using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;

namespace UnrealEngine
{
	// Token: 0x020005BA RID: 1466
	public sealed class FDeviceLangChange : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06008365 RID: 33637 RVA: 0x000C27DA File Offset: 0x000C09DA
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FDeviceLangChange.StaticFunctionPtr();
		}

		// Token: 0x06008366 RID: 33638 RVA: 0x000C27E6 File Offset: 0x000C09E6
		private static IntPtr StaticFunctionPtr()
		{
			if (FDeviceLangChange._FunctionPtr == IntPtr.Zero)
			{
				FDeviceLangChange._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroUtility.DeviceLangChange__DelegateSignature");
			}
			return FDeviceLangChange._FunctionPtr;
		}

		// Token: 0x06008367 RID: 33639 RVA: 0x000C2809 File Offset: 0x000C0A09
		public FDeviceLangChange()
		{
		}

		// Token: 0x06008368 RID: 33640 RVA: 0x000C2811 File Offset: 0x000C0A11
		[NullableContext(2)]
		public FDeviceLangChange(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06008369 RID: 33641 RVA: 0x000C281B File Offset: 0x000C0A1B
		public FDeviceLangChange(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600836A RID: 33642 RVA: 0x000C2826 File Offset: 0x000C0A26
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600836B RID: 33643 RVA: 0x000C2858 File Offset: 0x000C0A58
		[NullableContext(1)]
		public void Bind(Action Callback)
		{
			if (FDeviceLangChange.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FDeviceLangChange.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FDeviceLangChange.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FDeviceLangChange.OnScriptCallback));
				}
				FDeviceLangChange.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FDeviceLangChange.RegisterId);
		}

		// Token: 0x0600836C RID: 33644 RVA: 0x000C2892 File Offset: 0x000C0A92
		[SkipLocalsInit]
		public void Execute()
		{
			base.ExecuteInternal(null);
		}

		// Token: 0x0600836D RID: 33645 RVA: 0x000C28A0 File Offset: 0x000C0AA0
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

		// Token: 0x04003922 RID: 14626
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003923 RID: 14627
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroUtility.DeviceLangChange__DelegateSignature";

		// Token: 0x04003924 RID: 14628
		private static int RegisterId;

		// Token: 0x02000D3F RID: 3391
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005FDC RID: 24540
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
