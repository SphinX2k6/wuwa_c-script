using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001F09 RID: 7945
	public sealed class FSetVisibleFinishDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601E278 RID: 123512 RVA: 0x002CD4E0 File Offset: 0x002CB6E0
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FSetVisibleFinishDelegate.StaticFunctionPtr();
		}

		// Token: 0x0601E279 RID: 123513 RVA: 0x002CD4EC File Offset: 0x002CB6EC
		private static IntPtr StaticFunctionPtr()
		{
			if (FSetVisibleFinishDelegate._FunctionPtr == IntPtr.Zero)
			{
				FSetVisibleFinishDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroUtility.SetVisibleFinishDelegate__DelegateSignature");
			}
			return FSetVisibleFinishDelegate._FunctionPtr;
		}

		// Token: 0x0601E27A RID: 123514 RVA: 0x002CD50F File Offset: 0x002CB70F
		public FSetVisibleFinishDelegate()
		{
		}

		// Token: 0x0601E27B RID: 123515 RVA: 0x002CD517 File Offset: 0x002CB717
		[NullableContext(2)]
		public FSetVisibleFinishDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601E27C RID: 123516 RVA: 0x002CD521 File Offset: 0x002CB721
		public FSetVisibleFinishDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601E27D RID: 123517 RVA: 0x002CD52C File Offset: 0x002CB72C
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<int>) ?? ((Action<int>)Delegate.CreateDelegate(typeof(Action<int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601E27E RID: 123518 RVA: 0x002CD55E File Offset: 0x002CB75E
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action<int> Callback)
		{
			if (FSetVisibleFinishDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FSetVisibleFinishDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FSetVisibleFinishDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FSetVisibleFinishDelegate.OnScriptCallback));
				}
				FSetVisibleFinishDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FSetVisibleFinishDelegate.RegisterId);
		}

		// Token: 0x0601E27F RID: 123519 RVA: 0x002CD598 File Offset: 0x002CB798
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(int LinkId)
		{
			FSetVisibleFinishDelegate.__FSetVisibleFinishDelegate_DelegateParams* ptr = stackalloc FSetVisibleFinishDelegate.__FSetVisibleFinishDelegate_DelegateParams[(UIntPtr)19] + 15L / (long)sizeof(FSetVisibleFinishDelegate.__FSetVisibleFinishDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FSetVisibleFinishDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->LinkId = LinkId;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0601E280 RID: 123520 RVA: 0x002CD5D8 File Offset: 0x002CB7D8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int> action = target as Action<int>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FSetVisibleFinishDelegate.__FSetVisibleFinishDelegate_DelegateParams*)__Parameters)->LinkId);
		}

		// Token: 0x04010489 RID: 66697
		internal static IntPtr _FunctionPtr;

		// Token: 0x0401048A RID: 66698
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroUtility.SetVisibleFinishDelegate__DelegateSignature";

		// Token: 0x0401048B RID: 66699
		private static int RegisterId;

		// Token: 0x020033F7 RID: 13303
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __FSetVisibleFinishDelegate_DelegateParams
		{
			// Token: 0x040173B1 RID: 95153
			[FieldOffset(0)]
			public int LinkId;
		}

		// Token: 0x020033F8 RID: 13304
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040173B2 RID: 95154
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
