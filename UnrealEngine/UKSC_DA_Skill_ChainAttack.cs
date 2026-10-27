using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001DC1 RID: 7617
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_Skill_ChainAttack")]
	[UnrealStructLayout(416, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 416)]
	public class UKSC_DA_Skill_ChainAttack : UKSC_DA_Skill, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D1FC RID: 119292 RVA: 0x002B07C2 File Offset: 0x002AE9C2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_Skill_ChainAttack._ClassPtr;
		}

		// Token: 0x0601D1FD RID: 119293 RVA: 0x002B07D0 File Offset: 0x002AE9D0
		public UKSC_DA_Skill_ChainAttack() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Skill_ChainAttack.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D1FE RID: 119294 RVA: 0x002B07F8 File Offset: 0x002AE9F8
		[NullableContext(1)]
		public UKSC_DA_Skill_ChainAttack(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Skill_ChainAttack.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170075A0 RID: 30112
		// (get) Token: 0x0601D1FF RID: 119295 RVA: 0x002B082B File Offset: 0x002AEA2B
		// (set) Token: 0x0601D200 RID: 119296 RVA: 0x002B083B File Offset: 0x002AEA3B
		public unsafe int ChainNum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Skill_ChainAttack.__PropertyOffset_ChainNum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Skill_ChainAttack.__PropertyOffset_ChainNum) = value;
			}
		}

		// Token: 0x0601D201 RID: 119297 RVA: 0x002B084C File Offset: 0x002AEA4C
		static UKSC_DA_Skill_ChainAttack()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_Skill_ChainAttack");
		}

		// Token: 0x0601D202 RID: 119298 RVA: 0x002B085A File Offset: 0x002AEA5A
		protected UKSC_DA_Skill_ChainAttack(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FCF9 RID: 64761
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_Skill_ChainAttack";

		// Token: 0x0400FCFA RID: 64762
		private static IntPtr _ClassPtr;

		// Token: 0x0400FCFB RID: 64763
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FCFC RID: 64764
		internal static int __PropertyOffset_ChainNum;
	}
}
