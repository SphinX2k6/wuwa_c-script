using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200134D RID: 4941
	[UnrealObjectPath("/Script/GameplayAbilities.GameplayAbilityActorInfo")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 80)]
	public class FGameplayAbilityActorInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060121FF RID: 74239 RVA: 0x001A9BA9 File Offset: 0x001A7DA9
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FGameplayAbilityActorInfo._ScriptStructPtr != 0) ? FGameplayAbilityActorInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GameplayAbilities.GameplayAbilityActorInfo", ref FGameplayAbilityActorInfo._ScriptStructPtr);
		}

		// Token: 0x17004693 RID: 18067
		// (get) Token: 0x06012200 RID: 74240 RVA: 0x001A9BCD File Offset: 0x001A7DCD
		// (set) Token: 0x06012201 RID: 74241 RVA: 0x001A9BE1 File Offset: 0x001A7DE1
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<AActor> OwnerActor
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)FGameplayAbilityActorInfo.__PropertyOffset_OwnerActor);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)FGameplayAbilityActorInfo.__PropertyOffset_OwnerActor) = value;
			}
		}

		// Token: 0x17004694 RID: 18068
		// (get) Token: 0x06012202 RID: 74242 RVA: 0x001A9BF6 File Offset: 0x001A7DF6
		// (set) Token: 0x06012203 RID: 74243 RVA: 0x001A9C0A File Offset: 0x001A7E0A
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<AActor> AvatarActor
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)FGameplayAbilityActorInfo.__PropertyOffset_AvatarActor);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)FGameplayAbilityActorInfo.__PropertyOffset_AvatarActor) = value;
			}
		}

		// Token: 0x17004695 RID: 18069
		// (get) Token: 0x06012204 RID: 74244 RVA: 0x001A9C1F File Offset: 0x001A7E1F
		// (set) Token: 0x06012205 RID: 74245 RVA: 0x001A9C33 File Offset: 0x001A7E33
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<APlayerController> PlayerController
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)FGameplayAbilityActorInfo.__PropertyOffset_PlayerController);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)FGameplayAbilityActorInfo.__PropertyOffset_PlayerController) = value;
			}
		}

		// Token: 0x17004696 RID: 18070
		// (get) Token: 0x06012206 RID: 74246 RVA: 0x001A9C48 File Offset: 0x001A7E48
		// (set) Token: 0x06012207 RID: 74247 RVA: 0x001A9C5C File Offset: 0x001A7E5C
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<UAbilitySystemComponent> AbilitySystemComponent
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)FGameplayAbilityActorInfo.__PropertyOffset_AbilitySystemComponent);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)FGameplayAbilityActorInfo.__PropertyOffset_AbilitySystemComponent) = value;
			}
		}

		// Token: 0x17004697 RID: 18071
		// (get) Token: 0x06012208 RID: 74248 RVA: 0x001A9C71 File Offset: 0x001A7E71
		// (set) Token: 0x06012209 RID: 74249 RVA: 0x001A9C85 File Offset: 0x001A7E85
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<USkeletalMeshComponent> SkeletalMeshComponent
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)FGameplayAbilityActorInfo.__PropertyOffset_SkeletalMeshComponent);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)FGameplayAbilityActorInfo.__PropertyOffset_SkeletalMeshComponent) = value;
			}
		}

		// Token: 0x17004698 RID: 18072
		// (get) Token: 0x0601220A RID: 74250 RVA: 0x001A9C9A File Offset: 0x001A7E9A
		// (set) Token: 0x0601220B RID: 74251 RVA: 0x001A9CAE File Offset: 0x001A7EAE
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<UAnimInstance> AnimInstance
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)FGameplayAbilityActorInfo.__PropertyOffset_AnimInstance);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)FGameplayAbilityActorInfo.__PropertyOffset_AnimInstance) = value;
			}
		}

		// Token: 0x17004699 RID: 18073
		// (get) Token: 0x0601220C RID: 74252 RVA: 0x001A9CC3 File Offset: 0x001A7EC3
		// (set) Token: 0x0601220D RID: 74253 RVA: 0x001A9CD7 File Offset: 0x001A7ED7
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<UMovementComponent> MovementComponent
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)FGameplayAbilityActorInfo.__PropertyOffset_MovementComponent);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)FGameplayAbilityActorInfo.__PropertyOffset_MovementComponent) = value;
			}
		}

		// Token: 0x1700469A RID: 18074
		// (get) Token: 0x0601220E RID: 74254 RVA: 0x001A9CEC File Offset: 0x001A7EEC
		// (set) Token: 0x0601220F RID: 74255 RVA: 0x001A9D00 File Offset: 0x001A7F00
		public unsafe FName AffectedAnimInstanceTag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGameplayAbilityActorInfo.__PropertyOffset_AffectedAnimInstanceTag);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGameplayAbilityActorInfo.__PropertyOffset_AffectedAnimInstanceTag) = value;
			}
		}

		// Token: 0x06012210 RID: 74256 RVA: 0x001A9D15 File Offset: 0x001A7F15
		public FGameplayAbilityActorInfo()
		{
		}

		// Token: 0x06012211 RID: 74257 RVA: 0x001A9D20 File Offset: 0x001A7F20
		public FGameplayAbilityActorInfo([Nullable(new byte[]
		{
			0,
			1
		})] TWeakObjectPtr<AActor> OwnerActor, [Nullable(new byte[]
		{
			0,
			1
		})] TWeakObjectPtr<AActor> AvatarActor, [Nullable(new byte[]
		{
			0,
			1
		})] TWeakObjectPtr<APlayerController> PlayerController, [Nullable(new byte[]
		{
			0,
			1
		})] TWeakObjectPtr<UAbilitySystemComponent> AbilitySystemComponent, [Nullable(new byte[]
		{
			0,
			1
		})] TWeakObjectPtr<USkeletalMeshComponent> SkeletalMeshComponent, [Nullable(new byte[]
		{
			0,
			1
		})] TWeakObjectPtr<UAnimInstance> AnimInstance, [Nullable(new byte[]
		{
			0,
			1
		})] TWeakObjectPtr<UMovementComponent> MovementComponent, FName AffectedAnimInstanceTag)
		{
			this.OwnerActor = OwnerActor;
			this.AvatarActor = AvatarActor;
			this.PlayerController = PlayerController;
			this.AbilitySystemComponent = AbilitySystemComponent;
			this.SkeletalMeshComponent = SkeletalMeshComponent;
			this.AnimInstance = AnimInstance;
			this.MovementComponent = MovementComponent;
			this.AffectedAnimInstanceTag = AffectedAnimInstanceTag;
		}

		// Token: 0x06012212 RID: 74258 RVA: 0x001A9D70 File Offset: 0x001A7F70
		protected override IntPtr GetUStructPtr()
		{
			return FGameplayAbilityActorInfo.StaticStruct();
		}

		// Token: 0x06012213 RID: 74259 RVA: 0x001A9D7C File Offset: 0x001A7F7C
		[NullableContext(2)]
		public FGameplayAbilityActorInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06012214 RID: 74260 RVA: 0x001A9D86 File Offset: 0x001A7F86
		public FGameplayAbilityActorInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06012215 RID: 74261 RVA: 0x001A9D91 File Offset: 0x001A7F91
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FGameplayAbilityActorInfo(Pointer, false, true);
		}

		// Token: 0x06012216 RID: 74262 RVA: 0x001A9D9B File Offset: 0x001A7F9B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FGameplayAbilityActorInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04009B5A RID: 39770
		[Nullable(1)]
		public const string __ObjectPath = "/Script/GameplayAbilities.GameplayAbilityActorInfo";

		// Token: 0x04009B5B RID: 39771
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04009B5C RID: 39772
		internal static int __PropertyOffset_OwnerActor;

		// Token: 0x04009B5D RID: 39773
		internal static int __PropertyOffset_AvatarActor;

		// Token: 0x04009B5E RID: 39774
		internal static int __PropertyOffset_PlayerController;

		// Token: 0x04009B5F RID: 39775
		internal static int __PropertyOffset_AbilitySystemComponent;

		// Token: 0x04009B60 RID: 39776
		internal static int __PropertyOffset_SkeletalMeshComponent;

		// Token: 0x04009B61 RID: 39777
		internal static int __PropertyOffset_AnimInstance;

		// Token: 0x04009B62 RID: 39778
		internal static int __PropertyOffset_MovementComponent;

		// Token: 0x04009B63 RID: 39779
		internal static int __PropertyOffset_AffectedAnimInstanceTag;
	}
}
