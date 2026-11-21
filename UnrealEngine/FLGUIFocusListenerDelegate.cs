using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;

namespace UnrealEngine
{
	// Token: 0x0200069A RID: 1690
	public sealed class FLGUIFocusListenerDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060091A4 RID: 37284 RVA: 0x000DB3B1 File Offset: 0x000D95B1
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUIFocusListenerDelegate.StaticFunctionPtr();
		}

		// Token: 0x060091A5 RID: 37285 RVA: 0x000DB3BD File Offset: 0x000D95BD
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUIFocusListenerDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLGUIFocusListenerDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUIFocusListenerDelegate__DelegateSignature");
			}
			return FLGUIFocusListenerDelegate._FunctionPtr;
		}

		// Token: 0x060091A6 RID: 37286 RVA: 0x000DB3E0 File Offset: 0x000D95E0
		public FLGUIFocusListenerDelegate()
		{
		}

		// Token: 0x060091A7 RID: 37287 RVA: 0x000DB3E8 File Offset: 0x000D95E8
		[NullableContext(2)]
		public FLGUIFocusListenerDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060091A8 RID: 37288 RVA: 0x000DB3F2 File Offset: 0x000D95F2
		public FLGUIFocusListenerDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060091A9 RID: 37289 RVA: 0x000DB3FD File Offset: 0x000D95FD
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x060091AA RID: 37290 RVA: 0x000DB42F File Offset: 0x000D962F
		[NullableContext(1)]
		public void Bind(Action Callback)
		{
			if (FLGUIFocusListenerDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLGUIFocusListenerDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLGUIFocusListenerDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLGUIFocusListenerDelegate.OnScriptCallback));
				}
				FLGUIFocusListenerDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLGUIFocusListenerDelegate.RegisterId);
		}

		// Token: 0x060091AB RID: 37291 RVA: 0x000DB469 File Offset: 0x000D9669
		[SkipLocalsInit]
		public void Execute()
		{
			base.ExecuteInternal(null);
		}

		// Token: 0x060091AC RID: 37292 RVA: 0x000DB474 File Offset: 0x000D9674
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

		// Token: 0x04003F7B RID: 16251
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003F7C RID: 16252
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUIFocusListenerDelegate__DelegateSignature";

		// Token: 0x04003F7D RID: 16253
		private static int RegisterId;

		// Token: 0x02000EC3 RID: 3779
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0400627B RID: 25211
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
