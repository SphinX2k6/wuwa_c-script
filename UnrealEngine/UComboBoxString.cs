using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000856 RID: 2134
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/UMG.ComboBoxString")]
	[UnrealStructLayout(4576, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 4576)]
	public class UComboBoxString : UWidget, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600B9D1 RID: 47569 RVA: 0x00129875 File Offset: 0x00127A75
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UComboBoxString._ClassPtr;
		}

		// Token: 0x0600B9D2 RID: 47570 RVA: 0x00129884 File Offset: 0x00127A84
		public UComboBoxString() : this(BuiltinUtils.AllocNativeUObject(UComboBoxString.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600B9D3 RID: 47571 RVA: 0x001298AC File Offset: 0x00127AAC
		public UComboBoxString(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UComboBoxString.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002292 RID: 8850
		// (get) Token: 0x0600B9D4 RID: 47572 RVA: 0x001298E0 File Offset: 0x00127AE0
		// (set) Token: 0x0600B9D5 RID: 47573 RVA: 0x00129919 File Offset: 0x00127B19
		public TArray<string> DefaultOptions
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._DefaultOptions) == null)
				{
					result = (this._DefaultOptions = new TArray<string>(base.NativePtr + (IntPtr)UComboBoxString.__PropertyOffset_DefaultOptions, this));
				}
				return result;
			}
			set
			{
				this.DefaultOptions.CopyAssign(value);
			}
		}

		// Token: 0x17002293 RID: 8851
		// (get) Token: 0x0600B9D6 RID: 47574 RVA: 0x00129927 File Offset: 0x00127B27
		// (set) Token: 0x0600B9D7 RID: 47575 RVA: 0x0012993B File Offset: 0x00127B3B
		public unsafe string SelectedOption
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UComboBoxString.__PropertyOffset_SelectedOption)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UComboBoxString.__PropertyOffset_SelectedOption)), value);
			}
		}

		// Token: 0x17002294 RID: 8852
		// (get) Token: 0x0600B9D8 RID: 47576 RVA: 0x00129950 File Offset: 0x00127B50
		// (set) Token: 0x0600B9D9 RID: 47577 RVA: 0x00129964 File Offset: 0x00127B64
		public unsafe FMargin ContentPadding
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UComboBoxString.__PropertyOffset_ContentPadding);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UComboBoxString.__PropertyOffset_ContentPadding) = value;
			}
		}

		// Token: 0x17002295 RID: 8853
		// (get) Token: 0x0600B9DA RID: 47578 RVA: 0x00129979 File Offset: 0x00127B79
		// (set) Token: 0x0600B9DB RID: 47579 RVA: 0x00129989 File Offset: 0x00127B89
		public unsafe float MaxListHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UComboBoxString.__PropertyOffset_MaxListHeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UComboBoxString.__PropertyOffset_MaxListHeight) = value;
			}
		}

		// Token: 0x17002296 RID: 8854
		// (get) Token: 0x0600B9DC RID: 47580 RVA: 0x0012999A File Offset: 0x00127B9A
		// (set) Token: 0x0600B9DD RID: 47581 RVA: 0x001299AA File Offset: 0x00127BAA
		public unsafe bool HasDownArrow
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UComboBoxString.__PropertyOffset_HasDownArrow) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UComboBoxString.__PropertyOffset_HasDownArrow) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002297 RID: 8855
		// (get) Token: 0x0600B9DE RID: 47582 RVA: 0x001299BB File Offset: 0x00127BBB
		// (set) Token: 0x0600B9DF RID: 47583 RVA: 0x001299CB File Offset: 0x00127BCB
		public unsafe bool EnableGamepadNavigationMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UComboBoxString.__PropertyOffset_EnableGamepadNavigationMode) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UComboBoxString.__PropertyOffset_EnableGamepadNavigationMode) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002298 RID: 8856
		// (get) Token: 0x0600B9E0 RID: 47584 RVA: 0x001299DC File Offset: 0x00127BDC
		// (set) Token: 0x0600B9E1 RID: 47585 RVA: 0x00129A15 File Offset: 0x00127C15
		public FSlateFontInfo Font
		{
			get
			{
				base.FastCheckIsValid();
				FSlateFontInfo result;
				if ((result = this._Font) == null)
				{
					result = (this._Font = new FSlateFontInfo(base.NativePtr + (IntPtr)UComboBoxString.__PropertyOffset_Font, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateFontInfo.StaticStruct(), base.NativePtr + (IntPtr)UComboBoxString.__PropertyOffset_Font, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002299 RID: 8857
		// (get) Token: 0x0600B9E2 RID: 47586 RVA: 0x00129A38 File Offset: 0x00127C38
		// (set) Token: 0x0600B9E3 RID: 47587 RVA: 0x00129A71 File Offset: 0x00127C71
		public FSlateColor ForegroundColor
		{
			get
			{
				base.FastCheckIsValid();
				FSlateColor result;
				if ((result = this._ForegroundColor) == null)
				{
					result = (this._ForegroundColor = new FSlateColor(base.NativePtr + (IntPtr)UComboBoxString.__PropertyOffset_ForegroundColor, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateColor.StaticStruct(), base.NativePtr + (IntPtr)UComboBoxString.__PropertyOffset_ForegroundColor, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700229A RID: 8858
		// (get) Token: 0x0600B9E4 RID: 47588 RVA: 0x00129A92 File Offset: 0x00127C92
		// (set) Token: 0x0600B9E5 RID: 47589 RVA: 0x00129AA2 File Offset: 0x00127CA2
		public unsafe bool bIsFocusable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UComboBoxString.__PropertyOffset_bIsFocusable) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UComboBoxString.__PropertyOffset_bIsFocusable) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700229B RID: 8859
		// (get) Token: 0x0600B9E6 RID: 47590 RVA: 0x00129AB4 File Offset: 0x00127CB4
		// (set) Token: 0x0600B9E7 RID: 47591 RVA: 0x00129AED File Offset: 0x00127CED
		public FGenerateWidgetForString OnGenerateWidgetEvent
		{
			get
			{
				base.FastCheckIsValid();
				FGenerateWidgetForString result;
				if ((result = this._OnGenerateWidgetEvent) == null)
				{
					result = (this._OnGenerateWidgetEvent = new FGenerateWidgetForString(base.NativePtr + (IntPtr)UComboBoxString.__PropertyOffset_OnGenerateWidgetEvent, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UComboBoxString.__PropertyOffset_OnGenerateWidgetEvent, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700229C RID: 8860
		// (get) Token: 0x0600B9E8 RID: 47592 RVA: 0x00129B10 File Offset: 0x00127D10
		// (set) Token: 0x0600B9E9 RID: 47593 RVA: 0x00129B49 File Offset: 0x00127D49
		public FOnOpeningEvent OnOpening
		{
			get
			{
				base.FastCheckIsValid();
				FOnOpeningEvent result;
				if ((result = this._OnOpening) == null)
				{
					result = (this._OnOpening = new FOnOpeningEvent(base.NativePtr + (IntPtr)UComboBoxString.__PropertyOffset_OnOpening, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UComboBoxString.__PropertyOffset_OnOpening, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x0600B9EA RID: 47594 RVA: 0x00129B6C File Offset: 0x00127D6C
		public unsafe void SetSelectedOption(string Option)
		{
			FString fstring = FString.AllocTemp(Option);
			UComboBoxString.__SetSelectedOption_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0600B9EB RID: 47595 RVA: 0x00129B96 File Offset: 0x00127D96
		public void SetSelectedIndex(int Index)
		{
			UComboBoxString.__SetSelectedIndex_Internal(base.NativePtr, Index);
		}

		// Token: 0x0600B9EC RID: 47596 RVA: 0x00129BA4 File Offset: 0x00127DA4
		public unsafe bool RemoveOption(string Option)
		{
			FString fstring = FString.AllocTemp(Option);
			bool result = UComboBoxString.__RemoveOption_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0600B9ED RID: 47597 RVA: 0x00129BCE File Offset: 0x00127DCE
		public void RefreshOptions()
		{
			UComboBoxString.__RefreshOptions_Internal(base.NativePtr);
		}

		// Token: 0x0600B9EE RID: 47598 RVA: 0x00129BDB File Offset: 0x00127DDB
		public bool IsOpen()
		{
			return UComboBoxString.__IsOpen_Internal(base.NativePtr);
		}

		// Token: 0x0600B9EF RID: 47599 RVA: 0x00129BE8 File Offset: 0x00127DE8
		public string GetSelectedOption()
		{
			return FString.ToStringAndDeleteNativePtr(UComboBoxString.__GetSelectedOption_Internal(base.NativePtr));
		}

		// Token: 0x0600B9F0 RID: 47600 RVA: 0x00129BFA File Offset: 0x00127DFA
		public int GetSelectedIndex()
		{
			return UComboBoxString.__GetSelectedIndex_Internal(base.NativePtr);
		}

		// Token: 0x0600B9F1 RID: 47601 RVA: 0x00129C07 File Offset: 0x00127E07
		public int GetOptionCount()
		{
			return UComboBoxString.__GetOptionCount_Internal(base.NativePtr);
		}

		// Token: 0x0600B9F2 RID: 47602 RVA: 0x00129C14 File Offset: 0x00127E14
		public string GetOptionAtIndex(int Index)
		{
			return FString.ToStringAndDeleteNativePtr(UComboBoxString.__GetOptionAtIndex_Internal(base.NativePtr, Index));
		}

		// Token: 0x0600B9F3 RID: 47603 RVA: 0x00129C28 File Offset: 0x00127E28
		public unsafe int FindOptionIndex(string Option)
		{
			FString fstring = FString.AllocTemp(Option);
			int result = UComboBoxString.__FindOptionIndex_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0600B9F4 RID: 47604 RVA: 0x00129C52 File Offset: 0x00127E52
		public void ClearSelection()
		{
			UComboBoxString.__ClearSelection_Internal(base.NativePtr);
		}

		// Token: 0x0600B9F5 RID: 47605 RVA: 0x00129C5F File Offset: 0x00127E5F
		public void ClearOptions()
		{
			UComboBoxString.__ClearOptions_Internal(base.NativePtr);
		}

		// Token: 0x0600B9F6 RID: 47606 RVA: 0x00129C6C File Offset: 0x00127E6C
		public unsafe void AddOption(string Option)
		{
			FString fstring = FString.AllocTemp(Option);
			UComboBoxString.__AddOption_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0600B9F7 RID: 47607
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSelectedOption_Internal(IntPtr @this, in FString Option);

		// Token: 0x0600B9F8 RID: 47608
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSelectedIndex_Internal(IntPtr @this, int Index);

		// Token: 0x0600B9F9 RID: 47609
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __RemoveOption_Internal(IntPtr @this, in FString Option);

		// Token: 0x0600B9FA RID: 47610
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RefreshOptions_Internal(IntPtr @this);

		// Token: 0x0600B9FB RID: 47611
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsOpen_Internal(IntPtr @this);

		// Token: 0x0600B9FC RID: 47612
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetSelectedOption_Internal(IntPtr @this);

		// Token: 0x0600B9FD RID: 47613
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetSelectedIndex_Internal(IntPtr @this);

		// Token: 0x0600B9FE RID: 47614
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetOptionCount_Internal(IntPtr @this);

		// Token: 0x0600B9FF RID: 47615
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetOptionAtIndex_Internal(IntPtr @this, int Index);

		// Token: 0x0600BA00 RID: 47616
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __FindOptionIndex_Internal(IntPtr @this, in FString Option);

		// Token: 0x0600BA01 RID: 47617
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearSelection_Internal(IntPtr @this);

		// Token: 0x0600BA02 RID: 47618
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearOptions_Internal(IntPtr @this);

		// Token: 0x0600BA03 RID: 47619
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddOption_Internal(IntPtr @this, in FString Option);

		// Token: 0x0600BA04 RID: 47620 RVA: 0x00129C96 File Offset: 0x00127E96
		static UComboBoxString()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/UMG.ComboBoxString");
		}

		// Token: 0x0600BA05 RID: 47621 RVA: 0x00129CA4 File Offset: 0x00127EA4
		protected UComboBoxString(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400545F RID: 21599
		public new const string __ObjectPath = "/Script/UMG.ComboBoxString";

		// Token: 0x04005460 RID: 21600
		private static IntPtr _ClassPtr;

		// Token: 0x04005461 RID: 21601
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04005462 RID: 21602
		public static IntPtr __OnSelectionChangedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04005463 RID: 21603
		public static IntPtr __OnOpeningEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04005464 RID: 21604
		internal static int __PropertyOffset_DefaultOptions;

		// Token: 0x04005465 RID: 21605
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _DefaultOptions;

		// Token: 0x04005466 RID: 21606
		internal static int __PropertyOffset_SelectedOption;

		// Token: 0x04005467 RID: 21607
		internal static int __PropertyOffset_ContentPadding;

		// Token: 0x04005468 RID: 21608
		internal static int __PropertyOffset_MaxListHeight;

		// Token: 0x04005469 RID: 21609
		internal static int __PropertyOffset_HasDownArrow;

		// Token: 0x0400546A RID: 21610
		internal static int __PropertyOffset_EnableGamepadNavigationMode;

		// Token: 0x0400546B RID: 21611
		internal static int __PropertyOffset_Font;

		// Token: 0x0400546C RID: 21612
		[Nullable(2)]
		private FSlateFontInfo _Font;

		// Token: 0x0400546D RID: 21613
		internal static int __PropertyOffset_ForegroundColor;

		// Token: 0x0400546E RID: 21614
		[Nullable(2)]
		private FSlateColor _ForegroundColor;

		// Token: 0x0400546F RID: 21615
		internal static int __PropertyOffset_bIsFocusable;

		// Token: 0x04005470 RID: 21616
		internal static int __PropertyOffset_OnGenerateWidgetEvent;

		// Token: 0x04005471 RID: 21617
		[Nullable(2)]
		private FGenerateWidgetForString _OnGenerateWidgetEvent;

		// Token: 0x04005472 RID: 21618
		internal static int __PropertyOffset_OnOpening;

		// Token: 0x04005473 RID: 21619
		[Nullable(2)]
		private FOnOpeningEvent _OnOpening;
	}
}
