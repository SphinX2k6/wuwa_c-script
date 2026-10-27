using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001EF3 RID: 7923
	public sealed class FOnXboxInviteReceivedDynamic : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601E194 RID: 123284 RVA: 0x002CB66E File Offset: 0x002C986E
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnXboxInviteReceivedDynamic.StaticFunctionPtr();
		}

		// Token: 0x0601E195 RID: 123285 RVA: 0x002CB67A File Offset: 0x002C987A
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnXboxInviteReceivedDynamic._FunctionPtr == IntPtr.Zero)
			{
				FOnXboxInviteReceivedDynamic._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroUtility.OnXboxInviteReceivedDynamic__DelegateSignature");
			}
			return FOnXboxInviteReceivedDynamic._FunctionPtr;
		}

		// Token: 0x0601E196 RID: 123286 RVA: 0x002CB69D File Offset: 0x002C989D
		public FOnXboxInviteReceivedDynamic()
		{
		}

		// Token: 0x0601E197 RID: 123287 RVA: 0x002CB6A5 File Offset: 0x002C98A5
		[NullableContext(2)]
		public FOnXboxInviteReceivedDynamic(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601E198 RID: 123288 RVA: 0x002CB6AF File Offset: 0x002C98AF
		public FOnXboxInviteReceivedDynamic(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601E199 RID: 123289 RVA: 0x002CB6BA File Offset: 0x002C98BA
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<FXboxInviteInfo>) ?? ((Action<FXboxInviteInfo>)Delegate.CreateDelegate(typeof(Action<FXboxInviteInfo>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601E19A RID: 123290 RVA: 0x002CB6EC File Offset: 0x002C98EC
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0601E19B RID: 123291 RVA: 0x002CB728 File Offset: 0x002C9928
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0601E19C RID: 123292 RVA: 0x002CB794 File Offset: 0x002C9994
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x04010433 RID: 66611
		internal static IntPtr _FunctionPtr;

		// Token: 0x04010434 RID: 66612
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroUtility.OnXboxInviteReceivedDynamic__DelegateSignature";

		// Token: 0x04010435 RID: 66613
		private static int RegisterId;

		// Token: 0x020033D3 RID: 13267
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 88)]
		protected ref struct __FOnXboxInviteReceivedDynamic_DelegateParams
		{
			// Token: 0x04017388 RID: 95112
			[FieldOffset(0)]
			public byte Info;
		}

		// Token: 0x020033D4 RID: 13268
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017389 RID: 95113
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
