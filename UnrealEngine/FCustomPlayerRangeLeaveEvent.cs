using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;

namespace UnrealEngine
{
	// Token: 0x02000390 RID: 912
	public sealed class FCustomPlayerRangeLeaveEvent : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06005B1B RID: 23323 RVA: 0x00080AF6 File Offset: 0x0007ECF6
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FCustomPlayerRangeLeaveEvent.StaticFunctionPtr();
		}

		// Token: 0x06005B1C RID: 23324 RVA: 0x00080B02 File Offset: 0x0007ED02
		private static IntPtr StaticFunctionPtr()
		{
			if (FCustomPlayerRangeLeaveEvent._FunctionPtr == IntPtr.Zero)
			{
				FCustomPlayerRangeLeaveEvent._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroGameBudget.CustomPlayerRangeLeaveEvent__DelegateSignature");
			}
			return FCustomPlayerRangeLeaveEvent._FunctionPtr;
		}

		// Token: 0x06005B1D RID: 23325 RVA: 0x00080B25 File Offset: 0x0007ED25
		public FCustomPlayerRangeLeaveEvent()
		{
		}

		// Token: 0x06005B1E RID: 23326 RVA: 0x00080B2D File Offset: 0x0007ED2D
		[NullableContext(2)]
		public FCustomPlayerRangeLeaveEvent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005B1F RID: 23327 RVA: 0x00080B37 File Offset: 0x0007ED37
		public FCustomPlayerRangeLeaveEvent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005B20 RID: 23328 RVA: 0x00080B42 File Offset: 0x0007ED42
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x06005B21 RID: 23329 RVA: 0x00080B74 File Offset: 0x0007ED74
		[NullableContext(1)]
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

		// Token: 0x06005B22 RID: 23330 RVA: 0x00080BAE File Offset: 0x0007EDAE
		[SkipLocalsInit]
		public void Execute()
		{
			base.ExecuteInternal(null);
		}

		// Token: 0x06005B23 RID: 23331 RVA: 0x00080BBC File Offset: 0x0007EDBC
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

		// Token: 0x040025DA RID: 9690
		internal static IntPtr _FunctionPtr;

		// Token: 0x040025DB RID: 9691
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameBudget.CustomPlayerRangeLeaveEvent__DelegateSignature";

		// Token: 0x040025DC RID: 9692
		private static int RegisterId;

		// Token: 0x02000A9A RID: 2714
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005AEE RID: 23278
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
