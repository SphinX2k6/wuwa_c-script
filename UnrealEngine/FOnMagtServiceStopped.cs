using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002280 RID: 8832
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnMagtServiceStopped : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0602193E RID: 137534 RVA: 0x0031AD5E File Offset: 0x00318F5E
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnMagtServiceStopped.StaticFunctionPtr();
		}

		// Token: 0x0602193F RID: 137535 RVA: 0x0031AD6A File Offset: 0x00318F6A
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnMagtServiceStopped._FunctionPtr == IntPtr.Zero)
			{
				FOnMagtServiceStopped._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/MagtModule.OnMagtServiceStopped__DelegateSignature");
			}
			return FOnMagtServiceStopped._FunctionPtr;
		}

		// Token: 0x06021940 RID: 137536 RVA: 0x0031AD8D File Offset: 0x00318F8D
		public FOnMagtServiceStopped()
		{
		}

		// Token: 0x06021941 RID: 137537 RVA: 0x0031AD95 File Offset: 0x00318F95
		[NullableContext(2)]
		public FOnMagtServiceStopped(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021942 RID: 137538 RVA: 0x0031AD9F File Offset: 0x00318F9F
		public FOnMagtServiceStopped(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021943 RID: 137539 RVA: 0x0031ADAA File Offset: 0x00318FAA
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x06021944 RID: 137540 RVA: 0x0031ADDC File Offset: 0x00318FDC
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action Callback)
		{
			if (FOnMagtServiceStopped.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnMagtServiceStopped.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnMagtServiceStopped.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnMagtServiceStopped.OnScriptCallback));
				}
				FOnMagtServiceStopped.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnMagtServiceStopped.RegisterId);
		}

		// Token: 0x06021945 RID: 137541 RVA: 0x0031AE16 File Offset: 0x00319016
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06021946 RID: 137542 RVA: 0x0031AE1F File Offset: 0x0031901F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x06021947 RID: 137543 RVA: 0x0031AE2C File Offset: 0x0031902C
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

		// Token: 0x04011EE7 RID: 73447
		internal static IntPtr _FunctionPtr;

		// Token: 0x04011EE8 RID: 73448
		[Nullable(1)]
		public const string __ObjectPath = "/Script/MagtModule.OnMagtServiceStopped__DelegateSignature";

		// Token: 0x04011EE9 RID: 73449
		private static int RegisterId;

		// Token: 0x02003609 RID: 13833
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017693 RID: 95891
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
