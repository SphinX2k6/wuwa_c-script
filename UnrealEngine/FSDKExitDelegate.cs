using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000533 RID: 1331
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FSDKExitDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06007C25 RID: 31781 RVA: 0x000B7956 File Offset: 0x000B5B56
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FSDKExitDelegate.StaticFunctionPtr();
		}

		// Token: 0x06007C26 RID: 31782 RVA: 0x000B7962 File Offset: 0x000B5B62
		private static IntPtr StaticFunctionPtr()
		{
			if (FSDKExitDelegate._FunctionPtr == IntPtr.Zero)
			{
				FSDKExitDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroSDK.SDKExitDelegate__DelegateSignature");
			}
			return FSDKExitDelegate._FunctionPtr;
		}

		// Token: 0x06007C27 RID: 31783 RVA: 0x000B7985 File Offset: 0x000B5B85
		public FSDKExitDelegate()
		{
		}

		// Token: 0x06007C28 RID: 31784 RVA: 0x000B798D File Offset: 0x000B5B8D
		[NullableContext(2)]
		public FSDKExitDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007C29 RID: 31785 RVA: 0x000B7997 File Offset: 0x000B5B97
		public FSDKExitDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007C2A RID: 31786 RVA: 0x000B79A2 File Offset: 0x000B5BA2
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x06007C2B RID: 31787 RVA: 0x000B79D4 File Offset: 0x000B5BD4
		[NullableContext(1)]
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

		// Token: 0x06007C2C RID: 31788 RVA: 0x000B7A0E File Offset: 0x000B5C0E
		[NullableContext(1)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06007C2D RID: 31789 RVA: 0x000B7A17 File Offset: 0x000B5C17
		[SkipLocalsInit]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x06007C2E RID: 31790 RVA: 0x000B7A24 File Offset: 0x000B5C24
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

		// Token: 0x04003519 RID: 13593
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400351A RID: 13594
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSDK.SDKExitDelegate__DelegateSignature";

		// Token: 0x0400351B RID: 13595
		private static int RegisterId;

		// Token: 0x02000CDD RID: 3293
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005F5D RID: 24413
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
