using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002949 RID: 10569
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/UMG.ComboBoxString")]
	[UnrealStructLayout(4576, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 4576)]
	public class UComboBoxString : UWidget, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060271FB RID: 160251 RVA: 0x003BA6A6 File Offset: 0x003B88A6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UComboBoxString._ClassPtr;
		}

		// Token: 0x060271FC RID: 160252 RVA: 0x003BA6B4 File Offset: 0x003B88B4
		public UComboBoxString() : this(BuiltinUtils.AllocNativeUObject(UComboBoxString.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060271FD RID: 160253 RVA: 0x003BA6DC File Offset: 0x003B88DC
		public UComboBoxString(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UComboBoxString.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17009681 RID: 38529
		// (get) Token: 0x060271FE RID: 160254 RVA: 0x003BA710 File Offset: 0x003B8910
		// (set) Token: 0x060271FF RID: 160255 RVA: 0x003BA749 File Offset: 0x003B8949
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

		// Token: 0x17009682 RID: 38530
		// (get) Token: 0x06027200 RID: 160256 RVA: 0x003BA757 File Offset: 0x003B8957
		// (set) Token: 0x06027201 RID: 160257 RVA: 0x003BA76B File Offset: 0x003B896B
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

		// Token: 0x17009683 RID: 38531
		// (get) Token: 0x06027202 RID: 160258 RVA: 0x003BA780 File Offset: 0x003B8980
		// (set) Token: 0x06027203 RID: 160259 RVA: 0x003BA7B9 File Offset: 0x003B89B9
		public FComboBoxStyle WidgetStyle
		{
			get
			{
				base.FastCheckIsValid();
				FComboBoxStyle result;
				if ((result = this._WidgetStyle) == null)
				{
					result = (this._WidgetStyle = new FComboBoxStyle(base.NativePtr + (IntPtr)UComboBoxString.__PropertyOffset_WidgetStyle, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FComboBoxStyle.StaticStruct(), base.NativePtr + (IntPtr)UComboBoxString.__PropertyOffset_WidgetStyle, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17009684 RID: 38532
		// (get) Token: 0x06027204 RID: 160260 RVA: 0x003BA7DC File Offset: 0x003B89DC
		// (set) Token: 0x06027205 RID: 160261 RVA: 0x003BA815 File Offset: 0x003B8A15
		public FTableRowStyle ItemStyle
		{
			get
			{
				base.FastCheckIsValid();
				FTableRowStyle result;
				if ((result = this._ItemStyle) == null)
				{
					result = (this._ItemStyle = new FTableRowStyle(base.NativePtr + (IntPtr)UComboBoxString.__PropertyOffset_ItemStyle, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FTableRowStyle.StaticStruct(), base.NativePtr + (IntPtr)UComboBoxString.__PropertyOffset_ItemStyle, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17009685 RID: 38533
		// (get) Token: 0x06027206 RID: 160262 RVA: 0x003BA836 File Offset: 0x003B8A36
		// (set) Token: 0x06027207 RID: 160263 RVA: 0x003BA84A File Offset: 0x003B8A4A
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

		// Token: 0x17009686 RID: 38534
		// (get) Token: 0x06027208 RID: 160264 RVA: 0x003BA85F File Offset: 0x003B8A5F
		// (set) Token: 0x06027209 RID: 160265 RVA: 0x003BA86F File Offset: 0x003B8A6F
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

		// Token: 0x17009687 RID: 38535
		// (get) Token: 0x0602720A RID: 160266 RVA: 0x003BA880 File Offset: 0x003B8A80
		// (set) Token: 0x0602720B RID: 160267 RVA: 0x003BA890 File Offset: 0x003B8A90
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

		// Token: 0x17009688 RID: 38536
		// (get) Token: 0x0602720C RID: 160268 RVA: 0x003BA8A1 File Offset: 0x003B8AA1
		// (set) Token: 0x0602720D RID: 160269 RVA: 0x003BA8B1 File Offset: 0x003B8AB1
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

		// Token: 0x17009689 RID: 38537
		// (get) Token: 0x0602720E RID: 160270 RVA: 0x003BA8C4 File Offset: 0x003B8AC4
		// (set) Token: 0x0602720F RID: 160271 RVA: 0x003BA8FD File Offset: 0x003B8AFD
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

		// Token: 0x1700968A RID: 38538
		// (get) Token: 0x06027210 RID: 160272 RVA: 0x003BA920 File Offset: 0x003B8B20
		// (set) Token: 0x06027211 RID: 160273 RVA: 0x003BA959 File Offset: 0x003B8B59
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

		// Token: 0x1700968B RID: 38539
		// (get) Token: 0x06027212 RID: 160274 RVA: 0x003BA97A File Offset: 0x003B8B7A
		// (set) Token: 0x06027213 RID: 160275 RVA: 0x003BA98A File Offset: 0x003B8B8A
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

		// Token: 0x1700968C RID: 38540
		// (get) Token: 0x06027214 RID: 160276 RVA: 0x003BA99C File Offset: 0x003B8B9C
		// (set) Token: 0x06027215 RID: 160277 RVA: 0x003BA9D5 File Offset: 0x003B8BD5
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

		// Token: 0x1700968D RID: 38541
		// (get) Token: 0x06027216 RID: 160278 RVA: 0x003BA9F8 File Offset: 0x003B8BF8
		// (set) Token: 0x06027217 RID: 160279 RVA: 0x003BAA31 File Offset: 0x003B8C31
		public FOnSelectionChangedEvent OnSelectionChanged
		{
			get
			{
				base.FastCheckIsValid();
				FOnSelectionChangedEvent result;
				if ((result = this._OnSelectionChanged) == null)
				{
					result = (this._OnSelectionChanged = new FOnSelectionChangedEvent(base.NativePtr + (IntPtr)UComboBoxString.__PropertyOffset_OnSelectionChanged, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UComboBoxString.__PropertyOffset_OnSelectionChanged, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700968E RID: 38542
		// (get) Token: 0x06027218 RID: 160280 RVA: 0x003BAA54 File Offset: 0x003B8C54
		// (set) Token: 0x06027219 RID: 160281 RVA: 0x003BAA8D File Offset: 0x003B8C8D
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

		// Token: 0x0602721A RID: 160282 RVA: 0x003BAAB0 File Offset: 0x003B8CB0
		public unsafe void SetSelectedOption(string Option)
		{
			FString fstring = FString.AllocTemp(Option);
			UComboBoxString.__SetSelectedOption_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0602721B RID: 160283 RVA: 0x003BAADA File Offset: 0x003B8CDA
		public void SetSelectedIndex(int Index)
		{
			UComboBoxString.__SetSelectedIndex_Internal(base.NativePtr, Index);
		}

		// Token: 0x0602721C RID: 160284 RVA: 0x003BAAE8 File Offset: 0x003B8CE8
		public unsafe bool RemoveOption(string Option)
		{
			FString fstring = FString.AllocTemp(Option);
			bool result = UComboBoxString.__RemoveOption_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0602721D RID: 160285 RVA: 0x003BAB12 File Offset: 0x003B8D12
		public void RefreshOptions()
		{
			UComboBoxString.__RefreshOptions_Internal(base.NativePtr);
		}

		// Token: 0x0602721E RID: 160286 RVA: 0x003BAB1F File Offset: 0x003B8D1F
		public bool IsOpen()
		{
			return UComboBoxString.__IsOpen_Internal(base.NativePtr);
		}

		// Token: 0x0602721F RID: 160287 RVA: 0x003BAB2C File Offset: 0x003B8D2C
		public string GetSelectedOption()
		{
			return FString.ToStringAndDeleteNativePtr(UComboBoxString.__GetSelectedOption_Internal(base.NativePtr));
		}

		// Token: 0x06027220 RID: 160288 RVA: 0x003BAB3E File Offset: 0x003B8D3E
		public int GetSelectedIndex()
		{
			return UComboBoxString.__GetSelectedIndex_Internal(base.NativePtr);
		}

		// Token: 0x06027221 RID: 160289 RVA: 0x003BAB4B File Offset: 0x003B8D4B
		public int GetOptionCount()
		{
			return UComboBoxString.__GetOptionCount_Internal(base.NativePtr);
		}

		// Token: 0x06027222 RID: 160290 RVA: 0x003BAB58 File Offset: 0x003B8D58
		public string GetOptionAtIndex(int Index)
		{
			return FString.ToStringAndDeleteNativePtr(UComboBoxString.__GetOptionAtIndex_Internal(base.NativePtr, Index));
		}

		// Token: 0x06027223 RID: 160291 RVA: 0x003BAB6C File Offset: 0x003B8D6C
		public unsafe int FindOptionIndex(string Option)
		{
			FString fstring = FString.AllocTemp(Option);
			int result = UComboBoxString.__FindOptionIndex_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06027224 RID: 160292 RVA: 0x003BAB96 File Offset: 0x003B8D96
		public void ClearSelection()
		{
			UComboBoxString.__ClearSelection_Internal(base.NativePtr);
		}

		// Token: 0x06027225 RID: 160293 RVA: 0x003BABA3 File Offset: 0x003B8DA3
		public void ClearOptions()
		{
			UComboBoxString.__ClearOptions_Internal(base.NativePtr);
		}

		// Token: 0x06027226 RID: 160294 RVA: 0x003BABB0 File Offset: 0x003B8DB0
		public unsafe void AddOption(string Option)
		{
			FString fstring = FString.AllocTemp(Option);
			UComboBoxString.__AddOption_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06027227 RID: 160295
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSelectedOption_Internal(IntPtr @this, in FString Option);

		// Token: 0x06027228 RID: 160296
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSelectedIndex_Internal(IntPtr @this, int Index);

		// Token: 0x06027229 RID: 160297
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __RemoveOption_Internal(IntPtr @this, in FString Option);

		// Token: 0x0602722A RID: 160298
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RefreshOptions_Internal(IntPtr @this);

		// Token: 0x0602722B RID: 160299
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsOpen_Internal(IntPtr @this);

		// Token: 0x0602722C RID: 160300
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetSelectedOption_Internal(IntPtr @this);

		// Token: 0x0602722D RID: 160301
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetSelectedIndex_Internal(IntPtr @this);

		// Token: 0x0602722E RID: 160302
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetOptionCount_Internal(IntPtr @this);

		// Token: 0x0602722F RID: 160303
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetOptionAtIndex_Internal(IntPtr @this, int Index);

		// Token: 0x06027230 RID: 160304
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __FindOptionIndex_Internal(IntPtr @this, in FString Option);

		// Token: 0x06027231 RID: 160305
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearSelection_Internal(IntPtr @this);

		// Token: 0x06027232 RID: 160306
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearOptions_Internal(IntPtr @this);

		// Token: 0x06027233 RID: 160307
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddOption_Internal(IntPtr @this, in FString Option);

		// Token: 0x06027234 RID: 160308 RVA: 0x003BABDA File Offset: 0x003B8DDA
		static UComboBoxString()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/UMG.ComboBoxString");
		}

		// Token: 0x06027235 RID: 160309 RVA: 0x003BABE8 File Offset: 0x003B8DE8
		protected UComboBoxString(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040157C9 RID: 88009
		public new const string __ObjectPath = "/Script/UMG.ComboBoxString";

		// Token: 0x040157CA RID: 88010
		private static IntPtr _ClassPtr;

		// Token: 0x040157CB RID: 88011
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040157CC RID: 88012
		public static IntPtr __OnSelectionChangedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x040157CD RID: 88013
		public static IntPtr __OnOpeningEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x040157CE RID: 88014
		internal static int __PropertyOffset_DefaultOptions;

		// Token: 0x040157CF RID: 88015
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _DefaultOptions;

		// Token: 0x040157D0 RID: 88016
		internal static int __PropertyOffset_SelectedOption;

		// Token: 0x040157D1 RID: 88017
		internal static int __PropertyOffset_WidgetStyle;

		// Token: 0x040157D2 RID: 88018
		[Nullable(2)]
		private FComboBoxStyle _WidgetStyle;

		// Token: 0x040157D3 RID: 88019
		internal static int __PropertyOffset_ItemStyle;

		// Token: 0x040157D4 RID: 88020
		[Nullable(2)]
		private FTableRowStyle _ItemStyle;

		// Token: 0x040157D5 RID: 88021
		internal static int __PropertyOffset_ContentPadding;

		// Token: 0x040157D6 RID: 88022
		internal static int __PropertyOffset_MaxListHeight;

		// Token: 0x040157D7 RID: 88023
		internal static int __PropertyOffset_HasDownArrow;

		// Token: 0x040157D8 RID: 88024
		internal static int __PropertyOffset_EnableGamepadNavigationMode;

		// Token: 0x040157D9 RID: 88025
		internal static int __PropertyOffset_Font;

		// Token: 0x040157DA RID: 88026
		[Nullable(2)]
		private FSlateFontInfo _Font;

		// Token: 0x040157DB RID: 88027
		internal static int __PropertyOffset_ForegroundColor;

		// Token: 0x040157DC RID: 88028
		[Nullable(2)]
		private FSlateColor _ForegroundColor;

		// Token: 0x040157DD RID: 88029
		internal static int __PropertyOffset_bIsFocusable;

		// Token: 0x040157DE RID: 88030
		internal static int __PropertyOffset_OnGenerateWidgetEvent;

		// Token: 0x040157DF RID: 88031
		[Nullable(2)]
		private FGenerateWidgetForString _OnGenerateWidgetEvent;

		// Token: 0x040157E0 RID: 88032
		internal static int __PropertyOffset_OnSelectionChanged;

		// Token: 0x040157E1 RID: 88033
		[Nullable(2)]
		private FOnSelectionChangedEvent _OnSelectionChanged;

		// Token: 0x040157E2 RID: 88034
		internal static int __PropertyOffset_OnOpening;

		// Token: 0x040157E3 RID: 88035
		[Nullable(2)]
		private FOnOpeningEvent _OnOpening;
	}
}
