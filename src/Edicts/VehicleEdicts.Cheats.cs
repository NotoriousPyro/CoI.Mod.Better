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
    internal partial class VehicleEdicts : IModData
    {
        private static void Cheats(ProtoRegistrator registrator)
        {
            ResearchNodeProto parentResearch = registrator.PrototypesDb.GetOrThrow<ResearchNodeProto>(MyIDs.Research.VehicleCapIncreaseID_CHEAT);

            var costs = BetterMod.Config.Default.UnlockAllCheatsResearches ? 0 : BetterMod.Config.Default.CheatResearchCosts;

            var researchT1 = registrator.ResearchNodeProtoBuilder
                .Start("Vehicle Edict Cheat I", MyIDs.Research.VehicleEdictsResearchCheat_T1)
                .SetCosts(costs)
                .SetGridPosition(parentResearch.GridPosition + new Mafi.Vector2i(8, 8))
                .AddEdictToUnlock(
                    MyIDs.Eticts.Trucks.CapacityIncT1_CHEAT,
                    MyIDs.Eticts.Trucks.FuelReductionT1_CHEAT,
                    MyIDs.Eticts.Trucks.MaintenanceReductionT1_CHEAT
                )
                .BuildAndAdd();
            var researchT2 = registrator.ResearchNodeProtoBuilder
                .Start("Vehicle Edict Cheat II", MyIDs.Research.VehicleEdictsResearchCheat_T2)
                .SetCosts(costs)
                .SetGridPosition(researchT1.GridPosition + new Mafi.Vector2i(4, 0))
                .AddParents(researchT1)
                .AddEdictToUnlock(
                    MyIDs.Eticts.Trucks.CapacityIncT2_CHEAT,
                    MyIDs.Eticts.Trucks.FuelReductionT2_CHEAT,
                    MyIDs.Eticts.Trucks.MaintenanceReductionT2_CHEAT
                )
                .BuildAndAdd();
            var researchT3 = registrator.ResearchNodeProtoBuilder
                .Start("Vehicle Edict Cheat III", MyIDs.Research.VehicleEdictsResearchCheat_T3)
                .SetCosts(costs)
                .SetGridPosition(researchT2.GridPosition + new Mafi.Vector2i(4, 0))
                .AddParents(researchT2)
                .AddEdictToUnlock(
                    MyIDs.Eticts.Trucks.CapacityIncT3_CHEAT,
                    MyIDs.Eticts.Trucks.FuelReductionT3_CHEAT,
                    MyIDs.Eticts.Trucks.MaintenanceReductionT3_CHEAT
                )
                .BuildAndAdd();
            var researchT4 = registrator.ResearchNodeProtoBuilder
                .Start("Vehicle Edict Cheat IV", MyIDs.Research.VehicleEdictsResearchCheat_T4)
                .SetCosts(costs)
                .SetGridPosition(researchT3.GridPosition + new Mafi.Vector2i(4, 0))
                .AddParents(researchT3)
                .AddEdictToUnlock(
                    MyIDs.Eticts.Trucks.CapacityIncT4_CHEAT,
                    MyIDs.Eticts.Trucks.FuelReductionT4_CHEAT,
                    MyIDs.Eticts.Trucks.MaintenanceReductionT4_CHEAT
                )
                .BuildAndAdd();
            var researchT5 = registrator.ResearchNodeProtoBuilder
                .Start("Vehicle Edict Cheat V", MyIDs.Research.VehicleEdictsResearchCheat_T5)
                .SetCosts(costs)
                .SetGridPosition(researchT4.GridPosition + new Mafi.Vector2i(4, 0))
                .AddParents(researchT4)
                .AddEdictToUnlock(
                    MyIDs.Eticts.Trucks.CapacityIncT5_CHEAT
                )
                .BuildAndAdd();

            Debug.Log("BetterMod(V: " + BetterMod.MyVersion + ") >> VehicleEdicts >> Vehicle Edict cheats created!");
        }
    }
}
