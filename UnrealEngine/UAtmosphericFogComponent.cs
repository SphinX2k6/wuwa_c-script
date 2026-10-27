using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000865 RID: 2149
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.AtmosphericFogComponent")]
	[UnrealStructLayout(1184, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1184)]
	public class UAtmosphericFogComponent : USceneComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060073D2 RID: 29650 RVA: 0x000A63FB File Offset: 0x000A45FB
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAtmosphericFogComponent._ClassPtr;
		}

		// Token: 0x060073D3 RID: 29651 RVA: 0x000A6408 File Offset: 0x000A4608
		public UAtmosphericFogComponent() : this(BuiltinUtils.AllocNativeUObject(UAtmosphericFogComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060073D4 RID: 29652 RVA: 0x000A6430 File Offset: 0x000A4630
		[NullableContext(1)]
		public UAtmosphericFogComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAtmosphericFogComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001B4C RID: 6988
		// (get) Token: 0x060073D5 RID: 29653 RVA: 0x000A6463 File Offset: 0x000A4663
		// (set) Token: 0x060073D6 RID: 29654 RVA: 0x000A6473 File Offset: 0x000A4673
		public unsafe float SunMultiplier
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAtmosphericFogComponent.__PropertyOffset_SunMultiplier);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAtmosphericFogComponent.__PropertyOffset_SunMultiplier) = value;
			}
		}

		// Token: 0x17001B4D RID: 6989
		// (get) Token: 0x060073D7 RID: 29655 RVA: 0x000A6484 File Offset: 0x000A4684
		// (set) Token: 0x060073D8 RID: 29656 RVA: 0x000A6494 File Offset: 0x000A4694
		public unsafe float FogMultiplier
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAtmosphericFogComponent.__PropertyOffset_FogMultiplier);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAtmosphericFogComponent.__PropertyOffset_FogMultiplier) = value;
			}
		}

		// Token: 0x17001B4E RID: 6990
		// (get) Token: 0x060073D9 RID: 29657 RVA: 0x000A64A5 File Offset: 0x000A46A5
		// (set) Token: 0x060073DA RID: 29658 RVA: 0x000A64B5 File Offset: 0x000A46B5
		public unsafe float DensityMultiplier
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAtmosphericFogComponent.__PropertyOffset_DensityMultiplier);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAtmosphericFogComponent.__PropertyOffset_DensityMultiplier) = value;
			}
		}

		// Token: 0x17001B4F RID: 6991
		// (get) Token: 0x060073DB RID: 29659 RVA: 0x000A64C6 File Offset: 0x000A46C6
		// (set) Token: 0x060073DC RID: 29660 RVA: 0x000A64D6 File Offset: 0x000A46D6
		public unsafe float DensityOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAtmosphericFogComponent.__PropertyOffset_DensityOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAtmosphericFogComponent.__PropertyOffset_DensityOffset) = value;
			}
		}

		// Token: 0x17001B50 RID: 6992
		// (get) Token: 0x060073DD RID: 29661 RVA: 0x000A64E7 File Offset: 0x000A46E7
		// (set) Token: 0x060073DE RID: 29662 RVA: 0x000A64F7 File Offset: 0x000A46F7
		public unsafe float DistanceScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAtmosphericFogComponent.__PropertyOffset_DistanceScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAtmosphericFogComponent.__PropertyOffset_DistanceScale) = value;
			}
		}

		// Token: 0x17001B51 RID: 6993
		// (get) Token: 0x060073DF RID: 29663 RVA: 0x000A6508 File Offset: 0x000A4708
		// (set) Token: 0x060073E0 RID: 29664 RVA: 0x000A6518 File Offset: 0x000A4718
		public unsafe float AltitudeScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAtmosphericFogComponent.__PropertyOffset_AltitudeScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAtmosphericFogComponent.__PropertyOffset_AltitudeScale) = value;
			}
		}

		// Token: 0x17001B52 RID: 6994
		// (get) Token: 0x060073E1 RID: 29665 RVA: 0x000A6529 File Offset: 0x000A4729
		// (set) Token: 0x060073E2 RID: 29666 RVA: 0x000A6539 File Offset: 0x000A4739
		public unsafe float DistanceOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAtmosphericFogComponent.__PropertyOffset_DistanceOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAtmosphericFogComponent.__PropertyOffset_DistanceOffset) = value;
			}
		}

		// Token: 0x17001B53 RID: 6995
		// (get) Token: 0x060073E3 RID: 29667 RVA: 0x000A654A File Offset: 0x000A474A
		// (set) Token: 0x060073E4 RID: 29668 RVA: 0x000A655A File Offset: 0x000A475A
		public unsafe float GroundOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAtmosphericFogComponent.__PropertyOffset_GroundOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAtmosphericFogComponent.__PropertyOffset_GroundOffset) = value;
			}
		}

		// Token: 0x17001B54 RID: 6996
		// (get) Token: 0x060073E5 RID: 29669 RVA: 0x000A656B File Offset: 0x000A476B
		// (set) Token: 0x060073E6 RID: 29670 RVA: 0x000A657B File Offset: 0x000A477B
		public unsafe float StartDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAtmosphericFogComponent.__PropertyOffset_StartDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAtmosphericFogComponent.__PropertyOffset_StartDistance) = value;
			}
		}

		// Token: 0x17001B55 RID: 6997
		// (get) Token: 0x060073E7 RID: 29671 RVA: 0x000A658C File Offset: 0x000A478C
		// (set) Token: 0x060073E8 RID: 29672 RVA: 0x000A659C File Offset: 0x000A479C
		public unsafe float SunDiscScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAtmosphericFogComponent.__PropertyOffset_SunDiscScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAtmosphericFogComponent.__PropertyOffset_SunDiscScale) = value;
			}
		}

		// Token: 0x17001B56 RID: 6998
		// (get) Token: 0x060073E9 RID: 29673 RVA: 0x000A65AD File Offset: 0x000A47AD
		// (set) Token: 0x060073EA RID: 29674 RVA: 0x000A65BD File Offset: 0x000A47BD
		public unsafe float DefaultBrightness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAtmosphericFogComponent.__PropertyOffset_DefaultBrightness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAtmosphericFogComponent.__PropertyOffset_DefaultBrightness) = value;
			}
		}

		// Token: 0x17001B57 RID: 6999
		// (get) Token: 0x060073EB RID: 29675 RVA: 0x000A65CE File Offset: 0x000A47CE
		// (set) Token: 0x060073EC RID: 29676 RVA: 0x000A65E2 File Offset: 0x000A47E2
		public unsafe FColor DefaultLightColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAtmosphericFogComponent.__PropertyOffset_DefaultLightColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAtmosphericFogComponent.__PropertyOffset_DefaultLightColor) = value;
			}
		}

		// Token: 0x17001B58 RID: 7000
		// (get) Token: 0x060073ED RID: 29677 RVA: 0x000A65F7 File Offset: 0x000A47F7
		// (set) Token: 0x060073EE RID: 29678 RVA: 0x000A6610 File Offset: 0x000A4810
		public unsafe bool bDisableSunDisk
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UAtmosphericFogComponent.__PropertyOffset_bDisableSunDisk) & UAtmosphericFogComponent.__PropertyMask_bDisableSunDisk) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UAtmosphericFogComponent.__PropertyOffset_bDisableSunDisk) = ((*(base.NativePtr + (IntPtr)UAtmosphericFogComponent.__PropertyOffset_bDisableSunDisk) & ~UAtmosphericFogComponent.__PropertyMask_bDisableSunDisk) | (value ? UAtmosphericFogComponent.__PropertyMask_bDisableSunDisk : 0));
			}
		}

		// Token: 0x17001B59 RID: 7001
		// (get) Token: 0x060073EF RID: 29679 RVA: 0x000A6640 File Offset: 0x000A4840
		// (set) Token: 0x060073F0 RID: 29680 RVA: 0x000A6659 File Offset: 0x000A4859
		public unsafe bool bAtmosphereAffectsSunIlluminance
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UAtmosphericFogComponent.__PropertyOffset_bAtmosphereAffectsSunIlluminance) & UAtmosphericFogComponent.__PropertyMask_bAtmosphereAffectsSunIlluminance) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UAtmosphericFogComponent.__PropertyOffset_bAtmosphereAffectsSunIlluminance) = ((*(base.NativePtr + (IntPtr)UAtmosphericFogComponent.__PropertyOffset_bAtmosphereAffectsSunIlluminance) & ~UAtmosphericFogComponent.__PropertyMask_bAtmosphereAffectsSunIlluminance) | (value ? UAtmosphericFogComponent.__PropertyMask_bAtmosphereAffectsSunIlluminance : 0));
			}
		}

		// Token: 0x17001B5A RID: 7002
		// (get) Token: 0x060073F1 RID: 29681 RVA: 0x000A6689 File Offset: 0x000A4889
		// (set) Token: 0x060073F2 RID: 29682 RVA: 0x000A66A2 File Offset: 0x000A48A2
		public unsafe bool bDisableGroundScattering
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UAtmosphericFogComponent.__PropertyOffset_bDisableGroundScattering) & UAtmosphericFogComponent.__PropertyMask_bDisableGroundScattering) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UAtmosphericFogComponent.__PropertyOffset_bDisableGroundScattering) = ((*(base.NativePtr + (IntPtr)UAtmosphericFogComponent.__PropertyOffset_bDisableGroundScattering) & ~UAtmosphericFogComponent.__PropertyMask_bDisableGroundScattering) | (value ? UAtmosphericFogComponent.__PropertyMask_bDisableGroundScattering : 0));
			}
		}

		// Token: 0x17001B5B RID: 7003
		// (get) Token: 0x060073F3 RID: 29683 RVA: 0x000A66D4 File Offset: 0x000A48D4
		// (set) Token: 0x060073F4 RID: 29684 RVA: 0x000A670D File Offset: 0x000A490D
		[Nullable(1)]
		public FAtmospherePrecomputeParameters PrecomputeParams
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FAtmospherePrecomputeParameters result;
				if ((result = this._PrecomputeParams) == null)
				{
					result = (this._PrecomputeParams = new FAtmospherePrecomputeParameters(base.NativePtr + (IntPtr)UAtmosphericFogComponent.__PropertyOffset_PrecomputeParams, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FAtmospherePrecomputeParameters.StaticStruct(), base.NativePtr + (IntPtr)UAtmosphericFogComponent.__PropertyOffset_PrecomputeParams, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001B5C RID: 7004
		// (get) Token: 0x060073F5 RID: 29685 RVA: 0x000A672E File Offset: 0x000A492E
		// (set) Token: 0x060073F6 RID: 29686 RVA: 0x000A6742 File Offset: 0x000A4942
		public unsafe UTexture2D TransmittanceTexture_DEPRECATED
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + UAtmosphericFogComponent.__PropertyOffset_TransmittanceTexture_DEPRECATED);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UAtmosphericFogComponent.__PropertyOffset_TransmittanceTexture_DEPRECATED, value);
			}
		}

		// Token: 0x17001B5D RID: 7005
		// (get) Token: 0x060073F7 RID: 29687 RVA: 0x000A6757 File Offset: 0x000A4957
		// (set) Token: 0x060073F8 RID: 29688 RVA: 0x000A676B File Offset: 0x000A496B
		public unsafe UTexture2D IrradianceTexture_DEPRECATED
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + UAtmosphericFogComponent.__PropertyOffset_IrradianceTexture_DEPRECATED);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UAtmosphericFogComponent.__PropertyOffset_IrradianceTexture_DEPRECATED, value);
			}
		}

		// Token: 0x060073F9 RID: 29689 RVA: 0x000A6780 File Offset: 0x000A4980
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void StartPrecompute()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UAtmosphericFogComponent.__StartPrecompute_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060073FA RID: 29690 RVA: 0x000A6795 File Offset: 0x000A4995
		public void SetSunMultiplier(float NewSunMultiplier)
		{
			UAtmosphericFogComponent.__SetSunMultiplier_Internal(base.NativePtr, NewSunMultiplier);
		}

		// Token: 0x060073FB RID: 29691 RVA: 0x000A67A3 File Offset: 0x000A49A3
		public void SetStartDistance(float NewStartDistance)
		{
			UAtmosphericFogComponent.__SetStartDistance_Internal(base.NativePtr, NewStartDistance);
		}

		// Token: 0x060073FC RID: 29692 RVA: 0x000A67B1 File Offset: 0x000A49B1
		public void SetPrecomputeParams(float DensityHeight, int MaxScatteringOrder, int InscatterAltitudeSampleNum)
		{
			UAtmosphericFogComponent.__SetPrecomputeParams_Internal(base.NativePtr, DensityHeight, MaxScatteringOrder, InscatterAltitudeSampleNum);
		}

		// Token: 0x060073FD RID: 29693 RVA: 0x000A67C1 File Offset: 0x000A49C1
		public void SetFogMultiplier(float NewFogMultiplier)
		{
			UAtmosphericFogComponent.__SetFogMultiplier_Internal(base.NativePtr, NewFogMultiplier);
		}

		// Token: 0x060073FE RID: 29694 RVA: 0x000A67CF File Offset: 0x000A49CF
		public void SetDistanceScale(float NewDistanceScale)
		{
			UAtmosphericFogComponent.__SetDistanceScale_Internal(base.NativePtr, NewDistanceScale);
		}

		// Token: 0x060073FF RID: 29695 RVA: 0x000A67DD File Offset: 0x000A49DD
		public void SetDistanceOffset(float NewDistanceOffset)
		{
			UAtmosphericFogComponent.__SetDistanceOffset_Internal(base.NativePtr, NewDistanceOffset);
		}

		// Token: 0x06007400 RID: 29696 RVA: 0x000A67EB File Offset: 0x000A49EB
		public void SetDensityOffset(float NewDensityOffset)
		{
			UAtmosphericFogComponent.__SetDensityOffset_Internal(base.NativePtr, NewDensityOffset);
		}

		// Token: 0x06007401 RID: 29697 RVA: 0x000A67F9 File Offset: 0x000A49F9
		public void SetDensityMultiplier(float NewDensityMultiplier)
		{
			UAtmosphericFogComponent.__SetDensityMultiplier_Internal(base.NativePtr, NewDensityMultiplier);
		}

		// Token: 0x06007402 RID: 29698 RVA: 0x000A6807 File Offset: 0x000A4A07
		public void SetDefaultLightColor(FLinearColor NewLightColor)
		{
			UAtmosphericFogComponent.__SetDefaultLightColor_Internal(base.NativePtr, NewLightColor);
		}

		// Token: 0x06007403 RID: 29699 RVA: 0x000A6815 File Offset: 0x000A4A15
		public void SetDefaultBrightness(float NewBrightness)
		{
			UAtmosphericFogComponent.__SetDefaultBrightness_Internal(base.NativePtr, NewBrightness);
		}

		// Token: 0x06007404 RID: 29700 RVA: 0x000A6823 File Offset: 0x000A4A23
		public void SetAltitudeScale(float NewAltitudeScale)
		{
			UAtmosphericFogComponent.__SetAltitudeScale_Internal(base.NativePtr, NewAltitudeScale);
		}

		// Token: 0x06007405 RID: 29701 RVA: 0x000A6831 File Offset: 0x000A4A31
		public void DisableSunDisk(bool NewSunDisk)
		{
			UAtmosphericFogComponent.__DisableSunDisk_Internal(base.NativePtr, NewSunDisk);
		}

		// Token: 0x06007406 RID: 29702 RVA: 0x000A683F File Offset: 0x000A4A3F
		public void DisableGroundScattering(bool NewGroundScattering)
		{
			UAtmosphericFogComponent.__DisableGroundScattering_Internal(base.NativePtr, NewGroundScattering);
		}

		// Token: 0x06007407 RID: 29703
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSunMultiplier_Internal(IntPtr @this, float NewSunMultiplier);

		// Token: 0x06007408 RID: 29704
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetStartDistance_Internal(IntPtr @this, float NewStartDistance);

		// Token: 0x06007409 RID: 29705
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPrecomputeParams_Internal(IntPtr @this, float DensityHeight, int MaxScatteringOrder, int InscatterAltitudeSampleNum);

		// Token: 0x0600740A RID: 29706
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetFogMultiplier_Internal(IntPtr @this, float NewFogMultiplier);

		// Token: 0x0600740B RID: 29707
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDistanceScale_Internal(IntPtr @this, float NewDistanceScale);

		// Token: 0x0600740C RID: 29708
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDistanceOffset_Internal(IntPtr @this, float NewDistanceOffset);

		// Token: 0x0600740D RID: 29709
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDensityOffset_Internal(IntPtr @this, float NewDensityOffset);

		// Token: 0x0600740E RID: 29710
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDensityMultiplier_Internal(IntPtr @this, float NewDensityMultiplier);

		// Token: 0x0600740F RID: 29711
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDefaultLightColor_Internal(IntPtr @this, FLinearColor NewLightColor);

		// Token: 0x06007410 RID: 29712
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDefaultBrightness_Internal(IntPtr @this, float NewBrightness);

		// Token: 0x06007411 RID: 29713
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAltitudeScale_Internal(IntPtr @this, float NewAltitudeScale);

		// Token: 0x06007412 RID: 29714
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DisableSunDisk_Internal(IntPtr @this, bool NewSunDisk);

		// Token: 0x06007413 RID: 29715
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DisableGroundScattering_Internal(IntPtr @this, bool NewGroundScattering);

		// Token: 0x06007414 RID: 29716 RVA: 0x000A684D File Offset: 0x000A4A4D
		static UAtmosphericFogComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.AtmosphericFogComponent");
		}

		// Token: 0x06007415 RID: 29717 RVA: 0x000A685B File Offset: 0x000A4A5B
		protected UAtmosphericFogComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040037BF RID: 14271
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.AtmosphericFogComponent";

		// Token: 0x040037C0 RID: 14272
		private static IntPtr _ClassPtr;

		// Token: 0x040037C1 RID: 14273
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040037C2 RID: 14274
		internal static int __PropertyOffset_SunMultiplier;

		// Token: 0x040037C3 RID: 14275
		internal static int __PropertyOffset_FogMultiplier;

		// Token: 0x040037C4 RID: 14276
		internal static int __PropertyOffset_DensityMultiplier;

		// Token: 0x040037C5 RID: 14277
		internal static int __PropertyOffset_DensityOffset;

		// Token: 0x040037C6 RID: 14278
		internal static int __PropertyOffset_DistanceScale;

		// Token: 0x040037C7 RID: 14279
		internal static int __PropertyOffset_AltitudeScale;

		// Token: 0x040037C8 RID: 14280
		internal static int __PropertyOffset_DistanceOffset;

		// Token: 0x040037C9 RID: 14281
		internal static int __PropertyOffset_GroundOffset;

		// Token: 0x040037CA RID: 14282
		internal static int __PropertyOffset_StartDistance;

		// Token: 0x040037CB RID: 14283
		internal static int __PropertyOffset_SunDiscScale;

		// Token: 0x040037CC RID: 14284
		internal static int __PropertyOffset_DefaultBrightness;

		// Token: 0x040037CD RID: 14285
		internal static int __PropertyOffset_DefaultLightColor;

		// Token: 0x040037CE RID: 14286
		internal static int __PropertyOffset_bDisableSunDisk;

		// Token: 0x040037CF RID: 14287
		internal static byte __PropertyMask_bDisableSunDisk;

		// Token: 0x040037D0 RID: 14288
		internal static int __PropertyOffset_bAtmosphereAffectsSunIlluminance;

		// Token: 0x040037D1 RID: 14289
		internal static byte __PropertyMask_bAtmosphereAffectsSunIlluminance;

		// Token: 0x040037D2 RID: 14290
		internal static int __PropertyOffset_bDisableGroundScattering;

		// Token: 0x040037D3 RID: 14291
		internal static byte __PropertyMask_bDisableGroundScattering;

		// Token: 0x040037D4 RID: 14292
		internal static int __PropertyOffset_PrecomputeParams;

		// Token: 0x040037D5 RID: 14293
		private FAtmospherePrecomputeParameters _PrecomputeParams;

		// Token: 0x040037D6 RID: 14294
		internal static int __PropertyOffset_TransmittanceTexture_DEPRECATED;

		// Token: 0x040037D7 RID: 14295
		internal static int __PropertyOffset_IrradianceTexture_DEPRECATED;

		// Token: 0x040037D8 RID: 14296
		private static IntPtr __StartPrecompute_NativeFunctionPtr;
	}
}
