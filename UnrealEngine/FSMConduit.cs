using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002880 RID: 10368
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SMSystem.SMConduit")]
	[UnrealStructLayout(344, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 344)]
	public class FSMConduit : FSMState_Base, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06026601 RID: 157185 RVA: 0x003A522B File Offset: 0x003A342B
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSMConduit._ScriptStructPtr != 0) ? FSMConduit._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SMSystem.SMConduit", ref FSMConduit._ScriptStructPtr);
		}

		// Token: 0x17009400 RID: 37888
		// (get) Token: 0x06026602 RID: 157186 RVA: 0x003A524F File Offset: 0x003A344F
		// (set) Token: 0x06026603 RID: 157187 RVA: 0x003A5268 File Offset: 0x003A3468
		public unsafe bool bCanEnterTransition
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FSMConduit.__PropertyOffset_bCanEnterTransition) & FSMConduit.__PropertyMask_bCanEnterTransition) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FSMConduit.__PropertyOffset_bCanEnterTransition) = ((*(base.NativePtr + (IntPtr)FSMConduit.__PropertyOffset_bCanEnterTransition) & ~FSMConduit.__PropertyMask_bCanEnterTransition) | (value ? FSMConduit.__PropertyMask_bCanEnterTransition : 0));
			}
		}

		// Token: 0x17009401 RID: 37889
		// (get) Token: 0x06026604 RID: 157188 RVA: 0x003A5298 File Offset: 0x003A3498
		// (set) Token: 0x06026605 RID: 157189 RVA: 0x003A52B1 File Offset: 0x003A34B1
		public unsafe bool bCanEvaluate
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FSMConduit.__PropertyOffset_bCanEvaluate) & FSMConduit.__PropertyMask_bCanEvaluate) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FSMConduit.__PropertyOffset_bCanEvaluate) = ((*(base.NativePtr + (IntPtr)FSMConduit.__PropertyOffset_bCanEvaluate) & ~FSMConduit.__PropertyMask_bCanEvaluate) | (value ? FSMConduit.__PropertyMask_bCanEvaluate : 0));
			}
		}

		// Token: 0x17009402 RID: 37890
		// (get) Token: 0x06026606 RID: 157190 RVA: 0x003A52E1 File Offset: 0x003A34E1
		// (set) Token: 0x06026607 RID: 157191 RVA: 0x003A52FA File Offset: 0x003A34FA
		public unsafe bool bEvalWithTransitions
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FSMConduit.__PropertyOffset_bEvalWithTransitions) & FSMConduit.__PropertyMask_bEvalWithTransitions) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FSMConduit.__PropertyOffset_bEvalWithTransitions) = ((*(base.NativePtr + (IntPtr)FSMConduit.__PropertyOffset_bEvalWithTransitions) & ~FSMConduit.__PropertyMask_bEvalWithTransitions) | (value ? FSMConduit.__PropertyMask_bEvalWithTransitions : 0));
			}
		}

		// Token: 0x17009403 RID: 37891
		// (get) Token: 0x06026608 RID: 157192 RVA: 0x003A532C File Offset: 0x003A352C
		// (set) Token: 0x06026609 RID: 157193 RVA: 0x003A536F File Offset: 0x003A356F
		public TArray<FSMExposedFunctionHandler> CanEnterConduitGraphEvaluator
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FSMExposedFunctionHandler> result;
				if ((result = this._CanEnterConduitGraphEvaluator) == null)
				{
					result = (this._CanEnterConduitGraphEvaluator = new TArray<FSMExposedFunctionHandler>(base.NativePtr + (IntPtr)FSMConduit.__PropertyOffset_CanEnterConduitGraphEvaluator, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.CanEnterConduitGraphEvaluator.CopyAssign(value);
			}
		}

		// Token: 0x17009404 RID: 37892
		// (get) Token: 0x0602660A RID: 157194 RVA: 0x003A5380 File Offset: 0x003A3580
		// (set) Token: 0x0602660B RID: 157195 RVA: 0x003A53C3 File Offset: 0x003A35C3
		public TArray<FSMExposedFunctionHandler> ConduitEnteredGraphEvaluator
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FSMExposedFunctionHandler> result;
				if ((result = this._ConduitEnteredGraphEvaluator) == null)
				{
					result = (this._ConduitEnteredGraphEvaluator = new TArray<FSMExposedFunctionHandler>(base.NativePtr + (IntPtr)FSMConduit.__PropertyOffset_ConduitEnteredGraphEvaluator, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ConduitEnteredGraphEvaluator.CopyAssign(value);
			}
		}

		// Token: 0x17009405 RID: 37893
		// (get) Token: 0x0602660C RID: 157196 RVA: 0x003A53D1 File Offset: 0x003A35D1
		// (set) Token: 0x0602660D RID: 157197 RVA: 0x003A53E1 File Offset: 0x003A35E1
		public unsafe ESMConditionalEvaluationType ConditionalEvaluationType
		{
			get
			{
				return (ESMConditionalEvaluationType)(*(base.NativePtr + (IntPtr)FSMConduit.__PropertyOffset_ConditionalEvaluationType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSMConduit.__PropertyOffset_ConditionalEvaluationType) = (byte)value;
			}
		}

		// Token: 0x0602660E RID: 157198 RVA: 0x003A53F2 File Offset: 0x003A35F2
		public FSMConduit()
		{
		}

		// Token: 0x0602660F RID: 157199 RVA: 0x003A53FC File Offset: 0x003A35FC
		public FSMConduit(bool bCanEnterTransition, bool bCanEvaluate, bool bEvalWithTransitions, TArray<FSMExposedFunctionHandler> CanEnterConduitGraphEvaluator, TArray<FSMExposedFunctionHandler> ConduitEnteredGraphEvaluator, ESMConditionalEvaluationType ConditionalEvaluationType, bool bIsRootNode, bool bAlwaysUpdate, bool bEvalTransitionsOnStart, bool bDisableTickTransitionEvaluation, bool bStayActiveOnStateChange, bool bAllowParallelReentry, TArray<FSMExposedFunctionHandler> TransitionInitializedGraphEvaluators, TArray<FSMExposedFunctionHandler> TransitionShutdownGraphEvaluators, TArray<FSMExposedFunctionHandler> OnRootStateMachineStartedGraphEvaluator, TArray<FSMExposedFunctionHandler> OnRootStateMachineStoppedGraphEvaluator, float TimeInState, bool bIsInEndState, bool bHasUpdated, int DuplicateId, FGuid Guid, FGuid OwnerGuid, FGuid PathGuid, string NodeName, FName TemplateName, USMInstance OwningInstance, USMNodeInstance NodeInstance, UClassStackOnlyPtr NodeInstanceClass)
		{
			this.bCanEnterTransition = bCanEnterTransition;
			this.bCanEvaluate = bCanEvaluate;
			this.bEvalWithTransitions = bEvalWithTransitions;
			this.CanEnterConduitGraphEvaluator = CanEnterConduitGraphEvaluator;
			this.ConduitEnteredGraphEvaluator = ConduitEnteredGraphEvaluator;
			this.ConditionalEvaluationType = ConditionalEvaluationType;
			base.bIsRootNode = bIsRootNode;
			base.bAlwaysUpdate = bAlwaysUpdate;
			base.bEvalTransitionsOnStart = bEvalTransitionsOnStart;
			base.bDisableTickTransitionEvaluation = bDisableTickTransitionEvaluation;
			base.bStayActiveOnStateChange = bStayActiveOnStateChange;
			base.bAllowParallelReentry = bAllowParallelReentry;
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

		// Token: 0x06026610 RID: 157200 RVA: 0x003A54EC File Offset: 0x003A36EC
		protected override IntPtr GetUStructPtr()
		{
			return FSMConduit.StaticStruct();
		}

		// Token: 0x06026611 RID: 157201 RVA: 0x003A54F8 File Offset: 0x003A36F8
		[NullableContext(2)]
		public FSMConduit(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06026612 RID: 157202 RVA: 0x003A5502 File Offset: 0x003A3702
		public FSMConduit(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06026613 RID: 157203 RVA: 0x003A550D File Offset: 0x003A370D
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSMConduit(Pointer, false, true);
		}

		// Token: 0x06026614 RID: 157204 RVA: 0x003A5517 File Offset: 0x003A3717
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSMConduit(Pointer, MemoryOwner);
		}

		// Token: 0x040150BF RID: 86207
		public new const string __ObjectPath = "/Script/SMSystem.SMConduit";

		// Token: 0x040150C0 RID: 86208
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040150C1 RID: 86209
		internal static int __PropertyOffset_bCanEnterTransition;

		// Token: 0x040150C2 RID: 86210
		internal static byte __PropertyMask_bCanEnterTransition;

		// Token: 0x040150C3 RID: 86211
		internal static int __PropertyOffset_bCanEvaluate;

		// Token: 0x040150C4 RID: 86212
		internal static byte __PropertyMask_bCanEvaluate;

		// Token: 0x040150C5 RID: 86213
		internal static int __PropertyOffset_bEvalWithTransitions;

		// Token: 0x040150C6 RID: 86214
		internal static byte __PropertyMask_bEvalWithTransitions;

		// Token: 0x040150C7 RID: 86215
		internal static int __PropertyOffset_CanEnterConduitGraphEvaluator;

		// Token: 0x040150C8 RID: 86216
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSMExposedFunctionHandler> _CanEnterConduitGraphEvaluator;

		// Token: 0x040150C9 RID: 86217
		internal static int __PropertyOffset_ConduitEnteredGraphEvaluator;

		// Token: 0x040150CA RID: 86218
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSMExposedFunctionHandler> _ConduitEnteredGraphEvaluator;

		// Token: 0x040150CB RID: 86219
		internal static int __PropertyOffset_ConditionalEvaluationType;
	}
}
