using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001730 RID: 5936
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroBullet.KSC_DA_Skill_KuroBullet")]
	[UnrealStructLayout(464, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 464)]
	public class UKSC_DA_Skill_KuroBullet : UKSC_DA_Skill_Anim, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060155E0 RID: 87520 RVA: 0x001F655D File Offset: 0x001F475D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_Skill_KuroBullet._ClassPtr;
		}

		// Token: 0x060155E1 RID: 87521 RVA: 0x001F656C File Offset: 0x001F476C
		public UKSC_DA_Skill_KuroBullet() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Skill_KuroBullet.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060155E2 RID: 87522 RVA: 0x001F6594 File Offset: 0x001F4794
		public UKSC_DA_Skill_KuroBullet(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Skill_KuroBullet.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005466 RID: 21606
		// (get) Token: 0x060155E3 RID: 87523 RVA: 0x001F65C8 File Offset: 0x001F47C8
		// (set) Token: 0x060155E4 RID: 87524 RVA: 0x001F6601 File Offset: 0x001F4801
		public TArray<FKSC_SkillKuroBullet> Bullets
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKSC_SkillKuroBullet> result;
				if ((result = this._Bullets) == null)
				{
					result = (this._Bullets = new TArray<FKSC_SkillKuroBullet>(base.NativePtr + (IntPtr)UKSC_DA_Skill_KuroBullet.__PropertyOffset_Bullets, this));
				}
				return result;
			}
			set
			{
				this.Bullets.CopyAssign(value);
			}
		}

		// Token: 0x17005467 RID: 21607
		// (get) Token: 0x060155E5 RID: 87525 RVA: 0x001F660F File Offset: 0x001F480F
		// (set) Token: 0x060155E6 RID: 87526 RVA: 0x001F661F File Offset: 0x001F481F
		public unsafe EKSC_BulletTarget Target
		{
			get
			{
				return (EKSC_BulletTarget)(*(base.NativePtr + (IntPtr)UKSC_DA_Skill_KuroBullet.__PropertyOffset_Target));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Skill_KuroBullet.__PropertyOffset_Target) = (byte)value;
			}
		}

		// Token: 0x17005468 RID: 21608
		// (get) Token: 0x060155E7 RID: 87527 RVA: 0x001F6630 File Offset: 0x001F4830
		// (set) Token: 0x060155E8 RID: 87528 RVA: 0x001F6640 File Offset: 0x001F4840
		public unsafe EKuroBulletSkillDirection SkillDirection
		{
			get
			{
				return (EKuroBulletSkillDirection)(*(base.NativePtr + (IntPtr)UKSC_DA_Skill_KuroBullet.__PropertyOffset_SkillDirection));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Skill_KuroBullet.__PropertyOffset_SkillDirection) = (byte)value;
			}
		}

		// Token: 0x17005469 RID: 21609
		// (get) Token: 0x060155E9 RID: 87529 RVA: 0x001F6651 File Offset: 0x001F4851
		// (set) Token: 0x060155EA RID: 87530 RVA: 0x001F6661 File Offset: 0x001F4861
		public unsafe float CastRangeMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Skill_KuroBullet.__PropertyOffset_CastRangeMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Skill_KuroBullet.__PropertyOffset_CastRangeMin) = value;
			}
		}

		// Token: 0x1700546A RID: 21610
		// (get) Token: 0x060155EB RID: 87531 RVA: 0x001F6674 File Offset: 0x001F4874
		// (set) Token: 0x060155EC RID: 87532 RVA: 0x001F66AD File Offset: 0x001F48AD
		public TArray<long> AddBuffsToSelf
		{
			get
			{
				base.FastCheckIsValid();
				TArray<long> result;
				if ((result = this._AddBuffsToSelf) == null)
				{
					result = (this._AddBuffsToSelf = new TArray<long>(base.NativePtr + (IntPtr)UKSC_DA_Skill_KuroBullet.__PropertyOffset_AddBuffsToSelf, this));
				}
				return result;
			}
			set
			{
				this.AddBuffsToSelf.CopyAssign(value);
			}
		}

		// Token: 0x1700546B RID: 21611
		// (get) Token: 0x060155ED RID: 87533 RVA: 0x001F66BB File Offset: 0x001F48BB
		// (set) Token: 0x060155EE RID: 87534 RVA: 0x001F66CF File Offset: 0x001F48CF
		[Nullable(2)]
		public unsafe UKSC_DA_Buff AddBuffToSelf
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_Buff>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Skill_KuroBullet.__PropertyOffset_AddBuffToSelf);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Skill_KuroBullet.__PropertyOffset_AddBuffToSelf, value);
			}
		}

		// Token: 0x060155EF RID: 87535 RVA: 0x001F66E4 File Offset: 0x001F48E4
		static UKSC_DA_Skill_KuroBullet()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroBullet.KSC_DA_Skill_KuroBullet");
		}

		// Token: 0x060155F0 RID: 87536 RVA: 0x001F66F2 File Offset: 0x001F48F2
		protected UKSC_DA_Skill_KuroBullet(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400BA6E RID: 47726
		public new const string __ObjectPath = "/Script/KuroBullet.KSC_DA_Skill_KuroBullet";

		// Token: 0x0400BA6F RID: 47727
		private static IntPtr _ClassPtr;

		// Token: 0x0400BA70 RID: 47728
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400BA71 RID: 47729
		internal static int __PropertyOffset_Bullets;

		// Token: 0x0400BA72 RID: 47730
		[Nullable(2)]
		private TArray<FKSC_SkillKuroBullet> _Bullets;

		// Token: 0x0400BA73 RID: 47731
		internal static int __PropertyOffset_Target;

		// Token: 0x0400BA74 RID: 47732
		internal static int __PropertyOffset_SkillDirection;

		// Token: 0x0400BA75 RID: 47733
		internal static int __PropertyOffset_CastRangeMin;

		// Token: 0x0400BA76 RID: 47734
		internal static int __PropertyOffset_AddBuffsToSelf;

		// Token: 0x0400BA77 RID: 47735
		[Nullable(2)]
		private TArray<long> _AddBuffsToSelf;

		// Token: 0x0400BA78 RID: 47736
		internal static int __PropertyOffset_AddBuffToSelf;
	}
}
