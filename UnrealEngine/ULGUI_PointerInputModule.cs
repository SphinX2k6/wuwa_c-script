using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020020E3 RID: 8419
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.LGUI_PointerInputModule")]
	[UnrealStructLayout(296, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 296)]
	public abstract class ULGUI_PointerInputModule : ULGUIBaseInputModule, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601FB3C RID: 129852 RVA: 0x002F24E6 File Offset: 0x002F06E6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULGUI_PointerInputModule._ClassPtr;
		}

		// Token: 0x17007CE6 RID: 31974
		// (get) Token: 0x0601FB3D RID: 129853 RVA: 0x002F24F2 File Offset: 0x002F06F2
		// (set) Token: 0x0601FB3E RID: 129854 RVA: 0x002F2506 File Offset: 0x002F0706
		public unsafe ULGUIEventSystem eventSystem
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ULGUIEventSystem>(base.NativePtr / (IntPtr)sizeof(void*) + ULGUI_PointerInputModule.__PropertyOffset_eventSystem);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ULGUI_PointerInputModule.__PropertyOffset_eventSystem, value);
			}
		}

		// Token: 0x0601FB3F RID: 129855 RVA: 0x002F251B File Offset: 0x002F071B
		public void UpdateNavigation(USceneComponent NewSelectable)
		{
			ULGUI_PointerInputModule.__UpdateNavigation_Internal(base.NativePtr, (NewSelectable != null) ? NewSelectable.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601FB40 RID: 129856 RVA: 0x002F2538 File Offset: 0x002F0738
		public void UnregisterInputChangeEvent(FLGUIDelegateHandleWrapper delegateHandle)
		{
			ULGUI_PointerInputModule.__UnregisterInputChangeEvent_Internal(base.NativePtr, (delegateHandle ?? new FLGUIDelegateHandleWrapper()).NativePtr);
		}

		// Token: 0x0601FB41 RID: 129857 RVA: 0x002F2554 File Offset: 0x002F0754
		public void SwitchToNavigationInputType()
		{
			ULGUI_PointerInputModule.__SwitchToNavigationInputType_Internal(base.NativePtr);
		}

		// Token: 0x0601FB42 RID: 129858 RVA: 0x002F2561 File Offset: 0x002F0761
		public void SetCurrentInputKeyType(EInputKeyType InputKeyType)
		{
			ULGUI_PointerInputModule.__SetCurrentInputKeyType_Internal(base.NativePtr, InputKeyType);
		}

		// Token: 0x0601FB43 RID: 129859 RVA: 0x002F256F File Offset: 0x002F076F
		public void SetClickThreshold(float Value)
		{
			ULGUI_PointerInputModule.__SetClickThreshold_Internal(base.NativePtr, Value);
		}

		// Token: 0x0601FB44 RID: 129860 RVA: 0x002F257D File Offset: 0x002F077D
		[NullableContext(1)]
		public FLGUIDelegateHandleWrapper RegisterInputChangeEvent([Nullable(2)] in FLGUIPointerInputChange_DynamicDelegate pointerInputChange)
		{
			IntPtr nativePtr = base.NativePtr;
			FLGUIPointerInputChange_DynamicDelegate flguipointerInputChange_DynamicDelegate = pointerInputChange;
			return new FLGUIDelegateHandleWrapper(ULGUI_PointerInputModule.__RegisterInputChangeEvent_Internal(nativePtr, (flguipointerInputChange_DynamicDelegate != null) ? flguipointerInputChange_DynamicDelegate.NativePtr : ((IntPtr)0)), null);
		}

		// Token: 0x0601FB45 RID: 129861 RVA: 0x002F259F File Offset: 0x002F079F
		public bool IsPointerEventDataLineTrace(ULGUIPointerEventData InPointerEventData)
		{
			return ULGUI_PointerInputModule.__IsPointerEventDataLineTrace_Internal(base.NativePtr, (InPointerEventData != null) ? InPointerEventData.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601FB46 RID: 129862 RVA: 0x002F25BC File Offset: 0x002F07BC
		public void InputTriggerForNavigation(bool triggerPress)
		{
			ULGUI_PointerInputModule.__InputTriggerForNavigation_Internal(base.NativePtr, triggerPress);
		}

		// Token: 0x0601FB47 RID: 129863 RVA: 0x002F25CA File Offset: 0x002F07CA
		public void InputNavigation(ELGUINavigationDirection direction, bool pressOrRelease)
		{
			ULGUI_PointerInputModule.__InputNavigation_Internal(base.NativePtr, direction, pressOrRelease);
		}

		// Token: 0x0601FB48 RID: 129864 RVA: 0x002F25D9 File Offset: 0x002F07D9
		public ULGUIPointerEventData GetPointerEventData(int PointerId, bool CreateIfNotExist = false)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULGUIPointerEventData>(ULGUI_PointerInputModule.__GetPointerEventData_Internal(base.NativePtr, PointerId, CreateIfNotExist));
		}

		// Token: 0x0601FB49 RID: 129865 RVA: 0x002F25ED File Offset: 0x002F07ED
		public UUIItem GetNowHitComponent()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UUIItem>(ULGUI_PointerInputModule.__GetNowHitComponent_Internal(base.NativePtr));
		}

		// Token: 0x0601FB4A RID: 129866 RVA: 0x002F25FF File Offset: 0x002F07FF
		public EInputKeyType GetCurrentInputKeyType()
		{
			return ULGUI_PointerInputModule.__GetCurrentInputKeyType_Internal(base.NativePtr);
		}

		// Token: 0x0601FB4B RID: 129867
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateNavigation_Internal(IntPtr @this, IntPtr NewSelectable);

		// Token: 0x0601FB4C RID: 129868
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UnregisterInputChangeEvent_Internal(IntPtr @this, IntPtr delegateHandle);

		// Token: 0x0601FB4D RID: 129869
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SwitchToNavigationInputType_Internal(IntPtr @this);

		// Token: 0x0601FB4E RID: 129870
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCurrentInputKeyType_Internal(IntPtr @this, EInputKeyType InputKeyType);

		// Token: 0x0601FB4F RID: 129871
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetClickThreshold_Internal(IntPtr @this, float Value);

		// Token: 0x0601FB50 RID: 129872
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __RegisterInputChangeEvent_Internal(IntPtr @this, IntPtr pointerInputChange);

		// Token: 0x0601FB51 RID: 129873
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsPointerEventDataLineTrace_Internal(IntPtr @this, IntPtr InPointerEventData);

		// Token: 0x0601FB52 RID: 129874
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InputTriggerForNavigation_Internal(IntPtr @this, bool triggerPress);

		// Token: 0x0601FB53 RID: 129875
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InputNavigation_Internal(IntPtr @this, ELGUINavigationDirection direction, bool pressOrRelease);

		// Token: 0x0601FB54 RID: 129876
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetPointerEventData_Internal(IntPtr @this, int PointerId, bool CreateIfNotExist);

		// Token: 0x0601FB55 RID: 129877
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetNowHitComponent_Internal(IntPtr @this);

		// Token: 0x0601FB56 RID: 129878
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern EInputKeyType __GetCurrentInputKeyType_Internal(IntPtr @this);

		// Token: 0x0601FB57 RID: 129879 RVA: 0x002F260C File Offset: 0x002F080C
		static ULGUI_PointerInputModule()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.LGUI_PointerInputModule");
		}

		// Token: 0x0601FB58 RID: 129880 RVA: 0x002F261C File Offset: 0x002F081C
		protected ULGUI_PointerInputModule() : this(BuiltinUtils.AllocNativeUObject(ULGUI_PointerInputModule.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601FB59 RID: 129881 RVA: 0x002F2644 File Offset: 0x002F0844
		protected ULGUI_PointerInputModule(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011196 RID: 70038
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.LGUI_PointerInputModule";

		// Token: 0x04011197 RID: 70039
		private static IntPtr _ClassPtr;

		// Token: 0x04011198 RID: 70040
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011199 RID: 70041
		internal static int __PropertyOffset_eventSystem;
	}
}
