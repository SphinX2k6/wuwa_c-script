using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001F02 RID: 7938
	public sealed class FPlayStationRegisterContextCallBack : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601E226 RID: 123430 RVA: 0x002CCB2A File Offset: 0x002CAD2A
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FPlayStationRegisterContextCallBack.StaticFunctionPtr();
		}

		// Token: 0x0601E227 RID: 123431 RVA: 0x002CCB36 File Offset: 0x002CAD36
		private static IntPtr StaticFunctionPtr()
		{
			if (FPlayStationRegisterContextCallBack._FunctionPtr == IntPtr.Zero)
			{
				FPlayStationRegisterContextCallBack._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroUtility.PlayStationRegisterContextCallBack__DelegateSignature");
			}
			return FPlayStationRegisterContextCallBack._FunctionPtr;
		}

		// Token: 0x0601E228 RID: 123432 RVA: 0x002CCB59 File Offset: 0x002CAD59
		public FPlayStationRegisterContextCallBack()
		{
		}

		// Token: 0x0601E229 RID: 123433 RVA: 0x002CCB61 File Offset: 0x002CAD61
		[NullableContext(2)]
		public FPlayStationRegisterContextCallBack(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601E22A RID: 123434 RVA: 0x002CCB6B File Offset: 0x002CAD6B
		public FPlayStationRegisterContextCallBack(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601E22B RID: 123435 RVA: 0x002CCB76 File Offset: 0x002CAD76
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<int>) ?? ((Action<int>)Delegate.CreateDelegate(typeof(Action<int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601E22C RID: 123436 RVA: 0x002CCBA8 File Offset: 0x002CADA8
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action<int> Callback)
		{
			if (FPlayStationRegisterContextCallBack.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FPlayStationRegisterContextCallBack.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FPlayStationRegisterContextCallBack.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FPlayStationRegisterContextCallBack.OnScriptCallback));
				}
				FPlayStationRegisterContextCallBack.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FPlayStationRegisterContextCallBack.RegisterId);
		}

		// Token: 0x0601E22D RID: 123437 RVA: 0x002CCBE4 File Offset: 0x002CADE4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(int ret)
		{
			FPlayStationRegisterContextCallBack.__FPlayStationRegisterContextCallBack_DelegateParams* ptr = stackalloc FPlayStationRegisterContextCallBack.__FPlayStationRegisterContextCallBack_DelegateParams[(UIntPtr)19] + 15L / (long)sizeof(FPlayStationRegisterContextCallBack.__FPlayStationRegisterContextCallBack_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FPlayStationRegisterContextCallBack.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->ret = ret;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0601E22E RID: 123438 RVA: 0x002CCC24 File Offset: 0x002CAE24
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
			action(((FPlayStationRegisterContextCallBack.__FPlayStationRegisterContextCallBack_DelegateParams*)__Parameters)->ret);
		}

		// Token: 0x04010466 RID: 66662
		internal static IntPtr _FunctionPtr;

		// Token: 0x04010467 RID: 66663
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroUtility.PlayStationRegisterContextCallBack__DelegateSignature";

		// Token: 0x04010468 RID: 66664
		private static int RegisterId;

		// Token: 0x020033EF RID: 13295
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __FPlayStationRegisterContextCallBack_DelegateParams
		{
			// Token: 0x040173A9 RID: 95145
			[FieldOffset(0)]
			public int ret;
		}

		// Token: 0x020033F0 RID: 13296
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040173AA RID: 95146
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
