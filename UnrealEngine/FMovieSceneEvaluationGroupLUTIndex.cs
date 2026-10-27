using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020023FE RID: 9214
	[UnrealObjectPath("/Script/MovieScene.MovieSceneEvaluationGroupLUTIndex")]
	[UnrealStructLayout(8, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 8)]
	public class FMovieSceneEvaluationGroupLUTIndex : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06022901 RID: 141569 RVA: 0x00331EC6 File Offset: 0x003300C6
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneEvaluationGroupLUTIndex._ScriptStructPtr != 0) ? FMovieSceneEvaluationGroupLUTIndex._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieScene.MovieSceneEvaluationGroupLUTIndex", ref FMovieSceneEvaluationGroupLUTIndex._ScriptStructPtr);
		}

		// Token: 0x1700850F RID: 34063
		// (get) Token: 0x06022902 RID: 141570 RVA: 0x00331EEA File Offset: 0x003300EA
		// (set) Token: 0x06022903 RID: 141571 RVA: 0x00331EFA File Offset: 0x003300FA
		public unsafe int NumInitPtrs
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneEvaluationGroupLUTIndex.__PropertyOffset_NumInitPtrs);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneEvaluationGroupLUTIndex.__PropertyOffset_NumInitPtrs) = value;
			}
		}

		// Token: 0x17008510 RID: 34064
		// (get) Token: 0x06022904 RID: 141572 RVA: 0x00331F0B File Offset: 0x0033010B
		// (set) Token: 0x06022905 RID: 141573 RVA: 0x00331F1B File Offset: 0x0033011B
		public unsafe int NumEvalPtrs
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneEvaluationGroupLUTIndex.__PropertyOffset_NumEvalPtrs);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneEvaluationGroupLUTIndex.__PropertyOffset_NumEvalPtrs) = value;
			}
		}

		// Token: 0x06022906 RID: 141574 RVA: 0x00331F2C File Offset: 0x0033012C
		public FMovieSceneEvaluationGroupLUTIndex()
		{
		}

		// Token: 0x06022907 RID: 141575 RVA: 0x00331F34 File Offset: 0x00330134
		public FMovieSceneEvaluationGroupLUTIndex(int NumInitPtrs, int NumEvalPtrs)
		{
			this.NumInitPtrs = NumInitPtrs;
			this.NumEvalPtrs = NumEvalPtrs;
		}

		// Token: 0x06022908 RID: 141576 RVA: 0x00331F4A File Offset: 0x0033014A
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneEvaluationGroupLUTIndex.StaticStruct();
		}

		// Token: 0x06022909 RID: 141577 RVA: 0x00331F56 File Offset: 0x00330156
		[NullableContext(2)]
		public FMovieSceneEvaluationGroupLUTIndex(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602290A RID: 141578 RVA: 0x00331F60 File Offset: 0x00330160
		public FMovieSceneEvaluationGroupLUTIndex(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602290B RID: 141579 RVA: 0x00331F6B File Offset: 0x0033016B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneEvaluationGroupLUTIndex(Pointer, false, true);
		}

		// Token: 0x0602290C RID: 141580 RVA: 0x00331F75 File Offset: 0x00330175
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneEvaluationGroupLUTIndex(Pointer, MemoryOwner);
		}

		// Token: 0x0401278B RID: 75659
		[Nullable(1)]
		public const string __ObjectPath = "/Script/MovieScene.MovieSceneEvaluationGroupLUTIndex";

		// Token: 0x0401278C RID: 75660
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401278D RID: 75661
		internal static int __PropertyOffset_NumInitPtrs;

		// Token: 0x0401278E RID: 75662
		internal static int __PropertyOffset_NumEvalPtrs;
	}
}
