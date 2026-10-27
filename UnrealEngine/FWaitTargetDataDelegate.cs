using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020013C6 RID: 5062
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FWaitTargetDataDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060128BF RID: 75967 RVA: 0x001B49B0 File Offset: 0x001B2BB0
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FWaitTargetDataDelegate.StaticFunctionPtr();
		}

		// Token: 0x060128C0 RID: 75968 RVA: 0x001B49BC File Offset: 0x001B2BBC
		private static IntPtr StaticFunctionPtr()
		{
			if (FWaitTargetDataDelegate._FunctionPtr == IntPtr.Zero)
			{
				FWaitTargetDataDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/GameplayAbilities.WaitTargetDataDelegate__DelegateSignature");
			}
			return FWaitTargetDataDelegate._FunctionPtr;
		}

		// Token: 0x060128C1 RID: 75969 RVA: 0x001B49DF File Offset: 0x001B2BDF
		public FWaitTargetDataDelegate()
		{
		}

		// Token: 0x060128C2 RID: 75970 RVA: 0x001B49E7 File Offset: 0x001B2BE7
		[NullableContext(2)]
		public FWaitTargetDataDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060128C3 RID: 75971 RVA: 0x001B49F1 File Offset: 0x001B2BF1
		public FWaitTargetDataDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060128C4 RID: 75972 RVA: 0x001B49FC File Offset: 0x001B2BFC
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<FGameplayAbilityTargetDataHandle>) ?? ((Action<FGameplayAbilityTargetDataHandle>)Delegate.CreateDelegate(typeof(Action<FGameplayAbilityTargetDataHandle>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060128C5 RID: 75973 RVA: 0x001B4A2E File Offset: 0x001B2C2E
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<FGameplayAbilityTargetDataHandle> Callback)
		{
			if (FWaitTargetDataDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FWaitTargetDataDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FWaitTargetDataDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FWaitTargetDataDelegate.OnScriptCallback));
				}
				FWaitTargetDataDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FWaitTargetDataDelegate.RegisterId);
		}

		// Token: 0x060128C6 RID: 75974 RVA: 0x001B4A68 File Offset: 0x001B2C68
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<FGameplayAbilityTargetDataHandle> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x060128C7 RID: 75975 RVA: 0x001B4A74 File Offset: 0x001B2C74
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(in FGameplayAbilityTargetDataHandle Data)
		{
			FWaitTargetDataDelegate.__FWaitTargetDataDelegate_DelegateParams* ptr = stackalloc FWaitTargetDataDelegate.__FWaitTargetDataDelegate_DelegateParams[(UIntPtr)55] + 15L / (long)sizeof(FWaitTargetDataDelegate.__FWaitTargetDataDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FWaitTargetDataDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			if (Data != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAbilityTargetDataHandle.StaticStruct(), &ptr->Data, Data.NativePtr, 1, false);
			}
			base.BroadcastInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FWaitTargetDataDelegate._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060128C8 RID: 75976 RVA: 0x001B4AE0 File Offset: 0x001B2CE0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<FGameplayAbilityTargetDataHandle> action = target as Action<FGameplayAbilityTargetDataHandle>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			FGameplayAbilityTargetDataHandle obj = new FGameplayAbilityTargetDataHandle(&((FWaitTargetDataDelegate.__FWaitTargetDataDelegate_DelegateParams*)__Parameters)->Data, true, true);
			action(obj);
		}

		// Token: 0x04009E9D RID: 40605
		internal static IntPtr _FunctionPtr;

		// Token: 0x04009E9E RID: 40606
		[Nullable(1)]
		public const string __ObjectPath = "/Script/GameplayAbilities.WaitTargetDataDelegate__DelegateSignature";

		// Token: 0x04009E9F RID: 40607
		private static int RegisterId;

		// Token: 0x02002E68 RID: 11880
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __FWaitTargetDataDelegate_DelegateParams
		{
			// Token: 0x04016929 RID: 92457
			[FieldOffset(0)]
			public byte Data;
		}

		// Token: 0x02002E69 RID: 11881
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401692A RID: 92458
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
