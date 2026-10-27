using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200233B RID: 9019
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneAdditiveCameraAnimationTemplate")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FMovieSceneAdditiveCameraAnimationTemplate : FMovieSceneEvalTemplate, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060221A4 RID: 139684 RVA: 0x00326C7E File Offset: 0x00324E7E
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneAdditiveCameraAnimationTemplate._ScriptStructPtr != 0) ? FMovieSceneAdditiveCameraAnimationTemplate._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieSceneTracks.MovieSceneAdditiveCameraAnimationTemplate", ref FMovieSceneAdditiveCameraAnimationTemplate._ScriptStructPtr);
		}

		// Token: 0x060221A5 RID: 139685 RVA: 0x00326CA2 File Offset: 0x00324EA2
		public FMovieSceneAdditiveCameraAnimationTemplate()
		{
		}

		// Token: 0x060221A6 RID: 139686 RVA: 0x00326CAA File Offset: 0x00324EAA
		public FMovieSceneAdditiveCameraAnimationTemplate(EMovieSceneCompletionMode CompletionMode, [Nullable(new byte[]
		{
			0,
			1
		})] TWeakObjectPtr<UMovieSceneSection> SourceSectionPtr)
		{
			base.CompletionMode = CompletionMode;
			base.SourceSectionPtr = SourceSectionPtr;
		}

		// Token: 0x060221A7 RID: 139687 RVA: 0x00326CC0 File Offset: 0x00324EC0
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneAdditiveCameraAnimationTemplate.StaticStruct();
		}

		// Token: 0x060221A8 RID: 139688 RVA: 0x00326CCC File Offset: 0x00324ECC
		[NullableContext(2)]
		public FMovieSceneAdditiveCameraAnimationTemplate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060221A9 RID: 139689 RVA: 0x00326CD6 File Offset: 0x00324ED6
		public FMovieSceneAdditiveCameraAnimationTemplate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060221AA RID: 139690 RVA: 0x00326CE1 File Offset: 0x00324EE1
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneAdditiveCameraAnimationTemplate(Pointer, false, true);
		}

		// Token: 0x060221AB RID: 139691 RVA: 0x00326CEB File Offset: 0x00324EEB
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneAdditiveCameraAnimationTemplate(Pointer, MemoryOwner);
		}

		// Token: 0x0401233B RID: 74555
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneAdditiveCameraAnimationTemplate";

		// Token: 0x0401233C RID: 74556
		private static IntPtr _ScriptStructPtr;
	}
}
