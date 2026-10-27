using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001434 RID: 5172
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FNotifyGeometryCollectionPhysicsStateChange : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06012EC7 RID: 77511 RVA: 0x001BD0A1 File Offset: 0x001BB2A1
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FNotifyGeometryCollectionPhysicsStateChange.StaticFunctionPtr();
		}

		// Token: 0x06012EC8 RID: 77512 RVA: 0x001BD0AD File Offset: 0x001BB2AD
		private static IntPtr StaticFunctionPtr()
		{
			if (UGeometryCollectionComponent.__NotifyGeometryCollectionPhysicsStateChange__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				UGeometryCollectionComponent.__NotifyGeometryCollectionPhysicsStateChange__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/GeometryCollectionEngine.GeometryCollectionComponent:NotifyGeometryCollectionPhysicsStateChange__DelegateSignature");
			}
			return UGeometryCollectionComponent.__NotifyGeometryCollectionPhysicsStateChange__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x06012EC9 RID: 77513 RVA: 0x001BD0D0 File Offset: 0x001BB2D0
		public FNotifyGeometryCollectionPhysicsStateChange()
		{
		}

		// Token: 0x06012ECA RID: 77514 RVA: 0x001BD0D8 File Offset: 0x001BB2D8
		[NullableContext(2)]
		public FNotifyGeometryCollectionPhysicsStateChange(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06012ECB RID: 77515 RVA: 0x001BD0E2 File Offset: 0x001BB2E2
		public FNotifyGeometryCollectionPhysicsStateChange(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06012ECC RID: 77516 RVA: 0x001BD0ED File Offset: 0x001BB2ED
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<UGeometryCollectionComponent>) ?? ((Action<UGeometryCollectionComponent>)Delegate.CreateDelegate(typeof(Action<UGeometryCollectionComponent>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06012ECD RID: 77517 RVA: 0x001BD11F File Offset: 0x001BB31F
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<UGeometryCollectionComponent> Callback)
		{
			if (FNotifyGeometryCollectionPhysicsStateChange.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FNotifyGeometryCollectionPhysicsStateChange.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FNotifyGeometryCollectionPhysicsStateChange.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FNotifyGeometryCollectionPhysicsStateChange.OnScriptCallback));
				}
				FNotifyGeometryCollectionPhysicsStateChange.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FNotifyGeometryCollectionPhysicsStateChange.RegisterId);
		}

		// Token: 0x06012ECE RID: 77518 RVA: 0x001BD159 File Offset: 0x001BB359
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<UGeometryCollectionComponent> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06012ECF RID: 77519 RVA: 0x001BD164 File Offset: 0x001BB364
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(UGeometryCollectionComponent FracturedComponent)
		{
			FNotifyGeometryCollectionPhysicsStateChange.__FNotifyGeometryCollectionPhysicsStateChange_DelegateParams* ptr = stackalloc FNotifyGeometryCollectionPhysicsStateChange.__FNotifyGeometryCollectionPhysicsStateChange_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FNotifyGeometryCollectionPhysicsStateChange.__FNotifyGeometryCollectionPhysicsStateChange_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FNotifyGeometryCollectionPhysicsStateChange.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->FracturedComponent = ((FracturedComponent != null) ? FracturedComponent.NativePtr : IntPtr.Zero);
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x06012ED0 RID: 77520 RVA: 0x001BD1B0 File Offset: 0x001BB3B0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<UGeometryCollectionComponent> action = target as Action<UGeometryCollectionComponent>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			UGeometryCollectionComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UGeometryCollectionComponent>(((FNotifyGeometryCollectionPhysicsStateChange.__FNotifyGeometryCollectionPhysicsStateChange_DelegateParams*)__Parameters)->FracturedComponent);
			action(orCreateUObjectByNativePointer);
		}

		// Token: 0x0400A1C1 RID: 41409
		[Nullable(1)]
		public const string __ObjectPath = "/Script/GeometryCollectionEngine.GeometryCollectionComponent:NotifyGeometryCollectionPhysicsStateChange__DelegateSignature";

		// Token: 0x0400A1C2 RID: 41410
		private static int RegisterId;

		// Token: 0x02002E82 RID: 11906
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __FNotifyGeometryCollectionPhysicsStateChange_DelegateParams
		{
			// Token: 0x04016956 RID: 92502
			[FieldOffset(0)]
			public IntPtr FracturedComponent;
		}

		// Token: 0x02002E83 RID: 11907
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016957 RID: 92503
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
