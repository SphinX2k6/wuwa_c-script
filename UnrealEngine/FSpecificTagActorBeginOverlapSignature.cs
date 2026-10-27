using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200193D RID: 6461
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FSpecificTagActorBeginOverlapSignature : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06017F3E RID: 98110 RVA: 0x00231A96 File Offset: 0x0022FC96
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FSpecificTagActorBeginOverlapSignature.StaticFunctionPtr();
		}

		// Token: 0x06017F3F RID: 98111 RVA: 0x00231AA2 File Offset: 0x0022FCA2
		private static IntPtr StaticFunctionPtr()
		{
			if (FSpecificTagActorBeginOverlapSignature._FunctionPtr == IntPtr.Zero)
			{
				FSpecificTagActorBeginOverlapSignature._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroGameplay.SpecificTagActorBeginOverlapSignature__DelegateSignature");
			}
			return FSpecificTagActorBeginOverlapSignature._FunctionPtr;
		}

		// Token: 0x06017F40 RID: 98112 RVA: 0x00231AC5 File Offset: 0x0022FCC5
		public FSpecificTagActorBeginOverlapSignature()
		{
		}

		// Token: 0x06017F41 RID: 98113 RVA: 0x00231ACD File Offset: 0x0022FCCD
		[NullableContext(2)]
		public FSpecificTagActorBeginOverlapSignature(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06017F42 RID: 98114 RVA: 0x00231AD7 File Offset: 0x0022FCD7
		public FSpecificTagActorBeginOverlapSignature(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06017F43 RID: 98115 RVA: 0x00231AE2 File Offset: 0x0022FCE2
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<AActor, AActor, FGameplayTagContainer, FGameplayTagContainer>) ?? ((Action<AActor, AActor, FGameplayTagContainer, FGameplayTagContainer>)Delegate.CreateDelegate(typeof(Action<AActor, AActor, FGameplayTagContainer, FGameplayTagContainer>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06017F44 RID: 98116 RVA: 0x00231B14 File Offset: 0x0022FD14
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x06017F45 RID: 98117 RVA: 0x00231B4E File Offset: 0x0022FD4E
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x06017F46 RID: 98118 RVA: 0x00231B58 File Offset: 0x0022FD58
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x06017F47 RID: 98119 RVA: 0x00231C14 File Offset: 0x0022FE14
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x0400CF60 RID: 53088
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400CF61 RID: 53089
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameplay.SpecificTagActorBeginOverlapSignature__DelegateSignature";

		// Token: 0x0400CF62 RID: 53090
		private static int RegisterId;

		// Token: 0x02003003 RID: 12291
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __FSpecificTagActorBeginOverlapSignature_DelegateParams
		{
			// Token: 0x04016C18 RID: 93208
			[FieldOffset(0)]
			public IntPtr SelfActor;

			// Token: 0x04016C19 RID: 93209
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x04016C1A RID: 93210
			[FieldOffset(16)]
			public byte GameplayTags;

			// Token: 0x04016C1B RID: 93211
			[FieldOffset(48)]
			public byte RestrictGameplayTags;
		}

		// Token: 0x02003004 RID: 12292
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016C1C RID: 93212
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
