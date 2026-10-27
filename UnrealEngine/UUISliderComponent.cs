using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020021B2 RID: 8626
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.UISliderComponent")]
	[UnrealStructLayout(1320, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1320)]
	public class UUISliderComponent : UUISelectableComponent, IUnrealUObject, IUnrealObject, ILGUIPointerDragInterface, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x06020CE9 RID: 134377 RVA: 0x00307A67 File Offset: 0x00305C67
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUISliderComponent._ClassPtr;
		}

		// Token: 0x06020CEA RID: 134378 RVA: 0x00307A73 File Offset: 0x00305C73
		int ILGUIPointerDragInterface.InterfaceOffset()
		{
			return UUISliderComponent.__InterfaceOffset_ILGUIPointerDragInterface;
		}

		// Token: 0x06020CEB RID: 134379 RVA: 0x00307A7C File Offset: 0x00305C7C
		public UUISliderComponent() : this(BuiltinUtils.AllocNativeUObject(UUISliderComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020CEC RID: 134380 RVA: 0x00307AA4 File Offset: 0x00305CA4
		public UUISliderComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUISliderComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008020 RID: 32800
		// (get) Token: 0x06020CED RID: 134381 RVA: 0x00307AD7 File Offset: 0x00305CD7
		// (set) Token: 0x06020CEE RID: 134382 RVA: 0x00307AE7 File Offset: 0x00305CE7
		public unsafe float Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUISliderComponent.__PropertyOffset_Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUISliderComponent.__PropertyOffset_Value) = value;
			}
		}

		// Token: 0x17008021 RID: 32801
		// (get) Token: 0x06020CEF RID: 134383 RVA: 0x00307AF8 File Offset: 0x00305CF8
		// (set) Token: 0x06020CF0 RID: 134384 RVA: 0x00307B08 File Offset: 0x00305D08
		public unsafe float MinValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUISliderComponent.__PropertyOffset_MinValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUISliderComponent.__PropertyOffset_MinValue) = value;
			}
		}

		// Token: 0x17008022 RID: 32802
		// (get) Token: 0x06020CF1 RID: 134385 RVA: 0x00307B19 File Offset: 0x00305D19
		// (set) Token: 0x06020CF2 RID: 134386 RVA: 0x00307B29 File Offset: 0x00305D29
		public unsafe float MaxValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUISliderComponent.__PropertyOffset_MaxValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUISliderComponent.__PropertyOffset_MaxValue) = value;
			}
		}

		// Token: 0x17008023 RID: 32803
		// (get) Token: 0x06020CF3 RID: 134387 RVA: 0x00307B3A File Offset: 0x00305D3A
		// (set) Token: 0x06020CF4 RID: 134388 RVA: 0x00307B4A File Offset: 0x00305D4A
		public unsafe bool WholeNumbers
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUISliderComponent.__PropertyOffset_WholeNumbers) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUISliderComponent.__PropertyOffset_WholeNumbers) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008024 RID: 32804
		// (get) Token: 0x06020CF5 RID: 134389 RVA: 0x00307B5B File Offset: 0x00305D5B
		// (set) Token: 0x06020CF6 RID: 134390 RVA: 0x00307B6F File Offset: 0x00305D6F
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<AUIBaseActor> FillActor
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UUISliderComponent.__PropertyOffset_FillActor);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UUISliderComponent.__PropertyOffset_FillActor) = value;
			}
		}

		// Token: 0x17008025 RID: 32805
		// (get) Token: 0x06020CF7 RID: 134391 RVA: 0x00307B84 File Offset: 0x00305D84
		// (set) Token: 0x06020CF8 RID: 134392 RVA: 0x00307B98 File Offset: 0x00305D98
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<AUIBaseActor> HandleActor
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UUISliderComponent.__PropertyOffset_HandleActor);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UUISliderComponent.__PropertyOffset_HandleActor) = value;
			}
		}

		// Token: 0x17008026 RID: 32806
		// (get) Token: 0x06020CF9 RID: 134393 RVA: 0x00307BAD File Offset: 0x00305DAD
		// (set) Token: 0x06020CFA RID: 134394 RVA: 0x00307BBD File Offset: 0x00305DBD
		public unsafe UISliderDirectionType DirectionType
		{
			get
			{
				return (UISliderDirectionType)(*(base.NativePtr + (IntPtr)UUISliderComponent.__PropertyOffset_DirectionType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUISliderComponent.__PropertyOffset_DirectionType) = (byte)value;
			}
		}

		// Token: 0x17008027 RID: 32807
		// (get) Token: 0x06020CFB RID: 134395 RVA: 0x00307BD0 File Offset: 0x00305DD0
		// (set) Token: 0x06020CFC RID: 134396 RVA: 0x00307C09 File Offset: 0x00305E09
		public FLGUISliderDynamicDelegate OnValueChangeCb
		{
			get
			{
				base.FastCheckIsValid();
				FLGUISliderDynamicDelegate result;
				if ((result = this._OnValueChangeCb) == null)
				{
					result = (this._OnValueChangeCb = new FLGUISliderDynamicDelegate(base.NativePtr + (IntPtr)UUISliderComponent.__PropertyOffset_OnValueChangeCb, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UUISliderComponent.__PropertyOffset_OnValueChangeCb, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17008028 RID: 32808
		// (get) Token: 0x06020CFD RID: 134397 RVA: 0x00307C2C File Offset: 0x00305E2C
		// (set) Token: 0x06020CFE RID: 134398 RVA: 0x00307C65 File Offset: 0x00305E65
		public FLGUISliderEndDragDelegate OnEndDragCb
		{
			get
			{
				base.FastCheckIsValid();
				FLGUISliderEndDragDelegate result;
				if ((result = this._OnEndDragCb) == null)
				{
					result = (this._OnEndDragCb = new FLGUISliderEndDragDelegate(base.NativePtr + (IntPtr)UUISliderComponent.__PropertyOffset_OnEndDragCb, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UUISliderComponent.__PropertyOffset_OnEndDragCb, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17008029 RID: 32809
		// (get) Token: 0x06020CFF RID: 134399 RVA: 0x00307C88 File Offset: 0x00305E88
		// (set) Token: 0x06020D00 RID: 134400 RVA: 0x00307CC1 File Offset: 0x00305EC1
		public FLGUISliderPointUpDelegateOneParams OnPointUpCallBack
		{
			get
			{
				base.FastCheckIsValid();
				FLGUISliderPointUpDelegateOneParams result;
				if ((result = this._OnPointUpCallBack) == null)
				{
					result = (this._OnPointUpCallBack = new FLGUISliderPointUpDelegateOneParams(base.NativePtr + (IntPtr)UUISliderComponent.__PropertyOffset_OnPointUpCallBack, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UUISliderComponent.__PropertyOffset_OnPointUpCallBack, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700802A RID: 32810
		// (get) Token: 0x06020D01 RID: 134401 RVA: 0x00307CE2 File Offset: 0x00305EE2
		// (set) Token: 0x06020D02 RID: 134402 RVA: 0x00307CF6 File Offset: 0x00305EF6
		[Nullable(2)]
		public unsafe UAkAudioEvent DragBeginAudioEvent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAkAudioEvent>(base.NativePtr / (IntPtr)sizeof(void*) + UUISliderComponent.__PropertyOffset_DragBeginAudioEvent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UUISliderComponent.__PropertyOffset_DragBeginAudioEvent, value);
			}
		}

		// Token: 0x1700802B RID: 32811
		// (get) Token: 0x06020D03 RID: 134403 RVA: 0x00307D0B File Offset: 0x00305F0B
		// (set) Token: 0x06020D04 RID: 134404 RVA: 0x00307D1F File Offset: 0x00305F1F
		[Nullable(2)]
		public unsafe UAkAudioEvent DragEndAudioEvent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAkAudioEvent>(base.NativePtr / (IntPtr)sizeof(void*) + UUISliderComponent.__PropertyOffset_DragEndAudioEvent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UUISliderComponent.__PropertyOffset_DragEndAudioEvent, value);
			}
		}

		// Token: 0x1700802C RID: 32812
		// (get) Token: 0x06020D05 RID: 134405 RVA: 0x00307D34 File Offset: 0x00305F34
		// (set) Token: 0x06020D06 RID: 134406 RVA: 0x00307D48 File Offset: 0x00305F48
		[Nullable(2)]
		public unsafe UAkAudioEvent DraggingAudioEvent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAkAudioEvent>(base.NativePtr / (IntPtr)sizeof(void*) + UUISliderComponent.__PropertyOffset_DraggingAudioEvent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UUISliderComponent.__PropertyOffset_DraggingAudioEvent, value);
			}
		}

		// Token: 0x1700802D RID: 32813
		// (get) Token: 0x06020D07 RID: 134407 RVA: 0x00307D5D File Offset: 0x00305F5D
		// (set) Token: 0x06020D08 RID: 134408 RVA: 0x00307D6D File Offset: 0x00305F6D
		public unsafe float DraggingAudioEventInterval
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUISliderComponent.__PropertyOffset_DraggingAudioEventInterval);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUISliderComponent.__PropertyOffset_DraggingAudioEventInterval) = value;
			}
		}

		// Token: 0x1700802E RID: 32814
		// (get) Token: 0x06020D09 RID: 134409 RVA: 0x00307D7E File Offset: 0x00305F7E
		// (set) Token: 0x06020D0A RID: 134410 RVA: 0x00307D92 File Offset: 0x00305F92
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<UUIItem> Fill
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UUISliderComponent.__PropertyOffset_Fill);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UUISliderComponent.__PropertyOffset_Fill) = value;
			}
		}

		// Token: 0x1700802F RID: 32815
		// (get) Token: 0x06020D0B RID: 134411 RVA: 0x00307DA7 File Offset: 0x00305FA7
		// (set) Token: 0x06020D0C RID: 134412 RVA: 0x00307DBB File Offset: 0x00305FBB
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<UUIItem> FillArea
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UUISliderComponent.__PropertyOffset_FillArea);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UUISliderComponent.__PropertyOffset_FillArea) = value;
			}
		}

		// Token: 0x17008030 RID: 32816
		// (get) Token: 0x06020D0D RID: 134413 RVA: 0x00307DD0 File Offset: 0x00305FD0
		// (set) Token: 0x06020D0E RID: 134414 RVA: 0x00307DE4 File Offset: 0x00305FE4
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<UUIItem> Handle
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UUISliderComponent.__PropertyOffset_Handle);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UUISliderComponent.__PropertyOffset_Handle) = value;
			}
		}

		// Token: 0x17008031 RID: 32817
		// (get) Token: 0x06020D0F RID: 134415 RVA: 0x00307DF9 File Offset: 0x00305FF9
		// (set) Token: 0x06020D10 RID: 134416 RVA: 0x00307E0D File Offset: 0x0030600D
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<UUIItem> HandleArea
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UUISliderComponent.__PropertyOffset_HandleArea);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UUISliderComponent.__PropertyOffset_HandleArea) = value;
			}
		}

		// Token: 0x17008032 RID: 32818
		// (get) Token: 0x06020D11 RID: 134417 RVA: 0x00307E24 File Offset: 0x00306024
		// (set) Token: 0x06020D12 RID: 134418 RVA: 0x00307E5D File Offset: 0x0030605D
		public FLGUIDrawableEvent OnValueChange
		{
			get
			{
				base.FastCheckIsValid();
				FLGUIDrawableEvent result;
				if ((result = this._OnValueChange) == null)
				{
					result = (this._OnValueChange = new FLGUIDrawableEvent(base.NativePtr + (IntPtr)UUISliderComponent.__PropertyOffset_OnValueChange, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FLGUIDrawableEvent.StaticStruct(), base.NativePtr + (IntPtr)UUISliderComponent.__PropertyOffset_OnValueChange, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06020D13 RID: 134419 RVA: 0x00307E7E File Offset: 0x0030607E
		[NullableContext(2)]
		public void UnregisterSlideEvent(in FLGUIDelegateHandleWrapper InDelegateHandle)
		{
			UUISliderComponent.__UnregisterSlideEvent_Internal(base.NativePtr, (InDelegateHandle ?? new FLGUIDelegateHandleWrapper()).NativePtr);
		}

		// Token: 0x06020D14 RID: 134420 RVA: 0x00307E9B File Offset: 0x0030609B
		public void SetValueWithAudio(float InValue, bool FireEvent = true)
		{
			UUISliderComponent.__SetValueWithAudio_Internal(base.NativePtr, InValue, FireEvent);
		}

		// Token: 0x06020D15 RID: 134421 RVA: 0x00307EAA File Offset: 0x003060AA
		public void SetValue(float InValue, bool FireEvent = true)
		{
			UUISliderComponent.__SetValue_Internal(base.NativePtr, InValue, FireEvent);
		}

		// Token: 0x06020D16 RID: 134422 RVA: 0x00307EB9 File Offset: 0x003060B9
		public void SetProgressIncrement(float incrementValue, bool needRound = true, bool NeedAudio = false)
		{
			UUISliderComponent.__SetProgressIncrement_Internal(base.NativePtr, incrementValue, needRound, NeedAudio);
		}

		// Token: 0x06020D17 RID: 134423 RVA: 0x00307EC9 File Offset: 0x003060C9
		public void SetMinValue(float InMinValue, bool KeepRelativeValue, bool FireEvent = true)
		{
			UUISliderComponent.__SetMinValue_Internal(base.NativePtr, InMinValue, KeepRelativeValue, FireEvent);
		}

		// Token: 0x06020D18 RID: 134424 RVA: 0x00307ED9 File Offset: 0x003060D9
		public void SetMaxValue(float InMaxValue, bool KeepRelativeValue, bool FireEvent = true)
		{
			UUISliderComponent.__SetMaxValue_Internal(base.NativePtr, InMaxValue, KeepRelativeValue, FireEvent);
		}

		// Token: 0x06020D19 RID: 134425 RVA: 0x00307EE9 File Offset: 0x003060E9
		public FLGUIDelegateHandleWrapper RegisterSlideEvent([Nullable(2)] in FLGUISliderDynamicDelegate InDelegate)
		{
			IntPtr nativePtr = base.NativePtr;
			FLGUISliderDynamicDelegate flguisliderDynamicDelegate = InDelegate;
			return new FLGUIDelegateHandleWrapper(UUISliderComponent.__RegisterSlideEvent_Internal(nativePtr, (flguisliderDynamicDelegate != null) ? flguisliderDynamicDelegate.NativePtr : ((IntPtr)0)), null);
		}

		// Token: 0x06020D1A RID: 134426 RVA: 0x00307F0B File Offset: 0x0030610B
		public float GetValue()
		{
			return UUISliderComponent.__GetValue_Internal(base.NativePtr);
		}

		// Token: 0x06020D1B RID: 134427 RVA: 0x00307F18 File Offset: 0x00306118
		public float GetMinValue()
		{
			return UUISliderComponent.__GetMinValue_Internal(base.NativePtr);
		}

		// Token: 0x06020D1C RID: 134428 RVA: 0x00307F25 File Offset: 0x00306125
		public float GetMaxValue()
		{
			return UUISliderComponent.__GetMaxValue_Internal(base.NativePtr);
		}

		// Token: 0x06020D1D RID: 134429
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UnregisterSlideEvent_Internal(IntPtr @this, IntPtr InDelegateHandle);

		// Token: 0x06020D1E RID: 134430
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetValueWithAudio_Internal(IntPtr @this, float InValue, bool FireEvent);

		// Token: 0x06020D1F RID: 134431
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetValue_Internal(IntPtr @this, float InValue, bool FireEvent);

		// Token: 0x06020D20 RID: 134432
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetProgressIncrement_Internal(IntPtr @this, float incrementValue, bool needRound, bool NeedAudio);

		// Token: 0x06020D21 RID: 134433
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMinValue_Internal(IntPtr @this, float InMinValue, bool KeepRelativeValue, bool FireEvent);

		// Token: 0x06020D22 RID: 134434
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMaxValue_Internal(IntPtr @this, float InMaxValue, bool KeepRelativeValue, bool FireEvent);

		// Token: 0x06020D23 RID: 134435
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __RegisterSlideEvent_Internal(IntPtr @this, IntPtr InDelegate);

		// Token: 0x06020D24 RID: 134436
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetValue_Internal(IntPtr @this);

		// Token: 0x06020D25 RID: 134437
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetMinValue_Internal(IntPtr @this);

		// Token: 0x06020D26 RID: 134438
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetMaxValue_Internal(IntPtr @this);

		// Token: 0x06020D27 RID: 134439 RVA: 0x00307F32 File Offset: 0x00306132
		static UUISliderComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UISliderComponent");
		}

		// Token: 0x06020D28 RID: 134440 RVA: 0x00307F40 File Offset: 0x00306140
		protected UUISliderComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011862 RID: 71778
		internal static int __InterfaceOffset_ILGUIPointerDragInterface;

		// Token: 0x04011863 RID: 71779
		public new const string __ObjectPath = "/Script/LGUI.UISliderComponent";

		// Token: 0x04011864 RID: 71780
		private static IntPtr _ClassPtr;

		// Token: 0x04011865 RID: 71781
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011866 RID: 71782
		internal static int __PropertyOffset_Value;

		// Token: 0x04011867 RID: 71783
		internal static int __PropertyOffset_MinValue;

		// Token: 0x04011868 RID: 71784
		internal static int __PropertyOffset_MaxValue;

		// Token: 0x04011869 RID: 71785
		internal static int __PropertyOffset_WholeNumbers;

		// Token: 0x0401186A RID: 71786
		internal static int __PropertyOffset_FillActor;

		// Token: 0x0401186B RID: 71787
		internal static int __PropertyOffset_HandleActor;

		// Token: 0x0401186C RID: 71788
		internal static int __PropertyOffset_DirectionType;

		// Token: 0x0401186D RID: 71789
		internal static int __PropertyOffset_OnValueChangeCb;

		// Token: 0x0401186E RID: 71790
		[Nullable(2)]
		private FLGUISliderDynamicDelegate _OnValueChangeCb;

		// Token: 0x0401186F RID: 71791
		internal static int __PropertyOffset_OnEndDragCb;

		// Token: 0x04011870 RID: 71792
		[Nullable(2)]
		private FLGUISliderEndDragDelegate _OnEndDragCb;

		// Token: 0x04011871 RID: 71793
		internal static int __PropertyOffset_OnPointUpCallBack;

		// Token: 0x04011872 RID: 71794
		[Nullable(2)]
		private FLGUISliderPointUpDelegateOneParams _OnPointUpCallBack;

		// Token: 0x04011873 RID: 71795
		internal static int __PropertyOffset_DragBeginAudioEvent;

		// Token: 0x04011874 RID: 71796
		internal static int __PropertyOffset_DragEndAudioEvent;

		// Token: 0x04011875 RID: 71797
		internal static int __PropertyOffset_DraggingAudioEvent;

		// Token: 0x04011876 RID: 71798
		internal static int __PropertyOffset_DraggingAudioEventInterval;

		// Token: 0x04011877 RID: 71799
		internal static int __PropertyOffset_Fill;

		// Token: 0x04011878 RID: 71800
		internal static int __PropertyOffset_FillArea;

		// Token: 0x04011879 RID: 71801
		internal static int __PropertyOffset_Handle;

		// Token: 0x0401187A RID: 71802
		internal static int __PropertyOffset_HandleArea;

		// Token: 0x0401187B RID: 71803
		internal static int __PropertyOffset_OnValueChange;

		// Token: 0x0401187C RID: 71804
		[Nullable(2)]
		private FLGUIDrawableEvent _OnValueChange;
	}
}
