using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001E49 RID: 7753
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Skill_LandFire")]
	[UnrealStructLayout(240, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 240)]
	public class UKSC_Skill_LandFire : UKSC_Skill_RangeAttack, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D87D RID: 120957 RVA: 0x002B9ABF File Offset: 0x002B7CBF
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Skill_LandFire._ClassPtr;
		}

		// Token: 0x0601D87E RID: 120958 RVA: 0x002B9ACC File Offset: 0x002B7CCC
		public UKSC_Skill_LandFire() : this(BuiltinUtils.AllocNativeUObject(UKSC_Skill_LandFire.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D87F RID: 120959 RVA: 0x002B9AF4 File Offset: 0x002B7CF4
		[NullableContext(1)]
		public UKSC_Skill_LandFire(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_Skill_LandFire.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170076F7 RID: 30455
		// (get) Token: 0x0601D880 RID: 120960 RVA: 0x002B9B27 File Offset: 0x002B7D27
		// (set) Token: 0x0601D881 RID: 120961 RVA: 0x002B9B3B File Offset: 0x002B7D3B
		[Nullable(2)]
		public unsafe UKSC_DA_Skill_LandFire DaSkillLandFire_
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_Skill_LandFire>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Skill_LandFire.__PropertyOffset_DaSkillLandFire_);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Skill_LandFire.__PropertyOffset_DaSkillLandFire_, value);
			}
		}

		// Token: 0x0601D882 RID: 120962 RVA: 0x002B9B50 File Offset: 0x002B7D50
		static UKSC_Skill_LandFire()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Skill_LandFire");
		}

		// Token: 0x0601D883 RID: 120963 RVA: 0x002B9B5E File Offset: 0x002B7D5E
		protected UKSC_Skill_LandFire(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010023 RID: 65571
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Skill_LandFire";

		// Token: 0x04010024 RID: 65572
		private static IntPtr _ClassPtr;

		// Token: 0x04010025 RID: 65573
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010026 RID: 65574
		internal static int __PropertyOffset_DaSkillLandFire_;
	}
}
