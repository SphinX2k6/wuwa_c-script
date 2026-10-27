using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001EFB RID: 7931
	public sealed class FPlayStationCreateHandleCallBack : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601E1E7 RID: 123367 RVA: 0x002CC20C File Offset: 0x002CA40C
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FPlayStationCreateHandleCallBack.StaticFunctionPtr();
		}

		// Token: 0x0601E1E8 RID: 123368 RVA: 0x002CC218 File Offset: 0x002CA418
		private static IntPtr StaticFunctionPtr()
		{
			if (FPlayStationCreateHandleCallBack._FunctionPtr == IntPtr.Zero)
			{
				FPlayStationCreateHandleCallBack._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroUtility.PlayStationCreateHandleCallBack__DelegateSignature");
			}
			return FPlayStationCreateHandleCallBack._FunctionPtr;
		}

		// Token: 0x0601E1E9 RID: 123369 RVA: 0x002CC23B File Offset: 0x002CA43B
		public FPlayStationCreateHandleCallBack()
		{
		}

		// Token: 0x0601E1EA RID: 123370 RVA: 0x002CC243 File Offset: 0x002CA443
		[NullableContext(2)]
		public FPlayStationCreateHandleCallBack(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601E1EB RID: 123371 RVA: 0x002CC24D File Offset: 0x002CA44D
		public FPlayStationCreateHandleCallBack(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601E1EC RID: 123372 RVA: 0x002CC258 File Offset: 0x002CA458
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<int, int>) ?? ((Action<int, int>)Delegate.CreateDelegate(typeof(Action<int, int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601E1ED RID: 123373 RVA: 0x002CC28A File Offset: 0x002CA48A
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0601E1EE RID: 123374 RVA: 0x002CC2C4 File Offset: 0x002CA4C4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(int ret, int result)
		{
			FPlayStationCreateHandleCallBack.__FPlayStationCreateHandleCallBack_DelegateParams* ptr = stackalloc FPlayStationCreateHandleCallBack.__FPlayStationCreateHandleCallBack_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FPlayStationCreateHandleCallBack.__FPlayStationCreateHandleCallBack_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FPlayStationCreateHandleCallBack.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->ret = ret;
			ptr->result = result;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0601E1EF RID: 123375 RVA: 0x002CC308 File Offset: 0x002CA508
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int, int> action = target as Action<int, int>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FPlayStationCreateHandleCallBack.__FPlayStationCreateHandleCallBack_DelegateParams*)__Parameters)->ret, ((FPlayStationCreateHandleCallBack.__FPlayStationCreateHandleCallBack_DelegateParams*)__Parameters)->result);
		}

		// Token: 0x04010451 RID: 66641
		internal static IntPtr _FunctionPtr;

		// Token: 0x04010452 RID: 66642
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroUtility.PlayStationCreateHandleCallBack__DelegateSignature";

		// Token: 0x04010453 RID: 66643
		private static int RegisterId;

		// Token: 0x020033E1 RID: 13281
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __FPlayStationCreateHandleCallBack_DelegateParams
		{
			// Token: 0x04017399 RID: 95129
			[FieldOffset(0)]
			public int ret;

			// Token: 0x0401739A RID: 95130
			[FieldOffset(4)]
			public int result;
		}

		// Token: 0x020033E2 RID: 13282
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401739B RID: 95131
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
