using CoI.Mod.Better.Buildings;
using CoI.Mod.Better.Custom;
using CoI.Mod.Better.Edicts;
using CoI.Mod.Better.Extensions;
using CoI.Mod.Better.lang;
using CoI.Mod.Better.ModConfigs;
using CoI.Mod.Better.Research;
using CoI.Mod.Better.Utilities;
using Mafi;
using Mafi.Base;
using Mafi.Core;
using Mafi.Core.Buildings.Storages;
using Mafi.Core.Entities.Static.Layout;
using Mafi.Core.Game;
using Mafi.Core.Maintenance;
using Mafi.Core.Map;
using Mafi.Core.Mods;
using Mafi.Core.Prototypes;
using Mafi.Core.Research;
using Mafi.Core.Terrain.Generation;
using Mafi.Localization;
using Mafi.Serialization;
using Mafi.Unity;
using Mafi.Unity.UiFramework;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using UnityEngine;
using Mafi.Collections;

namespace CoI.Mod.Better
{

    public sealed class BetterMod : IMod
    {
        public void ChangeConfigs(Lyst<IConfig> configs) {}

        public string Name => "BetterMod";

        public int Version => 1;

        public bool IsUiOnly => false;

        public static ModConfigV2 Config = new ModConfigV2();

        public static readonly string ModRootDirPath = new FileSystemHelper().GetDirPath(FileType.Mod, false);
        public static readonly string ModDirPath = Path.Combine(ModRootDirPath, "CoI.Mod.Better");
        public static readonly string CustomsDirPath = Path.Combine(ModDirPath, "Customs");
        public static readonly string LangDirPath = Path.Combine(ModDirPath, "Lang");

        public const int UIStepSize = 4;
        public static readonly string MyVersion = typeof(BetterMod).Assembly.GetName().Version.ToString();

        static readonly GameVersion CurrentGameVersion = new GameVersion();
        static readonly GameVersion TargetGameVersion = new GameVersion("Early Access", "0", "4", "12", "");
        static bool isTargetedGameVersion => CurrentGameVersion.Equals(TargetGameVersion, true);

        public BetterMod() {}

        public void Initialize(DependencyResolver resolver, bool gameWasLoaded)
        {
            Debug.Log("BetterMod(V: " + MyVersion + ") mod was created!");

            ReflectionUtility.PrintAllProperties<CoreModConfig>(resolver);
            ReflectionUtility.PrintAllProperties<GameDifficultyConfig>(resolver);
            ReflectionUtility.PrintAllProperties<MaintenanceConfig>(resolver);
            ReflectionUtility.PrintAllProperties<IslandMapDifficultyConfig>(resolver);
            ReflectionUtility.PrintAllProperties<StaticIslandMapProviderConfig>(resolver);
            ReflectionUtility.PrintAllProperties<RandomSeedConfig>(resolver);
            ReflectionUtility.PrintAllProperties<TerrainGeneratorConfig>(resolver);
            ReflectionUtility.PrintAllProperties<IslandMapGeneratorConfig>(resolver);
            ReflectionUtility.PrintAllProperties<BaseModConfig>(resolver);
            ReflectionUtility.PrintAllProperties<StartingFactoryConfig>(resolver);
            ReflectionUtility.PrintAllProperties<UnityModConfig>(resolver);

            if (!gameWasLoaded && Config.StartSettings.OverrideStartSettings)
            {
                if (resolver.TryGetResolvedDependency(out CoreModConfig coreConfig))
                {
                    coreConfig.InitialVehiclesCap = Config.StartSettings.InitialVehiclesCap;
                    coreConfig.StartingPopulation = Config.StartSettings.StartingPopulation;
                    coreConfig.ShouldUnlockAllProtosOnInit = Config.StartSettings.UnlockAll;
                }
            }
            if (Config.GameSettings.OverrideGameConfig)
            {
                if (resolver.TryGetResolvedDependency(out CoreModConfig coreConfig))
                {
                    coreConfig.BaseRoundsToEscape = Config.GameSettings.BattleRoundsToEscape;
                    coreConfig.IsGodModeEnabled = Config.GameSettings.IsGodMode;
                    coreConfig.IsInstaBuildEnabled = Config.GameSettings.IsInstaBuild;
                    coreConfig.BaseRoundsToEscape = Config.GameSettings.BattleRoundsToEscape;
                    coreConfig.FreeElectricityPerTick = Config.GameSettings.FreeElectricity.Kw();
                }
            }
        }

