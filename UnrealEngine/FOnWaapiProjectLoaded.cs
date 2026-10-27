using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;

namespace UnrealEngine
{
	// Token: 0x02000298 RID: 664
	public sealed class FOnWaapiProjectLoaded : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600250D RID: 9485 RVA: 0x000374AE File Offset: 0x000356AE
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnWaapiProjectLoaded.StaticFunctionPtr();
		}

		// Token: 0x0600250E RID: 9486 RVA: 0x000374BA File Offset: 0x000356BA
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnWaapiProjectLoaded._FunctionPtr == IntPtr.Zero)
			{
				FOnWaapiProjectLoaded._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/AkAudio.OnWaapiProjectLoaded__DelegateSignature");
			}
			return FOnWaapiProjectLoaded._FunctionPtr;
		}

		// Token: 0x0600250F RID: 9487 RVA: 0x000374DD File Offset: 0x000356DD
		public FOnWaapiProjectLoaded()
		{
		}

		// Token: 0x06002510 RID: 9488 RVA: 0x000374E5 File Offset: 0x000356E5
		[NullableContext(2)]
		public FOnWaapiProjectLoaded(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06002511 RID: 9489 RVA: 0x000374EF File Offset: 0x000356EF
		public FOnWaapiProjectLoaded(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06002512 RID: 9490 RVA: 0x000374FA File Offset: 0x000356FA
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x06002513 RID: 9491 RVA: 0x0003752C File Offset: 0x0003572C
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action Callback)
		{
			if (FOnWaapiProjectLoaded.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnWaapiProjectLoaded.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnWaapiProjectLoaded.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnWaapiProjectLoaded.OnScriptCallback));
				}
				FOnWaapiProjectLoaded.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FOnWaapiProjectLoaded.RegisterId);
		}

		// Token: 0x06002514 RID: 9492 RVA: 0x00037566 File Offset: 0x00035766
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Execute()
		{
			base.ExecuteInternal(null);
		}

		// Token: 0x06002515 RID: 9493 RVA: 0x00037574 File Offset: 0x00035774
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

		// Token: 0x04000E12 RID: 3602
		internal static IntPtr _FunctionPtr;

		// Token: 0x04000E13 RID: 3603
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AkAudio.OnWaapiProjectLoaded__DelegateSignature";

		// Token: 0x04000E14 RID: 3604
		private static int RegisterId;

		// Token: 0x02002BA4 RID: 11172
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401643A RID: 91194
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
