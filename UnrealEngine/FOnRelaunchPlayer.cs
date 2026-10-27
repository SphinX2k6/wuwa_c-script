using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;

namespace UnrealEngine
{
	// Token: 0x02001E6B RID: 7787
	public sealed class FOnRelaunchPlayer : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601DAAA RID: 121514 RVA: 0x002BD12A File Offset: 0x002BB32A
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnRelaunchPlayer.StaticFunctionPtr();
		}

		// Token: 0x0601DAAB RID: 121515 RVA: 0x002BD136 File Offset: 0x002BB336
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnRelaunchPlayer._FunctionPtr == IntPtr.Zero)
			{
				FOnRelaunchPlayer._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroSimpleCombat.OnRelaunchPlayer__DelegateSignature");
			}
			return FOnRelaunchPlayer._FunctionPtr;
		}

		// Token: 0x0601DAAC RID: 121516 RVA: 0x002BD159 File Offset: 0x002BB359
		public FOnRelaunchPlayer()
		{
		}

		// Token: 0x0601DAAD RID: 121517 RVA: 0x002BD161 File Offset: 0x002BB361
		[NullableContext(2)]
		public FOnRelaunchPlayer(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601DAAE RID: 121518 RVA: 0x002BD16B File Offset: 0x002BB36B
		public FOnRelaunchPlayer(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601DAAF RID: 121519 RVA: 0x002BD176 File Offset: 0x002BB376
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601DAB0 RID: 121520 RVA: 0x002BD1A8 File Offset: 0x002BB3A8
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action Callback)
		{
			if (FOnRelaunchPlayer.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnRelaunchPlayer.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnRelaunchPlayer.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnRelaunchPlayer.OnScriptCallback));
				}
				FOnRelaunchPlayer.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FOnRelaunchPlayer.RegisterId);
		}

		// Token: 0x0601DAB1 RID: 121521 RVA: 0x002BD1E2 File Offset: 0x002BB3E2
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Execute()
		{
			base.ExecuteInternal(null);
		}

		// Token: 0x0601DAB2 RID: 121522 RVA: 0x002BD1F0 File Offset: 0x002BB3F0
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

		// Token: 0x04010124 RID: 65828
		internal static IntPtr _FunctionPtr;

		// Token: 0x04010125 RID: 65829
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSimpleCombat.OnRelaunchPlayer__DelegateSignature";

		// Token: 0x04010126 RID: 65830
		private static int RegisterId;

		// Token: 0x020032C0 RID: 12992
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017164 RID: 94564
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
