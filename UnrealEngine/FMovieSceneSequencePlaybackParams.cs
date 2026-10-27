using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002436 RID: 9270
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieScene.MovieSceneSequencePlaybackParams")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FMovieSceneSequencePlaybackParams : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06022BA2 RID: 142242 RVA: 0x00335B17 File Offset: 0x00333D17
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneSequencePlaybackParams._ScriptStructPtr != 0) ? FMovieSceneSequencePlaybackParams._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieScene.MovieSceneSequencePlaybackParams", ref FMovieSceneSequencePlaybackParams._ScriptStructPtr);
		}

		// Token: 0x17008591 RID: 34193
		// (get) Token: 0x06022BA3 RID: 142243 RVA: 0x00335B3C File Offset: 0x00333D3C
		// (set) Token: 0x06022BA4 RID: 142244 RVA: 0x00335B7F File Offset: 0x00333D7F
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

		// Token: 0x17008592 RID: 34194
		// (get) Token: 0x06022BA5 RID: 142245 RVA: 0x00335BA0 File Offset: 0x00333DA0
		// (set) Token: 0x06022BA6 RID: 142246 RVA: 0x00335BB0 File Offset: 0x00333DB0
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

		// Token: 0x17008593 RID: 34195
		// (get) Token: 0x06022BA7 RID: 142247 RVA: 0x00335BC1 File Offset: 0x00333DC1
		// (set) Token: 0x06022BA8 RID: 142248 RVA: 0x00335BD5 File Offset: 0x00333DD5
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

		// Token: 0x17008594 RID: 34196
		// (get) Token: 0x06022BA9 RID: 142249 RVA: 0x00335BEA File Offset: 0x00333DEA
		// (set) Token: 0x06022BAA RID: 142250 RVA: 0x00335BFA File Offset: 0x00333DFA
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

		// Token: 0x17008595 RID: 34197
		// (get) Token: 0x06022BAB RID: 142251 RVA: 0x00335C0B File Offset: 0x00333E0B
		// (set) Token: 0x06022BAC RID: 142252 RVA: 0x00335C1B File Offset: 0x00333E1B
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

		// Token: 0x06022BAD RID: 142253 RVA: 0x00335C2C File Offset: 0x00333E2C
		public FMovieSceneSequencePlaybackParams()
		{
		}

		// Token: 0x06022BAE RID: 142254 RVA: 0x00335C34 File Offset: 0x00333E34
		public FMovieSceneSequencePlaybackParams(FFrameTime Frame, float Time, string MarkedFrame, EMovieScenePositionType PositionType, EUpdatePositionMethod UpdateMethod)
		{
			this.Frame = Frame;
			this.Time = Time;
			this.MarkedFrame = MarkedFrame;
			this.PositionType = PositionType;
			this.UpdateMethod = UpdateMethod;
		}

		// Token: 0x06022BAF RID: 142255 RVA: 0x00335C61 File Offset: 0x00333E61
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneSequencePlaybackParams.StaticStruct();
		}

		// Token: 0x06022BB0 RID: 142256 RVA: 0x00335C6D File Offset: 0x00333E6D
		[NullableContext(2)]
		public FMovieSceneSequencePlaybackParams(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06022BB1 RID: 142257 RVA: 0x00335C77 File Offset: 0x00333E77
		public FMovieSceneSequencePlaybackParams(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06022BB2 RID: 142258 RVA: 0x00335C82 File Offset: 0x00333E82
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneSequencePlaybackParams(Pointer, false, true);
		}

		// Token: 0x06022BB3 RID: 142259 RVA: 0x00335C8C File Offset: 0x00333E8C
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneSequencePlaybackParams(Pointer, MemoryOwner);
		}

		// Token: 0x040128CD RID: 75981
		public const string __ObjectPath = "/Script/MovieScene.MovieSceneSequencePlaybackParams";

		// Token: 0x040128CE RID: 75982
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040128CF RID: 75983
		internal static int __PropertyOffset_Frame;

		// Token: 0x040128D0 RID: 75984
		[Nullable(2)]
		private FFrameTime _Frame;

		// Token: 0x040128D1 RID: 75985
		internal static int __PropertyOffset_Time;

		// Token: 0x040128D2 RID: 75986
		internal static int __PropertyOffset_MarkedFrame;

		// Token: 0x040128D3 RID: 75987
		internal static int __PropertyOffset_PositionType;

		// Token: 0x040128D4 RID: 75988
		internal static int __PropertyOffset_UpdateMethod;
	}
}
