using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200196B RID: 6507
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnGameplayCueNotify : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06018304 RID: 99076 RVA: 0x0023A5A8 File Offset: 0x002387A8
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnGameplayCueNotify.StaticFunctionPtr();
		}

		// Token: 0x06018305 RID: 99077 RVA: 0x0023A5B4 File Offset: 0x002387B4
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnGameplayCueNotify._FunctionPtr == IntPtr.Zero)
			{
				FOnGameplayCueNotify._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroGAS.OnGameplayCueNotify__DelegateSignature");
			}
			return FOnGameplayCueNotify._FunctionPtr;
		}

		// Token: 0x06018306 RID: 99078 RVA: 0x0023A5D7 File Offset: 0x002387D7
		public FOnGameplayCueNotify()
		{
		}

		// Token: 0x06018307 RID: 99079 RVA: 0x0023A5DF File Offset: 0x002387DF
		[NullableContext(2)]
		public FOnGameplayCueNotify(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06018308 RID: 99080 RVA: 0x0023A5E9 File Offset: 0x002387E9
		public FOnGameplayCueNotify(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06018309 RID: 99081 RVA: 0x0023A5F4 File Offset: 0x002387F4
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<FActiveGameplayEffectHandle, FGameplayEffectContextHandle, long, bool>) ?? ((Action<FActiveGameplayEffectHandle, FGameplayEffectContextHandle, long, bool>)Delegate.CreateDelegate(typeof(Action<FActiveGameplayEffectHandle, FGameplayEffectContextHandle, long, bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601830A RID: 99082 RVA: 0x0023A626 File Offset: 0x00238826
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<FActiveGameplayEffectHandle, FGameplayEffectContextHandle, long, bool> Callback)
		{
			if (FOnGameplayCueNotify.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnGameplayCueNotify.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnGameplayCueNotify.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnGameplayCueNotify.OnScriptCallback));
				}
				FOnGameplayCueNotify.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnGameplayCueNotify.RegisterId);
		}

		// Token: 0x0601830B RID: 99083 RVA: 0x0023A660 File Offset: 0x00238860
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<FActiveGameplayEffectHandle, FGameplayEffectContextHandle, long, bool> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601830C RID: 99084 RVA: 0x0023A66C File Offset: 0x0023886C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(FActiveGameplayEffectHandle ActiveHandle, FGameplayEffectContextHandle ContextHandle, long GameplayCueId, bool bIsAdd)
		{
			FOnGameplayCueNotify.__FOnGameplayCueNotify_DelegateParams* ptr = stackalloc FOnGameplayCueNotify.__FOnGameplayCueNotify_DelegateParams[(UIntPtr)63] + 15L / (long)sizeof(FOnGameplayCueNotify.__FOnGameplayCueNotify_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnGameplayCueNotify.StaticFunctionPtr(), (void*)ptr, 1);
			if (ActiveHandle != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FActiveGameplayEffectHandle.StaticStruct(), &ptr->ActiveHandle, ActiveHandle.NativePtr, 1, false);
			}
			if (ContextHandle != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayEffectContextHandle.StaticStruct(), &ptr->ContextHandle, ContextHandle.NativePtr, 1, false);
			}
			ptr->GameplayCueId = GameplayCueId;
			ptr->bIsAdd = bIsAdd;
			base.BroadcastInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FOnGameplayCueNotify._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601830D RID: 99085 RVA: 0x0023A708 File Offset: 0x00238908
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<FActiveGameplayEffectHandle, FGameplayEffectContextHandle, long, bool> action = target as Action<FActiveGameplayEffectHandle, FGameplayEffectContextHandle, long, bool>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			FActiveGameplayEffectHandle arg = new FActiveGameplayEffectHandle(&((FOnGameplayCueNotify.__FOnGameplayCueNotify_DelegateParams*)__Parameters)->ActiveHandle, true, true);
			FGameplayEffectContextHandle arg2 = new FGameplayEffectContextHandle(&((FOnGameplayCueNotify.__FOnGameplayCueNotify_DelegateParams*)__Parameters)->ContextHandle, true, true);
			action(arg, arg2, ((FOnGameplayCueNotify.__FOnGameplayCueNotify_DelegateParams*)__Parameters)->GameplayCueId, ((FOnGameplayCueNotify.__FOnGameplayCueNotify_DelegateParams*)__Parameters)->bIsAdd);
		}

		// Token: 0x0400D1B7 RID: 53687
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400D1B8 RID: 53688
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGAS.OnGameplayCueNotify__DelegateSignature";

		// Token: 0x0400D1B9 RID: 53689
		private static int RegisterId;

		// Token: 0x02003058 RID: 12376
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __FOnGameplayCueNotify_DelegateParams
		{
			// Token: 0x04016D1D RID: 93469
			[FieldOffset(0)]
			public byte ActiveHandle;

			// Token: 0x04016D1E RID: 93470
			[FieldOffset(8)]
			public byte ContextHandle;

			// Token: 0x04016D1F RID: 93471
			[FieldOffset(32)]
			public long GameplayCueId;

			// Token: 0x04016D20 RID: 93472
			[FieldOffset(40)]
			public bool bIsAdd;
		}

		// Token: 0x02003059 RID: 12377
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016D21 RID: 93473
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
