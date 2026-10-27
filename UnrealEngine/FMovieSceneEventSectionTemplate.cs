using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002374 RID: 9076
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneEventSectionTemplate")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 192)]
	public class FMovieSceneEventSectionTemplate : FMovieSceneEvalTemplate, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060223EC RID: 140268 RVA: 0x0032A3CB File Offset: 0x003285CB
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneEventSectionTemplate._ScriptStructPtr != 0) ? FMovieSceneEventSectionTemplate._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieSceneTracks.MovieSceneEventSectionTemplate", ref FMovieSceneEventSectionTemplate._ScriptStructPtr);
		}

		// Token: 0x17008421 RID: 33825
		// (get) Token: 0x060223ED RID: 140269 RVA: 0x0032A3F0 File Offset: 0x003285F0
		// (set) Token: 0x060223EE RID: 140270 RVA: 0x0032A433 File Offset: 0x00328633
		public FMovieSceneEventSectionData EventData
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneEventSectionData result;
				if ((result = this._EventData) == null)
				{
					result = (this._EventData = new FMovieSceneEventSectionData(base.NativePtr + (IntPtr)FMovieSceneEventSectionTemplate.__PropertyOffset_EventData, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneEventSectionData.StaticStruct(), base.NativePtr + (IntPtr)FMovieSceneEventSectionTemplate.__PropertyOffset_EventData, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008422 RID: 33826
		// (get) Token: 0x060223EF RID: 140271 RVA: 0x0032A454 File Offset: 0x00328654
		// (set) Token: 0x060223F0 RID: 140272 RVA: 0x0032A46D File Offset: 0x0032866D
		public unsafe bool bFireEventsWhenForwards
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMovieSceneEventSectionTemplate.__PropertyOffset_bFireEventsWhenForwards) & FMovieSceneEventSectionTemplate.__PropertyMask_bFireEventsWhenForwards) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMovieSceneEventSectionTemplate.__PropertyOffset_bFireEventsWhenForwards) = ((*(base.NativePtr + (IntPtr)FMovieSceneEventSectionTemplate.__PropertyOffset_bFireEventsWhenForwards) & ~FMovieSceneEventSectionTemplate.__PropertyMask_bFireEventsWhenForwards) | (value ? FMovieSceneEventSectionTemplate.__PropertyMask_bFireEventsWhenForwards : 0));
			}
		}

		// Token: 0x17008423 RID: 33827
		// (get) Token: 0x060223F1 RID: 140273 RVA: 0x0032A49D File Offset: 0x0032869D
		// (set) Token: 0x060223F2 RID: 140274 RVA: 0x0032A4B6 File Offset: 0x003286B6
		public unsafe bool bFireEventsWhenBackwards
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMovieSceneEventSectionTemplate.__PropertyOffset_bFireEventsWhenBackwards) & FMovieSceneEventSectionTemplate.__PropertyMask_bFireEventsWhenBackwards) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMovieSceneEventSectionTemplate.__PropertyOffset_bFireEventsWhenBackwards) = ((*(base.NativePtr + (IntPtr)FMovieSceneEventSectionTemplate.__PropertyOffset_bFireEventsWhenBackwards) & ~FMovieSceneEventSectionTemplate.__PropertyMask_bFireEventsWhenBackwards) | (value ? FMovieSceneEventSectionTemplate.__PropertyMask_bFireEventsWhenBackwards : 0));
			}
		}

		// Token: 0x060223F3 RID: 140275 RVA: 0x0032A4E6 File Offset: 0x003286E6
		public FMovieSceneEventSectionTemplate()
		{
		}

		// Token: 0x060223F4 RID: 140276 RVA: 0x0032A4EE File Offset: 0x003286EE
		public FMovieSceneEventSectionTemplate(FMovieSceneEventSectionData EventData, bool bFireEventsWhenForwards, bool bFireEventsWhenBackwards, EMovieSceneCompletionMode CompletionMode, [Nullable(new byte[]
		{
			0,
			1
		})] TWeakObjectPtr<UMovieSceneSection> SourceSectionPtr)
		{
			this.EventData = EventData;
			this.bFireEventsWhenForwards = bFireEventsWhenForwards;
			this.bFireEventsWhenBackwards = bFireEventsWhenBackwards;
			base.CompletionMode = CompletionMode;
			base.SourceSectionPtr = SourceSectionPtr;
		}

		// Token: 0x060223F5 RID: 140277 RVA: 0x0032A51B File Offset: 0x0032871B
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneEventSectionTemplate.StaticStruct();
		}

		// Token: 0x060223F6 RID: 140278 RVA: 0x0032A527 File Offset: 0x00328727
		[NullableContext(2)]
		public FMovieSceneEventSectionTemplate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060223F7 RID: 140279 RVA: 0x0032A531 File Offset: 0x00328731
		public FMovieSceneEventSectionTemplate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060223F8 RID: 140280 RVA: 0x0032A53C File Offset: 0x0032873C
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneEventSectionTemplate(Pointer, false, true);
		}

		// Token: 0x060223F9 RID: 140281 RVA: 0x0032A546 File Offset: 0x00328746
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneEventSectionTemplate(Pointer, MemoryOwner);
		}

		// Token: 0x04012478 RID: 74872
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneEventSectionTemplate";

		// Token: 0x04012479 RID: 74873
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401247A RID: 74874
		internal static int __PropertyOffset_EventData;

		// Token: 0x0401247B RID: 74875
		[Nullable(2)]
		private FMovieSceneEventSectionData _EventData;

		// Token: 0x0401247C RID: 74876
		internal static int __PropertyOffset_bFireEventsWhenForwards;

		// Token: 0x0401247D RID: 74877
		internal static byte __PropertyMask_bFireEventsWhenForwards;

		// Token: 0x0401247E RID: 74878
		internal static int __PropertyOffset_bFireEventsWhenBackwards;

		// Token: 0x0401247F RID: 74879
		internal static byte __PropertyMask_bFireEventsWhenBackwards;
	}
}
