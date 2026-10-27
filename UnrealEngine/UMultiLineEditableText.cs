using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200298D RID: 10637
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/UMG.MultiLineEditableText")]
	[UnrealStructLayout(1680, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1680)]
	public class UMultiLineEditableText : UTextLayoutWidget, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060275D2 RID: 161234 RVA: 0x003C0377 File Offset: 0x003BE577
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMultiLineEditableText._ClassPtr;
		}

		// Token: 0x060275D3 RID: 161235 RVA: 0x003C0384 File Offset: 0x003BE584
		public UMultiLineEditableText() : this(BuiltinUtils.AllocNativeUObject(UMultiLineEditableText.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060275D4 RID: 161236 RVA: 0x003C03AC File Offset: 0x003BE5AC
		public UMultiLineEditableText(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMultiLineEditableText.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17009745 RID: 38725
		// (get) Token: 0x060275D5 RID: 161237 RVA: 0x003C03E0 File Offset: 0x003BE5E0
		// (set) Token: 0x060275D6 RID: 161238 RVA: 0x003C0419 File Offset: 0x003BE619
		public unsafe FText Text
		{
			get
			{
				base.FastCheckIsValid();
				FText result;
				if ((result = this._Text) == null)
				{
					result = (this._Text = new FText(base.NativePtr + (IntPtr)UMultiLineEditableText.__PropertyOffset_Text, this));
				}
				return result;
			}
			set
			{
				FText.NativeCopy((void*)(base.NativePtr + (byte*)((IntPtr)UMultiLineEditableText.__PropertyOffset_Text)), value.NativePtr, 1);
			}
		}

		// Token: 0x17009746 RID: 38726
		// (get) Token: 0x060275D7 RID: 161239 RVA: 0x003C0434 File Offset: 0x003BE634
		// (set) Token: 0x060275D8 RID: 161240 RVA: 0x003C046D File Offset: 0x003BE66D
		public unsafe FText HintText
		{
			get
			{
				base.FastCheckIsValid();
				FText result;
				if ((result = this._HintText) == null)
				{
					result = (this._HintText = new FText(base.NativePtr + (IntPtr)UMultiLineEditableText.__PropertyOffset_HintText, this));
				}
				return result;
			}
			set
			{
				FText.NativeCopy((void*)(base.NativePtr + (byte*)((IntPtr)UMultiLineEditableText.__PropertyOffset_HintText)), value.NativePtr, 1);
			}
		}

		// Token: 0x17009747 RID: 38727
		// (get) Token: 0x060275D9 RID: 161241 RVA: 0x003C0488 File Offset: 0x003BE688
		// (set) Token: 0x060275DA RID: 161242 RVA: 0x003C04C1 File Offset: 0x003BE6C1
		public FGetText HintTextDelegate
		{
			get
			{
				base.FastCheckIsValid();
				FGetText result;
				if ((result = this._HintTextDelegate) == null)
				{
					result = (this._HintTextDelegate = new FGetText(base.NativePtr + (IntPtr)UMultiLineEditableText.__PropertyOffset_HintTextDelegate, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UMultiLineEditableText.__PropertyOffset_HintTextDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17009748 RID: 38728
		// (get) Token: 0x060275DB RID: 161243 RVA: 0x003C04E4 File Offset: 0x003BE6E4
		// (set) Token: 0x060275DC RID: 161244 RVA: 0x003C051D File Offset: 0x003BE71D
		public FTextBlockStyle WidgetStyle
		{
			get
			{
				base.FastCheckIsValid();
				FTextBlockStyle result;
				if ((result = this._WidgetStyle) == null)
				{
					result = (this._WidgetStyle = new FTextBlockStyle(base.NativePtr + (IntPtr)UMultiLineEditableText.__PropertyOffset_WidgetStyle, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FTextBlockStyle.StaticStruct(), base.NativePtr + (IntPtr)UMultiLineEditableText.__PropertyOffset_WidgetStyle, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17009749 RID: 38729
		// (get) Token: 0x060275DD RID: 161245 RVA: 0x003C053E File Offset: 0x003BE73E
		// (set) Token: 0x060275DE RID: 161246 RVA: 0x003C054E File Offset: 0x003BE74E
		public unsafe bool bIsReadOnly
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMultiLineEditableText.__PropertyOffset_bIsReadOnly) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMultiLineEditableText.__PropertyOffset_bIsReadOnly) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700974A RID: 38730
		// (get) Token: 0x060275DF RID: 161247 RVA: 0x003C0560 File Offset: 0x003BE760
		// (set) Token: 0x060275E0 RID: 161248 RVA: 0x003C0599 File Offset: 0x003BE799
		public FSlateFontInfo Font_DEPRECATED
		{
			get
			{
				base.FastCheckIsValid();
				FSlateFontInfo result;
				if ((result = this._Font_DEPRECATED) == null)
				{
					result = (this._Font_DEPRECATED = new FSlateFontInfo(base.NativePtr + (IntPtr)UMultiLineEditableText.__PropertyOffset_Font_DEPRECATED, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateFontInfo.StaticStruct(), base.NativePtr + (IntPtr)UMultiLineEditableText.__PropertyOffset_Font_DEPRECATED, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700974B RID: 38731
		// (get) Token: 0x060275E1 RID: 161249 RVA: 0x003C05BA File Offset: 0x003BE7BA
		// (set) Token: 0x060275E2 RID: 161250 RVA: 0x003C05CA File Offset: 0x003BE7CA
		public unsafe bool SelectAllTextWhenFocused
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMultiLineEditableText.__PropertyOffset_SelectAllTextWhenFocused) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMultiLineEditableText.__PropertyOffset_SelectAllTextWhenFocused) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700974C RID: 38732
		// (get) Token: 0x060275E3 RID: 161251 RVA: 0x003C05DB File Offset: 0x003BE7DB
		// (set) Token: 0x060275E4 RID: 161252 RVA: 0x003C05EB File Offset: 0x003BE7EB
		public unsafe bool ClearTextSelectionOnFocusLoss
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMultiLineEditableText.__PropertyOffset_ClearTextSelectionOnFocusLoss) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMultiLineEditableText.__PropertyOffset_ClearTextSelectionOnFocusLoss) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700974D RID: 38733
		// (get) Token: 0x060275E5 RID: 161253 RVA: 0x003C05FC File Offset: 0x003BE7FC
		// (set) Token: 0x060275E6 RID: 161254 RVA: 0x003C060C File Offset: 0x003BE80C
		public unsafe bool RevertTextOnEscape
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMultiLineEditableText.__PropertyOffset_RevertTextOnEscape) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMultiLineEditableText.__PropertyOffset_RevertTextOnEscape) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700974E RID: 38734
		// (get) Token: 0x060275E7 RID: 161255 RVA: 0x003C061D File Offset: 0x003BE81D
		// (set) Token: 0x060275E8 RID: 161256 RVA: 0x003C062D File Offset: 0x003BE82D
		public unsafe bool ClearKeyboardFocusOnCommit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMultiLineEditableText.__PropertyOffset_ClearKeyboardFocusOnCommit) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMultiLineEditableText.__PropertyOffset_ClearKeyboardFocusOnCommit) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700974F RID: 38735
		// (get) Token: 0x060275E9 RID: 161257 RVA: 0x003C063E File Offset: 0x003BE83E
		// (set) Token: 0x060275EA RID: 161258 RVA: 0x003C064E File Offset: 0x003BE84E
		public unsafe bool AllowContextMenu
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMultiLineEditableText.__PropertyOffset_AllowContextMenu) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMultiLineEditableText.__PropertyOffset_AllowContextMenu) = (value ? 1 : 0);
			}
		}

		// Token: 0x17009750 RID: 38736
		// (get) Token: 0x060275EB RID: 161259 RVA: 0x003C0660 File Offset: 0x003BE860
		// (set) Token: 0x060275EC RID: 161260 RVA: 0x003C0699 File Offset: 0x003BE899
		public FVirtualKeyboardOptions VirtualKeyboardOptions
		{
			get
			{
				base.FastCheckIsValid();
				FVirtualKeyboardOptions result;
				if ((result = this._VirtualKeyboardOptions) == null)
				{
					result = (this._VirtualKeyboardOptions = new FVirtualKeyboardOptions(base.NativePtr + (IntPtr)UMultiLineEditableText.__PropertyOffset_VirtualKeyboardOptions, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FVirtualKeyboardOptions.StaticStruct(), base.NativePtr + (IntPtr)UMultiLineEditableText.__PropertyOffset_VirtualKeyboardOptions, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17009751 RID: 38737
		// (get) Token: 0x060275ED RID: 161261 RVA: 0x003C06BA File Offset: 0x003BE8BA
		// (set) Token: 0x060275EE RID: 161262 RVA: 0x003C06CA File Offset: 0x003BE8CA
		public unsafe EVirtualKeyboardDismissAction VirtualKeyboardDismissAction
		{
			get
			{
				return (EVirtualKeyboardDismissAction)(*(base.NativePtr + (IntPtr)UMultiLineEditableText.__PropertyOffset_VirtualKeyboardDismissAction));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMultiLineEditableText.__PropertyOffset_VirtualKeyboardDismissAction) = (byte)value;
			}
		}

		// Token: 0x17009752 RID: 38738
		// (get) Token: 0x060275EF RID: 161263 RVA: 0x003C06DC File Offset: 0x003BE8DC
		// (set) Token: 0x060275F0 RID: 161264 RVA: 0x003C0715 File Offset: 0x003BE915
		public FOnMultiLineEditableTextChangedEvent OnTextChanged
		{
			get
			{
				base.FastCheckIsValid();
				FOnMultiLineEditableTextChangedEvent result;
				if ((result = this._OnTextChanged) == null)
				{
					result = (this._OnTextChanged = new FOnMultiLineEditableTextChangedEvent(base.NativePtr + (IntPtr)UMultiLineEditableText.__PropertyOffset_OnTextChanged, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UMultiLineEditableText.__PropertyOffset_OnTextChanged, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17009753 RID: 38739
		// (get) Token: 0x060275F1 RID: 161265 RVA: 0x003C0738 File Offset: 0x003BE938
		// (set) Token: 0x060275F2 RID: 161266 RVA: 0x003C0771 File Offset: 0x003BE971
		public FOnMultiLineEditableTextCommittedEvent OnTextCommitted
		{
			get
			{
				base.FastCheckIsValid();
				FOnMultiLineEditableTextCommittedEvent result;
				if ((result = this._OnTextCommitted) == null)
				{
					result = (this._OnTextCommitted = new FOnMultiLineEditableTextCommittedEvent(base.NativePtr + (IntPtr)UMultiLineEditableText.__PropertyOffset_OnTextCommitted, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UMultiLineEditableText.__PropertyOffset_OnTextCommitted, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x060275F3 RID: 161267 RVA: 0x003C0792 File Offset: 0x003BE992
		[NullableContext(2)]
		public void SetWidgetStyle(in FTextBlockStyle InWidgetStyle)
		{
			UMultiLineEditableText.__SetWidgetStyle_Internal(base.NativePtr, (InWidgetStyle ?? new FTextBlockStyle()).NativePtr);
		}

		// Token: 0x060275F4 RID: 161268 RVA: 0x003C07AF File Offset: 0x003BE9AF
		public void SetText(FText InText)
		{
			UMultiLineEditableText.__SetText_Internal(base.NativePtr, (InText != null) ? InText.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060275F5 RID: 161269 RVA: 0x003C07CC File Offset: 0x003BE9CC
		public void SetIsReadOnly(bool bReadOnly)
		{
			UMultiLineEditableText.__SetIsReadOnly_Internal(base.NativePtr, bReadOnly);
		}

		// Token: 0x060275F6 RID: 161270 RVA: 0x003C07DA File Offset: 0x003BE9DA
		public void SetHintText(FText InHintText)
		{
			UMultiLineEditableText.__SetHintText_Internal(base.NativePtr, (InHintText != null) ? InHintText.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060275F7 RID: 161271 RVA: 0x003C07F7 File Offset: 0x003BE9F7
		public FText GetText()
		{
			return new FText(UMultiLineEditableText.__GetText_Internal(base.NativePtr), null);
		}

		// Token: 0x060275F8 RID: 161272 RVA: 0x003C080A File Offset: 0x003BEA0A
		public FText GetHintText()
		{
			return new FText(UMultiLineEditableText.__GetHintText_Internal(base.NativePtr), null);
		}

		// Token: 0x060275F9 RID: 161273
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetWidgetStyle_Internal(IntPtr @this, IntPtr InWidgetStyle);

		// Token: 0x060275FA RID: 161274
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetText_Internal(IntPtr @this, IntPtr InText);

		// Token: 0x060275FB RID: 161275
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetIsReadOnly_Internal(IntPtr @this, bool bReadOnly);

		// Token: 0x060275FC RID: 161276
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetHintText_Internal(IntPtr @this, IntPtr InHintText);

		// Token: 0x060275FD RID: 161277
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetText_Internal(IntPtr @this);

		// Token: 0x060275FE RID: 161278
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetHintText_Internal(IntPtr @this);

		// Token: 0x060275FF RID: 161279 RVA: 0x003C081D File Offset: 0x003BEA1D
		static UMultiLineEditableText()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/UMG.MultiLineEditableText");
		}

		// Token: 0x06027600 RID: 161280 RVA: 0x003C082B File Offset: 0x003BEA2B
		protected UMultiLineEditableText(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040159D9 RID: 88537
		public new const string __ObjectPath = "/Script/UMG.MultiLineEditableText";

		// Token: 0x040159DA RID: 88538
		private static IntPtr _ClassPtr;

		// Token: 0x040159DB RID: 88539
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040159DC RID: 88540
		public static IntPtr __OnMultiLineEditableTextCommittedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x040159DD RID: 88541
		public static IntPtr __OnMultiLineEditableTextChangedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x040159DE RID: 88542
		internal static int __PropertyOffset_Text;

		// Token: 0x040159DF RID: 88543
		[Nullable(2)]
		private FText _Text;

		// Token: 0x040159E0 RID: 88544
		internal static int __PropertyOffset_HintText;

		// Token: 0x040159E1 RID: 88545
		[Nullable(2)]
		private FText _HintText;

		// Token: 0x040159E2 RID: 88546
		internal static int __PropertyOffset_HintTextDelegate;

		// Token: 0x040159E3 RID: 88547
		[Nullable(2)]
		private FGetText _HintTextDelegate;

		// Token: 0x040159E4 RID: 88548
		internal static int __PropertyOffset_WidgetStyle;

		// Token: 0x040159E5 RID: 88549
		[Nullable(2)]
		private FTextBlockStyle _WidgetStyle;

		// Token: 0x040159E6 RID: 88550
		internal static int __PropertyOffset_bIsReadOnly;

		// Token: 0x040159E7 RID: 88551
		internal static int __PropertyOffset_Font_DEPRECATED;

		// Token: 0x040159E8 RID: 88552
		[Nullable(2)]
		private FSlateFontInfo _Font_DEPRECATED;

		// Token: 0x040159E9 RID: 88553
		internal static int __PropertyOffset_SelectAllTextWhenFocused;

		// Token: 0x040159EA RID: 88554
		internal static int __PropertyOffset_ClearTextSelectionOnFocusLoss;

		// Token: 0x040159EB RID: 88555
		internal static int __PropertyOffset_RevertTextOnEscape;

		// Token: 0x040159EC RID: 88556
		internal static int __PropertyOffset_ClearKeyboardFocusOnCommit;

		// Token: 0x040159ED RID: 88557
		internal static int __PropertyOffset_AllowContextMenu;

		// Token: 0x040159EE RID: 88558
		internal static int __PropertyOffset_VirtualKeyboardOptions;

		// Token: 0x040159EF RID: 88559
		[Nullable(2)]
		private FVirtualKeyboardOptions _VirtualKeyboardOptions;

		// Token: 0x040159F0 RID: 88560
		internal static int __PropertyOffset_VirtualKeyboardDismissAction;

		// Token: 0x040159F1 RID: 88561
		internal static int __PropertyOffset_OnTextChanged;

		// Token: 0x040159F2 RID: 88562
		[Nullable(2)]
		private FOnMultiLineEditableTextChangedEvent _OnTextChanged;

		// Token: 0x040159F3 RID: 88563
		internal static int __PropertyOffset_OnTextCommitted;

		// Token: 0x040159F4 RID: 88564
		[Nullable(2)]
		private FOnMultiLineEditableTextCommittedEvent _OnTextCommitted;
	}
}
