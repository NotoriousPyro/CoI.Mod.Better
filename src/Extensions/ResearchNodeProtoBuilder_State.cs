﻿using Mafi;
using Mafi.Core.Entities.Static;
using Mafi.Core.Entities.Static.Layout;
using Mafi.Core.Population.Edicts;
using Mafi.Core.Prototypes;
using Mafi.Core.Research;
using Mafi.Core.UnlockingTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CoI.Mod.Better.Extensions
{
    public static class ResearchNodeProtoBuilder_State
    {

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ResearchNodeProtoBuilder.State SetCosts(this ResearchNodeProtoBuilder.State state, int ResearchCost)
        {
            return state.SetCosts(new ResearchCostsTpl(ResearchCost));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ResearchNodeProtoBuilder.State SetCostsOne(this ResearchNodeProtoBuilder.State state)
        {
            return state.SetCosts(1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ResearchNodeProtoBuilder.State SetCostsFree(this ResearchNodeProtoBuilder.State state)
        {
            return state.SetCosts(0);
        }

        public static ResearchNodeProtoBuilder.State AddEdictToUnlock(this ResearchNodeProtoBuilder.State builderState, params Proto.ID[] protoIDs)
        {
            foreach (Proto.ID protoId in protoIDs)
            {
                EdictProto orThrow = builderState.Builder.ProtosDb.GetOrThrow<EdictProto>(protoId);
                builderState.AddIcon(orThrow, orThrow.Graphics.IconPath);
                builderState.AddUnit(new EdictUnlock(orThrow));
            }
            return builderState;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ResearchNodeProto AddParentPlusGridPos(this ResearchNodeProto builder, ResearchNodeProto parentProto, int ui_stepSize_x = BetterMod.UIStepSize, int ui_stepSize_y = 0)
        {
            builder.AddGridPos(parentProto, ui_stepSize_x, ui_stepSize_y);
            builder.AddParent(parentProto);
            return builder;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ResearchNodeProto AddGridPos(this ResearchNodeProto builder, ResearchNodeProto parentProto, int ui_stepSize_x = BetterMod.UIStepSize, int ui_stepSize_y = 0)
        {
            builder.GridPosition = parentProto.GridPosition + new Vector2i(ui_stepSize_x, ui_stepSize_y);
            return builder;
        }
    }
}
