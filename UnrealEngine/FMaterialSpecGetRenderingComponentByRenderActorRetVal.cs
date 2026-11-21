using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200040E RID: 1038
	public sealed class FMaterialSpecGetRenderingComponentByRenderActorRetVal : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600653F RID: 25919 RVA: 0x000909F3 File Offset: 0x0008EBF3
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FMaterialSpecGetRenderingComponentByRenderActorRetVal.StaticFunctionPtr();
		}

		// Token: 0x06006540 RID: 25920 RVA: 0x000909FF File Offset: 0x0008EBFF
		private static IntPtr StaticFunctionPtr()
		{
			if (FMaterialSpecGetRenderingComponentByRenderActorRetVal._FunctionPtr == IntPtr.Zero)
			{
				FMaterialSpecGetRenderingComponentByRenderActorRetVal._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroGameplay.MaterialSpecGetRenderingComponentByRenderActorRetVal__DelegateSignature");
			}
			return FMaterialSpecGetRenderingComponentByRenderActorRetVal._FunctionPtr;
		}

		// Token: 0x06006541 RID: 25921 RVA: 0x00090A22 File Offset: 0x0008EC22
		public FMaterialSpecGetRenderingComponentByRenderActorRetVal()
		{
		}

		// Token: 0x06006542 RID: 25922 RVA: 0x00090A2A File Offset: 0x0008EC2A
		[NullableContext(2)]
		public FMaterialSpecGetRenderingComponentByRenderActorRetVal(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006543 RID: 25923 RVA: 0x00090A34 File Offset: 0x0008EC34
		public FMaterialSpecGetRenderingComponentByRenderActorRetVal(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06006544 RID: 25924 RVA: 0x00090A3F File Offset: 0x0008EC3F
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Func<AActor, USkeletalMeshComponent, UKuroCharRenderingComponent>) ?? ((Func<AActor, USkeletalMeshComponent, UKuroCharRenderingComponent>)Delegate.CreateDelegate(typeof(Func<AActor, USkeletalMeshComponent, UKuroCharRenderingComponent>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06006545 RID: 25925 RVA: 0x00090A71 File Offset: 0x0008EC71
		public void Bind([Nullable(new byte[]
		{
			1,
			2,
			2,
			2
		})] Func<AActor, USkeletalMeshComponent, UKuroCharRenderingComponent> Callback)
		{
			if (FMaterialSpecGetRenderingComponentByRenderActorRetVal.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FMaterialSpecGetRenderingComponentByRenderActorRetVal.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FMaterialSpecGetRenderingComponentByRenderActorRetVal.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FMaterialSpecGetRenderingComponentByRenderActorRetVal.OnScriptCallback));
				}
				FMaterialSpecGetRenderingComponentByRenderActorRetVal.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FMaterialSpecGetRenderingComponentByRenderActorRetVal.RegisterId);
		}

		// Token: 0x06006546 RID: 25926 RVA: 0x00090AAC File Offset: 0x0008ECAC
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe UKuroCharRenderingComponent Execute(AActor Actor, USkeletalMeshComponent SkeletalMeshComponent)
		{
			FMaterialSpecGetRenderingComponentByRenderActorRetVal.__FMaterialSpecGetRenderingComponentByRenderActorRetVal_DelegateParams* ptr = stackalloc FMaterialSpecGetRenderingComponentByRenderActorRetVal.__FMaterialSpecGetRenderingComponentByRenderActorRetVal_DelegateParams[(UIntPtr)39] + 15L / (long)sizeof(FMaterialSpecGetRenderingComponentByRenderActorRetVal.__FMaterialSpecGetRenderingComponentByRenderActorRetVal_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FMaterialSpecGetRenderingComponentByRenderActorRetVal.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Actor = ((Actor != null) ? Actor.NativePtr : IntPtr.Zero);
			ptr->SkeletalMeshComponent = ((SkeletalMeshComponent != null) ? SkeletalMeshComponent.NativePtr : IntPtr.Zero);
			base.ExecuteInternal((void*)ptr);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroCharRenderingComponent>(ptr->__Result);
		}

		// Token: 0x06006547 RID: 25927 RVA: 0x00090B1C File Offset: 0x0008ED1C
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Func<AActor, USkeletalMeshComponent, UKuroCharRenderingComponent> func = target as Func<AActor, USkeletalMeshComponent, UKuroCharRenderingComponent>;
			if (func == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			AActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(((FMaterialSpecGetRenderingComponentByRenderActorRetVal.__FMaterialSpecGetRenderingComponentByRenderActorRetVal_DelegateParams*)__Parameters)->Actor);
			USkeletalMeshComponent orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(((FMaterialSpecGetRenderingComponentByRenderActorRetVal.__FMaterialSpecGetRenderingComponentByRenderActorRetVal_DelegateParams*)__Parameters)->SkeletalMeshComponent);
			UKuroCharRenderingComponent ukuroCharRenderingComponent = func(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
			((FMaterialSpecGetRenderingComponentByRenderActorRetVal.__FMaterialSpecGetRenderingComponentByRenderActorRetVal_DelegateParams*)__Parameters)->__Result = ((ukuroCharRenderingComponent != null) ? ukuroCharRenderingComponent.NativePtr : IntPtr.Zero);
		}

		// Token: 0x04002A96 RID: 10902
		internal static IntPtr _FunctionPtr;

		// Token: 0x04002A97 RID: 10903
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameplay.MaterialSpecGetRenderingComponentByRenderActorRetVal__DelegateSignature";

		// Token: 0x04002A98 RID: 10904
		private static int RegisterId;

		// Token: 0x02000AFD RID: 2813
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		private ref struct __FMaterialSpecGetRenderingComponentByRenderActorRetVal_DelegateParams
		{
			// Token: 0x04005B90 RID: 23440
			[FieldOffset(0)]
			public IntPtr Actor;

			// Token: 0x04005B91 RID: 23441
			[FieldOffset(8)]
			public IntPtr SkeletalMeshComponent;

			// Token: 0x04005B92 RID: 23442
			[FieldOffset(16)]
			public IntPtr __Result;
		}

		// Token: 0x02000AFE RID: 2814
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005B93 RID: 23443
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
