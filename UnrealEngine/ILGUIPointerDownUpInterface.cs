using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020020A1 RID: 8353
	[UnrealObjectPath("/Script/LGUI.LGUIPointerDownUpInterface")]
	public interface ILGUIPointerDownUpInterface : IUnrealNativeInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x0601F7E4 RID: 128996
		int InterfaceOffset();

		// Token: 0x0601F7E5 RID: 128997 RVA: 0x002ECB1C File Offset: 0x002EAD1C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe bool OnPointerUp(ULGUIPointerEventData eventData)
		{
			ILGUIPointerDownUpInterface.__OnPointerUp_FunctionParams* ptr = stackalloc ILGUIPointerDownUpInterface.__OnPointerUp_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(ILGUIPointerDownUpInterface.__OnPointerUp_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ILGUIPointerDownUpInterface_ReflectionImplementationFields.__OnPointerUp_NativeFunctionPtr, (void*)ptr, 1);
			ptr->eventData = ((eventData != null) ? eventData.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, ILGUIPointerDownUpInterface_ReflectionImplementationFields.__OnPointerUp_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0601F7E6 RID: 128998 RVA: 0x002ECB78 File Offset: 0x002EAD78
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe bool OnPointerUp_Implementation(ULGUIPointerEventData eventData)
		{
			ILGUIPointerDownUpInterface.__OnPointerUp_FunctionParams* ptr = stackalloc ILGUIPointerDownUpInterface.__OnPointerUp_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(ILGUIPointerDownUpInterface.__OnPointerUp_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ILGUIPointerDownUpInterface_ReflectionImplementationFields.__OnPointerUp_NativeFunctionPtr, (void*)ptr, 1);
			ptr->eventData = ((eventData != null) ? eventData.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(this.NativePtr, ILGUIPointerDownUpInterface_ReflectionImplementationFields.__OnPointerUp_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0601F7E7 RID: 128999 RVA: 0x002ECBD4 File Offset: 0x002EADD4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe bool OnPointerDown(ULGUIPointerEventData eventData)
		{
			ILGUIPointerDownUpInterface.__OnPointerDown_FunctionParams* ptr = stackalloc ILGUIPointerDownUpInterface.__OnPointerDown_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(ILGUIPointerDownUpInterface.__OnPointerDown_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ILGUIPointerDownUpInterface_ReflectionImplementationFields.__OnPointerDown_NativeFunctionPtr, (void*)ptr, 1);
			ptr->eventData = ((eventData != null) ? eventData.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, ILGUIPointerDownUpInterface_ReflectionImplementationFields.__OnPointerDown_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0601F7E8 RID: 129000 RVA: 0x002ECC30 File Offset: 0x002EAE30
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe bool OnPointerDown_Implementation(ULGUIPointerEventData eventData)
		{
			ILGUIPointerDownUpInterface.__OnPointerDown_FunctionParams* ptr = stackalloc ILGUIPointerDownUpInterface.__OnPointerDown_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(ILGUIPointerDownUpInterface.__OnPointerDown_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ILGUIPointerDownUpInterface_ReflectionImplementationFields.__OnPointerDown_NativeFunctionPtr, (void*)ptr, 1);
			ptr->eventData = ((eventData != null) ? eventData.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(this.NativePtr, ILGUIPointerDownUpInterface_ReflectionImplementationFields.__OnPointerDown_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0401101A RID: 69658
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUIPointerDownUpInterface";

		// Token: 0x0200349A RID: 13466
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OnPointerUp_FunctionParams
		{
			// Token: 0x04017493 RID: 95379
			[FieldOffset(0)]
			public IntPtr eventData;

			// Token: 0x04017494 RID: 95380
			[FieldOffset(8)]
			public bool __Result;
		}

		// Token: 0x0200349B RID: 13467
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OnPointerDown_FunctionParams
		{
			// Token: 0x04017495 RID: 95381
			[FieldOffset(0)]
			public IntPtr eventData;

			// Token: 0x04017496 RID: 95382
			[FieldOffset(8)]
			public bool __Result;
		}
	}
}
