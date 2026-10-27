using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200169C RID: 5788
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroAudio.KuroAudioStatics")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroAudioStatics : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06014FC1 RID: 85953 RVA: 0x001ED7D5 File Offset: 0x001EB9D5
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroAudioStatics._ClassPtr;
		}

		// Token: 0x06014FC2 RID: 85954 RVA: 0x001ED7E4 File Offset: 0x001EB9E4
		public UKuroAudioStatics() : this(BuiltinUtils.AllocNativeUObject(UKuroAudioStatics.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06014FC3 RID: 85955 RVA: 0x001ED80C File Offset: 0x001EBA0C
		public UKuroAudioStatics(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroAudioStatics.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06014FC4 RID: 85956 RVA: 0x001ED83F File Offset: 0x001EBA3F
		[NullableContext(2)]
		public static void StopAll(AActor Actor)
		{
			UKuroAudioStatics.__StopAll_Internal((Actor != null) ? Actor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06014FC5 RID: 85957 RVA: 0x001ED858 File Offset: 0x001EBA58
		public unsafe static void SetSwitch(string SwitchGroup, string SwitchState, [Nullable(2)] AActor Actor)
		{
			FString fstring = FString.AllocTemp(SwitchGroup);
			FString fstring2 = FString.AllocTemp(SwitchState);
			UKuroAudioStatics.__SetSwitch_Internal(fstring, fstring2, (Actor != null) ? Actor.NativePtr : IntPtr.Zero);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
		}

		// Token: 0x06014FC6 RID: 85958 RVA: 0x001ED8A0 File Offset: 0x001EBAA0
		public unsafe static void SetState(string StateGroup, string State)
		{
			FString fstring = FString.AllocTemp(StateGroup);
			FString fstring2 = FString.AllocTemp(State);
			UKuroAudioStatics.__SetState_Internal(fstring, fstring2);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
		}

		// Token: 0x06014FC7 RID: 85959 RVA: 0x001ED8D8 File Offset: 0x001EBAD8
		public unsafe static void SetRtpcValue(string RtpcName, float Value, [Nullable(2)] AActor Actor = null, int TransitionDuration = 0, EAudioFadeCurve TransitionFadeCurve = EAudioFadeCurve.Linear)
		{
			FString fstring = FString.AllocTemp(RtpcName);
			UKuroAudioStatics.__SetRtpcValue_Internal(fstring, Value, (Actor != null) ? Actor.NativePtr : IntPtr.Zero, TransitionDuration, TransitionFadeCurve);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06014FC8 RID: 85960
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetIosAuditPackage(bool IsAuditPackage);

		// Token: 0x06014FC9 RID: 85961 RVA: 0x001ED910 File Offset: 0x001EBB10
		public unsafe static void SeekOnEventName(string EventName, int Position, [Nullable(2)] AActor Actor = null, int PlayingId = 0, bool bSnapToMarker = false)
		{
			FString fstring = FString.AllocTemp(EventName);
			UKuroAudioStatics.__SeekOnEventName_Internal(fstring, Position, (Actor != null) ? Actor.NativePtr : IntPtr.Zero, PlayingId, bSnapToMarker);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06014FCA RID: 85962 RVA: 0x001ED948 File Offset: 0x001EBB48
		[NullableContext(2)]
		public static void PostNotifyEvent(UAkAudioEvent NotifyEvent, AActor Actor)
		{
			UKuroAudioStatics.__PostNotifyEvent_Internal((NotifyEvent != null) ? NotifyEvent.NativePtr : IntPtr.Zero, (Actor != null) ? Actor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06014FCB RID: 85963 RVA: 0x001ED96F File Offset: 0x001EBB6F
		[NullableContext(2)]
		public static void PostEventWithMidiNote(UAkAudioEvent AudioEvent, byte Note, AActor Actor = null)
		{
			UKuroAudioStatics.__PostEventWithMidiNote_Internal((AudioEvent != null) ? AudioEvent.NativePtr : IntPtr.Zero, Note, (Actor != null) ? Actor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06014FCC RID: 85964
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsDolbyAtmosGameSupported();

		// Token: 0x06014FCD RID: 85965
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsAndroidApiUsingOpenSL();

		// Token: 0x06014FCE RID: 85966
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetSourcePlayPosition(int PlayingId, bool bExtrapolate = false);

		// Token: 0x06014FCF RID: 85967 RVA: 0x001ED997 File Offset: 0x001EBB97
		[NullableContext(2)]
		public static UKuroAudioEnvironmentSubsystem GetAudioEnvironmentSubsystem(UWorld World)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroAudioEnvironmentSubsystem>(UKuroAudioStatics.__GetAudioEnvironmentSubsystem_Internal((World != null) ? World.NativePtr : IntPtr.Zero));
		}

		// Token: 0x06014FD0 RID: 85968 RVA: 0x001ED9B4 File Offset: 0x001EBBB4
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

		// Token: 0x06014FD1 RID: 85969
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void ExecuteActionOnPlayingId(int PlayingId, EAudioActionType ActionType, int TransitionDuration = 500, EAudioFadeCurve TransitionFadeCurve = EAudioFadeCurve.Linear);

		// Token: 0x06014FD2 RID: 85970 RVA: 0x001ED9E8 File Offset: 0x001EBBE8
		public unsafe static void ExecuteActionOnEventName(string EventName, EAudioActionType ActionType, [Nullable(2)] AActor Actor = null, int TransitionDuration = 500, EAudioFadeCurve TransitionFadeCurve = EAudioFadeCurve.Linear)
		{
			FString fstring = FString.AllocTemp(EventName);
			UKuroAudioStatics.__ExecuteActionOnEventName_Internal(fstring, ActionType, (Actor != null) ? Actor.NativePtr : IntPtr.Zero, TransitionDuration, TransitionFadeCurve);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06014FD3 RID: 85971 RVA: 0x001EDA20 File Offset: 0x001EBC20
		[NullableContext(2)]
		public static void ExecuteActionOnEvent(UAkAudioEvent AudioEvent, EAudioActionType ActionType, AActor Actor = null, int TransitionDuration = 500, EAudioFadeCurve TransitionFadeCurve = EAudioFadeCurve.Linear)
		{
			UKuroAudioStatics.__ExecuteActionOnEvent_Internal((AudioEvent != null) ? AudioEvent.NativePtr : IntPtr.Zero, ActionType, (Actor != null) ? Actor.NativePtr : IntPtr.Zero, TransitionDuration, TransitionFadeCurve);
		}

		// Token: 0x06014FD4 RID: 85972
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void ChangeIosAudioSessionProperties();

		// Token: 0x06014FD5 RID: 85973
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StopAll_Internal(IntPtr Actor);

		// Token: 0x06014FD6 RID: 85974
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSwitch_Internal(in FString SwitchGroup, in FString SwitchState, IntPtr Actor);

		// Token: 0x06014FD7 RID: 85975
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetState_Internal(in FString StateGroup, in FString State);

		// Token: 0x06014FD8 RID: 85976
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetRtpcValue_Internal(in FString RtpcName, float Value, IntPtr Actor, int TransitionDuration, EAudioFadeCurve TransitionFadeCurve);

		// Token: 0x06014FD9 RID: 85977
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SeekOnEventName_Internal(in FString EventName, int Position, IntPtr Actor, int PlayingId, bool bSnapToMarker);

		// Token: 0x06014FDA RID: 85978
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PostNotifyEvent_Internal(IntPtr NotifyEvent, IntPtr Actor);

		// Token: 0x06014FDB RID: 85979
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PostEventWithMidiNote_Internal(IntPtr AudioEvent, byte Note, IntPtr Actor);

		// Token: 0x06014FDC RID: 85980
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetAudioEnvironmentSubsystem_Internal(IntPtr World);

		// Token: 0x06014FDD RID: 85981
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetAkComponent_Internal(IntPtr Parent, in FName SocketName, ref bool bCreated);

		// Token: 0x06014FDE RID: 85982
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ExecuteActionOnEventName_Internal(in FString EventName, EAudioActionType ActionType, IntPtr Actor, int TransitionDuration, EAudioFadeCurve TransitionFadeCurve);

		// Token: 0x06014FDF RID: 85983
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ExecuteActionOnEvent_Internal(IntPtr AudioEvent, EAudioActionType ActionType, IntPtr Actor, int TransitionDuration, EAudioFadeCurve TransitionFadeCurve);

		// Token: 0x06014FE0 RID: 85984 RVA: 0x001EDA4B File Offset: 0x001EBC4B
		static UKuroAudioStatics()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroAudio.KuroAudioStatics");
		}

		// Token: 0x06014FE1 RID: 85985 RVA: 0x001EDA59 File Offset: 0x001EBC59
		protected UKuroAudioStatics(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400B6E3 RID: 46819
		public new const string __ObjectPath = "/Script/KuroAudio.KuroAudioStatics";

		// Token: 0x0400B6E4 RID: 46820
		private static IntPtr _ClassPtr;

		// Token: 0x0400B6E5 RID: 46821
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
