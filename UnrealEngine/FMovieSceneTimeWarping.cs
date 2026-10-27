using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200244B RID: 9291
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieScene.MovieSceneTimeWarping")]
	[UnrealStructLayout(8, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 8)]
	public class FMovieSceneTimeWarping : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06022D49 RID: 142665 RVA: 0x0033819A File Offset: 0x0033639A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneTimeWarping._ScriptStructPtr != 0) ? FMovieSceneTimeWarping._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieScene.MovieSceneTimeWarping", ref FMovieSceneTimeWarping._ScriptStructPtr);
		}

		// Token: 0x170085EB RID: 34283
		// (get) Token: 0x06022D4A RID: 142666 RVA: 0x003381C0 File Offset: 0x003363C0
		// (set) Token: 0x06022D4B RID: 142667 RVA: 0x00338203 File Offset: 0x00336403
		public FFrameNumber Start
		{
			get
			{
				base.FastCheckIsValid();
				FFrameNumber result;
				if ((result = this._Start) == null)
				{
					result = (this._Start = new FFrameNumber(base.NativePtr + (IntPtr)FMovieSceneTimeWarping.__PropertyOffset_Start, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FFrameNumber.StaticStruct(), base.NativePtr + (IntPtr)FMovieSceneTimeWarping.__PropertyOffset_Start, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170085EC RID: 34284
		// (get) Token: 0x06022D4C RID: 142668 RVA: 0x00338224 File Offset: 0x00336424
		// (set) Token: 0x06022D4D RID: 142669 RVA: 0x00338267 File Offset: 0x00336467
		public FFrameNumber End
		{
			get
			{
				base.FastCheckIsValid();
				FFrameNumber result;
				if ((result = this._End) == null)
				{
					result = (this._End = new FFrameNumber(base.NativePtr + (IntPtr)FMovieSceneTimeWarping.__PropertyOffset_End, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FFrameNumber.StaticStruct(), base.NativePtr + (IntPtr)FMovieSceneTimeWarping.__PropertyOffset_End, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06022D4E RID: 142670 RVA: 0x00338288 File Offset: 0x00336488
		public FMovieSceneTimeWarping()
		{
		}

		// Token: 0x06022D4F RID: 142671 RVA: 0x00338290 File Offset: 0x00336490
		public FMovieSceneTimeWarping(FFrameNumber Start, FFrameNumber End)
		{
			this.Start = Start;
			this.End = End;
		}

		// Token: 0x06022D50 RID: 142672 RVA: 0x003382A6 File Offset: 0x003364A6
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneTimeWarping.StaticStruct();
		}

		// Token: 0x06022D51 RID: 142673 RVA: 0x003382B2 File Offset: 0x003364B2
		[NullableContext(2)]
		public FMovieSceneTimeWarping(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06022D52 RID: 142674 RVA: 0x003382BC File Offset: 0x003364BC
		public FMovieSceneTimeWarping(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06022D53 RID: 142675 RVA: 0x003382C7 File Offset: 0x003364C7
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneTimeWarping(Pointer, false, true);
		}

		// Token: 0x06022D54 RID: 142676 RVA: 0x003382D1 File Offset: 0x003364D1
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneTimeWarping(Pointer, MemoryOwner);
		}

		// Token: 0x04012990 RID: 76176
		public const string __ObjectPath = "/Script/MovieScene.MovieSceneTimeWarping";

		// Token: 0x04012991 RID: 76177
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012992 RID: 76178
		internal static int __PropertyOffset_Start;

		// Token: 0x04012993 RID: 76179
		[Nullable(2)]
		private FFrameNumber _Start;

		// Token: 0x04012994 RID: 76180
		internal static int __PropertyOffset_End;

		// Token: 0x04012995 RID: 76181
		[Nullable(2)]
		private FFrameNumber _End;
	}
}
