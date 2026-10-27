using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001003 RID: 4099
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FPlatformReceivedLocalNotificationDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600DDFA RID: 56826 RVA: 0x0014715B File Offset: 0x0014535B
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FPlatformReceivedLocalNotificationDelegate.StaticFunctionPtr();
		}

		// Token: 0x0600DDFB RID: 56827 RVA: 0x00147167 File Offset: 0x00145367
		private static IntPtr StaticFunctionPtr()
		{
			if (UPlatformGameInstance.__PlatformReceivedLocalNotificationDelegate__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				UPlatformGameInstance.__PlatformReceivedLocalNotificationDelegate__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.PlatformGameInstance:PlatformReceivedLocalNotificationDelegate__DelegateSignature");
			}
			return UPlatformGameInstance.__PlatformReceivedLocalNotificationDelegate__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0600DDFC RID: 56828 RVA: 0x0014718A File Offset: 0x0014538A
		public FPlatformReceivedLocalNotificationDelegate()
		{
		}

		// Token: 0x0600DDFD RID: 56829 RVA: 0x00147192 File Offset: 0x00145392
		[NullableContext(2)]
		public FPlatformReceivedLocalNotificationDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600DDFE RID: 56830 RVA: 0x0014719C File Offset: 0x0014539C
		public FPlatformReceivedLocalNotificationDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600DDFF RID: 56831 RVA: 0x001471A7 File Offset: 0x001453A7
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<string, int, TEnumAsByte<EApplicationState>>) ?? ((Action<string, int, TEnumAsByte<EApplicationState>>)Delegate.CreateDelegate(typeof(Action<string, int, TEnumAsByte<EApplicationState>>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600DE00 RID: 56832 RVA: 0x001471D9 File Offset: 0x001453D9
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			1,
			0
		})] Action<string, int, TEnumAsByte<EApplicationState>> Callback)
		{
			if (FPlatformReceivedLocalNotificationDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FPlatformReceivedLocalNotificationDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FPlatformReceivedLocalNotificationDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FPlatformReceivedLocalNotificationDelegate.OnScriptCallback));
				}
				FPlatformReceivedLocalNotificationDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FPlatformReceivedLocalNotificationDelegate.RegisterId);
		}

		// Token: 0x0600DE01 RID: 56833 RVA: 0x00147213 File Offset: 0x00145413
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			1,
			0
		})] Action<string, int, TEnumAsByte<EApplicationState>> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0600DE02 RID: 56834 RVA: 0x0014721C File Offset: 0x0014541C
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(string inString, int inInt, EApplicationState inAppState)
		{
			FPlatformReceivedLocalNotificationDelegate.__FPlatformReceivedLocalNotificationDelegate_DelegateParams* ptr = stackalloc FPlatformReceivedLocalNotificationDelegate.__FPlatformReceivedLocalNotificationDelegate_DelegateParams[(UIntPtr)39] + 15L / (long)sizeof(FPlatformReceivedLocalNotificationDelegate.__FPlatformReceivedLocalNotificationDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FPlatformReceivedLocalNotificationDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->inString), inString);
			ptr->inInt = inInt;
			ptr->inAppState = inAppState;
			base.BroadcastInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UPlatformGameInstance.__PlatformReceivedLocalNotificationDelegate__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600DE03 RID: 56835 RVA: 0x00147284 File Offset: 0x00145484
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<string, int, TEnumAsByte<EApplicationState>> action = target as Action<string, int, TEnumAsByte<EApplicationState>>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			string arg = FString.ToString((void*)(&((FPlatformReceivedLocalNotificationDelegate.__FPlatformReceivedLocalNotificationDelegate_DelegateParams*)__Parameters)->inString));
			action(arg, ((FPlatformReceivedLocalNotificationDelegate.__FPlatformReceivedLocalNotificationDelegate_DelegateParams*)__Parameters)->inInt, ((FPlatformReceivedLocalNotificationDelegate.__FPlatformReceivedLocalNotificationDelegate_DelegateParams*)__Parameters)->inAppState);
		}

		// Token: 0x04007802 RID: 30722
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.PlatformGameInstance:PlatformReceivedLocalNotificationDelegate__DelegateSignature";

		// Token: 0x04007803 RID: 30723
		private static int RegisterId;

		// Token: 0x02002DCB RID: 11723
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __FPlatformReceivedLocalNotificationDelegate_DelegateParams
		{
			// Token: 0x04016806 RID: 92166
			[FieldOffset(0)]
			public FString inString;

			// Token: 0x04016807 RID: 92167
			[FieldOffset(16)]
			public int inInt;

			// Token: 0x04016808 RID: 92168
			[FieldOffset(20)]
			public TEnumAsByte<EApplicationState> inAppState;
		}

		// Token: 0x02002DCC RID: 11724
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016809 RID: 92169
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
