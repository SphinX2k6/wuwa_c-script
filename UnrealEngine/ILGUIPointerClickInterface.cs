using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020020A0 RID: 8352
	[UnrealObjectPath("/Script/LGUI.LGUIPointerClickInterface")]
	public interface ILGUIPointerClickInterface : IUnrealNativeInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x0601F7E1 RID: 128993
		int InterfaceOffset();

		// Token: 0x0601F7E2 RID: 128994 RVA: 0x002ECA64 File Offset: 0x002EAC64
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe bool OnPointerClick(ULGUIPointerEventData eventData)
		{
			ILGUIPointerClickInterface.__OnPointerClick_FunctionParams* ptr = stackalloc ILGUIPointerClickInterface.__OnPointerClick_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(ILGUIPointerClickInterface.__OnPointerClick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ILGUIPointerClickInterface_ReflectionImplementationFields.__OnPointerClick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->eventData = ((eventData != null) ? eventData.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, ILGUIPointerClickInterface_ReflectionImplementationFields.__OnPointerClick_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0601F7E3 RID: 128995 RVA: 0x002ECAC0 File Offset: 0x002EACC0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe bool OnPointerClick_Implementation(ULGUIPointerEventData eventData)
		{
			ILGUIPointerClickInterface.__OnPointerClick_FunctionParams* ptr = stackalloc ILGUIPointerClickInterface.__OnPointerClick_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(ILGUIPointerClickInterface.__OnPointerClick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ILGUIPointerClickInterface_ReflectionImplementationFields.__OnPointerClick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->eventData = ((eventData != null) ? eventData.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(this.NativePtr, ILGUIPointerClickInterface_ReflectionImplementationFields.__OnPointerClick_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x04011019 RID: 69657
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUIPointerClickInterface";

		// Token: 0x02003499 RID: 13465
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OnPointerClick_FunctionParams
		{
			// Token: 0x04017491 RID: 95377
			[FieldOffset(0)]
			public IntPtr eventData;

			// Token: 0x04017492 RID: 95378
			[FieldOffset(8)]
			public bool __Result;
		}
	}
}
