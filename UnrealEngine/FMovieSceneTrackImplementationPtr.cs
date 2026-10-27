using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002453 RID: 9299
	[UnrealObjectPath("/Script/MovieScene.MovieSceneTrackImplementationPtr")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FMovieSceneTrackImplementationPtr : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06022DAC RID: 142764 RVA: 0x00338A97 File Offset: 0x00336C97
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneTrackImplementationPtr._ScriptStructPtr != 0) ? FMovieSceneTrackImplementationPtr._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieScene.MovieSceneTrackImplementationPtr", ref FMovieSceneTrackImplementationPtr._ScriptStructPtr);
		}

		// Token: 0x06022DAD RID: 142765 RVA: 0x00338ABB File Offset: 0x00336CBB
		public FMovieSceneTrackImplementationPtr()
		{
		}

		// Token: 0x06022DAE RID: 142766 RVA: 0x00338AC3 File Offset: 0x00336CC3
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneTrackImplementationPtr.StaticStruct();
		}

		// Token: 0x06022DAF RID: 142767 RVA: 0x00338ACF File Offset: 0x00336CCF
		[NullableContext(2)]
		public FMovieSceneTrackImplementationPtr(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06022DB0 RID: 142768 RVA: 0x00338AD9 File Offset: 0x00336CD9
		public FMovieSceneTrackImplementationPtr(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06022DB1 RID: 142769 RVA: 0x00338AE4 File Offset: 0x00336CE4
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneTrackImplementationPtr(Pointer, false, true);
		}

		// Token: 0x06022DB2 RID: 142770 RVA: 0x00338AEE File Offset: 0x00336CEE
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneTrackImplementationPtr(Pointer, MemoryOwner);
		}

		// Token: 0x040129C3 RID: 76227
		[Nullable(1)]
		public const string __ObjectPath = "/Script/MovieScene.MovieSceneTrackImplementationPtr";

		// Token: 0x040129C4 RID: 76228
		private static IntPtr _ScriptStructPtr;
	}
}
