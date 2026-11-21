using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;

namespace UnrealEngine
{
	// Token: 0x02000875 RID: 2165
	public sealed class FWidgetAnimationDynamicEvent : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600BC89 RID: 48265 RVA: 0x0012D4C1 File Offset: 0x0012B6C1
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FWidgetAnimationDynamicEvent.StaticFunctionPtr();
		}

		// Token: 0x0600BC8A RID: 48266 RVA: 0x0012D4CD File Offset: 0x0012B6CD
		private static IntPtr StaticFunctionPtr()
		{
			if (FWidgetAnimationDynamicEvent._FunctionPtr == IntPtr.Zero)
			{
				FWidgetAnimationDynamicEvent._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/UMG.WidgetAnimationDynamicEvent__DelegateSignature");
			}
			return FWidgetAnimationDynamicEvent._FunctionPtr;
		}

		// Token: 0x0600BC8B RID: 48267 RVA: 0x0012D4F0 File Offset: 0x0012B6F0
		public FWidgetAnimationDynamicEvent()
		{
		}

		// Token: 0x0600BC8C RID: 48268 RVA: 0x0012D4F8 File Offset: 0x0012B6F8
		[NullableContext(2)]
		public FWidgetAnimationDynamicEvent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600BC8D RID: 48269 RVA: 0x0012D502 File Offset: 0x0012B702
		public FWidgetAnimationDynamicEvent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600BC8E RID: 48270 RVA: 0x0012D50D File Offset: 0x0012B70D
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600BC8F RID: 48271 RVA: 0x0012D53F File Offset: 0x0012B73F
		[NullableContext(1)]
		public void Bind(Action Callback)
		{
			if (FWidgetAnimationDynamicEvent.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FWidgetAnimationDynamicEvent.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FWidgetAnimationDynamicEvent.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FWidgetAnimationDynamicEvent.OnScriptCallback));
				}
				FWidgetAnimationDynamicEvent.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FWidgetAnimationDynamicEvent.RegisterId);
		}

		// Token: 0x0600BC90 RID: 48272 RVA: 0x0012D579 File Offset: 0x0012B779
		[SkipLocalsInit]
		public void Execute()
		{
			base.ExecuteInternal(null);
		}

		// Token: 0x0600BC91 RID: 48273 RVA: 0x0012D584 File Offset: 0x0012B784
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

		// Token: 0x04005543 RID: 21827
		internal static IntPtr _FunctionPtr;

		// Token: 0x04005544 RID: 21828
		[Nullable(1)]
		public const string __ObjectPath = "/Script/UMG.WidgetAnimationDynamicEvent__DelegateSignature";

		// Token: 0x04005545 RID: 21829
		private static int RegisterId;

		// Token: 0x02001412 RID: 5138
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040068C0 RID: 26816
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
