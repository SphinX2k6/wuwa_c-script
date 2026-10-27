using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001CB1 RID: 7345
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FSDKWebViewCloseDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601C7CE RID: 116686 RVA: 0x002A1FAB File Offset: 0x002A01AB
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FSDKWebViewCloseDelegate.StaticFunctionPtr();
		}

		// Token: 0x0601C7CF RID: 116687 RVA: 0x002A1FB7 File Offset: 0x002A01B7
		private static IntPtr StaticFunctionPtr()
		{
			if (FSDKWebViewCloseDelegate._FunctionPtr == IntPtr.Zero)
			{
				FSDKWebViewCloseDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroSDK.SDKWebViewCloseDelegate__DelegateSignature");
			}
			return FSDKWebViewCloseDelegate._FunctionPtr;
		}

		// Token: 0x0601C7D0 RID: 116688 RVA: 0x002A1FDA File Offset: 0x002A01DA
		public FSDKWebViewCloseDelegate()
		{
		}

		// Token: 0x0601C7D1 RID: 116689 RVA: 0x002A1FE2 File Offset: 0x002A01E2
		[NullableContext(2)]
		public FSDKWebViewCloseDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601C7D2 RID: 116690 RVA: 0x002A1FEC File Offset: 0x002A01EC
		public FSDKWebViewCloseDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601C7D3 RID: 116691 RVA: 0x002A1FF7 File Offset: 0x002A01F7
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601C7D4 RID: 116692 RVA: 0x002A2029 File Offset: 0x002A0229
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0601C7D5 RID: 116693 RVA: 0x002A2063 File Offset: 0x002A0263
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601C7D6 RID: 116694 RVA: 0x002A206C File Offset: 0x002A026C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x0601C7D7 RID: 116695 RVA: 0x002A2078 File Offset: 0x002A0278
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

		// Token: 0x0400F4F4 RID: 62708
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400F4F5 RID: 62709
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSDK.SDKWebViewCloseDelegate__DelegateSignature";

		// Token: 0x0400F4F6 RID: 62710
		private static int RegisterId;

		// Token: 0x02003293 RID: 12947
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017120 RID: 94496
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
