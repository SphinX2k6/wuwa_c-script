using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000241 RID: 577
	[UnrealObjectPath("/Script/Engine.MeshBuildSettings")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FMeshBuildSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600317B RID: 12667 RVA: 0x000466AF File Offset: 0x000448AF
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMeshBuildSettings._ScriptStructPtr != 0) ? FMeshBuildSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.MeshBuildSettings", ref FMeshBuildSettings._ScriptStructPtr);
		}

		// Token: 0x170006CB RID: 1739
		// (get) Token: 0x0600317C RID: 12668 RVA: 0x000466D3 File Offset: 0x000448D3
		// (set) Token: 0x0600317D RID: 12669 RVA: 0x000466EC File Offset: 0x000448EC
		public unsafe bool bHasKuroUVUnwrap
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMeshBuildSettings.__PropertyOffset_bHasKuroUVUnwrap) & FMeshBuildSettings.__PropertyMask_bHasKuroUVUnwrap) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMeshBuildSettings.__PropertyOffset_bHasKuroUVUnwrap) = ((*(base.NativePtr + (IntPtr)FMeshBuildSettings.__PropertyOffset_bHasKuroUVUnwrap) & ~FMeshBuildSettings.__PropertyMask_bHasKuroUVUnwrap) | (value ? FMeshBuildSettings.__PropertyMask_bHasKuroUVUnwrap : 0));
			}
		}

		// Token: 0x170006CC RID: 1740
		// (get) Token: 0x0600317E RID: 12670 RVA: 0x0004671C File Offset: 0x0004491C
		// (set) Token: 0x0600317F RID: 12671 RVA: 0x00046735 File Offset: 0x00044935
		public unsafe bool bHasKuroInsideCulling
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMeshBuildSettings.__PropertyOffset_bHasKuroInsideCulling) & FMeshBuildSettings.__PropertyMask_bHasKuroInsideCulling) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMeshBuildSettings.__PropertyOffset_bHasKuroInsideCulling) = ((*(base.NativePtr + (IntPtr)FMeshBuildSettings.__PropertyOffset_bHasKuroInsideCulling) & ~FMeshBuildSettings.__PropertyMask_bHasKuroInsideCulling) | (value ? FMeshBuildSettings.__PropertyMask_bHasKuroInsideCulling : 0));
			}
		}

		// Token: 0x170006CD RID: 1741
		// (get) Token: 0x06003180 RID: 12672 RVA: 0x00046765 File Offset: 0x00044965
		// (set) Token: 0x06003181 RID: 12673 RVA: 0x0004677E File Offset: 0x0004497E
		public unsafe bool bKuroKeepRawMeshPrimIndex
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMeshBuildSettings.__PropertyOffset_bKuroKeepRawMeshPrimIndex) & FMeshBuildSettings.__PropertyMask_bKuroKeepRawMeshPrimIndex) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMeshBuildSettings.__PropertyOffset_bKuroKeepRawMeshPrimIndex) = ((*(base.NativePtr + (IntPtr)FMeshBuildSettings.__PropertyOffset_bKuroKeepRawMeshPrimIndex) & ~FMeshBuildSettings.__PropertyMask_bKuroKeepRawMeshPrimIndex) | (value ? FMeshBuildSettings.__PropertyMask_bKuroKeepRawMeshPrimIndex : 0));
			}
		}

		// Token: 0x170006CE RID: 1742
		// (get) Token: 0x06003182 RID: 12674 RVA: 0x000467AE File Offset: 0x000449AE
		// (set) Token: 0x06003183 RID: 12675 RVA: 0x000467C7 File Offset: 0x000449C7
		public unsafe bool bUseMikkTSpace
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMeshBuildSettings.__PropertyOffset_bUseMikkTSpace) & FMeshBuildSettings.__PropertyMask_bUseMikkTSpace) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMeshBuildSettings.__PropertyOffset_bUseMikkTSpace) = ((*(base.NativePtr + (IntPtr)FMeshBuildSettings.__PropertyOffset_bUseMikkTSpace) & ~FMeshBuildSettings.__PropertyMask_bUseMikkTSpace) | (value ? FMeshBuildSettings.__PropertyMask_bUseMikkTSpace : 0));
			}
		}

		// Token: 0x170006CF RID: 1743
		// (get) Token: 0x06003184 RID: 12676 RVA: 0x000467F7 File Offset: 0x000449F7
		// (set) Token: 0x06003185 RID: 12677 RVA: 0x00046810 File Offset: 0x00044A10
		public unsafe bool bRecomputeNormals
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMeshBuildSettings.__PropertyOffset_bRecomputeNormals) & FMeshBuildSettings.__PropertyMask_bRecomputeNormals) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMeshBuildSettings.__PropertyOffset_bRecomputeNormals) = ((*(base.NativePtr + (IntPtr)FMeshBuildSettings.__PropertyOffset_bRecomputeNormals) & ~FMeshBuildSettings.__PropertyMask_bRecomputeNormals) | (value ? FMeshBuildSettings.__PropertyMask_bRecomputeNormals : 0));
			}
		}

		// Token: 0x170006D0 RID: 1744
		// (get) Token: 0x06003186 RID: 12678 RVA: 0x00046840 File Offset: 0x00044A40
		// (set) Token: 0x06003187 RID: 12679 RVA: 0x00046859 File Offset: 0x00044A59
		public unsafe bool bRecomputeTangents
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMeshBuildSettings.__PropertyOffset_bRecomputeTangents) & FMeshBuildSettings.__PropertyMask_bRecomputeTangents) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMeshBuildSettings.__PropertyOffset_bRecomputeTangents) = ((*(base.NativePtr + (IntPtr)FMeshBuildSettings.__PropertyOffset_bRecomputeTangents) & ~FMeshBuildSettings.__PropertyMask_bRecomputeTangents) | (value ? FMeshBuildSettings.__PropertyMask_bRecomputeTangents : 0));
			}
		}

		// Token: 0x170006D1 RID: 1745
		// (get) Token: 0x06003188 RID: 12680 RVA: 0x00046889 File Offset: 0x00044A89
		// (set) Token: 0x06003189 RID: 12681 RVA: 0x000468A2 File Offset: 0x00044AA2
		public unsafe bool bComputeWeightedNormals
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMeshBuildSettings.__PropertyOffset_bComputeWeightedNormals) & FMeshBuildSettings.__PropertyMask_bComputeWeightedNormals) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMeshBuildSettings.__PropertyOffset_bComputeWeightedNormals) = ((*(base.NativePtr + (IntPtr)FMeshBuildSettings.__PropertyOffset_bComputeWeightedNormals) & ~FMeshBuildSettings.__PropertyMask_bComputeWeightedNormals) | (value ? FMeshBuildSettings.__PropertyMask_bComputeWeightedNormals : 0));
			}
		}

		// Token: 0x170006D2 RID: 1746
		// (get) Token: 0x0600318A RID: 12682 RVA: 0x000468D2 File Offset: 0x00044AD2
		// (set) Token: 0x0600318B RID: 12683 RVA: 0x000468EB File Offset: 0x00044AEB
		public unsafe bool bRemoveDegenerates
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMeshBuildSettings.__PropertyOffset_bRemoveDegenerates) & FMeshBuildSettings.__PropertyMask_bRemoveDegenerates) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMeshBuildSettings.__PropertyOffset_bRemoveDegenerates) = ((*(base.NativePtr + (IntPtr)FMeshBuildSettings.__PropertyOffset_bRemoveDegenerates) & ~FMeshBuildSettings.__PropertyMask_bRemoveDegenerates) | (value ? FMeshBuildSettings.__PropertyMask_bRemoveDegenerates : 0));
			}
		}

		// Token: 0x170006D3 RID: 1747
		// (get) Token: 0x0600318C RID: 12684 RVA: 0x0004691B File Offset: 0x00044B1B
		// (set) Token: 0x0600318D RID: 12685 RVA: 0x00046934 File Offset: 0x00044B34
		public unsafe bool bBuildAdjacencyBuffer
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMeshBuildSettings.__PropertyOffset_bBuildAdjacencyBuffer) & FMeshBuildSettings.__PropertyMask_bBuildAdjacencyBuffer) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMeshBuildSettings.__PropertyOffset_bBuildAdjacencyBuffer) = ((*(base.NativePtr + (IntPtr)FMeshBuildSettings.__PropertyOffset_bBuildAdjacencyBuffer) & ~FMeshBuildSettings.__PropertyMask_bBuildAdjacencyBuffer) | (value ? FMeshBuildSettings.__PropertyMask_bBuildAdjacencyBuffer : 0));
			}
		}

		// Token: 0x170006D4 RID: 1748
		// (get) Token: 0x0600318E RID: 12686 RVA: 0x00046964 File Offset: 0x00044B64
		// (set) Token: 0x0600318F RID: 12687 RVA: 0x0004697D File Offset: 0x00044B7D
		public unsafe bool bBuildReversedIndexBuffer
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMeshBuildSettings.__PropertyOffset_bBuildReversedIndexBuffer) & FMeshBuildSettings.__PropertyMask_bBuildReversedIndexBuffer) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMeshBuildSettings.__PropertyOffset_bBuildReversedIndexBuffer) = ((*(base.NativePtr + (IntPtr)FMeshBuildSettings.__PropertyOffset_bBuildReversedIndexBuffer) & ~FMeshBuildSettings.__PropertyMask_bBuildReversedIndexBuffer) | (value ? FMeshBuildSettings.__PropertyMask_bBuildReversedIndexBuffer : 0));
			}
		}

		// Token: 0x170006D5 RID: 1749
		// (get) Token: 0x06003190 RID: 12688 RVA: 0x000469AD File Offset: 0x00044BAD
		// (set) Token: 0x06003191 RID: 12689 RVA: 0x000469C6 File Offset: 0x00044BC6
		public unsafe bool bUseHighPrecisionTangentBasis
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMeshBuildSettings.__PropertyOffset_bUseHighPrecisionTangentBasis) & FMeshBuildSettings.__PropertyMask_bUseHighPrecisionTangentBasis) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMeshBuildSettings.__PropertyOffset_bUseHighPrecisionTangentBasis) = ((*(base.NativePtr + (IntPtr)FMeshBuildSettings.__PropertyOffset_bUseHighPrecisionTangentBasis) & ~FMeshBuildSettings.__PropertyMask_bUseHighPrecisionTangentBasis) | (value ? FMeshBuildSettings.__PropertyMask_bUseHighPrecisionTangentBasis : 0));
			}
		}

		// Token: 0x170006D6 RID: 1750
		// (get) Token: 0x06003192 RID: 12690 RVA: 0x000469F6 File Offset: 0x00044BF6
		// (set) Token: 0x06003193 RID: 12691 RVA: 0x00046A0F File Offset: 0x00044C0F
		public unsafe bool bUseFullPrecisionUVs
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMeshBuildSettings.__PropertyOffset_bUseFullPrecisionUVs) & FMeshBuildSettings.__PropertyMask_bUseFullPrecisionUVs) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMeshBuildSettings.__PropertyOffset_bUseFullPrecisionUVs) = ((*(base.NativePtr + (IntPtr)FMeshBuildSettings.__PropertyOffset_bUseFullPrecisionUVs) & ~FMeshBuildSettings.__PropertyMask_bUseFullPrecisionUVs) | (value ? FMeshBuildSettings.__PropertyMask_bUseFullPrecisionUVs : 0));
			}
		}

		// Token: 0x170006D7 RID: 1751
		// (get) Token: 0x06003194 RID: 12692 RVA: 0x00046A3F File Offset: 0x00044C3F
		// (set) Token: 0x06003195 RID: 12693 RVA: 0x00046A58 File Offset: 0x00044C58
		public unsafe bool bGenerateLightmapUVs
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMeshBuildSettings.__PropertyOffset_bGenerateLightmapUVs) & FMeshBuildSettings.__PropertyMask_bGenerateLightmapUVs) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMeshBuildSettings.__PropertyOffset_bGenerateLightmapUVs) = ((*(base.NativePtr + (IntPtr)FMeshBuildSettings.__PropertyOffset_bGenerateLightmapUVs) & ~FMeshBuildSettings.__PropertyMask_bGenerateLightmapUVs) | (value ? FMeshBuildSettings.__PropertyMask_bGenerateLightmapUVs : 0));
			}
		}

		// Token: 0x170006D8 RID: 1752
		// (get) Token: 0x06003196 RID: 12694 RVA: 0x00046A88 File Offset: 0x00044C88
		// (set) Token: 0x06003197 RID: 12695 RVA: 0x00046AA1 File Offset: 0x00044CA1
		public unsafe bool bUseKuroUVUnwrap
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMeshBuildSettings.__PropertyOffset_bUseKuroUVUnwrap) & FMeshBuildSettings.__PropertyMask_bUseKuroUVUnwrap) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMeshBuildSettings.__PropertyOffset_bUseKuroUVUnwrap) = ((*(base.NativePtr + (IntPtr)FMeshBuildSettings.__PropertyOffset_bUseKuroUVUnwrap) & ~FMeshBuildSettings.__PropertyMask_bUseKuroUVUnwrap) | (value ? FMeshBuildSettings.__PropertyMask_bUseKuroUVUnwrap : 0));
			}
		}

		// Token: 0x170006D9 RID: 1753
		// (get) Token: 0x06003198 RID: 12696 RVA: 0x00046AD1 File Offset: 0x00044CD1
		// (set) Token: 0x06003199 RID: 12697 RVA: 0x00046AEA File Offset: 0x00044CEA
		public unsafe bool bGenerateDistanceFieldAsIfTwoSided
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMeshBuildSettings.__PropertyOffset_bGenerateDistanceFieldAsIfTwoSided) & FMeshBuildSettings.__PropertyMask_bGenerateDistanceFieldAsIfTwoSided) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMeshBuildSettings.__PropertyOffset_bGenerateDistanceFieldAsIfTwoSided) = ((*(base.NativePtr + (IntPtr)FMeshBuildSettings.__PropertyOffset_bGenerateDistanceFieldAsIfTwoSided) & ~FMeshBuildSettings.__PropertyMask_bGenerateDistanceFieldAsIfTwoSided) | (value ? FMeshBuildSettings.__PropertyMask_bGenerateDistanceFieldAsIfTwoSided : 0));
			}
		}

		// Token: 0x170006DA RID: 1754
		// (get) Token: 0x0600319A RID: 12698 RVA: 0x00046B1A File Offset: 0x00044D1A
		// (set) Token: 0x0600319B RID: 12699 RVA: 0x00046B33 File Offset: 0x00044D33
		public unsafe bool bSupportFaceRemap
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMeshBuildSettings.__PropertyOffset_bSupportFaceRemap) & FMeshBuildSettings.__PropertyMask_bSupportFaceRemap) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMeshBuildSettings.__PropertyOffset_bSupportFaceRemap) = ((*(base.NativePtr + (IntPtr)FMeshBuildSettings.__PropertyOffset_bSupportFaceRemap) & ~FMeshBuildSettings.__PropertyMask_bSupportFaceRemap) | (value ? FMeshBuildSettings.__PropertyMask_bSupportFaceRemap : 0));
			}
		}

		// Token: 0x170006DB RID: 1755
		// (get) Token: 0x0600319C RID: 12700 RVA: 0x00046B63 File Offset: 0x00044D63
		// (set) Token: 0x0600319D RID: 12701 RVA: 0x00046B73 File Offset: 0x00044D73
		public unsafe int MinLightmapResolution
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMeshBuildSettings.__PropertyOffset_MinLightmapResolution);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMeshBuildSettings.__PropertyOffset_MinLightmapResolution) = value;
			}
		}

		// Token: 0x170006DC RID: 1756
		// (get) Token: 0x0600319E RID: 12702 RVA: 0x00046B84 File Offset: 0x00044D84
		// (set) Token: 0x0600319F RID: 12703 RVA: 0x00046B94 File Offset: 0x00044D94
		public unsafe int SrcLightmapIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMeshBuildSettings.__PropertyOffset_SrcLightmapIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMeshBuildSettings.__PropertyOffset_SrcLightmapIndex) = value;
			}
		}

		// Token: 0x170006DD RID: 1757
		// (get) Token: 0x060031A0 RID: 12704 RVA: 0x00046BA5 File Offset: 0x00044DA5
		// (set) Token: 0x060031A1 RID: 12705 RVA: 0x00046BB5 File Offset: 0x00044DB5
		public unsafe int DstLightmapIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMeshBuildSettings.__PropertyOffset_DstLightmapIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMeshBuildSettings.__PropertyOffset_DstLightmapIndex) = value;
			}
		}

		// Token: 0x170006DE RID: 1758
		// (get) Token: 0x060031A2 RID: 12706 RVA: 0x00046BC6 File Offset: 0x00044DC6
		// (set) Token: 0x060031A3 RID: 12707 RVA: 0x00046BD6 File Offset: 0x00044DD6
		public unsafe float BuildScale_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMeshBuildSettings.__PropertyOffset_BuildScale_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMeshBuildSettings.__PropertyOffset_BuildScale_DEPRECATED) = value;
			}
		}

		// Token: 0x170006DF RID: 1759
		// (get) Token: 0x060031A4 RID: 12708 RVA: 0x00046BE7 File Offset: 0x00044DE7
		// (set) Token: 0x060031A5 RID: 12709 RVA: 0x00046BFB File Offset: 0x00044DFB
		public unsafe FVector BuildScale3D
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMeshBuildSettings.__PropertyOffset_BuildScale3D);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMeshBuildSettings.__PropertyOffset_BuildScale3D) = value;
			}
		}

		// Token: 0x170006E0 RID: 1760
		// (get) Token: 0x060031A6 RID: 12710 RVA: 0x00046C10 File Offset: 0x00044E10
		// (set) Token: 0x060031A7 RID: 12711 RVA: 0x00046C20 File Offset: 0x00044E20
		public unsafe float DistanceFieldResolutionScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMeshBuildSettings.__PropertyOffset_DistanceFieldResolutionScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMeshBuildSettings.__PropertyOffset_DistanceFieldResolutionScale) = value;
			}
		}

		// Token: 0x170006E1 RID: 1761
		// (get) Token: 0x060031A8 RID: 12712 RVA: 0x00046C31 File Offset: 0x00044E31
		// (set) Token: 0x060031A9 RID: 12713 RVA: 0x00046C45 File Offset: 0x00044E45
		[Nullable(2)]
		public unsafe UStaticMesh DistanceFieldReplacementMesh
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + FMeshBuildSettings.__PropertyOffset_DistanceFieldReplacementMesh);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FMeshBuildSettings.__PropertyOffset_DistanceFieldReplacementMesh, value);
			}
		}

		// Token: 0x060031AA RID: 12714 RVA: 0x00046C5A File Offset: 0x00044E5A
		public FMeshBuildSettings()
		{
		}

		// Token: 0x060031AB RID: 12715 RVA: 0x00046C62 File Offset: 0x00044E62
		protected override IntPtr GetUStructPtr()
		{
			return FMeshBuildSettings.StaticStruct();
		}

		// Token: 0x060031AC RID: 12716 RVA: 0x00046C6E File Offset: 0x00044E6E
		[NullableContext(2)]
		public FMeshBuildSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060031AD RID: 12717 RVA: 0x00046C78 File Offset: 0x00044E78
		public FMeshBuildSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060031AE RID: 12718 RVA: 0x00046C83 File Offset: 0x00044E83
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMeshBuildSettings(Pointer, false, true);
		}

		// Token: 0x060031AF RID: 12719 RVA: 0x00046C8D File Offset: 0x00044E8D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMeshBuildSettings(Pointer, MemoryOwner);
		}

		// Token: 0x040010F8 RID: 4344
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.MeshBuildSettings";

		// Token: 0x040010F9 RID: 4345
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040010FA RID: 4346
		internal static int __PropertyOffset_bHasKuroUVUnwrap;

		// Token: 0x040010FB RID: 4347
		internal static byte __PropertyMask_bHasKuroUVUnwrap;

		// Token: 0x040010FC RID: 4348
		internal static int __PropertyOffset_bHasKuroInsideCulling;

		// Token: 0x040010FD RID: 4349
		internal static byte __PropertyMask_bHasKuroInsideCulling;

		// Token: 0x040010FE RID: 4350
		internal static int __PropertyOffset_bKuroKeepRawMeshPrimIndex;

		// Token: 0x040010FF RID: 4351
		internal static byte __PropertyMask_bKuroKeepRawMeshPrimIndex;

		// Token: 0x04001100 RID: 4352
		internal static int __PropertyOffset_bUseMikkTSpace;

		// Token: 0x04001101 RID: 4353
		internal static byte __PropertyMask_bUseMikkTSpace;

		// Token: 0x04001102 RID: 4354
		internal static int __PropertyOffset_bRecomputeNormals;

		// Token: 0x04001103 RID: 4355
		internal static byte __PropertyMask_bRecomputeNormals;

		// Token: 0x04001104 RID: 4356
		internal static int __PropertyOffset_bRecomputeTangents;

		// Token: 0x04001105 RID: 4357
		internal static byte __PropertyMask_bRecomputeTangents;

		// Token: 0x04001106 RID: 4358
		internal static int __PropertyOffset_bComputeWeightedNormals;

		// Token: 0x04001107 RID: 4359
		internal static byte __PropertyMask_bComputeWeightedNormals;

		// Token: 0x04001108 RID: 4360
		internal static int __PropertyOffset_bRemoveDegenerates;

		// Token: 0x04001109 RID: 4361
		internal static byte __PropertyMask_bRemoveDegenerates;

		// Token: 0x0400110A RID: 4362
		internal static int __PropertyOffset_bBuildAdjacencyBuffer;

		// Token: 0x0400110B RID: 4363
		internal static byte __PropertyMask_bBuildAdjacencyBuffer;

		// Token: 0x0400110C RID: 4364
		internal static int __PropertyOffset_bBuildReversedIndexBuffer;

		// Token: 0x0400110D RID: 4365
		internal static byte __PropertyMask_bBuildReversedIndexBuffer;

		// Token: 0x0400110E RID: 4366
		internal static int __PropertyOffset_bUseHighPrecisionTangentBasis;

		// Token: 0x0400110F RID: 4367
		internal static byte __PropertyMask_bUseHighPrecisionTangentBasis;

		// Token: 0x04001110 RID: 4368
		internal static int __PropertyOffset_bUseFullPrecisionUVs;

		// Token: 0x04001111 RID: 4369
		internal static byte __PropertyMask_bUseFullPrecisionUVs;

		// Token: 0x04001112 RID: 4370
		internal static int __PropertyOffset_bGenerateLightmapUVs;

		// Token: 0x04001113 RID: 4371
		internal static byte __PropertyMask_bGenerateLightmapUVs;

		// Token: 0x04001114 RID: 4372
		internal static int __PropertyOffset_bUseKuroUVUnwrap;

		// Token: 0x04001115 RID: 4373
		internal static byte __PropertyMask_bUseKuroUVUnwrap;

		// Token: 0x04001116 RID: 4374
		internal static int __PropertyOffset_bGenerateDistanceFieldAsIfTwoSided;

		// Token: 0x04001117 RID: 4375
		internal static byte __PropertyMask_bGenerateDistanceFieldAsIfTwoSided;

		// Token: 0x04001118 RID: 4376
		internal static int __PropertyOffset_bSupportFaceRemap;

		// Token: 0x04001119 RID: 4377
		internal static byte __PropertyMask_bSupportFaceRemap;

		// Token: 0x0400111A RID: 4378
		internal static int __PropertyOffset_MinLightmapResolution;

		// Token: 0x0400111B RID: 4379
		internal static int __PropertyOffset_SrcLightmapIndex;

		// Token: 0x0400111C RID: 4380
		internal static int __PropertyOffset_DstLightmapIndex;

		// Token: 0x0400111D RID: 4381
		internal static int __PropertyOffset_BuildScale_DEPRECATED;

		// Token: 0x0400111E RID: 4382
		internal static int __PropertyOffset_BuildScale3D;

		// Token: 0x0400111F RID: 4383
		internal static int __PropertyOffset_DistanceFieldResolutionScale;

		// Token: 0x04001120 RID: 4384
		internal static int __PropertyOffset_DistanceFieldReplacementMesh;
	}
}
