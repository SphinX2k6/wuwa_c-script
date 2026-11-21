using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020005FA RID: 1530
	public sealed class FOnStreamedAllStaticMeshCompMips : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060087A9 RID: 34729 RVA: 0x000CBD85 File Offset: 0x000C9F85
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnStreamedAllStaticMeshCompMips.StaticFunctionPtr();
		}

		// Token: 0x060087AA RID: 34730 RVA: 0x000CBD91 File Offset: 0x000C9F91
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnStreamedAllStaticMeshCompMips._FunctionPtr == IntPtr.Zero)
			{
				FOnStreamedAllStaticMeshCompMips._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroUtility.OnStreamedAllStaticMeshCompMips__DelegateSignature");
			}
			return FOnStreamedAllStaticMeshCompMips._FunctionPtr;
		}

		// Token: 0x060087AB RID: 34731 RVA: 0x000CBDB4 File Offset: 0x000C9FB4
		public FOnStreamedAllStaticMeshCompMips()
		{
		}

		// Token: 0x060087AC RID: 34732 RVA: 0x000CBDBC File Offset: 0x000C9FBC
		[NullableContext(2)]
		public FOnStreamedAllStaticMeshCompMips(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060087AD RID: 34733 RVA: 0x000CBDC6 File Offset: 0x000C9FC6
		public FOnStreamedAllStaticMeshCompMips(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060087AE RID: 34734 RVA: 0x000CBDD1 File Offset: 0x000C9FD1
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<UStaticMesh>) ?? ((Action<UStaticMesh>)Delegate.CreateDelegate(typeof(Action<UStaticMesh>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060087AF RID: 34735 RVA: 0x000CBE03 File Offset: 0x000CA003
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

		// Token: 0x060087B0 RID: 34736 RVA: 0x000CBE40 File Offset: 0x000CA040
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Execute(UStaticMesh StaticMesh)
		{
			FOnStreamedAllStaticMeshCompMips.__FOnStreamedAllStaticMeshCompMips_DelegateParams* ptr = stackalloc FOnStreamedAllStaticMeshCompMips.__FOnStreamedAllStaticMeshCompMips_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FOnStreamedAllStaticMeshCompMips.__FOnStreamedAllStaticMeshCompMips_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnStreamedAllStaticMeshCompMips.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->StaticMesh = ((StaticMesh != null) ? StaticMesh.NativePtr : IntPtr.Zero);
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x060087B1 RID: 34737 RVA: 0x000CBE8C File Offset: 0x000CA08C
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x04003AF9 RID: 15097
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003AFA RID: 15098
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroUtility.OnStreamedAllStaticMeshCompMips__DelegateSignature";

		// Token: 0x04003AFB RID: 15099
		private static int RegisterId;

		// Token: 0x02000E12 RID: 3602
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		private ref struct __FOnStreamedAllStaticMeshCompMips_DelegateParams
		{
			// Token: 0x040061A7 RID: 24999
			[FieldOffset(0)]
			public IntPtr StaticMesh;
		}

		// Token: 0x02000E13 RID: 3603
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040061A8 RID: 25000
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
