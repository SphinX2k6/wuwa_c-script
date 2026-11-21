using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020000BB RID: 187
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AkAudio.AkAudioEvent")]
	[UnrealStructLayout(288, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 288)]
	public class UAkAudioEvent : UAkAudioType, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06000DE8 RID: 3560 RVA: 0x00015D6F File Offset: 0x00013F6F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAkAudioEvent._ClassPtr;
		}

		// Token: 0x06000DE9 RID: 3561 RVA: 0x00015D7C File Offset: 0x00013F7C
		public UAkAudioEvent() : this(BuiltinUtils.AllocNativeUObject(UAkAudioEvent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06000DEA RID: 3562 RVA: 0x00015DA4 File Offset: 0x00013FA4
		[NullableContext(1)]
		public UAkAudioEvent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAkAudioEvent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x06000DEB RID: 3563 RVA: 0x00015DD7 File Offset: 0x00013FD7
		// (set) Token: 0x06000DEC RID: 3564 RVA: 0x00015DE7 File Offset: 0x00013FE7
		public unsafe float MaxAttenuationRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAkAudioEvent.__PropertyOffset_MaxAttenuationRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAkAudioEvent.__PropertyOffset_MaxAttenuationRadius) = value;
			}
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x06000DED RID: 3565 RVA: 0x00015DF8 File Offset: 0x00013FF8
		// (set) Token: 0x06000DEE RID: 3566 RVA: 0x00015E08 File Offset: 0x00014008
		public unsafe bool IsInfinite
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAkAudioEvent.__PropertyOffset_IsInfinite) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAkAudioEvent.__PropertyOffset_IsInfinite) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x06000DEF RID: 3567 RVA: 0x00015E19 File Offset: 0x00014019
		// (set) Token: 0x06000DF0 RID: 3568 RVA: 0x00015E29 File Offset: 0x00014029
		public unsafe float MinimumDuration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAkAudioEvent.__PropertyOffset_MinimumDuration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAkAudioEvent.__PropertyOffset_MinimumDuration) = value;
			}
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x06000DF1 RID: 3569 RVA: 0x00015E3A File Offset: 0x0001403A
		// (set) Token: 0x06000DF2 RID: 3570 RVA: 0x00015E4A File Offset: 0x0001404A
		public unsafe float MaximumDuration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAkAudioEvent.__PropertyOffset_MaximumDuration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAkAudioEvent.__PropertyOffset_MaximumDuration) = value;
			}
		}

		// Token: 0x06000DF3 RID: 3571 RVA: 0x00015E5B File Offset: 0x0001405B
		public int PostOnGameObject(UAkGameObject GameObject, in FOnAkPostEventCallback Delegate, int CallbackMask)
		{
			IntPtr nativePtr = base.NativePtr;
			IntPtr gameObject = (GameObject != null) ? GameObject.NativePtr : IntPtr.Zero;
			FOnAkPostEventCallback fonAkPostEventCallback = Delegate;
			return UAkAudioEvent.__PostOnGameObject_Internal(nativePtr, gameObject, (fonAkPostEventCallback != null) ? fonAkPostEventCallback.NativePtr : ((IntPtr)0), CallbackMask);
		}

		// Token: 0x06000DF4 RID: 3572 RVA: 0x00015E88 File Offset: 0x00014088
		public int PostOnComponent(UAkComponent Component, in FOnAkPostEventCallback Delegate, int CallbackMask, bool bStopWhenAttachedObjectDestroyed)
		{
			IntPtr nativePtr = base.NativePtr;
			IntPtr component = (Component != null) ? Component.NativePtr : IntPtr.Zero;
			FOnAkPostEventCallback fonAkPostEventCallback = Delegate;
			return UAkAudioEvent.__PostOnComponent_Internal(nativePtr, component, (fonAkPostEventCallback != null) ? fonAkPostEventCallback.NativePtr : ((IntPtr)0), CallbackMask, bStopWhenAttachedObjectDestroyed);
		}

		// Token: 0x06000DF5 RID: 3573 RVA: 0x00015EB7 File Offset: 0x000140B7
		public int PostOnActor(AActor Actor, in FOnAkPostEventCallback Delegate, int CallbackMask, bool bStopWhenAttachedObjectDestroyed)
		{
			IntPtr nativePtr = base.NativePtr;
			IntPtr actor = (Actor != null) ? Actor.NativePtr : IntPtr.Zero;
			FOnAkPostEventCallback fonAkPostEventCallback = Delegate;
			return UAkAudioEvent.__PostOnActor_Internal(nativePtr, actor, (fonAkPostEventCallback != null) ? fonAkPostEventCallback.NativePtr : ((IntPtr)0), CallbackMask, bStopWhenAttachedObjectDestroyed);
		}

		// Token: 0x06000DF6 RID: 3574 RVA: 0x00015EE6 File Offset: 0x000140E6
		public int PostAtLocation(FVector Location, FRotator Orientation, in FOnAkPostEventCallback Callback, int CallbackMask, UObject WorldContextObject)
		{
			IntPtr nativePtr = base.NativePtr;
			FOnAkPostEventCallback fonAkPostEventCallback = Callback;
			return UAkAudioEvent.__PostAtLocation_Internal(nativePtr, Location, Orientation, (fonAkPostEventCallback != null) ? fonAkPostEventCallback.NativePtr : ((IntPtr)0), CallbackMask, (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06000DF7 RID: 3575 RVA: 0x00015F18 File Offset: 0x00014118
		public int ExecuteAction(EAkActionOnEventType ActionType, AActor Actor, int PlayingID = 0, int TransitionDuration = 0, EAkCurveInterpolation FadeCurve = EAkCurveInterpolation.Linear)
		{
			return UAkAudioEvent.__ExecuteAction_Internal(base.NativePtr, ActionType, (Actor != null) ? Actor.NativePtr : IntPtr.Zero, PlayingID, TransitionDuration, FadeCurve);
		}

		// Token: 0x06000DF8 RID: 3576 RVA: 0x00015F3B File Offset: 0x0001413B
		public int D_PostAtLocation(FVectorDouble Location, FRotator Orientation, in FOnAkPostEventCallback Callback, int CallbackMask, UObject WorldContextObject)
		{
			IntPtr nativePtr = base.NativePtr;
			FOnAkPostEventCallback fonAkPostEventCallback = Callback;
			return UAkAudioEvent.__D_PostAtLocation_Internal(nativePtr, Location, Orientation, (fonAkPostEventCallback != null) ? fonAkPostEventCallback.NativePtr : ((IntPtr)0), CallbackMask, (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06000DF9 RID: 3577
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __PostOnGameObject_Internal(IntPtr @this, IntPtr GameObject, IntPtr Delegate, int CallbackMask);

		// Token: 0x06000DFA RID: 3578
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __PostOnComponent_Internal(IntPtr @this, IntPtr Component, IntPtr Delegate, int CallbackMask, bool bStopWhenAttachedObjectDestroyed);

		// Token: 0x06000DFB RID: 3579
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __PostOnActor_Internal(IntPtr @this, IntPtr Actor, IntPtr Delegate, int CallbackMask, bool bStopWhenAttachedObjectDestroyed);

		// Token: 0x06000DFC RID: 3580
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __PostAtLocation_Internal(IntPtr @this, FVector Location, FRotator Orientation, IntPtr Callback, int CallbackMask, IntPtr WorldContextObject);

		// Token: 0x06000DFD RID: 3581
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __ExecuteAction_Internal(IntPtr @this, EAkActionOnEventType ActionType, IntPtr Actor, int PlayingID, int TransitionDuration, EAkCurveInterpolation FadeCurve);

		// Token: 0x06000DFE RID: 3582
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __D_PostAtLocation_Internal(IntPtr @this, FVectorDouble Location, FRotator Orientation, IntPtr Callback, int CallbackMask, IntPtr WorldContextObject);

		// Token: 0x06000DFF RID: 3583 RVA: 0x00015F6D File Offset: 0x0001416D
		static UAkAudioEvent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AkAudio.AkAudioEvent");
		}

		// Token: 0x06000E00 RID: 3584 RVA: 0x00015F7B File Offset: 0x0001417B
		protected UAkAudioEvent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040002A6 RID: 678
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AkAudio.AkAudioEvent";

		// Token: 0x040002A7 RID: 679
		private static IntPtr _ClassPtr;

		// Token: 0x040002A8 RID: 680
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040002A9 RID: 681
		internal static int __PropertyOffset_MaxAttenuationRadius;

		// Token: 0x040002AA RID: 682
		internal static int __PropertyOffset_IsInfinite;

		// Token: 0x040002AB RID: 683
		internal static int __PropertyOffset_MinimumDuration;

		// Token: 0x040002AC RID: 684
		internal static int __PropertyOffset_MaximumDuration;
	}
}
