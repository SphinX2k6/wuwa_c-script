using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020005FC RID: 1532
	public sealed class FOnXboxAchievementsReceived : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060087BB RID: 34747 RVA: 0x000CC0CB File Offset: 0x000CA2CB
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnXboxAchievementsReceived.StaticFunctionPtr();
		}

		// Token: 0x060087BC RID: 34748 RVA: 0x000CC0D7 File Offset: 0x000CA2D7
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnXboxAchievementsReceived._FunctionPtr == IntPtr.Zero)
			{
				FOnXboxAchievementsReceived._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroUtility.OnXboxAchievementsReceived__DelegateSignature");
			}
			return FOnXboxAchievementsReceived._FunctionPtr;
		}

		// Token: 0x060087BD RID: 34749 RVA: 0x000CC0FA File Offset: 0x000CA2FA
		public FOnXboxAchievementsReceived()
		{
		}

		// Token: 0x060087BE RID: 34750 RVA: 0x000CC102 File Offset: 0x000CA302
		[NullableContext(2)]
		public FOnXboxAchievementsReceived(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060087BF RID: 34751 RVA: 0x000CC10C File Offset: 0x000CA30C
		public FOnXboxAchievementsReceived(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060087C0 RID: 34752 RVA: 0x000CC117 File Offset: 0x000CA317
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as FOnXboxAchievementsReceived.FOnXboxAchievementsReceived_ScriptDelegate) ?? ((FOnXboxAchievementsReceived.FOnXboxAchievementsReceived_ScriptDelegate)Delegate.CreateDelegate(typeof(FOnXboxAchievementsReceived.FOnXboxAchievementsReceived_ScriptDelegate), Callback.Target, Callback.Method)));
		}

		// Token: 0x060087C1 RID: 34753 RVA: 0x000CC149 File Offset: 0x000CA349
		[NullableContext(1)]
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

		// Token: 0x060087C2 RID: 34754 RVA: 0x000CC184 File Offset: 0x000CA384
		[SkipLocalsInit]
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

		// Token: 0x060087C3 RID: 34755 RVA: 0x000CC1FC File Offset: 0x000CA3FC
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x04003AFF RID: 15103
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003B00 RID: 15104
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroUtility.OnXboxAchievementsReceived__DelegateSignature";

		// Token: 0x04003B01 RID: 15105
		private static int RegisterId;

		// Token: 0x02000E17 RID: 3607
		// (Invoke) Token: 0x0600BF23 RID: 48931
		public delegate void FOnXboxAchievementsReceived_ScriptDelegate(bool bSuccess, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FXboxAchievementInfo> Achievements);

		// Token: 0x02000E18 RID: 3608
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		private ref struct __FOnXboxAchievementsReceived_DelegateParams
		{
			// Token: 0x040061AC RID: 25004
			[FieldOffset(0)]
			public bool bSuccess;

			// Token: 0x040061AD RID: 25005
			[FieldOffset(8)]
			public byte Achievements;
		}

		// Token: 0x02000E19 RID: 3609
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040061AE RID: 25006
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
