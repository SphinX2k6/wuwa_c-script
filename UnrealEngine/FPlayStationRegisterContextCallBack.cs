using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200060F RID: 1551
	public sealed class FPlayStationRegisterContextCallBack : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06008866 RID: 34918 RVA: 0x000CDAB2 File Offset: 0x000CBCB2
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FPlayStationRegisterContextCallBack.StaticFunctionPtr();
		}

		// Token: 0x06008867 RID: 34919 RVA: 0x000CDABE File Offset: 0x000CBCBE
		private static IntPtr StaticFunctionPtr()
		{
			if (FPlayStationRegisterContextCallBack._FunctionPtr == IntPtr.Zero)
			{
				FPlayStationRegisterContextCallBack._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroUtility.PlayStationRegisterContextCallBack__DelegateSignature");
			}
			return FPlayStationRegisterContextCallBack._FunctionPtr;
		}

		// Token: 0x06008868 RID: 34920 RVA: 0x000CDAE1 File Offset: 0x000CBCE1
		public FPlayStationRegisterContextCallBack()
		{
		}

		// Token: 0x06008869 RID: 34921 RVA: 0x000CDAE9 File Offset: 0x000CBCE9
		[NullableContext(2)]
		public FPlayStationRegisterContextCallBack(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600886A RID: 34922 RVA: 0x000CDAF3 File Offset: 0x000CBCF3
		public FPlayStationRegisterContextCallBack(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600886B RID: 34923 RVA: 0x000CDAFE File Offset: 0x000CBCFE
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<int>) ?? ((Action<int>)Delegate.CreateDelegate(typeof(Action<int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600886C RID: 34924 RVA: 0x000CDB30 File Offset: 0x000CBD30
		[NullableContext(1)]
		public void Bind(Action<int> Callback)
		{
			if (FPlayStationRegisterContextCallBack.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FPlayStationRegisterContextCallBack.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FPlayStationRegisterContextCallBack.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FPlayStationRegisterContextCallBack.OnScriptCallback));
				}
				FPlayStationRegisterContextCallBack.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FPlayStationRegisterContextCallBack.RegisterId);
		}

		// Token: 0x0600886D RID: 34925 RVA: 0x000CDB6C File Offset: 0x000CBD6C
		[SkipLocalsInit]
		public unsafe void Execute(int ret)
		{
			FPlayStationRegisterContextCallBack.__FPlayStationRegisterContextCallBack_DelegateParams* ptr = stackalloc FPlayStationRegisterContextCallBack.__FPlayStationRegisterContextCallBack_DelegateParams[(UIntPtr)19] + 15L / (long)sizeof(FPlayStationRegisterContextCallBack.__FPlayStationRegisterContextCallBack_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FPlayStationRegisterContextCallBack.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->ret = ret;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0600886E RID: 34926 RVA: 0x000CDBAC File Offset: 0x000CBDAC
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int> action = target as Action<int>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FPlayStationRegisterContextCallBack.__FPlayStationRegisterContextCallBack_DelegateParams*)__Parameters)->ret);
		}

		// Token: 0x04003B38 RID: 15160
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003B39 RID: 15161
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroUtility.PlayStationRegisterContextCallBack__DelegateSignature";

		// Token: 0x04003B3A RID: 15162
		private static int RegisterId;

		// Token: 0x02000E3E RID: 3646
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		private ref struct __FPlayStationRegisterContextCallBack_DelegateParams
		{
			// Token: 0x040061D8 RID: 25048
			[FieldOffset(0)]
			public int ret;
		}

		// Token: 0x02000E3F RID: 3647
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040061D9 RID: 25049
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
