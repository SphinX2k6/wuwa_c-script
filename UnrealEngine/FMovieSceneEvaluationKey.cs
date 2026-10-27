using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020023FF RID: 9215
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Script/MovieScene.MovieSceneEvaluationKey")]
	[UnrealStructLayout(12, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 12)]
	public class FMovieSceneEvaluationKey : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602290D RID: 141581 RVA: 0x00331F7E File Offset: 0x0033017E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneEvaluationKey._ScriptStructPtr != 0) ? FMovieSceneEvaluationKey._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieScene.MovieSceneEvaluationKey", ref FMovieSceneEvaluationKey._ScriptStructPtr);
		}

		// Token: 0x17008511 RID: 34065
		// (get) Token: 0x0602290E RID: 141582 RVA: 0x00331FA4 File Offset: 0x003301A4
		// (set) Token: 0x0602290F RID: 141583 RVA: 0x00331FE7 File Offset: 0x003301E7
		public FMovieSceneSequenceID SequenceID
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneSequenceID result;
				if ((result = this._SequenceID) == null)
				{
					result = (this._SequenceID = new FMovieSceneSequenceID(base.NativePtr + (IntPtr)FMovieSceneEvaluationKey.__PropertyOffset_SequenceID, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneSequenceID.StaticStruct(), base.NativePtr + (IntPtr)FMovieSceneEvaluationKey.__PropertyOffset_SequenceID, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008512 RID: 34066
		// (get) Token: 0x06022910 RID: 141584 RVA: 0x00332008 File Offset: 0x00330208
		// (set) Token: 0x06022911 RID: 141585 RVA: 0x0033204B File Offset: 0x0033024B
		public FMovieSceneTrackIdentifier TrackIdentifier
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneTrackIdentifier result;
				if ((result = this._TrackIdentifier) == null)
				{
					result = (this._TrackIdentifier = new FMovieSceneTrackIdentifier(base.NativePtr + (IntPtr)FMovieSceneEvaluationKey.__PropertyOffset_TrackIdentifier, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneTrackIdentifier.StaticStruct(), base.NativePtr + (IntPtr)FMovieSceneEvaluationKey.__PropertyOffset_TrackIdentifier, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008513 RID: 34067
		// (get) Token: 0x06022912 RID: 141586 RVA: 0x0033206C File Offset: 0x0033026C
		// (set) Token: 0x06022913 RID: 141587 RVA: 0x0033207C File Offset: 0x0033027C
		public unsafe uint SectionIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneEvaluationKey.__PropertyOffset_SectionIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneEvaluationKey.__PropertyOffset_SectionIndex) = (int)value;
			}
		}

		// Token: 0x06022914 RID: 141588 RVA: 0x0033208D File Offset: 0x0033028D
		public FMovieSceneEvaluationKey()
		{
		}

		// Token: 0x06022915 RID: 141589 RVA: 0x00332095 File Offset: 0x00330295
		public FMovieSceneEvaluationKey(FMovieSceneSequenceID SequenceID, FMovieSceneTrackIdentifier TrackIdentifier, uint SectionIndex)
		{
			this.SequenceID = SequenceID;
			this.TrackIdentifier = TrackIdentifier;
			this.SectionIndex = SectionIndex;
		}

		// Token: 0x06022916 RID: 141590 RVA: 0x003320B2 File Offset: 0x003302B2
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneEvaluationKey.StaticStruct();
		}

		// Token: 0x06022917 RID: 141591 RVA: 0x003320BE File Offset: 0x003302BE
		[NullableContext(2)]
		public FMovieSceneEvaluationKey(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06022918 RID: 141592 RVA: 0x003320C8 File Offset: 0x003302C8
		public FMovieSceneEvaluationKey(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06022919 RID: 141593 RVA: 0x003320D3 File Offset: 0x003302D3
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneEvaluationKey(Pointer, false, true);
		}

		// Token: 0x0602291A RID: 141594 RVA: 0x003320DD File Offset: 0x003302DD
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneEvaluationKey(Pointer, MemoryOwner);
		}

		// Token: 0x0401278F RID: 75663
		public const string __ObjectPath = "/Script/MovieScene.MovieSceneEvaluationKey";

		// Token: 0x04012790 RID: 75664
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012791 RID: 75665
		internal static int __PropertyOffset_SequenceID;

		// Token: 0x04012792 RID: 75666
		[Nullable(2)]
		private FMovieSceneSequenceID _SequenceID;

		// Token: 0x04012793 RID: 75667
		internal static int __PropertyOffset_TrackIdentifier;

		// Token: 0x04012794 RID: 75668
		[Nullable(2)]
		private FMovieSceneTrackIdentifier _TrackIdentifier;

		// Token: 0x04012795 RID: 75669
		internal static int __PropertyOffset_SectionIndex;
	}
}
