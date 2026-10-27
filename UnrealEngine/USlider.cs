using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020029DD RID: 10717
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/UMG.Slider")]
	[UnrealStructLayout(1840, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1840)]
	public class USlider : UWidget, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06027A83 RID: 162435 RVA: 0x003C79C5 File Offset: 0x003C5BC5
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USlider._ClassPtr;
		}

		// Token: 0x06027A84 RID: 162436 RVA: 0x003C79D4 File Offset: 0x003C5BD4
		public USlider() : this(BuiltinUtils.AllocNativeUObject(USlider.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06027A85 RID: 162437 RVA: 0x003C79FC File Offset: 0x003C5BFC
		public USlider(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USlider.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170097EC RID: 38892
		// (get) Token: 0x06027A86 RID: 162438 RVA: 0x003C7A2F File Offset: 0x003C5C2F
		// (set) Token: 0x06027A87 RID: 162439 RVA: 0x003C7A3F File Offset: 0x003C5C3F
		public unsafe float Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USlider.__PropertyOffset_Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USlider.__PropertyOffset_Value) = value;
			}
		}

		// Token: 0x170097ED RID: 38893
		// (get) Token: 0x06027A88 RID: 162440 RVA: 0x003C7A50 File Offset: 0x003C5C50
		// (set) Token: 0x06027A89 RID: 162441 RVA: 0x003C7A89 File Offset: 0x003C5C89
		public FGetFloat ValueDelegate
		{
			get
			{
				base.FastCheckIsValid();
				FGetFloat result;
				if ((result = this._ValueDelegate) == null)
				{
					result = (this._ValueDelegate = new FGetFloat(base.NativePtr + (IntPtr)USlider.__PropertyOffset_ValueDelegate, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)USlider.__PropertyOffset_ValueDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170097EE RID: 38894
		// (get) Token: 0x06027A8A RID: 162442 RVA: 0x003C7AAA File Offset: 0x003C5CAA
		// (set) Token: 0x06027A8B RID: 162443 RVA: 0x003C7ABA File Offset: 0x003C5CBA
		public unsafe float MinValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USlider.__PropertyOffset_MinValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USlider.__PropertyOffset_MinValue) = value;
			}
		}

		// Token: 0x170097EF RID: 38895
		// (get) Token: 0x06027A8C RID: 162444 RVA: 0x003C7ACB File Offset: 0x003C5CCB
		// (set) Token: 0x06027A8D RID: 162445 RVA: 0x003C7ADB File Offset: 0x003C5CDB
		public unsafe float MaxValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USlider.__PropertyOffset_MaxValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USlider.__PropertyOffset_MaxValue) = value;
			}
		}

		// Token: 0x170097F0 RID: 38896
		// (get) Token: 0x06027A8E RID: 162446 RVA: 0x003C7AEC File Offset: 0x003C5CEC
		// (set) Token: 0x06027A8F RID: 162447 RVA: 0x003C7B25 File Offset: 0x003C5D25
		public FSliderStyle WidgetStyle
		{
			get
			{
				base.FastCheckIsValid();
				FSliderStyle result;
				if ((result = this._WidgetStyle) == null)
				{
					result = (this._WidgetStyle = new FSliderStyle(base.NativePtr + (IntPtr)USlider.__PropertyOffset_WidgetStyle, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSliderStyle.StaticStruct(), base.NativePtr + (IntPtr)USlider.__PropertyOffset_WidgetStyle, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170097F1 RID: 38897
		// (get) Token: 0x06027A90 RID: 162448 RVA: 0x003C7B46 File Offset: 0x003C5D46
		// (set) Token: 0x06027A91 RID: 162449 RVA: 0x003C7B5A File Offset: 0x003C5D5A
		[Nullable(0)]
		public unsafe TEnumAsByte<EOrientation> Orientation
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)USlider.__PropertyOffset_Orientation);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)USlider.__PropertyOffset_Orientation) = value;
			}
		}

		// Token: 0x170097F2 RID: 38898
		// (get) Token: 0x06027A92 RID: 162450 RVA: 0x003C7B6F File Offset: 0x003C5D6F
		// (set) Token: 0x06027A93 RID: 162451 RVA: 0x003C7B83 File Offset: 0x003C5D83
		public unsafe FLinearColor SliderBarColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USlider.__PropertyOffset_SliderBarColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USlider.__PropertyOffset_SliderBarColor) = value;
			}
		}

		// Token: 0x170097F3 RID: 38899
		// (get) Token: 0x06027A94 RID: 162452 RVA: 0x003C7B98 File Offset: 0x003C5D98
		// (set) Token: 0x06027A95 RID: 162453 RVA: 0x003C7BAC File Offset: 0x003C5DAC
		public unsafe FLinearColor SliderHandleColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USlider.__PropertyOffset_SliderHandleColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USlider.__PropertyOffset_SliderHandleColor) = value;
			}
		}

		// Token: 0x170097F4 RID: 38900
		// (get) Token: 0x06027A96 RID: 162454 RVA: 0x003C7BC1 File Offset: 0x003C5DC1
		// (set) Token: 0x06027A97 RID: 162455 RVA: 0x003C7BD1 File Offset: 0x003C5DD1
		public unsafe bool IndentHandle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USlider.__PropertyOffset_IndentHandle) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)USlider.__PropertyOffset_IndentHandle) = (value ? 1 : 0);
			}
		}

		// Token: 0x170097F5 RID: 38901
		// (get) Token: 0x06027A98 RID: 162456 RVA: 0x003C7BE2 File Offset: 0x003C5DE2
		// (set) Token: 0x06027A99 RID: 162457 RVA: 0x003C7BF2 File Offset: 0x003C5DF2
		public unsafe bool Locked
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USlider.__PropertyOffset_Locked) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)USlider.__PropertyOffset_Locked) = (value ? 1 : 0);
			}
		}

		// Token: 0x170097F6 RID: 38902
		// (get) Token: 0x06027A9A RID: 162458 RVA: 0x003C7C03 File Offset: 0x003C5E03
		// (set) Token: 0x06027A9B RID: 162459 RVA: 0x003C7C13 File Offset: 0x003C5E13
		public unsafe bool MouseUsesStep
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USlider.__PropertyOffset_MouseUsesStep) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)USlider.__PropertyOffset_MouseUsesStep) = (value ? 1 : 0);
			}
		}

		// Token: 0x170097F7 RID: 38903
		// (get) Token: 0x06027A9C RID: 162460 RVA: 0x003C7C24 File Offset: 0x003C5E24
		// (set) Token: 0x06027A9D RID: 162461 RVA: 0x003C7C34 File Offset: 0x003C5E34
		public unsafe bool RequiresControllerLock
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USlider.__PropertyOffset_RequiresControllerLock) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)USlider.__PropertyOffset_RequiresControllerLock) = (value ? 1 : 0);
			}
		}

		// Token: 0x170097F8 RID: 38904
		// (get) Token: 0x06027A9E RID: 162462 RVA: 0x003C7C45 File Offset: 0x003C5E45
		// (set) Token: 0x06027A9F RID: 162463 RVA: 0x003C7C55 File Offset: 0x003C5E55
		public unsafe float StepSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USlider.__PropertyOffset_StepSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USlider.__PropertyOffset_StepSize) = value;
			}
		}

		// Token: 0x170097F9 RID: 38905
		// (get) Token: 0x06027AA0 RID: 162464 RVA: 0x003C7C66 File Offset: 0x003C5E66
		// (set) Token: 0x06027AA1 RID: 162465 RVA: 0x003C7C76 File Offset: 0x003C5E76
		public unsafe bool IsFocusable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USlider.__PropertyOffset_IsFocusable) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)USlider.__PropertyOffset_IsFocusable) = (value ? 1 : 0);
			}
		}

		// Token: 0x170097FA RID: 38906
		// (get) Token: 0x06027AA2 RID: 162466 RVA: 0x003C7C88 File Offset: 0x003C5E88
		// (set) Token: 0x06027AA3 RID: 162467 RVA: 0x003C7CC1 File Offset: 0x003C5EC1
		public FOnMouseCaptureBeginEvent OnMouseCaptureBegin
		{
			get
			{
				base.FastCheckIsValid();
				FOnMouseCaptureBeginEvent result;
				if ((result = this._OnMouseCaptureBegin) == null)
				{
					result = (this._OnMouseCaptureBegin = new FOnMouseCaptureBeginEvent(base.NativePtr + (IntPtr)USlider.__PropertyOffset_OnMouseCaptureBegin, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)USlider.__PropertyOffset_OnMouseCaptureBegin, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170097FB RID: 38907
		// (get) Token: 0x06027AA4 RID: 162468 RVA: 0x003C7CE4 File Offset: 0x003C5EE4
		// (set) Token: 0x06027AA5 RID: 162469 RVA: 0x003C7D1D File Offset: 0x003C5F1D
		public FOnMouseCaptureEndEvent OnMouseCaptureEnd
		{
			get
			{
				base.FastCheckIsValid();
				FOnMouseCaptureEndEvent result;
				if ((result = this._OnMouseCaptureEnd) == null)
				{
					result = (this._OnMouseCaptureEnd = new FOnMouseCaptureEndEvent(base.NativePtr + (IntPtr)USlider.__PropertyOffset_OnMouseCaptureEnd, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)USlider.__PropertyOffset_OnMouseCaptureEnd, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170097FC RID: 38908
		// (get) Token: 0x06027AA6 RID: 162470 RVA: 0x003C7D40 File Offset: 0x003C5F40
		// (set) Token: 0x06027AA7 RID: 162471 RVA: 0x003C7D79 File Offset: 0x003C5F79
		public FOnControllerCaptureBeginEvent OnControllerCaptureBegin
		{
			get
			{
				base.FastCheckIsValid();
				FOnControllerCaptureBeginEvent result;
				if ((result = this._OnControllerCaptureBegin) == null)
				{
					result = (this._OnControllerCaptureBegin = new FOnControllerCaptureBeginEvent(base.NativePtr + (IntPtr)USlider.__PropertyOffset_OnControllerCaptureBegin, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)USlider.__PropertyOffset_OnControllerCaptureBegin, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170097FD RID: 38909
		// (get) Token: 0x06027AA8 RID: 162472 RVA: 0x003C7D9C File Offset: 0x003C5F9C
		// (set) Token: 0x06027AA9 RID: 162473 RVA: 0x003C7DD5 File Offset: 0x003C5FD5
		public FOnControllerCaptureEndEvent OnControllerCaptureEnd
		{
			get
			{
				base.FastCheckIsValid();
				FOnControllerCaptureEndEvent result;
				if ((result = this._OnControllerCaptureEnd) == null)
				{
					result = (this._OnControllerCaptureEnd = new FOnControllerCaptureEndEvent(base.NativePtr + (IntPtr)USlider.__PropertyOffset_OnControllerCaptureEnd, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)USlider.__PropertyOffset_OnControllerCaptureEnd, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170097FE RID: 38910
		// (get) Token: 0x06027AAA RID: 162474 RVA: 0x003C7DF8 File Offset: 0x003C5FF8
		// (set) Token: 0x06027AAB RID: 162475 RVA: 0x003C7E31 File Offset: 0x003C6031
		public FOnFloatValueChangedEvent OnValueChanged
		{
			get
			{
				base.FastCheckIsValid();
				FOnFloatValueChangedEvent result;
				if ((result = this._OnValueChanged) == null)
				{
					result = (this._OnValueChanged = new FOnFloatValueChangedEvent(base.NativePtr + (IntPtr)USlider.__PropertyOffset_OnValueChanged, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)USlider.__PropertyOffset_OnValueChanged, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x06027AAC RID: 162476 RVA: 0x003C7E52 File Offset: 0x003C6052
		public void SetValue(float InValue)
		{
			USlider.__SetValue_Internal(base.NativePtr, InValue);
		}

		// Token: 0x06027AAD RID: 162477 RVA: 0x003C7E60 File Offset: 0x003C6060
		public void SetStepSize(float InValue)
		{
			USlider.__SetStepSize_Internal(base.NativePtr, InValue);
		}

		// Token: 0x06027AAE RID: 162478 RVA: 0x003C7E6E File Offset: 0x003C606E
		public void SetSliderHandleColor(FLinearColor InValue)
		{
			USlider.__SetSliderHandleColor_Internal(base.NativePtr, InValue);
		}

		// Token: 0x06027AAF RID: 162479 RVA: 0x003C7E7C File Offset: 0x003C607C
		public void SetSliderBarColor(FLinearColor InValue)
		{
			USlider.__SetSliderBarColor_Internal(base.NativePtr, InValue);
		}

		// Token: 0x06027AB0 RID: 162480 RVA: 0x003C7E8A File Offset: 0x003C608A
		public void SetMinValue(float InValue)
		{
			USlider.__SetMinValue_Internal(base.NativePtr, InValue);
		}

		// Token: 0x06027AB1 RID: 162481 RVA: 0x003C7E98 File Offset: 0x003C6098
		public void SetMaxValue(float InValue)
		{
			USlider.__SetMaxValue_Internal(base.NativePtr, InValue);
		}

		// Token: 0x06027AB2 RID: 162482 RVA: 0x003C7EA6 File Offset: 0x003C60A6
		public void SetLocked(bool InValue)
		{
			USlider.__SetLocked_Internal(base.NativePtr, InValue);
		}

		// Token: 0x06027AB3 RID: 162483 RVA: 0x003C7EB4 File Offset: 0x003C60B4
		public void SetIndentHandle(bool InValue)
		{
			USlider.__SetIndentHandle_Internal(base.NativePtr, InValue);
		}

		// Token: 0x06027AB4 RID: 162484 RVA: 0x003C7EC2 File Offset: 0x003C60C2
		public float GetValue()
		{
			return USlider.__GetValue_Internal(base.NativePtr);
		}

		// Token: 0x06027AB5 RID: 162485 RVA: 0x003C7ECF File Offset: 0x003C60CF
		public float GetNormalizedValue()
		{
			return USlider.__GetNormalizedValue_Internal(base.NativePtr);
		}

		// Token: 0x06027AB6 RID: 162486
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetValue_Internal(IntPtr @this, float InValue);

		// Token: 0x06027AB7 RID: 162487
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetStepSize_Internal(IntPtr @this, float InValue);

		// Token: 0x06027AB8 RID: 162488
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSliderHandleColor_Internal(IntPtr @this, FLinearColor InValue);

		// Token: 0x06027AB9 RID: 162489
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSliderBarColor_Internal(IntPtr @this, FLinearColor InValue);

		// Token: 0x06027ABA RID: 162490
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMinValue_Internal(IntPtr @this, float InValue);

		// Token: 0x06027ABB RID: 162491
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMaxValue_Internal(IntPtr @this, float InValue);

		// Token: 0x06027ABC RID: 162492
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLocked_Internal(IntPtr @this, bool InValue);

		// Token: 0x06027ABD RID: 162493
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetIndentHandle_Internal(IntPtr @this, bool InValue);

		// Token: 0x06027ABE RID: 162494
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetValue_Internal(IntPtr @this);

		// Token: 0x06027ABF RID: 162495
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetNormalizedValue_Internal(IntPtr @this);

		// Token: 0x06027AC0 RID: 162496 RVA: 0x003C7EDC File Offset: 0x003C60DC
		static USlider()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/UMG.Slider");
		}

		// Token: 0x06027AC1 RID: 162497 RVA: 0x003C7EEA File Offset: 0x003C60EA
		protected USlider(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015B8B RID: 88971
		public new const string __ObjectPath = "/Script/UMG.Slider";

		// Token: 0x04015B8C RID: 88972
		private static IntPtr _ClassPtr;

		// Token: 0x04015B8D RID: 88973
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015B8E RID: 88974
		internal static int __PropertyOffset_Value;

		// Token: 0x04015B8F RID: 88975
		internal static int __PropertyOffset_ValueDelegate;

		// Token: 0x04015B90 RID: 88976
		[Nullable(2)]
		private FGetFloat _ValueDelegate;

		// Token: 0x04015B91 RID: 88977
		internal static int __PropertyOffset_MinValue;

		// Token: 0x04015B92 RID: 88978
		internal static int __PropertyOffset_MaxValue;

		// Token: 0x04015B93 RID: 88979
		internal static int __PropertyOffset_WidgetStyle;

		// Token: 0x04015B94 RID: 88980
		[Nullable(2)]
		private FSliderStyle _WidgetStyle;

		// Token: 0x04015B95 RID: 88981
		internal static int __PropertyOffset_Orientation;

		// Token: 0x04015B96 RID: 88982
		internal static int __PropertyOffset_SliderBarColor;

		// Token: 0x04015B97 RID: 88983
		internal static int __PropertyOffset_SliderHandleColor;

		// Token: 0x04015B98 RID: 88984
		internal static int __PropertyOffset_IndentHandle;

		// Token: 0x04015B99 RID: 88985
		internal static int __PropertyOffset_Locked;

		// Token: 0x04015B9A RID: 88986
		internal static int __PropertyOffset_MouseUsesStep;

		// Token: 0x04015B9B RID: 88987
		internal static int __PropertyOffset_RequiresControllerLock;

		// Token: 0x04015B9C RID: 88988
		internal static int __PropertyOffset_StepSize;

		// Token: 0x04015B9D RID: 88989
		internal static int __PropertyOffset_IsFocusable;

		// Token: 0x04015B9E RID: 88990
		internal static int __PropertyOffset_OnMouseCaptureBegin;

		// Token: 0x04015B9F RID: 88991
		[Nullable(2)]
		private FOnMouseCaptureBeginEvent _OnMouseCaptureBegin;

		// Token: 0x04015BA0 RID: 88992
		internal static int __PropertyOffset_OnMouseCaptureEnd;

		// Token: 0x04015BA1 RID: 88993
		[Nullable(2)]
		private FOnMouseCaptureEndEvent _OnMouseCaptureEnd;

		// Token: 0x04015BA2 RID: 88994
		internal static int __PropertyOffset_OnControllerCaptureBegin;

		// Token: 0x04015BA3 RID: 88995
		[Nullable(2)]
		private FOnControllerCaptureBeginEvent _OnControllerCaptureBegin;

		// Token: 0x04015BA4 RID: 88996
		internal static int __PropertyOffset_OnControllerCaptureEnd;

		// Token: 0x04015BA5 RID: 88997
		[Nullable(2)]
		private FOnControllerCaptureEndEvent _OnControllerCaptureEnd;

		// Token: 0x04015BA6 RID: 88998
		internal static int __PropertyOffset_OnValueChanged;

		// Token: 0x04015BA7 RID: 88999
		[Nullable(2)]
		private FOnFloatValueChangedEvent _OnValueChanged;
	}
}
