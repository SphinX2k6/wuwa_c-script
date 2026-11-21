using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200078A RID: 1930
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieScene.MovieSceneSequencePlaybackParams")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FMovieSceneSequencePlaybackParams : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600A67B RID: 42619 RVA: 0x000F5F37 File Offset: 0x000F4137
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneSequencePlaybackParams._ScriptStructPtr != 0) ? FMovieSceneSequencePlaybackParams._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieScene.MovieSceneSequencePlaybackParams", ref FMovieSceneSequencePlaybackParams._ScriptStructPtr);
		}

		// Token: 0x17001EEF RID: 7919
		// (get) Token: 0x0600A67C RID: 42620 RVA: 0x000F5F5C File Offset: 0x000F415C
		// (set) Token: 0x0600A67D RID: 42621 RVA: 0x000F5F9F File Offset: 0x000F419F
		public FFrameTime Frame
		{
			get
			{
				base.FastCheckIsValid();
				FFrameTime result;
				if ((result = this._Frame) == null)
				{
					result = (this._Frame = new FFrameTime(base.NativePtr + (IntPtr)FMovieSceneSequencePlaybackParams.__PropertyOffset_Frame, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FFrameTime.StaticStruct(), base.NativePtr + (IntPtr)FMovieSceneSequencePlaybackParams.__PropertyOffset_Frame, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001EF0 RID: 7920
		// (get) Token: 0x0600A67E RID: 42622 RVA: 0x000F5FC0 File Offset: 0x000F41C0
		// (set) Token: 0x0600A67F RID: 42623 RVA: 0x000F5FD0 File Offset: 0x000F41D0
		public unsafe float Time
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneSequencePlaybackParams.__PropertyOffset_Time);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneSequencePlaybackParams.__PropertyOffset_Time) = value;
			}
		}

		// Token: 0x17001EF1 RID: 7921
		// (get) Token: 0x0600A680 RID: 42624 RVA: 0x000F5FE1 File Offset: 0x000F41E1
		// (set) Token: 0x0600A681 RID: 42625 RVA: 0x000F5FF5 File Offset: 0x000F41F5
		public unsafe string MarkedFrame
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FMovieSceneSequencePlaybackParams.__PropertyOffset_MarkedFrame)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FMovieSceneSequencePlaybackParams.__PropertyOffset_MarkedFrame)), value);
			}
		}

		// Token: 0x17001EF2 RID: 7922
		// (get) Token: 0x0600A682 RID: 42626 RVA: 0x000F600A File Offset: 0x000F420A
		// (set) Token: 0x0600A683 RID: 42627 RVA: 0x000F601A File Offset: 0x000F421A
		public unsafe EMovieScenePositionType PositionType
		{
			get
			{
				return (EMovieScenePositionType)(*(base.NativePtr + (IntPtr)FMovieSceneSequencePlaybackParams.__PropertyOffset_PositionType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneSequencePlaybackParams.__PropertyOffset_PositionType) = (byte)value;
			}
		}

		// Token: 0x17001EF3 RID: 7923
		// (get) Token: 0x0600A684 RID: 42628 RVA: 0x000F602B File Offset: 0x000F422B
		// (set) Token: 0x0600A685 RID: 42629 RVA: 0x000F603B File Offset: 0x000F423B
		public unsafe EUpdatePositionMethod UpdateMethod
		{
			get
			{
				return (EUpdatePositionMethod)(*(base.NativePtr + (IntPtr)FMovieSceneSequencePlaybackParams.__PropertyOffset_UpdateMethod));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneSequencePlaybackParams.__PropertyOffset_UpdateMethod) = (byte)value;
			}
		}

		// Token: 0x0600A686 RID: 42630 RVA: 0x000F604C File Offset: 0x000F424C
		public FMovieSceneSequencePlaybackParams()
		{
		}

		// Token: 0x0600A687 RID: 42631 RVA: 0x000F6054 File Offset: 0x000F4254
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneSequencePlaybackParams.StaticStruct();
		}

		// Token: 0x0600A688 RID: 42632 RVA: 0x000F6060 File Offset: 0x000F4260
		[NullableContext(2)]
		public FMovieSceneSequencePlaybackParams(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600A689 RID: 42633 RVA: 0x000F606A File Offset: 0x000F426A
		public FMovieSceneSequencePlaybackParams(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600A68A RID: 42634 RVA: 0x000F6075 File Offset: 0x000F4275
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneSequencePlaybackParams(Pointer, false, true);
		}

		// Token: 0x0600A68B RID: 42635 RVA: 0x000F607F File Offset: 0x000F427F
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneSequencePlaybackParams(Pointer, MemoryOwner);
		}

		// Token: 0x0400475A RID: 18266
		public const string __ObjectPath = "/Script/MovieScene.MovieSceneSequencePlaybackParams";

		// Token: 0x0400475B RID: 18267
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400475C RID: 18268
		internal static int __PropertyOffset_Frame;

		// Token: 0x0400475D RID: 18269
		[Nullable(2)]
		private FFrameTime _Frame;

		// Token: 0x0400475E RID: 18270
		internal static int __PropertyOffset_Time;

		// Token: 0x0400475F RID: 18271
		internal static int __PropertyOffset_MarkedFrame;

		// Token: 0x04004760 RID: 18272
		internal static int __PropertyOffset_PositionType;

		// Token: 0x04004761 RID: 18273
		internal static int __PropertyOffset_UpdateMethod;
	}
}
