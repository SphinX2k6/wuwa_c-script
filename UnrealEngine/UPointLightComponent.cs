using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000265 RID: 613
	[UnrealObjectPath("/Script/Engine.PointLightComponent")]
	[UnrealStructLayout(1264, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1264)]
	public class UPointLightComponent : ULocalLightComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06003672 RID: 13938 RVA: 0x0004CCAB File Offset: 0x0004AEAB
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UPointLightComponent._ClassPtr;
		}

		// Token: 0x06003673 RID: 13939 RVA: 0x0004CCB8 File Offset: 0x0004AEB8
		public UPointLightComponent() : this(BuiltinUtils.AllocNativeUObject(UPointLightComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06003674 RID: 13940 RVA: 0x0004CCE0 File Offset: 0x0004AEE0
		[NullableContext(1)]
		public UPointLightComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UPointLightComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170007BA RID: 1978
		// (get) Token: 0x06003675 RID: 13941 RVA: 0x0004CD13 File Offset: 0x0004AF13
		// (set) Token: 0x06003676 RID: 13942 RVA: 0x0004CD23 File Offset: 0x0004AF23
		public unsafe float PointLightShadowDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPointLightComponent.__PropertyOffset_PointLightShadowDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPointLightComponent.__PropertyOffset_PointLightShadowDistance) = value;
			}
		}

		// Token: 0x170007BB RID: 1979
		// (get) Token: 0x06003677 RID: 13943 RVA: 0x0004CD34 File Offset: 0x0004AF34
		// (set) Token: 0x06003678 RID: 13944 RVA: 0x0004CD44 File Offset: 0x0004AF44
		public unsafe float PointShadowFadeDistancePercent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPointLightComponent.__PropertyOffset_PointShadowFadeDistancePercent);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPointLightComponent.__PropertyOffset_PointShadowFadeDistancePercent) = value;
			}
		}

		// Token: 0x170007BC RID: 1980
		// (get) Token: 0x06003679 RID: 13945 RVA: 0x0004CD55 File Offset: 0x0004AF55
		// (set) Token: 0x0600367A RID: 13946 RVA: 0x0004CD6E File Offset: 0x0004AF6E
		public unsafe bool bUseInverseSquaredFalloff
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UPointLightComponent.__PropertyOffset_bUseInverseSquaredFalloff) & UPointLightComponent.__PropertyMask_bUseInverseSquaredFalloff) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UPointLightComponent.__PropertyOffset_bUseInverseSquaredFalloff) = ((*(base.NativePtr + (IntPtr)UPointLightComponent.__PropertyOffset_bUseInverseSquaredFalloff) & ~UPointLightComponent.__PropertyMask_bUseInverseSquaredFalloff) | (value ? UPointLightComponent.__PropertyMask_bUseInverseSquaredFalloff : 0));
			}
		}

		// Token: 0x170007BD RID: 1981
		// (get) Token: 0x0600367B RID: 13947 RVA: 0x0004CD9E File Offset: 0x0004AF9E
		// (set) Token: 0x0600367C RID: 13948 RVA: 0x0004CDAE File Offset: 0x0004AFAE
		public unsafe float LightFalloffExponent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPointLightComponent.__PropertyOffset_LightFalloffExponent);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPointLightComponent.__PropertyOffset_LightFalloffExponent) = value;
			}
		}

		// Token: 0x170007BE RID: 1982
		// (get) Token: 0x0600367D RID: 13949 RVA: 0x0004CDBF File Offset: 0x0004AFBF
		// (set) Token: 0x0600367E RID: 13950 RVA: 0x0004CDCF File Offset: 0x0004AFCF
		public unsafe float SourceRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPointLightComponent.__PropertyOffset_SourceRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPointLightComponent.__PropertyOffset_SourceRadius) = value;
			}
		}

		// Token: 0x170007BF RID: 1983
		// (get) Token: 0x0600367F RID: 13951 RVA: 0x0004CDE0 File Offset: 0x0004AFE0
		// (set) Token: 0x06003680 RID: 13952 RVA: 0x0004CDF0 File Offset: 0x0004AFF0
		public unsafe float SoftSourceRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPointLightComponent.__PropertyOffset_SoftSourceRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPointLightComponent.__PropertyOffset_SoftSourceRadius) = value;
			}
		}

		// Token: 0x170007C0 RID: 1984
		// (get) Token: 0x06003681 RID: 13953 RVA: 0x0004CE01 File Offset: 0x0004B001
		// (set) Token: 0x06003682 RID: 13954 RVA: 0x0004CE11 File Offset: 0x0004B011
		public unsafe float SourceLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPointLightComponent.__PropertyOffset_SourceLength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPointLightComponent.__PropertyOffset_SourceLength) = value;
			}
		}

		// Token: 0x170007C1 RID: 1985
		// (get) Token: 0x06003683 RID: 13955 RVA: 0x0004CE22 File Offset: 0x0004B022
		// (set) Token: 0x06003684 RID: 13956 RVA: 0x0004CE32 File Offset: 0x0004B032
		public unsafe bool bEnableRainLightParameter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPointLightComponent.__PropertyOffset_bEnableRainLightParameter) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPointLightComponent.__PropertyOffset_bEnableRainLightParameter) = (value ? 1 : 0);
			}
		}

		// Token: 0x170007C2 RID: 1986
		// (get) Token: 0x06003685 RID: 13957 RVA: 0x0004CE43 File Offset: 0x0004B043
		// (set) Token: 0x06003686 RID: 13958 RVA: 0x0004CE53 File Offset: 0x0004B053
		public unsafe float SourceRadius_Rain
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPointLightComponent.__PropertyOffset_SourceRadius_Rain);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPointLightComponent.__PropertyOffset_SourceRadius_Rain) = value;
			}
		}

		// Token: 0x170007C3 RID: 1987
		// (get) Token: 0x06003687 RID: 13959 RVA: 0x0004CE64 File Offset: 0x0004B064
		// (set) Token: 0x06003688 RID: 13960 RVA: 0x0004CE74 File Offset: 0x0004B074
		public unsafe float SoftSourceRadius_Rain
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPointLightComponent.__PropertyOffset_SoftSourceRadius_Rain);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPointLightComponent.__PropertyOffset_SoftSourceRadius_Rain) = value;
			}
		}

		// Token: 0x170007C4 RID: 1988
		// (get) Token: 0x06003689 RID: 13961 RVA: 0x0004CE85 File Offset: 0x0004B085
		// (set) Token: 0x0600368A RID: 13962 RVA: 0x0004CE95 File Offset: 0x0004B095
		public unsafe float SourceLength_Rain
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPointLightComponent.__PropertyOffset_SourceLength_Rain);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPointLightComponent.__PropertyOffset_SourceLength_Rain) = value;
			}
		}

		// Token: 0x170007C5 RID: 1989
		// (get) Token: 0x0600368B RID: 13963 RVA: 0x0004CEA6 File Offset: 0x0004B0A6
		// (set) Token: 0x0600368C RID: 13964 RVA: 0x0004CEBF File Offset: 0x0004B0BF
		public unsafe bool bCastSpecialPrimShadow
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UPointLightComponent.__PropertyOffset_bCastSpecialPrimShadow) & UPointLightComponent.__PropertyMask_bCastSpecialPrimShadow) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UPointLightComponent.__PropertyOffset_bCastSpecialPrimShadow) = ((*(base.NativePtr + (IntPtr)UPointLightComponent.__PropertyOffset_bCastSpecialPrimShadow) & ~UPointLightComponent.__PropertyMask_bCastSpecialPrimShadow) | (value ? UPointLightComponent.__PropertyMask_bCastSpecialPrimShadow : 0));
			}
		}

		// Token: 0x170007C6 RID: 1990
		// (get) Token: 0x0600368D RID: 13965 RVA: 0x0004CEEF File Offset: 0x0004B0EF
		// (set) Token: 0x0600368E RID: 13966 RVA: 0x0004CEFF File Offset: 0x0004B0FF
		public unsafe bool bExcludeFromTODLightManager
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPointLightComponent.__PropertyOffset_bExcludeFromTODLightManager) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPointLightComponent.__PropertyOffset_bExcludeFromTODLightManager) = (value ? 1 : 0);
			}
		}

		// Token: 0x170007C7 RID: 1991
		// (get) Token: 0x0600368F RID: 13967 RVA: 0x0004CF10 File Offset: 0x0004B110
		// (set) Token: 0x06003690 RID: 13968 RVA: 0x0004CF20 File Offset: 0x0004B120
		public unsafe bool bKuroMirrorAttenuation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPointLightComponent.__PropertyOffset_bKuroMirrorAttenuation) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPointLightComponent.__PropertyOffset_bKuroMirrorAttenuation) = (value ? 1 : 0);
			}
		}

		// Token: 0x170007C8 RID: 1992
		// (get) Token: 0x06003691 RID: 13969 RVA: 0x0004CF31 File Offset: 0x0004B131
		// (set) Token: 0x06003692 RID: 13970 RVA: 0x0004CF41 File Offset: 0x0004B141
		public unsafe float KuroAttenuationNearDist
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPointLightComponent.__PropertyOffset_KuroAttenuationNearDist);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPointLightComponent.__PropertyOffset_KuroAttenuationNearDist) = value;
			}
		}

		// Token: 0x170007C9 RID: 1993
		// (get) Token: 0x06003693 RID: 13971 RVA: 0x0004CF52 File Offset: 0x0004B152
		// (set) Token: 0x06003694 RID: 13972 RVA: 0x0004CF62 File Offset: 0x0004B162
		public unsafe float KuroAttenuationNearBlur
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPointLightComponent.__PropertyOffset_KuroAttenuationNearBlur);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPointLightComponent.__PropertyOffset_KuroAttenuationNearBlur) = value;
			}
		}

		// Token: 0x170007CA RID: 1994
		// (get) Token: 0x06003695 RID: 13973 RVA: 0x0004CF73 File Offset: 0x0004B173
		// (set) Token: 0x06003696 RID: 13974 RVA: 0x0004CF83 File Offset: 0x0004B183
		public unsafe float KuroConeSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPointLightComponent.__PropertyOffset_KuroConeSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPointLightComponent.__PropertyOffset_KuroConeSize) = value;
			}
		}

		// Token: 0x170007CB RID: 1995
		// (get) Token: 0x06003697 RID: 13975 RVA: 0x0004CF94 File Offset: 0x0004B194
		// (set) Token: 0x06003698 RID: 13976 RVA: 0x0004CFA4 File Offset: 0x0004B1A4
		public unsafe float KuroConeBlurSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPointLightComponent.__PropertyOffset_KuroConeBlurSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPointLightComponent.__PropertyOffset_KuroConeBlurSize) = value;
			}
		}

		// Token: 0x170007CC RID: 1996
		// (get) Token: 0x06003699 RID: 13977 RVA: 0x0004CFB5 File Offset: 0x0004B1B5
		// (set) Token: 0x0600369A RID: 13978 RVA: 0x0004CFC5 File Offset: 0x0004B1C5
		public unsafe float KuroRectSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPointLightComponent.__PropertyOffset_KuroRectSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPointLightComponent.__PropertyOffset_KuroRectSize) = value;
			}
		}

		// Token: 0x170007CD RID: 1997
		// (get) Token: 0x0600369B RID: 13979 RVA: 0x0004CFD6 File Offset: 0x0004B1D6
		// (set) Token: 0x0600369C RID: 13980 RVA: 0x0004CFE6 File Offset: 0x0004B1E6
		public unsafe float KuroRectBlurSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPointLightComponent.__PropertyOffset_KuroRectBlurSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPointLightComponent.__PropertyOffset_KuroRectBlurSize) = value;
			}
		}

		// Token: 0x0600369D RID: 13981 RVA: 0x0004CFF7 File Offset: 0x0004B1F7
		public void SetSourceRadius(float bNewValue)
		{
			UPointLightComponent.__SetSourceRadius_Internal(base.NativePtr, bNewValue);
		}

		// Token: 0x0600369E RID: 13982 RVA: 0x0004D005 File Offset: 0x0004B205
		public void SetSourceLength(float NewValue)
		{
			UPointLightComponent.__SetSourceLength_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x0600369F RID: 13983 RVA: 0x0004D013 File Offset: 0x0004B213
		public void SetSoftSourceRadius(float bNewValue)
		{
			UPointLightComponent.__SetSoftSourceRadius_Internal(base.NativePtr, bNewValue);
		}

		// Token: 0x060036A0 RID: 13984 RVA: 0x0004D021 File Offset: 0x0004B221
		public void SetRainLerp(float NewValue)
		{
			UPointLightComponent.__SetRainLerp_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x060036A1 RID: 13985 RVA: 0x0004D02F File Offset: 0x0004B22F
		public void SetLightFalloffExponent(float NewLightFalloffExponent)
		{
			UPointLightComponent.__SetLightFalloffExponent_Internal(base.NativePtr, NewLightFalloffExponent);
		}

		// Token: 0x060036A2 RID: 13986
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSourceRadius_Internal(IntPtr @this, float bNewValue);

		// Token: 0x060036A3 RID: 13987
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSourceLength_Internal(IntPtr @this, float NewValue);

		// Token: 0x060036A4 RID: 13988
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSoftSourceRadius_Internal(IntPtr @this, float bNewValue);

		// Token: 0x060036A5 RID: 13989
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetRainLerp_Internal(IntPtr @this, float NewValue);

		// Token: 0x060036A6 RID: 13990
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLightFalloffExponent_Internal(IntPtr @this, float NewLightFalloffExponent);

		// Token: 0x060036A7 RID: 13991 RVA: 0x0004D03D File Offset: 0x0004B23D
		static UPointLightComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.PointLightComponent");
		}

		// Token: 0x060036A8 RID: 13992 RVA: 0x0004D04B File Offset: 0x0004B24B
		protected UPointLightComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040012BD RID: 4797
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.PointLightComponent";

		// Token: 0x040012BE RID: 4798
		private static IntPtr _ClassPtr;

		// Token: 0x040012BF RID: 4799
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040012C0 RID: 4800
		internal static int __PropertyOffset_PointLightShadowDistance;

		// Token: 0x040012C1 RID: 4801
		internal static int __PropertyOffset_PointShadowFadeDistancePercent;

		// Token: 0x040012C2 RID: 4802
		internal static int __PropertyOffset_bUseInverseSquaredFalloff;

		// Token: 0x040012C3 RID: 4803
		internal static byte __PropertyMask_bUseInverseSquaredFalloff;

		// Token: 0x040012C4 RID: 4804
		internal static int __PropertyOffset_LightFalloffExponent;

		// Token: 0x040012C5 RID: 4805
		internal static int __PropertyOffset_SourceRadius;

		// Token: 0x040012C6 RID: 4806
		internal static int __PropertyOffset_SoftSourceRadius;

		// Token: 0x040012C7 RID: 4807
		internal static int __PropertyOffset_SourceLength;

		// Token: 0x040012C8 RID: 4808
		internal static int __PropertyOffset_bEnableRainLightParameter;

		// Token: 0x040012C9 RID: 4809
		internal static int __PropertyOffset_SourceRadius_Rain;

		// Token: 0x040012CA RID: 4810
		internal static int __PropertyOffset_SoftSourceRadius_Rain;

		// Token: 0x040012CB RID: 4811
		internal static int __PropertyOffset_SourceLength_Rain;

		// Token: 0x040012CC RID: 4812
		internal static int __PropertyOffset_bCastSpecialPrimShadow;

		// Token: 0x040012CD RID: 4813
		internal static byte __PropertyMask_bCastSpecialPrimShadow;

		// Token: 0x040012CE RID: 4814
		internal static int __PropertyOffset_bExcludeFromTODLightManager;

		// Token: 0x040012CF RID: 4815
		internal static int __PropertyOffset_bKuroMirrorAttenuation;

		// Token: 0x040012D0 RID: 4816
		internal static int __PropertyOffset_KuroAttenuationNearDist;

		// Token: 0x040012D1 RID: 4817
		internal static int __PropertyOffset_KuroAttenuationNearBlur;

		// Token: 0x040012D2 RID: 4818
		internal static int __PropertyOffset_KuroConeSize;

		// Token: 0x040012D3 RID: 4819
		internal static int __PropertyOffset_KuroConeBlurSize;

		// Token: 0x040012D4 RID: 4820
		internal static int __PropertyOffset_KuroRectSize;

		// Token: 0x040012D5 RID: 4821
		internal static int __PropertyOffset_KuroRectBlurSize;
	}
}
