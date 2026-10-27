using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001EE3 RID: 7907
	public sealed class FOnCompressComplete : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601E102 RID: 123138 RVA: 0x002C9EE6 File Offset: 0x002C80E6
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnCompressComplete.StaticFunctionPtr();
		}

		// Token: 0x0601E103 RID: 123139 RVA: 0x002C9EF2 File Offset: 0x002C80F2
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnCompressComplete._FunctionPtr == IntPtr.Zero)
			{
				FOnCompressComplete._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroUtility.OnCompressComplete__DelegateSignature");
			}
			return FOnCompressComplete._FunctionPtr;
		}

		// Token: 0x0601E104 RID: 123140 RVA: 0x002C9F15 File Offset: 0x002C8115
		public FOnCompressComplete()
		{
		}

		// Token: 0x0601E105 RID: 123141 RVA: 0x002C9F1D File Offset: 0x002C811D
		[NullableContext(2)]
		public FOnCompressComplete(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601E106 RID: 123142 RVA: 0x002C9F27 File Offset: 0x002C8127
		public FOnCompressComplete(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601E107 RID: 123143 RVA: 0x002C9F32 File Offset: 0x002C8132
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as FOnCompressComplete.FOnCompressComplete_ScriptDelegate) ?? ((FOnCompressComplete.FOnCompressComplete_ScriptDelegate)Delegate.CreateDelegate(typeof(FOnCompressComplete.FOnCompressComplete_ScriptDelegate), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601E108 RID: 123144 RVA: 0x002C9F64 File Offset: 0x002C8164
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(FOnCompressComplete.FOnCompressComplete_ScriptDelegate Callback)
		{
			if (FOnCompressComplete.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnCompressComplete.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnCompressComplete.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnCompressComplete.OnScriptCallback));
				}
				FOnCompressComplete.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FOnCompressComplete.RegisterId);
		}

		// Token: 0x0601E109 RID: 123145 RVA: 0x002C9FA0 File Offset: 0x002C81A0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<string> SuccessedPaths)
		{
			FOnCompressComplete.__FOnCompressComplete_DelegateParams* ptr = stackalloc FOnCompressComplete.__FOnCompressComplete_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FOnCompressComplete.__FOnCompressComplete_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnCompressComplete.StaticFunctionPtr(), (void*)ptr, 1);
			TArray<string> tarray = SuccessedPaths;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->SuccessedPaths);
			}
			base.ExecuteInternal((void*)ptr);
			TArray<string> tarray2 = SuccessedPaths;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->SuccessedPaths);
			}
			UnrealReflectionUtils.DestroyStruct(FOnCompressComplete._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601E10A RID: 123146 RVA: 0x002CA010 File Offset: 0x002C8210
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			FOnCompressComplete.FOnCompressComplete_ScriptDelegate fonCompressComplete_ScriptDelegate = target as FOnCompressComplete.FOnCompressComplete_ScriptDelegate;
			if (fonCompressComplete_ScriptDelegate == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			TArray<string> tarray = new TArray<string>(&((FOnCompressComplete.__FOnCompressComplete_DelegateParams*)__Parameters)->SuccessedPaths, true, true);
			fonCompressComplete_ScriptDelegate(tarray);
			if (tarray != null)
			{
				tarray.CopyTo(&((FOnCompressComplete.__FOnCompressComplete_DelegateParams*)__Parameters)->SuccessedPaths, default(UScriptStructStackOnlyPtr));
			}
		}

		// Token: 0x04010403 RID: 66563
		internal static IntPtr _FunctionPtr;

		// Token: 0x04010404 RID: 66564
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroUtility.OnCompressComplete__DelegateSignature";

		// Token: 0x04010405 RID: 66565
		private static int RegisterId;

		// Token: 0x020033AE RID: 13230
		// (Invoke) Token: 0x060285A6 RID: 165286
		public delegate void FOnCompressComplete_ScriptDelegate([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<string> SuccessedPaths);

		// Token: 0x020033AF RID: 13231
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FOnCompressComplete_DelegateParams
		{
			// Token: 0x04017363 RID: 95075
			[FieldOffset(0)]
			public byte SuccessedPaths;
		}

		// Token: 0x020033B0 RID: 13232
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017364 RID: 95076
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
