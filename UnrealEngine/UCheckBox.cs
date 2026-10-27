using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002943 RID: 10563
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/UMG.CheckBox")]
	[UnrealStructLayout(2608, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2608)]
	public class UCheckBox : UContentWidget, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602717B RID: 160123 RVA: 0x003B9C34 File Offset: 0x003B7E34
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UCheckBox._ClassPtr;
		}

		// Token: 0x0602717C RID: 160124 RVA: 0x003B9C40 File Offset: 0x003B7E40
		public UCheckBox() : this(BuiltinUtils.AllocNativeUObject(UCheckBox.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602717D RID: 160125 RVA: 0x003B9C68 File Offset: 0x003B7E68
		[NullableContext(1)]
		public UCheckBox(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UCheckBox.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17009660 RID: 38496
		// (get) Token: 0x0602717E RID: 160126 RVA: 0x003B9C9B File Offset: 0x003B7E9B
		// (set) Token: 0x0602717F RID: 160127 RVA: 0x003B9CAB File Offset: 0x003B7EAB
		public unsafe ECheckBoxState CheckedState
		{
			get
			{
				return (ECheckBoxState)(*(base.NativePtr + (IntPtr)UCheckBox.__PropertyOffset_CheckedState));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCheckBox.__PropertyOffset_CheckedState) = (byte)value;
			}
		}

		// Token: 0x17009661 RID: 38497
		// (get) Token: 0x06027180 RID: 160128 RVA: 0x003B9CBC File Offset: 0x003B7EBC
		// (set) Token: 0x06027181 RID: 160129 RVA: 0x003B9CF5 File Offset: 0x003B7EF5
		[Nullable(1)]
		public FGetCheckBoxState CheckedStateDelegate
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FGetCheckBoxState result;
				if ((result = this._CheckedStateDelegate) == null)
				{
					result = (this._CheckedStateDelegate = new FGetCheckBoxState(base.NativePtr + (IntPtr)UCheckBox.__PropertyOffset_CheckedStateDelegate, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UCheckBox.__PropertyOffset_CheckedStateDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17009662 RID: 38498
		// (get) Token: 0x06027182 RID: 160130 RVA: 0x003B9D18 File Offset: 0x003B7F18
		// (set) Token: 0x06027183 RID: 160131 RVA: 0x003B9D51 File Offset: 0x003B7F51
		[Nullable(1)]
		public FCheckBoxStyle WidgetStyle
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FCheckBoxStyle result;
				if ((result = this._WidgetStyle) == null)
				{
					result = (this._WidgetStyle = new FCheckBoxStyle(base.NativePtr + (IntPtr)UCheckBox.__PropertyOffset_WidgetStyle, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCheckBoxStyle.StaticStruct(), base.NativePtr + (IntPtr)UCheckBox.__PropertyOffset_WidgetStyle, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17009663 RID: 38499
		// (get) Token: 0x06027184 RID: 160132 RVA: 0x003B9D72 File Offset: 0x003B7F72
		// (set) Token: 0x06027185 RID: 160133 RVA: 0x003B9D86 File Offset: 0x003B7F86
		public unsafe USlateWidgetStyleAsset Style_DEPRECATED
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USlateWidgetStyleAsset>(base.NativePtr / (IntPtr)sizeof(void*) + UCheckBox.__PropertyOffset_Style_DEPRECATED);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UCheckBox.__PropertyOffset_Style_DEPRECATED, value);
			}
		}

		// Token: 0x17009664 RID: 38500
		// (get) Token: 0x06027186 RID: 160134 RVA: 0x003B9D9B File Offset: 0x003B7F9B
		// (set) Token: 0x06027187 RID: 160135 RVA: 0x003B9DAF File Offset: 0x003B7FAF
		public unsafe USlateBrushAsset UncheckedImage_DEPRECATED
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USlateBrushAsset>(base.NativePtr / (IntPtr)sizeof(void*) + UCheckBox.__PropertyOffset_UncheckedImage_DEPRECATED);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UCheckBox.__PropertyOffset_UncheckedImage_DEPRECATED, value);
			}
		}

		// Token: 0x17009665 RID: 38501
		// (get) Token: 0x06027188 RID: 160136 RVA: 0x003B9DC4 File Offset: 0x003B7FC4
		// (set) Token: 0x06027189 RID: 160137 RVA: 0x003B9DD8 File Offset: 0x003B7FD8
		public unsafe USlateBrushAsset UncheckedHoveredImage_DEPRECATED
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USlateBrushAsset>(base.NativePtr / (IntPtr)sizeof(void*) + UCheckBox.__PropertyOffset_UncheckedHoveredImage_DEPRECATED);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UCheckBox.__PropertyOffset_UncheckedHoveredImage_DEPRECATED, value);
			}
		}

		// Token: 0x17009666 RID: 38502
		// (get) Token: 0x0602718A RID: 160138 RVA: 0x003B9DED File Offset: 0x003B7FED
		// (set) Token: 0x0602718B RID: 160139 RVA: 0x003B9E01 File Offset: 0x003B8001
		public unsafe USlateBrushAsset UncheckedPressedImage_DEPRECATED
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USlateBrushAsset>(base.NativePtr / (IntPtr)sizeof(void*) + UCheckBox.__PropertyOffset_UncheckedPressedImage_DEPRECATED);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UCheckBox.__PropertyOffset_UncheckedPressedImage_DEPRECATED, value);
			}
		}

		// Token: 0x17009667 RID: 38503
		// (get) Token: 0x0602718C RID: 160140 RVA: 0x003B9E16 File Offset: 0x003B8016
		// (set) Token: 0x0602718D RID: 160141 RVA: 0x003B9E2A File Offset: 0x003B802A
		public unsafe USlateBrushAsset CheckedImage_DEPRECATED
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USlateBrushAsset>(base.NativePtr / (IntPtr)sizeof(void*) + UCheckBox.__PropertyOffset_CheckedImage_DEPRECATED);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UCheckBox.__PropertyOffset_CheckedImage_DEPRECATED, value);
			}
		}

		// Token: 0x17009668 RID: 38504
		// (get) Token: 0x0602718E RID: 160142 RVA: 0x003B9E3F File Offset: 0x003B803F
		// (set) Token: 0x0602718F RID: 160143 RVA: 0x003B9E53 File Offset: 0x003B8053
		public unsafe USlateBrushAsset CheckedHoveredImage_DEPRECATED
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USlateBrushAsset>(base.NativePtr / (IntPtr)sizeof(void*) + UCheckBox.__PropertyOffset_CheckedHoveredImage_DEPRECATED);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UCheckBox.__PropertyOffset_CheckedHoveredImage_DEPRECATED, value);
			}
		}

		// Token: 0x17009669 RID: 38505
		// (get) Token: 0x06027190 RID: 160144 RVA: 0x003B9E68 File Offset: 0x003B8068
		// (set) Token: 0x06027191 RID: 160145 RVA: 0x003B9E7C File Offset: 0x003B807C
		public unsafe USlateBrushAsset CheckedPressedImage_DEPRECATED
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USlateBrushAsset>(base.NativePtr / (IntPtr)sizeof(void*) + UCheckBox.__PropertyOffset_CheckedPressedImage_DEPRECATED);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UCheckBox.__PropertyOffset_CheckedPressedImage_DEPRECATED, value);
			}
		}

		// Token: 0x1700966A RID: 38506
		// (get) Token: 0x06027192 RID: 160146 RVA: 0x003B9E91 File Offset: 0x003B8091
		// (set) Token: 0x06027193 RID: 160147 RVA: 0x003B9EA5 File Offset: 0x003B80A5
		public unsafe USlateBrushAsset UndeterminedImage_DEPRECATED
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USlateBrushAsset>(base.NativePtr / (IntPtr)sizeof(void*) + UCheckBox.__PropertyOffset_UndeterminedImage_DEPRECATED);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UCheckBox.__PropertyOffset_UndeterminedImage_DEPRECATED, value);
			}
		}

		// Token: 0x1700966B RID: 38507
		// (get) Token: 0x06027194 RID: 160148 RVA: 0x003B9EBA File Offset: 0x003B80BA
		// (set) Token: 0x06027195 RID: 160149 RVA: 0x003B9ECE File Offset: 0x003B80CE
		public unsafe USlateBrushAsset UndeterminedHoveredImage_DEPRECATED
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USlateBrushAsset>(base.NativePtr / (IntPtr)sizeof(void*) + UCheckBox.__PropertyOffset_UndeterminedHoveredImage_DEPRECATED);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UCheckBox.__PropertyOffset_UndeterminedHoveredImage_DEPRECATED, value);
			}
		}

		// Token: 0x1700966C RID: 38508
		// (get) Token: 0x06027196 RID: 160150 RVA: 0x003B9EE3 File Offset: 0x003B80E3
		// (set) Token: 0x06027197 RID: 160151 RVA: 0x003B9EF7 File Offset: 0x003B80F7
		public unsafe USlateBrushAsset UndeterminedPressedImage_DEPRECATED
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USlateBrushAsset>(base.NativePtr / (IntPtr)sizeof(void*) + UCheckBox.__PropertyOffset_UndeterminedPressedImage_DEPRECATED);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UCheckBox.__PropertyOffset_UndeterminedPressedImage_DEPRECATED, value);
			}
		}

		// Token: 0x1700966D RID: 38509
		// (get) Token: 0x06027198 RID: 160152 RVA: 0x003B9F0C File Offset: 0x003B810C
		// (set) Token: 0x06027199 RID: 160153 RVA: 0x003B9F20 File Offset: 0x003B8120
		[Nullable(0)]
		public unsafe TEnumAsByte<EHorizontalAlignment> HorizontalAlignment
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)UCheckBox.__PropertyOffset_HorizontalAlignment);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)UCheckBox.__PropertyOffset_HorizontalAlignment) = value;
			}
		}

		// Token: 0x1700966E RID: 38510
		// (get) Token: 0x0602719A RID: 160154 RVA: 0x003B9F35 File Offset: 0x003B8135
		// (set) Token: 0x0602719B RID: 160155 RVA: 0x003B9F49 File Offset: 0x003B8149
		public unsafe FMargin Padding_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCheckBox.__PropertyOffset_Padding_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCheckBox.__PropertyOffset_Padding_DEPRECATED) = value;
			}
		}

		// Token: 0x1700966F RID: 38511
		// (get) Token: 0x0602719C RID: 160156 RVA: 0x003B9F60 File Offset: 0x003B8160
		// (set) Token: 0x0602719D RID: 160157 RVA: 0x003B9F99 File Offset: 0x003B8199
		[Nullable(1)]
		public FSlateColor BorderBackgroundColor_DEPRECATED
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FSlateColor result;
				if ((result = this._BorderBackgroundColor_DEPRECATED) == null)
				{
					result = (this._BorderBackgroundColor_DEPRECATED = new FSlateColor(base.NativePtr + (IntPtr)UCheckBox.__PropertyOffset_BorderBackgroundColor_DEPRECATED, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateColor.StaticStruct(), base.NativePtr + (IntPtr)UCheckBox.__PropertyOffset_BorderBackgroundColor_DEPRECATED, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17009670 RID: 38512
		// (get) Token: 0x0602719E RID: 160158 RVA: 0x003B9FBA File Offset: 0x003B81BA
		// (set) Token: 0x0602719F RID: 160159 RVA: 0x003B9FCE File Offset: 0x003B81CE
		[Nullable(0)]
		public unsafe TEnumAsByte<EButtonClickMethod> ClickMethod
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)UCheckBox.__PropertyOffset_ClickMethod);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)UCheckBox.__PropertyOffset_ClickMethod) = value;
			}
		}

		// Token: 0x17009671 RID: 38513
		// (get) Token: 0x060271A0 RID: 160160 RVA: 0x003B9FE3 File Offset: 0x003B81E3
		// (set) Token: 0x060271A1 RID: 160161 RVA: 0x003B9FF7 File Offset: 0x003B81F7
		[Nullable(0)]
		public unsafe TEnumAsByte<EButtonTouchMethod> TouchMethod
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)UCheckBox.__PropertyOffset_TouchMethod);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)UCheckBox.__PropertyOffset_TouchMethod) = value;
			}
		}

		// Token: 0x17009672 RID: 38514
		// (get) Token: 0x060271A2 RID: 160162 RVA: 0x003BA00C File Offset: 0x003B820C
		// (set) Token: 0x060271A3 RID: 160163 RVA: 0x003BA020 File Offset: 0x003B8220
		[Nullable(0)]
		public unsafe TEnumAsByte<EButtonPressMethod> PressMethod
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)UCheckBox.__PropertyOffset_PressMethod);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)UCheckBox.__PropertyOffset_PressMethod) = value;
			}
		}

		// Token: 0x17009673 RID: 38515
		// (get) Token: 0x060271A4 RID: 160164 RVA: 0x003BA035 File Offset: 0x003B8235
		// (set) Token: 0x060271A5 RID: 160165 RVA: 0x003BA045 File Offset: 0x003B8245
		public unsafe bool IsFocusable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCheckBox.__PropertyOffset_IsFocusable) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCheckBox.__PropertyOffset_IsFocusable) = (value ? 1 : 0);
			}
		}

		// Token: 0x17009674 RID: 38516
		// (get) Token: 0x060271A6 RID: 160166 RVA: 0x003BA058 File Offset: 0x003B8258
		// (set) Token: 0x060271A7 RID: 160167 RVA: 0x003BA091 File Offset: 0x003B8291
		[Nullable(1)]
		public FOnCheckBoxComponentStateChanged OnCheckStateChanged
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FOnCheckBoxComponentStateChanged result;
				if ((result = this._OnCheckStateChanged) == null)
				{
					result = (this._OnCheckStateChanged = new FOnCheckBoxComponentStateChanged(base.NativePtr + (IntPtr)UCheckBox.__PropertyOffset_OnCheckStateChanged, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UCheckBox.__PropertyOffset_OnCheckStateChanged, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x060271A8 RID: 160168 RVA: 0x003BA0B2 File Offset: 0x003B82B2
		public void SetTouchMethod(EButtonTouchMethod InTouchMethod)
		{
			UCheckBox.__SetTouchMethod_Internal(base.NativePtr, InTouchMethod);
		}

		// Token: 0x060271A9 RID: 160169 RVA: 0x003BA0C5 File Offset: 0x003B82C5
		public void SetPressMethod(EButtonPressMethod InPressMethod)
		{
			UCheckBox.__SetPressMethod_Internal(base.NativePtr, InPressMethod);
		}

		// Token: 0x060271AA RID: 160170 RVA: 0x003BA0D8 File Offset: 0x003B82D8
		public void SetIsChecked(bool InIsChecked)
		{
			UCheckBox.__SetIsChecked_Internal(base.NativePtr, InIsChecked);
		}

		// Token: 0x060271AB RID: 160171 RVA: 0x003BA0E6 File Offset: 0x003B82E6
		public void SetClickMethod(EButtonClickMethod InClickMethod)
		{
			UCheckBox.__SetClickMethod_Internal(base.NativePtr, InClickMethod);
		}

		// Token: 0x060271AC RID: 160172 RVA: 0x003BA0F9 File Offset: 0x003B82F9
		public void SetCheckedState(ECheckBoxState InCheckedState)
		{
			UCheckBox.__SetCheckedState_Internal(base.NativePtr, InCheckedState);
		}

		// Token: 0x060271AD RID: 160173 RVA: 0x003BA107 File Offset: 0x003B8307
		public bool IsPressed()
		{
			return UCheckBox.__IsPressed_Internal(base.NativePtr);
		}

		// Token: 0x060271AE RID: 160174 RVA: 0x003BA114 File Offset: 0x003B8314
		public bool IsChecked()
		{
			return UCheckBox.__IsChecked_Internal(base.NativePtr);
		}

		// Token: 0x060271AF RID: 160175 RVA: 0x003BA121 File Offset: 0x003B8321
		public ECheckBoxState GetCheckedState()
		{
			return UCheckBox.__GetCheckedState_Internal(base.NativePtr);
		}

		// Token: 0x060271B0 RID: 160176
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTouchMethod_Internal(IntPtr @this, TEnumAsByte<EButtonTouchMethod> InTouchMethod);

		// Token: 0x060271B1 RID: 160177
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPressMethod_Internal(IntPtr @this, TEnumAsByte<EButtonPressMethod> InPressMethod);

		// Token: 0x060271B2 RID: 160178
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetIsChecked_Internal(IntPtr @this, bool InIsChecked);

		// Token: 0x060271B3 RID: 160179
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetClickMethod_Internal(IntPtr @this, TEnumAsByte<EButtonClickMethod> InClickMethod);

		// Token: 0x060271B4 RID: 160180
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCheckedState_Internal(IntPtr @this, ECheckBoxState InCheckedState);

		// Token: 0x060271B5 RID: 160181
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsPressed_Internal(IntPtr @this);

		// Token: 0x060271B6 RID: 160182
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsChecked_Internal(IntPtr @this);

		// Token: 0x060271B7 RID: 160183
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern ECheckBoxState __GetCheckedState_Internal(IntPtr @this);

		// Token: 0x060271B8 RID: 160184 RVA: 0x003BA12E File Offset: 0x003B832E
		static UCheckBox()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/UMG.CheckBox");
		}

		// Token: 0x060271B9 RID: 160185 RVA: 0x003BA13C File Offset: 0x003B833C
		protected UCheckBox(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401578E RID: 87950
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/UMG.CheckBox";

		// Token: 0x0401578F RID: 87951
		private static IntPtr _ClassPtr;

		// Token: 0x04015790 RID: 87952
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015791 RID: 87953
		internal static int __PropertyOffset_CheckedState;

		// Token: 0x04015792 RID: 87954
		internal static int __PropertyOffset_CheckedStateDelegate;

		// Token: 0x04015793 RID: 87955
		private FGetCheckBoxState _CheckedStateDelegate;

		// Token: 0x04015794 RID: 87956
		internal static int __PropertyOffset_WidgetStyle;

		// Token: 0x04015795 RID: 87957
		private FCheckBoxStyle _WidgetStyle;

		// Token: 0x04015796 RID: 87958
		internal static int __PropertyOffset_Style_DEPRECATED;

		// Token: 0x04015797 RID: 87959
		internal static int __PropertyOffset_UncheckedImage_DEPRECATED;

		// Token: 0x04015798 RID: 87960
		internal static int __PropertyOffset_UncheckedHoveredImage_DEPRECATED;

		// Token: 0x04015799 RID: 87961
		internal static int __PropertyOffset_UncheckedPressedImage_DEPRECATED;

		// Token: 0x0401579A RID: 87962
		internal static int __PropertyOffset_CheckedImage_DEPRECATED;

		// Token: 0x0401579B RID: 87963
		internal static int __PropertyOffset_CheckedHoveredImage_DEPRECATED;

		// Token: 0x0401579C RID: 87964
		internal static int __PropertyOffset_CheckedPressedImage_DEPRECATED;

		// Token: 0x0401579D RID: 87965
		internal static int __PropertyOffset_UndeterminedImage_DEPRECATED;

		// Token: 0x0401579E RID: 87966
		internal static int __PropertyOffset_UndeterminedHoveredImage_DEPRECATED;

		// Token: 0x0401579F RID: 87967
		internal static int __PropertyOffset_UndeterminedPressedImage_DEPRECATED;

		// Token: 0x040157A0 RID: 87968
		internal static int __PropertyOffset_HorizontalAlignment;

		// Token: 0x040157A1 RID: 87969
		internal static int __PropertyOffset_Padding_DEPRECATED;

		// Token: 0x040157A2 RID: 87970
		internal static int __PropertyOffset_BorderBackgroundColor_DEPRECATED;

		// Token: 0x040157A3 RID: 87971
		private FSlateColor _BorderBackgroundColor_DEPRECATED;

		// Token: 0x040157A4 RID: 87972
		internal static int __PropertyOffset_ClickMethod;

		// Token: 0x040157A5 RID: 87973
		internal static int __PropertyOffset_TouchMethod;

		// Token: 0x040157A6 RID: 87974
		internal static int __PropertyOffset_PressMethod;

		// Token: 0x040157A7 RID: 87975
		internal static int __PropertyOffset_IsFocusable;

		// Token: 0x040157A8 RID: 87976
		internal static int __PropertyOffset_OnCheckStateChanged;

		// Token: 0x040157A9 RID: 87977
		private FOnCheckBoxComponentStateChanged _OnCheckStateChanged;
	}
}
