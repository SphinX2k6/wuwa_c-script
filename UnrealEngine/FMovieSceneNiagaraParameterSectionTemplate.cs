using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002526 RID: 9510
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.MovieSceneNiagaraParameterSectionTemplate")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 96)]
	public class FMovieSceneNiagaraParameterSectionTemplate : FMovieSceneEvalTemplate, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602351F RID: 144671 RVA: 0x00343D56 File Offset: 0x00341F56
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneNiagaraParameterSectionTemplate._ScriptStructPtr != 0) ? FMovieSceneNiagaraParameterSectionTemplate._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Niagara.MovieSceneNiagaraParameterSectionTemplate", ref FMovieSceneNiagaraParameterSectionTemplate._ScriptStructPtr);
		}

		// Token: 0x170087D2 RID: 34770
		// (get) Token: 0x06023520 RID: 144672 RVA: 0x00343D7C File Offset: 0x00341F7C
		// (set) Token: 0x06023521 RID: 144673 RVA: 0x00343DBF File Offset: 0x00341FBF
		public FNiagaraVariable Parameter
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraVariable result;
				if ((result = this._Parameter) == null)
				{
					result = (this._Parameter = new FNiagaraVariable(base.NativePtr + (IntPtr)FMovieSceneNiagaraParameterSectionTemplate.__PropertyOffset_Parameter, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraVariable.StaticStruct(), base.NativePtr + (IntPtr)FMovieSceneNiagaraParameterSectionTemplate.__PropertyOffset_Parameter, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06023522 RID: 144674 RVA: 0x00343DE0 File Offset: 0x00341FE0
		public FMovieSceneNiagaraParameterSectionTemplate()
		{
		}

		// Token: 0x06023523 RID: 144675 RVA: 0x00343DE8 File Offset: 0x00341FE8
		public FMovieSceneNiagaraParameterSectionTemplate(FNiagaraVariable Parameter, EMovieSceneCompletionMode CompletionMode, [Nullable(new byte[]
		{
			0,
			1
		})] TWeakObjectPtr<UMovieSceneSection> SourceSectionPtr)
		{
			this.Parameter = Parameter;
			base.CompletionMode = CompletionMode;
			base.SourceSectionPtr = SourceSectionPtr;
		}

		// Token: 0x06023524 RID: 144676 RVA: 0x00343E05 File Offset: 0x00342005
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneNiagaraParameterSectionTemplate.StaticStruct();
		}

		// Token: 0x06023525 RID: 144677 RVA: 0x00343E11 File Offset: 0x00342011
		[NullableContext(2)]
		public FMovieSceneNiagaraParameterSectionTemplate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06023526 RID: 144678 RVA: 0x00343E1B File Offset: 0x0034201B
		public FMovieSceneNiagaraParameterSectionTemplate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06023527 RID: 144679 RVA: 0x00343E26 File Offset: 0x00342026
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneNiagaraParameterSectionTemplate(Pointer, false, true);
		}

		// Token: 0x06023528 RID: 144680 RVA: 0x00343E30 File Offset: 0x00342030
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneNiagaraParameterSectionTemplate(Pointer, MemoryOwner);
		}

		// Token: 0x04012F5F RID: 77663
		public new const string __ObjectPath = "/Script/Niagara.MovieSceneNiagaraParameterSectionTemplate";

		// Token: 0x04012F60 RID: 77664
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012F61 RID: 77665
		internal static int __PropertyOffset_Parameter;

		// Token: 0x04012F62 RID: 77666
		[Nullable(2)]
		private FNiagaraVariable _Parameter;
	}
}
