using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200289A RID: 10394
	[UnrealObjectPath("/Script/SMSystem.SMStateMachineNetworkedInterface")]
	public interface ISMStateMachineNetworkedInterface : IUnrealNativeInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x060268B6 RID: 157878
		int InterfaceOffset();

		// Token: 0x060268B7 RID: 157879 RVA: 0x003AC884 File Offset: 0x003AAA84
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe bool IsSimulatedProxy()
		{
			ISMStateMachineNetworkedInterface.__IsSimulatedProxy_FunctionParams* ptr = stackalloc ISMStateMachineNetworkedInterface.__IsSimulatedProxy_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(ISMStateMachineNetworkedInterface.__IsSimulatedProxy_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ISMStateMachineNetworkedInterface_ReflectionImplementationFields.__IsSimulatedProxy_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(this.NativePtr, ISMStateMachineNetworkedInterface_ReflectionImplementationFields.__IsSimulatedProxy_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x060268B8 RID: 157880 RVA: 0x003AC8CC File Offset: 0x003AAACC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe bool IsConfiguredForNetworking()
		{
			ISMStateMachineNetworkedInterface.__IsConfiguredForNetworking_FunctionParams* ptr = stackalloc ISMStateMachineNetworkedInterface.__IsConfiguredForNetworking_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(ISMStateMachineNetworkedInterface.__IsConfiguredForNetworking_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ISMStateMachineNetworkedInterface_ReflectionImplementationFields.__IsConfiguredForNetworking_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(this.NativePtr, ISMStateMachineNetworkedInterface_ReflectionImplementationFields.__IsConfiguredForNetworking_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x060268B9 RID: 157881 RVA: 0x003AC914 File Offset: 0x003AAB14
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe bool HasAuthority()
		{
			ISMStateMachineNetworkedInterface.__HasAuthority_FunctionParams* ptr = stackalloc ISMStateMachineNetworkedInterface.__HasAuthority_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(ISMStateMachineNetworkedInterface.__HasAuthority_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ISMStateMachineNetworkedInterface_ReflectionImplementationFields.__HasAuthority_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(this.NativePtr, ISMStateMachineNetworkedInterface_ReflectionImplementationFields.__HasAuthority_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x040152B5 RID: 86709
		[Nullable(1)]
		public const string __ObjectPath = "/Script/SMSystem.SMStateMachineNetworkedInterface";

		// Token: 0x02003B25 RID: 15141
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsSimulatedProxy_FunctionParams
		{
			// Token: 0x04017CC9 RID: 97481
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02003B26 RID: 15142
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsConfiguredForNetworking_FunctionParams
		{
			// Token: 0x04017CCA RID: 97482
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02003B27 RID: 15143
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __HasAuthority_FunctionParams
		{
			// Token: 0x04017CCB RID: 97483
			[FieldOffset(0)]
			public bool __Result;
		}
	}
}
