using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020013FB RID: 5115
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FTaskDelayDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06012AC6 RID: 76486 RVA: 0x001B7DCD File Offset: 0x001B5FCD
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FTaskDelayDelegate.StaticFunctionPtr();
		}

		// Token: 0x06012AC7 RID: 76487 RVA: 0x001B7DD9 File Offset: 0x001B5FD9
		private static IntPtr StaticFunctionPtr()
		{
			if (UGameplayTask_WaitDelay.__TaskDelayDelegate__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				UGameplayTask_WaitDelay.__TaskDelayDelegate__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/GameplayTasks.GameplayTask_WaitDelay:TaskDelayDelegate__DelegateSignature");
			}
			return UGameplayTask_WaitDelay.__TaskDelayDelegate__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x06012AC8 RID: 76488 RVA: 0x001B7DFC File Offset: 0x001B5FFC
		public FTaskDelayDelegate()
		{
		}

		// Token: 0x06012AC9 RID: 76489 RVA: 0x001B7E04 File Offset: 0x001B6004
		[NullableContext(2)]
		public FTaskDelayDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06012ACA RID: 76490 RVA: 0x001B7E0E File Offset: 0x001B600E
		public FTaskDelayDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06012ACB RID: 76491 RVA: 0x001B7E19 File Offset: 0x001B6019
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x06012ACC RID: 76492 RVA: 0x001B7E4B File Offset: 0x001B604B
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action Callback)
		{
			if (FTaskDelayDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FTaskDelayDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FTaskDelayDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FTaskDelayDelegate.OnScriptCallback));
				}
				FTaskDelayDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FTaskDelayDelegate.RegisterId);
		}

		// Token: 0x06012ACD RID: 76493 RVA: 0x001B7E85 File Offset: 0x001B6085
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06012ACE RID: 76494 RVA: 0x001B7E8E File Offset: 0x001B608E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x06012ACF RID: 76495 RVA: 0x001B7E98 File Offset: 0x001B6098
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

		// Token: 0x04009FAF RID: 40879
		[Nullable(1)]
		public const string __ObjectPath = "/Script/GameplayTasks.GameplayTask_WaitDelay:TaskDelayDelegate__DelegateSignature";

		// Token: 0x04009FB0 RID: 40880
		private static int RegisterId;

		// Token: 0x02002E7D RID: 11901
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016951 RID: 92497
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
