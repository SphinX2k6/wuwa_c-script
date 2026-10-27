using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001E55 RID: 7765
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_SpineAnimNotify")]
	[UnrealStructLayout(320, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 320)]
	public class FKSC_SpineAnimNotify : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601D8E3 RID: 121059 RVA: 0x002BA38C File Offset: 0x002B858C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKSC_SpineAnimNotify._ScriptStructPtr != 0) ? FKSC_SpineAnimNotify._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroSimpleCombat.KSC_SpineAnimNotify", ref FKSC_SpineAnimNotify._ScriptStructPtr);
		}

		// Token: 0x17007708 RID: 30472
		// (get) Token: 0x0601D8E4 RID: 121060 RVA: 0x002BA3B0 File Offset: 0x002B85B0
		// (set) Token: 0x0601D8E5 RID: 121061 RVA: 0x002BA3C0 File Offset: 0x002B85C0
		public unsafe float Time
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSC_SpineAnimNotify.__PropertyOffset_Time);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_SpineAnimNotify.__PropertyOffset_Time) = value;
			}
		}

		// Token: 0x17007709 RID: 30473
		// (get) Token: 0x0601D8E6 RID: 121062 RVA: 0x002BA3D1 File Offset: 0x002B85D1
		// (set) Token: 0x0601D8E7 RID: 121063 RVA: 0x002BA3E1 File Offset: 0x002B85E1
		public unsafe bool IsUseFullTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSC_SpineAnimNotify.__PropertyOffset_IsUseFullTime) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_SpineAnimNotify.__PropertyOffset_IsUseFullTime) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700770A RID: 30474
		// (get) Token: 0x0601D8E8 RID: 121064 RVA: 0x002BA3F2 File Offset: 0x002B85F2
		// (set) Token: 0x0601D8E9 RID: 121065 RVA: 0x002BA402 File Offset: 0x002B8602
		public unsafe bool IsTriggerOnce
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSC_SpineAnimNotify.__PropertyOffset_IsTriggerOnce) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_SpineAnimNotify.__PropertyOffset_IsTriggerOnce) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700770B RID: 30475
		// (get) Token: 0x0601D8EA RID: 121066 RVA: 0x002BA413 File Offset: 0x002B8613
		// (set) Token: 0x0601D8EB RID: 121067 RVA: 0x002BA423 File Offset: 0x002B8623
		public unsafe bool IsUseCurrentPlayer
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSC_SpineAnimNotify.__PropertyOffset_IsUseCurrentPlayer) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_SpineAnimNotify.__PropertyOffset_IsUseCurrentPlayer) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700770C RID: 30476
		// (get) Token: 0x0601D8EC RID: 121068 RVA: 0x002BA434 File Offset: 0x002B8634
		// (set) Token: 0x0601D8ED RID: 121069 RVA: 0x002BA444 File Offset: 0x002B8644
		public unsafe EKSC_SpineAnimNotifyType Type
		{
			get
			{
				return (EKSC_SpineAnimNotifyType)(*(base.NativePtr + (IntPtr)FKSC_SpineAnimNotify.__PropertyOffset_Type));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_SpineAnimNotify.__PropertyOffset_Type) = (byte)value;
			}
		}

		// Token: 0x1700770D RID: 30477
		// (get) Token: 0x0601D8EE RID: 121070 RVA: 0x002BA455 File Offset: 0x002B8655
		// (set) Token: 0x0601D8EF RID: 121071 RVA: 0x002BA469 File Offset: 0x002B8669
		public unsafe FGameplayTag Tag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSC_SpineAnimNotify.__PropertyOffset_Tag);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_SpineAnimNotify.__PropertyOffset_Tag) = value;
			}
		}

		// Token: 0x1700770E RID: 30478
		// (get) Token: 0x0601D8F0 RID: 121072 RVA: 0x002BA47E File Offset: 0x002B867E
		// (set) Token: 0x0601D8F1 RID: 121073 RVA: 0x002BA492 File Offset: 0x002B8692
		public unsafe UKSC_DA_Buff Buff
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_Buff>(base.NativePtr / (IntPtr)sizeof(void*) + FKSC_SpineAnimNotify.__PropertyOffset_Buff);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FKSC_SpineAnimNotify.__PropertyOffset_Buff, value);
			}
		}

		// Token: 0x1700770F RID: 30479
		// (get) Token: 0x0601D8F2 RID: 121074 RVA: 0x002BA4A7 File Offset: 0x002B86A7
		// (set) Token: 0x0601D8F3 RID: 121075 RVA: 0x002BA4B7 File Offset: 0x002B86B7
		public unsafe int BuffStackNum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSC_SpineAnimNotify.__PropertyOffset_BuffStackNum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_SpineAnimNotify.__PropertyOffset_BuffStackNum) = value;
			}
		}

		// Token: 0x17007710 RID: 30480
		// (get) Token: 0x0601D8F4 RID: 121076 RVA: 0x002BA4C8 File Offset: 0x002B86C8
		// (set) Token: 0x0601D8F5 RID: 121077 RVA: 0x002BA4D8 File Offset: 0x002B86D8
		public unsafe EKSC_Shape2D_SelectTarget SelectTarget
		{
			get
			{
				return (EKSC_Shape2D_SelectTarget)(*(base.NativePtr + (IntPtr)FKSC_SpineAnimNotify.__PropertyOffset_SelectTarget));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_SpineAnimNotify.__PropertyOffset_SelectTarget) = (byte)value;
			}
		}

		// Token: 0x17007711 RID: 30481
		// (get) Token: 0x0601D8F6 RID: 121078 RVA: 0x002BA4E9 File Offset: 0x002B86E9
		// (set) Token: 0x0601D8F7 RID: 121079 RVA: 0x002BA4F9 File Offset: 0x002B86F9
		public unsafe int BulletID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSC_SpineAnimNotify.__PropertyOffset_BulletID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_SpineAnimNotify.__PropertyOffset_BulletID) = value;
			}
		}

		// Token: 0x17007712 RID: 30482
		// (get) Token: 0x0601D8F8 RID: 121080 RVA: 0x002BA50A File Offset: 0x002B870A
		// (set) Token: 0x0601D8F9 RID: 121081 RVA: 0x002BA51A File Offset: 0x002B871A
		public unsafe bool IsUseBulletDefaultRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSC_SpineAnimNotify.__PropertyOffset_IsUseBulletDefaultRotation) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_SpineAnimNotify.__PropertyOffset_IsUseBulletDefaultRotation) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007713 RID: 30483
		// (get) Token: 0x0601D8FA RID: 121082 RVA: 0x002BA52B File Offset: 0x002B872B
		// (set) Token: 0x0601D8FB RID: 121083 RVA: 0x002BA53F File Offset: 0x002B873F
		public unsafe FRotator BulletDefaultRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSC_SpineAnimNotify.__PropertyOffset_BulletDefaultRotation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_SpineAnimNotify.__PropertyOffset_BulletDefaultRotation) = value;
			}
		}

		// Token: 0x17007714 RID: 30484
		// (get) Token: 0x0601D8FC RID: 121084 RVA: 0x002BA554 File Offset: 0x002B8754
		// (set) Token: 0x0601D8FD RID: 121085 RVA: 0x002BA568 File Offset: 0x002B8768
		public unsafe UEffectModelBase Effect
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UEffectModelBase>(base.NativePtr / (IntPtr)sizeof(void*) + FKSC_SpineAnimNotify.__PropertyOffset_Effect);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FKSC_SpineAnimNotify.__PropertyOffset_Effect, value);
			}
		}

		// Token: 0x17007715 RID: 30485
		// (get) Token: 0x0601D8FE RID: 121086 RVA: 0x002BA57D File Offset: 0x002B877D
		// (set) Token: 0x0601D8FF RID: 121087 RVA: 0x002BA591 File Offset: 0x002B8791
		public unsafe FTransform EffectOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSC_SpineAnimNotify.__PropertyOffset_EffectOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_SpineAnimNotify.__PropertyOffset_EffectOffset) = value;
			}
		}

		// Token: 0x17007716 RID: 30486
		// (get) Token: 0x0601D900 RID: 121088 RVA: 0x002BA5A6 File Offset: 0x002B87A6
		// (set) Token: 0x0601D901 RID: 121089 RVA: 0x002BA5B6 File Offset: 0x002B87B6
		public unsafe float SearchRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSC_SpineAnimNotify.__PropertyOffset_SearchRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_SpineAnimNotify.__PropertyOffset_SearchRange) = value;
			}
		}

		// Token: 0x17007717 RID: 30487
		// (get) Token: 0x0601D902 RID: 121090 RVA: 0x002BA5C8 File Offset: 0x002B87C8
		// (set) Token: 0x0601D903 RID: 121091 RVA: 0x002BA60B File Offset: 0x002B880B
		[Nullable(1)]
		public TMap<EKSC_EntityType, int> SearchPriorityMap
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<EKSC_EntityType, int> result;
				if ((result = this._SearchPriorityMap) == null)
				{
					result = (this._SearchPriorityMap = new TMap<EKSC_EntityType, int>(base.NativePtr + (IntPtr)FKSC_SpineAnimNotify.__PropertyOffset_SearchPriorityMap, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.SearchPriorityMap.CopyAssign(value);
			}
		}

		// Token: 0x17007718 RID: 30488
		// (get) Token: 0x0601D904 RID: 121092 RVA: 0x002BA619 File Offset: 0x002B8819
		// (set) Token: 0x0601D905 RID: 121093 RVA: 0x002BA629 File Offset: 0x002B8829
		public unsafe EKSC_Shape2D_CustomMovementMode MovementMode
		{
			get
			{
				return (EKSC_Shape2D_CustomMovementMode)(*(base.NativePtr + (IntPtr)FKSC_SpineAnimNotify.__PropertyOffset_MovementMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_SpineAnimNotify.__PropertyOffset_MovementMode) = (byte)value;
			}
		}

		// Token: 0x17007719 RID: 30489
		// (get) Token: 0x0601D906 RID: 121094 RVA: 0x002BA63A File Offset: 0x002B883A
		// (set) Token: 0x0601D907 RID: 121095 RVA: 0x002BA64A File Offset: 0x002B884A
		public unsafe float MovementDuration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSC_SpineAnimNotify.__PropertyOffset_MovementDuration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_SpineAnimNotify.__PropertyOffset_MovementDuration) = value;
			}
		}

		// Token: 0x1700771A RID: 30490
		// (get) Token: 0x0601D908 RID: 121096 RVA: 0x002BA65B File Offset: 0x002B885B
		// (set) Token: 0x0601D909 RID: 121097 RVA: 0x002BA66B File Offset: 0x002B886B
		public unsafe float MovementDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSC_SpineAnimNotify.__PropertyOffset_MovementDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_SpineAnimNotify.__PropertyOffset_MovementDistance) = value;
			}
		}

		// Token: 0x1700771B RID: 30491
		// (get) Token: 0x0601D90A RID: 121098 RVA: 0x002BA67C File Offset: 0x002B887C
		// (set) Token: 0x0601D90B RID: 121099 RVA: 0x002BA68C File Offset: 0x002B888C
		public unsafe float MovementEndDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSC_SpineAnimNotify.__PropertyOffset_MovementEndDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_SpineAnimNotify.__PropertyOffset_MovementEndDistance) = value;
			}
		}

		// Token: 0x1700771C RID: 30492
		// (get) Token: 0x0601D90C RID: 121100 RVA: 0x002BA69D File Offset: 0x002B889D
		// (set) Token: 0x0601D90D RID: 121101 RVA: 0x002BA6B1 File Offset: 0x002B88B1
		public unsafe UCurveFloat MovementCurve
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + FKSC_SpineAnimNotify.__PropertyOffset_MovementCurve);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FKSC_SpineAnimNotify.__PropertyOffset_MovementCurve, value);
			}
		}

		// Token: 0x1700771D RID: 30493
		// (get) Token: 0x0601D90E RID: 121102 RVA: 0x002BA6C6 File Offset: 0x002B88C6
		// (set) Token: 0x0601D90F RID: 121103 RVA: 0x002BA6D6 File Offset: 0x002B88D6
		public unsafe bool MovementIsTrace
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSC_SpineAnimNotify.__PropertyOffset_MovementIsTrace) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_SpineAnimNotify.__PropertyOffset_MovementIsTrace) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700771E RID: 30494
		// (get) Token: 0x0601D910 RID: 121104 RVA: 0x002BA6E7 File Offset: 0x002B88E7
		// (set) Token: 0x0601D911 RID: 121105 RVA: 0x002BA6F7 File Offset: 0x002B88F7
		public unsafe bool MovementIsKeep
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSC_SpineAnimNotify.__PropertyOffset_MovementIsKeep) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_SpineAnimNotify.__PropertyOffset_MovementIsKeep) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700771F RID: 30495
		// (get) Token: 0x0601D912 RID: 121106 RVA: 0x002BA708 File Offset: 0x002B8908
		// (set) Token: 0x0601D913 RID: 121107 RVA: 0x002BA718 File Offset: 0x002B8918
		public unsafe bool MovementIsKeepEnd
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSC_SpineAnimNotify.__PropertyOffset_MovementIsKeepEnd) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_SpineAnimNotify.__PropertyOffset_MovementIsKeepEnd) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007720 RID: 30496
		// (get) Token: 0x0601D914 RID: 121108 RVA: 0x002BA729 File Offset: 0x002B8929
		// (set) Token: 0x0601D915 RID: 121109 RVA: 0x002BA739 File Offset: 0x002B8939
		public unsafe float MoveRangeLimitRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSC_SpineAnimNotify.__PropertyOffset_MoveRangeLimitRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_SpineAnimNotify.__PropertyOffset_MoveRangeLimitRadius) = value;
			}
		}

		// Token: 0x17007721 RID: 30497
		// (get) Token: 0x0601D916 RID: 121110 RVA: 0x002BA74A File Offset: 0x002B894A
		// (set) Token: 0x0601D917 RID: 121111 RVA: 0x002BA75A File Offset: 0x002B895A
		public unsafe float MoveRangeLimitReflectSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSC_SpineAnimNotify.__PropertyOffset_MoveRangeLimitReflectSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_SpineAnimNotify.__PropertyOffset_MoveRangeLimitReflectSpeed) = value;
			}
		}

		// Token: 0x17007722 RID: 30498
		// (get) Token: 0x0601D918 RID: 121112 RVA: 0x002BA76B File Offset: 0x002B896B
		// (set) Token: 0x0601D919 RID: 121113 RVA: 0x002BA77B File Offset: 0x002B897B
		public unsafe float MoveRangeLimitDuration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSC_SpineAnimNotify.__PropertyOffset_MoveRangeLimitDuration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_SpineAnimNotify.__PropertyOffset_MoveRangeLimitDuration) = value;
			}
		}

		// Token: 0x17007723 RID: 30499
		// (get) Token: 0x0601D91A RID: 121114 RVA: 0x002BA78C File Offset: 0x002B898C
		// (set) Token: 0x0601D91B RID: 121115 RVA: 0x002BA7CF File Offset: 0x002B89CF
		[Nullable(1)]
		public TArray<FKSC_SpawnEntity> SummonEntities
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FKSC_SpawnEntity> result;
				if ((result = this._SummonEntities) == null)
				{
					result = (this._SummonEntities = new TArray<FKSC_SpawnEntity>(base.NativePtr + (IntPtr)FKSC_SpineAnimNotify.__PropertyOffset_SummonEntities, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.SummonEntities.CopyAssign(value);
			}
		}

		// Token: 0x17007724 RID: 30500
		// (get) Token: 0x0601D91C RID: 121116 RVA: 0x002BA7DD File Offset: 0x002B89DD
		// (set) Token: 0x0601D91D RID: 121117 RVA: 0x002BA7ED File Offset: 0x002B89ED
		public unsafe float SpeedValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSC_SpineAnimNotify.__PropertyOffset_SpeedValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_SpineAnimNotify.__PropertyOffset_SpeedValue) = value;
			}
		}

		// Token: 0x17007725 RID: 30501
		// (get) Token: 0x0601D91E RID: 121118 RVA: 0x002BA7FE File Offset: 0x002B89FE
		// (set) Token: 0x0601D91F RID: 121119 RVA: 0x002BA80E File Offset: 0x002B8A0E
		public unsafe bool IsUseTargetDirection
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSC_SpineAnimNotify.__PropertyOffset_IsUseTargetDirection) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_SpineAnimNotify.__PropertyOffset_IsUseTargetDirection) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007726 RID: 30502
		// (get) Token: 0x0601D920 RID: 121120 RVA: 0x002BA81F File Offset: 0x002B8A1F
		// (set) Token: 0x0601D921 RID: 121121 RVA: 0x002BA833 File Offset: 0x002B8A33
		public unsafe FVector2D SpeedDirection
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSC_SpineAnimNotify.__PropertyOffset_SpeedDirection);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_SpineAnimNotify.__PropertyOffset_SpeedDirection) = value;
			}
		}

		// Token: 0x17007727 RID: 30503
		// (get) Token: 0x0601D922 RID: 121122 RVA: 0x002BA848 File Offset: 0x002B8A48
		// (set) Token: 0x0601D923 RID: 121123 RVA: 0x002BA858 File Offset: 0x002B8A58
		public unsafe float ChargeDuration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSC_SpineAnimNotify.__PropertyOffset_ChargeDuration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_SpineAnimNotify.__PropertyOffset_ChargeDuration) = value;
			}
		}

		// Token: 0x17007728 RID: 30504
		// (get) Token: 0x0601D924 RID: 121124 RVA: 0x002BA869 File Offset: 0x002B8A69
		// (set) Token: 0x0601D925 RID: 121125 RVA: 0x002BA87D File Offset: 0x002B8A7D
		public unsafe FVector Position
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSC_SpineAnimNotify.__PropertyOffset_Position);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_SpineAnimNotify.__PropertyOffset_Position) = value;
			}
		}

		// Token: 0x17007729 RID: 30505
		// (get) Token: 0x0601D926 RID: 121126 RVA: 0x002BA892 File Offset: 0x002B8A92
		// (set) Token: 0x0601D927 RID: 121127 RVA: 0x002BA8A2 File Offset: 0x002B8AA2
		public unsafe float PositionLerpTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSC_SpineAnimNotify.__PropertyOffset_PositionLerpTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_SpineAnimNotify.__PropertyOffset_PositionLerpTime) = value;
			}
		}

		// Token: 0x1700772A RID: 30506
		// (get) Token: 0x0601D928 RID: 121128 RVA: 0x002BA8B3 File Offset: 0x002B8AB3
		// (set) Token: 0x0601D929 RID: 121129 RVA: 0x002BA8C7 File Offset: 0x002B8AC7
		public unsafe UCurveFloat PositionLerpCurve
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + FKSC_SpineAnimNotify.__PropertyOffset_PositionLerpCurve);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FKSC_SpineAnimNotify.__PropertyOffset_PositionLerpCurve, value);
			}
		}

		// Token: 0x0601D92A RID: 121130 RVA: 0x002BA8DC File Offset: 0x002B8ADC
		public FKSC_SpineAnimNotify()
		{
		}

		// Token: 0x0601D92B RID: 121131 RVA: 0x002BA8E4 File Offset: 0x002B8AE4
		[NullableContext(1)]
		public FKSC_SpineAnimNotify(float Time, bool IsUseFullTime, bool IsTriggerOnce, bool IsUseCurrentPlayer, EKSC_SpineAnimNotifyType Type, FGameplayTag Tag, UKSC_DA_Buff Buff, int BuffStackNum, EKSC_Shape2D_SelectTarget SelectTarget, int BulletID, bool IsUseBulletDefaultRotation, FRotator BulletDefaultRotation, UEffectModelBase Effect, FTransform EffectOffset, float SearchRange, TMap<EKSC_EntityType, int> SearchPriorityMap, EKSC_Shape2D_CustomMovementMode MovementMode, float MovementDuration, float MovementDistance, float MovementEndDistance, UCurveFloat MovementCurve, bool MovementIsTrace, bool MovementIsKeep, bool MovementIsKeepEnd, float MoveRangeLimitRadius, float MoveRangeLimitReflectSpeed, float MoveRangeLimitDuration, TArray<FKSC_SpawnEntity> SummonEntities, float SpeedValue, bool IsUseTargetDirection, FVector2D SpeedDirection, float ChargeDuration, FVector Position, float PositionLerpTime, UCurveFloat PositionLerpCurve)
		{
			this.Time = Time;
			this.IsUseFullTime = IsUseFullTime;
			this.IsTriggerOnce = IsTriggerOnce;
			this.IsUseCurrentPlayer = IsUseCurrentPlayer;
			this.Type = Type;
			this.Tag = Tag;
			this.Buff = Buff;
			this.BuffStackNum = BuffStackNum;
			this.SelectTarget = SelectTarget;
			this.BulletID = BulletID;
			this.IsUseBulletDefaultRotation = IsUseBulletDefaultRotation;
			this.BulletDefaultRotation = BulletDefaultRotation;
			this.Effect = Effect;
			this.EffectOffset = EffectOffset;
			this.SearchRange = SearchRange;
			this.SearchPriorityMap = SearchPriorityMap;
			this.MovementMode = MovementMode;
			this.MovementDuration = MovementDuration;
			this.MovementDistance = MovementDistance;
			this.MovementEndDistance = MovementEndDistance;
			this.MovementCurve = MovementCurve;
			this.MovementIsTrace = MovementIsTrace;
			this.MovementIsKeep = MovementIsKeep;
			this.MovementIsKeepEnd = MovementIsKeepEnd;
			this.MoveRangeLimitRadius = MoveRangeLimitRadius;
			this.MoveRangeLimitReflectSpeed = MoveRangeLimitReflectSpeed;
			this.MoveRangeLimitDuration = MoveRangeLimitDuration;
			this.SummonEntities = SummonEntities;
			this.SpeedValue = SpeedValue;
			this.IsUseTargetDirection = IsUseTargetDirection;
			this.SpeedDirection = SpeedDirection;
			this.ChargeDuration = ChargeDuration;
			this.Position = Position;
			this.PositionLerpTime = PositionLerpTime;
			this.PositionLerpCurve = PositionLerpCurve;
		}

		// Token: 0x0601D92C RID: 121132 RVA: 0x002BAA0C File Offset: 0x002B8C0C
		protected override IntPtr GetUStructPtr()
		{
			return FKSC_SpineAnimNotify.StaticStruct();
		}

		// Token: 0x0601D92D RID: 121133 RVA: 0x002BAA18 File Offset: 0x002B8C18
		public FKSC_SpineAnimNotify(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601D92E RID: 121134 RVA: 0x002BAA22 File Offset: 0x002B8C22
		public FKSC_SpineAnimNotify(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601D92F RID: 121135 RVA: 0x002BAA2D File Offset: 0x002B8C2D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKSC_SpineAnimNotify(Pointer, false, true);
		}

		// Token: 0x0601D930 RID: 121136 RVA: 0x002BAA37 File Offset: 0x002B8C37
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKSC_SpineAnimNotify(Pointer, MemoryOwner);
		}

		// Token: 0x04010057 RID: 65623
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_SpineAnimNotify";

		// Token: 0x04010058 RID: 65624
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04010059 RID: 65625
		internal static int __PropertyOffset_Time;

		// Token: 0x0401005A RID: 65626
		internal static int __PropertyOffset_IsUseFullTime;

		// Token: 0x0401005B RID: 65627
		internal static int __PropertyOffset_IsTriggerOnce;

		// Token: 0x0401005C RID: 65628
		internal static int __PropertyOffset_IsUseCurrentPlayer;

		// Token: 0x0401005D RID: 65629
		internal static int __PropertyOffset_Type;

		// Token: 0x0401005E RID: 65630
		internal static int __PropertyOffset_Tag;

		// Token: 0x0401005F RID: 65631
		internal static int __PropertyOffset_Buff;

		// Token: 0x04010060 RID: 65632
		internal static int __PropertyOffset_BuffStackNum;

		// Token: 0x04010061 RID: 65633
		internal static int __PropertyOffset_SelectTarget;

		// Token: 0x04010062 RID: 65634
		internal static int __PropertyOffset_BulletID;

		// Token: 0x04010063 RID: 65635
		internal static int __PropertyOffset_IsUseBulletDefaultRotation;

		// Token: 0x04010064 RID: 65636
		internal static int __PropertyOffset_BulletDefaultRotation;

		// Token: 0x04010065 RID: 65637
		internal static int __PropertyOffset_Effect;

		// Token: 0x04010066 RID: 65638
		internal static int __PropertyOffset_EffectOffset;

		// Token: 0x04010067 RID: 65639
		internal static int __PropertyOffset_SearchRange;

		// Token: 0x04010068 RID: 65640
		internal static int __PropertyOffset_SearchPriorityMap;

		// Token: 0x04010069 RID: 65641
		private TMap<EKSC_EntityType, int> _SearchPriorityMap;

		// Token: 0x0401006A RID: 65642
		internal static int __PropertyOffset_MovementMode;

		// Token: 0x0401006B RID: 65643
		internal static int __PropertyOffset_MovementDuration;

		// Token: 0x0401006C RID: 65644
		internal static int __PropertyOffset_MovementDistance;

		// Token: 0x0401006D RID: 65645
		internal static int __PropertyOffset_MovementEndDistance;

		// Token: 0x0401006E RID: 65646
		internal static int __PropertyOffset_MovementCurve;

		// Token: 0x0401006F RID: 65647
		internal static int __PropertyOffset_MovementIsTrace;

		// Token: 0x04010070 RID: 65648
		internal static int __PropertyOffset_MovementIsKeep;

		// Token: 0x04010071 RID: 65649
		internal static int __PropertyOffset_MovementIsKeepEnd;

		// Token: 0x04010072 RID: 65650
		internal static int __PropertyOffset_MoveRangeLimitRadius;

		// Token: 0x04010073 RID: 65651
		internal static int __PropertyOffset_MoveRangeLimitReflectSpeed;

		// Token: 0x04010074 RID: 65652
		internal static int __PropertyOffset_MoveRangeLimitDuration;

		// Token: 0x04010075 RID: 65653
		internal static int __PropertyOffset_SummonEntities;

		// Token: 0x04010076 RID: 65654
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKSC_SpawnEntity> _SummonEntities;

		// Token: 0x04010077 RID: 65655
		internal static int __PropertyOffset_SpeedValue;

		// Token: 0x04010078 RID: 65656
		internal static int __PropertyOffset_IsUseTargetDirection;

		// Token: 0x04010079 RID: 65657
		internal static int __PropertyOffset_SpeedDirection;

		// Token: 0x0401007A RID: 65658
		internal static int __PropertyOffset_ChargeDuration;

		// Token: 0x0401007B RID: 65659
		internal static int __PropertyOffset_Position;

		// Token: 0x0401007C RID: 65660
		internal static int __PropertyOffset_PositionLerpTime;

		// Token: 0x0401007D RID: 65661
		internal static int __PropertyOffset_PositionLerpCurve;
	}
}
