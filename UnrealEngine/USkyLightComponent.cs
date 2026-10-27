using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001116 RID: 4374
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.SkyLightComponent")]
	[UnrealStructLayout(1760, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1760)]
	public class USkyLightComponent : ULightComponentBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600FEC3 RID: 65219 RVA: 0x00177CE1 File Offset: 0x00175EE1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USkyLightComponent._ClassPtr;
		}

		// Token: 0x0600FEC4 RID: 65220 RVA: 0x00177CF0 File Offset: 0x00175EF0
		public USkyLightComponent() : this(BuiltinUtils.AllocNativeUObject(USkyLightComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600FEC5 RID: 65221 RVA: 0x00177D18 File Offset: 0x00175F18
		[NullableContext(1)]
		public USkyLightComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USkyLightComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003E22 RID: 15906
		// (get) Token: 0x0600FEC6 RID: 65222 RVA: 0x00177D4B File Offset: 0x00175F4B
		// (set) Token: 0x0600FEC7 RID: 65223 RVA: 0x00177D5B File Offset: 0x00175F5B
		public unsafe bool bRealTimeCapture
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_bRealTimeCapture) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_bRealTimeCapture) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003E23 RID: 15907
		// (get) Token: 0x0600FEC8 RID: 65224 RVA: 0x00177D6C File Offset: 0x00175F6C
		// (set) Token: 0x0600FEC9 RID: 65225 RVA: 0x00177D80 File Offset: 0x00175F80
		[Nullable(0)]
		public unsafe TEnumAsByte<ESkyLightSourceType> SourceType
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_SourceType);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_SourceType) = value;
			}
		}

		// Token: 0x17003E24 RID: 15908
		// (get) Token: 0x0600FECA RID: 65226 RVA: 0x00177D95 File Offset: 0x00175F95
		// (set) Token: 0x0600FECB RID: 65227 RVA: 0x00177DA9 File Offset: 0x00175FA9
		public unsafe UTextureCube Cubemap
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureCube>(base.NativePtr / (IntPtr)sizeof(void*) + USkyLightComponent.__PropertyOffset_Cubemap);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + USkyLightComponent.__PropertyOffset_Cubemap, value);
			}
		}

		// Token: 0x17003E25 RID: 15909
		// (get) Token: 0x0600FECC RID: 65228 RVA: 0x00177DBE File Offset: 0x00175FBE
		// (set) Token: 0x0600FECD RID: 65229 RVA: 0x00177DCE File Offset: 0x00175FCE
		public unsafe float SourceCubemapAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_SourceCubemapAngle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_SourceCubemapAngle) = value;
			}
		}

		// Token: 0x17003E26 RID: 15910
		// (get) Token: 0x0600FECE RID: 65230 RVA: 0x00177DDF File Offset: 0x00175FDF
		// (set) Token: 0x0600FECF RID: 65231 RVA: 0x00177DEF File Offset: 0x00175FEF
		public unsafe int CubemapResolution
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_CubemapResolution);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_CubemapResolution) = value;
			}
		}

		// Token: 0x17003E27 RID: 15911
		// (get) Token: 0x0600FED0 RID: 65232 RVA: 0x00177E00 File Offset: 0x00176000
		// (set) Token: 0x0600FED1 RID: 65233 RVA: 0x00177E10 File Offset: 0x00176010
		public unsafe float SkyDistanceThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_SkyDistanceThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_SkyDistanceThreshold) = value;
			}
		}

		// Token: 0x17003E28 RID: 15912
		// (get) Token: 0x0600FED2 RID: 65234 RVA: 0x00177E21 File Offset: 0x00176021
		// (set) Token: 0x0600FED3 RID: 65235 RVA: 0x00177E31 File Offset: 0x00176031
		public unsafe bool bCaptureEmissiveOnly
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_bCaptureEmissiveOnly) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_bCaptureEmissiveOnly) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003E29 RID: 15913
		// (get) Token: 0x0600FED4 RID: 65236 RVA: 0x00177E42 File Offset: 0x00176042
		// (set) Token: 0x0600FED5 RID: 65237 RVA: 0x00177E52 File Offset: 0x00176052
		public unsafe bool bLowerHemisphereIsBlack
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_bLowerHemisphereIsBlack) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_bLowerHemisphereIsBlack) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003E2A RID: 15914
		// (get) Token: 0x0600FED6 RID: 65238 RVA: 0x00177E63 File Offset: 0x00176063
		// (set) Token: 0x0600FED7 RID: 65239 RVA: 0x00177E77 File Offset: 0x00176077
		public unsafe FLinearColor LowerHemisphereColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_LowerHemisphereColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_LowerHemisphereColor) = value;
			}
		}

		// Token: 0x17003E2B RID: 15915
		// (get) Token: 0x0600FED8 RID: 65240 RVA: 0x00177E8C File Offset: 0x0017608C
		// (set) Token: 0x0600FED9 RID: 65241 RVA: 0x00177E9C File Offset: 0x0017609C
		public unsafe float OcclusionMaxDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_OcclusionMaxDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_OcclusionMaxDistance) = value;
			}
		}

		// Token: 0x17003E2C RID: 15916
		// (get) Token: 0x0600FEDA RID: 65242 RVA: 0x00177EAD File Offset: 0x001760AD
		// (set) Token: 0x0600FEDB RID: 65243 RVA: 0x00177EBD File Offset: 0x001760BD
		public unsafe float Contrast
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_Contrast);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_Contrast) = value;
			}
		}

		// Token: 0x17003E2D RID: 15917
		// (get) Token: 0x0600FEDC RID: 65244 RVA: 0x00177ECE File Offset: 0x001760CE
		// (set) Token: 0x0600FEDD RID: 65245 RVA: 0x00177EDE File Offset: 0x001760DE
		public unsafe float OcclusionExponent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_OcclusionExponent);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_OcclusionExponent) = value;
			}
		}

		// Token: 0x17003E2E RID: 15918
		// (get) Token: 0x0600FEDE RID: 65246 RVA: 0x00177EEF File Offset: 0x001760EF
		// (set) Token: 0x0600FEDF RID: 65247 RVA: 0x00177EFF File Offset: 0x001760FF
		public unsafe float MinOcclusion
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_MinOcclusion);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_MinOcclusion) = value;
			}
		}

		// Token: 0x17003E2F RID: 15919
		// (get) Token: 0x0600FEE0 RID: 65248 RVA: 0x00177F10 File Offset: 0x00176110
		// (set) Token: 0x0600FEE1 RID: 65249 RVA: 0x00177F24 File Offset: 0x00176124
		public unsafe FColor OcclusionTint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_OcclusionTint);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_OcclusionTint) = value;
			}
		}

		// Token: 0x17003E30 RID: 15920
		// (get) Token: 0x0600FEE2 RID: 65250 RVA: 0x00177F39 File Offset: 0x00176139
		// (set) Token: 0x0600FEE3 RID: 65251 RVA: 0x00177F52 File Offset: 0x00176152
		public unsafe bool bCloudAmbientOcclusion
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_bCloudAmbientOcclusion) & USkyLightComponent.__PropertyMask_bCloudAmbientOcclusion) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_bCloudAmbientOcclusion) = ((*(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_bCloudAmbientOcclusion) & ~USkyLightComponent.__PropertyMask_bCloudAmbientOcclusion) | (value ? USkyLightComponent.__PropertyMask_bCloudAmbientOcclusion : 0));
			}
		}

		// Token: 0x17003E31 RID: 15921
		// (get) Token: 0x0600FEE4 RID: 65252 RVA: 0x00177F82 File Offset: 0x00176182
		// (set) Token: 0x0600FEE5 RID: 65253 RVA: 0x00177F92 File Offset: 0x00176192
		public unsafe float CloudAmbientOcclusionStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_CloudAmbientOcclusionStrength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_CloudAmbientOcclusionStrength) = value;
			}
		}

		// Token: 0x17003E32 RID: 15922
		// (get) Token: 0x0600FEE6 RID: 65254 RVA: 0x00177FA3 File Offset: 0x001761A3
		// (set) Token: 0x0600FEE7 RID: 65255 RVA: 0x00177FB3 File Offset: 0x001761B3
		public unsafe float CloudAmbientOcclusionExtent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_CloudAmbientOcclusionExtent);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_CloudAmbientOcclusionExtent) = value;
			}
		}

		// Token: 0x17003E33 RID: 15923
		// (get) Token: 0x0600FEE8 RID: 65256 RVA: 0x00177FC4 File Offset: 0x001761C4
		// (set) Token: 0x0600FEE9 RID: 65257 RVA: 0x00177FD4 File Offset: 0x001761D4
		public unsafe float CloudAmbientOcclusionMapResolutionScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_CloudAmbientOcclusionMapResolutionScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_CloudAmbientOcclusionMapResolutionScale) = value;
			}
		}

		// Token: 0x17003E34 RID: 15924
		// (get) Token: 0x0600FEEA RID: 65258 RVA: 0x00177FE5 File Offset: 0x001761E5
		// (set) Token: 0x0600FEEB RID: 65259 RVA: 0x00177FF5 File Offset: 0x001761F5
		public unsafe float CloudAmbientOcclusionApertureScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_CloudAmbientOcclusionApertureScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_CloudAmbientOcclusionApertureScale) = value;
			}
		}

		// Token: 0x17003E35 RID: 15925
		// (get) Token: 0x0600FEEC RID: 65260 RVA: 0x00178006 File Offset: 0x00176206
		// (set) Token: 0x0600FEED RID: 65261 RVA: 0x0017801A File Offset: 0x0017621A
		[Nullable(0)]
		public unsafe TEnumAsByte<EOcclusionCombineMode> OcclusionCombineMode
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_OcclusionCombineMode);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_OcclusionCombineMode) = value;
			}
		}

		// Token: 0x17003E36 RID: 15926
		// (get) Token: 0x0600FEEE RID: 65262 RVA: 0x0017802F File Offset: 0x0017622F
		// (set) Token: 0x0600FEEF RID: 65263 RVA: 0x00178043 File Offset: 0x00176243
		public unsafe UTextureCube DefaultKuroCubemap
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureCube>(base.NativePtr / (IntPtr)sizeof(void*) + USkyLightComponent.__PropertyOffset_DefaultKuroCubemap);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + USkyLightComponent.__PropertyOffset_DefaultKuroCubemap, value);
			}
		}

		// Token: 0x17003E37 RID: 15927
		// (get) Token: 0x0600FEF0 RID: 65264 RVA: 0x00178058 File Offset: 0x00176258
		// (set) Token: 0x0600FEF1 RID: 65265 RVA: 0x0017806C File Offset: 0x0017626C
		public unsafe FVector KuroLightProbeSH1_Default
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_KuroLightProbeSH1_Default);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_KuroLightProbeSH1_Default) = value;
			}
		}

		// Token: 0x17003E38 RID: 15928
		// (get) Token: 0x0600FEF2 RID: 65266 RVA: 0x00178081 File Offset: 0x00176281
		// (set) Token: 0x0600FEF3 RID: 65267 RVA: 0x00178095 File Offset: 0x00176295
		public unsafe FVector KuroLightProbeSH2_Default
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_KuroLightProbeSH2_Default);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_KuroLightProbeSH2_Default) = value;
			}
		}

		// Token: 0x17003E39 RID: 15929
		// (get) Token: 0x0600FEF4 RID: 65268 RVA: 0x001780AA File Offset: 0x001762AA
		// (set) Token: 0x0600FEF5 RID: 65269 RVA: 0x001780BE File Offset: 0x001762BE
		public unsafe FVector KuroLightProbeSH3_Default
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_KuroLightProbeSH3_Default);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_KuroLightProbeSH3_Default) = value;
			}
		}

		// Token: 0x17003E3A RID: 15930
		// (get) Token: 0x0600FEF6 RID: 65270 RVA: 0x001780D3 File Offset: 0x001762D3
		// (set) Token: 0x0600FEF7 RID: 65271 RVA: 0x001780E7 File Offset: 0x001762E7
		public unsafe FVector KuroLightProbeSH4_Default
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_KuroLightProbeSH4_Default);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_KuroLightProbeSH4_Default) = value;
			}
		}

		// Token: 0x17003E3B RID: 15931
		// (get) Token: 0x0600FEF8 RID: 65272 RVA: 0x001780FC File Offset: 0x001762FC
		// (set) Token: 0x0600FEF9 RID: 65273 RVA: 0x00178110 File Offset: 0x00176310
		public unsafe FVector KuroLightProbeSH5_Default
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_KuroLightProbeSH5_Default);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_KuroLightProbeSH5_Default) = value;
			}
		}

		// Token: 0x17003E3C RID: 15932
		// (get) Token: 0x0600FEFA RID: 65274 RVA: 0x00178125 File Offset: 0x00176325
		// (set) Token: 0x0600FEFB RID: 65275 RVA: 0x00178139 File Offset: 0x00176339
		public unsafe FVector KuroLightProbeSH6_Default
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_KuroLightProbeSH6_Default);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_KuroLightProbeSH6_Default) = value;
			}
		}

		// Token: 0x17003E3D RID: 15933
		// (get) Token: 0x0600FEFC RID: 65276 RVA: 0x0017814E File Offset: 0x0017634E
		// (set) Token: 0x0600FEFD RID: 65277 RVA: 0x0017815E File Offset: 0x0017635E
		public unsafe bool bUseKuroSkyLight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_bUseKuroSkyLight) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_bUseKuroSkyLight) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003E3E RID: 15934
		// (get) Token: 0x0600FEFE RID: 65278 RVA: 0x0017816F File Offset: 0x0017636F
		// (set) Token: 0x0600FEFF RID: 65279 RVA: 0x0017817F File Offset: 0x0017637F
		public unsafe float KuroSkyLightTranslucent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_KuroSkyLightTranslucent);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_KuroSkyLightTranslucent) = value;
			}
		}

		// Token: 0x17003E3F RID: 15935
		// (get) Token: 0x0600FF00 RID: 65280 RVA: 0x00178190 File Offset: 0x00176390
		// (set) Token: 0x0600FF01 RID: 65281 RVA: 0x001781A0 File Offset: 0x001763A0
		public unsafe float KuroSkyLightIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_KuroSkyLightIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_KuroSkyLightIntensity) = value;
			}
		}

		// Token: 0x17003E40 RID: 15936
		// (get) Token: 0x0600FF02 RID: 65282 RVA: 0x001781B1 File Offset: 0x001763B1
		// (set) Token: 0x0600FF03 RID: 65283 RVA: 0x001781C5 File Offset: 0x001763C5
		public unsafe FLinearColor KuroSkyLightColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_KuroSkyLightColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_KuroSkyLightColor) = value;
			}
		}

		// Token: 0x17003E41 RID: 15937
		// (get) Token: 0x0600FF04 RID: 65284 RVA: 0x001781DA File Offset: 0x001763DA
		// (set) Token: 0x0600FF05 RID: 65285 RVA: 0x001781EE File Offset: 0x001763EE
		public unsafe FLinearColor KuroAOColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_KuroAOColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_KuroAOColor) = value;
			}
		}

		// Token: 0x17003E42 RID: 15938
		// (get) Token: 0x0600FF06 RID: 65286 RVA: 0x00178203 File Offset: 0x00176403
		// (set) Token: 0x0600FF07 RID: 65287 RVA: 0x00178213 File Offset: 0x00176413
		public unsafe float KuroInteriorSkyLightIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_KuroInteriorSkyLightIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_KuroInteriorSkyLightIntensity) = value;
			}
		}

		// Token: 0x17003E43 RID: 15939
		// (get) Token: 0x0600FF08 RID: 65288 RVA: 0x00178224 File Offset: 0x00176424
		// (set) Token: 0x0600FF09 RID: 65289 RVA: 0x00178238 File Offset: 0x00176438
		public unsafe FLinearColor KuroInteriorSkyLightColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_KuroInteriorSkyLightColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_KuroInteriorSkyLightColor) = value;
			}
		}

		// Token: 0x17003E44 RID: 15940
		// (get) Token: 0x0600FF0A RID: 65290 RVA: 0x0017824D File Offset: 0x0017644D
		// (set) Token: 0x0600FF0B RID: 65291 RVA: 0x00178261 File Offset: 0x00176461
		public unsafe FLinearColor KuroNearSkyLightColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_KuroNearSkyLightColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_KuroNearSkyLightColor) = value;
			}
		}

		// Token: 0x17003E45 RID: 15941
		// (get) Token: 0x0600FF0C RID: 65292 RVA: 0x00178276 File Offset: 0x00176476
		// (set) Token: 0x0600FF0D RID: 65293 RVA: 0x00178286 File Offset: 0x00176486
		public unsafe float KuroMainLightSpecularIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_KuroMainLightSpecularIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_KuroMainLightSpecularIntensity) = value;
			}
		}

		// Token: 0x17003E46 RID: 15942
		// (get) Token: 0x0600FF0E RID: 65294 RVA: 0x00178297 File Offset: 0x00176497
		// (set) Token: 0x0600FF0F RID: 65295 RVA: 0x001782A7 File Offset: 0x001764A7
		public unsafe float KuroDirLightSpecularIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_KuroDirLightSpecularIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_KuroDirLightSpecularIntensity) = value;
			}
		}

		// Token: 0x17003E47 RID: 15943
		// (get) Token: 0x0600FF10 RID: 65296 RVA: 0x001782B8 File Offset: 0x001764B8
		// (set) Token: 0x0600FF11 RID: 65297 RVA: 0x001782C8 File Offset: 0x001764C8
		public unsafe float KuroMainLightSpecularMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_KuroMainLightSpecularMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_KuroMainLightSpecularMax) = value;
			}
		}

		// Token: 0x17003E48 RID: 15944
		// (get) Token: 0x0600FF12 RID: 65298 RVA: 0x001782D9 File Offset: 0x001764D9
		// (set) Token: 0x0600FF13 RID: 65299 RVA: 0x001782E9 File Offset: 0x001764E9
		public unsafe float KuroSkyLightSpecularIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_KuroSkyLightSpecularIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_KuroSkyLightSpecularIntensity) = value;
			}
		}

		// Token: 0x17003E49 RID: 15945
		// (get) Token: 0x0600FF14 RID: 65300 RVA: 0x001782FA File Offset: 0x001764FA
		// (set) Token: 0x0600FF15 RID: 65301 RVA: 0x0017830A File Offset: 0x0017650A
		public unsafe float KuroSkyLightShadowIntSupplement
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_KuroSkyLightShadowIntSupplement);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_KuroSkyLightShadowIntSupplement) = value;
			}
		}

		// Token: 0x17003E4A RID: 15946
		// (get) Token: 0x0600FF16 RID: 65302 RVA: 0x0017831B File Offset: 0x0017651B
		// (set) Token: 0x0600FF17 RID: 65303 RVA: 0x0017832B File Offset: 0x0017652B
		public unsafe float KuroSkyLightShadowIntSupplementDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_KuroSkyLightShadowIntSupplementDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_KuroSkyLightShadowIntSupplementDistance) = value;
			}
		}

		// Token: 0x17003E4B RID: 15947
		// (get) Token: 0x0600FF18 RID: 65304 RVA: 0x0017833C File Offset: 0x0017653C
		// (set) Token: 0x0600FF19 RID: 65305 RVA: 0x0017834C File Offset: 0x0017654C
		public unsafe float KuroMetallicSpecularAddIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_KuroMetallicSpecularAddIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_KuroMetallicSpecularAddIntensity) = value;
			}
		}

		// Token: 0x17003E4C RID: 15948
		// (get) Token: 0x0600FF1A RID: 65306 RVA: 0x0017835D File Offset: 0x0017655D
		// (set) Token: 0x0600FF1B RID: 65307 RVA: 0x0017836D File Offset: 0x0017656D
		public unsafe float KuroMetallicReflectionAddIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_KuroMetallicReflectionAddIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_KuroMetallicReflectionAddIntensity) = value;
			}
		}

		// Token: 0x17003E4D RID: 15949
		// (get) Token: 0x0600FF1C RID: 65308 RVA: 0x0017837E File Offset: 0x0017657E
		// (set) Token: 0x0600FF1D RID: 65309 RVA: 0x0017838E File Offset: 0x0017658E
		public unsafe float KuroMetallicMaskStep
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_KuroMetallicMaskStep);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_KuroMetallicMaskStep) = value;
			}
		}

		// Token: 0x17003E4E RID: 15950
		// (get) Token: 0x0600FF1E RID: 65310 RVA: 0x0017839F File Offset: 0x0017659F
		// (set) Token: 0x0600FF1F RID: 65311 RVA: 0x001783B3 File Offset: 0x001765B3
		public unsafe FVector4 KuroMetalCubeMapBoost
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_KuroMetalCubeMapBoost);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_KuroMetalCubeMapBoost) = value;
			}
		}

		// Token: 0x17003E4F RID: 15951
		// (get) Token: 0x0600FF20 RID: 65312 RVA: 0x001783C8 File Offset: 0x001765C8
		// (set) Token: 0x0600FF21 RID: 65313 RVA: 0x001783DC File Offset: 0x001765DC
		public unsafe UTextureCube MaterialDynamicReflectionTexture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureCube>(base.NativePtr / (IntPtr)sizeof(void*) + USkyLightComponent.__PropertyOffset_MaterialDynamicReflectionTexture);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + USkyLightComponent.__PropertyOffset_MaterialDynamicReflectionTexture, value);
			}
		}

		// Token: 0x17003E50 RID: 15952
		// (get) Token: 0x0600FF22 RID: 65314 RVA: 0x001783F1 File Offset: 0x001765F1
		// (set) Token: 0x0600FF23 RID: 65315 RVA: 0x00178405 File Offset: 0x00176605
		public unsafe FVector KuroLightProbeSH1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_KuroLightProbeSH1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_KuroLightProbeSH1) = value;
			}
		}

		// Token: 0x17003E51 RID: 15953
		// (get) Token: 0x0600FF24 RID: 65316 RVA: 0x0017841A File Offset: 0x0017661A
		// (set) Token: 0x0600FF25 RID: 65317 RVA: 0x0017842E File Offset: 0x0017662E
		public unsafe FVector KuroLightProbeSH2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_KuroLightProbeSH2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_KuroLightProbeSH2) = value;
			}
		}

		// Token: 0x17003E52 RID: 15954
		// (get) Token: 0x0600FF26 RID: 65318 RVA: 0x00178443 File Offset: 0x00176643
		// (set) Token: 0x0600FF27 RID: 65319 RVA: 0x00178457 File Offset: 0x00176657
		public unsafe FVector KuroLightProbeSH3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_KuroLightProbeSH3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_KuroLightProbeSH3) = value;
			}
		}

		// Token: 0x17003E53 RID: 15955
		// (get) Token: 0x0600FF28 RID: 65320 RVA: 0x0017846C File Offset: 0x0017666C
		// (set) Token: 0x0600FF29 RID: 65321 RVA: 0x00178480 File Offset: 0x00176680
		public unsafe FVector KuroLightProbeSH4
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_KuroLightProbeSH4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_KuroLightProbeSH4) = value;
			}
		}

		// Token: 0x17003E54 RID: 15956
		// (get) Token: 0x0600FF2A RID: 65322 RVA: 0x00178495 File Offset: 0x00176695
		// (set) Token: 0x0600FF2B RID: 65323 RVA: 0x001784A9 File Offset: 0x001766A9
		public unsafe FVector KuroLightProbeSH5
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_KuroLightProbeSH5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_KuroLightProbeSH5) = value;
			}
		}

		// Token: 0x17003E55 RID: 15957
		// (get) Token: 0x0600FF2C RID: 65324 RVA: 0x001784BE File Offset: 0x001766BE
		// (set) Token: 0x0600FF2D RID: 65325 RVA: 0x001784D2 File Offset: 0x001766D2
		public unsafe FVector KuroLightProbeSH6
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_KuroLightProbeSH6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_KuroLightProbeSH6) = value;
			}
		}

		// Token: 0x17003E56 RID: 15958
		// (get) Token: 0x0600FF2E RID: 65326 RVA: 0x001784E7 File Offset: 0x001766E7
		// (set) Token: 0x0600FF2F RID: 65327 RVA: 0x001784F7 File Offset: 0x001766F7
		public unsafe float KuroBlend12
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_KuroBlend12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_KuroBlend12) = value;
			}
		}

		// Token: 0x17003E57 RID: 15959
		// (get) Token: 0x0600FF30 RID: 65328 RVA: 0x00178508 File Offset: 0x00176708
		// (set) Token: 0x0600FF31 RID: 65329 RVA: 0x00178518 File Offset: 0x00176718
		public unsafe float KuroBlend23
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_KuroBlend23);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_KuroBlend23) = value;
			}
		}

		// Token: 0x17003E58 RID: 15960
		// (get) Token: 0x0600FF32 RID: 65330 RVA: 0x00178529 File Offset: 0x00176729
		// (set) Token: 0x0600FF33 RID: 65331 RVA: 0x0017853D File Offset: 0x0017673D
		public unsafe UTextureCube KuroCubemap_Layer1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureCube>(base.NativePtr / (IntPtr)sizeof(void*) + USkyLightComponent.__PropertyOffset_KuroCubemap_Layer1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + USkyLightComponent.__PropertyOffset_KuroCubemap_Layer1, value);
			}
		}

		// Token: 0x17003E59 RID: 15961
		// (get) Token: 0x0600FF34 RID: 65332 RVA: 0x00178552 File Offset: 0x00176752
		// (set) Token: 0x0600FF35 RID: 65333 RVA: 0x00178566 File Offset: 0x00176766
		public unsafe UTextureCube KuroCubemap_Layer2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureCube>(base.NativePtr / (IntPtr)sizeof(void*) + USkyLightComponent.__PropertyOffset_KuroCubemap_Layer2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + USkyLightComponent.__PropertyOffset_KuroCubemap_Layer2, value);
			}
		}

		// Token: 0x17003E5A RID: 15962
		// (get) Token: 0x0600FF36 RID: 65334 RVA: 0x0017857B File Offset: 0x0017677B
		// (set) Token: 0x0600FF37 RID: 65335 RVA: 0x0017858F File Offset: 0x0017678F
		public unsafe UTextureCube KuroCubemap_Layer3
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureCube>(base.NativePtr / (IntPtr)sizeof(void*) + USkyLightComponent.__PropertyOffset_KuroCubemap_Layer3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + USkyLightComponent.__PropertyOffset_KuroCubemap_Layer3, value);
			}
		}

		// Token: 0x17003E5B RID: 15963
		// (get) Token: 0x0600FF38 RID: 65336 RVA: 0x001785A4 File Offset: 0x001767A4
		// (set) Token: 0x0600FF39 RID: 65337 RVA: 0x001785B4 File Offset: 0x001767B4
		public unsafe float KuroCharacterSSSIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_KuroCharacterSSSIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_KuroCharacterSSSIntensity) = value;
			}
		}

		// Token: 0x17003E5C RID: 15964
		// (get) Token: 0x0600FF3A RID: 65338 RVA: 0x001785C5 File Offset: 0x001767C5
		// (set) Token: 0x0600FF3B RID: 65339 RVA: 0x001785D5 File Offset: 0x001767D5
		public unsafe float KuroCharacterGlobalShadowIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_KuroCharacterGlobalShadowIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_KuroCharacterGlobalShadowIntensity) = value;
			}
		}

		// Token: 0x17003E5D RID: 15965
		// (get) Token: 0x0600FF3C RID: 65340 RVA: 0x001785E6 File Offset: 0x001767E6
		// (set) Token: 0x0600FF3D RID: 65341 RVA: 0x001785F6 File Offset: 0x001767F6
		public unsafe float KuroCharacterGlobalBossShadowIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_KuroCharacterGlobalBossShadowIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_KuroCharacterGlobalBossShadowIntensity) = value;
			}
		}

		// Token: 0x17003E5E RID: 15966
		// (get) Token: 0x0600FF3E RID: 65342 RVA: 0x00178607 File Offset: 0x00176807
		// (set) Token: 0x0600FF3F RID: 65343 RVA: 0x0017861B File Offset: 0x0017681B
		public unsafe FVector2D KuroCharacterGlobalBossShadowRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_KuroCharacterGlobalBossShadowRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_KuroCharacterGlobalBossShadowRange) = value;
			}
		}

		// Token: 0x17003E5F RID: 15967
		// (get) Token: 0x0600FF40 RID: 65344 RVA: 0x00178630 File Offset: 0x00176830
		// (set) Token: 0x0600FF41 RID: 65345 RVA: 0x00178640 File Offset: 0x00176840
		public unsafe float KuroUseNewCharacterRim
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_KuroUseNewCharacterRim);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_KuroUseNewCharacterRim) = value;
			}
		}

		// Token: 0x17003E60 RID: 15968
		// (get) Token: 0x0600FF42 RID: 65346 RVA: 0x00178651 File Offset: 0x00176851
		// (set) Token: 0x0600FF43 RID: 65347 RVA: 0x00178665 File Offset: 0x00176865
		public unsafe FLinearColor KuroCharacterAmbientColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_KuroCharacterAmbientColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_KuroCharacterAmbientColor) = value;
			}
		}

		// Token: 0x17003E61 RID: 15969
		// (get) Token: 0x0600FF44 RID: 65348 RVA: 0x0017867A File Offset: 0x0017687A
		// (set) Token: 0x0600FF45 RID: 65349 RVA: 0x0017868E File Offset: 0x0017688E
		public unsafe FLinearColor KuroCharacterMainLightColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_KuroCharacterMainLightColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_KuroCharacterMainLightColor) = value;
			}
		}

		// Token: 0x17003E62 RID: 15970
		// (get) Token: 0x0600FF46 RID: 65350 RVA: 0x001786A3 File Offset: 0x001768A3
		// (set) Token: 0x0600FF47 RID: 65351 RVA: 0x001786B3 File Offset: 0x001768B3
		public unsafe float NearCharDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_NearCharDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_NearCharDistance) = value;
			}
		}

		// Token: 0x17003E63 RID: 15971
		// (get) Token: 0x0600FF48 RID: 65352 RVA: 0x001786C4 File Offset: 0x001768C4
		// (set) Token: 0x0600FF49 RID: 65353 RVA: 0x001786D4 File Offset: 0x001768D4
		public unsafe float NearCharDistanceSoft
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_NearCharDistanceSoft);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_NearCharDistanceSoft) = value;
			}
		}

		// Token: 0x17003E64 RID: 15972
		// (get) Token: 0x0600FF4A RID: 65354 RVA: 0x001786E5 File Offset: 0x001768E5
		// (set) Token: 0x0600FF4B RID: 65355 RVA: 0x001786F9 File Offset: 0x001768F9
		public unsafe FLinearColor NearCharLightColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_NearCharLightColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_NearCharLightColor) = value;
			}
		}

		// Token: 0x17003E65 RID: 15973
		// (get) Token: 0x0600FF4C RID: 65356 RVA: 0x0017870E File Offset: 0x0017690E
		// (set) Token: 0x0600FF4D RID: 65357 RVA: 0x00178722 File Offset: 0x00176922
		public unsafe FLinearColor NearCharShadowColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_NearCharShadowColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_NearCharShadowColor) = value;
			}
		}

		// Token: 0x17003E66 RID: 15974
		// (get) Token: 0x0600FF4E RID: 65358 RVA: 0x00178737 File Offset: 0x00176937
		// (set) Token: 0x0600FF4F RID: 65359 RVA: 0x0017874B File Offset: 0x0017694B
		public unsafe FLinearColor KuroCharacterRimColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_KuroCharacterRimColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_KuroCharacterRimColor) = value;
			}
		}

		// Token: 0x17003E67 RID: 15975
		// (get) Token: 0x0600FF50 RID: 65360 RVA: 0x00178760 File Offset: 0x00176960
		// (set) Token: 0x0600FF51 RID: 65361 RVA: 0x00178774 File Offset: 0x00176974
		public unsafe FVector4 KuroCharRimDir
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_KuroCharRimDir);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_KuroCharRimDir) = value;
			}
		}

		// Token: 0x17003E68 RID: 15976
		// (get) Token: 0x0600FF52 RID: 65362 RVA: 0x00178789 File Offset: 0x00176989
		// (set) Token: 0x0600FF53 RID: 65363 RVA: 0x00178799 File Offset: 0x00176999
		public unsafe float KuroTreeOutLineRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_KuroTreeOutLineRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_KuroTreeOutLineRadius) = value;
			}
		}

		// Token: 0x17003E69 RID: 15977
		// (get) Token: 0x0600FF54 RID: 65364 RVA: 0x001787AA File Offset: 0x001769AA
		// (set) Token: 0x0600FF55 RID: 65365 RVA: 0x001787BA File Offset: 0x001769BA
		public unsafe float KuroTreeOutLineDistanceRatio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_KuroTreeOutLineDistanceRatio);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_KuroTreeOutLineDistanceRatio) = value;
			}
		}

		// Token: 0x17003E6A RID: 15978
		// (get) Token: 0x0600FF56 RID: 65366 RVA: 0x001787CB File Offset: 0x001769CB
		// (set) Token: 0x0600FF57 RID: 65367 RVA: 0x001787DB File Offset: 0x001769DB
		public unsafe float KuroTreeOutLineFarScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_KuroTreeOutLineFarScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_KuroTreeOutLineFarScale) = value;
			}
		}

		// Token: 0x17003E6B RID: 15979
		// (get) Token: 0x0600FF58 RID: 65368 RVA: 0x001787EC File Offset: 0x001769EC
		// (set) Token: 0x0600FF59 RID: 65369 RVA: 0x00178800 File Offset: 0x00176A00
		public unsafe FLinearColor KuroTreeOutLineInnerColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_KuroTreeOutLineInnerColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_KuroTreeOutLineInnerColor) = value;
			}
		}

		// Token: 0x17003E6C RID: 15980
		// (get) Token: 0x0600FF5A RID: 65370 RVA: 0x00178815 File Offset: 0x00176A15
		// (set) Token: 0x0600FF5B RID: 65371 RVA: 0x00178829 File Offset: 0x00176A29
		public unsafe FLinearColor KuroTreeOutLineOuterColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_KuroTreeOutLineOuterColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_KuroTreeOutLineOuterColor) = value;
			}
		}

		// Token: 0x17003E6D RID: 15981
		// (get) Token: 0x0600FF5C RID: 65372 RVA: 0x0017883E File Offset: 0x00176A3E
		// (set) Token: 0x0600FF5D RID: 65373 RVA: 0x0017884E File Offset: 0x00176A4E
		public unsafe float KuroTreeOutLineOuterScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_KuroTreeOutLineOuterScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_KuroTreeOutLineOuterScale) = value;
			}
		}

		// Token: 0x17003E6E RID: 15982
		// (get) Token: 0x0600FF5E RID: 65374 RVA: 0x0017885F File Offset: 0x00176A5F
		// (set) Token: 0x0600FF5F RID: 65375 RVA: 0x0017886F File Offset: 0x00176A6F
		public unsafe float KuroTreeOutLineNearFarDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_KuroTreeOutLineNearFarDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_KuroTreeOutLineNearFarDistance) = value;
			}
		}

		// Token: 0x17003E6F RID: 15983
		// (get) Token: 0x0600FF60 RID: 65376 RVA: 0x00178880 File Offset: 0x00176A80
		// (set) Token: 0x0600FF61 RID: 65377 RVA: 0x00178894 File Offset: 0x00176A94
		public unsafe UTexture KuroSnowRampTexture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture>(base.NativePtr / (IntPtr)sizeof(void*) + USkyLightComponent.__PropertyOffset_KuroSnowRampTexture);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + USkyLightComponent.__PropertyOffset_KuroSnowRampTexture, value);
			}
		}

		// Token: 0x17003E70 RID: 15984
		// (get) Token: 0x0600FF62 RID: 65378 RVA: 0x001788A9 File Offset: 0x00176AA9
		// (set) Token: 0x0600FF63 RID: 65379 RVA: 0x001788BD File Offset: 0x00176ABD
		public unsafe UTexture ShadowTintLut
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture>(base.NativePtr / (IntPtr)sizeof(void*) + USkyLightComponent.__PropertyOffset_ShadowTintLut);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + USkyLightComponent.__PropertyOffset_ShadowTintLut, value);
			}
		}

		// Token: 0x17003E71 RID: 15985
		// (get) Token: 0x0600FF64 RID: 65380 RVA: 0x001788D2 File Offset: 0x00176AD2
		// (set) Token: 0x0600FF65 RID: 65381 RVA: 0x001788E2 File Offset: 0x00176AE2
		public unsafe float ShadowTintLutOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_ShadowTintLutOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkyLightComponent.__PropertyOffset_ShadowTintLutOffset) = value;
			}
		}

		// Token: 0x17003E72 RID: 15986
		// (get) Token: 0x0600FF66 RID: 65382 RVA: 0x001788F3 File Offset: 0x00176AF3
		// (set) Token: 0x0600FF67 RID: 65383 RVA: 0x00178907 File Offset: 0x00176B07
		public unsafe UTextureCube BlendDestinationCubemap
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureCube>(base.NativePtr / (IntPtr)sizeof(void*) + USkyLightComponent.__PropertyOffset_BlendDestinationCubemap);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + USkyLightComponent.__PropertyOffset_BlendDestinationCubemap, value);
			}
		}

		// Token: 0x0600FF68 RID: 65384 RVA: 0x0017891C File Offset: 0x00176B1C
		public void SetVolumetricScatteringIntensity(float NewIntensity)
		{
			USkyLightComponent.__SetVolumetricScatteringIntensity_Internal(base.NativePtr, NewIntensity);
		}

		// Token: 0x0600FF69 RID: 65385 RVA: 0x0017892A File Offset: 0x00176B2A
		public void SetTreeOutLineOuterScale(float InKuroTreeOutLineOuterScale)
		{
			USkyLightComponent.__SetTreeOutLineOuterScale_Internal(base.NativePtr, InKuroTreeOutLineOuterScale);
		}

		// Token: 0x0600FF6A RID: 65386 RVA: 0x00178938 File Offset: 0x00176B38
		public void SetShadowTintLutOffset(float InShadowTintLutOffset)
		{
			USkyLightComponent.__SetShadowTintLutOffset_Internal(base.NativePtr, InShadowTintLutOffset);
		}

		// Token: 0x0600FF6B RID: 65387 RVA: 0x00178946 File Offset: 0x00176B46
		public void SetOcclusionTint(in FColor InTint)
		{
			USkyLightComponent.__SetOcclusionTint_Internal(base.NativePtr, InTint);
		}

		// Token: 0x0600FF6C RID: 65388 RVA: 0x00178954 File Offset: 0x00176B54
		public void SetOcclusionMaxDistance(float InOcclusionMaxDistance)
		{
			USkyLightComponent.__SetOcclusionMaxDistance_Internal(base.NativePtr, InOcclusionMaxDistance);
		}

		// Token: 0x0600FF6D RID: 65389 RVA: 0x00178962 File Offset: 0x00176B62
		public void SetOcclusionExponent(float InOcclusionExponent)
		{
			USkyLightComponent.__SetOcclusionExponent_Internal(base.NativePtr, InOcclusionExponent);
		}

		// Token: 0x0600FF6E RID: 65390 RVA: 0x00178970 File Offset: 0x00176B70
		public void SetOcclusionContrast(float InOcclusionContrast)
		{
			USkyLightComponent.__SetOcclusionContrast_Internal(base.NativePtr, InOcclusionContrast);
		}

		// Token: 0x0600FF6F RID: 65391 RVA: 0x0017897E File Offset: 0x00176B7E
		public void SetMinOcclusion(float InMinOcclusion)
		{
			USkyLightComponent.__SetMinOcclusion_Internal(base.NativePtr, InMinOcclusion);
		}

		// Token: 0x0600FF70 RID: 65392 RVA: 0x0017898C File Offset: 0x00176B8C
		public void SetMaterialDynamicReflectionTexture(UTextureCube InMaterialDynamicReflectionTexure)
		{
			USkyLightComponent.__SetMaterialDynamicReflectionTexture_Internal(base.NativePtr, (InMaterialDynamicReflectionTexure != null) ? InMaterialDynamicReflectionTexure.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600FF71 RID: 65393 RVA: 0x001789A9 File Offset: 0x00176BA9
		public void SetLowerHemisphereColor(in FLinearColor InLowerHemisphereColor)
		{
			USkyLightComponent.__SetLowerHemisphereColor_Internal(base.NativePtr, InLowerHemisphereColor);
		}

		// Token: 0x0600FF72 RID: 65394 RVA: 0x001789B7 File Offset: 0x00176BB7
		public void SetLightColor(FLinearColor NewLightColor)
		{
			USkyLightComponent.__SetLightColor_Internal(base.NativePtr, NewLightColor);
		}

		// Token: 0x0600FF73 RID: 65395 RVA: 0x001789C5 File Offset: 0x00176BC5
		public void SetKuroUseNewCharacterRim(float InUseNewCharacterRim)
		{
			USkyLightComponent.__SetKuroUseNewCharacterRim_Internal(base.NativePtr, InUseNewCharacterRim);
		}

		// Token: 0x0600FF74 RID: 65396 RVA: 0x001789D3 File Offset: 0x00176BD3
		public void SetKuroTreeOutLineOuterColor(FLinearColor InKuroTreeOutLineOuterColor)
		{
			USkyLightComponent.__SetKuroTreeOutLineOuterColor_Internal(base.NativePtr, InKuroTreeOutLineOuterColor);
		}

		// Token: 0x0600FF75 RID: 65397 RVA: 0x001789E1 File Offset: 0x00176BE1
		public void SetKuroTreeOutLineInnerColor(FLinearColor InKuroTreeOutLineInnerColor)
		{
			USkyLightComponent.__SetKuroTreeOutLineInnerColor_Internal(base.NativePtr, InKuroTreeOutLineInnerColor);
		}

		// Token: 0x0600FF76 RID: 65398 RVA: 0x001789EF File Offset: 0x00176BEF
		public void SetKuroTreeOutLineFarScale(float InKuroTreeOutLineFarScale)
		{
			USkyLightComponent.__SetKuroTreeOutLineFarScale_Internal(base.NativePtr, InKuroTreeOutLineFarScale);
		}

		// Token: 0x0600FF77 RID: 65399 RVA: 0x001789FD File Offset: 0x00176BFD
		public void SetKuroTreeNearFarDistance(float InKuroTreeOutLineNearFarDistance)
		{
			USkyLightComponent.__SetKuroTreeNearFarDistance_Internal(base.NativePtr, InKuroTreeOutLineNearFarDistance);
		}

		// Token: 0x0600FF78 RID: 65400 RVA: 0x00178A0B File Offset: 0x00176C0B
		public void SetKuroTreeLineRadius(float InKuroTreeOutLineRadius)
		{
			USkyLightComponent.__SetKuroTreeLineRadius_Internal(base.NativePtr, InKuroTreeOutLineRadius);
		}

		// Token: 0x0600FF79 RID: 65401 RVA: 0x00178A19 File Offset: 0x00176C19
		public void SetKuroTreeDistanceRatio(float InKuroTreeOutLineDistanceRatio)
		{
			USkyLightComponent.__SetKuroTreeDistanceRatio_Internal(base.NativePtr, InKuroTreeOutLineDistanceRatio);
		}

		// Token: 0x0600FF7A RID: 65402 RVA: 0x00178A27 File Offset: 0x00176C27
		public void SetKuroSkyLightTranslucent(float InTranslucent)
		{
			USkyLightComponent.__SetKuroSkyLightTranslucent_Internal(base.NativePtr, InTranslucent);
		}

		// Token: 0x0600FF7B RID: 65403 RVA: 0x00178A35 File Offset: 0x00176C35
		public void SetKuroSkyLightSpecularIntensity(float InSkyLightSpecularIntensity)
		{
			USkyLightComponent.__SetKuroSkyLightSpecularIntensity_Internal(base.NativePtr, InSkyLightSpecularIntensity);
		}

		// Token: 0x0600FF7C RID: 65404 RVA: 0x00178A43 File Offset: 0x00176C43
		public void SetKuroSkyLightShadowIntSupplementDistance(float InIntensity)
		{
			USkyLightComponent.__SetKuroSkyLightShadowIntSupplementDistance_Internal(base.NativePtr, InIntensity);
		}

		// Token: 0x0600FF7D RID: 65405 RVA: 0x00178A51 File Offset: 0x00176C51
		public void SetKuroSkyLightShadowIntSupplement(float InIntensity)
		{
			USkyLightComponent.__SetKuroSkyLightShadowIntSupplement_Internal(base.NativePtr, InIntensity);
		}

		// Token: 0x0600FF7E RID: 65406 RVA: 0x00178A5F File Offset: 0x00176C5F
		public void SetKuroSkyLightSH(FVector SH1, FVector SH2, FVector SH3, FVector SH4, FVector SH5, FVector SH6)
		{
			USkyLightComponent.__SetKuroSkyLightSH_Internal(base.NativePtr, SH1, SH2, SH3, SH4, SH5, SH6);
		}

		// Token: 0x0600FF7F RID: 65407 RVA: 0x00178A75 File Offset: 0x00176C75
		public void SetKuroSkyLightLayerCubemap3(UTextureCube Cubemap3)
		{
			USkyLightComponent.__SetKuroSkyLightLayerCubemap3_Internal(base.NativePtr, (Cubemap3 != null) ? Cubemap3.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600FF80 RID: 65408 RVA: 0x00178A92 File Offset: 0x00176C92
		public void SetKuroSkyLightLayerCubemap2(UTextureCube Cubemap2)
		{
			USkyLightComponent.__SetKuroSkyLightLayerCubemap2_Internal(base.NativePtr, (Cubemap2 != null) ? Cubemap2.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600FF81 RID: 65409 RVA: 0x00178AAF File Offset: 0x00176CAF
		public void SetKuroSkyLightLayerCubemap1(UTextureCube Cubemap1)
		{
			USkyLightComponent.__SetKuroSkyLightLayerCubemap1_Internal(base.NativePtr, (Cubemap1 != null) ? Cubemap1.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600FF82 RID: 65410 RVA: 0x00178ACC File Offset: 0x00176CCC
		public void SetKuroSkyLightIntensity(float InIntensity)
		{
			USkyLightComponent.__SetKuroSkyLightIntensity_Internal(base.NativePtr, InIntensity);
		}

		// Token: 0x0600FF83 RID: 65411 RVA: 0x00178ADA File Offset: 0x00176CDA
		public void SetKuroSkyLightColorTint(FLinearColor InColorTint)
		{
			USkyLightComponent.__SetKuroSkyLightColorTint_Internal(base.NativePtr, InColorTint);
		}

		// Token: 0x0600FF84 RID: 65412 RVA: 0x00178AE8 File Offset: 0x00176CE8
		public void SetKuroSkyLightBlend23(float Blend23)
		{
			USkyLightComponent.__SetKuroSkyLightBlend23_Internal(base.NativePtr, Blend23);
		}

		// Token: 0x0600FF85 RID: 65413 RVA: 0x00178AF6 File Offset: 0x00176CF6
		public void SetKuroSkyLightBlend12(float Blend12)
		{
			USkyLightComponent.__SetKuroSkyLightBlend12_Internal(base.NativePtr, Blend12);
		}

		// Token: 0x0600FF86 RID: 65414 RVA: 0x00178B04 File Offset: 0x00176D04
		public void SetKuroNearSkyLightDistance(float SkyLightDistance)
		{
			USkyLightComponent.__SetKuroNearSkyLightDistance_Internal(base.NativePtr, SkyLightDistance);
		}

		// Token: 0x0600FF87 RID: 65415 RVA: 0x00178B12 File Offset: 0x00176D12
		public void SetKuroNearSkyLightColor(FLinearColor SkyLightColor)
		{
			USkyLightComponent.__SetKuroNearSkyLightColor_Internal(base.NativePtr, SkyLightColor);
		}

		// Token: 0x0600FF88 RID: 65416 RVA: 0x00178B20 File Offset: 0x00176D20
		public void SetKuroNearCharLightAdv(float KuroNearCharLightDistanceSoft, float KuroNearCharLightDistance, FLinearColor KuroNearCharLightColor, FLinearColor KuroNearCharShadowColor)
		{
			USkyLightComponent.__SetKuroNearCharLightAdv_Internal(base.NativePtr, KuroNearCharLightDistanceSoft, KuroNearCharLightDistance, KuroNearCharLightColor, KuroNearCharShadowColor);
		}

		// Token: 0x0600FF89 RID: 65417 RVA: 0x00178B32 File Offset: 0x00176D32
		public void SetKuroNearCharLight(float KuroNearCharLightDistance, FLinearColor KuroNearCharLightColor, FLinearColor KuroNearCharShadowColor)
		{
			USkyLightComponent.__SetKuroNearCharLight_Internal(base.NativePtr, KuroNearCharLightDistance, KuroNearCharLightColor, KuroNearCharShadowColor);
		}

		// Token: 0x0600FF8A RID: 65418 RVA: 0x00178B44 File Offset: 0x00176D44
		public unsafe void SetKuroMetalCubeMapBoost(FVector4 MetalCubeMapBoost)
		{
			ref FVector4 ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr = MetalCubeMapBoost;
			USkyLightComponent.__SetKuroMetalCubeMapBoost_Internal(base.NativePtr, ptr);
		}

		// Token: 0x0600FF8B RID: 65419 RVA: 0x00178B74 File Offset: 0x00176D74
		public void SetKuroMainLightSpecularMax(float InMainLightSpecularMax)
		{
			USkyLightComponent.__SetKuroMainLightSpecularMax_Internal(base.NativePtr, InMainLightSpecularMax);
		}

		// Token: 0x0600FF8C RID: 65420 RVA: 0x00178B82 File Offset: 0x00176D82
		public void SetKuroMainLightSpecularIntensity(float InMainLightSpecularIntensity)
		{
			USkyLightComponent.__SetKuroMainLightSpecularIntensity_Internal(base.NativePtr, InMainLightSpecularIntensity);
		}

		// Token: 0x0600FF8D RID: 65421 RVA: 0x00178B90 File Offset: 0x00176D90
		public void SetKuroInteriorSkyLightIntensity(float InteriorSkyLightIntensity)
		{
			USkyLightComponent.__SetKuroInteriorSkyLightIntensity_Internal(base.NativePtr, InteriorSkyLightIntensity);
		}

		// Token: 0x0600FF8E RID: 65422 RVA: 0x00178B9E File Offset: 0x00176D9E
		public void SetKuroInteriorSkyLightColor(FLinearColor InteriorColorTint)
		{
			USkyLightComponent.__SetKuroInteriorSkyLightColor_Internal(base.NativePtr, InteriorColorTint);
		}

		// Token: 0x0600FF8F RID: 65423 RVA: 0x00178BAC File Offset: 0x00176DAC
		public void SetKuroDirLightSpecularIntensity(float InDirLightSpecularIntensity)
		{
			USkyLightComponent.__SetKuroDirLightSpecularIntensity_Internal(base.NativePtr, InDirLightSpecularIntensity);
		}

		// Token: 0x0600FF90 RID: 65424 RVA: 0x00178BBA File Offset: 0x00176DBA
		public void SetKuroCharacterSSSIntensity(float InCharacterSSSIntensity)
		{
			USkyLightComponent.__SetKuroCharacterSSSIntensity_Internal(base.NativePtr, InCharacterSSSIntensity);
		}

		// Token: 0x0600FF91 RID: 65425 RVA: 0x00178BC8 File Offset: 0x00176DC8
		public unsafe void SetKuroCharacterRimDir(FVector4 InCharacterLightDir)
		{
			ref FVector4 ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr = InCharacterLightDir;
			USkyLightComponent.__SetKuroCharacterRimDir_Internal(base.NativePtr, ptr);
		}

		// Token: 0x0600FF92 RID: 65426 RVA: 0x00178BF8 File Offset: 0x00176DF8
		public void SetKuroCharacterRimColor(FLinearColor InCharacterRimColor)
		{
			USkyLightComponent.__SetKuroCharacterRimColor_Internal(base.NativePtr, InCharacterRimColor);
		}

		// Token: 0x0600FF93 RID: 65427 RVA: 0x00178C06 File Offset: 0x00176E06
		public void SetKuroCharacterMainLightColor(FLinearColor InCharacterMainLightColor)
		{
			USkyLightComponent.__SetKuroCharacterMainLightColor_Internal(base.NativePtr, InCharacterMainLightColor);
		}

		// Token: 0x0600FF94 RID: 65428 RVA: 0x00178C14 File Offset: 0x00176E14
		public void SetKuroCharacterGlobalShadowIntensity(float GlobalShadowIntensity)
		{
			USkyLightComponent.__SetKuroCharacterGlobalShadowIntensity_Internal(base.NativePtr, GlobalShadowIntensity);
		}

		// Token: 0x0600FF95 RID: 65429 RVA: 0x00178C22 File Offset: 0x00176E22
		public void SetKuroCharacterGlobalBossShadowRange(FVector2D GlobalBossShadowRange)
		{
			USkyLightComponent.__SetKuroCharacterGlobalBossShadowRange_Internal(base.NativePtr, GlobalBossShadowRange);
		}

		// Token: 0x0600FF96 RID: 65430 RVA: 0x00178C30 File Offset: 0x00176E30
		public void SetKuroCharacterGlobalBossShadowIntensity(float GlobalBossShadowIntensity)
		{
			USkyLightComponent.__SetKuroCharacterGlobalBossShadowIntensity_Internal(base.NativePtr, GlobalBossShadowIntensity);
		}

		// Token: 0x0600FF97 RID: 65431 RVA: 0x00178C3E File Offset: 0x00176E3E
		public void SetKuroCharacterAmbientColor(FLinearColor InCharacterAmbientColor)
		{
			USkyLightComponent.__SetKuroCharacterAmbientColor_Internal(base.NativePtr, InCharacterAmbientColor);
		}

		// Token: 0x0600FF98 RID: 65432 RVA: 0x00178C4C File Offset: 0x00176E4C
		public void SetKuroAOColorTint(FLinearColor InColorTint)
		{
			USkyLightComponent.__SetKuroAOColorTint_Internal(base.NativePtr, InColorTint);
		}

		// Token: 0x0600FF99 RID: 65433 RVA: 0x00178C5A File Offset: 0x00176E5A
		public void SetIntensity(float NewIntensity)
		{
			USkyLightComponent.__SetIntensity_Internal(base.NativePtr, NewIntensity);
		}

		// Token: 0x0600FF9A RID: 65434 RVA: 0x00178C68 File Offset: 0x00176E68
		public void SetIndirectLightingIntensity(float NewIntensity)
		{
			USkyLightComponent.__SetIndirectLightingIntensity_Internal(base.NativePtr, NewIntensity);
		}

		// Token: 0x0600FF9B RID: 65435 RVA: 0x00178C76 File Offset: 0x00176E76
		public void SetCubemapBlend(UTextureCube SourceCubemap, UTextureCube DestinationCubemap, float InBlendFraction)
		{
			USkyLightComponent.__SetCubemapBlend_Internal(base.NativePtr, (SourceCubemap != null) ? SourceCubemap.NativePtr : IntPtr.Zero, (DestinationCubemap != null) ? DestinationCubemap.NativePtr : IntPtr.Zero, InBlendFraction);
		}

		// Token: 0x0600FF9C RID: 65436 RVA: 0x00178CA4 File Offset: 0x00176EA4
		public void SetCubemap(UTextureCube NewCubemap)
		{
			USkyLightComponent.__SetCubemap_Internal(base.NativePtr, (NewCubemap != null) ? NewCubemap.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600FF9D RID: 65437 RVA: 0x00178CC1 File Offset: 0x00176EC1
		public void RecaptureSky()
		{
			USkyLightComponent.__RecaptureSky_Internal(base.NativePtr);
		}

		// Token: 0x0600FF9E RID: 65438 RVA: 0x00178CCE File Offset: 0x00176ECE
		public void ForceKuroSkyLightBlendUpdate()
		{
			USkyLightComponent.__ForceKuroSkyLightBlendUpdate_Internal(base.NativePtr);
		}

		// Token: 0x0600FF9F RID: 65439
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVolumetricScatteringIntensity_Internal(IntPtr @this, float NewIntensity);

		// Token: 0x0600FFA0 RID: 65440
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTreeOutLineOuterScale_Internal(IntPtr @this, float InKuroTreeOutLineOuterScale);

		// Token: 0x0600FFA1 RID: 65441
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetShadowTintLutOffset_Internal(IntPtr @this, float InShadowTintLutOffset);

		// Token: 0x0600FFA2 RID: 65442
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetOcclusionTint_Internal(IntPtr @this, in FColor InTint);

		// Token: 0x0600FFA3 RID: 65443
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetOcclusionMaxDistance_Internal(IntPtr @this, float InOcclusionMaxDistance);

		// Token: 0x0600FFA4 RID: 65444
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetOcclusionExponent_Internal(IntPtr @this, float InOcclusionExponent);

		// Token: 0x0600FFA5 RID: 65445
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetOcclusionContrast_Internal(IntPtr @this, float InOcclusionContrast);

		// Token: 0x0600FFA6 RID: 65446
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMinOcclusion_Internal(IntPtr @this, float InMinOcclusion);

		// Token: 0x0600FFA7 RID: 65447
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMaterialDynamicReflectionTexture_Internal(IntPtr @this, IntPtr InMaterialDynamicReflectionTexure);

		// Token: 0x0600FFA8 RID: 65448
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLowerHemisphereColor_Internal(IntPtr @this, in FLinearColor InLowerHemisphereColor);

		// Token: 0x0600FFA9 RID: 65449
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLightColor_Internal(IntPtr @this, FLinearColor NewLightColor);

		// Token: 0x0600FFAA RID: 65450
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroUseNewCharacterRim_Internal(IntPtr @this, float InUseNewCharacterRim);

		// Token: 0x0600FFAB RID: 65451
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroTreeOutLineOuterColor_Internal(IntPtr @this, FLinearColor InKuroTreeOutLineOuterColor);

		// Token: 0x0600FFAC RID: 65452
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroTreeOutLineInnerColor_Internal(IntPtr @this, FLinearColor InKuroTreeOutLineInnerColor);

		// Token: 0x0600FFAD RID: 65453
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroTreeOutLineFarScale_Internal(IntPtr @this, float InKuroTreeOutLineFarScale);

		// Token: 0x0600FFAE RID: 65454
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroTreeNearFarDistance_Internal(IntPtr @this, float InKuroTreeOutLineNearFarDistance);

		// Token: 0x0600FFAF RID: 65455
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroTreeLineRadius_Internal(IntPtr @this, float InKuroTreeOutLineRadius);

		// Token: 0x0600FFB0 RID: 65456
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroTreeDistanceRatio_Internal(IntPtr @this, float InKuroTreeOutLineDistanceRatio);

		// Token: 0x0600FFB1 RID: 65457
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroSkyLightTranslucent_Internal(IntPtr @this, float InTranslucent);

		// Token: 0x0600FFB2 RID: 65458
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroSkyLightSpecularIntensity_Internal(IntPtr @this, float InSkyLightSpecularIntensity);

		// Token: 0x0600FFB3 RID: 65459
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroSkyLightShadowIntSupplementDistance_Internal(IntPtr @this, float InIntensity);

		// Token: 0x0600FFB4 RID: 65460
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroSkyLightShadowIntSupplement_Internal(IntPtr @this, float InIntensity);

		// Token: 0x0600FFB5 RID: 65461
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroSkyLightSH_Internal(IntPtr @this, FVector SH1, FVector SH2, FVector SH3, FVector SH4, FVector SH5, FVector SH6);

		// Token: 0x0600FFB6 RID: 65462
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroSkyLightLayerCubemap3_Internal(IntPtr @this, IntPtr Cubemap3);

		// Token: 0x0600FFB7 RID: 65463
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroSkyLightLayerCubemap2_Internal(IntPtr @this, IntPtr Cubemap2);

		// Token: 0x0600FFB8 RID: 65464
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroSkyLightLayerCubemap1_Internal(IntPtr @this, IntPtr Cubemap1);

		// Token: 0x0600FFB9 RID: 65465
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroSkyLightIntensity_Internal(IntPtr @this, float InIntensity);

		// Token: 0x0600FFBA RID: 65466
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroSkyLightColorTint_Internal(IntPtr @this, FLinearColor InColorTint);

		// Token: 0x0600FFBB RID: 65467
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroSkyLightBlend23_Internal(IntPtr @this, float Blend23);

		// Token: 0x0600FFBC RID: 65468
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroSkyLightBlend12_Internal(IntPtr @this, float Blend12);

		// Token: 0x0600FFBD RID: 65469
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroNearSkyLightDistance_Internal(IntPtr @this, float SkyLightDistance);

		// Token: 0x0600FFBE RID: 65470
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroNearSkyLightColor_Internal(IntPtr @this, FLinearColor SkyLightColor);

		// Token: 0x0600FFBF RID: 65471
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroNearCharLightAdv_Internal(IntPtr @this, float KuroNearCharLightDistanceSoft, float KuroNearCharLightDistance, FLinearColor KuroNearCharLightColor, FLinearColor KuroNearCharShadowColor);

		// Token: 0x0600FFC0 RID: 65472
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroNearCharLight_Internal(IntPtr @this, float KuroNearCharLightDistance, FLinearColor KuroNearCharLightColor, FLinearColor KuroNearCharShadowColor);

		// Token: 0x0600FFC1 RID: 65473
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroMetalCubeMapBoost_Internal(IntPtr @this, in FVector4 MetalCubeMapBoost);

		// Token: 0x0600FFC2 RID: 65474
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroMainLightSpecularMax_Internal(IntPtr @this, float InMainLightSpecularMax);

		// Token: 0x0600FFC3 RID: 65475
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroMainLightSpecularIntensity_Internal(IntPtr @this, float InMainLightSpecularIntensity);

		// Token: 0x0600FFC4 RID: 65476
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroInteriorSkyLightIntensity_Internal(IntPtr @this, float InteriorSkyLightIntensity);

		// Token: 0x0600FFC5 RID: 65477
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroInteriorSkyLightColor_Internal(IntPtr @this, FLinearColor InteriorColorTint);

		// Token: 0x0600FFC6 RID: 65478
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroDirLightSpecularIntensity_Internal(IntPtr @this, float InDirLightSpecularIntensity);

		// Token: 0x0600FFC7 RID: 65479
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroCharacterSSSIntensity_Internal(IntPtr @this, float InCharacterSSSIntensity);

		// Token: 0x0600FFC8 RID: 65480
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroCharacterRimDir_Internal(IntPtr @this, in FVector4 InCharacterLightDir);

		// Token: 0x0600FFC9 RID: 65481
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroCharacterRimColor_Internal(IntPtr @this, FLinearColor InCharacterRimColor);

		// Token: 0x0600FFCA RID: 65482
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroCharacterMainLightColor_Internal(IntPtr @this, FLinearColor InCharacterMainLightColor);

		// Token: 0x0600FFCB RID: 65483
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroCharacterGlobalShadowIntensity_Internal(IntPtr @this, float GlobalShadowIntensity);

		// Token: 0x0600FFCC RID: 65484
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroCharacterGlobalBossShadowRange_Internal(IntPtr @this, FVector2D GlobalBossShadowRange);

		// Token: 0x0600FFCD RID: 65485
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroCharacterGlobalBossShadowIntensity_Internal(IntPtr @this, float GlobalBossShadowIntensity);

		// Token: 0x0600FFCE RID: 65486
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroCharacterAmbientColor_Internal(IntPtr @this, FLinearColor InCharacterAmbientColor);

		// Token: 0x0600FFCF RID: 65487
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroAOColorTint_Internal(IntPtr @this, FLinearColor InColorTint);

		// Token: 0x0600FFD0 RID: 65488
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetIntensity_Internal(IntPtr @this, float NewIntensity);

		// Token: 0x0600FFD1 RID: 65489
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetIndirectLightingIntensity_Internal(IntPtr @this, float NewIntensity);

		// Token: 0x0600FFD2 RID: 65490
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCubemapBlend_Internal(IntPtr @this, IntPtr SourceCubemap, IntPtr DestinationCubemap, float InBlendFraction);

		// Token: 0x0600FFD3 RID: 65491
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCubemap_Internal(IntPtr @this, IntPtr NewCubemap);

		// Token: 0x0600FFD4 RID: 65492
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RecaptureSky_Internal(IntPtr @this);

		// Token: 0x0600FFD5 RID: 65493
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ForceKuroSkyLightBlendUpdate_Internal(IntPtr @this);

		// Token: 0x0600FFD6 RID: 65494 RVA: 0x00178CDB File Offset: 0x00176EDB
		static USkyLightComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.SkyLightComponent");
		}

		// Token: 0x0600FFD7 RID: 65495 RVA: 0x00178CE9 File Offset: 0x00176EE9
		protected USkyLightComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04008927 RID: 35111
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.SkyLightComponent";

		// Token: 0x04008928 RID: 35112
		private static IntPtr _ClassPtr;

		// Token: 0x04008929 RID: 35113
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400892A RID: 35114
		internal static int __PropertyOffset_bRealTimeCapture;

		// Token: 0x0400892B RID: 35115
		internal static int __PropertyOffset_SourceType;

		// Token: 0x0400892C RID: 35116
		internal static int __PropertyOffset_Cubemap;

		// Token: 0x0400892D RID: 35117
		internal static int __PropertyOffset_SourceCubemapAngle;

		// Token: 0x0400892E RID: 35118
		internal static int __PropertyOffset_CubemapResolution;

		// Token: 0x0400892F RID: 35119
		internal static int __PropertyOffset_SkyDistanceThreshold;

		// Token: 0x04008930 RID: 35120
		internal static int __PropertyOffset_bCaptureEmissiveOnly;

		// Token: 0x04008931 RID: 35121
		internal static int __PropertyOffset_bLowerHemisphereIsBlack;

		// Token: 0x04008932 RID: 35122
		internal static int __PropertyOffset_LowerHemisphereColor;

		// Token: 0x04008933 RID: 35123
		internal static int __PropertyOffset_OcclusionMaxDistance;

		// Token: 0x04008934 RID: 35124
		internal static int __PropertyOffset_Contrast;

		// Token: 0x04008935 RID: 35125
		internal static int __PropertyOffset_OcclusionExponent;

		// Token: 0x04008936 RID: 35126
		internal static int __PropertyOffset_MinOcclusion;

		// Token: 0x04008937 RID: 35127
		internal static int __PropertyOffset_OcclusionTint;

		// Token: 0x04008938 RID: 35128
		internal static int __PropertyOffset_bCloudAmbientOcclusion;

		// Token: 0x04008939 RID: 35129
		internal static byte __PropertyMask_bCloudAmbientOcclusion;

		// Token: 0x0400893A RID: 35130
		internal static int __PropertyOffset_CloudAmbientOcclusionStrength;

		// Token: 0x0400893B RID: 35131
		internal static int __PropertyOffset_CloudAmbientOcclusionExtent;

		// Token: 0x0400893C RID: 35132
		internal static int __PropertyOffset_CloudAmbientOcclusionMapResolutionScale;

		// Token: 0x0400893D RID: 35133
		internal static int __PropertyOffset_CloudAmbientOcclusionApertureScale;

		// Token: 0x0400893E RID: 35134
		internal static int __PropertyOffset_OcclusionCombineMode;

		// Token: 0x0400893F RID: 35135
		internal static int __PropertyOffset_DefaultKuroCubemap;

		// Token: 0x04008940 RID: 35136
		internal static int __PropertyOffset_KuroLightProbeSH1_Default;

		// Token: 0x04008941 RID: 35137
		internal static int __PropertyOffset_KuroLightProbeSH2_Default;

		// Token: 0x04008942 RID: 35138
		internal static int __PropertyOffset_KuroLightProbeSH3_Default;

		// Token: 0x04008943 RID: 35139
		internal static int __PropertyOffset_KuroLightProbeSH4_Default;

		// Token: 0x04008944 RID: 35140
		internal static int __PropertyOffset_KuroLightProbeSH5_Default;

		// Token: 0x04008945 RID: 35141
		internal static int __PropertyOffset_KuroLightProbeSH6_Default;

		// Token: 0x04008946 RID: 35142
		internal static int __PropertyOffset_bUseKuroSkyLight;

		// Token: 0x04008947 RID: 35143
		internal static int __PropertyOffset_KuroSkyLightTranslucent;

		// Token: 0x04008948 RID: 35144
		internal static int __PropertyOffset_KuroSkyLightIntensity;

		// Token: 0x04008949 RID: 35145
		internal static int __PropertyOffset_KuroSkyLightColor;

		// Token: 0x0400894A RID: 35146
		internal static int __PropertyOffset_KuroAOColor;

		// Token: 0x0400894B RID: 35147
		internal static int __PropertyOffset_KuroInteriorSkyLightIntensity;

		// Token: 0x0400894C RID: 35148
		internal static int __PropertyOffset_KuroInteriorSkyLightColor;

		// Token: 0x0400894D RID: 35149
		internal static int __PropertyOffset_KuroNearSkyLightColor;

		// Token: 0x0400894E RID: 35150
		internal static int __PropertyOffset_KuroMainLightSpecularIntensity;

		// Token: 0x0400894F RID: 35151
		internal static int __PropertyOffset_KuroDirLightSpecularIntensity;

		// Token: 0x04008950 RID: 35152
		internal static int __PropertyOffset_KuroMainLightSpecularMax;

		// Token: 0x04008951 RID: 35153
		internal static int __PropertyOffset_KuroSkyLightSpecularIntensity;

		// Token: 0x04008952 RID: 35154
		internal static int __PropertyOffset_KuroSkyLightShadowIntSupplement;

		// Token: 0x04008953 RID: 35155
		internal static int __PropertyOffset_KuroSkyLightShadowIntSupplementDistance;

		// Token: 0x04008954 RID: 35156
		internal static int __PropertyOffset_KuroMetallicSpecularAddIntensity;

		// Token: 0x04008955 RID: 35157
		internal static int __PropertyOffset_KuroMetallicReflectionAddIntensity;

		// Token: 0x04008956 RID: 35158
		internal static int __PropertyOffset_KuroMetallicMaskStep;

		// Token: 0x04008957 RID: 35159
		internal static int __PropertyOffset_KuroMetalCubeMapBoost;

		// Token: 0x04008958 RID: 35160
		internal static int __PropertyOffset_MaterialDynamicReflectionTexture;

		// Token: 0x04008959 RID: 35161
		internal static int __PropertyOffset_KuroLightProbeSH1;

		// Token: 0x0400895A RID: 35162
		internal static int __PropertyOffset_KuroLightProbeSH2;

		// Token: 0x0400895B RID: 35163
		internal static int __PropertyOffset_KuroLightProbeSH3;

		// Token: 0x0400895C RID: 35164
		internal static int __PropertyOffset_KuroLightProbeSH4;

		// Token: 0x0400895D RID: 35165
		internal static int __PropertyOffset_KuroLightProbeSH5;

		// Token: 0x0400895E RID: 35166
		internal static int __PropertyOffset_KuroLightProbeSH6;

		// Token: 0x0400895F RID: 35167
		internal static int __PropertyOffset_KuroBlend12;

		// Token: 0x04008960 RID: 35168
		internal static int __PropertyOffset_KuroBlend23;

		// Token: 0x04008961 RID: 35169
		internal static int __PropertyOffset_KuroCubemap_Layer1;

		// Token: 0x04008962 RID: 35170
		internal static int __PropertyOffset_KuroCubemap_Layer2;

		// Token: 0x04008963 RID: 35171
		internal static int __PropertyOffset_KuroCubemap_Layer3;

		// Token: 0x04008964 RID: 35172
		internal static int __PropertyOffset_KuroCharacterSSSIntensity;

		// Token: 0x04008965 RID: 35173
		internal static int __PropertyOffset_KuroCharacterGlobalShadowIntensity;

		// Token: 0x04008966 RID: 35174
		internal static int __PropertyOffset_KuroCharacterGlobalBossShadowIntensity;

		// Token: 0x04008967 RID: 35175
		internal static int __PropertyOffset_KuroCharacterGlobalBossShadowRange;

		// Token: 0x04008968 RID: 35176
		internal static int __PropertyOffset_KuroUseNewCharacterRim;

		// Token: 0x04008969 RID: 35177
		internal static int __PropertyOffset_KuroCharacterAmbientColor;

		// Token: 0x0400896A RID: 35178
		internal static int __PropertyOffset_KuroCharacterMainLightColor;

		// Token: 0x0400896B RID: 35179
		internal static int __PropertyOffset_NearCharDistance;

		// Token: 0x0400896C RID: 35180
		internal static int __PropertyOffset_NearCharDistanceSoft;

		// Token: 0x0400896D RID: 35181
		internal static int __PropertyOffset_NearCharLightColor;

		// Token: 0x0400896E RID: 35182
		internal static int __PropertyOffset_NearCharShadowColor;

		// Token: 0x0400896F RID: 35183
		internal static int __PropertyOffset_KuroCharacterRimColor;

		// Token: 0x04008970 RID: 35184
		internal static int __PropertyOffset_KuroCharRimDir;

		// Token: 0x04008971 RID: 35185
		internal static int __PropertyOffset_KuroTreeOutLineRadius;

		// Token: 0x04008972 RID: 35186
		internal static int __PropertyOffset_KuroTreeOutLineDistanceRatio;

		// Token: 0x04008973 RID: 35187
		internal static int __PropertyOffset_KuroTreeOutLineFarScale;

		// Token: 0x04008974 RID: 35188
		internal static int __PropertyOffset_KuroTreeOutLineInnerColor;

		// Token: 0x04008975 RID: 35189
		internal static int __PropertyOffset_KuroTreeOutLineOuterColor;

		// Token: 0x04008976 RID: 35190
		internal static int __PropertyOffset_KuroTreeOutLineOuterScale;

		// Token: 0x04008977 RID: 35191
		internal static int __PropertyOffset_KuroTreeOutLineNearFarDistance;

		// Token: 0x04008978 RID: 35192
		internal static int __PropertyOffset_KuroSnowRampTexture;

		// Token: 0x04008979 RID: 35193
		internal static int __PropertyOffset_ShadowTintLut;

		// Token: 0x0400897A RID: 35194
		internal static int __PropertyOffset_ShadowTintLutOffset;

		// Token: 0x0400897B RID: 35195
		internal static int __PropertyOffset_BlendDestinationCubemap;
	}
}
