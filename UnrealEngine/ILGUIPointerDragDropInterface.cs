using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020020A2 RID: 8354
	[UnrealObjectPath("/Script/LGUI.LGUIPointerDragDropInterface")]
	public interface ILGUIPointerDragDropInterface : IUnrealNativeInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x0601F7E9 RID: 129001
		int InterfaceOffset();

		// Token: 0x0601F7EA RID: 129002 RVA: 0x002ECC8C File Offset: 0x002EAE8C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe bool OnPointerDragDrop(ULGUIPointerEventData eventData)
		{
			ILGUIPointerDragDropInterface.__OnPointerDragDrop_FunctionParams* ptr = stackalloc ILGUIPointerDragDropInterface.__OnPointerDragDrop_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(ILGUIPointerDragDropInterface.__OnPointerDragDrop_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ILGUIPointerDragDropInterface_ReflectionImplementationFields.__OnPointerDragDrop_NativeFunctionPtr, (void*)ptr, 1);
			ptr->eventData = ((eventData != null) ? eventData.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, ILGUIPointerDragDropInterface_ReflectionImplementationFields.__OnPointerDragDrop_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0601F7EB RID: 129003 RVA: 0x002ECCE8 File Offset: 0x002EAEE8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe bool OnPointerDragDrop_Implementation(ULGUIPointerEventData eventData)
		{
			ILGUIPointerDragDropInterface.__OnPointerDragDrop_FunctionParams* ptr = stackalloc ILGUIPointerDragDropInterface.__OnPointerDragDrop_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(ILGUIPointerDragDropInterface.__OnPointerDragDrop_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ILGUIPointerDragDropInterface_ReflectionImplementationFields.__OnPointerDragDrop_NativeFunctionPtr, (void*)ptr, 1);
			ptr->eventData = ((eventData != null) ? eventData.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(this.NativePtr, ILGUIPointerDragDropInterface_ReflectionImplementationFields.__OnPointerDragDrop_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0401101B RID: 69659
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUIPointerDragDropInterface";

		// Token: 0x0200349C RID: 13468
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OnPointerDragDrop_FunctionParams
		{
			// Token: 0x04017497 RID: 95383
			[FieldOffset(0)]
			public IntPtr eventData;

			// Token: 0x04017498 RID: 95384
			[FieldOffset(8)]
			public bool __Result;
		}
	}
}
