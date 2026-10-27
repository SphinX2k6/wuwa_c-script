using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200136A RID: 4970
	[UnrealObjectPath("/Script/GameplayAbilities.GameplayCueInterface")]
	public interface IGameplayCueInterface : IUnrealNativeInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x0601239F RID: 74655
		int InterfaceOffset();

		// Token: 0x060123A0 RID: 74656 RVA: 0x001AC0D2 File Offset: 0x001AA2D2
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		void ForwardGameplayCueToParent()
		{
			UnrealReflectionUtils.CallUFunction(this.NativePtr, IGameplayCueInterface_ReflectionImplementationFields.__ForwardGameplayCueToParent_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060123A1 RID: 74657 RVA: 0x001AC0E8 File Offset: 0x001AA2E8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe void BlueprintCustomHandler(EGameplayCueEvent EventType, FGameplayCueParameters Parameters)
		{
			IGameplayCueInterface.__BlueprintCustomHandler_FunctionParams* ptr = stackalloc IGameplayCueInterface.__BlueprintCustomHandler_FunctionParams[(UIntPtr)215] + 15L / (long)sizeof(IGameplayCueInterface.__BlueprintCustomHandler_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IGameplayCueInterface_ReflectionImplementationFields.__BlueprintCustomHandler_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EventType = EventType;
			if (Parameters != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayCueParameters.StaticStruct(), &ptr->Parameters, Parameters.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IGameplayCueInterface_ReflectionImplementationFields.__BlueprintCustomHandler_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(IGameplayCueInterface_ReflectionImplementationFields.__BlueprintCustomHandler_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x04009C2B RID: 39979
		[Nullable(1)]
		public const string __ObjectPath = "/Script/GameplayAbilities.GameplayCueInterface";

		// Token: 0x02002E32 RID: 11826
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 200)]
		protected ref struct __BlueprintCustomHandler_FunctionParams
		{
			// Token: 0x040168CF RID: 92367
			[FieldOffset(0)]
			public TEnumAsByte<EGameplayCueEvent> EventType;

			// Token: 0x040168D0 RID: 92368
			[FieldOffset(8)]
			public byte Parameters;
		}
	}
}
