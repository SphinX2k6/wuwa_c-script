using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200193C RID: 6460
	public sealed class FSkeletalMeshSpecOnBodyEffectChangeRetVal : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06017F35 RID: 98101 RVA: 0x002318C3 File Offset: 0x0022FAC3
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FSkeletalMeshSpecOnBodyEffectChangeRetVal.StaticFunctionPtr();
		}

		// Token: 0x06017F36 RID: 98102 RVA: 0x002318CF File Offset: 0x0022FACF
		private static IntPtr StaticFunctionPtr()
		{
			if (FSkeletalMeshSpecOnBodyEffectChangeRetVal._FunctionPtr == IntPtr.Zero)
			{
				FSkeletalMeshSpecOnBodyEffectChangeRetVal._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroGameplay.SkeletalMeshSpecOnBodyEffectChangeRetVal__DelegateSignature");
			}
			return FSkeletalMeshSpecOnBodyEffectChangeRetVal._FunctionPtr;
		}

		// Token: 0x06017F37 RID: 98103 RVA: 0x002318F2 File Offset: 0x0022FAF2
		public FSkeletalMeshSpecOnBodyEffectChangeRetVal()
		{
		}

		// Token: 0x06017F38 RID: 98104 RVA: 0x002318FA File Offset: 0x0022FAFA
		[NullableContext(2)]
		public FSkeletalMeshSpecOnBodyEffectChangeRetVal(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06017F39 RID: 98105 RVA: 0x00231904 File Offset: 0x0022FB04
		public FSkeletalMeshSpecOnBodyEffectChangeRetVal(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06017F3A RID: 98106 RVA: 0x0023190F File Offset: 0x0022FB0F
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Func<float, UActorComponent, USkeletalMeshComponent, AActor, UActorComponent>) ?? ((Func<float, UActorComponent, USkeletalMeshComponent, AActor, UActorComponent>)Delegate.CreateDelegate(typeof(Func<float, UActorComponent, USkeletalMeshComponent, AActor, UActorComponent>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06017F3B RID: 98107 RVA: 0x00231941 File Offset: 0x0022FB41
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind([Nullable(new byte[]
		{
			1,
			2,
			2,
			2,
			2
		})] Func<float, UActorComponent, USkeletalMeshComponent, AActor, UActorComponent> Callback)
		{
			if (FSkeletalMeshSpecOnBodyEffectChangeRetVal.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FSkeletalMeshSpecOnBodyEffectChangeRetVal.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FSkeletalMeshSpecOnBodyEffectChangeRetVal.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FSkeletalMeshSpecOnBodyEffectChangeRetVal.OnScriptCallback));
				}
				FSkeletalMeshSpecOnBodyEffectChangeRetVal.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FSkeletalMeshSpecOnBodyEffectChangeRetVal.RegisterId);
		}

		// Token: 0x06017F3C RID: 98108 RVA: 0x0023197C File Offset: 0x0022FB7C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe UActorComponent Execute(float Opacity, UActorComponent CharRenderingComponent, USkeletalMeshComponent SkeletalMeshComponent, AActor Owner)
		{
			FSkeletalMeshSpecOnBodyEffectChangeRetVal.__FSkeletalMeshSpecOnBodyEffectChangeRetVal_DelegateParams* ptr = stackalloc FSkeletalMeshSpecOnBodyEffectChangeRetVal.__FSkeletalMeshSpecOnBodyEffectChangeRetVal_DelegateParams[(UIntPtr)55] + 15L / (long)sizeof(FSkeletalMeshSpecOnBodyEffectChangeRetVal.__FSkeletalMeshSpecOnBodyEffectChangeRetVal_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FSkeletalMeshSpecOnBodyEffectChangeRetVal.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Opacity = Opacity;
			ptr->CharRenderingComponent = ((CharRenderingComponent != null) ? CharRenderingComponent.NativePtr : IntPtr.Zero);
			ptr->SkeletalMeshComponent = ((SkeletalMeshComponent != null) ? SkeletalMeshComponent.NativePtr : IntPtr.Zero);
			ptr->Owner = ((Owner != null) ? Owner.NativePtr : IntPtr.Zero);
			base.ExecuteInternal((void*)ptr);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UActorComponent>(ptr->__Result);
		}

		// Token: 0x06017F3D RID: 98109 RVA: 0x00231A08 File Offset: 0x0022FC08
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Func<float, UActorComponent, USkeletalMeshComponent, AActor, UActorComponent> func = target as Func<float, UActorComponent, USkeletalMeshComponent, AActor, UActorComponent>;
			if (func == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			UActorComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UActorComponent>(((FSkeletalMeshSpecOnBodyEffectChangeRetVal.__FSkeletalMeshSpecOnBodyEffectChangeRetVal_DelegateParams*)__Parameters)->CharRenderingComponent);
			USkeletalMeshComponent orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(((FSkeletalMeshSpecOnBodyEffectChangeRetVal.__FSkeletalMeshSpecOnBodyEffectChangeRetVal_DelegateParams*)__Parameters)->SkeletalMeshComponent);
			AActor orCreateUObjectByNativePointer3 = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(((FSkeletalMeshSpecOnBodyEffectChangeRetVal.__FSkeletalMeshSpecOnBodyEffectChangeRetVal_DelegateParams*)__Parameters)->Owner);
			UActorComponent uactorComponent = func(((FSkeletalMeshSpecOnBodyEffectChangeRetVal.__FSkeletalMeshSpecOnBodyEffectChangeRetVal_DelegateParams*)__Parameters)->Opacity, orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, orCreateUObjectByNativePointer3);
			((FSkeletalMeshSpecOnBodyEffectChangeRetVal.__FSkeletalMeshSpecOnBodyEffectChangeRetVal_DelegateParams*)__Parameters)->__Result = ((uactorComponent != null) ? uactorComponent.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0400CF5D RID: 53085
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400CF5E RID: 53086
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameplay.SkeletalMeshSpecOnBodyEffectChangeRetVal__DelegateSignature";

		// Token: 0x0400CF5F RID: 53087
		private static int RegisterId;

		// Token: 0x02003001 RID: 12289
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __FSkeletalMeshSpecOnBodyEffectChangeRetVal_DelegateParams
		{
			// Token: 0x04016C12 RID: 93202
			[FieldOffset(0)]
			public float Opacity;

			// Token: 0x04016C13 RID: 93203
			[FieldOffset(8)]
			public IntPtr CharRenderingComponent;

			// Token: 0x04016C14 RID: 93204
			[FieldOffset(16)]
			public IntPtr SkeletalMeshComponent;

			// Token: 0x04016C15 RID: 93205
			[FieldOffset(24)]
			public IntPtr Owner;

			// Token: 0x04016C16 RID: 93206
			[FieldOffset(32)]
			public IntPtr __Result;
		}

		// Token: 0x02003002 RID: 12290
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016C17 RID: 93207
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
