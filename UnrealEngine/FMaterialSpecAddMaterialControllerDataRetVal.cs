using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200040B RID: 1035
	public sealed class FMaterialSpecAddMaterialControllerDataRetVal : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06006524 RID: 25892 RVA: 0x00090585 File Offset: 0x0008E785
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FMaterialSpecAddMaterialControllerDataRetVal.StaticFunctionPtr();
		}

		// Token: 0x06006525 RID: 25893 RVA: 0x00090591 File Offset: 0x0008E791
		private static IntPtr StaticFunctionPtr()
		{
			if (FMaterialSpecAddMaterialControllerDataRetVal._FunctionPtr == IntPtr.Zero)
			{
				FMaterialSpecAddMaterialControllerDataRetVal._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroGameplay.MaterialSpecAddMaterialControllerDataRetVal__DelegateSignature");
			}
			return FMaterialSpecAddMaterialControllerDataRetVal._FunctionPtr;
		}

		// Token: 0x06006526 RID: 25894 RVA: 0x000905B4 File Offset: 0x0008E7B4
		public FMaterialSpecAddMaterialControllerDataRetVal()
		{
		}

		// Token: 0x06006527 RID: 25895 RVA: 0x000905BC File Offset: 0x0008E7BC
		[NullableContext(2)]
		public FMaterialSpecAddMaterialControllerDataRetVal(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006528 RID: 25896 RVA: 0x000905C6 File Offset: 0x0008E7C6
		public FMaterialSpecAddMaterialControllerDataRetVal(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06006529 RID: 25897 RVA: 0x000905D1 File Offset: 0x0008E7D1
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Func<UKuroCharRenderingComponent, UKuroMaterialControllerDataAsset, int>) ?? ((Func<UKuroCharRenderingComponent, UKuroMaterialControllerDataAsset, int>)Delegate.CreateDelegate(typeof(Func<UKuroCharRenderingComponent, UKuroMaterialControllerDataAsset, int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600652A RID: 25898 RVA: 0x00090603 File Offset: 0x0008E803
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

		// Token: 0x0600652B RID: 25899 RVA: 0x00090640 File Offset: 0x0008E840
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe int Execute(UKuroCharRenderingComponent RenderComponent, UKuroMaterialControllerDataAsset DataAsset)
		{
			FMaterialSpecAddMaterialControllerDataRetVal.__FMaterialSpecAddMaterialControllerDataRetVal_DelegateParams* ptr = stackalloc FMaterialSpecAddMaterialControllerDataRetVal.__FMaterialSpecAddMaterialControllerDataRetVal_DelegateParams[(UIntPtr)39] + 15L / (long)sizeof(FMaterialSpecAddMaterialControllerDataRetVal.__FMaterialSpecAddMaterialControllerDataRetVal_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FMaterialSpecAddMaterialControllerDataRetVal.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->RenderComponent = ((RenderComponent != null) ? RenderComponent.NativePtr : IntPtr.Zero);
			ptr->DataAsset = ((DataAsset != null) ? DataAsset.NativePtr : IntPtr.Zero);
			base.ExecuteInternal((void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0600652C RID: 25900 RVA: 0x000906A8 File Offset: 0x0008E8A8
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x04002A8D RID: 10893
		internal static IntPtr _FunctionPtr;

		// Token: 0x04002A8E RID: 10894
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameplay.MaterialSpecAddMaterialControllerDataRetVal__DelegateSignature";

		// Token: 0x04002A8F RID: 10895
		private static int RegisterId;

		// Token: 0x02000AF7 RID: 2807
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		private ref struct __FMaterialSpecAddMaterialControllerDataRetVal_DelegateParams
		{
			// Token: 0x04005B86 RID: 23430
			[FieldOffset(0)]
			public IntPtr RenderComponent;

			// Token: 0x04005B87 RID: 23431
			[FieldOffset(8)]
			public IntPtr DataAsset;

			// Token: 0x04005B88 RID: 23432
			[FieldOffset(16)]
			public int __Result;
		}

		// Token: 0x02000AF8 RID: 2808
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005B89 RID: 23433
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
