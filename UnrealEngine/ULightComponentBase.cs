using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000D46 RID: 3398
	[UnrealObjectPath("/Script/Engine.LightComponentBase")]
	[UnrealStructLayout(656, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 656)]
	public abstract class ULightComponentBase : USceneComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600B744 RID: 46916 RVA: 0x00104BFD File Offset: 0x00102DFD
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULightComponentBase._ClassPtr;
		}

		// Token: 0x170029E6 RID: 10726
		// (get) Token: 0x0600B745 RID: 46917 RVA: 0x00104C09 File Offset: 0x00102E09
		// (set) Token: 0x0600B746 RID: 46918 RVA: 0x00104C1D File Offset: 0x00102E1D
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

		// Token: 0x170029E7 RID: 10727
		// (get) Token: 0x0600B747 RID: 46919 RVA: 0x00104C32 File Offset: 0x00102E32
		// (set) Token: 0x0600B748 RID: 46920 RVA: 0x00104C42 File Offset: 0x00102E42
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

		// Token: 0x170029E8 RID: 10728
		// (get) Token: 0x0600B749 RID: 46921 RVA: 0x00104C53 File Offset: 0x00102E53
		// (set) Token: 0x0600B74A RID: 46922 RVA: 0x00104C63 File Offset: 0x00102E63
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

		// Token: 0x170029E9 RID: 10729
		// (get) Token: 0x0600B74B RID: 46923 RVA: 0x00104C74 File Offset: 0x00102E74
		// (set) Token: 0x0600B74C RID: 46924 RVA: 0x00104C88 File Offset: 0x00102E88
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

		// Token: 0x170029EA RID: 10730
		// (get) Token: 0x0600B74D RID: 46925 RVA: 0x00104C9D File Offset: 0x00102E9D
		// (set) Token: 0x0600B74E RID: 46926 RVA: 0x00104CB6 File Offset: 0x00102EB6
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

		// Token: 0x170029EB RID: 10731
		// (get) Token: 0x0600B74F RID: 46927 RVA: 0x00104CE6 File Offset: 0x00102EE6
		// (set) Token: 0x0600B750 RID: 46928 RVA: 0x00104CFF File Offset: 0x00102EFF
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

		// Token: 0x170029EC RID: 10732
		// (get) Token: 0x0600B751 RID: 46929 RVA: 0x00104D2F File Offset: 0x00102F2F
		// (set) Token: 0x0600B752 RID: 46930 RVA: 0x00104D48 File Offset: 0x00102F48
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

		// Token: 0x170029ED RID: 10733
		// (get) Token: 0x0600B753 RID: 46931 RVA: 0x00104D78 File Offset: 0x00102F78
		// (set) Token: 0x0600B754 RID: 46932 RVA: 0x00104D91 File Offset: 0x00102F91
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

		// Token: 0x170029EE RID: 10734
		// (get) Token: 0x0600B755 RID: 46933 RVA: 0x00104DC1 File Offset: 0x00102FC1
		// (set) Token: 0x0600B756 RID: 46934 RVA: 0x00104DDA File Offset: 0x00102FDA
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

		// Token: 0x170029EF RID: 10735
		// (get) Token: 0x0600B757 RID: 46935 RVA: 0x00104E0A File Offset: 0x0010300A
		// (set) Token: 0x0600B758 RID: 46936 RVA: 0x00104E23 File Offset: 0x00103023
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

		// Token: 0x170029F0 RID: 10736
		// (get) Token: 0x0600B759 RID: 46937 RVA: 0x00104E53 File Offset: 0x00103053
		// (set) Token: 0x0600B75A RID: 46938 RVA: 0x00104E6C File Offset: 0x0010306C
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

		// Token: 0x170029F1 RID: 10737
		// (get) Token: 0x0600B75B RID: 46939 RVA: 0x00104E9C File Offset: 0x0010309C
		// (set) Token: 0x0600B75C RID: 46940 RVA: 0x00104EB5 File Offset: 0x001030B5
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

		// Token: 0x170029F2 RID: 10738
		// (get) Token: 0x0600B75D RID: 46941 RVA: 0x00104EE5 File Offset: 0x001030E5
		// (set) Token: 0x0600B75E RID: 46942 RVA: 0x00104EFE File Offset: 0x001030FE
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

		// Token: 0x170029F3 RID: 10739
		// (get) Token: 0x0600B75F RID: 46943 RVA: 0x00104F2E File Offset: 0x0010312E
		// (set) Token: 0x0600B760 RID: 46944 RVA: 0x00104F47 File Offset: 0x00103147
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

		// Token: 0x170029F4 RID: 10740
		// (get) Token: 0x0600B761 RID: 46945 RVA: 0x00104F77 File Offset: 0x00103177
		// (set) Token: 0x0600B762 RID: 46946 RVA: 0x00104F90 File Offset: 0x00103190
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

		// Token: 0x170029F5 RID: 10741
		// (get) Token: 0x0600B763 RID: 46947 RVA: 0x00104FC0 File Offset: 0x001031C0
		// (set) Token: 0x0600B764 RID: 46948 RVA: 0x00104FD0 File Offset: 0x001031D0
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

		// Token: 0x170029F6 RID: 10742
		// (get) Token: 0x0600B765 RID: 46949 RVA: 0x00104FE1 File Offset: 0x001031E1
		// (set) Token: 0x0600B766 RID: 46950 RVA: 0x00104FF1 File Offset: 0x001031F1
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

		// Token: 0x170029F7 RID: 10743
		// (get) Token: 0x0600B767 RID: 46951 RVA: 0x00105002 File Offset: 0x00103202
		// (set) Token: 0x0600B768 RID: 46952 RVA: 0x00105012 File Offset: 0x00103212
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

		// Token: 0x170029F8 RID: 10744
		// (get) Token: 0x0600B769 RID: 46953 RVA: 0x00105023 File Offset: 0x00103223
		// (set) Token: 0x0600B76A RID: 46954 RVA: 0x00105033 File Offset: 0x00103233
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

		// Token: 0x170029F9 RID: 10745
		// (get) Token: 0x0600B76B RID: 46955 RVA: 0x00105044 File Offset: 0x00103244
		// (set) Token: 0x0600B76C RID: 46956 RVA: 0x00105054 File Offset: 0x00103254
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

		// Token: 0x0600B76D RID: 46957 RVA: 0x00105065 File Offset: 0x00103265
		public void SetSamplesPerPixel(int NewValue)
		{
			ULightComponentBase.__SetSamplesPerPixel_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x0600B76E RID: 46958 RVA: 0x00105073 File Offset: 0x00103273
		public void SetCastVolumetricShadow(bool bNewValue)
		{
			ULightComponentBase.__SetCastVolumetricShadow_Internal(base.NativePtr, bNewValue);
		}

		// Token: 0x0600B76F RID: 46959 RVA: 0x00105081 File Offset: 0x00103281
		public void SetCastShadows(bool bNewValue)
		{
			ULightComponentBase.__SetCastShadows_Internal(base.NativePtr, bNewValue);
		}

		// Token: 0x0600B770 RID: 46960 RVA: 0x0010508F File Offset: 0x0010328F
		public void SetCastRaytracedShadow(bool bNewValue)
		{
			ULightComponentBase.__SetCastRaytracedShadow_Internal(base.NativePtr, bNewValue);
		}

		// Token: 0x0600B771 RID: 46961 RVA: 0x0010509D File Offset: 0x0010329D
		public void SetCastDeepShadow(bool bNewValue)
		{
			ULightComponentBase.__SetCastDeepShadow_Internal(base.NativePtr, bNewValue);
		}

		// Token: 0x0600B772 RID: 46962 RVA: 0x001050AB File Offset: 0x001032AB
		public void SetAffectReflection(bool bNewValue)
		{
			ULightComponentBase.__SetAffectReflection_Internal(base.NativePtr, bNewValue);
		}

		// Token: 0x0600B773 RID: 46963 RVA: 0x001050B9 File Offset: 0x001032B9
		public void SetAffectGlobalIllumination(bool bNewValue)
		{
			ULightComponentBase.__SetAffectGlobalIllumination_Internal(base.NativePtr, bNewValue);
		}

		// Token: 0x0600B774 RID: 46964 RVA: 0x001050C7 File Offset: 0x001032C7
		public FLinearColor GetLightColor()
		{
			return ULightComponentBase.__GetLightColor_Internal(base.NativePtr);
		}

		// Token: 0x0600B775 RID: 46965 RVA: 0x001050D4 File Offset: 0x001032D4
		public bool GetCastShadows()
		{
			return ULightComponentBase.__GetCastShadows_Internal(base.NativePtr);
		}

		// Token: 0x0600B776 RID: 46966
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSamplesPerPixel_Internal(IntPtr @this, int NewValue);

		// Token: 0x0600B777 RID: 46967
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCastVolumetricShadow_Internal(IntPtr @this, bool bNewValue);

		// Token: 0x0600B778 RID: 46968
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCastShadows_Internal(IntPtr @this, bool bNewValue);

		// Token: 0x0600B779 RID: 46969
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCastRaytracedShadow_Internal(IntPtr @this, bool bNewValue);

		// Token: 0x0600B77A RID: 46970
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCastDeepShadow_Internal(IntPtr @this, bool bNewValue);

		// Token: 0x0600B77B RID: 46971
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAffectReflection_Internal(IntPtr @this, bool bNewValue);

		// Token: 0x0600B77C RID: 46972
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAffectGlobalIllumination_Internal(IntPtr @this, bool bNewValue);

		// Token: 0x0600B77D RID: 46973
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FLinearColor __GetLightColor_Internal(IntPtr @this);

		// Token: 0x0600B77E RID: 46974
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetCastShadows_Internal(IntPtr @this);

		// Token: 0x0600B77F RID: 46975 RVA: 0x001050E1 File Offset: 0x001032E1
		static ULightComponentBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.LightComponentBase");
		}

		// Token: 0x0600B780 RID: 46976 RVA: 0x001050F0 File Offset: 0x001032F0
		protected ULightComponentBase() : this(BuiltinUtils.AllocNativeUObject(ULightComponentBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600B781 RID: 46977 RVA: 0x00105118 File Offset: 0x00103318
		protected ULightComponentBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04005FFE RID: 24574
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.LightComponentBase";

		// Token: 0x04005FFF RID: 24575
		private static IntPtr _ClassPtr;

		// Token: 0x04006000 RID: 24576
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04006001 RID: 24577
		internal static int __PropertyOffset_LightGuid;

		// Token: 0x04006002 RID: 24578
		internal static int __PropertyOffset_Brightness_DEPRECATED;

		// Token: 0x04006003 RID: 24579
		internal static int __PropertyOffset_Intensity;

		// Token: 0x04006004 RID: 24580
		internal static int __PropertyOffset_LightColor;

		// Token: 0x04006005 RID: 24581
		internal static int __PropertyOffset_bAffectsWorld;

		// Token: 0x04006006 RID: 24582
		internal static byte __PropertyMask_bAffectsWorld;

		// Token: 0x04006007 RID: 24583
		internal static int __PropertyOffset_CastShadows;

		// Token: 0x04006008 RID: 24584
		internal static byte __PropertyMask_CastShadows;

		// Token: 0x04006009 RID: 24585
		internal static int __PropertyOffset_CastStaticShadows;

		// Token: 0x0400600A RID: 24586
		internal static byte __PropertyMask_CastStaticShadows;

		// Token: 0x0400600B RID: 24587
		internal static int __PropertyOffset_CastDynamicShadows;

		// Token: 0x0400600C RID: 24588
		internal static byte __PropertyMask_CastDynamicShadows;

		// Token: 0x0400600D RID: 24589
		internal static int __PropertyOffset_bAffectTranslucentLighting;

		// Token: 0x0400600E RID: 24590
		internal static byte __PropertyMask_bAffectTranslucentLighting;

		// Token: 0x0400600F RID: 24591
		internal static int __PropertyOffset_bTransmission;

		// Token: 0x04006010 RID: 24592
		internal static byte __PropertyMask_bTransmission;

		// Token: 0x04006011 RID: 24593
		internal static int __PropertyOffset_bCastVolumetricShadow;

		// Token: 0x04006012 RID: 24594
		internal static byte __PropertyMask_bCastVolumetricShadow;

		// Token: 0x04006013 RID: 24595
		internal static int __PropertyOffset_bCastDeepShadow;

		// Token: 0x04006014 RID: 24596
		internal static byte __PropertyMask_bCastDeepShadow;

		// Token: 0x04006015 RID: 24597
		internal static int __PropertyOffset_bCastRaytracedShadow;

		// Token: 0x04006016 RID: 24598
		internal static byte __PropertyMask_bCastRaytracedShadow;

		// Token: 0x04006017 RID: 24599
		internal static int __PropertyOffset_bAffectReflection;

		// Token: 0x04006018 RID: 24600
		internal static byte __PropertyMask_bAffectReflection;

		// Token: 0x04006019 RID: 24601
		internal static int __PropertyOffset_bAffectGlobalIllumination;

		// Token: 0x0400601A RID: 24602
		internal static byte __PropertyMask_bAffectGlobalIllumination;

		// Token: 0x0400601B RID: 24603
		internal static int __PropertyOffset_DeepShadowLayerDistribution;

		// Token: 0x0400601C RID: 24604
		internal static int __PropertyOffset_IndirectLightingIntensity;

		// Token: 0x0400601D RID: 24605
		internal static int __PropertyOffset_VolumetricScatteringIntensity;

		// Token: 0x0400601E RID: 24606
		internal static int __PropertyOffset_VolumetricFogScatteringIntensity;

		// Token: 0x0400601F RID: 24607
		internal static int __PropertyOffset_SamplesPerPixel;
	}
}
