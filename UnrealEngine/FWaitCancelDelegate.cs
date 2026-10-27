using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020013BF RID: 5055
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FWaitCancelDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06012879 RID: 75897 RVA: 0x001B4094 File Offset: 0x001B2294
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FWaitCancelDelegate.StaticFunctionPtr();
		}

		// Token: 0x0601287A RID: 75898 RVA: 0x001B40A0 File Offset: 0x001B22A0
		private static IntPtr StaticFunctionPtr()
		{
			if (FWaitCancelDelegate._FunctionPtr == IntPtr.Zero)
			{
				FWaitCancelDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/GameplayAbilities.WaitCancelDelegate__DelegateSignature");
			}
			return FWaitCancelDelegate._FunctionPtr;
		}

		// Token: 0x0601287B RID: 75899 RVA: 0x001B40C3 File Offset: 0x001B22C3
		public FWaitCancelDelegate()
		{
		}

		// Token: 0x0601287C RID: 75900 RVA: 0x001B40CB File Offset: 0x001B22CB
		[NullableContext(2)]
		public FWaitCancelDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601287D RID: 75901 RVA: 0x001B40D5 File Offset: 0x001B22D5
		public FWaitCancelDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601287E RID: 75902 RVA: 0x001B40E0 File Offset: 0x001B22E0
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601287F RID: 75903 RVA: 0x001B4112 File Offset: 0x001B2312
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action Callback)
		{
			if (FWaitCancelDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FWaitCancelDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FWaitCancelDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FWaitCancelDelegate.OnScriptCallback));
				}
				FWaitCancelDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FWaitCancelDelegate.RegisterId);
		}

		// Token: 0x06012880 RID: 75904 RVA: 0x001B414C File Offset: 0x001B234C
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06012881 RID: 75905 RVA: 0x001B4155 File Offset: 0x001B2355
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x06012882 RID: 75906 RVA: 0x001B4160 File Offset: 0x001B2360
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

		// Token: 0x04009E88 RID: 40584
		internal static IntPtr _FunctionPtr;

		// Token: 0x04009E89 RID: 40585
		[Nullable(1)]
		public const string __ObjectPath = "/Script/GameplayAbilities.WaitCancelDelegate__DelegateSignature";

		// Token: 0x04009E8A RID: 40586
		private static int RegisterId;

		// Token: 0x02002E5D RID: 11869
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401691B RID: 92443
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
