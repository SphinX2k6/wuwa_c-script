using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001DC3 RID: 7619
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_Skill_LandFire")]
	[UnrealStructLayout(608, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 608)]
	public class UKSC_DA_Skill_LandFire : UKSC_DA_Skill_RangeAttack, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D214 RID: 119316 RVA: 0x002B09F6 File Offset: 0x002AEBF6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_Skill_LandFire._ClassPtr;
		}

		// Token: 0x0601D215 RID: 119317 RVA: 0x002B0A04 File Offset: 0x002AEC04
		public UKSC_DA_Skill_LandFire() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Skill_LandFire.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D216 RID: 119318 RVA: 0x002B0A2C File Offset: 0x002AEC2C
		[NullableContext(1)]
		public UKSC_DA_Skill_LandFire(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Skill_LandFire.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170075A7 RID: 30119
		// (get) Token: 0x0601D217 RID: 119319 RVA: 0x002B0A5F File Offset: 0x002AEC5F
		// (set) Token: 0x0601D218 RID: 119320 RVA: 0x002B0A73 File Offset: 0x002AEC73
		public unsafe FGameplayTag ListenTag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Skill_LandFire.__PropertyOffset_ListenTag);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Skill_LandFire.__PropertyOffset_ListenTag) = value;
			}
		}

		// Token: 0x170075A8 RID: 30120
		// (get) Token: 0x0601D219 RID: 119321 RVA: 0x002B0A88 File Offset: 0x002AEC88
		// (set) Token: 0x0601D21A RID: 119322 RVA: 0x002B0A98 File Offset: 0x002AEC98
		public unsafe float ListenRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Skill_LandFire.__PropertyOffset_ListenRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Skill_LandFire.__PropertyOffset_ListenRange) = value;
			}
		}

		// Token: 0x170075A9 RID: 30121
		// (get) Token: 0x0601D21B RID: 119323 RVA: 0x002B0AA9 File Offset: 0x002AECA9
		// (set) Token: 0x0601D21C RID: 119324 RVA: 0x002B0AB9 File Offset: 0x002AECB9
		public unsafe float ListenTagIncTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Skill_LandFire.__PropertyOffset_ListenTagIncTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Skill_LandFire.__PropertyOffset_ListenTagIncTime) = value;
			}
		}

		// Token: 0x170075AA RID: 30122
		// (get) Token: 0x0601D21D RID: 119325 RVA: 0x002B0ACA File Offset: 0x002AECCA
		// (set) Token: 0x0601D21E RID: 119326 RVA: 0x002B0ADE File Offset: 0x002AECDE
		public unsafe UKSC_DA_Buff AddBuff6
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_Buff>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Skill_LandFire.__PropertyOffset_AddBuff6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Skill_LandFire.__PropertyOffset_AddBuff6, value);
			}
		}

		// Token: 0x170075AB RID: 30123
		// (get) Token: 0x0601D21F RID: 119327 RVA: 0x002B0AF3 File Offset: 0x002AECF3
		// (set) Token: 0x0601D220 RID: 119328 RVA: 0x002B0B07 File Offset: 0x002AED07
		public unsafe UKSC_DA_Buff AddBuff7
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_Buff>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Skill_LandFire.__PropertyOffset_AddBuff7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Skill_LandFire.__PropertyOffset_AddBuff7, value);
			}
		}

		// Token: 0x0601D221 RID: 119329 RVA: 0x002B0B1C File Offset: 0x002AED1C
		static UKSC_DA_Skill_LandFire()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_Skill_LandFire");
		}

		// Token: 0x0601D222 RID: 119330 RVA: 0x002B0B2A File Offset: 0x002AED2A
		protected UKSC_DA_Skill_LandFire(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FD08 RID: 64776
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_Skill_LandFire";

		// Token: 0x0400FD09 RID: 64777
		private static IntPtr _ClassPtr;

		// Token: 0x0400FD0A RID: 64778
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FD0B RID: 64779
		internal static int __PropertyOffset_ListenTag;

		// Token: 0x0400FD0C RID: 64780
		internal static int __PropertyOffset_ListenRange;

		// Token: 0x0400FD0D RID: 64781
		internal static int __PropertyOffset_ListenTagIncTime;

		// Token: 0x0400FD0E RID: 64782
		internal static int __PropertyOffset_AddBuff6;

		// Token: 0x0400FD0F RID: 64783
		internal static int __PropertyOffset_AddBuff7;
	}
}
