using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001DC2 RID: 7618
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_Skill_Dash")]
	[UnrealStructLayout(464, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 464)]
	public class UKSC_DA_Skill_Dash : UKSC_DA_Skill_Anim, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D203 RID: 119299 RVA: 0x002B0863 File Offset: 0x002AEA63
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_Skill_Dash._ClassPtr;
		}

		// Token: 0x0601D204 RID: 119300 RVA: 0x002B0870 File Offset: 0x002AEA70
		public UKSC_DA_Skill_Dash() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Skill_Dash.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D205 RID: 119301 RVA: 0x002B0898 File Offset: 0x002AEA98
		public UKSC_DA_Skill_Dash(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Skill_Dash.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170075A1 RID: 30113
		// (get) Token: 0x0601D206 RID: 119302 RVA: 0x002B08CC File Offset: 0x002AEACC
		// (set) Token: 0x0601D207 RID: 119303 RVA: 0x002B0905 File Offset: 0x002AEB05
		public TArray<FKSC_SkillDashBullet> Bullets
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKSC_SkillDashBullet> result;
				if ((result = this._Bullets) == null)
				{
					result = (this._Bullets = new TArray<FKSC_SkillDashBullet>(base.NativePtr + (IntPtr)UKSC_DA_Skill_Dash.__PropertyOffset_Bullets, this));
				}
				return result;
			}
			set
			{
				this.Bullets.CopyAssign(value);
			}
		}

		// Token: 0x170075A2 RID: 30114
		// (get) Token: 0x0601D208 RID: 119304 RVA: 0x002B0913 File Offset: 0x002AEB13
		// (set) Token: 0x0601D209 RID: 119305 RVA: 0x002B0923 File Offset: 0x002AEB23
		public unsafe EKSC_SkillTarget Target
		{
			get
			{
				return (EKSC_SkillTarget)(*(base.NativePtr + (IntPtr)UKSC_DA_Skill_Dash.__PropertyOffset_Target));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Skill_Dash.__PropertyOffset_Target) = (byte)value;
			}
		}

		// Token: 0x170075A3 RID: 30115
		// (get) Token: 0x0601D20A RID: 119306 RVA: 0x002B0934 File Offset: 0x002AEB34
		// (set) Token: 0x0601D20B RID: 119307 RVA: 0x002B0944 File Offset: 0x002AEB44
		public unsafe EKSC_SkillDirection Direction
		{
			get
			{
				return (EKSC_SkillDirection)(*(base.NativePtr + (IntPtr)UKSC_DA_Skill_Dash.__PropertyOffset_Direction));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Skill_Dash.__PropertyOffset_Direction) = (byte)value;
			}
		}

		// Token: 0x170075A4 RID: 30116
		// (get) Token: 0x0601D20C RID: 119308 RVA: 0x002B0955 File Offset: 0x002AEB55
		// (set) Token: 0x0601D20D RID: 119309 RVA: 0x002B0965 File Offset: 0x002AEB65
		public unsafe float Speed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Skill_Dash.__PropertyOffset_Speed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Skill_Dash.__PropertyOffset_Speed) = value;
			}
		}

		// Token: 0x170075A5 RID: 30117
		// (get) Token: 0x0601D20E RID: 119310 RVA: 0x002B0976 File Offset: 0x002AEB76
		// (set) Token: 0x0601D20F RID: 119311 RVA: 0x002B0986 File Offset: 0x002AEB86
		public unsafe bool bIgnoreKnock
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Skill_Dash.__PropertyOffset_bIgnoreKnock) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Skill_Dash.__PropertyOffset_bIgnoreKnock) = (value ? 1 : 0);
			}
		}

		// Token: 0x170075A6 RID: 30118
		// (get) Token: 0x0601D210 RID: 119312 RVA: 0x002B0998 File Offset: 0x002AEB98
		// (set) Token: 0x0601D211 RID: 119313 RVA: 0x002B09D1 File Offset: 0x002AEBD1
		public TArray<UKSC_DA_Buff> AddBuffsToSelf
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UKSC_DA_Buff> result;
				if ((result = this._AddBuffsToSelf) == null)
				{
					result = (this._AddBuffsToSelf = new TArray<UKSC_DA_Buff>(base.NativePtr + (IntPtr)UKSC_DA_Skill_Dash.__PropertyOffset_AddBuffsToSelf, this));
				}
				return result;
			}
			set
			{
				this.AddBuffsToSelf.CopyAssign(value);
			}
		}

		// Token: 0x0601D212 RID: 119314 RVA: 0x002B09DF File Offset: 0x002AEBDF
		static UKSC_DA_Skill_Dash()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_Skill_Dash");
		}

		// Token: 0x0601D213 RID: 119315 RVA: 0x002B09ED File Offset: 0x002AEBED
		protected UKSC_DA_Skill_Dash(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FCFD RID: 64765
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_Skill_Dash";

		// Token: 0x0400FCFE RID: 64766
		private static IntPtr _ClassPtr;

		// Token: 0x0400FCFF RID: 64767
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FD00 RID: 64768
		internal static int __PropertyOffset_Bullets;

		// Token: 0x0400FD01 RID: 64769
		[Nullable(2)]
		private TArray<FKSC_SkillDashBullet> _Bullets;

		// Token: 0x0400FD02 RID: 64770
		internal static int __PropertyOffset_Target;

		// Token: 0x0400FD03 RID: 64771
		internal static int __PropertyOffset_Direction;

		// Token: 0x0400FD04 RID: 64772
		internal static int __PropertyOffset_Speed;

		// Token: 0x0400FD05 RID: 64773
		internal static int __PropertyOffset_bIgnoreKnock;

		// Token: 0x0400FD06 RID: 64774
		internal static int __PropertyOffset_AddBuffsToSelf;

		// Token: 0x0400FD07 RID: 64775
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UKSC_DA_Buff> _AddBuffsToSelf;
	}
}
