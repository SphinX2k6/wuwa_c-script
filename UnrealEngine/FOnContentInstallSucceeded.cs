using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;

namespace UnrealEngine
{
	// Token: 0x0200075B RID: 1883
	public sealed class FOnContentInstallSucceeded : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600A437 RID: 42039 RVA: 0x000F26CE File Offset: 0x000F08CE
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnContentInstallSucceeded.StaticFunctionPtr();
		}

		// Token: 0x0600A438 RID: 42040 RVA: 0x000F26DA File Offset: 0x000F08DA
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnContentInstallSucceeded._FunctionPtr == IntPtr.Zero)
			{
				FOnContentInstallSucceeded._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/MobilePatchingUtils.OnContentInstallSucceeded__DelegateSignature");
			}
			return FOnContentInstallSucceeded._FunctionPtr;
		}

		// Token: 0x0600A439 RID: 42041 RVA: 0x000F26FD File Offset: 0x000F08FD
		public FOnContentInstallSucceeded()
		{
		}

		// Token: 0x0600A43A RID: 42042 RVA: 0x000F2705 File Offset: 0x000F0905
		[NullableContext(2)]
		public FOnContentInstallSucceeded(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600A43B RID: 42043 RVA: 0x000F270F File Offset: 0x000F090F
		public FOnContentInstallSucceeded(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600A43C RID: 42044 RVA: 0x000F271A File Offset: 0x000F091A
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600A43D RID: 42045 RVA: 0x000F274C File Offset: 0x000F094C
		[NullableContext(1)]
		public void Bind(Action Callback)
		{
			if (FOnContentInstallSucceeded.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnContentInstallSucceeded.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnContentInstallSucceeded.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnContentInstallSucceeded.OnScriptCallback));
				}
				FOnContentInstallSucceeded.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FOnContentInstallSucceeded.RegisterId);
		}

		// Token: 0x0600A43E RID: 42046 RVA: 0x000F2786 File Offset: 0x000F0986
		[SkipLocalsInit]
		public void Execute()
		{
			base.ExecuteInternal(null);
		}

		// Token: 0x0600A43F RID: 42047 RVA: 0x000F2794 File Offset: 0x000F0994
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

		// Token: 0x04004602 RID: 17922
		internal static IntPtr _FunctionPtr;

		// Token: 0x04004603 RID: 17923
		[Nullable(1)]
		public const string __ObjectPath = "/Script/MobilePatchingUtils.OnContentInstallSucceeded__DelegateSignature";

		// Token: 0x04004604 RID: 17924
		private static int RegisterId;

		// Token: 0x02000F46 RID: 3910
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0400631B RID: 25371
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
