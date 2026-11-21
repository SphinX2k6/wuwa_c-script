using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020006D6 RID: 1750
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnUndeterminedClicked : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060094E6 RID: 38118 RVA: 0x000E0AFA File Offset: 0x000DECFA
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnUndeterminedClicked.StaticFunctionPtr();
		}

		// Token: 0x060094E7 RID: 38119 RVA: 0x000E0B06 File Offset: 0x000DED06
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnUndeterminedClicked._FunctionPtr == IntPtr.Zero)
			{
				FOnUndeterminedClicked._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.OnUndeterminedClicked__DelegateSignature");
			}
			return FOnUndeterminedClicked._FunctionPtr;
		}

		// Token: 0x060094E8 RID: 38120 RVA: 0x000E0B29 File Offset: 0x000DED29
		public FOnUndeterminedClicked()
		{
		}

		// Token: 0x060094E9 RID: 38121 RVA: 0x000E0B31 File Offset: 0x000DED31
		[NullableContext(2)]
		public FOnUndeterminedClicked(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060094EA RID: 38122 RVA: 0x000E0B3B File Offset: 0x000DED3B
		public FOnUndeterminedClicked(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060094EB RID: 38123 RVA: 0x000E0B46 File Offset: 0x000DED46
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x060094EC RID: 38124 RVA: 0x000E0B78 File Offset: 0x000DED78
		[NullableContext(1)]
		public void Add(Action Callback)
		{
			if (FOnUndeterminedClicked.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnUndeterminedClicked.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnUndeterminedClicked.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnUndeterminedClicked.OnScriptCallback));
				}
				FOnUndeterminedClicked.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnUndeterminedClicked.RegisterId);
		}

		// Token: 0x060094ED RID: 38125 RVA: 0x000E0BB2 File Offset: 0x000DEDB2
		[NullableContext(1)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x060094EE RID: 38126 RVA: 0x000E0BBB File Offset: 0x000DEDBB
		[SkipLocalsInit]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x060094EF RID: 38127 RVA: 0x000E0BC8 File Offset: 0x000DEDC8
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

		// Token: 0x040040C0 RID: 16576
		internal static IntPtr _FunctionPtr;

		// Token: 0x040040C1 RID: 16577
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.OnUndeterminedClicked__DelegateSignature";

		// Token: 0x040040C2 RID: 16578
		private static int RegisterId;

		// Token: 0x02000F0B RID: 3851
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040062D8 RID: 25304
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
