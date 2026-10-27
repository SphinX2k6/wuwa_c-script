using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;

namespace UnrealEngine
{
	// Token: 0x02001E99 RID: 7833
	public sealed class FEndLoadTransitionMapDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601DC76 RID: 121974 RVA: 0x002C0276 File Offset: 0x002BE476
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FEndLoadTransitionMapDelegate.StaticFunctionPtr();
		}

		// Token: 0x0601DC77 RID: 121975 RVA: 0x002C0282 File Offset: 0x002BE482
		private static IntPtr StaticFunctionPtr()
		{
			if (FEndLoadTransitionMapDelegate._FunctionPtr == IntPtr.Zero)
			{
				FEndLoadTransitionMapDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroUtility.EndLoadTransitionMapDelegate__DelegateSignature");
			}
			return FEndLoadTransitionMapDelegate._FunctionPtr;
		}

		// Token: 0x0601DC78 RID: 121976 RVA: 0x002C02A5 File Offset: 0x002BE4A5
		public FEndLoadTransitionMapDelegate()
		{
		}

		// Token: 0x0601DC79 RID: 121977 RVA: 0x002C02AD File Offset: 0x002BE4AD
		[NullableContext(2)]
		public FEndLoadTransitionMapDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601DC7A RID: 121978 RVA: 0x002C02B7 File Offset: 0x002BE4B7
		public FEndLoadTransitionMapDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601DC7B RID: 121979 RVA: 0x002C02C2 File Offset: 0x002BE4C2
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601DC7C RID: 121980 RVA: 0x002C02F4 File Offset: 0x002BE4F4
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action Callback)
		{
			if (FEndLoadTransitionMapDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FEndLoadTransitionMapDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FEndLoadTransitionMapDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FEndLoadTransitionMapDelegate.OnScriptCallback));
				}
				FEndLoadTransitionMapDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FEndLoadTransitionMapDelegate.RegisterId);
		}

		// Token: 0x0601DC7D RID: 121981 RVA: 0x002C032E File Offset: 0x002BE52E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Execute()
		{
			base.ExecuteInternal(null);
		}

		// Token: 0x0601DC7E RID: 121982 RVA: 0x002C033C File Offset: 0x002BE53C
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

		// Token: 0x040101F0 RID: 66032
		internal static IntPtr _FunctionPtr;

		// Token: 0x040101F1 RID: 66033
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroUtility.EndLoadTransitionMapDelegate__DelegateSignature";

		// Token: 0x040101F2 RID: 66034
		private static int RegisterId;

		// Token: 0x020032E8 RID: 13032
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017198 RID: 94616
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
