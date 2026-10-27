using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002524 RID: 9508
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.MovieSceneNiagaraIntegerParameterSectionTemplate")]
	[UnrealStructLayout(240, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 240)]
	public class FMovieSceneNiagaraIntegerParameterSectionTemplate : FMovieSceneNiagaraParameterSectionTemplate, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602350F RID: 144655 RVA: 0x00343BE6 File Offset: 0x00341DE6
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneNiagaraIntegerParameterSectionTemplate._ScriptStructPtr != 0) ? FMovieSceneNiagaraIntegerParameterSectionTemplate._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Niagara.MovieSceneNiagaraIntegerParameterSectionTemplate", ref FMovieSceneNiagaraIntegerParameterSectionTemplate._ScriptStructPtr);
		}

		// Token: 0x170087D1 RID: 34769
		// (get) Token: 0x06023510 RID: 144656 RVA: 0x00343C0C File Offset: 0x00341E0C
		// (set) Token: 0x06023511 RID: 144657 RVA: 0x00343C4F File Offset: 0x00341E4F
		public FMovieSceneIntegerChannel IntegerChannel
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneIntegerChannel result;
				if ((result = this._IntegerChannel) == null)
				{
					result = (this._IntegerChannel = new FMovieSceneIntegerChannel(base.NativePtr + (IntPtr)FMovieSceneNiagaraIntegerParameterSectionTemplate.__PropertyOffset_IntegerChannel, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneIntegerChannel.StaticStruct(), base.NativePtr + (IntPtr)FMovieSceneNiagaraIntegerParameterSectionTemplate.__PropertyOffset_IntegerChannel, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06023512 RID: 144658 RVA: 0x00343C70 File Offset: 0x00341E70
		public FMovieSceneNiagaraIntegerParameterSectionTemplate()
		{
		}

		// Token: 0x06023513 RID: 144659 RVA: 0x00343C78 File Offset: 0x00341E78
		public FMovieSceneNiagaraIntegerParameterSectionTemplate(FMovieSceneIntegerChannel IntegerChannel, FNiagaraVariable Parameter, EMovieSceneCompletionMode CompletionMode, [Nullable(new byte[]
		{
			0,
			1
		})] TWeakObjectPtr<UMovieSceneSection> SourceSectionPtr)
		{
			this.IntegerChannel = IntegerChannel;
			base.Parameter = Parameter;
			base.CompletionMode = CompletionMode;
			base.SourceSectionPtr = SourceSectionPtr;
		}

		// Token: 0x06023514 RID: 144660 RVA: 0x00343C9D File Offset: 0x00341E9D
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneNiagaraIntegerParameterSectionTemplate.StaticStruct();
		}

		// Token: 0x06023515 RID: 144661 RVA: 0x00343CA9 File Offset: 0x00341EA9
		[NullableContext(2)]
		public FMovieSceneNiagaraIntegerParameterSectionTemplate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06023516 RID: 144662 RVA: 0x00343CB3 File Offset: 0x00341EB3
		public FMovieSceneNiagaraIntegerParameterSectionTemplate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06023517 RID: 144663 RVA: 0x00343CBE File Offset: 0x00341EBE
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneNiagaraIntegerParameterSectionTemplate(Pointer, false, true);
		}

		// Token: 0x06023518 RID: 144664 RVA: 0x00343CC8 File Offset: 0x00341EC8
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneNiagaraIntegerParameterSectionTemplate(Pointer, MemoryOwner);
		}

		// Token: 0x04012F57 RID: 77655
		public new const string __ObjectPath = "/Script/Niagara.MovieSceneNiagaraIntegerParameterSectionTemplate";

		// Token: 0x04012F58 RID: 77656
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012F59 RID: 77657
		internal static int __PropertyOffset_IntegerChannel;

		// Token: 0x04012F5A RID: 77658
		[Nullable(2)]
		private FMovieSceneIntegerChannel _IntegerChannel;
	}
}
