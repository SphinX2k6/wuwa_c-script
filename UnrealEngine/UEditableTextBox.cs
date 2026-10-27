using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002955 RID: 10581
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/UMG.EditableTextBox")]
	[UnrealStructLayout(3448, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 3448)]
	public class UEditableTextBox : UWidget, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06027304 RID: 160516 RVA: 0x003BBF3D File Offset: 0x003BA13D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UEditableTextBox._ClassPtr;
		}

		// Token: 0x06027305 RID: 160517 RVA: 0x003BBF4C File Offset: 0x003BA14C
		public UEditableTextBox() : this(BuiltinUtils.AllocNativeUObject(UEditableTextBox.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06027306 RID: 160518 RVA: 0x003BBF74 File Offset: 0x003BA174
		public UEditableTextBox(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UEditableTextBox.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170096C2 RID: 38594
		// (get) Token: 0x06027307 RID: 160519 RVA: 0x003BBFA8 File Offset: 0x003BA1A8
		// (set) Token: 0x06027308 RID: 160520 RVA: 0x003BBFE1 File Offset: 0x003BA1E1
		public unsafe FText Text
		{
			get
			{
				base.FastCheckIsValid();
				FText result;
				if ((result = this._Text) == null)
				{
					result = (this._Text = new FText(base.NativePtr + (IntPtr)UEditableTextBox.__PropertyOffset_Text, this));
				}
				return result;
			}
			set
			{
				FText.NativeCopy((void*)(base.NativePtr + (byte*)((IntPtr)UEditableTextBox.__PropertyOffset_Text)), value.NativePtr, 1);
			}
		}

		// Token: 0x170096C3 RID: 38595
		// (get) Token: 0x06027309 RID: 160521 RVA: 0x003BBFFC File Offset: 0x003BA1FC
		// (set) Token: 0x0602730A RID: 160522 RVA: 0x003BC035 File Offset: 0x003BA235
		public FGetText TextDelegate
		{
			get
			{
				base.FastCheckIsValid();
				FGetText result;
				if ((result = this._TextDelegate) == null)
				{
					result = (this._TextDelegate = new FGetText(base.NativePtr + (IntPtr)UEditableTextBox.__PropertyOffset_TextDelegate, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UEditableTextBox.__PropertyOffset_TextDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170096C4 RID: 38596
		// (get) Token: 0x0602730B RID: 160523 RVA: 0x003BC058 File Offset: 0x003BA258
		// (set) Token: 0x0602730C RID: 160524 RVA: 0x003BC091 File Offset: 0x003BA291
		public FEditableTextBoxStyle WidgetStyle
		{
			get
			{
				base.FastCheckIsValid();
				FEditableTextBoxStyle result;
				if ((result = this._WidgetStyle) == null)
				{
					result = (this._WidgetStyle = new FEditableTextBoxStyle(base.NativePtr + (IntPtr)UEditableTextBox.__PropertyOffset_WidgetStyle, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FEditableTextBoxStyle.StaticStruct(), base.NativePtr + (IntPtr)UEditableTextBox.__PropertyOffset_WidgetStyle, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170096C5 RID: 38597
		// (get) Token: 0x0602730D RID: 160525 RVA: 0x003BC0B2 File Offset: 0x003BA2B2
		// (set) Token: 0x0602730E RID: 160526 RVA: 0x003BC0C6 File Offset: 0x003BA2C6
		[Nullable(2)]
		public unsafe USlateWidgetStyleAsset Style_DEPRECATED
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USlateWidgetStyleAsset>(base.NativePtr / (IntPtr)sizeof(void*) + UEditableTextBox.__PropertyOffset_Style_DEPRECATED);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UEditableTextBox.__PropertyOffset_Style_DEPRECATED, value);
			}
		}

		// Token: 0x170096C6 RID: 38598
		// (get) Token: 0x0602730F RID: 160527 RVA: 0x003BC0DC File Offset: 0x003BA2DC
		// (set) Token: 0x06027310 RID: 160528 RVA: 0x003BC115 File Offset: 0x003BA315
		public unsafe FText HintText
		{
			get
			{
				base.FastCheckIsValid();
				FText result;
				if ((result = this._HintText) == null)
				{
					result = (this._HintText = new FText(base.NativePtr + (IntPtr)UEditableTextBox.__PropertyOffset_HintText, this));
				}
				return result;
			}
			set
			{
				FText.NativeCopy((void*)(base.NativePtr + (byte*)((IntPtr)UEditableTextBox.__PropertyOffset_HintText)), value.NativePtr, 1);
			}
		}

		// Token: 0x170096C7 RID: 38599
		// (get) Token: 0x06027311 RID: 160529 RVA: 0x003BC130 File Offset: 0x003BA330
		// (set) Token: 0x06027312 RID: 160530 RVA: 0x003BC169 File Offset: 0x003BA369
		public FGetText HintTextDelegate
		{
			get
			{
				base.FastCheckIsValid();
				FGetText result;
				if ((result = this._HintTextDelegate) == null)
				{
					result = (this._HintTextDelegate = new FGetText(base.NativePtr + (IntPtr)UEditableTextBox.__PropertyOffset_HintTextDelegate, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UEditableTextBox.__PropertyOffset_HintTextDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170096C8 RID: 38600
		// (get) Token: 0x06027313 RID: 160531 RVA: 0x003BC18C File Offset: 0x003BA38C
		// (set) Token: 0x06027314 RID: 160532 RVA: 0x003BC1C5 File Offset: 0x003BA3C5
		public FSlateFontInfo Font_DEPRECATED
		{
			get
			{
				base.FastCheckIsValid();
				FSlateFontInfo result;
				if ((result = this._Font_DEPRECATED) == null)
				{
					result = (this._Font_DEPRECATED = new FSlateFontInfo(base.NativePtr + (IntPtr)UEditableTextBox.__PropertyOffset_Font_DEPRECATED, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateFontInfo.StaticStruct(), base.NativePtr + (IntPtr)UEditableTextBox.__PropertyOffset_Font_DEPRECATED, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170096C9 RID: 38601
		// (get) Token: 0x06027315 RID: 160533 RVA: 0x003BC1E6 File Offset: 0x003BA3E6
		// (set) Token: 0x06027316 RID: 160534 RVA: 0x003BC1FA File Offset: 0x003BA3FA
		public unsafe FLinearColor ForegroundColor_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEditableTextBox.__PropertyOffset_ForegroundColor_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEditableTextBox.__PropertyOffset_ForegroundColor_DEPRECATED) = value;
			}
		}

		// Token: 0x170096CA RID: 38602
		// (get) Token: 0x06027317 RID: 160535 RVA: 0x003BC20F File Offset: 0x003BA40F
		// (set) Token: 0x06027318 RID: 160536 RVA: 0x003BC223 File Offset: 0x003BA423
		public unsafe FLinearColor BackgroundColor_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEditableTextBox.__PropertyOffset_BackgroundColor_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEditableTextBox.__PropertyOffset_BackgroundColor_DEPRECATED) = value;
			}
		}

		// Token: 0x170096CB RID: 38603
		// (get) Token: 0x06027319 RID: 160537 RVA: 0x003BC238 File Offset: 0x003BA438
		// (set) Token: 0x0602731A RID: 160538 RVA: 0x003BC24C File Offset: 0x003BA44C
		public unsafe FLinearColor ReadOnlyForegroundColor_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEditableTextBox.__PropertyOffset_ReadOnlyForegroundColor_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEditableTextBox.__PropertyOffset_ReadOnlyForegroundColor_DEPRECATED) = value;
			}
		}

		// Token: 0x170096CC RID: 38604
		// (get) Token: 0x0602731B RID: 160539 RVA: 0x003BC261 File Offset: 0x003BA461
		// (set) Token: 0x0602731C RID: 160540 RVA: 0x003BC271 File Offset: 0x003BA471
		public unsafe bool IsReadOnly
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEditableTextBox.__PropertyOffset_IsReadOnly) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEditableTextBox.__PropertyOffset_IsReadOnly) = (value ? 1 : 0);
			}
		}

		// Token: 0x170096CD RID: 38605
		// (get) Token: 0x0602731D RID: 160541 RVA: 0x003BC282 File Offset: 0x003BA482
		// (set) Token: 0x0602731E RID: 160542 RVA: 0x003BC292 File Offset: 0x003BA492
		public unsafe bool IsPassword
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEditableTextBox.__PropertyOffset_IsPassword) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEditableTextBox.__PropertyOffset_IsPassword) = (value ? 1 : 0);
			}
		}

		// Token: 0x170096CE RID: 38606
		// (get) Token: 0x0602731F RID: 160543 RVA: 0x003BC2A3 File Offset: 0x003BA4A3
		// (set) Token: 0x06027320 RID: 160544 RVA: 0x003BC2B3 File Offset: 0x003BA4B3
		public unsafe float MinimumDesiredWidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEditableTextBox.__PropertyOffset_MinimumDesiredWidth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEditableTextBox.__PropertyOffset_MinimumDesiredWidth) = value;
			}
		}

		// Token: 0x170096CF RID: 38607
		// (get) Token: 0x06027321 RID: 160545 RVA: 0x003BC2C4 File Offset: 0x003BA4C4
		// (set) Token: 0x06027322 RID: 160546 RVA: 0x003BC2D8 File Offset: 0x003BA4D8
		public unsafe FMargin Padding_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEditableTextBox.__PropertyOffset_Padding_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEditableTextBox.__PropertyOffset_Padding_DEPRECATED) = value;
			}
		}

		// Token: 0x170096D0 RID: 38608
		// (get) Token: 0x06027323 RID: 160547 RVA: 0x003BC2ED File Offset: 0x003BA4ED
		// (set) Token: 0x06027324 RID: 160548 RVA: 0x003BC2FD File Offset: 0x003BA4FD
		public unsafe bool IsCaretMovedWhenGainFocus
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEditableTextBox.__PropertyOffset_IsCaretMovedWhenGainFocus) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEditableTextBox.__PropertyOffset_IsCaretMovedWhenGainFocus) = (value ? 1 : 0);
			}
		}

		// Token: 0x170096D1 RID: 38609
		// (get) Token: 0x06027325 RID: 160549 RVA: 0x003BC30E File Offset: 0x003BA50E
		// (set) Token: 0x06027326 RID: 160550 RVA: 0x003BC31E File Offset: 0x003BA51E
		public unsafe bool SelectAllTextWhenFocused
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEditableTextBox.__PropertyOffset_SelectAllTextWhenFocused) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEditableTextBox.__PropertyOffset_SelectAllTextWhenFocused) = (value ? 1 : 0);
			}
		}

		// Token: 0x170096D2 RID: 38610
		// (get) Token: 0x06027327 RID: 160551 RVA: 0x003BC32F File Offset: 0x003BA52F
		// (set) Token: 0x06027328 RID: 160552 RVA: 0x003BC33F File Offset: 0x003BA53F
		public unsafe bool RevertTextOnEscape
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEditableTextBox.__PropertyOffset_RevertTextOnEscape) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEditableTextBox.__PropertyOffset_RevertTextOnEscape) = (value ? 1 : 0);
			}
		}

		// Token: 0x170096D3 RID: 38611
		// (get) Token: 0x06027329 RID: 160553 RVA: 0x003BC350 File Offset: 0x003BA550
		// (set) Token: 0x0602732A RID: 160554 RVA: 0x003BC360 File Offset: 0x003BA560
		public unsafe bool ClearKeyboardFocusOnCommit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEditableTextBox.__PropertyOffset_ClearKeyboardFocusOnCommit) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEditableTextBox.__PropertyOffset_ClearKeyboardFocusOnCommit) = (value ? 1 : 0);
			}
		}

		// Token: 0x170096D4 RID: 38612
		// (get) Token: 0x0602732B RID: 160555 RVA: 0x003BC371 File Offset: 0x003BA571
		// (set) Token: 0x0602732C RID: 160556 RVA: 0x003BC381 File Offset: 0x003BA581
		public unsafe bool SelectAllTextOnCommit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEditableTextBox.__PropertyOffset_SelectAllTextOnCommit) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEditableTextBox.__PropertyOffset_SelectAllTextOnCommit) = (value ? 1 : 0);
			}
		}

		// Token: 0x170096D5 RID: 38613
		// (get) Token: 0x0602732D RID: 160557 RVA: 0x003BC392 File Offset: 0x003BA592
		// (set) Token: 0x0602732E RID: 160558 RVA: 0x003BC3A2 File Offset: 0x003BA5A2
		public unsafe bool AllowContextMenu
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEditableTextBox.__PropertyOffset_AllowContextMenu) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEditableTextBox.__PropertyOffset_AllowContextMenu) = (value ? 1 : 0);
			}
		}

		// Token: 0x170096D6 RID: 38614
		// (get) Token: 0x0602732F RID: 160559 RVA: 0x003BC3B3 File Offset: 0x003BA5B3
		// (set) Token: 0x06027330 RID: 160560 RVA: 0x003BC3C7 File Offset: 0x003BA5C7
		[Nullable(0)]
		public unsafe TEnumAsByte<EVirtualKeyboardType> KeyboardType
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)UEditableTextBox.__PropertyOffset_KeyboardType);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)UEditableTextBox.__PropertyOffset_KeyboardType) = value;
			}
		}

		// Token: 0x170096D7 RID: 38615
		// (get) Token: 0x06027331 RID: 160561 RVA: 0x003BC3DC File Offset: 0x003BA5DC
		// (set) Token: 0x06027332 RID: 160562 RVA: 0x003BC415 File Offset: 0x003BA615
		public FVirtualKeyboardOptions VirtualKeyboardOptions
		{
			get
			{
				base.FastCheckIsValid();
				FVirtualKeyboardOptions result;
				if ((result = this._VirtualKeyboardOptions) == null)
				{
					result = (this._VirtualKeyboardOptions = new FVirtualKeyboardOptions(base.NativePtr + (IntPtr)UEditableTextBox.__PropertyOffset_VirtualKeyboardOptions, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FVirtualKeyboardOptions.StaticStruct(), base.NativePtr + (IntPtr)UEditableTextBox.__PropertyOffset_VirtualKeyboardOptions, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170096D8 RID: 38616
		// (get) Token: 0x06027333 RID: 160563 RVA: 0x003BC436 File Offset: 0x003BA636
		// (set) Token: 0x06027334 RID: 160564 RVA: 0x003BC446 File Offset: 0x003BA646
		public unsafe EVirtualKeyboardTrigger VirtualKeyboardTrigger
		{
			get
			{
				return (EVirtualKeyboardTrigger)(*(base.NativePtr + (IntPtr)UEditableTextBox.__PropertyOffset_VirtualKeyboardTrigger));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEditableTextBox.__PropertyOffset_VirtualKeyboardTrigger) = (byte)value;
			}
		}

		// Token: 0x170096D9 RID: 38617
		// (get) Token: 0x06027335 RID: 160565 RVA: 0x003BC457 File Offset: 0x003BA657
		// (set) Token: 0x06027336 RID: 160566 RVA: 0x003BC467 File Offset: 0x003BA667
		public unsafe EVirtualKeyboardDismissAction VirtualKeyboardDismissAction
		{
			get
			{
				return (EVirtualKeyboardDismissAction)(*(base.NativePtr + (IntPtr)UEditableTextBox.__PropertyOffset_VirtualKeyboardDismissAction));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEditableTextBox.__PropertyOffset_VirtualKeyboardDismissAction) = (byte)value;
			}
		}

		// Token: 0x170096DA RID: 38618
		// (get) Token: 0x06027337 RID: 160567 RVA: 0x003BC478 File Offset: 0x003BA678
		// (set) Token: 0x06027338 RID: 160568 RVA: 0x003BC48C File Offset: 0x003BA68C
		[Nullable(0)]
		public unsafe TEnumAsByte<ETextJustify> Justification
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)UEditableTextBox.__PropertyOffset_Justification);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)UEditableTextBox.__PropertyOffset_Justification) = value;
			}
		}

		// Token: 0x170096DB RID: 38619
		// (get) Token: 0x06027339 RID: 160569 RVA: 0x003BC4A4 File Offset: 0x003BA6A4
		// (set) Token: 0x0602733A RID: 160570 RVA: 0x003BC4DD File Offset: 0x003BA6DD
		public FShapedTextOptions ShapedTextOptions
		{
			get
			{
				base.FastCheckIsValid();
				FShapedTextOptions result;
				if ((result = this._ShapedTextOptions) == null)
				{
					result = (this._ShapedTextOptions = new FShapedTextOptions(base.NativePtr + (IntPtr)UEditableTextBox.__PropertyOffset_ShapedTextOptions, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FShapedTextOptions.StaticStruct(), base.NativePtr + (IntPtr)UEditableTextBox.__PropertyOffset_ShapedTextOptions, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170096DC RID: 38620
		// (get) Token: 0x0602733B RID: 160571 RVA: 0x003BC500 File Offset: 0x003BA700
		// (set) Token: 0x0602733C RID: 160572 RVA: 0x003BC539 File Offset: 0x003BA739
		public FOnEditableTextBoxChangedEvent OnTextChanged
		{
			get
			{
				base.FastCheckIsValid();
				FOnEditableTextBoxChangedEvent result;
				if ((result = this._OnTextChanged) == null)
				{
					result = (this._OnTextChanged = new FOnEditableTextBoxChangedEvent(base.NativePtr + (IntPtr)UEditableTextBox.__PropertyOffset_OnTextChanged, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UEditableTextBox.__PropertyOffset_OnTextChanged, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170096DD RID: 38621
		// (get) Token: 0x0602733D RID: 160573 RVA: 0x003BC55C File Offset: 0x003BA75C
		// (set) Token: 0x0602733E RID: 160574 RVA: 0x003BC595 File Offset: 0x003BA795
		public FOnEditableTextBoxCommittedEvent OnTextCommitted
		{
			get
			{
				base.FastCheckIsValid();
				FOnEditableTextBoxCommittedEvent result;
				if ((result = this._OnTextCommitted) == null)
				{
					result = (this._OnTextCommitted = new FOnEditableTextBoxCommittedEvent(base.NativePtr + (IntPtr)UEditableTextBox.__PropertyOffset_OnTextCommitted, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UEditableTextBox.__PropertyOffset_OnTextCommitted, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x0602733F RID: 160575 RVA: 0x003BC5B6 File Offset: 0x003BA7B6
		public void SetText(FText InText)
		{
			UEditableTextBox.__SetText_Internal(base.NativePtr, (InText != null) ? InText.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06027340 RID: 160576 RVA: 0x003BC5D3 File Offset: 0x003BA7D3
		public void SetJustification(ETextJustify InJustification)
		{
			UEditableTextBox.__SetJustification_Internal(base.NativePtr, InJustification);
		}

		// Token: 0x06027341 RID: 160577 RVA: 0x003BC5E6 File Offset: 0x003BA7E6
		public void SetIsReadOnly(bool bReadOnly)
		{
			UEditableTextBox.__SetIsReadOnly_Internal(base.NativePtr, bReadOnly);
		}

		// Token: 0x06027342 RID: 160578 RVA: 0x003BC5F4 File Offset: 0x003BA7F4
		public void SetIsPassword(bool bIsPassword)
		{
			UEditableTextBox.__SetIsPassword_Internal(base.NativePtr, bIsPassword);
		}

		// Token: 0x06027343 RID: 160579 RVA: 0x003BC602 File Offset: 0x003BA802
		public void SetHintText(FText InText)
		{
			UEditableTextBox.__SetHintText_Internal(base.NativePtr, (InText != null) ? InText.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06027344 RID: 160580 RVA: 0x003BC61F File Offset: 0x003BA81F
		public void SetError(FText InError)
		{
			UEditableTextBox.__SetError_Internal(base.NativePtr, (InError != null) ? InError.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06027345 RID: 160581 RVA: 0x003BC63C File Offset: 0x003BA83C
		public bool HasError()
		{
			return UEditableTextBox.__HasError_Internal(base.NativePtr);
		}

		// Token: 0x06027346 RID: 160582 RVA: 0x003BC649 File Offset: 0x003BA849
		public FText GetText()
		{
			return new FText(UEditableTextBox.__GetText_Internal(base.NativePtr), null);
		}

		// Token: 0x06027347 RID: 160583 RVA: 0x003BC65C File Offset: 0x003BA85C
		public void ClearError()
		{
			UEditableTextBox.__ClearError_Internal(base.NativePtr);
		}

		// Token: 0x06027348 RID: 160584
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetText_Internal(IntPtr @this, IntPtr InText);

		// Token: 0x06027349 RID: 160585
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetJustification_Internal(IntPtr @this, TEnumAsByte<ETextJustify> InJustification);

		// Token: 0x0602734A RID: 160586
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetIsReadOnly_Internal(IntPtr @this, bool bReadOnly);

		// Token: 0x0602734B RID: 160587
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetIsPassword_Internal(IntPtr @this, bool bIsPassword);

		// Token: 0x0602734C RID: 160588
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetHintText_Internal(IntPtr @this, IntPtr InText);

		// Token: 0x0602734D RID: 160589
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetError_Internal(IntPtr @this, IntPtr InError);

		// Token: 0x0602734E RID: 160590
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __HasError_Internal(IntPtr @this);

		// Token: 0x0602734F RID: 160591
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetText_Internal(IntPtr @this);

		// Token: 0x06027350 RID: 160592
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearError_Internal(IntPtr @this);

		// Token: 0x06027351 RID: 160593 RVA: 0x003BC669 File Offset: 0x003BA869
		static UEditableTextBox()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/UMG.EditableTextBox");
		}

		// Token: 0x06027352 RID: 160594 RVA: 0x003BC677 File Offset: 0x003BA877
		protected UEditableTextBox(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015850 RID: 88144
		public new const string __ObjectPath = "/Script/UMG.EditableTextBox";

		// Token: 0x04015851 RID: 88145
		private static IntPtr _ClassPtr;

		// Token: 0x04015852 RID: 88146
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015853 RID: 88147
		public static IntPtr __OnEditableTextBoxCommittedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04015854 RID: 88148
		public static IntPtr __OnEditableTextBoxChangedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04015855 RID: 88149
		internal static int __PropertyOffset_Text;

		// Token: 0x04015856 RID: 88150
		[Nullable(2)]
		private FText _Text;

		// Token: 0x04015857 RID: 88151
		internal static int __PropertyOffset_TextDelegate;

		// Token: 0x04015858 RID: 88152
		[Nullable(2)]
		private FGetText _TextDelegate;

		// Token: 0x04015859 RID: 88153
		internal static int __PropertyOffset_WidgetStyle;

		// Token: 0x0401585A RID: 88154
		[Nullable(2)]
		private FEditableTextBoxStyle _WidgetStyle;

		// Token: 0x0401585B RID: 88155
		internal static int __PropertyOffset_Style_DEPRECATED;

		// Token: 0x0401585C RID: 88156
		internal static int __PropertyOffset_HintText;

		// Token: 0x0401585D RID: 88157
		[Nullable(2)]
		private FText _HintText;

		// Token: 0x0401585E RID: 88158
		internal static int __PropertyOffset_HintTextDelegate;

		// Token: 0x0401585F RID: 88159
		[Nullable(2)]
		private FGetText _HintTextDelegate;

		// Token: 0x04015860 RID: 88160
		internal static int __PropertyOffset_Font_DEPRECATED;

		// Token: 0x04015861 RID: 88161
		[Nullable(2)]
		private FSlateFontInfo _Font_DEPRECATED;

		// Token: 0x04015862 RID: 88162
		internal static int __PropertyOffset_ForegroundColor_DEPRECATED;

		// Token: 0x04015863 RID: 88163
		internal static int __PropertyOffset_BackgroundColor_DEPRECATED;

		// Token: 0x04015864 RID: 88164
		internal static int __PropertyOffset_ReadOnlyForegroundColor_DEPRECATED;

		// Token: 0x04015865 RID: 88165
		internal static int __PropertyOffset_IsReadOnly;

		// Token: 0x04015866 RID: 88166
		internal static int __PropertyOffset_IsPassword;

		// Token: 0x04015867 RID: 88167
		internal static int __PropertyOffset_MinimumDesiredWidth;

		// Token: 0x04015868 RID: 88168
		internal static int __PropertyOffset_Padding_DEPRECATED;

		// Token: 0x04015869 RID: 88169
		internal static int __PropertyOffset_IsCaretMovedWhenGainFocus;

		// Token: 0x0401586A RID: 88170
		internal static int __PropertyOffset_SelectAllTextWhenFocused;

		// Token: 0x0401586B RID: 88171
		internal static int __PropertyOffset_RevertTextOnEscape;

		// Token: 0x0401586C RID: 88172
		internal static int __PropertyOffset_ClearKeyboardFocusOnCommit;

		// Token: 0x0401586D RID: 88173
		internal static int __PropertyOffset_SelectAllTextOnCommit;

		// Token: 0x0401586E RID: 88174
		internal static int __PropertyOffset_AllowContextMenu;

		// Token: 0x0401586F RID: 88175
		internal static int __PropertyOffset_KeyboardType;

		// Token: 0x04015870 RID: 88176
		internal static int __PropertyOffset_VirtualKeyboardOptions;

		// Token: 0x04015871 RID: 88177
		[Nullable(2)]
		private FVirtualKeyboardOptions _VirtualKeyboardOptions;

		// Token: 0x04015872 RID: 88178
		internal static int __PropertyOffset_VirtualKeyboardTrigger;

		// Token: 0x04015873 RID: 88179
		internal static int __PropertyOffset_VirtualKeyboardDismissAction;

		// Token: 0x04015874 RID: 88180
		internal static int __PropertyOffset_Justification;

		// Token: 0x04015875 RID: 88181
		internal static int __PropertyOffset_ShapedTextOptions;

		// Token: 0x04015876 RID: 88182
		[Nullable(2)]
		private FShapedTextOptions _ShapedTextOptions;

		// Token: 0x04015877 RID: 88183
		internal static int __PropertyOffset_OnTextChanged;

		// Token: 0x04015878 RID: 88184
		[Nullable(2)]
		private FOnEditableTextBoxChangedEvent _OnTextChanged;

		// Token: 0x04015879 RID: 88185
		internal static int __PropertyOffset_OnTextCommitted;

		// Token: 0x0401587A RID: 88186
		[Nullable(2)]
		private FOnEditableTextBoxCommittedEvent _OnTextCommitted;
	}
}
