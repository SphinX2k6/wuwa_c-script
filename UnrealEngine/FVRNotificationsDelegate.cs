using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200146D RID: 5229
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FVRNotificationsDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06013137 RID: 78135 RVA: 0x001C0D9D File Offset: 0x001BEF9D
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FVRNotificationsDelegate.StaticFunctionPtr();
		}

		// Token: 0x06013138 RID: 78136 RVA: 0x001C0DA9 File Offset: 0x001BEFA9
		private static IntPtr StaticFunctionPtr()
		{
			if (UVRNotificationsComponent.__VRNotificationsDelegate__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				UVRNotificationsComponent.__VRNotificationsDelegate__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/HeadMountedDisplay.VRNotificationsComponent:VRNotificationsDelegate__DelegateSignature");
			}
			return UVRNotificationsComponent.__VRNotificationsDelegate__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x06013139 RID: 78137 RVA: 0x001C0DCC File Offset: 0x001BEFCC
		public FVRNotificationsDelegate()
		{
		}

		// Token: 0x0601313A RID: 78138 RVA: 0x001C0DD4 File Offset: 0x001BEFD4
		[NullableContext(2)]
		public FVRNotificationsDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601313B RID: 78139 RVA: 0x001C0DDE File Offset: 0x001BEFDE
		public FVRNotificationsDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601313C RID: 78140 RVA: 0x001C0DE9 File Offset: 0x001BEFE9
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601313D RID: 78141 RVA: 0x001C0E1B File Offset: 0x001BF01B
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action Callback)
		{
			if (FVRNotificationsDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FVRNotificationsDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FVRNotificationsDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FVRNotificationsDelegate.OnScriptCallback));
				}
				FVRNotificationsDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FVRNotificationsDelegate.RegisterId);
		}

		// Token: 0x0601313E RID: 78142 RVA: 0x001C0E55 File Offset: 0x001BF055
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601313F RID: 78143 RVA: 0x001C0E5E File Offset: 0x001BF05E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x06013140 RID: 78144 RVA: 0x001C0E68 File Offset: 0x001BF068
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action action = target as Action;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action();
		}

		// Token: 0x0400A3A8 RID: 41896
		[Nullable(1)]
		public const string __ObjectPath = "/Script/HeadMountedDisplay.VRNotificationsComponent:VRNotificationsDelegate__DelegateSignature";

		// Token: 0x0400A3A9 RID: 41897
		private static int RegisterId;

		// Token: 0x02002EAB RID: 11947
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401699C RID: 92572
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
