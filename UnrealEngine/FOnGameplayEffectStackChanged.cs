using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200196F RID: 6511
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnGameplayEffectStackChanged : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601832C RID: 99116 RVA: 0x0023AC4B File Offset: 0x00238E4B
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnGameplayEffectStackChanged.StaticFunctionPtr();
		}

		// Token: 0x0601832D RID: 99117 RVA: 0x0023AC57 File Offset: 0x00238E57
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnGameplayEffectStackChanged._FunctionPtr == IntPtr.Zero)
			{
				FOnGameplayEffectStackChanged._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroGAS.OnGameplayEffectStackChanged__DelegateSignature");
			}
			return FOnGameplayEffectStackChanged._FunctionPtr;
		}

		// Token: 0x0601832E RID: 99118 RVA: 0x0023AC7A File Offset: 0x00238E7A
		public FOnGameplayEffectStackChanged()
		{
		}

		// Token: 0x0601832F RID: 99119 RVA: 0x0023AC82 File Offset: 0x00238E82
		[NullableContext(2)]
		public FOnGameplayEffectStackChanged(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06018330 RID: 99120 RVA: 0x0023AC8C File Offset: 0x00238E8C
		public FOnGameplayEffectStackChanged(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06018331 RID: 99121 RVA: 0x0023AC97 File Offset: 0x00238E97
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<FActiveGameplayEffectHandle, int, int, bool>) ?? ((Action<FActiveGameplayEffectHandle, int, int, bool>)Delegate.CreateDelegate(typeof(Action<FActiveGameplayEffectHandle, int, int, bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06018332 RID: 99122 RVA: 0x0023ACC9 File Offset: 0x00238EC9
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<FActiveGameplayEffectHandle, int, int, bool> Callback)
		{
			if (FOnGameplayEffectStackChanged.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnGameplayEffectStackChanged.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnGameplayEffectStackChanged.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnGameplayEffectStackChanged.OnScriptCallback));
				}
				FOnGameplayEffectStackChanged.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnGameplayEffectStackChanged.RegisterId);
		}

		// Token: 0x06018333 RID: 99123 RVA: 0x0023AD03 File Offset: 0x00238F03
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<FActiveGameplayEffectHandle, int, int, bool> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06018334 RID: 99124 RVA: 0x0023AD0C File Offset: 0x00238F0C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(FActiveGameplayEffectHandle Handle, int NewStack, int OldStack, bool bPremature)
		{
			FOnGameplayEffectStackChanged.__FOnGameplayEffectStackChanged_DelegateParams* ptr = stackalloc FOnGameplayEffectStackChanged.__FOnGameplayEffectStackChanged_DelegateParams[(UIntPtr)35] + 15L / (long)sizeof(FOnGameplayEffectStackChanged.__FOnGameplayEffectStackChanged_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnGameplayEffectStackChanged.StaticFunctionPtr(), (void*)ptr, 1);
			if (Handle != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FActiveGameplayEffectHandle.StaticStruct(), &ptr->Handle, Handle.NativePtr, 1, false);
			}
			ptr->NewStack = NewStack;
			ptr->OldStack = OldStack;
			ptr->bPremature = bPremature;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x06018335 RID: 99125 RVA: 0x0023AD7C File Offset: 0x00238F7C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<FActiveGameplayEffectHandle, int, int, bool> action = target as Action<FActiveGameplayEffectHandle, int, int, bool>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			FActiveGameplayEffectHandle arg = new FActiveGameplayEffectHandle(&((FOnGameplayEffectStackChanged.__FOnGameplayEffectStackChanged_DelegateParams*)__Parameters)->Handle, true, true);
			action(arg, ((FOnGameplayEffectStackChanged.__FOnGameplayEffectStackChanged_DelegateParams*)__Parameters)->NewStack, ((FOnGameplayEffectStackChanged.__FOnGameplayEffectStackChanged_DelegateParams*)__Parameters)->OldStack, ((FOnGameplayEffectStackChanged.__FOnGameplayEffectStackChanged_DelegateParams*)__Parameters)->bPremature);
		}

		// Token: 0x0400D1C3 RID: 53699
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400D1C4 RID: 53700
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGAS.OnGameplayEffectStackChanged__DelegateSignature";

		// Token: 0x0400D1C5 RID: 53701
		private static int RegisterId;

		// Token: 0x02003060 RID: 12384
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 20)]
		protected ref struct __FOnGameplayEffectStackChanged_DelegateParams
		{
			// Token: 0x04016D2B RID: 93483
			[FieldOffset(0)]
			public byte Handle;

			// Token: 0x04016D2C RID: 93484
			[FieldOffset(8)]
			public int NewStack;

			// Token: 0x04016D2D RID: 93485
			[FieldOffset(12)]
			public int OldStack;

			// Token: 0x04016D2E RID: 93486
			[FieldOffset(16)]
			public bool bPremature;
		}

		// Token: 0x02003061 RID: 12385
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016D2F RID: 93487
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
