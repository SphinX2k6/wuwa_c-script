using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002461 RID: 9313
	[UnrealObjectPath("/Script/MovieScene.TestMovieSceneEvalTemplate")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FTestMovieSceneEvalTemplate : FMovieSceneEvalTemplate, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06022E28 RID: 142888 RVA: 0x003393EE File Offset: 0x003375EE
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FTestMovieSceneEvalTemplate._ScriptStructPtr != 0) ? FTestMovieSceneEvalTemplate._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieScene.TestMovieSceneEvalTemplate", ref FTestMovieSceneEvalTemplate._ScriptStructPtr);
		}

		// Token: 0x06022E29 RID: 142889 RVA: 0x00339412 File Offset: 0x00337612
		public FTestMovieSceneEvalTemplate()
		{
		}

		// Token: 0x06022E2A RID: 142890 RVA: 0x0033941A File Offset: 0x0033761A
		public FTestMovieSceneEvalTemplate(EMovieSceneCompletionMode CompletionMode, [Nullable(new byte[]
		{
			0,
			1
		})] TWeakObjectPtr<UMovieSceneSection> SourceSectionPtr)
		{
			base.CompletionMode = CompletionMode;
			base.SourceSectionPtr = SourceSectionPtr;
		}

		// Token: 0x06022E2B RID: 142891 RVA: 0x00339430 File Offset: 0x00337630
		protected override IntPtr GetUStructPtr()
		{
			return FTestMovieSceneEvalTemplate.StaticStruct();
		}

		// Token: 0x06022E2C RID: 142892 RVA: 0x0033943C File Offset: 0x0033763C
		[NullableContext(2)]
		public FTestMovieSceneEvalTemplate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06022E2D RID: 142893 RVA: 0x00339446 File Offset: 0x00337646
		public FTestMovieSceneEvalTemplate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06022E2E RID: 142894 RVA: 0x00339451 File Offset: 0x00337651
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FTestMovieSceneEvalTemplate(Pointer, false, true);
		}

		// Token: 0x06022E2F RID: 142895 RVA: 0x0033945B File Offset: 0x0033765B
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FTestMovieSceneEvalTemplate(Pointer, MemoryOwner);
		}

		// Token: 0x040129F6 RID: 76278
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MovieScene.TestMovieSceneEvalTemplate";

		// Token: 0x040129F7 RID: 76279
		private static IntPtr _ScriptStructPtr;
	}
}
