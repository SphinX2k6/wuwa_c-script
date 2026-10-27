using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200289F RID: 10399
	[UnrealObjectPath("/Script/SMSystem.SMTransitionInstance")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 136)]
	public class USMTransitionInstance : USMNodeInstance, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06026916 RID: 157974 RVA: 0x003AD4E4 File Offset: 0x003AB6E4
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USMTransitionInstance._ClassPtr;
		}

		// Token: 0x06026917 RID: 157975 RVA: 0x003AD4F0 File Offset: 0x003AB6F0
		public USMTransitionInstance() : this(BuiltinUtils.AllocNativeUObject(USMTransitionInstance.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06026918 RID: 157976 RVA: 0x003AD518 File Offset: 0x003AB718
		[NullableContext(1)]
		public USMTransitionInstance(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USMTransitionInstance.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170094BF RID: 38079
		// (get) Token: 0x06026919 RID: 157977 RVA: 0x003AD54B File Offset: 0x003AB74B
		// (set) Token: 0x0602691A RID: 157978 RVA: 0x003AD55B File Offset: 0x003AB75B
		public unsafe int PriorityOrder
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USMTransitionInstance.__PropertyOffset_PriorityOrder);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USMTransitionInstance.__PropertyOffset_PriorityOrder) = value;
			}
		}

		// Token: 0x170094C0 RID: 38080
		// (get) Token: 0x0602691B RID: 157979 RVA: 0x003AD56C File Offset: 0x003AB76C
		// (set) Token: 0x0602691C RID: 157980 RVA: 0x003AD5A5 File Offset: 0x003AB7A5
		[Nullable(1)]
		public FOnTransitionEnteredSignature OnTransitionEnteredEvent
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FOnTransitionEnteredSignature result;
				if ((result = this._OnTransitionEnteredEvent) == null)
				{
					result = (this._OnTransitionEnteredEvent = new FOnTransitionEnteredSignature(base.NativePtr + (IntPtr)USMTransitionInstance.__PropertyOffset_OnTransitionEnteredEvent, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)USMTransitionInstance.__PropertyOffset_OnTransitionEnteredEvent, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170094C1 RID: 38081
		// (get) Token: 0x0602691D RID: 157981 RVA: 0x003AD5C6 File Offset: 0x003AB7C6
		// (set) Token: 0x0602691E RID: 157982 RVA: 0x003AD5DA File Offset: 0x003AB7DA
		public unsafe TEnumAsByte<ETransitionPredictionType> TransitionPredictionType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USMTransitionInstance.__PropertyOffset_TransitionPredictionType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USMTransitionInstance.__PropertyOffset_TransitionPredictionType) = value;
			}
		}

		// Token: 0x170094C2 RID: 38082
		// (get) Token: 0x0602691F RID: 157983 RVA: 0x003AD5EF File Offset: 0x003AB7EF
		// (set) Token: 0x06026920 RID: 157984 RVA: 0x003AD603 File Offset: 0x003AB803
		[Nullable(2)]
		public unsafe UASMConditionBase Condition
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UASMConditionBase>(base.NativePtr / (IntPtr)sizeof(void*) + USMTransitionInstance.__PropertyOffset_Condition);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + USMTransitionInstance.__PropertyOffset_Condition, value);
			}
		}

		// Token: 0x170094C3 RID: 38083
		// (get) Token: 0x06026921 RID: 157985 RVA: 0x003AD618 File Offset: 0x003AB818
		// (set) Token: 0x06026922 RID: 157986 RVA: 0x003AD62C File Offset: 0x003AB82C
		[Nullable(2)]
		public unsafe USMStateInstance_Base From
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USMStateInstance_Base>(base.NativePtr / (IntPtr)sizeof(void*) + USMTransitionInstance.__PropertyOffset_From);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + USMTransitionInstance.__PropertyOffset_From, value);
			}
		}

		// Token: 0x170094C4 RID: 38084
		// (get) Token: 0x06026923 RID: 157987 RVA: 0x003AD641 File Offset: 0x003AB841
		// (set) Token: 0x06026924 RID: 157988 RVA: 0x003AD655 File Offset: 0x003AB855
		[Nullable(2)]
		public unsafe USMStateInstance_Base To
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USMStateInstance_Base>(base.NativePtr / (IntPtr)sizeof(void*) + USMTransitionInstance.__PropertyOffset_To);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + USMTransitionInstance.__PropertyOffset_To, value);
			}
		}

		// Token: 0x06026925 RID: 157989 RVA: 0x003AD66C File Offset: 0x003AB86C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetPriorityOrder(int Value)
		{
			USMTransitionInstance.__SetPriorityOrder_FunctionParams* ptr = stackalloc USMTransitionInstance.__SetPriorityOrder_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(USMTransitionInstance.__SetPriorityOrder_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMTransitionInstance.__SetPriorityOrder_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Value = Value;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMTransitionInstance.__SetPriorityOrder_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06026926 RID: 157990 RVA: 0x003AD6B4 File Offset: 0x003AB8B4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetCanEvalWithStartState(bool bValue)
		{
			USMTransitionInstance.__SetCanEvalWithStartState_FunctionParams* ptr = stackalloc USMTransitionInstance.__SetCanEvalWithStartState_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(USMTransitionInstance.__SetCanEvalWithStartState_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMTransitionInstance.__SetCanEvalWithStartState_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bValue = bValue;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMTransitionInstance.__SetCanEvalWithStartState_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06026927 RID: 157991 RVA: 0x003AD6FC File Offset: 0x003AB8FC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetCanEvaluateFromEvent(bool bValue)
		{
			USMTransitionInstance.__SetCanEvaluateFromEvent_FunctionParams* ptr = stackalloc USMTransitionInstance.__SetCanEvaluateFromEvent_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(USMTransitionInstance.__SetCanEvaluateFromEvent_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMTransitionInstance.__SetCanEvaluateFromEvent_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bValue = bValue;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMTransitionInstance.__SetCanEvaluateFromEvent_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06026928 RID: 157992 RVA: 0x003AD744 File Offset: 0x003AB944
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetCanEvaluate(bool bValue)
		{
			USMTransitionInstance.__SetCanEvaluate_FunctionParams* ptr = stackalloc USMTransitionInstance.__SetCanEvaluate_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(USMTransitionInstance.__SetCanEvaluate_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMTransitionInstance.__SetCanEvaluate_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bValue = bValue;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMTransitionInstance.__SetCanEvaluate_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06026929 RID: 157993 RVA: 0x003AD78C File Offset: 0x003AB98C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool IsTransitionFromAnyState()
		{
			USMTransitionInstance.__IsTransitionFromAnyState_FunctionParams* ptr = stackalloc USMTransitionInstance.__IsTransitionFromAnyState_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(USMTransitionInstance.__IsTransitionFromAnyState_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMTransitionInstance.__IsTransitionFromAnyState_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMTransitionInstance.__IsTransitionFromAnyState_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0602692A RID: 157994 RVA: 0x003AD7D4 File Offset: 0x003AB9D4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void GetTransitionInfo(ref FSMTransitionInfo Transition)
		{
			USMTransitionInstance.__GetTransitionInfo_FunctionParams* ptr = stackalloc USMTransitionInstance.__GetTransitionInfo_FunctionParams[(UIntPtr)167] + 15L / (long)sizeof(USMTransitionInstance.__GetTransitionInfo_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMTransitionInstance.__GetTransitionInfo_NativeFunctionPtr, (void*)ptr, 1);
			if (Transition != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FSMTransitionInfo.StaticStruct(), &ptr->Transition, Transition.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMTransitionInstance.__GetTransitionInfo_NativeFunctionPtr, (void*)ptr, 0);
			if (Transition != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FSMTransitionInfo.StaticStruct(), Transition.NativePtr, &ptr->Transition, 1, false);
			}
			UnrealReflectionUtils.DestroyStruct(USMTransitionInstance.__GetTransitionInfo_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602692B RID: 157995 RVA: 0x003AD870 File Offset: 0x003ABA70
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe USMStateInstance_Base GetSourceStateForActiveTransition()
		{
			USMTransitionInstance.__GetSourceStateForActiveTransition_FunctionParams* ptr = stackalloc USMTransitionInstance.__GetSourceStateForActiveTransition_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(USMTransitionInstance.__GetSourceStateForActiveTransition_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMTransitionInstance.__GetSourceStateForActiveTransition_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMTransitionInstance.__GetSourceStateForActiveTransition_NativeFunctionPtr, (void*)ptr, 0);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<USMStateInstance_Base>(ptr->__Result);
		}

		// Token: 0x0602692C RID: 157996 RVA: 0x003AD8BC File Offset: 0x003ABABC
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe FDateTime GetServerTimestamp()
		{
			USMTransitionInstance.__GetServerTimestamp_FunctionParams* ptr = stackalloc USMTransitionInstance.__GetServerTimestamp_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(USMTransitionInstance.__GetServerTimestamp_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMTransitionInstance.__GetServerTimestamp_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMTransitionInstance.__GetServerTimestamp_NativeFunctionPtr, (void*)ptr, 0);
			return new FDateTime(&ptr->__Result, true, true);
		}

		// Token: 0x0602692D RID: 157997 RVA: 0x003AD90C File Offset: 0x003ABB0C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe int GetPriorityOrder()
		{
			USMTransitionInstance.__GetPriorityOrder_FunctionParams* ptr = stackalloc USMTransitionInstance.__GetPriorityOrder_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(USMTransitionInstance.__GetPriorityOrder_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMTransitionInstance.__GetPriorityOrder_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMTransitionInstance.__GetPriorityOrder_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0602692E RID: 157998 RVA: 0x003AD954 File Offset: 0x003ABB54
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe USMStateInstance_Base GetPreviousStateInstance()
		{
			USMTransitionInstance.__GetPreviousStateInstance_FunctionParams* ptr = stackalloc USMTransitionInstance.__GetPreviousStateInstance_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(USMTransitionInstance.__GetPreviousStateInstance_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMTransitionInstance.__GetPreviousStateInstance_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMTransitionInstance.__GetPreviousStateInstance_NativeFunctionPtr, (void*)ptr, 0);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<USMStateInstance_Base>(ptr->__Result);
		}

		// Token: 0x0602692F RID: 157999 RVA: 0x003AD9A0 File Offset: 0x003ABBA0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe USMStateInstance_Base GetNextStateInstance()
		{
			USMTransitionInstance.__GetNextStateInstance_FunctionParams* ptr = stackalloc USMTransitionInstance.__GetNextStateInstance_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(USMTransitionInstance.__GetNextStateInstance_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMTransitionInstance.__GetNextStateInstance_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMTransitionInstance.__GetNextStateInstance_NativeFunctionPtr, (void*)ptr, 0);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<USMStateInstance_Base>(ptr->__Result);
		}

		// Token: 0x06026930 RID: 158000 RVA: 0x003AD9EC File Offset: 0x003ABBEC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe USMStateInstance_Base GetDestinationStateForActiveTransition()
		{
			USMTransitionInstance.__GetDestinationStateForActiveTransition_FunctionParams* ptr = stackalloc USMTransitionInstance.__GetDestinationStateForActiveTransition_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(USMTransitionInstance.__GetDestinationStateForActiveTransition_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMTransitionInstance.__GetDestinationStateForActiveTransition_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMTransitionInstance.__GetDestinationStateForActiveTransition_NativeFunctionPtr, (void*)ptr, 0);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<USMStateInstance_Base>(ptr->__Result);
		}

		// Token: 0x06026931 RID: 158001 RVA: 0x003ADA38 File Offset: 0x003ABC38
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool GetCanEvalWithStartState()
		{
			USMTransitionInstance.__GetCanEvalWithStartState_FunctionParams* ptr = stackalloc USMTransitionInstance.__GetCanEvalWithStartState_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(USMTransitionInstance.__GetCanEvalWithStartState_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMTransitionInstance.__GetCanEvalWithStartState_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMTransitionInstance.__GetCanEvalWithStartState_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06026932 RID: 158002 RVA: 0x003ADA80 File Offset: 0x003ABC80
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool GetCanEvaluateFromEvent()
		{
			USMTransitionInstance.__GetCanEvaluateFromEvent_FunctionParams* ptr = stackalloc USMTransitionInstance.__GetCanEvaluateFromEvent_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(USMTransitionInstance.__GetCanEvaluateFromEvent_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMTransitionInstance.__GetCanEvaluateFromEvent_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMTransitionInstance.__GetCanEvaluateFromEvent_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06026933 RID: 158003 RVA: 0x003ADAC8 File Offset: 0x003ABCC8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool GetCanEvaluate()
		{
			USMTransitionInstance.__GetCanEvaluate_FunctionParams* ptr = stackalloc USMTransitionInstance.__GetCanEvaluate_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(USMTransitionInstance.__GetCanEvaluate_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMTransitionInstance.__GetCanEvaluate_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMTransitionInstance.__GetCanEvaluate_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06026934 RID: 158004 RVA: 0x003ADB0E File Offset: 0x003ABD0E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void EvaluateFromManuallyBoundEvent()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMTransitionInstance.__EvaluateFromManuallyBoundEvent_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06026935 RID: 158005 RVA: 0x003ADB24 File Offset: 0x003ABD24
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool DoesTransitionPass()
		{
			USMTransitionInstance.__DoesTransitionPass_FunctionParams* ptr = stackalloc USMTransitionInstance.__DoesTransitionPass_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(USMTransitionInstance.__DoesTransitionPass_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMTransitionInstance.__DoesTransitionPass_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMTransitionInstance.__DoesTransitionPass_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06026936 RID: 158006 RVA: 0x003ADB6A File Offset: 0x003ABD6A
		static USMTransitionInstance()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SMSystem.SMTransitionInstance");
		}

		// Token: 0x06026937 RID: 158007 RVA: 0x003ADB78 File Offset: 0x003ABD78
		protected USMTransitionInstance(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040152F2 RID: 86770
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/SMSystem.SMTransitionInstance";

		// Token: 0x040152F3 RID: 86771
		private static IntPtr _ClassPtr;

		// Token: 0x040152F4 RID: 86772
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040152F5 RID: 86773
		internal static int __PropertyOffset_PriorityOrder;

		// Token: 0x040152F6 RID: 86774
		internal static int __PropertyOffset_OnTransitionEnteredEvent;

		// Token: 0x040152F7 RID: 86775
		[Nullable(2)]
		private FOnTransitionEnteredSignature _OnTransitionEnteredEvent;

		// Token: 0x040152F8 RID: 86776
		internal static int __PropertyOffset_TransitionPredictionType;

		// Token: 0x040152F9 RID: 86777
		internal static int __PropertyOffset_Condition;

		// Token: 0x040152FA RID: 86778
		internal static int __PropertyOffset_From;

		// Token: 0x040152FB RID: 86779
		internal static int __PropertyOffset_To;

		// Token: 0x040152FC RID: 86780
		private static IntPtr __SetPriorityOrder_NativeFunctionPtr;

		// Token: 0x040152FD RID: 86781
		private static IntPtr __SetCanEvalWithStartState_NativeFunctionPtr;

		// Token: 0x040152FE RID: 86782
		private static IntPtr __SetCanEvaluateFromEvent_NativeFunctionPtr;

		// Token: 0x040152FF RID: 86783
		private static IntPtr __SetCanEvaluate_NativeFunctionPtr;

		// Token: 0x04015300 RID: 86784
		private static IntPtr __IsTransitionFromAnyState_NativeFunctionPtr;

		// Token: 0x04015301 RID: 86785
		private static IntPtr __GetTransitionInfo_NativeFunctionPtr;

		// Token: 0x04015302 RID: 86786
		private static IntPtr __GetSourceStateForActiveTransition_NativeFunctionPtr;

		// Token: 0x04015303 RID: 86787
		private static IntPtr __GetServerTimestamp_NativeFunctionPtr;

		// Token: 0x04015304 RID: 86788
		private static IntPtr __GetPriorityOrder_NativeFunctionPtr;

		// Token: 0x04015305 RID: 86789
		private static IntPtr __GetPreviousStateInstance_NativeFunctionPtr;

		// Token: 0x04015306 RID: 86790
		private static IntPtr __GetNextStateInstance_NativeFunctionPtr;

		// Token: 0x04015307 RID: 86791
		private static IntPtr __GetDestinationStateForActiveTransition_NativeFunctionPtr;

		// Token: 0x04015308 RID: 86792
		private static IntPtr __GetCanEvalWithStartState_NativeFunctionPtr;

		// Token: 0x04015309 RID: 86793
		private static IntPtr __GetCanEvaluateFromEvent_NativeFunctionPtr;

		// Token: 0x0401530A RID: 86794
		private static IntPtr __GetCanEvaluate_NativeFunctionPtr;

		// Token: 0x0401530B RID: 86795
		private static IntPtr __EvaluateFromManuallyBoundEvent_NativeFunctionPtr;

		// Token: 0x0401530C RID: 86796
		private static IntPtr __DoesTransitionPass_NativeFunctionPtr;

		// Token: 0x02003B28 RID: 15144
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __SetPriorityOrder_FunctionParams
		{
			// Token: 0x04017CCC RID: 97484
			[FieldOffset(0)]
			public int Value;
		}

		// Token: 0x02003B29 RID: 15145
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetCanEvalWithStartState_FunctionParams
		{
			// Token: 0x04017CCD RID: 97485
			[FieldOffset(0)]
			public bool bValue;
		}

		// Token: 0x02003B2A RID: 15146
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetCanEvaluateFromEvent_FunctionParams
		{
			// Token: 0x04017CCE RID: 97486
			[FieldOffset(0)]
			public bool bValue;
		}

		// Token: 0x02003B2B RID: 15147
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetCanEvaluate_FunctionParams
		{
			// Token: 0x04017CCF RID: 97487
			[FieldOffset(0)]
			public bool bValue;
		}

		// Token: 0x02003B2C RID: 15148
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsTransitionFromAnyState_FunctionParams
		{
			// Token: 0x04017CD0 RID: 97488
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02003B2D RID: 15149
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 152)]
		protected ref struct __GetTransitionInfo_FunctionParams
		{
			// Token: 0x04017CD1 RID: 97489
			[FieldOffset(0)]
			public byte Transition;
		}

		// Token: 0x02003B2E RID: 15150
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetSourceStateForActiveTransition_FunctionParams
		{
			// Token: 0x04017CD2 RID: 97490
			[FieldOffset(0)]
			public IntPtr __Result;
		}

		// Token: 0x02003B2F RID: 15151
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetServerTimestamp_FunctionParams
		{
			// Token: 0x04017CD3 RID: 97491
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02003B30 RID: 15152
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetPriorityOrder_FunctionParams
		{
			// Token: 0x04017CD4 RID: 97492
			[FieldOffset(0)]
			public int __Result;
		}

		// Token: 0x02003B31 RID: 15153
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetPreviousStateInstance_FunctionParams
		{
			// Token: 0x04017CD5 RID: 97493
			[FieldOffset(0)]
			public IntPtr __Result;
		}

		// Token: 0x02003B32 RID: 15154
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetNextStateInstance_FunctionParams
		{
			// Token: 0x04017CD6 RID: 97494
			[FieldOffset(0)]
			public IntPtr __Result;
		}

		// Token: 0x02003B33 RID: 15155
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetDestinationStateForActiveTransition_FunctionParams
		{
			// Token: 0x04017CD7 RID: 97495
			[FieldOffset(0)]
			public IntPtr __Result;
		}

		// Token: 0x02003B34 RID: 15156
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __GetCanEvalWithStartState_FunctionParams
		{
			// Token: 0x04017CD8 RID: 97496
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02003B35 RID: 15157
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __GetCanEvaluateFromEvent_FunctionParams
		{
			// Token: 0x04017CD9 RID: 97497
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02003B36 RID: 15158
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __GetCanEvaluate_FunctionParams
		{
			// Token: 0x04017CDA RID: 97498
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02003B37 RID: 15159
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __DoesTransitionPass_FunctionParams
		{
			// Token: 0x04017CDB RID: 97499
			[FieldOffset(0)]
			public bool __Result;
		}
	}
}
