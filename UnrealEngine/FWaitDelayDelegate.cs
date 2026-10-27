using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020013C1 RID: 5057
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FWaitDelayDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601288D RID: 75917 RVA: 0x001B42B2 File Offset: 0x001B24B2
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FWaitDelayDelegate.StaticFunctionPtr();
		}

		// Token: 0x0601288E RID: 75918 RVA: 0x001B42BE File Offset: 0x001B24BE
		private static IntPtr StaticFunctionPtr()
		{
			if (FWaitDelayDelegate._FunctionPtr == IntPtr.Zero)
			{
				FWaitDelayDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/GameplayAbilities.WaitDelayDelegate__DelegateSignature");
			}
			return FWaitDelayDelegate._FunctionPtr;
		}

		// Token: 0x0601288F RID: 75919 RVA: 0x001B42E1 File Offset: 0x001B24E1
		public FWaitDelayDelegate()
		{
		}

		// Token: 0x06012890 RID: 75920 RVA: 0x001B42E9 File Offset: 0x001B24E9
		[NullableContext(2)]
		public FWaitDelayDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06012891 RID: 75921 RVA: 0x001B42F3 File Offset: 0x001B24F3
		public FWaitDelayDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06012892 RID: 75922 RVA: 0x001B42FE File Offset: 0x001B24FE
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x06012893 RID: 75923 RVA: 0x001B4330 File Offset: 0x001B2530
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action Callback)
		{
			if (FWaitDelayDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FWaitDelayDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FWaitDelayDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FWaitDelayDelegate.OnScriptCallback));
				}
				FWaitDelayDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FWaitDelayDelegate.RegisterId);
		}

		// Token: 0x06012894 RID: 75924 RVA: 0x001B436A File Offset: 0x001B256A
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06012895 RID: 75925 RVA: 0x001B4373 File Offset: 0x001B2573
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x06012896 RID: 75926 RVA: 0x001B4380 File Offset: 0x001B2580
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

		// Token: 0x04009E8E RID: 40590
		internal static IntPtr _FunctionPtr;

		// Token: 0x04009E8F RID: 40591
		[Nullable(1)]
		public const string __ObjectPath = "/Script/GameplayAbilities.WaitDelayDelegate__DelegateSignature";

		// Token: 0x04009E90 RID: 40592
		private static int RegisterId;

		// Token: 0x02002E5F RID: 11871
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401691D RID: 92445
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
