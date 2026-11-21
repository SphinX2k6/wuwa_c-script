using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020003BD RID: 957
	public sealed class FEffectHandleGetOrAddEffectDynamicGroupRetVal : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06005D9F RID: 23967 RVA: 0x000845D1 File Offset: 0x000827D1
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FEffectHandleGetOrAddEffectDynamicGroupRetVal.StaticFunctionPtr();
		}

		// Token: 0x06005DA0 RID: 23968 RVA: 0x000845DD File Offset: 0x000827DD
		private static IntPtr StaticFunctionPtr()
		{
			if (FEffectHandleGetOrAddEffectDynamicGroupRetVal._FunctionPtr == IntPtr.Zero)
			{
				FEffectHandleGetOrAddEffectDynamicGroupRetVal._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroGameplay.EffectHandleGetOrAddEffectDynamicGroupRetVal__DelegateSignature");
			}
			return FEffectHandleGetOrAddEffectDynamicGroupRetVal._FunctionPtr;
		}

		// Token: 0x06005DA1 RID: 23969 RVA: 0x00084600 File Offset: 0x00082800
		public FEffectHandleGetOrAddEffectDynamicGroupRetVal()
		{
		}

		// Token: 0x06005DA2 RID: 23970 RVA: 0x00084608 File Offset: 0x00082808
		[NullableContext(2)]
		public FEffectHandleGetOrAddEffectDynamicGroupRetVal(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005DA3 RID: 23971 RVA: 0x00084612 File Offset: 0x00082812
		public FEffectHandleGetOrAddEffectDynamicGroupRetVal(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005DA4 RID: 23972 RVA: 0x0008461D File Offset: 0x0008281D
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Func<float, FName>) ?? ((Func<float, FName>)Delegate.CreateDelegate(typeof(Func<float, FName>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06005DA5 RID: 23973 RVA: 0x0008464F File Offset: 0x0008284F
		[NullableContext(1)]
		public void Bind(Func<float, FName> Callback)
		{
			if (FEffectHandleGetOrAddEffectDynamicGroupRetVal.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FEffectHandleGetOrAddEffectDynamicGroupRetVal.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FEffectHandleGetOrAddEffectDynamicGroupRetVal.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FEffectHandleGetOrAddEffectDynamicGroupRetVal.OnScriptCallback));
				}
				FEffectHandleGetOrAddEffectDynamicGroupRetVal.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FEffectHandleGetOrAddEffectDynamicGroupRetVal.RegisterId);
		}

		// Token: 0x06005DA6 RID: 23974 RVA: 0x0008468C File Offset: 0x0008288C
		[SkipLocalsInit]
		public unsafe FName Execute(float EffectEnableRange)
		{
			FEffectHandleGetOrAddEffectDynamicGroupRetVal.__FEffectHandleGetOrAddEffectDynamicGroupRetVal_DelegateParams* ptr = stackalloc FEffectHandleGetOrAddEffectDynamicGroupRetVal.__FEffectHandleGetOrAddEffectDynamicGroupRetVal_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FEffectHandleGetOrAddEffectDynamicGroupRetVal.__FEffectHandleGetOrAddEffectDynamicGroupRetVal_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FEffectHandleGetOrAddEffectDynamicGroupRetVal.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->EffectEnableRange = EffectEnableRange;
			base.ExecuteInternal((void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06005DA7 RID: 23975 RVA: 0x000846D0 File Offset: 0x000828D0
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Func<float, FName> func = target as Func<float, FName>;
			if (func == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			FName _Result = func(((FEffectHandleGetOrAddEffectDynamicGroupRetVal.__FEffectHandleGetOrAddEffectDynamicGroupRetVal_DelegateParams*)__Parameters)->EffectEnableRange);
			((FEffectHandleGetOrAddEffectDynamicGroupRetVal.__FEffectHandleGetOrAddEffectDynamicGroupRetVal_DelegateParams*)__Parameters)->__Result = _Result;
		}

		// Token: 0x04002703 RID: 9987
		internal static IntPtr _FunctionPtr;

		// Token: 0x04002704 RID: 9988
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameplay.EffectHandleGetOrAddEffectDynamicGroupRetVal__DelegateSignature";

		// Token: 0x04002705 RID: 9989
		private static int RegisterId;

		// Token: 0x02000AC4 RID: 2756
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		private ref struct __FEffectHandleGetOrAddEffectDynamicGroupRetVal_DelegateParams
		{
			// Token: 0x04005B35 RID: 23349
			[FieldOffset(0)]
			public float EffectEnableRange;

			// Token: 0x04005B36 RID: 23350
			[FieldOffset(4)]
			public FName __Result;
		}

		// Token: 0x02000AC5 RID: 2757
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005B37 RID: 23351
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
