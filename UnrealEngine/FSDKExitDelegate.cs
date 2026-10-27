using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001C9A RID: 7322
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FSDKExitDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601C6E8 RID: 116456 RVA: 0x0029FFA2 File Offset: 0x0029E1A2
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FSDKExitDelegate.StaticFunctionPtr();
		}

		// Token: 0x0601C6E9 RID: 116457 RVA: 0x0029FFAE File Offset: 0x0029E1AE
		private static IntPtr StaticFunctionPtr()
		{
			if (FSDKExitDelegate._FunctionPtr == IntPtr.Zero)
			{
				FSDKExitDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroSDK.SDKExitDelegate__DelegateSignature");
			}
			return FSDKExitDelegate._FunctionPtr;
		}

		// Token: 0x0601C6EA RID: 116458 RVA: 0x0029FFD1 File Offset: 0x0029E1D1
		public FSDKExitDelegate()
		{
		}

		// Token: 0x0601C6EB RID: 116459 RVA: 0x0029FFD9 File Offset: 0x0029E1D9
		[NullableContext(2)]
		public FSDKExitDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601C6EC RID: 116460 RVA: 0x0029FFE3 File Offset: 0x0029E1E3
		public FSDKExitDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601C6ED RID: 116461 RVA: 0x0029FFEE File Offset: 0x0029E1EE
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601C6EE RID: 116462 RVA: 0x002A0020 File Offset: 0x0029E220
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action Callback)
		{
			if (FSDKExitDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FSDKExitDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FSDKExitDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FSDKExitDelegate.OnScriptCallback));
				}
				FSDKExitDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FSDKExitDelegate.RegisterId);
		}

		// Token: 0x0601C6EF RID: 116463 RVA: 0x002A005A File Offset: 0x0029E25A
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601C6F0 RID: 116464 RVA: 0x002A0063 File Offset: 0x0029E263
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x0601C6F1 RID: 116465 RVA: 0x002A0070 File Offset: 0x0029E270
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

		// Token: 0x0400F4AF RID: 62639
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400F4B0 RID: 62640
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSDK.SDKExitDelegate__DelegateSignature";

		// Token: 0x0400F4B1 RID: 62641
		private static int RegisterId;

		// Token: 0x02003268 RID: 12904
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040170E9 RID: 94441
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
