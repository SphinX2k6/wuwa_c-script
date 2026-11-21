using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000591 RID: 1425
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Skill")]
	[UnrealStructLayout(168, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 168)]
	public abstract class UKSC_Skill : UKSC_BaseObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06008101 RID: 33025 RVA: 0x000BE6AC File Offset: 0x000BC8AC
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Skill._ClassPtr;
		}

		// Token: 0x1700191E RID: 6430
		// (get) Token: 0x06008102 RID: 33026 RVA: 0x000BE6B8 File Offset: 0x000BC8B8
		// (set) Token: 0x06008103 RID: 33027 RVA: 0x000BE6CC File Offset: 0x000BC8CC
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

		// Token: 0x1700191F RID: 6431
		// (get) Token: 0x06008104 RID: 33028 RVA: 0x000BE6E1 File Offset: 0x000BC8E1
		// (set) Token: 0x06008105 RID: 33029 RVA: 0x000BE6F5 File Offset: 0x000BC8F5
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

		// Token: 0x17001920 RID: 6432
		// (get) Token: 0x06008106 RID: 33030 RVA: 0x000BE70A File Offset: 0x000BC90A
		// (set) Token: 0x06008107 RID: 33031 RVA: 0x000BE71E File Offset: 0x000BC91E
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

		// Token: 0x17001921 RID: 6433
		// (get) Token: 0x06008108 RID: 33032 RVA: 0x000BE734 File Offset: 0x000BC934
		// (set) Token: 0x06008109 RID: 33033 RVA: 0x000BE76D File Offset: 0x000BC96D
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

		// Token: 0x17001922 RID: 6434
		// (get) Token: 0x0600810A RID: 33034 RVA: 0x000BE77B File Offset: 0x000BC97B
		// (set) Token: 0x0600810B RID: 33035 RVA: 0x000BE78B File Offset: 0x000BC98B
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

		// Token: 0x0600810C RID: 33036 RVA: 0x000BE79C File Offset: 0x000BC99C
		public float GetSkillCoolDownRemain()
		{
			return UKSC_Skill.__GetSkillCoolDownRemain_Internal(base.NativePtr);
		}

		// Token: 0x0600810D RID: 33037 RVA: 0x000BE7A9 File Offset: 0x000BC9A9
		public float GetSkillCoolDownMax()
		{
			return UKSC_Skill.__GetSkillCoolDownMax_Internal(base.NativePtr);
		}

		// Token: 0x0600810E RID: 33038
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetSkillCoolDownRemain_Internal(IntPtr @this);

		// Token: 0x0600810F RID: 33039
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetSkillCoolDownMax_Internal(IntPtr @this);

		// Token: 0x06008110 RID: 33040 RVA: 0x000BE7B6 File Offset: 0x000BC9B6
		static UKSC_Skill()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Skill");
		}

		// Token: 0x06008111 RID: 33041 RVA: 0x000BE7C4 File Offset: 0x000BC9C4
		protected UKSC_Skill() : this(BuiltinUtils.AllocNativeUObject(UKSC_Skill.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06008112 RID: 33042 RVA: 0x000BE7EC File Offset: 0x000BC9EC
		protected UKSC_Skill(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400384A RID: 14410
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Skill";

		// Token: 0x0400384B RID: 14411
		private static IntPtr _ClassPtr;

		// Token: 0x0400384C RID: 14412
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400384D RID: 14413
		internal static int __PropertyOffset_DaSkill_;

		// Token: 0x0400384E RID: 14414
		internal static int __PropertyOffset_Caster_;

		// Token: 0x0400384F RID: 14415
		internal static int __PropertyOffset_Target_;

		// Token: 0x04003850 RID: 14416
		internal static int __PropertyOffset_Targets_;

		// Token: 0x04003851 RID: 14417
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UKSC_SkillComp> _Targets_;

		// Token: 0x04003852 RID: 14418
		internal static int __PropertyOffset_SkillState_;
	}
}
