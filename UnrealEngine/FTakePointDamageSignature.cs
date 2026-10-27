using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020011C2 RID: 4546
	[UnrealStructLayout(1, 1, UnrealReflectionPropertyTypeCode.MulticastSparseDelegate)]
	public sealed class FTakePointDamageSignature : FSparseDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06010C1C RID: 68636 RVA: 0x0018998B File Offset: 0x00187B8B
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FTakePointDamageSignature.StaticFunctionPtr();
		}

		// Token: 0x06010C1D RID: 68637 RVA: 0x00189997 File Offset: 0x00187B97
		private static IntPtr StaticFunctionPtr()
		{
			if (FTakePointDamageSignature._FunctionPtr == IntPtr.Zero)
			{
				FTakePointDamageSignature._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.TakePointDamageSignature__DelegateSignature");
			}
			return FTakePointDamageSignature._FunctionPtr;
		}

		// Token: 0x1700416F RID: 16751
		// (get) Token: 0x06010C1E RID: 68638 RVA: 0x001899BA File Offset: 0x00187BBA
		public override FName DelegateName
		{
			get
			{
				return FNameStatic.OnTakePointDamage;
			}
		}

		// Token: 0x06010C1F RID: 68639 RVA: 0x001899C1 File Offset: 0x00187BC1
		[NullableContext(2)]
		public FTakePointDamageSignature(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06010C20 RID: 68640 RVA: 0x001899CB File Offset: 0x00187BCB
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<AActor, float, AController, FVector, UPrimitiveComponent, FName, FVector, UDamageType, AActor>) ?? ((Action<AActor, float, AController, FVector, UPrimitiveComponent, FName, FVector, UDamageType, AActor>)Delegate.CreateDelegate(typeof(Action<AActor, float, AController, FVector, UPrimitiveComponent, FName, FVector, UDamageType, AActor>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06010C21 RID: 68641 RVA: 0x00189A00 File Offset: 0x00187C00
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2,
			2,
			2,
			2,
			2
		})] Action<AActor, float, AController, FVector, UPrimitiveComponent, FName, FVector, UDamageType, AActor> Callback)
		{
			if (FTakePointDamageSignature.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FTakePointDamageSignature.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FTakePointDamageSignature.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FTakePointDamageSignature.OnScriptCallback));
				}
				FTakePointDamageSignature.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			FName delegateName = this.DelegateName;
			base.Add(delegateName, Callback, FTakePointDamageSignature.RegisterId);
		}

		// Token: 0x06010C22 RID: 68642 RVA: 0x00189A50 File Offset: 0x00187C50
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2,
			2,
			2,
			2,
			2
		})] Action<AActor, float, AController, FVector, UPrimitiveComponent, FName, FVector, UDamageType, AActor> Callback)
		{
			FName delegateName = this.DelegateName;
			base.Remove(delegateName, Callback);
		}

		// Token: 0x06010C23 RID: 68643 RVA: 0x00189A70 File Offset: 0x00187C70
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(AActor DamagedActor, float Damage, AController InstigatedBy, FVector HitLocation, UPrimitiveComponent FHitComponent, FName BoneName, FVector ShotFromDirection, UDamageType DamageType, AActor DamageCauser)
		{
			FTakePointDamageSignature.__FTakePointDamageSignature_DelegateParams* ptr = stackalloc FTakePointDamageSignature.__FTakePointDamageSignature_DelegateParams[(UIntPtr)103] + 15L / (long)sizeof(FTakePointDamageSignature.__FTakePointDamageSignature_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FTakePointDamageSignature.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->DamagedActor = ((DamagedActor != null) ? DamagedActor.NativePtr : IntPtr.Zero);
			ptr->Damage = Damage;
			ptr->InstigatedBy = ((InstigatedBy != null) ? InstigatedBy.NativePtr : IntPtr.Zero);
			ptr->HitLocation = HitLocation;
			ptr->FHitComponent = ((FHitComponent != null) ? FHitComponent.NativePtr : IntPtr.Zero);
			ptr->BoneName = BoneName;
			ptr->ShotFromDirection = ShotFromDirection;
			ptr->DamageType = ((DamageType != null) ? DamageType.NativePtr : IntPtr.Zero);
			ptr->DamageCauser = ((DamageCauser != null) ? DamageCauser.NativePtr : IntPtr.Zero);
			FSparseDelegate.BroadcastInternal(base.GetOwner().NativePtr, this.DelegateName, (void*)ptr);
		}

		// Token: 0x06010C24 RID: 68644 RVA: 0x00189B48 File Offset: 0x00187D48
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<AActor, float, AController, FVector, UPrimitiveComponent, FName, FVector, UDamageType, AActor> action = target as Action<AActor, float, AController, FVector, UPrimitiveComponent, FName, FVector, UDamageType, AActor>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			AActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(((FTakePointDamageSignature.__FTakePointDamageSignature_DelegateParams*)__Parameters)->DamagedActor);
			AController orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<AController>(((FTakePointDamageSignature.__FTakePointDamageSignature_DelegateParams*)__Parameters)->InstigatedBy);
			UPrimitiveComponent orCreateUObjectByNativePointer3 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UPrimitiveComponent>(((FTakePointDamageSignature.__FTakePointDamageSignature_DelegateParams*)__Parameters)->FHitComponent);
			UDamageType orCreateUObjectByNativePointer4 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UDamageType>(((FTakePointDamageSignature.__FTakePointDamageSignature_DelegateParams*)__Parameters)->DamageType);
			AActor orCreateUObjectByNativePointer5 = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(((FTakePointDamageSignature.__FTakePointDamageSignature_DelegateParams*)__Parameters)->DamageCauser);
			action(orCreateUObjectByNativePointer, ((FTakePointDamageSignature.__FTakePointDamageSignature_DelegateParams*)__Parameters)->Damage, orCreateUObjectByNativePointer2, ((FTakePointDamageSignature.__FTakePointDamageSignature_DelegateParams*)__Parameters)->HitLocation, orCreateUObjectByNativePointer3, ((FTakePointDamageSignature.__FTakePointDamageSignature_DelegateParams*)__Parameters)->BoneName, ((FTakePointDamageSignature.__FTakePointDamageSignature_DelegateParams*)__Parameters)->ShotFromDirection, orCreateUObjectByNativePointer4, orCreateUObjectByNativePointer5);
		}

		// Token: 0x04008F4A RID: 36682
		internal static IntPtr _FunctionPtr;

		// Token: 0x04008F4B RID: 36683
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.TakePointDamageSignature__DelegateSignature";

		// Token: 0x04008F4C RID: 36684
		private static int RegisterId;

		// Token: 0x02002DF5 RID: 11765
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 88)]
		protected ref struct __FTakePointDamageSignature_DelegateParams
		{
			// Token: 0x04016848 RID: 92232
			[FieldOffset(0)]
			public IntPtr DamagedActor;

			// Token: 0x04016849 RID: 92233
			[FieldOffset(8)]
			public float Damage;

			// Token: 0x0401684A RID: 92234
			[FieldOffset(16)]
			public IntPtr InstigatedBy;

			// Token: 0x0401684B RID: 92235
			[FieldOffset(24)]
			public FVector HitLocation;

			// Token: 0x0401684C RID: 92236
			[FieldOffset(40)]
			public IntPtr FHitComponent;

			// Token: 0x0401684D RID: 92237
			[FieldOffset(48)]
			public FName BoneName;

			// Token: 0x0401684E RID: 92238
			[FieldOffset(60)]
			public FVector ShotFromDirection;

			// Token: 0x0401684F RID: 92239
			[FieldOffset(72)]
			public IntPtr DamageType;

			// Token: 0x04016850 RID: 92240
			[FieldOffset(80)]
			public IntPtr DamageCauser;
		}

		// Token: 0x02002DF6 RID: 11766
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016851 RID: 92241
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
