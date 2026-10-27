using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002407 RID: 9223
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieScene.MovieSceneFieldEntry_EvaluationTrack")]
	[UnrealStructLayout(12, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 12)]
	public class FMovieSceneFieldEntry_EvaluationTrack : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06022981 RID: 141697 RVA: 0x00332A29 File Offset: 0x00330C29
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneFieldEntry_EvaluationTrack._ScriptStructPtr != 0) ? FMovieSceneFieldEntry_EvaluationTrack._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieScene.MovieSceneFieldEntry_EvaluationTrack", ref FMovieSceneFieldEntry_EvaluationTrack._ScriptStructPtr);
		}

		// Token: 0x1700852B RID: 34091
		// (get) Token: 0x06022982 RID: 141698 RVA: 0x00332A50 File Offset: 0x00330C50
		// (set) Token: 0x06022983 RID: 141699 RVA: 0x00332A93 File Offset: 0x00330C93
		public FMovieSceneEvaluationFieldTrackPtr TrackPtr
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneEvaluationFieldTrackPtr result;
				if ((result = this._TrackPtr) == null)
				{
					result = (this._TrackPtr = new FMovieSceneEvaluationFieldTrackPtr(base.NativePtr + (IntPtr)FMovieSceneFieldEntry_EvaluationTrack.__PropertyOffset_TrackPtr, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneEvaluationFieldTrackPtr.StaticStruct(), base.NativePtr + (IntPtr)FMovieSceneFieldEntry_EvaluationTrack.__PropertyOffset_TrackPtr, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700852C RID: 34092
		// (get) Token: 0x06022984 RID: 141700 RVA: 0x00332AB4 File Offset: 0x00330CB4
		// (set) Token: 0x06022985 RID: 141701 RVA: 0x00332AC4 File Offset: 0x00330CC4
		public unsafe ushort NumChildren
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneFieldEntry_EvaluationTrack.__PropertyOffset_NumChildren);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneFieldEntry_EvaluationTrack.__PropertyOffset_NumChildren) = (short)value;
			}
		}

		// Token: 0x06022986 RID: 141702 RVA: 0x00332AD5 File Offset: 0x00330CD5
		public FMovieSceneFieldEntry_EvaluationTrack()
		{
		}

		// Token: 0x06022987 RID: 141703 RVA: 0x00332ADD File Offset: 0x00330CDD
		public FMovieSceneFieldEntry_EvaluationTrack(FMovieSceneEvaluationFieldTrackPtr TrackPtr, ushort NumChildren)
		{
			this.TrackPtr = TrackPtr;
			this.NumChildren = NumChildren;
		}

		// Token: 0x06022988 RID: 141704 RVA: 0x00332AF3 File Offset: 0x00330CF3
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneFieldEntry_EvaluationTrack.StaticStruct();
		}

		// Token: 0x06022989 RID: 141705 RVA: 0x00332AFF File Offset: 0x00330CFF
		[NullableContext(2)]
		public FMovieSceneFieldEntry_EvaluationTrack(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602298A RID: 141706 RVA: 0x00332B09 File Offset: 0x00330D09
		public FMovieSceneFieldEntry_EvaluationTrack(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602298B RID: 141707 RVA: 0x00332B14 File Offset: 0x00330D14
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneFieldEntry_EvaluationTrack(Pointer, false, true);
		}

		// Token: 0x0602298C RID: 141708 RVA: 0x00332B1E File Offset: 0x00330D1E
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneFieldEntry_EvaluationTrack(Pointer, MemoryOwner);
		}

		// Token: 0x040127C7 RID: 75719
		public const string __ObjectPath = "/Script/MovieScene.MovieSceneFieldEntry_EvaluationTrack";

		// Token: 0x040127C8 RID: 75720
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040127C9 RID: 75721
		internal static int __PropertyOffset_TrackPtr;

		// Token: 0x040127CA RID: 75722
		[Nullable(2)]
		private FMovieSceneEvaluationFieldTrackPtr _TrackPtr;

		// Token: 0x040127CB RID: 75723
		internal static int __PropertyOffset_NumChildren;
	}
}
