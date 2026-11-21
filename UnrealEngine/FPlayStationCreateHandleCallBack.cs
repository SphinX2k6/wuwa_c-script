using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000608 RID: 1544
	public sealed class FPlayStationCreateHandleCallBack : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06008827 RID: 34855 RVA: 0x000CD194 File Offset: 0x000CB394
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FPlayStationCreateHandleCallBack.StaticFunctionPtr();
		}

		// Token: 0x06008828 RID: 34856 RVA: 0x000CD1A0 File Offset: 0x000CB3A0
		private static IntPtr StaticFunctionPtr()
		{
			if (FPlayStationCreateHandleCallBack._FunctionPtr == IntPtr.Zero)
			{
				FPlayStationCreateHandleCallBack._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroUtility.PlayStationCreateHandleCallBack__DelegateSignature");
			}
			return FPlayStationCreateHandleCallBack._FunctionPtr;
		}

		// Token: 0x06008829 RID: 34857 RVA: 0x000CD1C3 File Offset: 0x000CB3C3
		public FPlayStationCreateHandleCallBack()
		{
		}

		// Token: 0x0600882A RID: 34858 RVA: 0x000CD1CB File Offset: 0x000CB3CB
		[NullableContext(2)]
		public FPlayStationCreateHandleCallBack(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600882B RID: 34859 RVA: 0x000CD1D5 File Offset: 0x000CB3D5
		public FPlayStationCreateHandleCallBack(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600882C RID: 34860 RVA: 0x000CD1E0 File Offset: 0x000CB3E0
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<int, int>) ?? ((Action<int, int>)Delegate.CreateDelegate(typeof(Action<int, int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600882D RID: 34861 RVA: 0x000CD212 File Offset: 0x000CB412
		[NullableContext(1)]
		public void Bind(Action<int, int> Callback)
		{
			if (FPlayStationCreateHandleCallBack.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FPlayStationCreateHandleCallBack.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FPlayStationCreateHandleCallBack.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FPlayStationCreateHandleCallBack.OnScriptCallback));
				}
				FPlayStationCreateHandleCallBack.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FPlayStationCreateHandleCallBack.RegisterId);
		}

		// Token: 0x0600882E RID: 34862 RVA: 0x000CD24C File Offset: 0x000CB44C
		[SkipLocalsInit]
		public unsafe void Execute(int ret, int result)
		{
			FPlayStationCreateHandleCallBack.__FPlayStationCreateHandleCallBack_DelegateParams* ptr = stackalloc FPlayStationCreateHandleCallBack.__FPlayStationCreateHandleCallBack_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FPlayStationCreateHandleCallBack.__FPlayStationCreateHandleCallBack_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FPlayStationCreateHandleCallBack.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->ret = ret;
			ptr->result = result;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0600882F RID: 34863 RVA: 0x000CD290 File Offset: 0x000CB490
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int, int> action = target as Action<int, int>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FPlayStationCreateHandleCallBack.__FPlayStationCreateHandleCallBack_DelegateParams*)__Parameters)->ret, ((FPlayStationCreateHandleCallBack.__FPlayStationCreateHandleCallBack_DelegateParams*)__Parameters)->result);
		}

		// Token: 0x04003B23 RID: 15139
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003B24 RID: 15140
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroUtility.PlayStationCreateHandleCallBack__DelegateSignature";

		// Token: 0x04003B25 RID: 15141
		private static int RegisterId;

		// Token: 0x02000E30 RID: 3632
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		private ref struct __FPlayStationCreateHandleCallBack_DelegateParams
		{
			// Token: 0x040061C8 RID: 25032
			[FieldOffset(0)]
			public int ret;

			// Token: 0x040061C9 RID: 25033
			[FieldOffset(4)]
			public int result;
		}

		// Token: 0x02000E31 RID: 3633
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040061CA RID: 25034
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
