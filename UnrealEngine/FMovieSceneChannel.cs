using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020023DF RID: 9183
	[UnrealObjectPath("/Script/MovieScene.MovieSceneChannel")]
	[UnrealStructLayout(8, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 8)]
	public class FMovieSceneChannel : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060227B4 RID: 141236 RVA: 0x0032FEE2 File Offset: 0x0032E0E2
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneChannel._ScriptStructPtr != 0) ? FMovieSceneChannel._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieScene.MovieSceneChannel", ref FMovieSceneChannel._ScriptStructPtr);
		}

		// Token: 0x060227B5 RID: 141237 RVA: 0x0032FF06 File Offset: 0x0032E106
		public FMovieSceneChannel()
		{
		}

		// Token: 0x060227B6 RID: 141238 RVA: 0x0032FF0E File Offset: 0x0032E10E
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneChannel.StaticStruct();
		}

		// Token: 0x060227B7 RID: 141239 RVA: 0x0032FF1A File Offset: 0x0032E11A
		[NullableContext(2)]
		public FMovieSceneChannel(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060227B8 RID: 141240 RVA: 0x0032FF24 File Offset: 0x0032E124
		public FMovieSceneChannel(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060227B9 RID: 141241 RVA: 0x0032FF2F File Offset: 0x0032E12F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneChannel(Pointer, false, true);
		}

		// Token: 0x060227BA RID: 141242 RVA: 0x0032FF39 File Offset: 0x0032E139
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneChannel(Pointer, MemoryOwner);
		}

		// Token: 0x040126E3 RID: 75491
		[Nullable(1)]
		public const string __ObjectPath = "/Script/MovieScene.MovieSceneChannel";

		// Token: 0x040126E4 RID: 75492
		private static IntPtr _ScriptStructPtr;
	}
}
