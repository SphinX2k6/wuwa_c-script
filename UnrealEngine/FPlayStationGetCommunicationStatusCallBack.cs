using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001EFF RID: 7935
	public sealed class FPlayStationGetCommunicationStatusCallBack : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601E20B RID: 123403 RVA: 0x002CC758 File Offset: 0x002CA958
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FPlayStationGetCommunicationStatusCallBack.StaticFunctionPtr();
		}

		// Token: 0x0601E20C RID: 123404 RVA: 0x002CC764 File Offset: 0x002CA964
		private static IntPtr StaticFunctionPtr()
		{
			if (FPlayStationGetCommunicationStatusCallBack._FunctionPtr == IntPtr.Zero)
			{
				FPlayStationGetCommunicationStatusCallBack._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroUtility.PlayStationGetCommunicationStatusCallBack__DelegateSignature");
			}
			return FPlayStationGetCommunicationStatusCallBack._FunctionPtr;
		}

		// Token: 0x0601E20D RID: 123405 RVA: 0x002CC787 File Offset: 0x002CA987
		public FPlayStationGetCommunicationStatusCallBack()
		{
		}

		// Token: 0x0601E20E RID: 123406 RVA: 0x002CC78F File Offset: 0x002CA98F
		[NullableContext(2)]
		public FPlayStationGetCommunicationStatusCallBack(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601E20F RID: 123407 RVA: 0x002CC799 File Offset: 0x002CA999
		public FPlayStationGetCommunicationStatusCallBack(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601E210 RID: 123408 RVA: 0x002CC7A4 File Offset: 0x002CA9A4
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<int, int>) ?? ((Action<int, int>)Delegate.CreateDelegate(typeof(Action<int, int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601E211 RID: 123409 RVA: 0x002CC7D6 File Offset: 0x002CA9D6
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action<int, int> Callback)
		{
			if (FPlayStationGetCommunicationStatusCallBack.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FPlayStationGetCommunicationStatusCallBack.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FPlayStationGetCommunicationStatusCallBack.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FPlayStationGetCommunicationStatusCallBack.OnScriptCallback));
				}
				FPlayStationGetCommunicationStatusCallBack.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FPlayStationGetCommunicationStatusCallBack.RegisterId);
		}

		// Token: 0x0601E212 RID: 123410 RVA: 0x002CC810 File Offset: 0x002CAA10
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(int ret, int status)
		{
			FPlayStationGetCommunicationStatusCallBack.__FPlayStationGetCommunicationStatusCallBack_DelegateParams* ptr = stackalloc FPlayStationGetCommunicationStatusCallBack.__FPlayStationGetCommunicationStatusCallBack_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FPlayStationGetCommunicationStatusCallBack.__FPlayStationGetCommunicationStatusCallBack_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FPlayStationGetCommunicationStatusCallBack.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->ret = ret;
			ptr->status = status;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0601E213 RID: 123411 RVA: 0x002CC854 File Offset: 0x002CAA54
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
			action(((FPlayStationGetCommunicationStatusCallBack.__FPlayStationGetCommunicationStatusCallBack_DelegateParams*)__Parameters)->ret, ((FPlayStationGetCommunicationStatusCallBack.__FPlayStationGetCommunicationStatusCallBack_DelegateParams*)__Parameters)->status);
		}

		// Token: 0x0401045D RID: 66653
		internal static IntPtr _FunctionPtr;

		// Token: 0x0401045E RID: 66654
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroUtility.PlayStationGetCommunicationStatusCallBack__DelegateSignature";

		// Token: 0x0401045F RID: 66655
		private static int RegisterId;

		// Token: 0x020033E9 RID: 13289
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __FPlayStationGetCommunicationStatusCallBack_DelegateParams
		{
			// Token: 0x040173A2 RID: 95138
			[FieldOffset(0)]
			public int ret;

			// Token: 0x040173A3 RID: 95139
			[FieldOffset(4)]
			public int status;
		}

		// Token: 0x020033EA RID: 13290
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040173A4 RID: 95140
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
