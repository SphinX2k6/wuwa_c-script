using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020013FC RID: 5116
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FTaskFinishDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06012AD0 RID: 76496 RVA: 0x001B7EDA File Offset: 0x001B60DA
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FTaskFinishDelegate.StaticFunctionPtr();
		}

		// Token: 0x06012AD1 RID: 76497 RVA: 0x001B7EE6 File Offset: 0x001B60E6
		private static IntPtr StaticFunctionPtr()
		{
			if (UGameplayTask_TimeLimitedExecution.__TaskFinishDelegate__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				UGameplayTask_TimeLimitedExecution.__TaskFinishDelegate__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/GameplayTasks.GameplayTask_TimeLimitedExecution:TaskFinishDelegate__DelegateSignature");
			}
			return UGameplayTask_TimeLimitedExecution.__TaskFinishDelegate__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x06012AD2 RID: 76498 RVA: 0x001B7F09 File Offset: 0x001B6109
		public FTaskFinishDelegate()
		{
		}

		// Token: 0x06012AD3 RID: 76499 RVA: 0x001B7F11 File Offset: 0x001B6111
		[NullableContext(2)]
		public FTaskFinishDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06012AD4 RID: 76500 RVA: 0x001B7F1B File Offset: 0x001B611B
		public FTaskFinishDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06012AD5 RID: 76501 RVA: 0x001B7F26 File Offset: 0x001B6126
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x06012AD6 RID: 76502 RVA: 0x001B7F58 File Offset: 0x001B6158
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action Callback)
		{
			if (FTaskFinishDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FTaskFinishDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FTaskFinishDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FTaskFinishDelegate.OnScriptCallback));
				}
				FTaskFinishDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FTaskFinishDelegate.RegisterId);
		}

		// Token: 0x06012AD7 RID: 76503 RVA: 0x001B7F92 File Offset: 0x001B6192
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06012AD8 RID: 76504 RVA: 0x001B7F9B File Offset: 0x001B619B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x06012AD9 RID: 76505 RVA: 0x001B7FA8 File Offset: 0x001B61A8
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

		// Token: 0x04009FB1 RID: 40881
		[Nullable(1)]
		public const string __ObjectPath = "/Script/GameplayTasks.GameplayTask_TimeLimitedExecution:TaskFinishDelegate__DelegateSignature";

		// Token: 0x04009FB2 RID: 40882
		private static int RegisterId;

		// Token: 0x02002E7E RID: 11902
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016952 RID: 92498
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
