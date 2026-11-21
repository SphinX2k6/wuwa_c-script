using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Script;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000692 RID: 1682
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.LGUIEventSystem")]
	[UnrealStructLayout(608, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 608)]
	public class ULGUIEventSystem : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06009110 RID: 37136 RVA: 0x000DA523 File Offset: 0x000D8723
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULGUIEventSystem._ClassPtr;
		}

		// Token: 0x06009111 RID: 37137 RVA: 0x000DA530 File Offset: 0x000D8730
		public ULGUIEventSystem() : this(BuiltinUtils.AllocNativeUObject(ULGUIEventSystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06009112 RID: 37138 RVA: 0x000DA558 File Offset: 0x000D8758
		[NullableContext(1)]
		public ULGUIEventSystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULGUIEventSystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001B1C RID: 6940
		// (get) Token: 0x06009113 RID: 37139 RVA: 0x000DA58C File Offset: 0x000D878C
		// (set) Token: 0x06009114 RID: 37140 RVA: 0x000DA5C5 File Offset: 0x000D87C5
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

		// Token: 0x17001B1D RID: 6941
		// (get) Token: 0x06009115 RID: 37141 RVA: 0x000DA5E6 File Offset: 0x000D87E6
		// (set) Token: 0x06009116 RID: 37142 RVA: 0x000DA5F6 File Offset: 0x000D87F6
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

		// Token: 0x17001B1E RID: 6942
		// (get) Token: 0x06009117 RID: 37143 RVA: 0x000DA607 File Offset: 0x000D8807
		// (set) Token: 0x06009118 RID: 37144 RVA: 0x000DA617 File Offset: 0x000D8817
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

		// Token: 0x17001B1F RID: 6943
		// (get) Token: 0x06009119 RID: 37145 RVA: 0x000DA628 File Offset: 0x000D8828
		// (set) Token: 0x0600911A RID: 37146 RVA: 0x000DA661 File Offset: 0x000D8861
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

		// Token: 0x17001B20 RID: 6944
		// (get) Token: 0x0600911B RID: 37147 RVA: 0x000DA670 File Offset: 0x000D8870
		// (set) Token: 0x0600911C RID: 37148 RVA: 0x000DA6A9 File Offset: 0x000D88A9
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

		// Token: 0x17001B21 RID: 6945
		// (get) Token: 0x0600911D RID: 37149 RVA: 0x000DA6CC File Offset: 0x000D88CC
		// (set) Token: 0x0600911E RID: 37150 RVA: 0x000DA705 File Offset: 0x000D8905
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

		// Token: 0x17001B22 RID: 6946
		// (get) Token: 0x0600911F RID: 37151 RVA: 0x000DA726 File Offset: 0x000D8926
		// (set) Token: 0x06009120 RID: 37152 RVA: 0x000DA736 File Offset: 0x000D8936
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

		// Token: 0x17001B23 RID: 6947
		// (get) Token: 0x06009121 RID: 37153 RVA: 0x000DA747 File Offset: 0x000D8947
		// (set) Token: 0x06009122 RID: 37154 RVA: 0x000DA757 File Offset: 0x000D8957
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

		// Token: 0x17001B24 RID: 6948
		// (get) Token: 0x06009123 RID: 37155 RVA: 0x000DA768 File Offset: 0x000D8968
		// (set) Token: 0x06009124 RID: 37156 RVA: 0x000DA778 File Offset: 0x000D8978
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

		// Token: 0x17001B25 RID: 6949
		// (get) Token: 0x06009125 RID: 37157 RVA: 0x000DA789 File Offset: 0x000D8989
		// (set) Token: 0x06009126 RID: 37158 RVA: 0x000DA799 File Offset: 0x000D8999
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

		// Token: 0x17001B26 RID: 6950
		// (get) Token: 0x06009127 RID: 37159 RVA: 0x000DA7AA File Offset: 0x000D89AA
		// (set) Token: 0x06009128 RID: 37160 RVA: 0x000DA7BE File Offset: 0x000D89BE
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

		// Token: 0x17001B27 RID: 6951
		// (get) Token: 0x06009129 RID: 37161 RVA: 0x000DA7D3 File Offset: 0x000D89D3
		// (set) Token: 0x0600912A RID: 37162 RVA: 0x000DA7E7 File Offset: 0x000D89E7
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

		// Token: 0x17001B28 RID: 6952
		// (get) Token: 0x0600912B RID: 37163 RVA: 0x000DA7FC File Offset: 0x000D89FC
		// (set) Token: 0x0600912C RID: 37164 RVA: 0x000DA810 File Offset: 0x000D8A10
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

		// Token: 0x17001B29 RID: 6953
		// (get) Token: 0x0600912D RID: 37165 RVA: 0x000DA828 File Offset: 0x000D8A28
		// (set) Token: 0x0600912E RID: 37166 RVA: 0x000DA861 File Offset: 0x000D8A61
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

		// Token: 0x0600912F RID: 37167 RVA: 0x000DA882 File Offset: 0x000D8A82
		public void UnRegisterPointerEnterExitEvent()
		{
			ULGUIEventSystem.__UnRegisterPointerEnterExitEvent_Internal(base.NativePtr);
		}

		// Token: 0x06009130 RID: 37168 RVA: 0x000DA88F File Offset: 0x000D8A8F
		public void UnregisterHitEvent(in FLGUIDelegateHandleWrapper InHandle)
		{
			ULGUIEventSystem.__UnregisterHitEvent_Internal(base.NativePtr, (InHandle ?? new FLGUIDelegateHandleWrapper()).NativePtr);
		}

		// Token: 0x06009131 RID: 37169 RVA: 0x000DA8AC File Offset: 0x000D8AAC
		public void UnregisterGlobalListener(in FLGUIDelegateHandleWrapper InHandle)
		{
			ULGUIEventSystem.__UnregisterGlobalListener_Internal(base.NativePtr, (InHandle ?? new FLGUIDelegateHandleWrapper()).NativePtr);
		}

		// Token: 0x06009132 RID: 37170 RVA: 0x000DA8C9 File Offset: 0x000D8AC9
		public void SetSelectComponentWithDefault(USceneComponent InSelectComp)
		{
			ULGUIEventSystem.__SetSelectComponentWithDefault_Internal(base.NativePtr, (InSelectComp != null) ? InSelectComp.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06009133 RID: 37171 RVA: 0x000DA8E6 File Offset: 0x000D8AE6
		public void SetSelectComponent(USceneComponent InSelectComp, ULGUIBaseEventData eventData, ELGUIEventFireType eventFireType)
		{
			ULGUIEventSystem.__SetSelectComponent_Internal(base.NativePtr, (InSelectComp != null) ? InSelectComp.NativePtr : IntPtr.Zero, (eventData != null) ? eventData.NativePtr : IntPtr.Zero, eventFireType);
		}

		// Token: 0x06009134 RID: 37172 RVA: 0x000DA914 File Offset: 0x000D8B14
		public void SetRaycastEnable(bool enable, bool clearEvent = false)
		{
			ULGUIEventSystem.__SetRaycastEnable_Internal(base.NativePtr, enable, clearEvent);
		}

		// Token: 0x06009135 RID: 37173 RVA: 0x000DA923 File Offset: 0x000D8B23
		public void RegisterPointerEnterExitEvent(in FLGUIPointerEnterExit_DynamicDelegate PointerEnterExitDelegate)
		{
			IntPtr nativePtr = base.NativePtr;
			FLGUIPointerEnterExit_DynamicDelegate flguipointerEnterExit_DynamicDelegate = PointerEnterExitDelegate;
			ULGUIEventSystem.__RegisterPointerEnterExitEvent_Internal(nativePtr, (flguipointerEnterExit_DynamicDelegate != null) ? flguipointerEnterExit_DynamicDelegate.NativePtr : ((IntPtr)0));
		}

		// Token: 0x06009136 RID: 37174 RVA: 0x000DA93F File Offset: 0x000D8B3F
		[NullableContext(1)]
		public FLGUIDelegateHandleWrapper RegisterHitEvent([Nullable(2)] in FLGUIHitDynamicDelegate InDelegate)
		{
			IntPtr nativePtr = base.NativePtr;
			FLGUIHitDynamicDelegate flguihitDynamicDelegate = InDelegate;
			return new FLGUIDelegateHandleWrapper(ULGUIEventSystem.__RegisterHitEvent_Internal(nativePtr, (flguihitDynamicDelegate != null) ? flguihitDynamicDelegate.NativePtr : ((IntPtr)0)), null);
		}

		// Token: 0x06009137 RID: 37175 RVA: 0x000DA961 File Offset: 0x000D8B61
		[NullableContext(1)]
		public FLGUIDelegateHandleWrapper RegisterGlobalListener([Nullable(2)] in FLGUIBaseEventDynamicDelegate InDelegate)
		{
			IntPtr nativePtr = base.NativePtr;
			FLGUIBaseEventDynamicDelegate flguibaseEventDynamicDelegate = InDelegate;
			return new FLGUIDelegateHandleWrapper(ULGUIEventSystem.__RegisterGlobalListener_Internal(nativePtr, (flguibaseEventDynamicDelegate != null) ? flguibaseEventDynamicDelegate.NativePtr : ((IntPtr)0)), null);
		}

		// Token: 0x06009138 RID: 37176 RVA: 0x000DA983 File Offset: 0x000D8B83
		public USceneComponent Navigate(ELGUINavigationDirection direction, UUISelectableComponent Selectable = null)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<USceneComponent>(ULGUIEventSystem.__Navigate_Internal(base.NativePtr, direction, (Selectable != null) ? Selectable.NativePtr : IntPtr.Zero));
		}

		// Token: 0x06009139 RID: 37177 RVA: 0x000DA9A6 File Offset: 0x000D8BA6
		public bool IsRaycastEnable()
		{
			return ULGUIEventSystem.__IsRaycastEnable_Internal(base.NativePtr);
		}

		// Token: 0x0600913A RID: 37178 RVA: 0x000DA9B3 File Offset: 0x000D8BB3
		public bool IsNavigationActive()
		{
			return ULGUIEventSystem.__IsNavigationActive_Internal(base.NativePtr);
		}

		// Token: 0x0600913B RID: 37179 RVA: 0x000DA9C0 File Offset: 0x000D8BC0
		public void InputTrigger(bool inTriggerPress, EMouseButtonType inMouseButtonType = EMouseButtonType.Left)
		{
			ULGUIEventSystem.__InputTrigger_Internal(base.NativePtr, inTriggerPress, inMouseButtonType);
		}

		// Token: 0x0600913C RID: 37180 RVA: 0x000DA9D0 File Offset: 0x000D8BD0
		public unsafe void InputScroll(in float inAxisValue)
		{
			fixed (float* ptr = &inAxisValue)
			{
				void* ptr2 = (void*)ptr;
				ULGUIEventSystem.__InputScroll_Internal(base.NativePtr, inAxisValue);
			}
		}

		// Token: 0x0600913D RID: 37181 RVA: 0x000DA9F1 File Offset: 0x000D8BF1
		public void InputNavigationUp()
		{
			ULGUIEventSystem.__InputNavigationUp_Internal(base.NativePtr);
		}

		// Token: 0x0600913E RID: 37182 RVA: 0x000DA9FE File Offset: 0x000D8BFE
		public void InputNavigationRight()
		{
			ULGUIEventSystem.__InputNavigationRight_Internal(base.NativePtr);
		}

		// Token: 0x0600913F RID: 37183 RVA: 0x000DAA0B File Offset: 0x000D8C0B
		public void InputNavigationPrev()
		{
			ULGUIEventSystem.__InputNavigationPrev_Internal(base.NativePtr);
		}

		// Token: 0x06009140 RID: 37184 RVA: 0x000DAA18 File Offset: 0x000D8C18
		public void InputNavigationNext()
		{
			ULGUIEventSystem.__InputNavigationNext_Internal(base.NativePtr);
		}

		// Token: 0x06009141 RID: 37185 RVA: 0x000DAA25 File Offset: 0x000D8C25
		public void InputNavigationLeft()
		{
			ULGUIEventSystem.__InputNavigationLeft_Internal(base.NativePtr);
		}

		// Token: 0x06009142 RID: 37186 RVA: 0x000DAA32 File Offset: 0x000D8C32
		public void InputNavigationEnd()
		{
			ULGUIEventSystem.__InputNavigationEnd_Internal(base.NativePtr);
		}

		// Token: 0x06009143 RID: 37187 RVA: 0x000DAA3F File Offset: 0x000D8C3F
		public void InputNavigationDown()
		{
			ULGUIEventSystem.__InputNavigationDown_Internal(base.NativePtr);
		}

		// Token: 0x06009144 RID: 37188 RVA: 0x000DAA4C File Offset: 0x000D8C4C
		public void InputNavigationBegin()
		{
			ULGUIEventSystem.__InputNavigationBegin_Internal(base.NativePtr);
		}

		// Token: 0x06009145 RID: 37189 RVA: 0x000DAA59 File Offset: 0x000D8C59
		public static ULGUIEventSystem GetLGUIEventSystemInstance(UObject WorldContextObject)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULGUIEventSystem>(ULGUIEventSystem.__GetLGUIEventSystemInstance_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero));
		}

		// Token: 0x06009146 RID: 37190 RVA: 0x000DAA75 File Offset: 0x000D8C75
		public USceneComponent GetCurrentSelectedComponent()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<USceneComponent>(ULGUIEventSystem.__GetCurrentSelectedComponent_Internal(base.NativePtr));
		}

		// Token: 0x06009147 RID: 37191 RVA: 0x000DAA87 File Offset: 0x000D8C87
		public ULGUIBaseInputModule GetCurrentInputModule()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULGUIBaseInputModule>(ULGUIEventSystem.__GetCurrentInputModule_Internal(base.NativePtr));
		}

		// Token: 0x06009148 RID: 37192 RVA: 0x000DAA99 File Offset: 0x000D8C99
		public void ClearEvent()
		{
			ULGUIEventSystem.__ClearEvent_Internal(base.NativePtr);
		}

		// Token: 0x06009149 RID: 37193
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UnRegisterPointerEnterExitEvent_Internal(IntPtr @this);

		// Token: 0x0600914A RID: 37194
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UnregisterHitEvent_Internal(IntPtr @this, IntPtr InHandle);

		// Token: 0x0600914B RID: 37195
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UnregisterGlobalListener_Internal(IntPtr @this, IntPtr InHandle);

		// Token: 0x0600914C RID: 37196
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSelectComponentWithDefault_Internal(IntPtr @this, IntPtr InSelectComp);

		// Token: 0x0600914D RID: 37197
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSelectComponent_Internal(IntPtr @this, IntPtr InSelectComp, IntPtr eventData, ELGUIEventFireType eventFireType);

		// Token: 0x0600914E RID: 37198
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetRaycastEnable_Internal(IntPtr @this, bool enable, bool clearEvent);

		// Token: 0x0600914F RID: 37199
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RegisterPointerEnterExitEvent_Internal(IntPtr @this, IntPtr PointerEnterExitDelegate);

		// Token: 0x06009150 RID: 37200
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __RegisterHitEvent_Internal(IntPtr @this, IntPtr InDelegate);

		// Token: 0x06009151 RID: 37201
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __RegisterGlobalListener_Internal(IntPtr @this, IntPtr InDelegate);

		// Token: 0x06009152 RID: 37202
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __Navigate_Internal(IntPtr @this, ELGUINavigationDirection direction, IntPtr Selectable);

		// Token: 0x06009153 RID: 37203
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsRaycastEnable_Internal(IntPtr @this);

		// Token: 0x06009154 RID: 37204
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsNavigationActive_Internal(IntPtr @this);

		// Token: 0x06009155 RID: 37205
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InputTrigger_Internal(IntPtr @this, bool inTriggerPress, EMouseButtonType inMouseButtonType);

		// Token: 0x06009156 RID: 37206
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InputScroll_Internal(IntPtr @this, in float inAxisValue);

		// Token: 0x06009157 RID: 37207
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InputNavigationUp_Internal(IntPtr @this);

		// Token: 0x06009158 RID: 37208
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InputNavigationRight_Internal(IntPtr @this);

		// Token: 0x06009159 RID: 37209
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InputNavigationPrev_Internal(IntPtr @this);

		// Token: 0x0600915A RID: 37210
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InputNavigationNext_Internal(IntPtr @this);

		// Token: 0x0600915B RID: 37211
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InputNavigationLeft_Internal(IntPtr @this);

		// Token: 0x0600915C RID: 37212
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InputNavigationEnd_Internal(IntPtr @this);

		// Token: 0x0600915D RID: 37213
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InputNavigationDown_Internal(IntPtr @this);

		// Token: 0x0600915E RID: 37214
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InputNavigationBegin_Internal(IntPtr @this);

		// Token: 0x0600915F RID: 37215
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetLGUIEventSystemInstance_Internal(IntPtr WorldContextObject);

		// Token: 0x06009160 RID: 37216
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetCurrentSelectedComponent_Internal(IntPtr @this);

		// Token: 0x06009161 RID: 37217
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetCurrentInputModule_Internal(IntPtr @this);

		// Token: 0x06009162 RID: 37218
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearEvent_Internal(IntPtr @this);

		// Token: 0x06009163 RID: 37219 RVA: 0x000DAAA6 File Offset: 0x000D8CA6
		static ULGUIEventSystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.LGUIEventSystem");
		}

		// Token: 0x06009164 RID: 37220 RVA: 0x000DAAB4 File Offset: 0x000D8CB4
		protected ULGUIEventSystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003F4F RID: 16207
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.LGUIEventSystem";

		// Token: 0x04003F50 RID: 16208
		private static IntPtr _ClassPtr;

		// Token: 0x04003F51 RID: 16209
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003F52 RID: 16210
		internal static int __PropertyOffset_OnConnectionChanged;

		// Token: 0x04003F53 RID: 16211
		private FOnControllerConnectionChanged _OnConnectionChanged;

		// Token: 0x04003F54 RID: 16212
		internal static int __PropertyOffset_bRayEventEnable;

		// Token: 0x04003F55 RID: 16213
		internal static int __PropertyOffset_HighlightWhenMouseMoveOut;

		// Token: 0x04003F56 RID: 16214
		internal static int __PropertyOffset_pointerEventDataMap;

		// Token: 0x04003F57 RID: 16215
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<int, ULGUIPointerEventData> _pointerEventDataMap;

		// Token: 0x04003F58 RID: 16216
		internal static int __PropertyOffset_FindDefaultNavigationDelegate;

		// Token: 0x04003F59 RID: 16217
		private FLGUIFindDefaultNavigationDelegate _FindDefaultNavigationDelegate;

		// Token: 0x04003F5A RID: 16218
		internal static int __PropertyOffset_TryFindNavigationDelegate;

		// Token: 0x04003F5B RID: 16219
		private FLGUITryFindNavigationDelegate _TryFindNavigationDelegate;

		// Token: 0x04003F5C RID: 16220
		internal static int __PropertyOffset_defaultInputType;

		// Token: 0x04003F5D RID: 16221
		internal static int __PropertyOffset_eventFireTypeForNavigation;

		// Token: 0x04003F5E RID: 16222
		internal static int __PropertyOffset_navigateInputInterval;

		// Token: 0x04003F5F RID: 16223
		internal static int __PropertyOffset_navigateInputIntervalForFirstTime;

		// Token: 0x04003F60 RID: 16224
		internal static int __PropertyOffset_selectedComponent;

		// Token: 0x04003F61 RID: 16225
		internal static int __PropertyOffset_navigationComponent;

		// Token: 0x04003F62 RID: 16226
		internal static int __PropertyOffset_preSelectedComponent;

		// Token: 0x04003F63 RID: 16227
		internal static int __PropertyOffset_OnScrollTriggeredDelegate;

		// Token: 0x04003F64 RID: 16228
		private FLGUIOnScrollTriggeredDelegate _OnScrollTriggeredDelegate;
	}
}
