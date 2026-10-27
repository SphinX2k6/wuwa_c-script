using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020022A0 RID: 8864
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnMediaPlayerMediaEvent : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06021B77 RID: 138103 RVA: 0x0031D8F6 File Offset: 0x0031BAF6
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnMediaPlayerMediaEvent.StaticFunctionPtr();
		}

		// Token: 0x06021B78 RID: 138104 RVA: 0x0031D902 File Offset: 0x0031BB02
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnMediaPlayerMediaEvent._FunctionPtr == IntPtr.Zero)
			{
				FOnMediaPlayerMediaEvent._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/MediaAssets.OnMediaPlayerMediaEvent__DelegateSignature");
			}
			return FOnMediaPlayerMediaEvent._FunctionPtr;
		}

		// Token: 0x06021B79 RID: 138105 RVA: 0x0031D925 File Offset: 0x0031BB25
		public FOnMediaPlayerMediaEvent()
		{
		}

		// Token: 0x06021B7A RID: 138106 RVA: 0x0031D92D File Offset: 0x0031BB2D
		[NullableContext(2)]
		public FOnMediaPlayerMediaEvent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021B7B RID: 138107 RVA: 0x0031D937 File Offset: 0x0031BB37
		public FOnMediaPlayerMediaEvent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021B7C RID: 138108 RVA: 0x0031D942 File Offset: 0x0031BB42
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x06021B7D RID: 138109 RVA: 0x0031D974 File Offset: 0x0031BB74
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action Callback)
		{
			if (FOnMediaPlayerMediaEvent.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnMediaPlayerMediaEvent.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnMediaPlayerMediaEvent.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnMediaPlayerMediaEvent.OnScriptCallback));
				}
				FOnMediaPlayerMediaEvent.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnMediaPlayerMediaEvent.RegisterId);
		}

		// Token: 0x06021B7E RID: 138110 RVA: 0x0031D9AE File Offset: 0x0031BBAE
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06021B7F RID: 138111 RVA: 0x0031D9B7 File Offset: 0x0031BBB7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x06021B80 RID: 138112 RVA: 0x0031D9C4 File Offset: 0x0031BBC4
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

		// Token: 0x04011FCE RID: 73678
		internal static IntPtr _FunctionPtr;

		// Token: 0x04011FCF RID: 73679
		[Nullable(1)]
		public const string __ObjectPath = "/Script/MediaAssets.OnMediaPlayerMediaEvent__DelegateSignature";

		// Token: 0x04011FD0 RID: 73680
		private static int RegisterId;

		// Token: 0x02003611 RID: 13841
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040176A1 RID: 95905
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
