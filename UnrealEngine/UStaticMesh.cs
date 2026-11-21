using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200028E RID: 654
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.StaticMesh")]
	[UnrealStructLayout(4152, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 4152)]
	public class UStaticMesh : UStreamableRenderAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060047DC RID: 18396 RVA: 0x00064A84 File Offset: 0x00062C84
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UStaticMesh._ClassPtr;
		}

		// Token: 0x060047DD RID: 18397 RVA: 0x00064A90 File Offset: 0x00062C90
		public UStaticMesh() : this(BuiltinUtils.AllocNativeUObject(UStaticMesh.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060047DE RID: 18398 RVA: 0x00064AB8 File Offset: 0x00062CB8
		[NullableContext(1)]
		public UStaticMesh(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UStaticMesh.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000D49 RID: 3401
		// (get) Token: 0x060047DF RID: 18399 RVA: 0x00064AEB File Offset: 0x00062CEB
		// (set) Token: 0x060047E0 RID: 18400 RVA: 0x00064AFB File Offset: 0x00062CFB
		public unsafe bool bUseKuroLODDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_bUseKuroLODDistance) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_bUseKuroLODDistance) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000D4A RID: 3402
		// (get) Token: 0x060047E1 RID: 18401 RVA: 0x00064B0C File Offset: 0x00062D0C
		// (set) Token: 0x060047E2 RID: 18402 RVA: 0x00064B1C File Offset: 0x00062D1C
		public unsafe bool bBakeImposter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_bBakeImposter) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_bBakeImposter) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000D4B RID: 3403
		// (get) Token: 0x060047E3 RID: 18403 RVA: 0x00064B2D File Offset: 0x00062D2D
		// (set) Token: 0x060047E4 RID: 18404 RVA: 0x00064B3D File Offset: 0x00062D3D
		public unsafe int BakeImposterType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_BakeImposterType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_BakeImposterType) = value;
			}
		}

		// Token: 0x17000D4C RID: 3404
		// (get) Token: 0x060047E5 RID: 18405 RVA: 0x00064B4E File Offset: 0x00062D4E
		// (set) Token: 0x060047E6 RID: 18406 RVA: 0x00064B5E File Offset: 0x00062D5E
		public unsafe bool bCastRasterShadowsInRaytracing
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_bCastRasterShadowsInRaytracing) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_bCastRasterShadowsInRaytracing) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000D4D RID: 3405
		// (get) Token: 0x060047E7 RID: 18407 RVA: 0x00064B6F File Offset: 0x00062D6F
		// (set) Token: 0x060047E8 RID: 18408 RVA: 0x00064B7F File Offset: 0x00062D7F
		public unsafe bool bUseCustomDataForWorldMap
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_bUseCustomDataForWorldMap) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_bUseCustomDataForWorldMap) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000D4E RID: 3406
		// (get) Token: 0x060047E9 RID: 18409 RVA: 0x00064B90 File Offset: 0x00062D90
		// (set) Token: 0x060047EA RID: 18410 RVA: 0x00064BA0 File Offset: 0x00062DA0
		public unsafe float ScreenSizeCullRatio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_ScreenSizeCullRatio);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_ScreenSizeCullRatio) = value;
			}
		}

		// Token: 0x17000D4F RID: 3407
		// (get) Token: 0x060047EB RID: 18411 RVA: 0x00064BB4 File Offset: 0x00062DB4
		// (set) Token: 0x060047EC RID: 18412 RVA: 0x00064BED File Offset: 0x00062DED
		[Nullable(1)]
		public TArray<FName> Tags
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._Tags) == null)
				{
					result = (this._Tags = new TArray<FName>(base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_Tags, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Tags.CopyAssign(value);
			}
		}

		// Token: 0x17000D50 RID: 3408
		// (get) Token: 0x060047ED RID: 18413 RVA: 0x00064BFB File Offset: 0x00062DFB
		// (set) Token: 0x060047EE RID: 18414 RVA: 0x00064C0B File Offset: 0x00062E0B
		public unsafe float LpvBiasMultiplier
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_LpvBiasMultiplier);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_LpvBiasMultiplier) = value;
			}
		}

		// Token: 0x17000D51 RID: 3409
		// (get) Token: 0x060047EF RID: 18415 RVA: 0x00064C1C File Offset: 0x00062E1C
		// (set) Token: 0x060047F0 RID: 18416 RVA: 0x00064C2C File Offset: 0x00062E2C
		public unsafe float LightmapUVDensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_LightmapUVDensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_LightmapUVDensity) = value;
			}
		}

		// Token: 0x17000D52 RID: 3410
		// (get) Token: 0x060047F1 RID: 18417 RVA: 0x00064C3D File Offset: 0x00062E3D
		// (set) Token: 0x060047F2 RID: 18418 RVA: 0x00064C4D File Offset: 0x00062E4D
		public unsafe int LightMapResolution
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_LightMapResolution);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_LightMapResolution) = value;
			}
		}

		// Token: 0x17000D53 RID: 3411
		// (get) Token: 0x060047F3 RID: 18419 RVA: 0x00064C5E File Offset: 0x00062E5E
		// (set) Token: 0x060047F4 RID: 18420 RVA: 0x00064C6E File Offset: 0x00062E6E
		public unsafe int LightMapCoordinateIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_LightMapCoordinateIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_LightMapCoordinateIndex) = value;
			}
		}

		// Token: 0x17000D54 RID: 3412
		// (get) Token: 0x060047F5 RID: 18421 RVA: 0x00064C7F File Offset: 0x00062E7F
		// (set) Token: 0x060047F6 RID: 18422 RVA: 0x00064C8F File Offset: 0x00062E8F
		public unsafe float DistanceFieldSelfShadowBias
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_DistanceFieldSelfShadowBias);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_DistanceFieldSelfShadowBias) = value;
			}
		}

		// Token: 0x17000D55 RID: 3413
		// (get) Token: 0x060047F7 RID: 18423 RVA: 0x00064CA0 File Offset: 0x00062EA0
		// (set) Token: 0x060047F8 RID: 18424 RVA: 0x00064CB4 File Offset: 0x00062EB4
		public unsafe UBodySetup BodySetup
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBodySetup>(base.NativePtr / (IntPtr)sizeof(void*) + UStaticMesh.__PropertyOffset_BodySetup);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UStaticMesh.__PropertyOffset_BodySetup, value);
			}
		}

		// Token: 0x17000D56 RID: 3414
		// (get) Token: 0x060047F9 RID: 18425 RVA: 0x00064CC9 File Offset: 0x00062EC9
		// (set) Token: 0x060047FA RID: 18426 RVA: 0x00064CD9 File Offset: 0x00062ED9
		public unsafe int LODForCollision
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_LODForCollision);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_LODForCollision) = value;
			}
		}

		// Token: 0x17000D57 RID: 3415
		// (get) Token: 0x060047FB RID: 18427 RVA: 0x00064CEA File Offset: 0x00062EEA
		// (set) Token: 0x060047FC RID: 18428 RVA: 0x00064CFE File Offset: 0x00062EFE
		public unsafe UBodySetup StandaloneBodySetup
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBodySetup>(base.NativePtr / (IntPtr)sizeof(void*) + UStaticMesh.__PropertyOffset_StandaloneBodySetup);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UStaticMesh.__PropertyOffset_StandaloneBodySetup, value);
			}
		}

		// Token: 0x17000D58 RID: 3416
		// (get) Token: 0x060047FD RID: 18429 RVA: 0x00064D13 File Offset: 0x00062F13
		// (set) Token: 0x060047FE RID: 18430 RVA: 0x00064D2C File Offset: 0x00062F2C
		public unsafe bool bUseStandaloneBodySetup
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_bUseStandaloneBodySetup) & UStaticMesh.__PropertyMask_bUseStandaloneBodySetup) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_bUseStandaloneBodySetup) = ((*(base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_bUseStandaloneBodySetup) & ~UStaticMesh.__PropertyMask_bUseStandaloneBodySetup) | (value ? UStaticMesh.__PropertyMask_bUseStandaloneBodySetup : 0));
			}
		}

		// Token: 0x17000D59 RID: 3417
		// (get) Token: 0x060047FF RID: 18431 RVA: 0x00064D5C File Offset: 0x00062F5C
		// (set) Token: 0x06004800 RID: 18432 RVA: 0x00064D75 File Offset: 0x00062F75
		public unsafe bool bGenerateMeshDistanceField
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_bGenerateMeshDistanceField) & UStaticMesh.__PropertyMask_bGenerateMeshDistanceField) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_bGenerateMeshDistanceField) = ((*(base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_bGenerateMeshDistanceField) & ~UStaticMesh.__PropertyMask_bGenerateMeshDistanceField) | (value ? UStaticMesh.__PropertyMask_bGenerateMeshDistanceField : 0));
			}
		}

		// Token: 0x17000D5A RID: 3418
		// (get) Token: 0x06004801 RID: 18433 RVA: 0x00064DA5 File Offset: 0x00062FA5
		// (set) Token: 0x06004802 RID: 18434 RVA: 0x00064DBE File Offset: 0x00062FBE
		public unsafe bool bStripComplexCollisionForConsole_DEPRECATED
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_bStripComplexCollisionForConsole_DEPRECATED) & UStaticMesh.__PropertyMask_bStripComplexCollisionForConsole_DEPRECATED) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_bStripComplexCollisionForConsole_DEPRECATED) = ((*(base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_bStripComplexCollisionForConsole_DEPRECATED) & ~UStaticMesh.__PropertyMask_bStripComplexCollisionForConsole_DEPRECATED) | (value ? UStaticMesh.__PropertyMask_bStripComplexCollisionForConsole_DEPRECATED : 0));
			}
		}

		// Token: 0x17000D5B RID: 3419
		// (get) Token: 0x06004803 RID: 18435 RVA: 0x00064DEE File Offset: 0x00062FEE
		// (set) Token: 0x06004804 RID: 18436 RVA: 0x00064E07 File Offset: 0x00063007
		public unsafe bool bHasNavigationData
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_bHasNavigationData) & UStaticMesh.__PropertyMask_bHasNavigationData) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_bHasNavigationData) = ((*(base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_bHasNavigationData) & ~UStaticMesh.__PropertyMask_bHasNavigationData) | (value ? UStaticMesh.__PropertyMask_bHasNavigationData : 0));
			}
		}

		// Token: 0x17000D5C RID: 3420
		// (get) Token: 0x06004805 RID: 18437 RVA: 0x00064E37 File Offset: 0x00063037
		// (set) Token: 0x06004806 RID: 18438 RVA: 0x00064E50 File Offset: 0x00063050
		public unsafe bool bSupportUniformlyDistributedSampling
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_bSupportUniformlyDistributedSampling) & UStaticMesh.__PropertyMask_bSupportUniformlyDistributedSampling) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_bSupportUniformlyDistributedSampling) = ((*(base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_bSupportUniformlyDistributedSampling) & ~UStaticMesh.__PropertyMask_bSupportUniformlyDistributedSampling) | (value ? UStaticMesh.__PropertyMask_bSupportUniformlyDistributedSampling : 0));
			}
		}

		// Token: 0x17000D5D RID: 3421
		// (get) Token: 0x06004807 RID: 18439 RVA: 0x00064E80 File Offset: 0x00063080
		// (set) Token: 0x06004808 RID: 18440 RVA: 0x00064E99 File Offset: 0x00063099
		public unsafe bool bSupportPhysicalMaterialMasks
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_bSupportPhysicalMaterialMasks) & UStaticMesh.__PropertyMask_bSupportPhysicalMaterialMasks) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_bSupportPhysicalMaterialMasks) = ((*(base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_bSupportPhysicalMaterialMasks) & ~UStaticMesh.__PropertyMask_bSupportPhysicalMaterialMasks) | (value ? UStaticMesh.__PropertyMask_bSupportPhysicalMaterialMasks : 0));
			}
		}

		// Token: 0x17000D5E RID: 3422
		// (get) Token: 0x06004809 RID: 18441 RVA: 0x00064EC9 File Offset: 0x000630C9
		// (set) Token: 0x0600480A RID: 18442 RVA: 0x00064EE2 File Offset: 0x000630E2
		public unsafe bool bIsBuiltAtRuntime
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_bIsBuiltAtRuntime) & UStaticMesh.__PropertyMask_bIsBuiltAtRuntime) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_bIsBuiltAtRuntime) = ((*(base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_bIsBuiltAtRuntime) & ~UStaticMesh.__PropertyMask_bIsBuiltAtRuntime) | (value ? UStaticMesh.__PropertyMask_bIsBuiltAtRuntime : 0));
			}
		}

		// Token: 0x17000D5F RID: 3423
		// (get) Token: 0x0600480B RID: 18443 RVA: 0x00064F12 File Offset: 0x00063112
		// (set) Token: 0x0600480C RID: 18444 RVA: 0x00064F2B File Offset: 0x0006312B
		public unsafe bool bAllowCPUAccess
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_bAllowCPUAccess) & UStaticMesh.__PropertyMask_bAllowCPUAccess) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_bAllowCPUAccess) = ((*(base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_bAllowCPUAccess) & ~UStaticMesh.__PropertyMask_bAllowCPUAccess) | (value ? UStaticMesh.__PropertyMask_bAllowCPUAccess : 0));
			}
		}

		// Token: 0x17000D60 RID: 3424
		// (get) Token: 0x0600480D RID: 18445 RVA: 0x00064F5B File Offset: 0x0006315B
		// (set) Token: 0x0600480E RID: 18446 RVA: 0x00064F74 File Offset: 0x00063174
		public unsafe bool bSupportGpuUniformlyDistributedSampling
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_bSupportGpuUniformlyDistributedSampling) & UStaticMesh.__PropertyMask_bSupportGpuUniformlyDistributedSampling) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_bSupportGpuUniformlyDistributedSampling) = ((*(base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_bSupportGpuUniformlyDistributedSampling) & ~UStaticMesh.__PropertyMask_bSupportGpuUniformlyDistributedSampling) | (value ? UStaticMesh.__PropertyMask_bSupportGpuUniformlyDistributedSampling : 0));
			}
		}

		// Token: 0x17000D61 RID: 3425
		// (get) Token: 0x0600480F RID: 18447 RVA: 0x00064FA4 File Offset: 0x000631A4
		// (set) Token: 0x06004810 RID: 18448 RVA: 0x00064FBD File Offset: 0x000631BD
		public unsafe bool bAllowVertexCompress
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_bAllowVertexCompress) & UStaticMesh.__PropertyMask_bAllowVertexCompress) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_bAllowVertexCompress) = ((*(base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_bAllowVertexCompress) & ~UStaticMesh.__PropertyMask_bAllowVertexCompress) | (value ? UStaticMesh.__PropertyMask_bAllowVertexCompress : 0));
			}
		}

		// Token: 0x17000D62 RID: 3426
		// (get) Token: 0x06004811 RID: 18449 RVA: 0x00064FED File Offset: 0x000631ED
		// (set) Token: 0x06004812 RID: 18450 RVA: 0x00065006 File Offset: 0x00063206
		public unsafe bool bPreviewVertexCompressed
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_bPreviewVertexCompressed) & UStaticMesh.__PropertyMask_bPreviewVertexCompressed) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_bPreviewVertexCompressed) = ((*(base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_bPreviewVertexCompressed) & ~UStaticMesh.__PropertyMask_bPreviewVertexCompressed) | (value ? UStaticMesh.__PropertyMask_bPreviewVertexCompressed : 0));
			}
		}

		// Token: 0x17000D63 RID: 3427
		// (get) Token: 0x06004813 RID: 18451 RVA: 0x00065036 File Offset: 0x00063236
		// (set) Token: 0x06004814 RID: 18452 RVA: 0x0006504F File Offset: 0x0006324F
		public unsafe bool bAfterVertexCompress
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_bAfterVertexCompress) & UStaticMesh.__PropertyMask_bAfterVertexCompress) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_bAfterVertexCompress) = ((*(base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_bAfterVertexCompress) & ~UStaticMesh.__PropertyMask_bAfterVertexCompress) | (value ? UStaticMesh.__PropertyMask_bAfterVertexCompress : 0));
			}
		}

		// Token: 0x17000D64 RID: 3428
		// (get) Token: 0x06004815 RID: 18453 RVA: 0x0006507F File Offset: 0x0006327F
		// (set) Token: 0x06004816 RID: 18454 RVA: 0x00065098 File Offset: 0x00063298
		public unsafe bool bBasePassVelocity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_bBasePassVelocity) & UStaticMesh.__PropertyMask_bBasePassVelocity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_bBasePassVelocity) = ((*(base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_bBasePassVelocity) & ~UStaticMesh.__PropertyMask_bBasePassVelocity) | (value ? UStaticMesh.__PropertyMask_bBasePassVelocity : 0));
			}
		}

		// Token: 0x17000D65 RID: 3429
		// (get) Token: 0x06004817 RID: 18455 RVA: 0x000650C8 File Offset: 0x000632C8
		// (set) Token: 0x06004818 RID: 18456 RVA: 0x000650DC File Offset: 0x000632DC
		public unsafe FVector PositiveBoundsExtension
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_PositiveBoundsExtension);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_PositiveBoundsExtension) = value;
			}
		}

		// Token: 0x17000D66 RID: 3430
		// (get) Token: 0x06004819 RID: 18457 RVA: 0x000650F1 File Offset: 0x000632F1
		// (set) Token: 0x0600481A RID: 18458 RVA: 0x00065105 File Offset: 0x00063305
		public unsafe FVector NegativeBoundsExtension
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_NegativeBoundsExtension);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_NegativeBoundsExtension) = value;
			}
		}

		// Token: 0x17000D67 RID: 3431
		// (get) Token: 0x0600481B RID: 18459 RVA: 0x0006511A File Offset: 0x0006331A
		// (set) Token: 0x0600481C RID: 18460 RVA: 0x0006512E File Offset: 0x0006332E
		public unsafe FBoxSphereBounds ExtendedBounds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_ExtendedBounds);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_ExtendedBounds) = value;
			}
		}

		// Token: 0x17000D68 RID: 3432
		// (get) Token: 0x0600481D RID: 18461 RVA: 0x00065143 File Offset: 0x00063343
		// (set) Token: 0x0600481E RID: 18462 RVA: 0x00065153 File Offset: 0x00063353
		public unsafe int ElementToIgnoreForTexFactor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_ElementToIgnoreForTexFactor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_ElementToIgnoreForTexFactor) = value;
			}
		}

		// Token: 0x17000D69 RID: 3433
		// (get) Token: 0x0600481F RID: 18463 RVA: 0x00065164 File Offset: 0x00063364
		// (set) Token: 0x06004820 RID: 18464 RVA: 0x00065178 File Offset: 0x00063378
		public unsafe UObject EditableMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UObject>(base.NativePtr / (IntPtr)sizeof(void*) + UStaticMesh.__PropertyOffset_EditableMesh);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UStaticMesh.__PropertyOffset_EditableMesh, value);
			}
		}

		// Token: 0x17000D6A RID: 3434
		// (get) Token: 0x06004821 RID: 18465 RVA: 0x0006518D File Offset: 0x0006338D
		// (set) Token: 0x06004822 RID: 18466 RVA: 0x0006519D File Offset: 0x0006339D
		public unsafe bool bUseSpecialBodySetup
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_bUseSpecialBodySetup) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_bUseSpecialBodySetup) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000D6B RID: 3435
		// (get) Token: 0x06004823 RID: 18467 RVA: 0x000651AE File Offset: 0x000633AE
		// (set) Token: 0x06004824 RID: 18468 RVA: 0x000651BE File Offset: 0x000633BE
		public unsafe bool bOnlyUseSimpleCollision
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_bOnlyUseSimpleCollision) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_bOnlyUseSimpleCollision) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000D6C RID: 3436
		// (get) Token: 0x06004825 RID: 18469 RVA: 0x000651CF File Offset: 0x000633CF
		// (set) Token: 0x06004826 RID: 18470 RVA: 0x000651DF File Offset: 0x000633DF
		public unsafe bool bKuroAutoReduce
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_bKuroAutoReduce) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_bKuroAutoReduce) = (value ? 1 : 0);
			}
		}

		// Token: 0x06004827 RID: 18471 RVA: 0x000651F0 File Offset: 0x000633F0
		public int GetNumTriangles(int LODIndex)
		{
			return UStaticMesh.__GetNumTriangles_Internal(base.NativePtr, LODIndex);
		}

		// Token: 0x06004828 RID: 18472 RVA: 0x000651FE File Offset: 0x000633FE
		public int GetNumSections(int InLOD)
		{
			return UStaticMesh.__GetNumSections_Internal(base.NativePtr, InLOD);
		}

		// Token: 0x06004829 RID: 18473 RVA: 0x0006520C File Offset: 0x0006340C
		public int GetNumLODs()
		{
			return UStaticMesh.__GetNumLODs_Internal(base.NativePtr);
		}

		// Token: 0x0600482A RID: 18474 RVA: 0x0006521C File Offset: 0x0006341C
		[SkipLocalsInit]
		public unsafe void GetMinimumLODForPlatforms(ref TMap<FName, int> PlatformMinimumLODs)
		{
			UStaticMesh.__GetMinimumLODForPlatforms_FunctionParams* ptr = stackalloc UStaticMesh.__GetMinimumLODForPlatforms_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UStaticMesh.__GetMinimumLODForPlatforms_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UStaticMesh.__GetMinimumLODForPlatforms_NativeFunctionPtr, (void*)ptr, 1);
			TMap<FName, int> tmap = PlatformMinimumLODs;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->PlatformMinimumLODs);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UStaticMesh.__GetMinimumLODForPlatforms_NativeFunctionPtr, (void*)ptr);
			TMap<FName, int> tmap2 = PlatformMinimumLODs;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->PlatformMinimumLODs);
			}
			UnrealReflectionUtils.DestroyStruct(UStaticMesh.__GetMinimumLODForPlatforms_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600482B RID: 18475 RVA: 0x00065294 File Offset: 0x00063494
		[SkipLocalsInit]
		public unsafe int GetMinimumLODForPlatform(in FName PlatformName)
		{
			UStaticMesh.__GetMinimumLODForPlatform_FunctionParams* ptr = stackalloc UStaticMesh.__GetMinimumLODForPlatform_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UStaticMesh.__GetMinimumLODForPlatform_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UStaticMesh.__GetMinimumLODForPlatform_NativeFunctionPtr, (void*)ptr, 1);
			ptr->PlatformName = PlatformName;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UStaticMesh.__GetMinimumLODForPlatform_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0600482C RID: 18476 RVA: 0x000652E8 File Offset: 0x000634E8
		[NullableContext(1)]
		public unsafe int GetMaterialIndexByDisplayName(string DiaplayName)
		{
			FString fstring = FString.AllocTemp(DiaplayName);
			int result = UStaticMesh.__GetMaterialIndexByDisplayName_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0600482D RID: 18477 RVA: 0x00065312 File Offset: 0x00063512
		public int GetMaterialIndex(FName MaterialSlotName)
		{
			return UStaticMesh.__GetMaterialIndex_Internal(base.NativePtr, MaterialSlotName);
		}

		// Token: 0x0600482E RID: 18478 RVA: 0x00065320 File Offset: 0x00063520
		public UMaterialInterface GetMaterial(int MaterialIndex)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UMaterialInterface>(UStaticMesh.__GetMaterial_Internal(base.NativePtr, MaterialIndex));
		}

		// Token: 0x0600482F RID: 18479 RVA: 0x00065333 File Offset: 0x00063533
		public FBoxSphereBounds GetBounds()
		{
			return UStaticMesh.__GetBounds_Internal(base.NativePtr);
		}

		// Token: 0x06004830 RID: 18480 RVA: 0x00065340 File Offset: 0x00063540
		public FBox GetBoundingBox()
		{
			return UStaticMesh.__GetBoundingBox_Internal(base.NativePtr);
		}

		// Token: 0x06004831 RID: 18481 RVA: 0x0006534D File Offset: 0x0006354D
		public bool GetAllowVertexCompress()
		{
			return UStaticMesh.__GetAllowVertexCompress_Internal(base.NativePtr);
		}

		// Token: 0x06004832 RID: 18482 RVA: 0x0006535A File Offset: 0x0006355A
		public FName AddMaterial(UMaterialInterface Material)
		{
			return UStaticMesh.__AddMaterial_Internal(base.NativePtr, (Material != null) ? Material.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06004833 RID: 18483
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetNumTriangles_Internal(IntPtr @this, int LODIndex);

		// Token: 0x06004834 RID: 18484
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetNumSections_Internal(IntPtr @this, int InLOD);

		// Token: 0x06004835 RID: 18485
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetNumLODs_Internal(IntPtr @this);

		// Token: 0x06004836 RID: 18486
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetMaterialIndexByDisplayName_Internal(IntPtr @this, in FString DiaplayName);

		// Token: 0x06004837 RID: 18487
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetMaterialIndex_Internal(IntPtr @this, FName MaterialSlotName);

		// Token: 0x06004838 RID: 18488
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetMaterial_Internal(IntPtr @this, int MaterialIndex);

		// Token: 0x06004839 RID: 18489
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FBoxSphereBounds __GetBounds_Internal(IntPtr @this);

		// Token: 0x0600483A RID: 18490
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FBox __GetBoundingBox_Internal(IntPtr @this);

		// Token: 0x0600483B RID: 18491
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetAllowVertexCompress_Internal(IntPtr @this);

		// Token: 0x0600483C RID: 18492
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FName __AddMaterial_Internal(IntPtr @this, IntPtr Material);

		// Token: 0x0600483D RID: 18493 RVA: 0x00065377 File Offset: 0x00063577
		static UStaticMesh()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.StaticMesh");
		}

		// Token: 0x0600483E RID: 18494 RVA: 0x00065385 File Offset: 0x00063585
		protected UStaticMesh(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001BB7 RID: 7095
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.StaticMesh";

		// Token: 0x04001BB8 RID: 7096
		private static IntPtr _ClassPtr;

		// Token: 0x04001BB9 RID: 7097
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04001BBA RID: 7098
		internal static int __PropertyOffset_bUseKuroLODDistance;

		// Token: 0x04001BBB RID: 7099
		internal static int __PropertyOffset_bBakeImposter;

		// Token: 0x04001BBC RID: 7100
		internal static int __PropertyOffset_BakeImposterType;

		// Token: 0x04001BBD RID: 7101
		internal static int __PropertyOffset_bCastRasterShadowsInRaytracing;

		// Token: 0x04001BBE RID: 7102
		internal static int __PropertyOffset_bUseCustomDataForWorldMap;

		// Token: 0x04001BBF RID: 7103
		internal static int __PropertyOffset_ScreenSizeCullRatio;

		// Token: 0x04001BC0 RID: 7104
		internal static int __PropertyOffset_Tags;

		// Token: 0x04001BC1 RID: 7105
		private TArray<FName> _Tags;

		// Token: 0x04001BC2 RID: 7106
		internal static int __PropertyOffset_LpvBiasMultiplier;

		// Token: 0x04001BC3 RID: 7107
		internal static int __PropertyOffset_LightmapUVDensity;

		// Token: 0x04001BC4 RID: 7108
		internal static int __PropertyOffset_LightMapResolution;

		// Token: 0x04001BC5 RID: 7109
		internal static int __PropertyOffset_LightMapCoordinateIndex;

		// Token: 0x04001BC6 RID: 7110
		internal static int __PropertyOffset_DistanceFieldSelfShadowBias;

		// Token: 0x04001BC7 RID: 7111
		internal static int __PropertyOffset_BodySetup;

		// Token: 0x04001BC8 RID: 7112
		internal static int __PropertyOffset_LODForCollision;

		// Token: 0x04001BC9 RID: 7113
		internal static int __PropertyOffset_StandaloneBodySetup;

		// Token: 0x04001BCA RID: 7114
		internal static int __PropertyOffset_bUseStandaloneBodySetup;

		// Token: 0x04001BCB RID: 7115
		internal static byte __PropertyMask_bUseStandaloneBodySetup;

		// Token: 0x04001BCC RID: 7116
		internal static int __PropertyOffset_bGenerateMeshDistanceField;

		// Token: 0x04001BCD RID: 7117
		internal static byte __PropertyMask_bGenerateMeshDistanceField;

		// Token: 0x04001BCE RID: 7118
		internal static int __PropertyOffset_bStripComplexCollisionForConsole_DEPRECATED;

		// Token: 0x04001BCF RID: 7119
		internal static byte __PropertyMask_bStripComplexCollisionForConsole_DEPRECATED;

		// Token: 0x04001BD0 RID: 7120
		internal static int __PropertyOffset_bHasNavigationData;

		// Token: 0x04001BD1 RID: 7121
		internal static byte __PropertyMask_bHasNavigationData;

		// Token: 0x04001BD2 RID: 7122
		internal static int __PropertyOffset_bSupportUniformlyDistributedSampling;

		// Token: 0x04001BD3 RID: 7123
		internal static byte __PropertyMask_bSupportUniformlyDistributedSampling;

		// Token: 0x04001BD4 RID: 7124
		internal static int __PropertyOffset_bSupportPhysicalMaterialMasks;

		// Token: 0x04001BD5 RID: 7125
		internal static byte __PropertyMask_bSupportPhysicalMaterialMasks;

		// Token: 0x04001BD6 RID: 7126
		internal static int __PropertyOffset_bIsBuiltAtRuntime;

		// Token: 0x04001BD7 RID: 7127
		internal static byte __PropertyMask_bIsBuiltAtRuntime;

		// Token: 0x04001BD8 RID: 7128
		internal static int __PropertyOffset_bAllowCPUAccess;

		// Token: 0x04001BD9 RID: 7129
		internal static byte __PropertyMask_bAllowCPUAccess;

		// Token: 0x04001BDA RID: 7130
		internal static int __PropertyOffset_bSupportGpuUniformlyDistributedSampling;

		// Token: 0x04001BDB RID: 7131
		internal static byte __PropertyMask_bSupportGpuUniformlyDistributedSampling;

		// Token: 0x04001BDC RID: 7132
		internal static int __PropertyOffset_bAllowVertexCompress;

		// Token: 0x04001BDD RID: 7133
		internal static byte __PropertyMask_bAllowVertexCompress;

		// Token: 0x04001BDE RID: 7134
		internal static int __PropertyOffset_bPreviewVertexCompressed;

		// Token: 0x04001BDF RID: 7135
		internal static byte __PropertyMask_bPreviewVertexCompressed;

		// Token: 0x04001BE0 RID: 7136
		internal static int __PropertyOffset_bAfterVertexCompress;

		// Token: 0x04001BE1 RID: 7137
		internal static byte __PropertyMask_bAfterVertexCompress;

		// Token: 0x04001BE2 RID: 7138
		internal static int __PropertyOffset_bBasePassVelocity;

		// Token: 0x04001BE3 RID: 7139
		internal static byte __PropertyMask_bBasePassVelocity;

		// Token: 0x04001BE4 RID: 7140
		internal static int __PropertyOffset_PositiveBoundsExtension;

		// Token: 0x04001BE5 RID: 7141
		internal static int __PropertyOffset_NegativeBoundsExtension;

		// Token: 0x04001BE6 RID: 7142
		internal static int __PropertyOffset_ExtendedBounds;

		// Token: 0x04001BE7 RID: 7143
		internal static int __PropertyOffset_ElementToIgnoreForTexFactor;

		// Token: 0x04001BE8 RID: 7144
		internal static int __PropertyOffset_EditableMesh;

		// Token: 0x04001BE9 RID: 7145
		internal static int __PropertyOffset_bUseSpecialBodySetup;

		// Token: 0x04001BEA RID: 7146
		internal static int __PropertyOffset_bOnlyUseSimpleCollision;

		// Token: 0x04001BEB RID: 7147
		internal static int __PropertyOffset_bKuroAutoReduce;

		// Token: 0x04001BEC RID: 7148
		private static IntPtr __GetMinimumLODForPlatforms_NativeFunctionPtr;

		// Token: 0x04001BED RID: 7149
		private static IntPtr __GetMinimumLODForPlatform_NativeFunctionPtr;

		// Token: 0x020009E7 RID: 2535
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetMinimumLODForPlatforms_FunctionParams
		{
			// Token: 0x04005980 RID: 22912
			[FieldOffset(0)]
			public byte PlatformMinimumLODs;
		}

		// Token: 0x020009E8 RID: 2536
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetMinimumLODForPlatform_FunctionParams
		{
			// Token: 0x04005981 RID: 22913
			[FieldOffset(0)]
			public FName PlatformName;

			// Token: 0x04005982 RID: 22914
			[FieldOffset(12)]
			public int __Result;
		}
	}
}
