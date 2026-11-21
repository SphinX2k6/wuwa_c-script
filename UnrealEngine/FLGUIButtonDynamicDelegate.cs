using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;

namespace UnrealEngine
{
	// Token: 0x0200066F RID: 1647
	public sealed class FLGUIButtonDynamicDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06008EF1 RID: 36593 RVA: 0x000D6ED0 File Offset: 0x000D50D0
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUIButtonDynamicDelegate.StaticFunctionPtr();
		}

		// Token: 0x06008EF2 RID: 36594 RVA: 0x000D6EDC File Offset: 0x000D50DC
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUIButtonDynamicDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLGUIButtonDynamicDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUIButtonDynamicDelegate__DelegateSignature");
			}
			return FLGUIButtonDynamicDelegate._FunctionPtr;
		}

		// Token: 0x06008EF3 RID: 36595 RVA: 0x000D6EFF File Offset: 0x000D50FF
		public FLGUIButtonDynamicDelegate()
		{
		}

		// Token: 0x06008EF4 RID: 36596 RVA: 0x000D6F07 File Offset: 0x000D5107
		[NullableContext(2)]
		public FLGUIButtonDynamicDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06008EF5 RID: 36597 RVA: 0x000D6F11 File Offset: 0x000D5111
		public FLGUIButtonDynamicDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06008EF6 RID: 36598 RVA: 0x000D6F1C File Offset: 0x000D511C
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x06008EF7 RID: 36599 RVA: 0x000D6F4E File Offset: 0x000D514E
		[NullableContext(1)]
		public void Bind(Action Callback)
		{
			if (FLGUIButtonDynamicDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLGUIButtonDynamicDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLGUIButtonDynamicDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLGUIButtonDynamicDelegate.OnScriptCallback));
				}
				FLGUIButtonDynamicDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLGUIButtonDynamicDelegate.RegisterId);
		}

		// Token: 0x06008EF8 RID: 36600 RVA: 0x000D6F88 File Offset: 0x000D5188
		[SkipLocalsInit]
		public void Execute()
		{
			base.ExecuteInternal(null);
		}

		// Token: 0x06008EF9 RID: 36601 RVA: 0x000D6F94 File Offset: 0x000D5194
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

		// Token: 0x04003EAB RID: 16043
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003EAC RID: 16044
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUIButtonDynamicDelegate__DelegateSignature";

		// Token: 0x04003EAD RID: 16045
		private static int RegisterId;

		// Token: 0x02000E7C RID: 3708
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04006228 RID: 25128
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
