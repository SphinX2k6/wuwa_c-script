using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020023A9 RID: 9129
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneSkeletalAnimRootMotionTrackParams")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FMovieSceneSkeletalAnimRootMotionTrackParams : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06022629 RID: 140841 RVA: 0x0032DB2E File Offset: 0x0032BD2E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneSkeletalAnimRootMotionTrackParams._ScriptStructPtr != 0) ? FMovieSceneSkeletalAnimRootMotionTrackParams._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieSceneTracks.MovieSceneSkeletalAnimRootMotionTrackParams", ref FMovieSceneSkeletalAnimRootMotionTrackParams._ScriptStructPtr);
		}

		// Token: 0x0602262A RID: 140842 RVA: 0x0032DB52 File Offset: 0x0032BD52
		public FMovieSceneSkeletalAnimRootMotionTrackParams()
		{
		}

		// Token: 0x0602262B RID: 140843 RVA: 0x0032DB5A File Offset: 0x0032BD5A
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneSkeletalAnimRootMotionTrackParams.StaticStruct();
		}

		// Token: 0x0602262C RID: 140844 RVA: 0x0032DB66 File Offset: 0x0032BD66
		[NullableContext(2)]
		public FMovieSceneSkeletalAnimRootMotionTrackParams(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602262D RID: 140845 RVA: 0x0032DB70 File Offset: 0x0032BD70
		public FMovieSceneSkeletalAnimRootMotionTrackParams(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602262E RID: 140846 RVA: 0x0032DB7B File Offset: 0x0032BD7B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneSkeletalAnimRootMotionTrackParams(Pointer, false, true);
		}

		// Token: 0x0602262F RID: 140847 RVA: 0x0032DB85 File Offset: 0x0032BD85
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneSkeletalAnimRootMotionTrackParams(Pointer, MemoryOwner);
		}

		// Token: 0x040125B7 RID: 75191
		[Nullable(1)]
		public const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneSkeletalAnimRootMotionTrackParams";

		// Token: 0x040125B8 RID: 75192
		private static IntPtr _ScriptStructPtr;
	}
}
