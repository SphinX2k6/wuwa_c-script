using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;

namespace UnrealEngine
{
	// Token: 0x02000663 RID: 1635
	public sealed class FInturnSequenceEvent : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06008DBF RID: 36287 RVA: 0x000D57B2 File Offset: 0x000D39B2
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FInturnSequenceEvent.StaticFunctionPtr();
		}

		// Token: 0x06008DC0 RID: 36288 RVA: 0x000D57BE File Offset: 0x000D39BE
		private static IntPtr StaticFunctionPtr()
		{
			if (FInturnSequenceEvent._FunctionPtr == IntPtr.Zero)
			{
				FInturnSequenceEvent._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.InturnSequenceEvent__DelegateSignature");
			}
			return FInturnSequenceEvent._FunctionPtr;
		}

		// Token: 0x06008DC1 RID: 36289 RVA: 0x000D57E1 File Offset: 0x000D39E1
		public FInturnSequenceEvent()
		{
		}

		// Token: 0x06008DC2 RID: 36290 RVA: 0x000D57E9 File Offset: 0x000D39E9
		[NullableContext(2)]
		public FInturnSequenceEvent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06008DC3 RID: 36291 RVA: 0x000D57F3 File Offset: 0x000D39F3
		public FInturnSequenceEvent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06008DC4 RID: 36292 RVA: 0x000D57FE File Offset: 0x000D39FE
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x06008DC5 RID: 36293 RVA: 0x000D5830 File Offset: 0x000D3A30
		[NullableContext(1)]
		public void Bind(Action Callback)
		{
			if (FInturnSequenceEvent.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FInturnSequenceEvent.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FInturnSequenceEvent.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FInturnSequenceEvent.OnScriptCallback));
				}
				FInturnSequenceEvent.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FInturnSequenceEvent.RegisterId);
		}

		// Token: 0x06008DC6 RID: 36294 RVA: 0x000D586A File Offset: 0x000D3A6A
		[SkipLocalsInit]
		public void Execute()
		{
			base.ExecuteInternal(null);
		}

		// Token: 0x06008DC7 RID: 36295 RVA: 0x000D5878 File Offset: 0x000D3A78
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

		// Token: 0x04003E77 RID: 15991
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003E78 RID: 15992
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.InturnSequenceEvent__DelegateSignature";

		// Token: 0x04003E79 RID: 15993
		private static int RegisterId;

		// Token: 0x02000E6B RID: 3691
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04006213 RID: 25107
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
