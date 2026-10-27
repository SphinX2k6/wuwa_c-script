using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020023F2 RID: 9202
	[UnrealObjectPath("/Script/MovieScene.MovieSceneEvalTemplateBase")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FMovieSceneEvalTemplateBase : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06022883 RID: 141443 RVA: 0x00331421 File Offset: 0x0032F621
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneEvalTemplateBase._ScriptStructPtr != 0) ? FMovieSceneEvalTemplateBase._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieScene.MovieSceneEvalTemplateBase", ref FMovieSceneEvalTemplateBase._ScriptStructPtr);
		}

		// Token: 0x06022884 RID: 141444 RVA: 0x00331445 File Offset: 0x0032F645
		public FMovieSceneEvalTemplateBase()
		{
		}

		// Token: 0x06022885 RID: 141445 RVA: 0x0033144D File Offset: 0x0032F64D
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneEvalTemplateBase.StaticStruct();
		}

		// Token: 0x06022886 RID: 141446 RVA: 0x00331459 File Offset: 0x0032F659
		[NullableContext(2)]
		public FMovieSceneEvalTemplateBase(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06022887 RID: 141447 RVA: 0x00331463 File Offset: 0x0032F663
		public FMovieSceneEvalTemplateBase(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06022888 RID: 141448 RVA: 0x0033146E File Offset: 0x0032F66E
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneEvalTemplateBase(Pointer, false, true);
		}

		// Token: 0x06022889 RID: 141449 RVA: 0x00331478 File Offset: 0x0032F678
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneEvalTemplateBase(Pointer, MemoryOwner);
		}

		// Token: 0x04012753 RID: 75603
		[Nullable(1)]
		public const string __ObjectPath = "/Script/MovieScene.MovieSceneEvalTemplateBase";

		// Token: 0x04012754 RID: 75604
		private static IntPtr _ScriptStructPtr;
	}
}
