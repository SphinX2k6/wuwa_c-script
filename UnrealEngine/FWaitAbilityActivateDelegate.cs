using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020013BA RID: 5050
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FWaitAbilityActivateDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06012847 RID: 75847 RVA: 0x001B3A1A File Offset: 0x001B1C1A
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FWaitAbilityActivateDelegate.StaticFunctionPtr();
		}

		// Token: 0x06012848 RID: 75848 RVA: 0x001B3A26 File Offset: 0x001B1C26
		private static IntPtr StaticFunctionPtr()
		{
			if (FWaitAbilityActivateDelegate._FunctionPtr == IntPtr.Zero)
			{
				FWaitAbilityActivateDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/GameplayAbilities.WaitAbilityActivateDelegate__DelegateSignature");
			}
			return FWaitAbilityActivateDelegate._FunctionPtr;
		}

		// Token: 0x06012849 RID: 75849 RVA: 0x001B3A49 File Offset: 0x001B1C49
		public FWaitAbilityActivateDelegate()
		{
		}

		// Token: 0x0601284A RID: 75850 RVA: 0x001B3A51 File Offset: 0x001B1C51
		[NullableContext(2)]
		public FWaitAbilityActivateDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601284B RID: 75851 RVA: 0x001B3A5B File Offset: 0x001B1C5B
		public FWaitAbilityActivateDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601284C RID: 75852 RVA: 0x001B3A66 File Offset: 0x001B1C66
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<UGameplayAbility>) ?? ((Action<UGameplayAbility>)Delegate.CreateDelegate(typeof(Action<UGameplayAbility>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601284D RID: 75853 RVA: 0x001B3A98 File Offset: 0x001B1C98
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<UGameplayAbility> Callback)
		{
			if (FWaitAbilityActivateDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FWaitAbilityActivateDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FWaitAbilityActivateDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FWaitAbilityActivateDelegate.OnScriptCallback));
				}
				FWaitAbilityActivateDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FWaitAbilityActivateDelegate.RegisterId);
		}

		// Token: 0x0601284E RID: 75854 RVA: 0x001B3AD2 File Offset: 0x001B1CD2
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<UGameplayAbility> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601284F RID: 75855 RVA: 0x001B3ADC File Offset: 0x001B1CDC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(UGameplayAbility ActivatedAbility)
		{
			FWaitAbilityActivateDelegate.__FWaitAbilityActivateDelegate_DelegateParams* ptr = stackalloc FWaitAbilityActivateDelegate.__FWaitAbilityActivateDelegate_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FWaitAbilityActivateDelegate.__FWaitAbilityActivateDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FWaitAbilityActivateDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->ActivatedAbility = ((ActivatedAbility != null) ? ActivatedAbility.NativePtr : IntPtr.Zero);
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x06012850 RID: 75856 RVA: 0x001B3B28 File Offset: 0x001B1D28
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<UGameplayAbility> action = target as Action<UGameplayAbility>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			UGameplayAbility orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UGameplayAbility>(((FWaitAbilityActivateDelegate.__FWaitAbilityActivateDelegate_DelegateParams*)__Parameters)->ActivatedAbility);
			action(orCreateUObjectByNativePointer);
		}

		// Token: 0x04009E79 RID: 40569
		internal static IntPtr _FunctionPtr;

		// Token: 0x04009E7A RID: 40570
		[Nullable(1)]
		public const string __ObjectPath = "/Script/GameplayAbilities.WaitAbilityActivateDelegate__DelegateSignature";

		// Token: 0x04009E7B RID: 40571
		private static int RegisterId;

		// Token: 0x02002E54 RID: 11860
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __FWaitAbilityActivateDelegate_DelegateParams
		{
			// Token: 0x04016910 RID: 92432
			[FieldOffset(0)]
			public IntPtr ActivatedAbility;
		}

		// Token: 0x02002E55 RID: 11861
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016911 RID: 92433
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
