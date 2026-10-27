using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200235A RID: 9050
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneColorKeyStruct")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FMovieSceneColorKeyStruct : FMovieSceneKeyStruct, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602230D RID: 140045 RVA: 0x00328EEE File Offset: 0x003270EE
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneColorKeyStruct._ScriptStructPtr != 0) ? FMovieSceneColorKeyStruct._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieSceneTracks.MovieSceneColorKeyStruct", ref FMovieSceneColorKeyStruct._ScriptStructPtr);
		}

		// Token: 0x17008406 RID: 33798
		// (get) Token: 0x0602230E RID: 140046 RVA: 0x00328F12 File Offset: 0x00327112
		// (set) Token: 0x0602230F RID: 140047 RVA: 0x00328F26 File Offset: 0x00327126
		public unsafe FLinearColor Color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneColorKeyStruct.__PropertyOffset_Color);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneColorKeyStruct.__PropertyOffset_Color) = value;
			}
		}

		// Token: 0x17008407 RID: 33799
		// (get) Token: 0x06022310 RID: 140048 RVA: 0x00328F3C File Offset: 0x0032713C
		// (set) Token: 0x06022311 RID: 140049 RVA: 0x00328F7F File Offset: 0x0032717F
		public FFrameNumber Time
		{
			get
			{
				base.FastCheckIsValid();
				FFrameNumber result;
				if ((result = this._Time) == null)
				{
					result = (this._Time = new FFrameNumber(base.NativePtr + (IntPtr)FMovieSceneColorKeyStruct.__PropertyOffset_Time, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FFrameNumber.StaticStruct(), base.NativePtr + (IntPtr)FMovieSceneColorKeyStruct.__PropertyOffset_Time, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06022312 RID: 140050 RVA: 0x00328FA0 File Offset: 0x003271A0
		public FMovieSceneColorKeyStruct()
		{
		}

		// Token: 0x06022313 RID: 140051 RVA: 0x00328FA8 File Offset: 0x003271A8
		public FMovieSceneColorKeyStruct(FLinearColor Color, FFrameNumber Time)
		{
			this.Color = Color;
			this.Time = Time;
		}

		// Token: 0x06022314 RID: 140052 RVA: 0x00328FBE File Offset: 0x003271BE
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneColorKeyStruct.StaticStruct();
		}

		// Token: 0x06022315 RID: 140053 RVA: 0x00328FCA File Offset: 0x003271CA
		[NullableContext(2)]
		public FMovieSceneColorKeyStruct(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06022316 RID: 140054 RVA: 0x00328FD4 File Offset: 0x003271D4
		public FMovieSceneColorKeyStruct(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06022317 RID: 140055 RVA: 0x00328FDF File Offset: 0x003271DF
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneColorKeyStruct(Pointer, false, true);
		}

		// Token: 0x06022318 RID: 140056 RVA: 0x00328FE9 File Offset: 0x003271E9
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneColorKeyStruct(Pointer, MemoryOwner);
		}

		// Token: 0x04012401 RID: 74753
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneColorKeyStruct";

		// Token: 0x04012402 RID: 74754
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012403 RID: 74755
		internal static int __PropertyOffset_Color;

		// Token: 0x04012404 RID: 74756
		internal static int __PropertyOffset_Time;

		// Token: 0x04012405 RID: 74757
		[Nullable(2)]
		private FFrameNumber _Time;
	}
}
