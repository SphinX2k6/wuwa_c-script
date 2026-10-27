using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020021A3 RID: 8611
	[UnrealObjectPath("/Script/LGUI.UIScrollbarComponent")]
	[UnrealStructLayout(1160, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1160)]
	public class UUIScrollbarComponent : UUISelectableComponent, IUnrealUObject, IUnrealObject, ILGUIPointerDragInterface, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x06020A8C RID: 133772 RVA: 0x00305449 File Offset: 0x00303649
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUIScrollbarComponent._ClassPtr;
		}

		// Token: 0x06020A8D RID: 133773 RVA: 0x00305455 File Offset: 0x00303655
		int ILGUIPointerDragInterface.InterfaceOffset()
		{
			return UUIScrollbarComponent.__InterfaceOffset_ILGUIPointerDragInterface;
		}

		// Token: 0x06020A8E RID: 133774 RVA: 0x0030545C File Offset: 0x0030365C
		public UUIScrollbarComponent() : this(BuiltinUtils.AllocNativeUObject(UUIScrollbarComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020A8F RID: 133775 RVA: 0x00305484 File Offset: 0x00303684
		[NullableContext(1)]
		public UUIScrollbarComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUIScrollbarComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007FA7 RID: 32679
		// (get) Token: 0x06020A90 RID: 133776 RVA: 0x003054B7 File Offset: 0x003036B7
		// (set) Token: 0x06020A91 RID: 133777 RVA: 0x003054C7 File Offset: 0x003036C7
		public unsafe float Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIScrollbarComponent.__PropertyOffset_Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIScrollbarComponent.__PropertyOffset_Value) = value;
			}
		}

		// Token: 0x17007FA8 RID: 32680
		// (get) Token: 0x06020A92 RID: 133778 RVA: 0x003054D8 File Offset: 0x003036D8
		// (set) Token: 0x06020A93 RID: 133779 RVA: 0x003054E8 File Offset: 0x003036E8
		public unsafe float Size
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIScrollbarComponent.__PropertyOffset_Size);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIScrollbarComponent.__PropertyOffset_Size) = value;
			}
		}

		// Token: 0x17007FA9 RID: 32681
		// (get) Token: 0x06020A94 RID: 133780 RVA: 0x003054F9 File Offset: 0x003036F9
		// (set) Token: 0x06020A95 RID: 133781 RVA: 0x0030550D File Offset: 0x0030370D
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
				return *(base.NativePtr + (IntPtr)UUIScrollbarComponent.__PropertyOffset_HandleActor);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UUIScrollbarComponent.__PropertyOffset_HandleActor) = value;
			}
		}

		// Token: 0x17007FAA RID: 32682
		// (get) Token: 0x06020A96 RID: 133782 RVA: 0x00305522 File Offset: 0x00303722
		// (set) Token: 0x06020A97 RID: 133783 RVA: 0x00305532 File Offset: 0x00303732
		public unsafe UIScrollbarDirectionType DirectionType
		{
			get
			{
				return (UIScrollbarDirectionType)(*(base.NativePtr + (IntPtr)UUIScrollbarComponent.__PropertyOffset_DirectionType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIScrollbarComponent.__PropertyOffset_DirectionType) = (byte)value;
			}
		}

		// Token: 0x17007FAB RID: 32683
		// (get) Token: 0x06020A98 RID: 133784 RVA: 0x00305543 File Offset: 0x00303743
		// (set) Token: 0x06020A99 RID: 133785 RVA: 0x00305557 File Offset: 0x00303757
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
				return *(base.NativePtr + (IntPtr)UUIScrollbarComponent.__PropertyOffset_Handle);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UUIScrollbarComponent.__PropertyOffset_Handle) = value;
			}
		}

		// Token: 0x17007FAC RID: 32684
		// (get) Token: 0x06020A9A RID: 133786 RVA: 0x0030556C File Offset: 0x0030376C
		// (set) Token: 0x06020A9B RID: 133787 RVA: 0x00305580 File Offset: 0x00303780
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
				return *(base.NativePtr + (IntPtr)UUIScrollbarComponent.__PropertyOffset_HandleArea);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UUIScrollbarComponent.__PropertyOffset_HandleArea) = value;
			}
		}

		// Token: 0x17007FAD RID: 32685
		// (get) Token: 0x06020A9C RID: 133788 RVA: 0x00305598 File Offset: 0x00303798
		// (set) Token: 0x06020A9D RID: 133789 RVA: 0x003055D1 File Offset: 0x003037D1
		[Nullable(1)]
		public FLGUIDrawableEvent OnValueChange
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FLGUIDrawableEvent result;
				if ((result = this._OnValueChange) == null)
				{
					result = (this._OnValueChange = new FLGUIDrawableEvent(base.NativePtr + (IntPtr)UUIScrollbarComponent.__PropertyOffset_OnValueChange, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FLGUIDrawableEvent.StaticStruct(), base.NativePtr + (IntPtr)UUIScrollbarComponent.__PropertyOffset_OnValueChange, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007FAE RID: 32686
		// (get) Token: 0x06020A9E RID: 133790 RVA: 0x003055F2 File Offset: 0x003037F2
		// (set) Token: 0x06020A9F RID: 133791 RVA: 0x00305606 File Offset: 0x00303806
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<AActor> ScrollViewBackgroundActor
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UUIScrollbarComponent.__PropertyOffset_ScrollViewBackgroundActor);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UUIScrollbarComponent.__PropertyOffset_ScrollViewBackgroundActor) = value;
			}
		}

		// Token: 0x17007FAF RID: 32687
		// (get) Token: 0x06020AA0 RID: 133792 RVA: 0x0030561B File Offset: 0x0030381B
		// (set) Token: 0x06020AA1 RID: 133793 RVA: 0x0030562F File Offset: 0x0030382F
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<UUIItem> ScrollViewBackgroundComponent
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UUIScrollbarComponent.__PropertyOffset_ScrollViewBackgroundComponent);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UUIScrollbarComponent.__PropertyOffset_ScrollViewBackgroundComponent) = value;
			}
		}

		// Token: 0x17007FB0 RID: 32688
		// (get) Token: 0x06020AA2 RID: 133794 RVA: 0x00305644 File Offset: 0x00303844
		// (set) Token: 0x06020AA3 RID: 133795 RVA: 0x00305654 File Offset: 0x00303854
		public unsafe bool MainScrollbar
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIScrollbarComponent.__PropertyOffset_MainScrollbar) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIScrollbarComponent.__PropertyOffset_MainScrollbar) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007FB1 RID: 32689
		// (get) Token: 0x06020AA4 RID: 133796 RVA: 0x00305665 File Offset: 0x00303865
		// (set) Token: 0x06020AA5 RID: 133797 RVA: 0x00305675 File Offset: 0x00303875
		public unsafe int ViewId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIScrollbarComponent.__PropertyOffset_ViewId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIScrollbarComponent.__PropertyOffset_ViewId) = value;
			}
		}

		// Token: 0x06020AA6 RID: 133798 RVA: 0x00305686 File Offset: 0x00303886
		[NullableContext(2)]
		public void UnregisterSlideEvent(in FLGUIDelegateHandleWrapper InDelegateHandle)
		{
			UUIScrollbarComponent.__UnregisterSlideEvent_Internal(base.NativePtr, (InDelegateHandle ?? new FLGUIDelegateHandleWrapper()).NativePtr);
		}

		// Token: 0x06020AA7 RID: 133799 RVA: 0x003056A3 File Offset: 0x003038A3
		public void SetValueAndSize(float InValue, float InSize, bool FireEvent = true)
		{
			UUIScrollbarComponent.__SetValueAndSize_Internal(base.NativePtr, InValue, InSize, FireEvent);
		}

		// Token: 0x06020AA8 RID: 133800 RVA: 0x003056B3 File Offset: 0x003038B3
		public void SetValue(float InValue, bool FireEvent = true)
		{
			UUIScrollbarComponent.__SetValue_Internal(base.NativePtr, InValue, FireEvent);
		}

		// Token: 0x06020AA9 RID: 133801 RVA: 0x003056C2 File Offset: 0x003038C2
		public void SetSize(float InSize)
		{
			UUIScrollbarComponent.__SetSize_Internal(base.NativePtr, InSize);
		}

		// Token: 0x06020AAA RID: 133802 RVA: 0x003056D0 File Offset: 0x003038D0
		[NullableContext(2)]
		public static void SetScrollbarDelegate(in FLGUIScrollbarDelegate Delegate)
		{
			FLGUIScrollbarDelegate flguiscrollbarDelegate = Delegate;
			UUIScrollbarComponent.__SetScrollbarDelegate_Internal((flguiscrollbarDelegate != null) ? flguiscrollbarDelegate.NativePtr : ((IntPtr)0));
		}

		// Token: 0x06020AAB RID: 133803
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void ResetScrollbarDelegate();

		// Token: 0x06020AAC RID: 133804 RVA: 0x003056E6 File Offset: 0x003038E6
		[NullableContext(1)]
		public FLGUIDelegateHandleWrapper RegisterSlideEvent([Nullable(2)] in FLGUIScrollbarDynamicDelegate InDelegate)
		{
			IntPtr nativePtr = base.NativePtr;
			FLGUIScrollbarDynamicDelegate flguiscrollbarDynamicDelegate = InDelegate;
			return new FLGUIDelegateHandleWrapper(UUIScrollbarComponent.__RegisterSlideEvent_Internal(nativePtr, (flguiscrollbarDynamicDelegate != null) ? flguiscrollbarDynamicDelegate.NativePtr : ((IntPtr)0)), null);
		}

		// Token: 0x06020AAD RID: 133805 RVA: 0x00305708 File Offset: 0x00303908
		public float GetValue()
		{
			return UUIScrollbarComponent.__GetValue_Internal(base.NativePtr);
		}

		// Token: 0x06020AAE RID: 133806 RVA: 0x00305715 File Offset: 0x00303915
		public float GetSize()
		{
			return UUIScrollbarComponent.__GetSize_Internal(base.NativePtr);
		}

		// Token: 0x06020AAF RID: 133807 RVA: 0x00305722 File Offset: 0x00303922
		public void ChangeSchedule(ELGUINavigationDirection InDirection)
		{
			UUIScrollbarComponent.__ChangeSchedule_Internal(base.NativePtr, InDirection);
		}

		// Token: 0x06020AB0 RID: 133808
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UnregisterSlideEvent_Internal(IntPtr @this, IntPtr InDelegateHandle);

		// Token: 0x06020AB1 RID: 133809
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetValueAndSize_Internal(IntPtr @this, float InValue, float InSize, bool FireEvent);

		// Token: 0x06020AB2 RID: 133810
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetValue_Internal(IntPtr @this, float InValue, bool FireEvent);

		// Token: 0x06020AB3 RID: 133811
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSize_Internal(IntPtr @this, float InSize);

		// Token: 0x06020AB4 RID: 133812
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetScrollbarDelegate_Internal(IntPtr Delegate);

		// Token: 0x06020AB5 RID: 133813
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __RegisterSlideEvent_Internal(IntPtr @this, IntPtr InDelegate);

		// Token: 0x06020AB6 RID: 133814
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetValue_Internal(IntPtr @this);

		// Token: 0x06020AB7 RID: 133815
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetSize_Internal(IntPtr @this);

		// Token: 0x06020AB8 RID: 133816
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ChangeSchedule_Internal(IntPtr @this, ELGUINavigationDirection InDirection);

		// Token: 0x06020AB9 RID: 133817 RVA: 0x00305730 File Offset: 0x00303930
		static UUIScrollbarComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIScrollbarComponent");
		}

		// Token: 0x06020ABA RID: 133818 RVA: 0x0030573E File Offset: 0x0030393E
		protected UUIScrollbarComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011798 RID: 71576
		internal static int __InterfaceOffset_ILGUIPointerDragInterface;

		// Token: 0x04011799 RID: 71577
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UIScrollbarComponent";

		// Token: 0x0401179A RID: 71578
		private static IntPtr _ClassPtr;

		// Token: 0x0401179B RID: 71579
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401179C RID: 71580
		internal static int __PropertyOffset_Value;

		// Token: 0x0401179D RID: 71581
		internal static int __PropertyOffset_Size;

		// Token: 0x0401179E RID: 71582
		internal static int __PropertyOffset_HandleActor;

		// Token: 0x0401179F RID: 71583
		internal static int __PropertyOffset_DirectionType;

		// Token: 0x040117A0 RID: 71584
		internal static int __PropertyOffset_Handle;

		// Token: 0x040117A1 RID: 71585
		internal static int __PropertyOffset_HandleArea;

		// Token: 0x040117A2 RID: 71586
		internal static int __PropertyOffset_OnValueChange;

		// Token: 0x040117A3 RID: 71587
		[Nullable(2)]
		private FLGUIDrawableEvent _OnValueChange;

		// Token: 0x040117A4 RID: 71588
		internal static int __PropertyOffset_ScrollViewBackgroundActor;

		// Token: 0x040117A5 RID: 71589
		internal static int __PropertyOffset_ScrollViewBackgroundComponent;

		// Token: 0x040117A6 RID: 71590
		internal static int __PropertyOffset_MainScrollbar;

		// Token: 0x040117A7 RID: 71591
		internal static int __PropertyOffset_ViewId;
	}
}
