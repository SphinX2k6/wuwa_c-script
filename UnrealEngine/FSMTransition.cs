using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200289D RID: 10397
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SMSystem.SMTransition")]
	[UnrealStructLayout(368, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 368)]
	public class FSMTransition : FSMNode_Base, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060268DA RID: 157914 RVA: 0x003ACD10 File Offset: 0x003AAF10
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSMTransition._ScriptStructPtr != 0) ? FSMTransition._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SMSystem.SMTransition", ref FSMTransition._ScriptStructPtr);
		}

		// Token: 0x170094A9 RID: 38057
		// (get) Token: 0x060268DB RID: 157915 RVA: 0x003ACD34 File Offset: 0x003AAF34
		// (set) Token: 0x060268DC RID: 157916 RVA: 0x003ACD77 File Offset: 0x003AAF77
		public TArray<FSMExposedFunctionHandler> CanEnterTransitionGraphEvaluator
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FSMExposedFunctionHandler> result;
				if ((result = this._CanEnterTransitionGraphEvaluator) == null)
				{
					result = (this._CanEnterTransitionGraphEvaluator = new TArray<FSMExposedFunctionHandler>(base.NativePtr + (IntPtr)FSMTransition.__PropertyOffset_CanEnterTransitionGraphEvaluator, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.CanEnterTransitionGraphEvaluator.CopyAssign(value);
			}
		}

		// Token: 0x170094AA RID: 38058
		// (get) Token: 0x060268DD RID: 157917 RVA: 0x003ACD88 File Offset: 0x003AAF88
		// (set) Token: 0x060268DE RID: 157918 RVA: 0x003ACDCB File Offset: 0x003AAFCB
		public TArray<FSMExposedFunctionHandler> TransitionEnteredGraphEvaluator
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FSMExposedFunctionHandler> result;
				if ((result = this._TransitionEnteredGraphEvaluator) == null)
				{
					result = (this._TransitionEnteredGraphEvaluator = new TArray<FSMExposedFunctionHandler>(base.NativePtr + (IntPtr)FSMTransition.__PropertyOffset_TransitionEnteredGraphEvaluator, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.TransitionEnteredGraphEvaluator.CopyAssign(value);
			}
		}

		// Token: 0x170094AB RID: 38059
		// (get) Token: 0x060268DF RID: 157919 RVA: 0x003ACDDC File Offset: 0x003AAFDC
		// (set) Token: 0x060268E0 RID: 157920 RVA: 0x003ACE1F File Offset: 0x003AB01F
		public TArray<FSMExposedFunctionHandler> TransitionPreEvaluateGraphEvaluator
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FSMExposedFunctionHandler> result;
				if ((result = this._TransitionPreEvaluateGraphEvaluator) == null)
				{
					result = (this._TransitionPreEvaluateGraphEvaluator = new TArray<FSMExposedFunctionHandler>(base.NativePtr + (IntPtr)FSMTransition.__PropertyOffset_TransitionPreEvaluateGraphEvaluator, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.TransitionPreEvaluateGraphEvaluator.CopyAssign(value);
			}
		}

		// Token: 0x170094AC RID: 38060
		// (get) Token: 0x060268E1 RID: 157921 RVA: 0x003ACE30 File Offset: 0x003AB030
		// (set) Token: 0x060268E2 RID: 157922 RVA: 0x003ACE73 File Offset: 0x003AB073
		public TArray<FSMExposedFunctionHandler> TransitionPostEvaluateGraphEvaluator
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FSMExposedFunctionHandler> result;
				if ((result = this._TransitionPostEvaluateGraphEvaluator) == null)
				{
					result = (this._TransitionPostEvaluateGraphEvaluator = new TArray<FSMExposedFunctionHandler>(base.NativePtr + (IntPtr)FSMTransition.__PropertyOffset_TransitionPostEvaluateGraphEvaluator, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.TransitionPostEvaluateGraphEvaluator.CopyAssign(value);
			}
		}

		// Token: 0x170094AD RID: 38061
		// (get) Token: 0x060268E3 RID: 157923 RVA: 0x003ACE81 File Offset: 0x003AB081
		// (set) Token: 0x060268E4 RID: 157924 RVA: 0x003ACE91 File Offset: 0x003AB091
		public unsafe int Priority
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSMTransition.__PropertyOffset_Priority);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSMTransition.__PropertyOffset_Priority) = value;
			}
		}

		// Token: 0x170094AE RID: 38062
		// (get) Token: 0x060268E5 RID: 157925 RVA: 0x003ACEA2 File Offset: 0x003AB0A2
		// (set) Token: 0x060268E6 RID: 157926 RVA: 0x003ACEBB File Offset: 0x003AB0BB
		public unsafe bool bCanEnterTransition
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FSMTransition.__PropertyOffset_bCanEnterTransition) & FSMTransition.__PropertyMask_bCanEnterTransition) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FSMTransition.__PropertyOffset_bCanEnterTransition) = ((*(base.NativePtr + (IntPtr)FSMTransition.__PropertyOffset_bCanEnterTransition) & ~FSMTransition.__PropertyMask_bCanEnterTransition) | (value ? FSMTransition.__PropertyMask_bCanEnterTransition : 0));
			}
		}

		// Token: 0x170094AF RID: 38063
		// (get) Token: 0x060268E7 RID: 157927 RVA: 0x003ACEEB File Offset: 0x003AB0EB
		// (set) Token: 0x060268E8 RID: 157928 RVA: 0x003ACF04 File Offset: 0x003AB104
		public unsafe bool bCanEnterTransitionFromEvent
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FSMTransition.__PropertyOffset_bCanEnterTransitionFromEvent) & FSMTransition.__PropertyMask_bCanEnterTransitionFromEvent) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FSMTransition.__PropertyOffset_bCanEnterTransitionFromEvent) = ((*(base.NativePtr + (IntPtr)FSMTransition.__PropertyOffset_bCanEnterTransitionFromEvent) & ~FSMTransition.__PropertyMask_bCanEnterTransitionFromEvent) | (value ? FSMTransition.__PropertyMask_bCanEnterTransitionFromEvent : 0));
			}
		}

		// Token: 0x170094B0 RID: 38064
		// (get) Token: 0x060268E9 RID: 157929 RVA: 0x003ACF34 File Offset: 0x003AB134
		// (set) Token: 0x060268EA RID: 157930 RVA: 0x003ACF4D File Offset: 0x003AB14D
		public unsafe bool bIsEvaluating
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FSMTransition.__PropertyOffset_bIsEvaluating) & FSMTransition.__PropertyMask_bIsEvaluating) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FSMTransition.__PropertyOffset_bIsEvaluating) = ((*(base.NativePtr + (IntPtr)FSMTransition.__PropertyOffset_bIsEvaluating) & ~FSMTransition.__PropertyMask_bIsEvaluating) | (value ? FSMTransition.__PropertyMask_bIsEvaluating : 0));
			}
		}

		// Token: 0x170094B1 RID: 38065
		// (get) Token: 0x060268EB RID: 157931 RVA: 0x003ACF7D File Offset: 0x003AB17D
		// (set) Token: 0x060268EC RID: 157932 RVA: 0x003ACF96 File Offset: 0x003AB196
		public unsafe bool bCanEvaluate
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FSMTransition.__PropertyOffset_bCanEvaluate) & FSMTransition.__PropertyMask_bCanEvaluate) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FSMTransition.__PropertyOffset_bCanEvaluate) = ((*(base.NativePtr + (IntPtr)FSMTransition.__PropertyOffset_bCanEvaluate) & ~FSMTransition.__PropertyMask_bCanEvaluate) | (value ? FSMTransition.__PropertyMask_bCanEvaluate : 0));
			}
		}

		// Token: 0x170094B2 RID: 38066
		// (get) Token: 0x060268ED RID: 157933 RVA: 0x003ACFC6 File Offset: 0x003AB1C6
		// (set) Token: 0x060268EE RID: 157934 RVA: 0x003ACFDF File Offset: 0x003AB1DF
		public unsafe bool bCanEvaluateFromEvent
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FSMTransition.__PropertyOffset_bCanEvaluateFromEvent) & FSMTransition.__PropertyMask_bCanEvaluateFromEvent) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FSMTransition.__PropertyOffset_bCanEvaluateFromEvent) = ((*(base.NativePtr + (IntPtr)FSMTransition.__PropertyOffset_bCanEvaluateFromEvent) & ~FSMTransition.__PropertyMask_bCanEvaluateFromEvent) | (value ? FSMTransition.__PropertyMask_bCanEvaluateFromEvent : 0));
			}
		}

		// Token: 0x170094B3 RID: 38067
		// (get) Token: 0x060268EF RID: 157935 RVA: 0x003AD00F File Offset: 0x003AB20F
		// (set) Token: 0x060268F0 RID: 157936 RVA: 0x003AD028 File Offset: 0x003AB228
		public unsafe bool bRunParallel
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FSMTransition.__PropertyOffset_bRunParallel) & FSMTransition.__PropertyMask_bRunParallel) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FSMTransition.__PropertyOffset_bRunParallel) = ((*(base.NativePtr + (IntPtr)FSMTransition.__PropertyOffset_bRunParallel) & ~FSMTransition.__PropertyMask_bRunParallel) | (value ? FSMTransition.__PropertyMask_bRunParallel : 0));
			}
		}

		// Token: 0x170094B4 RID: 38068
		// (get) Token: 0x060268F1 RID: 157937 RVA: 0x003AD058 File Offset: 0x003AB258
		// (set) Token: 0x060268F2 RID: 157938 RVA: 0x003AD071 File Offset: 0x003AB271
		public unsafe bool bEvalIfNextStateActive
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FSMTransition.__PropertyOffset_bEvalIfNextStateActive) & FSMTransition.__PropertyMask_bEvalIfNextStateActive) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FSMTransition.__PropertyOffset_bEvalIfNextStateActive) = ((*(base.NativePtr + (IntPtr)FSMTransition.__PropertyOffset_bEvalIfNextStateActive) & ~FSMTransition.__PropertyMask_bEvalIfNextStateActive) | (value ? FSMTransition.__PropertyMask_bEvalIfNextStateActive : 0));
			}
		}

		// Token: 0x170094B5 RID: 38069
		// (get) Token: 0x060268F3 RID: 157939 RVA: 0x003AD0A1 File Offset: 0x003AB2A1
		// (set) Token: 0x060268F4 RID: 157940 RVA: 0x003AD0BA File Offset: 0x003AB2BA
		public unsafe bool bCanEvalWithStartState
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FSMTransition.__PropertyOffset_bCanEvalWithStartState) & FSMTransition.__PropertyMask_bCanEvalWithStartState) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FSMTransition.__PropertyOffset_bCanEvalWithStartState) = ((*(base.NativePtr + (IntPtr)FSMTransition.__PropertyOffset_bCanEvalWithStartState) & ~FSMTransition.__PropertyMask_bCanEvalWithStartState) | (value ? FSMTransition.__PropertyMask_bCanEvalWithStartState : 0));
			}
		}

		// Token: 0x170094B6 RID: 38070
		// (get) Token: 0x060268F5 RID: 157941 RVA: 0x003AD0EA File Offset: 0x003AB2EA
		// (set) Token: 0x060268F6 RID: 157942 RVA: 0x003AD103 File Offset: 0x003AB303
		public unsafe bool bAlwaysFalse
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FSMTransition.__PropertyOffset_bAlwaysFalse) & FSMTransition.__PropertyMask_bAlwaysFalse) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FSMTransition.__PropertyOffset_bAlwaysFalse) = ((*(base.NativePtr + (IntPtr)FSMTransition.__PropertyOffset_bAlwaysFalse) & ~FSMTransition.__PropertyMask_bAlwaysFalse) | (value ? FSMTransition.__PropertyMask_bAlwaysFalse : 0));
			}
		}

		// Token: 0x170094B7 RID: 38071
		// (get) Token: 0x060268F7 RID: 157943 RVA: 0x003AD133 File Offset: 0x003AB333
		// (set) Token: 0x060268F8 RID: 157944 RVA: 0x003AD14C File Offset: 0x003AB34C
		public unsafe bool bFromAnyState
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FSMTransition.__PropertyOffset_bFromAnyState) & FSMTransition.__PropertyMask_bFromAnyState) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FSMTransition.__PropertyOffset_bFromAnyState) = ((*(base.NativePtr + (IntPtr)FSMTransition.__PropertyOffset_bFromAnyState) & ~FSMTransition.__PropertyMask_bFromAnyState) | (value ? FSMTransition.__PropertyMask_bFromAnyState : 0));
			}
		}

		// Token: 0x170094B8 RID: 38072
		// (get) Token: 0x060268F9 RID: 157945 RVA: 0x003AD17C File Offset: 0x003AB37C
		// (set) Token: 0x060268FA RID: 157946 RVA: 0x003AD190 File Offset: 0x003AB390
		public unsafe FGuid FromGuid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSMTransition.__PropertyOffset_FromGuid);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSMTransition.__PropertyOffset_FromGuid) = value;
			}
		}

		// Token: 0x170094B9 RID: 38073
		// (get) Token: 0x060268FB RID: 157947 RVA: 0x003AD1A5 File Offset: 0x003AB3A5
		// (set) Token: 0x060268FC RID: 157948 RVA: 0x003AD1B9 File Offset: 0x003AB3B9
		public unsafe FGuid ToGuid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSMTransition.__PropertyOffset_ToGuid);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSMTransition.__PropertyOffset_ToGuid) = value;
			}
		}

		// Token: 0x170094BA RID: 38074
		// (get) Token: 0x060268FD RID: 157949 RVA: 0x003AD1CE File Offset: 0x003AB3CE
		// (set) Token: 0x060268FE RID: 157950 RVA: 0x003AD1DE File Offset: 0x003AB3DE
		public unsafe ESMConditionalEvaluationType ConditionalEvaluationType
		{
			get
			{
				return (ESMConditionalEvaluationType)(*(base.NativePtr + (IntPtr)FSMTransition.__PropertyOffset_ConditionalEvaluationType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSMTransition.__PropertyOffset_ConditionalEvaluationType) = (byte)value;
			}
		}

		// Token: 0x060268FF RID: 157951 RVA: 0x003AD1EF File Offset: 0x003AB3EF
		public FSMTransition()
		{
		}

		// Token: 0x06026900 RID: 157952 RVA: 0x003AD1F8 File Offset: 0x003AB3F8
		public FSMTransition(TArray<FSMExposedFunctionHandler> CanEnterTransitionGraphEvaluator, TArray<FSMExposedFunctionHandler> TransitionEnteredGraphEvaluator, TArray<FSMExposedFunctionHandler> TransitionPreEvaluateGraphEvaluator, TArray<FSMExposedFunctionHandler> TransitionPostEvaluateGraphEvaluator, int Priority, bool bCanEnterTransition, bool bCanEnterTransitionFromEvent, bool bIsEvaluating, bool bCanEvaluate, bool bCanEvaluateFromEvent, bool bRunParallel, bool bEvalIfNextStateActive, bool bCanEvalWithStartState, bool bAlwaysFalse, bool bFromAnyState, FGuid FromGuid, FGuid ToGuid, ESMConditionalEvaluationType ConditionalEvaluationType, TArray<FSMExposedFunctionHandler> TransitionInitializedGraphEvaluators, TArray<FSMExposedFunctionHandler> TransitionShutdownGraphEvaluators, TArray<FSMExposedFunctionHandler> OnRootStateMachineStartedGraphEvaluator, TArray<FSMExposedFunctionHandler> OnRootStateMachineStoppedGraphEvaluator, float TimeInState, bool bIsInEndState, bool bHasUpdated, int DuplicateId, FGuid Guid, FGuid OwnerGuid, FGuid PathGuid, string NodeName, FName TemplateName, USMInstance OwningInstance, USMNodeInstance NodeInstance, UClassStackOnlyPtr NodeInstanceClass)
		{
			this.CanEnterTransitionGraphEvaluator = CanEnterTransitionGraphEvaluator;
			this.TransitionEnteredGraphEvaluator = TransitionEnteredGraphEvaluator;
			this.TransitionPreEvaluateGraphEvaluator = TransitionPreEvaluateGraphEvaluator;
			this.TransitionPostEvaluateGraphEvaluator = TransitionPostEvaluateGraphEvaluator;
			this.Priority = Priority;
			this.bCanEnterTransition = bCanEnterTransition;
			this.bCanEnterTransitionFromEvent = bCanEnterTransitionFromEvent;
			this.bIsEvaluating = bIsEvaluating;
			this.bCanEvaluate = bCanEvaluate;
			this.bCanEvaluateFromEvent = bCanEvaluateFromEvent;
			this.bRunParallel = bRunParallel;
			this.bEvalIfNextStateActive = bEvalIfNextStateActive;
			this.bCanEvalWithStartState = bCanEvalWithStartState;
			this.bAlwaysFalse = bAlwaysFalse;
			this.bFromAnyState = bFromAnyState;
			this.FromGuid = FromGuid;
			this.ToGuid = ToGuid;
			this.ConditionalEvaluationType = ConditionalEvaluationType;
			base.TransitionInitializedGraphEvaluators = TransitionInitializedGraphEvaluators;
			base.TransitionShutdownGraphEvaluators = TransitionShutdownGraphEvaluators;
			base.OnRootStateMachineStartedGraphEvaluator = OnRootStateMachineStartedGraphEvaluator;
			base.OnRootStateMachineStoppedGraphEvaluator = OnRootStateMachineStoppedGraphEvaluator;
			base.TimeInState = TimeInState;
			base.bIsInEndState = bIsInEndState;
			base.bHasUpdated = bHasUpdated;
			base.DuplicateId = DuplicateId;
			base.Guid = Guid;
			base.OwnerGuid = OwnerGuid;
			base.PathGuid = PathGuid;
			base.NodeName = NodeName;
			base.TemplateName = TemplateName;
			base.OwningInstance = OwningInstance;
			base.NodeInstance = NodeInstance;
			base.NodeInstanceClass = NodeInstanceClass;
		}

		// Token: 0x06026901 RID: 157953 RVA: 0x003AD318 File Offset: 0x003AB518
		protected override IntPtr GetUStructPtr()
		{
			return FSMTransition.StaticStruct();
		}

		// Token: 0x06026902 RID: 157954 RVA: 0x003AD324 File Offset: 0x003AB524
		[NullableContext(2)]
		public FSMTransition(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06026903 RID: 157955 RVA: 0x003AD32E File Offset: 0x003AB52E
		public FSMTransition(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06026904 RID: 157956 RVA: 0x003AD339 File Offset: 0x003AB539
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSMTransition(Pointer, false, true);
		}

		// Token: 0x06026905 RID: 157957 RVA: 0x003AD343 File Offset: 0x003AB543
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSMTransition(Pointer, MemoryOwner);
		}

		// Token: 0x040152C9 RID: 86729
		public new const string __ObjectPath = "/Script/SMSystem.SMTransition";

		// Token: 0x040152CA RID: 86730
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040152CB RID: 86731
		internal static int __PropertyOffset_CanEnterTransitionGraphEvaluator;

		// Token: 0x040152CC RID: 86732
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSMExposedFunctionHandler> _CanEnterTransitionGraphEvaluator;

		// Token: 0x040152CD RID: 86733
		internal static int __PropertyOffset_TransitionEnteredGraphEvaluator;

		// Token: 0x040152CE RID: 86734
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSMExposedFunctionHandler> _TransitionEnteredGraphEvaluator;

		// Token: 0x040152CF RID: 86735
		internal static int __PropertyOffset_TransitionPreEvaluateGraphEvaluator;

		// Token: 0x040152D0 RID: 86736
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSMExposedFunctionHandler> _TransitionPreEvaluateGraphEvaluator;

		// Token: 0x040152D1 RID: 86737
		internal static int __PropertyOffset_TransitionPostEvaluateGraphEvaluator;

		// Token: 0x040152D2 RID: 86738
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSMExposedFunctionHandler> _TransitionPostEvaluateGraphEvaluator;

		// Token: 0x040152D3 RID: 86739
		internal static int __PropertyOffset_Priority;

		// Token: 0x040152D4 RID: 86740
		internal static int __PropertyOffset_bCanEnterTransition;

		// Token: 0x040152D5 RID: 86741
		internal static byte __PropertyMask_bCanEnterTransition;

		// Token: 0x040152D6 RID: 86742
		internal static int __PropertyOffset_bCanEnterTransitionFromEvent;

		// Token: 0x040152D7 RID: 86743
		internal static byte __PropertyMask_bCanEnterTransitionFromEvent;

		// Token: 0x040152D8 RID: 86744
		internal static int __PropertyOffset_bIsEvaluating;

		// Token: 0x040152D9 RID: 86745
		internal static byte __PropertyMask_bIsEvaluating;

		// Token: 0x040152DA RID: 86746
		internal static int __PropertyOffset_bCanEvaluate;

		// Token: 0x040152DB RID: 86747
		internal static byte __PropertyMask_bCanEvaluate;

		// Token: 0x040152DC RID: 86748
		internal static int __PropertyOffset_bCanEvaluateFromEvent;

		// Token: 0x040152DD RID: 86749
		internal static byte __PropertyMask_bCanEvaluateFromEvent;

		// Token: 0x040152DE RID: 86750
		internal static int __PropertyOffset_bRunParallel;

		// Token: 0x040152DF RID: 86751
		internal static byte __PropertyMask_bRunParallel;

		// Token: 0x040152E0 RID: 86752
		internal static int __PropertyOffset_bEvalIfNextStateActive;

		// Token: 0x040152E1 RID: 86753
		internal static byte __PropertyMask_bEvalIfNextStateActive;

		// Token: 0x040152E2 RID: 86754
		internal static int __PropertyOffset_bCanEvalWithStartState;

		// Token: 0x040152E3 RID: 86755
		internal static byte __PropertyMask_bCanEvalWithStartState;

		// Token: 0x040152E4 RID: 86756
		internal static int __PropertyOffset_bAlwaysFalse;

		// Token: 0x040152E5 RID: 86757
		internal static byte __PropertyMask_bAlwaysFalse;

		// Token: 0x040152E6 RID: 86758
		internal static int __PropertyOffset_bFromAnyState;

		// Token: 0x040152E7 RID: 86759
		internal static byte __PropertyMask_bFromAnyState;

		// Token: 0x040152E8 RID: 86760
		internal static int __PropertyOffset_FromGuid;

		// Token: 0x040152E9 RID: 86761
		internal static int __PropertyOffset_ToGuid;

		// Token: 0x040152EA RID: 86762
		internal static int __PropertyOffset_ConditionalEvaluationType;
	}
}
