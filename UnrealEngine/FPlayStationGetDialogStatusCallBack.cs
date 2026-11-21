using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200060D RID: 1549
	public sealed class FPlayStationGetDialogStatusCallBack : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06008854 RID: 34900 RVA: 0x000CD82C File Offset: 0x000CBA2C
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FPlayStationGetDialogStatusCallBack.StaticFunctionPtr();
		}

		// Token: 0x06008855 RID: 34901 RVA: 0x000CD838 File Offset: 0x000CBA38
		private static IntPtr StaticFunctionPtr()
		{
			if (FPlayStationGetDialogStatusCallBack._FunctionPtr == IntPtr.Zero)
			{
				FPlayStationGetDialogStatusCallBack._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroUtility.PlayStationGetDialogStatusCallBack__DelegateSignature");
			}
			return FPlayStationGetDialogStatusCallBack._FunctionPtr;
		}

		// Token: 0x06008856 RID: 34902 RVA: 0x000CD85B File Offset: 0x000CBA5B
		public FPlayStationGetDialogStatusCallBack()
		{
		}

		// Token: 0x06008857 RID: 34903 RVA: 0x000CD863 File Offset: 0x000CBA63
		[NullableContext(2)]
		public FPlayStationGetDialogStatusCallBack(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06008858 RID: 34904 RVA: 0x000CD86D File Offset: 0x000CBA6D
		public FPlayStationGetDialogStatusCallBack(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06008859 RID: 34905 RVA: 0x000CD878 File Offset: 0x000CBA78
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<int>) ?? ((Action<int>)Delegate.CreateDelegate(typeof(Action<int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600885A RID: 34906 RVA: 0x000CD8AA File Offset: 0x000CBAAA
		[NullableContext(1)]
		public void Bind(Action<int> Callback)
		{
			if (FPlayStationGetDialogStatusCallBack.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FPlayStationGetDialogStatusCallBack.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FPlayStationGetDialogStatusCallBack.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FPlayStationGetDialogStatusCallBack.OnScriptCallback));
				}
				FPlayStationGetDialogStatusCallBack.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FPlayStationGetDialogStatusCallBack.RegisterId);
		}

		// Token: 0x0600885B RID: 34907 RVA: 0x000CD8E4 File Offset: 0x000CBAE4
		[SkipLocalsInit]
		public unsafe void Execute(int ret)
		{
			FPlayStationGetDialogStatusCallBack.__FPlayStationGetDialogStatusCallBack_DelegateParams* ptr = stackalloc FPlayStationGetDialogStatusCallBack.__FPlayStationGetDialogStatusCallBack_DelegateParams[(UIntPtr)19] + 15L / (long)sizeof(FPlayStationGetDialogStatusCallBack.__FPlayStationGetDialogStatusCallBack_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FPlayStationGetDialogStatusCallBack.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->ret = ret;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0600885C RID: 34908 RVA: 0x000CD924 File Offset: 0x000CBB24
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int> action = target as Action<int>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FPlayStationGetDialogStatusCallBack.__FPlayStationGetDialogStatusCallBack_DelegateParams*)__Parameters)->ret);
		}

		// Token: 0x04003B32 RID: 15154
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003B33 RID: 15155
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroUtility.PlayStationGetDialogStatusCallBack__DelegateSignature";

		// Token: 0x04003B34 RID: 15156
		private static int RegisterId;

		// Token: 0x02000E3A RID: 3642
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		private ref struct __FPlayStationGetDialogStatusCallBack_DelegateParams
		{
			// Token: 0x040061D4 RID: 25044
			[FieldOffset(0)]
			public int ret;
		}

		// Token: 0x02000E3B RID: 3643
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040061D5 RID: 25045
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
