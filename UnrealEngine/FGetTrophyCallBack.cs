using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001EA3 RID: 7843
	public sealed class FGetTrophyCallBack : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601DC86 RID: 121990 RVA: 0x002C041C File Offset: 0x002BE61C
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FGetTrophyCallBack.StaticFunctionPtr();
		}

		// Token: 0x0601DC87 RID: 121991 RVA: 0x002C0428 File Offset: 0x002BE628
		private static IntPtr StaticFunctionPtr()
		{
			if (FGetTrophyCallBack._FunctionPtr == IntPtr.Zero)
			{
				FGetTrophyCallBack._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroUtility.GetTrophyCallBack__DelegateSignature");
			}
			return FGetTrophyCallBack._FunctionPtr;
		}

		// Token: 0x0601DC88 RID: 121992 RVA: 0x002C044B File Offset: 0x002BE64B
		public FGetTrophyCallBack()
		{
		}

		// Token: 0x0601DC89 RID: 121993 RVA: 0x002C0453 File Offset: 0x002BE653
		[NullableContext(2)]
		public FGetTrophyCallBack(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601DC8A RID: 121994 RVA: 0x002C045D File Offset: 0x002BE65D
		public FGetTrophyCallBack(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601DC8B RID: 121995 RVA: 0x002C0468 File Offset: 0x002BE668
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<FTrophyInfoData>) ?? ((Action<FTrophyInfoData>)Delegate.CreateDelegate(typeof(Action<FTrophyInfoData>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601DC8C RID: 121996 RVA: 0x002C049A File Offset: 0x002BE69A
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action<FTrophyInfoData> Callback)
		{
			if (FGetTrophyCallBack.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FGetTrophyCallBack.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FGetTrophyCallBack.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FGetTrophyCallBack.OnScriptCallback));
				}
				FGetTrophyCallBack.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FGetTrophyCallBack.RegisterId);
		}

		// Token: 0x0601DC8D RID: 121997 RVA: 0x002C04D4 File Offset: 0x002BE6D4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(FTrophyInfoData data)
		{
			FGetTrophyCallBack.__FGetTrophyCallBack_DelegateParams* ptr = stackalloc FGetTrophyCallBack.__FGetTrophyCallBack_DelegateParams[(UIntPtr)55] + 15L / (long)sizeof(FGetTrophyCallBack.__FGetTrophyCallBack_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FGetTrophyCallBack.StaticFunctionPtr(), (void*)ptr, 1);
			if (data != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FTrophyInfoData.StaticStruct(), &ptr->data, data.NativePtr, 1, false);
			}
			base.ExecuteInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FGetTrophyCallBack._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601DC8E RID: 121998 RVA: 0x002C0540 File Offset: 0x002BE740
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<FTrophyInfoData> action = target as Action<FTrophyInfoData>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			FTrophyInfoData obj = new FTrophyInfoData(&((FGetTrophyCallBack.__FGetTrophyCallBack_DelegateParams*)__Parameters)->data, true, true);
			action(obj);
		}

		// Token: 0x04010238 RID: 66104
		internal static IntPtr _FunctionPtr;

		// Token: 0x04010239 RID: 66105
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroUtility.GetTrophyCallBack__DelegateSignature";

		// Token: 0x0401023A RID: 66106
		private static int RegisterId;

		// Token: 0x020032E9 RID: 13033
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __FGetTrophyCallBack_DelegateParams
		{
			// Token: 0x04017199 RID: 94617
			[FieldOffset(0)]
			public byte data;
		}

		// Token: 0x020032EA RID: 13034
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401719A RID: 94618
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
