using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002898 RID: 10392
	[UnrealObjectPath("/Script/SMSystem.SMStateMachineInstance")]
	[UnrealStructLayout(296, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 296)]
	public class USMStateMachineInstance : USMStateInstance_Base, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060268A1 RID: 157857 RVA: 0x003AC39C File Offset: 0x003AA59C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USMStateMachineInstance._ClassPtr;
		}

		// Token: 0x060268A2 RID: 157858 RVA: 0x003AC3A8 File Offset: 0x003AA5A8
		public USMStateMachineInstance() : this(BuiltinUtils.AllocNativeUObject(USMStateMachineInstance.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060268A3 RID: 157859 RVA: 0x003AC3D0 File Offset: 0x003AA5D0
		[NullableContext(1)]
		public USMStateMachineInstance(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USMStateMachineInstance.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700949F RID: 38047
		// (get) Token: 0x060268A4 RID: 157860 RVA: 0x003AC404 File Offset: 0x003AA604
		// (set) Token: 0x060268A5 RID: 157861 RVA: 0x003AC43D File Offset: 0x003AA63D
		[Nullable(1)]
		public TArray<USMStateInstance_Base> Children
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<USMStateInstance_Base> result;
				if ((result = this._Children) == null)
				{
					result = (this._Children = new TArray<USMStateInstance_Base>(base.NativePtr + (IntPtr)USMStateMachineInstance.__PropertyOffset_Children, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Children.CopyAssign(value);
			}
		}

		// Token: 0x170094A0 RID: 38048
		// (get) Token: 0x060268A6 RID: 157862 RVA: 0x003AC44C File Offset: 0x003AA64C
		// (set) Token: 0x060268A7 RID: 157863 RVA: 0x003AC485 File Offset: 0x003AA685
		[Nullable(1)]
		public TArray<USMTransitionInstance> TransitionList
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<USMTransitionInstance> result;
				if ((result = this._TransitionList) == null)
				{
					result = (this._TransitionList = new TArray<USMTransitionInstance>(base.NativePtr + (IntPtr)USMStateMachineInstance.__PropertyOffset_TransitionList, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.TransitionList.CopyAssign(value);
			}
		}

		// Token: 0x060268A8 RID: 157864 RVA: 0x003AC494 File Offset: 0x003AA694
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetWaitForEndState(bool bValue)
		{
			USMStateMachineInstance.__SetWaitForEndState_FunctionParams* ptr = stackalloc USMStateMachineInstance.__SetWaitForEndState_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(USMStateMachineInstance.__SetWaitForEndState_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMStateMachineInstance.__SetWaitForEndState_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bValue = bValue;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMStateMachineInstance.__SetWaitForEndState_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060268A9 RID: 157865 RVA: 0x003AC4DC File Offset: 0x003AA6DC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetReuseIfNotEndState(bool bValue)
		{
			USMStateMachineInstance.__SetReuseIfNotEndState_FunctionParams* ptr = stackalloc USMStateMachineInstance.__SetReuseIfNotEndState_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(USMStateMachineInstance.__SetReuseIfNotEndState_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMStateMachineInstance.__SetReuseIfNotEndState_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bValue = bValue;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMStateMachineInstance.__SetReuseIfNotEndState_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060268AA RID: 157866 RVA: 0x003AC524 File Offset: 0x003AA724
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetReuseCurrentState(bool bValue)
		{
			USMStateMachineInstance.__SetReuseCurrentState_FunctionParams* ptr = stackalloc USMStateMachineInstance.__SetReuseCurrentState_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(USMStateMachineInstance.__SetReuseCurrentState_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMStateMachineInstance.__SetReuseCurrentState_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bValue = bValue;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMStateMachineInstance.__SetReuseCurrentState_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060268AB RID: 157867 RVA: 0x003AC56C File Offset: 0x003AA76C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool GetWaitForEndState()
		{
			USMStateMachineInstance.__GetWaitForEndState_FunctionParams* ptr = stackalloc USMStateMachineInstance.__GetWaitForEndState_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(USMStateMachineInstance.__GetWaitForEndState_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMStateMachineInstance.__GetWaitForEndState_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMStateMachineInstance.__GetWaitForEndState_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x060268AC RID: 157868 RVA: 0x003AC5B4 File Offset: 0x003AA7B4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe USMInstance GetStateMachineReference()
		{
			USMStateMachineInstance.__GetStateMachineReference_FunctionParams* ptr = stackalloc USMStateMachineInstance.__GetStateMachineReference_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(USMStateMachineInstance.__GetStateMachineReference_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMStateMachineInstance.__GetStateMachineReference_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMStateMachineInstance.__GetStateMachineReference_NativeFunctionPtr, (void*)ptr, 0);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<USMInstance>(ptr->__Result);
		}

		// Token: 0x060268AD RID: 157869 RVA: 0x003AC600 File Offset: 0x003AA800
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool GetReuseIfNotEndState()
		{
			USMStateMachineInstance.__GetReuseIfNotEndState_FunctionParams* ptr = stackalloc USMStateMachineInstance.__GetReuseIfNotEndState_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(USMStateMachineInstance.__GetReuseIfNotEndState_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMStateMachineInstance.__GetReuseIfNotEndState_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMStateMachineInstance.__GetReuseIfNotEndState_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x060268AE RID: 157870 RVA: 0x003AC648 File Offset: 0x003AA848
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool GetReuseCurrentState()
		{
			USMStateMachineInstance.__GetReuseCurrentState_FunctionParams* ptr = stackalloc USMStateMachineInstance.__GetReuseCurrentState_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(USMStateMachineInstance.__GetReuseCurrentState_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMStateMachineInstance.__GetReuseCurrentState_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMStateMachineInstance.__GetReuseCurrentState_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x060268AF RID: 157871 RVA: 0x003AC690 File Offset: 0x003AA890
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void GetEntryStates([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<USMStateInstance_Base> EntryStates)
		{
			USMStateMachineInstance.__GetEntryStates_FunctionParams* ptr = stackalloc USMStateMachineInstance.__GetEntryStates_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(USMStateMachineInstance.__GetEntryStates_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMStateMachineInstance.__GetEntryStates_NativeFunctionPtr, (void*)ptr, 1);
			TArray<USMStateInstance_Base> tarray = EntryStates;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->EntryStates);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMStateMachineInstance.__GetEntryStates_NativeFunctionPtr, (void*)ptr, 0);
			TArray<USMStateInstance_Base> tarray2 = EntryStates;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->EntryStates);
			}
			UnrealReflectionUtils.DestroyStruct(USMStateMachineInstance.__GetEntryStates_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060268B0 RID: 157872 RVA: 0x003AC70C File Offset: 0x003AA90C
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		[return: Nullable(2)]
		public unsafe USMStateInstance_Base GetContainedStateByName(string StateName)
		{
			USMStateMachineInstance.__GetContainedStateByName_FunctionParams* ptr = stackalloc USMStateMachineInstance.__GetContainedStateByName_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(USMStateMachineInstance.__GetContainedStateByName_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMStateMachineInstance.__GetContainedStateByName_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->StateName), StateName);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMStateMachineInstance.__GetContainedStateByName_NativeFunctionPtr, (void*)ptr, 0);
			USMStateInstance_Base orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USMStateInstance_Base>(ptr->__Result);
			UnrealReflectionUtils.DestroyStruct(USMStateMachineInstance.__GetContainedStateByName_NativeFunctionPtr, (void*)ptr, 1);
			return orCreateUObjectByNativePointer;
		}

		// Token: 0x060268B1 RID: 157873 RVA: 0x003AC778 File Offset: 0x003AA978
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void GetAllStateInstances([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<USMStateInstance_Base> StateInstances)
		{
			USMStateMachineInstance.__GetAllStateInstances_FunctionParams* ptr = stackalloc USMStateMachineInstance.__GetAllStateInstances_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(USMStateMachineInstance.__GetAllStateInstances_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMStateMachineInstance.__GetAllStateInstances_NativeFunctionPtr, (void*)ptr, 1);
			TArray<USMStateInstance_Base> tarray = StateInstances;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->StateInstances);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMStateMachineInstance.__GetAllStateInstances_NativeFunctionPtr, (void*)ptr, 0);
			TArray<USMStateInstance_Base> tarray2 = StateInstances;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->StateInstances);
			}
			UnrealReflectionUtils.DestroyStruct(USMStateMachineInstance.__GetAllStateInstances_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060268B2 RID: 157874 RVA: 0x003AC7F4 File Offset: 0x003AA9F4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void GetActiveStates([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<USMStateInstance_Base> ActiveStates)
		{
			USMStateMachineInstance.__GetActiveStates_FunctionParams* ptr = stackalloc USMStateMachineInstance.__GetActiveStates_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(USMStateMachineInstance.__GetActiveStates_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMStateMachineInstance.__GetActiveStates_NativeFunctionPtr, (void*)ptr, 1);
			TArray<USMStateInstance_Base> tarray = ActiveStates;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->ActiveStates);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMStateMachineInstance.__GetActiveStates_NativeFunctionPtr, (void*)ptr, 0);
			TArray<USMStateInstance_Base> tarray2 = ActiveStates;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->ActiveStates);
			}
			UnrealReflectionUtils.DestroyStruct(USMStateMachineInstance.__GetActiveStates_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060268B3 RID: 157875 RVA: 0x003AC86D File Offset: 0x003AAA6D
		static USMStateMachineInstance()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SMSystem.SMStateMachineInstance");
		}

		// Token: 0x060268B4 RID: 157876 RVA: 0x003AC87B File Offset: 0x003AAA7B
		protected USMStateMachineInstance(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040152A2 RID: 86690
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/SMSystem.SMStateMachineInstance";

		// Token: 0x040152A3 RID: 86691
		private static IntPtr _ClassPtr;

		// Token: 0x040152A4 RID: 86692
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040152A5 RID: 86693
		internal static int __PropertyOffset_Children;

		// Token: 0x040152A6 RID: 86694
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<USMStateInstance_Base> _Children;

		// Token: 0x040152A7 RID: 86695
		internal static int __PropertyOffset_TransitionList;

		// Token: 0x040152A8 RID: 86696
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<USMTransitionInstance> _TransitionList;

		// Token: 0x040152A9 RID: 86697
		private static IntPtr __SetWaitForEndState_NativeFunctionPtr;

		// Token: 0x040152AA RID: 86698
		private static IntPtr __SetReuseIfNotEndState_NativeFunctionPtr;

		// Token: 0x040152AB RID: 86699
		private static IntPtr __SetReuseCurrentState_NativeFunctionPtr;

		// Token: 0x040152AC RID: 86700
		private static IntPtr __GetWaitForEndState_NativeFunctionPtr;

		// Token: 0x040152AD RID: 86701
		private static IntPtr __GetStateMachineReference_NativeFunctionPtr;

		// Token: 0x040152AE RID: 86702
		private static IntPtr __GetReuseIfNotEndState_NativeFunctionPtr;

		// Token: 0x040152AF RID: 86703
		private static IntPtr __GetReuseCurrentState_NativeFunctionPtr;

		// Token: 0x040152B0 RID: 86704
		private static IntPtr __GetEntryStates_NativeFunctionPtr;

		// Token: 0x040152B1 RID: 86705
		private static IntPtr __GetContainedStateByName_NativeFunctionPtr;

		// Token: 0x040152B2 RID: 86706
		private static IntPtr __GetAllStateInstances_NativeFunctionPtr;

		// Token: 0x040152B3 RID: 86707
		private static IntPtr __GetActiveStates_NativeFunctionPtr;

		// Token: 0x02003B1A RID: 15130
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetWaitForEndState_FunctionParams
		{
			// Token: 0x04017CBD RID: 97469
			[FieldOffset(0)]
			public bool bValue;
		}

		// Token: 0x02003B1B RID: 15131
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetReuseIfNotEndState_FunctionParams
		{
			// Token: 0x04017CBE RID: 97470
			[FieldOffset(0)]
			public bool bValue;
		}

		// Token: 0x02003B1C RID: 15132
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetReuseCurrentState_FunctionParams
		{
			// Token: 0x04017CBF RID: 97471
			[FieldOffset(0)]
			public bool bValue;
		}

		// Token: 0x02003B1D RID: 15133
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __GetWaitForEndState_FunctionParams
		{
			// Token: 0x04017CC0 RID: 97472
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02003B1E RID: 15134
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetStateMachineReference_FunctionParams
		{
			// Token: 0x04017CC1 RID: 97473
			[FieldOffset(0)]
			public IntPtr __Result;
		}

		// Token: 0x02003B1F RID: 15135
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __GetReuseIfNotEndState_FunctionParams
		{
			// Token: 0x04017CC2 RID: 97474
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02003B20 RID: 15136
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __GetReuseCurrentState_FunctionParams
		{
			// Token: 0x04017CC3 RID: 97475
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02003B21 RID: 15137
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetEntryStates_FunctionParams
		{
			// Token: 0x04017CC4 RID: 97476
			[FieldOffset(0)]
			public byte EntryStates;
		}

		// Token: 0x02003B22 RID: 15138
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __GetContainedStateByName_FunctionParams
		{
			// Token: 0x04017CC5 RID: 97477
			[FieldOffset(0)]
			public FString StateName;

			// Token: 0x04017CC6 RID: 97478
			[FieldOffset(16)]
			public IntPtr __Result;
		}

		// Token: 0x02003B23 RID: 15139
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetAllStateInstances_FunctionParams
		{
			// Token: 0x04017CC7 RID: 97479
			[FieldOffset(0)]
			public byte StateInstances;
		}

		// Token: 0x02003B24 RID: 15140
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetActiveStates_FunctionParams
		{
			// Token: 0x04017CC8 RID: 97480
			[FieldOffset(0)]
			public byte ActiveStates;
		}
	}
}
