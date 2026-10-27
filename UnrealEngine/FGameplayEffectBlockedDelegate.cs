using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001381 RID: 4993
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FGameplayEffectBlockedDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06012556 RID: 75094 RVA: 0x001AED4F File Offset: 0x001ACF4F
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FGameplayEffectBlockedDelegate.StaticFunctionPtr();
		}

		// Token: 0x06012557 RID: 75095 RVA: 0x001AED5B File Offset: 0x001ACF5B
		private static IntPtr StaticFunctionPtr()
		{
			if (FGameplayEffectBlockedDelegate._FunctionPtr == IntPtr.Zero)
			{
				FGameplayEffectBlockedDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/GameplayAbilities.GameplayEffectBlockedDelegate__DelegateSignature");
			}
			return FGameplayEffectBlockedDelegate._FunctionPtr;
		}

		// Token: 0x06012558 RID: 75096 RVA: 0x001AED7E File Offset: 0x001ACF7E
		public FGameplayEffectBlockedDelegate()
		{
		}

		// Token: 0x06012559 RID: 75097 RVA: 0x001AED86 File Offset: 0x001ACF86
		[NullableContext(2)]
		public FGameplayEffectBlockedDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601255A RID: 75098 RVA: 0x001AED90 File Offset: 0x001ACF90
		public FGameplayEffectBlockedDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601255B RID: 75099 RVA: 0x001AED9B File Offset: 0x001ACF9B
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<FGameplayEffectSpecHandle, FActiveGameplayEffectHandle>) ?? ((Action<FGameplayEffectSpecHandle, FActiveGameplayEffectHandle>)Delegate.CreateDelegate(typeof(Action<FGameplayEffectSpecHandle, FActiveGameplayEffectHandle>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601255C RID: 75100 RVA: 0x001AEDCD File Offset: 0x001ACFCD
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<FGameplayEffectSpecHandle, FActiveGameplayEffectHandle> Callback)
		{
			if (FGameplayEffectBlockedDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FGameplayEffectBlockedDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FGameplayEffectBlockedDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FGameplayEffectBlockedDelegate.OnScriptCallback));
				}
				FGameplayEffectBlockedDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FGameplayEffectBlockedDelegate.RegisterId);
		}

		// Token: 0x0601255D RID: 75101 RVA: 0x001AEE07 File Offset: 0x001AD007
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<FGameplayEffectSpecHandle, FActiveGameplayEffectHandle> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601255E RID: 75102 RVA: 0x001AEE10 File Offset: 0x001AD010
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(FGameplayEffectSpecHandle BlockedSpec, FActiveGameplayEffectHandle ImmunityGameplayEffectHandle)
		{
			FGameplayEffectBlockedDelegate.__FGameplayEffectBlockedDelegate_DelegateParams* ptr = stackalloc FGameplayEffectBlockedDelegate.__FGameplayEffectBlockedDelegate_DelegateParams[(UIntPtr)39] + 15L / (long)sizeof(FGameplayEffectBlockedDelegate.__FGameplayEffectBlockedDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FGameplayEffectBlockedDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			if (BlockedSpec != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayEffectSpecHandle.StaticStruct(), &ptr->BlockedSpec, BlockedSpec.NativePtr, 1, false);
			}
			if (ImmunityGameplayEffectHandle != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FActiveGameplayEffectHandle.StaticStruct(), &ptr->ImmunityGameplayEffectHandle, ImmunityGameplayEffectHandle.NativePtr, 1, false);
			}
			base.BroadcastInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FGameplayEffectBlockedDelegate._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601255F RID: 75103 RVA: 0x001AEE9C File Offset: 0x001AD09C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<FGameplayEffectSpecHandle, FActiveGameplayEffectHandle> action = target as Action<FGameplayEffectSpecHandle, FActiveGameplayEffectHandle>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			FGameplayEffectSpecHandle arg = new FGameplayEffectSpecHandle(&((FGameplayEffectBlockedDelegate.__FGameplayEffectBlockedDelegate_DelegateParams*)__Parameters)->BlockedSpec, true, true);
			FActiveGameplayEffectHandle arg2 = new FActiveGameplayEffectHandle(&((FGameplayEffectBlockedDelegate.__FGameplayEffectBlockedDelegate_DelegateParams*)__Parameters)->ImmunityGameplayEffectHandle, true, true);
			action(arg, arg2);
		}

		// Token: 0x04009D0D RID: 40205
		internal static IntPtr _FunctionPtr;

		// Token: 0x04009D0E RID: 40206
		[Nullable(1)]
		public const string __ObjectPath = "/Script/GameplayAbilities.GameplayEffectBlockedDelegate__DelegateSignature";

		// Token: 0x04009D0F RID: 40207
		private static int RegisterId;

		// Token: 0x02002E41 RID: 11841
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __FGameplayEffectBlockedDelegate_DelegateParams
		{
			// Token: 0x040168F7 RID: 92407
			[FieldOffset(0)]
			public byte BlockedSpec;

			// Token: 0x040168F8 RID: 92408
			[FieldOffset(16)]
			public byte ImmunityGameplayEffectHandle;
		}

		// Token: 0x02002E42 RID: 11842
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040168F9 RID: 92409
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
