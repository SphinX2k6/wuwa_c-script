using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200288D RID: 10381
	[UnrealObjectPath("/Script/SMSystem.SMNodeInstance")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public abstract class USMNodeInstance : UObject, IUnrealUObject, IUnrealObject, ISMInstanceInterface, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x0602673A RID: 157498 RVA: 0x003A8933 File Offset: 0x003A6B33
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USMNodeInstance._ClassPtr;
		}

		// Token: 0x0602673B RID: 157499 RVA: 0x003A893F File Offset: 0x003A6B3F
		int ISMInstanceInterface.InterfaceOffset()
		{
			return USMNodeInstance.__InterfaceOffset_ISMInstanceInterface;
		}

		// Token: 0x1700943A RID: 37946
		// (get) Token: 0x0602673C RID: 157500 RVA: 0x003A8946 File Offset: 0x003A6B46
		// (set) Token: 0x0602673D RID: 157501 RVA: 0x003A895A File Offset: 0x003A6B5A
		public unsafe FGuid TemplateGuid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USMNodeInstance.__PropertyOffset_TemplateGuid);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USMNodeInstance.__PropertyOffset_TemplateGuid) = value;
			}
		}

		// Token: 0x0602673E RID: 157502 RVA: 0x003A8970 File Offset: 0x003A6B70
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool IsInEndState()
		{
			USMNodeInstance.__IsInEndState_FunctionParams* ptr = stackalloc USMNodeInstance.__IsInEndState_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(USMNodeInstance.__IsInEndState_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMNodeInstance.__IsInEndState_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMNodeInstance.__IsInEndState_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0602673F RID: 157503 RVA: 0x003A89B8 File Offset: 0x003A6BB8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool IsActive()
		{
			USMNodeInstance.__IsActive_FunctionParams* ptr = stackalloc USMNodeInstance.__IsActive_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(USMNodeInstance.__IsActive_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMNodeInstance.__IsActive_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMNodeInstance.__IsActive_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06026740 RID: 157504 RVA: 0x003A8A00 File Offset: 0x003A6C00
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool HasUpdated()
		{
			USMNodeInstance.__HasUpdated_FunctionParams* ptr = stackalloc USMNodeInstance.__HasUpdated_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(USMNodeInstance.__HasUpdated_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMNodeInstance.__HasUpdated_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMNodeInstance.__HasUpdated_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06026741 RID: 157505 RVA: 0x003A8A48 File Offset: 0x003A6C48
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe float GetTimeInState()
		{
			USMNodeInstance.__GetTimeInState_FunctionParams* ptr = stackalloc USMNodeInstance.__GetTimeInState_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(USMNodeInstance.__GetTimeInState_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMNodeInstance.__GetTimeInState_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMNodeInstance.__GetTimeInState_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06026742 RID: 157506 RVA: 0x003A8A90 File Offset: 0x003A6C90
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe USMInstance GetStateMachineInstance(bool bTopMostInstance = false)
		{
			USMNodeInstance.__GetStateMachineInstance_FunctionParams* ptr = stackalloc USMNodeInstance.__GetStateMachineInstance_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(USMNodeInstance.__GetStateMachineInstance_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMNodeInstance.__GetStateMachineInstance_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bTopMostInstance = bTopMostInstance;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMNodeInstance.__GetStateMachineInstance_NativeFunctionPtr, (void*)ptr, 0);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<USMInstance>(ptr->__Result);
		}

		// Token: 0x06026743 RID: 157507 RVA: 0x003A8AE4 File Offset: 0x003A6CE4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe USMStateMachineInstance GetOwningStateMachineNodeInstance()
		{
			USMNodeInstance.__GetOwningStateMachineNodeInstance_FunctionParams* ptr = stackalloc USMNodeInstance.__GetOwningStateMachineNodeInstance_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(USMNodeInstance.__GetOwningStateMachineNodeInstance_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMNodeInstance.__GetOwningStateMachineNodeInstance_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMNodeInstance.__GetOwningStateMachineNodeInstance_NativeFunctionPtr, (void*)ptr, 0);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<USMStateMachineInstance>(ptr->__Result);
		}

		// Token: 0x06026744 RID: 157508 RVA: 0x003A8B30 File Offset: 0x003A6D30
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe string GetNodeName()
		{
			USMNodeInstance.__GetNodeName_FunctionParams* ptr = stackalloc USMNodeInstance.__GetNodeName_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(USMNodeInstance.__GetNodeName_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMNodeInstance.__GetNodeName_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMNodeInstance.__GetNodeName_NativeFunctionPtr, (void*)ptr, 0);
			string result = FString.ToString((void*)(&ptr->__Result));
			UnrealReflectionUtils.DestroyStruct(USMNodeInstance.__GetNodeName_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06026745 RID: 157509 RVA: 0x003A8B90 File Offset: 0x003A6D90
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe ISMStateMachineNetworkedInterface GetNetworkInterface()
		{
			USMNodeInstance.__GetNetworkInterface_FunctionParams* ptr = stackalloc USMNodeInstance.__GetNetworkInterface_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(USMNodeInstance.__GetNetworkInterface_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMNodeInstance.__GetNetworkInterface_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMNodeInstance.__GetNetworkInterface_NativeFunctionPtr, (void*)ptr, 0);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer(ptr->__Result.ObjectPointer) as ISMStateMachineNetworkedInterface;
		}

		// Token: 0x06026746 RID: 157510 RVA: 0x003A8BE8 File Offset: 0x003A6DE8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe FGuid GetGuid()
		{
			USMNodeInstance.__GetGuid_FunctionParams* ptr = stackalloc USMNodeInstance.__GetGuid_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(USMNodeInstance.__GetGuid_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMNodeInstance.__GetGuid_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMNodeInstance.__GetGuid_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06026747 RID: 157511 RVA: 0x003A8C30 File Offset: 0x003A6E30
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe UObject GetContext()
		{
			USMNodeInstance.__GetContext_FunctionParams* ptr = stackalloc USMNodeInstance.__GetContext_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(USMNodeInstance.__GetContext_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMNodeInstance.__GetContext_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMNodeInstance.__GetContext_NativeFunctionPtr, (void*)ptr, 0);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(ptr->__Result);
		}

		// Token: 0x06026748 RID: 157512 RVA: 0x003A8C7B File Offset: 0x003A6E7B
		static USMNodeInstance()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SMSystem.SMNodeInstance");
		}

		// Token: 0x06026749 RID: 157513 RVA: 0x003A8C8C File Offset: 0x003A6E8C
		protected USMNodeInstance() : this(BuiltinUtils.AllocNativeUObject(USMNodeInstance.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602674A RID: 157514 RVA: 0x003A8CB4 File Offset: 0x003A6EB4
		protected USMNodeInstance(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401519F RID: 86431
		internal static int __InterfaceOffset_ISMInstanceInterface;

		// Token: 0x040151A0 RID: 86432
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/SMSystem.SMNodeInstance";

		// Token: 0x040151A1 RID: 86433
		private static IntPtr _ClassPtr;

		// Token: 0x040151A2 RID: 86434
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040151A3 RID: 86435
		internal static int __PropertyOffset_TemplateGuid;

		// Token: 0x040151A4 RID: 86436
		private static IntPtr __IsInEndState_NativeFunctionPtr;

		// Token: 0x040151A5 RID: 86437
		private static IntPtr __IsActive_NativeFunctionPtr;

		// Token: 0x040151A6 RID: 86438
		private static IntPtr __HasUpdated_NativeFunctionPtr;

		// Token: 0x040151A7 RID: 86439
		private static IntPtr __GetTimeInState_NativeFunctionPtr;

		// Token: 0x040151A8 RID: 86440
		private static IntPtr __GetStateMachineInstance_NativeFunctionPtr;

		// Token: 0x040151A9 RID: 86441
		private static IntPtr __GetOwningStateMachineNodeInstance_NativeFunctionPtr;

		// Token: 0x040151AA RID: 86442
		private static IntPtr __GetNodeName_NativeFunctionPtr;

		// Token: 0x040151AB RID: 86443
		private static IntPtr __GetNetworkInterface_NativeFunctionPtr;

		// Token: 0x040151AC RID: 86444
		private static IntPtr __GetGuid_NativeFunctionPtr;

		// Token: 0x040151AD RID: 86445
		private static IntPtr __GetContext_NativeFunctionPtr;

		// Token: 0x02003AD0 RID: 15056
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsInEndState_FunctionParams
		{
			// Token: 0x04017C59 RID: 97369
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02003AD1 RID: 15057
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsActive_FunctionParams
		{
			// Token: 0x04017C5A RID: 97370
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02003AD2 RID: 15058
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __HasUpdated_FunctionParams
		{
			// Token: 0x04017C5B RID: 97371
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02003AD3 RID: 15059
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetTimeInState_FunctionParams
		{
			// Token: 0x04017C5C RID: 97372
			[FieldOffset(0)]
			public float __Result;
		}

		// Token: 0x02003AD4 RID: 15060
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetStateMachineInstance_FunctionParams
		{
			// Token: 0x04017C5D RID: 97373
			[FieldOffset(0)]
			public bool bTopMostInstance;

			// Token: 0x04017C5E RID: 97374
			[FieldOffset(8)]
			public IntPtr __Result;
		}

		// Token: 0x02003AD5 RID: 15061
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetOwningStateMachineNodeInstance_FunctionParams
		{
			// Token: 0x04017C5F RID: 97375
			[FieldOffset(0)]
			public IntPtr __Result;
		}

		// Token: 0x02003AD6 RID: 15062
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetNodeName_FunctionParams
		{
			// Token: 0x04017C60 RID: 97376
			[FieldOffset(0)]
			public FString __Result;
		}

		// Token: 0x02003AD7 RID: 15063
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetNetworkInterface_FunctionParams
		{
			// Token: 0x04017C61 RID: 97377
			[FieldOffset(0)]
			public FScriptInterface __Result;
		}

		// Token: 0x02003AD8 RID: 15064
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetGuid_FunctionParams
		{
			// Token: 0x04017C62 RID: 97378
			[FieldOffset(0)]
			public FGuid __Result;
		}

		// Token: 0x02003AD9 RID: 15065
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetContext_FunctionParams
		{
			// Token: 0x04017C63 RID: 97379
			[FieldOffset(0)]
			public IntPtr __Result;
		}
	}
}
