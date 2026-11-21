using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000530 RID: 1328
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FSDKAnnounceRedPointDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06007C07 RID: 31751 RVA: 0x000B751E File Offset: 0x000B571E
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FSDKAnnounceRedPointDelegate.StaticFunctionPtr();
		}

		// Token: 0x06007C08 RID: 31752 RVA: 0x000B752A File Offset: 0x000B572A
		private static IntPtr StaticFunctionPtr()
		{
			if (FSDKAnnounceRedPointDelegate._FunctionPtr == IntPtr.Zero)
			{
				FSDKAnnounceRedPointDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroSDK.SDKAnnounceRedPointDelegate__DelegateSignature");
			}
			return FSDKAnnounceRedPointDelegate._FunctionPtr;
		}

		// Token: 0x06007C09 RID: 31753 RVA: 0x000B754D File Offset: 0x000B574D
		public FSDKAnnounceRedPointDelegate()
		{
		}

		// Token: 0x06007C0A RID: 31754 RVA: 0x000B7555 File Offset: 0x000B5755
		[NullableContext(2)]
		public FSDKAnnounceRedPointDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007C0B RID: 31755 RVA: 0x000B755F File Offset: 0x000B575F
		public FSDKAnnounceRedPointDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007C0C RID: 31756 RVA: 0x000B756A File Offset: 0x000B576A
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<string>) ?? ((Action<string>)Delegate.CreateDelegate(typeof(Action<string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06007C0D RID: 31757 RVA: 0x000B759C File Offset: 0x000B579C
		[NullableContext(1)]
		public void Add(Action<string> Callback)
		{
			if (FSDKAnnounceRedPointDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FSDKAnnounceRedPointDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FSDKAnnounceRedPointDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FSDKAnnounceRedPointDelegate.OnScriptCallback));
				}
				FSDKAnnounceRedPointDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FSDKAnnounceRedPointDelegate.RegisterId);
		}

		// Token: 0x06007C0E RID: 31758 RVA: 0x000B75D6 File Offset: 0x000B57D6
		[NullableContext(1)]
		public void Remove(Action<string> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06007C0F RID: 31759 RVA: 0x000B75E0 File Offset: 0x000B57E0
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe void Broadcast(string result)
		{
			FSDKAnnounceRedPointDelegate.__FSDKAnnounceRedPointDelegate_DelegateParams* ptr = stackalloc FSDKAnnounceRedPointDelegate.__FSDKAnnounceRedPointDelegate_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FSDKAnnounceRedPointDelegate.__FSDKAnnounceRedPointDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FSDKAnnounceRedPointDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->result), result);
			base.BroadcastInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FSDKAnnounceRedPointDelegate._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06007C10 RID: 31760 RVA: 0x000B7634 File Offset: 0x000B5834
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<string> action = target as Action<string>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			string obj = FString.ToString((void*)(&((FSDKAnnounceRedPointDelegate.__FSDKAnnounceRedPointDelegate_DelegateParams*)__Parameters)->result));
			action(obj);
		}

		// Token: 0x04003510 RID: 13584
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003511 RID: 13585
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSDK.SDKAnnounceRedPointDelegate__DelegateSignature";

		// Token: 0x04003512 RID: 13586
		private static int RegisterId;

		// Token: 0x02000CD7 RID: 3287
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		private ref struct __FSDKAnnounceRedPointDelegate_DelegateParams
		{
			// Token: 0x04005F57 RID: 24407
			[FieldOffset(0)]
			public FString result;
		}

		// Token: 0x02000CD8 RID: 3288
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005F58 RID: 24408
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
