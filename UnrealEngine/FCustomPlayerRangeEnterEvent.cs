using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;

namespace UnrealEngine
{
	// Token: 0x0200038F RID: 911
	public sealed class FCustomPlayerRangeEnterEvent : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06005B12 RID: 23314 RVA: 0x000809EE File Offset: 0x0007EBEE
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FCustomPlayerRangeEnterEvent.StaticFunctionPtr();
		}

		// Token: 0x06005B13 RID: 23315 RVA: 0x000809FA File Offset: 0x0007EBFA
		private static IntPtr StaticFunctionPtr()
		{
			if (FCustomPlayerRangeEnterEvent._FunctionPtr == IntPtr.Zero)
			{
				FCustomPlayerRangeEnterEvent._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroGameBudget.CustomPlayerRangeEnterEvent__DelegateSignature");
			}
			return FCustomPlayerRangeEnterEvent._FunctionPtr;
		}

		// Token: 0x06005B14 RID: 23316 RVA: 0x00080A1D File Offset: 0x0007EC1D
		public FCustomPlayerRangeEnterEvent()
		{
		}

		// Token: 0x06005B15 RID: 23317 RVA: 0x00080A25 File Offset: 0x0007EC25
		[NullableContext(2)]
		public FCustomPlayerRangeEnterEvent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005B16 RID: 23318 RVA: 0x00080A2F File Offset: 0x0007EC2F
		public FCustomPlayerRangeEnterEvent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005B17 RID: 23319 RVA: 0x00080A3A File Offset: 0x0007EC3A
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x06005B18 RID: 23320 RVA: 0x00080A6C File Offset: 0x0007EC6C
		[NullableContext(1)]
		public void Bind(Action Callback)
		{
			if (FCustomPlayerRangeEnterEvent.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FCustomPlayerRangeEnterEvent.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FCustomPlayerRangeEnterEvent.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FCustomPlayerRangeEnterEvent.OnScriptCallback));
				}
				FCustomPlayerRangeEnterEvent.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FCustomPlayerRangeEnterEvent.RegisterId);
		}

		// Token: 0x06005B19 RID: 23321 RVA: 0x00080AA6 File Offset: 0x0007ECA6
		[SkipLocalsInit]
		public void Execute()
		{
			base.ExecuteInternal(null);
		}

		// Token: 0x06005B1A RID: 23322 RVA: 0x00080AB4 File Offset: 0x0007ECB4
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

		// Token: 0x040025D7 RID: 9687
		internal static IntPtr _FunctionPtr;

		// Token: 0x040025D8 RID: 9688
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameBudget.CustomPlayerRangeEnterEvent__DelegateSignature";

		// Token: 0x040025D9 RID: 9689
		private static int RegisterId;

		// Token: 0x02000A99 RID: 2713
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005AED RID: 23277
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
