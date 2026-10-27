using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001504 RID: 5380
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.HoudiniStaticMesh")]
	[UnrealStructLayout(208, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 208)]
	public class UHoudiniStaticMesh : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060138A4 RID: 80036 RVA: 0x001CB8A6 File Offset: 0x001C9AA6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UHoudiniStaticMesh._ClassPtr;
		}

		// Token: 0x060138A5 RID: 80037 RVA: 0x001CB8B4 File Offset: 0x001C9AB4
		public UHoudiniStaticMesh() : this(BuiltinUtils.AllocNativeUObject(UHoudiniStaticMesh.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060138A6 RID: 80038 RVA: 0x001CB8DC File Offset: 0x001C9ADC
		public UHoudiniStaticMesh(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UHoudiniStaticMesh.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004C8F RID: 19599
		// (get) Token: 0x060138A7 RID: 80039 RVA: 0x001CB90F File Offset: 0x001C9B0F
		// (set) Token: 0x060138A8 RID: 80040 RVA: 0x001CB91F File Offset: 0x001C9B1F
		public unsafe bool bHasNormals
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniStaticMesh.__PropertyOffset_bHasNormals) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniStaticMesh.__PropertyOffset_bHasNormals) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004C90 RID: 19600
		// (get) Token: 0x060138A9 RID: 80041 RVA: 0x001CB930 File Offset: 0x001C9B30
		// (set) Token: 0x060138AA RID: 80042 RVA: 0x001CB940 File Offset: 0x001C9B40
		public unsafe bool bHasTangents
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniStaticMesh.__PropertyOffset_bHasTangents) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniStaticMesh.__PropertyOffset_bHasTangents) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004C91 RID: 19601
		// (get) Token: 0x060138AB RID: 80043 RVA: 0x001CB951 File Offset: 0x001C9B51
		// (set) Token: 0x060138AC RID: 80044 RVA: 0x001CB961 File Offset: 0x001C9B61
		public unsafe bool bHasColors
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniStaticMesh.__PropertyOffset_bHasColors) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniStaticMesh.__PropertyOffset_bHasColors) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004C92 RID: 19602
		// (get) Token: 0x060138AD RID: 80045 RVA: 0x001CB972 File Offset: 0x001C9B72
		// (set) Token: 0x060138AE RID: 80046 RVA: 0x001CB982 File Offset: 0x001C9B82
		public unsafe uint NumUVLayers
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniStaticMesh.__PropertyOffset_NumUVLayers);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniStaticMesh.__PropertyOffset_NumUVLayers) = (int)value;
			}
		}

		// Token: 0x17004C93 RID: 19603
		// (get) Token: 0x060138AF RID: 80047 RVA: 0x001CB993 File Offset: 0x001C9B93
		// (set) Token: 0x060138B0 RID: 80048 RVA: 0x001CB9A3 File Offset: 0x001C9BA3
		public unsafe bool bHasPerFaceMaterials
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniStaticMesh.__PropertyOffset_bHasPerFaceMaterials) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniStaticMesh.__PropertyOffset_bHasPerFaceMaterials) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004C94 RID: 19604
		// (get) Token: 0x060138B1 RID: 80049 RVA: 0x001CB9B4 File Offset: 0x001C9BB4
		// (set) Token: 0x060138B2 RID: 80050 RVA: 0x001CB9ED File Offset: 0x001C9BED
		public TArray<FVector> VertexPositions
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._VertexPositions) == null)
				{
					result = (this._VertexPositions = new TArray<FVector>(base.NativePtr + (IntPtr)UHoudiniStaticMesh.__PropertyOffset_VertexPositions, this));
				}
				return result;
			}
			set
			{
				this.VertexPositions.CopyAssign(value);
			}
		}

		// Token: 0x17004C95 RID: 19605
		// (get) Token: 0x060138B3 RID: 80051 RVA: 0x001CB9FC File Offset: 0x001C9BFC
		// (set) Token: 0x060138B4 RID: 80052 RVA: 0x001CBA35 File Offset: 0x001C9C35
		public TArray<FIntVector> TriangleIndices
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FIntVector> result;
				if ((result = this._TriangleIndices) == null)
				{
					result = (this._TriangleIndices = new TArray<FIntVector>(base.NativePtr + (IntPtr)UHoudiniStaticMesh.__PropertyOffset_TriangleIndices, this));
				}
				return result;
			}
			set
			{
				this.TriangleIndices.CopyAssign(value);
			}
		}

		// Token: 0x17004C96 RID: 19606
		// (get) Token: 0x060138B5 RID: 80053 RVA: 0x001CBA44 File Offset: 0x001C9C44
		// (set) Token: 0x060138B6 RID: 80054 RVA: 0x001CBA7D File Offset: 0x001C9C7D
		public TArray<FColor> VertexInstanceColors
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FColor> result;
				if ((result = this._VertexInstanceColors) == null)
				{
					result = (this._VertexInstanceColors = new TArray<FColor>(base.NativePtr + (IntPtr)UHoudiniStaticMesh.__PropertyOffset_VertexInstanceColors, this));
				}
				return result;
			}
			set
			{
				this.VertexInstanceColors.CopyAssign(value);
			}
		}

		// Token: 0x17004C97 RID: 19607
		// (get) Token: 0x060138B7 RID: 80055 RVA: 0x001CBA8C File Offset: 0x001C9C8C
		// (set) Token: 0x060138B8 RID: 80056 RVA: 0x001CBAC5 File Offset: 0x001C9CC5
		public TArray<FVector> VertexInstanceNormals
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._VertexInstanceNormals) == null)
				{
					result = (this._VertexInstanceNormals = new TArray<FVector>(base.NativePtr + (IntPtr)UHoudiniStaticMesh.__PropertyOffset_VertexInstanceNormals, this));
				}
				return result;
			}
			set
			{
				this.VertexInstanceNormals.CopyAssign(value);
			}
		}

		// Token: 0x17004C98 RID: 19608
		// (get) Token: 0x060138B9 RID: 80057 RVA: 0x001CBAD4 File Offset: 0x001C9CD4
		// (set) Token: 0x060138BA RID: 80058 RVA: 0x001CBB0D File Offset: 0x001C9D0D
		public TArray<FVector> VertexInstanceUTangents
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._VertexInstanceUTangents) == null)
				{
					result = (this._VertexInstanceUTangents = new TArray<FVector>(base.NativePtr + (IntPtr)UHoudiniStaticMesh.__PropertyOffset_VertexInstanceUTangents, this));
				}
				return result;
			}
			set
			{
				this.VertexInstanceUTangents.CopyAssign(value);
			}
		}

		// Token: 0x17004C99 RID: 19609
		// (get) Token: 0x060138BB RID: 80059 RVA: 0x001CBB1C File Offset: 0x001C9D1C
		// (set) Token: 0x060138BC RID: 80060 RVA: 0x001CBB55 File Offset: 0x001C9D55
		public TArray<FVector> VertexInstanceVTangents
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._VertexInstanceVTangents) == null)
				{
					result = (this._VertexInstanceVTangents = new TArray<FVector>(base.NativePtr + (IntPtr)UHoudiniStaticMesh.__PropertyOffset_VertexInstanceVTangents, this));
				}
				return result;
			}
			set
			{
				this.VertexInstanceVTangents.CopyAssign(value);
			}
		}

		// Token: 0x17004C9A RID: 19610
		// (get) Token: 0x060138BD RID: 80061 RVA: 0x001CBB64 File Offset: 0x001C9D64
		// (set) Token: 0x060138BE RID: 80062 RVA: 0x001CBB9D File Offset: 0x001C9D9D
		public TArray<FVector2D> VertexInstanceUVs
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector2D> result;
				if ((result = this._VertexInstanceUVs) == null)
				{
					result = (this._VertexInstanceUVs = new TArray<FVector2D>(base.NativePtr + (IntPtr)UHoudiniStaticMesh.__PropertyOffset_VertexInstanceUVs, this));
				}
				return result;
			}
			set
			{
				this.VertexInstanceUVs.CopyAssign(value);
			}
		}

		// Token: 0x17004C9B RID: 19611
		// (get) Token: 0x060138BF RID: 80063 RVA: 0x001CBBAC File Offset: 0x001C9DAC
		// (set) Token: 0x060138C0 RID: 80064 RVA: 0x001CBBE5 File Offset: 0x001C9DE5
		public TArray<int> MaterialIDsPerTriangle
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._MaterialIDsPerTriangle) == null)
				{
					result = (this._MaterialIDsPerTriangle = new TArray<int>(base.NativePtr + (IntPtr)UHoudiniStaticMesh.__PropertyOffset_MaterialIDsPerTriangle, this));
				}
				return result;
			}
			set
			{
				this.MaterialIDsPerTriangle.CopyAssign(value);
			}
		}

		// Token: 0x17004C9C RID: 19612
		// (get) Token: 0x060138C1 RID: 80065 RVA: 0x001CBBF4 File Offset: 0x001C9DF4
		// (set) Token: 0x060138C2 RID: 80066 RVA: 0x001CBC2D File Offset: 0x001C9E2D
		public TArray<FStaticMaterial> StaticMaterials
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FStaticMaterial> result;
				if ((result = this._StaticMaterials) == null)
				{
					result = (this._StaticMaterials = new TArray<FStaticMaterial>(base.NativePtr + (IntPtr)UHoudiniStaticMesh.__PropertyOffset_StaticMaterials, this));
				}
				return result;
			}
			set
			{
				this.StaticMaterials.CopyAssign(value);
			}
		}

		// Token: 0x060138C3 RID: 80067 RVA: 0x001CBC3B File Offset: 0x001C9E3B
		public void SetVertexPosition(uint InVertexIndex, in FVector InPosition)
		{
			UHoudiniStaticMesh.__SetVertexPosition_Internal(base.NativePtr, InVertexIndex, InPosition);
		}

		// Token: 0x060138C4 RID: 80068 RVA: 0x001CBC4A File Offset: 0x001C9E4A
		public void SetTriangleVertexVTangent(uint InTriangleIndex, byte InTriangleVertexIndex, in FVector InVTangent)
		{
			UHoudiniStaticMesh.__SetTriangleVertexVTangent_Internal(base.NativePtr, InTriangleIndex, InTriangleVertexIndex, InVTangent);
		}

		// Token: 0x060138C5 RID: 80069 RVA: 0x001CBC5A File Offset: 0x001C9E5A
		public void SetTriangleVertexUV(uint InTriangleIndex, byte InTriangleVertexIndex, byte InUVLayer, in FVector2D InUV)
		{
			UHoudiniStaticMesh.__SetTriangleVertexUV_Internal(base.NativePtr, InTriangleIndex, InTriangleVertexIndex, InUVLayer, InUV);
		}

		// Token: 0x060138C6 RID: 80070 RVA: 0x001CBC6C File Offset: 0x001C9E6C
		public void SetTriangleVertexUTangent(uint InTriangleIndex, byte InTriangleVertexIndex, in FVector InUTangent)
		{
			UHoudiniStaticMesh.__SetTriangleVertexUTangent_Internal(base.NativePtr, InTriangleIndex, InTriangleVertexIndex, InUTangent);
		}

		// Token: 0x060138C7 RID: 80071 RVA: 0x001CBC7C File Offset: 0x001C9E7C
		public void SetTriangleVertexNormal(uint InTriangleIndex, byte InTriangleVertexIndex, in FVector InNormal)
		{
			UHoudiniStaticMesh.__SetTriangleVertexNormal_Internal(base.NativePtr, InTriangleIndex, InTriangleVertexIndex, InNormal);
		}

		// Token: 0x060138C8 RID: 80072 RVA: 0x001CBC8C File Offset: 0x001C9E8C
		public void SetTriangleVertexIndices(uint InTriangleIndex, in FIntVector InTriangleVertexIndices)
		{
			UHoudiniStaticMesh.__SetTriangleVertexIndices_Internal(base.NativePtr, InTriangleIndex, InTriangleVertexIndices);
		}

		// Token: 0x060138C9 RID: 80073 RVA: 0x001CBC9B File Offset: 0x001C9E9B
		public void SetTriangleVertexColor(uint InTriangleIndex, byte InTriangleVertexIndex, in FColor InColor)
		{
			UHoudiniStaticMesh.__SetTriangleVertexColor_Internal(base.NativePtr, InTriangleIndex, InTriangleVertexIndex, InColor);
		}

		// Token: 0x060138CA RID: 80074 RVA: 0x001CBCAB File Offset: 0x001C9EAB
		public void SetTriangleMaterialID(uint InTriangleIndex, int InMaterialID)
		{
			UHoudiniStaticMesh.__SetTriangleMaterialID_Internal(base.NativePtr, InTriangleIndex, InMaterialID);
		}

		// Token: 0x060138CB RID: 80075 RVA: 0x001CBCBA File Offset: 0x001C9EBA
		[NullableContext(2)]
		public void SetStaticMaterial(uint InMaterialIndex, in FStaticMaterial InStaticMaterial)
		{
			UHoudiniStaticMesh.__SetStaticMaterial_Internal(base.NativePtr, InMaterialIndex, (InStaticMaterial ?? new FStaticMaterial()).NativePtr);
		}

		// Token: 0x060138CC RID: 80076 RVA: 0x001CBCD8 File Offset: 0x001C9ED8
		public void SetNumUVLayers(uint InNumUVLayers)
		{
			UHoudiniStaticMesh.__SetNumUVLayers_Internal(base.NativePtr, InNumUVLayers);
		}

		// Token: 0x060138CD RID: 80077 RVA: 0x001CBCE6 File Offset: 0x001C9EE6
		public void SetNumStaticMaterials(uint InNumStaticMaterials)
		{
			UHoudiniStaticMesh.__SetNumStaticMaterials_Internal(base.NativePtr, InNumStaticMaterials);
		}

		// Token: 0x060138CE RID: 80078 RVA: 0x001CBCF4 File Offset: 0x001C9EF4
		public void SetHasTangents(bool bInHasTangents)
		{
			UHoudiniStaticMesh.__SetHasTangents_Internal(base.NativePtr, bInHasTangents);
		}

		// Token: 0x060138CF RID: 80079 RVA: 0x001CBD02 File Offset: 0x001C9F02
		public void SetHasPerFaceMaterials(bool bInHasPerFaceMaterials)
		{
			UHoudiniStaticMesh.__SetHasPerFaceMaterials_Internal(base.NativePtr, bInHasPerFaceMaterials);
		}

		// Token: 0x060138D0 RID: 80080 RVA: 0x001CBD10 File Offset: 0x001C9F10
		public void SetHasNormals(bool bInHasNormals)
		{
			UHoudiniStaticMesh.__SetHasNormals_Internal(base.NativePtr, bInHasNormals);
		}

		// Token: 0x060138D1 RID: 80081 RVA: 0x001CBD1E File Offset: 0x001C9F1E
		public void SetHasColors(bool bInHasColors)
		{
			UHoudiniStaticMesh.__SetHasColors_Internal(base.NativePtr, bInHasColors);
		}

		// Token: 0x060138D2 RID: 80082 RVA: 0x001CBD2C File Offset: 0x001C9F2C
		public void Optimize()
		{
			UHoudiniStaticMesh.__Optimize_Internal(base.NativePtr);
		}

		// Token: 0x060138D3 RID: 80083 RVA: 0x001CBD39 File Offset: 0x001C9F39
		public bool IsValid(bool bInSkipVertexIndicesCheck)
		{
			return UHoudiniStaticMesh.__IsValid_Internal(base.NativePtr, bInSkipVertexIndicesCheck);
		}

		// Token: 0x060138D4 RID: 80084 RVA: 0x001CBD48 File Offset: 0x001C9F48
		public void Initialize(uint InNumVertices, uint InNumTriangles, uint InNumUVLayers, uint InInitialNumStaticMaterials, bool bInHasNormals, bool bInHasTangents, bool bInHasColors, bool bInHasPerFaceMaterials)
		{
			UHoudiniStaticMesh.__Initialize_Internal(base.NativePtr, InNumVertices, InNumTriangles, InNumUVLayers, InInitialNumStaticMaterials, bInHasNormals, bInHasTangents, bInHasColors, bInHasPerFaceMaterials);
		}

		// Token: 0x060138D5 RID: 80085 RVA: 0x001CBD6D File Offset: 0x001C9F6D
		public bool HasTangents()
		{
			return UHoudiniStaticMesh.__HasTangents_Internal(base.NativePtr);
		}

		// Token: 0x060138D6 RID: 80086 RVA: 0x001CBD7A File Offset: 0x001C9F7A
		public bool HasPerFaceMaterials()
		{
			return UHoudiniStaticMesh.__HasPerFaceMaterials_Internal(base.NativePtr);
		}

		// Token: 0x060138D7 RID: 80087 RVA: 0x001CBD87 File Offset: 0x001C9F87
		public bool HasNormals()
		{
			return UHoudiniStaticMesh.__HasNormals_Internal(base.NativePtr);
		}

		// Token: 0x060138D8 RID: 80088 RVA: 0x001CBD94 File Offset: 0x001C9F94
		public bool HasColors()
		{
			return UHoudiniStaticMesh.__HasColors_Internal(base.NativePtr);
		}

		// Token: 0x060138D9 RID: 80089 RVA: 0x001CBDA1 File Offset: 0x001C9FA1
		public TArray<FVector> GetVertexPositions()
		{
			return new TArray<FVector>(UHoudiniStaticMesh.__GetVertexPositions_Internal(base.NativePtr), null);
		}

		// Token: 0x060138DA RID: 80090 RVA: 0x001CBDB4 File Offset: 0x001C9FB4
		public TArray<FVector> GetVertexInstanceVTangents()
		{
			return new TArray<FVector>(UHoudiniStaticMesh.__GetVertexInstanceVTangents_Internal(base.NativePtr), null);
		}

		// Token: 0x060138DB RID: 80091 RVA: 0x001CBDC7 File Offset: 0x001C9FC7
		public TArray<FVector2D> GetVertexInstanceUVs()
		{
			return new TArray<FVector2D>(UHoudiniStaticMesh.__GetVertexInstanceUVs_Internal(base.NativePtr), null);
		}

		// Token: 0x060138DC RID: 80092 RVA: 0x001CBDDA File Offset: 0x001C9FDA
		public TArray<FVector> GetVertexInstanceUTangents()
		{
			return new TArray<FVector>(UHoudiniStaticMesh.__GetVertexInstanceUTangents_Internal(base.NativePtr), null);
		}

		// Token: 0x060138DD RID: 80093 RVA: 0x001CBDED File Offset: 0x001C9FED
		public TArray<FVector> GetVertexInstanceNormals()
		{
			return new TArray<FVector>(UHoudiniStaticMesh.__GetVertexInstanceNormals_Internal(base.NativePtr), null);
		}

		// Token: 0x060138DE RID: 80094 RVA: 0x001CBE00 File Offset: 0x001CA000
		public TArray<FColor> GetVertexInstanceColors()
		{
			return new TArray<FColor>(UHoudiniStaticMesh.__GetVertexInstanceColors_Internal(base.NativePtr), null);
		}

		// Token: 0x060138DF RID: 80095 RVA: 0x001CBE13 File Offset: 0x001CA013
		public TArray<FIntVector> GetTriangleIndices()
		{
			return new TArray<FIntVector>(UHoudiniStaticMesh.__GetTriangleIndices_Internal(base.NativePtr), null);
		}

		// Token: 0x060138E0 RID: 80096 RVA: 0x001CBE26 File Offset: 0x001CA026
		public TArray<FStaticMaterial> GetStaticMaterials()
		{
			return new TArray<FStaticMaterial>(UHoudiniStaticMesh.__GetStaticMaterials_Internal(base.NativePtr), null);
		}

		// Token: 0x060138E1 RID: 80097 RVA: 0x001CBE39 File Offset: 0x001CA039
		public uint GetNumVertices()
		{
			return UHoudiniStaticMesh.__GetNumVertices_Internal(base.NativePtr);
		}

		// Token: 0x060138E2 RID: 80098 RVA: 0x001CBE46 File Offset: 0x001CA046
		public uint GetNumVertexInstances()
		{
			return UHoudiniStaticMesh.__GetNumVertexInstances_Internal(base.NativePtr);
		}

		// Token: 0x060138E3 RID: 80099 RVA: 0x001CBE53 File Offset: 0x001CA053
		public uint GetNumUVLayers()
		{
			return UHoudiniStaticMesh.__GetNumUVLayers_Internal(base.NativePtr);
		}

		// Token: 0x060138E4 RID: 80100 RVA: 0x001CBE60 File Offset: 0x001CA060
		public uint GetNumTriangles()
		{
			return UHoudiniStaticMesh.__GetNumTriangles_Internal(base.NativePtr);
		}

		// Token: 0x060138E5 RID: 80101 RVA: 0x001CBE6D File Offset: 0x001CA06D
		public uint GetNumStaticMaterials()
		{
			return UHoudiniStaticMesh.__GetNumStaticMaterials_Internal(base.NativePtr);
		}

		// Token: 0x060138E6 RID: 80102 RVA: 0x001CBE7A File Offset: 0x001CA07A
		public int GetMaterialIndex(FName InMaterialSlotName)
		{
			return UHoudiniStaticMesh.__GetMaterialIndex_Internal(base.NativePtr, InMaterialSlotName);
		}

		// Token: 0x060138E7 RID: 80103 RVA: 0x001CBE88 File Offset: 0x001CA088
		public TArray<int> GetMaterialIDsPerTriangle()
		{
			return new TArray<int>(UHoudiniStaticMesh.__GetMaterialIDsPerTriangle_Internal(base.NativePtr), null);
		}

		// Token: 0x060138E8 RID: 80104 RVA: 0x001CBE9B File Offset: 0x001CA09B
		[NullableContext(2)]
		public UMaterialInterface GetMaterial(int InMaterialIndex)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UMaterialInterface>(UHoudiniStaticMesh.__GetMaterial_Internal(base.NativePtr, InMaterialIndex));
		}

		// Token: 0x060138E9 RID: 80105 RVA: 0x001CBEAE File Offset: 0x001CA0AE
		public void CalculateTangents(bool bInComputeWeightedNormals)
		{
			UHoudiniStaticMesh.__CalculateTangents_Internal(base.NativePtr, bInComputeWeightedNormals);
		}

		// Token: 0x060138EA RID: 80106 RVA: 0x001CBEBC File Offset: 0x001CA0BC
		public void CalculateNormals(bool bInComputeWeightedNormals)
		{
			UHoudiniStaticMesh.__CalculateNormals_Internal(base.NativePtr, bInComputeWeightedNormals);
		}

		// Token: 0x060138EB RID: 80107 RVA: 0x001CBECA File Offset: 0x001CA0CA
		public FBox CalcBounds()
		{
			return UHoudiniStaticMesh.__CalcBounds_Internal(base.NativePtr);
		}

		// Token: 0x060138EC RID: 80108 RVA: 0x001CBED7 File Offset: 0x001CA0D7
		[NullableContext(2)]
		public uint AddStaticMaterial(in FStaticMaterial InStaticMaterial)
		{
			return UHoudiniStaticMesh.__AddStaticMaterial_Internal(base.NativePtr, (InStaticMaterial ?? new FStaticMaterial()).NativePtr);
		}

		// Token: 0x060138ED RID: 80109
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVertexPosition_Internal(IntPtr @this, uint InVertexIndex, in FVector InPosition);

		// Token: 0x060138EE RID: 80110
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTriangleVertexVTangent_Internal(IntPtr @this, uint InTriangleIndex, byte InTriangleVertexIndex, in FVector InVTangent);

		// Token: 0x060138EF RID: 80111
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTriangleVertexUV_Internal(IntPtr @this, uint InTriangleIndex, byte InTriangleVertexIndex, byte InUVLayer, in FVector2D InUV);

		// Token: 0x060138F0 RID: 80112
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTriangleVertexUTangent_Internal(IntPtr @this, uint InTriangleIndex, byte InTriangleVertexIndex, in FVector InUTangent);

		// Token: 0x060138F1 RID: 80113
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTriangleVertexNormal_Internal(IntPtr @this, uint InTriangleIndex, byte InTriangleVertexIndex, in FVector InNormal);

		// Token: 0x060138F2 RID: 80114
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTriangleVertexIndices_Internal(IntPtr @this, uint InTriangleIndex, in FIntVector InTriangleVertexIndices);

		// Token: 0x060138F3 RID: 80115
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTriangleVertexColor_Internal(IntPtr @this, uint InTriangleIndex, byte InTriangleVertexIndex, in FColor InColor);

		// Token: 0x060138F4 RID: 80116
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTriangleMaterialID_Internal(IntPtr @this, uint InTriangleIndex, int InMaterialID);

		// Token: 0x060138F5 RID: 80117
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetStaticMaterial_Internal(IntPtr @this, uint InMaterialIndex, IntPtr InStaticMaterial);

		// Token: 0x060138F6 RID: 80118
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNumUVLayers_Internal(IntPtr @this, uint InNumUVLayers);

		// Token: 0x060138F7 RID: 80119
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNumStaticMaterials_Internal(IntPtr @this, uint InNumStaticMaterials);

		// Token: 0x060138F8 RID: 80120
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetHasTangents_Internal(IntPtr @this, bool bInHasTangents);

		// Token: 0x060138F9 RID: 80121
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetHasPerFaceMaterials_Internal(IntPtr @this, bool bInHasPerFaceMaterials);

		// Token: 0x060138FA RID: 80122
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetHasNormals_Internal(IntPtr @this, bool bInHasNormals);

		// Token: 0x060138FB RID: 80123
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetHasColors_Internal(IntPtr @this, bool bInHasColors);

		// Token: 0x060138FC RID: 80124
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Optimize_Internal(IntPtr @this);

		// Token: 0x060138FD RID: 80125
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsValid_Internal(IntPtr @this, bool bInSkipVertexIndicesCheck);

		// Token: 0x060138FE RID: 80126
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Initialize_Internal(IntPtr @this, uint InNumVertices, uint InNumTriangles, uint InNumUVLayers, uint InInitialNumStaticMaterials, bool bInHasNormals, bool bInHasTangents, bool bInHasColors, bool bInHasPerFaceMaterials);

		// Token: 0x060138FF RID: 80127
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __HasTangents_Internal(IntPtr @this);

		// Token: 0x06013900 RID: 80128
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __HasPerFaceMaterials_Internal(IntPtr @this);

		// Token: 0x06013901 RID: 80129
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __HasNormals_Internal(IntPtr @this);

		// Token: 0x06013902 RID: 80130
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __HasColors_Internal(IntPtr @this);

		// Token: 0x06013903 RID: 80131
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetVertexPositions_Internal(IntPtr @this);

		// Token: 0x06013904 RID: 80132
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetVertexInstanceVTangents_Internal(IntPtr @this);

		// Token: 0x06013905 RID: 80133
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetVertexInstanceUVs_Internal(IntPtr @this);

		// Token: 0x06013906 RID: 80134
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetVertexInstanceUTangents_Internal(IntPtr @this);

		// Token: 0x06013907 RID: 80135
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetVertexInstanceNormals_Internal(IntPtr @this);

		// Token: 0x06013908 RID: 80136
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetVertexInstanceColors_Internal(IntPtr @this);

		// Token: 0x06013909 RID: 80137
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetTriangleIndices_Internal(IntPtr @this);

		// Token: 0x0601390A RID: 80138
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetStaticMaterials_Internal(IntPtr @this);

		// Token: 0x0601390B RID: 80139
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern uint __GetNumVertices_Internal(IntPtr @this);

		// Token: 0x0601390C RID: 80140
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern uint __GetNumVertexInstances_Internal(IntPtr @this);

		// Token: 0x0601390D RID: 80141
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern uint __GetNumUVLayers_Internal(IntPtr @this);

		// Token: 0x0601390E RID: 80142
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern uint __GetNumTriangles_Internal(IntPtr @this);

		// Token: 0x0601390F RID: 80143
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern uint __GetNumStaticMaterials_Internal(IntPtr @this);

		// Token: 0x06013910 RID: 80144
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetMaterialIndex_Internal(IntPtr @this, FName InMaterialSlotName);

		// Token: 0x06013911 RID: 80145
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetMaterialIDsPerTriangle_Internal(IntPtr @this);

		// Token: 0x06013912 RID: 80146
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetMaterial_Internal(IntPtr @this, int InMaterialIndex);

		// Token: 0x06013913 RID: 80147
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CalculateTangents_Internal(IntPtr @this, bool bInComputeWeightedNormals);

		// Token: 0x06013914 RID: 80148
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CalculateNormals_Internal(IntPtr @this, bool bInComputeWeightedNormals);

		// Token: 0x06013915 RID: 80149
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FBox __CalcBounds_Internal(IntPtr @this);

		// Token: 0x06013916 RID: 80150
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern uint __AddStaticMaterial_Internal(IntPtr @this, IntPtr InStaticMaterial);

		// Token: 0x06013917 RID: 80151 RVA: 0x001CBEF4 File Offset: 0x001CA0F4
		static UHoudiniStaticMesh()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/HoudiniEngineRuntime.HoudiniStaticMesh");
		}

		// Token: 0x06013918 RID: 80152 RVA: 0x001CBF02 File Offset: 0x001CA102
		protected UHoudiniStaticMesh(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400A90C RID: 43276
		public new const string __ObjectPath = "/Script/HoudiniEngineRuntime.HoudiniStaticMesh";

		// Token: 0x0400A90D RID: 43277
		private static IntPtr _ClassPtr;

		// Token: 0x0400A90E RID: 43278
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400A90F RID: 43279
		internal static int __PropertyOffset_bHasNormals;

		// Token: 0x0400A910 RID: 43280
		internal static int __PropertyOffset_bHasTangents;

		// Token: 0x0400A911 RID: 43281
		internal static int __PropertyOffset_bHasColors;

		// Token: 0x0400A912 RID: 43282
		internal static int __PropertyOffset_NumUVLayers;

		// Token: 0x0400A913 RID: 43283
		internal static int __PropertyOffset_bHasPerFaceMaterials;

		// Token: 0x0400A914 RID: 43284
		internal static int __PropertyOffset_VertexPositions;

		// Token: 0x0400A915 RID: 43285
		[Nullable(2)]
		private TArray<FVector> _VertexPositions;

		// Token: 0x0400A916 RID: 43286
		internal static int __PropertyOffset_TriangleIndices;

		// Token: 0x0400A917 RID: 43287
		[Nullable(2)]
		private TArray<FIntVector> _TriangleIndices;

		// Token: 0x0400A918 RID: 43288
		internal static int __PropertyOffset_VertexInstanceColors;

		// Token: 0x0400A919 RID: 43289
		[Nullable(2)]
		private TArray<FColor> _VertexInstanceColors;

		// Token: 0x0400A91A RID: 43290
		internal static int __PropertyOffset_VertexInstanceNormals;

		// Token: 0x0400A91B RID: 43291
		[Nullable(2)]
		private TArray<FVector> _VertexInstanceNormals;

		// Token: 0x0400A91C RID: 43292
		internal static int __PropertyOffset_VertexInstanceUTangents;

		// Token: 0x0400A91D RID: 43293
		[Nullable(2)]
		private TArray<FVector> _VertexInstanceUTangents;

		// Token: 0x0400A91E RID: 43294
		internal static int __PropertyOffset_VertexInstanceVTangents;

		// Token: 0x0400A91F RID: 43295
		[Nullable(2)]
		private TArray<FVector> _VertexInstanceVTangents;

		// Token: 0x0400A920 RID: 43296
		internal static int __PropertyOffset_VertexInstanceUVs;

		// Token: 0x0400A921 RID: 43297
		[Nullable(2)]
		private TArray<FVector2D> _VertexInstanceUVs;

		// Token: 0x0400A922 RID: 43298
		internal static int __PropertyOffset_MaterialIDsPerTriangle;

		// Token: 0x0400A923 RID: 43299
		[Nullable(2)]
		private TArray<int> _MaterialIDsPerTriangle;

		// Token: 0x0400A924 RID: 43300
		internal static int __PropertyOffset_StaticMaterials;

		// Token: 0x0400A925 RID: 43301
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FStaticMaterial> _StaticMaterials;
	}
}
