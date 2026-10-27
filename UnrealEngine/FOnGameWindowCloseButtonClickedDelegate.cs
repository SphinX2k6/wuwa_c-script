using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;

namespace UnrealEngine
{
	// Token: 0x020029A1 RID: 10657
	public sealed class FOnGameWindowCloseButtonClickedDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060276D7 RID: 161495 RVA: 0x003C20FE File Offset: 0x003C02FE
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnGameWindowCloseButtonClickedDelegate.StaticFunctionPtr();
		}

		// Token: 0x060276D8 RID: 161496 RVA: 0x003C210A File Offset: 0x003C030A
		private static IntPtr StaticFunctionPtr()
		{
			if (UWidgetBlueprintLibrary.__OnGameWindowCloseButtonClickedDelegate__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				UWidgetBlueprintLibrary.__OnGameWindowCloseButtonClickedDelegate__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/UMG.WidgetBlueprintLibrary:OnGameWindowCloseButtonClickedDelegate__DelegateSignature");
			}
			return UWidgetBlueprintLibrary.__OnGameWindowCloseButtonClickedDelegate__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x060276D9 RID: 161497 RVA: 0x003C212D File Offset: 0x003C032D
		public FOnGameWindowCloseButtonClickedDelegate()
		{
		}

		// Token: 0x060276DA RID: 161498 RVA: 0x003C2135 File Offset: 0x003C0335
		[NullableContext(2)]
		public FOnGameWindowCloseButtonClickedDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060276DB RID: 161499 RVA: 0x003C213F File Offset: 0x003C033F
		public FOnGameWindowCloseButtonClickedDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060276DC RID: 161500 RVA: 0x003C214A File Offset: 0x003C034A
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x060276DD RID: 161501 RVA: 0x003C217C File Offset: 0x003C037C
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action Callback)
		{
			if (FOnGameWindowCloseButtonClickedDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnGameWindowCloseButtonClickedDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnGameWindowCloseButtonClickedDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnGameWindowCloseButtonClickedDelegate.OnScriptCallback));
				}
				FOnGameWindowCloseButtonClickedDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FOnGameWindowCloseButtonClickedDelegate.RegisterId);
		}

		// Token: 0x060276DE RID: 161502 RVA: 0x003C21B6 File Offset: 0x003C03B6
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Execute()
		{
			base.ExecuteInternal(null);
		}

		// Token: 0x060276DF RID: 161503 RVA: 0x003C21C4 File Offset: 0x003C03C4
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

		// Token: 0x04015A44 RID: 88644
		[Nullable(1)]
		public const string __ObjectPath = "/Script/UMG.WidgetBlueprintLibrary:OnGameWindowCloseButtonClickedDelegate__DelegateSignature";

		// Token: 0x04015A45 RID: 88645
		private static int RegisterId;

		// Token: 0x02003B9B RID: 15259
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017D78 RID: 97656
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
