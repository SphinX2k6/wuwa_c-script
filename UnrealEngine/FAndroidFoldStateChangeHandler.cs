using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020005B3 RID: 1459
	public sealed class FAndroidFoldStateChangeHandler : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06008321 RID: 33569 RVA: 0x000C1F28 File Offset: 0x000C0128
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FAndroidFoldStateChangeHandler.StaticFunctionPtr();
		}

		// Token: 0x06008322 RID: 33570 RVA: 0x000C1F34 File Offset: 0x000C0134
		private static IntPtr StaticFunctionPtr()
		{
			if (FAndroidFoldStateChangeHandler._FunctionPtr == IntPtr.Zero)
			{
				FAndroidFoldStateChangeHandler._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroUtility.AndroidFoldStateChangeHandler__DelegateSignature");
			}
			return FAndroidFoldStateChangeHandler._FunctionPtr;
		}

		// Token: 0x06008323 RID: 33571 RVA: 0x000C1F57 File Offset: 0x000C0157
		public FAndroidFoldStateChangeHandler()
		{
		}

		// Token: 0x06008324 RID: 33572 RVA: 0x000C1F5F File Offset: 0x000C015F
		[NullableContext(2)]
		public FAndroidFoldStateChangeHandler(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06008325 RID: 33573 RVA: 0x000C1F69 File Offset: 0x000C0169
		public FAndroidFoldStateChangeHandler(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06008326 RID: 33574 RVA: 0x000C1F74 File Offset: 0x000C0174
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<bool>) ?? ((Action<bool>)Delegate.CreateDelegate(typeof(Action<bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06008327 RID: 33575 RVA: 0x000C1FA6 File Offset: 0x000C01A6
		[NullableContext(1)]
		public void Bind(Action<bool> Callback)
		{
			if (FAndroidFoldStateChangeHandler.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FAndroidFoldStateChangeHandler.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FAndroidFoldStateChangeHandler.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FAndroidFoldStateChangeHandler.OnScriptCallback));
				}
				FAndroidFoldStateChangeHandler.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FAndroidFoldStateChangeHandler.RegisterId);
		}

		// Token: 0x06008328 RID: 33576 RVA: 0x000C1FE0 File Offset: 0x000C01E0
		[SkipLocalsInit]
		public unsafe void Execute(bool bIsFolded)
		{
			FAndroidFoldStateChangeHandler.__FAndroidFoldStateChangeHandler_DelegateParams* ptr = stackalloc FAndroidFoldStateChangeHandler.__FAndroidFoldStateChangeHandler_DelegateParams[(UIntPtr)16] + 15L / (long)sizeof(FAndroidFoldStateChangeHandler.__FAndroidFoldStateChangeHandler_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FAndroidFoldStateChangeHandler.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->bIsFolded = bIsFolded;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x06008329 RID: 33577 RVA: 0x000C2020 File Offset: 0x000C0220
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<bool> action = target as Action<bool>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FAndroidFoldStateChangeHandler.__FAndroidFoldStateChangeHandler_DelegateParams*)__Parameters)->bIsFolded);
		}

		// Token: 0x0400390A RID: 14602
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400390B RID: 14603
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroUtility.AndroidFoldStateChangeHandler__DelegateSignature";

		// Token: 0x0400390C RID: 14604
		private static int RegisterId;

		// Token: 0x02000D34 RID: 3380
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		private ref struct __FAndroidFoldStateChangeHandler_DelegateParams
		{
			// Token: 0x04005FCE RID: 24526
			[FieldOffset(0)]
			public bool bIsFolded;
		}

		// Token: 0x02000D35 RID: 3381
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005FCF RID: 24527
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
