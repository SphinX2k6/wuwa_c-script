using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;

namespace UnrealEngine
{
	// Token: 0x0200169A RID: 5786
	public sealed class FKuroAudioResumeDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06014FAD RID: 85933 RVA: 0x001ED5DA File Offset: 0x001EB7DA
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FKuroAudioResumeDelegate.StaticFunctionPtr();
		}

		// Token: 0x06014FAE RID: 85934 RVA: 0x001ED5E6 File Offset: 0x001EB7E6
		private static IntPtr StaticFunctionPtr()
		{
			if (FKuroAudioResumeDelegate._FunctionPtr == IntPtr.Zero)
			{
				FKuroAudioResumeDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroAudio.KuroAudioResumeDelegate__DelegateSignature");
			}
			return FKuroAudioResumeDelegate._FunctionPtr;
		}

		// Token: 0x06014FAF RID: 85935 RVA: 0x001ED609 File Offset: 0x001EB809
		public FKuroAudioResumeDelegate()
		{
		}

		// Token: 0x06014FB0 RID: 85936 RVA: 0x001ED611 File Offset: 0x001EB811
		[NullableContext(2)]
		public FKuroAudioResumeDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06014FB1 RID: 85937 RVA: 0x001ED61B File Offset: 0x001EB81B
		public FKuroAudioResumeDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06014FB2 RID: 85938 RVA: 0x001ED626 File Offset: 0x001EB826
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x06014FB3 RID: 85939 RVA: 0x001ED658 File Offset: 0x001EB858
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x06014FB4 RID: 85940 RVA: 0x001ED692 File Offset: 0x001EB892
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Execute()
		{
			base.ExecuteInternal(null);
		}

		// Token: 0x06014FB5 RID: 85941 RVA: 0x001ED6A0 File Offset: 0x001EB8A0
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

		// Token: 0x0400B6DA RID: 46810
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400B6DB RID: 46811
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroAudio.KuroAudioResumeDelegate__DelegateSignature";

		// Token: 0x0400B6DC RID: 46812
		private static int RegisterId;

		// Token: 0x02002EDF RID: 11999
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040169FD RID: 92669
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
