using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200060A RID: 1546
	public sealed class FPlayStationDestroyHandleCallBack : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06008839 RID: 34873 RVA: 0x000CD422 File Offset: 0x000CB622
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FPlayStationDestroyHandleCallBack.StaticFunctionPtr();
		}

		// Token: 0x0600883A RID: 34874 RVA: 0x000CD42E File Offset: 0x000CB62E
		private static IntPtr StaticFunctionPtr()
		{
			if (FPlayStationDestroyHandleCallBack._FunctionPtr == IntPtr.Zero)
			{
				FPlayStationDestroyHandleCallBack._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroUtility.PlayStationDestroyHandleCallBack__DelegateSignature");
			}
			return FPlayStationDestroyHandleCallBack._FunctionPtr;
		}

		// Token: 0x0600883B RID: 34875 RVA: 0x000CD451 File Offset: 0x000CB651
		public FPlayStationDestroyHandleCallBack()
		{
		}

		// Token: 0x0600883C RID: 34876 RVA: 0x000CD459 File Offset: 0x000CB659
		[NullableContext(2)]
		public FPlayStationDestroyHandleCallBack(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600883D RID: 34877 RVA: 0x000CD463 File Offset: 0x000CB663
		public FPlayStationDestroyHandleCallBack(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600883E RID: 34878 RVA: 0x000CD46E File Offset: 0x000CB66E
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<int>) ?? ((Action<int>)Delegate.CreateDelegate(typeof(Action<int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600883F RID: 34879 RVA: 0x000CD4A0 File Offset: 0x000CB6A0
		[NullableContext(1)]
		public void Bind(Action<int> Callback)
		{
			if (FPlayStationDestroyHandleCallBack.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FPlayStationDestroyHandleCallBack.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FPlayStationDestroyHandleCallBack.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FPlayStationDestroyHandleCallBack.OnScriptCallback));
				}
				FPlayStationDestroyHandleCallBack.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FPlayStationDestroyHandleCallBack.RegisterId);
		}

		// Token: 0x06008840 RID: 34880 RVA: 0x000CD4DC File Offset: 0x000CB6DC
		[SkipLocalsInit]
		public unsafe void Execute(int ret)
		{
			FPlayStationDestroyHandleCallBack.__FPlayStationDestroyHandleCallBack_DelegateParams* ptr = stackalloc FPlayStationDestroyHandleCallBack.__FPlayStationDestroyHandleCallBack_DelegateParams[(UIntPtr)19] + 15L / (long)sizeof(FPlayStationDestroyHandleCallBack.__FPlayStationDestroyHandleCallBack_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FPlayStationDestroyHandleCallBack.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->ret = ret;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x06008841 RID: 34881 RVA: 0x000CD51C File Offset: 0x000CB71C
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int> action = target as Action<int>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FPlayStationDestroyHandleCallBack.__FPlayStationDestroyHandleCallBack_DelegateParams*)__Parameters)->ret);
		}

		// Token: 0x04003B29 RID: 15145
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003B2A RID: 15146
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroUtility.PlayStationDestroyHandleCallBack__DelegateSignature";

		// Token: 0x04003B2B RID: 15147
		private static int RegisterId;

		// Token: 0x02000E34 RID: 3636
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		private ref struct __FPlayStationDestroyHandleCallBack_DelegateParams
		{
			// Token: 0x040061CD RID: 25037
			[FieldOffset(0)]
			public int ret;
		}

		// Token: 0x02000E35 RID: 3637
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040061CE RID: 25038
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
