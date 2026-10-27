using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020020A5 RID: 8357
	[UnrealObjectPath("/Script/LGUI.LGUIPointerEnterExitInterface")]
	public interface ILGUIPointerEnterExitInterface : IUnrealNativeInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x0601F7F8 RID: 129016
		int InterfaceOffset();

		// Token: 0x0601F7F9 RID: 129017 RVA: 0x002ED0DC File Offset: 0x002EB2DC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe bool OnPointerExit(ULGUIPointerEventData eventData)
		{
			ILGUIPointerEnterExitInterface.__OnPointerExit_FunctionParams* ptr = stackalloc ILGUIPointerEnterExitInterface.__OnPointerExit_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(ILGUIPointerEnterExitInterface.__OnPointerExit_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ILGUIPointerEnterExitInterface_ReflectionImplementationFields.__OnPointerExit_NativeFunctionPtr, (void*)ptr, 1);
			ptr->eventData = ((eventData != null) ? eventData.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, ILGUIPointerEnterExitInterface_ReflectionImplementationFields.__OnPointerExit_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0601F7FA RID: 129018 RVA: 0x002ED138 File Offset: 0x002EB338
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe bool OnPointerExit_Implementation(ULGUIPointerEventData eventData)
		{
			ILGUIPointerEnterExitInterface.__OnPointerExit_FunctionParams* ptr = stackalloc ILGUIPointerEnterExitInterface.__OnPointerExit_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(ILGUIPointerEnterExitInterface.__OnPointerExit_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ILGUIPointerEnterExitInterface_ReflectionImplementationFields.__OnPointerExit_NativeFunctionPtr, (void*)ptr, 1);
			ptr->eventData = ((eventData != null) ? eventData.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(this.NativePtr, ILGUIPointerEnterExitInterface_ReflectionImplementationFields.__OnPointerExit_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0601F7FB RID: 129019 RVA: 0x002ED194 File Offset: 0x002EB394
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe bool OnPointerEnter(ULGUIPointerEventData eventData)
		{
			ILGUIPointerEnterExitInterface.__OnPointerEnter_FunctionParams* ptr = stackalloc ILGUIPointerEnterExitInterface.__OnPointerEnter_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(ILGUIPointerEnterExitInterface.__OnPointerEnter_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ILGUIPointerEnterExitInterface_ReflectionImplementationFields.__OnPointerEnter_NativeFunctionPtr, (void*)ptr, 1);
			ptr->eventData = ((eventData != null) ? eventData.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, ILGUIPointerEnterExitInterface_ReflectionImplementationFields.__OnPointerEnter_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0601F7FC RID: 129020 RVA: 0x002ED1F0 File Offset: 0x002EB3F0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe bool OnPointerEnter_Implementation(ULGUIPointerEventData eventData)
		{
			ILGUIPointerEnterExitInterface.__OnPointerEnter_FunctionParams* ptr = stackalloc ILGUIPointerEnterExitInterface.__OnPointerEnter_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(ILGUIPointerEnterExitInterface.__OnPointerEnter_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ILGUIPointerEnterExitInterface_ReflectionImplementationFields.__OnPointerEnter_NativeFunctionPtr, (void*)ptr, 1);
			ptr->eventData = ((eventData != null) ? eventData.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(this.NativePtr, ILGUIPointerEnterExitInterface_ReflectionImplementationFields.__OnPointerEnter_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0401101E RID: 69662
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUIPointerEnterExitInterface";

		// Token: 0x020034A2 RID: 13474
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OnPointerExit_FunctionParams
		{
			// Token: 0x040174A3 RID: 95395
			[FieldOffset(0)]
			public IntPtr eventData;

			// Token: 0x040174A4 RID: 95396
			[FieldOffset(8)]
			public bool __Result;
		}

		// Token: 0x020034A3 RID: 13475
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OnPointerEnter_FunctionParams
		{
			// Token: 0x040174A5 RID: 95397
			[FieldOffset(0)]
			public IntPtr eventData;

			// Token: 0x040174A6 RID: 95398
			[FieldOffset(8)]
			public bool __Result;
		}
	}
}
