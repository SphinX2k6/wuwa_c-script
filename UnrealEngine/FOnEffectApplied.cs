using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200196A RID: 6506
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnEffectApplied : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060182FA RID: 99066 RVA: 0x0023A43A File Offset: 0x0023863A
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnEffectApplied.StaticFunctionPtr();
		}

		// Token: 0x060182FB RID: 99067 RVA: 0x0023A446 File Offset: 0x00238646
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnEffectApplied._FunctionPtr == IntPtr.Zero)
			{
				FOnEffectApplied._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroGAS.OnEffectApplied__DelegateSignature");
			}
			return FOnEffectApplied._FunctionPtr;
		}

		// Token: 0x060182FC RID: 99068 RVA: 0x0023A469 File Offset: 0x00238669
		public FOnEffectApplied()
		{
		}

		// Token: 0x060182FD RID: 99069 RVA: 0x0023A471 File Offset: 0x00238671
		[NullableContext(2)]
		public FOnEffectApplied(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060182FE RID: 99070 RVA: 0x0023A47B File Offset: 0x0023867B
		public FOnEffectApplied(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060182FF RID: 99071 RVA: 0x0023A486 File Offset: 0x00238686
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<FActiveGameplayEffectHandle>) ?? ((Action<FActiveGameplayEffectHandle>)Delegate.CreateDelegate(typeof(Action<FActiveGameplayEffectHandle>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06018300 RID: 99072 RVA: 0x0023A4B8 File Offset: 0x002386B8
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<FActiveGameplayEffectHandle> Callback)
		{
			if (FOnEffectApplied.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnEffectApplied.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnEffectApplied.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnEffectApplied.OnScriptCallback));
				}
				FOnEffectApplied.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnEffectApplied.RegisterId);
		}

		// Token: 0x06018301 RID: 99073 RVA: 0x0023A4F2 File Offset: 0x002386F2
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<FActiveGameplayEffectHandle> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06018302 RID: 99074 RVA: 0x0023A4FC File Offset: 0x002386FC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(FActiveGameplayEffectHandle ActiveHandle)
		{
			FOnEffectApplied.__FOnEffectApplied_DelegateParams* ptr = stackalloc FOnEffectApplied.__FOnEffectApplied_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FOnEffectApplied.__FOnEffectApplied_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnEffectApplied.StaticFunctionPtr(), (void*)ptr, 1);
			if (ActiveHandle != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FActiveGameplayEffectHandle.StaticStruct(), &ptr->ActiveHandle, ActiveHandle.NativePtr, 1, false);
			}
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x06018303 RID: 99075 RVA: 0x0023A554 File Offset: 0x00238754
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<FActiveGameplayEffectHandle> action = target as Action<FActiveGameplayEffectHandle>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			FActiveGameplayEffectHandle obj = new FActiveGameplayEffectHandle(&((FOnEffectApplied.__FOnEffectApplied_DelegateParams*)__Parameters)->ActiveHandle, true, true);
			action(obj);
		}

		// Token: 0x0400D1B4 RID: 53684
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400D1B5 RID: 53685
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGAS.OnEffectApplied__DelegateSignature";

		// Token: 0x0400D1B6 RID: 53686
		private static int RegisterId;

		// Token: 0x02003056 RID: 12374
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __FOnEffectApplied_DelegateParams
		{
			// Token: 0x04016D1B RID: 93467
			[FieldOffset(0)]
			public byte ActiveHandle;
		}

		// Token: 0x02003057 RID: 12375
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016D1C RID: 93468
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
