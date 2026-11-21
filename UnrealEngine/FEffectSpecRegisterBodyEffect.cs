using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020003D0 RID: 976
	public sealed class FEffectSpecRegisterBodyEffect : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060060B0 RID: 24752 RVA: 0x00089ED8 File Offset: 0x000880D8
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FEffectSpecRegisterBodyEffect.StaticFunctionPtr();
		}

		// Token: 0x060060B1 RID: 24753 RVA: 0x00089EE4 File Offset: 0x000880E4
		private static IntPtr StaticFunctionPtr()
		{
			if (FEffectSpecRegisterBodyEffect._FunctionPtr == IntPtr.Zero)
			{
				FEffectSpecRegisterBodyEffect._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroGameplay.EffectSpecRegisterBodyEffect__DelegateSignature");
			}
			return FEffectSpecRegisterBodyEffect._FunctionPtr;
		}

		// Token: 0x060060B2 RID: 24754 RVA: 0x00089F07 File Offset: 0x00088107
		public FEffectSpecRegisterBodyEffect()
		{
		}

		// Token: 0x060060B3 RID: 24755 RVA: 0x00089F0F File Offset: 0x0008810F
		[NullableContext(2)]
		public FEffectSpecRegisterBodyEffect(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060060B4 RID: 24756 RVA: 0x00089F19 File Offset: 0x00088119
		public FEffectSpecRegisterBodyEffect(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060060B5 RID: 24757 RVA: 0x00089F24 File Offset: 0x00088124
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<int, AActor, USkeletalMeshComponent, UObject, UEffectModelBase>) ?? ((Action<int, AActor, USkeletalMeshComponent, UObject, UEffectModelBase>)Delegate.CreateDelegate(typeof(Action<int, AActor, USkeletalMeshComponent, UObject, UEffectModelBase>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060060B6 RID: 24758 RVA: 0x00089F56 File Offset: 0x00088156
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

		// Token: 0x060060B7 RID: 24759 RVA: 0x00089F90 File Offset: 0x00088190
		[NullableContext(2)]
		[SkipLocalsInit]
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

		// Token: 0x060060B8 RID: 24760 RVA: 0x0008A02C File Offset: 0x0008822C
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x0400292F RID: 10543
		internal static IntPtr _FunctionPtr;

		// Token: 0x04002930 RID: 10544
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameplay.EffectSpecRegisterBodyEffect__DelegateSignature";

		// Token: 0x04002931 RID: 10545
		private static int RegisterId;

		// Token: 0x02000AC6 RID: 2758
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		private ref struct __FEffectSpecRegisterBodyEffect_DelegateParams
		{
			// Token: 0x04005B38 RID: 23352
			[FieldOffset(0)]
			public int EffectId;

			// Token: 0x04005B39 RID: 23353
			[FieldOffset(8)]
			public IntPtr EffectActor;

			// Token: 0x04005B3A RID: 23354
			[FieldOffset(16)]
			public IntPtr ContextMeshComponent;

			// Token: 0x04005B3B RID: 23355
			[FieldOffset(24)]
			public IntPtr ContextSourceObject;

			// Token: 0x04005B3C RID: 23356
			[FieldOffset(32)]
			public IntPtr EffectModel;
		}

		// Token: 0x02000AC7 RID: 2759
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005B3D RID: 23357
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
