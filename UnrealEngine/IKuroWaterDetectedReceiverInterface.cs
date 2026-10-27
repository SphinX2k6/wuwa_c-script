using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200187B RID: 6267
	[UnrealObjectPath("/Script/KuroGameplayInterface.KuroWaterDetectedReceiverInterface")]
	public interface IKuroWaterDetectedReceiverInterface : IUnrealNativeInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x06017138 RID: 94520
		int InterfaceOffset();

		// Token: 0x06017139 RID: 94521 RVA: 0x0021A12C File Offset: 0x0021832C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe IKuroWaterDetectedInterface GetWaterDetectedInterface()
		{
			IKuroWaterDetectedReceiverInterface.__GetWaterDetectedInterface_FunctionParams* ptr = stackalloc IKuroWaterDetectedReceiverInterface.__GetWaterDetectedInterface_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(IKuroWaterDetectedReceiverInterface.__GetWaterDetectedInterface_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IKuroWaterDetectedReceiverInterface_ReflectionImplementationFields.__GetWaterDetectedInterface_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IKuroWaterDetectedReceiverInterface_ReflectionImplementationFields.__GetWaterDetectedInterface_NativeFunctionPtr, (void*)ptr);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer(ptr->__Result.ObjectPointer) as IKuroWaterDetectedInterface;
		}

		// Token: 0x0601713A RID: 94522 RVA: 0x0021A180 File Offset: 0x00218380
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe IKuroWaterDetectedInterface GetWaterDetectedInterface_Implementation()
		{
			IKuroWaterDetectedReceiverInterface.__GetWaterDetectedInterface_FunctionParams* ptr = stackalloc IKuroWaterDetectedReceiverInterface.__GetWaterDetectedInterface_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(IKuroWaterDetectedReceiverInterface.__GetWaterDetectedInterface_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IKuroWaterDetectedReceiverInterface_ReflectionImplementationFields.__GetWaterDetectedInterface_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(this.NativePtr, IKuroWaterDetectedReceiverInterface_ReflectionImplementationFields.__GetWaterDetectedInterface_NativeFunctionPtr, (void*)ptr, 0);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer(ptr->__Result.ObjectPointer) as IKuroWaterDetectedInterface;
		}

		// Token: 0x0601713B RID: 94523 RVA: 0x0021A1D8 File Offset: 0x002183D8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe AActor GetTargetInvoker()
		{
			IKuroWaterDetectedReceiverInterface.__GetTargetInvoker_FunctionParams* ptr = stackalloc IKuroWaterDetectedReceiverInterface.__GetTargetInvoker_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(IKuroWaterDetectedReceiverInterface.__GetTargetInvoker_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IKuroWaterDetectedReceiverInterface_ReflectionImplementationFields.__GetTargetInvoker_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IKuroWaterDetectedReceiverInterface_ReflectionImplementationFields.__GetTargetInvoker_NativeFunctionPtr, (void*)ptr);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(ptr->__Result);
		}

		// Token: 0x0601713C RID: 94524 RVA: 0x0021A224 File Offset: 0x00218424
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe AActor GetTargetInvoker_Implementation()
		{
			IKuroWaterDetectedReceiverInterface.__GetTargetInvoker_FunctionParams* ptr = stackalloc IKuroWaterDetectedReceiverInterface.__GetTargetInvoker_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(IKuroWaterDetectedReceiverInterface.__GetTargetInvoker_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IKuroWaterDetectedReceiverInterface_ReflectionImplementationFields.__GetTargetInvoker_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(this.NativePtr, IKuroWaterDetectedReceiverInterface_ReflectionImplementationFields.__GetTargetInvoker_NativeFunctionPtr, (void*)ptr, 0);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(ptr->__Result);
		}

		// Token: 0x0400C857 RID: 51287
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameplayInterface.KuroWaterDetectedReceiverInterface";

		// Token: 0x02002F80 RID: 12160
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetWaterDetectedInterface_FunctionParams
		{
			// Token: 0x04016B40 RID: 92992
			[FieldOffset(0)]
			public FScriptInterface __Result;
		}

		// Token: 0x02002F81 RID: 12161
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetTargetInvoker_FunctionParams
		{
			// Token: 0x04016B41 RID: 92993
			[FieldOffset(0)]
			public IntPtr __Result;
		}
	}
}
