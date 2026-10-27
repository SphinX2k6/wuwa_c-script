using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001EEC RID: 7916
	public sealed class FOnStreamedAllSkeletalCompMips : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601E155 RID: 123221 RVA: 0x002CAC2C File Offset: 0x002C8E2C
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnStreamedAllSkeletalCompMips.StaticFunctionPtr();
		}

		// Token: 0x0601E156 RID: 123222 RVA: 0x002CAC38 File Offset: 0x002C8E38
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnStreamedAllSkeletalCompMips._FunctionPtr == IntPtr.Zero)
			{
				FOnStreamedAllSkeletalCompMips._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroUtility.OnStreamedAllSkeletalCompMips__DelegateSignature");
			}
			return FOnStreamedAllSkeletalCompMips._FunctionPtr;
		}

		// Token: 0x0601E157 RID: 123223 RVA: 0x002CAC5B File Offset: 0x002C8E5B
		public FOnStreamedAllSkeletalCompMips()
		{
		}

		// Token: 0x0601E158 RID: 123224 RVA: 0x002CAC63 File Offset: 0x002C8E63
		[NullableContext(2)]
		public FOnStreamedAllSkeletalCompMips(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601E159 RID: 123225 RVA: 0x002CAC6D File Offset: 0x002C8E6D
		public FOnStreamedAllSkeletalCompMips(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601E15A RID: 123226 RVA: 0x002CAC78 File Offset: 0x002C8E78
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<USkeletalMesh>) ?? ((Action<USkeletalMesh>)Delegate.CreateDelegate(typeof(Action<USkeletalMesh>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601E15B RID: 123227 RVA: 0x002CACAA File Offset: 0x002C8EAA
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0601E15C RID: 123228 RVA: 0x002CACE4 File Offset: 0x002C8EE4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(USkeletalMesh SkeletalMesh)
		{
			FOnStreamedAllSkeletalCompMips.__FOnStreamedAllSkeletalCompMips_DelegateParams* ptr = stackalloc FOnStreamedAllSkeletalCompMips.__FOnStreamedAllSkeletalCompMips_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FOnStreamedAllSkeletalCompMips.__FOnStreamedAllSkeletalCompMips_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnStreamedAllSkeletalCompMips.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->SkeletalMesh = ((SkeletalMesh != null) ? SkeletalMesh.NativePtr : IntPtr.Zero);
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0601E15D RID: 123229 RVA: 0x002CAD30 File Offset: 0x002C8F30
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x0401041E RID: 66590
		internal static IntPtr _FunctionPtr;

		// Token: 0x0401041F RID: 66591
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroUtility.OnStreamedAllSkeletalCompMips__DelegateSignature";

		// Token: 0x04010420 RID: 66592
		private static int RegisterId;

		// Token: 0x020033C3 RID: 13251
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __FOnStreamedAllSkeletalCompMips_DelegateParams
		{
			// Token: 0x04017378 RID: 95096
			[FieldOffset(0)]
			public IntPtr SkeletalMesh;
		}

		// Token: 0x020033C4 RID: 13252
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017379 RID: 95097
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
