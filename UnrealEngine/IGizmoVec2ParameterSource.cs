using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200156A RID: 5482
	[UnrealObjectPath("/Script/InteractiveToolsFramework.GizmoVec2ParameterSource")]
	public interface IGizmoVec2ParameterSource : IUnrealNativeInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x06013DB0 RID: 81328
		int InterfaceOffset();

		// Token: 0x06013DB1 RID: 81329 RVA: 0x001D2800 File Offset: 0x001D0A00
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe void SetParameter(in FVector2D NewValue)
		{
			IGizmoVec2ParameterSource.__SetParameter_FunctionParams* ptr = stackalloc IGizmoVec2ParameterSource.__SetParameter_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(IGizmoVec2ParameterSource.__SetParameter_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IGizmoVec2ParameterSource_ReflectionImplementationFields.__SetParameter_NativeFunctionPtr, (void*)ptr, 1);
			ptr->NewValue = NewValue;
			UnrealReflectionUtils.CallUFunction(this.NativePtr, IGizmoVec2ParameterSource_ReflectionImplementationFields.__SetParameter_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06013DB2 RID: 81330 RVA: 0x001D284C File Offset: 0x001D0A4C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe FVector2D GetParameter()
		{
			IGizmoVec2ParameterSource.__GetParameter_FunctionParams* ptr = stackalloc IGizmoVec2ParameterSource.__GetParameter_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(IGizmoVec2ParameterSource.__GetParameter_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IGizmoVec2ParameterSource_ReflectionImplementationFields.__GetParameter_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(this.NativePtr, IGizmoVec2ParameterSource_ReflectionImplementationFields.__GetParameter_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06013DB3 RID: 81331 RVA: 0x001D2892 File Offset: 0x001D0A92
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		void EndModify()
		{
			UnrealReflectionUtils.CallUFunction(this.NativePtr, IGizmoVec2ParameterSource_ReflectionImplementationFields.__EndModify_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06013DB4 RID: 81332 RVA: 0x001D28A7 File Offset: 0x001D0AA7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		void BeginModify()
		{
			UnrealReflectionUtils.CallUFunction(this.NativePtr, IGizmoVec2ParameterSource_ReflectionImplementationFields.__BeginModify_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0400ABDE RID: 43998
		[Nullable(1)]
		public const string __ObjectPath = "/Script/InteractiveToolsFramework.GizmoVec2ParameterSource";

		// Token: 0x02002EBD RID: 11965
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __SetParameter_FunctionParams
		{
			// Token: 0x040169BA RID: 92602
			[FieldOffset(0)]
			public FVector2D NewValue;
		}

		// Token: 0x02002EBE RID: 11966
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetParameter_FunctionParams
		{
			// Token: 0x040169BB RID: 92603
			[FieldOffset(0)]
			public FVector2D __Result;
		}
	}
}
