using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020029D1 RID: 10705
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/UMG.ScrollBox")]
	[UnrealStructLayout(2896, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2896)]
	public class UScrollBox : UPanelWidget, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602793C RID: 162108 RVA: 0x003C6082 File Offset: 0x003C4282
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UScrollBox._ClassPtr;
		}

		// Token: 0x0602793D RID: 162109 RVA: 0x003C6090 File Offset: 0x003C4290
		public UScrollBox() : this(BuiltinUtils.AllocNativeUObject(UScrollBox.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602793E RID: 162110 RVA: 0x003C60B8 File Offset: 0x003C42B8
		public UScrollBox(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UScrollBox.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170097A8 RID: 38824
		// (get) Token: 0x0602793F RID: 162111 RVA: 0x003C60EC File Offset: 0x003C42EC
		// (set) Token: 0x06027940 RID: 162112 RVA: 0x003C6125 File Offset: 0x003C4325
		public FScrollBoxStyle WidgetStyle
		{
			get
			{
				base.FastCheckIsValid();
				FScrollBoxStyle result;
				if ((result = this._WidgetStyle) == null)
				{
					result = (this._WidgetStyle = new FScrollBoxStyle(base.NativePtr + (IntPtr)UScrollBox.__PropertyOffset_WidgetStyle, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FScrollBoxStyle.StaticStruct(), base.NativePtr + (IntPtr)UScrollBox.__PropertyOffset_WidgetStyle, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170097A9 RID: 38825
		// (get) Token: 0x06027941 RID: 162113 RVA: 0x003C6148 File Offset: 0x003C4348
		// (set) Token: 0x06027942 RID: 162114 RVA: 0x003C6181 File Offset: 0x003C4381
		public FScrollBarStyle WidgetBarStyle
		{
			get
			{
				base.FastCheckIsValid();
				FScrollBarStyle result;
				if ((result = this._WidgetBarStyle) == null)
				{
					result = (this._WidgetBarStyle = new FScrollBarStyle(base.NativePtr + (IntPtr)UScrollBox.__PropertyOffset_WidgetBarStyle, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FScrollBarStyle.StaticStruct(), base.NativePtr + (IntPtr)UScrollBox.__PropertyOffset_WidgetBarStyle, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170097AA RID: 38826
		// (get) Token: 0x06027943 RID: 162115 RVA: 0x003C61A2 File Offset: 0x003C43A2
		// (set) Token: 0x06027944 RID: 162116 RVA: 0x003C61B6 File Offset: 0x003C43B6
		[Nullable(2)]
		public unsafe USlateWidgetStyleAsset Style_DEPRECATED
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USlateWidgetStyleAsset>(base.NativePtr / (IntPtr)sizeof(void*) + UScrollBox.__PropertyOffset_Style_DEPRECATED);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UScrollBox.__PropertyOffset_Style_DEPRECATED, value);
			}
		}

		// Token: 0x170097AB RID: 38827
		// (get) Token: 0x06027945 RID: 162117 RVA: 0x003C61CB File Offset: 0x003C43CB
		// (set) Token: 0x06027946 RID: 162118 RVA: 0x003C61DF File Offset: 0x003C43DF
		[Nullable(2)]
		public unsafe USlateWidgetStyleAsset BarStyle_DEPRECATED
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USlateWidgetStyleAsset>(base.NativePtr / (IntPtr)sizeof(void*) + UScrollBox.__PropertyOffset_BarStyle_DEPRECATED);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UScrollBox.__PropertyOffset_BarStyle_DEPRECATED, value);
			}
		}

		// Token: 0x170097AC RID: 38828
		// (get) Token: 0x06027947 RID: 162119 RVA: 0x003C61F4 File Offset: 0x003C43F4
		// (set) Token: 0x06027948 RID: 162120 RVA: 0x003C6208 File Offset: 0x003C4408
		[Nullable(0)]
		public unsafe TEnumAsByte<EOrientation> Orientation
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)UScrollBox.__PropertyOffset_Orientation);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)UScrollBox.__PropertyOffset_Orientation) = value;
			}
		}

		// Token: 0x170097AD RID: 38829
		// (get) Token: 0x06027949 RID: 162121 RVA: 0x003C621D File Offset: 0x003C441D
		// (set) Token: 0x0602794A RID: 162122 RVA: 0x003C622D File Offset: 0x003C442D
		public unsafe ESlateVisibility ScrollBarVisibility
		{
			get
			{
				return (ESlateVisibility)(*(base.NativePtr + (IntPtr)UScrollBox.__PropertyOffset_ScrollBarVisibility));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UScrollBox.__PropertyOffset_ScrollBarVisibility) = (byte)value;
			}
		}

		// Token: 0x170097AE RID: 38830
		// (get) Token: 0x0602794B RID: 162123 RVA: 0x003C623E File Offset: 0x003C443E
		// (set) Token: 0x0602794C RID: 162124 RVA: 0x003C624E File Offset: 0x003C444E
		public unsafe EConsumeMouseWheel ConsumeMouseWheel
		{
			get
			{
				return (EConsumeMouseWheel)(*(base.NativePtr + (IntPtr)UScrollBox.__PropertyOffset_ConsumeMouseWheel));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UScrollBox.__PropertyOffset_ConsumeMouseWheel) = (byte)value;
			}
		}

		// Token: 0x170097AF RID: 38831
		// (get) Token: 0x0602794D RID: 162125 RVA: 0x003C625F File Offset: 0x003C445F
		// (set) Token: 0x0602794E RID: 162126 RVA: 0x003C6273 File Offset: 0x003C4473
		public unsafe FVector2D ScrollbarThickness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UScrollBox.__PropertyOffset_ScrollbarThickness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UScrollBox.__PropertyOffset_ScrollbarThickness) = value;
			}
		}

		// Token: 0x170097B0 RID: 38832
		// (get) Token: 0x0602794F RID: 162127 RVA: 0x003C6288 File Offset: 0x003C4488
		// (set) Token: 0x06027950 RID: 162128 RVA: 0x003C629C File Offset: 0x003C449C
		public unsafe FMargin ScrollbarPadding
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UScrollBox.__PropertyOffset_ScrollbarPadding);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UScrollBox.__PropertyOffset_ScrollbarPadding) = value;
			}
		}

		// Token: 0x170097B1 RID: 38833
		// (get) Token: 0x06027951 RID: 162129 RVA: 0x003C62B1 File Offset: 0x003C44B1
		// (set) Token: 0x06027952 RID: 162130 RVA: 0x003C62C1 File Offset: 0x003C44C1
		public unsafe bool AlwaysShowScrollbar
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UScrollBox.__PropertyOffset_AlwaysShowScrollbar) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UScrollBox.__PropertyOffset_AlwaysShowScrollbar) = (value ? 1 : 0);
			}
		}

		// Token: 0x170097B2 RID: 38834
		// (get) Token: 0x06027953 RID: 162131 RVA: 0x003C62D2 File Offset: 0x003C44D2
		// (set) Token: 0x06027954 RID: 162132 RVA: 0x003C62E2 File Offset: 0x003C44E2
		public unsafe bool AlwaysShowScrollbarTrack
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UScrollBox.__PropertyOffset_AlwaysShowScrollbarTrack) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UScrollBox.__PropertyOffset_AlwaysShowScrollbarTrack) = (value ? 1 : 0);
			}
		}

		// Token: 0x170097B3 RID: 38835
		// (get) Token: 0x06027955 RID: 162133 RVA: 0x003C62F3 File Offset: 0x003C44F3
		// (set) Token: 0x06027956 RID: 162134 RVA: 0x003C6303 File Offset: 0x003C4503
		public unsafe bool AllowOverscroll
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UScrollBox.__PropertyOffset_AllowOverscroll) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UScrollBox.__PropertyOffset_AllowOverscroll) = (value ? 1 : 0);
			}
		}

		// Token: 0x170097B4 RID: 38836
		// (get) Token: 0x06027957 RID: 162135 RVA: 0x003C6314 File Offset: 0x003C4514
		// (set) Token: 0x06027958 RID: 162136 RVA: 0x003C6324 File Offset: 0x003C4524
		public unsafe bool bAnimateWheelScrolling
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UScrollBox.__PropertyOffset_bAnimateWheelScrolling) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UScrollBox.__PropertyOffset_bAnimateWheelScrolling) = (value ? 1 : 0);
			}
		}

		// Token: 0x170097B5 RID: 38837
		// (get) Token: 0x06027959 RID: 162137 RVA: 0x003C6335 File Offset: 0x003C4535
		// (set) Token: 0x0602795A RID: 162138 RVA: 0x003C6345 File Offset: 0x003C4545
		public unsafe EDescendantScrollDestination NavigationDestination
		{
			get
			{
				return (EDescendantScrollDestination)(*(base.NativePtr + (IntPtr)UScrollBox.__PropertyOffset_NavigationDestination));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UScrollBox.__PropertyOffset_NavigationDestination) = (byte)value;
			}
		}

		// Token: 0x170097B6 RID: 38838
		// (get) Token: 0x0602795B RID: 162139 RVA: 0x003C6356 File Offset: 0x003C4556
		// (set) Token: 0x0602795C RID: 162140 RVA: 0x003C6366 File Offset: 0x003C4566
		public unsafe float NavigationScrollPadding
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UScrollBox.__PropertyOffset_NavigationScrollPadding);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UScrollBox.__PropertyOffset_NavigationScrollPadding) = value;
			}
		}

		// Token: 0x170097B7 RID: 38839
		// (get) Token: 0x0602795D RID: 162141 RVA: 0x003C6377 File Offset: 0x003C4577
		// (set) Token: 0x0602795E RID: 162142 RVA: 0x003C6387 File Offset: 0x003C4587
		public unsafe EScrollWhenFocusChanges ScrollWhenFocusChanges
		{
			get
			{
				return (EScrollWhenFocusChanges)(*(base.NativePtr + (IntPtr)UScrollBox.__PropertyOffset_ScrollWhenFocusChanges));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UScrollBox.__PropertyOffset_ScrollWhenFocusChanges) = (byte)value;
			}
		}

		// Token: 0x170097B8 RID: 38840
		// (get) Token: 0x0602795F RID: 162143 RVA: 0x003C6398 File Offset: 0x003C4598
		// (set) Token: 0x06027960 RID: 162144 RVA: 0x003C63A8 File Offset: 0x003C45A8
		public unsafe bool bAllowRightClickDragScrolling
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UScrollBox.__PropertyOffset_bAllowRightClickDragScrolling) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UScrollBox.__PropertyOffset_bAllowRightClickDragScrolling) = (value ? 1 : 0);
			}
		}

		// Token: 0x170097B9 RID: 38841
		// (get) Token: 0x06027961 RID: 162145 RVA: 0x003C63B9 File Offset: 0x003C45B9
		// (set) Token: 0x06027962 RID: 162146 RVA: 0x003C63C9 File Offset: 0x003C45C9
		public unsafe float WheelScrollMultiplier
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UScrollBox.__PropertyOffset_WheelScrollMultiplier);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UScrollBox.__PropertyOffset_WheelScrollMultiplier) = value;
			}
		}

		// Token: 0x170097BA RID: 38842
		// (get) Token: 0x06027963 RID: 162147 RVA: 0x003C63DA File Offset: 0x003C45DA
		// (set) Token: 0x06027964 RID: 162148 RVA: 0x003C63EA File Offset: 0x003C45EA
		public unsafe bool bCoverNavigation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UScrollBox.__PropertyOffset_bCoverNavigation) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UScrollBox.__PropertyOffset_bCoverNavigation) = (value ? 1 : 0);
			}
		}

		// Token: 0x170097BB RID: 38843
		// (get) Token: 0x06027965 RID: 162149 RVA: 0x003C63FC File Offset: 0x003C45FC
		// (set) Token: 0x06027966 RID: 162150 RVA: 0x003C6435 File Offset: 0x003C4635
		public FOnUserScrolledEvent OnUserScrolled
		{
			get
			{
				base.FastCheckIsValid();
				FOnUserScrolledEvent result;
				if ((result = this._OnUserScrolled) == null)
				{
					result = (this._OnUserScrolled = new FOnUserScrolledEvent(base.NativePtr + (IntPtr)UScrollBox.__PropertyOffset_OnUserScrolled, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UScrollBox.__PropertyOffset_OnUserScrolled, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x06027967 RID: 162151 RVA: 0x003C6456 File Offset: 0x003C4656
		public void SetWheelScrollMultiplier(float NewWheelScrollMultiplier)
		{
			UScrollBox.__SetWheelScrollMultiplier_Internal(base.NativePtr, NewWheelScrollMultiplier);
		}

		// Token: 0x06027968 RID: 162152 RVA: 0x003C6464 File Offset: 0x003C4664
		public void SetScrollOffset(float NewScrollOffset)
		{
			UScrollBox.__SetScrollOffset_Internal(base.NativePtr, NewScrollOffset);
		}

		// Token: 0x06027969 RID: 162153 RVA: 0x003C6472 File Offset: 0x003C4672
		public void SetScrollBarVisibility(ESlateVisibility NewScrollBarVisibility)
		{
			UScrollBox.__SetScrollBarVisibility_Internal(base.NativePtr, NewScrollBarVisibility);
		}

		// Token: 0x0602796A RID: 162154 RVA: 0x003C6480 File Offset: 0x003C4680
		public void SetScrollbarThickness(in FVector2D NewScrollbarThickness)
		{
			UScrollBox.__SetScrollbarThickness_Internal(base.NativePtr, NewScrollbarThickness);
		}

		// Token: 0x0602796B RID: 162155 RVA: 0x003C648E File Offset: 0x003C468E
		public void SetScrollbarPadding(in FMargin NewScrollbarPadding)
		{
			UScrollBox.__SetScrollbarPadding_Internal(base.NativePtr, NewScrollbarPadding);
		}

		// Token: 0x0602796C RID: 162156 RVA: 0x003C649C File Offset: 0x003C469C
		public void SetOrientation(EOrientation NewOrientation)
		{
			UScrollBox.__SetOrientation_Internal(base.NativePtr, NewOrientation);
		}

		// Token: 0x0602796D RID: 162157 RVA: 0x003C64AF File Offset: 0x003C46AF
		public void SetConsumeMouseWheel(EConsumeMouseWheel NewConsumeMouseWheel)
		{
			UScrollBox.__SetConsumeMouseWheel_Internal(base.NativePtr, NewConsumeMouseWheel);
		}

		// Token: 0x0602796E RID: 162158 RVA: 0x003C64BD File Offset: 0x003C46BD
		public void SetAnimateWheelScrolling(bool bShouldAnimateWheelScrolling)
		{
			UScrollBox.__SetAnimateWheelScrolling_Internal(base.NativePtr, bShouldAnimateWheelScrolling);
		}

		// Token: 0x0602796F RID: 162159 RVA: 0x003C64CB File Offset: 0x003C46CB
		public void SetAlwaysShowScrollbar(bool NewAlwaysShowScrollbar)
		{
			UScrollBox.__SetAlwaysShowScrollbar_Internal(base.NativePtr, NewAlwaysShowScrollbar);
		}

		// Token: 0x06027970 RID: 162160 RVA: 0x003C64D9 File Offset: 0x003C46D9
		public void SetAllowOverscroll(bool NewAllowOverscroll)
		{
			UScrollBox.__SetAllowOverscroll_Internal(base.NativePtr, NewAllowOverscroll);
		}

		// Token: 0x06027971 RID: 162161 RVA: 0x003C64E7 File Offset: 0x003C46E7
		[NullableContext(2)]
		public void ScrollWidgetIntoView(UWidget WidgetToFind, bool AnimateScroll = true, EDescendantScrollDestination ScrollDestination = EDescendantScrollDestination.IntoView, float Padding = 0f)
		{
			UScrollBox.__ScrollWidgetIntoView_Internal(base.NativePtr, (WidgetToFind != null) ? WidgetToFind.NativePtr : IntPtr.Zero, AnimateScroll, ScrollDestination, Padding);
		}

		// Token: 0x06027972 RID: 162162 RVA: 0x003C6508 File Offset: 0x003C4708
		public void ScrollToStart()
		{
			UScrollBox.__ScrollToStart_Internal(base.NativePtr);
		}

		// Token: 0x06027973 RID: 162163 RVA: 0x003C6515 File Offset: 0x003C4715
		public void ScrollToEnd()
		{
			UScrollBox.__ScrollToEnd_Internal(base.NativePtr);
		}

		// Token: 0x06027974 RID: 162164 RVA: 0x003C6522 File Offset: 0x003C4722
		public bool IsPressing()
		{
			return UScrollBox.__IsPressing_Internal(base.NativePtr);
		}

		// Token: 0x06027975 RID: 162165 RVA: 0x003C652F File Offset: 0x003C472F
		public float GetViewOffsetFraction()
		{
			return UScrollBox.__GetViewOffsetFraction_Internal(base.NativePtr);
		}

		// Token: 0x06027976 RID: 162166 RVA: 0x003C653C File Offset: 0x003C473C
		public float GetScrollOffsetOfEnd()
		{
			return UScrollBox.__GetScrollOffsetOfEnd_Internal(base.NativePtr);
		}

		// Token: 0x06027977 RID: 162167 RVA: 0x003C6549 File Offset: 0x003C4749
		public float GetScrollOffset()
		{
			return UScrollBox.__GetScrollOffset_Internal(base.NativePtr);
		}

		// Token: 0x06027978 RID: 162168 RVA: 0x003C6556 File Offset: 0x003C4756
		public void EndInertialScrolling()
		{
			UScrollBox.__EndInertialScrolling_Internal(base.NativePtr);
		}

		// Token: 0x06027979 RID: 162169
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetWheelScrollMultiplier_Internal(IntPtr @this, float NewWheelScrollMultiplier);

		// Token: 0x0602797A RID: 162170
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetScrollOffset_Internal(IntPtr @this, float NewScrollOffset);

		// Token: 0x0602797B RID: 162171
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetScrollBarVisibility_Internal(IntPtr @this, ESlateVisibility NewScrollBarVisibility);

		// Token: 0x0602797C RID: 162172
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetScrollbarThickness_Internal(IntPtr @this, in FVector2D NewScrollbarThickness);

		// Token: 0x0602797D RID: 162173
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetScrollbarPadding_Internal(IntPtr @this, in FMargin NewScrollbarPadding);

		// Token: 0x0602797E RID: 162174
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetOrientation_Internal(IntPtr @this, TEnumAsByte<EOrientation> NewOrientation);

		// Token: 0x0602797F RID: 162175
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetConsumeMouseWheel_Internal(IntPtr @this, EConsumeMouseWheel NewConsumeMouseWheel);

		// Token: 0x06027980 RID: 162176
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAnimateWheelScrolling_Internal(IntPtr @this, bool bShouldAnimateWheelScrolling);

		// Token: 0x06027981 RID: 162177
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAlwaysShowScrollbar_Internal(IntPtr @this, bool NewAlwaysShowScrollbar);

		// Token: 0x06027982 RID: 162178
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAllowOverscroll_Internal(IntPtr @this, bool NewAllowOverscroll);

		// Token: 0x06027983 RID: 162179
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ScrollWidgetIntoView_Internal(IntPtr @this, IntPtr WidgetToFind, bool AnimateScroll, EDescendantScrollDestination ScrollDestination, float Padding);

		// Token: 0x06027984 RID: 162180
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ScrollToStart_Internal(IntPtr @this);

		// Token: 0x06027985 RID: 162181
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ScrollToEnd_Internal(IntPtr @this);

		// Token: 0x06027986 RID: 162182
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsPressing_Internal(IntPtr @this);

		// Token: 0x06027987 RID: 162183
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetViewOffsetFraction_Internal(IntPtr @this);

		// Token: 0x06027988 RID: 162184
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetScrollOffsetOfEnd_Internal(IntPtr @this);

		// Token: 0x06027989 RID: 162185
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetScrollOffset_Internal(IntPtr @this);

		// Token: 0x0602798A RID: 162186
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __EndInertialScrolling_Internal(IntPtr @this);

		// Token: 0x0602798B RID: 162187 RVA: 0x003C6563 File Offset: 0x003C4763
		static UScrollBox()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/UMG.ScrollBox");
		}

		// Token: 0x0602798C RID: 162188 RVA: 0x003C6571 File Offset: 0x003C4771
		protected UScrollBox(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015B12 RID: 88850
		public new const string __ObjectPath = "/Script/UMG.ScrollBox";

		// Token: 0x04015B13 RID: 88851
		private static IntPtr _ClassPtr;

		// Token: 0x04015B14 RID: 88852
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015B15 RID: 88853
		internal static int __PropertyOffset_WidgetStyle;

		// Token: 0x04015B16 RID: 88854
		[Nullable(2)]
		private FScrollBoxStyle _WidgetStyle;

		// Token: 0x04015B17 RID: 88855
		internal static int __PropertyOffset_WidgetBarStyle;

		// Token: 0x04015B18 RID: 88856
		[Nullable(2)]
		private FScrollBarStyle _WidgetBarStyle;

		// Token: 0x04015B19 RID: 88857
		internal static int __PropertyOffset_Style_DEPRECATED;

		// Token: 0x04015B1A RID: 88858
		internal static int __PropertyOffset_BarStyle_DEPRECATED;

		// Token: 0x04015B1B RID: 88859
		internal static int __PropertyOffset_Orientation;

		// Token: 0x04015B1C RID: 88860
		internal static int __PropertyOffset_ScrollBarVisibility;

		// Token: 0x04015B1D RID: 88861
		internal static int __PropertyOffset_ConsumeMouseWheel;

		// Token: 0x04015B1E RID: 88862
		internal static int __PropertyOffset_ScrollbarThickness;

		// Token: 0x04015B1F RID: 88863
		internal static int __PropertyOffset_ScrollbarPadding;

		// Token: 0x04015B20 RID: 88864
		internal static int __PropertyOffset_AlwaysShowScrollbar;

		// Token: 0x04015B21 RID: 88865
		internal static int __PropertyOffset_AlwaysShowScrollbarTrack;

		// Token: 0x04015B22 RID: 88866
		internal static int __PropertyOffset_AllowOverscroll;

		// Token: 0x04015B23 RID: 88867
		internal static int __PropertyOffset_bAnimateWheelScrolling;

		// Token: 0x04015B24 RID: 88868
		internal static int __PropertyOffset_NavigationDestination;

		// Token: 0x04015B25 RID: 88869
		internal static int __PropertyOffset_NavigationScrollPadding;

		// Token: 0x04015B26 RID: 88870
		internal static int __PropertyOffset_ScrollWhenFocusChanges;

		// Token: 0x04015B27 RID: 88871
		internal static int __PropertyOffset_bAllowRightClickDragScrolling;

		// Token: 0x04015B28 RID: 88872
		internal static int __PropertyOffset_WheelScrollMultiplier;

		// Token: 0x04015B29 RID: 88873
		internal static int __PropertyOffset_bCoverNavigation;

		// Token: 0x04015B2A RID: 88874
		internal static int __PropertyOffset_OnUserScrolled;

		// Token: 0x04015B2B RID: 88875
		[Nullable(2)]
		private FOnUserScrolledEvent _OnUserScrolled;
	}
}
