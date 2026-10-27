using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001017 RID: 4119
	[UnrealObjectPath("/Script/Engine.PointLightComponent")]
	[UnrealStructLayout(1248, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1248)]
	public class UPointLightComponent : ULocalLightComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600E126 RID: 57638 RVA: 0x0014B047 File Offset: 0x00149247
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UPointLightComponent._ClassPtr;
		}

		// Token: 0x0600E127 RID: 57639 RVA: 0x0014B054 File Offset: 0x00149254
		public UPointLightComponent() : this(BuiltinUtils.AllocNativeUObject(UPointLightComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600E128 RID: 57640 RVA: 0x0014B07C File Offset: 0x0014927C
		[NullableContext(1)]
		public UPointLightComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UPointLightComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170034DC RID: 13532
		// (get) Token: 0x0600E129 RID: 57641 RVA: 0x0014B0AF File Offset: 0x001492AF
		// (set) Token: 0x0600E12A RID: 57642 RVA: 0x0014B0BF File Offset: 0x001492BF
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

		// Token: 0x170034DD RID: 13533
		// (get) Token: 0x0600E12B RID: 57643 RVA: 0x0014B0D0 File Offset: 0x001492D0
		// (set) Token: 0x0600E12C RID: 57644 RVA: 0x0014B0E0 File Offset: 0x001492E0
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

		// Token: 0x170034DE RID: 13534
		// (get) Token: 0x0600E12D RID: 57645 RVA: 0x0014B0F1 File Offset: 0x001492F1
		// (set) Token: 0x0600E12E RID: 57646 RVA: 0x0014B10A File Offset: 0x0014930A
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

		// Token: 0x170034DF RID: 13535
		// (get) Token: 0x0600E12F RID: 57647 RVA: 0x0014B13A File Offset: 0x0014933A
		// (set) Token: 0x0600E130 RID: 57648 RVA: 0x0014B14A File Offset: 0x0014934A
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

		// Token: 0x170034E0 RID: 13536
		// (get) Token: 0x0600E131 RID: 57649 RVA: 0x0014B15B File Offset: 0x0014935B
		// (set) Token: 0x0600E132 RID: 57650 RVA: 0x0014B16B File Offset: 0x0014936B
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

		// Token: 0x170034E1 RID: 13537
		// (get) Token: 0x0600E133 RID: 57651 RVA: 0x0014B17C File Offset: 0x0014937C
		// (set) Token: 0x0600E134 RID: 57652 RVA: 0x0014B18C File Offset: 0x0014938C
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

		// Token: 0x170034E2 RID: 13538
		// (get) Token: 0x0600E135 RID: 57653 RVA: 0x0014B19D File Offset: 0x0014939D
		// (set) Token: 0x0600E136 RID: 57654 RVA: 0x0014B1AD File Offset: 0x001493AD
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

		// Token: 0x170034E3 RID: 13539
		// (get) Token: 0x0600E137 RID: 57655 RVA: 0x0014B1BE File Offset: 0x001493BE
		// (set) Token: 0x0600E138 RID: 57656 RVA: 0x0014B1CE File Offset: 0x001493CE
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

		// Token: 0x170034E4 RID: 13540
		// (get) Token: 0x0600E139 RID: 57657 RVA: 0x0014B1DF File Offset: 0x001493DF
		// (set) Token: 0x0600E13A RID: 57658 RVA: 0x0014B1EF File Offset: 0x001493EF
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

		// Token: 0x170034E5 RID: 13541
		// (get) Token: 0x0600E13B RID: 57659 RVA: 0x0014B200 File Offset: 0x00149400
		// (set) Token: 0x0600E13C RID: 57660 RVA: 0x0014B210 File Offset: 0x00149410
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

		// Token: 0x170034E6 RID: 13542
		// (get) Token: 0x0600E13D RID: 57661 RVA: 0x0014B221 File Offset: 0x00149421
		// (set) Token: 0x0600E13E RID: 57662 RVA: 0x0014B231 File Offset: 0x00149431
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

		// Token: 0x170034E7 RID: 13543
		// (get) Token: 0x0600E13F RID: 57663 RVA: 0x0014B242 File Offset: 0x00149442
		// (set) Token: 0x0600E140 RID: 57664 RVA: 0x0014B25B File Offset: 0x0014945B
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

		// Token: 0x170034E8 RID: 13544
		// (get) Token: 0x0600E141 RID: 57665 RVA: 0x0014B28B File Offset: 0x0014948B
		// (set) Token: 0x0600E142 RID: 57666 RVA: 0x0014B29B File Offset: 0x0014949B
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

		// Token: 0x170034E9 RID: 13545
		// (get) Token: 0x0600E143 RID: 57667 RVA: 0x0014B2AC File Offset: 0x001494AC
		// (set) Token: 0x0600E144 RID: 57668 RVA: 0x0014B2BC File Offset: 0x001494BC
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

		// Token: 0x170034EA RID: 13546
		// (get) Token: 0x0600E145 RID: 57669 RVA: 0x0014B2CD File Offset: 0x001494CD
		// (set) Token: 0x0600E146 RID: 57670 RVA: 0x0014B2DD File Offset: 0x001494DD
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

		// Token: 0x170034EB RID: 13547
		// (get) Token: 0x0600E147 RID: 57671 RVA: 0x0014B2EE File Offset: 0x001494EE
		// (set) Token: 0x0600E148 RID: 57672 RVA: 0x0014B2FE File Offset: 0x001494FE
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

		// Token: 0x170034EC RID: 13548
		// (get) Token: 0x0600E149 RID: 57673 RVA: 0x0014B30F File Offset: 0x0014950F
		// (set) Token: 0x0600E14A RID: 57674 RVA: 0x0014B31F File Offset: 0x0014951F
		public unsafe EKuroLightAttenuationShape KuroLightAttenuationShape
		{
			get
			{
				return (EKuroLightAttenuationShape)(*(base.NativePtr + (IntPtr)UPointLightComponent.__PropertyOffset_KuroLightAttenuationShape));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPointLightComponent.__PropertyOffset_KuroLightAttenuationShape) = (byte)value;
			}
		}

		// Token: 0x170034ED RID: 13549
		// (get) Token: 0x0600E14B RID: 57675 RVA: 0x0014B330 File Offset: 0x00149530
		// (set) Token: 0x0600E14C RID: 57676 RVA: 0x0014B340 File Offset: 0x00149540
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

		// Token: 0x170034EE RID: 13550
		// (get) Token: 0x0600E14D RID: 57677 RVA: 0x0014B351 File Offset: 0x00149551
		// (set) Token: 0x0600E14E RID: 57678 RVA: 0x0014B361 File Offset: 0x00149561
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

		// Token: 0x170034EF RID: 13551
		// (get) Token: 0x0600E14F RID: 57679 RVA: 0x0014B372 File Offset: 0x00149572
		// (set) Token: 0x0600E150 RID: 57680 RVA: 0x0014B382 File Offset: 0x00149582
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

		// Token: 0x170034F0 RID: 13552
		// (get) Token: 0x0600E151 RID: 57681 RVA: 0x0014B393 File Offset: 0x00149593
		// (set) Token: 0x0600E152 RID: 57682 RVA: 0x0014B3A3 File Offset: 0x001495A3
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

		// Token: 0x0600E153 RID: 57683 RVA: 0x0014B3B4 File Offset: 0x001495B4
		public void SetSourceRadius(float bNewValue)
		{
			UPointLightComponent.__SetSourceRadius_Internal(base.NativePtr, bNewValue);
		}

		// Token: 0x0600E154 RID: 57684 RVA: 0x0014B3C2 File Offset: 0x001495C2
		public void SetSourceLength(float NewValue)
		{
			UPointLightComponent.__SetSourceLength_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x0600E155 RID: 57685 RVA: 0x0014B3D0 File Offset: 0x001495D0
		public void SetSoftSourceRadius(float bNewValue)
		{
			UPointLightComponent.__SetSoftSourceRadius_Internal(base.NativePtr, bNewValue);
		}

		// Token: 0x0600E156 RID: 57686 RVA: 0x0014B3DE File Offset: 0x001495DE
		public void SetRainLerp(float NewValue)
		{
			UPointLightComponent.__SetRainLerp_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x0600E157 RID: 57687 RVA: 0x0014B3EC File Offset: 0x001495EC
		public void SetLightFalloffExponent(float NewLightFalloffExponent)
		{
			UPointLightComponent.__SetLightFalloffExponent_Internal(base.NativePtr, NewLightFalloffExponent);
		}

		// Token: 0x0600E158 RID: 57688
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSourceRadius_Internal(IntPtr @this, float bNewValue);

		// Token: 0x0600E159 RID: 57689
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSourceLength_Internal(IntPtr @this, float NewValue);

		// Token: 0x0600E15A RID: 57690
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSoftSourceRadius_Internal(IntPtr @this, float bNewValue);

		// Token: 0x0600E15B RID: 57691
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetRainLerp_Internal(IntPtr @this, float NewValue);

		// Token: 0x0600E15C RID: 57692
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLightFalloffExponent_Internal(IntPtr @this, float NewLightFalloffExponent);

		// Token: 0x0600E15D RID: 57693 RVA: 0x0014B3FA File Offset: 0x001495FA
		static UPointLightComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.PointLightComponent");
		}

		// Token: 0x0600E15E RID: 57694 RVA: 0x0014B408 File Offset: 0x00149608
		protected UPointLightComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040078EB RID: 30955
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.PointLightComponent";

		// Token: 0x040078EC RID: 30956
		private static IntPtr _ClassPtr;

		// Token: 0x040078ED RID: 30957
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040078EE RID: 30958
		internal static int __PropertyOffset_PointLightShadowDistance;

		// Token: 0x040078EF RID: 30959
		internal static int __PropertyOffset_PointShadowFadeDistancePercent;

		// Token: 0x040078F0 RID: 30960
		internal static int __PropertyOffset_bUseInverseSquaredFalloff;

		// Token: 0x040078F1 RID: 30961
		internal static byte __PropertyMask_bUseInverseSquaredFalloff;

		// Token: 0x040078F2 RID: 30962
		internal static int __PropertyOffset_LightFalloffExponent;

		// Token: 0x040078F3 RID: 30963
		internal static int __PropertyOffset_SourceRadius;

		// Token: 0x040078F4 RID: 30964
		internal static int __PropertyOffset_SoftSourceRadius;

		// Token: 0x040078F5 RID: 30965
		internal static int __PropertyOffset_SourceLength;

		// Token: 0x040078F6 RID: 30966
		internal static int __PropertyOffset_bEnableRainLightParameter;

		// Token: 0x040078F7 RID: 30967
		internal static int __PropertyOffset_SourceRadius_Rain;

		// Token: 0x040078F8 RID: 30968
		internal static int __PropertyOffset_SoftSourceRadius_Rain;

		// Token: 0x040078F9 RID: 30969
		internal static int __PropertyOffset_SourceLength_Rain;

		// Token: 0x040078FA RID: 30970
		internal static int __PropertyOffset_bCastSpecialPrimShadow;

		// Token: 0x040078FB RID: 30971
		internal static byte __PropertyMask_bCastSpecialPrimShadow;

		// Token: 0x040078FC RID: 30972
		internal static int __PropertyOffset_bExcludeFromTODLightManager;

		// Token: 0x040078FD RID: 30973
		internal static int __PropertyOffset_bKuroMirrorAttenuation;

		// Token: 0x040078FE RID: 30974
		internal static int __PropertyOffset_KuroAttenuationNearDist;

		// Token: 0x040078FF RID: 30975
		internal static int __PropertyOffset_KuroAttenuationNearBlur;

		// Token: 0x04007900 RID: 30976
		internal static int __PropertyOffset_KuroLightAttenuationShape;

		// Token: 0x04007901 RID: 30977
		internal static int __PropertyOffset_KuroConeSize;

		// Token: 0x04007902 RID: 30978
		internal static int __PropertyOffset_KuroConeBlurSize;

		// Token: 0x04007903 RID: 30979
		internal static int __PropertyOffset_KuroRectSize;

		// Token: 0x04007904 RID: 30980
		internal static int __PropertyOffset_KuroRectBlurSize;
	}
}
