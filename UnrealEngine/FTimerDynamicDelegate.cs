using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;

namespace UnrealEngine
{
	// Token: 0x020011F1 RID: 4593
	public sealed class FTimerDynamicDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06010EF8 RID: 69368 RVA: 0x0018DCDB File Offset: 0x0018BEDB
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FTimerDynamicDelegate.StaticFunctionPtr();
		}

		// Token: 0x06010EF9 RID: 69369 RVA: 0x0018DCE7 File Offset: 0x0018BEE7
		private static IntPtr StaticFunctionPtr()
		{
			if (FTimerDynamicDelegate._FunctionPtr == IntPtr.Zero)
			{
				FTimerDynamicDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.TimerDynamicDelegate__DelegateSignature");
			}
			return FTimerDynamicDelegate._FunctionPtr;
		}

		// Token: 0x06010EFA RID: 69370 RVA: 0x0018DD0A File Offset: 0x0018BF0A
		public FTimerDynamicDelegate()
		{
		}

		// Token: 0x06010EFB RID: 69371 RVA: 0x0018DD12 File Offset: 0x0018BF12
		[NullableContext(2)]
		public FTimerDynamicDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06010EFC RID: 69372 RVA: 0x0018DD1C File Offset: 0x0018BF1C
		public FTimerDynamicDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06010EFD RID: 69373 RVA: 0x0018DD27 File Offset: 0x0018BF27
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x06010EFE RID: 69374 RVA: 0x0018DD59 File Offset: 0x0018BF59
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action Callback)
		{
			if (FTimerDynamicDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FTimerDynamicDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FTimerDynamicDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FTimerDynamicDelegate.OnScriptCallback));
				}
				FTimerDynamicDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FTimerDynamicDelegate.RegisterId);
		}

		// Token: 0x06010EFF RID: 69375 RVA: 0x0018DD93 File Offset: 0x0018BF93
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Execute()
		{
			base.ExecuteInternal(null);
		}

		// Token: 0x06010F00 RID: 69376 RVA: 0x0018DDA0 File Offset: 0x0018BFA0
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

		// Token: 0x04009129 RID: 37161
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400912A RID: 37162
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.TimerDynamicDelegate__DelegateSignature";

		// Token: 0x0400912B RID: 37163
		private static int RegisterId;

		// Token: 0x02002DFB RID: 11771
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401685C RID: 92252
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
