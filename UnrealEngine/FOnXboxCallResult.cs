using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020005FF RID: 1535
	public sealed class FOnXboxCallResult : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060087D6 RID: 34774 RVA: 0x000CC530 File Offset: 0x000CA730
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnXboxCallResult.StaticFunctionPtr();
		}

		// Token: 0x060087D7 RID: 34775 RVA: 0x000CC53C File Offset: 0x000CA73C
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnXboxCallResult._FunctionPtr == IntPtr.Zero)
			{
				FOnXboxCallResult._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroUtility.OnXboxCallResult__DelegateSignature");
			}
			return FOnXboxCallResult._FunctionPtr;
		}

		// Token: 0x060087D8 RID: 34776 RVA: 0x000CC55F File Offset: 0x000CA75F
		public FOnXboxCallResult()
		{
		}

		// Token: 0x060087D9 RID: 34777 RVA: 0x000CC567 File Offset: 0x000CA767
		[NullableContext(2)]
		public FOnXboxCallResult(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060087DA RID: 34778 RVA: 0x000CC571 File Offset: 0x000CA771
		public FOnXboxCallResult(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060087DB RID: 34779 RVA: 0x000CC57C File Offset: 0x000CA77C
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<bool>) ?? ((Action<bool>)Delegate.CreateDelegate(typeof(Action<bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060087DC RID: 34780 RVA: 0x000CC5AE File Offset: 0x000CA7AE
		[NullableContext(1)]
		public void Bind(Action<bool> Callback)
		{
			if (FOnXboxCallResult.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnXboxCallResult.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnXboxCallResult.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnXboxCallResult.OnScriptCallback));
				}
				FOnXboxCallResult.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FOnXboxCallResult.RegisterId);
		}

		// Token: 0x060087DD RID: 34781 RVA: 0x000CC5E8 File Offset: 0x000CA7E8
		[SkipLocalsInit]
		public unsafe void Execute(bool bSuccess)
		{
			FOnXboxCallResult.__FOnXboxCallResult_DelegateParams* ptr = stackalloc FOnXboxCallResult.__FOnXboxCallResult_DelegateParams[(UIntPtr)16] + 15L / (long)sizeof(FOnXboxCallResult.__FOnXboxCallResult_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnXboxCallResult.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->bSuccess = bSuccess;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x060087DE RID: 34782 RVA: 0x000CC628 File Offset: 0x000CA828
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<bool> action = target as Action<bool>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FOnXboxCallResult.__FOnXboxCallResult_DelegateParams*)__Parameters)->bSuccess);
		}

		// Token: 0x04003B08 RID: 15112
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003B09 RID: 15113
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroUtility.OnXboxCallResult__DelegateSignature";

		// Token: 0x04003B0A RID: 15114
		private static int RegisterId;

		// Token: 0x02000E1E RID: 3614
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		private ref struct __FOnXboxCallResult_DelegateParams
		{
			// Token: 0x040061B3 RID: 25011
			[FieldOffset(0)]
			public bool bSuccess;
		}

		// Token: 0x02000E1F RID: 3615
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040061B4 RID: 25012
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
