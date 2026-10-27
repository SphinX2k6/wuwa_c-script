using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020026EA RID: 9962
	[UnrealObjectPath("/Script/SequenceDialogue.MovieSceneDialogueSharedTrack")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FMovieSceneDialogueSharedTrack : FMovieSceneEvalTemplate, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06024F3D RID: 151357 RVA: 0x0036A818 File Offset: 0x00368A18
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneDialogueSharedTrack._ScriptStructPtr != 0) ? FMovieSceneDialogueSharedTrack._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SequenceDialogue.MovieSceneDialogueSharedTrack", ref FMovieSceneDialogueSharedTrack._ScriptStructPtr);
		}

		// Token: 0x06024F3E RID: 151358 RVA: 0x0036A83C File Offset: 0x00368A3C
		public FMovieSceneDialogueSharedTrack()
		{
		}

		// Token: 0x06024F3F RID: 151359 RVA: 0x0036A844 File Offset: 0x00368A44
		public FMovieSceneDialogueSharedTrack(EMovieSceneCompletionMode CompletionMode, [Nullable(new byte[]
		{
			0,
			1
		})] TWeakObjectPtr<UMovieSceneSection> SourceSectionPtr)
		{
			base.CompletionMode = CompletionMode;
			base.SourceSectionPtr = SourceSectionPtr;
		}

		// Token: 0x06024F40 RID: 151360 RVA: 0x0036A85A File Offset: 0x00368A5A
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneDialogueSharedTrack.StaticStruct();
		}

		// Token: 0x06024F41 RID: 151361 RVA: 0x0036A866 File Offset: 0x00368A66
		[NullableContext(2)]
		public FMovieSceneDialogueSharedTrack(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06024F42 RID: 151362 RVA: 0x0036A870 File Offset: 0x00368A70
		public FMovieSceneDialogueSharedTrack(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06024F43 RID: 151363 RVA: 0x0036A87B File Offset: 0x00368A7B
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneDialogueSharedTrack(Pointer, false, true);
		}

		// Token: 0x06024F44 RID: 151364 RVA: 0x0036A885 File Offset: 0x00368A85
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneDialogueSharedTrack(Pointer, MemoryOwner);
		}

		// Token: 0x04013E9B RID: 81563
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/SequenceDialogue.MovieSceneDialogueSharedTrack";

		// Token: 0x04013E9C RID: 81564
		private static IntPtr _ScriptStructPtr;
	}
}
