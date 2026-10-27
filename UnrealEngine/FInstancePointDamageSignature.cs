using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020012CF RID: 4815
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FInstancePointDamageSignature : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06011A9B RID: 72347 RVA: 0x0019ECDB File Offset: 0x0019CEDB
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FInstancePointDamageSignature.StaticFunctionPtr();
		}

		// Token: 0x06011A9C RID: 72348 RVA: 0x0019ECE7 File Offset: 0x0019CEE7
		private static IntPtr StaticFunctionPtr()
		{
			if (FInstancePointDamageSignature._FunctionPtr == IntPtr.Zero)
			{
				FInstancePointDamageSignature._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Foliage.InstancePointDamageSignature__DelegateSignature");
			}
			return FInstancePointDamageSignature._FunctionPtr;
		}

		// Token: 0x06011A9D RID: 72349 RVA: 0x0019ED0A File Offset: 0x0019CF0A
		public FInstancePointDamageSignature()
		{
		}

		// Token: 0x06011A9E RID: 72350 RVA: 0x0019ED12 File Offset: 0x0019CF12
		[NullableContext(2)]
		public FInstancePointDamageSignature(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06011A9F RID: 72351 RVA: 0x0019ED1C File Offset: 0x0019CF1C
		public FInstancePointDamageSignature(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06011AA0 RID: 72352 RVA: 0x0019ED27 File Offset: 0x0019CF27
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<int, float, AController, FVector, FVector, UDamageType, AActor>) ?? ((Action<int, float, AController, FVector, FVector, UDamageType, AActor>)Delegate.CreateDelegate(typeof(Action<int, float, AController, FVector, FVector, UDamageType, AActor>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06011AA1 RID: 72353 RVA: 0x0019ED59 File Offset: 0x0019CF59
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2,
			2,
			2
		})] Action<int, float, AController, FVector, FVector, UDamageType, AActor> Callback)
		{
			if (FInstancePointDamageSignature.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FInstancePointDamageSignature.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FInstancePointDamageSignature.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FInstancePointDamageSignature.OnScriptCallback));
				}
				FInstancePointDamageSignature.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FInstancePointDamageSignature.RegisterId);
		}

		// Token: 0x06011AA2 RID: 72354 RVA: 0x0019ED93 File Offset: 0x0019CF93
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2,
			2,
			2
		})] Action<int, float, AController, FVector, FVector, UDamageType, AActor> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06011AA3 RID: 72355 RVA: 0x0019ED9C File Offset: 0x0019CF9C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(int InstanceIndex, float Damage, AController InstigatedBy, FVector HitLocation, FVector ShotFromDirection, UDamageType DamageType, AActor DamageCauser)
		{
			FInstancePointDamageSignature.__FInstancePointDamageSignature_DelegateParams* ptr = stackalloc FInstancePointDamageSignature.__FInstancePointDamageSignature_DelegateParams[(UIntPtr)71] + 15L / (long)sizeof(FInstancePointDamageSignature.__FInstancePointDamageSignature_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FInstancePointDamageSignature.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->InstanceIndex = InstanceIndex;
			ptr->Damage = Damage;
			ptr->InstigatedBy = ((InstigatedBy != null) ? InstigatedBy.NativePtr : IntPtr.Zero);
			ptr->HitLocation = HitLocation;
			ptr->ShotFromDirection = ShotFromDirection;
			ptr->DamageType = ((DamageType != null) ? DamageType.NativePtr : IntPtr.Zero);
			ptr->DamageCauser = ((DamageCauser != null) ? DamageCauser.NativePtr : IntPtr.Zero);
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x06011AA4 RID: 72356 RVA: 0x0019EE38 File Offset: 0x0019D038
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int, float, AController, FVector, FVector, UDamageType, AActor> action = target as Action<int, float, AController, FVector, FVector, UDamageType, AActor>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			AController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AController>(((FInstancePointDamageSignature.__FInstancePointDamageSignature_DelegateParams*)__Parameters)->InstigatedBy);
			UDamageType orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UDamageType>(((FInstancePointDamageSignature.__FInstancePointDamageSignature_DelegateParams*)__Parameters)->DamageType);
			AActor orCreateUObjectByNativePointer3 = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(((FInstancePointDamageSignature.__FInstancePointDamageSignature_DelegateParams*)__Parameters)->DamageCauser);
			action(((FInstancePointDamageSignature.__FInstancePointDamageSignature_DelegateParams*)__Parameters)->InstanceIndex, ((FInstancePointDamageSignature.__FInstancePointDamageSignature_DelegateParams*)__Parameters)->Damage, orCreateUObjectByNativePointer, ((FInstancePointDamageSignature.__FInstancePointDamageSignature_DelegateParams*)__Parameters)->HitLocation, ((FInstancePointDamageSignature.__FInstancePointDamageSignature_DelegateParams*)__Parameters)->ShotFromDirection, orCreateUObjectByNativePointer2, orCreateUObjectByNativePointer3);
		}

		// Token: 0x0400979E RID: 38814
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400979F RID: 38815
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Foliage.InstancePointDamageSignature__DelegateSignature";

		// Token: 0x040097A0 RID: 38816
		private static int RegisterId;

		// Token: 0x02002E1A RID: 11802
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 56)]
		protected ref struct __FInstancePointDamageSignature_DelegateParams
		{
			// Token: 0x0401689F RID: 92319
			[FieldOffset(0)]
			public int InstanceIndex;

			// Token: 0x040168A0 RID: 92320
			[FieldOffset(4)]
			public float Damage;

			// Token: 0x040168A1 RID: 92321
			[FieldOffset(8)]
			public IntPtr InstigatedBy;

			// Token: 0x040168A2 RID: 92322
			[FieldOffset(16)]
			public FVector HitLocation;

			// Token: 0x040168A3 RID: 92323
			[FieldOffset(28)]
			public FVector ShotFromDirection;

			// Token: 0x040168A4 RID: 92324
			[FieldOffset(40)]
			public IntPtr DamageType;

			// Token: 0x040168A5 RID: 92325
			[FieldOffset(48)]
			public IntPtr DamageCauser;
		}

		// Token: 0x02002E1B RID: 11803
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040168A6 RID: 92326
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
