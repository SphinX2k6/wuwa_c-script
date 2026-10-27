using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000D77 RID: 3447
	[UnrealObjectPath("/Script/Engine.Material")]
	[UnrealStructLayout(4232, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 4232)]
	public class UMaterial : UMaterialInterface, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600BA91 RID: 47761 RVA: 0x00109284 File Offset: 0x00107484
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterial._ClassPtr;
		}

		// Token: 0x0600BA92 RID: 47762 RVA: 0x00109290 File Offset: 0x00107490
		public UMaterial() : this(BuiltinUtils.AllocNativeUObject(UMaterial.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600BA93 RID: 47763 RVA: 0x001092B8 File Offset: 0x001074B8
		[NullableContext(1)]
		public UMaterial(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterial.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002AC9 RID: 10953
		// (get) Token: 0x0600BA94 RID: 47764 RVA: 0x001092EB File Offset: 0x001074EB
		// (set) Token: 0x0600BA95 RID: 47765 RVA: 0x001092FF File Offset: 0x001074FF
		[Nullable(2)]
		public unsafe UPhysicalMaterial PhysMaterial
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPhysicalMaterial>(base.NativePtr / (IntPtr)sizeof(void*) + UMaterial.__PropertyOffset_PhysMaterial);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UMaterial.__PropertyOffset_PhysMaterial, value);
			}
		}

		// Token: 0x17002ACA RID: 10954
		// (get) Token: 0x0600BA96 RID: 47766 RVA: 0x00109314 File Offset: 0x00107514
		// (set) Token: 0x0600BA97 RID: 47767 RVA: 0x00109328 File Offset: 0x00107528
		[Nullable(2)]
		public unsafe UPhysicalMaterialMask PhysMaterialMask
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPhysicalMaterialMask>(base.NativePtr / (IntPtr)sizeof(void*) + UMaterial.__PropertyOffset_PhysMaterialMask);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UMaterial.__PropertyOffset_PhysMaterialMask, value);
			}
		}

		// Token: 0x17002ACB RID: 10955
		// (get) Token: 0x0600BA98 RID: 47768 RVA: 0x00109340 File Offset: 0x00107540
		// (set) Token: 0x0600BA99 RID: 47769 RVA: 0x0010937A File Offset: 0x0010757A
		[Nullable(1)]
		public TFixedArray<UPhysicalMaterial> PhysicalMaterialMap
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TFixedArray<UPhysicalMaterial> result;
				if ((result = this._PhysicalMaterialMap) == null)
				{
					result = (this._PhysicalMaterialMap = new TFixedArray<UPhysicalMaterial>(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_PhysicalMaterialMap, 8, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.PhysicalMaterialMap.CopyAssign(value);
			}
		}

		// Token: 0x17002ACC RID: 10956
		// (get) Token: 0x0600BA9A RID: 47770 RVA: 0x00109388 File Offset: 0x00107588
		// (set) Token: 0x0600BA9B RID: 47771 RVA: 0x001093C1 File Offset: 0x001075C1
		[Nullable(1)]
		public FScalarMaterialInput Metallic
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FScalarMaterialInput result;
				if ((result = this._Metallic) == null)
				{
					result = (this._Metallic = new FScalarMaterialInput(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_Metallic, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FScalarMaterialInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_Metallic, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002ACD RID: 10957
		// (get) Token: 0x0600BA9C RID: 47772 RVA: 0x001093E4 File Offset: 0x001075E4
		// (set) Token: 0x0600BA9D RID: 47773 RVA: 0x0010941D File Offset: 0x0010761D
		[Nullable(1)]
		public FScalarMaterialInput Specular
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FScalarMaterialInput result;
				if ((result = this._Specular) == null)
				{
					result = (this._Specular = new FScalarMaterialInput(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_Specular, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FScalarMaterialInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_Specular, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002ACE RID: 10958
		// (get) Token: 0x0600BA9E RID: 47774 RVA: 0x00109440 File Offset: 0x00107640
		// (set) Token: 0x0600BA9F RID: 47775 RVA: 0x00109479 File Offset: 0x00107679
		[Nullable(1)]
		public FScalarMaterialInput Anisotropy
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FScalarMaterialInput result;
				if ((result = this._Anisotropy) == null)
				{
					result = (this._Anisotropy = new FScalarMaterialInput(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_Anisotropy, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FScalarMaterialInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_Anisotropy, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002ACF RID: 10959
		// (get) Token: 0x0600BAA0 RID: 47776 RVA: 0x0010949C File Offset: 0x0010769C
		// (set) Token: 0x0600BAA1 RID: 47777 RVA: 0x001094D5 File Offset: 0x001076D5
		[Nullable(1)]
		public FVectorMaterialInput Normal
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FVectorMaterialInput result;
				if ((result = this._Normal) == null)
				{
					result = (this._Normal = new FVectorMaterialInput(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_Normal, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FVectorMaterialInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_Normal, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002AD0 RID: 10960
		// (get) Token: 0x0600BAA2 RID: 47778 RVA: 0x001094F8 File Offset: 0x001076F8
		// (set) Token: 0x0600BAA3 RID: 47779 RVA: 0x00109531 File Offset: 0x00107731
		[Nullable(1)]
		public FVectorMaterialInput Tangent
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FVectorMaterialInput result;
				if ((result = this._Tangent) == null)
				{
					result = (this._Tangent = new FVectorMaterialInput(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_Tangent, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FVectorMaterialInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_Tangent, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002AD1 RID: 10961
		// (get) Token: 0x0600BAA4 RID: 47780 RVA: 0x00109554 File Offset: 0x00107754
		// (set) Token: 0x0600BAA5 RID: 47781 RVA: 0x0010958D File Offset: 0x0010778D
		[Nullable(1)]
		public FColorMaterialInput EmissiveColor
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FColorMaterialInput result;
				if ((result = this._EmissiveColor) == null)
				{
					result = (this._EmissiveColor = new FColorMaterialInput(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_EmissiveColor, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FColorMaterialInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_EmissiveColor, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002AD2 RID: 10962
		// (get) Token: 0x0600BAA6 RID: 47782 RVA: 0x001095AE File Offset: 0x001077AE
		// (set) Token: 0x0600BAA7 RID: 47783 RVA: 0x001095C2 File Offset: 0x001077C2
		public unsafe TEnumAsByte<EMaterialDomain> MaterialDomain
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_MaterialDomain);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_MaterialDomain) = value;
			}
		}

		// Token: 0x17002AD3 RID: 10963
		// (get) Token: 0x0600BAA8 RID: 47784 RVA: 0x001095D7 File Offset: 0x001077D7
		// (set) Token: 0x0600BAA9 RID: 47785 RVA: 0x001095EB File Offset: 0x001077EB
		public unsafe TEnumAsByte<EBlendMode> BlendMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_BlendMode);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_BlendMode) = value;
			}
		}

		// Token: 0x17002AD4 RID: 10964
		// (get) Token: 0x0600BAAA RID: 47786 RVA: 0x00109600 File Offset: 0x00107800
		// (set) Token: 0x0600BAAB RID: 47787 RVA: 0x00109614 File Offset: 0x00107814
		public unsafe TEnumAsByte<EDecalBlendMode> DecalBlendMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_DecalBlendMode);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_DecalBlendMode) = value;
			}
		}

		// Token: 0x17002AD5 RID: 10965
		// (get) Token: 0x0600BAAC RID: 47788 RVA: 0x00109629 File Offset: 0x00107829
		// (set) Token: 0x0600BAAD RID: 47789 RVA: 0x00109642 File Offset: 0x00107842
		public unsafe bool MaterialReceiveDecal
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_MaterialReceiveDecal) & UMaterial.__PropertyMask_MaterialReceiveDecal) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_MaterialReceiveDecal) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_MaterialReceiveDecal) & ~UMaterial.__PropertyMask_MaterialReceiveDecal) | (value ? UMaterial.__PropertyMask_MaterialReceiveDecal : 0));
			}
		}

		// Token: 0x17002AD6 RID: 10966
		// (get) Token: 0x0600BAAE RID: 47790 RVA: 0x00109672 File Offset: 0x00107872
		// (set) Token: 0x0600BAAF RID: 47791 RVA: 0x00109686 File Offset: 0x00107886
		public unsafe TEnumAsByte<EMaterialDecalResponse> MaterialDecalResponse
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_MaterialDecalResponse);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_MaterialDecalResponse) = value;
			}
		}

		// Token: 0x17002AD7 RID: 10967
		// (get) Token: 0x0600BAB0 RID: 47792 RVA: 0x0010969B File Offset: 0x0010789B
		// (set) Token: 0x0600BAB1 RID: 47793 RVA: 0x001096AF File Offset: 0x001078AF
		public unsafe TEnumAsByte<EMaterialShadingModel> ShadingModel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_ShadingModel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_ShadingModel) = value;
			}
		}

		// Token: 0x17002AD8 RID: 10968
		// (get) Token: 0x0600BAB2 RID: 47794 RVA: 0x001096C4 File Offset: 0x001078C4
		// (set) Token: 0x0600BAB3 RID: 47795 RVA: 0x001096DD File Offset: 0x001078DD
		public unsafe bool bCastDynamicShadowAsMasked
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bCastDynamicShadowAsMasked) & UMaterial.__PropertyMask_bCastDynamicShadowAsMasked) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bCastDynamicShadowAsMasked) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bCastDynamicShadowAsMasked) & ~UMaterial.__PropertyMask_bCastDynamicShadowAsMasked) | (value ? UMaterial.__PropertyMask_bCastDynamicShadowAsMasked : 0));
			}
		}

		// Token: 0x17002AD9 RID: 10969
		// (get) Token: 0x0600BAB4 RID: 47796 RVA: 0x00109710 File Offset: 0x00107910
		// (set) Token: 0x0600BAB5 RID: 47797 RVA: 0x00109749 File Offset: 0x00107949
		[Nullable(1)]
		public FMaterialShadingModelField ShadingModels
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FMaterialShadingModelField result;
				if ((result = this._ShadingModels) == null)
				{
					result = (this._ShadingModels = new FMaterialShadingModelField(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_ShadingModels, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMaterialShadingModelField.StaticStruct(), base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_ShadingModels, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002ADA RID: 10970
		// (get) Token: 0x0600BAB6 RID: 47798 RVA: 0x0010976A File Offset: 0x0010796A
		// (set) Token: 0x0600BAB7 RID: 47799 RVA: 0x0010977A File Offset: 0x0010797A
		public unsafe float OpacityMaskClipValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_OpacityMaskClipValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_OpacityMaskClipValue) = value;
			}
		}

		// Token: 0x17002ADB RID: 10971
		// (get) Token: 0x0600BAB8 RID: 47800 RVA: 0x0010978C File Offset: 0x0010798C
		// (set) Token: 0x0600BAB9 RID: 47801 RVA: 0x001097C5 File Offset: 0x001079C5
		[Nullable(1)]
		public FVectorMaterialInput WorldPositionOffset
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FVectorMaterialInput result;
				if ((result = this._WorldPositionOffset) == null)
				{
					result = (this._WorldPositionOffset = new FVectorMaterialInput(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_WorldPositionOffset, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FVectorMaterialInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_WorldPositionOffset, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002ADC RID: 10972
		// (get) Token: 0x0600BABA RID: 47802 RVA: 0x001097E8 File Offset: 0x001079E8
		// (set) Token: 0x0600BABB RID: 47803 RVA: 0x00109821 File Offset: 0x00107A21
		[Nullable(1)]
		public FScalarMaterialInput Refraction
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FScalarMaterialInput result;
				if ((result = this._Refraction) == null)
				{
					result = (this._Refraction = new FScalarMaterialInput(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_Refraction, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FScalarMaterialInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_Refraction, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002ADD RID: 10973
		// (get) Token: 0x0600BABC RID: 47804 RVA: 0x00109844 File Offset: 0x00107A44
		// (set) Token: 0x0600BABD RID: 47805 RVA: 0x0010987D File Offset: 0x00107A7D
		[Nullable(1)]
		public FMaterialAttributesInput MaterialAttributes
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FMaterialAttributesInput result;
				if ((result = this._MaterialAttributes) == null)
				{
					result = (this._MaterialAttributes = new FMaterialAttributesInput(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_MaterialAttributes, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMaterialAttributesInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_MaterialAttributes, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002ADE RID: 10974
		// (get) Token: 0x0600BABE RID: 47806 RVA: 0x001098A0 File Offset: 0x00107AA0
		// (set) Token: 0x0600BABF RID: 47807 RVA: 0x001098D9 File Offset: 0x00107AD9
		[Nullable(1)]
		public FScalarMaterialInput PixelDepthOffset
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FScalarMaterialInput result;
				if ((result = this._PixelDepthOffset) == null)
				{
					result = (this._PixelDepthOffset = new FScalarMaterialInput(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_PixelDepthOffset, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FScalarMaterialInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_PixelDepthOffset, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002ADF RID: 10975
		// (get) Token: 0x0600BAC0 RID: 47808 RVA: 0x001098FC File Offset: 0x00107AFC
		// (set) Token: 0x0600BAC1 RID: 47809 RVA: 0x00109935 File Offset: 0x00107B35
		[Nullable(1)]
		public FShadingModelMaterialInput ShadingModelFromMaterialExpression
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FShadingModelMaterialInput result;
				if ((result = this._ShadingModelFromMaterialExpression) == null)
				{
					result = (this._ShadingModelFromMaterialExpression = new FShadingModelMaterialInput(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_ShadingModelFromMaterialExpression, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FShadingModelMaterialInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_ShadingModelFromMaterialExpression, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002AE0 RID: 10976
		// (get) Token: 0x0600BAC2 RID: 47810 RVA: 0x00109958 File Offset: 0x00107B58
		// (set) Token: 0x0600BAC3 RID: 47811 RVA: 0x00109991 File Offset: 0x00107B91
		[Nullable(1)]
		public FScalarMaterialInput ShadowPixelDepthOffset
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FScalarMaterialInput result;
				if ((result = this._ShadowPixelDepthOffset) == null)
				{
					result = (this._ShadowPixelDepthOffset = new FScalarMaterialInput(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_ShadowPixelDepthOffset, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FScalarMaterialInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_ShadowPixelDepthOffset, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002AE1 RID: 10977
		// (get) Token: 0x0600BAC4 RID: 47812 RVA: 0x001099B4 File Offset: 0x00107BB4
		// (set) Token: 0x0600BAC5 RID: 47813 RVA: 0x001099ED File Offset: 0x00107BED
		[Nullable(1)]
		public FScalarMaterialInput KuroDepthRimWidth
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FScalarMaterialInput result;
				if ((result = this._KuroDepthRimWidth) == null)
				{
					result = (this._KuroDepthRimWidth = new FScalarMaterialInput(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_KuroDepthRimWidth, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FScalarMaterialInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_KuroDepthRimWidth, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002AE2 RID: 10978
		// (get) Token: 0x0600BAC6 RID: 47814 RVA: 0x00109A10 File Offset: 0x00107C10
		// (set) Token: 0x0600BAC7 RID: 47815 RVA: 0x00109A49 File Offset: 0x00107C49
		[Nullable(1)]
		public FScalarMaterialInput KuroPreComputeShadow
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FScalarMaterialInput result;
				if ((result = this._KuroPreComputeShadow) == null)
				{
					result = (this._KuroPreComputeShadow = new FScalarMaterialInput(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_KuroPreComputeShadow, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FScalarMaterialInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_KuroPreComputeShadow, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002AE3 RID: 10979
		// (get) Token: 0x0600BAC8 RID: 47816 RVA: 0x00109A6A File Offset: 0x00107C6A
		// (set) Token: 0x0600BAC9 RID: 47817 RVA: 0x00109A83 File Offset: 0x00107C83
		public unsafe bool bEnableSeparateTranslucency
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bEnableSeparateTranslucency) & UMaterial.__PropertyMask_bEnableSeparateTranslucency) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bEnableSeparateTranslucency) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bEnableSeparateTranslucency) & ~UMaterial.__PropertyMask_bEnableSeparateTranslucency) | (value ? UMaterial.__PropertyMask_bEnableSeparateTranslucency : 0));
			}
		}

		// Token: 0x17002AE4 RID: 10980
		// (get) Token: 0x0600BACA RID: 47818 RVA: 0x00109AB3 File Offset: 0x00107CB3
		// (set) Token: 0x0600BACB RID: 47819 RVA: 0x00109ACC File Offset: 0x00107CCC
		public unsafe bool bEnableResponsiveAA
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bEnableResponsiveAA) & UMaterial.__PropertyMask_bEnableResponsiveAA) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bEnableResponsiveAA) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bEnableResponsiveAA) & ~UMaterial.__PropertyMask_bEnableResponsiveAA) | (value ? UMaterial.__PropertyMask_bEnableResponsiveAA : 0));
			}
		}

		// Token: 0x17002AE5 RID: 10981
		// (get) Token: 0x0600BACC RID: 47820 RVA: 0x00109AFC File Offset: 0x00107CFC
		// (set) Token: 0x0600BACD RID: 47821 RVA: 0x00109B15 File Offset: 0x00107D15
		public unsafe bool bScreenSpaceReflections
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bScreenSpaceReflections) & UMaterial.__PropertyMask_bScreenSpaceReflections) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bScreenSpaceReflections) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bScreenSpaceReflections) & ~UMaterial.__PropertyMask_bScreenSpaceReflections) | (value ? UMaterial.__PropertyMask_bScreenSpaceReflections : 0));
			}
		}

		// Token: 0x17002AE6 RID: 10982
		// (get) Token: 0x0600BACE RID: 47822 RVA: 0x00109B45 File Offset: 0x00107D45
		// (set) Token: 0x0600BACF RID: 47823 RVA: 0x00109B5E File Offset: 0x00107D5E
		public unsafe bool bContactShadows
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bContactShadows) & UMaterial.__PropertyMask_bContactShadows) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bContactShadows) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bContactShadows) & ~UMaterial.__PropertyMask_bContactShadows) | (value ? UMaterial.__PropertyMask_bContactShadows : 0));
			}
		}

		// Token: 0x17002AE7 RID: 10983
		// (get) Token: 0x0600BAD0 RID: 47824 RVA: 0x00109B8E File Offset: 0x00107D8E
		// (set) Token: 0x0600BAD1 RID: 47825 RVA: 0x00109BA7 File Offset: 0x00107DA7
		public unsafe bool bTranslucencyReceiveLightFunctionShadow
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bTranslucencyReceiveLightFunctionShadow) & UMaterial.__PropertyMask_bTranslucencyReceiveLightFunctionShadow) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bTranslucencyReceiveLightFunctionShadow) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bTranslucencyReceiveLightFunctionShadow) & ~UMaterial.__PropertyMask_bTranslucencyReceiveLightFunctionShadow) | (value ? UMaterial.__PropertyMask_bTranslucencyReceiveLightFunctionShadow : 0));
			}
		}

		// Token: 0x17002AE8 RID: 10984
		// (get) Token: 0x0600BAD2 RID: 47826 RVA: 0x00109BD7 File Offset: 0x00107DD7
		// (set) Token: 0x0600BAD3 RID: 47827 RVA: 0x00109BF0 File Offset: 0x00107DF0
		public unsafe bool TwoSided
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_TwoSided) & UMaterial.__PropertyMask_TwoSided) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_TwoSided) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_TwoSided) & ~UMaterial.__PropertyMask_TwoSided) | (value ? UMaterial.__PropertyMask_TwoSided : 0));
			}
		}

		// Token: 0x17002AE9 RID: 10985
		// (get) Token: 0x0600BAD4 RID: 47828 RVA: 0x00109C20 File Offset: 0x00107E20
		// (set) Token: 0x0600BAD5 RID: 47829 RVA: 0x00109C39 File Offset: 0x00107E39
		public unsafe bool KuroWater
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_KuroWater) & UMaterial.__PropertyMask_KuroWater) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_KuroWater) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_KuroWater) & ~UMaterial.__PropertyMask_KuroWater) | (value ? UMaterial.__PropertyMask_KuroWater : 0));
			}
		}

		// Token: 0x17002AEA RID: 10986
		// (get) Token: 0x0600BAD6 RID: 47830 RVA: 0x00109C69 File Offset: 0x00107E69
		// (set) Token: 0x0600BAD7 RID: 47831 RVA: 0x00109C82 File Offset: 0x00107E82
		public unsafe bool BackFace
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_BackFace) & UMaterial.__PropertyMask_BackFace) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_BackFace) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_BackFace) & ~UMaterial.__PropertyMask_BackFace) | (value ? UMaterial.__PropertyMask_BackFace : 0));
			}
		}

		// Token: 0x17002AEB RID: 10987
		// (get) Token: 0x0600BAD8 RID: 47832 RVA: 0x00109CB2 File Offset: 0x00107EB2
		// (set) Token: 0x0600BAD9 RID: 47833 RVA: 0x00109CCB File Offset: 0x00107ECB
		public unsafe bool bSceneDissolveEnable
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bSceneDissolveEnable) & UMaterial.__PropertyMask_bSceneDissolveEnable) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bSceneDissolveEnable) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bSceneDissolveEnable) & ~UMaterial.__PropertyMask_bSceneDissolveEnable) | (value ? UMaterial.__PropertyMask_bSceneDissolveEnable : 0));
			}
		}

		// Token: 0x17002AEC RID: 10988
		// (get) Token: 0x0600BADA RID: 47834 RVA: 0x00109CFB File Offset: 0x00107EFB
		// (set) Token: 0x0600BADB RID: 47835 RVA: 0x00109D14 File Offset: 0x00107F14
		public unsafe bool bSceneColorClearEnable
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bSceneColorClearEnable) & UMaterial.__PropertyMask_bSceneColorClearEnable) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bSceneColorClearEnable) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bSceneColorClearEnable) & ~UMaterial.__PropertyMask_bSceneColorClearEnable) | (value ? UMaterial.__PropertyMask_bSceneColorClearEnable : 0));
			}
		}

		// Token: 0x17002AED RID: 10989
		// (get) Token: 0x0600BADC RID: 47836 RVA: 0x00109D44 File Offset: 0x00107F44
		// (set) Token: 0x0600BADD RID: 47837 RVA: 0x00109D54 File Offset: 0x00107F54
		public unsafe ushort RenderQueue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_RenderQueue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_RenderQueue) = (short)value;
			}
		}

		// Token: 0x17002AEE RID: 10990
		// (get) Token: 0x0600BADE RID: 47838 RVA: 0x00109D65 File Offset: 0x00107F65
		// (set) Token: 0x0600BADF RID: 47839 RVA: 0x00109D79 File Offset: 0x00107F79
		public unsafe TEnumAsByte<EMaterialGameQualityShoulderRender> MaterialDesktopGameQualityShoulderRender
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_MaterialDesktopGameQualityShoulderRender);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_MaterialDesktopGameQualityShoulderRender) = value;
			}
		}

		// Token: 0x17002AEF RID: 10991
		// (get) Token: 0x0600BAE0 RID: 47840 RVA: 0x00109D8E File Offset: 0x00107F8E
		// (set) Token: 0x0600BAE1 RID: 47841 RVA: 0x00109DA2 File Offset: 0x00107FA2
		public unsafe TEnumAsByte<EMaterialGameQualityShoulderRender> MaterialMobileGameQualityShoulderRender
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_MaterialMobileGameQualityShoulderRender);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_MaterialMobileGameQualityShoulderRender) = value;
			}
		}

		// Token: 0x17002AF0 RID: 10992
		// (get) Token: 0x0600BAE2 RID: 47842 RVA: 0x00109DB7 File Offset: 0x00107FB7
		// (set) Token: 0x0600BAE3 RID: 47843 RVA: 0x00109DD0 File Offset: 0x00107FD0
		public unsafe bool bDisableShadowCacheForSPDO
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bDisableShadowCacheForSPDO) & UMaterial.__PropertyMask_bDisableShadowCacheForSPDO) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bDisableShadowCacheForSPDO) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bDisableShadowCacheForSPDO) & ~UMaterial.__PropertyMask_bDisableShadowCacheForSPDO) | (value ? UMaterial.__PropertyMask_bDisableShadowCacheForSPDO : 0));
			}
		}

		// Token: 0x17002AF1 RID: 10993
		// (get) Token: 0x0600BAE4 RID: 47844 RVA: 0x00109E00 File Offset: 0x00108000
		// (set) Token: 0x0600BAE5 RID: 47845 RVA: 0x00109E19 File Offset: 0x00108019
		public unsafe bool bSinglelayerWaterWriteDepth
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bSinglelayerWaterWriteDepth) & UMaterial.__PropertyMask_bSinglelayerWaterWriteDepth) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bSinglelayerWaterWriteDepth) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bSinglelayerWaterWriteDepth) & ~UMaterial.__PropertyMask_bSinglelayerWaterWriteDepth) | (value ? UMaterial.__PropertyMask_bSinglelayerWaterWriteDepth : 0));
			}
		}

		// Token: 0x17002AF2 RID: 10994
		// (get) Token: 0x0600BAE6 RID: 47846 RVA: 0x00109E49 File Offset: 0x00108049
		// (set) Token: 0x0600BAE7 RID: 47847 RVA: 0x00109E62 File Offset: 0x00108062
		public unsafe bool bSingleLayerWaterMobileDesaturation
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bSingleLayerWaterMobileDesaturation) & UMaterial.__PropertyMask_bSingleLayerWaterMobileDesaturation) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bSingleLayerWaterMobileDesaturation) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bSingleLayerWaterMobileDesaturation) & ~UMaterial.__PropertyMask_bSingleLayerWaterMobileDesaturation) | (value ? UMaterial.__PropertyMask_bSingleLayerWaterMobileDesaturation : 0));
			}
		}

		// Token: 0x17002AF3 RID: 10995
		// (get) Token: 0x0600BAE8 RID: 47848 RVA: 0x00109E92 File Offset: 0x00108092
		// (set) Token: 0x0600BAE9 RID: 47849 RVA: 0x00109EAB File Offset: 0x001080AB
		public unsafe bool bDrawRTWithRGBA
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bDrawRTWithRGBA) & UMaterial.__PropertyMask_bDrawRTWithRGBA) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bDrawRTWithRGBA) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bDrawRTWithRGBA) & ~UMaterial.__PropertyMask_bDrawRTWithRGBA) | (value ? UMaterial.__PropertyMask_bDrawRTWithRGBA : 0));
			}
		}

		// Token: 0x17002AF4 RID: 10996
		// (get) Token: 0x0600BAEA RID: 47850 RVA: 0x00109EDB File Offset: 0x001080DB
		// (set) Token: 0x0600BAEB RID: 47851 RVA: 0x00109EF4 File Offset: 0x001080F4
		public unsafe bool bRenderInCustomCapturePass
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bRenderInCustomCapturePass) & UMaterial.__PropertyMask_bRenderInCustomCapturePass) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bRenderInCustomCapturePass) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bRenderInCustomCapturePass) & ~UMaterial.__PropertyMask_bRenderInCustomCapturePass) | (value ? UMaterial.__PropertyMask_bRenderInCustomCapturePass : 0));
			}
		}

		// Token: 0x17002AF5 RID: 10997
		// (get) Token: 0x0600BAEC RID: 47852 RVA: 0x00109F24 File Offset: 0x00108124
		// (set) Token: 0x0600BAED RID: 47853 RVA: 0x00109F3D File Offset: 0x0010813D
		public unsafe bool bRenderInGodRayPass
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bRenderInGodRayPass) & UMaterial.__PropertyMask_bRenderInGodRayPass) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bRenderInGodRayPass) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bRenderInGodRayPass) & ~UMaterial.__PropertyMask_bRenderInGodRayPass) | (value ? UMaterial.__PropertyMask_bRenderInGodRayPass : 0));
			}
		}

		// Token: 0x17002AF6 RID: 10998
		// (get) Token: 0x0600BAEE RID: 47854 RVA: 0x00109F6D File Offset: 0x0010816D
		// (set) Token: 0x0600BAEF RID: 47855 RVA: 0x00109F86 File Offset: 0x00108186
		public unsafe bool bMaskedRenderInPreDepth
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bMaskedRenderInPreDepth) & UMaterial.__PropertyMask_bMaskedRenderInPreDepth) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bMaskedRenderInPreDepth) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bMaskedRenderInPreDepth) & ~UMaterial.__PropertyMask_bMaskedRenderInPreDepth) | (value ? UMaterial.__PropertyMask_bMaskedRenderInPreDepth : 0));
			}
		}

		// Token: 0x17002AF7 RID: 10999
		// (get) Token: 0x0600BAF0 RID: 47856 RVA: 0x00109FB6 File Offset: 0x001081B6
		// (set) Token: 0x0600BAF1 RID: 47857 RVA: 0x00109FCF File Offset: 0x001081CF
		public unsafe bool bMaskedRenderInPreDepth_PC
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bMaskedRenderInPreDepth_PC) & UMaterial.__PropertyMask_bMaskedRenderInPreDepth_PC) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bMaskedRenderInPreDepth_PC) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bMaskedRenderInPreDepth_PC) & ~UMaterial.__PropertyMask_bMaskedRenderInPreDepth_PC) | (value ? UMaterial.__PropertyMask_bMaskedRenderInPreDepth_PC : 0));
			}
		}

		// Token: 0x17002AF8 RID: 11000
		// (get) Token: 0x0600BAF2 RID: 47858 RVA: 0x00109FFF File Offset: 0x001081FF
		// (set) Token: 0x0600BAF3 RID: 47859 RVA: 0x0010A018 File Offset: 0x00108218
		public unsafe bool bSupportMobileHighQuality
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bSupportMobileHighQuality) & UMaterial.__PropertyMask_bSupportMobileHighQuality) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bSupportMobileHighQuality) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bSupportMobileHighQuality) & ~UMaterial.__PropertyMask_bSupportMobileHighQuality) | (value ? UMaterial.__PropertyMask_bSupportMobileHighQuality : 0));
			}
		}

		// Token: 0x17002AF9 RID: 11001
		// (get) Token: 0x0600BAF4 RID: 47860 RVA: 0x0010A048 File Offset: 0x00108248
		// (set) Token: 0x0600BAF5 RID: 47861 RVA: 0x0010A061 File Offset: 0x00108261
		public unsafe bool bCustomAlphaTest
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bCustomAlphaTest) & UMaterial.__PropertyMask_bCustomAlphaTest) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bCustomAlphaTest) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bCustomAlphaTest) & ~UMaterial.__PropertyMask_bCustomAlphaTest) | (value ? UMaterial.__PropertyMask_bCustomAlphaTest : 0));
			}
		}

		// Token: 0x17002AFA RID: 11002
		// (get) Token: 0x0600BAF6 RID: 47862 RVA: 0x0010A091 File Offset: 0x00108291
		// (set) Token: 0x0600BAF7 RID: 47863 RVA: 0x0010A0AA File Offset: 0x001082AA
		public unsafe bool bEnableBattle
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bEnableBattle) & UMaterial.__PropertyMask_bEnableBattle) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bEnableBattle) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bEnableBattle) & ~UMaterial.__PropertyMask_bEnableBattle) | (value ? UMaterial.__PropertyMask_bEnableBattle : 0));
			}
		}

		// Token: 0x17002AFB RID: 11003
		// (get) Token: 0x0600BAF8 RID: 47864 RVA: 0x0010A0DA File Offset: 0x001082DA
		// (set) Token: 0x0600BAF9 RID: 47865 RVA: 0x0010A0F3 File Offset: 0x001082F3
		public unsafe bool bEnableBattleMask
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bEnableBattleMask) & UMaterial.__PropertyMask_bEnableBattleMask) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bEnableBattleMask) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bEnableBattleMask) & ~UMaterial.__PropertyMask_bEnableBattleMask) | (value ? UMaterial.__PropertyMask_bEnableBattleMask : 0));
			}
		}

		// Token: 0x17002AFC RID: 11004
		// (get) Token: 0x0600BAFA RID: 47866 RVA: 0x0010A123 File Offset: 0x00108323
		// (set) Token: 0x0600BAFB RID: 47867 RVA: 0x0010A13C File Offset: 0x0010833C
		public unsafe bool bIsCharacterHairMat
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bIsCharacterHairMat) & UMaterial.__PropertyMask_bIsCharacterHairMat) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bIsCharacterHairMat) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bIsCharacterHairMat) & ~UMaterial.__PropertyMask_bIsCharacterHairMat) | (value ? UMaterial.__PropertyMask_bIsCharacterHairMat : 0));
			}
		}

		// Token: 0x17002AFD RID: 11005
		// (get) Token: 0x0600BAFC RID: 47868 RVA: 0x0010A16C File Offset: 0x0010836C
		// (set) Token: 0x0600BAFD RID: 47869 RVA: 0x0010A185 File Offset: 0x00108385
		public unsafe bool bIsCharacterHETMat
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bIsCharacterHETMat) & UMaterial.__PropertyMask_bIsCharacterHETMat) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bIsCharacterHETMat) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bIsCharacterHETMat) & ~UMaterial.__PropertyMask_bIsCharacterHETMat) | (value ? UMaterial.__PropertyMask_bIsCharacterHETMat : 0));
			}
		}

		// Token: 0x17002AFE RID: 11006
		// (get) Token: 0x0600BAFE RID: 47870 RVA: 0x0010A1B5 File Offset: 0x001083B5
		// (set) Token: 0x0600BAFF RID: 47871 RVA: 0x0010A1C5 File Offset: 0x001083C5
		public unsafe bool bHETMatOnlyUsedPlayer
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bHETMatOnlyUsedPlayer) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bHETMatOnlyUsedPlayer) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002AFF RID: 11007
		// (get) Token: 0x0600BB00 RID: 47872 RVA: 0x0010A1D6 File Offset: 0x001083D6
		// (set) Token: 0x0600BB01 RID: 47873 RVA: 0x0010A1E6 File Offset: 0x001083E6
		public unsafe bool bIsUsedWithWriteStencil
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bIsUsedWithWriteStencil) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bIsUsedWithWriteStencil) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002B00 RID: 11008
		// (get) Token: 0x0600BB02 RID: 47874 RVA: 0x0010A1F7 File Offset: 0x001083F7
		// (set) Token: 0x0600BB03 RID: 47875 RVA: 0x0010A210 File Offset: 0x00108410
		public unsafe bool bRenderToonFFT
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bRenderToonFFT) & UMaterial.__PropertyMask_bRenderToonFFT) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bRenderToonFFT) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bRenderToonFFT) & ~UMaterial.__PropertyMask_bRenderToonFFT) | (value ? UMaterial.__PropertyMask_bRenderToonFFT : 0));
			}
		}

		// Token: 0x17002B01 RID: 11009
		// (get) Token: 0x0600BB04 RID: 47876 RVA: 0x0010A240 File Offset: 0x00108440
		// (set) Token: 0x0600BB05 RID: 47877 RVA: 0x0010A259 File Offset: 0x00108459
		public unsafe bool bRenderTranslucentOpacity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bRenderTranslucentOpacity) & UMaterial.__PropertyMask_bRenderTranslucentOpacity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bRenderTranslucentOpacity) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bRenderTranslucentOpacity) & ~UMaterial.__PropertyMask_bRenderTranslucentOpacity) | (value ? UMaterial.__PropertyMask_bRenderTranslucentOpacity : 0));
			}
		}

		// Token: 0x17002B02 RID: 11010
		// (get) Token: 0x0600BB06 RID: 47878 RVA: 0x0010A289 File Offset: 0x00108489
		// (set) Token: 0x0600BB07 RID: 47879 RVA: 0x0010A2A2 File Offset: 0x001084A2
		public unsafe bool bForceSceneTranslucentOpacity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bForceSceneTranslucentOpacity) & UMaterial.__PropertyMask_bForceSceneTranslucentOpacity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bForceSceneTranslucentOpacity) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bForceSceneTranslucentOpacity) & ~UMaterial.__PropertyMask_bForceSceneTranslucentOpacity) | (value ? UMaterial.__PropertyMask_bForceSceneTranslucentOpacity : 0));
			}
		}

		// Token: 0x17002B03 RID: 11011
		// (get) Token: 0x0600BB08 RID: 47880 RVA: 0x0010A2D2 File Offset: 0x001084D2
		// (set) Token: 0x0600BB09 RID: 47881 RVA: 0x0010A2EB File Offset: 0x001084EB
		public unsafe bool bForceFightTranslucentOpacity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bForceFightTranslucentOpacity) & UMaterial.__PropertyMask_bForceFightTranslucentOpacity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bForceFightTranslucentOpacity) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bForceFightTranslucentOpacity) & ~UMaterial.__PropertyMask_bForceFightTranslucentOpacity) | (value ? UMaterial.__PropertyMask_bForceFightTranslucentOpacity : 0));
			}
		}

		// Token: 0x17002B04 RID: 11012
		// (get) Token: 0x0600BB0A RID: 47882 RVA: 0x0010A31B File Offset: 0x0010851B
		// (set) Token: 0x0600BB0B RID: 47883 RVA: 0x0010A32B File Offset: 0x0010852B
		public unsafe float ExtendedHETDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_ExtendedHETDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_ExtendedHETDistance) = value;
			}
		}

		// Token: 0x17002B05 RID: 11013
		// (get) Token: 0x0600BB0C RID: 47884 RVA: 0x0010A33C File Offset: 0x0010853C
		// (set) Token: 0x0600BB0D RID: 47885 RVA: 0x0010A355 File Offset: 0x00108555
		public unsafe bool bUseMobileDistortion
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUseMobileDistortion) & UMaterial.__PropertyMask_bUseMobileDistortion) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUseMobileDistortion) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUseMobileDistortion) & ~UMaterial.__PropertyMask_bUseMobileDistortion) | (value ? UMaterial.__PropertyMask_bUseMobileDistortion : 0));
			}
		}

		// Token: 0x17002B06 RID: 11014
		// (get) Token: 0x0600BB0E RID: 47886 RVA: 0x0010A385 File Offset: 0x00108585
		// (set) Token: 0x0600BB0F RID: 47887 RVA: 0x0010A39E File Offset: 0x0010859E
		public unsafe bool bLGUIMaterial
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bLGUIMaterial) & UMaterial.__PropertyMask_bLGUIMaterial) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bLGUIMaterial) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bLGUIMaterial) & ~UMaterial.__PropertyMask_bLGUIMaterial) | (value ? UMaterial.__PropertyMask_bLGUIMaterial : 0));
			}
		}

		// Token: 0x17002B07 RID: 11015
		// (get) Token: 0x0600BB10 RID: 47888 RVA: 0x0010A3CE File Offset: 0x001085CE
		// (set) Token: 0x0600BB11 RID: 47889 RVA: 0x0010A3E7 File Offset: 0x001085E7
		public unsafe bool bLGUIMaterialDrawBeforeUpScale
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bLGUIMaterialDrawBeforeUpScale) & UMaterial.__PropertyMask_bLGUIMaterialDrawBeforeUpScale) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bLGUIMaterialDrawBeforeUpScale) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bLGUIMaterialDrawBeforeUpScale) & ~UMaterial.__PropertyMask_bLGUIMaterialDrawBeforeUpScale) | (value ? UMaterial.__PropertyMask_bLGUIMaterialDrawBeforeUpScale : 0));
			}
		}

		// Token: 0x17002B08 RID: 11016
		// (get) Token: 0x0600BB12 RID: 47890 RVA: 0x0010A417 File Offset: 0x00108617
		// (set) Token: 0x0600BB13 RID: 47891 RVA: 0x0010A430 File Offset: 0x00108630
		public unsafe bool bLGUISkipDepth
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bLGUISkipDepth) & UMaterial.__PropertyMask_bLGUISkipDepth) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bLGUISkipDepth) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bLGUISkipDepth) & ~UMaterial.__PropertyMask_bLGUISkipDepth) | (value ? UMaterial.__PropertyMask_bLGUISkipDepth : 0));
			}
		}

		// Token: 0x17002B09 RID: 11017
		// (get) Token: 0x0600BB14 RID: 47892 RVA: 0x0010A460 File Offset: 0x00108660
		// (set) Token: 0x0600BB15 RID: 47893 RVA: 0x0010A479 File Offset: 0x00108679
		public unsafe bool bTranslucencyUse3xPCF
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bTranslucencyUse3xPCF) & UMaterial.__PropertyMask_bTranslucencyUse3xPCF) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bTranslucencyUse3xPCF) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bTranslucencyUse3xPCF) & ~UMaterial.__PropertyMask_bTranslucencyUse3xPCF) | (value ? UMaterial.__PropertyMask_bTranslucencyUse3xPCF : 0));
			}
		}

		// Token: 0x17002B0A RID: 11018
		// (get) Token: 0x0600BB16 RID: 47894 RVA: 0x0010A4A9 File Offset: 0x001086A9
		// (set) Token: 0x0600BB17 RID: 47895 RVA: 0x0010A4C2 File Offset: 0x001086C2
		public unsafe bool bTranslucencyIBLUseCustomdataRoughness
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bTranslucencyIBLUseCustomdataRoughness) & UMaterial.__PropertyMask_bTranslucencyIBLUseCustomdataRoughness) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bTranslucencyIBLUseCustomdataRoughness) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bTranslucencyIBLUseCustomdataRoughness) & ~UMaterial.__PropertyMask_bTranslucencyIBLUseCustomdataRoughness) | (value ? UMaterial.__PropertyMask_bTranslucencyIBLUseCustomdataRoughness : 0));
			}
		}

		// Token: 0x17002B0B RID: 11019
		// (get) Token: 0x0600BB18 RID: 47896 RVA: 0x0010A4F2 File Offset: 0x001086F2
		// (set) Token: 0x0600BB19 RID: 47897 RVA: 0x0010A50B File Offset: 0x0010870B
		public unsafe bool bTranslucencyReceiveShadowMobile
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bTranslucencyReceiveShadowMobile) & UMaterial.__PropertyMask_bTranslucencyReceiveShadowMobile) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bTranslucencyReceiveShadowMobile) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bTranslucencyReceiveShadowMobile) & ~UMaterial.__PropertyMask_bTranslucencyReceiveShadowMobile) | (value ? UMaterial.__PropertyMask_bTranslucencyReceiveShadowMobile : 0));
			}
		}

		// Token: 0x17002B0C RID: 11020
		// (get) Token: 0x0600BB1A RID: 47898 RVA: 0x0010A53B File Offset: 0x0010873B
		// (set) Token: 0x0600BB1B RID: 47899 RVA: 0x0010A554 File Offset: 0x00108754
		public unsafe bool DitheredLODTransition
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_DitheredLODTransition) & UMaterial.__PropertyMask_DitheredLODTransition) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_DitheredLODTransition) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_DitheredLODTransition) & ~UMaterial.__PropertyMask_DitheredLODTransition) | (value ? UMaterial.__PropertyMask_DitheredLODTransition : 0));
			}
		}

		// Token: 0x17002B0D RID: 11021
		// (get) Token: 0x0600BB1C RID: 47900 RVA: 0x0010A584 File Offset: 0x00108784
		// (set) Token: 0x0600BB1D RID: 47901 RVA: 0x0010A59D File Offset: 0x0010879D
		public unsafe bool DitherOpacityMask
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_DitherOpacityMask) & UMaterial.__PropertyMask_DitherOpacityMask) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_DitherOpacityMask) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_DitherOpacityMask) & ~UMaterial.__PropertyMask_DitherOpacityMask) | (value ? UMaterial.__PropertyMask_DitherOpacityMask : 0));
			}
		}

		// Token: 0x17002B0E RID: 11022
		// (get) Token: 0x0600BB1E RID: 47902 RVA: 0x0010A5CD File Offset: 0x001087CD
		// (set) Token: 0x0600BB1F RID: 47903 RVA: 0x0010A5E6 File Offset: 0x001087E6
		public unsafe bool bAllowNegativeEmissiveColor
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bAllowNegativeEmissiveColor) & UMaterial.__PropertyMask_bAllowNegativeEmissiveColor) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bAllowNegativeEmissiveColor) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bAllowNegativeEmissiveColor) & ~UMaterial.__PropertyMask_bAllowNegativeEmissiveColor) | (value ? UMaterial.__PropertyMask_bAllowNegativeEmissiveColor : 0));
			}
		}

		// Token: 0x17002B0F RID: 11023
		// (get) Token: 0x0600BB20 RID: 47904 RVA: 0x0010A616 File Offset: 0x00108816
		// (set) Token: 0x0600BB21 RID: 47905 RVA: 0x0010A62A File Offset: 0x0010882A
		public unsafe TEnumAsByte<ETranslucencyLightingMode> TranslucencyLightingMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_TranslucencyLightingMode);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_TranslucencyLightingMode) = value;
			}
		}

		// Token: 0x17002B10 RID: 11024
		// (get) Token: 0x0600BB22 RID: 47906 RVA: 0x0010A63F File Offset: 0x0010883F
		// (set) Token: 0x0600BB23 RID: 47907 RVA: 0x0010A658 File Offset: 0x00108858
		public unsafe bool bEnableMobileSeparateTranslucency
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bEnableMobileSeparateTranslucency) & UMaterial.__PropertyMask_bEnableMobileSeparateTranslucency) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bEnableMobileSeparateTranslucency) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bEnableMobileSeparateTranslucency) & ~UMaterial.__PropertyMask_bEnableMobileSeparateTranslucency) | (value ? UMaterial.__PropertyMask_bEnableMobileSeparateTranslucency : 0));
			}
		}

		// Token: 0x17002B11 RID: 11025
		// (get) Token: 0x0600BB24 RID: 47908 RVA: 0x0010A688 File Offset: 0x00108888
		// (set) Token: 0x0600BB25 RID: 47909 RVA: 0x0010A6A1 File Offset: 0x001088A1
		public unsafe bool bUseNormalDither
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUseNormalDither) & UMaterial.__PropertyMask_bUseNormalDither) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUseNormalDither) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUseNormalDither) & ~UMaterial.__PropertyMask_bUseNormalDither) | (value ? UMaterial.__PropertyMask_bUseNormalDither : 0));
			}
		}

		// Token: 0x17002B12 RID: 11026
		// (get) Token: 0x0600BB26 RID: 47910 RVA: 0x0010A6D1 File Offset: 0x001088D1
		// (set) Token: 0x0600BB27 RID: 47911 RVA: 0x0010A6E1 File Offset: 0x001088E1
		public unsafe float NormalDitherScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_NormalDitherScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_NormalDitherScale) = value;
			}
		}

		// Token: 0x17002B13 RID: 11027
		// (get) Token: 0x0600BB28 RID: 47912 RVA: 0x0010A6F2 File Offset: 0x001088F2
		// (set) Token: 0x0600BB29 RID: 47913 RVA: 0x0010A702 File Offset: 0x00108902
		public unsafe float WPORTCullDistScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_WPORTCullDistScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_WPORTCullDistScale) = value;
			}
		}

		// Token: 0x17002B14 RID: 11028
		// (get) Token: 0x0600BB2A RID: 47914 RVA: 0x0010A713 File Offset: 0x00108913
		// (set) Token: 0x0600BB2B RID: 47915 RVA: 0x0010A723 File Offset: 0x00108923
		public unsafe int NumCustomizedUVs
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_NumCustomizedUVs);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_NumCustomizedUVs) = value;
			}
		}

		// Token: 0x17002B15 RID: 11029
		// (get) Token: 0x0600BB2C RID: 47916 RVA: 0x0010A734 File Offset: 0x00108934
		// (set) Token: 0x0600BB2D RID: 47917 RVA: 0x0010A744 File Offset: 0x00108944
		public unsafe float TranslucencyDirectionalLightingIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_TranslucencyDirectionalLightingIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_TranslucencyDirectionalLightingIntensity) = value;
			}
		}

		// Token: 0x17002B16 RID: 11030
		// (get) Token: 0x0600BB2E RID: 47918 RVA: 0x0010A755 File Offset: 0x00108955
		// (set) Token: 0x0600BB2F RID: 47919 RVA: 0x0010A765 File Offset: 0x00108965
		public unsafe float TranslucentShadowDensityScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_TranslucentShadowDensityScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_TranslucentShadowDensityScale) = value;
			}
		}

		// Token: 0x17002B17 RID: 11031
		// (get) Token: 0x0600BB30 RID: 47920 RVA: 0x0010A776 File Offset: 0x00108976
		// (set) Token: 0x0600BB31 RID: 47921 RVA: 0x0010A786 File Offset: 0x00108986
		public unsafe float TranslucentSelfShadowDensityScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_TranslucentSelfShadowDensityScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_TranslucentSelfShadowDensityScale) = value;
			}
		}

		// Token: 0x17002B18 RID: 11032
		// (get) Token: 0x0600BB32 RID: 47922 RVA: 0x0010A797 File Offset: 0x00108997
		// (set) Token: 0x0600BB33 RID: 47923 RVA: 0x0010A7A7 File Offset: 0x001089A7
		public unsafe float TranslucentSelfShadowSecondDensityScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_TranslucentSelfShadowSecondDensityScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_TranslucentSelfShadowSecondDensityScale) = value;
			}
		}

		// Token: 0x17002B19 RID: 11033
		// (get) Token: 0x0600BB34 RID: 47924 RVA: 0x0010A7B8 File Offset: 0x001089B8
		// (set) Token: 0x0600BB35 RID: 47925 RVA: 0x0010A7C8 File Offset: 0x001089C8
		public unsafe float TranslucentSelfShadowSecondOpacity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_TranslucentSelfShadowSecondOpacity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_TranslucentSelfShadowSecondOpacity) = value;
			}
		}

		// Token: 0x17002B1A RID: 11034
		// (get) Token: 0x0600BB36 RID: 47926 RVA: 0x0010A7D9 File Offset: 0x001089D9
		// (set) Token: 0x0600BB37 RID: 47927 RVA: 0x0010A7E9 File Offset: 0x001089E9
		public unsafe float TranslucentBackscatteringExponent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_TranslucentBackscatteringExponent);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_TranslucentBackscatteringExponent) = value;
			}
		}

		// Token: 0x17002B1B RID: 11035
		// (get) Token: 0x0600BB38 RID: 47928 RVA: 0x0010A7FA File Offset: 0x001089FA
		// (set) Token: 0x0600BB39 RID: 47929 RVA: 0x0010A80E File Offset: 0x00108A0E
		public unsafe FLinearColor TranslucentMultipleScatteringExtinction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_TranslucentMultipleScatteringExtinction);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_TranslucentMultipleScatteringExtinction) = value;
			}
		}

		// Token: 0x17002B1C RID: 11036
		// (get) Token: 0x0600BB3A RID: 47930 RVA: 0x0010A823 File Offset: 0x00108A23
		// (set) Token: 0x0600BB3B RID: 47931 RVA: 0x0010A833 File Offset: 0x00108A33
		public unsafe float TranslucentShadowStartOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_TranslucentShadowStartOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_TranslucentShadowStartOffset) = value;
			}
		}

		// Token: 0x17002B1D RID: 11037
		// (get) Token: 0x0600BB3C RID: 47932 RVA: 0x0010A844 File Offset: 0x00108A44
		// (set) Token: 0x0600BB3D RID: 47933 RVA: 0x0010A85D File Offset: 0x00108A5D
		public unsafe bool bDisableDepthTest
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bDisableDepthTest) & UMaterial.__PropertyMask_bDisableDepthTest) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bDisableDepthTest) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bDisableDepthTest) & ~UMaterial.__PropertyMask_bDisableDepthTest) | (value ? UMaterial.__PropertyMask_bDisableDepthTest : 0));
			}
		}

		// Token: 0x17002B1E RID: 11038
		// (get) Token: 0x0600BB3E RID: 47934 RVA: 0x0010A88D File Offset: 0x00108A8D
		// (set) Token: 0x0600BB3F RID: 47935 RVA: 0x0010A8A6 File Offset: 0x00108AA6
		public unsafe bool bWriteOnlyAlpha
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bWriteOnlyAlpha) & UMaterial.__PropertyMask_bWriteOnlyAlpha) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bWriteOnlyAlpha) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bWriteOnlyAlpha) & ~UMaterial.__PropertyMask_bWriteOnlyAlpha) | (value ? UMaterial.__PropertyMask_bWriteOnlyAlpha : 0));
			}
		}

		// Token: 0x17002B1F RID: 11039
		// (get) Token: 0x0600BB40 RID: 47936 RVA: 0x0010A8D6 File Offset: 0x00108AD6
		// (set) Token: 0x0600BB41 RID: 47937 RVA: 0x0010A8EF File Offset: 0x00108AEF
		public unsafe bool bGenerateSphericalParticleNormals
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bGenerateSphericalParticleNormals) & UMaterial.__PropertyMask_bGenerateSphericalParticleNormals) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bGenerateSphericalParticleNormals) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bGenerateSphericalParticleNormals) & ~UMaterial.__PropertyMask_bGenerateSphericalParticleNormals) | (value ? UMaterial.__PropertyMask_bGenerateSphericalParticleNormals : 0));
			}
		}

		// Token: 0x17002B20 RID: 11040
		// (get) Token: 0x0600BB42 RID: 47938 RVA: 0x0010A91F File Offset: 0x00108B1F
		// (set) Token: 0x0600BB43 RID: 47939 RVA: 0x0010A938 File Offset: 0x00108B38
		public unsafe bool bTangentSpaceNormal
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bTangentSpaceNormal) & UMaterial.__PropertyMask_bTangentSpaceNormal) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bTangentSpaceNormal) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bTangentSpaceNormal) & ~UMaterial.__PropertyMask_bTangentSpaceNormal) | (value ? UMaterial.__PropertyMask_bTangentSpaceNormal : 0));
			}
		}

		// Token: 0x17002B21 RID: 11041
		// (get) Token: 0x0600BB44 RID: 47940 RVA: 0x0010A968 File Offset: 0x00108B68
		// (set) Token: 0x0600BB45 RID: 47941 RVA: 0x0010A981 File Offset: 0x00108B81
		public unsafe bool bUseEmissiveForDynamicAreaLighting
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUseEmissiveForDynamicAreaLighting) & UMaterial.__PropertyMask_bUseEmissiveForDynamicAreaLighting) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUseEmissiveForDynamicAreaLighting) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUseEmissiveForDynamicAreaLighting) & ~UMaterial.__PropertyMask_bUseEmissiveForDynamicAreaLighting) | (value ? UMaterial.__PropertyMask_bUseEmissiveForDynamicAreaLighting : 0));
			}
		}

		// Token: 0x17002B22 RID: 11042
		// (get) Token: 0x0600BB46 RID: 47942 RVA: 0x0010A9B1 File Offset: 0x00108BB1
		// (set) Token: 0x0600BB47 RID: 47943 RVA: 0x0010A9CA File Offset: 0x00108BCA
		public unsafe bool bBlockGI
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bBlockGI) & UMaterial.__PropertyMask_bBlockGI) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bBlockGI) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bBlockGI) & ~UMaterial.__PropertyMask_bBlockGI) | (value ? UMaterial.__PropertyMask_bBlockGI : 0));
			}
		}

		// Token: 0x17002B23 RID: 11043
		// (get) Token: 0x0600BB48 RID: 47944 RVA: 0x0010A9FA File Offset: 0x00108BFA
		// (set) Token: 0x0600BB49 RID: 47945 RVA: 0x0010AA13 File Offset: 0x00108C13
		public unsafe bool bUsedAsSpecialEngineMaterial
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedAsSpecialEngineMaterial) & UMaterial.__PropertyMask_bUsedAsSpecialEngineMaterial) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedAsSpecialEngineMaterial) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedAsSpecialEngineMaterial) & ~UMaterial.__PropertyMask_bUsedAsSpecialEngineMaterial) | (value ? UMaterial.__PropertyMask_bUsedAsSpecialEngineMaterial : 0));
			}
		}

		// Token: 0x17002B24 RID: 11044
		// (get) Token: 0x0600BB4A RID: 47946 RVA: 0x0010AA43 File Offset: 0x00108C43
		// (set) Token: 0x0600BB4B RID: 47947 RVA: 0x0010AA5C File Offset: 0x00108C5C
		public unsafe bool bUsedWithSkeletalMesh
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithSkeletalMesh) & UMaterial.__PropertyMask_bUsedWithSkeletalMesh) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithSkeletalMesh) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithSkeletalMesh) & ~UMaterial.__PropertyMask_bUsedWithSkeletalMesh) | (value ? UMaterial.__PropertyMask_bUsedWithSkeletalMesh : 0));
			}
		}

		// Token: 0x17002B25 RID: 11045
		// (get) Token: 0x0600BB4C RID: 47948 RVA: 0x0010AA8C File Offset: 0x00108C8C
		// (set) Token: 0x0600BB4D RID: 47949 RVA: 0x0010AAA5 File Offset: 0x00108CA5
		public unsafe bool bUsedWithBakedBoneMesh
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithBakedBoneMesh) & UMaterial.__PropertyMask_bUsedWithBakedBoneMesh) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithBakedBoneMesh) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithBakedBoneMesh) & ~UMaterial.__PropertyMask_bUsedWithBakedBoneMesh) | (value ? UMaterial.__PropertyMask_bUsedWithBakedBoneMesh : 0));
			}
		}

		// Token: 0x17002B26 RID: 11046
		// (get) Token: 0x0600BB4E RID: 47950 RVA: 0x0010AAD5 File Offset: 0x00108CD5
		// (set) Token: 0x0600BB4F RID: 47951 RVA: 0x0010AAEE File Offset: 0x00108CEE
		public unsafe bool bUsedWithExpandedTexcoordsSkeletalMesh
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithExpandedTexcoordsSkeletalMesh) & UMaterial.__PropertyMask_bUsedWithExpandedTexcoordsSkeletalMesh) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithExpandedTexcoordsSkeletalMesh) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithExpandedTexcoordsSkeletalMesh) & ~UMaterial.__PropertyMask_bUsedWithExpandedTexcoordsSkeletalMesh) | (value ? UMaterial.__PropertyMask_bUsedWithExpandedTexcoordsSkeletalMesh : 0));
			}
		}

		// Token: 0x17002B27 RID: 11047
		// (get) Token: 0x0600BB50 RID: 47952 RVA: 0x0010AB1E File Offset: 0x00108D1E
		// (set) Token: 0x0600BB51 RID: 47953 RVA: 0x0010AB37 File Offset: 0x00108D37
		public unsafe bool bIsOnlyForSkeletalMesh
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bIsOnlyForSkeletalMesh) & UMaterial.__PropertyMask_bIsOnlyForSkeletalMesh) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bIsOnlyForSkeletalMesh) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bIsOnlyForSkeletalMesh) & ~UMaterial.__PropertyMask_bIsOnlyForSkeletalMesh) | (value ? UMaterial.__PropertyMask_bIsOnlyForSkeletalMesh : 0));
			}
		}

		// Token: 0x17002B28 RID: 11048
		// (get) Token: 0x0600BB52 RID: 47954 RVA: 0x0010AB67 File Offset: 0x00108D67
		// (set) Token: 0x0600BB53 RID: 47955 RVA: 0x0010AB80 File Offset: 0x00108D80
		public unsafe bool bIsDisableWuYinQuLayer
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bIsDisableWuYinQuLayer) & UMaterial.__PropertyMask_bIsDisableWuYinQuLayer) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bIsDisableWuYinQuLayer) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bIsDisableWuYinQuLayer) & ~UMaterial.__PropertyMask_bIsDisableWuYinQuLayer) | (value ? UMaterial.__PropertyMask_bIsDisableWuYinQuLayer : 0));
			}
		}

		// Token: 0x17002B29 RID: 11049
		// (get) Token: 0x0600BB54 RID: 47956 RVA: 0x0010ABB0 File Offset: 0x00108DB0
		// (set) Token: 0x0600BB55 RID: 47957 RVA: 0x0010ABC9 File Offset: 0x00108DC9
		public unsafe bool bIsDisableWetLayer
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bIsDisableWetLayer) & UMaterial.__PropertyMask_bIsDisableWetLayer) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bIsDisableWetLayer) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bIsDisableWetLayer) & ~UMaterial.__PropertyMask_bIsDisableWetLayer) | (value ? UMaterial.__PropertyMask_bIsDisableWetLayer : 0));
			}
		}

		// Token: 0x17002B2A RID: 11050
		// (get) Token: 0x0600BB56 RID: 47958 RVA: 0x0010ABF9 File Offset: 0x00108DF9
		// (set) Token: 0x0600BB57 RID: 47959 RVA: 0x0010AC12 File Offset: 0x00108E12
		public unsafe bool bIsNoWaterForToon
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bIsNoWaterForToon) & UMaterial.__PropertyMask_bIsNoWaterForToon) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bIsNoWaterForToon) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bIsNoWaterForToon) & ~UMaterial.__PropertyMask_bIsNoWaterForToon) | (value ? UMaterial.__PropertyMask_bIsNoWaterForToon : 0));
			}
		}

		// Token: 0x17002B2B RID: 11051
		// (get) Token: 0x0600BB58 RID: 47960 RVA: 0x0010AC42 File Offset: 0x00108E42
		// (set) Token: 0x0600BB59 RID: 47961 RVA: 0x0010AC5B File Offset: 0x00108E5B
		public unsafe bool bUsedWithShadowSVT
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithShadowSVT) & UMaterial.__PropertyMask_bUsedWithShadowSVT) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithShadowSVT) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithShadowSVT) & ~UMaterial.__PropertyMask_bUsedWithShadowSVT) | (value ? UMaterial.__PropertyMask_bUsedWithShadowSVT : 0));
			}
		}

		// Token: 0x17002B2C RID: 11052
		// (get) Token: 0x0600BB5A RID: 47962 RVA: 0x0010AC8B File Offset: 0x00108E8B
		// (set) Token: 0x0600BB5B RID: 47963 RVA: 0x0010ACA4 File Offset: 0x00108EA4
		public unsafe bool bSingleLayerWaterRainDrop
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bSingleLayerWaterRainDrop) & UMaterial.__PropertyMask_bSingleLayerWaterRainDrop) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bSingleLayerWaterRainDrop) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bSingleLayerWaterRainDrop) & ~UMaterial.__PropertyMask_bSingleLayerWaterRainDrop) | (value ? UMaterial.__PropertyMask_bSingleLayerWaterRainDrop : 0));
			}
		}

		// Token: 0x17002B2D RID: 11053
		// (get) Token: 0x0600BB5C RID: 47964 RVA: 0x0010ACD4 File Offset: 0x00108ED4
		// (set) Token: 0x0600BB5D RID: 47965 RVA: 0x0010ACED File Offset: 0x00108EED
		public unsafe bool bSingleLayerWaterSSRProxy
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bSingleLayerWaterSSRProxy) & UMaterial.__PropertyMask_bSingleLayerWaterSSRProxy) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bSingleLayerWaterSSRProxy) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bSingleLayerWaterSSRProxy) & ~UMaterial.__PropertyMask_bSingleLayerWaterSSRProxy) | (value ? UMaterial.__PropertyMask_bSingleLayerWaterSSRProxy : 0));
			}
		}

		// Token: 0x17002B2E RID: 11054
		// (get) Token: 0x0600BB5E RID: 47966 RVA: 0x0010AD1D File Offset: 0x00108F1D
		// (set) Token: 0x0600BB5F RID: 47967 RVA: 0x0010AD36 File Offset: 0x00108F36
		public unsafe bool bWriteDepthToGbuffer
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bWriteDepthToGbuffer) & UMaterial.__PropertyMask_bWriteDepthToGbuffer) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bWriteDepthToGbuffer) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bWriteDepthToGbuffer) & ~UMaterial.__PropertyMask_bWriteDepthToGbuffer) | (value ? UMaterial.__PropertyMask_bWriteDepthToGbuffer : 0));
			}
		}

		// Token: 0x17002B2F RID: 11055
		// (get) Token: 0x0600BB60 RID: 47968 RVA: 0x0010AD66 File Offset: 0x00108F66
		// (set) Token: 0x0600BB61 RID: 47969 RVA: 0x0010AD7F File Offset: 0x00108F7F
		public unsafe bool bUseAnisotropy
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUseAnisotropy) & UMaterial.__PropertyMask_bUseAnisotropy) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUseAnisotropy) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUseAnisotropy) & ~UMaterial.__PropertyMask_bUseAnisotropy) | (value ? UMaterial.__PropertyMask_bUseAnisotropy : 0));
			}
		}

		// Token: 0x17002B30 RID: 11056
		// (get) Token: 0x0600BB62 RID: 47970 RVA: 0x0010ADAF File Offset: 0x00108FAF
		// (set) Token: 0x0600BB63 RID: 47971 RVA: 0x0010ADC8 File Offset: 0x00108FC8
		public unsafe bool bKuroSceneTranslucency
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bKuroSceneTranslucency) & UMaterial.__PropertyMask_bKuroSceneTranslucency) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bKuroSceneTranslucency) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bKuroSceneTranslucency) & ~UMaterial.__PropertyMask_bKuroSceneTranslucency) | (value ? UMaterial.__PropertyMask_bKuroSceneTranslucency : 0));
			}
		}

		// Token: 0x17002B31 RID: 11057
		// (get) Token: 0x0600BB64 RID: 47972 RVA: 0x0010ADF8 File Offset: 0x00108FF8
		// (set) Token: 0x0600BB65 RID: 47973 RVA: 0x0010AE11 File Offset: 0x00109011
		public unsafe bool bKuroTranslucencyWaterMasked
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bKuroTranslucencyWaterMasked) & UMaterial.__PropertyMask_bKuroTranslucencyWaterMasked) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bKuroTranslucencyWaterMasked) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bKuroTranslucencyWaterMasked) & ~UMaterial.__PropertyMask_bKuroTranslucencyWaterMasked) | (value ? UMaterial.__PropertyMask_bKuroTranslucencyWaterMasked : 0));
			}
		}

		// Token: 0x17002B32 RID: 11058
		// (get) Token: 0x0600BB66 RID: 47974 RVA: 0x0010AE41 File Offset: 0x00109041
		// (set) Token: 0x0600BB67 RID: 47975 RVA: 0x0010AE5A File Offset: 0x0010905A
		public unsafe bool bKuroVolumeCloud
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bKuroVolumeCloud) & UMaterial.__PropertyMask_bKuroVolumeCloud) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bKuroVolumeCloud) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bKuroVolumeCloud) & ~UMaterial.__PropertyMask_bKuroVolumeCloud) | (value ? UMaterial.__PropertyMask_bKuroVolumeCloud : 0));
			}
		}

		// Token: 0x17002B33 RID: 11059
		// (get) Token: 0x0600BB68 RID: 47976 RVA: 0x0010AE8A File Offset: 0x0010908A
		// (set) Token: 0x0600BB69 RID: 47977 RVA: 0x0010AEA3 File Offset: 0x001090A3
		public unsafe bool bKuroDownsampleTranslucency
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bKuroDownsampleTranslucency) & UMaterial.__PropertyMask_bKuroDownsampleTranslucency) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bKuroDownsampleTranslucency) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bKuroDownsampleTranslucency) & ~UMaterial.__PropertyMask_bKuroDownsampleTranslucency) | (value ? UMaterial.__PropertyMask_bKuroDownsampleTranslucency : 0));
			}
		}

		// Token: 0x17002B34 RID: 11060
		// (get) Token: 0x0600BB6A RID: 47978 RVA: 0x0010AED3 File Offset: 0x001090D3
		// (set) Token: 0x0600BB6B RID: 47979 RVA: 0x0010AEEC File Offset: 0x001090EC
		public unsafe bool bKuroTranslucencyWriteDepth
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bKuroTranslucencyWriteDepth) & UMaterial.__PropertyMask_bKuroTranslucencyWriteDepth) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bKuroTranslucencyWriteDepth) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bKuroTranslucencyWriteDepth) & ~UMaterial.__PropertyMask_bKuroTranslucencyWriteDepth) | (value ? UMaterial.__PropertyMask_bKuroTranslucencyWriteDepth : 0));
			}
		}

		// Token: 0x17002B35 RID: 11061
		// (get) Token: 0x0600BB6C RID: 47980 RVA: 0x0010AF1C File Offset: 0x0010911C
		// (set) Token: 0x0600BB6D RID: 47981 RVA: 0x0010AF35 File Offset: 0x00109135
		public unsafe bool bKuroFakeDecalStencil
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bKuroFakeDecalStencil) & UMaterial.__PropertyMask_bKuroFakeDecalStencil) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bKuroFakeDecalStencil) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bKuroFakeDecalStencil) & ~UMaterial.__PropertyMask_bKuroFakeDecalStencil) | (value ? UMaterial.__PropertyMask_bKuroFakeDecalStencil : 0));
			}
		}

		// Token: 0x17002B36 RID: 11062
		// (get) Token: 0x0600BB6E RID: 47982 RVA: 0x0010AF65 File Offset: 0x00109165
		// (set) Token: 0x0600BB6F RID: 47983 RVA: 0x0010AF7E File Offset: 0x0010917E
		public unsafe bool bUsedWithOutline
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithOutline) & UMaterial.__PropertyMask_bUsedWithOutline) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithOutline) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithOutline) & ~UMaterial.__PropertyMask_bUsedWithOutline) | (value ? UMaterial.__PropertyMask_bUsedWithOutline : 0));
			}
		}

		// Token: 0x17002B37 RID: 11063
		// (get) Token: 0x0600BB70 RID: 47984 RVA: 0x0010AFAE File Offset: 0x001091AE
		// (set) Token: 0x0600BB71 RID: 47985 RVA: 0x0010AFC7 File Offset: 0x001091C7
		public unsafe bool bUsedWithStencilOnlyWrite
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithStencilOnlyWrite) & UMaterial.__PropertyMask_bUsedWithStencilOnlyWrite) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithStencilOnlyWrite) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithStencilOnlyWrite) & ~UMaterial.__PropertyMask_bUsedWithStencilOnlyWrite) | (value ? UMaterial.__PropertyMask_bUsedWithStencilOnlyWrite : 0));
			}
		}

		// Token: 0x17002B38 RID: 11064
		// (get) Token: 0x0600BB72 RID: 47986 RVA: 0x0010AFF7 File Offset: 0x001091F7
		// (set) Token: 0x0600BB73 RID: 47987 RVA: 0x0010B010 File Offset: 0x00109210
		public unsafe bool bUsedWithFaceShadowMesh
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithFaceShadowMesh) & UMaterial.__PropertyMask_bUsedWithFaceShadowMesh) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithFaceShadowMesh) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithFaceShadowMesh) & ~UMaterial.__PropertyMask_bUsedWithFaceShadowMesh) | (value ? UMaterial.__PropertyMask_bUsedWithFaceShadowMesh : 0));
			}
		}

		// Token: 0x17002B39 RID: 11065
		// (get) Token: 0x0600BB74 RID: 47988 RVA: 0x0010B040 File Offset: 0x00109240
		// (set) Token: 0x0600BB75 RID: 47989 RVA: 0x0010B059 File Offset: 0x00109259
		public unsafe bool bUsedWithEmpty
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithEmpty) & UMaterial.__PropertyMask_bUsedWithEmpty) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithEmpty) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithEmpty) & ~UMaterial.__PropertyMask_bUsedWithEmpty) | (value ? UMaterial.__PropertyMask_bUsedWithEmpty : 0));
			}
		}

		// Token: 0x17002B3A RID: 11066
		// (get) Token: 0x0600BB76 RID: 47990 RVA: 0x0010B089 File Offset: 0x00109289
		// (set) Token: 0x0600BB77 RID: 47991 RVA: 0x0010B0A2 File Offset: 0x001092A2
		public unsafe bool bUsedForGenerate2DMap
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedForGenerate2DMap) & UMaterial.__PropertyMask_bUsedForGenerate2DMap) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedForGenerate2DMap) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedForGenerate2DMap) & ~UMaterial.__PropertyMask_bUsedForGenerate2DMap) | (value ? UMaterial.__PropertyMask_bUsedForGenerate2DMap : 0));
			}
		}

		// Token: 0x17002B3B RID: 11067
		// (get) Token: 0x0600BB78 RID: 47992 RVA: 0x0010B0D2 File Offset: 0x001092D2
		// (set) Token: 0x0600BB79 RID: 47993 RVA: 0x0010B0E2 File Offset: 0x001092E2
		public unsafe byte Generate2DMapStencil
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_Generate2DMapStencil);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_Generate2DMapStencil) = value;
			}
		}

		// Token: 0x17002B3C RID: 11068
		// (get) Token: 0x0600BB7A RID: 47994 RVA: 0x0010B0F3 File Offset: 0x001092F3
		// (set) Token: 0x0600BB7B RID: 47995 RVA: 0x0010B10C File Offset: 0x0010930C
		public unsafe bool bLandscapeMaterialWithHoles
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bLandscapeMaterialWithHoles) & UMaterial.__PropertyMask_bLandscapeMaterialWithHoles) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bLandscapeMaterialWithHoles) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bLandscapeMaterialWithHoles) & ~UMaterial.__PropertyMask_bLandscapeMaterialWithHoles) | (value ? UMaterial.__PropertyMask_bLandscapeMaterialWithHoles : 0));
			}
		}

		// Token: 0x17002B3D RID: 11069
		// (get) Token: 0x0600BB7C RID: 47996 RVA: 0x0010B13C File Offset: 0x0010933C
		// (set) Token: 0x0600BB7D RID: 47997 RVA: 0x0010B155 File Offset: 0x00109355
		public unsafe bool bCompileRuntimeVirtualTextureVariant
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bCompileRuntimeVirtualTextureVariant) & UMaterial.__PropertyMask_bCompileRuntimeVirtualTextureVariant) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bCompileRuntimeVirtualTextureVariant) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bCompileRuntimeVirtualTextureVariant) & ~UMaterial.__PropertyMask_bCompileRuntimeVirtualTextureVariant) | (value ? UMaterial.__PropertyMask_bCompileRuntimeVirtualTextureVariant : 0));
			}
		}

		// Token: 0x17002B3E RID: 11070
		// (get) Token: 0x0600BB7E RID: 47998 RVA: 0x0010B185 File Offset: 0x00109385
		// (set) Token: 0x0600BB7F RID: 47999 RVA: 0x0010B19E File Offset: 0x0010939E
		public unsafe bool bBakeImposter
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bBakeImposter) & UMaterial.__PropertyMask_bBakeImposter) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bBakeImposter) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bBakeImposter) & ~UMaterial.__PropertyMask_bBakeImposter) | (value ? UMaterial.__PropertyMask_bBakeImposter : 0));
			}
		}

		// Token: 0x17002B3F RID: 11071
		// (get) Token: 0x0600BB80 RID: 48000 RVA: 0x0010B1CE File Offset: 0x001093CE
		// (set) Token: 0x0600BB81 RID: 48001 RVA: 0x0010B1E7 File Offset: 0x001093E7
		public unsafe bool bUsedWithHLODVertexCompression
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithHLODVertexCompression) & UMaterial.__PropertyMask_bUsedWithHLODVertexCompression) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithHLODVertexCompression) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithHLODVertexCompression) & ~UMaterial.__PropertyMask_bUsedWithHLODVertexCompression) | (value ? UMaterial.__PropertyMask_bUsedWithHLODVertexCompression : 0));
			}
		}

		// Token: 0x17002B40 RID: 11072
		// (get) Token: 0x0600BB82 RID: 48002 RVA: 0x0010B217 File Offset: 0x00109417
		// (set) Token: 0x0600BB83 RID: 48003 RVA: 0x0010B230 File Offset: 0x00109430
		public unsafe bool bHasPreDepthPass
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bHasPreDepthPass) & UMaterial.__PropertyMask_bHasPreDepthPass) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bHasPreDepthPass) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bHasPreDepthPass) & ~UMaterial.__PropertyMask_bHasPreDepthPass) | (value ? UMaterial.__PropertyMask_bHasPreDepthPass : 0));
			}
		}

		// Token: 0x17002B41 RID: 11073
		// (get) Token: 0x0600BB84 RID: 48004 RVA: 0x0010B260 File Offset: 0x00109460
		// (set) Token: 0x0600BB85 RID: 48005 RVA: 0x0010B279 File Offset: 0x00109479
		public unsafe bool bMobileNoPreDepthPass
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bMobileNoPreDepthPass) & UMaterial.__PropertyMask_bMobileNoPreDepthPass) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bMobileNoPreDepthPass) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bMobileNoPreDepthPass) & ~UMaterial.__PropertyMask_bMobileNoPreDepthPass) | (value ? UMaterial.__PropertyMask_bMobileNoPreDepthPass : 0));
			}
		}

		// Token: 0x17002B42 RID: 11074
		// (get) Token: 0x0600BB86 RID: 48006 RVA: 0x0010B2A9 File Offset: 0x001094A9
		// (set) Token: 0x0600BB87 RID: 48007 RVA: 0x0010B2C2 File Offset: 0x001094C2
		public unsafe bool bDrawPreDepthOnly
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bDrawPreDepthOnly) & UMaterial.__PropertyMask_bDrawPreDepthOnly) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bDrawPreDepthOnly) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bDrawPreDepthOnly) & ~UMaterial.__PropertyMask_bDrawPreDepthOnly) | (value ? UMaterial.__PropertyMask_bDrawPreDepthOnly : 0));
			}
		}

		// Token: 0x17002B43 RID: 11075
		// (get) Token: 0x0600BB88 RID: 48008 RVA: 0x0010B2F2 File Offset: 0x001094F2
		// (set) Token: 0x0600BB89 RID: 48009 RVA: 0x0010B306 File Offset: 0x00109506
		public unsafe TEnumAsByte<EKuroTranslucentPreDepthTestMode> KuroTranslucentPreDepthTestMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_KuroTranslucentPreDepthTestMode);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_KuroTranslucentPreDepthTestMode) = value;
			}
		}

		// Token: 0x17002B44 RID: 11076
		// (get) Token: 0x0600BB8A RID: 48010 RVA: 0x0010B31B File Offset: 0x0010951B
		// (set) Token: 0x0600BB8B RID: 48011 RVA: 0x0010B32F File Offset: 0x0010952F
		public unsafe TEnumAsByte<EKuroTranslucentPreDepthCullMode> KuroTranslucentPreDepthCullMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_KuroTranslucentPreDepthCullMode);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_KuroTranslucentPreDepthCullMode) = value;
			}
		}

		// Token: 0x17002B45 RID: 11077
		// (get) Token: 0x0600BB8C RID: 48012 RVA: 0x0010B344 File Offset: 0x00109544
		// (set) Token: 0x0600BB8D RID: 48013 RVA: 0x0010B35D File Offset: 0x0010955D
		public unsafe bool bHasDataDistortionPass
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bHasDataDistortionPass) & UMaterial.__PropertyMask_bHasDataDistortionPass) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bHasDataDistortionPass) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bHasDataDistortionPass) & ~UMaterial.__PropertyMask_bHasDataDistortionPass) | (value ? UMaterial.__PropertyMask_bHasDataDistortionPass : 0));
			}
		}

		// Token: 0x17002B46 RID: 11078
		// (get) Token: 0x0600BB8E RID: 48014 RVA: 0x0010B38D File Offset: 0x0010958D
		// (set) Token: 0x0600BB8F RID: 48015 RVA: 0x0010B3A6 File Offset: 0x001095A6
		public unsafe bool bHasCustomWPOVariant
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bHasCustomWPOVariant) & UMaterial.__PropertyMask_bHasCustomWPOVariant) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bHasCustomWPOVariant) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bHasCustomWPOVariant) & ~UMaterial.__PropertyMask_bHasCustomWPOVariant) | (value ? UMaterial.__PropertyMask_bHasCustomWPOVariant : 0));
			}
		}

		// Token: 0x17002B47 RID: 11079
		// (get) Token: 0x0600BB90 RID: 48016 RVA: 0x0010B3D6 File Offset: 0x001095D6
		// (set) Token: 0x0600BB91 RID: 48017 RVA: 0x0010B3EF File Offset: 0x001095EF
		public unsafe bool DissolveInBurst
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_DissolveInBurst) & UMaterial.__PropertyMask_DissolveInBurst) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_DissolveInBurst) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_DissolveInBurst) & ~UMaterial.__PropertyMask_DissolveInBurst) | (value ? UMaterial.__PropertyMask_DissolveInBurst : 0));
			}
		}

		// Token: 0x17002B48 RID: 11080
		// (get) Token: 0x0600BB92 RID: 48018 RVA: 0x0010B41F File Offset: 0x0010961F
		// (set) Token: 0x0600BB93 RID: 48019 RVA: 0x0010B438 File Offset: 0x00109638
		public unsafe bool WaterDissolveInBurst
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_WaterDissolveInBurst) & UMaterial.__PropertyMask_WaterDissolveInBurst) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_WaterDissolveInBurst) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_WaterDissolveInBurst) & ~UMaterial.__PropertyMask_WaterDissolveInBurst) | (value ? UMaterial.__PropertyMask_WaterDissolveInBurst : 0));
			}
		}

		// Token: 0x17002B49 RID: 11081
		// (get) Token: 0x0600BB94 RID: 48020 RVA: 0x0010B468 File Offset: 0x00109668
		// (set) Token: 0x0600BB95 RID: 48021 RVA: 0x0010B478 File Offset: 0x00109678
		public unsafe byte ToonCustomStencilTestBit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_ToonCustomStencilTestBit);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_ToonCustomStencilTestBit) = value;
			}
		}

		// Token: 0x17002B4A RID: 11082
		// (get) Token: 0x0600BB96 RID: 48022 RVA: 0x0010B489 File Offset: 0x00109689
		// (set) Token: 0x0600BB97 RID: 48023 RVA: 0x0010B4A2 File Offset: 0x001096A2
		public unsafe bool bEffectSpaceWrite
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bEffectSpaceWrite) & UMaterial.__PropertyMask_bEffectSpaceWrite) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bEffectSpaceWrite) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bEffectSpaceWrite) & ~UMaterial.__PropertyMask_bEffectSpaceWrite) | (value ? UMaterial.__PropertyMask_bEffectSpaceWrite : 0));
			}
		}

		// Token: 0x17002B4B RID: 11083
		// (get) Token: 0x0600BB98 RID: 48024 RVA: 0x0010B4D2 File Offset: 0x001096D2
		// (set) Token: 0x0600BB99 RID: 48025 RVA: 0x0010B4EB File Offset: 0x001096EB
		public unsafe bool bEffectSpaceRead
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bEffectSpaceRead) & UMaterial.__PropertyMask_bEffectSpaceRead) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bEffectSpaceRead) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bEffectSpaceRead) & ~UMaterial.__PropertyMask_bEffectSpaceRead) | (value ? UMaterial.__PropertyMask_bEffectSpaceRead : 0));
			}
		}

		// Token: 0x17002B4C RID: 11084
		// (get) Token: 0x0600BB9A RID: 48026 RVA: 0x0010B51B File Offset: 0x0010971B
		// (set) Token: 0x0600BB9B RID: 48027 RVA: 0x0010B534 File Offset: 0x00109734
		public unsafe bool bXRayBodyStencil
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bXRayBodyStencil) & UMaterial.__PropertyMask_bXRayBodyStencil) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bXRayBodyStencil) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bXRayBodyStencil) & ~UMaterial.__PropertyMask_bXRayBodyStencil) | (value ? UMaterial.__PropertyMask_bXRayBodyStencil : 0));
			}
		}

		// Token: 0x17002B4D RID: 11085
		// (get) Token: 0x0600BB9C RID: 48028 RVA: 0x0010B564 File Offset: 0x00109764
		// (set) Token: 0x0600BB9D RID: 48029 RVA: 0x0010B57D File Offset: 0x0010977D
		public unsafe bool bRenderInKuroVolumetricLightColorMask
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bRenderInKuroVolumetricLightColorMask) & UMaterial.__PropertyMask_bRenderInKuroVolumetricLightColorMask) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bRenderInKuroVolumetricLightColorMask) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bRenderInKuroVolumetricLightColorMask) & ~UMaterial.__PropertyMask_bRenderInKuroVolumetricLightColorMask) | (value ? UMaterial.__PropertyMask_bRenderInKuroVolumetricLightColorMask : 0));
			}
		}

		// Token: 0x17002B4E RID: 11086
		// (get) Token: 0x0600BB9E RID: 48030 RVA: 0x0010B5AD File Offset: 0x001097AD
		// (set) Token: 0x0600BB9F RID: 48031 RVA: 0x0010B5C6 File Offset: 0x001097C6
		public unsafe bool bKuroBlendWaterTranslucency
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bKuroBlendWaterTranslucency) & UMaterial.__PropertyMask_bKuroBlendWaterTranslucency) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bKuroBlendWaterTranslucency) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bKuroBlendWaterTranslucency) & ~UMaterial.__PropertyMask_bKuroBlendWaterTranslucency) | (value ? UMaterial.__PropertyMask_bKuroBlendWaterTranslucency : 0));
			}
		}

		// Token: 0x17002B4F RID: 11087
		// (get) Token: 0x0600BBA0 RID: 48032 RVA: 0x0010B5F6 File Offset: 0x001097F6
		// (set) Token: 0x0600BBA1 RID: 48033 RVA: 0x0010B60F File Offset: 0x0010980F
		public unsafe bool bSupportsUBInstancing
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bSupportsUBInstancing) & UMaterial.__PropertyMask_bSupportsUBInstancing) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bSupportsUBInstancing) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bSupportsUBInstancing) & ~UMaterial.__PropertyMask_bSupportsUBInstancing) | (value ? UMaterial.__PropertyMask_bSupportsUBInstancing : 0));
			}
		}

		// Token: 0x17002B50 RID: 11088
		// (get) Token: 0x0600BBA2 RID: 48034 RVA: 0x0010B63F File Offset: 0x0010983F
		// (set) Token: 0x0600BBA3 RID: 48035 RVA: 0x0010B658 File Offset: 0x00109858
		public unsafe bool bSupportsDrawMaterialToRT
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bSupportsDrawMaterialToRT) & UMaterial.__PropertyMask_bSupportsDrawMaterialToRT) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bSupportsDrawMaterialToRT) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bSupportsDrawMaterialToRT) & ~UMaterial.__PropertyMask_bSupportsDrawMaterialToRT) | (value ? UMaterial.__PropertyMask_bSupportsDrawMaterialToRT : 0));
			}
		}

		// Token: 0x17002B51 RID: 11089
		// (get) Token: 0x0600BBA4 RID: 48036 RVA: 0x0010B688 File Offset: 0x00109888
		// (set) Token: 0x0600BBA5 RID: 48037 RVA: 0x0010B6A1 File Offset: 0x001098A1
		public unsafe bool bUsedWithEditorCompositing
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithEditorCompositing) & UMaterial.__PropertyMask_bUsedWithEditorCompositing) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithEditorCompositing) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithEditorCompositing) & ~UMaterial.__PropertyMask_bUsedWithEditorCompositing) | (value ? UMaterial.__PropertyMask_bUsedWithEditorCompositing : 0));
			}
		}

		// Token: 0x17002B52 RID: 11090
		// (get) Token: 0x0600BBA6 RID: 48038 RVA: 0x0010B6D1 File Offset: 0x001098D1
		// (set) Token: 0x0600BBA7 RID: 48039 RVA: 0x0010B6EA File Offset: 0x001098EA
		public unsafe bool bUsedWithParticleSprites
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithParticleSprites) & UMaterial.__PropertyMask_bUsedWithParticleSprites) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithParticleSprites) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithParticleSprites) & ~UMaterial.__PropertyMask_bUsedWithParticleSprites) | (value ? UMaterial.__PropertyMask_bUsedWithParticleSprites : 0));
			}
		}

		// Token: 0x17002B53 RID: 11091
		// (get) Token: 0x0600BBA8 RID: 48040 RVA: 0x0010B71A File Offset: 0x0010991A
		// (set) Token: 0x0600BBA9 RID: 48041 RVA: 0x0010B733 File Offset: 0x00109933
		public unsafe bool bUsedWithBeamTrails
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithBeamTrails) & UMaterial.__PropertyMask_bUsedWithBeamTrails) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithBeamTrails) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithBeamTrails) & ~UMaterial.__PropertyMask_bUsedWithBeamTrails) | (value ? UMaterial.__PropertyMask_bUsedWithBeamTrails : 0));
			}
		}

		// Token: 0x17002B54 RID: 11092
		// (get) Token: 0x0600BBAA RID: 48042 RVA: 0x0010B763 File Offset: 0x00109963
		// (set) Token: 0x0600BBAB RID: 48043 RVA: 0x0010B77C File Offset: 0x0010997C
		public unsafe bool bUsedWithMeshParticles
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithMeshParticles) & UMaterial.__PropertyMask_bUsedWithMeshParticles) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithMeshParticles) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithMeshParticles) & ~UMaterial.__PropertyMask_bUsedWithMeshParticles) | (value ? UMaterial.__PropertyMask_bUsedWithMeshParticles : 0));
			}
		}

		// Token: 0x17002B55 RID: 11093
		// (get) Token: 0x0600BBAC RID: 48044 RVA: 0x0010B7AC File Offset: 0x001099AC
		// (set) Token: 0x0600BBAD RID: 48045 RVA: 0x0010B7C5 File Offset: 0x001099C5
		public unsafe bool bUsedWithNiagaraSprites
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithNiagaraSprites) & UMaterial.__PropertyMask_bUsedWithNiagaraSprites) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithNiagaraSprites) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithNiagaraSprites) & ~UMaterial.__PropertyMask_bUsedWithNiagaraSprites) | (value ? UMaterial.__PropertyMask_bUsedWithNiagaraSprites : 0));
			}
		}

		// Token: 0x17002B56 RID: 11094
		// (get) Token: 0x0600BBAE RID: 48046 RVA: 0x0010B7F5 File Offset: 0x001099F5
		// (set) Token: 0x0600BBAF RID: 48047 RVA: 0x0010B80E File Offset: 0x00109A0E
		public unsafe bool bUsedWithNiagaraRibbons
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithNiagaraRibbons) & UMaterial.__PropertyMask_bUsedWithNiagaraRibbons) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithNiagaraRibbons) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithNiagaraRibbons) & ~UMaterial.__PropertyMask_bUsedWithNiagaraRibbons) | (value ? UMaterial.__PropertyMask_bUsedWithNiagaraRibbons : 0));
			}
		}

		// Token: 0x17002B57 RID: 11095
		// (get) Token: 0x0600BBB0 RID: 48048 RVA: 0x0010B83E File Offset: 0x00109A3E
		// (set) Token: 0x0600BBB1 RID: 48049 RVA: 0x0010B857 File Offset: 0x00109A57
		public unsafe bool bUsedWithNiagaraMeshParticles
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithNiagaraMeshParticles) & UMaterial.__PropertyMask_bUsedWithNiagaraMeshParticles) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithNiagaraMeshParticles) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithNiagaraMeshParticles) & ~UMaterial.__PropertyMask_bUsedWithNiagaraMeshParticles) | (value ? UMaterial.__PropertyMask_bUsedWithNiagaraMeshParticles : 0));
			}
		}

		// Token: 0x17002B58 RID: 11096
		// (get) Token: 0x0600BBB2 RID: 48050 RVA: 0x0010B887 File Offset: 0x00109A87
		// (set) Token: 0x0600BBB3 RID: 48051 RVA: 0x0010B8A0 File Offset: 0x00109AA0
		public unsafe bool bUsedWithGeometryCache
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithGeometryCache) & UMaterial.__PropertyMask_bUsedWithGeometryCache) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithGeometryCache) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithGeometryCache) & ~UMaterial.__PropertyMask_bUsedWithGeometryCache) | (value ? UMaterial.__PropertyMask_bUsedWithGeometryCache : 0));
			}
		}

		// Token: 0x17002B59 RID: 11097
		// (get) Token: 0x0600BBB4 RID: 48052 RVA: 0x0010B8D0 File Offset: 0x00109AD0
		// (set) Token: 0x0600BBB5 RID: 48053 RVA: 0x0010B8E9 File Offset: 0x00109AE9
		public unsafe bool bUsedWithStaticLighting
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithStaticLighting) & UMaterial.__PropertyMask_bUsedWithStaticLighting) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithStaticLighting) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithStaticLighting) & ~UMaterial.__PropertyMask_bUsedWithStaticLighting) | (value ? UMaterial.__PropertyMask_bUsedWithStaticLighting : 0));
			}
		}

		// Token: 0x17002B5A RID: 11098
		// (get) Token: 0x0600BBB6 RID: 48054 RVA: 0x0010B919 File Offset: 0x00109B19
		// (set) Token: 0x0600BBB7 RID: 48055 RVA: 0x0010B932 File Offset: 0x00109B32
		public unsafe bool bUsedWithMorphTargets
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithMorphTargets) & UMaterial.__PropertyMask_bUsedWithMorphTargets) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithMorphTargets) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithMorphTargets) & ~UMaterial.__PropertyMask_bUsedWithMorphTargets) | (value ? UMaterial.__PropertyMask_bUsedWithMorphTargets : 0));
			}
		}

		// Token: 0x17002B5B RID: 11099
		// (get) Token: 0x0600BBB8 RID: 48056 RVA: 0x0010B962 File Offset: 0x00109B62
		// (set) Token: 0x0600BBB9 RID: 48057 RVA: 0x0010B97B File Offset: 0x00109B7B
		public unsafe bool bUsedWithSplineMeshes
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithSplineMeshes) & UMaterial.__PropertyMask_bUsedWithSplineMeshes) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithSplineMeshes) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithSplineMeshes) & ~UMaterial.__PropertyMask_bUsedWithSplineMeshes) | (value ? UMaterial.__PropertyMask_bUsedWithSplineMeshes : 0));
			}
		}

		// Token: 0x17002B5C RID: 11100
		// (get) Token: 0x0600BBBA RID: 48058 RVA: 0x0010B9AB File Offset: 0x00109BAB
		// (set) Token: 0x0600BBBB RID: 48059 RVA: 0x0010B9C4 File Offset: 0x00109BC4
		public unsafe bool bUsedWithInstancedStaticMeshes
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithInstancedStaticMeshes) & UMaterial.__PropertyMask_bUsedWithInstancedStaticMeshes) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithInstancedStaticMeshes) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithInstancedStaticMeshes) & ~UMaterial.__PropertyMask_bUsedWithInstancedStaticMeshes) | (value ? UMaterial.__PropertyMask_bUsedWithInstancedStaticMeshes : 0));
			}
		}

		// Token: 0x17002B5D RID: 11101
		// (get) Token: 0x0600BBBC RID: 48060 RVA: 0x0010B9F4 File Offset: 0x00109BF4
		// (set) Token: 0x0600BBBD RID: 48061 RVA: 0x0010BA0D File Offset: 0x00109C0D
		public unsafe bool bUsedWithGeometryCollections
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithGeometryCollections) & UMaterial.__PropertyMask_bUsedWithGeometryCollections) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithGeometryCollections) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithGeometryCollections) & ~UMaterial.__PropertyMask_bUsedWithGeometryCollections) | (value ? UMaterial.__PropertyMask_bUsedWithGeometryCollections : 0));
			}
		}

		// Token: 0x17002B5E RID: 11102
		// (get) Token: 0x0600BBBE RID: 48062 RVA: 0x0010BA3D File Offset: 0x00109C3D
		// (set) Token: 0x0600BBBF RID: 48063 RVA: 0x0010BA56 File Offset: 0x00109C56
		public unsafe bool bUsesDistortion
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsesDistortion) & UMaterial.__PropertyMask_bUsesDistortion) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsesDistortion) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsesDistortion) & ~UMaterial.__PropertyMask_bUsesDistortion) | (value ? UMaterial.__PropertyMask_bUsesDistortion : 0));
			}
		}

		// Token: 0x17002B5F RID: 11103
		// (get) Token: 0x0600BBC0 RID: 48064 RVA: 0x0010BA86 File Offset: 0x00109C86
		// (set) Token: 0x0600BBC1 RID: 48065 RVA: 0x0010BA9F File Offset: 0x00109C9F
		public unsafe bool bUsedWithClothing
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithClothing) & UMaterial.__PropertyMask_bUsedWithClothing) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithClothing) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithClothing) & ~UMaterial.__PropertyMask_bUsedWithClothing) | (value ? UMaterial.__PropertyMask_bUsedWithClothing : 0));
			}
		}

		// Token: 0x17002B60 RID: 11104
		// (get) Token: 0x0600BBC2 RID: 48066 RVA: 0x0010BACF File Offset: 0x00109CCF
		// (set) Token: 0x0600BBC3 RID: 48067 RVA: 0x0010BAE8 File Offset: 0x00109CE8
		public unsafe bool bUsedWithWater
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithWater) & UMaterial.__PropertyMask_bUsedWithWater) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithWater) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithWater) & ~UMaterial.__PropertyMask_bUsedWithWater) | (value ? UMaterial.__PropertyMask_bUsedWithWater : 0));
			}
		}

		// Token: 0x17002B61 RID: 11105
		// (get) Token: 0x0600BBC4 RID: 48068 RVA: 0x0010BB18 File Offset: 0x00109D18
		// (set) Token: 0x0600BBC5 RID: 48069 RVA: 0x0010BB31 File Offset: 0x00109D31
		public unsafe bool bUsedWithHairStrands
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithHairStrands) & UMaterial.__PropertyMask_bUsedWithHairStrands) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithHairStrands) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithHairStrands) & ~UMaterial.__PropertyMask_bUsedWithHairStrands) | (value ? UMaterial.__PropertyMask_bUsedWithHairStrands : 0));
			}
		}

		// Token: 0x17002B62 RID: 11106
		// (get) Token: 0x0600BBC6 RID: 48070 RVA: 0x0010BB61 File Offset: 0x00109D61
		// (set) Token: 0x0600BBC7 RID: 48071 RVA: 0x0010BB7A File Offset: 0x00109D7A
		public unsafe bool bUsedWithLidarPointCloud
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithLidarPointCloud) & UMaterial.__PropertyMask_bUsedWithLidarPointCloud) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithLidarPointCloud) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithLidarPointCloud) & ~UMaterial.__PropertyMask_bUsedWithLidarPointCloud) | (value ? UMaterial.__PropertyMask_bUsedWithLidarPointCloud : 0));
			}
		}

		// Token: 0x17002B63 RID: 11107
		// (get) Token: 0x0600BBC8 RID: 48072 RVA: 0x0010BBAA File Offset: 0x00109DAA
		// (set) Token: 0x0600BBC9 RID: 48073 RVA: 0x0010BBC3 File Offset: 0x00109DC3
		public unsafe bool bUsedWithVirtualHeightfieldMesh
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithVirtualHeightfieldMesh) & UMaterial.__PropertyMask_bUsedWithVirtualHeightfieldMesh) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithVirtualHeightfieldMesh) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithVirtualHeightfieldMesh) & ~UMaterial.__PropertyMask_bUsedWithVirtualHeightfieldMesh) | (value ? UMaterial.__PropertyMask_bUsedWithVirtualHeightfieldMesh : 0));
			}
		}

		// Token: 0x17002B64 RID: 11108
		// (get) Token: 0x0600BBCA RID: 48074 RVA: 0x0010BBF3 File Offset: 0x00109DF3
		// (set) Token: 0x0600BBCB RID: 48075 RVA: 0x0010BC0C File Offset: 0x00109E0C
		public unsafe bool bRemoveLocalVertexFactory
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bRemoveLocalVertexFactory) & UMaterial.__PropertyMask_bRemoveLocalVertexFactory) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bRemoveLocalVertexFactory) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bRemoveLocalVertexFactory) & ~UMaterial.__PropertyMask_bRemoveLocalVertexFactory) | (value ? UMaterial.__PropertyMask_bRemoveLocalVertexFactory : 0));
			}
		}

		// Token: 0x17002B65 RID: 11109
		// (get) Token: 0x0600BBCC RID: 48076 RVA: 0x0010BC3C File Offset: 0x00109E3C
		// (set) Token: 0x0600BBCD RID: 48077 RVA: 0x0010BC55 File Offset: 0x00109E55
		public unsafe bool bUsedWithMarchingCubes
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithMarchingCubes) & UMaterial.__PropertyMask_bUsedWithMarchingCubes) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithMarchingCubes) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithMarchingCubes) & ~UMaterial.__PropertyMask_bUsedWithMarchingCubes) | (value ? UMaterial.__PropertyMask_bUsedWithMarchingCubes : 0));
			}
		}

		// Token: 0x17002B66 RID: 11110
		// (get) Token: 0x0600BBCE RID: 48078 RVA: 0x0010BC85 File Offset: 0x00109E85
		// (set) Token: 0x0600BBCF RID: 48079 RVA: 0x0010BC9E File Offset: 0x00109E9E
		public unsafe bool bUsedWithKuroCSInteractiveObject
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithKuroCSInteractiveObject) & UMaterial.__PropertyMask_bUsedWithKuroCSInteractiveObject) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithKuroCSInteractiveObject) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithKuroCSInteractiveObject) & ~UMaterial.__PropertyMask_bUsedWithKuroCSInteractiveObject) | (value ? UMaterial.__PropertyMask_bUsedWithKuroCSInteractiveObject : 0));
			}
		}

		// Token: 0x17002B67 RID: 11111
		// (get) Token: 0x0600BBD0 RID: 48080 RVA: 0x0010BCCE File Offset: 0x00109ECE
		// (set) Token: 0x0600BBD1 RID: 48081 RVA: 0x0010BCE7 File Offset: 0x00109EE7
		public unsafe bool bUsedWithNanite
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithNanite) & UMaterial.__PropertyMask_bUsedWithNanite) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithNanite) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithNanite) & ~UMaterial.__PropertyMask_bUsedWithNanite) | (value ? UMaterial.__PropertyMask_bUsedWithNanite : 0));
			}
		}

		// Token: 0x17002B68 RID: 11112
		// (get) Token: 0x0600BBD2 RID: 48082 RVA: 0x0010BD17 File Offset: 0x00109F17
		// (set) Token: 0x0600BBD3 RID: 48083 RVA: 0x0010BD30 File Offset: 0x00109F30
		public unsafe bool bUsedWithVolumetricCloud
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithVolumetricCloud) & UMaterial.__PropertyMask_bUsedWithVolumetricCloud) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithVolumetricCloud) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithVolumetricCloud) & ~UMaterial.__PropertyMask_bUsedWithVolumetricCloud) | (value ? UMaterial.__PropertyMask_bUsedWithVolumetricCloud : 0));
			}
		}

		// Token: 0x17002B69 RID: 11113
		// (get) Token: 0x0600BBD4 RID: 48084 RVA: 0x0010BD60 File Offset: 0x00109F60
		// (set) Token: 0x0600BBD5 RID: 48085 RVA: 0x0010BD79 File Offset: 0x00109F79
		public unsafe bool bUsedWithHeterogeneousVolumes
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithHeterogeneousVolumes) & UMaterial.__PropertyMask_bUsedWithHeterogeneousVolumes) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithHeterogeneousVolumes) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithHeterogeneousVolumes) & ~UMaterial.__PropertyMask_bUsedWithHeterogeneousVolumes) | (value ? UMaterial.__PropertyMask_bUsedWithHeterogeneousVolumes : 0));
			}
		}

		// Token: 0x17002B6A RID: 11114
		// (get) Token: 0x0600BBD6 RID: 48086 RVA: 0x0010BDA9 File Offset: 0x00109FA9
		// (set) Token: 0x0600BBD7 RID: 48087 RVA: 0x0010BDC2 File Offset: 0x00109FC2
		public unsafe bool bUsedWithTransvoxel
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithTransvoxel) & UMaterial.__PropertyMask_bUsedWithTransvoxel) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithTransvoxel) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithTransvoxel) & ~UMaterial.__PropertyMask_bUsedWithTransvoxel) | (value ? UMaterial.__PropertyMask_bUsedWithTransvoxel : 0));
			}
		}

		// Token: 0x17002B6B RID: 11115
		// (get) Token: 0x0600BBD8 RID: 48088 RVA: 0x0010BDF2 File Offset: 0x00109FF2
		// (set) Token: 0x0600BBD9 RID: 48089 RVA: 0x0010BE0B File Offset: 0x0010A00B
		public unsafe bool bUsedWithUI_DEPRECATED
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithUI_DEPRECATED) & UMaterial.__PropertyMask_bUsedWithUI_DEPRECATED) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithUI_DEPRECATED) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithUI_DEPRECATED) & ~UMaterial.__PropertyMask_bUsedWithUI_DEPRECATED) | (value ? UMaterial.__PropertyMask_bUsedWithUI_DEPRECATED : 0));
			}
		}

		// Token: 0x17002B6C RID: 11116
		// (get) Token: 0x0600BBDA RID: 48090 RVA: 0x0010BE3B File Offset: 0x0010A03B
		// (set) Token: 0x0600BBDB RID: 48091 RVA: 0x0010BE54 File Offset: 0x0010A054
		public unsafe bool bAutomaticallySetUsageInEditor
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bAutomaticallySetUsageInEditor) & UMaterial.__PropertyMask_bAutomaticallySetUsageInEditor) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bAutomaticallySetUsageInEditor) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bAutomaticallySetUsageInEditor) & ~UMaterial.__PropertyMask_bAutomaticallySetUsageInEditor) | (value ? UMaterial.__PropertyMask_bAutomaticallySetUsageInEditor : 0));
			}
		}

		// Token: 0x17002B6D RID: 11117
		// (get) Token: 0x0600BBDC RID: 48092 RVA: 0x0010BE84 File Offset: 0x0010A084
		// (set) Token: 0x0600BBDD RID: 48093 RVA: 0x0010BE98 File Offset: 0x0010A098
		public unsafe TEnumAsByte<EMaterialPipelineStateCreationHint> PipelineStateCreationHint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_PipelineStateCreationHint);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_PipelineStateCreationHint) = value;
			}
		}

		// Token: 0x17002B6E RID: 11118
		// (get) Token: 0x0600BBDE RID: 48094 RVA: 0x0010BEAD File Offset: 0x0010A0AD
		// (set) Token: 0x0600BBDF RID: 48095 RVA: 0x0010BEC6 File Offset: 0x0010A0C6
		public unsafe bool bFullyRough
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bFullyRough) & UMaterial.__PropertyMask_bFullyRough) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bFullyRough) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bFullyRough) & ~UMaterial.__PropertyMask_bFullyRough) | (value ? UMaterial.__PropertyMask_bFullyRough : 0));
			}
		}

		// Token: 0x17002B6F RID: 11119
		// (get) Token: 0x0600BBE0 RID: 48096 RVA: 0x0010BEF6 File Offset: 0x0010A0F6
		// (set) Token: 0x0600BBE1 RID: 48097 RVA: 0x0010BF0F File Offset: 0x0010A10F
		public unsafe bool bUseFullPrecision
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUseFullPrecision) & UMaterial.__PropertyMask_bUseFullPrecision) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUseFullPrecision) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUseFullPrecision) & ~UMaterial.__PropertyMask_bUseFullPrecision) | (value ? UMaterial.__PropertyMask_bUseFullPrecision : 0));
			}
		}

		// Token: 0x17002B70 RID: 11120
		// (get) Token: 0x0600BBE2 RID: 48098 RVA: 0x0010BF3F File Offset: 0x0010A13F
		// (set) Token: 0x0600BBE3 RID: 48099 RVA: 0x0010BF53 File Offset: 0x0010A153
		public unsafe TEnumAsByte<EUseFullPrecisionPlatform> FullPrecisionPlatform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_FullPrecisionPlatform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_FullPrecisionPlatform) = value;
			}
		}

		// Token: 0x17002B71 RID: 11121
		// (get) Token: 0x0600BBE4 RID: 48100 RVA: 0x0010BF68 File Offset: 0x0010A168
		// (set) Token: 0x0600BBE5 RID: 48101 RVA: 0x0010BF81 File Offset: 0x0010A181
		public unsafe bool bUseFullPrecisionParams
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUseFullPrecisionParams) & UMaterial.__PropertyMask_bUseFullPrecisionParams) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUseFullPrecisionParams) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUseFullPrecisionParams) & ~UMaterial.__PropertyMask_bUseFullPrecisionParams) | (value ? UMaterial.__PropertyMask_bUseFullPrecisionParams : 0));
			}
		}

		// Token: 0x17002B72 RID: 11122
		// (get) Token: 0x0600BBE6 RID: 48102 RVA: 0x0010BFB1 File Offset: 0x0010A1B1
		// (set) Token: 0x0600BBE7 RID: 48103 RVA: 0x0010BFC5 File Offset: 0x0010A1C5
		public unsafe TEnumAsByte<EUseFullPrecisionPlatform> FullPrecisionParamsPlatform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_FullPrecisionParamsPlatform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_FullPrecisionParamsPlatform) = value;
			}
		}

		// Token: 0x17002B73 RID: 11123
		// (get) Token: 0x0600BBE8 RID: 48104 RVA: 0x0010BFDA File Offset: 0x0010A1DA
		// (set) Token: 0x0600BBE9 RID: 48105 RVA: 0x0010BFF3 File Offset: 0x0010A1F3
		public unsafe bool bUseHalfPrecisionVS
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUseHalfPrecisionVS) & UMaterial.__PropertyMask_bUseHalfPrecisionVS) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUseHalfPrecisionVS) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUseHalfPrecisionVS) & ~UMaterial.__PropertyMask_bUseHalfPrecisionVS) | (value ? UMaterial.__PropertyMask_bUseHalfPrecisionVS : 0));
			}
		}

		// Token: 0x17002B74 RID: 11124
		// (get) Token: 0x0600BBEA RID: 48106 RVA: 0x0010C023 File Offset: 0x0010A223
		// (set) Token: 0x0600BBEB RID: 48107 RVA: 0x0010C03C File Offset: 0x0010A23C
		public unsafe bool bUseLightmapDirectionality
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUseLightmapDirectionality) & UMaterial.__PropertyMask_bUseLightmapDirectionality) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUseLightmapDirectionality) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUseLightmapDirectionality) & ~UMaterial.__PropertyMask_bUseLightmapDirectionality) | (value ? UMaterial.__PropertyMask_bUseLightmapDirectionality : 0));
			}
		}

		// Token: 0x17002B75 RID: 11125
		// (get) Token: 0x0600BBEC RID: 48108 RVA: 0x0010C06C File Offset: 0x0010A26C
		// (set) Token: 0x0600BBED RID: 48109 RVA: 0x0010C085 File Offset: 0x0010A285
		public unsafe bool bUseAlphaToCoverage
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUseAlphaToCoverage) & UMaterial.__PropertyMask_bUseAlphaToCoverage) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUseAlphaToCoverage) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUseAlphaToCoverage) & ~UMaterial.__PropertyMask_bUseAlphaToCoverage) | (value ? UMaterial.__PropertyMask_bUseAlphaToCoverage : 0));
			}
		}

		// Token: 0x17002B76 RID: 11126
		// (get) Token: 0x0600BBEE RID: 48110 RVA: 0x0010C0B5 File Offset: 0x0010A2B5
		// (set) Token: 0x0600BBEF RID: 48111 RVA: 0x0010C0CE File Offset: 0x0010A2CE
		public unsafe bool bForwardRenderUsePreintegratedGFForSimpleIBL
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bForwardRenderUsePreintegratedGFForSimpleIBL) & UMaterial.__PropertyMask_bForwardRenderUsePreintegratedGFForSimpleIBL) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bForwardRenderUsePreintegratedGFForSimpleIBL) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bForwardRenderUsePreintegratedGFForSimpleIBL) & ~UMaterial.__PropertyMask_bForwardRenderUsePreintegratedGFForSimpleIBL) | (value ? UMaterial.__PropertyMask_bForwardRenderUsePreintegratedGFForSimpleIBL : 0));
			}
		}

		// Token: 0x17002B77 RID: 11127
		// (get) Token: 0x0600BBF0 RID: 48112 RVA: 0x0010C0FE File Offset: 0x0010A2FE
		// (set) Token: 0x0600BBF1 RID: 48113 RVA: 0x0010C117 File Offset: 0x0010A317
		public unsafe bool bUseHQForwardReflections
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUseHQForwardReflections) & UMaterial.__PropertyMask_bUseHQForwardReflections) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUseHQForwardReflections) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUseHQForwardReflections) & ~UMaterial.__PropertyMask_bUseHQForwardReflections) | (value ? UMaterial.__PropertyMask_bUseHQForwardReflections : 0));
			}
		}

		// Token: 0x17002B78 RID: 11128
		// (get) Token: 0x0600BBF2 RID: 48114 RVA: 0x0010C147 File Offset: 0x0010A347
		// (set) Token: 0x0600BBF3 RID: 48115 RVA: 0x0010C160 File Offset: 0x0010A360
		public unsafe bool bUsePlanarForwardReflections
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsePlanarForwardReflections) & UMaterial.__PropertyMask_bUsePlanarForwardReflections) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsePlanarForwardReflections) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsePlanarForwardReflections) & ~UMaterial.__PropertyMask_bUsePlanarForwardReflections) | (value ? UMaterial.__PropertyMask_bUsePlanarForwardReflections : 0));
			}
		}

		// Token: 0x17002B79 RID: 11129
		// (get) Token: 0x0600BBF4 RID: 48116 RVA: 0x0010C190 File Offset: 0x0010A390
		// (set) Token: 0x0600BBF5 RID: 48117 RVA: 0x0010C1A9 File Offset: 0x0010A3A9
		public unsafe bool bNormalCurvatureToRoughness
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bNormalCurvatureToRoughness) & UMaterial.__PropertyMask_bNormalCurvatureToRoughness) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bNormalCurvatureToRoughness) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bNormalCurvatureToRoughness) & ~UMaterial.__PropertyMask_bNormalCurvatureToRoughness) | (value ? UMaterial.__PropertyMask_bNormalCurvatureToRoughness : 0));
			}
		}

		// Token: 0x17002B7A RID: 11130
		// (get) Token: 0x0600BBF6 RID: 48118 RVA: 0x0010C1D9 File Offset: 0x0010A3D9
		// (set) Token: 0x0600BBF7 RID: 48119 RVA: 0x0010C1ED File Offset: 0x0010A3ED
		public unsafe TEnumAsByte<EMaterialTessellationMode> D3D11TessellationMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_D3D11TessellationMode);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_D3D11TessellationMode) = value;
			}
		}

		// Token: 0x17002B7B RID: 11131
		// (get) Token: 0x0600BBF8 RID: 48120 RVA: 0x0010C202 File Offset: 0x0010A402
		// (set) Token: 0x0600BBF9 RID: 48121 RVA: 0x0010C21B File Offset: 0x0010A41B
		public unsafe bool bEnableCrackFreeDisplacement
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bEnableCrackFreeDisplacement) & UMaterial.__PropertyMask_bEnableCrackFreeDisplacement) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bEnableCrackFreeDisplacement) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bEnableCrackFreeDisplacement) & ~UMaterial.__PropertyMask_bEnableCrackFreeDisplacement) | (value ? UMaterial.__PropertyMask_bEnableCrackFreeDisplacement : 0));
			}
		}

		// Token: 0x17002B7C RID: 11132
		// (get) Token: 0x0600BBFA RID: 48122 RVA: 0x0010C24B File Offset: 0x0010A44B
		// (set) Token: 0x0600BBFB RID: 48123 RVA: 0x0010C264 File Offset: 0x0010A464
		public unsafe bool bEnableAdaptiveTessellation
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bEnableAdaptiveTessellation) & UMaterial.__PropertyMask_bEnableAdaptiveTessellation) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bEnableAdaptiveTessellation) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bEnableAdaptiveTessellation) & ~UMaterial.__PropertyMask_bEnableAdaptiveTessellation) | (value ? UMaterial.__PropertyMask_bEnableAdaptiveTessellation : 0));
			}
		}

		// Token: 0x17002B7D RID: 11133
		// (get) Token: 0x0600BBFC RID: 48124 RVA: 0x0010C294 File Offset: 0x0010A494
		// (set) Token: 0x0600BBFD RID: 48125 RVA: 0x0010C2AD File Offset: 0x0010A4AD
		public unsafe bool bDisableTessellationInShadowPass
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bDisableTessellationInShadowPass) & UMaterial.__PropertyMask_bDisableTessellationInShadowPass) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bDisableTessellationInShadowPass) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bDisableTessellationInShadowPass) & ~UMaterial.__PropertyMask_bDisableTessellationInShadowPass) | (value ? UMaterial.__PropertyMask_bDisableTessellationInShadowPass : 0));
			}
		}

		// Token: 0x17002B7E RID: 11134
		// (get) Token: 0x0600BBFE RID: 48126 RVA: 0x0010C2DD File Offset: 0x0010A4DD
		// (set) Token: 0x0600BBFF RID: 48127 RVA: 0x0010C2F6 File Offset: 0x0010A4F6
		public unsafe bool AllowTranslucentCustomDepthWrites
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_AllowTranslucentCustomDepthWrites) & UMaterial.__PropertyMask_AllowTranslucentCustomDepthWrites) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_AllowTranslucentCustomDepthWrites) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_AllowTranslucentCustomDepthWrites) & ~UMaterial.__PropertyMask_AllowTranslucentCustomDepthWrites) | (value ? UMaterial.__PropertyMask_AllowTranslucentCustomDepthWrites : 0));
			}
		}

		// Token: 0x17002B7F RID: 11135
		// (get) Token: 0x0600BC00 RID: 48128 RVA: 0x0010C326 File Offset: 0x0010A526
		// (set) Token: 0x0600BC01 RID: 48129 RVA: 0x0010C33F File Offset: 0x0010A53F
		public unsafe bool AllowMobileSceneCustomDepthWrites
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_AllowMobileSceneCustomDepthWrites) & UMaterial.__PropertyMask_AllowMobileSceneCustomDepthWrites) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_AllowMobileSceneCustomDepthWrites) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_AllowMobileSceneCustomDepthWrites) & ~UMaterial.__PropertyMask_AllowMobileSceneCustomDepthWrites) | (value ? UMaterial.__PropertyMask_AllowMobileSceneCustomDepthWrites : 0));
			}
		}

		// Token: 0x17002B80 RID: 11136
		// (get) Token: 0x0600BC02 RID: 48130 RVA: 0x0010C36F File Offset: 0x0010A56F
		// (set) Token: 0x0600BC03 RID: 48131 RVA: 0x0010C388 File Offset: 0x0010A588
		public unsafe bool bAllowFrontLayerTranslucency
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bAllowFrontLayerTranslucency) & UMaterial.__PropertyMask_bAllowFrontLayerTranslucency) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bAllowFrontLayerTranslucency) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bAllowFrontLayerTranslucency) & ~UMaterial.__PropertyMask_bAllowFrontLayerTranslucency) | (value ? UMaterial.__PropertyMask_bAllowFrontLayerTranslucency : 0));
			}
		}

		// Token: 0x17002B81 RID: 11137
		// (get) Token: 0x0600BC04 RID: 48132 RVA: 0x0010C3B8 File Offset: 0x0010A5B8
		// (set) Token: 0x0600BC05 RID: 48133 RVA: 0x0010C3D1 File Offset: 0x0010A5D1
		public unsafe bool Wireframe
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_Wireframe) & UMaterial.__PropertyMask_Wireframe) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_Wireframe) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_Wireframe) & ~UMaterial.__PropertyMask_Wireframe) | (value ? UMaterial.__PropertyMask_Wireframe : 0));
			}
		}

		// Token: 0x17002B82 RID: 11138
		// (get) Token: 0x0600BC06 RID: 48134 RVA: 0x0010C401 File Offset: 0x0010A601
		// (set) Token: 0x0600BC07 RID: 48135 RVA: 0x0010C415 File Offset: 0x0010A615
		public unsafe TEnumAsByte<EMaterialShadingRate> ShadingRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_ShadingRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_ShadingRate) = value;
			}
		}

		// Token: 0x17002B83 RID: 11139
		// (get) Token: 0x0600BC08 RID: 48136 RVA: 0x0010C42A File Offset: 0x0010A62A
		// (set) Token: 0x0600BC09 RID: 48137 RVA: 0x0010C443 File Offset: 0x0010A643
		public unsafe bool bCanMaskedBeAssumedOpaque
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bCanMaskedBeAssumedOpaque) & UMaterial.__PropertyMask_bCanMaskedBeAssumedOpaque) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bCanMaskedBeAssumedOpaque) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bCanMaskedBeAssumedOpaque) & ~UMaterial.__PropertyMask_bCanMaskedBeAssumedOpaque) | (value ? UMaterial.__PropertyMask_bCanMaskedBeAssumedOpaque : 0));
			}
		}

		// Token: 0x17002B84 RID: 11140
		// (get) Token: 0x0600BC0A RID: 48138 RVA: 0x0010C473 File Offset: 0x0010A673
		// (set) Token: 0x0600BC0B RID: 48139 RVA: 0x0010C48C File Offset: 0x0010A68C
		public unsafe bool bIsMasked_DEPRECATED
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bIsMasked_DEPRECATED) & UMaterial.__PropertyMask_bIsMasked_DEPRECATED) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bIsMasked_DEPRECATED) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bIsMasked_DEPRECATED) & ~UMaterial.__PropertyMask_bIsMasked_DEPRECATED) | (value ? UMaterial.__PropertyMask_bIsMasked_DEPRECATED : 0));
			}
		}

		// Token: 0x17002B85 RID: 11141
		// (get) Token: 0x0600BC0C RID: 48140 RVA: 0x0010C4BC File Offset: 0x0010A6BC
		// (set) Token: 0x0600BC0D RID: 48141 RVA: 0x0010C4D5 File Offset: 0x0010A6D5
		public unsafe bool bIsPreviewMaterial
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bIsPreviewMaterial) & UMaterial.__PropertyMask_bIsPreviewMaterial) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bIsPreviewMaterial) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bIsPreviewMaterial) & ~UMaterial.__PropertyMask_bIsPreviewMaterial) | (value ? UMaterial.__PropertyMask_bIsPreviewMaterial : 0));
			}
		}

		// Token: 0x17002B86 RID: 11142
		// (get) Token: 0x0600BC0E RID: 48142 RVA: 0x0010C505 File Offset: 0x0010A705
		// (set) Token: 0x0600BC0F RID: 48143 RVA: 0x0010C51E File Offset: 0x0010A71E
		public unsafe bool bIsDebugMaterial
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bIsDebugMaterial) & UMaterial.__PropertyMask_bIsDebugMaterial) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bIsDebugMaterial) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bIsDebugMaterial) & ~UMaterial.__PropertyMask_bIsDebugMaterial) | (value ? UMaterial.__PropertyMask_bIsDebugMaterial : 0));
			}
		}

		// Token: 0x17002B87 RID: 11143
		// (get) Token: 0x0600BC10 RID: 48144 RVA: 0x0010C54E File Offset: 0x0010A74E
		// (set) Token: 0x0600BC11 RID: 48145 RVA: 0x0010C567 File Offset: 0x0010A767
		public unsafe bool bIsFunctionPreviewMaterial
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bIsFunctionPreviewMaterial) & UMaterial.__PropertyMask_bIsFunctionPreviewMaterial) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bIsFunctionPreviewMaterial) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bIsFunctionPreviewMaterial) & ~UMaterial.__PropertyMask_bIsFunctionPreviewMaterial) | (value ? UMaterial.__PropertyMask_bIsFunctionPreviewMaterial : 0));
			}
		}

		// Token: 0x17002B88 RID: 11144
		// (get) Token: 0x0600BC12 RID: 48146 RVA: 0x0010C597 File Offset: 0x0010A797
		// (set) Token: 0x0600BC13 RID: 48147 RVA: 0x0010C5B0 File Offset: 0x0010A7B0
		public unsafe bool bUseMaterialAttributes
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUseMaterialAttributes) & UMaterial.__PropertyMask_bUseMaterialAttributes) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUseMaterialAttributes) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUseMaterialAttributes) & ~UMaterial.__PropertyMask_bUseMaterialAttributes) | (value ? UMaterial.__PropertyMask_bUseMaterialAttributes : 0));
			}
		}

		// Token: 0x17002B89 RID: 11145
		// (get) Token: 0x0600BC14 RID: 48148 RVA: 0x0010C5E0 File Offset: 0x0010A7E0
		// (set) Token: 0x0600BC15 RID: 48149 RVA: 0x0010C5F9 File Offset: 0x0010A7F9
		public unsafe bool bCastRayTracedShadows
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bCastRayTracedShadows) & UMaterial.__PropertyMask_bCastRayTracedShadows) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bCastRayTracedShadows) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bCastRayTracedShadows) & ~UMaterial.__PropertyMask_bCastRayTracedShadows) | (value ? UMaterial.__PropertyMask_bCastRayTracedShadows : 0));
			}
		}

		// Token: 0x17002B8A RID: 11146
		// (get) Token: 0x0600BC16 RID: 48150 RVA: 0x0010C629 File Offset: 0x0010A829
		// (set) Token: 0x0600BC17 RID: 48151 RVA: 0x0010C642 File Offset: 0x0010A842
		public unsafe bool bCastRasterShadowsInRaytracing
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bCastRasterShadowsInRaytracing) & UMaterial.__PropertyMask_bCastRasterShadowsInRaytracing) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bCastRasterShadowsInRaytracing) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bCastRasterShadowsInRaytracing) & ~UMaterial.__PropertyMask_bCastRasterShadowsInRaytracing) | (value ? UMaterial.__PropertyMask_bCastRasterShadowsInRaytracing : 0));
			}
		}

		// Token: 0x17002B8B RID: 11147
		// (get) Token: 0x0600BC18 RID: 48152 RVA: 0x0010C672 File Offset: 0x0010A872
		// (set) Token: 0x0600BC19 RID: 48153 RVA: 0x0010C68B File Offset: 0x0010A88B
		public unsafe bool bDisableCastDynamicShadows
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bDisableCastDynamicShadows) & UMaterial.__PropertyMask_bDisableCastDynamicShadows) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bDisableCastDynamicShadows) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bDisableCastDynamicShadows) & ~UMaterial.__PropertyMask_bDisableCastDynamicShadows) | (value ? UMaterial.__PropertyMask_bDisableCastDynamicShadows : 0));
			}
		}

		// Token: 0x17002B8C RID: 11148
		// (get) Token: 0x0600BC1A RID: 48154 RVA: 0x0010C6BB File Offset: 0x0010A8BB
		// (set) Token: 0x0600BC1B RID: 48155 RVA: 0x0010C6D4 File Offset: 0x0010A8D4
		public unsafe bool bUseShadowPixelDepthOffset
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUseShadowPixelDepthOffset) & UMaterial.__PropertyMask_bUseShadowPixelDepthOffset) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUseShadowPixelDepthOffset) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUseShadowPixelDepthOffset) & ~UMaterial.__PropertyMask_bUseShadowPixelDepthOffset) | (value ? UMaterial.__PropertyMask_bUseShadowPixelDepthOffset : 0));
			}
		}

		// Token: 0x17002B8D RID: 11149
		// (get) Token: 0x0600BC1C RID: 48156 RVA: 0x0010C704 File Offset: 0x0010A904
		// (set) Token: 0x0600BC1D RID: 48157 RVA: 0x0010C71D File Offset: 0x0010A91D
		public unsafe bool bUseTranslucencyVertexFog
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUseTranslucencyVertexFog) & UMaterial.__PropertyMask_bUseTranslucencyVertexFog) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUseTranslucencyVertexFog) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUseTranslucencyVertexFog) & ~UMaterial.__PropertyMask_bUseTranslucencyVertexFog) | (value ? UMaterial.__PropertyMask_bUseTranslucencyVertexFog : 0));
			}
		}

		// Token: 0x17002B8E RID: 11150
		// (get) Token: 0x0600BC1E RID: 48158 RVA: 0x0010C74D File Offset: 0x0010A94D
		// (set) Token: 0x0600BC1F RID: 48159 RVA: 0x0010C766 File Offset: 0x0010A966
		public unsafe bool bUseTranslucencyEffectVertexFog
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUseTranslucencyEffectVertexFog) & UMaterial.__PropertyMask_bUseTranslucencyEffectVertexFog) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUseTranslucencyEffectVertexFog) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUseTranslucencyEffectVertexFog) & ~UMaterial.__PropertyMask_bUseTranslucencyEffectVertexFog) | (value ? UMaterial.__PropertyMask_bUseTranslucencyEffectVertexFog : 0));
			}
		}

		// Token: 0x17002B8F RID: 11151
		// (get) Token: 0x0600BC20 RID: 48160 RVA: 0x0010C796 File Offset: 0x0010A996
		// (set) Token: 0x0600BC21 RID: 48161 RVA: 0x0010C7AF File Offset: 0x0010A9AF
		public unsafe bool bApplyCloudFogging
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bApplyCloudFogging) & UMaterial.__PropertyMask_bApplyCloudFogging) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bApplyCloudFogging) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bApplyCloudFogging) & ~UMaterial.__PropertyMask_bApplyCloudFogging) | (value ? UMaterial.__PropertyMask_bApplyCloudFogging : 0));
			}
		}

		// Token: 0x17002B90 RID: 11152
		// (get) Token: 0x0600BC22 RID: 48162 RVA: 0x0010C7DF File Offset: 0x0010A9DF
		// (set) Token: 0x0600BC23 RID: 48163 RVA: 0x0010C7F8 File Offset: 0x0010A9F8
		public unsafe bool bIsSky
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bIsSky) & UMaterial.__PropertyMask_bIsSky) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bIsSky) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bIsSky) & ~UMaterial.__PropertyMask_bIsSky) | (value ? UMaterial.__PropertyMask_bIsSky : 0));
			}
		}

		// Token: 0x17002B91 RID: 11153
		// (get) Token: 0x0600BC24 RID: 48164 RVA: 0x0010C828 File Offset: 0x0010AA28
		// (set) Token: 0x0600BC25 RID: 48165 RVA: 0x0010C841 File Offset: 0x0010AA41
		public unsafe bool bSupportRayTracing
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bSupportRayTracing) & UMaterial.__PropertyMask_bSupportRayTracing) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bSupportRayTracing) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bSupportRayTracing) & ~UMaterial.__PropertyMask_bSupportRayTracing) | (value ? UMaterial.__PropertyMask_bSupportRayTracing : 0));
			}
		}

		// Token: 0x17002B92 RID: 11154
		// (get) Token: 0x0600BC26 RID: 48166 RVA: 0x0010C871 File Offset: 0x0010AA71
		// (set) Token: 0x0600BC27 RID: 48167 RVA: 0x0010C88A File Offset: 0x0010AA8A
		public unsafe bool bAutoSupportRayTracing
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bAutoSupportRayTracing) & UMaterial.__PropertyMask_bAutoSupportRayTracing) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bAutoSupportRayTracing) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bAutoSupportRayTracing) & ~UMaterial.__PropertyMask_bAutoSupportRayTracing) | (value ? UMaterial.__PropertyMask_bAutoSupportRayTracing : 0));
			}
		}

		// Token: 0x17002B93 RID: 11155
		// (get) Token: 0x0600BC28 RID: 48168 RVA: 0x0010C8BA File Offset: 0x0010AABA
		// (set) Token: 0x0600BC29 RID: 48169 RVA: 0x0010C8D3 File Offset: 0x0010AAD3
		public unsafe bool DisableNPCOptimiAsRayTracing
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_DisableNPCOptimiAsRayTracing) & UMaterial.__PropertyMask_DisableNPCOptimiAsRayTracing) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_DisableNPCOptimiAsRayTracing) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_DisableNPCOptimiAsRayTracing) & ~UMaterial.__PropertyMask_DisableNPCOptimiAsRayTracing) | (value ? UMaterial.__PropertyMask_DisableNPCOptimiAsRayTracing : 0));
			}
		}

		// Token: 0x17002B94 RID: 11156
		// (get) Token: 0x0600BC2A RID: 48170 RVA: 0x0010C903 File Offset: 0x0010AB03
		// (set) Token: 0x0600BC2B RID: 48171 RVA: 0x0010C91C File Offset: 0x0010AB1C
		public unsafe bool bUseAsRaytracedSky
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUseAsRaytracedSky) & UMaterial.__PropertyMask_bUseAsRaytracedSky) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUseAsRaytracedSky) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUseAsRaytracedSky) & ~UMaterial.__PropertyMask_bUseAsRaytracedSky) | (value ? UMaterial.__PropertyMask_bUseAsRaytracedSky : 0));
			}
		}

		// Token: 0x17002B95 RID: 11157
		// (get) Token: 0x0600BC2C RID: 48172 RVA: 0x0010C94C File Offset: 0x0010AB4C
		// (set) Token: 0x0600BC2D RID: 48173 RVA: 0x0010C965 File Offset: 0x0010AB65
		public unsafe bool bComputeFogPerPixel
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bComputeFogPerPixel) & UMaterial.__PropertyMask_bComputeFogPerPixel) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bComputeFogPerPixel) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bComputeFogPerPixel) & ~UMaterial.__PropertyMask_bComputeFogPerPixel) | (value ? UMaterial.__PropertyMask_bComputeFogPerPixel : 0));
			}
		}

		// Token: 0x17002B96 RID: 11158
		// (get) Token: 0x0600BC2E RID: 48174 RVA: 0x0010C995 File Offset: 0x0010AB95
		// (set) Token: 0x0600BC2F RID: 48175 RVA: 0x0010C9AE File Offset: 0x0010ABAE
		public unsafe bool bOutputTranslucentVelocity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bOutputTranslucentVelocity) & UMaterial.__PropertyMask_bOutputTranslucentVelocity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bOutputTranslucentVelocity) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bOutputTranslucentVelocity) & ~UMaterial.__PropertyMask_bOutputTranslucentVelocity) | (value ? UMaterial.__PropertyMask_bOutputTranslucentVelocity : 0));
			}
		}

		// Token: 0x17002B97 RID: 11159
		// (get) Token: 0x0600BC30 RID: 48176 RVA: 0x0010C9DE File Offset: 0x0010ABDE
		// (set) Token: 0x0600BC31 RID: 48177 RVA: 0x0010C9F7 File Offset: 0x0010ABF7
		public unsafe bool bIsDisableOutputVelocity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bIsDisableOutputVelocity) & UMaterial.__PropertyMask_bIsDisableOutputVelocity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bIsDisableOutputVelocity) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bIsDisableOutputVelocity) & ~UMaterial.__PropertyMask_bIsDisableOutputVelocity) | (value ? UMaterial.__PropertyMask_bIsDisableOutputVelocity : 0));
			}
		}

		// Token: 0x17002B98 RID: 11160
		// (get) Token: 0x0600BC32 RID: 48178 RVA: 0x0010CA27 File Offset: 0x0010AC27
		// (set) Token: 0x0600BC33 RID: 48179 RVA: 0x0010CA40 File Offset: 0x0010AC40
		public unsafe bool bIsMobileOutputVelocity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bIsMobileOutputVelocity) & UMaterial.__PropertyMask_bIsMobileOutputVelocity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bIsMobileOutputVelocity) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bIsMobileOutputVelocity) & ~UMaterial.__PropertyMask_bIsMobileOutputVelocity) | (value ? UMaterial.__PropertyMask_bIsMobileOutputVelocity : 0));
			}
		}

		// Token: 0x17002B99 RID: 11161
		// (get) Token: 0x0600BC34 RID: 48180 RVA: 0x0010CA70 File Offset: 0x0010AC70
		// (set) Token: 0x0600BC35 RID: 48181 RVA: 0x0010CA89 File Offset: 0x0010AC89
		public unsafe bool bAllowDevelopmentShaderCompile
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bAllowDevelopmentShaderCompile) & UMaterial.__PropertyMask_bAllowDevelopmentShaderCompile) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bAllowDevelopmentShaderCompile) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bAllowDevelopmentShaderCompile) & ~UMaterial.__PropertyMask_bAllowDevelopmentShaderCompile) | (value ? UMaterial.__PropertyMask_bAllowDevelopmentShaderCompile : 0));
			}
		}

		// Token: 0x17002B9A RID: 11162
		// (get) Token: 0x0600BC36 RID: 48182 RVA: 0x0010CAB9 File Offset: 0x0010ACB9
		// (set) Token: 0x0600BC37 RID: 48183 RVA: 0x0010CAD2 File Offset: 0x0010ACD2
		public unsafe bool bIsMaterialEditorStatsMaterial
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bIsMaterialEditorStatsMaterial) & UMaterial.__PropertyMask_bIsMaterialEditorStatsMaterial) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bIsMaterialEditorStatsMaterial) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bIsMaterialEditorStatsMaterial) & ~UMaterial.__PropertyMask_bIsMaterialEditorStatsMaterial) | (value ? UMaterial.__PropertyMask_bIsMaterialEditorStatsMaterial : 0));
			}
		}

		// Token: 0x17002B9B RID: 11163
		// (get) Token: 0x0600BC38 RID: 48184 RVA: 0x0010CB02 File Offset: 0x0010AD02
		// (set) Token: 0x0600BC39 RID: 48185 RVA: 0x0010CB16 File Offset: 0x0010AD16
		public unsafe TEnumAsByte<EBlendableLocation> BlendableLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_BlendableLocation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_BlendableLocation) = value;
			}
		}

		// Token: 0x17002B9C RID: 11164
		// (get) Token: 0x0600BC3A RID: 48186 RVA: 0x0010CB2B File Offset: 0x0010AD2B
		// (set) Token: 0x0600BC3B RID: 48187 RVA: 0x0010CB44 File Offset: 0x0010AD44
		public unsafe bool BlendableOutputAlpha
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_BlendableOutputAlpha) & UMaterial.__PropertyMask_BlendableOutputAlpha) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_BlendableOutputAlpha) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_BlendableOutputAlpha) & ~UMaterial.__PropertyMask_BlendableOutputAlpha) | (value ? UMaterial.__PropertyMask_BlendableOutputAlpha : 0));
			}
		}

		// Token: 0x17002B9D RID: 11165
		// (get) Token: 0x0600BC3C RID: 48188 RVA: 0x0010CB74 File Offset: 0x0010AD74
		// (set) Token: 0x0600BC3D RID: 48189 RVA: 0x0010CB8D File Offset: 0x0010AD8D
		public unsafe bool bAdditiveBlendToSceneColor
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bAdditiveBlendToSceneColor) & UMaterial.__PropertyMask_bAdditiveBlendToSceneColor) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bAdditiveBlendToSceneColor) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bAdditiveBlendToSceneColor) & ~UMaterial.__PropertyMask_bAdditiveBlendToSceneColor) | (value ? UMaterial.__PropertyMask_bAdditiveBlendToSceneColor : 0));
			}
		}

		// Token: 0x17002B9E RID: 11166
		// (get) Token: 0x0600BC3E RID: 48190 RVA: 0x0010CBBD File Offset: 0x0010ADBD
		// (set) Token: 0x0600BC3F RID: 48191 RVA: 0x0010CBD6 File Offset: 0x0010ADD6
		public unsafe bool bEnableStencilTest
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bEnableStencilTest) & UMaterial.__PropertyMask_bEnableStencilTest) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bEnableStencilTest) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bEnableStencilTest) & ~UMaterial.__PropertyMask_bEnableStencilTest) | (value ? UMaterial.__PropertyMask_bEnableStencilTest : 0));
			}
		}

		// Token: 0x17002B9F RID: 11167
		// (get) Token: 0x0600BC40 RID: 48192 RVA: 0x0010CC06 File Offset: 0x0010AE06
		// (set) Token: 0x0600BC41 RID: 48193 RVA: 0x0010CC1A File Offset: 0x0010AE1A
		public unsafe TEnumAsByte<EMaterialStencilCompare> StencilCompare
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_StencilCompare);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_StencilCompare) = value;
			}
		}

		// Token: 0x17002BA0 RID: 11168
		// (get) Token: 0x0600BC42 RID: 48194 RVA: 0x0010CC2F File Offset: 0x0010AE2F
		// (set) Token: 0x0600BC43 RID: 48195 RVA: 0x0010CC3F File Offset: 0x0010AE3F
		public unsafe byte StencilRefValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_StencilRefValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_StencilRefValue) = value;
			}
		}

		// Token: 0x17002BA1 RID: 11169
		// (get) Token: 0x0600BC44 RID: 48196 RVA: 0x0010CC50 File Offset: 0x0010AE50
		// (set) Token: 0x0600BC45 RID: 48197 RVA: 0x0010CC69 File Offset: 0x0010AE69
		public unsafe bool bEnableCustomStencilTest
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bEnableCustomStencilTest) & UMaterial.__PropertyMask_bEnableCustomStencilTest) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bEnableCustomStencilTest) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bEnableCustomStencilTest) & ~UMaterial.__PropertyMask_bEnableCustomStencilTest) | (value ? UMaterial.__PropertyMask_bEnableCustomStencilTest : 0));
			}
		}

		// Token: 0x17002BA2 RID: 11170
		// (get) Token: 0x0600BC46 RID: 48198 RVA: 0x0010CC99 File Offset: 0x0010AE99
		// (set) Token: 0x0600BC47 RID: 48199 RVA: 0x0010CCB2 File Offset: 0x0010AEB2
		public unsafe bool bEnableCustomStencilDepthTest
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bEnableCustomStencilDepthTest) & UMaterial.__PropertyMask_bEnableCustomStencilDepthTest) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bEnableCustomStencilDepthTest) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bEnableCustomStencilDepthTest) & ~UMaterial.__PropertyMask_bEnableCustomStencilDepthTest) | (value ? UMaterial.__PropertyMask_bEnableCustomStencilDepthTest : 0));
			}
		}

		// Token: 0x17002BA3 RID: 11171
		// (get) Token: 0x0600BC48 RID: 48200 RVA: 0x0010CCE2 File Offset: 0x0010AEE2
		// (set) Token: 0x0600BC49 RID: 48201 RVA: 0x0010CCF2 File Offset: 0x0010AEF2
		public unsafe byte CustomStencilRefValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_CustomStencilRefValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_CustomStencilRefValue) = value;
			}
		}

		// Token: 0x17002BA4 RID: 11172
		// (get) Token: 0x0600BC4A RID: 48202 RVA: 0x0010CD03 File Offset: 0x0010AF03
		// (set) Token: 0x0600BC4B RID: 48203 RVA: 0x0010CD1C File Offset: 0x0010AF1C
		public unsafe bool bEnableCustomStencilWrite
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bEnableCustomStencilWrite) & UMaterial.__PropertyMask_bEnableCustomStencilWrite) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bEnableCustomStencilWrite) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bEnableCustomStencilWrite) & ~UMaterial.__PropertyMask_bEnableCustomStencilWrite) | (value ? UMaterial.__PropertyMask_bEnableCustomStencilWrite : 0));
			}
		}

		// Token: 0x17002BA5 RID: 11173
		// (get) Token: 0x0600BC4C RID: 48204 RVA: 0x0010CD4C File Offset: 0x0010AF4C
		// (set) Token: 0x0600BC4D RID: 48205 RVA: 0x0010CD5C File Offset: 0x0010AF5C
		public unsafe byte CustomStencilWriteValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_CustomStencilWriteValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_CustomStencilWriteValue) = value;
			}
		}

		// Token: 0x17002BA6 RID: 11174
		// (get) Token: 0x0600BC4E RID: 48206 RVA: 0x0010CD6D File Offset: 0x0010AF6D
		// (set) Token: 0x0600BC4F RID: 48207 RVA: 0x0010CD86 File Offset: 0x0010AF86
		public unsafe bool bCustomStencilWriteOnly
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bCustomStencilWriteOnly) & UMaterial.__PropertyMask_bCustomStencilWriteOnly) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bCustomStencilWriteOnly) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bCustomStencilWriteOnly) & ~UMaterial.__PropertyMask_bCustomStencilWriteOnly) | (value ? UMaterial.__PropertyMask_bCustomStencilWriteOnly : 0));
			}
		}

		// Token: 0x17002BA7 RID: 11175
		// (get) Token: 0x0600BC50 RID: 48208 RVA: 0x0010CDB6 File Offset: 0x0010AFB6
		// (set) Token: 0x0600BC51 RID: 48209 RVA: 0x0010CDCF File Offset: 0x0010AFCF
		public unsafe bool bCustomStencilWriteOnlyEnableDepthWrite
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bCustomStencilWriteOnlyEnableDepthWrite) & UMaterial.__PropertyMask_bCustomStencilWriteOnlyEnableDepthWrite) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bCustomStencilWriteOnlyEnableDepthWrite) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bCustomStencilWriteOnlyEnableDepthWrite) & ~UMaterial.__PropertyMask_bCustomStencilWriteOnlyEnableDepthWrite) | (value ? UMaterial.__PropertyMask_bCustomStencilWriteOnlyEnableDepthWrite : 0));
			}
		}

		// Token: 0x17002BA8 RID: 11176
		// (get) Token: 0x0600BC52 RID: 48210 RVA: 0x0010CDFF File Offset: 0x0010AFFF
		// (set) Token: 0x0600BC53 RID: 48211 RVA: 0x0010CE18 File Offset: 0x0010B018
		public unsafe bool bCustomStencilWriteDisableDepthTest
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bCustomStencilWriteDisableDepthTest) & UMaterial.__PropertyMask_bCustomStencilWriteDisableDepthTest) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bCustomStencilWriteDisableDepthTest) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bCustomStencilWriteDisableDepthTest) & ~UMaterial.__PropertyMask_bCustomStencilWriteDisableDepthTest) | (value ? UMaterial.__PropertyMask_bCustomStencilWriteDisableDepthTest : 0));
			}
		}

		// Token: 0x17002BA9 RID: 11177
		// (get) Token: 0x0600BC54 RID: 48212 RVA: 0x0010CE48 File Offset: 0x0010B048
		// (set) Token: 0x0600BC55 RID: 48213 RVA: 0x0010CE61 File Offset: 0x0010B061
		public unsafe bool bCustomStencilWriteRenderLast
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bCustomStencilWriteRenderLast) & UMaterial.__PropertyMask_bCustomStencilWriteRenderLast) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bCustomStencilWriteRenderLast) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bCustomStencilWriteRenderLast) & ~UMaterial.__PropertyMask_bCustomStencilWriteRenderLast) | (value ? UMaterial.__PropertyMask_bCustomStencilWriteRenderLast : 0));
			}
		}

		// Token: 0x17002BAA RID: 11178
		// (get) Token: 0x0600BC56 RID: 48214 RVA: 0x0010CE91 File Offset: 0x0010B091
		// (set) Token: 0x0600BC57 RID: 48215 RVA: 0x0010CEAA File Offset: 0x0010B0AA
		public unsafe bool bRenderOnDepthTestFail
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bRenderOnDepthTestFail) & UMaterial.__PropertyMask_bRenderOnDepthTestFail) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bRenderOnDepthTestFail) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bRenderOnDepthTestFail) & ~UMaterial.__PropertyMask_bRenderOnDepthTestFail) | (value ? UMaterial.__PropertyMask_bRenderOnDepthTestFail : 0));
			}
		}

		// Token: 0x17002BAB RID: 11179
		// (get) Token: 0x0600BC58 RID: 48216 RVA: 0x0010CEDA File Offset: 0x0010B0DA
		// (set) Token: 0x0600BC59 RID: 48217 RVA: 0x0010CEF3 File Offset: 0x0010B0F3
		public unsafe bool bTranslucentDepthWrite
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bTranslucentDepthWrite) & UMaterial.__PropertyMask_bTranslucentDepthWrite) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bTranslucentDepthWrite) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bTranslucentDepthWrite) & ~UMaterial.__PropertyMask_bTranslucentDepthWrite) | (value ? UMaterial.__PropertyMask_bTranslucentDepthWrite : 0));
			}
		}

		// Token: 0x17002BAC RID: 11180
		// (get) Token: 0x0600BC5A RID: 48218 RVA: 0x0010CF23 File Offset: 0x0010B123
		// (set) Token: 0x0600BC5B RID: 48219 RVA: 0x0010CF3C File Offset: 0x0010B13C
		public unsafe bool bTranslucentPixelClip
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bTranslucentPixelClip) & UMaterial.__PropertyMask_bTranslucentPixelClip) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bTranslucentPixelClip) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bTranslucentPixelClip) & ~UMaterial.__PropertyMask_bTranslucentPixelClip) | (value ? UMaterial.__PropertyMask_bTranslucentPixelClip : 0));
			}
		}

		// Token: 0x17002BAD RID: 11181
		// (get) Token: 0x0600BC5C RID: 48220 RVA: 0x0010CF6C File Offset: 0x0010B16C
		// (set) Token: 0x0600BC5D RID: 48221 RVA: 0x0010CF80 File Offset: 0x0010B180
		public unsafe TEnumAsByte<ERefractionMode> RefractionMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_RefractionMode);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_RefractionMode) = value;
			}
		}

		// Token: 0x17002BAE RID: 11182
		// (get) Token: 0x0600BC5E RID: 48222 RVA: 0x0010CF95 File Offset: 0x0010B195
		// (set) Token: 0x0600BC5F RID: 48223 RVA: 0x0010CFA5 File Offset: 0x0010B1A5
		public unsafe int BlendablePriority
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_BlendablePriority);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_BlendablePriority) = value;
			}
		}

		// Token: 0x17002BAF RID: 11183
		// (get) Token: 0x0600BC60 RID: 48224 RVA: 0x0010CFB6 File Offset: 0x0010B1B6
		// (set) Token: 0x0600BC61 RID: 48225 RVA: 0x0010CFCF File Offset: 0x0010B1CF
		public unsafe bool bIsBlendable
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bIsBlendable) & UMaterial.__PropertyMask_bIsBlendable) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bIsBlendable) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bIsBlendable) & ~UMaterial.__PropertyMask_bIsBlendable) | (value ? UMaterial.__PropertyMask_bIsBlendable : 0));
			}
		}

		// Token: 0x17002BB0 RID: 11184
		// (get) Token: 0x0600BC62 RID: 48226 RVA: 0x0010CFFF File Offset: 0x0010B1FF
		// (set) Token: 0x0600BC63 RID: 48227 RVA: 0x0010D00F File Offset: 0x0010B20F
		public unsafe uint UsageFlagWarnings
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_UsageFlagWarnings);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_UsageFlagWarnings) = (int)value;
			}
		}

		// Token: 0x17002BB1 RID: 11185
		// (get) Token: 0x0600BC64 RID: 48228 RVA: 0x0010D020 File Offset: 0x0010B220
		// (set) Token: 0x0600BC65 RID: 48229 RVA: 0x0010D030 File Offset: 0x0010B230
		public unsafe float RefractionDepthBias
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_RefractionDepthBias);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_RefractionDepthBias) = value;
			}
		}

		// Token: 0x17002BB2 RID: 11186
		// (get) Token: 0x0600BC66 RID: 48230 RVA: 0x0010D041 File Offset: 0x0010B241
		// (set) Token: 0x0600BC67 RID: 48231 RVA: 0x0010D055 File Offset: 0x0010B255
		public unsafe FGuid StateId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_StateId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_StateId) = value;
			}
		}

		// Token: 0x17002BB3 RID: 11187
		// (get) Token: 0x0600BC68 RID: 48232 RVA: 0x0010D06A File Offset: 0x0010B26A
		// (set) Token: 0x0600BC69 RID: 48233 RVA: 0x0010D07A File Offset: 0x0010B27A
		public unsafe float MaxDisplacement
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_MaxDisplacement);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_MaxDisplacement) = value;
			}
		}

		// Token: 0x17002BB4 RID: 11188
		// (get) Token: 0x0600BC6A RID: 48234 RVA: 0x0010D08C File Offset: 0x0010B28C
		// (set) Token: 0x0600BC6B RID: 48235 RVA: 0x0010D0C5 File Offset: 0x0010B2C5
		[Nullable(1)]
		public FMaterialCachedExpressionData CachedExpressionData
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FMaterialCachedExpressionData result;
				if ((result = this._CachedExpressionData) == null)
				{
					result = (this._CachedExpressionData = new FMaterialCachedExpressionData(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_CachedExpressionData, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMaterialCachedExpressionData.StaticStruct(), base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_CachedExpressionData, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600BC6C RID: 48236 RVA: 0x0010D0E6 File Offset: 0x0010B2E6
		static UMaterial()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.Material");
		}

		// Token: 0x0600BC6D RID: 48237 RVA: 0x0010D0F4 File Offset: 0x0010B2F4
		protected UMaterial(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040061A0 RID: 24992
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.Material";

		// Token: 0x040061A1 RID: 24993
		private static IntPtr _ClassPtr;

		// Token: 0x040061A2 RID: 24994
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040061A3 RID: 24995
		internal static int __PropertyOffset_PhysMaterial;

		// Token: 0x040061A4 RID: 24996
		internal static int __PropertyOffset_PhysMaterialMask;

		// Token: 0x040061A5 RID: 24997
		internal static int __PropertyOffset_PhysicalMaterialMap;

		// Token: 0x040061A6 RID: 24998
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TFixedArray<UPhysicalMaterial> _PhysicalMaterialMap;

		// Token: 0x040061A7 RID: 24999
		internal static int __PropertyOffset_Metallic;

		// Token: 0x040061A8 RID: 25000
		[Nullable(2)]
		private FScalarMaterialInput _Metallic;

		// Token: 0x040061A9 RID: 25001
		internal static int __PropertyOffset_Specular;

		// Token: 0x040061AA RID: 25002
		[Nullable(2)]
		private FScalarMaterialInput _Specular;

		// Token: 0x040061AB RID: 25003
		internal static int __PropertyOffset_Anisotropy;

		// Token: 0x040061AC RID: 25004
		[Nullable(2)]
		private FScalarMaterialInput _Anisotropy;

		// Token: 0x040061AD RID: 25005
		internal static int __PropertyOffset_Normal;

		// Token: 0x040061AE RID: 25006
		[Nullable(2)]
		private FVectorMaterialInput _Normal;

		// Token: 0x040061AF RID: 25007
		internal static int __PropertyOffset_Tangent;

		// Token: 0x040061B0 RID: 25008
		[Nullable(2)]
		private FVectorMaterialInput _Tangent;

		// Token: 0x040061B1 RID: 25009
		internal static int __PropertyOffset_EmissiveColor;

		// Token: 0x040061B2 RID: 25010
		[Nullable(2)]
		private FColorMaterialInput _EmissiveColor;

		// Token: 0x040061B3 RID: 25011
		internal static int __PropertyOffset_MaterialDomain;

		// Token: 0x040061B4 RID: 25012
		internal static int __PropertyOffset_BlendMode;

		// Token: 0x040061B5 RID: 25013
		internal static int __PropertyOffset_DecalBlendMode;

		// Token: 0x040061B6 RID: 25014
		internal static int __PropertyOffset_MaterialReceiveDecal;

		// Token: 0x040061B7 RID: 25015
		internal static byte __PropertyMask_MaterialReceiveDecal;

		// Token: 0x040061B8 RID: 25016
		internal static int __PropertyOffset_MaterialDecalResponse;

		// Token: 0x040061B9 RID: 25017
		internal static int __PropertyOffset_ShadingModel;

		// Token: 0x040061BA RID: 25018
		internal static int __PropertyOffset_bCastDynamicShadowAsMasked;

		// Token: 0x040061BB RID: 25019
		internal static byte __PropertyMask_bCastDynamicShadowAsMasked;

		// Token: 0x040061BC RID: 25020
		internal static int __PropertyOffset_ShadingModels;

		// Token: 0x040061BD RID: 25021
		[Nullable(2)]
		private FMaterialShadingModelField _ShadingModels;

		// Token: 0x040061BE RID: 25022
		internal static int __PropertyOffset_OpacityMaskClipValue;

		// Token: 0x040061BF RID: 25023
		internal static int __PropertyOffset_WorldPositionOffset;

		// Token: 0x040061C0 RID: 25024
		[Nullable(2)]
		private FVectorMaterialInput _WorldPositionOffset;

		// Token: 0x040061C1 RID: 25025
		internal static int __PropertyOffset_Refraction;

		// Token: 0x040061C2 RID: 25026
		[Nullable(2)]
		private FScalarMaterialInput _Refraction;

		// Token: 0x040061C3 RID: 25027
		internal static int __PropertyOffset_MaterialAttributes;

		// Token: 0x040061C4 RID: 25028
		[Nullable(2)]
		private FMaterialAttributesInput _MaterialAttributes;

		// Token: 0x040061C5 RID: 25029
		internal static int __PropertyOffset_PixelDepthOffset;

		// Token: 0x040061C6 RID: 25030
		[Nullable(2)]
		private FScalarMaterialInput _PixelDepthOffset;

		// Token: 0x040061C7 RID: 25031
		internal static int __PropertyOffset_ShadingModelFromMaterialExpression;

		// Token: 0x040061C8 RID: 25032
		[Nullable(2)]
		private FShadingModelMaterialInput _ShadingModelFromMaterialExpression;

		// Token: 0x040061C9 RID: 25033
		internal static int __PropertyOffset_ShadowPixelDepthOffset;

		// Token: 0x040061CA RID: 25034
		[Nullable(2)]
		private FScalarMaterialInput _ShadowPixelDepthOffset;

		// Token: 0x040061CB RID: 25035
		internal static int __PropertyOffset_KuroDepthRimWidth;

		// Token: 0x040061CC RID: 25036
		[Nullable(2)]
		private FScalarMaterialInput _KuroDepthRimWidth;

		// Token: 0x040061CD RID: 25037
		internal static int __PropertyOffset_KuroPreComputeShadow;

		// Token: 0x040061CE RID: 25038
		[Nullable(2)]
		private FScalarMaterialInput _KuroPreComputeShadow;

		// Token: 0x040061CF RID: 25039
		internal static int __PropertyOffset_bEnableSeparateTranslucency;

		// Token: 0x040061D0 RID: 25040
		internal static byte __PropertyMask_bEnableSeparateTranslucency;

		// Token: 0x040061D1 RID: 25041
		internal static int __PropertyOffset_bEnableResponsiveAA;

		// Token: 0x040061D2 RID: 25042
		internal static byte __PropertyMask_bEnableResponsiveAA;

		// Token: 0x040061D3 RID: 25043
		internal static int __PropertyOffset_bScreenSpaceReflections;

		// Token: 0x040061D4 RID: 25044
		internal static byte __PropertyMask_bScreenSpaceReflections;

		// Token: 0x040061D5 RID: 25045
		internal static int __PropertyOffset_bContactShadows;

		// Token: 0x040061D6 RID: 25046
		internal static byte __PropertyMask_bContactShadows;

		// Token: 0x040061D7 RID: 25047
		internal static int __PropertyOffset_bTranslucencyReceiveLightFunctionShadow;

		// Token: 0x040061D8 RID: 25048
		internal static byte __PropertyMask_bTranslucencyReceiveLightFunctionShadow;

		// Token: 0x040061D9 RID: 25049
		internal static int __PropertyOffset_TwoSided;

		// Token: 0x040061DA RID: 25050
		internal static byte __PropertyMask_TwoSided;

		// Token: 0x040061DB RID: 25051
		internal static int __PropertyOffset_KuroWater;

		// Token: 0x040061DC RID: 25052
		internal static byte __PropertyMask_KuroWater;

		// Token: 0x040061DD RID: 25053
		internal static int __PropertyOffset_BackFace;

		// Token: 0x040061DE RID: 25054
		internal static byte __PropertyMask_BackFace;

		// Token: 0x040061DF RID: 25055
		internal static int __PropertyOffset_bSceneDissolveEnable;

		// Token: 0x040061E0 RID: 25056
		internal static byte __PropertyMask_bSceneDissolveEnable;

		// Token: 0x040061E1 RID: 25057
		internal static int __PropertyOffset_bSceneColorClearEnable;

		// Token: 0x040061E2 RID: 25058
		internal static byte __PropertyMask_bSceneColorClearEnable;

		// Token: 0x040061E3 RID: 25059
		internal static int __PropertyOffset_RenderQueue;

		// Token: 0x040061E4 RID: 25060
		internal static int __PropertyOffset_MaterialDesktopGameQualityShoulderRender;

		// Token: 0x040061E5 RID: 25061
		internal static int __PropertyOffset_MaterialMobileGameQualityShoulderRender;

		// Token: 0x040061E6 RID: 25062
		internal static int __PropertyOffset_bDisableShadowCacheForSPDO;

		// Token: 0x040061E7 RID: 25063
		internal static byte __PropertyMask_bDisableShadowCacheForSPDO;

		// Token: 0x040061E8 RID: 25064
		internal static int __PropertyOffset_bSinglelayerWaterWriteDepth;

		// Token: 0x040061E9 RID: 25065
		internal static byte __PropertyMask_bSinglelayerWaterWriteDepth;

		// Token: 0x040061EA RID: 25066
		internal static int __PropertyOffset_bSingleLayerWaterMobileDesaturation;

		// Token: 0x040061EB RID: 25067
		internal static byte __PropertyMask_bSingleLayerWaterMobileDesaturation;

		// Token: 0x040061EC RID: 25068
		internal static int __PropertyOffset_bDrawRTWithRGBA;

		// Token: 0x040061ED RID: 25069
		internal static byte __PropertyMask_bDrawRTWithRGBA;

		// Token: 0x040061EE RID: 25070
		internal static int __PropertyOffset_bRenderInCustomCapturePass;

		// Token: 0x040061EF RID: 25071
		internal static byte __PropertyMask_bRenderInCustomCapturePass;

		// Token: 0x040061F0 RID: 25072
		internal static int __PropertyOffset_bRenderInGodRayPass;

		// Token: 0x040061F1 RID: 25073
		internal static byte __PropertyMask_bRenderInGodRayPass;

		// Token: 0x040061F2 RID: 25074
		internal static int __PropertyOffset_bMaskedRenderInPreDepth;

		// Token: 0x040061F3 RID: 25075
		internal static byte __PropertyMask_bMaskedRenderInPreDepth;

		// Token: 0x040061F4 RID: 25076
		internal static int __PropertyOffset_bMaskedRenderInPreDepth_PC;

		// Token: 0x040061F5 RID: 25077
		internal static byte __PropertyMask_bMaskedRenderInPreDepth_PC;

		// Token: 0x040061F6 RID: 25078
		internal static int __PropertyOffset_bSupportMobileHighQuality;

		// Token: 0x040061F7 RID: 25079
		internal static byte __PropertyMask_bSupportMobileHighQuality;

		// Token: 0x040061F8 RID: 25080
		internal static int __PropertyOffset_bCustomAlphaTest;

		// Token: 0x040061F9 RID: 25081
		internal static byte __PropertyMask_bCustomAlphaTest;

		// Token: 0x040061FA RID: 25082
		internal static int __PropertyOffset_bEnableBattle;

		// Token: 0x040061FB RID: 25083
		internal static byte __PropertyMask_bEnableBattle;

		// Token: 0x040061FC RID: 25084
		internal static int __PropertyOffset_bEnableBattleMask;

		// Token: 0x040061FD RID: 25085
		internal static byte __PropertyMask_bEnableBattleMask;

		// Token: 0x040061FE RID: 25086
		internal static int __PropertyOffset_bIsCharacterHairMat;

		// Token: 0x040061FF RID: 25087
		internal static byte __PropertyMask_bIsCharacterHairMat;

		// Token: 0x04006200 RID: 25088
		internal static int __PropertyOffset_bIsCharacterHETMat;

		// Token: 0x04006201 RID: 25089
		internal static byte __PropertyMask_bIsCharacterHETMat;

		// Token: 0x04006202 RID: 25090
		internal static int __PropertyOffset_bHETMatOnlyUsedPlayer;

		// Token: 0x04006203 RID: 25091
		internal static int __PropertyOffset_bIsUsedWithWriteStencil;

		// Token: 0x04006204 RID: 25092
		internal static int __PropertyOffset_bRenderToonFFT;

		// Token: 0x04006205 RID: 25093
		internal static byte __PropertyMask_bRenderToonFFT;

		// Token: 0x04006206 RID: 25094
		internal static int __PropertyOffset_bRenderTranslucentOpacity;

		// Token: 0x04006207 RID: 25095
		internal static byte __PropertyMask_bRenderTranslucentOpacity;

		// Token: 0x04006208 RID: 25096
		internal static int __PropertyOffset_bForceSceneTranslucentOpacity;

		// Token: 0x04006209 RID: 25097
		internal static byte __PropertyMask_bForceSceneTranslucentOpacity;

		// Token: 0x0400620A RID: 25098
		internal static int __PropertyOffset_bForceFightTranslucentOpacity;

		// Token: 0x0400620B RID: 25099
		internal static byte __PropertyMask_bForceFightTranslucentOpacity;

		// Token: 0x0400620C RID: 25100
		internal static int __PropertyOffset_ExtendedHETDistance;

		// Token: 0x0400620D RID: 25101
		internal static int __PropertyOffset_bUseMobileDistortion;

		// Token: 0x0400620E RID: 25102
		internal static byte __PropertyMask_bUseMobileDistortion;

		// Token: 0x0400620F RID: 25103
		internal static int __PropertyOffset_bLGUIMaterial;

		// Token: 0x04006210 RID: 25104
		internal static byte __PropertyMask_bLGUIMaterial;

		// Token: 0x04006211 RID: 25105
		internal static int __PropertyOffset_bLGUIMaterialDrawBeforeUpScale;

		// Token: 0x04006212 RID: 25106
		internal static byte __PropertyMask_bLGUIMaterialDrawBeforeUpScale;

		// Token: 0x04006213 RID: 25107
		internal static int __PropertyOffset_bLGUISkipDepth;

		// Token: 0x04006214 RID: 25108
		internal static byte __PropertyMask_bLGUISkipDepth;

		// Token: 0x04006215 RID: 25109
		internal static int __PropertyOffset_bTranslucencyUse3xPCF;

		// Token: 0x04006216 RID: 25110
		internal static byte __PropertyMask_bTranslucencyUse3xPCF;

		// Token: 0x04006217 RID: 25111
		internal static int __PropertyOffset_bTranslucencyIBLUseCustomdataRoughness;

		// Token: 0x04006218 RID: 25112
		internal static byte __PropertyMask_bTranslucencyIBLUseCustomdataRoughness;

		// Token: 0x04006219 RID: 25113
		internal static int __PropertyOffset_bTranslucencyReceiveShadowMobile;

		// Token: 0x0400621A RID: 25114
		internal static byte __PropertyMask_bTranslucencyReceiveShadowMobile;

		// Token: 0x0400621B RID: 25115
		internal static int __PropertyOffset_DitheredLODTransition;

		// Token: 0x0400621C RID: 25116
		internal static byte __PropertyMask_DitheredLODTransition;

		// Token: 0x0400621D RID: 25117
		internal static int __PropertyOffset_DitherOpacityMask;

		// Token: 0x0400621E RID: 25118
		internal static byte __PropertyMask_DitherOpacityMask;

		// Token: 0x0400621F RID: 25119
		internal static int __PropertyOffset_bAllowNegativeEmissiveColor;

		// Token: 0x04006220 RID: 25120
		internal static byte __PropertyMask_bAllowNegativeEmissiveColor;

		// Token: 0x04006221 RID: 25121
		internal static int __PropertyOffset_TranslucencyLightingMode;

		// Token: 0x04006222 RID: 25122
		internal static int __PropertyOffset_bEnableMobileSeparateTranslucency;

		// Token: 0x04006223 RID: 25123
		internal static byte __PropertyMask_bEnableMobileSeparateTranslucency;

		// Token: 0x04006224 RID: 25124
		internal static int __PropertyOffset_bUseNormalDither;

		// Token: 0x04006225 RID: 25125
		internal static byte __PropertyMask_bUseNormalDither;

		// Token: 0x04006226 RID: 25126
		internal static int __PropertyOffset_NormalDitherScale;

		// Token: 0x04006227 RID: 25127
		internal static int __PropertyOffset_WPORTCullDistScale;

		// Token: 0x04006228 RID: 25128
		internal static int __PropertyOffset_NumCustomizedUVs;

		// Token: 0x04006229 RID: 25129
		internal static int __PropertyOffset_TranslucencyDirectionalLightingIntensity;

		// Token: 0x0400622A RID: 25130
		internal static int __PropertyOffset_TranslucentShadowDensityScale;

		// Token: 0x0400622B RID: 25131
		internal static int __PropertyOffset_TranslucentSelfShadowDensityScale;

		// Token: 0x0400622C RID: 25132
		internal static int __PropertyOffset_TranslucentSelfShadowSecondDensityScale;

		// Token: 0x0400622D RID: 25133
		internal static int __PropertyOffset_TranslucentSelfShadowSecondOpacity;

		// Token: 0x0400622E RID: 25134
		internal static int __PropertyOffset_TranslucentBackscatteringExponent;

		// Token: 0x0400622F RID: 25135
		internal static int __PropertyOffset_TranslucentMultipleScatteringExtinction;

		// Token: 0x04006230 RID: 25136
		internal static int __PropertyOffset_TranslucentShadowStartOffset;

		// Token: 0x04006231 RID: 25137
		internal static int __PropertyOffset_bDisableDepthTest;

		// Token: 0x04006232 RID: 25138
		internal static byte __PropertyMask_bDisableDepthTest;

		// Token: 0x04006233 RID: 25139
		internal static int __PropertyOffset_bWriteOnlyAlpha;

		// Token: 0x04006234 RID: 25140
		internal static byte __PropertyMask_bWriteOnlyAlpha;

		// Token: 0x04006235 RID: 25141
		internal static int __PropertyOffset_bGenerateSphericalParticleNormals;

		// Token: 0x04006236 RID: 25142
		internal static byte __PropertyMask_bGenerateSphericalParticleNormals;

		// Token: 0x04006237 RID: 25143
		internal static int __PropertyOffset_bTangentSpaceNormal;

		// Token: 0x04006238 RID: 25144
		internal static byte __PropertyMask_bTangentSpaceNormal;

		// Token: 0x04006239 RID: 25145
		internal static int __PropertyOffset_bUseEmissiveForDynamicAreaLighting;

		// Token: 0x0400623A RID: 25146
		internal static byte __PropertyMask_bUseEmissiveForDynamicAreaLighting;

		// Token: 0x0400623B RID: 25147
		internal static int __PropertyOffset_bBlockGI;

		// Token: 0x0400623C RID: 25148
		internal static byte __PropertyMask_bBlockGI;

		// Token: 0x0400623D RID: 25149
		internal static int __PropertyOffset_bUsedAsSpecialEngineMaterial;

		// Token: 0x0400623E RID: 25150
		internal static byte __PropertyMask_bUsedAsSpecialEngineMaterial;

		// Token: 0x0400623F RID: 25151
		internal static int __PropertyOffset_bUsedWithSkeletalMesh;

		// Token: 0x04006240 RID: 25152
		internal static byte __PropertyMask_bUsedWithSkeletalMesh;

		// Token: 0x04006241 RID: 25153
		internal static int __PropertyOffset_bUsedWithBakedBoneMesh;

		// Token: 0x04006242 RID: 25154
		internal static byte __PropertyMask_bUsedWithBakedBoneMesh;

		// Token: 0x04006243 RID: 25155
		internal static int __PropertyOffset_bUsedWithExpandedTexcoordsSkeletalMesh;

		// Token: 0x04006244 RID: 25156
		internal static byte __PropertyMask_bUsedWithExpandedTexcoordsSkeletalMesh;

		// Token: 0x04006245 RID: 25157
		internal static int __PropertyOffset_bIsOnlyForSkeletalMesh;

		// Token: 0x04006246 RID: 25158
		internal static byte __PropertyMask_bIsOnlyForSkeletalMesh;

		// Token: 0x04006247 RID: 25159
		internal static int __PropertyOffset_bIsDisableWuYinQuLayer;

		// Token: 0x04006248 RID: 25160
		internal static byte __PropertyMask_bIsDisableWuYinQuLayer;

		// Token: 0x04006249 RID: 25161
		internal static int __PropertyOffset_bIsDisableWetLayer;

		// Token: 0x0400624A RID: 25162
		internal static byte __PropertyMask_bIsDisableWetLayer;

		// Token: 0x0400624B RID: 25163
		internal static int __PropertyOffset_bIsNoWaterForToon;

		// Token: 0x0400624C RID: 25164
		internal static byte __PropertyMask_bIsNoWaterForToon;

		// Token: 0x0400624D RID: 25165
		internal static int __PropertyOffset_bUsedWithShadowSVT;

		// Token: 0x0400624E RID: 25166
		internal static byte __PropertyMask_bUsedWithShadowSVT;

		// Token: 0x0400624F RID: 25167
		internal static int __PropertyOffset_bSingleLayerWaterRainDrop;

		// Token: 0x04006250 RID: 25168
		internal static byte __PropertyMask_bSingleLayerWaterRainDrop;

		// Token: 0x04006251 RID: 25169
		internal static int __PropertyOffset_bSingleLayerWaterSSRProxy;

		// Token: 0x04006252 RID: 25170
		internal static byte __PropertyMask_bSingleLayerWaterSSRProxy;

		// Token: 0x04006253 RID: 25171
		internal static int __PropertyOffset_bWriteDepthToGbuffer;

		// Token: 0x04006254 RID: 25172
		internal static byte __PropertyMask_bWriteDepthToGbuffer;

		// Token: 0x04006255 RID: 25173
		internal static int __PropertyOffset_bUseAnisotropy;

		// Token: 0x04006256 RID: 25174
		internal static byte __PropertyMask_bUseAnisotropy;

		// Token: 0x04006257 RID: 25175
		internal static int __PropertyOffset_bKuroSceneTranslucency;

		// Token: 0x04006258 RID: 25176
		internal static byte __PropertyMask_bKuroSceneTranslucency;

		// Token: 0x04006259 RID: 25177
		internal static int __PropertyOffset_bKuroTranslucencyWaterMasked;

		// Token: 0x0400625A RID: 25178
		internal static byte __PropertyMask_bKuroTranslucencyWaterMasked;

		// Token: 0x0400625B RID: 25179
		internal static int __PropertyOffset_bKuroVolumeCloud;

		// Token: 0x0400625C RID: 25180
		internal static byte __PropertyMask_bKuroVolumeCloud;

		// Token: 0x0400625D RID: 25181
		internal static int __PropertyOffset_bKuroDownsampleTranslucency;

		// Token: 0x0400625E RID: 25182
		internal static byte __PropertyMask_bKuroDownsampleTranslucency;

		// Token: 0x0400625F RID: 25183
		internal static int __PropertyOffset_bKuroTranslucencyWriteDepth;

		// Token: 0x04006260 RID: 25184
		internal static byte __PropertyMask_bKuroTranslucencyWriteDepth;

		// Token: 0x04006261 RID: 25185
		internal static int __PropertyOffset_bKuroFakeDecalStencil;

		// Token: 0x04006262 RID: 25186
		internal static byte __PropertyMask_bKuroFakeDecalStencil;

		// Token: 0x04006263 RID: 25187
		internal static int __PropertyOffset_bUsedWithOutline;

		// Token: 0x04006264 RID: 25188
		internal static byte __PropertyMask_bUsedWithOutline;

		// Token: 0x04006265 RID: 25189
		internal static int __PropertyOffset_bUsedWithStencilOnlyWrite;

		// Token: 0x04006266 RID: 25190
		internal static byte __PropertyMask_bUsedWithStencilOnlyWrite;

		// Token: 0x04006267 RID: 25191
		internal static int __PropertyOffset_bUsedWithFaceShadowMesh;

		// Token: 0x04006268 RID: 25192
		internal static byte __PropertyMask_bUsedWithFaceShadowMesh;

		// Token: 0x04006269 RID: 25193
		internal static int __PropertyOffset_bUsedWithEmpty;

		// Token: 0x0400626A RID: 25194
		internal static byte __PropertyMask_bUsedWithEmpty;

		// Token: 0x0400626B RID: 25195
		internal static int __PropertyOffset_bUsedForGenerate2DMap;

		// Token: 0x0400626C RID: 25196
		internal static byte __PropertyMask_bUsedForGenerate2DMap;

		// Token: 0x0400626D RID: 25197
		internal static int __PropertyOffset_Generate2DMapStencil;

		// Token: 0x0400626E RID: 25198
		internal static int __PropertyOffset_bLandscapeMaterialWithHoles;

		// Token: 0x0400626F RID: 25199
		internal static byte __PropertyMask_bLandscapeMaterialWithHoles;

		// Token: 0x04006270 RID: 25200
		internal static int __PropertyOffset_bCompileRuntimeVirtualTextureVariant;

		// Token: 0x04006271 RID: 25201
		internal static byte __PropertyMask_bCompileRuntimeVirtualTextureVariant;

		// Token: 0x04006272 RID: 25202
		internal static int __PropertyOffset_bBakeImposter;

		// Token: 0x04006273 RID: 25203
		internal static byte __PropertyMask_bBakeImposter;

		// Token: 0x04006274 RID: 25204
		internal static int __PropertyOffset_bUsedWithHLODVertexCompression;

		// Token: 0x04006275 RID: 25205
		internal static byte __PropertyMask_bUsedWithHLODVertexCompression;

		// Token: 0x04006276 RID: 25206
		internal static int __PropertyOffset_bHasPreDepthPass;

		// Token: 0x04006277 RID: 25207
		internal static byte __PropertyMask_bHasPreDepthPass;

		// Token: 0x04006278 RID: 25208
		internal static int __PropertyOffset_bMobileNoPreDepthPass;

		// Token: 0x04006279 RID: 25209
		internal static byte __PropertyMask_bMobileNoPreDepthPass;

		// Token: 0x0400627A RID: 25210
		internal static int __PropertyOffset_bDrawPreDepthOnly;

		// Token: 0x0400627B RID: 25211
		internal static byte __PropertyMask_bDrawPreDepthOnly;

		// Token: 0x0400627C RID: 25212
		internal static int __PropertyOffset_KuroTranslucentPreDepthTestMode;

		// Token: 0x0400627D RID: 25213
		internal static int __PropertyOffset_KuroTranslucentPreDepthCullMode;

		// Token: 0x0400627E RID: 25214
		internal static int __PropertyOffset_bHasDataDistortionPass;

		// Token: 0x0400627F RID: 25215
		internal static byte __PropertyMask_bHasDataDistortionPass;

		// Token: 0x04006280 RID: 25216
		internal static int __PropertyOffset_bHasCustomWPOVariant;

		// Token: 0x04006281 RID: 25217
		internal static byte __PropertyMask_bHasCustomWPOVariant;

		// Token: 0x04006282 RID: 25218
		internal static int __PropertyOffset_DissolveInBurst;

		// Token: 0x04006283 RID: 25219
		internal static byte __PropertyMask_DissolveInBurst;

		// Token: 0x04006284 RID: 25220
		internal static int __PropertyOffset_WaterDissolveInBurst;

		// Token: 0x04006285 RID: 25221
		internal static byte __PropertyMask_WaterDissolveInBurst;

		// Token: 0x04006286 RID: 25222
		internal static int __PropertyOffset_ToonCustomStencilTestBit;

		// Token: 0x04006287 RID: 25223
		internal static int __PropertyOffset_bEffectSpaceWrite;

		// Token: 0x04006288 RID: 25224
		internal static byte __PropertyMask_bEffectSpaceWrite;

		// Token: 0x04006289 RID: 25225
		internal static int __PropertyOffset_bEffectSpaceRead;

		// Token: 0x0400628A RID: 25226
		internal static byte __PropertyMask_bEffectSpaceRead;

		// Token: 0x0400628B RID: 25227
		internal static int __PropertyOffset_bXRayBodyStencil;

		// Token: 0x0400628C RID: 25228
		internal static byte __PropertyMask_bXRayBodyStencil;

		// Token: 0x0400628D RID: 25229
		internal static int __PropertyOffset_bRenderInKuroVolumetricLightColorMask;

		// Token: 0x0400628E RID: 25230
		internal static byte __PropertyMask_bRenderInKuroVolumetricLightColorMask;

		// Token: 0x0400628F RID: 25231
		internal static int __PropertyOffset_bKuroBlendWaterTranslucency;

		// Token: 0x04006290 RID: 25232
		internal static byte __PropertyMask_bKuroBlendWaterTranslucency;

		// Token: 0x04006291 RID: 25233
		internal static int __PropertyOffset_bSupportsUBInstancing;

		// Token: 0x04006292 RID: 25234
		internal static byte __PropertyMask_bSupportsUBInstancing;

		// Token: 0x04006293 RID: 25235
		internal static int __PropertyOffset_bSupportsDrawMaterialToRT;

		// Token: 0x04006294 RID: 25236
		internal static byte __PropertyMask_bSupportsDrawMaterialToRT;

		// Token: 0x04006295 RID: 25237
		internal static int __PropertyOffset_bUsedWithEditorCompositing;

		// Token: 0x04006296 RID: 25238
		internal static byte __PropertyMask_bUsedWithEditorCompositing;

		// Token: 0x04006297 RID: 25239
		internal static int __PropertyOffset_bUsedWithParticleSprites;

		// Token: 0x04006298 RID: 25240
		internal static byte __PropertyMask_bUsedWithParticleSprites;

		// Token: 0x04006299 RID: 25241
		internal static int __PropertyOffset_bUsedWithBeamTrails;

		// Token: 0x0400629A RID: 25242
		internal static byte __PropertyMask_bUsedWithBeamTrails;

		// Token: 0x0400629B RID: 25243
		internal static int __PropertyOffset_bUsedWithMeshParticles;

		// Token: 0x0400629C RID: 25244
		internal static byte __PropertyMask_bUsedWithMeshParticles;

		// Token: 0x0400629D RID: 25245
		internal static int __PropertyOffset_bUsedWithNiagaraSprites;

		// Token: 0x0400629E RID: 25246
		internal static byte __PropertyMask_bUsedWithNiagaraSprites;

		// Token: 0x0400629F RID: 25247
		internal static int __PropertyOffset_bUsedWithNiagaraRibbons;

		// Token: 0x040062A0 RID: 25248
		internal static byte __PropertyMask_bUsedWithNiagaraRibbons;

		// Token: 0x040062A1 RID: 25249
		internal static int __PropertyOffset_bUsedWithNiagaraMeshParticles;

		// Token: 0x040062A2 RID: 25250
		internal static byte __PropertyMask_bUsedWithNiagaraMeshParticles;

		// Token: 0x040062A3 RID: 25251
		internal static int __PropertyOffset_bUsedWithGeometryCache;

		// Token: 0x040062A4 RID: 25252
		internal static byte __PropertyMask_bUsedWithGeometryCache;

		// Token: 0x040062A5 RID: 25253
		internal static int __PropertyOffset_bUsedWithStaticLighting;

		// Token: 0x040062A6 RID: 25254
		internal static byte __PropertyMask_bUsedWithStaticLighting;

		// Token: 0x040062A7 RID: 25255
		internal static int __PropertyOffset_bUsedWithMorphTargets;

		// Token: 0x040062A8 RID: 25256
		internal static byte __PropertyMask_bUsedWithMorphTargets;

		// Token: 0x040062A9 RID: 25257
		internal static int __PropertyOffset_bUsedWithSplineMeshes;

		// Token: 0x040062AA RID: 25258
		internal static byte __PropertyMask_bUsedWithSplineMeshes;

		// Token: 0x040062AB RID: 25259
		internal static int __PropertyOffset_bUsedWithInstancedStaticMeshes;

		// Token: 0x040062AC RID: 25260
		internal static byte __PropertyMask_bUsedWithInstancedStaticMeshes;

		// Token: 0x040062AD RID: 25261
		internal static int __PropertyOffset_bUsedWithGeometryCollections;

		// Token: 0x040062AE RID: 25262
		internal static byte __PropertyMask_bUsedWithGeometryCollections;

		// Token: 0x040062AF RID: 25263
		internal static int __PropertyOffset_bUsesDistortion;

		// Token: 0x040062B0 RID: 25264
		internal static byte __PropertyMask_bUsesDistortion;

		// Token: 0x040062B1 RID: 25265
		internal static int __PropertyOffset_bUsedWithClothing;

		// Token: 0x040062B2 RID: 25266
		internal static byte __PropertyMask_bUsedWithClothing;

		// Token: 0x040062B3 RID: 25267
		internal static int __PropertyOffset_bUsedWithWater;

		// Token: 0x040062B4 RID: 25268
		internal static byte __PropertyMask_bUsedWithWater;

		// Token: 0x040062B5 RID: 25269
		internal static int __PropertyOffset_bUsedWithHairStrands;

		// Token: 0x040062B6 RID: 25270
		internal static byte __PropertyMask_bUsedWithHairStrands;

		// Token: 0x040062B7 RID: 25271
		internal static int __PropertyOffset_bUsedWithLidarPointCloud;

		// Token: 0x040062B8 RID: 25272
		internal static byte __PropertyMask_bUsedWithLidarPointCloud;

		// Token: 0x040062B9 RID: 25273
		internal static int __PropertyOffset_bUsedWithVirtualHeightfieldMesh;

		// Token: 0x040062BA RID: 25274
		internal static byte __PropertyMask_bUsedWithVirtualHeightfieldMesh;

		// Token: 0x040062BB RID: 25275
		internal static int __PropertyOffset_bRemoveLocalVertexFactory;

		// Token: 0x040062BC RID: 25276
		internal static byte __PropertyMask_bRemoveLocalVertexFactory;

		// Token: 0x040062BD RID: 25277
		internal static int __PropertyOffset_bUsedWithMarchingCubes;

		// Token: 0x040062BE RID: 25278
		internal static byte __PropertyMask_bUsedWithMarchingCubes;

		// Token: 0x040062BF RID: 25279
		internal static int __PropertyOffset_bUsedWithKuroCSInteractiveObject;

		// Token: 0x040062C0 RID: 25280
		internal static byte __PropertyMask_bUsedWithKuroCSInteractiveObject;

		// Token: 0x040062C1 RID: 25281
		internal static int __PropertyOffset_bUsedWithNanite;

		// Token: 0x040062C2 RID: 25282
		internal static byte __PropertyMask_bUsedWithNanite;

		// Token: 0x040062C3 RID: 25283
		internal static int __PropertyOffset_bUsedWithVolumetricCloud;

		// Token: 0x040062C4 RID: 25284
		internal static byte __PropertyMask_bUsedWithVolumetricCloud;

		// Token: 0x040062C5 RID: 25285
		internal static int __PropertyOffset_bUsedWithHeterogeneousVolumes;

		// Token: 0x040062C6 RID: 25286
		internal static byte __PropertyMask_bUsedWithHeterogeneousVolumes;

		// Token: 0x040062C7 RID: 25287
		internal static int __PropertyOffset_bUsedWithTransvoxel;

		// Token: 0x040062C8 RID: 25288
		internal static byte __PropertyMask_bUsedWithTransvoxel;

		// Token: 0x040062C9 RID: 25289
		internal static int __PropertyOffset_bUsedWithUI_DEPRECATED;

		// Token: 0x040062CA RID: 25290
		internal static byte __PropertyMask_bUsedWithUI_DEPRECATED;

		// Token: 0x040062CB RID: 25291
		internal static int __PropertyOffset_bAutomaticallySetUsageInEditor;

		// Token: 0x040062CC RID: 25292
		internal static byte __PropertyMask_bAutomaticallySetUsageInEditor;

		// Token: 0x040062CD RID: 25293
		internal static int __PropertyOffset_PipelineStateCreationHint;

		// Token: 0x040062CE RID: 25294
		internal static int __PropertyOffset_bFullyRough;

		// Token: 0x040062CF RID: 25295
		internal static byte __PropertyMask_bFullyRough;

		// Token: 0x040062D0 RID: 25296
		internal static int __PropertyOffset_bUseFullPrecision;

		// Token: 0x040062D1 RID: 25297
		internal static byte __PropertyMask_bUseFullPrecision;

		// Token: 0x040062D2 RID: 25298
		internal static int __PropertyOffset_FullPrecisionPlatform;

		// Token: 0x040062D3 RID: 25299
		internal static int __PropertyOffset_bUseFullPrecisionParams;

		// Token: 0x040062D4 RID: 25300
		internal static byte __PropertyMask_bUseFullPrecisionParams;

		// Token: 0x040062D5 RID: 25301
		internal static int __PropertyOffset_FullPrecisionParamsPlatform;

		// Token: 0x040062D6 RID: 25302
		internal static int __PropertyOffset_bUseHalfPrecisionVS;

		// Token: 0x040062D7 RID: 25303
		internal static byte __PropertyMask_bUseHalfPrecisionVS;

		// Token: 0x040062D8 RID: 25304
		internal static int __PropertyOffset_bUseLightmapDirectionality;

		// Token: 0x040062D9 RID: 25305
		internal static byte __PropertyMask_bUseLightmapDirectionality;

		// Token: 0x040062DA RID: 25306
		internal static int __PropertyOffset_bUseAlphaToCoverage;

		// Token: 0x040062DB RID: 25307
		internal static byte __PropertyMask_bUseAlphaToCoverage;

		// Token: 0x040062DC RID: 25308
		internal static int __PropertyOffset_bForwardRenderUsePreintegratedGFForSimpleIBL;

		// Token: 0x040062DD RID: 25309
		internal static byte __PropertyMask_bForwardRenderUsePreintegratedGFForSimpleIBL;

		// Token: 0x040062DE RID: 25310
		internal static int __PropertyOffset_bUseHQForwardReflections;

		// Token: 0x040062DF RID: 25311
		internal static byte __PropertyMask_bUseHQForwardReflections;

		// Token: 0x040062E0 RID: 25312
		internal static int __PropertyOffset_bUsePlanarForwardReflections;

		// Token: 0x040062E1 RID: 25313
		internal static byte __PropertyMask_bUsePlanarForwardReflections;

		// Token: 0x040062E2 RID: 25314
		internal static int __PropertyOffset_bNormalCurvatureToRoughness;

		// Token: 0x040062E3 RID: 25315
		internal static byte __PropertyMask_bNormalCurvatureToRoughness;

		// Token: 0x040062E4 RID: 25316
		internal static int __PropertyOffset_D3D11TessellationMode;

		// Token: 0x040062E5 RID: 25317
		internal static int __PropertyOffset_bEnableCrackFreeDisplacement;

		// Token: 0x040062E6 RID: 25318
		internal static byte __PropertyMask_bEnableCrackFreeDisplacement;

		// Token: 0x040062E7 RID: 25319
		internal static int __PropertyOffset_bEnableAdaptiveTessellation;

		// Token: 0x040062E8 RID: 25320
		internal static byte __PropertyMask_bEnableAdaptiveTessellation;

		// Token: 0x040062E9 RID: 25321
		internal static int __PropertyOffset_bDisableTessellationInShadowPass;

		// Token: 0x040062EA RID: 25322
		internal static byte __PropertyMask_bDisableTessellationInShadowPass;

		// Token: 0x040062EB RID: 25323
		internal static int __PropertyOffset_AllowTranslucentCustomDepthWrites;

		// Token: 0x040062EC RID: 25324
		internal static byte __PropertyMask_AllowTranslucentCustomDepthWrites;

		// Token: 0x040062ED RID: 25325
		internal static int __PropertyOffset_AllowMobileSceneCustomDepthWrites;

		// Token: 0x040062EE RID: 25326
		internal static byte __PropertyMask_AllowMobileSceneCustomDepthWrites;

		// Token: 0x040062EF RID: 25327
		internal static int __PropertyOffset_bAllowFrontLayerTranslucency;

		// Token: 0x040062F0 RID: 25328
		internal static byte __PropertyMask_bAllowFrontLayerTranslucency;

		// Token: 0x040062F1 RID: 25329
		internal static int __PropertyOffset_Wireframe;

		// Token: 0x040062F2 RID: 25330
		internal static byte __PropertyMask_Wireframe;

		// Token: 0x040062F3 RID: 25331
		internal static int __PropertyOffset_ShadingRate;

		// Token: 0x040062F4 RID: 25332
		internal static int __PropertyOffset_bCanMaskedBeAssumedOpaque;

		// Token: 0x040062F5 RID: 25333
		internal static byte __PropertyMask_bCanMaskedBeAssumedOpaque;

		// Token: 0x040062F6 RID: 25334
		internal static int __PropertyOffset_bIsMasked_DEPRECATED;

		// Token: 0x040062F7 RID: 25335
		internal static byte __PropertyMask_bIsMasked_DEPRECATED;

		// Token: 0x040062F8 RID: 25336
		internal static int __PropertyOffset_bIsPreviewMaterial;

		// Token: 0x040062F9 RID: 25337
		internal static byte __PropertyMask_bIsPreviewMaterial;

		// Token: 0x040062FA RID: 25338
		internal static int __PropertyOffset_bIsDebugMaterial;

		// Token: 0x040062FB RID: 25339
		internal static byte __PropertyMask_bIsDebugMaterial;

		// Token: 0x040062FC RID: 25340
		internal static int __PropertyOffset_bIsFunctionPreviewMaterial;

		// Token: 0x040062FD RID: 25341
		internal static byte __PropertyMask_bIsFunctionPreviewMaterial;

		// Token: 0x040062FE RID: 25342
		internal static int __PropertyOffset_bUseMaterialAttributes;

		// Token: 0x040062FF RID: 25343
		internal static byte __PropertyMask_bUseMaterialAttributes;

		// Token: 0x04006300 RID: 25344
		internal static int __PropertyOffset_bCastRayTracedShadows;

		// Token: 0x04006301 RID: 25345
		internal static byte __PropertyMask_bCastRayTracedShadows;

		// Token: 0x04006302 RID: 25346
		internal static int __PropertyOffset_bCastRasterShadowsInRaytracing;

		// Token: 0x04006303 RID: 25347
		internal static byte __PropertyMask_bCastRasterShadowsInRaytracing;

		// Token: 0x04006304 RID: 25348
		internal static int __PropertyOffset_bDisableCastDynamicShadows;

		// Token: 0x04006305 RID: 25349
		internal static byte __PropertyMask_bDisableCastDynamicShadows;

		// Token: 0x04006306 RID: 25350
		internal static int __PropertyOffset_bUseShadowPixelDepthOffset;

		// Token: 0x04006307 RID: 25351
		internal static byte __PropertyMask_bUseShadowPixelDepthOffset;

		// Token: 0x04006308 RID: 25352
		internal static int __PropertyOffset_bUseTranslucencyVertexFog;

		// Token: 0x04006309 RID: 25353
		internal static byte __PropertyMask_bUseTranslucencyVertexFog;

		// Token: 0x0400630A RID: 25354
		internal static int __PropertyOffset_bUseTranslucencyEffectVertexFog;

		// Token: 0x0400630B RID: 25355
		internal static byte __PropertyMask_bUseTranslucencyEffectVertexFog;

		// Token: 0x0400630C RID: 25356
		internal static int __PropertyOffset_bApplyCloudFogging;

		// Token: 0x0400630D RID: 25357
		internal static byte __PropertyMask_bApplyCloudFogging;

		// Token: 0x0400630E RID: 25358
		internal static int __PropertyOffset_bIsSky;

		// Token: 0x0400630F RID: 25359
		internal static byte __PropertyMask_bIsSky;

		// Token: 0x04006310 RID: 25360
		internal static int __PropertyOffset_bSupportRayTracing;

		// Token: 0x04006311 RID: 25361
		internal static byte __PropertyMask_bSupportRayTracing;

		// Token: 0x04006312 RID: 25362
		internal static int __PropertyOffset_bAutoSupportRayTracing;

		// Token: 0x04006313 RID: 25363
		internal static byte __PropertyMask_bAutoSupportRayTracing;

		// Token: 0x04006314 RID: 25364
		internal static int __PropertyOffset_DisableNPCOptimiAsRayTracing;

		// Token: 0x04006315 RID: 25365
		internal static byte __PropertyMask_DisableNPCOptimiAsRayTracing;

		// Token: 0x04006316 RID: 25366
		internal static int __PropertyOffset_bUseAsRaytracedSky;

		// Token: 0x04006317 RID: 25367
		internal static byte __PropertyMask_bUseAsRaytracedSky;

		// Token: 0x04006318 RID: 25368
		internal static int __PropertyOffset_bComputeFogPerPixel;

		// Token: 0x04006319 RID: 25369
		internal static byte __PropertyMask_bComputeFogPerPixel;

		// Token: 0x0400631A RID: 25370
		internal static int __PropertyOffset_bOutputTranslucentVelocity;

		// Token: 0x0400631B RID: 25371
		internal static byte __PropertyMask_bOutputTranslucentVelocity;

		// Token: 0x0400631C RID: 25372
		internal static int __PropertyOffset_bIsDisableOutputVelocity;

		// Token: 0x0400631D RID: 25373
		internal static byte __PropertyMask_bIsDisableOutputVelocity;

		// Token: 0x0400631E RID: 25374
		internal static int __PropertyOffset_bIsMobileOutputVelocity;

		// Token: 0x0400631F RID: 25375
		internal static byte __PropertyMask_bIsMobileOutputVelocity;

		// Token: 0x04006320 RID: 25376
		internal static int __PropertyOffset_bAllowDevelopmentShaderCompile;

		// Token: 0x04006321 RID: 25377
		internal static byte __PropertyMask_bAllowDevelopmentShaderCompile;

		// Token: 0x04006322 RID: 25378
		internal static int __PropertyOffset_bIsMaterialEditorStatsMaterial;

		// Token: 0x04006323 RID: 25379
		internal static byte __PropertyMask_bIsMaterialEditorStatsMaterial;

		// Token: 0x04006324 RID: 25380
		internal static int __PropertyOffset_BlendableLocation;

		// Token: 0x04006325 RID: 25381
		internal static int __PropertyOffset_BlendableOutputAlpha;

		// Token: 0x04006326 RID: 25382
		internal static byte __PropertyMask_BlendableOutputAlpha;

		// Token: 0x04006327 RID: 25383
		internal static int __PropertyOffset_bAdditiveBlendToSceneColor;

		// Token: 0x04006328 RID: 25384
		internal static byte __PropertyMask_bAdditiveBlendToSceneColor;

		// Token: 0x04006329 RID: 25385
		internal static int __PropertyOffset_bEnableStencilTest;

		// Token: 0x0400632A RID: 25386
		internal static byte __PropertyMask_bEnableStencilTest;

		// Token: 0x0400632B RID: 25387
		internal static int __PropertyOffset_StencilCompare;

		// Token: 0x0400632C RID: 25388
		internal static int __PropertyOffset_StencilRefValue;

		// Token: 0x0400632D RID: 25389
		internal static int __PropertyOffset_bEnableCustomStencilTest;

		// Token: 0x0400632E RID: 25390
		internal static byte __PropertyMask_bEnableCustomStencilTest;

		// Token: 0x0400632F RID: 25391
		internal static int __PropertyOffset_bEnableCustomStencilDepthTest;

		// Token: 0x04006330 RID: 25392
		internal static byte __PropertyMask_bEnableCustomStencilDepthTest;

		// Token: 0x04006331 RID: 25393
		internal static int __PropertyOffset_CustomStencilRefValue;

		// Token: 0x04006332 RID: 25394
		internal static int __PropertyOffset_bEnableCustomStencilWrite;

		// Token: 0x04006333 RID: 25395
		internal static byte __PropertyMask_bEnableCustomStencilWrite;

		// Token: 0x04006334 RID: 25396
		internal static int __PropertyOffset_CustomStencilWriteValue;

		// Token: 0x04006335 RID: 25397
		internal static int __PropertyOffset_bCustomStencilWriteOnly;

		// Token: 0x04006336 RID: 25398
		internal static byte __PropertyMask_bCustomStencilWriteOnly;

		// Token: 0x04006337 RID: 25399
		internal static int __PropertyOffset_bCustomStencilWriteOnlyEnableDepthWrite;

		// Token: 0x04006338 RID: 25400
		internal static byte __PropertyMask_bCustomStencilWriteOnlyEnableDepthWrite;

		// Token: 0x04006339 RID: 25401
		internal static int __PropertyOffset_bCustomStencilWriteDisableDepthTest;

		// Token: 0x0400633A RID: 25402
		internal static byte __PropertyMask_bCustomStencilWriteDisableDepthTest;

		// Token: 0x0400633B RID: 25403
		internal static int __PropertyOffset_bCustomStencilWriteRenderLast;

		// Token: 0x0400633C RID: 25404
		internal static byte __PropertyMask_bCustomStencilWriteRenderLast;

		// Token: 0x0400633D RID: 25405
		internal static int __PropertyOffset_bRenderOnDepthTestFail;

		// Token: 0x0400633E RID: 25406
		internal static byte __PropertyMask_bRenderOnDepthTestFail;

		// Token: 0x0400633F RID: 25407
		internal static int __PropertyOffset_bTranslucentDepthWrite;

		// Token: 0x04006340 RID: 25408
		internal static byte __PropertyMask_bTranslucentDepthWrite;

		// Token: 0x04006341 RID: 25409
		internal static int __PropertyOffset_bTranslucentPixelClip;

		// Token: 0x04006342 RID: 25410
		internal static byte __PropertyMask_bTranslucentPixelClip;

		// Token: 0x04006343 RID: 25411
		internal static int __PropertyOffset_RefractionMode;

		// Token: 0x04006344 RID: 25412
		internal static int __PropertyOffset_BlendablePriority;

		// Token: 0x04006345 RID: 25413
		internal static int __PropertyOffset_bIsBlendable;

		// Token: 0x04006346 RID: 25414
		internal static byte __PropertyMask_bIsBlendable;

		// Token: 0x04006347 RID: 25415
		internal static int __PropertyOffset_UsageFlagWarnings;

		// Token: 0x04006348 RID: 25416
		internal static int __PropertyOffset_RefractionDepthBias;

		// Token: 0x04006349 RID: 25417
		internal static int __PropertyOffset_StateId;

		// Token: 0x0400634A RID: 25418
		internal static int __PropertyOffset_MaxDisplacement;

		// Token: 0x0400634B RID: 25419
		internal static int __PropertyOffset_CachedExpressionData;

		// Token: 0x0400634C RID: 25420
		[Nullable(2)]
		private FMaterialCachedExpressionData _CachedExpressionData;
	}
}
