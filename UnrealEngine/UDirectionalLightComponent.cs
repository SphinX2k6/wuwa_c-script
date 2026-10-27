using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020009C2 RID: 2498
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.DirectionalLightComponent")]
	[UnrealStructLayout(1488, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1488)]
	public class UDirectionalLightComponent : ULightComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06008CFC RID: 36092 RVA: 0x000C9C92 File Offset: 0x000C7E92
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UDirectionalLightComponent._ClassPtr;
		}

		// Token: 0x06008CFD RID: 36093 RVA: 0x000C9CA0 File Offset: 0x000C7EA0
		public UDirectionalLightComponent() : this(BuiltinUtils.AllocNativeUObject(UDirectionalLightComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06008CFE RID: 36094 RVA: 0x000C9CC8 File Offset: 0x000C7EC8
		public UDirectionalLightComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UDirectionalLightComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002127 RID: 8487
		// (get) Token: 0x06008CFF RID: 36095 RVA: 0x000C9CFB File Offset: 0x000C7EFB
		// (set) Token: 0x06008D00 RID: 36096 RVA: 0x000C9D0B File Offset: 0x000C7F0B
		public unsafe float ShadowCascadeBiasDistribution
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UDirectionalLightComponent.__PropertyOffset_ShadowCascadeBiasDistribution);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDirectionalLightComponent.__PropertyOffset_ShadowCascadeBiasDistribution) = value;
			}
		}

		// Token: 0x17002128 RID: 8488
		// (get) Token: 0x06008D01 RID: 36097 RVA: 0x000C9D1C File Offset: 0x000C7F1C
		// (set) Token: 0x06008D02 RID: 36098 RVA: 0x000C9D30 File Offset: 0x000C7F30
		public unsafe FVector LightShaftOverrideDirection
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UDirectionalLightComponent.__PropertyOffset_LightShaftOverrideDirection);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDirectionalLightComponent.__PropertyOffset_LightShaftOverrideDirection) = value;
			}
		}

		// Token: 0x17002129 RID: 8489
		// (get) Token: 0x06008D03 RID: 36099 RVA: 0x000C9D45 File Offset: 0x000C7F45
		// (set) Token: 0x06008D04 RID: 36100 RVA: 0x000C9D55 File Offset: 0x000C7F55
		public unsafe float WholeSceneDynamicShadowRadius_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UDirectionalLightComponent.__PropertyOffset_WholeSceneDynamicShadowRadius_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDirectionalLightComponent.__PropertyOffset_WholeSceneDynamicShadowRadius_DEPRECATED) = value;
			}
		}

		// Token: 0x1700212A RID: 8490
		// (get) Token: 0x06008D05 RID: 36101 RVA: 0x000C9D66 File Offset: 0x000C7F66
		// (set) Token: 0x06008D06 RID: 36102 RVA: 0x000C9D76 File Offset: 0x000C7F76
		public unsafe float DynamicShadowDistanceMovableLight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UDirectionalLightComponent.__PropertyOffset_DynamicShadowDistanceMovableLight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDirectionalLightComponent.__PropertyOffset_DynamicShadowDistanceMovableLight) = value;
			}
		}

		// Token: 0x1700212B RID: 8491
		// (get) Token: 0x06008D07 RID: 36103 RVA: 0x000C9D87 File Offset: 0x000C7F87
		// (set) Token: 0x06008D08 RID: 36104 RVA: 0x000C9D97 File Offset: 0x000C7F97
		public unsafe float MobileDynamicShadowDistanceMovableLight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UDirectionalLightComponent.__PropertyOffset_MobileDynamicShadowDistanceMovableLight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDirectionalLightComponent.__PropertyOffset_MobileDynamicShadowDistanceMovableLight) = value;
			}
		}

		// Token: 0x1700212C RID: 8492
		// (get) Token: 0x06008D09 RID: 36105 RVA: 0x000C9DA8 File Offset: 0x000C7FA8
		// (set) Token: 0x06008D0A RID: 36106 RVA: 0x000C9DB8 File Offset: 0x000C7FB8
		public unsafe float DynamicShadowDistanceStationaryLight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UDirectionalLightComponent.__PropertyOffset_DynamicShadowDistanceStationaryLight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDirectionalLightComponent.__PropertyOffset_DynamicShadowDistanceStationaryLight) = value;
			}
		}

		// Token: 0x1700212D RID: 8493
		// (get) Token: 0x06008D0B RID: 36107 RVA: 0x000C9DC9 File Offset: 0x000C7FC9
		// (set) Token: 0x06008D0C RID: 36108 RVA: 0x000C9DD9 File Offset: 0x000C7FD9
		public unsafe int DynamicShadowCascades
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UDirectionalLightComponent.__PropertyOffset_DynamicShadowCascades);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDirectionalLightComponent.__PropertyOffset_DynamicShadowCascades) = value;
			}
		}

		// Token: 0x1700212E RID: 8494
		// (get) Token: 0x06008D0D RID: 36109 RVA: 0x000C9DEA File Offset: 0x000C7FEA
		// (set) Token: 0x06008D0E RID: 36110 RVA: 0x000C9DFA File Offset: 0x000C7FFA
		public unsafe float CascadeDistributionExponent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UDirectionalLightComponent.__PropertyOffset_CascadeDistributionExponent);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDirectionalLightComponent.__PropertyOffset_CascadeDistributionExponent) = value;
			}
		}

		// Token: 0x1700212F RID: 8495
		// (get) Token: 0x06008D0F RID: 36111 RVA: 0x000C9E0B File Offset: 0x000C800B
		// (set) Token: 0x06008D10 RID: 36112 RVA: 0x000C9E1B File Offset: 0x000C801B
		public unsafe float MobileCascadeDistributionExponent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UDirectionalLightComponent.__PropertyOffset_MobileCascadeDistributionExponent);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDirectionalLightComponent.__PropertyOffset_MobileCascadeDistributionExponent) = value;
			}
		}

		// Token: 0x17002130 RID: 8496
		// (get) Token: 0x06008D11 RID: 36113 RVA: 0x000C9E2C File Offset: 0x000C802C
		// (set) Token: 0x06008D12 RID: 36114 RVA: 0x000C9E3C File Offset: 0x000C803C
		public unsafe float CascadeTransitionFraction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UDirectionalLightComponent.__PropertyOffset_CascadeTransitionFraction);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDirectionalLightComponent.__PropertyOffset_CascadeTransitionFraction) = value;
			}
		}

		// Token: 0x17002131 RID: 8497
		// (get) Token: 0x06008D13 RID: 36115 RVA: 0x000C9E4D File Offset: 0x000C804D
		// (set) Token: 0x06008D14 RID: 36116 RVA: 0x000C9E5D File Offset: 0x000C805D
		public unsafe float ShadowDistanceFadeoutFraction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UDirectionalLightComponent.__PropertyOffset_ShadowDistanceFadeoutFraction);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDirectionalLightComponent.__PropertyOffset_ShadowDistanceFadeoutFraction) = value;
			}
		}

		// Token: 0x17002132 RID: 8498
		// (get) Token: 0x06008D15 RID: 36117 RVA: 0x000C9E6E File Offset: 0x000C806E
		// (set) Token: 0x06008D16 RID: 36118 RVA: 0x000C9E87 File Offset: 0x000C8087
		public unsafe bool bUseInsetShadowsForMovableObjects
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UDirectionalLightComponent.__PropertyOffset_bUseInsetShadowsForMovableObjects) & UDirectionalLightComponent.__PropertyMask_bUseInsetShadowsForMovableObjects) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UDirectionalLightComponent.__PropertyOffset_bUseInsetShadowsForMovableObjects) = ((*(base.NativePtr + (IntPtr)UDirectionalLightComponent.__PropertyOffset_bUseInsetShadowsForMovableObjects) & ~UDirectionalLightComponent.__PropertyMask_bUseInsetShadowsForMovableObjects) | (value ? UDirectionalLightComponent.__PropertyMask_bUseInsetShadowsForMovableObjects : 0));
			}
		}

		// Token: 0x17002133 RID: 8499
		// (get) Token: 0x06008D17 RID: 36119 RVA: 0x000C9EB7 File Offset: 0x000C80B7
		// (set) Token: 0x06008D18 RID: 36120 RVA: 0x000C9ED0 File Offset: 0x000C80D0
		public unsafe bool bUseCaveOrIndoorShadowStrategy
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UDirectionalLightComponent.__PropertyOffset_bUseCaveOrIndoorShadowStrategy) & UDirectionalLightComponent.__PropertyMask_bUseCaveOrIndoorShadowStrategy) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UDirectionalLightComponent.__PropertyOffset_bUseCaveOrIndoorShadowStrategy) = ((*(base.NativePtr + (IntPtr)UDirectionalLightComponent.__PropertyOffset_bUseCaveOrIndoorShadowStrategy) & ~UDirectionalLightComponent.__PropertyMask_bUseCaveOrIndoorShadowStrategy) | (value ? UDirectionalLightComponent.__PropertyMask_bUseCaveOrIndoorShadowStrategy : 0));
			}
		}

		// Token: 0x17002134 RID: 8500
		// (get) Token: 0x06008D19 RID: 36121 RVA: 0x000C9F00 File Offset: 0x000C8100
		// (set) Token: 0x06008D1A RID: 36122 RVA: 0x000C9F10 File Offset: 0x000C8110
		public unsafe int FarShadowCascadeCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UDirectionalLightComponent.__PropertyOffset_FarShadowCascadeCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDirectionalLightComponent.__PropertyOffset_FarShadowCascadeCount) = value;
			}
		}

		// Token: 0x17002135 RID: 8501
		// (get) Token: 0x06008D1B RID: 36123 RVA: 0x000C9F21 File Offset: 0x000C8121
		// (set) Token: 0x06008D1C RID: 36124 RVA: 0x000C9F31 File Offset: 0x000C8131
		public unsafe float FarShadowDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UDirectionalLightComponent.__PropertyOffset_FarShadowDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDirectionalLightComponent.__PropertyOffset_FarShadowDistance) = value;
			}
		}

		// Token: 0x17002136 RID: 8502
		// (get) Token: 0x06008D1D RID: 36125 RVA: 0x000C9F42 File Offset: 0x000C8142
		// (set) Token: 0x06008D1E RID: 36126 RVA: 0x000C9F52 File Offset: 0x000C8152
		public unsafe float DynamicShadowDistanceMovableLightPCHigh
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UDirectionalLightComponent.__PropertyOffset_DynamicShadowDistanceMovableLightPCHigh);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDirectionalLightComponent.__PropertyOffset_DynamicShadowDistanceMovableLightPCHigh) = value;
			}
		}

		// Token: 0x17002137 RID: 8503
		// (get) Token: 0x06008D1F RID: 36127 RVA: 0x000C9F63 File Offset: 0x000C8163
		// (set) Token: 0x06008D20 RID: 36128 RVA: 0x000C9F73 File Offset: 0x000C8173
		public unsafe int DynamicShadowCascadesPCHigh
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UDirectionalLightComponent.__PropertyOffset_DynamicShadowCascadesPCHigh);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDirectionalLightComponent.__PropertyOffset_DynamicShadowCascadesPCHigh) = value;
			}
		}

		// Token: 0x17002138 RID: 8504
		// (get) Token: 0x06008D21 RID: 36129 RVA: 0x000C9F84 File Offset: 0x000C8184
		// (set) Token: 0x06008D22 RID: 36130 RVA: 0x000C9F94 File Offset: 0x000C8194
		public unsafe float DistanceFieldShadowDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UDirectionalLightComponent.__PropertyOffset_DistanceFieldShadowDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDirectionalLightComponent.__PropertyOffset_DistanceFieldShadowDistance) = value;
			}
		}

		// Token: 0x17002139 RID: 8505
		// (get) Token: 0x06008D23 RID: 36131 RVA: 0x000C9FA5 File Offset: 0x000C81A5
		// (set) Token: 0x06008D24 RID: 36132 RVA: 0x000C9FB5 File Offset: 0x000C81B5
		public unsafe float LightSourceAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UDirectionalLightComponent.__PropertyOffset_LightSourceAngle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDirectionalLightComponent.__PropertyOffset_LightSourceAngle) = value;
			}
		}

		// Token: 0x1700213A RID: 8506
		// (get) Token: 0x06008D25 RID: 36133 RVA: 0x000C9FC6 File Offset: 0x000C81C6
		// (set) Token: 0x06008D26 RID: 36134 RVA: 0x000C9FDA File Offset: 0x000C81DA
		public unsafe FLinearColor NearMainLightColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UDirectionalLightComponent.__PropertyOffset_NearMainLightColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDirectionalLightComponent.__PropertyOffset_NearMainLightColor) = value;
			}
		}

		// Token: 0x1700213B RID: 8507
		// (get) Token: 0x06008D27 RID: 36135 RVA: 0x000C9FEF File Offset: 0x000C81EF
		// (set) Token: 0x06008D28 RID: 36136 RVA: 0x000C9FFF File Offset: 0x000C81FF
		public unsafe float LightSourceSoftAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UDirectionalLightComponent.__PropertyOffset_LightSourceSoftAngle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDirectionalLightComponent.__PropertyOffset_LightSourceSoftAngle) = value;
			}
		}

		// Token: 0x1700213C RID: 8508
		// (get) Token: 0x06008D29 RID: 36137 RVA: 0x000CA010 File Offset: 0x000C8210
		// (set) Token: 0x06008D2A RID: 36138 RVA: 0x000CA029 File Offset: 0x000C8229
		public unsafe bool bIsMainDirectionalLight
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UDirectionalLightComponent.__PropertyOffset_bIsMainDirectionalLight) & UDirectionalLightComponent.__PropertyMask_bIsMainDirectionalLight) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UDirectionalLightComponent.__PropertyOffset_bIsMainDirectionalLight) = ((*(base.NativePtr + (IntPtr)UDirectionalLightComponent.__PropertyOffset_bIsMainDirectionalLight) & ~UDirectionalLightComponent.__PropertyMask_bIsMainDirectionalLight) | (value ? UDirectionalLightComponent.__PropertyMask_bIsMainDirectionalLight : 0));
			}
		}

		// Token: 0x1700213D RID: 8509
		// (get) Token: 0x06008D2B RID: 36139 RVA: 0x000CA059 File Offset: 0x000C8259
		// (set) Token: 0x06008D2C RID: 36140 RVA: 0x000CA069 File Offset: 0x000C8269
		public unsafe float ShadowSourceAngleFactor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UDirectionalLightComponent.__PropertyOffset_ShadowSourceAngleFactor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDirectionalLightComponent.__PropertyOffset_ShadowSourceAngleFactor) = value;
			}
		}

		// Token: 0x1700213E RID: 8510
		// (get) Token: 0x06008D2D RID: 36141 RVA: 0x000CA07A File Offset: 0x000C827A
		// (set) Token: 0x06008D2E RID: 36142 RVA: 0x000CA08A File Offset: 0x000C828A
		public unsafe float TraceDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UDirectionalLightComponent.__PropertyOffset_TraceDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDirectionalLightComponent.__PropertyOffset_TraceDistance) = value;
			}
		}

		// Token: 0x1700213F RID: 8511
		// (get) Token: 0x06008D2F RID: 36143 RVA: 0x000CA09B File Offset: 0x000C829B
		// (set) Token: 0x06008D30 RID: 36144 RVA: 0x000CA0B4 File Offset: 0x000C82B4
		public unsafe bool bUsedAsAtmosphereSunLight
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UDirectionalLightComponent.__PropertyOffset_bUsedAsAtmosphereSunLight) & UDirectionalLightComponent.__PropertyMask_bUsedAsAtmosphereSunLight) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UDirectionalLightComponent.__PropertyOffset_bUsedAsAtmosphereSunLight) = ((*(base.NativePtr + (IntPtr)UDirectionalLightComponent.__PropertyOffset_bUsedAsAtmosphereSunLight) & ~UDirectionalLightComponent.__PropertyMask_bUsedAsAtmosphereSunLight) | (value ? UDirectionalLightComponent.__PropertyMask_bUsedAsAtmosphereSunLight : 0));
			}
		}

		// Token: 0x17002140 RID: 8512
		// (get) Token: 0x06008D31 RID: 36145 RVA: 0x000CA0E4 File Offset: 0x000C82E4
		// (set) Token: 0x06008D32 RID: 36146 RVA: 0x000CA0FD File Offset: 0x000C82FD
		public unsafe bool bKuroAtmosphereSunLight
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UDirectionalLightComponent.__PropertyOffset_bKuroAtmosphereSunLight) & UDirectionalLightComponent.__PropertyMask_bKuroAtmosphereSunLight) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UDirectionalLightComponent.__PropertyOffset_bKuroAtmosphereSunLight) = ((*(base.NativePtr + (IntPtr)UDirectionalLightComponent.__PropertyOffset_bKuroAtmosphereSunLight) & ~UDirectionalLightComponent.__PropertyMask_bKuroAtmosphereSunLight) | (value ? UDirectionalLightComponent.__PropertyMask_bKuroAtmosphereSunLight : 0));
			}
		}

		// Token: 0x17002141 RID: 8513
		// (get) Token: 0x06008D33 RID: 36147 RVA: 0x000CA12D File Offset: 0x000C832D
		// (set) Token: 0x06008D34 RID: 36148 RVA: 0x000CA13D File Offset: 0x000C833D
		public unsafe int AtmosphereSunLightIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UDirectionalLightComponent.__PropertyOffset_AtmosphereSunLightIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDirectionalLightComponent.__PropertyOffset_AtmosphereSunLightIndex) = value;
			}
		}

		// Token: 0x17002142 RID: 8514
		// (get) Token: 0x06008D35 RID: 36149 RVA: 0x000CA14E File Offset: 0x000C834E
		// (set) Token: 0x06008D36 RID: 36150 RVA: 0x000CA162 File Offset: 0x000C8362
		public unsafe FLinearColor AtmosphereSunDiskColorScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UDirectionalLightComponent.__PropertyOffset_AtmosphereSunDiskColorScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDirectionalLightComponent.__PropertyOffset_AtmosphereSunDiskColorScale) = value;
			}
		}

		// Token: 0x17002143 RID: 8515
		// (get) Token: 0x06008D37 RID: 36151 RVA: 0x000CA177 File Offset: 0x000C8377
		// (set) Token: 0x06008D38 RID: 36152 RVA: 0x000CA190 File Offset: 0x000C8390
		public unsafe bool bPerPixelAtmosphereTransmittance
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UDirectionalLightComponent.__PropertyOffset_bPerPixelAtmosphereTransmittance) & UDirectionalLightComponent.__PropertyMask_bPerPixelAtmosphereTransmittance) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UDirectionalLightComponent.__PropertyOffset_bPerPixelAtmosphereTransmittance) = ((*(base.NativePtr + (IntPtr)UDirectionalLightComponent.__PropertyOffset_bPerPixelAtmosphereTransmittance) & ~UDirectionalLightComponent.__PropertyMask_bPerPixelAtmosphereTransmittance) | (value ? UDirectionalLightComponent.__PropertyMask_bPerPixelAtmosphereTransmittance : 0));
			}
		}

		// Token: 0x17002144 RID: 8516
		// (get) Token: 0x06008D39 RID: 36153 RVA: 0x000CA1C0 File Offset: 0x000C83C0
		// (set) Token: 0x06008D3A RID: 36154 RVA: 0x000CA1D9 File Offset: 0x000C83D9
		public unsafe bool bCastShadowsOnClouds
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UDirectionalLightComponent.__PropertyOffset_bCastShadowsOnClouds) & UDirectionalLightComponent.__PropertyMask_bCastShadowsOnClouds) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UDirectionalLightComponent.__PropertyOffset_bCastShadowsOnClouds) = ((*(base.NativePtr + (IntPtr)UDirectionalLightComponent.__PropertyOffset_bCastShadowsOnClouds) & ~UDirectionalLightComponent.__PropertyMask_bCastShadowsOnClouds) | (value ? UDirectionalLightComponent.__PropertyMask_bCastShadowsOnClouds : 0));
			}
		}

		// Token: 0x17002145 RID: 8517
		// (get) Token: 0x06008D3B RID: 36155 RVA: 0x000CA209 File Offset: 0x000C8409
		// (set) Token: 0x06008D3C RID: 36156 RVA: 0x000CA222 File Offset: 0x000C8422
		public unsafe bool bCastShadowsOnAtmosphere
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UDirectionalLightComponent.__PropertyOffset_bCastShadowsOnAtmosphere) & UDirectionalLightComponent.__PropertyMask_bCastShadowsOnAtmosphere) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UDirectionalLightComponent.__PropertyOffset_bCastShadowsOnAtmosphere) = ((*(base.NativePtr + (IntPtr)UDirectionalLightComponent.__PropertyOffset_bCastShadowsOnAtmosphere) & ~UDirectionalLightComponent.__PropertyMask_bCastShadowsOnAtmosphere) | (value ? UDirectionalLightComponent.__PropertyMask_bCastShadowsOnAtmosphere : 0));
			}
		}

		// Token: 0x17002146 RID: 8518
		// (get) Token: 0x06008D3D RID: 36157 RVA: 0x000CA252 File Offset: 0x000C8452
		// (set) Token: 0x06008D3E RID: 36158 RVA: 0x000CA26B File Offset: 0x000C846B
		public unsafe bool bCastCloudShadows
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UDirectionalLightComponent.__PropertyOffset_bCastCloudShadows) & UDirectionalLightComponent.__PropertyMask_bCastCloudShadows) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UDirectionalLightComponent.__PropertyOffset_bCastCloudShadows) = ((*(base.NativePtr + (IntPtr)UDirectionalLightComponent.__PropertyOffset_bCastCloudShadows) & ~UDirectionalLightComponent.__PropertyMask_bCastCloudShadows) | (value ? UDirectionalLightComponent.__PropertyMask_bCastCloudShadows : 0));
			}
		}

		// Token: 0x17002147 RID: 8519
		// (get) Token: 0x06008D3F RID: 36159 RVA: 0x000CA29B File Offset: 0x000C849B
		// (set) Token: 0x06008D40 RID: 36160 RVA: 0x000CA2AB File Offset: 0x000C84AB
		public unsafe float CloudShadowStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UDirectionalLightComponent.__PropertyOffset_CloudShadowStrength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDirectionalLightComponent.__PropertyOffset_CloudShadowStrength) = value;
			}
		}

		// Token: 0x17002148 RID: 8520
		// (get) Token: 0x06008D41 RID: 36161 RVA: 0x000CA2BC File Offset: 0x000C84BC
		// (set) Token: 0x06008D42 RID: 36162 RVA: 0x000CA2CC File Offset: 0x000C84CC
		public unsafe float CloudShadowOnAtmosphereStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UDirectionalLightComponent.__PropertyOffset_CloudShadowOnAtmosphereStrength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDirectionalLightComponent.__PropertyOffset_CloudShadowOnAtmosphereStrength) = value;
			}
		}

		// Token: 0x17002149 RID: 8521
		// (get) Token: 0x06008D43 RID: 36163 RVA: 0x000CA2DD File Offset: 0x000C84DD
		// (set) Token: 0x06008D44 RID: 36164 RVA: 0x000CA2ED File Offset: 0x000C84ED
		public unsafe float CloudShadowOnSurfaceStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UDirectionalLightComponent.__PropertyOffset_CloudShadowOnSurfaceStrength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDirectionalLightComponent.__PropertyOffset_CloudShadowOnSurfaceStrength) = value;
			}
		}

		// Token: 0x1700214A RID: 8522
		// (get) Token: 0x06008D45 RID: 36165 RVA: 0x000CA2FE File Offset: 0x000C84FE
		// (set) Token: 0x06008D46 RID: 36166 RVA: 0x000CA30E File Offset: 0x000C850E
		public unsafe float CloudShadowDepthBias
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UDirectionalLightComponent.__PropertyOffset_CloudShadowDepthBias);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDirectionalLightComponent.__PropertyOffset_CloudShadowDepthBias) = value;
			}
		}

		// Token: 0x1700214B RID: 8523
		// (get) Token: 0x06008D47 RID: 36167 RVA: 0x000CA31F File Offset: 0x000C851F
		// (set) Token: 0x06008D48 RID: 36168 RVA: 0x000CA32F File Offset: 0x000C852F
		public unsafe float CloudShadowExtent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UDirectionalLightComponent.__PropertyOffset_CloudShadowExtent);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDirectionalLightComponent.__PropertyOffset_CloudShadowExtent) = value;
			}
		}

		// Token: 0x1700214C RID: 8524
		// (get) Token: 0x06008D49 RID: 36169 RVA: 0x000CA340 File Offset: 0x000C8540
		// (set) Token: 0x06008D4A RID: 36170 RVA: 0x000CA350 File Offset: 0x000C8550
		public unsafe float CloudShadowMapResolutionScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UDirectionalLightComponent.__PropertyOffset_CloudShadowMapResolutionScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDirectionalLightComponent.__PropertyOffset_CloudShadowMapResolutionScale) = value;
			}
		}

		// Token: 0x1700214D RID: 8525
		// (get) Token: 0x06008D4B RID: 36171 RVA: 0x000CA361 File Offset: 0x000C8561
		// (set) Token: 0x06008D4C RID: 36172 RVA: 0x000CA371 File Offset: 0x000C8571
		public unsafe float CloudShadowRaySampleCountScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UDirectionalLightComponent.__PropertyOffset_CloudShadowRaySampleCountScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDirectionalLightComponent.__PropertyOffset_CloudShadowRaySampleCountScale) = value;
			}
		}

		// Token: 0x1700214E RID: 8526
		// (get) Token: 0x06008D4D RID: 36173 RVA: 0x000CA382 File Offset: 0x000C8582
		// (set) Token: 0x06008D4E RID: 36174 RVA: 0x000CA396 File Offset: 0x000C8596
		public unsafe FLinearColor CloudScatteredLuminanceScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UDirectionalLightComponent.__PropertyOffset_CloudScatteredLuminanceScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDirectionalLightComponent.__PropertyOffset_CloudScatteredLuminanceScale) = value;
			}
		}

		// Token: 0x1700214F RID: 8527
		// (get) Token: 0x06008D4F RID: 36175 RVA: 0x000CA3AC File Offset: 0x000C85AC
		// (set) Token: 0x06008D50 RID: 36176 RVA: 0x000CA3E5 File Offset: 0x000C85E5
		public FLightmassDirectionalLightSettings LightmassSettings
		{
			get
			{
				base.FastCheckIsValid();
				FLightmassDirectionalLightSettings result;
				if ((result = this._LightmassSettings) == null)
				{
					result = (this._LightmassSettings = new FLightmassDirectionalLightSettings(base.NativePtr + (IntPtr)UDirectionalLightComponent.__PropertyOffset_LightmassSettings, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FLightmassDirectionalLightSettings.StaticStruct(), base.NativePtr + (IntPtr)UDirectionalLightComponent.__PropertyOffset_LightmassSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002150 RID: 8528
		// (get) Token: 0x06008D51 RID: 36177 RVA: 0x000CA406 File Offset: 0x000C8606
		// (set) Token: 0x06008D52 RID: 36178 RVA: 0x000CA41F File Offset: 0x000C861F
		public unsafe bool bCastModulatedShadows
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UDirectionalLightComponent.__PropertyOffset_bCastModulatedShadows) & UDirectionalLightComponent.__PropertyMask_bCastModulatedShadows) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UDirectionalLightComponent.__PropertyOffset_bCastModulatedShadows) = ((*(base.NativePtr + (IntPtr)UDirectionalLightComponent.__PropertyOffset_bCastModulatedShadows) & ~UDirectionalLightComponent.__PropertyMask_bCastModulatedShadows) | (value ? UDirectionalLightComponent.__PropertyMask_bCastModulatedShadows : 0));
			}
		}

		// Token: 0x17002151 RID: 8529
		// (get) Token: 0x06008D53 RID: 36179 RVA: 0x000CA44F File Offset: 0x000C864F
		// (set) Token: 0x06008D54 RID: 36180 RVA: 0x000CA463 File Offset: 0x000C8663
		public unsafe FColor ModulatedShadowColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UDirectionalLightComponent.__PropertyOffset_ModulatedShadowColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDirectionalLightComponent.__PropertyOffset_ModulatedShadowColor) = value;
			}
		}

		// Token: 0x17002152 RID: 8530
		// (get) Token: 0x06008D55 RID: 36181 RVA: 0x000CA478 File Offset: 0x000C8678
		// (set) Token: 0x06008D56 RID: 36182 RVA: 0x000CA488 File Offset: 0x000C8688
		public unsafe float ShadowAmount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UDirectionalLightComponent.__PropertyOffset_ShadowAmount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDirectionalLightComponent.__PropertyOffset_ShadowAmount) = value;
			}
		}

		// Token: 0x17002153 RID: 8531
		// (get) Token: 0x06008D57 RID: 36183 RVA: 0x000CA499 File Offset: 0x000C8699
		// (set) Token: 0x06008D58 RID: 36184 RVA: 0x000CA4A9 File Offset: 0x000C86A9
		public unsafe float Softness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UDirectionalLightComponent.__PropertyOffset_Softness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDirectionalLightComponent.__PropertyOffset_Softness) = value;
			}
		}

		// Token: 0x17002154 RID: 8532
		// (get) Token: 0x06008D59 RID: 36185 RVA: 0x000CA4BA File Offset: 0x000C86BA
		// (set) Token: 0x06008D5A RID: 36186 RVA: 0x000CA4CA File Offset: 0x000C86CA
		public unsafe float SoftnessFallloff
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UDirectionalLightComponent.__PropertyOffset_SoftnessFallloff);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDirectionalLightComponent.__PropertyOffset_SoftnessFallloff) = value;
			}
		}

		// Token: 0x17002155 RID: 8533
		// (get) Token: 0x06008D5B RID: 36187 RVA: 0x000CA4DB File Offset: 0x000C86DB
		// (set) Token: 0x06008D5C RID: 36188 RVA: 0x000CA4EB File Offset: 0x000C86EB
		public unsafe float ShadowPow
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UDirectionalLightComponent.__PropertyOffset_ShadowPow);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDirectionalLightComponent.__PropertyOffset_ShadowPow) = value;
			}
		}

		// Token: 0x17002156 RID: 8534
		// (get) Token: 0x06008D5D RID: 36189 RVA: 0x000CA4FC File Offset: 0x000C86FC
		// (set) Token: 0x06008D5E RID: 36190 RVA: 0x000CA50C File Offset: 0x000C870C
		public unsafe float Softness2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UDirectionalLightComponent.__PropertyOffset_Softness2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDirectionalLightComponent.__PropertyOffset_Softness2) = value;
			}
		}

		// Token: 0x17002157 RID: 8535
		// (get) Token: 0x06008D5F RID: 36191 RVA: 0x000CA51D File Offset: 0x000C871D
		// (set) Token: 0x06008D60 RID: 36192 RVA: 0x000CA531 File Offset: 0x000C8731
		public unsafe FVector4 ShadowTint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UDirectionalLightComponent.__PropertyOffset_ShadowTint);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDirectionalLightComponent.__PropertyOffset_ShadowTint) = value;
			}
		}

		// Token: 0x06008D61 RID: 36193 RVA: 0x000CA546 File Offset: 0x000C8746
		public void UpdateParallaxCorrectCachedLightToWorld(FRotator NewRelativeRotation, FRotator CrossFadeRelativeRotation, float CrossFadeWaitTime, float CrossFadeDuration)
		{
			UDirectionalLightComponent.__UpdateParallaxCorrectCachedLightToWorld_Internal(base.NativePtr, NewRelativeRotation, CrossFadeRelativeRotation, CrossFadeWaitTime, CrossFadeDuration);
		}

		// Token: 0x06008D62 RID: 36194 RVA: 0x000CA558 File Offset: 0x000C8758
		public void SetUseCaveOrIndoorShadowStrategy(bool NewValue)
		{
			UDirectionalLightComponent.__SetUseCaveOrIndoorShadowStrategy_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x06008D63 RID: 36195 RVA: 0x000CA568 File Offset: 0x000C8768
		public unsafe void SetShadowTint(FVector4 shaodwTint)
		{
			ref FVector4 ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr = shaodwTint;
			UDirectionalLightComponent.__SetShadowTint_Internal(base.NativePtr, ptr);
		}

		// Token: 0x06008D64 RID: 36196 RVA: 0x000CA598 File Offset: 0x000C8798
		public void SetShadowDistanceFadeoutFraction(float NewValue)
		{
			UDirectionalLightComponent.__SetShadowDistanceFadeoutFraction_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x06008D65 RID: 36197 RVA: 0x000CA5A6 File Offset: 0x000C87A6
		public void SetShadowAmount(float NewValue)
		{
			UDirectionalLightComponent.__SetShadowAmount_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x06008D66 RID: 36198 RVA: 0x000CA5B4 File Offset: 0x000C87B4
		public void SetNearMainLightDistance(float MainLightDistance)
		{
			UDirectionalLightComponent.__SetNearMainLightDistance_Internal(base.NativePtr, MainLightDistance);
		}

		// Token: 0x06008D67 RID: 36199 RVA: 0x000CA5C2 File Offset: 0x000C87C2
		public void SetNearMainLightColor(FLinearColor MainLightColor)
		{
			UDirectionalLightComponent.__SetNearMainLightColor_Internal(base.NativePtr, MainLightColor);
		}

		// Token: 0x06008D68 RID: 36200 RVA: 0x000CA5D0 File Offset: 0x000C87D0
		public void SetMobileDynamicShadowDistanceMovableLight(float NewValue)
		{
			UDirectionalLightComponent.__SetMobileDynamicShadowDistanceMovableLight_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x06008D69 RID: 36201 RVA: 0x000CA5DE File Offset: 0x000C87DE
		public void SetMobileCascadeDistributionExponent(float NewValue)
		{
			UDirectionalLightComponent.__SetMobileCascadeDistributionExponent_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x06008D6A RID: 36202 RVA: 0x000CA5EC File Offset: 0x000C87EC
		public void SetLightShaftOverrideDirection(FVector NewValue)
		{
			UDirectionalLightComponent.__SetLightShaftOverrideDirection_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x06008D6B RID: 36203 RVA: 0x000CA5FA File Offset: 0x000C87FA
		public void SetFarShadowDistance(float NewValue)
		{
			UDirectionalLightComponent.__SetFarShadowDistance_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x06008D6C RID: 36204 RVA: 0x000CA608 File Offset: 0x000C8808
		public void SetFarShadowCascadeCount(int NewValue)
		{
			UDirectionalLightComponent.__SetFarShadowCascadeCount_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x06008D6D RID: 36205 RVA: 0x000CA616 File Offset: 0x000C8816
		public void SetDynamicShadowDistanceStationaryLight(float NewValue)
		{
			UDirectionalLightComponent.__SetDynamicShadowDistanceStationaryLight_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x06008D6E RID: 36206 RVA: 0x000CA624 File Offset: 0x000C8824
		public void SetDynamicShadowDistanceMovableLightPCHigh(float NewValue)
		{
			UDirectionalLightComponent.__SetDynamicShadowDistanceMovableLightPCHigh_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x06008D6F RID: 36207 RVA: 0x000CA632 File Offset: 0x000C8832
		public void SetDynamicShadowDistanceMovableLight(float NewValue)
		{
			UDirectionalLightComponent.__SetDynamicShadowDistanceMovableLight_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x06008D70 RID: 36208 RVA: 0x000CA640 File Offset: 0x000C8840
		public void SetDynamicShadowCascadesPCHigh(int NewValue)
		{
			UDirectionalLightComponent.__SetDynamicShadowCascadesPCHigh_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x06008D71 RID: 36209 RVA: 0x000CA64E File Offset: 0x000C884E
		public void SetDynamicShadowCascades(int NewValue)
		{
			UDirectionalLightComponent.__SetDynamicShadowCascades_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x06008D72 RID: 36210 RVA: 0x000CA65C File Offset: 0x000C885C
		public void SetCloudScatteredLuminanceScale(FLinearColor NewColor)
		{
			UDirectionalLightComponent.__SetCloudScatteredLuminanceScale_Internal(base.NativePtr, NewColor);
		}

		// Token: 0x06008D73 RID: 36211 RVA: 0x000CA66A File Offset: 0x000C886A
		public void SetCascadeTransitionFraction(float NewValue)
		{
			UDirectionalLightComponent.__SetCascadeTransitionFraction_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x06008D74 RID: 36212 RVA: 0x000CA678 File Offset: 0x000C8878
		public void SetCascadeDistributionExponent(float NewValue)
		{
			UDirectionalLightComponent.__SetCascadeDistributionExponent_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x06008D75 RID: 36213 RVA: 0x000CA686 File Offset: 0x000C8886
		public void SetAtmosphereSunLightIndex(int NewValue)
		{
			UDirectionalLightComponent.__SetAtmosphereSunLightIndex_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x06008D76 RID: 36214 RVA: 0x000CA694 File Offset: 0x000C8894
		public void SetAtmosphereSunLight(bool bNewValue)
		{
			UDirectionalLightComponent.__SetAtmosphereSunLight_Internal(base.NativePtr, bNewValue);
		}

		// Token: 0x06008D77 RID: 36215 RVA: 0x000CA6A2 File Offset: 0x000C88A2
		public void SetAtmosphereSunDiskColorScale(FLinearColor NewColor)
		{
			UDirectionalLightComponent.__SetAtmosphereSunDiskColorScale_Internal(base.NativePtr, NewColor);
		}

		// Token: 0x06008D78 RID: 36216 RVA: 0x000CA6B0 File Offset: 0x000C88B0
		public FVector GetParallaxCorrectCachedForwardVector()
		{
			return UDirectionalLightComponent.__GetParallaxCorrectCachedForwardVector_Internal(base.NativePtr);
		}

		// Token: 0x06008D79 RID: 36217
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateParallaxCorrectCachedLightToWorld_Internal(IntPtr @this, FRotator NewRelativeRotation, FRotator CrossFadeRelativeRotation, float CrossFadeWaitTime, float CrossFadeDuration);

		// Token: 0x06008D7A RID: 36218
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetUseCaveOrIndoorShadowStrategy_Internal(IntPtr @this, bool NewValue);

		// Token: 0x06008D7B RID: 36219
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetShadowTint_Internal(IntPtr @this, in FVector4 shaodwTint);

		// Token: 0x06008D7C RID: 36220
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetShadowDistanceFadeoutFraction_Internal(IntPtr @this, float NewValue);

		// Token: 0x06008D7D RID: 36221
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetShadowAmount_Internal(IntPtr @this, float NewValue);

		// Token: 0x06008D7E RID: 36222
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNearMainLightDistance_Internal(IntPtr @this, float MainLightDistance);

		// Token: 0x06008D7F RID: 36223
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNearMainLightColor_Internal(IntPtr @this, FLinearColor MainLightColor);

		// Token: 0x06008D80 RID: 36224
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMobileDynamicShadowDistanceMovableLight_Internal(IntPtr @this, float NewValue);

		// Token: 0x06008D81 RID: 36225
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMobileCascadeDistributionExponent_Internal(IntPtr @this, float NewValue);

		// Token: 0x06008D82 RID: 36226
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLightShaftOverrideDirection_Internal(IntPtr @this, FVector NewValue);

		// Token: 0x06008D83 RID: 36227
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetFarShadowDistance_Internal(IntPtr @this, float NewValue);

		// Token: 0x06008D84 RID: 36228
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetFarShadowCascadeCount_Internal(IntPtr @this, int NewValue);

		// Token: 0x06008D85 RID: 36229
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDynamicShadowDistanceStationaryLight_Internal(IntPtr @this, float NewValue);

		// Token: 0x06008D86 RID: 36230
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDynamicShadowDistanceMovableLightPCHigh_Internal(IntPtr @this, float NewValue);

		// Token: 0x06008D87 RID: 36231
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDynamicShadowDistanceMovableLight_Internal(IntPtr @this, float NewValue);

		// Token: 0x06008D88 RID: 36232
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDynamicShadowCascadesPCHigh_Internal(IntPtr @this, int NewValue);

		// Token: 0x06008D89 RID: 36233
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDynamicShadowCascades_Internal(IntPtr @this, int NewValue);

		// Token: 0x06008D8A RID: 36234
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCloudScatteredLuminanceScale_Internal(IntPtr @this, FLinearColor NewColor);

		// Token: 0x06008D8B RID: 36235
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCascadeTransitionFraction_Internal(IntPtr @this, float NewValue);

		// Token: 0x06008D8C RID: 36236
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCascadeDistributionExponent_Internal(IntPtr @this, float NewValue);

		// Token: 0x06008D8D RID: 36237
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAtmosphereSunLightIndex_Internal(IntPtr @this, int NewValue);

		// Token: 0x06008D8E RID: 36238
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAtmosphereSunLight_Internal(IntPtr @this, bool bNewValue);

		// Token: 0x06008D8F RID: 36239
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAtmosphereSunDiskColorScale_Internal(IntPtr @this, FLinearColor NewColor);

		// Token: 0x06008D90 RID: 36240
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetParallaxCorrectCachedForwardVector_Internal(IntPtr @this);

		// Token: 0x06008D91 RID: 36241 RVA: 0x000CA6BD File Offset: 0x000C88BD
		static UDirectionalLightComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.DirectionalLightComponent");
		}

		// Token: 0x06008D92 RID: 36242 RVA: 0x000CA6CB File Offset: 0x000C88CB
		protected UDirectionalLightComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040042F6 RID: 17142
		public new const string __ObjectPath = "/Script/Engine.DirectionalLightComponent";

		// Token: 0x040042F7 RID: 17143
		private static IntPtr _ClassPtr;

		// Token: 0x040042F8 RID: 17144
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040042F9 RID: 17145
		internal static int __PropertyOffset_ShadowCascadeBiasDistribution;

		// Token: 0x040042FA RID: 17146
		internal static int __PropertyOffset_LightShaftOverrideDirection;

		// Token: 0x040042FB RID: 17147
		internal static int __PropertyOffset_WholeSceneDynamicShadowRadius_DEPRECATED;

		// Token: 0x040042FC RID: 17148
		internal static int __PropertyOffset_DynamicShadowDistanceMovableLight;

		// Token: 0x040042FD RID: 17149
		internal static int __PropertyOffset_MobileDynamicShadowDistanceMovableLight;

		// Token: 0x040042FE RID: 17150
		internal static int __PropertyOffset_DynamicShadowDistanceStationaryLight;

		// Token: 0x040042FF RID: 17151
		internal static int __PropertyOffset_DynamicShadowCascades;

		// Token: 0x04004300 RID: 17152
		internal static int __PropertyOffset_CascadeDistributionExponent;

		// Token: 0x04004301 RID: 17153
		internal static int __PropertyOffset_MobileCascadeDistributionExponent;

		// Token: 0x04004302 RID: 17154
		internal static int __PropertyOffset_CascadeTransitionFraction;

		// Token: 0x04004303 RID: 17155
		internal static int __PropertyOffset_ShadowDistanceFadeoutFraction;

		// Token: 0x04004304 RID: 17156
		internal static int __PropertyOffset_bUseInsetShadowsForMovableObjects;

		// Token: 0x04004305 RID: 17157
		internal static byte __PropertyMask_bUseInsetShadowsForMovableObjects;

		// Token: 0x04004306 RID: 17158
		internal static int __PropertyOffset_bUseCaveOrIndoorShadowStrategy;

		// Token: 0x04004307 RID: 17159
		internal static byte __PropertyMask_bUseCaveOrIndoorShadowStrategy;

		// Token: 0x04004308 RID: 17160
		internal static int __PropertyOffset_FarShadowCascadeCount;

		// Token: 0x04004309 RID: 17161
		internal static int __PropertyOffset_FarShadowDistance;

		// Token: 0x0400430A RID: 17162
		internal static int __PropertyOffset_DynamicShadowDistanceMovableLightPCHigh;

		// Token: 0x0400430B RID: 17163
		internal static int __PropertyOffset_DynamicShadowCascadesPCHigh;

		// Token: 0x0400430C RID: 17164
		internal static int __PropertyOffset_DistanceFieldShadowDistance;

		// Token: 0x0400430D RID: 17165
		internal static int __PropertyOffset_LightSourceAngle;

		// Token: 0x0400430E RID: 17166
		internal static int __PropertyOffset_NearMainLightColor;

		// Token: 0x0400430F RID: 17167
		internal static int __PropertyOffset_LightSourceSoftAngle;

		// Token: 0x04004310 RID: 17168
		internal static int __PropertyOffset_bIsMainDirectionalLight;

		// Token: 0x04004311 RID: 17169
		internal static byte __PropertyMask_bIsMainDirectionalLight;

		// Token: 0x04004312 RID: 17170
		internal static int __PropertyOffset_ShadowSourceAngleFactor;

		// Token: 0x04004313 RID: 17171
		internal static int __PropertyOffset_TraceDistance;

		// Token: 0x04004314 RID: 17172
		internal static int __PropertyOffset_bUsedAsAtmosphereSunLight;

		// Token: 0x04004315 RID: 17173
		internal static byte __PropertyMask_bUsedAsAtmosphereSunLight;

		// Token: 0x04004316 RID: 17174
		internal static int __PropertyOffset_bKuroAtmosphereSunLight;

		// Token: 0x04004317 RID: 17175
		internal static byte __PropertyMask_bKuroAtmosphereSunLight;

		// Token: 0x04004318 RID: 17176
		internal static int __PropertyOffset_AtmosphereSunLightIndex;

		// Token: 0x04004319 RID: 17177
		internal static int __PropertyOffset_AtmosphereSunDiskColorScale;

		// Token: 0x0400431A RID: 17178
		internal static int __PropertyOffset_bPerPixelAtmosphereTransmittance;

		// Token: 0x0400431B RID: 17179
		internal static byte __PropertyMask_bPerPixelAtmosphereTransmittance;

		// Token: 0x0400431C RID: 17180
		internal static int __PropertyOffset_bCastShadowsOnClouds;

		// Token: 0x0400431D RID: 17181
		internal static byte __PropertyMask_bCastShadowsOnClouds;

		// Token: 0x0400431E RID: 17182
		internal static int __PropertyOffset_bCastShadowsOnAtmosphere;

		// Token: 0x0400431F RID: 17183
		internal static byte __PropertyMask_bCastShadowsOnAtmosphere;

		// Token: 0x04004320 RID: 17184
		internal static int __PropertyOffset_bCastCloudShadows;

		// Token: 0x04004321 RID: 17185
		internal static byte __PropertyMask_bCastCloudShadows;

		// Token: 0x04004322 RID: 17186
		internal static int __PropertyOffset_CloudShadowStrength;

		// Token: 0x04004323 RID: 17187
		internal static int __PropertyOffset_CloudShadowOnAtmosphereStrength;

		// Token: 0x04004324 RID: 17188
		internal static int __PropertyOffset_CloudShadowOnSurfaceStrength;

		// Token: 0x04004325 RID: 17189
		internal static int __PropertyOffset_CloudShadowDepthBias;

		// Token: 0x04004326 RID: 17190
		internal static int __PropertyOffset_CloudShadowExtent;

		// Token: 0x04004327 RID: 17191
		internal static int __PropertyOffset_CloudShadowMapResolutionScale;

		// Token: 0x04004328 RID: 17192
		internal static int __PropertyOffset_CloudShadowRaySampleCountScale;

		// Token: 0x04004329 RID: 17193
		internal static int __PropertyOffset_CloudScatteredLuminanceScale;

		// Token: 0x0400432A RID: 17194
		internal static int __PropertyOffset_LightmassSettings;

		// Token: 0x0400432B RID: 17195
		[Nullable(2)]
		private FLightmassDirectionalLightSettings _LightmassSettings;

		// Token: 0x0400432C RID: 17196
		internal static int __PropertyOffset_bCastModulatedShadows;

		// Token: 0x0400432D RID: 17197
		internal static byte __PropertyMask_bCastModulatedShadows;

		// Token: 0x0400432E RID: 17198
		internal static int __PropertyOffset_ModulatedShadowColor;

		// Token: 0x0400432F RID: 17199
		internal static int __PropertyOffset_ShadowAmount;

		// Token: 0x04004330 RID: 17200
		internal static int __PropertyOffset_Softness;

		// Token: 0x04004331 RID: 17201
		internal static int __PropertyOffset_SoftnessFallloff;

		// Token: 0x04004332 RID: 17202
		internal static int __PropertyOffset_ShadowPow;

		// Token: 0x04004333 RID: 17203
		internal static int __PropertyOffset_Softness2;

		// Token: 0x04004334 RID: 17204
		internal static int __PropertyOffset_ShadowTint;
	}
}
