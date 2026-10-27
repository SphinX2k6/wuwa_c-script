using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001C9B RID: 7323
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FSDKExternalLoginDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601C6F2 RID: 116466 RVA: 0x002A00B2 File Offset: 0x0029E2B2
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FSDKExternalLoginDelegate.StaticFunctionPtr();
		}

		// Token: 0x0601C6F3 RID: 116467 RVA: 0x002A00BE File Offset: 0x0029E2BE
		private static IntPtr StaticFunctionPtr()
		{
			if (FSDKExternalLoginDelegate._FunctionPtr == IntPtr.Zero)
			{
				FSDKExternalLoginDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroSDK.SDKExternalLoginDelegate__DelegateSignature");
			}
			return FSDKExternalLoginDelegate._FunctionPtr;
		}

		// Token: 0x0601C6F4 RID: 116468 RVA: 0x002A00E1 File Offset: 0x0029E2E1
		public FSDKExternalLoginDelegate()
		{
		}

		// Token: 0x0601C6F5 RID: 116469 RVA: 0x002A00E9 File Offset: 0x0029E2E9
		[NullableContext(2)]
		public FSDKExternalLoginDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601C6F6 RID: 116470 RVA: 0x002A00F3 File Offset: 0x0029E2F3
		public FSDKExternalLoginDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601C6F7 RID: 116471 RVA: 0x002A00FE File Offset: 0x0029E2FE
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<bool, string>) ?? ((Action<bool, string>)Delegate.CreateDelegate(typeof(Action<bool, string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601C6F8 RID: 116472 RVA: 0x002A0130 File Offset: 0x0029E330
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0601C6F9 RID: 116473 RVA: 0x002A016A File Offset: 0x0029E36A
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<bool, string> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601C6FA RID: 116474 RVA: 0x002A0174 File Offset: 0x0029E374
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(bool result, string data)
		{
			FSDKExternalLoginDelegate.__FSDKExternalLoginDelegate_DelegateParams* ptr = stackalloc FSDKExternalLoginDelegate.__FSDKExternalLoginDelegate_DelegateParams[(UIntPtr)39] + 15L / (long)sizeof(FSDKExternalLoginDelegate.__FSDKExternalLoginDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FSDKExternalLoginDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->result = result;
			FString.CopyFrom((void*)(&ptr->data), data);
			base.BroadcastInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FSDKExternalLoginDelegate._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601C6FB RID: 116475 RVA: 0x002A01D0 File Offset: 0x0029E3D0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x0400F4B2 RID: 62642
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400F4B3 RID: 62643
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSDK.SDKExternalLoginDelegate__DelegateSignature";

		// Token: 0x0400F4B4 RID: 62644
		private static int RegisterId;

		// Token: 0x02003269 RID: 12905
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __FSDKExternalLoginDelegate_DelegateParams
		{
			// Token: 0x040170EA RID: 94442
			[FieldOffset(0)]
			public bool result;

			// Token: 0x040170EB RID: 94443
			[FieldOffset(8)]
			public FString data;
		}

		// Token: 0x0200326A RID: 12906
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040170EC RID: 94444
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
