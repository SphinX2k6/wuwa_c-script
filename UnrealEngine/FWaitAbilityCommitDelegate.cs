using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020013BB RID: 5051
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FWaitAbilityCommitDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06012851 RID: 75857 RVA: 0x001B3B79 File Offset: 0x001B1D79
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FWaitAbilityCommitDelegate.StaticFunctionPtr();
		}

		// Token: 0x06012852 RID: 75858 RVA: 0x001B3B85 File Offset: 0x001B1D85
		private static IntPtr StaticFunctionPtr()
		{
			if (FWaitAbilityCommitDelegate._FunctionPtr == IntPtr.Zero)
			{
				FWaitAbilityCommitDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/GameplayAbilities.WaitAbilityCommitDelegate__DelegateSignature");
			}
			return FWaitAbilityCommitDelegate._FunctionPtr;
		}

		// Token: 0x06012853 RID: 75859 RVA: 0x001B3BA8 File Offset: 0x001B1DA8
		public FWaitAbilityCommitDelegate()
		{
		}

		// Token: 0x06012854 RID: 75860 RVA: 0x001B3BB0 File Offset: 0x001B1DB0
		[NullableContext(2)]
		public FWaitAbilityCommitDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06012855 RID: 75861 RVA: 0x001B3BBA File Offset: 0x001B1DBA
		public FWaitAbilityCommitDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06012856 RID: 75862 RVA: 0x001B3BC5 File Offset: 0x001B1DC5
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<UGameplayAbility>) ?? ((Action<UGameplayAbility>)Delegate.CreateDelegate(typeof(Action<UGameplayAbility>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06012857 RID: 75863 RVA: 0x001B3BF7 File Offset: 0x001B1DF7
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<UGameplayAbility> Callback)
		{
			if (FWaitAbilityCommitDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FWaitAbilityCommitDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FWaitAbilityCommitDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FWaitAbilityCommitDelegate.OnScriptCallback));
				}
				FWaitAbilityCommitDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FWaitAbilityCommitDelegate.RegisterId);
		}

		// Token: 0x06012858 RID: 75864 RVA: 0x001B3C31 File Offset: 0x001B1E31
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<UGameplayAbility> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06012859 RID: 75865 RVA: 0x001B3C3C File Offset: 0x001B1E3C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(UGameplayAbility ActivatedAbility)
		{
			FWaitAbilityCommitDelegate.__FWaitAbilityCommitDelegate_DelegateParams* ptr = stackalloc FWaitAbilityCommitDelegate.__FWaitAbilityCommitDelegate_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FWaitAbilityCommitDelegate.__FWaitAbilityCommitDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FWaitAbilityCommitDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->ActivatedAbility = ((ActivatedAbility != null) ? ActivatedAbility.NativePtr : IntPtr.Zero);
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0601285A RID: 75866 RVA: 0x001B3C88 File Offset: 0x001B1E88
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
			UGameplayAbility orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UGameplayAbility>(((FWaitAbilityCommitDelegate.__FWaitAbilityCommitDelegate_DelegateParams*)__Parameters)->ActivatedAbility);
			action(orCreateUObjectByNativePointer);
		}

		// Token: 0x04009E7C RID: 40572
		internal static IntPtr _FunctionPtr;

		// Token: 0x04009E7D RID: 40573
		[Nullable(1)]
		public const string __ObjectPath = "/Script/GameplayAbilities.WaitAbilityCommitDelegate__DelegateSignature";

		// Token: 0x04009E7E RID: 40574
		private static int RegisterId;

		// Token: 0x02002E56 RID: 11862
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __FWaitAbilityCommitDelegate_DelegateParams
		{
			// Token: 0x04016912 RID: 92434
			[FieldOffset(0)]
			public IntPtr ActivatedAbility;
		}

		// Token: 0x02002E57 RID: 11863
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016913 RID: 92435
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
