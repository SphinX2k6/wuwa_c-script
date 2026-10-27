using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001DC8 RID: 7624
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_Skill_RangeAttack")]
	[UnrealStructLayout(576, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 576)]
	public class UKSC_DA_Skill_RangeAttack : UKSC_DA_Skill, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D26B RID: 119403 RVA: 0x002B110F File Offset: 0x002AF30F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_Skill_RangeAttack._ClassPtr;
		}

		// Token: 0x0601D26C RID: 119404 RVA: 0x002B111C File Offset: 0x002AF31C
		public UKSC_DA_Skill_RangeAttack() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Skill_RangeAttack.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D26D RID: 119405 RVA: 0x002B1144 File Offset: 0x002AF344
		public UKSC_DA_Skill_RangeAttack(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Skill_RangeAttack.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170075C6 RID: 30150
		// (get) Token: 0x0601D26E RID: 119406 RVA: 0x002B1178 File Offset: 0x002AF378
		// (set) Token: 0x0601D26F RID: 119407 RVA: 0x002B11B1 File Offset: 0x002AF3B1
		public FKSC_Range CheckRange
		{
			get
			{
				base.FastCheckIsValid();
				FKSC_Range result;
				if ((result = this._CheckRange) == null)
				{
					result = (this._CheckRange = new FKSC_Range(base.NativePtr + (IntPtr)UKSC_DA_Skill_RangeAttack.__PropertyOffset_CheckRange, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKSC_Range.StaticStruct(), base.NativePtr + (IntPtr)UKSC_DA_Skill_RangeAttack.__PropertyOffset_CheckRange, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170075C7 RID: 30151
		// (get) Token: 0x0601D270 RID: 119408 RVA: 0x002B11D4 File Offset: 0x002AF3D4
		// (set) Token: 0x0601D271 RID: 119409 RVA: 0x002B120D File Offset: 0x002AF40D
		public FKSC_Range DamageRange
		{
			get
			{
				base.FastCheckIsValid();
				FKSC_Range result;
				if ((result = this._DamageRange) == null)
				{
					result = (this._DamageRange = new FKSC_Range(base.NativePtr + (IntPtr)UKSC_DA_Skill_RangeAttack.__PropertyOffset_DamageRange, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKSC_Range.StaticStruct(), base.NativePtr + (IntPtr)UKSC_DA_Skill_RangeAttack.__PropertyOffset_DamageRange, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170075C8 RID: 30152
		// (get) Token: 0x0601D272 RID: 119410 RVA: 0x002B122E File Offset: 0x002AF42E
		// (set) Token: 0x0601D273 RID: 119411 RVA: 0x002B123E File Offset: 0x002AF43E
		public unsafe bool ForceDoSkill
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Skill_RangeAttack.__PropertyOffset_ForceDoSkill) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Skill_RangeAttack.__PropertyOffset_ForceDoSkill) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601D274 RID: 119412 RVA: 0x002B124F File Offset: 0x002AF44F
		static UKSC_DA_Skill_RangeAttack()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_Skill_RangeAttack");
		}

		// Token: 0x0601D275 RID: 119413 RVA: 0x002B125D File Offset: 0x002AF45D
		protected UKSC_DA_Skill_RangeAttack(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FD37 RID: 64823
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_Skill_RangeAttack";

		// Token: 0x0400FD38 RID: 64824
		private static IntPtr _ClassPtr;

		// Token: 0x0400FD39 RID: 64825
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FD3A RID: 64826
		internal static int __PropertyOffset_CheckRange;

		// Token: 0x0400FD3B RID: 64827
		[Nullable(2)]
		private FKSC_Range _CheckRange;

		// Token: 0x0400FD3C RID: 64828
		internal static int __PropertyOffset_DamageRange;

		// Token: 0x0400FD3D RID: 64829
		[Nullable(2)]
		private FKSC_Range _DamageRange;

		// Token: 0x0400FD3E RID: 64830
		internal static int __PropertyOffset_ForceDoSkill;
	}
}
