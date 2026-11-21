using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;

namespace UnrealEngine
{
	// Token: 0x020003E7 RID: 999
	public sealed class FKuroEffectOnClearCallback : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060061E2 RID: 25058 RVA: 0x0008BFE5 File Offset: 0x0008A1E5
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FKuroEffectOnClearCallback.StaticFunctionPtr();
		}

		// Token: 0x060061E3 RID: 25059 RVA: 0x0008BFF1 File Offset: 0x0008A1F1
		private static IntPtr StaticFunctionPtr()
		{
			if (FKuroEffectOnClearCallback._FunctionPtr == IntPtr.Zero)
			{
				FKuroEffectOnClearCallback._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroGameplay.KuroEffectOnClearCallback__DelegateSignature");
			}
			return FKuroEffectOnClearCallback._FunctionPtr;
		}

		// Token: 0x060061E4 RID: 25060 RVA: 0x0008C014 File Offset: 0x0008A214
		public FKuroEffectOnClearCallback()
		{
		}

		// Token: 0x060061E5 RID: 25061 RVA: 0x0008C01C File Offset: 0x0008A21C
		[NullableContext(2)]
		public FKuroEffectOnClearCallback(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060061E6 RID: 25062 RVA: 0x0008C026 File Offset: 0x0008A226
		public FKuroEffectOnClearCallback(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060061E7 RID: 25063 RVA: 0x0008C031 File Offset: 0x0008A231
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x060061E8 RID: 25064 RVA: 0x0008C063 File Offset: 0x0008A263
		[NullableContext(1)]
		public void Bind(Action Callback)
		{
			if (FKuroEffectOnClearCallback.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FKuroEffectOnClearCallback.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FKuroEffectOnClearCallback.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FKuroEffectOnClearCallback.OnScriptCallback));
				}
				FKuroEffectOnClearCallback.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FKuroEffectOnClearCallback.RegisterId);
		}

		// Token: 0x060061E9 RID: 25065 RVA: 0x0008C09D File Offset: 0x0008A29D
		[SkipLocalsInit]
		public void Execute()
		{
			base.ExecuteInternal(null);
		}

		// Token: 0x060061EA RID: 25066 RVA: 0x0008C0A8 File Offset: 0x0008A2A8
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

		// Token: 0x040029B0 RID: 10672
		internal static IntPtr _FunctionPtr;

		// Token: 0x040029B1 RID: 10673
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameplay.KuroEffectOnClearCallback__DelegateSignature";

		// Token: 0x040029B2 RID: 10674
		private static int RegisterId;

		// Token: 0x02000ADB RID: 2779
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005B59 RID: 23385
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
