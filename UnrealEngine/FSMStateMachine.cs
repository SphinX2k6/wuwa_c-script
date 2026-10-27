using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002896 RID: 10390
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SMSystem.SMStateMachine")]
	[UnrealStructLayout(672, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 672)]
	public class FSMStateMachine : FSMState_Base, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060267F6 RID: 157686 RVA: 0x003AA511 File Offset: 0x003A8711
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSMStateMachine._ScriptStructPtr != 0) ? FSMStateMachine._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SMSystem.SMStateMachine", ref FSMStateMachine._ScriptStructPtr);
		}

		// Token: 0x17009467 RID: 37991
		// (get) Token: 0x060267F7 RID: 157687 RVA: 0x003AA535 File Offset: 0x003A8735
		// (set) Token: 0x060267F8 RID: 157688 RVA: 0x003AA545 File Offset: 0x003A8745
		public unsafe bool bHasAdditionalLogic
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSMStateMachine.__PropertyOffset_bHasAdditionalLogic) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSMStateMachine.__PropertyOffset_bHasAdditionalLogic) = (value ? 1 : 0);
			}
		}

		// Token: 0x17009468 RID: 37992
		// (get) Token: 0x060267F9 RID: 157689 RVA: 0x003AA556 File Offset: 0x003A8756
		// (set) Token: 0x060267FA RID: 157690 RVA: 0x003AA566 File Offset: 0x003A8766
		public unsafe bool bReuseCurrentState
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSMStateMachine.__PropertyOffset_bReuseCurrentState) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSMStateMachine.__PropertyOffset_bReuseCurrentState) = (value ? 1 : 0);
			}
		}

		// Token: 0x17009469 RID: 37993
		// (get) Token: 0x060267FB RID: 157691 RVA: 0x003AA577 File Offset: 0x003A8777
		// (set) Token: 0x060267FC RID: 157692 RVA: 0x003AA587 File Offset: 0x003A8787
		public unsafe bool bOnlyReuseIfNotEndState
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSMStateMachine.__PropertyOffset_bOnlyReuseIfNotEndState) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSMStateMachine.__PropertyOffset_bOnlyReuseIfNotEndState) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700946A RID: 37994
		// (get) Token: 0x060267FD RID: 157693 RVA: 0x003AA598 File Offset: 0x003A8798
		// (set) Token: 0x060267FE RID: 157694 RVA: 0x003AA5A8 File Offset: 0x003A87A8
		public unsafe bool bAllowIndependentTick
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSMStateMachine.__PropertyOffset_bAllowIndependentTick) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSMStateMachine.__PropertyOffset_bAllowIndependentTick) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700946B RID: 37995
		// (get) Token: 0x060267FF RID: 157695 RVA: 0x003AA5B9 File Offset: 0x003A87B9
		// (set) Token: 0x06026800 RID: 157696 RVA: 0x003AA5C9 File Offset: 0x003A87C9
		public unsafe bool bCallReferenceTickOnManualUpdate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSMStateMachine.__PropertyOffset_bCallReferenceTickOnManualUpdate) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSMStateMachine.__PropertyOffset_bCallReferenceTickOnManualUpdate) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700946C RID: 37996
		// (get) Token: 0x06026801 RID: 157697 RVA: 0x003AA5DA File Offset: 0x003A87DA
		// (set) Token: 0x06026802 RID: 157698 RVA: 0x003AA5F3 File Offset: 0x003A87F3
		public unsafe bool bWaitForEndState
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FSMStateMachine.__PropertyOffset_bWaitForEndState) & FSMStateMachine.__PropertyMask_bWaitForEndState) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FSMStateMachine.__PropertyOffset_bWaitForEndState) = ((*(base.NativePtr + (IntPtr)FSMStateMachine.__PropertyOffset_bWaitForEndState) & ~FSMStateMachine.__PropertyMask_bWaitForEndState) | (value ? FSMStateMachine.__PropertyMask_bWaitForEndState : 0));
			}
		}

		// Token: 0x1700946D RID: 37997
		// (get) Token: 0x06026803 RID: 157699 RVA: 0x003AA624 File Offset: 0x003A8824
		// (set) Token: 0x06026804 RID: 157700 RVA: 0x003AA667 File Offset: 0x003A8867
		public TArray<FSMExposedFunctionHandler> BeginStateGraphEvaluator
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FSMExposedFunctionHandler> result;
				if ((result = this._BeginStateGraphEvaluator) == null)
				{
					result = (this._BeginStateGraphEvaluator = new TArray<FSMExposedFunctionHandler>(base.NativePtr + (IntPtr)FSMStateMachine.__PropertyOffset_BeginStateGraphEvaluator, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.BeginStateGraphEvaluator.CopyAssign(value);
			}
		}

		// Token: 0x1700946E RID: 37998
		// (get) Token: 0x06026805 RID: 157701 RVA: 0x003AA678 File Offset: 0x003A8878
		// (set) Token: 0x06026806 RID: 157702 RVA: 0x003AA6BB File Offset: 0x003A88BB
		public TArray<FSMExposedFunctionHandler> UpdateStateGraphEvaluator
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FSMExposedFunctionHandler> result;
				if ((result = this._UpdateStateGraphEvaluator) == null)
				{
					result = (this._UpdateStateGraphEvaluator = new TArray<FSMExposedFunctionHandler>(base.NativePtr + (IntPtr)FSMStateMachine.__PropertyOffset_UpdateStateGraphEvaluator, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.UpdateStateGraphEvaluator.CopyAssign(value);
			}
		}

		// Token: 0x1700946F RID: 37999
		// (get) Token: 0x06026807 RID: 157703 RVA: 0x003AA6CC File Offset: 0x003A88CC
		// (set) Token: 0x06026808 RID: 157704 RVA: 0x003AA70F File Offset: 0x003A890F
		public TArray<FSMExposedFunctionHandler> EndStateGraphEvaluator
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FSMExposedFunctionHandler> result;
				if ((result = this._EndStateGraphEvaluator) == null)
				{
					result = (this._EndStateGraphEvaluator = new TArray<FSMExposedFunctionHandler>(base.NativePtr + (IntPtr)FSMStateMachine.__PropertyOffset_EndStateGraphEvaluator, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.EndStateGraphEvaluator.CopyAssign(value);
			}
		}

		// Token: 0x17009470 RID: 38000
		// (get) Token: 0x06026809 RID: 157705 RVA: 0x003AA71D File Offset: 0x003A891D
		// (set) Token: 0x0602680A RID: 157706 RVA: 0x003AA737 File Offset: 0x003A8937
		[Nullable(2)]
		public unsafe ISMStateMachineNetworkedInterface NetworkedInterface
		{
			[NullableContext(2)]
			get
			{
				return (ISMStateMachineNetworkedInterface)BuiltinUtils.GetOrCreateUObjectByNativePointer(*(base.NativePtr + (IntPtr)FSMStateMachine.__PropertyOffset_NetworkedInterface));
			}
			[NullableContext(2)]
			set
			{
				*(base.NativePtr + (IntPtr)FSMStateMachine.__PropertyOffset_NetworkedInterface) = new FScriptInterface(value, (value != null) ? value.InterfaceOffset() : 0);
			}
		}

		// Token: 0x17009471 RID: 38001
		// (get) Token: 0x0602680B RID: 157707 RVA: 0x003AA75D File Offset: 0x003A895D
		// (set) Token: 0x0602680C RID: 157708 RVA: 0x003AA771 File Offset: 0x003A8971
		public unsafe UClassStackOnlyPtr ReferencedStateMachineClass
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSMStateMachine.__PropertyOffset_ReferencedStateMachineClass);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSMStateMachine.__PropertyOffset_ReferencedStateMachineClass) = value;
			}
		}

		// Token: 0x17009472 RID: 38002
		// (get) Token: 0x0602680D RID: 157709 RVA: 0x003AA786 File Offset: 0x003A8986
		// (set) Token: 0x0602680E RID: 157710 RVA: 0x003AA79A File Offset: 0x003A899A
		public unsafe FName ReferencedTemplateName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSMStateMachine.__PropertyOffset_ReferencedTemplateName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSMStateMachine.__PropertyOffset_ReferencedTemplateName) = value;
			}
		}

		// Token: 0x17009473 RID: 38003
		// (get) Token: 0x0602680F RID: 157711 RVA: 0x003AA7AF File Offset: 0x003A89AF
		// (set) Token: 0x06026810 RID: 157712 RVA: 0x003AA7C3 File Offset: 0x003A89C3
		public unsafe FName DynamicStateMachineReferenceVariable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSMStateMachine.__PropertyOffset_DynamicStateMachineReferenceVariable);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSMStateMachine.__PropertyOffset_DynamicStateMachineReferenceVariable) = value;
			}
		}

		// Token: 0x17009474 RID: 38004
		// (get) Token: 0x06026811 RID: 157713 RVA: 0x003AA7D8 File Offset: 0x003A89D8
		// (set) Token: 0x06026812 RID: 157714 RVA: 0x003AA7EC File Offset: 0x003A89EC
		[Nullable(2)]
		public unsafe USMInstance ReferencedStateMachine
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USMInstance>(base.NativePtr / (IntPtr)sizeof(void*) + FSMStateMachine.__PropertyOffset_ReferencedStateMachine);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FSMStateMachine.__PropertyOffset_ReferencedStateMachine, value);
			}
		}

		// Token: 0x17009475 RID: 38005
		// (get) Token: 0x06026813 RID: 157715 RVA: 0x003AA801 File Offset: 0x003A8A01
		// (set) Token: 0x06026814 RID: 157716 RVA: 0x003AA815 File Offset: 0x003A8A15
		[Nullable(2)]
		public unsafe USMInstance IsReferencedByInstance
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USMInstance>(base.NativePtr / (IntPtr)sizeof(void*) + FSMStateMachine.__PropertyOffset_IsReferencedByInstance);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FSMStateMachine.__PropertyOffset_IsReferencedByInstance, value);
			}
		}

		// Token: 0x06026815 RID: 157717 RVA: 0x003AA82A File Offset: 0x003A8A2A
		public FSMStateMachine()
		{
		}

		// Token: 0x06026816 RID: 157718 RVA: 0x003AA834 File Offset: 0x003A8A34
		public FSMStateMachine(bool bHasAdditionalLogic, bool bReuseCurrentState, bool bOnlyReuseIfNotEndState, bool bAllowIndependentTick, bool bCallReferenceTickOnManualUpdate, bool bWaitForEndState, TArray<FSMExposedFunctionHandler> BeginStateGraphEvaluator, TArray<FSMExposedFunctionHandler> UpdateStateGraphEvaluator, TArray<FSMExposedFunctionHandler> EndStateGraphEvaluator, ISMStateMachineNetworkedInterface NetworkedInterface, UClassStackOnlyPtr ReferencedStateMachineClass, FName ReferencedTemplateName, FName DynamicStateMachineReferenceVariable, USMInstance ReferencedStateMachine, USMInstance IsReferencedByInstance, bool bIsRootNode, bool bAlwaysUpdate, bool bEvalTransitionsOnStart, bool bDisableTickTransitionEvaluation, bool bStayActiveOnStateChange, bool bAllowParallelReentry, TArray<FSMExposedFunctionHandler> TransitionInitializedGraphEvaluators, TArray<FSMExposedFunctionHandler> TransitionShutdownGraphEvaluators, TArray<FSMExposedFunctionHandler> OnRootStateMachineStartedGraphEvaluator, TArray<FSMExposedFunctionHandler> OnRootStateMachineStoppedGraphEvaluator, float TimeInState, bool bIsInEndState, bool bHasUpdated, int DuplicateId, FGuid Guid, FGuid OwnerGuid, FGuid PathGuid, string NodeName, FName TemplateName, USMInstance OwningInstance, USMNodeInstance NodeInstance, UClassStackOnlyPtr NodeInstanceClass)
		{
			this.bHasAdditionalLogic = bHasAdditionalLogic;
			this.bReuseCurrentState = bReuseCurrentState;
			this.bOnlyReuseIfNotEndState = bOnlyReuseIfNotEndState;
			this.bAllowIndependentTick = bAllowIndependentTick;
			this.bCallReferenceTickOnManualUpdate = bCallReferenceTickOnManualUpdate;
			this.bWaitForEndState = bWaitForEndState;
			this.BeginStateGraphEvaluator = BeginStateGraphEvaluator;
			this.UpdateStateGraphEvaluator = UpdateStateGraphEvaluator;
			this.EndStateGraphEvaluator = EndStateGraphEvaluator;
			this.NetworkedInterface = NetworkedInterface;
			this.ReferencedStateMachineClass = ReferencedStateMachineClass;
			this.ReferencedTemplateName = ReferencedTemplateName;
			this.DynamicStateMachineReferenceVariable = DynamicStateMachineReferenceVariable;
			this.ReferencedStateMachine = ReferencedStateMachine;
			this.IsReferencedByInstance = IsReferencedByInstance;
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

		// Token: 0x06026817 RID: 157719 RVA: 0x003AA96C File Offset: 0x003A8B6C
		protected override IntPtr GetUStructPtr()
		{
			return FSMStateMachine.StaticStruct();
		}

		// Token: 0x06026818 RID: 157720 RVA: 0x003AA978 File Offset: 0x003A8B78
		[NullableContext(2)]
		public FSMStateMachine(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06026819 RID: 157721 RVA: 0x003AA982 File Offset: 0x003A8B82
		public FSMStateMachine(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602681A RID: 157722 RVA: 0x003AA98D File Offset: 0x003A8B8D
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSMStateMachine(Pointer, false, true);
		}

		// Token: 0x0602681B RID: 157723 RVA: 0x003AA997 File Offset: 0x003A8B97
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSMStateMachine(Pointer, MemoryOwner);
		}

		// Token: 0x0401521A RID: 86554
		public new const string __ObjectPath = "/Script/SMSystem.SMStateMachine";

		// Token: 0x0401521B RID: 86555
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401521C RID: 86556
		internal static int __PropertyOffset_bHasAdditionalLogic;

		// Token: 0x0401521D RID: 86557
		internal static int __PropertyOffset_bReuseCurrentState;

		// Token: 0x0401521E RID: 86558
		internal static int __PropertyOffset_bOnlyReuseIfNotEndState;

		// Token: 0x0401521F RID: 86559
		internal static int __PropertyOffset_bAllowIndependentTick;

		// Token: 0x04015220 RID: 86560
		internal static int __PropertyOffset_bCallReferenceTickOnManualUpdate;

		// Token: 0x04015221 RID: 86561
		internal static int __PropertyOffset_bWaitForEndState;

		// Token: 0x04015222 RID: 86562
		internal static byte __PropertyMask_bWaitForEndState;

		// Token: 0x04015223 RID: 86563
		internal static int __PropertyOffset_BeginStateGraphEvaluator;

		// Token: 0x04015224 RID: 86564
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSMExposedFunctionHandler> _BeginStateGraphEvaluator;

		// Token: 0x04015225 RID: 86565
		internal static int __PropertyOffset_UpdateStateGraphEvaluator;

		// Token: 0x04015226 RID: 86566
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSMExposedFunctionHandler> _UpdateStateGraphEvaluator;

		// Token: 0x04015227 RID: 86567
		internal static int __PropertyOffset_EndStateGraphEvaluator;

		// Token: 0x04015228 RID: 86568
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSMExposedFunctionHandler> _EndStateGraphEvaluator;

		// Token: 0x04015229 RID: 86569
		internal static int __PropertyOffset_NetworkedInterface;

		// Token: 0x0401522A RID: 86570
		internal static int __PropertyOffset_ReferencedStateMachineClass;

		// Token: 0x0401522B RID: 86571
		internal static int __PropertyOffset_ReferencedTemplateName;

		// Token: 0x0401522C RID: 86572
		internal static int __PropertyOffset_DynamicStateMachineReferenceVariable;

		// Token: 0x0401522D RID: 86573
		internal static int __PropertyOffset_ReferencedStateMachine;

		// Token: 0x0401522E RID: 86574
		internal static int __PropertyOffset_IsReferencedByInstance;
	}
}
