using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;

namespace UnrealEngine
{
	// Token: 0x0200049D RID: 1181
	public sealed class FOnDataTableChanged : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06006E1B RID: 28187 RVA: 0x000A209F File Offset: 0x000A029F
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnDataTableChanged.StaticFunctionPtr();
		}

		// Token: 0x06006E1C RID: 28188 RVA: 0x000A20AB File Offset: 0x000A02AB
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnDataTableChanged._FunctionPtr == IntPtr.Zero)
			{
				FOnDataTableChanged._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroPuertsWrapper.OnDataTableChanged__DelegateSignature");
			}
			return FOnDataTableChanged._FunctionPtr;
		}

		// Token: 0x06006E1D RID: 28189 RVA: 0x000A20CE File Offset: 0x000A02CE
		public FOnDataTableChanged()
		{
		}

		// Token: 0x06006E1E RID: 28190 RVA: 0x000A20D6 File Offset: 0x000A02D6
		[NullableContext(2)]
		public FOnDataTableChanged(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006E1F RID: 28191 RVA: 0x000A20E0 File Offset: 0x000A02E0
		public FOnDataTableChanged(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06006E20 RID: 28192 RVA: 0x000A20EB File Offset: 0x000A02EB
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x06006E21 RID: 28193 RVA: 0x000A211D File Offset: 0x000A031D
		[NullableContext(1)]
		public void Bind(Action Callback)
		{
			if (FOnDataTableChanged.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnDataTableChanged.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnDataTableChanged.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnDataTableChanged.OnScriptCallback));
				}
				FOnDataTableChanged.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FOnDataTableChanged.RegisterId);
		}

		// Token: 0x06006E22 RID: 28194 RVA: 0x000A2157 File Offset: 0x000A0357
		[SkipLocalsInit]
		public void Execute()
		{
			base.ExecuteInternal(null);
		}

		// Token: 0x06006E23 RID: 28195 RVA: 0x000A2164 File Offset: 0x000A0364
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

		// Token: 0x04002F2A RID: 12074
		internal static IntPtr _FunctionPtr;

		// Token: 0x04002F2B RID: 12075
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroPuertsWrapper.OnDataTableChanged__DelegateSignature";

		// Token: 0x04002F2C RID: 12076
		private static int RegisterId;

		// Token: 0x02000BD4 RID: 3028
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005D7F RID: 23935
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
