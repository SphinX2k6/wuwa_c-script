using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000401 RID: 1025
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGameplay.KuroSequenceRuntimeFunctionLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroSequenceRuntimeFunctionLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600646A RID: 25706 RVA: 0x0008F738 File Offset: 0x0008D938
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroSequenceRuntimeFunctionLibrary._ClassPtr;
		}

		// Token: 0x0600646B RID: 25707 RVA: 0x0008F744 File Offset: 0x0008D944
		public UKuroSequenceRuntimeFunctionLibrary() : this(BuiltinUtils.AllocNativeUObject(UKuroSequenceRuntimeFunctionLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600646C RID: 25708 RVA: 0x0008F76C File Offset: 0x0008D96C
		[NullableContext(1)]
		public UKuroSequenceRuntimeFunctionLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroSequenceRuntimeFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600646D RID: 25709 RVA: 0x0008F79F File Offset: 0x0008D99F
		public static bool StopEasingPlayRate(ALevelSequenceActor SequenceActor, int HandleId, bool JumpToTarget = false)
		{
			return UKuroSequenceRuntimeFunctionLibrary.__StopEasingPlayRate_Internal((SequenceActor != null) ? SequenceActor.NativePtr : IntPtr.Zero, HandleId, JumpToTarget);
		}

		// Token: 0x0600646E RID: 25710 RVA: 0x0008F7B8 File Offset: 0x0008D9B8
		public static bool SetSequenceInUiScene(UMovieSceneSequence Sequence, bool IsEnable)
		{
			return UKuroSequenceRuntimeFunctionLibrary.__SetSequenceInUiScene_Internal((Sequence != null) ? Sequence.NativePtr : IntPtr.Zero, IsEnable);
		}

		// Token: 0x0600646F RID: 25711 RVA: 0x0008F7D0 File Offset: 0x0008D9D0
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

		// Token: 0x06006470 RID: 25712 RVA: 0x0008F808 File Offset: 0x0008DA08
		public static bool SectionContains(UMovieSceneSection Section, FFrameTime Frame)
		{
			return UKuroSequenceRuntimeFunctionLibrary.__SectionContains_Internal((Section != null) ? Section.NativePtr : IntPtr.Zero, (Frame ?? new FFrameTime()).NativePtr);
		}

		// Token: 0x06006471 RID: 25713 RVA: 0x0008F82E File Offset: 0x0008DA2E
		public static void SearchAttachAndReattach(UMovieSceneSequence Sequence, TArray<FName> InBindingNames, FName Tag)
		{
			UKuroSequenceRuntimeFunctionLibrary.__SearchAttachAndReattach_Internal((Sequence != null) ? Sequence.NativePtr : IntPtr.Zero, (InBindingNames ?? new TArray<FName>()).NativePtr, Tag);
		}

		// Token: 0x06006472 RID: 25714 RVA: 0x0008F855 File Offset: 0x0008DA55
		public static void ResetMovieSceneCompiledData(UMovieSceneSequence Sequence)
		{
			UKuroSequenceRuntimeFunctionLibrary.__ResetMovieSceneCompiledData_Internal((Sequence != null) ? Sequence.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06006473 RID: 25715 RVA: 0x0008F86C File Offset: 0x0008DA6C
		public static UKuroActorStreamingHandle RequestActorExternalStreaming(UObject WorldContextObject, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FSoftObjectPath> ActorRefs)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroActorStreamingHandle>(UKuroSequenceRuntimeFunctionLibrary.__RequestActorExternalStreaming_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (ActorRefs ?? new TArray<FSoftObjectPath>()).NativePtr));
		}

		// Token: 0x06006474 RID: 25716 RVA: 0x0008F898 File Offset: 0x0008DA98
		public static void MuteTrackByTag(UMovieSceneSequence Sequence, FName Tag, bool bIsMuted = true)
		{
			UKuroSequenceRuntimeFunctionLibrary.__MuteTrackByTag_Internal((Sequence != null) ? Sequence.NativePtr : IntPtr.Zero, Tag, bIsMuted);
		}

		// Token: 0x06006475 RID: 25717 RVA: 0x0008F8B1 File Offset: 0x0008DAB1
		public static void MuteTrackByName(UMovieSceneSequence Sequence, FName Name, bool bIsMuted = true)
		{
			UKuroSequenceRuntimeFunctionLibrary.__MuteTrackByName_Internal((Sequence != null) ? Sequence.NativePtr : IntPtr.Zero, Name, bIsMuted);
		}

		// Token: 0x06006476 RID: 25718 RVA: 0x0008F8CA File Offset: 0x0008DACA
		public static bool HandleSeqTexStreaming(ULevelSequence LevelSequences, bool bStartForceStreamIn, bool bCollectExtraTexture = false)
		{
			return UKuroSequenceRuntimeFunctionLibrary.__HandleSeqTexStreaming_Internal((LevelSequences != null) ? LevelSequences.NativePtr : IntPtr.Zero, bStartForceStreamIn, bCollectExtraTexture);
		}

		// Token: 0x06006477 RID: 25719 RVA: 0x0008F8E3 File Offset: 0x0008DAE3
		[NullableContext(1)]
		public static TArray<UMovieSceneTrack> GetTracks([Nullable(2)] in FSequencerBindingRuntimeProxy InBinding)
		{
			return new TArray<UMovieSceneTrack>(UKuroSequenceRuntimeFunctionLibrary.__GetTracks_Internal((InBinding ?? new FSequencerBindingRuntimeProxy()).NativePtr), null);
		}

		// Token: 0x06006478 RID: 25720 RVA: 0x0008F900 File Offset: 0x0008DB00
		public static int GetStartFrame(UMovieSceneSection Section)
		{
			return UKuroSequenceRuntimeFunctionLibrary.__GetStartFrame_Internal((Section != null) ? Section.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06006479 RID: 25721 RVA: 0x0008F917 File Offset: 0x0008DB17
		[NullableContext(1)]
		public static TArray<FSequencerBindingRuntimeProxy> GetSpawnables([Nullable(2)] UMovieSceneSequence Sequence)
		{
			return new TArray<FSequencerBindingRuntimeProxy>(UKuroSequenceRuntimeFunctionLibrary.__GetSpawnables_Internal((Sequence != null) ? Sequence.NativePtr : IntPtr.Zero), null);
		}

		// Token: 0x0600647A RID: 25722 RVA: 0x0008F934 File Offset: 0x0008DB34
		[NullableContext(1)]
		public static TArray<UMovieSceneSection> GetSections([Nullable(2)] UMovieSceneTrack Track)
		{
			return new TArray<UMovieSceneSection>(UKuroSequenceRuntimeFunctionLibrary.__GetSections_Internal((Track != null) ? Track.NativePtr : IntPtr.Zero), null);
		}

		// Token: 0x0600647B RID: 25723 RVA: 0x0008F951 File Offset: 0x0008DB51
		public static int GetPlaybackStart(UMovieSceneSequence Sequence)
		{
			return UKuroSequenceRuntimeFunctionLibrary.__GetPlaybackStart_Internal((Sequence != null) ? Sequence.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600647C RID: 25724 RVA: 0x0008F968 File Offset: 0x0008DB68
		public static int GetPlaybackEnd(UMovieSceneSequence Sequence)
		{
			return UKuroSequenceRuntimeFunctionLibrary.__GetPlaybackEnd_Internal((Sequence != null) ? Sequence.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600647D RID: 25725 RVA: 0x0008F97F File Offset: 0x0008DB7F
		public static UObject GetObjectTemplate(in FSequencerBindingRuntimeProxy InBinding)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(UKuroSequenceRuntimeFunctionLibrary.__GetObjectTemplate_Internal((InBinding ?? new FSequencerBindingRuntimeProxy()).NativePtr));
		}

		// Token: 0x0600647E RID: 25726 RVA: 0x0008F99B File Offset: 0x0008DB9B
		[NullableContext(1)]
		public static TArray<UMovieSceneTrack> GetMasterTracks([Nullable(2)] UMovieSceneSequence Sequence)
		{
			return new TArray<UMovieSceneTrack>(UKuroSequenceRuntimeFunctionLibrary.__GetMasterTracks_Internal((Sequence != null) ? Sequence.NativePtr : IntPtr.Zero), null);
		}

		// Token: 0x0600647F RID: 25727 RVA: 0x0008F9B8 File Offset: 0x0008DBB8
		public unsafe static bool GetFrameTransformByTag(UMovieSceneSequence Sequence, FName Tag, int OutsideFrame, ref FTransform OutTransfom)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = OutTransfom;
			bool result = UKuroSequenceRuntimeFunctionLibrary.__GetFrameTransformByTag_Internal((Sequence != null) ? Sequence.NativePtr : IntPtr.Zero, Tag, OutsideFrame, ref ptr);
			OutTransfom = ptr;
			return result;
		}

		// Token: 0x06006480 RID: 25728 RVA: 0x0008FA05 File Offset: 0x0008DC05
		public static FTransform GetFrameTransform(UMovieSceneTrack Track, FFrameTime Frame)
		{
			return UKuroSequenceRuntimeFunctionLibrary.__GetFrameTransform_Internal((Track != null) ? Track.NativePtr : IntPtr.Zero, (Frame ?? new FFrameTime()).NativePtr);
		}

		// Token: 0x06006481 RID: 25729 RVA: 0x0008FA2B File Offset: 0x0008DC2B
		public static float GetFadeAmountAt(UMovieSceneFadeSection Section, FFrameTime Frame)
		{
			return UKuroSequenceRuntimeFunctionLibrary.__GetFadeAmountAt_Internal((Section != null) ? Section.NativePtr : IntPtr.Zero, (Frame ?? new FFrameTime()).NativePtr);
		}

		// Token: 0x06006482 RID: 25730 RVA: 0x0008FA51 File Offset: 0x0008DC51
		public static int GetEndFrame(UMovieSceneSection Section)
		{
			return UKuroSequenceRuntimeFunctionLibrary.__GetEndFrame_Internal((Section != null) ? Section.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06006483 RID: 25731 RVA: 0x0008FA68 File Offset: 0x0008DC68
		[NullableContext(1)]
		public static TArray<UMovieSceneTrack> FindTracksByType([Nullable(2)] in FSequencerBindingRuntimeProxy InBinding, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UMovieSceneTrack> TrackType)
		{
			return new TArray<UMovieSceneTrack>(UKuroSequenceRuntimeFunctionLibrary.__FindTracksByType_Internal((InBinding ?? new FSequencerBindingRuntimeProxy()).NativePtr, TrackType._NativePtr), null);
		}

		// Token: 0x06006484 RID: 25732 RVA: 0x0008FA8B File Offset: 0x0008DC8B
		[return: Nullable(1)]
		public static TArray<FMovieSceneObjectBindingID> FindMatchAllTagsBinding(in TArray<FName> Tags, ULevelSequence LevelSequence)
		{
			return new TArray<FMovieSceneObjectBindingID>(UKuroSequenceRuntimeFunctionLibrary.__FindMatchAllTagsBinding_Internal((Tags ?? new TArray<FName>()).NativePtr, (LevelSequence != null) ? LevelSequence.NativePtr : IntPtr.Zero), null);
		}

		// Token: 0x06006485 RID: 25733 RVA: 0x0008FAB8 File Offset: 0x0008DCB8
		[NullableContext(1)]
		public static TArray<UMovieSceneTrack> FindMasterTracksByType([Nullable(2)] UMovieSceneSequence Sequence, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UMovieSceneTrack> TrackType)
		{
			return new TArray<UMovieSceneTrack>(UKuroSequenceRuntimeFunctionLibrary.__FindMasterTracksByType_Internal((Sequence != null) ? Sequence.NativePtr : IntPtr.Zero, TrackType._NativePtr), null);
		}

		// Token: 0x06006486 RID: 25734 RVA: 0x0008FADB File Offset: 0x0008DCDB
		[NullableContext(1)]
		public static FSequencerBindingRuntimeProxy FindBindingById([Nullable(2)] UMovieSceneSequence Sequence, FGuid BindingId)
		{
			return new FSequencerBindingRuntimeProxy(UKuroSequenceRuntimeFunctionLibrary.__FindBindingById_Internal((Sequence != null) ? Sequence.NativePtr : IntPtr.Zero, BindingId), null);
		}

		// Token: 0x06006487 RID: 25735 RVA: 0x0008FAF9 File Offset: 0x0008DCF9
		public static int EasePlayRateTo(ALevelSequenceActor SequenceActor, float TargetPlayRate, EKuroEasingFuncType EaseType, float Duration, float Exp)
		{
			return UKuroSequenceRuntimeFunctionLibrary.__EasePlayRateTo_Internal((SequenceActor != null) ? SequenceActor.NativePtr : IntPtr.Zero, TargetPlayRate, EaseType, Duration, Exp);
		}

		// Token: 0x06006488 RID: 25736
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void AddOrRemoveRenderAssetsQueryViewInfo(in FVector ViewOrigin, float Duration = 0f, float BoostFactor = 1.2f);

		// Token: 0x06006489 RID: 25737
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __StopEasingPlayRate_Internal(IntPtr SequenceActor, int HandleId, bool JumpToTarget);

		// Token: 0x0600648A RID: 25738
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SetSequenceInUiScene_Internal(IntPtr Sequence, bool IsEnable);

		// Token: 0x0600648B RID: 25739
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBindings_Internal(IntPtr SequenceActor, IntPtr Bindings, IntPtr Actors, bool bAllowBindingsFromAsset);

		// Token: 0x0600648C RID: 25740
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SectionContains_Internal(IntPtr Section, IntPtr Frame);

		// Token: 0x0600648D RID: 25741
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SearchAttachAndReattach_Internal(IntPtr Sequence, IntPtr InBindingNames, FName Tag);

		// Token: 0x0600648E RID: 25742
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResetMovieSceneCompiledData_Internal(IntPtr Sequence);

		// Token: 0x0600648F RID: 25743
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __RequestActorExternalStreaming_Internal(IntPtr WorldContextObject, IntPtr ActorRefs);

		// Token: 0x06006490 RID: 25744
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __MuteTrackByTag_Internal(IntPtr Sequence, FName Tag, bool bIsMuted);

		// Token: 0x06006491 RID: 25745
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __MuteTrackByName_Internal(IntPtr Sequence, FName Name, bool bIsMuted);

		// Token: 0x06006492 RID: 25746
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __HandleSeqTexStreaming_Internal(IntPtr LevelSequences, bool bStartForceStreamIn, bool bCollectExtraTexture);

		// Token: 0x06006493 RID: 25747
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetTracks_Internal(IntPtr InBinding);

		// Token: 0x06006494 RID: 25748
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetStartFrame_Internal(IntPtr Section);

		// Token: 0x06006495 RID: 25749
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetSpawnables_Internal(IntPtr Sequence);

		// Token: 0x06006496 RID: 25750
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetSections_Internal(IntPtr Track);

		// Token: 0x06006497 RID: 25751
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetPlaybackStart_Internal(IntPtr Sequence);

		// Token: 0x06006498 RID: 25752
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetPlaybackEnd_Internal(IntPtr Sequence);

		// Token: 0x06006499 RID: 25753
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetObjectTemplate_Internal(IntPtr InBinding);

		// Token: 0x0600649A RID: 25754
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetMasterTracks_Internal(IntPtr Sequence);

		// Token: 0x0600649B RID: 25755
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetFrameTransformByTag_Internal(IntPtr Sequence, FName Tag, int OutsideFrame, ref FTransform OutTransfom);

		// Token: 0x0600649C RID: 25756
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransform __GetFrameTransform_Internal(IntPtr Track, IntPtr Frame);

		// Token: 0x0600649D RID: 25757
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetFadeAmountAt_Internal(IntPtr Section, IntPtr Frame);

		// Token: 0x0600649E RID: 25758
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetEndFrame_Internal(IntPtr Section);

		// Token: 0x0600649F RID: 25759
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __FindTracksByType_Internal(IntPtr InBinding, IntPtr TrackType);

		// Token: 0x060064A0 RID: 25760
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __FindMatchAllTagsBinding_Internal(IntPtr Tags, IntPtr LevelSequence);

		// Token: 0x060064A1 RID: 25761
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __FindMasterTracksByType_Internal(IntPtr Sequence, IntPtr TrackType);

		// Token: 0x060064A2 RID: 25762
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __FindBindingById_Internal(IntPtr Sequence, FGuid BindingId);

		// Token: 0x060064A3 RID: 25763
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __EasePlayRateTo_Internal(IntPtr SequenceActor, float TargetPlayRate, EKuroEasingFuncType EaseType, float Duration, float Exp);

		// Token: 0x060064A4 RID: 25764 RVA: 0x0008FB15 File Offset: 0x0008DD15
		static UKuroSequenceRuntimeFunctionLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplay.KuroSequenceRuntimeFunctionLibrary");
		}

		// Token: 0x060064A5 RID: 25765 RVA: 0x0008FB23 File Offset: 0x0008DD23
		protected UKuroSequenceRuntimeFunctionLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002A62 RID: 10850
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroGameplay.KuroSequenceRuntimeFunctionLibrary";

		// Token: 0x04002A63 RID: 10851
		private static IntPtr _ClassPtr;

		// Token: 0x04002A64 RID: 10852
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
