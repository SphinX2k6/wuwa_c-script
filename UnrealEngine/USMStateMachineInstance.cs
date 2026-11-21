using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000835 RID: 2101
	[UnrealObjectPath("/Script/SMSystem.SMStateMachineInstance")]
	[UnrealStructLayout(296, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 296)]
	public class USMStateMachineInstance : USMStateInstance_Base, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600B751 RID: 46929 RVA: 0x00125691 File Offset: 0x00123891
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USMStateMachineInstance._ClassPtr;
		}

		// Token: 0x0600B752 RID: 46930 RVA: 0x001256A0 File Offset: 0x001238A0
		public USMStateMachineInstance() : this(BuiltinUtils.AllocNativeUObject(USMStateMachineInstance.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600B753 RID: 46931 RVA: 0x001256C8 File Offset: 0x001238C8
		[NullableContext(1)]
		public USMStateMachineInstance(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USMStateMachineInstance.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002241 RID: 8769
		// (get) Token: 0x0600B754 RID: 46932 RVA: 0x001256FC File Offset: 0x001238FC
		// (set) Token: 0x0600B755 RID: 46933 RVA: 0x00125735 File Offset: 0x00123935
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

		// Token: 0x17002242 RID: 8770
		// (get) Token: 0x0600B756 RID: 46934 RVA: 0x00125744 File Offset: 0x00123944
		// (set) Token: 0x0600B757 RID: 46935 RVA: 0x0012577D File Offset: 0x0012397D
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

		// Token: 0x0600B758 RID: 46936 RVA: 0x0012578C File Offset: 0x0012398C
		[SkipLocalsInit]
		public unsafe void SetWaitForEndState(bool bValue)
		{
			USMStateMachineInstance.__SetWaitForEndState_FunctionParams* ptr = stackalloc USMStateMachineInstance.__SetWaitForEndState_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(USMStateMachineInstance.__SetWaitForEndState_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMStateMachineInstance.__SetWaitForEndState_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bValue = bValue;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMStateMachineInstance.__SetWaitForEndState_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600B759 RID: 46937 RVA: 0x001257D4 File Offset: 0x001239D4
		[SkipLocalsInit]
		public unsafe void SetReuseIfNotEndState(bool bValue)
		{
			USMStateMachineInstance.__SetReuseIfNotEndState_FunctionParams* ptr = stackalloc USMStateMachineInstance.__SetReuseIfNotEndState_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(USMStateMachineInstance.__SetReuseIfNotEndState_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMStateMachineInstance.__SetReuseIfNotEndState_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bValue = bValue;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMStateMachineInstance.__SetReuseIfNotEndState_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600B75A RID: 46938 RVA: 0x0012581C File Offset: 0x00123A1C
		[SkipLocalsInit]
		public unsafe void SetReuseCurrentState(bool bValue)
		{
			USMStateMachineInstance.__SetReuseCurrentState_FunctionParams* ptr = stackalloc USMStateMachineInstance.__SetReuseCurrentState_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(USMStateMachineInstance.__SetReuseCurrentState_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMStateMachineInstance.__SetReuseCurrentState_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bValue = bValue;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMStateMachineInstance.__SetReuseCurrentState_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600B75B RID: 46939 RVA: 0x00125864 File Offset: 0x00123A64
		[SkipLocalsInit]
		public unsafe bool GetWaitForEndState()
		{
			USMStateMachineInstance.__GetWaitForEndState_FunctionParams* ptr = stackalloc USMStateMachineInstance.__GetWaitForEndState_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(USMStateMachineInstance.__GetWaitForEndState_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMStateMachineInstance.__GetWaitForEndState_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMStateMachineInstance.__GetWaitForEndState_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0600B75C RID: 46940 RVA: 0x001258AC File Offset: 0x00123AAC
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe USMInstance GetStateMachineReference()
		{
			USMStateMachineInstance.__GetStateMachineReference_FunctionParams* ptr = stackalloc USMStateMachineInstance.__GetStateMachineReference_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(USMStateMachineInstance.__GetStateMachineReference_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMStateMachineInstance.__GetStateMachineReference_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMStateMachineInstance.__GetStateMachineReference_NativeFunctionPtr, (void*)ptr);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<USMInstance>(ptr->__Result);
		}

		// Token: 0x0600B75D RID: 46941 RVA: 0x001258F8 File Offset: 0x00123AF8
		[SkipLocalsInit]
		public unsafe bool GetReuseIfNotEndState()
		{
			USMStateMachineInstance.__GetReuseIfNotEndState_FunctionParams* ptr = stackalloc USMStateMachineInstance.__GetReuseIfNotEndState_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(USMStateMachineInstance.__GetReuseIfNotEndState_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMStateMachineInstance.__GetReuseIfNotEndState_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMStateMachineInstance.__GetReuseIfNotEndState_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0600B75E RID: 46942 RVA: 0x00125940 File Offset: 0x00123B40
		[SkipLocalsInit]
		public unsafe bool GetReuseCurrentState()
		{
			USMStateMachineInstance.__GetReuseCurrentState_FunctionParams* ptr = stackalloc USMStateMachineInstance.__GetReuseCurrentState_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(USMStateMachineInstance.__GetReuseCurrentState_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMStateMachineInstance.__GetReuseCurrentState_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMStateMachineInstance.__GetReuseCurrentState_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0600B75F RID: 46943 RVA: 0x00125988 File Offset: 0x00123B88
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMStateMachineInstance.__GetEntryStates_NativeFunctionPtr, (void*)ptr);
			TArray<USMStateInstance_Base> tarray2 = EntryStates;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->EntryStates);
			}
			UnrealReflectionUtils.DestroyStruct(USMStateMachineInstance.__GetEntryStates_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B760 RID: 46944 RVA: 0x00125A00 File Offset: 0x00123C00
		[NullableContext(1)]
		[SkipLocalsInit]
		[return: Nullable(2)]
		public unsafe USMStateInstance_Base GetContainedStateByName(string StateName)
		{
			USMStateMachineInstance.__GetContainedStateByName_FunctionParams* ptr = stackalloc USMStateMachineInstance.__GetContainedStateByName_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(USMStateMachineInstance.__GetContainedStateByName_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMStateMachineInstance.__GetContainedStateByName_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->StateName), StateName);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMStateMachineInstance.__GetContainedStateByName_NativeFunctionPtr, (void*)ptr);
			USMStateInstance_Base orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USMStateInstance_Base>(ptr->__Result);
			UnrealReflectionUtils.DestroyStruct(USMStateMachineInstance.__GetContainedStateByName_NativeFunctionPtr, (void*)ptr, 1);
			return orCreateUObjectByNativePointer;
		}

		// Token: 0x0600B761 RID: 46945 RVA: 0x00125A68 File Offset: 0x00123C68
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMStateMachineInstance.__GetAllStateInstances_NativeFunctionPtr, (void*)ptr);
			TArray<USMStateInstance_Base> tarray2 = StateInstances;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->StateInstances);
			}
			UnrealReflectionUtils.DestroyStruct(USMStateMachineInstance.__GetAllStateInstances_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B762 RID: 46946 RVA: 0x00125AE0 File Offset: 0x00123CE0
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMStateMachineInstance.__GetActiveStates_NativeFunctionPtr, (void*)ptr);
			TArray<USMStateInstance_Base> tarray2 = ActiveStates;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->ActiveStates);
			}
			UnrealReflectionUtils.DestroyStruct(USMStateMachineInstance.__GetActiveStates_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B763 RID: 46947 RVA: 0x00125B58 File Offset: 0x00123D58
		static USMStateMachineInstance()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SMSystem.SMStateMachineInstance");
		}

		// Token: 0x0600B764 RID: 46948 RVA: 0x00125B66 File Offset: 0x00123D66
		protected USMStateMachineInstance(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400533F RID: 21311
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/SMSystem.SMStateMachineInstance";

		// Token: 0x04005340 RID: 21312
		private static IntPtr _ClassPtr;

		// Token: 0x04005341 RID: 21313
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04005342 RID: 21314
		internal static int __PropertyOffset_Children;

		// Token: 0x04005343 RID: 21315
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<USMStateInstance_Base> _Children;

		// Token: 0x04005344 RID: 21316
		internal static int __PropertyOffset_TransitionList;

		// Token: 0x04005345 RID: 21317
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<USMTransitionInstance> _TransitionList;

		// Token: 0x04005346 RID: 21318
		private static IntPtr __SetWaitForEndState_NativeFunctionPtr;

		// Token: 0x04005347 RID: 21319
		private static IntPtr __SetReuseIfNotEndState_NativeFunctionPtr;

		// Token: 0x04005348 RID: 21320
		private static IntPtr __SetReuseCurrentState_NativeFunctionPtr;

		// Token: 0x04005349 RID: 21321
		private static IntPtr __GetWaitForEndState_NativeFunctionPtr;

		// Token: 0x0400534A RID: 21322
		private static IntPtr __GetStateMachineReference_NativeFunctionPtr;

		// Token: 0x0400534B RID: 21323
		private static IntPtr __GetReuseIfNotEndState_NativeFunctionPtr;

		// Token: 0x0400534C RID: 21324
		private static IntPtr __GetReuseCurrentState_NativeFunctionPtr;

		// Token: 0x0400534D RID: 21325
		private static IntPtr __GetEntryStates_NativeFunctionPtr;

		// Token: 0x0400534E RID: 21326
		private static IntPtr __GetContainedStateByName_NativeFunctionPtr;

		// Token: 0x0400534F RID: 21327
		private static IntPtr __GetAllStateInstances_NativeFunctionPtr;

		// Token: 0x04005350 RID: 21328
		private static IntPtr __GetActiveStates_NativeFunctionPtr;

		// Token: 0x020013B0 RID: 5040
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetWaitForEndState_FunctionParams
		{
			// Token: 0x0400681A RID: 26650
			[FieldOffset(0)]
			public bool bValue;
		}

		// Token: 0x020013B1 RID: 5041
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetReuseIfNotEndState_FunctionParams
		{
			// Token: 0x0400681B RID: 26651
			[FieldOffset(0)]
			public bool bValue;
		}

		// Token: 0x020013B2 RID: 5042
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetReuseCurrentState_FunctionParams
		{
			// Token: 0x0400681C RID: 26652
			[FieldOffset(0)]
			public bool bValue;
		}

		// Token: 0x020013B3 RID: 5043
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __GetWaitForEndState_FunctionParams
		{
			// Token: 0x0400681D RID: 26653
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x020013B4 RID: 5044
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetStateMachineReference_FunctionParams
		{
			// Token: 0x0400681E RID: 26654
			[FieldOffset(0)]
			public IntPtr __Result;
		}

		// Token: 0x020013B5 RID: 5045
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __GetReuseIfNotEndState_FunctionParams
		{
			// Token: 0x0400681F RID: 26655
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x020013B6 RID: 5046
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __GetReuseCurrentState_FunctionParams
		{
			// Token: 0x04006820 RID: 26656
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x020013B7 RID: 5047
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetEntryStates_FunctionParams
		{
			// Token: 0x04006821 RID: 26657
			[FieldOffset(0)]
			public byte EntryStates;
		}

		// Token: 0x020013B8 RID: 5048
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __GetContainedStateByName_FunctionParams
		{
			// Token: 0x04006822 RID: 26658
			[FieldOffset(0)]
			public FString StateName;

			// Token: 0x04006823 RID: 26659
			[FieldOffset(16)]
			public IntPtr __Result;
		}

		// Token: 0x020013B9 RID: 5049
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetAllStateInstances_FunctionParams
		{
			// Token: 0x04006824 RID: 26660
			[FieldOffset(0)]
			public byte StateInstances;
		}

		// Token: 0x020013BA RID: 5050
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetActiveStates_FunctionParams
		{
			// Token: 0x04006825 RID: 26661
			[FieldOffset(0)]
			public byte ActiveStates;
		}
	}
}
