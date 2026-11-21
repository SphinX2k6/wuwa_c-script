using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020005FD RID: 1533
	public sealed class FOnXboxAchievementUpdated : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060087C4 RID: 34756 RVA: 0x000CC271 File Offset: 0x000CA471
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnXboxAchievementUpdated.StaticFunctionPtr();
		}

		// Token: 0x060087C5 RID: 34757 RVA: 0x000CC27D File Offset: 0x000CA47D
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnXboxAchievementUpdated._FunctionPtr == IntPtr.Zero)
			{
				FOnXboxAchievementUpdated._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroUtility.OnXboxAchievementUpdated__DelegateSignature");
			}
			return FOnXboxAchievementUpdated._FunctionPtr;
		}

		// Token: 0x060087C6 RID: 34758 RVA: 0x000CC2A0 File Offset: 0x000CA4A0
		public FOnXboxAchievementUpdated()
		{
		}

		// Token: 0x060087C7 RID: 34759 RVA: 0x000CC2A8 File Offset: 0x000CA4A8
		[NullableContext(2)]
		public FOnXboxAchievementUpdated(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060087C8 RID: 34760 RVA: 0x000CC2B2 File Offset: 0x000CA4B2
		public FOnXboxAchievementUpdated(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060087C9 RID: 34761 RVA: 0x000CC2BD File Offset: 0x000CA4BD
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<bool>) ?? ((Action<bool>)Delegate.CreateDelegate(typeof(Action<bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060087CA RID: 34762 RVA: 0x000CC2EF File Offset: 0x000CA4EF
		[NullableContext(1)]
		public void Bind(Action<bool> Callback)
		{
			if (FOnXboxAchievementUpdated.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnXboxAchievementUpdated.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnXboxAchievementUpdated.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnXboxAchievementUpdated.OnScriptCallback));
				}
				FOnXboxAchievementUpdated.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FOnXboxAchievementUpdated.RegisterId);
		}

		// Token: 0x060087CB RID: 34763 RVA: 0x000CC32C File Offset: 0x000CA52C
		[SkipLocalsInit]
		public unsafe void Execute(bool bSuccess)
		{
			FOnXboxAchievementUpdated.__FOnXboxAchievementUpdated_DelegateParams* ptr = stackalloc FOnXboxAchievementUpdated.__FOnXboxAchievementUpdated_DelegateParams[(UIntPtr)16] + 15L / (long)sizeof(FOnXboxAchievementUpdated.__FOnXboxAchievementUpdated_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnXboxAchievementUpdated.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->bSuccess = bSuccess;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x060087CC RID: 34764 RVA: 0x000CC36C File Offset: 0x000CA56C
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<bool> action = target as Action<bool>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FOnXboxAchievementUpdated.__FOnXboxAchievementUpdated_DelegateParams*)__Parameters)->bSuccess);
		}

		// Token: 0x04003B02 RID: 15106
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003B03 RID: 15107
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroUtility.OnXboxAchievementUpdated__DelegateSignature";

		// Token: 0x04003B04 RID: 15108
		private static int RegisterId;

		// Token: 0x02000E1A RID: 3610
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		private ref struct __FOnXboxAchievementUpdated_DelegateParams
		{
			// Token: 0x040061AF RID: 25007
			[FieldOffset(0)]
			public bool bSuccess;
		}

		// Token: 0x02000E1B RID: 3611
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040061B0 RID: 25008
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
