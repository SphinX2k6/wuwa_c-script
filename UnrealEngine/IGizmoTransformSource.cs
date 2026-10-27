using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001567 RID: 5479
	[UnrealObjectPath("/Script/InteractiveToolsFramework.GizmoTransformSource")]
	public interface IGizmoTransformSource : IUnrealNativeInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x06013D88 RID: 81288
		int InterfaceOffset();

		// Token: 0x06013D89 RID: 81289 RVA: 0x001D2430 File Offset: 0x001D0630
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe void SetTransform(in FTransform NewTransform)
		{
			IGizmoTransformSource.__SetTransform_FunctionParams* ptr = stackalloc IGizmoTransformSource.__SetTransform_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(IGizmoTransformSource.__SetTransform_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IGizmoTransformSource_ReflectionImplementationFields.__SetTransform_NativeFunctionPtr, (void*)ptr, 1);
			ptr->NewTransform = NewTransform;
			UnrealReflectionUtils.CallUFunction(this.NativePtr, IGizmoTransformSource_ReflectionImplementationFields.__SetTransform_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06013D8A RID: 81290 RVA: 0x001D247C File Offset: 0x001D067C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe FTransform GetTransform()
		{
			IGizmoTransformSource.__GetTransform_FunctionParams* ptr = stackalloc IGizmoTransformSource.__GetTransform_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(IGizmoTransformSource.__GetTransform_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IGizmoTransformSource_ReflectionImplementationFields.__GetTransform_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(this.NativePtr, IGizmoTransformSource_ReflectionImplementationFields.__GetTransform_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0400ABCB RID: 43979
		[Nullable(1)]
		public const string __ObjectPath = "/Script/InteractiveToolsFramework.GizmoTransformSource";

		// Token: 0x02002EBB RID: 11963
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __SetTransform_FunctionParams
		{
			// Token: 0x040169B8 RID: 92600
			[FieldOffset(0)]
			public FTransform NewTransform;
		}

		// Token: 0x02002EBC RID: 11964
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __GetTransform_FunctionParams
		{
			// Token: 0x040169B9 RID: 92601
			[FieldOffset(0)]
			public FTransform __Result;
		}
	}
}
