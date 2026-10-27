using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020020AB RID: 8363
	[UnrealObjectPath("/Script/LGUI.LGUIPointerScrollInterface")]
	public interface ILGUIPointerScrollInterface : IUnrealNativeInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x0601F874 RID: 129140
		int InterfaceOffset();

		// Token: 0x0601F875 RID: 129141 RVA: 0x002EDD4C File Offset: 0x002EBF4C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe bool OnPointerScroll(ULGUIPointerEventData eventData)
		{
			ILGUIPointerScrollInterface.__OnPointerScroll_FunctionParams* ptr = stackalloc ILGUIPointerScrollInterface.__OnPointerScroll_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(ILGUIPointerScrollInterface.__OnPointerScroll_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ILGUIPointerScrollInterface_ReflectionImplementationFields.__OnPointerScroll_NativeFunctionPtr, (void*)ptr, 1);
			ptr->eventData = ((eventData != null) ? eventData.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, ILGUIPointerScrollInterface_ReflectionImplementationFields.__OnPointerScroll_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0601F876 RID: 129142 RVA: 0x002EDDA8 File Offset: 0x002EBFA8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe bool OnPointerScroll_Implementation(ULGUIPointerEventData eventData)
		{
			ILGUIPointerScrollInterface.__OnPointerScroll_FunctionParams* ptr = stackalloc ILGUIPointerScrollInterface.__OnPointerScroll_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(ILGUIPointerScrollInterface.__OnPointerScroll_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ILGUIPointerScrollInterface_ReflectionImplementationFields.__OnPointerScroll_NativeFunctionPtr, (void*)ptr, 1);
			ptr->eventData = ((eventData != null) ? eventData.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(this.NativePtr, ILGUIPointerScrollInterface_ReflectionImplementationFields.__OnPointerScroll_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x04011052 RID: 69714
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUIPointerScrollInterface";

		// Token: 0x020034AB RID: 13483
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OnPointerScroll_FunctionParams
		{
			// Token: 0x040174AF RID: 95407
			[FieldOffset(0)]
			public IntPtr eventData;

			// Token: 0x040174B0 RID: 95408
			[FieldOffset(8)]
			public bool __Result;
		}
	}
}
