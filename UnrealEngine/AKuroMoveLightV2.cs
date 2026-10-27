using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001B78 RID: 7032
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroMoveLightV2")]
	[UnrealStructLayout(2112, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2112)]
	public class AKuroMoveLightV2 : AKuroGameBudgetBlueprintActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601AA68 RID: 109160 RVA: 0x002747B6 File Offset: 0x002729B6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroMoveLightV2._ClassPtr;
		}

		// Token: 0x0601AA69 RID: 109161 RVA: 0x002747C4 File Offset: 0x002729C4
		public AKuroMoveLightV2() : this(BuiltinUtils.AllocNativeUObject(AKuroMoveLightV2.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601AA6A RID: 109162 RVA: 0x002747EC File Offset: 0x002729EC
		[NullableContext(1)]
		public AKuroMoveLightV2(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroMoveLightV2.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006B0D RID: 27405
		// (get) Token: 0x0601AA6B RID: 109163 RVA: 0x0027481F File Offset: 0x00272A1F
		// (set) Token: 0x0601AA6C RID: 109164 RVA: 0x00274833 File Offset: 0x00272A33
		public unsafe AActor SplineSource
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroMoveLightV2.__PropertyOffset_SplineSource);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroMoveLightV2.__PropertyOffset_SplineSource, value);
			}
		}

		// Token: 0x17006B0E RID: 27406
		// (get) Token: 0x0601AA6D RID: 109165 RVA: 0x00274848 File Offset: 0x00272A48
		// (set) Token: 0x0601AA6E RID: 109166 RVA: 0x00274858 File Offset: 0x00272A58
		public unsafe bool bApplySplineMove
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroMoveLightV2.__PropertyOffset_bApplySplineMove) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroMoveLightV2.__PropertyOffset_bApplySplineMove) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006B0F RID: 27407
		// (get) Token: 0x0601AA6F RID: 109167 RVA: 0x00274869 File Offset: 0x00272A69
		// (set) Token: 0x0601AA70 RID: 109168 RVA: 0x00274879 File Offset: 0x00272A79
		public unsafe float MoveSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroMoveLightV2.__PropertyOffset_MoveSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroMoveLightV2.__PropertyOffset_MoveSpeed) = value;
			}
		}

		// Token: 0x17006B10 RID: 27408
		// (get) Token: 0x0601AA71 RID: 109169 RVA: 0x0027488A File Offset: 0x00272A8A
		// (set) Token: 0x0601AA72 RID: 109170 RVA: 0x0027489A File Offset: 0x00272A9A
		public unsafe bool bLoopMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroMoveLightV2.__PropertyOffset_bLoopMode) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroMoveLightV2.__PropertyOffset_bLoopMode) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006B11 RID: 27409
		// (get) Token: 0x0601AA73 RID: 109171 RVA: 0x002748AB File Offset: 0x00272AAB
		// (set) Token: 0x0601AA74 RID: 109172 RVA: 0x002748BF File Offset: 0x00272ABF
		public unsafe UKuroFlickerLightPreset Preset
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroFlickerLightPreset>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroMoveLightV2.__PropertyOffset_Preset);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroMoveLightV2.__PropertyOffset_Preset, value);
			}
		}

		// Token: 0x17006B12 RID: 27410
		// (get) Token: 0x0601AA75 RID: 109173 RVA: 0x002748D4 File Offset: 0x00272AD4
		// (set) Token: 0x0601AA76 RID: 109174 RVA: 0x0027490D File Offset: 0x00272B0D
		[Nullable(1)]
		public FKuroCurveFloat BakedIntensityCurve
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._BakedIntensityCurve) == null)
				{
					result = (this._BakedIntensityCurve = new FKuroCurveFloat(base.NativePtr + (IntPtr)AKuroMoveLightV2.__PropertyOffset_BakedIntensityCurve, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)AKuroMoveLightV2.__PropertyOffset_BakedIntensityCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006B13 RID: 27411
		// (get) Token: 0x0601AA77 RID: 109175 RVA: 0x0027492E File Offset: 0x00272B2E
		// (set) Token: 0x0601AA78 RID: 109176 RVA: 0x0027493E File Offset: 0x00272B3E
		public unsafe float BaseIntensityScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroMoveLightV2.__PropertyOffset_BaseIntensityScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroMoveLightV2.__PropertyOffset_BaseIntensityScale) = value;
			}
		}

		// Token: 0x17006B14 RID: 27412
		// (get) Token: 0x0601AA79 RID: 109177 RVA: 0x0027494F File Offset: 0x00272B4F
		// (set) Token: 0x0601AA7A RID: 109178 RVA: 0x0027495F File Offset: 0x00272B5F
		public unsafe float IntensityCurveScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroMoveLightV2.__PropertyOffset_IntensityCurveScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroMoveLightV2.__PropertyOffset_IntensityCurveScale) = value;
			}
		}

		// Token: 0x17006B15 RID: 27413
		// (get) Token: 0x0601AA7B RID: 109179 RVA: 0x00274970 File Offset: 0x00272B70
		// (set) Token: 0x0601AA7C RID: 109180 RVA: 0x00274980 File Offset: 0x00272B80
		public unsafe float FlickSpeedScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroMoveLightV2.__PropertyOffset_FlickSpeedScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroMoveLightV2.__PropertyOffset_FlickSpeedScale) = value;
			}
		}

		// Token: 0x17006B16 RID: 27414
		// (get) Token: 0x0601AA7D RID: 109181 RVA: 0x00274991 File Offset: 0x00272B91
		// (set) Token: 0x0601AA7E RID: 109182 RVA: 0x002749A1 File Offset: 0x00272BA1
		public unsafe float AllIntensityScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroMoveLightV2.__PropertyOffset_AllIntensityScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroMoveLightV2.__PropertyOffset_AllIntensityScale) = value;
			}
		}

		// Token: 0x17006B17 RID: 27415
		// (get) Token: 0x0601AA7F RID: 109183 RVA: 0x002749B2 File Offset: 0x00272BB2
		// (set) Token: 0x0601AA80 RID: 109184 RVA: 0x002749C2 File Offset: 0x00272BC2
		public unsafe EKuroMoveLightColorSource LightColorSource
		{
			get
			{
				return (EKuroMoveLightColorSource)(*(base.NativePtr + (IntPtr)AKuroMoveLightV2.__PropertyOffset_LightColorSource));
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroMoveLightV2.__PropertyOffset_LightColorSource) = (byte)value;
			}
		}

		// Token: 0x17006B18 RID: 27416
		// (get) Token: 0x0601AA81 RID: 109185 RVA: 0x002749D3 File Offset: 0x00272BD3
		// (set) Token: 0x0601AA82 RID: 109186 RVA: 0x002749E7 File Offset: 0x00272BE7
		public unsafe FLinearColor SelfLightColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroMoveLightV2.__PropertyOffset_SelfLightColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroMoveLightV2.__PropertyOffset_SelfLightColor) = value;
			}
		}

		// Token: 0x17006B19 RID: 27417
		// (get) Token: 0x0601AA83 RID: 109187 RVA: 0x002749FC File Offset: 0x00272BFC
		// (set) Token: 0x0601AA84 RID: 109188 RVA: 0x00274A10 File Offset: 0x00272C10
		public unsafe UCurveLinearColor BakedColorCurve
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveLinearColor>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroMoveLightV2.__PropertyOffset_BakedColorCurve);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroMoveLightV2.__PropertyOffset_BakedColorCurve, value);
			}
		}

		// Token: 0x17006B1A RID: 27418
		// (get) Token: 0x0601AA85 RID: 109189 RVA: 0x00274A25 File Offset: 0x00272C25
		// (set) Token: 0x0601AA86 RID: 109190 RVA: 0x00274A35 File Offset: 0x00272C35
		public unsafe float BakedColorBlendRatio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroMoveLightV2.__PropertyOffset_BakedColorBlendRatio);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroMoveLightV2.__PropertyOffset_BakedColorBlendRatio) = value;
			}
		}

		// Token: 0x17006B1B RID: 27419
		// (get) Token: 0x0601AA87 RID: 109191 RVA: 0x00274A46 File Offset: 0x00272C46
		// (set) Token: 0x0601AA88 RID: 109192 RVA: 0x00274A5A File Offset: 0x00272C5A
		public unsafe UCurveLinearColor EmissiveBakedColorCurve
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveLinearColor>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroMoveLightV2.__PropertyOffset_EmissiveBakedColorCurve);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroMoveLightV2.__PropertyOffset_EmissiveBakedColorCurve, value);
			}
		}

		// Token: 0x17006B1C RID: 27420
		// (get) Token: 0x0601AA89 RID: 109193 RVA: 0x00274A70 File Offset: 0x00272C70
		// (set) Token: 0x0601AA8A RID: 109194 RVA: 0x00274AA9 File Offset: 0x00272CA9
		[Nullable(1)]
		public FKuroCurveFloat EmissiveBakedIntensityCurve
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._EmissiveBakedIntensityCurve) == null)
				{
					result = (this._EmissiveBakedIntensityCurve = new FKuroCurveFloat(base.NativePtr + (IntPtr)AKuroMoveLightV2.__PropertyOffset_EmissiveBakedIntensityCurve, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)AKuroMoveLightV2.__PropertyOffset_EmissiveBakedIntensityCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006B1D RID: 27421
		// (get) Token: 0x0601AA8B RID: 109195 RVA: 0x00274ACA File Offset: 0x00272CCA
		// (set) Token: 0x0601AA8C RID: 109196 RVA: 0x00274ADA File Offset: 0x00272CDA
		public unsafe float EmissiveColorBlendRatio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroMoveLightV2.__PropertyOffset_EmissiveColorBlendRatio);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroMoveLightV2.__PropertyOffset_EmissiveColorBlendRatio) = value;
			}
		}

		// Token: 0x17006B1E RID: 27422
		// (get) Token: 0x0601AA8D RID: 109197 RVA: 0x00274AEB File Offset: 0x00272CEB
		// (set) Token: 0x0601AA8E RID: 109198 RVA: 0x00274AFB File Offset: 0x00272CFB
		public unsafe float EmissiveIntensityBlendRatio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroMoveLightV2.__PropertyOffset_EmissiveIntensityBlendRatio);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroMoveLightV2.__PropertyOffset_EmissiveIntensityBlendRatio) = value;
			}
		}

		// Token: 0x17006B1F RID: 27423
		// (get) Token: 0x0601AA8F RID: 109199 RVA: 0x00274B0C File Offset: 0x00272D0C
		// (set) Token: 0x0601AA90 RID: 109200 RVA: 0x00274B1C File Offset: 0x00272D1C
		public unsafe float EmissiveIntensityScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroMoveLightV2.__PropertyOffset_EmissiveIntensityScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroMoveLightV2.__PropertyOffset_EmissiveIntensityScale) = value;
			}
		}

		// Token: 0x17006B20 RID: 27424
		// (get) Token: 0x0601AA91 RID: 109201 RVA: 0x00274B2D File Offset: 0x00272D2D
		// (set) Token: 0x0601AA92 RID: 109202 RVA: 0x00274B3D File Offset: 0x00272D3D
		public unsafe float CurveTimeOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroMoveLightV2.__PropertyOffset_CurveTimeOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroMoveLightV2.__PropertyOffset_CurveTimeOffset) = value;
			}
		}

		// Token: 0x17006B21 RID: 27425
		// (get) Token: 0x0601AA93 RID: 109203 RVA: 0x00274B4E File Offset: 0x00272D4E
		// (set) Token: 0x0601AA94 RID: 109204 RVA: 0x00274B5E File Offset: 0x00272D5E
		public unsafe float CurvePeriod
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroMoveLightV2.__PropertyOffset_CurvePeriod);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroMoveLightV2.__PropertyOffset_CurvePeriod) = value;
			}
		}

		// Token: 0x17006B22 RID: 27426
		// (get) Token: 0x0601AA95 RID: 109205 RVA: 0x00274B6F File Offset: 0x00272D6F
		// (set) Token: 0x0601AA96 RID: 109206 RVA: 0x00274B7F File Offset: 0x00272D7F
		public unsafe float KuroMoveLightAttenuationRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroMoveLightV2.__PropertyOffset_KuroMoveLightAttenuationRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroMoveLightV2.__PropertyOffset_KuroMoveLightAttenuationRadius) = value;
			}
		}

		// Token: 0x17006B23 RID: 27427
		// (get) Token: 0x0601AA97 RID: 109207 RVA: 0x00274B90 File Offset: 0x00272D90
		// (set) Token: 0x0601AA98 RID: 109208 RVA: 0x00274BA0 File Offset: 0x00272DA0
		public unsafe float KuroMoveLightAttenuation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroMoveLightV2.__PropertyOffset_KuroMoveLightAttenuation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroMoveLightV2.__PropertyOffset_KuroMoveLightAttenuation) = value;
			}
		}

		// Token: 0x17006B24 RID: 27428
		// (get) Token: 0x0601AA99 RID: 109209 RVA: 0x00274BB1 File Offset: 0x00272DB1
		// (set) Token: 0x0601AA9A RID: 109210 RVA: 0x00274BC1 File Offset: 0x00272DC1
		public unsafe float SourceRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroMoveLightV2.__PropertyOffset_SourceRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroMoveLightV2.__PropertyOffset_SourceRadius) = value;
			}
		}

		// Token: 0x17006B25 RID: 27429
		// (get) Token: 0x0601AA9B RID: 109211 RVA: 0x00274BD2 File Offset: 0x00272DD2
		// (set) Token: 0x0601AA9C RID: 109212 RVA: 0x00274BE2 File Offset: 0x00272DE2
		public unsafe float SoftSourceRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroMoveLightV2.__PropertyOffset_SoftSourceRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroMoveLightV2.__PropertyOffset_SoftSourceRadius) = value;
			}
		}

		// Token: 0x17006B26 RID: 27430
		// (get) Token: 0x0601AA9D RID: 109213 RVA: 0x00274BF3 File Offset: 0x00272DF3
		// (set) Token: 0x0601AA9E RID: 109214 RVA: 0x00274C03 File Offset: 0x00272E03
		public unsafe float SourceLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroMoveLightV2.__PropertyOffset_SourceLength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroMoveLightV2.__PropertyOffset_SourceLength) = value;
			}
		}

		// Token: 0x17006B27 RID: 27431
		// (get) Token: 0x0601AA9F RID: 109215 RVA: 0x00274C14 File Offset: 0x00272E14
		// (set) Token: 0x0601AAA0 RID: 109216 RVA: 0x00274C24 File Offset: 0x00272E24
		public unsafe float SpecularScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroMoveLightV2.__PropertyOffset_SpecularScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroMoveLightV2.__PropertyOffset_SpecularScale) = value;
			}
		}

		// Token: 0x17006B28 RID: 27432
		// (get) Token: 0x0601AAA1 RID: 109217 RVA: 0x00274C35 File Offset: 0x00272E35
		// (set) Token: 0x0601AAA2 RID: 109218 RVA: 0x00274C45 File Offset: 0x00272E45
		public unsafe bool bKuroMirrorAttenuation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroMoveLightV2.__PropertyOffset_bKuroMirrorAttenuation) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroMoveLightV2.__PropertyOffset_bKuroMirrorAttenuation) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006B29 RID: 27433
		// (get) Token: 0x0601AAA3 RID: 109219 RVA: 0x00274C56 File Offset: 0x00272E56
		// (set) Token: 0x0601AAA4 RID: 109220 RVA: 0x00274C66 File Offset: 0x00272E66
		public unsafe float KuroAttenuationNearDist
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroMoveLightV2.__PropertyOffset_KuroAttenuationNearDist);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroMoveLightV2.__PropertyOffset_KuroAttenuationNearDist) = value;
			}
		}

		// Token: 0x17006B2A RID: 27434
		// (get) Token: 0x0601AAA5 RID: 109221 RVA: 0x00274C77 File Offset: 0x00272E77
		// (set) Token: 0x0601AAA6 RID: 109222 RVA: 0x00274C87 File Offset: 0x00272E87
		public unsafe float KuroAttenuationNearBlur
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroMoveLightV2.__PropertyOffset_KuroAttenuationNearBlur);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroMoveLightV2.__PropertyOffset_KuroAttenuationNearBlur) = value;
			}
		}

		// Token: 0x17006B2B RID: 27435
		// (get) Token: 0x0601AAA7 RID: 109223 RVA: 0x00274C98 File Offset: 0x00272E98
		// (set) Token: 0x0601AAA8 RID: 109224 RVA: 0x00274CA8 File Offset: 0x00272EA8
		public unsafe EKuroLightAttenuationShape KuroLightAttenuationShape
		{
			get
			{
				return (EKuroLightAttenuationShape)(*(base.NativePtr + (IntPtr)AKuroMoveLightV2.__PropertyOffset_KuroLightAttenuationShape));
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroMoveLightV2.__PropertyOffset_KuroLightAttenuationShape) = (byte)value;
			}
		}

		// Token: 0x17006B2C RID: 27436
		// (get) Token: 0x0601AAA9 RID: 109225 RVA: 0x00274CB9 File Offset: 0x00272EB9
		// (set) Token: 0x0601AAAA RID: 109226 RVA: 0x00274CC9 File Offset: 0x00272EC9
		public unsafe float KuroConeSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroMoveLightV2.__PropertyOffset_KuroConeSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroMoveLightV2.__PropertyOffset_KuroConeSize) = value;
			}
		}

		// Token: 0x17006B2D RID: 27437
		// (get) Token: 0x0601AAAB RID: 109227 RVA: 0x00274CDA File Offset: 0x00272EDA
		// (set) Token: 0x0601AAAC RID: 109228 RVA: 0x00274CEA File Offset: 0x00272EEA
		public unsafe float KuroConeBlurSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroMoveLightV2.__PropertyOffset_KuroConeBlurSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroMoveLightV2.__PropertyOffset_KuroConeBlurSize) = value;
			}
		}

		// Token: 0x17006B2E RID: 27438
		// (get) Token: 0x0601AAAD RID: 109229 RVA: 0x00274CFB File Offset: 0x00272EFB
		// (set) Token: 0x0601AAAE RID: 109230 RVA: 0x00274D0B File Offset: 0x00272F0B
		public unsafe float KuroRectSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroMoveLightV2.__PropertyOffset_KuroRectSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroMoveLightV2.__PropertyOffset_KuroRectSize) = value;
			}
		}

		// Token: 0x17006B2F RID: 27439
		// (get) Token: 0x0601AAAF RID: 109231 RVA: 0x00274D1C File Offset: 0x00272F1C
		// (set) Token: 0x0601AAB0 RID: 109232 RVA: 0x00274D2C File Offset: 0x00272F2C
		public unsafe float KuroRectBlurSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroMoveLightV2.__PropertyOffset_KuroRectBlurSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroMoveLightV2.__PropertyOffset_KuroRectBlurSize) = value;
			}
		}

		// Token: 0x17006B30 RID: 27440
		// (get) Token: 0x0601AAB1 RID: 109233 RVA: 0x00274D3D File Offset: 0x00272F3D
		// (set) Token: 0x0601AAB2 RID: 109234 RVA: 0x00274D4D File Offset: 0x00272F4D
		public unsafe float ToonPointLightFallOff
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroMoveLightV2.__PropertyOffset_ToonPointLightFallOff);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroMoveLightV2.__PropertyOffset_ToonPointLightFallOff) = value;
			}
		}

		// Token: 0x17006B31 RID: 27441
		// (get) Token: 0x0601AAB3 RID: 109235 RVA: 0x00274D5E File Offset: 0x00272F5E
		// (set) Token: 0x0601AAB4 RID: 109236 RVA: 0x00274D6E File Offset: 0x00272F6E
		public unsafe bool bUsePointLightFallOffColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroMoveLightV2.__PropertyOffset_bUsePointLightFallOffColor) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroMoveLightV2.__PropertyOffset_bUsePointLightFallOffColor) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006B32 RID: 27442
		// (get) Token: 0x0601AAB5 RID: 109237 RVA: 0x00274D7F File Offset: 0x00272F7F
		// (set) Token: 0x0601AAB6 RID: 109238 RVA: 0x00274D8F File Offset: 0x00272F8F
		public unsafe float ToonDistanceBlendAtten
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroMoveLightV2.__PropertyOffset_ToonDistanceBlendAtten);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroMoveLightV2.__PropertyOffset_ToonDistanceBlendAtten) = value;
			}
		}

		// Token: 0x17006B33 RID: 27443
		// (get) Token: 0x0601AAB7 RID: 109239 RVA: 0x00274DA0 File Offset: 0x00272FA0
		// (set) Token: 0x0601AAB8 RID: 109240 RVA: 0x00274DB0 File Offset: 0x00272FB0
		public unsafe float ToonDistanceBlendIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroMoveLightV2.__PropertyOffset_ToonDistanceBlendIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroMoveLightV2.__PropertyOffset_ToonDistanceBlendIntensity) = value;
			}
		}

		// Token: 0x17006B34 RID: 27444
		// (get) Token: 0x0601AAB9 RID: 109241 RVA: 0x00274DC1 File Offset: 0x00272FC1
		// (set) Token: 0x0601AABA RID: 109242 RVA: 0x00274DD5 File Offset: 0x00272FD5
		[Nullable(0)]
		public unsafe TEnumAsByte<EToonLightType> ToonLightType
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroMoveLightV2.__PropertyOffset_ToonLightType);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)AKuroMoveLightV2.__PropertyOffset_ToonLightType) = value;
			}
		}

		// Token: 0x17006B35 RID: 27445
		// (get) Token: 0x0601AABB RID: 109243 RVA: 0x00274DEA File Offset: 0x00272FEA
		// (set) Token: 0x0601AABC RID: 109244 RVA: 0x00274DFA File Offset: 0x00272FFA
		public unsafe int ToonLightingPriority
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroMoveLightV2.__PropertyOffset_ToonLightingPriority);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroMoveLightV2.__PropertyOffset_ToonLightingPriority) = value;
			}
		}

		// Token: 0x17006B36 RID: 27446
		// (get) Token: 0x0601AABD RID: 109245 RVA: 0x00274E0B File Offset: 0x0027300B
		// (set) Token: 0x0601AABE RID: 109246 RVA: 0x00274E1B File Offset: 0x0027301B
		public unsafe bool bApplyToonLight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroMoveLightV2.__PropertyOffset_bApplyToonLight) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroMoveLightV2.__PropertyOffset_bApplyToonLight) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006B37 RID: 27447
		// (get) Token: 0x0601AABF RID: 109247 RVA: 0x00274E2C File Offset: 0x0027302C
		// (set) Token: 0x0601AAC0 RID: 109248 RVA: 0x00274E3C File Offset: 0x0027303C
		public unsafe float ToonLightBaseIntensityScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroMoveLightV2.__PropertyOffset_ToonLightBaseIntensityScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroMoveLightV2.__PropertyOffset_ToonLightBaseIntensityScale) = value;
			}
		}

		// Token: 0x17006B38 RID: 27448
		// (get) Token: 0x0601AAC1 RID: 109249 RVA: 0x00274E4D File Offset: 0x0027304D
		// (set) Token: 0x0601AAC2 RID: 109250 RVA: 0x00274E5D File Offset: 0x0027305D
		public unsafe float ToonLightIntensityCurveScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroMoveLightV2.__PropertyOffset_ToonLightIntensityCurveScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroMoveLightV2.__PropertyOffset_ToonLightIntensityCurveScale) = value;
			}
		}

		// Token: 0x17006B39 RID: 27449
		// (get) Token: 0x0601AAC3 RID: 109251 RVA: 0x00274E6E File Offset: 0x0027306E
		// (set) Token: 0x0601AAC4 RID: 109252 RVA: 0x00274E7E File Offset: 0x0027307E
		public unsafe float ToonLightIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroMoveLightV2.__PropertyOffset_ToonLightIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroMoveLightV2.__PropertyOffset_ToonLightIntensity) = value;
			}
		}

		// Token: 0x17006B3A RID: 27450
		// (get) Token: 0x0601AAC5 RID: 109253 RVA: 0x00274E8F File Offset: 0x0027308F
		// (set) Token: 0x0601AAC6 RID: 109254 RVA: 0x00274EA3 File Offset: 0x002730A3
		public unsafe FColor ToonLightColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroMoveLightV2.__PropertyOffset_ToonLightColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroMoveLightV2.__PropertyOffset_ToonLightColor) = value;
			}
		}

		// Token: 0x17006B3B RID: 27451
		// (get) Token: 0x0601AAC7 RID: 109255 RVA: 0x00274EB8 File Offset: 0x002730B8
		// (set) Token: 0x0601AAC8 RID: 109256 RVA: 0x00274EC8 File Offset: 0x002730C8
		public unsafe float ToonShadowColorIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroMoveLightV2.__PropertyOffset_ToonShadowColorIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroMoveLightV2.__PropertyOffset_ToonShadowColorIntensity) = value;
			}
		}

		// Token: 0x17006B3C RID: 27452
		// (get) Token: 0x0601AAC9 RID: 109257 RVA: 0x00274ED9 File Offset: 0x002730D9
		// (set) Token: 0x0601AACA RID: 109258 RVA: 0x00274EE9 File Offset: 0x002730E9
		public unsafe float ToonBaseColorIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroMoveLightV2.__PropertyOffset_ToonBaseColorIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroMoveLightV2.__PropertyOffset_ToonBaseColorIntensity) = value;
			}
		}

		// Token: 0x17006B3D RID: 27453
		// (get) Token: 0x0601AACB RID: 109259 RVA: 0x00274EFA File Offset: 0x002730FA
		// (set) Token: 0x0601AACC RID: 109260 RVA: 0x00274F0A File Offset: 0x0027310A
		public unsafe float ToonRealTimeShadowIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroMoveLightV2.__PropertyOffset_ToonRealTimeShadowIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroMoveLightV2.__PropertyOffset_ToonRealTimeShadowIntensity) = value;
			}
		}

		// Token: 0x17006B3E RID: 27454
		// (get) Token: 0x0601AACD RID: 109261 RVA: 0x00274F1C File Offset: 0x0027311C
		// (set) Token: 0x0601AACE RID: 109262 RVA: 0x00274F55 File Offset: 0x00273155
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
					result = (this._ToonLightingChannels = new FLightingChannels(base.NativePtr + (IntPtr)AKuroMoveLightV2.__PropertyOffset_ToonLightingChannels, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FLightingChannels.StaticStruct(), base.NativePtr + (IntPtr)AKuroMoveLightV2.__PropertyOffset_ToonLightingChannels, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006B3F RID: 27455
		// (get) Token: 0x0601AACF RID: 109263 RVA: 0x00274F76 File Offset: 0x00273176
		// (set) Token: 0x0601AAD0 RID: 109264 RVA: 0x00274F86 File Offset: 0x00273186
		public unsafe bool bApplyToonHardLight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroMoveLightV2.__PropertyOffset_bApplyToonHardLight) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroMoveLightV2.__PropertyOffset_bApplyToonHardLight) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006B40 RID: 27456
		// (get) Token: 0x0601AAD1 RID: 109265 RVA: 0x00274F97 File Offset: 0x00273197
		// (set) Token: 0x0601AAD2 RID: 109266 RVA: 0x00274FA7 File Offset: 0x002731A7
		public unsafe float ToonHardLightBaseIntensityScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroMoveLightV2.__PropertyOffset_ToonHardLightBaseIntensityScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroMoveLightV2.__PropertyOffset_ToonHardLightBaseIntensityScale) = value;
			}
		}

		// Token: 0x17006B41 RID: 27457
		// (get) Token: 0x0601AAD3 RID: 109267 RVA: 0x00274FB8 File Offset: 0x002731B8
		// (set) Token: 0x0601AAD4 RID: 109268 RVA: 0x00274FC8 File Offset: 0x002731C8
		public unsafe float ToonHardLightIntensityCurveScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroMoveLightV2.__PropertyOffset_ToonHardLightIntensityCurveScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroMoveLightV2.__PropertyOffset_ToonHardLightIntensityCurveScale) = value;
			}
		}

		// Token: 0x17006B42 RID: 27458
		// (get) Token: 0x0601AAD5 RID: 109269 RVA: 0x00274FD9 File Offset: 0x002731D9
		// (set) Token: 0x0601AAD6 RID: 109270 RVA: 0x00274FE9 File Offset: 0x002731E9
		public unsafe float ToonHardShadowIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroMoveLightV2.__PropertyOffset_ToonHardShadowIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroMoveLightV2.__PropertyOffset_ToonHardShadowIntensity) = value;
			}
		}

		// Token: 0x17006B43 RID: 27459
		// (get) Token: 0x0601AAD7 RID: 109271 RVA: 0x00274FFA File Offset: 0x002731FA
		// (set) Token: 0x0601AAD8 RID: 109272 RVA: 0x0027500A File Offset: 0x0027320A
		public unsafe float ToonHardShadowRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroMoveLightV2.__PropertyOffset_ToonHardShadowRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroMoveLightV2.__PropertyOffset_ToonHardShadowRange) = value;
			}
		}

		// Token: 0x17006B44 RID: 27460
		// (get) Token: 0x0601AAD9 RID: 109273 RVA: 0x0027501B File Offset: 0x0027321B
		// (set) Token: 0x0601AADA RID: 109274 RVA: 0x0027502F File Offset: 0x0027322F
		public unsafe FLinearColor ToonHardBaseColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroMoveLightV2.__PropertyOffset_ToonHardBaseColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroMoveLightV2.__PropertyOffset_ToonHardBaseColor) = value;
			}
		}

		// Token: 0x17006B45 RID: 27461
		// (get) Token: 0x0601AADB RID: 109275 RVA: 0x00275044 File Offset: 0x00273244
		// (set) Token: 0x0601AADC RID: 109276 RVA: 0x00275058 File Offset: 0x00273258
		public unsafe FLinearColor ToonHardShadowColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroMoveLightV2.__PropertyOffset_ToonHardShadowColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroMoveLightV2.__PropertyOffset_ToonHardShadowColor) = value;
			}
		}

		// Token: 0x17006B46 RID: 27462
		// (get) Token: 0x0601AADD RID: 109277 RVA: 0x0027506D File Offset: 0x0027326D
		// (set) Token: 0x0601AADE RID: 109278 RVA: 0x0027507D File Offset: 0x0027327D
		public unsafe float ToonHardShadowBlend
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroMoveLightV2.__PropertyOffset_ToonHardShadowBlend);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroMoveLightV2.__PropertyOffset_ToonHardShadowBlend) = value;
			}
		}

		// Token: 0x17006B47 RID: 27463
		// (get) Token: 0x0601AADF RID: 109279 RVA: 0x0027508E File Offset: 0x0027328E
		// (set) Token: 0x0601AAE0 RID: 109280 RVA: 0x0027509E File Offset: 0x0027329E
		public unsafe bool bEnableTickThrottle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroMoveLightV2.__PropertyOffset_bEnableTickThrottle) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroMoveLightV2.__PropertyOffset_bEnableTickThrottle) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006B48 RID: 27464
		// (get) Token: 0x0601AAE1 RID: 109281 RVA: 0x002750AF File Offset: 0x002732AF
		// (set) Token: 0x0601AAE2 RID: 109282 RVA: 0x002750BF File Offset: 0x002732BF
		public unsafe float TickFactor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroMoveLightV2.__PropertyOffset_TickFactor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroMoveLightV2.__PropertyOffset_TickFactor) = value;
			}
		}

		// Token: 0x17006B49 RID: 27465
		// (get) Token: 0x0601AAE3 RID: 109283 RVA: 0x002750D0 File Offset: 0x002732D0
		// (set) Token: 0x0601AAE4 RID: 109284 RVA: 0x002750E0 File Offset: 0x002732E0
		public unsafe bool bTickInEditorViewport
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroMoveLightV2.__PropertyOffset_bTickInEditorViewport) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroMoveLightV2.__PropertyOffset_bTickInEditorViewport) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006B4A RID: 27466
		// (get) Token: 0x0601AAE5 RID: 109285 RVA: 0x002750F1 File Offset: 0x002732F1
		// (set) Token: 0x0601AAE6 RID: 109286 RVA: 0x00275105 File Offset: 0x00273305
		public unsafe UPointLightComponent PointLight
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPointLightComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroMoveLightV2.__PropertyOffset_PointLight);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroMoveLightV2.__PropertyOffset_PointLight, value);
			}
		}

		// Token: 0x17006B4B RID: 27467
		// (get) Token: 0x0601AAE7 RID: 109287 RVA: 0x0027511A File Offset: 0x0027331A
		// (set) Token: 0x0601AAE8 RID: 109288 RVA: 0x0027512E File Offset: 0x0027332E
		public unsafe UTextureRenderTarget2D EmissiveRenderTarget
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroMoveLightV2.__PropertyOffset_EmissiveRenderTarget);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroMoveLightV2.__PropertyOffset_EmissiveRenderTarget, value);
			}
		}

		// Token: 0x0601AAE9 RID: 109289 RVA: 0x00275143 File Offset: 0x00273343
		public USplineComponent ResolveSplineComponent()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<USplineComponent>(AKuroMoveLightV2.__ResolveSplineComponent_Internal(base.NativePtr));
		}

		// Token: 0x0601AAEA RID: 109290 RVA: 0x00275155 File Offset: 0x00273355
		public float GetCurrentIntensityCurve()
		{
			return AKuroMoveLightV2.__GetCurrentIntensityCurve_Internal(base.NativePtr);
		}

		// Token: 0x0601AAEB RID: 109291 RVA: 0x00275162 File Offset: 0x00273362
		public float GetCurrentBaseIntensity()
		{
			return AKuroMoveLightV2.__GetCurrentBaseIntensity_Internal(base.NativePtr);
		}

		// Token: 0x0601AAEC RID: 109292 RVA: 0x0027516F File Offset: 0x0027336F
		public void ApplyStaticLightProperties()
		{
			AKuroMoveLightV2.__ApplyStaticLightProperties_Internal(base.NativePtr);
		}

		// Token: 0x0601AAED RID: 109293
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __ResolveSplineComponent_Internal(IntPtr @this);

		// Token: 0x0601AAEE RID: 109294
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetCurrentIntensityCurve_Internal(IntPtr @this);

		// Token: 0x0601AAEF RID: 109295
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetCurrentBaseIntensity_Internal(IntPtr @this);

		// Token: 0x0601AAF0 RID: 109296
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ApplyStaticLightProperties_Internal(IntPtr @this);

		// Token: 0x0601AAF1 RID: 109297 RVA: 0x0027517C File Offset: 0x0027337C
		static AKuroMoveLightV2()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroMoveLightV2");
		}

		// Token: 0x0601AAF2 RID: 109298 RVA: 0x0027518A File Offset: 0x0027338A
		protected AKuroMoveLightV2(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400E6B3 RID: 59059
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroMoveLightV2";

		// Token: 0x0400E6B4 RID: 59060
		private static IntPtr _ClassPtr;

		// Token: 0x0400E6B5 RID: 59061
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400E6B6 RID: 59062
		internal static int __PropertyOffset_SplineSource;

		// Token: 0x0400E6B7 RID: 59063
		internal static int __PropertyOffset_bApplySplineMove;

		// Token: 0x0400E6B8 RID: 59064
		internal static int __PropertyOffset_MoveSpeed;

		// Token: 0x0400E6B9 RID: 59065
		internal static int __PropertyOffset_bLoopMode;

		// Token: 0x0400E6BA RID: 59066
		internal static int __PropertyOffset_Preset;

		// Token: 0x0400E6BB RID: 59067
		internal static int __PropertyOffset_BakedIntensityCurve;

		// Token: 0x0400E6BC RID: 59068
		private FKuroCurveFloat _BakedIntensityCurve;

		// Token: 0x0400E6BD RID: 59069
		internal static int __PropertyOffset_BaseIntensityScale;

		// Token: 0x0400E6BE RID: 59070
		internal static int __PropertyOffset_IntensityCurveScale;

		// Token: 0x0400E6BF RID: 59071
		internal static int __PropertyOffset_FlickSpeedScale;

		// Token: 0x0400E6C0 RID: 59072
		internal static int __PropertyOffset_AllIntensityScale;

		// Token: 0x0400E6C1 RID: 59073
		internal static int __PropertyOffset_LightColorSource;

		// Token: 0x0400E6C2 RID: 59074
		internal static int __PropertyOffset_SelfLightColor;

		// Token: 0x0400E6C3 RID: 59075
		internal static int __PropertyOffset_BakedColorCurve;

		// Token: 0x0400E6C4 RID: 59076
		internal static int __PropertyOffset_BakedColorBlendRatio;

		// Token: 0x0400E6C5 RID: 59077
		internal static int __PropertyOffset_EmissiveBakedColorCurve;

		// Token: 0x0400E6C6 RID: 59078
		internal static int __PropertyOffset_EmissiveBakedIntensityCurve;

		// Token: 0x0400E6C7 RID: 59079
		private FKuroCurveFloat _EmissiveBakedIntensityCurve;

		// Token: 0x0400E6C8 RID: 59080
		internal static int __PropertyOffset_EmissiveColorBlendRatio;

		// Token: 0x0400E6C9 RID: 59081
		internal static int __PropertyOffset_EmissiveIntensityBlendRatio;

		// Token: 0x0400E6CA RID: 59082
		internal static int __PropertyOffset_EmissiveIntensityScale;

		// Token: 0x0400E6CB RID: 59083
		internal static int __PropertyOffset_CurveTimeOffset;

		// Token: 0x0400E6CC RID: 59084
		internal static int __PropertyOffset_CurvePeriod;

		// Token: 0x0400E6CD RID: 59085
		internal static int __PropertyOffset_KuroMoveLightAttenuationRadius;

		// Token: 0x0400E6CE RID: 59086
		internal static int __PropertyOffset_KuroMoveLightAttenuation;

		// Token: 0x0400E6CF RID: 59087
		internal static int __PropertyOffset_SourceRadius;

		// Token: 0x0400E6D0 RID: 59088
		internal static int __PropertyOffset_SoftSourceRadius;

		// Token: 0x0400E6D1 RID: 59089
		internal static int __PropertyOffset_SourceLength;

		// Token: 0x0400E6D2 RID: 59090
		internal static int __PropertyOffset_SpecularScale;

		// Token: 0x0400E6D3 RID: 59091
		internal static int __PropertyOffset_bKuroMirrorAttenuation;

		// Token: 0x0400E6D4 RID: 59092
		internal static int __PropertyOffset_KuroAttenuationNearDist;

		// Token: 0x0400E6D5 RID: 59093
		internal static int __PropertyOffset_KuroAttenuationNearBlur;

		// Token: 0x0400E6D6 RID: 59094
		internal static int __PropertyOffset_KuroLightAttenuationShape;

		// Token: 0x0400E6D7 RID: 59095
		internal static int __PropertyOffset_KuroConeSize;

		// Token: 0x0400E6D8 RID: 59096
		internal static int __PropertyOffset_KuroConeBlurSize;

		// Token: 0x0400E6D9 RID: 59097
		internal static int __PropertyOffset_KuroRectSize;

		// Token: 0x0400E6DA RID: 59098
		internal static int __PropertyOffset_KuroRectBlurSize;

		// Token: 0x0400E6DB RID: 59099
		internal static int __PropertyOffset_ToonPointLightFallOff;

		// Token: 0x0400E6DC RID: 59100
		internal static int __PropertyOffset_bUsePointLightFallOffColor;

		// Token: 0x0400E6DD RID: 59101
		internal static int __PropertyOffset_ToonDistanceBlendAtten;

		// Token: 0x0400E6DE RID: 59102
		internal static int __PropertyOffset_ToonDistanceBlendIntensity;

		// Token: 0x0400E6DF RID: 59103
		internal static int __PropertyOffset_ToonLightType;

		// Token: 0x0400E6E0 RID: 59104
		internal static int __PropertyOffset_ToonLightingPriority;

		// Token: 0x0400E6E1 RID: 59105
		internal static int __PropertyOffset_bApplyToonLight;

		// Token: 0x0400E6E2 RID: 59106
		internal static int __PropertyOffset_ToonLightBaseIntensityScale;

		// Token: 0x0400E6E3 RID: 59107
		internal static int __PropertyOffset_ToonLightIntensityCurveScale;

		// Token: 0x0400E6E4 RID: 59108
		internal static int __PropertyOffset_ToonLightIntensity;

		// Token: 0x0400E6E5 RID: 59109
		internal static int __PropertyOffset_ToonLightColor;

		// Token: 0x0400E6E6 RID: 59110
		internal static int __PropertyOffset_ToonShadowColorIntensity;

		// Token: 0x0400E6E7 RID: 59111
		internal static int __PropertyOffset_ToonBaseColorIntensity;

		// Token: 0x0400E6E8 RID: 59112
		internal static int __PropertyOffset_ToonRealTimeShadowIntensity;

		// Token: 0x0400E6E9 RID: 59113
		internal static int __PropertyOffset_ToonLightingChannels;

		// Token: 0x0400E6EA RID: 59114
		private FLightingChannels _ToonLightingChannels;

		// Token: 0x0400E6EB RID: 59115
		internal static int __PropertyOffset_bApplyToonHardLight;

		// Token: 0x0400E6EC RID: 59116
		internal static int __PropertyOffset_ToonHardLightBaseIntensityScale;

		// Token: 0x0400E6ED RID: 59117
		internal static int __PropertyOffset_ToonHardLightIntensityCurveScale;

		// Token: 0x0400E6EE RID: 59118
		internal static int __PropertyOffset_ToonHardShadowIntensity;

		// Token: 0x0400E6EF RID: 59119
		internal static int __PropertyOffset_ToonHardShadowRange;

		// Token: 0x0400E6F0 RID: 59120
		internal static int __PropertyOffset_ToonHardBaseColor;

		// Token: 0x0400E6F1 RID: 59121
		internal static int __PropertyOffset_ToonHardShadowColor;

		// Token: 0x0400E6F2 RID: 59122
		internal static int __PropertyOffset_ToonHardShadowBlend;

		// Token: 0x0400E6F3 RID: 59123
		internal static int __PropertyOffset_bEnableTickThrottle;

		// Token: 0x0400E6F4 RID: 59124
		internal static int __PropertyOffset_TickFactor;

		// Token: 0x0400E6F5 RID: 59125
		internal static int __PropertyOffset_bTickInEditorViewport;

		// Token: 0x0400E6F6 RID: 59126
		internal static int __PropertyOffset_PointLight;

		// Token: 0x0400E6F7 RID: 59127
		internal static int __PropertyOffset_EmissiveRenderTarget;
	}
}
