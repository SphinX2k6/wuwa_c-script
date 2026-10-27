using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;

namespace UnrealEngine
{
	// Token: 0x02001854 RID: 6228
	public sealed class FCustomPlayerRangeEnterEvent : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06016F0D RID: 93965 RVA: 0x002178BE File Offset: 0x00215ABE
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FCustomPlayerRangeEnterEvent.StaticFunctionPtr();
		}

		// Token: 0x06016F0E RID: 93966 RVA: 0x002178CA File Offset: 0x00215ACA
		private static IntPtr StaticFunctionPtr()
		{
			if (FCustomPlayerRangeEnterEvent._FunctionPtr == IntPtr.Zero)
			{
				FCustomPlayerRangeEnterEvent._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroGameBudget.CustomPlayerRangeEnterEvent__DelegateSignature");
			}
			return FCustomPlayerRangeEnterEvent._FunctionPtr;
		}

		// Token: 0x06016F0F RID: 93967 RVA: 0x002178ED File Offset: 0x00215AED
		public FCustomPlayerRangeEnterEvent()
		{
		}

		// Token: 0x06016F10 RID: 93968 RVA: 0x002178F5 File Offset: 0x00215AF5
		[NullableContext(2)]
		public FCustomPlayerRangeEnterEvent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06016F11 RID: 93969 RVA: 0x002178FF File Offset: 0x00215AFF
		public FCustomPlayerRangeEnterEvent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06016F12 RID: 93970 RVA: 0x0021790A File Offset: 0x00215B0A
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x06016F13 RID: 93971 RVA: 0x0021793C File Offset: 0x00215B3C
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action Callback)
		{
			if (FCustomPlayerRangeEnterEvent.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FCustomPlayerRangeEnterEvent.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FCustomPlayerRangeEnterEvent.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FCustomPlayerRangeEnterEvent.OnScriptCallback));
				}
				FCustomPlayerRangeEnterEvent.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FCustomPlayerRangeEnterEvent.RegisterId);
		}

		// Token: 0x06016F14 RID: 93972 RVA: 0x00217976 File Offset: 0x00215B76
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Execute()
		{
			base.ExecuteInternal(null);
		}

		// Token: 0x06016F15 RID: 93973 RVA: 0x00217984 File Offset: 0x00215B84
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

		// Token: 0x0400C762 RID: 51042
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400C763 RID: 51043
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameBudget.CustomPlayerRangeEnterEvent__DelegateSignature";

		// Token: 0x0400C764 RID: 51044
		private static int RegisterId;

		// Token: 0x02002F70 RID: 12144
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016B2B RID: 92971
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
