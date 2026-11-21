using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000532 RID: 1330
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FSDKDeepLinkDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06007C1B RID: 31771 RVA: 0x000B77EE File Offset: 0x000B59EE
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FSDKDeepLinkDelegate.StaticFunctionPtr();
		}

		// Token: 0x06007C1C RID: 31772 RVA: 0x000B77FA File Offset: 0x000B59FA
		private static IntPtr StaticFunctionPtr()
		{
			if (FSDKDeepLinkDelegate._FunctionPtr == IntPtr.Zero)
			{
				FSDKDeepLinkDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroSDK.SDKDeepLinkDelegate__DelegateSignature");
			}
			return FSDKDeepLinkDelegate._FunctionPtr;
		}

		// Token: 0x06007C1D RID: 31773 RVA: 0x000B781D File Offset: 0x000B5A1D
		public FSDKDeepLinkDelegate()
		{
		}

		// Token: 0x06007C1E RID: 31774 RVA: 0x000B7825 File Offset: 0x000B5A25
		[NullableContext(2)]
		public FSDKDeepLinkDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007C1F RID: 31775 RVA: 0x000B782F File Offset: 0x000B5A2F
		public FSDKDeepLinkDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007C20 RID: 31776 RVA: 0x000B783A File Offset: 0x000B5A3A
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<string>) ?? ((Action<string>)Delegate.CreateDelegate(typeof(Action<string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06007C21 RID: 31777 RVA: 0x000B786C File Offset: 0x000B5A6C
		[NullableContext(1)]
		public void Add(Action<string> Callback)
		{
			if (FSDKDeepLinkDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FSDKDeepLinkDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FSDKDeepLinkDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FSDKDeepLinkDelegate.OnScriptCallback));
				}
				FSDKDeepLinkDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FSDKDeepLinkDelegate.RegisterId);
		}

		// Token: 0x06007C22 RID: 31778 RVA: 0x000B78A6 File Offset: 0x000B5AA6
		[NullableContext(1)]
		public void Remove(Action<string> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06007C23 RID: 31779 RVA: 0x000B78B0 File Offset: 0x000B5AB0
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe void Broadcast(string result)
		{
			FSDKDeepLinkDelegate.__FSDKDeepLinkDelegate_DelegateParams* ptr = stackalloc FSDKDeepLinkDelegate.__FSDKDeepLinkDelegate_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FSDKDeepLinkDelegate.__FSDKDeepLinkDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FSDKDeepLinkDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->result), result);
			base.BroadcastInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FSDKDeepLinkDelegate._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06007C24 RID: 31780 RVA: 0x000B7904 File Offset: 0x000B5B04
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<string> action = target as Action<string>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			string obj = FString.ToString((void*)(&((FSDKDeepLinkDelegate.__FSDKDeepLinkDelegate_DelegateParams*)__Parameters)->result));
			action(obj);
		}

		// Token: 0x04003516 RID: 13590
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003517 RID: 13591
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSDK.SDKDeepLinkDelegate__DelegateSignature";

		// Token: 0x04003518 RID: 13592
		private static int RegisterId;

		// Token: 0x02000CDB RID: 3291
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		private ref struct __FSDKDeepLinkDelegate_DelegateParams
		{
			// Token: 0x04005F5B RID: 24411
			[FieldOffset(0)]
			public FString result;
		}

		// Token: 0x02000CDC RID: 3292
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005F5C RID: 24412
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
