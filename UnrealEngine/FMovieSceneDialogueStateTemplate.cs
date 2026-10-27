using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020026EC RID: 9964
	[UnrealObjectPath("/Script/SequenceDialogue.MovieSceneDialogueStateTemplate")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FMovieSceneDialogueStateTemplate : FMovieSceneEvalTemplate, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06024F4C RID: 151372 RVA: 0x0036A937 File Offset: 0x00368B37
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneDialogueStateTemplate._ScriptStructPtr != 0) ? FMovieSceneDialogueStateTemplate._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SequenceDialogue.MovieSceneDialogueStateTemplate", ref FMovieSceneDialogueStateTemplate._ScriptStructPtr);
		}

		// Token: 0x06024F4D RID: 151373 RVA: 0x0036A95B File Offset: 0x00368B5B
		public FMovieSceneDialogueStateTemplate()
		{
		}

		// Token: 0x06024F4E RID: 151374 RVA: 0x0036A963 File Offset: 0x00368B63
		public FMovieSceneDialogueStateTemplate(EMovieSceneCompletionMode CompletionMode, [Nullable(new byte[]
		{
			0,
			1
		})] TWeakObjectPtr<UMovieSceneSection> SourceSectionPtr)
		{
			base.CompletionMode = CompletionMode;
			base.SourceSectionPtr = SourceSectionPtr;
		}

		// Token: 0x06024F4F RID: 151375 RVA: 0x0036A979 File Offset: 0x00368B79
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneDialogueStateTemplate.StaticStruct();
		}

		// Token: 0x06024F50 RID: 151376 RVA: 0x0036A985 File Offset: 0x00368B85
		[NullableContext(2)]
		public FMovieSceneDialogueStateTemplate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06024F51 RID: 151377 RVA: 0x0036A98F File Offset: 0x00368B8F
		public FMovieSceneDialogueStateTemplate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06024F52 RID: 151378 RVA: 0x0036A99A File Offset: 0x00368B9A
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneDialogueStateTemplate(Pointer, false, true);
		}

		// Token: 0x06024F53 RID: 151379 RVA: 0x0036A9A4 File Offset: 0x00368BA4
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneDialogueStateTemplate(Pointer, MemoryOwner);
		}

		// Token: 0x04013EA1 RID: 81569
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/SequenceDialogue.MovieSceneDialogueStateTemplate";

		// Token: 0x04013EA2 RID: 81570
		private static IntPtr _ScriptStructPtr;
	}
}
