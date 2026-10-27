using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001558 RID: 5464
	[UnrealObjectPath("/Script/InteractiveToolsFramework.GizmoFloatParameterSource")]
	public interface IGizmoFloatParameterSource : IUnrealNativeInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x06013CEA RID: 81130
		int InterfaceOffset();

		// Token: 0x06013CEB RID: 81131 RVA: 0x001D1554 File Offset: 0x001CF754
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe void SetParameter(float NewValue)
		{
			IGizmoFloatParameterSource.__SetParameter_FunctionParams* ptr = stackalloc IGizmoFloatParameterSource.__SetParameter_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(IGizmoFloatParameterSource.__SetParameter_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IGizmoFloatParameterSource_ReflectionImplementationFields.__SetParameter_NativeFunctionPtr, (void*)ptr, 1);
			ptr->NewValue = NewValue;
			UnrealReflectionUtils.CallUFunction(this.NativePtr, IGizmoFloatParameterSource_ReflectionImplementationFields.__SetParameter_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06013CEC RID: 81132 RVA: 0x001D159C File Offset: 0x001CF79C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe float GetParameter()
		{
			IGizmoFloatParameterSource.__GetParameter_FunctionParams* ptr = stackalloc IGizmoFloatParameterSource.__GetParameter_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(IGizmoFloatParameterSource.__GetParameter_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IGizmoFloatParameterSource_ReflectionImplementationFields.__GetParameter_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(this.NativePtr, IGizmoFloatParameterSource_ReflectionImplementationFields.__GetParameter_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06013CED RID: 81133 RVA: 0x001D15E2 File Offset: 0x001CF7E2
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		void EndModify()
		{
			UnrealReflectionUtils.CallUFunction(this.NativePtr, IGizmoFloatParameterSource_ReflectionImplementationFields.__EndModify_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06013CEE RID: 81134 RVA: 0x001D15F7 File Offset: 0x001CF7F7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		void BeginModify()
		{
			UnrealReflectionUtils.CallUFunction(this.NativePtr, IGizmoFloatParameterSource_ReflectionImplementationFields.__BeginModify_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0400AB71 RID: 43889
		[Nullable(1)]
		public const string __ObjectPath = "/Script/InteractiveToolsFramework.GizmoFloatParameterSource";

		// Token: 0x02002EB9 RID: 11961
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __SetParameter_FunctionParams
		{
			// Token: 0x040169B6 RID: 92598
			[FieldOffset(0)]
			public float NewValue;
		}

		// Token: 0x02002EBA RID: 11962
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetParameter_FunctionParams
		{
			// Token: 0x040169B7 RID: 92599
			[FieldOffset(0)]
			public float __Result;
		}
	}
}
