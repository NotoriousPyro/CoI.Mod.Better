using CoI.Mod.Better.Extensions;
using CoI.Mod.Better.Utilities;
using Mafi;
using Mafi.Base;
using Mafi.Collections.ImmutableCollections;
using Mafi.Core;
using Mafi.Core.Mods;
using Mafi.Core.Population.Edicts;
using Mafi.Core.Prototypes;
using Mafi.Core.Research;
using Mafi.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace CoI.Mod.Better.Edicts
{
    internal partial class GenerelEdicts : IModData
    {

        private static void Cheats(ProtoRegistrator registrator)
        {
            // Add parent to my research CHEAT
            ResearchNodeProto parentResearch = registrator.PrototypesDb.GetOrThrow<ResearchNodeProto>(MyIDs.Research.VehicleCapIncreaseID_CHEAT);

            var costs = BetterMod.Config.Default.UnlockAllCheatsResearches ? 0 : BetterMod.Config.Default.CheatResearchCosts;

            var researchT1 = registrator.ResearchNodeProtoBuilder
                .Start("Generell Edict Cheat I", MyIDs.Research.GenerellEdictsResearchCheat_T1)
                .SetCosts(costs)
                .SetGridPosition(parentResearch.GridPosition + new Mafi.Vector2i(8, -4))
                .AddEdictToUnlock(
                    MyIDs.Eticts.Generell.UnityPointsT1_CHEAT, 
                    MyIDs.Eticts.Generell.ReduceServiceT1_CHEAT, 
                    MyIDs.Eticts.Generell.FarmMultiplierT1_CHEAT, 
                    MyIDs.Eticts.Generell.FarmWaterConsumMultiplierT1_CHEAT, 
                    MyIDs.Eticts.Generell.RecyclingRatioDiffT1_CHEAT, 
                    MyIDs.Eticts.Generell.SolarPowerT1_CHEAT
                )
                .BuildAndAdd();
            var researchT2 = registrator.ResearchNodeProtoBuilder
                .Start("Generell Edict Cheat II", MyIDs.Research.GenerellEdictsResearchCheat_T2)
                .SetCosts(costs)
                .SetGridPosition(researchT1.GridPosition + new Mafi.Vector2i(4, 0))
                .AddParents(researchT1)
                .AddEdictToUnlock(
                    MyIDs.Eticts.Generell.UnityPointsT2_CHEAT, 
                    MyIDs.Eticts.Generell.ReduceServiceT2_CHEAT, 
                    MyIDs.Eticts.Generell.FarmMultiplierT2_CHEAT,
                    MyIDs.Eticts.Generell.FarmWaterConsumMultiplierT2_CHEAT, 
                    MyIDs.Eticts.Generell.RecyclingRatioDiffT2_CHEAT,
                    MyIDs.Eticts.Generell.SolarPowerT2_CHEAT
                )
                .BuildAndAdd();
            var researchT3 = registrator.ResearchNodeProtoBuilder
                .Start("Generell Edict Cheat III", MyIDs.Research.GenerellEdictsResearchCheat_T3)
                .SetCosts(costs)
                .SetGridPosition(researchT2.GridPosition + new Mafi.Vector2i(4, 0))
                .AddParents(researchT2)
                .AddEdictToUnlock(
                    MyIDs.Eticts.Generell.UnityPointsT3_CHEAT, 
                    MyIDs.Eticts.Generell.ReduceServiceT3_CHEAT, 
                    MyIDs.Eticts.Generell.FarmMultiplierT3_CHEAT, 
                    MyIDs.Eticts.Generell.FarmWaterConsumMultiplierT3_CHEAT, 
                    MyIDs.Eticts.Generell.RecyclingRatioDiffT3_CHEAT,
                    MyIDs.Eticts.Generell.SolarPowerT3_CHEAT
                )
                .BuildAndAdd();
            var researchT4 = registrator.ResearchNodeProtoBuilder
                .Start("Generell Edict Cheat IV", MyIDs.Research.GenerellEdictsResearchCheat_T4)
                .SetCosts(costs)
                .SetGridPosition(researchT3.GridPosition + new Mafi.Vector2i(4, 0))
                .AddParents(researchT3)
                .AddEdictToUnlock(
                    MyIDs.Eticts.Generell.UnityPointsT4_CHEAT, 
                    MyIDs.Eticts.Generell.ReduceServiceT4_CHEAT, 
                    MyIDs.Eticts.Generell.FarmMultiplierT4_CHEAT, 
                    MyIDs.Eticts.Generell.FarmWaterConsumMultiplierT4_CHEAT, 
                    MyIDs.Eticts.Generell.RecyclingRatioDiffT4_CHEAT,
                    MyIDs.Eticts.Generell.SolarPowerT4_CHEAT
                )
                .BuildAndAdd();
            var researchT5 = registrator.ResearchNodeProtoBuilder
                .Start("Generell Edict Cheat V", MyIDs.Research.GenerellEdictsResearchCheat_T5)
                .SetCosts(costs)
                .SetGridPosition(researchT4.GridPosition + new Mafi.Vector2i(4, 0))
                .AddParents(researchT4)
                .AddEdictToUnlock(
                    MyIDs.Eticts.Generell.UnityPointsT5_CHEAT, 
                    MyIDs.Eticts.Generell.ReduceServiceT5_CHEAT, 
                    MyIDs.Eticts.Generell.FarmMultiplierT5_CHEAT, 
                    MyIDs.Eticts.Generell.FarmWaterConsumMultiplierT5_CHEAT, 
                    MyIDs.Eticts.Generell.RecyclingRatioDiffT5_CHEAT,
                    MyIDs.Eticts.Generell.SolarPowerT5_CHEAT
                )
                .BuildAndAdd();

            Debug.Log("BetterMod(V: " + BetterMod.MyVersion + ") >> GenerelEdicts >> Generell edict cheats created!");
        }
    }
}
