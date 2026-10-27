using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000958 RID: 2392
	[UnrealStructLayout(1, 1, UnrealReflectionPropertyTypeCode.MulticastSparseDelegate)]
	public sealed class FComponentHitSignature : FSparseDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600874A RID: 34634 RVA: 0x000C1747 File Offset: 0x000BF947
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FComponentHitSignature.StaticFunctionPtr();
		}

		// Token: 0x0600874B RID: 34635 RVA: 0x000C1753 File Offset: 0x000BF953
		private static IntPtr StaticFunctionPtr()
		{
			if (FComponentHitSignature._FunctionPtr == IntPtr.Zero)
			{
				FComponentHitSignature._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.ComponentHitSignature__DelegateSignature");
			}
			return FComponentHitSignature._FunctionPtr;
		}

		// Token: 0x17001FFC RID: 8188
		// (get) Token: 0x0600874C RID: 34636 RVA: 0x000C1776 File Offset: 0x000BF976
		public override FName DelegateName
		{
			get
			{
				return FNameStatic.OnComponentHit;
			}
		}

		// Token: 0x0600874D RID: 34637 RVA: 0x000C177D File Offset: 0x000BF97D
		[NullableContext(2)]
		public FComponentHitSignature(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600874E RID: 34638 RVA: 0x000C1787 File Offset: 0x000BF987
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<UPrimitiveComponent, AActor, UPrimitiveComponent, FVector, FHitResult>) ?? ((Action<UPrimitiveComponent, AActor, UPrimitiveComponent, FVector, FHitResult>)Delegate.CreateDelegate(typeof(Action<UPrimitiveComponent, AActor, UPrimitiveComponent, FVector, FHitResult>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600874F RID: 34639 RVA: 0x000C17BC File Offset: 0x000BF9BC
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2,
			2,
			2,
			1
		})] Action<UPrimitiveComponent, AActor, UPrimitiveComponent, FVector, FHitResult> Callback)
		{
			if (FComponentHitSignature.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FComponentHitSignature.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FComponentHitSignature.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FComponentHitSignature.OnScriptCallback));
				}
				FComponentHitSignature.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			FName delegateName = this.DelegateName;
			base.Add(delegateName, Callback, FComponentHitSignature.RegisterId);
		}

		// Token: 0x06008750 RID: 34640 RVA: 0x000C180C File Offset: 0x000BFA0C
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2,
			2,
			2,
			1
		})] Action<UPrimitiveComponent, AActor, UPrimitiveComponent, FVector, FHitResult> Callback)
		{
			FName delegateName = this.DelegateName;
			base.Remove(delegateName, Callback);
		}

		// Token: 0x06008751 RID: 34641 RVA: 0x000C182C File Offset: 0x000BFA2C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(UPrimitiveComponent HitComponent, AActor OtherActor, UPrimitiveComponent OtherComp, FVector NormalImpulse, in FHitResult Hit)
		{
			FComponentHitSignature.__FComponentHitSignature_DelegateParams* ptr = stackalloc FComponentHitSignature.__FComponentHitSignature_DelegateParams[(UIntPtr)199] + 15L / (long)sizeof(FComponentHitSignature.__FComponentHitSignature_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FComponentHitSignature.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->HitComponent = ((HitComponent != null) ? HitComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->NormalImpulse = NormalImpulse;
			if (Hit != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FHitResult.StaticStruct(), &ptr->Hit, Hit.NativePtr, 1, false);
			}
			FSparseDelegate.BroadcastInternal(base.GetOwner().NativePtr, this.DelegateName, (void*)ptr);
		}

		// Token: 0x06008752 RID: 34642 RVA: 0x000C18E4 File Offset: 0x000BFAE4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<UPrimitiveComponent, AActor, UPrimitiveComponent, FVector, FHitResult> action = target as Action<UPrimitiveComponent, AActor, UPrimitiveComponent, FVector, FHitResult>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			UPrimitiveComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UPrimitiveComponent>(((FComponentHitSignature.__FComponentHitSignature_DelegateParams*)__Parameters)->HitComponent);
			AActor orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(((FComponentHitSignature.__FComponentHitSignature_DelegateParams*)__Parameters)->OtherActor);
			UPrimitiveComponent orCreateUObjectByNativePointer3 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UPrimitiveComponent>(((FComponentHitSignature.__FComponentHitSignature_DelegateParams*)__Parameters)->OtherComp);
			FHitResult arg = new FHitResult(&((FComponentHitSignature.__FComponentHitSignature_DelegateParams*)__Parameters)->Hit, true, true);
			action(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, orCreateUObjectByNativePointer3, ((FComponentHitSignature.__FComponentHitSignature_DelegateParams*)__Parameters)->NormalImpulse, arg);
		}

		// Token: 0x0400405D RID: 16477
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400405E RID: 16478
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.ComponentHitSignature__DelegateSignature";

		// Token: 0x0400405F RID: 16479
		private static int RegisterId;

		// Token: 0x02002CD1 RID: 11473
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		protected ref struct __FComponentHitSignature_DelegateParams
		{
			// Token: 0x04016675 RID: 91765
			[FieldOffset(0)]
			public IntPtr HitComponent;

			// Token: 0x04016676 RID: 91766
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x04016677 RID: 91767
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x04016678 RID: 91768
			[FieldOffset(24)]
			public FVector NormalImpulse;

			// Token: 0x04016679 RID: 91769
			[FieldOffset(36)]
			public byte Hit;
		}

		// Token: 0x02002CD2 RID: 11474
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401667A RID: 91770
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
