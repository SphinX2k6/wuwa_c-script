using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000411 RID: 1041
	public sealed class FMaterialSpecSpawnRenderActorRetVal : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600655A RID: 25946 RVA: 0x00090E77 File Offset: 0x0008F077
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FMaterialSpecSpawnRenderActorRetVal.StaticFunctionPtr();
		}

		// Token: 0x0600655B RID: 25947 RVA: 0x00090E83 File Offset: 0x0008F083
		private static IntPtr StaticFunctionPtr()
		{
			if (FMaterialSpecSpawnRenderActorRetVal._FunctionPtr == IntPtr.Zero)
			{
				FMaterialSpecSpawnRenderActorRetVal._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroGameplay.MaterialSpecSpawnRenderActorRetVal__DelegateSignature");
			}
			return FMaterialSpecSpawnRenderActorRetVal._FunctionPtr;
		}

		// Token: 0x0600655C RID: 25948 RVA: 0x00090EA6 File Offset: 0x0008F0A6
		public FMaterialSpecSpawnRenderActorRetVal()
		{
		}

		// Token: 0x0600655D RID: 25949 RVA: 0x00090EAE File Offset: 0x0008F0AE
		[NullableContext(2)]
		public FMaterialSpecSpawnRenderActorRetVal(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600655E RID: 25950 RVA: 0x00090EB8 File Offset: 0x0008F0B8
		public FMaterialSpecSpawnRenderActorRetVal(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600655F RID: 25951 RVA: 0x00090EC3 File Offset: 0x0008F0C3
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Func<USkeletalMeshComponent, AActor>) ?? ((Func<USkeletalMeshComponent, AActor>)Delegate.CreateDelegate(typeof(Func<USkeletalMeshComponent, AActor>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06006560 RID: 25952 RVA: 0x00090EF5 File Offset: 0x0008F0F5
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

		// Token: 0x06006561 RID: 25953 RVA: 0x00090F30 File Offset: 0x0008F130
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe AActor Execute(USkeletalMeshComponent SkeletalMeshComponent)
		{
			FMaterialSpecSpawnRenderActorRetVal.__FMaterialSpecSpawnRenderActorRetVal_DelegateParams* ptr = stackalloc FMaterialSpecSpawnRenderActorRetVal.__FMaterialSpecSpawnRenderActorRetVal_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FMaterialSpecSpawnRenderActorRetVal.__FMaterialSpecSpawnRenderActorRetVal_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FMaterialSpecSpawnRenderActorRetVal.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->SkeletalMeshComponent = ((SkeletalMeshComponent != null) ? SkeletalMeshComponent.NativePtr : IntPtr.Zero);
			base.ExecuteInternal((void*)ptr);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(ptr->__Result);
		}

		// Token: 0x06006562 RID: 25954 RVA: 0x00090F88 File Offset: 0x0008F188
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x04002A9F RID: 10911
		internal static IntPtr _FunctionPtr;

		// Token: 0x04002AA0 RID: 10912
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameplay.MaterialSpecSpawnRenderActorRetVal__DelegateSignature";

		// Token: 0x04002AA1 RID: 10913
		private static int RegisterId;

		// Token: 0x02000B03 RID: 2819
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		private ref struct __FMaterialSpecSpawnRenderActorRetVal_DelegateParams
		{
			// Token: 0x04005B9A RID: 23450
			[FieldOffset(0)]
			public IntPtr SkeletalMeshComponent;

			// Token: 0x04005B9B RID: 23451
			[FieldOffset(8)]
			public IntPtr __Result;
		}

		// Token: 0x02000B04 RID: 2820
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005B9C RID: 23452
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
