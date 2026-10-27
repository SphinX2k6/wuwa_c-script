using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D08 RID: 7432
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Buff_AddSkill")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 104)]
	public class UKSC_Buff_AddSkill : UKSC_Buff, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601C93B RID: 117051 RVA: 0x002A3EDB File Offset: 0x002A20DB
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Buff_AddSkill._ClassPtr;
		}

		// Token: 0x0601C93C RID: 117052 RVA: 0x002A3EE8 File Offset: 0x002A20E8
		public UKSC_Buff_AddSkill() : this(BuiltinUtils.AllocNativeUObject(UKSC_Buff_AddSkill.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601C93D RID: 117053 RVA: 0x002A3F10 File Offset: 0x002A2110
		[NullableContext(1)]
		public UKSC_Buff_AddSkill(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_Buff_AddSkill.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007318 RID: 29464
		// (get) Token: 0x0601C93E RID: 117054 RVA: 0x002A3F43 File Offset: 0x002A2143
		// (set) Token: 0x0601C93F RID: 117055 RVA: 0x002A3F57 File Offset: 0x002A2157
		[Nullable(2)]
		public unsafe UKSC_DA_Buff_AddSkill DaBuffAddSkill_
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_Buff_AddSkill>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Buff_AddSkill.__PropertyOffset_DaBuffAddSkill_);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Buff_AddSkill.__PropertyOffset_DaBuffAddSkill_, value);
			}
		}

		// Token: 0x0601C940 RID: 117056 RVA: 0x002A3F6C File Offset: 0x002A216C
		static UKSC_Buff_AddSkill()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Buff_AddSkill");
		}

		// Token: 0x0601C941 RID: 117057 RVA: 0x002A3F7A File Offset: 0x002A217A
		protected UKSC_Buff_AddSkill(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F7DA RID: 63450
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Buff_AddSkill";

		// Token: 0x0400F7DB RID: 63451
		private static IntPtr _ClassPtr;

		// Token: 0x0400F7DC RID: 63452
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F7DD RID: 63453
		internal static int __PropertyOffset_DaBuffAddSkill_;
	}
}
