using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000953 RID: 2387
	[UnrealStructLayout(1, 1, UnrealReflectionPropertyTypeCode.MulticastSparseDelegate)]
	public sealed class FComponentConveyBaseMovementSignature : FSparseDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600871F RID: 34591 RVA: 0x000C0FB7 File Offset: 0x000BF1B7
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FComponentConveyBaseMovementSignature.StaticFunctionPtr();
		}

		// Token: 0x06008720 RID: 34592 RVA: 0x000C0FC3 File Offset: 0x000BF1C3
		private static IntPtr StaticFunctionPtr()
		{
			if (FComponentConveyBaseMovementSignature._FunctionPtr == IntPtr.Zero)
			{
				FComponentConveyBaseMovementSignature._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.ComponentConveyBaseMovementSignature__DelegateSignature");
			}
			return FComponentConveyBaseMovementSignature._FunctionPtr;
		}

		// Token: 0x17001FF7 RID: 8183
		// (get) Token: 0x06008721 RID: 34593 RVA: 0x000C0FE6 File Offset: 0x000BF1E6
		public override FName DelegateName
		{
			get
			{
				return FNameStatic.OnConveyBase;
			}
		}

		// Token: 0x06008722 RID: 34594 RVA: 0x000C0FED File Offset: 0x000BF1ED
		[NullableContext(2)]
		public FComponentConveyBaseMovementSignature(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06008723 RID: 34595 RVA: 0x000C0FF7 File Offset: 0x000BF1F7
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<float, FVector, UCharacterMovementComponent>) ?? ((Action<float, FVector, UCharacterMovementComponent>)Delegate.CreateDelegate(typeof(Action<float, FVector, UCharacterMovementComponent>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06008724 RID: 34596 RVA: 0x000C102C File Offset: 0x000BF22C
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<float, FVector, UCharacterMovementComponent> Callback)
		{
			if (FComponentConveyBaseMovementSignature.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FComponentConveyBaseMovementSignature.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FComponentConveyBaseMovementSignature.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FComponentConveyBaseMovementSignature.OnScriptCallback));
				}
				FComponentConveyBaseMovementSignature.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			FName delegateName = this.DelegateName;
			base.Add(delegateName, Callback, FComponentConveyBaseMovementSignature.RegisterId);
		}

		// Token: 0x06008725 RID: 34597 RVA: 0x000C107C File Offset: 0x000BF27C
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<float, FVector, UCharacterMovementComponent> Callback)
		{
			FName delegateName = this.DelegateName;
			base.Remove(delegateName, Callback);
		}

		// Token: 0x06008726 RID: 34598 RVA: 0x000C109C File Offset: 0x000BF29C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(float DeltaSeconds, FVector FloorLocation, UCharacterMovementComponent CharacterMovement)
		{
			FComponentConveyBaseMovementSignature.__FComponentConveyBaseMovementSignature_DelegateParams* ptr = stackalloc FComponentConveyBaseMovementSignature.__FComponentConveyBaseMovementSignature_DelegateParams[(UIntPtr)39] + 15L / (long)sizeof(FComponentConveyBaseMovementSignature.__FComponentConveyBaseMovementSignature_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FComponentConveyBaseMovementSignature.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			ptr->FloorLocation = FloorLocation;
			ptr->CharacterMovement = ((CharacterMovement != null) ? CharacterMovement.NativePtr : IntPtr.Zero);
			FSparseDelegate.BroadcastInternal(base.GetOwner().NativePtr, this.DelegateName, (void*)ptr);
		}

		// Token: 0x06008727 RID: 34599 RVA: 0x000C1108 File Offset: 0x000BF308
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<float, FVector, UCharacterMovementComponent> action = target as Action<float, FVector, UCharacterMovementComponent>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			UCharacterMovementComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UCharacterMovementComponent>(((FComponentConveyBaseMovementSignature.__FComponentConveyBaseMovementSignature_DelegateParams*)__Parameters)->CharacterMovement);
			action(((FComponentConveyBaseMovementSignature.__FComponentConveyBaseMovementSignature_DelegateParams*)__Parameters)->DeltaSeconds, ((FComponentConveyBaseMovementSignature.__FComponentConveyBaseMovementSignature_DelegateParams*)__Parameters)->FloorLocation, orCreateUObjectByNativePointer);
		}

		// Token: 0x0400404C RID: 16460
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400404D RID: 16461
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.ComponentConveyBaseMovementSignature__DelegateSignature";

		// Token: 0x0400404E RID: 16462
		private static int RegisterId;

		// Token: 0x02002CC9 RID: 11465
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __FComponentConveyBaseMovementSignature_DelegateParams
		{
			// Token: 0x04016667 RID: 91751
			[FieldOffset(0)]
			public float DeltaSeconds;

			// Token: 0x04016668 RID: 91752
			[FieldOffset(4)]
			public FVector FloorLocation;

			// Token: 0x04016669 RID: 91753
			[FieldOffset(16)]
			public IntPtr CharacterMovement;
		}

		// Token: 0x02002CCA RID: 11466
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401666A RID: 91754
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
