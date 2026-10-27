using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020025ED RID: 9709
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.NiagaraSpriteRendererProperties")]
	[UnrealStructLayout(5248, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 5248)]
	public class UNiagaraSpriteRendererProperties : UNiagaraRendererProperties, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602414F RID: 147791 RVA: 0x003562B6 File Offset: 0x003544B6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNiagaraSpriteRendererProperties._ClassPtr;
		}

		// Token: 0x06024150 RID: 147792 RVA: 0x003562C4 File Offset: 0x003544C4
		public UNiagaraSpriteRendererProperties() : this(BuiltinUtils.AllocNativeUObject(UNiagaraSpriteRendererProperties.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06024151 RID: 147793 RVA: 0x003562EC File Offset: 0x003544EC
		public UNiagaraSpriteRendererProperties(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNiagaraSpriteRendererProperties.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008AD3 RID: 35539
		// (get) Token: 0x06024152 RID: 147794 RVA: 0x0035631F File Offset: 0x0035451F
		// (set) Token: 0x06024153 RID: 147795 RVA: 0x00356333 File Offset: 0x00354533
		[Nullable(2)]
		public unsafe UMaterialInterface Material
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + UNiagaraSpriteRendererProperties.__PropertyOffset_Material);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UNiagaraSpriteRendererProperties.__PropertyOffset_Material, value);
			}
		}

		// Token: 0x17008AD4 RID: 35540
		// (get) Token: 0x06024154 RID: 147796 RVA: 0x00356348 File Offset: 0x00354548
		// (set) Token: 0x06024155 RID: 147797 RVA: 0x00356358 File Offset: 0x00354558
		public unsafe ENiagaraRendererSourceDataMode SourceMode
		{
			get
			{
				return (ENiagaraRendererSourceDataMode)(*(base.NativePtr + (IntPtr)UNiagaraSpriteRendererProperties.__PropertyOffset_SourceMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraSpriteRendererProperties.__PropertyOffset_SourceMode) = (byte)value;
			}
		}

		// Token: 0x17008AD5 RID: 35541
		// (get) Token: 0x06024156 RID: 147798 RVA: 0x0035636C File Offset: 0x0035456C
		// (set) Token: 0x06024157 RID: 147799 RVA: 0x003563A5 File Offset: 0x003545A5
		public FNiagaraUserParameterBinding MaterialUserParamBinding
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraUserParameterBinding result;
				if ((result = this._MaterialUserParamBinding) == null)
				{
					result = (this._MaterialUserParamBinding = new FNiagaraUserParameterBinding(base.NativePtr + (IntPtr)UNiagaraSpriteRendererProperties.__PropertyOffset_MaterialUserParamBinding, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraUserParameterBinding.StaticStruct(), base.NativePtr + (IntPtr)UNiagaraSpriteRendererProperties.__PropertyOffset_MaterialUserParamBinding, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008AD6 RID: 35542
		// (get) Token: 0x06024158 RID: 147800 RVA: 0x003563C6 File Offset: 0x003545C6
		// (set) Token: 0x06024159 RID: 147801 RVA: 0x003563D6 File Offset: 0x003545D6
		public unsafe ENiagaraSpriteAlignment Alignment
		{
			get
			{
				return (ENiagaraSpriteAlignment)(*(base.NativePtr + (IntPtr)UNiagaraSpriteRendererProperties.__PropertyOffset_Alignment));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraSpriteRendererProperties.__PropertyOffset_Alignment) = (byte)value;
			}
		}

		// Token: 0x17008AD7 RID: 35543
		// (get) Token: 0x0602415A RID: 147802 RVA: 0x003563E7 File Offset: 0x003545E7
		// (set) Token: 0x0602415B RID: 147803 RVA: 0x003563F7 File Offset: 0x003545F7
		public unsafe ENiagaraSpriteFacingMode FacingMode
		{
			get
			{
				return (ENiagaraSpriteFacingMode)(*(base.NativePtr + (IntPtr)UNiagaraSpriteRendererProperties.__PropertyOffset_FacingMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraSpriteRendererProperties.__PropertyOffset_FacingMode) = (byte)value;
			}
		}

		// Token: 0x17008AD8 RID: 35544
		// (get) Token: 0x0602415C RID: 147804 RVA: 0x00356408 File Offset: 0x00354608
		// (set) Token: 0x0602415D RID: 147805 RVA: 0x0035641C File Offset: 0x0035461C
		public unsafe FVector2D PivotInUVSpace
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraSpriteRendererProperties.__PropertyOffset_PivotInUVSpace);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraSpriteRendererProperties.__PropertyOffset_PivotInUVSpace) = value;
			}
		}

		// Token: 0x17008AD9 RID: 35545
		// (get) Token: 0x0602415E RID: 147806 RVA: 0x00356431 File Offset: 0x00354631
		// (set) Token: 0x0602415F RID: 147807 RVA: 0x0035644A File Offset: 0x0035464A
		public unsafe bool bUseScreenEffectMode
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UNiagaraSpriteRendererProperties.__PropertyOffset_bUseScreenEffectMode) & UNiagaraSpriteRendererProperties.__PropertyMask_bUseScreenEffectMode) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UNiagaraSpriteRendererProperties.__PropertyOffset_bUseScreenEffectMode) = ((*(base.NativePtr + (IntPtr)UNiagaraSpriteRendererProperties.__PropertyOffset_bUseScreenEffectMode) & ~UNiagaraSpriteRendererProperties.__PropertyMask_bUseScreenEffectMode) | (value ? UNiagaraSpriteRendererProperties.__PropertyMask_bUseScreenEffectMode : 0));
			}
		}

		// Token: 0x17008ADA RID: 35546
		// (get) Token: 0x06024160 RID: 147808 RVA: 0x0035647A File Offset: 0x0035467A
		// (set) Token: 0x06024161 RID: 147809 RVA: 0x0035648A File Offset: 0x0035468A
		public unsafe float SpriteEffectDepth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraSpriteRendererProperties.__PropertyOffset_SpriteEffectDepth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraSpriteRendererProperties.__PropertyOffset_SpriteEffectDepth) = value;
			}
		}

		// Token: 0x17008ADB RID: 35547
		// (get) Token: 0x06024162 RID: 147810 RVA: 0x0035649B File Offset: 0x0035469B
		// (set) Token: 0x06024163 RID: 147811 RVA: 0x003564AF File Offset: 0x003546AF
		public unsafe FVector2D SpriteEffectOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraSpriteRendererProperties.__PropertyOffset_SpriteEffectOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraSpriteRendererProperties.__PropertyOffset_SpriteEffectOffset) = value;
			}
		}

		// Token: 0x17008ADC RID: 35548
		// (get) Token: 0x06024164 RID: 147812 RVA: 0x003564C4 File Offset: 0x003546C4
		// (set) Token: 0x06024165 RID: 147813 RVA: 0x003564D4 File Offset: 0x003546D4
		public unsafe float SpriteSortID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraSpriteRendererProperties.__PropertyOffset_SpriteSortID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraSpriteRendererProperties.__PropertyOffset_SpriteSortID) = value;
			}
		}

		// Token: 0x17008ADD RID: 35549
		// (get) Token: 0x06024166 RID: 147814 RVA: 0x003564E5 File Offset: 0x003546E5
		// (set) Token: 0x06024167 RID: 147815 RVA: 0x003564FE File Offset: 0x003546FE
		public unsafe bool bUseFixedBoundsForScreenEffect
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UNiagaraSpriteRendererProperties.__PropertyOffset_bUseFixedBoundsForScreenEffect) & UNiagaraSpriteRendererProperties.__PropertyMask_bUseFixedBoundsForScreenEffect) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UNiagaraSpriteRendererProperties.__PropertyOffset_bUseFixedBoundsForScreenEffect) = ((*(base.NativePtr + (IntPtr)UNiagaraSpriteRendererProperties.__PropertyOffset_bUseFixedBoundsForScreenEffect) & ~UNiagaraSpriteRendererProperties.__PropertyMask_bUseFixedBoundsForScreenEffect) | (value ? UNiagaraSpriteRendererProperties.__PropertyMask_bUseFixedBoundsForScreenEffect : 0));
			}
		}

		// Token: 0x17008ADE RID: 35550
		// (get) Token: 0x06024168 RID: 147816 RVA: 0x0035652E File Offset: 0x0035472E
		// (set) Token: 0x06024169 RID: 147817 RVA: 0x0035653E File Offset: 0x0035473E
		public unsafe ENiagaraSortMode SortMode
		{
			get
			{
				return (ENiagaraSortMode)(*(base.NativePtr + (IntPtr)UNiagaraSpriteRendererProperties.__PropertyOffset_SortMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraSpriteRendererProperties.__PropertyOffset_SortMode) = (byte)value;
			}
		}

		// Token: 0x17008ADF RID: 35551
		// (get) Token: 0x0602416A RID: 147818 RVA: 0x0035654F File Offset: 0x0035474F
		// (set) Token: 0x0602416B RID: 147819 RVA: 0x00356563 File Offset: 0x00354763
		public unsafe FVector2D SubImageSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraSpriteRendererProperties.__PropertyOffset_SubImageSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraSpriteRendererProperties.__PropertyOffset_SubImageSize) = value;
			}
		}

		// Token: 0x17008AE0 RID: 35552
		// (get) Token: 0x0602416C RID: 147820 RVA: 0x00356578 File Offset: 0x00354778
		// (set) Token: 0x0602416D RID: 147821 RVA: 0x00356591 File Offset: 0x00354791
		public unsafe bool bSubImageBlend
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UNiagaraSpriteRendererProperties.__PropertyOffset_bSubImageBlend) & UNiagaraSpriteRendererProperties.__PropertyMask_bSubImageBlend) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UNiagaraSpriteRendererProperties.__PropertyOffset_bSubImageBlend) = ((*(base.NativePtr + (IntPtr)UNiagaraSpriteRendererProperties.__PropertyOffset_bSubImageBlend) & ~UNiagaraSpriteRendererProperties.__PropertyMask_bSubImageBlend) | (value ? UNiagaraSpriteRendererProperties.__PropertyMask_bSubImageBlend : 0));
			}
		}

		// Token: 0x17008AE1 RID: 35553
		// (get) Token: 0x0602416E RID: 147822 RVA: 0x003565C1 File Offset: 0x003547C1
		// (set) Token: 0x0602416F RID: 147823 RVA: 0x003565DA File Offset: 0x003547DA
		public unsafe bool bRemoveHMDRollInVR
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UNiagaraSpriteRendererProperties.__PropertyOffset_bRemoveHMDRollInVR) & UNiagaraSpriteRendererProperties.__PropertyMask_bRemoveHMDRollInVR) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UNiagaraSpriteRendererProperties.__PropertyOffset_bRemoveHMDRollInVR) = ((*(base.NativePtr + (IntPtr)UNiagaraSpriteRendererProperties.__PropertyOffset_bRemoveHMDRollInVR) & ~UNiagaraSpriteRendererProperties.__PropertyMask_bRemoveHMDRollInVR) | (value ? UNiagaraSpriteRendererProperties.__PropertyMask_bRemoveHMDRollInVR : 0));
			}
		}

		// Token: 0x17008AE2 RID: 35554
		// (get) Token: 0x06024170 RID: 147824 RVA: 0x0035660A File Offset: 0x0035480A
		// (set) Token: 0x06024171 RID: 147825 RVA: 0x00356623 File Offset: 0x00354823
		public unsafe bool bSortOnlyWhenTranslucent
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UNiagaraSpriteRendererProperties.__PropertyOffset_bSortOnlyWhenTranslucent) & UNiagaraSpriteRendererProperties.__PropertyMask_bSortOnlyWhenTranslucent) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UNiagaraSpriteRendererProperties.__PropertyOffset_bSortOnlyWhenTranslucent) = ((*(base.NativePtr + (IntPtr)UNiagaraSpriteRendererProperties.__PropertyOffset_bSortOnlyWhenTranslucent) & ~UNiagaraSpriteRendererProperties.__PropertyMask_bSortOnlyWhenTranslucent) | (value ? UNiagaraSpriteRendererProperties.__PropertyMask_bSortOnlyWhenTranslucent : 0));
			}
		}

		// Token: 0x17008AE3 RID: 35555
		// (get) Token: 0x06024172 RID: 147826 RVA: 0x00356653 File Offset: 0x00354853
		// (set) Token: 0x06024173 RID: 147827 RVA: 0x0035666C File Offset: 0x0035486C
		public unsafe bool bGpuLowLatencyTranslucency
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UNiagaraSpriteRendererProperties.__PropertyOffset_bGpuLowLatencyTranslucency) & UNiagaraSpriteRendererProperties.__PropertyMask_bGpuLowLatencyTranslucency) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UNiagaraSpriteRendererProperties.__PropertyOffset_bGpuLowLatencyTranslucency) = ((*(base.NativePtr + (IntPtr)UNiagaraSpriteRendererProperties.__PropertyOffset_bGpuLowLatencyTranslucency) & ~UNiagaraSpriteRendererProperties.__PropertyMask_bGpuLowLatencyTranslucency) | (value ? UNiagaraSpriteRendererProperties.__PropertyMask_bGpuLowLatencyTranslucency : 0));
			}
		}

		// Token: 0x17008AE4 RID: 35556
		// (get) Token: 0x06024174 RID: 147828 RVA: 0x0035669C File Offset: 0x0035489C
		// (set) Token: 0x06024175 RID: 147829 RVA: 0x003566AC File Offset: 0x003548AC
		public unsafe float MinFacingCameraBlendDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraSpriteRendererProperties.__PropertyOffset_MinFacingCameraBlendDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraSpriteRendererProperties.__PropertyOffset_MinFacingCameraBlendDistance) = value;
			}
		}

		// Token: 0x17008AE5 RID: 35557
		// (get) Token: 0x06024176 RID: 147830 RVA: 0x003566BD File Offset: 0x003548BD
		// (set) Token: 0x06024177 RID: 147831 RVA: 0x003566CD File Offset: 0x003548CD
		public unsafe float MaxFacingCameraBlendDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraSpriteRendererProperties.__PropertyOffset_MaxFacingCameraBlendDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraSpriteRendererProperties.__PropertyOffset_MaxFacingCameraBlendDistance) = value;
			}
		}

		// Token: 0x17008AE6 RID: 35558
		// (get) Token: 0x06024178 RID: 147832 RVA: 0x003566DE File Offset: 0x003548DE
		// (set) Token: 0x06024179 RID: 147833 RVA: 0x003566F7 File Offset: 0x003548F7
		public unsafe bool bEnableCameraDistanceCulling
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UNiagaraSpriteRendererProperties.__PropertyOffset_bEnableCameraDistanceCulling) & UNiagaraSpriteRendererProperties.__PropertyMask_bEnableCameraDistanceCulling) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UNiagaraSpriteRendererProperties.__PropertyOffset_bEnableCameraDistanceCulling) = ((*(base.NativePtr + (IntPtr)UNiagaraSpriteRendererProperties.__PropertyOffset_bEnableCameraDistanceCulling) & ~UNiagaraSpriteRendererProperties.__PropertyMask_bEnableCameraDistanceCulling) | (value ? UNiagaraSpriteRendererProperties.__PropertyMask_bEnableCameraDistanceCulling : 0));
			}
		}

		// Token: 0x17008AE7 RID: 35559
		// (get) Token: 0x0602417A RID: 147834 RVA: 0x00356727 File Offset: 0x00354927
		// (set) Token: 0x0602417B RID: 147835 RVA: 0x00356737 File Offset: 0x00354937
		public unsafe float MinCameraDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraSpriteRendererProperties.__PropertyOffset_MinCameraDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraSpriteRendererProperties.__PropertyOffset_MinCameraDistance) = value;
			}
		}

		// Token: 0x17008AE8 RID: 35560
		// (get) Token: 0x0602417C RID: 147836 RVA: 0x00356748 File Offset: 0x00354948
		// (set) Token: 0x0602417D RID: 147837 RVA: 0x00356758 File Offset: 0x00354958
		public unsafe float MaxCameraDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraSpriteRendererProperties.__PropertyOffset_MaxCameraDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraSpriteRendererProperties.__PropertyOffset_MaxCameraDistance) = value;
			}
		}

		// Token: 0x17008AE9 RID: 35561
		// (get) Token: 0x0602417E RID: 147838 RVA: 0x00356769 File Offset: 0x00354969
		// (set) Token: 0x0602417F RID: 147839 RVA: 0x00356779 File Offset: 0x00354979
		public unsafe uint RendererVisibility
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraSpriteRendererProperties.__PropertyOffset_RendererVisibility);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraSpriteRendererProperties.__PropertyOffset_RendererVisibility) = (int)value;
			}
		}

		// Token: 0x17008AEA RID: 35562
		// (get) Token: 0x06024180 RID: 147840 RVA: 0x0035678C File Offset: 0x0035498C
		// (set) Token: 0x06024181 RID: 147841 RVA: 0x003567C5 File Offset: 0x003549C5
		public FNiagaraVariableAttributeBinding PositionBinding
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraVariableAttributeBinding result;
				if ((result = this._PositionBinding) == null)
				{
					result = (this._PositionBinding = new FNiagaraVariableAttributeBinding(base.NativePtr + (IntPtr)UNiagaraSpriteRendererProperties.__PropertyOffset_PositionBinding, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraVariableAttributeBinding.StaticStruct(), base.NativePtr + (IntPtr)UNiagaraSpriteRendererProperties.__PropertyOffset_PositionBinding, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008AEB RID: 35563
		// (get) Token: 0x06024182 RID: 147842 RVA: 0x003567E8 File Offset: 0x003549E8
		// (set) Token: 0x06024183 RID: 147843 RVA: 0x00356821 File Offset: 0x00354A21
		public FNiagaraVariableAttributeBinding ColorBinding
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraVariableAttributeBinding result;
				if ((result = this._ColorBinding) == null)
				{
					result = (this._ColorBinding = new FNiagaraVariableAttributeBinding(base.NativePtr + (IntPtr)UNiagaraSpriteRendererProperties.__PropertyOffset_ColorBinding, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraVariableAttributeBinding.StaticStruct(), base.NativePtr + (IntPtr)UNiagaraSpriteRendererProperties.__PropertyOffset_ColorBinding, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008AEC RID: 35564
		// (get) Token: 0x06024184 RID: 147844 RVA: 0x00356844 File Offset: 0x00354A44
		// (set) Token: 0x06024185 RID: 147845 RVA: 0x0035687D File Offset: 0x00354A7D
		public FNiagaraVariableAttributeBinding VelocityBinding
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraVariableAttributeBinding result;
				if ((result = this._VelocityBinding) == null)
				{
					result = (this._VelocityBinding = new FNiagaraVariableAttributeBinding(base.NativePtr + (IntPtr)UNiagaraSpriteRendererProperties.__PropertyOffset_VelocityBinding, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraVariableAttributeBinding.StaticStruct(), base.NativePtr + (IntPtr)UNiagaraSpriteRendererProperties.__PropertyOffset_VelocityBinding, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008AED RID: 35565
		// (get) Token: 0x06024186 RID: 147846 RVA: 0x003568A0 File Offset: 0x00354AA0
		// (set) Token: 0x06024187 RID: 147847 RVA: 0x003568D9 File Offset: 0x00354AD9
		public FNiagaraVariableAttributeBinding SpriteRotationBinding
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraVariableAttributeBinding result;
				if ((result = this._SpriteRotationBinding) == null)
				{
					result = (this._SpriteRotationBinding = new FNiagaraVariableAttributeBinding(base.NativePtr + (IntPtr)UNiagaraSpriteRendererProperties.__PropertyOffset_SpriteRotationBinding, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraVariableAttributeBinding.StaticStruct(), base.NativePtr + (IntPtr)UNiagaraSpriteRendererProperties.__PropertyOffset_SpriteRotationBinding, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008AEE RID: 35566
		// (get) Token: 0x06024188 RID: 147848 RVA: 0x003568FC File Offset: 0x00354AFC
		// (set) Token: 0x06024189 RID: 147849 RVA: 0x00356935 File Offset: 0x00354B35
		public FNiagaraVariableAttributeBinding SpriteSizeBinding
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraVariableAttributeBinding result;
				if ((result = this._SpriteSizeBinding) == null)
				{
					result = (this._SpriteSizeBinding = new FNiagaraVariableAttributeBinding(base.NativePtr + (IntPtr)UNiagaraSpriteRendererProperties.__PropertyOffset_SpriteSizeBinding, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraVariableAttributeBinding.StaticStruct(), base.NativePtr + (IntPtr)UNiagaraSpriteRendererProperties.__PropertyOffset_SpriteSizeBinding, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008AEF RID: 35567
		// (get) Token: 0x0602418A RID: 147850 RVA: 0x00356958 File Offset: 0x00354B58
		// (set) Token: 0x0602418B RID: 147851 RVA: 0x00356991 File Offset: 0x00354B91
		public FNiagaraVariableAttributeBinding SpriteFacingBinding
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraVariableAttributeBinding result;
				if ((result = this._SpriteFacingBinding) == null)
				{
					result = (this._SpriteFacingBinding = new FNiagaraVariableAttributeBinding(base.NativePtr + (IntPtr)UNiagaraSpriteRendererProperties.__PropertyOffset_SpriteFacingBinding, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraVariableAttributeBinding.StaticStruct(), base.NativePtr + (IntPtr)UNiagaraSpriteRendererProperties.__PropertyOffset_SpriteFacingBinding, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008AF0 RID: 35568
		// (get) Token: 0x0602418C RID: 147852 RVA: 0x003569B4 File Offset: 0x00354BB4
		// (set) Token: 0x0602418D RID: 147853 RVA: 0x003569ED File Offset: 0x00354BED
		public FNiagaraVariableAttributeBinding SpriteAlignmentBinding
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraVariableAttributeBinding result;
				if ((result = this._SpriteAlignmentBinding) == null)
				{
					result = (this._SpriteAlignmentBinding = new FNiagaraVariableAttributeBinding(base.NativePtr + (IntPtr)UNiagaraSpriteRendererProperties.__PropertyOffset_SpriteAlignmentBinding, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraVariableAttributeBinding.StaticStruct(), base.NativePtr + (IntPtr)UNiagaraSpriteRendererProperties.__PropertyOffset_SpriteAlignmentBinding, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008AF1 RID: 35569
		// (get) Token: 0x0602418E RID: 147854 RVA: 0x00356A10 File Offset: 0x00354C10
		// (set) Token: 0x0602418F RID: 147855 RVA: 0x00356A49 File Offset: 0x00354C49
		public FNiagaraVariableAttributeBinding SubImageIndexBinding
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraVariableAttributeBinding result;
				if ((result = this._SubImageIndexBinding) == null)
				{
					result = (this._SubImageIndexBinding = new FNiagaraVariableAttributeBinding(base.NativePtr + (IntPtr)UNiagaraSpriteRendererProperties.__PropertyOffset_SubImageIndexBinding, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraVariableAttributeBinding.StaticStruct(), base.NativePtr + (IntPtr)UNiagaraSpriteRendererProperties.__PropertyOffset_SubImageIndexBinding, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008AF2 RID: 35570
		// (get) Token: 0x06024190 RID: 147856 RVA: 0x00356A6C File Offset: 0x00354C6C
		// (set) Token: 0x06024191 RID: 147857 RVA: 0x00356AA5 File Offset: 0x00354CA5
		public FNiagaraVariableAttributeBinding DynamicMaterialBinding
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraVariableAttributeBinding result;
				if ((result = this._DynamicMaterialBinding) == null)
				{
					result = (this._DynamicMaterialBinding = new FNiagaraVariableAttributeBinding(base.NativePtr + (IntPtr)UNiagaraSpriteRendererProperties.__PropertyOffset_DynamicMaterialBinding, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraVariableAttributeBinding.StaticStruct(), base.NativePtr + (IntPtr)UNiagaraSpriteRendererProperties.__PropertyOffset_DynamicMaterialBinding, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008AF3 RID: 35571
		// (get) Token: 0x06024192 RID: 147858 RVA: 0x00356AC8 File Offset: 0x00354CC8
		// (set) Token: 0x06024193 RID: 147859 RVA: 0x00356B01 File Offset: 0x00354D01
		public FNiagaraVariableAttributeBinding DynamicMaterial1Binding
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraVariableAttributeBinding result;
				if ((result = this._DynamicMaterial1Binding) == null)
				{
					result = (this._DynamicMaterial1Binding = new FNiagaraVariableAttributeBinding(base.NativePtr + (IntPtr)UNiagaraSpriteRendererProperties.__PropertyOffset_DynamicMaterial1Binding, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraVariableAttributeBinding.StaticStruct(), base.NativePtr + (IntPtr)UNiagaraSpriteRendererProperties.__PropertyOffset_DynamicMaterial1Binding, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008AF4 RID: 35572
		// (get) Token: 0x06024194 RID: 147860 RVA: 0x00356B24 File Offset: 0x00354D24
		// (set) Token: 0x06024195 RID: 147861 RVA: 0x00356B5D File Offset: 0x00354D5D
		public FNiagaraVariableAttributeBinding DynamicMaterial2Binding
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraVariableAttributeBinding result;
				if ((result = this._DynamicMaterial2Binding) == null)
				{
					result = (this._DynamicMaterial2Binding = new FNiagaraVariableAttributeBinding(base.NativePtr + (IntPtr)UNiagaraSpriteRendererProperties.__PropertyOffset_DynamicMaterial2Binding, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraVariableAttributeBinding.StaticStruct(), base.NativePtr + (IntPtr)UNiagaraSpriteRendererProperties.__PropertyOffset_DynamicMaterial2Binding, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008AF5 RID: 35573
		// (get) Token: 0x06024196 RID: 147862 RVA: 0x00356B80 File Offset: 0x00354D80
		// (set) Token: 0x06024197 RID: 147863 RVA: 0x00356BB9 File Offset: 0x00354DB9
		public FNiagaraVariableAttributeBinding DynamicMaterial3Binding
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraVariableAttributeBinding result;
				if ((result = this._DynamicMaterial3Binding) == null)
				{
					result = (this._DynamicMaterial3Binding = new FNiagaraVariableAttributeBinding(base.NativePtr + (IntPtr)UNiagaraSpriteRendererProperties.__PropertyOffset_DynamicMaterial3Binding, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraVariableAttributeBinding.StaticStruct(), base.NativePtr + (IntPtr)UNiagaraSpriteRendererProperties.__PropertyOffset_DynamicMaterial3Binding, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008AF6 RID: 35574
		// (get) Token: 0x06024198 RID: 147864 RVA: 0x00356BDC File Offset: 0x00354DDC
		// (set) Token: 0x06024199 RID: 147865 RVA: 0x00356C15 File Offset: 0x00354E15
		public FNiagaraVariableAttributeBinding CameraOffsetBinding
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraVariableAttributeBinding result;
				if ((result = this._CameraOffsetBinding) == null)
				{
					result = (this._CameraOffsetBinding = new FNiagaraVariableAttributeBinding(base.NativePtr + (IntPtr)UNiagaraSpriteRendererProperties.__PropertyOffset_CameraOffsetBinding, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraVariableAttributeBinding.StaticStruct(), base.NativePtr + (IntPtr)UNiagaraSpriteRendererProperties.__PropertyOffset_CameraOffsetBinding, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008AF7 RID: 35575
		// (get) Token: 0x0602419A RID: 147866 RVA: 0x00356C38 File Offset: 0x00354E38
		// (set) Token: 0x0602419B RID: 147867 RVA: 0x00356C71 File Offset: 0x00354E71
		public FNiagaraVariableAttributeBinding UVScaleBinding
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraVariableAttributeBinding result;
				if ((result = this._UVScaleBinding) == null)
				{
					result = (this._UVScaleBinding = new FNiagaraVariableAttributeBinding(base.NativePtr + (IntPtr)UNiagaraSpriteRendererProperties.__PropertyOffset_UVScaleBinding, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraVariableAttributeBinding.StaticStruct(), base.NativePtr + (IntPtr)UNiagaraSpriteRendererProperties.__PropertyOffset_UVScaleBinding, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008AF8 RID: 35576
		// (get) Token: 0x0602419C RID: 147868 RVA: 0x00356C94 File Offset: 0x00354E94
		// (set) Token: 0x0602419D RID: 147869 RVA: 0x00356CCD File Offset: 0x00354ECD
		public FNiagaraVariableAttributeBinding MaterialRandomBinding
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraVariableAttributeBinding result;
				if ((result = this._MaterialRandomBinding) == null)
				{
					result = (this._MaterialRandomBinding = new FNiagaraVariableAttributeBinding(base.NativePtr + (IntPtr)UNiagaraSpriteRendererProperties.__PropertyOffset_MaterialRandomBinding, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraVariableAttributeBinding.StaticStruct(), base.NativePtr + (IntPtr)UNiagaraSpriteRendererProperties.__PropertyOffset_MaterialRandomBinding, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008AF9 RID: 35577
		// (get) Token: 0x0602419E RID: 147870 RVA: 0x00356CF0 File Offset: 0x00354EF0
		// (set) Token: 0x0602419F RID: 147871 RVA: 0x00356D29 File Offset: 0x00354F29
		public FNiagaraVariableAttributeBinding CustomSortingBinding
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraVariableAttributeBinding result;
				if ((result = this._CustomSortingBinding) == null)
				{
					result = (this._CustomSortingBinding = new FNiagaraVariableAttributeBinding(base.NativePtr + (IntPtr)UNiagaraSpriteRendererProperties.__PropertyOffset_CustomSortingBinding, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraVariableAttributeBinding.StaticStruct(), base.NativePtr + (IntPtr)UNiagaraSpriteRendererProperties.__PropertyOffset_CustomSortingBinding, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008AFA RID: 35578
		// (get) Token: 0x060241A0 RID: 147872 RVA: 0x00356D4C File Offset: 0x00354F4C
		// (set) Token: 0x060241A1 RID: 147873 RVA: 0x00356D85 File Offset: 0x00354F85
		public FNiagaraVariableAttributeBinding NormalizedAgeBinding
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraVariableAttributeBinding result;
				if ((result = this._NormalizedAgeBinding) == null)
				{
					result = (this._NormalizedAgeBinding = new FNiagaraVariableAttributeBinding(base.NativePtr + (IntPtr)UNiagaraSpriteRendererProperties.__PropertyOffset_NormalizedAgeBinding, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraVariableAttributeBinding.StaticStruct(), base.NativePtr + (IntPtr)UNiagaraSpriteRendererProperties.__PropertyOffset_NormalizedAgeBinding, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008AFB RID: 35579
		// (get) Token: 0x060241A2 RID: 147874 RVA: 0x00356DA8 File Offset: 0x00354FA8
		// (set) Token: 0x060241A3 RID: 147875 RVA: 0x00356DE1 File Offset: 0x00354FE1
		public FNiagaraVariableAttributeBinding RendererVisibilityTagBinding
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraVariableAttributeBinding result;
				if ((result = this._RendererVisibilityTagBinding) == null)
				{
					result = (this._RendererVisibilityTagBinding = new FNiagaraVariableAttributeBinding(base.NativePtr + (IntPtr)UNiagaraSpriteRendererProperties.__PropertyOffset_RendererVisibilityTagBinding, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraVariableAttributeBinding.StaticStruct(), base.NativePtr + (IntPtr)UNiagaraSpriteRendererProperties.__PropertyOffset_RendererVisibilityTagBinding, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008AFC RID: 35580
		// (get) Token: 0x060241A4 RID: 147876 RVA: 0x00356E04 File Offset: 0x00355004
		// (set) Token: 0x060241A5 RID: 147877 RVA: 0x00356E3D File Offset: 0x0035503D
		public TArray<FNiagaraMaterialAttributeBinding> MaterialParameterBindings
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FNiagaraMaterialAttributeBinding> result;
				if ((result = this._MaterialParameterBindings) == null)
				{
					result = (this._MaterialParameterBindings = new TArray<FNiagaraMaterialAttributeBinding>(base.NativePtr + (IntPtr)UNiagaraSpriteRendererProperties.__PropertyOffset_MaterialParameterBindings, this));
				}
				return result;
			}
			set
			{
				this.MaterialParameterBindings.CopyAssign(value);
			}
		}

		// Token: 0x060241A6 RID: 147878 RVA: 0x00356E4B File Offset: 0x0035504B
		static UNiagaraSpriteRendererProperties()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Niagara.NiagaraSpriteRendererProperties");
		}

		// Token: 0x060241A7 RID: 147879 RVA: 0x00356E59 File Offset: 0x00355059
		protected UNiagaraSpriteRendererProperties(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040135A1 RID: 79265
		public new const string __ObjectPath = "/Script/Niagara.NiagaraSpriteRendererProperties";

		// Token: 0x040135A2 RID: 79266
		private static IntPtr _ClassPtr;

		// Token: 0x040135A3 RID: 79267
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040135A4 RID: 79268
		internal static int __PropertyOffset_Material;

		// Token: 0x040135A5 RID: 79269
		internal static int __PropertyOffset_SourceMode;

		// Token: 0x040135A6 RID: 79270
		internal static int __PropertyOffset_MaterialUserParamBinding;

		// Token: 0x040135A7 RID: 79271
		[Nullable(2)]
		private FNiagaraUserParameterBinding _MaterialUserParamBinding;

		// Token: 0x040135A8 RID: 79272
		internal static int __PropertyOffset_Alignment;

		// Token: 0x040135A9 RID: 79273
		internal static int __PropertyOffset_FacingMode;

		// Token: 0x040135AA RID: 79274
		internal static int __PropertyOffset_PivotInUVSpace;

		// Token: 0x040135AB RID: 79275
		internal static int __PropertyOffset_bUseScreenEffectMode;

		// Token: 0x040135AC RID: 79276
		internal static byte __PropertyMask_bUseScreenEffectMode;

		// Token: 0x040135AD RID: 79277
		internal static int __PropertyOffset_SpriteEffectDepth;

		// Token: 0x040135AE RID: 79278
		internal static int __PropertyOffset_SpriteEffectOffset;

		// Token: 0x040135AF RID: 79279
		internal static int __PropertyOffset_SpriteSortID;

		// Token: 0x040135B0 RID: 79280
		internal static int __PropertyOffset_bUseFixedBoundsForScreenEffect;

		// Token: 0x040135B1 RID: 79281
		internal static byte __PropertyMask_bUseFixedBoundsForScreenEffect;

		// Token: 0x040135B2 RID: 79282
		internal static int __PropertyOffset_SortMode;

		// Token: 0x040135B3 RID: 79283
		internal static int __PropertyOffset_SubImageSize;

		// Token: 0x040135B4 RID: 79284
		internal static int __PropertyOffset_bSubImageBlend;

		// Token: 0x040135B5 RID: 79285
		internal static byte __PropertyMask_bSubImageBlend;

		// Token: 0x040135B6 RID: 79286
		internal static int __PropertyOffset_bRemoveHMDRollInVR;

		// Token: 0x040135B7 RID: 79287
		internal static byte __PropertyMask_bRemoveHMDRollInVR;

		// Token: 0x040135B8 RID: 79288
		internal static int __PropertyOffset_bSortOnlyWhenTranslucent;

		// Token: 0x040135B9 RID: 79289
		internal static byte __PropertyMask_bSortOnlyWhenTranslucent;

		// Token: 0x040135BA RID: 79290
		internal static int __PropertyOffset_bGpuLowLatencyTranslucency;

		// Token: 0x040135BB RID: 79291
		internal static byte __PropertyMask_bGpuLowLatencyTranslucency;

		// Token: 0x040135BC RID: 79292
		internal static int __PropertyOffset_MinFacingCameraBlendDistance;

		// Token: 0x040135BD RID: 79293
		internal static int __PropertyOffset_MaxFacingCameraBlendDistance;

		// Token: 0x040135BE RID: 79294
		internal static int __PropertyOffset_bEnableCameraDistanceCulling;

		// Token: 0x040135BF RID: 79295
		internal static byte __PropertyMask_bEnableCameraDistanceCulling;

		// Token: 0x040135C0 RID: 79296
		internal static int __PropertyOffset_MinCameraDistance;

		// Token: 0x040135C1 RID: 79297
		internal static int __PropertyOffset_MaxCameraDistance;

		// Token: 0x040135C2 RID: 79298
		internal static int __PropertyOffset_RendererVisibility;

		// Token: 0x040135C3 RID: 79299
		internal static int __PropertyOffset_PositionBinding;

		// Token: 0x040135C4 RID: 79300
		[Nullable(2)]
		private FNiagaraVariableAttributeBinding _PositionBinding;

		// Token: 0x040135C5 RID: 79301
		internal static int __PropertyOffset_ColorBinding;

		// Token: 0x040135C6 RID: 79302
		[Nullable(2)]
		private FNiagaraVariableAttributeBinding _ColorBinding;

		// Token: 0x040135C7 RID: 79303
		internal static int __PropertyOffset_VelocityBinding;

		// Token: 0x040135C8 RID: 79304
		[Nullable(2)]
		private FNiagaraVariableAttributeBinding _VelocityBinding;

		// Token: 0x040135C9 RID: 79305
		internal static int __PropertyOffset_SpriteRotationBinding;

		// Token: 0x040135CA RID: 79306
		[Nullable(2)]
		private FNiagaraVariableAttributeBinding _SpriteRotationBinding;

		// Token: 0x040135CB RID: 79307
		internal static int __PropertyOffset_SpriteSizeBinding;

		// Token: 0x040135CC RID: 79308
		[Nullable(2)]
		private FNiagaraVariableAttributeBinding _SpriteSizeBinding;

		// Token: 0x040135CD RID: 79309
		internal static int __PropertyOffset_SpriteFacingBinding;

		// Token: 0x040135CE RID: 79310
		[Nullable(2)]
		private FNiagaraVariableAttributeBinding _SpriteFacingBinding;

		// Token: 0x040135CF RID: 79311
		internal static int __PropertyOffset_SpriteAlignmentBinding;

		// Token: 0x040135D0 RID: 79312
		[Nullable(2)]
		private FNiagaraVariableAttributeBinding _SpriteAlignmentBinding;

		// Token: 0x040135D1 RID: 79313
		internal static int __PropertyOffset_SubImageIndexBinding;

		// Token: 0x040135D2 RID: 79314
		[Nullable(2)]
		private FNiagaraVariableAttributeBinding _SubImageIndexBinding;

		// Token: 0x040135D3 RID: 79315
		internal static int __PropertyOffset_DynamicMaterialBinding;

		// Token: 0x040135D4 RID: 79316
		[Nullable(2)]
		private FNiagaraVariableAttributeBinding _DynamicMaterialBinding;

		// Token: 0x040135D5 RID: 79317
		internal static int __PropertyOffset_DynamicMaterial1Binding;

		// Token: 0x040135D6 RID: 79318
		[Nullable(2)]
		private FNiagaraVariableAttributeBinding _DynamicMaterial1Binding;

		// Token: 0x040135D7 RID: 79319
		internal static int __PropertyOffset_DynamicMaterial2Binding;

		// Token: 0x040135D8 RID: 79320
		[Nullable(2)]
		private FNiagaraVariableAttributeBinding _DynamicMaterial2Binding;

		// Token: 0x040135D9 RID: 79321
		internal static int __PropertyOffset_DynamicMaterial3Binding;

		// Token: 0x040135DA RID: 79322
		[Nullable(2)]
		private FNiagaraVariableAttributeBinding _DynamicMaterial3Binding;

		// Token: 0x040135DB RID: 79323
		internal static int __PropertyOffset_CameraOffsetBinding;

		// Token: 0x040135DC RID: 79324
		[Nullable(2)]
		private FNiagaraVariableAttributeBinding _CameraOffsetBinding;

		// Token: 0x040135DD RID: 79325
		internal static int __PropertyOffset_UVScaleBinding;

		// Token: 0x040135DE RID: 79326
		[Nullable(2)]
		private FNiagaraVariableAttributeBinding _UVScaleBinding;

		// Token: 0x040135DF RID: 79327
		internal static int __PropertyOffset_MaterialRandomBinding;

		// Token: 0x040135E0 RID: 79328
		[Nullable(2)]
		private FNiagaraVariableAttributeBinding _MaterialRandomBinding;

		// Token: 0x040135E1 RID: 79329
		internal static int __PropertyOffset_CustomSortingBinding;

		// Token: 0x040135E2 RID: 79330
		[Nullable(2)]
		private FNiagaraVariableAttributeBinding _CustomSortingBinding;

		// Token: 0x040135E3 RID: 79331
		internal static int __PropertyOffset_NormalizedAgeBinding;

		// Token: 0x040135E4 RID: 79332
		[Nullable(2)]
		private FNiagaraVariableAttributeBinding _NormalizedAgeBinding;

		// Token: 0x040135E5 RID: 79333
		internal static int __PropertyOffset_RendererVisibilityTagBinding;

		// Token: 0x040135E6 RID: 79334
		[Nullable(2)]
		private FNiagaraVariableAttributeBinding _RendererVisibilityTagBinding;

		// Token: 0x040135E7 RID: 79335
		internal static int __PropertyOffset_MaterialParameterBindings;

		// Token: 0x040135E8 RID: 79336
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FNiagaraMaterialAttributeBinding> _MaterialParameterBindings;
	}
}
