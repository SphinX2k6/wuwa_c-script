using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200251E RID: 9502
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.MovieSceneNiagaraBoolParameterSectionTemplate")]
	[UnrealStructLayout(240, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 240)]
	public class FMovieSceneNiagaraBoolParameterSectionTemplate : FMovieSceneNiagaraParameterSectionTemplate, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060234D9 RID: 144601 RVA: 0x00343652 File Offset: 0x00341852
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneNiagaraBoolParameterSectionTemplate._ScriptStructPtr != 0) ? FMovieSceneNiagaraBoolParameterSectionTemplate._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Niagara.MovieSceneNiagaraBoolParameterSectionTemplate", ref FMovieSceneNiagaraBoolParameterSectionTemplate._ScriptStructPtr);
		}

		// Token: 0x170087CB RID: 34763
		// (get) Token: 0x060234DA RID: 144602 RVA: 0x00343678 File Offset: 0x00341878
		// (set) Token: 0x060234DB RID: 144603 RVA: 0x003436BB File Offset: 0x003418BB
		public FMovieSceneBoolChannel BoolChannel
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneBoolChannel result;
				if ((result = this._BoolChannel) == null)
				{
					result = (this._BoolChannel = new FMovieSceneBoolChannel(base.NativePtr + (IntPtr)FMovieSceneNiagaraBoolParameterSectionTemplate.__PropertyOffset_BoolChannel, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneBoolChannel.StaticStruct(), base.NativePtr + (IntPtr)FMovieSceneNiagaraBoolParameterSectionTemplate.__PropertyOffset_BoolChannel, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060234DC RID: 144604 RVA: 0x003436DC File Offset: 0x003418DC
		public FMovieSceneNiagaraBoolParameterSectionTemplate()
		{
		}

		// Token: 0x060234DD RID: 144605 RVA: 0x003436E4 File Offset: 0x003418E4
		public FMovieSceneNiagaraBoolParameterSectionTemplate(FMovieSceneBoolChannel BoolChannel, FNiagaraVariable Parameter, EMovieSceneCompletionMode CompletionMode, [Nullable(new byte[]
		{
			0,
			1
		})] TWeakObjectPtr<UMovieSceneSection> SourceSectionPtr)
		{
			this.BoolChannel = BoolChannel;
			base.Parameter = Parameter;
			base.CompletionMode = CompletionMode;
			base.SourceSectionPtr = SourceSectionPtr;
		}

		// Token: 0x060234DE RID: 144606 RVA: 0x00343709 File Offset: 0x00341909
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneNiagaraBoolParameterSectionTemplate.StaticStruct();
		}

		// Token: 0x060234DF RID: 144607 RVA: 0x00343715 File Offset: 0x00341915
		[NullableContext(2)]
		public FMovieSceneNiagaraBoolParameterSectionTemplate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060234E0 RID: 144608 RVA: 0x0034371F File Offset: 0x0034191F
		public FMovieSceneNiagaraBoolParameterSectionTemplate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060234E1 RID: 144609 RVA: 0x0034372A File Offset: 0x0034192A
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneNiagaraBoolParameterSectionTemplate(Pointer, false, true);
		}

		// Token: 0x060234E2 RID: 144610 RVA: 0x00343734 File Offset: 0x00341934
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneNiagaraBoolParameterSectionTemplate(Pointer, MemoryOwner);
		}

		// Token: 0x04012F39 RID: 77625
		public new const string __ObjectPath = "/Script/Niagara.MovieSceneNiagaraBoolParameterSectionTemplate";

		// Token: 0x04012F3A RID: 77626
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012F3B RID: 77627
		internal static int __PropertyOffset_BoolChannel;

		// Token: 0x04012F3C RID: 77628
		[Nullable(2)]
		private FMovieSceneBoolChannel _BoolChannel;
	}
}
