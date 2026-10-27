using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001923 RID: 6435
	public sealed class FMaterialSpecSpawnRenderActorRetVal : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06017DE4 RID: 97764 RVA: 0x0022F877 File Offset: 0x0022DA77
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FMaterialSpecSpawnRenderActorRetVal.StaticFunctionPtr();
		}

		// Token: 0x06017DE5 RID: 97765 RVA: 0x0022F883 File Offset: 0x0022DA83
		private static IntPtr StaticFunctionPtr()
		{
			if (FMaterialSpecSpawnRenderActorRetVal._FunctionPtr == IntPtr.Zero)
			{
				FMaterialSpecSpawnRenderActorRetVal._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroGameplay.MaterialSpecSpawnRenderActorRetVal__DelegateSignature");
			}
			return FMaterialSpecSpawnRenderActorRetVal._FunctionPtr;
		}

		// Token: 0x06017DE6 RID: 97766 RVA: 0x0022F8A6 File Offset: 0x0022DAA6
		public FMaterialSpecSpawnRenderActorRetVal()
		{
		}

		// Token: 0x06017DE7 RID: 97767 RVA: 0x0022F8AE File Offset: 0x0022DAAE
		[NullableContext(2)]
		public FMaterialSpecSpawnRenderActorRetVal(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06017DE8 RID: 97768 RVA: 0x0022F8B8 File Offset: 0x0022DAB8
		public FMaterialSpecSpawnRenderActorRetVal(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06017DE9 RID: 97769 RVA: 0x0022F8C3 File Offset: 0x0022DAC3
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Func<USkeletalMeshComponent, AActor>) ?? ((Func<USkeletalMeshComponent, AActor>)Delegate.CreateDelegate(typeof(Func<USkeletalMeshComponent, AActor>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06017DEA RID: 97770 RVA: 0x0022F8F5 File Offset: 0x0022DAF5
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind([Nullable(new byte[]
		{
			1,
			2,
			2
		})] Func<USkeletalMeshComponent, AActor> Callback)
		{
			if (FMaterialSpecSpawnRenderActorRetVal.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FMaterialSpecSpawnRenderActorRetVal.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FMaterialSpecSpawnRenderActorRetVal.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FMaterialSpecSpawnRenderActorRetVal.OnScriptCallback));
				}
				FMaterialSpecSpawnRenderActorRetVal.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FMaterialSpecSpawnRenderActorRetVal.RegisterId);
		}

		// Token: 0x06017DEB RID: 97771 RVA: 0x0022F930 File Offset: 0x0022DB30
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe AActor Execute(USkeletalMeshComponent SkeletalMeshComponent)
		{
			FMaterialSpecSpawnRenderActorRetVal.__FMaterialSpecSpawnRenderActorRetVal_DelegateParams* ptr = stackalloc FMaterialSpecSpawnRenderActorRetVal.__FMaterialSpecSpawnRenderActorRetVal_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FMaterialSpecSpawnRenderActorRetVal.__FMaterialSpecSpawnRenderActorRetVal_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FMaterialSpecSpawnRenderActorRetVal.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->SkeletalMeshComponent = ((SkeletalMeshComponent != null) ? SkeletalMeshComponent.NativePtr : IntPtr.Zero);
			base.ExecuteInternal((void*)ptr);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(ptr->__Result);
		}

		// Token: 0x06017DEC RID: 97772 RVA: 0x0022F988 File Offset: 0x0022DB88
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Func<USkeletalMeshComponent, AActor> func = target as Func<USkeletalMeshComponent, AActor>;
			if (func == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(((FMaterialSpecSpawnRenderActorRetVal.__FMaterialSpecSpawnRenderActorRetVal_DelegateParams*)__Parameters)->SkeletalMeshComponent);
			AActor aactor = func(orCreateUObjectByNativePointer);
			((FMaterialSpecSpawnRenderActorRetVal.__FMaterialSpecSpawnRenderActorRetVal_DelegateParams*)__Parameters)->__Result = ((aactor != null) ? aactor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0400CEDA RID: 52954
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400CEDB RID: 52955
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameplay.MaterialSpecSpawnRenderActorRetVal__DelegateSignature";

		// Token: 0x0400CEDC RID: 52956
		private static int RegisterId;

		// Token: 0x02002FEF RID: 12271
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FMaterialSpecSpawnRenderActorRetVal_DelegateParams
		{
			// Token: 0x04016BF1 RID: 93169
			[FieldOffset(0)]
			public IntPtr SkeletalMeshComponent;

			// Token: 0x04016BF2 RID: 93170
			[FieldOffset(8)]
			public IntPtr __Result;
		}

		// Token: 0x02002FF0 RID: 12272
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016BF3 RID: 93171
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
