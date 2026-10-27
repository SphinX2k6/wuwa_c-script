using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002895 RID: 10389
	[UnrealObjectPath("/Script/SMSystem.SMStateInstance_Base")]
	[UnrealStructLayout(256, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 256)]
	public abstract class USMStateInstance_Base : USMNodeInstance, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060267B5 RID: 157621 RVA: 0x003A9762 File Offset: 0x003A7962
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USMStateInstance_Base._ClassPtr;
		}

		// Token: 0x17009457 RID: 37975
		// (get) Token: 0x060267B6 RID: 157622 RVA: 0x003A9770 File Offset: 0x003A7970
		// (set) Token: 0x060267B7 RID: 157623 RVA: 0x003A97A9 File Offset: 0x003A79A9
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

		// Token: 0x17009458 RID: 37976
		// (get) Token: 0x060267B8 RID: 157624 RVA: 0x003A97CC File Offset: 0x003A79CC
		// (set) Token: 0x060267B9 RID: 157625 RVA: 0x003A9805 File Offset: 0x003A7A05
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

		// Token: 0x17009459 RID: 37977
		// (get) Token: 0x060267BA RID: 157626 RVA: 0x003A9828 File Offset: 0x003A7A28
		// (set) Token: 0x060267BB RID: 157627 RVA: 0x003A9861 File Offset: 0x003A7A61
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

		// Token: 0x1700945A RID: 37978
		// (get) Token: 0x060267BC RID: 157628 RVA: 0x003A9884 File Offset: 0x003A7A84
		// (set) Token: 0x060267BD RID: 157629 RVA: 0x003A98BD File Offset: 0x003A7ABD
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

		// Token: 0x1700945B RID: 37979
		// (get) Token: 0x060267BE RID: 157630 RVA: 0x003A98DE File Offset: 0x003A7ADE
		// (set) Token: 0x060267BF RID: 157631 RVA: 0x003A98F2 File Offset: 0x003A7AF2
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

		// Token: 0x1700945C RID: 37980
		// (get) Token: 0x060267C0 RID: 157632 RVA: 0x003A9907 File Offset: 0x003A7B07
		// (set) Token: 0x060267C1 RID: 157633 RVA: 0x003A991B File Offset: 0x003A7B1B
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

		// Token: 0x1700945D RID: 37981
		// (get) Token: 0x060267C2 RID: 157634 RVA: 0x003A9930 File Offset: 0x003A7B30
		// (set) Token: 0x060267C3 RID: 157635 RVA: 0x003A9944 File Offset: 0x003A7B44
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

		// Token: 0x1700945E RID: 37982
		// (get) Token: 0x060267C4 RID: 157636 RVA: 0x003A995C File Offset: 0x003A7B5C
		// (set) Token: 0x060267C5 RID: 157637 RVA: 0x003A9995 File Offset: 0x003A7B95
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

		// Token: 0x1700945F RID: 37983
		// (get) Token: 0x060267C6 RID: 157638 RVA: 0x003A99A4 File Offset: 0x003A7BA4
		// (set) Token: 0x060267C7 RID: 157639 RVA: 0x003A99DD File Offset: 0x003A7BDD
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

		// Token: 0x17009460 RID: 37984
		// (get) Token: 0x060267C8 RID: 157640 RVA: 0x003A99EC File Offset: 0x003A7BEC
		// (set) Token: 0x060267C9 RID: 157641 RVA: 0x003A9A25 File Offset: 0x003A7C25
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

		// Token: 0x17009461 RID: 37985
		// (get) Token: 0x060267CA RID: 157642 RVA: 0x003A9A33 File Offset: 0x003A7C33
		// (set) Token: 0x060267CB RID: 157643 RVA: 0x003A9A47 File Offset: 0x003A7C47
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

		// Token: 0x17009462 RID: 37986
		// (get) Token: 0x060267CC RID: 157644 RVA: 0x003A9A5C File Offset: 0x003A7C5C
		// (set) Token: 0x060267CD RID: 157645 RVA: 0x003A9A6C File Offset: 0x003A7C6C
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

		// Token: 0x17009463 RID: 37987
		// (get) Token: 0x060267CE RID: 157646 RVA: 0x003A9A7D File Offset: 0x003A7C7D
		// (set) Token: 0x060267CF RID: 157647 RVA: 0x003A9A8D File Offset: 0x003A7C8D
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

		// Token: 0x17009464 RID: 37988
		// (get) Token: 0x060267D0 RID: 157648 RVA: 0x003A9A9E File Offset: 0x003A7C9E
		// (set) Token: 0x060267D1 RID: 157649 RVA: 0x003A9AAE File Offset: 0x003A7CAE
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

		// Token: 0x17009465 RID: 37989
		// (get) Token: 0x060267D2 RID: 157650 RVA: 0x003A9ABF File Offset: 0x003A7CBF
		// (set) Token: 0x060267D3 RID: 157651 RVA: 0x003A9ACF File Offset: 0x003A7CCF
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

		// Token: 0x17009466 RID: 37990
		// (get) Token: 0x060267D4 RID: 157652 RVA: 0x003A9AE0 File Offset: 0x003A7CE0
		// (set) Token: 0x060267D5 RID: 157653 RVA: 0x003A9AF0 File Offset: 0x003A7CF0
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

		// Token: 0x060267D6 RID: 157654 RVA: 0x003A9B04 File Offset: 0x003A7D04
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool SwitchToLinkedStateByTransition(USMTransitionInstance TransitionInstance, bool bRequireTransitionToPass = true, bool bActivateNow = true)
		{
			USMStateInstance_Base.__SwitchToLinkedStateByTransition_FunctionParams* ptr = stackalloc USMStateInstance_Base.__SwitchToLinkedStateByTransition_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(USMStateInstance_Base.__SwitchToLinkedStateByTransition_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMStateInstance_Base.__SwitchToLinkedStateByTransition_NativeFunctionPtr, (void*)ptr, 1);
			ptr->TransitionInstance = ((TransitionInstance != null) ? TransitionInstance.NativePtr : IntPtr.Zero);
			ptr->bRequireTransitionToPass = bRequireTransitionToPass;
			ptr->bActivateNow = bActivateNow;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMStateInstance_Base.__SwitchToLinkedStateByTransition_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x060267D7 RID: 157655 RVA: 0x003A9B70 File Offset: 0x003A7D70
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool SwitchToLinkedStateByName(string NextStateName, bool bRequireTransitionToPass = true, bool bActivateNow = true)
		{
			USMStateInstance_Base.__SwitchToLinkedStateByName_FunctionParams* ptr = stackalloc USMStateInstance_Base.__SwitchToLinkedStateByName_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(USMStateInstance_Base.__SwitchToLinkedStateByName_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMStateInstance_Base.__SwitchToLinkedStateByName_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->NextStateName), NextStateName);
			ptr->bRequireTransitionToPass = bRequireTransitionToPass;
			ptr->bActivateNow = bActivateNow;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMStateInstance_Base.__SwitchToLinkedStateByName_NativeFunctionPtr, (void*)ptr, 0);
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(USMStateInstance_Base.__SwitchToLinkedStateByName_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x060267D8 RID: 157656 RVA: 0x003A9BE4 File Offset: 0x003A7DE4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool SwitchToLinkedState(USMStateInstance_Base NextStateInstance, bool bRequireTransitionToPass = true, bool bActivateNow = true)
		{
			USMStateInstance_Base.__SwitchToLinkedState_FunctionParams* ptr = stackalloc USMStateInstance_Base.__SwitchToLinkedState_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(USMStateInstance_Base.__SwitchToLinkedState_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMStateInstance_Base.__SwitchToLinkedState_NativeFunctionPtr, (void*)ptr, 1);
			ptr->NextStateInstance = ((NextStateInstance != null) ? NextStateInstance.NativePtr : IntPtr.Zero);
			ptr->bRequireTransitionToPass = bRequireTransitionToPass;
			ptr->bActivateNow = bActivateNow;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMStateInstance_Base.__SwitchToLinkedState_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x060267D9 RID: 157657 RVA: 0x003A9C50 File Offset: 0x003A7E50
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetExcludeFromAnyState(bool bValue)
		{
			USMStateInstance_Base.__SetExcludeFromAnyState_FunctionParams* ptr = stackalloc USMStateInstance_Base.__SetExcludeFromAnyState_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(USMStateInstance_Base.__SetExcludeFromAnyState_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMStateInstance_Base.__SetExcludeFromAnyState_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bValue = bValue;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMStateInstance_Base.__SetExcludeFromAnyState_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060267DA RID: 157658 RVA: 0x003A9C98 File Offset: 0x003A7E98
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetEvalTransitionsOnStart(bool bValue)
		{
			USMStateInstance_Base.__SetEvalTransitionsOnStart_FunctionParams* ptr = stackalloc USMStateInstance_Base.__SetEvalTransitionsOnStart_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(USMStateInstance_Base.__SetEvalTransitionsOnStart_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMStateInstance_Base.__SetEvalTransitionsOnStart_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bValue = bValue;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMStateInstance_Base.__SetEvalTransitionsOnStart_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060267DB RID: 157659 RVA: 0x003A9CE0 File Offset: 0x003A7EE0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetDisableTickTransitionEvaluation(bool bValue)
		{
			USMStateInstance_Base.__SetDisableTickTransitionEvaluation_FunctionParams* ptr = stackalloc USMStateInstance_Base.__SetDisableTickTransitionEvaluation_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(USMStateInstance_Base.__SetDisableTickTransitionEvaluation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMStateInstance_Base.__SetDisableTickTransitionEvaluation_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bValue = bValue;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMStateInstance_Base.__SetDisableTickTransitionEvaluation_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060267DC RID: 157660 RVA: 0x003A9D28 File Offset: 0x003A7F28
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetAlwaysUpdate(bool bValue)
		{
			USMStateInstance_Base.__SetAlwaysUpdate_FunctionParams* ptr = stackalloc USMStateInstance_Base.__SetAlwaysUpdate_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(USMStateInstance_Base.__SetAlwaysUpdate_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMStateInstance_Base.__SetAlwaysUpdate_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bValue = bValue;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMStateInstance_Base.__SetAlwaysUpdate_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060267DD RID: 157661 RVA: 0x003A9D70 File Offset: 0x003A7F70
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetActive(bool bValue, bool bSetAllParents = false, bool bActivateNow = true)
		{
			USMStateInstance_Base.__SetActive_FunctionParams* ptr = stackalloc USMStateInstance_Base.__SetActive_FunctionParams[(UIntPtr)18] + 15L / (long)sizeof(USMStateInstance_Base.__SetActive_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMStateInstance_Base.__SetActive_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bValue = bValue;
			ptr->bSetAllParents = bSetAllParents;
			ptr->bActivateNow = bActivateNow;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMStateInstance_Base.__SetActive_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060267DE RID: 157662 RVA: 0x003A9DC8 File Offset: 0x003A7FC8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool IsStateMachine()
		{
			USMStateInstance_Base.__IsStateMachine_FunctionParams* ptr = stackalloc USMStateInstance_Base.__IsStateMachine_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(USMStateInstance_Base.__IsStateMachine_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMStateInstance_Base.__IsStateMachine_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMStateInstance_Base.__IsStateMachine_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x060267DF RID: 157663 RVA: 0x003A9E10 File Offset: 0x003A8010
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool IsEntryState()
		{
			USMStateInstance_Base.__IsEntryState_FunctionParams* ptr = stackalloc USMStateInstance_Base.__IsEntryState_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(USMStateInstance_Base.__IsEntryState_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMStateInstance_Base.__IsEntryState_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMStateInstance_Base.__IsEntryState_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x060267E0 RID: 157664 RVA: 0x003A9E58 File Offset: 0x003A8058
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe USMTransitionInstance GetTransitionToTake()
		{
			USMStateInstance_Base.__GetTransitionToTake_FunctionParams* ptr = stackalloc USMStateInstance_Base.__GetTransitionToTake_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(USMStateInstance_Base.__GetTransitionToTake_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMStateInstance_Base.__GetTransitionToTake_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMStateInstance_Base.__GetTransitionToTake_NativeFunctionPtr, (void*)ptr, 0);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<USMTransitionInstance>(ptr->__Result);
		}

		// Token: 0x060267E1 RID: 157665 RVA: 0x003A9EA4 File Offset: 0x003A80A4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe USMTransitionInstance GetTransitionByIndex(int Index)
		{
			USMStateInstance_Base.__GetTransitionByIndex_FunctionParams* ptr = stackalloc USMStateInstance_Base.__GetTransitionByIndex_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(USMStateInstance_Base.__GetTransitionByIndex_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMStateInstance_Base.__GetTransitionByIndex_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Index = Index;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMStateInstance_Base.__GetTransitionByIndex_NativeFunctionPtr, (void*)ptr, 0);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<USMTransitionInstance>(ptr->__Result);
		}

		// Token: 0x060267E2 RID: 157666 RVA: 0x003A9EF8 File Offset: 0x003A80F8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void GetStateInfo(ref FSMStateInfo State)
		{
			USMStateInstance_Base.__GetStateInfo_FunctionParams* ptr = stackalloc USMStateInstance_Base.__GetStateInfo_FunctionParams[(UIntPtr)143] + 15L / (long)sizeof(USMStateInstance_Base.__GetStateInfo_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMStateInstance_Base.__GetStateInfo_NativeFunctionPtr, (void*)ptr, 1);
			if (State != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FSMStateInfo.StaticStruct(), &ptr->State, State.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMStateInstance_Base.__GetStateInfo_NativeFunctionPtr, (void*)ptr, 0);
			if (State != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FSMStateInfo.StaticStruct(), State.NativePtr, &ptr->State, 1, false);
			}
			UnrealReflectionUtils.DestroyStruct(USMStateInstance_Base.__GetStateInfo_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060267E3 RID: 157667 RVA: 0x003A9F94 File Offset: 0x003A8194
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe FDateTime GetStartTime()
		{
			USMStateInstance_Base.__GetStartTime_FunctionParams* ptr = stackalloc USMStateInstance_Base.__GetStartTime_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(USMStateInstance_Base.__GetStartTime_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMStateInstance_Base.__GetStartTime_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMStateInstance_Base.__GetStartTime_NativeFunctionPtr, (void*)ptr, 0);
			return new FDateTime(&ptr->__Result, true, true);
		}

		// Token: 0x060267E4 RID: 157668 RVA: 0x003A9FE4 File Offset: 0x003A81E4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe float GetServerTimeInState(ref bool bOutUsedLocalTime)
		{
			USMStateInstance_Base.__GetServerTimeInState_FunctionParams* ptr = stackalloc USMStateInstance_Base.__GetServerTimeInState_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(USMStateInstance_Base.__GetServerTimeInState_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMStateInstance_Base.__GetServerTimeInState_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bOutUsedLocalTime = bOutUsedLocalTime;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMStateInstance_Base.__GetServerTimeInState_NativeFunctionPtr, (void*)ptr, 0);
			bOutUsedLocalTime = ptr->bOutUsedLocalTime;
			return ptr->__Result;
		}

		// Token: 0x060267E5 RID: 157669 RVA: 0x003AA03C File Offset: 0x003A823C
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		[return: Nullable(2)]
		public unsafe USMStateInstance_Base GetPreviousStateByName(string StateName)
		{
			USMStateInstance_Base.__GetPreviousStateByName_FunctionParams* ptr = stackalloc USMStateInstance_Base.__GetPreviousStateByName_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(USMStateInstance_Base.__GetPreviousStateByName_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMStateInstance_Base.__GetPreviousStateByName_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->StateName), StateName);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMStateInstance_Base.__GetPreviousStateByName_NativeFunctionPtr, (void*)ptr, 0);
			USMStateInstance_Base orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USMStateInstance_Base>(ptr->__Result);
			UnrealReflectionUtils.DestroyStruct(USMStateInstance_Base.__GetPreviousStateByName_NativeFunctionPtr, (void*)ptr, 1);
			return orCreateUObjectByNativePointer;
		}

		// Token: 0x060267E6 RID: 157670 RVA: 0x003AA0A8 File Offset: 0x003A82A8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe USMTransitionInstance GetPreviousActiveTransition()
		{
			USMStateInstance_Base.__GetPreviousActiveTransition_FunctionParams* ptr = stackalloc USMStateInstance_Base.__GetPreviousActiveTransition_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(USMStateInstance_Base.__GetPreviousActiveTransition_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMStateInstance_Base.__GetPreviousActiveTransition_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMStateInstance_Base.__GetPreviousActiveTransition_NativeFunctionPtr, (void*)ptr, 0);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<USMTransitionInstance>(ptr->__Result);
		}

		// Token: 0x060267E7 RID: 157671 RVA: 0x003AA0F4 File Offset: 0x003A82F4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe USMStateInstance_Base GetPreviousActiveState()
		{
			USMStateInstance_Base.__GetPreviousActiveState_FunctionParams* ptr = stackalloc USMStateInstance_Base.__GetPreviousActiveState_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(USMStateInstance_Base.__GetPreviousActiveState_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMStateInstance_Base.__GetPreviousActiveState_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMStateInstance_Base.__GetPreviousActiveState_NativeFunctionPtr, (void*)ptr, 0);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<USMStateInstance_Base>(ptr->__Result);
		}

		// Token: 0x060267E8 RID: 157672 RVA: 0x003AA140 File Offset: 0x003A8340
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMStateInstance_Base.__GetOutgoingTransitions_NativeFunctionPtr, (void*)ptr, 0);
			TArray<USMTransitionInstance> tarray2 = Transitions;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->Transitions);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(USMStateInstance_Base.__GetOutgoingTransitions_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x060267E9 RID: 157673 RVA: 0x003AA1C8 File Offset: 0x003A83C8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe USMStateInstance_Base GetNextStateByTransitionIndex(int Index)
		{
			USMStateInstance_Base.__GetNextStateByTransitionIndex_FunctionParams* ptr = stackalloc USMStateInstance_Base.__GetNextStateByTransitionIndex_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(USMStateInstance_Base.__GetNextStateByTransitionIndex_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMStateInstance_Base.__GetNextStateByTransitionIndex_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Index = Index;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMStateInstance_Base.__GetNextStateByTransitionIndex_NativeFunctionPtr, (void*)ptr, 0);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<USMStateInstance_Base>(ptr->__Result);
		}

		// Token: 0x060267EA RID: 157674 RVA: 0x003AA21C File Offset: 0x003A841C
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		[return: Nullable(2)]
		public unsafe USMStateInstance_Base GetNextStateByName(string StateName)
		{
			USMStateInstance_Base.__GetNextStateByName_FunctionParams* ptr = stackalloc USMStateInstance_Base.__GetNextStateByName_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(USMStateInstance_Base.__GetNextStateByName_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMStateInstance_Base.__GetNextStateByName_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->StateName), StateName);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMStateInstance_Base.__GetNextStateByName_NativeFunctionPtr, (void*)ptr, 0);
			USMStateInstance_Base orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USMStateInstance_Base>(ptr->__Result);
			UnrealReflectionUtils.DestroyStruct(USMStateInstance_Base.__GetNextStateByName_NativeFunctionPtr, (void*)ptr, 1);
			return orCreateUObjectByNativePointer;
		}

		// Token: 0x060267EB RID: 157675 RVA: 0x003AA288 File Offset: 0x003A8488
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMStateInstance_Base.__GetIncomingTransitions_NativeFunctionPtr, (void*)ptr, 0);
			TArray<USMTransitionInstance> tarray2 = Transitions;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->Transitions);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(USMStateInstance_Base.__GetIncomingTransitions_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x060267EC RID: 157676 RVA: 0x003AA310 File Offset: 0x003A8510
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool GetExcludeFromAnyState()
		{
			USMStateInstance_Base.__GetExcludeFromAnyState_FunctionParams* ptr = stackalloc USMStateInstance_Base.__GetExcludeFromAnyState_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(USMStateInstance_Base.__GetExcludeFromAnyState_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMStateInstance_Base.__GetExcludeFromAnyState_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMStateInstance_Base.__GetExcludeFromAnyState_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x060267ED RID: 157677 RVA: 0x003AA358 File Offset: 0x003A8558
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool GetEvalTransitionsOnStart()
		{
			USMStateInstance_Base.__GetEvalTransitionsOnStart_FunctionParams* ptr = stackalloc USMStateInstance_Base.__GetEvalTransitionsOnStart_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(USMStateInstance_Base.__GetEvalTransitionsOnStart_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMStateInstance_Base.__GetEvalTransitionsOnStart_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMStateInstance_Base.__GetEvalTransitionsOnStart_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x060267EE RID: 157678 RVA: 0x003AA3A0 File Offset: 0x003A85A0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool GetDisableTickTransitionEvaluation()
		{
			USMStateInstance_Base.__GetDisableTickTransitionEvaluation_FunctionParams* ptr = stackalloc USMStateInstance_Base.__GetDisableTickTransitionEvaluation_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(USMStateInstance_Base.__GetDisableTickTransitionEvaluation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMStateInstance_Base.__GetDisableTickTransitionEvaluation_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMStateInstance_Base.__GetDisableTickTransitionEvaluation_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x060267EF RID: 157679 RVA: 0x003AA3E8 File Offset: 0x003A85E8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool GetAlwaysUpdate()
		{
			USMStateInstance_Base.__GetAlwaysUpdate_FunctionParams* ptr = stackalloc USMStateInstance_Base.__GetAlwaysUpdate_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(USMStateInstance_Base.__GetAlwaysUpdate_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMStateInstance_Base.__GetAlwaysUpdate_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMStateInstance_Base.__GetAlwaysUpdate_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x060267F0 RID: 157680 RVA: 0x003AA42E File Offset: 0x003A862E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void EvaluateTransitions()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMStateInstance_Base.__EvaluateTransitions_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060267F1 RID: 157681 RVA: 0x003AA444 File Offset: 0x003A8644
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool AreAllOutgoingTransitionsFromAnAnyState()
		{
			USMStateInstance_Base.__AreAllOutgoingTransitionsFromAnAnyState_FunctionParams* ptr = stackalloc USMStateInstance_Base.__AreAllOutgoingTransitionsFromAnAnyState_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(USMStateInstance_Base.__AreAllOutgoingTransitionsFromAnAnyState_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMStateInstance_Base.__AreAllOutgoingTransitionsFromAnAnyState_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMStateInstance_Base.__AreAllOutgoingTransitionsFromAnAnyState_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x060267F2 RID: 157682 RVA: 0x003AA48C File Offset: 0x003A868C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool AreAllIncomingTransitionsFromAnAnyState()
		{
			USMStateInstance_Base.__AreAllIncomingTransitionsFromAnAnyState_FunctionParams* ptr = stackalloc USMStateInstance_Base.__AreAllIncomingTransitionsFromAnAnyState_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(USMStateInstance_Base.__AreAllIncomingTransitionsFromAnAnyState_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMStateInstance_Base.__AreAllIncomingTransitionsFromAnAnyState_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMStateInstance_Base.__AreAllIncomingTransitionsFromAnAnyState_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x060267F3 RID: 157683 RVA: 0x003AA4D2 File Offset: 0x003A86D2
		static USMStateInstance_Base()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SMSystem.SMStateInstance_Base");
		}

		// Token: 0x060267F4 RID: 157684 RVA: 0x003AA4E0 File Offset: 0x003A86E0
		protected USMStateInstance_Base() : this(BuiltinUtils.AllocNativeUObject(USMStateInstance_Base.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060267F5 RID: 157685 RVA: 0x003AA508 File Offset: 0x003A8708
		protected USMStateInstance_Base(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040151E3 RID: 86499
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/SMSystem.SMStateInstance_Base";

		// Token: 0x040151E4 RID: 86500
		private static IntPtr _ClassPtr;

		// Token: 0x040151E5 RID: 86501
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040151E6 RID: 86502
		internal static int __PropertyOffset_OnStateBeginEvent;

		// Token: 0x040151E7 RID: 86503
		[Nullable(2)]
		private FOnStateBeginSignature _OnStateBeginEvent;

		// Token: 0x040151E8 RID: 86504
		internal static int __PropertyOffset_OnPostStateBeginEvent;

		// Token: 0x040151E9 RID: 86505
		[Nullable(2)]
		private FOnStateBeginSignature _OnPostStateBeginEvent;

		// Token: 0x040151EA RID: 86506
		internal static int __PropertyOffset_OnStateUpdateEvent;

		// Token: 0x040151EB RID: 86507
		[Nullable(2)]
		private FOnStateUpdateSignature _OnStateUpdateEvent;

		// Token: 0x040151EC RID: 86508
		internal static int __PropertyOffset_OnStateEndEvent;

		// Token: 0x040151ED RID: 86509
		[Nullable(2)]
		private FOnStateEndSignature _OnStateEndEvent;

		// Token: 0x040151EE RID: 86510
		internal static int __PropertyOffset_TakeControlType;

		// Token: 0x040151EF RID: 86511
		internal static int __PropertyOffset_TransitionRule;

		// Token: 0x040151F0 RID: 86512
		internal static int __PropertyOffset_Task;

		// Token: 0x040151F1 RID: 86513
		internal static int __PropertyOffset_BindStates;

		// Token: 0x040151F2 RID: 86514
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UASMBindState> _BindStates;

		// Token: 0x040151F3 RID: 86515
		internal static int __PropertyOffset_OnEnterActions;

		// Token: 0x040151F4 RID: 86516
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UASMAction> _OnEnterActions;

		// Token: 0x040151F5 RID: 86517
		internal static int __PropertyOffset_OnExitActions;

		// Token: 0x040151F6 RID: 86518
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UASMAction> _OnExitActions;

		// Token: 0x040151F7 RID: 86519
		internal static int __PropertyOffset_NodeName;

		// Token: 0x040151F8 RID: 86520
		internal static int __PropertyOffset_IsRefNode;

		// Token: 0x040151F9 RID: 86521
		internal static int __PropertyOffset_IsOvrNode;

		// Token: 0x040151FA RID: 86522
		internal static int __PropertyOffset_IsAnimNode;

		// Token: 0x040151FB RID: 86523
		internal static int __PropertyOffset_IsConduitNode;

		// Token: 0x040151FC RID: 86524
		internal static int __PropertyOffset_IsAnyStateNode;

		// Token: 0x040151FD RID: 86525
		private static IntPtr __SwitchToLinkedStateByTransition_NativeFunctionPtr;

		// Token: 0x040151FE RID: 86526
		private static IntPtr __SwitchToLinkedStateByName_NativeFunctionPtr;

		// Token: 0x040151FF RID: 86527
		private static IntPtr __SwitchToLinkedState_NativeFunctionPtr;

		// Token: 0x04015200 RID: 86528
		private static IntPtr __SetExcludeFromAnyState_NativeFunctionPtr;

		// Token: 0x04015201 RID: 86529
		private static IntPtr __SetEvalTransitionsOnStart_NativeFunctionPtr;

		// Token: 0x04015202 RID: 86530
		private static IntPtr __SetDisableTickTransitionEvaluation_NativeFunctionPtr;

		// Token: 0x04015203 RID: 86531
		private static IntPtr __SetAlwaysUpdate_NativeFunctionPtr;

		// Token: 0x04015204 RID: 86532
		private static IntPtr __SetActive_NativeFunctionPtr;

		// Token: 0x04015205 RID: 86533
		private static IntPtr __IsStateMachine_NativeFunctionPtr;

		// Token: 0x04015206 RID: 86534
		private static IntPtr __IsEntryState_NativeFunctionPtr;

		// Token: 0x04015207 RID: 86535
		private static IntPtr __GetTransitionToTake_NativeFunctionPtr;

		// Token: 0x04015208 RID: 86536
		private static IntPtr __GetTransitionByIndex_NativeFunctionPtr;

		// Token: 0x04015209 RID: 86537
		private static IntPtr __GetStateInfo_NativeFunctionPtr;

		// Token: 0x0401520A RID: 86538
		private static IntPtr __GetStartTime_NativeFunctionPtr;

		// Token: 0x0401520B RID: 86539
		private static IntPtr __GetServerTimeInState_NativeFunctionPtr;

		// Token: 0x0401520C RID: 86540
		private static IntPtr __GetPreviousStateByName_NativeFunctionPtr;

		// Token: 0x0401520D RID: 86541
		private static IntPtr __GetPreviousActiveTransition_NativeFunctionPtr;

		// Token: 0x0401520E RID: 86542
		private static IntPtr __GetPreviousActiveState_NativeFunctionPtr;

		// Token: 0x0401520F RID: 86543
		private static IntPtr __GetOutgoingTransitions_NativeFunctionPtr;

		// Token: 0x04015210 RID: 86544
		private static IntPtr __GetNextStateByTransitionIndex_NativeFunctionPtr;

		// Token: 0x04015211 RID: 86545
		private static IntPtr __GetNextStateByName_NativeFunctionPtr;

		// Token: 0x04015212 RID: 86546
		private static IntPtr __GetIncomingTransitions_NativeFunctionPtr;

		// Token: 0x04015213 RID: 86547
		private static IntPtr __GetExcludeFromAnyState_NativeFunctionPtr;

		// Token: 0x04015214 RID: 86548
		private static IntPtr __GetEvalTransitionsOnStart_NativeFunctionPtr;

		// Token: 0x04015215 RID: 86549
		private static IntPtr __GetDisableTickTransitionEvaluation_NativeFunctionPtr;

		// Token: 0x04015216 RID: 86550
		private static IntPtr __GetAlwaysUpdate_NativeFunctionPtr;

		// Token: 0x04015217 RID: 86551
		private static IntPtr __EvaluateTransitions_NativeFunctionPtr;

		// Token: 0x04015218 RID: 86552
		private static IntPtr __AreAllOutgoingTransitionsFromAnAnyState_NativeFunctionPtr;

		// Token: 0x04015219 RID: 86553
		private static IntPtr __AreAllIncomingTransitionsFromAnAnyState_NativeFunctionPtr;

		// Token: 0x02003ADA RID: 15066
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SwitchToLinkedStateByTransition_FunctionParams
		{
			// Token: 0x04017C64 RID: 97380
			[FieldOffset(0)]
			public IntPtr TransitionInstance;

			// Token: 0x04017C65 RID: 97381
			[FieldOffset(8)]
			public bool bRequireTransitionToPass;

			// Token: 0x04017C66 RID: 97382
			[FieldOffset(9)]
			public bool bActivateNow;

			// Token: 0x04017C67 RID: 97383
			[FieldOffset(10)]
			public bool __Result;
		}

		// Token: 0x02003ADB RID: 15067
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __SwitchToLinkedStateByName_FunctionParams
		{
			// Token: 0x04017C68 RID: 97384
			[FieldOffset(0)]
			public FString NextStateName;

			// Token: 0x04017C69 RID: 97385
			[FieldOffset(16)]
			public bool bRequireTransitionToPass;

			// Token: 0x04017C6A RID: 97386
			[FieldOffset(17)]
			public bool bActivateNow;

			// Token: 0x04017C6B RID: 97387
			[FieldOffset(18)]
			public bool __Result;
		}

		// Token: 0x02003ADC RID: 15068
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SwitchToLinkedState_FunctionParams
		{
			// Token: 0x04017C6C RID: 97388
			[FieldOffset(0)]
			public IntPtr NextStateInstance;

			// Token: 0x04017C6D RID: 97389
			[FieldOffset(8)]
			public bool bRequireTransitionToPass;

			// Token: 0x04017C6E RID: 97390
			[FieldOffset(9)]
			public bool bActivateNow;

			// Token: 0x04017C6F RID: 97391
			[FieldOffset(10)]
			public bool __Result;
		}

		// Token: 0x02003ADD RID: 15069
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetExcludeFromAnyState_FunctionParams
		{
			// Token: 0x04017C70 RID: 97392
			[FieldOffset(0)]
			public bool bValue;
		}

		// Token: 0x02003ADE RID: 15070
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetEvalTransitionsOnStart_FunctionParams
		{
			// Token: 0x04017C71 RID: 97393
			[FieldOffset(0)]
			public bool bValue;
		}

		// Token: 0x02003ADF RID: 15071
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetDisableTickTransitionEvaluation_FunctionParams
		{
			// Token: 0x04017C72 RID: 97394
			[FieldOffset(0)]
			public bool bValue;
		}

		// Token: 0x02003AE0 RID: 15072
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetAlwaysUpdate_FunctionParams
		{
			// Token: 0x04017C73 RID: 97395
			[FieldOffset(0)]
			public bool bValue;
		}

		// Token: 0x02003AE1 RID: 15073
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 3)]
		protected ref struct __SetActive_FunctionParams
		{
			// Token: 0x04017C74 RID: 97396
			[FieldOffset(0)]
			public bool bValue;

			// Token: 0x04017C75 RID: 97397
			[FieldOffset(1)]
			public bool bSetAllParents;

			// Token: 0x04017C76 RID: 97398
			[FieldOffset(2)]
			public bool bActivateNow;
		}

		// Token: 0x02003AE2 RID: 15074
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsStateMachine_FunctionParams
		{
			// Token: 0x04017C77 RID: 97399
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02003AE3 RID: 15075
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsEntryState_FunctionParams
		{
			// Token: 0x04017C78 RID: 97400
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02003AE4 RID: 15076
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetTransitionToTake_FunctionParams
		{
			// Token: 0x04017C79 RID: 97401
			[FieldOffset(0)]
			public IntPtr __Result;
		}

		// Token: 0x02003AE5 RID: 15077
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetTransitionByIndex_FunctionParams
		{
			// Token: 0x04017C7A RID: 97402
			[FieldOffset(0)]
			public int Index;

			// Token: 0x04017C7B RID: 97403
			[FieldOffset(8)]
			public IntPtr __Result;
		}

		// Token: 0x02003AE6 RID: 15078
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 128)]
		protected ref struct __GetStateInfo_FunctionParams
		{
			// Token: 0x04017C7C RID: 97404
			[FieldOffset(0)]
			public byte State;
		}

		// Token: 0x02003AE7 RID: 15079
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetStartTime_FunctionParams
		{
			// Token: 0x04017C7D RID: 97405
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02003AE8 RID: 15080
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetServerTimeInState_FunctionParams
		{
			// Token: 0x04017C7E RID: 97406
			[FieldOffset(0)]
			public bool bOutUsedLocalTime;

			// Token: 0x04017C7F RID: 97407
			[FieldOffset(4)]
			public float __Result;
		}

		// Token: 0x02003AE9 RID: 15081
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __GetPreviousStateByName_FunctionParams
		{
			// Token: 0x04017C80 RID: 97408
			[FieldOffset(0)]
			public FString StateName;

			// Token: 0x04017C81 RID: 97409
			[FieldOffset(16)]
			public IntPtr __Result;
		}

		// Token: 0x02003AEA RID: 15082
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetPreviousActiveTransition_FunctionParams
		{
			// Token: 0x04017C82 RID: 97410
			[FieldOffset(0)]
			public IntPtr __Result;
		}

		// Token: 0x02003AEB RID: 15083
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetPreviousActiveState_FunctionParams
		{
			// Token: 0x04017C83 RID: 97411
			[FieldOffset(0)]
			public IntPtr __Result;
		}

		// Token: 0x02003AEC RID: 15084
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __GetOutgoingTransitions_FunctionParams
		{
			// Token: 0x04017C84 RID: 97412
			[FieldOffset(0)]
			public byte Transitions;

			// Token: 0x04017C85 RID: 97413
			[FieldOffset(16)]
			public bool bExcludeAlwaysFalse;

			// Token: 0x04017C86 RID: 97414
			[FieldOffset(17)]
			public bool __Result;
		}

		// Token: 0x02003AED RID: 15085
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetNextStateByTransitionIndex_FunctionParams
		{
			// Token: 0x04017C87 RID: 97415
			[FieldOffset(0)]
			public int Index;

			// Token: 0x04017C88 RID: 97416
			[FieldOffset(8)]
			public IntPtr __Result;
		}

		// Token: 0x02003AEE RID: 15086
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __GetNextStateByName_FunctionParams
		{
			// Token: 0x04017C89 RID: 97417
			[FieldOffset(0)]
			public FString StateName;

			// Token: 0x04017C8A RID: 97418
			[FieldOffset(16)]
			public IntPtr __Result;
		}

		// Token: 0x02003AEF RID: 15087
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __GetIncomingTransitions_FunctionParams
		{
			// Token: 0x04017C8B RID: 97419
			[FieldOffset(0)]
			public byte Transitions;

			// Token: 0x04017C8C RID: 97420
			[FieldOffset(16)]
			public bool bExcludeAlwaysFalse;

			// Token: 0x04017C8D RID: 97421
			[FieldOffset(17)]
			public bool __Result;
		}

		// Token: 0x02003AF0 RID: 15088
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __GetExcludeFromAnyState_FunctionParams
		{
			// Token: 0x04017C8E RID: 97422
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02003AF1 RID: 15089
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __GetEvalTransitionsOnStart_FunctionParams
		{
			// Token: 0x04017C8F RID: 97423
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02003AF2 RID: 15090
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __GetDisableTickTransitionEvaluation_FunctionParams
		{
			// Token: 0x04017C90 RID: 97424
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02003AF3 RID: 15091
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __GetAlwaysUpdate_FunctionParams
		{
			// Token: 0x04017C91 RID: 97425
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02003AF4 RID: 15092
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __AreAllOutgoingTransitionsFromAnAnyState_FunctionParams
		{
			// Token: 0x04017C92 RID: 97426
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02003AF5 RID: 15093
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __AreAllIncomingTransitionsFromAnAnyState_FunctionParams
		{
			// Token: 0x04017C93 RID: 97427
			[FieldOffset(0)]
			public bool __Result;
		}
	}
}
