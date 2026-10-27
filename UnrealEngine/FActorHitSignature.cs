using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020007C5 RID: 1989
	[UnrealStructLayout(1, 1, UnrealReflectionPropertyTypeCode.MulticastSparseDelegate)]
	public sealed class FActorHitSignature : FSparseDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06006A39 RID: 27193 RVA: 0x00098C47 File Offset: 0x00096E47
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FActorHitSignature.StaticFunctionPtr();
		}

		// Token: 0x06006A3A RID: 27194 RVA: 0x00098C53 File Offset: 0x00096E53
		private static IntPtr StaticFunctionPtr()
		{
			if (FActorHitSignature._FunctionPtr == IntPtr.Zero)
			{
				FActorHitSignature._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.ActorHitSignature__DelegateSignature");
			}
			return FActorHitSignature._FunctionPtr;
		}

		// Token: 0x17001916 RID: 6422
		// (get) Token: 0x06006A3B RID: 27195 RVA: 0x00098C76 File Offset: 0x00096E76
		public override FName DelegateName
		{
			get
			{
				return FNameStatic.OnActorHit;
			}
		}

		// Token: 0x06006A3C RID: 27196 RVA: 0x00098C7D File Offset: 0x00096E7D
		[NullableContext(2)]
		public FActorHitSignature(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006A3D RID: 27197 RVA: 0x00098C87 File Offset: 0x00096E87
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<AActor, AActor, FVector, FHitResult>) ?? ((Action<AActor, AActor, FVector, FHitResult>)Delegate.CreateDelegate(typeof(Action<AActor, AActor, FVector, FHitResult>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06006A3E RID: 27198 RVA: 0x00098CBC File Offset: 0x00096EBC
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x06006A3F RID: 27199 RVA: 0x00098D0C File Offset: 0x00096F0C
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x06006A40 RID: 27200 RVA: 0x00098D2C File Offset: 0x00096F2C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x06006A41 RID: 27201 RVA: 0x00098DD0 File Offset: 0x00096FD0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x0400332D RID: 13101
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400332E RID: 13102
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.ActorHitSignature__DelegateSignature";

		// Token: 0x0400332F RID: 13103
		private static int RegisterId;

		// Token: 0x02002C77 RID: 11383
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 176)]
		protected ref struct __FActorHitSignature_DelegateParams
		{
			// Token: 0x040165A9 RID: 91561
			[FieldOffset(0)]
			public IntPtr SelfActor;

			// Token: 0x040165AA RID: 91562
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x040165AB RID: 91563
			[FieldOffset(16)]
			public FVector NormalImpulse;

			// Token: 0x040165AC RID: 91564
			[FieldOffset(28)]
			public byte Hit;
		}

		// Token: 0x02002C78 RID: 11384
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040165AD RID: 91565
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
