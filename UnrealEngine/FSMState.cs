using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002891 RID: 10385
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SMSystem.SMState")]
	[UnrealStructLayout(344, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 344)]
	public class FSMState : FSMState_Base, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06026786 RID: 157574 RVA: 0x003A9233 File Offset: 0x003A7433
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSMState._ScriptStructPtr != 0) ? FSMState._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SMSystem.SMState", ref FSMState._ScriptStructPtr);
		}

		// Token: 0x1700944E RID: 37966
		// (get) Token: 0x06026787 RID: 157575 RVA: 0x003A9258 File Offset: 0x003A7458
		// (set) Token: 0x06026788 RID: 157576 RVA: 0x003A929B File Offset: 0x003A749B
		public TArray<FSMExposedFunctionHandler> BeginStateGraphEvaluator
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FSMExposedFunctionHandler> result;
				if ((result = this._BeginStateGraphEvaluator) == null)
				{
					result = (this._BeginStateGraphEvaluator = new TArray<FSMExposedFunctionHandler>(base.NativePtr + (IntPtr)FSMState.__PropertyOffset_BeginStateGraphEvaluator, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.BeginStateGraphEvaluator.CopyAssign(value);
			}
		}

		// Token: 0x1700944F RID: 37967
		// (get) Token: 0x06026789 RID: 157577 RVA: 0x003A92AC File Offset: 0x003A74AC
		// (set) Token: 0x0602678A RID: 157578 RVA: 0x003A92EF File Offset: 0x003A74EF
		public TArray<FSMExposedFunctionHandler> UpdateStateGraphEvaluator
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FSMExposedFunctionHandler> result;
				if ((result = this._UpdateStateGraphEvaluator) == null)
				{
					result = (this._UpdateStateGraphEvaluator = new TArray<FSMExposedFunctionHandler>(base.NativePtr + (IntPtr)FSMState.__PropertyOffset_UpdateStateGraphEvaluator, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.UpdateStateGraphEvaluator.CopyAssign(value);
			}
		}

		// Token: 0x17009450 RID: 37968
		// (get) Token: 0x0602678B RID: 157579 RVA: 0x003A9300 File Offset: 0x003A7500
		// (set) Token: 0x0602678C RID: 157580 RVA: 0x003A9343 File Offset: 0x003A7543
		public TArray<FSMExposedFunctionHandler> EndStateGraphEvaluator
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FSMExposedFunctionHandler> result;
				if ((result = this._EndStateGraphEvaluator) == null)
				{
					result = (this._EndStateGraphEvaluator = new TArray<FSMExposedFunctionHandler>(base.NativePtr + (IntPtr)FSMState.__PropertyOffset_EndStateGraphEvaluator, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.EndStateGraphEvaluator.CopyAssign(value);
			}
		}

		// Token: 0x0602678D RID: 157581 RVA: 0x003A9351 File Offset: 0x003A7551
		public FSMState()
		{
		}

		// Token: 0x0602678E RID: 157582 RVA: 0x003A935C File Offset: 0x003A755C
		public FSMState(TArray<FSMExposedFunctionHandler> BeginStateGraphEvaluator, TArray<FSMExposedFunctionHandler> UpdateStateGraphEvaluator, TArray<FSMExposedFunctionHandler> EndStateGraphEvaluator, bool bIsRootNode, bool bAlwaysUpdate, bool bEvalTransitionsOnStart, bool bDisableTickTransitionEvaluation, bool bStayActiveOnStateChange, bool bAllowParallelReentry, TArray<FSMExposedFunctionHandler> TransitionInitializedGraphEvaluators, TArray<FSMExposedFunctionHandler> TransitionShutdownGraphEvaluators, TArray<FSMExposedFunctionHandler> OnRootStateMachineStartedGraphEvaluator, TArray<FSMExposedFunctionHandler> OnRootStateMachineStoppedGraphEvaluator, float TimeInState, bool bIsInEndState, bool bHasUpdated, int DuplicateId, FGuid Guid, FGuid OwnerGuid, FGuid PathGuid, string NodeName, FName TemplateName, USMInstance OwningInstance, USMNodeInstance NodeInstance, UClassStackOnlyPtr NodeInstanceClass)
		{
			this.BeginStateGraphEvaluator = BeginStateGraphEvaluator;
			this.UpdateStateGraphEvaluator = UpdateStateGraphEvaluator;
			this.EndStateGraphEvaluator = EndStateGraphEvaluator;
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

		// Token: 0x0602678F RID: 157583 RVA: 0x003A9434 File Offset: 0x003A7634
		protected override IntPtr GetUStructPtr()
		{
			return FSMState.StaticStruct();
		}

		// Token: 0x06026790 RID: 157584 RVA: 0x003A9440 File Offset: 0x003A7640
		[NullableContext(2)]
		public FSMState(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06026791 RID: 157585 RVA: 0x003A944A File Offset: 0x003A764A
		public FSMState(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06026792 RID: 157586 RVA: 0x003A9455 File Offset: 0x003A7655
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSMState(Pointer, false, true);
		}

		// Token: 0x06026793 RID: 157587 RVA: 0x003A945F File Offset: 0x003A765F
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSMState(Pointer, MemoryOwner);
		}

		// Token: 0x040151CC RID: 86476
		public new const string __ObjectPath = "/Script/SMSystem.SMState";

		// Token: 0x040151CD RID: 86477
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040151CE RID: 86478
		internal static int __PropertyOffset_BeginStateGraphEvaluator;

		// Token: 0x040151CF RID: 86479
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSMExposedFunctionHandler> _BeginStateGraphEvaluator;

		// Token: 0x040151D0 RID: 86480
		internal static int __PropertyOffset_UpdateStateGraphEvaluator;

		// Token: 0x040151D1 RID: 86481
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSMExposedFunctionHandler> _UpdateStateGraphEvaluator;

		// Token: 0x040151D2 RID: 86482
		internal static int __PropertyOffset_EndStateGraphEvaluator;

		// Token: 0x040151D3 RID: 86483
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSMExposedFunctionHandler> _EndStateGraphEvaluator;
	}
}
