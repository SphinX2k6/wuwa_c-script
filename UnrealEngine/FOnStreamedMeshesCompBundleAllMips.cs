using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020005FB RID: 1531
	public sealed class FOnStreamedMeshesCompBundleAllMips : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060087B2 RID: 34738 RVA: 0x000CBEDD File Offset: 0x000CA0DD
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnStreamedMeshesCompBundleAllMips.StaticFunctionPtr();
		}

		// Token: 0x060087B3 RID: 34739 RVA: 0x000CBEE9 File Offset: 0x000CA0E9
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnStreamedMeshesCompBundleAllMips._FunctionPtr == IntPtr.Zero)
			{
				FOnStreamedMeshesCompBundleAllMips._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroUtility.OnStreamedMeshesCompBundleAllMips__DelegateSignature");
			}
			return FOnStreamedMeshesCompBundleAllMips._FunctionPtr;
		}

		// Token: 0x060087B4 RID: 34740 RVA: 0x000CBF0C File Offset: 0x000CA10C
		public FOnStreamedMeshesCompBundleAllMips()
		{
		}

		// Token: 0x060087B5 RID: 34741 RVA: 0x000CBF14 File Offset: 0x000CA114
		[NullableContext(2)]
		public FOnStreamedMeshesCompBundleAllMips(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060087B6 RID: 34742 RVA: 0x000CBF1E File Offset: 0x000CA11E
		public FOnStreamedMeshesCompBundleAllMips(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060087B7 RID: 34743 RVA: 0x000CBF29 File Offset: 0x000CA129
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as FOnStreamedMeshesCompBundleAllMips.FOnStreamedMeshesCompBundleAllMips_ScriptDelegate) ?? ((FOnStreamedMeshesCompBundleAllMips.FOnStreamedMeshesCompBundleAllMips_ScriptDelegate)Delegate.CreateDelegate(typeof(FOnStreamedMeshesCompBundleAllMips.FOnStreamedMeshesCompBundleAllMips_ScriptDelegate), Callback.Target, Callback.Method)));
		}

		// Token: 0x060087B8 RID: 34744 RVA: 0x000CBF5B File Offset: 0x000CA15B
		[NullableContext(1)]
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

		// Token: 0x060087B9 RID: 34745 RVA: 0x000CBF98 File Offset: 0x000CA198
		[SkipLocalsInit]
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

		// Token: 0x060087BA RID: 34746 RVA: 0x000CC030 File Offset: 0x000CA230
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x04003AFC RID: 15100
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003AFD RID: 15101
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroUtility.OnStreamedMeshesCompBundleAllMips__DelegateSignature";

		// Token: 0x04003AFE RID: 15102
		private static int RegisterId;

		// Token: 0x02000E14 RID: 3604
		// (Invoke) Token: 0x0600BF1F RID: 48927
		public delegate void FOnStreamedMeshesCompBundleAllMips_ScriptDelegate([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<USkeletalMesh> SkeletalMeshes, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<UStaticMesh> StaticMeshes);

		// Token: 0x02000E15 RID: 3605
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		private ref struct __FOnStreamedMeshesCompBundleAllMips_DelegateParams
		{
			// Token: 0x040061A9 RID: 25001
			[FieldOffset(0)]
			public byte SkeletalMeshes;

			// Token: 0x040061AA RID: 25002
			[FieldOffset(16)]
			public byte StaticMeshes;
		}

		// Token: 0x02000E16 RID: 3606
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040061AB RID: 25003
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
