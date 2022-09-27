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
        private int countTruckCapEdicts = 1;
        private int countTruckFuelConsEdicts = 1;

        private const string translationComment = "policy / edict which can enabled by the player in their Captain's office.";
        private float CheatUpkeepEdicts = -0.5f;

        public void RegisterData(ProtoRegistrator registrator)
        {
            if (!BetterMod.Config.Systems.VehicleEdicts) return;

            CheatUpkeepEdicts = BetterMod.Config.Default.CheatUpkeepEdicts;

            AddTruckCap(registrator);
            AddTruckFuelCons(registrator);
            AddMaintenance(registrator);

            GenerateResearch(registrator);
        }

        private void GenerateResearch(ProtoRegistrator registrator)
        {
            ResearchNodeProto parentResearch = registrator.PrototypesDb.GetOrThrow<ResearchNodeProto>(Ids.Research.CaptainsOffice);

            var researchT1 = registrator.ResearchNodeProtoBuilder
                .Start("Vehicle Edict Plus I", MyIDs.Research.VehicleEdictsResearchT1)
                .SetCosts(new ResearchCostsTpl(BetterMod.Config.VehicleEdicts.ResearchCostT1))
                .SetGridPosition(parentResearch.GridPosition + new Mafi.Vector2i(4, 20))
                .AddParents(parentResearch)
                .AddEdictToUnlock(
                    MyIDs.Eticts.Trucks.CapacityIncT1,
                    MyIDs.Eticts.Trucks.FuelReductionT1,
                    MyIDs.Eticts.Trucks.MaintenanceReductionT1
                )
                .BuildAndAdd();
            var researchT2 = registrator.ResearchNodeProtoBuilder
                .Start("Vehicle Edict Plus II", MyIDs.Research.VehicleEdictsResearchT2)
                .SetCosts(new ResearchCostsTpl(BetterMod.Config.VehicleEdicts.ResearchCostT2))
                .SetGridPosition(researchT1.GridPosition + new Mafi.Vector2i(4, 0))
                .AddParents(researchT1)
                .AddEdictToUnlock(
                    MyIDs.Eticts.Trucks.CapacityIncT2,
                    MyIDs.Eticts.Trucks.FuelReductionT2,
                    MyIDs.Eticts.Trucks.MaintenanceReductionT2
                )
                .BuildAndAdd();
            var researchT3 = registrator.ResearchNodeProtoBuilder
                .Start("Vehicle Edict Plus III", MyIDs.Research.VehicleEdictsResearchT3)
                .SetCosts(new ResearchCostsTpl(BetterMod.Config.VehicleEdicts.ResearchCostT3))
                .SetGridPosition(researchT2.GridPosition + new Mafi.Vector2i(4, 0))
                .AddParents(researchT2)
                .AddEdictToUnlock(
                    MyIDs.Eticts.Trucks.CapacityIncT3,
                    MyIDs.Eticts.Trucks.FuelReductionT3,
                    MyIDs.Eticts.Trucks.MaintenanceReductionT3
                )
                .BuildAndAdd();
            var researchT4 = registrator.ResearchNodeProtoBuilder
                .Start("Vehicle Edict Plus IV", MyIDs.Research.VehicleEdictsResearchT4)
                .SetCosts(new ResearchCostsTpl(BetterMod.Config.VehicleEdicts.ResearchCostT4))
                .SetGridPosition(researchT3.GridPosition + new Mafi.Vector2i(4, 0))
                .AddParents(researchT3)
                .AddEdictToUnlock(
                    MyIDs.Eticts.Trucks.CapacityIncT4,
                    MyIDs.Eticts.Trucks.FuelReductionT4,
                    MyIDs.Eticts.Trucks.MaintenanceReductionT4
                )
                .BuildAndAdd();
            var researchT5 = registrator.ResearchNodeProtoBuilder
                .Start("Vehicle Edict Plus V", MyIDs.Research.VehicleEdictsResearchT5)
                .SetCosts(new ResearchCostsTpl(BetterMod.Config.VehicleEdicts.ResearchCostT5))
                .SetGridPosition(researchT4.GridPosition + new Mafi.Vector2i(4, 0))
                .AddParents(researchT4)
                .BuildAndAdd();

            Debug.Log("BetterMod(V: " + BetterMod.MyVersion + ") >> VehicleEdicts >> Vehicle Edict created!");

            if (BetterMod.Config.Systems.Cheats)
            {
                Cheats(registrator);
            }
        }
    }
}
