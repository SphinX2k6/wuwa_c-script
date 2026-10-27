using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200196E RID: 6510
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnGameplayEffectRemoved : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06018322 RID: 99106 RVA: 0x0023AA5E File Offset: 0x00238C5E
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnGameplayEffectRemoved.StaticFunctionPtr();
		}

		// Token: 0x06018323 RID: 99107 RVA: 0x0023AA6A File Offset: 0x00238C6A
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnGameplayEffectRemoved._FunctionPtr == IntPtr.Zero)
			{
				FOnGameplayEffectRemoved._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroGAS.OnGameplayEffectRemoved__DelegateSignature");
			}
			return FOnGameplayEffectRemoved._FunctionPtr;
		}

		// Token: 0x06018324 RID: 99108 RVA: 0x0023AA8D File Offset: 0x00238C8D
		public FOnGameplayEffectRemoved()
		{
		}

		// Token: 0x06018325 RID: 99109 RVA: 0x0023AA95 File Offset: 0x00238C95
		[NullableContext(2)]
		public FOnGameplayEffectRemoved(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06018326 RID: 99110 RVA: 0x0023AA9F File Offset: 0x00238C9F
		public FOnGameplayEffectRemoved(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06018327 RID: 99111 RVA: 0x0023AAAA File Offset: 0x00238CAA
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<FActiveGameplayEffectHandle, FGameplayEffectSpec, FGameplayEffectRemovalInfo>) ?? ((Action<FActiveGameplayEffectHandle, FGameplayEffectSpec, FGameplayEffectRemovalInfo>)Delegate.CreateDelegate(typeof(Action<FActiveGameplayEffectHandle, FGameplayEffectSpec, FGameplayEffectRemovalInfo>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06018328 RID: 99112 RVA: 0x0023AADC File Offset: 0x00238CDC
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<FActiveGameplayEffectHandle, FGameplayEffectSpec, FGameplayEffectRemovalInfo> Callback)
		{
			if (FOnGameplayEffectRemoved.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnGameplayEffectRemoved.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnGameplayEffectRemoved.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnGameplayEffectRemoved.OnScriptCallback));
				}
				FOnGameplayEffectRemoved.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnGameplayEffectRemoved.RegisterId);
		}

		// Token: 0x06018329 RID: 99113 RVA: 0x0023AB16 File Offset: 0x00238D16
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<FActiveGameplayEffectHandle, FGameplayEffectSpec, FGameplayEffectRemovalInfo> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601832A RID: 99114 RVA: 0x0023AB20 File Offset: 0x00238D20
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(FActiveGameplayEffectHandle Handle, FGameplayEffectSpec Spec, in FGameplayEffectRemovalInfo RemovalInfo)
		{
			FOnGameplayEffectRemoved.__FOnGameplayEffectRemoved_DelegateParams* ptr = stackalloc FOnGameplayEffectRemoved.__FOnGameplayEffectRemoved_DelegateParams[(UIntPtr)743] + 15L / (long)sizeof(FOnGameplayEffectRemoved.__FOnGameplayEffectRemoved_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnGameplayEffectRemoved.StaticFunctionPtr(), (void*)ptr, 1);
			if (Handle != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FActiveGameplayEffectHandle.StaticStruct(), &ptr->Handle, Handle.NativePtr, 1, false);
			}
			if (Spec != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayEffectSpec.StaticStruct(), &ptr->Spec, Spec.NativePtr, 1, false);
			}
			if (RemovalInfo != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayEffectRemovalInfo.StaticStruct(), &ptr->RemovalInfo, RemovalInfo.NativePtr, 1, false);
			}
			base.BroadcastInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FOnGameplayEffectRemoved._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601832B RID: 99115 RVA: 0x0023ABD4 File Offset: 0x00238DD4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<FActiveGameplayEffectHandle, FGameplayEffectSpec, FGameplayEffectRemovalInfo> action = target as Action<FActiveGameplayEffectHandle, FGameplayEffectSpec, FGameplayEffectRemovalInfo>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			FActiveGameplayEffectHandle arg = new FActiveGameplayEffectHandle(&((FOnGameplayEffectRemoved.__FOnGameplayEffectRemoved_DelegateParams*)__Parameters)->Handle, true, true);
			FGameplayEffectSpec arg2 = new FGameplayEffectSpec(&((FOnGameplayEffectRemoved.__FOnGameplayEffectRemoved_DelegateParams*)__Parameters)->Spec, true, true);
			FGameplayEffectRemovalInfo arg3 = new FGameplayEffectRemovalInfo(&((FOnGameplayEffectRemoved.__FOnGameplayEffectRemoved_DelegateParams*)__Parameters)->RemovalInfo, true, true);
			action(arg, arg2, arg3);
		}

		// Token: 0x0400D1C0 RID: 53696
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400D1C1 RID: 53697
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGAS.OnGameplayEffectRemoved__DelegateSignature";

		// Token: 0x0400D1C2 RID: 53698
		private static int RegisterId;

		// Token: 0x0200305E RID: 12382
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 728)]
		protected ref struct __FOnGameplayEffectRemoved_DelegateParams
		{
			// Token: 0x04016D27 RID: 93479
			[FieldOffset(0)]
			public byte Handle;

			// Token: 0x04016D28 RID: 93480
			[FieldOffset(8)]
			public byte Spec;

			// Token: 0x04016D29 RID: 93481
			[FieldOffset(696)]
			public byte RemovalInfo;
		}

		// Token: 0x0200305F RID: 12383
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016D2A RID: 93482
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
