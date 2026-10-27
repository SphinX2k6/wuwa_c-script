using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002093 RID: 8339
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.LGUIPlayTween")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 192)]
	public abstract class ULGUIPlayTween : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601F727 RID: 128807 RVA: 0x002EB91D File Offset: 0x002E9B1D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULGUIPlayTween._ClassPtr;
		}

		// Token: 0x17007C0F RID: 31759
		// (get) Token: 0x0601F728 RID: 128808 RVA: 0x002EB929 File Offset: 0x002E9B29
		// (set) Token: 0x0601F729 RID: 128809 RVA: 0x002EB939 File Offset: 0x002E9B39
		public unsafe LTweenLoop loopType
		{
			get
			{
				return (LTweenLoop)(*(base.NativePtr + (IntPtr)ULGUIPlayTween.__PropertyOffset_loopType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUIPlayTween.__PropertyOffset_loopType) = (byte)value;
			}
		}

		// Token: 0x17007C10 RID: 31760
		// (get) Token: 0x0601F72A RID: 128810 RVA: 0x002EB94A File Offset: 0x002E9B4A
		// (set) Token: 0x0601F72B RID: 128811 RVA: 0x002EB95A File Offset: 0x002E9B5A
		public unsafe int loopCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUIPlayTween.__PropertyOffset_loopCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUIPlayTween.__PropertyOffset_loopCount) = value;
			}
		}

		// Token: 0x17007C11 RID: 31761
		// (get) Token: 0x0601F72C RID: 128812 RVA: 0x002EB96B File Offset: 0x002E9B6B
		// (set) Token: 0x0601F72D RID: 128813 RVA: 0x002EB97B File Offset: 0x002E9B7B
		public unsafe LTweenEase easeType
		{
			get
			{
				return (LTweenEase)(*(base.NativePtr + (IntPtr)ULGUIPlayTween.__PropertyOffset_easeType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUIPlayTween.__PropertyOffset_easeType) = (byte)value;
			}
		}

		// Token: 0x17007C12 RID: 31762
		// (get) Token: 0x0601F72E RID: 128814 RVA: 0x002EB98C File Offset: 0x002E9B8C
		// (set) Token: 0x0601F72F RID: 128815 RVA: 0x002EB9A0 File Offset: 0x002E9BA0
		[Nullable(2)]
		public unsafe UCurveFloat easeCurve
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + ULGUIPlayTween.__PropertyOffset_easeCurve);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ULGUIPlayTween.__PropertyOffset_easeCurve, value);
			}
		}

		// Token: 0x17007C13 RID: 31763
		// (get) Token: 0x0601F730 RID: 128816 RVA: 0x002EB9B5 File Offset: 0x002E9BB5
		// (set) Token: 0x0601F731 RID: 128817 RVA: 0x002EB9C5 File Offset: 0x002E9BC5
		public unsafe float duration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUIPlayTween.__PropertyOffset_duration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUIPlayTween.__PropertyOffset_duration) = value;
			}
		}

		// Token: 0x17007C14 RID: 31764
		// (get) Token: 0x0601F732 RID: 128818 RVA: 0x002EB9D6 File Offset: 0x002E9BD6
		// (set) Token: 0x0601F733 RID: 128819 RVA: 0x002EB9E6 File Offset: 0x002E9BE6
		public unsafe float startDelay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUIPlayTween.__PropertyOffset_startDelay);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUIPlayTween.__PropertyOffset_startDelay) = value;
			}
		}

		// Token: 0x17007C15 RID: 31765
		// (get) Token: 0x0601F734 RID: 128820 RVA: 0x002EB9F7 File Offset: 0x002E9BF7
		// (set) Token: 0x0601F735 RID: 128821 RVA: 0x002EBA07 File Offset: 0x002E9C07
		public unsafe float speed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUIPlayTween.__PropertyOffset_speed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUIPlayTween.__PropertyOffset_speed) = value;
			}
		}

		// Token: 0x17007C16 RID: 31766
		// (get) Token: 0x0601F736 RID: 128822 RVA: 0x002EBA18 File Offset: 0x002E9C18
		// (set) Token: 0x0601F737 RID: 128823 RVA: 0x002EBA51 File Offset: 0x002E9C51
		public FLGUIDrawableEvent onStart
		{
			get
			{
				base.FastCheckIsValid();
				FLGUIDrawableEvent result;
				if ((result = this._onStart) == null)
				{
					result = (this._onStart = new FLGUIDrawableEvent(base.NativePtr + (IntPtr)ULGUIPlayTween.__PropertyOffset_onStart, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FLGUIDrawableEvent.StaticStruct(), base.NativePtr + (IntPtr)ULGUIPlayTween.__PropertyOffset_onStart, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007C17 RID: 31767
		// (get) Token: 0x0601F738 RID: 128824 RVA: 0x002EBA74 File Offset: 0x002E9C74
		// (set) Token: 0x0601F739 RID: 128825 RVA: 0x002EBAAD File Offset: 0x002E9CAD
		public FLGUIDrawableEvent onUpdateProgress
		{
			get
			{
				base.FastCheckIsValid();
				FLGUIDrawableEvent result;
				if ((result = this._onUpdateProgress) == null)
				{
					result = (this._onUpdateProgress = new FLGUIDrawableEvent(base.NativePtr + (IntPtr)ULGUIPlayTween.__PropertyOffset_onUpdateProgress, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FLGUIDrawableEvent.StaticStruct(), base.NativePtr + (IntPtr)ULGUIPlayTween.__PropertyOffset_onUpdateProgress, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007C18 RID: 31768
		// (get) Token: 0x0601F73A RID: 128826 RVA: 0x002EBAD0 File Offset: 0x002E9CD0
		// (set) Token: 0x0601F73B RID: 128827 RVA: 0x002EBB09 File Offset: 0x002E9D09
		public FLGUIDrawableEvent onComplete
		{
			get
			{
				base.FastCheckIsValid();
				FLGUIDrawableEvent result;
				if ((result = this._onComplete) == null)
				{
					result = (this._onComplete = new FLGUIDrawableEvent(base.NativePtr + (IntPtr)ULGUIPlayTween.__PropertyOffset_onComplete, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FLGUIDrawableEvent.StaticStruct(), base.NativePtr + (IntPtr)ULGUIPlayTween.__PropertyOffset_onComplete, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007C19 RID: 31769
		// (get) Token: 0x0601F73C RID: 128828 RVA: 0x002EBB2A File Offset: 0x002E9D2A
		// (set) Token: 0x0601F73D RID: 128829 RVA: 0x002EBB3E File Offset: 0x002E9D3E
		[Nullable(2)]
		public unsafe ULTweener tweener
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ULTweener>(base.NativePtr / (IntPtr)sizeof(void*) + ULGUIPlayTween.__PropertyOffset_tweener);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ULGUIPlayTween.__PropertyOffset_tweener, value);
			}
		}

		// Token: 0x0601F73E RID: 128830 RVA: 0x002EBB53 File Offset: 0x002E9D53
		[NullableContext(2)]
		public void UnregisterOnComplete(in FLGUIDelegateHandleWrapper InDelegateHandle)
		{
			ULGUIPlayTween.__UnregisterOnComplete_Internal(base.NativePtr, (InDelegateHandle ?? new FLGUIDelegateHandleWrapper()).NativePtr);
		}

		// Token: 0x0601F73F RID: 128831 RVA: 0x002EBB70 File Offset: 0x002E9D70
		public void Stop()
		{
			ULGUIPlayTween.__Stop_Internal(base.NativePtr);
		}

		// Token: 0x0601F740 RID: 128832 RVA: 0x002EBB7D File Offset: 0x002E9D7D
		public void Start()
		{
			ULGUIPlayTween.__Start_Internal(base.NativePtr);
		}

		// Token: 0x0601F741 RID: 128833 RVA: 0x002EBB8A File Offset: 0x002E9D8A
		public void Resume()
		{
			ULGUIPlayTween.__Resume_Internal(base.NativePtr);
		}

		// Token: 0x0601F742 RID: 128834 RVA: 0x002EBB97 File Offset: 0x002E9D97
		public FLGUIDelegateHandleWrapper RegisterOnComplete([Nullable(2)] in FLGUIPlayTweenCompleteDynamicDelegate InDelegate)
		{
			IntPtr nativePtr = base.NativePtr;
			FLGUIPlayTweenCompleteDynamicDelegate flguiplayTweenCompleteDynamicDelegate = InDelegate;
			return new FLGUIDelegateHandleWrapper(ULGUIPlayTween.__RegisterOnComplete_Internal(nativePtr, (flguiplayTweenCompleteDynamicDelegate != null) ? flguiplayTweenCompleteDynamicDelegate.NativePtr : ((IntPtr)0)), null);
		}

		// Token: 0x0601F743 RID: 128835 RVA: 0x002EBBB9 File Offset: 0x002E9DB9
		public void Pause()
		{
			ULGUIPlayTween.__Pause_Internal(base.NativePtr);
		}

		// Token: 0x0601F744 RID: 128836 RVA: 0x002EBBC6 File Offset: 0x002E9DC6
		[NullableContext(2)]
		public ULTweener GetTweener()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULGUIPlayTween.__GetTweener_Internal(base.NativePtr));
		}

		// Token: 0x0601F745 RID: 128837
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UnregisterOnComplete_Internal(IntPtr @this, IntPtr InDelegateHandle);

		// Token: 0x0601F746 RID: 128838
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Stop_Internal(IntPtr @this);

		// Token: 0x0601F747 RID: 128839
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Start_Internal(IntPtr @this);

		// Token: 0x0601F748 RID: 128840
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Resume_Internal(IntPtr @this);

		// Token: 0x0601F749 RID: 128841
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __RegisterOnComplete_Internal(IntPtr @this, IntPtr InDelegate);

		// Token: 0x0601F74A RID: 128842
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Pause_Internal(IntPtr @this);

		// Token: 0x0601F74B RID: 128843
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetTweener_Internal(IntPtr @this);

		// Token: 0x0601F74C RID: 128844 RVA: 0x002EBBD8 File Offset: 0x002E9DD8
		static ULGUIPlayTween()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.LGUIPlayTween");
		}

		// Token: 0x0601F74D RID: 128845 RVA: 0x002EBBE8 File Offset: 0x002E9DE8
		protected ULGUIPlayTween() : this(BuiltinUtils.AllocNativeUObject(ULGUIPlayTween.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601F74E RID: 128846 RVA: 0x002EBC10 File Offset: 0x002E9E10
		protected ULGUIPlayTween(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010FB7 RID: 69559
		public new const string __ObjectPath = "/Script/LGUI.LGUIPlayTween";

		// Token: 0x04010FB8 RID: 69560
		private static IntPtr _ClassPtr;

		// Token: 0x04010FB9 RID: 69561
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010FBA RID: 69562
		internal static int __PropertyOffset_loopType;

		// Token: 0x04010FBB RID: 69563
		internal static int __PropertyOffset_loopCount;

		// Token: 0x04010FBC RID: 69564
		internal static int __PropertyOffset_easeType;

		// Token: 0x04010FBD RID: 69565
		internal static int __PropertyOffset_easeCurve;

		// Token: 0x04010FBE RID: 69566
		internal static int __PropertyOffset_duration;

		// Token: 0x04010FBF RID: 69567
		internal static int __PropertyOffset_startDelay;

		// Token: 0x04010FC0 RID: 69568
		internal static int __PropertyOffset_speed;

		// Token: 0x04010FC1 RID: 69569
		internal static int __PropertyOffset_onStart;

		// Token: 0x04010FC2 RID: 69570
		[Nullable(2)]
		private FLGUIDrawableEvent _onStart;

		// Token: 0x04010FC3 RID: 69571
		internal static int __PropertyOffset_onUpdateProgress;

		// Token: 0x04010FC4 RID: 69572
		[Nullable(2)]
		private FLGUIDrawableEvent _onUpdateProgress;

		// Token: 0x04010FC5 RID: 69573
		internal static int __PropertyOffset_onComplete;

		// Token: 0x04010FC6 RID: 69574
		[Nullable(2)]
		private FLGUIDrawableEvent _onComplete;

		// Token: 0x04010FC7 RID: 69575
		internal static int __PropertyOffset_tweener;
	}
}
