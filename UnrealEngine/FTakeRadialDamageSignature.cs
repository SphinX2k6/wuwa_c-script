using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020011C3 RID: 4547
	[UnrealStructLayout(1, 1, UnrealReflectionPropertyTypeCode.MulticastSparseDelegate)]
	public sealed class FTakeRadialDamageSignature : FSparseDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06010C25 RID: 68645 RVA: 0x00189BEC File Offset: 0x00187DEC
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FTakeRadialDamageSignature.StaticFunctionPtr();
		}

		// Token: 0x06010C26 RID: 68646 RVA: 0x00189BF8 File Offset: 0x00187DF8
		private static IntPtr StaticFunctionPtr()
		{
			if (FTakeRadialDamageSignature._FunctionPtr == IntPtr.Zero)
			{
				FTakeRadialDamageSignature._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.TakeRadialDamageSignature__DelegateSignature");
			}
			return FTakeRadialDamageSignature._FunctionPtr;
		}

		// Token: 0x17004170 RID: 16752
		// (get) Token: 0x06010C27 RID: 68647 RVA: 0x00189C1B File Offset: 0x00187E1B
		public override FName DelegateName
		{
			get
			{
				return FNameStatic.OnTakeRadialDamage;
			}
		}

		// Token: 0x06010C28 RID: 68648 RVA: 0x00189C22 File Offset: 0x00187E22
		[NullableContext(2)]
		public FTakeRadialDamageSignature(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06010C29 RID: 68649 RVA: 0x00189C2C File Offset: 0x00187E2C
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<AActor, float, UDamageType, FVector, FHitResult, AController, AActor>) ?? ((Action<AActor, float, UDamageType, FVector, FHitResult, AController, AActor>)Delegate.CreateDelegate(typeof(Action<AActor, float, UDamageType, FVector, FHitResult, AController, AActor>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06010C2A RID: 68650 RVA: 0x00189C60 File Offset: 0x00187E60
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2,
			2,
			1,
			2,
			2
		})] Action<AActor, float, UDamageType, FVector, FHitResult, AController, AActor> Callback)
		{
			if (FTakeRadialDamageSignature.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FTakeRadialDamageSignature.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FTakeRadialDamageSignature.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FTakeRadialDamageSignature.OnScriptCallback));
				}
				FTakeRadialDamageSignature.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			FName delegateName = this.DelegateName;
			base.Add(delegateName, Callback, FTakeRadialDamageSignature.RegisterId);
		}

		// Token: 0x06010C2B RID: 68651 RVA: 0x00189CB0 File Offset: 0x00187EB0
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2,
			2,
			1,
			2,
			2
		})] Action<AActor, float, UDamageType, FVector, FHitResult, AController, AActor> Callback)
		{
			FName delegateName = this.DelegateName;
			base.Remove(delegateName, Callback);
		}

		// Token: 0x06010C2C RID: 68652 RVA: 0x00189CD0 File Offset: 0x00187ED0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(AActor DamagedActor, float Damage, UDamageType DamageType, FVector Origin, FHitResult HitInfo, AController InstigatedBy, AActor DamageCauser)
		{
			FTakeRadialDamageSignature.__FTakeRadialDamageSignature_DelegateParams* ptr = stackalloc FTakeRadialDamageSignature.__FTakeRadialDamageSignature_DelegateParams[(UIntPtr)215] + 15L / (long)sizeof(FTakeRadialDamageSignature.__FTakeRadialDamageSignature_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FTakeRadialDamageSignature.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->DamagedActor = ((DamagedActor != null) ? DamagedActor.NativePtr : IntPtr.Zero);
			ptr->Damage = Damage;
			ptr->DamageType = ((DamageType != null) ? DamageType.NativePtr : IntPtr.Zero);
			ptr->Origin = Origin;
			if (HitInfo != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FHitResult.StaticStruct(), &ptr->HitInfo, HitInfo.NativePtr, 1, false);
			}
			ptr->InstigatedBy = ((InstigatedBy != null) ? InstigatedBy.NativePtr : IntPtr.Zero);
			ptr->DamageCauser = ((DamageCauser != null) ? DamageCauser.NativePtr : IntPtr.Zero);
			FSparseDelegate.BroadcastInternal(base.GetOwner().NativePtr, this.DelegateName, (void*)ptr);
		}

		// Token: 0x06010C2D RID: 68653 RVA: 0x00189DA8 File Offset: 0x00187FA8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<AActor, float, UDamageType, FVector, FHitResult, AController, AActor> action = target as Action<AActor, float, UDamageType, FVector, FHitResult, AController, AActor>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			AActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(((FTakeRadialDamageSignature.__FTakeRadialDamageSignature_DelegateParams*)__Parameters)->DamagedActor);
			UDamageType orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UDamageType>(((FTakeRadialDamageSignature.__FTakeRadialDamageSignature_DelegateParams*)__Parameters)->DamageType);
			FHitResult arg = new FHitResult(&((FTakeRadialDamageSignature.__FTakeRadialDamageSignature_DelegateParams*)__Parameters)->HitInfo, true, true);
			AController orCreateUObjectByNativePointer3 = BuiltinUtils.GetOrCreateUObjectByNativePointer<AController>(((FTakeRadialDamageSignature.__FTakeRadialDamageSignature_DelegateParams*)__Parameters)->InstigatedBy);
			AActor orCreateUObjectByNativePointer4 = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(((FTakeRadialDamageSignature.__FTakeRadialDamageSignature_DelegateParams*)__Parameters)->DamageCauser);
			action(orCreateUObjectByNativePointer, ((FTakeRadialDamageSignature.__FTakeRadialDamageSignature_DelegateParams*)__Parameters)->Damage, orCreateUObjectByNativePointer2, ((FTakeRadialDamageSignature.__FTakeRadialDamageSignature_DelegateParams*)__Parameters)->Origin, arg, orCreateUObjectByNativePointer3, orCreateUObjectByNativePointer4);
		}

		// Token: 0x04008F4D RID: 36685
		internal static IntPtr _FunctionPtr;

		// Token: 0x04008F4E RID: 36686
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.TakeRadialDamageSignature__DelegateSignature";

		// Token: 0x04008F4F RID: 36687
		private static int RegisterId;

		// Token: 0x02002DF7 RID: 11767
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 200)]
		protected ref struct __FTakeRadialDamageSignature_DelegateParams
		{
			// Token: 0x04016852 RID: 92242
			[FieldOffset(0)]
			public IntPtr DamagedActor;

			// Token: 0x04016853 RID: 92243
			[FieldOffset(8)]
			public float Damage;

			// Token: 0x04016854 RID: 92244
			[FieldOffset(16)]
			public IntPtr DamageType;

			// Token: 0x04016855 RID: 92245
			[FieldOffset(24)]
			public FVector Origin;

			// Token: 0x04016856 RID: 92246
			[FieldOffset(36)]
			public byte HitInfo;

			// Token: 0x04016857 RID: 92247
			[FieldOffset(184)]
			public IntPtr InstigatedBy;

			// Token: 0x04016858 RID: 92248
			[FieldOffset(192)]
			public IntPtr DamageCauser;
		}

		// Token: 0x02002DF8 RID: 11768
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016859 RID: 92249
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
