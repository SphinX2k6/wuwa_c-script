using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002404 RID: 9220
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieScene.MovieSceneEvaluationTrack")]
	[UnrealStructLayout(120, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 120)]
	public class FMovieSceneEvaluationTrack : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602294D RID: 141645 RVA: 0x00332561 File Offset: 0x00330761
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneEvaluationTrack._ScriptStructPtr != 0) ? FMovieSceneEvaluationTrack._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieScene.MovieSceneEvaluationTrack", ref FMovieSceneEvaluationTrack._ScriptStructPtr);
		}

		// Token: 0x1700851D RID: 34077
		// (get) Token: 0x0602294E RID: 141646 RVA: 0x00332585 File Offset: 0x00330785
		// (set) Token: 0x0602294F RID: 141647 RVA: 0x00332599 File Offset: 0x00330799
		public unsafe FGuid ObjectBindingID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneEvaluationTrack.__PropertyOffset_ObjectBindingID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneEvaluationTrack.__PropertyOffset_ObjectBindingID) = value;
			}
		}

		// Token: 0x1700851E RID: 34078
		// (get) Token: 0x06022950 RID: 141648 RVA: 0x003325AE File Offset: 0x003307AE
		// (set) Token: 0x06022951 RID: 141649 RVA: 0x003325BE File Offset: 0x003307BE
		public unsafe ushort EvaluationPriority
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneEvaluationTrack.__PropertyOffset_EvaluationPriority);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneEvaluationTrack.__PropertyOffset_EvaluationPriority) = (short)value;
			}
		}

		// Token: 0x1700851F RID: 34079
		// (get) Token: 0x06022952 RID: 141650 RVA: 0x003325CF File Offset: 0x003307CF
		// (set) Token: 0x06022953 RID: 141651 RVA: 0x003325DF File Offset: 0x003307DF
		public unsafe EEvaluationMethod EvaluationMethod
		{
			get
			{
				return (EEvaluationMethod)(*(base.NativePtr + (IntPtr)FMovieSceneEvaluationTrack.__PropertyOffset_EvaluationMethod));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneEvaluationTrack.__PropertyOffset_EvaluationMethod) = (byte)value;
			}
		}

		// Token: 0x17008520 RID: 34080
		// (get) Token: 0x06022954 RID: 141652 RVA: 0x003325F0 File Offset: 0x003307F0
		// (set) Token: 0x06022955 RID: 141653 RVA: 0x00332604 File Offset: 0x00330804
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<UMovieSceneTrack> SourceTrack
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneEvaluationTrack.__PropertyOffset_SourceTrack);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneEvaluationTrack.__PropertyOffset_SourceTrack) = value;
			}
		}

		// Token: 0x17008521 RID: 34081
		// (get) Token: 0x06022956 RID: 141654 RVA: 0x0033261C File Offset: 0x0033081C
		// (set) Token: 0x06022957 RID: 141655 RVA: 0x0033265F File Offset: 0x0033085F
		public TArray<FMovieSceneEvalTemplatePtr> ChildTemplates
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FMovieSceneEvalTemplatePtr> result;
				if ((result = this._ChildTemplates) == null)
				{
					result = (this._ChildTemplates = new TArray<FMovieSceneEvalTemplatePtr>(base.NativePtr + (IntPtr)FMovieSceneEvaluationTrack.__PropertyOffset_ChildTemplates, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ChildTemplates.CopyAssign(value);
			}
		}

		// Token: 0x17008522 RID: 34082
		// (get) Token: 0x06022958 RID: 141656 RVA: 0x00332670 File Offset: 0x00330870
		// (set) Token: 0x06022959 RID: 141657 RVA: 0x003326B3 File Offset: 0x003308B3
		public FMovieSceneTrackImplementationPtr TrackTemplate
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneTrackImplementationPtr result;
				if ((result = this._TrackTemplate) == null)
				{
					result = (this._TrackTemplate = new FMovieSceneTrackImplementationPtr(base.NativePtr + (IntPtr)FMovieSceneEvaluationTrack.__PropertyOffset_TrackTemplate, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneTrackImplementationPtr.StaticStruct(), base.NativePtr + (IntPtr)FMovieSceneEvaluationTrack.__PropertyOffset_TrackTemplate, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008523 RID: 34083
		// (get) Token: 0x0602295A RID: 141658 RVA: 0x003326D4 File Offset: 0x003308D4
		// (set) Token: 0x0602295B RID: 141659 RVA: 0x003326E8 File Offset: 0x003308E8
		public unsafe FName EvaluationGroup
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneEvaluationTrack.__PropertyOffset_EvaluationGroup);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneEvaluationTrack.__PropertyOffset_EvaluationGroup) = value;
			}
		}

		// Token: 0x17008524 RID: 34084
		// (get) Token: 0x0602295C RID: 141660 RVA: 0x003326FD File Offset: 0x003308FD
		// (set) Token: 0x0602295D RID: 141661 RVA: 0x00332716 File Offset: 0x00330916
		public unsafe bool bEvaluateInPreroll
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMovieSceneEvaluationTrack.__PropertyOffset_bEvaluateInPreroll) & FMovieSceneEvaluationTrack.__PropertyMask_bEvaluateInPreroll) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMovieSceneEvaluationTrack.__PropertyOffset_bEvaluateInPreroll) = ((*(base.NativePtr + (IntPtr)FMovieSceneEvaluationTrack.__PropertyOffset_bEvaluateInPreroll) & ~FMovieSceneEvaluationTrack.__PropertyMask_bEvaluateInPreroll) | (value ? FMovieSceneEvaluationTrack.__PropertyMask_bEvaluateInPreroll : 0));
			}
		}

		// Token: 0x17008525 RID: 34085
		// (get) Token: 0x0602295E RID: 141662 RVA: 0x00332746 File Offset: 0x00330946
		// (set) Token: 0x0602295F RID: 141663 RVA: 0x0033275F File Offset: 0x0033095F
		public unsafe bool bEvaluateInPostroll
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMovieSceneEvaluationTrack.__PropertyOffset_bEvaluateInPostroll) & FMovieSceneEvaluationTrack.__PropertyMask_bEvaluateInPostroll) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMovieSceneEvaluationTrack.__PropertyOffset_bEvaluateInPostroll) = ((*(base.NativePtr + (IntPtr)FMovieSceneEvaluationTrack.__PropertyOffset_bEvaluateInPostroll) & ~FMovieSceneEvaluationTrack.__PropertyMask_bEvaluateInPostroll) | (value ? FMovieSceneEvaluationTrack.__PropertyMask_bEvaluateInPostroll : 0));
			}
		}

		// Token: 0x17008526 RID: 34086
		// (get) Token: 0x06022960 RID: 141664 RVA: 0x0033278F File Offset: 0x0033098F
		// (set) Token: 0x06022961 RID: 141665 RVA: 0x003327A8 File Offset: 0x003309A8
		public unsafe bool bTearDownPriority
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMovieSceneEvaluationTrack.__PropertyOffset_bTearDownPriority) & FMovieSceneEvaluationTrack.__PropertyMask_bTearDownPriority) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMovieSceneEvaluationTrack.__PropertyOffset_bTearDownPriority) = ((*(base.NativePtr + (IntPtr)FMovieSceneEvaluationTrack.__PropertyOffset_bTearDownPriority) & ~FMovieSceneEvaluationTrack.__PropertyMask_bTearDownPriority) | (value ? FMovieSceneEvaluationTrack.__PropertyMask_bTearDownPriority : 0));
			}
		}

		// Token: 0x06022962 RID: 141666 RVA: 0x003327D8 File Offset: 0x003309D8
		public FMovieSceneEvaluationTrack()
		{
		}

		// Token: 0x06022963 RID: 141667 RVA: 0x003327E0 File Offset: 0x003309E0
		public FMovieSceneEvaluationTrack(FGuid ObjectBindingID, ushort EvaluationPriority, EEvaluationMethod EvaluationMethod, [Nullable(new byte[]
		{
			0,
			1
		})] TWeakObjectPtr<UMovieSceneTrack> SourceTrack, TArray<FMovieSceneEvalTemplatePtr> ChildTemplates, FMovieSceneTrackImplementationPtr TrackTemplate, FName EvaluationGroup, bool bEvaluateInPreroll, bool bEvaluateInPostroll, bool bTearDownPriority)
		{
			this.ObjectBindingID = ObjectBindingID;
			this.EvaluationPriority = EvaluationPriority;
			this.EvaluationMethod = EvaluationMethod;
			this.SourceTrack = SourceTrack;
			this.ChildTemplates = ChildTemplates;
			this.TrackTemplate = TrackTemplate;
			this.EvaluationGroup = EvaluationGroup;
			this.bEvaluateInPreroll = bEvaluateInPreroll;
			this.bEvaluateInPostroll = bEvaluateInPostroll;
			this.bTearDownPriority = bTearDownPriority;
		}

		// Token: 0x06022964 RID: 141668 RVA: 0x00332840 File Offset: 0x00330A40
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneEvaluationTrack.StaticStruct();
		}

		// Token: 0x06022965 RID: 141669 RVA: 0x0033284C File Offset: 0x00330A4C
		[NullableContext(2)]
		public FMovieSceneEvaluationTrack(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06022966 RID: 141670 RVA: 0x00332856 File Offset: 0x00330A56
		public FMovieSceneEvaluationTrack(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06022967 RID: 141671 RVA: 0x00332861 File Offset: 0x00330A61
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneEvaluationTrack(Pointer, false, true);
		}

		// Token: 0x06022968 RID: 141672 RVA: 0x0033286B File Offset: 0x00330A6B
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneEvaluationTrack(Pointer, MemoryOwner);
		}

		// Token: 0x040127AD RID: 75693
		public const string __ObjectPath = "/Script/MovieScene.MovieSceneEvaluationTrack";

		// Token: 0x040127AE RID: 75694
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040127AF RID: 75695
		internal static int __PropertyOffset_ObjectBindingID;

		// Token: 0x040127B0 RID: 75696
		internal static int __PropertyOffset_EvaluationPriority;

		// Token: 0x040127B1 RID: 75697
		internal static int __PropertyOffset_EvaluationMethod;

		// Token: 0x040127B2 RID: 75698
		internal static int __PropertyOffset_SourceTrack;

		// Token: 0x040127B3 RID: 75699
		internal static int __PropertyOffset_ChildTemplates;

		// Token: 0x040127B4 RID: 75700
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FMovieSceneEvalTemplatePtr> _ChildTemplates;

		// Token: 0x040127B5 RID: 75701
		internal static int __PropertyOffset_TrackTemplate;

		// Token: 0x040127B6 RID: 75702
		[Nullable(2)]
		private FMovieSceneTrackImplementationPtr _TrackTemplate;

		// Token: 0x040127B7 RID: 75703
		internal static int __PropertyOffset_EvaluationGroup;

		// Token: 0x040127B8 RID: 75704
		internal static int __PropertyOffset_bEvaluateInPreroll;

		// Token: 0x040127B9 RID: 75705
		internal static byte __PropertyMask_bEvaluateInPreroll;

		// Token: 0x040127BA RID: 75706
		internal static int __PropertyOffset_bEvaluateInPostroll;

		// Token: 0x040127BB RID: 75707
		internal static byte __PropertyMask_bEvaluateInPostroll;

		// Token: 0x040127BC RID: 75708
		internal static int __PropertyOffset_bTearDownPriority;

		// Token: 0x040127BD RID: 75709
		internal static byte __PropertyMask_bTearDownPriority;
	}
}
