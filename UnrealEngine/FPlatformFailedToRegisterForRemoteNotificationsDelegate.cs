using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000FFC RID: 4092
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FPlatformFailedToRegisterForRemoteNotificationsDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600DD8F RID: 56719 RVA: 0x00146368 File Offset: 0x00144568
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FPlatformFailedToRegisterForRemoteNotificationsDelegate.StaticFunctionPtr();
		}

		// Token: 0x0600DD90 RID: 56720 RVA: 0x00146374 File Offset: 0x00144574
		private static IntPtr StaticFunctionPtr()
		{
			if (UPlatformGameInstance.__PlatformFailedToRegisterForRemoteNotificationsDelegate__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				UPlatformGameInstance.__PlatformFailedToRegisterForRemoteNotificationsDelegate__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.PlatformGameInstance:PlatformFailedToRegisterForRemoteNotificationsDelegate__DelegateSignature");
			}
			return UPlatformGameInstance.__PlatformFailedToRegisterForRemoteNotificationsDelegate__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0600DD91 RID: 56721 RVA: 0x00146397 File Offset: 0x00144597
		public FPlatformFailedToRegisterForRemoteNotificationsDelegate()
		{
		}

		// Token: 0x0600DD92 RID: 56722 RVA: 0x0014639F File Offset: 0x0014459F
		[NullableContext(2)]
		public FPlatformFailedToRegisterForRemoteNotificationsDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600DD93 RID: 56723 RVA: 0x001463A9 File Offset: 0x001445A9
		public FPlatformFailedToRegisterForRemoteNotificationsDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600DD94 RID: 56724 RVA: 0x001463B4 File Offset: 0x001445B4
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<string>) ?? ((Action<string>)Delegate.CreateDelegate(typeof(Action<string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600DD95 RID: 56725 RVA: 0x001463E6 File Offset: 0x001445E6
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<string> Callback)
		{
			if (FPlatformFailedToRegisterForRemoteNotificationsDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FPlatformFailedToRegisterForRemoteNotificationsDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FPlatformFailedToRegisterForRemoteNotificationsDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FPlatformFailedToRegisterForRemoteNotificationsDelegate.OnScriptCallback));
				}
				FPlatformFailedToRegisterForRemoteNotificationsDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FPlatformFailedToRegisterForRemoteNotificationsDelegate.RegisterId);
		}

		// Token: 0x0600DD96 RID: 56726 RVA: 0x00146420 File Offset: 0x00144620
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<string> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0600DD97 RID: 56727 RVA: 0x0014642C File Offset: 0x0014462C
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(string inString)
		{
			FPlatformFailedToRegisterForRemoteNotificationsDelegate.__FPlatformFailedToRegisterForRemoteNotificationsDelegate_DelegateParams* ptr = stackalloc FPlatformFailedToRegisterForRemoteNotificationsDelegate.__FPlatformFailedToRegisterForRemoteNotificationsDelegate_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FPlatformFailedToRegisterForRemoteNotificationsDelegate.__FPlatformFailedToRegisterForRemoteNotificationsDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FPlatformFailedToRegisterForRemoteNotificationsDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->inString), inString);
			base.BroadcastInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UPlatformGameInstance.__PlatformFailedToRegisterForRemoteNotificationsDelegate__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600DD98 RID: 56728 RVA: 0x00146480 File Offset: 0x00144680
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
			string obj = FString.ToString((void*)(&((FPlatformFailedToRegisterForRemoteNotificationsDelegate.__FPlatformFailedToRegisterForRemoteNotificationsDelegate_DelegateParams*)__Parameters)->inString));
			action(obj);
		}

		// Token: 0x040077BA RID: 30650
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.PlatformGameInstance:PlatformFailedToRegisterForRemoteNotificationsDelegate__DelegateSignature";

		// Token: 0x040077BB RID: 30651
		private static int RegisterId;

		// Token: 0x02002DC4 RID: 11716
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FPlatformFailedToRegisterForRemoteNotificationsDelegate_DelegateParams
		{
			// Token: 0x040167FC RID: 92156
			[FieldOffset(0)]
			public FString inString;
		}

		// Token: 0x02002DC5 RID: 11717
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040167FD RID: 92157
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
