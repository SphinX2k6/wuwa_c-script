using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;

namespace UnrealEngine
{
	// Token: 0x020005A4 RID: 1444
	public sealed class FOnTeamAllDead : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600824A RID: 33354 RVA: 0x000C0ABE File Offset: 0x000BECBE
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnTeamAllDead.StaticFunctionPtr();
		}

		// Token: 0x0600824B RID: 33355 RVA: 0x000C0ACA File Offset: 0x000BECCA
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnTeamAllDead._FunctionPtr == IntPtr.Zero)
			{
				FOnTeamAllDead._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroSimpleCombat.OnTeamAllDead__DelegateSignature");
			}
			return FOnTeamAllDead._FunctionPtr;
		}

		// Token: 0x0600824C RID: 33356 RVA: 0x000C0AED File Offset: 0x000BECED
		public FOnTeamAllDead()
		{
		}

		// Token: 0x0600824D RID: 33357 RVA: 0x000C0AF5 File Offset: 0x000BECF5
		[NullableContext(2)]
		public FOnTeamAllDead(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600824E RID: 33358 RVA: 0x000C0AFF File Offset: 0x000BECFF
		public FOnTeamAllDead(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600824F RID: 33359 RVA: 0x000C0B0A File Offset: 0x000BED0A
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x06008250 RID: 33360 RVA: 0x000C0B3C File Offset: 0x000BED3C
		[NullableContext(1)]
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

		// Token: 0x06008251 RID: 33361 RVA: 0x000C0B76 File Offset: 0x000BED76
		[SkipLocalsInit]
		public void Execute()
		{
			base.ExecuteInternal(null);
		}

		// Token: 0x06008252 RID: 33362 RVA: 0x000C0B84 File Offset: 0x000BED84
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

		// Token: 0x040038C7 RID: 14535
		internal static IntPtr _FunctionPtr;

		// Token: 0x040038C8 RID: 14536
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSimpleCombat.OnTeamAllDead__DelegateSignature";

		// Token: 0x040038C9 RID: 14537
		private static int RegisterId;

		// Token: 0x02000D27 RID: 3367
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005FBA RID: 24506
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
