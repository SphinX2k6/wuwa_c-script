using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001F03 RID: 7939
	public sealed class FPlayStationUnlockTrophyCallBack : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601E22F RID: 123439 RVA: 0x002CCC6E File Offset: 0x002CAE6E
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FPlayStationUnlockTrophyCallBack.StaticFunctionPtr();
		}

		// Token: 0x0601E230 RID: 123440 RVA: 0x002CCC7A File Offset: 0x002CAE7A
		private static IntPtr StaticFunctionPtr()
		{
			if (FPlayStationUnlockTrophyCallBack._FunctionPtr == IntPtr.Zero)
			{
				FPlayStationUnlockTrophyCallBack._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroUtility.PlayStationUnlockTrophyCallBack__DelegateSignature");
			}
			return FPlayStationUnlockTrophyCallBack._FunctionPtr;
		}

		// Token: 0x0601E231 RID: 123441 RVA: 0x002CCC9D File Offset: 0x002CAE9D
		public FPlayStationUnlockTrophyCallBack()
		{
		}

		// Token: 0x0601E232 RID: 123442 RVA: 0x002CCCA5 File Offset: 0x002CAEA5
		[NullableContext(2)]
		public FPlayStationUnlockTrophyCallBack(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601E233 RID: 123443 RVA: 0x002CCCAF File Offset: 0x002CAEAF
		public FPlayStationUnlockTrophyCallBack(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601E234 RID: 123444 RVA: 0x002CCCBA File Offset: 0x002CAEBA
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<int>) ?? ((Action<int>)Delegate.CreateDelegate(typeof(Action<int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601E235 RID: 123445 RVA: 0x002CCCEC File Offset: 0x002CAEEC
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action<int> Callback)
		{
			if (FPlayStationUnlockTrophyCallBack.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FPlayStationUnlockTrophyCallBack.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FPlayStationUnlockTrophyCallBack.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FPlayStationUnlockTrophyCallBack.OnScriptCallback));
				}
				FPlayStationUnlockTrophyCallBack.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FPlayStationUnlockTrophyCallBack.RegisterId);
		}

		// Token: 0x0601E236 RID: 123446 RVA: 0x002CCD28 File Offset: 0x002CAF28
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(int ret)
		{
			FPlayStationUnlockTrophyCallBack.__FPlayStationUnlockTrophyCallBack_DelegateParams* ptr = stackalloc FPlayStationUnlockTrophyCallBack.__FPlayStationUnlockTrophyCallBack_DelegateParams[(UIntPtr)19] + 15L / (long)sizeof(FPlayStationUnlockTrophyCallBack.__FPlayStationUnlockTrophyCallBack_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FPlayStationUnlockTrophyCallBack.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->ret = ret;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0601E237 RID: 123447 RVA: 0x002CCD68 File Offset: 0x002CAF68
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
			action(((FPlayStationUnlockTrophyCallBack.__FPlayStationUnlockTrophyCallBack_DelegateParams*)__Parameters)->ret);
		}

		// Token: 0x04010469 RID: 66665
		internal static IntPtr _FunctionPtr;

		// Token: 0x0401046A RID: 66666
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroUtility.PlayStationUnlockTrophyCallBack__DelegateSignature";

		// Token: 0x0401046B RID: 66667
		private static int RegisterId;

		// Token: 0x020033F1 RID: 13297
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __FPlayStationUnlockTrophyCallBack_DelegateParams
		{
			// Token: 0x040173AB RID: 95147
			[FieldOffset(0)]
			public int ret;
		}

		// Token: 0x020033F2 RID: 13298
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040173AC RID: 95148
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
