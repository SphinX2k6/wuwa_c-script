using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;

namespace UnrealEngine
{
	// Token: 0x020006DD RID: 1757
	public sealed class FSimpleSequenceEvent : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06009554 RID: 38228 RVA: 0x000E1752 File Offset: 0x000DF952
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FSimpleSequenceEvent.StaticFunctionPtr();
		}

		// Token: 0x06009555 RID: 38229 RVA: 0x000E175E File Offset: 0x000DF95E
		private static IntPtr StaticFunctionPtr()
		{
			if (FSimpleSequenceEvent._FunctionPtr == IntPtr.Zero)
			{
				FSimpleSequenceEvent._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.SimpleSequenceEvent__DelegateSignature");
			}
			return FSimpleSequenceEvent._FunctionPtr;
		}

		// Token: 0x06009556 RID: 38230 RVA: 0x000E1781 File Offset: 0x000DF981
		public FSimpleSequenceEvent()
		{
		}

		// Token: 0x06009557 RID: 38231 RVA: 0x000E1789 File Offset: 0x000DF989
		[NullableContext(2)]
		public FSimpleSequenceEvent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06009558 RID: 38232 RVA: 0x000E1793 File Offset: 0x000DF993
		public FSimpleSequenceEvent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06009559 RID: 38233 RVA: 0x000E179E File Offset: 0x000DF99E
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600955A RID: 38234 RVA: 0x000E17D0 File Offset: 0x000DF9D0
		[NullableContext(1)]
		public void Bind(Action Callback)
		{
			if (FSimpleSequenceEvent.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FSimpleSequenceEvent.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FSimpleSequenceEvent.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FSimpleSequenceEvent.OnScriptCallback));
				}
				FSimpleSequenceEvent.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FSimpleSequenceEvent.RegisterId);
		}

		// Token: 0x0600955B RID: 38235 RVA: 0x000E180A File Offset: 0x000DFA0A
		[SkipLocalsInit]
		public void Execute()
		{
			base.ExecuteInternal(null);
		}

		// Token: 0x0600955C RID: 38236 RVA: 0x000E1818 File Offset: 0x000DFA18
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action action = target as Action;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action();
		}

		// Token: 0x040040F3 RID: 16627
		internal static IntPtr _FunctionPtr;

		// Token: 0x040040F4 RID: 16628
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.SimpleSequenceEvent__DelegateSignature";

		// Token: 0x040040F5 RID: 16629
		private static int RegisterId;

		// Token: 0x02000F11 RID: 3857
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040062DE RID: 25310
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
