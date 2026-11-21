using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;

namespace UnrealEngine
{
	// Token: 0x02000313 RID: 787
	public sealed class FKuroAudioPauseDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06005385 RID: 21381 RVA: 0x00074BE5 File Offset: 0x00072DE5
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FKuroAudioPauseDelegate.StaticFunctionPtr();
		}

		// Token: 0x06005386 RID: 21382 RVA: 0x00074BF1 File Offset: 0x00072DF1
		private static IntPtr StaticFunctionPtr()
		{
			if (FKuroAudioPauseDelegate._FunctionPtr == IntPtr.Zero)
			{
				FKuroAudioPauseDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroAudio.KuroAudioPauseDelegate__DelegateSignature");
			}
			return FKuroAudioPauseDelegate._FunctionPtr;
		}

		// Token: 0x06005387 RID: 21383 RVA: 0x00074C14 File Offset: 0x00072E14
		public FKuroAudioPauseDelegate()
		{
		}

		// Token: 0x06005388 RID: 21384 RVA: 0x00074C1C File Offset: 0x00072E1C
		[NullableContext(2)]
		public FKuroAudioPauseDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005389 RID: 21385 RVA: 0x00074C26 File Offset: 0x00072E26
		public FKuroAudioPauseDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600538A RID: 21386 RVA: 0x00074C31 File Offset: 0x00072E31
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600538B RID: 21387 RVA: 0x00074C63 File Offset: 0x00072E63
		[NullableContext(1)]
		public void Bind(Action Callback)
		{
			if (FKuroAudioPauseDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FKuroAudioPauseDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FKuroAudioPauseDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FKuroAudioPauseDelegate.OnScriptCallback));
				}
				FKuroAudioPauseDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FKuroAudioPauseDelegate.RegisterId);
		}

		// Token: 0x0600538C RID: 21388 RVA: 0x00074C9D File Offset: 0x00072E9D
		[SkipLocalsInit]
		public void Execute()
		{
			base.ExecuteInternal(null);
		}

		// Token: 0x0600538D RID: 21389 RVA: 0x00074CA8 File Offset: 0x00072EA8
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

		// Token: 0x04002229 RID: 8745
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400222A RID: 8746
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroAudio.KuroAudioPauseDelegate__DelegateSignature";

		// Token: 0x0400222B RID: 8747
		private static int RegisterId;

		// Token: 0x02000A17 RID: 2583
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040059D7 RID: 22999
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
