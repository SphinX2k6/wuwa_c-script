using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200189A RID: 6298
	public sealed class FEffectHandleGetOrAddEffectDynamicGroupRetVal : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060172F4 RID: 94964 RVA: 0x0021D135 File Offset: 0x0021B335
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FEffectHandleGetOrAddEffectDynamicGroupRetVal.StaticFunctionPtr();
		}

		// Token: 0x060172F5 RID: 94965 RVA: 0x0021D141 File Offset: 0x0021B341
		private static IntPtr StaticFunctionPtr()
		{
			if (FEffectHandleGetOrAddEffectDynamicGroupRetVal._FunctionPtr == IntPtr.Zero)
			{
				FEffectHandleGetOrAddEffectDynamicGroupRetVal._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroGameplay.EffectHandleGetOrAddEffectDynamicGroupRetVal__DelegateSignature");
			}
			return FEffectHandleGetOrAddEffectDynamicGroupRetVal._FunctionPtr;
		}

		// Token: 0x060172F6 RID: 94966 RVA: 0x0021D164 File Offset: 0x0021B364
		public FEffectHandleGetOrAddEffectDynamicGroupRetVal()
		{
		}

		// Token: 0x060172F7 RID: 94967 RVA: 0x0021D16C File Offset: 0x0021B36C
		[NullableContext(2)]
		public FEffectHandleGetOrAddEffectDynamicGroupRetVal(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060172F8 RID: 94968 RVA: 0x0021D176 File Offset: 0x0021B376
		public FEffectHandleGetOrAddEffectDynamicGroupRetVal(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060172F9 RID: 94969 RVA: 0x0021D181 File Offset: 0x0021B381
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Func<float, FName>) ?? ((Func<float, FName>)Delegate.CreateDelegate(typeof(Func<float, FName>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060172FA RID: 94970 RVA: 0x0021D1B3 File Offset: 0x0021B3B3
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x060172FB RID: 94971 RVA: 0x0021D1F0 File Offset: 0x0021B3F0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe FName Execute(float EffectEnableRange)
		{
			FEffectHandleGetOrAddEffectDynamicGroupRetVal.__FEffectHandleGetOrAddEffectDynamicGroupRetVal_DelegateParams* ptr = stackalloc FEffectHandleGetOrAddEffectDynamicGroupRetVal.__FEffectHandleGetOrAddEffectDynamicGroupRetVal_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FEffectHandleGetOrAddEffectDynamicGroupRetVal.__FEffectHandleGetOrAddEffectDynamicGroupRetVal_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FEffectHandleGetOrAddEffectDynamicGroupRetVal.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->EffectEnableRange = EffectEnableRange;
			base.ExecuteInternal((void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x060172FC RID: 94972 RVA: 0x0021D234 File Offset: 0x0021B434
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x0400C934 RID: 51508
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400C935 RID: 51509
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameplay.EffectHandleGetOrAddEffectDynamicGroupRetVal__DelegateSignature";

		// Token: 0x0400C936 RID: 51510
		private static int RegisterId;

		// Token: 0x02002FA1 RID: 12193
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FEffectHandleGetOrAddEffectDynamicGroupRetVal_DelegateParams
		{
			// Token: 0x04016B78 RID: 93048
			[FieldOffset(0)]
			public float EffectEnableRange;

			// Token: 0x04016B79 RID: 93049
			[FieldOffset(4)]
			public FName __Result;
		}

		// Token: 0x02002FA2 RID: 12194
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016B7A RID: 93050
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
