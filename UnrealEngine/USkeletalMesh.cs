using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020010F3 RID: 4339
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.SkeletalMesh")]
	[UnrealStructLayout(4928, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 4928)]
	public class USkeletalMesh : UStreamableRenderAsset, IUnrealUObject, IUnrealObject, IInterface_CollisionDataProvider, IUnrealNativeInterface, IUnrealInterface, IInterface_AssetUserData, INodeMappingProviderInterface
	{
		// Token: 0x0600F8E2 RID: 63714 RVA: 0x00170172 File Offset: 0x0016E372
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USkeletalMesh._ClassPtr;
		}

		// Token: 0x0600F8E3 RID: 63715 RVA: 0x0017017E File Offset: 0x0016E37E
		int IInterface_CollisionDataProvider.InterfaceOffset()
		{
			return USkeletalMesh.__InterfaceOffset_IInterface_CollisionDataProvider;
		}

		// Token: 0x0600F8E4 RID: 63716 RVA: 0x00170185 File Offset: 0x0016E385
		int IInterface_AssetUserData.InterfaceOffset()
		{
			return USkeletalMesh.__InterfaceOffset_IInterface_AssetUserData;
		}

		// Token: 0x0600F8E5 RID: 63717 RVA: 0x0017018C File Offset: 0x0016E38C
		int INodeMappingProviderInterface.InterfaceOffset()
		{
			return USkeletalMesh.__InterfaceOffset_INodeMappingProviderInterface;
		}

		// Token: 0x0600F8E6 RID: 63718 RVA: 0x00170194 File Offset: 0x0016E394
		public USkeletalMesh() : this(BuiltinUtils.AllocNativeUObject(USkeletalMesh.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600F8E7 RID: 63719 RVA: 0x001701BC File Offset: 0x0016E3BC
		public USkeletalMesh(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USkeletalMesh.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003C9C RID: 15516
		// (get) Token: 0x0600F8E8 RID: 63720 RVA: 0x001701EF File Offset: 0x0016E3EF
		// (set) Token: 0x0600F8E9 RID: 63721 RVA: 0x00170203 File Offset: 0x0016E403
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

		// Token: 0x17003C9D RID: 15517
		// (get) Token: 0x0600F8EA RID: 63722 RVA: 0x00170218 File Offset: 0x0016E418
		// (set) Token: 0x0600F8EB RID: 63723 RVA: 0x00170228 File Offset: 0x0016E428
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

		// Token: 0x17003C9E RID: 15518
		// (get) Token: 0x0600F8EC RID: 63724 RVA: 0x00170239 File Offset: 0x0016E439
		// (set) Token: 0x0600F8ED RID: 63725 RVA: 0x00170249 File Offset: 0x0016E449
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

		// Token: 0x17003C9F RID: 15519
		// (get) Token: 0x0600F8EE RID: 63726 RVA: 0x0017025C File Offset: 0x0016E45C
		// (set) Token: 0x0600F8EF RID: 63727 RVA: 0x00170295 File Offset: 0x0016E495
		public FLeftKneeBoneNames LeftKneeBoneNames
		{
			get
			{
				base.FastCheckIsValid();
				FLeftKneeBoneNames result;
				if ((result = this._LeftKneeBoneNames) == null)
				{
					result = (this._LeftKneeBoneNames = new FLeftKneeBoneNames(base.NativePtr + (IntPtr)USkeletalMesh.__PropertyOffset_LeftKneeBoneNames, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FLeftKneeBoneNames.StaticStruct(), base.NativePtr + (IntPtr)USkeletalMesh.__PropertyOffset_LeftKneeBoneNames, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003CA0 RID: 15520
		// (get) Token: 0x0600F8F0 RID: 63728 RVA: 0x001702B8 File Offset: 0x0016E4B8
		// (set) Token: 0x0600F8F1 RID: 63729 RVA: 0x001702F1 File Offset: 0x0016E4F1
		public FRightKneeBoneNames RightKneeBoneNames
		{
			get
			{
				base.FastCheckIsValid();
				FRightKneeBoneNames result;
				if ((result = this._RightKneeBoneNames) == null)
				{
					result = (this._RightKneeBoneNames = new FRightKneeBoneNames(base.NativePtr + (IntPtr)USkeletalMesh.__PropertyOffset_RightKneeBoneNames, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRightKneeBoneNames.StaticStruct(), base.NativePtr + (IntPtr)USkeletalMesh.__PropertyOffset_RightKneeBoneNames, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003CA1 RID: 15521
		// (get) Token: 0x0600F8F2 RID: 63730 RVA: 0x00170312 File Offset: 0x0016E512
		// (set) Token: 0x0600F8F3 RID: 63731 RVA: 0x00170322 File Offset: 0x0016E522
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

		// Token: 0x17003CA2 RID: 15522
		// (get) Token: 0x0600F8F4 RID: 63732 RVA: 0x00170334 File Offset: 0x0016E534
		// (set) Token: 0x0600F8F5 RID: 63733 RVA: 0x0017036D File Offset: 0x0016E56D
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

		// Token: 0x17003CA3 RID: 15523
		// (get) Token: 0x0600F8F6 RID: 63734 RVA: 0x0017037B File Offset: 0x0016E57B
		// (set) Token: 0x0600F8F7 RID: 63735 RVA: 0x0017038F File Offset: 0x0016E58F
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

		// Token: 0x17003CA4 RID: 15524
		// (get) Token: 0x0600F8F8 RID: 63736 RVA: 0x001703A4 File Offset: 0x0016E5A4
		// (set) Token: 0x0600F8F9 RID: 63737 RVA: 0x001703B4 File Offset: 0x0016E5B4
		public unsafe ESkeletalMeshForcePreviousBoneUpateMode ForcePreviousBoneUpdateMode
		{
			get
			{
				return (ESkeletalMeshForcePreviousBoneUpateMode)(*(base.NativePtr + (IntPtr)USkeletalMesh.__PropertyOffset_ForcePreviousBoneUpdateMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkeletalMesh.__PropertyOffset_ForcePreviousBoneUpdateMode) = (byte)value;
			}
		}

		// Token: 0x17003CA5 RID: 15525
		// (get) Token: 0x0600F8FA RID: 63738 RVA: 0x001703C8 File Offset: 0x0016E5C8
		// (set) Token: 0x0600F8FB RID: 63739 RVA: 0x00170401 File Offset: 0x0016E601
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

		// Token: 0x17003CA6 RID: 15526
		// (get) Token: 0x0600F8FC RID: 63740 RVA: 0x0017040F File Offset: 0x0016E60F
		// (set) Token: 0x0600F8FD RID: 63741 RVA: 0x00170423 File Offset: 0x0016E623
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

		// Token: 0x17003CA7 RID: 15527
		// (get) Token: 0x0600F8FE RID: 63742 RVA: 0x00170438 File Offset: 0x0016E638
		// (set) Token: 0x0600F8FF RID: 63743 RVA: 0x0017044C File Offset: 0x0016E64C
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

		// Token: 0x17003CA8 RID: 15528
		// (get) Token: 0x0600F900 RID: 63744 RVA: 0x00170461 File Offset: 0x0016E661
		// (set) Token: 0x0600F901 RID: 63745 RVA: 0x00170471 File Offset: 0x0016E671
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

		// Token: 0x17003CA9 RID: 15529
		// (get) Token: 0x0600F902 RID: 63746 RVA: 0x00170482 File Offset: 0x0016E682
		// (set) Token: 0x0600F903 RID: 63747 RVA: 0x00170496 File Offset: 0x0016E696
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

		// Token: 0x17003CAA RID: 15530
		// (get) Token: 0x0600F904 RID: 63748 RVA: 0x001704AB File Offset: 0x0016E6AB
		// (set) Token: 0x0600F905 RID: 63749 RVA: 0x001704BF File Offset: 0x0016E6BF
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

		// Token: 0x17003CAB RID: 15531
		// (get) Token: 0x0600F906 RID: 63750 RVA: 0x001704D4 File Offset: 0x0016E6D4
		// (set) Token: 0x0600F907 RID: 63751 RVA: 0x001704E4 File Offset: 0x0016E6E4
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

		// Token: 0x17003CAC RID: 15532
		// (get) Token: 0x0600F908 RID: 63752 RVA: 0x001704F5 File Offset: 0x0016E6F5
		// (set) Token: 0x0600F909 RID: 63753 RVA: 0x00170505 File Offset: 0x0016E705
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

		// Token: 0x17003CAD RID: 15533
		// (get) Token: 0x0600F90A RID: 63754 RVA: 0x00170516 File Offset: 0x0016E716
		// (set) Token: 0x0600F90B RID: 63755 RVA: 0x00170526 File Offset: 0x0016E726
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

		// Token: 0x17003CAE RID: 15534
		// (get) Token: 0x0600F90C RID: 63756 RVA: 0x00170537 File Offset: 0x0016E737
		// (set) Token: 0x0600F90D RID: 63757 RVA: 0x00170547 File Offset: 0x0016E747
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

		// Token: 0x17003CAF RID: 15535
		// (get) Token: 0x0600F90E RID: 63758 RVA: 0x00170558 File Offset: 0x0016E758
		// (set) Token: 0x0600F90F RID: 63759 RVA: 0x00170568 File Offset: 0x0016E768
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

		// Token: 0x17003CB0 RID: 15536
		// (get) Token: 0x0600F910 RID: 63760 RVA: 0x00170579 File Offset: 0x0016E779
		// (set) Token: 0x0600F911 RID: 63761 RVA: 0x00170589 File Offset: 0x0016E789
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

		// Token: 0x17003CB1 RID: 15537
		// (get) Token: 0x0600F912 RID: 63762 RVA: 0x0017059A File Offset: 0x0016E79A
		// (set) Token: 0x0600F913 RID: 63763 RVA: 0x001705AA File Offset: 0x0016E7AA
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

		// Token: 0x17003CB2 RID: 15538
		// (get) Token: 0x0600F914 RID: 63764 RVA: 0x001705BC File Offset: 0x0016E7BC
		// (set) Token: 0x0600F915 RID: 63765 RVA: 0x001705F5 File Offset: 0x0016E7F5
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

		// Token: 0x17003CB3 RID: 15539
		// (get) Token: 0x0600F916 RID: 63766 RVA: 0x00170604 File Offset: 0x0016E804
		// (set) Token: 0x0600F917 RID: 63767 RVA: 0x0017063D File Offset: 0x0016E83D
		public TArray<FBoneMirrorInfo> SkelMirrorTable
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FBoneMirrorInfo> result;
				if ((result = this._SkelMirrorTable) == null)
				{
					result = (this._SkelMirrorTable = new TArray<FBoneMirrorInfo>(base.NativePtr + (IntPtr)USkeletalMesh.__PropertyOffset_SkelMirrorTable, this));
				}
				return result;
			}
			set
			{
				this.SkelMirrorTable.CopyAssign(value);
			}
		}

		// Token: 0x17003CB4 RID: 15540
		// (get) Token: 0x0600F918 RID: 63768 RVA: 0x0017064C File Offset: 0x0016E84C
		// (set) Token: 0x0600F919 RID: 63769 RVA: 0x00170685 File Offset: 0x0016E885
		public TArray<FSkeletalMeshLODInfo> LODInfo
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FSkeletalMeshLODInfo> result;
				if ((result = this._LODInfo) == null)
				{
					result = (this._LODInfo = new TArray<FSkeletalMeshLODInfo>(base.NativePtr + (IntPtr)USkeletalMesh.__PropertyOffset_LODInfo, this));
				}
				return result;
			}
			set
			{
				this.LODInfo.CopyAssign(value);
			}
		}

		// Token: 0x17003CB5 RID: 15541
		// (get) Token: 0x0600F91A RID: 63770 RVA: 0x00170694 File Offset: 0x0016E894
		// (set) Token: 0x0600F91B RID: 63771 RVA: 0x001706CD File Offset: 0x0016E8CD
		public FPerPlatformInt MinLod
		{
			get
			{
				base.FastCheckIsValid();
				FPerPlatformInt result;
				if ((result = this._MinLod) == null)
				{
					result = (this._MinLod = new FPerPlatformInt(base.NativePtr + (IntPtr)USkeletalMesh.__PropertyOffset_MinLod, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPerPlatformInt.StaticStruct(), base.NativePtr + (IntPtr)USkeletalMesh.__PropertyOffset_MinLod, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003CB6 RID: 15542
		// (get) Token: 0x0600F91C RID: 63772 RVA: 0x001706F0 File Offset: 0x0016E8F0
		// (set) Token: 0x0600F91D RID: 63773 RVA: 0x00170729 File Offset: 0x0016E929
		public FPerPlatformInt MaxLod
		{
			get
			{
				base.FastCheckIsValid();
				FPerPlatformInt result;
				if ((result = this._MaxLod) == null)
				{
					result = (this._MaxLod = new FPerPlatformInt(base.NativePtr + (IntPtr)USkeletalMesh.__PropertyOffset_MaxLod, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPerPlatformInt.StaticStruct(), base.NativePtr + (IntPtr)USkeletalMesh.__PropertyOffset_MaxLod, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003CB7 RID: 15543
		// (get) Token: 0x0600F91E RID: 63774 RVA: 0x0017074C File Offset: 0x0016E94C
		// (set) Token: 0x0600F91F RID: 63775 RVA: 0x00170785 File Offset: 0x0016E985
		public FPerPlatformInt MaxOutlineLod
		{
			get
			{
				base.FastCheckIsValid();
				FPerPlatformInt result;
				if ((result = this._MaxOutlineLod) == null)
				{
					result = (this._MaxOutlineLod = new FPerPlatformInt(base.NativePtr + (IntPtr)USkeletalMesh.__PropertyOffset_MaxOutlineLod, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPerPlatformInt.StaticStruct(), base.NativePtr + (IntPtr)USkeletalMesh.__PropertyOffset_MaxOutlineLod, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003CB8 RID: 15544
		// (get) Token: 0x0600F920 RID: 63776 RVA: 0x001707A6 File Offset: 0x0016E9A6
		// (set) Token: 0x0600F921 RID: 63777 RVA: 0x001707B6 File Offset: 0x0016E9B6
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

		// Token: 0x17003CB9 RID: 15545
		// (get) Token: 0x0600F922 RID: 63778 RVA: 0x001707C8 File Offset: 0x0016E9C8
		// (set) Token: 0x0600F923 RID: 63779 RVA: 0x00170801 File Offset: 0x0016EA01
		public FPerPlatformBool DisableBelowMinLodStripping
		{
			get
			{
				base.FastCheckIsValid();
				FPerPlatformBool result;
				if ((result = this._DisableBelowMinLodStripping) == null)
				{
					result = (this._DisableBelowMinLodStripping = new FPerPlatformBool(base.NativePtr + (IntPtr)USkeletalMesh.__PropertyOffset_DisableBelowMinLodStripping, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPerPlatformBool.StaticStruct(), base.NativePtr + (IntPtr)USkeletalMesh.__PropertyOffset_DisableBelowMinLodStripping, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003CBA RID: 15546
		// (get) Token: 0x0600F924 RID: 63780 RVA: 0x00170822 File Offset: 0x0016EA22
		// (set) Token: 0x0600F925 RID: 63781 RVA: 0x00170832 File Offset: 0x0016EA32
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

		// Token: 0x17003CBB RID: 15547
		// (get) Token: 0x0600F926 RID: 63782 RVA: 0x00170843 File Offset: 0x0016EA43
		// (set) Token: 0x0600F927 RID: 63783 RVA: 0x00170857 File Offset: 0x0016EA57
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

		// Token: 0x17003CBC RID: 15548
		// (get) Token: 0x0600F928 RID: 63784 RVA: 0x0017086C File Offset: 0x0016EA6C
		// (set) Token: 0x0600F929 RID: 63785 RVA: 0x00170880 File Offset: 0x0016EA80
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

		// Token: 0x17003CBD RID: 15549
		// (get) Token: 0x0600F92A RID: 63786 RVA: 0x00170895 File Offset: 0x0016EA95
		// (set) Token: 0x0600F92B RID: 63787 RVA: 0x001708AE File Offset: 0x0016EAAE
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

		// Token: 0x17003CBE RID: 15550
		// (get) Token: 0x0600F92C RID: 63788 RVA: 0x001708DE File Offset: 0x0016EADE
		// (set) Token: 0x0600F92D RID: 63789 RVA: 0x001708F7 File Offset: 0x0016EAF7
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

		// Token: 0x17003CBF RID: 15551
		// (get) Token: 0x0600F92E RID: 63790 RVA: 0x00170927 File Offset: 0x0016EB27
		// (set) Token: 0x0600F92F RID: 63791 RVA: 0x00170940 File Offset: 0x0016EB40
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

		// Token: 0x17003CC0 RID: 15552
		// (get) Token: 0x0600F930 RID: 63792 RVA: 0x00170970 File Offset: 0x0016EB70
		// (set) Token: 0x0600F931 RID: 63793 RVA: 0x00170989 File Offset: 0x0016EB89
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

		// Token: 0x17003CC1 RID: 15553
		// (get) Token: 0x0600F932 RID: 63794 RVA: 0x001709B9 File Offset: 0x0016EBB9
		// (set) Token: 0x0600F933 RID: 63795 RVA: 0x001709D2 File Offset: 0x0016EBD2
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

		// Token: 0x17003CC2 RID: 15554
		// (get) Token: 0x0600F934 RID: 63796 RVA: 0x00170A02 File Offset: 0x0016EC02
		// (set) Token: 0x0600F935 RID: 63797 RVA: 0x00170A16 File Offset: 0x0016EC16
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

		// Token: 0x17003CC3 RID: 15555
		// (get) Token: 0x0600F936 RID: 63798 RVA: 0x00170A2B File Offset: 0x0016EC2B
		// (set) Token: 0x0600F937 RID: 63799 RVA: 0x00170A3F File Offset: 0x0016EC3F
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

		// Token: 0x17003CC4 RID: 15556
		// (get) Token: 0x0600F938 RID: 63800 RVA: 0x00170A54 File Offset: 0x0016EC54
		// (set) Token: 0x0600F939 RID: 63801 RVA: 0x00170A68 File Offset: 0x0016EC68
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

		// Token: 0x17003CC5 RID: 15557
		// (get) Token: 0x0600F93A RID: 63802 RVA: 0x00170A80 File Offset: 0x0016EC80
		// (set) Token: 0x0600F93B RID: 63803 RVA: 0x00170AB9 File Offset: 0x0016ECB9
		public TArray<UKuroMaterialVariationCollection> KuroMaterialVariationAssets
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UKuroMaterialVariationCollection> result;
				if ((result = this._KuroMaterialVariationAssets) == null)
				{
					result = (this._KuroMaterialVariationAssets = new TArray<UKuroMaterialVariationCollection>(base.NativePtr + (IntPtr)USkeletalMesh.__PropertyOffset_KuroMaterialVariationAssets, this));
				}
				return result;
			}
			set
			{
				this.KuroMaterialVariationAssets.CopyAssign(value);
			}
		}

		// Token: 0x17003CC6 RID: 15558
		// (get) Token: 0x0600F93C RID: 63804 RVA: 0x00170AC7 File Offset: 0x0016ECC7
		// (set) Token: 0x0600F93D RID: 63805 RVA: 0x00170ADB File Offset: 0x0016ECDB
		[Nullable(2)]
		public unsafe UKuroMaterialVariationData KuroMaterialVariationData
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroMaterialVariationData>(base.NativePtr / (IntPtr)sizeof(void*) + USkeletalMesh.__PropertyOffset_KuroMaterialVariationData);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + USkeletalMesh.__PropertyOffset_KuroMaterialVariationData, value);
			}
		}

		// Token: 0x17003CC7 RID: 15559
		// (get) Token: 0x0600F93E RID: 63806 RVA: 0x00170AF0 File Offset: 0x0016ECF0
		// (set) Token: 0x0600F93F RID: 63807 RVA: 0x00170B29 File Offset: 0x0016ED29
		public TArray<UNodeMappingContainer> NodeMappingData
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UNodeMappingContainer> result;
				if ((result = this._NodeMappingData) == null)
				{
					result = (this._NodeMappingData = new TArray<UNodeMappingContainer>(base.NativePtr + (IntPtr)USkeletalMesh.__PropertyOffset_NodeMappingData, this));
				}
				return result;
			}
			set
			{
				this.NodeMappingData.CopyAssign(value);
			}
		}

		// Token: 0x17003CC8 RID: 15560
		// (get) Token: 0x0600F940 RID: 63808 RVA: 0x00170B38 File Offset: 0x0016ED38
		// (set) Token: 0x0600F941 RID: 63809 RVA: 0x00170B71 File Offset: 0x0016ED71
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

		// Token: 0x17003CC9 RID: 15561
		// (get) Token: 0x0600F942 RID: 63810 RVA: 0x00170B92 File Offset: 0x0016ED92
		// (set) Token: 0x0600F943 RID: 63811 RVA: 0x00170BA6 File Offset: 0x0016EDA6
		[Nullable(2)]
		public unsafe UMorphTargetsAsset KuroMorphTargetsAsset
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMorphTargetsAsset>(base.NativePtr / (IntPtr)sizeof(void*) + USkeletalMesh.__PropertyOffset_KuroMorphTargetsAsset);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + USkeletalMesh.__PropertyOffset_KuroMorphTargetsAsset, value);
			}
		}

		// Token: 0x17003CCA RID: 15562
		// (get) Token: 0x0600F944 RID: 63812 RVA: 0x00170BBC File Offset: 0x0016EDBC
		// (set) Token: 0x0600F945 RID: 63813 RVA: 0x00170BF5 File Offset: 0x0016EDF5
		public TArray<UMorphTarget> MorphTargets
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMorphTarget> result;
				if ((result = this._MorphTargets) == null)
				{
					result = (this._MorphTargets = new TArray<UMorphTarget>(base.NativePtr + (IntPtr)USkeletalMesh.__PropertyOffset_MorphTargets, this));
				}
				return result;
			}
			set
			{
				this.MorphTargets.CopyAssign(value);
			}
		}

		// Token: 0x17003CCB RID: 15563
		// (get) Token: 0x0600F946 RID: 63814 RVA: 0x00170C03 File Offset: 0x0016EE03
		// (set) Token: 0x0600F947 RID: 63815 RVA: 0x00170C17 File Offset: 0x0016EE17
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

		// Token: 0x17003CCC RID: 15564
		// (get) Token: 0x0600F948 RID: 63816 RVA: 0x00170C2C File Offset: 0x0016EE2C
		// (set) Token: 0x0600F949 RID: 63817 RVA: 0x00170C65 File Offset: 0x0016EE65
		public TArray<UClothingAssetBase> MeshClothingAssets
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UClothingAssetBase> result;
				if ((result = this._MeshClothingAssets) == null)
				{
					result = (this._MeshClothingAssets = new TArray<UClothingAssetBase>(base.NativePtr + (IntPtr)USkeletalMesh.__PropertyOffset_MeshClothingAssets, this));
				}
				return result;
			}
			set
			{
				this.MeshClothingAssets.CopyAssign(value);
			}
		}

		// Token: 0x17003CCD RID: 15565
		// (get) Token: 0x0600F94A RID: 63818 RVA: 0x00170C74 File Offset: 0x0016EE74
		// (set) Token: 0x0600F94B RID: 63819 RVA: 0x00170CAD File Offset: 0x0016EEAD
		public FSkeletalMeshSamplingInfo SamplingInfo
		{
			get
			{
				base.FastCheckIsValid();
				FSkeletalMeshSamplingInfo result;
				if ((result = this._SamplingInfo) == null)
				{
					result = (this._SamplingInfo = new FSkeletalMeshSamplingInfo(base.NativePtr + (IntPtr)USkeletalMesh.__PropertyOffset_SamplingInfo, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSkeletalMeshSamplingInfo.StaticStruct(), base.NativePtr + (IntPtr)USkeletalMesh.__PropertyOffset_SamplingInfo, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003CCE RID: 15566
		// (get) Token: 0x0600F94C RID: 63820 RVA: 0x00170CD0 File Offset: 0x0016EED0
		// (set) Token: 0x0600F94D RID: 63821 RVA: 0x00170D09 File Offset: 0x0016EF09
		public TArray<UAssetUserData> AssetUserData
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UAssetUserData> result;
				if ((result = this._AssetUserData) == null)
				{
					result = (this._AssetUserData = new TArray<UAssetUserData>(base.NativePtr + (IntPtr)USkeletalMesh.__PropertyOffset_AssetUserData, this));
				}
				return result;
			}
			set
			{
				this.AssetUserData.CopyAssign(value);
			}
		}

		// Token: 0x17003CCF RID: 15567
		// (get) Token: 0x0600F94E RID: 63822 RVA: 0x00170D18 File Offset: 0x0016EF18
		// (set) Token: 0x0600F94F RID: 63823 RVA: 0x00170D51 File Offset: 0x0016EF51
		public TArray<USkeletalMeshSocket> Sockets
		{
			get
			{
				base.FastCheckIsValid();
				TArray<USkeletalMeshSocket> result;
				if ((result = this._Sockets) == null)
				{
					result = (this._Sockets = new TArray<USkeletalMeshSocket>(base.NativePtr + (IntPtr)USkeletalMesh.__PropertyOffset_Sockets, this));
				}
				return result;
			}
			set
			{
				this.Sockets.CopyAssign(value);
			}
		}

		// Token: 0x17003CD0 RID: 15568
		// (get) Token: 0x0600F950 RID: 63824 RVA: 0x00170D60 File Offset: 0x0016EF60
		// (set) Token: 0x0600F951 RID: 63825 RVA: 0x00170D99 File Offset: 0x0016EF99
		public TArray<FSkinWeightProfileInfo> SkinWeightProfiles
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FSkinWeightProfileInfo> result;
				if ((result = this._SkinWeightProfiles) == null)
				{
					result = (this._SkinWeightProfiles = new TArray<FSkinWeightProfileInfo>(base.NativePtr + (IntPtr)USkeletalMesh.__PropertyOffset_SkinWeightProfiles, this));
				}
				return result;
			}
			set
			{
				this.SkinWeightProfiles.CopyAssign(value);
			}
		}

		// Token: 0x0600F952 RID: 63826 RVA: 0x00170DA7 File Offset: 0x0016EFA7
		public void UpdateUVChannelData(bool bResetOverrides)
		{
			USkeletalMesh.__UpdateUVChannelData_Internal(base.NativePtr, bResetOverrides);
		}

		// Token: 0x0600F953 RID: 63827 RVA: 0x00170DB5 File Offset: 0x0016EFB5
		public void SetPreviewMaterials([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<UMaterialInterface> InMaterials)
		{
			USkeletalMesh.__SetPreviewMaterials_Internal(base.NativePtr, (InMaterials ?? new TArray<UMaterialInterface>()).NativePtr);
		}

		// Token: 0x0600F954 RID: 63828 RVA: 0x00170DD2 File Offset: 0x0016EFD2
		[NullableContext(2)]
		public void SetLODSettings(USkeletalMeshLODSettings InLODSettings)
		{
			USkeletalMesh.__SetLODSettings_Internal(base.NativePtr, (InLODSettings != null) ? InLODSettings.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600F955 RID: 63829 RVA: 0x00170DEF File Offset: 0x0016EFEF
		public void SetEnableBoneBounds(bool bEnable)
		{
			USkeletalMesh.__SetEnableBoneBounds_Internal(base.NativePtr, bEnable);
		}

		// Token: 0x0600F956 RID: 63830 RVA: 0x00170DFD File Offset: 0x0016EFFD
		public void SetDefaultAnimatingRig(TSoftObjectPtr<UObject> InAnimatingRig)
		{
			USkeletalMesh.__SetDefaultAnimatingRig_Internal(base.NativePtr, (InAnimatingRig ?? new TSoftObjectPtr<UObject>()).NativePtr);
		}

		// Token: 0x0600F957 RID: 63831 RVA: 0x00170E19 File Offset: 0x0016F019
		public void SetBoneBoundsApplyBounds(bool bApply)
		{
			USkeletalMesh.__SetBoneBoundsApplyBounds_Internal(base.NativePtr, bApply);
		}

		// Token: 0x0600F958 RID: 63832 RVA: 0x00170E27 File Offset: 0x0016F027
		public void RemoveLODInfo(int Index)
		{
			USkeletalMesh.__RemoveLODInfo_Internal(base.NativePtr, Index);
		}

		// Token: 0x0600F959 RID: 63833 RVA: 0x00170E35 File Offset: 0x0016F035
		public int NumSockets()
		{
			return USkeletalMesh.__NumSockets_Internal(base.NativePtr);
		}

		// Token: 0x0600F95A RID: 63834 RVA: 0x00170E42 File Offset: 0x0016F042
		public TArray<string> K2_GetAllMorphTargetNames()
		{
			return new TArray<string>(USkeletalMesh.__K2_GetAllMorphTargetNames_Internal(base.NativePtr), null);
		}

		// Token: 0x0600F95B RID: 63835 RVA: 0x00170E55 File Offset: 0x0016F055
		public bool IsSectionUsingCloth(int InSectionIndex, bool bCheckCorrespondingSections = true)
		{
			return USkeletalMesh.__IsSectionUsingCloth_Internal(base.NativePtr, InSectionIndex, bCheckCorrespondingSections);
		}

		// Token: 0x0600F95C RID: 63836 RVA: 0x00170E64 File Offset: 0x0016F064
		public bool IsEnableBoneBounds()
		{
			return USkeletalMesh.__IsEnableBoneBounds_Internal(base.NativePtr);
		}

		// Token: 0x0600F95D RID: 63837 RVA: 0x00170E74 File Offset: 0x0016F074
		public unsafe bool IsContainSocket(string InSocketName)
		{
			FString fstring = FString.AllocTemp(InSocketName);
			bool result = USkeletalMesh.__IsContainSocket_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0600F95E RID: 63838 RVA: 0x00170E9E File Offset: 0x0016F09E
		public bool IsBoneBoundsApplyBounds()
		{
			return USkeletalMesh.__IsBoneBoundsApplyBounds_Internal(base.NativePtr);
		}

		// Token: 0x0600F95F RID: 63839 RVA: 0x00170EAB File Offset: 0x0016F0AB
		[NullableContext(2)]
		public USkeletalMeshSocket GetSocketByIndex(int Index)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshSocket>(USkeletalMesh.__GetSocketByIndex_Internal(base.NativePtr, Index));
		}

		// Token: 0x0600F960 RID: 63840 RVA: 0x00170EBE File Offset: 0x0016F0BE
		public int GetRawBoneNum()
		{
			return USkeletalMesh.__GetRawBoneNum_Internal(base.NativePtr);
		}

		// Token: 0x0600F961 RID: 63841 RVA: 0x00170ECB File Offset: 0x0016F0CB
		public TArray<UMaterialInterface> GetPreviewMaterials()
		{
			return new TArray<UMaterialInterface>(USkeletalMesh.__GetPreviewMaterials_Internal(base.NativePtr), null);
		}

		// Token: 0x0600F962 RID: 63842 RVA: 0x00170EDE File Offset: 0x0016F0DE
		public int GetNumTexCoords()
		{
			return USkeletalMesh.__GetNumTexCoords_Internal(base.NativePtr);
		}

		// Token: 0x0600F963 RID: 63843 RVA: 0x00170EEB File Offset: 0x0016F0EB
		public int GetNumSectionsAtLODIndex(int LODIndex)
		{
			return USkeletalMesh.__GetNumSectionsAtLODIndex_Internal(base.NativePtr, LODIndex);
		}

		// Token: 0x0600F964 RID: 63844 RVA: 0x00170EF9 File Offset: 0x0016F0F9
		public int GetNumSections()
		{
			return USkeletalMesh.__GetNumSections_Internal(base.NativePtr);
		}

		// Token: 0x0600F965 RID: 63845 RVA: 0x00170F06 File Offset: 0x0016F106
		[NullableContext(2)]
		public UNodeMappingContainer GetNodeMappingContainer(UBlueprint SourceAsset)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UNodeMappingContainer>(USkeletalMesh.__GetNodeMappingContainer_Internal(base.NativePtr, (SourceAsset != null) ? SourceAsset.NativePtr : IntPtr.Zero));
		}

		// Token: 0x0600F966 RID: 63846 RVA: 0x00170F28 File Offset: 0x0016F128
		public int GetLODNum()
		{
			return USkeletalMesh.__GetLODNum_Internal(base.NativePtr);
		}

		// Token: 0x0600F967 RID: 63847 RVA: 0x00170F35 File Offset: 0x0016F135
		public FBoxSphereBounds GetImportedBounds()
		{
			return USkeletalMesh.__GetImportedBounds_Internal(base.NativePtr);
		}

		// Token: 0x0600F968 RID: 63848 RVA: 0x00170F42 File Offset: 0x0016F142
		public TSoftObjectPtr<UObject> GetDefaultAnimatingRig()
		{
			return new TSoftObjectPtr<UObject>(USkeletalMesh.__GetDefaultAnimatingRig_Internal(base.NativePtr), true, true);
		}

		// Token: 0x0600F969 RID: 63849 RVA: 0x00170F56 File Offset: 0x0016F156
		public FBoxSphereBounds GetBounds()
		{
			return USkeletalMesh.__GetBounds_Internal(base.NativePtr);
		}

		// Token: 0x0600F96A RID: 63850 RVA: 0x00170F63 File Offset: 0x0016F163
		public float GetBoneBoundsExtension()
		{
			return USkeletalMesh.__GetBoneBoundsExtension_Internal(base.NativePtr);
		}

		// Token: 0x0600F96B RID: 63851 RVA: 0x00170F70 File Offset: 0x0016F170
		[NullableContext(2)]
		public unsafe USkeletalMeshSocket FindSocketInfo(FName InSocketName, ref FTransform OutTransform, ref int OutBoneIndex, ref int OutIndex)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = OutTransform;
			fixed (int* ptr2 = &OutBoneIndex)
			{
				void* ptr3 = (void*)ptr2;
				fixed (int* ptr4 = &OutIndex)
				{
					void* ptr5 = (void*)ptr4;
					USkeletalMeshSocket orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshSocket>(USkeletalMesh.__FindSocketInfo_Internal(base.NativePtr, InSocketName, ref ptr, ref OutBoneIndex, ref OutIndex));
					OutTransform = ptr;
					return orCreateUObjectByNativePointer;
				}
			}
		}

		// Token: 0x0600F96C RID: 63852 RVA: 0x00170FC8 File Offset: 0x0016F1C8
		[NullableContext(2)]
		public unsafe USkeletalMeshSocket FindSocketAndIndex(FName InSocketName, ref int OutIndex)
		{
			fixed (int* ptr = &OutIndex)
			{
				void* ptr2 = (void*)ptr;
				return BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshSocket>(USkeletalMesh.__FindSocketAndIndex_Internal(base.NativePtr, InSocketName, ref OutIndex));
			}
		}

		// Token: 0x0600F96D RID: 63853 RVA: 0x00170FEC File Offset: 0x0016F1EC
		[NullableContext(2)]
		public USkeletalMeshSocket FindSocket(FName InSocketName)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshSocket>(USkeletalMesh.__FindSocket_Internal(base.NativePtr, InSocketName));
		}

		// Token: 0x0600F96E RID: 63854
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateUVChannelData_Internal(IntPtr @this, bool bResetOverrides);

		// Token: 0x0600F96F RID: 63855
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPreviewMaterials_Internal(IntPtr @this, IntPtr InMaterials);

		// Token: 0x0600F970 RID: 63856
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLODSettings_Internal(IntPtr @this, IntPtr InLODSettings);

		// Token: 0x0600F971 RID: 63857
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetEnableBoneBounds_Internal(IntPtr @this, bool bEnable);

		// Token: 0x0600F972 RID: 63858
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDefaultAnimatingRig_Internal(IntPtr @this, IntPtr InAnimatingRig);

		// Token: 0x0600F973 RID: 63859
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBoneBoundsApplyBounds_Internal(IntPtr @this, bool bApply);

		// Token: 0x0600F974 RID: 63860
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveLODInfo_Internal(IntPtr @this, int Index);

		// Token: 0x0600F975 RID: 63861
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __NumSockets_Internal(IntPtr @this);

		// Token: 0x0600F976 RID: 63862
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __K2_GetAllMorphTargetNames_Internal(IntPtr @this);

		// Token: 0x0600F977 RID: 63863
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsSectionUsingCloth_Internal(IntPtr @this, int InSectionIndex, bool bCheckCorrespondingSections);

		// Token: 0x0600F978 RID: 63864
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsEnableBoneBounds_Internal(IntPtr @this);

		// Token: 0x0600F979 RID: 63865
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsContainSocket_Internal(IntPtr @this, in FString InSocketName);

		// Token: 0x0600F97A RID: 63866
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsBoneBoundsApplyBounds_Internal(IntPtr @this);

		// Token: 0x0600F97B RID: 63867
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetSocketByIndex_Internal(IntPtr @this, int Index);

		// Token: 0x0600F97C RID: 63868
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetRawBoneNum_Internal(IntPtr @this);

		// Token: 0x0600F97D RID: 63869
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetPreviewMaterials_Internal(IntPtr @this);

		// Token: 0x0600F97E RID: 63870
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetNumTexCoords_Internal(IntPtr @this);

		// Token: 0x0600F97F RID: 63871
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetNumSectionsAtLODIndex_Internal(IntPtr @this, int LODIndex);

		// Token: 0x0600F980 RID: 63872
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetNumSections_Internal(IntPtr @this);

		// Token: 0x0600F981 RID: 63873
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetNodeMappingContainer_Internal(IntPtr @this, IntPtr SourceAsset);

		// Token: 0x0600F982 RID: 63874
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetLODNum_Internal(IntPtr @this);

		// Token: 0x0600F983 RID: 63875
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FBoxSphereBounds __GetImportedBounds_Internal(IntPtr @this);

		// Token: 0x0600F984 RID: 63876
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetDefaultAnimatingRig_Internal(IntPtr @this);

		// Token: 0x0600F985 RID: 63877
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FBoxSphereBounds __GetBounds_Internal(IntPtr @this);

		// Token: 0x0600F986 RID: 63878
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetBoneBoundsExtension_Internal(IntPtr @this);

		// Token: 0x0600F987 RID: 63879
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __FindSocketInfo_Internal(IntPtr @this, FName InSocketName, ref FTransform OutTransform, ref int OutBoneIndex, ref int OutIndex);

		// Token: 0x0600F988 RID: 63880
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __FindSocketAndIndex_Internal(IntPtr @this, FName InSocketName, ref int OutIndex);

		// Token: 0x0600F989 RID: 63881
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __FindSocket_Internal(IntPtr @this, FName InSocketName);

		// Token: 0x0600F98A RID: 63882 RVA: 0x00170FFF File Offset: 0x0016F1FF
		static USkeletalMesh()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.SkeletalMesh");
		}

		// Token: 0x0600F98B RID: 63883 RVA: 0x0017100D File Offset: 0x0016F20D
		protected USkeletalMesh(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04008673 RID: 34419
		internal static int __InterfaceOffset_IInterface_CollisionDataProvider;

		// Token: 0x04008674 RID: 34420
		internal static int __InterfaceOffset_IInterface_AssetUserData;

		// Token: 0x04008675 RID: 34421
		internal static int __InterfaceOffset_INodeMappingProviderInterface;

		// Token: 0x04008676 RID: 34422
		public new const string __ObjectPath = "/Script/Engine.SkeletalMesh";

		// Token: 0x04008677 RID: 34423
		private static IntPtr _ClassPtr;

		// Token: 0x04008678 RID: 34424
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04008679 RID: 34425
		internal static int __PropertyOffset_Skeleton;

		// Token: 0x0400867A RID: 34426
		internal static int __PropertyOffset_bEnableBoneFold;

		// Token: 0x0400867B RID: 34427
		internal static int __PropertyOffset_UseKneeTransparency;

		// Token: 0x0400867C RID: 34428
		internal static int __PropertyOffset_LeftKneeBoneNames;

		// Token: 0x0400867D RID: 34429
		[Nullable(2)]
		private FLeftKneeBoneNames _LeftKneeBoneNames;

		// Token: 0x0400867E RID: 34430
		internal static int __PropertyOffset_RightKneeBoneNames;

		// Token: 0x0400867F RID: 34431
		[Nullable(2)]
		private FRightKneeBoneNames _RightKneeBoneNames;

		// Token: 0x04008680 RID: 34432
		internal static int __PropertyOffset_UseCustomBonePosition;

		// Token: 0x04008681 RID: 34433
		internal static int __PropertyOffset_CustomBoneNamesIndices;

		// Token: 0x04008682 RID: 34434
		[Nullable(2)]
		private TMap<FName, int> _CustomBoneNamesIndices;

		// Token: 0x04008683 RID: 34435
		internal static int __PropertyOffset_HeadBoneName;

		// Token: 0x04008684 RID: 34436
		internal static int __PropertyOffset_ForcePreviousBoneUpdateMode;

		// Token: 0x04008685 RID: 34437
		internal static int __PropertyOffset_LODBoneFoldMapping;

		// Token: 0x04008686 RID: 34438
		[Nullable(2)]
		private TArray<int> _LODBoneFoldMapping;

		// Token: 0x04008687 RID: 34439
		internal static int __PropertyOffset_ImportedBounds;

		// Token: 0x04008688 RID: 34440
		internal static int __PropertyOffset_ExtendedBounds;

		// Token: 0x04008689 RID: 34441
		internal static int __PropertyOffset_ImportedBoundsScale;

		// Token: 0x0400868A RID: 34442
		internal static int __PropertyOffset_PositiveBoundsExtension;

		// Token: 0x0400868B RID: 34443
		internal static int __PropertyOffset_NegativeBoundsExtension;

		// Token: 0x0400868C RID: 34444
		internal static int __PropertyOffset_bEnableBoneBounds;

		// Token: 0x0400868D RID: 34445
		internal static int __PropertyOffset_BoneBoundsExtension;

		// Token: 0x0400868E RID: 34446
		internal static int __PropertyOffset_bBoneBoundsApplyBounds;

		// Token: 0x0400868F RID: 34447
		internal static int __PropertyOffset_bSkipCullVelocity;

		// Token: 0x04008690 RID: 34448
		internal static int __PropertyOffset_bForceUseExpandedTexcoords;

		// Token: 0x04008691 RID: 34449
		internal static int __PropertyOffset_NumSectionsBeforeCook;

		// Token: 0x04008692 RID: 34450
		internal static int __PropertyOffset_NumSectionsAfterCooked;

		// Token: 0x04008693 RID: 34451
		internal static int __PropertyOffset_Materials;

		// Token: 0x04008694 RID: 34452
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSkeletalMaterial> _Materials;

		// Token: 0x04008695 RID: 34453
		internal static int __PropertyOffset_SkelMirrorTable;

		// Token: 0x04008696 RID: 34454
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FBoneMirrorInfo> _SkelMirrorTable;

		// Token: 0x04008697 RID: 34455
		internal static int __PropertyOffset_LODInfo;

		// Token: 0x04008698 RID: 34456
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSkeletalMeshLODInfo> _LODInfo;

		// Token: 0x04008699 RID: 34457
		internal static int __PropertyOffset_MinLod;

		// Token: 0x0400869A RID: 34458
		[Nullable(2)]
		private FPerPlatformInt _MinLod;

		// Token: 0x0400869B RID: 34459
		internal static int __PropertyOffset_MaxLod;

		// Token: 0x0400869C RID: 34460
		[Nullable(2)]
		private FPerPlatformInt _MaxLod;

		// Token: 0x0400869D RID: 34461
		internal static int __PropertyOffset_MaxOutlineLod;

		// Token: 0x0400869E RID: 34462
		[Nullable(2)]
		private FPerPlatformInt _MaxOutlineLod;

		// Token: 0x0400869F RID: 34463
		internal static int __PropertyOffset_ScreenSizeCullRatio;

		// Token: 0x040086A0 RID: 34464
		internal static int __PropertyOffset_DisableBelowMinLodStripping;

		// Token: 0x040086A1 RID: 34465
		[Nullable(2)]
		private FPerPlatformBool _DisableBelowMinLodStripping;

		// Token: 0x040086A2 RID: 34466
		internal static int __PropertyOffset_bUseKuroLODDistance;

		// Token: 0x040086A3 RID: 34467
		internal static int __PropertyOffset_SkelMirrorAxis;

		// Token: 0x040086A4 RID: 34468
		internal static int __PropertyOffset_SkelMirrorFlipAxis;

		// Token: 0x040086A5 RID: 34469
		internal static int __PropertyOffset_bUseFullPrecisionUVs_DEPRECATED;

		// Token: 0x040086A6 RID: 34470
		internal static byte __PropertyMask_bUseFullPrecisionUVs_DEPRECATED;

		// Token: 0x040086A7 RID: 34471
		internal static int __PropertyOffset_bUseHighPrecisionTangentBasis_DEPRECATED;

		// Token: 0x040086A8 RID: 34472
		internal static byte __PropertyMask_bUseHighPrecisionTangentBasis_DEPRECATED;

		// Token: 0x040086A9 RID: 34473
		internal static int __PropertyOffset_bHasBeenSimplified;

		// Token: 0x040086AA RID: 34474
		internal static byte __PropertyMask_bHasBeenSimplified;

		// Token: 0x040086AB RID: 34475
		internal static int __PropertyOffset_bHasVertexColors;

		// Token: 0x040086AC RID: 34476
		internal static byte __PropertyMask_bHasVertexColors;

		// Token: 0x040086AD RID: 34477
		internal static int __PropertyOffset_bEnablePerPolyCollision;

		// Token: 0x040086AE RID: 34478
		internal static byte __PropertyMask_bEnablePerPolyCollision;

		// Token: 0x040086AF RID: 34479
		internal static int __PropertyOffset_BodySetup;

		// Token: 0x040086B0 RID: 34480
		internal static int __PropertyOffset_PhysicsAsset;

		// Token: 0x040086B1 RID: 34481
		internal static int __PropertyOffset_ShadowPhysicsAsset;

		// Token: 0x040086B2 RID: 34482
		internal static int __PropertyOffset_KuroMaterialVariationAssets;

		// Token: 0x040086B3 RID: 34483
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UKuroMaterialVariationCollection> _KuroMaterialVariationAssets;

		// Token: 0x040086B4 RID: 34484
		internal static int __PropertyOffset_KuroMaterialVariationData;

		// Token: 0x040086B5 RID: 34485
		internal static int __PropertyOffset_NodeMappingData;

		// Token: 0x040086B6 RID: 34486
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UNodeMappingContainer> _NodeMappingData;

		// Token: 0x040086B7 RID: 34487
		internal static int __PropertyOffset_KuroMorphTargetsAssetPath;

		// Token: 0x040086B8 RID: 34488
		[Nullable(2)]
		private FSoftObjectPath _KuroMorphTargetsAssetPath;

		// Token: 0x040086B9 RID: 34489
		internal static int __PropertyOffset_KuroMorphTargetsAsset;

		// Token: 0x040086BA RID: 34490
		internal static int __PropertyOffset_MorphTargets;

		// Token: 0x040086BB RID: 34491
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMorphTarget> _MorphTargets;

		// Token: 0x040086BC RID: 34492
		internal static int __PropertyOffset_PostProcessAnimBlueprint;

		// Token: 0x040086BD RID: 34493
		internal static int __PropertyOffset_MeshClothingAssets;

		// Token: 0x040086BE RID: 34494
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UClothingAssetBase> _MeshClothingAssets;

		// Token: 0x040086BF RID: 34495
		internal static int __PropertyOffset_SamplingInfo;

		// Token: 0x040086C0 RID: 34496
		[Nullable(2)]
		private FSkeletalMeshSamplingInfo _SamplingInfo;

		// Token: 0x040086C1 RID: 34497
		internal static int __PropertyOffset_AssetUserData;

		// Token: 0x040086C2 RID: 34498
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UAssetUserData> _AssetUserData;

		// Token: 0x040086C3 RID: 34499
		internal static int __PropertyOffset_Sockets;

		// Token: 0x040086C4 RID: 34500
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<USkeletalMeshSocket> _Sockets;

		// Token: 0x040086C5 RID: 34501
		internal static int __PropertyOffset_SkinWeightProfiles;

		// Token: 0x040086C6 RID: 34502
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSkinWeightProfileInfo> _SkinWeightProfiles;
	}
}
