using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000EA7 RID: 3751
	[UnrealObjectPath("/Script/Engine.MeshReductionSettings")]
	[UnrealStructLayout(36, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 36)]
	public class FMeshReductionSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600CADE RID: 51934 RVA: 0x00127A08 File Offset: 0x00125C08
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMeshReductionSettings._ScriptStructPtr != 0) ? FMeshReductionSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.MeshReductionSettings", ref FMeshReductionSettings._ScriptStructPtr);
		}

		// Token: 0x17002FB0 RID: 12208
		// (get) Token: 0x0600CADF RID: 51935 RVA: 0x00127A2C File Offset: 0x00125C2C
		// (set) Token: 0x0600CAE0 RID: 51936 RVA: 0x00127A3C File Offset: 0x00125C3C
		public unsafe float PercentTriangles
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMeshReductionSettings.__PropertyOffset_PercentTriangles);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMeshReductionSettings.__PropertyOffset_PercentTriangles) = value;
			}
		}

		// Token: 0x17002FB1 RID: 12209
		// (get) Token: 0x0600CAE1 RID: 51937 RVA: 0x00127A4D File Offset: 0x00125C4D
		// (set) Token: 0x0600CAE2 RID: 51938 RVA: 0x00127A5D File Offset: 0x00125C5D
		public unsafe float PercentVertices
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMeshReductionSettings.__PropertyOffset_PercentVertices);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMeshReductionSettings.__PropertyOffset_PercentVertices) = value;
			}
		}

		// Token: 0x17002FB2 RID: 12210
		// (get) Token: 0x0600CAE3 RID: 51939 RVA: 0x00127A6E File Offset: 0x00125C6E
		// (set) Token: 0x0600CAE4 RID: 51940 RVA: 0x00127A7E File Offset: 0x00125C7E
		public unsafe float MaxDeviation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMeshReductionSettings.__PropertyOffset_MaxDeviation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMeshReductionSettings.__PropertyOffset_MaxDeviation) = value;
			}
		}

		// Token: 0x17002FB3 RID: 12211
		// (get) Token: 0x0600CAE5 RID: 51941 RVA: 0x00127A8F File Offset: 0x00125C8F
		// (set) Token: 0x0600CAE6 RID: 51942 RVA: 0x00127A9F File Offset: 0x00125C9F
		public unsafe float PixelError
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMeshReductionSettings.__PropertyOffset_PixelError);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMeshReductionSettings.__PropertyOffset_PixelError) = value;
			}
		}

		// Token: 0x17002FB4 RID: 12212
		// (get) Token: 0x0600CAE7 RID: 51943 RVA: 0x00127AB0 File Offset: 0x00125CB0
		// (set) Token: 0x0600CAE8 RID: 51944 RVA: 0x00127AC0 File Offset: 0x00125CC0
		public unsafe float WeldingThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMeshReductionSettings.__PropertyOffset_WeldingThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMeshReductionSettings.__PropertyOffset_WeldingThreshold) = value;
			}
		}

		// Token: 0x17002FB5 RID: 12213
		// (get) Token: 0x0600CAE9 RID: 51945 RVA: 0x00127AD1 File Offset: 0x00125CD1
		// (set) Token: 0x0600CAEA RID: 51946 RVA: 0x00127AE1 File Offset: 0x00125CE1
		public unsafe float HardAngleThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMeshReductionSettings.__PropertyOffset_HardAngleThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMeshReductionSettings.__PropertyOffset_HardAngleThreshold) = value;
			}
		}

		// Token: 0x17002FB6 RID: 12214
		// (get) Token: 0x0600CAEB RID: 51947 RVA: 0x00127AF2 File Offset: 0x00125CF2
		// (set) Token: 0x0600CAEC RID: 51948 RVA: 0x00127B02 File Offset: 0x00125D02
		public unsafe int BaseLODModel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMeshReductionSettings.__PropertyOffset_BaseLODModel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMeshReductionSettings.__PropertyOffset_BaseLODModel) = value;
			}
		}

		// Token: 0x17002FB7 RID: 12215
		// (get) Token: 0x0600CAED RID: 51949 RVA: 0x00127B13 File Offset: 0x00125D13
		// (set) Token: 0x0600CAEE RID: 51950 RVA: 0x00127B27 File Offset: 0x00125D27
		public unsafe TEnumAsByte<EMeshFeatureImportance> SilhouetteImportance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMeshReductionSettings.__PropertyOffset_SilhouetteImportance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMeshReductionSettings.__PropertyOffset_SilhouetteImportance) = value;
			}
		}

		// Token: 0x17002FB8 RID: 12216
		// (get) Token: 0x0600CAEF RID: 51951 RVA: 0x00127B3C File Offset: 0x00125D3C
		// (set) Token: 0x0600CAF0 RID: 51952 RVA: 0x00127B50 File Offset: 0x00125D50
		public unsafe TEnumAsByte<EMeshFeatureImportance> TextureImportance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMeshReductionSettings.__PropertyOffset_TextureImportance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMeshReductionSettings.__PropertyOffset_TextureImportance) = value;
			}
		}

		// Token: 0x17002FB9 RID: 12217
		// (get) Token: 0x0600CAF1 RID: 51953 RVA: 0x00127B65 File Offset: 0x00125D65
		// (set) Token: 0x0600CAF2 RID: 51954 RVA: 0x00127B79 File Offset: 0x00125D79
		public unsafe TEnumAsByte<EMeshFeatureImportance> ShadingImportance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMeshReductionSettings.__PropertyOffset_ShadingImportance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMeshReductionSettings.__PropertyOffset_ShadingImportance) = value;
			}
		}

		// Token: 0x17002FBA RID: 12218
		// (get) Token: 0x0600CAF3 RID: 51955 RVA: 0x00127B8E File Offset: 0x00125D8E
		// (set) Token: 0x0600CAF4 RID: 51956 RVA: 0x00127BA7 File Offset: 0x00125DA7
		public unsafe bool bRecalculateNormals
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMeshReductionSettings.__PropertyOffset_bRecalculateNormals) & FMeshReductionSettings.__PropertyMask_bRecalculateNormals) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMeshReductionSettings.__PropertyOffset_bRecalculateNormals) = ((*(base.NativePtr + (IntPtr)FMeshReductionSettings.__PropertyOffset_bRecalculateNormals) & ~FMeshReductionSettings.__PropertyMask_bRecalculateNormals) | (value ? FMeshReductionSettings.__PropertyMask_bRecalculateNormals : 0));
			}
		}

		// Token: 0x17002FBB RID: 12219
		// (get) Token: 0x0600CAF5 RID: 51957 RVA: 0x00127BD7 File Offset: 0x00125DD7
		// (set) Token: 0x0600CAF6 RID: 51958 RVA: 0x00127BF0 File Offset: 0x00125DF0
		public unsafe bool bGenerateUniqueLightmapUVs
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMeshReductionSettings.__PropertyOffset_bGenerateUniqueLightmapUVs) & FMeshReductionSettings.__PropertyMask_bGenerateUniqueLightmapUVs) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMeshReductionSettings.__PropertyOffset_bGenerateUniqueLightmapUVs) = ((*(base.NativePtr + (IntPtr)FMeshReductionSettings.__PropertyOffset_bGenerateUniqueLightmapUVs) & ~FMeshReductionSettings.__PropertyMask_bGenerateUniqueLightmapUVs) | (value ? FMeshReductionSettings.__PropertyMask_bGenerateUniqueLightmapUVs : 0));
			}
		}

		// Token: 0x17002FBC RID: 12220
		// (get) Token: 0x0600CAF7 RID: 51959 RVA: 0x00127C20 File Offset: 0x00125E20
		// (set) Token: 0x0600CAF8 RID: 51960 RVA: 0x00127C39 File Offset: 0x00125E39
		public unsafe bool bKeepSymmetry
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMeshReductionSettings.__PropertyOffset_bKeepSymmetry) & FMeshReductionSettings.__PropertyMask_bKeepSymmetry) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMeshReductionSettings.__PropertyOffset_bKeepSymmetry) = ((*(base.NativePtr + (IntPtr)FMeshReductionSettings.__PropertyOffset_bKeepSymmetry) & ~FMeshReductionSettings.__PropertyMask_bKeepSymmetry) | (value ? FMeshReductionSettings.__PropertyMask_bKeepSymmetry : 0));
			}
		}

		// Token: 0x17002FBD RID: 12221
		// (get) Token: 0x0600CAF9 RID: 51961 RVA: 0x00127C69 File Offset: 0x00125E69
		// (set) Token: 0x0600CAFA RID: 51962 RVA: 0x00127C82 File Offset: 0x00125E82
		public unsafe bool bVisibilityAided
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMeshReductionSettings.__PropertyOffset_bVisibilityAided) & FMeshReductionSettings.__PropertyMask_bVisibilityAided) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMeshReductionSettings.__PropertyOffset_bVisibilityAided) = ((*(base.NativePtr + (IntPtr)FMeshReductionSettings.__PropertyOffset_bVisibilityAided) & ~FMeshReductionSettings.__PropertyMask_bVisibilityAided) | (value ? FMeshReductionSettings.__PropertyMask_bVisibilityAided : 0));
			}
		}

		// Token: 0x17002FBE RID: 12222
		// (get) Token: 0x0600CAFB RID: 51963 RVA: 0x00127CB2 File Offset: 0x00125EB2
		// (set) Token: 0x0600CAFC RID: 51964 RVA: 0x00127CCB File Offset: 0x00125ECB
		public unsafe bool bCullOccluded
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMeshReductionSettings.__PropertyOffset_bCullOccluded) & FMeshReductionSettings.__PropertyMask_bCullOccluded) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMeshReductionSettings.__PropertyOffset_bCullOccluded) = ((*(base.NativePtr + (IntPtr)FMeshReductionSettings.__PropertyOffset_bCullOccluded) & ~FMeshReductionSettings.__PropertyMask_bCullOccluded) | (value ? FMeshReductionSettings.__PropertyMask_bCullOccluded : 0));
			}
		}

		// Token: 0x17002FBF RID: 12223
		// (get) Token: 0x0600CAFD RID: 51965 RVA: 0x00127CFB File Offset: 0x00125EFB
		// (set) Token: 0x0600CAFE RID: 51966 RVA: 0x00127D14 File Offset: 0x00125F14
		public unsafe bool bProtectProfile
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMeshReductionSettings.__PropertyOffset_bProtectProfile) & FMeshReductionSettings.__PropertyMask_bProtectProfile) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMeshReductionSettings.__PropertyOffset_bProtectProfile) = ((*(base.NativePtr + (IntPtr)FMeshReductionSettings.__PropertyOffset_bProtectProfile) & ~FMeshReductionSettings.__PropertyMask_bProtectProfile) | (value ? FMeshReductionSettings.__PropertyMask_bProtectProfile : 0));
			}
		}

		// Token: 0x17002FC0 RID: 12224
		// (get) Token: 0x0600CAFF RID: 51967 RVA: 0x00127D44 File Offset: 0x00125F44
		// (set) Token: 0x0600CB00 RID: 51968 RVA: 0x00127D5D File Offset: 0x00125F5D
		public unsafe bool bAlreadyProtectProfile
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMeshReductionSettings.__PropertyOffset_bAlreadyProtectProfile) & FMeshReductionSettings.__PropertyMask_bAlreadyProtectProfile) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMeshReductionSettings.__PropertyOffset_bAlreadyProtectProfile) = ((*(base.NativePtr + (IntPtr)FMeshReductionSettings.__PropertyOffset_bAlreadyProtectProfile) & ~FMeshReductionSettings.__PropertyMask_bAlreadyProtectProfile) | (value ? FMeshReductionSettings.__PropertyMask_bAlreadyProtectProfile : 0));
			}
		}

		// Token: 0x17002FC1 RID: 12225
		// (get) Token: 0x0600CB01 RID: 51969 RVA: 0x00127D8D File Offset: 0x00125F8D
		// (set) Token: 0x0600CB02 RID: 51970 RVA: 0x00127DA6 File Offset: 0x00125FA6
		public unsafe bool bInsideCulling
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMeshReductionSettings.__PropertyOffset_bInsideCulling) & FMeshReductionSettings.__PropertyMask_bInsideCulling) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMeshReductionSettings.__PropertyOffset_bInsideCulling) = ((*(base.NativePtr + (IntPtr)FMeshReductionSettings.__PropertyOffset_bInsideCulling) & ~FMeshReductionSettings.__PropertyMask_bInsideCulling) | (value ? FMeshReductionSettings.__PropertyMask_bInsideCulling : 0));
			}
		}

		// Token: 0x17002FC2 RID: 12226
		// (get) Token: 0x0600CB03 RID: 51971 RVA: 0x00127DD6 File Offset: 0x00125FD6
		// (set) Token: 0x0600CB04 RID: 51972 RVA: 0x00127DEF File Offset: 0x00125FEF
		public unsafe bool bUVUnwrap
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMeshReductionSettings.__PropertyOffset_bUVUnwrap) & FMeshReductionSettings.__PropertyMask_bUVUnwrap) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMeshReductionSettings.__PropertyOffset_bUVUnwrap) = ((*(base.NativePtr + (IntPtr)FMeshReductionSettings.__PropertyOffset_bUVUnwrap) & ~FMeshReductionSettings.__PropertyMask_bUVUnwrap) | (value ? FMeshReductionSettings.__PropertyMask_bUVUnwrap : 0));
			}
		}

		// Token: 0x17002FC3 RID: 12227
		// (get) Token: 0x0600CB05 RID: 51973 RVA: 0x00127E1F File Offset: 0x0012601F
		// (set) Token: 0x0600CB06 RID: 51974 RVA: 0x00127E2F File Offset: 0x0012602F
		public unsafe EStaticMeshReductionTerimationCriterion TerminationCriterion
		{
			get
			{
				return (EStaticMeshReductionTerimationCriterion)(*(base.NativePtr + (IntPtr)FMeshReductionSettings.__PropertyOffset_TerminationCriterion));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMeshReductionSettings.__PropertyOffset_TerminationCriterion) = (byte)value;
			}
		}

		// Token: 0x17002FC4 RID: 12228
		// (get) Token: 0x0600CB07 RID: 51975 RVA: 0x00127E40 File Offset: 0x00126040
		// (set) Token: 0x0600CB08 RID: 51976 RVA: 0x00127E54 File Offset: 0x00126054
		public unsafe TEnumAsByte<EMeshFeatureImportance> VisibilityAggressiveness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMeshReductionSettings.__PropertyOffset_VisibilityAggressiveness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMeshReductionSettings.__PropertyOffset_VisibilityAggressiveness) = value;
			}
		}

		// Token: 0x17002FC5 RID: 12229
		// (get) Token: 0x0600CB09 RID: 51977 RVA: 0x00127E69 File Offset: 0x00126069
		// (set) Token: 0x0600CB0A RID: 51978 RVA: 0x00127E7D File Offset: 0x0012607D
		public unsafe TEnumAsByte<EMeshFeatureImportance> VertexColorImportance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMeshReductionSettings.__PropertyOffset_VertexColorImportance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMeshReductionSettings.__PropertyOffset_VertexColorImportance) = value;
			}
		}

		// Token: 0x0600CB0B RID: 51979 RVA: 0x00127E92 File Offset: 0x00126092
		public FMeshReductionSettings()
		{
		}

		// Token: 0x0600CB0C RID: 51980 RVA: 0x00127E9C File Offset: 0x0012609C
		public FMeshReductionSettings(float PercentTriangles, float PercentVertices, float MaxDeviation, float PixelError, float WeldingThreshold, float HardAngleThreshold, int BaseLODModel, TEnumAsByte<EMeshFeatureImportance> SilhouetteImportance, TEnumAsByte<EMeshFeatureImportance> TextureImportance, TEnumAsByte<EMeshFeatureImportance> ShadingImportance, bool bRecalculateNormals, bool bGenerateUniqueLightmapUVs, bool bKeepSymmetry, bool bVisibilityAided, bool bCullOccluded, bool bProtectProfile, bool bAlreadyProtectProfile, bool bInsideCulling, bool bUVUnwrap, EStaticMeshReductionTerimationCriterion TerminationCriterion, TEnumAsByte<EMeshFeatureImportance> VisibilityAggressiveness, TEnumAsByte<EMeshFeatureImportance> VertexColorImportance)
		{
			this.PercentTriangles = PercentTriangles;
			this.PercentVertices = PercentVertices;
			this.MaxDeviation = MaxDeviation;
			this.PixelError = PixelError;
			this.WeldingThreshold = WeldingThreshold;
			this.HardAngleThreshold = HardAngleThreshold;
			this.BaseLODModel = BaseLODModel;
			this.SilhouetteImportance = SilhouetteImportance;
			this.TextureImportance = TextureImportance;
			this.ShadingImportance = ShadingImportance;
			this.bRecalculateNormals = bRecalculateNormals;
			this.bGenerateUniqueLightmapUVs = bGenerateUniqueLightmapUVs;
			this.bKeepSymmetry = bKeepSymmetry;
			this.bVisibilityAided = bVisibilityAided;
			this.bCullOccluded = bCullOccluded;
			this.bProtectProfile = bProtectProfile;
			this.bAlreadyProtectProfile = bAlreadyProtectProfile;
			this.bInsideCulling = bInsideCulling;
			this.bUVUnwrap = bUVUnwrap;
			this.TerminationCriterion = TerminationCriterion;
			this.VisibilityAggressiveness = VisibilityAggressiveness;
			this.VertexColorImportance = VertexColorImportance;
		}

		// Token: 0x0600CB0D RID: 51981 RVA: 0x00127F5C File Offset: 0x0012615C
		protected override IntPtr GetUStructPtr()
		{
			return FMeshReductionSettings.StaticStruct();
		}

		// Token: 0x0600CB0E RID: 51982 RVA: 0x00127F68 File Offset: 0x00126168
		[NullableContext(2)]
		public FMeshReductionSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600CB0F RID: 51983 RVA: 0x00127F72 File Offset: 0x00126172
		public FMeshReductionSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600CB10 RID: 51984 RVA: 0x00127F7D File Offset: 0x0012617D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMeshReductionSettings(Pointer, false, true);
		}

		// Token: 0x0600CB11 RID: 51985 RVA: 0x00127F87 File Offset: 0x00126187
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMeshReductionSettings(Pointer, MemoryOwner);
		}

		// Token: 0x04006D4C RID: 27980
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.MeshReductionSettings";

		// Token: 0x04006D4D RID: 27981
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04006D4E RID: 27982
		internal static int __PropertyOffset_PercentTriangles;

		// Token: 0x04006D4F RID: 27983
		internal static int __PropertyOffset_PercentVertices;

		// Token: 0x04006D50 RID: 27984
		internal static int __PropertyOffset_MaxDeviation;

		// Token: 0x04006D51 RID: 27985
		internal static int __PropertyOffset_PixelError;

		// Token: 0x04006D52 RID: 27986
		internal static int __PropertyOffset_WeldingThreshold;

		// Token: 0x04006D53 RID: 27987
		internal static int __PropertyOffset_HardAngleThreshold;

		// Token: 0x04006D54 RID: 27988
		internal static int __PropertyOffset_BaseLODModel;

		// Token: 0x04006D55 RID: 27989
		internal static int __PropertyOffset_SilhouetteImportance;

		// Token: 0x04006D56 RID: 27990
		internal static int __PropertyOffset_TextureImportance;

		// Token: 0x04006D57 RID: 27991
		internal static int __PropertyOffset_ShadingImportance;

		// Token: 0x04006D58 RID: 27992
		internal static int __PropertyOffset_bRecalculateNormals;

		// Token: 0x04006D59 RID: 27993
		internal static byte __PropertyMask_bRecalculateNormals;

		// Token: 0x04006D5A RID: 27994
		internal static int __PropertyOffset_bGenerateUniqueLightmapUVs;

		// Token: 0x04006D5B RID: 27995
		internal static byte __PropertyMask_bGenerateUniqueLightmapUVs;

		// Token: 0x04006D5C RID: 27996
		internal static int __PropertyOffset_bKeepSymmetry;

		// Token: 0x04006D5D RID: 27997
		internal static byte __PropertyMask_bKeepSymmetry;

		// Token: 0x04006D5E RID: 27998
		internal static int __PropertyOffset_bVisibilityAided;

		// Token: 0x04006D5F RID: 27999
		internal static byte __PropertyMask_bVisibilityAided;

		// Token: 0x04006D60 RID: 28000
		internal static int __PropertyOffset_bCullOccluded;

		// Token: 0x04006D61 RID: 28001
		internal static byte __PropertyMask_bCullOccluded;

		// Token: 0x04006D62 RID: 28002
		internal static int __PropertyOffset_bProtectProfile;

		// Token: 0x04006D63 RID: 28003
		internal static byte __PropertyMask_bProtectProfile;

		// Token: 0x04006D64 RID: 28004
		internal static int __PropertyOffset_bAlreadyProtectProfile;

		// Token: 0x04006D65 RID: 28005
		internal static byte __PropertyMask_bAlreadyProtectProfile;

		// Token: 0x04006D66 RID: 28006
		internal static int __PropertyOffset_bInsideCulling;

		// Token: 0x04006D67 RID: 28007
		internal static byte __PropertyMask_bInsideCulling;

		// Token: 0x04006D68 RID: 28008
		internal static int __PropertyOffset_bUVUnwrap;

		// Token: 0x04006D69 RID: 28009
		internal static byte __PropertyMask_bUVUnwrap;

		// Token: 0x04006D6A RID: 28010
		internal static int __PropertyOffset_TerminationCriterion;

		// Token: 0x04006D6B RID: 28011
		internal static int __PropertyOffset_VisibilityAggressiveness;

		// Token: 0x04006D6C RID: 28012
		internal static int __PropertyOffset_VertexColorImportance;
	}
}
