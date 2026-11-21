using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200041E RID: 1054
	public sealed class FSkeletalMeshSpecOnBodyEffectChangeRetVal : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060065E9 RID: 26089 RVA: 0x00092053 File Offset: 0x00090253
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FSkeletalMeshSpecOnBodyEffectChangeRetVal.StaticFunctionPtr();
		}

		// Token: 0x060065EA RID: 26090 RVA: 0x0009205F File Offset: 0x0009025F
		private static IntPtr StaticFunctionPtr()
		{
			if (FSkeletalMeshSpecOnBodyEffectChangeRetVal._FunctionPtr == IntPtr.Zero)
			{
				FSkeletalMeshSpecOnBodyEffectChangeRetVal._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroGameplay.SkeletalMeshSpecOnBodyEffectChangeRetVal__DelegateSignature");
			}
			return FSkeletalMeshSpecOnBodyEffectChangeRetVal._FunctionPtr;
		}

		// Token: 0x060065EB RID: 26091 RVA: 0x00092082 File Offset: 0x00090282
		public FSkeletalMeshSpecOnBodyEffectChangeRetVal()
		{
		}

		// Token: 0x060065EC RID: 26092 RVA: 0x0009208A File Offset: 0x0009028A
		[NullableContext(2)]
		public FSkeletalMeshSpecOnBodyEffectChangeRetVal(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060065ED RID: 26093 RVA: 0x00092094 File Offset: 0x00090294
		public FSkeletalMeshSpecOnBodyEffectChangeRetVal(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060065EE RID: 26094 RVA: 0x0009209F File Offset: 0x0009029F
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Func<float, UActorComponent, USkeletalMeshComponent, AActor, UActorComponent>) ?? ((Func<float, UActorComponent, USkeletalMeshComponent, AActor, UActorComponent>)Delegate.CreateDelegate(typeof(Func<float, UActorComponent, USkeletalMeshComponent, AActor, UActorComponent>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060065EF RID: 26095 RVA: 0x000920D1 File Offset: 0x000902D1
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

		// Token: 0x060065F0 RID: 26096 RVA: 0x0009210C File Offset: 0x0009030C
		[NullableContext(2)]
		[SkipLocalsInit]
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

		// Token: 0x060065F1 RID: 26097 RVA: 0x00092198 File Offset: 0x00090398
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x04002ADE RID: 10974
		internal static IntPtr _FunctionPtr;

		// Token: 0x04002ADF RID: 10975
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameplay.SkeletalMeshSpecOnBodyEffectChangeRetVal__DelegateSignature";

		// Token: 0x04002AE0 RID: 10976
		private static int RegisterId;

		// Token: 0x02000B15 RID: 2837
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		private ref struct __FSkeletalMeshSpecOnBodyEffectChangeRetVal_DelegateParams
		{
			// Token: 0x04005BBB RID: 23483
			[FieldOffset(0)]
			public float Opacity;

			// Token: 0x04005BBC RID: 23484
			[FieldOffset(8)]
			public IntPtr CharRenderingComponent;

			// Token: 0x04005BBD RID: 23485
			[FieldOffset(16)]
			public IntPtr SkeletalMeshComponent;

			// Token: 0x04005BBE RID: 23486
			[FieldOffset(24)]
			public IntPtr Owner;

			// Token: 0x04005BBF RID: 23487
			[FieldOffset(32)]
			public IntPtr __Result;
		}

		// Token: 0x02000B16 RID: 2838
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005BC0 RID: 23488
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
