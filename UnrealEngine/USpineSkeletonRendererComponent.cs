using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000842 RID: 2114
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SpinePlugin.SpineSkeletonRendererComponent")]
	[UnrealStructLayout(2496, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2496)]
	public class USpineSkeletonRendererComponent : UProceduralMeshComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600B854 RID: 47188 RVA: 0x001276EF File Offset: 0x001258EF
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USpineSkeletonRendererComponent._ClassPtr;
		}

		// Token: 0x0600B855 RID: 47189 RVA: 0x001276FC File Offset: 0x001258FC
		public USpineSkeletonRendererComponent() : this(BuiltinUtils.AllocNativeUObject(USpineSkeletonRendererComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600B856 RID: 47190 RVA: 0x00127724 File Offset: 0x00125924
		public USpineSkeletonRendererComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USpineSkeletonRendererComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002261 RID: 8801
		// (get) Token: 0x0600B857 RID: 47191 RVA: 0x00127757 File Offset: 0x00125957
		// (set) Token: 0x0600B858 RID: 47192 RVA: 0x0012776B File Offset: 0x0012596B
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

		// Token: 0x17002262 RID: 8802
		// (get) Token: 0x0600B859 RID: 47193 RVA: 0x00127780 File Offset: 0x00125980
		// (set) Token: 0x0600B85A RID: 47194 RVA: 0x00127794 File Offset: 0x00125994
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

		// Token: 0x17002263 RID: 8803
		// (get) Token: 0x0600B85B RID: 47195 RVA: 0x001277A9 File Offset: 0x001259A9
		// (set) Token: 0x0600B85C RID: 47196 RVA: 0x001277BD File Offset: 0x001259BD
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

		// Token: 0x17002264 RID: 8804
		// (get) Token: 0x0600B85D RID: 47197 RVA: 0x001277D2 File Offset: 0x001259D2
		// (set) Token: 0x0600B85E RID: 47198 RVA: 0x001277E6 File Offset: 0x001259E6
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

		// Token: 0x17002265 RID: 8805
		// (get) Token: 0x0600B85F RID: 47199 RVA: 0x001277FC File Offset: 0x001259FC
		// (set) Token: 0x0600B860 RID: 47200 RVA: 0x00127835 File Offset: 0x00125A35
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

		// Token: 0x17002266 RID: 8806
		// (get) Token: 0x0600B861 RID: 47201 RVA: 0x00127844 File Offset: 0x00125A44
		// (set) Token: 0x0600B862 RID: 47202 RVA: 0x0012787D File Offset: 0x00125A7D
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

		// Token: 0x17002267 RID: 8807
		// (get) Token: 0x0600B863 RID: 47203 RVA: 0x0012788C File Offset: 0x00125A8C
		// (set) Token: 0x0600B864 RID: 47204 RVA: 0x001278C5 File Offset: 0x00125AC5
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

		// Token: 0x17002268 RID: 8808
		// (get) Token: 0x0600B865 RID: 47205 RVA: 0x001278D4 File Offset: 0x00125AD4
		// (set) Token: 0x0600B866 RID: 47206 RVA: 0x0012790D File Offset: 0x00125B0D
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

		// Token: 0x17002269 RID: 8809
		// (get) Token: 0x0600B867 RID: 47207 RVA: 0x0012791B File Offset: 0x00125B1B
		// (set) Token: 0x0600B868 RID: 47208 RVA: 0x0012792B File Offset: 0x00125B2B
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

		// Token: 0x1700226A RID: 8810
		// (get) Token: 0x0600B869 RID: 47209 RVA: 0x0012793C File Offset: 0x00125B3C
		// (set) Token: 0x0600B86A RID: 47210 RVA: 0x00127950 File Offset: 0x00125B50
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

		// Token: 0x1700226B RID: 8811
		// (get) Token: 0x0600B86B RID: 47211 RVA: 0x00127965 File Offset: 0x00125B65
		// (set) Token: 0x0600B86C RID: 47212 RVA: 0x00127979 File Offset: 0x00125B79
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

		// Token: 0x1700226C RID: 8812
		// (get) Token: 0x0600B86D RID: 47213 RVA: 0x0012798E File Offset: 0x00125B8E
		// (set) Token: 0x0600B86E RID: 47214 RVA: 0x0012799E File Offset: 0x00125B9E
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

		// Token: 0x1700226D RID: 8813
		// (get) Token: 0x0600B86F RID: 47215 RVA: 0x001279B0 File Offset: 0x00125BB0
		// (set) Token: 0x0600B870 RID: 47216 RVA: 0x001279E9 File Offset: 0x00125BE9
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

		// Token: 0x1700226E RID: 8814
		// (get) Token: 0x0600B871 RID: 47217 RVA: 0x001279F8 File Offset: 0x00125BF8
		// (set) Token: 0x0600B872 RID: 47218 RVA: 0x00127A31 File Offset: 0x00125C31
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

		// Token: 0x1700226F RID: 8815
		// (get) Token: 0x0600B873 RID: 47219 RVA: 0x00127A40 File Offset: 0x00125C40
		// (set) Token: 0x0600B874 RID: 47220 RVA: 0x00127A79 File Offset: 0x00125C79
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

		// Token: 0x17002270 RID: 8816
		// (get) Token: 0x0600B875 RID: 47221 RVA: 0x00127A88 File Offset: 0x00125C88
		// (set) Token: 0x0600B876 RID: 47222 RVA: 0x00127AC1 File Offset: 0x00125CC1
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

		// Token: 0x17002271 RID: 8817
		// (get) Token: 0x0600B877 RID: 47223 RVA: 0x00127AD0 File Offset: 0x00125CD0
		// (set) Token: 0x0600B878 RID: 47224 RVA: 0x00127B09 File Offset: 0x00125D09
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

		// Token: 0x17002272 RID: 8818
		// (get) Token: 0x0600B879 RID: 47225 RVA: 0x00127B17 File Offset: 0x00125D17
		// (set) Token: 0x0600B87A RID: 47226 RVA: 0x00127B27 File Offset: 0x00125D27
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

		// Token: 0x0600B87B RID: 47227 RVA: 0x00127B38 File Offset: 0x00125D38
		static USpineSkeletonRendererComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SpinePlugin.SpineSkeletonRendererComponent");
		}

		// Token: 0x0600B87C RID: 47228 RVA: 0x00127B46 File Offset: 0x00125D46
		protected USpineSkeletonRendererComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040053B3 RID: 21427
		public new const string __ObjectPath = "/Script/SpinePlugin.SpineSkeletonRendererComponent";

		// Token: 0x040053B4 RID: 21428
		private static IntPtr _ClassPtr;

		// Token: 0x040053B5 RID: 21429
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040053B6 RID: 21430
		internal static int __PropertyOffset_NormalBlendMaterial;

		// Token: 0x040053B7 RID: 21431
		internal static int __PropertyOffset_AdditiveBlendMaterial;

		// Token: 0x040053B8 RID: 21432
		internal static int __PropertyOffset_MultiplyBlendMaterial;

		// Token: 0x040053B9 RID: 21433
		internal static int __PropertyOffset_ScreenBlendMaterial;

		// Token: 0x040053BA RID: 21434
		internal static int __PropertyOffset_atlasNormalBlendMaterials;

		// Token: 0x040053BB RID: 21435
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInstanceDynamic> _atlasNormalBlendMaterials;

		// Token: 0x040053BC RID: 21436
		internal static int __PropertyOffset_atlasAdditiveBlendMaterials;

		// Token: 0x040053BD RID: 21437
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInstanceDynamic> _atlasAdditiveBlendMaterials;

		// Token: 0x040053BE RID: 21438
		internal static int __PropertyOffset_atlasMultiplyBlendMaterials;

		// Token: 0x040053BF RID: 21439
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInstanceDynamic> _atlasMultiplyBlendMaterials;

		// Token: 0x040053C0 RID: 21440
		internal static int __PropertyOffset_atlasScreenBlendMaterials;

		// Token: 0x040053C1 RID: 21441
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInstanceDynamic> _atlasScreenBlendMaterials;

		// Token: 0x040053C2 RID: 21442
		internal static int __PropertyOffset_DepthOffset;

		// Token: 0x040053C3 RID: 21443
		internal static int __PropertyOffset_TextureParameterName;

		// Token: 0x040053C4 RID: 21444
		internal static int __PropertyOffset_Color;

		// Token: 0x040053C5 RID: 21445
		internal static int __PropertyOffset_bCreateCollision;

		// Token: 0x040053C6 RID: 21446
		internal static int __PropertyOffset_vertices;

		// Token: 0x040053C7 RID: 21447
		[Nullable(2)]
		private TArray<FVector> _vertices;

		// Token: 0x040053C8 RID: 21448
		internal static int __PropertyOffset_indices;

		// Token: 0x040053C9 RID: 21449
		[Nullable(2)]
		private TArray<int> _indices;

		// Token: 0x040053CA RID: 21450
		internal static int __PropertyOffset_normals;

		// Token: 0x040053CB RID: 21451
		[Nullable(2)]
		private TArray<FVector> _normals;

		// Token: 0x040053CC RID: 21452
		internal static int __PropertyOffset_uvs;

		// Token: 0x040053CD RID: 21453
		[Nullable(2)]
		private TArray<FVector2D> _uvs;

		// Token: 0x040053CE RID: 21454
		internal static int __PropertyOffset_colors;

		// Token: 0x040053CF RID: 21455
		[Nullable(2)]
		private TArray<FColor> _colors;

		// Token: 0x040053D0 RID: 21456
		internal static int __PropertyOffset_bNeedParallelUpdate;
	}
}
