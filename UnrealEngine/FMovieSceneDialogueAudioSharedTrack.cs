using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020026E6 RID: 9958
	[UnrealObjectPath("/Script/SequenceDialogue.MovieSceneDialogueAudioSharedTrack")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FMovieSceneDialogueAudioSharedTrack : FMovieSceneEvalTemplate, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06024EE3 RID: 151267 RVA: 0x00369EAF File Offset: 0x003680AF
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneDialogueAudioSharedTrack._ScriptStructPtr != 0) ? FMovieSceneDialogueAudioSharedTrack._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SequenceDialogue.MovieSceneDialogueAudioSharedTrack", ref FMovieSceneDialogueAudioSharedTrack._ScriptStructPtr);
		}

		// Token: 0x06024EE4 RID: 151268 RVA: 0x00369ED3 File Offset: 0x003680D3
		public FMovieSceneDialogueAudioSharedTrack()
		{
		}

		// Token: 0x06024EE5 RID: 151269 RVA: 0x00369EDB File Offset: 0x003680DB
		public FMovieSceneDialogueAudioSharedTrack(EMovieSceneCompletionMode CompletionMode, [Nullable(new byte[]
		{
			0,
			1
		})] TWeakObjectPtr<UMovieSceneSection> SourceSectionPtr)
		{
			base.CompletionMode = CompletionMode;
			base.SourceSectionPtr = SourceSectionPtr;
		}

		// Token: 0x06024EE6 RID: 151270 RVA: 0x00369EF1 File Offset: 0x003680F1
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneDialogueAudioSharedTrack.StaticStruct();
		}

		// Token: 0x06024EE7 RID: 151271 RVA: 0x00369EFD File Offset: 0x003680FD
		[NullableContext(2)]
		public FMovieSceneDialogueAudioSharedTrack(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06024EE8 RID: 151272 RVA: 0x00369F07 File Offset: 0x00368107
		public FMovieSceneDialogueAudioSharedTrack(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06024EE9 RID: 151273 RVA: 0x00369F12 File Offset: 0x00368112
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneDialogueAudioSharedTrack(Pointer, false, true);
		}

		// Token: 0x06024EEA RID: 151274 RVA: 0x00369F1C File Offset: 0x0036811C
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneDialogueAudioSharedTrack(Pointer, MemoryOwner);
		}

		// Token: 0x04013E63 RID: 81507
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/SequenceDialogue.MovieSceneDialogueAudioSharedTrack";

		// Token: 0x04013E64 RID: 81508
		private static IntPtr _ScriptStructPtr;
	}
}
