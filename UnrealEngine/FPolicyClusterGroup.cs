using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001018 RID: 4120
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.PolicyClusterGroup")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 96)]
	public class FPolicyClusterGroup : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600E15F RID: 57695 RVA: 0x0014B411 File Offset: 0x00149611
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPolicyClusterGroup._ScriptStructPtr != 0) ? FPolicyClusterGroup._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.PolicyClusterGroup", ref FPolicyClusterGroup._ScriptStructPtr);
		}

		// Token: 0x170034F1 RID: 13553
		// (get) Token: 0x0600E160 RID: 57696 RVA: 0x0014B435 File Offset: 0x00149635
		// (set) Token: 0x0600E161 RID: 57697 RVA: 0x0014B445 File Offset: 0x00149645
		public unsafe uint RecommendActorSetSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPolicyClusterGroup.__PropertyOffset_RecommendActorSetSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPolicyClusterGroup.__PropertyOffset_RecommendActorSetSize) = (int)value;
			}
		}

		// Token: 0x170034F2 RID: 13554
		// (get) Token: 0x0600E162 RID: 57698 RVA: 0x0014B456 File Offset: 0x00149656
		// (set) Token: 0x0600E163 RID: 57699 RVA: 0x0014B466 File Offset: 0x00149666
		public unsafe int ActorSetSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPolicyClusterGroup.__PropertyOffset_ActorSetSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPolicyClusterGroup.__PropertyOffset_ActorSetSize) = value;
			}
		}

		// Token: 0x170034F3 RID: 13555
		// (get) Token: 0x0600E164 RID: 57700 RVA: 0x0014B477 File Offset: 0x00149677
		// (set) Token: 0x0600E165 RID: 57701 RVA: 0x0014B487 File Offset: 0x00149687
		public unsafe uint RecommendCellSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPolicyClusterGroup.__PropertyOffset_RecommendCellSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPolicyClusterGroup.__PropertyOffset_RecommendCellSize) = (int)value;
			}
		}

		// Token: 0x170034F4 RID: 13556
		// (get) Token: 0x0600E166 RID: 57702 RVA: 0x0014B498 File Offset: 0x00149698
		// (set) Token: 0x0600E167 RID: 57703 RVA: 0x0014B4A8 File Offset: 0x001496A8
		public unsafe int CellSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPolicyClusterGroup.__PropertyOffset_CellSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPolicyClusterGroup.__PropertyOffset_CellSize) = value;
			}
		}

		// Token: 0x170034F5 RID: 13557
		// (get) Token: 0x0600E168 RID: 57704 RVA: 0x0014B4BC File Offset: 0x001496BC
		// (set) Token: 0x0600E169 RID: 57705 RVA: 0x0014B4FF File Offset: 0x001496FF
		public FSoftObjectPath HLODLayer
		{
			get
			{
				base.FastCheckIsValid();
				FSoftObjectPath result;
				if ((result = this._HLODLayer) == null)
				{
					result = (this._HLODLayer = new FSoftObjectPath(base.NativePtr + (IntPtr)FPolicyClusterGroup.__PropertyOffset_HLODLayer, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)FPolicyClusterGroup.__PropertyOffset_HLODLayer, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170034F6 RID: 13558
		// (get) Token: 0x0600E16A RID: 57706 RVA: 0x0014B520 File Offset: 0x00149720
		// (set) Token: 0x0600E16B RID: 57707 RVA: 0x0014B563 File Offset: 0x00149763
		public FSoftObjectPath RockHLODLayer
		{
			get
			{
				base.FastCheckIsValid();
				FSoftObjectPath result;
				if ((result = this._RockHLODLayer) == null)
				{
					result = (this._RockHLODLayer = new FSoftObjectPath(base.NativePtr + (IntPtr)FPolicyClusterGroup.__PropertyOffset_RockHLODLayer, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)FPolicyClusterGroup.__PropertyOffset_RockHLODLayer, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170034F7 RID: 13559
		// (get) Token: 0x0600E16C RID: 57708 RVA: 0x0014B584 File Offset: 0x00149784
		// (set) Token: 0x0600E16D RID: 57709 RVA: 0x0014B594 File Offset: 0x00149794
		public unsafe float LoadingRangeScaleFactor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPolicyClusterGroup.__PropertyOffset_LoadingRangeScaleFactor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPolicyClusterGroup.__PropertyOffset_LoadingRangeScaleFactor) = value;
			}
		}

		// Token: 0x170034F8 RID: 13560
		// (get) Token: 0x0600E16E RID: 57710 RVA: 0x0014B5A5 File Offset: 0x001497A5
		// (set) Token: 0x0600E16F RID: 57711 RVA: 0x0014B5B5 File Offset: 0x001497B5
		public unsafe int LoadingRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPolicyClusterGroup.__PropertyOffset_LoadingRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPolicyClusterGroup.__PropertyOffset_LoadingRange) = value;
			}
		}

		// Token: 0x170034F9 RID: 13561
		// (get) Token: 0x0600E170 RID: 57712 RVA: 0x0014B5C6 File Offset: 0x001497C6
		// (set) Token: 0x0600E171 RID: 57713 RVA: 0x0014B5D6 File Offset: 0x001497D6
		public unsafe int ElementCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPolicyClusterGroup.__PropertyOffset_ElementCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPolicyClusterGroup.__PropertyOffset_ElementCount) = value;
			}
		}

		// Token: 0x170034FA RID: 13562
		// (get) Token: 0x0600E172 RID: 57714 RVA: 0x0014B5E7 File Offset: 0x001497E7
		// (set) Token: 0x0600E173 RID: 57715 RVA: 0x0014B5F7 File Offset: 0x001497F7
		public unsafe int ForceLoadingRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPolicyClusterGroup.__PropertyOffset_ForceLoadingRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPolicyClusterGroup.__PropertyOffset_ForceLoadingRange) = value;
			}
		}

		// Token: 0x0600E174 RID: 57716 RVA: 0x0014B608 File Offset: 0x00149808
		public FPolicyClusterGroup()
		{
		}

		// Token: 0x0600E175 RID: 57717 RVA: 0x0014B610 File Offset: 0x00149810
		public FPolicyClusterGroup(uint RecommendActorSetSize, int ActorSetSize, uint RecommendCellSize, int CellSize, FSoftObjectPath HLODLayer, FSoftObjectPath RockHLODLayer, float LoadingRangeScaleFactor, int LoadingRange, int ElementCount, int ForceLoadingRange)
		{
			this.RecommendActorSetSize = RecommendActorSetSize;
			this.ActorSetSize = ActorSetSize;
			this.RecommendCellSize = RecommendCellSize;
			this.CellSize = CellSize;
			this.HLODLayer = HLODLayer;
			this.RockHLODLayer = RockHLODLayer;
			this.LoadingRangeScaleFactor = LoadingRangeScaleFactor;
			this.LoadingRange = LoadingRange;
			this.ElementCount = ElementCount;
			this.ForceLoadingRange = ForceLoadingRange;
		}

		// Token: 0x0600E176 RID: 57718 RVA: 0x0014B670 File Offset: 0x00149870
		protected override IntPtr GetUStructPtr()
		{
			return FPolicyClusterGroup.StaticStruct();
		}

		// Token: 0x0600E177 RID: 57719 RVA: 0x0014B67C File Offset: 0x0014987C
		[NullableContext(2)]
		public FPolicyClusterGroup(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600E178 RID: 57720 RVA: 0x0014B686 File Offset: 0x00149886
		public FPolicyClusterGroup(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600E179 RID: 57721 RVA: 0x0014B691 File Offset: 0x00149891
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FPolicyClusterGroup(Pointer, false, true);
		}

		// Token: 0x0600E17A RID: 57722 RVA: 0x0014B69B File Offset: 0x0014989B
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FPolicyClusterGroup(Pointer, MemoryOwner);
		}

		// Token: 0x04007905 RID: 30981
		public const string __ObjectPath = "/Script/Engine.PolicyClusterGroup";

		// Token: 0x04007906 RID: 30982
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04007907 RID: 30983
		internal static int __PropertyOffset_RecommendActorSetSize;

		// Token: 0x04007908 RID: 30984
		internal static int __PropertyOffset_ActorSetSize;

		// Token: 0x04007909 RID: 30985
		internal static int __PropertyOffset_RecommendCellSize;

		// Token: 0x0400790A RID: 30986
		internal static int __PropertyOffset_CellSize;

		// Token: 0x0400790B RID: 30987
		internal static int __PropertyOffset_HLODLayer;

		// Token: 0x0400790C RID: 30988
		[Nullable(2)]
		private FSoftObjectPath _HLODLayer;

		// Token: 0x0400790D RID: 30989
		internal static int __PropertyOffset_RockHLODLayer;

		// Token: 0x0400790E RID: 30990
		[Nullable(2)]
		private FSoftObjectPath _RockHLODLayer;

		// Token: 0x0400790F RID: 30991
		internal static int __PropertyOffset_LoadingRangeScaleFactor;

		// Token: 0x04007910 RID: 30992
		internal static int __PropertyOffset_LoadingRange;

		// Token: 0x04007911 RID: 30993
		internal static int __PropertyOffset_ElementCount;

		// Token: 0x04007912 RID: 30994
		internal static int __PropertyOffset_ForceLoadingRange;
	}
}
