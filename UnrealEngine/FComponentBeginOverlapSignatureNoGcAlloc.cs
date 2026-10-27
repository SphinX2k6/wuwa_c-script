using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000951 RID: 2385
	[UnrealStructLayout(1, 1, UnrealReflectionPropertyTypeCode.MulticastSparseDelegate)]
	public sealed class FComponentBeginOverlapSignatureNoGcAlloc : FSparseDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600870D RID: 34573 RVA: 0x000C0C3C File Offset: 0x000BEE3C
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FComponentBeginOverlapSignatureNoGcAlloc.StaticFunctionPtr();
		}

		// Token: 0x0600870E RID: 34574 RVA: 0x000C0C48 File Offset: 0x000BEE48
		private static IntPtr StaticFunctionPtr()
		{
			if (FComponentBeginOverlapSignatureNoGcAlloc._FunctionPtr == IntPtr.Zero)
			{
				FComponentBeginOverlapSignatureNoGcAlloc._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.ComponentBeginOverlapSignatureNoGcAlloc__DelegateSignature");
			}
			return FComponentBeginOverlapSignatureNoGcAlloc._FunctionPtr;
		}

		// Token: 0x17001FF5 RID: 8181
		// (get) Token: 0x0600870F RID: 34575 RVA: 0x000C0C6B File Offset: 0x000BEE6B
		public override FName DelegateName
		{
			get
			{
				return FNameStatic.OnComponentBeginOverlapNoGcAlloc;
			}
		}

		// Token: 0x06008710 RID: 34576 RVA: 0x000C0C72 File Offset: 0x000BEE72
		[NullableContext(2)]
		public FComponentBeginOverlapSignatureNoGcAlloc(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06008711 RID: 34577 RVA: 0x000C0C7C File Offset: 0x000BEE7C
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<UPrimitiveComponent, AActor, UPrimitiveComponent>) ?? ((Action<UPrimitiveComponent, AActor, UPrimitiveComponent>)Delegate.CreateDelegate(typeof(Action<UPrimitiveComponent, AActor, UPrimitiveComponent>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06008712 RID: 34578 RVA: 0x000C0CB0 File Offset: 0x000BEEB0
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x06008713 RID: 34579 RVA: 0x000C0D00 File Offset: 0x000BEF00
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x06008714 RID: 34580 RVA: 0x000C0D20 File Offset: 0x000BEF20
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp)
		{
			FComponentBeginOverlapSignatureNoGcAlloc.__FComponentBeginOverlapSignatureNoGcAlloc_DelegateParams* ptr = stackalloc FComponentBeginOverlapSignatureNoGcAlloc.__FComponentBeginOverlapSignatureNoGcAlloc_DelegateParams[(UIntPtr)39] + 15L / (long)sizeof(FComponentBeginOverlapSignatureNoGcAlloc.__FComponentBeginOverlapSignatureNoGcAlloc_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FComponentBeginOverlapSignatureNoGcAlloc.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			FSparseDelegate.BroadcastInternal(base.GetOwner().NativePtr, this.DelegateName, (void*)ptr);
		}

		// Token: 0x06008715 RID: 34581 RVA: 0x000C0DA8 File Offset: 0x000BEFA8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x04004046 RID: 16454
		internal static IntPtr _FunctionPtr;

		// Token: 0x04004047 RID: 16455
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.ComponentBeginOverlapSignatureNoGcAlloc__DelegateSignature";

		// Token: 0x04004048 RID: 16456
		private static int RegisterId;

		// Token: 0x02002CC5 RID: 11461
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __FComponentBeginOverlapSignatureNoGcAlloc_DelegateParams
		{
			// Token: 0x04016660 RID: 91744
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x04016661 RID: 91745
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x04016662 RID: 91746
			[FieldOffset(16)]
			public IntPtr OtherComp;
		}

		// Token: 0x02002CC6 RID: 11462
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016663 RID: 91747
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
