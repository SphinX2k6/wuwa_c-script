using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200289B RID: 10395
	[UnrealObjectPath("/Script/SMSystem.SMState_Base")]
	[UnrealStructLayout(296, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 296)]
	public class FSMState_Base : FSMNode_Base, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060268BA RID: 157882 RVA: 0x003AC95A File Offset: 0x003AAB5A
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSMState_Base._ScriptStructPtr != 0) ? FSMState_Base._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SMSystem.SMState_Base", ref FSMState_Base._ScriptStructPtr);
		}

		// Token: 0x170094A1 RID: 38049
		// (get) Token: 0x060268BB RID: 157883 RVA: 0x003AC97E File Offset: 0x003AAB7E
		// (set) Token: 0x060268BC RID: 157884 RVA: 0x003AC997 File Offset: 0x003AAB97
		public unsafe bool bIsRootNode
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FSMState_Base.__PropertyOffset_bIsRootNode) & FSMState_Base.__PropertyMask_bIsRootNode) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FSMState_Base.__PropertyOffset_bIsRootNode) = ((*(base.NativePtr + (IntPtr)FSMState_Base.__PropertyOffset_bIsRootNode) & ~FSMState_Base.__PropertyMask_bIsRootNode) | (value ? FSMState_Base.__PropertyMask_bIsRootNode : 0));
			}
		}

		// Token: 0x170094A2 RID: 38050
		// (get) Token: 0x060268BD RID: 157885 RVA: 0x003AC9C7 File Offset: 0x003AABC7
		// (set) Token: 0x060268BE RID: 157886 RVA: 0x003AC9E0 File Offset: 0x003AABE0
		public unsafe bool bAlwaysUpdate
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FSMState_Base.__PropertyOffset_bAlwaysUpdate) & FSMState_Base.__PropertyMask_bAlwaysUpdate) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FSMState_Base.__PropertyOffset_bAlwaysUpdate) = ((*(base.NativePtr + (IntPtr)FSMState_Base.__PropertyOffset_bAlwaysUpdate) & ~FSMState_Base.__PropertyMask_bAlwaysUpdate) | (value ? FSMState_Base.__PropertyMask_bAlwaysUpdate : 0));
			}
		}

		// Token: 0x170094A3 RID: 38051
		// (get) Token: 0x060268BF RID: 157887 RVA: 0x003ACA10 File Offset: 0x003AAC10
		// (set) Token: 0x060268C0 RID: 157888 RVA: 0x003ACA29 File Offset: 0x003AAC29
		public unsafe bool bEvalTransitionsOnStart
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FSMState_Base.__PropertyOffset_bEvalTransitionsOnStart) & FSMState_Base.__PropertyMask_bEvalTransitionsOnStart) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FSMState_Base.__PropertyOffset_bEvalTransitionsOnStart) = ((*(base.NativePtr + (IntPtr)FSMState_Base.__PropertyOffset_bEvalTransitionsOnStart) & ~FSMState_Base.__PropertyMask_bEvalTransitionsOnStart) | (value ? FSMState_Base.__PropertyMask_bEvalTransitionsOnStart : 0));
			}
		}

		// Token: 0x170094A4 RID: 38052
		// (get) Token: 0x060268C1 RID: 157889 RVA: 0x003ACA59 File Offset: 0x003AAC59
		// (set) Token: 0x060268C2 RID: 157890 RVA: 0x003ACA72 File Offset: 0x003AAC72
		public unsafe bool bDisableTickTransitionEvaluation
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FSMState_Base.__PropertyOffset_bDisableTickTransitionEvaluation) & FSMState_Base.__PropertyMask_bDisableTickTransitionEvaluation) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FSMState_Base.__PropertyOffset_bDisableTickTransitionEvaluation) = ((*(base.NativePtr + (IntPtr)FSMState_Base.__PropertyOffset_bDisableTickTransitionEvaluation) & ~FSMState_Base.__PropertyMask_bDisableTickTransitionEvaluation) | (value ? FSMState_Base.__PropertyMask_bDisableTickTransitionEvaluation : 0));
			}
		}

		// Token: 0x170094A5 RID: 38053
		// (get) Token: 0x060268C3 RID: 157891 RVA: 0x003ACAA2 File Offset: 0x003AACA2
		// (set) Token: 0x060268C4 RID: 157892 RVA: 0x003ACABB File Offset: 0x003AACBB
		public unsafe bool bStayActiveOnStateChange
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FSMState_Base.__PropertyOffset_bStayActiveOnStateChange) & FSMState_Base.__PropertyMask_bStayActiveOnStateChange) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FSMState_Base.__PropertyOffset_bStayActiveOnStateChange) = ((*(base.NativePtr + (IntPtr)FSMState_Base.__PropertyOffset_bStayActiveOnStateChange) & ~FSMState_Base.__PropertyMask_bStayActiveOnStateChange) | (value ? FSMState_Base.__PropertyMask_bStayActiveOnStateChange : 0));
			}
		}

		// Token: 0x170094A6 RID: 38054
		// (get) Token: 0x060268C5 RID: 157893 RVA: 0x003ACAEB File Offset: 0x003AACEB
		// (set) Token: 0x060268C6 RID: 157894 RVA: 0x003ACB04 File Offset: 0x003AAD04
		public unsafe bool bAllowParallelReentry
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FSMState_Base.__PropertyOffset_bAllowParallelReentry) & FSMState_Base.__PropertyMask_bAllowParallelReentry) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FSMState_Base.__PropertyOffset_bAllowParallelReentry) = ((*(base.NativePtr + (IntPtr)FSMState_Base.__PropertyOffset_bAllowParallelReentry) & ~FSMState_Base.__PropertyMask_bAllowParallelReentry) | (value ? FSMState_Base.__PropertyMask_bAllowParallelReentry : 0));
			}
		}

		// Token: 0x060268C7 RID: 157895 RVA: 0x003ACB34 File Offset: 0x003AAD34
		public FSMState_Base()
		{
		}

		// Token: 0x060268C8 RID: 157896 RVA: 0x003ACB3C File Offset: 0x003AAD3C
		[NullableContext(1)]
		public FSMState_Base(bool bIsRootNode, bool bAlwaysUpdate, bool bEvalTransitionsOnStart, bool bDisableTickTransitionEvaluation, bool bStayActiveOnStateChange, bool bAllowParallelReentry, TArray<FSMExposedFunctionHandler> TransitionInitializedGraphEvaluators, TArray<FSMExposedFunctionHandler> TransitionShutdownGraphEvaluators, TArray<FSMExposedFunctionHandler> OnRootStateMachineStartedGraphEvaluator, TArray<FSMExposedFunctionHandler> OnRootStateMachineStoppedGraphEvaluator, float TimeInState, bool bIsInEndState, bool bHasUpdated, int DuplicateId, FGuid Guid, FGuid OwnerGuid, FGuid PathGuid, string NodeName, FName TemplateName, USMInstance OwningInstance, USMNodeInstance NodeInstance, UClassStackOnlyPtr NodeInstanceClass)
		{
			this.bIsRootNode = bIsRootNode;
			this.bAlwaysUpdate = bAlwaysUpdate;
			this.bEvalTransitionsOnStart = bEvalTransitionsOnStart;
			this.bDisableTickTransitionEvaluation = bDisableTickTransitionEvaluation;
			this.bStayActiveOnStateChange = bStayActiveOnStateChange;
			this.bAllowParallelReentry = bAllowParallelReentry;
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

		// Token: 0x060268C9 RID: 157897 RVA: 0x003ACBFC File Offset: 0x003AADFC
		protected override IntPtr GetUStructPtr()
		{
			return FSMState_Base.StaticStruct();
		}

		// Token: 0x060268CA RID: 157898 RVA: 0x003ACC08 File Offset: 0x003AAE08
		[NullableContext(2)]
		public FSMState_Base(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060268CB RID: 157899 RVA: 0x003ACC12 File Offset: 0x003AAE12
		public FSMState_Base(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060268CC RID: 157900 RVA: 0x003ACC1D File Offset: 0x003AAE1D
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSMState_Base(Pointer, false, true);
		}

		// Token: 0x060268CD RID: 157901 RVA: 0x003ACC27 File Offset: 0x003AAE27
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSMState_Base(Pointer, MemoryOwner);
		}

		// Token: 0x040152B6 RID: 86710
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/SMSystem.SMState_Base";

		// Token: 0x040152B7 RID: 86711
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040152B8 RID: 86712
		internal static int __PropertyOffset_bIsRootNode;

		// Token: 0x040152B9 RID: 86713
		internal static byte __PropertyMask_bIsRootNode;

		// Token: 0x040152BA RID: 86714
		internal static int __PropertyOffset_bAlwaysUpdate;

		// Token: 0x040152BB RID: 86715
		internal static byte __PropertyMask_bAlwaysUpdate;

		// Token: 0x040152BC RID: 86716
		internal static int __PropertyOffset_bEvalTransitionsOnStart;

		// Token: 0x040152BD RID: 86717
		internal static byte __PropertyMask_bEvalTransitionsOnStart;

		// Token: 0x040152BE RID: 86718
		internal static int __PropertyOffset_bDisableTickTransitionEvaluation;

		// Token: 0x040152BF RID: 86719
		internal static byte __PropertyMask_bDisableTickTransitionEvaluation;

		// Token: 0x040152C0 RID: 86720
		internal static int __PropertyOffset_bStayActiveOnStateChange;

		// Token: 0x040152C1 RID: 86721
		internal static byte __PropertyMask_bStayActiveOnStateChange;

		// Token: 0x040152C2 RID: 86722
		internal static int __PropertyOffset_bAllowParallelReentry;

		// Token: 0x040152C3 RID: 86723
		internal static byte __PropertyMask_bAllowParallelReentry;
	}
}
