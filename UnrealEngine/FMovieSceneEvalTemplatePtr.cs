using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020023F3 RID: 9203
	[UnrealObjectPath("/Script/MovieScene.MovieSceneEvalTemplatePtr")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 136)]
	public class FMovieSceneEvalTemplatePtr : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602288A RID: 141450 RVA: 0x00331481 File Offset: 0x0032F681
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneEvalTemplatePtr._ScriptStructPtr != 0) ? FMovieSceneEvalTemplatePtr._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieScene.MovieSceneEvalTemplatePtr", ref FMovieSceneEvalTemplatePtr._ScriptStructPtr);
		}

		// Token: 0x0602288B RID: 141451 RVA: 0x003314A5 File Offset: 0x0032F6A5
		public FMovieSceneEvalTemplatePtr()
		{
		}

		// Token: 0x0602288C RID: 141452 RVA: 0x003314AD File Offset: 0x0032F6AD
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneEvalTemplatePtr.StaticStruct();
		}

		// Token: 0x0602288D RID: 141453 RVA: 0x003314B9 File Offset: 0x0032F6B9
		[NullableContext(2)]
		public FMovieSceneEvalTemplatePtr(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602288E RID: 141454 RVA: 0x003314C3 File Offset: 0x0032F6C3
		public FMovieSceneEvalTemplatePtr(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602288F RID: 141455 RVA: 0x003314CE File Offset: 0x0032F6CE
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneEvalTemplatePtr(Pointer, false, true);
		}

		// Token: 0x06022890 RID: 141456 RVA: 0x003314D8 File Offset: 0x0032F6D8
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneEvalTemplatePtr(Pointer, MemoryOwner);
		}

		// Token: 0x04012755 RID: 75605
		[Nullable(1)]
		public const string __ObjectPath = "/Script/MovieScene.MovieSceneEvalTemplatePtr";

		// Token: 0x04012756 RID: 75606
		private static IntPtr _ScriptStructPtr;
	}
}
