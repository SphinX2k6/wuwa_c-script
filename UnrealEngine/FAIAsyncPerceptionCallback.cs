using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;

namespace UnrealEngine
{
	// Token: 0x020003B0 RID: 944
	public sealed class FAIAsyncPerceptionCallback : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06005D28 RID: 23848 RVA: 0x000833A6 File Offset: 0x000815A6
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FAIAsyncPerceptionCallback.StaticFunctionPtr();
		}

		// Token: 0x06005D29 RID: 23849 RVA: 0x000833B2 File Offset: 0x000815B2
		private static IntPtr StaticFunctionPtr()
		{
			if (FAIAsyncPerceptionCallback._FunctionPtr == IntPtr.Zero)
			{
				FAIAsyncPerceptionCallback._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroGameplay.AIAsyncPerceptionCallback__DelegateSignature");
			}
			return FAIAsyncPerceptionCallback._FunctionPtr;
		}

		// Token: 0x06005D2A RID: 23850 RVA: 0x000833D5 File Offset: 0x000815D5
		public FAIAsyncPerceptionCallback()
		{
		}

		// Token: 0x06005D2B RID: 23851 RVA: 0x000833DD File Offset: 0x000815DD
		[NullableContext(2)]
		public FAIAsyncPerceptionCallback(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005D2C RID: 23852 RVA: 0x000833E7 File Offset: 0x000815E7
		public FAIAsyncPerceptionCallback(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005D2D RID: 23853 RVA: 0x000833F2 File Offset: 0x000815F2
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x06005D2E RID: 23854 RVA: 0x00083424 File Offset: 0x00081624
		[NullableContext(1)]
		public void Bind(Action Callback)
		{
			if (FAIAsyncPerceptionCallback.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FAIAsyncPerceptionCallback.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FAIAsyncPerceptionCallback.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FAIAsyncPerceptionCallback.OnScriptCallback));
				}
				FAIAsyncPerceptionCallback.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FAIAsyncPerceptionCallback.RegisterId);
		}

		// Token: 0x06005D2F RID: 23855 RVA: 0x0008345E File Offset: 0x0008165E
		[SkipLocalsInit]
		public void Execute()
		{
			base.ExecuteInternal(null);
		}

		// Token: 0x06005D30 RID: 23856 RVA: 0x0008346C File Offset: 0x0008166C
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

		// Token: 0x040026D5 RID: 9941
		internal static IntPtr _FunctionPtr;

		// Token: 0x040026D6 RID: 9942
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameplay.AIAsyncPerceptionCallback__DelegateSignature";

		// Token: 0x040026D7 RID: 9943
		private static int RegisterId;

		// Token: 0x02000AAC RID: 2732
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005B09 RID: 23305
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
