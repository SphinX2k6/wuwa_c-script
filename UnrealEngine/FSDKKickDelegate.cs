using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200053C RID: 1340
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FSDKKickDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06007C7F RID: 31871 RVA: 0x000B862E File Offset: 0x000B682E
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FSDKKickDelegate.StaticFunctionPtr();
		}

		// Token: 0x06007C80 RID: 31872 RVA: 0x000B863A File Offset: 0x000B683A
		private static IntPtr StaticFunctionPtr()
		{
			if (FSDKKickDelegate._FunctionPtr == IntPtr.Zero)
			{
				FSDKKickDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroSDK.SDKKickDelegate__DelegateSignature");
			}
			return FSDKKickDelegate._FunctionPtr;
		}

		// Token: 0x06007C81 RID: 31873 RVA: 0x000B865D File Offset: 0x000B685D
		public FSDKKickDelegate()
		{
		}

		// Token: 0x06007C82 RID: 31874 RVA: 0x000B8665 File Offset: 0x000B6865
		[NullableContext(2)]
		public FSDKKickDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007C83 RID: 31875 RVA: 0x000B866F File Offset: 0x000B686F
		public FSDKKickDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007C84 RID: 31876 RVA: 0x000B867A File Offset: 0x000B687A
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x06007C85 RID: 31877 RVA: 0x000B86AC File Offset: 0x000B68AC
		[NullableContext(1)]
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

		// Token: 0x06007C86 RID: 31878 RVA: 0x000B86E6 File Offset: 0x000B68E6
		[NullableContext(1)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06007C87 RID: 31879 RVA: 0x000B86EF File Offset: 0x000B68EF
		[SkipLocalsInit]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x06007C88 RID: 31880 RVA: 0x000B86FC File Offset: 0x000B68FC
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

		// Token: 0x04003534 RID: 13620
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003535 RID: 13621
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSDK.SDKKickDelegate__DelegateSignature";

		// Token: 0x04003536 RID: 13622
		private static int RegisterId;

		// Token: 0x02000CEE RID: 3310
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005F75 RID: 24437
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
