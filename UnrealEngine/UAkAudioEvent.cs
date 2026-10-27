using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020001F0 RID: 496
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AkAudio.AkAudioEvent")]
	[UnrealStructLayout(288, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 288)]
	public class UAkAudioEvent : UAkAudioType, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001D28 RID: 7464 RVA: 0x0002B72F File Offset: 0x0002992F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAkAudioEvent._ClassPtr;
		}

		// Token: 0x06001D29 RID: 7465 RVA: 0x0002B73C File Offset: 0x0002993C
		public UAkAudioEvent() : this(BuiltinUtils.AllocNativeUObject(UAkAudioEvent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001D2A RID: 7466 RVA: 0x0002B764 File Offset: 0x00029964
		[NullableContext(1)]
		public UAkAudioEvent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAkAudioEvent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700075E RID: 1886
		// (get) Token: 0x06001D2B RID: 7467 RVA: 0x0002B797 File Offset: 0x00029997
		// (set) Token: 0x06001D2C RID: 7468 RVA: 0x0002B7A7 File Offset: 0x000299A7
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

		// Token: 0x1700075F RID: 1887
		// (get) Token: 0x06001D2D RID: 7469 RVA: 0x0002B7B8 File Offset: 0x000299B8
		// (set) Token: 0x06001D2E RID: 7470 RVA: 0x0002B7C8 File Offset: 0x000299C8
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

		// Token: 0x17000760 RID: 1888
		// (get) Token: 0x06001D2F RID: 7471 RVA: 0x0002B7D9 File Offset: 0x000299D9
		// (set) Token: 0x06001D30 RID: 7472 RVA: 0x0002B7E9 File Offset: 0x000299E9
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

		// Token: 0x17000761 RID: 1889
		// (get) Token: 0x06001D31 RID: 7473 RVA: 0x0002B7FA File Offset: 0x000299FA
		// (set) Token: 0x06001D32 RID: 7474 RVA: 0x0002B80A File Offset: 0x00029A0A
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

		// Token: 0x17000762 RID: 1890
		// (get) Token: 0x06001D33 RID: 7475 RVA: 0x0002B81C File Offset: 0x00029A1C
		// (set) Token: 0x06001D34 RID: 7476 RVA: 0x0002B855 File Offset: 0x00029A55
		[Nullable(1)]
		public FWwiseLocalizedEventCookedData EventCookedData
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FWwiseLocalizedEventCookedData result;
				if ((result = this._EventCookedData) == null)
				{
					result = (this._EventCookedData = new FWwiseLocalizedEventCookedData(base.NativePtr + (IntPtr)UAkAudioEvent.__PropertyOffset_EventCookedData, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FWwiseLocalizedEventCookedData.StaticStruct(), base.NativePtr + (IntPtr)UAkAudioEvent.__PropertyOffset_EventCookedData, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000763 RID: 1891
		// (get) Token: 0x06001D35 RID: 7477 RVA: 0x0002B876 File Offset: 0x00029A76
		// (set) Token: 0x06001D36 RID: 7478 RVA: 0x0002B88A File Offset: 0x00029A8A
		public unsafe UAkAudioBank RequiredBank_DEPRECATED
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAkAudioBank>(base.NativePtr / (IntPtr)sizeof(void*) + UAkAudioEvent.__PropertyOffset_RequiredBank_DEPRECATED);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UAkAudioEvent.__PropertyOffset_RequiredBank_DEPRECATED, value);
			}
		}

		// Token: 0x06001D37 RID: 7479 RVA: 0x0002B89F File Offset: 0x00029A9F
		public int PostOnGameObjectAndWait(UAkGameObject GameObject, FLatentActionInfo LatentActionInfo)
		{
			return UAkAudioEvent.__PostOnGameObjectAndWait_Internal(base.NativePtr, (GameObject != null) ? GameObject.NativePtr : IntPtr.Zero, (LatentActionInfo ?? new FLatentActionInfo()).NativePtr);
		}

		// Token: 0x06001D38 RID: 7480 RVA: 0x0002B8CB File Offset: 0x00029ACB
		public int PostOnGameObject(UAkGameObject GameObject, in FOnAkPostEventCallback Delegate, int CallbackMask)
		{
			IntPtr nativePtr = base.NativePtr;
			IntPtr gameObject = (GameObject != null) ? GameObject.NativePtr : IntPtr.Zero;
			FOnAkPostEventCallback fonAkPostEventCallback = Delegate;
			return UAkAudioEvent.__PostOnGameObject_Internal(nativePtr, gameObject, (fonAkPostEventCallback != null) ? fonAkPostEventCallback.NativePtr : ((IntPtr)0), CallbackMask);
		}

		// Token: 0x06001D39 RID: 7481 RVA: 0x0002B8F8 File Offset: 0x00029AF8
		public int PostOnComponentAndWait(UAkComponent Component, bool bStopWhenAttachedObjectDestroyed, FLatentActionInfo LatentActionInfo)
		{
			return UAkAudioEvent.__PostOnComponentAndWait_Internal(base.NativePtr, (Component != null) ? Component.NativePtr : IntPtr.Zero, bStopWhenAttachedObjectDestroyed, (LatentActionInfo ?? new FLatentActionInfo()).NativePtr);
		}

		// Token: 0x06001D3A RID: 7482 RVA: 0x0002B925 File Offset: 0x00029B25
		public int PostOnComponent(UAkComponent Component, in FOnAkPostEventCallback Delegate, int CallbackMask, bool bStopWhenAttachedObjectDestroyed)
		{
			IntPtr nativePtr = base.NativePtr;
			IntPtr component = (Component != null) ? Component.NativePtr : IntPtr.Zero;
			FOnAkPostEventCallback fonAkPostEventCallback = Delegate;
			return UAkAudioEvent.__PostOnComponent_Internal(nativePtr, component, (fonAkPostEventCallback != null) ? fonAkPostEventCallback.NativePtr : ((IntPtr)0), CallbackMask, bStopWhenAttachedObjectDestroyed);
		}

		// Token: 0x06001D3B RID: 7483 RVA: 0x0002B954 File Offset: 0x00029B54
		public int PostOnActorAndWait(AActor Actor, bool bStopWhenAttachedObjectDestroyed, FLatentActionInfo LatentActionInfo)
		{
			return UAkAudioEvent.__PostOnActorAndWait_Internal(base.NativePtr, (Actor != null) ? Actor.NativePtr : IntPtr.Zero, bStopWhenAttachedObjectDestroyed, (LatentActionInfo ?? new FLatentActionInfo()).NativePtr);
		}

		// Token: 0x06001D3C RID: 7484 RVA: 0x0002B981 File Offset: 0x00029B81
		public int PostOnActor(AActor Actor, in FOnAkPostEventCallback Delegate, int CallbackMask, bool bStopWhenAttachedObjectDestroyed)
		{
			IntPtr nativePtr = base.NativePtr;
			IntPtr actor = (Actor != null) ? Actor.NativePtr : IntPtr.Zero;
			FOnAkPostEventCallback fonAkPostEventCallback = Delegate;
			return UAkAudioEvent.__PostOnActor_Internal(nativePtr, actor, (fonAkPostEventCallback != null) ? fonAkPostEventCallback.NativePtr : ((IntPtr)0), CallbackMask, bStopWhenAttachedObjectDestroyed);
		}

		// Token: 0x06001D3D RID: 7485 RVA: 0x0002B9B0 File Offset: 0x00029BB0
		public int PostAtLocation(FVector Location, FRotator Orientation, in FOnAkPostEventCallback Callback, int CallbackMask, UObject WorldContextObject)
		{
			IntPtr nativePtr = base.NativePtr;
			FOnAkPostEventCallback fonAkPostEventCallback = Callback;
			return UAkAudioEvent.__PostAtLocation_Internal(nativePtr, Location, Orientation, (fonAkPostEventCallback != null) ? fonAkPostEventCallback.NativePtr : ((IntPtr)0), CallbackMask, (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06001D3E RID: 7486 RVA: 0x0002B9E2 File Offset: 0x00029BE2
		public int ExecuteAction(EAkActionOnEventType ActionType, AActor Actor, int PlayingID = 0, int TransitionDuration = 0, EAkCurveInterpolation FadeCurve = EAkCurveInterpolation.Linear)
		{
			return UAkAudioEvent.__ExecuteAction_Internal(base.NativePtr, ActionType, (Actor != null) ? Actor.NativePtr : IntPtr.Zero, PlayingID, TransitionDuration, FadeCurve);
		}

		// Token: 0x06001D3F RID: 7487 RVA: 0x0002BA05 File Offset: 0x00029C05
		public int D_PostAtLocation(FVectorDouble Location, FRotator Orientation, in FOnAkPostEventCallback Callback, int CallbackMask, UObject WorldContextObject)
		{
			IntPtr nativePtr = base.NativePtr;
			FOnAkPostEventCallback fonAkPostEventCallback = Callback;
			return UAkAudioEvent.__D_PostAtLocation_Internal(nativePtr, Location, Orientation, (fonAkPostEventCallback != null) ? fonAkPostEventCallback.NativePtr : ((IntPtr)0), CallbackMask, (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06001D40 RID: 7488
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __PostOnGameObjectAndWait_Internal(IntPtr @this, IntPtr GameObject, IntPtr LatentActionInfo);

		// Token: 0x06001D41 RID: 7489
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __PostOnGameObject_Internal(IntPtr @this, IntPtr GameObject, IntPtr Delegate, int CallbackMask);

		// Token: 0x06001D42 RID: 7490
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __PostOnComponentAndWait_Internal(IntPtr @this, IntPtr Component, bool bStopWhenAttachedObjectDestroyed, IntPtr LatentActionInfo);

		// Token: 0x06001D43 RID: 7491
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __PostOnComponent_Internal(IntPtr @this, IntPtr Component, IntPtr Delegate, int CallbackMask, bool bStopWhenAttachedObjectDestroyed);

		// Token: 0x06001D44 RID: 7492
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __PostOnActorAndWait_Internal(IntPtr @this, IntPtr Actor, bool bStopWhenAttachedObjectDestroyed, IntPtr LatentActionInfo);

		// Token: 0x06001D45 RID: 7493
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __PostOnActor_Internal(IntPtr @this, IntPtr Actor, IntPtr Delegate, int CallbackMask, bool bStopWhenAttachedObjectDestroyed);

		// Token: 0x06001D46 RID: 7494
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __PostAtLocation_Internal(IntPtr @this, FVector Location, FRotator Orientation, IntPtr Callback, int CallbackMask, IntPtr WorldContextObject);

		// Token: 0x06001D47 RID: 7495
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __ExecuteAction_Internal(IntPtr @this, EAkActionOnEventType ActionType, IntPtr Actor, int PlayingID, int TransitionDuration, EAkCurveInterpolation FadeCurve);

		// Token: 0x06001D48 RID: 7496
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __D_PostAtLocation_Internal(IntPtr @this, FVectorDouble Location, FRotator Orientation, IntPtr Callback, int CallbackMask, IntPtr WorldContextObject);

		// Token: 0x06001D49 RID: 7497 RVA: 0x0002BA37 File Offset: 0x00029C37
		static UAkAudioEvent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AkAudio.AkAudioEvent");
		}

		// Token: 0x06001D4A RID: 7498 RVA: 0x0002BA45 File Offset: 0x00029C45
		protected UAkAudioEvent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400099A RID: 2458
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AkAudio.AkAudioEvent";

		// Token: 0x0400099B RID: 2459
		private static IntPtr _ClassPtr;

		// Token: 0x0400099C RID: 2460
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400099D RID: 2461
		internal static int __PropertyOffset_MaxAttenuationRadius;

		// Token: 0x0400099E RID: 2462
		internal static int __PropertyOffset_IsInfinite;

		// Token: 0x0400099F RID: 2463
		internal static int __PropertyOffset_MinimumDuration;

		// Token: 0x040009A0 RID: 2464
		internal static int __PropertyOffset_MaximumDuration;

		// Token: 0x040009A1 RID: 2465
		internal static int __PropertyOffset_EventCookedData;

		// Token: 0x040009A2 RID: 2466
		private FWwiseLocalizedEventCookedData _EventCookedData;

		// Token: 0x040009A3 RID: 2467
		internal static int __PropertyOffset_RequiredBank_DEPRECATED;
	}
}
