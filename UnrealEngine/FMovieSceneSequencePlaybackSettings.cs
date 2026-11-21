using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200078B RID: 1931
	[UnrealObjectPath("/Script/MovieScene.MovieSceneSequencePlaybackSettings")]
	[UnrealStructLayout(20, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 20)]
	public class FMovieSceneSequencePlaybackSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600A68C RID: 42636 RVA: 0x000F6088 File Offset: 0x000F4288
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneSequencePlaybackSettings._ScriptStructPtr != 0) ? FMovieSceneSequencePlaybackSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieScene.MovieSceneSequencePlaybackSettings", ref FMovieSceneSequencePlaybackSettings._ScriptStructPtr);
		}

		// Token: 0x17001EF4 RID: 7924
		// (get) Token: 0x0600A68D RID: 42637 RVA: 0x000F60AC File Offset: 0x000F42AC
		// (set) Token: 0x0600A68E RID: 42638 RVA: 0x000F60C5 File Offset: 0x000F42C5
		public unsafe bool bAutoPlay
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMovieSceneSequencePlaybackSettings.__PropertyOffset_bAutoPlay) & FMovieSceneSequencePlaybackSettings.__PropertyMask_bAutoPlay) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMovieSceneSequencePlaybackSettings.__PropertyOffset_bAutoPlay) = ((*(base.NativePtr + (IntPtr)FMovieSceneSequencePlaybackSettings.__PropertyOffset_bAutoPlay) & ~FMovieSceneSequencePlaybackSettings.__PropertyMask_bAutoPlay) | (value ? FMovieSceneSequencePlaybackSettings.__PropertyMask_bAutoPlay : 0));
			}
		}

		// Token: 0x17001EF5 RID: 7925
		// (get) Token: 0x0600A68F RID: 42639 RVA: 0x000F60F5 File Offset: 0x000F42F5
		// (set) Token: 0x0600A690 RID: 42640 RVA: 0x000F6105 File Offset: 0x000F4305
		public unsafe float PlayRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneSequencePlaybackSettings.__PropertyOffset_PlayRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneSequencePlaybackSettings.__PropertyOffset_PlayRate) = value;
			}
		}

		// Token: 0x17001EF6 RID: 7926
		// (get) Token: 0x0600A691 RID: 42641 RVA: 0x000F6116 File Offset: 0x000F4316
		// (set) Token: 0x0600A692 RID: 42642 RVA: 0x000F6126 File Offset: 0x000F4326
		public unsafe float StartTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneSequencePlaybackSettings.__PropertyOffset_StartTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneSequencePlaybackSettings.__PropertyOffset_StartTime) = value;
			}
		}

		// Token: 0x17001EF7 RID: 7927
		// (get) Token: 0x0600A693 RID: 42643 RVA: 0x000F6137 File Offset: 0x000F4337
		// (set) Token: 0x0600A694 RID: 42644 RVA: 0x000F6150 File Offset: 0x000F4350
		public unsafe bool bRandomStartTime
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMovieSceneSequencePlaybackSettings.__PropertyOffset_bRandomStartTime) & FMovieSceneSequencePlaybackSettings.__PropertyMask_bRandomStartTime) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMovieSceneSequencePlaybackSettings.__PropertyOffset_bRandomStartTime) = ((*(base.NativePtr + (IntPtr)FMovieSceneSequencePlaybackSettings.__PropertyOffset_bRandomStartTime) & ~FMovieSceneSequencePlaybackSettings.__PropertyMask_bRandomStartTime) | (value ? FMovieSceneSequencePlaybackSettings.__PropertyMask_bRandomStartTime : 0));
			}
		}

		// Token: 0x17001EF8 RID: 7928
		// (get) Token: 0x0600A695 RID: 42645 RVA: 0x000F6180 File Offset: 0x000F4380
		// (set) Token: 0x0600A696 RID: 42646 RVA: 0x000F6199 File Offset: 0x000F4399
		public unsafe bool bRestoreState
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMovieSceneSequencePlaybackSettings.__PropertyOffset_bRestoreState) & FMovieSceneSequencePlaybackSettings.__PropertyMask_bRestoreState) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMovieSceneSequencePlaybackSettings.__PropertyOffset_bRestoreState) = ((*(base.NativePtr + (IntPtr)FMovieSceneSequencePlaybackSettings.__PropertyOffset_bRestoreState) & ~FMovieSceneSequencePlaybackSettings.__PropertyMask_bRestoreState) | (value ? FMovieSceneSequencePlaybackSettings.__PropertyMask_bRestoreState : 0));
			}
		}

		// Token: 0x17001EF9 RID: 7929
		// (get) Token: 0x0600A697 RID: 42647 RVA: 0x000F61C9 File Offset: 0x000F43C9
		// (set) Token: 0x0600A698 RID: 42648 RVA: 0x000F61E2 File Offset: 0x000F43E2
		public unsafe bool bDisableMovementInput
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMovieSceneSequencePlaybackSettings.__PropertyOffset_bDisableMovementInput) & FMovieSceneSequencePlaybackSettings.__PropertyMask_bDisableMovementInput) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMovieSceneSequencePlaybackSettings.__PropertyOffset_bDisableMovementInput) = ((*(base.NativePtr + (IntPtr)FMovieSceneSequencePlaybackSettings.__PropertyOffset_bDisableMovementInput) & ~FMovieSceneSequencePlaybackSettings.__PropertyMask_bDisableMovementInput) | (value ? FMovieSceneSequencePlaybackSettings.__PropertyMask_bDisableMovementInput : 0));
			}
		}

		// Token: 0x17001EFA RID: 7930
		// (get) Token: 0x0600A699 RID: 42649 RVA: 0x000F6212 File Offset: 0x000F4412
		// (set) Token: 0x0600A69A RID: 42650 RVA: 0x000F622B File Offset: 0x000F442B
		public unsafe bool bDisableLookAtInput
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMovieSceneSequencePlaybackSettings.__PropertyOffset_bDisableLookAtInput) & FMovieSceneSequencePlaybackSettings.__PropertyMask_bDisableLookAtInput) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMovieSceneSequencePlaybackSettings.__PropertyOffset_bDisableLookAtInput) = ((*(base.NativePtr + (IntPtr)FMovieSceneSequencePlaybackSettings.__PropertyOffset_bDisableLookAtInput) & ~FMovieSceneSequencePlaybackSettings.__PropertyMask_bDisableLookAtInput) | (value ? FMovieSceneSequencePlaybackSettings.__PropertyMask_bDisableLookAtInput : 0));
			}
		}

		// Token: 0x17001EFB RID: 7931
		// (get) Token: 0x0600A69B RID: 42651 RVA: 0x000F625B File Offset: 0x000F445B
		// (set) Token: 0x0600A69C RID: 42652 RVA: 0x000F6274 File Offset: 0x000F4474
		public unsafe bool bHidePlayer
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMovieSceneSequencePlaybackSettings.__PropertyOffset_bHidePlayer) & FMovieSceneSequencePlaybackSettings.__PropertyMask_bHidePlayer) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMovieSceneSequencePlaybackSettings.__PropertyOffset_bHidePlayer) = ((*(base.NativePtr + (IntPtr)FMovieSceneSequencePlaybackSettings.__PropertyOffset_bHidePlayer) & ~FMovieSceneSequencePlaybackSettings.__PropertyMask_bHidePlayer) | (value ? FMovieSceneSequencePlaybackSettings.__PropertyMask_bHidePlayer : 0));
			}
		}

		// Token: 0x17001EFC RID: 7932
		// (get) Token: 0x0600A69D RID: 42653 RVA: 0x000F62A4 File Offset: 0x000F44A4
		// (set) Token: 0x0600A69E RID: 42654 RVA: 0x000F62BD File Offset: 0x000F44BD
		public unsafe bool bHideHud
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMovieSceneSequencePlaybackSettings.__PropertyOffset_bHideHud) & FMovieSceneSequencePlaybackSettings.__PropertyMask_bHideHud) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMovieSceneSequencePlaybackSettings.__PropertyOffset_bHideHud) = ((*(base.NativePtr + (IntPtr)FMovieSceneSequencePlaybackSettings.__PropertyOffset_bHideHud) & ~FMovieSceneSequencePlaybackSettings.__PropertyMask_bHideHud) | (value ? FMovieSceneSequencePlaybackSettings.__PropertyMask_bHideHud : 0));
			}
		}

		// Token: 0x17001EFD RID: 7933
		// (get) Token: 0x0600A69F RID: 42655 RVA: 0x000F62ED File Offset: 0x000F44ED
		// (set) Token: 0x0600A6A0 RID: 42656 RVA: 0x000F6306 File Offset: 0x000F4506
		public unsafe bool bDisableCameraCuts
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMovieSceneSequencePlaybackSettings.__PropertyOffset_bDisableCameraCuts) & FMovieSceneSequencePlaybackSettings.__PropertyMask_bDisableCameraCuts) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMovieSceneSequencePlaybackSettings.__PropertyOffset_bDisableCameraCuts) = ((*(base.NativePtr + (IntPtr)FMovieSceneSequencePlaybackSettings.__PropertyOffset_bDisableCameraCuts) & ~FMovieSceneSequencePlaybackSettings.__PropertyMask_bDisableCameraCuts) | (value ? FMovieSceneSequencePlaybackSettings.__PropertyMask_bDisableCameraCuts : 0));
			}
		}

		// Token: 0x17001EFE RID: 7934
		// (get) Token: 0x0600A6A1 RID: 42657 RVA: 0x000F6336 File Offset: 0x000F4536
		// (set) Token: 0x0600A6A2 RID: 42658 RVA: 0x000F634F File Offset: 0x000F454F
		public unsafe bool bPauseAtEnd
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMovieSceneSequencePlaybackSettings.__PropertyOffset_bPauseAtEnd) & FMovieSceneSequencePlaybackSettings.__PropertyMask_bPauseAtEnd) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMovieSceneSequencePlaybackSettings.__PropertyOffset_bPauseAtEnd) = ((*(base.NativePtr + (IntPtr)FMovieSceneSequencePlaybackSettings.__PropertyOffset_bPauseAtEnd) & ~FMovieSceneSequencePlaybackSettings.__PropertyMask_bPauseAtEnd) | (value ? FMovieSceneSequencePlaybackSettings.__PropertyMask_bPauseAtEnd : 0));
			}
		}

		// Token: 0x0600A6A3 RID: 42659 RVA: 0x000F637F File Offset: 0x000F457F
		public FMovieSceneSequencePlaybackSettings()
		{
		}

		// Token: 0x0600A6A4 RID: 42660 RVA: 0x000F6387 File Offset: 0x000F4587
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneSequencePlaybackSettings.StaticStruct();
		}

		// Token: 0x0600A6A5 RID: 42661 RVA: 0x000F6393 File Offset: 0x000F4593
		[NullableContext(2)]
		public FMovieSceneSequencePlaybackSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600A6A6 RID: 42662 RVA: 0x000F639D File Offset: 0x000F459D
		public FMovieSceneSequencePlaybackSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600A6A7 RID: 42663 RVA: 0x000F63A8 File Offset: 0x000F45A8
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneSequencePlaybackSettings(Pointer, false, true);
		}

		// Token: 0x0600A6A8 RID: 42664 RVA: 0x000F63B2 File Offset: 0x000F45B2
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneSequencePlaybackSettings(Pointer, MemoryOwner);
		}

		// Token: 0x04004762 RID: 18274
		[Nullable(1)]
		public const string __ObjectPath = "/Script/MovieScene.MovieSceneSequencePlaybackSettings";

		// Token: 0x04004763 RID: 18275
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04004764 RID: 18276
		internal static int __PropertyOffset_bAutoPlay;

		// Token: 0x04004765 RID: 18277
		internal static byte __PropertyMask_bAutoPlay;

		// Token: 0x04004766 RID: 18278
		internal static int __PropertyOffset_PlayRate;

		// Token: 0x04004767 RID: 18279
		internal static int __PropertyOffset_StartTime;

		// Token: 0x04004768 RID: 18280
		internal static int __PropertyOffset_bRandomStartTime;

		// Token: 0x04004769 RID: 18281
		internal static byte __PropertyMask_bRandomStartTime;

		// Token: 0x0400476A RID: 18282
		internal static int __PropertyOffset_bRestoreState;

		// Token: 0x0400476B RID: 18283
		internal static byte __PropertyMask_bRestoreState;

		// Token: 0x0400476C RID: 18284
		internal static int __PropertyOffset_bDisableMovementInput;

		// Token: 0x0400476D RID: 18285
		internal static byte __PropertyMask_bDisableMovementInput;

		// Token: 0x0400476E RID: 18286
		internal static int __PropertyOffset_bDisableLookAtInput;

		// Token: 0x0400476F RID: 18287
		internal static byte __PropertyMask_bDisableLookAtInput;

		// Token: 0x04004770 RID: 18288
		internal static int __PropertyOffset_bHidePlayer;

		// Token: 0x04004771 RID: 18289
		internal static byte __PropertyMask_bHidePlayer;

		// Token: 0x04004772 RID: 18290
		internal static int __PropertyOffset_bHideHud;

		// Token: 0x04004773 RID: 18291
		internal static byte __PropertyMask_bHideHud;

		// Token: 0x04004774 RID: 18292
		internal static int __PropertyOffset_bDisableCameraCuts;

		// Token: 0x04004775 RID: 18293
		internal static byte __PropertyMask_bDisableCameraCuts;

		// Token: 0x04004776 RID: 18294
		internal static int __PropertyOffset_bPauseAtEnd;

		// Token: 0x04004777 RID: 18295
		internal static byte __PropertyMask_bPauseAtEnd;
	}
}
