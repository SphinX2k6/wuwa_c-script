using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;

namespace UnrealEngine
{
	// Token: 0x0200067A RID: 1658
	public sealed class FLGUIDraggableNavigateToPrevDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06009038 RID: 36920 RVA: 0x000D862E File Offset: 0x000D682E
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUIDraggableNavigateToPrevDelegate.StaticFunctionPtr();
		}

		// Token: 0x06009039 RID: 36921 RVA: 0x000D863A File Offset: 0x000D683A
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUIDraggableNavigateToPrevDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLGUIDraggableNavigateToPrevDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUIDraggableNavigateToPrevDelegate__DelegateSignature");
			}
			return FLGUIDraggableNavigateToPrevDelegate._FunctionPtr;
		}

		// Token: 0x0600903A RID: 36922 RVA: 0x000D865D File Offset: 0x000D685D
		public FLGUIDraggableNavigateToPrevDelegate()
		{
		}

		// Token: 0x0600903B RID: 36923 RVA: 0x000D8665 File Offset: 0x000D6865
		[NullableContext(2)]
		public FLGUIDraggableNavigateToPrevDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600903C RID: 36924 RVA: 0x000D866F File Offset: 0x000D686F
		public FLGUIDraggableNavigateToPrevDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600903D RID: 36925 RVA: 0x000D867A File Offset: 0x000D687A
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600903E RID: 36926 RVA: 0x000D86AC File Offset: 0x000D68AC
		[NullableContext(1)]
		public void Bind(Action Callback)
		{
			if (FLGUIDraggableNavigateToPrevDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLGUIDraggableNavigateToPrevDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLGUIDraggableNavigateToPrevDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLGUIDraggableNavigateToPrevDelegate.OnScriptCallback));
				}
				FLGUIDraggableNavigateToPrevDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLGUIDraggableNavigateToPrevDelegate.RegisterId);
		}

		// Token: 0x0600903F RID: 36927 RVA: 0x000D86E6 File Offset: 0x000D68E6
		[SkipLocalsInit]
		public void Execute()
		{
			base.ExecuteInternal(null);
		}

		// Token: 0x06009040 RID: 36928 RVA: 0x000D86F4 File Offset: 0x000D68F4
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

		// Token: 0x04003F07 RID: 16135
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003F08 RID: 16136
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUIDraggableNavigateToPrevDelegate__DelegateSignature";

		// Token: 0x04003F09 RID: 16137
		private static int RegisterId;

		// Token: 0x02000E88 RID: 3720
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04006237 RID: 25143
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
