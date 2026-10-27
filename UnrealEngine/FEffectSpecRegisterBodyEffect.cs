using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020018AE RID: 6318
	public sealed class FEffectSpecRegisterBodyEffect : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601761D RID: 95773 RVA: 0x00222CF8 File Offset: 0x00220EF8
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FEffectSpecRegisterBodyEffect.StaticFunctionPtr();
		}

		// Token: 0x0601761E RID: 95774 RVA: 0x00222D04 File Offset: 0x00220F04
		private static IntPtr StaticFunctionPtr()
		{
			if (FEffectSpecRegisterBodyEffect._FunctionPtr == IntPtr.Zero)
			{
				FEffectSpecRegisterBodyEffect._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroGameplay.EffectSpecRegisterBodyEffect__DelegateSignature");
			}
			return FEffectSpecRegisterBodyEffect._FunctionPtr;
		}

		// Token: 0x0601761F RID: 95775 RVA: 0x00222D27 File Offset: 0x00220F27
		public FEffectSpecRegisterBodyEffect()
		{
		}

		// Token: 0x06017620 RID: 95776 RVA: 0x00222D2F File Offset: 0x00220F2F
		[NullableContext(2)]
		public FEffectSpecRegisterBodyEffect(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06017621 RID: 95777 RVA: 0x00222D39 File Offset: 0x00220F39
		public FEffectSpecRegisterBodyEffect(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06017622 RID: 95778 RVA: 0x00222D44 File Offset: 0x00220F44
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<int, AActor, USkeletalMeshComponent, UObject, UEffectModelBase>) ?? ((Action<int, AActor, USkeletalMeshComponent, UObject, UEffectModelBase>)Delegate.CreateDelegate(typeof(Action<int, AActor, USkeletalMeshComponent, UObject, UEffectModelBase>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06017623 RID: 95779 RVA: 0x00222D76 File Offset: 0x00220F76
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
			if (FEffectSpecRegisterBodyEffect.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FEffectSpecRegisterBodyEffect.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FEffectSpecRegisterBodyEffect.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FEffectSpecRegisterBodyEffect.OnScriptCallback));
				}
				FEffectSpecRegisterBodyEffect.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FEffectSpecRegisterBodyEffect.RegisterId);
		}

		// Token: 0x06017624 RID: 95780 RVA: 0x00222DB0 File Offset: 0x00220FB0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(int EffectId, AActor EffectActor, USkeletalMeshComponent ContextMeshComponent, UObject ContextSourceObject, UEffectModelBase EffectModel)
		{
			FEffectSpecRegisterBodyEffect.__FEffectSpecRegisterBodyEffect_DelegateParams* ptr = stackalloc FEffectSpecRegisterBodyEffect.__FEffectSpecRegisterBodyEffect_DelegateParams[(UIntPtr)55] + 15L / (long)sizeof(FEffectSpecRegisterBodyEffect.__FEffectSpecRegisterBodyEffect_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FEffectSpecRegisterBodyEffect.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->EffectId = EffectId;
			ptr->EffectActor = ((EffectActor != null) ? EffectActor.NativePtr : IntPtr.Zero);
			ptr->ContextMeshComponent = ((ContextMeshComponent != null) ? ContextMeshComponent.NativePtr : IntPtr.Zero);
			ptr->ContextSourceObject = ((ContextSourceObject != null) ? ContextSourceObject.NativePtr : IntPtr.Zero);
			ptr->EffectModel = ((EffectModel != null) ? EffectModel.NativePtr : IntPtr.Zero);
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x06017625 RID: 95781 RVA: 0x00222E4C File Offset: 0x0022104C
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
			AActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(((FEffectSpecRegisterBodyEffect.__FEffectSpecRegisterBodyEffect_DelegateParams*)__Parameters)->EffectActor);
			USkeletalMeshComponent orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(((FEffectSpecRegisterBodyEffect.__FEffectSpecRegisterBodyEffect_DelegateParams*)__Parameters)->ContextMeshComponent);
			UObject orCreateUObjectByNativePointer3 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(((FEffectSpecRegisterBodyEffect.__FEffectSpecRegisterBodyEffect_DelegateParams*)__Parameters)->ContextSourceObject);
			UEffectModelBase orCreateUObjectByNativePointer4 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UEffectModelBase>(((FEffectSpecRegisterBodyEffect.__FEffectSpecRegisterBodyEffect_DelegateParams*)__Parameters)->EffectModel);
			action(((FEffectSpecRegisterBodyEffect.__FEffectSpecRegisterBodyEffect_DelegateParams*)__Parameters)->EffectId, orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, orCreateUObjectByNativePointer3, orCreateUObjectByNativePointer4);
		}

		// Token: 0x0400CB70 RID: 52080
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400CB71 RID: 52081
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameplay.EffectSpecRegisterBodyEffect__DelegateSignature";

		// Token: 0x0400CB72 RID: 52082
		private static int RegisterId;

		// Token: 0x02002FA3 RID: 12195
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __FEffectSpecRegisterBodyEffect_DelegateParams
		{
			// Token: 0x04016B7B RID: 93051
			[FieldOffset(0)]
			public int EffectId;

			// Token: 0x04016B7C RID: 93052
			[FieldOffset(8)]
			public IntPtr EffectActor;

			// Token: 0x04016B7D RID: 93053
			[FieldOffset(16)]
			public IntPtr ContextMeshComponent;

			// Token: 0x04016B7E RID: 93054
			[FieldOffset(24)]
			public IntPtr ContextSourceObject;

			// Token: 0x04016B7F RID: 93055
			[FieldOffset(32)]
			public IntPtr EffectModel;
		}

		// Token: 0x02002FA4 RID: 12196
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016B80 RID: 93056
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
