using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000928 RID: 2344
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FCharacterMovementUpdatedSignature : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06008436 RID: 33846 RVA: 0x000BCF57 File Offset: 0x000BB157
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FCharacterMovementUpdatedSignature.StaticFunctionPtr();
		}

		// Token: 0x06008437 RID: 33847 RVA: 0x000BCF63 File Offset: 0x000BB163
		private static IntPtr StaticFunctionPtr()
		{
			if (FCharacterMovementUpdatedSignature._FunctionPtr == IntPtr.Zero)
			{
				FCharacterMovementUpdatedSignature._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.CharacterMovementUpdatedSignature__DelegateSignature");
			}
			return FCharacterMovementUpdatedSignature._FunctionPtr;
		}

		// Token: 0x06008438 RID: 33848 RVA: 0x000BCF86 File Offset: 0x000BB186
		public FCharacterMovementUpdatedSignature()
		{
		}

		// Token: 0x06008439 RID: 33849 RVA: 0x000BCF8E File Offset: 0x000BB18E
		[NullableContext(2)]
		public FCharacterMovementUpdatedSignature(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600843A RID: 33850 RVA: 0x000BCF98 File Offset: 0x000BB198
		public FCharacterMovementUpdatedSignature(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600843B RID: 33851 RVA: 0x000BCFA3 File Offset: 0x000BB1A3
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<float, FVector, FVector>) ?? ((Action<float, FVector, FVector>)Delegate.CreateDelegate(typeof(Action<float, FVector, FVector>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600843C RID: 33852 RVA: 0x000BCFD5 File Offset: 0x000BB1D5
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<float, FVector, FVector> Callback)
		{
			if (FCharacterMovementUpdatedSignature.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FCharacterMovementUpdatedSignature.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FCharacterMovementUpdatedSignature.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FCharacterMovementUpdatedSignature.OnScriptCallback));
				}
				FCharacterMovementUpdatedSignature.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FCharacterMovementUpdatedSignature.RegisterId);
		}

		// Token: 0x0600843D RID: 33853 RVA: 0x000BD00F File Offset: 0x000BB20F
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<float, FVector, FVector> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0600843E RID: 33854 RVA: 0x000BD018 File Offset: 0x000BB218
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(float DeltaSeconds, FVector OldLocation, FVector OldVelocity)
		{
			FCharacterMovementUpdatedSignature.__FCharacterMovementUpdatedSignature_DelegateParams* ptr = stackalloc FCharacterMovementUpdatedSignature.__FCharacterMovementUpdatedSignature_DelegateParams[(UIntPtr)43] + 15L / (long)sizeof(FCharacterMovementUpdatedSignature.__FCharacterMovementUpdatedSignature_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FCharacterMovementUpdatedSignature.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			ptr->OldLocation = OldLocation;
			ptr->OldVelocity = OldVelocity;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0600843F RID: 33855 RVA: 0x000BD064 File Offset: 0x000BB264
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<float, FVector, FVector> action = target as Action<float, FVector, FVector>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FCharacterMovementUpdatedSignature.__FCharacterMovementUpdatedSignature_DelegateParams*)__Parameters)->DeltaSeconds, ((FCharacterMovementUpdatedSignature.__FCharacterMovementUpdatedSignature_DelegateParams*)__Parameters)->OldLocation, ((FCharacterMovementUpdatedSignature.__FCharacterMovementUpdatedSignature_DelegateParams*)__Parameters)->OldVelocity);
		}

		// Token: 0x04003F28 RID: 16168
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003F29 RID: 16169
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.CharacterMovementUpdatedSignature__DelegateSignature";

		// Token: 0x04003F2A RID: 16170
		private static int RegisterId;

		// Token: 0x02002CBC RID: 11452
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 28)]
		protected ref struct __FCharacterMovementUpdatedSignature_DelegateParams
		{
			// Token: 0x0401664B RID: 91723
			[FieldOffset(0)]
			public float DeltaSeconds;

			// Token: 0x0401664C RID: 91724
			[FieldOffset(4)]
			public FVector OldLocation;

			// Token: 0x0401664D RID: 91725
			[FieldOffset(16)]
			public FVector OldVelocity;
		}

		// Token: 0x02002CBD RID: 11453
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401664E RID: 91726
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
