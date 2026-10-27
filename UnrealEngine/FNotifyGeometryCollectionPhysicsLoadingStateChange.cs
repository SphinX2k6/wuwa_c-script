using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001433 RID: 5171
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FNotifyGeometryCollectionPhysicsLoadingStateChange : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06012EBD RID: 77501 RVA: 0x001BCF42 File Offset: 0x001BB142
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FNotifyGeometryCollectionPhysicsLoadingStateChange.StaticFunctionPtr();
		}

		// Token: 0x06012EBE RID: 77502 RVA: 0x001BCF4E File Offset: 0x001BB14E
		private static IntPtr StaticFunctionPtr()
		{
			if (UGeometryCollectionComponent.__NotifyGeometryCollectionPhysicsLoadingStateChange__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				UGeometryCollectionComponent.__NotifyGeometryCollectionPhysicsLoadingStateChange__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/GeometryCollectionEngine.GeometryCollectionComponent:NotifyGeometryCollectionPhysicsLoadingStateChange__DelegateSignature");
			}
			return UGeometryCollectionComponent.__NotifyGeometryCollectionPhysicsLoadingStateChange__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x06012EBF RID: 77503 RVA: 0x001BCF71 File Offset: 0x001BB171
		public FNotifyGeometryCollectionPhysicsLoadingStateChange()
		{
		}

		// Token: 0x06012EC0 RID: 77504 RVA: 0x001BCF79 File Offset: 0x001BB179
		[NullableContext(2)]
		public FNotifyGeometryCollectionPhysicsLoadingStateChange(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06012EC1 RID: 77505 RVA: 0x001BCF83 File Offset: 0x001BB183
		public FNotifyGeometryCollectionPhysicsLoadingStateChange(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06012EC2 RID: 77506 RVA: 0x001BCF8E File Offset: 0x001BB18E
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<UGeometryCollectionComponent>) ?? ((Action<UGeometryCollectionComponent>)Delegate.CreateDelegate(typeof(Action<UGeometryCollectionComponent>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06012EC3 RID: 77507 RVA: 0x001BCFC0 File Offset: 0x001BB1C0
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<UGeometryCollectionComponent> Callback)
		{
			if (FNotifyGeometryCollectionPhysicsLoadingStateChange.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FNotifyGeometryCollectionPhysicsLoadingStateChange.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FNotifyGeometryCollectionPhysicsLoadingStateChange.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FNotifyGeometryCollectionPhysicsLoadingStateChange.OnScriptCallback));
				}
				FNotifyGeometryCollectionPhysicsLoadingStateChange.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FNotifyGeometryCollectionPhysicsLoadingStateChange.RegisterId);
		}

		// Token: 0x06012EC4 RID: 77508 RVA: 0x001BCFFA File Offset: 0x001BB1FA
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<UGeometryCollectionComponent> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06012EC5 RID: 77509 RVA: 0x001BD004 File Offset: 0x001BB204
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(UGeometryCollectionComponent FracturedComponent)
		{
			FNotifyGeometryCollectionPhysicsLoadingStateChange.__FNotifyGeometryCollectionPhysicsLoadingStateChange_DelegateParams* ptr = stackalloc FNotifyGeometryCollectionPhysicsLoadingStateChange.__FNotifyGeometryCollectionPhysicsLoadingStateChange_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FNotifyGeometryCollectionPhysicsLoadingStateChange.__FNotifyGeometryCollectionPhysicsLoadingStateChange_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FNotifyGeometryCollectionPhysicsLoadingStateChange.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->FracturedComponent = ((FracturedComponent != null) ? FracturedComponent.NativePtr : IntPtr.Zero);
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x06012EC6 RID: 77510 RVA: 0x001BD050 File Offset: 0x001BB250
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
			UGeometryCollectionComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UGeometryCollectionComponent>(((FNotifyGeometryCollectionPhysicsLoadingStateChange.__FNotifyGeometryCollectionPhysicsLoadingStateChange_DelegateParams*)__Parameters)->FracturedComponent);
			action(orCreateUObjectByNativePointer);
		}

		// Token: 0x0400A1BF RID: 41407
		[Nullable(1)]
		public const string __ObjectPath = "/Script/GeometryCollectionEngine.GeometryCollectionComponent:NotifyGeometryCollectionPhysicsLoadingStateChange__DelegateSignature";

		// Token: 0x0400A1C0 RID: 41408
		private static int RegisterId;

		// Token: 0x02002E80 RID: 11904
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __FNotifyGeometryCollectionPhysicsLoadingStateChange_DelegateParams
		{
			// Token: 0x04016954 RID: 92500
			[FieldOffset(0)]
			public IntPtr FracturedComponent;
		}

		// Token: 0x02002E81 RID: 11905
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016955 RID: 92501
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
