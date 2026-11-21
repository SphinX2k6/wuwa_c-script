using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200041F RID: 1055
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FSpecificTagActorBeginOverlapSignature : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060065F2 RID: 26098 RVA: 0x00092226 File Offset: 0x00090426
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FSpecificTagActorBeginOverlapSignature.StaticFunctionPtr();
		}

		// Token: 0x060065F3 RID: 26099 RVA: 0x00092232 File Offset: 0x00090432
		private static IntPtr StaticFunctionPtr()
		{
			if (FSpecificTagActorBeginOverlapSignature._FunctionPtr == IntPtr.Zero)
			{
				FSpecificTagActorBeginOverlapSignature._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroGameplay.SpecificTagActorBeginOverlapSignature__DelegateSignature");
			}
			return FSpecificTagActorBeginOverlapSignature._FunctionPtr;
		}

		// Token: 0x060065F4 RID: 26100 RVA: 0x00092255 File Offset: 0x00090455
		public FSpecificTagActorBeginOverlapSignature()
		{
		}

		// Token: 0x060065F5 RID: 26101 RVA: 0x0009225D File Offset: 0x0009045D
		[NullableContext(2)]
		public FSpecificTagActorBeginOverlapSignature(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060065F6 RID: 26102 RVA: 0x00092267 File Offset: 0x00090467
		public FSpecificTagActorBeginOverlapSignature(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060065F7 RID: 26103 RVA: 0x00092272 File Offset: 0x00090472
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<AActor, AActor, FGameplayTagContainer, FGameplayTagContainer>) ?? ((Action<AActor, AActor, FGameplayTagContainer, FGameplayTagContainer>)Delegate.CreateDelegate(typeof(Action<AActor, AActor, FGameplayTagContainer, FGameplayTagContainer>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060065F8 RID: 26104 RVA: 0x000922A4 File Offset: 0x000904A4
		public void Add([Nullable(new byte[]
		{
			1,
			2,
			2,
			1,
			1
		})] Action<AActor, AActor, FGameplayTagContainer, FGameplayTagContainer> Callback)
		{
			if (FSpecificTagActorBeginOverlapSignature.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FSpecificTagActorBeginOverlapSignature.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FSpecificTagActorBeginOverlapSignature.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FSpecificTagActorBeginOverlapSignature.OnScriptCallback));
				}
				FSpecificTagActorBeginOverlapSignature.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FSpecificTagActorBeginOverlapSignature.RegisterId);
		}

		// Token: 0x060065F9 RID: 26105 RVA: 0x000922DE File Offset: 0x000904DE
		public void Remove([Nullable(new byte[]
		{
			1,
			2,
			2,
			1,
			1
		})] Action<AActor, AActor, FGameplayTagContainer, FGameplayTagContainer> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x060065FA RID: 26106 RVA: 0x000922E8 File Offset: 0x000904E8
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Broadcast(AActor SelfActor, AActor OtherActor, in FGameplayTagContainer GameplayTags, in FGameplayTagContainer RestrictGameplayTags)
		{
			FSpecificTagActorBeginOverlapSignature.__FSpecificTagActorBeginOverlapSignature_DelegateParams* ptr = stackalloc FSpecificTagActorBeginOverlapSignature.__FSpecificTagActorBeginOverlapSignature_DelegateParams[(UIntPtr)95] + 15L / (long)sizeof(FSpecificTagActorBeginOverlapSignature.__FSpecificTagActorBeginOverlapSignature_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FSpecificTagActorBeginOverlapSignature.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->SelfActor = ((SelfActor != null) ? SelfActor.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			if (GameplayTags != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), &ptr->GameplayTags, GameplayTags.NativePtr, 1, false);
			}
			if (RestrictGameplayTags != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), &ptr->RestrictGameplayTags, RestrictGameplayTags.NativePtr, 1, false);
			}
			base.BroadcastInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FSpecificTagActorBeginOverlapSignature._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060065FB RID: 26107 RVA: 0x000923A4 File Offset: 0x000905A4
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<AActor, AActor, FGameplayTagContainer, FGameplayTagContainer> action = target as Action<AActor, AActor, FGameplayTagContainer, FGameplayTagContainer>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			AActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(((FSpecificTagActorBeginOverlapSignature.__FSpecificTagActorBeginOverlapSignature_DelegateParams*)__Parameters)->SelfActor);
			AActor orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(((FSpecificTagActorBeginOverlapSignature.__FSpecificTagActorBeginOverlapSignature_DelegateParams*)__Parameters)->OtherActor);
			FGameplayTagContainer arg = new FGameplayTagContainer(&((FSpecificTagActorBeginOverlapSignature.__FSpecificTagActorBeginOverlapSignature_DelegateParams*)__Parameters)->GameplayTags, true, true);
			FGameplayTagContainer arg2 = new FGameplayTagContainer(&((FSpecificTagActorBeginOverlapSignature.__FSpecificTagActorBeginOverlapSignature_DelegateParams*)__Parameters)->RestrictGameplayTags, true, true);
			action(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, arg, arg2);
		}

		// Token: 0x04002AE1 RID: 10977
		internal static IntPtr _FunctionPtr;

		// Token: 0x04002AE2 RID: 10978
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameplay.SpecificTagActorBeginOverlapSignature__DelegateSignature";

		// Token: 0x04002AE3 RID: 10979
		private static int RegisterId;

		// Token: 0x02000B17 RID: 2839
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		private ref struct __FSpecificTagActorBeginOverlapSignature_DelegateParams
		{
			// Token: 0x04005BC1 RID: 23489
			[FieldOffset(0)]
			public IntPtr SelfActor;

			// Token: 0x04005BC2 RID: 23490
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x04005BC3 RID: 23491
			[FieldOffset(16)]
			public byte GameplayTags;

			// Token: 0x04005BC4 RID: 23492
			[FieldOffset(48)]
			public byte RestrictGameplayTags;
		}

		// Token: 0x02000B18 RID: 2840
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005BC5 RID: 23493
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
