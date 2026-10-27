using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D8C RID: 7564
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_Decorator_AddSkill")]
	[UnrealStructLayout(120, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 120)]
	public class UKSC_DA_Decorator_AddSkill : UKSC_DA_Decorator, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601CF42 RID: 118594 RVA: 0x002ACC05 File Offset: 0x002AAE05
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_Decorator_AddSkill._ClassPtr;
		}

		// Token: 0x0601CF43 RID: 118595 RVA: 0x002ACC14 File Offset: 0x002AAE14
		public UKSC_DA_Decorator_AddSkill() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Decorator_AddSkill.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601CF44 RID: 118596 RVA: 0x002ACC3C File Offset: 0x002AAE3C
		[NullableContext(1)]
		public UKSC_DA_Decorator_AddSkill(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Decorator_AddSkill.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170074C8 RID: 29896
		// (get) Token: 0x0601CF45 RID: 118597 RVA: 0x002ACC6F File Offset: 0x002AAE6F
		// (set) Token: 0x0601CF46 RID: 118598 RVA: 0x002ACC83 File Offset: 0x002AAE83
		[Nullable(2)]
		public unsafe UKSC_DA_Skill AddSkill
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_Skill>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Decorator_AddSkill.__PropertyOffset_AddSkill);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Decorator_AddSkill.__PropertyOffset_AddSkill, value);
			}
		}

		// Token: 0x0601CF47 RID: 118599 RVA: 0x002ACC98 File Offset: 0x002AAE98
		static UKSC_DA_Decorator_AddSkill()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_Decorator_AddSkill");
		}

		// Token: 0x0601CF48 RID: 118600 RVA: 0x002ACCA6 File Offset: 0x002AAEA6
		protected UKSC_DA_Decorator_AddSkill(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FB6C RID: 64364
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_Decorator_AddSkill";

		// Token: 0x0400FB6D RID: 64365
		private static IntPtr _ClassPtr;

		// Token: 0x0400FB6E RID: 64366
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FB6F RID: 64367
		internal static int __PropertyOffset_AddSkill;
	}
}
