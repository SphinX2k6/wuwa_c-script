using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001EF0 RID: 7920
	public sealed class FOnXboxAchievementUpdated : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601E179 RID: 123257 RVA: 0x002CB26D File Offset: 0x002C946D
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnXboxAchievementUpdated.StaticFunctionPtr();
		}

		// Token: 0x0601E17A RID: 123258 RVA: 0x002CB279 File Offset: 0x002C9479
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnXboxAchievementUpdated._FunctionPtr == IntPtr.Zero)
			{
				FOnXboxAchievementUpdated._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroUtility.OnXboxAchievementUpdated__DelegateSignature");
			}
			return FOnXboxAchievementUpdated._FunctionPtr;
		}

		// Token: 0x0601E17B RID: 123259 RVA: 0x002CB29C File Offset: 0x002C949C
		public FOnXboxAchievementUpdated()
		{
		}

		// Token: 0x0601E17C RID: 123260 RVA: 0x002CB2A4 File Offset: 0x002C94A4
		[NullableContext(2)]
		public FOnXboxAchievementUpdated(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601E17D RID: 123261 RVA: 0x002CB2AE File Offset: 0x002C94AE
		public FOnXboxAchievementUpdated(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601E17E RID: 123262 RVA: 0x002CB2B9 File Offset: 0x002C94B9
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<bool>) ?? ((Action<bool>)Delegate.CreateDelegate(typeof(Action<bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601E17F RID: 123263 RVA: 0x002CB2EB File Offset: 0x002C94EB
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0601E180 RID: 123264 RVA: 0x002CB328 File Offset: 0x002C9528
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(bool bSuccess)
		{
			FOnXboxAchievementUpdated.__FOnXboxAchievementUpdated_DelegateParams* ptr = stackalloc FOnXboxAchievementUpdated.__FOnXboxAchievementUpdated_DelegateParams[(UIntPtr)16] + 15L / (long)sizeof(FOnXboxAchievementUpdated.__FOnXboxAchievementUpdated_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnXboxAchievementUpdated.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->bSuccess = bSuccess;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0601E181 RID: 123265 RVA: 0x002CB368 File Offset: 0x002C9568
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<bool> action = target as Action<bool>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FOnXboxAchievementUpdated.__FOnXboxAchievementUpdated_DelegateParams*)__Parameters)->bSuccess);
		}

		// Token: 0x0401042A RID: 66602
		internal static IntPtr _FunctionPtr;

		// Token: 0x0401042B RID: 66603
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroUtility.OnXboxAchievementUpdated__DelegateSignature";

		// Token: 0x0401042C RID: 66604
		private static int RegisterId;

		// Token: 0x020033CD RID: 13261
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __FOnXboxAchievementUpdated_DelegateParams
		{
			// Token: 0x04017382 RID: 95106
			[FieldOffset(0)]
			public bool bSuccess;
		}

		// Token: 0x020033CE RID: 13262
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017383 RID: 95107
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
