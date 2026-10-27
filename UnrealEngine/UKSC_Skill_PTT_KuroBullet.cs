using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001735 RID: 5941
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroBullet.KSC_Skill_PTT_KuroBullet")]
	[UnrealStructLayout(304, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 304)]
	public class UKSC_Skill_PTT_KuroBullet : UKSC_Skill_Anim, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06015630 RID: 87600 RVA: 0x001F6C43 File Offset: 0x001F4E43
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Skill_PTT_KuroBullet._ClassPtr;
		}

		// Token: 0x06015631 RID: 87601 RVA: 0x001F6C50 File Offset: 0x001F4E50
		public UKSC_Skill_PTT_KuroBullet() : this(BuiltinUtils.AllocNativeUObject(UKSC_Skill_PTT_KuroBullet.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06015632 RID: 87602 RVA: 0x001F6C78 File Offset: 0x001F4E78
		[NullableContext(1)]
		public UKSC_Skill_PTT_KuroBullet(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_Skill_PTT_KuroBullet.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700547F RID: 21631
		// (get) Token: 0x06015633 RID: 87603 RVA: 0x001F6CAB File Offset: 0x001F4EAB
		// (set) Token: 0x06015634 RID: 87604 RVA: 0x001F6CBF File Offset: 0x001F4EBF
		public unsafe UKSC_DA_Skill_PTT_KuroBullet DaSkillKuroBullet_
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_Skill_PTT_KuroBullet>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Skill_PTT_KuroBullet.__PropertyOffset_DaSkillKuroBullet_);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Skill_PTT_KuroBullet.__PropertyOffset_DaSkillKuroBullet_, value);
			}
		}

		// Token: 0x17005480 RID: 21632
		// (get) Token: 0x06015635 RID: 87605 RVA: 0x001F6CD4 File Offset: 0x001F4ED4
		// (set) Token: 0x06015636 RID: 87606 RVA: 0x001F6CE8 File Offset: 0x001F4EE8
		public unsafe AKSC_Entity SkillTarget
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AKSC_Entity>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Skill_PTT_KuroBullet.__PropertyOffset_SkillTarget);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Skill_PTT_KuroBullet.__PropertyOffset_SkillTarget, value);
			}
		}

		// Token: 0x17005481 RID: 21633
		// (get) Token: 0x06015637 RID: 87607 RVA: 0x001F6CFD File Offset: 0x001F4EFD
		// (set) Token: 0x06015638 RID: 87608 RVA: 0x001F6D11 File Offset: 0x001F4F11
		public unsafe AKSC_Entity NearestEnemy
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AKSC_Entity>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Skill_PTT_KuroBullet.__PropertyOffset_NearestEnemy);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Skill_PTT_KuroBullet.__PropertyOffset_NearestEnemy, value);
			}
		}

		// Token: 0x06015639 RID: 87609 RVA: 0x001F6D26 File Offset: 0x001F4F26
		static UKSC_Skill_PTT_KuroBullet()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroBullet.KSC_Skill_PTT_KuroBullet");
		}

		// Token: 0x0601563A RID: 87610 RVA: 0x001F6D34 File Offset: 0x001F4F34
		protected UKSC_Skill_PTT_KuroBullet(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400BA9A RID: 47770
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroBullet.KSC_Skill_PTT_KuroBullet";

		// Token: 0x0400BA9B RID: 47771
		private static IntPtr _ClassPtr;

		// Token: 0x0400BA9C RID: 47772
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400BA9D RID: 47773
		internal static int __PropertyOffset_DaSkillKuroBullet_;

		// Token: 0x0400BA9E RID: 47774
		internal static int __PropertyOffset_SkillTarget;

		// Token: 0x0400BA9F RID: 47775
		internal static int __PropertyOffset_NearestEnemy;
	}
}
