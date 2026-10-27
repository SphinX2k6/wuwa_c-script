using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020013F4 RID: 5108
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FGameplayTaskSpawnActorDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06012A7D RID: 76413 RVA: 0x001B72CB File Offset: 0x001B54CB
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FGameplayTaskSpawnActorDelegate.StaticFunctionPtr();
		}

		// Token: 0x06012A7E RID: 76414 RVA: 0x001B72D7 File Offset: 0x001B54D7
		private static IntPtr StaticFunctionPtr()
		{
			if (FGameplayTaskSpawnActorDelegate._FunctionPtr == IntPtr.Zero)
			{
				FGameplayTaskSpawnActorDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/GameplayTasks.GameplayTaskSpawnActorDelegate__DelegateSignature");
			}
			return FGameplayTaskSpawnActorDelegate._FunctionPtr;
		}

		// Token: 0x06012A7F RID: 76415 RVA: 0x001B72FA File Offset: 0x001B54FA
		public FGameplayTaskSpawnActorDelegate()
		{
		}

		// Token: 0x06012A80 RID: 76416 RVA: 0x001B7302 File Offset: 0x001B5502
		[NullableContext(2)]
		public FGameplayTaskSpawnActorDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06012A81 RID: 76417 RVA: 0x001B730C File Offset: 0x001B550C
		public FGameplayTaskSpawnActorDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06012A82 RID: 76418 RVA: 0x001B7317 File Offset: 0x001B5517
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<AActor>) ?? ((Action<AActor>)Delegate.CreateDelegate(typeof(Action<AActor>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06012A83 RID: 76419 RVA: 0x001B7349 File Offset: 0x001B5549
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<AActor> Callback)
		{
			if (FGameplayTaskSpawnActorDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FGameplayTaskSpawnActorDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FGameplayTaskSpawnActorDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FGameplayTaskSpawnActorDelegate.OnScriptCallback));
				}
				FGameplayTaskSpawnActorDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FGameplayTaskSpawnActorDelegate.RegisterId);
		}

		// Token: 0x06012A84 RID: 76420 RVA: 0x001B7383 File Offset: 0x001B5583
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<AActor> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06012A85 RID: 76421 RVA: 0x001B738C File Offset: 0x001B558C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(AActor SpawnedActor)
		{
			FGameplayTaskSpawnActorDelegate.__FGameplayTaskSpawnActorDelegate_DelegateParams* ptr = stackalloc FGameplayTaskSpawnActorDelegate.__FGameplayTaskSpawnActorDelegate_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FGameplayTaskSpawnActorDelegate.__FGameplayTaskSpawnActorDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FGameplayTaskSpawnActorDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->SpawnedActor = ((SpawnedActor != null) ? SpawnedActor.NativePtr : IntPtr.Zero);
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x06012A86 RID: 76422 RVA: 0x001B73D8 File Offset: 0x001B55D8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<AActor> action = target as Action<AActor>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			AActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(((FGameplayTaskSpawnActorDelegate.__FGameplayTaskSpawnActorDelegate_DelegateParams*)__Parameters)->SpawnedActor);
			action(orCreateUObjectByNativePointer);
		}

		// Token: 0x04009F87 RID: 40839
		internal static IntPtr _FunctionPtr;

		// Token: 0x04009F88 RID: 40840
		[Nullable(1)]
		public const string __ObjectPath = "/Script/GameplayTasks.GameplayTaskSpawnActorDelegate__DelegateSignature";

		// Token: 0x04009F89 RID: 40841
		private static int RegisterId;

		// Token: 0x02002E73 RID: 11891
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __FGameplayTaskSpawnActorDelegate_DelegateParams
		{
			// Token: 0x0401693A RID: 92474
			[FieldOffset(0)]
			public IntPtr SpawnedActor;
		}

		// Token: 0x02002E74 RID: 11892
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401693B RID: 92475
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
