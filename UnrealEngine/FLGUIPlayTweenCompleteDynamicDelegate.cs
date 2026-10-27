using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;

namespace UnrealEngine
{
	// Token: 0x02002094 RID: 8340
	public sealed class FLGUIPlayTweenCompleteDynamicDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601F74F RID: 128847 RVA: 0x002EBC19 File Offset: 0x002E9E19
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUIPlayTweenCompleteDynamicDelegate.StaticFunctionPtr();
		}

		// Token: 0x0601F750 RID: 128848 RVA: 0x002EBC25 File Offset: 0x002E9E25
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUIPlayTweenCompleteDynamicDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLGUIPlayTweenCompleteDynamicDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUIPlayTweenCompleteDynamicDelegate__DelegateSignature");
			}
			return FLGUIPlayTweenCompleteDynamicDelegate._FunctionPtr;
		}

		// Token: 0x0601F751 RID: 128849 RVA: 0x002EBC48 File Offset: 0x002E9E48
		public FLGUIPlayTweenCompleteDynamicDelegate()
		{
		}

		// Token: 0x0601F752 RID: 128850 RVA: 0x002EBC50 File Offset: 0x002E9E50
		[NullableContext(2)]
		public FLGUIPlayTweenCompleteDynamicDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F753 RID: 128851 RVA: 0x002EBC5A File Offset: 0x002E9E5A
		public FLGUIPlayTweenCompleteDynamicDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F754 RID: 128852 RVA: 0x002EBC65 File Offset: 0x002E9E65
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601F755 RID: 128853 RVA: 0x002EBC97 File Offset: 0x002E9E97
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action Callback)
		{
			if (FLGUIPlayTweenCompleteDynamicDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLGUIPlayTweenCompleteDynamicDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLGUIPlayTweenCompleteDynamicDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLGUIPlayTweenCompleteDynamicDelegate.OnScriptCallback));
				}
				FLGUIPlayTweenCompleteDynamicDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLGUIPlayTweenCompleteDynamicDelegate.RegisterId);
		}

		// Token: 0x0601F756 RID: 128854 RVA: 0x002EBCD1 File Offset: 0x002E9ED1
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Execute()
		{
			base.ExecuteInternal(null);
		}

		// Token: 0x0601F757 RID: 128855 RVA: 0x002EBCDC File Offset: 0x002E9EDC
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

		// Token: 0x04010FC8 RID: 69576
		internal static IntPtr _FunctionPtr;

		// Token: 0x04010FC9 RID: 69577
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUIPlayTweenCompleteDynamicDelegate__DelegateSignature";

		// Token: 0x04010FCA RID: 69578
		private static int RegisterId;

		// Token: 0x02003498 RID: 13464
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017490 RID: 95376
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
