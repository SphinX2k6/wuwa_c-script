using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020007E9 RID: 2025
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FSharpherealTestDynMultiDelegate0 : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600AD8F RID: 44431 RVA: 0x00100C9C File Offset: 0x000FEE9C
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FSharpherealTestDynMultiDelegate0.StaticFunctionPtr();
		}

		// Token: 0x0600AD90 RID: 44432 RVA: 0x00100CA8 File Offset: 0x000FEEA8
		private static IntPtr StaticFunctionPtr()
		{
			if (FSharpherealTestDynMultiDelegate0._FunctionPtr == IntPtr.Zero)
			{
				FSharpherealTestDynMultiDelegate0._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/SharpherealTest.SharpherealTestDynMultiDelegate0__DelegateSignature");
			}
			return FSharpherealTestDynMultiDelegate0._FunctionPtr;
		}

		// Token: 0x0600AD91 RID: 44433 RVA: 0x00100CCB File Offset: 0x000FEECB
		public FSharpherealTestDynMultiDelegate0()
		{
		}

		// Token: 0x0600AD92 RID: 44434 RVA: 0x00100CD3 File Offset: 0x000FEED3
		[NullableContext(2)]
		public FSharpherealTestDynMultiDelegate0(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600AD93 RID: 44435 RVA: 0x00100CDD File Offset: 0x000FEEDD
		public FSharpherealTestDynMultiDelegate0(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600AD94 RID: 44436 RVA: 0x00100CE8 File Offset: 0x000FEEE8
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600AD95 RID: 44437 RVA: 0x00100D1A File Offset: 0x000FEF1A
		[NullableContext(1)]
		public void Add(Action Callback)
		{
			if (FSharpherealTestDynMultiDelegate0.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FSharpherealTestDynMultiDelegate0.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FSharpherealTestDynMultiDelegate0.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FSharpherealTestDynMultiDelegate0.OnScriptCallback));
				}
				FSharpherealTestDynMultiDelegate0.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FSharpherealTestDynMultiDelegate0.RegisterId);
		}

		// Token: 0x0600AD96 RID: 44438 RVA: 0x00100D54 File Offset: 0x000FEF54
		[NullableContext(1)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0600AD97 RID: 44439 RVA: 0x00100D5D File Offset: 0x000FEF5D
		[SkipLocalsInit]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x0600AD98 RID: 44440 RVA: 0x00100D68 File Offset: 0x000FEF68
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

		// Token: 0x04004AE3 RID: 19171
		internal static IntPtr _FunctionPtr;

		// Token: 0x04004AE4 RID: 19172
		[Nullable(1)]
		public const string __ObjectPath = "/Script/SharpherealTest.SharpherealTestDynMultiDelegate0__DelegateSignature";

		// Token: 0x04004AE5 RID: 19173
		private static int RegisterId;

		// Token: 0x02000F93 RID: 3987
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04006393 RID: 25491
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
