using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;

namespace UnrealEngine
{
	// Token: 0x020006A0 RID: 1696
	public sealed class FLGUILoopScrollViewDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06009204 RID: 37380 RVA: 0x000DBC47 File Offset: 0x000D9E47
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUILoopScrollViewDelegate.StaticFunctionPtr();
		}

		// Token: 0x06009205 RID: 37381 RVA: 0x000DBC53 File Offset: 0x000D9E53
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUILoopScrollViewDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLGUILoopScrollViewDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUILoopScrollViewDelegate__DelegateSignature");
			}
			return FLGUILoopScrollViewDelegate._FunctionPtr;
		}

		// Token: 0x06009206 RID: 37382 RVA: 0x000DBC76 File Offset: 0x000D9E76
		public FLGUILoopScrollViewDelegate()
		{
		}

		// Token: 0x06009207 RID: 37383 RVA: 0x000DBC7E File Offset: 0x000D9E7E
		[NullableContext(2)]
		public FLGUILoopScrollViewDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06009208 RID: 37384 RVA: 0x000DBC88 File Offset: 0x000D9E88
		public FLGUILoopScrollViewDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06009209 RID: 37385 RVA: 0x000DBC93 File Offset: 0x000D9E93
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600920A RID: 37386 RVA: 0x000DBCC5 File Offset: 0x000D9EC5
		[NullableContext(1)]
		public void Bind(Action Callback)
		{
			if (FLGUILoopScrollViewDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLGUILoopScrollViewDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLGUILoopScrollViewDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLGUILoopScrollViewDelegate.OnScriptCallback));
				}
				FLGUILoopScrollViewDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLGUILoopScrollViewDelegate.RegisterId);
		}

		// Token: 0x0600920B RID: 37387 RVA: 0x000DBCFF File Offset: 0x000D9EFF
		[SkipLocalsInit]
		public void Execute()
		{
			base.ExecuteInternal(null);
		}

		// Token: 0x0600920C RID: 37388 RVA: 0x000DBD0C File Offset: 0x000D9F0C
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

		// Token: 0x04003FA2 RID: 16290
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003FA3 RID: 16291
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUILoopScrollViewDelegate__DelegateSignature";

		// Token: 0x04003FA4 RID: 16292
		private static int RegisterId;

		// Token: 0x02000EC8 RID: 3784
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04006282 RID: 25218
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
