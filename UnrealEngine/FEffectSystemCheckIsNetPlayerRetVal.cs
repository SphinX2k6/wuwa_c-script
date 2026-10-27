using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020018B1 RID: 6321
	public sealed class FEffectSystemCheckIsNetPlayerRetVal : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06017640 RID: 95808 RVA: 0x0022318C File Offset: 0x0022138C
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FEffectSystemCheckIsNetPlayerRetVal.StaticFunctionPtr();
		}

		// Token: 0x06017641 RID: 95809 RVA: 0x00223198 File Offset: 0x00221398
		private static IntPtr StaticFunctionPtr()
		{
			if (FEffectSystemCheckIsNetPlayerRetVal._FunctionPtr == IntPtr.Zero)
			{
				FEffectSystemCheckIsNetPlayerRetVal._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroGameplay.EffectSystemCheckIsNetPlayerRetVal__DelegateSignature");
			}
			return FEffectSystemCheckIsNetPlayerRetVal._FunctionPtr;
		}

		// Token: 0x06017642 RID: 95810 RVA: 0x002231BB File Offset: 0x002213BB
		public FEffectSystemCheckIsNetPlayerRetVal()
		{
		}

		// Token: 0x06017643 RID: 95811 RVA: 0x002231C3 File Offset: 0x002213C3
		[NullableContext(2)]
		public FEffectSystemCheckIsNetPlayerRetVal(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06017644 RID: 95812 RVA: 0x002231CD File Offset: 0x002213CD
		public FEffectSystemCheckIsNetPlayerRetVal(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06017645 RID: 95813 RVA: 0x002231D8 File Offset: 0x002213D8
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Func<int, bool>) ?? ((Func<int, bool>)Delegate.CreateDelegate(typeof(Func<int, bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06017646 RID: 95814 RVA: 0x0022320A File Offset: 0x0022140A
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Func<int, bool> Callback)
		{
			if (FEffectSystemCheckIsNetPlayerRetVal.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FEffectSystemCheckIsNetPlayerRetVal.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FEffectSystemCheckIsNetPlayerRetVal.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FEffectSystemCheckIsNetPlayerRetVal.OnScriptCallback));
				}
				FEffectSystemCheckIsNetPlayerRetVal.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FEffectSystemCheckIsNetPlayerRetVal.RegisterId);
		}

		// Token: 0x06017647 RID: 95815 RVA: 0x00223244 File Offset: 0x00221444
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool Execute(int EntityId)
		{
			FEffectSystemCheckIsNetPlayerRetVal.__FEffectSystemCheckIsNetPlayerRetVal_DelegateParams* ptr = stackalloc FEffectSystemCheckIsNetPlayerRetVal.__FEffectSystemCheckIsNetPlayerRetVal_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FEffectSystemCheckIsNetPlayerRetVal.__FEffectSystemCheckIsNetPlayerRetVal_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FEffectSystemCheckIsNetPlayerRetVal.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->EntityId = EntityId;
			base.ExecuteInternal((void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06017648 RID: 95816 RVA: 0x00223288 File Offset: 0x00221488
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Func<int, bool> func = target as Func<int, bool>;
			if (func == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			bool _Result = func(((FEffectSystemCheckIsNetPlayerRetVal.__FEffectSystemCheckIsNetPlayerRetVal_DelegateParams*)__Parameters)->EntityId);
			((FEffectSystemCheckIsNetPlayerRetVal.__FEffectSystemCheckIsNetPlayerRetVal_DelegateParams*)__Parameters)->__Result = _Result;
		}

		// Token: 0x0400CB79 RID: 52089
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400CB7A RID: 52090
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameplay.EffectSystemCheckIsNetPlayerRetVal__DelegateSignature";

		// Token: 0x0400CB7B RID: 52091
		private static int RegisterId;

		// Token: 0x02002FA7 RID: 12199
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __FEffectSystemCheckIsNetPlayerRetVal_DelegateParams
		{
			// Token: 0x04016B87 RID: 93063
			[FieldOffset(0)]
			public int EntityId;

			// Token: 0x04016B88 RID: 93064
			[FieldOffset(4)]
			public bool __Result;
		}

		// Token: 0x02002FA8 RID: 12200
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016B89 RID: 93065
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
