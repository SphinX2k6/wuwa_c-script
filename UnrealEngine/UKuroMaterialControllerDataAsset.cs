using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001B3B RID: 6971
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialControllerDataAsset")]
	[UnrealStructLayout(3160, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 3160)]
	public class UKuroMaterialControllerDataAsset : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601A624 RID: 108068 RVA: 0x0026E5E2 File Offset: 0x0026C7E2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroMaterialControllerDataAsset._ClassPtr;
		}

		// Token: 0x0601A625 RID: 108069 RVA: 0x0026E5F0 File Offset: 0x0026C7F0
		public UKuroMaterialControllerDataAsset() : this(BuiltinUtils.AllocNativeUObject(UKuroMaterialControllerDataAsset.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601A626 RID: 108070 RVA: 0x0026E618 File Offset: 0x0026C818
		public UKuroMaterialControllerDataAsset(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroMaterialControllerDataAsset.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006A0A RID: 27146
		// (get) Token: 0x0601A627 RID: 108071 RVA: 0x0026E64B File Offset: 0x0026C84B
		// (set) Token: 0x0601A628 RID: 108072 RVA: 0x0026E65B File Offset: 0x0026C85B
		public unsafe bool bUseAbsoluteSpaceCurve
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroMaterialControllerDataAsset.__PropertyOffset_bUseAbsoluteSpaceCurve) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroMaterialControllerDataAsset.__PropertyOffset_bUseAbsoluteSpaceCurve) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006A0B RID: 27147
		// (get) Token: 0x0601A629 RID: 108073 RVA: 0x0026E66C File Offset: 0x0026C86C
		// (set) Token: 0x0601A62A RID: 108074 RVA: 0x0026E67C File Offset: 0x0026C87C
		public unsafe bool CleanOriginEffect
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroMaterialControllerDataAsset.__PropertyOffset_CleanOriginEffect) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroMaterialControllerDataAsset.__PropertyOffset_CleanOriginEffect) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006A0C RID: 27148
		// (get) Token: 0x0601A62B RID: 108075 RVA: 0x0026E68D File Offset: 0x0026C88D
		// (set) Token: 0x0601A62C RID: 108076 RVA: 0x0026E69D File Offset: 0x0026C89D
		public unsafe bool NeverBeCleanedByOthers
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroMaterialControllerDataAsset.__PropertyOffset_NeverBeCleanedByOthers) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroMaterialControllerDataAsset.__PropertyOffset_NeverBeCleanedByOthers) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006A0D RID: 27149
		// (get) Token: 0x0601A62D RID: 108077 RVA: 0x0026E6AE File Offset: 0x0026C8AE
		// (set) Token: 0x0601A62E RID: 108078 RVA: 0x0026E6BE File Offset: 0x0026C8BE
		public unsafe bool HighPriority
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroMaterialControllerDataAsset.__PropertyOffset_HighPriority) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroMaterialControllerDataAsset.__PropertyOffset_HighPriority) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006A0E RID: 27150
		// (get) Token: 0x0601A62F RID: 108079 RVA: 0x0026E6CF File Offset: 0x0026C8CF
		// (set) Token: 0x0601A630 RID: 108080 RVA: 0x0026E6DF File Offset: 0x0026C8DF
		public unsafe bool bReceiveLogicalTimeDilation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroMaterialControllerDataAsset.__PropertyOffset_bReceiveLogicalTimeDilation) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroMaterialControllerDataAsset.__PropertyOffset_bReceiveLogicalTimeDilation) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006A0F RID: 27151
		// (get) Token: 0x0601A631 RID: 108081 RVA: 0x0026E6F0 File Offset: 0x0026C8F0
		// (set) Token: 0x0601A632 RID: 108082 RVA: 0x0026E700 File Offset: 0x0026C900
		public unsafe bool ForceBattle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroMaterialControllerDataAsset.__PropertyOffset_ForceBattle) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroMaterialControllerDataAsset.__PropertyOffset_ForceBattle) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006A10 RID: 27152
		// (get) Token: 0x0601A633 RID: 108083 RVA: 0x0026E711 File Offset: 0x0026C911
		// (set) Token: 0x0601A634 RID: 108084 RVA: 0x0026E721 File Offset: 0x0026C921
		public unsafe bool ForceBattleMask
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroMaterialControllerDataAsset.__PropertyOffset_ForceBattleMask) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroMaterialControllerDataAsset.__PropertyOffset_ForceBattleMask) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006A11 RID: 27153
		// (get) Token: 0x0601A635 RID: 108085 RVA: 0x0026E732 File Offset: 0x0026C932
		// (set) Token: 0x0601A636 RID: 108086 RVA: 0x0026E742 File Offset: 0x0026C942
		public unsafe bool ForceAlphaTest
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroMaterialControllerDataAsset.__PropertyOffset_ForceAlphaTest) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroMaterialControllerDataAsset.__PropertyOffset_ForceAlphaTest) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006A12 RID: 27154
		// (get) Token: 0x0601A637 RID: 108087 RVA: 0x0026E753 File Offset: 0x0026C953
		// (set) Token: 0x0601A638 RID: 108088 RVA: 0x0026E767 File Offset: 0x0026C967
		[Nullable(2)]
		public unsafe UKuroMaterialContainerDataCache DataCache
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroMaterialContainerDataCache>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroMaterialControllerDataAsset.__PropertyOffset_DataCache);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroMaterialControllerDataAsset.__PropertyOffset_DataCache, value);
			}
		}

		// Token: 0x17006A13 RID: 27155
		// (get) Token: 0x0601A639 RID: 108089 RVA: 0x0026E77C File Offset: 0x0026C97C
		// (set) Token: 0x0601A63A RID: 108090 RVA: 0x0026E78C File Offset: 0x0026C98C
		public unsafe bool bAllowMaterialUnreverted
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroMaterialControllerDataAsset.__PropertyOffset_bAllowMaterialUnreverted) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroMaterialControllerDataAsset.__PropertyOffset_bAllowMaterialUnreverted) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006A14 RID: 27156
		// (get) Token: 0x0601A63B RID: 108091 RVA: 0x0026E79D File Offset: 0x0026C99D
		// (set) Token: 0x0601A63C RID: 108092 RVA: 0x0026E7AD File Offset: 0x0026C9AD
		public unsafe bool bMaterialReplaceReceiveEffects
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroMaterialControllerDataAsset.__PropertyOffset_bMaterialReplaceReceiveEffects) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroMaterialControllerDataAsset.__PropertyOffset_bMaterialReplaceReceiveEffects) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006A15 RID: 27157
		// (get) Token: 0x0601A63D RID: 108093 RVA: 0x0026E7C0 File Offset: 0x0026C9C0
		// (set) Token: 0x0601A63E RID: 108094 RVA: 0x0026E7F9 File Offset: 0x0026C9F9
		public TArray<FName> ExtraBodyNames
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._ExtraBodyNames) == null)
				{
					result = (this._ExtraBodyNames = new TArray<FName>(base.NativePtr + (IntPtr)UKuroMaterialControllerDataAsset.__PropertyOffset_ExtraBodyNames, this));
				}
				return result;
			}
			set
			{
				this.ExtraBodyNames.CopyAssign(value);
			}
		}

		// Token: 0x17006A16 RID: 27158
		// (get) Token: 0x0601A63F RID: 108095 RVA: 0x0026E807 File Offset: 0x0026CA07
		// (set) Token: 0x0601A640 RID: 108096 RVA: 0x0026E817 File Offset: 0x0026CA17
		public unsafe bool AlwaysApplyToExtraBodies
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroMaterialControllerDataAsset.__PropertyOffset_AlwaysApplyToExtraBodies) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroMaterialControllerDataAsset.__PropertyOffset_AlwaysApplyToExtraBodies) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006A17 RID: 27159
		// (get) Token: 0x0601A641 RID: 108097 RVA: 0x0026E828 File Offset: 0x0026CA28
		// (set) Token: 0x0601A642 RID: 108098 RVA: 0x0026E83C File Offset: 0x0026CA3C
		[Nullable(2)]
		public unsafe UMaterialInterface ReplaceMaterialMac
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroMaterialControllerDataAsset.__PropertyOffset_ReplaceMaterialMac);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroMaterialControllerDataAsset.__PropertyOffset_ReplaceMaterialMac, value);
			}
		}

		// Token: 0x17006A18 RID: 27160
		// (get) Token: 0x0601A643 RID: 108099 RVA: 0x0026E851 File Offset: 0x0026CA51
		// (set) Token: 0x0601A644 RID: 108100 RVA: 0x0026E861 File Offset: 0x0026CA61
		public unsafe bool bMatchMaterialIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroMaterialControllerDataAsset.__PropertyOffset_bMatchMaterialIndex) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroMaterialControllerDataAsset.__PropertyOffset_bMatchMaterialIndex) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006A19 RID: 27161
		// (get) Token: 0x0601A645 RID: 108101 RVA: 0x0026E874 File Offset: 0x0026CA74
		// (set) Token: 0x0601A646 RID: 108102 RVA: 0x0026E8AD File Offset: 0x0026CAAD
		public TArray<UMaterialInterface> ReplaceBaseMaterials
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInterface> result;
				if ((result = this._ReplaceBaseMaterials) == null)
				{
					result = (this._ReplaceBaseMaterials = new TArray<UMaterialInterface>(base.NativePtr + (IntPtr)UKuroMaterialControllerDataAsset.__PropertyOffset_ReplaceBaseMaterials, this));
				}
				return result;
			}
			set
			{
				this.ReplaceBaseMaterials.CopyAssign(value);
			}
		}

		// Token: 0x17006A1A RID: 27162
		// (get) Token: 0x0601A647 RID: 108103 RVA: 0x0026E8BC File Offset: 0x0026CABC
		// (set) Token: 0x0601A648 RID: 108104 RVA: 0x0026E8F5 File Offset: 0x0026CAF5
		public TArray<UMaterialInterface> ReplaceBaseMaterialsMobile
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInterface> result;
				if ((result = this._ReplaceBaseMaterialsMobile) == null)
				{
					result = (this._ReplaceBaseMaterialsMobile = new TArray<UMaterialInterface>(base.NativePtr + (IntPtr)UKuroMaterialControllerDataAsset.__PropertyOffset_ReplaceBaseMaterialsMobile, this));
				}
				return result;
			}
			set
			{
				this.ReplaceBaseMaterialsMobile.CopyAssign(value);
			}
		}

		// Token: 0x17006A1B RID: 27163
		// (get) Token: 0x0601A649 RID: 108105 RVA: 0x0026E904 File Offset: 0x0026CB04
		// (set) Token: 0x0601A64A RID: 108106 RVA: 0x0026E93D File Offset: 0x0026CB3D
		public TArray<FKuroMaterialCustomParamGroupForEachMaterial> CustomParametersForEachMaterials
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroMaterialCustomParamGroupForEachMaterial> result;
				if ((result = this._CustomParametersForEachMaterials) == null)
				{
					result = (this._CustomParametersForEachMaterials = new TArray<FKuroMaterialCustomParamGroupForEachMaterial>(base.NativePtr + (IntPtr)UKuroMaterialControllerDataAsset.__PropertyOffset_CustomParametersForEachMaterials, this));
				}
				return result;
			}
			set
			{
				this.CustomParametersForEachMaterials.CopyAssign(value);
			}
		}

		// Token: 0x17006A1C RID: 27164
		// (get) Token: 0x0601A64B RID: 108107 RVA: 0x0026E94B File Offset: 0x0026CB4B
		// (set) Token: 0x0601A64C RID: 108108 RVA: 0x0026E95B File Offset: 0x0026CB5B
		public unsafe bool bUseBodyOpacity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroMaterialControllerDataAsset.__PropertyOffset_bUseBodyOpacity) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroMaterialControllerDataAsset.__PropertyOffset_bUseBodyOpacity) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006A1D RID: 27165
		// (get) Token: 0x0601A64D RID: 108109 RVA: 0x0026E96C File Offset: 0x0026CB6C
		// (set) Token: 0x0601A64E RID: 108110 RVA: 0x0026E9A5 File Offset: 0x0026CBA5
		public FKuroMaterialCurveFloatGroup BodyOpacity
		{
			get
			{
				base.FastCheckIsValid();
				FKuroMaterialCurveFloatGroup result;
				if ((result = this._BodyOpacity) == null)
				{
					result = (this._BodyOpacity = new FKuroMaterialCurveFloatGroup(base.NativePtr + (IntPtr)UKuroMaterialControllerDataAsset.__PropertyOffset_BodyOpacity, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroMaterialCurveFloatGroup.StaticStruct(), base.NativePtr + (IntPtr)UKuroMaterialControllerDataAsset.__PropertyOffset_BodyOpacity, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006A1E RID: 27166
		// (get) Token: 0x0601A64F RID: 108111 RVA: 0x0026E9C6 File Offset: 0x0026CBC6
		// (set) Token: 0x0601A650 RID: 108112 RVA: 0x0026E9D6 File Offset: 0x0026CBD6
		public unsafe bool bUseXRay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroMaterialControllerDataAsset.__PropertyOffset_bUseXRay) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroMaterialControllerDataAsset.__PropertyOffset_bUseXRay) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006A1F RID: 27167
		// (get) Token: 0x0601A651 RID: 108113 RVA: 0x0026E9E8 File Offset: 0x0026CBE8
		// (set) Token: 0x0601A652 RID: 108114 RVA: 0x0026EA21 File Offset: 0x0026CC21
		public FKuroMaterialControllerParam_XRay XRayParam
		{
			get
			{
				base.FastCheckIsValid();
				FKuroMaterialControllerParam_XRay result;
				if ((result = this._XRayParam) == null)
				{
					result = (this._XRayParam = new FKuroMaterialControllerParam_XRay(base.NativePtr + (IntPtr)UKuroMaterialControllerDataAsset.__PropertyOffset_XRayParam, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroMaterialControllerParam_XRay.StaticStruct(), base.NativePtr + (IntPtr)UKuroMaterialControllerDataAsset.__PropertyOffset_XRayParam, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0601A653 RID: 108115 RVA: 0x0026EA42 File Offset: 0x0026CC42
		public void ResetDataCache(bool bForce = false)
		{
			UKuroMaterialControllerDataAsset.__ResetDataCache_Internal(base.NativePtr, bForce);
		}

		// Token: 0x0601A654 RID: 108116 RVA: 0x0026EA50 File Offset: 0x0026CC50
		public bool IsDataCacheValid()
		{
			return UKuroMaterialControllerDataAsset.__IsDataCacheValid_Internal(base.NativePtr);
		}

		// Token: 0x0601A655 RID: 108117
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResetDataCache_Internal(IntPtr @this, bool bForce);

		// Token: 0x0601A656 RID: 108118
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsDataCacheValid_Internal(IntPtr @this);

		// Token: 0x0601A657 RID: 108119 RVA: 0x0026EA5D File Offset: 0x0026CC5D
		static UKuroMaterialControllerDataAsset()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialControllerDataAsset");
		}

		// Token: 0x0601A658 RID: 108120 RVA: 0x0026EA6B File Offset: 0x0026CC6B
		protected UKuroMaterialControllerDataAsset(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400E4BE RID: 58558
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialControllerDataAsset";

		// Token: 0x0400E4BF RID: 58559
		private static IntPtr _ClassPtr;

		// Token: 0x0400E4C0 RID: 58560
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400E4C1 RID: 58561
		internal static int __PropertyOffset_bUseAbsoluteSpaceCurve;

		// Token: 0x0400E4C2 RID: 58562
		internal static int __PropertyOffset_CleanOriginEffect;

		// Token: 0x0400E4C3 RID: 58563
		internal static int __PropertyOffset_NeverBeCleanedByOthers;

		// Token: 0x0400E4C4 RID: 58564
		internal static int __PropertyOffset_HighPriority;

		// Token: 0x0400E4C5 RID: 58565
		internal static int __PropertyOffset_bReceiveLogicalTimeDilation;

		// Token: 0x0400E4C6 RID: 58566
		internal static int __PropertyOffset_ForceBattle;

		// Token: 0x0400E4C7 RID: 58567
		internal static int __PropertyOffset_ForceBattleMask;

		// Token: 0x0400E4C8 RID: 58568
		internal static int __PropertyOffset_ForceAlphaTest;

		// Token: 0x0400E4C9 RID: 58569
		internal static int __PropertyOffset_DataCache;

		// Token: 0x0400E4CA RID: 58570
		internal static int __PropertyOffset_bAllowMaterialUnreverted;

		// Token: 0x0400E4CB RID: 58571
		internal static int __PropertyOffset_bMaterialReplaceReceiveEffects;

		// Token: 0x0400E4CC RID: 58572
		internal static int __PropertyOffset_ExtraBodyNames;

		// Token: 0x0400E4CD RID: 58573
		[Nullable(2)]
		private TArray<FName> _ExtraBodyNames;

		// Token: 0x0400E4CE RID: 58574
		internal static int __PropertyOffset_AlwaysApplyToExtraBodies;

		// Token: 0x0400E4CF RID: 58575
		internal static int __PropertyOffset_ReplaceMaterialMac;

		// Token: 0x0400E4D0 RID: 58576
		internal static int __PropertyOffset_bMatchMaterialIndex;

		// Token: 0x0400E4D1 RID: 58577
		internal static int __PropertyOffset_ReplaceBaseMaterials;

		// Token: 0x0400E4D2 RID: 58578
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInterface> _ReplaceBaseMaterials;

		// Token: 0x0400E4D3 RID: 58579
		internal static int __PropertyOffset_ReplaceBaseMaterialsMobile;

		// Token: 0x0400E4D4 RID: 58580
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInterface> _ReplaceBaseMaterialsMobile;

		// Token: 0x0400E4D5 RID: 58581
		internal static int __PropertyOffset_CustomParametersForEachMaterials;

		// Token: 0x0400E4D6 RID: 58582
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroMaterialCustomParamGroupForEachMaterial> _CustomParametersForEachMaterials;

		// Token: 0x0400E4D7 RID: 58583
		internal static int __PropertyOffset_bUseBodyOpacity;

		// Token: 0x0400E4D8 RID: 58584
		internal static int __PropertyOffset_BodyOpacity;

		// Token: 0x0400E4D9 RID: 58585
		[Nullable(2)]
		private FKuroMaterialCurveFloatGroup _BodyOpacity;

		// Token: 0x0400E4DA RID: 58586
		internal static int __PropertyOffset_bUseXRay;

		// Token: 0x0400E4DB RID: 58587
		internal static int __PropertyOffset_XRayParam;

		// Token: 0x0400E4DC RID: 58588
		[Nullable(2)]
		private FKuroMaterialControllerParam_XRay _XRayParam;
	}
}
