using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001EE6 RID: 7910
	public sealed class FOnEditorPreEndPIE : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601E11D RID: 123165 RVA: 0x002CA2CA File Offset: 0x002C84CA
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnEditorPreEndPIE.StaticFunctionPtr();
		}

		// Token: 0x0601E11E RID: 123166 RVA: 0x002CA2D6 File Offset: 0x002C84D6
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnEditorPreEndPIE._FunctionPtr == IntPtr.Zero)
			{
				FOnEditorPreEndPIE._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroUtility.OnEditorPreEndPIE__DelegateSignature");
			}
			return FOnEditorPreEndPIE._FunctionPtr;
		}

		// Token: 0x0601E11F RID: 123167 RVA: 0x002CA2F9 File Offset: 0x002C84F9
		public FOnEditorPreEndPIE()
		{
		}

		// Token: 0x0601E120 RID: 123168 RVA: 0x002CA301 File Offset: 0x002C8501
		[NullableContext(2)]
		public FOnEditorPreEndPIE(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601E121 RID: 123169 RVA: 0x002CA30B File Offset: 0x002C850B
		public FOnEditorPreEndPIE(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601E122 RID: 123170 RVA: 0x002CA316 File Offset: 0x002C8516
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<bool>) ?? ((Action<bool>)Delegate.CreateDelegate(typeof(Action<bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601E123 RID: 123171 RVA: 0x002CA348 File Offset: 0x002C8548
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action<bool> Callback)
		{
			if (FOnEditorPreEndPIE.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnEditorPreEndPIE.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnEditorPreEndPIE.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnEditorPreEndPIE.OnScriptCallback));
				}
				FOnEditorPreEndPIE.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FOnEditorPreEndPIE.RegisterId);
		}

		// Token: 0x0601E124 RID: 123172 RVA: 0x002CA384 File Offset: 0x002C8584
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(bool bSimulateInEditor)
		{
			FOnEditorPreEndPIE.__FOnEditorPreEndPIE_DelegateParams* ptr = stackalloc FOnEditorPreEndPIE.__FOnEditorPreEndPIE_DelegateParams[(UIntPtr)16] + 15L / (long)sizeof(FOnEditorPreEndPIE.__FOnEditorPreEndPIE_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnEditorPreEndPIE.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->bSimulateInEditor = bSimulateInEditor;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0601E125 RID: 123173 RVA: 0x002CA3C4 File Offset: 0x002C85C4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<bool> action = target as Action<bool>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FOnEditorPreEndPIE.__FOnEditorPreEndPIE_DelegateParams*)__Parameters)->bSimulateInEditor);
		}

		// Token: 0x0401040C RID: 66572
		internal static IntPtr _FunctionPtr;

		// Token: 0x0401040D RID: 66573
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroUtility.OnEditorPreEndPIE__DelegateSignature";

		// Token: 0x0401040E RID: 66574
		private static int RegisterId;

		// Token: 0x020033B4 RID: 13236
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __FOnEditorPreEndPIE_DelegateParams
		{
			// Token: 0x04017368 RID: 95080
			[FieldOffset(0)]
			public bool bSimulateInEditor;
		}

		// Token: 0x020033B5 RID: 13237
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017369 RID: 95081
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
