using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020018A9 RID: 6313
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGameplay.EffectModelPostProcess")]
	[UnrealStructLayout(29368, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 29368)]
	public class UEffectModelPostProcess : UEffectModelBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601744A RID: 95306 RVA: 0x0021F31A File Offset: 0x0021D51A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UEffectModelPostProcess._ClassPtr;
		}

		// Token: 0x0601744B RID: 95307 RVA: 0x0021F328 File Offset: 0x0021D528
		public UEffectModelPostProcess() : this(BuiltinUtils.AllocNativeUObject(UEffectModelPostProcess.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601744C RID: 95308 RVA: 0x0021F350 File Offset: 0x0021D550
		public UEffectModelPostProcess(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UEffectModelPostProcess.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005DAD RID: 23981
		// (get) Token: 0x0601744D RID: 95309 RVA: 0x0021F384 File Offset: 0x0021D584
		// (set) Token: 0x0601744E RID: 95310 RVA: 0x0021F3BD File Offset: 0x0021D5BD
		public FKuroCurveVector Location
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveVector result;
				if ((result = this._Location) == null)
				{
					result = (this._Location = new FKuroCurveVector(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_Location, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveVector.StaticStruct(), base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_Location, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005DAE RID: 23982
		// (get) Token: 0x0601744F RID: 95311 RVA: 0x0021F3DE File Offset: 0x0021D5DE
		// (set) Token: 0x06017450 RID: 95312 RVA: 0x0021F3EE File Offset: 0x0021D5EE
		public unsafe bool EnableVolume
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_EnableVolume) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_EnableVolume) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005DAF RID: 23983
		// (get) Token: 0x06017451 RID: 95313 RVA: 0x0021F3FF File Offset: 0x0021D5FF
		// (set) Token: 0x06017452 RID: 95314 RVA: 0x0021F40F File Offset: 0x0021D60F
		public unsafe float VolumeRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_VolumeRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_VolumeRadius) = value;
			}
		}

		// Token: 0x17005DB0 RID: 23984
		// (get) Token: 0x06017453 RID: 95315 RVA: 0x0021F420 File Offset: 0x0021D620
		// (set) Token: 0x06017454 RID: 95316 RVA: 0x0021F430 File Offset: 0x0021D630
		public unsafe float VolumeHardness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_VolumeHardness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_VolumeHardness) = value;
			}
		}

		// Token: 0x17005DB1 RID: 23985
		// (get) Token: 0x06017455 RID: 95317 RVA: 0x0021F441 File Offset: 0x0021D641
		// (set) Token: 0x06017456 RID: 95318 RVA: 0x0021F451 File Offset: 0x0021D651
		public unsafe bool UseVolumeHardnessCurve
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_UseVolumeHardnessCurve) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_UseVolumeHardnessCurve) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005DB2 RID: 23986
		// (get) Token: 0x06017457 RID: 95319 RVA: 0x0021F464 File Offset: 0x0021D664
		// (set) Token: 0x06017458 RID: 95320 RVA: 0x0021F49D File Offset: 0x0021D69D
		public FKuroCurveFloat VolumeHardnessCurve
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._VolumeHardnessCurve) == null)
				{
					result = (this._VolumeHardnessCurve = new FKuroCurveFloat(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_VolumeHardnessCurve, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_VolumeHardnessCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005DB3 RID: 23987
		// (get) Token: 0x06017459 RID: 95321 RVA: 0x0021F4BE File Offset: 0x0021D6BE
		// (set) Token: 0x0601745A RID: 95322 RVA: 0x0021F4CE File Offset: 0x0021D6CE
		public unsafe float WeatherPriority
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_WeatherPriority);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_WeatherPriority) = value;
			}
		}

		// Token: 0x17005DB4 RID: 23988
		// (get) Token: 0x0601745B RID: 95323 RVA: 0x0021F4DF File Offset: 0x0021D6DF
		// (set) Token: 0x0601745C RID: 95324 RVA: 0x0021F4EF File Offset: 0x0021D6EF
		public unsafe bool VisibleForProtoPlayer
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_VisibleForProtoPlayer) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_VisibleForProtoPlayer) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005DB5 RID: 23989
		// (get) Token: 0x0601745D RID: 95325 RVA: 0x0021F500 File Offset: 0x0021D700
		// (set) Token: 0x0601745E RID: 95326 RVA: 0x0021F510 File Offset: 0x0021D710
		public unsafe bool OverrideTOD
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_OverrideTOD) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_OverrideTOD) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005DB6 RID: 23990
		// (get) Token: 0x0601745F RID: 95327 RVA: 0x0021F521 File Offset: 0x0021D721
		// (set) Token: 0x06017460 RID: 95328 RVA: 0x0021F531 File Offset: 0x0021D731
		public unsafe bool StopWhenActorHidden
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_StopWhenActorHidden) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_StopWhenActorHidden) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005DB7 RID: 23991
		// (get) Token: 0x06017461 RID: 95329 RVA: 0x0021F542 File Offset: 0x0021D742
		// (set) Token: 0x06017462 RID: 95330 RVA: 0x0021F552 File Offset: 0x0021D752
		public unsafe bool bEnablePostprocessMaterial
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_bEnablePostprocessMaterial) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_bEnablePostprocessMaterial) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005DB8 RID: 23992
		// (get) Token: 0x06017463 RID: 95331 RVA: 0x0021F563 File Offset: 0x0021D763
		// (set) Token: 0x06017464 RID: 95332 RVA: 0x0021F577 File Offset: 0x0021D777
		[Nullable(2)]
		public unsafe UMaterialInterface PostprocessMaterial
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + UEffectModelPostProcess.__PropertyOffset_PostprocessMaterial);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UEffectModelPostProcess.__PropertyOffset_PostprocessMaterial, value);
			}
		}

		// Token: 0x17005DB9 RID: 23993
		// (get) Token: 0x06017465 RID: 95333 RVA: 0x0021F58C File Offset: 0x0021D78C
		// (set) Token: 0x06017466 RID: 95334 RVA: 0x0021F5C5 File Offset: 0x0021D7C5
		public TArray<UMaterialInterface> PostprocessMaterialQualityArray
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInterface> result;
				if ((result = this._PostprocessMaterialQualityArray) == null)
				{
					result = (this._PostprocessMaterialQualityArray = new TArray<UMaterialInterface>(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_PostprocessMaterialQualityArray, this));
				}
				return result;
			}
			set
			{
				this.PostprocessMaterialQualityArray.CopyAssign(value);
			}
		}

		// Token: 0x17005DBA RID: 23994
		// (get) Token: 0x06017467 RID: 95335 RVA: 0x0021F5D4 File Offset: 0x0021D7D4
		// (set) Token: 0x06017468 RID: 95336 RVA: 0x0021F60D File Offset: 0x0021D80D
		public TArray<UMaterialInterface> PostprocessMaterialQualityArrayMobile
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInterface> result;
				if ((result = this._PostprocessMaterialQualityArrayMobile) == null)
				{
					result = (this._PostprocessMaterialQualityArrayMobile = new TArray<UMaterialInterface>(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_PostprocessMaterialQualityArrayMobile, this));
				}
				return result;
			}
			set
			{
				this.PostprocessMaterialQualityArrayMobile.CopyAssign(value);
			}
		}

		// Token: 0x17005DBB RID: 23995
		// (get) Token: 0x06017469 RID: 95337 RVA: 0x0021F61C File Offset: 0x0021D81C
		// (set) Token: 0x0601746A RID: 95338 RVA: 0x0021F655 File Offset: 0x0021D855
		public TMap<FName, FKuroCurveFloat> PostprocessMaterialFloatParameters
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FKuroCurveFloat> result;
				if ((result = this._PostprocessMaterialFloatParameters) == null)
				{
					result = (this._PostprocessMaterialFloatParameters = new TMap<FName, FKuroCurveFloat>(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_PostprocessMaterialFloatParameters, this));
				}
				return result;
			}
			set
			{
				this.PostprocessMaterialFloatParameters.CopyAssign(value);
			}
		}

		// Token: 0x17005DBC RID: 23996
		// (get) Token: 0x0601746B RID: 95339 RVA: 0x0021F664 File Offset: 0x0021D864
		// (set) Token: 0x0601746C RID: 95340 RVA: 0x0021F69D File Offset: 0x0021D89D
		public TMap<FName, FKuroCurveLinearColor> PostprocessMaterialColorParameters
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FKuroCurveLinearColor> result;
				if ((result = this._PostprocessMaterialColorParameters) == null)
				{
					result = (this._PostprocessMaterialColorParameters = new TMap<FName, FKuroCurveLinearColor>(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_PostprocessMaterialColorParameters, this));
				}
				return result;
			}
			set
			{
				this.PostprocessMaterialColorParameters.CopyAssign(value);
			}
		}

		// Token: 0x17005DBD RID: 23997
		// (get) Token: 0x0601746D RID: 95341 RVA: 0x0021F6AB File Offset: 0x0021D8AB
		// (set) Token: 0x0601746E RID: 95342 RVA: 0x0021F6BB File Offset: 0x0021D8BB
		public unsafe bool BlurIntensityOverride
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_BlurIntensityOverride) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_BlurIntensityOverride) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005DBE RID: 23998
		// (get) Token: 0x0601746F RID: 95343 RVA: 0x0021F6CC File Offset: 0x0021D8CC
		// (set) Token: 0x06017470 RID: 95344 RVA: 0x0021F705 File Offset: 0x0021D905
		public FKuroCurveFloat BlurIntensity
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._BlurIntensity) == null)
				{
					result = (this._BlurIntensity = new FKuroCurveFloat(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_BlurIntensity, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_BlurIntensity, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005DBF RID: 23999
		// (get) Token: 0x06017471 RID: 95345 RVA: 0x0021F726 File Offset: 0x0021D926
		// (set) Token: 0x06017472 RID: 95346 RVA: 0x0021F736 File Offset: 0x0021D936
		public unsafe bool UseWorldPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_UseWorldPosition) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_UseWorldPosition) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005DC0 RID: 24000
		// (get) Token: 0x06017473 RID: 95347 RVA: 0x0021F747 File Offset: 0x0021D947
		// (set) Token: 0x06017474 RID: 95348 RVA: 0x0021F75B File Offset: 0x0021D95B
		public unsafe FVector2D ScreenPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_ScreenPosition);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_ScreenPosition) = value;
			}
		}

		// Token: 0x17005DC1 RID: 24001
		// (get) Token: 0x06017475 RID: 95349 RVA: 0x0021F770 File Offset: 0x0021D970
		// (set) Token: 0x06017476 RID: 95350 RVA: 0x0021F7A9 File Offset: 0x0021D9A9
		public FKuroCurveFloat RadialBlurRadius
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._RadialBlurRadius) == null)
				{
					result = (this._RadialBlurRadius = new FKuroCurveFloat(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_RadialBlurRadius, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_RadialBlurRadius, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005DC2 RID: 24002
		// (get) Token: 0x06017477 RID: 95351 RVA: 0x0021F7CC File Offset: 0x0021D9CC
		// (set) Token: 0x06017478 RID: 95352 RVA: 0x0021F805 File Offset: 0x0021DA05
		public FKuroCurveFloat RadialBlurHardness
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._RadialBlurHardness) == null)
				{
					result = (this._RadialBlurHardness = new FKuroCurveFloat(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_RadialBlurHardness, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_RadialBlurHardness, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005DC3 RID: 24003
		// (get) Token: 0x06017479 RID: 95353 RVA: 0x0021F826 File Offset: 0x0021DA26
		// (set) Token: 0x0601747A RID: 95354 RVA: 0x0021F83A File Offset: 0x0021DA3A
		[Nullable(2)]
		public unsafe UTexture RadialBlurMask
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture>(base.NativePtr / (IntPtr)sizeof(void*) + UEffectModelPostProcess.__PropertyOffset_RadialBlurMask);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UEffectModelPostProcess.__PropertyOffset_RadialBlurMask, value);
			}
		}

		// Token: 0x17005DC4 RID: 24004
		// (get) Token: 0x0601747B RID: 95355 RVA: 0x0021F84F File Offset: 0x0021DA4F
		// (set) Token: 0x0601747C RID: 95356 RVA: 0x0021F863 File Offset: 0x0021DA63
		public unsafe FVector2D RadialBlurMaskScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_RadialBlurMaskScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_RadialBlurMaskScale) = value;
			}
		}

		// Token: 0x17005DC5 RID: 24005
		// (get) Token: 0x0601747D RID: 95357 RVA: 0x0021F878 File Offset: 0x0021DA78
		// (set) Token: 0x0601747E RID: 95358 RVA: 0x0021F8B1 File Offset: 0x0021DAB1
		public FKuroCurveLinearColor RadialBlurMaskScaleOffset
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveLinearColor result;
				if ((result = this._RadialBlurMaskScaleOffset) == null)
				{
					result = (this._RadialBlurMaskScaleOffset = new FKuroCurveLinearColor(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_RadialBlurMaskScaleOffset, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveLinearColor.StaticStruct(), base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_RadialBlurMaskScaleOffset, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005DC6 RID: 24006
		// (get) Token: 0x0601747F RID: 95359 RVA: 0x0021F8D2 File Offset: 0x0021DAD2
		// (set) Token: 0x06017480 RID: 95360 RVA: 0x0021F8E2 File Offset: 0x0021DAE2
		public unsafe bool MainLightIntensityOverride
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_MainLightIntensityOverride) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_MainLightIntensityOverride) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005DC7 RID: 24007
		// (get) Token: 0x06017481 RID: 95361 RVA: 0x0021F8F4 File Offset: 0x0021DAF4
		// (set) Token: 0x06017482 RID: 95362 RVA: 0x0021F92D File Offset: 0x0021DB2D
		public FKuroCurveFloat MainLightIntensity
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._MainLightIntensity) == null)
				{
					result = (this._MainLightIntensity = new FKuroCurveFloat(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_MainLightIntensity, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_MainLightIntensity, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005DC8 RID: 24008
		// (get) Token: 0x06017483 RID: 95363 RVA: 0x0021F94E File Offset: 0x0021DB4E
		// (set) Token: 0x06017484 RID: 95364 RVA: 0x0021F95E File Offset: 0x0021DB5E
		public unsafe bool MainLightColorOverride
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_MainLightColorOverride) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_MainLightColorOverride) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005DC9 RID: 24009
		// (get) Token: 0x06017485 RID: 95365 RVA: 0x0021F970 File Offset: 0x0021DB70
		// (set) Token: 0x06017486 RID: 95366 RVA: 0x0021F9A9 File Offset: 0x0021DBA9
		public FKuroCurveLinearColor MainLightColor
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveLinearColor result;
				if ((result = this._MainLightColor) == null)
				{
					result = (this._MainLightColor = new FKuroCurveLinearColor(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_MainLightColor, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveLinearColor.StaticStruct(), base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_MainLightColor, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005DCA RID: 24010
		// (get) Token: 0x06017487 RID: 95367 RVA: 0x0021F9CA File Offset: 0x0021DBCA
		// (set) Token: 0x06017488 RID: 95368 RVA: 0x0021F9DA File Offset: 0x0021DBDA
		public unsafe bool SkyLightIntensityOverride
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_SkyLightIntensityOverride) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_SkyLightIntensityOverride) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005DCB RID: 24011
		// (get) Token: 0x06017489 RID: 95369 RVA: 0x0021F9EC File Offset: 0x0021DBEC
		// (set) Token: 0x0601748A RID: 95370 RVA: 0x0021FA25 File Offset: 0x0021DC25
		public FKuroCurveFloat SkyLightIntensity
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._SkyLightIntensity) == null)
				{
					result = (this._SkyLightIntensity = new FKuroCurveFloat(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_SkyLightIntensity, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_SkyLightIntensity, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005DCC RID: 24012
		// (get) Token: 0x0601748B RID: 95371 RVA: 0x0021FA46 File Offset: 0x0021DC46
		// (set) Token: 0x0601748C RID: 95372 RVA: 0x0021FA56 File Offset: 0x0021DC56
		public unsafe bool SkyLightColorOverride
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_SkyLightColorOverride) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_SkyLightColorOverride) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005DCD RID: 24013
		// (get) Token: 0x0601748D RID: 95373 RVA: 0x0021FA68 File Offset: 0x0021DC68
		// (set) Token: 0x0601748E RID: 95374 RVA: 0x0021FAA1 File Offset: 0x0021DCA1
		public FKuroCurveLinearColor SkyLightColor
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveLinearColor result;
				if ((result = this._SkyLightColor) == null)
				{
					result = (this._SkyLightColor = new FKuroCurveLinearColor(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_SkyLightColor, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveLinearColor.StaticStruct(), base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_SkyLightColor, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005DCE RID: 24014
		// (get) Token: 0x0601748F RID: 95375 RVA: 0x0021FAC2 File Offset: 0x0021DCC2
		// (set) Token: 0x06017490 RID: 95376 RVA: 0x0021FAD2 File Offset: 0x0021DCD2
		public unsafe bool EnableEffectFog
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_EnableEffectFog) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_EnableEffectFog) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005DCF RID: 24015
		// (get) Token: 0x06017491 RID: 95377 RVA: 0x0021FAE4 File Offset: 0x0021DCE4
		// (set) Token: 0x06017492 RID: 95378 RVA: 0x0021FB1D File Offset: 0x0021DD1D
		public FKuroCurveFloat EffectFogSwitch
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._EffectFogSwitch) == null)
				{
					result = (this._EffectFogSwitch = new FKuroCurveFloat(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_EffectFogSwitch, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_EffectFogSwitch, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005DD0 RID: 24016
		// (get) Token: 0x06017493 RID: 95379 RVA: 0x0021FB40 File Offset: 0x0021DD40
		// (set) Token: 0x06017494 RID: 95380 RVA: 0x0021FB79 File Offset: 0x0021DD79
		public FKuroCurveFloat KuroEffectFogBlendSceneFogMin
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._KuroEffectFogBlendSceneFogMin) == null)
				{
					result = (this._KuroEffectFogBlendSceneFogMin = new FKuroCurveFloat(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_KuroEffectFogBlendSceneFogMin, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_KuroEffectFogBlendSceneFogMin, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005DD1 RID: 24017
		// (get) Token: 0x06017495 RID: 95381 RVA: 0x0021FB9A File Offset: 0x0021DD9A
		// (set) Token: 0x06017496 RID: 95382 RVA: 0x0021FBAA File Offset: 0x0021DDAA
		public unsafe bool FogDensityOverride
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_FogDensityOverride) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_FogDensityOverride) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005DD2 RID: 24018
		// (get) Token: 0x06017497 RID: 95383 RVA: 0x0021FBBC File Offset: 0x0021DDBC
		// (set) Token: 0x06017498 RID: 95384 RVA: 0x0021FBF5 File Offset: 0x0021DDF5
		public FKuroCurveFloat FogDensity
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._FogDensity) == null)
				{
					result = (this._FogDensity = new FKuroCurveFloat(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_FogDensity, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_FogDensity, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005DD3 RID: 24019
		// (get) Token: 0x06017499 RID: 95385 RVA: 0x0021FC18 File Offset: 0x0021DE18
		// (set) Token: 0x0601749A RID: 95386 RVA: 0x0021FC51 File Offset: 0x0021DE51
		public FKuroCurveFloat FogStartDistance
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._FogStartDistance) == null)
				{
					result = (this._FogStartDistance = new FKuroCurveFloat(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_FogStartDistance, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_FogStartDistance, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005DD4 RID: 24020
		// (get) Token: 0x0601749B RID: 95387 RVA: 0x0021FC72 File Offset: 0x0021DE72
		// (set) Token: 0x0601749C RID: 95388 RVA: 0x0021FC82 File Offset: 0x0021DE82
		public unsafe float FogFalloff
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_FogFalloff);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_FogFalloff) = value;
			}
		}

		// Token: 0x17005DD5 RID: 24021
		// (get) Token: 0x0601749D RID: 95389 RVA: 0x0021FC94 File Offset: 0x0021DE94
		// (set) Token: 0x0601749E RID: 95390 RVA: 0x0021FCCD File Offset: 0x0021DECD
		public FKuroCurveFloat FogMaxOpacity
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._FogMaxOpacity) == null)
				{
					result = (this._FogMaxOpacity = new FKuroCurveFloat(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_FogMaxOpacity, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_FogMaxOpacity, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005DD6 RID: 24022
		// (get) Token: 0x0601749F RID: 95391 RVA: 0x0021FCEE File Offset: 0x0021DEEE
		// (set) Token: 0x060174A0 RID: 95392 RVA: 0x0021FCFE File Offset: 0x0021DEFE
		public unsafe bool FogColorOverride
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_FogColorOverride) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_FogColorOverride) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005DD7 RID: 24023
		// (get) Token: 0x060174A1 RID: 95393 RVA: 0x0021FD10 File Offset: 0x0021DF10
		// (set) Token: 0x060174A2 RID: 95394 RVA: 0x0021FD49 File Offset: 0x0021DF49
		public FKuroCurveLinearColor FogNearColor
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveLinearColor result;
				if ((result = this._FogNearColor) == null)
				{
					result = (this._FogNearColor = new FKuroCurveLinearColor(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_FogNearColor, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveLinearColor.StaticStruct(), base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_FogNearColor, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005DD8 RID: 24024
		// (get) Token: 0x060174A3 RID: 95395 RVA: 0x0021FD6C File Offset: 0x0021DF6C
		// (set) Token: 0x060174A4 RID: 95396 RVA: 0x0021FDA5 File Offset: 0x0021DFA5
		public FKuroCurveLinearColor FogFarColor
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveLinearColor result;
				if ((result = this._FogFarColor) == null)
				{
					result = (this._FogFarColor = new FKuroCurveLinearColor(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_FogFarColor, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveLinearColor.StaticStruct(), base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_FogFarColor, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005DD9 RID: 24025
		// (get) Token: 0x060174A5 RID: 95397 RVA: 0x0021FDC8 File Offset: 0x0021DFC8
		// (set) Token: 0x060174A6 RID: 95398 RVA: 0x0021FE01 File Offset: 0x0021E001
		public FKuroCurveFloat FogNearColorDistance
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._FogNearColorDistance) == null)
				{
					result = (this._FogNearColorDistance = new FKuroCurveFloat(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_FogNearColorDistance, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_FogNearColorDistance, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005DDA RID: 24026
		// (get) Token: 0x060174A7 RID: 95399 RVA: 0x0021FE24 File Offset: 0x0021E024
		// (set) Token: 0x060174A8 RID: 95400 RVA: 0x0021FE5D File Offset: 0x0021E05D
		public FKuroCurveFloat FogFarColorDistance
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._FogFarColorDistance) == null)
				{
					result = (this._FogFarColorDistance = new FKuroCurveFloat(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_FogFarColorDistance, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_FogFarColorDistance, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005DDB RID: 24027
		// (get) Token: 0x060174A9 RID: 95401 RVA: 0x0021FE7E File Offset: 0x0021E07E
		// (set) Token: 0x060174AA RID: 95402 RVA: 0x0021FE8E File Offset: 0x0021E08E
		public unsafe float FogColorRatio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_FogColorRatio);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_FogColorRatio) = value;
			}
		}

		// Token: 0x17005DDC RID: 24028
		// (get) Token: 0x060174AB RID: 95403 RVA: 0x0021FE9F File Offset: 0x0021E09F
		// (set) Token: 0x060174AC RID: 95404 RVA: 0x0021FEAF File Offset: 0x0021E0AF
		public unsafe bool FogDistanceViewOverride
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_FogDistanceViewOverride) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_FogDistanceViewOverride) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005DDD RID: 24029
		// (get) Token: 0x060174AD RID: 95405 RVA: 0x0021FEC0 File Offset: 0x0021E0C0
		// (set) Token: 0x060174AE RID: 95406 RVA: 0x0021FED0 File Offset: 0x0021E0D0
		public unsafe float FogFalloffFarSky
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_FogFalloffFarSky);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_FogFalloffFarSky) = value;
			}
		}

		// Token: 0x17005DDE RID: 24030
		// (get) Token: 0x060174AF RID: 95407 RVA: 0x0021FEE1 File Offset: 0x0021E0E1
		// (set) Token: 0x060174B0 RID: 95408 RVA: 0x0021FEF1 File Offset: 0x0021E0F1
		public unsafe float FogMixDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_FogMixDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_FogMixDistance) = value;
			}
		}

		// Token: 0x17005DDF RID: 24031
		// (get) Token: 0x060174B1 RID: 95409 RVA: 0x0021FF02 File Offset: 0x0021E102
		// (set) Token: 0x060174B2 RID: 95410 RVA: 0x0021FF12 File Offset: 0x0021E112
		public unsafe float FogMixWidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_FogMixWidth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_FogMixWidth) = value;
			}
		}

		// Token: 0x17005DE0 RID: 24032
		// (get) Token: 0x060174B3 RID: 95411 RVA: 0x0021FF23 File Offset: 0x0021E123
		// (set) Token: 0x060174B4 RID: 95412 RVA: 0x0021FF33 File Offset: 0x0021E133
		public unsafe bool KuroBloomIntensityOverride
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_KuroBloomIntensityOverride) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_KuroBloomIntensityOverride) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005DE1 RID: 24033
		// (get) Token: 0x060174B5 RID: 95413 RVA: 0x0021FF44 File Offset: 0x0021E144
		// (set) Token: 0x060174B6 RID: 95414 RVA: 0x0021FF7D File Offset: 0x0021E17D
		public FKuroCurveFloat KuroBloomIntensity
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._KuroBloomIntensity) == null)
				{
					result = (this._KuroBloomIntensity = new FKuroCurveFloat(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_KuroBloomIntensity, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_KuroBloomIntensity, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005DE2 RID: 24034
		// (get) Token: 0x060174B7 RID: 95415 RVA: 0x0021FF9E File Offset: 0x0021E19E
		// (set) Token: 0x060174B8 RID: 95416 RVA: 0x0021FFAE File Offset: 0x0021E1AE
		public unsafe bool KuroThresholdOverride
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_KuroThresholdOverride) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_KuroThresholdOverride) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005DE3 RID: 24035
		// (get) Token: 0x060174B9 RID: 95417 RVA: 0x0021FFC0 File Offset: 0x0021E1C0
		// (set) Token: 0x060174BA RID: 95418 RVA: 0x0021FFF9 File Offset: 0x0021E1F9
		public FKuroCurveFloat KuroThreshold
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._KuroThreshold) == null)
				{
					result = (this._KuroThreshold = new FKuroCurveFloat(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_KuroThreshold, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_KuroThreshold, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005DE4 RID: 24036
		// (get) Token: 0x060174BB RID: 95419 RVA: 0x0022001A File Offset: 0x0021E21A
		// (set) Token: 0x060174BC RID: 95420 RVA: 0x0022002A File Offset: 0x0021E22A
		public unsafe bool SceneFringeIntensityOverride
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_SceneFringeIntensityOverride) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_SceneFringeIntensityOverride) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005DE5 RID: 24037
		// (get) Token: 0x060174BD RID: 95421 RVA: 0x0022003C File Offset: 0x0021E23C
		// (set) Token: 0x060174BE RID: 95422 RVA: 0x00220075 File Offset: 0x0021E275
		public FKuroCurveFloat SceneFringeIntensity
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._SceneFringeIntensity) == null)
				{
					result = (this._SceneFringeIntensity = new FKuroCurveFloat(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_SceneFringeIntensity, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_SceneFringeIntensity, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005DE6 RID: 24038
		// (get) Token: 0x060174BF RID: 95423 RVA: 0x00220096 File Offset: 0x0021E296
		// (set) Token: 0x060174C0 RID: 95424 RVA: 0x002200A6 File Offset: 0x0021E2A6
		public unsafe bool StartOffsetOverride
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_StartOffsetOverride) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_StartOffsetOverride) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005DE7 RID: 24039
		// (get) Token: 0x060174C1 RID: 95425 RVA: 0x002200B8 File Offset: 0x0021E2B8
		// (set) Token: 0x060174C2 RID: 95426 RVA: 0x002200F1 File Offset: 0x0021E2F1
		public FKuroCurveFloat StartOffset
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._StartOffset) == null)
				{
					result = (this._StartOffset = new FKuroCurveFloat(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_StartOffset, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_StartOffset, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005DE8 RID: 24040
		// (get) Token: 0x060174C3 RID: 95427 RVA: 0x00220112 File Offset: 0x0021E312
		// (set) Token: 0x060174C4 RID: 95428 RVA: 0x00220122 File Offset: 0x0021E322
		public unsafe bool VignetteIntensityOverride
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_VignetteIntensityOverride) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_VignetteIntensityOverride) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005DE9 RID: 24041
		// (get) Token: 0x060174C5 RID: 95429 RVA: 0x00220134 File Offset: 0x0021E334
		// (set) Token: 0x060174C6 RID: 95430 RVA: 0x0022016D File Offset: 0x0021E36D
		public FKuroCurveFloat VignetteIntensity
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._VignetteIntensity) == null)
				{
					result = (this._VignetteIntensity = new FKuroCurveFloat(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_VignetteIntensity, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_VignetteIntensity, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005DEA RID: 24042
		// (get) Token: 0x060174C7 RID: 95431 RVA: 0x00220190 File Offset: 0x0021E390
		// (set) Token: 0x060174C8 RID: 95432 RVA: 0x002201C9 File Offset: 0x0021E3C9
		public FKuroCurveFloat VignetteHardness
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._VignetteHardness) == null)
				{
					result = (this._VignetteHardness = new FKuroCurveFloat(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_VignetteHardness, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_VignetteHardness, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005DEB RID: 24043
		// (get) Token: 0x060174C9 RID: 95433 RVA: 0x002201EC File Offset: 0x0021E3EC
		// (set) Token: 0x060174CA RID: 95434 RVA: 0x00220225 File Offset: 0x0021E425
		public FKuroCurveFloat VignetteXScale
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._VignetteXScale) == null)
				{
					result = (this._VignetteXScale = new FKuroCurveFloat(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_VignetteXScale, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_VignetteXScale, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005DEC RID: 24044
		// (get) Token: 0x060174CB RID: 95435 RVA: 0x00220248 File Offset: 0x0021E448
		// (set) Token: 0x060174CC RID: 95436 RVA: 0x00220281 File Offset: 0x0021E481
		public FKuroCurveFloat VignetteYScale
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._VignetteYScale) == null)
				{
					result = (this._VignetteYScale = new FKuroCurveFloat(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_VignetteYScale, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_VignetteYScale, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005DED RID: 24045
		// (get) Token: 0x060174CD RID: 95437 RVA: 0x002202A4 File Offset: 0x0021E4A4
		// (set) Token: 0x060174CE RID: 95438 RVA: 0x002202DD File Offset: 0x0021E4DD
		public FKuroCurveFloat VignetteXPos
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._VignetteXPos) == null)
				{
					result = (this._VignetteXPos = new FKuroCurveFloat(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_VignetteXPos, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_VignetteXPos, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005DEE RID: 24046
		// (get) Token: 0x060174CF RID: 95439 RVA: 0x00220300 File Offset: 0x0021E500
		// (set) Token: 0x060174D0 RID: 95440 RVA: 0x00220339 File Offset: 0x0021E539
		public FKuroCurveFloat VignetteYPos
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._VignetteYPos) == null)
				{
					result = (this._VignetteYPos = new FKuroCurveFloat(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_VignetteYPos, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_VignetteYPos, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005DEF RID: 24047
		// (get) Token: 0x060174D1 RID: 95441 RVA: 0x0022035C File Offset: 0x0021E55C
		// (set) Token: 0x060174D2 RID: 95442 RVA: 0x00220395 File Offset: 0x0021E595
		public FKuroCurveLinearColor VignetteColor
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveLinearColor result;
				if ((result = this._VignetteColor) == null)
				{
					result = (this._VignetteColor = new FKuroCurveLinearColor(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_VignetteColor, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveLinearColor.StaticStruct(), base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_VignetteColor, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005DF0 RID: 24048
		// (get) Token: 0x060174D3 RID: 95443 RVA: 0x002203B8 File Offset: 0x0021E5B8
		// (set) Token: 0x060174D4 RID: 95444 RVA: 0x002203F1 File Offset: 0x0021E5F1
		public FKuroCurveFloat VignetteGain
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._VignetteGain) == null)
				{
					result = (this._VignetteGain = new FKuroCurveFloat(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_VignetteGain, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_VignetteGain, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005DF1 RID: 24049
		// (get) Token: 0x060174D5 RID: 95445 RVA: 0x00220412 File Offset: 0x0021E612
		// (set) Token: 0x060174D6 RID: 95446 RVA: 0x00220422 File Offset: 0x0021E622
		public unsafe bool GrainJitterOverride
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_GrainJitterOverride) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_GrainJitterOverride) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005DF2 RID: 24050
		// (get) Token: 0x060174D7 RID: 95447 RVA: 0x00220434 File Offset: 0x0021E634
		// (set) Token: 0x060174D8 RID: 95448 RVA: 0x0022046D File Offset: 0x0021E66D
		public FKuroCurveFloat GrainJitter
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._GrainJitter) == null)
				{
					result = (this._GrainJitter = new FKuroCurveFloat(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_GrainJitter, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_GrainJitter, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005DF3 RID: 24051
		// (get) Token: 0x060174D9 RID: 95449 RVA: 0x0022048E File Offset: 0x0021E68E
		// (set) Token: 0x060174DA RID: 95450 RVA: 0x0022049E File Offset: 0x0021E69E
		public unsafe bool GrainIntensityOverride
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_GrainIntensityOverride) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_GrainIntensityOverride) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005DF4 RID: 24052
		// (get) Token: 0x060174DB RID: 95451 RVA: 0x002204B0 File Offset: 0x0021E6B0
		// (set) Token: 0x060174DC RID: 95452 RVA: 0x002204E9 File Offset: 0x0021E6E9
		public FKuroCurveFloat GrainIntensity
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._GrainIntensity) == null)
				{
					result = (this._GrainIntensity = new FKuroCurveFloat(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_GrainIntensity, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_GrainIntensity, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005DF5 RID: 24053
		// (get) Token: 0x060174DD RID: 95453 RVA: 0x0022050A File Offset: 0x0021E70A
		// (set) Token: 0x060174DE RID: 95454 RVA: 0x0022051A File Offset: 0x0021E71A
		public unsafe bool LutIntensityOverride
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_LutIntensityOverride) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_LutIntensityOverride) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005DF6 RID: 24054
		// (get) Token: 0x060174DF RID: 95455 RVA: 0x0022052C File Offset: 0x0021E72C
		// (set) Token: 0x060174E0 RID: 95456 RVA: 0x00220565 File Offset: 0x0021E765
		public FKuroCurveFloat LutIntensity
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._LutIntensity) == null)
				{
					result = (this._LutIntensity = new FKuroCurveFloat(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_LutIntensity, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_LutIntensity, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005DF7 RID: 24055
		// (get) Token: 0x060174E1 RID: 95457 RVA: 0x00220586 File Offset: 0x0021E786
		// (set) Token: 0x060174E2 RID: 95458 RVA: 0x00220596 File Offset: 0x0021E796
		public unsafe bool LutTextureOverride
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_LutTextureOverride) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_LutTextureOverride) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005DF8 RID: 24056
		// (get) Token: 0x060174E3 RID: 95459 RVA: 0x002205A7 File Offset: 0x0021E7A7
		// (set) Token: 0x060174E4 RID: 95460 RVA: 0x002205BB File Offset: 0x0021E7BB
		[Nullable(2)]
		public unsafe UTexture2D LutTexture
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + UEffectModelPostProcess.__PropertyOffset_LutTexture);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UEffectModelPostProcess.__PropertyOffset_LutTexture, value);
			}
		}

		// Token: 0x17005DF9 RID: 24057
		// (get) Token: 0x060174E5 RID: 95461 RVA: 0x002205D0 File Offset: 0x0021E7D0
		// (set) Token: 0x060174E6 RID: 95462 RVA: 0x002205E0 File Offset: 0x0021E7E0
		public unsafe bool SceneColorTintOverride
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_SceneColorTintOverride) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_SceneColorTintOverride) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005DFA RID: 24058
		// (get) Token: 0x060174E7 RID: 95463 RVA: 0x002205F4 File Offset: 0x0021E7F4
		// (set) Token: 0x060174E8 RID: 95464 RVA: 0x0022062D File Offset: 0x0021E82D
		public FKuroCurveLinearColor SceneColorTint
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveLinearColor result;
				if ((result = this._SceneColorTint) == null)
				{
					result = (this._SceneColorTint = new FKuroCurveLinearColor(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_SceneColorTint, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveLinearColor.StaticStruct(), base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_SceneColorTint, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005DFB RID: 24059
		// (get) Token: 0x060174E9 RID: 95465 RVA: 0x0022064E File Offset: 0x0021E84E
		// (set) Token: 0x060174EA RID: 95466 RVA: 0x0022065E File Offset: 0x0021E85E
		public unsafe bool SceneColorDesaturateOverride
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_SceneColorDesaturateOverride) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_SceneColorDesaturateOverride) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005DFC RID: 24060
		// (get) Token: 0x060174EB RID: 95467 RVA: 0x00220670 File Offset: 0x0021E870
		// (set) Token: 0x060174EC RID: 95468 RVA: 0x002206A9 File Offset: 0x0021E8A9
		public FKuroCurveFloat SceneColorDesaturate
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._SceneColorDesaturate) == null)
				{
					result = (this._SceneColorDesaturate = new FKuroCurveFloat(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_SceneColorDesaturate, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_SceneColorDesaturate, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005DFD RID: 24061
		// (get) Token: 0x060174ED RID: 95469 RVA: 0x002206CA File Offset: 0x0021E8CA
		// (set) Token: 0x060174EE RID: 95470 RVA: 0x002206DA File Offset: 0x0021E8DA
		public unsafe bool TranslucentColorTintOverride
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_TranslucentColorTintOverride) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_TranslucentColorTintOverride) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005DFE RID: 24062
		// (get) Token: 0x060174EF RID: 95471 RVA: 0x002206EC File Offset: 0x0021E8EC
		// (set) Token: 0x060174F0 RID: 95472 RVA: 0x00220725 File Offset: 0x0021E925
		public FKuroCurveLinearColor TranslucentColorTint
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveLinearColor result;
				if ((result = this._TranslucentColorTint) == null)
				{
					result = (this._TranslucentColorTint = new FKuroCurveLinearColor(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_TranslucentColorTint, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveLinearColor.StaticStruct(), base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_TranslucentColorTint, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005DFF RID: 24063
		// (get) Token: 0x060174F1 RID: 95473 RVA: 0x00220746 File Offset: 0x0021E946
		// (set) Token: 0x060174F2 RID: 95474 RVA: 0x00220756 File Offset: 0x0021E956
		public unsafe bool TranslucentColorDesaturateOverride
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_TranslucentColorDesaturateOverride) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_TranslucentColorDesaturateOverride) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005E00 RID: 24064
		// (get) Token: 0x060174F3 RID: 95475 RVA: 0x00220768 File Offset: 0x0021E968
		// (set) Token: 0x060174F4 RID: 95476 RVA: 0x002207A1 File Offset: 0x0021E9A1
		public FKuroCurveFloat TranslucentColorDesaturate
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._TranslucentColorDesaturate) == null)
				{
					result = (this._TranslucentColorDesaturate = new FKuroCurveFloat(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_TranslucentColorDesaturate, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_TranslucentColorDesaturate, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005E01 RID: 24065
		// (get) Token: 0x060174F5 RID: 95477 RVA: 0x002207C2 File Offset: 0x0021E9C2
		// (set) Token: 0x060174F6 RID: 95478 RVA: 0x002207D2 File Offset: 0x0021E9D2
		public unsafe bool FightTranslucentNoDesaturateOverride
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_FightTranslucentNoDesaturateOverride) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_FightTranslucentNoDesaturateOverride) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005E02 RID: 24066
		// (get) Token: 0x060174F7 RID: 95479 RVA: 0x002207E3 File Offset: 0x0021E9E3
		// (set) Token: 0x060174F8 RID: 95480 RVA: 0x002207F3 File Offset: 0x0021E9F3
		public unsafe bool FightTranslucentNoDesaturate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_FightTranslucentNoDesaturate) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_FightTranslucentNoDesaturate) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005E03 RID: 24067
		// (get) Token: 0x060174F9 RID: 95481 RVA: 0x00220804 File Offset: 0x0021EA04
		// (set) Token: 0x060174FA RID: 95482 RVA: 0x00220814 File Offset: 0x0021EA14
		public unsafe bool BlackWhiteFlashIntensityOverride
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_BlackWhiteFlashIntensityOverride) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_BlackWhiteFlashIntensityOverride) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005E04 RID: 24068
		// (get) Token: 0x060174FB RID: 95483 RVA: 0x00220828 File Offset: 0x0021EA28
		// (set) Token: 0x060174FC RID: 95484 RVA: 0x00220861 File Offset: 0x0021EA61
		public FKuroCurveFloat BlackWhiteFlashIntensity
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._BlackWhiteFlashIntensity) == null)
				{
					result = (this._BlackWhiteFlashIntensity = new FKuroCurveFloat(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_BlackWhiteFlashIntensity, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_BlackWhiteFlashIntensity, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005E05 RID: 24069
		// (get) Token: 0x060174FD RID: 95485 RVA: 0x00220882 File Offset: 0x0021EA82
		// (set) Token: 0x060174FE RID: 95486 RVA: 0x00220892 File Offset: 0x0021EA92
		public unsafe bool BlackWhiteFlashFactorOverride
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_BlackWhiteFlashFactorOverride) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_BlackWhiteFlashFactorOverride) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005E06 RID: 24070
		// (get) Token: 0x060174FF RID: 95487 RVA: 0x002208A4 File Offset: 0x0021EAA4
		// (set) Token: 0x06017500 RID: 95488 RVA: 0x002208DD File Offset: 0x0021EADD
		public FKuroCurveFloat BlackWhiteFlashFactor
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._BlackWhiteFlashFactor) == null)
				{
					result = (this._BlackWhiteFlashFactor = new FKuroCurveFloat(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_BlackWhiteFlashFactor, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_BlackWhiteFlashFactor, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005E07 RID: 24071
		// (get) Token: 0x06017501 RID: 95489 RVA: 0x002208FE File Offset: 0x0021EAFE
		// (set) Token: 0x06017502 RID: 95490 RVA: 0x0022090E File Offset: 0x0021EB0E
		public unsafe bool BlackWhiteFlashThresholdOverride
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_BlackWhiteFlashThresholdOverride) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_BlackWhiteFlashThresholdOverride) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005E08 RID: 24072
		// (get) Token: 0x06017503 RID: 95491 RVA: 0x00220920 File Offset: 0x0021EB20
		// (set) Token: 0x06017504 RID: 95492 RVA: 0x00220959 File Offset: 0x0021EB59
		public FKuroCurveFloat BlackWhiteFlashThreshold
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._BlackWhiteFlashThreshold) == null)
				{
					result = (this._BlackWhiteFlashThreshold = new FKuroCurveFloat(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_BlackWhiteFlashThreshold, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_BlackWhiteFlashThreshold, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005E09 RID: 24073
		// (get) Token: 0x06017505 RID: 95493 RVA: 0x0022097A File Offset: 0x0021EB7A
		// (set) Token: 0x06017506 RID: 95494 RVA: 0x0022098A File Offset: 0x0021EB8A
		public unsafe bool BlackWhiteFlashBlackAreaColorOverride
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_BlackWhiteFlashBlackAreaColorOverride) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_BlackWhiteFlashBlackAreaColorOverride) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005E0A RID: 24074
		// (get) Token: 0x06017507 RID: 95495 RVA: 0x0022099C File Offset: 0x0021EB9C
		// (set) Token: 0x06017508 RID: 95496 RVA: 0x002209D5 File Offset: 0x0021EBD5
		public FKuroCurveLinearColor BlackWhiteFlashBlackAreaColor
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveLinearColor result;
				if ((result = this._BlackWhiteFlashBlackAreaColor) == null)
				{
					result = (this._BlackWhiteFlashBlackAreaColor = new FKuroCurveLinearColor(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_BlackWhiteFlashBlackAreaColor, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveLinearColor.StaticStruct(), base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_BlackWhiteFlashBlackAreaColor, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005E0B RID: 24075
		// (get) Token: 0x06017509 RID: 95497 RVA: 0x002209F6 File Offset: 0x0021EBF6
		// (set) Token: 0x0601750A RID: 95498 RVA: 0x00220A06 File Offset: 0x0021EC06
		public unsafe bool BlackWhiteFlashWhiteAreaColorOverride
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_BlackWhiteFlashWhiteAreaColorOverride) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_BlackWhiteFlashWhiteAreaColorOverride) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005E0C RID: 24076
		// (get) Token: 0x0601750B RID: 95499 RVA: 0x00220A18 File Offset: 0x0021EC18
		// (set) Token: 0x0601750C RID: 95500 RVA: 0x00220A51 File Offset: 0x0021EC51
		public FKuroCurveLinearColor BlackWhiteFlashWhiteAreaColor
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveLinearColor result;
				if ((result = this._BlackWhiteFlashWhiteAreaColor) == null)
				{
					result = (this._BlackWhiteFlashWhiteAreaColor = new FKuroCurveLinearColor(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_BlackWhiteFlashWhiteAreaColor, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveLinearColor.StaticStruct(), base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_BlackWhiteFlashWhiteAreaColor, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005E0D RID: 24077
		// (get) Token: 0x0601750D RID: 95501 RVA: 0x00220A72 File Offset: 0x0021EC72
		// (set) Token: 0x0601750E RID: 95502 RVA: 0x00220A82 File Offset: 0x0021EC82
		public unsafe bool GrayGradationOverride
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_GrayGradationOverride) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_GrayGradationOverride) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005E0E RID: 24078
		// (get) Token: 0x0601750F RID: 95503 RVA: 0x00220A93 File Offset: 0x0021EC93
		// (set) Token: 0x06017510 RID: 95504 RVA: 0x00220AA3 File Offset: 0x0021ECA3
		public unsafe bool GrayGradationCullTranslucency
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_GrayGradationCullTranslucency) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_GrayGradationCullTranslucency) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005E0F RID: 24079
		// (get) Token: 0x06017511 RID: 95505 RVA: 0x00220AB4 File Offset: 0x0021ECB4
		// (set) Token: 0x06017512 RID: 95506 RVA: 0x00220AC4 File Offset: 0x0021ECC4
		public unsafe bool GrayGradationUsePlayerLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_GrayGradationUsePlayerLocation) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_GrayGradationUsePlayerLocation) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005E10 RID: 24080
		// (get) Token: 0x06017513 RID: 95507 RVA: 0x00220AD8 File Offset: 0x0021ECD8
		// (set) Token: 0x06017514 RID: 95508 RVA: 0x00220B11 File Offset: 0x0021ED11
		public FKuroCurveFloat GrayGradationDegree
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._GrayGradationDegree) == null)
				{
					result = (this._GrayGradationDegree = new FKuroCurveFloat(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_GrayGradationDegree, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_GrayGradationDegree, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005E11 RID: 24081
		// (get) Token: 0x06017515 RID: 95509 RVA: 0x00220B34 File Offset: 0x0021ED34
		// (set) Token: 0x06017516 RID: 95510 RVA: 0x00220B6D File Offset: 0x0021ED6D
		public FKuroCurveFloat GrayGradationLerpWidth
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._GrayGradationLerpWidth) == null)
				{
					result = (this._GrayGradationLerpWidth = new FKuroCurveFloat(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_GrayGradationLerpWidth, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_GrayGradationLerpWidth, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005E12 RID: 24082
		// (get) Token: 0x06017517 RID: 95511 RVA: 0x00220B8E File Offset: 0x0021ED8E
		// (set) Token: 0x06017518 RID: 95512 RVA: 0x00220BA2 File Offset: 0x0021EDA2
		[Nullable(2)]
		public unsafe UTexture2D GrayGradationRampTexture
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + UEffectModelPostProcess.__PropertyOffset_GrayGradationRampTexture);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UEffectModelPostProcess.__PropertyOffset_GrayGradationRampTexture, value);
			}
		}

		// Token: 0x17005E13 RID: 24083
		// (get) Token: 0x06017519 RID: 95513 RVA: 0x00220BB8 File Offset: 0x0021EDB8
		// (set) Token: 0x0601751A RID: 95514 RVA: 0x00220BF1 File Offset: 0x0021EDF1
		public FKuroCurveLinearColor GrayGradationColorTint
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveLinearColor result;
				if ((result = this._GrayGradationColorTint) == null)
				{
					result = (this._GrayGradationColorTint = new FKuroCurveLinearColor(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_GrayGradationColorTint, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveLinearColor.StaticStruct(), base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_GrayGradationColorTint, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005E14 RID: 24084
		// (get) Token: 0x0601751B RID: 95515 RVA: 0x00220C14 File Offset: 0x0021EE14
		// (set) Token: 0x0601751C RID: 95516 RVA: 0x00220C4D File Offset: 0x0021EE4D
		public FKuroCurveFloat GrayGradationBlendWeight
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._GrayGradationBlendWeight) == null)
				{
					result = (this._GrayGradationBlendWeight = new FKuroCurveFloat(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_GrayGradationBlendWeight, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_GrayGradationBlendWeight, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005E15 RID: 24085
		// (get) Token: 0x0601751D RID: 95517 RVA: 0x00220C6E File Offset: 0x0021EE6E
		// (set) Token: 0x0601751E RID: 95518 RVA: 0x00220C7E File Offset: 0x0021EE7E
		public unsafe bool RetroFuturisticOverride
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_RetroFuturisticOverride) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_RetroFuturisticOverride) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005E16 RID: 24086
		// (get) Token: 0x0601751F RID: 95519 RVA: 0x00220C90 File Offset: 0x0021EE90
		// (set) Token: 0x06017520 RID: 95520 RVA: 0x00220CC9 File Offset: 0x0021EEC9
		public FKuroCurveFloat MainCenterMask
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._MainCenterMask) == null)
				{
					result = (this._MainCenterMask = new FKuroCurveFloat(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_MainCenterMask, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_MainCenterMask, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005E17 RID: 24087
		// (get) Token: 0x06017521 RID: 95521 RVA: 0x00220CEC File Offset: 0x0021EEEC
		// (set) Token: 0x06017522 RID: 95522 RVA: 0x00220D25 File Offset: 0x0021EF25
		public FKuroCurveFloat MainCenterMaskRadius
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._MainCenterMaskRadius) == null)
				{
					result = (this._MainCenterMaskRadius = new FKuroCurveFloat(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_MainCenterMaskRadius, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_MainCenterMaskRadius, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005E18 RID: 24088
		// (get) Token: 0x06017523 RID: 95523 RVA: 0x00220D48 File Offset: 0x0021EF48
		// (set) Token: 0x06017524 RID: 95524 RVA: 0x00220D81 File Offset: 0x0021EF81
		public FKuroCurveFloat MainCenterMaskHardness
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._MainCenterMaskHardness) == null)
				{
					result = (this._MainCenterMaskHardness = new FKuroCurveFloat(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_MainCenterMaskHardness, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_MainCenterMaskHardness, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005E19 RID: 24089
		// (get) Token: 0x06017525 RID: 95525 RVA: 0x00220DA4 File Offset: 0x0021EFA4
		// (set) Token: 0x06017526 RID: 95526 RVA: 0x00220DDD File Offset: 0x0021EFDD
		public FKuroCurveFloat MainStartDistance
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._MainStartDistance) == null)
				{
					result = (this._MainStartDistance = new FKuroCurveFloat(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_MainStartDistance, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_MainStartDistance, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005E1A RID: 24090
		// (get) Token: 0x06017527 RID: 95527 RVA: 0x00220E00 File Offset: 0x0021F000
		// (set) Token: 0x06017528 RID: 95528 RVA: 0x00220E39 File Offset: 0x0021F039
		public FKuroCurveFloat MainCharacterIntensity
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._MainCharacterIntensity) == null)
				{
					result = (this._MainCharacterIntensity = new FKuroCurveFloat(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_MainCharacterIntensity, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_MainCharacterIntensity, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005E1B RID: 24091
		// (get) Token: 0x06017529 RID: 95529 RVA: 0x00220E5C File Offset: 0x0021F05C
		// (set) Token: 0x0601752A RID: 95530 RVA: 0x00220E95 File Offset: 0x0021F095
		public FKuroCurveFloat VintageColorIntensity
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._VintageColorIntensity) == null)
				{
					result = (this._VintageColorIntensity = new FKuroCurveFloat(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_VintageColorIntensity, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_VintageColorIntensity, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005E1C RID: 24092
		// (get) Token: 0x0601752B RID: 95531 RVA: 0x00220EB8 File Offset: 0x0021F0B8
		// (set) Token: 0x0601752C RID: 95532 RVA: 0x00220EF1 File Offset: 0x0021F0F1
		public FKuroCurveFloat VintageColorBlackPoint
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._VintageColorBlackPoint) == null)
				{
					result = (this._VintageColorBlackPoint = new FKuroCurveFloat(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_VintageColorBlackPoint, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_VintageColorBlackPoint, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005E1D RID: 24093
		// (get) Token: 0x0601752D RID: 95533 RVA: 0x00220F14 File Offset: 0x0021F114
		// (set) Token: 0x0601752E RID: 95534 RVA: 0x00220F4D File Offset: 0x0021F14D
		public FKuroCurveFloat VintageColorWhitePoint
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._VintageColorWhitePoint) == null)
				{
					result = (this._VintageColorWhitePoint = new FKuroCurveFloat(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_VintageColorWhitePoint, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_VintageColorWhitePoint, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005E1E RID: 24094
		// (get) Token: 0x0601752F RID: 95535 RVA: 0x00220F70 File Offset: 0x0021F170
		// (set) Token: 0x06017530 RID: 95536 RVA: 0x00220FA9 File Offset: 0x0021F1A9
		public FKuroCurveFloat VHSLinesColorIntensity
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._VHSLinesColorIntensity) == null)
				{
					result = (this._VHSLinesColorIntensity = new FKuroCurveFloat(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_VHSLinesColorIntensity, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_VHSLinesColorIntensity, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005E1F RID: 24095
		// (get) Token: 0x06017531 RID: 95537 RVA: 0x00220FCC File Offset: 0x0021F1CC
		// (set) Token: 0x06017532 RID: 95538 RVA: 0x00221005 File Offset: 0x0021F205
		public FKuroCurveFloat VHSLinesDistortIntensity
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._VHSLinesDistortIntensity) == null)
				{
					result = (this._VHSLinesDistortIntensity = new FKuroCurveFloat(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_VHSLinesDistortIntensity, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_VHSLinesDistortIntensity, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005E20 RID: 24096
		// (get) Token: 0x06017533 RID: 95539 RVA: 0x00221028 File Offset: 0x0021F228
		// (set) Token: 0x06017534 RID: 95540 RVA: 0x00221061 File Offset: 0x0021F261
		public FKuroCurveFloat VHSEffectIntensity
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._VHSEffectIntensity) == null)
				{
					result = (this._VHSEffectIntensity = new FKuroCurveFloat(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_VHSEffectIntensity, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_VHSEffectIntensity, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005E21 RID: 24097
		// (get) Token: 0x06017535 RID: 95541 RVA: 0x00221084 File Offset: 0x0021F284
		// (set) Token: 0x06017536 RID: 95542 RVA: 0x002210BD File Offset: 0x0021F2BD
		public FKuroCurveFloat VHSSpecklesIntensity
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._VHSSpecklesIntensity) == null)
				{
					result = (this._VHSSpecklesIntensity = new FKuroCurveFloat(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_VHSSpecklesIntensity, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_VHSSpecklesIntensity, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005E22 RID: 24098
		// (get) Token: 0x06017537 RID: 95543 RVA: 0x002210E0 File Offset: 0x0021F2E0
		// (set) Token: 0x06017538 RID: 95544 RVA: 0x00221119 File Offset: 0x0021F319
		public FKuroCurveFloat VHSSpecklesAmount
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._VHSSpecklesAmount) == null)
				{
					result = (this._VHSSpecklesAmount = new FKuroCurveFloat(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_VHSSpecklesAmount, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_VHSSpecklesAmount, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005E23 RID: 24099
		// (get) Token: 0x06017539 RID: 95545 RVA: 0x0022113C File Offset: 0x0021F33C
		// (set) Token: 0x0601753A RID: 95546 RVA: 0x00221175 File Offset: 0x0021F375
		public FKuroCurveFloat VHSSpecklesSize
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._VHSSpecklesSize) == null)
				{
					result = (this._VHSSpecklesSize = new FKuroCurveFloat(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_VHSSpecklesSize, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_VHSSpecklesSize, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005E24 RID: 24100
		// (get) Token: 0x0601753B RID: 95547 RVA: 0x00221198 File Offset: 0x0021F398
		// (set) Token: 0x0601753C RID: 95548 RVA: 0x002211D1 File Offset: 0x0021F3D1
		public FKuroCurveFloat CRTDistortion
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._CRTDistortion) == null)
				{
					result = (this._CRTDistortion = new FKuroCurveFloat(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_CRTDistortion, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_CRTDistortion, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005E25 RID: 24101
		// (get) Token: 0x0601753D RID: 95549 RVA: 0x002211F2 File Offset: 0x0021F3F2
		// (set) Token: 0x0601753E RID: 95550 RVA: 0x00221202 File Offset: 0x0021F402
		public unsafe bool RetroFuturisticAdvancedOverride
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_RetroFuturisticAdvancedOverride) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_RetroFuturisticAdvancedOverride) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005E26 RID: 24102
		// (get) Token: 0x0601753F RID: 95551 RVA: 0x00221214 File Offset: 0x0021F414
		// (set) Token: 0x06017540 RID: 95552 RVA: 0x0022124D File Offset: 0x0021F44D
		public FKuroCurveFloat VintageColorCenterMask
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._VintageColorCenterMask) == null)
				{
					result = (this._VintageColorCenterMask = new FKuroCurveFloat(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_VintageColorCenterMask, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_VintageColorCenterMask, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005E27 RID: 24103
		// (get) Token: 0x06017541 RID: 95553 RVA: 0x00221270 File Offset: 0x0021F470
		// (set) Token: 0x06017542 RID: 95554 RVA: 0x002212A9 File Offset: 0x0021F4A9
		public FKuroCurveFloat VintageColorStartDistance
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._VintageColorStartDistance) == null)
				{
					result = (this._VintageColorStartDistance = new FKuroCurveFloat(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_VintageColorStartDistance, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_VintageColorStartDistance, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005E28 RID: 24104
		// (get) Token: 0x06017543 RID: 95555 RVA: 0x002212CC File Offset: 0x0021F4CC
		// (set) Token: 0x06017544 RID: 95556 RVA: 0x00221305 File Offset: 0x0021F505
		public FKuroCurveFloat VintageColorCharacterIntensity
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._VintageColorCharacterIntensity) == null)
				{
					result = (this._VintageColorCharacterIntensity = new FKuroCurveFloat(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_VintageColorCharacterIntensity, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_VintageColorCharacterIntensity, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005E29 RID: 24105
		// (get) Token: 0x06017545 RID: 95557 RVA: 0x00221328 File Offset: 0x0021F528
		// (set) Token: 0x06017546 RID: 95558 RVA: 0x00221361 File Offset: 0x0021F561
		public FKuroCurveFloat VHSLinesCenterMask
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._VHSLinesCenterMask) == null)
				{
					result = (this._VHSLinesCenterMask = new FKuroCurveFloat(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_VHSLinesCenterMask, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_VHSLinesCenterMask, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005E2A RID: 24106
		// (get) Token: 0x06017547 RID: 95559 RVA: 0x00221384 File Offset: 0x0021F584
		// (set) Token: 0x06017548 RID: 95560 RVA: 0x002213BD File Offset: 0x0021F5BD
		public FKuroCurveFloat VHSLinesStartDistance
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._VHSLinesStartDistance) == null)
				{
					result = (this._VHSLinesStartDistance = new FKuroCurveFloat(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_VHSLinesStartDistance, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_VHSLinesStartDistance, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005E2B RID: 24107
		// (get) Token: 0x06017549 RID: 95561 RVA: 0x002213E0 File Offset: 0x0021F5E0
		// (set) Token: 0x0601754A RID: 95562 RVA: 0x00221419 File Offset: 0x0021F619
		public FKuroCurveFloat VHSLinesCharacterIntensity
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._VHSLinesCharacterIntensity) == null)
				{
					result = (this._VHSLinesCharacterIntensity = new FKuroCurveFloat(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_VHSLinesCharacterIntensity, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_VHSLinesCharacterIntensity, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005E2C RID: 24108
		// (get) Token: 0x0601754B RID: 95563 RVA: 0x0022143C File Offset: 0x0021F63C
		// (set) Token: 0x0601754C RID: 95564 RVA: 0x00221475 File Offset: 0x0021F675
		public FKuroCurveFloat VHSEffectCenterMask
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._VHSEffectCenterMask) == null)
				{
					result = (this._VHSEffectCenterMask = new FKuroCurveFloat(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_VHSEffectCenterMask, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_VHSEffectCenterMask, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005E2D RID: 24109
		// (get) Token: 0x0601754D RID: 95565 RVA: 0x00221498 File Offset: 0x0021F698
		// (set) Token: 0x0601754E RID: 95566 RVA: 0x002214D1 File Offset: 0x0021F6D1
		public FKuroCurveFloat VHSEffectStartDistance
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._VHSEffectStartDistance) == null)
				{
					result = (this._VHSEffectStartDistance = new FKuroCurveFloat(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_VHSEffectStartDistance, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_VHSEffectStartDistance, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005E2E RID: 24110
		// (get) Token: 0x0601754F RID: 95567 RVA: 0x002214F4 File Offset: 0x0021F6F4
		// (set) Token: 0x06017550 RID: 95568 RVA: 0x0022152D File Offset: 0x0021F72D
		public FKuroCurveFloat VHSEffectCharacterIntensity
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._VHSEffectCharacterIntensity) == null)
				{
					result = (this._VHSEffectCharacterIntensity = new FKuroCurveFloat(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_VHSEffectCharacterIntensity, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_VHSEffectCharacterIntensity, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005E2F RID: 24111
		// (get) Token: 0x06017551 RID: 95569 RVA: 0x00221550 File Offset: 0x0021F750
		// (set) Token: 0x06017552 RID: 95570 RVA: 0x00221589 File Offset: 0x0021F789
		public FKuroCurveFloat VHSSpecklesCenterMask
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._VHSSpecklesCenterMask) == null)
				{
					result = (this._VHSSpecklesCenterMask = new FKuroCurveFloat(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_VHSSpecklesCenterMask, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_VHSSpecklesCenterMask, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005E30 RID: 24112
		// (get) Token: 0x06017553 RID: 95571 RVA: 0x002215AC File Offset: 0x0021F7AC
		// (set) Token: 0x06017554 RID: 95572 RVA: 0x002215E5 File Offset: 0x0021F7E5
		public FKuroCurveFloat VHSSpecklesStartDistance
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._VHSSpecklesStartDistance) == null)
				{
					result = (this._VHSSpecklesStartDistance = new FKuroCurveFloat(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_VHSSpecklesStartDistance, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_VHSSpecklesStartDistance, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005E31 RID: 24113
		// (get) Token: 0x06017555 RID: 95573 RVA: 0x00221608 File Offset: 0x0021F808
		// (set) Token: 0x06017556 RID: 95574 RVA: 0x00221641 File Offset: 0x0021F841
		public FKuroCurveFloat VHSSpecklesCharacterIntensity
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._VHSSpecklesCharacterIntensity) == null)
				{
					result = (this._VHSSpecklesCharacterIntensity = new FKuroCurveFloat(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_VHSSpecklesCharacterIntensity, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_VHSSpecklesCharacterIntensity, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005E32 RID: 24114
		// (get) Token: 0x06017557 RID: 95575 RVA: 0x00221662 File Offset: 0x0021F862
		// (set) Token: 0x06017558 RID: 95576 RVA: 0x00221672 File Offset: 0x0021F872
		public unsafe bool ScreenWaveOverride
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_ScreenWaveOverride) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_ScreenWaveOverride) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005E33 RID: 24115
		// (get) Token: 0x06017559 RID: 95577 RVA: 0x00221683 File Offset: 0x0021F883
		// (set) Token: 0x0601755A RID: 95578 RVA: 0x00221693 File Offset: 0x0021F893
		public unsafe bool UsePolarWavePattern
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_UsePolarWavePattern) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_UsePolarWavePattern) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005E34 RID: 24116
		// (get) Token: 0x0601755B RID: 95579 RVA: 0x002216A4 File Offset: 0x0021F8A4
		// (set) Token: 0x0601755C RID: 95580 RVA: 0x002216B8 File Offset: 0x0021F8B8
		[Nullable(2)]
		public unsafe UTexture2D WavePatternTexture
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + UEffectModelPostProcess.__PropertyOffset_WavePatternTexture);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UEffectModelPostProcess.__PropertyOffset_WavePatternTexture, value);
			}
		}

		// Token: 0x17005E35 RID: 24117
		// (get) Token: 0x0601755D RID: 95581 RVA: 0x002216D0 File Offset: 0x0021F8D0
		// (set) Token: 0x0601755E RID: 95582 RVA: 0x00221709 File Offset: 0x0021F909
		public FKuroCurveLinearColor WavePatternScaleBias
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveLinearColor result;
				if ((result = this._WavePatternScaleBias) == null)
				{
					result = (this._WavePatternScaleBias = new FKuroCurveLinearColor(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_WavePatternScaleBias, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveLinearColor.StaticStruct(), base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_WavePatternScaleBias, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005E36 RID: 24118
		// (get) Token: 0x0601755F RID: 95583 RVA: 0x0022172C File Offset: 0x0021F92C
		// (set) Token: 0x06017560 RID: 95584 RVA: 0x00221765 File Offset: 0x0021F965
		public FKuroCurveFloat WaveRadius
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._WaveRadius) == null)
				{
					result = (this._WaveRadius = new FKuroCurveFloat(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_WaveRadius, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_WaveRadius, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005E37 RID: 24119
		// (get) Token: 0x06017561 RID: 95585 RVA: 0x00221788 File Offset: 0x0021F988
		// (set) Token: 0x06017562 RID: 95586 RVA: 0x002217C1 File Offset: 0x0021F9C1
		public FKuroCurveFloat WaveRadiusSmooth
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._WaveRadiusSmooth) == null)
				{
					result = (this._WaveRadiusSmooth = new FKuroCurveFloat(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_WaveRadiusSmooth, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_WaveRadiusSmooth, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005E38 RID: 24120
		// (get) Token: 0x06017563 RID: 95587 RVA: 0x002217E4 File Offset: 0x0021F9E4
		// (set) Token: 0x06017564 RID: 95588 RVA: 0x0022181D File Offset: 0x0021FA1D
		public FKuroCurveFloat WaveHeight
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._WaveHeight) == null)
				{
					result = (this._WaveHeight = new FKuroCurveFloat(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_WaveHeight, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_WaveHeight, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005E39 RID: 24121
		// (get) Token: 0x06017565 RID: 95589 RVA: 0x00221840 File Offset: 0x0021FA40
		// (set) Token: 0x06017566 RID: 95590 RVA: 0x00221879 File Offset: 0x0021FA79
		public FKuroCurveFloat WaveHeightSmooth
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._WaveHeightSmooth) == null)
				{
					result = (this._WaveHeightSmooth = new FKuroCurveFloat(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_WaveHeightSmooth, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_WaveHeightSmooth, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005E3A RID: 24122
		// (get) Token: 0x06017567 RID: 95591 RVA: 0x0022189C File Offset: 0x0021FA9C
		// (set) Token: 0x06017568 RID: 95592 RVA: 0x002218D5 File Offset: 0x0021FAD5
		public FKuroCurveFloat WaveNormalSize
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._WaveNormalSize) == null)
				{
					result = (this._WaveNormalSize = new FKuroCurveFloat(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_WaveNormalSize, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_WaveNormalSize, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005E3B RID: 24123
		// (get) Token: 0x06017569 RID: 95593 RVA: 0x002218F8 File Offset: 0x0021FAF8
		// (set) Token: 0x0601756A RID: 95594 RVA: 0x00221931 File Offset: 0x0021FB31
		public FKuroCurveFloat WaveRoughness
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._WaveRoughness) == null)
				{
					result = (this._WaveRoughness = new FKuroCurveFloat(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_WaveRoughness, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_WaveRoughness, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005E3C RID: 24124
		// (get) Token: 0x0601756B RID: 95595 RVA: 0x00221952 File Offset: 0x0021FB52
		// (set) Token: 0x0601756C RID: 95596 RVA: 0x00221966 File Offset: 0x0021FB66
		[Nullable(2)]
		public unsafe UTexture2D WaveDissolveTexture
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + UEffectModelPostProcess.__PropertyOffset_WaveDissolveTexture);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UEffectModelPostProcess.__PropertyOffset_WaveDissolveTexture, value);
			}
		}

		// Token: 0x17005E3D RID: 24125
		// (get) Token: 0x0601756D RID: 95597 RVA: 0x0022197C File Offset: 0x0021FB7C
		// (set) Token: 0x0601756E RID: 95598 RVA: 0x002219B5 File Offset: 0x0021FBB5
		public FKuroCurveLinearColor WaveDissolveScaleBias
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveLinearColor result;
				if ((result = this._WaveDissolveScaleBias) == null)
				{
					result = (this._WaveDissolveScaleBias = new FKuroCurveLinearColor(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_WaveDissolveScaleBias, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveLinearColor.StaticStruct(), base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_WaveDissolveScaleBias, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005E3E RID: 24126
		// (get) Token: 0x0601756F RID: 95599 RVA: 0x002219D8 File Offset: 0x0021FBD8
		// (set) Token: 0x06017570 RID: 95600 RVA: 0x00221A11 File Offset: 0x0021FC11
		public FKuroCurveFloat WaveDissolveProgress
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._WaveDissolveProgress) == null)
				{
					result = (this._WaveDissolveProgress = new FKuroCurveFloat(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_WaveDissolveProgress, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_WaveDissolveProgress, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005E3F RID: 24127
		// (get) Token: 0x06017571 RID: 95601 RVA: 0x00221A34 File Offset: 0x0021FC34
		// (set) Token: 0x06017572 RID: 95602 RVA: 0x00221A6D File Offset: 0x0021FC6D
		public FKuroCurveFloat WaveDissolveSmooth
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._WaveDissolveSmooth) == null)
				{
					result = (this._WaveDissolveSmooth = new FKuroCurveFloat(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_WaveDissolveSmooth, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_WaveDissolveSmooth, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005E40 RID: 24128
		// (get) Token: 0x06017573 RID: 95603 RVA: 0x00221A8E File Offset: 0x0021FC8E
		// (set) Token: 0x06017574 RID: 95604 RVA: 0x00221AA2 File Offset: 0x0021FCA2
		[Nullable(2)]
		public unsafe UTexture2D WaveColorTexture
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + UEffectModelPostProcess.__PropertyOffset_WaveColorTexture);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UEffectModelPostProcess.__PropertyOffset_WaveColorTexture, value);
			}
		}

		// Token: 0x17005E41 RID: 24129
		// (get) Token: 0x06017575 RID: 95605 RVA: 0x00221AB8 File Offset: 0x0021FCB8
		// (set) Token: 0x06017576 RID: 95606 RVA: 0x00221AF1 File Offset: 0x0021FCF1
		public FKuroCurveLinearColor WaveColorScaleBias
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveLinearColor result;
				if ((result = this._WaveColorScaleBias) == null)
				{
					result = (this._WaveColorScaleBias = new FKuroCurveLinearColor(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_WaveColorScaleBias, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveLinearColor.StaticStruct(), base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_WaveColorScaleBias, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005E42 RID: 24130
		// (get) Token: 0x06017577 RID: 95607 RVA: 0x00221B14 File Offset: 0x0021FD14
		// (set) Token: 0x06017578 RID: 95608 RVA: 0x00221B4D File Offset: 0x0021FD4D
		public FKuroCurveLinearColor WaveColorTextureTint
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveLinearColor result;
				if ((result = this._WaveColorTextureTint) == null)
				{
					result = (this._WaveColorTextureTint = new FKuroCurveLinearColor(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_WaveColorTextureTint, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveLinearColor.StaticStruct(), base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_WaveColorTextureTint, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005E43 RID: 24131
		// (get) Token: 0x06017579 RID: 95609 RVA: 0x00221B70 File Offset: 0x0021FD70
		// (set) Token: 0x0601757A RID: 95610 RVA: 0x00221BA9 File Offset: 0x0021FDA9
		public FKuroCurveFloat WaveAmplitude
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._WaveAmplitude) == null)
				{
					result = (this._WaveAmplitude = new FKuroCurveFloat(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_WaveAmplitude, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_WaveAmplitude, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005E44 RID: 24132
		// (get) Token: 0x0601757B RID: 95611 RVA: 0x00221BCA File Offset: 0x0021FDCA
		// (set) Token: 0x0601757C RID: 95612 RVA: 0x00221BDA File Offset: 0x0021FDDA
		public unsafe bool AutoExposureOverride
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_AutoExposureOverride) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_AutoExposureOverride) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005E45 RID: 24133
		// (get) Token: 0x0601757D RID: 95613 RVA: 0x00221BEC File Offset: 0x0021FDEC
		// (set) Token: 0x0601757E RID: 95614 RVA: 0x00221C25 File Offset: 0x0021FE25
		public FKuroCurveFloat AutoExposureMinBrightness
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._AutoExposureMinBrightness) == null)
				{
					result = (this._AutoExposureMinBrightness = new FKuroCurveFloat(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_AutoExposureMinBrightness, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_AutoExposureMinBrightness, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005E46 RID: 24134
		// (get) Token: 0x0601757F RID: 95615 RVA: 0x00221C48 File Offset: 0x0021FE48
		// (set) Token: 0x06017580 RID: 95616 RVA: 0x00221C81 File Offset: 0x0021FE81
		public FKuroCurveFloat AutoExposureMaxBrightness
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._AutoExposureMaxBrightness) == null)
				{
					result = (this._AutoExposureMaxBrightness = new FKuroCurveFloat(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_AutoExposureMaxBrightness, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_AutoExposureMaxBrightness, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005E47 RID: 24135
		// (get) Token: 0x06017581 RID: 95617 RVA: 0x00221CA2 File Offset: 0x0021FEA2
		// (set) Token: 0x06017582 RID: 95618 RVA: 0x00221CB6 File Offset: 0x0021FEB6
		[Nullable(2)]
		public unsafe UKuroWeatherDataAsset WeatherDataAsset
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroWeatherDataAsset>(base.NativePtr / (IntPtr)sizeof(void*) + UEffectModelPostProcess.__PropertyOffset_WeatherDataAsset);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UEffectModelPostProcess.__PropertyOffset_WeatherDataAsset, value);
			}
		}

		// Token: 0x17005E48 RID: 24136
		// (get) Token: 0x06017583 RID: 95619 RVA: 0x00221CCB File Offset: 0x0021FECB
		// (set) Token: 0x06017584 RID: 95620 RVA: 0x00221CDB File Offset: 0x0021FEDB
		public unsafe bool BurstDissolveOverride
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_BurstDissolveOverride) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_BurstDissolveOverride) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005E49 RID: 24137
		// (get) Token: 0x06017585 RID: 95621 RVA: 0x00221CEC File Offset: 0x0021FEEC
		// (set) Token: 0x06017586 RID: 95622 RVA: 0x00221D00 File Offset: 0x0021FF00
		[Nullable(2)]
		public unsafe UTexture2D BurstDissolveTexture
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + UEffectModelPostProcess.__PropertyOffset_BurstDissolveTexture);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UEffectModelPostProcess.__PropertyOffset_BurstDissolveTexture, value);
			}
		}

		// Token: 0x17005E4A RID: 24138
		// (get) Token: 0x06017587 RID: 95623 RVA: 0x00221D18 File Offset: 0x0021FF18
		// (set) Token: 0x06017588 RID: 95624 RVA: 0x00221D51 File Offset: 0x0021FF51
		public FKuroCurveFloat BurstDissolveThreshold
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._BurstDissolveThreshold) == null)
				{
					result = (this._BurstDissolveThreshold = new FKuroCurveFloat(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_BurstDissolveThreshold, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_BurstDissolveThreshold, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005E4B RID: 24139
		// (get) Token: 0x06017589 RID: 95625 RVA: 0x00221D74 File Offset: 0x0021FF74
		// (set) Token: 0x0601758A RID: 95626 RVA: 0x00221DAD File Offset: 0x0021FFAD
		public FKuroCurveFloat BurstDissolveSmooth
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._BurstDissolveSmooth) == null)
				{
					result = (this._BurstDissolveSmooth = new FKuroCurveFloat(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_BurstDissolveSmooth, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_BurstDissolveSmooth, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005E4C RID: 24140
		// (get) Token: 0x0601758B RID: 95627 RVA: 0x00221DD0 File Offset: 0x0021FFD0
		// (set) Token: 0x0601758C RID: 95628 RVA: 0x00221E09 File Offset: 0x00220009
		public FKuroCurveFloat BurstClipThreshold
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._BurstClipThreshold) == null)
				{
					result = (this._BurstClipThreshold = new FKuroCurveFloat(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_BurstClipThreshold, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_BurstClipThreshold, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005E4D RID: 24141
		// (get) Token: 0x0601758D RID: 95629 RVA: 0x00221E2A File Offset: 0x0022002A
		// (set) Token: 0x0601758E RID: 95630 RVA: 0x00221E3A File Offset: 0x0022003A
		public unsafe bool SkyBoxOverride
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_SkyBoxOverride) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_SkyBoxOverride) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005E4E RID: 24142
		// (get) Token: 0x0601758F RID: 95631 RVA: 0x00221E4C File Offset: 0x0022004C
		// (set) Token: 0x06017590 RID: 95632 RVA: 0x00221E85 File Offset: 0x00220085
		public FKuroEffectPostProcessSkyBoxSetting SkyBoxSetting
		{
			get
			{
				base.FastCheckIsValid();
				FKuroEffectPostProcessSkyBoxSetting result;
				if ((result = this._SkyBoxSetting) == null)
				{
					result = (this._SkyBoxSetting = new FKuroEffectPostProcessSkyBoxSetting(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_SkyBoxSetting, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroEffectPostProcessSkyBoxSetting.StaticStruct(), base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_SkyBoxSetting, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005E4F RID: 24143
		// (get) Token: 0x06017591 RID: 95633 RVA: 0x00221EA6 File Offset: 0x002200A6
		// (set) Token: 0x06017592 RID: 95634 RVA: 0x00221EB6 File Offset: 0x002200B6
		public unsafe bool ColorGradingOverride
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_ColorGradingOverride) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_ColorGradingOverride) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005E50 RID: 24144
		// (get) Token: 0x06017593 RID: 95635 RVA: 0x00221EC8 File Offset: 0x002200C8
		// (set) Token: 0x06017594 RID: 95636 RVA: 0x00221F01 File Offset: 0x00220101
		public FKuroCurveFloat Desaturate
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._Desaturate) == null)
				{
					result = (this._Desaturate = new FKuroCurveFloat(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_Desaturate, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_Desaturate, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005E51 RID: 24145
		// (get) Token: 0x06017595 RID: 95637 RVA: 0x00221F24 File Offset: 0x00220124
		// (set) Token: 0x06017596 RID: 95638 RVA: 0x00221F5D File Offset: 0x0022015D
		public FKuroCurveLinearColor Tint
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveLinearColor result;
				if ((result = this._Tint) == null)
				{
					result = (this._Tint = new FKuroCurveLinearColor(base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_Tint, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveLinearColor.StaticStruct(), base.NativePtr + (IntPtr)UEffectModelPostProcess.__PropertyOffset_Tint, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06017597 RID: 95639 RVA: 0x00221F7E File Offset: 0x0022017E
		static UEffectModelPostProcess()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplay.EffectModelPostProcess");
		}

		// Token: 0x06017598 RID: 95640 RVA: 0x00221F8C File Offset: 0x0022018C
		protected UEffectModelPostProcess(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400CA0B RID: 51723
		public new const string __ObjectPath = "/Script/KuroGameplay.EffectModelPostProcess";

		// Token: 0x0400CA0C RID: 51724
		private static IntPtr _ClassPtr;

		// Token: 0x0400CA0D RID: 51725
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400CA0E RID: 51726
		internal static int __PropertyOffset_Location;

		// Token: 0x0400CA0F RID: 51727
		[Nullable(2)]
		private FKuroCurveVector _Location;

		// Token: 0x0400CA10 RID: 51728
		internal static int __PropertyOffset_EnableVolume;

		// Token: 0x0400CA11 RID: 51729
		internal static int __PropertyOffset_VolumeRadius;

		// Token: 0x0400CA12 RID: 51730
		internal static int __PropertyOffset_VolumeHardness;

		// Token: 0x0400CA13 RID: 51731
		internal static int __PropertyOffset_UseVolumeHardnessCurve;

		// Token: 0x0400CA14 RID: 51732
		internal static int __PropertyOffset_VolumeHardnessCurve;

		// Token: 0x0400CA15 RID: 51733
		[Nullable(2)]
		private FKuroCurveFloat _VolumeHardnessCurve;

		// Token: 0x0400CA16 RID: 51734
		internal static int __PropertyOffset_WeatherPriority;

		// Token: 0x0400CA17 RID: 51735
		internal static int __PropertyOffset_VisibleForProtoPlayer;

		// Token: 0x0400CA18 RID: 51736
		internal static int __PropertyOffset_OverrideTOD;

		// Token: 0x0400CA19 RID: 51737
		internal static int __PropertyOffset_StopWhenActorHidden;

		// Token: 0x0400CA1A RID: 51738
		internal static int __PropertyOffset_bEnablePostprocessMaterial;

		// Token: 0x0400CA1B RID: 51739
		internal static int __PropertyOffset_PostprocessMaterial;

		// Token: 0x0400CA1C RID: 51740
		internal static int __PropertyOffset_PostprocessMaterialQualityArray;

		// Token: 0x0400CA1D RID: 51741
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInterface> _PostprocessMaterialQualityArray;

		// Token: 0x0400CA1E RID: 51742
		internal static int __PropertyOffset_PostprocessMaterialQualityArrayMobile;

		// Token: 0x0400CA1F RID: 51743
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInterface> _PostprocessMaterialQualityArrayMobile;

		// Token: 0x0400CA20 RID: 51744
		internal static int __PropertyOffset_PostprocessMaterialFloatParameters;

		// Token: 0x0400CA21 RID: 51745
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, FKuroCurveFloat> _PostprocessMaterialFloatParameters;

		// Token: 0x0400CA22 RID: 51746
		internal static int __PropertyOffset_PostprocessMaterialColorParameters;

		// Token: 0x0400CA23 RID: 51747
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, FKuroCurveLinearColor> _PostprocessMaterialColorParameters;

		// Token: 0x0400CA24 RID: 51748
		internal static int __PropertyOffset_BlurIntensityOverride;

		// Token: 0x0400CA25 RID: 51749
		internal static int __PropertyOffset_BlurIntensity;

		// Token: 0x0400CA26 RID: 51750
		[Nullable(2)]
		private FKuroCurveFloat _BlurIntensity;

		// Token: 0x0400CA27 RID: 51751
		internal static int __PropertyOffset_UseWorldPosition;

		// Token: 0x0400CA28 RID: 51752
		internal static int __PropertyOffset_ScreenPosition;

		// Token: 0x0400CA29 RID: 51753
		internal static int __PropertyOffset_RadialBlurRadius;

		// Token: 0x0400CA2A RID: 51754
		[Nullable(2)]
		private FKuroCurveFloat _RadialBlurRadius;

		// Token: 0x0400CA2B RID: 51755
		internal static int __PropertyOffset_RadialBlurHardness;

		// Token: 0x0400CA2C RID: 51756
		[Nullable(2)]
		private FKuroCurveFloat _RadialBlurHardness;

		// Token: 0x0400CA2D RID: 51757
		internal static int __PropertyOffset_RadialBlurMask;

		// Token: 0x0400CA2E RID: 51758
		internal static int __PropertyOffset_RadialBlurMaskScale;

		// Token: 0x0400CA2F RID: 51759
		internal static int __PropertyOffset_RadialBlurMaskScaleOffset;

		// Token: 0x0400CA30 RID: 51760
		[Nullable(2)]
		private FKuroCurveLinearColor _RadialBlurMaskScaleOffset;

		// Token: 0x0400CA31 RID: 51761
		internal static int __PropertyOffset_MainLightIntensityOverride;

		// Token: 0x0400CA32 RID: 51762
		internal static int __PropertyOffset_MainLightIntensity;

		// Token: 0x0400CA33 RID: 51763
		[Nullable(2)]
		private FKuroCurveFloat _MainLightIntensity;

		// Token: 0x0400CA34 RID: 51764
		internal static int __PropertyOffset_MainLightColorOverride;

		// Token: 0x0400CA35 RID: 51765
		internal static int __PropertyOffset_MainLightColor;

		// Token: 0x0400CA36 RID: 51766
		[Nullable(2)]
		private FKuroCurveLinearColor _MainLightColor;

		// Token: 0x0400CA37 RID: 51767
		internal static int __PropertyOffset_SkyLightIntensityOverride;

		// Token: 0x0400CA38 RID: 51768
		internal static int __PropertyOffset_SkyLightIntensity;

		// Token: 0x0400CA39 RID: 51769
		[Nullable(2)]
		private FKuroCurveFloat _SkyLightIntensity;

		// Token: 0x0400CA3A RID: 51770
		internal static int __PropertyOffset_SkyLightColorOverride;

		// Token: 0x0400CA3B RID: 51771
		internal static int __PropertyOffset_SkyLightColor;

		// Token: 0x0400CA3C RID: 51772
		[Nullable(2)]
		private FKuroCurveLinearColor _SkyLightColor;

		// Token: 0x0400CA3D RID: 51773
		internal static int __PropertyOffset_EnableEffectFog;

		// Token: 0x0400CA3E RID: 51774
		internal static int __PropertyOffset_EffectFogSwitch;

		// Token: 0x0400CA3F RID: 51775
		[Nullable(2)]
		private FKuroCurveFloat _EffectFogSwitch;

		// Token: 0x0400CA40 RID: 51776
		internal static int __PropertyOffset_KuroEffectFogBlendSceneFogMin;

		// Token: 0x0400CA41 RID: 51777
		[Nullable(2)]
		private FKuroCurveFloat _KuroEffectFogBlendSceneFogMin;

		// Token: 0x0400CA42 RID: 51778
		internal static int __PropertyOffset_FogDensityOverride;

		// Token: 0x0400CA43 RID: 51779
		internal static int __PropertyOffset_FogDensity;

		// Token: 0x0400CA44 RID: 51780
		[Nullable(2)]
		private FKuroCurveFloat _FogDensity;

		// Token: 0x0400CA45 RID: 51781
		internal static int __PropertyOffset_FogStartDistance;

		// Token: 0x0400CA46 RID: 51782
		[Nullable(2)]
		private FKuroCurveFloat _FogStartDistance;

		// Token: 0x0400CA47 RID: 51783
		internal static int __PropertyOffset_FogFalloff;

		// Token: 0x0400CA48 RID: 51784
		internal static int __PropertyOffset_FogMaxOpacity;

		// Token: 0x0400CA49 RID: 51785
		[Nullable(2)]
		private FKuroCurveFloat _FogMaxOpacity;

		// Token: 0x0400CA4A RID: 51786
		internal static int __PropertyOffset_FogColorOverride;

		// Token: 0x0400CA4B RID: 51787
		internal static int __PropertyOffset_FogNearColor;

		// Token: 0x0400CA4C RID: 51788
		[Nullable(2)]
		private FKuroCurveLinearColor _FogNearColor;

		// Token: 0x0400CA4D RID: 51789
		internal static int __PropertyOffset_FogFarColor;

		// Token: 0x0400CA4E RID: 51790
		[Nullable(2)]
		private FKuroCurveLinearColor _FogFarColor;

		// Token: 0x0400CA4F RID: 51791
		internal static int __PropertyOffset_FogNearColorDistance;

		// Token: 0x0400CA50 RID: 51792
		[Nullable(2)]
		private FKuroCurveFloat _FogNearColorDistance;

		// Token: 0x0400CA51 RID: 51793
		internal static int __PropertyOffset_FogFarColorDistance;

		// Token: 0x0400CA52 RID: 51794
		[Nullable(2)]
		private FKuroCurveFloat _FogFarColorDistance;

		// Token: 0x0400CA53 RID: 51795
		internal static int __PropertyOffset_FogColorRatio;

		// Token: 0x0400CA54 RID: 51796
		internal static int __PropertyOffset_FogDistanceViewOverride;

		// Token: 0x0400CA55 RID: 51797
		internal static int __PropertyOffset_FogFalloffFarSky;

		// Token: 0x0400CA56 RID: 51798
		internal static int __PropertyOffset_FogMixDistance;

		// Token: 0x0400CA57 RID: 51799
		internal static int __PropertyOffset_FogMixWidth;

		// Token: 0x0400CA58 RID: 51800
		internal static int __PropertyOffset_KuroBloomIntensityOverride;

		// Token: 0x0400CA59 RID: 51801
		internal static int __PropertyOffset_KuroBloomIntensity;

		// Token: 0x0400CA5A RID: 51802
		[Nullable(2)]
		private FKuroCurveFloat _KuroBloomIntensity;

		// Token: 0x0400CA5B RID: 51803
		internal static int __PropertyOffset_KuroThresholdOverride;

		// Token: 0x0400CA5C RID: 51804
		internal static int __PropertyOffset_KuroThreshold;

		// Token: 0x0400CA5D RID: 51805
		[Nullable(2)]
		private FKuroCurveFloat _KuroThreshold;

		// Token: 0x0400CA5E RID: 51806
		internal static int __PropertyOffset_SceneFringeIntensityOverride;

		// Token: 0x0400CA5F RID: 51807
		internal static int __PropertyOffset_SceneFringeIntensity;

		// Token: 0x0400CA60 RID: 51808
		[Nullable(2)]
		private FKuroCurveFloat _SceneFringeIntensity;

		// Token: 0x0400CA61 RID: 51809
		internal static int __PropertyOffset_StartOffsetOverride;

		// Token: 0x0400CA62 RID: 51810
		internal static int __PropertyOffset_StartOffset;

		// Token: 0x0400CA63 RID: 51811
		[Nullable(2)]
		private FKuroCurveFloat _StartOffset;

		// Token: 0x0400CA64 RID: 51812
		internal static int __PropertyOffset_VignetteIntensityOverride;

		// Token: 0x0400CA65 RID: 51813
		internal static int __PropertyOffset_VignetteIntensity;

		// Token: 0x0400CA66 RID: 51814
		[Nullable(2)]
		private FKuroCurveFloat _VignetteIntensity;

		// Token: 0x0400CA67 RID: 51815
		internal static int __PropertyOffset_VignetteHardness;

		// Token: 0x0400CA68 RID: 51816
		[Nullable(2)]
		private FKuroCurveFloat _VignetteHardness;

		// Token: 0x0400CA69 RID: 51817
		internal static int __PropertyOffset_VignetteXScale;

		// Token: 0x0400CA6A RID: 51818
		[Nullable(2)]
		private FKuroCurveFloat _VignetteXScale;

		// Token: 0x0400CA6B RID: 51819
		internal static int __PropertyOffset_VignetteYScale;

		// Token: 0x0400CA6C RID: 51820
		[Nullable(2)]
		private FKuroCurveFloat _VignetteYScale;

		// Token: 0x0400CA6D RID: 51821
		internal static int __PropertyOffset_VignetteXPos;

		// Token: 0x0400CA6E RID: 51822
		[Nullable(2)]
		private FKuroCurveFloat _VignetteXPos;

		// Token: 0x0400CA6F RID: 51823
		internal static int __PropertyOffset_VignetteYPos;

		// Token: 0x0400CA70 RID: 51824
		[Nullable(2)]
		private FKuroCurveFloat _VignetteYPos;

		// Token: 0x0400CA71 RID: 51825
		internal static int __PropertyOffset_VignetteColor;

		// Token: 0x0400CA72 RID: 51826
		[Nullable(2)]
		private FKuroCurveLinearColor _VignetteColor;

		// Token: 0x0400CA73 RID: 51827
		internal static int __PropertyOffset_VignetteGain;

		// Token: 0x0400CA74 RID: 51828
		[Nullable(2)]
		private FKuroCurveFloat _VignetteGain;

		// Token: 0x0400CA75 RID: 51829
		internal static int __PropertyOffset_GrainJitterOverride;

		// Token: 0x0400CA76 RID: 51830
		internal static int __PropertyOffset_GrainJitter;

		// Token: 0x0400CA77 RID: 51831
		[Nullable(2)]
		private FKuroCurveFloat _GrainJitter;

		// Token: 0x0400CA78 RID: 51832
		internal static int __PropertyOffset_GrainIntensityOverride;

		// Token: 0x0400CA79 RID: 51833
		internal static int __PropertyOffset_GrainIntensity;

		// Token: 0x0400CA7A RID: 51834
		[Nullable(2)]
		private FKuroCurveFloat _GrainIntensity;

		// Token: 0x0400CA7B RID: 51835
		internal static int __PropertyOffset_LutIntensityOverride;

		// Token: 0x0400CA7C RID: 51836
		internal static int __PropertyOffset_LutIntensity;

		// Token: 0x0400CA7D RID: 51837
		[Nullable(2)]
		private FKuroCurveFloat _LutIntensity;

		// Token: 0x0400CA7E RID: 51838
		internal static int __PropertyOffset_LutTextureOverride;

		// Token: 0x0400CA7F RID: 51839
		internal static int __PropertyOffset_LutTexture;

		// Token: 0x0400CA80 RID: 51840
		internal static int __PropertyOffset_SceneColorTintOverride;

		// Token: 0x0400CA81 RID: 51841
		internal static int __PropertyOffset_SceneColorTint;

		// Token: 0x0400CA82 RID: 51842
		[Nullable(2)]
		private FKuroCurveLinearColor _SceneColorTint;

		// Token: 0x0400CA83 RID: 51843
		internal static int __PropertyOffset_SceneColorDesaturateOverride;

		// Token: 0x0400CA84 RID: 51844
		internal static int __PropertyOffset_SceneColorDesaturate;

		// Token: 0x0400CA85 RID: 51845
		[Nullable(2)]
		private FKuroCurveFloat _SceneColorDesaturate;

		// Token: 0x0400CA86 RID: 51846
		internal static int __PropertyOffset_TranslucentColorTintOverride;

		// Token: 0x0400CA87 RID: 51847
		internal static int __PropertyOffset_TranslucentColorTint;

		// Token: 0x0400CA88 RID: 51848
		[Nullable(2)]
		private FKuroCurveLinearColor _TranslucentColorTint;

		// Token: 0x0400CA89 RID: 51849
		internal static int __PropertyOffset_TranslucentColorDesaturateOverride;

		// Token: 0x0400CA8A RID: 51850
		internal static int __PropertyOffset_TranslucentColorDesaturate;

		// Token: 0x0400CA8B RID: 51851
		[Nullable(2)]
		private FKuroCurveFloat _TranslucentColorDesaturate;

		// Token: 0x0400CA8C RID: 51852
		internal static int __PropertyOffset_FightTranslucentNoDesaturateOverride;

		// Token: 0x0400CA8D RID: 51853
		internal static int __PropertyOffset_FightTranslucentNoDesaturate;

		// Token: 0x0400CA8E RID: 51854
		internal static int __PropertyOffset_BlackWhiteFlashIntensityOverride;

		// Token: 0x0400CA8F RID: 51855
		internal static int __PropertyOffset_BlackWhiteFlashIntensity;

		// Token: 0x0400CA90 RID: 51856
		[Nullable(2)]
		private FKuroCurveFloat _BlackWhiteFlashIntensity;

		// Token: 0x0400CA91 RID: 51857
		internal static int __PropertyOffset_BlackWhiteFlashFactorOverride;

		// Token: 0x0400CA92 RID: 51858
		internal static int __PropertyOffset_BlackWhiteFlashFactor;

		// Token: 0x0400CA93 RID: 51859
		[Nullable(2)]
		private FKuroCurveFloat _BlackWhiteFlashFactor;

		// Token: 0x0400CA94 RID: 51860
		internal static int __PropertyOffset_BlackWhiteFlashThresholdOverride;

		// Token: 0x0400CA95 RID: 51861
		internal static int __PropertyOffset_BlackWhiteFlashThreshold;

		// Token: 0x0400CA96 RID: 51862
		[Nullable(2)]
		private FKuroCurveFloat _BlackWhiteFlashThreshold;

		// Token: 0x0400CA97 RID: 51863
		internal static int __PropertyOffset_BlackWhiteFlashBlackAreaColorOverride;

		// Token: 0x0400CA98 RID: 51864
		internal static int __PropertyOffset_BlackWhiteFlashBlackAreaColor;

		// Token: 0x0400CA99 RID: 51865
		[Nullable(2)]
		private FKuroCurveLinearColor _BlackWhiteFlashBlackAreaColor;

		// Token: 0x0400CA9A RID: 51866
		internal static int __PropertyOffset_BlackWhiteFlashWhiteAreaColorOverride;

		// Token: 0x0400CA9B RID: 51867
		internal static int __PropertyOffset_BlackWhiteFlashWhiteAreaColor;

		// Token: 0x0400CA9C RID: 51868
		[Nullable(2)]
		private FKuroCurveLinearColor _BlackWhiteFlashWhiteAreaColor;

		// Token: 0x0400CA9D RID: 51869
		internal static int __PropertyOffset_GrayGradationOverride;

		// Token: 0x0400CA9E RID: 51870
		internal static int __PropertyOffset_GrayGradationCullTranslucency;

		// Token: 0x0400CA9F RID: 51871
		internal static int __PropertyOffset_GrayGradationUsePlayerLocation;

		// Token: 0x0400CAA0 RID: 51872
		internal static int __PropertyOffset_GrayGradationDegree;

		// Token: 0x0400CAA1 RID: 51873
		[Nullable(2)]
		private FKuroCurveFloat _GrayGradationDegree;

		// Token: 0x0400CAA2 RID: 51874
		internal static int __PropertyOffset_GrayGradationLerpWidth;

		// Token: 0x0400CAA3 RID: 51875
		[Nullable(2)]
		private FKuroCurveFloat _GrayGradationLerpWidth;

		// Token: 0x0400CAA4 RID: 51876
		internal static int __PropertyOffset_GrayGradationRampTexture;

		// Token: 0x0400CAA5 RID: 51877
		internal static int __PropertyOffset_GrayGradationColorTint;

		// Token: 0x0400CAA6 RID: 51878
		[Nullable(2)]
		private FKuroCurveLinearColor _GrayGradationColorTint;

		// Token: 0x0400CAA7 RID: 51879
		internal static int __PropertyOffset_GrayGradationBlendWeight;

		// Token: 0x0400CAA8 RID: 51880
		[Nullable(2)]
		private FKuroCurveFloat _GrayGradationBlendWeight;

		// Token: 0x0400CAA9 RID: 51881
		internal static int __PropertyOffset_RetroFuturisticOverride;

		// Token: 0x0400CAAA RID: 51882
		internal static int __PropertyOffset_MainCenterMask;

		// Token: 0x0400CAAB RID: 51883
		[Nullable(2)]
		private FKuroCurveFloat _MainCenterMask;

		// Token: 0x0400CAAC RID: 51884
		internal static int __PropertyOffset_MainCenterMaskRadius;

		// Token: 0x0400CAAD RID: 51885
		[Nullable(2)]
		private FKuroCurveFloat _MainCenterMaskRadius;

		// Token: 0x0400CAAE RID: 51886
		internal static int __PropertyOffset_MainCenterMaskHardness;

		// Token: 0x0400CAAF RID: 51887
		[Nullable(2)]
		private FKuroCurveFloat _MainCenterMaskHardness;

		// Token: 0x0400CAB0 RID: 51888
		internal static int __PropertyOffset_MainStartDistance;

		// Token: 0x0400CAB1 RID: 51889
		[Nullable(2)]
		private FKuroCurveFloat _MainStartDistance;

		// Token: 0x0400CAB2 RID: 51890
		internal static int __PropertyOffset_MainCharacterIntensity;

		// Token: 0x0400CAB3 RID: 51891
		[Nullable(2)]
		private FKuroCurveFloat _MainCharacterIntensity;

		// Token: 0x0400CAB4 RID: 51892
		internal static int __PropertyOffset_VintageColorIntensity;

		// Token: 0x0400CAB5 RID: 51893
		[Nullable(2)]
		private FKuroCurveFloat _VintageColorIntensity;

		// Token: 0x0400CAB6 RID: 51894
		internal static int __PropertyOffset_VintageColorBlackPoint;

		// Token: 0x0400CAB7 RID: 51895
		[Nullable(2)]
		private FKuroCurveFloat _VintageColorBlackPoint;

		// Token: 0x0400CAB8 RID: 51896
		internal static int __PropertyOffset_VintageColorWhitePoint;

		// Token: 0x0400CAB9 RID: 51897
		[Nullable(2)]
		private FKuroCurveFloat _VintageColorWhitePoint;

		// Token: 0x0400CABA RID: 51898
		internal static int __PropertyOffset_VHSLinesColorIntensity;

		// Token: 0x0400CABB RID: 51899
		[Nullable(2)]
		private FKuroCurveFloat _VHSLinesColorIntensity;

		// Token: 0x0400CABC RID: 51900
		internal static int __PropertyOffset_VHSLinesDistortIntensity;

		// Token: 0x0400CABD RID: 51901
		[Nullable(2)]
		private FKuroCurveFloat _VHSLinesDistortIntensity;

		// Token: 0x0400CABE RID: 51902
		internal static int __PropertyOffset_VHSEffectIntensity;

		// Token: 0x0400CABF RID: 51903
		[Nullable(2)]
		private FKuroCurveFloat _VHSEffectIntensity;

		// Token: 0x0400CAC0 RID: 51904
		internal static int __PropertyOffset_VHSSpecklesIntensity;

		// Token: 0x0400CAC1 RID: 51905
		[Nullable(2)]
		private FKuroCurveFloat _VHSSpecklesIntensity;

		// Token: 0x0400CAC2 RID: 51906
		internal static int __PropertyOffset_VHSSpecklesAmount;

		// Token: 0x0400CAC3 RID: 51907
		[Nullable(2)]
		private FKuroCurveFloat _VHSSpecklesAmount;

		// Token: 0x0400CAC4 RID: 51908
		internal static int __PropertyOffset_VHSSpecklesSize;

		// Token: 0x0400CAC5 RID: 51909
		[Nullable(2)]
		private FKuroCurveFloat _VHSSpecklesSize;

		// Token: 0x0400CAC6 RID: 51910
		internal static int __PropertyOffset_CRTDistortion;

		// Token: 0x0400CAC7 RID: 51911
		[Nullable(2)]
		private FKuroCurveFloat _CRTDistortion;

		// Token: 0x0400CAC8 RID: 51912
		internal static int __PropertyOffset_RetroFuturisticAdvancedOverride;

		// Token: 0x0400CAC9 RID: 51913
		internal static int __PropertyOffset_VintageColorCenterMask;

		// Token: 0x0400CACA RID: 51914
		[Nullable(2)]
		private FKuroCurveFloat _VintageColorCenterMask;

		// Token: 0x0400CACB RID: 51915
		internal static int __PropertyOffset_VintageColorStartDistance;

		// Token: 0x0400CACC RID: 51916
		[Nullable(2)]
		private FKuroCurveFloat _VintageColorStartDistance;

		// Token: 0x0400CACD RID: 51917
		internal static int __PropertyOffset_VintageColorCharacterIntensity;

		// Token: 0x0400CACE RID: 51918
		[Nullable(2)]
		private FKuroCurveFloat _VintageColorCharacterIntensity;

		// Token: 0x0400CACF RID: 51919
		internal static int __PropertyOffset_VHSLinesCenterMask;

		// Token: 0x0400CAD0 RID: 51920
		[Nullable(2)]
		private FKuroCurveFloat _VHSLinesCenterMask;

		// Token: 0x0400CAD1 RID: 51921
		internal static int __PropertyOffset_VHSLinesStartDistance;

		// Token: 0x0400CAD2 RID: 51922
		[Nullable(2)]
		private FKuroCurveFloat _VHSLinesStartDistance;

		// Token: 0x0400CAD3 RID: 51923
		internal static int __PropertyOffset_VHSLinesCharacterIntensity;

		// Token: 0x0400CAD4 RID: 51924
		[Nullable(2)]
		private FKuroCurveFloat _VHSLinesCharacterIntensity;

		// Token: 0x0400CAD5 RID: 51925
		internal static int __PropertyOffset_VHSEffectCenterMask;

		// Token: 0x0400CAD6 RID: 51926
		[Nullable(2)]
		private FKuroCurveFloat _VHSEffectCenterMask;

		// Token: 0x0400CAD7 RID: 51927
		internal static int __PropertyOffset_VHSEffectStartDistance;

		// Token: 0x0400CAD8 RID: 51928
		[Nullable(2)]
		private FKuroCurveFloat _VHSEffectStartDistance;

		// Token: 0x0400CAD9 RID: 51929
		internal static int __PropertyOffset_VHSEffectCharacterIntensity;

		// Token: 0x0400CADA RID: 51930
		[Nullable(2)]
		private FKuroCurveFloat _VHSEffectCharacterIntensity;

		// Token: 0x0400CADB RID: 51931
		internal static int __PropertyOffset_VHSSpecklesCenterMask;

		// Token: 0x0400CADC RID: 51932
		[Nullable(2)]
		private FKuroCurveFloat _VHSSpecklesCenterMask;

		// Token: 0x0400CADD RID: 51933
		internal static int __PropertyOffset_VHSSpecklesStartDistance;

		// Token: 0x0400CADE RID: 51934
		[Nullable(2)]
		private FKuroCurveFloat _VHSSpecklesStartDistance;

		// Token: 0x0400CADF RID: 51935
		internal static int __PropertyOffset_VHSSpecklesCharacterIntensity;

		// Token: 0x0400CAE0 RID: 51936
		[Nullable(2)]
		private FKuroCurveFloat _VHSSpecklesCharacterIntensity;

		// Token: 0x0400CAE1 RID: 51937
		internal static int __PropertyOffset_ScreenWaveOverride;

		// Token: 0x0400CAE2 RID: 51938
		internal static int __PropertyOffset_UsePolarWavePattern;

		// Token: 0x0400CAE3 RID: 51939
		internal static int __PropertyOffset_WavePatternTexture;

		// Token: 0x0400CAE4 RID: 51940
		internal static int __PropertyOffset_WavePatternScaleBias;

		// Token: 0x0400CAE5 RID: 51941
		[Nullable(2)]
		private FKuroCurveLinearColor _WavePatternScaleBias;

		// Token: 0x0400CAE6 RID: 51942
		internal static int __PropertyOffset_WaveRadius;

		// Token: 0x0400CAE7 RID: 51943
		[Nullable(2)]
		private FKuroCurveFloat _WaveRadius;

		// Token: 0x0400CAE8 RID: 51944
		internal static int __PropertyOffset_WaveRadiusSmooth;

		// Token: 0x0400CAE9 RID: 51945
		[Nullable(2)]
		private FKuroCurveFloat _WaveRadiusSmooth;

		// Token: 0x0400CAEA RID: 51946
		internal static int __PropertyOffset_WaveHeight;

		// Token: 0x0400CAEB RID: 51947
		[Nullable(2)]
		private FKuroCurveFloat _WaveHeight;

		// Token: 0x0400CAEC RID: 51948
		internal static int __PropertyOffset_WaveHeightSmooth;

		// Token: 0x0400CAED RID: 51949
		[Nullable(2)]
		private FKuroCurveFloat _WaveHeightSmooth;

		// Token: 0x0400CAEE RID: 51950
		internal static int __PropertyOffset_WaveNormalSize;

		// Token: 0x0400CAEF RID: 51951
		[Nullable(2)]
		private FKuroCurveFloat _WaveNormalSize;

		// Token: 0x0400CAF0 RID: 51952
		internal static int __PropertyOffset_WaveRoughness;

		// Token: 0x0400CAF1 RID: 51953
		[Nullable(2)]
		private FKuroCurveFloat _WaveRoughness;

		// Token: 0x0400CAF2 RID: 51954
		internal static int __PropertyOffset_WaveDissolveTexture;

		// Token: 0x0400CAF3 RID: 51955
		internal static int __PropertyOffset_WaveDissolveScaleBias;

		// Token: 0x0400CAF4 RID: 51956
		[Nullable(2)]
		private FKuroCurveLinearColor _WaveDissolveScaleBias;

		// Token: 0x0400CAF5 RID: 51957
		internal static int __PropertyOffset_WaveDissolveProgress;

		// Token: 0x0400CAF6 RID: 51958
		[Nullable(2)]
		private FKuroCurveFloat _WaveDissolveProgress;

		// Token: 0x0400CAF7 RID: 51959
		internal static int __PropertyOffset_WaveDissolveSmooth;

		// Token: 0x0400CAF8 RID: 51960
		[Nullable(2)]
		private FKuroCurveFloat _WaveDissolveSmooth;

		// Token: 0x0400CAF9 RID: 51961
		internal static int __PropertyOffset_WaveColorTexture;

		// Token: 0x0400CAFA RID: 51962
		internal static int __PropertyOffset_WaveColorScaleBias;

		// Token: 0x0400CAFB RID: 51963
		[Nullable(2)]
		private FKuroCurveLinearColor _WaveColorScaleBias;

		// Token: 0x0400CAFC RID: 51964
		internal static int __PropertyOffset_WaveColorTextureTint;

		// Token: 0x0400CAFD RID: 51965
		[Nullable(2)]
		private FKuroCurveLinearColor _WaveColorTextureTint;

		// Token: 0x0400CAFE RID: 51966
		internal static int __PropertyOffset_WaveAmplitude;

		// Token: 0x0400CAFF RID: 51967
		[Nullable(2)]
		private FKuroCurveFloat _WaveAmplitude;

		// Token: 0x0400CB00 RID: 51968
		internal static int __PropertyOffset_AutoExposureOverride;

		// Token: 0x0400CB01 RID: 51969
		internal static int __PropertyOffset_AutoExposureMinBrightness;

		// Token: 0x0400CB02 RID: 51970
		[Nullable(2)]
		private FKuroCurveFloat _AutoExposureMinBrightness;

		// Token: 0x0400CB03 RID: 51971
		internal static int __PropertyOffset_AutoExposureMaxBrightness;

		// Token: 0x0400CB04 RID: 51972
		[Nullable(2)]
		private FKuroCurveFloat _AutoExposureMaxBrightness;

		// Token: 0x0400CB05 RID: 51973
		internal static int __PropertyOffset_WeatherDataAsset;

		// Token: 0x0400CB06 RID: 51974
		internal static int __PropertyOffset_BurstDissolveOverride;

		// Token: 0x0400CB07 RID: 51975
		internal static int __PropertyOffset_BurstDissolveTexture;

		// Token: 0x0400CB08 RID: 51976
		internal static int __PropertyOffset_BurstDissolveThreshold;

		// Token: 0x0400CB09 RID: 51977
		[Nullable(2)]
		private FKuroCurveFloat _BurstDissolveThreshold;

		// Token: 0x0400CB0A RID: 51978
		internal static int __PropertyOffset_BurstDissolveSmooth;

		// Token: 0x0400CB0B RID: 51979
		[Nullable(2)]
		private FKuroCurveFloat _BurstDissolveSmooth;

		// Token: 0x0400CB0C RID: 51980
		internal static int __PropertyOffset_BurstClipThreshold;

		// Token: 0x0400CB0D RID: 51981
		[Nullable(2)]
		private FKuroCurveFloat _BurstClipThreshold;

		// Token: 0x0400CB0E RID: 51982
		internal static int __PropertyOffset_SkyBoxOverride;

		// Token: 0x0400CB0F RID: 51983
		internal static int __PropertyOffset_SkyBoxSetting;

		// Token: 0x0400CB10 RID: 51984
		[Nullable(2)]
		private FKuroEffectPostProcessSkyBoxSetting _SkyBoxSetting;

		// Token: 0x0400CB11 RID: 51985
		internal static int __PropertyOffset_ColorGradingOverride;

		// Token: 0x0400CB12 RID: 51986
		internal static int __PropertyOffset_Desaturate;

		// Token: 0x0400CB13 RID: 51987
		[Nullable(2)]
		private FKuroCurveFloat _Desaturate;

		// Token: 0x0400CB14 RID: 51988
		internal static int __PropertyOffset_Tint;

		// Token: 0x0400CB15 RID: 51989
		[Nullable(2)]
		private FKuroCurveLinearColor _Tint;
	}
}
