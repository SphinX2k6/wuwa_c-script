using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020026E2 RID: 9954
	[UnrealObjectPath("/Script/SequenceDialogue.MovieSceneAutoTransformSectionTemplate")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FMovieSceneAutoTransformSectionTemplate : FMovieSceneEvalTemplate, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06024EBE RID: 151230 RVA: 0x00369BD3 File Offset: 0x00367DD3
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneAutoTransformSectionTemplate._ScriptStructPtr != 0) ? FMovieSceneAutoTransformSectionTemplate._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SequenceDialogue.MovieSceneAutoTransformSectionTemplate", ref FMovieSceneAutoTransformSectionTemplate._ScriptStructPtr);
		}

		// Token: 0x06024EBF RID: 151231 RVA: 0x00369BF7 File Offset: 0x00367DF7
		public FMovieSceneAutoTransformSectionTemplate()
		{
		}

		// Token: 0x06024EC0 RID: 151232 RVA: 0x00369BFF File Offset: 0x00367DFF
		public FMovieSceneAutoTransformSectionTemplate(EMovieSceneCompletionMode CompletionMode, [Nullable(new byte[]
		{
			0,
			1
		})] TWeakObjectPtr<UMovieSceneSection> SourceSectionPtr)
		{
			base.CompletionMode = CompletionMode;
			base.SourceSectionPtr = SourceSectionPtr;
		}

		// Token: 0x06024EC1 RID: 151233 RVA: 0x00369C15 File Offset: 0x00367E15
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneAutoTransformSectionTemplate.StaticStruct();
		}

		// Token: 0x06024EC2 RID: 151234 RVA: 0x00369C21 File Offset: 0x00367E21
		[NullableContext(2)]
		public FMovieSceneAutoTransformSectionTemplate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06024EC3 RID: 151235 RVA: 0x00369C2B File Offset: 0x00367E2B
		public FMovieSceneAutoTransformSectionTemplate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06024EC4 RID: 151236 RVA: 0x00369C36 File Offset: 0x00367E36
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneAutoTransformSectionTemplate(Pointer, false, true);
		}

		// Token: 0x06024EC5 RID: 151237 RVA: 0x00369C40 File Offset: 0x00367E40
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneAutoTransformSectionTemplate(Pointer, MemoryOwner);
		}

		// Token: 0x04013E52 RID: 81490
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/SequenceDialogue.MovieSceneAutoTransformSectionTemplate";

		// Token: 0x04013E53 RID: 81491
		private static IntPtr _ScriptStructPtr;
	}
}
