using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200261A RID: 9754
	[UnrealObjectPath("/Script/OnlineSubsystem.TurnBasedMatchInterface")]
	public interface ITurnBasedMatchInterface : IUnrealNativeInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x0602446F RID: 148591
		int InterfaceOffset();

		// Token: 0x06024470 RID: 148592 RVA: 0x0035B520 File Offset: 0x00359720
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe void OnMatchReceivedTurn(string Match, bool bDidBecomeActive)
		{
			ITurnBasedMatchInterface.__OnMatchReceivedTurn_FunctionParams* ptr = stackalloc ITurnBasedMatchInterface.__OnMatchReceivedTurn_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(ITurnBasedMatchInterface.__OnMatchReceivedTurn_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ITurnBasedMatchInterface_ReflectionImplementationFields.__OnMatchReceivedTurn_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->Match), Match);
			ptr->bDidBecomeActive = bDidBecomeActive;
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, ITurnBasedMatchInterface_ReflectionImplementationFields.__OnMatchReceivedTurn_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(ITurnBasedMatchInterface_ReflectionImplementationFields.__OnMatchReceivedTurn_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06024471 RID: 148593 RVA: 0x0035B584 File Offset: 0x00359784
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe void OnMatchEnded(string Match)
		{
			ITurnBasedMatchInterface.__OnMatchEnded_FunctionParams* ptr = stackalloc ITurnBasedMatchInterface.__OnMatchEnded_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(ITurnBasedMatchInterface.__OnMatchEnded_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ITurnBasedMatchInterface_ReflectionImplementationFields.__OnMatchEnded_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->Match), Match);
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, ITurnBasedMatchInterface_ReflectionImplementationFields.__OnMatchEnded_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(ITurnBasedMatchInterface_ReflectionImplementationFields.__OnMatchEnded_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0401375A RID: 79706
		[Nullable(1)]
		public const string __ObjectPath = "/Script/OnlineSubsystem.TurnBasedMatchInterface";

		// Token: 0x0200367E RID: 13950
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __OnMatchReceivedTurn_FunctionParams
		{
			// Token: 0x04017756 RID: 96086
			[FieldOffset(0)]
			public FString Match;

			// Token: 0x04017757 RID: 96087
			[FieldOffset(16)]
			public bool bDidBecomeActive;
		}

		// Token: 0x0200367F RID: 13951
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OnMatchEnded_FunctionParams
		{
			// Token: 0x04017758 RID: 96088
			[FieldOffset(0)]
			public FString Match;
		}
	}
}
