using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;

namespace UnrealEngine
{
	// Token: 0x02000F2F RID: 3887
	public sealed class FOnTimelineEvent : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600D1B2 RID: 53682 RVA: 0x001333E6 File Offset: 0x001315E6
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnTimelineEvent.StaticFunctionPtr();
		}

		// Token: 0x0600D1B3 RID: 53683 RVA: 0x001333F2 File Offset: 0x001315F2
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnTimelineEvent._FunctionPtr == IntPtr.Zero)
			{
				FOnTimelineEvent._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.OnTimelineEvent__DelegateSignature");
			}
			return FOnTimelineEvent._FunctionPtr;
		}

		// Token: 0x0600D1B4 RID: 53684 RVA: 0x00133415 File Offset: 0x00131615
		public FOnTimelineEvent()
		{
		}

		// Token: 0x0600D1B5 RID: 53685 RVA: 0x0013341D File Offset: 0x0013161D
		[NullableContext(2)]
		public FOnTimelineEvent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600D1B6 RID: 53686 RVA: 0x00133427 File Offset: 0x00131627
		public FOnTimelineEvent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600D1B7 RID: 53687 RVA: 0x00133432 File Offset: 0x00131632
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600D1B8 RID: 53688 RVA: 0x00133464 File Offset: 0x00131664
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action Callback)
		{
			if (FOnTimelineEvent.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnTimelineEvent.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnTimelineEvent.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnTimelineEvent.OnScriptCallback));
				}
				FOnTimelineEvent.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FOnTimelineEvent.RegisterId);
		}

		// Token: 0x0600D1B9 RID: 53689 RVA: 0x0013349E File Offset: 0x0013169E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Execute()
		{
			base.ExecuteInternal(null);
		}

		// Token: 0x0600D1BA RID: 53690 RVA: 0x001334AC File Offset: 0x001316AC
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

		// Token: 0x04007098 RID: 28824
		internal static IntPtr _FunctionPtr;

		// Token: 0x04007099 RID: 28825
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.OnTimelineEvent__DelegateSignature";

		// Token: 0x0400709A RID: 28826
		private static int RegisterId;

		// Token: 0x02002DAB RID: 11691
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040167D0 RID: 92112
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
