using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200298E RID: 10638
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/UMG.MultiLineEditableTextBox")]
	[UnrealStructLayout(4096, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 4096)]
	public class UMultiLineEditableTextBox : UTextLayoutWidget, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06027601 RID: 161281 RVA: 0x003C0834 File Offset: 0x003BEA34
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMultiLineEditableTextBox._ClassPtr;
		}

		// Token: 0x06027602 RID: 161282 RVA: 0x003C0840 File Offset: 0x003BEA40
		public UMultiLineEditableTextBox() : this(BuiltinUtils.AllocNativeUObject(UMultiLineEditableTextBox.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06027603 RID: 161283 RVA: 0x003C0868 File Offset: 0x003BEA68
		public UMultiLineEditableTextBox(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMultiLineEditableTextBox.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17009754 RID: 38740
		// (get) Token: 0x06027604 RID: 161284 RVA: 0x003C089C File Offset: 0x003BEA9C
		// (set) Token: 0x06027605 RID: 161285 RVA: 0x003C08D5 File Offset: 0x003BEAD5
		public unsafe FText Text
		{
			get
			{
				base.FastCheckIsValid();
				FText result;
				if ((result = this._Text) == null)
				{
					result = (this._Text = new FText(base.NativePtr + (IntPtr)UMultiLineEditableTextBox.__PropertyOffset_Text, this));
				}
				return result;
			}
			set
			{
				FText.NativeCopy((void*)(base.NativePtr + (byte*)((IntPtr)UMultiLineEditableTextBox.__PropertyOffset_Text)), value.NativePtr, 1);
			}
		}

		// Token: 0x17009755 RID: 38741
		// (get) Token: 0x06027606 RID: 161286 RVA: 0x003C08F0 File Offset: 0x003BEAF0
		// (set) Token: 0x06027607 RID: 161287 RVA: 0x003C0929 File Offset: 0x003BEB29
		public unsafe FText HintText
		{
			get
			{
				base.FastCheckIsValid();
				FText result;
				if ((result = this._HintText) == null)
				{
					result = (this._HintText = new FText(base.NativePtr + (IntPtr)UMultiLineEditableTextBox.__PropertyOffset_HintText, this));
				}
				return result;
			}
			set
			{
				FText.NativeCopy((void*)(base.NativePtr + (byte*)((IntPtr)UMultiLineEditableTextBox.__PropertyOffset_HintText)), value.NativePtr, 1);
			}
		}

		// Token: 0x17009756 RID: 38742
		// (get) Token: 0x06027608 RID: 161288 RVA: 0x003C0944 File Offset: 0x003BEB44
		// (set) Token: 0x06027609 RID: 161289 RVA: 0x003C097D File Offset: 0x003BEB7D
		public FGetText HintTextDelegate
		{
			get
			{
				base.FastCheckIsValid();
				FGetText result;
				if ((result = this._HintTextDelegate) == null)
				{
					result = (this._HintTextDelegate = new FGetText(base.NativePtr + (IntPtr)UMultiLineEditableTextBox.__PropertyOffset_HintTextDelegate, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UMultiLineEditableTextBox.__PropertyOffset_HintTextDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17009757 RID: 38743
		// (get) Token: 0x0602760A RID: 161290 RVA: 0x003C09A0 File Offset: 0x003BEBA0
		// (set) Token: 0x0602760B RID: 161291 RVA: 0x003C09D9 File Offset: 0x003BEBD9
		public FEditableTextBoxStyle WidgetStyle
		{
			get
			{
				base.FastCheckIsValid();
				FEditableTextBoxStyle result;
				if ((result = this._WidgetStyle) == null)
				{
					result = (this._WidgetStyle = new FEditableTextBoxStyle(base.NativePtr + (IntPtr)UMultiLineEditableTextBox.__PropertyOffset_WidgetStyle, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FEditableTextBoxStyle.StaticStruct(), base.NativePtr + (IntPtr)UMultiLineEditableTextBox.__PropertyOffset_WidgetStyle, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17009758 RID: 38744
		// (get) Token: 0x0602760C RID: 161292 RVA: 0x003C09FC File Offset: 0x003BEBFC
		// (set) Token: 0x0602760D RID: 161293 RVA: 0x003C0A35 File Offset: 0x003BEC35
		public FTextBlockStyle TextStyle
		{
			get
			{
				base.FastCheckIsValid();
				FTextBlockStyle result;
				if ((result = this._TextStyle) == null)
				{
					result = (this._TextStyle = new FTextBlockStyle(base.NativePtr + (IntPtr)UMultiLineEditableTextBox.__PropertyOffset_TextStyle, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FTextBlockStyle.StaticStruct(), base.NativePtr + (IntPtr)UMultiLineEditableTextBox.__PropertyOffset_TextStyle, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17009759 RID: 38745
		// (get) Token: 0x0602760E RID: 161294 RVA: 0x003C0A56 File Offset: 0x003BEC56
		// (set) Token: 0x0602760F RID: 161295 RVA: 0x003C0A66 File Offset: 0x003BEC66
		public unsafe bool bIsReadOnly
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMultiLineEditableTextBox.__PropertyOffset_bIsReadOnly) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMultiLineEditableTextBox.__PropertyOffset_bIsReadOnly) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700975A RID: 38746
		// (get) Token: 0x06027610 RID: 161296 RVA: 0x003C0A77 File Offset: 0x003BEC77
		// (set) Token: 0x06027611 RID: 161297 RVA: 0x003C0A87 File Offset: 0x003BEC87
		public unsafe bool AllowContextMenu
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMultiLineEditableTextBox.__PropertyOffset_AllowContextMenu) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMultiLineEditableTextBox.__PropertyOffset_AllowContextMenu) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700975B RID: 38747
		// (get) Token: 0x06027612 RID: 161298 RVA: 0x003C0A98 File Offset: 0x003BEC98
		// (set) Token: 0x06027613 RID: 161299 RVA: 0x003C0AD1 File Offset: 0x003BECD1
		public FVirtualKeyboardOptions VirtualKeyboardOptions
		{
			get
			{
				base.FastCheckIsValid();
				FVirtualKeyboardOptions result;
				if ((result = this._VirtualKeyboardOptions) == null)
				{
					result = (this._VirtualKeyboardOptions = new FVirtualKeyboardOptions(base.NativePtr + (IntPtr)UMultiLineEditableTextBox.__PropertyOffset_VirtualKeyboardOptions, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FVirtualKeyboardOptions.StaticStruct(), base.NativePtr + (IntPtr)UMultiLineEditableTextBox.__PropertyOffset_VirtualKeyboardOptions, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700975C RID: 38748
		// (get) Token: 0x06027614 RID: 161300 RVA: 0x003C0AF2 File Offset: 0x003BECF2
		// (set) Token: 0x06027615 RID: 161301 RVA: 0x003C0B02 File Offset: 0x003BED02
		public unsafe EVirtualKeyboardDismissAction VirtualKeyboardDismissAction
		{
			get
			{
				return (EVirtualKeyboardDismissAction)(*(base.NativePtr + (IntPtr)UMultiLineEditableTextBox.__PropertyOffset_VirtualKeyboardDismissAction));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMultiLineEditableTextBox.__PropertyOffset_VirtualKeyboardDismissAction) = (byte)value;
			}
		}

		// Token: 0x1700975D RID: 38749
		// (get) Token: 0x06027616 RID: 161302 RVA: 0x003C0B13 File Offset: 0x003BED13
		// (set) Token: 0x06027617 RID: 161303 RVA: 0x003C0B27 File Offset: 0x003BED27
		[Nullable(2)]
		public unsafe USlateWidgetStyleAsset Style_DEPRECATED
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USlateWidgetStyleAsset>(base.NativePtr / (IntPtr)sizeof(void*) + UMultiLineEditableTextBox.__PropertyOffset_Style_DEPRECATED);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UMultiLineEditableTextBox.__PropertyOffset_Style_DEPRECATED, value);
			}
		}

		// Token: 0x1700975E RID: 38750
		// (get) Token: 0x06027618 RID: 161304 RVA: 0x003C0B3C File Offset: 0x003BED3C
		// (set) Token: 0x06027619 RID: 161305 RVA: 0x003C0B75 File Offset: 0x003BED75
		public FSlateFontInfo Font_DEPRECATED
		{
			get
			{
				base.FastCheckIsValid();
				FSlateFontInfo result;
				if ((result = this._Font_DEPRECATED) == null)
				{
					result = (this._Font_DEPRECATED = new FSlateFontInfo(base.NativePtr + (IntPtr)UMultiLineEditableTextBox.__PropertyOffset_Font_DEPRECATED, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateFontInfo.StaticStruct(), base.NativePtr + (IntPtr)UMultiLineEditableTextBox.__PropertyOffset_Font_DEPRECATED, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700975F RID: 38751
		// (get) Token: 0x0602761A RID: 161306 RVA: 0x003C0B96 File Offset: 0x003BED96
		// (set) Token: 0x0602761B RID: 161307 RVA: 0x003C0BAA File Offset: 0x003BEDAA
		public unsafe FLinearColor ForegroundColor_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMultiLineEditableTextBox.__PropertyOffset_ForegroundColor_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMultiLineEditableTextBox.__PropertyOffset_ForegroundColor_DEPRECATED) = value;
			}
		}

		// Token: 0x17009760 RID: 38752
		// (get) Token: 0x0602761C RID: 161308 RVA: 0x003C0BBF File Offset: 0x003BEDBF
		// (set) Token: 0x0602761D RID: 161309 RVA: 0x003C0BD3 File Offset: 0x003BEDD3
		public unsafe FLinearColor BackgroundColor_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMultiLineEditableTextBox.__PropertyOffset_BackgroundColor_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMultiLineEditableTextBox.__PropertyOffset_BackgroundColor_DEPRECATED) = value;
			}
		}

		// Token: 0x17009761 RID: 38753
		// (get) Token: 0x0602761E RID: 161310 RVA: 0x003C0BE8 File Offset: 0x003BEDE8
		// (set) Token: 0x0602761F RID: 161311 RVA: 0x003C0BFC File Offset: 0x003BEDFC
		public unsafe FLinearColor ReadOnlyForegroundColor_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMultiLineEditableTextBox.__PropertyOffset_ReadOnlyForegroundColor_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMultiLineEditableTextBox.__PropertyOffset_ReadOnlyForegroundColor_DEPRECATED) = value;
			}
		}

		// Token: 0x17009762 RID: 38754
		// (get) Token: 0x06027620 RID: 161312 RVA: 0x003C0C14 File Offset: 0x003BEE14
		// (set) Token: 0x06027621 RID: 161313 RVA: 0x003C0C4D File Offset: 0x003BEE4D
		public FOnMultiLineEditableTextBoxChangedEvent OnTextChanged
		{
			get
			{
				base.FastCheckIsValid();
				FOnMultiLineEditableTextBoxChangedEvent result;
				if ((result = this._OnTextChanged) == null)
				{
					result = (this._OnTextChanged = new FOnMultiLineEditableTextBoxChangedEvent(base.NativePtr + (IntPtr)UMultiLineEditableTextBox.__PropertyOffset_OnTextChanged, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UMultiLineEditableTextBox.__PropertyOffset_OnTextChanged, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17009763 RID: 38755
		// (get) Token: 0x06027622 RID: 161314 RVA: 0x003C0C70 File Offset: 0x003BEE70
		// (set) Token: 0x06027623 RID: 161315 RVA: 0x003C0CA9 File Offset: 0x003BEEA9
		public FOnMultiLineEditableTextBoxCommittedEvent OnTextCommitted
		{
			get
			{
				base.FastCheckIsValid();
				FOnMultiLineEditableTextBoxCommittedEvent result;
				if ((result = this._OnTextCommitted) == null)
				{
					result = (this._OnTextCommitted = new FOnMultiLineEditableTextBoxCommittedEvent(base.NativePtr + (IntPtr)UMultiLineEditableTextBox.__PropertyOffset_OnTextCommitted, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UMultiLineEditableTextBox.__PropertyOffset_OnTextCommitted, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x06027624 RID: 161316 RVA: 0x003C0CCA File Offset: 0x003BEECA
		[NullableContext(2)]
		public void SetTextStyle(in FTextBlockStyle InTextStyle)
		{
			UMultiLineEditableTextBox.__SetTextStyle_Internal(base.NativePtr, (InTextStyle ?? new FTextBlockStyle()).NativePtr);
		}

		// Token: 0x06027625 RID: 161317 RVA: 0x003C0CE7 File Offset: 0x003BEEE7
		public void SetText(FText InText)
		{
			UMultiLineEditableTextBox.__SetText_Internal(base.NativePtr, (InText != null) ? InText.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06027626 RID: 161318 RVA: 0x003C0D04 File Offset: 0x003BEF04
		public void SetIsReadOnly(bool bReadOnly)
		{
			UMultiLineEditableTextBox.__SetIsReadOnly_Internal(base.NativePtr, bReadOnly);
		}

		// Token: 0x06027627 RID: 161319 RVA: 0x003C0D12 File Offset: 0x003BEF12
		public void SetHintText(FText InHintText)
		{
			UMultiLineEditableTextBox.__SetHintText_Internal(base.NativePtr, (InHintText != null) ? InHintText.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06027628 RID: 161320 RVA: 0x003C0D2F File Offset: 0x003BEF2F
		public void SetError(FText InError)
		{
			UMultiLineEditableTextBox.__SetError_Internal(base.NativePtr, (InError != null) ? InError.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06027629 RID: 161321 RVA: 0x003C0D4C File Offset: 0x003BEF4C
		public FText GetText()
		{
			return new FText(UMultiLineEditableTextBox.__GetText_Internal(base.NativePtr), null);
		}

		// Token: 0x0602762A RID: 161322 RVA: 0x003C0D5F File Offset: 0x003BEF5F
		public FText GetHintText()
		{
			return new FText(UMultiLineEditableTextBox.__GetHintText_Internal(base.NativePtr), null);
		}

		// Token: 0x0602762B RID: 161323
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTextStyle_Internal(IntPtr @this, IntPtr InTextStyle);

		// Token: 0x0602762C RID: 161324
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetText_Internal(IntPtr @this, IntPtr InText);

		// Token: 0x0602762D RID: 161325
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetIsReadOnly_Internal(IntPtr @this, bool bReadOnly);

		// Token: 0x0602762E RID: 161326
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetHintText_Internal(IntPtr @this, IntPtr InHintText);

		// Token: 0x0602762F RID: 161327
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetError_Internal(IntPtr @this, IntPtr InError);

		// Token: 0x06027630 RID: 161328
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetText_Internal(IntPtr @this);

		// Token: 0x06027631 RID: 161329
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetHintText_Internal(IntPtr @this);

		// Token: 0x06027632 RID: 161330 RVA: 0x003C0D72 File Offset: 0x003BEF72
		static UMultiLineEditableTextBox()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/UMG.MultiLineEditableTextBox");
		}

		// Token: 0x06027633 RID: 161331 RVA: 0x003C0D80 File Offset: 0x003BEF80
		protected UMultiLineEditableTextBox(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040159F5 RID: 88565
		public new const string __ObjectPath = "/Script/UMG.MultiLineEditableTextBox";

		// Token: 0x040159F6 RID: 88566
		private static IntPtr _ClassPtr;

		// Token: 0x040159F7 RID: 88567
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040159F8 RID: 88568
		public static IntPtr __OnMultiLineEditableTextBoxCommittedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x040159F9 RID: 88569
		public static IntPtr __OnMultiLineEditableTextBoxChangedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x040159FA RID: 88570
		internal static int __PropertyOffset_Text;

		// Token: 0x040159FB RID: 88571
		[Nullable(2)]
		private FText _Text;

		// Token: 0x040159FC RID: 88572
		internal static int __PropertyOffset_HintText;

		// Token: 0x040159FD RID: 88573
		[Nullable(2)]
		private FText _HintText;

		// Token: 0x040159FE RID: 88574
		internal static int __PropertyOffset_HintTextDelegate;

		// Token: 0x040159FF RID: 88575
		[Nullable(2)]
		private FGetText _HintTextDelegate;

		// Token: 0x04015A00 RID: 88576
		internal static int __PropertyOffset_WidgetStyle;

		// Token: 0x04015A01 RID: 88577
		[Nullable(2)]
		private FEditableTextBoxStyle _WidgetStyle;

		// Token: 0x04015A02 RID: 88578
		internal static int __PropertyOffset_TextStyle;

		// Token: 0x04015A03 RID: 88579
		[Nullable(2)]
		private FTextBlockStyle _TextStyle;

		// Token: 0x04015A04 RID: 88580
		internal static int __PropertyOffset_bIsReadOnly;

		// Token: 0x04015A05 RID: 88581
		internal static int __PropertyOffset_AllowContextMenu;

		// Token: 0x04015A06 RID: 88582
		internal static int __PropertyOffset_VirtualKeyboardOptions;

		// Token: 0x04015A07 RID: 88583
		[Nullable(2)]
		private FVirtualKeyboardOptions _VirtualKeyboardOptions;

		// Token: 0x04015A08 RID: 88584
		internal static int __PropertyOffset_VirtualKeyboardDismissAction;

		// Token: 0x04015A09 RID: 88585
		internal static int __PropertyOffset_Style_DEPRECATED;

		// Token: 0x04015A0A RID: 88586
		internal static int __PropertyOffset_Font_DEPRECATED;

		// Token: 0x04015A0B RID: 88587
		[Nullable(2)]
		private FSlateFontInfo _Font_DEPRECATED;

		// Token: 0x04015A0C RID: 88588
		internal static int __PropertyOffset_ForegroundColor_DEPRECATED;

		// Token: 0x04015A0D RID: 88589
		internal static int __PropertyOffset_BackgroundColor_DEPRECATED;

		// Token: 0x04015A0E RID: 88590
		internal static int __PropertyOffset_ReadOnlyForegroundColor_DEPRECATED;

		// Token: 0x04015A0F RID: 88591
		internal static int __PropertyOffset_OnTextChanged;

		// Token: 0x04015A10 RID: 88592
		[Nullable(2)]
		private FOnMultiLineEditableTextBoxChangedEvent _OnTextChanged;

		// Token: 0x04015A11 RID: 88593
		internal static int __PropertyOffset_OnTextCommitted;

		// Token: 0x04015A12 RID: 88594
		[Nullable(2)]
		private FOnMultiLineEditableTextBoxCommittedEvent _OnTextCommitted;
	}
}
