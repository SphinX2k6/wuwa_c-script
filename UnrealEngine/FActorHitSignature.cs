using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200016D RID: 365
	[UnrealStructLayout(1, 1, UnrealReflectionPropertyTypeCode.MulticastSparseDelegate)]
	public sealed class FActorHitSignature : FSparseDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06001676 RID: 5750 RVA: 0x00022C7F File Offset: 0x00020E7F
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FActorHitSignature.StaticFunctionPtr();
		}

		// Token: 0x06001677 RID: 5751 RVA: 0x00022C8B File Offset: 0x00020E8B
		private static IntPtr StaticFunctionPtr()
		{
			if (FActorHitSignature._FunctionPtr == IntPtr.Zero)
			{
				FActorHitSignature._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.ActorHitSignature__DelegateSignature");
			}
			return FActorHitSignature._FunctionPtr;
		}

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x06001678 RID: 5752 RVA: 0x00022CAE File Offset: 0x00020EAE
		public override FName DelegateName
		{
			get
			{
				return FNameStatic.OnActorHit;
			}
		}

		// Token: 0x06001679 RID: 5753 RVA: 0x00022CB5 File Offset: 0x00020EB5
		[NullableContext(2)]
		public FActorHitSignature(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600167A RID: 5754 RVA: 0x00022CBF File Offset: 0x00020EBF
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<AActor, AActor, FVector, FHitResult>) ?? ((Action<AActor, AActor, FVector, FHitResult>)Delegate.CreateDelegate(typeof(Action<AActor, AActor, FVector, FHitResult>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600167B RID: 5755 RVA: 0x00022CF4 File Offset: 0x00020EF4
		public void Add([Nullable(new byte[]
		{
			1,
			2,
			2,
			1
		})] Action<AActor, AActor, FVector, FHitResult> Callback)
		{
			if (FActorHitSignature.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FActorHitSignature.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FActorHitSignature.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FActorHitSignature.OnScriptCallback));
				}
				FActorHitSignature.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			FName delegateName = this.DelegateName;
			base.Add(delegateName, Callback, FActorHitSignature.RegisterId);
		}

		// Token: 0x0600167C RID: 5756 RVA: 0x00022D44 File Offset: 0x00020F44
		public void Remove([Nullable(new byte[]
		{
			1,
			2,
			2,
			1
		})] Action<AActor, AActor, FVector, FHitResult> Callback)
		{
			FName delegateName = this.DelegateName;
			base.Remove(delegateName, Callback);
		}

		// Token: 0x0600167D RID: 5757 RVA: 0x00022D64 File Offset: 0x00020F64
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Broadcast(AActor SelfActor, AActor OtherActor, FVector NormalImpulse, in FHitResult Hit)
		{
			FActorHitSignature.__FActorHitSignature_DelegateParams* ptr = stackalloc FActorHitSignature.__FActorHitSignature_DelegateParams[(UIntPtr)191] + 15L / (long)sizeof(FActorHitSignature.__FActorHitSignature_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FActorHitSignature.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->SelfActor = ((SelfActor != null) ? SelfActor.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->NormalImpulse = NormalImpulse;
			if (Hit != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FHitResult.StaticStruct(), &ptr->Hit, Hit.NativePtr, 1, false);
			}
			FSparseDelegate.BroadcastInternal(base.GetOwner().NativePtr, this.DelegateName, (void*)ptr);
		}

		// Token: 0x0600167E RID: 5758 RVA: 0x00022E08 File Offset: 0x00021008
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<AActor, AActor, FVector, FHitResult> action = target as Action<AActor, AActor, FVector, FHitResult>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			AActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(((FActorHitSignature.__FActorHitSignature_DelegateParams*)__Parameters)->SelfActor);
			AActor orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(((FActorHitSignature.__FActorHitSignature_DelegateParams*)__Parameters)->OtherActor);
			FHitResult arg = new FHitResult(&((FActorHitSignature.__FActorHitSignature_DelegateParams*)__Parameters)->Hit, true, true);
			action(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, ((FActorHitSignature.__FActorHitSignature_DelegateParams*)__Parameters)->NormalImpulse, arg);
		}

		// Token: 0x04000725 RID: 1829
		internal static IntPtr _FunctionPtr;

		// Token: 0x04000726 RID: 1830
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.ActorHitSignature__DelegateSignature";

		// Token: 0x04000727 RID: 1831
		private static int RegisterId;

		// Token: 0x0200095A RID: 2394
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 176)]
		private ref struct __FActorHitSignature_DelegateParams
		{
			// Token: 0x0400587F RID: 22655
			[FieldOffset(0)]
			public IntPtr SelfActor;

			// Token: 0x04005880 RID: 22656
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x04005881 RID: 22657
			[FieldOffset(16)]
			public FVector NormalImpulse;

			// Token: 0x04005882 RID: 22658
			[FieldOffset(28)]
			public byte Hit;
		}

		// Token: 0x0200095B RID: 2395
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005883 RID: 22659
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
