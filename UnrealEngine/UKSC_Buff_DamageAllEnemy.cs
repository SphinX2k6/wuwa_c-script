using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D12 RID: 7442
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Buff_DamageAllEnemy")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 104)]
	public class UKSC_Buff_DamageAllEnemy : UKSC_Buff, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601C985 RID: 117125 RVA: 0x002A458B File Offset: 0x002A278B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Buff_DamageAllEnemy._ClassPtr;
		}

		// Token: 0x0601C986 RID: 117126 RVA: 0x002A4598 File Offset: 0x002A2798
		public UKSC_Buff_DamageAllEnemy() : this(BuiltinUtils.AllocNativeUObject(UKSC_Buff_DamageAllEnemy.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601C987 RID: 117127 RVA: 0x002A45C0 File Offset: 0x002A27C0
		[NullableContext(1)]
		public UKSC_Buff_DamageAllEnemy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_Buff_DamageAllEnemy.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007322 RID: 29474
		// (get) Token: 0x0601C988 RID: 117128 RVA: 0x002A45F3 File Offset: 0x002A27F3
		// (set) Token: 0x0601C989 RID: 117129 RVA: 0x002A4607 File Offset: 0x002A2807
		[Nullable(2)]
		public unsafe UKSC_DA_Buff_DamageAllEnemy DaBuffDamageAllEnemy_
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_Buff_DamageAllEnemy>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Buff_DamageAllEnemy.__PropertyOffset_DaBuffDamageAllEnemy_);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Buff_DamageAllEnemy.__PropertyOffset_DaBuffDamageAllEnemy_, value);
			}
		}

		// Token: 0x0601C98A RID: 117130 RVA: 0x002A461C File Offset: 0x002A281C
		static UKSC_Buff_DamageAllEnemy()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Buff_DamageAllEnemy");
		}

		// Token: 0x0601C98B RID: 117131 RVA: 0x002A462A File Offset: 0x002A282A
		protected UKSC_Buff_DamageAllEnemy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F802 RID: 63490
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Buff_DamageAllEnemy";

		// Token: 0x0400F803 RID: 63491
		private static IntPtr _ClassPtr;

		// Token: 0x0400F804 RID: 63492
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F805 RID: 63493
		internal static int __PropertyOffset_DaBuffDamageAllEnemy_;
	}
}
