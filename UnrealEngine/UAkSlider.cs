using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000241 RID: 577
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AkAudio.AkSlider")]
	[UnrealStructLayout(1896, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1896)]
	public class UAkSlider : UWidget, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06002204 RID: 8708 RVA: 0x00032855 File Offset: 0x00030A55
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAkSlider._ClassPtr;
		}

		// Token: 0x06002205 RID: 8709 RVA: 0x00032864 File Offset: 0x00030A64
		public UAkSlider() : this(BuiltinUtils.AllocNativeUObject(UAkSlider.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06002206 RID: 8710 RVA: 0x0003288C File Offset: 0x00030A8C
		public UAkSlider(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAkSlider.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000851 RID: 2129
		// (get) Token: 0x06002207 RID: 8711 RVA: 0x000328BF File Offset: 0x00030ABF
		// (set) Token: 0x06002208 RID: 8712 RVA: 0x000328CF File Offset: 0x00030ACF
		public unsafe float Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAkSlider.__PropertyOffset_Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAkSlider.__PropertyOffset_Value) = value;
			}
		}

		// Token: 0x17000852 RID: 2130
		// (get) Token: 0x06002209 RID: 8713 RVA: 0x000328E0 File Offset: 0x00030AE0
		// (set) Token: 0x0600220A RID: 8714 RVA: 0x00032919 File Offset: 0x00030B19
		public FGetFloat ValueDelegate
		{
			get
			{
				base.FastCheckIsValid();
				FGetFloat result;
				if ((result = this._ValueDelegate) == null)
				{
					result = (this._ValueDelegate = new FGetFloat(base.NativePtr + (IntPtr)UAkSlider.__PropertyOffset_ValueDelegate, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UAkSlider.__PropertyOffset_ValueDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17000853 RID: 2131
		// (get) Token: 0x0600220B RID: 8715 RVA: 0x0003293C File Offset: 0x00030B3C
		// (set) Token: 0x0600220C RID: 8716 RVA: 0x00032975 File Offset: 0x00030B75
		public FSliderStyle WidgetStyle
		{
			get
			{
				base.FastCheckIsValid();
				FSliderStyle result;
				if ((result = this._WidgetStyle) == null)
				{
					result = (this._WidgetStyle = new FSliderStyle(base.NativePtr + (IntPtr)UAkSlider.__PropertyOffset_WidgetStyle, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSliderStyle.StaticStruct(), base.NativePtr + (IntPtr)UAkSlider.__PropertyOffset_WidgetStyle, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000854 RID: 2132
		// (get) Token: 0x0600220D RID: 8717 RVA: 0x00032996 File Offset: 0x00030B96
		// (set) Token: 0x0600220E RID: 8718 RVA: 0x000329AA File Offset: 0x00030BAA
		[Nullable(0)]
		public unsafe TEnumAsByte<EOrientation> Orientation
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)UAkSlider.__PropertyOffset_Orientation);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)UAkSlider.__PropertyOffset_Orientation) = value;
			}
		}

		// Token: 0x17000855 RID: 2133
		// (get) Token: 0x0600220F RID: 8719 RVA: 0x000329BF File Offset: 0x00030BBF
		// (set) Token: 0x06002210 RID: 8720 RVA: 0x000329D3 File Offset: 0x00030BD3
		public unsafe FLinearColor SliderBarColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAkSlider.__PropertyOffset_SliderBarColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAkSlider.__PropertyOffset_SliderBarColor) = value;
			}
		}

		// Token: 0x17000856 RID: 2134
		// (get) Token: 0x06002211 RID: 8721 RVA: 0x000329E8 File Offset: 0x00030BE8
		// (set) Token: 0x06002212 RID: 8722 RVA: 0x000329FC File Offset: 0x00030BFC
		public unsafe FLinearColor SliderHandleColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAkSlider.__PropertyOffset_SliderHandleColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAkSlider.__PropertyOffset_SliderHandleColor) = value;
			}
		}

		// Token: 0x17000857 RID: 2135
		// (get) Token: 0x06002213 RID: 8723 RVA: 0x00032A11 File Offset: 0x00030C11
		// (set) Token: 0x06002214 RID: 8724 RVA: 0x00032A21 File Offset: 0x00030C21
		public unsafe bool IndentHandle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAkSlider.__PropertyOffset_IndentHandle) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAkSlider.__PropertyOffset_IndentHandle) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000858 RID: 2136
		// (get) Token: 0x06002215 RID: 8725 RVA: 0x00032A32 File Offset: 0x00030C32
		// (set) Token: 0x06002216 RID: 8726 RVA: 0x00032A42 File Offset: 0x00030C42
		public unsafe bool Locked
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAkSlider.__PropertyOffset_Locked) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAkSlider.__PropertyOffset_Locked) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000859 RID: 2137
		// (get) Token: 0x06002217 RID: 8727 RVA: 0x00032A53 File Offset: 0x00030C53
		// (set) Token: 0x06002218 RID: 8728 RVA: 0x00032A63 File Offset: 0x00030C63
		public unsafe float StepSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAkSlider.__PropertyOffset_StepSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAkSlider.__PropertyOffset_StepSize) = value;
			}
		}

		// Token: 0x1700085A RID: 2138
		// (get) Token: 0x06002219 RID: 8729 RVA: 0x00032A74 File Offset: 0x00030C74
		// (set) Token: 0x0600221A RID: 8730 RVA: 0x00032A84 File Offset: 0x00030C84
		public unsafe bool IsFocusable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAkSlider.__PropertyOffset_IsFocusable) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAkSlider.__PropertyOffset_IsFocusable) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700085B RID: 2139
		// (get) Token: 0x0600221B RID: 8731 RVA: 0x00032A98 File Offset: 0x00030C98
		// (set) Token: 0x0600221C RID: 8732 RVA: 0x00032AD1 File Offset: 0x00030CD1
		public FAkPropertyToControl ThePropertyToControl
		{
			get
			{
				base.FastCheckIsValid();
				FAkPropertyToControl result;
				if ((result = this._ThePropertyToControl) == null)
				{
					result = (this._ThePropertyToControl = new FAkPropertyToControl(base.NativePtr + (IntPtr)UAkSlider.__PropertyOffset_ThePropertyToControl, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FAkPropertyToControl.StaticStruct(), base.NativePtr + (IntPtr)UAkSlider.__PropertyOffset_ThePropertyToControl, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700085C RID: 2140
		// (get) Token: 0x0600221D RID: 8733 RVA: 0x00032AF4 File Offset: 0x00030CF4
		// (set) Token: 0x0600221E RID: 8734 RVA: 0x00032B2D File Offset: 0x00030D2D
		public FAkWwiseItemToControl ItemToControl
		{
			get
			{
				base.FastCheckIsValid();
				FAkWwiseItemToControl result;
				if ((result = this._ItemToControl) == null)
				{
					result = (this._ItemToControl = new FAkWwiseItemToControl(base.NativePtr + (IntPtr)UAkSlider.__PropertyOffset_ItemToControl, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FAkWwiseItemToControl.StaticStruct(), base.NativePtr + (IntPtr)UAkSlider.__PropertyOffset_ItemToControl, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700085D RID: 2141
		// (get) Token: 0x0600221F RID: 8735 RVA: 0x00032B50 File Offset: 0x00030D50
		// (set) Token: 0x06002220 RID: 8736 RVA: 0x00032B89 File Offset: 0x00030D89
		public FAkOnFloatValueChangedEvent OnValueChanged
		{
			get
			{
				base.FastCheckIsValid();
				FAkOnFloatValueChangedEvent result;
				if ((result = this._OnValueChanged) == null)
				{
					result = (this._OnValueChanged = new FAkOnFloatValueChangedEvent(base.NativePtr + (IntPtr)UAkSlider.__PropertyOffset_OnValueChanged, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UAkSlider.__PropertyOffset_OnValueChanged, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700085E RID: 2142
		// (get) Token: 0x06002221 RID: 8737 RVA: 0x00032BAC File Offset: 0x00030DAC
		// (set) Token: 0x06002222 RID: 8738 RVA: 0x00032BE5 File Offset: 0x00030DE5
		public FOnItemDropDetected OnItemDropped
		{
			get
			{
				base.FastCheckIsValid();
				FOnItemDropDetected result;
				if ((result = this._OnItemDropped) == null)
				{
					result = (this._OnItemDropped = new FOnItemDropDetected(base.NativePtr + (IntPtr)UAkSlider.__PropertyOffset_OnItemDropped, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UAkSlider.__PropertyOffset_OnItemDropped, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700085F RID: 2143
		// (get) Token: 0x06002223 RID: 8739 RVA: 0x00032C08 File Offset: 0x00030E08
		// (set) Token: 0x06002224 RID: 8740 RVA: 0x00032C41 File Offset: 0x00030E41
		public FOnPropertyDropDetected OnPropertyDropped
		{
			get
			{
				base.FastCheckIsValid();
				FOnPropertyDropDetected result;
				if ((result = this._OnPropertyDropped) == null)
				{
					result = (this._OnPropertyDropped = new FOnPropertyDropDetected(base.NativePtr + (IntPtr)UAkSlider.__PropertyOffset_OnPropertyDropped, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UAkSlider.__PropertyOffset_OnPropertyDropped, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x06002225 RID: 8741 RVA: 0x00032C62 File Offset: 0x00030E62
		public void SetValue(float InValue)
		{
			UAkSlider.__SetValue_Internal(base.NativePtr, InValue);
		}

		// Token: 0x06002226 RID: 8742 RVA: 0x00032C70 File Offset: 0x00030E70
		public void SetStepSize(float InValue)
		{
			UAkSlider.__SetStepSize_Internal(base.NativePtr, InValue);
		}

		// Token: 0x06002227 RID: 8743 RVA: 0x00032C7E File Offset: 0x00030E7E
		public void SetSliderHandleColor(FLinearColor InValue)
		{
			UAkSlider.__SetSliderHandleColor_Internal(base.NativePtr, InValue);
		}

		// Token: 0x06002228 RID: 8744 RVA: 0x00032C8C File Offset: 0x00030E8C
		public void SetSliderBarColor(FLinearColor InValue)
		{
			UAkSlider.__SetSliderBarColor_Internal(base.NativePtr, InValue);
		}

		// Token: 0x06002229 RID: 8745 RVA: 0x00032C9A File Offset: 0x00030E9A
		public void SetLocked(bool InValue)
		{
			UAkSlider.__SetLocked_Internal(base.NativePtr, InValue);
		}

		// Token: 0x0600222A RID: 8746 RVA: 0x00032CA8 File Offset: 0x00030EA8
		public void SetIndentHandle(bool InValue)
		{
			UAkSlider.__SetIndentHandle_Internal(base.NativePtr, InValue);
		}

		// Token: 0x0600222B RID: 8747 RVA: 0x00032CB8 File Offset: 0x00030EB8
		public unsafe void SetAkSliderItemProperty(string ItemProperty)
		{
			FString fstring = FString.AllocTemp(ItemProperty);
			UAkSlider.__SetAkSliderItemProperty_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0600222C RID: 8748 RVA: 0x00032CE2 File Offset: 0x00030EE2
		public void SetAkSliderItemId(in FGuid ItemId)
		{
			UAkSlider.__SetAkSliderItemId_Internal(base.NativePtr, ItemId);
		}

		// Token: 0x0600222D RID: 8749 RVA: 0x00032CF0 File Offset: 0x00030EF0
		public float GetValue()
		{
			return UAkSlider.__GetValue_Internal(base.NativePtr);
		}

		// Token: 0x0600222E RID: 8750 RVA: 0x00032CFD File Offset: 0x00030EFD
		public string GetAkSliderItemProperty()
		{
			return FString.ToStringAndDeleteNativePtr(UAkSlider.__GetAkSliderItemProperty_Internal(base.NativePtr));
		}

		// Token: 0x0600222F RID: 8751 RVA: 0x00032D0F File Offset: 0x00030F0F
		public FGuid GetAkSliderItemId()
		{
			return UAkSlider.__GetAkSliderItemId_Internal(base.NativePtr);
		}

		// Token: 0x06002230 RID: 8752
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetValue_Internal(IntPtr @this, float InValue);

		// Token: 0x06002231 RID: 8753
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetStepSize_Internal(IntPtr @this, float InValue);

		// Token: 0x06002232 RID: 8754
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSliderHandleColor_Internal(IntPtr @this, FLinearColor InValue);

		// Token: 0x06002233 RID: 8755
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSliderBarColor_Internal(IntPtr @this, FLinearColor InValue);

		// Token: 0x06002234 RID: 8756
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLocked_Internal(IntPtr @this, bool InValue);

		// Token: 0x06002235 RID: 8757
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetIndentHandle_Internal(IntPtr @this, bool InValue);

		// Token: 0x06002236 RID: 8758
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAkSliderItemProperty_Internal(IntPtr @this, in FString ItemProperty);

		// Token: 0x06002237 RID: 8759
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAkSliderItemId_Internal(IntPtr @this, in FGuid ItemId);

		// Token: 0x06002238 RID: 8760
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetValue_Internal(IntPtr @this);

		// Token: 0x06002239 RID: 8761
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetAkSliderItemProperty_Internal(IntPtr @this);

		// Token: 0x0600223A RID: 8762
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FGuid __GetAkSliderItemId_Internal(IntPtr @this);

		// Token: 0x0600223B RID: 8763 RVA: 0x00032D1C File Offset: 0x00030F1C
		static UAkSlider()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AkAudio.AkSlider");
		}

		// Token: 0x0600223C RID: 8764 RVA: 0x00032D2A File Offset: 0x00030F2A
		protected UAkSlider(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000BAC RID: 2988
		public new const string __ObjectPath = "/Script/AkAudio.AkSlider";

		// Token: 0x04000BAD RID: 2989
		private static IntPtr _ClassPtr;

		// Token: 0x04000BAE RID: 2990
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000BAF RID: 2991
		internal static int __PropertyOffset_Value;

		// Token: 0x04000BB0 RID: 2992
		internal static int __PropertyOffset_ValueDelegate;

		// Token: 0x04000BB1 RID: 2993
		[Nullable(2)]
		private FGetFloat _ValueDelegate;

		// Token: 0x04000BB2 RID: 2994
		internal static int __PropertyOffset_WidgetStyle;

		// Token: 0x04000BB3 RID: 2995
		[Nullable(2)]
		private FSliderStyle _WidgetStyle;

		// Token: 0x04000BB4 RID: 2996
		internal static int __PropertyOffset_Orientation;

		// Token: 0x04000BB5 RID: 2997
		internal static int __PropertyOffset_SliderBarColor;

		// Token: 0x04000BB6 RID: 2998
		internal static int __PropertyOffset_SliderHandleColor;

		// Token: 0x04000BB7 RID: 2999
		internal static int __PropertyOffset_IndentHandle;

		// Token: 0x04000BB8 RID: 3000
		internal static int __PropertyOffset_Locked;

		// Token: 0x04000BB9 RID: 3001
		internal static int __PropertyOffset_StepSize;

		// Token: 0x04000BBA RID: 3002
		internal static int __PropertyOffset_IsFocusable;

		// Token: 0x04000BBB RID: 3003
		internal static int __PropertyOffset_ThePropertyToControl;

		// Token: 0x04000BBC RID: 3004
		[Nullable(2)]
		private FAkPropertyToControl _ThePropertyToControl;

		// Token: 0x04000BBD RID: 3005
		internal static int __PropertyOffset_ItemToControl;

		// Token: 0x04000BBE RID: 3006
		[Nullable(2)]
		private FAkWwiseItemToControl _ItemToControl;

		// Token: 0x04000BBF RID: 3007
		internal static int __PropertyOffset_OnValueChanged;

		// Token: 0x04000BC0 RID: 3008
		[Nullable(2)]
		private FAkOnFloatValueChangedEvent _OnValueChanged;

		// Token: 0x04000BC1 RID: 3009
		internal static int __PropertyOffset_OnItemDropped;

		// Token: 0x04000BC2 RID: 3010
		[Nullable(2)]
		private FOnItemDropDetected _OnItemDropped;

		// Token: 0x04000BC3 RID: 3011
		internal static int __PropertyOffset_OnPropertyDropped;

		// Token: 0x04000BC4 RID: 3012
		[Nullable(2)]
		private FOnPropertyDropDetected _OnPropertyDropped;
	}
}
