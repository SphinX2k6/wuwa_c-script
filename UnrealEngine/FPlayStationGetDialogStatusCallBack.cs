using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001F00 RID: 7936
	public sealed class FPlayStationGetDialogStatusCallBack : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601E214 RID: 123412 RVA: 0x002CC8A4 File Offset: 0x002CAAA4
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FPlayStationGetDialogStatusCallBack.StaticFunctionPtr();
		}

		// Token: 0x0601E215 RID: 123413 RVA: 0x002CC8B0 File Offset: 0x002CAAB0
		private static IntPtr StaticFunctionPtr()
		{
			if (FPlayStationGetDialogStatusCallBack._FunctionPtr == IntPtr.Zero)
			{
				FPlayStationGetDialogStatusCallBack._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroUtility.PlayStationGetDialogStatusCallBack__DelegateSignature");
			}
			return FPlayStationGetDialogStatusCallBack._FunctionPtr;
		}

		// Token: 0x0601E216 RID: 123414 RVA: 0x002CC8D3 File Offset: 0x002CAAD3
		public FPlayStationGetDialogStatusCallBack()
		{
		}

		// Token: 0x0601E217 RID: 123415 RVA: 0x002CC8DB File Offset: 0x002CAADB
		[NullableContext(2)]
		public FPlayStationGetDialogStatusCallBack(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601E218 RID: 123416 RVA: 0x002CC8E5 File Offset: 0x002CAAE5
		public FPlayStationGetDialogStatusCallBack(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601E219 RID: 123417 RVA: 0x002CC8F0 File Offset: 0x002CAAF0
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<int>) ?? ((Action<int>)Delegate.CreateDelegate(typeof(Action<int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601E21A RID: 123418 RVA: 0x002CC922 File Offset: 0x002CAB22
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action<int> Callback)
		{
			if (FPlayStationGetDialogStatusCallBack.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FPlayStationGetDialogStatusCallBack.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FPlayStationGetDialogStatusCallBack.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FPlayStationGetDialogStatusCallBack.OnScriptCallback));
				}
				FPlayStationGetDialogStatusCallBack.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FPlayStationGetDialogStatusCallBack.RegisterId);
		}

		// Token: 0x0601E21B RID: 123419 RVA: 0x002CC95C File Offset: 0x002CAB5C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(int ret)
		{
			FPlayStationGetDialogStatusCallBack.__FPlayStationGetDialogStatusCallBack_DelegateParams* ptr = stackalloc FPlayStationGetDialogStatusCallBack.__FPlayStationGetDialogStatusCallBack_DelegateParams[(UIntPtr)19] + 15L / (long)sizeof(FPlayStationGetDialogStatusCallBack.__FPlayStationGetDialogStatusCallBack_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FPlayStationGetDialogStatusCallBack.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->ret = ret;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0601E21C RID: 123420 RVA: 0x002CC99C File Offset: 0x002CAB9C
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
			action(((FPlayStationGetDialogStatusCallBack.__FPlayStationGetDialogStatusCallBack_DelegateParams*)__Parameters)->ret);
		}

		// Token: 0x04010460 RID: 66656
		internal static IntPtr _FunctionPtr;

		// Token: 0x04010461 RID: 66657
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroUtility.PlayStationGetDialogStatusCallBack__DelegateSignature";

		// Token: 0x04010462 RID: 66658
		private static int RegisterId;

		// Token: 0x020033EB RID: 13291
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __FPlayStationGetDialogStatusCallBack_DelegateParams
		{
			// Token: 0x040173A5 RID: 95141
			[FieldOffset(0)]
			public int ret;
		}

		// Token: 0x020033EC RID: 13292
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040173A6 RID: 95142
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
