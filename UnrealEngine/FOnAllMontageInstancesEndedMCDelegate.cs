using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000EFF RID: 3839
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnAllMontageInstancesEndedMCDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600CFE8 RID: 53224 RVA: 0x0012F443 File Offset: 0x0012D643
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnAllMontageInstancesEndedMCDelegate.StaticFunctionPtr();
		}

		// Token: 0x0600CFE9 RID: 53225 RVA: 0x0012F44F File Offset: 0x0012D64F
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnAllMontageInstancesEndedMCDelegate._FunctionPtr == IntPtr.Zero)
			{
				FOnAllMontageInstancesEndedMCDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.OnAllMontageInstancesEndedMCDelegate__DelegateSignature");
			}
			return FOnAllMontageInstancesEndedMCDelegate._FunctionPtr;
		}

		// Token: 0x0600CFEA RID: 53226 RVA: 0x0012F472 File Offset: 0x0012D672
		public FOnAllMontageInstancesEndedMCDelegate()
		{
		}

		// Token: 0x0600CFEB RID: 53227 RVA: 0x0012F47A File Offset: 0x0012D67A
		[NullableContext(2)]
		public FOnAllMontageInstancesEndedMCDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600CFEC RID: 53228 RVA: 0x0012F484 File Offset: 0x0012D684
		public FOnAllMontageInstancesEndedMCDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600CFED RID: 53229 RVA: 0x0012F48F File Offset: 0x0012D68F
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600CFEE RID: 53230 RVA: 0x0012F4C1 File Offset: 0x0012D6C1
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action Callback)
		{
			if (FOnAllMontageInstancesEndedMCDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnAllMontageInstancesEndedMCDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnAllMontageInstancesEndedMCDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnAllMontageInstancesEndedMCDelegate.OnScriptCallback));
				}
				FOnAllMontageInstancesEndedMCDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnAllMontageInstancesEndedMCDelegate.RegisterId);
		}

		// Token: 0x0600CFEF RID: 53231 RVA: 0x0012F4FB File Offset: 0x0012D6FB
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0600CFF0 RID: 53232 RVA: 0x0012F504 File Offset: 0x0012D704
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x0600CFF1 RID: 53233 RVA: 0x0012F510 File Offset: 0x0012D710
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

		// Token: 0x04007014 RID: 28692
		internal static IntPtr _FunctionPtr;

		// Token: 0x04007015 RID: 28693
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.OnAllMontageInstancesEndedMCDelegate__DelegateSignature";

		// Token: 0x04007016 RID: 28694
		private static int RegisterId;

		// Token: 0x02002D4F RID: 11599
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016762 RID: 92002
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
