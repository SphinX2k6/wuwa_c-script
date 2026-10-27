using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001CAA RID: 7338
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FSDKPaymentDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601C788 RID: 116616 RVA: 0x002A15F6 File Offset: 0x0029F7F6
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FSDKPaymentDelegate.StaticFunctionPtr();
		}

		// Token: 0x0601C789 RID: 116617 RVA: 0x002A1602 File Offset: 0x0029F802
		private static IntPtr StaticFunctionPtr()
		{
			if (FSDKPaymentDelegate._FunctionPtr == IntPtr.Zero)
			{
				FSDKPaymentDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroSDK.SDKPaymentDelegate__DelegateSignature");
			}
			return FSDKPaymentDelegate._FunctionPtr;
		}

		// Token: 0x0601C78A RID: 116618 RVA: 0x002A1625 File Offset: 0x0029F825
		public FSDKPaymentDelegate()
		{
		}

		// Token: 0x0601C78B RID: 116619 RVA: 0x002A162D File Offset: 0x0029F82D
		[NullableContext(2)]
		public FSDKPaymentDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601C78C RID: 116620 RVA: 0x002A1637 File Offset: 0x0029F837
		public FSDKPaymentDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601C78D RID: 116621 RVA: 0x002A1642 File Offset: 0x0029F842
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<FPaymentStruct, string>) ?? ((Action<FPaymentStruct, string>)Delegate.CreateDelegate(typeof(Action<FPaymentStruct, string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601C78E RID: 116622 RVA: 0x002A1674 File Offset: 0x0029F874
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0601C78F RID: 116623 RVA: 0x002A16AE File Offset: 0x0029F8AE
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<FPaymentStruct, string> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601C790 RID: 116624 RVA: 0x002A16B8 File Offset: 0x0029F8B8
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0601C791 RID: 116625 RVA: 0x002A1730 File Offset: 0x0029F930
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x0400F4DF RID: 62687
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400F4E0 RID: 62688
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSDK.SDKPaymentDelegate__DelegateSignature";

		// Token: 0x0400F4E1 RID: 62689
		private static int RegisterId;

		// Token: 0x02003285 RID: 12933
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 72)]
		protected ref struct __FSDKPaymentDelegate_DelegateParams
		{
			// Token: 0x0401710F RID: 94479
			[FieldOffset(0)]
			public byte PaymentInfo;

			// Token: 0x04017110 RID: 94480
			[FieldOffset(56)]
			public FString str;
		}

		// Token: 0x02003286 RID: 12934
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017111 RID: 94481
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
