using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000237 RID: 567
	[UnrealObjectPath("/Script/Engine.LightComponentBase")]
	[UnrealStructLayout(656, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 656)]
	public abstract class ULightComponentBase : USceneComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06002EF8 RID: 12024 RVA: 0x00041CA5 File Offset: 0x0003FEA5
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULightComponentBase._ClassPtr;
		}

		// Token: 0x170005BF RID: 1471
		// (get) Token: 0x06002EF9 RID: 12025 RVA: 0x00041CB1 File Offset: 0x0003FEB1
		// (set) Token: 0x06002EFA RID: 12026 RVA: 0x00041CC5 File Offset: 0x0003FEC5
		public unsafe FGuid LightGuid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULightComponentBase.__PropertyOffset_LightGuid);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULightComponentBase.__PropertyOffset_LightGuid) = value;
			}
		}

		// Token: 0x170005C0 RID: 1472
		// (get) Token: 0x06002EFB RID: 12027 RVA: 0x00041CDA File Offset: 0x0003FEDA
		// (set) Token: 0x06002EFC RID: 12028 RVA: 0x00041CEA File Offset: 0x0003FEEA
		public unsafe float Brightness_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULightComponentBase.__PropertyOffset_Brightness_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULightComponentBase.__PropertyOffset_Brightness_DEPRECATED) = value;
			}
		}

		// Token: 0x170005C1 RID: 1473
		// (get) Token: 0x06002EFD RID: 12029 RVA: 0x00041CFB File Offset: 0x0003FEFB
		// (set) Token: 0x06002EFE RID: 12030 RVA: 0x00041D0B File Offset: 0x0003FF0B
		public unsafe float Intensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULightComponentBase.__PropertyOffset_Intensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULightComponentBase.__PropertyOffset_Intensity) = value;
			}
		}

		// Token: 0x170005C2 RID: 1474
		// (get) Token: 0x06002EFF RID: 12031 RVA: 0x00041D1C File Offset: 0x0003FF1C
		// (set) Token: 0x06002F00 RID: 12032 RVA: 0x00041D30 File Offset: 0x0003FF30
		public unsafe FColor LightColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULightComponentBase.__PropertyOffset_LightColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULightComponentBase.__PropertyOffset_LightColor) = value;
			}
		}

		// Token: 0x170005C3 RID: 1475
		// (get) Token: 0x06002F01 RID: 12033 RVA: 0x00041D45 File Offset: 0x0003FF45
		// (set) Token: 0x06002F02 RID: 12034 RVA: 0x00041D5E File Offset: 0x0003FF5E
		public unsafe bool bAffectsWorld
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ULightComponentBase.__PropertyOffset_bAffectsWorld) & ULightComponentBase.__PropertyMask_bAffectsWorld) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ULightComponentBase.__PropertyOffset_bAffectsWorld) = ((*(base.NativePtr + (IntPtr)ULightComponentBase.__PropertyOffset_bAffectsWorld) & ~ULightComponentBase.__PropertyMask_bAffectsWorld) | (value ? ULightComponentBase.__PropertyMask_bAffectsWorld : 0));
			}
		}

		// Token: 0x170005C4 RID: 1476
		// (get) Token: 0x06002F03 RID: 12035 RVA: 0x00041D8E File Offset: 0x0003FF8E
		// (set) Token: 0x06002F04 RID: 12036 RVA: 0x00041DA7 File Offset: 0x0003FFA7
		public unsafe bool CastShadows
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ULightComponentBase.__PropertyOffset_CastShadows) & ULightComponentBase.__PropertyMask_CastShadows) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ULightComponentBase.__PropertyOffset_CastShadows) = ((*(base.NativePtr + (IntPtr)ULightComponentBase.__PropertyOffset_CastShadows) & ~ULightComponentBase.__PropertyMask_CastShadows) | (value ? ULightComponentBase.__PropertyMask_CastShadows : 0));
			}
		}

		// Token: 0x170005C5 RID: 1477
		// (get) Token: 0x06002F05 RID: 12037 RVA: 0x00041DD7 File Offset: 0x0003FFD7
		// (set) Token: 0x06002F06 RID: 12038 RVA: 0x00041DF0 File Offset: 0x0003FFF0
		public unsafe bool CastStaticShadows
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ULightComponentBase.__PropertyOffset_CastStaticShadows) & ULightComponentBase.__PropertyMask_CastStaticShadows) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ULightComponentBase.__PropertyOffset_CastStaticShadows) = ((*(base.NativePtr + (IntPtr)ULightComponentBase.__PropertyOffset_CastStaticShadows) & ~ULightComponentBase.__PropertyMask_CastStaticShadows) | (value ? ULightComponentBase.__PropertyMask_CastStaticShadows : 0));
			}
		}

		// Token: 0x170005C6 RID: 1478
		// (get) Token: 0x06002F07 RID: 12039 RVA: 0x00041E20 File Offset: 0x00040020
		// (set) Token: 0x06002F08 RID: 12040 RVA: 0x00041E39 File Offset: 0x00040039
		public unsafe bool CastDynamicShadows
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ULightComponentBase.__PropertyOffset_CastDynamicShadows) & ULightComponentBase.__PropertyMask_CastDynamicShadows) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ULightComponentBase.__PropertyOffset_CastDynamicShadows) = ((*(base.NativePtr + (IntPtr)ULightComponentBase.__PropertyOffset_CastDynamicShadows) & ~ULightComponentBase.__PropertyMask_CastDynamicShadows) | (value ? ULightComponentBase.__PropertyMask_CastDynamicShadows : 0));
			}
		}

		// Token: 0x170005C7 RID: 1479
		// (get) Token: 0x06002F09 RID: 12041 RVA: 0x00041E69 File Offset: 0x00040069
		// (set) Token: 0x06002F0A RID: 12042 RVA: 0x00041E82 File Offset: 0x00040082
		public unsafe bool bAffectTranslucentLighting
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ULightComponentBase.__PropertyOffset_bAffectTranslucentLighting) & ULightComponentBase.__PropertyMask_bAffectTranslucentLighting) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ULightComponentBase.__PropertyOffset_bAffectTranslucentLighting) = ((*(base.NativePtr + (IntPtr)ULightComponentBase.__PropertyOffset_bAffectTranslucentLighting) & ~ULightComponentBase.__PropertyMask_bAffectTranslucentLighting) | (value ? ULightComponentBase.__PropertyMask_bAffectTranslucentLighting : 0));
			}
		}

		// Token: 0x170005C8 RID: 1480
		// (get) Token: 0x06002F0B RID: 12043 RVA: 0x00041EB2 File Offset: 0x000400B2
		// (set) Token: 0x06002F0C RID: 12044 RVA: 0x00041ECB File Offset: 0x000400CB
		public unsafe bool bTransmission
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ULightComponentBase.__PropertyOffset_bTransmission) & ULightComponentBase.__PropertyMask_bTransmission) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ULightComponentBase.__PropertyOffset_bTransmission) = ((*(base.NativePtr + (IntPtr)ULightComponentBase.__PropertyOffset_bTransmission) & ~ULightComponentBase.__PropertyMask_bTransmission) | (value ? ULightComponentBase.__PropertyMask_bTransmission : 0));
			}
		}

		// Token: 0x170005C9 RID: 1481
		// (get) Token: 0x06002F0D RID: 12045 RVA: 0x00041EFB File Offset: 0x000400FB
		// (set) Token: 0x06002F0E RID: 12046 RVA: 0x00041F14 File Offset: 0x00040114
		public unsafe bool bCastVolumetricShadow
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ULightComponentBase.__PropertyOffset_bCastVolumetricShadow) & ULightComponentBase.__PropertyMask_bCastVolumetricShadow) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ULightComponentBase.__PropertyOffset_bCastVolumetricShadow) = ((*(base.NativePtr + (IntPtr)ULightComponentBase.__PropertyOffset_bCastVolumetricShadow) & ~ULightComponentBase.__PropertyMask_bCastVolumetricShadow) | (value ? ULightComponentBase.__PropertyMask_bCastVolumetricShadow : 0));
			}
		}

		// Token: 0x170005CA RID: 1482
		// (get) Token: 0x06002F0F RID: 12047 RVA: 0x00041F44 File Offset: 0x00040144
		// (set) Token: 0x06002F10 RID: 12048 RVA: 0x00041F5D File Offset: 0x0004015D
		public unsafe bool bCastDeepShadow
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ULightComponentBase.__PropertyOffset_bCastDeepShadow) & ULightComponentBase.__PropertyMask_bCastDeepShadow) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ULightComponentBase.__PropertyOffset_bCastDeepShadow) = ((*(base.NativePtr + (IntPtr)ULightComponentBase.__PropertyOffset_bCastDeepShadow) & ~ULightComponentBase.__PropertyMask_bCastDeepShadow) | (value ? ULightComponentBase.__PropertyMask_bCastDeepShadow : 0));
			}
		}

		// Token: 0x170005CB RID: 1483
		// (get) Token: 0x06002F11 RID: 12049 RVA: 0x00041F8D File Offset: 0x0004018D
		// (set) Token: 0x06002F12 RID: 12050 RVA: 0x00041FA6 File Offset: 0x000401A6
		public unsafe bool bCastRaytracedShadow
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ULightComponentBase.__PropertyOffset_bCastRaytracedShadow) & ULightComponentBase.__PropertyMask_bCastRaytracedShadow) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ULightComponentBase.__PropertyOffset_bCastRaytracedShadow) = ((*(base.NativePtr + (IntPtr)ULightComponentBase.__PropertyOffset_bCastRaytracedShadow) & ~ULightComponentBase.__PropertyMask_bCastRaytracedShadow) | (value ? ULightComponentBase.__PropertyMask_bCastRaytracedShadow : 0));
			}
		}

		// Token: 0x170005CC RID: 1484
		// (get) Token: 0x06002F13 RID: 12051 RVA: 0x00041FD6 File Offset: 0x000401D6
		// (set) Token: 0x06002F14 RID: 12052 RVA: 0x00041FEF File Offset: 0x000401EF
		public unsafe bool bAffectReflection
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ULightComponentBase.__PropertyOffset_bAffectReflection) & ULightComponentBase.__PropertyMask_bAffectReflection) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ULightComponentBase.__PropertyOffset_bAffectReflection) = ((*(base.NativePtr + (IntPtr)ULightComponentBase.__PropertyOffset_bAffectReflection) & ~ULightComponentBase.__PropertyMask_bAffectReflection) | (value ? ULightComponentBase.__PropertyMask_bAffectReflection : 0));
			}
		}

		// Token: 0x170005CD RID: 1485
		// (get) Token: 0x06002F15 RID: 12053 RVA: 0x0004201F File Offset: 0x0004021F
		// (set) Token: 0x06002F16 RID: 12054 RVA: 0x00042038 File Offset: 0x00040238
		public unsafe bool bAffectGlobalIllumination
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ULightComponentBase.__PropertyOffset_bAffectGlobalIllumination) & ULightComponentBase.__PropertyMask_bAffectGlobalIllumination) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ULightComponentBase.__PropertyOffset_bAffectGlobalIllumination) = ((*(base.NativePtr + (IntPtr)ULightComponentBase.__PropertyOffset_bAffectGlobalIllumination) & ~ULightComponentBase.__PropertyMask_bAffectGlobalIllumination) | (value ? ULightComponentBase.__PropertyMask_bAffectGlobalIllumination : 0));
			}
		}

		// Token: 0x170005CE RID: 1486
		// (get) Token: 0x06002F17 RID: 12055 RVA: 0x00042068 File Offset: 0x00040268
		// (set) Token: 0x06002F18 RID: 12056 RVA: 0x00042078 File Offset: 0x00040278
		public unsafe float DeepShadowLayerDistribution
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULightComponentBase.__PropertyOffset_DeepShadowLayerDistribution);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULightComponentBase.__PropertyOffset_DeepShadowLayerDistribution) = value;
			}
		}

		// Token: 0x170005CF RID: 1487
		// (get) Token: 0x06002F19 RID: 12057 RVA: 0x00042089 File Offset: 0x00040289
		// (set) Token: 0x06002F1A RID: 12058 RVA: 0x00042099 File Offset: 0x00040299
		public unsafe float IndirectLightingIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULightComponentBase.__PropertyOffset_IndirectLightingIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULightComponentBase.__PropertyOffset_IndirectLightingIntensity) = value;
			}
		}

		// Token: 0x170005D0 RID: 1488
		// (get) Token: 0x06002F1B RID: 12059 RVA: 0x000420AA File Offset: 0x000402AA
		// (set) Token: 0x06002F1C RID: 12060 RVA: 0x000420BA File Offset: 0x000402BA
		public unsafe float VolumetricScatteringIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULightComponentBase.__PropertyOffset_VolumetricScatteringIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULightComponentBase.__PropertyOffset_VolumetricScatteringIntensity) = value;
			}
		}

		// Token: 0x170005D1 RID: 1489
		// (get) Token: 0x06002F1D RID: 12061 RVA: 0x000420CB File Offset: 0x000402CB
		// (set) Token: 0x06002F1E RID: 12062 RVA: 0x000420DB File Offset: 0x000402DB
		public unsafe float VolumetricFogScatteringIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULightComponentBase.__PropertyOffset_VolumetricFogScatteringIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULightComponentBase.__PropertyOffset_VolumetricFogScatteringIntensity) = value;
			}
		}

		// Token: 0x170005D2 RID: 1490
		// (get) Token: 0x06002F1F RID: 12063 RVA: 0x000420EC File Offset: 0x000402EC
		// (set) Token: 0x06002F20 RID: 12064 RVA: 0x000420FC File Offset: 0x000402FC
		public unsafe int SamplesPerPixel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULightComponentBase.__PropertyOffset_SamplesPerPixel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULightComponentBase.__PropertyOffset_SamplesPerPixel) = value;
			}
		}

		// Token: 0x06002F21 RID: 12065 RVA: 0x0004210D File Offset: 0x0004030D
		public void SetSamplesPerPixel(int NewValue)
		{
			ULightComponentBase.__SetSamplesPerPixel_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x06002F22 RID: 12066 RVA: 0x0004211B File Offset: 0x0004031B
		public void SetCastVolumetricShadow(bool bNewValue)
		{
			ULightComponentBase.__SetCastVolumetricShadow_Internal(base.NativePtr, bNewValue);
		}

		// Token: 0x06002F23 RID: 12067 RVA: 0x00042129 File Offset: 0x00040329
		public void SetCastShadows(bool bNewValue)
		{
			ULightComponentBase.__SetCastShadows_Internal(base.NativePtr, bNewValue);
		}

		// Token: 0x06002F24 RID: 12068 RVA: 0x00042137 File Offset: 0x00040337
		public void SetCastRaytracedShadow(bool bNewValue)
		{
			ULightComponentBase.__SetCastRaytracedShadow_Internal(base.NativePtr, bNewValue);
		}

		// Token: 0x06002F25 RID: 12069 RVA: 0x00042145 File Offset: 0x00040345
		public void SetCastDeepShadow(bool bNewValue)
		{
			ULightComponentBase.__SetCastDeepShadow_Internal(base.NativePtr, bNewValue);
		}

		// Token: 0x06002F26 RID: 12070 RVA: 0x00042153 File Offset: 0x00040353
		public void SetAffectReflection(bool bNewValue)
		{
			ULightComponentBase.__SetAffectReflection_Internal(base.NativePtr, bNewValue);
		}

		// Token: 0x06002F27 RID: 12071 RVA: 0x00042161 File Offset: 0x00040361
		public void SetAffectGlobalIllumination(bool bNewValue)
		{
			ULightComponentBase.__SetAffectGlobalIllumination_Internal(base.NativePtr, bNewValue);
		}

		// Token: 0x06002F28 RID: 12072 RVA: 0x0004216F File Offset: 0x0004036F
		public FLinearColor GetLightColor()
		{
			return ULightComponentBase.__GetLightColor_Internal(base.NativePtr);
		}

		// Token: 0x06002F29 RID: 12073 RVA: 0x0004217C File Offset: 0x0004037C
		public bool GetCastShadows()
		{
			return ULightComponentBase.__GetCastShadows_Internal(base.NativePtr);
		}

		// Token: 0x06002F2A RID: 12074
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSamplesPerPixel_Internal(IntPtr @this, int NewValue);

		// Token: 0x06002F2B RID: 12075
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCastVolumetricShadow_Internal(IntPtr @this, bool bNewValue);

		// Token: 0x06002F2C RID: 12076
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCastShadows_Internal(IntPtr @this, bool bNewValue);

		// Token: 0x06002F2D RID: 12077
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCastRaytracedShadow_Internal(IntPtr @this, bool bNewValue);

		// Token: 0x06002F2E RID: 12078
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCastDeepShadow_Internal(IntPtr @this, bool bNewValue);

		// Token: 0x06002F2F RID: 12079
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAffectReflection_Internal(IntPtr @this, bool bNewValue);

		// Token: 0x06002F30 RID: 12080
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAffectGlobalIllumination_Internal(IntPtr @this, bool bNewValue);

		// Token: 0x06002F31 RID: 12081
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FLinearColor __GetLightColor_Internal(IntPtr @this);

		// Token: 0x06002F32 RID: 12082
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetCastShadows_Internal(IntPtr @this);

		// Token: 0x06002F33 RID: 12083 RVA: 0x00042189 File Offset: 0x00040389
		static ULightComponentBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.LightComponentBase");
		}

		// Token: 0x06002F34 RID: 12084 RVA: 0x00042198 File Offset: 0x00040398
		protected ULightComponentBase() : this(BuiltinUtils.AllocNativeUObject(ULightComponentBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06002F35 RID: 12085 RVA: 0x000421C0 File Offset: 0x000403C0
		protected ULightComponentBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000F02 RID: 3842
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.LightComponentBase";

		// Token: 0x04000F03 RID: 3843
		private static IntPtr _ClassPtr;

		// Token: 0x04000F04 RID: 3844
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000F05 RID: 3845
		internal static int __PropertyOffset_LightGuid;

		// Token: 0x04000F06 RID: 3846
		internal static int __PropertyOffset_Brightness_DEPRECATED;

		// Token: 0x04000F07 RID: 3847
		internal static int __PropertyOffset_Intensity;

		// Token: 0x04000F08 RID: 3848
		internal static int __PropertyOffset_LightColor;

		// Token: 0x04000F09 RID: 3849
		internal static int __PropertyOffset_bAffectsWorld;

		// Token: 0x04000F0A RID: 3850
		internal static byte __PropertyMask_bAffectsWorld;

		// Token: 0x04000F0B RID: 3851
		internal static int __PropertyOffset_CastShadows;

		// Token: 0x04000F0C RID: 3852
		internal static byte __PropertyMask_CastShadows;

		// Token: 0x04000F0D RID: 3853
		internal static int __PropertyOffset_CastStaticShadows;

		// Token: 0x04000F0E RID: 3854
		internal static byte __PropertyMask_CastStaticShadows;

		// Token: 0x04000F0F RID: 3855
		internal static int __PropertyOffset_CastDynamicShadows;

		// Token: 0x04000F10 RID: 3856
		internal static byte __PropertyMask_CastDynamicShadows;

		// Token: 0x04000F11 RID: 3857
		internal static int __PropertyOffset_bAffectTranslucentLighting;

		// Token: 0x04000F12 RID: 3858
		internal static byte __PropertyMask_bAffectTranslucentLighting;

		// Token: 0x04000F13 RID: 3859
		internal static int __PropertyOffset_bTransmission;

		// Token: 0x04000F14 RID: 3860
		internal static byte __PropertyMask_bTransmission;

		// Token: 0x04000F15 RID: 3861
		internal static int __PropertyOffset_bCastVolumetricShadow;

		// Token: 0x04000F16 RID: 3862
		internal static byte __PropertyMask_bCastVolumetricShadow;

		// Token: 0x04000F17 RID: 3863
		internal static int __PropertyOffset_bCastDeepShadow;

		// Token: 0x04000F18 RID: 3864
		internal static byte __PropertyMask_bCastDeepShadow;

		// Token: 0x04000F19 RID: 3865
		internal static int __PropertyOffset_bCastRaytracedShadow;

		// Token: 0x04000F1A RID: 3866
		internal static byte __PropertyMask_bCastRaytracedShadow;

		// Token: 0x04000F1B RID: 3867
		internal static int __PropertyOffset_bAffectReflection;

		// Token: 0x04000F1C RID: 3868
		internal static byte __PropertyMask_bAffectReflection;

		// Token: 0x04000F1D RID: 3869
		internal static int __PropertyOffset_bAffectGlobalIllumination;

		// Token: 0x04000F1E RID: 3870
		internal static byte __PropertyMask_bAffectGlobalIllumination;

		// Token: 0x04000F1F RID: 3871
		internal static int __PropertyOffset_DeepShadowLayerDistribution;

		// Token: 0x04000F20 RID: 3872
		internal static int __PropertyOffset_IndirectLightingIntensity;

		// Token: 0x04000F21 RID: 3873
		internal static int __PropertyOffset_VolumetricScatteringIntensity;

		// Token: 0x04000F22 RID: 3874
		internal static int __PropertyOffset_VolumetricFogScatteringIntensity;

		// Token: 0x04000F23 RID: 3875
		internal static int __PropertyOffset_SamplesPerPixel;
	}
}
