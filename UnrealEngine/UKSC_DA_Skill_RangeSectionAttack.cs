using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001DCB RID: 7627
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_Skill_RangeSectionAttack")]
	[UnrealStructLayout(576, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 576)]
	public class UKSC_DA_Skill_RangeSectionAttack : UKSC_DA_Skill_RangeAttack, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D286 RID: 119430 RVA: 0x002B13D0 File Offset: 0x002AF5D0
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_Skill_RangeSectionAttack._ClassPtr;
		}

		// Token: 0x0601D287 RID: 119431 RVA: 0x002B13DC File Offset: 0x002AF5DC
		public UKSC_DA_Skill_RangeSectionAttack() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Skill_RangeSectionAttack.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D288 RID: 119432 RVA: 0x002B1404 File Offset: 0x002AF604
		[NullableContext(1)]
		public UKSC_DA_Skill_RangeSectionAttack(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Skill_RangeSectionAttack.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170075CC RID: 30156
		// (get) Token: 0x0601D289 RID: 119433 RVA: 0x002B1437 File Offset: 0x002AF637
		// (set) Token: 0x0601D28A RID: 119434 RVA: 0x002B1447 File Offset: 0x002AF647
		public unsafe int SectionCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Skill_RangeSectionAttack.__PropertyOffset_SectionCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Skill_RangeSectionAttack.__PropertyOffset_SectionCount) = value;
			}
		}

		// Token: 0x170075CD RID: 30157
		// (get) Token: 0x0601D28B RID: 119435 RVA: 0x002B1458 File Offset: 0x002AF658
		// (set) Token: 0x0601D28C RID: 119436 RVA: 0x002B1468 File Offset: 0x002AF668
		public unsafe float SectionTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Skill_RangeSectionAttack.__PropertyOffset_SectionTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Skill_RangeSectionAttack.__PropertyOffset_SectionTime) = value;
			}
		}

		// Token: 0x0601D28D RID: 119437 RVA: 0x002B1479 File Offset: 0x002AF679
		static UKSC_DA_Skill_RangeSectionAttack()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_Skill_RangeSectionAttack");
		}

		// Token: 0x0601D28E RID: 119438 RVA: 0x002B1487 File Offset: 0x002AF687
		protected UKSC_DA_Skill_RangeSectionAttack(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FD48 RID: 64840
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_Skill_RangeSectionAttack";

		// Token: 0x0400FD49 RID: 64841
		private static IntPtr _ClassPtr;

		// Token: 0x0400FD4A RID: 64842
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FD4B RID: 64843
		internal static int __PropertyOffset_SectionCount;

		// Token: 0x0400FD4C RID: 64844
		internal static int __PropertyOffset_SectionTime;
	}
}
