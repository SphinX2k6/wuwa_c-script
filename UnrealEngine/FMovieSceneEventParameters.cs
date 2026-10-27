using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200236D RID: 9069
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneEventParameters")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FMovieSceneEventParameters : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060223AD RID: 140205 RVA: 0x00329E5B File Offset: 0x0032805B
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneEventParameters._ScriptStructPtr != 0) ? FMovieSceneEventParameters._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieSceneTracks.MovieSceneEventParameters", ref FMovieSceneEventParameters._ScriptStructPtr);
		}

		// Token: 0x060223AE RID: 140206 RVA: 0x00329E7F File Offset: 0x0032807F
		public FMovieSceneEventParameters()
		{
		}

		// Token: 0x060223AF RID: 140207 RVA: 0x00329E87 File Offset: 0x00328087
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneEventParameters.StaticStruct();
		}

		// Token: 0x060223B0 RID: 140208 RVA: 0x00329E93 File Offset: 0x00328093
		[NullableContext(2)]
		public FMovieSceneEventParameters(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060223B1 RID: 140209 RVA: 0x00329E9D File Offset: 0x0032809D
		public FMovieSceneEventParameters(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060223B2 RID: 140210 RVA: 0x00329EA8 File Offset: 0x003280A8
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneEventParameters(Pointer, false, true);
		}

		// Token: 0x060223B3 RID: 140211 RVA: 0x00329EB2 File Offset: 0x003280B2
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneEventParameters(Pointer, MemoryOwner);
		}

		// Token: 0x04012459 RID: 74841
		[Nullable(1)]
		public const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneEventParameters";

		// Token: 0x0401245A RID: 74842
		private static IntPtr _ScriptStructPtr;
	}
}
