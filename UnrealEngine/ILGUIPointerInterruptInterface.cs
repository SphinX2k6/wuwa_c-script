using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020020AA RID: 8362
	[UnrealObjectPath("/Script/LGUI.LGUIPointerInterruptInterface")]
	public interface ILGUIPointerInterruptInterface : IUnrealNativeInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x0601F871 RID: 129137
		int InterfaceOffset();

		// Token: 0x0601F872 RID: 129138 RVA: 0x002EDC94 File Offset: 0x002EBE94
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe bool NeedInterrupt(ULGUIBaseEventData EventData)
		{
			ILGUIPointerInterruptInterface.__NeedInterrupt_FunctionParams* ptr = stackalloc ILGUIPointerInterruptInterface.__NeedInterrupt_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(ILGUIPointerInterruptInterface.__NeedInterrupt_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ILGUIPointerInterruptInterface_ReflectionImplementationFields.__NeedInterrupt_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EventData = ((EventData != null) ? EventData.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, ILGUIPointerInterruptInterface_ReflectionImplementationFields.__NeedInterrupt_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0601F873 RID: 129139 RVA: 0x002EDCF0 File Offset: 0x002EBEF0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe bool NeedInterrupt_Implementation(ULGUIBaseEventData EventData)
		{
			ILGUIPointerInterruptInterface.__NeedInterrupt_FunctionParams* ptr = stackalloc ILGUIPointerInterruptInterface.__NeedInterrupt_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(ILGUIPointerInterruptInterface.__NeedInterrupt_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ILGUIPointerInterruptInterface_ReflectionImplementationFields.__NeedInterrupt_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EventData = ((EventData != null) ? EventData.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(this.NativePtr, ILGUIPointerInterruptInterface_ReflectionImplementationFields.__NeedInterrupt_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x04011051 RID: 69713
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUIPointerInterruptInterface";

		// Token: 0x020034AA RID: 13482
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __NeedInterrupt_FunctionParams
		{
			// Token: 0x040174AD RID: 95405
			[FieldOffset(0)]
			public IntPtr EventData;

			// Token: 0x040174AE RID: 95406
			[FieldOffset(8)]
			public bool __Result;
		}
	}
}
