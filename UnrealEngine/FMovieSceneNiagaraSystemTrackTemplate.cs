using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200252B RID: 9515
	[UnrealObjectPath("/Script/Niagara.MovieSceneNiagaraSystemTrackTemplate")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FMovieSceneNiagaraSystemTrackTemplate : FMovieSceneEvalTemplate, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06023557 RID: 144727 RVA: 0x00344285 File Offset: 0x00342485
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneNiagaraSystemTrackTemplate._ScriptStructPtr != 0) ? FMovieSceneNiagaraSystemTrackTemplate._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Niagara.MovieSceneNiagaraSystemTrackTemplate", ref FMovieSceneNiagaraSystemTrackTemplate._ScriptStructPtr);
		}

		// Token: 0x06023558 RID: 144728 RVA: 0x003442A9 File Offset: 0x003424A9
		public FMovieSceneNiagaraSystemTrackTemplate()
		{
		}

		// Token: 0x06023559 RID: 144729 RVA: 0x003442B1 File Offset: 0x003424B1
		public FMovieSceneNiagaraSystemTrackTemplate(EMovieSceneCompletionMode CompletionMode, [Nullable(new byte[]
		{
			0,
			1
		})] TWeakObjectPtr<UMovieSceneSection> SourceSectionPtr)
		{
			base.CompletionMode = CompletionMode;
			base.SourceSectionPtr = SourceSectionPtr;
		}

		// Token: 0x0602355A RID: 144730 RVA: 0x003442C7 File Offset: 0x003424C7
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneNiagaraSystemTrackTemplate.StaticStruct();
		}

		// Token: 0x0602355B RID: 144731 RVA: 0x003442D3 File Offset: 0x003424D3
		[NullableContext(2)]
		public FMovieSceneNiagaraSystemTrackTemplate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602355C RID: 144732 RVA: 0x003442DD File Offset: 0x003424DD
		public FMovieSceneNiagaraSystemTrackTemplate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602355D RID: 144733 RVA: 0x003442E8 File Offset: 0x003424E8
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneNiagaraSystemTrackTemplate(Pointer, false, true);
		}

		// Token: 0x0602355E RID: 144734 RVA: 0x003442F2 File Offset: 0x003424F2
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneNiagaraSystemTrackTemplate(Pointer, MemoryOwner);
		}

		// Token: 0x04012F7D RID: 77693
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Niagara.MovieSceneNiagaraSystemTrackTemplate";

		// Token: 0x04012F7E RID: 77694
		private static IntPtr _ScriptStructPtr;
	}
}
