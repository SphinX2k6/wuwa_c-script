using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020010F5 RID: 4341
	[UnrealObjectPath("/Script/Engine.SkeletalMeshBuildSettings")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FSkeletalMeshBuildSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600F9B2 RID: 63922 RVA: 0x001712E1 File Offset: 0x0016F4E1
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSkeletalMeshBuildSettings._ScriptStructPtr != 0) ? FSkeletalMeshBuildSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.SkeletalMeshBuildSettings", ref FSkeletalMeshBuildSettings._ScriptStructPtr);
		}

		// Token: 0x17003CDB RID: 15579
		// (get) Token: 0x0600F9B3 RID: 63923 RVA: 0x00171305 File Offset: 0x0016F505
		// (set) Token: 0x0600F9B4 RID: 63924 RVA: 0x0017131E File Offset: 0x0016F51E
		public unsafe bool bRecomputeNormals
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FSkeletalMeshBuildSettings.__PropertyOffset_bRecomputeNormals) & FSkeletalMeshBuildSettings.__PropertyMask_bRecomputeNormals) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FSkeletalMeshBuildSettings.__PropertyOffset_bRecomputeNormals) = ((*(base.NativePtr + (IntPtr)FSkeletalMeshBuildSettings.__PropertyOffset_bRecomputeNormals) & ~FSkeletalMeshBuildSettings.__PropertyMask_bRecomputeNormals) | (value ? FSkeletalMeshBuildSettings.__PropertyMask_bRecomputeNormals : 0));
			}
		}

		// Token: 0x17003CDC RID: 15580
		// (get) Token: 0x0600F9B5 RID: 63925 RVA: 0x0017134E File Offset: 0x0016F54E
		// (set) Token: 0x0600F9B6 RID: 63926 RVA: 0x00171367 File Offset: 0x0016F567
		public unsafe bool bRecomputeTangents
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FSkeletalMeshBuildSettings.__PropertyOffset_bRecomputeTangents) & FSkeletalMeshBuildSettings.__PropertyMask_bRecomputeTangents) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FSkeletalMeshBuildSettings.__PropertyOffset_bRecomputeTangents) = ((*(base.NativePtr + (IntPtr)FSkeletalMeshBuildSettings.__PropertyOffset_bRecomputeTangents) & ~FSkeletalMeshBuildSettings.__PropertyMask_bRecomputeTangents) | (value ? FSkeletalMeshBuildSettings.__PropertyMask_bRecomputeTangents : 0));
			}
		}

		// Token: 0x17003CDD RID: 15581
		// (get) Token: 0x0600F9B7 RID: 63927 RVA: 0x00171397 File Offset: 0x0016F597
		// (set) Token: 0x0600F9B8 RID: 63928 RVA: 0x001713B0 File Offset: 0x0016F5B0
		public unsafe bool bRecomputeTangentsUsingSpecifiedUV
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FSkeletalMeshBuildSettings.__PropertyOffset_bRecomputeTangentsUsingSpecifiedUV) & FSkeletalMeshBuildSettings.__PropertyMask_bRecomputeTangentsUsingSpecifiedUV) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FSkeletalMeshBuildSettings.__PropertyOffset_bRecomputeTangentsUsingSpecifiedUV) = ((*(base.NativePtr + (IntPtr)FSkeletalMeshBuildSettings.__PropertyOffset_bRecomputeTangentsUsingSpecifiedUV) & ~FSkeletalMeshBuildSettings.__PropertyMask_bRecomputeTangentsUsingSpecifiedUV) | (value ? FSkeletalMeshBuildSettings.__PropertyMask_bRecomputeTangentsUsingSpecifiedUV : 0));
			}
		}

		// Token: 0x17003CDE RID: 15582
		// (get) Token: 0x0600F9B9 RID: 63929 RVA: 0x001713E0 File Offset: 0x0016F5E0
		// (set) Token: 0x0600F9BA RID: 63930 RVA: 0x001713F9 File Offset: 0x0016F5F9
		public unsafe bool bUseMikkTSpace
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FSkeletalMeshBuildSettings.__PropertyOffset_bUseMikkTSpace) & FSkeletalMeshBuildSettings.__PropertyMask_bUseMikkTSpace) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FSkeletalMeshBuildSettings.__PropertyOffset_bUseMikkTSpace) = ((*(base.NativePtr + (IntPtr)FSkeletalMeshBuildSettings.__PropertyOffset_bUseMikkTSpace) & ~FSkeletalMeshBuildSettings.__PropertyMask_bUseMikkTSpace) | (value ? FSkeletalMeshBuildSettings.__PropertyMask_bUseMikkTSpace : 0));
			}
		}

		// Token: 0x17003CDF RID: 15583
		// (get) Token: 0x0600F9BB RID: 63931 RVA: 0x00171429 File Offset: 0x0016F629
		// (set) Token: 0x0600F9BC RID: 63932 RVA: 0x00171442 File Offset: 0x0016F642
		public unsafe bool bComputeWeightedNormals
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FSkeletalMeshBuildSettings.__PropertyOffset_bComputeWeightedNormals) & FSkeletalMeshBuildSettings.__PropertyMask_bComputeWeightedNormals) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FSkeletalMeshBuildSettings.__PropertyOffset_bComputeWeightedNormals) = ((*(base.NativePtr + (IntPtr)FSkeletalMeshBuildSettings.__PropertyOffset_bComputeWeightedNormals) & ~FSkeletalMeshBuildSettings.__PropertyMask_bComputeWeightedNormals) | (value ? FSkeletalMeshBuildSettings.__PropertyMask_bComputeWeightedNormals : 0));
			}
		}

		// Token: 0x17003CE0 RID: 15584
		// (get) Token: 0x0600F9BD RID: 63933 RVA: 0x00171472 File Offset: 0x0016F672
		// (set) Token: 0x0600F9BE RID: 63934 RVA: 0x0017148B File Offset: 0x0016F68B
		public unsafe bool bRemoveDegenerates
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FSkeletalMeshBuildSettings.__PropertyOffset_bRemoveDegenerates) & FSkeletalMeshBuildSettings.__PropertyMask_bRemoveDegenerates) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FSkeletalMeshBuildSettings.__PropertyOffset_bRemoveDegenerates) = ((*(base.NativePtr + (IntPtr)FSkeletalMeshBuildSettings.__PropertyOffset_bRemoveDegenerates) & ~FSkeletalMeshBuildSettings.__PropertyMask_bRemoveDegenerates) | (value ? FSkeletalMeshBuildSettings.__PropertyMask_bRemoveDegenerates : 0));
			}
		}

		// Token: 0x17003CE1 RID: 15585
		// (get) Token: 0x0600F9BF RID: 63935 RVA: 0x001714BB File Offset: 0x0016F6BB
		// (set) Token: 0x0600F9C0 RID: 63936 RVA: 0x001714D4 File Offset: 0x0016F6D4
		public unsafe bool bUseHighPrecisionTangentBasis
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FSkeletalMeshBuildSettings.__PropertyOffset_bUseHighPrecisionTangentBasis) & FSkeletalMeshBuildSettings.__PropertyMask_bUseHighPrecisionTangentBasis) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FSkeletalMeshBuildSettings.__PropertyOffset_bUseHighPrecisionTangentBasis) = ((*(base.NativePtr + (IntPtr)FSkeletalMeshBuildSettings.__PropertyOffset_bUseHighPrecisionTangentBasis) & ~FSkeletalMeshBuildSettings.__PropertyMask_bUseHighPrecisionTangentBasis) | (value ? FSkeletalMeshBuildSettings.__PropertyMask_bUseHighPrecisionTangentBasis : 0));
			}
		}

		// Token: 0x17003CE2 RID: 15586
		// (get) Token: 0x0600F9C1 RID: 63937 RVA: 0x00171504 File Offset: 0x0016F704
		// (set) Token: 0x0600F9C2 RID: 63938 RVA: 0x0017151D File Offset: 0x0016F71D
		public unsafe bool bUseFullPrecisionUVs
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FSkeletalMeshBuildSettings.__PropertyOffset_bUseFullPrecisionUVs) & FSkeletalMeshBuildSettings.__PropertyMask_bUseFullPrecisionUVs) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FSkeletalMeshBuildSettings.__PropertyOffset_bUseFullPrecisionUVs) = ((*(base.NativePtr + (IntPtr)FSkeletalMeshBuildSettings.__PropertyOffset_bUseFullPrecisionUVs) & ~FSkeletalMeshBuildSettings.__PropertyMask_bUseFullPrecisionUVs) | (value ? FSkeletalMeshBuildSettings.__PropertyMask_bUseFullPrecisionUVs : 0));
			}
		}

		// Token: 0x17003CE3 RID: 15587
		// (get) Token: 0x0600F9C3 RID: 63939 RVA: 0x0017154D File Offset: 0x0016F74D
		// (set) Token: 0x0600F9C4 RID: 63940 RVA: 0x00171566 File Offset: 0x0016F766
		public unsafe bool bBuildAdjacencyBuffer
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FSkeletalMeshBuildSettings.__PropertyOffset_bBuildAdjacencyBuffer) & FSkeletalMeshBuildSettings.__PropertyMask_bBuildAdjacencyBuffer) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FSkeletalMeshBuildSettings.__PropertyOffset_bBuildAdjacencyBuffer) = ((*(base.NativePtr + (IntPtr)FSkeletalMeshBuildSettings.__PropertyOffset_bBuildAdjacencyBuffer) & ~FSkeletalMeshBuildSettings.__PropertyMask_bBuildAdjacencyBuffer) | (value ? FSkeletalMeshBuildSettings.__PropertyMask_bBuildAdjacencyBuffer : 0));
			}
		}

		// Token: 0x17003CE4 RID: 15588
		// (get) Token: 0x0600F9C5 RID: 63941 RVA: 0x00171596 File Offset: 0x0016F796
		// (set) Token: 0x0600F9C6 RID: 63942 RVA: 0x001715A6 File Offset: 0x0016F7A6
		public unsafe float ThresholdPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSkeletalMeshBuildSettings.__PropertyOffset_ThresholdPosition);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSkeletalMeshBuildSettings.__PropertyOffset_ThresholdPosition) = value;
			}
		}

		// Token: 0x17003CE5 RID: 15589
		// (get) Token: 0x0600F9C7 RID: 63943 RVA: 0x001715B7 File Offset: 0x0016F7B7
		// (set) Token: 0x0600F9C8 RID: 63944 RVA: 0x001715C7 File Offset: 0x0016F7C7
		public unsafe float ThresholdTangentNormal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSkeletalMeshBuildSettings.__PropertyOffset_ThresholdTangentNormal);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSkeletalMeshBuildSettings.__PropertyOffset_ThresholdTangentNormal) = value;
			}
		}

		// Token: 0x17003CE6 RID: 15590
		// (get) Token: 0x0600F9C9 RID: 63945 RVA: 0x001715D8 File Offset: 0x0016F7D8
		// (set) Token: 0x0600F9CA RID: 63946 RVA: 0x001715E8 File Offset: 0x0016F7E8
		public unsafe float ThresholdUV
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSkeletalMeshBuildSettings.__PropertyOffset_ThresholdUV);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSkeletalMeshBuildSettings.__PropertyOffset_ThresholdUV) = value;
			}
		}

		// Token: 0x17003CE7 RID: 15591
		// (get) Token: 0x0600F9CB RID: 63947 RVA: 0x001715F9 File Offset: 0x0016F7F9
		// (set) Token: 0x0600F9CC RID: 63948 RVA: 0x00171609 File Offset: 0x0016F809
		public unsafe float MorphThresholdPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSkeletalMeshBuildSettings.__PropertyOffset_MorphThresholdPosition);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSkeletalMeshBuildSettings.__PropertyOffset_MorphThresholdPosition) = value;
			}
		}

		// Token: 0x0600F9CD RID: 63949 RVA: 0x0017161A File Offset: 0x0016F81A
		public FSkeletalMeshBuildSettings()
		{
		}

		// Token: 0x0600F9CE RID: 63950 RVA: 0x00171624 File Offset: 0x0016F824
		public FSkeletalMeshBuildSettings(bool bRecomputeNormals, bool bRecomputeTangents, bool bRecomputeTangentsUsingSpecifiedUV, bool bUseMikkTSpace, bool bComputeWeightedNormals, bool bRemoveDegenerates, bool bUseHighPrecisionTangentBasis, bool bUseFullPrecisionUVs, bool bBuildAdjacencyBuffer, float ThresholdPosition, float ThresholdTangentNormal, float ThresholdUV, float MorphThresholdPosition)
		{
			this.bRecomputeNormals = bRecomputeNormals;
			this.bRecomputeTangents = bRecomputeTangents;
			this.bRecomputeTangentsUsingSpecifiedUV = bRecomputeTangentsUsingSpecifiedUV;
			this.bUseMikkTSpace = bUseMikkTSpace;
			this.bComputeWeightedNormals = bComputeWeightedNormals;
			this.bRemoveDegenerates = bRemoveDegenerates;
			this.bUseHighPrecisionTangentBasis = bUseHighPrecisionTangentBasis;
			this.bUseFullPrecisionUVs = bUseFullPrecisionUVs;
			this.bBuildAdjacencyBuffer = bBuildAdjacencyBuffer;
			this.ThresholdPosition = ThresholdPosition;
			this.ThresholdTangentNormal = ThresholdTangentNormal;
			this.ThresholdUV = ThresholdUV;
			this.MorphThresholdPosition = MorphThresholdPosition;
		}

		// Token: 0x0600F9CF RID: 63951 RVA: 0x0017169C File Offset: 0x0016F89C
		protected override IntPtr GetUStructPtr()
		{
			return FSkeletalMeshBuildSettings.StaticStruct();
		}

		// Token: 0x0600F9D0 RID: 63952 RVA: 0x001716A8 File Offset: 0x0016F8A8
		[NullableContext(2)]
		public FSkeletalMeshBuildSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600F9D1 RID: 63953 RVA: 0x001716B2 File Offset: 0x0016F8B2
		public FSkeletalMeshBuildSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600F9D2 RID: 63954 RVA: 0x001716BD File Offset: 0x0016F8BD
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSkeletalMeshBuildSettings(Pointer, false, true);
		}

		// Token: 0x0600F9D3 RID: 63955 RVA: 0x001716C7 File Offset: 0x0016F8C7
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSkeletalMeshBuildSettings(Pointer, MemoryOwner);
		}

		// Token: 0x040086D8 RID: 34520
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.SkeletalMeshBuildSettings";

		// Token: 0x040086D9 RID: 34521
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040086DA RID: 34522
		internal static int __PropertyOffset_bRecomputeNormals;

		// Token: 0x040086DB RID: 34523
		internal static byte __PropertyMask_bRecomputeNormals;

		// Token: 0x040086DC RID: 34524
		internal static int __PropertyOffset_bRecomputeTangents;

		// Token: 0x040086DD RID: 34525
		internal static byte __PropertyMask_bRecomputeTangents;

		// Token: 0x040086DE RID: 34526
		internal static int __PropertyOffset_bRecomputeTangentsUsingSpecifiedUV;

		// Token: 0x040086DF RID: 34527
		internal static byte __PropertyMask_bRecomputeTangentsUsingSpecifiedUV;

		// Token: 0x040086E0 RID: 34528
		internal static int __PropertyOffset_bUseMikkTSpace;

		// Token: 0x040086E1 RID: 34529
		internal static byte __PropertyMask_bUseMikkTSpace;

		// Token: 0x040086E2 RID: 34530
		internal static int __PropertyOffset_bComputeWeightedNormals;

		// Token: 0x040086E3 RID: 34531
		internal static byte __PropertyMask_bComputeWeightedNormals;

		// Token: 0x040086E4 RID: 34532
		internal static int __PropertyOffset_bRemoveDegenerates;

		// Token: 0x040086E5 RID: 34533
		internal static byte __PropertyMask_bRemoveDegenerates;

		// Token: 0x040086E6 RID: 34534
		internal static int __PropertyOffset_bUseHighPrecisionTangentBasis;

		// Token: 0x040086E7 RID: 34535
		internal static byte __PropertyMask_bUseHighPrecisionTangentBasis;

		// Token: 0x040086E8 RID: 34536
		internal static int __PropertyOffset_bUseFullPrecisionUVs;

		// Token: 0x040086E9 RID: 34537
		internal static byte __PropertyMask_bUseFullPrecisionUVs;

		// Token: 0x040086EA RID: 34538
		internal static int __PropertyOffset_bBuildAdjacencyBuffer;

		// Token: 0x040086EB RID: 34539
		internal static byte __PropertyMask_bBuildAdjacencyBuffer;

		// Token: 0x040086EC RID: 34540
		internal static int __PropertyOffset_ThresholdPosition;

		// Token: 0x040086ED RID: 34541
		internal static int __PropertyOffset_ThresholdTangentNormal;

		// Token: 0x040086EE RID: 34542
		internal static int __PropertyOffset_ThresholdUV;

		// Token: 0x040086EF RID: 34543
		internal static int __PropertyOffset_MorphThresholdPosition;
	}
}
