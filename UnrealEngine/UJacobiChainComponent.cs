using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001787 RID: 6023
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroComputeShader.JacobiChainComponent")]
	[UnrealStructLayout(1888, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1888)]
	public class UJacobiChainComponent : UPrimitiveComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06015A6A RID: 88682 RVA: 0x001FD591 File Offset: 0x001FB791
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UJacobiChainComponent._ClassPtr;
		}

		// Token: 0x06015A6B RID: 88683 RVA: 0x001FD5A0 File Offset: 0x001FB7A0
		public UJacobiChainComponent() : this(BuiltinUtils.AllocNativeUObject(UJacobiChainComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06015A6C RID: 88684 RVA: 0x001FD5C8 File Offset: 0x001FB7C8
		[NullableContext(1)]
		public UJacobiChainComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UJacobiChainComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700558E RID: 21902
		// (get) Token: 0x06015A6D RID: 88685 RVA: 0x001FD5FB File Offset: 0x001FB7FB
		// (set) Token: 0x06015A6E RID: 88686 RVA: 0x001FD60F File Offset: 0x001FB80F
		public unsafe UStaticMesh SourceMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + UJacobiChainComponent.__PropertyOffset_SourceMesh);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UJacobiChainComponent.__PropertyOffset_SourceMesh, value);
			}
		}

		// Token: 0x1700558F RID: 21903
		// (get) Token: 0x06015A6F RID: 88687 RVA: 0x001FD624 File Offset: 0x001FB824
		// (set) Token: 0x06015A70 RID: 88688 RVA: 0x001FD65D File Offset: 0x001FB85D
		[Nullable(1)]
		public TArray<UMaterialInterface> OverrideMaterials
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInterface> result;
				if ((result = this._OverrideMaterials) == null)
				{
					result = (this._OverrideMaterials = new TArray<UMaterialInterface>(base.NativePtr + (IntPtr)UJacobiChainComponent.__PropertyOffset_OverrideMaterials, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.OverrideMaterials.CopyAssign(value);
			}
		}

		// Token: 0x17005590 RID: 21904
		// (get) Token: 0x06015A71 RID: 88689 RVA: 0x001FD66B File Offset: 0x001FB86B
		// (set) Token: 0x06015A72 RID: 88690 RVA: 0x001FD67F File Offset: 0x001FB87F
		public unsafe UJacobiChainAsset SimulationProfile
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UJacobiChainAsset>(base.NativePtr / (IntPtr)sizeof(void*) + UJacobiChainComponent.__PropertyOffset_SimulationProfile);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UJacobiChainComponent.__PropertyOffset_SimulationProfile, value);
			}
		}

		// Token: 0x17005591 RID: 21905
		// (get) Token: 0x06015A73 RID: 88691 RVA: 0x001FD694 File Offset: 0x001FB894
		// (set) Token: 0x06015A74 RID: 88692 RVA: 0x001FD6A4 File Offset: 0x001FB8A4
		public unsafe bool bAutoStart
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UJacobiChainComponent.__PropertyOffset_bAutoStart) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UJacobiChainComponent.__PropertyOffset_bAutoStart) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005592 RID: 21906
		// (get) Token: 0x06015A75 RID: 88693 RVA: 0x001FD6B5 File Offset: 0x001FB8B5
		// (set) Token: 0x06015A76 RID: 88694 RVA: 0x001FD6C5 File Offset: 0x001FB8C5
		public unsafe bool bSimulating
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UJacobiChainComponent.__PropertyOffset_bSimulating) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UJacobiChainComponent.__PropertyOffset_bSimulating) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005593 RID: 21907
		// (get) Token: 0x06015A77 RID: 88695 RVA: 0x001FD6D6 File Offset: 0x001FB8D6
		// (set) Token: 0x06015A78 RID: 88696 RVA: 0x001FD6E6 File Offset: 0x001FB8E6
		public unsafe float SimulationBlend
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UJacobiChainComponent.__PropertyOffset_SimulationBlend);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UJacobiChainComponent.__PropertyOffset_SimulationBlend) = value;
			}
		}

		// Token: 0x17005594 RID: 21908
		// (get) Token: 0x06015A79 RID: 88697 RVA: 0x001FD6F7 File Offset: 0x001FB8F7
		// (set) Token: 0x06015A7A RID: 88698 RVA: 0x001FD707 File Offset: 0x001FB907
		public unsafe bool bUseProfileSolverSettings
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UJacobiChainComponent.__PropertyOffset_bUseProfileSolverSettings) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UJacobiChainComponent.__PropertyOffset_bUseProfileSolverSettings) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005595 RID: 21909
		// (get) Token: 0x06015A7B RID: 88699 RVA: 0x001FD718 File Offset: 0x001FB918
		// (set) Token: 0x06015A7C RID: 88700 RVA: 0x001FD728 File Offset: 0x001FB928
		public unsafe float FixedDeltaTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UJacobiChainComponent.__PropertyOffset_FixedDeltaTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UJacobiChainComponent.__PropertyOffset_FixedDeltaTime) = value;
			}
		}

		// Token: 0x17005596 RID: 21910
		// (get) Token: 0x06015A7D RID: 88701 RVA: 0x001FD739 File Offset: 0x001FB939
		// (set) Token: 0x06015A7E RID: 88702 RVA: 0x001FD749 File Offset: 0x001FB949
		public unsafe int Substeps
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UJacobiChainComponent.__PropertyOffset_Substeps);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UJacobiChainComponent.__PropertyOffset_Substeps) = value;
			}
		}

		// Token: 0x17005597 RID: 21911
		// (get) Token: 0x06015A7F RID: 88703 RVA: 0x001FD75A File Offset: 0x001FB95A
		// (set) Token: 0x06015A80 RID: 88704 RVA: 0x001FD76A File Offset: 0x001FB96A
		public unsafe int SolverIterations
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UJacobiChainComponent.__PropertyOffset_SolverIterations);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UJacobiChainComponent.__PropertyOffset_SolverIterations) = value;
			}
		}

		// Token: 0x17005598 RID: 21912
		// (get) Token: 0x06015A81 RID: 88705 RVA: 0x001FD77B File Offset: 0x001FB97B
		// (set) Token: 0x06015A82 RID: 88706 RVA: 0x001FD78F File Offset: 0x001FB98F
		public unsafe FVector Gravity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UJacobiChainComponent.__PropertyOffset_Gravity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UJacobiChainComponent.__PropertyOffset_Gravity) = value;
			}
		}

		// Token: 0x17005599 RID: 21913
		// (get) Token: 0x06015A83 RID: 88707 RVA: 0x001FD7A4 File Offset: 0x001FB9A4
		// (set) Token: 0x06015A84 RID: 88708 RVA: 0x001FD7B4 File Offset: 0x001FB9B4
		public unsafe float GravityDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UJacobiChainComponent.__PropertyOffset_GravityDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UJacobiChainComponent.__PropertyOffset_GravityDistance) = value;
			}
		}

		// Token: 0x1700559A RID: 21914
		// (get) Token: 0x06015A85 RID: 88709 RVA: 0x001FD7C5 File Offset: 0x001FB9C5
		// (set) Token: 0x06015A86 RID: 88710 RVA: 0x001FD7D5 File Offset: 0x001FB9D5
		public unsafe float VelocityDamping
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UJacobiChainComponent.__PropertyOffset_VelocityDamping);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UJacobiChainComponent.__PropertyOffset_VelocityDamping) = value;
			}
		}

		// Token: 0x1700559B RID: 21915
		// (get) Token: 0x06015A87 RID: 88711 RVA: 0x001FD7E6 File Offset: 0x001FB9E6
		// (set) Token: 0x06015A88 RID: 88712 RVA: 0x001FD7F6 File Offset: 0x001FB9F6
		public unsafe float ConstraintStiffness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UJacobiChainComponent.__PropertyOffset_ConstraintStiffness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UJacobiChainComponent.__PropertyOffset_ConstraintStiffness) = value;
			}
		}

		// Token: 0x1700559C RID: 21916
		// (get) Token: 0x06015A89 RID: 88713 RVA: 0x001FD807 File Offset: 0x001FBA07
		// (set) Token: 0x06015A8A RID: 88714 RVA: 0x001FD817 File Offset: 0x001FBA17
		public unsafe float VertexMatchTolerance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UJacobiChainComponent.__PropertyOffset_VertexMatchTolerance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UJacobiChainComponent.__PropertyOffset_VertexMatchTolerance) = value;
			}
		}

		// Token: 0x1700559D RID: 21917
		// (get) Token: 0x06015A8B RID: 88715 RVA: 0x001FD828 File Offset: 0x001FBA28
		// (set) Token: 0x06015A8C RID: 88716 RVA: 0x001FD83C File Offset: 0x001FBA3C
		public unsafe UJacobiChainPrebuiltData PrebuiltData
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UJacobiChainPrebuiltData>(base.NativePtr / (IntPtr)sizeof(void*) + UJacobiChainComponent.__PropertyOffset_PrebuiltData);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UJacobiChainComponent.__PropertyOffset_PrebuiltData, value);
			}
		}

		// Token: 0x1700559E RID: 21918
		// (get) Token: 0x06015A8D RID: 88717 RVA: 0x001FD851 File Offset: 0x001FBA51
		// (set) Token: 0x06015A8E RID: 88718 RVA: 0x001FD861 File Offset: 0x001FBA61
		public unsafe bool bBakedBatchComponent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UJacobiChainComponent.__PropertyOffset_bBakedBatchComponent) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UJacobiChainComponent.__PropertyOffset_bBakedBatchComponent) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700559F RID: 21919
		// (get) Token: 0x06015A8F RID: 88719 RVA: 0x001FD872 File Offset: 0x001FBA72
		// (set) Token: 0x06015A90 RID: 88720 RVA: 0x001FD882 File Offset: 0x001FBA82
		public unsafe int BakedSourceIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UJacobiChainComponent.__PropertyOffset_BakedSourceIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UJacobiChainComponent.__PropertyOffset_BakedSourceIndex) = value;
			}
		}

		// Token: 0x170055A0 RID: 21920
		// (get) Token: 0x06015A91 RID: 88721 RVA: 0x001FD893 File Offset: 0x001FBA93
		// (set) Token: 0x06015A92 RID: 88722 RVA: 0x001FD8A3 File Offset: 0x001FBAA3
		public unsafe float DynamicBoundsScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UJacobiChainComponent.__PropertyOffset_DynamicBoundsScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UJacobiChainComponent.__PropertyOffset_DynamicBoundsScale) = value;
			}
		}

		// Token: 0x170055A1 RID: 21921
		// (get) Token: 0x06015A93 RID: 88723 RVA: 0x001FD8B4 File Offset: 0x001FBAB4
		// (set) Token: 0x06015A94 RID: 88724 RVA: 0x001FD8C4 File Offset: 0x001FBAC4
		public unsafe bool bEnableOfflineWindAnimation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UJacobiChainComponent.__PropertyOffset_bEnableOfflineWindAnimation) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UJacobiChainComponent.__PropertyOffset_bEnableOfflineWindAnimation) = (value ? 1 : 0);
			}
		}

		// Token: 0x170055A2 RID: 21922
		// (get) Token: 0x06015A95 RID: 88725 RVA: 0x001FD8D5 File Offset: 0x001FBAD5
		// (set) Token: 0x06015A96 RID: 88726 RVA: 0x001FD8E5 File Offset: 0x001FBAE5
		public unsafe bool bLoopOfflineWindAnimation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UJacobiChainComponent.__PropertyOffset_bLoopOfflineWindAnimation) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UJacobiChainComponent.__PropertyOffset_bLoopOfflineWindAnimation) = (value ? 1 : 0);
			}
		}

		// Token: 0x170055A3 RID: 21923
		// (get) Token: 0x06015A97 RID: 88727 RVA: 0x001FD8F6 File Offset: 0x001FBAF6
		// (set) Token: 0x06015A98 RID: 88728 RVA: 0x001FD906 File Offset: 0x001FBB06
		public unsafe float OfflineWindPlayRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UJacobiChainComponent.__PropertyOffset_OfflineWindPlayRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UJacobiChainComponent.__PropertyOffset_OfflineWindPlayRate) = value;
			}
		}

		// Token: 0x170055A4 RID: 21924
		// (get) Token: 0x06015A99 RID: 88729 RVA: 0x001FD917 File Offset: 0x001FBB17
		// (set) Token: 0x06015A9A RID: 88730 RVA: 0x001FD927 File Offset: 0x001FBB27
		public unsafe bool bOfflineWindPlaying
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UJacobiChainComponent.__PropertyOffset_bOfflineWindPlaying) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UJacobiChainComponent.__PropertyOffset_bOfflineWindPlaying) = (value ? 1 : 0);
			}
		}

		// Token: 0x170055A5 RID: 21925
		// (get) Token: 0x06015A9B RID: 88731 RVA: 0x001FD938 File Offset: 0x001FBB38
		// (set) Token: 0x06015A9C RID: 88732 RVA: 0x001FD948 File Offset: 0x001FBB48
		public unsafe bool bEnablePlayerCapsuleInteraction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UJacobiChainComponent.__PropertyOffset_bEnablePlayerCapsuleInteraction) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UJacobiChainComponent.__PropertyOffset_bEnablePlayerCapsuleInteraction) = (value ? 1 : 0);
			}
		}

		// Token: 0x170055A6 RID: 21926
		// (get) Token: 0x06015A9D RID: 88733 RVA: 0x001FD959 File Offset: 0x001FBB59
		// (set) Token: 0x06015A9E RID: 88734 RVA: 0x001FD969 File Offset: 0x001FBB69
		public unsafe int PlayerCapsuleContactIterations
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UJacobiChainComponent.__PropertyOffset_PlayerCapsuleContactIterations);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UJacobiChainComponent.__PropertyOffset_PlayerCapsuleContactIterations) = value;
			}
		}

		// Token: 0x170055A7 RID: 21927
		// (get) Token: 0x06015A9F RID: 88735 RVA: 0x001FD97A File Offset: 0x001FBB7A
		// (set) Token: 0x06015AA0 RID: 88736 RVA: 0x001FD98A File Offset: 0x001FBB8A
		public unsafe float PlayerCollisionSkin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UJacobiChainComponent.__PropertyOffset_PlayerCollisionSkin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UJacobiChainComponent.__PropertyOffset_PlayerCollisionSkin) = value;
			}
		}

		// Token: 0x170055A8 RID: 21928
		// (get) Token: 0x06015AA1 RID: 88737 RVA: 0x001FD99B File Offset: 0x001FBB9B
		// (set) Token: 0x06015AA2 RID: 88738 RVA: 0x001FD9AB File Offset: 0x001FBBAB
		public unsafe float SoftParticleCollisionRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UJacobiChainComponent.__PropertyOffset_SoftParticleCollisionRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UJacobiChainComponent.__PropertyOffset_SoftParticleCollisionRadius) = value;
			}
		}

		// Token: 0x170055A9 RID: 21929
		// (get) Token: 0x06015AA3 RID: 88739 RVA: 0x001FD9BC File Offset: 0x001FBBBC
		// (set) Token: 0x06015AA4 RID: 88740 RVA: 0x001FD9CC File Offset: 0x001FBBCC
		public unsafe float PlayerCollisionStiffness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UJacobiChainComponent.__PropertyOffset_PlayerCollisionStiffness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UJacobiChainComponent.__PropertyOffset_PlayerCollisionStiffness) = value;
			}
		}

		// Token: 0x170055AA RID: 21930
		// (get) Token: 0x06015AA5 RID: 88741 RVA: 0x001FD9DD File Offset: 0x001FBBDD
		// (set) Token: 0x06015AA6 RID: 88742 RVA: 0x001FD9ED File Offset: 0x001FBBED
		public unsafe float MaxPlayerInteractionSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UJacobiChainComponent.__PropertyOffset_MaxPlayerInteractionSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UJacobiChainComponent.__PropertyOffset_MaxPlayerInteractionSpeed) = value;
			}
		}

		// Token: 0x170055AB RID: 21931
		// (get) Token: 0x06015AA7 RID: 88743 RVA: 0x001FD9FE File Offset: 0x001FBBFE
		// (set) Token: 0x06015AA8 RID: 88744 RVA: 0x001FDA0E File Offset: 0x001FBC0E
		public unsafe bool bEnableGlobalDistanceFieldCollision
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UJacobiChainComponent.__PropertyOffset_bEnableGlobalDistanceFieldCollision) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UJacobiChainComponent.__PropertyOffset_bEnableGlobalDistanceFieldCollision) = (value ? 1 : 0);
			}
		}

		// Token: 0x170055AC RID: 21932
		// (get) Token: 0x06015AA9 RID: 88745 RVA: 0x001FDA1F File Offset: 0x001FBC1F
		// (set) Token: 0x06015AAA RID: 88746 RVA: 0x001FDA2F File Offset: 0x001FBC2F
		public unsafe float GlobalDistanceFieldMinSafeDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UJacobiChainComponent.__PropertyOffset_GlobalDistanceFieldMinSafeDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UJacobiChainComponent.__PropertyOffset_GlobalDistanceFieldMinSafeDistance) = value;
			}
		}

		// Token: 0x170055AD RID: 21933
		// (get) Token: 0x06015AAB RID: 88747 RVA: 0x001FDA40 File Offset: 0x001FBC40
		// (set) Token: 0x06015AAC RID: 88748 RVA: 0x001FDA50 File Offset: 0x001FBC50
		public unsafe float GlobalDistanceFieldDynamicSafeDistanceFactor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UJacobiChainComponent.__PropertyOffset_GlobalDistanceFieldDynamicSafeDistanceFactor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UJacobiChainComponent.__PropertyOffset_GlobalDistanceFieldDynamicSafeDistanceFactor) = value;
			}
		}

		// Token: 0x170055AE RID: 21934
		// (get) Token: 0x06015AAD RID: 88749 RVA: 0x001FDA61 File Offset: 0x001FBC61
		// (set) Token: 0x06015AAE RID: 88750 RVA: 0x001FDA71 File Offset: 0x001FBC71
		public unsafe float GlobalDistanceFieldCorrectionStiffness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UJacobiChainComponent.__PropertyOffset_GlobalDistanceFieldCorrectionStiffness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UJacobiChainComponent.__PropertyOffset_GlobalDistanceFieldCorrectionStiffness) = value;
			}
		}

		// Token: 0x170055AF RID: 21935
		// (get) Token: 0x06015AAF RID: 88751 RVA: 0x001FDA82 File Offset: 0x001FBC82
		// (set) Token: 0x06015AB0 RID: 88752 RVA: 0x001FDA92 File Offset: 0x001FBC92
		public unsafe float GlobalDistanceFieldMaxCorrectionPerFrame
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UJacobiChainComponent.__PropertyOffset_GlobalDistanceFieldMaxCorrectionPerFrame);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UJacobiChainComponent.__PropertyOffset_GlobalDistanceFieldMaxCorrectionPerFrame) = value;
			}
		}

		// Token: 0x170055B0 RID: 21936
		// (get) Token: 0x06015AB1 RID: 88753 RVA: 0x001FDAA3 File Offset: 0x001FBCA3
		// (set) Token: 0x06015AB2 RID: 88754 RVA: 0x001FDAB7 File Offset: 0x001FBCB7
		public unsafe UStaticMeshComponent StaticMeshFallbackComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + UJacobiChainComponent.__PropertyOffset_StaticMeshFallbackComponent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UJacobiChainComponent.__PropertyOffset_StaticMeshFallbackComponent, value);
			}
		}

		// Token: 0x06015AB3 RID: 88755 RVA: 0x001FDACC File Offset: 0x001FBCCC
		public void StopSimulation()
		{
			UJacobiChainComponent.__StopSimulation_Internal(base.NativePtr);
		}

		// Token: 0x06015AB4 RID: 88756 RVA: 0x001FDAD9 File Offset: 0x001FBCD9
		public void StartSimulation()
		{
			UJacobiChainComponent.__StartSimulation_Internal(base.NativePtr);
		}

		// Token: 0x06015AB5 RID: 88757 RVA: 0x001FDAE6 File Offset: 0x001FBCE6
		public void SetSimulationBlend(float InSimulationBlend)
		{
			UJacobiChainComponent.__SetSimulationBlend_Internal(base.NativePtr, InSimulationBlend);
		}

		// Token: 0x06015AB6 RID: 88758 RVA: 0x001FDAF4 File Offset: 0x001FBCF4
		public void SetMeshAndProfile(UStaticMesh InMesh, UJacobiChainAsset InProfile)
		{
			UJacobiChainComponent.__SetMeshAndProfile_Internal(base.NativePtr, (InMesh != null) ? InMesh.NativePtr : IntPtr.Zero, (InProfile != null) ? InProfile.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06015AB7 RID: 88759 RVA: 0x001FDB21 File Offset: 0x001FBD21
		public void SetGlobalDistanceFieldCollisionEnabled(bool bEnabled)
		{
			UJacobiChainComponent.__SetGlobalDistanceFieldCollisionEnabled_Internal(base.NativePtr, bEnabled);
		}

		// Token: 0x06015AB8 RID: 88760 RVA: 0x001FDB2F File Offset: 0x001FBD2F
		public void ResetSimulation()
		{
			UJacobiChainComponent.__ResetSimulation_Internal(base.NativePtr);
		}

		// Token: 0x06015AB9 RID: 88761 RVA: 0x001FDB3C File Offset: 0x001FBD3C
		public void ResetOfflineWindAnimation()
		{
			UJacobiChainComponent.__ResetOfflineWindAnimation_Internal(base.NativePtr);
		}

		// Token: 0x06015ABA RID: 88762 RVA: 0x001FDB49 File Offset: 0x001FBD49
		public void PlayOfflineWindAnimation()
		{
			UJacobiChainComponent.__PlayOfflineWindAnimation_Internal(base.NativePtr);
		}

		// Token: 0x06015ABB RID: 88763 RVA: 0x001FDB56 File Offset: 0x001FBD56
		public void PauseOfflineWindAnimation()
		{
			UJacobiChainComponent.__PauseOfflineWindAnimation_Internal(base.NativePtr);
		}

		// Token: 0x06015ABC RID: 88764
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StopSimulation_Internal(IntPtr @this);

		// Token: 0x06015ABD RID: 88765
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StartSimulation_Internal(IntPtr @this);

		// Token: 0x06015ABE RID: 88766
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSimulationBlend_Internal(IntPtr @this, float InSimulationBlend);

		// Token: 0x06015ABF RID: 88767
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMeshAndProfile_Internal(IntPtr @this, IntPtr InMesh, IntPtr InProfile);

		// Token: 0x06015AC0 RID: 88768
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetGlobalDistanceFieldCollisionEnabled_Internal(IntPtr @this, bool bEnabled);

		// Token: 0x06015AC1 RID: 88769
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResetSimulation_Internal(IntPtr @this);

		// Token: 0x06015AC2 RID: 88770
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResetOfflineWindAnimation_Internal(IntPtr @this);

		// Token: 0x06015AC3 RID: 88771
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PlayOfflineWindAnimation_Internal(IntPtr @this);

		// Token: 0x06015AC4 RID: 88772
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PauseOfflineWindAnimation_Internal(IntPtr @this);

		// Token: 0x06015AC5 RID: 88773 RVA: 0x001FDB63 File Offset: 0x001FBD63
		static UJacobiChainComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroComputeShader.JacobiChainComponent");
		}

		// Token: 0x06015AC6 RID: 88774 RVA: 0x001FDB71 File Offset: 0x001FBD71
		protected UJacobiChainComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400BD30 RID: 48432
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroComputeShader.JacobiChainComponent";

		// Token: 0x0400BD31 RID: 48433
		private static IntPtr _ClassPtr;

		// Token: 0x0400BD32 RID: 48434
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400BD33 RID: 48435
		internal static int __PropertyOffset_SourceMesh;

		// Token: 0x0400BD34 RID: 48436
		internal static int __PropertyOffset_OverrideMaterials;

		// Token: 0x0400BD35 RID: 48437
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInterface> _OverrideMaterials;

		// Token: 0x0400BD36 RID: 48438
		internal static int __PropertyOffset_SimulationProfile;

		// Token: 0x0400BD37 RID: 48439
		internal static int __PropertyOffset_bAutoStart;

		// Token: 0x0400BD38 RID: 48440
		internal static int __PropertyOffset_bSimulating;

		// Token: 0x0400BD39 RID: 48441
		internal static int __PropertyOffset_SimulationBlend;

		// Token: 0x0400BD3A RID: 48442
		internal static int __PropertyOffset_bUseProfileSolverSettings;

		// Token: 0x0400BD3B RID: 48443
		internal static int __PropertyOffset_FixedDeltaTime;

		// Token: 0x0400BD3C RID: 48444
		internal static int __PropertyOffset_Substeps;

		// Token: 0x0400BD3D RID: 48445
		internal static int __PropertyOffset_SolverIterations;

		// Token: 0x0400BD3E RID: 48446
		internal static int __PropertyOffset_Gravity;

		// Token: 0x0400BD3F RID: 48447
		internal static int __PropertyOffset_GravityDistance;

		// Token: 0x0400BD40 RID: 48448
		internal static int __PropertyOffset_VelocityDamping;

		// Token: 0x0400BD41 RID: 48449
		internal static int __PropertyOffset_ConstraintStiffness;

		// Token: 0x0400BD42 RID: 48450
		internal static int __PropertyOffset_VertexMatchTolerance;

		// Token: 0x0400BD43 RID: 48451
		internal static int __PropertyOffset_PrebuiltData;

		// Token: 0x0400BD44 RID: 48452
		internal static int __PropertyOffset_bBakedBatchComponent;

		// Token: 0x0400BD45 RID: 48453
		internal static int __PropertyOffset_BakedSourceIndex;

		// Token: 0x0400BD46 RID: 48454
		internal static int __PropertyOffset_DynamicBoundsScale;

		// Token: 0x0400BD47 RID: 48455
		internal static int __PropertyOffset_bEnableOfflineWindAnimation;

		// Token: 0x0400BD48 RID: 48456
		internal static int __PropertyOffset_bLoopOfflineWindAnimation;

		// Token: 0x0400BD49 RID: 48457
		internal static int __PropertyOffset_OfflineWindPlayRate;

		// Token: 0x0400BD4A RID: 48458
		internal static int __PropertyOffset_bOfflineWindPlaying;

		// Token: 0x0400BD4B RID: 48459
		internal static int __PropertyOffset_bEnablePlayerCapsuleInteraction;

		// Token: 0x0400BD4C RID: 48460
		internal static int __PropertyOffset_PlayerCapsuleContactIterations;

		// Token: 0x0400BD4D RID: 48461
		internal static int __PropertyOffset_PlayerCollisionSkin;

		// Token: 0x0400BD4E RID: 48462
		internal static int __PropertyOffset_SoftParticleCollisionRadius;

		// Token: 0x0400BD4F RID: 48463
		internal static int __PropertyOffset_PlayerCollisionStiffness;

		// Token: 0x0400BD50 RID: 48464
		internal static int __PropertyOffset_MaxPlayerInteractionSpeed;

		// Token: 0x0400BD51 RID: 48465
		internal static int __PropertyOffset_bEnableGlobalDistanceFieldCollision;

		// Token: 0x0400BD52 RID: 48466
		internal static int __PropertyOffset_GlobalDistanceFieldMinSafeDistance;

		// Token: 0x0400BD53 RID: 48467
		internal static int __PropertyOffset_GlobalDistanceFieldDynamicSafeDistanceFactor;

		// Token: 0x0400BD54 RID: 48468
		internal static int __PropertyOffset_GlobalDistanceFieldCorrectionStiffness;

		// Token: 0x0400BD55 RID: 48469
		internal static int __PropertyOffset_GlobalDistanceFieldMaxCorrectionPerFrame;

		// Token: 0x0400BD56 RID: 48470
		internal static int __PropertyOffset_StaticMeshFallbackComponent;
	}
}
