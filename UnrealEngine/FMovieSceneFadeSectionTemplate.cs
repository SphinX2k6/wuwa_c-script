using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200237A RID: 9082
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneFadeSectionTemplate")]
	[UnrealStructLayout(216, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 216)]
	public class FMovieSceneFadeSectionTemplate : FMovieSceneEvalTemplate, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602242C RID: 140332 RVA: 0x0032AA87 File Offset: 0x00328C87
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneFadeSectionTemplate._ScriptStructPtr != 0) ? FMovieSceneFadeSectionTemplate._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieSceneTracks.MovieSceneFadeSectionTemplate", ref FMovieSceneFadeSectionTemplate._ScriptStructPtr);
		}

		// Token: 0x1700842E RID: 33838
		// (get) Token: 0x0602242D RID: 140333 RVA: 0x0032AAAC File Offset: 0x00328CAC
		// (set) Token: 0x0602242E RID: 140334 RVA: 0x0032AAEF File Offset: 0x00328CEF
		public FMovieSceneFloatChannel FadeCurve
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneFloatChannel result;
				if ((result = this._FadeCurve) == null)
				{
					result = (this._FadeCurve = new FMovieSceneFloatChannel(base.NativePtr + (IntPtr)FMovieSceneFadeSectionTemplate.__PropertyOffset_FadeCurve, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneFloatChannel.StaticStruct(), base.NativePtr + (IntPtr)FMovieSceneFadeSectionTemplate.__PropertyOffset_FadeCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700842F RID: 33839
		// (get) Token: 0x0602242F RID: 140335 RVA: 0x0032AB10 File Offset: 0x00328D10
		// (set) Token: 0x06022430 RID: 140336 RVA: 0x0032AB24 File Offset: 0x00328D24
		public unsafe FLinearColor FadeColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneFadeSectionTemplate.__PropertyOffset_FadeColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneFadeSectionTemplate.__PropertyOffset_FadeColor) = value;
			}
		}

		// Token: 0x17008430 RID: 33840
		// (get) Token: 0x06022431 RID: 140337 RVA: 0x0032AB39 File Offset: 0x00328D39
		// (set) Token: 0x06022432 RID: 140338 RVA: 0x0032AB52 File Offset: 0x00328D52
		public unsafe bool bFadeAudio
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMovieSceneFadeSectionTemplate.__PropertyOffset_bFadeAudio) & FMovieSceneFadeSectionTemplate.__PropertyMask_bFadeAudio) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMovieSceneFadeSectionTemplate.__PropertyOffset_bFadeAudio) = ((*(base.NativePtr + (IntPtr)FMovieSceneFadeSectionTemplate.__PropertyOffset_bFadeAudio) & ~FMovieSceneFadeSectionTemplate.__PropertyMask_bFadeAudio) | (value ? FMovieSceneFadeSectionTemplate.__PropertyMask_bFadeAudio : 0));
			}
		}

		// Token: 0x06022433 RID: 140339 RVA: 0x0032AB82 File Offset: 0x00328D82
		public FMovieSceneFadeSectionTemplate()
		{
		}

		// Token: 0x06022434 RID: 140340 RVA: 0x0032AB8A File Offset: 0x00328D8A
		public FMovieSceneFadeSectionTemplate(FMovieSceneFloatChannel FadeCurve, FLinearColor FadeColor, bool bFadeAudio, EMovieSceneCompletionMode CompletionMode, [Nullable(new byte[]
		{
			0,
			1
		})] TWeakObjectPtr<UMovieSceneSection> SourceSectionPtr)
		{
			this.FadeCurve = FadeCurve;
			this.FadeColor = FadeColor;
			this.bFadeAudio = bFadeAudio;
			base.CompletionMode = CompletionMode;
			base.SourceSectionPtr = SourceSectionPtr;
		}

		// Token: 0x06022435 RID: 140341 RVA: 0x0032ABB7 File Offset: 0x00328DB7
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneFadeSectionTemplate.StaticStruct();
		}

		// Token: 0x06022436 RID: 140342 RVA: 0x0032ABC3 File Offset: 0x00328DC3
		[NullableContext(2)]
		public FMovieSceneFadeSectionTemplate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06022437 RID: 140343 RVA: 0x0032ABCD File Offset: 0x00328DCD
		public FMovieSceneFadeSectionTemplate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06022438 RID: 140344 RVA: 0x0032ABD8 File Offset: 0x00328DD8
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneFadeSectionTemplate(Pointer, false, true);
		}

		// Token: 0x06022439 RID: 140345 RVA: 0x0032ABE2 File Offset: 0x00328DE2
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneFadeSectionTemplate(Pointer, MemoryOwner);
		}

		// Token: 0x040124A1 RID: 74913
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneFadeSectionTemplate";

		// Token: 0x040124A2 RID: 74914
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040124A3 RID: 74915
		internal static int __PropertyOffset_FadeCurve;

		// Token: 0x040124A4 RID: 74916
		[Nullable(2)]
		private FMovieSceneFloatChannel _FadeCurve;

		// Token: 0x040124A5 RID: 74917
		internal static int __PropertyOffset_FadeColor;

		// Token: 0x040124A6 RID: 74918
		internal static int __PropertyOffset_bFadeAudio;

		// Token: 0x040124A7 RID: 74919
		internal static byte __PropertyMask_bFadeAudio;
	}
}
