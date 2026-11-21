using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200060B RID: 1547
	public sealed class FPlayStationGetBlockResult : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06008842 RID: 34882 RVA: 0x000CD566 File Offset: 0x000CB766
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FPlayStationGetBlockResult.StaticFunctionPtr();
		}

		// Token: 0x06008843 RID: 34883 RVA: 0x000CD572 File Offset: 0x000CB772
		private static IntPtr StaticFunctionPtr()
		{
			if (FPlayStationGetBlockResult._FunctionPtr == IntPtr.Zero)
			{
				FPlayStationGetBlockResult._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroUtility.PlayStationGetBlockResult__DelegateSignature");
			}
			return FPlayStationGetBlockResult._FunctionPtr;
		}

		// Token: 0x06008844 RID: 34884 RVA: 0x000CD595 File Offset: 0x000CB795
		public FPlayStationGetBlockResult()
		{
		}

		// Token: 0x06008845 RID: 34885 RVA: 0x000CD59D File Offset: 0x000CB79D
		[NullableContext(2)]
		public FPlayStationGetBlockResult(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06008846 RID: 34886 RVA: 0x000CD5A7 File Offset: 0x000CB7A7
		public FPlayStationGetBlockResult(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06008847 RID: 34887 RVA: 0x000CD5B2 File Offset: 0x000CB7B2
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<FBlockUserData>) ?? ((Action<FBlockUserData>)Delegate.CreateDelegate(typeof(Action<FBlockUserData>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06008848 RID: 34888 RVA: 0x000CD5E4 File Offset: 0x000CB7E4
		[NullableContext(1)]
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

		// Token: 0x06008849 RID: 34889 RVA: 0x000CD620 File Offset: 0x000CB820
		[NullableContext(2)]
		[SkipLocalsInit]
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

		// Token: 0x0600884A RID: 34890 RVA: 0x000CD68C File Offset: 0x000CB88C
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x04003B2C RID: 15148
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003B2D RID: 15149
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroUtility.PlayStationGetBlockResult__DelegateSignature";

		// Token: 0x04003B2E RID: 15150
		private static int RegisterId;

		// Token: 0x02000E36 RID: 3638
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		private ref struct __FPlayStationGetBlockResult_DelegateParams
		{
			// Token: 0x040061CF RID: 25039
			[FieldOffset(0)]
			public byte data;
		}

		// Token: 0x02000E37 RID: 3639
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040061D0 RID: 25040
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
