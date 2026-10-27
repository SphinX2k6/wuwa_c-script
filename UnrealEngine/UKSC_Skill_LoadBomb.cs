using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001E4A RID: 7754
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Skill_LoadBomb")]
	[UnrealStructLayout(352, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 352)]
	public class UKSC_Skill_LoadBomb : UKSC_Skill_RangeAttack, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D884 RID: 120964 RVA: 0x002B9B67 File Offset: 0x002B7D67
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Skill_LoadBomb._ClassPtr;
		}

		// Token: 0x0601D885 RID: 120965 RVA: 0x002B9B74 File Offset: 0x002B7D74
		public UKSC_Skill_LoadBomb() : this(BuiltinUtils.AllocNativeUObject(UKSC_Skill_LoadBomb.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D886 RID: 120966 RVA: 0x002B9B9C File Offset: 0x002B7D9C
		[NullableContext(1)]
		public UKSC_Skill_LoadBomb(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_Skill_LoadBomb.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170076F8 RID: 30456
		// (get) Token: 0x0601D887 RID: 120967 RVA: 0x002B9BCF File Offset: 0x002B7DCF
		// (set) Token: 0x0601D888 RID: 120968 RVA: 0x002B9BE3 File Offset: 0x002B7DE3
		[Nullable(2)]
		public unsafe UKSC_DA_Skill_LoadBomb DaSkillLoadBomb_
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_Skill_LoadBomb>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Skill_LoadBomb.__PropertyOffset_DaSkillLoadBomb_);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Skill_LoadBomb.__PropertyOffset_DaSkillLoadBomb_, value);
			}
		}

		// Token: 0x0601D889 RID: 120969 RVA: 0x002B9BF8 File Offset: 0x002B7DF8
		static UKSC_Skill_LoadBomb()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Skill_LoadBomb");
		}

		// Token: 0x0601D88A RID: 120970 RVA: 0x002B9C06 File Offset: 0x002B7E06
		protected UKSC_Skill_LoadBomb(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010027 RID: 65575
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Skill_LoadBomb";

		// Token: 0x04010028 RID: 65576
		private static IntPtr _ClassPtr;

		// Token: 0x04010029 RID: 65577
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401002A RID: 65578
		internal static int __PropertyOffset_DaSkillLoadBomb_;
	}
}
