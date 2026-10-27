using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001383 RID: 4995
	[UnrealObjectPath("/Script/GameplayAbilities.GameplayEffectContext")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 112)]
	public class FGameplayEffectContext : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06012566 RID: 75110 RVA: 0x001AEF99 File Offset: 0x001AD199
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FGameplayEffectContext._ScriptStructPtr != 0) ? FGameplayEffectContext._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GameplayAbilities.GameplayEffectContext", ref FGameplayEffectContext._ScriptStructPtr);
		}

		// Token: 0x17004774 RID: 18292
		// (get) Token: 0x06012567 RID: 75111 RVA: 0x001AEFBD File Offset: 0x001AD1BD
		// (set) Token: 0x06012568 RID: 75112 RVA: 0x001AEFD1 File Offset: 0x001AD1D1
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<AActor> Instigator
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)FGameplayEffectContext.__PropertyOffset_Instigator);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)FGameplayEffectContext.__PropertyOffset_Instigator) = value;
			}
		}

		// Token: 0x17004775 RID: 18293
		// (get) Token: 0x06012569 RID: 75113 RVA: 0x001AEFE6 File Offset: 0x001AD1E6
		// (set) Token: 0x0601256A RID: 75114 RVA: 0x001AEFFA File Offset: 0x001AD1FA
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<AActor> EffectCauser
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)FGameplayEffectContext.__PropertyOffset_EffectCauser);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)FGameplayEffectContext.__PropertyOffset_EffectCauser) = value;
			}
		}

		// Token: 0x17004776 RID: 18294
		// (get) Token: 0x0601256B RID: 75115 RVA: 0x001AF00F File Offset: 0x001AD20F
		// (set) Token: 0x0601256C RID: 75116 RVA: 0x001AF023 File Offset: 0x001AD223
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<UGameplayAbility> AbilityCDO
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)FGameplayEffectContext.__PropertyOffset_AbilityCDO);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)FGameplayEffectContext.__PropertyOffset_AbilityCDO) = value;
			}
		}

		// Token: 0x17004777 RID: 18295
		// (get) Token: 0x0601256D RID: 75117 RVA: 0x001AF038 File Offset: 0x001AD238
		// (set) Token: 0x0601256E RID: 75118 RVA: 0x001AF04C File Offset: 0x001AD24C
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<UGameplayAbility> AbilityInstanceNotReplicated
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)FGameplayEffectContext.__PropertyOffset_AbilityInstanceNotReplicated);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)FGameplayEffectContext.__PropertyOffset_AbilityInstanceNotReplicated) = value;
			}
		}

		// Token: 0x17004778 RID: 18296
		// (get) Token: 0x0601256F RID: 75119 RVA: 0x001AF061 File Offset: 0x001AD261
		// (set) Token: 0x06012570 RID: 75120 RVA: 0x001AF071 File Offset: 0x001AD271
		public unsafe int AbilityLevel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGameplayEffectContext.__PropertyOffset_AbilityLevel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGameplayEffectContext.__PropertyOffset_AbilityLevel) = value;
			}
		}

		// Token: 0x17004779 RID: 18297
		// (get) Token: 0x06012571 RID: 75121 RVA: 0x001AF082 File Offset: 0x001AD282
		// (set) Token: 0x06012572 RID: 75122 RVA: 0x001AF096 File Offset: 0x001AD296
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<UObject> SourceObject
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)FGameplayEffectContext.__PropertyOffset_SourceObject);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)FGameplayEffectContext.__PropertyOffset_SourceObject) = value;
			}
		}

		// Token: 0x1700477A RID: 18298
		// (get) Token: 0x06012573 RID: 75123 RVA: 0x001AF0AB File Offset: 0x001AD2AB
		// (set) Token: 0x06012574 RID: 75124 RVA: 0x001AF0BF File Offset: 0x001AD2BF
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<UAbilitySystemComponent> InstigatorAbilitySystemComponent
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)FGameplayEffectContext.__PropertyOffset_InstigatorAbilitySystemComponent);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)FGameplayEffectContext.__PropertyOffset_InstigatorAbilitySystemComponent) = value;
			}
		}

		// Token: 0x1700477B RID: 18299
		// (get) Token: 0x06012575 RID: 75125 RVA: 0x001AF0D4 File Offset: 0x001AD2D4
		// (set) Token: 0x06012576 RID: 75126 RVA: 0x001AF117 File Offset: 0x001AD317
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		public TArray<TWeakObjectPtr<AActor>> Actors
		{
			[return: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			get
			{
				base.FastCheckIsValid();
				TArray<TWeakObjectPtr<AActor>> result;
				if ((result = this._Actors) == null)
				{
					result = (this._Actors = new TArray<TWeakObjectPtr<AActor>>(base.NativePtr + (IntPtr)FGameplayEffectContext.__PropertyOffset_Actors, base.MemoryOwner ?? this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			set
			{
				this.Actors.CopyAssign(value);
			}
		}

		// Token: 0x1700477C RID: 18300
		// (get) Token: 0x06012577 RID: 75127 RVA: 0x001AF125 File Offset: 0x001AD325
		// (set) Token: 0x06012578 RID: 75128 RVA: 0x001AF139 File Offset: 0x001AD339
		public unsafe FVector WorldOrigin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGameplayEffectContext.__PropertyOffset_WorldOrigin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGameplayEffectContext.__PropertyOffset_WorldOrigin) = value;
			}
		}

		// Token: 0x1700477D RID: 18301
		// (get) Token: 0x06012579 RID: 75129 RVA: 0x001AF14E File Offset: 0x001AD34E
		// (set) Token: 0x0601257A RID: 75130 RVA: 0x001AF167 File Offset: 0x001AD367
		public unsafe bool bHasWorldOrigin
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FGameplayEffectContext.__PropertyOffset_bHasWorldOrigin) & FGameplayEffectContext.__PropertyMask_bHasWorldOrigin) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FGameplayEffectContext.__PropertyOffset_bHasWorldOrigin) = ((*(base.NativePtr + (IntPtr)FGameplayEffectContext.__PropertyOffset_bHasWorldOrigin) & ~FGameplayEffectContext.__PropertyMask_bHasWorldOrigin) | (value ? FGameplayEffectContext.__PropertyMask_bHasWorldOrigin : 0));
			}
		}

		// Token: 0x1700477E RID: 18302
		// (get) Token: 0x0601257B RID: 75131 RVA: 0x001AF197 File Offset: 0x001AD397
		// (set) Token: 0x0601257C RID: 75132 RVA: 0x001AF1B0 File Offset: 0x001AD3B0
		public unsafe bool bReplicateSourceObject
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FGameplayEffectContext.__PropertyOffset_bReplicateSourceObject) & FGameplayEffectContext.__PropertyMask_bReplicateSourceObject) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FGameplayEffectContext.__PropertyOffset_bReplicateSourceObject) = ((*(base.NativePtr + (IntPtr)FGameplayEffectContext.__PropertyOffset_bReplicateSourceObject) & ~FGameplayEffectContext.__PropertyMask_bReplicateSourceObject) | (value ? FGameplayEffectContext.__PropertyMask_bReplicateSourceObject : 0));
			}
		}

		// Token: 0x0601257D RID: 75133 RVA: 0x001AF1E0 File Offset: 0x001AD3E0
		public FGameplayEffectContext()
		{
		}

		// Token: 0x0601257E RID: 75134 RVA: 0x001AF1E8 File Offset: 0x001AD3E8
		public FGameplayEffectContext([Nullable(new byte[]
		{
			0,
			1
		})] TWeakObjectPtr<AActor> Instigator, [Nullable(new byte[]
		{
			0,
			1
		})] TWeakObjectPtr<AActor> EffectCauser, [Nullable(new byte[]
		{
			0,
			1
		})] TWeakObjectPtr<UGameplayAbility> AbilityCDO, [Nullable(new byte[]
		{
			0,
			1
		})] TWeakObjectPtr<UGameplayAbility> AbilityInstanceNotReplicated, int AbilityLevel, [Nullable(new byte[]
		{
			0,
			1
		})] TWeakObjectPtr<UObject> SourceObject, [Nullable(new byte[]
		{
			0,
			1
		})] TWeakObjectPtr<UAbilitySystemComponent> InstigatorAbilitySystemComponent, [Nullable(new byte[]
		{
			1,
			0,
			1
		})] TArray<TWeakObjectPtr<AActor>> Actors, FVector WorldOrigin, bool bHasWorldOrigin, bool bReplicateSourceObject)
		{
			this.Instigator = Instigator;
			this.EffectCauser = EffectCauser;
			this.AbilityCDO = AbilityCDO;
			this.AbilityInstanceNotReplicated = AbilityInstanceNotReplicated;
			this.AbilityLevel = AbilityLevel;
			this.SourceObject = SourceObject;
			this.InstigatorAbilitySystemComponent = InstigatorAbilitySystemComponent;
			this.Actors = Actors;
			this.WorldOrigin = WorldOrigin;
			this.bHasWorldOrigin = bHasWorldOrigin;
			this.bReplicateSourceObject = bReplicateSourceObject;
		}

		// Token: 0x0601257F RID: 75135 RVA: 0x001AF250 File Offset: 0x001AD450
		protected override IntPtr GetUStructPtr()
		{
			return FGameplayEffectContext.StaticStruct();
		}

		// Token: 0x06012580 RID: 75136 RVA: 0x001AF25C File Offset: 0x001AD45C
		[NullableContext(2)]
		public FGameplayEffectContext(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06012581 RID: 75137 RVA: 0x001AF266 File Offset: 0x001AD466
		public FGameplayEffectContext(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06012582 RID: 75138 RVA: 0x001AF271 File Offset: 0x001AD471
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FGameplayEffectContext(Pointer, false, true);
		}

		// Token: 0x06012583 RID: 75139 RVA: 0x001AF27B File Offset: 0x001AD47B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FGameplayEffectContext(Pointer, MemoryOwner);
		}

		// Token: 0x04009D15 RID: 40213
		[Nullable(1)]
		public const string __ObjectPath = "/Script/GameplayAbilities.GameplayEffectContext";

		// Token: 0x04009D16 RID: 40214
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04009D17 RID: 40215
		internal static int __PropertyOffset_Instigator;

		// Token: 0x04009D18 RID: 40216
		internal static int __PropertyOffset_EffectCauser;

		// Token: 0x04009D19 RID: 40217
		internal static int __PropertyOffset_AbilityCDO;

		// Token: 0x04009D1A RID: 40218
		internal static int __PropertyOffset_AbilityInstanceNotReplicated;

		// Token: 0x04009D1B RID: 40219
		internal static int __PropertyOffset_AbilityLevel;

		// Token: 0x04009D1C RID: 40220
		internal static int __PropertyOffset_SourceObject;

		// Token: 0x04009D1D RID: 40221
		internal static int __PropertyOffset_InstigatorAbilitySystemComponent;

		// Token: 0x04009D1E RID: 40222
		internal static int __PropertyOffset_Actors;

		// Token: 0x04009D1F RID: 40223
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TArray<TWeakObjectPtr<AActor>> _Actors;

		// Token: 0x04009D20 RID: 40224
		internal static int __PropertyOffset_WorldOrigin;

		// Token: 0x04009D21 RID: 40225
		internal static int __PropertyOffset_bHasWorldOrigin;

		// Token: 0x04009D22 RID: 40226
		internal static byte __PropertyMask_bHasWorldOrigin;

		// Token: 0x04009D23 RID: 40227
		internal static int __PropertyOffset_bReplicateSourceObject;

		// Token: 0x04009D24 RID: 40228
		internal static byte __PropertyMask_bReplicateSourceObject;
	}
}
