using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;

namespace UnrealEngine
{
	// Token: 0x02002017 RID: 8215
	public sealed class FInturnSequenceEvent : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601EF56 RID: 126806 RVA: 0x002E0A46 File Offset: 0x002DEC46
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FInturnSequenceEvent.StaticFunctionPtr();
		}

		// Token: 0x0601EF57 RID: 126807 RVA: 0x002E0A52 File Offset: 0x002DEC52
		private static IntPtr StaticFunctionPtr()
		{
			if (FInturnSequenceEvent._FunctionPtr == IntPtr.Zero)
			{
				FInturnSequenceEvent._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.InturnSequenceEvent__DelegateSignature");
			}
			return FInturnSequenceEvent._FunctionPtr;
		}

		// Token: 0x0601EF58 RID: 126808 RVA: 0x002E0A75 File Offset: 0x002DEC75
		public FInturnSequenceEvent()
		{
		}

		// Token: 0x0601EF59 RID: 126809 RVA: 0x002E0A7D File Offset: 0x002DEC7D
		[NullableContext(2)]
		public FInturnSequenceEvent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601EF5A RID: 126810 RVA: 0x002E0A87 File Offset: 0x002DEC87
		public FInturnSequenceEvent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601EF5B RID: 126811 RVA: 0x002E0A92 File Offset: 0x002DEC92
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601EF5C RID: 126812 RVA: 0x002E0AC4 File Offset: 0x002DECC4
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action Callback)
		{
			if (FInturnSequenceEvent.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FInturnSequenceEvent.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FInturnSequenceEvent.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FInturnSequenceEvent.OnScriptCallback));
				}
				FInturnSequenceEvent.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FInturnSequenceEvent.RegisterId);
		}

		// Token: 0x0601EF5D RID: 126813 RVA: 0x002E0AFE File Offset: 0x002DECFE
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Execute()
		{
			base.ExecuteInternal(null);
		}

		// Token: 0x0601EF5E RID: 126814 RVA: 0x002E0B0C File Offset: 0x002DED0C
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

		// Token: 0x04010D4D RID: 68941
		internal static IntPtr _FunctionPtr;

		// Token: 0x04010D4E RID: 68942
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.InturnSequenceEvent__DelegateSignature";

		// Token: 0x04010D4F RID: 68943
		private static int RegisterId;

		// Token: 0x02003428 RID: 13352
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017404 RID: 95236
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
