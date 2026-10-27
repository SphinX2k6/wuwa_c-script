using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001006 RID: 4102
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FPlatformRegisteredForUserNotificationsDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600DE18 RID: 56856 RVA: 0x001475FF File Offset: 0x001457FF
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FPlatformRegisteredForUserNotificationsDelegate.StaticFunctionPtr();
		}

		// Token: 0x0600DE19 RID: 56857 RVA: 0x0014760B File Offset: 0x0014580B
		private static IntPtr StaticFunctionPtr()
		{
			if (UPlatformGameInstance.__PlatformRegisteredForUserNotificationsDelegate__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				UPlatformGameInstance.__PlatformRegisteredForUserNotificationsDelegate__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.PlatformGameInstance:PlatformRegisteredForUserNotificationsDelegate__DelegateSignature");
			}
			return UPlatformGameInstance.__PlatformRegisteredForUserNotificationsDelegate__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0600DE1A RID: 56858 RVA: 0x0014762E File Offset: 0x0014582E
		public FPlatformRegisteredForUserNotificationsDelegate()
		{
		}

		// Token: 0x0600DE1B RID: 56859 RVA: 0x00147636 File Offset: 0x00145836
		[NullableContext(2)]
		public FPlatformRegisteredForUserNotificationsDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600DE1C RID: 56860 RVA: 0x00147640 File Offset: 0x00145840
		public FPlatformRegisteredForUserNotificationsDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600DE1D RID: 56861 RVA: 0x0014764B File Offset: 0x0014584B
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<int>) ?? ((Action<int>)Delegate.CreateDelegate(typeof(Action<int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600DE1E RID: 56862 RVA: 0x0014767D File Offset: 0x0014587D
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<int> Callback)
		{
			if (FPlatformRegisteredForUserNotificationsDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FPlatformRegisteredForUserNotificationsDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FPlatformRegisteredForUserNotificationsDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FPlatformRegisteredForUserNotificationsDelegate.OnScriptCallback));
				}
				FPlatformRegisteredForUserNotificationsDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FPlatformRegisteredForUserNotificationsDelegate.RegisterId);
		}

		// Token: 0x0600DE1F RID: 56863 RVA: 0x001476B7 File Offset: 0x001458B7
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<int> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0600DE20 RID: 56864 RVA: 0x001476C0 File Offset: 0x001458C0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(int inInt)
		{
			FPlatformRegisteredForUserNotificationsDelegate.__FPlatformRegisteredForUserNotificationsDelegate_DelegateParams* ptr = stackalloc FPlatformRegisteredForUserNotificationsDelegate.__FPlatformRegisteredForUserNotificationsDelegate_DelegateParams[(UIntPtr)19] + 15L / (long)sizeof(FPlatformRegisteredForUserNotificationsDelegate.__FPlatformRegisteredForUserNotificationsDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FPlatformRegisteredForUserNotificationsDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->inInt = inInt;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0600DE21 RID: 56865 RVA: 0x001476FC File Offset: 0x001458FC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int> action = target as Action<int>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FPlatformRegisteredForUserNotificationsDelegate.__FPlatformRegisteredForUserNotificationsDelegate_DelegateParams*)__Parameters)->inInt);
		}

		// Token: 0x04007808 RID: 30728
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.PlatformGameInstance:PlatformRegisteredForUserNotificationsDelegate__DelegateSignature";

		// Token: 0x04007809 RID: 30729
		private static int RegisterId;

		// Token: 0x02002DD2 RID: 11730
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __FPlatformRegisteredForUserNotificationsDelegate_DelegateParams
		{
			// Token: 0x0401680F RID: 92175
			[FieldOffset(0)]
			public int inInt;
		}

		// Token: 0x02002DD3 RID: 11731
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016810 RID: 92176
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
