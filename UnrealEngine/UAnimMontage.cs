using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000811 RID: 2065
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.AnimMontage")]
	[UnrealStructLayout(776, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 776)]
	public class UAnimMontage : UAnimCompositeBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06006ECF RID: 28367 RVA: 0x0009EE39 File Offset: 0x0009D039
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAnimMontage._ClassPtr;
		}

		// Token: 0x06006ED0 RID: 28368 RVA: 0x0009EE48 File Offset: 0x0009D048
		public UAnimMontage() : this(BuiltinUtils.AllocNativeUObject(UAnimMontage.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06006ED1 RID: 28369 RVA: 0x0009EE70 File Offset: 0x0009D070
		public UAnimMontage(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAnimMontage.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001A04 RID: 6660
		// (get) Token: 0x06006ED2 RID: 28370 RVA: 0x0009EEA4 File Offset: 0x0009D0A4
		// (set) Token: 0x06006ED3 RID: 28371 RVA: 0x0009EEDD File Offset: 0x0009D0DD
		public FAlphaBlend BlendIn
		{
			get
			{
				base.FastCheckIsValid();
				FAlphaBlend result;
				if ((result = this._BlendIn) == null)
				{
					result = (this._BlendIn = new FAlphaBlend(base.NativePtr + (IntPtr)UAnimMontage.__PropertyOffset_BlendIn, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FAlphaBlend.StaticStruct(), base.NativePtr + (IntPtr)UAnimMontage.__PropertyOffset_BlendIn, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001A05 RID: 6661
		// (get) Token: 0x06006ED4 RID: 28372 RVA: 0x0009EEFE File Offset: 0x0009D0FE
		// (set) Token: 0x06006ED5 RID: 28373 RVA: 0x0009EF0E File Offset: 0x0009D10E
		public unsafe float BlendInTime_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimMontage.__PropertyOffset_BlendInTime_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimMontage.__PropertyOffset_BlendInTime_DEPRECATED) = value;
			}
		}

		// Token: 0x17001A06 RID: 6662
		// (get) Token: 0x06006ED6 RID: 28374 RVA: 0x0009EF20 File Offset: 0x0009D120
		// (set) Token: 0x06006ED7 RID: 28375 RVA: 0x0009EF59 File Offset: 0x0009D159
		public FAlphaBlend BlendOut
		{
			get
			{
				base.FastCheckIsValid();
				FAlphaBlend result;
				if ((result = this._BlendOut) == null)
				{
					result = (this._BlendOut = new FAlphaBlend(base.NativePtr + (IntPtr)UAnimMontage.__PropertyOffset_BlendOut, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FAlphaBlend.StaticStruct(), base.NativePtr + (IntPtr)UAnimMontage.__PropertyOffset_BlendOut, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001A07 RID: 6663
		// (get) Token: 0x06006ED8 RID: 28376 RVA: 0x0009EF7A File Offset: 0x0009D17A
		// (set) Token: 0x06006ED9 RID: 28377 RVA: 0x0009EF8A File Offset: 0x0009D18A
		public unsafe float BlendOutTime_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimMontage.__PropertyOffset_BlendOutTime_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimMontage.__PropertyOffset_BlendOutTime_DEPRECATED) = value;
			}
		}

		// Token: 0x17001A08 RID: 6664
		// (get) Token: 0x06006EDA RID: 28378 RVA: 0x0009EF9B File Offset: 0x0009D19B
		// (set) Token: 0x06006EDB RID: 28379 RVA: 0x0009EFAB File Offset: 0x0009D1AB
		public unsafe float BlendOutTriggerTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimMontage.__PropertyOffset_BlendOutTriggerTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimMontage.__PropertyOffset_BlendOutTriggerTime) = value;
			}
		}

		// Token: 0x17001A09 RID: 6665
		// (get) Token: 0x06006EDC RID: 28380 RVA: 0x0009EFBC File Offset: 0x0009D1BC
		// (set) Token: 0x06006EDD RID: 28381 RVA: 0x0009EFD0 File Offset: 0x0009D1D0
		public unsafe FName SyncGroup
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimMontage.__PropertyOffset_SyncGroup);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimMontage.__PropertyOffset_SyncGroup) = value;
			}
		}

		// Token: 0x17001A0A RID: 6666
		// (get) Token: 0x06006EDE RID: 28382 RVA: 0x0009EFE5 File Offset: 0x0009D1E5
		// (set) Token: 0x06006EDF RID: 28383 RVA: 0x0009EFF5 File Offset: 0x0009D1F5
		public unsafe int SyncSlotIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimMontage.__PropertyOffset_SyncSlotIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimMontage.__PropertyOffset_SyncSlotIndex) = value;
			}
		}

		// Token: 0x17001A0B RID: 6667
		// (get) Token: 0x06006EE0 RID: 28384 RVA: 0x0009F008 File Offset: 0x0009D208
		// (set) Token: 0x06006EE1 RID: 28385 RVA: 0x0009F041 File Offset: 0x0009D241
		public FMarkerSyncData MarkerData
		{
			get
			{
				base.FastCheckIsValid();
				FMarkerSyncData result;
				if ((result = this._MarkerData) == null)
				{
					result = (this._MarkerData = new FMarkerSyncData(base.NativePtr + (IntPtr)UAnimMontage.__PropertyOffset_MarkerData, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMarkerSyncData.StaticStruct(), base.NativePtr + (IntPtr)UAnimMontage.__PropertyOffset_MarkerData, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001A0C RID: 6668
		// (get) Token: 0x06006EE2 RID: 28386 RVA: 0x0009F064 File Offset: 0x0009D264
		// (set) Token: 0x06006EE3 RID: 28387 RVA: 0x0009F09D File Offset: 0x0009D29D
		public TArray<FCompositeSection> CompositeSections
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FCompositeSection> result;
				if ((result = this._CompositeSections) == null)
				{
					result = (this._CompositeSections = new TArray<FCompositeSection>(base.NativePtr + (IntPtr)UAnimMontage.__PropertyOffset_CompositeSections, this));
				}
				return result;
			}
			set
			{
				this.CompositeSections.CopyAssign(value);
			}
		}

		// Token: 0x17001A0D RID: 6669
		// (get) Token: 0x06006EE4 RID: 28388 RVA: 0x0009F0AC File Offset: 0x0009D2AC
		// (set) Token: 0x06006EE5 RID: 28389 RVA: 0x0009F0E5 File Offset: 0x0009D2E5
		public TArray<FSlotAnimationTrack> SlotAnimTracks
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FSlotAnimationTrack> result;
				if ((result = this._SlotAnimTracks) == null)
				{
					result = (this._SlotAnimTracks = new TArray<FSlotAnimationTrack>(base.NativePtr + (IntPtr)UAnimMontage.__PropertyOffset_SlotAnimTracks, this));
				}
				return result;
			}
			set
			{
				this.SlotAnimTracks.CopyAssign(value);
			}
		}

		// Token: 0x17001A0E RID: 6670
		// (get) Token: 0x06006EE6 RID: 28390 RVA: 0x0009F0F4 File Offset: 0x0009D2F4
		// (set) Token: 0x06006EE7 RID: 28391 RVA: 0x0009F12D File Offset: 0x0009D32D
		public TArray<FBranchingPoint> BranchingPoints_DEPRECATED
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FBranchingPoint> result;
				if ((result = this._BranchingPoints_DEPRECATED) == null)
				{
					result = (this._BranchingPoints_DEPRECATED = new TArray<FBranchingPoint>(base.NativePtr + (IntPtr)UAnimMontage.__PropertyOffset_BranchingPoints_DEPRECATED, this));
				}
				return result;
			}
			set
			{
				this.BranchingPoints_DEPRECATED.CopyAssign(value);
			}
		}

		// Token: 0x17001A0F RID: 6671
		// (get) Token: 0x06006EE8 RID: 28392 RVA: 0x0009F13B File Offset: 0x0009D33B
		// (set) Token: 0x06006EE9 RID: 28393 RVA: 0x0009F14B File Offset: 0x0009D34B
		public unsafe bool bEnableRootMotionTranslation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimMontage.__PropertyOffset_bEnableRootMotionTranslation) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimMontage.__PropertyOffset_bEnableRootMotionTranslation) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001A10 RID: 6672
		// (get) Token: 0x06006EEA RID: 28394 RVA: 0x0009F15C File Offset: 0x0009D35C
		// (set) Token: 0x06006EEB RID: 28395 RVA: 0x0009F16C File Offset: 0x0009D36C
		public unsafe bool bEnableRootMotionRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimMontage.__PropertyOffset_bEnableRootMotionRotation) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimMontage.__PropertyOffset_bEnableRootMotionRotation) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001A11 RID: 6673
		// (get) Token: 0x06006EEC RID: 28396 RVA: 0x0009F17D File Offset: 0x0009D37D
		// (set) Token: 0x06006EED RID: 28397 RVA: 0x0009F18D File Offset: 0x0009D38D
		public unsafe bool bEnableAutoBlendOut
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimMontage.__PropertyOffset_bEnableAutoBlendOut) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimMontage.__PropertyOffset_bEnableAutoBlendOut) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001A12 RID: 6674
		// (get) Token: 0x06006EEE RID: 28398 RVA: 0x0009F19E File Offset: 0x0009D39E
		// (set) Token: 0x06006EEF RID: 28399 RVA: 0x0009F1B2 File Offset: 0x0009D3B2
		[Nullable(0)]
		public unsafe TEnumAsByte<ERootMotionRootLock> RootMotionRootLock
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimMontage.__PropertyOffset_RootMotionRootLock);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)UAnimMontage.__PropertyOffset_RootMotionRootLock) = value;
			}
		}

		// Token: 0x17001A13 RID: 6675
		// (get) Token: 0x06006EF0 RID: 28400 RVA: 0x0009F1C8 File Offset: 0x0009D3C8
		// (set) Token: 0x06006EF1 RID: 28401 RVA: 0x0009F201 File Offset: 0x0009D401
		public TArray<FBranchingPointMarker> BranchingPointMarkers
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FBranchingPointMarker> result;
				if ((result = this._BranchingPointMarkers) == null)
				{
					result = (this._BranchingPointMarkers = new TArray<FBranchingPointMarker>(base.NativePtr + (IntPtr)UAnimMontage.__PropertyOffset_BranchingPointMarkers, this));
				}
				return result;
			}
			set
			{
				this.BranchingPointMarkers.CopyAssign(value);
			}
		}

		// Token: 0x17001A14 RID: 6676
		// (get) Token: 0x06006EF2 RID: 28402 RVA: 0x0009F210 File Offset: 0x0009D410
		// (set) Token: 0x06006EF3 RID: 28403 RVA: 0x0009F249 File Offset: 0x0009D449
		public TArray<int> BranchingPointStateNotifyIndices
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._BranchingPointStateNotifyIndices) == null)
				{
					result = (this._BranchingPointStateNotifyIndices = new TArray<int>(base.NativePtr + (IntPtr)UAnimMontage.__PropertyOffset_BranchingPointStateNotifyIndices, this));
				}
				return result;
			}
			set
			{
				this.BranchingPointStateNotifyIndices.CopyAssign(value);
			}
		}

		// Token: 0x17001A15 RID: 6677
		// (get) Token: 0x06006EF4 RID: 28404 RVA: 0x0009F258 File Offset: 0x0009D458
		// (set) Token: 0x06006EF5 RID: 28405 RVA: 0x0009F291 File Offset: 0x0009D491
		public FTimeStretchCurve TimeStretchCurve
		{
			get
			{
				base.FastCheckIsValid();
				FTimeStretchCurve result;
				if ((result = this._TimeStretchCurve) == null)
				{
					result = (this._TimeStretchCurve = new FTimeStretchCurve(base.NativePtr + (IntPtr)UAnimMontage.__PropertyOffset_TimeStretchCurve, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FTimeStretchCurve.StaticStruct(), base.NativePtr + (IntPtr)UAnimMontage.__PropertyOffset_TimeStretchCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001A16 RID: 6678
		// (get) Token: 0x06006EF6 RID: 28406 RVA: 0x0009F2B2 File Offset: 0x0009D4B2
		// (set) Token: 0x06006EF7 RID: 28407 RVA: 0x0009F2C6 File Offset: 0x0009D4C6
		public unsafe FName TimeStretchCurveName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimMontage.__PropertyOffset_TimeStretchCurveName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimMontage.__PropertyOffset_TimeStretchCurveName) = value;
			}
		}

		// Token: 0x06006EF8 RID: 28408 RVA: 0x0009F2DC File Offset: 0x0009D4DC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe float GetDefaultBlendOutTime()
		{
			UAnimMontage.__GetDefaultBlendOutTime_FunctionParams* ptr = stackalloc UAnimMontage.__GetDefaultBlendOutTime_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UAnimMontage.__GetDefaultBlendOutTime_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UAnimMontage.__GetDefaultBlendOutTime_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UAnimMontage.__GetDefaultBlendOutTime_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06006EF9 RID: 28409 RVA: 0x0009F322 File Offset: 0x0009D522
		static UAnimMontage()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.AnimMontage");
		}

		// Token: 0x06006EFA RID: 28410 RVA: 0x0009F330 File Offset: 0x0009D530
		protected UAnimMontage(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003533 RID: 13619
		public new const string __ObjectPath = "/Script/Engine.AnimMontage";

		// Token: 0x04003534 RID: 13620
		private static IntPtr _ClassPtr;

		// Token: 0x04003535 RID: 13621
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003536 RID: 13622
		internal static int __PropertyOffset_BlendIn;

		// Token: 0x04003537 RID: 13623
		[Nullable(2)]
		private FAlphaBlend _BlendIn;

		// Token: 0x04003538 RID: 13624
		internal static int __PropertyOffset_BlendInTime_DEPRECATED;

		// Token: 0x04003539 RID: 13625
		internal static int __PropertyOffset_BlendOut;

		// Token: 0x0400353A RID: 13626
		[Nullable(2)]
		private FAlphaBlend _BlendOut;

		// Token: 0x0400353B RID: 13627
		internal static int __PropertyOffset_BlendOutTime_DEPRECATED;

		// Token: 0x0400353C RID: 13628
		internal static int __PropertyOffset_BlendOutTriggerTime;

		// Token: 0x0400353D RID: 13629
		internal static int __PropertyOffset_SyncGroup;

		// Token: 0x0400353E RID: 13630
		internal static int __PropertyOffset_SyncSlotIndex;

		// Token: 0x0400353F RID: 13631
		internal static int __PropertyOffset_MarkerData;

		// Token: 0x04003540 RID: 13632
		[Nullable(2)]
		private FMarkerSyncData _MarkerData;

		// Token: 0x04003541 RID: 13633
		internal static int __PropertyOffset_CompositeSections;

		// Token: 0x04003542 RID: 13634
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FCompositeSection> _CompositeSections;

		// Token: 0x04003543 RID: 13635
		internal static int __PropertyOffset_SlotAnimTracks;

		// Token: 0x04003544 RID: 13636
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSlotAnimationTrack> _SlotAnimTracks;

		// Token: 0x04003545 RID: 13637
		internal static int __PropertyOffset_BranchingPoints_DEPRECATED;

		// Token: 0x04003546 RID: 13638
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FBranchingPoint> _BranchingPoints_DEPRECATED;

		// Token: 0x04003547 RID: 13639
		internal static int __PropertyOffset_bEnableRootMotionTranslation;

		// Token: 0x04003548 RID: 13640
		internal static int __PropertyOffset_bEnableRootMotionRotation;

		// Token: 0x04003549 RID: 13641
		internal static int __PropertyOffset_bEnableAutoBlendOut;

		// Token: 0x0400354A RID: 13642
		internal static int __PropertyOffset_RootMotionRootLock;

		// Token: 0x0400354B RID: 13643
		internal static int __PropertyOffset_BranchingPointMarkers;

		// Token: 0x0400354C RID: 13644
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FBranchingPointMarker> _BranchingPointMarkers;

		// Token: 0x0400354D RID: 13645
		internal static int __PropertyOffset_BranchingPointStateNotifyIndices;

		// Token: 0x0400354E RID: 13646
		[Nullable(2)]
		private TArray<int> _BranchingPointStateNotifyIndices;

		// Token: 0x0400354F RID: 13647
		internal static int __PropertyOffset_TimeStretchCurve;

		// Token: 0x04003550 RID: 13648
		[Nullable(2)]
		private FTimeStretchCurve _TimeStretchCurve;

		// Token: 0x04003551 RID: 13649
		internal static int __PropertyOffset_TimeStretchCurveName;

		// Token: 0x04003552 RID: 13650
		private static IntPtr __GetDefaultBlendOutTime_NativeFunctionPtr;

		// Token: 0x02002C84 RID: 11396
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetDefaultBlendOutTime_FunctionParams
		{
			// Token: 0x040165BD RID: 91581
			[FieldOffset(0)]
			public float __Result;
		}
	}
}
