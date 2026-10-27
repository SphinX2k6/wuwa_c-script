using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200252A RID: 9514
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.MovieSceneNiagaraSystemTrackImplementation")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FMovieSceneNiagaraSystemTrackImplementation : FMovieSceneTrackImplementation, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06023543 RID: 144707 RVA: 0x003440A2 File Offset: 0x003422A2
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneNiagaraSystemTrackImplementation._ScriptStructPtr != 0) ? FMovieSceneNiagaraSystemTrackImplementation._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Niagara.MovieSceneNiagaraSystemTrackImplementation", ref FMovieSceneNiagaraSystemTrackImplementation._ScriptStructPtr);
		}

		// Token: 0x170087D8 RID: 34776
		// (get) Token: 0x06023544 RID: 144708 RVA: 0x003440C8 File Offset: 0x003422C8
		// (set) Token: 0x06023545 RID: 144709 RVA: 0x0034410B File Offset: 0x0034230B
		public FFrameNumber SpawnSectionStartFrame
		{
			get
			{
				base.FastCheckIsValid();
				FFrameNumber result;
				if ((result = this._SpawnSectionStartFrame) == null)
				{
					result = (this._SpawnSectionStartFrame = new FFrameNumber(base.NativePtr + (IntPtr)FMovieSceneNiagaraSystemTrackImplementation.__PropertyOffset_SpawnSectionStartFrame, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FFrameNumber.StaticStruct(), base.NativePtr + (IntPtr)FMovieSceneNiagaraSystemTrackImplementation.__PropertyOffset_SpawnSectionStartFrame, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170087D9 RID: 34777
		// (get) Token: 0x06023546 RID: 144710 RVA: 0x0034412C File Offset: 0x0034232C
		// (set) Token: 0x06023547 RID: 144711 RVA: 0x0034416F File Offset: 0x0034236F
		public FFrameNumber SpawnSectionEndFrame
		{
			get
			{
				base.FastCheckIsValid();
				FFrameNumber result;
				if ((result = this._SpawnSectionEndFrame) == null)
				{
					result = (this._SpawnSectionEndFrame = new FFrameNumber(base.NativePtr + (IntPtr)FMovieSceneNiagaraSystemTrackImplementation.__PropertyOffset_SpawnSectionEndFrame, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FFrameNumber.StaticStruct(), base.NativePtr + (IntPtr)FMovieSceneNiagaraSystemTrackImplementation.__PropertyOffset_SpawnSectionEndFrame, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170087DA RID: 34778
		// (get) Token: 0x06023548 RID: 144712 RVA: 0x00344190 File Offset: 0x00342390
		// (set) Token: 0x06023549 RID: 144713 RVA: 0x003441A0 File Offset: 0x003423A0
		public unsafe ENiagaraSystemSpawnSectionStartBehavior SpawnSectionStartBehavior
		{
			get
			{
				return (ENiagaraSystemSpawnSectionStartBehavior)(*(base.NativePtr + (IntPtr)FMovieSceneNiagaraSystemTrackImplementation.__PropertyOffset_SpawnSectionStartBehavior));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneNiagaraSystemTrackImplementation.__PropertyOffset_SpawnSectionStartBehavior) = (int)value;
			}
		}

		// Token: 0x170087DB RID: 34779
		// (get) Token: 0x0602354A RID: 144714 RVA: 0x003441B1 File Offset: 0x003423B1
		// (set) Token: 0x0602354B RID: 144715 RVA: 0x003441C1 File Offset: 0x003423C1
		public unsafe ENiagaraSystemSpawnSectionEvaluateBehavior SpawnSectionEvaluateBehavior
		{
			get
			{
				return (ENiagaraSystemSpawnSectionEvaluateBehavior)(*(base.NativePtr + (IntPtr)FMovieSceneNiagaraSystemTrackImplementation.__PropertyOffset_SpawnSectionEvaluateBehavior));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneNiagaraSystemTrackImplementation.__PropertyOffset_SpawnSectionEvaluateBehavior) = (int)value;
			}
		}

		// Token: 0x170087DC RID: 34780
		// (get) Token: 0x0602354C RID: 144716 RVA: 0x003441D2 File Offset: 0x003423D2
		// (set) Token: 0x0602354D RID: 144717 RVA: 0x003441E2 File Offset: 0x003423E2
		public unsafe ENiagaraSystemSpawnSectionEndBehavior SpawnSectionEndBehavior
		{
			get
			{
				return (ENiagaraSystemSpawnSectionEndBehavior)(*(base.NativePtr + (IntPtr)FMovieSceneNiagaraSystemTrackImplementation.__PropertyOffset_SpawnSectionEndBehavior));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneNiagaraSystemTrackImplementation.__PropertyOffset_SpawnSectionEndBehavior) = (int)value;
			}
		}

		// Token: 0x170087DD RID: 34781
		// (get) Token: 0x0602354E RID: 144718 RVA: 0x003441F3 File Offset: 0x003423F3
		// (set) Token: 0x0602354F RID: 144719 RVA: 0x00344203 File Offset: 0x00342403
		public unsafe ENiagaraAgeUpdateMode AgeUpdateMode
		{
			get
			{
				return (ENiagaraAgeUpdateMode)(*(base.NativePtr + (IntPtr)FMovieSceneNiagaraSystemTrackImplementation.__PropertyOffset_AgeUpdateMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneNiagaraSystemTrackImplementation.__PropertyOffset_AgeUpdateMode) = (byte)value;
			}
		}

		// Token: 0x06023550 RID: 144720 RVA: 0x00344214 File Offset: 0x00342414
		public FMovieSceneNiagaraSystemTrackImplementation()
		{
		}

		// Token: 0x06023551 RID: 144721 RVA: 0x0034421C File Offset: 0x0034241C
		public FMovieSceneNiagaraSystemTrackImplementation(FFrameNumber SpawnSectionStartFrame, FFrameNumber SpawnSectionEndFrame, ENiagaraSystemSpawnSectionStartBehavior SpawnSectionStartBehavior, ENiagaraSystemSpawnSectionEvaluateBehavior SpawnSectionEvaluateBehavior, ENiagaraSystemSpawnSectionEndBehavior SpawnSectionEndBehavior, ENiagaraAgeUpdateMode AgeUpdateMode)
		{
			this.SpawnSectionStartFrame = SpawnSectionStartFrame;
			this.SpawnSectionEndFrame = SpawnSectionEndFrame;
			this.SpawnSectionStartBehavior = SpawnSectionStartBehavior;
			this.SpawnSectionEvaluateBehavior = SpawnSectionEvaluateBehavior;
			this.SpawnSectionEndBehavior = SpawnSectionEndBehavior;
			this.AgeUpdateMode = AgeUpdateMode;
		}

		// Token: 0x06023552 RID: 144722 RVA: 0x00344251 File Offset: 0x00342451
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneNiagaraSystemTrackImplementation.StaticStruct();
		}

		// Token: 0x06023553 RID: 144723 RVA: 0x0034425D File Offset: 0x0034245D
		[NullableContext(2)]
		public FMovieSceneNiagaraSystemTrackImplementation(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06023554 RID: 144724 RVA: 0x00344267 File Offset: 0x00342467
		public FMovieSceneNiagaraSystemTrackImplementation(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06023555 RID: 144725 RVA: 0x00344272 File Offset: 0x00342472
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneNiagaraSystemTrackImplementation(Pointer, false, true);
		}

		// Token: 0x06023556 RID: 144726 RVA: 0x0034427C File Offset: 0x0034247C
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneNiagaraSystemTrackImplementation(Pointer, MemoryOwner);
		}

		// Token: 0x04012F73 RID: 77683
		public new const string __ObjectPath = "/Script/Niagara.MovieSceneNiagaraSystemTrackImplementation";

		// Token: 0x04012F74 RID: 77684
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012F75 RID: 77685
		internal static int __PropertyOffset_SpawnSectionStartFrame;

		// Token: 0x04012F76 RID: 77686
		[Nullable(2)]
		private FFrameNumber _SpawnSectionStartFrame;

		// Token: 0x04012F77 RID: 77687
		internal static int __PropertyOffset_SpawnSectionEndFrame;

		// Token: 0x04012F78 RID: 77688
		[Nullable(2)]
		private FFrameNumber _SpawnSectionEndFrame;

		// Token: 0x04012F79 RID: 77689
		internal static int __PropertyOffset_SpawnSectionStartBehavior;

		// Token: 0x04012F7A RID: 77690
		internal static int __PropertyOffset_SpawnSectionEvaluateBehavior;

		// Token: 0x04012F7B RID: 77691
		internal static int __PropertyOffset_SpawnSectionEndBehavior;

		// Token: 0x04012F7C RID: 77692
		internal static int __PropertyOffset_AgeUpdateMode;
	}
}
