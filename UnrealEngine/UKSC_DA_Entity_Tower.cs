using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D94 RID: 7572
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_Entity_Tower")]
	[UnrealStructLayout(480, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 480)]
	public class UKSC_DA_Entity_Tower : UKSC_DA_Entity, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601CFA4 RID: 118692 RVA: 0x002AD4EA File Offset: 0x002AB6EA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_Entity_Tower._ClassPtr;
		}

		// Token: 0x0601CFA5 RID: 118693 RVA: 0x002AD4F8 File Offset: 0x002AB6F8
		public UKSC_DA_Entity_Tower() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Entity_Tower.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601CFA6 RID: 118694 RVA: 0x002AD520 File Offset: 0x002AB720
		public UKSC_DA_Entity_Tower(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Entity_Tower.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170074E5 RID: 29925
		// (get) Token: 0x0601CFA7 RID: 118695 RVA: 0x002AD554 File Offset: 0x002AB754
		// (set) Token: 0x0601CFA8 RID: 118696 RVA: 0x002AD58D File Offset: 0x002AB78D
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

		// Token: 0x0601CFA9 RID: 118697 RVA: 0x002AD59B File Offset: 0x002AB79B
		static UKSC_DA_Entity_Tower()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_Entity_Tower");
		}

		// Token: 0x0601CFAA RID: 118698 RVA: 0x002AD5A9 File Offset: 0x002AB7A9
		protected UKSC_DA_Entity_Tower(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FBA5 RID: 64421
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_Entity_Tower";

		// Token: 0x0400FBA6 RID: 64422
		private static IntPtr _ClassPtr;

		// Token: 0x0400FBA7 RID: 64423
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FBA8 RID: 64424
		internal static int __PropertyOffset_SkillStateMap;

		// Token: 0x0400FBA9 RID: 64425
		[Nullable(2)]
		private TMap<EKSC_Skill_State, FName> _SkillStateMap;
	}
}
