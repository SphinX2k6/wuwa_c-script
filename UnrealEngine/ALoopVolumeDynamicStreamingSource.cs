using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200078C RID: 1932
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/EndlessCity.LoopVolumeDynamicStreamingSource")]
	[UnrealStructLayout(1240, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1240)]
	public class ALoopVolumeDynamicStreamingSource : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600648A RID: 25738 RVA: 0x0009047E File Offset: 0x0008E67E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ALoopVolumeDynamicStreamingSource._ClassPtr;
		}

		// Token: 0x0600648B RID: 25739 RVA: 0x0009048C File Offset: 0x0008E68C
		public ALoopVolumeDynamicStreamingSource() : this(BuiltinUtils.AllocNativeUObject(ALoopVolumeDynamicStreamingSource.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600648C RID: 25740 RVA: 0x000904B4 File Offset: 0x0008E6B4
		public ALoopVolumeDynamicStreamingSource(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ALoopVolumeDynamicStreamingSource.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170017D9 RID: 6105
		// (get) Token: 0x0600648D RID: 25741 RVA: 0x000904E7 File Offset: 0x0008E6E7
		// (set) Token: 0x0600648E RID: 25742 RVA: 0x000904F7 File Offset: 0x0008E6F7
		public unsafe bool bMasterEnabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ALoopVolumeDynamicStreamingSource.__PropertyOffset_bMasterEnabled) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ALoopVolumeDynamicStreamingSource.__PropertyOffset_bMasterEnabled) = (value ? 1 : 0);
			}
		}

		// Token: 0x170017DA RID: 6106
		// (get) Token: 0x0600648F RID: 25743 RVA: 0x00090508 File Offset: 0x0008E708
		// (set) Token: 0x06006490 RID: 25744 RVA: 0x0009051C File Offset: 0x0008E71C
		[Nullable(2)]
		public unsafe AVolume BoundsVolume
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AVolume>(base.NativePtr / (IntPtr)sizeof(void*) + ALoopVolumeDynamicStreamingSource.__PropertyOffset_BoundsVolume);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ALoopVolumeDynamicStreamingSource.__PropertyOffset_BoundsVolume, value);
			}
		}

		// Token: 0x170017DB RID: 6107
		// (get) Token: 0x06006491 RID: 25745 RVA: 0x00090534 File Offset: 0x0008E734
		// (set) Token: 0x06006492 RID: 25746 RVA: 0x0009056D File Offset: 0x0008E76D
		public FLoopAxisPredictionSetting AxisX
		{
			get
			{
				base.FastCheckIsValid();
				FLoopAxisPredictionSetting result;
				if ((result = this._AxisX) == null)
				{
					result = (this._AxisX = new FLoopAxisPredictionSetting(base.NativePtr + (IntPtr)ALoopVolumeDynamicStreamingSource.__PropertyOffset_AxisX, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FLoopAxisPredictionSetting.StaticStruct(), base.NativePtr + (IntPtr)ALoopVolumeDynamicStreamingSource.__PropertyOffset_AxisX, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170017DC RID: 6108
		// (get) Token: 0x06006493 RID: 25747 RVA: 0x00090590 File Offset: 0x0008E790
		// (set) Token: 0x06006494 RID: 25748 RVA: 0x000905C9 File Offset: 0x0008E7C9
		public FLoopAxisPredictionSetting AxisY
		{
			get
			{
				base.FastCheckIsValid();
				FLoopAxisPredictionSetting result;
				if ((result = this._AxisY) == null)
				{
					result = (this._AxisY = new FLoopAxisPredictionSetting(base.NativePtr + (IntPtr)ALoopVolumeDynamicStreamingSource.__PropertyOffset_AxisY, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FLoopAxisPredictionSetting.StaticStruct(), base.NativePtr + (IntPtr)ALoopVolumeDynamicStreamingSource.__PropertyOffset_AxisY, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170017DD RID: 6109
		// (get) Token: 0x06006495 RID: 25749 RVA: 0x000905EC File Offset: 0x0008E7EC
		// (set) Token: 0x06006496 RID: 25750 RVA: 0x00090625 File Offset: 0x0008E825
		public FLoopAxisPredictionSetting AxisZ
		{
			get
			{
				base.FastCheckIsValid();
				FLoopAxisPredictionSetting result;
				if ((result = this._AxisZ) == null)
				{
					result = (this._AxisZ = new FLoopAxisPredictionSetting(base.NativePtr + (IntPtr)ALoopVolumeDynamicStreamingSource.__PropertyOffset_AxisZ, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FLoopAxisPredictionSetting.StaticStruct(), base.NativePtr + (IntPtr)ALoopVolumeDynamicStreamingSource.__PropertyOffset_AxisZ, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170017DE RID: 6110
		// (get) Token: 0x06006497 RID: 25751 RVA: 0x00090646 File Offset: 0x0008E846
		// (set) Token: 0x06006498 RID: 25752 RVA: 0x00090656 File Offset: 0x0008E856
		public unsafe float BufferDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ALoopVolumeDynamicStreamingSource.__PropertyOffset_BufferDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ALoopVolumeDynamicStreamingSource.__PropertyOffset_BufferDistance) = value;
			}
		}

		// Token: 0x170017DF RID: 6111
		// (get) Token: 0x06006499 RID: 25753 RVA: 0x00090667 File Offset: 0x0008E867
		// (set) Token: 0x0600649A RID: 25754 RVA: 0x00090677 File Offset: 0x0008E877
		public unsafe bool bDiagonalPrediction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ALoopVolumeDynamicStreamingSource.__PropertyOffset_bDiagonalPrediction) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ALoopVolumeDynamicStreamingSource.__PropertyOffset_bDiagonalPrediction) = (value ? 1 : 0);
			}
		}

		// Token: 0x170017E0 RID: 6112
		// (get) Token: 0x0600649B RID: 25755 RVA: 0x00090688 File Offset: 0x0008E888
		// (set) Token: 0x0600649C RID: 25756 RVA: 0x00090698 File Offset: 0x0008E898
		public unsafe bool bStreamingSourceShouldBlockOnSlowStreaming
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ALoopVolumeDynamicStreamingSource.__PropertyOffset_bStreamingSourceShouldBlockOnSlowStreaming) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ALoopVolumeDynamicStreamingSource.__PropertyOffset_bStreamingSourceShouldBlockOnSlowStreaming) = (value ? 1 : 0);
			}
		}

		// Token: 0x170017E1 RID: 6113
		// (get) Token: 0x0600649D RID: 25757 RVA: 0x000906A9 File Offset: 0x0008E8A9
		// (set) Token: 0x0600649E RID: 25758 RVA: 0x000906B9 File Offset: 0x0008E8B9
		public unsafe bool bDisablePredictedCellRender
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ALoopVolumeDynamicStreamingSource.__PropertyOffset_bDisablePredictedCellRender) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ALoopVolumeDynamicStreamingSource.__PropertyOffset_bDisablePredictedCellRender) = (value ? 1 : 0);
			}
		}

		// Token: 0x170017E2 RID: 6114
		// (get) Token: 0x0600649F RID: 25759 RVA: 0x000906CA File Offset: 0x0008E8CA
		// (set) Token: 0x060064A0 RID: 25760 RVA: 0x000906DA File Offset: 0x0008E8DA
		public unsafe float PredictedLoadingRangeScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ALoopVolumeDynamicStreamingSource.__PropertyOffset_PredictedLoadingRangeScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ALoopVolumeDynamicStreamingSource.__PropertyOffset_PredictedLoadingRangeScale) = value;
			}
		}

		// Token: 0x170017E3 RID: 6115
		// (get) Token: 0x060064A1 RID: 25761 RVA: 0x000906EB File Offset: 0x0008E8EB
		// (set) Token: 0x060064A2 RID: 25762 RVA: 0x000906FB File Offset: 0x0008E8FB
		public unsafe EStreamingSourceTargetState PredictedTargetState
		{
			get
			{
				return (EStreamingSourceTargetState)(*(base.NativePtr + (IntPtr)ALoopVolumeDynamicStreamingSource.__PropertyOffset_PredictedTargetState));
			}
			set
			{
				*(base.NativePtr + (IntPtr)ALoopVolumeDynamicStreamingSource.__PropertyOffset_PredictedTargetState) = (byte)value;
			}
		}

		// Token: 0x170017E4 RID: 6116
		// (get) Token: 0x060064A3 RID: 25763 RVA: 0x0009070C File Offset: 0x0008E90C
		// (set) Token: 0x060064A4 RID: 25764 RVA: 0x0009071C File Offset: 0x0008E91C
		public unsafe EStreamingSourceTargetBehavior PredictedTargetBehavior
		{
			get
			{
				return (EStreamingSourceTargetBehavior)(*(base.NativePtr + (IntPtr)ALoopVolumeDynamicStreamingSource.__PropertyOffset_PredictedTargetBehavior));
			}
			set
			{
				*(base.NativePtr + (IntPtr)ALoopVolumeDynamicStreamingSource.__PropertyOffset_PredictedTargetBehavior) = (byte)value;
			}
		}

		// Token: 0x170017E5 RID: 6117
		// (get) Token: 0x060064A5 RID: 25765 RVA: 0x00090730 File Offset: 0x0008E930
		// (set) Token: 0x060064A6 RID: 25766 RVA: 0x00090769 File Offset: 0x0008E969
		public TArray<FName> PredictedTargetGrids
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._PredictedTargetGrids) == null)
				{
					result = (this._PredictedTargetGrids = new TArray<FName>(base.NativePtr + (IntPtr)ALoopVolumeDynamicStreamingSource.__PropertyOffset_PredictedTargetGrids, this));
				}
				return result;
			}
			set
			{
				this.PredictedTargetGrids.CopyAssign(value);
			}
		}

		// Token: 0x170017E6 RID: 6118
		// (get) Token: 0x060064A7 RID: 25767 RVA: 0x00090777 File Offset: 0x0008E977
		// (set) Token: 0x060064A8 RID: 25768 RVA: 0x00090787 File Offset: 0x0008E987
		public unsafe bool bUseGlobalStreamingPortalPriority
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ALoopVolumeDynamicStreamingSource.__PropertyOffset_bUseGlobalStreamingPortalPriority) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ALoopVolumeDynamicStreamingSource.__PropertyOffset_bUseGlobalStreamingPortalPriority) = (value ? 1 : 0);
			}
		}

		// Token: 0x170017E7 RID: 6119
		// (get) Token: 0x060064A9 RID: 25769 RVA: 0x00090798 File Offset: 0x0008E998
		// (set) Token: 0x060064AA RID: 25770 RVA: 0x000907A8 File Offset: 0x0008E9A8
		public unsafe EStreamingSourcePriority PredictedPriority
		{
			get
			{
				return (EStreamingSourcePriority)(*(base.NativePtr + (IntPtr)ALoopVolumeDynamicStreamingSource.__PropertyOffset_PredictedPriority));
			}
			set
			{
				*(base.NativePtr + (IntPtr)ALoopVolumeDynamicStreamingSource.__PropertyOffset_PredictedPriority) = (byte)value;
			}
		}

		// Token: 0x170017E8 RID: 6120
		// (get) Token: 0x060064AB RID: 25771 RVA: 0x000907B9 File Offset: 0x0008E9B9
		// (set) Token: 0x060064AC RID: 25772 RVA: 0x000907C9 File Offset: 0x0008E9C9
		public unsafe bool bPredictedUseVelocityContributionToCellsSorting
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ALoopVolumeDynamicStreamingSource.__PropertyOffset_bPredictedUseVelocityContributionToCellsSorting) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ALoopVolumeDynamicStreamingSource.__PropertyOffset_bPredictedUseVelocityContributionToCellsSorting) = (value ? 1 : 0);
			}
		}

		// Token: 0x170017E9 RID: 6121
		// (get) Token: 0x060064AD RID: 25773 RVA: 0x000907DA File Offset: 0x0008E9DA
		// (set) Token: 0x060064AE RID: 25774 RVA: 0x000907EA File Offset: 0x0008E9EA
		public unsafe bool bPredictedForce2D
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ALoopVolumeDynamicStreamingSource.__PropertyOffset_bPredictedForce2D) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ALoopVolumeDynamicStreamingSource.__PropertyOffset_bPredictedForce2D) = (value ? 1 : 0);
			}
		}

		// Token: 0x060064AF RID: 25775 RVA: 0x000907FB File Offset: 0x0008E9FB
		public void SetMasterEnabled(bool bEnabled)
		{
			ALoopVolumeDynamicStreamingSource.__SetMasterEnabled_Internal(base.NativePtr, bEnabled);
		}

		// Token: 0x060064B0 RID: 25776 RVA: 0x00090809 File Offset: 0x0008EA09
		public void ForceUpdateStreamingSources()
		{
			ALoopVolumeDynamicStreamingSource.__ForceUpdateStreamingSources_Internal(base.NativePtr);
		}

		// Token: 0x060064B1 RID: 25777
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMasterEnabled_Internal(IntPtr @this, bool bEnabled);

		// Token: 0x060064B2 RID: 25778
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ForceUpdateStreamingSources_Internal(IntPtr @this);

		// Token: 0x060064B3 RID: 25779 RVA: 0x00090816 File Offset: 0x0008EA16
		static ALoopVolumeDynamicStreamingSource()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/EndlessCity.LoopVolumeDynamicStreamingSource");
		}

		// Token: 0x060064B4 RID: 25780 RVA: 0x00090824 File Offset: 0x0008EA24
		protected ALoopVolumeDynamicStreamingSource(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040030BB RID: 12475
		public new const string __ObjectPath = "/Script/EndlessCity.LoopVolumeDynamicStreamingSource";

		// Token: 0x040030BC RID: 12476
		private static IntPtr _ClassPtr;

		// Token: 0x040030BD RID: 12477
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040030BE RID: 12478
		internal static int __PropertyOffset_bMasterEnabled;

		// Token: 0x040030BF RID: 12479
		internal static int __PropertyOffset_BoundsVolume;

		// Token: 0x040030C0 RID: 12480
		internal static int __PropertyOffset_AxisX;

		// Token: 0x040030C1 RID: 12481
		[Nullable(2)]
		private FLoopAxisPredictionSetting _AxisX;

		// Token: 0x040030C2 RID: 12482
		internal static int __PropertyOffset_AxisY;

		// Token: 0x040030C3 RID: 12483
		[Nullable(2)]
		private FLoopAxisPredictionSetting _AxisY;

		// Token: 0x040030C4 RID: 12484
		internal static int __PropertyOffset_AxisZ;

		// Token: 0x040030C5 RID: 12485
		[Nullable(2)]
		private FLoopAxisPredictionSetting _AxisZ;

		// Token: 0x040030C6 RID: 12486
		internal static int __PropertyOffset_BufferDistance;

		// Token: 0x040030C7 RID: 12487
		internal static int __PropertyOffset_bDiagonalPrediction;

		// Token: 0x040030C8 RID: 12488
		internal static int __PropertyOffset_bStreamingSourceShouldBlockOnSlowStreaming;

		// Token: 0x040030C9 RID: 12489
		internal static int __PropertyOffset_bDisablePredictedCellRender;

		// Token: 0x040030CA RID: 12490
		internal static int __PropertyOffset_PredictedLoadingRangeScale;

		// Token: 0x040030CB RID: 12491
		internal static int __PropertyOffset_PredictedTargetState;

		// Token: 0x040030CC RID: 12492
		internal static int __PropertyOffset_PredictedTargetBehavior;

		// Token: 0x040030CD RID: 12493
		internal static int __PropertyOffset_PredictedTargetGrids;

		// Token: 0x040030CE RID: 12494
		[Nullable(2)]
		private TArray<FName> _PredictedTargetGrids;

		// Token: 0x040030CF RID: 12495
		internal static int __PropertyOffset_bUseGlobalStreamingPortalPriority;

		// Token: 0x040030D0 RID: 12496
		internal static int __PropertyOffset_PredictedPriority;

		// Token: 0x040030D1 RID: 12497
		internal static int __PropertyOffset_bPredictedUseVelocityContributionToCellsSorting;

		// Token: 0x040030D2 RID: 12498
		internal static int __PropertyOffset_bPredictedForce2D;
	}
}
