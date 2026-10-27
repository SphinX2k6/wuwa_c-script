using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D5C RID: 7516
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_Buff_DamageAllEnemy")]
	[UnrealStructLayout(464, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 464)]
	public class UKSC_DA_Buff_DamageAllEnemy : UKSC_DA_Buff, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601CCAF RID: 117935 RVA: 0x002A8E7E File Offset: 0x002A707E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_Buff_DamageAllEnemy._ClassPtr;
		}

		// Token: 0x0601CCB0 RID: 117936 RVA: 0x002A8E8C File Offset: 0x002A708C
		public UKSC_DA_Buff_DamageAllEnemy() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Buff_DamageAllEnemy.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601CCB1 RID: 117937 RVA: 0x002A8EB4 File Offset: 0x002A70B4
		public UKSC_DA_Buff_DamageAllEnemy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Buff_DamageAllEnemy.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170073F5 RID: 29685
		// (get) Token: 0x0601CCB2 RID: 117938 RVA: 0x002A8EE8 File Offset: 0x002A70E8
		// (set) Token: 0x0601CCB3 RID: 117939 RVA: 0x002A8F21 File Offset: 0x002A7121
		public FKSCDamage Damage
		{
			get
			{
				base.FastCheckIsValid();
				FKSCDamage result;
				if ((result = this._Damage) == null)
				{
					result = (this._Damage = new FKSCDamage(base.NativePtr + (IntPtr)UKSC_DA_Buff_DamageAllEnemy.__PropertyOffset_Damage, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKSCDamage.StaticStruct(), base.NativePtr + (IntPtr)UKSC_DA_Buff_DamageAllEnemy.__PropertyOffset_Damage, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0601CCB4 RID: 117940 RVA: 0x002A8F42 File Offset: 0x002A7142
		static UKSC_DA_Buff_DamageAllEnemy()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_Buff_DamageAllEnemy");
		}

		// Token: 0x0601CCB5 RID: 117941 RVA: 0x002A8F50 File Offset: 0x002A7150
		protected UKSC_DA_Buff_DamageAllEnemy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F9D4 RID: 63956
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_Buff_DamageAllEnemy";

		// Token: 0x0400F9D5 RID: 63957
		private static IntPtr _ClassPtr;

		// Token: 0x0400F9D6 RID: 63958
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F9D7 RID: 63959
		internal static int __PropertyOffset_Damage;

		// Token: 0x0400F9D8 RID: 63960
		[Nullable(2)]
		private FKSCDamage _Damage;
	}
}
