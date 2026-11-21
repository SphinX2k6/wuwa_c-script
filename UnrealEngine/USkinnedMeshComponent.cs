using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000284 RID: 644
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.SkinnedMeshComponent")]
	[UnrealStructLayout(2624, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2624)]
	public abstract class USkinnedMeshComponent : UMeshComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060044BD RID: 17597 RVA: 0x0006182F File Offset: 0x0005FA2F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USkinnedMeshComponent._ClassPtr;
		}

		// Token: 0x17000CD0 RID: 3280
		// (get) Token: 0x060044BE RID: 17598 RVA: 0x0006183B File Offset: 0x0005FA3B
		// (set) Token: 0x060044BF RID: 17599 RVA: 0x0006184F File Offset: 0x0005FA4F
		public unsafe USkeletalMesh SkeletalMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMesh>(base.NativePtr / (IntPtr)sizeof(void*) + USkinnedMeshComponent.__PropertyOffset_SkeletalMesh);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + USkinnedMeshComponent.__PropertyOffset_SkeletalMesh, value);
			}
		}

		// Token: 0x17000CD1 RID: 3281
		// (get) Token: 0x060044C0 RID: 17600 RVA: 0x00061864 File Offset: 0x0005FA64
		// (set) Token: 0x060044C1 RID: 17601 RVA: 0x0006189D File Offset: 0x0005FA9D
		[Nullable(1)]
		public TArray<FExtraMaterialInfo> ExtraMaterialInfos
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FExtraMaterialInfo> result;
				if ((result = this._ExtraMaterialInfos) == null)
				{
					result = (this._ExtraMaterialInfos = new TArray<FExtraMaterialInfo>(base.NativePtr + (IntPtr)USkinnedMeshComponent.__PropertyOffset_ExtraMaterialInfos, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.ExtraMaterialInfos.CopyAssign(value);
			}
		}

		// Token: 0x17000CD2 RID: 3282
		// (get) Token: 0x060044C2 RID: 17602 RVA: 0x000618AB File Offset: 0x0005FAAB
		// (set) Token: 0x060044C3 RID: 17603 RVA: 0x000618BF File Offset: 0x0005FABF
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<USkinnedMeshComponent> MasterPoseComponent
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)USkinnedMeshComponent.__PropertyOffset_MasterPoseComponent);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)USkinnedMeshComponent.__PropertyOffset_MasterPoseComponent) = value;
			}
		}

		// Token: 0x17000CD3 RID: 3283
		// (get) Token: 0x060044C4 RID: 17604 RVA: 0x000618D4 File Offset: 0x0005FAD4
		// (set) Token: 0x060044C5 RID: 17605 RVA: 0x0006190D File Offset: 0x0005FB0D
		[Nullable(1)]
		public TArray<ESkinCacheUsage> SkinCacheUsage
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<ESkinCacheUsage> result;
				if ((result = this._SkinCacheUsage) == null)
				{
					result = (this._SkinCacheUsage = new TArray<ESkinCacheUsage>(base.NativePtr + (IntPtr)USkinnedMeshComponent.__PropertyOffset_SkinCacheUsage, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.SkinCacheUsage.CopyAssign(value);
			}
		}

		// Token: 0x17000CD4 RID: 3284
		// (get) Token: 0x060044C6 RID: 17606 RVA: 0x0006191C File Offset: 0x0005FB1C
		// (set) Token: 0x060044C7 RID: 17607 RVA: 0x00061955 File Offset: 0x0005FB55
		[Nullable(1)]
		public TArray<FVertexOffsetUsage> VertexOffsetUsage
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FVertexOffsetUsage> result;
				if ((result = this._VertexOffsetUsage) == null)
				{
					result = (this._VertexOffsetUsage = new TArray<FVertexOffsetUsage>(base.NativePtr + (IntPtr)USkinnedMeshComponent.__PropertyOffset_VertexOffsetUsage, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.VertexOffsetUsage.CopyAssign(value);
			}
		}

		// Token: 0x17000CD5 RID: 3285
		// (get) Token: 0x060044C8 RID: 17608 RVA: 0x00061964 File Offset: 0x0005FB64
		// (set) Token: 0x060044C9 RID: 17609 RVA: 0x0006199D File Offset: 0x0005FB9D
		[Nullable(1)]
		public TArray<FMatrix> ComponentSpaceMatricesWithShears
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FMatrix> result;
				if ((result = this._ComponentSpaceMatricesWithShears) == null)
				{
					result = (this._ComponentSpaceMatricesWithShears = new TArray<FMatrix>(base.NativePtr + (IntPtr)USkinnedMeshComponent.__PropertyOffset_ComponentSpaceMatricesWithShears, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.ComponentSpaceMatricesWithShears.CopyAssign(value);
			}
		}

		// Token: 0x17000CD6 RID: 3286
		// (get) Token: 0x060044CA RID: 17610 RVA: 0x000619AC File Offset: 0x0005FBAC
		// (set) Token: 0x060044CB RID: 17611 RVA: 0x000619E5 File Offset: 0x0005FBE5
		[Nullable(1)]
		public TArray<FMatrix> PreviousComponentSpaceMatricesWithShears
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FMatrix> result;
				if ((result = this._PreviousComponentSpaceMatricesWithShears) == null)
				{
					result = (this._PreviousComponentSpaceMatricesWithShears = new TArray<FMatrix>(base.NativePtr + (IntPtr)USkinnedMeshComponent.__PropertyOffset_PreviousComponentSpaceMatricesWithShears, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.PreviousComponentSpaceMatricesWithShears.CopyAssign(value);
			}
		}

		// Token: 0x17000CD7 RID: 3287
		// (get) Token: 0x060044CC RID: 17612 RVA: 0x000619F3 File Offset: 0x0005FBF3
		// (set) Token: 0x060044CD RID: 17613 RVA: 0x00061A07 File Offset: 0x0005FC07
		public unsafe UPhysicsAsset PhysicsAssetOverride
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPhysicsAsset>(base.NativePtr / (IntPtr)sizeof(void*) + USkinnedMeshComponent.__PropertyOffset_PhysicsAssetOverride);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + USkinnedMeshComponent.__PropertyOffset_PhysicsAssetOverride, value);
			}
		}

		// Token: 0x17000CD8 RID: 3288
		// (get) Token: 0x060044CE RID: 17614 RVA: 0x00061A1C File Offset: 0x0005FC1C
		// (set) Token: 0x060044CF RID: 17615 RVA: 0x00061A2C File Offset: 0x0005FC2C
		public unsafe int ForcedLodModel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkinnedMeshComponent.__PropertyOffset_ForcedLodModel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkinnedMeshComponent.__PropertyOffset_ForcedLodModel) = value;
			}
		}

		// Token: 0x17000CD9 RID: 3289
		// (get) Token: 0x060044D0 RID: 17616 RVA: 0x00061A3D File Offset: 0x0005FC3D
		// (set) Token: 0x060044D1 RID: 17617 RVA: 0x00061A4D File Offset: 0x0005FC4D
		public unsafe int MinLodModel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkinnedMeshComponent.__PropertyOffset_MinLodModel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkinnedMeshComponent.__PropertyOffset_MinLodModel) = value;
			}
		}

		// Token: 0x17000CDA RID: 3290
		// (get) Token: 0x060044D2 RID: 17618 RVA: 0x00061A5E File Offset: 0x0005FC5E
		// (set) Token: 0x060044D3 RID: 17619 RVA: 0x00061A77 File Offset: 0x0005FC77
		public unsafe bool bOverrideMinLod
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USkinnedMeshComponent.__PropertyOffset_bOverrideMinLod) & USkinnedMeshComponent.__PropertyMask_bOverrideMinLod) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USkinnedMeshComponent.__PropertyOffset_bOverrideMinLod) = ((*(base.NativePtr + (IntPtr)USkinnedMeshComponent.__PropertyOffset_bOverrideMinLod) & ~USkinnedMeshComponent.__PropertyMask_bOverrideMinLod) | (value ? USkinnedMeshComponent.__PropertyMask_bOverrideMinLod : 0));
			}
		}

		// Token: 0x17000CDB RID: 3291
		// (get) Token: 0x060044D4 RID: 17620 RVA: 0x00061AA7 File Offset: 0x0005FCA7
		// (set) Token: 0x060044D5 RID: 17621 RVA: 0x00061AB7 File Offset: 0x0005FCB7
		public unsafe int MaxLodModel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkinnedMeshComponent.__PropertyOffset_MaxLodModel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkinnedMeshComponent.__PropertyOffset_MaxLodModel) = value;
			}
		}

		// Token: 0x17000CDC RID: 3292
		// (get) Token: 0x060044D6 RID: 17622 RVA: 0x00061AC8 File Offset: 0x0005FCC8
		// (set) Token: 0x060044D7 RID: 17623 RVA: 0x00061AE1 File Offset: 0x0005FCE1
		public unsafe bool bOverrideMaxLod
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USkinnedMeshComponent.__PropertyOffset_bOverrideMaxLod) & USkinnedMeshComponent.__PropertyMask_bOverrideMaxLod) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USkinnedMeshComponent.__PropertyOffset_bOverrideMaxLod) = ((*(base.NativePtr + (IntPtr)USkinnedMeshComponent.__PropertyOffset_bOverrideMaxLod) & ~USkinnedMeshComponent.__PropertyMask_bOverrideMaxLod) | (value ? USkinnedMeshComponent.__PropertyMask_bOverrideMaxLod : 0));
			}
		}

		// Token: 0x17000CDD RID: 3293
		// (get) Token: 0x060044D8 RID: 17624 RVA: 0x00061B11 File Offset: 0x0005FD11
		// (set) Token: 0x060044D9 RID: 17625 RVA: 0x00061B2A File Offset: 0x0005FD2A
		public unsafe bool bEnableMaxLod
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USkinnedMeshComponent.__PropertyOffset_bEnableMaxLod) & USkinnedMeshComponent.__PropertyMask_bEnableMaxLod) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USkinnedMeshComponent.__PropertyOffset_bEnableMaxLod) = ((*(base.NativePtr + (IntPtr)USkinnedMeshComponent.__PropertyOffset_bEnableMaxLod) & ~USkinnedMeshComponent.__PropertyMask_bEnableMaxLod) | (value ? USkinnedMeshComponent.__PropertyMask_bEnableMaxLod : 0));
			}
		}

		// Token: 0x17000CDE RID: 3294
		// (get) Token: 0x060044DA RID: 17626 RVA: 0x00061B5A File Offset: 0x0005FD5A
		// (set) Token: 0x060044DB RID: 17627 RVA: 0x00061B6A File Offset: 0x0005FD6A
		public unsafe float StreamingDistanceMultiplier
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkinnedMeshComponent.__PropertyOffset_StreamingDistanceMultiplier);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkinnedMeshComponent.__PropertyOffset_StreamingDistanceMultiplier) = value;
			}
		}

		// Token: 0x17000CDF RID: 3295
		// (get) Token: 0x060044DC RID: 17628 RVA: 0x00061B7B File Offset: 0x0005FD7B
		// (set) Token: 0x060044DD RID: 17629 RVA: 0x00061B8F File Offset: 0x0005FD8F
		public unsafe UTextRenderComponent LODTextComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextRenderComponent>(base.NativePtr / (IntPtr)sizeof(void*) + USkinnedMeshComponent.__PropertyOffset_LODTextComponent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + USkinnedMeshComponent.__PropertyOffset_LODTextComponent, value);
			}
		}

		// Token: 0x17000CE0 RID: 3296
		// (get) Token: 0x060044DE RID: 17630 RVA: 0x00061BA4 File Offset: 0x0005FDA4
		// (set) Token: 0x060044DF RID: 17631 RVA: 0x00061BB8 File Offset: 0x0005FDB8
		public unsafe UTextRenderComponent DistanceTextComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextRenderComponent>(base.NativePtr / (IntPtr)sizeof(void*) + USkinnedMeshComponent.__PropertyOffset_DistanceTextComponent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + USkinnedMeshComponent.__PropertyOffset_DistanceTextComponent, value);
			}
		}

		// Token: 0x17000CE1 RID: 3297
		// (get) Token: 0x060044E0 RID: 17632 RVA: 0x00061BD0 File Offset: 0x0005FDD0
		// (set) Token: 0x060044E1 RID: 17633 RVA: 0x00061C09 File Offset: 0x0005FE09
		[Nullable(1)]
		public TArray<FSkelMeshComponentLODInfo> LODInfo
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FSkelMeshComponentLODInfo> result;
				if ((result = this._LODInfo) == null)
				{
					result = (this._LODInfo = new TArray<FSkelMeshComponentLODInfo>(base.NativePtr + (IntPtr)USkinnedMeshComponent.__PropertyOffset_LODInfo, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.LODInfo.CopyAssign(value);
			}
		}

		// Token: 0x17000CE2 RID: 3298
		// (get) Token: 0x060044E2 RID: 17634 RVA: 0x00061C17 File Offset: 0x0005FE17
		// (set) Token: 0x060044E3 RID: 17635 RVA: 0x00061C27 File Offset: 0x0005FE27
		public unsafe EVisibilityBasedAnimTickOption VisibilityBasedAnimTickOption
		{
			get
			{
				return (EVisibilityBasedAnimTickOption)(*(base.NativePtr + (IntPtr)USkinnedMeshComponent.__PropertyOffset_VisibilityBasedAnimTickOption));
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkinnedMeshComponent.__PropertyOffset_VisibilityBasedAnimTickOption) = (byte)value;
			}
		}

		// Token: 0x17000CE3 RID: 3299
		// (get) Token: 0x060044E4 RID: 17636 RVA: 0x00061C38 File Offset: 0x0005FE38
		// (set) Token: 0x060044E5 RID: 17637 RVA: 0x00061C48 File Offset: 0x0005FE48
		public unsafe bool bAllowBoneVisibilityStatesDifferentWithMaster
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkinnedMeshComponent.__PropertyOffset_bAllowBoneVisibilityStatesDifferentWithMaster) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkinnedMeshComponent.__PropertyOffset_bAllowBoneVisibilityStatesDifferentWithMaster) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000CE4 RID: 3300
		// (get) Token: 0x060044E6 RID: 17638 RVA: 0x00061C59 File Offset: 0x0005FE59
		// (set) Token: 0x060044E7 RID: 17639 RVA: 0x00061C69 File Offset: 0x0005FE69
		public unsafe bool bRequireHiddenBonesCalculation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkinnedMeshComponent.__PropertyOffset_bRequireHiddenBonesCalculation) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkinnedMeshComponent.__PropertyOffset_bRequireHiddenBonesCalculation) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000CE5 RID: 3301
		// (get) Token: 0x060044E8 RID: 17640 RVA: 0x00061C7A File Offset: 0x0005FE7A
		// (set) Token: 0x060044E9 RID: 17641 RVA: 0x00061C93 File Offset: 0x0005FE93
		public unsafe bool bUseBoundsFromMasterPoseComponent
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USkinnedMeshComponent.__PropertyOffset_bUseBoundsFromMasterPoseComponent) & USkinnedMeshComponent.__PropertyMask_bUseBoundsFromMasterPoseComponent) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USkinnedMeshComponent.__PropertyOffset_bUseBoundsFromMasterPoseComponent) = ((*(base.NativePtr + (IntPtr)USkinnedMeshComponent.__PropertyOffset_bUseBoundsFromMasterPoseComponent) & ~USkinnedMeshComponent.__PropertyMask_bUseBoundsFromMasterPoseComponent) | (value ? USkinnedMeshComponent.__PropertyMask_bUseBoundsFromMasterPoseComponent : 0));
			}
		}

		// Token: 0x17000CE6 RID: 3302
		// (get) Token: 0x060044EA RID: 17642 RVA: 0x00061CC3 File Offset: 0x0005FEC3
		// (set) Token: 0x060044EB RID: 17643 RVA: 0x00061CDC File Offset: 0x0005FEDC
		public unsafe bool bForceWireframe
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USkinnedMeshComponent.__PropertyOffset_bForceWireframe) & USkinnedMeshComponent.__PropertyMask_bForceWireframe) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USkinnedMeshComponent.__PropertyOffset_bForceWireframe) = ((*(base.NativePtr + (IntPtr)USkinnedMeshComponent.__PropertyOffset_bForceWireframe) & ~USkinnedMeshComponent.__PropertyMask_bForceWireframe) | (value ? USkinnedMeshComponent.__PropertyMask_bForceWireframe : 0));
			}
		}

		// Token: 0x17000CE7 RID: 3303
		// (get) Token: 0x060044EC RID: 17644 RVA: 0x00061D0C File Offset: 0x0005FF0C
		// (set) Token: 0x060044ED RID: 17645 RVA: 0x00061D25 File Offset: 0x0005FF25
		public unsafe bool bDisplayBones_DEPRECATED
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USkinnedMeshComponent.__PropertyOffset_bDisplayBones_DEPRECATED) & USkinnedMeshComponent.__PropertyMask_bDisplayBones_DEPRECATED) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USkinnedMeshComponent.__PropertyOffset_bDisplayBones_DEPRECATED) = ((*(base.NativePtr + (IntPtr)USkinnedMeshComponent.__PropertyOffset_bDisplayBones_DEPRECATED) & ~USkinnedMeshComponent.__PropertyMask_bDisplayBones_DEPRECATED) | (value ? USkinnedMeshComponent.__PropertyMask_bDisplayBones_DEPRECATED : 0));
			}
		}

		// Token: 0x17000CE8 RID: 3304
		// (get) Token: 0x060044EE RID: 17646 RVA: 0x00061D55 File Offset: 0x0005FF55
		// (set) Token: 0x060044EF RID: 17647 RVA: 0x00061D6E File Offset: 0x0005FF6E
		public unsafe bool bDisableMorphTarget
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USkinnedMeshComponent.__PropertyOffset_bDisableMorphTarget) & USkinnedMeshComponent.__PropertyMask_bDisableMorphTarget) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USkinnedMeshComponent.__PropertyOffset_bDisableMorphTarget) = ((*(base.NativePtr + (IntPtr)USkinnedMeshComponent.__PropertyOffset_bDisableMorphTarget) & ~USkinnedMeshComponent.__PropertyMask_bDisableMorphTarget) | (value ? USkinnedMeshComponent.__PropertyMask_bDisableMorphTarget : 0));
			}
		}

		// Token: 0x17000CE9 RID: 3305
		// (get) Token: 0x060044F0 RID: 17648 RVA: 0x00061D9E File Offset: 0x0005FF9E
		// (set) Token: 0x060044F1 RID: 17649 RVA: 0x00061DB7 File Offset: 0x0005FFB7
		public unsafe bool bHideSkin
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USkinnedMeshComponent.__PropertyOffset_bHideSkin) & USkinnedMeshComponent.__PropertyMask_bHideSkin) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USkinnedMeshComponent.__PropertyOffset_bHideSkin) = ((*(base.NativePtr + (IntPtr)USkinnedMeshComponent.__PropertyOffset_bHideSkin) & ~USkinnedMeshComponent.__PropertyMask_bHideSkin) | (value ? USkinnedMeshComponent.__PropertyMask_bHideSkin : 0));
			}
		}

		// Token: 0x17000CEA RID: 3306
		// (get) Token: 0x060044F2 RID: 17650 RVA: 0x00061DE7 File Offset: 0x0005FFE7
		// (set) Token: 0x060044F3 RID: 17651 RVA: 0x00061E00 File Offset: 0x00060000
		public unsafe bool bPerBoneMotionBlur
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USkinnedMeshComponent.__PropertyOffset_bPerBoneMotionBlur) & USkinnedMeshComponent.__PropertyMask_bPerBoneMotionBlur) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USkinnedMeshComponent.__PropertyOffset_bPerBoneMotionBlur) = ((*(base.NativePtr + (IntPtr)USkinnedMeshComponent.__PropertyOffset_bPerBoneMotionBlur) & ~USkinnedMeshComponent.__PropertyMask_bPerBoneMotionBlur) | (value ? USkinnedMeshComponent.__PropertyMask_bPerBoneMotionBlur : 0));
			}
		}

		// Token: 0x17000CEB RID: 3307
		// (get) Token: 0x060044F4 RID: 17652 RVA: 0x00061E30 File Offset: 0x00060030
		// (set) Token: 0x060044F5 RID: 17653 RVA: 0x00061E49 File Offset: 0x00060049
		public unsafe bool bComponentUseFixedSkelBounds
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USkinnedMeshComponent.__PropertyOffset_bComponentUseFixedSkelBounds) & USkinnedMeshComponent.__PropertyMask_bComponentUseFixedSkelBounds) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USkinnedMeshComponent.__PropertyOffset_bComponentUseFixedSkelBounds) = ((*(base.NativePtr + (IntPtr)USkinnedMeshComponent.__PropertyOffset_bComponentUseFixedSkelBounds) & ~USkinnedMeshComponent.__PropertyMask_bComponentUseFixedSkelBounds) | (value ? USkinnedMeshComponent.__PropertyMask_bComponentUseFixedSkelBounds : 0));
			}
		}

		// Token: 0x17000CEC RID: 3308
		// (get) Token: 0x060044F6 RID: 17654 RVA: 0x00061E79 File Offset: 0x00060079
		// (set) Token: 0x060044F7 RID: 17655 RVA: 0x00061E92 File Offset: 0x00060092
		public unsafe bool bConsiderAllBodiesForBounds
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USkinnedMeshComponent.__PropertyOffset_bConsiderAllBodiesForBounds) & USkinnedMeshComponent.__PropertyMask_bConsiderAllBodiesForBounds) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USkinnedMeshComponent.__PropertyOffset_bConsiderAllBodiesForBounds) = ((*(base.NativePtr + (IntPtr)USkinnedMeshComponent.__PropertyOffset_bConsiderAllBodiesForBounds) & ~USkinnedMeshComponent.__PropertyMask_bConsiderAllBodiesForBounds) | (value ? USkinnedMeshComponent.__PropertyMask_bConsiderAllBodiesForBounds : 0));
			}
		}

		// Token: 0x17000CED RID: 3309
		// (get) Token: 0x060044F8 RID: 17656 RVA: 0x00061EC2 File Offset: 0x000600C2
		// (set) Token: 0x060044F9 RID: 17657 RVA: 0x00061EDB File Offset: 0x000600DB
		public unsafe bool bSyncAttachParentLOD
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USkinnedMeshComponent.__PropertyOffset_bSyncAttachParentLOD) & USkinnedMeshComponent.__PropertyMask_bSyncAttachParentLOD) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USkinnedMeshComponent.__PropertyOffset_bSyncAttachParentLOD) = ((*(base.NativePtr + (IntPtr)USkinnedMeshComponent.__PropertyOffset_bSyncAttachParentLOD) & ~USkinnedMeshComponent.__PropertyMask_bSyncAttachParentLOD) | (value ? USkinnedMeshComponent.__PropertyMask_bSyncAttachParentLOD : 0));
			}
		}

		// Token: 0x17000CEE RID: 3310
		// (get) Token: 0x060044FA RID: 17658 RVA: 0x00061F0B File Offset: 0x0006010B
		// (set) Token: 0x060044FB RID: 17659 RVA: 0x00061F1B File Offset: 0x0006011B
		public unsafe bool bResetMorphTargetsWhenSetSkeletalMesh
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkinnedMeshComponent.__PropertyOffset_bResetMorphTargetsWhenSetSkeletalMesh) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkinnedMeshComponent.__PropertyOffset_bResetMorphTargetsWhenSetSkeletalMesh) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000CEF RID: 3311
		// (get) Token: 0x060044FC RID: 17660 RVA: 0x00061F2C File Offset: 0x0006012C
		// (set) Token: 0x060044FD RID: 17661 RVA: 0x00061F45 File Offset: 0x00060145
		public unsafe bool bCanHighlightSelectedSections
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USkinnedMeshComponent.__PropertyOffset_bCanHighlightSelectedSections) & USkinnedMeshComponent.__PropertyMask_bCanHighlightSelectedSections) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USkinnedMeshComponent.__PropertyOffset_bCanHighlightSelectedSections) = ((*(base.NativePtr + (IntPtr)USkinnedMeshComponent.__PropertyOffset_bCanHighlightSelectedSections) & ~USkinnedMeshComponent.__PropertyMask_bCanHighlightSelectedSections) | (value ? USkinnedMeshComponent.__PropertyMask_bCanHighlightSelectedSections : 0));
			}
		}

		// Token: 0x17000CF0 RID: 3312
		// (get) Token: 0x060044FE RID: 17662 RVA: 0x00061F75 File Offset: 0x00060175
		// (set) Token: 0x060044FF RID: 17663 RVA: 0x00061F8E File Offset: 0x0006018E
		public unsafe bool bRecentlyRendered
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USkinnedMeshComponent.__PropertyOffset_bRecentlyRendered) & USkinnedMeshComponent.__PropertyMask_bRecentlyRendered) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USkinnedMeshComponent.__PropertyOffset_bRecentlyRendered) = ((*(base.NativePtr + (IntPtr)USkinnedMeshComponent.__PropertyOffset_bRecentlyRendered) & ~USkinnedMeshComponent.__PropertyMask_bRecentlyRendered) | (value ? USkinnedMeshComponent.__PropertyMask_bRecentlyRendered : 0));
			}
		}

		// Token: 0x17000CF1 RID: 3313
		// (get) Token: 0x06004500 RID: 17664 RVA: 0x00061FBE File Offset: 0x000601BE
		// (set) Token: 0x06004501 RID: 17665 RVA: 0x00061FD7 File Offset: 0x000601D7
		public unsafe bool bForceTickThisFrame
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USkinnedMeshComponent.__PropertyOffset_bForceTickThisFrame) & USkinnedMeshComponent.__PropertyMask_bForceTickThisFrame) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USkinnedMeshComponent.__PropertyOffset_bForceTickThisFrame) = ((*(base.NativePtr + (IntPtr)USkinnedMeshComponent.__PropertyOffset_bForceTickThisFrame) & ~USkinnedMeshComponent.__PropertyMask_bForceTickThisFrame) | (value ? USkinnedMeshComponent.__PropertyMask_bForceTickThisFrame : 0));
			}
		}

		// Token: 0x17000CF2 RID: 3314
		// (get) Token: 0x06004502 RID: 17666 RVA: 0x00062007 File Offset: 0x00060207
		// (set) Token: 0x06004503 RID: 17667 RVA: 0x00062020 File Offset: 0x00060220
		public unsafe bool bCastCapsuleDirectShadow
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USkinnedMeshComponent.__PropertyOffset_bCastCapsuleDirectShadow) & USkinnedMeshComponent.__PropertyMask_bCastCapsuleDirectShadow) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USkinnedMeshComponent.__PropertyOffset_bCastCapsuleDirectShadow) = ((*(base.NativePtr + (IntPtr)USkinnedMeshComponent.__PropertyOffset_bCastCapsuleDirectShadow) & ~USkinnedMeshComponent.__PropertyMask_bCastCapsuleDirectShadow) | (value ? USkinnedMeshComponent.__PropertyMask_bCastCapsuleDirectShadow : 0));
			}
		}

		// Token: 0x17000CF3 RID: 3315
		// (get) Token: 0x06004504 RID: 17668 RVA: 0x00062050 File Offset: 0x00060250
		// (set) Token: 0x06004505 RID: 17669 RVA: 0x00062069 File Offset: 0x00060269
		public unsafe bool bCastCapsuleIndirectShadow
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USkinnedMeshComponent.__PropertyOffset_bCastCapsuleIndirectShadow) & USkinnedMeshComponent.__PropertyMask_bCastCapsuleIndirectShadow) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USkinnedMeshComponent.__PropertyOffset_bCastCapsuleIndirectShadow) = ((*(base.NativePtr + (IntPtr)USkinnedMeshComponent.__PropertyOffset_bCastCapsuleIndirectShadow) & ~USkinnedMeshComponent.__PropertyMask_bCastCapsuleIndirectShadow) | (value ? USkinnedMeshComponent.__PropertyMask_bCastCapsuleIndirectShadow : 0));
			}
		}

		// Token: 0x17000CF4 RID: 3316
		// (get) Token: 0x06004506 RID: 17670 RVA: 0x00062099 File Offset: 0x00060299
		// (set) Token: 0x06004507 RID: 17671 RVA: 0x000620B2 File Offset: 0x000602B2
		public unsafe bool bCPUSkinning
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USkinnedMeshComponent.__PropertyOffset_bCPUSkinning) & USkinnedMeshComponent.__PropertyMask_bCPUSkinning) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USkinnedMeshComponent.__PropertyOffset_bCPUSkinning) = ((*(base.NativePtr + (IntPtr)USkinnedMeshComponent.__PropertyOffset_bCPUSkinning) & ~USkinnedMeshComponent.__PropertyMask_bCPUSkinning) | (value ? USkinnedMeshComponent.__PropertyMask_bCPUSkinning : 0));
			}
		}

		// Token: 0x17000CF5 RID: 3317
		// (get) Token: 0x06004508 RID: 17672 RVA: 0x000620E2 File Offset: 0x000602E2
		// (set) Token: 0x06004509 RID: 17673 RVA: 0x000620FB File Offset: 0x000602FB
		public unsafe bool bEnableUpdateRateOptimizations
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USkinnedMeshComponent.__PropertyOffset_bEnableUpdateRateOptimizations) & USkinnedMeshComponent.__PropertyMask_bEnableUpdateRateOptimizations) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USkinnedMeshComponent.__PropertyOffset_bEnableUpdateRateOptimizations) = ((*(base.NativePtr + (IntPtr)USkinnedMeshComponent.__PropertyOffset_bEnableUpdateRateOptimizations) & ~USkinnedMeshComponent.__PropertyMask_bEnableUpdateRateOptimizations) | (value ? USkinnedMeshComponent.__PropertyMask_bEnableUpdateRateOptimizations : 0));
			}
		}

		// Token: 0x17000CF6 RID: 3318
		// (get) Token: 0x0600450A RID: 17674 RVA: 0x0006212B File Offset: 0x0006032B
		// (set) Token: 0x0600450B RID: 17675 RVA: 0x00062144 File Offset: 0x00060344
		public unsafe bool bDisplayDebugUpdateRateOptimizations
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USkinnedMeshComponent.__PropertyOffset_bDisplayDebugUpdateRateOptimizations) & USkinnedMeshComponent.__PropertyMask_bDisplayDebugUpdateRateOptimizations) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USkinnedMeshComponent.__PropertyOffset_bDisplayDebugUpdateRateOptimizations) = ((*(base.NativePtr + (IntPtr)USkinnedMeshComponent.__PropertyOffset_bDisplayDebugUpdateRateOptimizations) & ~USkinnedMeshComponent.__PropertyMask_bDisplayDebugUpdateRateOptimizations) | (value ? USkinnedMeshComponent.__PropertyMask_bDisplayDebugUpdateRateOptimizations : 0));
			}
		}

		// Token: 0x17000CF7 RID: 3319
		// (get) Token: 0x0600450C RID: 17676 RVA: 0x00062174 File Offset: 0x00060374
		// (set) Token: 0x0600450D RID: 17677 RVA: 0x0006218D File Offset: 0x0006038D
		public unsafe bool bRenderStatic
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USkinnedMeshComponent.__PropertyOffset_bRenderStatic) & USkinnedMeshComponent.__PropertyMask_bRenderStatic) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USkinnedMeshComponent.__PropertyOffset_bRenderStatic) = ((*(base.NativePtr + (IntPtr)USkinnedMeshComponent.__PropertyOffset_bRenderStatic) & ~USkinnedMeshComponent.__PropertyMask_bRenderStatic) | (value ? USkinnedMeshComponent.__PropertyMask_bRenderStatic : 0));
			}
		}

		// Token: 0x17000CF8 RID: 3320
		// (get) Token: 0x0600450E RID: 17678 RVA: 0x000621BD File Offset: 0x000603BD
		// (set) Token: 0x0600450F RID: 17679 RVA: 0x000621D6 File Offset: 0x000603D6
		public unsafe bool bIgnoreMasterPoseComponentLOD
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USkinnedMeshComponent.__PropertyOffset_bIgnoreMasterPoseComponentLOD) & USkinnedMeshComponent.__PropertyMask_bIgnoreMasterPoseComponentLOD) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USkinnedMeshComponent.__PropertyOffset_bIgnoreMasterPoseComponentLOD) = ((*(base.NativePtr + (IntPtr)USkinnedMeshComponent.__PropertyOffset_bIgnoreMasterPoseComponentLOD) & ~USkinnedMeshComponent.__PropertyMask_bIgnoreMasterPoseComponentLOD) | (value ? USkinnedMeshComponent.__PropertyMask_bIgnoreMasterPoseComponentLOD : 0));
			}
		}

		// Token: 0x17000CF9 RID: 3321
		// (get) Token: 0x06004510 RID: 17680 RVA: 0x00062206 File Offset: 0x00060406
		// (set) Token: 0x06004511 RID: 17681 RVA: 0x0006221F File Offset: 0x0006041F
		public unsafe bool bCachedLocalBoundsUpToDate
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USkinnedMeshComponent.__PropertyOffset_bCachedLocalBoundsUpToDate) & USkinnedMeshComponent.__PropertyMask_bCachedLocalBoundsUpToDate) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USkinnedMeshComponent.__PropertyOffset_bCachedLocalBoundsUpToDate) = ((*(base.NativePtr + (IntPtr)USkinnedMeshComponent.__PropertyOffset_bCachedLocalBoundsUpToDate) & ~USkinnedMeshComponent.__PropertyMask_bCachedLocalBoundsUpToDate) | (value ? USkinnedMeshComponent.__PropertyMask_bCachedLocalBoundsUpToDate : 0));
			}
		}

		// Token: 0x17000CFA RID: 3322
		// (get) Token: 0x06004512 RID: 17682 RVA: 0x0006224F File Offset: 0x0006044F
		// (set) Token: 0x06004513 RID: 17683 RVA: 0x00062268 File Offset: 0x00060468
		public unsafe bool bForceMeshObjectUpdate
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USkinnedMeshComponent.__PropertyOffset_bForceMeshObjectUpdate) & USkinnedMeshComponent.__PropertyMask_bForceMeshObjectUpdate) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USkinnedMeshComponent.__PropertyOffset_bForceMeshObjectUpdate) = ((*(base.NativePtr + (IntPtr)USkinnedMeshComponent.__PropertyOffset_bForceMeshObjectUpdate) & ~USkinnedMeshComponent.__PropertyMask_bForceMeshObjectUpdate) | (value ? USkinnedMeshComponent.__PropertyMask_bForceMeshObjectUpdate : 0));
			}
		}

		// Token: 0x17000CFB RID: 3323
		// (get) Token: 0x06004514 RID: 17684 RVA: 0x00062298 File Offset: 0x00060498
		// (set) Token: 0x06004515 RID: 17685 RVA: 0x000622A8 File Offset: 0x000604A8
		public unsafe float CapsuleIndirectShadowMinVisibility
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkinnedMeshComponent.__PropertyOffset_CapsuleIndirectShadowMinVisibility);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkinnedMeshComponent.__PropertyOffset_CapsuleIndirectShadowMinVisibility) = value;
			}
		}

		// Token: 0x17000CFC RID: 3324
		// (get) Token: 0x06004516 RID: 17686 RVA: 0x000622B9 File Offset: 0x000604B9
		// (set) Token: 0x06004517 RID: 17687 RVA: 0x000622C9 File Offset: 0x000604C9
		public unsafe int ComponentLODBias
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkinnedMeshComponent.__PropertyOffset_ComponentLODBias);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkinnedMeshComponent.__PropertyOffset_ComponentLODBias) = value;
			}
		}

		// Token: 0x17000CFD RID: 3325
		// (get) Token: 0x06004518 RID: 17688 RVA: 0x000622DA File Offset: 0x000604DA
		// (set) Token: 0x06004519 RID: 17689 RVA: 0x000622F3 File Offset: 0x000604F3
		public unsafe bool bEnableGlobalLODBias
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USkinnedMeshComponent.__PropertyOffset_bEnableGlobalLODBias) & USkinnedMeshComponent.__PropertyMask_bEnableGlobalLODBias) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USkinnedMeshComponent.__PropertyOffset_bEnableGlobalLODBias) = ((*(base.NativePtr + (IntPtr)USkinnedMeshComponent.__PropertyOffset_bEnableGlobalLODBias) & ~USkinnedMeshComponent.__PropertyMask_bEnableGlobalLODBias) | (value ? USkinnedMeshComponent.__PropertyMask_bEnableGlobalLODBias : 0));
			}
		}

		// Token: 0x17000CFE RID: 3326
		// (get) Token: 0x0600451A RID: 17690 RVA: 0x00062323 File Offset: 0x00060523
		// (set) Token: 0x0600451B RID: 17691 RVA: 0x00062337 File Offset: 0x00060537
		public unsafe FBoxSphereBounds CachedWorldSpaceBounds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkinnedMeshComponent.__PropertyOffset_CachedWorldSpaceBounds);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkinnedMeshComponent.__PropertyOffset_CachedWorldSpaceBounds) = value;
			}
		}

		// Token: 0x17000CFF RID: 3327
		// (get) Token: 0x0600451C RID: 17692 RVA: 0x0006234C File Offset: 0x0006054C
		// (set) Token: 0x0600451D RID: 17693 RVA: 0x00062360 File Offset: 0x00060560
		public unsafe FMatrix CachedWorldToLocalTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkinnedMeshComponent.__PropertyOffset_CachedWorldToLocalTransform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkinnedMeshComponent.__PropertyOffset_CachedWorldToLocalTransform) = value;
			}
		}

		// Token: 0x0600451E RID: 17694 RVA: 0x00062375 File Offset: 0x00060575
		public void UnloadSkinWeightProfile(FName InProfileName)
		{
			USkinnedMeshComponent.__UnloadSkinWeightProfile_Internal(base.NativePtr, InProfileName);
		}

		// Token: 0x0600451F RID: 17695 RVA: 0x00062383 File Offset: 0x00060583
		public void UnHideBoneByName(FName BoneName)
		{
			USkinnedMeshComponent.__UnHideBoneByName_Internal(base.NativePtr, BoneName);
		}

		// Token: 0x06004520 RID: 17696 RVA: 0x00062394 File Offset: 0x00060594
		public unsafe void TransformToBoneSpace(FName BoneName, FVector InPosition, FRotator InRotation, ref FVector OutPosition, ref FRotator OutRotation)
		{
			fixed (FVector* ptr = &OutPosition)
			{
				void* ptr2 = (void*)ptr;
				fixed (FRotator* ptr3 = &OutRotation)
				{
					void* ptr4 = (void*)ptr3;
					USkinnedMeshComponent.__TransformToBoneSpace_Internal(base.NativePtr, BoneName, InPosition, InRotation, ref OutPosition, ref OutRotation);
					ptr = null;
				}
			}
		}

		// Token: 0x06004521 RID: 17697 RVA: 0x000623C8 File Offset: 0x000605C8
		public unsafe void TransformFromBoneSpace(FName BoneName, FVector InPosition, FRotator InRotation, ref FVector OutPosition, ref FRotator OutRotation)
		{
			fixed (FVector* ptr = &OutPosition)
			{
				void* ptr2 = (void*)ptr;
				fixed (FRotator* ptr3 = &OutRotation)
				{
					void* ptr4 = (void*)ptr3;
					USkinnedMeshComponent.__TransformFromBoneSpace_Internal(base.NativePtr, BoneName, InPosition, InRotation, ref OutPosition, ref OutRotation);
					ptr = null;
				}
			}
		}

		// Token: 0x06004522 RID: 17698 RVA: 0x000623F9 File Offset: 0x000605F9
		public void ShowMaterialSection(int MaterialID, int SectionIndex, bool bShow, int LODIndex)
		{
			USkinnedMeshComponent.__ShowMaterialSection_Internal(base.NativePtr, MaterialID, SectionIndex, bShow, LODIndex);
		}

		// Token: 0x06004523 RID: 17699 RVA: 0x0006240B File Offset: 0x0006060B
		public void ShowAllMaterialSections(int LODIndex)
		{
			USkinnedMeshComponent.__ShowAllMaterialSections_Internal(base.NativePtr, LODIndex);
		}

		// Token: 0x06004524 RID: 17700 RVA: 0x00062419 File Offset: 0x00060619
		public void SetVertexOffsetUsage(int LODIndex, int Usage)
		{
			USkinnedMeshComponent.__SetVertexOffsetUsage_Internal(base.NativePtr, LODIndex, Usage);
		}

		// Token: 0x06004525 RID: 17701 RVA: 0x00062428 File Offset: 0x00060628
		public void SetVertexColorOverride_LinearColor(int LODIndex, in TArray<FLinearColor> VertexColors)
		{
			USkinnedMeshComponent.__SetVertexColorOverride_LinearColor_Internal(base.NativePtr, LODIndex, (VertexColors ?? new TArray<FLinearColor>()).NativePtr);
		}

		// Token: 0x06004526 RID: 17702 RVA: 0x00062446 File Offset: 0x00060646
		public bool SetSkinWeightProfile(FName InProfileName)
		{
			return USkinnedMeshComponent.__SetSkinWeightProfile_Internal(base.NativePtr, InProfileName);
		}

		// Token: 0x06004527 RID: 17703 RVA: 0x00062454 File Offset: 0x00060654
		public void SetSkinWeightOverride(int LODIndex, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FSkelMeshSkinWeightInfo> SkinWeights)
		{
			USkinnedMeshComponent.__SetSkinWeightOverride_Internal(base.NativePtr, LODIndex, (SkinWeights ?? new TArray<FSkelMeshSkinWeightInfo>()).NativePtr);
		}

		// Token: 0x06004528 RID: 17704 RVA: 0x00062472 File Offset: 0x00060672
		public void SetSkeletalMesh(USkeletalMesh NewMesh, bool bReinitPose = true)
		{
			USkinnedMeshComponent.__SetSkeletalMesh_Internal(base.NativePtr, (NewMesh != null) ? NewMesh.NativePtr : IntPtr.Zero, bReinitPose);
		}

		// Token: 0x06004529 RID: 17705 RVA: 0x00062490 File Offset: 0x00060690
		public void SetRenderStatic(bool bNewValue)
		{
			USkinnedMeshComponent.__SetRenderStatic_Internal(base.NativePtr, bNewValue);
		}

		// Token: 0x0600452A RID: 17706 RVA: 0x0006249E File Offset: 0x0006069E
		public void SetPreSkinningOffsets(int LODIndex, TArray<FVector> Offsets)
		{
			USkinnedMeshComponent.__SetPreSkinningOffsets_Internal(base.NativePtr, LODIndex, (Offsets ?? new TArray<FVector>()).NativePtr);
		}

		// Token: 0x0600452B RID: 17707 RVA: 0x000624BB File Offset: 0x000606BB
		public void SetPostSkinningOffsets(int LODIndex, TArray<FVector> Offsets)
		{
			USkinnedMeshComponent.__SetPostSkinningOffsets_Internal(base.NativePtr, LODIndex, (Offsets ?? new TArray<FVector>()).NativePtr);
		}

		// Token: 0x0600452C RID: 17708 RVA: 0x000624D8 File Offset: 0x000606D8
		public void SetPhysicsAsset(UPhysicsAsset NewPhysicsAsset, bool bForceReInit = false)
		{
			USkinnedMeshComponent.__SetPhysicsAsset_Internal(base.NativePtr, (NewPhysicsAsset != null) ? NewPhysicsAsset.NativePtr : IntPtr.Zero, bForceReInit);
		}

		// Token: 0x0600452D RID: 17709 RVA: 0x000624F6 File Offset: 0x000606F6
		public void SetOverrideMaxlod(bool InOverride)
		{
			USkinnedMeshComponent.__SetOverrideMaxlod_Internal(base.NativePtr, InOverride);
		}

		// Token: 0x0600452E RID: 17710 RVA: 0x00062504 File Offset: 0x00060704
		public void SetMinLOD(int InNewMinLOD)
		{
			USkinnedMeshComponent.__SetMinLOD_Internal(base.NativePtr, InNewMinLOD);
		}

		// Token: 0x0600452F RID: 17711 RVA: 0x00062512 File Offset: 0x00060712
		public void SetMaxLOD(int InNewMaxLOD)
		{
			USkinnedMeshComponent.__SetMaxLOD_Internal(base.NativePtr, InNewMaxLOD);
		}

		// Token: 0x06004530 RID: 17712 RVA: 0x00062520 File Offset: 0x00060720
		public void SetMasterPoseComponent(USkinnedMeshComponent NewMasterBoneComponent, bool bForceUpdate = false)
		{
			USkinnedMeshComponent.__SetMasterPoseComponent_Internal(base.NativePtr, (NewMasterBoneComponent != null) ? NewMasterBoneComponent.NativePtr : IntPtr.Zero, bForceUpdate);
		}

		// Token: 0x06004531 RID: 17713 RVA: 0x0006253E File Offset: 0x0006073E
		public void SetLODBias(int InLODBias)
		{
			USkinnedMeshComponent.__SetLODBias_Internal(base.NativePtr, InLODBias);
		}

		// Token: 0x06004532 RID: 17714 RVA: 0x0006254C File Offset: 0x0006074C
		public void SetForcedLOD(int InNewForcedLOD)
		{
			USkinnedMeshComponent.__SetForcedLOD_Internal(base.NativePtr, InNewForcedLOD);
		}

		// Token: 0x06004533 RID: 17715 RVA: 0x0006255A File Offset: 0x0006075A
		public void SetEnableMaxLod(bool InEnable)
		{
			USkinnedMeshComponent.__SetEnableMaxLod_Internal(base.NativePtr, InEnable);
		}

		// Token: 0x06004534 RID: 17716 RVA: 0x00062568 File Offset: 0x00060768
		public void SetComponentLODBias(int InBias)
		{
			USkinnedMeshComponent.__SetComponentLODBias_Internal(base.NativePtr, InBias);
		}

		// Token: 0x06004535 RID: 17717 RVA: 0x00062576 File Offset: 0x00060776
		public void SetCastCapsuleIndirectShadow(bool bNewValue)
		{
			USkinnedMeshComponent.__SetCastCapsuleIndirectShadow_Internal(base.NativePtr, bNewValue);
		}

		// Token: 0x06004536 RID: 17718 RVA: 0x00062584 File Offset: 0x00060784
		public void SetCastCapsuleDirectShadow(bool bNewValue)
		{
			USkinnedMeshComponent.__SetCastCapsuleDirectShadow_Internal(base.NativePtr, bNewValue);
		}

		// Token: 0x06004537 RID: 17719 RVA: 0x00062592 File Offset: 0x00060792
		public void SetCapsuleIndirectShadowMinVisibility(float NewValue)
		{
			USkinnedMeshComponent.__SetCapsuleIndirectShadowMinVisibility_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x06004538 RID: 17720 RVA: 0x000625A0 File Offset: 0x000607A0
		public bool SetAnimUpdateRateParameters(ref FAnimUpdateRateParameters AnimUpdateRateParamsIn)
		{
			return USkinnedMeshComponent.__SetAnimUpdateRateParameters_Internal(base.NativePtr, (AnimUpdateRateParamsIn ?? new FAnimUpdateRateParameters()).NativePtr);
		}

		// Token: 0x06004539 RID: 17721 RVA: 0x000625BD File Offset: 0x000607BD
		public bool RenderedAndNotSkipUpdate()
		{
			return USkinnedMeshComponent.__RenderedAndNotSkipUpdate_Internal(base.NativePtr);
		}

		// Token: 0x0600453A RID: 17722 RVA: 0x000625CA File Offset: 0x000607CA
		public bool IsUsingSkinWeightProfile()
		{
			return USkinnedMeshComponent.__IsUsingSkinWeightProfile_Internal(base.NativePtr);
		}

		// Token: 0x0600453B RID: 17723 RVA: 0x000625D7 File Offset: 0x000607D7
		public bool IsMaterialSectionShown(int MaterialID, int LODIndex)
		{
			return USkinnedMeshComponent.__IsMaterialSectionShown_Internal(base.NativePtr, MaterialID, LODIndex);
		}

		// Token: 0x0600453C RID: 17724 RVA: 0x000625E6 File Offset: 0x000607E6
		public bool IsBoneHiddenByName(FName BoneName)
		{
			return USkinnedMeshComponent.__IsBoneHiddenByName_Internal(base.NativePtr, BoneName);
		}

		// Token: 0x0600453D RID: 17725 RVA: 0x000625F4 File Offset: 0x000607F4
		public void HideBoneByName(FName BoneName, EPhysBodyOp PhysBodyOption)
		{
			USkinnedMeshComponent.__HideBoneByName_Internal(base.NativePtr, BoneName, PhysBodyOption);
		}

		// Token: 0x0600453E RID: 17726 RVA: 0x00062608 File Offset: 0x00060808
		public int GetVertexOffsetUsage(int LODIndex)
		{
			return USkinnedMeshComponent.__GetVertexOffsetUsage_Internal(base.NativePtr, LODIndex);
		}

		// Token: 0x0600453F RID: 17727 RVA: 0x00062618 File Offset: 0x00060818
		public unsafe bool GetTwistAndSwingAngleOfDeltaRotationFromRefPose(FName BoneName, ref float OutTwistAngle, ref float OutSwingAngle)
		{
			fixed (float* ptr = &OutTwistAngle)
			{
				void* ptr2 = (void*)ptr;
				fixed (float* ptr3 = &OutSwingAngle)
				{
					void* ptr4 = (void*)ptr3;
					return USkinnedMeshComponent.__GetTwistAndSwingAngleOfDeltaRotationFromRefPose_Internal(base.NativePtr, BoneName, ref OutTwistAngle, ref OutSwingAngle);
				}
			}
		}

		// Token: 0x06004540 RID: 17728 RVA: 0x0006263D File Offset: 0x0006083D
		public FName GetSocketBoneName(FName InSocketName)
		{
			return USkinnedMeshComponent.__GetSocketBoneName_Internal(base.NativePtr, InSocketName);
		}

		// Token: 0x06004541 RID: 17729 RVA: 0x0006264B File Offset: 0x0006084B
		public FVector GetRefPosePosition(int BoneIndex)
		{
			return USkinnedMeshComponent.__GetRefPosePosition_Internal(base.NativePtr, BoneIndex);
		}

		// Token: 0x06004542 RID: 17730 RVA: 0x00062659 File Offset: 0x00060859
		public int GetPredictedLODLevel()
		{
			return USkinnedMeshComponent.__GetPredictedLODLevel_Internal(base.NativePtr);
		}

		// Token: 0x06004543 RID: 17731 RVA: 0x00062666 File Offset: 0x00060866
		public FName GetParentBone(FName BoneName)
		{
			return USkinnedMeshComponent.__GetParentBone_Internal(base.NativePtr, BoneName);
		}

		// Token: 0x06004544 RID: 17732 RVA: 0x00062674 File Offset: 0x00060874
		public int GetNumSections(int LODIndex)
		{
			return USkinnedMeshComponent.__GetNumSections_Internal(base.NativePtr, LODIndex);
		}

		// Token: 0x06004545 RID: 17733 RVA: 0x00062682 File Offset: 0x00060882
		public int GetNumLODs()
		{
			return USkinnedMeshComponent.__GetNumLODs_Internal(base.NativePtr);
		}

		// Token: 0x06004546 RID: 17734 RVA: 0x0006268F File Offset: 0x0006088F
		public int GetNumBones()
		{
			return USkinnedMeshComponent.__GetNumBones_Internal(base.NativePtr);
		}

		// Token: 0x06004547 RID: 17735 RVA: 0x0006269C File Offset: 0x0006089C
		public int GetMeshObjectLODLevel()
		{
			return USkinnedMeshComponent.__GetMeshObjectLODLevel_Internal(base.NativePtr);
		}

		// Token: 0x06004548 RID: 17736 RVA: 0x000626A9 File Offset: 0x000608A9
		public int GetForcedLOD()
		{
			return USkinnedMeshComponent.__GetForcedLOD_Internal(base.NativePtr);
		}

		// Token: 0x06004549 RID: 17737 RVA: 0x000626B6 File Offset: 0x000608B6
		public FTransform GetDeltaTransformFromRefPose(FName BoneName, FName BaseName = default(FName))
		{
			return USkinnedMeshComponent.__GetDeltaTransformFromRefPose_Internal(base.NativePtr, BoneName, BaseName);
		}

		// Token: 0x0600454A RID: 17738 RVA: 0x000626C5 File Offset: 0x000608C5
		public FName GetCurrentSkinWeightProfileName()
		{
			return USkinnedMeshComponent.__GetCurrentSkinWeightProfileName_Internal(base.NativePtr);
		}

		// Token: 0x0600454B RID: 17739 RVA: 0x000626D2 File Offset: 0x000608D2
		public FTransform GetBoneTransform(int BoneIndex)
		{
			return USkinnedMeshComponent.__GetBoneTransform_Internal(base.NativePtr, BoneIndex);
		}

		// Token: 0x0600454C RID: 17740 RVA: 0x000626E0 File Offset: 0x000608E0
		public FName GetBoneName(int BoneIndex)
		{
			return USkinnedMeshComponent.__GetBoneName_Internal(base.NativePtr, BoneIndex);
		}

		// Token: 0x0600454D RID: 17741 RVA: 0x000626EE File Offset: 0x000608EE
		public int GetBoneIndex(FName BoneName)
		{
			return USkinnedMeshComponent.__GetBoneIndex_Internal(base.NativePtr, BoneName);
		}

		// Token: 0x0600454E RID: 17742 RVA: 0x000626FC File Offset: 0x000608FC
		public bool GetAnimUpdateRateParameters(ref FAnimUpdateRateParameters AnimUpdateRateParamsOut)
		{
			return USkinnedMeshComponent.__GetAnimUpdateRateParameters_Internal(base.NativePtr, (AnimUpdateRateParamsOut ?? new FAnimUpdateRateParameters()).NativePtr);
		}

		// Token: 0x0600454F RID: 17743 RVA: 0x0006271C File Offset: 0x0006091C
		public unsafe FName FindClosestBone_K2(FVector TestLocation, ref FVector BoneLocation, float IgnoreScale = 0f, bool bRequirePhysicsAsset = false)
		{
			fixed (FVector* ptr = &BoneLocation)
			{
				void* ptr2 = (void*)ptr;
				return USkinnedMeshComponent.__FindClosestBone_K2_Internal(base.NativePtr, TestLocation, ref BoneLocation, IgnoreScale, bRequirePhysicsAsset);
			}
		}

		// Token: 0x06004550 RID: 17744 RVA: 0x00062740 File Offset: 0x00060940
		public unsafe void D_TransformToBoneSpace(FName BoneName, FVectorDouble InPosition, FRotator InRotation, ref FVectorDouble OutPosition, ref FRotator OutRotation)
		{
			fixed (FVectorDouble* ptr = &OutPosition)
			{
				void* ptr2 = (void*)ptr;
				fixed (FRotator* ptr3 = &OutRotation)
				{
					void* ptr4 = (void*)ptr3;
					USkinnedMeshComponent.__D_TransformToBoneSpace_Internal(base.NativePtr, BoneName, InPosition, InRotation, ref OutPosition, ref OutRotation);
					ptr = null;
				}
			}
		}

		// Token: 0x06004551 RID: 17745 RVA: 0x00062774 File Offset: 0x00060974
		public unsafe void D_TransformFromBoneSpace(FName BoneName, FVectorDouble InPosition, FRotator InRotation, ref FVectorDouble OutPosition, ref FRotator OutRotation)
		{
			fixed (FVectorDouble* ptr = &OutPosition)
			{
				void* ptr2 = (void*)ptr;
				fixed (FRotator* ptr3 = &OutRotation)
				{
					void* ptr4 = (void*)ptr3;
					USkinnedMeshComponent.__D_TransformFromBoneSpace_Internal(base.NativePtr, BoneName, InPosition, InRotation, ref OutPosition, ref OutRotation);
					ptr = null;
				}
			}
		}

		// Token: 0x06004552 RID: 17746 RVA: 0x000627A5 File Offset: 0x000609A5
		public void ClearVertexColorOverride(int LODIndex)
		{
			USkinnedMeshComponent.__ClearVertexColorOverride_Internal(base.NativePtr, LODIndex);
		}

		// Token: 0x06004553 RID: 17747 RVA: 0x000627B3 File Offset: 0x000609B3
		public void ClearSkinWeightProfile()
		{
			USkinnedMeshComponent.__ClearSkinWeightProfile_Internal(base.NativePtr);
		}

		// Token: 0x06004554 RID: 17748 RVA: 0x000627C0 File Offset: 0x000609C0
		public void ClearSkinWeightOverride(int LODIndex)
		{
			USkinnedMeshComponent.__ClearSkinWeightOverride_Internal(base.NativePtr, LODIndex);
		}

		// Token: 0x06004555 RID: 17749 RVA: 0x000627CE File Offset: 0x000609CE
		public bool BoneIsChildOf(FName BoneName, FName ParentBoneName)
		{
			return USkinnedMeshComponent.__BoneIsChildOf_Internal(base.NativePtr, BoneName, ParentBoneName);
		}

		// Token: 0x06004556 RID: 17750
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UnloadSkinWeightProfile_Internal(IntPtr @this, FName InProfileName);

		// Token: 0x06004557 RID: 17751
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UnHideBoneByName_Internal(IntPtr @this, FName BoneName);

		// Token: 0x06004558 RID: 17752
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __TransformToBoneSpace_Internal(IntPtr @this, FName BoneName, FVector InPosition, FRotator InRotation, ref FVector OutPosition, ref FRotator OutRotation);

		// Token: 0x06004559 RID: 17753
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __TransformFromBoneSpace_Internal(IntPtr @this, FName BoneName, FVector InPosition, FRotator InRotation, ref FVector OutPosition, ref FRotator OutRotation);

		// Token: 0x0600455A RID: 17754
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ShowMaterialSection_Internal(IntPtr @this, int MaterialID, int SectionIndex, bool bShow, int LODIndex);

		// Token: 0x0600455B RID: 17755
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ShowAllMaterialSections_Internal(IntPtr @this, int LODIndex);

		// Token: 0x0600455C RID: 17756
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVertexOffsetUsage_Internal(IntPtr @this, int LODIndex, int Usage);

		// Token: 0x0600455D RID: 17757
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVertexColorOverride_LinearColor_Internal(IntPtr @this, int LODIndex, IntPtr VertexColors);

		// Token: 0x0600455E RID: 17758
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SetSkinWeightProfile_Internal(IntPtr @this, FName InProfileName);

		// Token: 0x0600455F RID: 17759
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSkinWeightOverride_Internal(IntPtr @this, int LODIndex, IntPtr SkinWeights);

		// Token: 0x06004560 RID: 17760
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSkeletalMesh_Internal(IntPtr @this, IntPtr NewMesh, bool bReinitPose);

		// Token: 0x06004561 RID: 17761
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetRenderStatic_Internal(IntPtr @this, bool bNewValue);

		// Token: 0x06004562 RID: 17762
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPreSkinningOffsets_Internal(IntPtr @this, int LODIndex, IntPtr Offsets);

		// Token: 0x06004563 RID: 17763
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPostSkinningOffsets_Internal(IntPtr @this, int LODIndex, IntPtr Offsets);

		// Token: 0x06004564 RID: 17764
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPhysicsAsset_Internal(IntPtr @this, IntPtr NewPhysicsAsset, bool bForceReInit);

		// Token: 0x06004565 RID: 17765
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetOverrideMaxlod_Internal(IntPtr @this, bool InOverride);

		// Token: 0x06004566 RID: 17766
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMinLOD_Internal(IntPtr @this, int InNewMinLOD);

		// Token: 0x06004567 RID: 17767
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMaxLOD_Internal(IntPtr @this, int InNewMaxLOD);

		// Token: 0x06004568 RID: 17768
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMasterPoseComponent_Internal(IntPtr @this, IntPtr NewMasterBoneComponent, bool bForceUpdate);

		// Token: 0x06004569 RID: 17769
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLODBias_Internal(IntPtr @this, int InLODBias);

		// Token: 0x0600456A RID: 17770
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetForcedLOD_Internal(IntPtr @this, int InNewForcedLOD);

		// Token: 0x0600456B RID: 17771
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetEnableMaxLod_Internal(IntPtr @this, bool InEnable);

		// Token: 0x0600456C RID: 17772
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetComponentLODBias_Internal(IntPtr @this, int InBias);

		// Token: 0x0600456D RID: 17773
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCastCapsuleIndirectShadow_Internal(IntPtr @this, bool bNewValue);

		// Token: 0x0600456E RID: 17774
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCastCapsuleDirectShadow_Internal(IntPtr @this, bool bNewValue);

		// Token: 0x0600456F RID: 17775
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCapsuleIndirectShadowMinVisibility_Internal(IntPtr @this, float NewValue);

		// Token: 0x06004570 RID: 17776
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SetAnimUpdateRateParameters_Internal(IntPtr @this, IntPtr AnimUpdateRateParamsIn);

		// Token: 0x06004571 RID: 17777
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __RenderedAndNotSkipUpdate_Internal(IntPtr @this);

		// Token: 0x06004572 RID: 17778
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsUsingSkinWeightProfile_Internal(IntPtr @this);

		// Token: 0x06004573 RID: 17779
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsMaterialSectionShown_Internal(IntPtr @this, int MaterialID, int LODIndex);

		// Token: 0x06004574 RID: 17780
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsBoneHiddenByName_Internal(IntPtr @this, FName BoneName);

		// Token: 0x06004575 RID: 17781
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __HideBoneByName_Internal(IntPtr @this, FName BoneName, TEnumAsByte<EPhysBodyOp> PhysBodyOption);

		// Token: 0x06004576 RID: 17782
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetVertexOffsetUsage_Internal(IntPtr @this, int LODIndex);

		// Token: 0x06004577 RID: 17783
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetTwistAndSwingAngleOfDeltaRotationFromRefPose_Internal(IntPtr @this, FName BoneName, ref float OutTwistAngle, ref float OutSwingAngle);

		// Token: 0x06004578 RID: 17784
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FName __GetSocketBoneName_Internal(IntPtr @this, FName InSocketName);

		// Token: 0x06004579 RID: 17785
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetRefPosePosition_Internal(IntPtr @this, int BoneIndex);

		// Token: 0x0600457A RID: 17786
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetPredictedLODLevel_Internal(IntPtr @this);

		// Token: 0x0600457B RID: 17787
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FName __GetParentBone_Internal(IntPtr @this, FName BoneName);

		// Token: 0x0600457C RID: 17788
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetNumSections_Internal(IntPtr @this, int LODIndex);

		// Token: 0x0600457D RID: 17789
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetNumLODs_Internal(IntPtr @this);

		// Token: 0x0600457E RID: 17790
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetNumBones_Internal(IntPtr @this);

		// Token: 0x0600457F RID: 17791
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetMeshObjectLODLevel_Internal(IntPtr @this);

		// Token: 0x06004580 RID: 17792
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetForcedLOD_Internal(IntPtr @this);

		// Token: 0x06004581 RID: 17793
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransform __GetDeltaTransformFromRefPose_Internal(IntPtr @this, FName BoneName, FName BaseName);

		// Token: 0x06004582 RID: 17794
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FName __GetCurrentSkinWeightProfileName_Internal(IntPtr @this);

		// Token: 0x06004583 RID: 17795
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransform __GetBoneTransform_Internal(IntPtr @this, int BoneIndex);

		// Token: 0x06004584 RID: 17796
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FName __GetBoneName_Internal(IntPtr @this, int BoneIndex);

		// Token: 0x06004585 RID: 17797
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetBoneIndex_Internal(IntPtr @this, FName BoneName);

		// Token: 0x06004586 RID: 17798
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetAnimUpdateRateParameters_Internal(IntPtr @this, IntPtr AnimUpdateRateParamsOut);

		// Token: 0x06004587 RID: 17799
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FName __FindClosestBone_K2_Internal(IntPtr @this, FVector TestLocation, ref FVector BoneLocation, float IgnoreScale, bool bRequirePhysicsAsset);

		// Token: 0x06004588 RID: 17800
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __D_TransformToBoneSpace_Internal(IntPtr @this, FName BoneName, FVectorDouble InPosition, FRotator InRotation, ref FVectorDouble OutPosition, ref FRotator OutRotation);

		// Token: 0x06004589 RID: 17801
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __D_TransformFromBoneSpace_Internal(IntPtr @this, FName BoneName, FVectorDouble InPosition, FRotator InRotation, ref FVectorDouble OutPosition, ref FRotator OutRotation);

		// Token: 0x0600458A RID: 17802
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearVertexColorOverride_Internal(IntPtr @this, int LODIndex);

		// Token: 0x0600458B RID: 17803
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearSkinWeightProfile_Internal(IntPtr @this);

		// Token: 0x0600458C RID: 17804
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearSkinWeightOverride_Internal(IntPtr @this, int LODIndex);

		// Token: 0x0600458D RID: 17805
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __BoneIsChildOf_Internal(IntPtr @this, FName BoneName, FName ParentBoneName);

		// Token: 0x0600458E RID: 17806 RVA: 0x000627DD File Offset: 0x000609DD
		static USkinnedMeshComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.SkinnedMeshComponent");
		}

		// Token: 0x0600458F RID: 17807 RVA: 0x000627EC File Offset: 0x000609EC
		protected USkinnedMeshComponent() : this(BuiltinUtils.AllocNativeUObject(USkinnedMeshComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06004590 RID: 17808 RVA: 0x00062814 File Offset: 0x00060A14
		protected USkinnedMeshComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001AE7 RID: 6887
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.SkinnedMeshComponent";

		// Token: 0x04001AE8 RID: 6888
		private static IntPtr _ClassPtr;

		// Token: 0x04001AE9 RID: 6889
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04001AEA RID: 6890
		internal static int __PropertyOffset_SkeletalMesh;

		// Token: 0x04001AEB RID: 6891
		internal static int __PropertyOffset_ExtraMaterialInfos;

		// Token: 0x04001AEC RID: 6892
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FExtraMaterialInfo> _ExtraMaterialInfos;

		// Token: 0x04001AED RID: 6893
		internal static int __PropertyOffset_MasterPoseComponent;

		// Token: 0x04001AEE RID: 6894
		internal static int __PropertyOffset_SkinCacheUsage;

		// Token: 0x04001AEF RID: 6895
		private TArray<ESkinCacheUsage> _SkinCacheUsage;

		// Token: 0x04001AF0 RID: 6896
		internal static int __PropertyOffset_VertexOffsetUsage;

		// Token: 0x04001AF1 RID: 6897
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FVertexOffsetUsage> _VertexOffsetUsage;

		// Token: 0x04001AF2 RID: 6898
		internal static int __PropertyOffset_ComponentSpaceMatricesWithShears;

		// Token: 0x04001AF3 RID: 6899
		private TArray<FMatrix> _ComponentSpaceMatricesWithShears;

		// Token: 0x04001AF4 RID: 6900
		internal static int __PropertyOffset_PreviousComponentSpaceMatricesWithShears;

		// Token: 0x04001AF5 RID: 6901
		private TArray<FMatrix> _PreviousComponentSpaceMatricesWithShears;

		// Token: 0x04001AF6 RID: 6902
		internal static int __PropertyOffset_PhysicsAssetOverride;

		// Token: 0x04001AF7 RID: 6903
		internal static int __PropertyOffset_ForcedLodModel;

		// Token: 0x04001AF8 RID: 6904
		internal static int __PropertyOffset_MinLodModel;

		// Token: 0x04001AF9 RID: 6905
		internal static int __PropertyOffset_bOverrideMinLod;

		// Token: 0x04001AFA RID: 6906
		internal static byte __PropertyMask_bOverrideMinLod;

		// Token: 0x04001AFB RID: 6907
		internal static int __PropertyOffset_MaxLodModel;

		// Token: 0x04001AFC RID: 6908
		internal static int __PropertyOffset_bOverrideMaxLod;

		// Token: 0x04001AFD RID: 6909
		internal static byte __PropertyMask_bOverrideMaxLod;

		// Token: 0x04001AFE RID: 6910
		internal static int __PropertyOffset_bEnableMaxLod;

		// Token: 0x04001AFF RID: 6911
		internal static byte __PropertyMask_bEnableMaxLod;

		// Token: 0x04001B00 RID: 6912
		internal static int __PropertyOffset_StreamingDistanceMultiplier;

		// Token: 0x04001B01 RID: 6913
		internal static int __PropertyOffset_LODTextComponent;

		// Token: 0x04001B02 RID: 6914
		internal static int __PropertyOffset_DistanceTextComponent;

		// Token: 0x04001B03 RID: 6915
		internal static int __PropertyOffset_LODInfo;

		// Token: 0x04001B04 RID: 6916
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSkelMeshComponentLODInfo> _LODInfo;

		// Token: 0x04001B05 RID: 6917
		internal static int __PropertyOffset_VisibilityBasedAnimTickOption;

		// Token: 0x04001B06 RID: 6918
		internal static int __PropertyOffset_bAllowBoneVisibilityStatesDifferentWithMaster;

		// Token: 0x04001B07 RID: 6919
		internal static int __PropertyOffset_bRequireHiddenBonesCalculation;

		// Token: 0x04001B08 RID: 6920
		internal static int __PropertyOffset_bUseBoundsFromMasterPoseComponent;

		// Token: 0x04001B09 RID: 6921
		internal static byte __PropertyMask_bUseBoundsFromMasterPoseComponent;

		// Token: 0x04001B0A RID: 6922
		internal static int __PropertyOffset_bForceWireframe;

		// Token: 0x04001B0B RID: 6923
		internal static byte __PropertyMask_bForceWireframe;

		// Token: 0x04001B0C RID: 6924
		internal static int __PropertyOffset_bDisplayBones_DEPRECATED;

		// Token: 0x04001B0D RID: 6925
		internal static byte __PropertyMask_bDisplayBones_DEPRECATED;

		// Token: 0x04001B0E RID: 6926
		internal static int __PropertyOffset_bDisableMorphTarget;

		// Token: 0x04001B0F RID: 6927
		internal static byte __PropertyMask_bDisableMorphTarget;

		// Token: 0x04001B10 RID: 6928
		internal static int __PropertyOffset_bHideSkin;

		// Token: 0x04001B11 RID: 6929
		internal static byte __PropertyMask_bHideSkin;

		// Token: 0x04001B12 RID: 6930
		internal static int __PropertyOffset_bPerBoneMotionBlur;

		// Token: 0x04001B13 RID: 6931
		internal static byte __PropertyMask_bPerBoneMotionBlur;

		// Token: 0x04001B14 RID: 6932
		internal static int __PropertyOffset_bComponentUseFixedSkelBounds;

		// Token: 0x04001B15 RID: 6933
		internal static byte __PropertyMask_bComponentUseFixedSkelBounds;

		// Token: 0x04001B16 RID: 6934
		internal static int __PropertyOffset_bConsiderAllBodiesForBounds;

		// Token: 0x04001B17 RID: 6935
		internal static byte __PropertyMask_bConsiderAllBodiesForBounds;

		// Token: 0x04001B18 RID: 6936
		internal static int __PropertyOffset_bSyncAttachParentLOD;

		// Token: 0x04001B19 RID: 6937
		internal static byte __PropertyMask_bSyncAttachParentLOD;

		// Token: 0x04001B1A RID: 6938
		internal static int __PropertyOffset_bResetMorphTargetsWhenSetSkeletalMesh;

		// Token: 0x04001B1B RID: 6939
		internal static int __PropertyOffset_bCanHighlightSelectedSections;

		// Token: 0x04001B1C RID: 6940
		internal static byte __PropertyMask_bCanHighlightSelectedSections;

		// Token: 0x04001B1D RID: 6941
		internal static int __PropertyOffset_bRecentlyRendered;

		// Token: 0x04001B1E RID: 6942
		internal static byte __PropertyMask_bRecentlyRendered;

		// Token: 0x04001B1F RID: 6943
		internal static int __PropertyOffset_bForceTickThisFrame;

		// Token: 0x04001B20 RID: 6944
		internal static byte __PropertyMask_bForceTickThisFrame;

		// Token: 0x04001B21 RID: 6945
		internal static int __PropertyOffset_bCastCapsuleDirectShadow;

		// Token: 0x04001B22 RID: 6946
		internal static byte __PropertyMask_bCastCapsuleDirectShadow;

		// Token: 0x04001B23 RID: 6947
		internal static int __PropertyOffset_bCastCapsuleIndirectShadow;

		// Token: 0x04001B24 RID: 6948
		internal static byte __PropertyMask_bCastCapsuleIndirectShadow;

		// Token: 0x04001B25 RID: 6949
		internal static int __PropertyOffset_bCPUSkinning;

		// Token: 0x04001B26 RID: 6950
		internal static byte __PropertyMask_bCPUSkinning;

		// Token: 0x04001B27 RID: 6951
		internal static int __PropertyOffset_bEnableUpdateRateOptimizations;

		// Token: 0x04001B28 RID: 6952
		internal static byte __PropertyMask_bEnableUpdateRateOptimizations;

		// Token: 0x04001B29 RID: 6953
		internal static int __PropertyOffset_bDisplayDebugUpdateRateOptimizations;

		// Token: 0x04001B2A RID: 6954
		internal static byte __PropertyMask_bDisplayDebugUpdateRateOptimizations;

		// Token: 0x04001B2B RID: 6955
		internal static int __PropertyOffset_bRenderStatic;

		// Token: 0x04001B2C RID: 6956
		internal static byte __PropertyMask_bRenderStatic;

		// Token: 0x04001B2D RID: 6957
		internal static int __PropertyOffset_bIgnoreMasterPoseComponentLOD;

		// Token: 0x04001B2E RID: 6958
		internal static byte __PropertyMask_bIgnoreMasterPoseComponentLOD;

		// Token: 0x04001B2F RID: 6959
		internal static int __PropertyOffset_bCachedLocalBoundsUpToDate;

		// Token: 0x04001B30 RID: 6960
		internal static byte __PropertyMask_bCachedLocalBoundsUpToDate;

		// Token: 0x04001B31 RID: 6961
		internal static int __PropertyOffset_bForceMeshObjectUpdate;

		// Token: 0x04001B32 RID: 6962
		internal static byte __PropertyMask_bForceMeshObjectUpdate;

		// Token: 0x04001B33 RID: 6963
		internal static int __PropertyOffset_CapsuleIndirectShadowMinVisibility;

		// Token: 0x04001B34 RID: 6964
		internal static int __PropertyOffset_ComponentLODBias;

		// Token: 0x04001B35 RID: 6965
		internal static int __PropertyOffset_bEnableGlobalLODBias;

		// Token: 0x04001B36 RID: 6966
		internal static byte __PropertyMask_bEnableGlobalLODBias;

		// Token: 0x04001B37 RID: 6967
		internal static int __PropertyOffset_CachedWorldSpaceBounds;

		// Token: 0x04001B38 RID: 6968
		internal static int __PropertyOffset_CachedWorldToLocalTransform;
	}
}
