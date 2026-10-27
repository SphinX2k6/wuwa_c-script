using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001DCA RID: 7626
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_Skill_RangePersistentAttack")]
	[UnrealStructLayout(576, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 576)]
	public class UKSC_DA_Skill_RangePersistentAttack : UKSC_DA_Skill_RangeAttack, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D27D RID: 119421 RVA: 0x002B130F File Offset: 0x002AF50F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_Skill_RangePersistentAttack._ClassPtr;
		}

		// Token: 0x0601D27E RID: 119422 RVA: 0x002B131C File Offset: 0x002AF51C
		public UKSC_DA_Skill_RangePersistentAttack() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Skill_RangePersistentAttack.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D27F RID: 119423 RVA: 0x002B1344 File Offset: 0x002AF544
		[NullableContext(1)]
		public UKSC_DA_Skill_RangePersistentAttack(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Skill_RangePersistentAttack.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170075CA RID: 30154
		// (get) Token: 0x0601D280 RID: 119424 RVA: 0x002B1377 File Offset: 0x002AF577
		// (set) Token: 0x0601D281 RID: 119425 RVA: 0x002B1387 File Offset: 0x002AF587
		public unsafe float PersistentTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Skill_RangePersistentAttack.__PropertyOffset_PersistentTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Skill_RangePersistentAttack.__PropertyOffset_PersistentTime) = value;
			}
		}

		// Token: 0x170075CB RID: 30155
		// (get) Token: 0x0601D282 RID: 119426 RVA: 0x002B1398 File Offset: 0x002AF598
		// (set) Token: 0x0601D283 RID: 119427 RVA: 0x002B13A8 File Offset: 0x002AF5A8
		public unsafe float Period
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Skill_RangePersistentAttack.__PropertyOffset_Period);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Skill_RangePersistentAttack.__PropertyOffset_Period) = value;
			}
		}

		// Token: 0x0601D284 RID: 119428 RVA: 0x002B13B9 File Offset: 0x002AF5B9
		static UKSC_DA_Skill_RangePersistentAttack()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_Skill_RangePersistentAttack");
		}

		// Token: 0x0601D285 RID: 119429 RVA: 0x002B13C7 File Offset: 0x002AF5C7
		protected UKSC_DA_Skill_RangePersistentAttack(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FD43 RID: 64835
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_Skill_RangePersistentAttack";

		// Token: 0x0400FD44 RID: 64836
		private static IntPtr _ClassPtr;

		// Token: 0x0400FD45 RID: 64837
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FD46 RID: 64838
		internal static int __PropertyOffset_PersistentTime;

		// Token: 0x0400FD47 RID: 64839
		internal static int __PropertyOffset_Period;
	}
}
