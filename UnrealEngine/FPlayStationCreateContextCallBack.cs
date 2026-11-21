using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000607 RID: 1543
	public sealed class FPlayStationCreateContextCallBack : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600881E RID: 34846 RVA: 0x000CD046 File Offset: 0x000CB246
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FPlayStationCreateContextCallBack.StaticFunctionPtr();
		}

		// Token: 0x0600881F RID: 34847 RVA: 0x000CD052 File Offset: 0x000CB252
		private static IntPtr StaticFunctionPtr()
		{
			if (FPlayStationCreateContextCallBack._FunctionPtr == IntPtr.Zero)
			{
				FPlayStationCreateContextCallBack._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroUtility.PlayStationCreateContextCallBack__DelegateSignature");
			}
			return FPlayStationCreateContextCallBack._FunctionPtr;
		}

		// Token: 0x06008820 RID: 34848 RVA: 0x000CD075 File Offset: 0x000CB275
		public FPlayStationCreateContextCallBack()
		{
		}

		// Token: 0x06008821 RID: 34849 RVA: 0x000CD07D File Offset: 0x000CB27D
		[NullableContext(2)]
		public FPlayStationCreateContextCallBack(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06008822 RID: 34850 RVA: 0x000CD087 File Offset: 0x000CB287
		public FPlayStationCreateContextCallBack(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06008823 RID: 34851 RVA: 0x000CD092 File Offset: 0x000CB292
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<int, int>) ?? ((Action<int, int>)Delegate.CreateDelegate(typeof(Action<int, int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06008824 RID: 34852 RVA: 0x000CD0C4 File Offset: 0x000CB2C4
		[NullableContext(1)]
		public void Bind(Action<int, int> Callback)
		{
			if (FPlayStationCreateContextCallBack.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FPlayStationCreateContextCallBack.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FPlayStationCreateContextCallBack.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FPlayStationCreateContextCallBack.OnScriptCallback));
				}
				FPlayStationCreateContextCallBack.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FPlayStationCreateContextCallBack.RegisterId);
		}

		// Token: 0x06008825 RID: 34853 RVA: 0x000CD100 File Offset: 0x000CB300
		[SkipLocalsInit]
		public unsafe void Execute(int ret, int result)
		{
			FPlayStationCreateContextCallBack.__FPlayStationCreateContextCallBack_DelegateParams* ptr = stackalloc FPlayStationCreateContextCallBack.__FPlayStationCreateContextCallBack_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FPlayStationCreateContextCallBack.__FPlayStationCreateContextCallBack_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FPlayStationCreateContextCallBack.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->ret = ret;
			ptr->result = result;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x06008826 RID: 34854 RVA: 0x000CD144 File Offset: 0x000CB344
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int, int> action = target as Action<int, int>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FPlayStationCreateContextCallBack.__FPlayStationCreateContextCallBack_DelegateParams*)__Parameters)->ret, ((FPlayStationCreateContextCallBack.__FPlayStationCreateContextCallBack_DelegateParams*)__Parameters)->result);
		}

		// Token: 0x04003B20 RID: 15136
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003B21 RID: 15137
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroUtility.PlayStationCreateContextCallBack__DelegateSignature";

		// Token: 0x04003B22 RID: 15138
		private static int RegisterId;

		// Token: 0x02000E2E RID: 3630
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		private ref struct __FPlayStationCreateContextCallBack_DelegateParams
		{
			// Token: 0x040061C5 RID: 25029
			[FieldOffset(0)]
			public int ret;

			// Token: 0x040061C6 RID: 25030
			[FieldOffset(4)]
			public int result;
		}

		// Token: 0x02000E2F RID: 3631
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040061C7 RID: 25031
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
