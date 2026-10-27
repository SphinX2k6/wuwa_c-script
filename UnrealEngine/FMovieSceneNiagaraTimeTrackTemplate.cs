using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200252D RID: 9517
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.MovieSceneNiagaraTimeTrackTemplate")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 192)]
	public class FMovieSceneNiagaraTimeTrackTemplate : FMovieSceneEvalTemplate, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06023565 RID: 144741 RVA: 0x00344382 File Offset: 0x00342582
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneNiagaraTimeTrackTemplate._ScriptStructPtr != 0) ? FMovieSceneNiagaraTimeTrackTemplate._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Niagara.MovieSceneNiagaraTimeTrackTemplate", ref FMovieSceneNiagaraTimeTrackTemplate._ScriptStructPtr);
		}

		// Token: 0x170087DE RID: 34782
		// (get) Token: 0x06023566 RID: 144742 RVA: 0x003443A8 File Offset: 0x003425A8
		// (set) Token: 0x06023567 RID: 144743 RVA: 0x003443EB File Offset: 0x003425EB
		public FMovieSceneFloatChannel FloatChannel
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneFloatChannel result;
				if ((result = this._FloatChannel) == null)
				{
					result = (this._FloatChannel = new FMovieSceneFloatChannel(base.NativePtr + (IntPtr)FMovieSceneNiagaraTimeTrackTemplate.__PropertyOffset_FloatChannel, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneFloatChannel.StaticStruct(), base.NativePtr + (IntPtr)FMovieSceneNiagaraTimeTrackTemplate.__PropertyOffset_FloatChannel, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06023568 RID: 144744 RVA: 0x0034440C File Offset: 0x0034260C
		public FMovieSceneNiagaraTimeTrackTemplate()
		{
		}

		// Token: 0x06023569 RID: 144745 RVA: 0x00344414 File Offset: 0x00342614
		public FMovieSceneNiagaraTimeTrackTemplate(FMovieSceneFloatChannel FloatChannel, EMovieSceneCompletionMode CompletionMode, [Nullable(new byte[]
		{
			0,
			1
		})] TWeakObjectPtr<UMovieSceneSection> SourceSectionPtr)
		{
			this.FloatChannel = FloatChannel;
			base.CompletionMode = CompletionMode;
			base.SourceSectionPtr = SourceSectionPtr;
		}

		// Token: 0x0602356A RID: 144746 RVA: 0x00344431 File Offset: 0x00342631
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneNiagaraTimeTrackTemplate.StaticStruct();
		}

		// Token: 0x0602356B RID: 144747 RVA: 0x0034443D File Offset: 0x0034263D
		[NullableContext(2)]
		public FMovieSceneNiagaraTimeTrackTemplate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602356C RID: 144748 RVA: 0x00344447 File Offset: 0x00342647
		public FMovieSceneNiagaraTimeTrackTemplate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602356D RID: 144749 RVA: 0x00344452 File Offset: 0x00342652
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneNiagaraTimeTrackTemplate(Pointer, false, true);
		}

		// Token: 0x0602356E RID: 144750 RVA: 0x0034445C File Offset: 0x0034265C
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneNiagaraTimeTrackTemplate(Pointer, MemoryOwner);
		}

		// Token: 0x04012F83 RID: 77699
		public new const string __ObjectPath = "/Script/Niagara.MovieSceneNiagaraTimeTrackTemplate";

		// Token: 0x04012F84 RID: 77700
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012F85 RID: 77701
		internal static int __PropertyOffset_FloatChannel;

		// Token: 0x04012F86 RID: 77702
		[Nullable(2)]
		private FMovieSceneFloatChannel _FloatChannel;
	}
}
