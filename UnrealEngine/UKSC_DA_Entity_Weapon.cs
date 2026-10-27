using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D95 RID: 7573
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_Entity_Weapon")]
	[UnrealStructLayout(400, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 400)]
	public class UKSC_DA_Entity_Weapon : UKSC_DA_Entity, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601CFAB RID: 118699 RVA: 0x002AD5B2 File Offset: 0x002AB7B2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_Entity_Weapon._ClassPtr;
		}

		// Token: 0x0601CFAC RID: 118700 RVA: 0x002AD5C0 File Offset: 0x002AB7C0
		public UKSC_DA_Entity_Weapon() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Entity_Weapon.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601CFAD RID: 118701 RVA: 0x002AD5E8 File Offset: 0x002AB7E8
		[NullableContext(1)]
		public UKSC_DA_Entity_Weapon(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Entity_Weapon.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170074E6 RID: 29926
		// (get) Token: 0x0601CFAE RID: 118702 RVA: 0x002AD61B File Offset: 0x002AB81B
		// (set) Token: 0x0601CFAF RID: 118703 RVA: 0x002AD62B File Offset: 0x002AB82B
		public unsafe bool bRedirectTimeScaleToSummoner
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Entity_Weapon.__PropertyOffset_bRedirectTimeScaleToSummoner) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Entity_Weapon.__PropertyOffset_bRedirectTimeScaleToSummoner) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601CFB0 RID: 118704 RVA: 0x002AD63C File Offset: 0x002AB83C
		static UKSC_DA_Entity_Weapon()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_Entity_Weapon");
		}

		// Token: 0x0601CFB1 RID: 118705 RVA: 0x002AD64A File Offset: 0x002AB84A
		protected UKSC_DA_Entity_Weapon(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FBAA RID: 64426
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_Entity_Weapon";

		// Token: 0x0400FBAB RID: 64427
		private static IntPtr _ClassPtr;

		// Token: 0x0400FBAC RID: 64428
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FBAD RID: 64429
		internal static int __PropertyOffset_bRedirectTimeScaleToSummoner;
	}
}
