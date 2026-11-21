using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200079B RID: 1947
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnCustomNavigationInitDone : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600A85B RID: 43099 RVA: 0x000F894A File Offset: 0x000F6B4A
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnCustomNavigationInitDone.StaticFunctionPtr();
		}

		// Token: 0x0600A85C RID: 43100 RVA: 0x000F8956 File Offset: 0x000F6B56
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnCustomNavigationInitDone._FunctionPtr == IntPtr.Zero)
			{
				FOnCustomNavigationInitDone._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/NavigationSystem.OnCustomNavigationInitDone__DelegateSignature");
			}
			return FOnCustomNavigationInitDone._FunctionPtr;
		}

		// Token: 0x0600A85D RID: 43101 RVA: 0x000F8979 File Offset: 0x000F6B79
		public FOnCustomNavigationInitDone()
		{
		}

		// Token: 0x0600A85E RID: 43102 RVA: 0x000F8981 File Offset: 0x000F6B81
		[NullableContext(2)]
		public FOnCustomNavigationInitDone(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600A85F RID: 43103 RVA: 0x000F898B File Offset: 0x000F6B8B
		public FOnCustomNavigationInitDone(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600A860 RID: 43104 RVA: 0x000F8996 File Offset: 0x000F6B96
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600A861 RID: 43105 RVA: 0x000F89C8 File Offset: 0x000F6BC8
		[NullableContext(1)]
		public void Add(Action Callback)
		{
			if (FOnCustomNavigationInitDone.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnCustomNavigationInitDone.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnCustomNavigationInitDone.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnCustomNavigationInitDone.OnScriptCallback));
				}
				FOnCustomNavigationInitDone.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnCustomNavigationInitDone.RegisterId);
		}

		// Token: 0x0600A862 RID: 43106 RVA: 0x000F8A02 File Offset: 0x000F6C02
		[NullableContext(1)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0600A863 RID: 43107 RVA: 0x000F8A0B File Offset: 0x000F6C0B
		[SkipLocalsInit]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x0600A864 RID: 43108 RVA: 0x000F8A18 File Offset: 0x000F6C18
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

		// Token: 0x0400481A RID: 18458
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400481B RID: 18459
		[Nullable(1)]
		public const string __ObjectPath = "/Script/NavigationSystem.OnCustomNavigationInitDone__DelegateSignature";

		// Token: 0x0400481C RID: 18460
		private static int RegisterId;

		// Token: 0x02000F5C RID: 3932
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04006332 RID: 25394
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
