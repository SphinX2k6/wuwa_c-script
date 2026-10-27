using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000F1B RID: 3867
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnMatineeEvent : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600D0EF RID: 53487 RVA: 0x0013178A File Offset: 0x0012F98A
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnMatineeEvent.StaticFunctionPtr();
		}

		// Token: 0x0600D0F0 RID: 53488 RVA: 0x00131796 File Offset: 0x0012F996
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnMatineeEvent._FunctionPtr == IntPtr.Zero)
			{
				FOnMatineeEvent._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.OnMatineeEvent__DelegateSignature");
			}
			return FOnMatineeEvent._FunctionPtr;
		}

		// Token: 0x0600D0F1 RID: 53489 RVA: 0x001317B9 File Offset: 0x0012F9B9
		public FOnMatineeEvent()
		{
		}

		// Token: 0x0600D0F2 RID: 53490 RVA: 0x001317C1 File Offset: 0x0012F9C1
		[NullableContext(2)]
		public FOnMatineeEvent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600D0F3 RID: 53491 RVA: 0x001317CB File Offset: 0x0012F9CB
		public FOnMatineeEvent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600D0F4 RID: 53492 RVA: 0x001317D6 File Offset: 0x0012F9D6
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600D0F5 RID: 53493 RVA: 0x00131808 File Offset: 0x0012FA08
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action Callback)
		{
			if (FOnMatineeEvent.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnMatineeEvent.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnMatineeEvent.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnMatineeEvent.OnScriptCallback));
				}
				FOnMatineeEvent.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnMatineeEvent.RegisterId);
		}

		// Token: 0x0600D0F6 RID: 53494 RVA: 0x00131842 File Offset: 0x0012FA42
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0600D0F7 RID: 53495 RVA: 0x0013184B File Offset: 0x0012FA4B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x0600D0F8 RID: 53496 RVA: 0x00131858 File Offset: 0x0012FA58
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

		// Token: 0x0400705F RID: 28767
		internal static IntPtr _FunctionPtr;

		// Token: 0x04007060 RID: 28768
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.OnMatineeEvent__DelegateSignature";

		// Token: 0x04007061 RID: 28769
		private static int RegisterId;

		// Token: 0x02002D7F RID: 11647
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040167A0 RID: 92064
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
