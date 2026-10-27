using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001CA2 RID: 7330
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FSDKHasExitDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601C738 RID: 116536 RVA: 0x002A0B33 File Offset: 0x0029ED33
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FSDKHasExitDelegate.StaticFunctionPtr();
		}

		// Token: 0x0601C739 RID: 116537 RVA: 0x002A0B3F File Offset: 0x0029ED3F
		private static IntPtr StaticFunctionPtr()
		{
			if (FSDKHasExitDelegate._FunctionPtr == IntPtr.Zero)
			{
				FSDKHasExitDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroSDK.SDKHasExitDelegate__DelegateSignature");
			}
			return FSDKHasExitDelegate._FunctionPtr;
		}

		// Token: 0x0601C73A RID: 116538 RVA: 0x002A0B62 File Offset: 0x0029ED62
		public FSDKHasExitDelegate()
		{
		}

		// Token: 0x0601C73B RID: 116539 RVA: 0x002A0B6A File Offset: 0x0029ED6A
		[NullableContext(2)]
		public FSDKHasExitDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601C73C RID: 116540 RVA: 0x002A0B74 File Offset: 0x0029ED74
		public FSDKHasExitDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601C73D RID: 116541 RVA: 0x002A0B7F File Offset: 0x0029ED7F
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<byte>) ?? ((Action<byte>)Delegate.CreateDelegate(typeof(Action<byte>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601C73E RID: 116542 RVA: 0x002A0BB1 File Offset: 0x0029EDB1
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<byte> Callback)
		{
			if (FSDKHasExitDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FSDKHasExitDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FSDKHasExitDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FSDKHasExitDelegate.OnScriptCallback));
				}
				FSDKHasExitDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FSDKHasExitDelegate.RegisterId);
		}

		// Token: 0x0601C73F RID: 116543 RVA: 0x002A0BEB File Offset: 0x0029EDEB
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<byte> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601C740 RID: 116544 RVA: 0x002A0BF4 File Offset: 0x0029EDF4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(byte flagId)
		{
			FSDKHasExitDelegate.__FSDKHasExitDelegate_DelegateParams* ptr = stackalloc FSDKHasExitDelegate.__FSDKHasExitDelegate_DelegateParams[(UIntPtr)16] + 15L / (long)sizeof(FSDKHasExitDelegate.__FSDKHasExitDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FSDKHasExitDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->flagId = flagId;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0601C741 RID: 116545 RVA: 0x002A0C30 File Offset: 0x0029EE30
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<byte> action = target as Action<byte>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FSDKHasExitDelegate.__FSDKHasExitDelegate_DelegateParams*)__Parameters)->flagId);
		}

		// Token: 0x0400F4C7 RID: 62663
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400F4C8 RID: 62664
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSDK.SDKHasExitDelegate__DelegateSignature";

		// Token: 0x0400F4C9 RID: 62665
		private static int RegisterId;

		// Token: 0x02003277 RID: 12919
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __FSDKHasExitDelegate_DelegateParams
		{
			// Token: 0x040170FF RID: 94463
			[FieldOffset(0)]
			public byte flagId;
		}

		// Token: 0x02003278 RID: 12920
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017100 RID: 94464
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
