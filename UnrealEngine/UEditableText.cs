using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002954 RID: 10580
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/UMG.EditableText")]
	[UnrealStructLayout(1712, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1712)]
	public class UEditableText : UWidget, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060272BB RID: 160443 RVA: 0x003BB7FF File Offset: 0x003B99FF
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UEditableText._ClassPtr;
		}

		// Token: 0x060272BC RID: 160444 RVA: 0x003BB80C File Offset: 0x003B9A0C
		public UEditableText() : this(BuiltinUtils.AllocNativeUObject(UEditableText.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060272BD RID: 160445 RVA: 0x003BB834 File Offset: 0x003B9A34
		public UEditableText(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UEditableText.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170096A6 RID: 38566
		// (get) Token: 0x060272BE RID: 160446 RVA: 0x003BB868 File Offset: 0x003B9A68
		// (set) Token: 0x060272BF RID: 160447 RVA: 0x003BB8A1 File Offset: 0x003B9AA1
		public unsafe FText Text
		{
			get
			{
				base.FastCheckIsValid();
				FText result;
				if ((result = this._Text) == null)
				{
					result = (this._Text = new FText(base.NativePtr + (IntPtr)UEditableText.__PropertyOffset_Text, this));
				}
				return result;
			}
			set
			{
				FText.NativeCopy((void*)(base.NativePtr + (byte*)((IntPtr)UEditableText.__PropertyOffset_Text)), value.NativePtr, 1);
			}
		}

		// Token: 0x170096A7 RID: 38567
		// (get) Token: 0x060272C0 RID: 160448 RVA: 0x003BB8BC File Offset: 0x003B9ABC
		// (set) Token: 0x060272C1 RID: 160449 RVA: 0x003BB8F5 File Offset: 0x003B9AF5
		public FGetText TextDelegate
		{
			get
			{
				base.FastCheckIsValid();
				FGetText result;
				if ((result = this._TextDelegate) == null)
				{
					result = (this._TextDelegate = new FGetText(base.NativePtr + (IntPtr)UEditableText.__PropertyOffset_TextDelegate, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UEditableText.__PropertyOffset_TextDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170096A8 RID: 38568
		// (get) Token: 0x060272C2 RID: 160450 RVA: 0x003BB918 File Offset: 0x003B9B18
		// (set) Token: 0x060272C3 RID: 160451 RVA: 0x003BB951 File Offset: 0x003B9B51
		public unsafe FText HintText
		{
			get
			{
				base.FastCheckIsValid();
				FText result;
				if ((result = this._HintText) == null)
				{
					result = (this._HintText = new FText(base.NativePtr + (IntPtr)UEditableText.__PropertyOffset_HintText, this));
				}
				return result;
			}
			set
			{
				FText.NativeCopy((void*)(base.NativePtr + (byte*)((IntPtr)UEditableText.__PropertyOffset_HintText)), value.NativePtr, 1);
			}
		}

		// Token: 0x170096A9 RID: 38569
		// (get) Token: 0x060272C4 RID: 160452 RVA: 0x003BB96C File Offset: 0x003B9B6C
		// (set) Token: 0x060272C5 RID: 160453 RVA: 0x003BB9A5 File Offset: 0x003B9BA5
		public FGetText HintTextDelegate
		{
			get
			{
				base.FastCheckIsValid();
				FGetText result;
				if ((result = this._HintTextDelegate) == null)
				{
					result = (this._HintTextDelegate = new FGetText(base.NativePtr + (IntPtr)UEditableText.__PropertyOffset_HintTextDelegate, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UEditableText.__PropertyOffset_HintTextDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170096AA RID: 38570
		// (get) Token: 0x060272C6 RID: 160454 RVA: 0x003BB9C8 File Offset: 0x003B9BC8
		// (set) Token: 0x060272C7 RID: 160455 RVA: 0x003BBA01 File Offset: 0x003B9C01
		public FEditableTextStyle WidgetStyle
		{
			get
			{
				base.FastCheckIsValid();
				FEditableTextStyle result;
				if ((result = this._WidgetStyle) == null)
				{
					result = (this._WidgetStyle = new FEditableTextStyle(base.NativePtr + (IntPtr)UEditableText.__PropertyOffset_WidgetStyle, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FEditableTextStyle.StaticStruct(), base.NativePtr + (IntPtr)UEditableText.__PropertyOffset_WidgetStyle, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170096AB RID: 38571
		// (get) Token: 0x060272C8 RID: 160456 RVA: 0x003BBA22 File Offset: 0x003B9C22
		// (set) Token: 0x060272C9 RID: 160457 RVA: 0x003BBA36 File Offset: 0x003B9C36
		[Nullable(2)]
		public unsafe USlateWidgetStyleAsset Style_DEPRECATED
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USlateWidgetStyleAsset>(base.NativePtr / (IntPtr)sizeof(void*) + UEditableText.__PropertyOffset_Style_DEPRECATED);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UEditableText.__PropertyOffset_Style_DEPRECATED, value);
			}
		}

		// Token: 0x170096AC RID: 38572
		// (get) Token: 0x060272CA RID: 160458 RVA: 0x003BBA4B File Offset: 0x003B9C4B
		// (set) Token: 0x060272CB RID: 160459 RVA: 0x003BBA5F File Offset: 0x003B9C5F
		[Nullable(2)]
		public unsafe USlateBrushAsset BackgroundImageSelected_DEPRECATED
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USlateBrushAsset>(base.NativePtr / (IntPtr)sizeof(void*) + UEditableText.__PropertyOffset_BackgroundImageSelected_DEPRECATED);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UEditableText.__PropertyOffset_BackgroundImageSelected_DEPRECATED, value);
			}
		}

		// Token: 0x170096AD RID: 38573
		// (get) Token: 0x060272CC RID: 160460 RVA: 0x003BBA74 File Offset: 0x003B9C74
		// (set) Token: 0x060272CD RID: 160461 RVA: 0x003BBA88 File Offset: 0x003B9C88
		[Nullable(2)]
		public unsafe USlateBrushAsset BackgroundImageComposing_DEPRECATED
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USlateBrushAsset>(base.NativePtr / (IntPtr)sizeof(void*) + UEditableText.__PropertyOffset_BackgroundImageComposing_DEPRECATED);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UEditableText.__PropertyOffset_BackgroundImageComposing_DEPRECATED, value);
			}
		}

		// Token: 0x170096AE RID: 38574
		// (get) Token: 0x060272CE RID: 160462 RVA: 0x003BBA9D File Offset: 0x003B9C9D
		// (set) Token: 0x060272CF RID: 160463 RVA: 0x003BBAB1 File Offset: 0x003B9CB1
		[Nullable(2)]
		public unsafe USlateBrushAsset CaretImage_DEPRECATED
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USlateBrushAsset>(base.NativePtr / (IntPtr)sizeof(void*) + UEditableText.__PropertyOffset_CaretImage_DEPRECATED);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UEditableText.__PropertyOffset_CaretImage_DEPRECATED, value);
			}
		}

		// Token: 0x170096AF RID: 38575
		// (get) Token: 0x060272D0 RID: 160464 RVA: 0x003BBAC8 File Offset: 0x003B9CC8
		// (set) Token: 0x060272D1 RID: 160465 RVA: 0x003BBB01 File Offset: 0x003B9D01
		public FSlateFontInfo Font_DEPRECATED
		{
			get
			{
				base.FastCheckIsValid();
				FSlateFontInfo result;
				if ((result = this._Font_DEPRECATED) == null)
				{
					result = (this._Font_DEPRECATED = new FSlateFontInfo(base.NativePtr + (IntPtr)UEditableText.__PropertyOffset_Font_DEPRECATED, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateFontInfo.StaticStruct(), base.NativePtr + (IntPtr)UEditableText.__PropertyOffset_Font_DEPRECATED, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170096B0 RID: 38576
		// (get) Token: 0x060272D2 RID: 160466 RVA: 0x003BBB24 File Offset: 0x003B9D24
		// (set) Token: 0x060272D3 RID: 160467 RVA: 0x003BBB5D File Offset: 0x003B9D5D
		public FSlateColor ColorAndOpacity_DEPRECATED
		{
			get
			{
				base.FastCheckIsValid();
				FSlateColor result;
				if ((result = this._ColorAndOpacity_DEPRECATED) == null)
				{
					result = (this._ColorAndOpacity_DEPRECATED = new FSlateColor(base.NativePtr + (IntPtr)UEditableText.__PropertyOffset_ColorAndOpacity_DEPRECATED, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateColor.StaticStruct(), base.NativePtr + (IntPtr)UEditableText.__PropertyOffset_ColorAndOpacity_DEPRECATED, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170096B1 RID: 38577
		// (get) Token: 0x060272D4 RID: 160468 RVA: 0x003BBB7E File Offset: 0x003B9D7E
		// (set) Token: 0x060272D5 RID: 160469 RVA: 0x003BBB8E File Offset: 0x003B9D8E
		public unsafe bool IsReadOnly
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEditableText.__PropertyOffset_IsReadOnly) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEditableText.__PropertyOffset_IsReadOnly) = (value ? 1 : 0);
			}
		}

		// Token: 0x170096B2 RID: 38578
		// (get) Token: 0x060272D6 RID: 160470 RVA: 0x003BBB9F File Offset: 0x003B9D9F
		// (set) Token: 0x060272D7 RID: 160471 RVA: 0x003BBBAF File Offset: 0x003B9DAF
		public unsafe bool IsPassword
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEditableText.__PropertyOffset_IsPassword) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEditableText.__PropertyOffset_IsPassword) = (value ? 1 : 0);
			}
		}

		// Token: 0x170096B3 RID: 38579
		// (get) Token: 0x060272D8 RID: 160472 RVA: 0x003BBBC0 File Offset: 0x003B9DC0
		// (set) Token: 0x060272D9 RID: 160473 RVA: 0x003BBBD0 File Offset: 0x003B9DD0
		public unsafe float MinimumDesiredWidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEditableText.__PropertyOffset_MinimumDesiredWidth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEditableText.__PropertyOffset_MinimumDesiredWidth) = value;
			}
		}

		// Token: 0x170096B4 RID: 38580
		// (get) Token: 0x060272DA RID: 160474 RVA: 0x003BBBE1 File Offset: 0x003B9DE1
		// (set) Token: 0x060272DB RID: 160475 RVA: 0x003BBBF1 File Offset: 0x003B9DF1
		public unsafe bool IsCaretMovedWhenGainFocus
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEditableText.__PropertyOffset_IsCaretMovedWhenGainFocus) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEditableText.__PropertyOffset_IsCaretMovedWhenGainFocus) = (value ? 1 : 0);
			}
		}

		// Token: 0x170096B5 RID: 38581
		// (get) Token: 0x060272DC RID: 160476 RVA: 0x003BBC02 File Offset: 0x003B9E02
		// (set) Token: 0x060272DD RID: 160477 RVA: 0x003BBC12 File Offset: 0x003B9E12
		public unsafe bool SelectAllTextWhenFocused
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEditableText.__PropertyOffset_SelectAllTextWhenFocused) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEditableText.__PropertyOffset_SelectAllTextWhenFocused) = (value ? 1 : 0);
			}
		}

		// Token: 0x170096B6 RID: 38582
		// (get) Token: 0x060272DE RID: 160478 RVA: 0x003BBC23 File Offset: 0x003B9E23
		// (set) Token: 0x060272DF RID: 160479 RVA: 0x003BBC33 File Offset: 0x003B9E33
		public unsafe bool RevertTextOnEscape
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEditableText.__PropertyOffset_RevertTextOnEscape) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEditableText.__PropertyOffset_RevertTextOnEscape) = (value ? 1 : 0);
			}
		}

		// Token: 0x170096B7 RID: 38583
		// (get) Token: 0x060272E0 RID: 160480 RVA: 0x003BBC44 File Offset: 0x003B9E44
		// (set) Token: 0x060272E1 RID: 160481 RVA: 0x003BBC54 File Offset: 0x003B9E54
		public unsafe bool ClearKeyboardFocusOnCommit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEditableText.__PropertyOffset_ClearKeyboardFocusOnCommit) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEditableText.__PropertyOffset_ClearKeyboardFocusOnCommit) = (value ? 1 : 0);
			}
		}

		// Token: 0x170096B8 RID: 38584
		// (get) Token: 0x060272E2 RID: 160482 RVA: 0x003BBC65 File Offset: 0x003B9E65
		// (set) Token: 0x060272E3 RID: 160483 RVA: 0x003BBC75 File Offset: 0x003B9E75
		public unsafe bool SelectAllTextOnCommit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEditableText.__PropertyOffset_SelectAllTextOnCommit) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEditableText.__PropertyOffset_SelectAllTextOnCommit) = (value ? 1 : 0);
			}
		}

		// Token: 0x170096B9 RID: 38585
		// (get) Token: 0x060272E4 RID: 160484 RVA: 0x003BBC86 File Offset: 0x003B9E86
		// (set) Token: 0x060272E5 RID: 160485 RVA: 0x003BBC96 File Offset: 0x003B9E96
		public unsafe bool AllowContextMenu
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEditableText.__PropertyOffset_AllowContextMenu) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEditableText.__PropertyOffset_AllowContextMenu) = (value ? 1 : 0);
			}
		}

		// Token: 0x170096BA RID: 38586
		// (get) Token: 0x060272E6 RID: 160486 RVA: 0x003BBCA7 File Offset: 0x003B9EA7
		// (set) Token: 0x060272E7 RID: 160487 RVA: 0x003BBCBB File Offset: 0x003B9EBB
		[Nullable(0)]
		public unsafe TEnumAsByte<EVirtualKeyboardType> KeyboardType
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)UEditableText.__PropertyOffset_KeyboardType);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)UEditableText.__PropertyOffset_KeyboardType) = value;
			}
		}

		// Token: 0x170096BB RID: 38587
		// (get) Token: 0x060272E8 RID: 160488 RVA: 0x003BBCD0 File Offset: 0x003B9ED0
		// (set) Token: 0x060272E9 RID: 160489 RVA: 0x003BBD09 File Offset: 0x003B9F09
		public FVirtualKeyboardOptions VirtualKeyboardOptions
		{
			get
			{
				base.FastCheckIsValid();
				FVirtualKeyboardOptions result;
				if ((result = this._VirtualKeyboardOptions) == null)
				{
					result = (this._VirtualKeyboardOptions = new FVirtualKeyboardOptions(base.NativePtr + (IntPtr)UEditableText.__PropertyOffset_VirtualKeyboardOptions, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FVirtualKeyboardOptions.StaticStruct(), base.NativePtr + (IntPtr)UEditableText.__PropertyOffset_VirtualKeyboardOptions, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170096BC RID: 38588
		// (get) Token: 0x060272EA RID: 160490 RVA: 0x003BBD2A File Offset: 0x003B9F2A
		// (set) Token: 0x060272EB RID: 160491 RVA: 0x003BBD3A File Offset: 0x003B9F3A
		public unsafe EVirtualKeyboardTrigger VirtualKeyboardTrigger
		{
			get
			{
				return (EVirtualKeyboardTrigger)(*(base.NativePtr + (IntPtr)UEditableText.__PropertyOffset_VirtualKeyboardTrigger));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEditableText.__PropertyOffset_VirtualKeyboardTrigger) = (byte)value;
			}
		}

		// Token: 0x170096BD RID: 38589
		// (get) Token: 0x060272EC RID: 160492 RVA: 0x003BBD4B File Offset: 0x003B9F4B
		// (set) Token: 0x060272ED RID: 160493 RVA: 0x003BBD5B File Offset: 0x003B9F5B
		public unsafe EVirtualKeyboardDismissAction VirtualKeyboardDismissAction
		{
			get
			{
				return (EVirtualKeyboardDismissAction)(*(base.NativePtr + (IntPtr)UEditableText.__PropertyOffset_VirtualKeyboardDismissAction));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEditableText.__PropertyOffset_VirtualKeyboardDismissAction) = (byte)value;
			}
		}

		// Token: 0x170096BE RID: 38590
		// (get) Token: 0x060272EE RID: 160494 RVA: 0x003BBD6C File Offset: 0x003B9F6C
		// (set) Token: 0x060272EF RID: 160495 RVA: 0x003BBD80 File Offset: 0x003B9F80
		[Nullable(0)]
		public unsafe TEnumAsByte<ETextJustify> Justification
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)UEditableText.__PropertyOffset_Justification);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)UEditableText.__PropertyOffset_Justification) = value;
			}
		}

		// Token: 0x170096BF RID: 38591
		// (get) Token: 0x060272F0 RID: 160496 RVA: 0x003BBD98 File Offset: 0x003B9F98
		// (set) Token: 0x060272F1 RID: 160497 RVA: 0x003BBDD1 File Offset: 0x003B9FD1
		public FShapedTextOptions ShapedTextOptions
		{
			get
			{
				base.FastCheckIsValid();
				FShapedTextOptions result;
				if ((result = this._ShapedTextOptions) == null)
				{
					result = (this._ShapedTextOptions = new FShapedTextOptions(base.NativePtr + (IntPtr)UEditableText.__PropertyOffset_ShapedTextOptions, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FShapedTextOptions.StaticStruct(), base.NativePtr + (IntPtr)UEditableText.__PropertyOffset_ShapedTextOptions, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170096C0 RID: 38592
		// (get) Token: 0x060272F2 RID: 160498 RVA: 0x003BBDF4 File Offset: 0x003B9FF4
		// (set) Token: 0x060272F3 RID: 160499 RVA: 0x003BBE2D File Offset: 0x003BA02D
		public FOnEditableTextChangedEvent OnTextChanged
		{
			get
			{
				base.FastCheckIsValid();
				FOnEditableTextChangedEvent result;
				if ((result = this._OnTextChanged) == null)
				{
					result = (this._OnTextChanged = new FOnEditableTextChangedEvent(base.NativePtr + (IntPtr)UEditableText.__PropertyOffset_OnTextChanged, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UEditableText.__PropertyOffset_OnTextChanged, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170096C1 RID: 38593
		// (get) Token: 0x060272F4 RID: 160500 RVA: 0x003BBE50 File Offset: 0x003BA050
		// (set) Token: 0x060272F5 RID: 160501 RVA: 0x003BBE89 File Offset: 0x003BA089
		public FOnEditableTextCommittedEvent OnTextCommitted
		{
			get
			{
				base.FastCheckIsValid();
				FOnEditableTextCommittedEvent result;
				if ((result = this._OnTextCommitted) == null)
				{
					result = (this._OnTextCommitted = new FOnEditableTextCommittedEvent(base.NativePtr + (IntPtr)UEditableText.__PropertyOffset_OnTextCommitted, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UEditableText.__PropertyOffset_OnTextCommitted, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x060272F6 RID: 160502 RVA: 0x003BBEAA File Offset: 0x003BA0AA
		public void SetText(FText InText)
		{
			UEditableText.__SetText_Internal(base.NativePtr, (InText != null) ? InText.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060272F7 RID: 160503 RVA: 0x003BBEC7 File Offset: 0x003BA0C7
		public void SetJustification(ETextJustify InJustification)
		{
			UEditableText.__SetJustification_Internal(base.NativePtr, InJustification);
		}

		// Token: 0x060272F8 RID: 160504 RVA: 0x003BBEDA File Offset: 0x003BA0DA
		public void SetIsReadOnly(bool InbIsReadyOnly)
		{
			UEditableText.__SetIsReadOnly_Internal(base.NativePtr, InbIsReadyOnly);
		}

		// Token: 0x060272F9 RID: 160505 RVA: 0x003BBEE8 File Offset: 0x003BA0E8
		public void SetIsPassword(bool InbIsPassword)
		{
			UEditableText.__SetIsPassword_Internal(base.NativePtr, InbIsPassword);
		}

		// Token: 0x060272FA RID: 160506 RVA: 0x003BBEF6 File Offset: 0x003BA0F6
		public void SetHintText(FText InHintText)
		{
			UEditableText.__SetHintText_Internal(base.NativePtr, (InHintText != null) ? InHintText.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060272FB RID: 160507 RVA: 0x003BBF13 File Offset: 0x003BA113
		public FText GetText()
		{
			return new FText(UEditableText.__GetText_Internal(base.NativePtr), null);
		}

		// Token: 0x060272FC RID: 160508
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetText_Internal(IntPtr @this, IntPtr InText);

		// Token: 0x060272FD RID: 160509
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetJustification_Internal(IntPtr @this, TEnumAsByte<ETextJustify> InJustification);

		// Token: 0x060272FE RID: 160510
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetIsReadOnly_Internal(IntPtr @this, bool InbIsReadyOnly);

		// Token: 0x060272FF RID: 160511
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetIsPassword_Internal(IntPtr @this, bool InbIsPassword);

		// Token: 0x06027300 RID: 160512
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetHintText_Internal(IntPtr @this, IntPtr InHintText);

		// Token: 0x06027301 RID: 160513
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetText_Internal(IntPtr @this);

		// Token: 0x06027302 RID: 160514 RVA: 0x003BBF26 File Offset: 0x003BA126
		static UEditableText()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/UMG.EditableText");
		}

		// Token: 0x06027303 RID: 160515 RVA: 0x003BBF34 File Offset: 0x003BA134
		protected UEditableText(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015824 RID: 88100
		public new const string __ObjectPath = "/Script/UMG.EditableText";

		// Token: 0x04015825 RID: 88101
		private static IntPtr _ClassPtr;

		// Token: 0x04015826 RID: 88102
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015827 RID: 88103
		public static IntPtr __OnEditableTextCommittedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04015828 RID: 88104
		public static IntPtr __OnEditableTextChangedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04015829 RID: 88105
		internal static int __PropertyOffset_Text;

		// Token: 0x0401582A RID: 88106
		[Nullable(2)]
		private FText _Text;

		// Token: 0x0401582B RID: 88107
		internal static int __PropertyOffset_TextDelegate;

		// Token: 0x0401582C RID: 88108
		[Nullable(2)]
		private FGetText _TextDelegate;

		// Token: 0x0401582D RID: 88109
		internal static int __PropertyOffset_HintText;

		// Token: 0x0401582E RID: 88110
		[Nullable(2)]
		private FText _HintText;

		// Token: 0x0401582F RID: 88111
		internal static int __PropertyOffset_HintTextDelegate;

		// Token: 0x04015830 RID: 88112
		[Nullable(2)]
		private FGetText _HintTextDelegate;

		// Token: 0x04015831 RID: 88113
		internal static int __PropertyOffset_WidgetStyle;

		// Token: 0x04015832 RID: 88114
		[Nullable(2)]
		private FEditableTextStyle _WidgetStyle;

		// Token: 0x04015833 RID: 88115
		internal static int __PropertyOffset_Style_DEPRECATED;

		// Token: 0x04015834 RID: 88116
		internal static int __PropertyOffset_BackgroundImageSelected_DEPRECATED;

		// Token: 0x04015835 RID: 88117
		internal static int __PropertyOffset_BackgroundImageComposing_DEPRECATED;

		// Token: 0x04015836 RID: 88118
		internal static int __PropertyOffset_CaretImage_DEPRECATED;

		// Token: 0x04015837 RID: 88119
		internal static int __PropertyOffset_Font_DEPRECATED;

		// Token: 0x04015838 RID: 88120
		[Nullable(2)]
		private FSlateFontInfo _Font_DEPRECATED;

		// Token: 0x04015839 RID: 88121
		internal static int __PropertyOffset_ColorAndOpacity_DEPRECATED;

		// Token: 0x0401583A RID: 88122
		[Nullable(2)]
		private FSlateColor _ColorAndOpacity_DEPRECATED;

		// Token: 0x0401583B RID: 88123
		internal static int __PropertyOffset_IsReadOnly;

		// Token: 0x0401583C RID: 88124
		internal static int __PropertyOffset_IsPassword;

		// Token: 0x0401583D RID: 88125
		internal static int __PropertyOffset_MinimumDesiredWidth;

		// Token: 0x0401583E RID: 88126
		internal static int __PropertyOffset_IsCaretMovedWhenGainFocus;

		// Token: 0x0401583F RID: 88127
		internal static int __PropertyOffset_SelectAllTextWhenFocused;

		// Token: 0x04015840 RID: 88128
		internal static int __PropertyOffset_RevertTextOnEscape;

		// Token: 0x04015841 RID: 88129
		internal static int __PropertyOffset_ClearKeyboardFocusOnCommit;

		// Token: 0x04015842 RID: 88130
		internal static int __PropertyOffset_SelectAllTextOnCommit;

		// Token: 0x04015843 RID: 88131
		internal static int __PropertyOffset_AllowContextMenu;

		// Token: 0x04015844 RID: 88132
		internal static int __PropertyOffset_KeyboardType;

		// Token: 0x04015845 RID: 88133
		internal static int __PropertyOffset_VirtualKeyboardOptions;

		// Token: 0x04015846 RID: 88134
		[Nullable(2)]
		private FVirtualKeyboardOptions _VirtualKeyboardOptions;

		// Token: 0x04015847 RID: 88135
		internal static int __PropertyOffset_VirtualKeyboardTrigger;

		// Token: 0x04015848 RID: 88136
		internal static int __PropertyOffset_VirtualKeyboardDismissAction;

		// Token: 0x04015849 RID: 88137
		internal static int __PropertyOffset_Justification;

		// Token: 0x0401584A RID: 88138
		internal static int __PropertyOffset_ShapedTextOptions;

		// Token: 0x0401584B RID: 88139
		[Nullable(2)]
		private FShapedTextOptions _ShapedTextOptions;

		// Token: 0x0401584C RID: 88140
		internal static int __PropertyOffset_OnTextChanged;

		// Token: 0x0401584D RID: 88141
		[Nullable(2)]
		private FOnEditableTextChangedEvent _OnTextChanged;

		// Token: 0x0401584E RID: 88142
		internal static int __PropertyOffset_OnTextCommitted;

		// Token: 0x0401584F RID: 88143
		[Nullable(2)]
		private FOnEditableTextCommittedEvent _OnTextCommitted;
	}
}
