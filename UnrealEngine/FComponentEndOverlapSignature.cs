using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020001B1 RID: 433
	[UnrealStructLayout(1, 1, UnrealReflectionPropertyTypeCode.MulticastSparseDelegate)]
	public sealed class FComponentEndOverlapSignature : FSparseDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06002018 RID: 8216 RVA: 0x0002ECB5 File Offset: 0x0002CEB5
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FComponentEndOverlapSignature.StaticFunctionPtr();
		}

		// Token: 0x06002019 RID: 8217 RVA: 0x0002ECC1 File Offset: 0x0002CEC1
		private static IntPtr StaticFunctionPtr()
		{
			if (FComponentEndOverlapSignature._FunctionPtr == IntPtr.Zero)
			{
				FComponentEndOverlapSignature._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.ComponentEndOverlapSignature__DelegateSignature");
			}
			return FComponentEndOverlapSignature._FunctionPtr;
		}

		// Token: 0x17000479 RID: 1145
		// (get) Token: 0x0600201A RID: 8218 RVA: 0x0002ECE4 File Offset: 0x0002CEE4
		public override FName DelegateName
		{
			get
			{
				return FNameStatic.OnComponentEndOverlap;
			}
		}

		// Token: 0x0600201B RID: 8219 RVA: 0x0002ECEB File Offset: 0x0002CEEB
		[NullableContext(2)]
		public FComponentEndOverlapSignature(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600201C RID: 8220 RVA: 0x0002ECF5 File Offset: 0x0002CEF5
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<UPrimitiveComponent, AActor, UPrimitiveComponent, int>) ?? ((Action<UPrimitiveComponent, AActor, UPrimitiveComponent, int>)Delegate.CreateDelegate(typeof(Action<UPrimitiveComponent, AActor, UPrimitiveComponent, int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600201D RID: 8221 RVA: 0x0002ED28 File Offset: 0x0002CF28
		public void Add([Nullable(new byte[]
		{
			1,
			2,
			2,
			2
		})] Action<UPrimitiveComponent, AActor, UPrimitiveComponent, int> Callback)
		{
			if (FComponentEndOverlapSignature.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FComponentEndOverlapSignature.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FComponentEndOverlapSignature.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FComponentEndOverlapSignature.OnScriptCallback));
				}
				FComponentEndOverlapSignature.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			FName delegateName = this.DelegateName;
			base.Add(delegateName, Callback, FComponentEndOverlapSignature.RegisterId);
		}

		// Token: 0x0600201E RID: 8222 RVA: 0x0002ED78 File Offset: 0x0002CF78
		public void Remove([Nullable(new byte[]
		{
			1,
			2,
			2,
			2
		})] Action<UPrimitiveComponent, AActor, UPrimitiveComponent, int> Callback)
		{
			FName delegateName = this.DelegateName;
			base.Remove(delegateName, Callback);
		}

		// Token: 0x0600201F RID: 8223 RVA: 0x0002ED98 File Offset: 0x0002CF98
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Broadcast(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex)
		{
			FComponentEndOverlapSignature.__FComponentEndOverlapSignature_DelegateParams* ptr = stackalloc FComponentEndOverlapSignature.__FComponentEndOverlapSignature_DelegateParams[(UIntPtr)47] + 15L / (long)sizeof(FComponentEndOverlapSignature.__FComponentEndOverlapSignature_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FComponentEndOverlapSignature.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			FSparseDelegate.BroadcastInternal(base.GetOwner().NativePtr, this.DelegateName, (void*)ptr);
		}

		// Token: 0x06002020 RID: 8224 RVA: 0x0002EE28 File Offset: 0x0002D028
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<UPrimitiveComponent, AActor, UPrimitiveComponent, int> action = target as Action<UPrimitiveComponent, AActor, UPrimitiveComponent, int>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			UPrimitiveComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UPrimitiveComponent>(((FComponentEndOverlapSignature.__FComponentEndOverlapSignature_DelegateParams*)__Parameters)->OverlappedComponent);
			AActor orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(((FComponentEndOverlapSignature.__FComponentEndOverlapSignature_DelegateParams*)__Parameters)->OtherActor);
			UPrimitiveComponent orCreateUObjectByNativePointer3 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UPrimitiveComponent>(((FComponentEndOverlapSignature.__FComponentEndOverlapSignature_DelegateParams*)__Parameters)->OtherComp);
			action(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, orCreateUObjectByNativePointer3, ((FComponentEndOverlapSignature.__FComponentEndOverlapSignature_DelegateParams*)__Parameters)->OtherBodyIndex);
		}

		// Token: 0x04000AAC RID: 2732
		internal static IntPtr _FunctionPtr;

		// Token: 0x04000AAD RID: 2733
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.ComponentEndOverlapSignature__DelegateSignature";

		// Token: 0x04000AAE RID: 2734
		private static int RegisterId;

		// Token: 0x02000989 RID: 2441
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		private ref struct __FComponentEndOverlapSignature_DelegateParams
		{
			// Token: 0x040058E2 RID: 22754
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x040058E3 RID: 22755
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x040058E4 RID: 22756
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x040058E5 RID: 22757
			[FieldOffset(24)]
			public int OtherBodyIndex;
		}

		// Token: 0x0200098A RID: 2442
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040058E6 RID: 22758
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
