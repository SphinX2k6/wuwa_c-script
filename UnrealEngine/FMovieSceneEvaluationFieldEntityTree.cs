using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020023F9 RID: 9209
	[UnrealObjectPath("/Script/MovieScene.MovieSceneEvaluationFieldEntityTree")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 96)]
	public class FMovieSceneEvaluationFieldEntityTree : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060228CC RID: 141516 RVA: 0x00331A34 File Offset: 0x0032FC34
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneEvaluationFieldEntityTree._ScriptStructPtr != 0) ? FMovieSceneEvaluationFieldEntityTree._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieScene.MovieSceneEvaluationFieldEntityTree", ref FMovieSceneEvaluationFieldEntityTree._ScriptStructPtr);
		}

		// Token: 0x060228CD RID: 141517 RVA: 0x00331A58 File Offset: 0x0032FC58
		public FMovieSceneEvaluationFieldEntityTree()
		{
		}

		// Token: 0x060228CE RID: 141518 RVA: 0x00331A60 File Offset: 0x0032FC60
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneEvaluationFieldEntityTree.StaticStruct();
		}

		// Token: 0x060228CF RID: 141519 RVA: 0x00331A6C File Offset: 0x0032FC6C
		[NullableContext(2)]
		public FMovieSceneEvaluationFieldEntityTree(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060228D0 RID: 141520 RVA: 0x00331A76 File Offset: 0x0032FC76
		public FMovieSceneEvaluationFieldEntityTree(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060228D1 RID: 141521 RVA: 0x00331A81 File Offset: 0x0032FC81
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneEvaluationFieldEntityTree(Pointer, false, true);
		}

		// Token: 0x060228D2 RID: 141522 RVA: 0x00331A8B File Offset: 0x0032FC8B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneEvaluationFieldEntityTree(Pointer, MemoryOwner);
		}

		// Token: 0x04012774 RID: 75636
		[Nullable(1)]
		public const string __ObjectPath = "/Script/MovieScene.MovieSceneEvaluationFieldEntityTree";

		// Token: 0x04012775 RID: 75637
		private static IntPtr _ScriptStructPtr;
	}
}
