using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000575 RID: 1397
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_Skill")]
	[UnrealStructLayout(400, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 400)]
	public abstract class UKSC_DA_Skill : UDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06007EF7 RID: 32503 RVA: 0x000BC09B File Offset: 0x000BA29B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_Skill._ClassPtr;
		}

		// Token: 0x170018A8 RID: 6312
		// (get) Token: 0x06007EF8 RID: 32504 RVA: 0x000BC0A7 File Offset: 0x000BA2A7
		// (set) Token: 0x06007EF9 RID: 32505 RVA: 0x000BC0BB File Offset: 0x000BA2BB
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

		// Token: 0x170018A9 RID: 6313
		// (get) Token: 0x06007EFA RID: 32506 RVA: 0x000BC0D0 File Offset: 0x000BA2D0
		// (set) Token: 0x06007EFB RID: 32507 RVA: 0x000BC0E0 File Offset: 0x000BA2E0
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

		// Token: 0x170018AA RID: 6314
		// (get) Token: 0x06007EFC RID: 32508 RVA: 0x000BC0F1 File Offset: 0x000BA2F1
		// (set) Token: 0x06007EFD RID: 32509 RVA: 0x000BC101 File Offset: 0x000BA301
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

		// Token: 0x170018AB RID: 6315
		// (get) Token: 0x06007EFE RID: 32510 RVA: 0x000BC112 File Offset: 0x000BA312
		// (set) Token: 0x06007EFF RID: 32511 RVA: 0x000BC122 File Offset: 0x000BA322
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

		// Token: 0x170018AC RID: 6316
		// (get) Token: 0x06007F00 RID: 32512 RVA: 0x000BC133 File Offset: 0x000BA333
		// (set) Token: 0x06007F01 RID: 32513 RVA: 0x000BC143 File Offset: 0x000BA343
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

		// Token: 0x170018AD RID: 6317
		// (get) Token: 0x06007F02 RID: 32514 RVA: 0x000BC154 File Offset: 0x000BA354
		// (set) Token: 0x06007F03 RID: 32515 RVA: 0x000BC164 File Offset: 0x000BA364
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

		// Token: 0x170018AE RID: 6318
		// (get) Token: 0x06007F04 RID: 32516 RVA: 0x000BC175 File Offset: 0x000BA375
		// (set) Token: 0x06007F05 RID: 32517 RVA: 0x000BC185 File Offset: 0x000BA385
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

		// Token: 0x170018AF RID: 6319
		// (get) Token: 0x06007F06 RID: 32518 RVA: 0x000BC196 File Offset: 0x000BA396
		// (set) Token: 0x06007F07 RID: 32519 RVA: 0x000BC1A6 File Offset: 0x000BA3A6
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

		// Token: 0x170018B0 RID: 6320
		// (get) Token: 0x06007F08 RID: 32520 RVA: 0x000BC1B7 File Offset: 0x000BA3B7
		// (set) Token: 0x06007F09 RID: 32521 RVA: 0x000BC1C7 File Offset: 0x000BA3C7
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

		// Token: 0x170018B1 RID: 6321
		// (get) Token: 0x06007F0A RID: 32522 RVA: 0x000BC1D8 File Offset: 0x000BA3D8
		// (set) Token: 0x06007F0B RID: 32523 RVA: 0x000BC1E8 File Offset: 0x000BA3E8
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

		// Token: 0x170018B2 RID: 6322
		// (get) Token: 0x06007F0C RID: 32524 RVA: 0x000BC1F9 File Offset: 0x000BA3F9
		// (set) Token: 0x06007F0D RID: 32525 RVA: 0x000BC209 File Offset: 0x000BA409
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

		// Token: 0x170018B3 RID: 6323
		// (get) Token: 0x06007F0E RID: 32526 RVA: 0x000BC21A File Offset: 0x000BA41A
		// (set) Token: 0x06007F0F RID: 32527 RVA: 0x000BC22A File Offset: 0x000BA42A
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

		// Token: 0x170018B4 RID: 6324
		// (get) Token: 0x06007F10 RID: 32528 RVA: 0x000BC23B File Offset: 0x000BA43B
		// (set) Token: 0x06007F11 RID: 32529 RVA: 0x000BC24B File Offset: 0x000BA44B
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

		// Token: 0x170018B5 RID: 6325
		// (get) Token: 0x06007F12 RID: 32530 RVA: 0x000BC25C File Offset: 0x000BA45C
		// (set) Token: 0x06007F13 RID: 32531 RVA: 0x000BC26C File Offset: 0x000BA46C
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

		// Token: 0x170018B6 RID: 6326
		// (get) Token: 0x06007F14 RID: 32532 RVA: 0x000BC27D File Offset: 0x000BA47D
		// (set) Token: 0x06007F15 RID: 32533 RVA: 0x000BC28D File Offset: 0x000BA48D
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

		// Token: 0x170018B7 RID: 6327
		// (get) Token: 0x06007F16 RID: 32534 RVA: 0x000BC29E File Offset: 0x000BA49E
		// (set) Token: 0x06007F17 RID: 32535 RVA: 0x000BC2AE File Offset: 0x000BA4AE
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

		// Token: 0x170018B8 RID: 6328
		// (get) Token: 0x06007F18 RID: 32536 RVA: 0x000BC2BF File Offset: 0x000BA4BF
		// (set) Token: 0x06007F19 RID: 32537 RVA: 0x000BC2CF File Offset: 0x000BA4CF
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

		// Token: 0x170018B9 RID: 6329
		// (get) Token: 0x06007F1A RID: 32538 RVA: 0x000BC2E0 File Offset: 0x000BA4E0
		// (set) Token: 0x06007F1B RID: 32539 RVA: 0x000BC319 File Offset: 0x000BA519
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

		// Token: 0x170018BA RID: 6330
		// (get) Token: 0x06007F1C RID: 32540 RVA: 0x000BC33A File Offset: 0x000BA53A
		// (set) Token: 0x06007F1D RID: 32541 RVA: 0x000BC34A File Offset: 0x000BA54A
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

		// Token: 0x170018BB RID: 6331
		// (get) Token: 0x06007F1E RID: 32542 RVA: 0x000BC35B File Offset: 0x000BA55B
		// (set) Token: 0x06007F1F RID: 32543 RVA: 0x000BC36B File Offset: 0x000BA56B
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

		// Token: 0x170018BC RID: 6332
		// (get) Token: 0x06007F20 RID: 32544 RVA: 0x000BC37C File Offset: 0x000BA57C
		// (set) Token: 0x06007F21 RID: 32545 RVA: 0x000BC390 File Offset: 0x000BA590
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

		// Token: 0x170018BD RID: 6333
		// (get) Token: 0x06007F22 RID: 32546 RVA: 0x000BC3A8 File Offset: 0x000BA5A8
		// (set) Token: 0x06007F23 RID: 32547 RVA: 0x000BC3E1 File Offset: 0x000BA5E1
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

		// Token: 0x170018BE RID: 6334
		// (get) Token: 0x06007F24 RID: 32548 RVA: 0x000BC3EF File Offset: 0x000BA5EF
		// (set) Token: 0x06007F25 RID: 32549 RVA: 0x000BC403 File Offset: 0x000BA603
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

		// Token: 0x170018BF RID: 6335
		// (get) Token: 0x06007F26 RID: 32550 RVA: 0x000BC418 File Offset: 0x000BA618
		// (set) Token: 0x06007F27 RID: 32551 RVA: 0x000BC42C File Offset: 0x000BA62C
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

		// Token: 0x170018C0 RID: 6336
		// (get) Token: 0x06007F28 RID: 32552 RVA: 0x000BC441 File Offset: 0x000BA641
		// (set) Token: 0x06007F29 RID: 32553 RVA: 0x000BC451 File Offset: 0x000BA651
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

		// Token: 0x170018C1 RID: 6337
		// (get) Token: 0x06007F2A RID: 32554 RVA: 0x000BC462 File Offset: 0x000BA662
		// (set) Token: 0x06007F2B RID: 32555 RVA: 0x000BC476 File Offset: 0x000BA676
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

		// Token: 0x170018C2 RID: 6338
		// (get) Token: 0x06007F2C RID: 32556 RVA: 0x000BC48B File Offset: 0x000BA68B
		// (set) Token: 0x06007F2D RID: 32557 RVA: 0x000BC49F File Offset: 0x000BA69F
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

		// Token: 0x170018C3 RID: 6339
		// (get) Token: 0x06007F2E RID: 32558 RVA: 0x000BC4B4 File Offset: 0x000BA6B4
		// (set) Token: 0x06007F2F RID: 32559 RVA: 0x000BC4C4 File Offset: 0x000BA6C4
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

		// Token: 0x170018C4 RID: 6340
		// (get) Token: 0x06007F30 RID: 32560 RVA: 0x000BC4D5 File Offset: 0x000BA6D5
		// (set) Token: 0x06007F31 RID: 32561 RVA: 0x000BC4E5 File Offset: 0x000BA6E5
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

		// Token: 0x170018C5 RID: 6341
		// (get) Token: 0x06007F32 RID: 32562 RVA: 0x000BC4F6 File Offset: 0x000BA6F6
		// (set) Token: 0x06007F33 RID: 32563 RVA: 0x000BC50A File Offset: 0x000BA70A
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

		// Token: 0x170018C6 RID: 6342
		// (get) Token: 0x06007F34 RID: 32564 RVA: 0x000BC51F File Offset: 0x000BA71F
		// (set) Token: 0x06007F35 RID: 32565 RVA: 0x000BC533 File Offset: 0x000BA733
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

		// Token: 0x06007F36 RID: 32566 RVA: 0x000BC548 File Offset: 0x000BA748
		static UKSC_DA_Skill()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_Skill");
		}

		// Token: 0x06007F37 RID: 32567 RVA: 0x000BC558 File Offset: 0x000BA758
		protected UKSC_DA_Skill() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Skill.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06007F38 RID: 32568 RVA: 0x000BC580 File Offset: 0x000BA780
		protected UKSC_DA_Skill(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003776 RID: 14198
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_Skill";

		// Token: 0x04003777 RID: 14199
		private static IntPtr _ClassPtr;

		// Token: 0x04003778 RID: 14200
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003779 RID: 14201
		internal static int __PropertyOffset_RuntimeClass;

		// Token: 0x0400377A RID: 14202
		internal static int __PropertyOffset_TargetNum;

		// Token: 0x0400377B RID: 14203
		internal static int __PropertyOffset_CheckTarget;

		// Token: 0x0400377C RID: 14204
		internal static int __PropertyOffset_CheckTargetVisible;

		// Token: 0x0400377D RID: 14205
		internal static int __PropertyOffset_GenerateStateEvent;

		// Token: 0x0400377E RID: 14206
		internal static int __PropertyOffset_IsAutoCast;

		// Token: 0x0400377F RID: 14207
		internal static int __PropertyOffset_UseAttrCD;

		// Token: 0x04003780 RID: 14208
		internal static int __PropertyOffset_CoolDown;

		// Token: 0x04003781 RID: 14209
		internal static int __PropertyOffset_CostMP;

		// Token: 0x04003782 RID: 14210
		internal static int __PropertyOffset_PreDelay;

		// Token: 0x04003783 RID: 14211
		internal static int __PropertyOffset_PreCastDelay;

		// Token: 0x04003784 RID: 14212
		internal static int __PropertyOffset_PostDelay;

		// Token: 0x04003785 RID: 14213
		internal static int __PropertyOffset_SkillCompSleep;

		// Token: 0x04003786 RID: 14214
		internal static int __PropertyOffset_CastRange;

		// Token: 0x04003787 RID: 14215
		internal static int __PropertyOffset_UseCustomCost;

		// Token: 0x04003788 RID: 14216
		internal static int __PropertyOffset_CustomCostType;

		// Token: 0x04003789 RID: 14217
		internal static int __PropertyOffset_CustomCostValue;

		// Token: 0x0400378A RID: 14218
		internal static int __PropertyOffset_Damage;

		// Token: 0x0400378B RID: 14219
		private FKSCDamage _Damage;

		// Token: 0x0400378C RID: 14220
		internal static int __PropertyOffset_DamageID;

		// Token: 0x0400378D RID: 14221
		internal static int __PropertyOffset_DamageMaterial;

		// Token: 0x0400378E RID: 14222
		internal static int __PropertyOffset_AddBuff;

		// Token: 0x0400378F RID: 14223
		internal static int __PropertyOffset_AddBuffs;

		// Token: 0x04003790 RID: 14224
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UKSC_DA_Buff> _AddBuffs;

		// Token: 0x04003791 RID: 14225
		internal static int __PropertyOffset_KuroSkillFX;

		// Token: 0x04003792 RID: 14226
		internal static int __PropertyOffset_KuroSkillFX_Offset;

		// Token: 0x04003793 RID: 14227
		internal static int __PropertyOffset_KuroSkillFX_BindingTarget;

		// Token: 0x04003794 RID: 14228
		internal static int __PropertyOffset_KuroCastFX;

		// Token: 0x04003795 RID: 14229
		internal static int __PropertyOffset_KuroCastFX_Offset;

		// Token: 0x04003796 RID: 14230
		internal static int __PropertyOffset_KuroCastFX_BindingTarget;

		// Token: 0x04003797 RID: 14231
		internal static int __PropertyOffset_KuroHitFX_MaxNum;

		// Token: 0x04003798 RID: 14232
		internal static int __PropertyOffset_KuroHitFX;

		// Token: 0x04003799 RID: 14233
		internal static int __PropertyOffset_KuroHitFX_Offset;
	}
}
