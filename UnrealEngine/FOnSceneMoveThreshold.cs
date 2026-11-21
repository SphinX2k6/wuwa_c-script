using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;

namespace UnrealEngine
{
	// Token: 0x0200059F RID: 1439
	public sealed class FOnSceneMoveThreshold : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600821D RID: 33309 RVA: 0x000C050E File Offset: 0x000BE70E
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnSceneMoveThreshold.StaticFunctionPtr();
		}

		// Token: 0x0600821E RID: 33310 RVA: 0x000C051A File Offset: 0x000BE71A
		private static IntPtr StaticFunctionPtr()
		{
			if (UKSC_SceneMovement.__OnSceneMoveThreshold__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				UKSC_SceneMovement.__OnSceneMoveThreshold__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroSimpleCombat.KSC_SceneMovement:OnSceneMoveThreshold__DelegateSignature");
			}
			return UKSC_SceneMovement.__OnSceneMoveThreshold__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0600821F RID: 33311 RVA: 0x000C053D File Offset: 0x000BE73D
		public FOnSceneMoveThreshold()
		{
		}

		// Token: 0x06008220 RID: 33312 RVA: 0x000C0545 File Offset: 0x000BE745
		[NullableContext(2)]
		public FOnSceneMoveThreshold(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06008221 RID: 33313 RVA: 0x000C054F File Offset: 0x000BE74F
		public FOnSceneMoveThreshold(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06008222 RID: 33314 RVA: 0x000C055A File Offset: 0x000BE75A
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x06008223 RID: 33315 RVA: 0x000C058C File Offset: 0x000BE78C
		[NullableContext(1)]
		public void Bind(Action Callback)
		{
			if (FOnSceneMoveThreshold.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnSceneMoveThreshold.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnSceneMoveThreshold.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnSceneMoveThreshold.OnScriptCallback));
				}
				FOnSceneMoveThreshold.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FOnSceneMoveThreshold.RegisterId);
		}

		// Token: 0x06008224 RID: 33316 RVA: 0x000C05C6 File Offset: 0x000BE7C6
		[SkipLocalsInit]
		public void Execute()
		{
			base.ExecuteInternal(null);
		}

		// Token: 0x06008225 RID: 33317 RVA: 0x000C05D4 File Offset: 0x000BE7D4
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

		// Token: 0x040038BC RID: 14524
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_SceneMovement:OnSceneMoveThreshold__DelegateSignature";

		// Token: 0x040038BD RID: 14525
		private static int RegisterId;

		// Token: 0x02000D20 RID: 3360
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005FB1 RID: 24497
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
