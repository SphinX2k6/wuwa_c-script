using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001C21 RID: 7201
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.PointLightData")]
	[UnrealStructLayout(464, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 464)]
	public class FPointLightData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601BCA3 RID: 113827 RVA: 0x0028E82C File Offset: 0x0028CA2C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPointLightData._ScriptStructPtr != 0) ? FPointLightData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.PointLightData", ref FPointLightData._ScriptStructPtr);
		}

		// Token: 0x17007008 RID: 28680
		// (get) Token: 0x0601BCA4 RID: 113828 RVA: 0x0028E850 File Offset: 0x0028CA50
		// (set) Token: 0x0601BCA5 RID: 113829 RVA: 0x0028E864 File Offset: 0x0028CA64
		public unsafe UKuroFlickerLightPreset Preset
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroFlickerLightPreset>(base.NativePtr / (IntPtr)sizeof(void*) + FPointLightData.__PropertyOffset_Preset);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FPointLightData.__PropertyOffset_Preset, value);
			}
		}

		// Token: 0x17007009 RID: 28681
		// (get) Token: 0x0601BCA6 RID: 113830 RVA: 0x0028E879 File Offset: 0x0028CA79
		// (set) Token: 0x0601BCA7 RID: 113831 RVA: 0x0028E88D File Offset: 0x0028CA8D
		public unsafe UKuroMoveMusicLightPreset MovePreset
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroMoveMusicLightPreset>(base.NativePtr / (IntPtr)sizeof(void*) + FPointLightData.__PropertyOffset_MovePreset);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FPointLightData.__PropertyOffset_MovePreset, value);
			}
		}

		// Token: 0x1700700A RID: 28682
		// (get) Token: 0x0601BCA8 RID: 113832 RVA: 0x0028E8A2 File Offset: 0x0028CAA2
		// (set) Token: 0x0601BCA9 RID: 113833 RVA: 0x0028E8B2 File Offset: 0x0028CAB2
		public unsafe float KuroMoveLightAttenuationRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPointLightData.__PropertyOffset_KuroMoveLightAttenuationRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPointLightData.__PropertyOffset_KuroMoveLightAttenuationRadius) = value;
			}
		}

		// Token: 0x1700700B RID: 28683
		// (get) Token: 0x0601BCAA RID: 113834 RVA: 0x0028E8C3 File Offset: 0x0028CAC3
		// (set) Token: 0x0601BCAB RID: 113835 RVA: 0x0028E8D3 File Offset: 0x0028CAD3
		public unsafe float KuroMoveLightAttenuation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPointLightData.__PropertyOffset_KuroMoveLightAttenuation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPointLightData.__PropertyOffset_KuroMoveLightAttenuation) = value;
			}
		}

		// Token: 0x1700700C RID: 28684
		// (get) Token: 0x0601BCAC RID: 113836 RVA: 0x0028E8E4 File Offset: 0x0028CAE4
		// (set) Token: 0x0601BCAD RID: 113837 RVA: 0x0028E8F4 File Offset: 0x0028CAF4
		public unsafe float SourceRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPointLightData.__PropertyOffset_SourceRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPointLightData.__PropertyOffset_SourceRadius) = value;
			}
		}

		// Token: 0x1700700D RID: 28685
		// (get) Token: 0x0601BCAE RID: 113838 RVA: 0x0028E905 File Offset: 0x0028CB05
		// (set) Token: 0x0601BCAF RID: 113839 RVA: 0x0028E915 File Offset: 0x0028CB15
		public unsafe float SoftSourceRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPointLightData.__PropertyOffset_SoftSourceRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPointLightData.__PropertyOffset_SoftSourceRadius) = value;
			}
		}

		// Token: 0x1700700E RID: 28686
		// (get) Token: 0x0601BCB0 RID: 113840 RVA: 0x0028E926 File Offset: 0x0028CB26
		// (set) Token: 0x0601BCB1 RID: 113841 RVA: 0x0028E936 File Offset: 0x0028CB36
		public unsafe float SourceLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPointLightData.__PropertyOffset_SourceLength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPointLightData.__PropertyOffset_SourceLength) = value;
			}
		}

		// Token: 0x1700700F RID: 28687
		// (get) Token: 0x0601BCB2 RID: 113842 RVA: 0x0028E947 File Offset: 0x0028CB47
		// (set) Token: 0x0601BCB3 RID: 113843 RVA: 0x0028E957 File Offset: 0x0028CB57
		public unsafe float SpecularScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPointLightData.__PropertyOffset_SpecularScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPointLightData.__PropertyOffset_SpecularScale) = value;
			}
		}

		// Token: 0x17007010 RID: 28688
		// (get) Token: 0x0601BCB4 RID: 113844 RVA: 0x0028E968 File Offset: 0x0028CB68
		// (set) Token: 0x0601BCB5 RID: 113845 RVA: 0x0028E9AB File Offset: 0x0028CBAB
		[Nullable(1)]
		public FKuroCurveFloat PointCurve
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._PointCurve) == null)
				{
					result = (this._PointCurve = new FKuroCurveFloat(base.NativePtr + (IntPtr)FPointLightData.__PropertyOffset_PointCurve, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)FPointLightData.__PropertyOffset_PointCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007011 RID: 28689
		// (get) Token: 0x0601BCB6 RID: 113846 RVA: 0x0028E9CC File Offset: 0x0028CBCC
		// (set) Token: 0x0601BCB7 RID: 113847 RVA: 0x0028E9DC File Offset: 0x0028CBDC
		public unsafe float MoveSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPointLightData.__PropertyOffset_MoveSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPointLightData.__PropertyOffset_MoveSpeed) = value;
			}
		}

		// Token: 0x17007012 RID: 28690
		// (get) Token: 0x0601BCB8 RID: 113848 RVA: 0x0028E9ED File Offset: 0x0028CBED
		// (set) Token: 0x0601BCB9 RID: 113849 RVA: 0x0028E9FD File Offset: 0x0028CBFD
		public unsafe bool bLoopMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPointLightData.__PropertyOffset_bLoopMode) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPointLightData.__PropertyOffset_bLoopMode) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007013 RID: 28691
		// (get) Token: 0x0601BCBA RID: 113850 RVA: 0x0028EA0E File Offset: 0x0028CC0E
		// (set) Token: 0x0601BCBB RID: 113851 RVA: 0x0028EA22 File Offset: 0x0028CC22
		public unsafe FLinearColor PointStartColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPointLightData.__PropertyOffset_PointStartColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPointLightData.__PropertyOffset_PointStartColor) = value;
			}
		}

		// Token: 0x17007014 RID: 28692
		// (get) Token: 0x0601BCBC RID: 113852 RVA: 0x0028EA37 File Offset: 0x0028CC37
		// (set) Token: 0x0601BCBD RID: 113853 RVA: 0x0028EA4B File Offset: 0x0028CC4B
		public unsafe FLinearColor PointEndColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPointLightData.__PropertyOffset_PointEndColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPointLightData.__PropertyOffset_PointEndColor) = value;
			}
		}

		// Token: 0x17007015 RID: 28693
		// (get) Token: 0x0601BCBE RID: 113854 RVA: 0x0028EA60 File Offset: 0x0028CC60
		// (set) Token: 0x0601BCBF RID: 113855 RVA: 0x0028EA70 File Offset: 0x0028CC70
		public unsafe bool bUseColorCurve
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPointLightData.__PropertyOffset_bUseColorCurve) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPointLightData.__PropertyOffset_bUseColorCurve) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007016 RID: 28694
		// (get) Token: 0x0601BCC0 RID: 113856 RVA: 0x0028EA81 File Offset: 0x0028CC81
		// (set) Token: 0x0601BCC1 RID: 113857 RVA: 0x0028EA95 File Offset: 0x0028CC95
		public unsafe UCurveLinearColor ColorGradientCurve
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveLinearColor>(base.NativePtr / (IntPtr)sizeof(void*) + FPointLightData.__PropertyOffset_ColorGradientCurve);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FPointLightData.__PropertyOffset_ColorGradientCurve, value);
			}
		}

		// Token: 0x17007017 RID: 28695
		// (get) Token: 0x0601BCC2 RID: 113858 RVA: 0x0028EAAA File Offset: 0x0028CCAA
		// (set) Token: 0x0601BCC3 RID: 113859 RVA: 0x0028EABA File Offset: 0x0028CCBA
		public unsafe ESplinePlaneType SplinePlane
		{
			get
			{
				return (ESplinePlaneType)(*(base.NativePtr + (IntPtr)FPointLightData.__PropertyOffset_SplinePlane));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPointLightData.__PropertyOffset_SplinePlane) = (byte)value;
			}
		}

		// Token: 0x17007018 RID: 28696
		// (get) Token: 0x0601BCC4 RID: 113860 RVA: 0x0028EACB File Offset: 0x0028CCCB
		// (set) Token: 0x0601BCC5 RID: 113861 RVA: 0x0028EADF File Offset: 0x0028CCDF
		public unsafe FVector SplineEndPoint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPointLightData.__PropertyOffset_SplineEndPoint);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPointLightData.__PropertyOffset_SplineEndPoint) = value;
			}
		}

		// Token: 0x17007019 RID: 28697
		// (get) Token: 0x0601BCC6 RID: 113862 RVA: 0x0028EAF4 File Offset: 0x0028CCF4
		// (set) Token: 0x0601BCC7 RID: 113863 RVA: 0x0028EB04 File Offset: 0x0028CD04
		public unsafe float CurveOffsetStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPointLightData.__PropertyOffset_CurveOffsetStrength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPointLightData.__PropertyOffset_CurveOffsetStrength) = value;
			}
		}

		// Token: 0x1700701A RID: 28698
		// (get) Token: 0x0601BCC8 RID: 113864 RVA: 0x0028EB15 File Offset: 0x0028CD15
		// (set) Token: 0x0601BCC9 RID: 113865 RVA: 0x0028EB25 File Offset: 0x0028CD25
		public unsafe int SplineSampleCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPointLightData.__PropertyOffset_SplineSampleCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPointLightData.__PropertyOffset_SplineSampleCount) = value;
			}
		}

		// Token: 0x1700701B RID: 28699
		// (get) Token: 0x0601BCCA RID: 113866 RVA: 0x0028EB36 File Offset: 0x0028CD36
		// (set) Token: 0x0601BCCB RID: 113867 RVA: 0x0028EB46 File Offset: 0x0028CD46
		public unsafe float BaseIntensityScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPointLightData.__PropertyOffset_BaseIntensityScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPointLightData.__PropertyOffset_BaseIntensityScale) = value;
			}
		}

		// Token: 0x1700701C RID: 28700
		// (get) Token: 0x0601BCCC RID: 113868 RVA: 0x0028EB57 File Offset: 0x0028CD57
		// (set) Token: 0x0601BCCD RID: 113869 RVA: 0x0028EB67 File Offset: 0x0028CD67
		public unsafe float IntensityCurveScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPointLightData.__PropertyOffset_IntensityCurveScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPointLightData.__PropertyOffset_IntensityCurveScale) = value;
			}
		}

		// Token: 0x1700701D RID: 28701
		// (get) Token: 0x0601BCCE RID: 113870 RVA: 0x0028EB78 File Offset: 0x0028CD78
		// (set) Token: 0x0601BCCF RID: 113871 RVA: 0x0028EB88 File Offset: 0x0028CD88
		public unsafe float FlickSpeedScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPointLightData.__PropertyOffset_FlickSpeedScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPointLightData.__PropertyOffset_FlickSpeedScale) = value;
			}
		}

		// Token: 0x1700701E RID: 28702
		// (get) Token: 0x0601BCD0 RID: 113872 RVA: 0x0028EB99 File Offset: 0x0028CD99
		// (set) Token: 0x0601BCD1 RID: 113873 RVA: 0x0028EBA9 File Offset: 0x0028CDA9
		public unsafe float AllIntensityScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPointLightData.__PropertyOffset_AllIntensityScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPointLightData.__PropertyOffset_AllIntensityScale) = value;
			}
		}

		// Token: 0x1700701F RID: 28703
		// (get) Token: 0x0601BCD2 RID: 113874 RVA: 0x0028EBBA File Offset: 0x0028CDBA
		// (set) Token: 0x0601BCD3 RID: 113875 RVA: 0x0028EBCA File Offset: 0x0028CDCA
		public unsafe bool bApplyToonLight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPointLightData.__PropertyOffset_bApplyToonLight) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPointLightData.__PropertyOffset_bApplyToonLight) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007020 RID: 28704
		// (get) Token: 0x0601BCD4 RID: 113876 RVA: 0x0028EBDB File Offset: 0x0028CDDB
		// (set) Token: 0x0601BCD5 RID: 113877 RVA: 0x0028EBEB File Offset: 0x0028CDEB
		public unsafe float ToonLightBaseIntensityScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPointLightData.__PropertyOffset_ToonLightBaseIntensityScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPointLightData.__PropertyOffset_ToonLightBaseIntensityScale) = value;
			}
		}

		// Token: 0x17007021 RID: 28705
		// (get) Token: 0x0601BCD6 RID: 113878 RVA: 0x0028EBFC File Offset: 0x0028CDFC
		// (set) Token: 0x0601BCD7 RID: 113879 RVA: 0x0028EC0C File Offset: 0x0028CE0C
		public unsafe float ToonLightIntensityCurveScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPointLightData.__PropertyOffset_ToonLightIntensityCurveScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPointLightData.__PropertyOffset_ToonLightIntensityCurveScale) = value;
			}
		}

		// Token: 0x17007022 RID: 28706
		// (get) Token: 0x0601BCD8 RID: 113880 RVA: 0x0028EC1D File Offset: 0x0028CE1D
		// (set) Token: 0x0601BCD9 RID: 113881 RVA: 0x0028EC2D File Offset: 0x0028CE2D
		public unsafe bool bApplyToonHardLight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPointLightData.__PropertyOffset_bApplyToonHardLight) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPointLightData.__PropertyOffset_bApplyToonHardLight) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007023 RID: 28707
		// (get) Token: 0x0601BCDA RID: 113882 RVA: 0x0028EC3E File Offset: 0x0028CE3E
		// (set) Token: 0x0601BCDB RID: 113883 RVA: 0x0028EC4E File Offset: 0x0028CE4E
		public unsafe float ToonHardLightBaseIntensityScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPointLightData.__PropertyOffset_ToonHardLightBaseIntensityScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPointLightData.__PropertyOffset_ToonHardLightBaseIntensityScale) = value;
			}
		}

		// Token: 0x17007024 RID: 28708
		// (get) Token: 0x0601BCDC RID: 113884 RVA: 0x0028EC5F File Offset: 0x0028CE5F
		// (set) Token: 0x0601BCDD RID: 113885 RVA: 0x0028EC6F File Offset: 0x0028CE6F
		public unsafe float ToonHardLightIntensityCurveScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPointLightData.__PropertyOffset_ToonHardLightIntensityCurveScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPointLightData.__PropertyOffset_ToonHardLightIntensityCurveScale) = value;
			}
		}

		// Token: 0x17007025 RID: 28709
		// (get) Token: 0x0601BCDE RID: 113886 RVA: 0x0028EC80 File Offset: 0x0028CE80
		// (set) Token: 0x0601BCDF RID: 113887 RVA: 0x0028EC90 File Offset: 0x0028CE90
		public unsafe float ToonPointLightFallOff
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPointLightData.__PropertyOffset_ToonPointLightFallOff);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPointLightData.__PropertyOffset_ToonPointLightFallOff) = value;
			}
		}

		// Token: 0x17007026 RID: 28710
		// (get) Token: 0x0601BCE0 RID: 113888 RVA: 0x0028ECA1 File Offset: 0x0028CEA1
		// (set) Token: 0x0601BCE1 RID: 113889 RVA: 0x0028ECB1 File Offset: 0x0028CEB1
		public unsafe bool bUsePointLightFallOffColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPointLightData.__PropertyOffset_bUsePointLightFallOffColor) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPointLightData.__PropertyOffset_bUsePointLightFallOffColor) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007027 RID: 28711
		// (get) Token: 0x0601BCE2 RID: 113890 RVA: 0x0028ECC2 File Offset: 0x0028CEC2
		// (set) Token: 0x0601BCE3 RID: 113891 RVA: 0x0028ECD2 File Offset: 0x0028CED2
		public unsafe float ToonDistanceBlendAtten
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPointLightData.__PropertyOffset_ToonDistanceBlendAtten);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPointLightData.__PropertyOffset_ToonDistanceBlendAtten) = value;
			}
		}

		// Token: 0x17007028 RID: 28712
		// (get) Token: 0x0601BCE4 RID: 113892 RVA: 0x0028ECE3 File Offset: 0x0028CEE3
		// (set) Token: 0x0601BCE5 RID: 113893 RVA: 0x0028ECF3 File Offset: 0x0028CEF3
		public unsafe float ToonDistanceBlendIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPointLightData.__PropertyOffset_ToonDistanceBlendIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPointLightData.__PropertyOffset_ToonDistanceBlendIntensity) = value;
			}
		}

		// Token: 0x17007029 RID: 28713
		// (get) Token: 0x0601BCE6 RID: 113894 RVA: 0x0028ED04 File Offset: 0x0028CF04
		// (set) Token: 0x0601BCE7 RID: 113895 RVA: 0x0028ED18 File Offset: 0x0028CF18
		[Nullable(0)]
		public unsafe TEnumAsByte<EToonLightType> ToonLightType
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)FPointLightData.__PropertyOffset_ToonLightType);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)FPointLightData.__PropertyOffset_ToonLightType) = value;
			}
		}

		// Token: 0x1700702A RID: 28714
		// (get) Token: 0x0601BCE8 RID: 113896 RVA: 0x0028ED2D File Offset: 0x0028CF2D
		// (set) Token: 0x0601BCE9 RID: 113897 RVA: 0x0028ED3D File Offset: 0x0028CF3D
		public unsafe int ToonLightingPriority
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPointLightData.__PropertyOffset_ToonLightingPriority);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPointLightData.__PropertyOffset_ToonLightingPriority) = value;
			}
		}

		// Token: 0x1700702B RID: 28715
		// (get) Token: 0x0601BCEA RID: 113898 RVA: 0x0028ED4E File Offset: 0x0028CF4E
		// (set) Token: 0x0601BCEB RID: 113899 RVA: 0x0028ED5E File Offset: 0x0028CF5E
		public unsafe float ToonLightIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPointLightData.__PropertyOffset_ToonLightIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPointLightData.__PropertyOffset_ToonLightIntensity) = value;
			}
		}

		// Token: 0x1700702C RID: 28716
		// (get) Token: 0x0601BCEC RID: 113900 RVA: 0x0028ED6F File Offset: 0x0028CF6F
		// (set) Token: 0x0601BCED RID: 113901 RVA: 0x0028ED83 File Offset: 0x0028CF83
		public unsafe FColor ToonLightColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPointLightData.__PropertyOffset_ToonLightColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPointLightData.__PropertyOffset_ToonLightColor) = value;
			}
		}

		// Token: 0x1700702D RID: 28717
		// (get) Token: 0x0601BCEE RID: 113902 RVA: 0x0028ED98 File Offset: 0x0028CF98
		// (set) Token: 0x0601BCEF RID: 113903 RVA: 0x0028EDA8 File Offset: 0x0028CFA8
		public unsafe float ToonShadowColorIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPointLightData.__PropertyOffset_ToonShadowColorIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPointLightData.__PropertyOffset_ToonShadowColorIntensity) = value;
			}
		}

		// Token: 0x1700702E RID: 28718
		// (get) Token: 0x0601BCF0 RID: 113904 RVA: 0x0028EDB9 File Offset: 0x0028CFB9
		// (set) Token: 0x0601BCF1 RID: 113905 RVA: 0x0028EDC9 File Offset: 0x0028CFC9
		public unsafe float ToonBaseColorIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPointLightData.__PropertyOffset_ToonBaseColorIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPointLightData.__PropertyOffset_ToonBaseColorIntensity) = value;
			}
		}

		// Token: 0x1700702F RID: 28719
		// (get) Token: 0x0601BCF2 RID: 113906 RVA: 0x0028EDDA File Offset: 0x0028CFDA
		// (set) Token: 0x0601BCF3 RID: 113907 RVA: 0x0028EDEA File Offset: 0x0028CFEA
		public unsafe float ToonRealTimeShadowIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPointLightData.__PropertyOffset_ToonRealTimeShadowIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPointLightData.__PropertyOffset_ToonRealTimeShadowIntensity) = value;
			}
		}

		// Token: 0x17007030 RID: 28720
		// (get) Token: 0x0601BCF4 RID: 113908 RVA: 0x0028EDFC File Offset: 0x0028CFFC
		// (set) Token: 0x0601BCF5 RID: 113909 RVA: 0x0028EE3F File Offset: 0x0028D03F
		[Nullable(1)]
		public FLightingChannels ToonLightingChannels
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FLightingChannels result;
				if ((result = this._ToonLightingChannels) == null)
				{
					result = (this._ToonLightingChannels = new FLightingChannels(base.NativePtr + (IntPtr)FPointLightData.__PropertyOffset_ToonLightingChannels, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FLightingChannels.StaticStruct(), base.NativePtr + (IntPtr)FPointLightData.__PropertyOffset_ToonLightingChannels, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007031 RID: 28721
		// (get) Token: 0x0601BCF6 RID: 113910 RVA: 0x0028EE60 File Offset: 0x0028D060
		// (set) Token: 0x0601BCF7 RID: 113911 RVA: 0x0028EE70 File Offset: 0x0028D070
		public unsafe float ToonHardShadowIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPointLightData.__PropertyOffset_ToonHardShadowIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPointLightData.__PropertyOffset_ToonHardShadowIntensity) = value;
			}
		}

		// Token: 0x17007032 RID: 28722
		// (get) Token: 0x0601BCF8 RID: 113912 RVA: 0x0028EE81 File Offset: 0x0028D081
		// (set) Token: 0x0601BCF9 RID: 113913 RVA: 0x0028EE91 File Offset: 0x0028D091
		public unsafe float ToonHardShadowRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPointLightData.__PropertyOffset_ToonHardShadowRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPointLightData.__PropertyOffset_ToonHardShadowRange) = value;
			}
		}

		// Token: 0x17007033 RID: 28723
		// (get) Token: 0x0601BCFA RID: 113914 RVA: 0x0028EEA2 File Offset: 0x0028D0A2
		// (set) Token: 0x0601BCFB RID: 113915 RVA: 0x0028EEB6 File Offset: 0x0028D0B6
		public unsafe FLinearColor ToonHardBaseColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPointLightData.__PropertyOffset_ToonHardBaseColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPointLightData.__PropertyOffset_ToonHardBaseColor) = value;
			}
		}

		// Token: 0x17007034 RID: 28724
		// (get) Token: 0x0601BCFC RID: 113916 RVA: 0x0028EECB File Offset: 0x0028D0CB
		// (set) Token: 0x0601BCFD RID: 113917 RVA: 0x0028EEDF File Offset: 0x0028D0DF
		public unsafe FLinearColor ToonHardShadowColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPointLightData.__PropertyOffset_ToonHardShadowColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPointLightData.__PropertyOffset_ToonHardShadowColor) = value;
			}
		}

		// Token: 0x17007035 RID: 28725
		// (get) Token: 0x0601BCFE RID: 113918 RVA: 0x0028EEF4 File Offset: 0x0028D0F4
		// (set) Token: 0x0601BCFF RID: 113919 RVA: 0x0028EF04 File Offset: 0x0028D104
		public unsafe float ToonHardShadowBlend
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPointLightData.__PropertyOffset_ToonHardShadowBlend);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPointLightData.__PropertyOffset_ToonHardShadowBlend) = value;
			}
		}

		// Token: 0x17007036 RID: 28726
		// (get) Token: 0x0601BD00 RID: 113920 RVA: 0x0028EF15 File Offset: 0x0028D115
		// (set) Token: 0x0601BD01 RID: 113921 RVA: 0x0028EF25 File Offset: 0x0028D125
		public unsafe bool bEnableIndependentTick
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPointLightData.__PropertyOffset_bEnableIndependentTick) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPointLightData.__PropertyOffset_bEnableIndependentTick) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007037 RID: 28727
		// (get) Token: 0x0601BD02 RID: 113922 RVA: 0x0028EF36 File Offset: 0x0028D136
		// (set) Token: 0x0601BD03 RID: 113923 RVA: 0x0028EF46 File Offset: 0x0028D146
		public unsafe float TickFactor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPointLightData.__PropertyOffset_TickFactor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPointLightData.__PropertyOffset_TickFactor) = value;
			}
		}

		// Token: 0x17007038 RID: 28728
		// (get) Token: 0x0601BD04 RID: 113924 RVA: 0x0028EF57 File Offset: 0x0028D157
		// (set) Token: 0x0601BD05 RID: 113925 RVA: 0x0028EF67 File Offset: 0x0028D167
		public unsafe float CurrentBaseIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPointLightData.__PropertyOffset_CurrentBaseIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPointLightData.__PropertyOffset_CurrentBaseIntensity) = value;
			}
		}

		// Token: 0x17007039 RID: 28729
		// (get) Token: 0x0601BD06 RID: 113926 RVA: 0x0028EF78 File Offset: 0x0028D178
		// (set) Token: 0x0601BD07 RID: 113927 RVA: 0x0028EF88 File Offset: 0x0028D188
		public unsafe float CurrentIntensityCurve
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPointLightData.__PropertyOffset_CurrentIntensityCurve);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPointLightData.__PropertyOffset_CurrentIntensityCurve) = value;
			}
		}

		// Token: 0x1700703A RID: 28730
		// (get) Token: 0x0601BD08 RID: 113928 RVA: 0x0028EF99 File Offset: 0x0028D199
		// (set) Token: 0x0601BD09 RID: 113929 RVA: 0x0028EFA9 File Offset: 0x0028D1A9
		public unsafe bool bKuroMirrorAttenuation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPointLightData.__PropertyOffset_bKuroMirrorAttenuation) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPointLightData.__PropertyOffset_bKuroMirrorAttenuation) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700703B RID: 28731
		// (get) Token: 0x0601BD0A RID: 113930 RVA: 0x0028EFBA File Offset: 0x0028D1BA
		// (set) Token: 0x0601BD0B RID: 113931 RVA: 0x0028EFCA File Offset: 0x0028D1CA
		public unsafe float KuroAttenuationNearDist
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPointLightData.__PropertyOffset_KuroAttenuationNearDist);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPointLightData.__PropertyOffset_KuroAttenuationNearDist) = value;
			}
		}

		// Token: 0x1700703C RID: 28732
		// (get) Token: 0x0601BD0C RID: 113932 RVA: 0x0028EFDB File Offset: 0x0028D1DB
		// (set) Token: 0x0601BD0D RID: 113933 RVA: 0x0028EFEB File Offset: 0x0028D1EB
		public unsafe float KuroAttenuationNearBlur
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPointLightData.__PropertyOffset_KuroAttenuationNearBlur);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPointLightData.__PropertyOffset_KuroAttenuationNearBlur) = value;
			}
		}

		// Token: 0x1700703D RID: 28733
		// (get) Token: 0x0601BD0E RID: 113934 RVA: 0x0028EFFC File Offset: 0x0028D1FC
		// (set) Token: 0x0601BD0F RID: 113935 RVA: 0x0028F00C File Offset: 0x0028D20C
		public unsafe EKuroLightAttenuationShape KuroLightAttenuationShape
		{
			get
			{
				return (EKuroLightAttenuationShape)(*(base.NativePtr + (IntPtr)FPointLightData.__PropertyOffset_KuroLightAttenuationShape));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPointLightData.__PropertyOffset_KuroLightAttenuationShape) = (byte)value;
			}
		}

		// Token: 0x1700703E RID: 28734
		// (get) Token: 0x0601BD10 RID: 113936 RVA: 0x0028F01D File Offset: 0x0028D21D
		// (set) Token: 0x0601BD11 RID: 113937 RVA: 0x0028F02D File Offset: 0x0028D22D
		public unsafe float KuroConeSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPointLightData.__PropertyOffset_KuroConeSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPointLightData.__PropertyOffset_KuroConeSize) = value;
			}
		}

		// Token: 0x1700703F RID: 28735
		// (get) Token: 0x0601BD12 RID: 113938 RVA: 0x0028F03E File Offset: 0x0028D23E
		// (set) Token: 0x0601BD13 RID: 113939 RVA: 0x0028F04E File Offset: 0x0028D24E
		public unsafe float KuroConeBlurSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPointLightData.__PropertyOffset_KuroConeBlurSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPointLightData.__PropertyOffset_KuroConeBlurSize) = value;
			}
		}

		// Token: 0x17007040 RID: 28736
		// (get) Token: 0x0601BD14 RID: 113940 RVA: 0x0028F05F File Offset: 0x0028D25F
		// (set) Token: 0x0601BD15 RID: 113941 RVA: 0x0028F06F File Offset: 0x0028D26F
		public unsafe float KuroRectSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPointLightData.__PropertyOffset_KuroRectSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPointLightData.__PropertyOffset_KuroRectSize) = value;
			}
		}

		// Token: 0x17007041 RID: 28737
		// (get) Token: 0x0601BD16 RID: 113942 RVA: 0x0028F080 File Offset: 0x0028D280
		// (set) Token: 0x0601BD17 RID: 113943 RVA: 0x0028F090 File Offset: 0x0028D290
		public unsafe float KuroRectBlurSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPointLightData.__PropertyOffset_KuroRectBlurSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPointLightData.__PropertyOffset_KuroRectBlurSize) = value;
			}
		}

		// Token: 0x0601BD18 RID: 113944 RVA: 0x0028F0A1 File Offset: 0x0028D2A1
		public FPointLightData()
		{
		}

		// Token: 0x0601BD19 RID: 113945 RVA: 0x0028F0AC File Offset: 0x0028D2AC
		[NullableContext(1)]
		public FPointLightData(UKuroFlickerLightPreset Preset, UKuroMoveMusicLightPreset MovePreset, float KuroMoveLightAttenuationRadius, float KuroMoveLightAttenuation, float SourceRadius, float SoftSourceRadius, float SourceLength, float SpecularScale, FKuroCurveFloat PointCurve, float MoveSpeed, bool bLoopMode, FLinearColor PointStartColor, FLinearColor PointEndColor, bool bUseColorCurve, UCurveLinearColor ColorGradientCurve, ESplinePlaneType SplinePlane, FVector SplineEndPoint, float CurveOffsetStrength, int SplineSampleCount, float BaseIntensityScale, float IntensityCurveScale, float FlickSpeedScale, float AllIntensityScale, bool bApplyToonLight, float ToonLightBaseIntensityScale, float ToonLightIntensityCurveScale, bool bApplyToonHardLight, float ToonHardLightBaseIntensityScale, float ToonHardLightIntensityCurveScale, float ToonPointLightFallOff, bool bUsePointLightFallOffColor, float ToonDistanceBlendAtten, float ToonDistanceBlendIntensity, [Nullable(0)] TEnumAsByte<EToonLightType> ToonLightType, int ToonLightingPriority, float ToonLightIntensity, FColor ToonLightColor, float ToonShadowColorIntensity, float ToonBaseColorIntensity, float ToonRealTimeShadowIntensity, FLightingChannels ToonLightingChannels, float ToonHardShadowIntensity, float ToonHardShadowRange, FLinearColor ToonHardBaseColor, FLinearColor ToonHardShadowColor, float ToonHardShadowBlend, bool bEnableIndependentTick, float TickFactor, float CurrentBaseIntensity, float CurrentIntensityCurve, bool bKuroMirrorAttenuation, float KuroAttenuationNearDist, float KuroAttenuationNearBlur, EKuroLightAttenuationShape KuroLightAttenuationShape, float KuroConeSize, float KuroConeBlurSize, float KuroRectSize, float KuroRectBlurSize)
		{
			this.Preset = Preset;
			this.MovePreset = MovePreset;
			this.KuroMoveLightAttenuationRadius = KuroMoveLightAttenuationRadius;
			this.KuroMoveLightAttenuation = KuroMoveLightAttenuation;
			this.SourceRadius = SourceRadius;
			this.SoftSourceRadius = SoftSourceRadius;
			this.SourceLength = SourceLength;
			this.SpecularScale = SpecularScale;
			this.PointCurve = PointCurve;
			this.MoveSpeed = MoveSpeed;
			this.bLoopMode = bLoopMode;
			this.PointStartColor = PointStartColor;
			this.PointEndColor = PointEndColor;
			this.bUseColorCurve = bUseColorCurve;
			this.ColorGradientCurve = ColorGradientCurve;
			this.SplinePlane = SplinePlane;
			this.SplineEndPoint = SplineEndPoint;
			this.CurveOffsetStrength = CurveOffsetStrength;
			this.SplineSampleCount = SplineSampleCount;
			this.BaseIntensityScale = BaseIntensityScale;
			this.IntensityCurveScale = IntensityCurveScale;
			this.FlickSpeedScale = FlickSpeedScale;
			this.AllIntensityScale = AllIntensityScale;
			this.bApplyToonLight = bApplyToonLight;
			this.ToonLightBaseIntensityScale = ToonLightBaseIntensityScale;
			this.ToonLightIntensityCurveScale = ToonLightIntensityCurveScale;
			this.bApplyToonHardLight = bApplyToonHardLight;
			this.ToonHardLightBaseIntensityScale = ToonHardLightBaseIntensityScale;
			this.ToonHardLightIntensityCurveScale = ToonHardLightIntensityCurveScale;
			this.ToonPointLightFallOff = ToonPointLightFallOff;
			this.bUsePointLightFallOffColor = bUsePointLightFallOffColor;
			this.ToonDistanceBlendAtten = ToonDistanceBlendAtten;
			this.ToonDistanceBlendIntensity = ToonDistanceBlendIntensity;
			this.ToonLightType = ToonLightType;
			this.ToonLightingPriority = ToonLightingPriority;
			this.ToonLightIntensity = ToonLightIntensity;
			this.ToonLightColor = ToonLightColor;
			this.ToonShadowColorIntensity = ToonShadowColorIntensity;
			this.ToonBaseColorIntensity = ToonBaseColorIntensity;
			this.ToonRealTimeShadowIntensity = ToonRealTimeShadowIntensity;
			this.ToonLightingChannels = ToonLightingChannels;
			this.ToonHardShadowIntensity = ToonHardShadowIntensity;
			this.ToonHardShadowRange = ToonHardShadowRange;
			this.ToonHardBaseColor = ToonHardBaseColor;
			this.ToonHardShadowColor = ToonHardShadowColor;
			this.ToonHardShadowBlend = ToonHardShadowBlend;
			this.bEnableIndependentTick = bEnableIndependentTick;
			this.TickFactor = TickFactor;
			this.CurrentBaseIntensity = CurrentBaseIntensity;
			this.CurrentIntensityCurve = CurrentIntensityCurve;
			this.bKuroMirrorAttenuation = bKuroMirrorAttenuation;
			this.KuroAttenuationNearDist = KuroAttenuationNearDist;
			this.KuroAttenuationNearBlur = KuroAttenuationNearBlur;
			this.KuroLightAttenuationShape = KuroLightAttenuationShape;
			this.KuroConeSize = KuroConeSize;
			this.KuroConeBlurSize = KuroConeBlurSize;
			this.KuroRectSize = KuroRectSize;
			this.KuroRectBlurSize = KuroRectBlurSize;
		}

		// Token: 0x0601BD1A RID: 113946 RVA: 0x0028F28C File Offset: 0x0028D48C
		protected override IntPtr GetUStructPtr()
		{
			return FPointLightData.StaticStruct();
		}

		// Token: 0x0601BD1B RID: 113947 RVA: 0x0028F298 File Offset: 0x0028D498
		public FPointLightData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601BD1C RID: 113948 RVA: 0x0028F2A2 File Offset: 0x0028D4A2
		public FPointLightData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601BD1D RID: 113949 RVA: 0x0028F2AD File Offset: 0x0028D4AD
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FPointLightData(Pointer, false, true);
		}

		// Token: 0x0601BD1E RID: 113950 RVA: 0x0028F2B7 File Offset: 0x0028D4B7
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FPointLightData(Pointer, MemoryOwner);
		}

		// Token: 0x0400EEFD RID: 61181
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.PointLightData";

		// Token: 0x0400EEFE RID: 61182
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400EEFF RID: 61183
		internal static int __PropertyOffset_Preset;

		// Token: 0x0400EF00 RID: 61184
		internal static int __PropertyOffset_MovePreset;

		// Token: 0x0400EF01 RID: 61185
		internal static int __PropertyOffset_KuroMoveLightAttenuationRadius;

		// Token: 0x0400EF02 RID: 61186
		internal static int __PropertyOffset_KuroMoveLightAttenuation;

		// Token: 0x0400EF03 RID: 61187
		internal static int __PropertyOffset_SourceRadius;

		// Token: 0x0400EF04 RID: 61188
		internal static int __PropertyOffset_SoftSourceRadius;

		// Token: 0x0400EF05 RID: 61189
		internal static int __PropertyOffset_SourceLength;

		// Token: 0x0400EF06 RID: 61190
		internal static int __PropertyOffset_SpecularScale;

		// Token: 0x0400EF07 RID: 61191
		internal static int __PropertyOffset_PointCurve;

		// Token: 0x0400EF08 RID: 61192
		private FKuroCurveFloat _PointCurve;

		// Token: 0x0400EF09 RID: 61193
		internal static int __PropertyOffset_MoveSpeed;

		// Token: 0x0400EF0A RID: 61194
		internal static int __PropertyOffset_bLoopMode;

		// Token: 0x0400EF0B RID: 61195
		internal static int __PropertyOffset_PointStartColor;

		// Token: 0x0400EF0C RID: 61196
		internal static int __PropertyOffset_PointEndColor;

		// Token: 0x0400EF0D RID: 61197
		internal static int __PropertyOffset_bUseColorCurve;

		// Token: 0x0400EF0E RID: 61198
		internal static int __PropertyOffset_ColorGradientCurve;

		// Token: 0x0400EF0F RID: 61199
		internal static int __PropertyOffset_SplinePlane;

		// Token: 0x0400EF10 RID: 61200
		internal static int __PropertyOffset_SplineEndPoint;

		// Token: 0x0400EF11 RID: 61201
		internal static int __PropertyOffset_CurveOffsetStrength;

		// Token: 0x0400EF12 RID: 61202
		internal static int __PropertyOffset_SplineSampleCount;

		// Token: 0x0400EF13 RID: 61203
		internal static int __PropertyOffset_BaseIntensityScale;

		// Token: 0x0400EF14 RID: 61204
		internal static int __PropertyOffset_IntensityCurveScale;

		// Token: 0x0400EF15 RID: 61205
		internal static int __PropertyOffset_FlickSpeedScale;

		// Token: 0x0400EF16 RID: 61206
		internal static int __PropertyOffset_AllIntensityScale;

		// Token: 0x0400EF17 RID: 61207
		internal static int __PropertyOffset_bApplyToonLight;

		// Token: 0x0400EF18 RID: 61208
		internal static int __PropertyOffset_ToonLightBaseIntensityScale;

		// Token: 0x0400EF19 RID: 61209
		internal static int __PropertyOffset_ToonLightIntensityCurveScale;

		// Token: 0x0400EF1A RID: 61210
		internal static int __PropertyOffset_bApplyToonHardLight;

		// Token: 0x0400EF1B RID: 61211
		internal static int __PropertyOffset_ToonHardLightBaseIntensityScale;

		// Token: 0x0400EF1C RID: 61212
		internal static int __PropertyOffset_ToonHardLightIntensityCurveScale;

		// Token: 0x0400EF1D RID: 61213
		internal static int __PropertyOffset_ToonPointLightFallOff;

		// Token: 0x0400EF1E RID: 61214
		internal static int __PropertyOffset_bUsePointLightFallOffColor;

		// Token: 0x0400EF1F RID: 61215
		internal static int __PropertyOffset_ToonDistanceBlendAtten;

		// Token: 0x0400EF20 RID: 61216
		internal static int __PropertyOffset_ToonDistanceBlendIntensity;

		// Token: 0x0400EF21 RID: 61217
		internal static int __PropertyOffset_ToonLightType;

		// Token: 0x0400EF22 RID: 61218
		internal static int __PropertyOffset_ToonLightingPriority;

		// Token: 0x0400EF23 RID: 61219
		internal static int __PropertyOffset_ToonLightIntensity;

		// Token: 0x0400EF24 RID: 61220
		internal static int __PropertyOffset_ToonLightColor;

		// Token: 0x0400EF25 RID: 61221
		internal static int __PropertyOffset_ToonShadowColorIntensity;

		// Token: 0x0400EF26 RID: 61222
		internal static int __PropertyOffset_ToonBaseColorIntensity;

		// Token: 0x0400EF27 RID: 61223
		internal static int __PropertyOffset_ToonRealTimeShadowIntensity;

		// Token: 0x0400EF28 RID: 61224
		internal static int __PropertyOffset_ToonLightingChannels;

		// Token: 0x0400EF29 RID: 61225
		private FLightingChannels _ToonLightingChannels;

		// Token: 0x0400EF2A RID: 61226
		internal static int __PropertyOffset_ToonHardShadowIntensity;

		// Token: 0x0400EF2B RID: 61227
		internal static int __PropertyOffset_ToonHardShadowRange;

		// Token: 0x0400EF2C RID: 61228
		internal static int __PropertyOffset_ToonHardBaseColor;

		// Token: 0x0400EF2D RID: 61229
		internal static int __PropertyOffset_ToonHardShadowColor;

		// Token: 0x0400EF2E RID: 61230
		internal static int __PropertyOffset_ToonHardShadowBlend;

		// Token: 0x0400EF2F RID: 61231
		internal static int __PropertyOffset_bEnableIndependentTick;

		// Token: 0x0400EF30 RID: 61232
		internal static int __PropertyOffset_TickFactor;

		// Token: 0x0400EF31 RID: 61233
		internal static int __PropertyOffset_CurrentBaseIntensity;

		// Token: 0x0400EF32 RID: 61234
		internal static int __PropertyOffset_CurrentIntensityCurve;

		// Token: 0x0400EF33 RID: 61235
		internal static int __PropertyOffset_bKuroMirrorAttenuation;

		// Token: 0x0400EF34 RID: 61236
		internal static int __PropertyOffset_KuroAttenuationNearDist;

		// Token: 0x0400EF35 RID: 61237
		internal static int __PropertyOffset_KuroAttenuationNearBlur;

		// Token: 0x0400EF36 RID: 61238
		internal static int __PropertyOffset_KuroLightAttenuationShape;

		// Token: 0x0400EF37 RID: 61239
		internal static int __PropertyOffset_KuroConeSize;

		// Token: 0x0400EF38 RID: 61240
		internal static int __PropertyOffset_KuroConeBlurSize;

		// Token: 0x0400EF39 RID: 61241
		internal static int __PropertyOffset_KuroRectSize;

		// Token: 0x0400EF3A RID: 61242
		internal static int __PropertyOffset_KuroRectBlurSize;
	}
}
