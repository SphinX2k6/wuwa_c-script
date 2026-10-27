using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020013C5 RID: 5061
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FWaitOverlapDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060128B5 RID: 75957 RVA: 0x001B482E File Offset: 0x001B2A2E
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FWaitOverlapDelegate.StaticFunctionPtr();
		}

		// Token: 0x060128B6 RID: 75958 RVA: 0x001B483A File Offset: 0x001B2A3A
		private static IntPtr StaticFunctionPtr()
		{
			if (FWaitOverlapDelegate._FunctionPtr == IntPtr.Zero)
			{
				FWaitOverlapDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/GameplayAbilities.WaitOverlapDelegate__DelegateSignature");
			}
			return FWaitOverlapDelegate._FunctionPtr;
		}

		// Token: 0x060128B7 RID: 75959 RVA: 0x001B485D File Offset: 0x001B2A5D
		public FWaitOverlapDelegate()
		{
		}

		// Token: 0x060128B8 RID: 75960 RVA: 0x001B4865 File Offset: 0x001B2A65
		[NullableContext(2)]
		public FWaitOverlapDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060128B9 RID: 75961 RVA: 0x001B486F File Offset: 0x001B2A6F
		public FWaitOverlapDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060128BA RID: 75962 RVA: 0x001B487A File Offset: 0x001B2A7A
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<FGameplayAbilityTargetDataHandle>) ?? ((Action<FGameplayAbilityTargetDataHandle>)Delegate.CreateDelegate(typeof(Action<FGameplayAbilityTargetDataHandle>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060128BB RID: 75963 RVA: 0x001B48AC File Offset: 0x001B2AAC
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<FGameplayAbilityTargetDataHandle> Callback)
		{
			if (FWaitOverlapDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FWaitOverlapDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FWaitOverlapDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FWaitOverlapDelegate.OnScriptCallback));
				}
				FWaitOverlapDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FWaitOverlapDelegate.RegisterId);
		}

		// Token: 0x060128BC RID: 75964 RVA: 0x001B48E6 File Offset: 0x001B2AE6
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<FGameplayAbilityTargetDataHandle> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x060128BD RID: 75965 RVA: 0x001B48F0 File Offset: 0x001B2AF0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(in FGameplayAbilityTargetDataHandle TargetData)
		{
			FWaitOverlapDelegate.__FWaitOverlapDelegate_DelegateParams* ptr = stackalloc FWaitOverlapDelegate.__FWaitOverlapDelegate_DelegateParams[(UIntPtr)55] + 15L / (long)sizeof(FWaitOverlapDelegate.__FWaitOverlapDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FWaitOverlapDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			if (TargetData != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAbilityTargetDataHandle.StaticStruct(), &ptr->TargetData, TargetData.NativePtr, 1, false);
			}
			base.BroadcastInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FWaitOverlapDelegate._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060128BE RID: 75966 RVA: 0x001B495C File Offset: 0x001B2B5C
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
			FGameplayAbilityTargetDataHandle obj = new FGameplayAbilityTargetDataHandle(&((FWaitOverlapDelegate.__FWaitOverlapDelegate_DelegateParams*)__Parameters)->TargetData, true, true);
			action(obj);
		}

		// Token: 0x04009E9A RID: 40602
		internal static IntPtr _FunctionPtr;

		// Token: 0x04009E9B RID: 40603
		[Nullable(1)]
		public const string __ObjectPath = "/Script/GameplayAbilities.WaitOverlapDelegate__DelegateSignature";

		// Token: 0x04009E9C RID: 40604
		private static int RegisterId;

		// Token: 0x02002E66 RID: 11878
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __FWaitOverlapDelegate_DelegateParams
		{
			// Token: 0x04016927 RID: 92455
			[FieldOffset(0)]
			public byte TargetData;
		}

		// Token: 0x02002E67 RID: 11879
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016928 RID: 92456
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
