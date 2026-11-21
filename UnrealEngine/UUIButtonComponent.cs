using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020006EE RID: 1774
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.UIButtonComponent")]
	[UnrealStructLayout(1680, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1680)]
	public class UUIButtonComponent : UUISelectableComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060096A9 RID: 38569 RVA: 0x000E3261 File Offset: 0x000E1461
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUIButtonComponent._ClassPtr;
		}

		// Token: 0x060096AA RID: 38570 RVA: 0x000E3270 File Offset: 0x000E1470
		public UUIButtonComponent() : this(BuiltinUtils.AllocNativeUObject(UUIButtonComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060096AB RID: 38571 RVA: 0x000E3298 File Offset: 0x000E1498
		public UUIButtonComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUIButtonComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001BF0 RID: 7152
		// (get) Token: 0x060096AC RID: 38572 RVA: 0x000E32CB File Offset: 0x000E14CB
		// (set) Token: 0x060096AD RID: 38573 RVA: 0x000E32DB File Offset: 0x000E14DB
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

		// Token: 0x17001BF1 RID: 7153
		// (get) Token: 0x060096AE RID: 38574 RVA: 0x000E32EC File Offset: 0x000E14EC
		// (set) Token: 0x060096AF RID: 38575 RVA: 0x000E3325 File Offset: 0x000E1525
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

		// Token: 0x17001BF2 RID: 7154
		// (get) Token: 0x060096B0 RID: 38576 RVA: 0x000E3348 File Offset: 0x000E1548
		// (set) Token: 0x060096B1 RID: 38577 RVA: 0x000E3381 File Offset: 0x000E1581
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

		// Token: 0x17001BF3 RID: 7155
		// (get) Token: 0x060096B2 RID: 38578 RVA: 0x000E33A4 File Offset: 0x000E15A4
		// (set) Token: 0x060096B3 RID: 38579 RVA: 0x000E33DD File Offset: 0x000E15DD
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

		// Token: 0x17001BF4 RID: 7156
		// (get) Token: 0x060096B4 RID: 38580 RVA: 0x000E3400 File Offset: 0x000E1600
		// (set) Token: 0x060096B5 RID: 38581 RVA: 0x000E3439 File Offset: 0x000E1639
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

		// Token: 0x17001BF5 RID: 7157
		// (get) Token: 0x060096B6 RID: 38582 RVA: 0x000E345C File Offset: 0x000E165C
		// (set) Token: 0x060096B7 RID: 38583 RVA: 0x000E3495 File Offset: 0x000E1695
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

		// Token: 0x17001BF6 RID: 7158
		// (get) Token: 0x060096B8 RID: 38584 RVA: 0x000E34B8 File Offset: 0x000E16B8
		// (set) Token: 0x060096B9 RID: 38585 RVA: 0x000E34F1 File Offset: 0x000E16F1
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

		// Token: 0x17001BF7 RID: 7159
		// (get) Token: 0x060096BA RID: 38586 RVA: 0x000E3514 File Offset: 0x000E1714
		// (set) Token: 0x060096BB RID: 38587 RVA: 0x000E354D File Offset: 0x000E174D
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

		// Token: 0x17001BF8 RID: 7160
		// (get) Token: 0x060096BC RID: 38588 RVA: 0x000E3570 File Offset: 0x000E1770
		// (set) Token: 0x060096BD RID: 38589 RVA: 0x000E35A9 File Offset: 0x000E17A9
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

		// Token: 0x17001BF9 RID: 7161
		// (get) Token: 0x060096BE RID: 38590 RVA: 0x000E35CC File Offset: 0x000E17CC
		// (set) Token: 0x060096BF RID: 38591 RVA: 0x000E3605 File Offset: 0x000E1805
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

		// Token: 0x17001BFA RID: 7162
		// (get) Token: 0x060096C0 RID: 38592 RVA: 0x000E3628 File Offset: 0x000E1828
		// (set) Token: 0x060096C1 RID: 38593 RVA: 0x000E3661 File Offset: 0x000E1861
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

		// Token: 0x17001BFB RID: 7163
		// (get) Token: 0x060096C2 RID: 38594 RVA: 0x000E3684 File Offset: 0x000E1884
		// (set) Token: 0x060096C3 RID: 38595 RVA: 0x000E36BD File Offset: 0x000E18BD
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

		// Token: 0x17001BFC RID: 7164
		// (get) Token: 0x060096C4 RID: 38596 RVA: 0x000E36E0 File Offset: 0x000E18E0
		// (set) Token: 0x060096C5 RID: 38597 RVA: 0x000E3719 File Offset: 0x000E1919
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

		// Token: 0x17001BFD RID: 7165
		// (get) Token: 0x060096C6 RID: 38598 RVA: 0x000E3728 File Offset: 0x000E1928
		// (set) Token: 0x060096C7 RID: 38599 RVA: 0x000E3761 File Offset: 0x000E1961
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

		// Token: 0x17001BFE RID: 7166
		// (get) Token: 0x060096C8 RID: 38600 RVA: 0x000E3784 File Offset: 0x000E1984
		// (set) Token: 0x060096C9 RID: 38601 RVA: 0x000E37BD File Offset: 0x000E19BD
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

		// Token: 0x060096CA RID: 38602 RVA: 0x000E37DE File Offset: 0x000E19DE
		[NullableContext(2)]
		public void UnregisterClickEvent(in FLGUIDelegateHandleWrapper InDelegateHandle)
		{
			UUIButtonComponent.__UnregisterClickEvent_Internal(base.NativePtr, (InDelegateHandle ?? new FLGUIDelegateHandleWrapper()).NativePtr);
		}

		// Token: 0x060096CB RID: 38603 RVA: 0x000E37FB File Offset: 0x000E19FB
		public FLGUIDelegateHandleWrapper RegisterClickEvent([Nullable(2)] in FLGUIButtonDynamicDelegate InDelegate)
		{
			IntPtr nativePtr = base.NativePtr;
			FLGUIButtonDynamicDelegate flguibuttonDynamicDelegate = InDelegate;
			return new FLGUIDelegateHandleWrapper(UUIButtonComponent.__RegisterClickEvent_Internal(nativePtr, (flguibuttonDynamicDelegate != null) ? flguibuttonDynamicDelegate.NativePtr : ((IntPtr)0)), null);
		}

		// Token: 0x060096CC RID: 38604 RVA: 0x000E381D File Offset: 0x000E1A1D
		[NullableContext(2)]
		public bool OnPointerDown_Implementation(ULGUIPointerEventData eventData)
		{
			return UUIButtonComponent.__OnPointerDown_Implementation_Internal(base.NativePtr, (eventData != null) ? eventData.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060096CD RID: 38605
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UnregisterClickEvent_Internal(IntPtr @this, IntPtr InDelegateHandle);

		// Token: 0x060096CE RID: 38606
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __RegisterClickEvent_Internal(IntPtr @this, IntPtr InDelegate);

		// Token: 0x060096CF RID: 38607
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __OnPointerDown_Implementation_Internal(IntPtr @this, IntPtr eventData);

		// Token: 0x060096D0 RID: 38608 RVA: 0x000E383A File Offset: 0x000E1A3A
		static UUIButtonComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIButtonComponent");
		}

		// Token: 0x060096D1 RID: 38609 RVA: 0x000E3848 File Offset: 0x000E1A48
		protected UUIButtonComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400417B RID: 16763
		public new const string __ObjectPath = "/Script/LGUI.UIButtonComponent";

		// Token: 0x0400417C RID: 16764
		private static IntPtr _ClassPtr;

		// Token: 0x0400417D RID: 16765
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400417E RID: 16766
		internal static int __PropertyOffset_bAllowChangeCursorStyleWhenEnter;

		// Token: 0x0400417F RID: 16767
		internal static int __PropertyOffset_OnClickCallBack;

		// Token: 0x04004180 RID: 16768
		[Nullable(2)]
		private FLGUIButtonDynamicDelegate _OnClickCallBack;

		// Token: 0x04004181 RID: 16769
		internal static int __PropertyOffset_OnPointDownCallBack;

		// Token: 0x04004182 RID: 16770
		[Nullable(2)]
		private FLGUIButtonDynamicDelegate _OnPointDownCallBack;

		// Token: 0x04004183 RID: 16771
		internal static int __PropertyOffset_OnPointUpCallBack;

		// Token: 0x04004184 RID: 16772
		[Nullable(2)]
		private FLGUIButtonDynamicDelegate _OnPointUpCallBack;

		// Token: 0x04004185 RID: 16773
		internal static int __PropertyOffset_OnPointCancelCallBack;

		// Token: 0x04004186 RID: 16774
		[Nullable(2)]
		private FLGUIButtonDynamicDelegate _OnPointCancelCallBack;

		// Token: 0x04004187 RID: 16775
		internal static int __PropertyOffset_OnPointEnterCallBack;

		// Token: 0x04004188 RID: 16776
		[Nullable(2)]
		private FLGUIButtonDynamicDelegate _OnPointEnterCallBack;

		// Token: 0x04004189 RID: 16777
		internal static int __PropertyOffset_OnPointExitCallBack;

		// Token: 0x0400418A RID: 16778
		[Nullable(2)]
		private FLGUIButtonDynamicDelegate _OnPointExitCallBack;

		// Token: 0x0400418B RID: 16779
		internal static int __PropertyOffset_OnPointerBeginDragCallBack;

		// Token: 0x0400418C RID: 16780
		[Nullable(2)]
		private FLGUIButtonDynamicDelegateOneParams _OnPointerBeginDragCallBack;

		// Token: 0x0400418D RID: 16781
		internal static int __PropertyOffset_OnPointerDragCallBack;

		// Token: 0x0400418E RID: 16782
		[Nullable(2)]
		private FLGUIButtonDynamicDelegateOneParams _OnPointerDragCallBack;

		// Token: 0x0400418F RID: 16783
		internal static int __PropertyOffset_OnPointerEndDragCallBack;

		// Token: 0x04004190 RID: 16784
		[Nullable(2)]
		private FLGUIButtonDynamicDelegateOneParams _OnPointerEndDragCallBack;

		// Token: 0x04004191 RID: 16785
		internal static int __PropertyOffset_AkAudioEvent;

		// Token: 0x04004192 RID: 16786
		[Nullable(2)]
		private FSoftObjectPath _AkAudioEvent;

		// Token: 0x04004193 RID: 16787
		internal static int __PropertyOffset_OnPostAudioEvent;

		// Token: 0x04004194 RID: 16788
		[Nullable(2)]
		private FLGUIButtonAudioDelegate _OnPostAudioEvent;

		// Token: 0x04004195 RID: 16789
		internal static int __PropertyOffset_AudioConfig;

		// Token: 0x04004196 RID: 16790
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<EButtonAudioStateTransferType, FSoftObjectPath> _AudioConfig;

		// Token: 0x04004197 RID: 16791
		internal static int __PropertyOffset_LongPressAudioEvent;

		// Token: 0x04004198 RID: 16792
		[Nullable(2)]
		private FSoftObjectPath _LongPressAudioEvent;

		// Token: 0x04004199 RID: 16793
		internal static int __PropertyOffset_OnPostAudioStateEvent;

		// Token: 0x0400419A RID: 16794
		[Nullable(2)]
		private FLGUIButtonAudioWithStateDelegate _OnPostAudioStateEvent;
	}
}
