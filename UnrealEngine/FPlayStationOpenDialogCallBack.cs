using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001F01 RID: 7937
	public sealed class FPlayStationOpenDialogCallBack : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601E21D RID: 123421 RVA: 0x002CC9E6 File Offset: 0x002CABE6
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FPlayStationOpenDialogCallBack.StaticFunctionPtr();
		}

		// Token: 0x0601E21E RID: 123422 RVA: 0x002CC9F2 File Offset: 0x002CABF2
		private static IntPtr StaticFunctionPtr()
		{
			if (FPlayStationOpenDialogCallBack._FunctionPtr == IntPtr.Zero)
			{
				FPlayStationOpenDialogCallBack._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroUtility.PlayStationOpenDialogCallBack__DelegateSignature");
			}
			return FPlayStationOpenDialogCallBack._FunctionPtr;
		}

		// Token: 0x0601E21F RID: 123423 RVA: 0x002CCA15 File Offset: 0x002CAC15
		public FPlayStationOpenDialogCallBack()
		{
		}

		// Token: 0x0601E220 RID: 123424 RVA: 0x002CCA1D File Offset: 0x002CAC1D
		[NullableContext(2)]
		public FPlayStationOpenDialogCallBack(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601E221 RID: 123425 RVA: 0x002CCA27 File Offset: 0x002CAC27
		public FPlayStationOpenDialogCallBack(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601E222 RID: 123426 RVA: 0x002CCA32 File Offset: 0x002CAC32
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<int>) ?? ((Action<int>)Delegate.CreateDelegate(typeof(Action<int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601E223 RID: 123427 RVA: 0x002CCA64 File Offset: 0x002CAC64
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0601E224 RID: 123428 RVA: 0x002CCAA0 File Offset: 0x002CACA0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(int ret)
		{
			FPlayStationOpenDialogCallBack.__FPlayStationOpenDialogCallBack_DelegateParams* ptr = stackalloc FPlayStationOpenDialogCallBack.__FPlayStationOpenDialogCallBack_DelegateParams[(UIntPtr)19] + 15L / (long)sizeof(FPlayStationOpenDialogCallBack.__FPlayStationOpenDialogCallBack_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FPlayStationOpenDialogCallBack.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->ret = ret;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0601E225 RID: 123429 RVA: 0x002CCAE0 File Offset: 0x002CACE0
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
			action(((FPlayStationOpenDialogCallBack.__FPlayStationOpenDialogCallBack_DelegateParams*)__Parameters)->ret);
		}

		// Token: 0x04010463 RID: 66659
		internal static IntPtr _FunctionPtr;

		// Token: 0x04010464 RID: 66660
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroUtility.PlayStationOpenDialogCallBack__DelegateSignature";

		// Token: 0x04010465 RID: 66661
		private static int RegisterId;

		// Token: 0x020033ED RID: 13293
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __FPlayStationOpenDialogCallBack_DelegateParams
		{
			// Token: 0x040173A7 RID: 95143
			[FieldOffset(0)]
			public int ret;
		}

		// Token: 0x020033EE RID: 13294
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040173A8 RID: 95144
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
