using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200052F RID: 1327
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FSDKAnnounceOpenDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06007BFD RID: 31741 RVA: 0x000B73B6 File Offset: 0x000B55B6
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FSDKAnnounceOpenDelegate.StaticFunctionPtr();
		}

		// Token: 0x06007BFE RID: 31742 RVA: 0x000B73C2 File Offset: 0x000B55C2
		private static IntPtr StaticFunctionPtr()
		{
			if (FSDKAnnounceOpenDelegate._FunctionPtr == IntPtr.Zero)
			{
				FSDKAnnounceOpenDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroSDK.SDKAnnounceOpenDelegate__DelegateSignature");
			}
			return FSDKAnnounceOpenDelegate._FunctionPtr;
		}

		// Token: 0x06007BFF RID: 31743 RVA: 0x000B73E5 File Offset: 0x000B55E5
		public FSDKAnnounceOpenDelegate()
		{
		}

		// Token: 0x06007C00 RID: 31744 RVA: 0x000B73ED File Offset: 0x000B55ED
		[NullableContext(2)]
		public FSDKAnnounceOpenDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007C01 RID: 31745 RVA: 0x000B73F7 File Offset: 0x000B55F7
		public FSDKAnnounceOpenDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007C02 RID: 31746 RVA: 0x000B7402 File Offset: 0x000B5602
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<string>) ?? ((Action<string>)Delegate.CreateDelegate(typeof(Action<string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06007C03 RID: 31747 RVA: 0x000B7434 File Offset: 0x000B5634
		[NullableContext(1)]
		public void Add(Action<string> Callback)
		{
			if (FSDKAnnounceOpenDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FSDKAnnounceOpenDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FSDKAnnounceOpenDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FSDKAnnounceOpenDelegate.OnScriptCallback));
				}
				FSDKAnnounceOpenDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FSDKAnnounceOpenDelegate.RegisterId);
		}

		// Token: 0x06007C04 RID: 31748 RVA: 0x000B746E File Offset: 0x000B566E
		[NullableContext(1)]
		public void Remove(Action<string> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06007C05 RID: 31749 RVA: 0x000B7478 File Offset: 0x000B5678
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe void Broadcast(string result)
		{
			FSDKAnnounceOpenDelegate.__FSDKAnnounceOpenDelegate_DelegateParams* ptr = stackalloc FSDKAnnounceOpenDelegate.__FSDKAnnounceOpenDelegate_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FSDKAnnounceOpenDelegate.__FSDKAnnounceOpenDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FSDKAnnounceOpenDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->result), result);
			base.BroadcastInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FSDKAnnounceOpenDelegate._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06007C06 RID: 31750 RVA: 0x000B74CC File Offset: 0x000B56CC
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<string> action = target as Action<string>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			string obj = FString.ToString((void*)(&((FSDKAnnounceOpenDelegate.__FSDKAnnounceOpenDelegate_DelegateParams*)__Parameters)->result));
			action(obj);
		}

		// Token: 0x0400350D RID: 13581
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400350E RID: 13582
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSDK.SDKAnnounceOpenDelegate__DelegateSignature";

		// Token: 0x0400350F RID: 13583
		private static int RegisterId;

		// Token: 0x02000CD5 RID: 3285
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		private ref struct __FSDKAnnounceOpenDelegate_DelegateParams
		{
			// Token: 0x04005F55 RID: 24405
			[FieldOffset(0)]
			public FString result;
		}

		// Token: 0x02000CD6 RID: 3286
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005F56 RID: 24406
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
