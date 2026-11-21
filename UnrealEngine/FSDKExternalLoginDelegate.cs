using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000534 RID: 1332
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FSDKExternalLoginDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06007C2F RID: 31791 RVA: 0x000B7A66 File Offset: 0x000B5C66
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FSDKExternalLoginDelegate.StaticFunctionPtr();
		}

		// Token: 0x06007C30 RID: 31792 RVA: 0x000B7A72 File Offset: 0x000B5C72
		private static IntPtr StaticFunctionPtr()
		{
			if (FSDKExternalLoginDelegate._FunctionPtr == IntPtr.Zero)
			{
				FSDKExternalLoginDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroSDK.SDKExternalLoginDelegate__DelegateSignature");
			}
			return FSDKExternalLoginDelegate._FunctionPtr;
		}

		// Token: 0x06007C31 RID: 31793 RVA: 0x000B7A95 File Offset: 0x000B5C95
		public FSDKExternalLoginDelegate()
		{
		}

		// Token: 0x06007C32 RID: 31794 RVA: 0x000B7A9D File Offset: 0x000B5C9D
		[NullableContext(2)]
		public FSDKExternalLoginDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007C33 RID: 31795 RVA: 0x000B7AA7 File Offset: 0x000B5CA7
		public FSDKExternalLoginDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007C34 RID: 31796 RVA: 0x000B7AB2 File Offset: 0x000B5CB2
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<bool, string>) ?? ((Action<bool, string>)Delegate.CreateDelegate(typeof(Action<bool, string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06007C35 RID: 31797 RVA: 0x000B7AE4 File Offset: 0x000B5CE4
		[NullableContext(1)]
		public void Add(Action<bool, string> Callback)
		{
			if (FSDKExternalLoginDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FSDKExternalLoginDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FSDKExternalLoginDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FSDKExternalLoginDelegate.OnScriptCallback));
				}
				FSDKExternalLoginDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FSDKExternalLoginDelegate.RegisterId);
		}

		// Token: 0x06007C36 RID: 31798 RVA: 0x000B7B1E File Offset: 0x000B5D1E
		[NullableContext(1)]
		public void Remove(Action<bool, string> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06007C37 RID: 31799 RVA: 0x000B7B28 File Offset: 0x000B5D28
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe void Broadcast(bool result, string data)
		{
			FSDKExternalLoginDelegate.__FSDKExternalLoginDelegate_DelegateParams* ptr = stackalloc FSDKExternalLoginDelegate.__FSDKExternalLoginDelegate_DelegateParams[(UIntPtr)39] + 15L / (long)sizeof(FSDKExternalLoginDelegate.__FSDKExternalLoginDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FSDKExternalLoginDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->result = result;
			FString.CopyFrom((void*)(&ptr->data), data);
			base.BroadcastInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FSDKExternalLoginDelegate._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06007C38 RID: 31800 RVA: 0x000B7B84 File Offset: 0x000B5D84
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<bool, string> action = target as Action<bool, string>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			string arg = FString.ToString((void*)(&((FSDKExternalLoginDelegate.__FSDKExternalLoginDelegate_DelegateParams*)__Parameters)->data));
			action(((FSDKExternalLoginDelegate.__FSDKExternalLoginDelegate_DelegateParams*)__Parameters)->result, arg);
		}

		// Token: 0x0400351C RID: 13596
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400351D RID: 13597
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSDK.SDKExternalLoginDelegate__DelegateSignature";

		// Token: 0x0400351E RID: 13598
		private static int RegisterId;

		// Token: 0x02000CDE RID: 3294
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		private ref struct __FSDKExternalLoginDelegate_DelegateParams
		{
			// Token: 0x04005F5E RID: 24414
			[FieldOffset(0)]
			public bool result;

			// Token: 0x04005F5F RID: 24415
			[FieldOffset(8)]
			public FString data;
		}

		// Token: 0x02000CDF RID: 3295
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005F60 RID: 24416
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
