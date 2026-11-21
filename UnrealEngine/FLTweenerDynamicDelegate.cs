using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;

namespace UnrealEngine
{
	// Token: 0x02000745 RID: 1861
	public sealed class FLTweenerDynamicDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600A2A8 RID: 41640 RVA: 0x000F02FD File Offset: 0x000EE4FD
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLTweenerDynamicDelegate.StaticFunctionPtr();
		}

		// Token: 0x0600A2A9 RID: 41641 RVA: 0x000F0309 File Offset: 0x000EE509
		private static IntPtr StaticFunctionPtr()
		{
			if (FLTweenerDynamicDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLTweenerDynamicDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LTween.LTweenerDynamicDelegate__DelegateSignature");
			}
			return FLTweenerDynamicDelegate._FunctionPtr;
		}

		// Token: 0x0600A2AA RID: 41642 RVA: 0x000F032C File Offset: 0x000EE52C
		public FLTweenerDynamicDelegate()
		{
		}

		// Token: 0x0600A2AB RID: 41643 RVA: 0x000F0334 File Offset: 0x000EE534
		[NullableContext(2)]
		public FLTweenerDynamicDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600A2AC RID: 41644 RVA: 0x000F033E File Offset: 0x000EE53E
		public FLTweenerDynamicDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600A2AD RID: 41645 RVA: 0x000F0349 File Offset: 0x000EE549
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600A2AE RID: 41646 RVA: 0x000F037B File Offset: 0x000EE57B
		[NullableContext(1)]
		public void Bind(Action Callback)
		{
			if (FLTweenerDynamicDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLTweenerDynamicDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLTweenerDynamicDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLTweenerDynamicDelegate.OnScriptCallback));
				}
				FLTweenerDynamicDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLTweenerDynamicDelegate.RegisterId);
		}

		// Token: 0x0600A2AF RID: 41647 RVA: 0x000F03B5 File Offset: 0x000EE5B5
		[SkipLocalsInit]
		public void Execute()
		{
			base.ExecuteInternal(null);
		}

		// Token: 0x0600A2B0 RID: 41648 RVA: 0x000F03C0 File Offset: 0x000EE5C0
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

		// Token: 0x04004594 RID: 17812
		internal static IntPtr _FunctionPtr;

		// Token: 0x04004595 RID: 17813
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LTween.LTweenerDynamicDelegate__DelegateSignature";

		// Token: 0x04004596 RID: 17814
		private static int RegisterId;

		// Token: 0x02000F2B RID: 3883
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040062FF RID: 25343
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
