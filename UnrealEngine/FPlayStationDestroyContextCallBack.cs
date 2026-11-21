using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000609 RID: 1545
	public sealed class FPlayStationDestroyContextCallBack : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06008830 RID: 34864 RVA: 0x000CD2E0 File Offset: 0x000CB4E0
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FPlayStationDestroyContextCallBack.StaticFunctionPtr();
		}

		// Token: 0x06008831 RID: 34865 RVA: 0x000CD2EC File Offset: 0x000CB4EC
		private static IntPtr StaticFunctionPtr()
		{
			if (FPlayStationDestroyContextCallBack._FunctionPtr == IntPtr.Zero)
			{
				FPlayStationDestroyContextCallBack._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroUtility.PlayStationDestroyContextCallBack__DelegateSignature");
			}
			return FPlayStationDestroyContextCallBack._FunctionPtr;
		}

		// Token: 0x06008832 RID: 34866 RVA: 0x000CD30F File Offset: 0x000CB50F
		public FPlayStationDestroyContextCallBack()
		{
		}

		// Token: 0x06008833 RID: 34867 RVA: 0x000CD317 File Offset: 0x000CB517
		[NullableContext(2)]
		public FPlayStationDestroyContextCallBack(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06008834 RID: 34868 RVA: 0x000CD321 File Offset: 0x000CB521
		public FPlayStationDestroyContextCallBack(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06008835 RID: 34869 RVA: 0x000CD32C File Offset: 0x000CB52C
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<int>) ?? ((Action<int>)Delegate.CreateDelegate(typeof(Action<int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06008836 RID: 34870 RVA: 0x000CD35E File Offset: 0x000CB55E
		[NullableContext(1)]
		public void Bind(Action<int> Callback)
		{
			if (FPlayStationDestroyContextCallBack.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FPlayStationDestroyContextCallBack.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FPlayStationDestroyContextCallBack.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FPlayStationDestroyContextCallBack.OnScriptCallback));
				}
				FPlayStationDestroyContextCallBack.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FPlayStationDestroyContextCallBack.RegisterId);
		}

		// Token: 0x06008837 RID: 34871 RVA: 0x000CD398 File Offset: 0x000CB598
		[SkipLocalsInit]
		public unsafe void Execute(int ret)
		{
			FPlayStationDestroyContextCallBack.__FPlayStationDestroyContextCallBack_DelegateParams* ptr = stackalloc FPlayStationDestroyContextCallBack.__FPlayStationDestroyContextCallBack_DelegateParams[(UIntPtr)19] + 15L / (long)sizeof(FPlayStationDestroyContextCallBack.__FPlayStationDestroyContextCallBack_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FPlayStationDestroyContextCallBack.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->ret = ret;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x06008838 RID: 34872 RVA: 0x000CD3D8 File Offset: 0x000CB5D8
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int> action = target as Action<int>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FPlayStationDestroyContextCallBack.__FPlayStationDestroyContextCallBack_DelegateParams*)__Parameters)->ret);
		}

		// Token: 0x04003B26 RID: 15142
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003B27 RID: 15143
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroUtility.PlayStationDestroyContextCallBack__DelegateSignature";

		// Token: 0x04003B28 RID: 15144
		private static int RegisterId;

		// Token: 0x02000E32 RID: 3634
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		private ref struct __FPlayStationDestroyContextCallBack_DelegateParams
		{
			// Token: 0x040061CB RID: 25035
			[FieldOffset(0)]
			public int ret;
		}

		// Token: 0x02000E33 RID: 3635
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040061CC RID: 25036
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
