using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001EFA RID: 7930
	public sealed class FPlayStationCreateContextCallBack : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601E1DE RID: 123358 RVA: 0x002CC0BE File Offset: 0x002CA2BE
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FPlayStationCreateContextCallBack.StaticFunctionPtr();
		}

		// Token: 0x0601E1DF RID: 123359 RVA: 0x002CC0CA File Offset: 0x002CA2CA
		private static IntPtr StaticFunctionPtr()
		{
			if (FPlayStationCreateContextCallBack._FunctionPtr == IntPtr.Zero)
			{
				FPlayStationCreateContextCallBack._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroUtility.PlayStationCreateContextCallBack__DelegateSignature");
			}
			return FPlayStationCreateContextCallBack._FunctionPtr;
		}

		// Token: 0x0601E1E0 RID: 123360 RVA: 0x002CC0ED File Offset: 0x002CA2ED
		public FPlayStationCreateContextCallBack()
		{
		}

		// Token: 0x0601E1E1 RID: 123361 RVA: 0x002CC0F5 File Offset: 0x002CA2F5
		[NullableContext(2)]
		public FPlayStationCreateContextCallBack(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601E1E2 RID: 123362 RVA: 0x002CC0FF File Offset: 0x002CA2FF
		public FPlayStationCreateContextCallBack(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601E1E3 RID: 123363 RVA: 0x002CC10A File Offset: 0x002CA30A
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<int, int>) ?? ((Action<int, int>)Delegate.CreateDelegate(typeof(Action<int, int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601E1E4 RID: 123364 RVA: 0x002CC13C File Offset: 0x002CA33C
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action<int, int> Callback)
		{
			if (FPlayStationCreateContextCallBack.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FPlayStationCreateContextCallBack.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FPlayStationCreateContextCallBack.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FPlayStationCreateContextCallBack.OnScriptCallback));
				}
				FPlayStationCreateContextCallBack.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FPlayStationCreateContextCallBack.RegisterId);
		}

		// Token: 0x0601E1E5 RID: 123365 RVA: 0x002CC178 File Offset: 0x002CA378
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(int ret, int result)
		{
			FPlayStationCreateContextCallBack.__FPlayStationCreateContextCallBack_DelegateParams* ptr = stackalloc FPlayStationCreateContextCallBack.__FPlayStationCreateContextCallBack_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FPlayStationCreateContextCallBack.__FPlayStationCreateContextCallBack_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FPlayStationCreateContextCallBack.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->ret = ret;
			ptr->result = result;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0601E1E6 RID: 123366 RVA: 0x002CC1BC File Offset: 0x002CA3BC
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
			action(((FPlayStationCreateContextCallBack.__FPlayStationCreateContextCallBack_DelegateParams*)__Parameters)->ret, ((FPlayStationCreateContextCallBack.__FPlayStationCreateContextCallBack_DelegateParams*)__Parameters)->result);
		}

		// Token: 0x0401044E RID: 66638
		internal static IntPtr _FunctionPtr;

		// Token: 0x0401044F RID: 66639
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroUtility.PlayStationCreateContextCallBack__DelegateSignature";

		// Token: 0x04010450 RID: 66640
		private static int RegisterId;

		// Token: 0x020033DF RID: 13279
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __FPlayStationCreateContextCallBack_DelegateParams
		{
			// Token: 0x04017396 RID: 95126
			[FieldOffset(0)]
			public int ret;

			// Token: 0x04017397 RID: 95127
			[FieldOffset(4)]
			public int result;
		}

		// Token: 0x020033E0 RID: 13280
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017398 RID: 95128
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
