using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001898 RID: 6296
	public sealed class FEffectHandleGetEntityModelConfigIdRetVal : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060172E2 RID: 94946 RVA: 0x0021CE84 File Offset: 0x0021B084
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FEffectHandleGetEntityModelConfigIdRetVal.StaticFunctionPtr();
		}

		// Token: 0x060172E3 RID: 94947 RVA: 0x0021CE90 File Offset: 0x0021B090
		private static IntPtr StaticFunctionPtr()
		{
			if (FEffectHandleGetEntityModelConfigIdRetVal._FunctionPtr == IntPtr.Zero)
			{
				FEffectHandleGetEntityModelConfigIdRetVal._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroGameplay.EffectHandleGetEntityModelConfigIdRetVal__DelegateSignature");
			}
			return FEffectHandleGetEntityModelConfigIdRetVal._FunctionPtr;
		}

		// Token: 0x060172E4 RID: 94948 RVA: 0x0021CEB3 File Offset: 0x0021B0B3
		public FEffectHandleGetEntityModelConfigIdRetVal()
		{
		}

		// Token: 0x060172E5 RID: 94949 RVA: 0x0021CEBB File Offset: 0x0021B0BB
		[NullableContext(2)]
		public FEffectHandleGetEntityModelConfigIdRetVal(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060172E6 RID: 94950 RVA: 0x0021CEC5 File Offset: 0x0021B0C5
		public FEffectHandleGetEntityModelConfigIdRetVal(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060172E7 RID: 94951 RVA: 0x0021CED0 File Offset: 0x0021B0D0
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Func<int, int>) ?? ((Func<int, int>)Delegate.CreateDelegate(typeof(Func<int, int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060172E8 RID: 94952 RVA: 0x0021CF02 File Offset: 0x0021B102
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Func<int, int> Callback)
		{
			if (FEffectHandleGetEntityModelConfigIdRetVal.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FEffectHandleGetEntityModelConfigIdRetVal.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FEffectHandleGetEntityModelConfigIdRetVal.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FEffectHandleGetEntityModelConfigIdRetVal.OnScriptCallback));
				}
				FEffectHandleGetEntityModelConfigIdRetVal.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FEffectHandleGetEntityModelConfigIdRetVal.RegisterId);
		}

		// Token: 0x060172E9 RID: 94953 RVA: 0x0021CF3C File Offset: 0x0021B13C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe int Execute(int EntityId)
		{
			FEffectHandleGetEntityModelConfigIdRetVal.__FEffectHandleGetEntityModelConfigIdRetVal_DelegateParams* ptr = stackalloc FEffectHandleGetEntityModelConfigIdRetVal.__FEffectHandleGetEntityModelConfigIdRetVal_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FEffectHandleGetEntityModelConfigIdRetVal.__FEffectHandleGetEntityModelConfigIdRetVal_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FEffectHandleGetEntityModelConfigIdRetVal.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->EntityId = EntityId;
			base.ExecuteInternal((void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x060172EA RID: 94954 RVA: 0x0021CF80 File Offset: 0x0021B180
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Func<int, int> func = target as Func<int, int>;
			if (func == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			int _Result = func(((FEffectHandleGetEntityModelConfigIdRetVal.__FEffectHandleGetEntityModelConfigIdRetVal_DelegateParams*)__Parameters)->EntityId);
			((FEffectHandleGetEntityModelConfigIdRetVal.__FEffectHandleGetEntityModelConfigIdRetVal_DelegateParams*)__Parameters)->__Result = _Result;
		}

		// Token: 0x0400C92E RID: 51502
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400C92F RID: 51503
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameplay.EffectHandleGetEntityModelConfigIdRetVal__DelegateSignature";

		// Token: 0x0400C930 RID: 51504
		private static int RegisterId;

		// Token: 0x02002F9D RID: 12189
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __FEffectHandleGetEntityModelConfigIdRetVal_DelegateParams
		{
			// Token: 0x04016B72 RID: 93042
			[FieldOffset(0)]
			public int EntityId;

			// Token: 0x04016B73 RID: 93043
			[FieldOffset(4)]
			public int __Result;
		}

		// Token: 0x02002F9E RID: 12190
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016B74 RID: 93044
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
