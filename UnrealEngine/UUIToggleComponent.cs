using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000739 RID: 1849
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.UIToggleComponent")]
	[UnrealStructLayout(1232, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1232)]
	public class UUIToggleComponent : UUISelectableComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A111 RID: 41233 RVA: 0x000EE449 File Offset: 0x000EC649
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUIToggleComponent._ClassPtr;
		}

		// Token: 0x0600A112 RID: 41234 RVA: 0x000EE458 File Offset: 0x000EC658
		public UUIToggleComponent() : this(BuiltinUtils.AllocNativeUObject(UUIToggleComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A113 RID: 41235 RVA: 0x000EE480 File Offset: 0x000EC680
		public UUIToggleComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUIToggleComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001DFB RID: 7675
		// (get) Token: 0x0600A114 RID: 41236 RVA: 0x000EE4B3 File Offset: 0x000EC6B3
		// (set) Token: 0x0600A115 RID: 41237 RVA: 0x000EE4C7 File Offset: 0x000EC6C7
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<AUIBaseActor> ToggleActor
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UUIToggleComponent.__PropertyOffset_ToggleActor);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UUIToggleComponent.__PropertyOffset_ToggleActor) = value;
			}
		}

		// Token: 0x17001DFC RID: 7676
		// (get) Token: 0x0600A116 RID: 41238 RVA: 0x000EE4DC File Offset: 0x000EC6DC
		// (set) Token: 0x0600A117 RID: 41239 RVA: 0x000EE4F0 File Offset: 0x000EC6F0
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<UUISelectableTransitionComponent> ToggleTransitionComp
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UUIToggleComponent.__PropertyOffset_ToggleTransitionComp);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UUIToggleComponent.__PropertyOffset_ToggleTransitionComp) = value;
			}
		}

		// Token: 0x17001DFD RID: 7677
		// (get) Token: 0x0600A118 RID: 41240 RVA: 0x000EE505 File Offset: 0x000EC705
		// (set) Token: 0x0600A119 RID: 41241 RVA: 0x000EE519 File Offset: 0x000EC719
		[Nullable(2)]
		public unsafe ULTweener ToggleTransitionTweener
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ULTweener>(base.NativePtr / (IntPtr)sizeof(void*) + UUIToggleComponent.__PropertyOffset_ToggleTransitionTweener);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UUIToggleComponent.__PropertyOffset_ToggleTransitionTweener, value);
			}
		}

		// Token: 0x17001DFE RID: 7678
		// (get) Token: 0x0600A11A RID: 41242 RVA: 0x000EE52E File Offset: 0x000EC72E
		// (set) Token: 0x0600A11B RID: 41243 RVA: 0x000EE53E File Offset: 0x000EC73E
		public unsafe float OnAlpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIToggleComponent.__PropertyOffset_OnAlpha);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIToggleComponent.__PropertyOffset_OnAlpha) = value;
			}
		}

		// Token: 0x17001DFF RID: 7679
		// (get) Token: 0x0600A11C RID: 41244 RVA: 0x000EE54F File Offset: 0x000EC74F
		// (set) Token: 0x0600A11D RID: 41245 RVA: 0x000EE55F File Offset: 0x000EC75F
		public unsafe float OffAlpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIToggleComponent.__PropertyOffset_OffAlpha);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIToggleComponent.__PropertyOffset_OffAlpha) = value;
			}
		}

		// Token: 0x17001E00 RID: 7680
		// (get) Token: 0x0600A11E RID: 41246 RVA: 0x000EE570 File Offset: 0x000EC770
		// (set) Token: 0x0600A11F RID: 41247 RVA: 0x000EE584 File Offset: 0x000EC784
		public unsafe FColor OnColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIToggleComponent.__PropertyOffset_OnColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIToggleComponent.__PropertyOffset_OnColor) = value;
			}
		}

		// Token: 0x17001E01 RID: 7681
		// (get) Token: 0x0600A120 RID: 41248 RVA: 0x000EE599 File Offset: 0x000EC799
		// (set) Token: 0x0600A121 RID: 41249 RVA: 0x000EE5AD File Offset: 0x000EC7AD
		public unsafe FColor OffColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIToggleComponent.__PropertyOffset_OffColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIToggleComponent.__PropertyOffset_OffColor) = value;
			}
		}

		// Token: 0x17001E02 RID: 7682
		// (get) Token: 0x0600A122 RID: 41250 RVA: 0x000EE5C2 File Offset: 0x000EC7C2
		// (set) Token: 0x0600A123 RID: 41251 RVA: 0x000EE5D2 File Offset: 0x000EC7D2
		public unsafe float ToggleDuration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIToggleComponent.__PropertyOffset_ToggleDuration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIToggleComponent.__PropertyOffset_ToggleDuration) = value;
			}
		}

		// Token: 0x17001E03 RID: 7683
		// (get) Token: 0x0600A124 RID: 41252 RVA: 0x000EE5E3 File Offset: 0x000EC7E3
		// (set) Token: 0x0600A125 RID: 41253 RVA: 0x000EE5F7 File Offset: 0x000EC7F7
		public unsafe FName OnTransitionName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIToggleComponent.__PropertyOffset_OnTransitionName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIToggleComponent.__PropertyOffset_OnTransitionName) = value;
			}
		}

		// Token: 0x17001E04 RID: 7684
		// (get) Token: 0x0600A126 RID: 41254 RVA: 0x000EE60C File Offset: 0x000EC80C
		// (set) Token: 0x0600A127 RID: 41255 RVA: 0x000EE620 File Offset: 0x000EC820
		public unsafe FName OffTransitionName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIToggleComponent.__PropertyOffset_OffTransitionName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIToggleComponent.__PropertyOffset_OffTransitionName) = value;
			}
		}

		// Token: 0x17001E05 RID: 7685
		// (get) Token: 0x0600A128 RID: 41256 RVA: 0x000EE635 File Offset: 0x000EC835
		// (set) Token: 0x0600A129 RID: 41257 RVA: 0x000EE649 File Offset: 0x000EC849
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<AUIBaseActor> OnActor
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UUIToggleComponent.__PropertyOffset_OnActor);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UUIToggleComponent.__PropertyOffset_OnActor) = value;
			}
		}

		// Token: 0x17001E06 RID: 7686
		// (get) Token: 0x0600A12A RID: 41258 RVA: 0x000EE65E File Offset: 0x000EC85E
		// (set) Token: 0x0600A12B RID: 41259 RVA: 0x000EE672 File Offset: 0x000EC872
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<AUIBaseActor> OffActor
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UUIToggleComponent.__PropertyOffset_OffActor);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UUIToggleComponent.__PropertyOffset_OffActor) = value;
			}
		}

		// Token: 0x17001E07 RID: 7687
		// (get) Token: 0x0600A12C RID: 41260 RVA: 0x000EE687 File Offset: 0x000EC887
		// (set) Token: 0x0600A12D RID: 41261 RVA: 0x000EE697 File Offset: 0x000EC897
		public unsafe bool IsOn
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIToggleComponent.__PropertyOffset_IsOn) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIToggleComponent.__PropertyOffset_IsOn) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001E08 RID: 7688
		// (get) Token: 0x0600A12E RID: 41262 RVA: 0x000EE6A8 File Offset: 0x000EC8A8
		// (set) Token: 0x0600A12F RID: 41263 RVA: 0x000EE6B8 File Offset: 0x000EC8B8
		public unsafe bool bToggleOnSelect
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIToggleComponent.__PropertyOffset_bToggleOnSelect) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIToggleComponent.__PropertyOffset_bToggleOnSelect) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001E09 RID: 7689
		// (get) Token: 0x0600A130 RID: 41264 RVA: 0x000EE6C9 File Offset: 0x000EC8C9
		// (set) Token: 0x0600A131 RID: 41265 RVA: 0x000EE6DD File Offset: 0x000EC8DD
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<AActor> UIToggleGroupActor
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UUIToggleComponent.__PropertyOffset_UIToggleGroupActor);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UUIToggleComponent.__PropertyOffset_UIToggleGroupActor) = value;
			}
		}

		// Token: 0x17001E0A RID: 7690
		// (get) Token: 0x0600A132 RID: 41266 RVA: 0x000EE6F4 File Offset: 0x000EC8F4
		// (set) Token: 0x0600A133 RID: 41267 RVA: 0x000EE72D File Offset: 0x000EC92D
		public FLGUIToggleDynamicDelegate OnToggleEvent
		{
			get
			{
				base.FastCheckIsValid();
				FLGUIToggleDynamicDelegate result;
				if ((result = this._OnToggleEvent) == null)
				{
					result = (this._OnToggleEvent = new FLGUIToggleDynamicDelegate(base.NativePtr + (IntPtr)UUIToggleComponent.__PropertyOffset_OnToggleEvent, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UUIToggleComponent.__PropertyOffset_OnToggleEvent, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x0600A134 RID: 41268 RVA: 0x000EE74E File Offset: 0x000EC94E
		[NullableContext(2)]
		public void UnregisterToggleEvent(in FLGUIDelegateHandleWrapper InDelegateHandle)
		{
			UUIToggleComponent.__UnregisterToggleEvent_Internal(base.NativePtr, (InDelegateHandle ?? new FLGUIDelegateHandleWrapper()).NativePtr);
		}

		// Token: 0x0600A135 RID: 41269 RVA: 0x000EE76B File Offset: 0x000EC96B
		public void SetValue(bool newValue, bool fireEvent = true)
		{
			UUIToggleComponent.__SetValue_Internal(base.NativePtr, newValue, fireEvent);
		}

		// Token: 0x0600A136 RID: 41270 RVA: 0x000EE77A File Offset: 0x000EC97A
		public void SetState(bool newState, bool fireEvent = true)
		{
			UUIToggleComponent.__SetState_Internal(base.NativePtr, newState, fireEvent);
		}

		// Token: 0x0600A137 RID: 41271 RVA: 0x000EE789 File Offset: 0x000EC989
		public FLGUIDelegateHandleWrapper RegisterToggleEvent([Nullable(2)] in FLGUIToggleDynamicDelegate InDelegate)
		{
			IntPtr nativePtr = base.NativePtr;
			FLGUIToggleDynamicDelegate flguitoggleDynamicDelegate = InDelegate;
			return new FLGUIDelegateHandleWrapper(UUIToggleComponent.__RegisterToggleEvent_Internal(nativePtr, (flguitoggleDynamicDelegate != null) ? flguitoggleDynamicDelegate.NativePtr : ((IntPtr)0)), null);
		}

		// Token: 0x0600A138 RID: 41272 RVA: 0x000EE7AB File Offset: 0x000EC9AB
		public bool GetValue()
		{
			return UUIToggleComponent.__GetValue_Internal(base.NativePtr);
		}

		// Token: 0x0600A139 RID: 41273 RVA: 0x000EE7B8 File Offset: 0x000EC9B8
		[NullableContext(2)]
		public AActor GetToggleGroupActor()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(UUIToggleComponent.__GetToggleGroupActor_Internal(base.NativePtr));
		}

		// Token: 0x0600A13A RID: 41274 RVA: 0x000EE7CA File Offset: 0x000EC9CA
		public bool GetState()
		{
			return UUIToggleComponent.__GetState_Internal(base.NativePtr);
		}

		// Token: 0x0600A13B RID: 41275 RVA: 0x000EE7D7 File Offset: 0x000EC9D7
		public int GetIndexInGroup()
		{
			return UUIToggleComponent.__GetIndexInGroup_Internal(base.NativePtr);
		}

		// Token: 0x0600A13C RID: 41276
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UnregisterToggleEvent_Internal(IntPtr @this, IntPtr InDelegateHandle);

		// Token: 0x0600A13D RID: 41277
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetValue_Internal(IntPtr @this, bool newValue, bool fireEvent);

		// Token: 0x0600A13E RID: 41278
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetState_Internal(IntPtr @this, bool newState, bool fireEvent);

		// Token: 0x0600A13F RID: 41279
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __RegisterToggleEvent_Internal(IntPtr @this, IntPtr InDelegate);

		// Token: 0x0600A140 RID: 41280
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetValue_Internal(IntPtr @this);

		// Token: 0x0600A141 RID: 41281
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetToggleGroupActor_Internal(IntPtr @this);

		// Token: 0x0600A142 RID: 41282
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetState_Internal(IntPtr @this);

		// Token: 0x0600A143 RID: 41283
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetIndexInGroup_Internal(IntPtr @this);

		// Token: 0x0600A144 RID: 41284 RVA: 0x000EE7E4 File Offset: 0x000EC9E4
		static UUIToggleComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIToggleComponent");
		}

		// Token: 0x0600A145 RID: 41285 RVA: 0x000EE7F2 File Offset: 0x000EC9F2
		protected UUIToggleComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04004502 RID: 17666
		public new const string __ObjectPath = "/Script/LGUI.UIToggleComponent";

		// Token: 0x04004503 RID: 17667
		private static IntPtr _ClassPtr;

		// Token: 0x04004504 RID: 17668
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04004505 RID: 17669
		internal static int __PropertyOffset_ToggleActor;

		// Token: 0x04004506 RID: 17670
		internal static int __PropertyOffset_ToggleTransitionComp;

		// Token: 0x04004507 RID: 17671
		internal static int __PropertyOffset_ToggleTransitionTweener;

		// Token: 0x04004508 RID: 17672
		internal static int __PropertyOffset_OnAlpha;

		// Token: 0x04004509 RID: 17673
		internal static int __PropertyOffset_OffAlpha;

		// Token: 0x0400450A RID: 17674
		internal static int __PropertyOffset_OnColor;

		// Token: 0x0400450B RID: 17675
		internal static int __PropertyOffset_OffColor;

		// Token: 0x0400450C RID: 17676
		internal static int __PropertyOffset_ToggleDuration;

		// Token: 0x0400450D RID: 17677
		internal static int __PropertyOffset_OnTransitionName;

		// Token: 0x0400450E RID: 17678
		internal static int __PropertyOffset_OffTransitionName;

		// Token: 0x0400450F RID: 17679
		internal static int __PropertyOffset_OnActor;

		// Token: 0x04004510 RID: 17680
		internal static int __PropertyOffset_OffActor;

		// Token: 0x04004511 RID: 17681
		internal static int __PropertyOffset_IsOn;

		// Token: 0x04004512 RID: 17682
		internal static int __PropertyOffset_bToggleOnSelect;

		// Token: 0x04004513 RID: 17683
		internal static int __PropertyOffset_UIToggleGroupActor;

		// Token: 0x04004514 RID: 17684
		internal static int __PropertyOffset_OnToggleEvent;

		// Token: 0x04004515 RID: 17685
		[Nullable(2)]
		private FLGUIToggleDynamicDelegate _OnToggleEvent;
	}
}
