using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200252F RID: 9519
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.MovieSceneNiagaraVectorParameterSectionTemplate")]
	[UnrealStructLayout(744, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 744)]
	public class FMovieSceneNiagaraVectorParameterSectionTemplate : FMovieSceneNiagaraParameterSectionTemplate, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06023576 RID: 144758 RVA: 0x0034452E File Offset: 0x0034272E
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneNiagaraVectorParameterSectionTemplate._ScriptStructPtr != 0) ? FMovieSceneNiagaraVectorParameterSectionTemplate._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Niagara.MovieSceneNiagaraVectorParameterSectionTemplate", ref FMovieSceneNiagaraVectorParameterSectionTemplate._ScriptStructPtr);
		}

		// Token: 0x170087E0 RID: 34784
		// (get) Token: 0x06023577 RID: 144759 RVA: 0x00344554 File Offset: 0x00342754
		// (set) Token: 0x06023578 RID: 144760 RVA: 0x00344598 File Offset: 0x00342798
		public TFixedArray<FMovieSceneFloatChannel> VectorChannels
		{
			get
			{
				base.FastCheckIsValid();
				TFixedArray<FMovieSceneFloatChannel> result;
				if ((result = this._VectorChannels) == null)
				{
					result = (this._VectorChannels = new TFixedArray<FMovieSceneFloatChannel>(base.NativePtr + (IntPtr)FMovieSceneNiagaraVectorParameterSectionTemplate.__PropertyOffset_VectorChannels, 4, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.VectorChannels.CopyAssign(value);
			}
		}

		// Token: 0x170087E1 RID: 34785
		// (get) Token: 0x06023579 RID: 144761 RVA: 0x003445A6 File Offset: 0x003427A6
		// (set) Token: 0x0602357A RID: 144762 RVA: 0x003445B6 File Offset: 0x003427B6
		public unsafe int ChannelsUsed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneNiagaraVectorParameterSectionTemplate.__PropertyOffset_ChannelsUsed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneNiagaraVectorParameterSectionTemplate.__PropertyOffset_ChannelsUsed) = value;
			}
		}

		// Token: 0x0602357B RID: 144763 RVA: 0x003445C7 File Offset: 0x003427C7
		public FMovieSceneNiagaraVectorParameterSectionTemplate()
		{
		}

		// Token: 0x0602357C RID: 144764 RVA: 0x003445CF File Offset: 0x003427CF
		public FMovieSceneNiagaraVectorParameterSectionTemplate(TFixedArray<FMovieSceneFloatChannel> VectorChannels, int ChannelsUsed, FNiagaraVariable Parameter, EMovieSceneCompletionMode CompletionMode, [Nullable(new byte[]
		{
			0,
			1
		})] TWeakObjectPtr<UMovieSceneSection> SourceSectionPtr)
		{
			this.VectorChannels = VectorChannels;
			this.ChannelsUsed = ChannelsUsed;
			base.Parameter = Parameter;
			base.CompletionMode = CompletionMode;
			base.SourceSectionPtr = SourceSectionPtr;
		}

		// Token: 0x0602357D RID: 144765 RVA: 0x003445FC File Offset: 0x003427FC
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneNiagaraVectorParameterSectionTemplate.StaticStruct();
		}

		// Token: 0x0602357E RID: 144766 RVA: 0x00344608 File Offset: 0x00342808
		[NullableContext(2)]
		public FMovieSceneNiagaraVectorParameterSectionTemplate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602357F RID: 144767 RVA: 0x00344612 File Offset: 0x00342812
		public FMovieSceneNiagaraVectorParameterSectionTemplate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06023580 RID: 144768 RVA: 0x0034461D File Offset: 0x0034281D
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneNiagaraVectorParameterSectionTemplate(Pointer, false, true);
		}

		// Token: 0x06023581 RID: 144769 RVA: 0x00344627 File Offset: 0x00342827
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneNiagaraVectorParameterSectionTemplate(Pointer, MemoryOwner);
		}

		// Token: 0x04012F8C RID: 77708
		public new const string __ObjectPath = "/Script/Niagara.MovieSceneNiagaraVectorParameterSectionTemplate";

		// Token: 0x04012F8D RID: 77709
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012F8E RID: 77710
		internal static int __PropertyOffset_VectorChannels;

		// Token: 0x04012F8F RID: 77711
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TFixedArray<FMovieSceneFloatChannel> _VectorChannels;

		// Token: 0x04012F90 RID: 77712
		internal static int __PropertyOffset_ChannelsUsed;
	}
}
