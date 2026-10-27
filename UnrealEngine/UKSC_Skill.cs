using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001E3E RID: 7742
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Skill")]
	[UnrealStructLayout(168, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 168)]
	public abstract class UKSC_Skill : UKSC_BaseObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D7F9 RID: 120825 RVA: 0x002B8DAA File Offset: 0x002B6FAA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Skill._ClassPtr;
		}

		// Token: 0x170076D8 RID: 30424
		// (get) Token: 0x0601D7FA RID: 120826 RVA: 0x002B8DB6 File Offset: 0x002B6FB6
		// (set) Token: 0x0601D7FB RID: 120827 RVA: 0x002B8DCA File Offset: 0x002B6FCA
		public unsafe UKSC_DA_Skill DaSkill_
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_Skill>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Skill.__PropertyOffset_DaSkill_);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Skill.__PropertyOffset_DaSkill_, value);
			}
		}

		// Token: 0x170076D9 RID: 30425
		// (get) Token: 0x0601D7FC RID: 120828 RVA: 0x002B8DDF File Offset: 0x002B6FDF
		// (set) Token: 0x0601D7FD RID: 120829 RVA: 0x002B8DF3 File Offset: 0x002B6FF3
		public unsafe UKSC_SkillComp Caster_
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_SkillComp>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Skill.__PropertyOffset_Caster_);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Skill.__PropertyOffset_Caster_, value);
			}
		}

		// Token: 0x170076DA RID: 30426
		// (get) Token: 0x0601D7FE RID: 120830 RVA: 0x002B8E08 File Offset: 0x002B7008
		// (set) Token: 0x0601D7FF RID: 120831 RVA: 0x002B8E1C File Offset: 0x002B701C
		public unsafe UKSC_SkillComp Target_
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_SkillComp>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Skill.__PropertyOffset_Target_);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Skill.__PropertyOffset_Target_, value);
			}
		}

		// Token: 0x170076DB RID: 30427
		// (get) Token: 0x0601D800 RID: 120832 RVA: 0x002B8E34 File Offset: 0x002B7034
		// (set) Token: 0x0601D801 RID: 120833 RVA: 0x002B8E6D File Offset: 0x002B706D
		[Nullable(1)]
		public TArray<UKSC_SkillComp> Targets_
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UKSC_SkillComp> result;
				if ((result = this._Targets_) == null)
				{
					result = (this._Targets_ = new TArray<UKSC_SkillComp>(base.NativePtr + (IntPtr)UKSC_Skill.__PropertyOffset_Targets_, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Targets_.CopyAssign(value);
			}
		}

		// Token: 0x170076DC RID: 30428
		// (get) Token: 0x0601D802 RID: 120834 RVA: 0x002B8E7B File Offset: 0x002B707B
		// (set) Token: 0x0601D803 RID: 120835 RVA: 0x002B8E8B File Offset: 0x002B708B
		public unsafe EKSC_Skill_State SkillState_
		{
			get
			{
				return (EKSC_Skill_State)(*(base.NativePtr + (IntPtr)UKSC_Skill.__PropertyOffset_SkillState_));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_Skill.__PropertyOffset_SkillState_) = (byte)value;
			}
		}

		// Token: 0x0601D804 RID: 120836 RVA: 0x002B8E9C File Offset: 0x002B709C
		public float GetSkillCoolDownRemain()
		{
			return UKSC_Skill.__GetSkillCoolDownRemain_Internal(base.NativePtr);
		}

		// Token: 0x0601D805 RID: 120837 RVA: 0x002B8EA9 File Offset: 0x002B70A9
		public float GetSkillCoolDownMax()
		{
			return UKSC_Skill.__GetSkillCoolDownMax_Internal(base.NativePtr);
		}

		// Token: 0x0601D806 RID: 120838
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetSkillCoolDownRemain_Internal(IntPtr @this);

		// Token: 0x0601D807 RID: 120839
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetSkillCoolDownMax_Internal(IntPtr @this);

		// Token: 0x0601D808 RID: 120840 RVA: 0x002B8EB6 File Offset: 0x002B70B6
		static UKSC_Skill()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Skill");
		}

		// Token: 0x0601D809 RID: 120841 RVA: 0x002B8EC4 File Offset: 0x002B70C4
		protected UKSC_Skill() : this(BuiltinUtils.AllocNativeUObject(UKSC_Skill.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D80A RID: 120842 RVA: 0x002B8EEC File Offset: 0x002B70EC
		protected UKSC_Skill(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FFD1 RID: 65489
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Skill";

		// Token: 0x0400FFD2 RID: 65490
		private static IntPtr _ClassPtr;

		// Token: 0x0400FFD3 RID: 65491
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FFD4 RID: 65492
		internal static int __PropertyOffset_DaSkill_;

		// Token: 0x0400FFD5 RID: 65493
		internal static int __PropertyOffset_Caster_;

		// Token: 0x0400FFD6 RID: 65494
		internal static int __PropertyOffset_Target_;

		// Token: 0x0400FFD7 RID: 65495
		internal static int __PropertyOffset_Targets_;

		// Token: 0x0400FFD8 RID: 65496
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UKSC_SkillComp> _Targets_;

		// Token: 0x0400FFD9 RID: 65497
		internal static int __PropertyOffset_SkillState_;
	}
}
