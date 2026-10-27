using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001922 RID: 6434
	public sealed class FMaterialSpecRemoveMaterialControllerData : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06017DDB RID: 97755 RVA: 0x0022F711 File Offset: 0x0022D911
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FMaterialSpecRemoveMaterialControllerData.StaticFunctionPtr();
		}

		// Token: 0x06017DDC RID: 97756 RVA: 0x0022F71D File Offset: 0x0022D91D
		private static IntPtr StaticFunctionPtr()
		{
			if (FMaterialSpecRemoveMaterialControllerData._FunctionPtr == IntPtr.Zero)
			{
				FMaterialSpecRemoveMaterialControllerData._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroGameplay.MaterialSpecRemoveMaterialControllerData__DelegateSignature");
			}
			return FMaterialSpecRemoveMaterialControllerData._FunctionPtr;
		}

		// Token: 0x06017DDD RID: 97757 RVA: 0x0022F740 File Offset: 0x0022D940
		public FMaterialSpecRemoveMaterialControllerData()
		{
		}

		// Token: 0x06017DDE RID: 97758 RVA: 0x0022F748 File Offset: 0x0022D948
		[NullableContext(2)]
		public FMaterialSpecRemoveMaterialControllerData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06017DDF RID: 97759 RVA: 0x0022F752 File Offset: 0x0022D952
		public FMaterialSpecRemoveMaterialControllerData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06017DE0 RID: 97760 RVA: 0x0022F75D File Offset: 0x0022D95D
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<UKuroCharRenderingComponent, int>) ?? ((Action<UKuroCharRenderingComponent, int>)Delegate.CreateDelegate(typeof(Action<UKuroCharRenderingComponent, int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06017DE1 RID: 97761 RVA: 0x0022F78F File Offset: 0x0022D98F
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind([Nullable(new byte[]
		{
			1,
			2
		})] Action<UKuroCharRenderingComponent, int> Callback)
		{
			if (FMaterialSpecRemoveMaterialControllerData.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FMaterialSpecRemoveMaterialControllerData.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FMaterialSpecRemoveMaterialControllerData.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FMaterialSpecRemoveMaterialControllerData.OnScriptCallback));
				}
				FMaterialSpecRemoveMaterialControllerData.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FMaterialSpecRemoveMaterialControllerData.RegisterId);
		}

		// Token: 0x06017DE2 RID: 97762 RVA: 0x0022F7CC File Offset: 0x0022D9CC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(UKuroCharRenderingComponent RenderComponent, int MaterialControllerHandle)
		{
			FMaterialSpecRemoveMaterialControllerData.__FMaterialSpecRemoveMaterialControllerData_DelegateParams* ptr = stackalloc FMaterialSpecRemoveMaterialControllerData.__FMaterialSpecRemoveMaterialControllerData_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FMaterialSpecRemoveMaterialControllerData.__FMaterialSpecRemoveMaterialControllerData_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FMaterialSpecRemoveMaterialControllerData.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->RenderComponent = ((RenderComponent != null) ? RenderComponent.NativePtr : IntPtr.Zero);
			ptr->MaterialControllerHandle = MaterialControllerHandle;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x06017DE3 RID: 97763 RVA: 0x0022F820 File Offset: 0x0022DA20
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<UKuroCharRenderingComponent, int> action = target as Action<UKuroCharRenderingComponent, int>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			UKuroCharRenderingComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroCharRenderingComponent>(((FMaterialSpecRemoveMaterialControllerData.__FMaterialSpecRemoveMaterialControllerData_DelegateParams*)__Parameters)->RenderComponent);
			action(orCreateUObjectByNativePointer, ((FMaterialSpecRemoveMaterialControllerData.__FMaterialSpecRemoveMaterialControllerData_DelegateParams*)__Parameters)->MaterialControllerHandle);
		}

		// Token: 0x0400CED7 RID: 52951
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400CED8 RID: 52952
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameplay.MaterialSpecRemoveMaterialControllerData__DelegateSignature";

		// Token: 0x0400CED9 RID: 52953
		private static int RegisterId;

		// Token: 0x02002FED RID: 12269
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FMaterialSpecRemoveMaterialControllerData_DelegateParams
		{
			// Token: 0x04016BEE RID: 93166
			[FieldOffset(0)]
			public IntPtr RenderComponent;

			// Token: 0x04016BEF RID: 93167
			[FieldOffset(8)]
			public int MaterialControllerHandle;
		}

		// Token: 0x02002FEE RID: 12270
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016BF0 RID: 93168
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
