using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001C9F RID: 7327
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FSDKGetAdsValueDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601C71A RID: 116506 RVA: 0x002A069A File Offset: 0x0029E89A
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FSDKGetAdsValueDelegate.StaticFunctionPtr();
		}

		// Token: 0x0601C71B RID: 116507 RVA: 0x002A06A6 File Offset: 0x0029E8A6
		private static IntPtr StaticFunctionPtr()
		{
			if (FSDKGetAdsValueDelegate._FunctionPtr == IntPtr.Zero)
			{
				FSDKGetAdsValueDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroSDK.SDKGetAdsValueDelegate__DelegateSignature");
			}
			return FSDKGetAdsValueDelegate._FunctionPtr;
		}

		// Token: 0x0601C71C RID: 116508 RVA: 0x002A06C9 File Offset: 0x0029E8C9
		public FSDKGetAdsValueDelegate()
		{
		}

		// Token: 0x0601C71D RID: 116509 RVA: 0x002A06D1 File Offset: 0x0029E8D1
		[NullableContext(2)]
		public FSDKGetAdsValueDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601C71E RID: 116510 RVA: 0x002A06DB File Offset: 0x0029E8DB
		public FSDKGetAdsValueDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601C71F RID: 116511 RVA: 0x002A06E6 File Offset: 0x0029E8E6
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<string, string>) ?? ((Action<string, string>)Delegate.CreateDelegate(typeof(Action<string, string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601C720 RID: 116512 RVA: 0x002A0718 File Offset: 0x0029E918
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0601C721 RID: 116513 RVA: 0x002A0752 File Offset: 0x0029E952
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<string, string> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601C722 RID: 116514 RVA: 0x002A075C File Offset: 0x0029E95C
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(string source, string result)
		{
			FSDKGetAdsValueDelegate.__FSDKGetAdsValueDelegate_DelegateParams* ptr = stackalloc FSDKGetAdsValueDelegate.__FSDKGetAdsValueDelegate_DelegateParams[(UIntPtr)47] + 15L / (long)sizeof(FSDKGetAdsValueDelegate.__FSDKGetAdsValueDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FSDKGetAdsValueDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->source), source);
			FString.CopyFrom((void*)(&ptr->result), result);
			base.BroadcastInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FSDKGetAdsValueDelegate._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601C723 RID: 116515 RVA: 0x002A07BC File Offset: 0x0029E9BC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x0400F4BE RID: 62654
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400F4BF RID: 62655
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSDK.SDKGetAdsValueDelegate__DelegateSignature";

		// Token: 0x0400F4C0 RID: 62656
		private static int RegisterId;

		// Token: 0x02003271 RID: 12913
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __FSDKGetAdsValueDelegate_DelegateParams
		{
			// Token: 0x040170F5 RID: 94453
			[FieldOffset(0)]
			public FString source;

			// Token: 0x040170F6 RID: 94454
			[FieldOffset(16)]
			public FString result;
		}

		// Token: 0x02003272 RID: 12914
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040170F7 RID: 94455
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
