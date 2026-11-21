using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000725 RID: 1829
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.UISliderComponent")]
	[UnrealStructLayout(1320, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1320)]
	public class UUISliderComponent : UUISelectableComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06009E9D RID: 40605 RVA: 0x000EBB96 File Offset: 0x000E9D96
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUISliderComponent._ClassPtr;
		}

		// Token: 0x06009E9E RID: 40606 RVA: 0x000EBBA4 File Offset: 0x000E9DA4
		public UUISliderComponent() : this(BuiltinUtils.AllocNativeUObject(UUISliderComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06009E9F RID: 40607 RVA: 0x000EBBCC File Offset: 0x000E9DCC
		[NullableContext(1)]
		public UUISliderComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUISliderComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001D6E RID: 7534
		// (get) Token: 0x06009EA0 RID: 40608 RVA: 0x000EBBFF File Offset: 0x000E9DFF
		// (set) Token: 0x06009EA1 RID: 40609 RVA: 0x000EBC0F File Offset: 0x000E9E0F
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

		// Token: 0x17001D6F RID: 7535
		// (get) Token: 0x06009EA2 RID: 40610 RVA: 0x000EBC20 File Offset: 0x000E9E20
		// (set) Token: 0x06009EA3 RID: 40611 RVA: 0x000EBC30 File Offset: 0x000E9E30
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

		// Token: 0x17001D70 RID: 7536
		// (get) Token: 0x06009EA4 RID: 40612 RVA: 0x000EBC41 File Offset: 0x000E9E41
		// (set) Token: 0x06009EA5 RID: 40613 RVA: 0x000EBC51 File Offset: 0x000E9E51
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

		// Token: 0x17001D71 RID: 7537
		// (get) Token: 0x06009EA6 RID: 40614 RVA: 0x000EBC62 File Offset: 0x000E9E62
		// (set) Token: 0x06009EA7 RID: 40615 RVA: 0x000EBC72 File Offset: 0x000E9E72
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

		// Token: 0x17001D72 RID: 7538
		// (get) Token: 0x06009EA8 RID: 40616 RVA: 0x000EBC83 File Offset: 0x000E9E83
		// (set) Token: 0x06009EA9 RID: 40617 RVA: 0x000EBC97 File Offset: 0x000E9E97
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

		// Token: 0x17001D73 RID: 7539
		// (get) Token: 0x06009EAA RID: 40618 RVA: 0x000EBCAC File Offset: 0x000E9EAC
		// (set) Token: 0x06009EAB RID: 40619 RVA: 0x000EBCC0 File Offset: 0x000E9EC0
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

		// Token: 0x17001D74 RID: 7540
		// (get) Token: 0x06009EAC RID: 40620 RVA: 0x000EBCD8 File Offset: 0x000E9ED8
		// (set) Token: 0x06009EAD RID: 40621 RVA: 0x000EBD11 File Offset: 0x000E9F11
		[Nullable(1)]
		public FLGUISliderDynamicDelegate OnValueChangeCb
		{
			[NullableContext(1)]
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
			[NullableContext(1)]
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UUISliderComponent.__PropertyOffset_OnValueChangeCb, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17001D75 RID: 7541
		// (get) Token: 0x06009EAE RID: 40622 RVA: 0x000EBD34 File Offset: 0x000E9F34
		// (set) Token: 0x06009EAF RID: 40623 RVA: 0x000EBD6D File Offset: 0x000E9F6D
		[Nullable(1)]
		public FLGUISliderEndDragDelegate OnEndDragCb
		{
			[NullableContext(1)]
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
			[NullableContext(1)]
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UUISliderComponent.__PropertyOffset_OnEndDragCb, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17001D76 RID: 7542
		// (get) Token: 0x06009EB0 RID: 40624 RVA: 0x000EBD90 File Offset: 0x000E9F90
		// (set) Token: 0x06009EB1 RID: 40625 RVA: 0x000EBDC9 File Offset: 0x000E9FC9
		[Nullable(1)]
		public FLGUISliderPointUpDelegateOneParams OnPointUpCallBack
		{
			[NullableContext(1)]
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
			[NullableContext(1)]
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UUISliderComponent.__PropertyOffset_OnPointUpCallBack, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17001D77 RID: 7543
		// (get) Token: 0x06009EB2 RID: 40626 RVA: 0x000EBDEA File Offset: 0x000E9FEA
		// (set) Token: 0x06009EB3 RID: 40627 RVA: 0x000EBDFE File Offset: 0x000E9FFE
		public unsafe UAkAudioEvent DragBeginAudioEvent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAkAudioEvent>(base.NativePtr / (IntPtr)sizeof(void*) + UUISliderComponent.__PropertyOffset_DragBeginAudioEvent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UUISliderComponent.__PropertyOffset_DragBeginAudioEvent, value);
			}
		}

		// Token: 0x17001D78 RID: 7544
		// (get) Token: 0x06009EB4 RID: 40628 RVA: 0x000EBE13 File Offset: 0x000EA013
		// (set) Token: 0x06009EB5 RID: 40629 RVA: 0x000EBE27 File Offset: 0x000EA027
		public unsafe UAkAudioEvent DragEndAudioEvent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAkAudioEvent>(base.NativePtr / (IntPtr)sizeof(void*) + UUISliderComponent.__PropertyOffset_DragEndAudioEvent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UUISliderComponent.__PropertyOffset_DragEndAudioEvent, value);
			}
		}

		// Token: 0x17001D79 RID: 7545
		// (get) Token: 0x06009EB6 RID: 40630 RVA: 0x000EBE3C File Offset: 0x000EA03C
		// (set) Token: 0x06009EB7 RID: 40631 RVA: 0x000EBE50 File Offset: 0x000EA050
		public unsafe UAkAudioEvent DraggingAudioEvent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAkAudioEvent>(base.NativePtr / (IntPtr)sizeof(void*) + UUISliderComponent.__PropertyOffset_DraggingAudioEvent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UUISliderComponent.__PropertyOffset_DraggingAudioEvent, value);
			}
		}

		// Token: 0x17001D7A RID: 7546
		// (get) Token: 0x06009EB8 RID: 40632 RVA: 0x000EBE65 File Offset: 0x000EA065
		// (set) Token: 0x06009EB9 RID: 40633 RVA: 0x000EBE75 File Offset: 0x000EA075
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

		// Token: 0x17001D7B RID: 7547
		// (get) Token: 0x06009EBA RID: 40634 RVA: 0x000EBE86 File Offset: 0x000EA086
		// (set) Token: 0x06009EBB RID: 40635 RVA: 0x000EBE9A File Offset: 0x000EA09A
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

		// Token: 0x17001D7C RID: 7548
		// (get) Token: 0x06009EBC RID: 40636 RVA: 0x000EBEAF File Offset: 0x000EA0AF
		// (set) Token: 0x06009EBD RID: 40637 RVA: 0x000EBEC3 File Offset: 0x000EA0C3
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

		// Token: 0x17001D7D RID: 7549
		// (get) Token: 0x06009EBE RID: 40638 RVA: 0x000EBED8 File Offset: 0x000EA0D8
		// (set) Token: 0x06009EBF RID: 40639 RVA: 0x000EBEEC File Offset: 0x000EA0EC
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

		// Token: 0x17001D7E RID: 7550
		// (get) Token: 0x06009EC0 RID: 40640 RVA: 0x000EBF01 File Offset: 0x000EA101
		// (set) Token: 0x06009EC1 RID: 40641 RVA: 0x000EBF15 File Offset: 0x000EA115
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

		// Token: 0x06009EC2 RID: 40642 RVA: 0x000EBF2A File Offset: 0x000EA12A
		public void UnregisterSlideEvent(in FLGUIDelegateHandleWrapper InDelegateHandle)
		{
			UUISliderComponent.__UnregisterSlideEvent_Internal(base.NativePtr, (InDelegateHandle ?? new FLGUIDelegateHandleWrapper()).NativePtr);
		}

		// Token: 0x06009EC3 RID: 40643 RVA: 0x000EBF47 File Offset: 0x000EA147
		public void SetValueWithAudio(float InValue, bool FireEvent = true)
		{
			UUISliderComponent.__SetValueWithAudio_Internal(base.NativePtr, InValue, FireEvent);
		}

		// Token: 0x06009EC4 RID: 40644 RVA: 0x000EBF56 File Offset: 0x000EA156
		public void SetValue(float InValue, bool FireEvent = true)
		{
			UUISliderComponent.__SetValue_Internal(base.NativePtr, InValue, FireEvent);
		}

		// Token: 0x06009EC5 RID: 40645 RVA: 0x000EBF65 File Offset: 0x000EA165
		public void SetProgressIncrement(float incrementValue, bool needRound = true, bool NeedAudio = false)
		{
			UUISliderComponent.__SetProgressIncrement_Internal(base.NativePtr, incrementValue, needRound, NeedAudio);
		}

		// Token: 0x06009EC6 RID: 40646 RVA: 0x000EBF75 File Offset: 0x000EA175
		public void SetMinValue(float InMinValue, bool KeepRelativeValue, bool FireEvent = true)
		{
			UUISliderComponent.__SetMinValue_Internal(base.NativePtr, InMinValue, KeepRelativeValue, FireEvent);
		}

		// Token: 0x06009EC7 RID: 40647 RVA: 0x000EBF85 File Offset: 0x000EA185
		public void SetMaxValue(float InMaxValue, bool KeepRelativeValue, bool FireEvent = true)
		{
			UUISliderComponent.__SetMaxValue_Internal(base.NativePtr, InMaxValue, KeepRelativeValue, FireEvent);
		}

		// Token: 0x06009EC8 RID: 40648 RVA: 0x000EBF95 File Offset: 0x000EA195
		[NullableContext(1)]
		public FLGUIDelegateHandleWrapper RegisterSlideEvent([Nullable(2)] in FLGUISliderDynamicDelegate InDelegate)
		{
			IntPtr nativePtr = base.NativePtr;
			FLGUISliderDynamicDelegate flguisliderDynamicDelegate = InDelegate;
			return new FLGUIDelegateHandleWrapper(UUISliderComponent.__RegisterSlideEvent_Internal(nativePtr, (flguisliderDynamicDelegate != null) ? flguisliderDynamicDelegate.NativePtr : ((IntPtr)0)), null);
		}

		// Token: 0x06009EC9 RID: 40649 RVA: 0x000EBFB7 File Offset: 0x000EA1B7
		public float GetValue()
		{
			return UUISliderComponent.__GetValue_Internal(base.NativePtr);
		}

		// Token: 0x06009ECA RID: 40650 RVA: 0x000EBFC4 File Offset: 0x000EA1C4
		public float GetMinValue()
		{
			return UUISliderComponent.__GetMinValue_Internal(base.NativePtr);
		}

		// Token: 0x06009ECB RID: 40651 RVA: 0x000EBFD1 File Offset: 0x000EA1D1
		public float GetMaxValue()
		{
			return UUISliderComponent.__GetMaxValue_Internal(base.NativePtr);
		}

		// Token: 0x06009ECC RID: 40652
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UnregisterSlideEvent_Internal(IntPtr @this, IntPtr InDelegateHandle);

		// Token: 0x06009ECD RID: 40653
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetValueWithAudio_Internal(IntPtr @this, float InValue, bool FireEvent);

		// Token: 0x06009ECE RID: 40654
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetValue_Internal(IntPtr @this, float InValue, bool FireEvent);

		// Token: 0x06009ECF RID: 40655
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetProgressIncrement_Internal(IntPtr @this, float incrementValue, bool needRound, bool NeedAudio);

		// Token: 0x06009ED0 RID: 40656
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMinValue_Internal(IntPtr @this, float InMinValue, bool KeepRelativeValue, bool FireEvent);

		// Token: 0x06009ED1 RID: 40657
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMaxValue_Internal(IntPtr @this, float InMaxValue, bool KeepRelativeValue, bool FireEvent);

		// Token: 0x06009ED2 RID: 40658
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __RegisterSlideEvent_Internal(IntPtr @this, IntPtr InDelegate);

		// Token: 0x06009ED3 RID: 40659
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetValue_Internal(IntPtr @this);

		// Token: 0x06009ED4 RID: 40660
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetMinValue_Internal(IntPtr @this);

		// Token: 0x06009ED5 RID: 40661
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetMaxValue_Internal(IntPtr @this);

		// Token: 0x06009ED6 RID: 40662 RVA: 0x000EBFDE File Offset: 0x000EA1DE
		static UUISliderComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UISliderComponent");
		}

		// Token: 0x06009ED7 RID: 40663 RVA: 0x000EBFEC File Offset: 0x000EA1EC
		protected UUISliderComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04004411 RID: 17425
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UISliderComponent";

		// Token: 0x04004412 RID: 17426
		private static IntPtr _ClassPtr;

		// Token: 0x04004413 RID: 17427
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04004414 RID: 17428
		internal static int __PropertyOffset_Value;

		// Token: 0x04004415 RID: 17429
		internal static int __PropertyOffset_MinValue;

		// Token: 0x04004416 RID: 17430
		internal static int __PropertyOffset_MaxValue;

		// Token: 0x04004417 RID: 17431
		internal static int __PropertyOffset_WholeNumbers;

		// Token: 0x04004418 RID: 17432
		internal static int __PropertyOffset_FillActor;

		// Token: 0x04004419 RID: 17433
		internal static int __PropertyOffset_HandleActor;

		// Token: 0x0400441A RID: 17434
		internal static int __PropertyOffset_OnValueChangeCb;

		// Token: 0x0400441B RID: 17435
		private FLGUISliderDynamicDelegate _OnValueChangeCb;

		// Token: 0x0400441C RID: 17436
		internal static int __PropertyOffset_OnEndDragCb;

		// Token: 0x0400441D RID: 17437
		private FLGUISliderEndDragDelegate _OnEndDragCb;

		// Token: 0x0400441E RID: 17438
		internal static int __PropertyOffset_OnPointUpCallBack;

		// Token: 0x0400441F RID: 17439
		private FLGUISliderPointUpDelegateOneParams _OnPointUpCallBack;

		// Token: 0x04004420 RID: 17440
		internal static int __PropertyOffset_DragBeginAudioEvent;

		// Token: 0x04004421 RID: 17441
		internal static int __PropertyOffset_DragEndAudioEvent;

		// Token: 0x04004422 RID: 17442
		internal static int __PropertyOffset_DraggingAudioEvent;

		// Token: 0x04004423 RID: 17443
		internal static int __PropertyOffset_DraggingAudioEventInterval;

		// Token: 0x04004424 RID: 17444
		internal static int __PropertyOffset_Fill;

		// Token: 0x04004425 RID: 17445
		internal static int __PropertyOffset_FillArea;

		// Token: 0x04004426 RID: 17446
		internal static int __PropertyOffset_Handle;

		// Token: 0x04004427 RID: 17447
		internal static int __PropertyOffset_HandleArea;
	}
}
