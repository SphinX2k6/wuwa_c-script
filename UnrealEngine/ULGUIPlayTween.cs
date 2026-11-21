using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020006AA RID: 1706
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.LGUIPlayTween")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 192)]
	public abstract class ULGUIPlayTween : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600928F RID: 37519 RVA: 0x000DCDED File Offset: 0x000DAFED
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULGUIPlayTween._ClassPtr;
		}

		// Token: 0x17001B54 RID: 6996
		// (get) Token: 0x06009290 RID: 37520 RVA: 0x000DCDF9 File Offset: 0x000DAFF9
		// (set) Token: 0x06009291 RID: 37521 RVA: 0x000DCE09 File Offset: 0x000DB009
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

		// Token: 0x17001B55 RID: 6997
		// (get) Token: 0x06009292 RID: 37522 RVA: 0x000DCE1A File Offset: 0x000DB01A
		// (set) Token: 0x06009293 RID: 37523 RVA: 0x000DCE2A File Offset: 0x000DB02A
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

		// Token: 0x17001B56 RID: 6998
		// (get) Token: 0x06009294 RID: 37524 RVA: 0x000DCE3B File Offset: 0x000DB03B
		// (set) Token: 0x06009295 RID: 37525 RVA: 0x000DCE4F File Offset: 0x000DB04F
		public unsafe UCurveFloat easeCurve
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + ULGUIPlayTween.__PropertyOffset_easeCurve);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ULGUIPlayTween.__PropertyOffset_easeCurve, value);
			}
		}

		// Token: 0x17001B57 RID: 6999
		// (get) Token: 0x06009296 RID: 37526 RVA: 0x000DCE64 File Offset: 0x000DB064
		// (set) Token: 0x06009297 RID: 37527 RVA: 0x000DCE74 File Offset: 0x000DB074
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

		// Token: 0x17001B58 RID: 7000
		// (get) Token: 0x06009298 RID: 37528 RVA: 0x000DCE85 File Offset: 0x000DB085
		// (set) Token: 0x06009299 RID: 37529 RVA: 0x000DCE95 File Offset: 0x000DB095
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

		// Token: 0x17001B59 RID: 7001
		// (get) Token: 0x0600929A RID: 37530 RVA: 0x000DCEA6 File Offset: 0x000DB0A6
		// (set) Token: 0x0600929B RID: 37531 RVA: 0x000DCEB6 File Offset: 0x000DB0B6
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

		// Token: 0x17001B5A RID: 7002
		// (get) Token: 0x0600929C RID: 37532 RVA: 0x000DCEC7 File Offset: 0x000DB0C7
		// (set) Token: 0x0600929D RID: 37533 RVA: 0x000DCEDB File Offset: 0x000DB0DB
		public unsafe ULTweener tweener
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ULTweener>(base.NativePtr / (IntPtr)sizeof(void*) + ULGUIPlayTween.__PropertyOffset_tweener);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ULGUIPlayTween.__PropertyOffset_tweener, value);
			}
		}

		// Token: 0x0600929E RID: 37534 RVA: 0x000DCEF0 File Offset: 0x000DB0F0
		public void UnregisterOnComplete(in FLGUIDelegateHandleWrapper InDelegateHandle)
		{
			ULGUIPlayTween.__UnregisterOnComplete_Internal(base.NativePtr, (InDelegateHandle ?? new FLGUIDelegateHandleWrapper()).NativePtr);
		}

		// Token: 0x0600929F RID: 37535 RVA: 0x000DCF0D File Offset: 0x000DB10D
		public void Stop()
		{
			ULGUIPlayTween.__Stop_Internal(base.NativePtr);
		}

		// Token: 0x060092A0 RID: 37536 RVA: 0x000DCF1A File Offset: 0x000DB11A
		public void Start()
		{
			ULGUIPlayTween.__Start_Internal(base.NativePtr);
		}

		// Token: 0x060092A1 RID: 37537 RVA: 0x000DCF27 File Offset: 0x000DB127
		public void Resume()
		{
			ULGUIPlayTween.__Resume_Internal(base.NativePtr);
		}

		// Token: 0x060092A2 RID: 37538 RVA: 0x000DCF34 File Offset: 0x000DB134
		[NullableContext(1)]
		public FLGUIDelegateHandleWrapper RegisterOnComplete([Nullable(2)] in FLGUIPlayTweenCompleteDynamicDelegate InDelegate)
		{
			IntPtr nativePtr = base.NativePtr;
			FLGUIPlayTweenCompleteDynamicDelegate flguiplayTweenCompleteDynamicDelegate = InDelegate;
			return new FLGUIDelegateHandleWrapper(ULGUIPlayTween.__RegisterOnComplete_Internal(nativePtr, (flguiplayTweenCompleteDynamicDelegate != null) ? flguiplayTweenCompleteDynamicDelegate.NativePtr : ((IntPtr)0)), null);
		}

		// Token: 0x060092A3 RID: 37539 RVA: 0x000DCF56 File Offset: 0x000DB156
		public void Pause()
		{
			ULGUIPlayTween.__Pause_Internal(base.NativePtr);
		}

		// Token: 0x060092A4 RID: 37540 RVA: 0x000DCF63 File Offset: 0x000DB163
		public ULTweener GetTweener()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULGUIPlayTween.__GetTweener_Internal(base.NativePtr));
		}

		// Token: 0x060092A5 RID: 37541
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UnregisterOnComplete_Internal(IntPtr @this, IntPtr InDelegateHandle);

		// Token: 0x060092A6 RID: 37542
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Stop_Internal(IntPtr @this);

		// Token: 0x060092A7 RID: 37543
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Start_Internal(IntPtr @this);

		// Token: 0x060092A8 RID: 37544
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Resume_Internal(IntPtr @this);

		// Token: 0x060092A9 RID: 37545
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __RegisterOnComplete_Internal(IntPtr @this, IntPtr InDelegate);

		// Token: 0x060092AA RID: 37546
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Pause_Internal(IntPtr @this);

		// Token: 0x060092AB RID: 37547
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetTweener_Internal(IntPtr @this);

		// Token: 0x060092AC RID: 37548 RVA: 0x000DCF75 File Offset: 0x000DB175
		static ULGUIPlayTween()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.LGUIPlayTween");
		}

		// Token: 0x060092AD RID: 37549 RVA: 0x000DCF84 File Offset: 0x000DB184
		protected ULGUIPlayTween() : this(BuiltinUtils.AllocNativeUObject(ULGUIPlayTween.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060092AE RID: 37550 RVA: 0x000DCFAC File Offset: 0x000DB1AC
		protected ULGUIPlayTween(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003FE7 RID: 16359
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.LGUIPlayTween";

		// Token: 0x04003FE8 RID: 16360
		private static IntPtr _ClassPtr;

		// Token: 0x04003FE9 RID: 16361
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003FEA RID: 16362
		internal static int __PropertyOffset_loopCount;

		// Token: 0x04003FEB RID: 16363
		internal static int __PropertyOffset_easeType;

		// Token: 0x04003FEC RID: 16364
		internal static int __PropertyOffset_easeCurve;

		// Token: 0x04003FED RID: 16365
		internal static int __PropertyOffset_duration;

		// Token: 0x04003FEE RID: 16366
		internal static int __PropertyOffset_startDelay;

		// Token: 0x04003FEF RID: 16367
		internal static int __PropertyOffset_speed;

		// Token: 0x04003FF0 RID: 16368
		internal static int __PropertyOffset_tweener;
	}
}
