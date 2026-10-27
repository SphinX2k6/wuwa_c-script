using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001F04 RID: 7940
	public sealed class FPlayStationUpdateTrophyCallBack : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601E238 RID: 123448 RVA: 0x002CCDB2 File Offset: 0x002CAFB2
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FPlayStationUpdateTrophyCallBack.StaticFunctionPtr();
		}

		// Token: 0x0601E239 RID: 123449 RVA: 0x002CCDBE File Offset: 0x002CAFBE
		private static IntPtr StaticFunctionPtr()
		{
			if (FPlayStationUpdateTrophyCallBack._FunctionPtr == IntPtr.Zero)
			{
				FPlayStationUpdateTrophyCallBack._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroUtility.PlayStationUpdateTrophyCallBack__DelegateSignature");
			}
			return FPlayStationUpdateTrophyCallBack._FunctionPtr;
		}

		// Token: 0x0601E23A RID: 123450 RVA: 0x002CCDE1 File Offset: 0x002CAFE1
		public FPlayStationUpdateTrophyCallBack()
		{
		}

		// Token: 0x0601E23B RID: 123451 RVA: 0x002CCDE9 File Offset: 0x002CAFE9
		[NullableContext(2)]
		public FPlayStationUpdateTrophyCallBack(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601E23C RID: 123452 RVA: 0x002CCDF3 File Offset: 0x002CAFF3
		public FPlayStationUpdateTrophyCallBack(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601E23D RID: 123453 RVA: 0x002CCDFE File Offset: 0x002CAFFE
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<int>) ?? ((Action<int>)Delegate.CreateDelegate(typeof(Action<int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601E23E RID: 123454 RVA: 0x002CCE30 File Offset: 0x002CB030
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action<int> Callback)
		{
			if (FPlayStationUpdateTrophyCallBack.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FPlayStationUpdateTrophyCallBack.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FPlayStationUpdateTrophyCallBack.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FPlayStationUpdateTrophyCallBack.OnScriptCallback));
				}
				FPlayStationUpdateTrophyCallBack.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FPlayStationUpdateTrophyCallBack.RegisterId);
		}

		// Token: 0x0601E23F RID: 123455 RVA: 0x002CCE6C File Offset: 0x002CB06C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(int ret)
		{
			FPlayStationUpdateTrophyCallBack.__FPlayStationUpdateTrophyCallBack_DelegateParams* ptr = stackalloc FPlayStationUpdateTrophyCallBack.__FPlayStationUpdateTrophyCallBack_DelegateParams[(UIntPtr)19] + 15L / (long)sizeof(FPlayStationUpdateTrophyCallBack.__FPlayStationUpdateTrophyCallBack_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FPlayStationUpdateTrophyCallBack.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->ret = ret;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0601E240 RID: 123456 RVA: 0x002CCEAC File Offset: 0x002CB0AC
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
			action(((FPlayStationUpdateTrophyCallBack.__FPlayStationUpdateTrophyCallBack_DelegateParams*)__Parameters)->ret);
		}

		// Token: 0x0401046C RID: 66668
		internal static IntPtr _FunctionPtr;

		// Token: 0x0401046D RID: 66669
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroUtility.PlayStationUpdateTrophyCallBack__DelegateSignature";

		// Token: 0x0401046E RID: 66670
		private static int RegisterId;

		// Token: 0x020033F3 RID: 13299
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __FPlayStationUpdateTrophyCallBack_DelegateParams
		{
			// Token: 0x040173AD RID: 95149
			[FieldOffset(0)]
			public int ret;
		}

		// Token: 0x020033F4 RID: 13300
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040173AE RID: 95150
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
