using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001967 RID: 6503
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FKuroMontageWaitSimpleDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060182DC RID: 99036 RVA: 0x0023A0B8 File Offset: 0x002382B8
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FKuroMontageWaitSimpleDelegate.StaticFunctionPtr();
		}

		// Token: 0x060182DD RID: 99037 RVA: 0x0023A0C4 File Offset: 0x002382C4
		private static IntPtr StaticFunctionPtr()
		{
			if (FKuroMontageWaitSimpleDelegate._FunctionPtr == IntPtr.Zero)
			{
				FKuroMontageWaitSimpleDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroGAS.KuroMontageWaitSimpleDelegate__DelegateSignature");
			}
			return FKuroMontageWaitSimpleDelegate._FunctionPtr;
		}

		// Token: 0x060182DE RID: 99038 RVA: 0x0023A0E7 File Offset: 0x002382E7
		public FKuroMontageWaitSimpleDelegate()
		{
		}

		// Token: 0x060182DF RID: 99039 RVA: 0x0023A0EF File Offset: 0x002382EF
		[NullableContext(2)]
		public FKuroMontageWaitSimpleDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060182E0 RID: 99040 RVA: 0x0023A0F9 File Offset: 0x002382F9
		public FKuroMontageWaitSimpleDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060182E1 RID: 99041 RVA: 0x0023A104 File Offset: 0x00238304
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x060182E2 RID: 99042 RVA: 0x0023A136 File Offset: 0x00238336
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action Callback)
		{
			if (FKuroMontageWaitSimpleDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FKuroMontageWaitSimpleDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FKuroMontageWaitSimpleDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FKuroMontageWaitSimpleDelegate.OnScriptCallback));
				}
				FKuroMontageWaitSimpleDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FKuroMontageWaitSimpleDelegate.RegisterId);
		}

		// Token: 0x060182E3 RID: 99043 RVA: 0x0023A170 File Offset: 0x00238370
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x060182E4 RID: 99044 RVA: 0x0023A179 File Offset: 0x00238379
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x060182E5 RID: 99045 RVA: 0x0023A184 File Offset: 0x00238384
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

		// Token: 0x0400D1AB RID: 53675
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400D1AC RID: 53676
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGAS.KuroMontageWaitSimpleDelegate__DelegateSignature";

		// Token: 0x0400D1AD RID: 53677
		private static int RegisterId;

		// Token: 0x02003052 RID: 12370
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016D15 RID: 93461
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
