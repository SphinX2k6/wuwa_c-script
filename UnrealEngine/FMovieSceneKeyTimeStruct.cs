using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002412 RID: 9234
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieScene.MovieSceneKeyTimeStruct")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FMovieSceneKeyTimeStruct : FMovieSceneKeyStruct, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060229F0 RID: 141808 RVA: 0x0033337A File Offset: 0x0033157A
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneKeyTimeStruct._ScriptStructPtr != 0) ? FMovieSceneKeyTimeStruct._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieScene.MovieSceneKeyTimeStruct", ref FMovieSceneKeyTimeStruct._ScriptStructPtr);
		}

		// Token: 0x17008542 RID: 34114
		// (get) Token: 0x060229F1 RID: 141809 RVA: 0x003333A0 File Offset: 0x003315A0
		// (set) Token: 0x060229F2 RID: 141810 RVA: 0x003333E3 File Offset: 0x003315E3
		public FFrameNumber Time
		{
			get
			{
				base.FastCheckIsValid();
				FFrameNumber result;
				if ((result = this._Time) == null)
				{
					result = (this._Time = new FFrameNumber(base.NativePtr + (IntPtr)FMovieSceneKeyTimeStruct.__PropertyOffset_Time, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FFrameNumber.StaticStruct(), base.NativePtr + (IntPtr)FMovieSceneKeyTimeStruct.__PropertyOffset_Time, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060229F3 RID: 141811 RVA: 0x00333404 File Offset: 0x00331604
		public FMovieSceneKeyTimeStruct()
		{
		}

		// Token: 0x060229F4 RID: 141812 RVA: 0x0033340C File Offset: 0x0033160C
		public FMovieSceneKeyTimeStruct(FFrameNumber Time)
		{
			this.Time = Time;
		}

		// Token: 0x060229F5 RID: 141813 RVA: 0x0033341B File Offset: 0x0033161B
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneKeyTimeStruct.StaticStruct();
		}

		// Token: 0x060229F6 RID: 141814 RVA: 0x00333427 File Offset: 0x00331627
		[NullableContext(2)]
		public FMovieSceneKeyTimeStruct(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060229F7 RID: 141815 RVA: 0x00333431 File Offset: 0x00331631
		public FMovieSceneKeyTimeStruct(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060229F8 RID: 141816 RVA: 0x0033343C File Offset: 0x0033163C
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneKeyTimeStruct(Pointer, false, true);
		}

		// Token: 0x060229F9 RID: 141817 RVA: 0x00333446 File Offset: 0x00331646
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneKeyTimeStruct(Pointer, MemoryOwner);
		}

		// Token: 0x040127FD RID: 75773
		public new const string __ObjectPath = "/Script/MovieScene.MovieSceneKeyTimeStruct";

		// Token: 0x040127FE RID: 75774
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040127FF RID: 75775
		internal static int __PropertyOffset_Time;

		// Token: 0x04012800 RID: 75776
		[Nullable(2)]
		private FFrameNumber _Time;
	}
}
