using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001DB9 RID: 7609
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_Skill")]
	[UnrealStructLayout(400, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 400)]
	public abstract class UKSC_DA_Skill : UDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D165 RID: 119141 RVA: 0x002AFB3A File Offset: 0x002ADD3A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_Skill._ClassPtr;
		}

		// Token: 0x17007568 RID: 30056
		// (get) Token: 0x0601D166 RID: 119142 RVA: 0x002AFB46 File Offset: 0x002ADD46
		// (set) Token: 0x0601D167 RID: 119143 RVA: 0x002AFB5A File Offset: 0x002ADD5A
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UKSC_Skill> RuntimeClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Skill.__PropertyOffset_RuntimeClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Skill.__PropertyOffset_RuntimeClass) = value;
			}
		}

		// Token: 0x17007569 RID: 30057
		// (get) Token: 0x0601D168 RID: 119144 RVA: 0x002AFB6F File Offset: 0x002ADD6F
		// (set) Token: 0x0601D169 RID: 119145 RVA: 0x002AFB7F File Offset: 0x002ADD7F
		public unsafe EKSC_TargetFaction TargetFaction
		{
			get
			{
				return (EKSC_TargetFaction)(*(base.NativePtr + (IntPtr)UKSC_DA_Skill.__PropertyOffset_TargetFaction));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Skill.__PropertyOffset_TargetFaction) = (byte)value;
			}
		}

		// Token: 0x1700756A RID: 30058
		// (get) Token: 0x0601D16A RID: 119146 RVA: 0x002AFB90 File Offset: 0x002ADD90
		// (set) Token: 0x0601D16B RID: 119147 RVA: 0x002AFBA0 File Offset: 0x002ADDA0
		public unsafe int TargetNum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Skill.__PropertyOffset_TargetNum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Skill.__PropertyOffset_TargetNum) = value;
			}
		}

		// Token: 0x1700756B RID: 30059
		// (get) Token: 0x0601D16C RID: 119148 RVA: 0x002AFBB1 File Offset: 0x002ADDB1
		// (set) Token: 0x0601D16D RID: 119149 RVA: 0x002AFBC1 File Offset: 0x002ADDC1
		public unsafe bool CheckTarget
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Skill.__PropertyOffset_CheckTarget) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Skill.__PropertyOffset_CheckTarget) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700756C RID: 30060
		// (get) Token: 0x0601D16E RID: 119150 RVA: 0x002AFBD2 File Offset: 0x002ADDD2
		// (set) Token: 0x0601D16F RID: 119151 RVA: 0x002AFBE2 File Offset: 0x002ADDE2
		public unsafe bool CheckTargetVisible
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Skill.__PropertyOffset_CheckTargetVisible) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Skill.__PropertyOffset_CheckTargetVisible) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700756D RID: 30061
		// (get) Token: 0x0601D170 RID: 119152 RVA: 0x002AFBF3 File Offset: 0x002ADDF3
		// (set) Token: 0x0601D171 RID: 119153 RVA: 0x002AFC03 File Offset: 0x002ADE03
		public unsafe bool GenerateStateEvent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Skill.__PropertyOffset_GenerateStateEvent) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Skill.__PropertyOffset_GenerateStateEvent) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700756E RID: 30062
		// (get) Token: 0x0601D172 RID: 119154 RVA: 0x002AFC14 File Offset: 0x002ADE14
		// (set) Token: 0x0601D173 RID: 119155 RVA: 0x002AFC24 File Offset: 0x002ADE24
		public unsafe bool IsAutoCast
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Skill.__PropertyOffset_IsAutoCast) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Skill.__PropertyOffset_IsAutoCast) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700756F RID: 30063
		// (get) Token: 0x0601D174 RID: 119156 RVA: 0x002AFC35 File Offset: 0x002ADE35
		// (set) Token: 0x0601D175 RID: 119157 RVA: 0x002AFC45 File Offset: 0x002ADE45
		public unsafe bool UseAttrCD
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Skill.__PropertyOffset_UseAttrCD) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Skill.__PropertyOffset_UseAttrCD) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007570 RID: 30064
		// (get) Token: 0x0601D176 RID: 119158 RVA: 0x002AFC56 File Offset: 0x002ADE56
		// (set) Token: 0x0601D177 RID: 119159 RVA: 0x002AFC66 File Offset: 0x002ADE66
		public unsafe float CoolDown
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Skill.__PropertyOffset_CoolDown);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Skill.__PropertyOffset_CoolDown) = value;
			}
		}

		// Token: 0x17007571 RID: 30065
		// (get) Token: 0x0601D178 RID: 119160 RVA: 0x002AFC77 File Offset: 0x002ADE77
		// (set) Token: 0x0601D179 RID: 119161 RVA: 0x002AFC87 File Offset: 0x002ADE87
		public unsafe float CostMP
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Skill.__PropertyOffset_CostMP);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Skill.__PropertyOffset_CostMP) = value;
			}
		}

		// Token: 0x17007572 RID: 30066
		// (get) Token: 0x0601D17A RID: 119162 RVA: 0x002AFC98 File Offset: 0x002ADE98
		// (set) Token: 0x0601D17B RID: 119163 RVA: 0x002AFCA8 File Offset: 0x002ADEA8
		public unsafe float PreDelay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Skill.__PropertyOffset_PreDelay);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Skill.__PropertyOffset_PreDelay) = value;
			}
		}

		// Token: 0x17007573 RID: 30067
		// (get) Token: 0x0601D17C RID: 119164 RVA: 0x002AFCB9 File Offset: 0x002ADEB9
		// (set) Token: 0x0601D17D RID: 119165 RVA: 0x002AFCC9 File Offset: 0x002ADEC9
		public unsafe float PreCastDelay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Skill.__PropertyOffset_PreCastDelay);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Skill.__PropertyOffset_PreCastDelay) = value;
			}
		}

		// Token: 0x17007574 RID: 30068
		// (get) Token: 0x0601D17E RID: 119166 RVA: 0x002AFCDA File Offset: 0x002ADEDA
		// (set) Token: 0x0601D17F RID: 119167 RVA: 0x002AFCEA File Offset: 0x002ADEEA
		public unsafe float PostDelay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Skill.__PropertyOffset_PostDelay);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Skill.__PropertyOffset_PostDelay) = value;
			}
		}

		// Token: 0x17007575 RID: 30069
		// (get) Token: 0x0601D180 RID: 119168 RVA: 0x002AFCFB File Offset: 0x002ADEFB
		// (set) Token: 0x0601D181 RID: 119169 RVA: 0x002AFD0B File Offset: 0x002ADF0B
		public unsafe float SkillCompSleep
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Skill.__PropertyOffset_SkillCompSleep);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Skill.__PropertyOffset_SkillCompSleep) = value;
			}
		}

		// Token: 0x17007576 RID: 30070
		// (get) Token: 0x0601D182 RID: 119170 RVA: 0x002AFD1C File Offset: 0x002ADF1C
		// (set) Token: 0x0601D183 RID: 119171 RVA: 0x002AFD2C File Offset: 0x002ADF2C
		public unsafe float CastRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Skill.__PropertyOffset_CastRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Skill.__PropertyOffset_CastRange) = value;
			}
		}

		// Token: 0x17007577 RID: 30071
		// (get) Token: 0x0601D184 RID: 119172 RVA: 0x002AFD3D File Offset: 0x002ADF3D
		// (set) Token: 0x0601D185 RID: 119173 RVA: 0x002AFD4D File Offset: 0x002ADF4D
		public unsafe bool UseCustomCost
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Skill.__PropertyOffset_UseCustomCost) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Skill.__PropertyOffset_UseCustomCost) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007578 RID: 30072
		// (get) Token: 0x0601D186 RID: 119174 RVA: 0x002AFD5E File Offset: 0x002ADF5E
		// (set) Token: 0x0601D187 RID: 119175 RVA: 0x002AFD6E File Offset: 0x002ADF6E
		public unsafe EKSC_AttrType CustomCostType
		{
			get
			{
				return (EKSC_AttrType)(*(base.NativePtr + (IntPtr)UKSC_DA_Skill.__PropertyOffset_CustomCostType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Skill.__PropertyOffset_CustomCostType) = (byte)value;
			}
		}

		// Token: 0x17007579 RID: 30073
		// (get) Token: 0x0601D188 RID: 119176 RVA: 0x002AFD7F File Offset: 0x002ADF7F
		// (set) Token: 0x0601D189 RID: 119177 RVA: 0x002AFD8F File Offset: 0x002ADF8F
		public unsafe float CustomCostValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Skill.__PropertyOffset_CustomCostValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Skill.__PropertyOffset_CustomCostValue) = value;
			}
		}

		// Token: 0x1700757A RID: 30074
		// (get) Token: 0x0601D18A RID: 119178 RVA: 0x002AFDA0 File Offset: 0x002ADFA0
		// (set) Token: 0x0601D18B RID: 119179 RVA: 0x002AFDD9 File Offset: 0x002ADFD9
		[Nullable(1)]
		public FKSCDamage Damage
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FKSCDamage result;
				if ((result = this._Damage) == null)
				{
					result = (this._Damage = new FKSCDamage(base.NativePtr + (IntPtr)UKSC_DA_Skill.__PropertyOffset_Damage, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKSCDamage.StaticStruct(), base.NativePtr + (IntPtr)UKSC_DA_Skill.__PropertyOffset_Damage, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700757B RID: 30075
		// (get) Token: 0x0601D18C RID: 119180 RVA: 0x002AFDFA File Offset: 0x002ADFFA
		// (set) Token: 0x0601D18D RID: 119181 RVA: 0x002AFE0A File Offset: 0x002AE00A
		public unsafe int DamageID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Skill.__PropertyOffset_DamageID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Skill.__PropertyOffset_DamageID) = value;
			}
		}

		// Token: 0x1700757C RID: 30076
		// (get) Token: 0x0601D18E RID: 119182 RVA: 0x002AFE1B File Offset: 0x002AE01B
		// (set) Token: 0x0601D18F RID: 119183 RVA: 0x002AFE2B File Offset: 0x002AE02B
		public unsafe bool DamageMaterial
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Skill.__PropertyOffset_DamageMaterial) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Skill.__PropertyOffset_DamageMaterial) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700757D RID: 30077
		// (get) Token: 0x0601D190 RID: 119184 RVA: 0x002AFE3C File Offset: 0x002AE03C
		// (set) Token: 0x0601D191 RID: 119185 RVA: 0x002AFE50 File Offset: 0x002AE050
		public unsafe UKSC_DA_AdditionalAttack AdditionalAttack
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_AdditionalAttack>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Skill.__PropertyOffset_AdditionalAttack);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Skill.__PropertyOffset_AdditionalAttack, value);
			}
		}

		// Token: 0x1700757E RID: 30078
		// (get) Token: 0x0601D192 RID: 119186 RVA: 0x002AFE65 File Offset: 0x002AE065
		// (set) Token: 0x0601D193 RID: 119187 RVA: 0x002AFE79 File Offset: 0x002AE079
		public unsafe UKSC_DA_Buff AddBuff
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_Buff>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Skill.__PropertyOffset_AddBuff);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Skill.__PropertyOffset_AddBuff, value);
			}
		}

		// Token: 0x1700757F RID: 30079
		// (get) Token: 0x0601D194 RID: 119188 RVA: 0x002AFE90 File Offset: 0x002AE090
		// (set) Token: 0x0601D195 RID: 119189 RVA: 0x002AFEC9 File Offset: 0x002AE0C9
		[Nullable(1)]
		public TArray<UKSC_DA_Buff> AddBuffs
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UKSC_DA_Buff> result;
				if ((result = this._AddBuffs) == null)
				{
					result = (this._AddBuffs = new TArray<UKSC_DA_Buff>(base.NativePtr + (IntPtr)UKSC_DA_Skill.__PropertyOffset_AddBuffs, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.AddBuffs.CopyAssign(value);
			}
		}

		// Token: 0x17007580 RID: 30080
		// (get) Token: 0x0601D196 RID: 119190 RVA: 0x002AFED7 File Offset: 0x002AE0D7
		// (set) Token: 0x0601D197 RID: 119191 RVA: 0x002AFEEB File Offset: 0x002AE0EB
		public unsafe UEffectModelBase KuroSkillFX
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UEffectModelBase>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Skill.__PropertyOffset_KuroSkillFX);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Skill.__PropertyOffset_KuroSkillFX, value);
			}
		}

		// Token: 0x17007581 RID: 30081
		// (get) Token: 0x0601D198 RID: 119192 RVA: 0x002AFF00 File Offset: 0x002AE100
		// (set) Token: 0x0601D199 RID: 119193 RVA: 0x002AFF14 File Offset: 0x002AE114
		public unsafe FTransform KuroSkillFX_Offset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Skill.__PropertyOffset_KuroSkillFX_Offset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Skill.__PropertyOffset_KuroSkillFX_Offset) = value;
			}
		}

		// Token: 0x17007582 RID: 30082
		// (get) Token: 0x0601D19A RID: 119194 RVA: 0x002AFF29 File Offset: 0x002AE129
		// (set) Token: 0x0601D19B RID: 119195 RVA: 0x002AFF39 File Offset: 0x002AE139
		public unsafe bool KuroSkillFX_BindingTarget
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Skill.__PropertyOffset_KuroSkillFX_BindingTarget) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Skill.__PropertyOffset_KuroSkillFX_BindingTarget) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007583 RID: 30083
		// (get) Token: 0x0601D19C RID: 119196 RVA: 0x002AFF4A File Offset: 0x002AE14A
		// (set) Token: 0x0601D19D RID: 119197 RVA: 0x002AFF5E File Offset: 0x002AE15E
		public unsafe UEffectModelBase KuroCastFX
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UEffectModelBase>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Skill.__PropertyOffset_KuroCastFX);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Skill.__PropertyOffset_KuroCastFX, value);
			}
		}

		// Token: 0x17007584 RID: 30084
		// (get) Token: 0x0601D19E RID: 119198 RVA: 0x002AFF73 File Offset: 0x002AE173
		// (set) Token: 0x0601D19F RID: 119199 RVA: 0x002AFF87 File Offset: 0x002AE187
		public unsafe FTransform KuroCastFX_Offset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Skill.__PropertyOffset_KuroCastFX_Offset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Skill.__PropertyOffset_KuroCastFX_Offset) = value;
			}
		}

		// Token: 0x17007585 RID: 30085
		// (get) Token: 0x0601D1A0 RID: 119200 RVA: 0x002AFF9C File Offset: 0x002AE19C
		// (set) Token: 0x0601D1A1 RID: 119201 RVA: 0x002AFFAC File Offset: 0x002AE1AC
		public unsafe bool KuroCastFX_BindingTarget
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Skill.__PropertyOffset_KuroCastFX_BindingTarget) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Skill.__PropertyOffset_KuroCastFX_BindingTarget) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007586 RID: 30086
		// (get) Token: 0x0601D1A2 RID: 119202 RVA: 0x002AFFBD File Offset: 0x002AE1BD
		// (set) Token: 0x0601D1A3 RID: 119203 RVA: 0x002AFFCD File Offset: 0x002AE1CD
		public unsafe int KuroHitFX_MaxNum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Skill.__PropertyOffset_KuroHitFX_MaxNum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Skill.__PropertyOffset_KuroHitFX_MaxNum) = value;
			}
		}

		// Token: 0x17007587 RID: 30087
		// (get) Token: 0x0601D1A4 RID: 119204 RVA: 0x002AFFDE File Offset: 0x002AE1DE
		// (set) Token: 0x0601D1A5 RID: 119205 RVA: 0x002AFFF2 File Offset: 0x002AE1F2
		public unsafe UEffectModelBase KuroHitFX
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UEffectModelBase>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Skill.__PropertyOffset_KuroHitFX);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Skill.__PropertyOffset_KuroHitFX, value);
			}
		}

		// Token: 0x17007588 RID: 30088
		// (get) Token: 0x0601D1A6 RID: 119206 RVA: 0x002B0007 File Offset: 0x002AE207
		// (set) Token: 0x0601D1A7 RID: 119207 RVA: 0x002B001B File Offset: 0x002AE21B
		public unsafe FTransform KuroHitFX_Offset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Skill.__PropertyOffset_KuroHitFX_Offset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Skill.__PropertyOffset_KuroHitFX_Offset) = value;
			}
		}

		// Token: 0x0601D1A8 RID: 119208 RVA: 0x002B0030 File Offset: 0x002AE230
		static UKSC_DA_Skill()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_Skill");
		}

		// Token: 0x0601D1A9 RID: 119209 RVA: 0x002B0040 File Offset: 0x002AE240
		protected UKSC_DA_Skill() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Skill.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D1AA RID: 119210 RVA: 0x002B0068 File Offset: 0x002AE268
		protected UKSC_DA_Skill(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FCA3 RID: 64675
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_Skill";

		// Token: 0x0400FCA4 RID: 64676
		private static IntPtr _ClassPtr;

		// Token: 0x0400FCA5 RID: 64677
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FCA6 RID: 64678
		internal static int __PropertyOffset_RuntimeClass;

		// Token: 0x0400FCA7 RID: 64679
		internal static int __PropertyOffset_TargetFaction;

		// Token: 0x0400FCA8 RID: 64680
		internal static int __PropertyOffset_TargetNum;

		// Token: 0x0400FCA9 RID: 64681
		internal static int __PropertyOffset_CheckTarget;

		// Token: 0x0400FCAA RID: 64682
		internal static int __PropertyOffset_CheckTargetVisible;

		// Token: 0x0400FCAB RID: 64683
		internal static int __PropertyOffset_GenerateStateEvent;

		// Token: 0x0400FCAC RID: 64684
		internal static int __PropertyOffset_IsAutoCast;

		// Token: 0x0400FCAD RID: 64685
		internal static int __PropertyOffset_UseAttrCD;

		// Token: 0x0400FCAE RID: 64686
		internal static int __PropertyOffset_CoolDown;

		// Token: 0x0400FCAF RID: 64687
		internal static int __PropertyOffset_CostMP;

		// Token: 0x0400FCB0 RID: 64688
		internal static int __PropertyOffset_PreDelay;

		// Token: 0x0400FCB1 RID: 64689
		internal static int __PropertyOffset_PreCastDelay;

		// Token: 0x0400FCB2 RID: 64690
		internal static int __PropertyOffset_PostDelay;

		// Token: 0x0400FCB3 RID: 64691
		internal static int __PropertyOffset_SkillCompSleep;

		// Token: 0x0400FCB4 RID: 64692
		internal static int __PropertyOffset_CastRange;

		// Token: 0x0400FCB5 RID: 64693
		internal static int __PropertyOffset_UseCustomCost;

		// Token: 0x0400FCB6 RID: 64694
		internal static int __PropertyOffset_CustomCostType;

		// Token: 0x0400FCB7 RID: 64695
		internal static int __PropertyOffset_CustomCostValue;

		// Token: 0x0400FCB8 RID: 64696
		internal static int __PropertyOffset_Damage;

		// Token: 0x0400FCB9 RID: 64697
		private FKSCDamage _Damage;

		// Token: 0x0400FCBA RID: 64698
		internal static int __PropertyOffset_DamageID;

		// Token: 0x0400FCBB RID: 64699
		internal static int __PropertyOffset_DamageMaterial;

		// Token: 0x0400FCBC RID: 64700
		internal static int __PropertyOffset_AdditionalAttack;

		// Token: 0x0400FCBD RID: 64701
		internal static int __PropertyOffset_AddBuff;

		// Token: 0x0400FCBE RID: 64702
		internal static int __PropertyOffset_AddBuffs;

		// Token: 0x0400FCBF RID: 64703
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UKSC_DA_Buff> _AddBuffs;

		// Token: 0x0400FCC0 RID: 64704
		internal static int __PropertyOffset_KuroSkillFX;

		// Token: 0x0400FCC1 RID: 64705
		internal static int __PropertyOffset_KuroSkillFX_Offset;

		// Token: 0x0400FCC2 RID: 64706
		internal static int __PropertyOffset_KuroSkillFX_BindingTarget;

		// Token: 0x0400FCC3 RID: 64707
		internal static int __PropertyOffset_KuroCastFX;

		// Token: 0x0400FCC4 RID: 64708
		internal static int __PropertyOffset_KuroCastFX_Offset;

		// Token: 0x0400FCC5 RID: 64709
		internal static int __PropertyOffset_KuroCastFX_BindingTarget;

		// Token: 0x0400FCC6 RID: 64710
		internal static int __PropertyOffset_KuroHitFX_MaxNum;

		// Token: 0x0400FCC7 RID: 64711
		internal static int __PropertyOffset_KuroHitFX;

		// Token: 0x0400FCC8 RID: 64712
		internal static int __PropertyOffset_KuroHitFX_Offset;
	}
}
