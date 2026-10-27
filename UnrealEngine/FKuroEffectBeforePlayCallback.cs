using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020018C6 RID: 6342
	public sealed class FKuroEffectBeforePlayCallback : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060176F0 RID: 95984 RVA: 0x0022456A File Offset: 0x0022276A
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FKuroEffectBeforePlayCallback.StaticFunctionPtr();
		}

		// Token: 0x060176F1 RID: 95985 RVA: 0x00224576 File Offset: 0x00222776
		private static IntPtr StaticFunctionPtr()
		{
			if (FKuroEffectBeforePlayCallback._FunctionPtr == IntPtr.Zero)
			{
				FKuroEffectBeforePlayCallback._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroGameplay.KuroEffectBeforePlayCallback__DelegateSignature");
			}
			return FKuroEffectBeforePlayCallback._FunctionPtr;
		}

		// Token: 0x060176F2 RID: 95986 RVA: 0x00224599 File Offset: 0x00222799
		public FKuroEffectBeforePlayCallback()
		{
		}

		// Token: 0x060176F3 RID: 95987 RVA: 0x002245A1 File Offset: 0x002227A1
		[NullableContext(2)]
		public FKuroEffectBeforePlayCallback(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060176F4 RID: 95988 RVA: 0x002245AB File Offset: 0x002227AB
		public FKuroEffectBeforePlayCallback(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060176F5 RID: 95989 RVA: 0x002245B6 File Offset: 0x002227B6
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<int>) ?? ((Action<int>)Delegate.CreateDelegate(typeof(Action<int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060176F6 RID: 95990 RVA: 0x002245E8 File Offset: 0x002227E8
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action<int> Callback)
		{
			if (FKuroEffectBeforePlayCallback.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FKuroEffectBeforePlayCallback.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FKuroEffectBeforePlayCallback.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FKuroEffectBeforePlayCallback.OnScriptCallback));
				}
				FKuroEffectBeforePlayCallback.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FKuroEffectBeforePlayCallback.RegisterId);
		}

		// Token: 0x060176F7 RID: 95991 RVA: 0x00224624 File Offset: 0x00222824
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(int Handle)
		{
			FKuroEffectBeforePlayCallback.__FKuroEffectBeforePlayCallback_DelegateParams* ptr = stackalloc FKuroEffectBeforePlayCallback.__FKuroEffectBeforePlayCallback_DelegateParams[(UIntPtr)19] + 15L / (long)sizeof(FKuroEffectBeforePlayCallback.__FKuroEffectBeforePlayCallback_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FKuroEffectBeforePlayCallback.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Handle = Handle;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x060176F8 RID: 95992 RVA: 0x00224664 File Offset: 0x00222864
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int> action = target as Action<int>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FKuroEffectBeforePlayCallback.__FKuroEffectBeforePlayCallback_DelegateParams*)__Parameters)->Handle);
		}

		// Token: 0x0400CBE9 RID: 52201
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400CBEA RID: 52202
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameplay.KuroEffectBeforePlayCallback__DelegateSignature";

		// Token: 0x0400CBEB RID: 52203
		private static int RegisterId;

		// Token: 0x02002FB2 RID: 12210
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __FKuroEffectBeforePlayCallback_DelegateParams
		{
			// Token: 0x04016B95 RID: 93077
			[FieldOffset(0)]
			public int Handle;
		}

		// Token: 0x02002FB3 RID: 12211
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016B96 RID: 93078
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
