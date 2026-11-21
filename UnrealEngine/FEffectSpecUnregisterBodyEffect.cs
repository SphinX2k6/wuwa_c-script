using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020003D1 RID: 977
	public sealed class FEffectSpecUnregisterBodyEffect : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060060B9 RID: 24761 RVA: 0x0008A0AF File Offset: 0x000882AF
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FEffectSpecUnregisterBodyEffect.StaticFunctionPtr();
		}

		// Token: 0x060060BA RID: 24762 RVA: 0x0008A0BB File Offset: 0x000882BB
		private static IntPtr StaticFunctionPtr()
		{
			if (FEffectSpecUnregisterBodyEffect._FunctionPtr == IntPtr.Zero)
			{
				FEffectSpecUnregisterBodyEffect._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroGameplay.EffectSpecUnregisterBodyEffect__DelegateSignature");
			}
			return FEffectSpecUnregisterBodyEffect._FunctionPtr;
		}

		// Token: 0x060060BB RID: 24763 RVA: 0x0008A0DE File Offset: 0x000882DE
		public FEffectSpecUnregisterBodyEffect()
		{
		}

		// Token: 0x060060BC RID: 24764 RVA: 0x0008A0E6 File Offset: 0x000882E6
		[NullableContext(2)]
		public FEffectSpecUnregisterBodyEffect(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060060BD RID: 24765 RVA: 0x0008A0F0 File Offset: 0x000882F0
		public FEffectSpecUnregisterBodyEffect(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060060BE RID: 24766 RVA: 0x0008A0FB File Offset: 0x000882FB
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<int, AActor, USkeletalMeshComponent, UObject, UEffectModelBase>) ?? ((Action<int, AActor, USkeletalMeshComponent, UObject, UEffectModelBase>)Delegate.CreateDelegate(typeof(Action<int, AActor, USkeletalMeshComponent, UObject, UEffectModelBase>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060060BF RID: 24767 RVA: 0x0008A12D File Offset: 0x0008832D
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

		// Token: 0x060060C0 RID: 24768 RVA: 0x0008A168 File Offset: 0x00088368
		[NullableContext(2)]
		[SkipLocalsInit]
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

		// Token: 0x060060C1 RID: 24769 RVA: 0x0008A204 File Offset: 0x00088404
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x04002932 RID: 10546
		internal static IntPtr _FunctionPtr;

		// Token: 0x04002933 RID: 10547
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameplay.EffectSpecUnregisterBodyEffect__DelegateSignature";

		// Token: 0x04002934 RID: 10548
		private static int RegisterId;

		// Token: 0x02000AC8 RID: 2760
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		private ref struct __FEffectSpecUnregisterBodyEffect_DelegateParams
		{
			// Token: 0x04005B3E RID: 23358
			[FieldOffset(0)]
			public int EffectId;

			// Token: 0x04005B3F RID: 23359
			[FieldOffset(8)]
			public IntPtr EffectActor;

			// Token: 0x04005B40 RID: 23360
			[FieldOffset(16)]
			public IntPtr ContextMeshComponent;

			// Token: 0x04005B41 RID: 23361
			[FieldOffset(24)]
			public IntPtr ContextSourceObject;

			// Token: 0x04005B42 RID: 23362
			[FieldOffset(32)]
			public IntPtr EffectModel;
		}

		// Token: 0x02000AC9 RID: 2761
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005B43 RID: 23363
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
