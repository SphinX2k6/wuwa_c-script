using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020020A3 RID: 8355
	[UnrealObjectPath("/Script/LGUI.LGUIPointerDragEnterExitInterface")]
	public interface ILGUIPointerDragEnterExitInterface : IUnrealNativeInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x0601F7EC RID: 129004
		int InterfaceOffset();

		// Token: 0x0601F7ED RID: 129005 RVA: 0x002ECD44 File Offset: 0x002EAF44
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe bool OnPointerDragExit(ULGUIPointerEventData eventData)
		{
			ILGUIPointerDragEnterExitInterface.__OnPointerDragExit_FunctionParams* ptr = stackalloc ILGUIPointerDragEnterExitInterface.__OnPointerDragExit_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(ILGUIPointerDragEnterExitInterface.__OnPointerDragExit_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ILGUIPointerDragEnterExitInterface_ReflectionImplementationFields.__OnPointerDragExit_NativeFunctionPtr, (void*)ptr, 1);
			ptr->eventData = ((eventData != null) ? eventData.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, ILGUIPointerDragEnterExitInterface_ReflectionImplementationFields.__OnPointerDragExit_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0601F7EE RID: 129006 RVA: 0x002ECDA0 File Offset: 0x002EAFA0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe bool OnPointerDragExit_Implementation(ULGUIPointerEventData eventData)
		{
			ILGUIPointerDragEnterExitInterface.__OnPointerDragExit_FunctionParams* ptr = stackalloc ILGUIPointerDragEnterExitInterface.__OnPointerDragExit_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(ILGUIPointerDragEnterExitInterface.__OnPointerDragExit_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ILGUIPointerDragEnterExitInterface_ReflectionImplementationFields.__OnPointerDragExit_NativeFunctionPtr, (void*)ptr, 1);
			ptr->eventData = ((eventData != null) ? eventData.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(this.NativePtr, ILGUIPointerDragEnterExitInterface_ReflectionImplementationFields.__OnPointerDragExit_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0601F7EF RID: 129007 RVA: 0x002ECDFC File Offset: 0x002EAFFC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe bool OnPointerDragEnter(ULGUIPointerEventData eventData)
		{
			ILGUIPointerDragEnterExitInterface.__OnPointerDragEnter_FunctionParams* ptr = stackalloc ILGUIPointerDragEnterExitInterface.__OnPointerDragEnter_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(ILGUIPointerDragEnterExitInterface.__OnPointerDragEnter_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ILGUIPointerDragEnterExitInterface_ReflectionImplementationFields.__OnPointerDragEnter_NativeFunctionPtr, (void*)ptr, 1);
			ptr->eventData = ((eventData != null) ? eventData.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, ILGUIPointerDragEnterExitInterface_ReflectionImplementationFields.__OnPointerDragEnter_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0601F7F0 RID: 129008 RVA: 0x002ECE58 File Offset: 0x002EB058
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe bool OnPointerDragEnter_Implementation(ULGUIPointerEventData eventData)
		{
			ILGUIPointerDragEnterExitInterface.__OnPointerDragEnter_FunctionParams* ptr = stackalloc ILGUIPointerDragEnterExitInterface.__OnPointerDragEnter_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(ILGUIPointerDragEnterExitInterface.__OnPointerDragEnter_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ILGUIPointerDragEnterExitInterface_ReflectionImplementationFields.__OnPointerDragEnter_NativeFunctionPtr, (void*)ptr, 1);
			ptr->eventData = ((eventData != null) ? eventData.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(this.NativePtr, ILGUIPointerDragEnterExitInterface_ReflectionImplementationFields.__OnPointerDragEnter_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0401101C RID: 69660
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUIPointerDragEnterExitInterface";

		// Token: 0x0200349D RID: 13469
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OnPointerDragExit_FunctionParams
		{
			// Token: 0x04017499 RID: 95385
			[FieldOffset(0)]
			public IntPtr eventData;

			// Token: 0x0401749A RID: 95386
			[FieldOffset(8)]
			public bool __Result;
		}

		// Token: 0x0200349E RID: 13470
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OnPointerDragEnter_FunctionParams
		{
			// Token: 0x0401749B RID: 95387
			[FieldOffset(0)]
			public IntPtr eventData;

			// Token: 0x0401749C RID: 95388
			[FieldOffset(8)]
			public bool __Result;
		}
	}
}
