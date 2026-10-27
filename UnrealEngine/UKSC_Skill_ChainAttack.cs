using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001E47 RID: 7751
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Skill_ChainAttack")]
	[UnrealStructLayout(176, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 176)]
	public class UKSC_Skill_ChainAttack : UKSC_Skill, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D86F RID: 120943 RVA: 0x002B9970 File Offset: 0x002B7B70
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Skill_ChainAttack._ClassPtr;
		}

		// Token: 0x0601D870 RID: 120944 RVA: 0x002B997C File Offset: 0x002B7B7C
		public UKSC_Skill_ChainAttack() : this(BuiltinUtils.AllocNativeUObject(UKSC_Skill_ChainAttack.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D871 RID: 120945 RVA: 0x002B99A4 File Offset: 0x002B7BA4
		[NullableContext(1)]
		public UKSC_Skill_ChainAttack(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_Skill_ChainAttack.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170076F5 RID: 30453
		// (get) Token: 0x0601D872 RID: 120946 RVA: 0x002B99D7 File Offset: 0x002B7BD7
		// (set) Token: 0x0601D873 RID: 120947 RVA: 0x002B99EB File Offset: 0x002B7BEB
		[Nullable(2)]
		public unsafe UKSC_DA_Skill_ChainAttack DaSkillChainAttack_
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_Skill_ChainAttack>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Skill_ChainAttack.__PropertyOffset_DaSkillChainAttack_);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Skill_ChainAttack.__PropertyOffset_DaSkillChainAttack_, value);
			}
		}

		// Token: 0x0601D874 RID: 120948 RVA: 0x002B9A00 File Offset: 0x002B7C00
		static UKSC_Skill_ChainAttack()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Skill_ChainAttack");
		}

		// Token: 0x0601D875 RID: 120949 RVA: 0x002B9A0E File Offset: 0x002B7C0E
		protected UKSC_Skill_ChainAttack(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401001B RID: 65563
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Skill_ChainAttack";

		// Token: 0x0401001C RID: 65564
		private static IntPtr _ClassPtr;

		// Token: 0x0401001D RID: 65565
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401001E RID: 65566
		internal static int __PropertyOffset_DaSkillChainAttack_;
	}
}
