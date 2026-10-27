using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002439 RID: 9273
	[UnrealObjectPath("/Script/MovieScene.MovieSceneSequenceReplProperties")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FMovieSceneSequenceReplProperties : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06022C60 RID: 142432 RVA: 0x00336A25 File Offset: 0x00334C25
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneSequenceReplProperties._ScriptStructPtr != 0) ? FMovieSceneSequenceReplProperties._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieScene.MovieSceneSequenceReplProperties", ref FMovieSceneSequenceReplProperties._ScriptStructPtr);
		}

		// Token: 0x170085B5 RID: 34229
		// (get) Token: 0x06022C61 RID: 142433 RVA: 0x00336A4C File Offset: 0x00334C4C
		// (set) Token: 0x06022C62 RID: 142434 RVA: 0x00336A8F File Offset: 0x00334C8F
		[Nullable(1)]
		public FFrameTime LastKnownPosition
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FFrameTime result;
				if ((result = this._LastKnownPosition) == null)
				{
					result = (this._LastKnownPosition = new FFrameTime(base.NativePtr + (IntPtr)FMovieSceneSequenceReplProperties.__PropertyOffset_LastKnownPosition, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FFrameTime.StaticStruct(), base.NativePtr + (IntPtr)FMovieSceneSequenceReplProperties.__PropertyOffset_LastKnownPosition, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170085B6 RID: 34230
		// (get) Token: 0x06022C63 RID: 142435 RVA: 0x00336AB0 File Offset: 0x00334CB0
		// (set) Token: 0x06022C64 RID: 142436 RVA: 0x00336AC4 File Offset: 0x00334CC4
		public unsafe TEnumAsByte<EMovieScenePlayerStatus> LastKnownStatus
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneSequenceReplProperties.__PropertyOffset_LastKnownStatus);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneSequenceReplProperties.__PropertyOffset_LastKnownStatus) = value;
			}
		}

		// Token: 0x170085B7 RID: 34231
		// (get) Token: 0x06022C65 RID: 142437 RVA: 0x00336AD9 File Offset: 0x00334CD9
		// (set) Token: 0x06022C66 RID: 142438 RVA: 0x00336AE9 File Offset: 0x00334CE9
		public unsafe int LastKnownNumLoops
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneSequenceReplProperties.__PropertyOffset_LastKnownNumLoops);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneSequenceReplProperties.__PropertyOffset_LastKnownNumLoops) = value;
			}
		}

		// Token: 0x06022C67 RID: 142439 RVA: 0x00336AFA File Offset: 0x00334CFA
		public FMovieSceneSequenceReplProperties()
		{
		}

		// Token: 0x06022C68 RID: 142440 RVA: 0x00336B02 File Offset: 0x00334D02
		public FMovieSceneSequenceReplProperties([Nullable(1)] FFrameTime LastKnownPosition, TEnumAsByte<EMovieScenePlayerStatus> LastKnownStatus, int LastKnownNumLoops)
		{
			this.LastKnownPosition = LastKnownPosition;
			this.LastKnownStatus = LastKnownStatus;
			this.LastKnownNumLoops = LastKnownNumLoops;
		}

		// Token: 0x06022C69 RID: 142441 RVA: 0x00336B1F File Offset: 0x00334D1F
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneSequenceReplProperties.StaticStruct();
		}

		// Token: 0x06022C6A RID: 142442 RVA: 0x00336B2B File Offset: 0x00334D2B
		[NullableContext(2)]
		public FMovieSceneSequenceReplProperties(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06022C6B RID: 142443 RVA: 0x00336B35 File Offset: 0x00334D35
		public FMovieSceneSequenceReplProperties(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06022C6C RID: 142444 RVA: 0x00336B40 File Offset: 0x00334D40
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneSequenceReplProperties(Pointer, false, true);
		}

		// Token: 0x06022C6D RID: 142445 RVA: 0x00336B4A File Offset: 0x00334D4A
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneSequenceReplProperties(Pointer, MemoryOwner);
		}

		// Token: 0x0401290F RID: 76047
		[Nullable(1)]
		public const string __ObjectPath = "/Script/MovieScene.MovieSceneSequenceReplProperties";

		// Token: 0x04012910 RID: 76048
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012911 RID: 76049
		internal static int __PropertyOffset_LastKnownPosition;

		// Token: 0x04012912 RID: 76050
		[Nullable(2)]
		private FFrameTime _LastKnownPosition;

		// Token: 0x04012913 RID: 76051
		internal static int __PropertyOffset_LastKnownStatus;

		// Token: 0x04012914 RID: 76052
		internal static int __PropertyOffset_LastKnownNumLoops;
	}
}
