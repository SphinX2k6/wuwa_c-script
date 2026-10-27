using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D52 RID: 7506
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_Buff_AddSkill")]
	[UnrealStructLayout(432, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 432)]
	public class UKSC_DA_Buff_AddSkill : UKSC_DA_Buff, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601CBE7 RID: 117735 RVA: 0x002A7CD4 File Offset: 0x002A5ED4
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_Buff_AddSkill._ClassPtr;
		}

		// Token: 0x0601CBE8 RID: 117736 RVA: 0x002A7CE0 File Offset: 0x002A5EE0
		public UKSC_DA_Buff_AddSkill() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Buff_AddSkill.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601CBE9 RID: 117737 RVA: 0x002A7D08 File Offset: 0x002A5F08
		[NullableContext(1)]
		public UKSC_DA_Buff_AddSkill(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Buff_AddSkill.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170073AA RID: 29610
		// (get) Token: 0x0601CBEA RID: 117738 RVA: 0x002A7D3B File Offset: 0x002A5F3B
		// (set) Token: 0x0601CBEB RID: 117739 RVA: 0x002A7D4F File Offset: 0x002A5F4F
		[Nullable(2)]
		public unsafe UKSC_DA_Skill DaSkill
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_Skill>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Buff_AddSkill.__PropertyOffset_DaSkill);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Buff_AddSkill.__PropertyOffset_DaSkill, value);
			}
		}

		// Token: 0x0601CBEC RID: 117740 RVA: 0x002A7D64 File Offset: 0x002A5F64
		static UKSC_DA_Buff_AddSkill()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_Buff_AddSkill");
		}

		// Token: 0x0601CBED RID: 117741 RVA: 0x002A7D72 File Offset: 0x002A5F72
		protected UKSC_DA_Buff_AddSkill(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F95E RID: 63838
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_Buff_AddSkill";

		// Token: 0x0400F95F RID: 63839
		private static IntPtr _ClassPtr;

		// Token: 0x0400F960 RID: 63840
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F961 RID: 63841
		internal static int __PropertyOffset_DaSkill;
	}
}
