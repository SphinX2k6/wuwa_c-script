using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;

namespace UnrealEngine
{
	// Token: 0x02001699 RID: 5785
	public sealed class FKuroAudioPauseDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06014FA4 RID: 85924 RVA: 0x001ED4D5 File Offset: 0x001EB6D5
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FKuroAudioPauseDelegate.StaticFunctionPtr();
		}

		// Token: 0x06014FA5 RID: 85925 RVA: 0x001ED4E1 File Offset: 0x001EB6E1
		private static IntPtr StaticFunctionPtr()
		{
			if (FKuroAudioPauseDelegate._FunctionPtr == IntPtr.Zero)
			{
				FKuroAudioPauseDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroAudio.KuroAudioPauseDelegate__DelegateSignature");
			}
			return FKuroAudioPauseDelegate._FunctionPtr;
		}

		// Token: 0x06014FA6 RID: 85926 RVA: 0x001ED504 File Offset: 0x001EB704
		public FKuroAudioPauseDelegate()
		{
		}

		// Token: 0x06014FA7 RID: 85927 RVA: 0x001ED50C File Offset: 0x001EB70C
		[NullableContext(2)]
		public FKuroAudioPauseDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06014FA8 RID: 85928 RVA: 0x001ED516 File Offset: 0x001EB716
		public FKuroAudioPauseDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06014FA9 RID: 85929 RVA: 0x001ED521 File Offset: 0x001EB721
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x06014FAA RID: 85930 RVA: 0x001ED553 File Offset: 0x001EB753
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x06014FAB RID: 85931 RVA: 0x001ED58D File Offset: 0x001EB78D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Execute()
		{
			base.ExecuteInternal(null);
		}

		// Token: 0x06014FAC RID: 85932 RVA: 0x001ED598 File Offset: 0x001EB798
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

		// Token: 0x0400B6D7 RID: 46807
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400B6D8 RID: 46808
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroAudio.KuroAudioPauseDelegate__DelegateSignature";

		// Token: 0x0400B6D9 RID: 46809
		private static int RegisterId;

		// Token: 0x02002EDE RID: 11998
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040169FC RID: 92668
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
