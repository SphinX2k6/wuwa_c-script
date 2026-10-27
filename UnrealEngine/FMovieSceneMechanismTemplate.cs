using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020019D1 RID: 6609
	[UnrealObjectPath("/Script/KuroMechanismSequenceRuntime.MovieSceneMechanismTemplate")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FMovieSceneMechanismTemplate : FMovieSceneEvalTemplate, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060188C3 RID: 100547 RVA: 0x00242656 File Offset: 0x00240856
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneMechanismTemplate._ScriptStructPtr != 0) ? FMovieSceneMechanismTemplate._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroMechanismSequenceRuntime.MovieSceneMechanismTemplate", ref FMovieSceneMechanismTemplate._ScriptStructPtr);
		}

		// Token: 0x060188C4 RID: 100548 RVA: 0x0024267A File Offset: 0x0024087A
		public FMovieSceneMechanismTemplate()
		{
		}

		// Token: 0x060188C5 RID: 100549 RVA: 0x00242682 File Offset: 0x00240882
		public FMovieSceneMechanismTemplate(EMovieSceneCompletionMode CompletionMode, [Nullable(new byte[]
		{
			0,
			1
		})] TWeakObjectPtr<UMovieSceneSection> SourceSectionPtr)
		{
			base.CompletionMode = CompletionMode;
			base.SourceSectionPtr = SourceSectionPtr;
		}

		// Token: 0x060188C6 RID: 100550 RVA: 0x00242698 File Offset: 0x00240898
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneMechanismTemplate.StaticStruct();
		}

		// Token: 0x060188C7 RID: 100551 RVA: 0x002426A4 File Offset: 0x002408A4
		[NullableContext(2)]
		public FMovieSceneMechanismTemplate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060188C8 RID: 100552 RVA: 0x002426AE File Offset: 0x002408AE
		public FMovieSceneMechanismTemplate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060188C9 RID: 100553 RVA: 0x002426B9 File Offset: 0x002408B9
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneMechanismTemplate(Pointer, false, true);
		}

		// Token: 0x060188CA RID: 100554 RVA: 0x002426C3 File Offset: 0x002408C3
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneMechanismTemplate(Pointer, MemoryOwner);
		}

		// Token: 0x0400D435 RID: 54325
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroMechanismSequenceRuntime.MovieSceneMechanismTemplate";

		// Token: 0x0400D436 RID: 54326
		private static IntPtr _ScriptStructPtr;
	}
}
