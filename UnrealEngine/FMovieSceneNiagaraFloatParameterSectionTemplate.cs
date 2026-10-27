using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002522 RID: 9506
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.MovieSceneNiagaraFloatParameterSectionTemplate")]
	[UnrealStructLayout(256, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 256)]
	public class FMovieSceneNiagaraFloatParameterSectionTemplate : FMovieSceneNiagaraParameterSectionTemplate, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060234FF RID: 144639 RVA: 0x00343A76 File Offset: 0x00341C76
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneNiagaraFloatParameterSectionTemplate._ScriptStructPtr != 0) ? FMovieSceneNiagaraFloatParameterSectionTemplate._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Niagara.MovieSceneNiagaraFloatParameterSectionTemplate", ref FMovieSceneNiagaraFloatParameterSectionTemplate._ScriptStructPtr);
		}

		// Token: 0x170087D0 RID: 34768
		// (get) Token: 0x06023500 RID: 144640 RVA: 0x00343A9C File Offset: 0x00341C9C
		// (set) Token: 0x06023501 RID: 144641 RVA: 0x00343ADF File Offset: 0x00341CDF
		public FMovieSceneFloatChannel FloatChannel
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneFloatChannel result;
				if ((result = this._FloatChannel) == null)
				{
					result = (this._FloatChannel = new FMovieSceneFloatChannel(base.NativePtr + (IntPtr)FMovieSceneNiagaraFloatParameterSectionTemplate.__PropertyOffset_FloatChannel, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneFloatChannel.StaticStruct(), base.NativePtr + (IntPtr)FMovieSceneNiagaraFloatParameterSectionTemplate.__PropertyOffset_FloatChannel, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06023502 RID: 144642 RVA: 0x00343B00 File Offset: 0x00341D00
		public FMovieSceneNiagaraFloatParameterSectionTemplate()
		{
		}

		// Token: 0x06023503 RID: 144643 RVA: 0x00343B08 File Offset: 0x00341D08
		public FMovieSceneNiagaraFloatParameterSectionTemplate(FMovieSceneFloatChannel FloatChannel, FNiagaraVariable Parameter, EMovieSceneCompletionMode CompletionMode, [Nullable(new byte[]
		{
			0,
			1
		})] TWeakObjectPtr<UMovieSceneSection> SourceSectionPtr)
		{
			this.FloatChannel = FloatChannel;
			base.Parameter = Parameter;
			base.CompletionMode = CompletionMode;
			base.SourceSectionPtr = SourceSectionPtr;
		}

		// Token: 0x06023504 RID: 144644 RVA: 0x00343B2D File Offset: 0x00341D2D
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneNiagaraFloatParameterSectionTemplate.StaticStruct();
		}

		// Token: 0x06023505 RID: 144645 RVA: 0x00343B39 File Offset: 0x00341D39
		[NullableContext(2)]
		public FMovieSceneNiagaraFloatParameterSectionTemplate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06023506 RID: 144646 RVA: 0x00343B43 File Offset: 0x00341D43
		public FMovieSceneNiagaraFloatParameterSectionTemplate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06023507 RID: 144647 RVA: 0x00343B4E File Offset: 0x00341D4E
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneNiagaraFloatParameterSectionTemplate(Pointer, false, true);
		}

		// Token: 0x06023508 RID: 144648 RVA: 0x00343B58 File Offset: 0x00341D58
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneNiagaraFloatParameterSectionTemplate(Pointer, MemoryOwner);
		}

		// Token: 0x04012F4F RID: 77647
		public new const string __ObjectPath = "/Script/Niagara.MovieSceneNiagaraFloatParameterSectionTemplate";

		// Token: 0x04012F50 RID: 77648
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012F51 RID: 77649
		internal static int __PropertyOffset_FloatChannel;

		// Token: 0x04012F52 RID: 77650
		[Nullable(2)]
		private FMovieSceneFloatChannel _FloatChannel;
	}
}
