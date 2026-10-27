using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020020A4 RID: 8356
	[UnrealObjectPath("/Script/LGUI.LGUIPointerDragInterface")]
	public interface ILGUIPointerDragInterface : IUnrealNativeInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x0601F7F1 RID: 129009
		int InterfaceOffset();

		// Token: 0x0601F7F2 RID: 129010 RVA: 0x002ECEB4 File Offset: 0x002EB0B4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe bool OnPointerEndDrag(ULGUIPointerEventData eventData)
		{
			ILGUIPointerDragInterface.__OnPointerEndDrag_FunctionParams* ptr = stackalloc ILGUIPointerDragInterface.__OnPointerEndDrag_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(ILGUIPointerDragInterface.__OnPointerEndDrag_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ILGUIPointerDragInterface_ReflectionImplementationFields.__OnPointerEndDrag_NativeFunctionPtr, (void*)ptr, 1);
			ptr->eventData = ((eventData != null) ? eventData.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, ILGUIPointerDragInterface_ReflectionImplementationFields.__OnPointerEndDrag_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0601F7F3 RID: 129011 RVA: 0x002ECF10 File Offset: 0x002EB110
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe bool OnPointerEndDrag_Implementation(ULGUIPointerEventData eventData)
		{
			ILGUIPointerDragInterface.__OnPointerEndDrag_FunctionParams* ptr = stackalloc ILGUIPointerDragInterface.__OnPointerEndDrag_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(ILGUIPointerDragInterface.__OnPointerEndDrag_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ILGUIPointerDragInterface_ReflectionImplementationFields.__OnPointerEndDrag_NativeFunctionPtr, (void*)ptr, 1);
			ptr->eventData = ((eventData != null) ? eventData.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(this.NativePtr, ILGUIPointerDragInterface_ReflectionImplementationFields.__OnPointerEndDrag_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0601F7F4 RID: 129012 RVA: 0x002ECF6C File Offset: 0x002EB16C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe bool OnPointerDrag(ULGUIPointerEventData eventData)
		{
			ILGUIPointerDragInterface.__OnPointerDrag_FunctionParams* ptr = stackalloc ILGUIPointerDragInterface.__OnPointerDrag_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(ILGUIPointerDragInterface.__OnPointerDrag_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ILGUIPointerDragInterface_ReflectionImplementationFields.__OnPointerDrag_NativeFunctionPtr, (void*)ptr, 1);
			ptr->eventData = ((eventData != null) ? eventData.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, ILGUIPointerDragInterface_ReflectionImplementationFields.__OnPointerDrag_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0601F7F5 RID: 129013 RVA: 0x002ECFC8 File Offset: 0x002EB1C8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe bool OnPointerDrag_Implementation(ULGUIPointerEventData eventData)
		{
			ILGUIPointerDragInterface.__OnPointerDrag_FunctionParams* ptr = stackalloc ILGUIPointerDragInterface.__OnPointerDrag_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(ILGUIPointerDragInterface.__OnPointerDrag_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ILGUIPointerDragInterface_ReflectionImplementationFields.__OnPointerDrag_NativeFunctionPtr, (void*)ptr, 1);
			ptr->eventData = ((eventData != null) ? eventData.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(this.NativePtr, ILGUIPointerDragInterface_ReflectionImplementationFields.__OnPointerDrag_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0601F7F6 RID: 129014 RVA: 0x002ED024 File Offset: 0x002EB224
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe bool OnPointerBeginDrag(ULGUIPointerEventData eventData)
		{
			ILGUIPointerDragInterface.__OnPointerBeginDrag_FunctionParams* ptr = stackalloc ILGUIPointerDragInterface.__OnPointerBeginDrag_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(ILGUIPointerDragInterface.__OnPointerBeginDrag_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ILGUIPointerDragInterface_ReflectionImplementationFields.__OnPointerBeginDrag_NativeFunctionPtr, (void*)ptr, 1);
			ptr->eventData = ((eventData != null) ? eventData.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, ILGUIPointerDragInterface_ReflectionImplementationFields.__OnPointerBeginDrag_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0601F7F7 RID: 129015 RVA: 0x002ED080 File Offset: 0x002EB280
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe bool OnPointerBeginDrag_Implementation(ULGUIPointerEventData eventData)
		{
			ILGUIPointerDragInterface.__OnPointerBeginDrag_FunctionParams* ptr = stackalloc ILGUIPointerDragInterface.__OnPointerBeginDrag_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(ILGUIPointerDragInterface.__OnPointerBeginDrag_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ILGUIPointerDragInterface_ReflectionImplementationFields.__OnPointerBeginDrag_NativeFunctionPtr, (void*)ptr, 1);
			ptr->eventData = ((eventData != null) ? eventData.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(this.NativePtr, ILGUIPointerDragInterface_ReflectionImplementationFields.__OnPointerBeginDrag_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0401101D RID: 69661
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUIPointerDragInterface";

		// Token: 0x0200349F RID: 13471
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OnPointerEndDrag_FunctionParams
		{
			// Token: 0x0401749D RID: 95389
			[FieldOffset(0)]
			public IntPtr eventData;

			// Token: 0x0401749E RID: 95390
			[FieldOffset(8)]
			public bool __Result;
		}

		// Token: 0x020034A0 RID: 13472
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OnPointerDrag_FunctionParams
		{
			// Token: 0x0401749F RID: 95391
			[FieldOffset(0)]
			public IntPtr eventData;

			// Token: 0x040174A0 RID: 95392
			[FieldOffset(8)]
			public bool __Result;
		}

		// Token: 0x020034A1 RID: 13473
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OnPointerBeginDrag_FunctionParams
		{
			// Token: 0x040174A1 RID: 95393
			[FieldOffset(0)]
			public IntPtr eventData;

			// Token: 0x040174A2 RID: 95394
			[FieldOffset(8)]
			public bool __Result;
		}
	}
}
