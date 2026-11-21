using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000260 RID: 608
	[UnrealObjectPath("/Script/Engine.PlanarReflectionComponent")]
	[UnrealStructLayout(1168, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1168)]
	public class UPlanarReflectionComponent : USceneCaptureComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06003434 RID: 13364 RVA: 0x0004A64B File Offset: 0x0004884B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UPlanarReflectionComponent._ClassPtr;
		}

		// Token: 0x06003435 RID: 13365 RVA: 0x0004A658 File Offset: 0x00048858
		public UPlanarReflectionComponent() : this(BuiltinUtils.AllocNativeUObject(UPlanarReflectionComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06003436 RID: 13366 RVA: 0x0004A680 File Offset: 0x00048880
		[NullableContext(1)]
		public UPlanarReflectionComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UPlanarReflectionComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000743 RID: 1859
		// (get) Token: 0x06003437 RID: 13367 RVA: 0x0004A6B3 File Offset: 0x000488B3
		// (set) Token: 0x06003438 RID: 13368 RVA: 0x0004A6C7 File Offset: 0x000488C7
		[Nullable(2)]
		public unsafe UBoxComponent PreviewBox
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + UPlanarReflectionComponent.__PropertyOffset_PreviewBox);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UPlanarReflectionComponent.__PropertyOffset_PreviewBox, value);
			}
		}

		// Token: 0x17000744 RID: 1860
		// (get) Token: 0x06003439 RID: 13369 RVA: 0x0004A6DC File Offset: 0x000488DC
		// (set) Token: 0x0600343A RID: 13370 RVA: 0x0004A6EC File Offset: 0x000488EC
		public unsafe float NormalDistortionStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPlanarReflectionComponent.__PropertyOffset_NormalDistortionStrength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPlanarReflectionComponent.__PropertyOffset_NormalDistortionStrength) = value;
			}
		}

		// Token: 0x17000745 RID: 1861
		// (get) Token: 0x0600343B RID: 13371 RVA: 0x0004A6FD File Offset: 0x000488FD
		// (set) Token: 0x0600343C RID: 13372 RVA: 0x0004A70D File Offset: 0x0004890D
		public unsafe float PrefilterRoughness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPlanarReflectionComponent.__PropertyOffset_PrefilterRoughness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPlanarReflectionComponent.__PropertyOffset_PrefilterRoughness) = value;
			}
		}

		// Token: 0x17000746 RID: 1862
		// (get) Token: 0x0600343D RID: 13373 RVA: 0x0004A71E File Offset: 0x0004891E
		// (set) Token: 0x0600343E RID: 13374 RVA: 0x0004A72E File Offset: 0x0004892E
		public unsafe float PrefilterRoughnessDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPlanarReflectionComponent.__PropertyOffset_PrefilterRoughnessDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPlanarReflectionComponent.__PropertyOffset_PrefilterRoughnessDistance) = value;
			}
		}

		// Token: 0x17000747 RID: 1863
		// (get) Token: 0x0600343F RID: 13375 RVA: 0x0004A73F File Offset: 0x0004893F
		// (set) Token: 0x06003440 RID: 13376 RVA: 0x0004A74F File Offset: 0x0004894F
		public unsafe int ScreenPercentage
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPlanarReflectionComponent.__PropertyOffset_ScreenPercentage);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPlanarReflectionComponent.__PropertyOffset_ScreenPercentage) = value;
			}
		}

		// Token: 0x17000748 RID: 1864
		// (get) Token: 0x06003441 RID: 13377 RVA: 0x0004A760 File Offset: 0x00048960
		// (set) Token: 0x06003442 RID: 13378 RVA: 0x0004A770 File Offset: 0x00048970
		public unsafe float MirrorHalfWidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPlanarReflectionComponent.__PropertyOffset_MirrorHalfWidth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPlanarReflectionComponent.__PropertyOffset_MirrorHalfWidth) = value;
			}
		}

		// Token: 0x17000749 RID: 1865
		// (get) Token: 0x06003443 RID: 13379 RVA: 0x0004A781 File Offset: 0x00048981
		// (set) Token: 0x06003444 RID: 13380 RVA: 0x0004A791 File Offset: 0x00048991
		public unsafe float MirrorHalfHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPlanarReflectionComponent.__PropertyOffset_MirrorHalfHeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPlanarReflectionComponent.__PropertyOffset_MirrorHalfHeight) = value;
			}
		}

		// Token: 0x1700074A RID: 1866
		// (get) Token: 0x06003445 RID: 13381 RVA: 0x0004A7A2 File Offset: 0x000489A2
		// (set) Token: 0x06003446 RID: 13382 RVA: 0x0004A7B2 File Offset: 0x000489B2
		public unsafe float MirrorBoundsPadding
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPlanarReflectionComponent.__PropertyOffset_MirrorBoundsPadding);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPlanarReflectionComponent.__PropertyOffset_MirrorBoundsPadding) = value;
			}
		}

		// Token: 0x1700074B RID: 1867
		// (get) Token: 0x06003447 RID: 13383 RVA: 0x0004A7C3 File Offset: 0x000489C3
		// (set) Token: 0x06003448 RID: 13384 RVA: 0x0004A7D3 File Offset: 0x000489D3
		public unsafe float ExtraFOV
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPlanarReflectionComponent.__PropertyOffset_ExtraFOV);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPlanarReflectionComponent.__PropertyOffset_ExtraFOV) = value;
			}
		}

		// Token: 0x1700074C RID: 1868
		// (get) Token: 0x06003449 RID: 13385 RVA: 0x0004A7E4 File Offset: 0x000489E4
		// (set) Token: 0x0600344A RID: 13386 RVA: 0x0004A7F4 File Offset: 0x000489F4
		public unsafe float DistanceFromPlaneFadeStart_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPlanarReflectionComponent.__PropertyOffset_DistanceFromPlaneFadeStart_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPlanarReflectionComponent.__PropertyOffset_DistanceFromPlaneFadeStart_DEPRECATED) = value;
			}
		}

		// Token: 0x1700074D RID: 1869
		// (get) Token: 0x0600344B RID: 13387 RVA: 0x0004A805 File Offset: 0x00048A05
		// (set) Token: 0x0600344C RID: 13388 RVA: 0x0004A815 File Offset: 0x00048A15
		public unsafe float DistanceFromPlaneFadeEnd_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPlanarReflectionComponent.__PropertyOffset_DistanceFromPlaneFadeEnd_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPlanarReflectionComponent.__PropertyOffset_DistanceFromPlaneFadeEnd_DEPRECATED) = value;
			}
		}

		// Token: 0x1700074E RID: 1870
		// (get) Token: 0x0600344D RID: 13389 RVA: 0x0004A826 File Offset: 0x00048A26
		// (set) Token: 0x0600344E RID: 13390 RVA: 0x0004A836 File Offset: 0x00048A36
		public unsafe float DistanceFromPlaneFadeoutStart
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPlanarReflectionComponent.__PropertyOffset_DistanceFromPlaneFadeoutStart);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPlanarReflectionComponent.__PropertyOffset_DistanceFromPlaneFadeoutStart) = value;
			}
		}

		// Token: 0x1700074F RID: 1871
		// (get) Token: 0x0600344F RID: 13391 RVA: 0x0004A847 File Offset: 0x00048A47
		// (set) Token: 0x06003450 RID: 13392 RVA: 0x0004A857 File Offset: 0x00048A57
		public unsafe float DistanceFromPlaneFadeoutEnd
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPlanarReflectionComponent.__PropertyOffset_DistanceFromPlaneFadeoutEnd);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPlanarReflectionComponent.__PropertyOffset_DistanceFromPlaneFadeoutEnd) = value;
			}
		}

		// Token: 0x17000750 RID: 1872
		// (get) Token: 0x06003451 RID: 13393 RVA: 0x0004A868 File Offset: 0x00048A68
		// (set) Token: 0x06003452 RID: 13394 RVA: 0x0004A878 File Offset: 0x00048A78
		public unsafe float AngleFromPlaneFadeStart
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPlanarReflectionComponent.__PropertyOffset_AngleFromPlaneFadeStart);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPlanarReflectionComponent.__PropertyOffset_AngleFromPlaneFadeStart) = value;
			}
		}

		// Token: 0x17000751 RID: 1873
		// (get) Token: 0x06003453 RID: 13395 RVA: 0x0004A889 File Offset: 0x00048A89
		// (set) Token: 0x06003454 RID: 13396 RVA: 0x0004A899 File Offset: 0x00048A99
		public unsafe float AngleFromPlaneFadeEnd
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPlanarReflectionComponent.__PropertyOffset_AngleFromPlaneFadeEnd);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPlanarReflectionComponent.__PropertyOffset_AngleFromPlaneFadeEnd) = value;
			}
		}

		// Token: 0x17000752 RID: 1874
		// (get) Token: 0x06003455 RID: 13397 RVA: 0x0004A8AA File Offset: 0x00048AAA
		// (set) Token: 0x06003456 RID: 13398 RVA: 0x0004A8BA File Offset: 0x00048ABA
		public unsafe bool bShowPreviewPlane
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPlanarReflectionComponent.__PropertyOffset_bShowPreviewPlane) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPlanarReflectionComponent.__PropertyOffset_bShowPreviewPlane) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000753 RID: 1875
		// (get) Token: 0x06003457 RID: 13399 RVA: 0x0004A8CB File Offset: 0x00048ACB
		// (set) Token: 0x06003458 RID: 13400 RVA: 0x0004A8DB File Offset: 0x00048ADB
		public unsafe bool bCustomComposite
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPlanarReflectionComponent.__PropertyOffset_bCustomComposite) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPlanarReflectionComponent.__PropertyOffset_bCustomComposite) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000754 RID: 1876
		// (get) Token: 0x06003459 RID: 13401 RVA: 0x0004A8EC File Offset: 0x00048AEC
		// (set) Token: 0x0600345A RID: 13402 RVA: 0x0004A8FC File Offset: 0x00048AFC
		public unsafe int Priority
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPlanarReflectionComponent.__PropertyOffset_Priority);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPlanarReflectionComponent.__PropertyOffset_Priority) = value;
			}
		}

		// Token: 0x17000755 RID: 1877
		// (get) Token: 0x0600345B RID: 13403 RVA: 0x0004A90D File Offset: 0x00048B0D
		// (set) Token: 0x0600345C RID: 13404 RVA: 0x0004A91D File Offset: 0x00048B1D
		public unsafe bool bEnableCapture
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPlanarReflectionComponent.__PropertyOffset_bEnableCapture) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPlanarReflectionComponent.__PropertyOffset_bEnableCapture) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000756 RID: 1878
		// (get) Token: 0x0600345D RID: 13405 RVA: 0x0004A92E File Offset: 0x00048B2E
		// (set) Token: 0x0600345E RID: 13406 RVA: 0x0004A93E File Offset: 0x00048B3E
		public unsafe float CaptureInterval
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPlanarReflectionComponent.__PropertyOffset_CaptureInterval);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPlanarReflectionComponent.__PropertyOffset_CaptureInterval) = value;
			}
		}

		// Token: 0x17000757 RID: 1879
		// (get) Token: 0x0600345F RID: 13407 RVA: 0x0004A94F File Offset: 0x00048B4F
		// (set) Token: 0x06003460 RID: 13408 RVA: 0x0004A95F File Offset: 0x00048B5F
		public unsafe bool bRenderDynamicShadows
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPlanarReflectionComponent.__PropertyOffset_bRenderDynamicShadows) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPlanarReflectionComponent.__PropertyOffset_bRenderDynamicShadows) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000758 RID: 1880
		// (get) Token: 0x06003461 RID: 13409 RVA: 0x0004A970 File Offset: 0x00048B70
		// (set) Token: 0x06003462 RID: 13410 RVA: 0x0004A980 File Offset: 0x00048B80
		public unsafe bool bRenderDecals
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPlanarReflectionComponent.__PropertyOffset_bRenderDecals) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPlanarReflectionComponent.__PropertyOffset_bRenderDecals) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000759 RID: 1881
		// (get) Token: 0x06003463 RID: 13411 RVA: 0x0004A991 File Offset: 0x00048B91
		// (set) Token: 0x06003464 RID: 13412 RVA: 0x0004A9A1 File Offset: 0x00048BA1
		public unsafe bool bRenderAmbientOcclusion
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPlanarReflectionComponent.__PropertyOffset_bRenderAmbientOcclusion) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPlanarReflectionComponent.__PropertyOffset_bRenderAmbientOcclusion) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700075A RID: 1882
		// (get) Token: 0x06003465 RID: 13413 RVA: 0x0004A9B2 File Offset: 0x00048BB2
		// (set) Token: 0x06003466 RID: 13414 RVA: 0x0004A9C2 File Offset: 0x00048BC2
		public unsafe bool bRenderTranslucency
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPlanarReflectionComponent.__PropertyOffset_bRenderTranslucency) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPlanarReflectionComponent.__PropertyOffset_bRenderTranslucency) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700075B RID: 1883
		// (get) Token: 0x06003467 RID: 13415 RVA: 0x0004A9D3 File Offset: 0x00048BD3
		// (set) Token: 0x06003468 RID: 13416 RVA: 0x0004A9E3 File Offset: 0x00048BE3
		public unsafe bool bRenderFog
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPlanarReflectionComponent.__PropertyOffset_bRenderFog) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPlanarReflectionComponent.__PropertyOffset_bRenderFog) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700075C RID: 1884
		// (get) Token: 0x06003469 RID: 13417 RVA: 0x0004A9F4 File Offset: 0x00048BF4
		// (set) Token: 0x0600346A RID: 13418 RVA: 0x0004AA04 File Offset: 0x00048C04
		public unsafe bool bRenderAtmosphere
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPlanarReflectionComponent.__PropertyOffset_bRenderAtmosphere) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPlanarReflectionComponent.__PropertyOffset_bRenderAtmosphere) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700075D RID: 1885
		// (get) Token: 0x0600346B RID: 13419 RVA: 0x0004AA15 File Offset: 0x00048C15
		// (set) Token: 0x0600346C RID: 13420 RVA: 0x0004AA25 File Offset: 0x00048C25
		public unsafe bool bRenderGodRay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPlanarReflectionComponent.__PropertyOffset_bRenderGodRay) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPlanarReflectionComponent.__PropertyOffset_bRenderGodRay) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700075E RID: 1886
		// (get) Token: 0x0600346D RID: 13421 RVA: 0x0004AA36 File Offset: 0x00048C36
		// (set) Token: 0x0600346E RID: 13422 RVA: 0x0004AA46 File Offset: 0x00048C46
		public unsafe bool bRenderVolumetricLight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPlanarReflectionComponent.__PropertyOffset_bRenderVolumetricLight) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPlanarReflectionComponent.__PropertyOffset_bRenderVolumetricLight) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700075F RID: 1887
		// (get) Token: 0x0600346F RID: 13423 RVA: 0x0004AA57 File Offset: 0x00048C57
		// (set) Token: 0x06003470 RID: 13424 RVA: 0x0004AA67 File Offset: 0x00048C67
		public unsafe bool bRenderDataDistortion
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPlanarReflectionComponent.__PropertyOffset_bRenderDataDistortion) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPlanarReflectionComponent.__PropertyOffset_bRenderDataDistortion) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000760 RID: 1888
		// (get) Token: 0x06003471 RID: 13425 RVA: 0x0004AA78 File Offset: 0x00048C78
		// (set) Token: 0x06003472 RID: 13426 RVA: 0x0004AA88 File Offset: 0x00048C88
		public unsafe bool bRenderKuroCloud
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPlanarReflectionComponent.__PropertyOffset_bRenderKuroCloud) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPlanarReflectionComponent.__PropertyOffset_bRenderKuroCloud) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000761 RID: 1889
		// (get) Token: 0x06003473 RID: 13427 RVA: 0x0004AA99 File Offset: 0x00048C99
		// (set) Token: 0x06003474 RID: 13428 RVA: 0x0004AAA9 File Offset: 0x00048CA9
		public unsafe bool bEnableGaussianPrefilter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPlanarReflectionComponent.__PropertyOffset_bEnableGaussianPrefilter) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPlanarReflectionComponent.__PropertyOffset_bEnableGaussianPrefilter) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000762 RID: 1890
		// (get) Token: 0x06003475 RID: 13429 RVA: 0x0004AABA File Offset: 0x00048CBA
		// (set) Token: 0x06003476 RID: 13430 RVA: 0x0004AACA File Offset: 0x00048CCA
		public unsafe bool bRenderSceneTwoSided
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPlanarReflectionComponent.__PropertyOffset_bRenderSceneTwoSided) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPlanarReflectionComponent.__PropertyOffset_bRenderSceneTwoSided) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000763 RID: 1891
		// (get) Token: 0x06003477 RID: 13431 RVA: 0x0004AADB File Offset: 0x00048CDB
		// (set) Token: 0x06003478 RID: 13432 RVA: 0x0004AAEB File Offset: 0x00048CEB
		public unsafe bool bApplyPrimitivePlanarReflectionRenderOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPlanarReflectionComponent.__PropertyOffset_bApplyPrimitivePlanarReflectionRenderOffset) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPlanarReflectionComponent.__PropertyOffset_bApplyPrimitivePlanarReflectionRenderOffset) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000764 RID: 1892
		// (get) Token: 0x06003479 RID: 13433 RVA: 0x0004AAFC File Offset: 0x00048CFC
		// (set) Token: 0x0600347A RID: 13434 RVA: 0x0004AB0C File Offset: 0x00048D0C
		public unsafe bool bRenderParticlesInPlanarReflection
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPlanarReflectionComponent.__PropertyOffset_bRenderParticlesInPlanarReflection) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPlanarReflectionComponent.__PropertyOffset_bRenderParticlesInPlanarReflection) = (value ? 1 : 0);
			}
		}

		// Token: 0x0600347B RID: 13435 RVA: 0x0004AB20 File Offset: 0x00048D20
		[SkipLocalsInit]
		public unsafe void SetMaxViewDistanceOverride(float InMaxViewDistanceOverride)
		{
			UPlanarReflectionComponent.__SetMaxViewDistanceOverride_FunctionParams* ptr = stackalloc UPlanarReflectionComponent.__SetMaxViewDistanceOverride_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UPlanarReflectionComponent.__SetMaxViewDistanceOverride_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UPlanarReflectionComponent.__SetMaxViewDistanceOverride_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InMaxViewDistanceOverride = InMaxViewDistanceOverride;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UPlanarReflectionComponent.__SetMaxViewDistanceOverride_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600347C RID: 13436 RVA: 0x0004AB66 File Offset: 0x00048D66
		public void RequestCapture()
		{
			UPlanarReflectionComponent.__RequestCapture_Internal(base.NativePtr);
		}

		// Token: 0x0600347D RID: 13437
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RequestCapture_Internal(IntPtr @this);

		// Token: 0x0600347E RID: 13438 RVA: 0x0004AB73 File Offset: 0x00048D73
		static UPlanarReflectionComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.PlanarReflectionComponent");
		}

		// Token: 0x0600347F RID: 13439 RVA: 0x0004AB81 File Offset: 0x00048D81
		protected UPlanarReflectionComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001218 RID: 4632
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.PlanarReflectionComponent";

		// Token: 0x04001219 RID: 4633
		private static IntPtr _ClassPtr;

		// Token: 0x0400121A RID: 4634
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400121B RID: 4635
		internal static int __PropertyOffset_PreviewBox;

		// Token: 0x0400121C RID: 4636
		internal static int __PropertyOffset_NormalDistortionStrength;

		// Token: 0x0400121D RID: 4637
		internal static int __PropertyOffset_PrefilterRoughness;

		// Token: 0x0400121E RID: 4638
		internal static int __PropertyOffset_PrefilterRoughnessDistance;

		// Token: 0x0400121F RID: 4639
		internal static int __PropertyOffset_ScreenPercentage;

		// Token: 0x04001220 RID: 4640
		internal static int __PropertyOffset_MirrorHalfWidth;

		// Token: 0x04001221 RID: 4641
		internal static int __PropertyOffset_MirrorHalfHeight;

		// Token: 0x04001222 RID: 4642
		internal static int __PropertyOffset_MirrorBoundsPadding;

		// Token: 0x04001223 RID: 4643
		internal static int __PropertyOffset_ExtraFOV;

		// Token: 0x04001224 RID: 4644
		internal static int __PropertyOffset_DistanceFromPlaneFadeStart_DEPRECATED;

		// Token: 0x04001225 RID: 4645
		internal static int __PropertyOffset_DistanceFromPlaneFadeEnd_DEPRECATED;

		// Token: 0x04001226 RID: 4646
		internal static int __PropertyOffset_DistanceFromPlaneFadeoutStart;

		// Token: 0x04001227 RID: 4647
		internal static int __PropertyOffset_DistanceFromPlaneFadeoutEnd;

		// Token: 0x04001228 RID: 4648
		internal static int __PropertyOffset_AngleFromPlaneFadeStart;

		// Token: 0x04001229 RID: 4649
		internal static int __PropertyOffset_AngleFromPlaneFadeEnd;

		// Token: 0x0400122A RID: 4650
		internal static int __PropertyOffset_bShowPreviewPlane;

		// Token: 0x0400122B RID: 4651
		internal static int __PropertyOffset_bCustomComposite;

		// Token: 0x0400122C RID: 4652
		internal static int __PropertyOffset_Priority;

		// Token: 0x0400122D RID: 4653
		internal static int __PropertyOffset_bEnableCapture;

		// Token: 0x0400122E RID: 4654
		internal static int __PropertyOffset_CaptureInterval;

		// Token: 0x0400122F RID: 4655
		internal static int __PropertyOffset_bRenderDynamicShadows;

		// Token: 0x04001230 RID: 4656
		internal static int __PropertyOffset_bRenderDecals;

		// Token: 0x04001231 RID: 4657
		internal static int __PropertyOffset_bRenderAmbientOcclusion;

		// Token: 0x04001232 RID: 4658
		internal static int __PropertyOffset_bRenderTranslucency;

		// Token: 0x04001233 RID: 4659
		internal static int __PropertyOffset_bRenderFog;

		// Token: 0x04001234 RID: 4660
		internal static int __PropertyOffset_bRenderAtmosphere;

		// Token: 0x04001235 RID: 4661
		internal static int __PropertyOffset_bRenderGodRay;

		// Token: 0x04001236 RID: 4662
		internal static int __PropertyOffset_bRenderVolumetricLight;

		// Token: 0x04001237 RID: 4663
		internal static int __PropertyOffset_bRenderDataDistortion;

		// Token: 0x04001238 RID: 4664
		internal static int __PropertyOffset_bRenderKuroCloud;

		// Token: 0x04001239 RID: 4665
		internal static int __PropertyOffset_bEnableGaussianPrefilter;

		// Token: 0x0400123A RID: 4666
		internal static int __PropertyOffset_bRenderSceneTwoSided;

		// Token: 0x0400123B RID: 4667
		internal static int __PropertyOffset_bApplyPrimitivePlanarReflectionRenderOffset;

		// Token: 0x0400123C RID: 4668
		internal static int __PropertyOffset_bRenderParticlesInPlanarReflection;

		// Token: 0x0400123D RID: 4669
		private static IntPtr __SetMaxViewDistanceOverride_NativeFunctionPtr;

		// Token: 0x020009E1 RID: 2529
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __SetMaxViewDistanceOverride_FunctionParams
		{
			// Token: 0x04005973 RID: 22899
			[FieldOffset(0)]
			public float InMaxViewDistanceOverride;
		}
	}
}
