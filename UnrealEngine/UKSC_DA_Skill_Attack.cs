using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001DBC RID: 7612
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_Skill_Attack")]
	[UnrealStructLayout(496, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 496)]
	public class UKSC_DA_Skill_Attack : UKSC_DA_Skill, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D1CB RID: 119243 RVA: 0x002B036E File Offset: 0x002AE56E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_Skill_Attack._ClassPtr;
		}

		// Token: 0x0601D1CC RID: 119244 RVA: 0x002B037C File Offset: 0x002AE57C
		public UKSC_DA_Skill_Attack() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Skill_Attack.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D1CD RID: 119245 RVA: 0x002B03A4 File Offset: 0x002AE5A4
		public UKSC_DA_Skill_Attack(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Skill_Attack.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007594 RID: 30100
		// (get) Token: 0x0601D1CE RID: 119246 RVA: 0x002B03D7 File Offset: 0x002AE5D7
		// (set) Token: 0x0601D1CF RID: 119247 RVA: 0x002B03E7 File Offset: 0x002AE5E7
		public unsafe bool OverrideCheckRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Skill_Attack.__PropertyOffset_OverrideCheckRange) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Skill_Attack.__PropertyOffset_OverrideCheckRange) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007595 RID: 30101
		// (get) Token: 0x0601D1D0 RID: 119248 RVA: 0x002B03F8 File Offset: 0x002AE5F8
		// (set) Token: 0x0601D1D1 RID: 119249 RVA: 0x002B0431 File Offset: 0x002AE631
		public FKSC_Range CheckRange
		{
			get
			{
				base.FastCheckIsValid();
				FKSC_Range result;
				if ((result = this._CheckRange) == null)
				{
					result = (this._CheckRange = new FKSC_Range(base.NativePtr + (IntPtr)UKSC_DA_Skill_Attack.__PropertyOffset_CheckRange, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKSC_Range.StaticStruct(), base.NativePtr + (IntPtr)UKSC_DA_Skill_Attack.__PropertyOffset_CheckRange, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0601D1D2 RID: 119250 RVA: 0x002B0452 File Offset: 0x002AE652
		static UKSC_DA_Skill_Attack()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_Skill_Attack");
		}

		// Token: 0x0601D1D3 RID: 119251 RVA: 0x002B0460 File Offset: 0x002AE660
		protected UKSC_DA_Skill_Attack(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FCDD RID: 64733
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_Skill_Attack";

		// Token: 0x0400FCDE RID: 64734
		private static IntPtr _ClassPtr;

		// Token: 0x0400FCDF RID: 64735
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FCE0 RID: 64736
		internal static int __PropertyOffset_OverrideCheckRange;

		// Token: 0x0400FCE1 RID: 64737
		internal static int __PropertyOffset_CheckRange;

		// Token: 0x0400FCE2 RID: 64738
		[Nullable(2)]
		private FKSC_Range _CheckRange;
	}
}
