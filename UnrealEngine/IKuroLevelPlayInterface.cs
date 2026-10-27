using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020018EC RID: 6380
	[UnrealObjectPath("/Script/KuroGameplay.KuroLevelPlayInterface")]
	public interface IKuroLevelPlayInterface : IUnrealNativeInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x06017A91 RID: 96913
		int InterfaceOffset();

		// Token: 0x06017A92 RID: 96914 RVA: 0x0022AD20 File Offset: 0x00228F20
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe bool ProcessPhysics()
		{
			IKuroLevelPlayInterface.__ProcessPhysics_FunctionParams* ptr = stackalloc IKuroLevelPlayInterface.__ProcessPhysics_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(IKuroLevelPlayInterface.__ProcessPhysics_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IKuroLevelPlayInterface_ReflectionImplementationFields.__ProcessPhysics_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IKuroLevelPlayInterface_ReflectionImplementationFields.__ProcessPhysics_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06017A93 RID: 96915 RVA: 0x0022AD68 File Offset: 0x00228F68
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe bool ProcessPhysics_Implementation()
		{
			IKuroLevelPlayInterface.__ProcessPhysics_FunctionParams* ptr = stackalloc IKuroLevelPlayInterface.__ProcessPhysics_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(IKuroLevelPlayInterface.__ProcessPhysics_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IKuroLevelPlayInterface_ReflectionImplementationFields.__ProcessPhysics_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(this.NativePtr, IKuroLevelPlayInterface_ReflectionImplementationFields.__ProcessPhysics_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0400CDA1 RID: 52641
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameplay.KuroLevelPlayInterface";

		// Token: 0x02002FD4 RID: 12244
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __ProcessPhysics_FunctionParams
		{
			// Token: 0x04016BC4 RID: 93124
			[FieldOffset(0)]
			public bool __Result;
		}
	}
}
