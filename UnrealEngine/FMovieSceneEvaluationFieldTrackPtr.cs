using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020023FC RID: 9212
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Script/MovieScene.MovieSceneEvaluationFieldTrackPtr")]
	[UnrealStructLayout(8, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 8)]
	public class FMovieSceneEvaluationFieldTrackPtr : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060228E7 RID: 141543 RVA: 0x00331C0D File Offset: 0x0032FE0D
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneEvaluationFieldTrackPtr._ScriptStructPtr != 0) ? FMovieSceneEvaluationFieldTrackPtr._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieScene.MovieSceneEvaluationFieldTrackPtr", ref FMovieSceneEvaluationFieldTrackPtr._ScriptStructPtr);
		}

		// Token: 0x1700850A RID: 34058
		// (get) Token: 0x060228E8 RID: 141544 RVA: 0x00331C34 File Offset: 0x0032FE34
		// (set) Token: 0x060228E9 RID: 141545 RVA: 0x00331C77 File Offset: 0x0032FE77
		public FMovieSceneSequenceID SequenceID
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneSequenceID result;
				if ((result = this._SequenceID) == null)
				{
					result = (this._SequenceID = new FMovieSceneSequenceID(base.NativePtr + (IntPtr)FMovieSceneEvaluationFieldTrackPtr.__PropertyOffset_SequenceID, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneSequenceID.StaticStruct(), base.NativePtr + (IntPtr)FMovieSceneEvaluationFieldTrackPtr.__PropertyOffset_SequenceID, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700850B RID: 34059
		// (get) Token: 0x060228EA RID: 141546 RVA: 0x00331C98 File Offset: 0x0032FE98
		// (set) Token: 0x060228EB RID: 141547 RVA: 0x00331CDB File Offset: 0x0032FEDB
		public FMovieSceneTrackIdentifier TrackIdentifier
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneTrackIdentifier result;
				if ((result = this._TrackIdentifier) == null)
				{
					result = (this._TrackIdentifier = new FMovieSceneTrackIdentifier(base.NativePtr + (IntPtr)FMovieSceneEvaluationFieldTrackPtr.__PropertyOffset_TrackIdentifier, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneTrackIdentifier.StaticStruct(), base.NativePtr + (IntPtr)FMovieSceneEvaluationFieldTrackPtr.__PropertyOffset_TrackIdentifier, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060228EC RID: 141548 RVA: 0x00331CFC File Offset: 0x0032FEFC
		public FMovieSceneEvaluationFieldTrackPtr()
		{
		}

		// Token: 0x060228ED RID: 141549 RVA: 0x00331D04 File Offset: 0x0032FF04
		public FMovieSceneEvaluationFieldTrackPtr(FMovieSceneSequenceID SequenceID, FMovieSceneTrackIdentifier TrackIdentifier)
		{
			this.SequenceID = SequenceID;
			this.TrackIdentifier = TrackIdentifier;
		}

		// Token: 0x060228EE RID: 141550 RVA: 0x00331D1A File Offset: 0x0032FF1A
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneEvaluationFieldTrackPtr.StaticStruct();
		}

		// Token: 0x060228EF RID: 141551 RVA: 0x00331D26 File Offset: 0x0032FF26
		[NullableContext(2)]
		public FMovieSceneEvaluationFieldTrackPtr(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060228F0 RID: 141552 RVA: 0x00331D30 File Offset: 0x0032FF30
		public FMovieSceneEvaluationFieldTrackPtr(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060228F1 RID: 141553 RVA: 0x00331D3B File Offset: 0x0032FF3B
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneEvaluationFieldTrackPtr(Pointer, false, true);
		}

		// Token: 0x060228F2 RID: 141554 RVA: 0x00331D45 File Offset: 0x0032FF45
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneEvaluationFieldTrackPtr(Pointer, MemoryOwner);
		}

		// Token: 0x0401277D RID: 75645
		public const string __ObjectPath = "/Script/MovieScene.MovieSceneEvaluationFieldTrackPtr";

		// Token: 0x0401277E RID: 75646
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401277F RID: 75647
		internal static int __PropertyOffset_SequenceID;

		// Token: 0x04012780 RID: 75648
		[Nullable(2)]
		private FMovieSceneSequenceID _SequenceID;

		// Token: 0x04012781 RID: 75649
		internal static int __PropertyOffset_TrackIdentifier;

		// Token: 0x04012782 RID: 75650
		[Nullable(2)]
		private FMovieSceneTrackIdentifier _TrackIdentifier;
	}
}
