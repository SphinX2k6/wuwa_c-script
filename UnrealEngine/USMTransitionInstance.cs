using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000836 RID: 2102
	[UnrealObjectPath("/Script/SMSystem.SMTransitionInstance")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 136)]
	public class USMTransitionInstance : USMNodeInstance, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600B765 RID: 46949 RVA: 0x00125B6F File Offset: 0x00123D6F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USMTransitionInstance._ClassPtr;
		}

		// Token: 0x0600B766 RID: 46950 RVA: 0x00125B7C File Offset: 0x00123D7C
		public USMTransitionInstance() : this(BuiltinUtils.AllocNativeUObject(USMTransitionInstance.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600B767 RID: 46951 RVA: 0x00125BA4 File Offset: 0x00123DA4
		[NullableContext(1)]
		public USMTransitionInstance(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USMTransitionInstance.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002243 RID: 8771
		// (get) Token: 0x0600B768 RID: 46952 RVA: 0x00125BD7 File Offset: 0x00123DD7
		// (set) Token: 0x0600B769 RID: 46953 RVA: 0x00125BE7 File Offset: 0x00123DE7
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

		// Token: 0x17002244 RID: 8772
		// (get) Token: 0x0600B76A RID: 46954 RVA: 0x00125BF8 File Offset: 0x00123DF8
		// (set) Token: 0x0600B76B RID: 46955 RVA: 0x00125C31 File Offset: 0x00123E31
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

		// Token: 0x17002245 RID: 8773
		// (get) Token: 0x0600B76C RID: 46956 RVA: 0x00125C52 File Offset: 0x00123E52
		// (set) Token: 0x0600B76D RID: 46957 RVA: 0x00125C66 File Offset: 0x00123E66
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

		// Token: 0x17002246 RID: 8774
		// (get) Token: 0x0600B76E RID: 46958 RVA: 0x00125C7B File Offset: 0x00123E7B
		// (set) Token: 0x0600B76F RID: 46959 RVA: 0x00125C8F File Offset: 0x00123E8F
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

		// Token: 0x17002247 RID: 8775
		// (get) Token: 0x0600B770 RID: 46960 RVA: 0x00125CA4 File Offset: 0x00123EA4
		// (set) Token: 0x0600B771 RID: 46961 RVA: 0x00125CB8 File Offset: 0x00123EB8
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

		// Token: 0x17002248 RID: 8776
		// (get) Token: 0x0600B772 RID: 46962 RVA: 0x00125CCD File Offset: 0x00123ECD
		// (set) Token: 0x0600B773 RID: 46963 RVA: 0x00125CE1 File Offset: 0x00123EE1
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

		// Token: 0x0600B774 RID: 46964 RVA: 0x00125CF8 File Offset: 0x00123EF8
		[SkipLocalsInit]
		public unsafe void SetPriorityOrder(int Value)
		{
			USMTransitionInstance.__SetPriorityOrder_FunctionParams* ptr = stackalloc USMTransitionInstance.__SetPriorityOrder_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(USMTransitionInstance.__SetPriorityOrder_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMTransitionInstance.__SetPriorityOrder_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Value = Value;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMTransitionInstance.__SetPriorityOrder_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600B775 RID: 46965 RVA: 0x00125D40 File Offset: 0x00123F40
		[SkipLocalsInit]
		public unsafe void SetCanEvalWithStartState(bool bValue)
		{
			USMTransitionInstance.__SetCanEvalWithStartState_FunctionParams* ptr = stackalloc USMTransitionInstance.__SetCanEvalWithStartState_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(USMTransitionInstance.__SetCanEvalWithStartState_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMTransitionInstance.__SetCanEvalWithStartState_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bValue = bValue;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMTransitionInstance.__SetCanEvalWithStartState_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600B776 RID: 46966 RVA: 0x00125D88 File Offset: 0x00123F88
		[SkipLocalsInit]
		public unsafe void SetCanEvaluateFromEvent(bool bValue)
		{
			USMTransitionInstance.__SetCanEvaluateFromEvent_FunctionParams* ptr = stackalloc USMTransitionInstance.__SetCanEvaluateFromEvent_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(USMTransitionInstance.__SetCanEvaluateFromEvent_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMTransitionInstance.__SetCanEvaluateFromEvent_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bValue = bValue;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMTransitionInstance.__SetCanEvaluateFromEvent_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600B777 RID: 46967 RVA: 0x00125DD0 File Offset: 0x00123FD0
		[SkipLocalsInit]
		public unsafe void SetCanEvaluate(bool bValue)
		{
			USMTransitionInstance.__SetCanEvaluate_FunctionParams* ptr = stackalloc USMTransitionInstance.__SetCanEvaluate_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(USMTransitionInstance.__SetCanEvaluate_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMTransitionInstance.__SetCanEvaluate_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bValue = bValue;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMTransitionInstance.__SetCanEvaluate_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600B778 RID: 46968 RVA: 0x00125E18 File Offset: 0x00124018
		[SkipLocalsInit]
		public unsafe bool IsTransitionFromAnyState()
		{
			USMTransitionInstance.__IsTransitionFromAnyState_FunctionParams* ptr = stackalloc USMTransitionInstance.__IsTransitionFromAnyState_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(USMTransitionInstance.__IsTransitionFromAnyState_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMTransitionInstance.__IsTransitionFromAnyState_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMTransitionInstance.__IsTransitionFromAnyState_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0600B779 RID: 46969 RVA: 0x00125E60 File Offset: 0x00124060
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe USMStateInstance_Base GetSourceStateForActiveTransition()
		{
			USMTransitionInstance.__GetSourceStateForActiveTransition_FunctionParams* ptr = stackalloc USMTransitionInstance.__GetSourceStateForActiveTransition_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(USMTransitionInstance.__GetSourceStateForActiveTransition_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMTransitionInstance.__GetSourceStateForActiveTransition_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMTransitionInstance.__GetSourceStateForActiveTransition_NativeFunctionPtr, (void*)ptr);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<USMStateInstance_Base>(ptr->__Result);
		}

		// Token: 0x0600B77A RID: 46970 RVA: 0x00125EAC File Offset: 0x001240AC
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe FDateTime GetServerTimestamp()
		{
			USMTransitionInstance.__GetServerTimestamp_FunctionParams* ptr = stackalloc USMTransitionInstance.__GetServerTimestamp_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(USMTransitionInstance.__GetServerTimestamp_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMTransitionInstance.__GetServerTimestamp_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMTransitionInstance.__GetServerTimestamp_NativeFunctionPtr, (void*)ptr);
			return new FDateTime(&ptr->__Result, true, true);
		}

		// Token: 0x0600B77B RID: 46971 RVA: 0x00125EFC File Offset: 0x001240FC
		[SkipLocalsInit]
		public unsafe int GetPriorityOrder()
		{
			USMTransitionInstance.__GetPriorityOrder_FunctionParams* ptr = stackalloc USMTransitionInstance.__GetPriorityOrder_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(USMTransitionInstance.__GetPriorityOrder_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMTransitionInstance.__GetPriorityOrder_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMTransitionInstance.__GetPriorityOrder_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0600B77C RID: 46972 RVA: 0x00125F44 File Offset: 0x00124144
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe USMStateInstance_Base GetPreviousStateInstance()
		{
			USMTransitionInstance.__GetPreviousStateInstance_FunctionParams* ptr = stackalloc USMTransitionInstance.__GetPreviousStateInstance_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(USMTransitionInstance.__GetPreviousStateInstance_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMTransitionInstance.__GetPreviousStateInstance_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMTransitionInstance.__GetPreviousStateInstance_NativeFunctionPtr, (void*)ptr);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<USMStateInstance_Base>(ptr->__Result);
		}

		// Token: 0x0600B77D RID: 46973 RVA: 0x00125F90 File Offset: 0x00124190
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe USMStateInstance_Base GetNextStateInstance()
		{
			USMTransitionInstance.__GetNextStateInstance_FunctionParams* ptr = stackalloc USMTransitionInstance.__GetNextStateInstance_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(USMTransitionInstance.__GetNextStateInstance_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMTransitionInstance.__GetNextStateInstance_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMTransitionInstance.__GetNextStateInstance_NativeFunctionPtr, (void*)ptr);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<USMStateInstance_Base>(ptr->__Result);
		}

		// Token: 0x0600B77E RID: 46974 RVA: 0x00125FDC File Offset: 0x001241DC
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe USMStateInstance_Base GetDestinationStateForActiveTransition()
		{
			USMTransitionInstance.__GetDestinationStateForActiveTransition_FunctionParams* ptr = stackalloc USMTransitionInstance.__GetDestinationStateForActiveTransition_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(USMTransitionInstance.__GetDestinationStateForActiveTransition_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMTransitionInstance.__GetDestinationStateForActiveTransition_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMTransitionInstance.__GetDestinationStateForActiveTransition_NativeFunctionPtr, (void*)ptr);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<USMStateInstance_Base>(ptr->__Result);
		}

		// Token: 0x0600B77F RID: 46975 RVA: 0x00126028 File Offset: 0x00124228
		[SkipLocalsInit]
		public unsafe bool GetCanEvalWithStartState()
		{
			USMTransitionInstance.__GetCanEvalWithStartState_FunctionParams* ptr = stackalloc USMTransitionInstance.__GetCanEvalWithStartState_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(USMTransitionInstance.__GetCanEvalWithStartState_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMTransitionInstance.__GetCanEvalWithStartState_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMTransitionInstance.__GetCanEvalWithStartState_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0600B780 RID: 46976 RVA: 0x00126070 File Offset: 0x00124270
		[SkipLocalsInit]
		public unsafe bool GetCanEvaluateFromEvent()
		{
			USMTransitionInstance.__GetCanEvaluateFromEvent_FunctionParams* ptr = stackalloc USMTransitionInstance.__GetCanEvaluateFromEvent_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(USMTransitionInstance.__GetCanEvaluateFromEvent_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMTransitionInstance.__GetCanEvaluateFromEvent_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMTransitionInstance.__GetCanEvaluateFromEvent_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0600B781 RID: 46977 RVA: 0x001260B8 File Offset: 0x001242B8
		[SkipLocalsInit]
		public unsafe bool GetCanEvaluate()
		{
			USMTransitionInstance.__GetCanEvaluate_FunctionParams* ptr = stackalloc USMTransitionInstance.__GetCanEvaluate_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(USMTransitionInstance.__GetCanEvaluate_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMTransitionInstance.__GetCanEvaluate_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMTransitionInstance.__GetCanEvaluate_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0600B782 RID: 46978 RVA: 0x001260FD File Offset: 0x001242FD
		[SkipLocalsInit]
		public void EvaluateFromManuallyBoundEvent()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMTransitionInstance.__EvaluateFromManuallyBoundEvent_NativeFunctionPtr, null);
		}

		// Token: 0x0600B783 RID: 46979 RVA: 0x00126114 File Offset: 0x00124314
		[SkipLocalsInit]
		public unsafe bool DoesTransitionPass()
		{
			USMTransitionInstance.__DoesTransitionPass_FunctionParams* ptr = stackalloc USMTransitionInstance.__DoesTransitionPass_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(USMTransitionInstance.__DoesTransitionPass_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMTransitionInstance.__DoesTransitionPass_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMTransitionInstance.__DoesTransitionPass_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0600B784 RID: 46980 RVA: 0x00126159 File Offset: 0x00124359
		static USMTransitionInstance()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SMSystem.SMTransitionInstance");
		}

		// Token: 0x0600B785 RID: 46981 RVA: 0x00126167 File Offset: 0x00124367
		protected USMTransitionInstance(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04005351 RID: 21329
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/SMSystem.SMTransitionInstance";

		// Token: 0x04005352 RID: 21330
		private static IntPtr _ClassPtr;

		// Token: 0x04005353 RID: 21331
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04005354 RID: 21332
		internal static int __PropertyOffset_PriorityOrder;

		// Token: 0x04005355 RID: 21333
		internal static int __PropertyOffset_OnTransitionEnteredEvent;

		// Token: 0x04005356 RID: 21334
		[Nullable(2)]
		private FOnTransitionEnteredSignature _OnTransitionEnteredEvent;

		// Token: 0x04005357 RID: 21335
		internal static int __PropertyOffset_TransitionPredictionType;

		// Token: 0x04005358 RID: 21336
		internal static int __PropertyOffset_Condition;

		// Token: 0x04005359 RID: 21337
		internal static int __PropertyOffset_From;

		// Token: 0x0400535A RID: 21338
		internal static int __PropertyOffset_To;

		// Token: 0x0400535B RID: 21339
		private static IntPtr __SetPriorityOrder_NativeFunctionPtr;

		// Token: 0x0400535C RID: 21340
		private static IntPtr __SetCanEvalWithStartState_NativeFunctionPtr;

		// Token: 0x0400535D RID: 21341
		private static IntPtr __SetCanEvaluateFromEvent_NativeFunctionPtr;

		// Token: 0x0400535E RID: 21342
		private static IntPtr __SetCanEvaluate_NativeFunctionPtr;

		// Token: 0x0400535F RID: 21343
		private static IntPtr __IsTransitionFromAnyState_NativeFunctionPtr;

		// Token: 0x04005360 RID: 21344
		private static IntPtr __GetSourceStateForActiveTransition_NativeFunctionPtr;

		// Token: 0x04005361 RID: 21345
		private static IntPtr __GetServerTimestamp_NativeFunctionPtr;

		// Token: 0x04005362 RID: 21346
		private static IntPtr __GetPriorityOrder_NativeFunctionPtr;

		// Token: 0x04005363 RID: 21347
		private static IntPtr __GetPreviousStateInstance_NativeFunctionPtr;

		// Token: 0x04005364 RID: 21348
		private static IntPtr __GetNextStateInstance_NativeFunctionPtr;

		// Token: 0x04005365 RID: 21349
		private static IntPtr __GetDestinationStateForActiveTransition_NativeFunctionPtr;

		// Token: 0x04005366 RID: 21350
		private static IntPtr __GetCanEvalWithStartState_NativeFunctionPtr;

		// Token: 0x04005367 RID: 21351
		private static IntPtr __GetCanEvaluateFromEvent_NativeFunctionPtr;

		// Token: 0x04005368 RID: 21352
		private static IntPtr __GetCanEvaluate_NativeFunctionPtr;

		// Token: 0x04005369 RID: 21353
		private static IntPtr __EvaluateFromManuallyBoundEvent_NativeFunctionPtr;

		// Token: 0x0400536A RID: 21354
		private static IntPtr __DoesTransitionPass_NativeFunctionPtr;

		// Token: 0x020013BB RID: 5051
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __SetPriorityOrder_FunctionParams
		{
			// Token: 0x04006826 RID: 26662
			[FieldOffset(0)]
			public int Value;
		}

		// Token: 0x020013BC RID: 5052
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetCanEvalWithStartState_FunctionParams
		{
			// Token: 0x04006827 RID: 26663
			[FieldOffset(0)]
			public bool bValue;
		}

		// Token: 0x020013BD RID: 5053
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetCanEvaluateFromEvent_FunctionParams
		{
			// Token: 0x04006828 RID: 26664
			[FieldOffset(0)]
			public bool bValue;
		}

		// Token: 0x020013BE RID: 5054
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetCanEvaluate_FunctionParams
		{
			// Token: 0x04006829 RID: 26665
			[FieldOffset(0)]
			public bool bValue;
		}

		// Token: 0x020013BF RID: 5055
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsTransitionFromAnyState_FunctionParams
		{
			// Token: 0x0400682A RID: 26666
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x020013C0 RID: 5056
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetSourceStateForActiveTransition_FunctionParams
		{
			// Token: 0x0400682B RID: 26667
			[FieldOffset(0)]
			public IntPtr __Result;
		}

		// Token: 0x020013C1 RID: 5057
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetServerTimestamp_FunctionParams
		{
			// Token: 0x0400682C RID: 26668
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x020013C2 RID: 5058
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetPriorityOrder_FunctionParams
		{
			// Token: 0x0400682D RID: 26669
			[FieldOffset(0)]
			public int __Result;
		}

		// Token: 0x020013C3 RID: 5059
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetPreviousStateInstance_FunctionParams
		{
			// Token: 0x0400682E RID: 26670
			[FieldOffset(0)]
			public IntPtr __Result;
		}

		// Token: 0x020013C4 RID: 5060
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetNextStateInstance_FunctionParams
		{
			// Token: 0x0400682F RID: 26671
			[FieldOffset(0)]
			public IntPtr __Result;
		}

		// Token: 0x020013C5 RID: 5061
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetDestinationStateForActiveTransition_FunctionParams
		{
			// Token: 0x04006830 RID: 26672
			[FieldOffset(0)]
			public IntPtr __Result;
		}

		// Token: 0x020013C6 RID: 5062
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __GetCanEvalWithStartState_FunctionParams
		{
			// Token: 0x04006831 RID: 26673
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x020013C7 RID: 5063
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __GetCanEvaluateFromEvent_FunctionParams
		{
			// Token: 0x04006832 RID: 26674
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x020013C8 RID: 5064
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __GetCanEvaluate_FunctionParams
		{
			// Token: 0x04006833 RID: 26675
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x020013C9 RID: 5065
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __DoesTransitionPass_FunctionParams
		{
			// Token: 0x04006834 RID: 26676
			[FieldOffset(0)]
			public bool __Result;
		}
	}
}
