using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001EFE RID: 7934
	public sealed class FPlayStationGetBlockResult : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601E202 RID: 123394 RVA: 0x002CC5DE File Offset: 0x002CA7DE
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FPlayStationGetBlockResult.StaticFunctionPtr();
		}

		// Token: 0x0601E203 RID: 123395 RVA: 0x002CC5EA File Offset: 0x002CA7EA
		private static IntPtr StaticFunctionPtr()
		{
			if (FPlayStationGetBlockResult._FunctionPtr == IntPtr.Zero)
			{
				FPlayStationGetBlockResult._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroUtility.PlayStationGetBlockResult__DelegateSignature");
			}
			return FPlayStationGetBlockResult._FunctionPtr;
		}

		// Token: 0x0601E204 RID: 123396 RVA: 0x002CC60D File Offset: 0x002CA80D
		public FPlayStationGetBlockResult()
		{
		}

		// Token: 0x0601E205 RID: 123397 RVA: 0x002CC615 File Offset: 0x002CA815
		[NullableContext(2)]
		public FPlayStationGetBlockResult(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601E206 RID: 123398 RVA: 0x002CC61F File Offset: 0x002CA81F
		public FPlayStationGetBlockResult(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601E207 RID: 123399 RVA: 0x002CC62A File Offset: 0x002CA82A
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<FBlockUserData>) ?? ((Action<FBlockUserData>)Delegate.CreateDelegate(typeof(Action<FBlockUserData>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601E208 RID: 123400 RVA: 0x002CC65C File Offset: 0x002CA85C
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action<FBlockUserData> Callback)
		{
			if (FPlayStationGetBlockResult.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FPlayStationGetBlockResult.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FPlayStationGetBlockResult.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FPlayStationGetBlockResult.OnScriptCallback));
				}
				FPlayStationGetBlockResult.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FPlayStationGetBlockResult.RegisterId);
		}

		// Token: 0x0601E209 RID: 123401 RVA: 0x002CC698 File Offset: 0x002CA898
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(FBlockUserData data)
		{
			FPlayStationGetBlockResult.__FPlayStationGetBlockResult_DelegateParams* ptr = stackalloc FPlayStationGetBlockResult.__FPlayStationGetBlockResult_DelegateParams[(UIntPtr)39] + 15L / (long)sizeof(FPlayStationGetBlockResult.__FPlayStationGetBlockResult_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FPlayStationGetBlockResult.StaticFunctionPtr(), (void*)ptr, 1);
			if (data != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FBlockUserData.StaticStruct(), &ptr->data, data.NativePtr, 1, false);
			}
			base.ExecuteInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FPlayStationGetBlockResult._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601E20A RID: 123402 RVA: 0x002CC704 File Offset: 0x002CA904
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<FBlockUserData> action = target as Action<FBlockUserData>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			FBlockUserData obj = new FBlockUserData(&((FPlayStationGetBlockResult.__FPlayStationGetBlockResult_DelegateParams*)__Parameters)->data, true, true);
			action(obj);
		}

		// Token: 0x0401045A RID: 66650
		internal static IntPtr _FunctionPtr;

		// Token: 0x0401045B RID: 66651
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroUtility.PlayStationGetBlockResult__DelegateSignature";

		// Token: 0x0401045C RID: 66652
		private static int RegisterId;

		// Token: 0x020033E7 RID: 13287
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __FPlayStationGetBlockResult_DelegateParams
		{
			// Token: 0x040173A0 RID: 95136
			[FieldOffset(0)]
			public byte data;
		}

		// Token: 0x020033E8 RID: 13288
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040173A1 RID: 95137
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
