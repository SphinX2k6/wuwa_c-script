using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020013B5 RID: 5045
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FSpawnActorDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601281A RID: 75802 RVA: 0x001B3494 File Offset: 0x001B1694
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FSpawnActorDelegate.StaticFunctionPtr();
		}

		// Token: 0x0601281B RID: 75803 RVA: 0x001B34A0 File Offset: 0x001B16A0
		private static IntPtr StaticFunctionPtr()
		{
			if (FSpawnActorDelegate._FunctionPtr == IntPtr.Zero)
			{
				FSpawnActorDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/GameplayAbilities.SpawnActorDelegate__DelegateSignature");
			}
			return FSpawnActorDelegate._FunctionPtr;
		}

		// Token: 0x0601281C RID: 75804 RVA: 0x001B34C3 File Offset: 0x001B16C3
		public FSpawnActorDelegate()
		{
		}

		// Token: 0x0601281D RID: 75805 RVA: 0x001B34CB File Offset: 0x001B16CB
		[NullableContext(2)]
		public FSpawnActorDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601281E RID: 75806 RVA: 0x001B34D5 File Offset: 0x001B16D5
		public FSpawnActorDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601281F RID: 75807 RVA: 0x001B34E0 File Offset: 0x001B16E0
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<AActor>) ?? ((Action<AActor>)Delegate.CreateDelegate(typeof(Action<AActor>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06012820 RID: 75808 RVA: 0x001B3512 File Offset: 0x001B1712
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<AActor> Callback)
		{
			if (FSpawnActorDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FSpawnActorDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FSpawnActorDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FSpawnActorDelegate.OnScriptCallback));
				}
				FSpawnActorDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FSpawnActorDelegate.RegisterId);
		}

		// Token: 0x06012821 RID: 75809 RVA: 0x001B354C File Offset: 0x001B174C
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<AActor> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06012822 RID: 75810 RVA: 0x001B3558 File Offset: 0x001B1758
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(AActor SpawnedActor)
		{
			FSpawnActorDelegate.__FSpawnActorDelegate_DelegateParams* ptr = stackalloc FSpawnActorDelegate.__FSpawnActorDelegate_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FSpawnActorDelegate.__FSpawnActorDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FSpawnActorDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->SpawnedActor = ((SpawnedActor != null) ? SpawnedActor.NativePtr : IntPtr.Zero);
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x06012823 RID: 75811 RVA: 0x001B35A4 File Offset: 0x001B17A4
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
			AActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(((FSpawnActorDelegate.__FSpawnActorDelegate_DelegateParams*)__Parameters)->SpawnedActor);
			action(orCreateUObjectByNativePointer);
		}

		// Token: 0x04009E67 RID: 40551
		internal static IntPtr _FunctionPtr;

		// Token: 0x04009E68 RID: 40552
		[Nullable(1)]
		public const string __ObjectPath = "/Script/GameplayAbilities.SpawnActorDelegate__DelegateSignature";

		// Token: 0x04009E69 RID: 40553
		private static int RegisterId;

		// Token: 0x02002E4F RID: 11855
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __FSpawnActorDelegate_DelegateParams
		{
			// Token: 0x04016909 RID: 92425
			[FieldOffset(0)]
			public IntPtr SpawnedActor;
		}

		// Token: 0x02002E50 RID: 11856
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401690A RID: 92426
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
