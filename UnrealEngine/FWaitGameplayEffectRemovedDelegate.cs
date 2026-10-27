using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020013C2 RID: 5058
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FWaitGameplayEffectRemovedDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06012897 RID: 75927 RVA: 0x001B43C2 File Offset: 0x001B25C2
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FWaitGameplayEffectRemovedDelegate.StaticFunctionPtr();
		}

		// Token: 0x06012898 RID: 75928 RVA: 0x001B43CE File Offset: 0x001B25CE
		private static IntPtr StaticFunctionPtr()
		{
			if (FWaitGameplayEffectRemovedDelegate._FunctionPtr == IntPtr.Zero)
			{
				FWaitGameplayEffectRemovedDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/GameplayAbilities.WaitGameplayEffectRemovedDelegate__DelegateSignature");
			}
			return FWaitGameplayEffectRemovedDelegate._FunctionPtr;
		}

		// Token: 0x06012899 RID: 75929 RVA: 0x001B43F1 File Offset: 0x001B25F1
		public FWaitGameplayEffectRemovedDelegate()
		{
		}

		// Token: 0x0601289A RID: 75930 RVA: 0x001B43F9 File Offset: 0x001B25F9
		[NullableContext(2)]
		public FWaitGameplayEffectRemovedDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601289B RID: 75931 RVA: 0x001B4403 File Offset: 0x001B2603
		public FWaitGameplayEffectRemovedDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601289C RID: 75932 RVA: 0x001B440E File Offset: 0x001B260E
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<FGameplayEffectRemovalInfo>) ?? ((Action<FGameplayEffectRemovalInfo>)Delegate.CreateDelegate(typeof(Action<FGameplayEffectRemovalInfo>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601289D RID: 75933 RVA: 0x001B4440 File Offset: 0x001B2640
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<FGameplayEffectRemovalInfo> Callback)
		{
			if (FWaitGameplayEffectRemovedDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FWaitGameplayEffectRemovedDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FWaitGameplayEffectRemovedDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FWaitGameplayEffectRemovedDelegate.OnScriptCallback));
				}
				FWaitGameplayEffectRemovedDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FWaitGameplayEffectRemovedDelegate.RegisterId);
		}

		// Token: 0x0601289E RID: 75934 RVA: 0x001B447A File Offset: 0x001B267A
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<FGameplayEffectRemovalInfo> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601289F RID: 75935 RVA: 0x001B4484 File Offset: 0x001B2684
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(in FGameplayEffectRemovalInfo GameplayEffectRemovalInfo)
		{
			FWaitGameplayEffectRemovedDelegate.__FWaitGameplayEffectRemovedDelegate_DelegateParams* ptr = stackalloc FWaitGameplayEffectRemovedDelegate.__FWaitGameplayEffectRemovedDelegate_DelegateParams[(UIntPtr)47] + 15L / (long)sizeof(FWaitGameplayEffectRemovedDelegate.__FWaitGameplayEffectRemovedDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FWaitGameplayEffectRemovedDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			if (GameplayEffectRemovalInfo != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayEffectRemovalInfo.StaticStruct(), &ptr->GameplayEffectRemovalInfo, GameplayEffectRemovalInfo.NativePtr, 1, false);
			}
			base.BroadcastInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FWaitGameplayEffectRemovedDelegate._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060128A0 RID: 75936 RVA: 0x001B44F0 File Offset: 0x001B26F0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<FGameplayEffectRemovalInfo> action = target as Action<FGameplayEffectRemovalInfo>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			FGameplayEffectRemovalInfo obj = new FGameplayEffectRemovalInfo(&((FWaitGameplayEffectRemovedDelegate.__FWaitGameplayEffectRemovedDelegate_DelegateParams*)__Parameters)->GameplayEffectRemovalInfo, true, true);
			action(obj);
		}

		// Token: 0x04009E91 RID: 40593
		internal static IntPtr _FunctionPtr;

		// Token: 0x04009E92 RID: 40594
		[Nullable(1)]
		public const string __ObjectPath = "/Script/GameplayAbilities.WaitGameplayEffectRemovedDelegate__DelegateSignature";

		// Token: 0x04009E93 RID: 40595
		private static int RegisterId;

		// Token: 0x02002E60 RID: 11872
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __FWaitGameplayEffectRemovedDelegate_DelegateParams
		{
			// Token: 0x0401691E RID: 92446
			[FieldOffset(0)]
			public byte GameplayEffectRemovalInfo;
		}

		// Token: 0x02002E61 RID: 11873
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401691F RID: 92447
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
