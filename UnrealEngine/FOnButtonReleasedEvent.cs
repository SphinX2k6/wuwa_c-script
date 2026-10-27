using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002996 RID: 10646
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnButtonReleasedEvent : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06027669 RID: 161385 RVA: 0x003C1282 File Offset: 0x003BF482
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnButtonReleasedEvent.StaticFunctionPtr();
		}

		// Token: 0x0602766A RID: 161386 RVA: 0x003C128E File Offset: 0x003BF48E
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnButtonReleasedEvent._FunctionPtr == IntPtr.Zero)
			{
				FOnButtonReleasedEvent._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/UMG.OnButtonReleasedEvent__DelegateSignature");
			}
			return FOnButtonReleasedEvent._FunctionPtr;
		}

		// Token: 0x0602766B RID: 161387 RVA: 0x003C12B1 File Offset: 0x003BF4B1
		public FOnButtonReleasedEvent()
		{
		}

		// Token: 0x0602766C RID: 161388 RVA: 0x003C12B9 File Offset: 0x003BF4B9
		[NullableContext(2)]
		public FOnButtonReleasedEvent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602766D RID: 161389 RVA: 0x003C12C3 File Offset: 0x003BF4C3
		public FOnButtonReleasedEvent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602766E RID: 161390 RVA: 0x003C12CE File Offset: 0x003BF4CE
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0602766F RID: 161391 RVA: 0x003C1300 File Offset: 0x003BF500
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action Callback)
		{
			if (FOnButtonReleasedEvent.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnButtonReleasedEvent.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnButtonReleasedEvent.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnButtonReleasedEvent.OnScriptCallback));
				}
				FOnButtonReleasedEvent.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnButtonReleasedEvent.RegisterId);
		}

		// Token: 0x06027670 RID: 161392 RVA: 0x003C133A File Offset: 0x003BF53A
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06027671 RID: 161393 RVA: 0x003C1343 File Offset: 0x003BF543
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x06027672 RID: 161394 RVA: 0x003C1350 File Offset: 0x003BF550
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

		// Token: 0x04015A27 RID: 88615
		internal static IntPtr _FunctionPtr;

		// Token: 0x04015A28 RID: 88616
		[Nullable(1)]
		public const string __ObjectPath = "/Script/UMG.OnButtonReleasedEvent__DelegateSignature";

		// Token: 0x04015A29 RID: 88617
		private static int RegisterId;

		// Token: 0x02003B88 RID: 15240
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017D62 RID: 97634
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
