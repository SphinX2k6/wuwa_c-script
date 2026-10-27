using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001C99 RID: 7321
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FSDKDeepLinkDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601C6DE RID: 116446 RVA: 0x0029FE3A File Offset: 0x0029E03A
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FSDKDeepLinkDelegate.StaticFunctionPtr();
		}

		// Token: 0x0601C6DF RID: 116447 RVA: 0x0029FE46 File Offset: 0x0029E046
		private static IntPtr StaticFunctionPtr()
		{
			if (FSDKDeepLinkDelegate._FunctionPtr == IntPtr.Zero)
			{
				FSDKDeepLinkDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroSDK.SDKDeepLinkDelegate__DelegateSignature");
			}
			return FSDKDeepLinkDelegate._FunctionPtr;
		}

		// Token: 0x0601C6E0 RID: 116448 RVA: 0x0029FE69 File Offset: 0x0029E069
		public FSDKDeepLinkDelegate()
		{
		}

		// Token: 0x0601C6E1 RID: 116449 RVA: 0x0029FE71 File Offset: 0x0029E071
		[NullableContext(2)]
		public FSDKDeepLinkDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601C6E2 RID: 116450 RVA: 0x0029FE7B File Offset: 0x0029E07B
		public FSDKDeepLinkDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601C6E3 RID: 116451 RVA: 0x0029FE86 File Offset: 0x0029E086
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<string>) ?? ((Action<string>)Delegate.CreateDelegate(typeof(Action<string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601C6E4 RID: 116452 RVA: 0x0029FEB8 File Offset: 0x0029E0B8
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0601C6E5 RID: 116453 RVA: 0x0029FEF2 File Offset: 0x0029E0F2
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<string> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601C6E6 RID: 116454 RVA: 0x0029FEFC File Offset: 0x0029E0FC
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(string result)
		{
			FSDKDeepLinkDelegate.__FSDKDeepLinkDelegate_DelegateParams* ptr = stackalloc FSDKDeepLinkDelegate.__FSDKDeepLinkDelegate_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FSDKDeepLinkDelegate.__FSDKDeepLinkDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FSDKDeepLinkDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->result), result);
			base.BroadcastInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FSDKDeepLinkDelegate._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601C6E7 RID: 116455 RVA: 0x0029FF50 File Offset: 0x0029E150
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x0400F4AC RID: 62636
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400F4AD RID: 62637
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSDK.SDKDeepLinkDelegate__DelegateSignature";

		// Token: 0x0400F4AE RID: 62638
		private static int RegisterId;

		// Token: 0x02003266 RID: 12902
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FSDKDeepLinkDelegate_DelegateParams
		{
			// Token: 0x040170E7 RID: 94439
			[FieldOffset(0)]
			public FString result;
		}

		// Token: 0x02003267 RID: 12903
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040170E8 RID: 94440
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
