using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001974 RID: 6516
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnRotateStepSignature : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601835E RID: 99166 RVA: 0x0023B319 File Offset: 0x00239519
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnRotateStepSignature.StaticFunctionPtr();
		}

		// Token: 0x0601835F RID: 99167 RVA: 0x0023B325 File Offset: 0x00239525
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnRotateStepSignature._FunctionPtr == IntPtr.Zero)
			{
				FOnRotateStepSignature._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroGAS.OnRotateStepSignature__DelegateSignature");
			}
			return FOnRotateStepSignature._FunctionPtr;
		}

		// Token: 0x06018360 RID: 99168 RVA: 0x0023B348 File Offset: 0x00239548
		public FOnRotateStepSignature()
		{
		}

		// Token: 0x06018361 RID: 99169 RVA: 0x0023B350 File Offset: 0x00239550
		[NullableContext(2)]
		public FOnRotateStepSignature(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06018362 RID: 99170 RVA: 0x0023B35A File Offset: 0x0023955A
		public FOnRotateStepSignature(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06018363 RID: 99171 RVA: 0x0023B365 File Offset: 0x00239565
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<USceneComponent, FVector>) ?? ((Action<USceneComponent, FVector>)Delegate.CreateDelegate(typeof(Action<USceneComponent, FVector>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06018364 RID: 99172 RVA: 0x0023B397 File Offset: 0x00239597
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<USceneComponent, FVector> Callback)
		{
			if (FOnRotateStepSignature.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnRotateStepSignature.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnRotateStepSignature.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnRotateStepSignature.OnScriptCallback));
				}
				FOnRotateStepSignature.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnRotateStepSignature.RegisterId);
		}

		// Token: 0x06018365 RID: 99173 RVA: 0x0023B3D1 File Offset: 0x002395D1
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<USceneComponent, FVector> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06018366 RID: 99174 RVA: 0x0023B3DC File Offset: 0x002395DC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(USceneComponent AimPivot, FVector TargetLocation)
		{
			FOnRotateStepSignature.__FOnRotateStepSignature_DelegateParams* ptr = stackalloc FOnRotateStepSignature.__FOnRotateStepSignature_DelegateParams[(UIntPtr)39] + 15L / (long)sizeof(FOnRotateStepSignature.__FOnRotateStepSignature_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnRotateStepSignature.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->AimPivot = ((AimPivot != null) ? AimPivot.NativePtr : IntPtr.Zero);
			ptr->TargetLocation = TargetLocation;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x06018367 RID: 99175 RVA: 0x0023B430 File Offset: 0x00239630
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<USceneComponent, FVector> action = target as Action<USceneComponent, FVector>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			USceneComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USceneComponent>(((FOnRotateStepSignature.__FOnRotateStepSignature_DelegateParams*)__Parameters)->AimPivot);
			action(orCreateUObjectByNativePointer, ((FOnRotateStepSignature.__FOnRotateStepSignature_DelegateParams*)__Parameters)->TargetLocation);
		}

		// Token: 0x0400D1D2 RID: 53714
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400D1D3 RID: 53715
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGAS.OnRotateStepSignature__DelegateSignature";

		// Token: 0x0400D1D4 RID: 53716
		private static int RegisterId;

		// Token: 0x0200306A RID: 12394
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __FOnRotateStepSignature_DelegateParams
		{
			// Token: 0x04016D38 RID: 93496
			[FieldOffset(0)]
			public IntPtr AimPivot;

			// Token: 0x04016D39 RID: 93497
			[FieldOffset(8)]
			public FVector TargetLocation;
		}

		// Token: 0x0200306B RID: 12395
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016D3A RID: 93498
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
