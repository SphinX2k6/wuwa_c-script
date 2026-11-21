using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200077D RID: 1917
	[UnrealObjectPath("/Script/MovieScene.MovieSceneChannel")]
	[UnrealStructLayout(8, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 8)]
	public class FMovieSceneChannel : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600A5A2 RID: 42402 RVA: 0x000F4A81 File Offset: 0x000F2C81
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneChannel._ScriptStructPtr != 0) ? FMovieSceneChannel._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieScene.MovieSceneChannel", ref FMovieSceneChannel._ScriptStructPtr);
		}

		// Token: 0x0600A5A3 RID: 42403 RVA: 0x000F4AA5 File Offset: 0x000F2CA5
		public FMovieSceneChannel()
		{
		}

		// Token: 0x0600A5A4 RID: 42404 RVA: 0x000F4AAD File Offset: 0x000F2CAD
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneChannel.StaticStruct();
		}

		// Token: 0x0600A5A5 RID: 42405 RVA: 0x000F4AB9 File Offset: 0x000F2CB9
		[NullableContext(2)]
		public FMovieSceneChannel(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600A5A6 RID: 42406 RVA: 0x000F4AC3 File Offset: 0x000F2CC3
		public FMovieSceneChannel(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600A5A7 RID: 42407 RVA: 0x000F4ACE File Offset: 0x000F2CCE
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneChannel(Pointer, false, true);
		}

		// Token: 0x0600A5A8 RID: 42408 RVA: 0x000F4AD8 File Offset: 0x000F2CD8
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneChannel(Pointer, MemoryOwner);
		}

		// Token: 0x040046E7 RID: 18151
		[Nullable(1)]
		public const string __ObjectPath = "/Script/MovieScene.MovieSceneChannel";

		// Token: 0x040046E8 RID: 18152
		private static IntPtr _ScriptStructPtr;
	}
}
