using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020023FD RID: 9213
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieScene.MovieSceneEvaluationGroup")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FMovieSceneEvaluationGroup : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060228F3 RID: 141555 RVA: 0x00331D4E File Offset: 0x0032FF4E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneEvaluationGroup._ScriptStructPtr != 0) ? FMovieSceneEvaluationGroup._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieScene.MovieSceneEvaluationGroup", ref FMovieSceneEvaluationGroup._ScriptStructPtr);
		}

		// Token: 0x1700850C RID: 34060
		// (get) Token: 0x060228F4 RID: 141556 RVA: 0x00331D74 File Offset: 0x0032FF74
		// (set) Token: 0x060228F5 RID: 141557 RVA: 0x00331DB7 File Offset: 0x0032FFB7
		public TArray<FMovieSceneEvaluationGroupLUTIndex> LUTIndices
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FMovieSceneEvaluationGroupLUTIndex> result;
				if ((result = this._LUTIndices) == null)
				{
					result = (this._LUTIndices = new TArray<FMovieSceneEvaluationGroupLUTIndex>(base.NativePtr + (IntPtr)FMovieSceneEvaluationGroup.__PropertyOffset_LUTIndices, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.LUTIndices.CopyAssign(value);
			}
		}

		// Token: 0x1700850D RID: 34061
		// (get) Token: 0x060228F6 RID: 141558 RVA: 0x00331DC8 File Offset: 0x0032FFC8
		// (set) Token: 0x060228F7 RID: 141559 RVA: 0x00331E0B File Offset: 0x0033000B
		public TArray<FMovieSceneFieldEntry_EvaluationTrack> TrackLUT
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FMovieSceneFieldEntry_EvaluationTrack> result;
				if ((result = this._TrackLUT) == null)
				{
					result = (this._TrackLUT = new TArray<FMovieSceneFieldEntry_EvaluationTrack>(base.NativePtr + (IntPtr)FMovieSceneEvaluationGroup.__PropertyOffset_TrackLUT, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.TrackLUT.CopyAssign(value);
			}
		}

		// Token: 0x1700850E RID: 34062
		// (get) Token: 0x060228F8 RID: 141560 RVA: 0x00331E1C File Offset: 0x0033001C
		// (set) Token: 0x060228F9 RID: 141561 RVA: 0x00331E5F File Offset: 0x0033005F
		public TArray<FMovieSceneFieldEntry_ChildTemplate> SectionLUT
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FMovieSceneFieldEntry_ChildTemplate> result;
				if ((result = this._SectionLUT) == null)
				{
					result = (this._SectionLUT = new TArray<FMovieSceneFieldEntry_ChildTemplate>(base.NativePtr + (IntPtr)FMovieSceneEvaluationGroup.__PropertyOffset_SectionLUT, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SectionLUT.CopyAssign(value);
			}
		}

		// Token: 0x060228FA RID: 141562 RVA: 0x00331E6D File Offset: 0x0033006D
		public FMovieSceneEvaluationGroup()
		{
		}

		// Token: 0x060228FB RID: 141563 RVA: 0x00331E75 File Offset: 0x00330075
		public FMovieSceneEvaluationGroup(TArray<FMovieSceneEvaluationGroupLUTIndex> LUTIndices, TArray<FMovieSceneFieldEntry_EvaluationTrack> TrackLUT, TArray<FMovieSceneFieldEntry_ChildTemplate> SectionLUT)
		{
			this.LUTIndices = LUTIndices;
			this.TrackLUT = TrackLUT;
			this.SectionLUT = SectionLUT;
		}

		// Token: 0x060228FC RID: 141564 RVA: 0x00331E92 File Offset: 0x00330092
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneEvaluationGroup.StaticStruct();
		}

		// Token: 0x060228FD RID: 141565 RVA: 0x00331E9E File Offset: 0x0033009E
		[NullableContext(2)]
		public FMovieSceneEvaluationGroup(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060228FE RID: 141566 RVA: 0x00331EA8 File Offset: 0x003300A8
		public FMovieSceneEvaluationGroup(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060228FF RID: 141567 RVA: 0x00331EB3 File Offset: 0x003300B3
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneEvaluationGroup(Pointer, false, true);
		}

		// Token: 0x06022900 RID: 141568 RVA: 0x00331EBD File Offset: 0x003300BD
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneEvaluationGroup(Pointer, MemoryOwner);
		}

		// Token: 0x04012783 RID: 75651
		public const string __ObjectPath = "/Script/MovieScene.MovieSceneEvaluationGroup";

		// Token: 0x04012784 RID: 75652
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012785 RID: 75653
		internal static int __PropertyOffset_LUTIndices;

		// Token: 0x04012786 RID: 75654
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FMovieSceneEvaluationGroupLUTIndex> _LUTIndices;

		// Token: 0x04012787 RID: 75655
		internal static int __PropertyOffset_TrackLUT;

		// Token: 0x04012788 RID: 75656
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FMovieSceneFieldEntry_EvaluationTrack> _TrackLUT;

		// Token: 0x04012789 RID: 75657
		internal static int __PropertyOffset_SectionLUT;

		// Token: 0x0401278A RID: 75658
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FMovieSceneFieldEntry_ChildTemplate> _SectionLUT;
	}
}
