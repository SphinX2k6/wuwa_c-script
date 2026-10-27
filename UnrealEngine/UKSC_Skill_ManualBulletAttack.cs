using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001E4B RID: 7755
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Skill_ManualBulletAttack")]
	[UnrealStructLayout(256, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 256)]
	public class UKSC_Skill_ManualBulletAttack : UKSC_Skill, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D88B RID: 120971 RVA: 0x002B9C0F File Offset: 0x002B7E0F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Skill_ManualBulletAttack._ClassPtr;
		}

		// Token: 0x0601D88C RID: 120972 RVA: 0x002B9C1C File Offset: 0x002B7E1C
		public UKSC_Skill_ManualBulletAttack() : this(BuiltinUtils.AllocNativeUObject(UKSC_Skill_ManualBulletAttack.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D88D RID: 120973 RVA: 0x002B9C44 File Offset: 0x002B7E44
		[NullableContext(1)]
		public UKSC_Skill_ManualBulletAttack(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_Skill_ManualBulletAttack.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170076F9 RID: 30457
		// (get) Token: 0x0601D88E RID: 120974 RVA: 0x002B9C77 File Offset: 0x002B7E77
		// (set) Token: 0x0601D88F RID: 120975 RVA: 0x002B9C8B File Offset: 0x002B7E8B
		public unsafe UKSC_DA_Skill_ManualBulletAttack DaSkillManualBulletAttack_
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_Skill_ManualBulletAttack>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Skill_ManualBulletAttack.__PropertyOffset_DaSkillManualBulletAttack_);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Skill_ManualBulletAttack.__PropertyOffset_DaSkillManualBulletAttack_, value);
			}
		}

		// Token: 0x0601D890 RID: 120976 RVA: 0x002B9CA0 File Offset: 0x002B7EA0
		public void OnBulletHit(in FKSC_BulletTargetContext TargetContext)
		{
			UKSC_Skill_ManualBulletAttack.__OnBulletHit_Internal(base.NativePtr, (TargetContext ?? new FKSC_BulletTargetContext()).NativePtr);
		}

		// Token: 0x0601D891 RID: 120977
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnBulletHit_Internal(IntPtr @this, IntPtr TargetContext);

		// Token: 0x0601D892 RID: 120978 RVA: 0x002B9CBD File Offset: 0x002B7EBD
		static UKSC_Skill_ManualBulletAttack()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Skill_ManualBulletAttack");
		}

		// Token: 0x0601D893 RID: 120979 RVA: 0x002B9CCB File Offset: 0x002B7ECB
		protected UKSC_Skill_ManualBulletAttack(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401002B RID: 65579
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Skill_ManualBulletAttack";

		// Token: 0x0401002C RID: 65580
		private static IntPtr _ClassPtr;

		// Token: 0x0401002D RID: 65581
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401002E RID: 65582
		internal static int __PropertyOffset_DaSkillManualBulletAttack_;
	}
}
