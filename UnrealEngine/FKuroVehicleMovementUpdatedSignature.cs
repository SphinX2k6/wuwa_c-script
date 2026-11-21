using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000631 RID: 1585
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FKuroVehicleMovementUpdatedSignature : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06008B1B RID: 35611 RVA: 0x000D13D1 File Offset: 0x000CF5D1
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FKuroVehicleMovementUpdatedSignature.StaticFunctionPtr();
		}

		// Token: 0x06008B1C RID: 35612 RVA: 0x000D13DD File Offset: 0x000CF5DD
		private static IntPtr StaticFunctionPtr()
		{
			if (FKuroVehicleMovementUpdatedSignature._FunctionPtr == IntPtr.Zero)
			{
				FKuroVehicleMovementUpdatedSignature._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroVehicle.KuroVehicleMovementUpdatedSignature__DelegateSignature");
			}
			return FKuroVehicleMovementUpdatedSignature._FunctionPtr;
		}

		// Token: 0x06008B1D RID: 35613 RVA: 0x000D1400 File Offset: 0x000CF600
		public FKuroVehicleMovementUpdatedSignature()
		{
		}

		// Token: 0x06008B1E RID: 35614 RVA: 0x000D1408 File Offset: 0x000CF608
		[NullableContext(2)]
		public FKuroVehicleMovementUpdatedSignature(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06008B1F RID: 35615 RVA: 0x000D1412 File Offset: 0x000CF612
		public FKuroVehicleMovementUpdatedSignature(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06008B20 RID: 35616 RVA: 0x000D141D File Offset: 0x000CF61D
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<float, FVector, FVector>) ?? ((Action<float, FVector, FVector>)Delegate.CreateDelegate(typeof(Action<float, FVector, FVector>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06008B21 RID: 35617 RVA: 0x000D144F File Offset: 0x000CF64F
		[NullableContext(1)]
		public void Add(Action<float, FVector, FVector> Callback)
		{
			if (FKuroVehicleMovementUpdatedSignature.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FKuroVehicleMovementUpdatedSignature.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FKuroVehicleMovementUpdatedSignature.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FKuroVehicleMovementUpdatedSignature.OnScriptCallback));
				}
				FKuroVehicleMovementUpdatedSignature.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FKuroVehicleMovementUpdatedSignature.RegisterId);
		}

		// Token: 0x06008B22 RID: 35618 RVA: 0x000D1489 File Offset: 0x000CF689
		[NullableContext(1)]
		public void Remove(Action<float, FVector, FVector> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06008B23 RID: 35619 RVA: 0x000D1494 File Offset: 0x000CF694
		[SkipLocalsInit]
		public unsafe void Broadcast(float DeltaSeconds, FVector OldLocation, FVector OldVelocity)
		{
			FKuroVehicleMovementUpdatedSignature.__FKuroVehicleMovementUpdatedSignature_DelegateParams* ptr = stackalloc FKuroVehicleMovementUpdatedSignature.__FKuroVehicleMovementUpdatedSignature_DelegateParams[(UIntPtr)43] + 15L / (long)sizeof(FKuroVehicleMovementUpdatedSignature.__FKuroVehicleMovementUpdatedSignature_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FKuroVehicleMovementUpdatedSignature.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			ptr->OldLocation = OldLocation;
			ptr->OldVelocity = OldVelocity;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x06008B24 RID: 35620 RVA: 0x000D14E0 File Offset: 0x000CF6E0
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<float, FVector, FVector> action = target as Action<float, FVector, FVector>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FKuroVehicleMovementUpdatedSignature.__FKuroVehicleMovementUpdatedSignature_DelegateParams*)__Parameters)->DeltaSeconds, ((FKuroVehicleMovementUpdatedSignature.__FKuroVehicleMovementUpdatedSignature_DelegateParams*)__Parameters)->OldLocation, ((FKuroVehicleMovementUpdatedSignature.__FKuroVehicleMovementUpdatedSignature_DelegateParams*)__Parameters)->OldVelocity);
		}

		// Token: 0x04003C5D RID: 15453
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003C5E RID: 15454
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroVehicle.KuroVehicleMovementUpdatedSignature__DelegateSignature";

		// Token: 0x04003C5F RID: 15455
		private static int RegisterId;

		// Token: 0x02000E54 RID: 3668
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 28)]
		private ref struct __FKuroVehicleMovementUpdatedSignature_DelegateParams
		{
			// Token: 0x040061F4 RID: 25076
			[FieldOffset(0)]
			public float DeltaSeconds;

			// Token: 0x040061F5 RID: 25077
			[FieldOffset(4)]
			public FVector OldLocation;

			// Token: 0x040061F6 RID: 25078
			[FieldOffset(16)]
			public FVector OldVelocity;
		}

		// Token: 0x02000E55 RID: 3669
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040061F7 RID: 25079
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
