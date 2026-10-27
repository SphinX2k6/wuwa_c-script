using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020022A9 RID: 8873
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MediaCompositing.MovieSceneMediaPlayerPropertySectionTemplate")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 80)]
	public class FMovieSceneMediaPlayerPropertySectionTemplate : FMovieScenePropertySectionTemplate, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06021BB6 RID: 138166 RVA: 0x0031DFA0 File Offset: 0x0031C1A0
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneMediaPlayerPropertySectionTemplate._ScriptStructPtr != 0) ? FMovieSceneMediaPlayerPropertySectionTemplate._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MediaCompositing.MovieSceneMediaPlayerPropertySectionTemplate", ref FMovieSceneMediaPlayerPropertySectionTemplate._ScriptStructPtr);
		}

		// Token: 0x170082D9 RID: 33497
		// (get) Token: 0x06021BB7 RID: 138167 RVA: 0x0031DFC4 File Offset: 0x0031C1C4
		// (set) Token: 0x06021BB8 RID: 138168 RVA: 0x0031DFD8 File Offset: 0x0031C1D8
		[Nullable(2)]
		public unsafe UMediaSource MediaSource
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMediaSource>(base.NativePtr / (IntPtr)sizeof(void*) + FMovieSceneMediaPlayerPropertySectionTemplate.__PropertyOffset_MediaSource);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FMovieSceneMediaPlayerPropertySectionTemplate.__PropertyOffset_MediaSource, value);
			}
		}

		// Token: 0x170082DA RID: 33498
		// (get) Token: 0x06021BB9 RID: 138169 RVA: 0x0031DFF0 File Offset: 0x0031C1F0
		// (set) Token: 0x06021BBA RID: 138170 RVA: 0x0031E033 File Offset: 0x0031C233
		public FFrameNumber SectionStartFrame
		{
			get
			{
				base.FastCheckIsValid();
				FFrameNumber result;
				if ((result = this._SectionStartFrame) == null)
				{
					result = (this._SectionStartFrame = new FFrameNumber(base.NativePtr + (IntPtr)FMovieSceneMediaPlayerPropertySectionTemplate.__PropertyOffset_SectionStartFrame, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FFrameNumber.StaticStruct(), base.NativePtr + (IntPtr)FMovieSceneMediaPlayerPropertySectionTemplate.__PropertyOffset_SectionStartFrame, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170082DB RID: 33499
		// (get) Token: 0x06021BBB RID: 138171 RVA: 0x0031E054 File Offset: 0x0031C254
		// (set) Token: 0x06021BBC RID: 138172 RVA: 0x0031E064 File Offset: 0x0031C264
		public unsafe bool bLoop
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneMediaPlayerPropertySectionTemplate.__PropertyOffset_bLoop) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneMediaPlayerPropertySectionTemplate.__PropertyOffset_bLoop) = (value ? 1 : 0);
			}
		}

		// Token: 0x06021BBD RID: 138173 RVA: 0x0031E075 File Offset: 0x0031C275
		public FMovieSceneMediaPlayerPropertySectionTemplate()
		{
		}

		// Token: 0x06021BBE RID: 138174 RVA: 0x0031E07D File Offset: 0x0031C27D
		public FMovieSceneMediaPlayerPropertySectionTemplate(UMediaSource MediaSource, FFrameNumber SectionStartFrame, bool bLoop, FMovieScenePropertySectionData PropertyData, EMovieSceneCompletionMode CompletionMode, [Nullable(new byte[]
		{
			0,
			1
		})] TWeakObjectPtr<UMovieSceneSection> SourceSectionPtr)
		{
			this.MediaSource = MediaSource;
			this.SectionStartFrame = SectionStartFrame;
			this.bLoop = bLoop;
			base.PropertyData = PropertyData;
			base.CompletionMode = CompletionMode;
			base.SourceSectionPtr = SourceSectionPtr;
		}

		// Token: 0x06021BBF RID: 138175 RVA: 0x0031E0B2 File Offset: 0x0031C2B2
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneMediaPlayerPropertySectionTemplate.StaticStruct();
		}

		// Token: 0x06021BC0 RID: 138176 RVA: 0x0031E0BE File Offset: 0x0031C2BE
		[NullableContext(2)]
		public FMovieSceneMediaPlayerPropertySectionTemplate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021BC1 RID: 138177 RVA: 0x0031E0C8 File Offset: 0x0031C2C8
		public FMovieSceneMediaPlayerPropertySectionTemplate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021BC2 RID: 138178 RVA: 0x0031E0D3 File Offset: 0x0031C2D3
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneMediaPlayerPropertySectionTemplate(Pointer, false, true);
		}

		// Token: 0x06021BC3 RID: 138179 RVA: 0x0031E0DD File Offset: 0x0031C2DD
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneMediaPlayerPropertySectionTemplate(Pointer, MemoryOwner);
		}

		// Token: 0x04011FF4 RID: 73716
		public new const string __ObjectPath = "/Script/MediaCompositing.MovieSceneMediaPlayerPropertySectionTemplate";

		// Token: 0x04011FF5 RID: 73717
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04011FF6 RID: 73718
		internal static int __PropertyOffset_MediaSource;

		// Token: 0x04011FF7 RID: 73719
		internal static int __PropertyOffset_SectionStartFrame;

		// Token: 0x04011FF8 RID: 73720
		[Nullable(2)]
		private FFrameNumber _SectionStartFrame;

		// Token: 0x04011FF9 RID: 73721
		internal static int __PropertyOffset_bLoop;
	}
}
