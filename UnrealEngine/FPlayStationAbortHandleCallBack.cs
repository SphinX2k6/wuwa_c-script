using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001EF9 RID: 7929
	public sealed class FPlayStationAbortHandleCallBack : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601E1D5 RID: 123349 RVA: 0x002CBF7A File Offset: 0x002CA17A
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FPlayStationAbortHandleCallBack.StaticFunctionPtr();
		}

		// Token: 0x0601E1D6 RID: 123350 RVA: 0x002CBF86 File Offset: 0x002CA186
		private static IntPtr StaticFunctionPtr()
		{
			if (FPlayStationAbortHandleCallBack._FunctionPtr == IntPtr.Zero)
			{
				FPlayStationAbortHandleCallBack._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroUtility.PlayStationAbortHandleCallBack__DelegateSignature");
			}
			return FPlayStationAbortHandleCallBack._FunctionPtr;
		}

		// Token: 0x0601E1D7 RID: 123351 RVA: 0x002CBFA9 File Offset: 0x002CA1A9
		public FPlayStationAbortHandleCallBack()
		{
		}

		// Token: 0x0601E1D8 RID: 123352 RVA: 0x002CBFB1 File Offset: 0x002CA1B1
		[NullableContext(2)]
		public FPlayStationAbortHandleCallBack(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601E1D9 RID: 123353 RVA: 0x002CBFBB File Offset: 0x002CA1BB
		public FPlayStationAbortHandleCallBack(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601E1DA RID: 123354 RVA: 0x002CBFC6 File Offset: 0x002CA1C6
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<int>) ?? ((Action<int>)Delegate.CreateDelegate(typeof(Action<int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601E1DB RID: 123355 RVA: 0x002CBFF8 File Offset: 0x002CA1F8
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0601E1DC RID: 123356 RVA: 0x002CC034 File Offset: 0x002CA234
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(int ret)
		{
			FPlayStationAbortHandleCallBack.__FPlayStationAbortHandleCallBack_DelegateParams* ptr = stackalloc FPlayStationAbortHandleCallBack.__FPlayStationAbortHandleCallBack_DelegateParams[(UIntPtr)19] + 15L / (long)sizeof(FPlayStationAbortHandleCallBack.__FPlayStationAbortHandleCallBack_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FPlayStationAbortHandleCallBack.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->ret = ret;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0601E1DD RID: 123357 RVA: 0x002CC074 File Offset: 0x002CA274
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int> action = target as Action<int>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FPlayStationAbortHandleCallBack.__FPlayStationAbortHandleCallBack_DelegateParams*)__Parameters)->ret);
		}

		// Token: 0x0401044B RID: 66635
		internal static IntPtr _FunctionPtr;

		// Token: 0x0401044C RID: 66636
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroUtility.PlayStationAbortHandleCallBack__DelegateSignature";

		// Token: 0x0401044D RID: 66637
		private static int RegisterId;

		// Token: 0x020033DD RID: 13277
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __FPlayStationAbortHandleCallBack_DelegateParams
		{
			// Token: 0x04017394 RID: 95124
			[FieldOffset(0)]
			public int ret;
		}

		// Token: 0x020033DE RID: 13278
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017395 RID: 95125
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
