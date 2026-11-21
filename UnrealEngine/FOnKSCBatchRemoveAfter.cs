using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000598 RID: 1432
	public sealed class FOnKSCBatchRemoveAfter : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060081DD RID: 33245 RVA: 0x000BFACC File Offset: 0x000BDCCC
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnKSCBatchRemoveAfter.StaticFunctionPtr();
		}

		// Token: 0x060081DE RID: 33246 RVA: 0x000BFAD8 File Offset: 0x000BDCD8
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnKSCBatchRemoveAfter._FunctionPtr == IntPtr.Zero)
			{
				FOnKSCBatchRemoveAfter._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroSimpleCombat.OnKSCBatchRemoveAfter__DelegateSignature");
			}
			return FOnKSCBatchRemoveAfter._FunctionPtr;
		}

		// Token: 0x060081DF RID: 33247 RVA: 0x000BFAFB File Offset: 0x000BDCFB
		public FOnKSCBatchRemoveAfter()
		{
		}

		// Token: 0x060081E0 RID: 33248 RVA: 0x000BFB03 File Offset: 0x000BDD03
		[NullableContext(2)]
		public FOnKSCBatchRemoveAfter(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060081E1 RID: 33249 RVA: 0x000BFB0D File Offset: 0x000BDD0D
		public FOnKSCBatchRemoveAfter(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060081E2 RID: 33250 RVA: 0x000BFB18 File Offset: 0x000BDD18
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as FOnKSCBatchRemoveAfter.FOnKSCBatchRemoveAfter_ScriptDelegate) ?? ((FOnKSCBatchRemoveAfter.FOnKSCBatchRemoveAfter_ScriptDelegate)Delegate.CreateDelegate(typeof(FOnKSCBatchRemoveAfter.FOnKSCBatchRemoveAfter_ScriptDelegate), Callback.Target, Callback.Method)));
		}

		// Token: 0x060081E3 RID: 33251 RVA: 0x000BFB4A File Offset: 0x000BDD4A
		[NullableContext(1)]
		public void Bind(FOnKSCBatchRemoveAfter.FOnKSCBatchRemoveAfter_ScriptDelegate Callback)
		{
			if (FOnKSCBatchRemoveAfter.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnKSCBatchRemoveAfter.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnKSCBatchRemoveAfter.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnKSCBatchRemoveAfter.OnScriptCallback));
				}
				FOnKSCBatchRemoveAfter.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FOnKSCBatchRemoveAfter.RegisterId);
		}

		// Token: 0x060081E4 RID: 33252 RVA: 0x000BFB84 File Offset: 0x000BDD84
		[SkipLocalsInit]
		public unsafe void Execute([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FKSC_RemoveContext> RemoveContext)
		{
			FOnKSCBatchRemoveAfter.__FOnKSCBatchRemoveAfter_DelegateParams* ptr = stackalloc FOnKSCBatchRemoveAfter.__FOnKSCBatchRemoveAfter_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FOnKSCBatchRemoveAfter.__FOnKSCBatchRemoveAfter_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnKSCBatchRemoveAfter.StaticFunctionPtr(), (void*)ptr, 1);
			TArray<FKSC_RemoveContext> tarray = RemoveContext;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->RemoveContext);
			}
			base.ExecuteInternal((void*)ptr);
			TArray<FKSC_RemoveContext> tarray2 = RemoveContext;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->RemoveContext);
			}
			UnrealReflectionUtils.DestroyStruct(FOnKSCBatchRemoveAfter._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060081E5 RID: 33253 RVA: 0x000BFBF4 File Offset: 0x000BDDF4
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			FOnKSCBatchRemoveAfter.FOnKSCBatchRemoveAfter_ScriptDelegate fonKSCBatchRemoveAfter_ScriptDelegate = target as FOnKSCBatchRemoveAfter.FOnKSCBatchRemoveAfter_ScriptDelegate;
			if (fonKSCBatchRemoveAfter_ScriptDelegate == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			TArray<FKSC_RemoveContext> tarray = new TArray<FKSC_RemoveContext>(&((FOnKSCBatchRemoveAfter.__FOnKSCBatchRemoveAfter_DelegateParams*)__Parameters)->RemoveContext, true, true);
			fonKSCBatchRemoveAfter_ScriptDelegate(tarray);
			if (tarray != null)
			{
				tarray.CopyTo(&((FOnKSCBatchRemoveAfter.__FOnKSCBatchRemoveAfter_DelegateParams*)__Parameters)->RemoveContext, default(UScriptStructStackOnlyPtr));
			}
		}

		// Token: 0x040038A7 RID: 14503
		internal static IntPtr _FunctionPtr;

		// Token: 0x040038A8 RID: 14504
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSimpleCombat.OnKSCBatchRemoveAfter__DelegateSignature";

		// Token: 0x040038A9 RID: 14505
		private static int RegisterId;

		// Token: 0x02000D0F RID: 3343
		// (Invoke) Token: 0x0600BF03 RID: 48899
		public delegate void FOnKSCBatchRemoveAfter_ScriptDelegate([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FKSC_RemoveContext> RemoveContext);

		// Token: 0x02000D10 RID: 3344
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		private ref struct __FOnKSCBatchRemoveAfter_DelegateParams
		{
			// Token: 0x04005FA0 RID: 24480
			[FieldOffset(0)]
			public byte RemoveContext;
		}

		// Token: 0x02000D11 RID: 3345
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005FA1 RID: 24481
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
