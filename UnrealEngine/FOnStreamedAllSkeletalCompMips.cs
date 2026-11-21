using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020005F9 RID: 1529
	public sealed class FOnStreamedAllSkeletalCompMips : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060087A0 RID: 34720 RVA: 0x000CBC30 File Offset: 0x000C9E30
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnStreamedAllSkeletalCompMips.StaticFunctionPtr();
		}

		// Token: 0x060087A1 RID: 34721 RVA: 0x000CBC3C File Offset: 0x000C9E3C
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnStreamedAllSkeletalCompMips._FunctionPtr == IntPtr.Zero)
			{
				FOnStreamedAllSkeletalCompMips._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroUtility.OnStreamedAllSkeletalCompMips__DelegateSignature");
			}
			return FOnStreamedAllSkeletalCompMips._FunctionPtr;
		}

		// Token: 0x060087A2 RID: 34722 RVA: 0x000CBC5F File Offset: 0x000C9E5F
		public FOnStreamedAllSkeletalCompMips()
		{
		}

		// Token: 0x060087A3 RID: 34723 RVA: 0x000CBC67 File Offset: 0x000C9E67
		[NullableContext(2)]
		public FOnStreamedAllSkeletalCompMips(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060087A4 RID: 34724 RVA: 0x000CBC71 File Offset: 0x000C9E71
		public FOnStreamedAllSkeletalCompMips(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060087A5 RID: 34725 RVA: 0x000CBC7C File Offset: 0x000C9E7C
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<USkeletalMesh>) ?? ((Action<USkeletalMesh>)Delegate.CreateDelegate(typeof(Action<USkeletalMesh>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060087A6 RID: 34726 RVA: 0x000CBCAE File Offset: 0x000C9EAE
		public void Bind([Nullable(new byte[]
		{
			1,
			2
		})] Action<USkeletalMesh> Callback)
		{
			if (FOnStreamedAllSkeletalCompMips.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnStreamedAllSkeletalCompMips.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnStreamedAllSkeletalCompMips.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnStreamedAllSkeletalCompMips.OnScriptCallback));
				}
				FOnStreamedAllSkeletalCompMips.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FOnStreamedAllSkeletalCompMips.RegisterId);
		}

		// Token: 0x060087A7 RID: 34727 RVA: 0x000CBCE8 File Offset: 0x000C9EE8
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Execute(USkeletalMesh SkeletalMesh)
		{
			FOnStreamedAllSkeletalCompMips.__FOnStreamedAllSkeletalCompMips_DelegateParams* ptr = stackalloc FOnStreamedAllSkeletalCompMips.__FOnStreamedAllSkeletalCompMips_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FOnStreamedAllSkeletalCompMips.__FOnStreamedAllSkeletalCompMips_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnStreamedAllSkeletalCompMips.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->SkeletalMesh = ((SkeletalMesh != null) ? SkeletalMesh.NativePtr : IntPtr.Zero);
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x060087A8 RID: 34728 RVA: 0x000CBD34 File Offset: 0x000C9F34
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<USkeletalMesh> action = target as Action<USkeletalMesh>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			USkeletalMesh orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMesh>(((FOnStreamedAllSkeletalCompMips.__FOnStreamedAllSkeletalCompMips_DelegateParams*)__Parameters)->SkeletalMesh);
			action(orCreateUObjectByNativePointer);
		}

		// Token: 0x04003AF6 RID: 15094
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003AF7 RID: 15095
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroUtility.OnStreamedAllSkeletalCompMips__DelegateSignature";

		// Token: 0x04003AF8 RID: 15096
		private static int RegisterId;

		// Token: 0x02000E10 RID: 3600
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		private ref struct __FOnStreamedAllSkeletalCompMips_DelegateParams
		{
			// Token: 0x040061A5 RID: 24997
			[FieldOffset(0)]
			public IntPtr SkeletalMesh;
		}

		// Token: 0x02000E11 RID: 3601
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040061A6 RID: 24998
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
