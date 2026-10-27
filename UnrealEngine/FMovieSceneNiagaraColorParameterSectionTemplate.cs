using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002520 RID: 9504
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.MovieSceneNiagaraColorParameterSectionTemplate")]
	[UnrealStructLayout(736, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 736)]
	public class FMovieSceneNiagaraColorParameterSectionTemplate : FMovieSceneNiagaraParameterSectionTemplate, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060234E9 RID: 144617 RVA: 0x003437C2 File Offset: 0x003419C2
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneNiagaraColorParameterSectionTemplate._ScriptStructPtr != 0) ? FMovieSceneNiagaraColorParameterSectionTemplate._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Niagara.MovieSceneNiagaraColorParameterSectionTemplate", ref FMovieSceneNiagaraColorParameterSectionTemplate._ScriptStructPtr);
		}

		// Token: 0x170087CC RID: 34764
		// (get) Token: 0x060234EA RID: 144618 RVA: 0x003437E8 File Offset: 0x003419E8
		// (set) Token: 0x060234EB RID: 144619 RVA: 0x0034382B File Offset: 0x00341A2B
		public FMovieSceneFloatChannel RedChannel
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneFloatChannel result;
				if ((result = this._RedChannel) == null)
				{
					result = (this._RedChannel = new FMovieSceneFloatChannel(base.NativePtr + (IntPtr)FMovieSceneNiagaraColorParameterSectionTemplate.__PropertyOffset_RedChannel, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneFloatChannel.StaticStruct(), base.NativePtr + (IntPtr)FMovieSceneNiagaraColorParameterSectionTemplate.__PropertyOffset_RedChannel, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170087CD RID: 34765
		// (get) Token: 0x060234EC RID: 144620 RVA: 0x0034384C File Offset: 0x00341A4C
		// (set) Token: 0x060234ED RID: 144621 RVA: 0x0034388F File Offset: 0x00341A8F
		public FMovieSceneFloatChannel GreenChannel
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneFloatChannel result;
				if ((result = this._GreenChannel) == null)
				{
					result = (this._GreenChannel = new FMovieSceneFloatChannel(base.NativePtr + (IntPtr)FMovieSceneNiagaraColorParameterSectionTemplate.__PropertyOffset_GreenChannel, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneFloatChannel.StaticStruct(), base.NativePtr + (IntPtr)FMovieSceneNiagaraColorParameterSectionTemplate.__PropertyOffset_GreenChannel, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170087CE RID: 34766
		// (get) Token: 0x060234EE RID: 144622 RVA: 0x003438B0 File Offset: 0x00341AB0
		// (set) Token: 0x060234EF RID: 144623 RVA: 0x003438F3 File Offset: 0x00341AF3
		public FMovieSceneFloatChannel BlueChannel
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneFloatChannel result;
				if ((result = this._BlueChannel) == null)
				{
					result = (this._BlueChannel = new FMovieSceneFloatChannel(base.NativePtr + (IntPtr)FMovieSceneNiagaraColorParameterSectionTemplate.__PropertyOffset_BlueChannel, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneFloatChannel.StaticStruct(), base.NativePtr + (IntPtr)FMovieSceneNiagaraColorParameterSectionTemplate.__PropertyOffset_BlueChannel, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170087CF RID: 34767
		// (get) Token: 0x060234F0 RID: 144624 RVA: 0x00343914 File Offset: 0x00341B14
		// (set) Token: 0x060234F1 RID: 144625 RVA: 0x00343957 File Offset: 0x00341B57
		public FMovieSceneFloatChannel AlphaChannel
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneFloatChannel result;
				if ((result = this._AlphaChannel) == null)
				{
					result = (this._AlphaChannel = new FMovieSceneFloatChannel(base.NativePtr + (IntPtr)FMovieSceneNiagaraColorParameterSectionTemplate.__PropertyOffset_AlphaChannel, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneFloatChannel.StaticStruct(), base.NativePtr + (IntPtr)FMovieSceneNiagaraColorParameterSectionTemplate.__PropertyOffset_AlphaChannel, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060234F2 RID: 144626 RVA: 0x00343978 File Offset: 0x00341B78
		public FMovieSceneNiagaraColorParameterSectionTemplate()
		{
		}

		// Token: 0x060234F3 RID: 144627 RVA: 0x00343980 File Offset: 0x00341B80
		public FMovieSceneNiagaraColorParameterSectionTemplate(FMovieSceneFloatChannel RedChannel, FMovieSceneFloatChannel GreenChannel, FMovieSceneFloatChannel BlueChannel, FMovieSceneFloatChannel AlphaChannel, FNiagaraVariable Parameter, EMovieSceneCompletionMode CompletionMode, [Nullable(new byte[]
		{
			0,
			1
		})] TWeakObjectPtr<UMovieSceneSection> SourceSectionPtr)
		{
			this.RedChannel = RedChannel;
			this.GreenChannel = GreenChannel;
			this.BlueChannel = BlueChannel;
			this.AlphaChannel = AlphaChannel;
			base.Parameter = Parameter;
			base.CompletionMode = CompletionMode;
			base.SourceSectionPtr = SourceSectionPtr;
		}

		// Token: 0x060234F4 RID: 144628 RVA: 0x003439BD File Offset: 0x00341BBD
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneNiagaraColorParameterSectionTemplate.StaticStruct();
		}

		// Token: 0x060234F5 RID: 144629 RVA: 0x003439C9 File Offset: 0x00341BC9
		[NullableContext(2)]
		public FMovieSceneNiagaraColorParameterSectionTemplate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060234F6 RID: 144630 RVA: 0x003439D3 File Offset: 0x00341BD3
		public FMovieSceneNiagaraColorParameterSectionTemplate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060234F7 RID: 144631 RVA: 0x003439DE File Offset: 0x00341BDE
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneNiagaraColorParameterSectionTemplate(Pointer, false, true);
		}

		// Token: 0x060234F8 RID: 144632 RVA: 0x003439E8 File Offset: 0x00341BE8
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneNiagaraColorParameterSectionTemplate(Pointer, MemoryOwner);
		}

		// Token: 0x04012F41 RID: 77633
		public new const string __ObjectPath = "/Script/Niagara.MovieSceneNiagaraColorParameterSectionTemplate";

		// Token: 0x04012F42 RID: 77634
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012F43 RID: 77635
		internal static int __PropertyOffset_RedChannel;

		// Token: 0x04012F44 RID: 77636
		[Nullable(2)]
		private FMovieSceneFloatChannel _RedChannel;

		// Token: 0x04012F45 RID: 77637
		internal static int __PropertyOffset_GreenChannel;

		// Token: 0x04012F46 RID: 77638
		[Nullable(2)]
		private FMovieSceneFloatChannel _GreenChannel;

		// Token: 0x04012F47 RID: 77639
		internal static int __PropertyOffset_BlueChannel;

		// Token: 0x04012F48 RID: 77640
		[Nullable(2)]
		private FMovieSceneFloatChannel _BlueChannel;

		// Token: 0x04012F49 RID: 77641
		internal static int __PropertyOffset_AlphaChannel;

		// Token: 0x04012F4A RID: 77642
		[Nullable(2)]
		private FMovieSceneFloatChannel _AlphaChannel;
	}
}
