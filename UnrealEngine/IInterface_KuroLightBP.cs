using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000C72 RID: 3186
	[UnrealObjectPath("/Script/Engine.Interface_KuroLightBP")]
	public interface IInterface_KuroLightBP : IUnrealNativeInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x0600A1F2 RID: 41458
		int InterfaceOffset();

		// Token: 0x0600A1F3 RID: 41459 RVA: 0x000E5F90 File Offset: 0x000E4190
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe int GetPlacementSortOrder()
		{
			IInterface_KuroLightBP.__GetPlacementSortOrder_FunctionParams* ptr = stackalloc IInterface_KuroLightBP.__GetPlacementSortOrder_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(IInterface_KuroLightBP.__GetPlacementSortOrder_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IInterface_KuroLightBP_ReflectionImplementationFields.__GetPlacementSortOrder_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IInterface_KuroLightBP_ReflectionImplementationFields.__GetPlacementSortOrder_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0600A1F4 RID: 41460 RVA: 0x000E5FD8 File Offset: 0x000E41D8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe int GetPlacementSortOrder_Implementation()
		{
			IInterface_KuroLightBP.__GetPlacementSortOrder_FunctionParams* ptr = stackalloc IInterface_KuroLightBP.__GetPlacementSortOrder_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(IInterface_KuroLightBP.__GetPlacementSortOrder_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IInterface_KuroLightBP_ReflectionImplementationFields.__GetPlacementSortOrder_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(this.NativePtr, IInterface_KuroLightBP_ReflectionImplementationFields.__GetPlacementSortOrder_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x040058E0 RID: 22752
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.Interface_KuroLightBP";

		// Token: 0x02002D19 RID: 11545
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetPlacementSortOrder_FunctionParams
		{
			// Token: 0x040166E8 RID: 91880
			[FieldOffset(0)]
			public int __Result;
		}
	}
}
