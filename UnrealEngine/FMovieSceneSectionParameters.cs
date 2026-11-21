using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000788 RID: 1928
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieScene.MovieSceneSectionParameters")]
	[UnrealStructLayout(36, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 36)]
	public class FMovieSceneSectionParameters : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600A645 RID: 42565 RVA: 0x000F5B2B File Offset: 0x000F3D2B
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneSectionParameters._ScriptStructPtr != 0) ? FMovieSceneSectionParameters._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieScene.MovieSceneSectionParameters", ref FMovieSceneSectionParameters._ScriptStructPtr);
		}

		// Token: 0x17001EE2 RID: 7906
		// (get) Token: 0x0600A646 RID: 42566 RVA: 0x000F5B50 File Offset: 0x000F3D50
		// (set) Token: 0x0600A647 RID: 42567 RVA: 0x000F5B93 File Offset: 0x000F3D93
		public FFrameNumber StartFrameOffset
		{
			get
			{
				base.FastCheckIsValid();
				FFrameNumber result;
				if ((result = this._StartFrameOffset) == null)
				{
					result = (this._StartFrameOffset = new FFrameNumber(base.NativePtr + (IntPtr)FMovieSceneSectionParameters.__PropertyOffset_StartFrameOffset, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FFrameNumber.StaticStruct(), base.NativePtr + (IntPtr)FMovieSceneSectionParameters.__PropertyOffset_StartFrameOffset, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001EE3 RID: 7907
		// (get) Token: 0x0600A648 RID: 42568 RVA: 0x000F5BB4 File Offset: 0x000F3DB4
		// (set) Token: 0x0600A649 RID: 42569 RVA: 0x000F5BC4 File Offset: 0x000F3DC4
		public unsafe bool bCanLoop
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneSectionParameters.__PropertyOffset_bCanLoop) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneSectionParameters.__PropertyOffset_bCanLoop) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001EE4 RID: 7908
		// (get) Token: 0x0600A64A RID: 42570 RVA: 0x000F5BD8 File Offset: 0x000F3DD8
		// (set) Token: 0x0600A64B RID: 42571 RVA: 0x000F5C1B File Offset: 0x000F3E1B
		public FFrameNumber EndFrameOffset
		{
			get
			{
				base.FastCheckIsValid();
				FFrameNumber result;
				if ((result = this._EndFrameOffset) == null)
				{
					result = (this._EndFrameOffset = new FFrameNumber(base.NativePtr + (IntPtr)FMovieSceneSectionParameters.__PropertyOffset_EndFrameOffset, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FFrameNumber.StaticStruct(), base.NativePtr + (IntPtr)FMovieSceneSectionParameters.__PropertyOffset_EndFrameOffset, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001EE5 RID: 7909
		// (get) Token: 0x0600A64C RID: 42572 RVA: 0x000F5C3C File Offset: 0x000F3E3C
		// (set) Token: 0x0600A64D RID: 42573 RVA: 0x000F5C7F File Offset: 0x000F3E7F
		public FFrameNumber FirstLoopStartFrameOffset
		{
			get
			{
				base.FastCheckIsValid();
				FFrameNumber result;
				if ((result = this._FirstLoopStartFrameOffset) == null)
				{
					result = (this._FirstLoopStartFrameOffset = new FFrameNumber(base.NativePtr + (IntPtr)FMovieSceneSectionParameters.__PropertyOffset_FirstLoopStartFrameOffset, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FFrameNumber.StaticStruct(), base.NativePtr + (IntPtr)FMovieSceneSectionParameters.__PropertyOffset_FirstLoopStartFrameOffset, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001EE6 RID: 7910
		// (get) Token: 0x0600A64E RID: 42574 RVA: 0x000F5CA0 File Offset: 0x000F3EA0
		// (set) Token: 0x0600A64F RID: 42575 RVA: 0x000F5CB0 File Offset: 0x000F3EB0
		public unsafe float TimeScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneSectionParameters.__PropertyOffset_TimeScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneSectionParameters.__PropertyOffset_TimeScale) = value;
			}
		}

		// Token: 0x17001EE7 RID: 7911
		// (get) Token: 0x0600A650 RID: 42576 RVA: 0x000F5CC1 File Offset: 0x000F3EC1
		// (set) Token: 0x0600A651 RID: 42577 RVA: 0x000F5CD1 File Offset: 0x000F3ED1
		public unsafe int HierarchicalBias
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneSectionParameters.__PropertyOffset_HierarchicalBias);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneSectionParameters.__PropertyOffset_HierarchicalBias) = value;
			}
		}

		// Token: 0x17001EE8 RID: 7912
		// (get) Token: 0x0600A652 RID: 42578 RVA: 0x000F5CE2 File Offset: 0x000F3EE2
		// (set) Token: 0x0600A653 RID: 42579 RVA: 0x000F5CF2 File Offset: 0x000F3EF2
		public unsafe float StartOffset_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneSectionParameters.__PropertyOffset_StartOffset_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneSectionParameters.__PropertyOffset_StartOffset_DEPRECATED) = value;
			}
		}

		// Token: 0x17001EE9 RID: 7913
		// (get) Token: 0x0600A654 RID: 42580 RVA: 0x000F5D03 File Offset: 0x000F3F03
		// (set) Token: 0x0600A655 RID: 42581 RVA: 0x000F5D13 File Offset: 0x000F3F13
		public unsafe float PrerollTime_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneSectionParameters.__PropertyOffset_PrerollTime_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneSectionParameters.__PropertyOffset_PrerollTime_DEPRECATED) = value;
			}
		}

		// Token: 0x17001EEA RID: 7914
		// (get) Token: 0x0600A656 RID: 42582 RVA: 0x000F5D24 File Offset: 0x000F3F24
		// (set) Token: 0x0600A657 RID: 42583 RVA: 0x000F5D34 File Offset: 0x000F3F34
		public unsafe float PostrollTime_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneSectionParameters.__PropertyOffset_PostrollTime_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneSectionParameters.__PropertyOffset_PostrollTime_DEPRECATED) = value;
			}
		}

		// Token: 0x0600A658 RID: 42584 RVA: 0x000F5D45 File Offset: 0x000F3F45
		public FMovieSceneSectionParameters()
		{
		}

		// Token: 0x0600A659 RID: 42585 RVA: 0x000F5D4D File Offset: 0x000F3F4D
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneSectionParameters.StaticStruct();
		}

		// Token: 0x0600A65A RID: 42586 RVA: 0x000F5D59 File Offset: 0x000F3F59
		[NullableContext(2)]
		public FMovieSceneSectionParameters(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600A65B RID: 42587 RVA: 0x000F5D63 File Offset: 0x000F3F63
		public FMovieSceneSectionParameters(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600A65C RID: 42588 RVA: 0x000F5D6E File Offset: 0x000F3F6E
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneSectionParameters(Pointer, false, true);
		}

		// Token: 0x0600A65D RID: 42589 RVA: 0x000F5D78 File Offset: 0x000F3F78
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneSectionParameters(Pointer, MemoryOwner);
		}

		// Token: 0x04004745 RID: 18245
		public const string __ObjectPath = "/Script/MovieScene.MovieSceneSectionParameters";

		// Token: 0x04004746 RID: 18246
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04004747 RID: 18247
		internal static int __PropertyOffset_StartFrameOffset;

		// Token: 0x04004748 RID: 18248
		[Nullable(2)]
		private FFrameNumber _StartFrameOffset;

		// Token: 0x04004749 RID: 18249
		internal static int __PropertyOffset_bCanLoop;

		// Token: 0x0400474A RID: 18250
		internal static int __PropertyOffset_EndFrameOffset;

		// Token: 0x0400474B RID: 18251
		[Nullable(2)]
		private FFrameNumber _EndFrameOffset;

		// Token: 0x0400474C RID: 18252
		internal static int __PropertyOffset_FirstLoopStartFrameOffset;

		// Token: 0x0400474D RID: 18253
		[Nullable(2)]
		private FFrameNumber _FirstLoopStartFrameOffset;

		// Token: 0x0400474E RID: 18254
		internal static int __PropertyOffset_TimeScale;

		// Token: 0x0400474F RID: 18255
		internal static int __PropertyOffset_HierarchicalBias;

		// Token: 0x04004750 RID: 18256
		internal static int __PropertyOffset_StartOffset_DEPRECATED;

		// Token: 0x04004751 RID: 18257
		internal static int __PropertyOffset_PrerollTime_DEPRECATED;

		// Token: 0x04004752 RID: 18258
		internal static int __PropertyOffset_PostrollTime_DEPRECATED;
	}
}
