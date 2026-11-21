using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020003D3 RID: 979
	public sealed class FEffectSystemCheckIsNetPlayerRetVal : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060060D3 RID: 24787 RVA: 0x0008A36C File Offset: 0x0008856C
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FEffectSystemCheckIsNetPlayerRetVal.StaticFunctionPtr();
		}

		// Token: 0x060060D4 RID: 24788 RVA: 0x0008A378 File Offset: 0x00088578
		private static IntPtr StaticFunctionPtr()
		{
			if (FEffectSystemCheckIsNetPlayerRetVal._FunctionPtr == IntPtr.Zero)
			{
				FEffectSystemCheckIsNetPlayerRetVal._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroGameplay.EffectSystemCheckIsNetPlayerRetVal__DelegateSignature");
			}
			return FEffectSystemCheckIsNetPlayerRetVal._FunctionPtr;
		}

		// Token: 0x060060D5 RID: 24789 RVA: 0x0008A39B File Offset: 0x0008859B
		public FEffectSystemCheckIsNetPlayerRetVal()
		{
		}

		// Token: 0x060060D6 RID: 24790 RVA: 0x0008A3A3 File Offset: 0x000885A3
		[NullableContext(2)]
		public FEffectSystemCheckIsNetPlayerRetVal(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060060D7 RID: 24791 RVA: 0x0008A3AD File Offset: 0x000885AD
		public FEffectSystemCheckIsNetPlayerRetVal(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060060D8 RID: 24792 RVA: 0x0008A3B8 File Offset: 0x000885B8
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Func<int, bool>) ?? ((Func<int, bool>)Delegate.CreateDelegate(typeof(Func<int, bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060060D9 RID: 24793 RVA: 0x0008A3EA File Offset: 0x000885EA
		[NullableContext(1)]
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

		// Token: 0x060060DA RID: 24794 RVA: 0x0008A424 File Offset: 0x00088624
		[SkipLocalsInit]
		public unsafe bool Execute(int EntityId)
		{
			FEffectSystemCheckIsNetPlayerRetVal.__FEffectSystemCheckIsNetPlayerRetVal_DelegateParams* ptr = stackalloc FEffectSystemCheckIsNetPlayerRetVal.__FEffectSystemCheckIsNetPlayerRetVal_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FEffectSystemCheckIsNetPlayerRetVal.__FEffectSystemCheckIsNetPlayerRetVal_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FEffectSystemCheckIsNetPlayerRetVal.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->EntityId = EntityId;
			base.ExecuteInternal((void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x060060DB RID: 24795 RVA: 0x0008A468 File Offset: 0x00088668
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x04002938 RID: 10552
		internal static IntPtr _FunctionPtr;

		// Token: 0x04002939 RID: 10553
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameplay.EffectSystemCheckIsNetPlayerRetVal__DelegateSignature";

		// Token: 0x0400293A RID: 10554
		private static int RegisterId;

		// Token: 0x02000ACA RID: 2762
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		private ref struct __FEffectSystemCheckIsNetPlayerRetVal_DelegateParams
		{
			// Token: 0x04005B44 RID: 23364
			[FieldOffset(0)]
			public int EntityId;

			// Token: 0x04005B45 RID: 23365
			[FieldOffset(4)]
			public bool __Result;
		}

		// Token: 0x02000ACB RID: 2763
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005B46 RID: 23366
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
