using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000120 RID: 288
	[UnrealObjectPath("/Script/AIModule.BlackboardAssetProvider")]
	public interface IBlackboardAssetProvider : IUnrealNativeInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x060014F6 RID: 5366
		int InterfaceOffset();

		// Token: 0x060014F7 RID: 5367 RVA: 0x0001EDBC File Offset: 0x0001CFBC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe UBlackboardData GetBlackboardAsset()
		{
			IBlackboardAssetProvider.__GetBlackboardAsset_FunctionParams* ptr = stackalloc IBlackboardAssetProvider.__GetBlackboardAsset_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(IBlackboardAssetProvider.__GetBlackboardAsset_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IBlackboardAssetProvider_ReflectionImplementationFields.__GetBlackboardAsset_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(this.NativePtr, IBlackboardAssetProvider_ReflectionImplementationFields.__GetBlackboardAsset_NativeFunctionPtr, (void*)ptr, 0);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UBlackboardData>(ptr->__Result);
		}

		// Token: 0x04000460 RID: 1120
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AIModule.BlackboardAssetProvider";

		// Token: 0x02002B48 RID: 11080
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetBlackboardAsset_FunctionParams
		{
			// Token: 0x040163AD RID: 91053
			[FieldOffset(0)]
			public IntPtr __Result;
		}
	}
}
