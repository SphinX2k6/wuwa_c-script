using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001DBD RID: 7613
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_Skill_Attack_Persistent")]
	[UnrealStructLayout(416, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 416)]
	public class UKSC_DA_Skill_Attack_Persistent : UKSC_DA_Skill, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D1D4 RID: 119252 RVA: 0x002B0469 File Offset: 0x002AE669
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_Skill_Attack_Persistent._ClassPtr;
		}

		// Token: 0x0601D1D5 RID: 119253 RVA: 0x002B0478 File Offset: 0x002AE678
		public UKSC_DA_Skill_Attack_Persistent() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Skill_Attack_Persistent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D1D6 RID: 119254 RVA: 0x002B04A0 File Offset: 0x002AE6A0
		[NullableContext(1)]
		public UKSC_DA_Skill_Attack_Persistent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Skill_Attack_Persistent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007596 RID: 30102
		// (get) Token: 0x0601D1D7 RID: 119255 RVA: 0x002B04D3 File Offset: 0x002AE6D3
		// (set) Token: 0x0601D1D8 RID: 119256 RVA: 0x002B04E3 File Offset: 0x002AE6E3
		public unsafe float PersistentTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Skill_Attack_Persistent.__PropertyOffset_PersistentTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Skill_Attack_Persistent.__PropertyOffset_PersistentTime) = value;
			}
		}

		// Token: 0x17007597 RID: 30103
		// (get) Token: 0x0601D1D9 RID: 119257 RVA: 0x002B04F4 File Offset: 0x002AE6F4
		// (set) Token: 0x0601D1DA RID: 119258 RVA: 0x002B0504 File Offset: 0x002AE704
		public unsafe float Period
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Skill_Attack_Persistent.__PropertyOffset_Period);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Skill_Attack_Persistent.__PropertyOffset_Period) = value;
			}
		}

		// Token: 0x17007598 RID: 30104
		// (get) Token: 0x0601D1DB RID: 119259 RVA: 0x002B0515 File Offset: 0x002AE715
		// (set) Token: 0x0601D1DC RID: 119260 RVA: 0x002B0525 File Offset: 0x002AE725
		public unsafe bool PeriodImmediately
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Skill_Attack_Persistent.__PropertyOffset_PeriodImmediately) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Skill_Attack_Persistent.__PropertyOffset_PeriodImmediately) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601D1DD RID: 119261 RVA: 0x002B0536 File Offset: 0x002AE736
		static UKSC_DA_Skill_Attack_Persistent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_Skill_Attack_Persistent");
		}

		// Token: 0x0601D1DE RID: 119262 RVA: 0x002B0544 File Offset: 0x002AE744
		protected UKSC_DA_Skill_Attack_Persistent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FCE3 RID: 64739
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_Skill_Attack_Persistent";

		// Token: 0x0400FCE4 RID: 64740
		private static IntPtr _ClassPtr;

		// Token: 0x0400FCE5 RID: 64741
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FCE6 RID: 64742
		internal static int __PropertyOffset_PersistentTime;

		// Token: 0x0400FCE7 RID: 64743
		internal static int __PropertyOffset_Period;

		// Token: 0x0400FCE8 RID: 64744
		internal static int __PropertyOffset_PeriodImmediately;
	}
}
