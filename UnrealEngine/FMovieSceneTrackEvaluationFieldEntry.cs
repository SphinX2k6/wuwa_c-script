using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000794 RID: 1940
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieScene.MovieSceneTrackEvaluationFieldEntry")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FMovieSceneTrackEvaluationFieldEntry : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600A789 RID: 42889 RVA: 0x000F745D File Offset: 0x000F565D
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneTrackEvaluationFieldEntry._ScriptStructPtr != 0) ? FMovieSceneTrackEvaluationFieldEntry._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieScene.MovieSceneTrackEvaluationFieldEntry", ref FMovieSceneTrackEvaluationFieldEntry._ScriptStructPtr);
		}

		// Token: 0x17001F26 RID: 7974
		// (get) Token: 0x0600A78A RID: 42890 RVA: 0x000F7481 File Offset: 0x000F5681
		// (set) Token: 0x0600A78B RID: 42891 RVA: 0x000F7495 File Offset: 0x000F5695
		[Nullable(2)]
		public unsafe UMovieSceneSection Section
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMovieSceneSection>(base.NativePtr / (IntPtr)sizeof(void*) + FMovieSceneTrackEvaluationFieldEntry.__PropertyOffset_Section);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FMovieSceneTrackEvaluationFieldEntry.__PropertyOffset_Section, value);
			}
		}

		// Token: 0x17001F27 RID: 7975
		// (get) Token: 0x0600A78C RID: 42892 RVA: 0x000F74AC File Offset: 0x000F56AC
		// (set) Token: 0x0600A78D RID: 42893 RVA: 0x000F74EF File Offset: 0x000F56EF
		public FFrameNumberRange Range
		{
			get
			{
				base.FastCheckIsValid();
				FFrameNumberRange result;
				if ((result = this._Range) == null)
				{
					result = (this._Range = new FFrameNumberRange(base.NativePtr + (IntPtr)FMovieSceneTrackEvaluationFieldEntry.__PropertyOffset_Range, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FFrameNumberRange.StaticStruct(), base.NativePtr + (IntPtr)FMovieSceneTrackEvaluationFieldEntry.__PropertyOffset_Range, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001F28 RID: 7976
		// (get) Token: 0x0600A78E RID: 42894 RVA: 0x000F7510 File Offset: 0x000F5710
		// (set) Token: 0x0600A78F RID: 42895 RVA: 0x000F7553 File Offset: 0x000F5753
		public FFrameNumber ForcedTime
		{
			get
			{
				base.FastCheckIsValid();
				FFrameNumber result;
				if ((result = this._ForcedTime) == null)
				{
					result = (this._ForcedTime = new FFrameNumber(base.NativePtr + (IntPtr)FMovieSceneTrackEvaluationFieldEntry.__PropertyOffset_ForcedTime, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FFrameNumber.StaticStruct(), base.NativePtr + (IntPtr)FMovieSceneTrackEvaluationFieldEntry.__PropertyOffset_ForcedTime, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001F29 RID: 7977
		// (get) Token: 0x0600A790 RID: 42896 RVA: 0x000F7574 File Offset: 0x000F5774
		// (set) Token: 0x0600A791 RID: 42897 RVA: 0x000F7584 File Offset: 0x000F5784
		public unsafe short LegacySortOrder
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneTrackEvaluationFieldEntry.__PropertyOffset_LegacySortOrder);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneTrackEvaluationFieldEntry.__PropertyOffset_LegacySortOrder) = value;
			}
		}

		// Token: 0x0600A792 RID: 42898 RVA: 0x000F7595 File Offset: 0x000F5795
		public FMovieSceneTrackEvaluationFieldEntry()
		{
		}

		// Token: 0x0600A793 RID: 42899 RVA: 0x000F759D File Offset: 0x000F579D
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneTrackEvaluationFieldEntry.StaticStruct();
		}

		// Token: 0x0600A794 RID: 42900 RVA: 0x000F75A9 File Offset: 0x000F57A9
		[NullableContext(2)]
		public FMovieSceneTrackEvaluationFieldEntry(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600A795 RID: 42901 RVA: 0x000F75B3 File Offset: 0x000F57B3
		public FMovieSceneTrackEvaluationFieldEntry(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600A796 RID: 42902 RVA: 0x000F75BE File Offset: 0x000F57BE
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneTrackEvaluationFieldEntry(Pointer, false, true);
		}

		// Token: 0x0600A797 RID: 42903 RVA: 0x000F75C8 File Offset: 0x000F57C8
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneTrackEvaluationFieldEntry(Pointer, MemoryOwner);
		}

		// Token: 0x040047C7 RID: 18375
		public const string __ObjectPath = "/Script/MovieScene.MovieSceneTrackEvaluationFieldEntry";

		// Token: 0x040047C8 RID: 18376
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040047C9 RID: 18377
		internal static int __PropertyOffset_Section;

		// Token: 0x040047CA RID: 18378
		internal static int __PropertyOffset_Range;

		// Token: 0x040047CB RID: 18379
		[Nullable(2)]
		private FFrameNumberRange _Range;

		// Token: 0x040047CC RID: 18380
		internal static int __PropertyOffset_ForcedTime;

		// Token: 0x040047CD RID: 18381
		[Nullable(2)]
		private FFrameNumber _ForcedTime;

		// Token: 0x040047CE RID: 18382
		internal static int __PropertyOffset_LegacySortOrder;
	}
}
