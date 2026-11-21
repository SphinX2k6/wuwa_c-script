using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200027E RID: 638
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.SkeletalMesh")]
	[UnrealStructLayout(5048, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 5048)]
	public class USkeletalMesh : UStreamableRenderAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600420B RID: 16907 RVA: 0x0005E620 File Offset: 0x0005C820
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USkeletalMesh._ClassPtr;
		}

		// Token: 0x0600420C RID: 16908 RVA: 0x0005E62C File Offset: 0x0005C82C
		public USkeletalMesh() : this(BuiltinUtils.AllocNativeUObject(USkeletalMesh.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600420D RID: 16909 RVA: 0x0005E654 File Offset: 0x0005C854
		public USkeletalMesh(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USkeletalMesh.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000C24 RID: 3108
		// (get) Token: 0x0600420E RID: 16910 RVA: 0x0005E687 File Offset: 0x0005C887
		// (set) Token: 0x0600420F RID: 16911 RVA: 0x0005E69B File Offset: 0x0005C89B
		[Nullable(2)]
		public unsafe USkeleton Skeleton
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeleton>(base.NativePtr / (IntPtr)sizeof(void*) + USkeletalMesh.__PropertyOffset_Skeleton);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + USkeletalMesh.__PropertyOffset_Skeleton, value);
			}
		}

		// Token: 0x17000C25 RID: 3109
		// (get) Token: 0x06004210 RID: 16912 RVA: 0x0005E6B0 File Offset: 0x0005C8B0
		// (set) Token: 0x06004211 RID: 16913 RVA: 0x0005E6C0 File Offset: 0x0005C8C0
		public unsafe bool bEnableBoneFold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkeletalMesh.__PropertyOffset_bEnableBoneFold) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkeletalMesh.__PropertyOffset_bEnableBoneFold) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000C26 RID: 3110
		// (get) Token: 0x06004212 RID: 16914 RVA: 0x0005E6D1 File Offset: 0x0005C8D1
		// (set) Token: 0x06004213 RID: 16915 RVA: 0x0005E6E1 File Offset: 0x0005C8E1
		public unsafe bool UseKneeTransparency
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkeletalMesh.__PropertyOffset_UseKneeTransparency) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkeletalMesh.__PropertyOffset_UseKneeTransparency) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000C27 RID: 3111
		// (get) Token: 0x06004214 RID: 16916 RVA: 0x0005E6F2 File Offset: 0x0005C8F2
		// (set) Token: 0x06004215 RID: 16917 RVA: 0x0005E702 File Offset: 0x0005C902
		public unsafe bool UseCustomBonePosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkeletalMesh.__PropertyOffset_UseCustomBonePosition) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkeletalMesh.__PropertyOffset_UseCustomBonePosition) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000C28 RID: 3112
		// (get) Token: 0x06004216 RID: 16918 RVA: 0x0005E714 File Offset: 0x0005C914
		// (set) Token: 0x06004217 RID: 16919 RVA: 0x0005E74D File Offset: 0x0005C94D
		public TMap<FName, int> CustomBoneNamesIndices
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, int> result;
				if ((result = this._CustomBoneNamesIndices) == null)
				{
					result = (this._CustomBoneNamesIndices = new TMap<FName, int>(base.NativePtr + (IntPtr)USkeletalMesh.__PropertyOffset_CustomBoneNamesIndices, this));
				}
				return result;
			}
			set
			{
				this.CustomBoneNamesIndices.CopyAssign(value);
			}
		}

		// Token: 0x17000C29 RID: 3113
		// (get) Token: 0x06004218 RID: 16920 RVA: 0x0005E75B File Offset: 0x0005C95B
		// (set) Token: 0x06004219 RID: 16921 RVA: 0x0005E76F File Offset: 0x0005C96F
		public unsafe FName HeadBoneName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkeletalMesh.__PropertyOffset_HeadBoneName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkeletalMesh.__PropertyOffset_HeadBoneName) = value;
			}
		}

		// Token: 0x17000C2A RID: 3114
		// (get) Token: 0x0600421A RID: 16922 RVA: 0x0005E784 File Offset: 0x0005C984
		// (set) Token: 0x0600421B RID: 16923 RVA: 0x0005E7BD File Offset: 0x0005C9BD
		public TArray<int> LODBoneFoldMapping
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._LODBoneFoldMapping) == null)
				{
					result = (this._LODBoneFoldMapping = new TArray<int>(base.NativePtr + (IntPtr)USkeletalMesh.__PropertyOffset_LODBoneFoldMapping, this));
				}
				return result;
			}
			set
			{
				this.LODBoneFoldMapping.CopyAssign(value);
			}
		}

		// Token: 0x17000C2B RID: 3115
		// (get) Token: 0x0600421C RID: 16924 RVA: 0x0005E7CB File Offset: 0x0005C9CB
		// (set) Token: 0x0600421D RID: 16925 RVA: 0x0005E7DF File Offset: 0x0005C9DF
		public unsafe FBoxSphereBounds ImportedBounds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkeletalMesh.__PropertyOffset_ImportedBounds);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkeletalMesh.__PropertyOffset_ImportedBounds) = value;
			}
		}

		// Token: 0x17000C2C RID: 3116
		// (get) Token: 0x0600421E RID: 16926 RVA: 0x0005E7F4 File Offset: 0x0005C9F4
		// (set) Token: 0x0600421F RID: 16927 RVA: 0x0005E808 File Offset: 0x0005CA08
		public unsafe FBoxSphereBounds ExtendedBounds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkeletalMesh.__PropertyOffset_ExtendedBounds);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkeletalMesh.__PropertyOffset_ExtendedBounds) = value;
			}
		}

		// Token: 0x17000C2D RID: 3117
		// (get) Token: 0x06004220 RID: 16928 RVA: 0x0005E81D File Offset: 0x0005CA1D
		// (set) Token: 0x06004221 RID: 16929 RVA: 0x0005E82D File Offset: 0x0005CA2D
		public unsafe float ImportedBoundsScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkeletalMesh.__PropertyOffset_ImportedBoundsScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkeletalMesh.__PropertyOffset_ImportedBoundsScale) = value;
			}
		}

		// Token: 0x17000C2E RID: 3118
		// (get) Token: 0x06004222 RID: 16930 RVA: 0x0005E83E File Offset: 0x0005CA3E
		// (set) Token: 0x06004223 RID: 16931 RVA: 0x0005E852 File Offset: 0x0005CA52
		public unsafe FVector PositiveBoundsExtension
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkeletalMesh.__PropertyOffset_PositiveBoundsExtension);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkeletalMesh.__PropertyOffset_PositiveBoundsExtension) = value;
			}
		}

		// Token: 0x17000C2F RID: 3119
		// (get) Token: 0x06004224 RID: 16932 RVA: 0x0005E867 File Offset: 0x0005CA67
		// (set) Token: 0x06004225 RID: 16933 RVA: 0x0005E87B File Offset: 0x0005CA7B
		public unsafe FVector NegativeBoundsExtension
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkeletalMesh.__PropertyOffset_NegativeBoundsExtension);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkeletalMesh.__PropertyOffset_NegativeBoundsExtension) = value;
			}
		}

		// Token: 0x17000C30 RID: 3120
		// (get) Token: 0x06004226 RID: 16934 RVA: 0x0005E890 File Offset: 0x0005CA90
		// (set) Token: 0x06004227 RID: 16935 RVA: 0x0005E8A0 File Offset: 0x0005CAA0
		public unsafe bool bEnableBoneBounds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkeletalMesh.__PropertyOffset_bEnableBoneBounds) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkeletalMesh.__PropertyOffset_bEnableBoneBounds) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000C31 RID: 3121
		// (get) Token: 0x06004228 RID: 16936 RVA: 0x0005E8B1 File Offset: 0x0005CAB1
		// (set) Token: 0x06004229 RID: 16937 RVA: 0x0005E8C1 File Offset: 0x0005CAC1
		public unsafe float BoneBoundsExtension
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkeletalMesh.__PropertyOffset_BoneBoundsExtension);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkeletalMesh.__PropertyOffset_BoneBoundsExtension) = value;
			}
		}

		// Token: 0x17000C32 RID: 3122
		// (get) Token: 0x0600422A RID: 16938 RVA: 0x0005E8D2 File Offset: 0x0005CAD2
		// (set) Token: 0x0600422B RID: 16939 RVA: 0x0005E8E2 File Offset: 0x0005CAE2
		public unsafe bool bBoneBoundsApplyBounds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkeletalMesh.__PropertyOffset_bBoneBoundsApplyBounds) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkeletalMesh.__PropertyOffset_bBoneBoundsApplyBounds) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000C33 RID: 3123
		// (get) Token: 0x0600422C RID: 16940 RVA: 0x0005E8F3 File Offset: 0x0005CAF3
		// (set) Token: 0x0600422D RID: 16941 RVA: 0x0005E903 File Offset: 0x0005CB03
		public unsafe bool bSkipCullVelocity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkeletalMesh.__PropertyOffset_bSkipCullVelocity) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkeletalMesh.__PropertyOffset_bSkipCullVelocity) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000C34 RID: 3124
		// (get) Token: 0x0600422E RID: 16942 RVA: 0x0005E914 File Offset: 0x0005CB14
		// (set) Token: 0x0600422F RID: 16943 RVA: 0x0005E924 File Offset: 0x0005CB24
		public unsafe bool bForceUseExpandedTexcoords
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkeletalMesh.__PropertyOffset_bForceUseExpandedTexcoords) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkeletalMesh.__PropertyOffset_bForceUseExpandedTexcoords) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000C35 RID: 3125
		// (get) Token: 0x06004230 RID: 16944 RVA: 0x0005E935 File Offset: 0x0005CB35
		// (set) Token: 0x06004231 RID: 16945 RVA: 0x0005E945 File Offset: 0x0005CB45
		public unsafe int NumSectionsBeforeCook
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkeletalMesh.__PropertyOffset_NumSectionsBeforeCook);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkeletalMesh.__PropertyOffset_NumSectionsBeforeCook) = value;
			}
		}

		// Token: 0x17000C36 RID: 3126
		// (get) Token: 0x06004232 RID: 16946 RVA: 0x0005E956 File Offset: 0x0005CB56
		// (set) Token: 0x06004233 RID: 16947 RVA: 0x0005E966 File Offset: 0x0005CB66
		public unsafe int NumSectionsAfterCooked
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkeletalMesh.__PropertyOffset_NumSectionsAfterCooked);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkeletalMesh.__PropertyOffset_NumSectionsAfterCooked) = value;
			}
		}

		// Token: 0x17000C37 RID: 3127
		// (get) Token: 0x06004234 RID: 16948 RVA: 0x0005E978 File Offset: 0x0005CB78
		// (set) Token: 0x06004235 RID: 16949 RVA: 0x0005E9B1 File Offset: 0x0005CBB1
		public TArray<FSkeletalMaterial> Materials
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FSkeletalMaterial> result;
				if ((result = this._Materials) == null)
				{
					result = (this._Materials = new TArray<FSkeletalMaterial>(base.NativePtr + (IntPtr)USkeletalMesh.__PropertyOffset_Materials, this));
				}
				return result;
			}
			set
			{
				this.Materials.CopyAssign(value);
			}
		}

		// Token: 0x17000C38 RID: 3128
		// (get) Token: 0x06004236 RID: 16950 RVA: 0x0005E9BF File Offset: 0x0005CBBF
		// (set) Token: 0x06004237 RID: 16951 RVA: 0x0005E9CF File Offset: 0x0005CBCF
		public unsafe float ScreenSizeCullRatio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkeletalMesh.__PropertyOffset_ScreenSizeCullRatio);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkeletalMesh.__PropertyOffset_ScreenSizeCullRatio) = value;
			}
		}

		// Token: 0x17000C39 RID: 3129
		// (get) Token: 0x06004238 RID: 16952 RVA: 0x0005E9E0 File Offset: 0x0005CBE0
		// (set) Token: 0x06004239 RID: 16953 RVA: 0x0005E9F0 File Offset: 0x0005CBF0
		public unsafe bool bUseKuroLODDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkeletalMesh.__PropertyOffset_bUseKuroLODDistance) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkeletalMesh.__PropertyOffset_bUseKuroLODDistance) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000C3A RID: 3130
		// (get) Token: 0x0600423A RID: 16954 RVA: 0x0005EA01 File Offset: 0x0005CC01
		// (set) Token: 0x0600423B RID: 16955 RVA: 0x0005EA15 File Offset: 0x0005CC15
		[Nullable(0)]
		public unsafe TEnumAsByte<EAxis> SkelMirrorAxis
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)USkeletalMesh.__PropertyOffset_SkelMirrorAxis);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)USkeletalMesh.__PropertyOffset_SkelMirrorAxis) = value;
			}
		}

		// Token: 0x17000C3B RID: 3131
		// (get) Token: 0x0600423C RID: 16956 RVA: 0x0005EA2A File Offset: 0x0005CC2A
		// (set) Token: 0x0600423D RID: 16957 RVA: 0x0005EA3E File Offset: 0x0005CC3E
		[Nullable(0)]
		public unsafe TEnumAsByte<EAxis> SkelMirrorFlipAxis
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)USkeletalMesh.__PropertyOffset_SkelMirrorFlipAxis);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)USkeletalMesh.__PropertyOffset_SkelMirrorFlipAxis) = value;
			}
		}

		// Token: 0x17000C3C RID: 3132
		// (get) Token: 0x0600423E RID: 16958 RVA: 0x0005EA53 File Offset: 0x0005CC53
		// (set) Token: 0x0600423F RID: 16959 RVA: 0x0005EA6C File Offset: 0x0005CC6C
		public unsafe bool bUseFullPrecisionUVs_DEPRECATED
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USkeletalMesh.__PropertyOffset_bUseFullPrecisionUVs_DEPRECATED) & USkeletalMesh.__PropertyMask_bUseFullPrecisionUVs_DEPRECATED) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USkeletalMesh.__PropertyOffset_bUseFullPrecisionUVs_DEPRECATED) = ((*(base.NativePtr + (IntPtr)USkeletalMesh.__PropertyOffset_bUseFullPrecisionUVs_DEPRECATED) & ~USkeletalMesh.__PropertyMask_bUseFullPrecisionUVs_DEPRECATED) | (value ? USkeletalMesh.__PropertyMask_bUseFullPrecisionUVs_DEPRECATED : 0));
			}
		}

		// Token: 0x17000C3D RID: 3133
		// (get) Token: 0x06004240 RID: 16960 RVA: 0x0005EA9C File Offset: 0x0005CC9C
		// (set) Token: 0x06004241 RID: 16961 RVA: 0x0005EAB5 File Offset: 0x0005CCB5
		public unsafe bool bUseHighPrecisionTangentBasis_DEPRECATED
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USkeletalMesh.__PropertyOffset_bUseHighPrecisionTangentBasis_DEPRECATED) & USkeletalMesh.__PropertyMask_bUseHighPrecisionTangentBasis_DEPRECATED) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USkeletalMesh.__PropertyOffset_bUseHighPrecisionTangentBasis_DEPRECATED) = ((*(base.NativePtr + (IntPtr)USkeletalMesh.__PropertyOffset_bUseHighPrecisionTangentBasis_DEPRECATED) & ~USkeletalMesh.__PropertyMask_bUseHighPrecisionTangentBasis_DEPRECATED) | (value ? USkeletalMesh.__PropertyMask_bUseHighPrecisionTangentBasis_DEPRECATED : 0));
			}
		}

		// Token: 0x17000C3E RID: 3134
		// (get) Token: 0x06004242 RID: 16962 RVA: 0x0005EAE5 File Offset: 0x0005CCE5
		// (set) Token: 0x06004243 RID: 16963 RVA: 0x0005EAFE File Offset: 0x0005CCFE
		public unsafe bool bHasBeenSimplified
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USkeletalMesh.__PropertyOffset_bHasBeenSimplified) & USkeletalMesh.__PropertyMask_bHasBeenSimplified) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USkeletalMesh.__PropertyOffset_bHasBeenSimplified) = ((*(base.NativePtr + (IntPtr)USkeletalMesh.__PropertyOffset_bHasBeenSimplified) & ~USkeletalMesh.__PropertyMask_bHasBeenSimplified) | (value ? USkeletalMesh.__PropertyMask_bHasBeenSimplified : 0));
			}
		}

		// Token: 0x17000C3F RID: 3135
		// (get) Token: 0x06004244 RID: 16964 RVA: 0x0005EB2E File Offset: 0x0005CD2E
		// (set) Token: 0x06004245 RID: 16965 RVA: 0x0005EB47 File Offset: 0x0005CD47
		public unsafe bool bHasVertexColors
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USkeletalMesh.__PropertyOffset_bHasVertexColors) & USkeletalMesh.__PropertyMask_bHasVertexColors) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USkeletalMesh.__PropertyOffset_bHasVertexColors) = ((*(base.NativePtr + (IntPtr)USkeletalMesh.__PropertyOffset_bHasVertexColors) & ~USkeletalMesh.__PropertyMask_bHasVertexColors) | (value ? USkeletalMesh.__PropertyMask_bHasVertexColors : 0));
			}
		}

		// Token: 0x17000C40 RID: 3136
		// (get) Token: 0x06004246 RID: 16966 RVA: 0x0005EB77 File Offset: 0x0005CD77
		// (set) Token: 0x06004247 RID: 16967 RVA: 0x0005EB90 File Offset: 0x0005CD90
		public unsafe bool bEnablePerPolyCollision
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USkeletalMesh.__PropertyOffset_bEnablePerPolyCollision) & USkeletalMesh.__PropertyMask_bEnablePerPolyCollision) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USkeletalMesh.__PropertyOffset_bEnablePerPolyCollision) = ((*(base.NativePtr + (IntPtr)USkeletalMesh.__PropertyOffset_bEnablePerPolyCollision) & ~USkeletalMesh.__PropertyMask_bEnablePerPolyCollision) | (value ? USkeletalMesh.__PropertyMask_bEnablePerPolyCollision : 0));
			}
		}

		// Token: 0x17000C41 RID: 3137
		// (get) Token: 0x06004248 RID: 16968 RVA: 0x0005EBC0 File Offset: 0x0005CDC0
		// (set) Token: 0x06004249 RID: 16969 RVA: 0x0005EBD4 File Offset: 0x0005CDD4
		[Nullable(2)]
		public unsafe UBodySetup BodySetup
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBodySetup>(base.NativePtr / (IntPtr)sizeof(void*) + USkeletalMesh.__PropertyOffset_BodySetup);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + USkeletalMesh.__PropertyOffset_BodySetup, value);
			}
		}

		// Token: 0x17000C42 RID: 3138
		// (get) Token: 0x0600424A RID: 16970 RVA: 0x0005EBE9 File Offset: 0x0005CDE9
		// (set) Token: 0x0600424B RID: 16971 RVA: 0x0005EBFD File Offset: 0x0005CDFD
		[Nullable(2)]
		public unsafe UPhysicsAsset PhysicsAsset
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPhysicsAsset>(base.NativePtr / (IntPtr)sizeof(void*) + USkeletalMesh.__PropertyOffset_PhysicsAsset);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + USkeletalMesh.__PropertyOffset_PhysicsAsset, value);
			}
		}

		// Token: 0x17000C43 RID: 3139
		// (get) Token: 0x0600424C RID: 16972 RVA: 0x0005EC12 File Offset: 0x0005CE12
		// (set) Token: 0x0600424D RID: 16973 RVA: 0x0005EC26 File Offset: 0x0005CE26
		[Nullable(2)]
		public unsafe UPhysicsAsset ShadowPhysicsAsset
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPhysicsAsset>(base.NativePtr / (IntPtr)sizeof(void*) + USkeletalMesh.__PropertyOffset_ShadowPhysicsAsset);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + USkeletalMesh.__PropertyOffset_ShadowPhysicsAsset, value);
			}
		}

		// Token: 0x17000C44 RID: 3140
		// (get) Token: 0x0600424E RID: 16974 RVA: 0x0005EC3C File Offset: 0x0005CE3C
		// (set) Token: 0x0600424F RID: 16975 RVA: 0x0005EC75 File Offset: 0x0005CE75
		public FSoftObjectPath KuroMorphTargetsAssetPath
		{
			get
			{
				base.FastCheckIsValid();
				FSoftObjectPath result;
				if ((result = this._KuroMorphTargetsAssetPath) == null)
				{
					result = (this._KuroMorphTargetsAssetPath = new FSoftObjectPath(base.NativePtr + (IntPtr)USkeletalMesh.__PropertyOffset_KuroMorphTargetsAssetPath, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)USkeletalMesh.__PropertyOffset_KuroMorphTargetsAssetPath, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000C45 RID: 3141
		// (get) Token: 0x06004250 RID: 16976 RVA: 0x0005EC96 File Offset: 0x0005CE96
		// (set) Token: 0x06004251 RID: 16977 RVA: 0x0005ECAA File Offset: 0x0005CEAA
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UAnimInstance> PostProcessAnimBlueprint
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)USkeletalMesh.__PropertyOffset_PostProcessAnimBlueprint);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)USkeletalMesh.__PropertyOffset_PostProcessAnimBlueprint) = value;
			}
		}

		// Token: 0x06004252 RID: 16978 RVA: 0x0005ECBF File Offset: 0x0005CEBF
		public void UpdateUVChannelData(bool bResetOverrides)
		{
			USkeletalMesh.__UpdateUVChannelData_Internal(base.NativePtr, bResetOverrides);
		}

		// Token: 0x06004253 RID: 16979 RVA: 0x0005ECCD File Offset: 0x0005CECD
		public void SetPreviewMaterials([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<UMaterialInterface> InMaterials)
		{
			USkeletalMesh.__SetPreviewMaterials_Internal(base.NativePtr, (InMaterials ?? new TArray<UMaterialInterface>()).NativePtr);
		}

		// Token: 0x06004254 RID: 16980 RVA: 0x0005ECEA File Offset: 0x0005CEEA
		public void SetEnableBoneBounds(bool bEnable)
		{
			USkeletalMesh.__SetEnableBoneBounds_Internal(base.NativePtr, bEnable);
		}

		// Token: 0x06004255 RID: 16981 RVA: 0x0005ECF8 File Offset: 0x0005CEF8
		public void SetDefaultAnimatingRig(TSoftObjectPtr<UObject> InAnimatingRig)
		{
			USkeletalMesh.__SetDefaultAnimatingRig_Internal(base.NativePtr, (InAnimatingRig ?? new TSoftObjectPtr<UObject>()).NativePtr);
		}

		// Token: 0x06004256 RID: 16982 RVA: 0x0005ED14 File Offset: 0x0005CF14
		public void SetBoneBoundsApplyBounds(bool bApply)
		{
			USkeletalMesh.__SetBoneBoundsApplyBounds_Internal(base.NativePtr, bApply);
		}

		// Token: 0x06004257 RID: 16983 RVA: 0x0005ED22 File Offset: 0x0005CF22
		public void RemoveLODInfo(int Index)
		{
			USkeletalMesh.__RemoveLODInfo_Internal(base.NativePtr, Index);
		}

		// Token: 0x06004258 RID: 16984 RVA: 0x0005ED30 File Offset: 0x0005CF30
		public int NumSockets()
		{
			return USkeletalMesh.__NumSockets_Internal(base.NativePtr);
		}

		// Token: 0x06004259 RID: 16985 RVA: 0x0005ED3D File Offset: 0x0005CF3D
		public TArray<string> K2_GetAllMorphTargetNames()
		{
			return new TArray<string>(USkeletalMesh.__K2_GetAllMorphTargetNames_Internal(base.NativePtr), null);
		}

		// Token: 0x0600425A RID: 16986 RVA: 0x0005ED50 File Offset: 0x0005CF50
		public bool IsSectionUsingCloth(int InSectionIndex, bool bCheckCorrespondingSections = true)
		{
			return USkeletalMesh.__IsSectionUsingCloth_Internal(base.NativePtr, InSectionIndex, bCheckCorrespondingSections);
		}

		// Token: 0x0600425B RID: 16987 RVA: 0x0005ED5F File Offset: 0x0005CF5F
		public bool IsEnableBoneBounds()
		{
			return USkeletalMesh.__IsEnableBoneBounds_Internal(base.NativePtr);
		}

		// Token: 0x0600425C RID: 16988 RVA: 0x0005ED6C File Offset: 0x0005CF6C
		public unsafe bool IsContainSocket(string InSocketName)
		{
			FString fstring = FString.AllocTemp(InSocketName);
			bool result = USkeletalMesh.__IsContainSocket_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0600425D RID: 16989 RVA: 0x0005ED96 File Offset: 0x0005CF96
		public bool IsBoneBoundsApplyBounds()
		{
			return USkeletalMesh.__IsBoneBoundsApplyBounds_Internal(base.NativePtr);
		}

		// Token: 0x0600425E RID: 16990 RVA: 0x0005EDA3 File Offset: 0x0005CFA3
		public int GetRawBoneNum()
		{
			return USkeletalMesh.__GetRawBoneNum_Internal(base.NativePtr);
		}

		// Token: 0x0600425F RID: 16991 RVA: 0x0005EDB0 File Offset: 0x0005CFB0
		public TArray<UMaterialInterface> GetPreviewMaterials()
		{
			return new TArray<UMaterialInterface>(USkeletalMesh.__GetPreviewMaterials_Internal(base.NativePtr), null);
		}

		// Token: 0x06004260 RID: 16992 RVA: 0x0005EDC3 File Offset: 0x0005CFC3
		public int GetNumTexCoords()
		{
			return USkeletalMesh.__GetNumTexCoords_Internal(base.NativePtr);
		}

		// Token: 0x06004261 RID: 16993 RVA: 0x0005EDD0 File Offset: 0x0005CFD0
		public int GetNumSectionsAtLODIndex(int LODIndex)
		{
			return USkeletalMesh.__GetNumSectionsAtLODIndex_Internal(base.NativePtr, LODIndex);
		}

		// Token: 0x06004262 RID: 16994 RVA: 0x0005EDDE File Offset: 0x0005CFDE
		public int GetNumSections()
		{
			return USkeletalMesh.__GetNumSections_Internal(base.NativePtr);
		}

		// Token: 0x06004263 RID: 16995 RVA: 0x0005EDEB File Offset: 0x0005CFEB
		public int GetLODNum()
		{
			return USkeletalMesh.__GetLODNum_Internal(base.NativePtr);
		}

		// Token: 0x06004264 RID: 16996 RVA: 0x0005EDF8 File Offset: 0x0005CFF8
		public FBoxSphereBounds GetImportedBounds()
		{
			return USkeletalMesh.__GetImportedBounds_Internal(base.NativePtr);
		}

		// Token: 0x06004265 RID: 16997 RVA: 0x0005EE05 File Offset: 0x0005D005
		public TSoftObjectPtr<UObject> GetDefaultAnimatingRig()
		{
			return new TSoftObjectPtr<UObject>(USkeletalMesh.__GetDefaultAnimatingRig_Internal(base.NativePtr), true, true);
		}

		// Token: 0x06004266 RID: 16998 RVA: 0x0005EE19 File Offset: 0x0005D019
		public FBoxSphereBounds GetBounds()
		{
			return USkeletalMesh.__GetBounds_Internal(base.NativePtr);
		}

		// Token: 0x06004267 RID: 16999 RVA: 0x0005EE26 File Offset: 0x0005D026
		public float GetBoneBoundsExtension()
		{
			return USkeletalMesh.__GetBoneBoundsExtension_Internal(base.NativePtr);
		}

		// Token: 0x06004268 RID: 17000
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateUVChannelData_Internal(IntPtr @this, bool bResetOverrides);

		// Token: 0x06004269 RID: 17001
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPreviewMaterials_Internal(IntPtr @this, IntPtr InMaterials);

		// Token: 0x0600426A RID: 17002
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetEnableBoneBounds_Internal(IntPtr @this, bool bEnable);

		// Token: 0x0600426B RID: 17003
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDefaultAnimatingRig_Internal(IntPtr @this, IntPtr InAnimatingRig);

		// Token: 0x0600426C RID: 17004
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBoneBoundsApplyBounds_Internal(IntPtr @this, bool bApply);

		// Token: 0x0600426D RID: 17005
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveLODInfo_Internal(IntPtr @this, int Index);

		// Token: 0x0600426E RID: 17006
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __NumSockets_Internal(IntPtr @this);

		// Token: 0x0600426F RID: 17007
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __K2_GetAllMorphTargetNames_Internal(IntPtr @this);

		// Token: 0x06004270 RID: 17008
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsSectionUsingCloth_Internal(IntPtr @this, int InSectionIndex, bool bCheckCorrespondingSections);

		// Token: 0x06004271 RID: 17009
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsEnableBoneBounds_Internal(IntPtr @this);

		// Token: 0x06004272 RID: 17010
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsContainSocket_Internal(IntPtr @this, in FString InSocketName);

		// Token: 0x06004273 RID: 17011
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsBoneBoundsApplyBounds_Internal(IntPtr @this);

		// Token: 0x06004274 RID: 17012
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetRawBoneNum_Internal(IntPtr @this);

		// Token: 0x06004275 RID: 17013
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetPreviewMaterials_Internal(IntPtr @this);

		// Token: 0x06004276 RID: 17014
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetNumTexCoords_Internal(IntPtr @this);

		// Token: 0x06004277 RID: 17015
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetNumSectionsAtLODIndex_Internal(IntPtr @this, int LODIndex);

		// Token: 0x06004278 RID: 17016
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetNumSections_Internal(IntPtr @this);

		// Token: 0x06004279 RID: 17017
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetLODNum_Internal(IntPtr @this);

		// Token: 0x0600427A RID: 17018
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FBoxSphereBounds __GetImportedBounds_Internal(IntPtr @this);

		// Token: 0x0600427B RID: 17019
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetDefaultAnimatingRig_Internal(IntPtr @this);

		// Token: 0x0600427C RID: 17020
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FBoxSphereBounds __GetBounds_Internal(IntPtr @this);

		// Token: 0x0600427D RID: 17021
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetBoneBoundsExtension_Internal(IntPtr @this);

		// Token: 0x0600427E RID: 17022 RVA: 0x0005EE33 File Offset: 0x0005D033
		static USkeletalMesh()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.SkeletalMesh");
		}

		// Token: 0x0600427F RID: 17023 RVA: 0x0005EE41 File Offset: 0x0005D041
		protected USkeletalMesh(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040019D5 RID: 6613
		public new const string __ObjectPath = "/Script/Engine.SkeletalMesh";

		// Token: 0x040019D6 RID: 6614
		private static IntPtr _ClassPtr;

		// Token: 0x040019D7 RID: 6615
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040019D8 RID: 6616
		internal static int __PropertyOffset_Skeleton;

		// Token: 0x040019D9 RID: 6617
		internal static int __PropertyOffset_bEnableBoneFold;

		// Token: 0x040019DA RID: 6618
		internal static int __PropertyOffset_UseKneeTransparency;

		// Token: 0x040019DB RID: 6619
		internal static int __PropertyOffset_UseCustomBonePosition;

		// Token: 0x040019DC RID: 6620
		internal static int __PropertyOffset_CustomBoneNamesIndices;

		// Token: 0x040019DD RID: 6621
		[Nullable(2)]
		private TMap<FName, int> _CustomBoneNamesIndices;

		// Token: 0x040019DE RID: 6622
		internal static int __PropertyOffset_HeadBoneName;

		// Token: 0x040019DF RID: 6623
		internal static int __PropertyOffset_LODBoneFoldMapping;

		// Token: 0x040019E0 RID: 6624
		[Nullable(2)]
		private TArray<int> _LODBoneFoldMapping;

		// Token: 0x040019E1 RID: 6625
		internal static int __PropertyOffset_ImportedBounds;

		// Token: 0x040019E2 RID: 6626
		internal static int __PropertyOffset_ExtendedBounds;

		// Token: 0x040019E3 RID: 6627
		internal static int __PropertyOffset_ImportedBoundsScale;

		// Token: 0x040019E4 RID: 6628
		internal static int __PropertyOffset_PositiveBoundsExtension;

		// Token: 0x040019E5 RID: 6629
		internal static int __PropertyOffset_NegativeBoundsExtension;

		// Token: 0x040019E6 RID: 6630
		internal static int __PropertyOffset_bEnableBoneBounds;

		// Token: 0x040019E7 RID: 6631
		internal static int __PropertyOffset_BoneBoundsExtension;

		// Token: 0x040019E8 RID: 6632
		internal static int __PropertyOffset_bBoneBoundsApplyBounds;

		// Token: 0x040019E9 RID: 6633
		internal static int __PropertyOffset_bSkipCullVelocity;

		// Token: 0x040019EA RID: 6634
		internal static int __PropertyOffset_bForceUseExpandedTexcoords;

		// Token: 0x040019EB RID: 6635
		internal static int __PropertyOffset_NumSectionsBeforeCook;

		// Token: 0x040019EC RID: 6636
		internal static int __PropertyOffset_NumSectionsAfterCooked;

		// Token: 0x040019ED RID: 6637
		internal static int __PropertyOffset_Materials;

		// Token: 0x040019EE RID: 6638
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSkeletalMaterial> _Materials;

		// Token: 0x040019EF RID: 6639
		internal static int __PropertyOffset_ScreenSizeCullRatio;

		// Token: 0x040019F0 RID: 6640
		internal static int __PropertyOffset_bUseKuroLODDistance;

		// Token: 0x040019F1 RID: 6641
		internal static int __PropertyOffset_SkelMirrorAxis;

		// Token: 0x040019F2 RID: 6642
		internal static int __PropertyOffset_SkelMirrorFlipAxis;

		// Token: 0x040019F3 RID: 6643
		internal static int __PropertyOffset_bUseFullPrecisionUVs_DEPRECATED;

		// Token: 0x040019F4 RID: 6644
		internal static byte __PropertyMask_bUseFullPrecisionUVs_DEPRECATED;

		// Token: 0x040019F5 RID: 6645
		internal static int __PropertyOffset_bUseHighPrecisionTangentBasis_DEPRECATED;

		// Token: 0x040019F6 RID: 6646
		internal static byte __PropertyMask_bUseHighPrecisionTangentBasis_DEPRECATED;

		// Token: 0x040019F7 RID: 6647
		internal static int __PropertyOffset_bHasBeenSimplified;

		// Token: 0x040019F8 RID: 6648
		internal static byte __PropertyMask_bHasBeenSimplified;

		// Token: 0x040019F9 RID: 6649
		internal static int __PropertyOffset_bHasVertexColors;

		// Token: 0x040019FA RID: 6650
		internal static byte __PropertyMask_bHasVertexColors;

		// Token: 0x040019FB RID: 6651
		internal static int __PropertyOffset_bEnablePerPolyCollision;

		// Token: 0x040019FC RID: 6652
		internal static byte __PropertyMask_bEnablePerPolyCollision;

		// Token: 0x040019FD RID: 6653
		internal static int __PropertyOffset_BodySetup;

		// Token: 0x040019FE RID: 6654
		internal static int __PropertyOffset_PhysicsAsset;

		// Token: 0x040019FF RID: 6655
		internal static int __PropertyOffset_ShadowPhysicsAsset;

		// Token: 0x04001A00 RID: 6656
		internal static int __PropertyOffset_KuroMorphTargetsAssetPath;

		// Token: 0x04001A01 RID: 6657
		[Nullable(2)]
		private FSoftObjectPath _KuroMorphTargetsAssetPath;

		// Token: 0x04001A02 RID: 6658
		internal static int __PropertyOffset_PostProcessAnimBlueprint;
	}
}
