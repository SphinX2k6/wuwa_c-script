using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;

namespace UnrealEngine
{
	// Token: 0x020007AD RID: 1965
	public sealed class FKuroNearbyReceiveComplete : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600AACB RID: 43723 RVA: 0x000FBEC7 File Offset: 0x000FA0C7
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FKuroNearbyReceiveComplete.StaticFunctionPtr();
		}

		// Token: 0x0600AACC RID: 43724 RVA: 0x000FBED3 File Offset: 0x000FA0D3
		private static IntPtr StaticFunctionPtr()
		{
			if (FKuroNearbyReceiveComplete._FunctionPtr == IntPtr.Zero)
			{
				FKuroNearbyReceiveComplete._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/OHNearby.KuroNearbyReceiveComplete__DelegateSignature");
			}
			return FKuroNearbyReceiveComplete._FunctionPtr;
		}

		// Token: 0x0600AACD RID: 43725 RVA: 0x000FBEF6 File Offset: 0x000FA0F6
		public FKuroNearbyReceiveComplete()
		{
		}

		// Token: 0x0600AACE RID: 43726 RVA: 0x000FBEFE File Offset: 0x000FA0FE
		[NullableContext(2)]
		public FKuroNearbyReceiveComplete(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600AACF RID: 43727 RVA: 0x000FBF08 File Offset: 0x000FA108
		public FKuroNearbyReceiveComplete(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600AAD0 RID: 43728 RVA: 0x000FBF13 File Offset: 0x000FA113
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600AAD1 RID: 43729 RVA: 0x000FBF45 File Offset: 0x000FA145
		[NullableContext(1)]
		public void Bind(Action Callback)
		{
			if (FKuroNearbyReceiveComplete.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FKuroNearbyReceiveComplete.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FKuroNearbyReceiveComplete.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FKuroNearbyReceiveComplete.OnScriptCallback));
				}
				FKuroNearbyReceiveComplete.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FKuroNearbyReceiveComplete.RegisterId);
		}

		// Token: 0x0600AAD2 RID: 43730 RVA: 0x000FBF7F File Offset: 0x000FA17F
		[SkipLocalsInit]
		public void Execute()
		{
			base.ExecuteInternal(null);
		}

		// Token: 0x0600AAD3 RID: 43731 RVA: 0x000FBF8C File Offset: 0x000FA18C
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

		// Token: 0x04004922 RID: 18722
		internal static IntPtr _FunctionPtr;

		// Token: 0x04004923 RID: 18723
		[Nullable(1)]
		public const string __ObjectPath = "/Script/OHNearby.KuroNearbyReceiveComplete__DelegateSignature";

		// Token: 0x04004924 RID: 18724
		private static int RegisterId;

		// Token: 0x02000F64 RID: 3940
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0400633B RID: 25403
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
