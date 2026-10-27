using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020023F8 RID: 9208
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieScene.MovieSceneEvaluationFieldEntityMetaData")]
	[UnrealStructLayout(12, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 12)]
	public class FMovieSceneEvaluationFieldEntityMetaData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060228BC RID: 141500 RVA: 0x00331897 File Offset: 0x0032FA97
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneEvaluationFieldEntityMetaData._ScriptStructPtr != 0) ? FMovieSceneEvaluationFieldEntityMetaData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieScene.MovieSceneEvaluationFieldEntityMetaData", ref FMovieSceneEvaluationFieldEntityMetaData._ScriptStructPtr);
		}

		// Token: 0x17008504 RID: 34052
		// (get) Token: 0x060228BD RID: 141501 RVA: 0x003318BC File Offset: 0x0032FABC
		// (set) Token: 0x060228BE RID: 141502 RVA: 0x003318FF File Offset: 0x0032FAFF
		public FFrameNumber ForcedTime
		{
			get
			{
				base.FastCheckIsValid();
				FFrameNumber result;
				if ((result = this._ForcedTime) == null)
				{
					result = (this._ForcedTime = new FFrameNumber(base.NativePtr + (IntPtr)FMovieSceneEvaluationFieldEntityMetaData.__PropertyOffset_ForcedTime, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FFrameNumber.StaticStruct(), base.NativePtr + (IntPtr)FMovieSceneEvaluationFieldEntityMetaData.__PropertyOffset_ForcedTime, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008505 RID: 34053
		// (get) Token: 0x060228BF RID: 141503 RVA: 0x00331920 File Offset: 0x0032FB20
		// (set) Token: 0x060228C0 RID: 141504 RVA: 0x00331930 File Offset: 0x0032FB30
		public unsafe ESectionEvaluationFlags Flags
		{
			get
			{
				return (ESectionEvaluationFlags)(*(base.NativePtr + (IntPtr)FMovieSceneEvaluationFieldEntityMetaData.__PropertyOffset_Flags));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneEvaluationFieldEntityMetaData.__PropertyOffset_Flags) = (byte)value;
			}
		}

		// Token: 0x17008506 RID: 34054
		// (get) Token: 0x060228C1 RID: 141505 RVA: 0x00331941 File Offset: 0x0032FB41
		// (set) Token: 0x060228C2 RID: 141506 RVA: 0x0033195A File Offset: 0x0032FB5A
		public unsafe bool bEvaluateInSequencePreRoll
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMovieSceneEvaluationFieldEntityMetaData.__PropertyOffset_bEvaluateInSequencePreRoll) & FMovieSceneEvaluationFieldEntityMetaData.__PropertyMask_bEvaluateInSequencePreRoll) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMovieSceneEvaluationFieldEntityMetaData.__PropertyOffset_bEvaluateInSequencePreRoll) = ((*(base.NativePtr + (IntPtr)FMovieSceneEvaluationFieldEntityMetaData.__PropertyOffset_bEvaluateInSequencePreRoll) & ~FMovieSceneEvaluationFieldEntityMetaData.__PropertyMask_bEvaluateInSequencePreRoll) | (value ? FMovieSceneEvaluationFieldEntityMetaData.__PropertyMask_bEvaluateInSequencePreRoll : 0));
			}
		}

		// Token: 0x17008507 RID: 34055
		// (get) Token: 0x060228C3 RID: 141507 RVA: 0x0033198A File Offset: 0x0032FB8A
		// (set) Token: 0x060228C4 RID: 141508 RVA: 0x003319A3 File Offset: 0x0032FBA3
		public unsafe bool bEvaluateInSequencePostRoll
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMovieSceneEvaluationFieldEntityMetaData.__PropertyOffset_bEvaluateInSequencePostRoll) & FMovieSceneEvaluationFieldEntityMetaData.__PropertyMask_bEvaluateInSequencePostRoll) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMovieSceneEvaluationFieldEntityMetaData.__PropertyOffset_bEvaluateInSequencePostRoll) = ((*(base.NativePtr + (IntPtr)FMovieSceneEvaluationFieldEntityMetaData.__PropertyOffset_bEvaluateInSequencePostRoll) & ~FMovieSceneEvaluationFieldEntityMetaData.__PropertyMask_bEvaluateInSequencePostRoll) | (value ? FMovieSceneEvaluationFieldEntityMetaData.__PropertyMask_bEvaluateInSequencePostRoll : 0));
			}
		}

		// Token: 0x060228C5 RID: 141509 RVA: 0x003319D3 File Offset: 0x0032FBD3
		public FMovieSceneEvaluationFieldEntityMetaData()
		{
		}

		// Token: 0x060228C6 RID: 141510 RVA: 0x003319DB File Offset: 0x0032FBDB
		public FMovieSceneEvaluationFieldEntityMetaData(FFrameNumber ForcedTime, ESectionEvaluationFlags Flags, bool bEvaluateInSequencePreRoll, bool bEvaluateInSequencePostRoll)
		{
			this.ForcedTime = ForcedTime;
			this.Flags = Flags;
			this.bEvaluateInSequencePreRoll = bEvaluateInSequencePreRoll;
			this.bEvaluateInSequencePostRoll = bEvaluateInSequencePostRoll;
		}

		// Token: 0x060228C7 RID: 141511 RVA: 0x00331A00 File Offset: 0x0032FC00
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneEvaluationFieldEntityMetaData.StaticStruct();
		}

		// Token: 0x060228C8 RID: 141512 RVA: 0x00331A0C File Offset: 0x0032FC0C
		[NullableContext(2)]
		public FMovieSceneEvaluationFieldEntityMetaData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060228C9 RID: 141513 RVA: 0x00331A16 File Offset: 0x0032FC16
		public FMovieSceneEvaluationFieldEntityMetaData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060228CA RID: 141514 RVA: 0x00331A21 File Offset: 0x0032FC21
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneEvaluationFieldEntityMetaData(Pointer, false, true);
		}

		// Token: 0x060228CB RID: 141515 RVA: 0x00331A2B File Offset: 0x0032FC2B
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneEvaluationFieldEntityMetaData(Pointer, MemoryOwner);
		}

		// Token: 0x0401276B RID: 75627
		public const string __ObjectPath = "/Script/MovieScene.MovieSceneEvaluationFieldEntityMetaData";

		// Token: 0x0401276C RID: 75628
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401276D RID: 75629
		internal static int __PropertyOffset_ForcedTime;

		// Token: 0x0401276E RID: 75630
		[Nullable(2)]
		private FFrameNumber _ForcedTime;

		// Token: 0x0401276F RID: 75631
		internal static int __PropertyOffset_Flags;

		// Token: 0x04012770 RID: 75632
		internal static int __PropertyOffset_bEvaluateInSequencePreRoll;

		// Token: 0x04012771 RID: 75633
		internal static byte __PropertyMask_bEvaluateInSequencePreRoll;

		// Token: 0x04012772 RID: 75634
		internal static int __PropertyOffset_bEvaluateInSequencePostRoll;

		// Token: 0x04012773 RID: 75635
		internal static byte __PropertyMask_bEvaluateInSequencePostRoll;
	}
}
