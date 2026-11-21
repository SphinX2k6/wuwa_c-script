using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000611 RID: 1553
	public sealed class FPlayStationUpdateTrophyCallBack : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06008878 RID: 34936 RVA: 0x000CDD3A File Offset: 0x000CBF3A
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FPlayStationUpdateTrophyCallBack.StaticFunctionPtr();
		}

		// Token: 0x06008879 RID: 34937 RVA: 0x000CDD46 File Offset: 0x000CBF46
		private static IntPtr StaticFunctionPtr()
		{
			if (FPlayStationUpdateTrophyCallBack._FunctionPtr == IntPtr.Zero)
			{
				FPlayStationUpdateTrophyCallBack._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroUtility.PlayStationUpdateTrophyCallBack__DelegateSignature");
			}
			return FPlayStationUpdateTrophyCallBack._FunctionPtr;
		}

		// Token: 0x0600887A RID: 34938 RVA: 0x000CDD69 File Offset: 0x000CBF69
		public FPlayStationUpdateTrophyCallBack()
		{
		}

		// Token: 0x0600887B RID: 34939 RVA: 0x000CDD71 File Offset: 0x000CBF71
		[NullableContext(2)]
		public FPlayStationUpdateTrophyCallBack(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600887C RID: 34940 RVA: 0x000CDD7B File Offset: 0x000CBF7B
		public FPlayStationUpdateTrophyCallBack(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600887D RID: 34941 RVA: 0x000CDD86 File Offset: 0x000CBF86
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<int>) ?? ((Action<int>)Delegate.CreateDelegate(typeof(Action<int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600887E RID: 34942 RVA: 0x000CDDB8 File Offset: 0x000CBFB8
		[NullableContext(1)]
		public void Bind(Action<int> Callback)
		{
			if (FPlayStationUpdateTrophyCallBack.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FPlayStationUpdateTrophyCallBack.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FPlayStationUpdateTrophyCallBack.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FPlayStationUpdateTrophyCallBack.OnScriptCallback));
				}
				FPlayStationUpdateTrophyCallBack.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FPlayStationUpdateTrophyCallBack.RegisterId);
		}

		// Token: 0x0600887F RID: 34943 RVA: 0x000CDDF4 File Offset: 0x000CBFF4
		[SkipLocalsInit]
		public unsafe void Execute(int ret)
		{
			FPlayStationUpdateTrophyCallBack.__FPlayStationUpdateTrophyCallBack_DelegateParams* ptr = stackalloc FPlayStationUpdateTrophyCallBack.__FPlayStationUpdateTrophyCallBack_DelegateParams[(UIntPtr)19] + 15L / (long)sizeof(FPlayStationUpdateTrophyCallBack.__FPlayStationUpdateTrophyCallBack_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FPlayStationUpdateTrophyCallBack.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->ret = ret;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x06008880 RID: 34944 RVA: 0x000CDE34 File Offset: 0x000CC034
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int> action = target as Action<int>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FPlayStationUpdateTrophyCallBack.__FPlayStationUpdateTrophyCallBack_DelegateParams*)__Parameters)->ret);
		}

		// Token: 0x04003B3E RID: 15166
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003B3F RID: 15167
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroUtility.PlayStationUpdateTrophyCallBack__DelegateSignature";

		// Token: 0x04003B40 RID: 15168
		private static int RegisterId;

		// Token: 0x02000E42 RID: 3650
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		private ref struct __FPlayStationUpdateTrophyCallBack_DelegateParams
		{
			// Token: 0x040061DC RID: 25052
			[FieldOffset(0)]
			public int ret;
		}

		// Token: 0x02000E43 RID: 3651
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040061DD RID: 25053
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
