using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D93 RID: 7571
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_Entity_Projectile")]
	[UnrealStructLayout(448, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 448)]
	public class UKSC_DA_Entity_Projectile : UKSC_DA_Entity, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601CF9B RID: 118683 RVA: 0x002AD3EF File Offset: 0x002AB5EF
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_Entity_Projectile._ClassPtr;
		}

		// Token: 0x0601CF9C RID: 118684 RVA: 0x002AD3FC File Offset: 0x002AB5FC
		public UKSC_DA_Entity_Projectile() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Entity_Projectile.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601CF9D RID: 118685 RVA: 0x002AD424 File Offset: 0x002AB624
		public UKSC_DA_Entity_Projectile(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Entity_Projectile.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170074E3 RID: 29923
		// (get) Token: 0x0601CF9E RID: 118686 RVA: 0x002AD458 File Offset: 0x002AB658
		// (set) Token: 0x0601CF9F RID: 118687 RVA: 0x002AD491 File Offset: 0x002AB691
		public FKSCDamage Damage
		{
			get
			{
				base.FastCheckIsValid();
				FKSCDamage result;
				if ((result = this._Damage) == null)
				{
					result = (this._Damage = new FKSCDamage(base.NativePtr + (IntPtr)UKSC_DA_Entity_Projectile.__PropertyOffset_Damage, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKSCDamage.StaticStruct(), base.NativePtr + (IntPtr)UKSC_DA_Entity_Projectile.__PropertyOffset_Damage, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170074E4 RID: 29924
		// (get) Token: 0x0601CFA0 RID: 118688 RVA: 0x002AD4B2 File Offset: 0x002AB6B2
		// (set) Token: 0x0601CFA1 RID: 118689 RVA: 0x002AD4C2 File Offset: 0x002AB6C2
		public unsafe int DamageID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Entity_Projectile.__PropertyOffset_DamageID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Entity_Projectile.__PropertyOffset_DamageID) = value;
			}
		}

		// Token: 0x0601CFA2 RID: 118690 RVA: 0x002AD4D3 File Offset: 0x002AB6D3
		static UKSC_DA_Entity_Projectile()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_Entity_Projectile");
		}

		// Token: 0x0601CFA3 RID: 118691 RVA: 0x002AD4E1 File Offset: 0x002AB6E1
		protected UKSC_DA_Entity_Projectile(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FB9F RID: 64415
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_Entity_Projectile";

		// Token: 0x0400FBA0 RID: 64416
		private static IntPtr _ClassPtr;

		// Token: 0x0400FBA1 RID: 64417
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FBA2 RID: 64418
		internal static int __PropertyOffset_Damage;

		// Token: 0x0400FBA3 RID: 64419
		[Nullable(2)]
		private FKSCDamage _Damage;

		// Token: 0x0400FBA4 RID: 64420
		internal static int __PropertyOffset_DamageID;
	}
}
