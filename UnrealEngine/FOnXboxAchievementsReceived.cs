using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001EEF RID: 7919
	public sealed class FOnXboxAchievementsReceived : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601E170 RID: 123248 RVA: 0x002CB0C7 File Offset: 0x002C92C7
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnXboxAchievementsReceived.StaticFunctionPtr();
		}

		// Token: 0x0601E171 RID: 123249 RVA: 0x002CB0D3 File Offset: 0x002C92D3
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnXboxAchievementsReceived._FunctionPtr == IntPtr.Zero)
			{
				FOnXboxAchievementsReceived._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroUtility.OnXboxAchievementsReceived__DelegateSignature");
			}
			return FOnXboxAchievementsReceived._FunctionPtr;
		}

		// Token: 0x0601E172 RID: 123250 RVA: 0x002CB0F6 File Offset: 0x002C92F6
		public FOnXboxAchievementsReceived()
		{
		}

		// Token: 0x0601E173 RID: 123251 RVA: 0x002CB0FE File Offset: 0x002C92FE
		[NullableContext(2)]
		public FOnXboxAchievementsReceived(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601E174 RID: 123252 RVA: 0x002CB108 File Offset: 0x002C9308
		public FOnXboxAchievementsReceived(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601E175 RID: 123253 RVA: 0x002CB113 File Offset: 0x002C9313
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as FOnXboxAchievementsReceived.FOnXboxAchievementsReceived_ScriptDelegate) ?? ((FOnXboxAchievementsReceived.FOnXboxAchievementsReceived_ScriptDelegate)Delegate.CreateDelegate(typeof(FOnXboxAchievementsReceived.FOnXboxAchievementsReceived_ScriptDelegate), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601E176 RID: 123254 RVA: 0x002CB145 File Offset: 0x002C9345
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(FOnXboxAchievementsReceived.FOnXboxAchievementsReceived_ScriptDelegate Callback)
		{
			if (FOnXboxAchievementsReceived.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnXboxAchievementsReceived.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnXboxAchievementsReceived.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnXboxAchievementsReceived.OnScriptCallback));
				}
				FOnXboxAchievementsReceived.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FOnXboxAchievementsReceived.RegisterId);
		}

		// Token: 0x0601E177 RID: 123255 RVA: 0x002CB180 File Offset: 0x002C9380
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(bool bSuccess, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FXboxAchievementInfo> Achievements)
		{
			FOnXboxAchievementsReceived.__FOnXboxAchievementsReceived_DelegateParams* ptr = stackalloc FOnXboxAchievementsReceived.__FOnXboxAchievementsReceived_DelegateParams[(UIntPtr)39] + 15L / (long)sizeof(FOnXboxAchievementsReceived.__FOnXboxAchievementsReceived_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnXboxAchievementsReceived.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->bSuccess = bSuccess;
			TArray<FXboxAchievementInfo> tarray = Achievements;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->Achievements);
			}
			base.ExecuteInternal((void*)ptr);
			TArray<FXboxAchievementInfo> tarray2 = Achievements;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->Achievements);
			}
			UnrealReflectionUtils.DestroyStruct(FOnXboxAchievementsReceived._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601E178 RID: 123256 RVA: 0x002CB1F8 File Offset: 0x002C93F8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			FOnXboxAchievementsReceived.FOnXboxAchievementsReceived_ScriptDelegate fonXboxAchievementsReceived_ScriptDelegate = target as FOnXboxAchievementsReceived.FOnXboxAchievementsReceived_ScriptDelegate;
			if (fonXboxAchievementsReceived_ScriptDelegate == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			TArray<FXboxAchievementInfo> tarray = new TArray<FXboxAchievementInfo>(&((FOnXboxAchievementsReceived.__FOnXboxAchievementsReceived_DelegateParams*)__Parameters)->Achievements, true, true);
			fonXboxAchievementsReceived_ScriptDelegate(((FOnXboxAchievementsReceived.__FOnXboxAchievementsReceived_DelegateParams*)__Parameters)->bSuccess, tarray);
			if (tarray != null)
			{
				tarray.CopyTo(&((FOnXboxAchievementsReceived.__FOnXboxAchievementsReceived_DelegateParams*)__Parameters)->Achievements, default(UScriptStructStackOnlyPtr));
			}
		}

		// Token: 0x04010427 RID: 66599
		internal static IntPtr _FunctionPtr;

		// Token: 0x04010428 RID: 66600
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroUtility.OnXboxAchievementsReceived__DelegateSignature";

		// Token: 0x04010429 RID: 66601
		private static int RegisterId;

		// Token: 0x020033CA RID: 13258
		// (Invoke) Token: 0x060285BA RID: 165306
		public delegate void FOnXboxAchievementsReceived_ScriptDelegate(bool bSuccess, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FXboxAchievementInfo> Achievements);

		// Token: 0x020033CB RID: 13259
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __FOnXboxAchievementsReceived_DelegateParams
		{
			// Token: 0x0401737F RID: 95103
			[FieldOffset(0)]
			public bool bSuccess;

			// Token: 0x04017380 RID: 95104
			[FieldOffset(8)]
			public byte Achievements;
		}

		// Token: 0x020033CC RID: 13260
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017381 RID: 95105
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
