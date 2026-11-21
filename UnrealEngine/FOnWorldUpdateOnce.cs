using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;

namespace UnrealEngine
{
	// Token: 0x020005A5 RID: 1445
	public sealed class FOnWorldUpdateOnce : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06008253 RID: 33363 RVA: 0x000C0BC6 File Offset: 0x000BEDC6
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnWorldUpdateOnce.StaticFunctionPtr();
		}

		// Token: 0x06008254 RID: 33364 RVA: 0x000C0BD2 File Offset: 0x000BEDD2
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnWorldUpdateOnce._FunctionPtr == IntPtr.Zero)
			{
				FOnWorldUpdateOnce._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroSimpleCombat.OnWorldUpdateOnce__DelegateSignature");
			}
			return FOnWorldUpdateOnce._FunctionPtr;
		}

		// Token: 0x06008255 RID: 33365 RVA: 0x000C0BF5 File Offset: 0x000BEDF5
		public FOnWorldUpdateOnce()
		{
		}

		// Token: 0x06008256 RID: 33366 RVA: 0x000C0BFD File Offset: 0x000BEDFD
		[NullableContext(2)]
		public FOnWorldUpdateOnce(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06008257 RID: 33367 RVA: 0x000C0C07 File Offset: 0x000BEE07
		public FOnWorldUpdateOnce(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06008258 RID: 33368 RVA: 0x000C0C12 File Offset: 0x000BEE12
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x06008259 RID: 33369 RVA: 0x000C0C44 File Offset: 0x000BEE44
		[NullableContext(1)]
		public void Bind(Action Callback)
		{
			if (FOnWorldUpdateOnce.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnWorldUpdateOnce.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnWorldUpdateOnce.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnWorldUpdateOnce.OnScriptCallback));
				}
				FOnWorldUpdateOnce.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FOnWorldUpdateOnce.RegisterId);
		}

		// Token: 0x0600825A RID: 33370 RVA: 0x000C0C7E File Offset: 0x000BEE7E
		[SkipLocalsInit]
		public void Execute()
		{
			base.ExecuteInternal(null);
		}

		// Token: 0x0600825B RID: 33371 RVA: 0x000C0C8C File Offset: 0x000BEE8C
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

		// Token: 0x040038CA RID: 14538
		internal static IntPtr _FunctionPtr;

		// Token: 0x040038CB RID: 14539
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSimpleCombat.OnWorldUpdateOnce__DelegateSignature";

		// Token: 0x040038CC RID: 14540
		private static int RegisterId;

		// Token: 0x02000D28 RID: 3368
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005FBB RID: 24507
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
