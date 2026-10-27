using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200293F RID: 10559
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/UMG.Button")]
	[UnrealStructLayout(1592, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1592)]
	public class UButton : UContentWidget, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06027107 RID: 160007 RVA: 0x003B93F1 File Offset: 0x003B75F1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UButton._ClassPtr;
		}

		// Token: 0x06027108 RID: 160008 RVA: 0x003B9400 File Offset: 0x003B7600
		public UButton() : this(BuiltinUtils.AllocNativeUObject(UButton.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06027109 RID: 160009 RVA: 0x003B9428 File Offset: 0x003B7628
		public UButton(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UButton.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700964D RID: 38477
		// (get) Token: 0x0602710A RID: 160010 RVA: 0x003B945B File Offset: 0x003B765B
		// (set) Token: 0x0602710B RID: 160011 RVA: 0x003B946F File Offset: 0x003B766F
		[Nullable(2)]
		public unsafe USlateWidgetStyleAsset Style_DEPRECATED
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USlateWidgetStyleAsset>(base.NativePtr / (IntPtr)sizeof(void*) + UButton.__PropertyOffset_Style_DEPRECATED);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UButton.__PropertyOffset_Style_DEPRECATED, value);
			}
		}

		// Token: 0x1700964E RID: 38478
		// (get) Token: 0x0602710C RID: 160012 RVA: 0x003B9484 File Offset: 0x003B7684
		// (set) Token: 0x0602710D RID: 160013 RVA: 0x003B94BD File Offset: 0x003B76BD
		public FButtonStyle WidgetStyle
		{
			get
			{
				base.FastCheckIsValid();
				FButtonStyle result;
				if ((result = this._WidgetStyle) == null)
				{
					result = (this._WidgetStyle = new FButtonStyle(base.NativePtr + (IntPtr)UButton.__PropertyOffset_WidgetStyle, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FButtonStyle.StaticStruct(), base.NativePtr + (IntPtr)UButton.__PropertyOffset_WidgetStyle, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700964F RID: 38479
		// (get) Token: 0x0602710E RID: 160014 RVA: 0x003B94DE File Offset: 0x003B76DE
		// (set) Token: 0x0602710F RID: 160015 RVA: 0x003B94F2 File Offset: 0x003B76F2
		public unsafe FLinearColor ColorAndOpacity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UButton.__PropertyOffset_ColorAndOpacity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UButton.__PropertyOffset_ColorAndOpacity) = value;
			}
		}

		// Token: 0x17009650 RID: 38480
		// (get) Token: 0x06027110 RID: 160016 RVA: 0x003B9507 File Offset: 0x003B7707
		// (set) Token: 0x06027111 RID: 160017 RVA: 0x003B951B File Offset: 0x003B771B
		public unsafe FLinearColor BackgroundColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UButton.__PropertyOffset_BackgroundColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UButton.__PropertyOffset_BackgroundColor) = value;
			}
		}

		// Token: 0x17009651 RID: 38481
		// (get) Token: 0x06027112 RID: 160018 RVA: 0x003B9530 File Offset: 0x003B7730
		// (set) Token: 0x06027113 RID: 160019 RVA: 0x003B9544 File Offset: 0x003B7744
		[Nullable(0)]
		public unsafe TEnumAsByte<EButtonClickMethod> ClickMethod
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)UButton.__PropertyOffset_ClickMethod);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)UButton.__PropertyOffset_ClickMethod) = value;
			}
		}

		// Token: 0x17009652 RID: 38482
		// (get) Token: 0x06027114 RID: 160020 RVA: 0x003B9559 File Offset: 0x003B7759
		// (set) Token: 0x06027115 RID: 160021 RVA: 0x003B956D File Offset: 0x003B776D
		[Nullable(0)]
		public unsafe TEnumAsByte<EButtonTouchMethod> TouchMethod
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)UButton.__PropertyOffset_TouchMethod);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)UButton.__PropertyOffset_TouchMethod) = value;
			}
		}

		// Token: 0x17009653 RID: 38483
		// (get) Token: 0x06027116 RID: 160022 RVA: 0x003B9582 File Offset: 0x003B7782
		// (set) Token: 0x06027117 RID: 160023 RVA: 0x003B9596 File Offset: 0x003B7796
		[Nullable(0)]
		public unsafe TEnumAsByte<EButtonPressMethod> PressMethod
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)UButton.__PropertyOffset_PressMethod);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)UButton.__PropertyOffset_PressMethod) = value;
			}
		}

		// Token: 0x17009654 RID: 38484
		// (get) Token: 0x06027118 RID: 160024 RVA: 0x003B95AB File Offset: 0x003B77AB
		// (set) Token: 0x06027119 RID: 160025 RVA: 0x003B95BB File Offset: 0x003B77BB
		public unsafe bool IsFocusable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UButton.__PropertyOffset_IsFocusable) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UButton.__PropertyOffset_IsFocusable) = (value ? 1 : 0);
			}
		}

		// Token: 0x17009655 RID: 38485
		// (get) Token: 0x0602711A RID: 160026 RVA: 0x003B95CC File Offset: 0x003B77CC
		// (set) Token: 0x0602711B RID: 160027 RVA: 0x003B9605 File Offset: 0x003B7805
		public FOnButtonClickedEvent OnClicked
		{
			get
			{
				base.FastCheckIsValid();
				FOnButtonClickedEvent result;
				if ((result = this._OnClicked) == null)
				{
					result = (this._OnClicked = new FOnButtonClickedEvent(base.NativePtr + (IntPtr)UButton.__PropertyOffset_OnClicked, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UButton.__PropertyOffset_OnClicked, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17009656 RID: 38486
		// (get) Token: 0x0602711C RID: 160028 RVA: 0x003B9628 File Offset: 0x003B7828
		// (set) Token: 0x0602711D RID: 160029 RVA: 0x003B9661 File Offset: 0x003B7861
		public FOnButtonPressedEvent OnPressed
		{
			get
			{
				base.FastCheckIsValid();
				FOnButtonPressedEvent result;
				if ((result = this._OnPressed) == null)
				{
					result = (this._OnPressed = new FOnButtonPressedEvent(base.NativePtr + (IntPtr)UButton.__PropertyOffset_OnPressed, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UButton.__PropertyOffset_OnPressed, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17009657 RID: 38487
		// (get) Token: 0x0602711E RID: 160030 RVA: 0x003B9684 File Offset: 0x003B7884
		// (set) Token: 0x0602711F RID: 160031 RVA: 0x003B96BD File Offset: 0x003B78BD
		public FOnButtonReleasedEvent OnReleased
		{
			get
			{
				base.FastCheckIsValid();
				FOnButtonReleasedEvent result;
				if ((result = this._OnReleased) == null)
				{
					result = (this._OnReleased = new FOnButtonReleasedEvent(base.NativePtr + (IntPtr)UButton.__PropertyOffset_OnReleased, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UButton.__PropertyOffset_OnReleased, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17009658 RID: 38488
		// (get) Token: 0x06027120 RID: 160032 RVA: 0x003B96E0 File Offset: 0x003B78E0
		// (set) Token: 0x06027121 RID: 160033 RVA: 0x003B9719 File Offset: 0x003B7919
		public FOnButtonHoverEvent OnHovered
		{
			get
			{
				base.FastCheckIsValid();
				FOnButtonHoverEvent result;
				if ((result = this._OnHovered) == null)
				{
					result = (this._OnHovered = new FOnButtonHoverEvent(base.NativePtr + (IntPtr)UButton.__PropertyOffset_OnHovered, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UButton.__PropertyOffset_OnHovered, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17009659 RID: 38489
		// (get) Token: 0x06027122 RID: 160034 RVA: 0x003B973C File Offset: 0x003B793C
		// (set) Token: 0x06027123 RID: 160035 RVA: 0x003B9775 File Offset: 0x003B7975
		public FOnButtonHoverEvent OnUnhovered
		{
			get
			{
				base.FastCheckIsValid();
				FOnButtonHoverEvent result;
				if ((result = this._OnUnhovered) == null)
				{
					result = (this._OnUnhovered = new FOnButtonHoverEvent(base.NativePtr + (IntPtr)UButton.__PropertyOffset_OnUnhovered, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UButton.__PropertyOffset_OnUnhovered, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x06027124 RID: 160036 RVA: 0x003B9796 File Offset: 0x003B7996
		public void SetTouchMethod(EButtonTouchMethod InTouchMethod)
		{
			UButton.__SetTouchMethod_Internal(base.NativePtr, InTouchMethod);
		}

		// Token: 0x06027125 RID: 160037 RVA: 0x003B97A9 File Offset: 0x003B79A9
		[NullableContext(2)]
		public void SetStyle(in FButtonStyle InStyle)
		{
			UButton.__SetStyle_Internal(base.NativePtr, (InStyle ?? new FButtonStyle()).NativePtr);
		}

		// Token: 0x06027126 RID: 160038 RVA: 0x003B97C6 File Offset: 0x003B79C6
		public void SetPressMethod(EButtonPressMethod InPressMethod)
		{
			UButton.__SetPressMethod_Internal(base.NativePtr, InPressMethod);
		}

		// Token: 0x06027127 RID: 160039 RVA: 0x003B97D9 File Offset: 0x003B79D9
		public void SetColorAndOpacity(FLinearColor InColorAndOpacity)
		{
			UButton.__SetColorAndOpacity_Internal(base.NativePtr, InColorAndOpacity);
		}

		// Token: 0x06027128 RID: 160040 RVA: 0x003B97E7 File Offset: 0x003B79E7
		public void SetClickMethod(EButtonClickMethod InClickMethod)
		{
			UButton.__SetClickMethod_Internal(base.NativePtr, InClickMethod);
		}

		// Token: 0x06027129 RID: 160041 RVA: 0x003B97FA File Offset: 0x003B79FA
		public void SetBackgroundColor(FLinearColor InBackgroundColor)
		{
			UButton.__SetBackgroundColor_Internal(base.NativePtr, InBackgroundColor);
		}

		// Token: 0x0602712A RID: 160042 RVA: 0x003B9808 File Offset: 0x003B7A08
		public bool IsPressed()
		{
			return UButton.__IsPressed_Internal(base.NativePtr);
		}

		// Token: 0x0602712B RID: 160043
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTouchMethod_Internal(IntPtr @this, TEnumAsByte<EButtonTouchMethod> InTouchMethod);

		// Token: 0x0602712C RID: 160044
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetStyle_Internal(IntPtr @this, IntPtr InStyle);

		// Token: 0x0602712D RID: 160045
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPressMethod_Internal(IntPtr @this, TEnumAsByte<EButtonPressMethod> InPressMethod);

		// Token: 0x0602712E RID: 160046
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetColorAndOpacity_Internal(IntPtr @this, FLinearColor InColorAndOpacity);

		// Token: 0x0602712F RID: 160047
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetClickMethod_Internal(IntPtr @this, TEnumAsByte<EButtonClickMethod> InClickMethod);

		// Token: 0x06027130 RID: 160048
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBackgroundColor_Internal(IntPtr @this, FLinearColor InBackgroundColor);

		// Token: 0x06027131 RID: 160049
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsPressed_Internal(IntPtr @this);

		// Token: 0x06027132 RID: 160050 RVA: 0x003B9815 File Offset: 0x003B7A15
		static UButton()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/UMG.Button");
		}

		// Token: 0x06027133 RID: 160051 RVA: 0x003B9823 File Offset: 0x003B7A23
		protected UButton(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015768 RID: 87912
		public new const string __ObjectPath = "/Script/UMG.Button";

		// Token: 0x04015769 RID: 87913
		private static IntPtr _ClassPtr;

		// Token: 0x0401576A RID: 87914
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401576B RID: 87915
		internal static int __PropertyOffset_Style_DEPRECATED;

		// Token: 0x0401576C RID: 87916
		internal static int __PropertyOffset_WidgetStyle;

		// Token: 0x0401576D RID: 87917
		[Nullable(2)]
		private FButtonStyle _WidgetStyle;

		// Token: 0x0401576E RID: 87918
		internal static int __PropertyOffset_ColorAndOpacity;

		// Token: 0x0401576F RID: 87919
		internal static int __PropertyOffset_BackgroundColor;

		// Token: 0x04015770 RID: 87920
		internal static int __PropertyOffset_ClickMethod;

		// Token: 0x04015771 RID: 87921
		internal static int __PropertyOffset_TouchMethod;

		// Token: 0x04015772 RID: 87922
		internal static int __PropertyOffset_PressMethod;

		// Token: 0x04015773 RID: 87923
		internal static int __PropertyOffset_IsFocusable;

		// Token: 0x04015774 RID: 87924
		internal static int __PropertyOffset_OnClicked;

		// Token: 0x04015775 RID: 87925
		[Nullable(2)]
		private FOnButtonClickedEvent _OnClicked;

		// Token: 0x04015776 RID: 87926
		internal static int __PropertyOffset_OnPressed;

		// Token: 0x04015777 RID: 87927
		[Nullable(2)]
		private FOnButtonPressedEvent _OnPressed;

		// Token: 0x04015778 RID: 87928
		internal static int __PropertyOffset_OnReleased;

		// Token: 0x04015779 RID: 87929
		[Nullable(2)]
		private FOnButtonReleasedEvent _OnReleased;

		// Token: 0x0401577A RID: 87930
		internal static int __PropertyOffset_OnHovered;

		// Token: 0x0401577B RID: 87931
		[Nullable(2)]
		private FOnButtonHoverEvent _OnHovered;

		// Token: 0x0401577C RID: 87932
		internal static int __PropertyOffset_OnUnhovered;

		// Token: 0x0401577D RID: 87933
		[Nullable(2)]
		private FOnButtonHoverEvent _OnUnhovered;
	}
}
