using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;

namespace UnrealEngine
{
	// Token: 0x02000680 RID: 1664
	public sealed class FLGUIDrawableEvent_Empty_DynamicDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600906E RID: 36974 RVA: 0x000D8DC2 File Offset: 0x000D6FC2
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUIDrawableEvent_Empty_DynamicDelegate.StaticFunctionPtr();
		}

		// Token: 0x0600906F RID: 36975 RVA: 0x000D8DCE File Offset: 0x000D6FCE
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUIDrawableEvent_Empty_DynamicDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLGUIDrawableEvent_Empty_DynamicDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUIDrawableEvent_Empty_DynamicDelegate__DelegateSignature");
			}
			return FLGUIDrawableEvent_Empty_DynamicDelegate._FunctionPtr;
		}

		// Token: 0x06009070 RID: 36976 RVA: 0x000D8DF1 File Offset: 0x000D6FF1
		public FLGUIDrawableEvent_Empty_DynamicDelegate()
		{
		}

		// Token: 0x06009071 RID: 36977 RVA: 0x000D8DF9 File Offset: 0x000D6FF9
		[NullableContext(2)]
		public FLGUIDrawableEvent_Empty_DynamicDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06009072 RID: 36978 RVA: 0x000D8E03 File Offset: 0x000D7003
		public FLGUIDrawableEvent_Empty_DynamicDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06009073 RID: 36979 RVA: 0x000D8E0E File Offset: 0x000D700E
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x06009074 RID: 36980 RVA: 0x000D8E40 File Offset: 0x000D7040
		[NullableContext(1)]
		public void Bind(Action Callback)
		{
			if (FLGUIDrawableEvent_Empty_DynamicDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLGUIDrawableEvent_Empty_DynamicDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLGUIDrawableEvent_Empty_DynamicDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLGUIDrawableEvent_Empty_DynamicDelegate.OnScriptCallback));
				}
				FLGUIDrawableEvent_Empty_DynamicDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLGUIDrawableEvent_Empty_DynamicDelegate.RegisterId);
		}

		// Token: 0x06009075 RID: 36981 RVA: 0x000D8E7A File Offset: 0x000D707A
		[SkipLocalsInit]
		public void Execute()
		{
			base.ExecuteInternal(null);
		}

		// Token: 0x06009076 RID: 36982 RVA: 0x000D8E88 File Offset: 0x000D7088
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

		// Token: 0x04003F19 RID: 16153
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003F1A RID: 16154
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUIDrawableEvent_Empty_DynamicDelegate__DelegateSignature";

		// Token: 0x04003F1B RID: 16155
		private static int RegisterId;

		// Token: 0x02000E94 RID: 3732
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04006243 RID: 25155
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
