using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020023EF RID: 9199
	[UnrealObjectPath("/Script/MovieScene.MovieSceneEntitySystemGraphNodes")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FMovieSceneEntitySystemGraphNodes : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06022869 RID: 141417 RVA: 0x00331227 File Offset: 0x0032F427
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneEntitySystemGraphNodes._ScriptStructPtr != 0) ? FMovieSceneEntitySystemGraphNodes._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieScene.MovieSceneEntitySystemGraphNodes", ref FMovieSceneEntitySystemGraphNodes._ScriptStructPtr);
		}

		// Token: 0x0602286A RID: 141418 RVA: 0x0033124B File Offset: 0x0032F44B
		public FMovieSceneEntitySystemGraphNodes()
		{
		}

		// Token: 0x0602286B RID: 141419 RVA: 0x00331253 File Offset: 0x0032F453
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneEntitySystemGraphNodes.StaticStruct();
		}

		// Token: 0x0602286C RID: 141420 RVA: 0x0033125F File Offset: 0x0032F45F
		[NullableContext(2)]
		public FMovieSceneEntitySystemGraphNodes(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602286D RID: 141421 RVA: 0x00331269 File Offset: 0x0032F469
		public FMovieSceneEntitySystemGraphNodes(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602286E RID: 141422 RVA: 0x00331274 File Offset: 0x0032F474
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneEntitySystemGraphNodes(Pointer, false, true);
		}

		// Token: 0x0602286F RID: 141423 RVA: 0x0033127E File Offset: 0x0032F47E
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneEntitySystemGraphNodes(Pointer, MemoryOwner);
		}

		// Token: 0x04012748 RID: 75592
		[Nullable(1)]
		public const string __ObjectPath = "/Script/MovieScene.MovieSceneEntitySystemGraphNodes";

		// Token: 0x04012749 RID: 75593
		private static IntPtr _ScriptStructPtr;
	}
}
