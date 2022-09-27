using Mafi.Base;
using Mafi.Core.Mods;
using Mafi.Core.Population.Edicts;
using Mafi.Core.Prototypes;
using Mafi.Core.Research;
using UnityEngine;

namespace CoI.Mod.Better.Edicts
{
    internal partial class GenerelEdicts : IModData
    {
        private float _cheatUpkeepEdicts = -0.5f;
        public static EdictCategoryProto Category;
        public static EdictCategoryProto CategoryCheats;

        public void RegisterData(ProtoRegistrator registrator)
        {
            if (!BetterMod.Config.Systems.GenerellEdicts) return;

            _cheatUpkeepEdicts = BetterMod.Config.Default.CheatUpkeepEdicts;
            Category = registrator.PrototypesDb.Add(new EdictCategoryProto(MyIDs.Eticts.BetterMod, Proto.CreateStr(MyIDs.Eticts.BetterMod, "Better mod")));
            CategoryCheats = registrator.PrototypesDb.Add(new EdictCategoryProto(MyIDs.Eticts.BetterModCheats, Proto.CreateStr(MyIDs.Eticts.BetterModCheats, "Better mod: Cheats")));

            AddUnityPoints(registrator);
            AddReduceService(registrator);
            AddFarmMultiplier(registrator);
            AddFarmWaterConsumMultiplier(registrator);
            AddRecyclingRatioDiff(registrator);
            AddSolarPower(registrator);

            GenerateResearch(registrator);
        }



        private void GenerateResearch(ProtoRegistrator registrator)
        {
            ResearchNodeProto parentResearch = registrator.PrototypesDb.GetOrThrow<ResearchNodeProto>(Ids.Research.CaptainsOffice);

            var researchT1 = registrator.ResearchNodeProtoBuilder
                .Start("Generell Edict I", MyIDs.Research.GenerellEdictsResearchT1)
                .SetCosts(new ResearchCostsTpl(BetterMod.Config.GenerellEdicts.ResearchCostT1))
                .SetGridPosition(parentResearch.GridPosition + new Mafi.Vector2i(4, 24))
                .AddParents(parentResearch)
                .BuildAndAdd();
            var researchT2 = registrator.ResearchNodeProtoBuilder
                .Start("Generell Edict II", MyIDs.Research.GenerellEdictsResearchT2)
                .SetCosts(new ResearchCostsTpl(BetterMod.Config.GenerellEdicts.ResearchCostT2))
                .SetGridPosition(researchT1.GridPosition + new Mafi.Vector2i(4, 0))
                .AddParents(researchT1)
                .BuildAndAdd();
            var researchT3 = registrator.ResearchNodeProtoBuilder
                .Start("Generell Edict III", MyIDs.Research.GenerellEdictsResearchT3)
                .SetCosts(new ResearchCostsTpl(BetterMod.Config.GenerellEdicts.ResearchCostT3))
                .SetGridPosition(researchT2.GridPosition + new Mafi.Vector2i(4, 0))
                .AddParents(researchT2)
                .BuildAndAdd();
            var researchT4 = registrator.ResearchNodeProtoBuilder
                .Start("Generell Edict IV", MyIDs.Research.GenerellEdictsResearchT4)
                .SetCosts(new ResearchCostsTpl(BetterMod.Config.GenerellEdicts.ResearchCostT4))
                .SetGridPosition(researchT3.GridPosition + new Mafi.Vector2i(4, 0))
                .AddParents(researchT3)
                .BuildAndAdd();
            var researchT5 = registrator.ResearchNodeProtoBuilder
                .Start("Generell Edict V", MyIDs.Research.GenerellEdictsResearchT5)
                .SetCosts(new ResearchCostsTpl(BetterMod.Config.GenerellEdicts.ResearchCostT5))
                .SetGridPosition(researchT4.GridPosition + new Mafi.Vector2i(4, 0))
                .AddParents(researchT4)
                .BuildAndAdd();

            Debug.Log("BetterMod(V: " + BetterMod.MyVersion + ") >> GenerelEdicts >> Generell Edict created!");

            if (BetterMod.Config.Systems.Cheats)
            {
                Cheats(registrator);
            }
        }
    }
}
