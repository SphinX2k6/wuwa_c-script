using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020005B1 RID: 1457
	public sealed class FQueriedCallback : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600830D RID: 33549 RVA: 0x000C1B63 File Offset: 0x000BFD63
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FQueriedCallback.StaticFunctionPtr();
		}

		// Token: 0x0600830E RID: 33550 RVA: 0x000C1B6F File Offset: 0x000BFD6F
		private static IntPtr StaticFunctionPtr()
		{
			if (FQueriedCallback._FunctionPtr == IntPtr.Zero)
			{
				FQueriedCallback._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroSqliteBpLib.QueriedCallback__DelegateSignature");
			}
			return FQueriedCallback._FunctionPtr;
		}

		// Token: 0x0600830F RID: 33551 RVA: 0x000C1B92 File Offset: 0x000BFD92
		public FQueriedCallback()
		{
		}

		// Token: 0x06008310 RID: 33552 RVA: 0x000C1B9A File Offset: 0x000BFD9A
		[NullableContext(2)]
		public FQueriedCallback(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06008311 RID: 33553 RVA: 0x000C1BA4 File Offset: 0x000BFDA4
		public FQueriedCallback(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06008312 RID: 33554 RVA: 0x000C1BAF File Offset: 0x000BFDAF
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<bool>) ?? ((Action<bool>)Delegate.CreateDelegate(typeof(Action<bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06008313 RID: 33555 RVA: 0x000C1BE1 File Offset: 0x000BFDE1
		[NullableContext(1)]
		public void Bind(Action<bool> Callback)
		{
			if (FQueriedCallback.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FQueriedCallback.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FQueriedCallback.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FQueriedCallback.OnScriptCallback));
				}
				FQueriedCallback.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FQueriedCallback.RegisterId);
		}

		// Token: 0x06008314 RID: 33556 RVA: 0x000C1C1C File Offset: 0x000BFE1C
		[SkipLocalsInit]
		public unsafe void Execute(bool Success)
		{
			FQueriedCallback.__FQueriedCallback_DelegateParams* ptr = stackalloc FQueriedCallback.__FQueriedCallback_DelegateParams[(UIntPtr)16] + 15L / (long)sizeof(FQueriedCallback.__FQueriedCallback_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FQueriedCallback.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Success = Success;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x06008315 RID: 33557 RVA: 0x000C1C5C File Offset: 0x000BFE5C
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<bool> action = target as Action<bool>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FQueriedCallback.__FQueriedCallback_DelegateParams*)__Parameters)->Success);
		}

		// Token: 0x040038FE RID: 14590
		internal static IntPtr _FunctionPtr;

		// Token: 0x040038FF RID: 14591
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSqliteBpLib.QueriedCallback__DelegateSignature";

		// Token: 0x04003900 RID: 14592
		private static int RegisterId;

		// Token: 0x02000D2D RID: 3373
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		private ref struct __FQueriedCallback_DelegateParams
		{
			// Token: 0x04005FC1 RID: 24513
			[FieldOffset(0)]
			public bool Success;
		}

		// Token: 0x02000D2E RID: 3374
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005FC2 RID: 24514
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
