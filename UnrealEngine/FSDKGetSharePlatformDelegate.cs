using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001CA1 RID: 7329
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FSDKGetSharePlatformDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601C72E RID: 116526 RVA: 0x002A09A1 File Offset: 0x0029EBA1
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FSDKGetSharePlatformDelegate.StaticFunctionPtr();
		}

		// Token: 0x0601C72F RID: 116527 RVA: 0x002A09AD File Offset: 0x0029EBAD
		private static IntPtr StaticFunctionPtr()
		{
			if (FSDKGetSharePlatformDelegate._FunctionPtr == IntPtr.Zero)
			{
				FSDKGetSharePlatformDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroSDK.SDKGetSharePlatformDelegate__DelegateSignature");
			}
			return FSDKGetSharePlatformDelegate._FunctionPtr;
		}

		// Token: 0x0601C730 RID: 116528 RVA: 0x002A09D0 File Offset: 0x0029EBD0
		public FSDKGetSharePlatformDelegate()
		{
		}

		// Token: 0x0601C731 RID: 116529 RVA: 0x002A09D8 File Offset: 0x0029EBD8
		[NullableContext(2)]
		public FSDKGetSharePlatformDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601C732 RID: 116530 RVA: 0x002A09E2 File Offset: 0x0029EBE2
		public FSDKGetSharePlatformDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601C733 RID: 116531 RVA: 0x002A09ED File Offset: 0x0029EBED
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<int, string, string>) ?? ((Action<int, string, string>)Delegate.CreateDelegate(typeof(Action<int, string, string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601C734 RID: 116532 RVA: 0x002A0A1F File Offset: 0x0029EC1F
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<int, string, string> Callback)
		{
			if (FSDKGetSharePlatformDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FSDKGetSharePlatformDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FSDKGetSharePlatformDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FSDKGetSharePlatformDelegate.OnScriptCallback));
				}
				FSDKGetSharePlatformDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FSDKGetSharePlatformDelegate.RegisterId);
		}

		// Token: 0x0601C735 RID: 116533 RVA: 0x002A0A59 File Offset: 0x0029EC59
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<int, string, string> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601C736 RID: 116534 RVA: 0x002A0A64 File Offset: 0x0029EC64
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(int code, string value, string msg)
		{
			FSDKGetSharePlatformDelegate.__FSDKGetSharePlatformDelegate_DelegateParams* ptr = stackalloc FSDKGetSharePlatformDelegate.__FSDKGetSharePlatformDelegate_DelegateParams[(UIntPtr)55] + 15L / (long)sizeof(FSDKGetSharePlatformDelegate.__FSDKGetSharePlatformDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FSDKGetSharePlatformDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->code = code;
			FString.CopyFrom((void*)(&ptr->value), value);
			FString.CopyFrom((void*)(&ptr->msg), msg);
			base.BroadcastInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FSDKGetSharePlatformDelegate._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601C737 RID: 116535 RVA: 0x002A0ACC File Offset: 0x0029ECCC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int, string, string> action = target as Action<int, string, string>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			string arg = FString.ToString((void*)(&((FSDKGetSharePlatformDelegate.__FSDKGetSharePlatformDelegate_DelegateParams*)__Parameters)->value));
			string arg2 = FString.ToString((void*)(&((FSDKGetSharePlatformDelegate.__FSDKGetSharePlatformDelegate_DelegateParams*)__Parameters)->msg));
			action(((FSDKGetSharePlatformDelegate.__FSDKGetSharePlatformDelegate_DelegateParams*)__Parameters)->code, arg, arg2);
		}

		// Token: 0x0400F4C4 RID: 62660
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400F4C5 RID: 62661
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSDK.SDKGetSharePlatformDelegate__DelegateSignature";

		// Token: 0x0400F4C6 RID: 62662
		private static int RegisterId;

		// Token: 0x02003275 RID: 12917
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __FSDKGetSharePlatformDelegate_DelegateParams
		{
			// Token: 0x040170FB RID: 94459
			[FieldOffset(0)]
			public int code;

			// Token: 0x040170FC RID: 94460
			[FieldOffset(8)]
			public FString value;

			// Token: 0x040170FD RID: 94461
			[FieldOffset(24)]
			public FString msg;
		}

		// Token: 0x02003276 RID: 12918
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040170FE RID: 94462
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
