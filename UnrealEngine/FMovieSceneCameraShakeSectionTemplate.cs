using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200234E RID: 9038
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneCameraShakeSectionTemplate")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 72)]
	public class FMovieSceneCameraShakeSectionTemplate : FMovieSceneAdditiveCameraAnimationTemplate, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06022293 RID: 139923 RVA: 0x003282A6 File Offset: 0x003264A6
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneCameraShakeSectionTemplate._ScriptStructPtr != 0) ? FMovieSceneCameraShakeSectionTemplate._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieSceneTracks.MovieSceneCameraShakeSectionTemplate", ref FMovieSceneCameraShakeSectionTemplate._ScriptStructPtr);
		}

		// Token: 0x170083F2 RID: 33778
		// (get) Token: 0x06022294 RID: 139924 RVA: 0x003282CC File Offset: 0x003264CC
		// (set) Token: 0x06022295 RID: 139925 RVA: 0x0032830F File Offset: 0x0032650F
		public FMovieSceneCameraShakeSectionData SourceData
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneCameraShakeSectionData result;
				if ((result = this._SourceData) == null)
				{
					result = (this._SourceData = new FMovieSceneCameraShakeSectionData(base.NativePtr + (IntPtr)FMovieSceneCameraShakeSectionTemplate.__PropertyOffset_SourceData, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneCameraShakeSectionData.StaticStruct(), base.NativePtr + (IntPtr)FMovieSceneCameraShakeSectionTemplate.__PropertyOffset_SourceData, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170083F3 RID: 33779
		// (get) Token: 0x06022296 RID: 139926 RVA: 0x00328330 File Offset: 0x00326530
		// (set) Token: 0x06022297 RID: 139927 RVA: 0x00328373 File Offset: 0x00326573
		public FFrameNumber SectionStartTime
		{
			get
			{
				base.FastCheckIsValid();
				FFrameNumber result;
				if ((result = this._SectionStartTime) == null)
				{
					result = (this._SectionStartTime = new FFrameNumber(base.NativePtr + (IntPtr)FMovieSceneCameraShakeSectionTemplate.__PropertyOffset_SectionStartTime, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FFrameNumber.StaticStruct(), base.NativePtr + (IntPtr)FMovieSceneCameraShakeSectionTemplate.__PropertyOffset_SectionStartTime, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06022298 RID: 139928 RVA: 0x00328394 File Offset: 0x00326594
		public FMovieSceneCameraShakeSectionTemplate()
		{
		}

		// Token: 0x06022299 RID: 139929 RVA: 0x0032839C File Offset: 0x0032659C
		public FMovieSceneCameraShakeSectionTemplate(FMovieSceneCameraShakeSectionData SourceData, FFrameNumber SectionStartTime, EMovieSceneCompletionMode CompletionMode, [Nullable(new byte[]
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

		// Token: 0x0602229A RID: 139930 RVA: 0x003283C1 File Offset: 0x003265C1
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneCameraShakeSectionTemplate.StaticStruct();
		}

		// Token: 0x0602229B RID: 139931 RVA: 0x003283CD File Offset: 0x003265CD
		[NullableContext(2)]
		public FMovieSceneCameraShakeSectionTemplate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602229C RID: 139932 RVA: 0x003283D7 File Offset: 0x003265D7
		public FMovieSceneCameraShakeSectionTemplate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602229D RID: 139933 RVA: 0x003283E2 File Offset: 0x003265E2
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneCameraShakeSectionTemplate(Pointer, false, true);
		}

		// Token: 0x0602229E RID: 139934 RVA: 0x003283EC File Offset: 0x003265EC
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneCameraShakeSectionTemplate(Pointer, MemoryOwner);
		}

		// Token: 0x040123BC RID: 74684
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneCameraShakeSectionTemplate";

		// Token: 0x040123BD RID: 74685
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040123BE RID: 74686
		internal static int __PropertyOffset_SourceData;

		// Token: 0x040123BF RID: 74687
		[Nullable(2)]
		private FMovieSceneCameraShakeSectionData _SourceData;

		// Token: 0x040123C0 RID: 74688
		internal static int __PropertyOffset_SectionStartTime;

		// Token: 0x040123C1 RID: 74689
		[Nullable(2)]
		private FFrameNumber _SectionStartTime;
	}
}
