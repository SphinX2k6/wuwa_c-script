using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;

namespace UnrealEngine
{
	// Token: 0x02001A3D RID: 6717
	public sealed class FOnDataTableChanged : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06018DD6 RID: 101846 RVA: 0x0024BC08 File Offset: 0x00249E08
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnDataTableChanged.StaticFunctionPtr();
		}

		// Token: 0x06018DD7 RID: 101847 RVA: 0x0024BC14 File Offset: 0x00249E14
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnDataTableChanged._FunctionPtr == IntPtr.Zero)
			{
				FOnDataTableChanged._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroPuertsWrapper.OnDataTableChanged__DelegateSignature");
			}
			return FOnDataTableChanged._FunctionPtr;
		}

		// Token: 0x06018DD8 RID: 101848 RVA: 0x0024BC37 File Offset: 0x00249E37
		public FOnDataTableChanged()
		{
		}

		// Token: 0x06018DD9 RID: 101849 RVA: 0x0024BC3F File Offset: 0x00249E3F
		[NullableContext(2)]
		public FOnDataTableChanged(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06018DDA RID: 101850 RVA: 0x0024BC49 File Offset: 0x00249E49
		public FOnDataTableChanged(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06018DDB RID: 101851 RVA: 0x0024BC54 File Offset: 0x00249E54
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x06018DDC RID: 101852 RVA: 0x0024BC86 File Offset: 0x00249E86
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action Callback)
		{
			if (FOnDataTableChanged.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnDataTableChanged.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnDataTableChanged.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnDataTableChanged.OnScriptCallback));
				}
				FOnDataTableChanged.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FOnDataTableChanged.RegisterId);
		}

		// Token: 0x06018DDD RID: 101853 RVA: 0x0024BCC0 File Offset: 0x00249EC0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Execute()
		{
			base.ExecuteInternal(null);
		}

		// Token: 0x06018DDE RID: 101854 RVA: 0x0024BCCC File Offset: 0x00249ECC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action action = target as Action;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action();
		}

		// Token: 0x0400D6EA RID: 55018
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400D6EB RID: 55019
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroPuertsWrapper.OnDataTableChanged__DelegateSignature";

		// Token: 0x0400D6EC RID: 55020
		private static int RegisterId;

		// Token: 0x020030FF RID: 12543
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016E85 RID: 93829
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
