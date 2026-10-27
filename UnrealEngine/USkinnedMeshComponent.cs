using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001110 RID: 4368
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.SkinnedMeshComponent")]
	[UnrealStructLayout(2624, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2624)]
	public abstract class USkinnedMeshComponent : UMeshComponent, IUnrealUObject, IUnrealObject, ILODSyncInterface, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x0600FD6F RID: 64879 RVA: 0x0017646D File Offset: 0x0017466D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USkinnedMeshComponent._ClassPtr;
		}

		// Token: 0x0600FD70 RID: 64880 RVA: 0x00176479 File Offset: 0x00174679
		int ILODSyncInterface.InterfaceOffset()
		{
			return USkinnedMeshComponent.__InterfaceOffset_ILODSyncInterface;
		}

		// Token: 0x17003DD4 RID: 15828
		// (get) Token: 0x0600FD71 RID: 64881 RVA: 0x00176480 File Offset: 0x00174680
		// (set) Token: 0x0600FD72 RID: 64882 RVA: 0x00176494 File Offset: 0x00174694
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

		// Token: 0x17003DD5 RID: 15829
		// (get) Token: 0x0600FD73 RID: 64883 RVA: 0x001764AC File Offset: 0x001746AC
		// (set) Token: 0x0600FD74 RID: 64884 RVA: 0x001764E5 File Offset: 0x001746E5
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

		// Token: 0x17003DD6 RID: 15830
		// (get) Token: 0x0600FD75 RID: 64885 RVA: 0x001764F3 File Offset: 0x001746F3
		// (set) Token: 0x0600FD76 RID: 64886 RVA: 0x00176507 File Offset: 0x00174707
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

		// Token: 0x17003DD7 RID: 15831
		// (get) Token: 0x0600FD77 RID: 64887 RVA: 0x0017651C File Offset: 0x0017471C
		// (set) Token: 0x0600FD78 RID: 64888 RVA: 0x00176555 File Offset: 0x00174755
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

		// Token: 0x17003DD8 RID: 15832
		// (get) Token: 0x0600FD79 RID: 64889 RVA: 0x00176564 File Offset: 0x00174764
		// (set) Token: 0x0600FD7A RID: 64890 RVA: 0x0017659D File Offset: 0x0017479D
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

		// Token: 0x17003DD9 RID: 15833
		// (get) Token: 0x0600FD7B RID: 64891 RVA: 0x001765AC File Offset: 0x001747AC
		// (set) Token: 0x0600FD7C RID: 64892 RVA: 0x001765E5 File Offset: 0x001747E5
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

		// Token: 0x17003DDA RID: 15834
		// (get) Token: 0x0600FD7D RID: 64893 RVA: 0x001765F4 File Offset: 0x001747F4
		// (set) Token: 0x0600FD7E RID: 64894 RVA: 0x0017662D File Offset: 0x0017482D
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

		// Token: 0x17003DDB RID: 15835
		// (get) Token: 0x0600FD7F RID: 64895 RVA: 0x0017663B File Offset: 0x0017483B
		// (set) Token: 0x0600FD80 RID: 64896 RVA: 0x0017664F File Offset: 0x0017484F
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

		// Token: 0x17003DDC RID: 15836
		// (get) Token: 0x0600FD81 RID: 64897 RVA: 0x00176664 File Offset: 0x00174864
		// (set) Token: 0x0600FD82 RID: 64898 RVA: 0x00176674 File Offset: 0x00174874
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

		// Token: 0x17003DDD RID: 15837
		// (get) Token: 0x0600FD83 RID: 64899 RVA: 0x00176685 File Offset: 0x00174885
		// (set) Token: 0x0600FD84 RID: 64900 RVA: 0x00176695 File Offset: 0x00174895
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

		// Token: 0x17003DDE RID: 15838
		// (get) Token: 0x0600FD85 RID: 64901 RVA: 0x001766A6 File Offset: 0x001748A6
		// (set) Token: 0x0600FD86 RID: 64902 RVA: 0x001766BF File Offset: 0x001748BF
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

		// Token: 0x17003DDF RID: 15839
		// (get) Token: 0x0600FD87 RID: 64903 RVA: 0x001766EF File Offset: 0x001748EF
		// (set) Token: 0x0600FD88 RID: 64904 RVA: 0x001766FF File Offset: 0x001748FF
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

		// Token: 0x17003DE0 RID: 15840
		// (get) Token: 0x0600FD89 RID: 64905 RVA: 0x00176710 File Offset: 0x00174910
		// (set) Token: 0x0600FD8A RID: 64906 RVA: 0x00176729 File Offset: 0x00174929
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

		// Token: 0x17003DE1 RID: 15841
		// (get) Token: 0x0600FD8B RID: 64907 RVA: 0x00176759 File Offset: 0x00174959
		// (set) Token: 0x0600FD8C RID: 64908 RVA: 0x00176772 File Offset: 0x00174972
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

		// Token: 0x17003DE2 RID: 15842
		// (get) Token: 0x0600FD8D RID: 64909 RVA: 0x001767A2 File Offset: 0x001749A2
		// (set) Token: 0x0600FD8E RID: 64910 RVA: 0x001767B2 File Offset: 0x001749B2
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

		// Token: 0x17003DE3 RID: 15843
		// (get) Token: 0x0600FD8F RID: 64911 RVA: 0x001767C3 File Offset: 0x001749C3
		// (set) Token: 0x0600FD90 RID: 64912 RVA: 0x001767D7 File Offset: 0x001749D7
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

		// Token: 0x17003DE4 RID: 15844
		// (get) Token: 0x0600FD91 RID: 64913 RVA: 0x001767EC File Offset: 0x001749EC
		// (set) Token: 0x0600FD92 RID: 64914 RVA: 0x00176800 File Offset: 0x00174A00
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

		// Token: 0x17003DE5 RID: 15845
		// (get) Token: 0x0600FD93 RID: 64915 RVA: 0x00176818 File Offset: 0x00174A18
		// (set) Token: 0x0600FD94 RID: 64916 RVA: 0x00176851 File Offset: 0x00174A51
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

		// Token: 0x17003DE6 RID: 15846
		// (get) Token: 0x0600FD95 RID: 64917 RVA: 0x0017685F File Offset: 0x00174A5F
		// (set) Token: 0x0600FD96 RID: 64918 RVA: 0x0017686F File Offset: 0x00174A6F
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

		// Token: 0x17003DE7 RID: 15847
		// (get) Token: 0x0600FD97 RID: 64919 RVA: 0x00176880 File Offset: 0x00174A80
		// (set) Token: 0x0600FD98 RID: 64920 RVA: 0x00176890 File Offset: 0x00174A90
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

		// Token: 0x17003DE8 RID: 15848
		// (get) Token: 0x0600FD99 RID: 64921 RVA: 0x001768A1 File Offset: 0x00174AA1
		// (set) Token: 0x0600FD9A RID: 64922 RVA: 0x001768B1 File Offset: 0x00174AB1
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

		// Token: 0x17003DE9 RID: 15849
		// (get) Token: 0x0600FD9B RID: 64923 RVA: 0x001768C2 File Offset: 0x00174AC2
		// (set) Token: 0x0600FD9C RID: 64924 RVA: 0x001768DB File Offset: 0x00174ADB
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

		// Token: 0x17003DEA RID: 15850
		// (get) Token: 0x0600FD9D RID: 64925 RVA: 0x0017690B File Offset: 0x00174B0B
		// (set) Token: 0x0600FD9E RID: 64926 RVA: 0x00176924 File Offset: 0x00174B24
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

		// Token: 0x17003DEB RID: 15851
		// (get) Token: 0x0600FD9F RID: 64927 RVA: 0x00176954 File Offset: 0x00174B54
		// (set) Token: 0x0600FDA0 RID: 64928 RVA: 0x0017696D File Offset: 0x00174B6D
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

		// Token: 0x17003DEC RID: 15852
		// (get) Token: 0x0600FDA1 RID: 64929 RVA: 0x0017699D File Offset: 0x00174B9D
		// (set) Token: 0x0600FDA2 RID: 64930 RVA: 0x001769B6 File Offset: 0x00174BB6
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

		// Token: 0x17003DED RID: 15853
		// (get) Token: 0x0600FDA3 RID: 64931 RVA: 0x001769E6 File Offset: 0x00174BE6
		// (set) Token: 0x0600FDA4 RID: 64932 RVA: 0x001769FF File Offset: 0x00174BFF
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

		// Token: 0x17003DEE RID: 15854
		// (get) Token: 0x0600FDA5 RID: 64933 RVA: 0x00176A2F File Offset: 0x00174C2F
		// (set) Token: 0x0600FDA6 RID: 64934 RVA: 0x00176A48 File Offset: 0x00174C48
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

		// Token: 0x17003DEF RID: 15855
		// (get) Token: 0x0600FDA7 RID: 64935 RVA: 0x00176A78 File Offset: 0x00174C78
		// (set) Token: 0x0600FDA8 RID: 64936 RVA: 0x00176A91 File Offset: 0x00174C91
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

		// Token: 0x17003DF0 RID: 15856
		// (get) Token: 0x0600FDA9 RID: 64937 RVA: 0x00176AC1 File Offset: 0x00174CC1
		// (set) Token: 0x0600FDAA RID: 64938 RVA: 0x00176ADA File Offset: 0x00174CDA
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

		// Token: 0x17003DF1 RID: 15857
		// (get) Token: 0x0600FDAB RID: 64939 RVA: 0x00176B0A File Offset: 0x00174D0A
		// (set) Token: 0x0600FDAC RID: 64940 RVA: 0x00176B23 File Offset: 0x00174D23
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

		// Token: 0x17003DF2 RID: 15858
		// (get) Token: 0x0600FDAD RID: 64941 RVA: 0x00176B53 File Offset: 0x00174D53
		// (set) Token: 0x0600FDAE RID: 64942 RVA: 0x00176B63 File Offset: 0x00174D63
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

		// Token: 0x17003DF3 RID: 15859
		// (get) Token: 0x0600FDAF RID: 64943 RVA: 0x00176B74 File Offset: 0x00174D74
		// (set) Token: 0x0600FDB0 RID: 64944 RVA: 0x00176B8D File Offset: 0x00174D8D
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

		// Token: 0x17003DF4 RID: 15860
		// (get) Token: 0x0600FDB1 RID: 64945 RVA: 0x00176BBD File Offset: 0x00174DBD
		// (set) Token: 0x0600FDB2 RID: 64946 RVA: 0x00176BD6 File Offset: 0x00174DD6
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

		// Token: 0x17003DF5 RID: 15861
		// (get) Token: 0x0600FDB3 RID: 64947 RVA: 0x00176C06 File Offset: 0x00174E06
		// (set) Token: 0x0600FDB4 RID: 64948 RVA: 0x00176C1F File Offset: 0x00174E1F
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

		// Token: 0x17003DF6 RID: 15862
		// (get) Token: 0x0600FDB5 RID: 64949 RVA: 0x00176C4F File Offset: 0x00174E4F
		// (set) Token: 0x0600FDB6 RID: 64950 RVA: 0x00176C68 File Offset: 0x00174E68
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

		// Token: 0x17003DF7 RID: 15863
		// (get) Token: 0x0600FDB7 RID: 64951 RVA: 0x00176C98 File Offset: 0x00174E98
		// (set) Token: 0x0600FDB8 RID: 64952 RVA: 0x00176CB1 File Offset: 0x00174EB1
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

		// Token: 0x17003DF8 RID: 15864
		// (get) Token: 0x0600FDB9 RID: 64953 RVA: 0x00176CE1 File Offset: 0x00174EE1
		// (set) Token: 0x0600FDBA RID: 64954 RVA: 0x00176CFA File Offset: 0x00174EFA
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

		// Token: 0x17003DF9 RID: 15865
		// (get) Token: 0x0600FDBB RID: 64955 RVA: 0x00176D2A File Offset: 0x00174F2A
		// (set) Token: 0x0600FDBC RID: 64956 RVA: 0x00176D43 File Offset: 0x00174F43
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

		// Token: 0x17003DFA RID: 15866
		// (get) Token: 0x0600FDBD RID: 64957 RVA: 0x00176D73 File Offset: 0x00174F73
		// (set) Token: 0x0600FDBE RID: 64958 RVA: 0x00176D8C File Offset: 0x00174F8C
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

		// Token: 0x17003DFB RID: 15867
		// (get) Token: 0x0600FDBF RID: 64959 RVA: 0x00176DBC File Offset: 0x00174FBC
		// (set) Token: 0x0600FDC0 RID: 64960 RVA: 0x00176DD5 File Offset: 0x00174FD5
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

		// Token: 0x17003DFC RID: 15868
		// (get) Token: 0x0600FDC1 RID: 64961 RVA: 0x00176E05 File Offset: 0x00175005
		// (set) Token: 0x0600FDC2 RID: 64962 RVA: 0x00176E1E File Offset: 0x0017501E
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

		// Token: 0x17003DFD RID: 15869
		// (get) Token: 0x0600FDC3 RID: 64963 RVA: 0x00176E4E File Offset: 0x0017504E
		// (set) Token: 0x0600FDC4 RID: 64964 RVA: 0x00176E67 File Offset: 0x00175067
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

		// Token: 0x17003DFE RID: 15870
		// (get) Token: 0x0600FDC5 RID: 64965 RVA: 0x00176E97 File Offset: 0x00175097
		// (set) Token: 0x0600FDC6 RID: 64966 RVA: 0x00176EB0 File Offset: 0x001750B0
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

		// Token: 0x17003DFF RID: 15871
		// (get) Token: 0x0600FDC7 RID: 64967 RVA: 0x00176EE0 File Offset: 0x001750E0
		// (set) Token: 0x0600FDC8 RID: 64968 RVA: 0x00176EF0 File Offset: 0x001750F0
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

		// Token: 0x17003E00 RID: 15872
		// (get) Token: 0x0600FDC9 RID: 64969 RVA: 0x00176F01 File Offset: 0x00175101
		// (set) Token: 0x0600FDCA RID: 64970 RVA: 0x00176F11 File Offset: 0x00175111
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

		// Token: 0x17003E01 RID: 15873
		// (get) Token: 0x0600FDCB RID: 64971 RVA: 0x00176F22 File Offset: 0x00175122
		// (set) Token: 0x0600FDCC RID: 64972 RVA: 0x00176F3B File Offset: 0x0017513B
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

		// Token: 0x17003E02 RID: 15874
		// (get) Token: 0x0600FDCD RID: 64973 RVA: 0x00176F6B File Offset: 0x0017516B
		// (set) Token: 0x0600FDCE RID: 64974 RVA: 0x00176F7F File Offset: 0x0017517F
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

		// Token: 0x17003E03 RID: 15875
		// (get) Token: 0x0600FDCF RID: 64975 RVA: 0x00176F94 File Offset: 0x00175194
		// (set) Token: 0x0600FDD0 RID: 64976 RVA: 0x00176FA8 File Offset: 0x001751A8
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

		// Token: 0x0600FDD1 RID: 64977 RVA: 0x00176FBD File Offset: 0x001751BD
		public void UnloadSkinWeightProfile(FName InProfileName)
		{
			USkinnedMeshComponent.__UnloadSkinWeightProfile_Internal(base.NativePtr, InProfileName);
		}

		// Token: 0x0600FDD2 RID: 64978 RVA: 0x00176FCB File Offset: 0x001751CB
		public void UnHideBoneByName(FName BoneName)
		{
			USkinnedMeshComponent.__UnHideBoneByName_Internal(base.NativePtr, BoneName);
		}

		// Token: 0x0600FDD3 RID: 64979 RVA: 0x00176FDC File Offset: 0x001751DC
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

		// Token: 0x0600FDD4 RID: 64980 RVA: 0x00177010 File Offset: 0x00175210
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

		// Token: 0x0600FDD5 RID: 64981 RVA: 0x00177041 File Offset: 0x00175241
		public void ShowMaterialSection(int MaterialID, int SectionIndex, bool bShow, int LODIndex)
		{
			USkinnedMeshComponent.__ShowMaterialSection_Internal(base.NativePtr, MaterialID, SectionIndex, bShow, LODIndex);
		}

		// Token: 0x0600FDD6 RID: 64982 RVA: 0x00177053 File Offset: 0x00175253
		public void ShowAllMaterialSections(int LODIndex)
		{
			USkinnedMeshComponent.__ShowAllMaterialSections_Internal(base.NativePtr, LODIndex);
		}

		// Token: 0x0600FDD7 RID: 64983 RVA: 0x00177061 File Offset: 0x00175261
		public void SetVertexOffsetUsage(int LODIndex, int Usage)
		{
			USkinnedMeshComponent.__SetVertexOffsetUsage_Internal(base.NativePtr, LODIndex, Usage);
		}

		// Token: 0x0600FDD8 RID: 64984 RVA: 0x00177070 File Offset: 0x00175270
		public void SetVertexColorOverride_LinearColor(int LODIndex, in TArray<FLinearColor> VertexColors)
		{
			USkinnedMeshComponent.__SetVertexColorOverride_LinearColor_Internal(base.NativePtr, LODIndex, (VertexColors ?? new TArray<FLinearColor>()).NativePtr);
		}

		// Token: 0x0600FDD9 RID: 64985 RVA: 0x0017708E File Offset: 0x0017528E
		public bool SetSkinWeightProfile(FName InProfileName)
		{
			return USkinnedMeshComponent.__SetSkinWeightProfile_Internal(base.NativePtr, InProfileName);
		}

		// Token: 0x0600FDDA RID: 64986 RVA: 0x0017709C File Offset: 0x0017529C
		public void SetSkinWeightOverride(int LODIndex, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FSkelMeshSkinWeightInfo> SkinWeights)
		{
			USkinnedMeshComponent.__SetSkinWeightOverride_Internal(base.NativePtr, LODIndex, (SkinWeights ?? new TArray<FSkelMeshSkinWeightInfo>()).NativePtr);
		}

		// Token: 0x0600FDDB RID: 64987 RVA: 0x001770BA File Offset: 0x001752BA
		public void SetSkeletalMesh(USkeletalMesh NewMesh, bool bReinitPose = true)
		{
			USkinnedMeshComponent.__SetSkeletalMesh_Internal(base.NativePtr, (NewMesh != null) ? NewMesh.NativePtr : IntPtr.Zero, bReinitPose);
		}

		// Token: 0x0600FDDC RID: 64988 RVA: 0x001770D8 File Offset: 0x001752D8
		public void SetRenderStatic(bool bNewValue)
		{
			USkinnedMeshComponent.__SetRenderStatic_Internal(base.NativePtr, bNewValue);
		}

		// Token: 0x0600FDDD RID: 64989 RVA: 0x001770E6 File Offset: 0x001752E6
		public void SetPreSkinningOffsets(int LODIndex, TArray<FVector> Offsets)
		{
			USkinnedMeshComponent.__SetPreSkinningOffsets_Internal(base.NativePtr, LODIndex, (Offsets ?? new TArray<FVector>()).NativePtr);
		}

		// Token: 0x0600FDDE RID: 64990 RVA: 0x00177103 File Offset: 0x00175303
		public void SetPostSkinningOffsets(int LODIndex, TArray<FVector> Offsets)
		{
			USkinnedMeshComponent.__SetPostSkinningOffsets_Internal(base.NativePtr, LODIndex, (Offsets ?? new TArray<FVector>()).NativePtr);
		}

		// Token: 0x0600FDDF RID: 64991 RVA: 0x00177120 File Offset: 0x00175320
		public void SetPhysicsAsset(UPhysicsAsset NewPhysicsAsset, bool bForceReInit = false)
		{
			USkinnedMeshComponent.__SetPhysicsAsset_Internal(base.NativePtr, (NewPhysicsAsset != null) ? NewPhysicsAsset.NativePtr : IntPtr.Zero, bForceReInit);
		}

		// Token: 0x0600FDE0 RID: 64992 RVA: 0x0017713E File Offset: 0x0017533E
		public void SetOverrideMaxlod(bool InOverride)
		{
			USkinnedMeshComponent.__SetOverrideMaxlod_Internal(base.NativePtr, InOverride);
		}

		// Token: 0x0600FDE1 RID: 64993 RVA: 0x0017714C File Offset: 0x0017534C
		public void SetMinLOD(int InNewMinLOD)
		{
			USkinnedMeshComponent.__SetMinLOD_Internal(base.NativePtr, InNewMinLOD);
		}

		// Token: 0x0600FDE2 RID: 64994 RVA: 0x0017715A File Offset: 0x0017535A
		public void SetMaxLOD(int InNewMaxLOD)
		{
			USkinnedMeshComponent.__SetMaxLOD_Internal(base.NativePtr, InNewMaxLOD);
		}

		// Token: 0x0600FDE3 RID: 64995 RVA: 0x00177168 File Offset: 0x00175368
		public void SetMasterPoseComponent(USkinnedMeshComponent NewMasterBoneComponent, bool bForceUpdate = false)
		{
			USkinnedMeshComponent.__SetMasterPoseComponent_Internal(base.NativePtr, (NewMasterBoneComponent != null) ? NewMasterBoneComponent.NativePtr : IntPtr.Zero, bForceUpdate);
		}

		// Token: 0x0600FDE4 RID: 64996 RVA: 0x00177186 File Offset: 0x00175386
		public void SetLODBias(int InLODBias)
		{
			USkinnedMeshComponent.__SetLODBias_Internal(base.NativePtr, InLODBias);
		}

		// Token: 0x0600FDE5 RID: 64997 RVA: 0x00177194 File Offset: 0x00175394
		public void SetForcedLOD(int InNewForcedLOD)
		{
			USkinnedMeshComponent.__SetForcedLOD_Internal(base.NativePtr, InNewForcedLOD);
		}

		// Token: 0x0600FDE6 RID: 64998 RVA: 0x001771A2 File Offset: 0x001753A2
		public void SetEnableMaxLod(bool InEnable)
		{
			USkinnedMeshComponent.__SetEnableMaxLod_Internal(base.NativePtr, InEnable);
		}

		// Token: 0x0600FDE7 RID: 64999 RVA: 0x001771B0 File Offset: 0x001753B0
		public void SetComponentLODBias(int InBias)
		{
			USkinnedMeshComponent.__SetComponentLODBias_Internal(base.NativePtr, InBias);
		}

		// Token: 0x0600FDE8 RID: 65000 RVA: 0x001771BE File Offset: 0x001753BE
		public void SetCastCapsuleIndirectShadow(bool bNewValue)
		{
			USkinnedMeshComponent.__SetCastCapsuleIndirectShadow_Internal(base.NativePtr, bNewValue);
		}

		// Token: 0x0600FDE9 RID: 65001 RVA: 0x001771CC File Offset: 0x001753CC
		public void SetCastCapsuleDirectShadow(bool bNewValue)
		{
			USkinnedMeshComponent.__SetCastCapsuleDirectShadow_Internal(base.NativePtr, bNewValue);
		}

		// Token: 0x0600FDEA RID: 65002 RVA: 0x001771DA File Offset: 0x001753DA
		public void SetCapsuleIndirectShadowMinVisibility(float NewValue)
		{
			USkinnedMeshComponent.__SetCapsuleIndirectShadowMinVisibility_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x0600FDEB RID: 65003 RVA: 0x001771E8 File Offset: 0x001753E8
		public bool SetAnimUpdateRateParameters(ref FAnimUpdateRateParameters AnimUpdateRateParamsIn)
		{
			return USkinnedMeshComponent.__SetAnimUpdateRateParameters_Internal(base.NativePtr, (AnimUpdateRateParamsIn ?? new FAnimUpdateRateParameters()).NativePtr);
		}

		// Token: 0x0600FDEC RID: 65004 RVA: 0x00177205 File Offset: 0x00175405
		public bool RenderedAndNotSkipUpdate()
		{
			return USkinnedMeshComponent.__RenderedAndNotSkipUpdate_Internal(base.NativePtr);
		}

		// Token: 0x0600FDED RID: 65005 RVA: 0x00177212 File Offset: 0x00175412
		public bool IsUsingSkinWeightProfile()
		{
			return USkinnedMeshComponent.__IsUsingSkinWeightProfile_Internal(base.NativePtr);
		}

		// Token: 0x0600FDEE RID: 65006 RVA: 0x0017721F File Offset: 0x0017541F
		public bool IsMaterialSectionShown(int MaterialID, int LODIndex)
		{
			return USkinnedMeshComponent.__IsMaterialSectionShown_Internal(base.NativePtr, MaterialID, LODIndex);
		}

		// Token: 0x0600FDEF RID: 65007 RVA: 0x0017722E File Offset: 0x0017542E
		public bool IsBoneHiddenByName(FName BoneName)
		{
			return USkinnedMeshComponent.__IsBoneHiddenByName_Internal(base.NativePtr, BoneName);
		}

		// Token: 0x0600FDF0 RID: 65008 RVA: 0x0017723C File Offset: 0x0017543C
		public void HideBoneByName(FName BoneName, EPhysBodyOp PhysBodyOption)
		{
			USkinnedMeshComponent.__HideBoneByName_Internal(base.NativePtr, BoneName, PhysBodyOption);
		}

		// Token: 0x0600FDF1 RID: 65009 RVA: 0x00177250 File Offset: 0x00175450
		public int GetVertexOffsetUsage(int LODIndex)
		{
			return USkinnedMeshComponent.__GetVertexOffsetUsage_Internal(base.NativePtr, LODIndex);
		}

		// Token: 0x0600FDF2 RID: 65010 RVA: 0x00177260 File Offset: 0x00175460
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

		// Token: 0x0600FDF3 RID: 65011 RVA: 0x00177285 File Offset: 0x00175485
		public FName GetSocketBoneName(FName InSocketName)
		{
			return USkinnedMeshComponent.__GetSocketBoneName_Internal(base.NativePtr, InSocketName);
		}

		// Token: 0x0600FDF4 RID: 65012 RVA: 0x00177293 File Offset: 0x00175493
		public FVector GetRefPosePosition(int BoneIndex)
		{
			return USkinnedMeshComponent.__GetRefPosePosition_Internal(base.NativePtr, BoneIndex);
		}

		// Token: 0x0600FDF5 RID: 65013 RVA: 0x001772A1 File Offset: 0x001754A1
		public int GetPredictedLODLevel()
		{
			return USkinnedMeshComponent.__GetPredictedLODLevel_Internal(base.NativePtr);
		}

		// Token: 0x0600FDF6 RID: 65014 RVA: 0x001772AE File Offset: 0x001754AE
		public FName GetParentBone(FName BoneName)
		{
			return USkinnedMeshComponent.__GetParentBone_Internal(base.NativePtr, BoneName);
		}

		// Token: 0x0600FDF7 RID: 65015 RVA: 0x001772BC File Offset: 0x001754BC
		public int GetNumSections(int LODIndex)
		{
			return USkinnedMeshComponent.__GetNumSections_Internal(base.NativePtr, LODIndex);
		}

		// Token: 0x0600FDF8 RID: 65016 RVA: 0x001772CA File Offset: 0x001754CA
		public int GetNumLODs()
		{
			return USkinnedMeshComponent.__GetNumLODs_Internal(base.NativePtr);
		}

		// Token: 0x0600FDF9 RID: 65017 RVA: 0x001772D7 File Offset: 0x001754D7
		public int GetNumBones()
		{
			return USkinnedMeshComponent.__GetNumBones_Internal(base.NativePtr);
		}

		// Token: 0x0600FDFA RID: 65018 RVA: 0x001772E4 File Offset: 0x001754E4
		public int GetMeshObjectLODLevel()
		{
			return USkinnedMeshComponent.__GetMeshObjectLODLevel_Internal(base.NativePtr);
		}

		// Token: 0x0600FDFB RID: 65019 RVA: 0x001772F1 File Offset: 0x001754F1
		public int GetForcedLOD()
		{
			return USkinnedMeshComponent.__GetForcedLOD_Internal(base.NativePtr);
		}

		// Token: 0x0600FDFC RID: 65020 RVA: 0x001772FE File Offset: 0x001754FE
		public FTransform GetDeltaTransformFromRefPose(FName BoneName, FName BaseName = default(FName))
		{
			return USkinnedMeshComponent.__GetDeltaTransformFromRefPose_Internal(base.NativePtr, BoneName, BaseName);
		}

		// Token: 0x0600FDFD RID: 65021 RVA: 0x0017730D File Offset: 0x0017550D
		public FName GetCurrentSkinWeightProfileName()
		{
			return USkinnedMeshComponent.__GetCurrentSkinWeightProfileName_Internal(base.NativePtr);
		}

		// Token: 0x0600FDFE RID: 65022 RVA: 0x0017731A File Offset: 0x0017551A
		public FTransform GetBoneTransform(int BoneIndex)
		{
			return USkinnedMeshComponent.__GetBoneTransform_Internal(base.NativePtr, BoneIndex);
		}

		// Token: 0x0600FDFF RID: 65023 RVA: 0x00177328 File Offset: 0x00175528
		public FName GetBoneName(int BoneIndex)
		{
			return USkinnedMeshComponent.__GetBoneName_Internal(base.NativePtr, BoneIndex);
		}

		// Token: 0x0600FE00 RID: 65024 RVA: 0x00177336 File Offset: 0x00175536
		public int GetBoneIndex(FName BoneName)
		{
			return USkinnedMeshComponent.__GetBoneIndex_Internal(base.NativePtr, BoneName);
		}

		// Token: 0x0600FE01 RID: 65025 RVA: 0x00177344 File Offset: 0x00175544
		public bool GetAnimUpdateRateParameters(ref FAnimUpdateRateParameters AnimUpdateRateParamsOut)
		{
			return USkinnedMeshComponent.__GetAnimUpdateRateParameters_Internal(base.NativePtr, (AnimUpdateRateParamsOut ?? new FAnimUpdateRateParameters()).NativePtr);
		}

		// Token: 0x0600FE02 RID: 65026 RVA: 0x00177364 File Offset: 0x00175564
		public unsafe FName FindClosestBone_K2(FVector TestLocation, ref FVector BoneLocation, float IgnoreScale = 0f, bool bRequirePhysicsAsset = false)
		{
			fixed (FVector* ptr = &BoneLocation)
			{
				void* ptr2 = (void*)ptr;
				return USkinnedMeshComponent.__FindClosestBone_K2_Internal(base.NativePtr, TestLocation, ref BoneLocation, IgnoreScale, bRequirePhysicsAsset);
			}
		}

		// Token: 0x0600FE03 RID: 65027 RVA: 0x00177388 File Offset: 0x00175588
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

		// Token: 0x0600FE04 RID: 65028 RVA: 0x001773BC File Offset: 0x001755BC
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

		// Token: 0x0600FE05 RID: 65029 RVA: 0x001773ED File Offset: 0x001755ED
		public void ClearVertexColorOverride(int LODIndex)
		{
			USkinnedMeshComponent.__ClearVertexColorOverride_Internal(base.NativePtr, LODIndex);
		}

		// Token: 0x0600FE06 RID: 65030 RVA: 0x001773FB File Offset: 0x001755FB
		public void ClearSkinWeightProfile()
		{
			USkinnedMeshComponent.__ClearSkinWeightProfile_Internal(base.NativePtr);
		}

		// Token: 0x0600FE07 RID: 65031 RVA: 0x00177408 File Offset: 0x00175608
		public void ClearSkinWeightOverride(int LODIndex)
		{
			USkinnedMeshComponent.__ClearSkinWeightOverride_Internal(base.NativePtr, LODIndex);
		}

		// Token: 0x0600FE08 RID: 65032 RVA: 0x00177416 File Offset: 0x00175616
		public bool BoneIsChildOf(FName BoneName, FName ParentBoneName)
		{
			return USkinnedMeshComponent.__BoneIsChildOf_Internal(base.NativePtr, BoneName, ParentBoneName);
		}

		// Token: 0x0600FE09 RID: 65033
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UnloadSkinWeightProfile_Internal(IntPtr @this, FName InProfileName);

		// Token: 0x0600FE0A RID: 65034
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UnHideBoneByName_Internal(IntPtr @this, FName BoneName);

		// Token: 0x0600FE0B RID: 65035
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __TransformToBoneSpace_Internal(IntPtr @this, FName BoneName, FVector InPosition, FRotator InRotation, ref FVector OutPosition, ref FRotator OutRotation);

		// Token: 0x0600FE0C RID: 65036
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __TransformFromBoneSpace_Internal(IntPtr @this, FName BoneName, FVector InPosition, FRotator InRotation, ref FVector OutPosition, ref FRotator OutRotation);

		// Token: 0x0600FE0D RID: 65037
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ShowMaterialSection_Internal(IntPtr @this, int MaterialID, int SectionIndex, bool bShow, int LODIndex);

		// Token: 0x0600FE0E RID: 65038
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ShowAllMaterialSections_Internal(IntPtr @this, int LODIndex);

		// Token: 0x0600FE0F RID: 65039
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVertexOffsetUsage_Internal(IntPtr @this, int LODIndex, int Usage);

		// Token: 0x0600FE10 RID: 65040
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVertexColorOverride_LinearColor_Internal(IntPtr @this, int LODIndex, IntPtr VertexColors);

		// Token: 0x0600FE11 RID: 65041
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SetSkinWeightProfile_Internal(IntPtr @this, FName InProfileName);

		// Token: 0x0600FE12 RID: 65042
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSkinWeightOverride_Internal(IntPtr @this, int LODIndex, IntPtr SkinWeights);

		// Token: 0x0600FE13 RID: 65043
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSkeletalMesh_Internal(IntPtr @this, IntPtr NewMesh, bool bReinitPose);

		// Token: 0x0600FE14 RID: 65044
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetRenderStatic_Internal(IntPtr @this, bool bNewValue);

		// Token: 0x0600FE15 RID: 65045
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPreSkinningOffsets_Internal(IntPtr @this, int LODIndex, IntPtr Offsets);

		// Token: 0x0600FE16 RID: 65046
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPostSkinningOffsets_Internal(IntPtr @this, int LODIndex, IntPtr Offsets);

		// Token: 0x0600FE17 RID: 65047
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPhysicsAsset_Internal(IntPtr @this, IntPtr NewPhysicsAsset, bool bForceReInit);

		// Token: 0x0600FE18 RID: 65048
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetOverrideMaxlod_Internal(IntPtr @this, bool InOverride);

		// Token: 0x0600FE19 RID: 65049
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMinLOD_Internal(IntPtr @this, int InNewMinLOD);

		// Token: 0x0600FE1A RID: 65050
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMaxLOD_Internal(IntPtr @this, int InNewMaxLOD);

		// Token: 0x0600FE1B RID: 65051
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMasterPoseComponent_Internal(IntPtr @this, IntPtr NewMasterBoneComponent, bool bForceUpdate);

		// Token: 0x0600FE1C RID: 65052
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLODBias_Internal(IntPtr @this, int InLODBias);

		// Token: 0x0600FE1D RID: 65053
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetForcedLOD_Internal(IntPtr @this, int InNewForcedLOD);

		// Token: 0x0600FE1E RID: 65054
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetEnableMaxLod_Internal(IntPtr @this, bool InEnable);

		// Token: 0x0600FE1F RID: 65055
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetComponentLODBias_Internal(IntPtr @this, int InBias);

		// Token: 0x0600FE20 RID: 65056
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCastCapsuleIndirectShadow_Internal(IntPtr @this, bool bNewValue);

		// Token: 0x0600FE21 RID: 65057
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCastCapsuleDirectShadow_Internal(IntPtr @this, bool bNewValue);

		// Token: 0x0600FE22 RID: 65058
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCapsuleIndirectShadowMinVisibility_Internal(IntPtr @this, float NewValue);

		// Token: 0x0600FE23 RID: 65059
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SetAnimUpdateRateParameters_Internal(IntPtr @this, IntPtr AnimUpdateRateParamsIn);

		// Token: 0x0600FE24 RID: 65060
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __RenderedAndNotSkipUpdate_Internal(IntPtr @this);

		// Token: 0x0600FE25 RID: 65061
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsUsingSkinWeightProfile_Internal(IntPtr @this);

		// Token: 0x0600FE26 RID: 65062
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsMaterialSectionShown_Internal(IntPtr @this, int MaterialID, int LODIndex);

		// Token: 0x0600FE27 RID: 65063
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsBoneHiddenByName_Internal(IntPtr @this, FName BoneName);

		// Token: 0x0600FE28 RID: 65064
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __HideBoneByName_Internal(IntPtr @this, FName BoneName, TEnumAsByte<EPhysBodyOp> PhysBodyOption);

		// Token: 0x0600FE29 RID: 65065
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetVertexOffsetUsage_Internal(IntPtr @this, int LODIndex);

		// Token: 0x0600FE2A RID: 65066
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetTwistAndSwingAngleOfDeltaRotationFromRefPose_Internal(IntPtr @this, FName BoneName, ref float OutTwistAngle, ref float OutSwingAngle);

		// Token: 0x0600FE2B RID: 65067
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FName __GetSocketBoneName_Internal(IntPtr @this, FName InSocketName);

		// Token: 0x0600FE2C RID: 65068
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetRefPosePosition_Internal(IntPtr @this, int BoneIndex);

		// Token: 0x0600FE2D RID: 65069
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetPredictedLODLevel_Internal(IntPtr @this);

		// Token: 0x0600FE2E RID: 65070
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FName __GetParentBone_Internal(IntPtr @this, FName BoneName);

		// Token: 0x0600FE2F RID: 65071
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetNumSections_Internal(IntPtr @this, int LODIndex);

		// Token: 0x0600FE30 RID: 65072
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetNumLODs_Internal(IntPtr @this);

		// Token: 0x0600FE31 RID: 65073
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetNumBones_Internal(IntPtr @this);

		// Token: 0x0600FE32 RID: 65074
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetMeshObjectLODLevel_Internal(IntPtr @this);

		// Token: 0x0600FE33 RID: 65075
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetForcedLOD_Internal(IntPtr @this);

		// Token: 0x0600FE34 RID: 65076
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransform __GetDeltaTransformFromRefPose_Internal(IntPtr @this, FName BoneName, FName BaseName);

		// Token: 0x0600FE35 RID: 65077
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FName __GetCurrentSkinWeightProfileName_Internal(IntPtr @this);

		// Token: 0x0600FE36 RID: 65078
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransform __GetBoneTransform_Internal(IntPtr @this, int BoneIndex);

		// Token: 0x0600FE37 RID: 65079
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FName __GetBoneName_Internal(IntPtr @this, int BoneIndex);

		// Token: 0x0600FE38 RID: 65080
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetBoneIndex_Internal(IntPtr @this, FName BoneName);

		// Token: 0x0600FE39 RID: 65081
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetAnimUpdateRateParameters_Internal(IntPtr @this, IntPtr AnimUpdateRateParamsOut);

		// Token: 0x0600FE3A RID: 65082
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FName __FindClosestBone_K2_Internal(IntPtr @this, FVector TestLocation, ref FVector BoneLocation, float IgnoreScale, bool bRequirePhysicsAsset);

		// Token: 0x0600FE3B RID: 65083
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __D_TransformToBoneSpace_Internal(IntPtr @this, FName BoneName, FVectorDouble InPosition, FRotator InRotation, ref FVectorDouble OutPosition, ref FRotator OutRotation);

		// Token: 0x0600FE3C RID: 65084
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __D_TransformFromBoneSpace_Internal(IntPtr @this, FName BoneName, FVectorDouble InPosition, FRotator InRotation, ref FVectorDouble OutPosition, ref FRotator OutRotation);

		// Token: 0x0600FE3D RID: 65085
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearVertexColorOverride_Internal(IntPtr @this, int LODIndex);

		// Token: 0x0600FE3E RID: 65086
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearSkinWeightProfile_Internal(IntPtr @this);

		// Token: 0x0600FE3F RID: 65087
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearSkinWeightOverride_Internal(IntPtr @this, int LODIndex);

		// Token: 0x0600FE40 RID: 65088
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __BoneIsChildOf_Internal(IntPtr @this, FName BoneName, FName ParentBoneName);

		// Token: 0x0600FE41 RID: 65089 RVA: 0x00177425 File Offset: 0x00175625
		static USkinnedMeshComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.SkinnedMeshComponent");
		}

		// Token: 0x0600FE42 RID: 65090 RVA: 0x00177434 File Offset: 0x00175634
		protected USkinnedMeshComponent() : this(BuiltinUtils.AllocNativeUObject(USkinnedMeshComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600FE43 RID: 65091 RVA: 0x0017745C File Offset: 0x0017565C
		protected USkinnedMeshComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040088A6 RID: 34982
		internal static int __InterfaceOffset_ILODSyncInterface;

		// Token: 0x040088A7 RID: 34983
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.SkinnedMeshComponent";

		// Token: 0x040088A8 RID: 34984
		private static IntPtr _ClassPtr;

		// Token: 0x040088A9 RID: 34985
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040088AA RID: 34986
		internal static int __PropertyOffset_SkeletalMesh;

		// Token: 0x040088AB RID: 34987
		internal static int __PropertyOffset_ExtraMaterialInfos;

		// Token: 0x040088AC RID: 34988
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FExtraMaterialInfo> _ExtraMaterialInfos;

		// Token: 0x040088AD RID: 34989
		internal static int __PropertyOffset_MasterPoseComponent;

		// Token: 0x040088AE RID: 34990
		internal static int __PropertyOffset_SkinCacheUsage;

		// Token: 0x040088AF RID: 34991
		private TArray<ESkinCacheUsage> _SkinCacheUsage;

		// Token: 0x040088B0 RID: 34992
		internal static int __PropertyOffset_VertexOffsetUsage;

		// Token: 0x040088B1 RID: 34993
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FVertexOffsetUsage> _VertexOffsetUsage;

		// Token: 0x040088B2 RID: 34994
		internal static int __PropertyOffset_ComponentSpaceMatricesWithShears;

		// Token: 0x040088B3 RID: 34995
		private TArray<FMatrix> _ComponentSpaceMatricesWithShears;

		// Token: 0x040088B4 RID: 34996
		internal static int __PropertyOffset_PreviousComponentSpaceMatricesWithShears;

		// Token: 0x040088B5 RID: 34997
		private TArray<FMatrix> _PreviousComponentSpaceMatricesWithShears;

		// Token: 0x040088B6 RID: 34998
		internal static int __PropertyOffset_PhysicsAssetOverride;

		// Token: 0x040088B7 RID: 34999
		internal static int __PropertyOffset_ForcedLodModel;

		// Token: 0x040088B8 RID: 35000
		internal static int __PropertyOffset_MinLodModel;

		// Token: 0x040088B9 RID: 35001
		internal static int __PropertyOffset_bOverrideMinLod;

		// Token: 0x040088BA RID: 35002
		internal static byte __PropertyMask_bOverrideMinLod;

		// Token: 0x040088BB RID: 35003
		internal static int __PropertyOffset_MaxLodModel;

		// Token: 0x040088BC RID: 35004
		internal static int __PropertyOffset_bOverrideMaxLod;

		// Token: 0x040088BD RID: 35005
		internal static byte __PropertyMask_bOverrideMaxLod;

		// Token: 0x040088BE RID: 35006
		internal static int __PropertyOffset_bEnableMaxLod;

		// Token: 0x040088BF RID: 35007
		internal static byte __PropertyMask_bEnableMaxLod;

		// Token: 0x040088C0 RID: 35008
		internal static int __PropertyOffset_StreamingDistanceMultiplier;

		// Token: 0x040088C1 RID: 35009
		internal static int __PropertyOffset_LODTextComponent;

		// Token: 0x040088C2 RID: 35010
		internal static int __PropertyOffset_DistanceTextComponent;

		// Token: 0x040088C3 RID: 35011
		internal static int __PropertyOffset_LODInfo;

		// Token: 0x040088C4 RID: 35012
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSkelMeshComponentLODInfo> _LODInfo;

		// Token: 0x040088C5 RID: 35013
		internal static int __PropertyOffset_VisibilityBasedAnimTickOption;

		// Token: 0x040088C6 RID: 35014
		internal static int __PropertyOffset_bAllowBoneVisibilityStatesDifferentWithMaster;

		// Token: 0x040088C7 RID: 35015
		internal static int __PropertyOffset_bRequireHiddenBonesCalculation;

		// Token: 0x040088C8 RID: 35016
		internal static int __PropertyOffset_bUseBoundsFromMasterPoseComponent;

		// Token: 0x040088C9 RID: 35017
		internal static byte __PropertyMask_bUseBoundsFromMasterPoseComponent;

		// Token: 0x040088CA RID: 35018
		internal static int __PropertyOffset_bForceWireframe;

		// Token: 0x040088CB RID: 35019
		internal static byte __PropertyMask_bForceWireframe;

		// Token: 0x040088CC RID: 35020
		internal static int __PropertyOffset_bDisplayBones_DEPRECATED;

		// Token: 0x040088CD RID: 35021
		internal static byte __PropertyMask_bDisplayBones_DEPRECATED;

		// Token: 0x040088CE RID: 35022
		internal static int __PropertyOffset_bDisableMorphTarget;

		// Token: 0x040088CF RID: 35023
		internal static byte __PropertyMask_bDisableMorphTarget;

		// Token: 0x040088D0 RID: 35024
		internal static int __PropertyOffset_bHideSkin;

		// Token: 0x040088D1 RID: 35025
		internal static byte __PropertyMask_bHideSkin;

		// Token: 0x040088D2 RID: 35026
		internal static int __PropertyOffset_bPerBoneMotionBlur;

		// Token: 0x040088D3 RID: 35027
		internal static byte __PropertyMask_bPerBoneMotionBlur;

		// Token: 0x040088D4 RID: 35028
		internal static int __PropertyOffset_bComponentUseFixedSkelBounds;

		// Token: 0x040088D5 RID: 35029
		internal static byte __PropertyMask_bComponentUseFixedSkelBounds;

		// Token: 0x040088D6 RID: 35030
		internal static int __PropertyOffset_bConsiderAllBodiesForBounds;

		// Token: 0x040088D7 RID: 35031
		internal static byte __PropertyMask_bConsiderAllBodiesForBounds;

		// Token: 0x040088D8 RID: 35032
		internal static int __PropertyOffset_bSyncAttachParentLOD;

		// Token: 0x040088D9 RID: 35033
		internal static byte __PropertyMask_bSyncAttachParentLOD;

		// Token: 0x040088DA RID: 35034
		internal static int __PropertyOffset_bResetMorphTargetsWhenSetSkeletalMesh;

		// Token: 0x040088DB RID: 35035
		internal static int __PropertyOffset_bCanHighlightSelectedSections;

		// Token: 0x040088DC RID: 35036
		internal static byte __PropertyMask_bCanHighlightSelectedSections;

		// Token: 0x040088DD RID: 35037
		internal static int __PropertyOffset_bRecentlyRendered;

		// Token: 0x040088DE RID: 35038
		internal static byte __PropertyMask_bRecentlyRendered;

		// Token: 0x040088DF RID: 35039
		internal static int __PropertyOffset_bForceTickThisFrame;

		// Token: 0x040088E0 RID: 35040
		internal static byte __PropertyMask_bForceTickThisFrame;

		// Token: 0x040088E1 RID: 35041
		internal static int __PropertyOffset_bCastCapsuleDirectShadow;

		// Token: 0x040088E2 RID: 35042
		internal static byte __PropertyMask_bCastCapsuleDirectShadow;

		// Token: 0x040088E3 RID: 35043
		internal static int __PropertyOffset_bCastCapsuleIndirectShadow;

		// Token: 0x040088E4 RID: 35044
		internal static byte __PropertyMask_bCastCapsuleIndirectShadow;

		// Token: 0x040088E5 RID: 35045
		internal static int __PropertyOffset_bCPUSkinning;

		// Token: 0x040088E6 RID: 35046
		internal static byte __PropertyMask_bCPUSkinning;

		// Token: 0x040088E7 RID: 35047
		internal static int __PropertyOffset_bEnableUpdateRateOptimizations;

		// Token: 0x040088E8 RID: 35048
		internal static byte __PropertyMask_bEnableUpdateRateOptimizations;

		// Token: 0x040088E9 RID: 35049
		internal static int __PropertyOffset_bDisplayDebugUpdateRateOptimizations;

		// Token: 0x040088EA RID: 35050
		internal static byte __PropertyMask_bDisplayDebugUpdateRateOptimizations;

		// Token: 0x040088EB RID: 35051
		internal static int __PropertyOffset_bRenderStatic;

		// Token: 0x040088EC RID: 35052
		internal static byte __PropertyMask_bRenderStatic;

		// Token: 0x040088ED RID: 35053
		internal static int __PropertyOffset_bIgnoreMasterPoseComponentLOD;

		// Token: 0x040088EE RID: 35054
		internal static byte __PropertyMask_bIgnoreMasterPoseComponentLOD;

		// Token: 0x040088EF RID: 35055
		internal static int __PropertyOffset_bCachedLocalBoundsUpToDate;

		// Token: 0x040088F0 RID: 35056
		internal static byte __PropertyMask_bCachedLocalBoundsUpToDate;

		// Token: 0x040088F1 RID: 35057
		internal static int __PropertyOffset_bForceMeshObjectUpdate;

		// Token: 0x040088F2 RID: 35058
		internal static byte __PropertyMask_bForceMeshObjectUpdate;

		// Token: 0x040088F3 RID: 35059
		internal static int __PropertyOffset_CapsuleIndirectShadowMinVisibility;

		// Token: 0x040088F4 RID: 35060
		internal static int __PropertyOffset_ComponentLODBias;

		// Token: 0x040088F5 RID: 35061
		internal static int __PropertyOffset_bEnableGlobalLODBias;

		// Token: 0x040088F6 RID: 35062
		internal static byte __PropertyMask_bEnableGlobalLODBias;

		// Token: 0x040088F7 RID: 35063
		internal static int __PropertyOffset_CachedWorldSpaceBounds;

		// Token: 0x040088F8 RID: 35064
		internal static int __PropertyOffset_CachedWorldToLocalTransform;
	}
}
