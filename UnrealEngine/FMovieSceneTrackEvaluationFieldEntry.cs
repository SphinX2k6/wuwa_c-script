using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002450 RID: 9296
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieScene.MovieSceneTrackEvaluationFieldEntry")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FMovieSceneTrackEvaluationFieldEntry : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06022D89 RID: 142729 RVA: 0x003387E4 File Offset: 0x003369E4
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneTrackEvaluationFieldEntry._ScriptStructPtr != 0) ? FMovieSceneTrackEvaluationFieldEntry._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieScene.MovieSceneTrackEvaluationFieldEntry", ref FMovieSceneTrackEvaluationFieldEntry._ScriptStructPtr);
		}

		// Token: 0x170085F9 RID: 34297
		// (get) Token: 0x06022D8A RID: 142730 RVA: 0x00338808 File Offset: 0x00336A08
		// (set) Token: 0x06022D8B RID: 142731 RVA: 0x0033881C File Offset: 0x00336A1C
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

		// Token: 0x170085FA RID: 34298
		// (get) Token: 0x06022D8C RID: 142732 RVA: 0x00338834 File Offset: 0x00336A34
		// (set) Token: 0x06022D8D RID: 142733 RVA: 0x00338877 File Offset: 0x00336A77
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

		// Token: 0x170085FB RID: 34299
		// (get) Token: 0x06022D8E RID: 142734 RVA: 0x00338898 File Offset: 0x00336A98
		// (set) Token: 0x06022D8F RID: 142735 RVA: 0x003388DB File Offset: 0x00336ADB
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

		// Token: 0x170085FC RID: 34300
		// (get) Token: 0x06022D90 RID: 142736 RVA: 0x003388FC File Offset: 0x00336AFC
		// (set) Token: 0x06022D91 RID: 142737 RVA: 0x0033890C File Offset: 0x00336B0C
		public unsafe ESectionEvaluationFlags Flags
		{
			get
			{
				return (ESectionEvaluationFlags)(*(base.NativePtr + (IntPtr)FMovieSceneTrackEvaluationFieldEntry.__PropertyOffset_Flags));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneTrackEvaluationFieldEntry.__PropertyOffset_Flags) = (byte)value;
			}
		}

		// Token: 0x170085FD RID: 34301
		// (get) Token: 0x06022D92 RID: 142738 RVA: 0x0033891D File Offset: 0x00336B1D
		// (set) Token: 0x06022D93 RID: 142739 RVA: 0x0033892D File Offset: 0x00336B2D
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

		// Token: 0x06022D94 RID: 142740 RVA: 0x0033893E File Offset: 0x00336B3E
		public FMovieSceneTrackEvaluationFieldEntry()
		{
		}

		// Token: 0x06022D95 RID: 142741 RVA: 0x00338946 File Offset: 0x00336B46
		public FMovieSceneTrackEvaluationFieldEntry(UMovieSceneSection Section, FFrameNumberRange Range, FFrameNumber ForcedTime, ESectionEvaluationFlags Flags, short LegacySortOrder)
		{
			this.Section = Section;
			this.Range = Range;
			this.ForcedTime = ForcedTime;
			this.Flags = Flags;
			this.LegacySortOrder = LegacySortOrder;
		}

		// Token: 0x06022D96 RID: 142742 RVA: 0x00338973 File Offset: 0x00336B73
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneTrackEvaluationFieldEntry.StaticStruct();
		}

		// Token: 0x06022D97 RID: 142743 RVA: 0x0033897F File Offset: 0x00336B7F
		[NullableContext(2)]
		public FMovieSceneTrackEvaluationFieldEntry(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06022D98 RID: 142744 RVA: 0x00338989 File Offset: 0x00336B89
		public FMovieSceneTrackEvaluationFieldEntry(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06022D99 RID: 142745 RVA: 0x00338994 File Offset: 0x00336B94
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneTrackEvaluationFieldEntry(Pointer, false, true);
		}

		// Token: 0x06022D9A RID: 142746 RVA: 0x0033899E File Offset: 0x00336B9E
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneTrackEvaluationFieldEntry(Pointer, MemoryOwner);
		}

		// Token: 0x040129B5 RID: 76213
		public const string __ObjectPath = "/Script/MovieScene.MovieSceneTrackEvaluationFieldEntry";

		// Token: 0x040129B6 RID: 76214
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040129B7 RID: 76215
		internal static int __PropertyOffset_Section;

		// Token: 0x040129B8 RID: 76216
		internal static int __PropertyOffset_Range;

		// Token: 0x040129B9 RID: 76217
		[Nullable(2)]
		private FFrameNumberRange _Range;

		// Token: 0x040129BA RID: 76218
		internal static int __PropertyOffset_ForcedTime;

		// Token: 0x040129BB RID: 76219
		[Nullable(2)]
		private FFrameNumber _ForcedTime;

		// Token: 0x040129BC RID: 76220
		internal static int __PropertyOffset_Flags;

		// Token: 0x040129BD RID: 76221
		internal static int __PropertyOffset_LegacySortOrder;
	}
}
