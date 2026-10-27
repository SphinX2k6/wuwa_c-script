using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001564 RID: 5476
	[UnrealObjectPath("/Script/InteractiveToolsFramework.GizmoStateTarget")]
	public interface IGizmoStateTarget : IUnrealNativeInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x06013D76 RID: 81270
		int InterfaceOffset();

		// Token: 0x06013D77 RID: 81271 RVA: 0x001D2296 File Offset: 0x001D0496
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		void EndUpdate()
		{
			UnrealReflectionUtils.CallUFunction(this.NativePtr, IGizmoStateTarget_ReflectionImplementationFields.__EndUpdate_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06013D78 RID: 81272 RVA: 0x001D22AB File Offset: 0x001D04AB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		void BeginUpdate()
		{
			UnrealReflectionUtils.CallUFunction(this.NativePtr, IGizmoStateTarget_ReflectionImplementationFields.__BeginUpdate_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0400ABC1 RID: 43969
		[Nullable(1)]
		public const string __ObjectPath = "/Script/InteractiveToolsFramework.GizmoStateTarget";
	}
}
