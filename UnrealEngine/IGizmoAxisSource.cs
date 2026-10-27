using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001548 RID: 5448
	[UnrealObjectPath("/Script/InteractiveToolsFramework.GizmoAxisSource")]
	public interface IGizmoAxisSource : IUnrealNativeInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x06013C4B RID: 80971
		int InterfaceOffset();

		// Token: 0x06013C4C RID: 80972 RVA: 0x001D0768 File Offset: 0x001CE968
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe bool HasTangentVectors()
		{
			IGizmoAxisSource.__HasTangentVectors_FunctionParams* ptr = stackalloc IGizmoAxisSource.__HasTangentVectors_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(IGizmoAxisSource.__HasTangentVectors_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IGizmoAxisSource_ReflectionImplementationFields.__HasTangentVectors_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(this.NativePtr, IGizmoAxisSource_ReflectionImplementationFields.__HasTangentVectors_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06013C4D RID: 80973 RVA: 0x001D07B0 File Offset: 0x001CE9B0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe void GetTangentVectors(ref FVector TangentXOut, ref FVector TangentYOut)
		{
			IGizmoAxisSource.__GetTangentVectors_FunctionParams* ptr = stackalloc IGizmoAxisSource.__GetTangentVectors_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(IGizmoAxisSource.__GetTangentVectors_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IGizmoAxisSource_ReflectionImplementationFields.__GetTangentVectors_NativeFunctionPtr, (void*)ptr, 1);
			ptr->TangentXOut = TangentXOut;
			ptr->TangentYOut = TangentYOut;
			UnrealReflectionUtils.CallUFunction(this.NativePtr, IGizmoAxisSource_ReflectionImplementationFields.__GetTangentVectors_NativeFunctionPtr, (void*)ptr, 0);
			TangentXOut = ptr->TangentXOut;
			TangentYOut = ptr->TangentYOut;
		}

		// Token: 0x06013C4E RID: 80974 RVA: 0x001D0820 File Offset: 0x001CEA20
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe FVector GetOrigin()
		{
			IGizmoAxisSource.__GetOrigin_FunctionParams* ptr = stackalloc IGizmoAxisSource.__GetOrigin_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(IGizmoAxisSource.__GetOrigin_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IGizmoAxisSource_ReflectionImplementationFields.__GetOrigin_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(this.NativePtr, IGizmoAxisSource_ReflectionImplementationFields.__GetOrigin_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06013C4F RID: 80975 RVA: 0x001D0868 File Offset: 0x001CEA68
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe FVector GetDirection()
		{
			IGizmoAxisSource.__GetDirection_FunctionParams* ptr = stackalloc IGizmoAxisSource.__GetDirection_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(IGizmoAxisSource.__GetDirection_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IGizmoAxisSource_ReflectionImplementationFields.__GetDirection_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(this.NativePtr, IGizmoAxisSource_ReflectionImplementationFields.__GetDirection_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0400AB1C RID: 43804
		[Nullable(1)]
		public const string __ObjectPath = "/Script/InteractiveToolsFramework.GizmoAxisSource";

		// Token: 0x02002EB4 RID: 11956
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __HasTangentVectors_FunctionParams
		{
			// Token: 0x040169B0 RID: 92592
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02002EB5 RID: 11957
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __GetTangentVectors_FunctionParams
		{
			// Token: 0x040169B1 RID: 92593
			[FieldOffset(0)]
			public FVector TangentXOut;

			// Token: 0x040169B2 RID: 92594
			[FieldOffset(12)]
			public FVector TangentYOut;
		}

		// Token: 0x02002EB6 RID: 11958
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __GetOrigin_FunctionParams
		{
			// Token: 0x040169B3 RID: 92595
			[FieldOffset(0)]
			public FVector __Result;
		}

		// Token: 0x02002EB7 RID: 11959
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __GetDirection_FunctionParams
		{
			// Token: 0x040169B4 RID: 92596
			[FieldOffset(0)]
			public FVector __Result;
		}
	}
}
