using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020013A8 RID: 5032
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FMontageWaitSimpleDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06012782 RID: 75650 RVA: 0x001B2672 File Offset: 0x001B0872
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FMontageWaitSimpleDelegate.StaticFunctionPtr();
		}

		// Token: 0x06012783 RID: 75651 RVA: 0x001B267E File Offset: 0x001B087E
		private static IntPtr StaticFunctionPtr()
		{
			if (FMontageWaitSimpleDelegate._FunctionPtr == IntPtr.Zero)
			{
				FMontageWaitSimpleDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/GameplayAbilities.MontageWaitSimpleDelegate__DelegateSignature");
			}
			return FMontageWaitSimpleDelegate._FunctionPtr;
		}

		// Token: 0x06012784 RID: 75652 RVA: 0x001B26A1 File Offset: 0x001B08A1
		public FMontageWaitSimpleDelegate()
		{
		}

		// Token: 0x06012785 RID: 75653 RVA: 0x001B26A9 File Offset: 0x001B08A9
		[NullableContext(2)]
		public FMontageWaitSimpleDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06012786 RID: 75654 RVA: 0x001B26B3 File Offset: 0x001B08B3
		public FMontageWaitSimpleDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06012787 RID: 75655 RVA: 0x001B26BE File Offset: 0x001B08BE
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x06012788 RID: 75656 RVA: 0x001B26F0 File Offset: 0x001B08F0
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action Callback)
		{
			if (FMontageWaitSimpleDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FMontageWaitSimpleDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FMontageWaitSimpleDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FMontageWaitSimpleDelegate.OnScriptCallback));
				}
				FMontageWaitSimpleDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FMontageWaitSimpleDelegate.RegisterId);
		}

		// Token: 0x06012789 RID: 75657 RVA: 0x001B272A File Offset: 0x001B092A
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601278A RID: 75658 RVA: 0x001B2733 File Offset: 0x001B0933
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x0601278B RID: 75659 RVA: 0x001B2740 File Offset: 0x001B0940
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

		// Token: 0x04009E2D RID: 40493
		internal static IntPtr _FunctionPtr;

		// Token: 0x04009E2E RID: 40494
		[Nullable(1)]
		public const string __ObjectPath = "/Script/GameplayAbilities.MontageWaitSimpleDelegate__DelegateSignature";

		// Token: 0x04009E2F RID: 40495
		private static int RegisterId;

		// Token: 0x02002E48 RID: 11848
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016902 RID: 92418
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
