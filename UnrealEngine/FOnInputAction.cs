using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;

namespace UnrealEngine
{
	// Token: 0x020029A4 RID: 10660
	public sealed class FOnInputAction : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060276F3 RID: 161523 RVA: 0x003C254B File Offset: 0x003C074B
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnInputAction.StaticFunctionPtr();
		}

		// Token: 0x060276F4 RID: 161524 RVA: 0x003C2557 File Offset: 0x003C0757
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnInputAction._FunctionPtr == IntPtr.Zero)
			{
				FOnInputAction._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/UMG.OnInputAction__DelegateSignature");
			}
			return FOnInputAction._FunctionPtr;
		}

		// Token: 0x060276F5 RID: 161525 RVA: 0x003C257A File Offset: 0x003C077A
		public FOnInputAction()
		{
		}

		// Token: 0x060276F6 RID: 161526 RVA: 0x003C2582 File Offset: 0x003C0782
		[NullableContext(2)]
		public FOnInputAction(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060276F7 RID: 161527 RVA: 0x003C258C File Offset: 0x003C078C
		public FOnInputAction(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060276F8 RID: 161528 RVA: 0x003C2597 File Offset: 0x003C0797
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x060276F9 RID: 161529 RVA: 0x003C25C9 File Offset: 0x003C07C9
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action Callback)
		{
			if (FOnInputAction.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnInputAction.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnInputAction.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnInputAction.OnScriptCallback));
				}
				FOnInputAction.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FOnInputAction.RegisterId);
		}

		// Token: 0x060276FA RID: 161530 RVA: 0x003C2603 File Offset: 0x003C0803
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Execute()
		{
			base.ExecuteInternal(null);
		}

		// Token: 0x060276FB RID: 161531 RVA: 0x003C2610 File Offset: 0x003C0810
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

		// Token: 0x04015A4C RID: 88652
		internal static IntPtr _FunctionPtr;

		// Token: 0x04015A4D RID: 88653
		[Nullable(1)]
		public const string __ObjectPath = "/Script/UMG.OnInputAction__DelegateSignature";

		// Token: 0x04015A4E RID: 88654
		private static int RegisterId;

		// Token: 0x02003BA1 RID: 15265
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017D7F RID: 97663
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
