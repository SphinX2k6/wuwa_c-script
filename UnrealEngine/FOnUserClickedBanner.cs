using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;

namespace UnrealEngine
{
	// Token: 0x02000F33 RID: 3891
	public sealed class FOnUserClickedBanner : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600D1D6 RID: 53718 RVA: 0x001338BA File Offset: 0x00131ABA
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnUserClickedBanner.StaticFunctionPtr();
		}

		// Token: 0x0600D1D7 RID: 53719 RVA: 0x001338C6 File Offset: 0x00131AC6
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnUserClickedBanner._FunctionPtr == IntPtr.Zero)
			{
				FOnUserClickedBanner._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.OnUserClickedBanner__DelegateSignature");
			}
			return FOnUserClickedBanner._FunctionPtr;
		}

		// Token: 0x0600D1D8 RID: 53720 RVA: 0x001338E9 File Offset: 0x00131AE9
		public FOnUserClickedBanner()
		{
		}

		// Token: 0x0600D1D9 RID: 53721 RVA: 0x001338F1 File Offset: 0x00131AF1
		[NullableContext(2)]
		public FOnUserClickedBanner(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600D1DA RID: 53722 RVA: 0x001338FB File Offset: 0x00131AFB
		public FOnUserClickedBanner(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600D1DB RID: 53723 RVA: 0x00133906 File Offset: 0x00131B06
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600D1DC RID: 53724 RVA: 0x00133938 File Offset: 0x00131B38
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action Callback)
		{
			if (FOnUserClickedBanner.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnUserClickedBanner.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnUserClickedBanner.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnUserClickedBanner.OnScriptCallback));
				}
				FOnUserClickedBanner.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FOnUserClickedBanner.RegisterId);
		}

		// Token: 0x0600D1DD RID: 53725 RVA: 0x00133972 File Offset: 0x00131B72
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Execute()
		{
			base.ExecuteInternal(null);
		}

		// Token: 0x0600D1DE RID: 53726 RVA: 0x00133980 File Offset: 0x00131B80
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

		// Token: 0x040070A4 RID: 28836
		internal static IntPtr _FunctionPtr;

		// Token: 0x040070A5 RID: 28837
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.OnUserClickedBanner__DelegateSignature";

		// Token: 0x040070A6 RID: 28838
		private static int RegisterId;

		// Token: 0x02002DB2 RID: 11698
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040167D7 RID: 92119
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
