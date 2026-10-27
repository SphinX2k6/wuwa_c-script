using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001100 RID: 4352
	[UnrealObjectPath("/Script/Engine.SkeletalMeshOptimizationSettings")]
	[UnrealStructLayout(120, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 120)]
	public class FSkeletalMeshOptimizationSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600FC8C RID: 64652 RVA: 0x00174FAF File Offset: 0x001731AF
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSkeletalMeshOptimizationSettings._ScriptStructPtr != 0) ? FSkeletalMeshOptimizationSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.SkeletalMeshOptimizationSettings", ref FSkeletalMeshOptimizationSettings._ScriptStructPtr);
		}

		// Token: 0x17003D98 RID: 15768
		// (get) Token: 0x0600FC8D RID: 64653 RVA: 0x00174FD3 File Offset: 0x001731D3
		// (set) Token: 0x0600FC8E RID: 64654 RVA: 0x00174FE7 File Offset: 0x001731E7
		public unsafe TEnumAsByte<SkeletalMeshTerminationCriterion> TerminationCriterion
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSkeletalMeshOptimizationSettings.__PropertyOffset_TerminationCriterion);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSkeletalMeshOptimizationSettings.__PropertyOffset_TerminationCriterion) = value;
			}
		}

		// Token: 0x17003D99 RID: 15769
		// (get) Token: 0x0600FC8F RID: 64655 RVA: 0x00174FFC File Offset: 0x001731FC
		// (set) Token: 0x0600FC90 RID: 64656 RVA: 0x0017500C File Offset: 0x0017320C
		public unsafe float NumOfTrianglesPercentage
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSkeletalMeshOptimizationSettings.__PropertyOffset_NumOfTrianglesPercentage);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSkeletalMeshOptimizationSettings.__PropertyOffset_NumOfTrianglesPercentage) = value;
			}
		}

		// Token: 0x17003D9A RID: 15770
		// (get) Token: 0x0600FC91 RID: 64657 RVA: 0x0017501D File Offset: 0x0017321D
		// (set) Token: 0x0600FC92 RID: 64658 RVA: 0x0017502D File Offset: 0x0017322D
		public unsafe float NumOfVertPercentage
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSkeletalMeshOptimizationSettings.__PropertyOffset_NumOfVertPercentage);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSkeletalMeshOptimizationSettings.__PropertyOffset_NumOfVertPercentage) = value;
			}
		}

		// Token: 0x17003D9B RID: 15771
		// (get) Token: 0x0600FC93 RID: 64659 RVA: 0x0017503E File Offset: 0x0017323E
		// (set) Token: 0x0600FC94 RID: 64660 RVA: 0x0017504E File Offset: 0x0017324E
		public unsafe uint MaxNumOfTriangles
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSkeletalMeshOptimizationSettings.__PropertyOffset_MaxNumOfTriangles);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSkeletalMeshOptimizationSettings.__PropertyOffset_MaxNumOfTriangles) = (int)value;
			}
		}

		// Token: 0x17003D9C RID: 15772
		// (get) Token: 0x0600FC95 RID: 64661 RVA: 0x0017505F File Offset: 0x0017325F
		// (set) Token: 0x0600FC96 RID: 64662 RVA: 0x0017506F File Offset: 0x0017326F
		public unsafe uint MaxNumOfVerts
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSkeletalMeshOptimizationSettings.__PropertyOffset_MaxNumOfVerts);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSkeletalMeshOptimizationSettings.__PropertyOffset_MaxNumOfVerts) = (int)value;
			}
		}

		// Token: 0x17003D9D RID: 15773
		// (get) Token: 0x0600FC97 RID: 64663 RVA: 0x00175080 File Offset: 0x00173280
		// (set) Token: 0x0600FC98 RID: 64664 RVA: 0x00175090 File Offset: 0x00173290
		public unsafe float MaxDeviationPercentage
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSkeletalMeshOptimizationSettings.__PropertyOffset_MaxDeviationPercentage);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSkeletalMeshOptimizationSettings.__PropertyOffset_MaxDeviationPercentage) = value;
			}
		}

		// Token: 0x17003D9E RID: 15774
		// (get) Token: 0x0600FC99 RID: 64665 RVA: 0x001750A1 File Offset: 0x001732A1
		// (set) Token: 0x0600FC9A RID: 64666 RVA: 0x001750B5 File Offset: 0x001732B5
		public unsafe TEnumAsByte<SkeletalMeshOptimizationType> ReductionMethod
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSkeletalMeshOptimizationSettings.__PropertyOffset_ReductionMethod);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSkeletalMeshOptimizationSettings.__PropertyOffset_ReductionMethod) = value;
			}
		}

		// Token: 0x17003D9F RID: 15775
		// (get) Token: 0x0600FC9B RID: 64667 RVA: 0x001750CA File Offset: 0x001732CA
		// (set) Token: 0x0600FC9C RID: 64668 RVA: 0x001750DE File Offset: 0x001732DE
		public unsafe TEnumAsByte<SkeletalMeshOptimizationImportance> SilhouetteImportance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSkeletalMeshOptimizationSettings.__PropertyOffset_SilhouetteImportance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSkeletalMeshOptimizationSettings.__PropertyOffset_SilhouetteImportance) = value;
			}
		}

		// Token: 0x17003DA0 RID: 15776
		// (get) Token: 0x0600FC9D RID: 64669 RVA: 0x001750F3 File Offset: 0x001732F3
		// (set) Token: 0x0600FC9E RID: 64670 RVA: 0x00175107 File Offset: 0x00173307
		public unsafe TEnumAsByte<SkeletalMeshOptimizationImportance> TextureImportance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSkeletalMeshOptimizationSettings.__PropertyOffset_TextureImportance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSkeletalMeshOptimizationSettings.__PropertyOffset_TextureImportance) = value;
			}
		}

		// Token: 0x17003DA1 RID: 15777
		// (get) Token: 0x0600FC9F RID: 64671 RVA: 0x0017511C File Offset: 0x0017331C
		// (set) Token: 0x0600FCA0 RID: 64672 RVA: 0x00175130 File Offset: 0x00173330
		public unsafe TEnumAsByte<SkeletalMeshOptimizationImportance> ShadingImportance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSkeletalMeshOptimizationSettings.__PropertyOffset_ShadingImportance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSkeletalMeshOptimizationSettings.__PropertyOffset_ShadingImportance) = value;
			}
		}

		// Token: 0x17003DA2 RID: 15778
		// (get) Token: 0x0600FCA1 RID: 64673 RVA: 0x00175145 File Offset: 0x00173345
		// (set) Token: 0x0600FCA2 RID: 64674 RVA: 0x00175159 File Offset: 0x00173359
		public unsafe TEnumAsByte<SkeletalMeshOptimizationImportance> SkinningImportance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSkeletalMeshOptimizationSettings.__PropertyOffset_SkinningImportance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSkeletalMeshOptimizationSettings.__PropertyOffset_SkinningImportance) = value;
			}
		}

		// Token: 0x17003DA3 RID: 15779
		// (get) Token: 0x0600FCA3 RID: 64675 RVA: 0x0017516E File Offset: 0x0017336E
		// (set) Token: 0x0600FCA4 RID: 64676 RVA: 0x00175187 File Offset: 0x00173387
		public unsafe bool bRemapMorphTargets
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FSkeletalMeshOptimizationSettings.__PropertyOffset_bRemapMorphTargets) & FSkeletalMeshOptimizationSettings.__PropertyMask_bRemapMorphTargets) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FSkeletalMeshOptimizationSettings.__PropertyOffset_bRemapMorphTargets) = ((*(base.NativePtr + (IntPtr)FSkeletalMeshOptimizationSettings.__PropertyOffset_bRemapMorphTargets) & ~FSkeletalMeshOptimizationSettings.__PropertyMask_bRemapMorphTargets) | (value ? FSkeletalMeshOptimizationSettings.__PropertyMask_bRemapMorphTargets : 0));
			}
		}

		// Token: 0x17003DA4 RID: 15780
		// (get) Token: 0x0600FCA5 RID: 64677 RVA: 0x001751B7 File Offset: 0x001733B7
		// (set) Token: 0x0600FCA6 RID: 64678 RVA: 0x001751D0 File Offset: 0x001733D0
		public unsafe bool bRecalcNormals
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FSkeletalMeshOptimizationSettings.__PropertyOffset_bRecalcNormals) & FSkeletalMeshOptimizationSettings.__PropertyMask_bRecalcNormals) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FSkeletalMeshOptimizationSettings.__PropertyOffset_bRecalcNormals) = ((*(base.NativePtr + (IntPtr)FSkeletalMeshOptimizationSettings.__PropertyOffset_bRecalcNormals) & ~FSkeletalMeshOptimizationSettings.__PropertyMask_bRecalcNormals) | (value ? FSkeletalMeshOptimizationSettings.__PropertyMask_bRecalcNormals : 0));
			}
		}

		// Token: 0x17003DA5 RID: 15781
		// (get) Token: 0x0600FCA7 RID: 64679 RVA: 0x00175200 File Offset: 0x00173400
		// (set) Token: 0x0600FCA8 RID: 64680 RVA: 0x00175210 File Offset: 0x00173410
		public unsafe float WeldingThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSkeletalMeshOptimizationSettings.__PropertyOffset_WeldingThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSkeletalMeshOptimizationSettings.__PropertyOffset_WeldingThreshold) = value;
			}
		}

		// Token: 0x17003DA6 RID: 15782
		// (get) Token: 0x0600FCA9 RID: 64681 RVA: 0x00175221 File Offset: 0x00173421
		// (set) Token: 0x0600FCAA RID: 64682 RVA: 0x00175231 File Offset: 0x00173431
		public unsafe float NormalsThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSkeletalMeshOptimizationSettings.__PropertyOffset_NormalsThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSkeletalMeshOptimizationSettings.__PropertyOffset_NormalsThreshold) = value;
			}
		}

		// Token: 0x17003DA7 RID: 15783
		// (get) Token: 0x0600FCAB RID: 64683 RVA: 0x00175242 File Offset: 0x00173442
		// (set) Token: 0x0600FCAC RID: 64684 RVA: 0x00175252 File Offset: 0x00173452
		public unsafe int MaxBonesPerVertex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSkeletalMeshOptimizationSettings.__PropertyOffset_MaxBonesPerVertex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSkeletalMeshOptimizationSettings.__PropertyOffset_MaxBonesPerVertex) = value;
			}
		}

		// Token: 0x17003DA8 RID: 15784
		// (get) Token: 0x0600FCAD RID: 64685 RVA: 0x00175263 File Offset: 0x00173463
		// (set) Token: 0x0600FCAE RID: 64686 RVA: 0x0017527C File Offset: 0x0017347C
		public unsafe bool bEnforceBoneBoundaries
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FSkeletalMeshOptimizationSettings.__PropertyOffset_bEnforceBoneBoundaries) & FSkeletalMeshOptimizationSettings.__PropertyMask_bEnforceBoneBoundaries) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FSkeletalMeshOptimizationSettings.__PropertyOffset_bEnforceBoneBoundaries) = ((*(base.NativePtr + (IntPtr)FSkeletalMeshOptimizationSettings.__PropertyOffset_bEnforceBoneBoundaries) & ~FSkeletalMeshOptimizationSettings.__PropertyMask_bEnforceBoneBoundaries) | (value ? FSkeletalMeshOptimizationSettings.__PropertyMask_bEnforceBoneBoundaries : 0));
			}
		}

		// Token: 0x17003DA9 RID: 15785
		// (get) Token: 0x0600FCAF RID: 64687 RVA: 0x001752AC File Offset: 0x001734AC
		// (set) Token: 0x0600FCB0 RID: 64688 RVA: 0x001752BC File Offset: 0x001734BC
		public unsafe float VolumeImportance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSkeletalMeshOptimizationSettings.__PropertyOffset_VolumeImportance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSkeletalMeshOptimizationSettings.__PropertyOffset_VolumeImportance) = value;
			}
		}

		// Token: 0x17003DAA RID: 15786
		// (get) Token: 0x0600FCB1 RID: 64689 RVA: 0x001752CD File Offset: 0x001734CD
		// (set) Token: 0x0600FCB2 RID: 64690 RVA: 0x001752E6 File Offset: 0x001734E6
		public unsafe bool bLockEdges
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FSkeletalMeshOptimizationSettings.__PropertyOffset_bLockEdges) & FSkeletalMeshOptimizationSettings.__PropertyMask_bLockEdges) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FSkeletalMeshOptimizationSettings.__PropertyOffset_bLockEdges) = ((*(base.NativePtr + (IntPtr)FSkeletalMeshOptimizationSettings.__PropertyOffset_bLockEdges) & ~FSkeletalMeshOptimizationSettings.__PropertyMask_bLockEdges) | (value ? FSkeletalMeshOptimizationSettings.__PropertyMask_bLockEdges : 0));
			}
		}

		// Token: 0x17003DAB RID: 15787
		// (get) Token: 0x0600FCB3 RID: 64691 RVA: 0x00175316 File Offset: 0x00173516
		// (set) Token: 0x0600FCB4 RID: 64692 RVA: 0x0017532F File Offset: 0x0017352F
		public unsafe bool bLockColorBounaries
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FSkeletalMeshOptimizationSettings.__PropertyOffset_bLockColorBounaries) & FSkeletalMeshOptimizationSettings.__PropertyMask_bLockColorBounaries) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FSkeletalMeshOptimizationSettings.__PropertyOffset_bLockColorBounaries) = ((*(base.NativePtr + (IntPtr)FSkeletalMeshOptimizationSettings.__PropertyOffset_bLockColorBounaries) & ~FSkeletalMeshOptimizationSettings.__PropertyMask_bLockColorBounaries) | (value ? FSkeletalMeshOptimizationSettings.__PropertyMask_bLockColorBounaries : 0));
			}
		}

		// Token: 0x17003DAC RID: 15788
		// (get) Token: 0x0600FCB5 RID: 64693 RVA: 0x0017535F File Offset: 0x0017355F
		// (set) Token: 0x0600FCB6 RID: 64694 RVA: 0x0017536F File Offset: 0x0017356F
		public unsafe int BaseLOD
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSkeletalMeshOptimizationSettings.__PropertyOffset_BaseLOD);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSkeletalMeshOptimizationSettings.__PropertyOffset_BaseLOD) = value;
			}
		}

		// Token: 0x0600FCB7 RID: 64695 RVA: 0x00175380 File Offset: 0x00173580
		public FSkeletalMeshOptimizationSettings()
		{
		}

		// Token: 0x0600FCB8 RID: 64696 RVA: 0x00175388 File Offset: 0x00173588
		public FSkeletalMeshOptimizationSettings(TEnumAsByte<SkeletalMeshTerminationCriterion> TerminationCriterion, float NumOfTrianglesPercentage, float NumOfVertPercentage, uint MaxNumOfTriangles, uint MaxNumOfVerts, uint MaxNumOfTrianglesPercentage, uint MaxNumOfVertsPercentage, float MaxDeviationPercentage, TEnumAsByte<SkeletalMeshOptimizationType> ReductionMethod, TEnumAsByte<SkeletalMeshOptimizationImportance> SilhouetteImportance, TEnumAsByte<SkeletalMeshOptimizationImportance> TextureImportance, TEnumAsByte<SkeletalMeshOptimizationImportance> ShadingImportance, TEnumAsByte<SkeletalMeshOptimizationImportance> SkinningImportance, bool bRemapMorphTargets, bool bRecalcNormals, float WeldingThreshold, float NormalsThreshold, int MaxBonesPerVertex, bool bEnforceBoneBoundaries, float VolumeImportance, bool bLockEdges, bool bLockColorBounaries, int BaseLOD, float LocalImportance, bool bForceCurrLOD, [Nullable(1)] TArray<FBoneReference> BonesToRemove_DEPRECATED, [Nullable(1)] UAnimSequence BakePose_DEPRECATED)
		{
			this.TerminationCriterion = TerminationCriterion;
			this.NumOfTrianglesPercentage = NumOfTrianglesPercentage;
			this.NumOfVertPercentage = NumOfVertPercentage;
			this.MaxNumOfTriangles = MaxNumOfTriangles;
			this.MaxNumOfVerts = MaxNumOfVerts;
			this.MaxDeviationPercentage = MaxDeviationPercentage;
			this.ReductionMethod = ReductionMethod;
			this.SilhouetteImportance = SilhouetteImportance;
			this.TextureImportance = TextureImportance;
			this.ShadingImportance = ShadingImportance;
			this.SkinningImportance = SkinningImportance;
			this.bRemapMorphTargets = bRemapMorphTargets;
			this.bRecalcNormals = bRecalcNormals;
			this.WeldingThreshold = WeldingThreshold;
			this.NormalsThreshold = NormalsThreshold;
			this.MaxBonesPerVertex = MaxBonesPerVertex;
			this.bEnforceBoneBoundaries = bEnforceBoneBoundaries;
			this.VolumeImportance = VolumeImportance;
			this.bLockEdges = bLockEdges;
			this.bLockColorBounaries = bLockColorBounaries;
			this.BaseLOD = BaseLOD;
		}

		// Token: 0x0600FCB9 RID: 64697 RVA: 0x00175440 File Offset: 0x00173640
		protected override IntPtr GetUStructPtr()
		{
			return FSkeletalMeshOptimizationSettings.StaticStruct();
		}

		// Token: 0x0600FCBA RID: 64698 RVA: 0x0017544C File Offset: 0x0017364C
		[NullableContext(2)]
		public FSkeletalMeshOptimizationSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600FCBB RID: 64699 RVA: 0x00175456 File Offset: 0x00173656
		public FSkeletalMeshOptimizationSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600FCBC RID: 64700 RVA: 0x00175461 File Offset: 0x00173661
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSkeletalMeshOptimizationSettings(Pointer, false, true);
		}

		// Token: 0x0600FCBD RID: 64701 RVA: 0x0017546B File Offset: 0x0017366B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSkeletalMeshOptimizationSettings(Pointer, MemoryOwner);
		}

		// Token: 0x0400881F RID: 34847
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.SkeletalMeshOptimizationSettings";

		// Token: 0x04008820 RID: 34848
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04008821 RID: 34849
		internal static int __PropertyOffset_TerminationCriterion;

		// Token: 0x04008822 RID: 34850
		internal static int __PropertyOffset_NumOfTrianglesPercentage;

		// Token: 0x04008823 RID: 34851
		internal static int __PropertyOffset_NumOfVertPercentage;

		// Token: 0x04008824 RID: 34852
		internal static int __PropertyOffset_MaxNumOfTriangles;

		// Token: 0x04008825 RID: 34853
		internal static int __PropertyOffset_MaxNumOfVerts;

		// Token: 0x04008826 RID: 34854
		internal static int __PropertyOffset_MaxDeviationPercentage;

		// Token: 0x04008827 RID: 34855
		internal static int __PropertyOffset_ReductionMethod;

		// Token: 0x04008828 RID: 34856
		internal static int __PropertyOffset_SilhouetteImportance;

		// Token: 0x04008829 RID: 34857
		internal static int __PropertyOffset_TextureImportance;

		// Token: 0x0400882A RID: 34858
		internal static int __PropertyOffset_ShadingImportance;

		// Token: 0x0400882B RID: 34859
		internal static int __PropertyOffset_SkinningImportance;

		// Token: 0x0400882C RID: 34860
		internal static int __PropertyOffset_bRemapMorphTargets;

		// Token: 0x0400882D RID: 34861
		internal static byte __PropertyMask_bRemapMorphTargets;

		// Token: 0x0400882E RID: 34862
		internal static int __PropertyOffset_bRecalcNormals;

		// Token: 0x0400882F RID: 34863
		internal static byte __PropertyMask_bRecalcNormals;

		// Token: 0x04008830 RID: 34864
		internal static int __PropertyOffset_WeldingThreshold;

		// Token: 0x04008831 RID: 34865
		internal static int __PropertyOffset_NormalsThreshold;

		// Token: 0x04008832 RID: 34866
		internal static int __PropertyOffset_MaxBonesPerVertex;

		// Token: 0x04008833 RID: 34867
		internal static int __PropertyOffset_bEnforceBoneBoundaries;

		// Token: 0x04008834 RID: 34868
		internal static byte __PropertyMask_bEnforceBoneBoundaries;

		// Token: 0x04008835 RID: 34869
		internal static int __PropertyOffset_VolumeImportance;

		// Token: 0x04008836 RID: 34870
		internal static int __PropertyOffset_bLockEdges;

		// Token: 0x04008837 RID: 34871
		internal static byte __PropertyMask_bLockEdges;

		// Token: 0x04008838 RID: 34872
		internal static int __PropertyOffset_bLockColorBounaries;

		// Token: 0x04008839 RID: 34873
		internal static byte __PropertyMask_bLockColorBounaries;

		// Token: 0x0400883A RID: 34874
		internal static int __PropertyOffset_BaseLOD;
	}
}
