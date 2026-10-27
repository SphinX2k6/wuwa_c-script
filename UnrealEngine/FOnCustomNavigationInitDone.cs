using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020024A9 RID: 9385
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnCustomNavigationInitDone : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060231DA RID: 143834 RVA: 0x0033EDF6 File Offset: 0x0033CFF6
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnCustomNavigationInitDone.StaticFunctionPtr();
		}

		// Token: 0x060231DB RID: 143835 RVA: 0x0033EE02 File Offset: 0x0033D002
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnCustomNavigationInitDone._FunctionPtr == IntPtr.Zero)
			{
				FOnCustomNavigationInitDone._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/NavigationSystem.OnCustomNavigationInitDone__DelegateSignature");
			}
			return FOnCustomNavigationInitDone._FunctionPtr;
		}

		// Token: 0x060231DC RID: 143836 RVA: 0x0033EE25 File Offset: 0x0033D025
		public FOnCustomNavigationInitDone()
		{
		}

		// Token: 0x060231DD RID: 143837 RVA: 0x0033EE2D File Offset: 0x0033D02D
		[NullableContext(2)]
		public FOnCustomNavigationInitDone(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060231DE RID: 143838 RVA: 0x0033EE37 File Offset: 0x0033D037
		public FOnCustomNavigationInitDone(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060231DF RID: 143839 RVA: 0x0033EE42 File Offset: 0x0033D042
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x060231E0 RID: 143840 RVA: 0x0033EE74 File Offset: 0x0033D074
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action Callback)
		{
			if (FOnCustomNavigationInitDone.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnCustomNavigationInitDone.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnCustomNavigationInitDone.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnCustomNavigationInitDone.OnScriptCallback));
				}
				FOnCustomNavigationInitDone.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnCustomNavigationInitDone.RegisterId);
		}

		// Token: 0x060231E1 RID: 143841 RVA: 0x0033EEAE File Offset: 0x0033D0AE
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x060231E2 RID: 143842 RVA: 0x0033EEB7 File Offset: 0x0033D0B7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x060231E3 RID: 143843 RVA: 0x0033EEC4 File Offset: 0x0033D0C4
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

		// Token: 0x04012BF4 RID: 76788
		internal static IntPtr _FunctionPtr;

		// Token: 0x04012BF5 RID: 76789
		[Nullable(1)]
		public const string __ObjectPath = "/Script/NavigationSystem.OnCustomNavigationInitDone__DelegateSignature";

		// Token: 0x04012BF6 RID: 76790
		private static int RegisterId;

		// Token: 0x02003667 RID: 13927
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017738 RID: 96056
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
