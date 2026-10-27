using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200191D RID: 6429
	public sealed class FMaterialSpecAddMaterialControllerDataRetVal : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06017DAE RID: 97710 RVA: 0x0022EF85 File Offset: 0x0022D185
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FMaterialSpecAddMaterialControllerDataRetVal.StaticFunctionPtr();
		}

		// Token: 0x06017DAF RID: 97711 RVA: 0x0022EF91 File Offset: 0x0022D191
		private static IntPtr StaticFunctionPtr()
		{
			if (FMaterialSpecAddMaterialControllerDataRetVal._FunctionPtr == IntPtr.Zero)
			{
				FMaterialSpecAddMaterialControllerDataRetVal._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroGameplay.MaterialSpecAddMaterialControllerDataRetVal__DelegateSignature");
			}
			return FMaterialSpecAddMaterialControllerDataRetVal._FunctionPtr;
		}

		// Token: 0x06017DB0 RID: 97712 RVA: 0x0022EFB4 File Offset: 0x0022D1B4
		public FMaterialSpecAddMaterialControllerDataRetVal()
		{
		}

		// Token: 0x06017DB1 RID: 97713 RVA: 0x0022EFBC File Offset: 0x0022D1BC
		[NullableContext(2)]
		public FMaterialSpecAddMaterialControllerDataRetVal(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06017DB2 RID: 97714 RVA: 0x0022EFC6 File Offset: 0x0022D1C6
		public FMaterialSpecAddMaterialControllerDataRetVal(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06017DB3 RID: 97715 RVA: 0x0022EFD1 File Offset: 0x0022D1D1
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Func<UKuroCharRenderingComponent, UKuroMaterialControllerDataAsset, int>) ?? ((Func<UKuroCharRenderingComponent, UKuroMaterialControllerDataAsset, int>)Delegate.CreateDelegate(typeof(Func<UKuroCharRenderingComponent, UKuroMaterialControllerDataAsset, int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06017DB4 RID: 97716 RVA: 0x0022F003 File Offset: 0x0022D203
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind([Nullable(new byte[]
		{
			1,
			2,
			2
		})] Func<UKuroCharRenderingComponent, UKuroMaterialControllerDataAsset, int> Callback)
		{
			if (FMaterialSpecAddMaterialControllerDataRetVal.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FMaterialSpecAddMaterialControllerDataRetVal.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FMaterialSpecAddMaterialControllerDataRetVal.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FMaterialSpecAddMaterialControllerDataRetVal.OnScriptCallback));
				}
				FMaterialSpecAddMaterialControllerDataRetVal.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FMaterialSpecAddMaterialControllerDataRetVal.RegisterId);
		}

		// Token: 0x06017DB5 RID: 97717 RVA: 0x0022F040 File Offset: 0x0022D240
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe int Execute(UKuroCharRenderingComponent RenderComponent, UKuroMaterialControllerDataAsset DataAsset)
		{
			FMaterialSpecAddMaterialControllerDataRetVal.__FMaterialSpecAddMaterialControllerDataRetVal_DelegateParams* ptr = stackalloc FMaterialSpecAddMaterialControllerDataRetVal.__FMaterialSpecAddMaterialControllerDataRetVal_DelegateParams[(UIntPtr)39] + 15L / (long)sizeof(FMaterialSpecAddMaterialControllerDataRetVal.__FMaterialSpecAddMaterialControllerDataRetVal_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FMaterialSpecAddMaterialControllerDataRetVal.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->RenderComponent = ((RenderComponent != null) ? RenderComponent.NativePtr : IntPtr.Zero);
			ptr->DataAsset = ((DataAsset != null) ? DataAsset.NativePtr : IntPtr.Zero);
			base.ExecuteInternal((void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06017DB6 RID: 97718 RVA: 0x0022F0A8 File Offset: 0x0022D2A8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Func<UKuroCharRenderingComponent, UKuroMaterialControllerDataAsset, int> func = target as Func<UKuroCharRenderingComponent, UKuroMaterialControllerDataAsset, int>;
			if (func == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			UKuroCharRenderingComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroCharRenderingComponent>(((FMaterialSpecAddMaterialControllerDataRetVal.__FMaterialSpecAddMaterialControllerDataRetVal_DelegateParams*)__Parameters)->RenderComponent);
			UKuroMaterialControllerDataAsset orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroMaterialControllerDataAsset>(((FMaterialSpecAddMaterialControllerDataRetVal.__FMaterialSpecAddMaterialControllerDataRetVal_DelegateParams*)__Parameters)->DataAsset);
			int _Result = func(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
			((FMaterialSpecAddMaterialControllerDataRetVal.__FMaterialSpecAddMaterialControllerDataRetVal_DelegateParams*)__Parameters)->__Result = _Result;
		}

		// Token: 0x0400CEC8 RID: 52936
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400CEC9 RID: 52937
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameplay.MaterialSpecAddMaterialControllerDataRetVal__DelegateSignature";

		// Token: 0x0400CECA RID: 52938
		private static int RegisterId;

		// Token: 0x02002FE3 RID: 12259
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __FMaterialSpecAddMaterialControllerDataRetVal_DelegateParams
		{
			// Token: 0x04016BDD RID: 93149
			[FieldOffset(0)]
			public IntPtr RenderComponent;

			// Token: 0x04016BDE RID: 93150
			[FieldOffset(8)]
			public IntPtr DataAsset;

			// Token: 0x04016BDF RID: 93151
			[FieldOffset(16)]
			public int __Result;
		}

		// Token: 0x02002FE4 RID: 12260
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016BE0 RID: 93152
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
