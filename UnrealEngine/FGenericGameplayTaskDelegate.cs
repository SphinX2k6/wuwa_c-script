using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020013F9 RID: 5113
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FGenericGameplayTaskDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06012AB2 RID: 76466 RVA: 0x001B7B1A File Offset: 0x001B5D1A
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FGenericGameplayTaskDelegate.StaticFunctionPtr();
		}

		// Token: 0x06012AB3 RID: 76467 RVA: 0x001B7B26 File Offset: 0x001B5D26
		private static IntPtr StaticFunctionPtr()
		{
			if (UGameplayTask.__GenericGameplayTaskDelegate__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				UGameplayTask.__GenericGameplayTaskDelegate__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/GameplayTasks.GameplayTask:GenericGameplayTaskDelegate__DelegateSignature");
			}
			return UGameplayTask.__GenericGameplayTaskDelegate__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x06012AB4 RID: 76468 RVA: 0x001B7B49 File Offset: 0x001B5D49
		public FGenericGameplayTaskDelegate()
		{
		}

		// Token: 0x06012AB5 RID: 76469 RVA: 0x001B7B51 File Offset: 0x001B5D51
		[NullableContext(2)]
		public FGenericGameplayTaskDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06012AB6 RID: 76470 RVA: 0x001B7B5B File Offset: 0x001B5D5B
		public FGenericGameplayTaskDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06012AB7 RID: 76471 RVA: 0x001B7B66 File Offset: 0x001B5D66
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x06012AB8 RID: 76472 RVA: 0x001B7B98 File Offset: 0x001B5D98
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action Callback)
		{
			if (FGenericGameplayTaskDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FGenericGameplayTaskDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FGenericGameplayTaskDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FGenericGameplayTaskDelegate.OnScriptCallback));
				}
				FGenericGameplayTaskDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FGenericGameplayTaskDelegate.RegisterId);
		}

		// Token: 0x06012AB9 RID: 76473 RVA: 0x001B7BD2 File Offset: 0x001B5DD2
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06012ABA RID: 76474 RVA: 0x001B7BDB File Offset: 0x001B5DDB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x06012ABB RID: 76475 RVA: 0x001B7BE8 File Offset: 0x001B5DE8
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

		// Token: 0x04009FAA RID: 40874
		[Nullable(1)]
		public const string __ObjectPath = "/Script/GameplayTasks.GameplayTask:GenericGameplayTaskDelegate__DelegateSignature";

		// Token: 0x04009FAB RID: 40875
		private static int RegisterId;

		// Token: 0x02002E7A RID: 11898
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401694D RID: 92493
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
