using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000410 RID: 1040
	public sealed class FMaterialSpecRemoveMaterialControllerData : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06006551 RID: 25937 RVA: 0x00090D11 File Offset: 0x0008EF11
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FMaterialSpecRemoveMaterialControllerData.StaticFunctionPtr();
		}

		// Token: 0x06006552 RID: 25938 RVA: 0x00090D1D File Offset: 0x0008EF1D
		private static IntPtr StaticFunctionPtr()
		{
			if (FMaterialSpecRemoveMaterialControllerData._FunctionPtr == IntPtr.Zero)
			{
				FMaterialSpecRemoveMaterialControllerData._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroGameplay.MaterialSpecRemoveMaterialControllerData__DelegateSignature");
			}
			return FMaterialSpecRemoveMaterialControllerData._FunctionPtr;
		}

		// Token: 0x06006553 RID: 25939 RVA: 0x00090D40 File Offset: 0x0008EF40
		public FMaterialSpecRemoveMaterialControllerData()
		{
		}

		// Token: 0x06006554 RID: 25940 RVA: 0x00090D48 File Offset: 0x0008EF48
		[NullableContext(2)]
		public FMaterialSpecRemoveMaterialControllerData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006555 RID: 25941 RVA: 0x00090D52 File Offset: 0x0008EF52
		public FMaterialSpecRemoveMaterialControllerData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06006556 RID: 25942 RVA: 0x00090D5D File Offset: 0x0008EF5D
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<UKuroCharRenderingComponent, int>) ?? ((Action<UKuroCharRenderingComponent, int>)Delegate.CreateDelegate(typeof(Action<UKuroCharRenderingComponent, int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06006557 RID: 25943 RVA: 0x00090D8F File Offset: 0x0008EF8F
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

		// Token: 0x06006558 RID: 25944 RVA: 0x00090DCC File Offset: 0x0008EFCC
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Execute(UKuroCharRenderingComponent RenderComponent, int MaterialControllerHandle)
		{
			FMaterialSpecRemoveMaterialControllerData.__FMaterialSpecRemoveMaterialControllerData_DelegateParams* ptr = stackalloc FMaterialSpecRemoveMaterialControllerData.__FMaterialSpecRemoveMaterialControllerData_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FMaterialSpecRemoveMaterialControllerData.__FMaterialSpecRemoveMaterialControllerData_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FMaterialSpecRemoveMaterialControllerData.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->RenderComponent = ((RenderComponent != null) ? RenderComponent.NativePtr : IntPtr.Zero);
			ptr->MaterialControllerHandle = MaterialControllerHandle;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x06006559 RID: 25945 RVA: 0x00090E20 File Offset: 0x0008F020
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x04002A9C RID: 10908
		internal static IntPtr _FunctionPtr;

		// Token: 0x04002A9D RID: 10909
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameplay.MaterialSpecRemoveMaterialControllerData__DelegateSignature";

		// Token: 0x04002A9E RID: 10910
		private static int RegisterId;

		// Token: 0x02000B01 RID: 2817
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		private ref struct __FMaterialSpecRemoveMaterialControllerData_DelegateParams
		{
			// Token: 0x04005B97 RID: 23447
			[FieldOffset(0)]
			public IntPtr RenderComponent;

			// Token: 0x04005B98 RID: 23448
			[FieldOffset(8)]
			public int MaterialControllerHandle;
		}

		// Token: 0x02000B02 RID: 2818
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005B99 RID: 23449
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
