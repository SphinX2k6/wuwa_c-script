using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000610 RID: 1552
	public sealed class FPlayStationUnlockTrophyCallBack : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600886F RID: 34927 RVA: 0x000CDBF6 File Offset: 0x000CBDF6
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FPlayStationUnlockTrophyCallBack.StaticFunctionPtr();
		}

		// Token: 0x06008870 RID: 34928 RVA: 0x000CDC02 File Offset: 0x000CBE02
		private static IntPtr StaticFunctionPtr()
		{
			if (FPlayStationUnlockTrophyCallBack._FunctionPtr == IntPtr.Zero)
			{
				FPlayStationUnlockTrophyCallBack._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroUtility.PlayStationUnlockTrophyCallBack__DelegateSignature");
			}
			return FPlayStationUnlockTrophyCallBack._FunctionPtr;
		}

		// Token: 0x06008871 RID: 34929 RVA: 0x000CDC25 File Offset: 0x000CBE25
		public FPlayStationUnlockTrophyCallBack()
		{
		}

		// Token: 0x06008872 RID: 34930 RVA: 0x000CDC2D File Offset: 0x000CBE2D
		[NullableContext(2)]
		public FPlayStationUnlockTrophyCallBack(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06008873 RID: 34931 RVA: 0x000CDC37 File Offset: 0x000CBE37
		public FPlayStationUnlockTrophyCallBack(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06008874 RID: 34932 RVA: 0x000CDC42 File Offset: 0x000CBE42
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<int>) ?? ((Action<int>)Delegate.CreateDelegate(typeof(Action<int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06008875 RID: 34933 RVA: 0x000CDC74 File Offset: 0x000CBE74
		[NullableContext(1)]
		public void Bind(Action<int> Callback)
		{
			if (FPlayStationUnlockTrophyCallBack.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FPlayStationUnlockTrophyCallBack.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FPlayStationUnlockTrophyCallBack.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FPlayStationUnlockTrophyCallBack.OnScriptCallback));
				}
				FPlayStationUnlockTrophyCallBack.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FPlayStationUnlockTrophyCallBack.RegisterId);
		}

		// Token: 0x06008876 RID: 34934 RVA: 0x000CDCB0 File Offset: 0x000CBEB0
		[SkipLocalsInit]
		public unsafe void Execute(int ret)
		{
			FPlayStationUnlockTrophyCallBack.__FPlayStationUnlockTrophyCallBack_DelegateParams* ptr = stackalloc FPlayStationUnlockTrophyCallBack.__FPlayStationUnlockTrophyCallBack_DelegateParams[(UIntPtr)19] + 15L / (long)sizeof(FPlayStationUnlockTrophyCallBack.__FPlayStationUnlockTrophyCallBack_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FPlayStationUnlockTrophyCallBack.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->ret = ret;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x06008877 RID: 34935 RVA: 0x000CDCF0 File Offset: 0x000CBEF0
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int> action = target as Action<int>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FPlayStationUnlockTrophyCallBack.__FPlayStationUnlockTrophyCallBack_DelegateParams*)__Parameters)->ret);
		}

		// Token: 0x04003B3B RID: 15163
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003B3C RID: 15164
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroUtility.PlayStationUnlockTrophyCallBack__DelegateSignature";

		// Token: 0x04003B3D RID: 15165
		private static int RegisterId;

		// Token: 0x02000E40 RID: 3648
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		private ref struct __FPlayStationUnlockTrophyCallBack_DelegateParams
		{
			// Token: 0x040061DA RID: 25050
			[FieldOffset(0)]
			public int ret;
		}

		// Token: 0x02000E41 RID: 3649
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040061DB RID: 25051
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
