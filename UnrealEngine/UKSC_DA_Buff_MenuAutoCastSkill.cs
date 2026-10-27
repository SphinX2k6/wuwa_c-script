using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D68 RID: 7528
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_Buff_MenuAutoCastSkill")]
	[UnrealStructLayout(432, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 432)]
	public class UKSC_DA_Buff_MenuAutoCastSkill : UKSC_DA_Buff, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601CD7F RID: 118143 RVA: 0x002AA285 File Offset: 0x002A8485
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_Buff_MenuAutoCastSkill._ClassPtr;
		}

		// Token: 0x0601CD80 RID: 118144 RVA: 0x002AA294 File Offset: 0x002A8494
		public UKSC_DA_Buff_MenuAutoCastSkill() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Buff_MenuAutoCastSkill.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601CD81 RID: 118145 RVA: 0x002AA2BC File Offset: 0x002A84BC
		[NullableContext(1)]
		public UKSC_DA_Buff_MenuAutoCastSkill(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Buff_MenuAutoCastSkill.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700743F RID: 29759
		// (get) Token: 0x0601CD82 RID: 118146 RVA: 0x002AA2EF File Offset: 0x002A84EF
		// (set) Token: 0x0601CD83 RID: 118147 RVA: 0x002AA2FF File Offset: 0x002A84FF
		public unsafe int SkillIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_MenuAutoCastSkill.__PropertyOffset_SkillIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_MenuAutoCastSkill.__PropertyOffset_SkillIndex) = value;
			}
		}

		// Token: 0x17007440 RID: 29760
		// (get) Token: 0x0601CD84 RID: 118148 RVA: 0x002AA310 File Offset: 0x002A8510
		// (set) Token: 0x0601CD85 RID: 118149 RVA: 0x002AA320 File Offset: 0x002A8520
		public unsafe bool bEnableAutoCast
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_MenuAutoCastSkill.__PropertyOffset_bEnableAutoCast) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_MenuAutoCastSkill.__PropertyOffset_bEnableAutoCast) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007441 RID: 29761
		// (get) Token: 0x0601CD86 RID: 118150 RVA: 0x002AA331 File Offset: 0x002A8531
		// (set) Token: 0x0601CD87 RID: 118151 RVA: 0x002AA341 File Offset: 0x002A8541
		public unsafe bool bRestoreOnEnd
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_MenuAutoCastSkill.__PropertyOffset_bRestoreOnEnd) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_MenuAutoCastSkill.__PropertyOffset_bRestoreOnEnd) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601CD88 RID: 118152 RVA: 0x002AA352 File Offset: 0x002A8552
		static UKSC_DA_Buff_MenuAutoCastSkill()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_Buff_MenuAutoCastSkill");
		}

		// Token: 0x0601CD89 RID: 118153 RVA: 0x002AA360 File Offset: 0x002A8560
		protected UKSC_DA_Buff_MenuAutoCastSkill(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FA57 RID: 64087
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_Buff_MenuAutoCastSkill";

		// Token: 0x0400FA58 RID: 64088
		private static IntPtr _ClassPtr;

		// Token: 0x0400FA59 RID: 64089
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FA5A RID: 64090
		internal static int __PropertyOffset_SkillIndex;

		// Token: 0x0400FA5B RID: 64091
		internal static int __PropertyOffset_bEnableAutoCast;

		// Token: 0x0400FA5C RID: 64092
		internal static int __PropertyOffset_bRestoreOnEnd;
	}
}
