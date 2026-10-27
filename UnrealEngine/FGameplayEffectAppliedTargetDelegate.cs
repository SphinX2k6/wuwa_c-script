using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200137D RID: 4989
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FGameplayEffectAppliedTargetDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06012522 RID: 75042 RVA: 0x001AE7D8 File Offset: 0x001AC9D8
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FGameplayEffectAppliedTargetDelegate.StaticFunctionPtr();
		}

		// Token: 0x06012523 RID: 75043 RVA: 0x001AE7E4 File Offset: 0x001AC9E4
		private static IntPtr StaticFunctionPtr()
		{
			if (FGameplayEffectAppliedTargetDelegate._FunctionPtr == IntPtr.Zero)
			{
				FGameplayEffectAppliedTargetDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/GameplayAbilities.GameplayEffectAppliedTargetDelegate__DelegateSignature");
			}
			return FGameplayEffectAppliedTargetDelegate._FunctionPtr;
		}

		// Token: 0x06012524 RID: 75044 RVA: 0x001AE807 File Offset: 0x001ACA07
		public FGameplayEffectAppliedTargetDelegate()
		{
		}

		// Token: 0x06012525 RID: 75045 RVA: 0x001AE80F File Offset: 0x001ACA0F
		[NullableContext(2)]
		public FGameplayEffectAppliedTargetDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06012526 RID: 75046 RVA: 0x001AE819 File Offset: 0x001ACA19
		public FGameplayEffectAppliedTargetDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06012527 RID: 75047 RVA: 0x001AE824 File Offset: 0x001ACA24
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<AActor, FGameplayEffectSpecHandle, FActiveGameplayEffectHandle>) ?? ((Action<AActor, FGameplayEffectSpecHandle, FActiveGameplayEffectHandle>)Delegate.CreateDelegate(typeof(Action<AActor, FGameplayEffectSpecHandle, FActiveGameplayEffectHandle>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06012528 RID: 75048 RVA: 0x001AE856 File Offset: 0x001ACA56
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2,
			1,
			1
		})] Action<AActor, FGameplayEffectSpecHandle, FActiveGameplayEffectHandle> Callback)
		{
			if (FGameplayEffectAppliedTargetDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FGameplayEffectAppliedTargetDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FGameplayEffectAppliedTargetDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FGameplayEffectAppliedTargetDelegate.OnScriptCallback));
				}
				FGameplayEffectAppliedTargetDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FGameplayEffectAppliedTargetDelegate.RegisterId);
		}

		// Token: 0x06012529 RID: 75049 RVA: 0x001AE890 File Offset: 0x001ACA90
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2,
			1,
			1
		})] Action<AActor, FGameplayEffectSpecHandle, FActiveGameplayEffectHandle> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601252A RID: 75050 RVA: 0x001AE89C File Offset: 0x001ACA9C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(AActor Target, FGameplayEffectSpecHandle SpecHandle, FActiveGameplayEffectHandle ActiveHandle)
		{
			FGameplayEffectAppliedTargetDelegate.__FGameplayEffectAppliedTargetDelegate_DelegateParams* ptr = stackalloc FGameplayEffectAppliedTargetDelegate.__FGameplayEffectAppliedTargetDelegate_DelegateParams[(UIntPtr)47] + 15L / (long)sizeof(FGameplayEffectAppliedTargetDelegate.__FGameplayEffectAppliedTargetDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FGameplayEffectAppliedTargetDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Target = ((Target != null) ? Target.NativePtr : IntPtr.Zero);
			if (SpecHandle != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayEffectSpecHandle.StaticStruct(), &ptr->SpecHandle, SpecHandle.NativePtr, 1, false);
			}
			if (ActiveHandle != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FActiveGameplayEffectHandle.StaticStruct(), &ptr->ActiveHandle, ActiveHandle.NativePtr, 1, false);
			}
			base.BroadcastInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FGameplayEffectAppliedTargetDelegate._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601252B RID: 75051 RVA: 0x001AE93C File Offset: 0x001ACB3C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<AActor, FGameplayEffectSpecHandle, FActiveGameplayEffectHandle> action = target as Action<AActor, FGameplayEffectSpecHandle, FActiveGameplayEffectHandle>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			AActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(((FGameplayEffectAppliedTargetDelegate.__FGameplayEffectAppliedTargetDelegate_DelegateParams*)__Parameters)->Target);
			FGameplayEffectSpecHandle arg = new FGameplayEffectSpecHandle(&((FGameplayEffectAppliedTargetDelegate.__FGameplayEffectAppliedTargetDelegate_DelegateParams*)__Parameters)->SpecHandle, true, true);
			FActiveGameplayEffectHandle arg2 = new FActiveGameplayEffectHandle(&((FGameplayEffectAppliedTargetDelegate.__FGameplayEffectAppliedTargetDelegate_DelegateParams*)__Parameters)->ActiveHandle, true, true);
			action(orCreateUObjectByNativePointer, arg, arg2);
		}

		// Token: 0x04009CF7 RID: 40183
		internal static IntPtr _FunctionPtr;

		// Token: 0x04009CF8 RID: 40184
		[Nullable(1)]
		public const string __ObjectPath = "/Script/GameplayAbilities.GameplayEffectAppliedTargetDelegate__DelegateSignature";

		// Token: 0x04009CF9 RID: 40185
		private static int RegisterId;

		// Token: 0x02002E3F RID: 11839
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __FGameplayEffectAppliedTargetDelegate_DelegateParams
		{
			// Token: 0x040168F3 RID: 92403
			[FieldOffset(0)]
			public IntPtr Target;

			// Token: 0x040168F4 RID: 92404
			[FieldOffset(8)]
			public byte SpecHandle;

			// Token: 0x040168F5 RID: 92405
			[FieldOffset(24)]
			public byte ActiveHandle;
		}

		// Token: 0x02002E40 RID: 11840
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040168F6 RID: 92406
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
