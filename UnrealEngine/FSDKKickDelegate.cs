using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001CA3 RID: 7331
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FSDKKickDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601C742 RID: 116546 RVA: 0x002A0C7A File Offset: 0x0029EE7A
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FSDKKickDelegate.StaticFunctionPtr();
		}

		// Token: 0x0601C743 RID: 116547 RVA: 0x002A0C86 File Offset: 0x0029EE86
		private static IntPtr StaticFunctionPtr()
		{
			if (FSDKKickDelegate._FunctionPtr == IntPtr.Zero)
			{
				FSDKKickDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroSDK.SDKKickDelegate__DelegateSignature");
			}
			return FSDKKickDelegate._FunctionPtr;
		}

		// Token: 0x0601C744 RID: 116548 RVA: 0x002A0CA9 File Offset: 0x0029EEA9
		public FSDKKickDelegate()
		{
		}

		// Token: 0x0601C745 RID: 116549 RVA: 0x002A0CB1 File Offset: 0x0029EEB1
		[NullableContext(2)]
		public FSDKKickDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601C746 RID: 116550 RVA: 0x002A0CBB File Offset: 0x0029EEBB
		public FSDKKickDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601C747 RID: 116551 RVA: 0x002A0CC6 File Offset: 0x0029EEC6
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601C748 RID: 116552 RVA: 0x002A0CF8 File Offset: 0x0029EEF8
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action Callback)
		{
			if (FSDKKickDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FSDKKickDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FSDKKickDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FSDKKickDelegate.OnScriptCallback));
				}
				FSDKKickDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FSDKKickDelegate.RegisterId);
		}

		// Token: 0x0601C749 RID: 116553 RVA: 0x002A0D32 File Offset: 0x0029EF32
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601C74A RID: 116554 RVA: 0x002A0D3B File Offset: 0x0029EF3B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x0601C74B RID: 116555 RVA: 0x002A0D48 File Offset: 0x0029EF48
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

		// Token: 0x0400F4CA RID: 62666
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400F4CB RID: 62667
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSDK.SDKKickDelegate__DelegateSignature";

		// Token: 0x0400F4CC RID: 62668
		private static int RegisterId;

		// Token: 0x02003279 RID: 12921
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017101 RID: 94465
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
