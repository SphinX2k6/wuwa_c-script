using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020020AC RID: 8364
	[UnrealObjectPath("/Script/LGUI.LGUIPointerSelectDeselectInterface")]
	public interface ILGUIPointerSelectDeselectInterface : IUnrealNativeInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x0601F877 RID: 129143
		int InterfaceOffset();

		// Token: 0x0601F878 RID: 129144 RVA: 0x002EDE04 File Offset: 0x002EC004
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe bool OnPointerSelect(ULGUIBaseEventData eventData)
		{
			ILGUIPointerSelectDeselectInterface.__OnPointerSelect_FunctionParams* ptr = stackalloc ILGUIPointerSelectDeselectInterface.__OnPointerSelect_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(ILGUIPointerSelectDeselectInterface.__OnPointerSelect_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ILGUIPointerSelectDeselectInterface_ReflectionImplementationFields.__OnPointerSelect_NativeFunctionPtr, (void*)ptr, 1);
			ptr->eventData = ((eventData != null) ? eventData.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, ILGUIPointerSelectDeselectInterface_ReflectionImplementationFields.__OnPointerSelect_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0601F879 RID: 129145 RVA: 0x002EDE60 File Offset: 0x002EC060
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe bool OnPointerSelect_Implementation(ULGUIBaseEventData eventData)
		{
			ILGUIPointerSelectDeselectInterface.__OnPointerSelect_FunctionParams* ptr = stackalloc ILGUIPointerSelectDeselectInterface.__OnPointerSelect_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(ILGUIPointerSelectDeselectInterface.__OnPointerSelect_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ILGUIPointerSelectDeselectInterface_ReflectionImplementationFields.__OnPointerSelect_NativeFunctionPtr, (void*)ptr, 1);
			ptr->eventData = ((eventData != null) ? eventData.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(this.NativePtr, ILGUIPointerSelectDeselectInterface_ReflectionImplementationFields.__OnPointerSelect_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0601F87A RID: 129146 RVA: 0x002EDEBC File Offset: 0x002EC0BC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe bool OnPointerDeselect(ULGUIBaseEventData eventData)
		{
			ILGUIPointerSelectDeselectInterface.__OnPointerDeselect_FunctionParams* ptr = stackalloc ILGUIPointerSelectDeselectInterface.__OnPointerDeselect_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(ILGUIPointerSelectDeselectInterface.__OnPointerDeselect_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ILGUIPointerSelectDeselectInterface_ReflectionImplementationFields.__OnPointerDeselect_NativeFunctionPtr, (void*)ptr, 1);
			ptr->eventData = ((eventData != null) ? eventData.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, ILGUIPointerSelectDeselectInterface_ReflectionImplementationFields.__OnPointerDeselect_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0601F87B RID: 129147 RVA: 0x002EDF18 File Offset: 0x002EC118
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe bool OnPointerDeselect_Implementation(ULGUIBaseEventData eventData)
		{
			ILGUIPointerSelectDeselectInterface.__OnPointerDeselect_FunctionParams* ptr = stackalloc ILGUIPointerSelectDeselectInterface.__OnPointerDeselect_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(ILGUIPointerSelectDeselectInterface.__OnPointerDeselect_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ILGUIPointerSelectDeselectInterface_ReflectionImplementationFields.__OnPointerDeselect_NativeFunctionPtr, (void*)ptr, 1);
			ptr->eventData = ((eventData != null) ? eventData.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(this.NativePtr, ILGUIPointerSelectDeselectInterface_ReflectionImplementationFields.__OnPointerDeselect_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x04011053 RID: 69715
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUIPointerSelectDeselectInterface";

		// Token: 0x020034AC RID: 13484
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OnPointerSelect_FunctionParams
		{
			// Token: 0x040174B1 RID: 95409
			[FieldOffset(0)]
			public IntPtr eventData;

			// Token: 0x040174B2 RID: 95410
			[FieldOffset(8)]
			public bool __Result;
		}

		// Token: 0x020034AD RID: 13485
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OnPointerDeselect_FunctionParams
		{
			// Token: 0x040174B3 RID: 95411
			[FieldOffset(0)]
			public IntPtr eventData;

			// Token: 0x040174B4 RID: 95412
			[FieldOffset(8)]
			public bool __Result;
		}
	}
}
