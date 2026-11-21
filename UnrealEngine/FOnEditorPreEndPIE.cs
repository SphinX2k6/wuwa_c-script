using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020005F3 RID: 1523
	public sealed class FOnEditorPreEndPIE : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06008768 RID: 34664 RVA: 0x000CB2CE File Offset: 0x000C94CE
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnEditorPreEndPIE.StaticFunctionPtr();
		}

		// Token: 0x06008769 RID: 34665 RVA: 0x000CB2DA File Offset: 0x000C94DA
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnEditorPreEndPIE._FunctionPtr == IntPtr.Zero)
			{
				FOnEditorPreEndPIE._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroUtility.OnEditorPreEndPIE__DelegateSignature");
			}
			return FOnEditorPreEndPIE._FunctionPtr;
		}

		// Token: 0x0600876A RID: 34666 RVA: 0x000CB2FD File Offset: 0x000C94FD
		public FOnEditorPreEndPIE()
		{
		}

		// Token: 0x0600876B RID: 34667 RVA: 0x000CB305 File Offset: 0x000C9505
		[NullableContext(2)]
		public FOnEditorPreEndPIE(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600876C RID: 34668 RVA: 0x000CB30F File Offset: 0x000C950F
		public FOnEditorPreEndPIE(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600876D RID: 34669 RVA: 0x000CB31A File Offset: 0x000C951A
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<bool>) ?? ((Action<bool>)Delegate.CreateDelegate(typeof(Action<bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600876E RID: 34670 RVA: 0x000CB34C File Offset: 0x000C954C
		[NullableContext(1)]
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

		// Token: 0x0600876F RID: 34671 RVA: 0x000CB388 File Offset: 0x000C9588
		[SkipLocalsInit]
		public unsafe void Execute(bool bSimulateInEditor)
		{
			FOnEditorPreEndPIE.__FOnEditorPreEndPIE_DelegateParams* ptr = stackalloc FOnEditorPreEndPIE.__FOnEditorPreEndPIE_DelegateParams[(UIntPtr)16] + 15L / (long)sizeof(FOnEditorPreEndPIE.__FOnEditorPreEndPIE_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnEditorPreEndPIE.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->bSimulateInEditor = bSimulateInEditor;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x06008770 RID: 34672 RVA: 0x000CB3C8 File Offset: 0x000C95C8
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<bool> action = target as Action<bool>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FOnEditorPreEndPIE.__FOnEditorPreEndPIE_DelegateParams*)__Parameters)->bSimulateInEditor);
		}

		// Token: 0x04003AE4 RID: 15076
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003AE5 RID: 15077
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroUtility.OnEditorPreEndPIE__DelegateSignature";

		// Token: 0x04003AE6 RID: 15078
		private static int RegisterId;

		// Token: 0x02000E01 RID: 3585
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		private ref struct __FOnEditorPreEndPIE_DelegateParams
		{
			// Token: 0x04006195 RID: 24981
			[FieldOffset(0)]
			public bool bSimulateInEditor;
		}

		// Token: 0x02000E02 RID: 3586
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04006196 RID: 24982
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
