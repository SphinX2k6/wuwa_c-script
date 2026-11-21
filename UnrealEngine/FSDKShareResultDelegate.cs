using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000549 RID: 1353
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FSDKShareResultDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06007D01 RID: 32001 RVA: 0x000B97CE File Offset: 0x000B79CE
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FSDKShareResultDelegate.StaticFunctionPtr();
		}

		// Token: 0x06007D02 RID: 32002 RVA: 0x000B97DA File Offset: 0x000B79DA
		private static IntPtr StaticFunctionPtr()
		{
			if (FSDKShareResultDelegate._FunctionPtr == IntPtr.Zero)
			{
				FSDKShareResultDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroSDK.SDKShareResultDelegate__DelegateSignature");
			}
			return FSDKShareResultDelegate._FunctionPtr;
		}

		// Token: 0x06007D03 RID: 32003 RVA: 0x000B97FD File Offset: 0x000B79FD
		public FSDKShareResultDelegate()
		{
		}

		// Token: 0x06007D04 RID: 32004 RVA: 0x000B9805 File Offset: 0x000B7A05
		[NullableContext(2)]
		public FSDKShareResultDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007D05 RID: 32005 RVA: 0x000B980F File Offset: 0x000B7A0F
		public FSDKShareResultDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007D06 RID: 32006 RVA: 0x000B981A File Offset: 0x000B7A1A
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<int, string, string>) ?? ((Action<int, string, string>)Delegate.CreateDelegate(typeof(Action<int, string, string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06007D07 RID: 32007 RVA: 0x000B984C File Offset: 0x000B7A4C
		[NullableContext(1)]
		public void Add(Action<int, string, string> Callback)
		{
			if (FSDKShareResultDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FSDKShareResultDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FSDKShareResultDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FSDKShareResultDelegate.OnScriptCallback));
				}
				FSDKShareResultDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FSDKShareResultDelegate.RegisterId);
		}

		// Token: 0x06007D08 RID: 32008 RVA: 0x000B9886 File Offset: 0x000B7A86
		[NullableContext(1)]
		public void Remove(Action<int, string, string> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06007D09 RID: 32009 RVA: 0x000B9890 File Offset: 0x000B7A90
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe void Broadcast(int code, string platform, string msg)
		{
			FSDKShareResultDelegate.__FSDKShareResultDelegate_DelegateParams* ptr = stackalloc FSDKShareResultDelegate.__FSDKShareResultDelegate_DelegateParams[(UIntPtr)55] + 15L / (long)sizeof(FSDKShareResultDelegate.__FSDKShareResultDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FSDKShareResultDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->code = code;
			FString.CopyFrom((void*)(&ptr->platform), platform);
			FString.CopyFrom((void*)(&ptr->msg), msg);
			base.BroadcastInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FSDKShareResultDelegate._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06007D0A RID: 32010 RVA: 0x000B98F8 File Offset: 0x000B7AF8
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int, string, string> action = target as Action<int, string, string>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			string arg = FString.ToString((void*)(&((FSDKShareResultDelegate.__FSDKShareResultDelegate_DelegateParams*)__Parameters)->platform));
			string arg2 = FString.ToString((void*)(&((FSDKShareResultDelegate.__FSDKShareResultDelegate_DelegateParams*)__Parameters)->msg));
			action(((FSDKShareResultDelegate.__FSDKShareResultDelegate_DelegateParams*)__Parameters)->code, arg, arg2);
		}

		// Token: 0x0400355B RID: 13659
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400355C RID: 13660
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSDK.SDKShareResultDelegate__DelegateSignature";

		// Token: 0x0400355D RID: 13661
		private static int RegisterId;

		// Token: 0x02000D06 RID: 3334
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		private ref struct __FSDKShareResultDelegate_DelegateParams
		{
			// Token: 0x04005F90 RID: 24464
			[FieldOffset(0)]
			public int code;

			// Token: 0x04005F91 RID: 24465
			[FieldOffset(8)]
			public FString platform;

			// Token: 0x04005F92 RID: 24466
			[FieldOffset(24)]
			public FString msg;
		}

		// Token: 0x02000D07 RID: 3335
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005F93 RID: 24467
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
