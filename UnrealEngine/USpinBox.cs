using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020029DF RID: 10719
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/UMG.SpinBox")]
	[UnrealStructLayout(1872, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1872)]
	public class USpinBox : UWidget, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06027ACB RID: 162507 RVA: 0x003C7FA9 File Offset: 0x003C61A9
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USpinBox._ClassPtr;
		}

		// Token: 0x06027ACC RID: 162508 RVA: 0x003C7FB8 File Offset: 0x003C61B8
		public USpinBox() : this(BuiltinUtils.AllocNativeUObject(USpinBox.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06027ACD RID: 162509 RVA: 0x003C7FE0 File Offset: 0x003C61E0
		public USpinBox(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USpinBox.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17009800 RID: 38912
		// (get) Token: 0x06027ACE RID: 162510 RVA: 0x003C8013 File Offset: 0x003C6213
		// (set) Token: 0x06027ACF RID: 162511 RVA: 0x003C8023 File Offset: 0x003C6223
		public unsafe float Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USpinBox.__PropertyOffset_Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USpinBox.__PropertyOffset_Value) = value;
			}
		}

		// Token: 0x17009801 RID: 38913
		// (get) Token: 0x06027AD0 RID: 162512 RVA: 0x003C8034 File Offset: 0x003C6234
		// (set) Token: 0x06027AD1 RID: 162513 RVA: 0x003C806D File Offset: 0x003C626D
		public FGetFloat ValueDelegate
		{
			get
			{
				base.FastCheckIsValid();
				FGetFloat result;
				if ((result = this._ValueDelegate) == null)
				{
					result = (this._ValueDelegate = new FGetFloat(base.NativePtr + (IntPtr)USpinBox.__PropertyOffset_ValueDelegate, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)USpinBox.__PropertyOffset_ValueDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17009802 RID: 38914
		// (get) Token: 0x06027AD2 RID: 162514 RVA: 0x003C8090 File Offset: 0x003C6290
		// (set) Token: 0x06027AD3 RID: 162515 RVA: 0x003C80C9 File Offset: 0x003C62C9
		public FSpinBoxStyle WidgetStyle
		{
			get
			{
				base.FastCheckIsValid();
				FSpinBoxStyle result;
				if ((result = this._WidgetStyle) == null)
				{
					result = (this._WidgetStyle = new FSpinBoxStyle(base.NativePtr + (IntPtr)USpinBox.__PropertyOffset_WidgetStyle, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSpinBoxStyle.StaticStruct(), base.NativePtr + (IntPtr)USpinBox.__PropertyOffset_WidgetStyle, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17009803 RID: 38915
		// (get) Token: 0x06027AD4 RID: 162516 RVA: 0x003C80EA File Offset: 0x003C62EA
		// (set) Token: 0x06027AD5 RID: 162517 RVA: 0x003C80FE File Offset: 0x003C62FE
		[Nullable(2)]
		public unsafe USlateWidgetStyleAsset Style_DEPRECATED
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USlateWidgetStyleAsset>(base.NativePtr / (IntPtr)sizeof(void*) + USpinBox.__PropertyOffset_Style_DEPRECATED);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + USpinBox.__PropertyOffset_Style_DEPRECATED, value);
			}
		}

		// Token: 0x17009804 RID: 38916
		// (get) Token: 0x06027AD6 RID: 162518 RVA: 0x003C8113 File Offset: 0x003C6313
		// (set) Token: 0x06027AD7 RID: 162519 RVA: 0x003C8123 File Offset: 0x003C6323
		public unsafe int MinFractionalDigits
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USpinBox.__PropertyOffset_MinFractionalDigits);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USpinBox.__PropertyOffset_MinFractionalDigits) = value;
			}
		}

		// Token: 0x17009805 RID: 38917
		// (get) Token: 0x06027AD8 RID: 162520 RVA: 0x003C8134 File Offset: 0x003C6334
		// (set) Token: 0x06027AD9 RID: 162521 RVA: 0x003C8144 File Offset: 0x003C6344
		public unsafe int MaxFractionalDigits
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USpinBox.__PropertyOffset_MaxFractionalDigits);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USpinBox.__PropertyOffset_MaxFractionalDigits) = value;
			}
		}

		// Token: 0x17009806 RID: 38918
		// (get) Token: 0x06027ADA RID: 162522 RVA: 0x003C8155 File Offset: 0x003C6355
		// (set) Token: 0x06027ADB RID: 162523 RVA: 0x003C8165 File Offset: 0x003C6365
		public unsafe bool bAlwaysUsesDeltaSnap
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USpinBox.__PropertyOffset_bAlwaysUsesDeltaSnap) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)USpinBox.__PropertyOffset_bAlwaysUsesDeltaSnap) = (value ? 1 : 0);
			}
		}

		// Token: 0x17009807 RID: 38919
		// (get) Token: 0x06027ADC RID: 162524 RVA: 0x003C8176 File Offset: 0x003C6376
		// (set) Token: 0x06027ADD RID: 162525 RVA: 0x003C8186 File Offset: 0x003C6386
		public unsafe float Delta
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USpinBox.__PropertyOffset_Delta);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USpinBox.__PropertyOffset_Delta) = value;
			}
		}

		// Token: 0x17009808 RID: 38920
		// (get) Token: 0x06027ADE RID: 162526 RVA: 0x003C8197 File Offset: 0x003C6397
		// (set) Token: 0x06027ADF RID: 162527 RVA: 0x003C81A7 File Offset: 0x003C63A7
		public unsafe float SliderExponent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USpinBox.__PropertyOffset_SliderExponent);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USpinBox.__PropertyOffset_SliderExponent) = value;
			}
		}

		// Token: 0x17009809 RID: 38921
		// (get) Token: 0x06027AE0 RID: 162528 RVA: 0x003C81B8 File Offset: 0x003C63B8
		// (set) Token: 0x06027AE1 RID: 162529 RVA: 0x003C81F1 File Offset: 0x003C63F1
		public FSlateFontInfo Font
		{
			get
			{
				base.FastCheckIsValid();
				FSlateFontInfo result;
				if ((result = this._Font) == null)
				{
					result = (this._Font = new FSlateFontInfo(base.NativePtr + (IntPtr)USpinBox.__PropertyOffset_Font, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateFontInfo.StaticStruct(), base.NativePtr + (IntPtr)USpinBox.__PropertyOffset_Font, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700980A RID: 38922
		// (get) Token: 0x06027AE2 RID: 162530 RVA: 0x003C8212 File Offset: 0x003C6412
		// (set) Token: 0x06027AE3 RID: 162531 RVA: 0x003C8226 File Offset: 0x003C6426
		[Nullable(0)]
		public unsafe TEnumAsByte<ETextJustify> Justification
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)USpinBox.__PropertyOffset_Justification);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)USpinBox.__PropertyOffset_Justification) = value;
			}
		}

		// Token: 0x1700980B RID: 38923
		// (get) Token: 0x06027AE4 RID: 162532 RVA: 0x003C823B File Offset: 0x003C643B
		// (set) Token: 0x06027AE5 RID: 162533 RVA: 0x003C824B File Offset: 0x003C644B
		public unsafe float MinDesiredWidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USpinBox.__PropertyOffset_MinDesiredWidth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USpinBox.__PropertyOffset_MinDesiredWidth) = value;
			}
		}

		// Token: 0x1700980C RID: 38924
		// (get) Token: 0x06027AE6 RID: 162534 RVA: 0x003C825C File Offset: 0x003C645C
		// (set) Token: 0x06027AE7 RID: 162535 RVA: 0x003C826C File Offset: 0x003C646C
		public unsafe bool ClearKeyboardFocusOnCommit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USpinBox.__PropertyOffset_ClearKeyboardFocusOnCommit) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)USpinBox.__PropertyOffset_ClearKeyboardFocusOnCommit) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700980D RID: 38925
		// (get) Token: 0x06027AE8 RID: 162536 RVA: 0x003C827D File Offset: 0x003C647D
		// (set) Token: 0x06027AE9 RID: 162537 RVA: 0x003C828D File Offset: 0x003C648D
		public unsafe bool SelectAllTextOnCommit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USpinBox.__PropertyOffset_SelectAllTextOnCommit) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)USpinBox.__PropertyOffset_SelectAllTextOnCommit) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700980E RID: 38926
		// (get) Token: 0x06027AEA RID: 162538 RVA: 0x003C82A0 File Offset: 0x003C64A0
		// (set) Token: 0x06027AEB RID: 162539 RVA: 0x003C82D9 File Offset: 0x003C64D9
		public FSlateColor ForegroundColor
		{
			get
			{
				base.FastCheckIsValid();
				FSlateColor result;
				if ((result = this._ForegroundColor) == null)
				{
					result = (this._ForegroundColor = new FSlateColor(base.NativePtr + (IntPtr)USpinBox.__PropertyOffset_ForegroundColor, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateColor.StaticStruct(), base.NativePtr + (IntPtr)USpinBox.__PropertyOffset_ForegroundColor, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700980F RID: 38927
		// (get) Token: 0x06027AEC RID: 162540 RVA: 0x003C82FC File Offset: 0x003C64FC
		// (set) Token: 0x06027AED RID: 162541 RVA: 0x003C8335 File Offset: 0x003C6535
		public FOnSpinBoxValueChangedEvent OnValueChanged
		{
			get
			{
				base.FastCheckIsValid();
				FOnSpinBoxValueChangedEvent result;
				if ((result = this._OnValueChanged) == null)
				{
					result = (this._OnValueChanged = new FOnSpinBoxValueChangedEvent(base.NativePtr + (IntPtr)USpinBox.__PropertyOffset_OnValueChanged, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)USpinBox.__PropertyOffset_OnValueChanged, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17009810 RID: 38928
		// (get) Token: 0x06027AEE RID: 162542 RVA: 0x003C8358 File Offset: 0x003C6558
		// (set) Token: 0x06027AEF RID: 162543 RVA: 0x003C8391 File Offset: 0x003C6591
		public FOnSpinBoxValueCommittedEvent OnValueCommitted
		{
			get
			{
				base.FastCheckIsValid();
				FOnSpinBoxValueCommittedEvent result;
				if ((result = this._OnValueCommitted) == null)
				{
					result = (this._OnValueCommitted = new FOnSpinBoxValueCommittedEvent(base.NativePtr + (IntPtr)USpinBox.__PropertyOffset_OnValueCommitted, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)USpinBox.__PropertyOffset_OnValueCommitted, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17009811 RID: 38929
		// (get) Token: 0x06027AF0 RID: 162544 RVA: 0x003C83B4 File Offset: 0x003C65B4
		// (set) Token: 0x06027AF1 RID: 162545 RVA: 0x003C83ED File Offset: 0x003C65ED
		public FOnSpinBoxBeginSliderMovement OnBeginSliderMovement
		{
			get
			{
				base.FastCheckIsValid();
				FOnSpinBoxBeginSliderMovement result;
				if ((result = this._OnBeginSliderMovement) == null)
				{
					result = (this._OnBeginSliderMovement = new FOnSpinBoxBeginSliderMovement(base.NativePtr + (IntPtr)USpinBox.__PropertyOffset_OnBeginSliderMovement, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)USpinBox.__PropertyOffset_OnBeginSliderMovement, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17009812 RID: 38930
		// (get) Token: 0x06027AF2 RID: 162546 RVA: 0x003C8410 File Offset: 0x003C6610
		// (set) Token: 0x06027AF3 RID: 162547 RVA: 0x003C8449 File Offset: 0x003C6649
		public FOnSpinBoxValueChangedEvent OnEndSliderMovement
		{
			get
			{
				base.FastCheckIsValid();
				FOnSpinBoxValueChangedEvent result;
				if ((result = this._OnEndSliderMovement) == null)
				{
					result = (this._OnEndSliderMovement = new FOnSpinBoxValueChangedEvent(base.NativePtr + (IntPtr)USpinBox.__PropertyOffset_OnEndSliderMovement, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)USpinBox.__PropertyOffset_OnEndSliderMovement, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17009813 RID: 38931
		// (get) Token: 0x06027AF4 RID: 162548 RVA: 0x003C846A File Offset: 0x003C666A
		// (set) Token: 0x06027AF5 RID: 162549 RVA: 0x003C8483 File Offset: 0x003C6683
		public unsafe bool bOverride_MinValue
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USpinBox.__PropertyOffset_bOverride_MinValue) & USpinBox.__PropertyMask_bOverride_MinValue) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USpinBox.__PropertyOffset_bOverride_MinValue) = ((*(base.NativePtr + (IntPtr)USpinBox.__PropertyOffset_bOverride_MinValue) & ~USpinBox.__PropertyMask_bOverride_MinValue) | (value ? USpinBox.__PropertyMask_bOverride_MinValue : 0));
			}
		}

		// Token: 0x17009814 RID: 38932
		// (get) Token: 0x06027AF6 RID: 162550 RVA: 0x003C84B3 File Offset: 0x003C66B3
		// (set) Token: 0x06027AF7 RID: 162551 RVA: 0x003C84CC File Offset: 0x003C66CC
		public unsafe bool bOverride_MaxValue
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USpinBox.__PropertyOffset_bOverride_MaxValue) & USpinBox.__PropertyMask_bOverride_MaxValue) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USpinBox.__PropertyOffset_bOverride_MaxValue) = ((*(base.NativePtr + (IntPtr)USpinBox.__PropertyOffset_bOverride_MaxValue) & ~USpinBox.__PropertyMask_bOverride_MaxValue) | (value ? USpinBox.__PropertyMask_bOverride_MaxValue : 0));
			}
		}

		// Token: 0x17009815 RID: 38933
		// (get) Token: 0x06027AF8 RID: 162552 RVA: 0x003C84FC File Offset: 0x003C66FC
		// (set) Token: 0x06027AF9 RID: 162553 RVA: 0x003C8515 File Offset: 0x003C6715
		public unsafe bool bOverride_MinSliderValue
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USpinBox.__PropertyOffset_bOverride_MinSliderValue) & USpinBox.__PropertyMask_bOverride_MinSliderValue) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USpinBox.__PropertyOffset_bOverride_MinSliderValue) = ((*(base.NativePtr + (IntPtr)USpinBox.__PropertyOffset_bOverride_MinSliderValue) & ~USpinBox.__PropertyMask_bOverride_MinSliderValue) | (value ? USpinBox.__PropertyMask_bOverride_MinSliderValue : 0));
			}
		}

		// Token: 0x17009816 RID: 38934
		// (get) Token: 0x06027AFA RID: 162554 RVA: 0x003C8545 File Offset: 0x003C6745
		// (set) Token: 0x06027AFB RID: 162555 RVA: 0x003C855E File Offset: 0x003C675E
		public unsafe bool bOverride_MaxSliderValue
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USpinBox.__PropertyOffset_bOverride_MaxSliderValue) & USpinBox.__PropertyMask_bOverride_MaxSliderValue) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USpinBox.__PropertyOffset_bOverride_MaxSliderValue) = ((*(base.NativePtr + (IntPtr)USpinBox.__PropertyOffset_bOverride_MaxSliderValue) & ~USpinBox.__PropertyMask_bOverride_MaxSliderValue) | (value ? USpinBox.__PropertyMask_bOverride_MaxSliderValue : 0));
			}
		}

		// Token: 0x17009817 RID: 38935
		// (get) Token: 0x06027AFC RID: 162556 RVA: 0x003C858E File Offset: 0x003C678E
		// (set) Token: 0x06027AFD RID: 162557 RVA: 0x003C859E File Offset: 0x003C679E
		public unsafe float MinValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USpinBox.__PropertyOffset_MinValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USpinBox.__PropertyOffset_MinValue) = value;
			}
		}

		// Token: 0x17009818 RID: 38936
		// (get) Token: 0x06027AFE RID: 162558 RVA: 0x003C85AF File Offset: 0x003C67AF
		// (set) Token: 0x06027AFF RID: 162559 RVA: 0x003C85BF File Offset: 0x003C67BF
		public unsafe float MaxValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USpinBox.__PropertyOffset_MaxValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USpinBox.__PropertyOffset_MaxValue) = value;
			}
		}

		// Token: 0x17009819 RID: 38937
		// (get) Token: 0x06027B00 RID: 162560 RVA: 0x003C85D0 File Offset: 0x003C67D0
		// (set) Token: 0x06027B01 RID: 162561 RVA: 0x003C85E0 File Offset: 0x003C67E0
		public unsafe float MinSliderValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USpinBox.__PropertyOffset_MinSliderValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USpinBox.__PropertyOffset_MinSliderValue) = value;
			}
		}

		// Token: 0x1700981A RID: 38938
		// (get) Token: 0x06027B02 RID: 162562 RVA: 0x003C85F1 File Offset: 0x003C67F1
		// (set) Token: 0x06027B03 RID: 162563 RVA: 0x003C8601 File Offset: 0x003C6801
		public unsafe float MaxSliderValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USpinBox.__PropertyOffset_MaxSliderValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USpinBox.__PropertyOffset_MaxSliderValue) = value;
			}
		}

		// Token: 0x06027B04 RID: 162564 RVA: 0x003C8612 File Offset: 0x003C6812
		public void SetValue(float NewValue)
		{
			USpinBox.__SetValue_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x06027B05 RID: 162565 RVA: 0x003C8620 File Offset: 0x003C6820
		public void SetMinValue(float NewValue)
		{
			USpinBox.__SetMinValue_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x06027B06 RID: 162566 RVA: 0x003C862E File Offset: 0x003C682E
		public void SetMinSliderValue(float NewValue)
		{
			USpinBox.__SetMinSliderValue_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x06027B07 RID: 162567 RVA: 0x003C863C File Offset: 0x003C683C
		public void SetMinFractionalDigits(int NewValue)
		{
			USpinBox.__SetMinFractionalDigits_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x06027B08 RID: 162568 RVA: 0x003C864A File Offset: 0x003C684A
		public void SetMaxValue(float NewValue)
		{
			USpinBox.__SetMaxValue_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x06027B09 RID: 162569 RVA: 0x003C8658 File Offset: 0x003C6858
		public void SetMaxSliderValue(float NewValue)
		{
			USpinBox.__SetMaxSliderValue_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x06027B0A RID: 162570 RVA: 0x003C8666 File Offset: 0x003C6866
		public void SetMaxFractionalDigits(int NewValue)
		{
			USpinBox.__SetMaxFractionalDigits_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x06027B0B RID: 162571 RVA: 0x003C8674 File Offset: 0x003C6874
		[NullableContext(2)]
		public void SetForegroundColor(FSlateColor InForegroundColor)
		{
			USpinBox.__SetForegroundColor_Internal(base.NativePtr, (InForegroundColor ?? new FSlateColor()).NativePtr);
		}

		// Token: 0x06027B0C RID: 162572 RVA: 0x003C8690 File Offset: 0x003C6890
		public void SetDelta(float NewValue)
		{
			USpinBox.__SetDelta_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x06027B0D RID: 162573 RVA: 0x003C869E File Offset: 0x003C689E
		public void SetAlwaysUsesDeltaSnap(bool bNewValue)
		{
			USpinBox.__SetAlwaysUsesDeltaSnap_Internal(base.NativePtr, bNewValue);
		}

		// Token: 0x06027B0E RID: 162574 RVA: 0x003C86AC File Offset: 0x003C68AC
		public float GetValue()
		{
			return USpinBox.__GetValue_Internal(base.NativePtr);
		}

		// Token: 0x06027B0F RID: 162575 RVA: 0x003C86B9 File Offset: 0x003C68B9
		public float GetMinValue()
		{
			return USpinBox.__GetMinValue_Internal(base.NativePtr);
		}

		// Token: 0x06027B10 RID: 162576 RVA: 0x003C86C6 File Offset: 0x003C68C6
		public float GetMinSliderValue()
		{
			return USpinBox.__GetMinSliderValue_Internal(base.NativePtr);
		}

		// Token: 0x06027B11 RID: 162577 RVA: 0x003C86D3 File Offset: 0x003C68D3
		public int GetMinFractionalDigits()
		{
			return USpinBox.__GetMinFractionalDigits_Internal(base.NativePtr);
		}

		// Token: 0x06027B12 RID: 162578 RVA: 0x003C86E0 File Offset: 0x003C68E0
		public float GetMaxValue()
		{
			return USpinBox.__GetMaxValue_Internal(base.NativePtr);
		}

		// Token: 0x06027B13 RID: 162579 RVA: 0x003C86ED File Offset: 0x003C68ED
		public float GetMaxSliderValue()
		{
			return USpinBox.__GetMaxSliderValue_Internal(base.NativePtr);
		}

		// Token: 0x06027B14 RID: 162580 RVA: 0x003C86FA File Offset: 0x003C68FA
		public int GetMaxFractionalDigits()
		{
			return USpinBox.__GetMaxFractionalDigits_Internal(base.NativePtr);
		}

		// Token: 0x06027B15 RID: 162581 RVA: 0x003C8707 File Offset: 0x003C6907
		public float GetDelta()
		{
			return USpinBox.__GetDelta_Internal(base.NativePtr);
		}

		// Token: 0x06027B16 RID: 162582 RVA: 0x003C8714 File Offset: 0x003C6914
		public bool GetAlwaysUsesDeltaSnap()
		{
			return USpinBox.__GetAlwaysUsesDeltaSnap_Internal(base.NativePtr);
		}

		// Token: 0x06027B17 RID: 162583 RVA: 0x003C8721 File Offset: 0x003C6921
		public void ClearMinValue()
		{
			USpinBox.__ClearMinValue_Internal(base.NativePtr);
		}

		// Token: 0x06027B18 RID: 162584 RVA: 0x003C872E File Offset: 0x003C692E
		public void ClearMinSliderValue()
		{
			USpinBox.__ClearMinSliderValue_Internal(base.NativePtr);
		}

		// Token: 0x06027B19 RID: 162585 RVA: 0x003C873B File Offset: 0x003C693B
		public void ClearMaxValue()
		{
			USpinBox.__ClearMaxValue_Internal(base.NativePtr);
		}

		// Token: 0x06027B1A RID: 162586 RVA: 0x003C8748 File Offset: 0x003C6948
		public void ClearMaxSliderValue()
		{
			USpinBox.__ClearMaxSliderValue_Internal(base.NativePtr);
		}

		// Token: 0x06027B1B RID: 162587
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetValue_Internal(IntPtr @this, float NewValue);

		// Token: 0x06027B1C RID: 162588
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMinValue_Internal(IntPtr @this, float NewValue);

		// Token: 0x06027B1D RID: 162589
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMinSliderValue_Internal(IntPtr @this, float NewValue);

		// Token: 0x06027B1E RID: 162590
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMinFractionalDigits_Internal(IntPtr @this, int NewValue);

		// Token: 0x06027B1F RID: 162591
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMaxValue_Internal(IntPtr @this, float NewValue);

		// Token: 0x06027B20 RID: 162592
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMaxSliderValue_Internal(IntPtr @this, float NewValue);

		// Token: 0x06027B21 RID: 162593
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMaxFractionalDigits_Internal(IntPtr @this, int NewValue);

		// Token: 0x06027B22 RID: 162594
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetForegroundColor_Internal(IntPtr @this, IntPtr InForegroundColor);

		// Token: 0x06027B23 RID: 162595
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDelta_Internal(IntPtr @this, float NewValue);

		// Token: 0x06027B24 RID: 162596
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAlwaysUsesDeltaSnap_Internal(IntPtr @this, bool bNewValue);

		// Token: 0x06027B25 RID: 162597
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetValue_Internal(IntPtr @this);

		// Token: 0x06027B26 RID: 162598
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetMinValue_Internal(IntPtr @this);

		// Token: 0x06027B27 RID: 162599
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetMinSliderValue_Internal(IntPtr @this);

		// Token: 0x06027B28 RID: 162600
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetMinFractionalDigits_Internal(IntPtr @this);

		// Token: 0x06027B29 RID: 162601
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetMaxValue_Internal(IntPtr @this);

		// Token: 0x06027B2A RID: 162602
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetMaxSliderValue_Internal(IntPtr @this);

		// Token: 0x06027B2B RID: 162603
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetMaxFractionalDigits_Internal(IntPtr @this);

		// Token: 0x06027B2C RID: 162604
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetDelta_Internal(IntPtr @this);

		// Token: 0x06027B2D RID: 162605
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetAlwaysUsesDeltaSnap_Internal(IntPtr @this);

		// Token: 0x06027B2E RID: 162606
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearMinValue_Internal(IntPtr @this);

		// Token: 0x06027B2F RID: 162607
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearMinSliderValue_Internal(IntPtr @this);

		// Token: 0x06027B30 RID: 162608
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearMaxValue_Internal(IntPtr @this);

		// Token: 0x06027B31 RID: 162609
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearMaxSliderValue_Internal(IntPtr @this);

		// Token: 0x06027B32 RID: 162610 RVA: 0x003C8755 File Offset: 0x003C6955
		static USpinBox()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/UMG.SpinBox");
		}

		// Token: 0x06027B33 RID: 162611 RVA: 0x003C8763 File Offset: 0x003C6963
		protected USpinBox(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015BAC RID: 89004
		public new const string __ObjectPath = "/Script/UMG.SpinBox";

		// Token: 0x04015BAD RID: 89005
		private static IntPtr _ClassPtr;

		// Token: 0x04015BAE RID: 89006
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015BAF RID: 89007
		public static IntPtr __OnSpinBoxValueCommittedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04015BB0 RID: 89008
		public static IntPtr __OnSpinBoxValueChangedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04015BB1 RID: 89009
		public static IntPtr __OnSpinBoxBeginSliderMovement__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04015BB2 RID: 89010
		internal static int __PropertyOffset_Value;

		// Token: 0x04015BB3 RID: 89011
		internal static int __PropertyOffset_ValueDelegate;

		// Token: 0x04015BB4 RID: 89012
		[Nullable(2)]
		private FGetFloat _ValueDelegate;

		// Token: 0x04015BB5 RID: 89013
		internal static int __PropertyOffset_WidgetStyle;

		// Token: 0x04015BB6 RID: 89014
		[Nullable(2)]
		private FSpinBoxStyle _WidgetStyle;

		// Token: 0x04015BB7 RID: 89015
		internal static int __PropertyOffset_Style_DEPRECATED;

		// Token: 0x04015BB8 RID: 89016
		internal static int __PropertyOffset_MinFractionalDigits;

		// Token: 0x04015BB9 RID: 89017
		internal static int __PropertyOffset_MaxFractionalDigits;

		// Token: 0x04015BBA RID: 89018
		internal static int __PropertyOffset_bAlwaysUsesDeltaSnap;

		// Token: 0x04015BBB RID: 89019
		internal static int __PropertyOffset_Delta;

		// Token: 0x04015BBC RID: 89020
		internal static int __PropertyOffset_SliderExponent;

		// Token: 0x04015BBD RID: 89021
		internal static int __PropertyOffset_Font;

		// Token: 0x04015BBE RID: 89022
		[Nullable(2)]
		private FSlateFontInfo _Font;

		// Token: 0x04015BBF RID: 89023
		internal static int __PropertyOffset_Justification;

		// Token: 0x04015BC0 RID: 89024
		internal static int __PropertyOffset_MinDesiredWidth;

		// Token: 0x04015BC1 RID: 89025
		internal static int __PropertyOffset_ClearKeyboardFocusOnCommit;

		// Token: 0x04015BC2 RID: 89026
		internal static int __PropertyOffset_SelectAllTextOnCommit;

		// Token: 0x04015BC3 RID: 89027
		internal static int __PropertyOffset_ForegroundColor;

		// Token: 0x04015BC4 RID: 89028
		[Nullable(2)]
		private FSlateColor _ForegroundColor;

		// Token: 0x04015BC5 RID: 89029
		internal static int __PropertyOffset_OnValueChanged;

		// Token: 0x04015BC6 RID: 89030
		[Nullable(2)]
		private FOnSpinBoxValueChangedEvent _OnValueChanged;

		// Token: 0x04015BC7 RID: 89031
		internal static int __PropertyOffset_OnValueCommitted;

		// Token: 0x04015BC8 RID: 89032
		[Nullable(2)]
		private FOnSpinBoxValueCommittedEvent _OnValueCommitted;

		// Token: 0x04015BC9 RID: 89033
		internal static int __PropertyOffset_OnBeginSliderMovement;

		// Token: 0x04015BCA RID: 89034
		[Nullable(2)]
		private FOnSpinBoxBeginSliderMovement _OnBeginSliderMovement;

		// Token: 0x04015BCB RID: 89035
		internal static int __PropertyOffset_OnEndSliderMovement;

		// Token: 0x04015BCC RID: 89036
		[Nullable(2)]
		private FOnSpinBoxValueChangedEvent _OnEndSliderMovement;

		// Token: 0x04015BCD RID: 89037
		internal static int __PropertyOffset_bOverride_MinValue;

		// Token: 0x04015BCE RID: 89038
		internal static byte __PropertyMask_bOverride_MinValue;

		// Token: 0x04015BCF RID: 89039
		internal static int __PropertyOffset_bOverride_MaxValue;

		// Token: 0x04015BD0 RID: 89040
		internal static byte __PropertyMask_bOverride_MaxValue;

		// Token: 0x04015BD1 RID: 89041
		internal static int __PropertyOffset_bOverride_MinSliderValue;

		// Token: 0x04015BD2 RID: 89042
		internal static byte __PropertyMask_bOverride_MinSliderValue;

		// Token: 0x04015BD3 RID: 89043
		internal static int __PropertyOffset_bOverride_MaxSliderValue;

		// Token: 0x04015BD4 RID: 89044
		internal static byte __PropertyMask_bOverride_MaxSliderValue;

		// Token: 0x04015BD5 RID: 89045
		internal static int __PropertyOffset_MinValue;

		// Token: 0x04015BD6 RID: 89046
		internal static int __PropertyOffset_MaxValue;

		// Token: 0x04015BD7 RID: 89047
		internal static int __PropertyOffset_MinSliderValue;

		// Token: 0x04015BD8 RID: 89048
		internal static int __PropertyOffset_MaxSliderValue;
	}
}
