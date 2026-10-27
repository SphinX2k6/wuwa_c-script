using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002434 RID: 9268
	[UnrealObjectPath("/Script/MovieScene.MovieSceneSequenceInstanceDataPtr")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FMovieSceneSequenceInstanceDataPtr : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06022B91 RID: 142225 RVA: 0x00335A27 File Offset: 0x00333C27
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneSequenceInstanceDataPtr._ScriptStructPtr != 0) ? FMovieSceneSequenceInstanceDataPtr._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieScene.MovieSceneSequenceInstanceDataPtr", ref FMovieSceneSequenceInstanceDataPtr._ScriptStructPtr);
		}

		// Token: 0x06022B92 RID: 142226 RVA: 0x00335A4B File Offset: 0x00333C4B
		public FMovieSceneSequenceInstanceDataPtr()
		{
		}

		// Token: 0x06022B93 RID: 142227 RVA: 0x00335A53 File Offset: 0x00333C53
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneSequenceInstanceDataPtr.StaticStruct();
		}

		// Token: 0x06022B94 RID: 142228 RVA: 0x00335A5F File Offset: 0x00333C5F
		[NullableContext(2)]
		public FMovieSceneSequenceInstanceDataPtr(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06022B95 RID: 142229 RVA: 0x00335A69 File Offset: 0x00333C69
		public FMovieSceneSequenceInstanceDataPtr(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06022B96 RID: 142230 RVA: 0x00335A74 File Offset: 0x00333C74
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneSequenceInstanceDataPtr(Pointer, false, true);
		}

		// Token: 0x06022B97 RID: 142231 RVA: 0x00335A7E File Offset: 0x00333C7E
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneSequenceInstanceDataPtr(Pointer, MemoryOwner);
		}

		// Token: 0x040128C8 RID: 75976
		[Nullable(1)]
		public const string __ObjectPath = "/Script/MovieScene.MovieSceneSequenceInstanceDataPtr";

		// Token: 0x040128C9 RID: 75977
		private static IntPtr _ScriptStructPtr;
	}
}
