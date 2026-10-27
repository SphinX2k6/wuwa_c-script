using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200193E RID: 6462
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FSpecificTagActorHitSignature : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06017F48 RID: 98120 RVA: 0x00231C97 File Offset: 0x0022FE97
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FSpecificTagActorHitSignature.StaticFunctionPtr();
		}

		// Token: 0x06017F49 RID: 98121 RVA: 0x00231CA3 File Offset: 0x0022FEA3
		private static IntPtr StaticFunctionPtr()
		{
			if (FSpecificTagActorHitSignature._FunctionPtr == IntPtr.Zero)
			{
				FSpecificTagActorHitSignature._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroGameplay.SpecificTagActorHitSignature__DelegateSignature");
			}
			return FSpecificTagActorHitSignature._FunctionPtr;
		}

		// Token: 0x06017F4A RID: 98122 RVA: 0x00231CC6 File Offset: 0x0022FEC6
		public FSpecificTagActorHitSignature()
		{
		}

		// Token: 0x06017F4B RID: 98123 RVA: 0x00231CCE File Offset: 0x0022FECE
		[NullableContext(2)]
		public FSpecificTagActorHitSignature(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06017F4C RID: 98124 RVA: 0x00231CD8 File Offset: 0x0022FED8
		public FSpecificTagActorHitSignature(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06017F4D RID: 98125 RVA: 0x00231CE3 File Offset: 0x0022FEE3
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<AActor, AActor, FVector, FHitResult, FGameplayTagContainer, FGameplayTagContainer>) ?? ((Action<AActor, AActor, FVector, FHitResult, FGameplayTagContainer, FGameplayTagContainer>)Delegate.CreateDelegate(typeof(Action<AActor, AActor, FVector, FHitResult, FGameplayTagContainer, FGameplayTagContainer>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06017F4E RID: 98126 RVA: 0x00231D15 File Offset: 0x0022FF15
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2,
			2,
			1,
			1,
			1
		})] Action<AActor, AActor, FVector, FHitResult, FGameplayTagContainer, FGameplayTagContainer> Callback)
		{
			if (FSpecificTagActorHitSignature.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FSpecificTagActorHitSignature.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FSpecificTagActorHitSignature.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FSpecificTagActorHitSignature.OnScriptCallback));
				}
				FSpecificTagActorHitSignature.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FSpecificTagActorHitSignature.RegisterId);
		}

		// Token: 0x06017F4F RID: 98127 RVA: 0x00231D4F File Offset: 0x0022FF4F
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2,
			2,
			1,
			1,
			1
		})] Action<AActor, AActor, FVector, FHitResult, FGameplayTagContainer, FGameplayTagContainer> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06017F50 RID: 98128 RVA: 0x00231D58 File Offset: 0x0022FF58
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(AActor SelfActor, AActor OtherActor, FVector NormalImpulse, in FHitResult HitResult, in FGameplayTagContainer GameplayTags, in FGameplayTagContainer RestrictGameplayTags)
		{
			FSpecificTagActorHitSignature.__FSpecificTagActorHitSignature_DelegateParams* ptr = stackalloc FSpecificTagActorHitSignature.__FSpecificTagActorHitSignature_DelegateParams[(UIntPtr)255] + 15L / (long)sizeof(FSpecificTagActorHitSignature.__FSpecificTagActorHitSignature_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FSpecificTagActorHitSignature.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->SelfActor = ((SelfActor != null) ? SelfActor.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->NormalImpulse = NormalImpulse;
			if (HitResult != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FHitResult.StaticStruct(), &ptr->HitResult, HitResult.NativePtr, 1, false);
			}
			if (GameplayTags != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), &ptr->GameplayTags, GameplayTags.NativePtr, 1, false);
			}
			if (RestrictGameplayTags != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), &ptr->RestrictGameplayTags, RestrictGameplayTags.NativePtr, 1, false);
			}
			base.BroadcastInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FSpecificTagActorHitSignature._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06017F51 RID: 98129 RVA: 0x00231E48 File Offset: 0x00230048
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<AActor, AActor, FVector, FHitResult, FGameplayTagContainer, FGameplayTagContainer> action = target as Action<AActor, AActor, FVector, FHitResult, FGameplayTagContainer, FGameplayTagContainer>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			AActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(((FSpecificTagActorHitSignature.__FSpecificTagActorHitSignature_DelegateParams*)__Parameters)->SelfActor);
			AActor orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(((FSpecificTagActorHitSignature.__FSpecificTagActorHitSignature_DelegateParams*)__Parameters)->OtherActor);
			FHitResult arg = new FHitResult(&((FSpecificTagActorHitSignature.__FSpecificTagActorHitSignature_DelegateParams*)__Parameters)->HitResult, true, true);
			FGameplayTagContainer arg2 = new FGameplayTagContainer(&((FSpecificTagActorHitSignature.__FSpecificTagActorHitSignature_DelegateParams*)__Parameters)->GameplayTags, true, true);
			FGameplayTagContainer arg3 = new FGameplayTagContainer(&((FSpecificTagActorHitSignature.__FSpecificTagActorHitSignature_DelegateParams*)__Parameters)->RestrictGameplayTags, true, true);
			action(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, ((FSpecificTagActorHitSignature.__FSpecificTagActorHitSignature_DelegateParams*)__Parameters)->NormalImpulse, arg, arg2, arg3);
		}

		// Token: 0x0400CF63 RID: 53091
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400CF64 RID: 53092
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameplay.SpecificTagActorHitSignature__DelegateSignature";

		// Token: 0x0400CF65 RID: 53093
		private static int RegisterId;

		// Token: 0x02003005 RID: 12293
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 240)]
		protected ref struct __FSpecificTagActorHitSignature_DelegateParams
		{
			// Token: 0x04016C1D RID: 93213
			[FieldOffset(0)]
			public IntPtr SelfActor;

			// Token: 0x04016C1E RID: 93214
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x04016C1F RID: 93215
			[FieldOffset(16)]
			public FVector NormalImpulse;

			// Token: 0x04016C20 RID: 93216
			[FieldOffset(28)]
			public byte HitResult;

			// Token: 0x04016C21 RID: 93217
			[FieldOffset(176)]
			public byte GameplayTags;

			// Token: 0x04016C22 RID: 93218
			[FieldOffset(208)]
			public byte RestrictGameplayTags;
		}

		// Token: 0x02003006 RID: 12294
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016C23 RID: 93219
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
