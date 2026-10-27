using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200190C RID: 6412
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGameplay.KuroSequenceRuntimeFunctionLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroSequenceRuntimeFunctionLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06017C9C RID: 97436 RVA: 0x0022D942 File Offset: 0x0022BB42
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroSequenceRuntimeFunctionLibrary._ClassPtr;
		}

		// Token: 0x06017C9D RID: 97437 RVA: 0x0022D950 File Offset: 0x0022BB50
		public UKuroSequenceRuntimeFunctionLibrary() : this(BuiltinUtils.AllocNativeUObject(UKuroSequenceRuntimeFunctionLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06017C9E RID: 97438 RVA: 0x0022D978 File Offset: 0x0022BB78
		[NullableContext(1)]
		public UKuroSequenceRuntimeFunctionLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroSequenceRuntimeFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06017C9F RID: 97439 RVA: 0x0022D9AB File Offset: 0x0022BBAB
		public static bool StopEasingPlayRate(ALevelSequenceActor SequenceActor, int HandleId, bool JumpToTarget = false)
		{
			return UKuroSequenceRuntimeFunctionLibrary.__StopEasingPlayRate_Internal((SequenceActor != null) ? SequenceActor.NativePtr : IntPtr.Zero, HandleId, JumpToTarget);
		}

		// Token: 0x06017CA0 RID: 97440 RVA: 0x0022D9C4 File Offset: 0x0022BBC4
		public static bool SetSequenceInUiScene(UMovieSceneSequence Sequence, bool IsEnable)
		{
			return UKuroSequenceRuntimeFunctionLibrary.__SetSequenceInUiScene_Internal((Sequence != null) ? Sequence.NativePtr : IntPtr.Zero, IsEnable);
		}

		// Token: 0x06017CA1 RID: 97441 RVA: 0x0022D9DC File Offset: 0x0022BBDC
		public static void SetBindings(ALevelSequenceActor SequenceActor, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FMovieSceneObjectBindingID> Bindings, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<AActor> Actors, bool bAllowBindingsFromAsset = false)
		{
			UKuroSequenceRuntimeFunctionLibrary.__SetBindings_Internal((SequenceActor != null) ? SequenceActor.NativePtr : IntPtr.Zero, (Bindings ?? new TArray<FMovieSceneObjectBindingID>()).NativePtr, (Actors ?? new TArray<AActor>()).NativePtr, bAllowBindingsFromAsset);
		}

		// Token: 0x06017CA2 RID: 97442 RVA: 0x0022DA14 File Offset: 0x0022BC14
		public static bool SectionContains(UMovieSceneSection Section, FFrameTime Frame)
		{
			return UKuroSequenceRuntimeFunctionLibrary.__SectionContains_Internal((Section != null) ? Section.NativePtr : IntPtr.Zero, (Frame ?? new FFrameTime()).NativePtr);
		}

		// Token: 0x06017CA3 RID: 97443 RVA: 0x0022DA3A File Offset: 0x0022BC3A
		public static void SearchAttachAndReattach(UMovieSceneSequence Sequence, TArray<FName> InBindingNames, FName Tag)
		{
			UKuroSequenceRuntimeFunctionLibrary.__SearchAttachAndReattach_Internal((Sequence != null) ? Sequence.NativePtr : IntPtr.Zero, (InBindingNames ?? new TArray<FName>()).NativePtr, Tag);
		}

		// Token: 0x06017CA4 RID: 97444 RVA: 0x0022DA61 File Offset: 0x0022BC61
		public static void ResetMovieSceneCompiledData(UMovieSceneSequence Sequence)
		{
			UKuroSequenceRuntimeFunctionLibrary.__ResetMovieSceneCompiledData_Internal((Sequence != null) ? Sequence.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06017CA5 RID: 97445 RVA: 0x0022DA78 File Offset: 0x0022BC78
		public static UKuroActorStreamingHandle RequestActorExternalStreaming(UObject WorldContextObject, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FSoftObjectPath> ActorRefs)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroActorStreamingHandle>(UKuroSequenceRuntimeFunctionLibrary.__RequestActorExternalStreaming_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (ActorRefs ?? new TArray<FSoftObjectPath>()).NativePtr));
		}

		// Token: 0x06017CA6 RID: 97446 RVA: 0x0022DAA4 File Offset: 0x0022BCA4
		public static void MuteTrackByTag(UMovieSceneSequence Sequence, FName Tag, bool bIsMuted = true)
		{
			UKuroSequenceRuntimeFunctionLibrary.__MuteTrackByTag_Internal((Sequence != null) ? Sequence.NativePtr : IntPtr.Zero, Tag, bIsMuted);
		}

		// Token: 0x06017CA7 RID: 97447 RVA: 0x0022DABD File Offset: 0x0022BCBD
		public static void MuteTrackByName(UMovieSceneSequence Sequence, FName Name, bool bIsMuted = true)
		{
			UKuroSequenceRuntimeFunctionLibrary.__MuteTrackByName_Internal((Sequence != null) ? Sequence.NativePtr : IntPtr.Zero, Name, bIsMuted);
		}

		// Token: 0x06017CA8 RID: 97448 RVA: 0x0022DAD6 File Offset: 0x0022BCD6
		public static bool HandleSeqTexStreaming(ULevelSequence LevelSequences, bool bStartForceStreamIn, bool bCollectExtraTexture = false)
		{
			return UKuroSequenceRuntimeFunctionLibrary.__HandleSeqTexStreaming_Internal((LevelSequences != null) ? LevelSequences.NativePtr : IntPtr.Zero, bStartForceStreamIn, bCollectExtraTexture);
		}

		// Token: 0x06017CA9 RID: 97449 RVA: 0x0022DAEF File Offset: 0x0022BCEF
		[NullableContext(1)]
		public static TArray<UMovieSceneTrack> GetTracks([Nullable(2)] in FSequencerBindingRuntimeProxy InBinding)
		{
			return new TArray<UMovieSceneTrack>(UKuroSequenceRuntimeFunctionLibrary.__GetTracks_Internal((InBinding ?? new FSequencerBindingRuntimeProxy()).NativePtr), null);
		}

		// Token: 0x06017CAA RID: 97450 RVA: 0x0022DB0C File Offset: 0x0022BD0C
		public static int GetStartFrame(UMovieSceneSection Section)
		{
			return UKuroSequenceRuntimeFunctionLibrary.__GetStartFrame_Internal((Section != null) ? Section.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06017CAB RID: 97451 RVA: 0x0022DB23 File Offset: 0x0022BD23
		[NullableContext(1)]
		public static TArray<FSequencerBindingRuntimeProxy> GetSpawnables([Nullable(2)] UMovieSceneSequence Sequence)
		{
			return new TArray<FSequencerBindingRuntimeProxy>(UKuroSequenceRuntimeFunctionLibrary.__GetSpawnables_Internal((Sequence != null) ? Sequence.NativePtr : IntPtr.Zero), null);
		}

		// Token: 0x06017CAC RID: 97452 RVA: 0x0022DB40 File Offset: 0x0022BD40
		[NullableContext(1)]
		public static TArray<UMovieSceneSection> GetSections([Nullable(2)] UMovieSceneTrack Track)
		{
			return new TArray<UMovieSceneSection>(UKuroSequenceRuntimeFunctionLibrary.__GetSections_Internal((Track != null) ? Track.NativePtr : IntPtr.Zero), null);
		}

		// Token: 0x06017CAD RID: 97453 RVA: 0x0022DB5D File Offset: 0x0022BD5D
		public static int GetPlaybackStart(UMovieSceneSequence Sequence)
		{
			return UKuroSequenceRuntimeFunctionLibrary.__GetPlaybackStart_Internal((Sequence != null) ? Sequence.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06017CAE RID: 97454 RVA: 0x0022DB74 File Offset: 0x0022BD74
		public static int GetPlaybackEnd(UMovieSceneSequence Sequence)
		{
			return UKuroSequenceRuntimeFunctionLibrary.__GetPlaybackEnd_Internal((Sequence != null) ? Sequence.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06017CAF RID: 97455 RVA: 0x0022DB8B File Offset: 0x0022BD8B
		public static UObject GetObjectTemplate(in FSequencerBindingRuntimeProxy InBinding)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(UKuroSequenceRuntimeFunctionLibrary.__GetObjectTemplate_Internal((InBinding ?? new FSequencerBindingRuntimeProxy()).NativePtr));
		}

		// Token: 0x06017CB0 RID: 97456 RVA: 0x0022DBA7 File Offset: 0x0022BDA7
		[NullableContext(1)]
		public static TArray<UMovieSceneTrack> GetMasterTracks([Nullable(2)] UMovieSceneSequence Sequence)
		{
			return new TArray<UMovieSceneTrack>(UKuroSequenceRuntimeFunctionLibrary.__GetMasterTracks_Internal((Sequence != null) ? Sequence.NativePtr : IntPtr.Zero), null);
		}

		// Token: 0x06017CB1 RID: 97457 RVA: 0x0022DBC4 File Offset: 0x0022BDC4
		public unsafe static bool GetFrameTransformByTag(UMovieSceneSequence Sequence, FName Tag, int OutsideFrame, ref FTransform OutTransfom)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = OutTransfom;
			bool result = UKuroSequenceRuntimeFunctionLibrary.__GetFrameTransformByTag_Internal((Sequence != null) ? Sequence.NativePtr : IntPtr.Zero, Tag, OutsideFrame, ref ptr);
			OutTransfom = ptr;
			return result;
		}

		// Token: 0x06017CB2 RID: 97458 RVA: 0x0022DC11 File Offset: 0x0022BE11
		public static FTransform GetFrameTransform(UMovieSceneTrack Track, FFrameTime Frame)
		{
			return UKuroSequenceRuntimeFunctionLibrary.__GetFrameTransform_Internal((Track != null) ? Track.NativePtr : IntPtr.Zero, (Frame ?? new FFrameTime()).NativePtr);
		}

		// Token: 0x06017CB3 RID: 97459 RVA: 0x0022DC37 File Offset: 0x0022BE37
		public static float GetFadeAmountAt(UMovieSceneFadeSection Section, FFrameTime Frame)
		{
			return UKuroSequenceRuntimeFunctionLibrary.__GetFadeAmountAt_Internal((Section != null) ? Section.NativePtr : IntPtr.Zero, (Frame ?? new FFrameTime()).NativePtr);
		}

		// Token: 0x06017CB4 RID: 97460 RVA: 0x0022DC5D File Offset: 0x0022BE5D
		public static int GetEndFrame(UMovieSceneSection Section)
		{
			return UKuroSequenceRuntimeFunctionLibrary.__GetEndFrame_Internal((Section != null) ? Section.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06017CB5 RID: 97461 RVA: 0x0022DC74 File Offset: 0x0022BE74
		[NullableContext(1)]
		public static TArray<UMovieSceneTrack> FindTracksByType([Nullable(2)] in FSequencerBindingRuntimeProxy InBinding, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UMovieSceneTrack> TrackType)
		{
			return new TArray<UMovieSceneTrack>(UKuroSequenceRuntimeFunctionLibrary.__FindTracksByType_Internal((InBinding ?? new FSequencerBindingRuntimeProxy()).NativePtr, TrackType._NativePtr), null);
		}

		// Token: 0x06017CB6 RID: 97462 RVA: 0x0022DC97 File Offset: 0x0022BE97
		[return: Nullable(1)]
		public static TArray<FMovieSceneObjectBindingID> FindMatchAllTagsBinding(in TArray<FName> Tags, ULevelSequence LevelSequence)
		{
			return new TArray<FMovieSceneObjectBindingID>(UKuroSequenceRuntimeFunctionLibrary.__FindMatchAllTagsBinding_Internal((Tags ?? new TArray<FName>()).NativePtr, (LevelSequence != null) ? LevelSequence.NativePtr : IntPtr.Zero), null);
		}

		// Token: 0x06017CB7 RID: 97463 RVA: 0x0022DCC4 File Offset: 0x0022BEC4
		[NullableContext(1)]
		public static TArray<UMovieSceneTrack> FindMasterTracksByType([Nullable(2)] UMovieSceneSequence Sequence, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UMovieSceneTrack> TrackType)
		{
			return new TArray<UMovieSceneTrack>(UKuroSequenceRuntimeFunctionLibrary.__FindMasterTracksByType_Internal((Sequence != null) ? Sequence.NativePtr : IntPtr.Zero, TrackType._NativePtr), null);
		}

		// Token: 0x06017CB8 RID: 97464 RVA: 0x0022DCE7 File Offset: 0x0022BEE7
		[NullableContext(1)]
		public static FSequencerBindingRuntimeProxy FindBindingById([Nullable(2)] UMovieSceneSequence Sequence, FGuid BindingId)
		{
			return new FSequencerBindingRuntimeProxy(UKuroSequenceRuntimeFunctionLibrary.__FindBindingById_Internal((Sequence != null) ? Sequence.NativePtr : IntPtr.Zero, BindingId), null);
		}

		// Token: 0x06017CB9 RID: 97465 RVA: 0x0022DD05 File Offset: 0x0022BF05
		public static int EasePlayRateTo(ALevelSequenceActor SequenceActor, float TargetPlayRate, EKuroEasingFuncType EaseType, float Duration, float Exp)
		{
			return UKuroSequenceRuntimeFunctionLibrary.__EasePlayRateTo_Internal((SequenceActor != null) ? SequenceActor.NativePtr : IntPtr.Zero, TargetPlayRate, EaseType, Duration, Exp);
		}

		// Token: 0x06017CBA RID: 97466
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __StopEasingPlayRate_Internal(IntPtr SequenceActor, int HandleId, bool JumpToTarget);

		// Token: 0x06017CBB RID: 97467
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SetSequenceInUiScene_Internal(IntPtr Sequence, bool IsEnable);

		// Token: 0x06017CBC RID: 97468
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBindings_Internal(IntPtr SequenceActor, IntPtr Bindings, IntPtr Actors, bool bAllowBindingsFromAsset);

		// Token: 0x06017CBD RID: 97469
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SectionContains_Internal(IntPtr Section, IntPtr Frame);

		// Token: 0x06017CBE RID: 97470
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SearchAttachAndReattach_Internal(IntPtr Sequence, IntPtr InBindingNames, FName Tag);

		// Token: 0x06017CBF RID: 97471
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResetMovieSceneCompiledData_Internal(IntPtr Sequence);

		// Token: 0x06017CC0 RID: 97472
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __RequestActorExternalStreaming_Internal(IntPtr WorldContextObject, IntPtr ActorRefs);

		// Token: 0x06017CC1 RID: 97473
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __MuteTrackByTag_Internal(IntPtr Sequence, FName Tag, bool bIsMuted);

		// Token: 0x06017CC2 RID: 97474
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __MuteTrackByName_Internal(IntPtr Sequence, FName Name, bool bIsMuted);

		// Token: 0x06017CC3 RID: 97475
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __HandleSeqTexStreaming_Internal(IntPtr LevelSequences, bool bStartForceStreamIn, bool bCollectExtraTexture);

		// Token: 0x06017CC4 RID: 97476
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetTracks_Internal(IntPtr InBinding);

		// Token: 0x06017CC5 RID: 97477
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetStartFrame_Internal(IntPtr Section);

		// Token: 0x06017CC6 RID: 97478
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetSpawnables_Internal(IntPtr Sequence);

		// Token: 0x06017CC7 RID: 97479
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetSections_Internal(IntPtr Track);

		// Token: 0x06017CC8 RID: 97480
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetPlaybackStart_Internal(IntPtr Sequence);

		// Token: 0x06017CC9 RID: 97481
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetPlaybackEnd_Internal(IntPtr Sequence);

		// Token: 0x06017CCA RID: 97482
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetObjectTemplate_Internal(IntPtr InBinding);

		// Token: 0x06017CCB RID: 97483
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetMasterTracks_Internal(IntPtr Sequence);

		// Token: 0x06017CCC RID: 97484
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetFrameTransformByTag_Internal(IntPtr Sequence, FName Tag, int OutsideFrame, ref FTransform OutTransfom);

		// Token: 0x06017CCD RID: 97485
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransform __GetFrameTransform_Internal(IntPtr Track, IntPtr Frame);

		// Token: 0x06017CCE RID: 97486
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetFadeAmountAt_Internal(IntPtr Section, IntPtr Frame);

		// Token: 0x06017CCF RID: 97487
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetEndFrame_Internal(IntPtr Section);

		// Token: 0x06017CD0 RID: 97488
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __FindTracksByType_Internal(IntPtr InBinding, IntPtr TrackType);

		// Token: 0x06017CD1 RID: 97489
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __FindMatchAllTagsBinding_Internal(IntPtr Tags, IntPtr LevelSequence);

		// Token: 0x06017CD2 RID: 97490
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __FindMasterTracksByType_Internal(IntPtr Sequence, IntPtr TrackType);

		// Token: 0x06017CD3 RID: 97491
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __FindBindingById_Internal(IntPtr Sequence, FGuid BindingId);

		// Token: 0x06017CD4 RID: 97492
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __EasePlayRateTo_Internal(IntPtr SequenceActor, float TargetPlayRate, EKuroEasingFuncType EaseType, float Duration, float Exp);

		// Token: 0x06017CD5 RID: 97493 RVA: 0x0022DD21 File Offset: 0x0022BF21
		static UKuroSequenceRuntimeFunctionLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplay.KuroSequenceRuntimeFunctionLibrary");
		}

		// Token: 0x06017CD6 RID: 97494 RVA: 0x0022DD2F File Offset: 0x0022BF2F
		protected UKuroSequenceRuntimeFunctionLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400CE6E RID: 52846
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroGameplay.KuroSequenceRuntimeFunctionLibrary";

		// Token: 0x0400CE6F RID: 52847
		private static IntPtr _ClassPtr;

		// Token: 0x0400CE70 RID: 52848
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
