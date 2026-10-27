using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;

namespace UnrealEngine
{
	// Token: 0x020029F9 RID: 10745
	public sealed class FWidgetAnimationDynamicEvent : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06027E13 RID: 163347 RVA: 0x003CBF92 File Offset: 0x003CA192
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FWidgetAnimationDynamicEvent.StaticFunctionPtr();
		}

		// Token: 0x06027E14 RID: 163348 RVA: 0x003CBF9E File Offset: 0x003CA19E
		private static IntPtr StaticFunctionPtr()
		{
			if (FWidgetAnimationDynamicEvent._FunctionPtr == IntPtr.Zero)
			{
				FWidgetAnimationDynamicEvent._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/UMG.WidgetAnimationDynamicEvent__DelegateSignature");
			}
			return FWidgetAnimationDynamicEvent._FunctionPtr;
		}

		// Token: 0x06027E15 RID: 163349 RVA: 0x003CBFC1 File Offset: 0x003CA1C1
		public FWidgetAnimationDynamicEvent()
		{
		}

		// Token: 0x06027E16 RID: 163350 RVA: 0x003CBFC9 File Offset: 0x003CA1C9
		[NullableContext(2)]
		public FWidgetAnimationDynamicEvent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06027E17 RID: 163351 RVA: 0x003CBFD3 File Offset: 0x003CA1D3
		public FWidgetAnimationDynamicEvent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06027E18 RID: 163352 RVA: 0x003CBFDE File Offset: 0x003CA1DE
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x06027E19 RID: 163353 RVA: 0x003CC010 File Offset: 0x003CA210
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action Callback)
		{
			if (FWidgetAnimationDynamicEvent.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FWidgetAnimationDynamicEvent.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FWidgetAnimationDynamicEvent.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FWidgetAnimationDynamicEvent.OnScriptCallback));
				}
				FWidgetAnimationDynamicEvent.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FWidgetAnimationDynamicEvent.RegisterId);
		}

		// Token: 0x06027E1A RID: 163354 RVA: 0x003CC04A File Offset: 0x003CA24A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Execute()
		{
			base.ExecuteInternal(null);
		}

		// Token: 0x06027E1B RID: 163355 RVA: 0x003CC058 File Offset: 0x003CA258
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

		// Token: 0x04015CC7 RID: 89287
		internal static IntPtr _FunctionPtr;

		// Token: 0x04015CC8 RID: 89288
		[Nullable(1)]
		public const string __ObjectPath = "/Script/UMG.WidgetAnimationDynamicEvent__DelegateSignature";

		// Token: 0x04015CC9 RID: 89289
		private static int RegisterId;

		// Token: 0x02003BFE RID: 15358
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017E1E RID: 97822
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
