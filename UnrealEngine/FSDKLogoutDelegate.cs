using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000540 RID: 1344
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FSDKLogoutDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06007CA7 RID: 31911 RVA: 0x000B8B8E File Offset: 0x000B6D8E
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FSDKLogoutDelegate.StaticFunctionPtr();
		}

		// Token: 0x06007CA8 RID: 31912 RVA: 0x000B8B9A File Offset: 0x000B6D9A
		private static IntPtr StaticFunctionPtr()
		{
			if (FSDKLogoutDelegate._FunctionPtr == IntPtr.Zero)
			{
				FSDKLogoutDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroSDK.SDKLogoutDelegate__DelegateSignature");
			}
			return FSDKLogoutDelegate._FunctionPtr;
		}

		// Token: 0x06007CA9 RID: 31913 RVA: 0x000B8BBD File Offset: 0x000B6DBD
		public FSDKLogoutDelegate()
		{
		}

		// Token: 0x06007CAA RID: 31914 RVA: 0x000B8BC5 File Offset: 0x000B6DC5
		[NullableContext(2)]
		public FSDKLogoutDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007CAB RID: 31915 RVA: 0x000B8BCF File Offset: 0x000B6DCF
		public FSDKLogoutDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007CAC RID: 31916 RVA: 0x000B8BDA File Offset: 0x000B6DDA
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x06007CAD RID: 31917 RVA: 0x000B8C0C File Offset: 0x000B6E0C
		[NullableContext(1)]
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

		// Token: 0x06007CAE RID: 31918 RVA: 0x000B8C46 File Offset: 0x000B6E46
		[NullableContext(1)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06007CAF RID: 31919 RVA: 0x000B8C4F File Offset: 0x000B6E4F
		[SkipLocalsInit]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x06007CB0 RID: 31920 RVA: 0x000B8C5C File Offset: 0x000B6E5C
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

		// Token: 0x04003540 RID: 13632
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003541 RID: 13633
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSDK.SDKLogoutDelegate__DelegateSignature";

		// Token: 0x04003542 RID: 13634
		private static int RegisterId;

		// Token: 0x02000CF5 RID: 3317
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005F7C RID: 24444
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
