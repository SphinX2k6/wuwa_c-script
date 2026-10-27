using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001CA4 RID: 7332
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FSDKLogDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601C74C RID: 116556 RVA: 0x002A0D8A File Offset: 0x0029EF8A
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FSDKLogDelegate.StaticFunctionPtr();
		}

		// Token: 0x0601C74D RID: 116557 RVA: 0x002A0D96 File Offset: 0x0029EF96
		private static IntPtr StaticFunctionPtr()
		{
			if (FSDKLogDelegate._FunctionPtr == IntPtr.Zero)
			{
				FSDKLogDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroSDK.SDKLogDelegate__DelegateSignature");
			}
			return FSDKLogDelegate._FunctionPtr;
		}

		// Token: 0x0601C74E RID: 116558 RVA: 0x002A0DB9 File Offset: 0x0029EFB9
		public FSDKLogDelegate()
		{
		}

		// Token: 0x0601C74F RID: 116559 RVA: 0x002A0DC1 File Offset: 0x0029EFC1
		[NullableContext(2)]
		public FSDKLogDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601C750 RID: 116560 RVA: 0x002A0DCB File Offset: 0x0029EFCB
		public FSDKLogDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601C751 RID: 116561 RVA: 0x002A0DD6 File Offset: 0x0029EFD6
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<string>) ?? ((Action<string>)Delegate.CreateDelegate(typeof(Action<string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601C752 RID: 116562 RVA: 0x002A0E08 File Offset: 0x0029F008
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<string> Callback)
		{
			if (FSDKLogDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FSDKLogDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FSDKLogDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FSDKLogDelegate.OnScriptCallback));
				}
				FSDKLogDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FSDKLogDelegate.RegisterId);
		}

		// Token: 0x0601C753 RID: 116563 RVA: 0x002A0E42 File Offset: 0x0029F042
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<string> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601C754 RID: 116564 RVA: 0x002A0E4C File Offset: 0x0029F04C
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(string log)
		{
			FSDKLogDelegate.__FSDKLogDelegate_DelegateParams* ptr = stackalloc FSDKLogDelegate.__FSDKLogDelegate_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FSDKLogDelegate.__FSDKLogDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FSDKLogDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->log), log);
			base.BroadcastInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FSDKLogDelegate._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601C755 RID: 116565 RVA: 0x002A0EA0 File Offset: 0x0029F0A0
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
			string obj = FString.ToString((void*)(&((FSDKLogDelegate.__FSDKLogDelegate_DelegateParams*)__Parameters)->log));
			action(obj);
		}

		// Token: 0x0400F4CD RID: 62669
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400F4CE RID: 62670
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSDK.SDKLogDelegate__DelegateSignature";

		// Token: 0x0400F4CF RID: 62671
		private static int RegisterId;

		// Token: 0x0200327A RID: 12922
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FSDKLogDelegate_DelegateParams
		{
			// Token: 0x04017102 RID: 94466
			[FieldOffset(0)]
			public FString log;
		}

		// Token: 0x0200327B RID: 12923
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017103 RID: 94467
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
