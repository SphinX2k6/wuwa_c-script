using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000814 RID: 2068
	[UnrealObjectPath("/Script/Engine.AnimNode_AssetPlayerBase")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 88)]
	public class FAnimNode_AssetPlayerBase : FAnimNode_Base, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06006F33 RID: 28467 RVA: 0x0009F9B8 File Offset: 0x0009DBB8
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimNode_AssetPlayerBase._ScriptStructPtr != 0) ? FAnimNode_AssetPlayerBase._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.AnimNode_AssetPlayerBase", ref FAnimNode_AssetPlayerBase._ScriptStructPtr);
		}

		// Token: 0x17001A2B RID: 6699
		// (get) Token: 0x06006F34 RID: 28468 RVA: 0x0009F9DC File Offset: 0x0009DBDC
		// (set) Token: 0x06006F35 RID: 28469 RVA: 0x0009F9F0 File Offset: 0x0009DBF0
		public unsafe FName GroupName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_AssetPlayerBase.__PropertyOffset_GroupName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_AssetPlayerBase.__PropertyOffset_GroupName) = value;
			}
		}

		// Token: 0x17001A2C RID: 6700
		// (get) Token: 0x06006F36 RID: 28470 RVA: 0x0009FA05 File Offset: 0x0009DC05
		// (set) Token: 0x06006F37 RID: 28471 RVA: 0x0009FA19 File Offset: 0x0009DC19
		public unsafe TEnumAsByte<EAnimGroupRole> GroupRole
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_AssetPlayerBase.__PropertyOffset_GroupRole);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_AssetPlayerBase.__PropertyOffset_GroupRole) = value;
			}
		}

		// Token: 0x17001A2D RID: 6701
		// (get) Token: 0x06006F38 RID: 28472 RVA: 0x0009FA2E File Offset: 0x0009DC2E
		// (set) Token: 0x06006F39 RID: 28473 RVA: 0x0009FA3E File Offset: 0x0009DC3E
		public unsafe EAnimSyncGroupScope GroupScope
		{
			get
			{
				return (EAnimSyncGroupScope)(*(base.NativePtr + (IntPtr)FAnimNode_AssetPlayerBase.__PropertyOffset_GroupScope));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_AssetPlayerBase.__PropertyOffset_GroupScope) = (byte)value;
			}
		}

		// Token: 0x17001A2E RID: 6702
		// (get) Token: 0x06006F3A RID: 28474 RVA: 0x0009FA4F File Offset: 0x0009DC4F
		// (set) Token: 0x06006F3B RID: 28475 RVA: 0x0009FA5F File Offset: 0x0009DC5F
		public unsafe bool bIgnoreForRelevancyTest
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_AssetPlayerBase.__PropertyOffset_bIgnoreForRelevancyTest) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_AssetPlayerBase.__PropertyOffset_bIgnoreForRelevancyTest) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001A2F RID: 6703
		// (get) Token: 0x06006F3C RID: 28476 RVA: 0x0009FA70 File Offset: 0x0009DC70
		// (set) Token: 0x06006F3D RID: 28477 RVA: 0x0009FA80 File Offset: 0x0009DC80
		public unsafe float BlendWeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_AssetPlayerBase.__PropertyOffset_BlendWeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_AssetPlayerBase.__PropertyOffset_BlendWeight) = value;
			}
		}

		// Token: 0x17001A30 RID: 6704
		// (get) Token: 0x06006F3E RID: 28478 RVA: 0x0009FA91 File Offset: 0x0009DC91
		// (set) Token: 0x06006F3F RID: 28479 RVA: 0x0009FAA1 File Offset: 0x0009DCA1
		public unsafe float InternalTimeAccumulator
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_AssetPlayerBase.__PropertyOffset_InternalTimeAccumulator);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_AssetPlayerBase.__PropertyOffset_InternalTimeAccumulator) = value;
			}
		}

		// Token: 0x17001A31 RID: 6705
		// (get) Token: 0x06006F40 RID: 28480 RVA: 0x0009FAB2 File Offset: 0x0009DCB2
		// (set) Token: 0x06006F41 RID: 28481 RVA: 0x0009FAC2 File Offset: 0x0009DCC2
		public unsafe float CachedSequenceLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_AssetPlayerBase.__PropertyOffset_CachedSequenceLength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_AssetPlayerBase.__PropertyOffset_CachedSequenceLength) = value;
			}
		}

		// Token: 0x17001A32 RID: 6706
		// (get) Token: 0x06006F42 RID: 28482 RVA: 0x0009FAD3 File Offset: 0x0009DCD3
		// (set) Token: 0x06006F43 RID: 28483 RVA: 0x0009FAE3 File Offset: 0x0009DCE3
		public unsafe float CachedRateScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_AssetPlayerBase.__PropertyOffset_CachedRateScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_AssetPlayerBase.__PropertyOffset_CachedRateScale) = value;
			}
		}

		// Token: 0x17001A33 RID: 6707
		// (get) Token: 0x06006F44 RID: 28484 RVA: 0x0009FAF4 File Offset: 0x0009DCF4
		// (set) Token: 0x06006F45 RID: 28485 RVA: 0x0009FB04 File Offset: 0x0009DD04
		public unsafe bool bUseSoftRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_AssetPlayerBase.__PropertyOffset_bUseSoftRef) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_AssetPlayerBase.__PropertyOffset_bUseSoftRef) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001A34 RID: 6708
		// (get) Token: 0x06006F46 RID: 28486 RVA: 0x0009FB15 File Offset: 0x0009DD15
		// (set) Token: 0x06006F47 RID: 28487 RVA: 0x0009FB29 File Offset: 0x0009DD29
		[Nullable(1)]
		public unsafe string AnimationName
		{
			[NullableContext(1)]
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FAnimNode_AssetPlayerBase.__PropertyOffset_AnimationName)));
			}
			[NullableContext(1)]
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FAnimNode_AssetPlayerBase.__PropertyOffset_AnimationName)), value);
			}
		}

		// Token: 0x06006F48 RID: 28488 RVA: 0x0009FB3E File Offset: 0x0009DD3E
		public FAnimNode_AssetPlayerBase()
		{
		}

		// Token: 0x06006F49 RID: 28489 RVA: 0x0009FB48 File Offset: 0x0009DD48
		public FAnimNode_AssetPlayerBase(FName GroupName, int GroupIndex_DEPRECATED, TEnumAsByte<EAnimGroupRole> GroupRole, EAnimSyncGroupScope GroupScope, bool bIgnoreForRelevancyTest, float BlendWeight, float InternalTimeAccumulator, float CachedSequenceLength, float CachedRateScale, bool bUseSoftRef, [Nullable(1)] string AnimationName)
		{
			this.GroupName = GroupName;
			this.GroupRole = GroupRole;
			this.GroupScope = GroupScope;
			this.bIgnoreForRelevancyTest = bIgnoreForRelevancyTest;
			this.BlendWeight = BlendWeight;
			this.InternalTimeAccumulator = InternalTimeAccumulator;
			this.CachedSequenceLength = CachedSequenceLength;
			this.CachedRateScale = CachedRateScale;
			this.bUseSoftRef = bUseSoftRef;
			this.AnimationName = AnimationName;
		}

		// Token: 0x06006F4A RID: 28490 RVA: 0x0009FBA9 File Offset: 0x0009DDA9
		protected override IntPtr GetUStructPtr()
		{
			return FAnimNode_AssetPlayerBase.StaticStruct();
		}

		// Token: 0x06006F4B RID: 28491 RVA: 0x0009FBB5 File Offset: 0x0009DDB5
		[NullableContext(2)]
		public FAnimNode_AssetPlayerBase(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006F4C RID: 28492 RVA: 0x0009FBBF File Offset: 0x0009DDBF
		public FAnimNode_AssetPlayerBase(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06006F4D RID: 28493 RVA: 0x0009FBCA File Offset: 0x0009DDCA
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimNode_AssetPlayerBase(Pointer, false, true);
		}

		// Token: 0x06006F4E RID: 28494 RVA: 0x0009FBD4 File Offset: 0x0009DDD4
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimNode_AssetPlayerBase(Pointer, MemoryOwner);
		}

		// Token: 0x04003575 RID: 13685
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.AnimNode_AssetPlayerBase";

		// Token: 0x04003576 RID: 13686
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003577 RID: 13687
		internal static int __PropertyOffset_GroupName;

		// Token: 0x04003578 RID: 13688
		internal static int __PropertyOffset_GroupRole;

		// Token: 0x04003579 RID: 13689
		internal static int __PropertyOffset_GroupScope;

		// Token: 0x0400357A RID: 13690
		internal static int __PropertyOffset_bIgnoreForRelevancyTest;

		// Token: 0x0400357B RID: 13691
		internal static int __PropertyOffset_BlendWeight;

		// Token: 0x0400357C RID: 13692
		internal static int __PropertyOffset_InternalTimeAccumulator;

		// Token: 0x0400357D RID: 13693
		internal static int __PropertyOffset_CachedSequenceLength;

		// Token: 0x0400357E RID: 13694
		internal static int __PropertyOffset_CachedRateScale;

		// Token: 0x0400357F RID: 13695
		internal static int __PropertyOffset_bUseSoftRef;

		// Token: 0x04003580 RID: 13696
		internal static int __PropertyOffset_AnimationName;
	}
}
