using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020025D9 RID: 9689
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.NiagaraRibbonRendererProperties")]
	[UnrealStructLayout(5320, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 5320)]
	public class UNiagaraRibbonRendererProperties : UNiagaraRendererProperties, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06024000 RID: 147456 RVA: 0x003540C5 File Offset: 0x003522C5
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNiagaraRibbonRendererProperties._ClassPtr;
		}

		// Token: 0x06024001 RID: 147457 RVA: 0x003540D4 File Offset: 0x003522D4
		public UNiagaraRibbonRendererProperties() : this(BuiltinUtils.AllocNativeUObject(UNiagaraRibbonRendererProperties.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06024002 RID: 147458 RVA: 0x003540FC File Offset: 0x003522FC
		public UNiagaraRibbonRendererProperties(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNiagaraRibbonRendererProperties.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008A6E RID: 35438
		// (get) Token: 0x06024003 RID: 147459 RVA: 0x0035412F File Offset: 0x0035232F
		// (set) Token: 0x06024004 RID: 147460 RVA: 0x00354143 File Offset: 0x00352343
		[Nullable(2)]
		public unsafe UMaterialInterface Material
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + UNiagaraRibbonRendererProperties.__PropertyOffset_Material);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UNiagaraRibbonRendererProperties.__PropertyOffset_Material, value);
			}
		}

		// Token: 0x17008A6F RID: 35439
		// (get) Token: 0x06024005 RID: 147461 RVA: 0x00354158 File Offset: 0x00352358
		// (set) Token: 0x06024006 RID: 147462 RVA: 0x00354191 File Offset: 0x00352391
		public FNiagaraUserParameterBinding MaterialUserParamBinding
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraUserParameterBinding result;
				if ((result = this._MaterialUserParamBinding) == null)
				{
					result = (this._MaterialUserParamBinding = new FNiagaraUserParameterBinding(base.NativePtr + (IntPtr)UNiagaraRibbonRendererProperties.__PropertyOffset_MaterialUserParamBinding, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraUserParameterBinding.StaticStruct(), base.NativePtr + (IntPtr)UNiagaraRibbonRendererProperties.__PropertyOffset_MaterialUserParamBinding, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008A70 RID: 35440
		// (get) Token: 0x06024007 RID: 147463 RVA: 0x003541B2 File Offset: 0x003523B2
		// (set) Token: 0x06024008 RID: 147464 RVA: 0x003541C2 File Offset: 0x003523C2
		public unsafe ENiagaraRibbonFacingMode FacingMode
		{
			get
			{
				return (ENiagaraRibbonFacingMode)(*(base.NativePtr + (IntPtr)UNiagaraRibbonRendererProperties.__PropertyOffset_FacingMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraRibbonRendererProperties.__PropertyOffset_FacingMode) = (byte)value;
			}
		}

		// Token: 0x17008A71 RID: 35441
		// (get) Token: 0x06024009 RID: 147465 RVA: 0x003541D4 File Offset: 0x003523D4
		// (set) Token: 0x0602400A RID: 147466 RVA: 0x0035420D File Offset: 0x0035240D
		public FNiagaraRibbonUVSettings UV0Settings
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraRibbonUVSettings result;
				if ((result = this._UV0Settings) == null)
				{
					result = (this._UV0Settings = new FNiagaraRibbonUVSettings(base.NativePtr + (IntPtr)UNiagaraRibbonRendererProperties.__PropertyOffset_UV0Settings, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraRibbonUVSettings.StaticStruct(), base.NativePtr + (IntPtr)UNiagaraRibbonRendererProperties.__PropertyOffset_UV0Settings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008A72 RID: 35442
		// (get) Token: 0x0602400B RID: 147467 RVA: 0x00354230 File Offset: 0x00352430
		// (set) Token: 0x0602400C RID: 147468 RVA: 0x00354269 File Offset: 0x00352469
		public FNiagaraRibbonUVSettings UV1Settings
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraRibbonUVSettings result;
				if ((result = this._UV1Settings) == null)
				{
					result = (this._UV1Settings = new FNiagaraRibbonUVSettings(base.NativePtr + (IntPtr)UNiagaraRibbonRendererProperties.__PropertyOffset_UV1Settings, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraRibbonUVSettings.StaticStruct(), base.NativePtr + (IntPtr)UNiagaraRibbonRendererProperties.__PropertyOffset_UV1Settings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008A73 RID: 35443
		// (get) Token: 0x0602400D RID: 147469 RVA: 0x0035428A File Offset: 0x0035248A
		// (set) Token: 0x0602400E RID: 147470 RVA: 0x0035429A File Offset: 0x0035249A
		public unsafe ENiagaraRibbonDrawDirection DrawDirection
		{
			get
			{
				return (ENiagaraRibbonDrawDirection)(*(base.NativePtr + (IntPtr)UNiagaraRibbonRendererProperties.__PropertyOffset_DrawDirection));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraRibbonRendererProperties.__PropertyOffset_DrawDirection) = (byte)value;
			}
		}

		// Token: 0x17008A74 RID: 35444
		// (get) Token: 0x0602400F RID: 147471 RVA: 0x003542AB File Offset: 0x003524AB
		// (set) Token: 0x06024010 RID: 147472 RVA: 0x003542BB File Offset: 0x003524BB
		public unsafe float CurveTension
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraRibbonRendererProperties.__PropertyOffset_CurveTension);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraRibbonRendererProperties.__PropertyOffset_CurveTension) = value;
			}
		}

		// Token: 0x17008A75 RID: 35445
		// (get) Token: 0x06024011 RID: 147473 RVA: 0x003542CC File Offset: 0x003524CC
		// (set) Token: 0x06024012 RID: 147474 RVA: 0x003542DC File Offset: 0x003524DC
		public unsafe ENiagaraRibbonTessellationMode TessellationMode
		{
			get
			{
				return (ENiagaraRibbonTessellationMode)(*(base.NativePtr + (IntPtr)UNiagaraRibbonRendererProperties.__PropertyOffset_TessellationMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraRibbonRendererProperties.__PropertyOffset_TessellationMode) = (byte)value;
			}
		}

		// Token: 0x17008A76 RID: 35446
		// (get) Token: 0x06024013 RID: 147475 RVA: 0x003542ED File Offset: 0x003524ED
		// (set) Token: 0x06024014 RID: 147476 RVA: 0x003542FD File Offset: 0x003524FD
		public unsafe int TessellationFactor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraRibbonRendererProperties.__PropertyOffset_TessellationFactor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraRibbonRendererProperties.__PropertyOffset_TessellationFactor) = value;
			}
		}

		// Token: 0x17008A77 RID: 35447
		// (get) Token: 0x06024015 RID: 147477 RVA: 0x0035430E File Offset: 0x0035250E
		// (set) Token: 0x06024016 RID: 147478 RVA: 0x0035431E File Offset: 0x0035251E
		public unsafe bool bUseConstantFactor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraRibbonRendererProperties.__PropertyOffset_bUseConstantFactor) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraRibbonRendererProperties.__PropertyOffset_bUseConstantFactor) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008A78 RID: 35448
		// (get) Token: 0x06024017 RID: 147479 RVA: 0x0035432F File Offset: 0x0035252F
		// (set) Token: 0x06024018 RID: 147480 RVA: 0x0035433F File Offset: 0x0035253F
		public unsafe float TessellationAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraRibbonRendererProperties.__PropertyOffset_TessellationAngle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraRibbonRendererProperties.__PropertyOffset_TessellationAngle) = value;
			}
		}

		// Token: 0x17008A79 RID: 35449
		// (get) Token: 0x06024019 RID: 147481 RVA: 0x00354350 File Offset: 0x00352550
		// (set) Token: 0x0602401A RID: 147482 RVA: 0x00354360 File Offset: 0x00352560
		public unsafe bool bScreenSpaceTessellation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraRibbonRendererProperties.__PropertyOffset_bScreenSpaceTessellation) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraRibbonRendererProperties.__PropertyOffset_bScreenSpaceTessellation) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008A7A RID: 35450
		// (get) Token: 0x0602401B RID: 147483 RVA: 0x00354374 File Offset: 0x00352574
		// (set) Token: 0x0602401C RID: 147484 RVA: 0x003543AD File Offset: 0x003525AD
		public FNiagaraVariableAttributeBinding PositionBinding
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraVariableAttributeBinding result;
				if ((result = this._PositionBinding) == null)
				{
					result = (this._PositionBinding = new FNiagaraVariableAttributeBinding(base.NativePtr + (IntPtr)UNiagaraRibbonRendererProperties.__PropertyOffset_PositionBinding, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraVariableAttributeBinding.StaticStruct(), base.NativePtr + (IntPtr)UNiagaraRibbonRendererProperties.__PropertyOffset_PositionBinding, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008A7B RID: 35451
		// (get) Token: 0x0602401D RID: 147485 RVA: 0x003543D0 File Offset: 0x003525D0
		// (set) Token: 0x0602401E RID: 147486 RVA: 0x00354409 File Offset: 0x00352609
		public FNiagaraVariableAttributeBinding ColorBinding
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraVariableAttributeBinding result;
				if ((result = this._ColorBinding) == null)
				{
					result = (this._ColorBinding = new FNiagaraVariableAttributeBinding(base.NativePtr + (IntPtr)UNiagaraRibbonRendererProperties.__PropertyOffset_ColorBinding, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraVariableAttributeBinding.StaticStruct(), base.NativePtr + (IntPtr)UNiagaraRibbonRendererProperties.__PropertyOffset_ColorBinding, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008A7C RID: 35452
		// (get) Token: 0x0602401F RID: 147487 RVA: 0x0035442C File Offset: 0x0035262C
		// (set) Token: 0x06024020 RID: 147488 RVA: 0x00354465 File Offset: 0x00352665
		public FNiagaraVariableAttributeBinding VelocityBinding
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraVariableAttributeBinding result;
				if ((result = this._VelocityBinding) == null)
				{
					result = (this._VelocityBinding = new FNiagaraVariableAttributeBinding(base.NativePtr + (IntPtr)UNiagaraRibbonRendererProperties.__PropertyOffset_VelocityBinding, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraVariableAttributeBinding.StaticStruct(), base.NativePtr + (IntPtr)UNiagaraRibbonRendererProperties.__PropertyOffset_VelocityBinding, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008A7D RID: 35453
		// (get) Token: 0x06024021 RID: 147489 RVA: 0x00354488 File Offset: 0x00352688
		// (set) Token: 0x06024022 RID: 147490 RVA: 0x003544C1 File Offset: 0x003526C1
		public FNiagaraVariableAttributeBinding NormalizedAgeBinding
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraVariableAttributeBinding result;
				if ((result = this._NormalizedAgeBinding) == null)
				{
					result = (this._NormalizedAgeBinding = new FNiagaraVariableAttributeBinding(base.NativePtr + (IntPtr)UNiagaraRibbonRendererProperties.__PropertyOffset_NormalizedAgeBinding, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraVariableAttributeBinding.StaticStruct(), base.NativePtr + (IntPtr)UNiagaraRibbonRendererProperties.__PropertyOffset_NormalizedAgeBinding, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008A7E RID: 35454
		// (get) Token: 0x06024023 RID: 147491 RVA: 0x003544E4 File Offset: 0x003526E4
		// (set) Token: 0x06024024 RID: 147492 RVA: 0x0035451D File Offset: 0x0035271D
		public FNiagaraVariableAttributeBinding RibbonTwistBinding
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraVariableAttributeBinding result;
				if ((result = this._RibbonTwistBinding) == null)
				{
					result = (this._RibbonTwistBinding = new FNiagaraVariableAttributeBinding(base.NativePtr + (IntPtr)UNiagaraRibbonRendererProperties.__PropertyOffset_RibbonTwistBinding, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraVariableAttributeBinding.StaticStruct(), base.NativePtr + (IntPtr)UNiagaraRibbonRendererProperties.__PropertyOffset_RibbonTwistBinding, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008A7F RID: 35455
		// (get) Token: 0x06024025 RID: 147493 RVA: 0x00354540 File Offset: 0x00352740
		// (set) Token: 0x06024026 RID: 147494 RVA: 0x00354579 File Offset: 0x00352779
		public FNiagaraVariableAttributeBinding RibbonWidthBinding
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraVariableAttributeBinding result;
				if ((result = this._RibbonWidthBinding) == null)
				{
					result = (this._RibbonWidthBinding = new FNiagaraVariableAttributeBinding(base.NativePtr + (IntPtr)UNiagaraRibbonRendererProperties.__PropertyOffset_RibbonWidthBinding, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraVariableAttributeBinding.StaticStruct(), base.NativePtr + (IntPtr)UNiagaraRibbonRendererProperties.__PropertyOffset_RibbonWidthBinding, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008A80 RID: 35456
		// (get) Token: 0x06024027 RID: 147495 RVA: 0x0035459C File Offset: 0x0035279C
		// (set) Token: 0x06024028 RID: 147496 RVA: 0x003545D5 File Offset: 0x003527D5
		public FNiagaraVariableAttributeBinding RibbonFacingBinding
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraVariableAttributeBinding result;
				if ((result = this._RibbonFacingBinding) == null)
				{
					result = (this._RibbonFacingBinding = new FNiagaraVariableAttributeBinding(base.NativePtr + (IntPtr)UNiagaraRibbonRendererProperties.__PropertyOffset_RibbonFacingBinding, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraVariableAttributeBinding.StaticStruct(), base.NativePtr + (IntPtr)UNiagaraRibbonRendererProperties.__PropertyOffset_RibbonFacingBinding, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008A81 RID: 35457
		// (get) Token: 0x06024029 RID: 147497 RVA: 0x003545F8 File Offset: 0x003527F8
		// (set) Token: 0x0602402A RID: 147498 RVA: 0x00354631 File Offset: 0x00352831
		public FNiagaraVariableAttributeBinding RibbonIdBinding
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraVariableAttributeBinding result;
				if ((result = this._RibbonIdBinding) == null)
				{
					result = (this._RibbonIdBinding = new FNiagaraVariableAttributeBinding(base.NativePtr + (IntPtr)UNiagaraRibbonRendererProperties.__PropertyOffset_RibbonIdBinding, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraVariableAttributeBinding.StaticStruct(), base.NativePtr + (IntPtr)UNiagaraRibbonRendererProperties.__PropertyOffset_RibbonIdBinding, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008A82 RID: 35458
		// (get) Token: 0x0602402B RID: 147499 RVA: 0x00354654 File Offset: 0x00352854
		// (set) Token: 0x0602402C RID: 147500 RVA: 0x0035468D File Offset: 0x0035288D
		public FNiagaraVariableAttributeBinding RibbonLinkOrderBinding
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraVariableAttributeBinding result;
				if ((result = this._RibbonLinkOrderBinding) == null)
				{
					result = (this._RibbonLinkOrderBinding = new FNiagaraVariableAttributeBinding(base.NativePtr + (IntPtr)UNiagaraRibbonRendererProperties.__PropertyOffset_RibbonLinkOrderBinding, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraVariableAttributeBinding.StaticStruct(), base.NativePtr + (IntPtr)UNiagaraRibbonRendererProperties.__PropertyOffset_RibbonLinkOrderBinding, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008A83 RID: 35459
		// (get) Token: 0x0602402D RID: 147501 RVA: 0x003546B0 File Offset: 0x003528B0
		// (set) Token: 0x0602402E RID: 147502 RVA: 0x003546E9 File Offset: 0x003528E9
		public FNiagaraVariableAttributeBinding MaterialRandomBinding
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraVariableAttributeBinding result;
				if ((result = this._MaterialRandomBinding) == null)
				{
					result = (this._MaterialRandomBinding = new FNiagaraVariableAttributeBinding(base.NativePtr + (IntPtr)UNiagaraRibbonRendererProperties.__PropertyOffset_MaterialRandomBinding, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraVariableAttributeBinding.StaticStruct(), base.NativePtr + (IntPtr)UNiagaraRibbonRendererProperties.__PropertyOffset_MaterialRandomBinding, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008A84 RID: 35460
		// (get) Token: 0x0602402F RID: 147503 RVA: 0x0035470C File Offset: 0x0035290C
		// (set) Token: 0x06024030 RID: 147504 RVA: 0x00354745 File Offset: 0x00352945
		public FNiagaraVariableAttributeBinding DynamicMaterialBinding
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraVariableAttributeBinding result;
				if ((result = this._DynamicMaterialBinding) == null)
				{
					result = (this._DynamicMaterialBinding = new FNiagaraVariableAttributeBinding(base.NativePtr + (IntPtr)UNiagaraRibbonRendererProperties.__PropertyOffset_DynamicMaterialBinding, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraVariableAttributeBinding.StaticStruct(), base.NativePtr + (IntPtr)UNiagaraRibbonRendererProperties.__PropertyOffset_DynamicMaterialBinding, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008A85 RID: 35461
		// (get) Token: 0x06024031 RID: 147505 RVA: 0x00354768 File Offset: 0x00352968
		// (set) Token: 0x06024032 RID: 147506 RVA: 0x003547A1 File Offset: 0x003529A1
		public FNiagaraVariableAttributeBinding DynamicMaterial1Binding
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraVariableAttributeBinding result;
				if ((result = this._DynamicMaterial1Binding) == null)
				{
					result = (this._DynamicMaterial1Binding = new FNiagaraVariableAttributeBinding(base.NativePtr + (IntPtr)UNiagaraRibbonRendererProperties.__PropertyOffset_DynamicMaterial1Binding, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraVariableAttributeBinding.StaticStruct(), base.NativePtr + (IntPtr)UNiagaraRibbonRendererProperties.__PropertyOffset_DynamicMaterial1Binding, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008A86 RID: 35462
		// (get) Token: 0x06024033 RID: 147507 RVA: 0x003547C4 File Offset: 0x003529C4
		// (set) Token: 0x06024034 RID: 147508 RVA: 0x003547FD File Offset: 0x003529FD
		public FNiagaraVariableAttributeBinding DynamicMaterial2Binding
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraVariableAttributeBinding result;
				if ((result = this._DynamicMaterial2Binding) == null)
				{
					result = (this._DynamicMaterial2Binding = new FNiagaraVariableAttributeBinding(base.NativePtr + (IntPtr)UNiagaraRibbonRendererProperties.__PropertyOffset_DynamicMaterial2Binding, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraVariableAttributeBinding.StaticStruct(), base.NativePtr + (IntPtr)UNiagaraRibbonRendererProperties.__PropertyOffset_DynamicMaterial2Binding, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008A87 RID: 35463
		// (get) Token: 0x06024035 RID: 147509 RVA: 0x00354820 File Offset: 0x00352A20
		// (set) Token: 0x06024036 RID: 147510 RVA: 0x00354859 File Offset: 0x00352A59
		public FNiagaraVariableAttributeBinding DynamicMaterial3Binding
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraVariableAttributeBinding result;
				if ((result = this._DynamicMaterial3Binding) == null)
				{
					result = (this._DynamicMaterial3Binding = new FNiagaraVariableAttributeBinding(base.NativePtr + (IntPtr)UNiagaraRibbonRendererProperties.__PropertyOffset_DynamicMaterial3Binding, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraVariableAttributeBinding.StaticStruct(), base.NativePtr + (IntPtr)UNiagaraRibbonRendererProperties.__PropertyOffset_DynamicMaterial3Binding, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008A88 RID: 35464
		// (get) Token: 0x06024037 RID: 147511 RVA: 0x0035487C File Offset: 0x00352A7C
		// (set) Token: 0x06024038 RID: 147512 RVA: 0x003548B5 File Offset: 0x00352AB5
		public FNiagaraVariableAttributeBinding U0OverrideBinding
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraVariableAttributeBinding result;
				if ((result = this._U0OverrideBinding) == null)
				{
					result = (this._U0OverrideBinding = new FNiagaraVariableAttributeBinding(base.NativePtr + (IntPtr)UNiagaraRibbonRendererProperties.__PropertyOffset_U0OverrideBinding, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraVariableAttributeBinding.StaticStruct(), base.NativePtr + (IntPtr)UNiagaraRibbonRendererProperties.__PropertyOffset_U0OverrideBinding, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008A89 RID: 35465
		// (get) Token: 0x06024039 RID: 147513 RVA: 0x003548D8 File Offset: 0x00352AD8
		// (set) Token: 0x0602403A RID: 147514 RVA: 0x00354911 File Offset: 0x00352B11
		public FNiagaraVariableAttributeBinding V0RangeOverrideBinding
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraVariableAttributeBinding result;
				if ((result = this._V0RangeOverrideBinding) == null)
				{
					result = (this._V0RangeOverrideBinding = new FNiagaraVariableAttributeBinding(base.NativePtr + (IntPtr)UNiagaraRibbonRendererProperties.__PropertyOffset_V0RangeOverrideBinding, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraVariableAttributeBinding.StaticStruct(), base.NativePtr + (IntPtr)UNiagaraRibbonRendererProperties.__PropertyOffset_V0RangeOverrideBinding, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008A8A RID: 35466
		// (get) Token: 0x0602403B RID: 147515 RVA: 0x00354934 File Offset: 0x00352B34
		// (set) Token: 0x0602403C RID: 147516 RVA: 0x0035496D File Offset: 0x00352B6D
		public FNiagaraVariableAttributeBinding U1OverrideBinding
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraVariableAttributeBinding result;
				if ((result = this._U1OverrideBinding) == null)
				{
					result = (this._U1OverrideBinding = new FNiagaraVariableAttributeBinding(base.NativePtr + (IntPtr)UNiagaraRibbonRendererProperties.__PropertyOffset_U1OverrideBinding, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraVariableAttributeBinding.StaticStruct(), base.NativePtr + (IntPtr)UNiagaraRibbonRendererProperties.__PropertyOffset_U1OverrideBinding, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008A8B RID: 35467
		// (get) Token: 0x0602403D RID: 147517 RVA: 0x00354990 File Offset: 0x00352B90
		// (set) Token: 0x0602403E RID: 147518 RVA: 0x003549C9 File Offset: 0x00352BC9
		public FNiagaraVariableAttributeBinding V1RangeOverrideBinding
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraVariableAttributeBinding result;
				if ((result = this._V1RangeOverrideBinding) == null)
				{
					result = (this._V1RangeOverrideBinding = new FNiagaraVariableAttributeBinding(base.NativePtr + (IntPtr)UNiagaraRibbonRendererProperties.__PropertyOffset_V1RangeOverrideBinding, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraVariableAttributeBinding.StaticStruct(), base.NativePtr + (IntPtr)UNiagaraRibbonRendererProperties.__PropertyOffset_V1RangeOverrideBinding, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008A8C RID: 35468
		// (get) Token: 0x0602403F RID: 147519 RVA: 0x003549EC File Offset: 0x00352BEC
		// (set) Token: 0x06024040 RID: 147520 RVA: 0x00354A25 File Offset: 0x00352C25
		public TArray<FNiagaraMaterialAttributeBinding> MaterialParameterBindings
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FNiagaraMaterialAttributeBinding> result;
				if ((result = this._MaterialParameterBindings) == null)
				{
					result = (this._MaterialParameterBindings = new TArray<FNiagaraMaterialAttributeBinding>(base.NativePtr + (IntPtr)UNiagaraRibbonRendererProperties.__PropertyOffset_MaterialParameterBindings, this));
				}
				return result;
			}
			set
			{
				this.MaterialParameterBindings.CopyAssign(value);
			}
		}

		// Token: 0x06024041 RID: 147521 RVA: 0x00354A33 File Offset: 0x00352C33
		static UNiagaraRibbonRendererProperties()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Niagara.NiagaraRibbonRendererProperties");
		}

		// Token: 0x06024042 RID: 147522 RVA: 0x00354A41 File Offset: 0x00352C41
		protected UNiagaraRibbonRendererProperties(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040134D9 RID: 79065
		public new const string __ObjectPath = "/Script/Niagara.NiagaraRibbonRendererProperties";

		// Token: 0x040134DA RID: 79066
		private static IntPtr _ClassPtr;

		// Token: 0x040134DB RID: 79067
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040134DC RID: 79068
		internal static int __PropertyOffset_Material;

		// Token: 0x040134DD RID: 79069
		internal static int __PropertyOffset_MaterialUserParamBinding;

		// Token: 0x040134DE RID: 79070
		[Nullable(2)]
		private FNiagaraUserParameterBinding _MaterialUserParamBinding;

		// Token: 0x040134DF RID: 79071
		internal static int __PropertyOffset_FacingMode;

		// Token: 0x040134E0 RID: 79072
		internal static int __PropertyOffset_UV0Settings;

		// Token: 0x040134E1 RID: 79073
		[Nullable(2)]
		private FNiagaraRibbonUVSettings _UV0Settings;

		// Token: 0x040134E2 RID: 79074
		internal static int __PropertyOffset_UV1Settings;

		// Token: 0x040134E3 RID: 79075
		[Nullable(2)]
		private FNiagaraRibbonUVSettings _UV1Settings;

		// Token: 0x040134E4 RID: 79076
		internal static int __PropertyOffset_DrawDirection;

		// Token: 0x040134E5 RID: 79077
		internal static int __PropertyOffset_CurveTension;

		// Token: 0x040134E6 RID: 79078
		internal static int __PropertyOffset_TessellationMode;

		// Token: 0x040134E7 RID: 79079
		internal static int __PropertyOffset_TessellationFactor;

		// Token: 0x040134E8 RID: 79080
		internal static int __PropertyOffset_bUseConstantFactor;

		// Token: 0x040134E9 RID: 79081
		internal static int __PropertyOffset_TessellationAngle;

		// Token: 0x040134EA RID: 79082
		internal static int __PropertyOffset_bScreenSpaceTessellation;

		// Token: 0x040134EB RID: 79083
		internal static int __PropertyOffset_PositionBinding;

		// Token: 0x040134EC RID: 79084
		[Nullable(2)]
		private FNiagaraVariableAttributeBinding _PositionBinding;

		// Token: 0x040134ED RID: 79085
		internal static int __PropertyOffset_ColorBinding;

		// Token: 0x040134EE RID: 79086
		[Nullable(2)]
		private FNiagaraVariableAttributeBinding _ColorBinding;

		// Token: 0x040134EF RID: 79087
		internal static int __PropertyOffset_VelocityBinding;

		// Token: 0x040134F0 RID: 79088
		[Nullable(2)]
		private FNiagaraVariableAttributeBinding _VelocityBinding;

		// Token: 0x040134F1 RID: 79089
		internal static int __PropertyOffset_NormalizedAgeBinding;

		// Token: 0x040134F2 RID: 79090
		[Nullable(2)]
		private FNiagaraVariableAttributeBinding _NormalizedAgeBinding;

		// Token: 0x040134F3 RID: 79091
		internal static int __PropertyOffset_RibbonTwistBinding;

		// Token: 0x040134F4 RID: 79092
		[Nullable(2)]
		private FNiagaraVariableAttributeBinding _RibbonTwistBinding;

		// Token: 0x040134F5 RID: 79093
		internal static int __PropertyOffset_RibbonWidthBinding;

		// Token: 0x040134F6 RID: 79094
		[Nullable(2)]
		private FNiagaraVariableAttributeBinding _RibbonWidthBinding;

		// Token: 0x040134F7 RID: 79095
		internal static int __PropertyOffset_RibbonFacingBinding;

		// Token: 0x040134F8 RID: 79096
		[Nullable(2)]
		private FNiagaraVariableAttributeBinding _RibbonFacingBinding;

		// Token: 0x040134F9 RID: 79097
		internal static int __PropertyOffset_RibbonIdBinding;

		// Token: 0x040134FA RID: 79098
		[Nullable(2)]
		private FNiagaraVariableAttributeBinding _RibbonIdBinding;

		// Token: 0x040134FB RID: 79099
		internal static int __PropertyOffset_RibbonLinkOrderBinding;

		// Token: 0x040134FC RID: 79100
		[Nullable(2)]
		private FNiagaraVariableAttributeBinding _RibbonLinkOrderBinding;

		// Token: 0x040134FD RID: 79101
		internal static int __PropertyOffset_MaterialRandomBinding;

		// Token: 0x040134FE RID: 79102
		[Nullable(2)]
		private FNiagaraVariableAttributeBinding _MaterialRandomBinding;

		// Token: 0x040134FF RID: 79103
		internal static int __PropertyOffset_DynamicMaterialBinding;

		// Token: 0x04013500 RID: 79104
		[Nullable(2)]
		private FNiagaraVariableAttributeBinding _DynamicMaterialBinding;

		// Token: 0x04013501 RID: 79105
		internal static int __PropertyOffset_DynamicMaterial1Binding;

		// Token: 0x04013502 RID: 79106
		[Nullable(2)]
		private FNiagaraVariableAttributeBinding _DynamicMaterial1Binding;

		// Token: 0x04013503 RID: 79107
		internal static int __PropertyOffset_DynamicMaterial2Binding;

		// Token: 0x04013504 RID: 79108
		[Nullable(2)]
		private FNiagaraVariableAttributeBinding _DynamicMaterial2Binding;

		// Token: 0x04013505 RID: 79109
		internal static int __PropertyOffset_DynamicMaterial3Binding;

		// Token: 0x04013506 RID: 79110
		[Nullable(2)]
		private FNiagaraVariableAttributeBinding _DynamicMaterial3Binding;

		// Token: 0x04013507 RID: 79111
		internal static int __PropertyOffset_U0OverrideBinding;

		// Token: 0x04013508 RID: 79112
		[Nullable(2)]
		private FNiagaraVariableAttributeBinding _U0OverrideBinding;

		// Token: 0x04013509 RID: 79113
		internal static int __PropertyOffset_V0RangeOverrideBinding;

		// Token: 0x0401350A RID: 79114
		[Nullable(2)]
		private FNiagaraVariableAttributeBinding _V0RangeOverrideBinding;

		// Token: 0x0401350B RID: 79115
		internal static int __PropertyOffset_U1OverrideBinding;

		// Token: 0x0401350C RID: 79116
		[Nullable(2)]
		private FNiagaraVariableAttributeBinding _U1OverrideBinding;

		// Token: 0x0401350D RID: 79117
		internal static int __PropertyOffset_V1RangeOverrideBinding;

		// Token: 0x0401350E RID: 79118
		[Nullable(2)]
		private FNiagaraVariableAttributeBinding _V1RangeOverrideBinding;

		// Token: 0x0401350F RID: 79119
		internal static int __PropertyOffset_MaterialParameterBindings;

		// Token: 0x04013510 RID: 79120
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FNiagaraMaterialAttributeBinding> _MaterialParameterBindings;
	}
}
