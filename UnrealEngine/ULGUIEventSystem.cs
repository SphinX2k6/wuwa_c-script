using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Script;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002070 RID: 8304
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.LGUIEventSystem")]
	[UnrealStructLayout(608, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 608)]
	public class ULGUIEventSystem : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601F511 RID: 128273 RVA: 0x002E839E File Offset: 0x002E659E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULGUIEventSystem._ClassPtr;
		}

		// Token: 0x0601F512 RID: 128274 RVA: 0x002E83AC File Offset: 0x002E65AC
		public ULGUIEventSystem() : this(BuiltinUtils.AllocNativeUObject(ULGUIEventSystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601F513 RID: 128275 RVA: 0x002E83D4 File Offset: 0x002E65D4
		[NullableContext(1)]
		public ULGUIEventSystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULGUIEventSystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007BBA RID: 31674
		// (get) Token: 0x0601F514 RID: 128276 RVA: 0x002E8408 File Offset: 0x002E6608
		// (set) Token: 0x0601F515 RID: 128277 RVA: 0x002E8441 File Offset: 0x002E6641
		[Nullable(1)]
		public FOnControllerConnectionChanged OnConnectionChanged
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FOnControllerConnectionChanged result;
				if ((result = this._OnConnectionChanged) == null)
				{
					result = (this._OnConnectionChanged = new FOnControllerConnectionChanged(base.NativePtr + (IntPtr)ULGUIEventSystem.__PropertyOffset_OnConnectionChanged, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)ULGUIEventSystem.__PropertyOffset_OnConnectionChanged, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17007BBB RID: 31675
		// (get) Token: 0x0601F516 RID: 128278 RVA: 0x002E8462 File Offset: 0x002E6662
		// (set) Token: 0x0601F517 RID: 128279 RVA: 0x002E8472 File Offset: 0x002E6672
		public unsafe bool bRayEventEnable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUIEventSystem.__PropertyOffset_bRayEventEnable) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUIEventSystem.__PropertyOffset_bRayEventEnable) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007BBC RID: 31676
		// (get) Token: 0x0601F518 RID: 128280 RVA: 0x002E8483 File Offset: 0x002E6683
		// (set) Token: 0x0601F519 RID: 128281 RVA: 0x002E8493 File Offset: 0x002E6693
		public unsafe bool HighlightWhenMouseMoveOut
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUIEventSystem.__PropertyOffset_HighlightWhenMouseMoveOut) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUIEventSystem.__PropertyOffset_HighlightWhenMouseMoveOut) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007BBD RID: 31677
		// (get) Token: 0x0601F51A RID: 128282 RVA: 0x002E84A4 File Offset: 0x002E66A4
		// (set) Token: 0x0601F51B RID: 128283 RVA: 0x002E84DD File Offset: 0x002E66DD
		[Nullable(1)]
		public TMap<int, ULGUIPointerEventData> pointerEventDataMap
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<int, ULGUIPointerEventData> result;
				if ((result = this._pointerEventDataMap) == null)
				{
					result = (this._pointerEventDataMap = new TMap<int, ULGUIPointerEventData>(base.NativePtr + (IntPtr)ULGUIEventSystem.__PropertyOffset_pointerEventDataMap, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.pointerEventDataMap.CopyAssign(value);
			}
		}

		// Token: 0x17007BBE RID: 31678
		// (get) Token: 0x0601F51C RID: 128284 RVA: 0x002E84EC File Offset: 0x002E66EC
		// (set) Token: 0x0601F51D RID: 128285 RVA: 0x002E8525 File Offset: 0x002E6725
		[Nullable(1)]
		public FLGUINavigationChangeDynamicDelegate NavigationChangeDelegate
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FLGUINavigationChangeDynamicDelegate result;
				if ((result = this._NavigationChangeDelegate) == null)
				{
					result = (this._NavigationChangeDelegate = new FLGUINavigationChangeDynamicDelegate(base.NativePtr + (IntPtr)ULGUIEventSystem.__PropertyOffset_NavigationChangeDelegate, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)ULGUIEventSystem.__PropertyOffset_NavigationChangeDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17007BBF RID: 31679
		// (get) Token: 0x0601F51E RID: 128286 RVA: 0x002E8548 File Offset: 0x002E6748
		// (set) Token: 0x0601F51F RID: 128287 RVA: 0x002E8581 File Offset: 0x002E6781
		[Nullable(1)]
		public FLGUIFindDefaultNavigationDelegate FindDefaultNavigationDelegate
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FLGUIFindDefaultNavigationDelegate result;
				if ((result = this._FindDefaultNavigationDelegate) == null)
				{
					result = (this._FindDefaultNavigationDelegate = new FLGUIFindDefaultNavigationDelegate(base.NativePtr + (IntPtr)ULGUIEventSystem.__PropertyOffset_FindDefaultNavigationDelegate, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)ULGUIEventSystem.__PropertyOffset_FindDefaultNavigationDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17007BC0 RID: 31680
		// (get) Token: 0x0601F520 RID: 128288 RVA: 0x002E85A4 File Offset: 0x002E67A4
		// (set) Token: 0x0601F521 RID: 128289 RVA: 0x002E85DD File Offset: 0x002E67DD
		[Nullable(1)]
		public FLGUITryFindNavigationDelegate TryFindNavigationDelegate
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FLGUITryFindNavigationDelegate result;
				if ((result = this._TryFindNavigationDelegate) == null)
				{
					result = (this._TryFindNavigationDelegate = new FLGUITryFindNavigationDelegate(base.NativePtr + (IntPtr)ULGUIEventSystem.__PropertyOffset_TryFindNavigationDelegate, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)ULGUIEventSystem.__PropertyOffset_TryFindNavigationDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17007BC1 RID: 31681
		// (get) Token: 0x0601F522 RID: 128290 RVA: 0x002E85FE File Offset: 0x002E67FE
		// (set) Token: 0x0601F523 RID: 128291 RVA: 0x002E860E File Offset: 0x002E680E
		public unsafe ELGUIPointerInputType defaultInputType
		{
			get
			{
				return (ELGUIPointerInputType)(*(base.NativePtr + (IntPtr)ULGUIEventSystem.__PropertyOffset_defaultInputType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUIEventSystem.__PropertyOffset_defaultInputType) = (byte)value;
			}
		}

		// Token: 0x17007BC2 RID: 31682
		// (get) Token: 0x0601F524 RID: 128292 RVA: 0x002E861F File Offset: 0x002E681F
		// (set) Token: 0x0601F525 RID: 128293 RVA: 0x002E862F File Offset: 0x002E682F
		public unsafe ELGUIEventFireType eventFireTypeForNavigation
		{
			get
			{
				return (ELGUIEventFireType)(*(base.NativePtr + (IntPtr)ULGUIEventSystem.__PropertyOffset_eventFireTypeForNavigation));
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUIEventSystem.__PropertyOffset_eventFireTypeForNavigation) = (byte)value;
			}
		}

		// Token: 0x17007BC3 RID: 31683
		// (get) Token: 0x0601F526 RID: 128294 RVA: 0x002E8640 File Offset: 0x002E6840
		// (set) Token: 0x0601F527 RID: 128295 RVA: 0x002E8650 File Offset: 0x002E6850
		public unsafe float navigateInputInterval
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUIEventSystem.__PropertyOffset_navigateInputInterval);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUIEventSystem.__PropertyOffset_navigateInputInterval) = value;
			}
		}

		// Token: 0x17007BC4 RID: 31684
		// (get) Token: 0x0601F528 RID: 128296 RVA: 0x002E8661 File Offset: 0x002E6861
		// (set) Token: 0x0601F529 RID: 128297 RVA: 0x002E8671 File Offset: 0x002E6871
		public unsafe float navigateInputIntervalForFirstTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUIEventSystem.__PropertyOffset_navigateInputIntervalForFirstTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUIEventSystem.__PropertyOffset_navigateInputIntervalForFirstTime) = value;
			}
		}

		// Token: 0x17007BC5 RID: 31685
		// (get) Token: 0x0601F52A RID: 128298 RVA: 0x002E8682 File Offset: 0x002E6882
		// (set) Token: 0x0601F52B RID: 128299 RVA: 0x002E8696 File Offset: 0x002E6896
		public unsafe USceneComponent selectedComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ULGUIEventSystem.__PropertyOffset_selectedComponent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ULGUIEventSystem.__PropertyOffset_selectedComponent, value);
			}
		}

		// Token: 0x17007BC6 RID: 31686
		// (get) Token: 0x0601F52C RID: 128300 RVA: 0x002E86AB File Offset: 0x002E68AB
		// (set) Token: 0x0601F52D RID: 128301 RVA: 0x002E86BF File Offset: 0x002E68BF
		public unsafe USceneComponent navigationComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ULGUIEventSystem.__PropertyOffset_navigationComponent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ULGUIEventSystem.__PropertyOffset_navigationComponent, value);
			}
		}

		// Token: 0x17007BC7 RID: 31687
		// (get) Token: 0x0601F52E RID: 128302 RVA: 0x002E86D4 File Offset: 0x002E68D4
		// (set) Token: 0x0601F52F RID: 128303 RVA: 0x002E86E8 File Offset: 0x002E68E8
		public unsafe USceneComponent preSelectedComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ULGUIEventSystem.__PropertyOffset_preSelectedComponent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ULGUIEventSystem.__PropertyOffset_preSelectedComponent, value);
			}
		}

		// Token: 0x17007BC8 RID: 31688
		// (get) Token: 0x0601F530 RID: 128304 RVA: 0x002E8700 File Offset: 0x002E6900
		// (set) Token: 0x0601F531 RID: 128305 RVA: 0x002E8739 File Offset: 0x002E6939
		[Nullable(1)]
		public FLGUIOnScrollTriggeredDelegate OnScrollTriggeredDelegate
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FLGUIOnScrollTriggeredDelegate result;
				if ((result = this._OnScrollTriggeredDelegate) == null)
				{
					result = (this._OnScrollTriggeredDelegate = new FLGUIOnScrollTriggeredDelegate(base.NativePtr + (IntPtr)ULGUIEventSystem.__PropertyOffset_OnScrollTriggeredDelegate, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)ULGUIEventSystem.__PropertyOffset_OnScrollTriggeredDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x0601F532 RID: 128306 RVA: 0x002E875A File Offset: 0x002E695A
		public void UnRegisterPointerEnterExitEvent()
		{
			ULGUIEventSystem.__UnRegisterPointerEnterExitEvent_Internal(base.NativePtr);
		}

		// Token: 0x0601F533 RID: 128307 RVA: 0x002E8767 File Offset: 0x002E6967
		public void UnregisterHitEvent(in FLGUIDelegateHandleWrapper InHandle)
		{
			ULGUIEventSystem.__UnregisterHitEvent_Internal(base.NativePtr, (InHandle ?? new FLGUIDelegateHandleWrapper()).NativePtr);
		}

		// Token: 0x0601F534 RID: 128308 RVA: 0x002E8784 File Offset: 0x002E6984
		public void UnregisterGlobalListener(in FLGUIDelegateHandleWrapper InHandle)
		{
			ULGUIEventSystem.__UnregisterGlobalListener_Internal(base.NativePtr, (InHandle ?? new FLGUIDelegateHandleWrapper()).NativePtr);
		}

		// Token: 0x0601F535 RID: 128309 RVA: 0x002E87A1 File Offset: 0x002E69A1
		public void SetSelectComponentWithDefault(USceneComponent InSelectComp)
		{
			ULGUIEventSystem.__SetSelectComponentWithDefault_Internal(base.NativePtr, (InSelectComp != null) ? InSelectComp.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601F536 RID: 128310 RVA: 0x002E87BE File Offset: 0x002E69BE
		public void SetSelectComponent(USceneComponent InSelectComp, ULGUIBaseEventData eventData, ELGUIEventFireType eventFireType)
		{
			ULGUIEventSystem.__SetSelectComponent_Internal(base.NativePtr, (InSelectComp != null) ? InSelectComp.NativePtr : IntPtr.Zero, (eventData != null) ? eventData.NativePtr : IntPtr.Zero, eventFireType);
		}

		// Token: 0x0601F537 RID: 128311 RVA: 0x002E87EC File Offset: 0x002E69EC
		public void SetRaycastEnable(bool enable, bool clearEvent = false)
		{
			ULGUIEventSystem.__SetRaycastEnable_Internal(base.NativePtr, enable, clearEvent);
		}

		// Token: 0x0601F538 RID: 128312 RVA: 0x002E87FB File Offset: 0x002E69FB
		public void RegisterPointerEnterExitEvent(in FLGUIPointerEnterExit_DynamicDelegate PointerEnterExitDelegate)
		{
			IntPtr nativePtr = base.NativePtr;
			FLGUIPointerEnterExit_DynamicDelegate flguipointerEnterExit_DynamicDelegate = PointerEnterExitDelegate;
			ULGUIEventSystem.__RegisterPointerEnterExitEvent_Internal(nativePtr, (flguipointerEnterExit_DynamicDelegate != null) ? flguipointerEnterExit_DynamicDelegate.NativePtr : ((IntPtr)0));
		}

		// Token: 0x0601F539 RID: 128313 RVA: 0x002E8817 File Offset: 0x002E6A17
		[NullableContext(1)]
		public FLGUIDelegateHandleWrapper RegisterHitEvent([Nullable(2)] in FLGUIHitDynamicDelegate InDelegate)
		{
			IntPtr nativePtr = base.NativePtr;
			FLGUIHitDynamicDelegate flguihitDynamicDelegate = InDelegate;
			return new FLGUIDelegateHandleWrapper(ULGUIEventSystem.__RegisterHitEvent_Internal(nativePtr, (flguihitDynamicDelegate != null) ? flguihitDynamicDelegate.NativePtr : ((IntPtr)0)), null);
		}

		// Token: 0x0601F53A RID: 128314 RVA: 0x002E8839 File Offset: 0x002E6A39
		[NullableContext(1)]
		public FLGUIDelegateHandleWrapper RegisterGlobalListener([Nullable(2)] in FLGUIBaseEventDynamicDelegate InDelegate)
		{
			IntPtr nativePtr = base.NativePtr;
			FLGUIBaseEventDynamicDelegate flguibaseEventDynamicDelegate = InDelegate;
			return new FLGUIDelegateHandleWrapper(ULGUIEventSystem.__RegisterGlobalListener_Internal(nativePtr, (flguibaseEventDynamicDelegate != null) ? flguibaseEventDynamicDelegate.NativePtr : ((IntPtr)0)), null);
		}

		// Token: 0x0601F53B RID: 128315 RVA: 0x002E885B File Offset: 0x002E6A5B
		public USceneComponent Navigate(ELGUINavigationDirection direction, UUISelectableComponent Selectable = null)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<USceneComponent>(ULGUIEventSystem.__Navigate_Internal(base.NativePtr, direction, (Selectable != null) ? Selectable.NativePtr : IntPtr.Zero));
		}

		// Token: 0x0601F53C RID: 128316 RVA: 0x002E887E File Offset: 0x002E6A7E
		public bool IsRaycastEnable()
		{
			return ULGUIEventSystem.__IsRaycastEnable_Internal(base.NativePtr);
		}

		// Token: 0x0601F53D RID: 128317 RVA: 0x002E888B File Offset: 0x002E6A8B
		public bool IsNavigationActive()
		{
			return ULGUIEventSystem.__IsNavigationActive_Internal(base.NativePtr);
		}

		// Token: 0x0601F53E RID: 128318 RVA: 0x002E8898 File Offset: 0x002E6A98
		public void InputTrigger(bool inTriggerPress, EMouseButtonType inMouseButtonType = EMouseButtonType.Left)
		{
			ULGUIEventSystem.__InputTrigger_Internal(base.NativePtr, inTriggerPress, inMouseButtonType);
		}

		// Token: 0x0601F53F RID: 128319 RVA: 0x002E88A8 File Offset: 0x002E6AA8
		public unsafe void InputScroll(in float inAxisValue)
		{
			fixed (float* ptr = &inAxisValue)
			{
				void* ptr2 = (void*)ptr;
				ULGUIEventSystem.__InputScroll_Internal(base.NativePtr, inAxisValue);
			}
		}

		// Token: 0x0601F540 RID: 128320 RVA: 0x002E88C9 File Offset: 0x002E6AC9
		public void InputNavigationUp()
		{
			ULGUIEventSystem.__InputNavigationUp_Internal(base.NativePtr);
		}

		// Token: 0x0601F541 RID: 128321 RVA: 0x002E88D6 File Offset: 0x002E6AD6
		public void InputNavigationRight()
		{
			ULGUIEventSystem.__InputNavigationRight_Internal(base.NativePtr);
		}

		// Token: 0x0601F542 RID: 128322 RVA: 0x002E88E3 File Offset: 0x002E6AE3
		public void InputNavigationPrev()
		{
			ULGUIEventSystem.__InputNavigationPrev_Internal(base.NativePtr);
		}

		// Token: 0x0601F543 RID: 128323 RVA: 0x002E88F0 File Offset: 0x002E6AF0
		public void InputNavigationNext()
		{
			ULGUIEventSystem.__InputNavigationNext_Internal(base.NativePtr);
		}

		// Token: 0x0601F544 RID: 128324 RVA: 0x002E88FD File Offset: 0x002E6AFD
		public void InputNavigationLeft()
		{
			ULGUIEventSystem.__InputNavigationLeft_Internal(base.NativePtr);
		}

		// Token: 0x0601F545 RID: 128325 RVA: 0x002E890A File Offset: 0x002E6B0A
		public void InputNavigationEnd()
		{
			ULGUIEventSystem.__InputNavigationEnd_Internal(base.NativePtr);
		}

		// Token: 0x0601F546 RID: 128326 RVA: 0x002E8917 File Offset: 0x002E6B17
		public void InputNavigationDown()
		{
			ULGUIEventSystem.__InputNavigationDown_Internal(base.NativePtr);
		}

		// Token: 0x0601F547 RID: 128327 RVA: 0x002E8924 File Offset: 0x002E6B24
		public void InputNavigationBegin()
		{
			ULGUIEventSystem.__InputNavigationBegin_Internal(base.NativePtr);
		}

		// Token: 0x0601F548 RID: 128328 RVA: 0x002E8931 File Offset: 0x002E6B31
		public static ULGUIEventSystem GetLGUIEventSystemInstance(UObject WorldContextObject)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULGUIEventSystem>(ULGUIEventSystem.__GetLGUIEventSystemInstance_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero));
		}

		// Token: 0x0601F549 RID: 128329 RVA: 0x002E894D File Offset: 0x002E6B4D
		public USceneComponent GetCurrentSelectedComponent()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<USceneComponent>(ULGUIEventSystem.__GetCurrentSelectedComponent_Internal(base.NativePtr));
		}

		// Token: 0x0601F54A RID: 128330 RVA: 0x002E895F File Offset: 0x002E6B5F
		public ULGUIBaseInputModule GetCurrentInputModule()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULGUIBaseInputModule>(ULGUIEventSystem.__GetCurrentInputModule_Internal(base.NativePtr));
		}

		// Token: 0x0601F54B RID: 128331 RVA: 0x002E8971 File Offset: 0x002E6B71
		public void ClearEvent()
		{
			ULGUIEventSystem.__ClearEvent_Internal(base.NativePtr);
		}

		// Token: 0x0601F54C RID: 128332
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UnRegisterPointerEnterExitEvent_Internal(IntPtr @this);

		// Token: 0x0601F54D RID: 128333
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UnregisterHitEvent_Internal(IntPtr @this, IntPtr InHandle);

		// Token: 0x0601F54E RID: 128334
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UnregisterGlobalListener_Internal(IntPtr @this, IntPtr InHandle);

		// Token: 0x0601F54F RID: 128335
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSelectComponentWithDefault_Internal(IntPtr @this, IntPtr InSelectComp);

		// Token: 0x0601F550 RID: 128336
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSelectComponent_Internal(IntPtr @this, IntPtr InSelectComp, IntPtr eventData, ELGUIEventFireType eventFireType);

		// Token: 0x0601F551 RID: 128337
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetRaycastEnable_Internal(IntPtr @this, bool enable, bool clearEvent);

		// Token: 0x0601F552 RID: 128338
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RegisterPointerEnterExitEvent_Internal(IntPtr @this, IntPtr PointerEnterExitDelegate);

		// Token: 0x0601F553 RID: 128339
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __RegisterHitEvent_Internal(IntPtr @this, IntPtr InDelegate);

		// Token: 0x0601F554 RID: 128340
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __RegisterGlobalListener_Internal(IntPtr @this, IntPtr InDelegate);

		// Token: 0x0601F555 RID: 128341
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __Navigate_Internal(IntPtr @this, ELGUINavigationDirection direction, IntPtr Selectable);

		// Token: 0x0601F556 RID: 128342
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsRaycastEnable_Internal(IntPtr @this);

		// Token: 0x0601F557 RID: 128343
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsNavigationActive_Internal(IntPtr @this);

		// Token: 0x0601F558 RID: 128344
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InputTrigger_Internal(IntPtr @this, bool inTriggerPress, EMouseButtonType inMouseButtonType);

		// Token: 0x0601F559 RID: 128345
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InputScroll_Internal(IntPtr @this, in float inAxisValue);

		// Token: 0x0601F55A RID: 128346
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InputNavigationUp_Internal(IntPtr @this);

		// Token: 0x0601F55B RID: 128347
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InputNavigationRight_Internal(IntPtr @this);

		// Token: 0x0601F55C RID: 128348
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InputNavigationPrev_Internal(IntPtr @this);

		// Token: 0x0601F55D RID: 128349
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InputNavigationNext_Internal(IntPtr @this);

		// Token: 0x0601F55E RID: 128350
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InputNavigationLeft_Internal(IntPtr @this);

		// Token: 0x0601F55F RID: 128351
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InputNavigationEnd_Internal(IntPtr @this);

		// Token: 0x0601F560 RID: 128352
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InputNavigationDown_Internal(IntPtr @this);

		// Token: 0x0601F561 RID: 128353
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InputNavigationBegin_Internal(IntPtr @this);

		// Token: 0x0601F562 RID: 128354
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetLGUIEventSystemInstance_Internal(IntPtr WorldContextObject);

		// Token: 0x0601F563 RID: 128355
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetCurrentSelectedComponent_Internal(IntPtr @this);

		// Token: 0x0601F564 RID: 128356
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetCurrentInputModule_Internal(IntPtr @this);

		// Token: 0x0601F565 RID: 128357
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearEvent_Internal(IntPtr @this);

		// Token: 0x0601F566 RID: 128358 RVA: 0x002E897E File Offset: 0x002E6B7E
		static ULGUIEventSystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.LGUIEventSystem");
		}

		// Token: 0x0601F567 RID: 128359 RVA: 0x002E898C File Offset: 0x002E6B8C
		protected ULGUIEventSystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010EE0 RID: 69344
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.LGUIEventSystem";

		// Token: 0x04010EE1 RID: 69345
		private static IntPtr _ClassPtr;

		// Token: 0x04010EE2 RID: 69346
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010EE3 RID: 69347
		internal static int __PropertyOffset_OnConnectionChanged;

		// Token: 0x04010EE4 RID: 69348
		private FOnControllerConnectionChanged _OnConnectionChanged;

		// Token: 0x04010EE5 RID: 69349
		internal static int __PropertyOffset_bRayEventEnable;

		// Token: 0x04010EE6 RID: 69350
		internal static int __PropertyOffset_HighlightWhenMouseMoveOut;

		// Token: 0x04010EE7 RID: 69351
		internal static int __PropertyOffset_pointerEventDataMap;

		// Token: 0x04010EE8 RID: 69352
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<int, ULGUIPointerEventData> _pointerEventDataMap;

		// Token: 0x04010EE9 RID: 69353
		internal static int __PropertyOffset_NavigationChangeDelegate;

		// Token: 0x04010EEA RID: 69354
		private FLGUINavigationChangeDynamicDelegate _NavigationChangeDelegate;

		// Token: 0x04010EEB RID: 69355
		internal static int __PropertyOffset_FindDefaultNavigationDelegate;

		// Token: 0x04010EEC RID: 69356
		private FLGUIFindDefaultNavigationDelegate _FindDefaultNavigationDelegate;

		// Token: 0x04010EED RID: 69357
		internal static int __PropertyOffset_TryFindNavigationDelegate;

		// Token: 0x04010EEE RID: 69358
		private FLGUITryFindNavigationDelegate _TryFindNavigationDelegate;

		// Token: 0x04010EEF RID: 69359
		internal static int __PropertyOffset_defaultInputType;

		// Token: 0x04010EF0 RID: 69360
		internal static int __PropertyOffset_eventFireTypeForNavigation;

		// Token: 0x04010EF1 RID: 69361
		internal static int __PropertyOffset_navigateInputInterval;

		// Token: 0x04010EF2 RID: 69362
		internal static int __PropertyOffset_navigateInputIntervalForFirstTime;

		// Token: 0x04010EF3 RID: 69363
		internal static int __PropertyOffset_selectedComponent;

		// Token: 0x04010EF4 RID: 69364
		internal static int __PropertyOffset_navigationComponent;

		// Token: 0x04010EF5 RID: 69365
		internal static int __PropertyOffset_preSelectedComponent;

		// Token: 0x04010EF6 RID: 69366
		internal static int __PropertyOffset_OnScrollTriggeredDelegate;

		// Token: 0x04010EF7 RID: 69367
		private FLGUIOnScrollTriggeredDelegate _OnScrollTriggeredDelegate;
	}
}
