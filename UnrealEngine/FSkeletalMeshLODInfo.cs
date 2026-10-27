using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020010FD RID: 4349
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.SkeletalMeshLODInfo")]
	[UnrealStructLayout(576, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 576)]
	public class FSkeletalMeshLODInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600FC43 RID: 64579 RVA: 0x001745F4 File Offset: 0x001727F4
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSkeletalMeshLODInfo._ScriptStructPtr != 0) ? FSkeletalMeshLODInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.SkeletalMeshLODInfo", ref FSkeletalMeshLODInfo._ScriptStructPtr);
		}

		// Token: 0x17003D7B RID: 15739
		// (get) Token: 0x0600FC44 RID: 64580 RVA: 0x00174618 File Offset: 0x00172818
		// (set) Token: 0x0600FC45 RID: 64581 RVA: 0x0017465B File Offset: 0x0017285B
		public FPerPlatformFloat ScreenSize
		{
			get
			{
				base.FastCheckIsValid();
				FPerPlatformFloat result;
				if ((result = this._ScreenSize) == null)
				{
					result = (this._ScreenSize = new FPerPlatformFloat(base.NativePtr + (IntPtr)FSkeletalMeshLODInfo.__PropertyOffset_ScreenSize, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPerPlatformFloat.StaticStruct(), base.NativePtr + (IntPtr)FSkeletalMeshLODInfo.__PropertyOffset_ScreenSize, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003D7C RID: 15740
		// (get) Token: 0x0600FC46 RID: 64582 RVA: 0x0017467C File Offset: 0x0017287C
		// (set) Token: 0x0600FC47 RID: 64583 RVA: 0x0017468C File Offset: 0x0017288C
		public unsafe float LODHysteresis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSkeletalMeshLODInfo.__PropertyOffset_LODHysteresis);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSkeletalMeshLODInfo.__PropertyOffset_LODHysteresis) = value;
			}
		}

		// Token: 0x17003D7D RID: 15741
		// (get) Token: 0x0600FC48 RID: 64584 RVA: 0x001746A0 File Offset: 0x001728A0
		// (set) Token: 0x0600FC49 RID: 64585 RVA: 0x001746E3 File Offset: 0x001728E3
		public FPerPlatformFloat KuroLODDistance
		{
			get
			{
				base.FastCheckIsValid();
				FPerPlatformFloat result;
				if ((result = this._KuroLODDistance) == null)
				{
					result = (this._KuroLODDistance = new FPerPlatformFloat(base.NativePtr + (IntPtr)FSkeletalMeshLODInfo.__PropertyOffset_KuroLODDistance, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPerPlatformFloat.StaticStruct(), base.NativePtr + (IntPtr)FSkeletalMeshLODInfo.__PropertyOffset_KuroLODDistance, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003D7E RID: 15742
		// (get) Token: 0x0600FC4A RID: 64586 RVA: 0x00174704 File Offset: 0x00172904
		// (set) Token: 0x0600FC4B RID: 64587 RVA: 0x00174747 File Offset: 0x00172947
		public TArray<int> LODMaterialMap
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._LODMaterialMap) == null)
				{
					result = (this._LODMaterialMap = new TArray<int>(base.NativePtr + (IntPtr)FSkeletalMeshLODInfo.__PropertyOffset_LODMaterialMap, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.LODMaterialMap.CopyAssign(value);
			}
		}

		// Token: 0x17003D7F RID: 15743
		// (get) Token: 0x0600FC4C RID: 64588 RVA: 0x00174758 File Offset: 0x00172958
		// (set) Token: 0x0600FC4D RID: 64589 RVA: 0x0017479B File Offset: 0x0017299B
		public TArray<FSectionExtraMaterialMap> LODSectionExtraMaterialMap
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FSectionExtraMaterialMap> result;
				if ((result = this._LODSectionExtraMaterialMap) == null)
				{
					result = (this._LODSectionExtraMaterialMap = new TArray<FSectionExtraMaterialMap>(base.NativePtr + (IntPtr)FSkeletalMeshLODInfo.__PropertyOffset_LODSectionExtraMaterialMap, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.LODSectionExtraMaterialMap.CopyAssign(value);
			}
		}

		// Token: 0x17003D80 RID: 15744
		// (get) Token: 0x0600FC4E RID: 64590 RVA: 0x001747AC File Offset: 0x001729AC
		// (set) Token: 0x0600FC4F RID: 64591 RVA: 0x001747EF File Offset: 0x001729EF
		public FSkeletalMeshBuildSettings BuildSettings
		{
			get
			{
				base.FastCheckIsValid();
				FSkeletalMeshBuildSettings result;
				if ((result = this._BuildSettings) == null)
				{
					result = (this._BuildSettings = new FSkeletalMeshBuildSettings(base.NativePtr + (IntPtr)FSkeletalMeshLODInfo.__PropertyOffset_BuildSettings, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSkeletalMeshBuildSettings.StaticStruct(), base.NativePtr + (IntPtr)FSkeletalMeshLODInfo.__PropertyOffset_BuildSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003D81 RID: 15745
		// (get) Token: 0x0600FC50 RID: 64592 RVA: 0x00174810 File Offset: 0x00172A10
		// (set) Token: 0x0600FC51 RID: 64593 RVA: 0x00174853 File Offset: 0x00172A53
		public FSkeletalMeshOptimizationSettings ReductionSettings
		{
			get
			{
				base.FastCheckIsValid();
				FSkeletalMeshOptimizationSettings result;
				if ((result = this._ReductionSettings) == null)
				{
					result = (this._ReductionSettings = new FSkeletalMeshOptimizationSettings(base.NativePtr + (IntPtr)FSkeletalMeshLODInfo.__PropertyOffset_ReductionSettings, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSkeletalMeshOptimizationSettings.StaticStruct(), base.NativePtr + (IntPtr)FSkeletalMeshLODInfo.__PropertyOffset_ReductionSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003D82 RID: 15746
		// (get) Token: 0x0600FC52 RID: 64594 RVA: 0x00174874 File Offset: 0x00172A74
		// (set) Token: 0x0600FC53 RID: 64595 RVA: 0x001748B7 File Offset: 0x00172AB7
		public TArray<FBoneReference> BonesToRemove
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FBoneReference> result;
				if ((result = this._BonesToRemove) == null)
				{
					result = (this._BonesToRemove = new TArray<FBoneReference>(base.NativePtr + (IntPtr)FSkeletalMeshLODInfo.__PropertyOffset_BonesToRemove, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.BonesToRemove.CopyAssign(value);
			}
		}

		// Token: 0x17003D83 RID: 15747
		// (get) Token: 0x0600FC54 RID: 64596 RVA: 0x001748C8 File Offset: 0x00172AC8
		// (set) Token: 0x0600FC55 RID: 64597 RVA: 0x0017490B File Offset: 0x00172B0B
		public TArray<FBoneReference> BonesToPrioritize
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FBoneReference> result;
				if ((result = this._BonesToPrioritize) == null)
				{
					result = (this._BonesToPrioritize = new TArray<FBoneReference>(base.NativePtr + (IntPtr)FSkeletalMeshLODInfo.__PropertyOffset_BonesToPrioritize, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.BonesToPrioritize.CopyAssign(value);
			}
		}

		// Token: 0x17003D84 RID: 15748
		// (get) Token: 0x0600FC56 RID: 64598 RVA: 0x00174919 File Offset: 0x00172B19
		// (set) Token: 0x0600FC57 RID: 64599 RVA: 0x00174929 File Offset: 0x00172B29
		public unsafe float WeightOfPrioritization
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSkeletalMeshLODInfo.__PropertyOffset_WeightOfPrioritization);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSkeletalMeshLODInfo.__PropertyOffset_WeightOfPrioritization) = value;
			}
		}

		// Token: 0x17003D85 RID: 15749
		// (get) Token: 0x0600FC58 RID: 64600 RVA: 0x0017493A File Offset: 0x00172B3A
		// (set) Token: 0x0600FC59 RID: 64601 RVA: 0x0017494E File Offset: 0x00172B4E
		[Nullable(2)]
		public unsafe UAnimSequence BakePose
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAnimSequence>(base.NativePtr / (IntPtr)sizeof(void*) + FSkeletalMeshLODInfo.__PropertyOffset_BakePose);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FSkeletalMeshLODInfo.__PropertyOffset_BakePose, value);
			}
		}

		// Token: 0x17003D86 RID: 15750
		// (get) Token: 0x0600FC5A RID: 64602 RVA: 0x00174963 File Offset: 0x00172B63
		// (set) Token: 0x0600FC5B RID: 64603 RVA: 0x00174977 File Offset: 0x00172B77
		[Nullable(2)]
		public unsafe UAnimSequence BakePoseOverride
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAnimSequence>(base.NativePtr / (IntPtr)sizeof(void*) + FSkeletalMeshLODInfo.__PropertyOffset_BakePoseOverride);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FSkeletalMeshLODInfo.__PropertyOffset_BakePoseOverride, value);
			}
		}

		// Token: 0x17003D87 RID: 15751
		// (get) Token: 0x0600FC5C RID: 64604 RVA: 0x0017498C File Offset: 0x00172B8C
		// (set) Token: 0x0600FC5D RID: 64605 RVA: 0x001749A0 File Offset: 0x00172BA0
		public unsafe string SourceImportFilename
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FSkeletalMeshLODInfo.__PropertyOffset_SourceImportFilename)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FSkeletalMeshLODInfo.__PropertyOffset_SourceImportFilename)), value);
			}
		}

		// Token: 0x17003D88 RID: 15752
		// (get) Token: 0x0600FC5E RID: 64606 RVA: 0x001749B5 File Offset: 0x00172BB5
		// (set) Token: 0x0600FC5F RID: 64607 RVA: 0x001749C5 File Offset: 0x00172BC5
		public unsafe ESkinCacheUsage SkinCacheUsage
		{
			get
			{
				return (ESkinCacheUsage)(*(base.NativePtr + (IntPtr)FSkeletalMeshLODInfo.__PropertyOffset_SkinCacheUsage));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSkeletalMeshLODInfo.__PropertyOffset_SkinCacheUsage) = (byte)value;
			}
		}

		// Token: 0x17003D89 RID: 15753
		// (get) Token: 0x0600FC60 RID: 64608 RVA: 0x001749D6 File Offset: 0x00172BD6
		// (set) Token: 0x0600FC61 RID: 64609 RVA: 0x001749EF File Offset: 0x00172BEF
		public unsafe bool bHasBeenSimplified
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FSkeletalMeshLODInfo.__PropertyOffset_bHasBeenSimplified) & FSkeletalMeshLODInfo.__PropertyMask_bHasBeenSimplified) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FSkeletalMeshLODInfo.__PropertyOffset_bHasBeenSimplified) = ((*(base.NativePtr + (IntPtr)FSkeletalMeshLODInfo.__PropertyOffset_bHasBeenSimplified) & ~FSkeletalMeshLODInfo.__PropertyMask_bHasBeenSimplified) | (value ? FSkeletalMeshLODInfo.__PropertyMask_bHasBeenSimplified : 0));
			}
		}

		// Token: 0x17003D8A RID: 15754
		// (get) Token: 0x0600FC62 RID: 64610 RVA: 0x00174A1F File Offset: 0x00172C1F
		// (set) Token: 0x0600FC63 RID: 64611 RVA: 0x00174A38 File Offset: 0x00172C38
		public unsafe bool bHasPerLODVertexColors
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FSkeletalMeshLODInfo.__PropertyOffset_bHasPerLODVertexColors) & FSkeletalMeshLODInfo.__PropertyMask_bHasPerLODVertexColors) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FSkeletalMeshLODInfo.__PropertyOffset_bHasPerLODVertexColors) = ((*(base.NativePtr + (IntPtr)FSkeletalMeshLODInfo.__PropertyOffset_bHasPerLODVertexColors) & ~FSkeletalMeshLODInfo.__PropertyMask_bHasPerLODVertexColors) | (value ? FSkeletalMeshLODInfo.__PropertyMask_bHasPerLODVertexColors : 0));
			}
		}

		// Token: 0x17003D8B RID: 15755
		// (get) Token: 0x0600FC64 RID: 64612 RVA: 0x00174A68 File Offset: 0x00172C68
		// (set) Token: 0x0600FC65 RID: 64613 RVA: 0x00174A81 File Offset: 0x00172C81
		public unsafe bool bAllowCPUAccess
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FSkeletalMeshLODInfo.__PropertyOffset_bAllowCPUAccess) & FSkeletalMeshLODInfo.__PropertyMask_bAllowCPUAccess) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FSkeletalMeshLODInfo.__PropertyOffset_bAllowCPUAccess) = ((*(base.NativePtr + (IntPtr)FSkeletalMeshLODInfo.__PropertyOffset_bAllowCPUAccess) & ~FSkeletalMeshLODInfo.__PropertyMask_bAllowCPUAccess) | (value ? FSkeletalMeshLODInfo.__PropertyMask_bAllowCPUAccess : 0));
			}
		}

		// Token: 0x17003D8C RID: 15756
		// (get) Token: 0x0600FC66 RID: 64614 RVA: 0x00174AB1 File Offset: 0x00172CB1
		// (set) Token: 0x0600FC67 RID: 64615 RVA: 0x00174ACA File Offset: 0x00172CCA
		public unsafe bool bSupportUniformlyDistributedSampling
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FSkeletalMeshLODInfo.__PropertyOffset_bSupportUniformlyDistributedSampling) & FSkeletalMeshLODInfo.__PropertyMask_bSupportUniformlyDistributedSampling) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FSkeletalMeshLODInfo.__PropertyOffset_bSupportUniformlyDistributedSampling) = ((*(base.NativePtr + (IntPtr)FSkeletalMeshLODInfo.__PropertyOffset_bSupportUniformlyDistributedSampling) & ~FSkeletalMeshLODInfo.__PropertyMask_bSupportUniformlyDistributedSampling) | (value ? FSkeletalMeshLODInfo.__PropertyMask_bSupportUniformlyDistributedSampling : 0));
			}
		}

		// Token: 0x17003D8D RID: 15757
		// (get) Token: 0x0600FC68 RID: 64616 RVA: 0x00174AFA File Offset: 0x00172CFA
		// (set) Token: 0x0600FC69 RID: 64617 RVA: 0x00174B13 File Offset: 0x00172D13
		public unsafe bool bEnableLODRemapping
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FSkeletalMeshLODInfo.__PropertyOffset_bEnableLODRemapping) & FSkeletalMeshLODInfo.__PropertyMask_bEnableLODRemapping) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FSkeletalMeshLODInfo.__PropertyOffset_bEnableLODRemapping) = ((*(base.NativePtr + (IntPtr)FSkeletalMeshLODInfo.__PropertyOffset_bEnableLODRemapping) & ~FSkeletalMeshLODInfo.__PropertyMask_bEnableLODRemapping) | (value ? FSkeletalMeshLODInfo.__PropertyMask_bEnableLODRemapping : 0));
			}
		}

		// Token: 0x17003D8E RID: 15758
		// (get) Token: 0x0600FC6A RID: 64618 RVA: 0x00174B43 File Offset: 0x00172D43
		// (set) Token: 0x0600FC6B RID: 64619 RVA: 0x00174B62 File Offset: 0x00172D62
		public TSoftObjectPtr<USkeletalMesh> LODRemappingMesh
		{
			get
			{
				return new TSoftObjectPtr<USkeletalMesh>(base.NativePtr + (IntPtr)FSkeletalMeshLODInfo.__PropertyOffset_LODRemappingMesh, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)FSkeletalMeshLODInfo.__PropertyOffset_LODRemappingMesh, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x0600FC6C RID: 64620 RVA: 0x00174B87 File Offset: 0x00172D87
		public FSkeletalMeshLODInfo()
		{
		}

		// Token: 0x0600FC6D RID: 64621 RVA: 0x00174B90 File Offset: 0x00172D90
		public FSkeletalMeshLODInfo(FPerPlatformFloat ScreenSize, float LODHysteresis, FPerPlatformFloat KuroLODDistance, TArray<int> LODMaterialMap, TArray<FSectionExtraMaterialMap> LODSectionExtraMaterialMap, TArray<int> SectionIndexToUVChannelForComputeTangents, TArray<bool> bEnableShadowCasting_DEPRECATED, TArray<FName> RemovedBones_DEPRECATED, FSkeletalMeshBuildSettings BuildSettings, FSkeletalMeshOptimizationSettings ReductionSettings, TArray<FBoneReference> BonesToRemove, TArray<FBoneReference> BonesToPrioritize, float WeightOfPrioritization, UAnimSequence BakePose, UAnimSequence BakePoseOverride, string SourceImportFilename, ESkinCacheUsage SkinCacheUsage, bool bHasBeenSimplified, bool bHasPerLODVertexColors, bool bAllowCPUAccess, bool bSupportUniformlyDistributedSampling, bool bEnableLODRemapping, TSoftObjectPtr<USkeletalMesh> LODRemappingMesh, bool bImportWithBaseMesh)
		{
			this.ScreenSize = ScreenSize;
			this.LODHysteresis = LODHysteresis;
			this.KuroLODDistance = KuroLODDistance;
			this.LODMaterialMap = LODMaterialMap;
			this.LODSectionExtraMaterialMap = LODSectionExtraMaterialMap;
			this.BuildSettings = BuildSettings;
			this.ReductionSettings = ReductionSettings;
			this.BonesToRemove = BonesToRemove;
			this.BonesToPrioritize = BonesToPrioritize;
			this.WeightOfPrioritization = WeightOfPrioritization;
			this.BakePose = BakePose;
			this.BakePoseOverride = BakePoseOverride;
			this.SourceImportFilename = SourceImportFilename;
			this.SkinCacheUsage = SkinCacheUsage;
			this.bHasBeenSimplified = bHasBeenSimplified;
			this.bHasPerLODVertexColors = bHasPerLODVertexColors;
			this.bAllowCPUAccess = bAllowCPUAccess;
			this.bSupportUniformlyDistributedSampling = bSupportUniformlyDistributedSampling;
			this.bEnableLODRemapping = bEnableLODRemapping;
			this.LODRemappingMesh = LODRemappingMesh;
		}

		// Token: 0x0600FC6E RID: 64622 RVA: 0x00174C40 File Offset: 0x00172E40
		protected override IntPtr GetUStructPtr()
		{
			return FSkeletalMeshLODInfo.StaticStruct();
		}

		// Token: 0x0600FC6F RID: 64623 RVA: 0x00174C4C File Offset: 0x00172E4C
		[NullableContext(2)]
		public FSkeletalMeshLODInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600FC70 RID: 64624 RVA: 0x00174C56 File Offset: 0x00172E56
		public FSkeletalMeshLODInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600FC71 RID: 64625 RVA: 0x00174C61 File Offset: 0x00172E61
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSkeletalMeshLODInfo(Pointer, false, true);
		}

		// Token: 0x0600FC72 RID: 64626 RVA: 0x00174C6B File Offset: 0x00172E6B
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSkeletalMeshLODInfo(Pointer, MemoryOwner);
		}

		// Token: 0x040087E1 RID: 34785
		public const string __ObjectPath = "/Script/Engine.SkeletalMeshLODInfo";

		// Token: 0x040087E2 RID: 34786
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040087E3 RID: 34787
		internal static int __PropertyOffset_ScreenSize;

		// Token: 0x040087E4 RID: 34788
		[Nullable(2)]
		private FPerPlatformFloat _ScreenSize;

		// Token: 0x040087E5 RID: 34789
		internal static int __PropertyOffset_LODHysteresis;

		// Token: 0x040087E6 RID: 34790
		internal static int __PropertyOffset_KuroLODDistance;

		// Token: 0x040087E7 RID: 34791
		[Nullable(2)]
		private FPerPlatformFloat _KuroLODDistance;

		// Token: 0x040087E8 RID: 34792
		internal static int __PropertyOffset_LODMaterialMap;

		// Token: 0x040087E9 RID: 34793
		[Nullable(2)]
		private TArray<int> _LODMaterialMap;

		// Token: 0x040087EA RID: 34794
		internal static int __PropertyOffset_LODSectionExtraMaterialMap;

		// Token: 0x040087EB RID: 34795
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSectionExtraMaterialMap> _LODSectionExtraMaterialMap;

		// Token: 0x040087EC RID: 34796
		internal static int __PropertyOffset_BuildSettings;

		// Token: 0x040087ED RID: 34797
		[Nullable(2)]
		private FSkeletalMeshBuildSettings _BuildSettings;

		// Token: 0x040087EE RID: 34798
		internal static int __PropertyOffset_ReductionSettings;

		// Token: 0x040087EF RID: 34799
		[Nullable(2)]
		private FSkeletalMeshOptimizationSettings _ReductionSettings;

		// Token: 0x040087F0 RID: 34800
		internal static int __PropertyOffset_BonesToRemove;

		// Token: 0x040087F1 RID: 34801
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FBoneReference> _BonesToRemove;

		// Token: 0x040087F2 RID: 34802
		internal static int __PropertyOffset_BonesToPrioritize;

		// Token: 0x040087F3 RID: 34803
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FBoneReference> _BonesToPrioritize;

		// Token: 0x040087F4 RID: 34804
		internal static int __PropertyOffset_WeightOfPrioritization;

		// Token: 0x040087F5 RID: 34805
		internal static int __PropertyOffset_BakePose;

		// Token: 0x040087F6 RID: 34806
		internal static int __PropertyOffset_BakePoseOverride;

		// Token: 0x040087F7 RID: 34807
		internal static int __PropertyOffset_SourceImportFilename;

		// Token: 0x040087F8 RID: 34808
		internal static int __PropertyOffset_SkinCacheUsage;

		// Token: 0x040087F9 RID: 34809
		internal static int __PropertyOffset_bHasBeenSimplified;

		// Token: 0x040087FA RID: 34810
		internal static byte __PropertyMask_bHasBeenSimplified;

		// Token: 0x040087FB RID: 34811
		internal static int __PropertyOffset_bHasPerLODVertexColors;

		// Token: 0x040087FC RID: 34812
		internal static byte __PropertyMask_bHasPerLODVertexColors;

		// Token: 0x040087FD RID: 34813
		internal static int __PropertyOffset_bAllowCPUAccess;

		// Token: 0x040087FE RID: 34814
		internal static byte __PropertyMask_bAllowCPUAccess;

		// Token: 0x040087FF RID: 34815
		internal static int __PropertyOffset_bSupportUniformlyDistributedSampling;

		// Token: 0x04008800 RID: 34816
		internal static byte __PropertyMask_bSupportUniformlyDistributedSampling;

		// Token: 0x04008801 RID: 34817
		internal static int __PropertyOffset_bEnableLODRemapping;

		// Token: 0x04008802 RID: 34818
		internal static byte __PropertyMask_bEnableLODRemapping;

		// Token: 0x04008803 RID: 34819
		internal static int __PropertyOffset_LODRemappingMesh;
	}
}
