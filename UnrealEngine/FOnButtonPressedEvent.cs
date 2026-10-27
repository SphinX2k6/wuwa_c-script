using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002995 RID: 10645
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnButtonPressedEvent : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0602765F RID: 161375 RVA: 0x003C1172 File Offset: 0x003BF372
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnButtonPressedEvent.StaticFunctionPtr();
		}

		// Token: 0x06027660 RID: 161376 RVA: 0x003C117E File Offset: 0x003BF37E
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnButtonPressedEvent._FunctionPtr == IntPtr.Zero)
			{
				FOnButtonPressedEvent._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/UMG.OnButtonPressedEvent__DelegateSignature");
			}
			return FOnButtonPressedEvent._FunctionPtr;
		}

		// Token: 0x06027661 RID: 161377 RVA: 0x003C11A1 File Offset: 0x003BF3A1
		public FOnButtonPressedEvent()
		{
		}

		// Token: 0x06027662 RID: 161378 RVA: 0x003C11A9 File Offset: 0x003BF3A9
		[NullableContext(2)]
		public FOnButtonPressedEvent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06027663 RID: 161379 RVA: 0x003C11B3 File Offset: 0x003BF3B3
		public FOnButtonPressedEvent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06027664 RID: 161380 RVA: 0x003C11BE File Offset: 0x003BF3BE
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x06027665 RID: 161381 RVA: 0x003C11F0 File Offset: 0x003BF3F0
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action Callback)
		{
			if (FOnButtonPressedEvent.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnButtonPressedEvent.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnButtonPressedEvent.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnButtonPressedEvent.OnScriptCallback));
				}
				FOnButtonPressedEvent.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnButtonPressedEvent.RegisterId);
		}

		// Token: 0x06027666 RID: 161382 RVA: 0x003C122A File Offset: 0x003BF42A
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06027667 RID: 161383 RVA: 0x003C1233 File Offset: 0x003BF433
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x06027668 RID: 161384 RVA: 0x003C1240 File Offset: 0x003BF440
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

		// Token: 0x04015A24 RID: 88612
		internal static IntPtr _FunctionPtr;

		// Token: 0x04015A25 RID: 88613
		[Nullable(1)]
		public const string __ObjectPath = "/Script/UMG.OnButtonPressedEvent__DelegateSignature";

		// Token: 0x04015A26 RID: 88614
		private static int RegisterId;

		// Token: 0x02003B87 RID: 15239
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017D61 RID: 97633
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
