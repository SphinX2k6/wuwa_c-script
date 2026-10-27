using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001004 RID: 4100
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FPlatformReceivedRemoteNotificationDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600DE04 RID: 56836 RVA: 0x001472E2 File Offset: 0x001454E2
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FPlatformReceivedRemoteNotificationDelegate.StaticFunctionPtr();
		}

		// Token: 0x0600DE05 RID: 56837 RVA: 0x001472EE File Offset: 0x001454EE
		private static IntPtr StaticFunctionPtr()
		{
			if (UPlatformGameInstance.__PlatformReceivedRemoteNotificationDelegate__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				UPlatformGameInstance.__PlatformReceivedRemoteNotificationDelegate__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.PlatformGameInstance:PlatformReceivedRemoteNotificationDelegate__DelegateSignature");
			}
			return UPlatformGameInstance.__PlatformReceivedRemoteNotificationDelegate__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0600DE06 RID: 56838 RVA: 0x00147311 File Offset: 0x00145511
		public FPlatformReceivedRemoteNotificationDelegate()
		{
		}

		// Token: 0x0600DE07 RID: 56839 RVA: 0x00147319 File Offset: 0x00145519
		[NullableContext(2)]
		public FPlatformReceivedRemoteNotificationDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600DE08 RID: 56840 RVA: 0x00147323 File Offset: 0x00145523
		public FPlatformReceivedRemoteNotificationDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600DE09 RID: 56841 RVA: 0x0014732E File Offset: 0x0014552E
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<string, TEnumAsByte<EApplicationState>>) ?? ((Action<string, TEnumAsByte<EApplicationState>>)Delegate.CreateDelegate(typeof(Action<string, TEnumAsByte<EApplicationState>>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600DE0A RID: 56842 RVA: 0x00147360 File Offset: 0x00145560
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			1,
			0
		})] Action<string, TEnumAsByte<EApplicationState>> Callback)
		{
			if (FPlatformReceivedRemoteNotificationDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FPlatformReceivedRemoteNotificationDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FPlatformReceivedRemoteNotificationDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FPlatformReceivedRemoteNotificationDelegate.OnScriptCallback));
				}
				FPlatformReceivedRemoteNotificationDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FPlatformReceivedRemoteNotificationDelegate.RegisterId);
		}

		// Token: 0x0600DE0B RID: 56843 RVA: 0x0014739A File Offset: 0x0014559A
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			1,
			0
		})] Action<string, TEnumAsByte<EApplicationState>> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0600DE0C RID: 56844 RVA: 0x001473A4 File Offset: 0x001455A4
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(string inString, EApplicationState inAppState)
		{
			FPlatformReceivedRemoteNotificationDelegate.__FPlatformReceivedRemoteNotificationDelegate_DelegateParams* ptr = stackalloc FPlatformReceivedRemoteNotificationDelegate.__FPlatformReceivedRemoteNotificationDelegate_DelegateParams[(UIntPtr)39] + 15L / (long)sizeof(FPlatformReceivedRemoteNotificationDelegate.__FPlatformReceivedRemoteNotificationDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FPlatformReceivedRemoteNotificationDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->inString), inString);
			ptr->inAppState = inAppState;
			base.BroadcastInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UPlatformGameInstance.__PlatformReceivedRemoteNotificationDelegate__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600DE0D RID: 56845 RVA: 0x00147404 File Offset: 0x00145604
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<string, TEnumAsByte<EApplicationState>> action = target as Action<string, TEnumAsByte<EApplicationState>>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			string arg = FString.ToString((void*)(&((FPlatformReceivedRemoteNotificationDelegate.__FPlatformReceivedRemoteNotificationDelegate_DelegateParams*)__Parameters)->inString));
			action(arg, ((FPlatformReceivedRemoteNotificationDelegate.__FPlatformReceivedRemoteNotificationDelegate_DelegateParams*)__Parameters)->inAppState);
		}

		// Token: 0x04007804 RID: 30724
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.PlatformGameInstance:PlatformReceivedRemoteNotificationDelegate__DelegateSignature";

		// Token: 0x04007805 RID: 30725
		private static int RegisterId;

		// Token: 0x02002DCD RID: 11725
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __FPlatformReceivedRemoteNotificationDelegate_DelegateParams
		{
			// Token: 0x0401680A RID: 92170
			[FieldOffset(0)]
			public FString inString;

			// Token: 0x0401680B RID: 92171
			[FieldOffset(16)]
			public TEnumAsByte<EApplicationState> inAppState;
		}

		// Token: 0x02002DCE RID: 11726
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401680C RID: 92172
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
