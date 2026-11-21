using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;

namespace UnrealEngine
{
	// Token: 0x02000863 RID: 2147
	public sealed class FOnGameWindowCloseButtonClickedDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600BAD6 RID: 47830 RVA: 0x0012B105 File Offset: 0x00129305
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnGameWindowCloseButtonClickedDelegate.StaticFunctionPtr();
		}

		// Token: 0x0600BAD7 RID: 47831 RVA: 0x0012B111 File Offset: 0x00129311
		private static IntPtr StaticFunctionPtr()
		{
			if (UWidgetBlueprintLibrary.__OnGameWindowCloseButtonClickedDelegate__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				UWidgetBlueprintLibrary.__OnGameWindowCloseButtonClickedDelegate__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/UMG.WidgetBlueprintLibrary:OnGameWindowCloseButtonClickedDelegate__DelegateSignature");
			}
			return UWidgetBlueprintLibrary.__OnGameWindowCloseButtonClickedDelegate__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0600BAD8 RID: 47832 RVA: 0x0012B134 File Offset: 0x00129334
		public FOnGameWindowCloseButtonClickedDelegate()
		{
		}

		// Token: 0x0600BAD9 RID: 47833 RVA: 0x0012B13C File Offset: 0x0012933C
		[NullableContext(2)]
		public FOnGameWindowCloseButtonClickedDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600BADA RID: 47834 RVA: 0x0012B146 File Offset: 0x00129346
		public FOnGameWindowCloseButtonClickedDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600BADB RID: 47835 RVA: 0x0012B151 File Offset: 0x00129351
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600BADC RID: 47836 RVA: 0x0012B183 File Offset: 0x00129383
		[NullableContext(1)]
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

		// Token: 0x0600BADD RID: 47837 RVA: 0x0012B1BD File Offset: 0x001293BD
		[SkipLocalsInit]
		public void Execute()
		{
			base.ExecuteInternal(null);
		}

		// Token: 0x0600BADE RID: 47838 RVA: 0x0012B1C8 File Offset: 0x001293C8
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

		// Token: 0x040054B4 RID: 21684
		[Nullable(1)]
		public const string __ObjectPath = "/Script/UMG.WidgetBlueprintLibrary:OnGameWindowCloseButtonClickedDelegate__DelegateSignature";

		// Token: 0x040054B5 RID: 21685
		private static int RegisterId;

		// Token: 0x020013FD RID: 5117
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040068A7 RID: 26791
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
