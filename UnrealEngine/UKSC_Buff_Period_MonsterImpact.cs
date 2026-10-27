using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D2E RID: 7470
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Buff_Period_MonsterImpact")]
	[UnrealStructLayout(272, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 272)]
	public class UKSC_Buff_Period_MonsterImpact : UKSC_Buff_Period, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601CA63 RID: 117347 RVA: 0x002A5A2F File Offset: 0x002A3C2F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Buff_Period_MonsterImpact._ClassPtr;
		}

		// Token: 0x0601CA64 RID: 117348 RVA: 0x002A5A3C File Offset: 0x002A3C3C
		public UKSC_Buff_Period_MonsterImpact() : this(BuiltinUtils.AllocNativeUObject(UKSC_Buff_Period_MonsterImpact.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601CA65 RID: 117349 RVA: 0x002A5A64 File Offset: 0x002A3C64
		[NullableContext(1)]
		public UKSC_Buff_Period_MonsterImpact(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_Buff_Period_MonsterImpact.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007348 RID: 29512
		// (get) Token: 0x0601CA66 RID: 117350 RVA: 0x002A5A97 File Offset: 0x002A3C97
		// (set) Token: 0x0601CA67 RID: 117351 RVA: 0x002A5AAB File Offset: 0x002A3CAB
		[Nullable(2)]
		public unsafe UKSC_DA_Buff_Period_MonsterImpact DaBuffPeriodMonsterImpact_
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_Buff_Period_MonsterImpact>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Buff_Period_MonsterImpact.__PropertyOffset_DaBuffPeriodMonsterImpact_);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Buff_Period_MonsterImpact.__PropertyOffset_DaBuffPeriodMonsterImpact_, value);
			}
		}

		// Token: 0x0601CA68 RID: 117352 RVA: 0x002A5AC0 File Offset: 0x002A3CC0
		static UKSC_Buff_Period_MonsterImpact()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Buff_Period_MonsterImpact");
		}

		// Token: 0x0601CA69 RID: 117353 RVA: 0x002A5ACE File Offset: 0x002A3CCE
		protected UKSC_Buff_Period_MonsterImpact(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F880 RID: 63616
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Buff_Period_MonsterImpact";

		// Token: 0x0400F881 RID: 63617
		private static IntPtr _ClassPtr;

		// Token: 0x0400F882 RID: 63618
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F883 RID: 63619
		internal static int __PropertyOffset_DaBuffPeriodMonsterImpact_;
	}
}
