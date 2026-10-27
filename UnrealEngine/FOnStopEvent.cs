using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001767 RID: 5991
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnStopEvent : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060158CE RID: 88270 RVA: 0x001FB4F2 File Offset: 0x001F96F2
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnStopEvent.StaticFunctionPtr();
		}

		// Token: 0x060158CF RID: 88271 RVA: 0x001FB4FE File Offset: 0x001F96FE
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnStopEvent._FunctionPtr == IntPtr.Zero)
			{
				FOnStopEvent._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroComponent.OnStopEvent__DelegateSignature");
			}
			return FOnStopEvent._FunctionPtr;
		}

		// Token: 0x060158D0 RID: 88272 RVA: 0x001FB521 File Offset: 0x001F9721
		public FOnStopEvent()
		{
		}

		// Token: 0x060158D1 RID: 88273 RVA: 0x001FB529 File Offset: 0x001F9729
		[NullableContext(2)]
		public FOnStopEvent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060158D2 RID: 88274 RVA: 0x001FB533 File Offset: 0x001F9733
		public FOnStopEvent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060158D3 RID: 88275 RVA: 0x001FB53E File Offset: 0x001F973E
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x060158D4 RID: 88276 RVA: 0x001FB570 File Offset: 0x001F9770
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action Callback)
		{
			if (FOnStopEvent.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnStopEvent.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnStopEvent.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnStopEvent.OnScriptCallback));
				}
				FOnStopEvent.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnStopEvent.RegisterId);
		}

		// Token: 0x060158D5 RID: 88277 RVA: 0x001FB5AA File Offset: 0x001F97AA
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x060158D6 RID: 88278 RVA: 0x001FB5B3 File Offset: 0x001F97B3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x060158D7 RID: 88279 RVA: 0x001FB5C0 File Offset: 0x001F97C0
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

		// Token: 0x0400BC2E RID: 48174
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400BC2F RID: 48175
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroComponent.OnStopEvent__DelegateSignature";

		// Token: 0x0400BC30 RID: 48176
		private static int RegisterId;

		// Token: 0x02002F2C RID: 12076
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016AA7 RID: 92839
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
