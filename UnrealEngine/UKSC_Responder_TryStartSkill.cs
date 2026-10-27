using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001E27 RID: 7719
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Responder_TryStartSkill")]
	[UnrealStructLayout(120, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 120)]
	public class UKSC_Responder_TryStartSkill : UKSC_EventResponder, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D6BE RID: 120510 RVA: 0x002B759B File Offset: 0x002B579B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Responder_TryStartSkill._ClassPtr;
		}

		// Token: 0x0601D6BF RID: 120511 RVA: 0x002B75A8 File Offset: 0x002B57A8
		public UKSC_Responder_TryStartSkill() : this(BuiltinUtils.AllocNativeUObject(UKSC_Responder_TryStartSkill.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D6C0 RID: 120512 RVA: 0x002B75D0 File Offset: 0x002B57D0
		public UKSC_Responder_TryStartSkill(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_Responder_TryStartSkill.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700769A RID: 30362
		// (get) Token: 0x0601D6C1 RID: 120513 RVA: 0x002B7604 File Offset: 0x002B5804
		// (set) Token: 0x0601D6C2 RID: 120514 RVA: 0x002B763D File Offset: 0x002B583D
		public TArray<int> SkillIndices
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._SkillIndices) == null)
				{
					result = (this._SkillIndices = new TArray<int>(base.NativePtr + (IntPtr)UKSC_Responder_TryStartSkill.__PropertyOffset_SkillIndices, this));
				}
				return result;
			}
			set
			{
				this.SkillIndices.CopyAssign(value);
			}
		}

		// Token: 0x0601D6C3 RID: 120515 RVA: 0x002B764B File Offset: 0x002B584B
		static UKSC_Responder_TryStartSkill()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Responder_TryStartSkill");
		}

		// Token: 0x0601D6C4 RID: 120516 RVA: 0x002B7659 File Offset: 0x002B5859
		protected UKSC_Responder_TryStartSkill(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FF44 RID: 65348
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Responder_TryStartSkill";

		// Token: 0x0400FF45 RID: 65349
		private static IntPtr _ClassPtr;

		// Token: 0x0400FF46 RID: 65350
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FF47 RID: 65351
		internal static int __PropertyOffset_SkillIndices;

		// Token: 0x0400FF48 RID: 65352
		[Nullable(2)]
		private TArray<int> _SkillIndices;
	}
}
