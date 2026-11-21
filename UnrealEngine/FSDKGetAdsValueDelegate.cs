using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000538 RID: 1336
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FSDKGetAdsValueDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06007C57 RID: 31831 RVA: 0x000B804E File Offset: 0x000B624E
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FSDKGetAdsValueDelegate.StaticFunctionPtr();
		}

		// Token: 0x06007C58 RID: 31832 RVA: 0x000B805A File Offset: 0x000B625A
		private static IntPtr StaticFunctionPtr()
		{
			if (FSDKGetAdsValueDelegate._FunctionPtr == IntPtr.Zero)
			{
				FSDKGetAdsValueDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroSDK.SDKGetAdsValueDelegate__DelegateSignature");
			}
			return FSDKGetAdsValueDelegate._FunctionPtr;
		}

		// Token: 0x06007C59 RID: 31833 RVA: 0x000B807D File Offset: 0x000B627D
		public FSDKGetAdsValueDelegate()
		{
		}

		// Token: 0x06007C5A RID: 31834 RVA: 0x000B8085 File Offset: 0x000B6285
		[NullableContext(2)]
		public FSDKGetAdsValueDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007C5B RID: 31835 RVA: 0x000B808F File Offset: 0x000B628F
		public FSDKGetAdsValueDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007C5C RID: 31836 RVA: 0x000B809A File Offset: 0x000B629A
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<string, string>) ?? ((Action<string, string>)Delegate.CreateDelegate(typeof(Action<string, string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06007C5D RID: 31837 RVA: 0x000B80CC File Offset: 0x000B62CC
		[NullableContext(1)]
		public void Add(Action<string, string> Callback)
		{
			if (FSDKGetAdsValueDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FSDKGetAdsValueDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FSDKGetAdsValueDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FSDKGetAdsValueDelegate.OnScriptCallback));
				}
				FSDKGetAdsValueDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FSDKGetAdsValueDelegate.RegisterId);
		}

		// Token: 0x06007C5E RID: 31838 RVA: 0x000B8106 File Offset: 0x000B6306
		[NullableContext(1)]
		public void Remove(Action<string, string> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06007C5F RID: 31839 RVA: 0x000B8110 File Offset: 0x000B6310
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe void Broadcast(string source, string result)
		{
			FSDKGetAdsValueDelegate.__FSDKGetAdsValueDelegate_DelegateParams* ptr = stackalloc FSDKGetAdsValueDelegate.__FSDKGetAdsValueDelegate_DelegateParams[(UIntPtr)47] + 15L / (long)sizeof(FSDKGetAdsValueDelegate.__FSDKGetAdsValueDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FSDKGetAdsValueDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->source), source);
			FString.CopyFrom((void*)(&ptr->result), result);
			base.BroadcastInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FSDKGetAdsValueDelegate._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06007C60 RID: 31840 RVA: 0x000B8170 File Offset: 0x000B6370
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<string, string> action = target as Action<string, string>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			string arg = FString.ToString((void*)(&((FSDKGetAdsValueDelegate.__FSDKGetAdsValueDelegate_DelegateParams*)__Parameters)->source));
			string arg2 = FString.ToString((void*)(&((FSDKGetAdsValueDelegate.__FSDKGetAdsValueDelegate_DelegateParams*)__Parameters)->result));
			action(arg, arg2);
		}

		// Token: 0x04003528 RID: 13608
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003529 RID: 13609
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSDK.SDKGetAdsValueDelegate__DelegateSignature";

		// Token: 0x0400352A RID: 13610
		private static int RegisterId;

		// Token: 0x02000CE6 RID: 3302
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		private ref struct __FSDKGetAdsValueDelegate_DelegateParams
		{
			// Token: 0x04005F69 RID: 24425
			[FieldOffset(0)]
			public FString source;

			// Token: 0x04005F6A RID: 24426
			[FieldOffset(16)]
			public FString result;
		}

		// Token: 0x02000CE7 RID: 3303
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005F6B RID: 24427
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
