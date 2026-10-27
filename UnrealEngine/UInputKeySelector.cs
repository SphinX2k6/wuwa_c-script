using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200297A RID: 10618
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/UMG.InputKeySelector")]
	[UnrealStructLayout(2432, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2432)]
	public class UInputKeySelector : UWidget, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602746E RID: 160878 RVA: 0x003BE442 File Offset: 0x003BC642
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UInputKeySelector._ClassPtr;
		}

		// Token: 0x0602746F RID: 160879 RVA: 0x003BE450 File Offset: 0x003BC650
		public UInputKeySelector() : this(BuiltinUtils.AllocNativeUObject(UInputKeySelector.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06027470 RID: 160880 RVA: 0x003BE478 File Offset: 0x003BC678
		public UInputKeySelector(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UInputKeySelector.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170096FD RID: 38653
		// (get) Token: 0x06027471 RID: 160881 RVA: 0x003BE4AC File Offset: 0x003BC6AC
		// (set) Token: 0x06027472 RID: 160882 RVA: 0x003BE4E5 File Offset: 0x003BC6E5
		public FButtonStyle WidgetStyle
		{
			get
			{
				base.FastCheckIsValid();
				FButtonStyle result;
				if ((result = this._WidgetStyle) == null)
				{
					result = (this._WidgetStyle = new FButtonStyle(base.NativePtr + (IntPtr)UInputKeySelector.__PropertyOffset_WidgetStyle, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FButtonStyle.StaticStruct(), base.NativePtr + (IntPtr)UInputKeySelector.__PropertyOffset_WidgetStyle, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170096FE RID: 38654
		// (get) Token: 0x06027473 RID: 160883 RVA: 0x003BE508 File Offset: 0x003BC708
		// (set) Token: 0x06027474 RID: 160884 RVA: 0x003BE541 File Offset: 0x003BC741
		public FTextBlockStyle TextStyle
		{
			get
			{
				base.FastCheckIsValid();
				FTextBlockStyle result;
				if ((result = this._TextStyle) == null)
				{
					result = (this._TextStyle = new FTextBlockStyle(base.NativePtr + (IntPtr)UInputKeySelector.__PropertyOffset_TextStyle, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FTextBlockStyle.StaticStruct(), base.NativePtr + (IntPtr)UInputKeySelector.__PropertyOffset_TextStyle, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170096FF RID: 38655
		// (get) Token: 0x06027475 RID: 160885 RVA: 0x003BE564 File Offset: 0x003BC764
		// (set) Token: 0x06027476 RID: 160886 RVA: 0x003BE59D File Offset: 0x003BC79D
		public FInputChord SelectedKey
		{
			get
			{
				base.FastCheckIsValid();
				FInputChord result;
				if ((result = this._SelectedKey) == null)
				{
					result = (this._SelectedKey = new FInputChord(base.NativePtr + (IntPtr)UInputKeySelector.__PropertyOffset_SelectedKey, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FInputChord.StaticStruct(), base.NativePtr + (IntPtr)UInputKeySelector.__PropertyOffset_SelectedKey, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17009700 RID: 38656
		// (get) Token: 0x06027477 RID: 160887 RVA: 0x003BE5C0 File Offset: 0x003BC7C0
		// (set) Token: 0x06027478 RID: 160888 RVA: 0x003BE5F9 File Offset: 0x003BC7F9
		public FSlateFontInfo Font_DEPRECATED
		{
			get
			{
				base.FastCheckIsValid();
				FSlateFontInfo result;
				if ((result = this._Font_DEPRECATED) == null)
				{
					result = (this._Font_DEPRECATED = new FSlateFontInfo(base.NativePtr + (IntPtr)UInputKeySelector.__PropertyOffset_Font_DEPRECATED, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateFontInfo.StaticStruct(), base.NativePtr + (IntPtr)UInputKeySelector.__PropertyOffset_Font_DEPRECATED, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17009701 RID: 38657
		// (get) Token: 0x06027479 RID: 160889 RVA: 0x003BE61A File Offset: 0x003BC81A
		// (set) Token: 0x0602747A RID: 160890 RVA: 0x003BE62E File Offset: 0x003BC82E
		public unsafe FMargin Margin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UInputKeySelector.__PropertyOffset_Margin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UInputKeySelector.__PropertyOffset_Margin) = value;
			}
		}

		// Token: 0x17009702 RID: 38658
		// (get) Token: 0x0602747B RID: 160891 RVA: 0x003BE643 File Offset: 0x003BC843
		// (set) Token: 0x0602747C RID: 160892 RVA: 0x003BE657 File Offset: 0x003BC857
		public unsafe FLinearColor ColorAndOpacity_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UInputKeySelector.__PropertyOffset_ColorAndOpacity_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UInputKeySelector.__PropertyOffset_ColorAndOpacity_DEPRECATED) = value;
			}
		}

		// Token: 0x17009703 RID: 38659
		// (get) Token: 0x0602747D RID: 160893 RVA: 0x003BE66C File Offset: 0x003BC86C
		// (set) Token: 0x0602747E RID: 160894 RVA: 0x003BE6A5 File Offset: 0x003BC8A5
		public unsafe FText KeySelectionText
		{
			get
			{
				base.FastCheckIsValid();
				FText result;
				if ((result = this._KeySelectionText) == null)
				{
					result = (this._KeySelectionText = new FText(base.NativePtr + (IntPtr)UInputKeySelector.__PropertyOffset_KeySelectionText, this));
				}
				return result;
			}
			set
			{
				FText.NativeCopy((void*)(base.NativePtr + (byte*)((IntPtr)UInputKeySelector.__PropertyOffset_KeySelectionText)), value.NativePtr, 1);
			}
		}

		// Token: 0x17009704 RID: 38660
		// (get) Token: 0x0602747F RID: 160895 RVA: 0x003BE6C0 File Offset: 0x003BC8C0
		// (set) Token: 0x06027480 RID: 160896 RVA: 0x003BE6F9 File Offset: 0x003BC8F9
		public unsafe FText NoKeySpecifiedText
		{
			get
			{
				base.FastCheckIsValid();
				FText result;
				if ((result = this._NoKeySpecifiedText) == null)
				{
					result = (this._NoKeySpecifiedText = new FText(base.NativePtr + (IntPtr)UInputKeySelector.__PropertyOffset_NoKeySpecifiedText, this));
				}
				return result;
			}
			set
			{
				FText.NativeCopy((void*)(base.NativePtr + (byte*)((IntPtr)UInputKeySelector.__PropertyOffset_NoKeySpecifiedText)), value.NativePtr, 1);
			}
		}

		// Token: 0x17009705 RID: 38661
		// (get) Token: 0x06027481 RID: 160897 RVA: 0x003BE714 File Offset: 0x003BC914
		// (set) Token: 0x06027482 RID: 160898 RVA: 0x003BE724 File Offset: 0x003BC924
		public unsafe bool bAllowModifierKeys
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UInputKeySelector.__PropertyOffset_bAllowModifierKeys) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UInputKeySelector.__PropertyOffset_bAllowModifierKeys) = (value ? 1 : 0);
			}
		}

		// Token: 0x17009706 RID: 38662
		// (get) Token: 0x06027483 RID: 160899 RVA: 0x003BE735 File Offset: 0x003BC935
		// (set) Token: 0x06027484 RID: 160900 RVA: 0x003BE745 File Offset: 0x003BC945
		public unsafe bool bAllowGamepadKeys
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UInputKeySelector.__PropertyOffset_bAllowGamepadKeys) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UInputKeySelector.__PropertyOffset_bAllowGamepadKeys) = (value ? 1 : 0);
			}
		}

		// Token: 0x17009707 RID: 38663
		// (get) Token: 0x06027485 RID: 160901 RVA: 0x003BE758 File Offset: 0x003BC958
		// (set) Token: 0x06027486 RID: 160902 RVA: 0x003BE791 File Offset: 0x003BC991
		public TArray<FKey> EscapeKeys
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKey> result;
				if ((result = this._EscapeKeys) == null)
				{
					result = (this._EscapeKeys = new TArray<FKey>(base.NativePtr + (IntPtr)UInputKeySelector.__PropertyOffset_EscapeKeys, this));
				}
				return result;
			}
			set
			{
				this.EscapeKeys.CopyAssign(value);
			}
		}

		// Token: 0x17009708 RID: 38664
		// (get) Token: 0x06027487 RID: 160903 RVA: 0x003BE7A0 File Offset: 0x003BC9A0
		// (set) Token: 0x06027488 RID: 160904 RVA: 0x003BE7D9 File Offset: 0x003BC9D9
		public FOnKeySelected OnKeySelected
		{
			get
			{
				base.FastCheckIsValid();
				FOnKeySelected result;
				if ((result = this._OnKeySelected) == null)
				{
					result = (this._OnKeySelected = new FOnKeySelected(base.NativePtr + (IntPtr)UInputKeySelector.__PropertyOffset_OnKeySelected, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UInputKeySelector.__PropertyOffset_OnKeySelected, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17009709 RID: 38665
		// (get) Token: 0x06027489 RID: 160905 RVA: 0x003BE7FC File Offset: 0x003BC9FC
		// (set) Token: 0x0602748A RID: 160906 RVA: 0x003BE835 File Offset: 0x003BCA35
		public FOnIsSelectingKeyChanged OnIsSelectingKeyChanged
		{
			get
			{
				base.FastCheckIsValid();
				FOnIsSelectingKeyChanged result;
				if ((result = this._OnIsSelectingKeyChanged) == null)
				{
					result = (this._OnIsSelectingKeyChanged = new FOnIsSelectingKeyChanged(base.NativePtr + (IntPtr)UInputKeySelector.__PropertyOffset_OnIsSelectingKeyChanged, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UInputKeySelector.__PropertyOffset_OnIsSelectingKeyChanged, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x0602748B RID: 160907 RVA: 0x003BE856 File Offset: 0x003BCA56
		public void SetTextBlockVisibility(ESlateVisibility InVisibility)
		{
			UInputKeySelector.__SetTextBlockVisibility_Internal(base.NativePtr, InVisibility);
		}

		// Token: 0x0602748C RID: 160908 RVA: 0x003BE864 File Offset: 0x003BCA64
		[NullableContext(2)]
		public void SetSelectedKey(in FInputChord InSelectedKey)
		{
			UInputKeySelector.__SetSelectedKey_Internal(base.NativePtr, (InSelectedKey ?? new FInputChord()).NativePtr);
		}

		// Token: 0x0602748D RID: 160909 RVA: 0x003BE881 File Offset: 0x003BCA81
		public void SetNoKeySpecifiedText(FText InNoKeySpecifiedText)
		{
			UInputKeySelector.__SetNoKeySpecifiedText_Internal(base.NativePtr, (InNoKeySpecifiedText != null) ? InNoKeySpecifiedText.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0602748E RID: 160910 RVA: 0x003BE89E File Offset: 0x003BCA9E
		public void SetKeySelectionText(FText InKeySelectionText)
		{
			UInputKeySelector.__SetKeySelectionText_Internal(base.NativePtr, (InKeySelectionText != null) ? InKeySelectionText.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0602748F RID: 160911 RVA: 0x003BE8BB File Offset: 0x003BCABB
		public void SetEscapeKeys([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FKey> InKeys)
		{
			UInputKeySelector.__SetEscapeKeys_Internal(base.NativePtr, (InKeys ?? new TArray<FKey>()).NativePtr);
		}

		// Token: 0x06027490 RID: 160912 RVA: 0x003BE8D8 File Offset: 0x003BCAD8
		public void SetAllowModifierKeys(bool bInAllowModifierKeys)
		{
			UInputKeySelector.__SetAllowModifierKeys_Internal(base.NativePtr, bInAllowModifierKeys);
		}

		// Token: 0x06027491 RID: 160913 RVA: 0x003BE8E6 File Offset: 0x003BCAE6
		public void SetAllowGamepadKeys(bool bInAllowGamepadKeys)
		{
			UInputKeySelector.__SetAllowGamepadKeys_Internal(base.NativePtr, bInAllowGamepadKeys);
		}

		// Token: 0x06027492 RID: 160914 RVA: 0x003BE8F4 File Offset: 0x003BCAF4
		public bool GetIsSelectingKey()
		{
			return UInputKeySelector.__GetIsSelectingKey_Internal(base.NativePtr);
		}

		// Token: 0x06027493 RID: 160915
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTextBlockVisibility_Internal(IntPtr @this, ESlateVisibility InVisibility);

		// Token: 0x06027494 RID: 160916
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSelectedKey_Internal(IntPtr @this, IntPtr InSelectedKey);

		// Token: 0x06027495 RID: 160917
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNoKeySpecifiedText_Internal(IntPtr @this, IntPtr InNoKeySpecifiedText);

		// Token: 0x06027496 RID: 160918
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKeySelectionText_Internal(IntPtr @this, IntPtr InKeySelectionText);

		// Token: 0x06027497 RID: 160919
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetEscapeKeys_Internal(IntPtr @this, IntPtr InKeys);

		// Token: 0x06027498 RID: 160920
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAllowModifierKeys_Internal(IntPtr @this, bool bInAllowModifierKeys);

		// Token: 0x06027499 RID: 160921
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAllowGamepadKeys_Internal(IntPtr @this, bool bInAllowGamepadKeys);

		// Token: 0x0602749A RID: 160922
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetIsSelectingKey_Internal(IntPtr @this);

		// Token: 0x0602749B RID: 160923 RVA: 0x003BE901 File Offset: 0x003BCB01
		static UInputKeySelector()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/UMG.InputKeySelector");
		}

		// Token: 0x0602749C RID: 160924 RVA: 0x003BE90F File Offset: 0x003BCB0F
		protected UInputKeySelector(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015930 RID: 88368
		public new const string __ObjectPath = "/Script/UMG.InputKeySelector";

		// Token: 0x04015931 RID: 88369
		private static IntPtr _ClassPtr;

		// Token: 0x04015932 RID: 88370
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015933 RID: 88371
		public static IntPtr __OnKeySelected__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04015934 RID: 88372
		public static IntPtr __OnIsSelectingKeyChanged__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04015935 RID: 88373
		internal static int __PropertyOffset_WidgetStyle;

		// Token: 0x04015936 RID: 88374
		[Nullable(2)]
		private FButtonStyle _WidgetStyle;

		// Token: 0x04015937 RID: 88375
		internal static int __PropertyOffset_TextStyle;

		// Token: 0x04015938 RID: 88376
		[Nullable(2)]
		private FTextBlockStyle _TextStyle;

		// Token: 0x04015939 RID: 88377
		internal static int __PropertyOffset_SelectedKey;

		// Token: 0x0401593A RID: 88378
		[Nullable(2)]
		private FInputChord _SelectedKey;

		// Token: 0x0401593B RID: 88379
		internal static int __PropertyOffset_Font_DEPRECATED;

		// Token: 0x0401593C RID: 88380
		[Nullable(2)]
		private FSlateFontInfo _Font_DEPRECATED;

		// Token: 0x0401593D RID: 88381
		internal static int __PropertyOffset_Margin;

		// Token: 0x0401593E RID: 88382
		internal static int __PropertyOffset_ColorAndOpacity_DEPRECATED;

		// Token: 0x0401593F RID: 88383
		internal static int __PropertyOffset_KeySelectionText;

		// Token: 0x04015940 RID: 88384
		[Nullable(2)]
		private FText _KeySelectionText;

		// Token: 0x04015941 RID: 88385
		internal static int __PropertyOffset_NoKeySpecifiedText;

		// Token: 0x04015942 RID: 88386
		[Nullable(2)]
		private FText _NoKeySpecifiedText;

		// Token: 0x04015943 RID: 88387
		internal static int __PropertyOffset_bAllowModifierKeys;

		// Token: 0x04015944 RID: 88388
		internal static int __PropertyOffset_bAllowGamepadKeys;

		// Token: 0x04015945 RID: 88389
		internal static int __PropertyOffset_EscapeKeys;

		// Token: 0x04015946 RID: 88390
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKey> _EscapeKeys;

		// Token: 0x04015947 RID: 88391
		internal static int __PropertyOffset_OnKeySelected;

		// Token: 0x04015948 RID: 88392
		[Nullable(2)]
		private FOnKeySelected _OnKeySelected;

		// Token: 0x04015949 RID: 88393
		internal static int __PropertyOffset_OnIsSelectingKeyChanged;

		// Token: 0x0401594A RID: 88394
		[Nullable(2)]
		private FOnIsSelectingKeyChanged _OnIsSelectingKeyChanged;
	}
}
