using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020012F1 RID: 4849
	[UnrealObjectPath("/Script/GameplayAbilities.AbilitySystemTestAttributeSet")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 128)]
	public class UAbilitySystemTestAttributeSet : UAttributeSet, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06011DC2 RID: 73154 RVA: 0x001A3362 File Offset: 0x001A1562
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAbilitySystemTestAttributeSet._ClassPtr;
		}

		// Token: 0x06011DC3 RID: 73155 RVA: 0x001A3370 File Offset: 0x001A1570
		public UAbilitySystemTestAttributeSet() : this(BuiltinUtils.AllocNativeUObject(UAbilitySystemTestAttributeSet.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06011DC4 RID: 73156 RVA: 0x001A3398 File Offset: 0x001A1598
		[NullableContext(1)]
		public UAbilitySystemTestAttributeSet(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAbilitySystemTestAttributeSet.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170045BB RID: 17851
		// (get) Token: 0x06011DC5 RID: 73157 RVA: 0x001A33CB File Offset: 0x001A15CB
		// (set) Token: 0x06011DC6 RID: 73158 RVA: 0x001A33DB File Offset: 0x001A15DB
		public unsafe float MaxHealth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbilitySystemTestAttributeSet.__PropertyOffset_MaxHealth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbilitySystemTestAttributeSet.__PropertyOffset_MaxHealth) = value;
			}
		}

		// Token: 0x170045BC RID: 17852
		// (get) Token: 0x06011DC7 RID: 73159 RVA: 0x001A33EC File Offset: 0x001A15EC
		// (set) Token: 0x06011DC8 RID: 73160 RVA: 0x001A33FC File Offset: 0x001A15FC
		public unsafe float Health
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbilitySystemTestAttributeSet.__PropertyOffset_Health);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbilitySystemTestAttributeSet.__PropertyOffset_Health) = value;
			}
		}

		// Token: 0x170045BD RID: 17853
		// (get) Token: 0x06011DC9 RID: 73161 RVA: 0x001A340D File Offset: 0x001A160D
		// (set) Token: 0x06011DCA RID: 73162 RVA: 0x001A341D File Offset: 0x001A161D
		public unsafe float Mana
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbilitySystemTestAttributeSet.__PropertyOffset_Mana);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbilitySystemTestAttributeSet.__PropertyOffset_Mana) = value;
			}
		}

		// Token: 0x170045BE RID: 17854
		// (get) Token: 0x06011DCB RID: 73163 RVA: 0x001A342E File Offset: 0x001A162E
		// (set) Token: 0x06011DCC RID: 73164 RVA: 0x001A343E File Offset: 0x001A163E
		public unsafe float MaxMana
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbilitySystemTestAttributeSet.__PropertyOffset_MaxMana);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbilitySystemTestAttributeSet.__PropertyOffset_MaxMana) = value;
			}
		}

		// Token: 0x170045BF RID: 17855
		// (get) Token: 0x06011DCD RID: 73165 RVA: 0x001A344F File Offset: 0x001A164F
		// (set) Token: 0x06011DCE RID: 73166 RVA: 0x001A345F File Offset: 0x001A165F
		public unsafe float Damage
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbilitySystemTestAttributeSet.__PropertyOffset_Damage);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbilitySystemTestAttributeSet.__PropertyOffset_Damage) = value;
			}
		}

		// Token: 0x170045C0 RID: 17856
		// (get) Token: 0x06011DCF RID: 73167 RVA: 0x001A3470 File Offset: 0x001A1670
		// (set) Token: 0x06011DD0 RID: 73168 RVA: 0x001A3480 File Offset: 0x001A1680
		public unsafe float SpellDamage
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbilitySystemTestAttributeSet.__PropertyOffset_SpellDamage);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbilitySystemTestAttributeSet.__PropertyOffset_SpellDamage) = value;
			}
		}

		// Token: 0x170045C1 RID: 17857
		// (get) Token: 0x06011DD1 RID: 73169 RVA: 0x001A3491 File Offset: 0x001A1691
		// (set) Token: 0x06011DD2 RID: 73170 RVA: 0x001A34A1 File Offset: 0x001A16A1
		public unsafe float PhysicalDamage
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbilitySystemTestAttributeSet.__PropertyOffset_PhysicalDamage);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbilitySystemTestAttributeSet.__PropertyOffset_PhysicalDamage) = value;
			}
		}

		// Token: 0x170045C2 RID: 17858
		// (get) Token: 0x06011DD3 RID: 73171 RVA: 0x001A34B2 File Offset: 0x001A16B2
		// (set) Token: 0x06011DD4 RID: 73172 RVA: 0x001A34C2 File Offset: 0x001A16C2
		public unsafe float CritChance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbilitySystemTestAttributeSet.__PropertyOffset_CritChance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbilitySystemTestAttributeSet.__PropertyOffset_CritChance) = value;
			}
		}

		// Token: 0x170045C3 RID: 17859
		// (get) Token: 0x06011DD5 RID: 73173 RVA: 0x001A34D3 File Offset: 0x001A16D3
		// (set) Token: 0x06011DD6 RID: 73174 RVA: 0x001A34E3 File Offset: 0x001A16E3
		public unsafe float CritMultiplier
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbilitySystemTestAttributeSet.__PropertyOffset_CritMultiplier);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbilitySystemTestAttributeSet.__PropertyOffset_CritMultiplier) = value;
			}
		}

		// Token: 0x170045C4 RID: 17860
		// (get) Token: 0x06011DD7 RID: 73175 RVA: 0x001A34F4 File Offset: 0x001A16F4
		// (set) Token: 0x06011DD8 RID: 73176 RVA: 0x001A3504 File Offset: 0x001A1704
		public unsafe float ArmorDamageReduction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbilitySystemTestAttributeSet.__PropertyOffset_ArmorDamageReduction);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbilitySystemTestAttributeSet.__PropertyOffset_ArmorDamageReduction) = value;
			}
		}

		// Token: 0x170045C5 RID: 17861
		// (get) Token: 0x06011DD9 RID: 73177 RVA: 0x001A3515 File Offset: 0x001A1715
		// (set) Token: 0x06011DDA RID: 73178 RVA: 0x001A3525 File Offset: 0x001A1725
		public unsafe float DodgeChance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbilitySystemTestAttributeSet.__PropertyOffset_DodgeChance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbilitySystemTestAttributeSet.__PropertyOffset_DodgeChance) = value;
			}
		}

		// Token: 0x170045C6 RID: 17862
		// (get) Token: 0x06011DDB RID: 73179 RVA: 0x001A3536 File Offset: 0x001A1736
		// (set) Token: 0x06011DDC RID: 73180 RVA: 0x001A3546 File Offset: 0x001A1746
		public unsafe float LifeSteal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbilitySystemTestAttributeSet.__PropertyOffset_LifeSteal);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbilitySystemTestAttributeSet.__PropertyOffset_LifeSteal) = value;
			}
		}

		// Token: 0x170045C7 RID: 17863
		// (get) Token: 0x06011DDD RID: 73181 RVA: 0x001A3557 File Offset: 0x001A1757
		// (set) Token: 0x06011DDE RID: 73182 RVA: 0x001A3567 File Offset: 0x001A1767
		public unsafe float Strength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbilitySystemTestAttributeSet.__PropertyOffset_Strength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbilitySystemTestAttributeSet.__PropertyOffset_Strength) = value;
			}
		}

		// Token: 0x170045C8 RID: 17864
		// (get) Token: 0x06011DDF RID: 73183 RVA: 0x001A3578 File Offset: 0x001A1778
		// (set) Token: 0x06011DE0 RID: 73184 RVA: 0x001A3588 File Offset: 0x001A1788
		public unsafe float StackingAttribute1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbilitySystemTestAttributeSet.__PropertyOffset_StackingAttribute1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbilitySystemTestAttributeSet.__PropertyOffset_StackingAttribute1) = value;
			}
		}

		// Token: 0x170045C9 RID: 17865
		// (get) Token: 0x06011DE1 RID: 73185 RVA: 0x001A3599 File Offset: 0x001A1799
		// (set) Token: 0x06011DE2 RID: 73186 RVA: 0x001A35A9 File Offset: 0x001A17A9
		public unsafe float StackingAttribute2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbilitySystemTestAttributeSet.__PropertyOffset_StackingAttribute2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbilitySystemTestAttributeSet.__PropertyOffset_StackingAttribute2) = value;
			}
		}

		// Token: 0x170045CA RID: 17866
		// (get) Token: 0x06011DE3 RID: 73187 RVA: 0x001A35BA File Offset: 0x001A17BA
		// (set) Token: 0x06011DE4 RID: 73188 RVA: 0x001A35CA File Offset: 0x001A17CA
		public unsafe float NoStackAttribute
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbilitySystemTestAttributeSet.__PropertyOffset_NoStackAttribute);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbilitySystemTestAttributeSet.__PropertyOffset_NoStackAttribute) = value;
			}
		}

		// Token: 0x06011DE5 RID: 73189 RVA: 0x001A35DB File Offset: 0x001A17DB
		static UAbilitySystemTestAttributeSet()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GameplayAbilities.AbilitySystemTestAttributeSet");
		}

		// Token: 0x06011DE6 RID: 73190 RVA: 0x001A35E9 File Offset: 0x001A17E9
		protected UAbilitySystemTestAttributeSet(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040098CD RID: 39117
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/GameplayAbilities.AbilitySystemTestAttributeSet";

		// Token: 0x040098CE RID: 39118
		private static IntPtr _ClassPtr;

		// Token: 0x040098CF RID: 39119
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040098D0 RID: 39120
		internal static int __PropertyOffset_MaxHealth;

		// Token: 0x040098D1 RID: 39121
		internal static int __PropertyOffset_Health;

		// Token: 0x040098D2 RID: 39122
		internal static int __PropertyOffset_Mana;

		// Token: 0x040098D3 RID: 39123
		internal static int __PropertyOffset_MaxMana;

		// Token: 0x040098D4 RID: 39124
		internal static int __PropertyOffset_Damage;

		// Token: 0x040098D5 RID: 39125
		internal static int __PropertyOffset_SpellDamage;

		// Token: 0x040098D6 RID: 39126
		internal static int __PropertyOffset_PhysicalDamage;

		// Token: 0x040098D7 RID: 39127
		internal static int __PropertyOffset_CritChance;

		// Token: 0x040098D8 RID: 39128
		internal static int __PropertyOffset_CritMultiplier;

		// Token: 0x040098D9 RID: 39129
		internal static int __PropertyOffset_ArmorDamageReduction;

		// Token: 0x040098DA RID: 39130
		internal static int __PropertyOffset_DodgeChance;

		// Token: 0x040098DB RID: 39131
		internal static int __PropertyOffset_LifeSteal;

		// Token: 0x040098DC RID: 39132
		internal static int __PropertyOffset_Strength;

		// Token: 0x040098DD RID: 39133
		internal static int __PropertyOffset_StackingAttribute1;

		// Token: 0x040098DE RID: 39134
		internal static int __PropertyOffset_StackingAttribute2;

		// Token: 0x040098DF RID: 39135
		internal static int __PropertyOffset_NoStackAttribute;
	}
}
