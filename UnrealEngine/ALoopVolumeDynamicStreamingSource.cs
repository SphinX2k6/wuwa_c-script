using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200015E RID: 350
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/EndlessCity.LoopVolumeDynamicStreamingSource")]
	[UnrealStructLayout(1240, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1240)]
	public class ALoopVolumeDynamicStreamingSource : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001374 RID: 4980 RVA: 0x0001EB7F File Offset: 0x0001CD7F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ALoopVolumeDynamicStreamingSource._ClassPtr;
		}

		// Token: 0x06001375 RID: 4981 RVA: 0x0001EB8C File Offset: 0x0001CD8C
		public ALoopVolumeDynamicStreamingSource() : this(BuiltinUtils.AllocNativeUObject(ALoopVolumeDynamicStreamingSource.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001376 RID: 4982 RVA: 0x0001EBB4 File Offset: 0x0001CDB4
		public ALoopVolumeDynamicStreamingSource(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ALoopVolumeDynamicStreamingSource.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x06001377 RID: 4983 RVA: 0x0001EBE7 File Offset: 0x0001CDE7
		// (set) Token: 0x06001378 RID: 4984 RVA: 0x0001EBF7 File Offset: 0x0001CDF7
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

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x06001379 RID: 4985 RVA: 0x0001EC08 File Offset: 0x0001CE08
		// (set) Token: 0x0600137A RID: 4986 RVA: 0x0001EC1C File Offset: 0x0001CE1C
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

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x0600137B RID: 4987 RVA: 0x0001EC31 File Offset: 0x0001CE31
		// (set) Token: 0x0600137C RID: 4988 RVA: 0x0001EC41 File Offset: 0x0001CE41
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

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x0600137D RID: 4989 RVA: 0x0001EC52 File Offset: 0x0001CE52
		// (set) Token: 0x0600137E RID: 4990 RVA: 0x0001EC62 File Offset: 0x0001CE62
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

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x0600137F RID: 4991 RVA: 0x0001EC73 File Offset: 0x0001CE73
		// (set) Token: 0x06001380 RID: 4992 RVA: 0x0001EC83 File Offset: 0x0001CE83
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

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x06001381 RID: 4993 RVA: 0x0001EC94 File Offset: 0x0001CE94
		// (set) Token: 0x06001382 RID: 4994 RVA: 0x0001ECA4 File Offset: 0x0001CEA4
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

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x06001383 RID: 4995 RVA: 0x0001ECB5 File Offset: 0x0001CEB5
		// (set) Token: 0x06001384 RID: 4996 RVA: 0x0001ECC5 File Offset: 0x0001CEC5
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

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x06001385 RID: 4997 RVA: 0x0001ECD6 File Offset: 0x0001CED6
		// (set) Token: 0x06001386 RID: 4998 RVA: 0x0001ECE6 File Offset: 0x0001CEE6
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

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x06001387 RID: 4999 RVA: 0x0001ECF8 File Offset: 0x0001CEF8
		// (set) Token: 0x06001388 RID: 5000 RVA: 0x0001ED31 File Offset: 0x0001CF31
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

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x06001389 RID: 5001 RVA: 0x0001ED3F File Offset: 0x0001CF3F
		// (set) Token: 0x0600138A RID: 5002 RVA: 0x0001ED4F File Offset: 0x0001CF4F
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

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x0600138B RID: 5003 RVA: 0x0001ED60 File Offset: 0x0001CF60
		// (set) Token: 0x0600138C RID: 5004 RVA: 0x0001ED70 File Offset: 0x0001CF70
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

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x0600138D RID: 5005 RVA: 0x0001ED81 File Offset: 0x0001CF81
		// (set) Token: 0x0600138E RID: 5006 RVA: 0x0001ED91 File Offset: 0x0001CF91
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

		// Token: 0x170001EB RID: 491
		// (get) Token: 0x0600138F RID: 5007 RVA: 0x0001EDA2 File Offset: 0x0001CFA2
		// (set) Token: 0x06001390 RID: 5008 RVA: 0x0001EDB2 File Offset: 0x0001CFB2
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

		// Token: 0x06001391 RID: 5009 RVA: 0x0001EDC3 File Offset: 0x0001CFC3
		public void SetMasterEnabled(bool bEnabled)
		{
			ALoopVolumeDynamicStreamingSource.__SetMasterEnabled_Internal(base.NativePtr, bEnabled);
		}

		// Token: 0x06001392 RID: 5010 RVA: 0x0001EDD1 File Offset: 0x0001CFD1
		public void ForceUpdateStreamingSources()
		{
			ALoopVolumeDynamicStreamingSource.__ForceUpdateStreamingSources_Internal(base.NativePtr);
		}

		// Token: 0x06001393 RID: 5011
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMasterEnabled_Internal(IntPtr @this, bool bEnabled);

		// Token: 0x06001394 RID: 5012
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ForceUpdateStreamingSources_Internal(IntPtr @this);

		// Token: 0x06001395 RID: 5013 RVA: 0x0001EDDE File Offset: 0x0001CFDE
		static ALoopVolumeDynamicStreamingSource()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/EndlessCity.LoopVolumeDynamicStreamingSource");
		}

		// Token: 0x06001396 RID: 5014 RVA: 0x0001EDEC File Offset: 0x0001CFEC
		protected ALoopVolumeDynamicStreamingSource(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000647 RID: 1607
		public new const string __ObjectPath = "/Script/EndlessCity.LoopVolumeDynamicStreamingSource";

		// Token: 0x04000648 RID: 1608
		private static IntPtr _ClassPtr;

		// Token: 0x04000649 RID: 1609
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400064A RID: 1610
		internal static int __PropertyOffset_bMasterEnabled;

		// Token: 0x0400064B RID: 1611
		internal static int __PropertyOffset_BoundsVolume;

		// Token: 0x0400064C RID: 1612
		internal static int __PropertyOffset_BufferDistance;

		// Token: 0x0400064D RID: 1613
		internal static int __PropertyOffset_bDiagonalPrediction;

		// Token: 0x0400064E RID: 1614
		internal static int __PropertyOffset_bStreamingSourceShouldBlockOnSlowStreaming;

		// Token: 0x0400064F RID: 1615
		internal static int __PropertyOffset_bDisablePredictedCellRender;

		// Token: 0x04000650 RID: 1616
		internal static int __PropertyOffset_PredictedLoadingRangeScale;

		// Token: 0x04000651 RID: 1617
		internal static int __PropertyOffset_PredictedTargetBehavior;

		// Token: 0x04000652 RID: 1618
		internal static int __PropertyOffset_PredictedTargetGrids;

		// Token: 0x04000653 RID: 1619
		[Nullable(2)]
		private TArray<FName> _PredictedTargetGrids;

		// Token: 0x04000654 RID: 1620
		internal static int __PropertyOffset_bUseGlobalStreamingPortalPriority;

		// Token: 0x04000655 RID: 1621
		internal static int __PropertyOffset_PredictedPriority;

		// Token: 0x04000656 RID: 1622
		internal static int __PropertyOffset_bPredictedUseVelocityContributionToCellsSorting;

		// Token: 0x04000657 RID: 1623
		internal static int __PropertyOffset_bPredictedForce2D;
	}
}
