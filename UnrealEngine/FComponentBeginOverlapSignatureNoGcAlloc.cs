using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020001AD RID: 429
	[UnrealStructLayout(1, 1, UnrealReflectionPropertyTypeCode.MulticastSparseDelegate)]
	public sealed class FComponentBeginOverlapSignatureNoGcAlloc : FSparseDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06001FF4 RID: 8180 RVA: 0x0002E5FC File Offset: 0x0002C7FC
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FComponentBeginOverlapSignatureNoGcAlloc.StaticFunctionPtr();
		}

		// Token: 0x06001FF5 RID: 8181 RVA: 0x0002E608 File Offset: 0x0002C808
		private static IntPtr StaticFunctionPtr()
		{
			if (FComponentBeginOverlapSignatureNoGcAlloc._FunctionPtr == IntPtr.Zero)
			{
				FComponentBeginOverlapSignatureNoGcAlloc._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.ComponentBeginOverlapSignatureNoGcAlloc__DelegateSignature");
			}
			return FComponentBeginOverlapSignatureNoGcAlloc._FunctionPtr;
		}

		// Token: 0x17000475 RID: 1141
		// (get) Token: 0x06001FF6 RID: 8182 RVA: 0x0002E62B File Offset: 0x0002C82B
		public override FName DelegateName
		{
			get
			{
				return FNameStatic.OnComponentBeginOverlapNoGcAlloc;
			}
		}

		// Token: 0x06001FF7 RID: 8183 RVA: 0x0002E632 File Offset: 0x0002C832
		[NullableContext(2)]
		public FComponentBeginOverlapSignatureNoGcAlloc(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06001FF8 RID: 8184 RVA: 0x0002E63C File Offset: 0x0002C83C
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<UPrimitiveComponent, AActor, UPrimitiveComponent>) ?? ((Action<UPrimitiveComponent, AActor, UPrimitiveComponent>)Delegate.CreateDelegate(typeof(Action<UPrimitiveComponent, AActor, UPrimitiveComponent>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06001FF9 RID: 8185 RVA: 0x0002E670 File Offset: 0x0002C870
		public void Add([Nullable(new byte[]
		{
			1,
			2,
			2,
			2
		})] Action<UPrimitiveComponent, AActor, UPrimitiveComponent> Callback)
		{
			if (FComponentBeginOverlapSignatureNoGcAlloc.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FComponentBeginOverlapSignatureNoGcAlloc.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FComponentBeginOverlapSignatureNoGcAlloc.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FComponentBeginOverlapSignatureNoGcAlloc.OnScriptCallback));
				}
				FComponentBeginOverlapSignatureNoGcAlloc.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			FName delegateName = this.DelegateName;
			base.Add(delegateName, Callback, FComponentBeginOverlapSignatureNoGcAlloc.RegisterId);
		}

		// Token: 0x06001FFA RID: 8186 RVA: 0x0002E6C0 File Offset: 0x0002C8C0
		public void Remove([Nullable(new byte[]
		{
			1,
			2,
			2,
			2
		})] Action<UPrimitiveComponent, AActor, UPrimitiveComponent> Callback)
		{
			FName delegateName = this.DelegateName;
			base.Remove(delegateName, Callback);
		}

		// Token: 0x06001FFB RID: 8187 RVA: 0x0002E6E0 File Offset: 0x0002C8E0
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Broadcast(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp)
		{
			FComponentBeginOverlapSignatureNoGcAlloc.__FComponentBeginOverlapSignatureNoGcAlloc_DelegateParams* ptr = stackalloc FComponentBeginOverlapSignatureNoGcAlloc.__FComponentBeginOverlapSignatureNoGcAlloc_DelegateParams[(UIntPtr)39] + 15L / (long)sizeof(FComponentBeginOverlapSignatureNoGcAlloc.__FComponentBeginOverlapSignatureNoGcAlloc_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FComponentBeginOverlapSignatureNoGcAlloc.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			FSparseDelegate.BroadcastInternal(base.GetOwner().NativePtr, this.DelegateName, (void*)ptr);
		}

		// Token: 0x06001FFC RID: 8188 RVA: 0x0002E768 File Offset: 0x0002C968
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<UPrimitiveComponent, AActor, UPrimitiveComponent> action = target as Action<UPrimitiveComponent, AActor, UPrimitiveComponent>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			UPrimitiveComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UPrimitiveComponent>(((FComponentBeginOverlapSignatureNoGcAlloc.__FComponentBeginOverlapSignatureNoGcAlloc_DelegateParams*)__Parameters)->OverlappedComponent);
			AActor orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(((FComponentBeginOverlapSignatureNoGcAlloc.__FComponentBeginOverlapSignatureNoGcAlloc_DelegateParams*)__Parameters)->OtherActor);
			UPrimitiveComponent orCreateUObjectByNativePointer3 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UPrimitiveComponent>(((FComponentBeginOverlapSignatureNoGcAlloc.__FComponentBeginOverlapSignatureNoGcAlloc_DelegateParams*)__Parameters)->OtherComp);
			action(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, orCreateUObjectByNativePointer3);
		}

		// Token: 0x04000AA0 RID: 2720
		internal static IntPtr _FunctionPtr;

		// Token: 0x04000AA1 RID: 2721
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.ComponentBeginOverlapSignatureNoGcAlloc__DelegateSignature";

		// Token: 0x04000AA2 RID: 2722
		private static int RegisterId;

		// Token: 0x02000981 RID: 2433
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		private ref struct __FComponentBeginOverlapSignatureNoGcAlloc_DelegateParams
		{
			// Token: 0x040058D5 RID: 22741
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x040058D6 RID: 22742
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x040058D7 RID: 22743
			[FieldOffset(16)]
			public IntPtr OtherComp;
		}

		// Token: 0x02000982 RID: 2434
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040058D8 RID: 22744
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
