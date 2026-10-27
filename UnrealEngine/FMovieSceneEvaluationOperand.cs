using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002401 RID: 9217
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Script/MovieScene.MovieSceneEvaluationOperand")]
	[UnrealStructLayout(20, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 20)]
	public class FMovieSceneEvaluationOperand : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06022927 RID: 141607 RVA: 0x00332203 File Offset: 0x00330403
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneEvaluationOperand._ScriptStructPtr != 0) ? FMovieSceneEvaluationOperand._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieScene.MovieSceneEvaluationOperand", ref FMovieSceneEvaluationOperand._ScriptStructPtr);
		}

		// Token: 0x17008516 RID: 34070
		// (get) Token: 0x06022928 RID: 141608 RVA: 0x00332227 File Offset: 0x00330427
		// (set) Token: 0x06022929 RID: 141609 RVA: 0x0033223B File Offset: 0x0033043B
		public unsafe FGuid ObjectBindingID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneEvaluationOperand.__PropertyOffset_ObjectBindingID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneEvaluationOperand.__PropertyOffset_ObjectBindingID) = value;
			}
		}

		// Token: 0x17008517 RID: 34071
		// (get) Token: 0x0602292A RID: 141610 RVA: 0x00332250 File Offset: 0x00330450
		// (set) Token: 0x0602292B RID: 141611 RVA: 0x00332293 File Offset: 0x00330493
		public FMovieSceneSequenceID SequenceID
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneSequenceID result;
				if ((result = this._SequenceID) == null)
				{
					result = (this._SequenceID = new FMovieSceneSequenceID(base.NativePtr + (IntPtr)FMovieSceneEvaluationOperand.__PropertyOffset_SequenceID, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneSequenceID.StaticStruct(), base.NativePtr + (IntPtr)FMovieSceneEvaluationOperand.__PropertyOffset_SequenceID, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0602292C RID: 141612 RVA: 0x003322B4 File Offset: 0x003304B4
		public FMovieSceneEvaluationOperand()
		{
		}

		// Token: 0x0602292D RID: 141613 RVA: 0x003322BC File Offset: 0x003304BC
		public FMovieSceneEvaluationOperand(FGuid ObjectBindingID, FMovieSceneSequenceID SequenceID)
		{
			this.ObjectBindingID = ObjectBindingID;
			this.SequenceID = SequenceID;
		}

		// Token: 0x0602292E RID: 141614 RVA: 0x003322D2 File Offset: 0x003304D2
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneEvaluationOperand.StaticStruct();
		}

		// Token: 0x0602292F RID: 141615 RVA: 0x003322DE File Offset: 0x003304DE
		[NullableContext(2)]
		public FMovieSceneEvaluationOperand(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06022930 RID: 141616 RVA: 0x003322E8 File Offset: 0x003304E8
		public FMovieSceneEvaluationOperand(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06022931 RID: 141617 RVA: 0x003322F3 File Offset: 0x003304F3
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneEvaluationOperand(Pointer, false, true);
		}

		// Token: 0x06022932 RID: 141618 RVA: 0x003322FD File Offset: 0x003304FD
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneEvaluationOperand(Pointer, MemoryOwner);
		}

		// Token: 0x0401279C RID: 75676
		public const string __ObjectPath = "/Script/MovieScene.MovieSceneEvaluationOperand";

		// Token: 0x0401279D RID: 75677
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401279E RID: 75678
		internal static int __PropertyOffset_ObjectBindingID;

		// Token: 0x0401279F RID: 75679
		internal static int __PropertyOffset_SequenceID;

		// Token: 0x040127A0 RID: 75680
		[Nullable(2)]
		private FMovieSceneSequenceID _SequenceID;
	}
}
