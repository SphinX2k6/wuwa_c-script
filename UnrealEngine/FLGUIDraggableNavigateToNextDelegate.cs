using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;

namespace UnrealEngine
{
	// Token: 0x02000679 RID: 1657
	public sealed class FLGUIDraggableNavigateToNextDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600902F RID: 36911 RVA: 0x000D8528 File Offset: 0x000D6728
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUIDraggableNavigateToNextDelegate.StaticFunctionPtr();
		}

		// Token: 0x06009030 RID: 36912 RVA: 0x000D8534 File Offset: 0x000D6734
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUIDraggableNavigateToNextDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLGUIDraggableNavigateToNextDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUIDraggableNavigateToNextDelegate__DelegateSignature");
			}
			return FLGUIDraggableNavigateToNextDelegate._FunctionPtr;
		}

		// Token: 0x06009031 RID: 36913 RVA: 0x000D8557 File Offset: 0x000D6757
		public FLGUIDraggableNavigateToNextDelegate()
		{
		}

		// Token: 0x06009032 RID: 36914 RVA: 0x000D855F File Offset: 0x000D675F
		[NullableContext(2)]
		public FLGUIDraggableNavigateToNextDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06009033 RID: 36915 RVA: 0x000D8569 File Offset: 0x000D6769
		public FLGUIDraggableNavigateToNextDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06009034 RID: 36916 RVA: 0x000D8574 File Offset: 0x000D6774
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x06009035 RID: 36917 RVA: 0x000D85A6 File Offset: 0x000D67A6
		[NullableContext(1)]
		public void Bind(Action Callback)
		{
			if (FLGUIDraggableNavigateToNextDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLGUIDraggableNavigateToNextDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLGUIDraggableNavigateToNextDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLGUIDraggableNavigateToNextDelegate.OnScriptCallback));
				}
				FLGUIDraggableNavigateToNextDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLGUIDraggableNavigateToNextDelegate.RegisterId);
		}

		// Token: 0x06009036 RID: 36918 RVA: 0x000D85E0 File Offset: 0x000D67E0
		[SkipLocalsInit]
		public void Execute()
		{
			base.ExecuteInternal(null);
		}

		// Token: 0x06009037 RID: 36919 RVA: 0x000D85EC File Offset: 0x000D67EC
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

		// Token: 0x04003F04 RID: 16132
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003F05 RID: 16133
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUIDraggableNavigateToNextDelegate__DelegateSignature";

		// Token: 0x04003F06 RID: 16134
		private static int RegisterId;

		// Token: 0x02000E87 RID: 3719
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04006236 RID: 25142
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
