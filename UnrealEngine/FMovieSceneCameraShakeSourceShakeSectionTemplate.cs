using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002350 RID: 9040
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneCameraShakeSourceShakeSectionTemplate")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 72)]
	public class FMovieSceneCameraShakeSourceShakeSectionTemplate : FMovieSceneEvalTemplate, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060222A6 RID: 139942 RVA: 0x003284D1 File Offset: 0x003266D1
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneCameraShakeSourceShakeSectionTemplate._ScriptStructPtr != 0) ? FMovieSceneCameraShakeSourceShakeSectionTemplate._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieSceneTracks.MovieSceneCameraShakeSourceShakeSectionTemplate", ref FMovieSceneCameraShakeSourceShakeSectionTemplate._ScriptStructPtr);
		}

		// Token: 0x170083F5 RID: 33781
		// (get) Token: 0x060222A7 RID: 139943 RVA: 0x003284F8 File Offset: 0x003266F8
		// (set) Token: 0x060222A8 RID: 139944 RVA: 0x0032853B File Offset: 0x0032673B
		public FMovieSceneCameraShakeSectionData SourceData
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneCameraShakeSectionData result;
				if ((result = this._SourceData) == null)
				{
					result = (this._SourceData = new FMovieSceneCameraShakeSectionData(base.NativePtr + (IntPtr)FMovieSceneCameraShakeSourceShakeSectionTemplate.__PropertyOffset_SourceData, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneCameraShakeSectionData.StaticStruct(), base.NativePtr + (IntPtr)FMovieSceneCameraShakeSourceShakeSectionTemplate.__PropertyOffset_SourceData, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170083F6 RID: 33782
		// (get) Token: 0x060222A9 RID: 139945 RVA: 0x0032855C File Offset: 0x0032675C
		// (set) Token: 0x060222AA RID: 139946 RVA: 0x0032859F File Offset: 0x0032679F
		public FFrameNumber SectionStartTime
		{
			get
			{
				base.FastCheckIsValid();
				FFrameNumber result;
				if ((result = this._SectionStartTime) == null)
				{
					result = (this._SectionStartTime = new FFrameNumber(base.NativePtr + (IntPtr)FMovieSceneCameraShakeSourceShakeSectionTemplate.__PropertyOffset_SectionStartTime, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FFrameNumber.StaticStruct(), base.NativePtr + (IntPtr)FMovieSceneCameraShakeSourceShakeSectionTemplate.__PropertyOffset_SectionStartTime, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170083F7 RID: 33783
		// (get) Token: 0x060222AB RID: 139947 RVA: 0x003285C0 File Offset: 0x003267C0
		// (set) Token: 0x060222AC RID: 139948 RVA: 0x00328603 File Offset: 0x00326803
		public FFrameNumber SectionEndTime
		{
			get
			{
				base.FastCheckIsValid();
				FFrameNumber result;
				if ((result = this._SectionEndTime) == null)
				{
					result = (this._SectionEndTime = new FFrameNumber(base.NativePtr + (IntPtr)FMovieSceneCameraShakeSourceShakeSectionTemplate.__PropertyOffset_SectionEndTime, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FFrameNumber.StaticStruct(), base.NativePtr + (IntPtr)FMovieSceneCameraShakeSourceShakeSectionTemplate.__PropertyOffset_SectionEndTime, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060222AD RID: 139949 RVA: 0x00328624 File Offset: 0x00326824
		public FMovieSceneCameraShakeSourceShakeSectionTemplate()
		{
		}

		// Token: 0x060222AE RID: 139950 RVA: 0x0032862C File Offset: 0x0032682C
		public FMovieSceneCameraShakeSourceShakeSectionTemplate(FMovieSceneCameraShakeSectionData SourceData, FFrameNumber SectionStartTime, FFrameNumber SectionEndTime, EMovieSceneCompletionMode CompletionMode, [Nullable(new byte[]
		{
			0,
			1
		})] TWeakObjectPtr<UMovieSceneSection> SourceSectionPtr)
		{
			this.SourceData = SourceData;
			this.SectionStartTime = SectionStartTime;
			this.SectionEndTime = SectionEndTime;
			base.CompletionMode = CompletionMode;
			base.SourceSectionPtr = SourceSectionPtr;
		}

		// Token: 0x060222AF RID: 139951 RVA: 0x00328659 File Offset: 0x00326859
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneCameraShakeSourceShakeSectionTemplate.StaticStruct();
		}

		// Token: 0x060222B0 RID: 139952 RVA: 0x00328665 File Offset: 0x00326865
		[NullableContext(2)]
		public FMovieSceneCameraShakeSourceShakeSectionTemplate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060222B1 RID: 139953 RVA: 0x0032866F File Offset: 0x0032686F
		public FMovieSceneCameraShakeSourceShakeSectionTemplate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060222B2 RID: 139954 RVA: 0x0032867A File Offset: 0x0032687A
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneCameraShakeSourceShakeSectionTemplate(Pointer, false, true);
		}

		// Token: 0x060222B3 RID: 139955 RVA: 0x00328684 File Offset: 0x00326884
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneCameraShakeSourceShakeSectionTemplate(Pointer, MemoryOwner);
		}

		// Token: 0x040123C7 RID: 74695
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneCameraShakeSourceShakeSectionTemplate";

		// Token: 0x040123C8 RID: 74696
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040123C9 RID: 74697
		internal static int __PropertyOffset_SourceData;

		// Token: 0x040123CA RID: 74698
		[Nullable(2)]
		private FMovieSceneCameraShakeSectionData _SourceData;

		// Token: 0x040123CB RID: 74699
		internal static int __PropertyOffset_SectionStartTime;

		// Token: 0x040123CC RID: 74700
		[Nullable(2)]
		private FFrameNumber _SectionStartTime;

		// Token: 0x040123CD RID: 74701
		internal static int __PropertyOffset_SectionEndTime;

		// Token: 0x040123CE RID: 74702
		[Nullable(2)]
		private FFrameNumber _SectionEndTime;
	}
}
