using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001EFC RID: 7932
	public sealed class FPlayStationDestroyContextCallBack : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601E1F0 RID: 123376 RVA: 0x002CC358 File Offset: 0x002CA558
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FPlayStationDestroyContextCallBack.StaticFunctionPtr();
		}

		// Token: 0x0601E1F1 RID: 123377 RVA: 0x002CC364 File Offset: 0x002CA564
		private static IntPtr StaticFunctionPtr()
		{
			if (FPlayStationDestroyContextCallBack._FunctionPtr == IntPtr.Zero)
			{
				FPlayStationDestroyContextCallBack._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroUtility.PlayStationDestroyContextCallBack__DelegateSignature");
			}
			return FPlayStationDestroyContextCallBack._FunctionPtr;
		}

		// Token: 0x0601E1F2 RID: 123378 RVA: 0x002CC387 File Offset: 0x002CA587
		public FPlayStationDestroyContextCallBack()
		{
		}

		// Token: 0x0601E1F3 RID: 123379 RVA: 0x002CC38F File Offset: 0x002CA58F
		[NullableContext(2)]
		public FPlayStationDestroyContextCallBack(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601E1F4 RID: 123380 RVA: 0x002CC399 File Offset: 0x002CA599
		public FPlayStationDestroyContextCallBack(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601E1F5 RID: 123381 RVA: 0x002CC3A4 File Offset: 0x002CA5A4
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<int>) ?? ((Action<int>)Delegate.CreateDelegate(typeof(Action<int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601E1F6 RID: 123382 RVA: 0x002CC3D6 File Offset: 0x002CA5D6
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0601E1F7 RID: 123383 RVA: 0x002CC410 File Offset: 0x002CA610
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(int ret)
		{
			FPlayStationDestroyContextCallBack.__FPlayStationDestroyContextCallBack_DelegateParams* ptr = stackalloc FPlayStationDestroyContextCallBack.__FPlayStationDestroyContextCallBack_DelegateParams[(UIntPtr)19] + 15L / (long)sizeof(FPlayStationDestroyContextCallBack.__FPlayStationDestroyContextCallBack_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FPlayStationDestroyContextCallBack.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->ret = ret;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0601E1F8 RID: 123384 RVA: 0x002CC450 File Offset: 0x002CA650
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
			action(((FPlayStationDestroyContextCallBack.__FPlayStationDestroyContextCallBack_DelegateParams*)__Parameters)->ret);
		}

		// Token: 0x04010454 RID: 66644
		internal static IntPtr _FunctionPtr;

		// Token: 0x04010455 RID: 66645
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroUtility.PlayStationDestroyContextCallBack__DelegateSignature";

		// Token: 0x04010456 RID: 66646
		private static int RegisterId;

		// Token: 0x020033E3 RID: 13283
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __FPlayStationDestroyContextCallBack_DelegateParams
		{
			// Token: 0x0401739C RID: 95132
			[FieldOffset(0)]
			public int ret;
		}

		// Token: 0x020033E4 RID: 13284
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401739D RID: 95133
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
