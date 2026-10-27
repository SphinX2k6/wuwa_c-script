using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D7B RID: 7547
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_Buff_RecordDamage")]
	[UnrealStructLayout(480, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 480)]
	public class UKSC_DA_Buff_RecordDamage : UKSC_DA_Buff, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601CE83 RID: 118403 RVA: 0x002ABA5C File Offset: 0x002A9C5C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_Buff_RecordDamage._ClassPtr;
		}

		// Token: 0x0601CE84 RID: 118404 RVA: 0x002ABA68 File Offset: 0x002A9C68
		public UKSC_DA_Buff_RecordDamage() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Buff_RecordDamage.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601CE85 RID: 118405 RVA: 0x002ABA90 File Offset: 0x002A9C90
		public UKSC_DA_Buff_RecordDamage(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Buff_RecordDamage.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007492 RID: 29842
		// (get) Token: 0x0601CE86 RID: 118406 RVA: 0x002ABAC4 File Offset: 0x002A9CC4
		// (set) Token: 0x0601CE87 RID: 118407 RVA: 0x002ABAFD File Offset: 0x002A9CFD
		public FKSC_DamageTypeFilter DamageTypeFilter
		{
			get
			{
				base.FastCheckIsValid();
				FKSC_DamageTypeFilter result;
				if ((result = this._DamageTypeFilter) == null)
				{
					result = (this._DamageTypeFilter = new FKSC_DamageTypeFilter(base.NativePtr + (IntPtr)UKSC_DA_Buff_RecordDamage.__PropertyOffset_DamageTypeFilter, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKSC_DamageTypeFilter.StaticStruct(), base.NativePtr + (IntPtr)UKSC_DA_Buff_RecordDamage.__PropertyOffset_DamageTypeFilter, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007493 RID: 29843
		// (get) Token: 0x0601CE88 RID: 118408 RVA: 0x002ABB1E File Offset: 0x002A9D1E
		// (set) Token: 0x0601CE89 RID: 118409 RVA: 0x002ABB2E File Offset: 0x002A9D2E
		public unsafe EKSC_AttrType AttrId
		{
			get
			{
				return (EKSC_AttrType)(*(base.NativePtr + (IntPtr)UKSC_DA_Buff_RecordDamage.__PropertyOffset_AttrId));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_RecordDamage.__PropertyOffset_AttrId) = (byte)value;
			}
		}

		// Token: 0x0601CE8A RID: 118410 RVA: 0x002ABB3F File Offset: 0x002A9D3F
		static UKSC_DA_Buff_RecordDamage()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_Buff_RecordDamage");
		}

		// Token: 0x0601CE8B RID: 118411 RVA: 0x002ABB4D File Offset: 0x002A9D4D
		protected UKSC_DA_Buff_RecordDamage(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FAF7 RID: 64247
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_Buff_RecordDamage";

		// Token: 0x0400FAF8 RID: 64248
		private static IntPtr _ClassPtr;

		// Token: 0x0400FAF9 RID: 64249
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FAFA RID: 64250
		internal static int __PropertyOffset_DamageTypeFilter;

		// Token: 0x0400FAFB RID: 64251
		[Nullable(2)]
		private FKSC_DamageTypeFilter _DamageTypeFilter;

		// Token: 0x0400FAFC RID: 64252
		internal static int __PropertyOffset_AttrId;
	}
}
