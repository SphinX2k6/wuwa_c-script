using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020026F7 RID: 9975
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SequenceDialogue.MovieSceneQteTemplateParams")]
	[UnrealStructLayout(208, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 208)]
	public class FMovieSceneQteTemplateParams : FMovieSceneQteParams, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06024FFF RID: 151551 RVA: 0x0036BC53 File Offset: 0x00369E53
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneQteTemplateParams._ScriptStructPtr != 0) ? FMovieSceneQteTemplateParams._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SequenceDialogue.MovieSceneQteTemplateParams", ref FMovieSceneQteTemplateParams._ScriptStructPtr);
		}

		// Token: 0x17008EE1 RID: 36577
		// (get) Token: 0x06025000 RID: 151552 RVA: 0x0036BC78 File Offset: 0x00369E78
		// (set) Token: 0x06025001 RID: 151553 RVA: 0x0036BCBB File Offset: 0x00369EBB
		public FFrameNumber SectionStartTime
		{
			get
			{
				base.FastCheckIsValid();
				FFrameNumber result;
				if ((result = this._SectionStartTime) == null)
				{
					result = (this._SectionStartTime = new FFrameNumber(base.NativePtr + (IntPtr)FMovieSceneQteTemplateParams.__PropertyOffset_SectionStartTime, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FFrameNumber.StaticStruct(), base.NativePtr + (IntPtr)FMovieSceneQteTemplateParams.__PropertyOffset_SectionStartTime, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008EE2 RID: 36578
		// (get) Token: 0x06025002 RID: 151554 RVA: 0x0036BCDC File Offset: 0x00369EDC
		// (set) Token: 0x06025003 RID: 151555 RVA: 0x0036BD1F File Offset: 0x00369F1F
		public FFrameNumber SectionEndTime
		{
			get
			{
				base.FastCheckIsValid();
				FFrameNumber result;
				if ((result = this._SectionEndTime) == null)
				{
					result = (this._SectionEndTime = new FFrameNumber(base.NativePtr + (IntPtr)FMovieSceneQteTemplateParams.__PropertyOffset_SectionEndTime, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FFrameNumber.StaticStruct(), base.NativePtr + (IntPtr)FMovieSceneQteTemplateParams.__PropertyOffset_SectionEndTime, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06025004 RID: 151556 RVA: 0x0036BD40 File Offset: 0x00369F40
		public FMovieSceneQteTemplateParams()
		{
		}

		// Token: 0x06025005 RID: 151557 RVA: 0x0036BD48 File Offset: 0x00369F48
		public FMovieSceneQteTemplateParams(FFrameNumber SectionStartTime, FFrameNumber SectionEndTime, int QteId, bool IsGroupQte, int SubtitleId, FMovieSceneObjectBindingID AttachActor, bool IsUpdateWithProgress, TArray<FMovieSceneQteAnimParams> Anims, ULevelSequence LevelSequence, FQteSpineInfo SpineInfo, TArray<FMovieSceneSubQteParams> SubQteParams)
		{
			this.SectionStartTime = SectionStartTime;
			this.SectionEndTime = SectionEndTime;
			base.QteId = QteId;
			base.IsGroupQte = IsGroupQte;
			base.SubtitleId = SubtitleId;
			base.AttachActor = AttachActor;
			base.IsUpdateWithProgress = IsUpdateWithProgress;
			base.Anims = Anims;
			base.LevelSequence = LevelSequence;
			base.SpineInfo = SpineInfo;
			base.SubQteParams = SubQteParams;
		}

		// Token: 0x06025006 RID: 151558 RVA: 0x0036BDB0 File Offset: 0x00369FB0
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneQteTemplateParams.StaticStruct();
		}

		// Token: 0x06025007 RID: 151559 RVA: 0x0036BDBC File Offset: 0x00369FBC
		[NullableContext(2)]
		public FMovieSceneQteTemplateParams(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06025008 RID: 151560 RVA: 0x0036BDC6 File Offset: 0x00369FC6
		public FMovieSceneQteTemplateParams(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06025009 RID: 151561 RVA: 0x0036BDD1 File Offset: 0x00369FD1
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneQteTemplateParams(Pointer, false, true);
		}

		// Token: 0x0602500A RID: 151562 RVA: 0x0036BDDB File Offset: 0x00369FDB
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneQteTemplateParams(Pointer, MemoryOwner);
		}

		// Token: 0x04013F05 RID: 81669
		public new const string __ObjectPath = "/Script/SequenceDialogue.MovieSceneQteTemplateParams";

		// Token: 0x04013F06 RID: 81670
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04013F07 RID: 81671
		internal static int __PropertyOffset_SectionStartTime;

		// Token: 0x04013F08 RID: 81672
		[Nullable(2)]
		private FFrameNumber _SectionStartTime;

		// Token: 0x04013F09 RID: 81673
		internal static int __PropertyOffset_SectionEndTime;

		// Token: 0x04013F0A RID: 81674
		[Nullable(2)]
		private FFrameNumber _SectionEndTime;
	}
}
