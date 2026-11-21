using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000834 RID: 2100
	[UnrealObjectPath("/Script/SMSystem.SMStateInstance_Base")]
	[UnrealStructLayout(256, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 256)]
	public abstract class USMStateInstance_Base : USMNodeInstance, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600B711 RID: 46865 RVA: 0x00124989 File Offset: 0x00122B89
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USMStateInstance_Base._ClassPtr;
		}

		// Token: 0x17002231 RID: 8753
		// (get) Token: 0x0600B712 RID: 46866 RVA: 0x00124998 File Offset: 0x00122B98
		// (set) Token: 0x0600B713 RID: 46867 RVA: 0x001249D1 File Offset: 0x00122BD1
		[Nullable(1)]
		public FOnStateBeginSignature OnStateBeginEvent
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FOnStateBeginSignature result;
				if ((result = this._OnStateBeginEvent) == null)
				{
					result = (this._OnStateBeginEvent = new FOnStateBeginSignature(base.NativePtr + (IntPtr)USMStateInstance_Base.__PropertyOffset_OnStateBeginEvent, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)USMStateInstance_Base.__PropertyOffset_OnStateBeginEvent, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17002232 RID: 8754
		// (get) Token: 0x0600B714 RID: 46868 RVA: 0x001249F4 File Offset: 0x00122BF4
		// (set) Token: 0x0600B715 RID: 46869 RVA: 0x00124A2D File Offset: 0x00122C2D
		[Nullable(1)]
		public FOnStateBeginSignature OnPostStateBeginEvent
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FOnStateBeginSignature result;
				if ((result = this._OnPostStateBeginEvent) == null)
				{
					result = (this._OnPostStateBeginEvent = new FOnStateBeginSignature(base.NativePtr + (IntPtr)USMStateInstance_Base.__PropertyOffset_OnPostStateBeginEvent, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)USMStateInstance_Base.__PropertyOffset_OnPostStateBeginEvent, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17002233 RID: 8755
		// (get) Token: 0x0600B716 RID: 46870 RVA: 0x00124A50 File Offset: 0x00122C50
		// (set) Token: 0x0600B717 RID: 46871 RVA: 0x00124A89 File Offset: 0x00122C89
		[Nullable(1)]
		public FOnStateUpdateSignature OnStateUpdateEvent
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FOnStateUpdateSignature result;
				if ((result = this._OnStateUpdateEvent) == null)
				{
					result = (this._OnStateUpdateEvent = new FOnStateUpdateSignature(base.NativePtr + (IntPtr)USMStateInstance_Base.__PropertyOffset_OnStateUpdateEvent, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)USMStateInstance_Base.__PropertyOffset_OnStateUpdateEvent, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17002234 RID: 8756
		// (get) Token: 0x0600B718 RID: 46872 RVA: 0x00124AAC File Offset: 0x00122CAC
		// (set) Token: 0x0600B719 RID: 46873 RVA: 0x00124AE5 File Offset: 0x00122CE5
		[Nullable(1)]
		public FOnStateEndSignature OnStateEndEvent
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FOnStateEndSignature result;
				if ((result = this._OnStateEndEvent) == null)
				{
					result = (this._OnStateEndEvent = new FOnStateEndSignature(base.NativePtr + (IntPtr)USMStateInstance_Base.__PropertyOffset_OnStateEndEvent, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)USMStateInstance_Base.__PropertyOffset_OnStateEndEvent, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17002235 RID: 8757
		// (get) Token: 0x0600B71A RID: 46874 RVA: 0x00124B06 File Offset: 0x00122D06
		// (set) Token: 0x0600B71B RID: 46875 RVA: 0x00124B1A File Offset: 0x00122D1A
		public unsafe TEnumAsByte<ETakeControlType> TakeControlType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USMStateInstance_Base.__PropertyOffset_TakeControlType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USMStateInstance_Base.__PropertyOffset_TakeControlType) = value;
			}
		}

		// Token: 0x17002236 RID: 8758
		// (get) Token: 0x0600B71C RID: 46876 RVA: 0x00124B2F File Offset: 0x00122D2F
		// (set) Token: 0x0600B71D RID: 46877 RVA: 0x00124B43 File Offset: 0x00122D43
		public unsafe TEnumAsByte<ETransitionRule> TransitionRule
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USMStateInstance_Base.__PropertyOffset_TransitionRule);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USMStateInstance_Base.__PropertyOffset_TransitionRule) = value;
			}
		}

		// Token: 0x17002237 RID: 8759
		// (get) Token: 0x0600B71E RID: 46878 RVA: 0x00124B58 File Offset: 0x00122D58
		// (set) Token: 0x0600B71F RID: 46879 RVA: 0x00124B6C File Offset: 0x00122D6C
		[Nullable(2)]
		public unsafe UASMTask Task
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UASMTask>(base.NativePtr / (IntPtr)sizeof(void*) + USMStateInstance_Base.__PropertyOffset_Task);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + USMStateInstance_Base.__PropertyOffset_Task, value);
			}
		}

		// Token: 0x17002238 RID: 8760
		// (get) Token: 0x0600B720 RID: 46880 RVA: 0x00124B84 File Offset: 0x00122D84
		// (set) Token: 0x0600B721 RID: 46881 RVA: 0x00124BBD File Offset: 0x00122DBD
		[Nullable(1)]
		public TArray<UASMBindState> BindStates
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UASMBindState> result;
				if ((result = this._BindStates) == null)
				{
					result = (this._BindStates = new TArray<UASMBindState>(base.NativePtr + (IntPtr)USMStateInstance_Base.__PropertyOffset_BindStates, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.BindStates.CopyAssign(value);
			}
		}

		// Token: 0x17002239 RID: 8761
		// (get) Token: 0x0600B722 RID: 46882 RVA: 0x00124BCC File Offset: 0x00122DCC
		// (set) Token: 0x0600B723 RID: 46883 RVA: 0x00124C05 File Offset: 0x00122E05
		[Nullable(1)]
		public TArray<UASMAction> OnEnterActions
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UASMAction> result;
				if ((result = this._OnEnterActions) == null)
				{
					result = (this._OnEnterActions = new TArray<UASMAction>(base.NativePtr + (IntPtr)USMStateInstance_Base.__PropertyOffset_OnEnterActions, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.OnEnterActions.CopyAssign(value);
			}
		}

		// Token: 0x1700223A RID: 8762
		// (get) Token: 0x0600B724 RID: 46884 RVA: 0x00124C14 File Offset: 0x00122E14
		// (set) Token: 0x0600B725 RID: 46885 RVA: 0x00124C4D File Offset: 0x00122E4D
		[Nullable(1)]
		public TArray<UASMAction> OnExitActions
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UASMAction> result;
				if ((result = this._OnExitActions) == null)
				{
					result = (this._OnExitActions = new TArray<UASMAction>(base.NativePtr + (IntPtr)USMStateInstance_Base.__PropertyOffset_OnExitActions, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.OnExitActions.CopyAssign(value);
			}
		}

		// Token: 0x1700223B RID: 8763
		// (get) Token: 0x0600B726 RID: 46886 RVA: 0x00124C5B File Offset: 0x00122E5B
		// (set) Token: 0x0600B727 RID: 46887 RVA: 0x00124C6F File Offset: 0x00122E6F
		[Nullable(1)]
		public unsafe string NodeName
		{
			[NullableContext(1)]
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)USMStateInstance_Base.__PropertyOffset_NodeName)));
			}
			[NullableContext(1)]
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)USMStateInstance_Base.__PropertyOffset_NodeName)), value);
			}
		}

		// Token: 0x1700223C RID: 8764
		// (get) Token: 0x0600B728 RID: 46888 RVA: 0x00124C84 File Offset: 0x00122E84
		// (set) Token: 0x0600B729 RID: 46889 RVA: 0x00124C94 File Offset: 0x00122E94
		public unsafe bool IsRefNode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USMStateInstance_Base.__PropertyOffset_IsRefNode) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)USMStateInstance_Base.__PropertyOffset_IsRefNode) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700223D RID: 8765
		// (get) Token: 0x0600B72A RID: 46890 RVA: 0x00124CA5 File Offset: 0x00122EA5
		// (set) Token: 0x0600B72B RID: 46891 RVA: 0x00124CB5 File Offset: 0x00122EB5
		public unsafe bool IsOvrNode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USMStateInstance_Base.__PropertyOffset_IsOvrNode) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)USMStateInstance_Base.__PropertyOffset_IsOvrNode) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700223E RID: 8766
		// (get) Token: 0x0600B72C RID: 46892 RVA: 0x00124CC6 File Offset: 0x00122EC6
		// (set) Token: 0x0600B72D RID: 46893 RVA: 0x00124CD6 File Offset: 0x00122ED6
		public unsafe bool IsAnimNode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USMStateInstance_Base.__PropertyOffset_IsAnimNode) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)USMStateInstance_Base.__PropertyOffset_IsAnimNode) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700223F RID: 8767
		// (get) Token: 0x0600B72E RID: 46894 RVA: 0x00124CE7 File Offset: 0x00122EE7
		// (set) Token: 0x0600B72F RID: 46895 RVA: 0x00124CF7 File Offset: 0x00122EF7
		public unsafe bool IsConduitNode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USMStateInstance_Base.__PropertyOffset_IsConduitNode) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)USMStateInstance_Base.__PropertyOffset_IsConduitNode) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002240 RID: 8768
		// (get) Token: 0x0600B730 RID: 46896 RVA: 0x00124D08 File Offset: 0x00122F08
		// (set) Token: 0x0600B731 RID: 46897 RVA: 0x00124D18 File Offset: 0x00122F18
		public unsafe bool IsAnyStateNode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USMStateInstance_Base.__PropertyOffset_IsAnyStateNode) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)USMStateInstance_Base.__PropertyOffset_IsAnyStateNode) = (value ? 1 : 0);
			}
		}

		// Token: 0x0600B732 RID: 46898 RVA: 0x00124D2C File Offset: 0x00122F2C
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe bool SwitchToLinkedStateByTransition(USMTransitionInstance TransitionInstance, bool bRequireTransitionToPass = true, bool bActivateNow = true)
		{
			USMStateInstance_Base.__SwitchToLinkedStateByTransition_FunctionParams* ptr = stackalloc USMStateInstance_Base.__SwitchToLinkedStateByTransition_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(USMStateInstance_Base.__SwitchToLinkedStateByTransition_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMStateInstance_Base.__SwitchToLinkedStateByTransition_NativeFunctionPtr, (void*)ptr, 1);
			ptr->TransitionInstance = ((TransitionInstance != null) ? TransitionInstance.NativePtr : IntPtr.Zero);
			ptr->bRequireTransitionToPass = bRequireTransitionToPass;
			ptr->bActivateNow = bActivateNow;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMStateInstance_Base.__SwitchToLinkedStateByTransition_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0600B733 RID: 46899 RVA: 0x00124D98 File Offset: 0x00122F98
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe bool SwitchToLinkedStateByName(string NextStateName, bool bRequireTransitionToPass = true, bool bActivateNow = true)
		{
			USMStateInstance_Base.__SwitchToLinkedStateByName_FunctionParams* ptr = stackalloc USMStateInstance_Base.__SwitchToLinkedStateByName_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(USMStateInstance_Base.__SwitchToLinkedStateByName_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMStateInstance_Base.__SwitchToLinkedStateByName_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->NextStateName), NextStateName);
			ptr->bRequireTransitionToPass = bRequireTransitionToPass;
			ptr->bActivateNow = bActivateNow;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMStateInstance_Base.__SwitchToLinkedStateByName_NativeFunctionPtr, (void*)ptr);
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(USMStateInstance_Base.__SwitchToLinkedStateByName_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0600B734 RID: 46900 RVA: 0x00124E0C File Offset: 0x0012300C
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe bool SwitchToLinkedState(USMStateInstance_Base NextStateInstance, bool bRequireTransitionToPass = true, bool bActivateNow = true)
		{
			USMStateInstance_Base.__SwitchToLinkedState_FunctionParams* ptr = stackalloc USMStateInstance_Base.__SwitchToLinkedState_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(USMStateInstance_Base.__SwitchToLinkedState_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMStateInstance_Base.__SwitchToLinkedState_NativeFunctionPtr, (void*)ptr, 1);
			ptr->NextStateInstance = ((NextStateInstance != null) ? NextStateInstance.NativePtr : IntPtr.Zero);
			ptr->bRequireTransitionToPass = bRequireTransitionToPass;
			ptr->bActivateNow = bActivateNow;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMStateInstance_Base.__SwitchToLinkedState_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0600B735 RID: 46901 RVA: 0x00124E78 File Offset: 0x00123078
		[SkipLocalsInit]
		public unsafe void SetExcludeFromAnyState(bool bValue)
		{
			USMStateInstance_Base.__SetExcludeFromAnyState_FunctionParams* ptr = stackalloc USMStateInstance_Base.__SetExcludeFromAnyState_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(USMStateInstance_Base.__SetExcludeFromAnyState_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMStateInstance_Base.__SetExcludeFromAnyState_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bValue = bValue;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMStateInstance_Base.__SetExcludeFromAnyState_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600B736 RID: 46902 RVA: 0x00124EC0 File Offset: 0x001230C0
		[SkipLocalsInit]
		public unsafe void SetEvalTransitionsOnStart(bool bValue)
		{
			USMStateInstance_Base.__SetEvalTransitionsOnStart_FunctionParams* ptr = stackalloc USMStateInstance_Base.__SetEvalTransitionsOnStart_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(USMStateInstance_Base.__SetEvalTransitionsOnStart_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMStateInstance_Base.__SetEvalTransitionsOnStart_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bValue = bValue;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMStateInstance_Base.__SetEvalTransitionsOnStart_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600B737 RID: 46903 RVA: 0x00124F08 File Offset: 0x00123108
		[SkipLocalsInit]
		public unsafe void SetDisableTickTransitionEvaluation(bool bValue)
		{
			USMStateInstance_Base.__SetDisableTickTransitionEvaluation_FunctionParams* ptr = stackalloc USMStateInstance_Base.__SetDisableTickTransitionEvaluation_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(USMStateInstance_Base.__SetDisableTickTransitionEvaluation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMStateInstance_Base.__SetDisableTickTransitionEvaluation_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bValue = bValue;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMStateInstance_Base.__SetDisableTickTransitionEvaluation_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600B738 RID: 46904 RVA: 0x00124F50 File Offset: 0x00123150
		[SkipLocalsInit]
		public unsafe void SetAlwaysUpdate(bool bValue)
		{
			USMStateInstance_Base.__SetAlwaysUpdate_FunctionParams* ptr = stackalloc USMStateInstance_Base.__SetAlwaysUpdate_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(USMStateInstance_Base.__SetAlwaysUpdate_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMStateInstance_Base.__SetAlwaysUpdate_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bValue = bValue;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMStateInstance_Base.__SetAlwaysUpdate_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600B739 RID: 46905 RVA: 0x00124F98 File Offset: 0x00123198
		[SkipLocalsInit]
		public unsafe void SetActive(bool bValue, bool bSetAllParents = false, bool bActivateNow = true)
		{
			USMStateInstance_Base.__SetActive_FunctionParams* ptr = stackalloc USMStateInstance_Base.__SetActive_FunctionParams[(UIntPtr)18] + 15L / (long)sizeof(USMStateInstance_Base.__SetActive_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMStateInstance_Base.__SetActive_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bValue = bValue;
			ptr->bSetAllParents = bSetAllParents;
			ptr->bActivateNow = bActivateNow;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMStateInstance_Base.__SetActive_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600B73A RID: 46906 RVA: 0x00124FEC File Offset: 0x001231EC
		[SkipLocalsInit]
		public unsafe bool IsStateMachine()
		{
			USMStateInstance_Base.__IsStateMachine_FunctionParams* ptr = stackalloc USMStateInstance_Base.__IsStateMachine_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(USMStateInstance_Base.__IsStateMachine_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMStateInstance_Base.__IsStateMachine_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMStateInstance_Base.__IsStateMachine_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0600B73B RID: 46907 RVA: 0x00125034 File Offset: 0x00123234
		[SkipLocalsInit]
		public unsafe bool IsEntryState()
		{
			USMStateInstance_Base.__IsEntryState_FunctionParams* ptr = stackalloc USMStateInstance_Base.__IsEntryState_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(USMStateInstance_Base.__IsEntryState_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMStateInstance_Base.__IsEntryState_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMStateInstance_Base.__IsEntryState_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0600B73C RID: 46908 RVA: 0x0012507C File Offset: 0x0012327C
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe USMTransitionInstance GetTransitionToTake()
		{
			USMStateInstance_Base.__GetTransitionToTake_FunctionParams* ptr = stackalloc USMStateInstance_Base.__GetTransitionToTake_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(USMStateInstance_Base.__GetTransitionToTake_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMStateInstance_Base.__GetTransitionToTake_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMStateInstance_Base.__GetTransitionToTake_NativeFunctionPtr, (void*)ptr);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<USMTransitionInstance>(ptr->__Result);
		}

		// Token: 0x0600B73D RID: 46909 RVA: 0x001250C8 File Offset: 0x001232C8
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe USMTransitionInstance GetTransitionByIndex(int Index)
		{
			USMStateInstance_Base.__GetTransitionByIndex_FunctionParams* ptr = stackalloc USMStateInstance_Base.__GetTransitionByIndex_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(USMStateInstance_Base.__GetTransitionByIndex_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMStateInstance_Base.__GetTransitionByIndex_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Index = Index;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMStateInstance_Base.__GetTransitionByIndex_NativeFunctionPtr, (void*)ptr);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<USMTransitionInstance>(ptr->__Result);
		}

		// Token: 0x0600B73E RID: 46910 RVA: 0x0012511C File Offset: 0x0012331C
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe FDateTime GetStartTime()
		{
			USMStateInstance_Base.__GetStartTime_FunctionParams* ptr = stackalloc USMStateInstance_Base.__GetStartTime_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(USMStateInstance_Base.__GetStartTime_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMStateInstance_Base.__GetStartTime_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMStateInstance_Base.__GetStartTime_NativeFunctionPtr, (void*)ptr);
			return new FDateTime(&ptr->__Result, true, true);
		}

		// Token: 0x0600B73F RID: 46911 RVA: 0x0012516C File Offset: 0x0012336C
		[SkipLocalsInit]
		public unsafe float GetServerTimeInState(ref bool bOutUsedLocalTime)
		{
			USMStateInstance_Base.__GetServerTimeInState_FunctionParams* ptr = stackalloc USMStateInstance_Base.__GetServerTimeInState_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(USMStateInstance_Base.__GetServerTimeInState_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMStateInstance_Base.__GetServerTimeInState_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bOutUsedLocalTime = bOutUsedLocalTime;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMStateInstance_Base.__GetServerTimeInState_NativeFunctionPtr, (void*)ptr);
			bOutUsedLocalTime = ptr->bOutUsedLocalTime;
			return ptr->__Result;
		}

		// Token: 0x0600B740 RID: 46912 RVA: 0x001251C4 File Offset: 0x001233C4
		[NullableContext(1)]
		[SkipLocalsInit]
		[return: Nullable(2)]
		public unsafe USMStateInstance_Base GetPreviousStateByName(string StateName)
		{
			USMStateInstance_Base.__GetPreviousStateByName_FunctionParams* ptr = stackalloc USMStateInstance_Base.__GetPreviousStateByName_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(USMStateInstance_Base.__GetPreviousStateByName_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMStateInstance_Base.__GetPreviousStateByName_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->StateName), StateName);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMStateInstance_Base.__GetPreviousStateByName_NativeFunctionPtr, (void*)ptr);
			USMStateInstance_Base orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USMStateInstance_Base>(ptr->__Result);
			UnrealReflectionUtils.DestroyStruct(USMStateInstance_Base.__GetPreviousStateByName_NativeFunctionPtr, (void*)ptr, 1);
			return orCreateUObjectByNativePointer;
		}

		// Token: 0x0600B741 RID: 46913 RVA: 0x0012522C File Offset: 0x0012342C
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe USMTransitionInstance GetPreviousActiveTransition()
		{
			USMStateInstance_Base.__GetPreviousActiveTransition_FunctionParams* ptr = stackalloc USMStateInstance_Base.__GetPreviousActiveTransition_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(USMStateInstance_Base.__GetPreviousActiveTransition_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMStateInstance_Base.__GetPreviousActiveTransition_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMStateInstance_Base.__GetPreviousActiveTransition_NativeFunctionPtr, (void*)ptr);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<USMTransitionInstance>(ptr->__Result);
		}

		// Token: 0x0600B742 RID: 46914 RVA: 0x00125278 File Offset: 0x00123478
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe USMStateInstance_Base GetPreviousActiveState()
		{
			USMStateInstance_Base.__GetPreviousActiveState_FunctionParams* ptr = stackalloc USMStateInstance_Base.__GetPreviousActiveState_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(USMStateInstance_Base.__GetPreviousActiveState_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMStateInstance_Base.__GetPreviousActiveState_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMStateInstance_Base.__GetPreviousActiveState_NativeFunctionPtr, (void*)ptr);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<USMStateInstance_Base>(ptr->__Result);
		}

		// Token: 0x0600B743 RID: 46915 RVA: 0x001252C4 File Offset: 0x001234C4
		[SkipLocalsInit]
		public unsafe bool GetOutgoingTransitions([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<USMTransitionInstance> Transitions, bool bExcludeAlwaysFalse = true)
		{
			USMStateInstance_Base.__GetOutgoingTransitions_FunctionParams* ptr = stackalloc USMStateInstance_Base.__GetOutgoingTransitions_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(USMStateInstance_Base.__GetOutgoingTransitions_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMStateInstance_Base.__GetOutgoingTransitions_NativeFunctionPtr, (void*)ptr, 1);
			TArray<USMTransitionInstance> tarray = Transitions;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->Transitions);
			}
			ptr->bExcludeAlwaysFalse = bExcludeAlwaysFalse;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMStateInstance_Base.__GetOutgoingTransitions_NativeFunctionPtr, (void*)ptr);
			TArray<USMTransitionInstance> tarray2 = Transitions;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->Transitions);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(USMStateInstance_Base.__GetOutgoingTransitions_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0600B744 RID: 46916 RVA: 0x0012534C File Offset: 0x0012354C
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe USMStateInstance_Base GetNextStateByTransitionIndex(int Index)
		{
			USMStateInstance_Base.__GetNextStateByTransitionIndex_FunctionParams* ptr = stackalloc USMStateInstance_Base.__GetNextStateByTransitionIndex_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(USMStateInstance_Base.__GetNextStateByTransitionIndex_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMStateInstance_Base.__GetNextStateByTransitionIndex_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Index = Index;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMStateInstance_Base.__GetNextStateByTransitionIndex_NativeFunctionPtr, (void*)ptr);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<USMStateInstance_Base>(ptr->__Result);
		}

		// Token: 0x0600B745 RID: 46917 RVA: 0x001253A0 File Offset: 0x001235A0
		[NullableContext(1)]
		[SkipLocalsInit]
		[return: Nullable(2)]
		public unsafe USMStateInstance_Base GetNextStateByName(string StateName)
		{
			USMStateInstance_Base.__GetNextStateByName_FunctionParams* ptr = stackalloc USMStateInstance_Base.__GetNextStateByName_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(USMStateInstance_Base.__GetNextStateByName_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMStateInstance_Base.__GetNextStateByName_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->StateName), StateName);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMStateInstance_Base.__GetNextStateByName_NativeFunctionPtr, (void*)ptr);
			USMStateInstance_Base orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USMStateInstance_Base>(ptr->__Result);
			UnrealReflectionUtils.DestroyStruct(USMStateInstance_Base.__GetNextStateByName_NativeFunctionPtr, (void*)ptr, 1);
			return orCreateUObjectByNativePointer;
		}

		// Token: 0x0600B746 RID: 46918 RVA: 0x00125408 File Offset: 0x00123608
		[SkipLocalsInit]
		public unsafe bool GetIncomingTransitions([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<USMTransitionInstance> Transitions, bool bExcludeAlwaysFalse = true)
		{
			USMStateInstance_Base.__GetIncomingTransitions_FunctionParams* ptr = stackalloc USMStateInstance_Base.__GetIncomingTransitions_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(USMStateInstance_Base.__GetIncomingTransitions_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMStateInstance_Base.__GetIncomingTransitions_NativeFunctionPtr, (void*)ptr, 1);
			TArray<USMTransitionInstance> tarray = Transitions;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->Transitions);
			}
			ptr->bExcludeAlwaysFalse = bExcludeAlwaysFalse;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMStateInstance_Base.__GetIncomingTransitions_NativeFunctionPtr, (void*)ptr);
			TArray<USMTransitionInstance> tarray2 = Transitions;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->Transitions);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(USMStateInstance_Base.__GetIncomingTransitions_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0600B747 RID: 46919 RVA: 0x00125490 File Offset: 0x00123690
		[SkipLocalsInit]
		public unsafe bool GetExcludeFromAnyState()
		{
			USMStateInstance_Base.__GetExcludeFromAnyState_FunctionParams* ptr = stackalloc USMStateInstance_Base.__GetExcludeFromAnyState_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(USMStateInstance_Base.__GetExcludeFromAnyState_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMStateInstance_Base.__GetExcludeFromAnyState_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMStateInstance_Base.__GetExcludeFromAnyState_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0600B748 RID: 46920 RVA: 0x001254D8 File Offset: 0x001236D8
		[SkipLocalsInit]
		public unsafe bool GetEvalTransitionsOnStart()
		{
			USMStateInstance_Base.__GetEvalTransitionsOnStart_FunctionParams* ptr = stackalloc USMStateInstance_Base.__GetEvalTransitionsOnStart_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(USMStateInstance_Base.__GetEvalTransitionsOnStart_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMStateInstance_Base.__GetEvalTransitionsOnStart_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMStateInstance_Base.__GetEvalTransitionsOnStart_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0600B749 RID: 46921 RVA: 0x00125520 File Offset: 0x00123720
		[SkipLocalsInit]
		public unsafe bool GetDisableTickTransitionEvaluation()
		{
			USMStateInstance_Base.__GetDisableTickTransitionEvaluation_FunctionParams* ptr = stackalloc USMStateInstance_Base.__GetDisableTickTransitionEvaluation_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(USMStateInstance_Base.__GetDisableTickTransitionEvaluation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMStateInstance_Base.__GetDisableTickTransitionEvaluation_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMStateInstance_Base.__GetDisableTickTransitionEvaluation_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0600B74A RID: 46922 RVA: 0x00125568 File Offset: 0x00123768
		[SkipLocalsInit]
		public unsafe bool GetAlwaysUpdate()
		{
			USMStateInstance_Base.__GetAlwaysUpdate_FunctionParams* ptr = stackalloc USMStateInstance_Base.__GetAlwaysUpdate_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(USMStateInstance_Base.__GetAlwaysUpdate_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMStateInstance_Base.__GetAlwaysUpdate_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMStateInstance_Base.__GetAlwaysUpdate_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0600B74B RID: 46923 RVA: 0x001255AD File Offset: 0x001237AD
		[SkipLocalsInit]
		public void EvaluateTransitions()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMStateInstance_Base.__EvaluateTransitions_NativeFunctionPtr, null);
		}

		// Token: 0x0600B74C RID: 46924 RVA: 0x001255C4 File Offset: 0x001237C4
		[SkipLocalsInit]
		public unsafe bool AreAllOutgoingTransitionsFromAnAnyState()
		{
			USMStateInstance_Base.__AreAllOutgoingTransitionsFromAnAnyState_FunctionParams* ptr = stackalloc USMStateInstance_Base.__AreAllOutgoingTransitionsFromAnAnyState_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(USMStateInstance_Base.__AreAllOutgoingTransitionsFromAnAnyState_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMStateInstance_Base.__AreAllOutgoingTransitionsFromAnAnyState_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMStateInstance_Base.__AreAllOutgoingTransitionsFromAnAnyState_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0600B74D RID: 46925 RVA: 0x0012560C File Offset: 0x0012380C
		[SkipLocalsInit]
		public unsafe bool AreAllIncomingTransitionsFromAnAnyState()
		{
			USMStateInstance_Base.__AreAllIncomingTransitionsFromAnAnyState_FunctionParams* ptr = stackalloc USMStateInstance_Base.__AreAllIncomingTransitionsFromAnAnyState_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(USMStateInstance_Base.__AreAllIncomingTransitionsFromAnAnyState_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMStateInstance_Base.__AreAllIncomingTransitionsFromAnAnyState_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMStateInstance_Base.__AreAllIncomingTransitionsFromAnAnyState_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0600B74E RID: 46926 RVA: 0x00125651 File Offset: 0x00123851
		static USMStateInstance_Base()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SMSystem.SMStateInstance_Base");
		}

		// Token: 0x0600B74F RID: 46927 RVA: 0x00125660 File Offset: 0x00123860
		protected USMStateInstance_Base() : this(BuiltinUtils.AllocNativeUObject(USMStateInstance_Base.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600B750 RID: 46928 RVA: 0x00125688 File Offset: 0x00123888
		protected USMStateInstance_Base(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04005309 RID: 21257
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/SMSystem.SMStateInstance_Base";

		// Token: 0x0400530A RID: 21258
		private static IntPtr _ClassPtr;

		// Token: 0x0400530B RID: 21259
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400530C RID: 21260
		internal static int __PropertyOffset_OnStateBeginEvent;

		// Token: 0x0400530D RID: 21261
		[Nullable(2)]
		private FOnStateBeginSignature _OnStateBeginEvent;

		// Token: 0x0400530E RID: 21262
		internal static int __PropertyOffset_OnPostStateBeginEvent;

		// Token: 0x0400530F RID: 21263
		[Nullable(2)]
		private FOnStateBeginSignature _OnPostStateBeginEvent;

		// Token: 0x04005310 RID: 21264
		internal static int __PropertyOffset_OnStateUpdateEvent;

		// Token: 0x04005311 RID: 21265
		[Nullable(2)]
		private FOnStateUpdateSignature _OnStateUpdateEvent;

		// Token: 0x04005312 RID: 21266
		internal static int __PropertyOffset_OnStateEndEvent;

		// Token: 0x04005313 RID: 21267
		[Nullable(2)]
		private FOnStateEndSignature _OnStateEndEvent;

		// Token: 0x04005314 RID: 21268
		internal static int __PropertyOffset_TakeControlType;

		// Token: 0x04005315 RID: 21269
		internal static int __PropertyOffset_TransitionRule;

		// Token: 0x04005316 RID: 21270
		internal static int __PropertyOffset_Task;

		// Token: 0x04005317 RID: 21271
		internal static int __PropertyOffset_BindStates;

		// Token: 0x04005318 RID: 21272
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UASMBindState> _BindStates;

		// Token: 0x04005319 RID: 21273
		internal static int __PropertyOffset_OnEnterActions;

		// Token: 0x0400531A RID: 21274
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UASMAction> _OnEnterActions;

		// Token: 0x0400531B RID: 21275
		internal static int __PropertyOffset_OnExitActions;

		// Token: 0x0400531C RID: 21276
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UASMAction> _OnExitActions;

		// Token: 0x0400531D RID: 21277
		internal static int __PropertyOffset_NodeName;

		// Token: 0x0400531E RID: 21278
		internal static int __PropertyOffset_IsRefNode;

		// Token: 0x0400531F RID: 21279
		internal static int __PropertyOffset_IsOvrNode;

		// Token: 0x04005320 RID: 21280
		internal static int __PropertyOffset_IsAnimNode;

		// Token: 0x04005321 RID: 21281
		internal static int __PropertyOffset_IsConduitNode;

		// Token: 0x04005322 RID: 21282
		internal static int __PropertyOffset_IsAnyStateNode;

		// Token: 0x04005323 RID: 21283
		private static IntPtr __SwitchToLinkedStateByTransition_NativeFunctionPtr;

		// Token: 0x04005324 RID: 21284
		private static IntPtr __SwitchToLinkedStateByName_NativeFunctionPtr;

		// Token: 0x04005325 RID: 21285
		private static IntPtr __SwitchToLinkedState_NativeFunctionPtr;

		// Token: 0x04005326 RID: 21286
		private static IntPtr __SetExcludeFromAnyState_NativeFunctionPtr;

		// Token: 0x04005327 RID: 21287
		private static IntPtr __SetEvalTransitionsOnStart_NativeFunctionPtr;

		// Token: 0x04005328 RID: 21288
		private static IntPtr __SetDisableTickTransitionEvaluation_NativeFunctionPtr;

		// Token: 0x04005329 RID: 21289
		private static IntPtr __SetAlwaysUpdate_NativeFunctionPtr;

		// Token: 0x0400532A RID: 21290
		private static IntPtr __SetActive_NativeFunctionPtr;

		// Token: 0x0400532B RID: 21291
		private static IntPtr __IsStateMachine_NativeFunctionPtr;

		// Token: 0x0400532C RID: 21292
		private static IntPtr __IsEntryState_NativeFunctionPtr;

		// Token: 0x0400532D RID: 21293
		private static IntPtr __GetTransitionToTake_NativeFunctionPtr;

		// Token: 0x0400532E RID: 21294
		private static IntPtr __GetTransitionByIndex_NativeFunctionPtr;

		// Token: 0x0400532F RID: 21295
		private static IntPtr __GetStartTime_NativeFunctionPtr;

		// Token: 0x04005330 RID: 21296
		private static IntPtr __GetServerTimeInState_NativeFunctionPtr;

		// Token: 0x04005331 RID: 21297
		private static IntPtr __GetPreviousStateByName_NativeFunctionPtr;

		// Token: 0x04005332 RID: 21298
		private static IntPtr __GetPreviousActiveTransition_NativeFunctionPtr;

		// Token: 0x04005333 RID: 21299
		private static IntPtr __GetPreviousActiveState_NativeFunctionPtr;

		// Token: 0x04005334 RID: 21300
		private static IntPtr __GetOutgoingTransitions_NativeFunctionPtr;

		// Token: 0x04005335 RID: 21301
		private static IntPtr __GetNextStateByTransitionIndex_NativeFunctionPtr;

		// Token: 0x04005336 RID: 21302
		private static IntPtr __GetNextStateByName_NativeFunctionPtr;

		// Token: 0x04005337 RID: 21303
		private static IntPtr __GetIncomingTransitions_NativeFunctionPtr;

		// Token: 0x04005338 RID: 21304
		private static IntPtr __GetExcludeFromAnyState_NativeFunctionPtr;

		// Token: 0x04005339 RID: 21305
		private static IntPtr __GetEvalTransitionsOnStart_NativeFunctionPtr;

		// Token: 0x0400533A RID: 21306
		private static IntPtr __GetDisableTickTransitionEvaluation_NativeFunctionPtr;

		// Token: 0x0400533B RID: 21307
		private static IntPtr __GetAlwaysUpdate_NativeFunctionPtr;

		// Token: 0x0400533C RID: 21308
		private static IntPtr __EvaluateTransitions_NativeFunctionPtr;

		// Token: 0x0400533D RID: 21309
		private static IntPtr __AreAllOutgoingTransitionsFromAnAnyState_NativeFunctionPtr;

		// Token: 0x0400533E RID: 21310
		private static IntPtr __AreAllIncomingTransitionsFromAnAnyState_NativeFunctionPtr;

		// Token: 0x02001395 RID: 5013
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SwitchToLinkedStateByTransition_FunctionParams
		{
			// Token: 0x040067EB RID: 26603
			[FieldOffset(0)]
			public IntPtr TransitionInstance;

			// Token: 0x040067EC RID: 26604
			[FieldOffset(8)]
			public bool bRequireTransitionToPass;

			// Token: 0x040067ED RID: 26605
			[FieldOffset(9)]
			public bool bActivateNow;

			// Token: 0x040067EE RID: 26606
			[FieldOffset(10)]
			public bool __Result;
		}

		// Token: 0x02001396 RID: 5014
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __SwitchToLinkedStateByName_FunctionParams
		{
			// Token: 0x040067EF RID: 26607
			[FieldOffset(0)]
			public FString NextStateName;

			// Token: 0x040067F0 RID: 26608
			[FieldOffset(16)]
			public bool bRequireTransitionToPass;

			// Token: 0x040067F1 RID: 26609
			[FieldOffset(17)]
			public bool bActivateNow;

			// Token: 0x040067F2 RID: 26610
			[FieldOffset(18)]
			public bool __Result;
		}

		// Token: 0x02001397 RID: 5015
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SwitchToLinkedState_FunctionParams
		{
			// Token: 0x040067F3 RID: 26611
			[FieldOffset(0)]
			public IntPtr NextStateInstance;

			// Token: 0x040067F4 RID: 26612
			[FieldOffset(8)]
			public bool bRequireTransitionToPass;

			// Token: 0x040067F5 RID: 26613
			[FieldOffset(9)]
			public bool bActivateNow;

			// Token: 0x040067F6 RID: 26614
			[FieldOffset(10)]
			public bool __Result;
		}

		// Token: 0x02001398 RID: 5016
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetExcludeFromAnyState_FunctionParams
		{
			// Token: 0x040067F7 RID: 26615
			[FieldOffset(0)]
			public bool bValue;
		}

		// Token: 0x02001399 RID: 5017
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetEvalTransitionsOnStart_FunctionParams
		{
			// Token: 0x040067F8 RID: 26616
			[FieldOffset(0)]
			public bool bValue;
		}

		// Token: 0x0200139A RID: 5018
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetDisableTickTransitionEvaluation_FunctionParams
		{
			// Token: 0x040067F9 RID: 26617
			[FieldOffset(0)]
			public bool bValue;
		}

		// Token: 0x0200139B RID: 5019
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetAlwaysUpdate_FunctionParams
		{
			// Token: 0x040067FA RID: 26618
			[FieldOffset(0)]
			public bool bValue;
		}

		// Token: 0x0200139C RID: 5020
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 3)]
		protected ref struct __SetActive_FunctionParams
		{
			// Token: 0x040067FB RID: 26619
			[FieldOffset(0)]
			public bool bValue;

			// Token: 0x040067FC RID: 26620
			[FieldOffset(1)]
			public bool bSetAllParents;

			// Token: 0x040067FD RID: 26621
			[FieldOffset(2)]
			public bool bActivateNow;
		}

		// Token: 0x0200139D RID: 5021
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsStateMachine_FunctionParams
		{
			// Token: 0x040067FE RID: 26622
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x0200139E RID: 5022
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsEntryState_FunctionParams
		{
			// Token: 0x040067FF RID: 26623
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x0200139F RID: 5023
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetTransitionToTake_FunctionParams
		{
			// Token: 0x04006800 RID: 26624
			[FieldOffset(0)]
			public IntPtr __Result;
		}

		// Token: 0x020013A0 RID: 5024
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetTransitionByIndex_FunctionParams
		{
			// Token: 0x04006801 RID: 26625
			[FieldOffset(0)]
			public int Index;

			// Token: 0x04006802 RID: 26626
			[FieldOffset(8)]
			public IntPtr __Result;
		}

		// Token: 0x020013A1 RID: 5025
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetStartTime_FunctionParams
		{
			// Token: 0x04006803 RID: 26627
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x020013A2 RID: 5026
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetServerTimeInState_FunctionParams
		{
			// Token: 0x04006804 RID: 26628
			[FieldOffset(0)]
			public bool bOutUsedLocalTime;

			// Token: 0x04006805 RID: 26629
			[FieldOffset(4)]
			public float __Result;
		}

		// Token: 0x020013A3 RID: 5027
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __GetPreviousStateByName_FunctionParams
		{
			// Token: 0x04006806 RID: 26630
			[FieldOffset(0)]
			public FString StateName;

			// Token: 0x04006807 RID: 26631
			[FieldOffset(16)]
			public IntPtr __Result;
		}

		// Token: 0x020013A4 RID: 5028
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetPreviousActiveTransition_FunctionParams
		{
			// Token: 0x04006808 RID: 26632
			[FieldOffset(0)]
			public IntPtr __Result;
		}

		// Token: 0x020013A5 RID: 5029
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetPreviousActiveState_FunctionParams
		{
			// Token: 0x04006809 RID: 26633
			[FieldOffset(0)]
			public IntPtr __Result;
		}

		// Token: 0x020013A6 RID: 5030
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __GetOutgoingTransitions_FunctionParams
		{
			// Token: 0x0400680A RID: 26634
			[FieldOffset(0)]
			public byte Transitions;

			// Token: 0x0400680B RID: 26635
			[FieldOffset(16)]
			public bool bExcludeAlwaysFalse;

			// Token: 0x0400680C RID: 26636
			[FieldOffset(17)]
			public bool __Result;
		}

		// Token: 0x020013A7 RID: 5031
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetNextStateByTransitionIndex_FunctionParams
		{
			// Token: 0x0400680D RID: 26637
			[FieldOffset(0)]
			public int Index;

			// Token: 0x0400680E RID: 26638
			[FieldOffset(8)]
			public IntPtr __Result;
		}

		// Token: 0x020013A8 RID: 5032
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __GetNextStateByName_FunctionParams
		{
			// Token: 0x0400680F RID: 26639
			[FieldOffset(0)]
			public FString StateName;

			// Token: 0x04006810 RID: 26640
			[FieldOffset(16)]
			public IntPtr __Result;
		}

		// Token: 0x020013A9 RID: 5033
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __GetIncomingTransitions_FunctionParams
		{
			// Token: 0x04006811 RID: 26641
			[FieldOffset(0)]
			public byte Transitions;

			// Token: 0x04006812 RID: 26642
			[FieldOffset(16)]
			public bool bExcludeAlwaysFalse;

			// Token: 0x04006813 RID: 26643
			[FieldOffset(17)]
			public bool __Result;
		}

		// Token: 0x020013AA RID: 5034
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __GetExcludeFromAnyState_FunctionParams
		{
			// Token: 0x04006814 RID: 26644
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x020013AB RID: 5035
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __GetEvalTransitionsOnStart_FunctionParams
		{
			// Token: 0x04006815 RID: 26645
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x020013AC RID: 5036
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __GetDisableTickTransitionEvaluation_FunctionParams
		{
			// Token: 0x04006816 RID: 26646
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x020013AD RID: 5037
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __GetAlwaysUpdate_FunctionParams
		{
			// Token: 0x04006817 RID: 26647
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x020013AE RID: 5038
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __AreAllOutgoingTransitionsFromAnAnyState_FunctionParams
		{
			// Token: 0x04006818 RID: 26648
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x020013AF RID: 5039
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __AreAllIncomingTransitionsFromAnAnyState_FunctionParams
		{
			// Token: 0x04006819 RID: 26649
			[FieldOffset(0)]
			public bool __Result;
		}
	}
}
