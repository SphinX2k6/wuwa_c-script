using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020014A6 RID: 5286
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.HoudiniAssetComponent_V1")]
	[UnrealStructLayout(2944, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2944)]
	public class UHoudiniAssetComponent_V1 : UPrimitiveComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060132C4 RID: 78532 RVA: 0x001C328A File Offset: 0x001C148A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UHoudiniAssetComponent_V1._ClassPtr;
		}

		// Token: 0x060132C5 RID: 78533 RVA: 0x001C3298 File Offset: 0x001C1498
		public UHoudiniAssetComponent_V1() : this(BuiltinUtils.AllocNativeUObject(UHoudiniAssetComponent_V1.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060132C6 RID: 78534 RVA: 0x001C32C0 File Offset: 0x001C14C0
		public UHoudiniAssetComponent_V1(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UHoudiniAssetComponent_V1.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004A9F RID: 19103
		// (get) Token: 0x060132C7 RID: 78535 RVA: 0x001C32F3 File Offset: 0x001C14F3
		// (set) Token: 0x060132C8 RID: 78536 RVA: 0x001C330C File Offset: 0x001C150C
		public unsafe bool bGeneratedDoubleSidedGeometry
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UHoudiniAssetComponent_V1.__PropertyOffset_bGeneratedDoubleSidedGeometry) & UHoudiniAssetComponent_V1.__PropertyMask_bGeneratedDoubleSidedGeometry) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UHoudiniAssetComponent_V1.__PropertyOffset_bGeneratedDoubleSidedGeometry) = ((*(base.NativePtr + (IntPtr)UHoudiniAssetComponent_V1.__PropertyOffset_bGeneratedDoubleSidedGeometry) & ~UHoudiniAssetComponent_V1.__PropertyMask_bGeneratedDoubleSidedGeometry) | (value ? UHoudiniAssetComponent_V1.__PropertyMask_bGeneratedDoubleSidedGeometry : 0));
			}
		}

		// Token: 0x17004AA0 RID: 19104
		// (get) Token: 0x060132C9 RID: 78537 RVA: 0x001C333C File Offset: 0x001C153C
		// (set) Token: 0x060132CA RID: 78538 RVA: 0x001C3350 File Offset: 0x001C1550
		[Nullable(2)]
		public unsafe UPhysicalMaterial GeneratedPhysMaterial
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPhysicalMaterial>(base.NativePtr / (IntPtr)sizeof(void*) + UHoudiniAssetComponent_V1.__PropertyOffset_GeneratedPhysMaterial);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UHoudiniAssetComponent_V1.__PropertyOffset_GeneratedPhysMaterial, value);
			}
		}

		// Token: 0x17004AA1 RID: 19105
		// (get) Token: 0x060132CB RID: 78539 RVA: 0x001C3368 File Offset: 0x001C1568
		// (set) Token: 0x060132CC RID: 78540 RVA: 0x001C33A1 File Offset: 0x001C15A1
		public FBodyInstance DefaultBodyInstance
		{
			get
			{
				base.FastCheckIsValid();
				FBodyInstance result;
				if ((result = this._DefaultBodyInstance) == null)
				{
					result = (this._DefaultBodyInstance = new FBodyInstance(base.NativePtr + (IntPtr)UHoudiniAssetComponent_V1.__PropertyOffset_DefaultBodyInstance, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBodyInstance.StaticStruct(), base.NativePtr + (IntPtr)UHoudiniAssetComponent_V1.__PropertyOffset_DefaultBodyInstance, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004AA2 RID: 19106
		// (get) Token: 0x060132CD RID: 78541 RVA: 0x001C33C2 File Offset: 0x001C15C2
		// (set) Token: 0x060132CE RID: 78542 RVA: 0x001C33D6 File Offset: 0x001C15D6
		[Nullable(0)]
		public unsafe TEnumAsByte<ECollisionTraceFlag> GeneratedCollisionTraceFlag
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniAssetComponent_V1.__PropertyOffset_GeneratedCollisionTraceFlag);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniAssetComponent_V1.__PropertyOffset_GeneratedCollisionTraceFlag) = value;
			}
		}

		// Token: 0x17004AA3 RID: 19107
		// (get) Token: 0x060132CF RID: 78543 RVA: 0x001C33EB File Offset: 0x001C15EB
		// (set) Token: 0x060132D0 RID: 78544 RVA: 0x001C33FB File Offset: 0x001C15FB
		public unsafe int GeneratedLightMapResolution
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniAssetComponent_V1.__PropertyOffset_GeneratedLightMapResolution);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniAssetComponent_V1.__PropertyOffset_GeneratedLightMapResolution) = value;
			}
		}

		// Token: 0x17004AA4 RID: 19108
		// (get) Token: 0x060132D1 RID: 78545 RVA: 0x001C340C File Offset: 0x001C160C
		// (set) Token: 0x060132D2 RID: 78546 RVA: 0x001C341C File Offset: 0x001C161C
		public unsafe float GeneratedDistanceFieldResolutionScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniAssetComponent_V1.__PropertyOffset_GeneratedDistanceFieldResolutionScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniAssetComponent_V1.__PropertyOffset_GeneratedDistanceFieldResolutionScale) = value;
			}
		}

		// Token: 0x17004AA5 RID: 19109
		// (get) Token: 0x060132D3 RID: 78547 RVA: 0x001C3430 File Offset: 0x001C1630
		// (set) Token: 0x060132D4 RID: 78548 RVA: 0x001C3469 File Offset: 0x001C1669
		public FWalkableSlopeOverride GeneratedWalkableSlopeOverride
		{
			get
			{
				base.FastCheckIsValid();
				FWalkableSlopeOverride result;
				if ((result = this._GeneratedWalkableSlopeOverride) == null)
				{
					result = (this._GeneratedWalkableSlopeOverride = new FWalkableSlopeOverride(base.NativePtr + (IntPtr)UHoudiniAssetComponent_V1.__PropertyOffset_GeneratedWalkableSlopeOverride, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FWalkableSlopeOverride.StaticStruct(), base.NativePtr + (IntPtr)UHoudiniAssetComponent_V1.__PropertyOffset_GeneratedWalkableSlopeOverride, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004AA6 RID: 19110
		// (get) Token: 0x060132D5 RID: 78549 RVA: 0x001C348A File Offset: 0x001C168A
		// (set) Token: 0x060132D6 RID: 78550 RVA: 0x001C349A File Offset: 0x001C169A
		public unsafe int GeneratedLightMapCoordinateIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniAssetComponent_V1.__PropertyOffset_GeneratedLightMapCoordinateIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniAssetComponent_V1.__PropertyOffset_GeneratedLightMapCoordinateIndex) = value;
			}
		}

		// Token: 0x17004AA7 RID: 19111
		// (get) Token: 0x060132D7 RID: 78551 RVA: 0x001C34AB File Offset: 0x001C16AB
		// (set) Token: 0x060132D8 RID: 78552 RVA: 0x001C34C4 File Offset: 0x001C16C4
		public unsafe bool bGeneratedUseMaximumStreamingTexelRatio
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UHoudiniAssetComponent_V1.__PropertyOffset_bGeneratedUseMaximumStreamingTexelRatio) & UHoudiniAssetComponent_V1.__PropertyMask_bGeneratedUseMaximumStreamingTexelRatio) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UHoudiniAssetComponent_V1.__PropertyOffset_bGeneratedUseMaximumStreamingTexelRatio) = ((*(base.NativePtr + (IntPtr)UHoudiniAssetComponent_V1.__PropertyOffset_bGeneratedUseMaximumStreamingTexelRatio) & ~UHoudiniAssetComponent_V1.__PropertyMask_bGeneratedUseMaximumStreamingTexelRatio) | (value ? UHoudiniAssetComponent_V1.__PropertyMask_bGeneratedUseMaximumStreamingTexelRatio : 0));
			}
		}

		// Token: 0x17004AA8 RID: 19112
		// (get) Token: 0x060132D9 RID: 78553 RVA: 0x001C34F4 File Offset: 0x001C16F4
		// (set) Token: 0x060132DA RID: 78554 RVA: 0x001C3504 File Offset: 0x001C1704
		public unsafe float GeneratedStreamingDistanceMultiplier
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniAssetComponent_V1.__PropertyOffset_GeneratedStreamingDistanceMultiplier);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniAssetComponent_V1.__PropertyOffset_GeneratedStreamingDistanceMultiplier) = value;
			}
		}

		// Token: 0x17004AA9 RID: 19113
		// (get) Token: 0x060132DB RID: 78555 RVA: 0x001C3515 File Offset: 0x001C1715
		// (set) Token: 0x060132DC RID: 78556 RVA: 0x001C3529 File Offset: 0x001C1729
		[Nullable(2)]
		public unsafe UFoliageType_InstancedStaticMesh GeneratedFoliageDefaultSettings
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UFoliageType_InstancedStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + UHoudiniAssetComponent_V1.__PropertyOffset_GeneratedFoliageDefaultSettings);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UHoudiniAssetComponent_V1.__PropertyOffset_GeneratedFoliageDefaultSettings, value);
			}
		}

		// Token: 0x17004AAA RID: 19114
		// (get) Token: 0x060132DD RID: 78557 RVA: 0x001C3540 File Offset: 0x001C1740
		// (set) Token: 0x060132DE RID: 78558 RVA: 0x001C3579 File Offset: 0x001C1779
		public TArray<UAssetUserData> GeneratedAssetUserData
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UAssetUserData> result;
				if ((result = this._GeneratedAssetUserData) == null)
				{
					result = (this._GeneratedAssetUserData = new TArray<UAssetUserData>(base.NativePtr + (IntPtr)UHoudiniAssetComponent_V1.__PropertyOffset_GeneratedAssetUserData, this));
				}
				return result;
			}
			set
			{
				this.GeneratedAssetUserData.CopyAssign(value);
			}
		}

		// Token: 0x17004AAB RID: 19115
		// (get) Token: 0x060132DF RID: 78559 RVA: 0x001C3588 File Offset: 0x001C1788
		// (set) Token: 0x060132E0 RID: 78560 RVA: 0x001C35C1 File Offset: 0x001C17C1
		public unsafe FText BakeFolder
		{
			get
			{
				base.FastCheckIsValid();
				FText result;
				if ((result = this._BakeFolder) == null)
				{
					result = (this._BakeFolder = new FText(base.NativePtr + (IntPtr)UHoudiniAssetComponent_V1.__PropertyOffset_BakeFolder, this));
				}
				return result;
			}
			set
			{
				FText.NativeCopy((void*)(base.NativePtr + (byte*)((IntPtr)UHoudiniAssetComponent_V1.__PropertyOffset_BakeFolder)), value.NativePtr, 1);
			}
		}

		// Token: 0x17004AAC RID: 19116
		// (get) Token: 0x060132E1 RID: 78561 RVA: 0x001C35DC File Offset: 0x001C17DC
		// (set) Token: 0x060132E2 RID: 78562 RVA: 0x001C3615 File Offset: 0x001C1815
		public unsafe FText TempCookFolder
		{
			get
			{
				base.FastCheckIsValid();
				FText result;
				if ((result = this._TempCookFolder) == null)
				{
					result = (this._TempCookFolder = new FText(base.NativePtr + (IntPtr)UHoudiniAssetComponent_V1.__PropertyOffset_TempCookFolder, this));
				}
				return result;
			}
			set
			{
				FText.NativeCopy((void*)(base.NativePtr + (byte*)((IntPtr)UHoudiniAssetComponent_V1.__PropertyOffset_TempCookFolder)), value.NativePtr, 1);
			}
		}

		// Token: 0x060132E3 RID: 78563 RVA: 0x001C3630 File Offset: 0x001C1830
		static UHoudiniAssetComponent_V1()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/HoudiniEngineRuntime.HoudiniAssetComponent_V1");
		}

		// Token: 0x060132E4 RID: 78564 RVA: 0x001C363E File Offset: 0x001C183E
		protected UHoudiniAssetComponent_V1(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400A5A4 RID: 42404
		public new const string __ObjectPath = "/Script/HoudiniEngineRuntime.HoudiniAssetComponent_V1";

		// Token: 0x0400A5A5 RID: 42405
		private static IntPtr _ClassPtr;

		// Token: 0x0400A5A6 RID: 42406
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400A5A7 RID: 42407
		internal static int __PropertyOffset_bGeneratedDoubleSidedGeometry;

		// Token: 0x0400A5A8 RID: 42408
		internal static byte __PropertyMask_bGeneratedDoubleSidedGeometry;

		// Token: 0x0400A5A9 RID: 42409
		internal static int __PropertyOffset_GeneratedPhysMaterial;

		// Token: 0x0400A5AA RID: 42410
		internal static int __PropertyOffset_DefaultBodyInstance;

		// Token: 0x0400A5AB RID: 42411
		[Nullable(2)]
		private FBodyInstance _DefaultBodyInstance;

		// Token: 0x0400A5AC RID: 42412
		internal static int __PropertyOffset_GeneratedCollisionTraceFlag;

		// Token: 0x0400A5AD RID: 42413
		internal static int __PropertyOffset_GeneratedLightMapResolution;

		// Token: 0x0400A5AE RID: 42414
		internal static int __PropertyOffset_GeneratedDistanceFieldResolutionScale;

		// Token: 0x0400A5AF RID: 42415
		internal static int __PropertyOffset_GeneratedWalkableSlopeOverride;

		// Token: 0x0400A5B0 RID: 42416
		[Nullable(2)]
		private FWalkableSlopeOverride _GeneratedWalkableSlopeOverride;

		// Token: 0x0400A5B1 RID: 42417
		internal static int __PropertyOffset_GeneratedLightMapCoordinateIndex;

		// Token: 0x0400A5B2 RID: 42418
		internal static int __PropertyOffset_bGeneratedUseMaximumStreamingTexelRatio;

		// Token: 0x0400A5B3 RID: 42419
		internal static byte __PropertyMask_bGeneratedUseMaximumStreamingTexelRatio;

		// Token: 0x0400A5B4 RID: 42420
		internal static int __PropertyOffset_GeneratedStreamingDistanceMultiplier;

		// Token: 0x0400A5B5 RID: 42421
		internal static int __PropertyOffset_GeneratedFoliageDefaultSettings;

		// Token: 0x0400A5B6 RID: 42422
		internal static int __PropertyOffset_GeneratedAssetUserData;

		// Token: 0x0400A5B7 RID: 42423
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UAssetUserData> _GeneratedAssetUserData;

		// Token: 0x0400A5B8 RID: 42424
		internal static int __PropertyOffset_BakeFolder;

		// Token: 0x0400A5B9 RID: 42425
		[Nullable(2)]
		private FText _BakeFolder;

		// Token: 0x0400A5BA RID: 42426
		internal static int __PropertyOffset_TempCookFolder;

		// Token: 0x0400A5BB RID: 42427
		[Nullable(2)]
		private FText _TempCookFolder;
	}
}
