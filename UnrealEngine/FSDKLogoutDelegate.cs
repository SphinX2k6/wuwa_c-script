using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001CA7 RID: 7335
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FSDKLogoutDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601C76A RID: 116586 RVA: 0x002A11DA File Offset: 0x0029F3DA
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FSDKLogoutDelegate.StaticFunctionPtr();
		}

		// Token: 0x0601C76B RID: 116587 RVA: 0x002A11E6 File Offset: 0x0029F3E6
		private static IntPtr StaticFunctionPtr()
		{
			if (FSDKLogoutDelegate._FunctionPtr == IntPtr.Zero)
			{
				FSDKLogoutDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroSDK.SDKLogoutDelegate__DelegateSignature");
			}
			return FSDKLogoutDelegate._FunctionPtr;
		}

		// Token: 0x0601C76C RID: 116588 RVA: 0x002A1209 File Offset: 0x0029F409
		public FSDKLogoutDelegate()
		{
		}

		// Token: 0x0601C76D RID: 116589 RVA: 0x002A1211 File Offset: 0x0029F411
		[NullableContext(2)]
		public FSDKLogoutDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601C76E RID: 116590 RVA: 0x002A121B File Offset: 0x0029F41B
		public FSDKLogoutDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601C76F RID: 116591 RVA: 0x002A1226 File Offset: 0x0029F426
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601C770 RID: 116592 RVA: 0x002A1258 File Offset: 0x0029F458
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action Callback)
		{
			if (FSDKLogoutDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FSDKLogoutDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FSDKLogoutDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FSDKLogoutDelegate.OnScriptCallback));
				}
				FSDKLogoutDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FSDKLogoutDelegate.RegisterId);
		}

		// Token: 0x0601C771 RID: 116593 RVA: 0x002A1292 File Offset: 0x0029F492
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601C772 RID: 116594 RVA: 0x002A129B File Offset: 0x0029F49B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x0601C773 RID: 116595 RVA: 0x002A12A8 File Offset: 0x0029F4A8
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

		// Token: 0x0400F4D6 RID: 62678
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400F4D7 RID: 62679
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSDK.SDKLogoutDelegate__DelegateSignature";

		// Token: 0x0400F4D8 RID: 62680
		private static int RegisterId;

		// Token: 0x02003280 RID: 12928
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017108 RID: 94472
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
