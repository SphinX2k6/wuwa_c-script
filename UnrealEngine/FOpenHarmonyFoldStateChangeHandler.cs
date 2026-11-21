using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000604 RID: 1540
	public sealed class FOpenHarmonyFoldStateChangeHandler : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06008803 RID: 34819 RVA: 0x000CCC44 File Offset: 0x000CAE44
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOpenHarmonyFoldStateChangeHandler.StaticFunctionPtr();
		}

		// Token: 0x06008804 RID: 34820 RVA: 0x000CCC50 File Offset: 0x000CAE50
		private static IntPtr StaticFunctionPtr()
		{
			if (FOpenHarmonyFoldStateChangeHandler._FunctionPtr == IntPtr.Zero)
			{
				FOpenHarmonyFoldStateChangeHandler._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroUtility.OpenHarmonyFoldStateChangeHandler__DelegateSignature");
			}
			return FOpenHarmonyFoldStateChangeHandler._FunctionPtr;
		}

		// Token: 0x06008805 RID: 34821 RVA: 0x000CCC73 File Offset: 0x000CAE73
		public FOpenHarmonyFoldStateChangeHandler()
		{
		}

		// Token: 0x06008806 RID: 34822 RVA: 0x000CCC7B File Offset: 0x000CAE7B
		[NullableContext(2)]
		public FOpenHarmonyFoldStateChangeHandler(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06008807 RID: 34823 RVA: 0x000CCC85 File Offset: 0x000CAE85
		public FOpenHarmonyFoldStateChangeHandler(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06008808 RID: 34824 RVA: 0x000CCC90 File Offset: 0x000CAE90
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<bool>) ?? ((Action<bool>)Delegate.CreateDelegate(typeof(Action<bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06008809 RID: 34825 RVA: 0x000CCCC2 File Offset: 0x000CAEC2
		[NullableContext(1)]
		public void Bind(Action<bool> Callback)
		{
			if (FOpenHarmonyFoldStateChangeHandler.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOpenHarmonyFoldStateChangeHandler.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOpenHarmonyFoldStateChangeHandler.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOpenHarmonyFoldStateChangeHandler.OnScriptCallback));
				}
				FOpenHarmonyFoldStateChangeHandler.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FOpenHarmonyFoldStateChangeHandler.RegisterId);
		}

		// Token: 0x0600880A RID: 34826 RVA: 0x000CCCFC File Offset: 0x000CAEFC
		[SkipLocalsInit]
		public unsafe void Execute(bool bIsFolded)
		{
			FOpenHarmonyFoldStateChangeHandler.__FOpenHarmonyFoldStateChangeHandler_DelegateParams* ptr = stackalloc FOpenHarmonyFoldStateChangeHandler.__FOpenHarmonyFoldStateChangeHandler_DelegateParams[(UIntPtr)16] + 15L / (long)sizeof(FOpenHarmonyFoldStateChangeHandler.__FOpenHarmonyFoldStateChangeHandler_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOpenHarmonyFoldStateChangeHandler.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->bIsFolded = bIsFolded;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0600880B RID: 34827 RVA: 0x000CCD3C File Offset: 0x000CAF3C
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<bool> action = target as Action<bool>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FOpenHarmonyFoldStateChangeHandler.__FOpenHarmonyFoldStateChangeHandler_DelegateParams*)__Parameters)->bIsFolded);
		}

		// Token: 0x04003B17 RID: 15127
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003B18 RID: 15128
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroUtility.OpenHarmonyFoldStateChangeHandler__DelegateSignature";

		// Token: 0x04003B19 RID: 15129
		private static int RegisterId;

		// Token: 0x02000E28 RID: 3624
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		private ref struct __FOpenHarmonyFoldStateChangeHandler_DelegateParams
		{
			// Token: 0x040061BD RID: 25021
			[FieldOffset(0)]
			public bool bIsFolded;
		}

		// Token: 0x02000E29 RID: 3625
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040061BE RID: 25022
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
