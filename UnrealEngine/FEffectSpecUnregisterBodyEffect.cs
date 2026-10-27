using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020018AF RID: 6319
	public sealed class FEffectSpecUnregisterBodyEffect : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06017626 RID: 95782 RVA: 0x00222ECF File Offset: 0x002210CF
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FEffectSpecUnregisterBodyEffect.StaticFunctionPtr();
		}

		// Token: 0x06017627 RID: 95783 RVA: 0x00222EDB File Offset: 0x002210DB
		private static IntPtr StaticFunctionPtr()
		{
			if (FEffectSpecUnregisterBodyEffect._FunctionPtr == IntPtr.Zero)
			{
				FEffectSpecUnregisterBodyEffect._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroGameplay.EffectSpecUnregisterBodyEffect__DelegateSignature");
			}
			return FEffectSpecUnregisterBodyEffect._FunctionPtr;
		}

		// Token: 0x06017628 RID: 95784 RVA: 0x00222EFE File Offset: 0x002210FE
		public FEffectSpecUnregisterBodyEffect()
		{
		}

		// Token: 0x06017629 RID: 95785 RVA: 0x00222F06 File Offset: 0x00221106
		[NullableContext(2)]
		public FEffectSpecUnregisterBodyEffect(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601762A RID: 95786 RVA: 0x00222F10 File Offset: 0x00221110
		public FEffectSpecUnregisterBodyEffect(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601762B RID: 95787 RVA: 0x00222F1B File Offset: 0x0022111B
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<int, AActor, USkeletalMeshComponent, UObject, UEffectModelBase>) ?? ((Action<int, AActor, USkeletalMeshComponent, UObject, UEffectModelBase>)Delegate.CreateDelegate(typeof(Action<int, AActor, USkeletalMeshComponent, UObject, UEffectModelBase>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601762C RID: 95788 RVA: 0x00222F4D File Offset: 0x0022114D
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind([Nullable(new byte[]
		{
			1,
			2,
			2,
			2,
			2
		})] Action<int, AActor, USkeletalMeshComponent, UObject, UEffectModelBase> Callback)
		{
			if (FEffectSpecUnregisterBodyEffect.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FEffectSpecUnregisterBodyEffect.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FEffectSpecUnregisterBodyEffect.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FEffectSpecUnregisterBodyEffect.OnScriptCallback));
				}
				FEffectSpecUnregisterBodyEffect.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FEffectSpecUnregisterBodyEffect.RegisterId);
		}

		// Token: 0x0601762D RID: 95789 RVA: 0x00222F88 File Offset: 0x00221188
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(int EffectId, AActor EffectActor, USkeletalMeshComponent ContextMeshComponent, UObject ContextSourceObject, UEffectModelBase EffectModel)
		{
			FEffectSpecUnregisterBodyEffect.__FEffectSpecUnregisterBodyEffect_DelegateParams* ptr = stackalloc FEffectSpecUnregisterBodyEffect.__FEffectSpecUnregisterBodyEffect_DelegateParams[(UIntPtr)55] + 15L / (long)sizeof(FEffectSpecUnregisterBodyEffect.__FEffectSpecUnregisterBodyEffect_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FEffectSpecUnregisterBodyEffect.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->EffectId = EffectId;
			ptr->EffectActor = ((EffectActor != null) ? EffectActor.NativePtr : IntPtr.Zero);
			ptr->ContextMeshComponent = ((ContextMeshComponent != null) ? ContextMeshComponent.NativePtr : IntPtr.Zero);
			ptr->ContextSourceObject = ((ContextSourceObject != null) ? ContextSourceObject.NativePtr : IntPtr.Zero);
			ptr->EffectModel = ((EffectModel != null) ? EffectModel.NativePtr : IntPtr.Zero);
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0601762E RID: 95790 RVA: 0x00223024 File Offset: 0x00221224
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int, AActor, USkeletalMeshComponent, UObject, UEffectModelBase> action = target as Action<int, AActor, USkeletalMeshComponent, UObject, UEffectModelBase>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			AActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(((FEffectSpecUnregisterBodyEffect.__FEffectSpecUnregisterBodyEffect_DelegateParams*)__Parameters)->EffectActor);
			USkeletalMeshComponent orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(((FEffectSpecUnregisterBodyEffect.__FEffectSpecUnregisterBodyEffect_DelegateParams*)__Parameters)->ContextMeshComponent);
			UObject orCreateUObjectByNativePointer3 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(((FEffectSpecUnregisterBodyEffect.__FEffectSpecUnregisterBodyEffect_DelegateParams*)__Parameters)->ContextSourceObject);
			UEffectModelBase orCreateUObjectByNativePointer4 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UEffectModelBase>(((FEffectSpecUnregisterBodyEffect.__FEffectSpecUnregisterBodyEffect_DelegateParams*)__Parameters)->EffectModel);
			action(((FEffectSpecUnregisterBodyEffect.__FEffectSpecUnregisterBodyEffect_DelegateParams*)__Parameters)->EffectId, orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, orCreateUObjectByNativePointer3, orCreateUObjectByNativePointer4);
		}

		// Token: 0x0400CB73 RID: 52083
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400CB74 RID: 52084
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameplay.EffectSpecUnregisterBodyEffect__DelegateSignature";

		// Token: 0x0400CB75 RID: 52085
		private static int RegisterId;

		// Token: 0x02002FA5 RID: 12197
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __FEffectSpecUnregisterBodyEffect_DelegateParams
		{
			// Token: 0x04016B81 RID: 93057
			[FieldOffset(0)]
			public int EffectId;

			// Token: 0x04016B82 RID: 93058
			[FieldOffset(8)]
			public IntPtr EffectActor;

			// Token: 0x04016B83 RID: 93059
			[FieldOffset(16)]
			public IntPtr ContextMeshComponent;

			// Token: 0x04016B84 RID: 93060
			[FieldOffset(24)]
			public IntPtr ContextSourceObject;

			// Token: 0x04016B85 RID: 93061
			[FieldOffset(32)]
			public IntPtr EffectModel;
		}

		// Token: 0x02002FA6 RID: 12198
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016B86 RID: 93062
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
