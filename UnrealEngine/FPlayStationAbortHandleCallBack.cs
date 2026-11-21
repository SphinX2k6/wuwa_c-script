using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000606 RID: 1542
	public sealed class FPlayStationAbortHandleCallBack : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06008815 RID: 34837 RVA: 0x000CCF02 File Offset: 0x000CB102
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FPlayStationAbortHandleCallBack.StaticFunctionPtr();
		}

		// Token: 0x06008816 RID: 34838 RVA: 0x000CCF0E File Offset: 0x000CB10E
		private static IntPtr StaticFunctionPtr()
		{
			if (FPlayStationAbortHandleCallBack._FunctionPtr == IntPtr.Zero)
			{
				FPlayStationAbortHandleCallBack._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroUtility.PlayStationAbortHandleCallBack__DelegateSignature");
			}
			return FPlayStationAbortHandleCallBack._FunctionPtr;
		}

		// Token: 0x06008817 RID: 34839 RVA: 0x000CCF31 File Offset: 0x000CB131
		public FPlayStationAbortHandleCallBack()
		{
		}

		// Token: 0x06008818 RID: 34840 RVA: 0x000CCF39 File Offset: 0x000CB139
		[NullableContext(2)]
		public FPlayStationAbortHandleCallBack(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06008819 RID: 34841 RVA: 0x000CCF43 File Offset: 0x000CB143
		public FPlayStationAbortHandleCallBack(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600881A RID: 34842 RVA: 0x000CCF4E File Offset: 0x000CB14E
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<int>) ?? ((Action<int>)Delegate.CreateDelegate(typeof(Action<int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600881B RID: 34843 RVA: 0x000CCF80 File Offset: 0x000CB180
		[NullableContext(1)]
		public void Bind(Action<int> Callback)
		{
			if (FPlayStationAbortHandleCallBack.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FPlayStationAbortHandleCallBack.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FPlayStationAbortHandleCallBack.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FPlayStationAbortHandleCallBack.OnScriptCallback));
				}
				FPlayStationAbortHandleCallBack.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FPlayStationAbortHandleCallBack.RegisterId);
		}

		// Token: 0x0600881C RID: 34844 RVA: 0x000CCFBC File Offset: 0x000CB1BC
		[SkipLocalsInit]
		public unsafe void Execute(int ret)
		{
			FPlayStationAbortHandleCallBack.__FPlayStationAbortHandleCallBack_DelegateParams* ptr = stackalloc FPlayStationAbortHandleCallBack.__FPlayStationAbortHandleCallBack_DelegateParams[(UIntPtr)19] + 15L / (long)sizeof(FPlayStationAbortHandleCallBack.__FPlayStationAbortHandleCallBack_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FPlayStationAbortHandleCallBack.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->ret = ret;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0600881D RID: 34845 RVA: 0x000CCFFC File Offset: 0x000CB1FC
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int> action = target as Action<int>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FPlayStationAbortHandleCallBack.__FPlayStationAbortHandleCallBack_DelegateParams*)__Parameters)->ret);
		}

		// Token: 0x04003B1D RID: 15133
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003B1E RID: 15134
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroUtility.PlayStationAbortHandleCallBack__DelegateSignature";

		// Token: 0x04003B1F RID: 15135
		private static int RegisterId;

		// Token: 0x02000E2C RID: 3628
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		private ref struct __FPlayStationAbortHandleCallBack_DelegateParams
		{
			// Token: 0x040061C3 RID: 25027
			[FieldOffset(0)]
			public int ret;
		}

		// Token: 0x02000E2D RID: 3629
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040061C4 RID: 25028
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
