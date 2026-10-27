using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001C09 RID: 7177
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.MovieSceneKuroMediaAlignSectionTemplate")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FMovieSceneKuroMediaAlignSectionTemplate : FMovieSceneEvalTemplate, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601BB14 RID: 113428 RVA: 0x0028C221 File Offset: 0x0028A421
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneKuroMediaAlignSectionTemplate._ScriptStructPtr != 0) ? FMovieSceneKuroMediaAlignSectionTemplate._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.MovieSceneKuroMediaAlignSectionTemplate", ref FMovieSceneKuroMediaAlignSectionTemplate._ScriptStructPtr);
		}

		// Token: 0x17006FB1 RID: 28593
		// (get) Token: 0x0601BB15 RID: 113429 RVA: 0x0028C245 File Offset: 0x0028A445
		// (set) Token: 0x0601BB16 RID: 113430 RVA: 0x0028C259 File Offset: 0x0028A459
		public unsafe FName AlignKey
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneKuroMediaAlignSectionTemplate.__PropertyOffset_AlignKey);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneKuroMediaAlignSectionTemplate.__PropertyOffset_AlignKey) = value;
			}
		}

		// Token: 0x17006FB2 RID: 28594
		// (get) Token: 0x0601BB17 RID: 113431 RVA: 0x0028C270 File Offset: 0x0028A470
		// (set) Token: 0x0601BB18 RID: 113432 RVA: 0x0028C2B3 File Offset: 0x0028A4B3
		public FFrameNumber SectionStartFrame
		{
			get
			{
				base.FastCheckIsValid();
				FFrameNumber result;
				if ((result = this._SectionStartFrame) == null)
				{
					result = (this._SectionStartFrame = new FFrameNumber(base.NativePtr + (IntPtr)FMovieSceneKuroMediaAlignSectionTemplate.__PropertyOffset_SectionStartFrame, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FFrameNumber.StaticStruct(), base.NativePtr + (IntPtr)FMovieSceneKuroMediaAlignSectionTemplate.__PropertyOffset_SectionStartFrame, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006FB3 RID: 28595
		// (get) Token: 0x0601BB19 RID: 113433 RVA: 0x0028C2D4 File Offset: 0x0028A4D4
		// (set) Token: 0x0601BB1A RID: 113434 RVA: 0x0028C317 File Offset: 0x0028A517
		public FFrameNumber SectionEndFrame
		{
			get
			{
				base.FastCheckIsValid();
				FFrameNumber result;
				if ((result = this._SectionEndFrame) == null)
				{
					result = (this._SectionEndFrame = new FFrameNumber(base.NativePtr + (IntPtr)FMovieSceneKuroMediaAlignSectionTemplate.__PropertyOffset_SectionEndFrame, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FFrameNumber.StaticStruct(), base.NativePtr + (IntPtr)FMovieSceneKuroMediaAlignSectionTemplate.__PropertyOffset_SectionEndFrame, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006FB4 RID: 28596
		// (get) Token: 0x0601BB1B RID: 113435 RVA: 0x0028C338 File Offset: 0x0028A538
		// (set) Token: 0x0601BB1C RID: 113436 RVA: 0x0028C37B File Offset: 0x0028A57B
		public FFrameNumber StartFrameOffset
		{
			get
			{
				base.FastCheckIsValid();
				FFrameNumber result;
				if ((result = this._StartFrameOffset) == null)
				{
					result = (this._StartFrameOffset = new FFrameNumber(base.NativePtr + (IntPtr)FMovieSceneKuroMediaAlignSectionTemplate.__PropertyOffset_StartFrameOffset, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FFrameNumber.StaticStruct(), base.NativePtr + (IntPtr)FMovieSceneKuroMediaAlignSectionTemplate.__PropertyOffset_StartFrameOffset, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0601BB1D RID: 113437 RVA: 0x0028C39C File Offset: 0x0028A59C
		public FMovieSceneKuroMediaAlignSectionTemplate()
		{
		}

		// Token: 0x0601BB1E RID: 113438 RVA: 0x0028C3A4 File Offset: 0x0028A5A4
		public FMovieSceneKuroMediaAlignSectionTemplate(FName AlignKey, FFrameNumber SectionStartFrame, FFrameNumber SectionEndFrame, FFrameNumber StartFrameOffset, EMovieSceneCompletionMode CompletionMode, [Nullable(new byte[]
		{
			0,
			1
		})] TWeakObjectPtr<UMovieSceneSection> SourceSectionPtr)
		{
			this.AlignKey = AlignKey;
			this.SectionStartFrame = SectionStartFrame;
			this.SectionEndFrame = SectionEndFrame;
			this.StartFrameOffset = StartFrameOffset;
			base.CompletionMode = CompletionMode;
			base.SourceSectionPtr = SourceSectionPtr;
		}

		// Token: 0x0601BB1F RID: 113439 RVA: 0x0028C3D9 File Offset: 0x0028A5D9
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneKuroMediaAlignSectionTemplate.StaticStruct();
		}

		// Token: 0x0601BB20 RID: 113440 RVA: 0x0028C3E5 File Offset: 0x0028A5E5
		[NullableContext(2)]
		public FMovieSceneKuroMediaAlignSectionTemplate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601BB21 RID: 113441 RVA: 0x0028C3EF File Offset: 0x0028A5EF
		public FMovieSceneKuroMediaAlignSectionTemplate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601BB22 RID: 113442 RVA: 0x0028C3FA File Offset: 0x0028A5FA
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneKuroMediaAlignSectionTemplate(Pointer, false, true);
		}

		// Token: 0x0601BB23 RID: 113443 RVA: 0x0028C404 File Offset: 0x0028A604
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneKuroMediaAlignSectionTemplate(Pointer, MemoryOwner);
		}

		// Token: 0x0400EE4C RID: 61004
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.MovieSceneKuroMediaAlignSectionTemplate";

		// Token: 0x0400EE4D RID: 61005
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400EE4E RID: 61006
		internal static int __PropertyOffset_AlignKey;

		// Token: 0x0400EE4F RID: 61007
		internal static int __PropertyOffset_SectionStartFrame;

		// Token: 0x0400EE50 RID: 61008
		[Nullable(2)]
		private FFrameNumber _SectionStartFrame;

		// Token: 0x0400EE51 RID: 61009
		internal static int __PropertyOffset_SectionEndFrame;

		// Token: 0x0400EE52 RID: 61010
		[Nullable(2)]
		private FFrameNumber _SectionEndFrame;

		// Token: 0x0400EE53 RID: 61011
		internal static int __PropertyOffset_StartFrameOffset;

		// Token: 0x0400EE54 RID: 61012
		[Nullable(2)]
		private FFrameNumber _StartFrameOffset;
	}
}
