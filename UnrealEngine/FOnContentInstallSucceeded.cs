using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;

namespace UnrealEngine
{
	// Token: 0x020022FA RID: 8954
	public sealed class FOnContentInstallSucceeded : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06021F03 RID: 139011 RVA: 0x00322FAE File Offset: 0x003211AE
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnContentInstallSucceeded.StaticFunctionPtr();
		}

		// Token: 0x06021F04 RID: 139012 RVA: 0x00322FBA File Offset: 0x003211BA
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnContentInstallSucceeded._FunctionPtr == IntPtr.Zero)
			{
				FOnContentInstallSucceeded._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/MobilePatchingUtils.OnContentInstallSucceeded__DelegateSignature");
			}
			return FOnContentInstallSucceeded._FunctionPtr;
		}

		// Token: 0x06021F05 RID: 139013 RVA: 0x00322FDD File Offset: 0x003211DD
		public FOnContentInstallSucceeded()
		{
		}

		// Token: 0x06021F06 RID: 139014 RVA: 0x00322FE5 File Offset: 0x003211E5
		[NullableContext(2)]
		public FOnContentInstallSucceeded(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021F07 RID: 139015 RVA: 0x00322FEF File Offset: 0x003211EF
		public FOnContentInstallSucceeded(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021F08 RID: 139016 RVA: 0x00322FFA File Offset: 0x003211FA
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x06021F09 RID: 139017 RVA: 0x0032302C File Offset: 0x0032122C
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action Callback)
		{
			if (FOnContentInstallSucceeded.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnContentInstallSucceeded.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnContentInstallSucceeded.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnContentInstallSucceeded.OnScriptCallback));
				}
				FOnContentInstallSucceeded.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FOnContentInstallSucceeded.RegisterId);
		}

		// Token: 0x06021F0A RID: 139018 RVA: 0x00323066 File Offset: 0x00321266
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Execute()
		{
			base.ExecuteInternal(null);
		}

		// Token: 0x06021F0B RID: 139019 RVA: 0x00323074 File Offset: 0x00321274
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

		// Token: 0x040121A7 RID: 74151
		internal static IntPtr _FunctionPtr;

		// Token: 0x040121A8 RID: 74152
		[Nullable(1)]
		public const string __ObjectPath = "/Script/MobilePatchingUtils.OnContentInstallSucceeded__DelegateSignature";

		// Token: 0x040121A9 RID: 74153
		private static int RegisterId;

		// Token: 0x02003640 RID: 13888
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017707 RID: 96007
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
