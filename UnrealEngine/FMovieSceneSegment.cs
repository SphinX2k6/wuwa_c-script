using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200242C RID: 9260
	[UnrealObjectPath("/Script/MovieScene.MovieSceneSegment")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 88)]
	public class FMovieSceneSegment : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06022B24 RID: 142116 RVA: 0x003351A0 File Offset: 0x003333A0
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneSegment._ScriptStructPtr != 0) ? FMovieSceneSegment._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieScene.MovieSceneSegment", ref FMovieSceneSegment._ScriptStructPtr);
		}

		// Token: 0x06022B25 RID: 142117 RVA: 0x003351C4 File Offset: 0x003333C4
		public FMovieSceneSegment()
		{
		}

		// Token: 0x06022B26 RID: 142118 RVA: 0x003351CC File Offset: 0x003333CC
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneSegment.StaticStruct();
		}

		// Token: 0x06022B27 RID: 142119 RVA: 0x003351D8 File Offset: 0x003333D8
		[NullableContext(2)]
		public FMovieSceneSegment(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06022B28 RID: 142120 RVA: 0x003351E2 File Offset: 0x003333E2
		public FMovieSceneSegment(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06022B29 RID: 142121 RVA: 0x003351ED File Offset: 0x003333ED
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneSegment(Pointer, false, true);
		}

		// Token: 0x06022B2A RID: 142122 RVA: 0x003351F7 File Offset: 0x003333F7
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneSegment(Pointer, MemoryOwner);
		}

		// Token: 0x0401289C RID: 75932
		[Nullable(1)]
		public const string __ObjectPath = "/Script/MovieScene.MovieSceneSegment";

		// Token: 0x0401289D RID: 75933
		private static IntPtr _ScriptStructPtr;
	}
}
