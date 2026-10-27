using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002347 RID: 9031
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneCameraAnimSectionTemplate")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 72)]
	public class FMovieSceneCameraAnimSectionTemplate : FMovieSceneAdditiveCameraAnimationTemplate, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06022240 RID: 139840 RVA: 0x00327A6E File Offset: 0x00325C6E
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneCameraAnimSectionTemplate._ScriptStructPtr != 0) ? FMovieSceneCameraAnimSectionTemplate._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieSceneTracks.MovieSceneCameraAnimSectionTemplate", ref FMovieSceneCameraAnimSectionTemplate._ScriptStructPtr);
		}

		// Token: 0x170083DF RID: 33759
		// (get) Token: 0x06022241 RID: 139841 RVA: 0x00327A94 File Offset: 0x00325C94
		// (set) Token: 0x06022242 RID: 139842 RVA: 0x00327AD7 File Offset: 0x00325CD7
		public FMovieSceneCameraAnimSectionData SourceData
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneCameraAnimSectionData result;
				if ((result = this._SourceData) == null)
				{
					result = (this._SourceData = new FMovieSceneCameraAnimSectionData(base.NativePtr + (IntPtr)FMovieSceneCameraAnimSectionTemplate.__PropertyOffset_SourceData, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneCameraAnimSectionData.StaticStruct(), base.NativePtr + (IntPtr)FMovieSceneCameraAnimSectionTemplate.__PropertyOffset_SourceData, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170083E0 RID: 33760
		// (get) Token: 0x06022243 RID: 139843 RVA: 0x00327AF8 File Offset: 0x00325CF8
		// (set) Token: 0x06022244 RID: 139844 RVA: 0x00327B3B File Offset: 0x00325D3B
		public FFrameNumber SectionStartTime
		{
			get
			{
				base.FastCheckIsValid();
				FFrameNumber result;
				if ((result = this._SectionStartTime) == null)
				{
					result = (this._SectionStartTime = new FFrameNumber(base.NativePtr + (IntPtr)FMovieSceneCameraAnimSectionTemplate.__PropertyOffset_SectionStartTime, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FFrameNumber.StaticStruct(), base.NativePtr + (IntPtr)FMovieSceneCameraAnimSectionTemplate.__PropertyOffset_SectionStartTime, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06022245 RID: 139845 RVA: 0x00327B5C File Offset: 0x00325D5C
		public FMovieSceneCameraAnimSectionTemplate()
		{
		}

		// Token: 0x06022246 RID: 139846 RVA: 0x00327B64 File Offset: 0x00325D64
		public FMovieSceneCameraAnimSectionTemplate(FMovieSceneCameraAnimSectionData SourceData, FFrameNumber SectionStartTime, EMovieSceneCompletionMode CompletionMode, [Nullable(new byte[]
		{
			0,
			1
		})] TWeakObjectPtr<UMovieSceneSection> SourceSectionPtr)
		{
			this.SourceData = SourceData;
			this.SectionStartTime = SectionStartTime;
			base.CompletionMode = CompletionMode;
			base.SourceSectionPtr = SourceSectionPtr;
		}

		// Token: 0x06022247 RID: 139847 RVA: 0x00327B89 File Offset: 0x00325D89
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneCameraAnimSectionTemplate.StaticStruct();
		}

		// Token: 0x06022248 RID: 139848 RVA: 0x00327B95 File Offset: 0x00325D95
		[NullableContext(2)]
		public FMovieSceneCameraAnimSectionTemplate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06022249 RID: 139849 RVA: 0x00327B9F File Offset: 0x00325D9F
		public FMovieSceneCameraAnimSectionTemplate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602224A RID: 139850 RVA: 0x00327BAA File Offset: 0x00325DAA
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneCameraAnimSectionTemplate(Pointer, false, true);
		}

		// Token: 0x0602224B RID: 139851 RVA: 0x00327BB4 File Offset: 0x00325DB4
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneCameraAnimSectionTemplate(Pointer, MemoryOwner);
		}

		// Token: 0x0401238C RID: 74636
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneCameraAnimSectionTemplate";

		// Token: 0x0401238D RID: 74637
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401238E RID: 74638
		internal static int __PropertyOffset_SourceData;

		// Token: 0x0401238F RID: 74639
		[Nullable(2)]
		private FMovieSceneCameraAnimSectionData _SourceData;

		// Token: 0x04012390 RID: 74640
		internal static int __PropertyOffset_SectionStartTime;

		// Token: 0x04012391 RID: 74641
		[Nullable(2)]
		private FFrameNumber _SectionStartTime;
	}
}
