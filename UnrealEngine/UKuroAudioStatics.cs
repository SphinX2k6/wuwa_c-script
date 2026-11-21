using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000315 RID: 789
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroAudio.KuroAudioStatics")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroAudioStatics : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06005397 RID: 21399 RVA: 0x00074DF2 File Offset: 0x00072FF2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroAudioStatics._ClassPtr;
		}

		// Token: 0x06005398 RID: 21400 RVA: 0x00074E00 File Offset: 0x00073000
		public UKuroAudioStatics() : this(BuiltinUtils.AllocNativeUObject(UKuroAudioStatics.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06005399 RID: 21401 RVA: 0x00074E28 File Offset: 0x00073028
		public UKuroAudioStatics(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroAudioStatics.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600539A RID: 21402 RVA: 0x00074E5B File Offset: 0x0007305B
		[NullableContext(2)]
		public static void StopAll(AActor Actor)
		{
			UKuroAudioStatics.__StopAll_Internal((Actor != null) ? Actor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600539B RID: 21403 RVA: 0x00074E74 File Offset: 0x00073074
		public unsafe static void SetSwitch(string SwitchGroup, string SwitchState, [Nullable(2)] AActor Actor)
		{
			FString fstring = FString.AllocTemp(SwitchGroup);
			FString fstring2 = FString.AllocTemp(SwitchState);
			UKuroAudioStatics.__SetSwitch_Internal(fstring, fstring2, (Actor != null) ? Actor.NativePtr : IntPtr.Zero);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
		}

		// Token: 0x0600539C RID: 21404 RVA: 0x00074EBC File Offset: 0x000730BC
		public unsafe static void SetState(string StateGroup, string State)
		{
			FString fstring = FString.AllocTemp(StateGroup);
			FString fstring2 = FString.AllocTemp(State);
			UKuroAudioStatics.__SetState_Internal(fstring, fstring2);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
		}

		// Token: 0x0600539D RID: 21405 RVA: 0x00074EF4 File Offset: 0x000730F4
		public unsafe static void SetRtpcValue(string RtpcName, float Value, [Nullable(2)] AActor Actor = null, int TransitionDuration = 0, EAudioFadeCurve TransitionFadeCurve = EAudioFadeCurve.Linear)
		{
			FString fstring = FString.AllocTemp(RtpcName);
			UKuroAudioStatics.__SetRtpcValue_Internal(fstring, Value, (Actor != null) ? Actor.NativePtr : IntPtr.Zero, TransitionDuration, TransitionFadeCurve);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0600539E RID: 21406
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetIosAuditPackage(bool IsAuditPackage);

		// Token: 0x0600539F RID: 21407
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetDualSenseSpeakerRouteEnabled(bool bEnabled);

		// Token: 0x060053A0 RID: 21408 RVA: 0x00074F2C File Offset: 0x0007312C
		public unsafe static void SeekOnEventName(string EventName, int Position, [Nullable(2)] AActor Actor = null, int PlayingId = 0, bool bSnapToMarker = false)
		{
			FString fstring = FString.AllocTemp(EventName);
			UKuroAudioStatics.__SeekOnEventName_Internal(fstring, Position, (Actor != null) ? Actor.NativePtr : IntPtr.Zero, PlayingId, bSnapToMarker);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x060053A1 RID: 21409 RVA: 0x00074F64 File Offset: 0x00073164
		[NullableContext(2)]
		public static void PostNotifyEvent(UAkAudioEvent NotifyEvent, AActor Actor)
		{
			UKuroAudioStatics.__PostNotifyEvent_Internal((NotifyEvent != null) ? NotifyEvent.NativePtr : IntPtr.Zero, (Actor != null) ? Actor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060053A2 RID: 21410 RVA: 0x00074F8B File Offset: 0x0007318B
		[NullableContext(2)]
		public static void PostEventWithMidiNote(UAkAudioEvent AudioEvent, byte Note, AActor Actor = null)
		{
			UKuroAudioStatics.__PostEventWithMidiNote_Internal((AudioEvent != null) ? AudioEvent.NativePtr : IntPtr.Zero, Note, (Actor != null) ? Actor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060053A3 RID: 21411
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsDualSenseSpeakerRouteActive();

		// Token: 0x060053A4 RID: 21412
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsDolbyAtmosGameSupported();

		// Token: 0x060053A5 RID: 21413
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsAndroidApiUsingOpenSL();

		// Token: 0x060053A6 RID: 21414
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetSourcePlayPosition(int PlayingId, bool bExtrapolate = false);

		// Token: 0x060053A7 RID: 21415 RVA: 0x00074FB3 File Offset: 0x000731B3
		[NullableContext(2)]
		public static UKuroAudioEnvironmentSubsystem GetAudioEnvironmentSubsystem(UWorld World)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroAudioEnvironmentSubsystem>(UKuroAudioStatics.__GetAudioEnvironmentSubsystem_Internal((World != null) ? World.NativePtr : IntPtr.Zero));
		}

		// Token: 0x060053A8 RID: 21416 RVA: 0x00074FD0 File Offset: 0x000731D0
		[NullableContext(2)]
		public unsafe static UAkComponent GetAkComponent(USceneComponent Parent, in FName SocketName, ref bool bCreated)
		{
			fixed (FName* ptr = &SocketName)
			{
				void* ptr2 = (void*)ptr;
				fixed (bool* ptr3 = &bCreated)
				{
					void* ptr4 = (void*)ptr3;
					return BuiltinUtils.GetOrCreateUObjectByNativePointer<UAkComponent>(UKuroAudioStatics.__GetAkComponent_Internal((Parent != null) ? Parent.NativePtr : IntPtr.Zero, SocketName, ref bCreated));
				}
			}
		}

		// Token: 0x060053A9 RID: 21417
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void ExecuteActionOnPlayingId(int PlayingId, EAudioActionType ActionType, int TransitionDuration = 500, EAudioFadeCurve TransitionFadeCurve = EAudioFadeCurve.Linear);

		// Token: 0x060053AA RID: 21418 RVA: 0x00075004 File Offset: 0x00073204
		public unsafe static void ExecuteActionOnEventName(string EventName, EAudioActionType ActionType, [Nullable(2)] AActor Actor = null, int TransitionDuration = 500, EAudioFadeCurve TransitionFadeCurve = EAudioFadeCurve.Linear)
		{
			FString fstring = FString.AllocTemp(EventName);
			UKuroAudioStatics.__ExecuteActionOnEventName_Internal(fstring, ActionType, (Actor != null) ? Actor.NativePtr : IntPtr.Zero, TransitionDuration, TransitionFadeCurve);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x060053AB RID: 21419 RVA: 0x0007503C File Offset: 0x0007323C
		[NullableContext(2)]
		public static void ExecuteActionOnEvent(UAkAudioEvent AudioEvent, EAudioActionType ActionType, AActor Actor = null, int TransitionDuration = 500, EAudioFadeCurve TransitionFadeCurve = EAudioFadeCurve.Linear)
		{
			UKuroAudioStatics.__ExecuteActionOnEvent_Internal((AudioEvent != null) ? AudioEvent.NativePtr : IntPtr.Zero, ActionType, (Actor != null) ? Actor.NativePtr : IntPtr.Zero, TransitionDuration, TransitionFadeCurve);
		}

		// Token: 0x060053AC RID: 21420
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void ChangeIosAudioSessionProperties();

		// Token: 0x060053AD RID: 21421
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StopAll_Internal(IntPtr Actor);

		// Token: 0x060053AE RID: 21422
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSwitch_Internal(in FString SwitchGroup, in FString SwitchState, IntPtr Actor);

		// Token: 0x060053AF RID: 21423
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetState_Internal(in FString StateGroup, in FString State);

		// Token: 0x060053B0 RID: 21424
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetRtpcValue_Internal(in FString RtpcName, float Value, IntPtr Actor, int TransitionDuration, EAudioFadeCurve TransitionFadeCurve);

		// Token: 0x060053B1 RID: 21425
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SeekOnEventName_Internal(in FString EventName, int Position, IntPtr Actor, int PlayingId, bool bSnapToMarker);

		// Token: 0x060053B2 RID: 21426
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PostNotifyEvent_Internal(IntPtr NotifyEvent, IntPtr Actor);

		// Token: 0x060053B3 RID: 21427
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PostEventWithMidiNote_Internal(IntPtr AudioEvent, byte Note, IntPtr Actor);

		// Token: 0x060053B4 RID: 21428
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetAudioEnvironmentSubsystem_Internal(IntPtr World);

		// Token: 0x060053B5 RID: 21429
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetAkComponent_Internal(IntPtr Parent, in FName SocketName, ref bool bCreated);

		// Token: 0x060053B6 RID: 21430
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ExecuteActionOnEventName_Internal(in FString EventName, EAudioActionType ActionType, IntPtr Actor, int TransitionDuration, EAudioFadeCurve TransitionFadeCurve);

		// Token: 0x060053B7 RID: 21431
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ExecuteActionOnEvent_Internal(IntPtr AudioEvent, EAudioActionType ActionType, IntPtr Actor, int TransitionDuration, EAudioFadeCurve TransitionFadeCurve);

		// Token: 0x060053B8 RID: 21432 RVA: 0x00075067 File Offset: 0x00073267
		static UKuroAudioStatics()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroAudio.KuroAudioStatics");
		}

		// Token: 0x060053B9 RID: 21433 RVA: 0x00075075 File Offset: 0x00073275
		protected UKuroAudioStatics(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400222F RID: 8751
		public new const string __ObjectPath = "/Script/KuroAudio.KuroAudioStatics";

		// Token: 0x04002230 RID: 8752
		private static IntPtr _ClassPtr;

		// Token: 0x04002231 RID: 8753
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
