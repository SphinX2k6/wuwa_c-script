using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020026F6 RID: 9974
	[UnrealObjectPath("/Script/SequenceDialogue.MovieSceneQteTemplate")]
	[UnrealStructLayout(240, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 240)]
	public class FMovieSceneQteTemplate : FMovieSceneEvalTemplate, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06024FF7 RID: 151543 RVA: 0x0036BBDD File Offset: 0x00369DDD
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneQteTemplate._ScriptStructPtr != 0) ? FMovieSceneQteTemplate._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SequenceDialogue.MovieSceneQteTemplate", ref FMovieSceneQteTemplate._ScriptStructPtr);
		}

		// Token: 0x06024FF8 RID: 151544 RVA: 0x0036BC01 File Offset: 0x00369E01
		public FMovieSceneQteTemplate()
		{
		}

		// Token: 0x06024FF9 RID: 151545 RVA: 0x0036BC09 File Offset: 0x00369E09
		public FMovieSceneQteTemplate(EMovieSceneCompletionMode CompletionMode, [Nullable(new byte[]
		{
			0,
			1
		})] TWeakObjectPtr<UMovieSceneSection> SourceSectionPtr)
		{
			base.CompletionMode = CompletionMode;
			base.SourceSectionPtr = SourceSectionPtr;
		}

		// Token: 0x06024FFA RID: 151546 RVA: 0x0036BC1F File Offset: 0x00369E1F
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneQteTemplate.StaticStruct();
		}

		// Token: 0x06024FFB RID: 151547 RVA: 0x0036BC2B File Offset: 0x00369E2B
		[NullableContext(2)]
		public FMovieSceneQteTemplate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06024FFC RID: 151548 RVA: 0x0036BC35 File Offset: 0x00369E35
		public FMovieSceneQteTemplate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06024FFD RID: 151549 RVA: 0x0036BC40 File Offset: 0x00369E40
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneQteTemplate(Pointer, false, true);
		}

		// Token: 0x06024FFE RID: 151550 RVA: 0x0036BC4A File Offset: 0x00369E4A
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneQteTemplate(Pointer, MemoryOwner);
		}

		// Token: 0x04013F03 RID: 81667
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/SequenceDialogue.MovieSceneQteTemplate";

		// Token: 0x04013F04 RID: 81668
		private static IntPtr _ScriptStructPtr;
	}
}
