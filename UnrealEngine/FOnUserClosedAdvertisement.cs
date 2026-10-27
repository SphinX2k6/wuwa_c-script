using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;

namespace UnrealEngine
{
	// Token: 0x02000F34 RID: 3892
	public sealed class FOnUserClosedAdvertisement : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600D1DF RID: 53727 RVA: 0x001339C2 File Offset: 0x00131BC2
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnUserClosedAdvertisement.StaticFunctionPtr();
		}

		// Token: 0x0600D1E0 RID: 53728 RVA: 0x001339CE File Offset: 0x00131BCE
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnUserClosedAdvertisement._FunctionPtr == IntPtr.Zero)
			{
				FOnUserClosedAdvertisement._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.OnUserClosedAdvertisement__DelegateSignature");
			}
			return FOnUserClosedAdvertisement._FunctionPtr;
		}

		// Token: 0x0600D1E1 RID: 53729 RVA: 0x001339F1 File Offset: 0x00131BF1
		public FOnUserClosedAdvertisement()
		{
		}

		// Token: 0x0600D1E2 RID: 53730 RVA: 0x001339F9 File Offset: 0x00131BF9
		[NullableContext(2)]
		public FOnUserClosedAdvertisement(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600D1E3 RID: 53731 RVA: 0x00133A03 File Offset: 0x00131C03
		public FOnUserClosedAdvertisement(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600D1E4 RID: 53732 RVA: 0x00133A0E File Offset: 0x00131C0E
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600D1E5 RID: 53733 RVA: 0x00133A40 File Offset: 0x00131C40
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action Callback)
		{
			if (FOnUserClosedAdvertisement.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnUserClosedAdvertisement.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnUserClosedAdvertisement.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnUserClosedAdvertisement.OnScriptCallback));
				}
				FOnUserClosedAdvertisement.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FOnUserClosedAdvertisement.RegisterId);
		}

		// Token: 0x0600D1E6 RID: 53734 RVA: 0x00133A7A File Offset: 0x00131C7A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Execute()
		{
			base.ExecuteInternal(null);
		}

		// Token: 0x0600D1E7 RID: 53735 RVA: 0x00133A88 File Offset: 0x00131C88
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

		// Token: 0x040070A7 RID: 28839
		internal static IntPtr _FunctionPtr;

		// Token: 0x040070A8 RID: 28840
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.OnUserClosedAdvertisement__DelegateSignature";

		// Token: 0x040070A9 RID: 28841
		private static int RegisterId;

		// Token: 0x02002DB3 RID: 11699
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040167D8 RID: 92120
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
