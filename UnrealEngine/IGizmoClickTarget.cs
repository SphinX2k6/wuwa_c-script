using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001551 RID: 5457
	[UnrealObjectPath("/Script/InteractiveToolsFramework.GizmoClickTarget")]
	public interface IGizmoClickTarget : IUnrealNativeInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x06013CA7 RID: 81063
		int InterfaceOffset();

		// Token: 0x06013CA8 RID: 81064 RVA: 0x001D0FE8 File Offset: 0x001CF1E8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe void UpdateHoverState(bool bHovering)
		{
			IGizmoClickTarget.__UpdateHoverState_FunctionParams* ptr = stackalloc IGizmoClickTarget.__UpdateHoverState_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(IGizmoClickTarget.__UpdateHoverState_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IGizmoClickTarget_ReflectionImplementationFields.__UpdateHoverState_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bHovering = bHovering;
			UnrealReflectionUtils.CallUFunction(this.NativePtr, IGizmoClickTarget_ReflectionImplementationFields.__UpdateHoverState_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0400AB4D RID: 43853
		[Nullable(1)]
		public const string __ObjectPath = "/Script/InteractiveToolsFramework.GizmoClickTarget";

		// Token: 0x02002EB8 RID: 11960
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __UpdateHoverState_FunctionParams
		{
			// Token: 0x040169B5 RID: 92597
			[FieldOffset(0)]
			public bool bHovering;
		}
	}
}
