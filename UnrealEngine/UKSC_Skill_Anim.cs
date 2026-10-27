using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001E41 RID: 7745
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Skill_Anim")]
	[UnrealStructLayout(184, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 184)]
	public class UKSC_Skill_Anim : UKSC_Skill, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D841 RID: 120897 RVA: 0x002B9548 File Offset: 0x002B7748
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Skill_Anim._ClassPtr;
		}

		// Token: 0x0601D842 RID: 120898 RVA: 0x002B9554 File Offset: 0x002B7754
		public UKSC_Skill_Anim() : this(BuiltinUtils.AllocNativeUObject(UKSC_Skill_Anim.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D843 RID: 120899 RVA: 0x002B957C File Offset: 0x002B777C
		[NullableContext(1)]
		public UKSC_Skill_Anim(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_Skill_Anim.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170076EF RID: 30447
		// (get) Token: 0x0601D844 RID: 120900 RVA: 0x002B95AF File Offset: 0x002B77AF
		// (set) Token: 0x0601D845 RID: 120901 RVA: 0x002B95C3 File Offset: 0x002B77C3
		[Nullable(2)]
		public unsafe UKSC_DA_Skill_Anim DaSkillAnim_
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_Skill_Anim>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Skill_Anim.__PropertyOffset_DaSkillAnim_);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Skill_Anim.__PropertyOffset_DaSkillAnim_, value);
			}
		}

		// Token: 0x0601D846 RID: 120902 RVA: 0x002B95D8 File Offset: 0x002B77D8
		static UKSC_Skill_Anim()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Skill_Anim");
		}

		// Token: 0x0601D847 RID: 120903 RVA: 0x002B95E6 File Offset: 0x002B77E6
		protected UKSC_Skill_Anim(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010003 RID: 65539
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Skill_Anim";

		// Token: 0x04010004 RID: 65540
		private static IntPtr _ClassPtr;

		// Token: 0x04010005 RID: 65541
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010006 RID: 65542
		internal static int __PropertyOffset_DaSkillAnim_;
	}
}
