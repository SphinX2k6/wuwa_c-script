using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020004F4 RID: 1268
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnLeaveVolumeBlueprintEvent : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600773F RID: 30527 RVA: 0x000AE529 File Offset: 0x000AC729
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnLeaveVolumeBlueprintEvent.StaticFunctionPtr();
		}

		// Token: 0x06007740 RID: 30528 RVA: 0x000AE535 File Offset: 0x000AC735
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnLeaveVolumeBlueprintEvent._FunctionPtr == IntPtr.Zero)
			{
				FOnLeaveVolumeBlueprintEvent._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroRenderingRuntimeBPPlugin.OnLeaveVolumeBlueprintEvent__DelegateSignature");
			}
			return FOnLeaveVolumeBlueprintEvent._FunctionPtr;
		}

		// Token: 0x06007741 RID: 30529 RVA: 0x000AE558 File Offset: 0x000AC758
		public FOnLeaveVolumeBlueprintEvent()
		{
		}

		// Token: 0x06007742 RID: 30530 RVA: 0x000AE560 File Offset: 0x000AC760
		[NullableContext(2)]
		public FOnLeaveVolumeBlueprintEvent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007743 RID: 30531 RVA: 0x000AE56A File Offset: 0x000AC76A
		public FOnLeaveVolumeBlueprintEvent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007744 RID: 30532 RVA: 0x000AE575 File Offset: 0x000AC775
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x06007745 RID: 30533 RVA: 0x000AE5A7 File Offset: 0x000AC7A7
		[NullableContext(1)]
		public void Add(Action Callback)
		{
			if (FOnLeaveVolumeBlueprintEvent.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnLeaveVolumeBlueprintEvent.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnLeaveVolumeBlueprintEvent.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnLeaveVolumeBlueprintEvent.OnScriptCallback));
				}
				FOnLeaveVolumeBlueprintEvent.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnLeaveVolumeBlueprintEvent.RegisterId);
		}

		// Token: 0x06007746 RID: 30534 RVA: 0x000AE5E1 File Offset: 0x000AC7E1
		[NullableContext(1)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06007747 RID: 30535 RVA: 0x000AE5EA File Offset: 0x000AC7EA
		[SkipLocalsInit]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x06007748 RID: 30536 RVA: 0x000AE5F4 File Offset: 0x000AC7F4
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action action = target as Action;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action();
		}

		// Token: 0x04003242 RID: 12866
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003243 RID: 12867
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.OnLeaveVolumeBlueprintEvent__DelegateSignature";

		// Token: 0x04003244 RID: 12868
		private static int RegisterId;

		// Token: 0x02000C36 RID: 3126
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005E83 RID: 24195
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
