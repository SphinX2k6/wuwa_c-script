using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001005 RID: 4101
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FPlatformRegisteredForRemoteNotificationsDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600DE0E RID: 56846 RVA: 0x0014745C File Offset: 0x0014565C
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FPlatformRegisteredForRemoteNotificationsDelegate.StaticFunctionPtr();
		}

		// Token: 0x0600DE0F RID: 56847 RVA: 0x00147468 File Offset: 0x00145668
		private static IntPtr StaticFunctionPtr()
		{
			if (UPlatformGameInstance.__PlatformRegisteredForRemoteNotificationsDelegate__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				UPlatformGameInstance.__PlatformRegisteredForRemoteNotificationsDelegate__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.PlatformGameInstance:PlatformRegisteredForRemoteNotificationsDelegate__DelegateSignature");
			}
			return UPlatformGameInstance.__PlatformRegisteredForRemoteNotificationsDelegate__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0600DE10 RID: 56848 RVA: 0x0014748B File Offset: 0x0014568B
		public FPlatformRegisteredForRemoteNotificationsDelegate()
		{
		}

		// Token: 0x0600DE11 RID: 56849 RVA: 0x00147493 File Offset: 0x00145693
		[NullableContext(2)]
		public FPlatformRegisteredForRemoteNotificationsDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600DE12 RID: 56850 RVA: 0x0014749D File Offset: 0x0014569D
		public FPlatformRegisteredForRemoteNotificationsDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600DE13 RID: 56851 RVA: 0x001474A8 File Offset: 0x001456A8
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as FPlatformRegisteredForRemoteNotificationsDelegate.FPlatformRegisteredForRemoteNotificationsDelegate_ScriptDelegate) ?? ((FPlatformRegisteredForRemoteNotificationsDelegate.FPlatformRegisteredForRemoteNotificationsDelegate_ScriptDelegate)Delegate.CreateDelegate(typeof(FPlatformRegisteredForRemoteNotificationsDelegate.FPlatformRegisteredForRemoteNotificationsDelegate_ScriptDelegate), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600DE14 RID: 56852 RVA: 0x001474DA File Offset: 0x001456DA
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(FPlatformRegisteredForRemoteNotificationsDelegate.FPlatformRegisteredForRemoteNotificationsDelegate_ScriptDelegate Callback)
		{
			if (FPlatformRegisteredForRemoteNotificationsDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FPlatformRegisteredForRemoteNotificationsDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FPlatformRegisteredForRemoteNotificationsDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FPlatformRegisteredForRemoteNotificationsDelegate.OnScriptCallback));
				}
				FPlatformRegisteredForRemoteNotificationsDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FPlatformRegisteredForRemoteNotificationsDelegate.RegisterId);
		}

		// Token: 0x0600DE15 RID: 56853 RVA: 0x00147514 File Offset: 0x00145714
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(FPlatformRegisteredForRemoteNotificationsDelegate.FPlatformRegisteredForRemoteNotificationsDelegate_ScriptDelegate Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0600DE16 RID: 56854 RVA: 0x00147520 File Offset: 0x00145720
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(in TArray<byte> inArray)
		{
			FPlatformRegisteredForRemoteNotificationsDelegate.__FPlatformRegisteredForRemoteNotificationsDelegate_DelegateParams* ptr = stackalloc FPlatformRegisteredForRemoteNotificationsDelegate.__FPlatformRegisteredForRemoteNotificationsDelegate_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FPlatformRegisteredForRemoteNotificationsDelegate.__FPlatformRegisteredForRemoteNotificationsDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FPlatformRegisteredForRemoteNotificationsDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			TArray<byte> tarray = inArray;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->inArray);
			}
			base.BroadcastInternal((void*)ptr);
			TArray<byte> tarray2 = inArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->inArray);
			}
			UnrealReflectionUtils.DestroyStruct(UPlatformGameInstance.__PlatformRegisteredForRemoteNotificationsDelegate__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600DE17 RID: 56855 RVA: 0x00147590 File Offset: 0x00145790
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			FPlatformRegisteredForRemoteNotificationsDelegate.FPlatformRegisteredForRemoteNotificationsDelegate_ScriptDelegate fplatformRegisteredForRemoteNotificationsDelegate_ScriptDelegate = target as FPlatformRegisteredForRemoteNotificationsDelegate.FPlatformRegisteredForRemoteNotificationsDelegate_ScriptDelegate;
			if (fplatformRegisteredForRemoteNotificationsDelegate_ScriptDelegate == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			TArray<byte> tarray = new TArray<byte>(&((FPlatformRegisteredForRemoteNotificationsDelegate.__FPlatformRegisteredForRemoteNotificationsDelegate_DelegateParams*)__Parameters)->inArray, true, true);
			fplatformRegisteredForRemoteNotificationsDelegate_ScriptDelegate(tarray);
			if (tarray != null)
			{
				tarray.CopyTo(&((FPlatformRegisteredForRemoteNotificationsDelegate.__FPlatformRegisteredForRemoteNotificationsDelegate_DelegateParams*)__Parameters)->inArray, default(UScriptStructStackOnlyPtr));
			}
		}

		// Token: 0x04007806 RID: 30726
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.PlatformGameInstance:PlatformRegisteredForRemoteNotificationsDelegate__DelegateSignature";

		// Token: 0x04007807 RID: 30727
		private static int RegisterId;

		// Token: 0x02002DCF RID: 11727
		// (Invoke) Token: 0x06028556 RID: 165206
		public delegate void FPlatformRegisteredForRemoteNotificationsDelegate_ScriptDelegate(in TArray<byte> inArray);

		// Token: 0x02002DD0 RID: 11728
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FPlatformRegisteredForRemoteNotificationsDelegate_DelegateParams
		{
			// Token: 0x0401680D RID: 92173
			[FieldOffset(0)]
			public byte inArray;
		}

		// Token: 0x02002DD1 RID: 11729
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401680E RID: 92174
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
