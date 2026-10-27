using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002445 RID: 9285
	[UnrealObjectPath("/Script/MovieScene.MovieSceneSubSequenceTreeEntry")]
	[UnrealStructLayout(8, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 8)]
	public class FMovieSceneSubSequenceTreeEntry : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06022D0E RID: 142606 RVA: 0x00337BE0 File Offset: 0x00335DE0
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneSubSequenceTreeEntry._ScriptStructPtr != 0) ? FMovieSceneSubSequenceTreeEntry._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieScene.MovieSceneSubSequenceTreeEntry", ref FMovieSceneSubSequenceTreeEntry._ScriptStructPtr);
		}

		// Token: 0x06022D0F RID: 142607 RVA: 0x00337C04 File Offset: 0x00335E04
		public FMovieSceneSubSequenceTreeEntry()
		{
		}

		// Token: 0x06022D10 RID: 142608 RVA: 0x00337C0C File Offset: 0x00335E0C
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneSubSequenceTreeEntry.StaticStruct();
		}

		// Token: 0x06022D11 RID: 142609 RVA: 0x00337C18 File Offset: 0x00335E18
		[NullableContext(2)]
		public FMovieSceneSubSequenceTreeEntry(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06022D12 RID: 142610 RVA: 0x00337C22 File Offset: 0x00335E22
		public FMovieSceneSubSequenceTreeEntry(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06022D13 RID: 142611 RVA: 0x00337C2D File Offset: 0x00335E2D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneSubSequenceTreeEntry(Pointer, false, true);
		}

		// Token: 0x06022D14 RID: 142612 RVA: 0x00337C37 File Offset: 0x00335E37
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneSubSequenceTreeEntry(Pointer, MemoryOwner);
		}

		// Token: 0x04012970 RID: 76144
		[Nullable(1)]
		public const string __ObjectPath = "/Script/MovieScene.MovieSceneSubSequenceTreeEntry";

		// Token: 0x04012971 RID: 76145
		private static IntPtr _ScriptStructPtr;
	}
}
