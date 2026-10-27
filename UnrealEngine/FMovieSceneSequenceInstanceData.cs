using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002433 RID: 9267
	[UnrealObjectPath("/Script/MovieScene.MovieSceneSequenceInstanceData")]
	[UnrealStructLayout(8, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 8)]
	public class FMovieSceneSequenceInstanceData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06022B8A RID: 142218 RVA: 0x003359C7 File Offset: 0x00333BC7
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneSequenceInstanceData._ScriptStructPtr != 0) ? FMovieSceneSequenceInstanceData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieScene.MovieSceneSequenceInstanceData", ref FMovieSceneSequenceInstanceData._ScriptStructPtr);
		}

		// Token: 0x06022B8B RID: 142219 RVA: 0x003359EB File Offset: 0x00333BEB
		public FMovieSceneSequenceInstanceData()
		{
		}

		// Token: 0x06022B8C RID: 142220 RVA: 0x003359F3 File Offset: 0x00333BF3
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneSequenceInstanceData.StaticStruct();
		}

		// Token: 0x06022B8D RID: 142221 RVA: 0x003359FF File Offset: 0x00333BFF
		[NullableContext(2)]
		public FMovieSceneSequenceInstanceData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06022B8E RID: 142222 RVA: 0x00335A09 File Offset: 0x00333C09
		public FMovieSceneSequenceInstanceData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06022B8F RID: 142223 RVA: 0x00335A14 File Offset: 0x00333C14
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneSequenceInstanceData(Pointer, false, true);
		}

		// Token: 0x06022B90 RID: 142224 RVA: 0x00335A1E File Offset: 0x00333C1E
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneSequenceInstanceData(Pointer, MemoryOwner);
		}

		// Token: 0x040128C6 RID: 75974
		[Nullable(1)]
		public const string __ObjectPath = "/Script/MovieScene.MovieSceneSequenceInstanceData";

		// Token: 0x040128C7 RID: 75975
		private static IntPtr _ScriptStructPtr;
	}
}
