using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020006CC RID: 1740
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.LGUI_PointerInputModule")]
	[UnrealStructLayout(296, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 296)]
	public abstract class ULGUI_PointerInputModule : ULGUIBaseInputModule, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06009463 RID: 37987 RVA: 0x000DFD5E File Offset: 0x000DDF5E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULGUI_PointerInputModule._ClassPtr;
		}

		// Token: 0x17001B9C RID: 7068
		// (get) Token: 0x06009464 RID: 37988 RVA: 0x000DFD6A File Offset: 0x000DDF6A
		// (set) Token: 0x06009465 RID: 37989 RVA: 0x000DFD7E File Offset: 0x000DDF7E
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

		// Token: 0x06009466 RID: 37990 RVA: 0x000DFD93 File Offset: 0x000DDF93
		public void UpdateNavigation(USceneComponent NewSelectable)
		{
			ULGUI_PointerInputModule.__UpdateNavigation_Internal(base.NativePtr, (NewSelectable != null) ? NewSelectable.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06009467 RID: 37991 RVA: 0x000DFDB0 File Offset: 0x000DDFB0
		public void UnregisterInputChangeEvent(FLGUIDelegateHandleWrapper delegateHandle)
		{
			ULGUI_PointerInputModule.__UnregisterInputChangeEvent_Internal(base.NativePtr, (delegateHandle ?? new FLGUIDelegateHandleWrapper()).NativePtr);
		}

		// Token: 0x06009468 RID: 37992 RVA: 0x000DFDCC File Offset: 0x000DDFCC
		public void SwitchToNavigationInputType()
		{
			ULGUI_PointerInputModule.__SwitchToNavigationInputType_Internal(base.NativePtr);
		}

		// Token: 0x06009469 RID: 37993 RVA: 0x000DFDD9 File Offset: 0x000DDFD9
		public void SetCurrentInputKeyType(EInputKeyType InputKeyType)
		{
			ULGUI_PointerInputModule.__SetCurrentInputKeyType_Internal(base.NativePtr, InputKeyType);
		}

		// Token: 0x0600946A RID: 37994 RVA: 0x000DFDE7 File Offset: 0x000DDFE7
		public void SetClickThreshold(float Value)
		{
			ULGUI_PointerInputModule.__SetClickThreshold_Internal(base.NativePtr, Value);
		}

		// Token: 0x0600946B RID: 37995 RVA: 0x000DFDF5 File Offset: 0x000DDFF5
		[NullableContext(1)]
		public FLGUIDelegateHandleWrapper RegisterInputChangeEvent([Nullable(2)] in FLGUIPointerInputChange_DynamicDelegate pointerInputChange)
		{
			IntPtr nativePtr = base.NativePtr;
			FLGUIPointerInputChange_DynamicDelegate flguipointerInputChange_DynamicDelegate = pointerInputChange;
			return new FLGUIDelegateHandleWrapper(ULGUI_PointerInputModule.__RegisterInputChangeEvent_Internal(nativePtr, (flguipointerInputChange_DynamicDelegate != null) ? flguipointerInputChange_DynamicDelegate.NativePtr : ((IntPtr)0)), null);
		}

		// Token: 0x0600946C RID: 37996 RVA: 0x000DFE17 File Offset: 0x000DE017
		public bool IsPointerEventDataLineTrace(ULGUIPointerEventData InPointerEventData)
		{
			return ULGUI_PointerInputModule.__IsPointerEventDataLineTrace_Internal(base.NativePtr, (InPointerEventData != null) ? InPointerEventData.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600946D RID: 37997 RVA: 0x000DFE34 File Offset: 0x000DE034
		public void InputTriggerForNavigation(bool triggerPress)
		{
			ULGUI_PointerInputModule.__InputTriggerForNavigation_Internal(base.NativePtr, triggerPress);
		}

		// Token: 0x0600946E RID: 37998 RVA: 0x000DFE42 File Offset: 0x000DE042
		public void InputNavigation(ELGUINavigationDirection direction, bool pressOrRelease)
		{
			ULGUI_PointerInputModule.__InputNavigation_Internal(base.NativePtr, direction, pressOrRelease);
		}

		// Token: 0x0600946F RID: 37999 RVA: 0x000DFE51 File Offset: 0x000DE051
		public ULGUIPointerEventData GetPointerEventData(int PointerId, bool CreateIfNotExist = false)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULGUIPointerEventData>(ULGUI_PointerInputModule.__GetPointerEventData_Internal(base.NativePtr, PointerId, CreateIfNotExist));
		}

		// Token: 0x06009470 RID: 38000 RVA: 0x000DFE65 File Offset: 0x000DE065
		public UUIItem GetNowHitComponent()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UUIItem>(ULGUI_PointerInputModule.__GetNowHitComponent_Internal(base.NativePtr));
		}

		// Token: 0x06009471 RID: 38001 RVA: 0x000DFE77 File Offset: 0x000DE077
		public EInputKeyType GetCurrentInputKeyType()
		{
			return ULGUI_PointerInputModule.__GetCurrentInputKeyType_Internal(base.NativePtr);
		}

		// Token: 0x06009472 RID: 38002
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateNavigation_Internal(IntPtr @this, IntPtr NewSelectable);

		// Token: 0x06009473 RID: 38003
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UnregisterInputChangeEvent_Internal(IntPtr @this, IntPtr delegateHandle);

		// Token: 0x06009474 RID: 38004
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SwitchToNavigationInputType_Internal(IntPtr @this);

		// Token: 0x06009475 RID: 38005
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCurrentInputKeyType_Internal(IntPtr @this, EInputKeyType InputKeyType);

		// Token: 0x06009476 RID: 38006
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetClickThreshold_Internal(IntPtr @this, float Value);

		// Token: 0x06009477 RID: 38007
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __RegisterInputChangeEvent_Internal(IntPtr @this, IntPtr pointerInputChange);

		// Token: 0x06009478 RID: 38008
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsPointerEventDataLineTrace_Internal(IntPtr @this, IntPtr InPointerEventData);

		// Token: 0x06009479 RID: 38009
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InputTriggerForNavigation_Internal(IntPtr @this, bool triggerPress);

		// Token: 0x0600947A RID: 38010
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InputNavigation_Internal(IntPtr @this, ELGUINavigationDirection direction, bool pressOrRelease);

		// Token: 0x0600947B RID: 38011
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetPointerEventData_Internal(IntPtr @this, int PointerId, bool CreateIfNotExist);

		// Token: 0x0600947C RID: 38012
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetNowHitComponent_Internal(IntPtr @this);

		// Token: 0x0600947D RID: 38013
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern EInputKeyType __GetCurrentInputKeyType_Internal(IntPtr @this);

		// Token: 0x0600947E RID: 38014 RVA: 0x000DFE84 File Offset: 0x000DE084
		static ULGUI_PointerInputModule()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.LGUI_PointerInputModule");
		}

		// Token: 0x0600947F RID: 38015 RVA: 0x000DFE94 File Offset: 0x000DE094
		protected ULGUI_PointerInputModule() : this(BuiltinUtils.AllocNativeUObject(ULGUI_PointerInputModule.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06009480 RID: 38016 RVA: 0x000DFEBC File Offset: 0x000DE0BC
		protected ULGUI_PointerInputModule(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400409F RID: 16543
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.LGUI_PointerInputModule";

		// Token: 0x040040A0 RID: 16544
		private static IntPtr _ClassPtr;

		// Token: 0x040040A1 RID: 16545
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040040A2 RID: 16546
		internal static int __PropertyOffset_eventSystem;
	}
}
