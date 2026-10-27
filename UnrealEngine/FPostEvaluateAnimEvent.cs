using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;

namespace UnrealEngine
{
	// Token: 0x02001023 RID: 4131
	public sealed class FPostEvaluateAnimEvent : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600E1FF RID: 57855 RVA: 0x0014C1DC File Offset: 0x0014A3DC
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FPostEvaluateAnimEvent.StaticFunctionPtr();
		}

		// Token: 0x0600E200 RID: 57856 RVA: 0x0014C1E8 File Offset: 0x0014A3E8
		private static IntPtr StaticFunctionPtr()
		{
			if (FPostEvaluateAnimEvent._FunctionPtr == IntPtr.Zero)
			{
				FPostEvaluateAnimEvent._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.PostEvaluateAnimEvent__DelegateSignature");
			}
			return FPostEvaluateAnimEvent._FunctionPtr;
		}

		// Token: 0x0600E201 RID: 57857 RVA: 0x0014C20B File Offset: 0x0014A40B
		public FPostEvaluateAnimEvent()
		{
		}

		// Token: 0x0600E202 RID: 57858 RVA: 0x0014C213 File Offset: 0x0014A413
		[NullableContext(2)]
		public FPostEvaluateAnimEvent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600E203 RID: 57859 RVA: 0x0014C21D File Offset: 0x0014A41D
		public FPostEvaluateAnimEvent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600E204 RID: 57860 RVA: 0x0014C228 File Offset: 0x0014A428
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600E205 RID: 57861 RVA: 0x0014C25A File Offset: 0x0014A45A
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action Callback)
		{
			if (FPostEvaluateAnimEvent.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FPostEvaluateAnimEvent.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FPostEvaluateAnimEvent.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FPostEvaluateAnimEvent.OnScriptCallback));
				}
				FPostEvaluateAnimEvent.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FPostEvaluateAnimEvent.RegisterId);
		}

		// Token: 0x0600E206 RID: 57862 RVA: 0x0014C294 File Offset: 0x0014A494
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Execute()
		{
			base.ExecuteInternal(null);
		}

		// Token: 0x0600E207 RID: 57863 RVA: 0x0014C2A0 File Offset: 0x0014A4A0
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

		// Token: 0x0400794C RID: 31052
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400794D RID: 31053
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.PostEvaluateAnimEvent__DelegateSignature";

		// Token: 0x0400794E RID: 31054
		private static int RegisterId;

		// Token: 0x02002DDD RID: 11741
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016820 RID: 92192
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
