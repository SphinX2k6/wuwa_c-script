using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200060E RID: 1550
	public sealed class FPlayStationOpenDialogCallBack : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600885D RID: 34909 RVA: 0x000CD96E File Offset: 0x000CBB6E
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FPlayStationOpenDialogCallBack.StaticFunctionPtr();
		}

		// Token: 0x0600885E RID: 34910 RVA: 0x000CD97A File Offset: 0x000CBB7A
		private static IntPtr StaticFunctionPtr()
		{
			if (FPlayStationOpenDialogCallBack._FunctionPtr == IntPtr.Zero)
			{
				FPlayStationOpenDialogCallBack._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroUtility.PlayStationOpenDialogCallBack__DelegateSignature");
			}
			return FPlayStationOpenDialogCallBack._FunctionPtr;
		}

		// Token: 0x0600885F RID: 34911 RVA: 0x000CD99D File Offset: 0x000CBB9D
		public FPlayStationOpenDialogCallBack()
		{
		}

		// Token: 0x06008860 RID: 34912 RVA: 0x000CD9A5 File Offset: 0x000CBBA5
		[NullableContext(2)]
		public FPlayStationOpenDialogCallBack(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06008861 RID: 34913 RVA: 0x000CD9AF File Offset: 0x000CBBAF
		public FPlayStationOpenDialogCallBack(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06008862 RID: 34914 RVA: 0x000CD9BA File Offset: 0x000CBBBA
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<int>) ?? ((Action<int>)Delegate.CreateDelegate(typeof(Action<int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06008863 RID: 34915 RVA: 0x000CD9EC File Offset: 0x000CBBEC
		[NullableContext(1)]
		public void Bind(Action<int> Callback)
		{
			if (FPlayStationOpenDialogCallBack.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FPlayStationOpenDialogCallBack.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FPlayStationOpenDialogCallBack.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FPlayStationOpenDialogCallBack.OnScriptCallback));
				}
				FPlayStationOpenDialogCallBack.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FPlayStationOpenDialogCallBack.RegisterId);
		}

		// Token: 0x06008864 RID: 34916 RVA: 0x000CDA28 File Offset: 0x000CBC28
		[SkipLocalsInit]
		public unsafe void Execute(int ret)
		{
			FPlayStationOpenDialogCallBack.__FPlayStationOpenDialogCallBack_DelegateParams* ptr = stackalloc FPlayStationOpenDialogCallBack.__FPlayStationOpenDialogCallBack_DelegateParams[(UIntPtr)19] + 15L / (long)sizeof(FPlayStationOpenDialogCallBack.__FPlayStationOpenDialogCallBack_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FPlayStationOpenDialogCallBack.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->ret = ret;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x06008865 RID: 34917 RVA: 0x000CDA68 File Offset: 0x000CBC68
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int> action = target as Action<int>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FPlayStationOpenDialogCallBack.__FPlayStationOpenDialogCallBack_DelegateParams*)__Parameters)->ret);
		}

		// Token: 0x04003B35 RID: 15157
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003B36 RID: 15158
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroUtility.PlayStationOpenDialogCallBack__DelegateSignature";

		// Token: 0x04003B37 RID: 15159
		private static int RegisterId;

		// Token: 0x02000E3C RID: 3644
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		private ref struct __FPlayStationOpenDialogCallBack_DelegateParams
		{
			// Token: 0x040061D6 RID: 25046
			[FieldOffset(0)]
			public int ret;
		}

		// Token: 0x02000E3D RID: 3645
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040061D7 RID: 25047
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
