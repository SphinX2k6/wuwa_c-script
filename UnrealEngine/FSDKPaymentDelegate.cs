using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000543 RID: 1347
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FSDKPaymentDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06007CC5 RID: 31941 RVA: 0x000B8FAA File Offset: 0x000B71AA
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FSDKPaymentDelegate.StaticFunctionPtr();
		}

		// Token: 0x06007CC6 RID: 31942 RVA: 0x000B8FB6 File Offset: 0x000B71B6
		private static IntPtr StaticFunctionPtr()
		{
			if (FSDKPaymentDelegate._FunctionPtr == IntPtr.Zero)
			{
				FSDKPaymentDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroSDK.SDKPaymentDelegate__DelegateSignature");
			}
			return FSDKPaymentDelegate._FunctionPtr;
		}

		// Token: 0x06007CC7 RID: 31943 RVA: 0x000B8FD9 File Offset: 0x000B71D9
		public FSDKPaymentDelegate()
		{
		}

		// Token: 0x06007CC8 RID: 31944 RVA: 0x000B8FE1 File Offset: 0x000B71E1
		[NullableContext(2)]
		public FSDKPaymentDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007CC9 RID: 31945 RVA: 0x000B8FEB File Offset: 0x000B71EB
		public FSDKPaymentDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007CCA RID: 31946 RVA: 0x000B8FF6 File Offset: 0x000B71F6
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<FPaymentStruct, string>) ?? ((Action<FPaymentStruct, string>)Delegate.CreateDelegate(typeof(Action<FPaymentStruct, string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06007CCB RID: 31947 RVA: 0x000B9028 File Offset: 0x000B7228
		[NullableContext(1)]
		public void Add(Action<FPaymentStruct, string> Callback)
		{
			if (FSDKPaymentDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FSDKPaymentDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FSDKPaymentDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FSDKPaymentDelegate.OnScriptCallback));
				}
				FSDKPaymentDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FSDKPaymentDelegate.RegisterId);
		}

		// Token: 0x06007CCC RID: 31948 RVA: 0x000B9062 File Offset: 0x000B7262
		[NullableContext(1)]
		public void Remove(Action<FPaymentStruct, string> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06007CCD RID: 31949 RVA: 0x000B906C File Offset: 0x000B726C
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe void Broadcast([Nullable(2)] FPaymentStruct PaymentInfo, string str)
		{
			FSDKPaymentDelegate.__FSDKPaymentDelegate_DelegateParams* ptr = stackalloc FSDKPaymentDelegate.__FSDKPaymentDelegate_DelegateParams[(UIntPtr)87] + 15L / (long)sizeof(FSDKPaymentDelegate.__FSDKPaymentDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FSDKPaymentDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			if (PaymentInfo != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPaymentStruct.StaticStruct(), &ptr->PaymentInfo, PaymentInfo.NativePtr, 1, false);
			}
			FString.CopyFrom((void*)(&ptr->str), str);
			base.BroadcastInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FSDKPaymentDelegate._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06007CCE RID: 31950 RVA: 0x000B90E4 File Offset: 0x000B72E4
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<FPaymentStruct, string> action = target as Action<FPaymentStruct, string>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			FPaymentStruct arg = new FPaymentStruct(&((FSDKPaymentDelegate.__FSDKPaymentDelegate_DelegateParams*)__Parameters)->PaymentInfo, true, true);
			string arg2 = FString.ToString((void*)(&((FSDKPaymentDelegate.__FSDKPaymentDelegate_DelegateParams*)__Parameters)->str));
			action(arg, arg2);
		}

		// Token: 0x04003549 RID: 13641
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400354A RID: 13642
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSDK.SDKPaymentDelegate__DelegateSignature";

		// Token: 0x0400354B RID: 13643
		private static int RegisterId;

		// Token: 0x02000CFA RID: 3322
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 72)]
		private ref struct __FSDKPaymentDelegate_DelegateParams
		{
			// Token: 0x04005F83 RID: 24451
			[FieldOffset(0)]
			public byte PaymentInfo;

			// Token: 0x04005F84 RID: 24452
			[FieldOffset(56)]
			public FString str;
		}

		// Token: 0x02000CFB RID: 3323
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005F85 RID: 24453
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
