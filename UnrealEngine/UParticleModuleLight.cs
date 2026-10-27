using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F71 RID: 3953
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.ParticleModuleLight")]
	[UnrealStructLayout(296, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 296)]
	public class UParticleModuleLight : UParticleModuleLightBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600D52D RID: 54573 RVA: 0x00139781 File Offset: 0x00137981
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UParticleModuleLight._ClassPtr;
		}

		// Token: 0x0600D52E RID: 54574 RVA: 0x00139790 File Offset: 0x00137990
		public UParticleModuleLight() : this(BuiltinUtils.AllocNativeUObject(UParticleModuleLight.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600D52F RID: 54575 RVA: 0x001397B8 File Offset: 0x001379B8
		public UParticleModuleLight(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UParticleModuleLight.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170031FF RID: 12799
		// (get) Token: 0x0600D530 RID: 54576 RVA: 0x001397EB File Offset: 0x001379EB
		// (set) Token: 0x0600D531 RID: 54577 RVA: 0x001397FB File Offset: 0x001379FB
		public unsafe bool bUseInverseSquaredFalloff
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleLight.__PropertyOffset_bUseInverseSquaredFalloff) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleLight.__PropertyOffset_bUseInverseSquaredFalloff) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003200 RID: 12800
		// (get) Token: 0x0600D532 RID: 54578 RVA: 0x0013980C File Offset: 0x00137A0C
		// (set) Token: 0x0600D533 RID: 54579 RVA: 0x0013981C File Offset: 0x00137A1C
		public unsafe bool bAffectsTranslucency
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleLight.__PropertyOffset_bAffectsTranslucency) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleLight.__PropertyOffset_bAffectsTranslucency) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003201 RID: 12801
		// (get) Token: 0x0600D534 RID: 54580 RVA: 0x0013982D File Offset: 0x00137A2D
		// (set) Token: 0x0600D535 RID: 54581 RVA: 0x0013983D File Offset: 0x00137A3D
		public unsafe bool bPreviewLightRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleLight.__PropertyOffset_bPreviewLightRadius) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleLight.__PropertyOffset_bPreviewLightRadius) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003202 RID: 12802
		// (get) Token: 0x0600D536 RID: 54582 RVA: 0x0013984E File Offset: 0x00137A4E
		// (set) Token: 0x0600D537 RID: 54583 RVA: 0x0013985E File Offset: 0x00137A5E
		public unsafe float SpawnFraction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleLight.__PropertyOffset_SpawnFraction);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleLight.__PropertyOffset_SpawnFraction) = value;
			}
		}

		// Token: 0x17003203 RID: 12803
		// (get) Token: 0x0600D538 RID: 54584 RVA: 0x00139870 File Offset: 0x00137A70
		// (set) Token: 0x0600D539 RID: 54585 RVA: 0x001398A9 File Offset: 0x00137AA9
		public FRawDistributionVector ColorScaleOverLife
		{
			get
			{
				base.FastCheckIsValid();
				FRawDistributionVector result;
				if ((result = this._ColorScaleOverLife) == null)
				{
					result = (this._ColorScaleOverLife = new FRawDistributionVector(base.NativePtr + (IntPtr)UParticleModuleLight.__PropertyOffset_ColorScaleOverLife, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRawDistributionVector.StaticStruct(), base.NativePtr + (IntPtr)UParticleModuleLight.__PropertyOffset_ColorScaleOverLife, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003204 RID: 12804
		// (get) Token: 0x0600D53A RID: 54586 RVA: 0x001398CC File Offset: 0x00137ACC
		// (set) Token: 0x0600D53B RID: 54587 RVA: 0x00139905 File Offset: 0x00137B05
		public FRawDistributionFloat BrightnessOverLife
		{
			get
			{
				base.FastCheckIsValid();
				FRawDistributionFloat result;
				if ((result = this._BrightnessOverLife) == null)
				{
					result = (this._BrightnessOverLife = new FRawDistributionFloat(base.NativePtr + (IntPtr)UParticleModuleLight.__PropertyOffset_BrightnessOverLife, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRawDistributionFloat.StaticStruct(), base.NativePtr + (IntPtr)UParticleModuleLight.__PropertyOffset_BrightnessOverLife, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003205 RID: 12805
		// (get) Token: 0x0600D53C RID: 54588 RVA: 0x00139928 File Offset: 0x00137B28
		// (set) Token: 0x0600D53D RID: 54589 RVA: 0x00139961 File Offset: 0x00137B61
		public FRawDistributionFloat RadiusScale
		{
			get
			{
				base.FastCheckIsValid();
				FRawDistributionFloat result;
				if ((result = this._RadiusScale) == null)
				{
					result = (this._RadiusScale = new FRawDistributionFloat(base.NativePtr + (IntPtr)UParticleModuleLight.__PropertyOffset_RadiusScale, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRawDistributionFloat.StaticStruct(), base.NativePtr + (IntPtr)UParticleModuleLight.__PropertyOffset_RadiusScale, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003206 RID: 12806
		// (get) Token: 0x0600D53E RID: 54590 RVA: 0x00139984 File Offset: 0x00137B84
		// (set) Token: 0x0600D53F RID: 54591 RVA: 0x001399BD File Offset: 0x00137BBD
		public FRawDistributionFloat LightExponent
		{
			get
			{
				base.FastCheckIsValid();
				FRawDistributionFloat result;
				if ((result = this._LightExponent) == null)
				{
					result = (this._LightExponent = new FRawDistributionFloat(base.NativePtr + (IntPtr)UParticleModuleLight.__PropertyOffset_LightExponent, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRawDistributionFloat.StaticStruct(), base.NativePtr + (IntPtr)UParticleModuleLight.__PropertyOffset_LightExponent, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003207 RID: 12807
		// (get) Token: 0x0600D540 RID: 54592 RVA: 0x001399E0 File Offset: 0x00137BE0
		// (set) Token: 0x0600D541 RID: 54593 RVA: 0x00139A19 File Offset: 0x00137C19
		public FLightingChannels LightingChannels
		{
			get
			{
				base.FastCheckIsValid();
				FLightingChannels result;
				if ((result = this._LightingChannels) == null)
				{
					result = (this._LightingChannels = new FLightingChannels(base.NativePtr + (IntPtr)UParticleModuleLight.__PropertyOffset_LightingChannels, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FLightingChannels.StaticStruct(), base.NativePtr + (IntPtr)UParticleModuleLight.__PropertyOffset_LightingChannels, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003208 RID: 12808
		// (get) Token: 0x0600D542 RID: 54594 RVA: 0x00139A3A File Offset: 0x00137C3A
		// (set) Token: 0x0600D543 RID: 54595 RVA: 0x00139A4A File Offset: 0x00137C4A
		public unsafe float VolumetricScatteringIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleLight.__PropertyOffset_VolumetricScatteringIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleLight.__PropertyOffset_VolumetricScatteringIntensity) = value;
			}
		}

		// Token: 0x17003209 RID: 12809
		// (get) Token: 0x0600D544 RID: 54596 RVA: 0x00139A5B File Offset: 0x00137C5B
		// (set) Token: 0x0600D545 RID: 54597 RVA: 0x00139A6B File Offset: 0x00137C6B
		public unsafe bool bHighQualityLights
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleLight.__PropertyOffset_bHighQualityLights) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleLight.__PropertyOffset_bHighQualityLights) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700320A RID: 12810
		// (get) Token: 0x0600D546 RID: 54598 RVA: 0x00139A7C File Offset: 0x00137C7C
		// (set) Token: 0x0600D547 RID: 54599 RVA: 0x00139A8C File Offset: 0x00137C8C
		public unsafe bool bShadowCastingLights
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleLight.__PropertyOffset_bShadowCastingLights) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleLight.__PropertyOffset_bShadowCastingLights) = (value ? 1 : 0);
			}
		}

		// Token: 0x0600D548 RID: 54600 RVA: 0x00139A9D File Offset: 0x00137C9D
		static UParticleModuleLight()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ParticleModuleLight");
		}

		// Token: 0x0600D549 RID: 54601 RVA: 0x00139AAB File Offset: 0x00137CAB
		protected UParticleModuleLight(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040072E5 RID: 29413
		public new const string __ObjectPath = "/Script/Engine.ParticleModuleLight";

		// Token: 0x040072E6 RID: 29414
		private static IntPtr _ClassPtr;

		// Token: 0x040072E7 RID: 29415
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040072E8 RID: 29416
		internal static int __PropertyOffset_bUseInverseSquaredFalloff;

		// Token: 0x040072E9 RID: 29417
		internal static int __PropertyOffset_bAffectsTranslucency;

		// Token: 0x040072EA RID: 29418
		internal static int __PropertyOffset_bPreviewLightRadius;

		// Token: 0x040072EB RID: 29419
		internal static int __PropertyOffset_SpawnFraction;

		// Token: 0x040072EC RID: 29420
		internal static int __PropertyOffset_ColorScaleOverLife;

		// Token: 0x040072ED RID: 29421
		[Nullable(2)]
		private FRawDistributionVector _ColorScaleOverLife;

		// Token: 0x040072EE RID: 29422
		internal static int __PropertyOffset_BrightnessOverLife;

		// Token: 0x040072EF RID: 29423
		[Nullable(2)]
		private FRawDistributionFloat _BrightnessOverLife;

		// Token: 0x040072F0 RID: 29424
		internal static int __PropertyOffset_RadiusScale;

		// Token: 0x040072F1 RID: 29425
		[Nullable(2)]
		private FRawDistributionFloat _RadiusScale;

		// Token: 0x040072F2 RID: 29426
		internal static int __PropertyOffset_LightExponent;

		// Token: 0x040072F3 RID: 29427
		[Nullable(2)]
		private FRawDistributionFloat _LightExponent;

		// Token: 0x040072F4 RID: 29428
		internal static int __PropertyOffset_LightingChannels;

		// Token: 0x040072F5 RID: 29429
		[Nullable(2)]
		private FLightingChannels _LightingChannels;

		// Token: 0x040072F6 RID: 29430
		internal static int __PropertyOffset_VolumetricScatteringIntensity;

		// Token: 0x040072F7 RID: 29431
		internal static int __PropertyOffset_bHighQualityLights;

		// Token: 0x040072F8 RID: 29432
		internal static int __PropertyOffset_bShadowCastingLights;
	}
}
