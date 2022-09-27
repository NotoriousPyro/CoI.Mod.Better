using Mafi;
using Mafi.Core.Entities.Static.Layout;
using Mafi.Core.Mods;
using Mafi.Core.Prototypes;
using Mafi.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace CoI.Mod.Better.Custom.Data
{
    [Serializable]
    public class ToolbarData
    {
        public string ProtoID;

        public string Name;
        public int Order;

        public string IconPath;
        public bool isTransportBuildAllowed = true;
        public string ShortcutID;

        public void From(ToolbarCategoryProto toolbarCategoryProto)
        {
            ProtoID = toolbarCategoryProto.Id.ToString();
            Name = toolbarCategoryProto.Strings.Name.Id.ToString();
            Order = (int)toolbarCategoryProto.Order;
            IconPath = toolbarCategoryProto.IconPath;
            isTransportBuildAllowed = toolbarCategoryProto.IsTransportBuildAllowed;
            ShortcutID = toolbarCategoryProto.ShortcutId;

            if (ShortcutID == "")
            {
                ShortcutID = null;
            }
        }

        public Option<ToolbarCategoryProto> Into(ProtoRegistrator registrator)
        {
            ProtoID.CheckNotNullOrEmpty();
            if (ProtoID == null || ProtoID.IsEmpty())
            {
                Debug.Log("StorageData >> Into >> name: " + Name + " >> Toolbar cannot generate, ProtoID is not set!");
                return Option<ToolbarCategoryProto>.None;
            }

            Proto.ID protoID = new Proto.ID(ProtoID);
            Option<ToolbarCategoryProto> overrideProto = registrator.PrototypesDb.Get<ToolbarCategoryProto>(protoID);
            if (overrideProto.HasValue)
            {
                Debug.Log("TooblarData >> Into >> name: " + Name + " | id: " + protoID + " >> Toolbar cannot generate, ProtoID already exists!");
                return Option<ToolbarCategoryProto>.None;
            }

            Name.CheckNotNullOrEmpty();
            IconPath.CheckNotNullOrEmpty();
            Order.CheckNotNegative();

            if (ShortcutID == null)
            {
                ShortcutID = "";
            }

            Proto.Str strings;
            strings = new Proto.Str(Loc.Str(protoID.ToString() + "__name", protoID.ToString(), ""), LocStr.Empty);
            return Option<ToolbarCategoryProto>.Some(new ToolbarCategoryProto(
                        protoID,
                        strings,
                        Order,
                        IconPath,
                        isTransportBuildAllowed: isTransportBuildAllowed,
                        shortcutId: ShortcutID
                    ));
        }

        public void Build(ProtoRegistrator registrator)
        {
            Option<ToolbarCategoryProto> intoData = Into(registrator);
            if (!intoData.HasValue)
            {
                return;
            }

            registrator.PrototypesDb.Add(intoData.Value);
        }
    }
}