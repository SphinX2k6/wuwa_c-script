using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200054A RID: 1354
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FSDKWebViewCloseDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06007D0B RID: 32011 RVA: 0x000B995F File Offset: 0x000B7B5F
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FSDKWebViewCloseDelegate.StaticFunctionPtr();
		}

		// Token: 0x06007D0C RID: 32012 RVA: 0x000B996B File Offset: 0x000B7B6B
		private static IntPtr StaticFunctionPtr()
		{
			if (FSDKWebViewCloseDelegate._FunctionPtr == IntPtr.Zero)
			{
				FSDKWebViewCloseDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroSDK.SDKWebViewCloseDelegate__DelegateSignature");
			}
			return FSDKWebViewCloseDelegate._FunctionPtr;
		}

		// Token: 0x06007D0D RID: 32013 RVA: 0x000B998E File Offset: 0x000B7B8E
		public FSDKWebViewCloseDelegate()
		{
		}

		// Token: 0x06007D0E RID: 32014 RVA: 0x000B9996 File Offset: 0x000B7B96
		[NullableContext(2)]
		public FSDKWebViewCloseDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007D0F RID: 32015 RVA: 0x000B99A0 File Offset: 0x000B7BA0
		public FSDKWebViewCloseDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007D10 RID: 32016 RVA: 0x000B99AB File Offset: 0x000B7BAB
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x06007D11 RID: 32017 RVA: 0x000B99DD File Offset: 0x000B7BDD
		[NullableContext(1)]
		public void Add(Action Callback)
		{
			if (FSDKWebViewCloseDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FSDKWebViewCloseDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FSDKWebViewCloseDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FSDKWebViewCloseDelegate.OnScriptCallback));
				}
				FSDKWebViewCloseDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FSDKWebViewCloseDelegate.RegisterId);
		}

		// Token: 0x06007D12 RID: 32018 RVA: 0x000B9A17 File Offset: 0x000B7C17
		[NullableContext(1)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06007D13 RID: 32019 RVA: 0x000B9A20 File Offset: 0x000B7C20
		[SkipLocalsInit]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x06007D14 RID: 32020 RVA: 0x000B9A2C File Offset: 0x000B7C2C
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

		// Token: 0x0400355E RID: 13662
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400355F RID: 13663
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSDK.SDKWebViewCloseDelegate__DelegateSignature";

		// Token: 0x04003560 RID: 13664
		private static int RegisterId;

		// Token: 0x02000D08 RID: 3336
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005F94 RID: 24468
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
