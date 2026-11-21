using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000600 RID: 1536
	public sealed class FOnXboxInviteReceivedDynamic : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060087DF RID: 34783 RVA: 0x000CC672 File Offset: 0x000CA872
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnXboxInviteReceivedDynamic.StaticFunctionPtr();
		}

		// Token: 0x060087E0 RID: 34784 RVA: 0x000CC67E File Offset: 0x000CA87E
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnXboxInviteReceivedDynamic._FunctionPtr == IntPtr.Zero)
			{
				FOnXboxInviteReceivedDynamic._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroUtility.OnXboxInviteReceivedDynamic__DelegateSignature");
			}
			return FOnXboxInviteReceivedDynamic._FunctionPtr;
		}

		// Token: 0x060087E1 RID: 34785 RVA: 0x000CC6A1 File Offset: 0x000CA8A1
		public FOnXboxInviteReceivedDynamic()
		{
		}

		// Token: 0x060087E2 RID: 34786 RVA: 0x000CC6A9 File Offset: 0x000CA8A9
		[NullableContext(2)]
		public FOnXboxInviteReceivedDynamic(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060087E3 RID: 34787 RVA: 0x000CC6B3 File Offset: 0x000CA8B3
		public FOnXboxInviteReceivedDynamic(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060087E4 RID: 34788 RVA: 0x000CC6BE File Offset: 0x000CA8BE
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<FXboxInviteInfo>) ?? ((Action<FXboxInviteInfo>)Delegate.CreateDelegate(typeof(Action<FXboxInviteInfo>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060087E5 RID: 34789 RVA: 0x000CC6F0 File Offset: 0x000CA8F0
		[NullableContext(1)]
		public void Bind(Action<FXboxInviteInfo> Callback)
		{
			if (FOnXboxInviteReceivedDynamic.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnXboxInviteReceivedDynamic.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnXboxInviteReceivedDynamic.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnXboxInviteReceivedDynamic.OnScriptCallback));
				}
				FOnXboxInviteReceivedDynamic.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FOnXboxInviteReceivedDynamic.RegisterId);
		}

		// Token: 0x060087E6 RID: 34790 RVA: 0x000CC72C File Offset: 0x000CA92C
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Execute(in FXboxInviteInfo Info)
		{
			FOnXboxInviteReceivedDynamic.__FOnXboxInviteReceivedDynamic_DelegateParams* ptr = stackalloc FOnXboxInviteReceivedDynamic.__FOnXboxInviteReceivedDynamic_DelegateParams[(UIntPtr)103] + 15L / (long)sizeof(FOnXboxInviteReceivedDynamic.__FOnXboxInviteReceivedDynamic_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnXboxInviteReceivedDynamic.StaticFunctionPtr(), (void*)ptr, 1);
			if (Info != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FXboxInviteInfo.StaticStruct(), &ptr->Info, Info.NativePtr, 1, false);
			}
			base.ExecuteInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FOnXboxInviteReceivedDynamic._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060087E7 RID: 34791 RVA: 0x000CC798 File Offset: 0x000CA998
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<FXboxInviteInfo> action = target as Action<FXboxInviteInfo>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			FXboxInviteInfo obj = new FXboxInviteInfo(&((FOnXboxInviteReceivedDynamic.__FOnXboxInviteReceivedDynamic_DelegateParams*)__Parameters)->Info, true, true);
			action(obj);
		}

		// Token: 0x04003B0B RID: 15115
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003B0C RID: 15116
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroUtility.OnXboxInviteReceivedDynamic__DelegateSignature";

		// Token: 0x04003B0D RID: 15117
		private static int RegisterId;

		// Token: 0x02000E20 RID: 3616
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 88)]
		private ref struct __FOnXboxInviteReceivedDynamic_DelegateParams
		{
			// Token: 0x040061B5 RID: 25013
			[FieldOffset(0)]
			public byte Info;
		}

		// Token: 0x02000E21 RID: 3617
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040061B6 RID: 25014
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
