using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D63 RID: 7523
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_Buff_KnockDamage")]
	[UnrealStructLayout(432, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 432)]
	public class UKSC_DA_Buff_KnockDamage : UKSC_DA_Buff, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601CD04 RID: 118020 RVA: 0x002A9741 File Offset: 0x002A7941
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_Buff_KnockDamage._ClassPtr;
		}

		// Token: 0x0601CD05 RID: 118021 RVA: 0x002A9750 File Offset: 0x002A7950
		public UKSC_DA_Buff_KnockDamage() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Buff_KnockDamage.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601CD06 RID: 118022 RVA: 0x002A9778 File Offset: 0x002A7978
		[NullableContext(1)]
		public UKSC_DA_Buff_KnockDamage(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Buff_KnockDamage.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700740E RID: 29710
		// (get) Token: 0x0601CD07 RID: 118023 RVA: 0x002A97AB File Offset: 0x002A79AB
		// (set) Token: 0x0601CD08 RID: 118024 RVA: 0x002A97BB File Offset: 0x002A79BB
		public unsafe int DamageID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_KnockDamage.__PropertyOffset_DamageID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_KnockDamage.__PropertyOffset_DamageID) = value;
			}
		}

		// Token: 0x1700740F RID: 29711
		// (get) Token: 0x0601CD09 RID: 118025 RVA: 0x002A97CC File Offset: 0x002A79CC
		// (set) Token: 0x0601CD0A RID: 118026 RVA: 0x002A97DC File Offset: 0x002A79DC
		public unsafe EKSC_AttrType IntervalAttrType
		{
			get
			{
				return (EKSC_AttrType)(*(base.NativePtr + (IntPtr)UKSC_DA_Buff_KnockDamage.__PropertyOffset_IntervalAttrType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_KnockDamage.__PropertyOffset_IntervalAttrType) = (byte)value;
			}
		}

		// Token: 0x0601CD0B RID: 118027 RVA: 0x002A97ED File Offset: 0x002A79ED
		static UKSC_DA_Buff_KnockDamage()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_Buff_KnockDamage");
		}

		// Token: 0x0601CD0C RID: 118028 RVA: 0x002A97FB File Offset: 0x002A79FB
		protected UKSC_DA_Buff_KnockDamage(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FA0C RID: 64012
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_Buff_KnockDamage";

		// Token: 0x0400FA0D RID: 64013
		private static IntPtr _ClassPtr;

		// Token: 0x0400FA0E RID: 64014
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FA0F RID: 64015
		internal static int __PropertyOffset_DamageID;

		// Token: 0x0400FA10 RID: 64016
		internal static int __PropertyOffset_IntervalAttrType;
	}
}
