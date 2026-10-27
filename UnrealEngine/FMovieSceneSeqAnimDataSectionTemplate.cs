using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020026FD RID: 9981
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SequenceDialogue.MovieSceneSeqAnimDataSectionTemplate")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FMovieSceneSeqAnimDataSectionTemplate : FMovieSceneEvalTemplate, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602504B RID: 151627 RVA: 0x0036C3B8 File Offset: 0x0036A5B8
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneSeqAnimDataSectionTemplate._ScriptStructPtr != 0) ? FMovieSceneSeqAnimDataSectionTemplate._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SequenceDialogue.MovieSceneSeqAnimDataSectionTemplate", ref FMovieSceneSeqAnimDataSectionTemplate._ScriptStructPtr);
		}

		// Token: 0x17008EEA RID: 36586
		// (get) Token: 0x0602504C RID: 151628 RVA: 0x0036C3DC File Offset: 0x0036A5DC
		// (set) Token: 0x0602504D RID: 151629 RVA: 0x0036C41F File Offset: 0x0036A61F
		public TArray<FFloatNameAndCurve> FloatCurves
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FFloatNameAndCurve> result;
				if ((result = this._FloatCurves) == null)
				{
					result = (this._FloatCurves = new TArray<FFloatNameAndCurve>(base.NativePtr + (IntPtr)FMovieSceneSeqAnimDataSectionTemplate.__PropertyOffset_FloatCurves, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.FloatCurves.CopyAssign(value);
			}
		}

		// Token: 0x17008EEB RID: 36587
		// (get) Token: 0x0602504E RID: 151630 RVA: 0x0036C430 File Offset: 0x0036A630
		// (set) Token: 0x0602504F RID: 151631 RVA: 0x0036C473 File Offset: 0x0036A673
		public TArray<FVectorNameAndCurve> VectorCurves
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVectorNameAndCurve> result;
				if ((result = this._VectorCurves) == null)
				{
					result = (this._VectorCurves = new TArray<FVectorNameAndCurve>(base.NativePtr + (IntPtr)FMovieSceneSeqAnimDataSectionTemplate.__PropertyOffset_VectorCurves, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.VectorCurves.CopyAssign(value);
			}
		}

		// Token: 0x06025050 RID: 151632 RVA: 0x0036C481 File Offset: 0x0036A681
		public FMovieSceneSeqAnimDataSectionTemplate()
		{
		}

		// Token: 0x06025051 RID: 151633 RVA: 0x0036C489 File Offset: 0x0036A689
		public FMovieSceneSeqAnimDataSectionTemplate(TArray<FFloatNameAndCurve> FloatCurves, TArray<FVectorNameAndCurve> VectorCurves, EMovieSceneCompletionMode CompletionMode, [Nullable(new byte[]
		{
			0,
			1
		})] TWeakObjectPtr<UMovieSceneSection> SourceSectionPtr)
		{
			this.FloatCurves = FloatCurves;
			this.VectorCurves = VectorCurves;
			base.CompletionMode = CompletionMode;
			base.SourceSectionPtr = SourceSectionPtr;
		}

		// Token: 0x06025052 RID: 151634 RVA: 0x0036C4AE File Offset: 0x0036A6AE
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneSeqAnimDataSectionTemplate.StaticStruct();
		}

		// Token: 0x06025053 RID: 151635 RVA: 0x0036C4BA File Offset: 0x0036A6BA
		[NullableContext(2)]
		public FMovieSceneSeqAnimDataSectionTemplate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06025054 RID: 151636 RVA: 0x0036C4C4 File Offset: 0x0036A6C4
		public FMovieSceneSeqAnimDataSectionTemplate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06025055 RID: 151637 RVA: 0x0036C4CF File Offset: 0x0036A6CF
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneSeqAnimDataSectionTemplate(Pointer, false, true);
		}

		// Token: 0x06025056 RID: 151638 RVA: 0x0036C4D9 File Offset: 0x0036A6D9
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneSeqAnimDataSectionTemplate(Pointer, MemoryOwner);
		}

		// Token: 0x04013F27 RID: 81703
		public new const string __ObjectPath = "/Script/SequenceDialogue.MovieSceneSeqAnimDataSectionTemplate";

		// Token: 0x04013F28 RID: 81704
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04013F29 RID: 81705
		internal static int __PropertyOffset_FloatCurves;

		// Token: 0x04013F2A RID: 81706
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FFloatNameAndCurve> _FloatCurves;

		// Token: 0x04013F2B RID: 81707
		internal static int __PropertyOffset_VectorCurves;

		// Token: 0x04013F2C RID: 81708
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FVectorNameAndCurve> _VectorCurves;
	}
}
