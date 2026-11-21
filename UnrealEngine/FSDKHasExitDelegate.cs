using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200053B RID: 1339
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FSDKHasExitDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06007C75 RID: 31861 RVA: 0x000B84E7 File Offset: 0x000B66E7
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FSDKHasExitDelegate.StaticFunctionPtr();
		}

		// Token: 0x06007C76 RID: 31862 RVA: 0x000B84F3 File Offset: 0x000B66F3
		private static IntPtr StaticFunctionPtr()
		{
			if (FSDKHasExitDelegate._FunctionPtr == IntPtr.Zero)
			{
				FSDKHasExitDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroSDK.SDKHasExitDelegate__DelegateSignature");
			}
			return FSDKHasExitDelegate._FunctionPtr;
		}

		// Token: 0x06007C77 RID: 31863 RVA: 0x000B8516 File Offset: 0x000B6716
		public FSDKHasExitDelegate()
		{
		}

		// Token: 0x06007C78 RID: 31864 RVA: 0x000B851E File Offset: 0x000B671E
		[NullableContext(2)]
		public FSDKHasExitDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007C79 RID: 31865 RVA: 0x000B8528 File Offset: 0x000B6728
		public FSDKHasExitDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007C7A RID: 31866 RVA: 0x000B8533 File Offset: 0x000B6733
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<byte>) ?? ((Action<byte>)Delegate.CreateDelegate(typeof(Action<byte>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06007C7B RID: 31867 RVA: 0x000B8565 File Offset: 0x000B6765
		[NullableContext(1)]
		public void Add(Action<byte> Callback)
		{
			if (FSDKHasExitDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FSDKHasExitDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FSDKHasExitDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FSDKHasExitDelegate.OnScriptCallback));
				}
				FSDKHasExitDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FSDKHasExitDelegate.RegisterId);
		}

		// Token: 0x06007C7C RID: 31868 RVA: 0x000B859F File Offset: 0x000B679F
		[NullableContext(1)]
		public void Remove(Action<byte> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06007C7D RID: 31869 RVA: 0x000B85A8 File Offset: 0x000B67A8
		[SkipLocalsInit]
		public unsafe void Broadcast(byte flagId)
		{
			FSDKHasExitDelegate.__FSDKHasExitDelegate_DelegateParams* ptr = stackalloc FSDKHasExitDelegate.__FSDKHasExitDelegate_DelegateParams[(UIntPtr)16] + 15L / (long)sizeof(FSDKHasExitDelegate.__FSDKHasExitDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FSDKHasExitDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->flagId = flagId;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x06007C7E RID: 31870 RVA: 0x000B85E4 File Offset: 0x000B67E4
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<byte> action = target as Action<byte>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FSDKHasExitDelegate.__FSDKHasExitDelegate_DelegateParams*)__Parameters)->flagId);
		}

		// Token: 0x04003531 RID: 13617
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003532 RID: 13618
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSDK.SDKHasExitDelegate__DelegateSignature";

		// Token: 0x04003533 RID: 13619
		private static int RegisterId;

		// Token: 0x02000CEC RID: 3308
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		private ref struct __FSDKHasExitDelegate_DelegateParams
		{
			// Token: 0x04005F73 RID: 24435
			[FieldOffset(0)]
			public byte flagId;
		}

		// Token: 0x02000CED RID: 3309
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005F74 RID: 24436
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
