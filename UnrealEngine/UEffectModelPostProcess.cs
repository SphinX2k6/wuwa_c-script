using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020003CB RID: 971
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGameplay.EffectModelPostProcess")]
	[UnrealStructLayout(29368, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 29368)]
	public class UEffectModelPostProcess : UEffectModelBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06005EDD RID: 24285 RVA: 0x00086534 File Offset: 0x00084734
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UEffectModelPostProcess._ClassPtr;
		}

		// Token: 0x06005EDE RID: 24286 RVA: 0x00086540 File Offset: 0x00084740
		public UEffectModelPostProcess() : this(BuiltinUtils.AllocNativeUObject(UEffectModelPostProcess.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06005EDF RID: 24287 RVA: 0x00086568 File Offset: 0x00084768
		public UEffectModelPostProcess(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UEffectModelPostProcess.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170012E8 RID: 4840
		// (get) Token: 0x06005EE0 RID: 24288 RVA: 0x0008659C File Offset: 0x0008479C
		// (set) Token: 0x06005EE1 RID: 24289 RVA: 0x000865D5 File Offset: 0x000847D5
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

		// Token: 0x170012E9 RID: 4841
		// (get) Token: 0x06005EE2 RID: 24290 RVA: 0x000865F6 File Offset: 0x000847F6
		// (set) Token: 0x06005EE3 RID: 24291 RVA: 0x00086606 File Offset: 0x00084806
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

		// Token: 0x170012EA RID: 4842
		// (get) Token: 0x06005EE4 RID: 24292 RVA: 0x00086617 File Offset: 0x00084817
		// (set) Token: 0x06005EE5 RID: 24293 RVA: 0x00086627 File Offset: 0x00084827
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

		// Token: 0x170012EB RID: 4843
		// (get) Token: 0x06005EE6 RID: 24294 RVA: 0x00086638 File Offset: 0x00084838
		// (set) Token: 0x06005EE7 RID: 24295 RVA: 0x00086648 File Offset: 0x00084848
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

		// Token: 0x170012EC RID: 4844
		// (get) Token: 0x06005EE8 RID: 24296 RVA: 0x00086659 File Offset: 0x00084859
		// (set) Token: 0x06005EE9 RID: 24297 RVA: 0x00086669 File Offset: 0x00084869
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

		// Token: 0x170012ED RID: 4845
		// (get) Token: 0x06005EEA RID: 24298 RVA: 0x0008667C File Offset: 0x0008487C
		// (set) Token: 0x06005EEB RID: 24299 RVA: 0x000866B5 File Offset: 0x000848B5
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

		// Token: 0x170012EE RID: 4846
		// (get) Token: 0x06005EEC RID: 24300 RVA: 0x000866D6 File Offset: 0x000848D6
		// (set) Token: 0x06005EED RID: 24301 RVA: 0x000866E6 File Offset: 0x000848E6
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

		// Token: 0x170012EF RID: 4847
		// (get) Token: 0x06005EEE RID: 24302 RVA: 0x000866F7 File Offset: 0x000848F7
		// (set) Token: 0x06005EEF RID: 24303 RVA: 0x00086707 File Offset: 0x00084907
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

		// Token: 0x170012F0 RID: 4848
		// (get) Token: 0x06005EF0 RID: 24304 RVA: 0x00086718 File Offset: 0x00084918
		// (set) Token: 0x06005EF1 RID: 24305 RVA: 0x00086728 File Offset: 0x00084928
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

		// Token: 0x170012F1 RID: 4849
		// (get) Token: 0x06005EF2 RID: 24306 RVA: 0x00086739 File Offset: 0x00084939
		// (set) Token: 0x06005EF3 RID: 24307 RVA: 0x00086749 File Offset: 0x00084949
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

		// Token: 0x170012F2 RID: 4850
		// (get) Token: 0x06005EF4 RID: 24308 RVA: 0x0008675A File Offset: 0x0008495A
		// (set) Token: 0x06005EF5 RID: 24309 RVA: 0x0008676A File Offset: 0x0008496A
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

		// Token: 0x170012F3 RID: 4851
		// (get) Token: 0x06005EF6 RID: 24310 RVA: 0x0008677B File Offset: 0x0008497B
		// (set) Token: 0x06005EF7 RID: 24311 RVA: 0x0008678F File Offset: 0x0008498F
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

		// Token: 0x170012F4 RID: 4852
		// (get) Token: 0x06005EF8 RID: 24312 RVA: 0x000867A4 File Offset: 0x000849A4
		// (set) Token: 0x06005EF9 RID: 24313 RVA: 0x000867DD File Offset: 0x000849DD
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

		// Token: 0x170012F5 RID: 4853
		// (get) Token: 0x06005EFA RID: 24314 RVA: 0x000867EC File Offset: 0x000849EC
		// (set) Token: 0x06005EFB RID: 24315 RVA: 0x00086825 File Offset: 0x00084A25
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

		// Token: 0x170012F6 RID: 4854
		// (get) Token: 0x06005EFC RID: 24316 RVA: 0x00086834 File Offset: 0x00084A34
		// (set) Token: 0x06005EFD RID: 24317 RVA: 0x0008686D File Offset: 0x00084A6D
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

		// Token: 0x170012F7 RID: 4855
		// (get) Token: 0x06005EFE RID: 24318 RVA: 0x0008687C File Offset: 0x00084A7C
		// (set) Token: 0x06005EFF RID: 24319 RVA: 0x000868B5 File Offset: 0x00084AB5
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

		// Token: 0x170012F8 RID: 4856
		// (get) Token: 0x06005F00 RID: 24320 RVA: 0x000868C3 File Offset: 0x00084AC3
		// (set) Token: 0x06005F01 RID: 24321 RVA: 0x000868D3 File Offset: 0x00084AD3
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

		// Token: 0x170012F9 RID: 4857
		// (get) Token: 0x06005F02 RID: 24322 RVA: 0x000868E4 File Offset: 0x00084AE4
		// (set) Token: 0x06005F03 RID: 24323 RVA: 0x0008691D File Offset: 0x00084B1D
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

		// Token: 0x170012FA RID: 4858
		// (get) Token: 0x06005F04 RID: 24324 RVA: 0x0008693E File Offset: 0x00084B3E
		// (set) Token: 0x06005F05 RID: 24325 RVA: 0x0008694E File Offset: 0x00084B4E
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

		// Token: 0x170012FB RID: 4859
		// (get) Token: 0x06005F06 RID: 24326 RVA: 0x0008695F File Offset: 0x00084B5F
		// (set) Token: 0x06005F07 RID: 24327 RVA: 0x00086973 File Offset: 0x00084B73
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

		// Token: 0x170012FC RID: 4860
		// (get) Token: 0x06005F08 RID: 24328 RVA: 0x00086988 File Offset: 0x00084B88
		// (set) Token: 0x06005F09 RID: 24329 RVA: 0x000869C1 File Offset: 0x00084BC1
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

		// Token: 0x170012FD RID: 4861
		// (get) Token: 0x06005F0A RID: 24330 RVA: 0x000869E4 File Offset: 0x00084BE4
		// (set) Token: 0x06005F0B RID: 24331 RVA: 0x00086A1D File Offset: 0x00084C1D
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

		// Token: 0x170012FE RID: 4862
		// (get) Token: 0x06005F0C RID: 24332 RVA: 0x00086A3E File Offset: 0x00084C3E
		// (set) Token: 0x06005F0D RID: 24333 RVA: 0x00086A52 File Offset: 0x00084C52
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

		// Token: 0x170012FF RID: 4863
		// (get) Token: 0x06005F0E RID: 24334 RVA: 0x00086A67 File Offset: 0x00084C67
		// (set) Token: 0x06005F0F RID: 24335 RVA: 0x00086A7B File Offset: 0x00084C7B
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

		// Token: 0x17001300 RID: 4864
		// (get) Token: 0x06005F10 RID: 24336 RVA: 0x00086A90 File Offset: 0x00084C90
		// (set) Token: 0x06005F11 RID: 24337 RVA: 0x00086AC9 File Offset: 0x00084CC9
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

		// Token: 0x17001301 RID: 4865
		// (get) Token: 0x06005F12 RID: 24338 RVA: 0x00086AEA File Offset: 0x00084CEA
		// (set) Token: 0x06005F13 RID: 24339 RVA: 0x00086AFA File Offset: 0x00084CFA
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

		// Token: 0x17001302 RID: 4866
		// (get) Token: 0x06005F14 RID: 24340 RVA: 0x00086B0C File Offset: 0x00084D0C
		// (set) Token: 0x06005F15 RID: 24341 RVA: 0x00086B45 File Offset: 0x00084D45
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

		// Token: 0x17001303 RID: 4867
		// (get) Token: 0x06005F16 RID: 24342 RVA: 0x00086B66 File Offset: 0x00084D66
		// (set) Token: 0x06005F17 RID: 24343 RVA: 0x00086B76 File Offset: 0x00084D76
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

		// Token: 0x17001304 RID: 4868
		// (get) Token: 0x06005F18 RID: 24344 RVA: 0x00086B88 File Offset: 0x00084D88
		// (set) Token: 0x06005F19 RID: 24345 RVA: 0x00086BC1 File Offset: 0x00084DC1
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

		// Token: 0x17001305 RID: 4869
		// (get) Token: 0x06005F1A RID: 24346 RVA: 0x00086BE2 File Offset: 0x00084DE2
		// (set) Token: 0x06005F1B RID: 24347 RVA: 0x00086BF2 File Offset: 0x00084DF2
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

		// Token: 0x17001306 RID: 4870
		// (get) Token: 0x06005F1C RID: 24348 RVA: 0x00086C04 File Offset: 0x00084E04
		// (set) Token: 0x06005F1D RID: 24349 RVA: 0x00086C3D File Offset: 0x00084E3D
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

		// Token: 0x17001307 RID: 4871
		// (get) Token: 0x06005F1E RID: 24350 RVA: 0x00086C5E File Offset: 0x00084E5E
		// (set) Token: 0x06005F1F RID: 24351 RVA: 0x00086C6E File Offset: 0x00084E6E
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

		// Token: 0x17001308 RID: 4872
		// (get) Token: 0x06005F20 RID: 24352 RVA: 0x00086C80 File Offset: 0x00084E80
		// (set) Token: 0x06005F21 RID: 24353 RVA: 0x00086CB9 File Offset: 0x00084EB9
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

		// Token: 0x17001309 RID: 4873
		// (get) Token: 0x06005F22 RID: 24354 RVA: 0x00086CDA File Offset: 0x00084EDA
		// (set) Token: 0x06005F23 RID: 24355 RVA: 0x00086CEA File Offset: 0x00084EEA
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

		// Token: 0x1700130A RID: 4874
		// (get) Token: 0x06005F24 RID: 24356 RVA: 0x00086CFC File Offset: 0x00084EFC
		// (set) Token: 0x06005F25 RID: 24357 RVA: 0x00086D35 File Offset: 0x00084F35
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

		// Token: 0x1700130B RID: 4875
		// (get) Token: 0x06005F26 RID: 24358 RVA: 0x00086D58 File Offset: 0x00084F58
		// (set) Token: 0x06005F27 RID: 24359 RVA: 0x00086D91 File Offset: 0x00084F91
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

		// Token: 0x1700130C RID: 4876
		// (get) Token: 0x06005F28 RID: 24360 RVA: 0x00086DB2 File Offset: 0x00084FB2
		// (set) Token: 0x06005F29 RID: 24361 RVA: 0x00086DC2 File Offset: 0x00084FC2
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

		// Token: 0x1700130D RID: 4877
		// (get) Token: 0x06005F2A RID: 24362 RVA: 0x00086DD4 File Offset: 0x00084FD4
		// (set) Token: 0x06005F2B RID: 24363 RVA: 0x00086E0D File Offset: 0x0008500D
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

		// Token: 0x1700130E RID: 4878
		// (get) Token: 0x06005F2C RID: 24364 RVA: 0x00086E30 File Offset: 0x00085030
		// (set) Token: 0x06005F2D RID: 24365 RVA: 0x00086E69 File Offset: 0x00085069
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

		// Token: 0x1700130F RID: 4879
		// (get) Token: 0x06005F2E RID: 24366 RVA: 0x00086E8A File Offset: 0x0008508A
		// (set) Token: 0x06005F2F RID: 24367 RVA: 0x00086E9A File Offset: 0x0008509A
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

		// Token: 0x17001310 RID: 4880
		// (get) Token: 0x06005F30 RID: 24368 RVA: 0x00086EAC File Offset: 0x000850AC
		// (set) Token: 0x06005F31 RID: 24369 RVA: 0x00086EE5 File Offset: 0x000850E5
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

		// Token: 0x17001311 RID: 4881
		// (get) Token: 0x06005F32 RID: 24370 RVA: 0x00086F06 File Offset: 0x00085106
		// (set) Token: 0x06005F33 RID: 24371 RVA: 0x00086F16 File Offset: 0x00085116
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

		// Token: 0x17001312 RID: 4882
		// (get) Token: 0x06005F34 RID: 24372 RVA: 0x00086F28 File Offset: 0x00085128
		// (set) Token: 0x06005F35 RID: 24373 RVA: 0x00086F61 File Offset: 0x00085161
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

		// Token: 0x17001313 RID: 4883
		// (get) Token: 0x06005F36 RID: 24374 RVA: 0x00086F84 File Offset: 0x00085184
		// (set) Token: 0x06005F37 RID: 24375 RVA: 0x00086FBD File Offset: 0x000851BD
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

		// Token: 0x17001314 RID: 4884
		// (get) Token: 0x06005F38 RID: 24376 RVA: 0x00086FE0 File Offset: 0x000851E0
		// (set) Token: 0x06005F39 RID: 24377 RVA: 0x00087019 File Offset: 0x00085219
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

		// Token: 0x17001315 RID: 4885
		// (get) Token: 0x06005F3A RID: 24378 RVA: 0x0008703C File Offset: 0x0008523C
		// (set) Token: 0x06005F3B RID: 24379 RVA: 0x00087075 File Offset: 0x00085275
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

		// Token: 0x17001316 RID: 4886
		// (get) Token: 0x06005F3C RID: 24380 RVA: 0x00087096 File Offset: 0x00085296
		// (set) Token: 0x06005F3D RID: 24381 RVA: 0x000870A6 File Offset: 0x000852A6
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

		// Token: 0x17001317 RID: 4887
		// (get) Token: 0x06005F3E RID: 24382 RVA: 0x000870B7 File Offset: 0x000852B7
		// (set) Token: 0x06005F3F RID: 24383 RVA: 0x000870C7 File Offset: 0x000852C7
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

		// Token: 0x17001318 RID: 4888
		// (get) Token: 0x06005F40 RID: 24384 RVA: 0x000870D8 File Offset: 0x000852D8
		// (set) Token: 0x06005F41 RID: 24385 RVA: 0x000870E8 File Offset: 0x000852E8
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

		// Token: 0x17001319 RID: 4889
		// (get) Token: 0x06005F42 RID: 24386 RVA: 0x000870F9 File Offset: 0x000852F9
		// (set) Token: 0x06005F43 RID: 24387 RVA: 0x00087109 File Offset: 0x00085309
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

		// Token: 0x1700131A RID: 4890
		// (get) Token: 0x06005F44 RID: 24388 RVA: 0x0008711A File Offset: 0x0008531A
		// (set) Token: 0x06005F45 RID: 24389 RVA: 0x0008712A File Offset: 0x0008532A
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

		// Token: 0x1700131B RID: 4891
		// (get) Token: 0x06005F46 RID: 24390 RVA: 0x0008713B File Offset: 0x0008533B
		// (set) Token: 0x06005F47 RID: 24391 RVA: 0x0008714B File Offset: 0x0008534B
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

		// Token: 0x1700131C RID: 4892
		// (get) Token: 0x06005F48 RID: 24392 RVA: 0x0008715C File Offset: 0x0008535C
		// (set) Token: 0x06005F49 RID: 24393 RVA: 0x00087195 File Offset: 0x00085395
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

		// Token: 0x1700131D RID: 4893
		// (get) Token: 0x06005F4A RID: 24394 RVA: 0x000871B6 File Offset: 0x000853B6
		// (set) Token: 0x06005F4B RID: 24395 RVA: 0x000871C6 File Offset: 0x000853C6
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

		// Token: 0x1700131E RID: 4894
		// (get) Token: 0x06005F4C RID: 24396 RVA: 0x000871D8 File Offset: 0x000853D8
		// (set) Token: 0x06005F4D RID: 24397 RVA: 0x00087211 File Offset: 0x00085411
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

		// Token: 0x1700131F RID: 4895
		// (get) Token: 0x06005F4E RID: 24398 RVA: 0x00087232 File Offset: 0x00085432
		// (set) Token: 0x06005F4F RID: 24399 RVA: 0x00087242 File Offset: 0x00085442
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

		// Token: 0x17001320 RID: 4896
		// (get) Token: 0x06005F50 RID: 24400 RVA: 0x00087254 File Offset: 0x00085454
		// (set) Token: 0x06005F51 RID: 24401 RVA: 0x0008728D File Offset: 0x0008548D
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

		// Token: 0x17001321 RID: 4897
		// (get) Token: 0x06005F52 RID: 24402 RVA: 0x000872AE File Offset: 0x000854AE
		// (set) Token: 0x06005F53 RID: 24403 RVA: 0x000872BE File Offset: 0x000854BE
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

		// Token: 0x17001322 RID: 4898
		// (get) Token: 0x06005F54 RID: 24404 RVA: 0x000872D0 File Offset: 0x000854D0
		// (set) Token: 0x06005F55 RID: 24405 RVA: 0x00087309 File Offset: 0x00085509
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

		// Token: 0x17001323 RID: 4899
		// (get) Token: 0x06005F56 RID: 24406 RVA: 0x0008732A File Offset: 0x0008552A
		// (set) Token: 0x06005F57 RID: 24407 RVA: 0x0008733A File Offset: 0x0008553A
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

		// Token: 0x17001324 RID: 4900
		// (get) Token: 0x06005F58 RID: 24408 RVA: 0x0008734C File Offset: 0x0008554C
		// (set) Token: 0x06005F59 RID: 24409 RVA: 0x00087385 File Offset: 0x00085585
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

		// Token: 0x17001325 RID: 4901
		// (get) Token: 0x06005F5A RID: 24410 RVA: 0x000873A8 File Offset: 0x000855A8
		// (set) Token: 0x06005F5B RID: 24411 RVA: 0x000873E1 File Offset: 0x000855E1
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

		// Token: 0x17001326 RID: 4902
		// (get) Token: 0x06005F5C RID: 24412 RVA: 0x00087404 File Offset: 0x00085604
		// (set) Token: 0x06005F5D RID: 24413 RVA: 0x0008743D File Offset: 0x0008563D
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

		// Token: 0x17001327 RID: 4903
		// (get) Token: 0x06005F5E RID: 24414 RVA: 0x00087460 File Offset: 0x00085660
		// (set) Token: 0x06005F5F RID: 24415 RVA: 0x00087499 File Offset: 0x00085699
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

		// Token: 0x17001328 RID: 4904
		// (get) Token: 0x06005F60 RID: 24416 RVA: 0x000874BC File Offset: 0x000856BC
		// (set) Token: 0x06005F61 RID: 24417 RVA: 0x000874F5 File Offset: 0x000856F5
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

		// Token: 0x17001329 RID: 4905
		// (get) Token: 0x06005F62 RID: 24418 RVA: 0x00087518 File Offset: 0x00085718
		// (set) Token: 0x06005F63 RID: 24419 RVA: 0x00087551 File Offset: 0x00085751
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

		// Token: 0x1700132A RID: 4906
		// (get) Token: 0x06005F64 RID: 24420 RVA: 0x00087574 File Offset: 0x00085774
		// (set) Token: 0x06005F65 RID: 24421 RVA: 0x000875AD File Offset: 0x000857AD
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

		// Token: 0x1700132B RID: 4907
		// (get) Token: 0x06005F66 RID: 24422 RVA: 0x000875D0 File Offset: 0x000857D0
		// (set) Token: 0x06005F67 RID: 24423 RVA: 0x00087609 File Offset: 0x00085809
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

		// Token: 0x1700132C RID: 4908
		// (get) Token: 0x06005F68 RID: 24424 RVA: 0x0008762A File Offset: 0x0008582A
		// (set) Token: 0x06005F69 RID: 24425 RVA: 0x0008763A File Offset: 0x0008583A
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

		// Token: 0x1700132D RID: 4909
		// (get) Token: 0x06005F6A RID: 24426 RVA: 0x0008764C File Offset: 0x0008584C
		// (set) Token: 0x06005F6B RID: 24427 RVA: 0x00087685 File Offset: 0x00085885
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

		// Token: 0x1700132E RID: 4910
		// (get) Token: 0x06005F6C RID: 24428 RVA: 0x000876A6 File Offset: 0x000858A6
		// (set) Token: 0x06005F6D RID: 24429 RVA: 0x000876B6 File Offset: 0x000858B6
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

		// Token: 0x1700132F RID: 4911
		// (get) Token: 0x06005F6E RID: 24430 RVA: 0x000876C8 File Offset: 0x000858C8
		// (set) Token: 0x06005F6F RID: 24431 RVA: 0x00087701 File Offset: 0x00085901
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

		// Token: 0x17001330 RID: 4912
		// (get) Token: 0x06005F70 RID: 24432 RVA: 0x00087722 File Offset: 0x00085922
		// (set) Token: 0x06005F71 RID: 24433 RVA: 0x00087732 File Offset: 0x00085932
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

		// Token: 0x17001331 RID: 4913
		// (get) Token: 0x06005F72 RID: 24434 RVA: 0x00087744 File Offset: 0x00085944
		// (set) Token: 0x06005F73 RID: 24435 RVA: 0x0008777D File Offset: 0x0008597D
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

		// Token: 0x17001332 RID: 4914
		// (get) Token: 0x06005F74 RID: 24436 RVA: 0x0008779E File Offset: 0x0008599E
		// (set) Token: 0x06005F75 RID: 24437 RVA: 0x000877AE File Offset: 0x000859AE
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

		// Token: 0x17001333 RID: 4915
		// (get) Token: 0x06005F76 RID: 24438 RVA: 0x000877BF File Offset: 0x000859BF
		// (set) Token: 0x06005F77 RID: 24439 RVA: 0x000877D3 File Offset: 0x000859D3
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

		// Token: 0x17001334 RID: 4916
		// (get) Token: 0x06005F78 RID: 24440 RVA: 0x000877E8 File Offset: 0x000859E8
		// (set) Token: 0x06005F79 RID: 24441 RVA: 0x000877F8 File Offset: 0x000859F8
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

		// Token: 0x17001335 RID: 4917
		// (get) Token: 0x06005F7A RID: 24442 RVA: 0x0008780C File Offset: 0x00085A0C
		// (set) Token: 0x06005F7B RID: 24443 RVA: 0x00087845 File Offset: 0x00085A45
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

		// Token: 0x17001336 RID: 4918
		// (get) Token: 0x06005F7C RID: 24444 RVA: 0x00087866 File Offset: 0x00085A66
		// (set) Token: 0x06005F7D RID: 24445 RVA: 0x00087876 File Offset: 0x00085A76
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

		// Token: 0x17001337 RID: 4919
		// (get) Token: 0x06005F7E RID: 24446 RVA: 0x00087888 File Offset: 0x00085A88
		// (set) Token: 0x06005F7F RID: 24447 RVA: 0x000878C1 File Offset: 0x00085AC1
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

		// Token: 0x17001338 RID: 4920
		// (get) Token: 0x06005F80 RID: 24448 RVA: 0x000878E2 File Offset: 0x00085AE2
		// (set) Token: 0x06005F81 RID: 24449 RVA: 0x000878F2 File Offset: 0x00085AF2
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

		// Token: 0x17001339 RID: 4921
		// (get) Token: 0x06005F82 RID: 24450 RVA: 0x00087904 File Offset: 0x00085B04
		// (set) Token: 0x06005F83 RID: 24451 RVA: 0x0008793D File Offset: 0x00085B3D
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

		// Token: 0x1700133A RID: 4922
		// (get) Token: 0x06005F84 RID: 24452 RVA: 0x0008795E File Offset: 0x00085B5E
		// (set) Token: 0x06005F85 RID: 24453 RVA: 0x0008796E File Offset: 0x00085B6E
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

		// Token: 0x1700133B RID: 4923
		// (get) Token: 0x06005F86 RID: 24454 RVA: 0x00087980 File Offset: 0x00085B80
		// (set) Token: 0x06005F87 RID: 24455 RVA: 0x000879B9 File Offset: 0x00085BB9
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

		// Token: 0x1700133C RID: 4924
		// (get) Token: 0x06005F88 RID: 24456 RVA: 0x000879DA File Offset: 0x00085BDA
		// (set) Token: 0x06005F89 RID: 24457 RVA: 0x000879EA File Offset: 0x00085BEA
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

		// Token: 0x1700133D RID: 4925
		// (get) Token: 0x06005F8A RID: 24458 RVA: 0x000879FB File Offset: 0x00085BFB
		// (set) Token: 0x06005F8B RID: 24459 RVA: 0x00087A0B File Offset: 0x00085C0B
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

		// Token: 0x1700133E RID: 4926
		// (get) Token: 0x06005F8C RID: 24460 RVA: 0x00087A1C File Offset: 0x00085C1C
		// (set) Token: 0x06005F8D RID: 24461 RVA: 0x00087A2C File Offset: 0x00085C2C
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

		// Token: 0x1700133F RID: 4927
		// (get) Token: 0x06005F8E RID: 24462 RVA: 0x00087A40 File Offset: 0x00085C40
		// (set) Token: 0x06005F8F RID: 24463 RVA: 0x00087A79 File Offset: 0x00085C79
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

		// Token: 0x17001340 RID: 4928
		// (get) Token: 0x06005F90 RID: 24464 RVA: 0x00087A9A File Offset: 0x00085C9A
		// (set) Token: 0x06005F91 RID: 24465 RVA: 0x00087AAA File Offset: 0x00085CAA
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

		// Token: 0x17001341 RID: 4929
		// (get) Token: 0x06005F92 RID: 24466 RVA: 0x00087ABC File Offset: 0x00085CBC
		// (set) Token: 0x06005F93 RID: 24467 RVA: 0x00087AF5 File Offset: 0x00085CF5
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

		// Token: 0x17001342 RID: 4930
		// (get) Token: 0x06005F94 RID: 24468 RVA: 0x00087B16 File Offset: 0x00085D16
		// (set) Token: 0x06005F95 RID: 24469 RVA: 0x00087B26 File Offset: 0x00085D26
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

		// Token: 0x17001343 RID: 4931
		// (get) Token: 0x06005F96 RID: 24470 RVA: 0x00087B38 File Offset: 0x00085D38
		// (set) Token: 0x06005F97 RID: 24471 RVA: 0x00087B71 File Offset: 0x00085D71
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

		// Token: 0x17001344 RID: 4932
		// (get) Token: 0x06005F98 RID: 24472 RVA: 0x00087B92 File Offset: 0x00085D92
		// (set) Token: 0x06005F99 RID: 24473 RVA: 0x00087BA2 File Offset: 0x00085DA2
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

		// Token: 0x17001345 RID: 4933
		// (get) Token: 0x06005F9A RID: 24474 RVA: 0x00087BB4 File Offset: 0x00085DB4
		// (set) Token: 0x06005F9B RID: 24475 RVA: 0x00087BED File Offset: 0x00085DED
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

		// Token: 0x17001346 RID: 4934
		// (get) Token: 0x06005F9C RID: 24476 RVA: 0x00087C0E File Offset: 0x00085E0E
		// (set) Token: 0x06005F9D RID: 24477 RVA: 0x00087C1E File Offset: 0x00085E1E
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

		// Token: 0x17001347 RID: 4935
		// (get) Token: 0x06005F9E RID: 24478 RVA: 0x00087C30 File Offset: 0x00085E30
		// (set) Token: 0x06005F9F RID: 24479 RVA: 0x00087C69 File Offset: 0x00085E69
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

		// Token: 0x17001348 RID: 4936
		// (get) Token: 0x06005FA0 RID: 24480 RVA: 0x00087C8A File Offset: 0x00085E8A
		// (set) Token: 0x06005FA1 RID: 24481 RVA: 0x00087C9A File Offset: 0x00085E9A
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

		// Token: 0x17001349 RID: 4937
		// (get) Token: 0x06005FA2 RID: 24482 RVA: 0x00087CAB File Offset: 0x00085EAB
		// (set) Token: 0x06005FA3 RID: 24483 RVA: 0x00087CBB File Offset: 0x00085EBB
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

		// Token: 0x1700134A RID: 4938
		// (get) Token: 0x06005FA4 RID: 24484 RVA: 0x00087CCC File Offset: 0x00085ECC
		// (set) Token: 0x06005FA5 RID: 24485 RVA: 0x00087CDC File Offset: 0x00085EDC
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

		// Token: 0x1700134B RID: 4939
		// (get) Token: 0x06005FA6 RID: 24486 RVA: 0x00087CF0 File Offset: 0x00085EF0
		// (set) Token: 0x06005FA7 RID: 24487 RVA: 0x00087D29 File Offset: 0x00085F29
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

		// Token: 0x1700134C RID: 4940
		// (get) Token: 0x06005FA8 RID: 24488 RVA: 0x00087D4C File Offset: 0x00085F4C
		// (set) Token: 0x06005FA9 RID: 24489 RVA: 0x00087D85 File Offset: 0x00085F85
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

		// Token: 0x1700134D RID: 4941
		// (get) Token: 0x06005FAA RID: 24490 RVA: 0x00087DA6 File Offset: 0x00085FA6
		// (set) Token: 0x06005FAB RID: 24491 RVA: 0x00087DBA File Offset: 0x00085FBA
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

		// Token: 0x1700134E RID: 4942
		// (get) Token: 0x06005FAC RID: 24492 RVA: 0x00087DD0 File Offset: 0x00085FD0
		// (set) Token: 0x06005FAD RID: 24493 RVA: 0x00087E09 File Offset: 0x00086009
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

		// Token: 0x1700134F RID: 4943
		// (get) Token: 0x06005FAE RID: 24494 RVA: 0x00087E2C File Offset: 0x0008602C
		// (set) Token: 0x06005FAF RID: 24495 RVA: 0x00087E65 File Offset: 0x00086065
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

		// Token: 0x17001350 RID: 4944
		// (get) Token: 0x06005FB0 RID: 24496 RVA: 0x00087E86 File Offset: 0x00086086
		// (set) Token: 0x06005FB1 RID: 24497 RVA: 0x00087E96 File Offset: 0x00086096
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

		// Token: 0x17001351 RID: 4945
		// (get) Token: 0x06005FB2 RID: 24498 RVA: 0x00087EA8 File Offset: 0x000860A8
		// (set) Token: 0x06005FB3 RID: 24499 RVA: 0x00087EE1 File Offset: 0x000860E1
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

		// Token: 0x17001352 RID: 4946
		// (get) Token: 0x06005FB4 RID: 24500 RVA: 0x00087F04 File Offset: 0x00086104
		// (set) Token: 0x06005FB5 RID: 24501 RVA: 0x00087F3D File Offset: 0x0008613D
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

		// Token: 0x17001353 RID: 4947
		// (get) Token: 0x06005FB6 RID: 24502 RVA: 0x00087F60 File Offset: 0x00086160
		// (set) Token: 0x06005FB7 RID: 24503 RVA: 0x00087F99 File Offset: 0x00086199
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

		// Token: 0x17001354 RID: 4948
		// (get) Token: 0x06005FB8 RID: 24504 RVA: 0x00087FBC File Offset: 0x000861BC
		// (set) Token: 0x06005FB9 RID: 24505 RVA: 0x00087FF5 File Offset: 0x000861F5
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

		// Token: 0x17001355 RID: 4949
		// (get) Token: 0x06005FBA RID: 24506 RVA: 0x00088018 File Offset: 0x00086218
		// (set) Token: 0x06005FBB RID: 24507 RVA: 0x00088051 File Offset: 0x00086251
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

		// Token: 0x17001356 RID: 4950
		// (get) Token: 0x06005FBC RID: 24508 RVA: 0x00088074 File Offset: 0x00086274
		// (set) Token: 0x06005FBD RID: 24509 RVA: 0x000880AD File Offset: 0x000862AD
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

		// Token: 0x17001357 RID: 4951
		// (get) Token: 0x06005FBE RID: 24510 RVA: 0x000880D0 File Offset: 0x000862D0
		// (set) Token: 0x06005FBF RID: 24511 RVA: 0x00088109 File Offset: 0x00086309
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

		// Token: 0x17001358 RID: 4952
		// (get) Token: 0x06005FC0 RID: 24512 RVA: 0x0008812C File Offset: 0x0008632C
		// (set) Token: 0x06005FC1 RID: 24513 RVA: 0x00088165 File Offset: 0x00086365
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

		// Token: 0x17001359 RID: 4953
		// (get) Token: 0x06005FC2 RID: 24514 RVA: 0x00088188 File Offset: 0x00086388
		// (set) Token: 0x06005FC3 RID: 24515 RVA: 0x000881C1 File Offset: 0x000863C1
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

		// Token: 0x1700135A RID: 4954
		// (get) Token: 0x06005FC4 RID: 24516 RVA: 0x000881E4 File Offset: 0x000863E4
		// (set) Token: 0x06005FC5 RID: 24517 RVA: 0x0008821D File Offset: 0x0008641D
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

		// Token: 0x1700135B RID: 4955
		// (get) Token: 0x06005FC6 RID: 24518 RVA: 0x00088240 File Offset: 0x00086440
		// (set) Token: 0x06005FC7 RID: 24519 RVA: 0x00088279 File Offset: 0x00086479
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

		// Token: 0x1700135C RID: 4956
		// (get) Token: 0x06005FC8 RID: 24520 RVA: 0x0008829C File Offset: 0x0008649C
		// (set) Token: 0x06005FC9 RID: 24521 RVA: 0x000882D5 File Offset: 0x000864D5
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

		// Token: 0x1700135D RID: 4957
		// (get) Token: 0x06005FCA RID: 24522 RVA: 0x000882F8 File Offset: 0x000864F8
		// (set) Token: 0x06005FCB RID: 24523 RVA: 0x00088331 File Offset: 0x00086531
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

		// Token: 0x1700135E RID: 4958
		// (get) Token: 0x06005FCC RID: 24524 RVA: 0x00088354 File Offset: 0x00086554
		// (set) Token: 0x06005FCD RID: 24525 RVA: 0x0008838D File Offset: 0x0008658D
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

		// Token: 0x1700135F RID: 4959
		// (get) Token: 0x06005FCE RID: 24526 RVA: 0x000883B0 File Offset: 0x000865B0
		// (set) Token: 0x06005FCF RID: 24527 RVA: 0x000883E9 File Offset: 0x000865E9
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

		// Token: 0x17001360 RID: 4960
		// (get) Token: 0x06005FD0 RID: 24528 RVA: 0x0008840A File Offset: 0x0008660A
		// (set) Token: 0x06005FD1 RID: 24529 RVA: 0x0008841A File Offset: 0x0008661A
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

		// Token: 0x17001361 RID: 4961
		// (get) Token: 0x06005FD2 RID: 24530 RVA: 0x0008842C File Offset: 0x0008662C
		// (set) Token: 0x06005FD3 RID: 24531 RVA: 0x00088465 File Offset: 0x00086665
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

		// Token: 0x17001362 RID: 4962
		// (get) Token: 0x06005FD4 RID: 24532 RVA: 0x00088488 File Offset: 0x00086688
		// (set) Token: 0x06005FD5 RID: 24533 RVA: 0x000884C1 File Offset: 0x000866C1
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

		// Token: 0x17001363 RID: 4963
		// (get) Token: 0x06005FD6 RID: 24534 RVA: 0x000884E4 File Offset: 0x000866E4
		// (set) Token: 0x06005FD7 RID: 24535 RVA: 0x0008851D File Offset: 0x0008671D
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

		// Token: 0x17001364 RID: 4964
		// (get) Token: 0x06005FD8 RID: 24536 RVA: 0x00088540 File Offset: 0x00086740
		// (set) Token: 0x06005FD9 RID: 24537 RVA: 0x00088579 File Offset: 0x00086779
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

		// Token: 0x17001365 RID: 4965
		// (get) Token: 0x06005FDA RID: 24538 RVA: 0x0008859C File Offset: 0x0008679C
		// (set) Token: 0x06005FDB RID: 24539 RVA: 0x000885D5 File Offset: 0x000867D5
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

		// Token: 0x17001366 RID: 4966
		// (get) Token: 0x06005FDC RID: 24540 RVA: 0x000885F8 File Offset: 0x000867F8
		// (set) Token: 0x06005FDD RID: 24541 RVA: 0x00088631 File Offset: 0x00086831
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

		// Token: 0x17001367 RID: 4967
		// (get) Token: 0x06005FDE RID: 24542 RVA: 0x00088654 File Offset: 0x00086854
		// (set) Token: 0x06005FDF RID: 24543 RVA: 0x0008868D File Offset: 0x0008688D
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

		// Token: 0x17001368 RID: 4968
		// (get) Token: 0x06005FE0 RID: 24544 RVA: 0x000886B0 File Offset: 0x000868B0
		// (set) Token: 0x06005FE1 RID: 24545 RVA: 0x000886E9 File Offset: 0x000868E9
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

		// Token: 0x17001369 RID: 4969
		// (get) Token: 0x06005FE2 RID: 24546 RVA: 0x0008870C File Offset: 0x0008690C
		// (set) Token: 0x06005FE3 RID: 24547 RVA: 0x00088745 File Offset: 0x00086945
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

		// Token: 0x1700136A RID: 4970
		// (get) Token: 0x06005FE4 RID: 24548 RVA: 0x00088768 File Offset: 0x00086968
		// (set) Token: 0x06005FE5 RID: 24549 RVA: 0x000887A1 File Offset: 0x000869A1
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

		// Token: 0x1700136B RID: 4971
		// (get) Token: 0x06005FE6 RID: 24550 RVA: 0x000887C4 File Offset: 0x000869C4
		// (set) Token: 0x06005FE7 RID: 24551 RVA: 0x000887FD File Offset: 0x000869FD
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

		// Token: 0x1700136C RID: 4972
		// (get) Token: 0x06005FE8 RID: 24552 RVA: 0x00088820 File Offset: 0x00086A20
		// (set) Token: 0x06005FE9 RID: 24553 RVA: 0x00088859 File Offset: 0x00086A59
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

		// Token: 0x1700136D RID: 4973
		// (get) Token: 0x06005FEA RID: 24554 RVA: 0x0008887A File Offset: 0x00086A7A
		// (set) Token: 0x06005FEB RID: 24555 RVA: 0x0008888A File Offset: 0x00086A8A
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

		// Token: 0x1700136E RID: 4974
		// (get) Token: 0x06005FEC RID: 24556 RVA: 0x0008889B File Offset: 0x00086A9B
		// (set) Token: 0x06005FED RID: 24557 RVA: 0x000888AB File Offset: 0x00086AAB
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

		// Token: 0x1700136F RID: 4975
		// (get) Token: 0x06005FEE RID: 24558 RVA: 0x000888BC File Offset: 0x00086ABC
		// (set) Token: 0x06005FEF RID: 24559 RVA: 0x000888D0 File Offset: 0x00086AD0
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

		// Token: 0x17001370 RID: 4976
		// (get) Token: 0x06005FF0 RID: 24560 RVA: 0x000888E8 File Offset: 0x00086AE8
		// (set) Token: 0x06005FF1 RID: 24561 RVA: 0x00088921 File Offset: 0x00086B21
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

		// Token: 0x17001371 RID: 4977
		// (get) Token: 0x06005FF2 RID: 24562 RVA: 0x00088944 File Offset: 0x00086B44
		// (set) Token: 0x06005FF3 RID: 24563 RVA: 0x0008897D File Offset: 0x00086B7D
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

		// Token: 0x17001372 RID: 4978
		// (get) Token: 0x06005FF4 RID: 24564 RVA: 0x000889A0 File Offset: 0x00086BA0
		// (set) Token: 0x06005FF5 RID: 24565 RVA: 0x000889D9 File Offset: 0x00086BD9
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

		// Token: 0x17001373 RID: 4979
		// (get) Token: 0x06005FF6 RID: 24566 RVA: 0x000889FC File Offset: 0x00086BFC
		// (set) Token: 0x06005FF7 RID: 24567 RVA: 0x00088A35 File Offset: 0x00086C35
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

		// Token: 0x17001374 RID: 4980
		// (get) Token: 0x06005FF8 RID: 24568 RVA: 0x00088A58 File Offset: 0x00086C58
		// (set) Token: 0x06005FF9 RID: 24569 RVA: 0x00088A91 File Offset: 0x00086C91
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

		// Token: 0x17001375 RID: 4981
		// (get) Token: 0x06005FFA RID: 24570 RVA: 0x00088AB4 File Offset: 0x00086CB4
		// (set) Token: 0x06005FFB RID: 24571 RVA: 0x00088AED File Offset: 0x00086CED
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

		// Token: 0x17001376 RID: 4982
		// (get) Token: 0x06005FFC RID: 24572 RVA: 0x00088B10 File Offset: 0x00086D10
		// (set) Token: 0x06005FFD RID: 24573 RVA: 0x00088B49 File Offset: 0x00086D49
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

		// Token: 0x17001377 RID: 4983
		// (get) Token: 0x06005FFE RID: 24574 RVA: 0x00088B6A File Offset: 0x00086D6A
		// (set) Token: 0x06005FFF RID: 24575 RVA: 0x00088B7E File Offset: 0x00086D7E
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

		// Token: 0x17001378 RID: 4984
		// (get) Token: 0x06006000 RID: 24576 RVA: 0x00088B94 File Offset: 0x00086D94
		// (set) Token: 0x06006001 RID: 24577 RVA: 0x00088BCD File Offset: 0x00086DCD
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

		// Token: 0x17001379 RID: 4985
		// (get) Token: 0x06006002 RID: 24578 RVA: 0x00088BF0 File Offset: 0x00086DF0
		// (set) Token: 0x06006003 RID: 24579 RVA: 0x00088C29 File Offset: 0x00086E29
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

		// Token: 0x1700137A RID: 4986
		// (get) Token: 0x06006004 RID: 24580 RVA: 0x00088C4C File Offset: 0x00086E4C
		// (set) Token: 0x06006005 RID: 24581 RVA: 0x00088C85 File Offset: 0x00086E85
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

		// Token: 0x1700137B RID: 4987
		// (get) Token: 0x06006006 RID: 24582 RVA: 0x00088CA6 File Offset: 0x00086EA6
		// (set) Token: 0x06006007 RID: 24583 RVA: 0x00088CBA File Offset: 0x00086EBA
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

		// Token: 0x1700137C RID: 4988
		// (get) Token: 0x06006008 RID: 24584 RVA: 0x00088CD0 File Offset: 0x00086ED0
		// (set) Token: 0x06006009 RID: 24585 RVA: 0x00088D09 File Offset: 0x00086F09
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

		// Token: 0x1700137D RID: 4989
		// (get) Token: 0x0600600A RID: 24586 RVA: 0x00088D2C File Offset: 0x00086F2C
		// (set) Token: 0x0600600B RID: 24587 RVA: 0x00088D65 File Offset: 0x00086F65
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

		// Token: 0x1700137E RID: 4990
		// (get) Token: 0x0600600C RID: 24588 RVA: 0x00088D88 File Offset: 0x00086F88
		// (set) Token: 0x0600600D RID: 24589 RVA: 0x00088DC1 File Offset: 0x00086FC1
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

		// Token: 0x1700137F RID: 4991
		// (get) Token: 0x0600600E RID: 24590 RVA: 0x00088DE2 File Offset: 0x00086FE2
		// (set) Token: 0x0600600F RID: 24591 RVA: 0x00088DF2 File Offset: 0x00086FF2
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

		// Token: 0x17001380 RID: 4992
		// (get) Token: 0x06006010 RID: 24592 RVA: 0x00088E04 File Offset: 0x00087004
		// (set) Token: 0x06006011 RID: 24593 RVA: 0x00088E3D File Offset: 0x0008703D
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

		// Token: 0x17001381 RID: 4993
		// (get) Token: 0x06006012 RID: 24594 RVA: 0x00088E60 File Offset: 0x00087060
		// (set) Token: 0x06006013 RID: 24595 RVA: 0x00088E99 File Offset: 0x00087099
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

		// Token: 0x17001382 RID: 4994
		// (get) Token: 0x06006014 RID: 24596 RVA: 0x00088EBA File Offset: 0x000870BA
		// (set) Token: 0x06006015 RID: 24597 RVA: 0x00088ECE File Offset: 0x000870CE
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

		// Token: 0x17001383 RID: 4995
		// (get) Token: 0x06006016 RID: 24598 RVA: 0x00088EE3 File Offset: 0x000870E3
		// (set) Token: 0x06006017 RID: 24599 RVA: 0x00088EF3 File Offset: 0x000870F3
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

		// Token: 0x17001384 RID: 4996
		// (get) Token: 0x06006018 RID: 24600 RVA: 0x00088F04 File Offset: 0x00087104
		// (set) Token: 0x06006019 RID: 24601 RVA: 0x00088F18 File Offset: 0x00087118
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

		// Token: 0x17001385 RID: 4997
		// (get) Token: 0x0600601A RID: 24602 RVA: 0x00088F30 File Offset: 0x00087130
		// (set) Token: 0x0600601B RID: 24603 RVA: 0x00088F69 File Offset: 0x00087169
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

		// Token: 0x17001386 RID: 4998
		// (get) Token: 0x0600601C RID: 24604 RVA: 0x00088F8C File Offset: 0x0008718C
		// (set) Token: 0x0600601D RID: 24605 RVA: 0x00088FC5 File Offset: 0x000871C5
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

		// Token: 0x17001387 RID: 4999
		// (get) Token: 0x0600601E RID: 24606 RVA: 0x00088FE8 File Offset: 0x000871E8
		// (set) Token: 0x0600601F RID: 24607 RVA: 0x00089021 File Offset: 0x00087221
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

		// Token: 0x17001388 RID: 5000
		// (get) Token: 0x06006020 RID: 24608 RVA: 0x00089042 File Offset: 0x00087242
		// (set) Token: 0x06006021 RID: 24609 RVA: 0x00089052 File Offset: 0x00087252
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

		// Token: 0x17001389 RID: 5001
		// (get) Token: 0x06006022 RID: 24610 RVA: 0x00089063 File Offset: 0x00087263
		// (set) Token: 0x06006023 RID: 24611 RVA: 0x00089073 File Offset: 0x00087273
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

		// Token: 0x1700138A RID: 5002
		// (get) Token: 0x06006024 RID: 24612 RVA: 0x00089084 File Offset: 0x00087284
		// (set) Token: 0x06006025 RID: 24613 RVA: 0x000890BD File Offset: 0x000872BD
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

		// Token: 0x1700138B RID: 5003
		// (get) Token: 0x06006026 RID: 24614 RVA: 0x000890E0 File Offset: 0x000872E0
		// (set) Token: 0x06006027 RID: 24615 RVA: 0x00089119 File Offset: 0x00087319
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

		// Token: 0x06006028 RID: 24616 RVA: 0x0008913A File Offset: 0x0008733A
		static UEffectModelPostProcess()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplay.EffectModelPostProcess");
		}

		// Token: 0x06006029 RID: 24617 RVA: 0x00089148 File Offset: 0x00087348
		protected UEffectModelPostProcess(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040027CB RID: 10187
		public new const string __ObjectPath = "/Script/KuroGameplay.EffectModelPostProcess";

		// Token: 0x040027CC RID: 10188
		private static IntPtr _ClassPtr;

		// Token: 0x040027CD RID: 10189
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040027CE RID: 10190
		internal static int __PropertyOffset_Location;

		// Token: 0x040027CF RID: 10191
		[Nullable(2)]
		private FKuroCurveVector _Location;

		// Token: 0x040027D0 RID: 10192
		internal static int __PropertyOffset_EnableVolume;

		// Token: 0x040027D1 RID: 10193
		internal static int __PropertyOffset_VolumeRadius;

		// Token: 0x040027D2 RID: 10194
		internal static int __PropertyOffset_VolumeHardness;

		// Token: 0x040027D3 RID: 10195
		internal static int __PropertyOffset_UseVolumeHardnessCurve;

		// Token: 0x040027D4 RID: 10196
		internal static int __PropertyOffset_VolumeHardnessCurve;

		// Token: 0x040027D5 RID: 10197
		[Nullable(2)]
		private FKuroCurveFloat _VolumeHardnessCurve;

		// Token: 0x040027D6 RID: 10198
		internal static int __PropertyOffset_WeatherPriority;

		// Token: 0x040027D7 RID: 10199
		internal static int __PropertyOffset_VisibleForProtoPlayer;

		// Token: 0x040027D8 RID: 10200
		internal static int __PropertyOffset_OverrideTOD;

		// Token: 0x040027D9 RID: 10201
		internal static int __PropertyOffset_StopWhenActorHidden;

		// Token: 0x040027DA RID: 10202
		internal static int __PropertyOffset_bEnablePostprocessMaterial;

		// Token: 0x040027DB RID: 10203
		internal static int __PropertyOffset_PostprocessMaterial;

		// Token: 0x040027DC RID: 10204
		internal static int __PropertyOffset_PostprocessMaterialQualityArray;

		// Token: 0x040027DD RID: 10205
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInterface> _PostprocessMaterialQualityArray;

		// Token: 0x040027DE RID: 10206
		internal static int __PropertyOffset_PostprocessMaterialQualityArrayMobile;

		// Token: 0x040027DF RID: 10207
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInterface> _PostprocessMaterialQualityArrayMobile;

		// Token: 0x040027E0 RID: 10208
		internal static int __PropertyOffset_PostprocessMaterialFloatParameters;

		// Token: 0x040027E1 RID: 10209
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, FKuroCurveFloat> _PostprocessMaterialFloatParameters;

		// Token: 0x040027E2 RID: 10210
		internal static int __PropertyOffset_PostprocessMaterialColorParameters;

		// Token: 0x040027E3 RID: 10211
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, FKuroCurveLinearColor> _PostprocessMaterialColorParameters;

		// Token: 0x040027E4 RID: 10212
		internal static int __PropertyOffset_BlurIntensityOverride;

		// Token: 0x040027E5 RID: 10213
		internal static int __PropertyOffset_BlurIntensity;

		// Token: 0x040027E6 RID: 10214
		[Nullable(2)]
		private FKuroCurveFloat _BlurIntensity;

		// Token: 0x040027E7 RID: 10215
		internal static int __PropertyOffset_UseWorldPosition;

		// Token: 0x040027E8 RID: 10216
		internal static int __PropertyOffset_ScreenPosition;

		// Token: 0x040027E9 RID: 10217
		internal static int __PropertyOffset_RadialBlurRadius;

		// Token: 0x040027EA RID: 10218
		[Nullable(2)]
		private FKuroCurveFloat _RadialBlurRadius;

		// Token: 0x040027EB RID: 10219
		internal static int __PropertyOffset_RadialBlurHardness;

		// Token: 0x040027EC RID: 10220
		[Nullable(2)]
		private FKuroCurveFloat _RadialBlurHardness;

		// Token: 0x040027ED RID: 10221
		internal static int __PropertyOffset_RadialBlurMask;

		// Token: 0x040027EE RID: 10222
		internal static int __PropertyOffset_RadialBlurMaskScale;

		// Token: 0x040027EF RID: 10223
		internal static int __PropertyOffset_RadialBlurMaskScaleOffset;

		// Token: 0x040027F0 RID: 10224
		[Nullable(2)]
		private FKuroCurveLinearColor _RadialBlurMaskScaleOffset;

		// Token: 0x040027F1 RID: 10225
		internal static int __PropertyOffset_MainLightIntensityOverride;

		// Token: 0x040027F2 RID: 10226
		internal static int __PropertyOffset_MainLightIntensity;

		// Token: 0x040027F3 RID: 10227
		[Nullable(2)]
		private FKuroCurveFloat _MainLightIntensity;

		// Token: 0x040027F4 RID: 10228
		internal static int __PropertyOffset_MainLightColorOverride;

		// Token: 0x040027F5 RID: 10229
		internal static int __PropertyOffset_MainLightColor;

		// Token: 0x040027F6 RID: 10230
		[Nullable(2)]
		private FKuroCurveLinearColor _MainLightColor;

		// Token: 0x040027F7 RID: 10231
		internal static int __PropertyOffset_SkyLightIntensityOverride;

		// Token: 0x040027F8 RID: 10232
		internal static int __PropertyOffset_SkyLightIntensity;

		// Token: 0x040027F9 RID: 10233
		[Nullable(2)]
		private FKuroCurveFloat _SkyLightIntensity;

		// Token: 0x040027FA RID: 10234
		internal static int __PropertyOffset_SkyLightColorOverride;

		// Token: 0x040027FB RID: 10235
		internal static int __PropertyOffset_SkyLightColor;

		// Token: 0x040027FC RID: 10236
		[Nullable(2)]
		private FKuroCurveLinearColor _SkyLightColor;

		// Token: 0x040027FD RID: 10237
		internal static int __PropertyOffset_EnableEffectFog;

		// Token: 0x040027FE RID: 10238
		internal static int __PropertyOffset_EffectFogSwitch;

		// Token: 0x040027FF RID: 10239
		[Nullable(2)]
		private FKuroCurveFloat _EffectFogSwitch;

		// Token: 0x04002800 RID: 10240
		internal static int __PropertyOffset_KuroEffectFogBlendSceneFogMin;

		// Token: 0x04002801 RID: 10241
		[Nullable(2)]
		private FKuroCurveFloat _KuroEffectFogBlendSceneFogMin;

		// Token: 0x04002802 RID: 10242
		internal static int __PropertyOffset_FogDensityOverride;

		// Token: 0x04002803 RID: 10243
		internal static int __PropertyOffset_FogDensity;

		// Token: 0x04002804 RID: 10244
		[Nullable(2)]
		private FKuroCurveFloat _FogDensity;

		// Token: 0x04002805 RID: 10245
		internal static int __PropertyOffset_FogStartDistance;

		// Token: 0x04002806 RID: 10246
		[Nullable(2)]
		private FKuroCurveFloat _FogStartDistance;

		// Token: 0x04002807 RID: 10247
		internal static int __PropertyOffset_FogFalloff;

		// Token: 0x04002808 RID: 10248
		internal static int __PropertyOffset_FogMaxOpacity;

		// Token: 0x04002809 RID: 10249
		[Nullable(2)]
		private FKuroCurveFloat _FogMaxOpacity;

		// Token: 0x0400280A RID: 10250
		internal static int __PropertyOffset_FogColorOverride;

		// Token: 0x0400280B RID: 10251
		internal static int __PropertyOffset_FogNearColor;

		// Token: 0x0400280C RID: 10252
		[Nullable(2)]
		private FKuroCurveLinearColor _FogNearColor;

		// Token: 0x0400280D RID: 10253
		internal static int __PropertyOffset_FogFarColor;

		// Token: 0x0400280E RID: 10254
		[Nullable(2)]
		private FKuroCurveLinearColor _FogFarColor;

		// Token: 0x0400280F RID: 10255
		internal static int __PropertyOffset_FogNearColorDistance;

		// Token: 0x04002810 RID: 10256
		[Nullable(2)]
		private FKuroCurveFloat _FogNearColorDistance;

		// Token: 0x04002811 RID: 10257
		internal static int __PropertyOffset_FogFarColorDistance;

		// Token: 0x04002812 RID: 10258
		[Nullable(2)]
		private FKuroCurveFloat _FogFarColorDistance;

		// Token: 0x04002813 RID: 10259
		internal static int __PropertyOffset_FogColorRatio;

		// Token: 0x04002814 RID: 10260
		internal static int __PropertyOffset_FogDistanceViewOverride;

		// Token: 0x04002815 RID: 10261
		internal static int __PropertyOffset_FogFalloffFarSky;

		// Token: 0x04002816 RID: 10262
		internal static int __PropertyOffset_FogMixDistance;

		// Token: 0x04002817 RID: 10263
		internal static int __PropertyOffset_FogMixWidth;

		// Token: 0x04002818 RID: 10264
		internal static int __PropertyOffset_KuroBloomIntensityOverride;

		// Token: 0x04002819 RID: 10265
		internal static int __PropertyOffset_KuroBloomIntensity;

		// Token: 0x0400281A RID: 10266
		[Nullable(2)]
		private FKuroCurveFloat _KuroBloomIntensity;

		// Token: 0x0400281B RID: 10267
		internal static int __PropertyOffset_KuroThresholdOverride;

		// Token: 0x0400281C RID: 10268
		internal static int __PropertyOffset_KuroThreshold;

		// Token: 0x0400281D RID: 10269
		[Nullable(2)]
		private FKuroCurveFloat _KuroThreshold;

		// Token: 0x0400281E RID: 10270
		internal static int __PropertyOffset_SceneFringeIntensityOverride;

		// Token: 0x0400281F RID: 10271
		internal static int __PropertyOffset_SceneFringeIntensity;

		// Token: 0x04002820 RID: 10272
		[Nullable(2)]
		private FKuroCurveFloat _SceneFringeIntensity;

		// Token: 0x04002821 RID: 10273
		internal static int __PropertyOffset_StartOffsetOverride;

		// Token: 0x04002822 RID: 10274
		internal static int __PropertyOffset_StartOffset;

		// Token: 0x04002823 RID: 10275
		[Nullable(2)]
		private FKuroCurveFloat _StartOffset;

		// Token: 0x04002824 RID: 10276
		internal static int __PropertyOffset_VignetteIntensityOverride;

		// Token: 0x04002825 RID: 10277
		internal static int __PropertyOffset_VignetteIntensity;

		// Token: 0x04002826 RID: 10278
		[Nullable(2)]
		private FKuroCurveFloat _VignetteIntensity;

		// Token: 0x04002827 RID: 10279
		internal static int __PropertyOffset_VignetteHardness;

		// Token: 0x04002828 RID: 10280
		[Nullable(2)]
		private FKuroCurveFloat _VignetteHardness;

		// Token: 0x04002829 RID: 10281
		internal static int __PropertyOffset_VignetteXScale;

		// Token: 0x0400282A RID: 10282
		[Nullable(2)]
		private FKuroCurveFloat _VignetteXScale;

		// Token: 0x0400282B RID: 10283
		internal static int __PropertyOffset_VignetteYScale;

		// Token: 0x0400282C RID: 10284
		[Nullable(2)]
		private FKuroCurveFloat _VignetteYScale;

		// Token: 0x0400282D RID: 10285
		internal static int __PropertyOffset_VignetteXPos;

		// Token: 0x0400282E RID: 10286
		[Nullable(2)]
		private FKuroCurveFloat _VignetteXPos;

		// Token: 0x0400282F RID: 10287
		internal static int __PropertyOffset_VignetteYPos;

		// Token: 0x04002830 RID: 10288
		[Nullable(2)]
		private FKuroCurveFloat _VignetteYPos;

		// Token: 0x04002831 RID: 10289
		internal static int __PropertyOffset_VignetteColor;

		// Token: 0x04002832 RID: 10290
		[Nullable(2)]
		private FKuroCurveLinearColor _VignetteColor;

		// Token: 0x04002833 RID: 10291
		internal static int __PropertyOffset_VignetteGain;

		// Token: 0x04002834 RID: 10292
		[Nullable(2)]
		private FKuroCurveFloat _VignetteGain;

		// Token: 0x04002835 RID: 10293
		internal static int __PropertyOffset_GrainJitterOverride;

		// Token: 0x04002836 RID: 10294
		internal static int __PropertyOffset_GrainJitter;

		// Token: 0x04002837 RID: 10295
		[Nullable(2)]
		private FKuroCurveFloat _GrainJitter;

		// Token: 0x04002838 RID: 10296
		internal static int __PropertyOffset_GrainIntensityOverride;

		// Token: 0x04002839 RID: 10297
		internal static int __PropertyOffset_GrainIntensity;

		// Token: 0x0400283A RID: 10298
		[Nullable(2)]
		private FKuroCurveFloat _GrainIntensity;

		// Token: 0x0400283B RID: 10299
		internal static int __PropertyOffset_LutIntensityOverride;

		// Token: 0x0400283C RID: 10300
		internal static int __PropertyOffset_LutIntensity;

		// Token: 0x0400283D RID: 10301
		[Nullable(2)]
		private FKuroCurveFloat _LutIntensity;

		// Token: 0x0400283E RID: 10302
		internal static int __PropertyOffset_LutTextureOverride;

		// Token: 0x0400283F RID: 10303
		internal static int __PropertyOffset_LutTexture;

		// Token: 0x04002840 RID: 10304
		internal static int __PropertyOffset_SceneColorTintOverride;

		// Token: 0x04002841 RID: 10305
		internal static int __PropertyOffset_SceneColorTint;

		// Token: 0x04002842 RID: 10306
		[Nullable(2)]
		private FKuroCurveLinearColor _SceneColorTint;

		// Token: 0x04002843 RID: 10307
		internal static int __PropertyOffset_SceneColorDesaturateOverride;

		// Token: 0x04002844 RID: 10308
		internal static int __PropertyOffset_SceneColorDesaturate;

		// Token: 0x04002845 RID: 10309
		[Nullable(2)]
		private FKuroCurveFloat _SceneColorDesaturate;

		// Token: 0x04002846 RID: 10310
		internal static int __PropertyOffset_TranslucentColorTintOverride;

		// Token: 0x04002847 RID: 10311
		internal static int __PropertyOffset_TranslucentColorTint;

		// Token: 0x04002848 RID: 10312
		[Nullable(2)]
		private FKuroCurveLinearColor _TranslucentColorTint;

		// Token: 0x04002849 RID: 10313
		internal static int __PropertyOffset_TranslucentColorDesaturateOverride;

		// Token: 0x0400284A RID: 10314
		internal static int __PropertyOffset_TranslucentColorDesaturate;

		// Token: 0x0400284B RID: 10315
		[Nullable(2)]
		private FKuroCurveFloat _TranslucentColorDesaturate;

		// Token: 0x0400284C RID: 10316
		internal static int __PropertyOffset_FightTranslucentNoDesaturateOverride;

		// Token: 0x0400284D RID: 10317
		internal static int __PropertyOffset_FightTranslucentNoDesaturate;

		// Token: 0x0400284E RID: 10318
		internal static int __PropertyOffset_BlackWhiteFlashIntensityOverride;

		// Token: 0x0400284F RID: 10319
		internal static int __PropertyOffset_BlackWhiteFlashIntensity;

		// Token: 0x04002850 RID: 10320
		[Nullable(2)]
		private FKuroCurveFloat _BlackWhiteFlashIntensity;

		// Token: 0x04002851 RID: 10321
		internal static int __PropertyOffset_BlackWhiteFlashFactorOverride;

		// Token: 0x04002852 RID: 10322
		internal static int __PropertyOffset_BlackWhiteFlashFactor;

		// Token: 0x04002853 RID: 10323
		[Nullable(2)]
		private FKuroCurveFloat _BlackWhiteFlashFactor;

		// Token: 0x04002854 RID: 10324
		internal static int __PropertyOffset_BlackWhiteFlashThresholdOverride;

		// Token: 0x04002855 RID: 10325
		internal static int __PropertyOffset_BlackWhiteFlashThreshold;

		// Token: 0x04002856 RID: 10326
		[Nullable(2)]
		private FKuroCurveFloat _BlackWhiteFlashThreshold;

		// Token: 0x04002857 RID: 10327
		internal static int __PropertyOffset_BlackWhiteFlashBlackAreaColorOverride;

		// Token: 0x04002858 RID: 10328
		internal static int __PropertyOffset_BlackWhiteFlashBlackAreaColor;

		// Token: 0x04002859 RID: 10329
		[Nullable(2)]
		private FKuroCurveLinearColor _BlackWhiteFlashBlackAreaColor;

		// Token: 0x0400285A RID: 10330
		internal static int __PropertyOffset_BlackWhiteFlashWhiteAreaColorOverride;

		// Token: 0x0400285B RID: 10331
		internal static int __PropertyOffset_BlackWhiteFlashWhiteAreaColor;

		// Token: 0x0400285C RID: 10332
		[Nullable(2)]
		private FKuroCurveLinearColor _BlackWhiteFlashWhiteAreaColor;

		// Token: 0x0400285D RID: 10333
		internal static int __PropertyOffset_GrayGradationOverride;

		// Token: 0x0400285E RID: 10334
		internal static int __PropertyOffset_GrayGradationCullTranslucency;

		// Token: 0x0400285F RID: 10335
		internal static int __PropertyOffset_GrayGradationUsePlayerLocation;

		// Token: 0x04002860 RID: 10336
		internal static int __PropertyOffset_GrayGradationDegree;

		// Token: 0x04002861 RID: 10337
		[Nullable(2)]
		private FKuroCurveFloat _GrayGradationDegree;

		// Token: 0x04002862 RID: 10338
		internal static int __PropertyOffset_GrayGradationLerpWidth;

		// Token: 0x04002863 RID: 10339
		[Nullable(2)]
		private FKuroCurveFloat _GrayGradationLerpWidth;

		// Token: 0x04002864 RID: 10340
		internal static int __PropertyOffset_GrayGradationRampTexture;

		// Token: 0x04002865 RID: 10341
		internal static int __PropertyOffset_GrayGradationColorTint;

		// Token: 0x04002866 RID: 10342
		[Nullable(2)]
		private FKuroCurveLinearColor _GrayGradationColorTint;

		// Token: 0x04002867 RID: 10343
		internal static int __PropertyOffset_GrayGradationBlendWeight;

		// Token: 0x04002868 RID: 10344
		[Nullable(2)]
		private FKuroCurveFloat _GrayGradationBlendWeight;

		// Token: 0x04002869 RID: 10345
		internal static int __PropertyOffset_RetroFuturisticOverride;

		// Token: 0x0400286A RID: 10346
		internal static int __PropertyOffset_MainCenterMask;

		// Token: 0x0400286B RID: 10347
		[Nullable(2)]
		private FKuroCurveFloat _MainCenterMask;

		// Token: 0x0400286C RID: 10348
		internal static int __PropertyOffset_MainCenterMaskRadius;

		// Token: 0x0400286D RID: 10349
		[Nullable(2)]
		private FKuroCurveFloat _MainCenterMaskRadius;

		// Token: 0x0400286E RID: 10350
		internal static int __PropertyOffset_MainCenterMaskHardness;

		// Token: 0x0400286F RID: 10351
		[Nullable(2)]
		private FKuroCurveFloat _MainCenterMaskHardness;

		// Token: 0x04002870 RID: 10352
		internal static int __PropertyOffset_MainStartDistance;

		// Token: 0x04002871 RID: 10353
		[Nullable(2)]
		private FKuroCurveFloat _MainStartDistance;

		// Token: 0x04002872 RID: 10354
		internal static int __PropertyOffset_MainCharacterIntensity;

		// Token: 0x04002873 RID: 10355
		[Nullable(2)]
		private FKuroCurveFloat _MainCharacterIntensity;

		// Token: 0x04002874 RID: 10356
		internal static int __PropertyOffset_VintageColorIntensity;

		// Token: 0x04002875 RID: 10357
		[Nullable(2)]
		private FKuroCurveFloat _VintageColorIntensity;

		// Token: 0x04002876 RID: 10358
		internal static int __PropertyOffset_VintageColorBlackPoint;

		// Token: 0x04002877 RID: 10359
		[Nullable(2)]
		private FKuroCurveFloat _VintageColorBlackPoint;

		// Token: 0x04002878 RID: 10360
		internal static int __PropertyOffset_VintageColorWhitePoint;

		// Token: 0x04002879 RID: 10361
		[Nullable(2)]
		private FKuroCurveFloat _VintageColorWhitePoint;

		// Token: 0x0400287A RID: 10362
		internal static int __PropertyOffset_VHSLinesColorIntensity;

		// Token: 0x0400287B RID: 10363
		[Nullable(2)]
		private FKuroCurveFloat _VHSLinesColorIntensity;

		// Token: 0x0400287C RID: 10364
		internal static int __PropertyOffset_VHSLinesDistortIntensity;

		// Token: 0x0400287D RID: 10365
		[Nullable(2)]
		private FKuroCurveFloat _VHSLinesDistortIntensity;

		// Token: 0x0400287E RID: 10366
		internal static int __PropertyOffset_VHSEffectIntensity;

		// Token: 0x0400287F RID: 10367
		[Nullable(2)]
		private FKuroCurveFloat _VHSEffectIntensity;

		// Token: 0x04002880 RID: 10368
		internal static int __PropertyOffset_VHSSpecklesIntensity;

		// Token: 0x04002881 RID: 10369
		[Nullable(2)]
		private FKuroCurveFloat _VHSSpecklesIntensity;

		// Token: 0x04002882 RID: 10370
		internal static int __PropertyOffset_VHSSpecklesAmount;

		// Token: 0x04002883 RID: 10371
		[Nullable(2)]
		private FKuroCurveFloat _VHSSpecklesAmount;

		// Token: 0x04002884 RID: 10372
		internal static int __PropertyOffset_VHSSpecklesSize;

		// Token: 0x04002885 RID: 10373
		[Nullable(2)]
		private FKuroCurveFloat _VHSSpecklesSize;

		// Token: 0x04002886 RID: 10374
		internal static int __PropertyOffset_CRTDistortion;

		// Token: 0x04002887 RID: 10375
		[Nullable(2)]
		private FKuroCurveFloat _CRTDistortion;

		// Token: 0x04002888 RID: 10376
		internal static int __PropertyOffset_RetroFuturisticAdvancedOverride;

		// Token: 0x04002889 RID: 10377
		internal static int __PropertyOffset_VintageColorCenterMask;

		// Token: 0x0400288A RID: 10378
		[Nullable(2)]
		private FKuroCurveFloat _VintageColorCenterMask;

		// Token: 0x0400288B RID: 10379
		internal static int __PropertyOffset_VintageColorStartDistance;

		// Token: 0x0400288C RID: 10380
		[Nullable(2)]
		private FKuroCurveFloat _VintageColorStartDistance;

		// Token: 0x0400288D RID: 10381
		internal static int __PropertyOffset_VintageColorCharacterIntensity;

		// Token: 0x0400288E RID: 10382
		[Nullable(2)]
		private FKuroCurveFloat _VintageColorCharacterIntensity;

		// Token: 0x0400288F RID: 10383
		internal static int __PropertyOffset_VHSLinesCenterMask;

		// Token: 0x04002890 RID: 10384
		[Nullable(2)]
		private FKuroCurveFloat _VHSLinesCenterMask;

		// Token: 0x04002891 RID: 10385
		internal static int __PropertyOffset_VHSLinesStartDistance;

		// Token: 0x04002892 RID: 10386
		[Nullable(2)]
		private FKuroCurveFloat _VHSLinesStartDistance;

		// Token: 0x04002893 RID: 10387
		internal static int __PropertyOffset_VHSLinesCharacterIntensity;

		// Token: 0x04002894 RID: 10388
		[Nullable(2)]
		private FKuroCurveFloat _VHSLinesCharacterIntensity;

		// Token: 0x04002895 RID: 10389
		internal static int __PropertyOffset_VHSEffectCenterMask;

		// Token: 0x04002896 RID: 10390
		[Nullable(2)]
		private FKuroCurveFloat _VHSEffectCenterMask;

		// Token: 0x04002897 RID: 10391
		internal static int __PropertyOffset_VHSEffectStartDistance;

		// Token: 0x04002898 RID: 10392
		[Nullable(2)]
		private FKuroCurveFloat _VHSEffectStartDistance;

		// Token: 0x04002899 RID: 10393
		internal static int __PropertyOffset_VHSEffectCharacterIntensity;

		// Token: 0x0400289A RID: 10394
		[Nullable(2)]
		private FKuroCurveFloat _VHSEffectCharacterIntensity;

		// Token: 0x0400289B RID: 10395
		internal static int __PropertyOffset_VHSSpecklesCenterMask;

		// Token: 0x0400289C RID: 10396
		[Nullable(2)]
		private FKuroCurveFloat _VHSSpecklesCenterMask;

		// Token: 0x0400289D RID: 10397
		internal static int __PropertyOffset_VHSSpecklesStartDistance;

		// Token: 0x0400289E RID: 10398
		[Nullable(2)]
		private FKuroCurveFloat _VHSSpecklesStartDistance;

		// Token: 0x0400289F RID: 10399
		internal static int __PropertyOffset_VHSSpecklesCharacterIntensity;

		// Token: 0x040028A0 RID: 10400
		[Nullable(2)]
		private FKuroCurveFloat _VHSSpecklesCharacterIntensity;

		// Token: 0x040028A1 RID: 10401
		internal static int __PropertyOffset_ScreenWaveOverride;

		// Token: 0x040028A2 RID: 10402
		internal static int __PropertyOffset_UsePolarWavePattern;

		// Token: 0x040028A3 RID: 10403
		internal static int __PropertyOffset_WavePatternTexture;

		// Token: 0x040028A4 RID: 10404
		internal static int __PropertyOffset_WavePatternScaleBias;

		// Token: 0x040028A5 RID: 10405
		[Nullable(2)]
		private FKuroCurveLinearColor _WavePatternScaleBias;

		// Token: 0x040028A6 RID: 10406
		internal static int __PropertyOffset_WaveRadius;

		// Token: 0x040028A7 RID: 10407
		[Nullable(2)]
		private FKuroCurveFloat _WaveRadius;

		// Token: 0x040028A8 RID: 10408
		internal static int __PropertyOffset_WaveRadiusSmooth;

		// Token: 0x040028A9 RID: 10409
		[Nullable(2)]
		private FKuroCurveFloat _WaveRadiusSmooth;

		// Token: 0x040028AA RID: 10410
		internal static int __PropertyOffset_WaveHeight;

		// Token: 0x040028AB RID: 10411
		[Nullable(2)]
		private FKuroCurveFloat _WaveHeight;

		// Token: 0x040028AC RID: 10412
		internal static int __PropertyOffset_WaveHeightSmooth;

		// Token: 0x040028AD RID: 10413
		[Nullable(2)]
		private FKuroCurveFloat _WaveHeightSmooth;

		// Token: 0x040028AE RID: 10414
		internal static int __PropertyOffset_WaveNormalSize;

		// Token: 0x040028AF RID: 10415
		[Nullable(2)]
		private FKuroCurveFloat _WaveNormalSize;

		// Token: 0x040028B0 RID: 10416
		internal static int __PropertyOffset_WaveRoughness;

		// Token: 0x040028B1 RID: 10417
		[Nullable(2)]
		private FKuroCurveFloat _WaveRoughness;

		// Token: 0x040028B2 RID: 10418
		internal static int __PropertyOffset_WaveDissolveTexture;

		// Token: 0x040028B3 RID: 10419
		internal static int __PropertyOffset_WaveDissolveScaleBias;

		// Token: 0x040028B4 RID: 10420
		[Nullable(2)]
		private FKuroCurveLinearColor _WaveDissolveScaleBias;

		// Token: 0x040028B5 RID: 10421
		internal static int __PropertyOffset_WaveDissolveProgress;

		// Token: 0x040028B6 RID: 10422
		[Nullable(2)]
		private FKuroCurveFloat _WaveDissolveProgress;

		// Token: 0x040028B7 RID: 10423
		internal static int __PropertyOffset_WaveDissolveSmooth;

		// Token: 0x040028B8 RID: 10424
		[Nullable(2)]
		private FKuroCurveFloat _WaveDissolveSmooth;

		// Token: 0x040028B9 RID: 10425
		internal static int __PropertyOffset_WaveColorTexture;

		// Token: 0x040028BA RID: 10426
		internal static int __PropertyOffset_WaveColorScaleBias;

		// Token: 0x040028BB RID: 10427
		[Nullable(2)]
		private FKuroCurveLinearColor _WaveColorScaleBias;

		// Token: 0x040028BC RID: 10428
		internal static int __PropertyOffset_WaveColorTextureTint;

		// Token: 0x040028BD RID: 10429
		[Nullable(2)]
		private FKuroCurveLinearColor _WaveColorTextureTint;

		// Token: 0x040028BE RID: 10430
		internal static int __PropertyOffset_WaveAmplitude;

		// Token: 0x040028BF RID: 10431
		[Nullable(2)]
		private FKuroCurveFloat _WaveAmplitude;

		// Token: 0x040028C0 RID: 10432
		internal static int __PropertyOffset_AutoExposureOverride;

		// Token: 0x040028C1 RID: 10433
		internal static int __PropertyOffset_AutoExposureMinBrightness;

		// Token: 0x040028C2 RID: 10434
		[Nullable(2)]
		private FKuroCurveFloat _AutoExposureMinBrightness;

		// Token: 0x040028C3 RID: 10435
		internal static int __PropertyOffset_AutoExposureMaxBrightness;

		// Token: 0x040028C4 RID: 10436
		[Nullable(2)]
		private FKuroCurveFloat _AutoExposureMaxBrightness;

		// Token: 0x040028C5 RID: 10437
		internal static int __PropertyOffset_WeatherDataAsset;

		// Token: 0x040028C6 RID: 10438
		internal static int __PropertyOffset_BurstDissolveOverride;

		// Token: 0x040028C7 RID: 10439
		internal static int __PropertyOffset_BurstDissolveTexture;

		// Token: 0x040028C8 RID: 10440
		internal static int __PropertyOffset_BurstDissolveThreshold;

		// Token: 0x040028C9 RID: 10441
		[Nullable(2)]
		private FKuroCurveFloat _BurstDissolveThreshold;

		// Token: 0x040028CA RID: 10442
		internal static int __PropertyOffset_BurstDissolveSmooth;

		// Token: 0x040028CB RID: 10443
		[Nullable(2)]
		private FKuroCurveFloat _BurstDissolveSmooth;

		// Token: 0x040028CC RID: 10444
		internal static int __PropertyOffset_BurstClipThreshold;

		// Token: 0x040028CD RID: 10445
		[Nullable(2)]
		private FKuroCurveFloat _BurstClipThreshold;

		// Token: 0x040028CE RID: 10446
		internal static int __PropertyOffset_SkyBoxOverride;

		// Token: 0x040028CF RID: 10447
		internal static int __PropertyOffset_ColorGradingOverride;

		// Token: 0x040028D0 RID: 10448
		internal static int __PropertyOffset_Desaturate;

		// Token: 0x040028D1 RID: 10449
		[Nullable(2)]
		private FKuroCurveFloat _Desaturate;

		// Token: 0x040028D2 RID: 10450
		internal static int __PropertyOffset_Tint;

		// Token: 0x040028D3 RID: 10451
		[Nullable(2)]
		private FKuroCurveLinearColor _Tint;
	}
}
