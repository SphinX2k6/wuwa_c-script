using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200060C RID: 1548
	public sealed class FPlayStationGetCommunicationStatusCallBack : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600884B RID: 34891 RVA: 0x000CD6E0 File Offset: 0x000CB8E0
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FPlayStationGetCommunicationStatusCallBack.StaticFunctionPtr();
		}

		// Token: 0x0600884C RID: 34892 RVA: 0x000CD6EC File Offset: 0x000CB8EC
		private static IntPtr StaticFunctionPtr()
		{
			if (FPlayStationGetCommunicationStatusCallBack._FunctionPtr == IntPtr.Zero)
			{
				FPlayStationGetCommunicationStatusCallBack._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroUtility.PlayStationGetCommunicationStatusCallBack__DelegateSignature");
			}
			return FPlayStationGetCommunicationStatusCallBack._FunctionPtr;
		}

		// Token: 0x0600884D RID: 34893 RVA: 0x000CD70F File Offset: 0x000CB90F
		public FPlayStationGetCommunicationStatusCallBack()
		{
		}

		// Token: 0x0600884E RID: 34894 RVA: 0x000CD717 File Offset: 0x000CB917
		[NullableContext(2)]
		public FPlayStationGetCommunicationStatusCallBack(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600884F RID: 34895 RVA: 0x000CD721 File Offset: 0x000CB921
		public FPlayStationGetCommunicationStatusCallBack(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06008850 RID: 34896 RVA: 0x000CD72C File Offset: 0x000CB92C
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<int, int>) ?? ((Action<int, int>)Delegate.CreateDelegate(typeof(Action<int, int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06008851 RID: 34897 RVA: 0x000CD75E File Offset: 0x000CB95E
		[NullableContext(1)]
		public void Bind(Action<int, int> Callback)
		{
			if (FPlayStationGetCommunicationStatusCallBack.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FPlayStationGetCommunicationStatusCallBack.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FPlayStationGetCommunicationStatusCallBack.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FPlayStationGetCommunicationStatusCallBack.OnScriptCallback));
				}
				FPlayStationGetCommunicationStatusCallBack.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FPlayStationGetCommunicationStatusCallBack.RegisterId);
		}

		// Token: 0x06008852 RID: 34898 RVA: 0x000CD798 File Offset: 0x000CB998
		[SkipLocalsInit]
		public unsafe void Execute(int ret, int status)
		{
			FPlayStationGetCommunicationStatusCallBack.__FPlayStationGetCommunicationStatusCallBack_DelegateParams* ptr = stackalloc FPlayStationGetCommunicationStatusCallBack.__FPlayStationGetCommunicationStatusCallBack_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FPlayStationGetCommunicationStatusCallBack.__FPlayStationGetCommunicationStatusCallBack_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FPlayStationGetCommunicationStatusCallBack.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->ret = ret;
			ptr->status = status;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x06008853 RID: 34899 RVA: 0x000CD7DC File Offset: 0x000CB9DC
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int, int> action = target as Action<int, int>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FPlayStationGetCommunicationStatusCallBack.__FPlayStationGetCommunicationStatusCallBack_DelegateParams*)__Parameters)->ret, ((FPlayStationGetCommunicationStatusCallBack.__FPlayStationGetCommunicationStatusCallBack_DelegateParams*)__Parameters)->status);
		}

		// Token: 0x04003B2F RID: 15151
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003B30 RID: 15152
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroUtility.PlayStationGetCommunicationStatusCallBack__DelegateSignature";

		// Token: 0x04003B31 RID: 15153
		private static int RegisterId;

		// Token: 0x02000E38 RID: 3640
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		private ref struct __FPlayStationGetCommunicationStatusCallBack_DelegateParams
		{
			// Token: 0x040061D1 RID: 25041
			[FieldOffset(0)]
			public int ret;

			// Token: 0x040061D2 RID: 25042
			[FieldOffset(4)]
			public int status;
		}

		// Token: 0x02000E39 RID: 3641
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040061D3 RID: 25043
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
