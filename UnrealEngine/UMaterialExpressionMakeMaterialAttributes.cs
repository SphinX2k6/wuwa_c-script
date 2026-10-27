using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000DF2 RID: 3570
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpressionMakeMaterialAttributes")]
	[UnrealStructLayout(1928, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1928)]
	public class UMaterialExpressionMakeMaterialAttributes : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C106 RID: 49414 RVA: 0x00115AF9 File Offset: 0x00113CF9
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionMakeMaterialAttributes._ClassPtr;
		}

		// Token: 0x0600C107 RID: 49415 RVA: 0x00115B08 File Offset: 0x00113D08
		public UMaterialExpressionMakeMaterialAttributes() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionMakeMaterialAttributes.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C108 RID: 49416 RVA: 0x00115B30 File Offset: 0x00113D30
		public UMaterialExpressionMakeMaterialAttributes(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionMakeMaterialAttributes.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002CC8 RID: 11464
		// (get) Token: 0x0600C109 RID: 49417 RVA: 0x00115B64 File Offset: 0x00113D64
		// (set) Token: 0x0600C10A RID: 49418 RVA: 0x00115B9D File Offset: 0x00113D9D
		public FExpressionInput BaseColor
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._BaseColor) == null)
				{
					result = (this._BaseColor = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionMakeMaterialAttributes.__PropertyOffset_BaseColor, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionMakeMaterialAttributes.__PropertyOffset_BaseColor, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002CC9 RID: 11465
		// (get) Token: 0x0600C10B RID: 49419 RVA: 0x00115BC0 File Offset: 0x00113DC0
		// (set) Token: 0x0600C10C RID: 49420 RVA: 0x00115BF9 File Offset: 0x00113DF9
		public FExpressionInput Metallic
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._Metallic) == null)
				{
					result = (this._Metallic = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionMakeMaterialAttributes.__PropertyOffset_Metallic, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionMakeMaterialAttributes.__PropertyOffset_Metallic, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002CCA RID: 11466
		// (get) Token: 0x0600C10D RID: 49421 RVA: 0x00115C1C File Offset: 0x00113E1C
		// (set) Token: 0x0600C10E RID: 49422 RVA: 0x00115C55 File Offset: 0x00113E55
		public FExpressionInput Specular
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._Specular) == null)
				{
					result = (this._Specular = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionMakeMaterialAttributes.__PropertyOffset_Specular, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionMakeMaterialAttributes.__PropertyOffset_Specular, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002CCB RID: 11467
		// (get) Token: 0x0600C10F RID: 49423 RVA: 0x00115C78 File Offset: 0x00113E78
		// (set) Token: 0x0600C110 RID: 49424 RVA: 0x00115CB1 File Offset: 0x00113EB1
		public FExpressionInput Roughness
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._Roughness) == null)
				{
					result = (this._Roughness = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionMakeMaterialAttributes.__PropertyOffset_Roughness, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionMakeMaterialAttributes.__PropertyOffset_Roughness, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002CCC RID: 11468
		// (get) Token: 0x0600C111 RID: 49425 RVA: 0x00115CD4 File Offset: 0x00113ED4
		// (set) Token: 0x0600C112 RID: 49426 RVA: 0x00115D0D File Offset: 0x00113F0D
		public FExpressionInput Anisotropy
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._Anisotropy) == null)
				{
					result = (this._Anisotropy = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionMakeMaterialAttributes.__PropertyOffset_Anisotropy, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionMakeMaterialAttributes.__PropertyOffset_Anisotropy, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002CCD RID: 11469
		// (get) Token: 0x0600C113 RID: 49427 RVA: 0x00115D30 File Offset: 0x00113F30
		// (set) Token: 0x0600C114 RID: 49428 RVA: 0x00115D69 File Offset: 0x00113F69
		public FExpressionInput EmissiveColor
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._EmissiveColor) == null)
				{
					result = (this._EmissiveColor = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionMakeMaterialAttributes.__PropertyOffset_EmissiveColor, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionMakeMaterialAttributes.__PropertyOffset_EmissiveColor, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002CCE RID: 11470
		// (get) Token: 0x0600C115 RID: 49429 RVA: 0x00115D8C File Offset: 0x00113F8C
		// (set) Token: 0x0600C116 RID: 49430 RVA: 0x00115DC5 File Offset: 0x00113FC5
		public FExpressionInput Opacity
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._Opacity) == null)
				{
					result = (this._Opacity = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionMakeMaterialAttributes.__PropertyOffset_Opacity, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionMakeMaterialAttributes.__PropertyOffset_Opacity, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002CCF RID: 11471
		// (get) Token: 0x0600C117 RID: 49431 RVA: 0x00115DE8 File Offset: 0x00113FE8
		// (set) Token: 0x0600C118 RID: 49432 RVA: 0x00115E21 File Offset: 0x00114021
		public FExpressionInput OpacityMask
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._OpacityMask) == null)
				{
					result = (this._OpacityMask = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionMakeMaterialAttributes.__PropertyOffset_OpacityMask, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionMakeMaterialAttributes.__PropertyOffset_OpacityMask, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002CD0 RID: 11472
		// (get) Token: 0x0600C119 RID: 49433 RVA: 0x00115E44 File Offset: 0x00114044
		// (set) Token: 0x0600C11A RID: 49434 RVA: 0x00115E7D File Offset: 0x0011407D
		public FExpressionInput Normal
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._Normal) == null)
				{
					result = (this._Normal = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionMakeMaterialAttributes.__PropertyOffset_Normal, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionMakeMaterialAttributes.__PropertyOffset_Normal, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002CD1 RID: 11473
		// (get) Token: 0x0600C11B RID: 49435 RVA: 0x00115EA0 File Offset: 0x001140A0
		// (set) Token: 0x0600C11C RID: 49436 RVA: 0x00115ED9 File Offset: 0x001140D9
		public FExpressionInput Tangent
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._Tangent) == null)
				{
					result = (this._Tangent = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionMakeMaterialAttributes.__PropertyOffset_Tangent, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionMakeMaterialAttributes.__PropertyOffset_Tangent, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002CD2 RID: 11474
		// (get) Token: 0x0600C11D RID: 49437 RVA: 0x00115EFC File Offset: 0x001140FC
		// (set) Token: 0x0600C11E RID: 49438 RVA: 0x00115F35 File Offset: 0x00114135
		public FExpressionInput WorldPositionOffset
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._WorldPositionOffset) == null)
				{
					result = (this._WorldPositionOffset = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionMakeMaterialAttributes.__PropertyOffset_WorldPositionOffset, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionMakeMaterialAttributes.__PropertyOffset_WorldPositionOffset, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002CD3 RID: 11475
		// (get) Token: 0x0600C11F RID: 49439 RVA: 0x00115F58 File Offset: 0x00114158
		// (set) Token: 0x0600C120 RID: 49440 RVA: 0x00115F91 File Offset: 0x00114191
		public FExpressionInput WorldDisplacement
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._WorldDisplacement) == null)
				{
					result = (this._WorldDisplacement = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionMakeMaterialAttributes.__PropertyOffset_WorldDisplacement, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionMakeMaterialAttributes.__PropertyOffset_WorldDisplacement, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002CD4 RID: 11476
		// (get) Token: 0x0600C121 RID: 49441 RVA: 0x00115FB4 File Offset: 0x001141B4
		// (set) Token: 0x0600C122 RID: 49442 RVA: 0x00115FED File Offset: 0x001141ED
		public FExpressionInput TessellationMultiplier
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._TessellationMultiplier) == null)
				{
					result = (this._TessellationMultiplier = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionMakeMaterialAttributes.__PropertyOffset_TessellationMultiplier, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionMakeMaterialAttributes.__PropertyOffset_TessellationMultiplier, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002CD5 RID: 11477
		// (get) Token: 0x0600C123 RID: 49443 RVA: 0x00116010 File Offset: 0x00114210
		// (set) Token: 0x0600C124 RID: 49444 RVA: 0x00116049 File Offset: 0x00114249
		public FExpressionInput SubsurfaceColor
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._SubsurfaceColor) == null)
				{
					result = (this._SubsurfaceColor = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionMakeMaterialAttributes.__PropertyOffset_SubsurfaceColor, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionMakeMaterialAttributes.__PropertyOffset_SubsurfaceColor, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002CD6 RID: 11478
		// (get) Token: 0x0600C125 RID: 49445 RVA: 0x0011606C File Offset: 0x0011426C
		// (set) Token: 0x0600C126 RID: 49446 RVA: 0x001160A5 File Offset: 0x001142A5
		public FExpressionInput ClearCoat
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._ClearCoat) == null)
				{
					result = (this._ClearCoat = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionMakeMaterialAttributes.__PropertyOffset_ClearCoat, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionMakeMaterialAttributes.__PropertyOffset_ClearCoat, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002CD7 RID: 11479
		// (get) Token: 0x0600C127 RID: 49447 RVA: 0x001160C8 File Offset: 0x001142C8
		// (set) Token: 0x0600C128 RID: 49448 RVA: 0x00116101 File Offset: 0x00114301
		public FExpressionInput ClearCoatRoughness
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._ClearCoatRoughness) == null)
				{
					result = (this._ClearCoatRoughness = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionMakeMaterialAttributes.__PropertyOffset_ClearCoatRoughness, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionMakeMaterialAttributes.__PropertyOffset_ClearCoatRoughness, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002CD8 RID: 11480
		// (get) Token: 0x0600C129 RID: 49449 RVA: 0x00116124 File Offset: 0x00114324
		// (set) Token: 0x0600C12A RID: 49450 RVA: 0x0011615D File Offset: 0x0011435D
		public FExpressionInput AmbientOcclusion
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._AmbientOcclusion) == null)
				{
					result = (this._AmbientOcclusion = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionMakeMaterialAttributes.__PropertyOffset_AmbientOcclusion, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionMakeMaterialAttributes.__PropertyOffset_AmbientOcclusion, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002CD9 RID: 11481
		// (get) Token: 0x0600C12B RID: 49451 RVA: 0x00116180 File Offset: 0x00114380
		// (set) Token: 0x0600C12C RID: 49452 RVA: 0x001161B9 File Offset: 0x001143B9
		public FExpressionInput Refraction
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._Refraction) == null)
				{
					result = (this._Refraction = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionMakeMaterialAttributes.__PropertyOffset_Refraction, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionMakeMaterialAttributes.__PropertyOffset_Refraction, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002CDA RID: 11482
		// (get) Token: 0x0600C12D RID: 49453 RVA: 0x001161DC File Offset: 0x001143DC
		// (set) Token: 0x0600C12E RID: 49454 RVA: 0x00116216 File Offset: 0x00114416
		public TFixedArray<FExpressionInput> CustomizedUVs
		{
			get
			{
				base.FastCheckIsValid();
				TFixedArray<FExpressionInput> result;
				if ((result = this._CustomizedUVs) == null)
				{
					result = (this._CustomizedUVs = new TFixedArray<FExpressionInput>(base.NativePtr + (IntPtr)UMaterialExpressionMakeMaterialAttributes.__PropertyOffset_CustomizedUVs, 8, this));
				}
				return result;
			}
			set
			{
				this.CustomizedUVs.CopyAssign(value);
			}
		}

		// Token: 0x17002CDB RID: 11483
		// (get) Token: 0x0600C12F RID: 49455 RVA: 0x00116224 File Offset: 0x00114424
		// (set) Token: 0x0600C130 RID: 49456 RVA: 0x0011625D File Offset: 0x0011445D
		public FExpressionInput PixelDepthOffset
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._PixelDepthOffset) == null)
				{
					result = (this._PixelDepthOffset = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionMakeMaterialAttributes.__PropertyOffset_PixelDepthOffset, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionMakeMaterialAttributes.__PropertyOffset_PixelDepthOffset, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002CDC RID: 11484
		// (get) Token: 0x0600C131 RID: 49457 RVA: 0x00116280 File Offset: 0x00114480
		// (set) Token: 0x0600C132 RID: 49458 RVA: 0x001162B9 File Offset: 0x001144B9
		public FExpressionInput ShadingModel
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._ShadingModel) == null)
				{
					result = (this._ShadingModel = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionMakeMaterialAttributes.__PropertyOffset_ShadingModel, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionMakeMaterialAttributes.__PropertyOffset_ShadingModel, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002CDD RID: 11485
		// (get) Token: 0x0600C133 RID: 49459 RVA: 0x001162DC File Offset: 0x001144DC
		// (set) Token: 0x0600C134 RID: 49460 RVA: 0x00116315 File Offset: 0x00114515
		public FExpressionInput ShadowPixelDepthOffset
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._ShadowPixelDepthOffset) == null)
				{
					result = (this._ShadowPixelDepthOffset = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionMakeMaterialAttributes.__PropertyOffset_ShadowPixelDepthOffset, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionMakeMaterialAttributes.__PropertyOffset_ShadowPixelDepthOffset, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002CDE RID: 11486
		// (get) Token: 0x0600C135 RID: 49461 RVA: 0x00116338 File Offset: 0x00114538
		// (set) Token: 0x0600C136 RID: 49462 RVA: 0x00116371 File Offset: 0x00114571
		public FExpressionInput KuroDepthRimWidth
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._KuroDepthRimWidth) == null)
				{
					result = (this._KuroDepthRimWidth = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionMakeMaterialAttributes.__PropertyOffset_KuroDepthRimWidth, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionMakeMaterialAttributes.__PropertyOffset_KuroDepthRimWidth, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002CDF RID: 11487
		// (get) Token: 0x0600C137 RID: 49463 RVA: 0x00116394 File Offset: 0x00114594
		// (set) Token: 0x0600C138 RID: 49464 RVA: 0x001163CD File Offset: 0x001145CD
		public FExpressionInput KuroPreComputeShadow
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._KuroPreComputeShadow) == null)
				{
					result = (this._KuroPreComputeShadow = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionMakeMaterialAttributes.__PropertyOffset_KuroPreComputeShadow, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionMakeMaterialAttributes.__PropertyOffset_KuroPreComputeShadow, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600C139 RID: 49465 RVA: 0x001163EE File Offset: 0x001145EE
		static UMaterialExpressionMakeMaterialAttributes()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionMakeMaterialAttributes");
		}

		// Token: 0x0600C13A RID: 49466 RVA: 0x001163FC File Offset: 0x001145FC
		protected UMaterialExpressionMakeMaterialAttributes(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006681 RID: 26241
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionMakeMaterialAttributes";

		// Token: 0x04006682 RID: 26242
		private static IntPtr _ClassPtr;

		// Token: 0x04006683 RID: 26243
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04006684 RID: 26244
		internal static int __PropertyOffset_BaseColor;

		// Token: 0x04006685 RID: 26245
		[Nullable(2)]
		private FExpressionInput _BaseColor;

		// Token: 0x04006686 RID: 26246
		internal static int __PropertyOffset_Metallic;

		// Token: 0x04006687 RID: 26247
		[Nullable(2)]
		private FExpressionInput _Metallic;

		// Token: 0x04006688 RID: 26248
		internal static int __PropertyOffset_Specular;

		// Token: 0x04006689 RID: 26249
		[Nullable(2)]
		private FExpressionInput _Specular;

		// Token: 0x0400668A RID: 26250
		internal static int __PropertyOffset_Roughness;

		// Token: 0x0400668B RID: 26251
		[Nullable(2)]
		private FExpressionInput _Roughness;

		// Token: 0x0400668C RID: 26252
		internal static int __PropertyOffset_Anisotropy;

		// Token: 0x0400668D RID: 26253
		[Nullable(2)]
		private FExpressionInput _Anisotropy;

		// Token: 0x0400668E RID: 26254
		internal static int __PropertyOffset_EmissiveColor;

		// Token: 0x0400668F RID: 26255
		[Nullable(2)]
		private FExpressionInput _EmissiveColor;

		// Token: 0x04006690 RID: 26256
		internal static int __PropertyOffset_Opacity;

		// Token: 0x04006691 RID: 26257
		[Nullable(2)]
		private FExpressionInput _Opacity;

		// Token: 0x04006692 RID: 26258
		internal static int __PropertyOffset_OpacityMask;

		// Token: 0x04006693 RID: 26259
		[Nullable(2)]
		private FExpressionInput _OpacityMask;

		// Token: 0x04006694 RID: 26260
		internal static int __PropertyOffset_Normal;

		// Token: 0x04006695 RID: 26261
		[Nullable(2)]
		private FExpressionInput _Normal;

		// Token: 0x04006696 RID: 26262
		internal static int __PropertyOffset_Tangent;

		// Token: 0x04006697 RID: 26263
		[Nullable(2)]
		private FExpressionInput _Tangent;

		// Token: 0x04006698 RID: 26264
		internal static int __PropertyOffset_WorldPositionOffset;

		// Token: 0x04006699 RID: 26265
		[Nullable(2)]
		private FExpressionInput _WorldPositionOffset;

		// Token: 0x0400669A RID: 26266
		internal static int __PropertyOffset_WorldDisplacement;

		// Token: 0x0400669B RID: 26267
		[Nullable(2)]
		private FExpressionInput _WorldDisplacement;

		// Token: 0x0400669C RID: 26268
		internal static int __PropertyOffset_TessellationMultiplier;

		// Token: 0x0400669D RID: 26269
		[Nullable(2)]
		private FExpressionInput _TessellationMultiplier;

		// Token: 0x0400669E RID: 26270
		internal static int __PropertyOffset_SubsurfaceColor;

		// Token: 0x0400669F RID: 26271
		[Nullable(2)]
		private FExpressionInput _SubsurfaceColor;

		// Token: 0x040066A0 RID: 26272
		internal static int __PropertyOffset_ClearCoat;

		// Token: 0x040066A1 RID: 26273
		[Nullable(2)]
		private FExpressionInput _ClearCoat;

		// Token: 0x040066A2 RID: 26274
		internal static int __PropertyOffset_ClearCoatRoughness;

		// Token: 0x040066A3 RID: 26275
		[Nullable(2)]
		private FExpressionInput _ClearCoatRoughness;

		// Token: 0x040066A4 RID: 26276
		internal static int __PropertyOffset_AmbientOcclusion;

		// Token: 0x040066A5 RID: 26277
		[Nullable(2)]
		private FExpressionInput _AmbientOcclusion;

		// Token: 0x040066A6 RID: 26278
		internal static int __PropertyOffset_Refraction;

		// Token: 0x040066A7 RID: 26279
		[Nullable(2)]
		private FExpressionInput _Refraction;

		// Token: 0x040066A8 RID: 26280
		internal static int __PropertyOffset_CustomizedUVs;

		// Token: 0x040066A9 RID: 26281
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TFixedArray<FExpressionInput> _CustomizedUVs;

		// Token: 0x040066AA RID: 26282
		internal static int __PropertyOffset_PixelDepthOffset;

		// Token: 0x040066AB RID: 26283
		[Nullable(2)]
		private FExpressionInput _PixelDepthOffset;

		// Token: 0x040066AC RID: 26284
		internal static int __PropertyOffset_ShadingModel;

		// Token: 0x040066AD RID: 26285
		[Nullable(2)]
		private FExpressionInput _ShadingModel;

		// Token: 0x040066AE RID: 26286
		internal static int __PropertyOffset_ShadowPixelDepthOffset;

		// Token: 0x040066AF RID: 26287
		[Nullable(2)]
		private FExpressionInput _ShadowPixelDepthOffset;

		// Token: 0x040066B0 RID: 26288
		internal static int __PropertyOffset_KuroDepthRimWidth;

		// Token: 0x040066B1 RID: 26289
		[Nullable(2)]
		private FExpressionInput _KuroDepthRimWidth;

		// Token: 0x040066B2 RID: 26290
		internal static int __PropertyOffset_KuroPreComputeShadow;

		// Token: 0x040066B3 RID: 26291
		[Nullable(2)]
		private FExpressionInput _KuroPreComputeShadow;
	}
}
