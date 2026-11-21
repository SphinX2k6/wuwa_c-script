using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000290 RID: 656
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.StaticMeshComponent")]
	[UnrealStructLayout(2016, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2016)]
	public class UStaticMeshComponent : UMeshComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06004850 RID: 18512 RVA: 0x000654D4 File Offset: 0x000636D4
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UStaticMeshComponent._ClassPtr;
		}

		// Token: 0x06004851 RID: 18513 RVA: 0x000654E0 File Offset: 0x000636E0
		public UStaticMeshComponent() : this(BuiltinUtils.AllocNativeUObject(UStaticMeshComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06004852 RID: 18514 RVA: 0x00065508 File Offset: 0x00063708
		public UStaticMeshComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UStaticMeshComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000D70 RID: 3440
		// (get) Token: 0x06004853 RID: 18515 RVA: 0x0006553B File Offset: 0x0006373B
		// (set) Token: 0x06004854 RID: 18516 RVA: 0x0006554B File Offset: 0x0006374B
		public unsafe int ForcedLodModel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_ForcedLodModel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_ForcedLodModel) = value;
			}
		}

		// Token: 0x17000D71 RID: 3441
		// (get) Token: 0x06004855 RID: 18517 RVA: 0x0006555C File Offset: 0x0006375C
		// (set) Token: 0x06004856 RID: 18518 RVA: 0x0006556C File Offset: 0x0006376C
		public unsafe int PreviousLODLevel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_PreviousLODLevel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_PreviousLODLevel) = value;
			}
		}

		// Token: 0x17000D72 RID: 3442
		// (get) Token: 0x06004857 RID: 18519 RVA: 0x0006557D File Offset: 0x0006377D
		// (set) Token: 0x06004858 RID: 18520 RVA: 0x0006558D File Offset: 0x0006378D
		public unsafe int MinLOD
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_MinLOD);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_MinLOD) = value;
			}
		}

		// Token: 0x17000D73 RID: 3443
		// (get) Token: 0x06004859 RID: 18521 RVA: 0x0006559E File Offset: 0x0006379E
		// (set) Token: 0x0600485A RID: 18522 RVA: 0x000655AE File Offset: 0x000637AE
		public unsafe int SubDivisionStepSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_SubDivisionStepSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_SubDivisionStepSize) = value;
			}
		}

		// Token: 0x17000D74 RID: 3444
		// (get) Token: 0x0600485B RID: 18523 RVA: 0x000655BF File Offset: 0x000637BF
		// (set) Token: 0x0600485C RID: 18524 RVA: 0x000655D8 File Offset: 0x000637D8
		public unsafe bool bOverrideScreenSizeCullRatio
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_bOverrideScreenSizeCullRatio) & UStaticMeshComponent.__PropertyMask_bOverrideScreenSizeCullRatio) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_bOverrideScreenSizeCullRatio) = ((*(base.NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_bOverrideScreenSizeCullRatio) & ~UStaticMeshComponent.__PropertyMask_bOverrideScreenSizeCullRatio) | (value ? UStaticMeshComponent.__PropertyMask_bOverrideScreenSizeCullRatio : 0));
			}
		}

		// Token: 0x17000D75 RID: 3445
		// (get) Token: 0x0600485D RID: 18525 RVA: 0x00065608 File Offset: 0x00063808
		// (set) Token: 0x0600485E RID: 18526 RVA: 0x00065618 File Offset: 0x00063818
		public unsafe float ScreenSizeCullRatioOverride
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_ScreenSizeCullRatioOverride);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_ScreenSizeCullRatioOverride) = value;
			}
		}

		// Token: 0x17000D76 RID: 3446
		// (get) Token: 0x0600485F RID: 18527 RVA: 0x00065629 File Offset: 0x00063829
		// (set) Token: 0x06004860 RID: 18528 RVA: 0x0006563D File Offset: 0x0006383D
		[Nullable(2)]
		public unsafe UStaticMesh StaticMesh
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + UStaticMeshComponent.__PropertyOffset_StaticMesh);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UStaticMeshComponent.__PropertyOffset_StaticMesh, value);
			}
		}

		// Token: 0x17000D77 RID: 3447
		// (get) Token: 0x06004861 RID: 18529 RVA: 0x00065652 File Offset: 0x00063852
		// (set) Token: 0x06004862 RID: 18530 RVA: 0x00065666 File Offset: 0x00063866
		public unsafe FBoxSphereBounds CachedVertexBounds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_CachedVertexBounds);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_CachedVertexBounds) = value;
			}
		}

		// Token: 0x17000D78 RID: 3448
		// (get) Token: 0x06004863 RID: 18531 RVA: 0x0006567C File Offset: 0x0006387C
		// (set) Token: 0x06004864 RID: 18532 RVA: 0x000656B5 File Offset: 0x000638B5
		public TArray<FExtraMaterialInfo> ExtraMaterialInfos
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FExtraMaterialInfo> result;
				if ((result = this._ExtraMaterialInfos) == null)
				{
					result = (this._ExtraMaterialInfos = new TArray<FExtraMaterialInfo>(base.NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_ExtraMaterialInfos, this));
				}
				return result;
			}
			set
			{
				this.ExtraMaterialInfos.CopyAssign(value);
			}
		}

		// Token: 0x17000D79 RID: 3449
		// (get) Token: 0x06004865 RID: 18533 RVA: 0x000656C3 File Offset: 0x000638C3
		// (set) Token: 0x06004866 RID: 18534 RVA: 0x000656D7 File Offset: 0x000638D7
		public unsafe FColor WireframeColorOverride
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_WireframeColorOverride);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_WireframeColorOverride) = value;
			}
		}

		// Token: 0x17000D7A RID: 3450
		// (get) Token: 0x06004867 RID: 18535 RVA: 0x000656EC File Offset: 0x000638EC
		// (set) Token: 0x06004868 RID: 18536 RVA: 0x00065705 File Offset: 0x00063905
		public unsafe bool bEvaluateWorldPositionOffset
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_bEvaluateWorldPositionOffset) & UStaticMeshComponent.__PropertyMask_bEvaluateWorldPositionOffset) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_bEvaluateWorldPositionOffset) = ((*(base.NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_bEvaluateWorldPositionOffset) & ~UStaticMeshComponent.__PropertyMask_bEvaluateWorldPositionOffset) | (value ? UStaticMeshComponent.__PropertyMask_bEvaluateWorldPositionOffset : 0));
			}
		}

		// Token: 0x17000D7B RID: 3451
		// (get) Token: 0x06004869 RID: 18537 RVA: 0x00065735 File Offset: 0x00063935
		// (set) Token: 0x0600486A RID: 18538 RVA: 0x0006574E File Offset: 0x0006394E
		public unsafe bool bDisableOpacityMicromap
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_bDisableOpacityMicromap) & UStaticMeshComponent.__PropertyMask_bDisableOpacityMicromap) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_bDisableOpacityMicromap) = ((*(base.NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_bDisableOpacityMicromap) & ~UStaticMeshComponent.__PropertyMask_bDisableOpacityMicromap) | (value ? UStaticMeshComponent.__PropertyMask_bDisableOpacityMicromap : 0));
			}
		}

		// Token: 0x17000D7C RID: 3452
		// (get) Token: 0x0600486B RID: 18539 RVA: 0x0006577E File Offset: 0x0006397E
		// (set) Token: 0x0600486C RID: 18540 RVA: 0x00065797 File Offset: 0x00063997
		public unsafe bool bForceEnableOpacityMicromap
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_bForceEnableOpacityMicromap) & UStaticMeshComponent.__PropertyMask_bForceEnableOpacityMicromap) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_bForceEnableOpacityMicromap) = ((*(base.NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_bForceEnableOpacityMicromap) & ~UStaticMeshComponent.__PropertyMask_bForceEnableOpacityMicromap) | (value ? UStaticMeshComponent.__PropertyMask_bForceEnableOpacityMicromap : 0));
			}
		}

		// Token: 0x17000D7D RID: 3453
		// (get) Token: 0x0600486D RID: 18541 RVA: 0x000657C7 File Offset: 0x000639C7
		// (set) Token: 0x0600486E RID: 18542 RVA: 0x000657E0 File Offset: 0x000639E0
		public unsafe bool bOverrideWireframeColor
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_bOverrideWireframeColor) & UStaticMeshComponent.__PropertyMask_bOverrideWireframeColor) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_bOverrideWireframeColor) = ((*(base.NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_bOverrideWireframeColor) & ~UStaticMeshComponent.__PropertyMask_bOverrideWireframeColor) | (value ? UStaticMeshComponent.__PropertyMask_bOverrideWireframeColor : 0));
			}
		}

		// Token: 0x17000D7E RID: 3454
		// (get) Token: 0x0600486F RID: 18543 RVA: 0x00065810 File Offset: 0x00063A10
		// (set) Token: 0x06004870 RID: 18544 RVA: 0x00065829 File Offset: 0x00063A29
		public unsafe bool bOverrideMinLOD
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_bOverrideMinLOD) & UStaticMeshComponent.__PropertyMask_bOverrideMinLOD) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_bOverrideMinLOD) = ((*(base.NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_bOverrideMinLOD) & ~UStaticMeshComponent.__PropertyMask_bOverrideMinLOD) | (value ? UStaticMeshComponent.__PropertyMask_bOverrideMinLOD : 0));
			}
		}

		// Token: 0x17000D7F RID: 3455
		// (get) Token: 0x06004871 RID: 18545 RVA: 0x00065859 File Offset: 0x00063A59
		// (set) Token: 0x06004872 RID: 18546 RVA: 0x00065872 File Offset: 0x00063A72
		public unsafe bool bOverrideNavigationExport
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_bOverrideNavigationExport) & UStaticMeshComponent.__PropertyMask_bOverrideNavigationExport) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_bOverrideNavigationExport) = ((*(base.NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_bOverrideNavigationExport) & ~UStaticMeshComponent.__PropertyMask_bOverrideNavigationExport) | (value ? UStaticMeshComponent.__PropertyMask_bOverrideNavigationExport : 0));
			}
		}

		// Token: 0x17000D80 RID: 3456
		// (get) Token: 0x06004873 RID: 18547 RVA: 0x000658A2 File Offset: 0x00063AA2
		// (set) Token: 0x06004874 RID: 18548 RVA: 0x000658BB File Offset: 0x00063ABB
		public unsafe bool bForceNavigationObstacle
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_bForceNavigationObstacle) & UStaticMeshComponent.__PropertyMask_bForceNavigationObstacle) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_bForceNavigationObstacle) = ((*(base.NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_bForceNavigationObstacle) & ~UStaticMeshComponent.__PropertyMask_bForceNavigationObstacle) | (value ? UStaticMeshComponent.__PropertyMask_bForceNavigationObstacle : 0));
			}
		}

		// Token: 0x17000D81 RID: 3457
		// (get) Token: 0x06004875 RID: 18549 RVA: 0x000658EB File Offset: 0x00063AEB
		// (set) Token: 0x06004876 RID: 18550 RVA: 0x00065904 File Offset: 0x00063B04
		public unsafe bool bSealedWater
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_bSealedWater) & UStaticMeshComponent.__PropertyMask_bSealedWater) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_bSealedWater) = ((*(base.NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_bSealedWater) & ~UStaticMeshComponent.__PropertyMask_bSealedWater) | (value ? UStaticMeshComponent.__PropertyMask_bSealedWater : 0));
			}
		}

		// Token: 0x17000D82 RID: 3458
		// (get) Token: 0x06004877 RID: 18551 RVA: 0x00065934 File Offset: 0x00063B34
		// (set) Token: 0x06004878 RID: 18552 RVA: 0x0006594D File Offset: 0x00063B4D
		public unsafe bool bDisallowMeshPaintPerInstance
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_bDisallowMeshPaintPerInstance) & UStaticMeshComponent.__PropertyMask_bDisallowMeshPaintPerInstance) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_bDisallowMeshPaintPerInstance) = ((*(base.NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_bDisallowMeshPaintPerInstance) & ~UStaticMeshComponent.__PropertyMask_bDisallowMeshPaintPerInstance) | (value ? UStaticMeshComponent.__PropertyMask_bDisallowMeshPaintPerInstance : 0));
			}
		}

		// Token: 0x17000D83 RID: 3459
		// (get) Token: 0x06004879 RID: 18553 RVA: 0x0006597D File Offset: 0x00063B7D
		// (set) Token: 0x0600487A RID: 18554 RVA: 0x00065996 File Offset: 0x00063B96
		public unsafe bool bIgnoreInstanceForTextureStreaming
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_bIgnoreInstanceForTextureStreaming) & UStaticMeshComponent.__PropertyMask_bIgnoreInstanceForTextureStreaming) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_bIgnoreInstanceForTextureStreaming) = ((*(base.NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_bIgnoreInstanceForTextureStreaming) & ~UStaticMeshComponent.__PropertyMask_bIgnoreInstanceForTextureStreaming) | (value ? UStaticMeshComponent.__PropertyMask_bIgnoreInstanceForTextureStreaming : 0));
			}
		}

		// Token: 0x17000D84 RID: 3460
		// (get) Token: 0x0600487B RID: 18555 RVA: 0x000659C6 File Offset: 0x00063BC6
		// (set) Token: 0x0600487C RID: 18556 RVA: 0x000659DF File Offset: 0x00063BDF
		public unsafe bool bOverrideLightMapRes
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_bOverrideLightMapRes) & UStaticMeshComponent.__PropertyMask_bOverrideLightMapRes) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_bOverrideLightMapRes) = ((*(base.NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_bOverrideLightMapRes) & ~UStaticMeshComponent.__PropertyMask_bOverrideLightMapRes) | (value ? UStaticMeshComponent.__PropertyMask_bOverrideLightMapRes : 0));
			}
		}

		// Token: 0x17000D85 RID: 3461
		// (get) Token: 0x0600487D RID: 18557 RVA: 0x00065A0F File Offset: 0x00063C0F
		// (set) Token: 0x0600487E RID: 18558 RVA: 0x00065A28 File Offset: 0x00063C28
		public unsafe bool bCastDistanceFieldIndirectShadow
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_bCastDistanceFieldIndirectShadow) & UStaticMeshComponent.__PropertyMask_bCastDistanceFieldIndirectShadow) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_bCastDistanceFieldIndirectShadow) = ((*(base.NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_bCastDistanceFieldIndirectShadow) & ~UStaticMeshComponent.__PropertyMask_bCastDistanceFieldIndirectShadow) | (value ? UStaticMeshComponent.__PropertyMask_bCastDistanceFieldIndirectShadow : 0));
			}
		}

		// Token: 0x17000D86 RID: 3462
		// (get) Token: 0x0600487F RID: 18559 RVA: 0x00065A58 File Offset: 0x00063C58
		// (set) Token: 0x06004880 RID: 18560 RVA: 0x00065A71 File Offset: 0x00063C71
		public unsafe bool bOverrideDistanceFieldSelfShadowBias
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_bOverrideDistanceFieldSelfShadowBias) & UStaticMeshComponent.__PropertyMask_bOverrideDistanceFieldSelfShadowBias) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_bOverrideDistanceFieldSelfShadowBias) = ((*(base.NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_bOverrideDistanceFieldSelfShadowBias) & ~UStaticMeshComponent.__PropertyMask_bOverrideDistanceFieldSelfShadowBias) | (value ? UStaticMeshComponent.__PropertyMask_bOverrideDistanceFieldSelfShadowBias : 0));
			}
		}

		// Token: 0x17000D87 RID: 3463
		// (get) Token: 0x06004881 RID: 18561 RVA: 0x00065AA1 File Offset: 0x00063CA1
		// (set) Token: 0x06004882 RID: 18562 RVA: 0x00065ABA File Offset: 0x00063CBA
		public unsafe bool bKuroDFISUseDirectionalLight
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_bKuroDFISUseDirectionalLight) & UStaticMeshComponent.__PropertyMask_bKuroDFISUseDirectionalLight) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_bKuroDFISUseDirectionalLight) = ((*(base.NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_bKuroDFISUseDirectionalLight) & ~UStaticMeshComponent.__PropertyMask_bKuroDFISUseDirectionalLight) | (value ? UStaticMeshComponent.__PropertyMask_bKuroDFISUseDirectionalLight : 0));
			}
		}

		// Token: 0x17000D88 RID: 3464
		// (get) Token: 0x06004883 RID: 18563 RVA: 0x00065AEA File Offset: 0x00063CEA
		// (set) Token: 0x06004884 RID: 18564 RVA: 0x00065AFA File Offset: 0x00063CFA
		public unsafe float KuroDistanceFieldIndirectShadowRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_KuroDistanceFieldIndirectShadowRotation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_KuroDistanceFieldIndirectShadowRotation) = value;
			}
		}

		// Token: 0x17000D89 RID: 3465
		// (get) Token: 0x06004885 RID: 18565 RVA: 0x00065B0B File Offset: 0x00063D0B
		// (set) Token: 0x06004886 RID: 18566 RVA: 0x00065B1B File Offset: 0x00063D1B
		public unsafe float KuroDistanceFieldIndirectShadowRotationAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_KuroDistanceFieldIndirectShadowRotationAngle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_KuroDistanceFieldIndirectShadowRotationAngle) = value;
			}
		}

		// Token: 0x17000D8A RID: 3466
		// (get) Token: 0x06004887 RID: 18567 RVA: 0x00065B2C File Offset: 0x00063D2C
		// (set) Token: 0x06004888 RID: 18568 RVA: 0x00065B3C File Offset: 0x00063D3C
		public unsafe float KuroDistanceFieldIndirectShadowSoftness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_KuroDistanceFieldIndirectShadowSoftness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_KuroDistanceFieldIndirectShadowSoftness) = value;
			}
		}

		// Token: 0x17000D8B RID: 3467
		// (get) Token: 0x06004889 RID: 18569 RVA: 0x00065B4D File Offset: 0x00063D4D
		// (set) Token: 0x0600488A RID: 18570 RVA: 0x00065B66 File Offset: 0x00063D66
		public unsafe bool bUseSubDivisions
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_bUseSubDivisions) & UStaticMeshComponent.__PropertyMask_bUseSubDivisions) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_bUseSubDivisions) = ((*(base.NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_bUseSubDivisions) & ~UStaticMeshComponent.__PropertyMask_bUseSubDivisions) | (value ? UStaticMeshComponent.__PropertyMask_bUseSubDivisions : 0));
			}
		}

		// Token: 0x17000D8C RID: 3468
		// (get) Token: 0x0600488B RID: 18571 RVA: 0x00065B96 File Offset: 0x00063D96
		// (set) Token: 0x0600488C RID: 18572 RVA: 0x00065BAF File Offset: 0x00063DAF
		public unsafe bool bUseDefaultCollision
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_bUseDefaultCollision) & UStaticMeshComponent.__PropertyMask_bUseDefaultCollision) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_bUseDefaultCollision) = ((*(base.NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_bUseDefaultCollision) & ~UStaticMeshComponent.__PropertyMask_bUseDefaultCollision) | (value ? UStaticMeshComponent.__PropertyMask_bUseDefaultCollision : 0));
			}
		}

		// Token: 0x17000D8D RID: 3469
		// (get) Token: 0x0600488D RID: 18573 RVA: 0x00065BDF File Offset: 0x00063DDF
		// (set) Token: 0x0600488E RID: 18574 RVA: 0x00065BF8 File Offset: 0x00063DF8
		public unsafe bool bRuntimeDisableCollision
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_bRuntimeDisableCollision) & UStaticMeshComponent.__PropertyMask_bRuntimeDisableCollision) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_bRuntimeDisableCollision) = ((*(base.NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_bRuntimeDisableCollision) & ~UStaticMeshComponent.__PropertyMask_bRuntimeDisableCollision) | (value ? UStaticMeshComponent.__PropertyMask_bRuntimeDisableCollision : 0));
			}
		}

		// Token: 0x17000D8E RID: 3470
		// (get) Token: 0x0600488F RID: 18575 RVA: 0x00065C28 File Offset: 0x00063E28
		// (set) Token: 0x06004890 RID: 18576 RVA: 0x00065C41 File Offset: 0x00063E41
		public unsafe bool bReverseCulling
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_bReverseCulling) & UStaticMeshComponent.__PropertyMask_bReverseCulling) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_bReverseCulling) = ((*(base.NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_bReverseCulling) & ~UStaticMeshComponent.__PropertyMask_bReverseCulling) | (value ? UStaticMeshComponent.__PropertyMask_bReverseCulling : 0));
			}
		}

		// Token: 0x17000D8F RID: 3471
		// (get) Token: 0x06004891 RID: 18577 RVA: 0x00065C71 File Offset: 0x00063E71
		// (set) Token: 0x06004892 RID: 18578 RVA: 0x00065C81 File Offset: 0x00063E81
		public unsafe int OverriddenLightMapRes
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_OverriddenLightMapRes);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_OverriddenLightMapRes) = value;
			}
		}

		// Token: 0x17000D90 RID: 3472
		// (get) Token: 0x06004893 RID: 18579 RVA: 0x00065C92 File Offset: 0x00063E92
		// (set) Token: 0x06004894 RID: 18580 RVA: 0x00065CA2 File Offset: 0x00063EA2
		public unsafe float DistanceFieldIndirectShadowMinVisibility
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_DistanceFieldIndirectShadowMinVisibility);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_DistanceFieldIndirectShadowMinVisibility) = value;
			}
		}

		// Token: 0x17000D91 RID: 3473
		// (get) Token: 0x06004895 RID: 18581 RVA: 0x00065CB3 File Offset: 0x00063EB3
		// (set) Token: 0x06004896 RID: 18582 RVA: 0x00065CC3 File Offset: 0x00063EC3
		public unsafe float WPORTDistCullScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_WPORTDistCullScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_WPORTDistCullScale) = value;
			}
		}

		// Token: 0x17000D92 RID: 3474
		// (get) Token: 0x06004897 RID: 18583 RVA: 0x00065CD4 File Offset: 0x00063ED4
		// (set) Token: 0x06004898 RID: 18584 RVA: 0x00065CE4 File Offset: 0x00063EE4
		public unsafe float DistanceFieldSelfShadowBias
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_DistanceFieldSelfShadowBias);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_DistanceFieldSelfShadowBias) = value;
			}
		}

		// Token: 0x17000D93 RID: 3475
		// (get) Token: 0x06004899 RID: 18585 RVA: 0x00065CF5 File Offset: 0x00063EF5
		// (set) Token: 0x0600489A RID: 18586 RVA: 0x00065D05 File Offset: 0x00063F05
		public unsafe float StreamingDistanceMultiplier
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_StreamingDistanceMultiplier);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_StreamingDistanceMultiplier) = value;
			}
		}

		// Token: 0x0600489B RID: 18587 RVA: 0x00065D16 File Offset: 0x00063F16
		[NullableContext(2)]
		public bool SetStaticMesh(UStaticMesh NewMesh)
		{
			return UStaticMeshComponent.__SetStaticMesh_Internal(base.NativePtr, (NewMesh != null) ? NewMesh.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600489C RID: 18588 RVA: 0x00065D33 File Offset: 0x00063F33
		public void SetReverseCulling(bool ReverseCulling)
		{
			UStaticMeshComponent.__SetReverseCulling_Internal(base.NativePtr, ReverseCulling);
		}

		// Token: 0x0600489D RID: 18589 RVA: 0x00065D41 File Offset: 0x00063F41
		public void SetForceVisibleInKuroRayTracing(bool NewValue)
		{
			UStaticMeshComponent.__SetForceVisibleInKuroRayTracing_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x0600489E RID: 18590 RVA: 0x00065D4F File Offset: 0x00063F4F
		public void SetForceEnableOpacityMicromap(bool bForceEnable)
		{
			UStaticMeshComponent.__SetForceEnableOpacityMicromap_Internal(base.NativePtr, bForceEnable);
		}

		// Token: 0x0600489F RID: 18591 RVA: 0x00065D5D File Offset: 0x00063F5D
		public void SetForcedLodModel(int NewForcedLodModel)
		{
			UStaticMeshComponent.__SetForcedLodModel_Internal(base.NativePtr, NewForcedLodModel);
		}

		// Token: 0x060048A0 RID: 18592 RVA: 0x00065D6B File Offset: 0x00063F6B
		public void SetEvaluateWorldPositionOffsetInRayTracing(bool NewValue)
		{
			UStaticMeshComponent.__SetEvaluateWorldPositionOffsetInRayTracing_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x060048A1 RID: 18593 RVA: 0x00065D79 File Offset: 0x00063F79
		public void SetDistanceFieldSelfShadowBias(float NewValue)
		{
			UStaticMeshComponent.__SetDistanceFieldSelfShadowBias_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x060048A2 RID: 18594 RVA: 0x00065D87 File Offset: 0x00063F87
		public void SetDistanceFieldIndirectShadowArgs(float Rotation, float RotationAngle, float Softness)
		{
			UStaticMeshComponent.__SetDistanceFieldIndirectShadowArgs_Internal(base.NativePtr, Rotation, RotationAngle, Softness);
		}

		// Token: 0x060048A3 RID: 18595 RVA: 0x00065D97 File Offset: 0x00063F97
		public void SetDisableOpacityMicromap(bool bDisable)
		{
			UStaticMeshComponent.__SetDisableOpacityMicromap_Internal(base.NativePtr, bDisable);
		}

		// Token: 0x060048A4 RID: 18596 RVA: 0x00065DA5 File Offset: 0x00063FA5
		[NullableContext(2)]
		public void OnRep_StaticMesh(UStaticMesh OldStaticMesh)
		{
			UStaticMeshComponent.__OnRep_StaticMesh_Internal(base.NativePtr, (OldStaticMesh != null) ? OldStaticMesh.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060048A5 RID: 18597 RVA: 0x00065DC4 File Offset: 0x00063FC4
		public unsafe void GetLocalBounds(ref FVector Min, ref FVector Max)
		{
			fixed (FVector* ptr = &Min)
			{
				void* ptr2 = (void*)ptr;
				fixed (FVector* ptr3 = &Max)
				{
					void* ptr4 = (void*)ptr3;
					UStaticMeshComponent.__GetLocalBounds_Internal(base.NativePtr, ref Min, ref Max);
					ptr = null;
				}
			}
		}

		// Token: 0x060048A6 RID: 18598
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SetStaticMesh_Internal(IntPtr @this, IntPtr NewMesh);

		// Token: 0x060048A7 RID: 18599
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetReverseCulling_Internal(IntPtr @this, bool ReverseCulling);

		// Token: 0x060048A8 RID: 18600
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetForceVisibleInKuroRayTracing_Internal(IntPtr @this, bool NewValue);

		// Token: 0x060048A9 RID: 18601
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetForceEnableOpacityMicromap_Internal(IntPtr @this, bool bForceEnable);

		// Token: 0x060048AA RID: 18602
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetForcedLodModel_Internal(IntPtr @this, int NewForcedLodModel);

		// Token: 0x060048AB RID: 18603
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetEvaluateWorldPositionOffsetInRayTracing_Internal(IntPtr @this, bool NewValue);

		// Token: 0x060048AC RID: 18604
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDistanceFieldSelfShadowBias_Internal(IntPtr @this, float NewValue);

		// Token: 0x060048AD RID: 18605
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDistanceFieldIndirectShadowArgs_Internal(IntPtr @this, float Rotation, float RotationAngle, float Softness);

		// Token: 0x060048AE RID: 18606
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDisableOpacityMicromap_Internal(IntPtr @this, bool bDisable);

		// Token: 0x060048AF RID: 18607
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnRep_StaticMesh_Internal(IntPtr @this, IntPtr OldStaticMesh);

		// Token: 0x060048B0 RID: 18608
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetLocalBounds_Internal(IntPtr @this, ref FVector Min, ref FVector Max);

		// Token: 0x060048B1 RID: 18609 RVA: 0x00065DEE File Offset: 0x00063FEE
		static UStaticMeshComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.StaticMeshComponent");
		}

		// Token: 0x060048B2 RID: 18610 RVA: 0x00065DFC File Offset: 0x00063FFC
		protected UStaticMeshComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001BF5 RID: 7157
		public new const string __ObjectPath = "/Script/Engine.StaticMeshComponent";

		// Token: 0x04001BF6 RID: 7158
		private static IntPtr _ClassPtr;

		// Token: 0x04001BF7 RID: 7159
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04001BF8 RID: 7160
		internal static int __PropertyOffset_ForcedLodModel;

		// Token: 0x04001BF9 RID: 7161
		internal static int __PropertyOffset_PreviousLODLevel;

		// Token: 0x04001BFA RID: 7162
		internal static int __PropertyOffset_MinLOD;

		// Token: 0x04001BFB RID: 7163
		internal static int __PropertyOffset_SubDivisionStepSize;

		// Token: 0x04001BFC RID: 7164
		internal static int __PropertyOffset_bOverrideScreenSizeCullRatio;

		// Token: 0x04001BFD RID: 7165
		internal static byte __PropertyMask_bOverrideScreenSizeCullRatio;

		// Token: 0x04001BFE RID: 7166
		internal static int __PropertyOffset_ScreenSizeCullRatioOverride;

		// Token: 0x04001BFF RID: 7167
		internal static int __PropertyOffset_StaticMesh;

		// Token: 0x04001C00 RID: 7168
		internal static int __PropertyOffset_CachedVertexBounds;

		// Token: 0x04001C01 RID: 7169
		internal static int __PropertyOffset_ExtraMaterialInfos;

		// Token: 0x04001C02 RID: 7170
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FExtraMaterialInfo> _ExtraMaterialInfos;

		// Token: 0x04001C03 RID: 7171
		internal static int __PropertyOffset_WireframeColorOverride;

		// Token: 0x04001C04 RID: 7172
		internal static int __PropertyOffset_bEvaluateWorldPositionOffset;

		// Token: 0x04001C05 RID: 7173
		internal static byte __PropertyMask_bEvaluateWorldPositionOffset;

		// Token: 0x04001C06 RID: 7174
		internal static int __PropertyOffset_bDisableOpacityMicromap;

		// Token: 0x04001C07 RID: 7175
		internal static byte __PropertyMask_bDisableOpacityMicromap;

		// Token: 0x04001C08 RID: 7176
		internal static int __PropertyOffset_bForceEnableOpacityMicromap;

		// Token: 0x04001C09 RID: 7177
		internal static byte __PropertyMask_bForceEnableOpacityMicromap;

		// Token: 0x04001C0A RID: 7178
		internal static int __PropertyOffset_bOverrideWireframeColor;

		// Token: 0x04001C0B RID: 7179
		internal static byte __PropertyMask_bOverrideWireframeColor;

		// Token: 0x04001C0C RID: 7180
		internal static int __PropertyOffset_bOverrideMinLOD;

		// Token: 0x04001C0D RID: 7181
		internal static byte __PropertyMask_bOverrideMinLOD;

		// Token: 0x04001C0E RID: 7182
		internal static int __PropertyOffset_bOverrideNavigationExport;

		// Token: 0x04001C0F RID: 7183
		internal static byte __PropertyMask_bOverrideNavigationExport;

		// Token: 0x04001C10 RID: 7184
		internal static int __PropertyOffset_bForceNavigationObstacle;

		// Token: 0x04001C11 RID: 7185
		internal static byte __PropertyMask_bForceNavigationObstacle;

		// Token: 0x04001C12 RID: 7186
		internal static int __PropertyOffset_bSealedWater;

		// Token: 0x04001C13 RID: 7187
		internal static byte __PropertyMask_bSealedWater;

		// Token: 0x04001C14 RID: 7188
		internal static int __PropertyOffset_bDisallowMeshPaintPerInstance;

		// Token: 0x04001C15 RID: 7189
		internal static byte __PropertyMask_bDisallowMeshPaintPerInstance;

		// Token: 0x04001C16 RID: 7190
		internal static int __PropertyOffset_bIgnoreInstanceForTextureStreaming;

		// Token: 0x04001C17 RID: 7191
		internal static byte __PropertyMask_bIgnoreInstanceForTextureStreaming;

		// Token: 0x04001C18 RID: 7192
		internal static int __PropertyOffset_bOverrideLightMapRes;

		// Token: 0x04001C19 RID: 7193
		internal static byte __PropertyMask_bOverrideLightMapRes;

		// Token: 0x04001C1A RID: 7194
		internal static int __PropertyOffset_bCastDistanceFieldIndirectShadow;

		// Token: 0x04001C1B RID: 7195
		internal static byte __PropertyMask_bCastDistanceFieldIndirectShadow;

		// Token: 0x04001C1C RID: 7196
		internal static int __PropertyOffset_bOverrideDistanceFieldSelfShadowBias;

		// Token: 0x04001C1D RID: 7197
		internal static byte __PropertyMask_bOverrideDistanceFieldSelfShadowBias;

		// Token: 0x04001C1E RID: 7198
		internal static int __PropertyOffset_bKuroDFISUseDirectionalLight;

		// Token: 0x04001C1F RID: 7199
		internal static byte __PropertyMask_bKuroDFISUseDirectionalLight;

		// Token: 0x04001C20 RID: 7200
		internal static int __PropertyOffset_KuroDistanceFieldIndirectShadowRotation;

		// Token: 0x04001C21 RID: 7201
		internal static int __PropertyOffset_KuroDistanceFieldIndirectShadowRotationAngle;

		// Token: 0x04001C22 RID: 7202
		internal static int __PropertyOffset_KuroDistanceFieldIndirectShadowSoftness;

		// Token: 0x04001C23 RID: 7203
		internal static int __PropertyOffset_bUseSubDivisions;

		// Token: 0x04001C24 RID: 7204
		internal static byte __PropertyMask_bUseSubDivisions;

		// Token: 0x04001C25 RID: 7205
		internal static int __PropertyOffset_bUseDefaultCollision;

		// Token: 0x04001C26 RID: 7206
		internal static byte __PropertyMask_bUseDefaultCollision;

		// Token: 0x04001C27 RID: 7207
		internal static int __PropertyOffset_bRuntimeDisableCollision;

		// Token: 0x04001C28 RID: 7208
		internal static byte __PropertyMask_bRuntimeDisableCollision;

		// Token: 0x04001C29 RID: 7209
		internal static int __PropertyOffset_bReverseCulling;

		// Token: 0x04001C2A RID: 7210
		internal static byte __PropertyMask_bReverseCulling;

		// Token: 0x04001C2B RID: 7211
		internal static int __PropertyOffset_OverriddenLightMapRes;

		// Token: 0x04001C2C RID: 7212
		internal static int __PropertyOffset_DistanceFieldIndirectShadowMinVisibility;

		// Token: 0x04001C2D RID: 7213
		internal static int __PropertyOffset_WPORTDistCullScale;

		// Token: 0x04001C2E RID: 7214
		internal static int __PropertyOffset_DistanceFieldSelfShadowBias;

		// Token: 0x04001C2F RID: 7215
		internal static int __PropertyOffset_StreamingDistanceMultiplier;
	}
}
