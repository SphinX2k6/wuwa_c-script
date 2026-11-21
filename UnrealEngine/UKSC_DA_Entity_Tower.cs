using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200056D RID: 1389
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_Entity_Tower")]
	[UnrealStructLayout(480, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 480)]
	public class UKSC_DA_Entity_Tower : UKSC_DA_Entity, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06007E5B RID: 32347 RVA: 0x000BB433 File Offset: 0x000B9633
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_Entity_Tower._ClassPtr;
		}

		// Token: 0x06007E5C RID: 32348 RVA: 0x000BB440 File Offset: 0x000B9640
		public UKSC_DA_Entity_Tower() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Entity_Tower.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06007E5D RID: 32349 RVA: 0x000BB468 File Offset: 0x000B9668
		public UKSC_DA_Entity_Tower(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Entity_Tower.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700186E RID: 6254
		// (get) Token: 0x06007E5E RID: 32350 RVA: 0x000BB49C File Offset: 0x000B969C
		// (set) Token: 0x06007E5F RID: 32351 RVA: 0x000BB4D5 File Offset: 0x000B96D5
		public TMap<EKSC_Skill_State, FName> SkillStateMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<EKSC_Skill_State, FName> result;
				if ((result = this._SkillStateMap) == null)
				{
					result = (this._SkillStateMap = new TMap<EKSC_Skill_State, FName>(base.NativePtr + (IntPtr)UKSC_DA_Entity_Tower.__PropertyOffset_SkillStateMap, this));
				}
				return result;
			}
			set
			{
				this.SkillStateMap.CopyAssign(value);
			}
		}

		// Token: 0x06007E60 RID: 32352 RVA: 0x000BB4E3 File Offset: 0x000B96E3
		static UKSC_DA_Entity_Tower()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_Entity_Tower");
		}

		// Token: 0x06007E61 RID: 32353 RVA: 0x000BB4F1 File Offset: 0x000B96F1
		protected UKSC_DA_Entity_Tower(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003723 RID: 14115
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_Entity_Tower";

		// Token: 0x04003724 RID: 14116
		private static IntPtr _ClassPtr;

		// Token: 0x04003725 RID: 14117
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003726 RID: 14118
		internal static int __PropertyOffset_SkillStateMap;

		// Token: 0x04003727 RID: 14119
		[Nullable(2)]
		private TMap<EKSC_Skill_State, FName> _SkillStateMap;
	}
}
