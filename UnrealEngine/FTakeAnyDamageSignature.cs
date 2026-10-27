using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020011C1 RID: 4545
	[UnrealStructLayout(1, 1, UnrealReflectionPropertyTypeCode.MulticastSparseDelegate)]
	public sealed class FTakeAnyDamageSignature : FSparseDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06010C13 RID: 68627 RVA: 0x0018977D File Offset: 0x0018797D
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FTakeAnyDamageSignature.StaticFunctionPtr();
		}

		// Token: 0x06010C14 RID: 68628 RVA: 0x00189789 File Offset: 0x00187989
		private static IntPtr StaticFunctionPtr()
		{
			if (FTakeAnyDamageSignature._FunctionPtr == IntPtr.Zero)
			{
				FTakeAnyDamageSignature._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.TakeAnyDamageSignature__DelegateSignature");
			}
			return FTakeAnyDamageSignature._FunctionPtr;
		}

		// Token: 0x1700416E RID: 16750
		// (get) Token: 0x06010C15 RID: 68629 RVA: 0x001897AC File Offset: 0x001879AC
		public override FName DelegateName
		{
			get
			{
				return FNameStatic.OnTakeAnyDamage;
			}
		}

		// Token: 0x06010C16 RID: 68630 RVA: 0x001897B3 File Offset: 0x001879B3
		[NullableContext(2)]
		public FTakeAnyDamageSignature(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06010C17 RID: 68631 RVA: 0x001897BD File Offset: 0x001879BD
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<AActor, float, UDamageType, AController, AActor>) ?? ((Action<AActor, float, UDamageType, AController, AActor>)Delegate.CreateDelegate(typeof(Action<AActor, float, UDamageType, AController, AActor>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06010C18 RID: 68632 RVA: 0x001897F0 File Offset: 0x001879F0
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2,
			2,
			2,
			2
		})] Action<AActor, float, UDamageType, AController, AActor> Callback)
		{
			if (FTakeAnyDamageSignature.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FTakeAnyDamageSignature.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FTakeAnyDamageSignature.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FTakeAnyDamageSignature.OnScriptCallback));
				}
				FTakeAnyDamageSignature.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			FName delegateName = this.DelegateName;
			base.Add(delegateName, Callback, FTakeAnyDamageSignature.RegisterId);
		}

		// Token: 0x06010C19 RID: 68633 RVA: 0x00189840 File Offset: 0x00187A40
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2,
			2,
			2,
			2
		})] Action<AActor, float, UDamageType, AController, AActor> Callback)
		{
			FName delegateName = this.DelegateName;
			base.Remove(delegateName, Callback);
		}

		// Token: 0x06010C1A RID: 68634 RVA: 0x00189860 File Offset: 0x00187A60
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(AActor DamagedActor, float Damage, UDamageType DamageType, AController InstigatedBy, AActor DamageCauser)
		{
			FTakeAnyDamageSignature.__FTakeAnyDamageSignature_DelegateParams* ptr = stackalloc FTakeAnyDamageSignature.__FTakeAnyDamageSignature_DelegateParams[(UIntPtr)55] + 15L / (long)sizeof(FTakeAnyDamageSignature.__FTakeAnyDamageSignature_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FTakeAnyDamageSignature.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->DamagedActor = ((DamagedActor != null) ? DamagedActor.NativePtr : IntPtr.Zero);
			ptr->Damage = Damage;
			ptr->DamageType = ((DamageType != null) ? DamageType.NativePtr : IntPtr.Zero);
			ptr->InstigatedBy = ((InstigatedBy != null) ? InstigatedBy.NativePtr : IntPtr.Zero);
			ptr->DamageCauser = ((DamageCauser != null) ? DamageCauser.NativePtr : IntPtr.Zero);
			FSparseDelegate.BroadcastInternal(base.GetOwner().NativePtr, this.DelegateName, (void*)ptr);
		}

		// Token: 0x06010C1B RID: 68635 RVA: 0x00189908 File Offset: 0x00187B08
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<AActor, float, UDamageType, AController, AActor> action = target as Action<AActor, float, UDamageType, AController, AActor>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			AActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(((FTakeAnyDamageSignature.__FTakeAnyDamageSignature_DelegateParams*)__Parameters)->DamagedActor);
			UDamageType orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UDamageType>(((FTakeAnyDamageSignature.__FTakeAnyDamageSignature_DelegateParams*)__Parameters)->DamageType);
			AController orCreateUObjectByNativePointer3 = BuiltinUtils.GetOrCreateUObjectByNativePointer<AController>(((FTakeAnyDamageSignature.__FTakeAnyDamageSignature_DelegateParams*)__Parameters)->InstigatedBy);
			AActor orCreateUObjectByNativePointer4 = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(((FTakeAnyDamageSignature.__FTakeAnyDamageSignature_DelegateParams*)__Parameters)->DamageCauser);
			action(orCreateUObjectByNativePointer, ((FTakeAnyDamageSignature.__FTakeAnyDamageSignature_DelegateParams*)__Parameters)->Damage, orCreateUObjectByNativePointer2, orCreateUObjectByNativePointer3, orCreateUObjectByNativePointer4);
		}

		// Token: 0x04008F47 RID: 36679
		internal static IntPtr _FunctionPtr;

		// Token: 0x04008F48 RID: 36680
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.TakeAnyDamageSignature__DelegateSignature";

		// Token: 0x04008F49 RID: 36681
		private static int RegisterId;

		// Token: 0x02002DF3 RID: 11763
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __FTakeAnyDamageSignature_DelegateParams
		{
			// Token: 0x04016842 RID: 92226
			[FieldOffset(0)]
			public IntPtr DamagedActor;

			// Token: 0x04016843 RID: 92227
			[FieldOffset(8)]
			public float Damage;

			// Token: 0x04016844 RID: 92228
			[FieldOffset(16)]
			public IntPtr DamageType;

			// Token: 0x04016845 RID: 92229
			[FieldOffset(24)]
			public IntPtr InstigatedBy;

			// Token: 0x04016846 RID: 92230
			[FieldOffset(32)]
			public IntPtr DamageCauser;
		}

		// Token: 0x02002DF4 RID: 11764
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016847 RID: 92231
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
