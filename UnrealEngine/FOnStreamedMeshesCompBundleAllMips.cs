using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001EEE RID: 7918
	public sealed class FOnStreamedMeshesCompBundleAllMips : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601E167 RID: 123239 RVA: 0x002CAED9 File Offset: 0x002C90D9
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnStreamedMeshesCompBundleAllMips.StaticFunctionPtr();
		}

		// Token: 0x0601E168 RID: 123240 RVA: 0x002CAEE5 File Offset: 0x002C90E5
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnStreamedMeshesCompBundleAllMips._FunctionPtr == IntPtr.Zero)
			{
				FOnStreamedMeshesCompBundleAllMips._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroUtility.OnStreamedMeshesCompBundleAllMips__DelegateSignature");
			}
			return FOnStreamedMeshesCompBundleAllMips._FunctionPtr;
		}

		// Token: 0x0601E169 RID: 123241 RVA: 0x002CAF08 File Offset: 0x002C9108
		public FOnStreamedMeshesCompBundleAllMips()
		{
		}

		// Token: 0x0601E16A RID: 123242 RVA: 0x002CAF10 File Offset: 0x002C9110
		[NullableContext(2)]
		public FOnStreamedMeshesCompBundleAllMips(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601E16B RID: 123243 RVA: 0x002CAF1A File Offset: 0x002C911A
		public FOnStreamedMeshesCompBundleAllMips(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601E16C RID: 123244 RVA: 0x002CAF25 File Offset: 0x002C9125
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as FOnStreamedMeshesCompBundleAllMips.FOnStreamedMeshesCompBundleAllMips_ScriptDelegate) ?? ((FOnStreamedMeshesCompBundleAllMips.FOnStreamedMeshesCompBundleAllMips_ScriptDelegate)Delegate.CreateDelegate(typeof(FOnStreamedMeshesCompBundleAllMips.FOnStreamedMeshesCompBundleAllMips_ScriptDelegate), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601E16D RID: 123245 RVA: 0x002CAF57 File Offset: 0x002C9157
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(FOnStreamedMeshesCompBundleAllMips.FOnStreamedMeshesCompBundleAllMips_ScriptDelegate Callback)
		{
			if (FOnStreamedMeshesCompBundleAllMips.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnStreamedMeshesCompBundleAllMips.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnStreamedMeshesCompBundleAllMips.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnStreamedMeshesCompBundleAllMips.OnScriptCallback));
				}
				FOnStreamedMeshesCompBundleAllMips.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FOnStreamedMeshesCompBundleAllMips.RegisterId);
		}

		// Token: 0x0601E16E RID: 123246 RVA: 0x002CAF94 File Offset: 0x002C9194
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<USkeletalMesh> SkeletalMeshes, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<UStaticMesh> StaticMeshes)
		{
			FOnStreamedMeshesCompBundleAllMips.__FOnStreamedMeshesCompBundleAllMips_DelegateParams* ptr = stackalloc FOnStreamedMeshesCompBundleAllMips.__FOnStreamedMeshesCompBundleAllMips_DelegateParams[(UIntPtr)47] + 15L / (long)sizeof(FOnStreamedMeshesCompBundleAllMips.__FOnStreamedMeshesCompBundleAllMips_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnStreamedMeshesCompBundleAllMips.StaticFunctionPtr(), (void*)ptr, 1);
			TArray<USkeletalMesh> tarray = SkeletalMeshes;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->SkeletalMeshes);
			}
			TArray<UStaticMesh> tarray2 = StaticMeshes;
			if (tarray2 != null)
			{
				tarray2.MoveTo(&ptr->StaticMeshes);
			}
			base.ExecuteInternal((void*)ptr);
			TArray<USkeletalMesh> tarray3 = SkeletalMeshes;
			if (tarray3 != null)
			{
				tarray3.MoveAssign(&ptr->SkeletalMeshes);
			}
			TArray<UStaticMesh> tarray4 = StaticMeshes;
			if (tarray4 != null)
			{
				tarray4.MoveAssign(&ptr->StaticMeshes);
			}
			UnrealReflectionUtils.DestroyStruct(FOnStreamedMeshesCompBundleAllMips._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601E16F RID: 123247 RVA: 0x002CB02C File Offset: 0x002C922C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			FOnStreamedMeshesCompBundleAllMips.FOnStreamedMeshesCompBundleAllMips_ScriptDelegate fonStreamedMeshesCompBundleAllMips_ScriptDelegate = target as FOnStreamedMeshesCompBundleAllMips.FOnStreamedMeshesCompBundleAllMips_ScriptDelegate;
			if (fonStreamedMeshesCompBundleAllMips_ScriptDelegate == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			TArray<USkeletalMesh> tarray = new TArray<USkeletalMesh>(&((FOnStreamedMeshesCompBundleAllMips.__FOnStreamedMeshesCompBundleAllMips_DelegateParams*)__Parameters)->SkeletalMeshes, true, true);
			TArray<UStaticMesh> tarray2 = new TArray<UStaticMesh>(&((FOnStreamedMeshesCompBundleAllMips.__FOnStreamedMeshesCompBundleAllMips_DelegateParams*)__Parameters)->StaticMeshes, true, true);
			fonStreamedMeshesCompBundleAllMips_ScriptDelegate(tarray, tarray2);
			if (tarray != null)
			{
				tarray.CopyTo(&((FOnStreamedMeshesCompBundleAllMips.__FOnStreamedMeshesCompBundleAllMips_DelegateParams*)__Parameters)->SkeletalMeshes, default(UScriptStructStackOnlyPtr));
			}
			if (tarray2 != null)
			{
				tarray2.CopyTo(&((FOnStreamedMeshesCompBundleAllMips.__FOnStreamedMeshesCompBundleAllMips_DelegateParams*)__Parameters)->StaticMeshes, default(UScriptStructStackOnlyPtr));
			}
		}

		// Token: 0x04010424 RID: 66596
		internal static IntPtr _FunctionPtr;

		// Token: 0x04010425 RID: 66597
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroUtility.OnStreamedMeshesCompBundleAllMips__DelegateSignature";

		// Token: 0x04010426 RID: 66598
		private static int RegisterId;

		// Token: 0x020033C7 RID: 13255
		// (Invoke) Token: 0x060285B6 RID: 165302
		public delegate void FOnStreamedMeshesCompBundleAllMips_ScriptDelegate([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<USkeletalMesh> SkeletalMeshes, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<UStaticMesh> StaticMeshes);

		// Token: 0x020033C8 RID: 13256
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __FOnStreamedMeshesCompBundleAllMips_DelegateParams
		{
			// Token: 0x0401737C RID: 95100
			[FieldOffset(0)]
			public byte SkeletalMeshes;

			// Token: 0x0401737D RID: 95101
			[FieldOffset(16)]
			public byte StaticMeshes;
		}

		// Token: 0x020033C9 RID: 13257
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401737E RID: 95102
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
