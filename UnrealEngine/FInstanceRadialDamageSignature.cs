using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020012D0 RID: 4816
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FInstanceRadialDamageSignature : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06011AA5 RID: 72357 RVA: 0x0019EEBE File Offset: 0x0019D0BE
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FInstanceRadialDamageSignature.StaticFunctionPtr();
		}

		// Token: 0x06011AA6 RID: 72358 RVA: 0x0019EECA File Offset: 0x0019D0CA
		private static IntPtr StaticFunctionPtr()
		{
			if (FInstanceRadialDamageSignature._FunctionPtr == IntPtr.Zero)
			{
				FInstanceRadialDamageSignature._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Foliage.InstanceRadialDamageSignature__DelegateSignature");
			}
			return FInstanceRadialDamageSignature._FunctionPtr;
		}

		// Token: 0x06011AA7 RID: 72359 RVA: 0x0019EEED File Offset: 0x0019D0ED
		public FInstanceRadialDamageSignature()
		{
		}

		// Token: 0x06011AA8 RID: 72360 RVA: 0x0019EEF5 File Offset: 0x0019D0F5
		[NullableContext(2)]
		public FInstanceRadialDamageSignature(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06011AA9 RID: 72361 RVA: 0x0019EEFF File Offset: 0x0019D0FF
		public FInstanceRadialDamageSignature(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06011AAA RID: 72362 RVA: 0x0019EF0A File Offset: 0x0019D10A
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as FInstanceRadialDamageSignature.FInstanceRadialDamageSignature_ScriptDelegate) ?? ((FInstanceRadialDamageSignature.FInstanceRadialDamageSignature_ScriptDelegate)Delegate.CreateDelegate(typeof(FInstanceRadialDamageSignature.FInstanceRadialDamageSignature_ScriptDelegate), Callback.Target, Callback.Method)));
		}

		// Token: 0x06011AAB RID: 72363 RVA: 0x0019EF3C File Offset: 0x0019D13C
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(FInstanceRadialDamageSignature.FInstanceRadialDamageSignature_ScriptDelegate Callback)
		{
			if (FInstanceRadialDamageSignature.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FInstanceRadialDamageSignature.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FInstanceRadialDamageSignature.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FInstanceRadialDamageSignature.OnScriptCallback));
				}
				FInstanceRadialDamageSignature.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FInstanceRadialDamageSignature.RegisterId);
		}

		// Token: 0x06011AAC RID: 72364 RVA: 0x0019EF76 File Offset: 0x0019D176
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(FInstanceRadialDamageSignature.FInstanceRadialDamageSignature_ScriptDelegate Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06011AAD RID: 72365 RVA: 0x0019EF80 File Offset: 0x0019D180
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(in TArray<int> Instances, in TArray<float> Damages, AController InstigatedBy, FVector Origin, float MaxRadius, UDamageType DamageType, AActor DamageCauser)
		{
			FInstanceRadialDamageSignature.__FInstanceRadialDamageSignature_DelegateParams* ptr = stackalloc FInstanceRadialDamageSignature.__FInstanceRadialDamageSignature_DelegateParams[(UIntPtr)87] + 15L / (long)sizeof(FInstanceRadialDamageSignature.__FInstanceRadialDamageSignature_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FInstanceRadialDamageSignature.StaticFunctionPtr(), (void*)ptr, 1);
			TArray<int> tarray = Instances;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->Instances);
			}
			TArray<float> tarray2 = Damages;
			if (tarray2 != null)
			{
				tarray2.MoveTo(&ptr->Damages);
			}
			ptr->InstigatedBy = ((InstigatedBy != null) ? InstigatedBy.NativePtr : IntPtr.Zero);
			ptr->Origin = Origin;
			ptr->MaxRadius = MaxRadius;
			ptr->DamageType = ((DamageType != null) ? DamageType.NativePtr : IntPtr.Zero);
			ptr->DamageCauser = ((DamageCauser != null) ? DamageCauser.NativePtr : IntPtr.Zero);
			base.BroadcastInternal((void*)ptr);
			TArray<int> tarray3 = Instances;
			if (tarray3 != null)
			{
				tarray3.MoveAssign(&ptr->Instances);
			}
			TArray<float> tarray4 = Damages;
			if (tarray4 != null)
			{
				tarray4.MoveAssign(&ptr->Damages);
			}
			UnrealReflectionUtils.DestroyStruct(FInstanceRadialDamageSignature._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06011AAE RID: 72366 RVA: 0x0019F06C File Offset: 0x0019D26C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			FInstanceRadialDamageSignature.FInstanceRadialDamageSignature_ScriptDelegate finstanceRadialDamageSignature_ScriptDelegate = target as FInstanceRadialDamageSignature.FInstanceRadialDamageSignature_ScriptDelegate;
			if (finstanceRadialDamageSignature_ScriptDelegate == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			TArray<int> tarray = new TArray<int>(&((FInstanceRadialDamageSignature.__FInstanceRadialDamageSignature_DelegateParams*)__Parameters)->Instances, true, true);
			TArray<float> tarray2 = new TArray<float>(&((FInstanceRadialDamageSignature.__FInstanceRadialDamageSignature_DelegateParams*)__Parameters)->Damages, true, true);
			AController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AController>(((FInstanceRadialDamageSignature.__FInstanceRadialDamageSignature_DelegateParams*)__Parameters)->InstigatedBy);
			UDamageType orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UDamageType>(((FInstanceRadialDamageSignature.__FInstanceRadialDamageSignature_DelegateParams*)__Parameters)->DamageType);
			AActor orCreateUObjectByNativePointer3 = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(((FInstanceRadialDamageSignature.__FInstanceRadialDamageSignature_DelegateParams*)__Parameters)->DamageCauser);
			finstanceRadialDamageSignature_ScriptDelegate(tarray, tarray2, orCreateUObjectByNativePointer, ((FInstanceRadialDamageSignature.__FInstanceRadialDamageSignature_DelegateParams*)__Parameters)->Origin, ((FInstanceRadialDamageSignature.__FInstanceRadialDamageSignature_DelegateParams*)__Parameters)->MaxRadius, orCreateUObjectByNativePointer2, orCreateUObjectByNativePointer3);
			if (tarray != null)
			{
				tarray.CopyTo(&((FInstanceRadialDamageSignature.__FInstanceRadialDamageSignature_DelegateParams*)__Parameters)->Instances, default(UScriptStructStackOnlyPtr));
			}
			if (tarray2 != null)
			{
				tarray2.CopyTo(&((FInstanceRadialDamageSignature.__FInstanceRadialDamageSignature_DelegateParams*)__Parameters)->Damages, default(UScriptStructStackOnlyPtr));
			}
		}

		// Token: 0x040097A1 RID: 38817
		internal static IntPtr _FunctionPtr;

		// Token: 0x040097A2 RID: 38818
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Foliage.InstanceRadialDamageSignature__DelegateSignature";

		// Token: 0x040097A3 RID: 38819
		private static int RegisterId;

		// Token: 0x02002E1C RID: 11804
		// (Invoke) Token: 0x06028562 RID: 165218
		[NullableContext(2)]
		[Nullable(0)]
		public delegate void FInstanceRadialDamageSignature_ScriptDelegate(in TArray<int> Instances, in TArray<float> Damages, AController InstigatedBy, FVector Origin, float MaxRadius, UDamageType DamageType, AActor DamageCauser);

		// Token: 0x02002E1D RID: 11805
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 72)]
		protected ref struct __FInstanceRadialDamageSignature_DelegateParams
		{
			// Token: 0x040168A7 RID: 92327
			[FieldOffset(0)]
			public byte Instances;

			// Token: 0x040168A8 RID: 92328
			[FieldOffset(16)]
			public byte Damages;

			// Token: 0x040168A9 RID: 92329
			[FieldOffset(32)]
			public IntPtr InstigatedBy;

			// Token: 0x040168AA RID: 92330
			[FieldOffset(40)]
			public FVector Origin;

			// Token: 0x040168AB RID: 92331
			[FieldOffset(52)]
			public float MaxRadius;

			// Token: 0x040168AC RID: 92332
			[FieldOffset(56)]
			public IntPtr DamageType;

			// Token: 0x040168AD RID: 92333
			[FieldOffset(64)]
			public IntPtr DamageCauser;
		}

		// Token: 0x02002E1E RID: 11806
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040168AE RID: 92334
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
