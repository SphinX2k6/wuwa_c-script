using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002444 RID: 9284
	[UnrealObjectPath("/Script/MovieScene.MovieSceneSubSequenceTree")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 96)]
	public class FMovieSceneSubSequenceTree : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06022D07 RID: 142599 RVA: 0x00337B80 File Offset: 0x00335D80
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneSubSequenceTree._ScriptStructPtr != 0) ? FMovieSceneSubSequenceTree._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieScene.MovieSceneSubSequenceTree", ref FMovieSceneSubSequenceTree._ScriptStructPtr);
		}

		// Token: 0x06022D08 RID: 142600 RVA: 0x00337BA4 File Offset: 0x00335DA4
		public FMovieSceneSubSequenceTree()
		{
		}

		// Token: 0x06022D09 RID: 142601 RVA: 0x00337BAC File Offset: 0x00335DAC
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneSubSequenceTree.StaticStruct();
		}

		// Token: 0x06022D0A RID: 142602 RVA: 0x00337BB8 File Offset: 0x00335DB8
		[NullableContext(2)]
		public FMovieSceneSubSequenceTree(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06022D0B RID: 142603 RVA: 0x00337BC2 File Offset: 0x00335DC2
		public FMovieSceneSubSequenceTree(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06022D0C RID: 142604 RVA: 0x00337BCD File Offset: 0x00335DCD
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneSubSequenceTree(Pointer, false, true);
		}

		// Token: 0x06022D0D RID: 142605 RVA: 0x00337BD7 File Offset: 0x00335DD7
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneSubSequenceTree(Pointer, MemoryOwner);
		}

		// Token: 0x0401296E RID: 76142
		[Nullable(1)]
		public const string __ObjectPath = "/Script/MovieScene.MovieSceneSubSequenceTree";

		// Token: 0x0401296F RID: 76143
		private static IntPtr _ScriptStructPtr;
	}
}
