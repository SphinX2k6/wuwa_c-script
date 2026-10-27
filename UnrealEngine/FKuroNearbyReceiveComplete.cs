using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;

namespace UnrealEngine
{
	// Token: 0x0200260F RID: 9743
	public sealed class FKuroNearbyReceiveComplete : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060243EA RID: 148458 RVA: 0x0035A9D6 File Offset: 0x00358BD6
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FKuroNearbyReceiveComplete.StaticFunctionPtr();
		}

		// Token: 0x060243EB RID: 148459 RVA: 0x0035A9E2 File Offset: 0x00358BE2
		private static IntPtr StaticFunctionPtr()
		{
			if (FKuroNearbyReceiveComplete._FunctionPtr == IntPtr.Zero)
			{
				FKuroNearbyReceiveComplete._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/OHNearby.KuroNearbyReceiveComplete__DelegateSignature");
			}
			return FKuroNearbyReceiveComplete._FunctionPtr;
		}

		// Token: 0x060243EC RID: 148460 RVA: 0x0035AA05 File Offset: 0x00358C05
		public FKuroNearbyReceiveComplete()
		{
		}

		// Token: 0x060243ED RID: 148461 RVA: 0x0035AA0D File Offset: 0x00358C0D
		[NullableContext(2)]
		public FKuroNearbyReceiveComplete(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060243EE RID: 148462 RVA: 0x0035AA17 File Offset: 0x00358C17
		public FKuroNearbyReceiveComplete(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060243EF RID: 148463 RVA: 0x0035AA22 File Offset: 0x00358C22
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x060243F0 RID: 148464 RVA: 0x0035AA54 File Offset: 0x00358C54
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x060243F1 RID: 148465 RVA: 0x0035AA8E File Offset: 0x00358C8E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Execute()
		{
			base.ExecuteInternal(null);
		}

		// Token: 0x060243F2 RID: 148466 RVA: 0x0035AA9C File Offset: 0x00358C9C
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

		// Token: 0x04013724 RID: 79652
		internal static IntPtr _FunctionPtr;

		// Token: 0x04013725 RID: 79653
		[Nullable(1)]
		public const string __ObjectPath = "/Script/OHNearby.KuroNearbyReceiveComplete__DelegateSignature";

		// Token: 0x04013726 RID: 79654
		private static int RegisterId;

		// Token: 0x0200367B RID: 13947
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017753 RID: 96083
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
