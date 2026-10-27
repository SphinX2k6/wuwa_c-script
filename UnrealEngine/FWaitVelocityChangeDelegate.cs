using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020013C7 RID: 5063
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FWaitVelocityChangeDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060128C9 RID: 75977 RVA: 0x001B4B34 File Offset: 0x001B2D34
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FWaitVelocityChangeDelegate.StaticFunctionPtr();
		}

		// Token: 0x060128CA RID: 75978 RVA: 0x001B4B40 File Offset: 0x001B2D40
		private static IntPtr StaticFunctionPtr()
		{
			if (FWaitVelocityChangeDelegate._FunctionPtr == IntPtr.Zero)
			{
				FWaitVelocityChangeDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/GameplayAbilities.WaitVelocityChangeDelegate__DelegateSignature");
			}
			return FWaitVelocityChangeDelegate._FunctionPtr;
		}

		// Token: 0x060128CB RID: 75979 RVA: 0x001B4B63 File Offset: 0x001B2D63
		public FWaitVelocityChangeDelegate()
		{
		}

		// Token: 0x060128CC RID: 75980 RVA: 0x001B4B6B File Offset: 0x001B2D6B
		[NullableContext(2)]
		public FWaitVelocityChangeDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060128CD RID: 75981 RVA: 0x001B4B75 File Offset: 0x001B2D75
		public FWaitVelocityChangeDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060128CE RID: 75982 RVA: 0x001B4B80 File Offset: 0x001B2D80
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x060128CF RID: 75983 RVA: 0x001B4BB2 File Offset: 0x001B2DB2
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action Callback)
		{
			if (FWaitVelocityChangeDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FWaitVelocityChangeDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FWaitVelocityChangeDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FWaitVelocityChangeDelegate.OnScriptCallback));
				}
				FWaitVelocityChangeDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FWaitVelocityChangeDelegate.RegisterId);
		}

		// Token: 0x060128D0 RID: 75984 RVA: 0x001B4BEC File Offset: 0x001B2DEC
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x060128D1 RID: 75985 RVA: 0x001B4BF5 File Offset: 0x001B2DF5
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x060128D2 RID: 75986 RVA: 0x001B4C00 File Offset: 0x001B2E00
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

		// Token: 0x04009EA0 RID: 40608
		internal static IntPtr _FunctionPtr;

		// Token: 0x04009EA1 RID: 40609
		[Nullable(1)]
		public const string __ObjectPath = "/Script/GameplayAbilities.WaitVelocityChangeDelegate__DelegateSignature";

		// Token: 0x04009EA2 RID: 40610
		private static int RegisterId;

		// Token: 0x02002E6A RID: 11882
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401692B RID: 92459
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
