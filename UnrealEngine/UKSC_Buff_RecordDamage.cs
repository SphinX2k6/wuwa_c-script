using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D31 RID: 7473
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Buff_RecordDamage")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 104)]
	public class UKSC_Buff_RecordDamage : UKSC_Buff, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601CA78 RID: 117368 RVA: 0x002A5C27 File Offset: 0x002A3E27
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Buff_RecordDamage._ClassPtr;
		}

		// Token: 0x0601CA79 RID: 117369 RVA: 0x002A5C34 File Offset: 0x002A3E34
		public UKSC_Buff_RecordDamage() : this(BuiltinUtils.AllocNativeUObject(UKSC_Buff_RecordDamage.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601CA7A RID: 117370 RVA: 0x002A5C5C File Offset: 0x002A3E5C
		[NullableContext(1)]
		public UKSC_Buff_RecordDamage(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_Buff_RecordDamage.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700734B RID: 29515
		// (get) Token: 0x0601CA7B RID: 117371 RVA: 0x002A5C8F File Offset: 0x002A3E8F
		// (set) Token: 0x0601CA7C RID: 117372 RVA: 0x002A5CA3 File Offset: 0x002A3EA3
		[Nullable(2)]
		public unsafe UKSC_DA_Buff_RecordDamage DaBuffRecordDamage_
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_Buff_RecordDamage>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Buff_RecordDamage.__PropertyOffset_DaBuffRecordDamage_);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Buff_RecordDamage.__PropertyOffset_DaBuffRecordDamage_, value);
			}
		}

		// Token: 0x0601CA7D RID: 117373 RVA: 0x002A5CB8 File Offset: 0x002A3EB8
		static UKSC_Buff_RecordDamage()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Buff_RecordDamage");
		}

		// Token: 0x0601CA7E RID: 117374 RVA: 0x002A5CC6 File Offset: 0x002A3EC6
		protected UKSC_Buff_RecordDamage(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F88C RID: 63628
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Buff_RecordDamage";

		// Token: 0x0400F88D RID: 63629
		private static IntPtr _ClassPtr;

		// Token: 0x0400F88E RID: 63630
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F88F RID: 63631
		internal static int __PropertyOffset_DaBuffRecordDamage_;
	}
}
