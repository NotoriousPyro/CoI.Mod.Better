using CoI.Mod.Better.Extensions;
using CoI.Mod.Better.lang;
using CoI.Mod.Better.Utilities;
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
    public partial class SteamStorages : IModData
    {
        private void GenerateResearch(ProtoRegistrator registrator)
        {
            string Name = LangManager.Instance.Get("research_steam_storage");

            ResearchNodeProto parentResearchT1 = registrator.PrototypesDb.GetOrThrow<ResearchNodeProto>(Ids.Research.PowerGeneration2);
            var researchT1 = registrator.ResearchNodeProtoBuilder
                .Start(Name + " I", MyIDs.Research.SteamStorageResearchT1)
                .SetCosts(new ResearchCostsTpl(BetterMod.Config.Storage.SteamResearchCostT1))
                .SetGridPosition(parentResearchT1.GridPosition + new Mafi.Vector2i(4, 20))
                .AddParents(parentResearchT1)
                .AddLayoutEntityToUnlock(MyIDs.Buildings.StorageSteamT1)
                .BuildAndAdd();
            var researchT2 = registrator.ResearchNodeProtoBuilder
                .Start(Name + " II", MyIDs.Research.SteamStorageResearchT2)
                .SetCosts(new ResearchCostsTpl(BetterMod.Config.Storage.SteamResearchCostT2))
                .SetGridPosition(researchT1.GridPosition + new Mafi.Vector2i(4, 0))
                .AddParents(researchT1)
                .AddLayoutEntityToUnlock(MyIDs.Buildings.StorageSteamT2)
                .BuildAndAdd();
            ResearchNodeProto parentResearchT2 = registrator.PrototypesDb.GetOrThrow<ResearchNodeProto>(Ids.Research.PowerGeneration3);
            var researchT3 = registrator.ResearchNodeProtoBuilder
                .Start(Name + " III", MyIDs.Research.SteamStorageResearchT3)
                .SetCosts(new ResearchCostsTpl(BetterMod.Config.Storage.SteamResearchCostT3))
                .SetGridPosition(parentResearchT2.GridPosition + new Mafi.Vector2i(4, 20))
                .AddParents(parentResearchT2)
                .AddLayoutEntityToUnlock(MyIDs.Buildings.StorageSteamT3)
                .BuildAndAdd();
            var researchT4 = registrator.ResearchNodeProtoBuilder
                .Start(Name + " IV", MyIDs.Research.SteamStorageResearchT4)
                .SetCosts(new ResearchCostsTpl(BetterMod.Config.Storage.SteamResearchCostT4))
                .SetGridPosition(researchT3.GridPosition + new Mafi.Vector2i(4, 0))
                .AddParents(researchT3)
                .AddLayoutEntityToUnlock(MyIDs.Buildings.StorageSteamT4)
                .BuildAndAdd();
        }
    }
}