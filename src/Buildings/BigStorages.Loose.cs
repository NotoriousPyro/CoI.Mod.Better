﻿using CoI.Mod.Better.lang;
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
using Mafi.Localization;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace CoI.Mod.Better.Buildings
{
    internal partial class BigStorages : IModData
    {

        #region Loose Storages Override
        private void LooseStoragesT1(ProtoRegistrator registrator)
        {            
            // Set proto ids
            StaticEntityProto.ID protoID = MyIDs.Buildings.StorageLooseT1;
            StaticEntityProto.ID protoNextTier = MyIDs.Buildings.StorageLooseT2;

            // Generate LocStr
            string Name = LangManager.Instance.Get("loose_storage");
            string desc = LangManager.Instance.Get("loose_storage_desc", capacity_T1.ToString());

            // Add new to Database
            var creator = registrator.StorageProtoBuilder.Start(Name + " I", protoID)
                .Description(desc)
                .SetCost(Costs.Buildings.StorageLoose)
                .SetNextTier(registrator.PrototypesDb.GetOrThrow<StorageProto>(protoNextTier))
                .SetCapacity(capacity_T1)
                .SetProductsFilter(ProductUtility.ProductFilter)
                .SetLayout("   [5][5][5][5][5]   ", " ~ >5A[5][5][5]X5> ~ ", "   [5][5][5][5][5]   ", " ~ >5B[5][5][5]Y5> ~ ", "   [5][5][5][5][5]   ")
                .SetPrefabPath("Assets/Base/Buildings/Storages/LooseT1.prefab")
                .SetPileGfxParams("Pile_Soft", "Pile_Soft", new LoosePileTextureParams(1.4f));

            creator.SetCustomIconPath(registrator.PrototypesDb.GetOrThrow<StorageProto>(Ids.Buildings.StorageLoose).Graphics.IconPath);
            creator = SetCategory(creator);
            ProductUtility.SetTransferLimitByT(creator, 1).BuildAsLooseAndAdd();

            Debug.Log("BetterMod(V: " + BetterMod.MyVersion + ") >> BigStorages >> LooseStoragesT1 >> created!");
        }

        private void LooseStoragesT2(ProtoRegistrator registrator)
        {            
            // Set proto ids
            StaticEntityProto.ID protoID = MyIDs.Buildings.StorageLooseT2;

            // Generate LocStr
            string Name = LangManager.Instance.Get("loose_storage");
            string desc = LangManager.Instance.Get("loose_storage_desc", capacity_T2.ToString());

            // Add new to Database
            var creator = registrator.StorageProtoBuilder.Start(Name + " II", protoID)
                .Description(desc)
                .SetCost(Costs.Buildings.StorageLooseT2)
                .SetCapacity(capacity_T2)
                .SetProductsFilter(ProductUtility.ProductFilter)
                .SetLayout("   [6][6][6][6][6]   ", " ~ >6A[6][6][6]X6> ~ ", "   [6][6][6][6][6]   ", " ~ >6B[6][6][6]Y6> ~ ", "   [6][6][6][6][6]   ")
                .SetPrefabPath("Assets/Base/Buildings/Storages/LooseT2.prefab")
                .SetPileGfxParams("Pile_Soft", "Pile_Soft", new LoosePileTextureParams(0.3f));

            creator.SetCustomIconPath(registrator.PrototypesDb.GetOrThrow<StorageProto>(Ids.Buildings.StorageLooseT2).Graphics.IconPath);
            creator = SetCategory(creator);
            ProductUtility.SetTransferLimitByT(creator, 2).BuildAsLooseAndAdd();
            Debug.Log("BetterMod(V: " + BetterMod.MyVersion + ") >> BigStorages >> LooseStoragesT2 >> created!");
        }

        private void LooseStoragesT3(ProtoRegistrator registrator)
        {
            // Set proto ids
            StaticEntityProto.ID protoID = MyIDs.Buildings.StorageLooseT3;
            StaticEntityProto.ID protoNextTier = MyIDs.Buildings.StorageLooseT4;

            // Generate LocStr
            string Name = LangManager.Instance.Get("loose_storage");
            string desc = LangManager.Instance.Get("loose_storage_desc", capacity_T3.ToString());

            // Add new to Database
            var creator = registrator.StorageProtoBuilder.Start(Name + " III", protoID)
                .Description(desc)
                .SetCost(Costs.Buildings.StorageLooseT3)
                .SetNextTier(registrator.PrototypesDb.GetOrThrow<StorageProto>(protoNextTier))
                .SetCapacity(capacity_T3)
                .SetProductsFilter(ProductUtility.ProductFilter)
                .SetLayout("      [6][6][6][6][6][6][6][6]      ", " ~ >6A[6][6][6][6][6][6][6][6]X6> ~ ", "   [6][6][6][6][6][6][6][6][6][6]   ", " ~ >6B[6][6][6][6][6][6][6][6]Y6> ~ ", "   [7][7][7][7][6][6][6][6][6][6]   ", "   [7][7][7][7][6][6][6][6][6][6]   ", " ~ >6C[6][6][6][6][6][6][6][6]Z6> ~ ", "   [6][6][6][6][6][6][6][6][6][6]   ", " ~ >6D[6][6][6][6][6][6][6][6]W6> ~ ", "      [6][6][6][6][6][6][6][6]      ")
                .SetPrefabPath("Assets/Base/Buildings/Storages/LooseT3.prefab")
                .SetPileGfxParams("Pile_Soft", "Pile_Soft", new LoosePileTextureParams(0.2f));

            creator.SetCustomIconPath(registrator.PrototypesDb.GetOrThrow<StorageProto>(Ids.Buildings.StorageLooseT3).Graphics.IconPath);
            creator = SetCategory(creator);
            ProductUtility.SetTransferLimitByT(creator, 3).BuildAsLooseAndAdd();
            Debug.Log("BetterMod(V: " + BetterMod.MyVersion + ") >> BigStorages >> LooseStoragesT3 >> created!");
        }

        private void LooseStoragesT4(ProtoRegistrator registrator)
        {            
            // Set proto ids
            StaticEntityProto.ID protoID = MyIDs.Buildings.StorageLooseT4;

            // Generate LocStr
            string Name = LangManager.Instance.Get("loose_storage");
            string desc = LangManager.Instance.Get("loose_storage_desc", capacity_T4.ToString());

            // Add new to Database
            var creator = registrator.StorageProtoBuilder.Start(Name + " IV", protoID)
                .Description(desc)
                .SetCost(Costs.Buildings.StorageLooseT4)
                .SetCapacity(capacity_T4)
                .SetProductsFilter(ProductUtility.ProductFilter)
                .SetLayout(new EntityLayoutParams(null, useNewLayoutSyntax: false, new CustomLayoutToken[1]
                {
                    new CustomLayoutToken("[0!", delegate(EntityLayoutParams p, int h)
                    {
                        int heightToExcl = h + 1;
                        int? terrainSurfaceHeight = 0;
                        Proto.ID? surfaceId = p.HardenedFloorSurfaceId;
                        return new LayoutTokenSpec(0, heightToExcl, LayoutTileConstraint.None, terrainSurfaceHeight, null, null, null, null, surfaceId);
                    })
                }), "      [9][9][9][9][9][9][9][9]      ", " ~ >9A[9][9][9][9][9][9][9][9]X9> ~ ", "   [9][9][9][9][9][9][9][9][9][9]   ", " ~ >9B[9][9][9][9][9][9][9][9]Y9> ~ ", "   [9![9![9![9![9][9][9][9][9][9]   ", "   [9![9![9![9![9][9][9][9][9][9]   ", " ~ >9C[9][9][9][9][9][9][9][9]Z9> ~ ", "   [9][9][9][9][9][9][9][9][9][9]   ", " ~ >9D[9][9][9][9][9][9][9][9]W9> ~ ", "      [9][9][9][9][9][9][9][9]      ")
                .SetPrefabPath("Assets/Base/Buildings/Storages/LooseT4.prefab")
                .SetPileGfxParams("Pile_Soft", "Pile_Soft", new LoosePileTextureParams(0.2f));

            creator.SetCustomIconPath(registrator.PrototypesDb.GetOrThrow<StorageProto>(Ids.Buildings.StorageLooseT4).Graphics.IconPath);
            creator = SetCategory(creator);
            ProductUtility.SetTransferLimitByT(creator, 4).BuildAsLooseAndAdd();
            Debug.Log("BetterMod(V: " + BetterMod.MyVersion + ") >> BigStorages >> LooseStoragesT4 >> created!");
        }

        #endregion

    }
}