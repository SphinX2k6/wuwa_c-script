using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;

namespace UnrealEngine
{
	// Token: 0x020006BE RID: 1726
	public sealed class FLGUISliderEndDragDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060093D4 RID: 37844 RVA: 0x000DEC7E File Offset: 0x000DCE7E
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUISliderEndDragDelegate.StaticFunctionPtr();
		}

		// Token: 0x060093D5 RID: 37845 RVA: 0x000DEC8A File Offset: 0x000DCE8A
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUISliderEndDragDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLGUISliderEndDragDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUISliderEndDragDelegate__DelegateSignature");
			}
			return FLGUISliderEndDragDelegate._FunctionPtr;
		}

		// Token: 0x060093D6 RID: 37846 RVA: 0x000DECAD File Offset: 0x000DCEAD
		public FLGUISliderEndDragDelegate()
		{
		}

		// Token: 0x060093D7 RID: 37847 RVA: 0x000DECB5 File Offset: 0x000DCEB5
		[NullableContext(2)]
		public FLGUISliderEndDragDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060093D8 RID: 37848 RVA: 0x000DECBF File Offset: 0x000DCEBF
		public FLGUISliderEndDragDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060093D9 RID: 37849 RVA: 0x000DECCA File Offset: 0x000DCECA
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x060093DA RID: 37850 RVA: 0x000DECFC File Offset: 0x000DCEFC
		[NullableContext(1)]
		public void Bind(Action Callback)
		{
			if (FLGUISliderEndDragDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLGUISliderEndDragDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLGUISliderEndDragDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLGUISliderEndDragDelegate.OnScriptCallback));
				}
				FLGUISliderEndDragDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLGUISliderEndDragDelegate.RegisterId);
		}

		// Token: 0x060093DB RID: 37851 RVA: 0x000DED36 File Offset: 0x000DCF36
		[SkipLocalsInit]
		public void Execute()
		{
			base.ExecuteInternal(null);
		}

		// Token: 0x060093DC RID: 37852 RVA: 0x000DED44 File Offset: 0x000DCF44
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

		// Token: 0x0400406F RID: 16495
		internal static IntPtr _FunctionPtr;

		// Token: 0x04004070 RID: 16496
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUISliderEndDragDelegate__DelegateSignature";

		// Token: 0x04004071 RID: 16497
		private static int RegisterId;

		// Token: 0x02000EEC RID: 3820
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040062AE RID: 25262
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
