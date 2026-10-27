using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;

namespace UnrealEngine
{
	// Token: 0x02002241 RID: 8769
	public sealed class FLTweenerDynamicDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06021621 RID: 136737 RVA: 0x00313092 File Offset: 0x00311292
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLTweenerDynamicDelegate.StaticFunctionPtr();
		}

		// Token: 0x06021622 RID: 136738 RVA: 0x0031309E File Offset: 0x0031129E
		private static IntPtr StaticFunctionPtr()
		{
			if (FLTweenerDynamicDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLTweenerDynamicDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LTween.LTweenerDynamicDelegate__DelegateSignature");
			}
			return FLTweenerDynamicDelegate._FunctionPtr;
		}

		// Token: 0x06021623 RID: 136739 RVA: 0x003130C1 File Offset: 0x003112C1
		public FLTweenerDynamicDelegate()
		{
		}

		// Token: 0x06021624 RID: 136740 RVA: 0x003130C9 File Offset: 0x003112C9
		[NullableContext(2)]
		public FLTweenerDynamicDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021625 RID: 136741 RVA: 0x003130D3 File Offset: 0x003112D3
		public FLTweenerDynamicDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021626 RID: 136742 RVA: 0x003130DE File Offset: 0x003112DE
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x06021627 RID: 136743 RVA: 0x00313110 File Offset: 0x00311310
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action Callback)
		{
			if (FLTweenerDynamicDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLTweenerDynamicDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLTweenerDynamicDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLTweenerDynamicDelegate.OnScriptCallback));
				}
				FLTweenerDynamicDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLTweenerDynamicDelegate.RegisterId);
		}

		// Token: 0x06021628 RID: 136744 RVA: 0x0031314A File Offset: 0x0031134A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Execute()
		{
			base.ExecuteInternal(null);
		}

		// Token: 0x06021629 RID: 136745 RVA: 0x00313158 File Offset: 0x00311358
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

		// Token: 0x04011CA8 RID: 72872
		internal static IntPtr _FunctionPtr;

		// Token: 0x04011CA9 RID: 72873
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LTween.LTweenerDynamicDelegate__DelegateSignature";

		// Token: 0x04011CAA RID: 72874
		private static int RegisterId;

		// Token: 0x0200350E RID: 13582
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017540 RID: 95552
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
