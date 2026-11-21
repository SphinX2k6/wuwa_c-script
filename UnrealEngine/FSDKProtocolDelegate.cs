using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000546 RID: 1350
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FSDKProtocolDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06007CE3 RID: 31971 RVA: 0x000B93F6 File Offset: 0x000B75F6
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FSDKProtocolDelegate.StaticFunctionPtr();
		}

		// Token: 0x06007CE4 RID: 31972 RVA: 0x000B9402 File Offset: 0x000B7602
		private static IntPtr StaticFunctionPtr()
		{
			if (FSDKProtocolDelegate._FunctionPtr == IntPtr.Zero)
			{
				FSDKProtocolDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroSDK.SDKProtocolDelegate__DelegateSignature");
			}
			return FSDKProtocolDelegate._FunctionPtr;
		}

		// Token: 0x06007CE5 RID: 31973 RVA: 0x000B9425 File Offset: 0x000B7625
		public FSDKProtocolDelegate()
		{
		}

		// Token: 0x06007CE6 RID: 31974 RVA: 0x000B942D File Offset: 0x000B762D
		[NullableContext(2)]
		public FSDKProtocolDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007CE7 RID: 31975 RVA: 0x000B9437 File Offset: 0x000B7637
		public FSDKProtocolDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007CE8 RID: 31976 RVA: 0x000B9442 File Offset: 0x000B7642
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<bool>) ?? ((Action<bool>)Delegate.CreateDelegate(typeof(Action<bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06007CE9 RID: 31977 RVA: 0x000B9474 File Offset: 0x000B7674
		[NullableContext(1)]
		public void Add(Action<bool> Callback)
		{
			if (FSDKProtocolDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FSDKProtocolDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FSDKProtocolDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FSDKProtocolDelegate.OnScriptCallback));
				}
				FSDKProtocolDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FSDKProtocolDelegate.RegisterId);
		}

		// Token: 0x06007CEA RID: 31978 RVA: 0x000B94AE File Offset: 0x000B76AE
		[NullableContext(1)]
		public void Remove(Action<bool> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06007CEB RID: 31979 RVA: 0x000B94B8 File Offset: 0x000B76B8
		[SkipLocalsInit]
		public unsafe void Broadcast(bool result)
		{
			FSDKProtocolDelegate.__FSDKProtocolDelegate_DelegateParams* ptr = stackalloc FSDKProtocolDelegate.__FSDKProtocolDelegate_DelegateParams[(UIntPtr)16] + 15L / (long)sizeof(FSDKProtocolDelegate.__FSDKProtocolDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FSDKProtocolDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->result = result;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x06007CEC RID: 31980 RVA: 0x000B94F4 File Offset: 0x000B76F4
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<bool> action = target as Action<bool>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FSDKProtocolDelegate.__FSDKProtocolDelegate_DelegateParams*)__Parameters)->result);
		}

		// Token: 0x04003552 RID: 13650
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003553 RID: 13651
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSDK.SDKProtocolDelegate__DelegateSignature";

		// Token: 0x04003554 RID: 13652
		private static int RegisterId;

		// Token: 0x02000D00 RID: 3328
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		private ref struct __FSDKProtocolDelegate_DelegateParams
		{
			// Token: 0x04005F8A RID: 24458
			[FieldOffset(0)]
			public bool result;
		}

		// Token: 0x02000D01 RID: 3329
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005F8B RID: 24459
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
