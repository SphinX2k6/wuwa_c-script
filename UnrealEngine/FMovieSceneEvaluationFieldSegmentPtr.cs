using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020023FA RID: 9210
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Script/MovieScene.MovieSceneEvaluationFieldSegmentPtr")]
	[UnrealStructLayout(12, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 12)]
	public class FMovieSceneEvaluationFieldSegmentPtr : FMovieSceneEvaluationFieldTrackPtr, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060228D3 RID: 141523 RVA: 0x00331A94 File Offset: 0x0032FC94
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneEvaluationFieldSegmentPtr._ScriptStructPtr != 0) ? FMovieSceneEvaluationFieldSegmentPtr._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieScene.MovieSceneEvaluationFieldSegmentPtr", ref FMovieSceneEvaluationFieldSegmentPtr._ScriptStructPtr);
		}

		// Token: 0x17008508 RID: 34056
		// (get) Token: 0x060228D4 RID: 141524 RVA: 0x00331AB8 File Offset: 0x0032FCB8
		// (set) Token: 0x060228D5 RID: 141525 RVA: 0x00331AFB File Offset: 0x0032FCFB
		public FMovieSceneSegmentIdentifier SegmentID
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneSegmentIdentifier result;
				if ((result = this._SegmentID) == null)
				{
					result = (this._SegmentID = new FMovieSceneSegmentIdentifier(base.NativePtr + (IntPtr)FMovieSceneEvaluationFieldSegmentPtr.__PropertyOffset_SegmentID, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneSegmentIdentifier.StaticStruct(), base.NativePtr + (IntPtr)FMovieSceneEvaluationFieldSegmentPtr.__PropertyOffset_SegmentID, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060228D6 RID: 141526 RVA: 0x00331B1C File Offset: 0x0032FD1C
		public FMovieSceneEvaluationFieldSegmentPtr()
		{
		}

		// Token: 0x060228D7 RID: 141527 RVA: 0x00331B24 File Offset: 0x0032FD24
		public FMovieSceneEvaluationFieldSegmentPtr(FMovieSceneSegmentIdentifier SegmentID, FMovieSceneSequenceID SequenceID, FMovieSceneTrackIdentifier TrackIdentifier)
		{
			this.SegmentID = SegmentID;
			base.SequenceID = SequenceID;
			base.TrackIdentifier = TrackIdentifier;
		}

		// Token: 0x060228D8 RID: 141528 RVA: 0x00331B41 File Offset: 0x0032FD41
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneEvaluationFieldSegmentPtr.StaticStruct();
		}

		// Token: 0x060228D9 RID: 141529 RVA: 0x00331B4D File Offset: 0x0032FD4D
		[NullableContext(2)]
		public FMovieSceneEvaluationFieldSegmentPtr(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060228DA RID: 141530 RVA: 0x00331B57 File Offset: 0x0032FD57
		public FMovieSceneEvaluationFieldSegmentPtr(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060228DB RID: 141531 RVA: 0x00331B62 File Offset: 0x0032FD62
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneEvaluationFieldSegmentPtr(Pointer, false, true);
		}

		// Token: 0x060228DC RID: 141532 RVA: 0x00331B6C File Offset: 0x0032FD6C
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneEvaluationFieldSegmentPtr(Pointer, MemoryOwner);
		}

		// Token: 0x04012776 RID: 75638
		public new const string __ObjectPath = "/Script/MovieScene.MovieSceneEvaluationFieldSegmentPtr";

		// Token: 0x04012777 RID: 75639
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012778 RID: 75640
		internal static int __PropertyOffset_SegmentID;

		// Token: 0x04012779 RID: 75641
		[Nullable(2)]
		private FMovieSceneSegmentIdentifier _SegmentID;
	}
}
