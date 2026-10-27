using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;

namespace UnrealEngine
{
	// Token: 0x02001856 RID: 6230
	public sealed class FCustomPlayerRangeLeaveEvent : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06016F22 RID: 93986 RVA: 0x00217B06 File Offset: 0x00215D06
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FCustomPlayerRangeLeaveEvent.StaticFunctionPtr();
		}

		// Token: 0x06016F23 RID: 93987 RVA: 0x00217B12 File Offset: 0x00215D12
		private static IntPtr StaticFunctionPtr()
		{
			if (FCustomPlayerRangeLeaveEvent._FunctionPtr == IntPtr.Zero)
			{
				FCustomPlayerRangeLeaveEvent._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroGameBudget.CustomPlayerRangeLeaveEvent__DelegateSignature");
			}
			return FCustomPlayerRangeLeaveEvent._FunctionPtr;
		}

		// Token: 0x06016F24 RID: 93988 RVA: 0x00217B35 File Offset: 0x00215D35
		public FCustomPlayerRangeLeaveEvent()
		{
		}

		// Token: 0x06016F25 RID: 93989 RVA: 0x00217B3D File Offset: 0x00215D3D
		[NullableContext(2)]
		public FCustomPlayerRangeLeaveEvent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06016F26 RID: 93990 RVA: 0x00217B47 File Offset: 0x00215D47
		public FCustomPlayerRangeLeaveEvent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06016F27 RID: 93991 RVA: 0x00217B52 File Offset: 0x00215D52
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x06016F28 RID: 93992 RVA: 0x00217B84 File Offset: 0x00215D84
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action Callback)
		{
			if (FCustomPlayerRangeLeaveEvent.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FCustomPlayerRangeLeaveEvent.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FCustomPlayerRangeLeaveEvent.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FCustomPlayerRangeLeaveEvent.OnScriptCallback));
				}
				FCustomPlayerRangeLeaveEvent.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FCustomPlayerRangeLeaveEvent.RegisterId);
		}

		// Token: 0x06016F29 RID: 93993 RVA: 0x00217BBE File Offset: 0x00215DBE
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Execute()
		{
			base.ExecuteInternal(null);
		}

		// Token: 0x06016F2A RID: 93994 RVA: 0x00217BCC File Offset: 0x00215DCC
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

		// Token: 0x0400C76B RID: 51051
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400C76C RID: 51052
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameBudget.CustomPlayerRangeLeaveEvent__DelegateSignature";

		// Token: 0x0400C76D RID: 51053
		private static int RegisterId;

		// Token: 0x02002F71 RID: 12145
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016B2C RID: 92972
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
