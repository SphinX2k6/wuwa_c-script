using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020001B3 RID: 435
	[UnrealStructLayout(1, 1, UnrealReflectionPropertyTypeCode.MulticastSparseDelegate)]
	public sealed class FComponentHitSignature : FSparseDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600202A RID: 8234 RVA: 0x0002F03F File Offset: 0x0002D23F
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FComponentHitSignature.StaticFunctionPtr();
		}

		// Token: 0x0600202B RID: 8235 RVA: 0x0002F04B File Offset: 0x0002D24B
		private static IntPtr StaticFunctionPtr()
		{
			if (FComponentHitSignature._FunctionPtr == IntPtr.Zero)
			{
				FComponentHitSignature._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.ComponentHitSignature__DelegateSignature");
			}
			return FComponentHitSignature._FunctionPtr;
		}

		// Token: 0x1700047B RID: 1147
		// (get) Token: 0x0600202C RID: 8236 RVA: 0x0002F06E File Offset: 0x0002D26E
		public override FName DelegateName
		{
			get
			{
				return FNameStatic.OnComponentHit;
			}
		}

		// Token: 0x0600202D RID: 8237 RVA: 0x0002F075 File Offset: 0x0002D275
		[NullableContext(2)]
		public FComponentHitSignature(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600202E RID: 8238 RVA: 0x0002F07F File Offset: 0x0002D27F
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<UPrimitiveComponent, AActor, UPrimitiveComponent, FVector, FHitResult>) ?? ((Action<UPrimitiveComponent, AActor, UPrimitiveComponent, FVector, FHitResult>)Delegate.CreateDelegate(typeof(Action<UPrimitiveComponent, AActor, UPrimitiveComponent, FVector, FHitResult>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600202F RID: 8239 RVA: 0x0002F0B4 File Offset: 0x0002D2B4
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

		// Token: 0x06002030 RID: 8240 RVA: 0x0002F104 File Offset: 0x0002D304
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

		// Token: 0x06002031 RID: 8241 RVA: 0x0002F124 File Offset: 0x0002D324
		[NullableContext(2)]
		[SkipLocalsInit]
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

		// Token: 0x06002032 RID: 8242 RVA: 0x0002F1DC File Offset: 0x0002D3DC
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x04000AB2 RID: 2738
		internal static IntPtr _FunctionPtr;

		// Token: 0x04000AB3 RID: 2739
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.ComponentHitSignature__DelegateSignature";

		// Token: 0x04000AB4 RID: 2740
		private static int RegisterId;

		// Token: 0x0200098D RID: 2445
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		private ref struct __FComponentHitSignature_DelegateParams
		{
			// Token: 0x040058EA RID: 22762
			[FieldOffset(0)]
			public IntPtr HitComponent;

			// Token: 0x040058EB RID: 22763
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x040058EC RID: 22764
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x040058ED RID: 22765
			[FieldOffset(24)]
			public FVector NormalImpulse;

			// Token: 0x040058EE RID: 22766
			[FieldOffset(36)]
			public byte Hit;
		}

		// Token: 0x0200098E RID: 2446
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040058EF RID: 22767
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
