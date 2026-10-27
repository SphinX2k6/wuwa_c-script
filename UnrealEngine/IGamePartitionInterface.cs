using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001876 RID: 6262
	[UnrealObjectPath("/Script/KuroGameplayInterface.GamePartitionInterface")]
	public interface IGamePartitionInterface : IUnrealNativeInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x060170EC RID: 94444
		int InterfaceOffset();

		// Token: 0x060170ED RID: 94445 RVA: 0x002199B4 File Offset: 0x00217BB4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe int GetGamePartitionObjectID()
		{
			IGamePartitionInterface.__GetGamePartitionObjectID_FunctionParams* ptr = stackalloc IGamePartitionInterface.__GetGamePartitionObjectID_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(IGamePartitionInterface.__GetGamePartitionObjectID_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IGamePartitionInterface_ReflectionImplementationFields.__GetGamePartitionObjectID_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(this.NativePtr, IGamePartitionInterface_ReflectionImplementationFields.__GetGamePartitionObjectID_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0400C82D RID: 51245
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameplayInterface.GamePartitionInterface";

		// Token: 0x02002F7E RID: 12158
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetGamePartitionObjectID_FunctionParams
		{
			// Token: 0x04016B3C RID: 92988
			[FieldOffset(0)]
			public int __Result;
		}
	}
}
