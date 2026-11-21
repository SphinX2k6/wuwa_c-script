using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;

namespace UnrealEngine
{
	// Token: 0x02000314 RID: 788
	public sealed class FKuroAudioResumeDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600538E RID: 21390 RVA: 0x00074CEA File Offset: 0x00072EEA
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FKuroAudioResumeDelegate.StaticFunctionPtr();
		}

		// Token: 0x0600538F RID: 21391 RVA: 0x00074CF6 File Offset: 0x00072EF6
		private static IntPtr StaticFunctionPtr()
		{
			if (FKuroAudioResumeDelegate._FunctionPtr == IntPtr.Zero)
			{
				FKuroAudioResumeDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroAudio.KuroAudioResumeDelegate__DelegateSignature");
			}
			return FKuroAudioResumeDelegate._FunctionPtr;
		}

		// Token: 0x06005390 RID: 21392 RVA: 0x00074D19 File Offset: 0x00072F19
		public FKuroAudioResumeDelegate()
		{
		}

		// Token: 0x06005391 RID: 21393 RVA: 0x00074D21 File Offset: 0x00072F21
		[NullableContext(2)]
		public FKuroAudioResumeDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005392 RID: 21394 RVA: 0x00074D2B File Offset: 0x00072F2B
		public FKuroAudioResumeDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005393 RID: 21395 RVA: 0x00074D36 File Offset: 0x00072F36
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x06005394 RID: 21396 RVA: 0x00074D68 File Offset: 0x00072F68
		[NullableContext(1)]
		public void Bind(Action Callback)
		{
			if (FKuroAudioResumeDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FKuroAudioResumeDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FKuroAudioResumeDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FKuroAudioResumeDelegate.OnScriptCallback));
				}
				FKuroAudioResumeDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FKuroAudioResumeDelegate.RegisterId);
		}

		// Token: 0x06005395 RID: 21397 RVA: 0x00074DA2 File Offset: 0x00072FA2
		[SkipLocalsInit]
		public void Execute()
		{
			base.ExecuteInternal(null);
		}

		// Token: 0x06005396 RID: 21398 RVA: 0x00074DB0 File Offset: 0x00072FB0
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

		// Token: 0x0400222C RID: 8748
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400222D RID: 8749
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroAudio.KuroAudioResumeDelegate__DelegateSignature";

		// Token: 0x0400222E RID: 8750
		private static int RegisterId;

		// Token: 0x02000A18 RID: 2584
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040059D8 RID: 23000
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
