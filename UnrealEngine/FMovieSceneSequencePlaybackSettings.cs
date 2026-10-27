using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002437 RID: 9271
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieScene.MovieSceneSequencePlaybackSettings")]
	[UnrealStructLayout(20, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 20)]
	public class FMovieSceneSequencePlaybackSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06022BB4 RID: 142260 RVA: 0x00335C95 File Offset: 0x00333E95
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneSequencePlaybackSettings._ScriptStructPtr != 0) ? FMovieSceneSequencePlaybackSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieScene.MovieSceneSequencePlaybackSettings", ref FMovieSceneSequencePlaybackSettings._ScriptStructPtr);
		}

		// Token: 0x17008596 RID: 34198
		// (get) Token: 0x06022BB5 RID: 142261 RVA: 0x00335CB9 File Offset: 0x00333EB9
		// (set) Token: 0x06022BB6 RID: 142262 RVA: 0x00335CD2 File Offset: 0x00333ED2
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

		// Token: 0x17008597 RID: 34199
		// (get) Token: 0x06022BB7 RID: 142263 RVA: 0x00335D04 File Offset: 0x00333F04
		// (set) Token: 0x06022BB8 RID: 142264 RVA: 0x00335D47 File Offset: 0x00333F47
		public FMovieSceneSequenceLoopCount LoopCount
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneSequenceLoopCount result;
				if ((result = this._LoopCount) == null)
				{
					result = (this._LoopCount = new FMovieSceneSequenceLoopCount(base.NativePtr + (IntPtr)FMovieSceneSequencePlaybackSettings.__PropertyOffset_LoopCount, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneSequenceLoopCount.StaticStruct(), base.NativePtr + (IntPtr)FMovieSceneSequencePlaybackSettings.__PropertyOffset_LoopCount, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008598 RID: 34200
		// (get) Token: 0x06022BB9 RID: 142265 RVA: 0x00335D68 File Offset: 0x00333F68
		// (set) Token: 0x06022BBA RID: 142266 RVA: 0x00335D78 File Offset: 0x00333F78
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

		// Token: 0x17008599 RID: 34201
		// (get) Token: 0x06022BBB RID: 142267 RVA: 0x00335D89 File Offset: 0x00333F89
		// (set) Token: 0x06022BBC RID: 142268 RVA: 0x00335D99 File Offset: 0x00333F99
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

		// Token: 0x1700859A RID: 34202
		// (get) Token: 0x06022BBD RID: 142269 RVA: 0x00335DAA File Offset: 0x00333FAA
		// (set) Token: 0x06022BBE RID: 142270 RVA: 0x00335DC3 File Offset: 0x00333FC3
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

		// Token: 0x1700859B RID: 34203
		// (get) Token: 0x06022BBF RID: 142271 RVA: 0x00335DF3 File Offset: 0x00333FF3
		// (set) Token: 0x06022BC0 RID: 142272 RVA: 0x00335E0C File Offset: 0x0033400C
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

		// Token: 0x1700859C RID: 34204
		// (get) Token: 0x06022BC1 RID: 142273 RVA: 0x00335E3C File Offset: 0x0033403C
		// (set) Token: 0x06022BC2 RID: 142274 RVA: 0x00335E55 File Offset: 0x00334055
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

		// Token: 0x1700859D RID: 34205
		// (get) Token: 0x06022BC3 RID: 142275 RVA: 0x00335E85 File Offset: 0x00334085
		// (set) Token: 0x06022BC4 RID: 142276 RVA: 0x00335E9E File Offset: 0x0033409E
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

		// Token: 0x1700859E RID: 34206
		// (get) Token: 0x06022BC5 RID: 142277 RVA: 0x00335ECE File Offset: 0x003340CE
		// (set) Token: 0x06022BC6 RID: 142278 RVA: 0x00335EE7 File Offset: 0x003340E7
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

		// Token: 0x1700859F RID: 34207
		// (get) Token: 0x06022BC7 RID: 142279 RVA: 0x00335F17 File Offset: 0x00334117
		// (set) Token: 0x06022BC8 RID: 142280 RVA: 0x00335F30 File Offset: 0x00334130
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

		// Token: 0x170085A0 RID: 34208
		// (get) Token: 0x06022BC9 RID: 142281 RVA: 0x00335F60 File Offset: 0x00334160
		// (set) Token: 0x06022BCA RID: 142282 RVA: 0x00335F79 File Offset: 0x00334179
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

		// Token: 0x170085A1 RID: 34209
		// (get) Token: 0x06022BCB RID: 142283 RVA: 0x00335FA9 File Offset: 0x003341A9
		// (set) Token: 0x06022BCC RID: 142284 RVA: 0x00335FC2 File Offset: 0x003341C2
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

		// Token: 0x06022BCD RID: 142285 RVA: 0x00335FF2 File Offset: 0x003341F2
		public FMovieSceneSequencePlaybackSettings()
		{
		}

		// Token: 0x06022BCE RID: 142286 RVA: 0x00335FFC File Offset: 0x003341FC
		public FMovieSceneSequencePlaybackSettings(bool bAutoPlay, FMovieSceneSequenceLoopCount LoopCount, float PlayRate, float StartTime, bool bRandomStartTime, bool bRestoreState, bool bDisableMovementInput, bool bDisableLookAtInput, bool bHidePlayer, bool bHideHud, bool bDisableCameraCuts, bool bPauseAtEnd)
		{
			this.bAutoPlay = bAutoPlay;
			this.LoopCount = LoopCount;
			this.PlayRate = PlayRate;
			this.StartTime = StartTime;
			this.bRandomStartTime = bRandomStartTime;
			this.bRestoreState = bRestoreState;
			this.bDisableMovementInput = bDisableMovementInput;
			this.bDisableLookAtInput = bDisableLookAtInput;
			this.bHidePlayer = bHidePlayer;
			this.bHideHud = bHideHud;
			this.bDisableCameraCuts = bDisableCameraCuts;
			this.bPauseAtEnd = bPauseAtEnd;
		}

		// Token: 0x06022BCF RID: 142287 RVA: 0x0033606C File Offset: 0x0033426C
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneSequencePlaybackSettings.StaticStruct();
		}

		// Token: 0x06022BD0 RID: 142288 RVA: 0x00336078 File Offset: 0x00334278
		[NullableContext(2)]
		public FMovieSceneSequencePlaybackSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06022BD1 RID: 142289 RVA: 0x00336082 File Offset: 0x00334282
		public FMovieSceneSequencePlaybackSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06022BD2 RID: 142290 RVA: 0x0033608D File Offset: 0x0033428D
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneSequencePlaybackSettings(Pointer, false, true);
		}

		// Token: 0x06022BD3 RID: 142291 RVA: 0x00336097 File Offset: 0x00334297
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneSequencePlaybackSettings(Pointer, MemoryOwner);
		}

		// Token: 0x040128D5 RID: 75989
		public const string __ObjectPath = "/Script/MovieScene.MovieSceneSequencePlaybackSettings";

		// Token: 0x040128D6 RID: 75990
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040128D7 RID: 75991
		internal static int __PropertyOffset_bAutoPlay;

		// Token: 0x040128D8 RID: 75992
		internal static byte __PropertyMask_bAutoPlay;

		// Token: 0x040128D9 RID: 75993
		internal static int __PropertyOffset_LoopCount;

		// Token: 0x040128DA RID: 75994
		[Nullable(2)]
		private FMovieSceneSequenceLoopCount _LoopCount;

		// Token: 0x040128DB RID: 75995
		internal static int __PropertyOffset_PlayRate;

		// Token: 0x040128DC RID: 75996
		internal static int __PropertyOffset_StartTime;

		// Token: 0x040128DD RID: 75997
		internal static int __PropertyOffset_bRandomStartTime;

		// Token: 0x040128DE RID: 75998
		internal static byte __PropertyMask_bRandomStartTime;

		// Token: 0x040128DF RID: 75999
		internal static int __PropertyOffset_bRestoreState;

		// Token: 0x040128E0 RID: 76000
		internal static byte __PropertyMask_bRestoreState;

		// Token: 0x040128E1 RID: 76001
		internal static int __PropertyOffset_bDisableMovementInput;

		// Token: 0x040128E2 RID: 76002
		internal static byte __PropertyMask_bDisableMovementInput;

		// Token: 0x040128E3 RID: 76003
		internal static int __PropertyOffset_bDisableLookAtInput;

		// Token: 0x040128E4 RID: 76004
		internal static byte __PropertyMask_bDisableLookAtInput;

		// Token: 0x040128E5 RID: 76005
		internal static int __PropertyOffset_bHidePlayer;

		// Token: 0x040128E6 RID: 76006
		internal static byte __PropertyMask_bHidePlayer;

		// Token: 0x040128E7 RID: 76007
		internal static int __PropertyOffset_bHideHud;

		// Token: 0x040128E8 RID: 76008
		internal static byte __PropertyMask_bHideHud;

		// Token: 0x040128E9 RID: 76009
		internal static int __PropertyOffset_bDisableCameraCuts;

		// Token: 0x040128EA RID: 76010
		internal static byte __PropertyMask_bDisableCameraCuts;

		// Token: 0x040128EB RID: 76011
		internal static int __PropertyOffset_bPauseAtEnd;

		// Token: 0x040128EC RID: 76012
		internal static byte __PropertyMask_bPauseAtEnd;
	}
}
