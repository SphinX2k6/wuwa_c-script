using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020029FB RID: 10747
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FWidgetAnimationResult : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06027E25 RID: 163365 RVA: 0x003CC2FE File Offset: 0x003CA4FE
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FWidgetAnimationResult.StaticFunctionPtr();
		}

		// Token: 0x06027E26 RID: 163366 RVA: 0x003CC30A File Offset: 0x003CA50A
		private static IntPtr StaticFunctionPtr()
		{
			if (FWidgetAnimationResult._FunctionPtr == IntPtr.Zero)
			{
				FWidgetAnimationResult._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/UMG.WidgetAnimationResult__DelegateSignature");
			}
			return FWidgetAnimationResult._FunctionPtr;
		}

		// Token: 0x06027E27 RID: 163367 RVA: 0x003CC32D File Offset: 0x003CA52D
		public FWidgetAnimationResult()
		{
		}

		// Token: 0x06027E28 RID: 163368 RVA: 0x003CC335 File Offset: 0x003CA535
		[NullableContext(2)]
		public FWidgetAnimationResult(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06027E29 RID: 163369 RVA: 0x003CC33F File Offset: 0x003CA53F
		public FWidgetAnimationResult(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06027E2A RID: 163370 RVA: 0x003CC34A File Offset: 0x003CA54A
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x06027E2B RID: 163371 RVA: 0x003CC37C File Offset: 0x003CA57C
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action Callback)
		{
			if (FWidgetAnimationResult.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FWidgetAnimationResult.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FWidgetAnimationResult.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FWidgetAnimationResult.OnScriptCallback));
				}
				FWidgetAnimationResult.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FWidgetAnimationResult.RegisterId);
		}

		// Token: 0x06027E2C RID: 163372 RVA: 0x003CC3B6 File Offset: 0x003CA5B6
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06027E2D RID: 163373 RVA: 0x003CC3BF File Offset: 0x003CA5BF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x06027E2E RID: 163374 RVA: 0x003CC3CC File Offset: 0x003CA5CC
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

		// Token: 0x04015CD1 RID: 89297
		internal static IntPtr _FunctionPtr;

		// Token: 0x04015CD2 RID: 89298
		[Nullable(1)]
		public const string __ObjectPath = "/Script/UMG.WidgetAnimationResult__DelegateSignature";

		// Token: 0x04015CD3 RID: 89299
		private static int RegisterId;

		// Token: 0x02003C01 RID: 15361
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017E30 RID: 97840
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