        public void RegisterPrototypes(ProtoRegistrator registrator)
        {
            if (!isTargetedGameVersion)
            {
                Debug.LogWarning("###############################################################");
                Debug.LogWarning("####################### WARNING ###############################");
                Debug.LogWarning("###############################################################");
                Debug.LogWarning("BetterMod(V: " + MyVersion + ") >> This mod is not compatible with the current game version and can cause problems!!!");
                Debug.LogWarning("BetterMod(V: " + MyVersion + ") >> CurrentGameVersion: " + CurrentGameVersion.ToString());
                Debug.LogWarning("BetterMod(V: " + MyVersion + ") >> TargetGameVersion: " + TargetGameVersion.ToString());
                Debug.LogWarning("BetterMod(V: " + MyVersion + ") >> Check for updates: https://github.com/Wehmeyer100/CoI.Mod.Better/releases");
                Debug.LogWarning("###############################################################");
            }

            Debug.Log("BetterMod(V: " + MyVersion + ") Directories ..");
            Debug.Log(" - MOD_ROOT_DIR_PATH: " + ModRootDirPath);
            Debug.Log(" - MOD_DIR_PATH: " + ModDirPath);
            Debug.Log(" - CUSTOMS_DIR_PATH: " + CustomsDirPath);
            Debug.Log(" - LANG_DIR_PATH: " + LangDirPath);


            Debug.Log("BetterMod(V: " + MyVersion + ") Config loading..");
            LoadModConfig();


            // Init LangManager
            LangManager.Instance.Load();

            Debug.Log("BetterMod(V: " + MyVersion + ") RegisterPrototypes..");
            // Use data class registration to register other protos such as machines, recipes, etc.
            registrator.RegisterData<MyVehicleCapIncrease>();
            registrator.RegisterData<MineTower>();
            registrator.RegisterData<BigStorages>();
            registrator.RegisterData<Beacon>();
            registrator.RegisterData<GenerelEdicts>();
            registrator.RegisterData<VehicleEdicts>();
            registrator.RegisterData<VoidCrusher>();
            registrator.RegisterData<VoidProducer>();
            registrator.RegisterData<DieselGenerator>();
            registrator.RegisterData<PowerGenerators>();
            registrator.RegisterData<Customs>();
            registrator.RegisterData<SteamStorages>();


            // https://github.com/Wehmeyer100/CoI.Mod.Better/issues/22
            int offsetY = 50;
            foreach (ResearchNodeProto result in registrator.PrototypesDb.All<ResearchNodeProto>()) 
            {
                result.GridPosition += new Vector2i(0, offsetY);
            }
        }

        private static void LoadModConfig()
        {
            JsonSerializerSettings settings = new JsonSerializerSettings() { Formatting = Formatting.Indented, MaxDepth = 500, MissingMemberHandling = MissingMemberHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ReferenceLoopHandling = ReferenceLoopHandling.Serialize };

            string v4ConfigFile = ModDirPath + "/globalconfig4.json";
            string v5ConfigFile = ModDirPath + "/globalconfig5.json";
            var hasConfigV4 = File.Exists(v4ConfigFile);
            var hasConfigV5 = File.Exists(v5ConfigFile);

            if (hasConfigV5)
            {
                string content = File.ReadAllText(v5ConfigFile, Encoding.UTF8);
                Config = JsonConvert.DeserializeObject<ModConfigV2>(content, settings);
            }
            if (hasConfigV4 && !hasConfigV5)
            {
                Debug.Log("BetterMod(V: " + MyVersion + ") Config converting..");

                Config = new ModConfigV2();
                ModConfig oldConfig = new ModConfig();

                string content = File.ReadAllText(v4ConfigFile);
                JsonUtility.FromJsonOverwrite(content, oldConfig);

                File.Delete(v4ConfigFile);
                Config = ModConfigV2.ConvertConfig_4_to_5(oldConfig);
                Debug.Log("BetterMod(V: " + MyVersion + ") Config converted.");
            }

            File.WriteAllText(v5ConfigFile, JsonConvert.SerializeObject(Config, settings));
            Config.Print();
        }

        public void RegisterDependencies(DependencyResolverBuilder depBuilder, ProtosDb protosDb, bool gameWasLoaded)
        {

        }
    }
}
