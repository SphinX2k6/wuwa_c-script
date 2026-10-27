using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020013C0 RID: 5056
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FWaitConfirmCancelDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06012883 RID: 75907 RVA: 0x001B41A2 File Offset: 0x001B23A2
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FWaitConfirmCancelDelegate.StaticFunctionPtr();
		}

		// Token: 0x06012884 RID: 75908 RVA: 0x001B41AE File Offset: 0x001B23AE
		private static IntPtr StaticFunctionPtr()
		{
			if (FWaitConfirmCancelDelegate._FunctionPtr == IntPtr.Zero)
			{
				FWaitConfirmCancelDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/GameplayAbilities.WaitConfirmCancelDelegate__DelegateSignature");
			}
			return FWaitConfirmCancelDelegate._FunctionPtr;
		}

		// Token: 0x06012885 RID: 75909 RVA: 0x001B41D1 File Offset: 0x001B23D1
		public FWaitConfirmCancelDelegate()
		{
		}

		// Token: 0x06012886 RID: 75910 RVA: 0x001B41D9 File Offset: 0x001B23D9
		[NullableContext(2)]
		public FWaitConfirmCancelDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06012887 RID: 75911 RVA: 0x001B41E3 File Offset: 0x001B23E3
		public FWaitConfirmCancelDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06012888 RID: 75912 RVA: 0x001B41EE File Offset: 0x001B23EE
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x06012889 RID: 75913 RVA: 0x001B4220 File Offset: 0x001B2420
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action Callback)
		{
			if (FWaitConfirmCancelDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FWaitConfirmCancelDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FWaitConfirmCancelDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FWaitConfirmCancelDelegate.OnScriptCallback));
				}
				FWaitConfirmCancelDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FWaitConfirmCancelDelegate.RegisterId);
		}

		// Token: 0x0601288A RID: 75914 RVA: 0x001B425A File Offset: 0x001B245A
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601288B RID: 75915 RVA: 0x001B4263 File Offset: 0x001B2463
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x0601288C RID: 75916 RVA: 0x001B4270 File Offset: 0x001B2470
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

		// Token: 0x04009E8B RID: 40587
		internal static IntPtr _FunctionPtr;

		// Token: 0x04009E8C RID: 40588
		[Nullable(1)]
		public const string __ObjectPath = "/Script/GameplayAbilities.WaitConfirmCancelDelegate__DelegateSignature";

		// Token: 0x04009E8D RID: 40589
		private static int RegisterId;

		// Token: 0x02002E5E RID: 11870
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401691C RID: 92444
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
