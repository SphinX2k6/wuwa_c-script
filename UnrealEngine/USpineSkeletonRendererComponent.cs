using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020028B3 RID: 10419
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SpinePlugin.SpineSkeletonRendererComponent")]
	[UnrealStructLayout(2496, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2496)]
	public class USpineSkeletonRendererComponent : UProceduralMeshComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06026A68 RID: 158312 RVA: 0x003AF9DB File Offset: 0x003ADBDB
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USpineSkeletonRendererComponent._ClassPtr;
		}

		// Token: 0x06026A69 RID: 158313 RVA: 0x003AF9E8 File Offset: 0x003ADBE8
		public USpineSkeletonRendererComponent() : this(BuiltinUtils.AllocNativeUObject(USpineSkeletonRendererComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06026A6A RID: 158314 RVA: 0x003AFA10 File Offset: 0x003ADC10
		public USpineSkeletonRendererComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USpineSkeletonRendererComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170094F7 RID: 38135
		// (get) Token: 0x06026A6B RID: 158315 RVA: 0x003AFA43 File Offset: 0x003ADC43
		// (set) Token: 0x06026A6C RID: 158316 RVA: 0x003AFA57 File Offset: 0x003ADC57
		[Nullable(2)]
		public unsafe UMaterialInterface NormalBlendMaterial
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + USpineSkeletonRendererComponent.__PropertyOffset_NormalBlendMaterial);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + USpineSkeletonRendererComponent.__PropertyOffset_NormalBlendMaterial, value);
			}
		}

		// Token: 0x170094F8 RID: 38136
		// (get) Token: 0x06026A6D RID: 158317 RVA: 0x003AFA6C File Offset: 0x003ADC6C
		// (set) Token: 0x06026A6E RID: 158318 RVA: 0x003AFA80 File Offset: 0x003ADC80
		[Nullable(2)]
		public unsafe UMaterialInterface AdditiveBlendMaterial
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + USpineSkeletonRendererComponent.__PropertyOffset_AdditiveBlendMaterial);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + USpineSkeletonRendererComponent.__PropertyOffset_AdditiveBlendMaterial, value);
			}
		}

		// Token: 0x170094F9 RID: 38137
		// (get) Token: 0x06026A6F RID: 158319 RVA: 0x003AFA95 File Offset: 0x003ADC95
		// (set) Token: 0x06026A70 RID: 158320 RVA: 0x003AFAA9 File Offset: 0x003ADCA9
		[Nullable(2)]
		public unsafe UMaterialInterface MultiplyBlendMaterial
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + USpineSkeletonRendererComponent.__PropertyOffset_MultiplyBlendMaterial);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + USpineSkeletonRendererComponent.__PropertyOffset_MultiplyBlendMaterial, value);
			}
		}

		// Token: 0x170094FA RID: 38138
		// (get) Token: 0x06026A71 RID: 158321 RVA: 0x003AFABE File Offset: 0x003ADCBE
		// (set) Token: 0x06026A72 RID: 158322 RVA: 0x003AFAD2 File Offset: 0x003ADCD2
		[Nullable(2)]
		public unsafe UMaterialInterface ScreenBlendMaterial
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + USpineSkeletonRendererComponent.__PropertyOffset_ScreenBlendMaterial);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + USpineSkeletonRendererComponent.__PropertyOffset_ScreenBlendMaterial, value);
			}
		}

		// Token: 0x170094FB RID: 38139
		// (get) Token: 0x06026A73 RID: 158323 RVA: 0x003AFAE8 File Offset: 0x003ADCE8
		// (set) Token: 0x06026A74 RID: 158324 RVA: 0x003AFB21 File Offset: 0x003ADD21
		public TArray<UMaterialInstanceDynamic> atlasNormalBlendMaterials
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInstanceDynamic> result;
				if ((result = this._atlasNormalBlendMaterials) == null)
				{
					result = (this._atlasNormalBlendMaterials = new TArray<UMaterialInstanceDynamic>(base.NativePtr + (IntPtr)USpineSkeletonRendererComponent.__PropertyOffset_atlasNormalBlendMaterials, this));
				}
				return result;
			}
			set
			{
				this.atlasNormalBlendMaterials.CopyAssign(value);
			}
		}

		// Token: 0x170094FC RID: 38140
		// (get) Token: 0x06026A75 RID: 158325 RVA: 0x003AFB30 File Offset: 0x003ADD30
		// (set) Token: 0x06026A76 RID: 158326 RVA: 0x003AFB69 File Offset: 0x003ADD69
		public TArray<UMaterialInstanceDynamic> atlasAdditiveBlendMaterials
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInstanceDynamic> result;
				if ((result = this._atlasAdditiveBlendMaterials) == null)
				{
					result = (this._atlasAdditiveBlendMaterials = new TArray<UMaterialInstanceDynamic>(base.NativePtr + (IntPtr)USpineSkeletonRendererComponent.__PropertyOffset_atlasAdditiveBlendMaterials, this));
				}
				return result;
			}
			set
			{
				this.atlasAdditiveBlendMaterials.CopyAssign(value);
			}
		}

		// Token: 0x170094FD RID: 38141
		// (get) Token: 0x06026A77 RID: 158327 RVA: 0x003AFB78 File Offset: 0x003ADD78
		// (set) Token: 0x06026A78 RID: 158328 RVA: 0x003AFBB1 File Offset: 0x003ADDB1
		public TArray<UMaterialInstanceDynamic> atlasMultiplyBlendMaterials
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInstanceDynamic> result;
				if ((result = this._atlasMultiplyBlendMaterials) == null)
				{
					result = (this._atlasMultiplyBlendMaterials = new TArray<UMaterialInstanceDynamic>(base.NativePtr + (IntPtr)USpineSkeletonRendererComponent.__PropertyOffset_atlasMultiplyBlendMaterials, this));
				}
				return result;
			}
			set
			{
				this.atlasMultiplyBlendMaterials.CopyAssign(value);
			}
		}

		// Token: 0x170094FE RID: 38142
		// (get) Token: 0x06026A79 RID: 158329 RVA: 0x003AFBC0 File Offset: 0x003ADDC0
		// (set) Token: 0x06026A7A RID: 158330 RVA: 0x003AFBF9 File Offset: 0x003ADDF9
		public TArray<UMaterialInstanceDynamic> atlasScreenBlendMaterials
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInstanceDynamic> result;
				if ((result = this._atlasScreenBlendMaterials) == null)
				{
					result = (this._atlasScreenBlendMaterials = new TArray<UMaterialInstanceDynamic>(base.NativePtr + (IntPtr)USpineSkeletonRendererComponent.__PropertyOffset_atlasScreenBlendMaterials, this));
				}
				return result;
			}
			set
			{
				this.atlasScreenBlendMaterials.CopyAssign(value);
			}
		}

		// Token: 0x170094FF RID: 38143
		// (get) Token: 0x06026A7B RID: 158331 RVA: 0x003AFC07 File Offset: 0x003ADE07
		// (set) Token: 0x06026A7C RID: 158332 RVA: 0x003AFC17 File Offset: 0x003ADE17
		public unsafe float DepthOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USpineSkeletonRendererComponent.__PropertyOffset_DepthOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USpineSkeletonRendererComponent.__PropertyOffset_DepthOffset) = value;
			}
		}

		// Token: 0x17009500 RID: 38144
		// (get) Token: 0x06026A7D RID: 158333 RVA: 0x003AFC28 File Offset: 0x003ADE28
		// (set) Token: 0x06026A7E RID: 158334 RVA: 0x003AFC3C File Offset: 0x003ADE3C
		public unsafe FName TextureParameterName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USpineSkeletonRendererComponent.__PropertyOffset_TextureParameterName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USpineSkeletonRendererComponent.__PropertyOffset_TextureParameterName) = value;
			}
		}

		// Token: 0x17009501 RID: 38145
		// (get) Token: 0x06026A7F RID: 158335 RVA: 0x003AFC51 File Offset: 0x003ADE51
		// (set) Token: 0x06026A80 RID: 158336 RVA: 0x003AFC65 File Offset: 0x003ADE65
		public unsafe FLinearColor Color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USpineSkeletonRendererComponent.__PropertyOffset_Color);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USpineSkeletonRendererComponent.__PropertyOffset_Color) = value;
			}
		}

		// Token: 0x17009502 RID: 38146
		// (get) Token: 0x06026A81 RID: 158337 RVA: 0x003AFC7A File Offset: 0x003ADE7A
		// (set) Token: 0x06026A82 RID: 158338 RVA: 0x003AFC8A File Offset: 0x003ADE8A
		public unsafe bool bCreateCollision
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USpineSkeletonRendererComponent.__PropertyOffset_bCreateCollision) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)USpineSkeletonRendererComponent.__PropertyOffset_bCreateCollision) = (value ? 1 : 0);
			}
		}

		// Token: 0x17009503 RID: 38147
		// (get) Token: 0x06026A83 RID: 158339 RVA: 0x003AFC9C File Offset: 0x003ADE9C
		// (set) Token: 0x06026A84 RID: 158340 RVA: 0x003AFCD5 File Offset: 0x003ADED5
		public TArray<FVector> vertices
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._vertices) == null)
				{
					result = (this._vertices = new TArray<FVector>(base.NativePtr + (IntPtr)USpineSkeletonRendererComponent.__PropertyOffset_vertices, this));
				}
				return result;
			}
			set
			{
				this.vertices.CopyAssign(value);
			}
		}

		// Token: 0x17009504 RID: 38148
		// (get) Token: 0x06026A85 RID: 158341 RVA: 0x003AFCE4 File Offset: 0x003ADEE4
		// (set) Token: 0x06026A86 RID: 158342 RVA: 0x003AFD1D File Offset: 0x003ADF1D
		public TArray<int> indices
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._indices) == null)
				{
					result = (this._indices = new TArray<int>(base.NativePtr + (IntPtr)USpineSkeletonRendererComponent.__PropertyOffset_indices, this));
				}
				return result;
			}
			set
			{
				this.indices.CopyAssign(value);
			}
		}

		// Token: 0x17009505 RID: 38149
		// (get) Token: 0x06026A87 RID: 158343 RVA: 0x003AFD2C File Offset: 0x003ADF2C
		// (set) Token: 0x06026A88 RID: 158344 RVA: 0x003AFD65 File Offset: 0x003ADF65
		public TArray<FVector> normals
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._normals) == null)
				{
					result = (this._normals = new TArray<FVector>(base.NativePtr + (IntPtr)USpineSkeletonRendererComponent.__PropertyOffset_normals, this));
				}
				return result;
			}
			set
			{
				this.normals.CopyAssign(value);
			}
		}

		// Token: 0x17009506 RID: 38150
		// (get) Token: 0x06026A89 RID: 158345 RVA: 0x003AFD74 File Offset: 0x003ADF74
		// (set) Token: 0x06026A8A RID: 158346 RVA: 0x003AFDAD File Offset: 0x003ADFAD
		public TArray<FVector2D> uvs
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector2D> result;
				if ((result = this._uvs) == null)
				{
					result = (this._uvs = new TArray<FVector2D>(base.NativePtr + (IntPtr)USpineSkeletonRendererComponent.__PropertyOffset_uvs, this));
				}
				return result;
			}
			set
			{
				this.uvs.CopyAssign(value);
			}
		}

		// Token: 0x17009507 RID: 38151
		// (get) Token: 0x06026A8B RID: 158347 RVA: 0x003AFDBC File Offset: 0x003ADFBC
		// (set) Token: 0x06026A8C RID: 158348 RVA: 0x003AFDF5 File Offset: 0x003ADFF5
		public TArray<FColor> colors
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FColor> result;
				if ((result = this._colors) == null)
				{
					result = (this._colors = new TArray<FColor>(base.NativePtr + (IntPtr)USpineSkeletonRendererComponent.__PropertyOffset_colors, this));
				}
				return result;
			}
			set
			{
				this.colors.CopyAssign(value);
			}
		}

		// Token: 0x17009508 RID: 38152
		// (get) Token: 0x06026A8D RID: 158349 RVA: 0x003AFE03 File Offset: 0x003AE003
		// (set) Token: 0x06026A8E RID: 158350 RVA: 0x003AFE13 File Offset: 0x003AE013
		public unsafe bool bNeedParallelUpdate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USpineSkeletonRendererComponent.__PropertyOffset_bNeedParallelUpdate) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)USpineSkeletonRendererComponent.__PropertyOffset_bNeedParallelUpdate) = (value ? 1 : 0);
			}
		}

		// Token: 0x06026A8F RID: 158351 RVA: 0x003AFE24 File Offset: 0x003AE024
		static USpineSkeletonRendererComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SpinePlugin.SpineSkeletonRendererComponent");
		}

		// Token: 0x06026A90 RID: 158352 RVA: 0x003AFE32 File Offset: 0x003AE032
		protected USpineSkeletonRendererComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401538B RID: 86923
		public new const string __ObjectPath = "/Script/SpinePlugin.SpineSkeletonRendererComponent";

		// Token: 0x0401538C RID: 86924
		private static IntPtr _ClassPtr;

		// Token: 0x0401538D RID: 86925
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401538E RID: 86926
		internal static int __PropertyOffset_NormalBlendMaterial;

		// Token: 0x0401538F RID: 86927
		internal static int __PropertyOffset_AdditiveBlendMaterial;

		// Token: 0x04015390 RID: 86928
		internal static int __PropertyOffset_MultiplyBlendMaterial;

		// Token: 0x04015391 RID: 86929
		internal static int __PropertyOffset_ScreenBlendMaterial;

		// Token: 0x04015392 RID: 86930
		internal static int __PropertyOffset_atlasNormalBlendMaterials;

		// Token: 0x04015393 RID: 86931
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInstanceDynamic> _atlasNormalBlendMaterials;

		// Token: 0x04015394 RID: 86932
		internal static int __PropertyOffset_atlasAdditiveBlendMaterials;

		// Token: 0x04015395 RID: 86933
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInstanceDynamic> _atlasAdditiveBlendMaterials;

		// Token: 0x04015396 RID: 86934
		internal static int __PropertyOffset_atlasMultiplyBlendMaterials;

		// Token: 0x04015397 RID: 86935
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInstanceDynamic> _atlasMultiplyBlendMaterials;

		// Token: 0x04015398 RID: 86936
		internal static int __PropertyOffset_atlasScreenBlendMaterials;

		// Token: 0x04015399 RID: 86937
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInstanceDynamic> _atlasScreenBlendMaterials;

		// Token: 0x0401539A RID: 86938
		internal static int __PropertyOffset_DepthOffset;

		// Token: 0x0401539B RID: 86939
		internal static int __PropertyOffset_TextureParameterName;

		// Token: 0x0401539C RID: 86940
		internal static int __PropertyOffset_Color;

		// Token: 0x0401539D RID: 86941
		internal static int __PropertyOffset_bCreateCollision;

		// Token: 0x0401539E RID: 86942
		internal static int __PropertyOffset_vertices;

		// Token: 0x0401539F RID: 86943
		[Nullable(2)]
		private TArray<FVector> _vertices;

		// Token: 0x040153A0 RID: 86944
		internal static int __PropertyOffset_indices;

		// Token: 0x040153A1 RID: 86945
		[Nullable(2)]
		private TArray<int> _indices;

		// Token: 0x040153A2 RID: 86946
		internal static int __PropertyOffset_normals;

		// Token: 0x040153A3 RID: 86947
		[Nullable(2)]
		private TArray<FVector> _normals;

		// Token: 0x040153A4 RID: 86948
		internal static int __PropertyOffset_uvs;

		// Token: 0x040153A5 RID: 86949
		[Nullable(2)]
		private TArray<FVector2D> _uvs;

		// Token: 0x040153A6 RID: 86950
		internal static int __PropertyOffset_colors;

		// Token: 0x040153A7 RID: 86951
		[Nullable(2)]
		private TArray<FColor> _colors;

		// Token: 0x040153A8 RID: 86952
		internal static int __PropertyOffset_bNeedParallelUpdate;
	}
}
