using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001734 RID: 5940
	[UnrealObjectPath("/Script/KuroBullet.KSC_Skill_KuroBullet")]
	[UnrealStructLayout(224, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 224)]
	public class UKSC_Skill_KuroBullet : UKSC_Skill_Anim, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06015629 RID: 87593 RVA: 0x001F6B9C File Offset: 0x001F4D9C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Skill_KuroBullet._ClassPtr;
		}

		// Token: 0x0601562A RID: 87594 RVA: 0x001F6BA8 File Offset: 0x001F4DA8
		public UKSC_Skill_KuroBullet() : this(BuiltinUtils.AllocNativeUObject(UKSC_Skill_KuroBullet.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601562B RID: 87595 RVA: 0x001F6BD0 File Offset: 0x001F4DD0
		[NullableContext(1)]
		public UKSC_Skill_KuroBullet(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_Skill_KuroBullet.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700547E RID: 21630
		// (get) Token: 0x0601562C RID: 87596 RVA: 0x001F6C03 File Offset: 0x001F4E03
		// (set) Token: 0x0601562D RID: 87597 RVA: 0x001F6C17 File Offset: 0x001F4E17
		[Nullable(2)]
		public unsafe UKSC_DA_Skill_KuroBullet DaSkillKuroBullet_
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_Skill_KuroBullet>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Skill_KuroBullet.__PropertyOffset_DaSkillKuroBullet_);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Skill_KuroBullet.__PropertyOffset_DaSkillKuroBullet_, value);
			}
		}

		// Token: 0x0601562E RID: 87598 RVA: 0x001F6C2C File Offset: 0x001F4E2C
		static UKSC_Skill_KuroBullet()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroBullet.KSC_Skill_KuroBullet");
		}

		// Token: 0x0601562F RID: 87599 RVA: 0x001F6C3A File Offset: 0x001F4E3A
		protected UKSC_Skill_KuroBullet(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400BA96 RID: 47766
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroBullet.KSC_Skill_KuroBullet";

		// Token: 0x0400BA97 RID: 47767
		private static IntPtr _ClassPtr;

		// Token: 0x0400BA98 RID: 47768
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400BA99 RID: 47769
		internal static int __PropertyOffset_DaSkillKuroBullet_;
	}
}
