using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002131 RID: 8497
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.UIButtonComponent")]
	[UnrealStructLayout(1680, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1680)]
	public class UUIButtonComponent : UUISelectableComponent, IUnrealUObject, IUnrealObject, ILGUIPointerDragInterface, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x0601FFCD RID: 131021 RVA: 0x002F8F31 File Offset: 0x002F7131
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUIButtonComponent._ClassPtr;
		}

		// Token: 0x0601FFCE RID: 131022 RVA: 0x002F8F3D File Offset: 0x002F713D
		int ILGUIPointerDragInterface.InterfaceOffset()
		{
			return UUIButtonComponent.__InterfaceOffset_ILGUIPointerDragInterface;
		}

		// Token: 0x0601FFCF RID: 131023 RVA: 0x002F8F44 File Offset: 0x002F7144
		public UUIButtonComponent() : this(BuiltinUtils.AllocNativeUObject(UUIButtonComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601FFD0 RID: 131024 RVA: 0x002F8F6C File Offset: 0x002F716C
		public UUIButtonComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUIButtonComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007DAA RID: 32170
		// (get) Token: 0x0601FFD1 RID: 131025 RVA: 0x002F8FA0 File Offset: 0x002F71A0
		// (set) Token: 0x0601FFD2 RID: 131026 RVA: 0x002F8FD9 File Offset: 0x002F71D9
		public FLGUIDrawableEvent OnClick
		{
			get
			{
				base.FastCheckIsValid();
				FLGUIDrawableEvent result;
				if ((result = this._OnClick) == null)
				{
					result = (this._OnClick = new FLGUIDrawableEvent(base.NativePtr + (IntPtr)UUIButtonComponent.__PropertyOffset_OnClick, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FLGUIDrawableEvent.StaticStruct(), base.NativePtr + (IntPtr)UUIButtonComponent.__PropertyOffset_OnClick, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007DAB RID: 32171
		// (get) Token: 0x0601FFD3 RID: 131027 RVA: 0x002F8FFA File Offset: 0x002F71FA
		// (set) Token: 0x0601FFD4 RID: 131028 RVA: 0x002F900A File Offset: 0x002F720A
		public unsafe bool bAllowChangeCursorStyleWhenEnter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIButtonComponent.__PropertyOffset_bAllowChangeCursorStyleWhenEnter) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIButtonComponent.__PropertyOffset_bAllowChangeCursorStyleWhenEnter) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007DAC RID: 32172
		// (get) Token: 0x0601FFD5 RID: 131029 RVA: 0x002F901C File Offset: 0x002F721C
		// (set) Token: 0x0601FFD6 RID: 131030 RVA: 0x002F9055 File Offset: 0x002F7255
		public FLGUIButtonDynamicDelegate OnClickCallBack
		{
			get
			{
				base.FastCheckIsValid();
				FLGUIButtonDynamicDelegate result;
				if ((result = this._OnClickCallBack) == null)
				{
					result = (this._OnClickCallBack = new FLGUIButtonDynamicDelegate(base.NativePtr + (IntPtr)UUIButtonComponent.__PropertyOffset_OnClickCallBack, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UUIButtonComponent.__PropertyOffset_OnClickCallBack, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17007DAD RID: 32173
		// (get) Token: 0x0601FFD7 RID: 131031 RVA: 0x002F9078 File Offset: 0x002F7278
		// (set) Token: 0x0601FFD8 RID: 131032 RVA: 0x002F90B1 File Offset: 0x002F72B1
		public FLGUIButtonDynamicDelegate OnPointDownCallBack
		{
			get
			{
				base.FastCheckIsValid();
				FLGUIButtonDynamicDelegate result;
				if ((result = this._OnPointDownCallBack) == null)
				{
					result = (this._OnPointDownCallBack = new FLGUIButtonDynamicDelegate(base.NativePtr + (IntPtr)UUIButtonComponent.__PropertyOffset_OnPointDownCallBack, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UUIButtonComponent.__PropertyOffset_OnPointDownCallBack, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17007DAE RID: 32174
		// (get) Token: 0x0601FFD9 RID: 131033 RVA: 0x002F90D4 File Offset: 0x002F72D4
		// (set) Token: 0x0601FFDA RID: 131034 RVA: 0x002F910D File Offset: 0x002F730D
		public FLGUIButtonDynamicDelegate OnPointUpCallBack
		{
			get
			{
				base.FastCheckIsValid();
				FLGUIButtonDynamicDelegate result;
				if ((result = this._OnPointUpCallBack) == null)
				{
					result = (this._OnPointUpCallBack = new FLGUIButtonDynamicDelegate(base.NativePtr + (IntPtr)UUIButtonComponent.__PropertyOffset_OnPointUpCallBack, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UUIButtonComponent.__PropertyOffset_OnPointUpCallBack, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17007DAF RID: 32175
		// (get) Token: 0x0601FFDB RID: 131035 RVA: 0x002F9130 File Offset: 0x002F7330
		// (set) Token: 0x0601FFDC RID: 131036 RVA: 0x002F9169 File Offset: 0x002F7369
		public FLGUIButtonDynamicDelegate OnPointCancelCallBack
		{
			get
			{
				base.FastCheckIsValid();
				FLGUIButtonDynamicDelegate result;
				if ((result = this._OnPointCancelCallBack) == null)
				{
					result = (this._OnPointCancelCallBack = new FLGUIButtonDynamicDelegate(base.NativePtr + (IntPtr)UUIButtonComponent.__PropertyOffset_OnPointCancelCallBack, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UUIButtonComponent.__PropertyOffset_OnPointCancelCallBack, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17007DB0 RID: 32176
		// (get) Token: 0x0601FFDD RID: 131037 RVA: 0x002F918C File Offset: 0x002F738C
		// (set) Token: 0x0601FFDE RID: 131038 RVA: 0x002F91C5 File Offset: 0x002F73C5
		public FLGUIButtonDynamicDelegate OnPointEnterCallBack
		{
			get
			{
				base.FastCheckIsValid();
				FLGUIButtonDynamicDelegate result;
				if ((result = this._OnPointEnterCallBack) == null)
				{
					result = (this._OnPointEnterCallBack = new FLGUIButtonDynamicDelegate(base.NativePtr + (IntPtr)UUIButtonComponent.__PropertyOffset_OnPointEnterCallBack, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UUIButtonComponent.__PropertyOffset_OnPointEnterCallBack, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17007DB1 RID: 32177
		// (get) Token: 0x0601FFDF RID: 131039 RVA: 0x002F91E8 File Offset: 0x002F73E8
		// (set) Token: 0x0601FFE0 RID: 131040 RVA: 0x002F9221 File Offset: 0x002F7421
		public FLGUIButtonDynamicDelegate OnPointExitCallBack
		{
			get
			{
				base.FastCheckIsValid();
				FLGUIButtonDynamicDelegate result;
				if ((result = this._OnPointExitCallBack) == null)
				{
					result = (this._OnPointExitCallBack = new FLGUIButtonDynamicDelegate(base.NativePtr + (IntPtr)UUIButtonComponent.__PropertyOffset_OnPointExitCallBack, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UUIButtonComponent.__PropertyOffset_OnPointExitCallBack, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17007DB2 RID: 32178
		// (get) Token: 0x0601FFE1 RID: 131041 RVA: 0x002F9244 File Offset: 0x002F7444
		// (set) Token: 0x0601FFE2 RID: 131042 RVA: 0x002F927D File Offset: 0x002F747D
		public FLGUIButtonDynamicDelegateOneParams OnPointerBeginDragCallBack
		{
			get
			{
				base.FastCheckIsValid();
				FLGUIButtonDynamicDelegateOneParams result;
				if ((result = this._OnPointerBeginDragCallBack) == null)
				{
					result = (this._OnPointerBeginDragCallBack = new FLGUIButtonDynamicDelegateOneParams(base.NativePtr + (IntPtr)UUIButtonComponent.__PropertyOffset_OnPointerBeginDragCallBack, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UUIButtonComponent.__PropertyOffset_OnPointerBeginDragCallBack, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17007DB3 RID: 32179
		// (get) Token: 0x0601FFE3 RID: 131043 RVA: 0x002F92A0 File Offset: 0x002F74A0
		// (set) Token: 0x0601FFE4 RID: 131044 RVA: 0x002F92D9 File Offset: 0x002F74D9
		public FLGUIButtonDynamicDelegateOneParams OnPointerDragCallBack
		{
			get
			{
				base.FastCheckIsValid();
				FLGUIButtonDynamicDelegateOneParams result;
				if ((result = this._OnPointerDragCallBack) == null)
				{
					result = (this._OnPointerDragCallBack = new FLGUIButtonDynamicDelegateOneParams(base.NativePtr + (IntPtr)UUIButtonComponent.__PropertyOffset_OnPointerDragCallBack, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UUIButtonComponent.__PropertyOffset_OnPointerDragCallBack, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17007DB4 RID: 32180
		// (get) Token: 0x0601FFE5 RID: 131045 RVA: 0x002F92FC File Offset: 0x002F74FC
		// (set) Token: 0x0601FFE6 RID: 131046 RVA: 0x002F9335 File Offset: 0x002F7535
		public FLGUIButtonDynamicDelegateOneParams OnPointerEndDragCallBack
		{
			get
			{
				base.FastCheckIsValid();
				FLGUIButtonDynamicDelegateOneParams result;
				if ((result = this._OnPointerEndDragCallBack) == null)
				{
					result = (this._OnPointerEndDragCallBack = new FLGUIButtonDynamicDelegateOneParams(base.NativePtr + (IntPtr)UUIButtonComponent.__PropertyOffset_OnPointerEndDragCallBack, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UUIButtonComponent.__PropertyOffset_OnPointerEndDragCallBack, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17007DB5 RID: 32181
		// (get) Token: 0x0601FFE7 RID: 131047 RVA: 0x002F9358 File Offset: 0x002F7558
		// (set) Token: 0x0601FFE8 RID: 131048 RVA: 0x002F9391 File Offset: 0x002F7591
		public FSoftObjectPath AkAudioEvent
		{
			get
			{
				base.FastCheckIsValid();
				FSoftObjectPath result;
				if ((result = this._AkAudioEvent) == null)
				{
					result = (this._AkAudioEvent = new FSoftObjectPath(base.NativePtr + (IntPtr)UUIButtonComponent.__PropertyOffset_AkAudioEvent, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)UUIButtonComponent.__PropertyOffset_AkAudioEvent, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007DB6 RID: 32182
		// (get) Token: 0x0601FFE9 RID: 131049 RVA: 0x002F93B4 File Offset: 0x002F75B4
		// (set) Token: 0x0601FFEA RID: 131050 RVA: 0x002F93ED File Offset: 0x002F75ED
		public FLGUIButtonAudioDelegate OnPostAudioEvent
		{
			get
			{
				base.FastCheckIsValid();
				FLGUIButtonAudioDelegate result;
				if ((result = this._OnPostAudioEvent) == null)
				{
					result = (this._OnPostAudioEvent = new FLGUIButtonAudioDelegate(base.NativePtr + (IntPtr)UUIButtonComponent.__PropertyOffset_OnPostAudioEvent, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UUIButtonComponent.__PropertyOffset_OnPostAudioEvent, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17007DB7 RID: 32183
		// (get) Token: 0x0601FFEB RID: 131051 RVA: 0x002F9410 File Offset: 0x002F7610
		// (set) Token: 0x0601FFEC RID: 131052 RVA: 0x002F9449 File Offset: 0x002F7649
		public TMap<EButtonAudioStateTransferType, FSoftObjectPath> AudioConfig
		{
			get
			{
				base.FastCheckIsValid();
				TMap<EButtonAudioStateTransferType, FSoftObjectPath> result;
				if ((result = this._AudioConfig) == null)
				{
					result = (this._AudioConfig = new TMap<EButtonAudioStateTransferType, FSoftObjectPath>(base.NativePtr + (IntPtr)UUIButtonComponent.__PropertyOffset_AudioConfig, this));
				}
				return result;
			}
			set
			{
				this.AudioConfig.CopyAssign(value);
			}
		}

		// Token: 0x17007DB8 RID: 32184
		// (get) Token: 0x0601FFED RID: 131053 RVA: 0x002F9458 File Offset: 0x002F7658
		// (set) Token: 0x0601FFEE RID: 131054 RVA: 0x002F9491 File Offset: 0x002F7691
		public FSoftObjectPath LongPressAudioEvent
		{
			get
			{
				base.FastCheckIsValid();
				FSoftObjectPath result;
				if ((result = this._LongPressAudioEvent) == null)
				{
					result = (this._LongPressAudioEvent = new FSoftObjectPath(base.NativePtr + (IntPtr)UUIButtonComponent.__PropertyOffset_LongPressAudioEvent, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)UUIButtonComponent.__PropertyOffset_LongPressAudioEvent, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007DB9 RID: 32185
		// (get) Token: 0x0601FFEF RID: 131055 RVA: 0x002F94B4 File Offset: 0x002F76B4
		// (set) Token: 0x0601FFF0 RID: 131056 RVA: 0x002F94ED File Offset: 0x002F76ED
		public FLGUIButtonAudioWithStateDelegate OnPostAudioStateEvent
		{
			get
			{
				base.FastCheckIsValid();
				FLGUIButtonAudioWithStateDelegate result;
				if ((result = this._OnPostAudioStateEvent) == null)
				{
					result = (this._OnPostAudioStateEvent = new FLGUIButtonAudioWithStateDelegate(base.NativePtr + (IntPtr)UUIButtonComponent.__PropertyOffset_OnPostAudioStateEvent, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UUIButtonComponent.__PropertyOffset_OnPostAudioStateEvent, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x0601FFF1 RID: 131057 RVA: 0x002F950E File Offset: 0x002F770E
		[NullableContext(2)]
		public void UnregisterClickEvent(in FLGUIDelegateHandleWrapper InDelegateHandle)
		{
			UUIButtonComponent.__UnregisterClickEvent_Internal(base.NativePtr, (InDelegateHandle ?? new FLGUIDelegateHandleWrapper()).NativePtr);
		}

		// Token: 0x0601FFF2 RID: 131058 RVA: 0x002F952B File Offset: 0x002F772B
		public FLGUIDelegateHandleWrapper RegisterClickEvent([Nullable(2)] in FLGUIButtonDynamicDelegate InDelegate)
		{
			IntPtr nativePtr = base.NativePtr;
			FLGUIButtonDynamicDelegate flguibuttonDynamicDelegate = InDelegate;
			return new FLGUIDelegateHandleWrapper(UUIButtonComponent.__RegisterClickEvent_Internal(nativePtr, (flguibuttonDynamicDelegate != null) ? flguibuttonDynamicDelegate.NativePtr : ((IntPtr)0)), null);
		}

		// Token: 0x0601FFF3 RID: 131059 RVA: 0x002F954D File Offset: 0x002F774D
		[NullableContext(2)]
		public bool OnPointerDown_Implementation(ULGUIPointerEventData eventData)
		{
			return UUIButtonComponent.__OnPointerDown_Implementation_Internal(base.NativePtr, (eventData != null) ? eventData.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601FFF4 RID: 131060
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UnregisterClickEvent_Internal(IntPtr @this, IntPtr InDelegateHandle);

		// Token: 0x0601FFF5 RID: 131061
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __RegisterClickEvent_Internal(IntPtr @this, IntPtr InDelegate);

		// Token: 0x0601FFF6 RID: 131062
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __OnPointerDown_Implementation_Internal(IntPtr @this, IntPtr eventData);

		// Token: 0x0601FFF7 RID: 131063 RVA: 0x002F956A File Offset: 0x002F776A
		static UUIButtonComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIButtonComponent");
		}

		// Token: 0x0601FFF8 RID: 131064 RVA: 0x002F9578 File Offset: 0x002F7778
		protected UUIButtonComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011383 RID: 70531
		internal static int __InterfaceOffset_ILGUIPointerDragInterface;

		// Token: 0x04011384 RID: 70532
		public new const string __ObjectPath = "/Script/LGUI.UIButtonComponent";

		// Token: 0x04011385 RID: 70533
		private static IntPtr _ClassPtr;

		// Token: 0x04011386 RID: 70534
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011387 RID: 70535
		internal static int __PropertyOffset_OnClick;

		// Token: 0x04011388 RID: 70536
		[Nullable(2)]
		private FLGUIDrawableEvent _OnClick;

		// Token: 0x04011389 RID: 70537
		internal static int __PropertyOffset_bAllowChangeCursorStyleWhenEnter;

		// Token: 0x0401138A RID: 70538
		internal static int __PropertyOffset_OnClickCallBack;

		// Token: 0x0401138B RID: 70539
		[Nullable(2)]
		private FLGUIButtonDynamicDelegate _OnClickCallBack;

		// Token: 0x0401138C RID: 70540
		internal static int __PropertyOffset_OnPointDownCallBack;

		// Token: 0x0401138D RID: 70541
		[Nullable(2)]
		private FLGUIButtonDynamicDelegate _OnPointDownCallBack;

		// Token: 0x0401138E RID: 70542
		internal static int __PropertyOffset_OnPointUpCallBack;

		// Token: 0x0401138F RID: 70543
		[Nullable(2)]
		private FLGUIButtonDynamicDelegate _OnPointUpCallBack;

		// Token: 0x04011390 RID: 70544
		internal static int __PropertyOffset_OnPointCancelCallBack;

		// Token: 0x04011391 RID: 70545
		[Nullable(2)]
		private FLGUIButtonDynamicDelegate _OnPointCancelCallBack;

		// Token: 0x04011392 RID: 70546
		internal static int __PropertyOffset_OnPointEnterCallBack;

		// Token: 0x04011393 RID: 70547
		[Nullable(2)]
		private FLGUIButtonDynamicDelegate _OnPointEnterCallBack;

		// Token: 0x04011394 RID: 70548
		internal static int __PropertyOffset_OnPointExitCallBack;

		// Token: 0x04011395 RID: 70549
		[Nullable(2)]
		private FLGUIButtonDynamicDelegate _OnPointExitCallBack;

		// Token: 0x04011396 RID: 70550
		internal static int __PropertyOffset_OnPointerBeginDragCallBack;

		// Token: 0x04011397 RID: 70551
		[Nullable(2)]
		private FLGUIButtonDynamicDelegateOneParams _OnPointerBeginDragCallBack;

		// Token: 0x04011398 RID: 70552
		internal static int __PropertyOffset_OnPointerDragCallBack;

		// Token: 0x04011399 RID: 70553
		[Nullable(2)]
		private FLGUIButtonDynamicDelegateOneParams _OnPointerDragCallBack;

		// Token: 0x0401139A RID: 70554
		internal static int __PropertyOffset_OnPointerEndDragCallBack;

		// Token: 0x0401139B RID: 70555
		[Nullable(2)]
		private FLGUIButtonDynamicDelegateOneParams _OnPointerEndDragCallBack;

		// Token: 0x0401139C RID: 70556
		internal static int __PropertyOffset_AkAudioEvent;

		// Token: 0x0401139D RID: 70557
		[Nullable(2)]
		private FSoftObjectPath _AkAudioEvent;

		// Token: 0x0401139E RID: 70558
		internal static int __PropertyOffset_OnPostAudioEvent;

		// Token: 0x0401139F RID: 70559
		[Nullable(2)]
		private FLGUIButtonAudioDelegate _OnPostAudioEvent;

		// Token: 0x040113A0 RID: 70560
		internal static int __PropertyOffset_AudioConfig;

		// Token: 0x040113A1 RID: 70561
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<EButtonAudioStateTransferType, FSoftObjectPath> _AudioConfig;

		// Token: 0x040113A2 RID: 70562
		internal static int __PropertyOffset_LongPressAudioEvent;

		// Token: 0x040113A3 RID: 70563
		[Nullable(2)]
		private FSoftObjectPath _LongPressAudioEvent;

		// Token: 0x040113A4 RID: 70564
		internal static int __PropertyOffset_OnPostAudioStateEvent;

		// Token: 0x040113A5 RID: 70565
		[Nullable(2)]
		private FLGUIButtonAudioWithStateDelegate _OnPostAudioStateEvent;
	}
}
