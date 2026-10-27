using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;

namespace UnrealEngine
{
	// Token: 0x02002083 RID: 8323
	public sealed class FLGUILoopScrollViewDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601F666 RID: 128614 RVA: 0x002EA164 File Offset: 0x002E8364
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUILoopScrollViewDelegate.StaticFunctionPtr();
		}

		// Token: 0x0601F667 RID: 128615 RVA: 0x002EA170 File Offset: 0x002E8370
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUILoopScrollViewDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLGUILoopScrollViewDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUILoopScrollViewDelegate__DelegateSignature");
			}
			return FLGUILoopScrollViewDelegate._FunctionPtr;
		}

		// Token: 0x0601F668 RID: 128616 RVA: 0x002EA193 File Offset: 0x002E8393
		public FLGUILoopScrollViewDelegate()
		{
		}

		// Token: 0x0601F669 RID: 128617 RVA: 0x002EA19B File Offset: 0x002E839B
		[NullableContext(2)]
		public FLGUILoopScrollViewDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F66A RID: 128618 RVA: 0x002EA1A5 File Offset: 0x002E83A5
		public FLGUILoopScrollViewDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F66B RID: 128619 RVA: 0x002EA1B0 File Offset: 0x002E83B0
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601F66C RID: 128620 RVA: 0x002EA1E2 File Offset: 0x002E83E2
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action Callback)
		{
			if (FLGUILoopScrollViewDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLGUILoopScrollViewDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLGUILoopScrollViewDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLGUILoopScrollViewDelegate.OnScriptCallback));
				}
				FLGUILoopScrollViewDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLGUILoopScrollViewDelegate.RegisterId);
		}

		// Token: 0x0601F66D RID: 128621 RVA: 0x002EA21C File Offset: 0x002E841C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Execute()
		{
			base.ExecuteInternal(null);
		}

		// Token: 0x0601F66E RID: 128622 RVA: 0x002EA228 File Offset: 0x002E8428
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

		// Token: 0x04010F58 RID: 69464
		internal static IntPtr _FunctionPtr;

		// Token: 0x04010F59 RID: 69465
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUILoopScrollViewDelegate__DelegateSignature";

		// Token: 0x04010F5A RID: 69466
		private static int RegisterId;

		// Token: 0x02003485 RID: 13445
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017473 RID: 95347
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
