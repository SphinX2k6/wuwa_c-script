using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000420 RID: 1056
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FSpecificTagActorHitSignature : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060065FC RID: 26108 RVA: 0x00092427 File Offset: 0x00090627
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FSpecificTagActorHitSignature.StaticFunctionPtr();
		}

		// Token: 0x060065FD RID: 26109 RVA: 0x00092433 File Offset: 0x00090633
		private static IntPtr StaticFunctionPtr()
		{
			if (FSpecificTagActorHitSignature._FunctionPtr == IntPtr.Zero)
			{
				FSpecificTagActorHitSignature._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroGameplay.SpecificTagActorHitSignature__DelegateSignature");
			}
			return FSpecificTagActorHitSignature._FunctionPtr;
		}

		// Token: 0x060065FE RID: 26110 RVA: 0x00092456 File Offset: 0x00090656
		public FSpecificTagActorHitSignature()
		{
		}

		// Token: 0x060065FF RID: 26111 RVA: 0x0009245E File Offset: 0x0009065E
		[NullableContext(2)]
		public FSpecificTagActorHitSignature(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006600 RID: 26112 RVA: 0x00092468 File Offset: 0x00090668
		public FSpecificTagActorHitSignature(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06006601 RID: 26113 RVA: 0x00092473 File Offset: 0x00090673
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<AActor, AActor, FVector, FHitResult, FGameplayTagContainer, FGameplayTagContainer>) ?? ((Action<AActor, AActor, FVector, FHitResult, FGameplayTagContainer, FGameplayTagContainer>)Delegate.CreateDelegate(typeof(Action<AActor, AActor, FVector, FHitResult, FGameplayTagContainer, FGameplayTagContainer>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06006602 RID: 26114 RVA: 0x000924A5 File Offset: 0x000906A5
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

		// Token: 0x06006603 RID: 26115 RVA: 0x000924DF File Offset: 0x000906DF
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

		// Token: 0x06006604 RID: 26116 RVA: 0x000924E8 File Offset: 0x000906E8
		[NullableContext(2)]
		[SkipLocalsInit]
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

		// Token: 0x06006605 RID: 26117 RVA: 0x000925D8 File Offset: 0x000907D8
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x04002AE4 RID: 10980
		internal static IntPtr _FunctionPtr;

		// Token: 0x04002AE5 RID: 10981
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameplay.SpecificTagActorHitSignature__DelegateSignature";

		// Token: 0x04002AE6 RID: 10982
		private static int RegisterId;

		// Token: 0x02000B19 RID: 2841
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 240)]
		private ref struct __FSpecificTagActorHitSignature_DelegateParams
		{
			// Token: 0x04005BC6 RID: 23494
			[FieldOffset(0)]
			public IntPtr SelfActor;

			// Token: 0x04005BC7 RID: 23495
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x04005BC8 RID: 23496
			[FieldOffset(16)]
			public FVector NormalImpulse;

			// Token: 0x04005BC9 RID: 23497
			[FieldOffset(28)]
			public byte HitResult;

			// Token: 0x04005BCA RID: 23498
			[FieldOffset(176)]
			public byte GameplayTags;

			// Token: 0x04005BCB RID: 23499
			[FieldOffset(208)]
			public byte RestrictGameplayTags;
		}

		// Token: 0x02000B1A RID: 2842
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005BCC RID: 23500
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
