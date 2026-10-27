using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001DB6 RID: 7606
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_Shape2D_World")]
	[UnrealStructLayout(432, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 432)]
	public class UKSC_DA_Shape2D_World : UDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D0E9 RID: 119017 RVA: 0x002AF1DA File Offset: 0x002AD3DA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_Shape2D_World._ClassPtr;
		}

		// Token: 0x0601D0EA RID: 119018 RVA: 0x002AF1E8 File Offset: 0x002AD3E8
		public UKSC_DA_Shape2D_World() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Shape2D_World.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D0EB RID: 119019 RVA: 0x002AF210 File Offset: 0x002AD410
		[NullableContext(1)]
		public UKSC_DA_Shape2D_World(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Shape2D_World.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007533 RID: 30003
		// (get) Token: 0x0601D0EC RID: 119020 RVA: 0x002AF243 File Offset: 0x002AD443
		// (set) Token: 0x0601D0ED RID: 119021 RVA: 0x002AF253 File Offset: 0x002AD453
		public unsafe float Gravity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_World.__PropertyOffset_Gravity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_World.__PropertyOffset_Gravity) = value;
			}
		}

		// Token: 0x17007534 RID: 30004
		// (get) Token: 0x0601D0EE RID: 119022 RVA: 0x002AF264 File Offset: 0x002AD464
		// (set) Token: 0x0601D0EF RID: 119023 RVA: 0x002AF278 File Offset: 0x002AD478
		public unsafe FVector2D GravityDir
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_World.__PropertyOffset_GravityDir);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_World.__PropertyOffset_GravityDir) = value;
			}
		}

		// Token: 0x17007535 RID: 30005
		// (get) Token: 0x0601D0F0 RID: 119024 RVA: 0x002AF28D File Offset: 0x002AD48D
		// (set) Token: 0x0601D0F1 RID: 119025 RVA: 0x002AF29D File Offset: 0x002AD49D
		public unsafe float RotateRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_World.__PropertyOffset_RotateRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_World.__PropertyOffset_RotateRange) = value;
			}
		}

		// Token: 0x17007536 RID: 30006
		// (get) Token: 0x0601D0F2 RID: 119026 RVA: 0x002AF2AE File Offset: 0x002AD4AE
		// (set) Token: 0x0601D0F3 RID: 119027 RVA: 0x002AF2BE File Offset: 0x002AD4BE
		public unsafe float RotateDuration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_World.__PropertyOffset_RotateDuration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_World.__PropertyOffset_RotateDuration) = value;
			}
		}

		// Token: 0x17007537 RID: 30007
		// (get) Token: 0x0601D0F4 RID: 119028 RVA: 0x002AF2CF File Offset: 0x002AD4CF
		// (set) Token: 0x0601D0F5 RID: 119029 RVA: 0x002AF2DF File Offset: 0x002AD4DF
		public unsafe float LaunchSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_World.__PropertyOffset_LaunchSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_World.__PropertyOffset_LaunchSpeed) = value;
			}
		}

		// Token: 0x17007538 RID: 30008
		// (get) Token: 0x0601D0F6 RID: 119030 RVA: 0x002AF2F0 File Offset: 0x002AD4F0
		// (set) Token: 0x0601D0F7 RID: 119031 RVA: 0x002AF304 File Offset: 0x002AD504
		public unsafe UCurveFloat DirectionCurve
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Shape2D_World.__PropertyOffset_DirectionCurve);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Shape2D_World.__PropertyOffset_DirectionCurve, value);
			}
		}

		// Token: 0x17007539 RID: 30009
		// (get) Token: 0x0601D0F8 RID: 119032 RVA: 0x002AF319 File Offset: 0x002AD519
		// (set) Token: 0x0601D0F9 RID: 119033 RVA: 0x002AF32D File Offset: 0x002AD52D
		public unsafe UEffectModelBase LaunchHitEffect
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UEffectModelBase>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Shape2D_World.__PropertyOffset_LaunchHitEffect);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Shape2D_World.__PropertyOffset_LaunchHitEffect, value);
			}
		}

		// Token: 0x1700753A RID: 30010
		// (get) Token: 0x0601D0FA RID: 119034 RVA: 0x002AF342 File Offset: 0x002AD542
		// (set) Token: 0x0601D0FB RID: 119035 RVA: 0x002AF356 File Offset: 0x002AD556
		public unsafe UEffectModelBase LaunchHitEffectPower1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UEffectModelBase>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Shape2D_World.__PropertyOffset_LaunchHitEffectPower1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Shape2D_World.__PropertyOffset_LaunchHitEffectPower1, value);
			}
		}

		// Token: 0x1700753B RID: 30011
		// (get) Token: 0x0601D0FC RID: 119036 RVA: 0x002AF36B File Offset: 0x002AD56B
		// (set) Token: 0x0601D0FD RID: 119037 RVA: 0x002AF37F File Offset: 0x002AD57F
		public unsafe UEffectModelBase LaunchHitEffectPower2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UEffectModelBase>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Shape2D_World.__PropertyOffset_LaunchHitEffectPower2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Shape2D_World.__PropertyOffset_LaunchHitEffectPower2, value);
			}
		}

		// Token: 0x1700753C RID: 30012
		// (get) Token: 0x0601D0FE RID: 119038 RVA: 0x002AF394 File Offset: 0x002AD594
		// (set) Token: 0x0601D0FF RID: 119039 RVA: 0x002AF3A8 File Offset: 0x002AD5A8
		public unsafe UEffectModelBase LaunchHitEffectPower3
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UEffectModelBase>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Shape2D_World.__PropertyOffset_LaunchHitEffectPower3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Shape2D_World.__PropertyOffset_LaunchHitEffectPower3, value);
			}
		}

		// Token: 0x1700753D RID: 30013
		// (get) Token: 0x0601D100 RID: 119040 RVA: 0x002AF3BD File Offset: 0x002AD5BD
		// (set) Token: 0x0601D101 RID: 119041 RVA: 0x002AF3D1 File Offset: 0x002AD5D1
		public unsafe FTransform LaunchHitEffectOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_World.__PropertyOffset_LaunchHitEffectOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_World.__PropertyOffset_LaunchHitEffectOffset) = value;
			}
		}

		// Token: 0x1700753E RID: 30014
		// (get) Token: 0x0601D102 RID: 119042 RVA: 0x002AF3E6 File Offset: 0x002AD5E6
		// (set) Token: 0x0601D103 RID: 119043 RVA: 0x002AF3FA File Offset: 0x002AD5FA
		public unsafe FVector2D InitLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_World.__PropertyOffset_InitLocation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_World.__PropertyOffset_InitLocation) = value;
			}
		}

		// Token: 0x1700753F RID: 30015
		// (get) Token: 0x0601D104 RID: 119044 RVA: 0x002AF40F File Offset: 0x002AD60F
		// (set) Token: 0x0601D105 RID: 119045 RVA: 0x002AF41F File Offset: 0x002AD61F
		public unsafe float MoveDelaySeconds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_World.__PropertyOffset_MoveDelaySeconds);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_World.__PropertyOffset_MoveDelaySeconds) = value;
			}
		}

		// Token: 0x17007540 RID: 30016
		// (get) Token: 0x0601D106 RID: 119046 RVA: 0x002AF430 File Offset: 0x002AD630
		// (set) Token: 0x0601D107 RID: 119047 RVA: 0x002AF440 File Offset: 0x002AD640
		public unsafe float MoveDelayMaxDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_World.__PropertyOffset_MoveDelayMaxDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_World.__PropertyOffset_MoveDelayMaxDistance) = value;
			}
		}

		// Token: 0x17007541 RID: 30017
		// (get) Token: 0x0601D108 RID: 119048 RVA: 0x002AF451 File Offset: 0x002AD651
		// (set) Token: 0x0601D109 RID: 119049 RVA: 0x002AF461 File Offset: 0x002AD661
		public unsafe float MoveMaxDistanceNeedSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_World.__PropertyOffset_MoveMaxDistanceNeedSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_World.__PropertyOffset_MoveMaxDistanceNeedSpeed) = value;
			}
		}

		// Token: 0x17007542 RID: 30018
		// (get) Token: 0x0601D10A RID: 119050 RVA: 0x002AF472 File Offset: 0x002AD672
		// (set) Token: 0x0601D10B RID: 119051 RVA: 0x002AF482 File Offset: 0x002AD682
		public unsafe float MoveDistanceInertialSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_World.__PropertyOffset_MoveDistanceInertialSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_World.__PropertyOffset_MoveDistanceInertialSpeed) = value;
			}
		}

		// Token: 0x17007543 RID: 30019
		// (get) Token: 0x0601D10C RID: 119052 RVA: 0x002AF493 File Offset: 0x002AD693
		// (set) Token: 0x0601D10D RID: 119053 RVA: 0x002AF4A3 File Offset: 0x002AD6A3
		public unsafe long CollisionDamageId0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_World.__PropertyOffset_CollisionDamageId0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_World.__PropertyOffset_CollisionDamageId0) = value;
			}
		}

		// Token: 0x17007544 RID: 30020
		// (get) Token: 0x0601D10E RID: 119054 RVA: 0x002AF4B4 File Offset: 0x002AD6B4
		// (set) Token: 0x0601D10F RID: 119055 RVA: 0x002AF4C4 File Offset: 0x002AD6C4
		public unsafe long CollisionDamageId1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_World.__PropertyOffset_CollisionDamageId1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_World.__PropertyOffset_CollisionDamageId1) = value;
			}
		}

		// Token: 0x17007545 RID: 30021
		// (get) Token: 0x0601D110 RID: 119056 RVA: 0x002AF4D5 File Offset: 0x002AD6D5
		// (set) Token: 0x0601D111 RID: 119057 RVA: 0x002AF4E5 File Offset: 0x002AD6E5
		public unsafe long CollisionDamageId2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_World.__PropertyOffset_CollisionDamageId2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_World.__PropertyOffset_CollisionDamageId2) = value;
			}
		}

		// Token: 0x17007546 RID: 30022
		// (get) Token: 0x0601D112 RID: 119058 RVA: 0x002AF4F6 File Offset: 0x002AD6F6
		// (set) Token: 0x0601D113 RID: 119059 RVA: 0x002AF506 File Offset: 0x002AD706
		public unsafe long CollisionDamageId3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_World.__PropertyOffset_CollisionDamageId3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_World.__PropertyOffset_CollisionDamageId3) = value;
			}
		}

		// Token: 0x17007547 RID: 30023
		// (get) Token: 0x0601D114 RID: 119060 RVA: 0x002AF517 File Offset: 0x002AD717
		// (set) Token: 0x0601D115 RID: 119061 RVA: 0x002AF52B File Offset: 0x002AD72B
		public unsafe FGameplayTag PowerCollisionTag1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_World.__PropertyOffset_PowerCollisionTag1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_World.__PropertyOffset_PowerCollisionTag1) = value;
			}
		}

		// Token: 0x17007548 RID: 30024
		// (get) Token: 0x0601D116 RID: 119062 RVA: 0x002AF540 File Offset: 0x002AD740
		// (set) Token: 0x0601D117 RID: 119063 RVA: 0x002AF554 File Offset: 0x002AD754
		public unsafe FGameplayTag PowerCollisionTag2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_World.__PropertyOffset_PowerCollisionTag2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_World.__PropertyOffset_PowerCollisionTag2) = value;
			}
		}

		// Token: 0x17007549 RID: 30025
		// (get) Token: 0x0601D118 RID: 119064 RVA: 0x002AF569 File Offset: 0x002AD769
		// (set) Token: 0x0601D119 RID: 119065 RVA: 0x002AF57D File Offset: 0x002AD77D
		public unsafe FGameplayTag PowerCollisionTag3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_World.__PropertyOffset_PowerCollisionTag3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_World.__PropertyOffset_PowerCollisionTag3) = value;
			}
		}

		// Token: 0x1700754A RID: 30026
		// (get) Token: 0x0601D11A RID: 119066 RVA: 0x002AF592 File Offset: 0x002AD792
		// (set) Token: 0x0601D11B RID: 119067 RVA: 0x002AF5A6 File Offset: 0x002AD7A6
		public unsafe UKSC_DA_Buff PowerCollisionBuff1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_Buff>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Shape2D_World.__PropertyOffset_PowerCollisionBuff1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Shape2D_World.__PropertyOffset_PowerCollisionBuff1, value);
			}
		}

		// Token: 0x1700754B RID: 30027
		// (get) Token: 0x0601D11C RID: 119068 RVA: 0x002AF5BB File Offset: 0x002AD7BB
		// (set) Token: 0x0601D11D RID: 119069 RVA: 0x002AF5CF File Offset: 0x002AD7CF
		public unsafe UKSC_DA_Buff PowerCollisionBuff2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_Buff>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Shape2D_World.__PropertyOffset_PowerCollisionBuff2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Shape2D_World.__PropertyOffset_PowerCollisionBuff2, value);
			}
		}

		// Token: 0x1700754C RID: 30028
		// (get) Token: 0x0601D11E RID: 119070 RVA: 0x002AF5E4 File Offset: 0x002AD7E4
		// (set) Token: 0x0601D11F RID: 119071 RVA: 0x002AF5F8 File Offset: 0x002AD7F8
		public unsafe UKSC_DA_Buff PowerCollisionBuff3
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_Buff>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Shape2D_World.__PropertyOffset_PowerCollisionBuff3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Shape2D_World.__PropertyOffset_PowerCollisionBuff3, value);
			}
		}

		// Token: 0x1700754D RID: 30029
		// (get) Token: 0x0601D120 RID: 119072 RVA: 0x002AF60D File Offset: 0x002AD80D
		// (set) Token: 0x0601D121 RID: 119073 RVA: 0x002AF621 File Offset: 0x002AD821
		public unsafe UEffectModelBase CollisionDamageEffect0
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UEffectModelBase>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Shape2D_World.__PropertyOffset_CollisionDamageEffect0);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Shape2D_World.__PropertyOffset_CollisionDamageEffect0, value);
			}
		}

		// Token: 0x1700754E RID: 30030
		// (get) Token: 0x0601D122 RID: 119074 RVA: 0x002AF636 File Offset: 0x002AD836
		// (set) Token: 0x0601D123 RID: 119075 RVA: 0x002AF64A File Offset: 0x002AD84A
		public unsafe UEffectModelBase CollisionDamageEffect1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UEffectModelBase>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Shape2D_World.__PropertyOffset_CollisionDamageEffect1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Shape2D_World.__PropertyOffset_CollisionDamageEffect1, value);
			}
		}

		// Token: 0x1700754F RID: 30031
		// (get) Token: 0x0601D124 RID: 119076 RVA: 0x002AF65F File Offset: 0x002AD85F
		// (set) Token: 0x0601D125 RID: 119077 RVA: 0x002AF673 File Offset: 0x002AD873
		public unsafe UEffectModelBase CollisionDamageEffect2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UEffectModelBase>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Shape2D_World.__PropertyOffset_CollisionDamageEffect2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Shape2D_World.__PropertyOffset_CollisionDamageEffect2, value);
			}
		}

		// Token: 0x17007550 RID: 30032
		// (get) Token: 0x0601D126 RID: 119078 RVA: 0x002AF688 File Offset: 0x002AD888
		// (set) Token: 0x0601D127 RID: 119079 RVA: 0x002AF69C File Offset: 0x002AD89C
		public unsafe UEffectModelBase CollisionDamageEffect3
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UEffectModelBase>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Shape2D_World.__PropertyOffset_CollisionDamageEffect3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Shape2D_World.__PropertyOffset_CollisionDamageEffect3, value);
			}
		}

		// Token: 0x17007551 RID: 30033
		// (get) Token: 0x0601D128 RID: 119080 RVA: 0x002AF6B1 File Offset: 0x002AD8B1
		// (set) Token: 0x0601D129 RID: 119081 RVA: 0x002AF6C1 File Offset: 0x002AD8C1
		public unsafe byte CollisionDamageEffectMaxCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_World.__PropertyOffset_CollisionDamageEffectMaxCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_World.__PropertyOffset_CollisionDamageEffectMaxCount) = value;
			}
		}

		// Token: 0x17007552 RID: 30034
		// (get) Token: 0x0601D12A RID: 119082 RVA: 0x002AF6D2 File Offset: 0x002AD8D2
		// (set) Token: 0x0601D12B RID: 119083 RVA: 0x002AF6E2 File Offset: 0x002AD8E2
		public unsafe int PowerCollisionCount1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_World.__PropertyOffset_PowerCollisionCount1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_World.__PropertyOffset_PowerCollisionCount1) = value;
			}
		}

		// Token: 0x17007553 RID: 30035
		// (get) Token: 0x0601D12C RID: 119084 RVA: 0x002AF6F3 File Offset: 0x002AD8F3
		// (set) Token: 0x0601D12D RID: 119085 RVA: 0x002AF703 File Offset: 0x002AD903
		public unsafe int PowerCollisionCount2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_World.__PropertyOffset_PowerCollisionCount2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_World.__PropertyOffset_PowerCollisionCount2) = value;
			}
		}

		// Token: 0x17007554 RID: 30036
		// (get) Token: 0x0601D12E RID: 119086 RVA: 0x002AF714 File Offset: 0x002AD914
		// (set) Token: 0x0601D12F RID: 119087 RVA: 0x002AF724 File Offset: 0x002AD924
		public unsafe int PowerCollisionCount3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_World.__PropertyOffset_PowerCollisionCount3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_World.__PropertyOffset_PowerCollisionCount3) = value;
			}
		}

		// Token: 0x17007555 RID: 30037
		// (get) Token: 0x0601D130 RID: 119088 RVA: 0x002AF735 File Offset: 0x002AD935
		// (set) Token: 0x0601D131 RID: 119089 RVA: 0x002AF745 File Offset: 0x002AD945
		public unsafe float RecoverSprintEnergy
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_World.__PropertyOffset_RecoverSprintEnergy);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_World.__PropertyOffset_RecoverSprintEnergy) = value;
			}
		}

		// Token: 0x17007556 RID: 30038
		// (get) Token: 0x0601D132 RID: 119090 RVA: 0x002AF756 File Offset: 0x002AD956
		// (set) Token: 0x0601D133 RID: 119091 RVA: 0x002AF766 File Offset: 0x002AD966
		public unsafe float RecoverSprintEnergyCD
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_World.__PropertyOffset_RecoverSprintEnergyCD);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_World.__PropertyOffset_RecoverSprintEnergyCD) = value;
			}
		}

		// Token: 0x17007557 RID: 30039
		// (get) Token: 0x0601D134 RID: 119092 RVA: 0x002AF777 File Offset: 0x002AD977
		// (set) Token: 0x0601D135 RID: 119093 RVA: 0x002AF787 File Offset: 0x002AD987
		public unsafe float CollisionDamageCD
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_World.__PropertyOffset_CollisionDamageCD);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_World.__PropertyOffset_CollisionDamageCD) = value;
			}
		}

		// Token: 0x17007558 RID: 30040
		// (get) Token: 0x0601D136 RID: 119094 RVA: 0x002AF798 File Offset: 0x002AD998
		// (set) Token: 0x0601D137 RID: 119095 RVA: 0x002AF7A8 File Offset: 0x002AD9A8
		public unsafe float CollisionDamageCDInIgnore
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_World.__PropertyOffset_CollisionDamageCDInIgnore);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_World.__PropertyOffset_CollisionDamageCDInIgnore) = value;
			}
		}

		// Token: 0x17007559 RID: 30041
		// (get) Token: 0x0601D138 RID: 119096 RVA: 0x002AF7B9 File Offset: 0x002AD9B9
		// (set) Token: 0x0601D139 RID: 119097 RVA: 0x002AF7CD File Offset: 0x002AD9CD
		public unsafe FGameplayTag DisableCollisionDamageTag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_World.__PropertyOffset_DisableCollisionDamageTag);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_World.__PropertyOffset_DisableCollisionDamageTag) = value;
			}
		}

		// Token: 0x1700755A RID: 30042
		// (get) Token: 0x0601D13A RID: 119098 RVA: 0x002AF7E2 File Offset: 0x002AD9E2
		// (set) Token: 0x0601D13B RID: 119099 RVA: 0x002AF7F6 File Offset: 0x002AD9F6
		public unsafe FGameplayTag DeadTag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_World.__PropertyOffset_DeadTag);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_World.__PropertyOffset_DeadTag) = value;
			}
		}

		// Token: 0x1700755B RID: 30043
		// (get) Token: 0x0601D13C RID: 119100 RVA: 0x002AF80B File Offset: 0x002ADA0B
		// (set) Token: 0x0601D13D RID: 119101 RVA: 0x002AF81F File Offset: 0x002ADA1F
		public unsafe FLinearColor PlayerBeHitColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_World.__PropertyOffset_PlayerBeHitColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_World.__PropertyOffset_PlayerBeHitColor) = value;
			}
		}

		// Token: 0x1700755C RID: 30044
		// (get) Token: 0x0601D13E RID: 119102 RVA: 0x002AF834 File Offset: 0x002ADA34
		// (set) Token: 0x0601D13F RID: 119103 RVA: 0x002AF844 File Offset: 0x002ADA44
		public unsafe float PlayerBeHitColorCD
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_World.__PropertyOffset_PlayerBeHitColorCD);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_World.__PropertyOffset_PlayerBeHitColorCD) = value;
			}
		}

		// Token: 0x1700755D RID: 30045
		// (get) Token: 0x0601D140 RID: 119104 RVA: 0x002AF855 File Offset: 0x002ADA55
		// (set) Token: 0x0601D141 RID: 119105 RVA: 0x002AF869 File Offset: 0x002ADA69
		public unsafe FLinearColor EnemyBeHitColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_World.__PropertyOffset_EnemyBeHitColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_World.__PropertyOffset_EnemyBeHitColor) = value;
			}
		}

		// Token: 0x1700755E RID: 30046
		// (get) Token: 0x0601D142 RID: 119106 RVA: 0x002AF87E File Offset: 0x002ADA7E
		// (set) Token: 0x0601D143 RID: 119107 RVA: 0x002AF88E File Offset: 0x002ADA8E
		public unsafe float EnemyBeHitColorCD
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_World.__PropertyOffset_EnemyBeHitColorCD);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_World.__PropertyOffset_EnemyBeHitColorCD) = value;
			}
		}

		// Token: 0x1700755F RID: 30047
		// (get) Token: 0x0601D144 RID: 119108 RVA: 0x002AF89F File Offset: 0x002ADA9F
		// (set) Token: 0x0601D145 RID: 119109 RVA: 0x002AF8AF File Offset: 0x002ADAAF
		public unsafe float BeHitColorDuration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_World.__PropertyOffset_BeHitColorDuration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_World.__PropertyOffset_BeHitColorDuration) = value;
			}
		}

		// Token: 0x0601D146 RID: 119110 RVA: 0x002AF8C0 File Offset: 0x002ADAC0
		static UKSC_DA_Shape2D_World()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_Shape2D_World");
		}

		// Token: 0x0601D147 RID: 119111 RVA: 0x002AF8CE File Offset: 0x002ADACE
		protected UKSC_DA_Shape2D_World(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FC65 RID: 64613
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_Shape2D_World";

		// Token: 0x0400FC66 RID: 64614
		private static IntPtr _ClassPtr;

		// Token: 0x0400FC67 RID: 64615
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FC68 RID: 64616
		internal static int __PropertyOffset_Gravity;

		// Token: 0x0400FC69 RID: 64617
		internal static int __PropertyOffset_GravityDir;

		// Token: 0x0400FC6A RID: 64618
		internal static int __PropertyOffset_RotateRange;

		// Token: 0x0400FC6B RID: 64619
		internal static int __PropertyOffset_RotateDuration;

		// Token: 0x0400FC6C RID: 64620
		internal static int __PropertyOffset_LaunchSpeed;

		// Token: 0x0400FC6D RID: 64621
		internal static int __PropertyOffset_DirectionCurve;

		// Token: 0x0400FC6E RID: 64622
		internal static int __PropertyOffset_LaunchHitEffect;

		// Token: 0x0400FC6F RID: 64623
		internal static int __PropertyOffset_LaunchHitEffectPower1;

		// Token: 0x0400FC70 RID: 64624
		internal static int __PropertyOffset_LaunchHitEffectPower2;

		// Token: 0x0400FC71 RID: 64625
		internal static int __PropertyOffset_LaunchHitEffectPower3;

		// Token: 0x0400FC72 RID: 64626
		internal static int __PropertyOffset_LaunchHitEffectOffset;

		// Token: 0x0400FC73 RID: 64627
		internal static int __PropertyOffset_InitLocation;

		// Token: 0x0400FC74 RID: 64628
		internal static int __PropertyOffset_MoveDelaySeconds;

		// Token: 0x0400FC75 RID: 64629
		internal static int __PropertyOffset_MoveDelayMaxDistance;

		// Token: 0x0400FC76 RID: 64630
		internal static int __PropertyOffset_MoveMaxDistanceNeedSpeed;

		// Token: 0x0400FC77 RID: 64631
		internal static int __PropertyOffset_MoveDistanceInertialSpeed;

		// Token: 0x0400FC78 RID: 64632
		internal static int __PropertyOffset_CollisionDamageId0;

		// Token: 0x0400FC79 RID: 64633
		internal static int __PropertyOffset_CollisionDamageId1;

		// Token: 0x0400FC7A RID: 64634
		internal static int __PropertyOffset_CollisionDamageId2;

		// Token: 0x0400FC7B RID: 64635
		internal static int __PropertyOffset_CollisionDamageId3;

		// Token: 0x0400FC7C RID: 64636
		internal static int __PropertyOffset_PowerCollisionTag1;

		// Token: 0x0400FC7D RID: 64637
		internal static int __PropertyOffset_PowerCollisionTag2;

		// Token: 0x0400FC7E RID: 64638
		internal static int __PropertyOffset_PowerCollisionTag3;

		// Token: 0x0400FC7F RID: 64639
		internal static int __PropertyOffset_PowerCollisionBuff1;

		// Token: 0x0400FC80 RID: 64640
		internal static int __PropertyOffset_PowerCollisionBuff2;

		// Token: 0x0400FC81 RID: 64641
		internal static int __PropertyOffset_PowerCollisionBuff3;

		// Token: 0x0400FC82 RID: 64642
		internal static int __PropertyOffset_CollisionDamageEffect0;

		// Token: 0x0400FC83 RID: 64643
		internal static int __PropertyOffset_CollisionDamageEffect1;

		// Token: 0x0400FC84 RID: 64644
		internal static int __PropertyOffset_CollisionDamageEffect2;

		// Token: 0x0400FC85 RID: 64645
		internal static int __PropertyOffset_CollisionDamageEffect3;

		// Token: 0x0400FC86 RID: 64646
		internal static int __PropertyOffset_CollisionDamageEffectMaxCount;

		// Token: 0x0400FC87 RID: 64647
		internal static int __PropertyOffset_PowerCollisionCount1;

		// Token: 0x0400FC88 RID: 64648
		internal static int __PropertyOffset_PowerCollisionCount2;

		// Token: 0x0400FC89 RID: 64649
		internal static int __PropertyOffset_PowerCollisionCount3;

		// Token: 0x0400FC8A RID: 64650
		internal static int __PropertyOffset_RecoverSprintEnergy;

		// Token: 0x0400FC8B RID: 64651
		internal static int __PropertyOffset_RecoverSprintEnergyCD;

		// Token: 0x0400FC8C RID: 64652
		internal static int __PropertyOffset_CollisionDamageCD;

		// Token: 0x0400FC8D RID: 64653
		internal static int __PropertyOffset_CollisionDamageCDInIgnore;

		// Token: 0x0400FC8E RID: 64654
		internal static int __PropertyOffset_DisableCollisionDamageTag;

		// Token: 0x0400FC8F RID: 64655
		internal static int __PropertyOffset_DeadTag;

		// Token: 0x0400FC90 RID: 64656
		internal static int __PropertyOffset_PlayerBeHitColor;

		// Token: 0x0400FC91 RID: 64657
		internal static int __PropertyOffset_PlayerBeHitColorCD;

		// Token: 0x0400FC92 RID: 64658
		internal static int __PropertyOffset_EnemyBeHitColor;

		// Token: 0x0400FC93 RID: 64659
		internal static int __PropertyOffset_EnemyBeHitColorCD;

		// Token: 0x0400FC94 RID: 64660
		internal static int __PropertyOffset_BeHitColorDuration;
	}
}
