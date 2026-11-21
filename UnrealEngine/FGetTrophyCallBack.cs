using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020005C6 RID: 1478
	public sealed class FGetTrophyCallBack : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06008387 RID: 33671 RVA: 0x000C2BE8 File Offset: 0x000C0DE8
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FGetTrophyCallBack.StaticFunctionPtr();
		}

		// Token: 0x06008388 RID: 33672 RVA: 0x000C2BF4 File Offset: 0x000C0DF4
		private static IntPtr StaticFunctionPtr()
		{
			if (FGetTrophyCallBack._FunctionPtr == IntPtr.Zero)
			{
				FGetTrophyCallBack._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroUtility.GetTrophyCallBack__DelegateSignature");
			}
			return FGetTrophyCallBack._FunctionPtr;
		}

		// Token: 0x06008389 RID: 33673 RVA: 0x000C2C17 File Offset: 0x000C0E17
		public FGetTrophyCallBack()
		{
		}

		// Token: 0x0600838A RID: 33674 RVA: 0x000C2C1F File Offset: 0x000C0E1F
		[NullableContext(2)]
		public FGetTrophyCallBack(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600838B RID: 33675 RVA: 0x000C2C29 File Offset: 0x000C0E29
		public FGetTrophyCallBack(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600838C RID: 33676 RVA: 0x000C2C34 File Offset: 0x000C0E34
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<FTrophyInfoData>) ?? ((Action<FTrophyInfoData>)Delegate.CreateDelegate(typeof(Action<FTrophyInfoData>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600838D RID: 33677 RVA: 0x000C2C66 File Offset: 0x000C0E66
		[NullableContext(1)]
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

		// Token: 0x0600838E RID: 33678 RVA: 0x000C2CA0 File Offset: 0x000C0EA0
		[NullableContext(2)]
		[SkipLocalsInit]
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

		// Token: 0x0600838F RID: 33679 RVA: 0x000C2D0C File Offset: 0x000C0F0C
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x0400396F RID: 14703
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003970 RID: 14704
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroUtility.GetTrophyCallBack__DelegateSignature";

		// Token: 0x04003971 RID: 14705
		private static int RegisterId;

		// Token: 0x02000D43 RID: 3395
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		private ref struct __FGetTrophyCallBack_DelegateParams
		{
			// Token: 0x04005FE0 RID: 24544
			[FieldOffset(0)]
			public byte data;
		}

		// Token: 0x02000D44 RID: 3396
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005FE1 RID: 24545
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
