using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;

namespace UnrealEngine
{
	// Token: 0x0200080D RID: 2061
	public sealed class FSharpherealConsoleCommandDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600B53B RID: 46395 RVA: 0x0012034D File Offset: 0x0011E54D
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FSharpherealConsoleCommandDelegate.StaticFunctionPtr();
		}

		// Token: 0x0600B53C RID: 46396 RVA: 0x00120359 File Offset: 0x0011E559
		private static IntPtr StaticFunctionPtr()
		{
			if (FSharpherealConsoleCommandDelegate._FunctionPtr == IntPtr.Zero)
			{
				FSharpherealConsoleCommandDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Sharphereal.SharpherealConsoleCommandDelegate__DelegateSignature");
			}
			return FSharpherealConsoleCommandDelegate._FunctionPtr;
		}

		// Token: 0x0600B53D RID: 46397 RVA: 0x0012037C File Offset: 0x0011E57C
		public FSharpherealConsoleCommandDelegate()
		{
		}

		// Token: 0x0600B53E RID: 46398 RVA: 0x00120384 File Offset: 0x0011E584
		[NullableContext(2)]
		public FSharpherealConsoleCommandDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600B53F RID: 46399 RVA: 0x0012038E File Offset: 0x0011E58E
		public FSharpherealConsoleCommandDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600B540 RID: 46400 RVA: 0x00120399 File Offset: 0x0011E599
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600B541 RID: 46401 RVA: 0x001203CB File Offset: 0x0011E5CB
		[NullableContext(1)]
		public void Bind(Action Callback)
		{
			if (FSharpherealConsoleCommandDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FSharpherealConsoleCommandDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FSharpherealConsoleCommandDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FSharpherealConsoleCommandDelegate.OnScriptCallback));
				}
				FSharpherealConsoleCommandDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FSharpherealConsoleCommandDelegate.RegisterId);
		}

		// Token: 0x0600B542 RID: 46402 RVA: 0x00120405 File Offset: 0x0011E605
		[SkipLocalsInit]
		public void Execute()
		{
			base.ExecuteInternal(null);
		}

		// Token: 0x0600B543 RID: 46403 RVA: 0x00120410 File Offset: 0x0011E610
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

		// Token: 0x040051CC RID: 20940
		internal static IntPtr _FunctionPtr;

		// Token: 0x040051CD RID: 20941
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Sharphereal.SharpherealConsoleCommandDelegate__DelegateSignature";

		// Token: 0x040051CE RID: 20942
		private static int RegisterId;

		// Token: 0x0200132B RID: 4907
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04006766 RID: 26470
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
