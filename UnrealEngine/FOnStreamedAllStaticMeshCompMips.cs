using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001EED RID: 7917
	public sealed class FOnStreamedAllStaticMeshCompMips : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601E15E RID: 123230 RVA: 0x002CAD81 File Offset: 0x002C8F81
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnStreamedAllStaticMeshCompMips.StaticFunctionPtr();
		}

		// Token: 0x0601E15F RID: 123231 RVA: 0x002CAD8D File Offset: 0x002C8F8D
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnStreamedAllStaticMeshCompMips._FunctionPtr == IntPtr.Zero)
			{
				FOnStreamedAllStaticMeshCompMips._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroUtility.OnStreamedAllStaticMeshCompMips__DelegateSignature");
			}
			return FOnStreamedAllStaticMeshCompMips._FunctionPtr;
		}

		// Token: 0x0601E160 RID: 123232 RVA: 0x002CADB0 File Offset: 0x002C8FB0
		public FOnStreamedAllStaticMeshCompMips()
		{
		}

		// Token: 0x0601E161 RID: 123233 RVA: 0x002CADB8 File Offset: 0x002C8FB8
		[NullableContext(2)]
		public FOnStreamedAllStaticMeshCompMips(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601E162 RID: 123234 RVA: 0x002CADC2 File Offset: 0x002C8FC2
		public FOnStreamedAllStaticMeshCompMips(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601E163 RID: 123235 RVA: 0x002CADCD File Offset: 0x002C8FCD
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<UStaticMesh>) ?? ((Action<UStaticMesh>)Delegate.CreateDelegate(typeof(Action<UStaticMesh>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601E164 RID: 123236 RVA: 0x002CADFF File Offset: 0x002C8FFF
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind([Nullable(new byte[]
		{
			1,
			2
		})] Action<UStaticMesh> Callback)
		{
			if (FOnStreamedAllStaticMeshCompMips.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnStreamedAllStaticMeshCompMips.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnStreamedAllStaticMeshCompMips.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnStreamedAllStaticMeshCompMips.OnScriptCallback));
				}
				FOnStreamedAllStaticMeshCompMips.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FOnStreamedAllStaticMeshCompMips.RegisterId);
		}

		// Token: 0x0601E165 RID: 123237 RVA: 0x002CAE3C File Offset: 0x002C903C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(UStaticMesh StaticMesh)
		{
			FOnStreamedAllStaticMeshCompMips.__FOnStreamedAllStaticMeshCompMips_DelegateParams* ptr = stackalloc FOnStreamedAllStaticMeshCompMips.__FOnStreamedAllStaticMeshCompMips_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FOnStreamedAllStaticMeshCompMips.__FOnStreamedAllStaticMeshCompMips_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnStreamedAllStaticMeshCompMips.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->StaticMesh = ((StaticMesh != null) ? StaticMesh.NativePtr : IntPtr.Zero);
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0601E166 RID: 123238 RVA: 0x002CAE88 File Offset: 0x002C9088
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<UStaticMesh> action = target as Action<UStaticMesh>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			UStaticMesh orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UStaticMesh>(((FOnStreamedAllStaticMeshCompMips.__FOnStreamedAllStaticMeshCompMips_DelegateParams*)__Parameters)->StaticMesh);
			action(orCreateUObjectByNativePointer);
		}

		// Token: 0x04010421 RID: 66593
		internal static IntPtr _FunctionPtr;

		// Token: 0x04010422 RID: 66594
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroUtility.OnStreamedAllStaticMeshCompMips__DelegateSignature";

		// Token: 0x04010423 RID: 66595
		private static int RegisterId;

		// Token: 0x020033C5 RID: 13253
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __FOnStreamedAllStaticMeshCompMips_DelegateParams
		{
			// Token: 0x0401737A RID: 95098
			[FieldOffset(0)]
			public IntPtr StaticMesh;
		}

		// Token: 0x020033C6 RID: 13254
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401737B RID: 95099
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
