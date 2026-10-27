using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020013AC RID: 5036
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FNetworkSyncDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060127AA RID: 75690 RVA: 0x001B2AA4 File Offset: 0x001B0CA4
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FNetworkSyncDelegate.StaticFunctionPtr();
		}

		// Token: 0x060127AB RID: 75691 RVA: 0x001B2AB0 File Offset: 0x001B0CB0
		private static IntPtr StaticFunctionPtr()
		{
			if (FNetworkSyncDelegate._FunctionPtr == IntPtr.Zero)
			{
				FNetworkSyncDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/GameplayAbilities.NetworkSyncDelegate__DelegateSignature");
			}
			return FNetworkSyncDelegate._FunctionPtr;
		}

		// Token: 0x060127AC RID: 75692 RVA: 0x001B2AD3 File Offset: 0x001B0CD3
		public FNetworkSyncDelegate()
		{
		}

		// Token: 0x060127AD RID: 75693 RVA: 0x001B2ADB File Offset: 0x001B0CDB
		[NullableContext(2)]
		public FNetworkSyncDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060127AE RID: 75694 RVA: 0x001B2AE5 File Offset: 0x001B0CE5
		public FNetworkSyncDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060127AF RID: 75695 RVA: 0x001B2AF0 File Offset: 0x001B0CF0
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x060127B0 RID: 75696 RVA: 0x001B2B22 File Offset: 0x001B0D22
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action Callback)
		{
			if (FNetworkSyncDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FNetworkSyncDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FNetworkSyncDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FNetworkSyncDelegate.OnScriptCallback));
				}
				FNetworkSyncDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FNetworkSyncDelegate.RegisterId);
		}

		// Token: 0x060127B1 RID: 75697 RVA: 0x001B2B5C File Offset: 0x001B0D5C
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x060127B2 RID: 75698 RVA: 0x001B2B65 File Offset: 0x001B0D65
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x060127B3 RID: 75699 RVA: 0x001B2B70 File Offset: 0x001B0D70
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

		// Token: 0x04009E3A RID: 40506
		internal static IntPtr _FunctionPtr;

		// Token: 0x04009E3B RID: 40507
		[Nullable(1)]
		public const string __ObjectPath = "/Script/GameplayAbilities.NetworkSyncDelegate__DelegateSignature";

		// Token: 0x04009E3C RID: 40508
		private static int RegisterId;

		// Token: 0x02002E4C RID: 11852
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016906 RID: 92422
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
