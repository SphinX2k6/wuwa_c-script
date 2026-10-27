using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001358 RID: 4952
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameplayAbilities.GameplayAbilityTargetActor")]
	[UnrealStructLayout(1344, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1344)]
	public abstract class AGameplayAbilityTargetActor : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060122BB RID: 74427 RVA: 0x001AAE13 File Offset: 0x001A9013
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AGameplayAbilityTargetActor._ClassPtr;
		}

		// Token: 0x170046C8 RID: 18120
		// (get) Token: 0x060122BC RID: 74428 RVA: 0x001AAE1F File Offset: 0x001A901F
		// (set) Token: 0x060122BD RID: 74429 RVA: 0x001AAE2F File Offset: 0x001A902F
		public unsafe bool ShouldProduceTargetDataOnServer
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGameplayAbilityTargetActor.__PropertyOffset_ShouldProduceTargetDataOnServer) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGameplayAbilityTargetActor.__PropertyOffset_ShouldProduceTargetDataOnServer) = (value ? 1 : 0);
			}
		}

		// Token: 0x170046C9 RID: 18121
		// (get) Token: 0x060122BE RID: 74430 RVA: 0x001AAE40 File Offset: 0x001A9040
		// (set) Token: 0x060122BF RID: 74431 RVA: 0x001AAE79 File Offset: 0x001A9079
		[Nullable(1)]
		public FGameplayAbilityTargetingLocationInfo StartLocation
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FGameplayAbilityTargetingLocationInfo result;
				if ((result = this._StartLocation) == null)
				{
					result = (this._StartLocation = new FGameplayAbilityTargetingLocationInfo(base.NativePtr + (IntPtr)AGameplayAbilityTargetActor.__PropertyOffset_StartLocation, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAbilityTargetingLocationInfo.StaticStruct(), base.NativePtr + (IntPtr)AGameplayAbilityTargetActor.__PropertyOffset_StartLocation, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170046CA RID: 18122
		// (get) Token: 0x060122C0 RID: 74432 RVA: 0x001AAE9A File Offset: 0x001A909A
		// (set) Token: 0x060122C1 RID: 74433 RVA: 0x001AAEAE File Offset: 0x001A90AE
		public unsafe APlayerController MasterPC
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<APlayerController>(base.NativePtr / (IntPtr)sizeof(void*) + AGameplayAbilityTargetActor.__PropertyOffset_MasterPC);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AGameplayAbilityTargetActor.__PropertyOffset_MasterPC, value);
			}
		}

		// Token: 0x170046CB RID: 18123
		// (get) Token: 0x060122C2 RID: 74434 RVA: 0x001AAEC3 File Offset: 0x001A90C3
		// (set) Token: 0x060122C3 RID: 74435 RVA: 0x001AAED7 File Offset: 0x001A90D7
		public unsafe UGameplayAbility OwningAbility
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UGameplayAbility>(base.NativePtr / (IntPtr)sizeof(void*) + AGameplayAbilityTargetActor.__PropertyOffset_OwningAbility);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AGameplayAbilityTargetActor.__PropertyOffset_OwningAbility, value);
			}
		}

		// Token: 0x170046CC RID: 18124
		// (get) Token: 0x060122C4 RID: 74436 RVA: 0x001AAEEC File Offset: 0x001A90EC
		// (set) Token: 0x060122C5 RID: 74437 RVA: 0x001AAEFC File Offset: 0x001A90FC
		public unsafe bool bDestroyOnConfirmation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGameplayAbilityTargetActor.__PropertyOffset_bDestroyOnConfirmation) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGameplayAbilityTargetActor.__PropertyOffset_bDestroyOnConfirmation) = (value ? 1 : 0);
			}
		}

		// Token: 0x170046CD RID: 18125
		// (get) Token: 0x060122C6 RID: 74438 RVA: 0x001AAF0D File Offset: 0x001A910D
		// (set) Token: 0x060122C7 RID: 74439 RVA: 0x001AAF21 File Offset: 0x001A9121
		public unsafe AActor SourceActor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + AGameplayAbilityTargetActor.__PropertyOffset_SourceActor);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AGameplayAbilityTargetActor.__PropertyOffset_SourceActor, value);
			}
		}

		// Token: 0x170046CE RID: 18126
		// (get) Token: 0x060122C8 RID: 74440 RVA: 0x001AAF38 File Offset: 0x001A9138
		// (set) Token: 0x060122C9 RID: 74441 RVA: 0x001AAF71 File Offset: 0x001A9171
		[Nullable(1)]
		public FWorldReticleParameters ReticleParams
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FWorldReticleParameters result;
				if ((result = this._ReticleParams) == null)
				{
					result = (this._ReticleParams = new FWorldReticleParameters(base.NativePtr + (IntPtr)AGameplayAbilityTargetActor.__PropertyOffset_ReticleParams, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FWorldReticleParameters.StaticStruct(), base.NativePtr + (IntPtr)AGameplayAbilityTargetActor.__PropertyOffset_ReticleParams, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170046CF RID: 18127
		// (get) Token: 0x060122CA RID: 74442 RVA: 0x001AAF92 File Offset: 0x001A9192
		// (set) Token: 0x060122CB RID: 74443 RVA: 0x001AAFA6 File Offset: 0x001A91A6
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<AGameplayAbilityWorldReticle> ReticleClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)AGameplayAbilityTargetActor.__PropertyOffset_ReticleClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)AGameplayAbilityTargetActor.__PropertyOffset_ReticleClass) = value;
			}
		}

		// Token: 0x170046D0 RID: 18128
		// (get) Token: 0x060122CC RID: 74444 RVA: 0x001AAFBC File Offset: 0x001A91BC
		// (set) Token: 0x060122CD RID: 74445 RVA: 0x001AAFF5 File Offset: 0x001A91F5
		[Nullable(1)]
		public FGameplayTargetDataFilterHandle Filter
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FGameplayTargetDataFilterHandle result;
				if ((result = this._Filter) == null)
				{
					result = (this._Filter = new FGameplayTargetDataFilterHandle(base.NativePtr + (IntPtr)AGameplayAbilityTargetActor.__PropertyOffset_Filter, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTargetDataFilterHandle.StaticStruct(), base.NativePtr + (IntPtr)AGameplayAbilityTargetActor.__PropertyOffset_Filter, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170046D1 RID: 18129
		// (get) Token: 0x060122CE RID: 74446 RVA: 0x001AB016 File Offset: 0x001A9216
		// (set) Token: 0x060122CF RID: 74447 RVA: 0x001AB026 File Offset: 0x001A9226
		public unsafe bool bDebug
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGameplayAbilityTargetActor.__PropertyOffset_bDebug) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGameplayAbilityTargetActor.__PropertyOffset_bDebug) = (value ? 1 : 0);
			}
		}

		// Token: 0x170046D2 RID: 18130
		// (get) Token: 0x060122D0 RID: 74448 RVA: 0x001AB037 File Offset: 0x001A9237
		// (set) Token: 0x060122D1 RID: 74449 RVA: 0x001AB04B File Offset: 0x001A924B
		public unsafe UAbilitySystemComponent GenericDelegateBoundASC
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAbilitySystemComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AGameplayAbilityTargetActor.__PropertyOffset_GenericDelegateBoundASC);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AGameplayAbilityTargetActor.__PropertyOffset_GenericDelegateBoundASC, value);
			}
		}

		// Token: 0x060122D2 RID: 74450 RVA: 0x001AB060 File Offset: 0x001A9260
		public void ConfirmTargeting()
		{
			AGameplayAbilityTargetActor.__ConfirmTargeting_Internal(base.NativePtr);
		}

		// Token: 0x060122D3 RID: 74451 RVA: 0x001AB06D File Offset: 0x001A926D
		public void CancelTargeting()
		{
			AGameplayAbilityTargetActor.__CancelTargeting_Internal(base.NativePtr);
		}

		// Token: 0x060122D4 RID: 74452
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ConfirmTargeting_Internal(IntPtr @this);

		// Token: 0x060122D5 RID: 74453
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CancelTargeting_Internal(IntPtr @this);

		// Token: 0x060122D6 RID: 74454 RVA: 0x001AB07A File Offset: 0x001A927A
		static AGameplayAbilityTargetActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GameplayAbilities.GameplayAbilityTargetActor");
		}

		// Token: 0x060122D7 RID: 74455 RVA: 0x001AB088 File Offset: 0x001A9288
		protected AGameplayAbilityTargetActor() : this(BuiltinUtils.AllocNativeUObject(AGameplayAbilityTargetActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060122D8 RID: 74456 RVA: 0x001AB0B0 File Offset: 0x001A92B0
		protected AGameplayAbilityTargetActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04009BBD RID: 39869
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/GameplayAbilities.GameplayAbilityTargetActor";

		// Token: 0x04009BBE RID: 39870
		private static IntPtr _ClassPtr;

		// Token: 0x04009BBF RID: 39871
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04009BC0 RID: 39872
		internal static int __PropertyOffset_ShouldProduceTargetDataOnServer;

		// Token: 0x04009BC1 RID: 39873
		internal static int __PropertyOffset_StartLocation;

		// Token: 0x04009BC2 RID: 39874
		private FGameplayAbilityTargetingLocationInfo _StartLocation;

		// Token: 0x04009BC3 RID: 39875
		internal static int __PropertyOffset_MasterPC;

		// Token: 0x04009BC4 RID: 39876
		internal static int __PropertyOffset_OwningAbility;

		// Token: 0x04009BC5 RID: 39877
		internal static int __PropertyOffset_bDestroyOnConfirmation;

		// Token: 0x04009BC6 RID: 39878
		internal static int __PropertyOffset_SourceActor;

		// Token: 0x04009BC7 RID: 39879
		internal static int __PropertyOffset_ReticleParams;

		// Token: 0x04009BC8 RID: 39880
		private FWorldReticleParameters _ReticleParams;

		// Token: 0x04009BC9 RID: 39881
		internal static int __PropertyOffset_ReticleClass;

		// Token: 0x04009BCA RID: 39882
		internal static int __PropertyOffset_Filter;

		// Token: 0x04009BCB RID: 39883
		private FGameplayTargetDataFilterHandle _Filter;

		// Token: 0x04009BCC RID: 39884
		internal static int __PropertyOffset_bDebug;

		// Token: 0x04009BCD RID: 39885
		internal static int __PropertyOffset_GenericDelegateBoundASC;
	}
}
