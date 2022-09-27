using CoI.Mod.Better.Extensions;
using CoI.Mod.Better.lang;
using Mafi;
using Mafi.Base;
using Mafi.Core.Buildings.Storages;
using Mafi.Core.Entities.Static;
using Mafi.Core.Entities.Static.Layout;
using Mafi.Core.Factory;
using Mafi.Core.Mods;
using Mafi.Core.Products;
using Mafi.Core.Prototypes;
using Mafi.Core.Research;
using Mafi.Localization;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace CoI.Mod.Better.Buildings
{
    internal partial class BigStorages : IModData
    {
        private void GenerateResearch(ProtoRegistrator registrator)
        {
            Debug.Log("BetterMod(V: " + BetterMod.MyVersion + ") >> BigStorages >> GenerateResearches...");
            string Name = LangManager.Instance.Get("research_storage");
            ResearchNodeProto parentResearch = registrator.PrototypesDb.GetOrThrow<ResearchNodeProto>(MyIDs.Research.VehicleCapIncreaseID_ZERO);
            ResearchNodeProto t1Storage = registrator.PrototypesDb.GetOrThrow<ResearchNodeProto>(Ids.Research.StoragesT1);
            ResearchNodeProto t2Storage = registrator.PrototypesDb.GetOrThrow<ResearchNodeProto>(Ids.Research.Storage2);
            ResearchNodeProto t3Storage = registrator.PrototypesDb.GetOrThrow<ResearchNodeProto>(Ids.Research.Storage3);
            ResearchNodeProto t4Storage = registrator.PrototypesDb.GetOrThrow<ResearchNodeProto>(Ids.Research.Storage4);

            var researchT1 = registrator.ResearchNodeProtoBuilder
                .Start(Name + " I", MyIDs.Research.StorageResearchT1)
                .SetCosts(new ResearchCostsTpl(BetterMod.Config.Storage.ResearchCostT1))
                .SetGridPosition(new Mafi.Vector2i(0, parentResearch.GridPosition.Y + 8) + new Mafi.Vector2i(t1Storage.GridPosition.X, 0))
                .AddParents(parentResearch, t1Storage)
                .AddLayoutEntityToUnlock(MyIDs.Buildings.StorageFluidT1)
                .AddLayoutEntityToUnlock(MyIDs.Buildings.StorageLooseT1)
                .AddLayoutEntityToUnlock(MyIDs.Buildings.StorageUnitT1)
                .BuildAndAdd();
            var researchT2 = registrator.ResearchNodeProtoBuilder
                .Start(Name + " II", MyIDs.Research.StorageResearchT2)
                .SetCosts(new ResearchCostsTpl(BetterMod.Config.Storage.ResearchCostT2))
                .SetGridPosition(new Mafi.Vector2i(0, researchT1.GridPosition.Y) + new Mafi.Vector2i(t2Storage.GridPosition.X, 0))
                .AddParents(researchT1, t2Storage)
                .AddLayoutEntityToUnlock(MyIDs.Buildings.StorageFluidT2)
                .AddLayoutEntityToUnlock(MyIDs.Buildings.StorageLooseT2)
                .AddLayoutEntityToUnlock(MyIDs.Buildings.StorageUnitT2)
                .BuildAndAdd();
            var researchT3 = registrator.ResearchNodeProtoBuilder
                .Start(Name + " III", MyIDs.Research.StorageResearchT3)
                .SetCosts(new ResearchCostsTpl(BetterMod.Config.Storage.ResearchCostT3))
                .SetGridPosition(new Mafi.Vector2i(0, researchT2.GridPosition.Y) + new Mafi.Vector2i(t3Storage.GridPosition.X, 0))
                .AddParents(researchT2, t3Storage)
                .AddLayoutEntityToUnlock(MyIDs.Buildings.StorageFluidT3)
                .AddLayoutEntityToUnlock(MyIDs.Buildings.StorageLooseT3)
                .AddLayoutEntityToUnlock(MyIDs.Buildings.StorageUnitT3)
                .BuildAndAdd();
            var researchT4 = registrator.ResearchNodeProtoBuilder
                .Start(Name + " IV", MyIDs.Research.StorageResearchT4)
                .SetCosts(new ResearchCostsTpl(BetterMod.Config.Storage.ResearchCostT4))
                .SetGridPosition(new Mafi.Vector2i(0, researchT3.GridPosition.Y) + new Mafi.Vector2i(t4Storage.GridPosition.X, 0))
                .AddParents(researchT3, t4Storage)
                .AddLayoutEntityToUnlock(MyIDs.Buildings.StorageFluidT4)
                .AddLayoutEntityToUnlock(MyIDs.Buildings.StorageLooseT4)
                .AddLayoutEntityToUnlock(MyIDs.Buildings.StorageUnitT4)
                .BuildAndAdd();
            // var researchT5 = registrator.ResearchNodeProtoBuilder
            //     .Start(Name + " V", MyIDs.Research.StorageResearchT5)
            //     .SetCosts(new ResearchCostsTpl(BetterMod.Config.Storage.ResearchCostT5))
            //     .SetGridPosition(researchT4.GridPosition + new Mafi.Vector2i(4, 0))
            //     .AddParents(researchT4)
            //     .AddLayoutEntityToUnlock(MyIDs.Buildings.NuclearWasteStorage)
            //     .BuildAndAdd();

            Debug.Log("BetterMod(V: " + BetterMod.MyVersion + ") >> BigStorages >> GenerateResearches... done.");
        }

        // private void GenerateResearchT5(ProtoRegistrator registrator)
        // {
        //     ResearchNodeProto.ID storageResearch = MyIDs.Research.StorageResearchT5;

        //     LocStr1 locStr = Loc.Str1(storageResearch.ToString() + "__desc", "Unlock Storages T5", "");
        //     LocStr desc = LocalizationManager.CreateAlreadyLocalizedStr(storageResearch.ToString() + "_formatted", "");

        //     ResearchNodeProtoBuilder.State result = registrator.ResearchNodeProtoBuilder
        //         .Start("Storage T5", storageResearch)
        //         .Description(desc)
        //         .AddLayoutEntityToUnlock(MyIDs.Buildings.NuclearWasteStorage);

        //     if (BetterMod.Config.Default.UnlockAllCheatsResearches)
        //     {
        //         result.SetCostsFree();
        //     }
        //     else
        //     {
        //         result.SetCosts(20);
        //     }

        //     result
        //         .BuildAndAdd()
        //         .AddParentPlusGridPos(registrator.PrototypesDb.GetOrThrow<ResearchNodeProto>(MyIDs.Research.StorageResearchT4));

        //     Debug.Log("BigStorages >> GenerateResearchT5 >> created!");
        // }

    }
}