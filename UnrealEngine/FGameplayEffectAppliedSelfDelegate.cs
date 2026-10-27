using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200137C RID: 4988
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FGameplayEffectAppliedSelfDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06012518 RID: 75032 RVA: 0x001AE602 File Offset: 0x001AC802
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FGameplayEffectAppliedSelfDelegate.StaticFunctionPtr();
		}

		// Token: 0x06012519 RID: 75033 RVA: 0x001AE60E File Offset: 0x001AC80E
		private static IntPtr StaticFunctionPtr()
		{
			if (FGameplayEffectAppliedSelfDelegate._FunctionPtr == IntPtr.Zero)
			{
				FGameplayEffectAppliedSelfDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/GameplayAbilities.GameplayEffectAppliedSelfDelegate__DelegateSignature");
			}
			return FGameplayEffectAppliedSelfDelegate._FunctionPtr;
		}

		// Token: 0x0601251A RID: 75034 RVA: 0x001AE631 File Offset: 0x001AC831
		public FGameplayEffectAppliedSelfDelegate()
		{
		}

		// Token: 0x0601251B RID: 75035 RVA: 0x001AE639 File Offset: 0x001AC839
		[NullableContext(2)]
		public FGameplayEffectAppliedSelfDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601251C RID: 75036 RVA: 0x001AE643 File Offset: 0x001AC843
		public FGameplayEffectAppliedSelfDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601251D RID: 75037 RVA: 0x001AE64E File Offset: 0x001AC84E
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<AActor, FGameplayEffectSpecHandle, FActiveGameplayEffectHandle>) ?? ((Action<AActor, FGameplayEffectSpecHandle, FActiveGameplayEffectHandle>)Delegate.CreateDelegate(typeof(Action<AActor, FGameplayEffectSpecHandle, FActiveGameplayEffectHandle>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601251E RID: 75038 RVA: 0x001AE680 File Offset: 0x001AC880
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2,
			1,
			1
		})] Action<AActor, FGameplayEffectSpecHandle, FActiveGameplayEffectHandle> Callback)
		{
			if (FGameplayEffectAppliedSelfDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FGameplayEffectAppliedSelfDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FGameplayEffectAppliedSelfDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FGameplayEffectAppliedSelfDelegate.OnScriptCallback));
				}
				FGameplayEffectAppliedSelfDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FGameplayEffectAppliedSelfDelegate.RegisterId);
		}

		// Token: 0x0601251F RID: 75039 RVA: 0x001AE6BA File Offset: 0x001AC8BA
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

		// Token: 0x06012520 RID: 75040 RVA: 0x001AE6C4 File Offset: 0x001AC8C4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(AActor Source, FGameplayEffectSpecHandle SpecHandle, FActiveGameplayEffectHandle ActiveHandle)
		{
			FGameplayEffectAppliedSelfDelegate.__FGameplayEffectAppliedSelfDelegate_DelegateParams* ptr = stackalloc FGameplayEffectAppliedSelfDelegate.__FGameplayEffectAppliedSelfDelegate_DelegateParams[(UIntPtr)47] + 15L / (long)sizeof(FGameplayEffectAppliedSelfDelegate.__FGameplayEffectAppliedSelfDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FGameplayEffectAppliedSelfDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Source = ((Source != null) ? Source.NativePtr : IntPtr.Zero);
			if (SpecHandle != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayEffectSpecHandle.StaticStruct(), &ptr->SpecHandle, SpecHandle.NativePtr, 1, false);
			}
			if (ActiveHandle != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FActiveGameplayEffectHandle.StaticStruct(), &ptr->ActiveHandle, ActiveHandle.NativePtr, 1, false);
			}
			base.BroadcastInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FGameplayEffectAppliedSelfDelegate._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06012521 RID: 75041 RVA: 0x001AE764 File Offset: 0x001AC964
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
			AActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(((FGameplayEffectAppliedSelfDelegate.__FGameplayEffectAppliedSelfDelegate_DelegateParams*)__Parameters)->Source);
			FGameplayEffectSpecHandle arg = new FGameplayEffectSpecHandle(&((FGameplayEffectAppliedSelfDelegate.__FGameplayEffectAppliedSelfDelegate_DelegateParams*)__Parameters)->SpecHandle, true, true);
			FActiveGameplayEffectHandle arg2 = new FActiveGameplayEffectHandle(&((FGameplayEffectAppliedSelfDelegate.__FGameplayEffectAppliedSelfDelegate_DelegateParams*)__Parameters)->ActiveHandle, true, true);
			action(orCreateUObjectByNativePointer, arg, arg2);
		}

		// Token: 0x04009CF4 RID: 40180
		internal static IntPtr _FunctionPtr;

		// Token: 0x04009CF5 RID: 40181
		[Nullable(1)]
		public const string __ObjectPath = "/Script/GameplayAbilities.GameplayEffectAppliedSelfDelegate__DelegateSignature";

		// Token: 0x04009CF6 RID: 40182
		private static int RegisterId;

		// Token: 0x02002E3D RID: 11837
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __FGameplayEffectAppliedSelfDelegate_DelegateParams
		{
			// Token: 0x040168EF RID: 92399
			[FieldOffset(0)]
			public IntPtr Source;

			// Token: 0x040168F0 RID: 92400
			[FieldOffset(8)]
			public byte SpecHandle;

			// Token: 0x040168F1 RID: 92401
			[FieldOffset(24)]
			public byte ActiveHandle;
		}

		// Token: 0x02002E3E RID: 11838
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040168F2 RID: 92402
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
