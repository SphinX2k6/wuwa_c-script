using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001EFD RID: 7933
	public sealed class FPlayStationDestroyHandleCallBack : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601E1F9 RID: 123385 RVA: 0x002CC49A File Offset: 0x002CA69A
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FPlayStationDestroyHandleCallBack.StaticFunctionPtr();
		}

		// Token: 0x0601E1FA RID: 123386 RVA: 0x002CC4A6 File Offset: 0x002CA6A6
		private static IntPtr StaticFunctionPtr()
		{
			if (FPlayStationDestroyHandleCallBack._FunctionPtr == IntPtr.Zero)
			{
				FPlayStationDestroyHandleCallBack._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroUtility.PlayStationDestroyHandleCallBack__DelegateSignature");
			}
			return FPlayStationDestroyHandleCallBack._FunctionPtr;
		}

		// Token: 0x0601E1FB RID: 123387 RVA: 0x002CC4C9 File Offset: 0x002CA6C9
		public FPlayStationDestroyHandleCallBack()
		{
		}

		// Token: 0x0601E1FC RID: 123388 RVA: 0x002CC4D1 File Offset: 0x002CA6D1
		[NullableContext(2)]
		public FPlayStationDestroyHandleCallBack(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601E1FD RID: 123389 RVA: 0x002CC4DB File Offset: 0x002CA6DB
		public FPlayStationDestroyHandleCallBack(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601E1FE RID: 123390 RVA: 0x002CC4E6 File Offset: 0x002CA6E6
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<int>) ?? ((Action<int>)Delegate.CreateDelegate(typeof(Action<int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601E1FF RID: 123391 RVA: 0x002CC518 File Offset: 0x002CA718
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0601E200 RID: 123392 RVA: 0x002CC554 File Offset: 0x002CA754
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(int ret)
		{
			FPlayStationDestroyHandleCallBack.__FPlayStationDestroyHandleCallBack_DelegateParams* ptr = stackalloc FPlayStationDestroyHandleCallBack.__FPlayStationDestroyHandleCallBack_DelegateParams[(UIntPtr)19] + 15L / (long)sizeof(FPlayStationDestroyHandleCallBack.__FPlayStationDestroyHandleCallBack_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FPlayStationDestroyHandleCallBack.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->ret = ret;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0601E201 RID: 123393 RVA: 0x002CC594 File Offset: 0x002CA794
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
			action(((FPlayStationDestroyHandleCallBack.__FPlayStationDestroyHandleCallBack_DelegateParams*)__Parameters)->ret);
		}

		// Token: 0x04010457 RID: 66647
		internal static IntPtr _FunctionPtr;

		// Token: 0x04010458 RID: 66648
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroUtility.PlayStationDestroyHandleCallBack__DelegateSignature";

		// Token: 0x04010459 RID: 66649
		private static int RegisterId;

		// Token: 0x020033E5 RID: 13285
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __FPlayStationDestroyHandleCallBack_DelegateParams
		{
			// Token: 0x0401739E RID: 95134
			[FieldOffset(0)]
			public int ret;
		}

		// Token: 0x020033E6 RID: 13286
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401739F RID: 95135
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
