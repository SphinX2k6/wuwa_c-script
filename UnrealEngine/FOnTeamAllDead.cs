using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;

namespace UnrealEngine
{
	// Token: 0x02001E71 RID: 7793
	public sealed class FOnTeamAllDead : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601DAE0 RID: 121568 RVA: 0x002BD7E2 File Offset: 0x002BB9E2
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnTeamAllDead.StaticFunctionPtr();
		}

		// Token: 0x0601DAE1 RID: 121569 RVA: 0x002BD7EE File Offset: 0x002BB9EE
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnTeamAllDead._FunctionPtr == IntPtr.Zero)
			{
				FOnTeamAllDead._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroSimpleCombat.OnTeamAllDead__DelegateSignature");
			}
			return FOnTeamAllDead._FunctionPtr;
		}

		// Token: 0x0601DAE2 RID: 121570 RVA: 0x002BD811 File Offset: 0x002BBA11
		public FOnTeamAllDead()
		{
		}

		// Token: 0x0601DAE3 RID: 121571 RVA: 0x002BD819 File Offset: 0x002BBA19
		[NullableContext(2)]
		public FOnTeamAllDead(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601DAE4 RID: 121572 RVA: 0x002BD823 File Offset: 0x002BBA23
		public FOnTeamAllDead(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601DAE5 RID: 121573 RVA: 0x002BD82E File Offset: 0x002BBA2E
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601DAE6 RID: 121574 RVA: 0x002BD860 File Offset: 0x002BBA60
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action Callback)
		{
			if (FOnTeamAllDead.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnTeamAllDead.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnTeamAllDead.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnTeamAllDead.OnScriptCallback));
				}
				FOnTeamAllDead.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FOnTeamAllDead.RegisterId);
		}

		// Token: 0x0601DAE7 RID: 121575 RVA: 0x002BD89A File Offset: 0x002BBA9A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Execute()
		{
			base.ExecuteInternal(null);
		}

		// Token: 0x0601DAE8 RID: 121576 RVA: 0x002BD8A8 File Offset: 0x002BBAA8
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

		// Token: 0x04010132 RID: 65842
		internal static IntPtr _FunctionPtr;

		// Token: 0x04010133 RID: 65843
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSimpleCombat.OnTeamAllDead__DelegateSignature";

		// Token: 0x04010134 RID: 65844
		private static int RegisterId;

		// Token: 0x020032C8 RID: 13000
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401716E RID: 94574
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
