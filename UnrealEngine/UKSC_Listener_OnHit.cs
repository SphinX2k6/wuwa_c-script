using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001DF8 RID: 7672
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Listener_OnHit")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 128)]
	public class UKSC_Listener_OnHit : UKSC_EventListener, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D500 RID: 120064 RVA: 0x002B4734 File Offset: 0x002B2934
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Listener_OnHit._ClassPtr;
		}

		// Token: 0x0601D501 RID: 120065 RVA: 0x002B4740 File Offset: 0x002B2940
		public UKSC_Listener_OnHit() : this(BuiltinUtils.AllocNativeUObject(UKSC_Listener_OnHit.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D502 RID: 120066 RVA: 0x002B4768 File Offset: 0x002B2968
		public UKSC_Listener_OnHit(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_Listener_OnHit.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700765A RID: 30298
		// (get) Token: 0x0601D503 RID: 120067 RVA: 0x002B479B File Offset: 0x002B299B
		// (set) Token: 0x0601D504 RID: 120068 RVA: 0x002B47AB File Offset: 0x002B29AB
		public unsafe bool bHitBefore
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_Listener_OnHit.__PropertyOffset_bHitBefore) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_Listener_OnHit.__PropertyOffset_bHitBefore) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700765B RID: 30299
		// (get) Token: 0x0601D505 RID: 120069 RVA: 0x002B47BC File Offset: 0x002B29BC
		// (set) Token: 0x0601D506 RID: 120070 RVA: 0x002B47F5 File Offset: 0x002B29F5
		public FKSC_DamageTypeFilter DamageTypeFilter
		{
			get
			{
				base.FastCheckIsValid();
				FKSC_DamageTypeFilter result;
				if ((result = this._DamageTypeFilter) == null)
				{
					result = (this._DamageTypeFilter = new FKSC_DamageTypeFilter(base.NativePtr + (IntPtr)UKSC_Listener_OnHit.__PropertyOffset_DamageTypeFilter, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKSC_DamageTypeFilter.StaticStruct(), base.NativePtr + (IntPtr)UKSC_Listener_OnHit.__PropertyOffset_DamageTypeFilter, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700765C RID: 30300
		// (get) Token: 0x0601D507 RID: 120071 RVA: 0x002B4816 File Offset: 0x002B2A16
		// (set) Token: 0x0601D508 RID: 120072 RVA: 0x002B4826 File Offset: 0x002B2A26
		public unsafe EKSC_Event_HitTarget CheckTarget
		{
			get
			{
				return (EKSC_Event_HitTarget)(*(base.NativePtr + (IntPtr)UKSC_Listener_OnHit.__PropertyOffset_CheckTarget));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_Listener_OnHit.__PropertyOffset_CheckTarget) = (byte)value;
			}
		}

		// Token: 0x1700765D RID: 30301
		// (get) Token: 0x0601D509 RID: 120073 RVA: 0x002B4837 File Offset: 0x002B2A37
		// (set) Token: 0x0601D50A RID: 120074 RVA: 0x002B4847 File Offset: 0x002B2A47
		public unsafe bool bListenZeroDamage
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_Listener_OnHit.__PropertyOffset_bListenZeroDamage) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_Listener_OnHit.__PropertyOffset_bListenZeroDamage) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601D50B RID: 120075 RVA: 0x002B4858 File Offset: 0x002B2A58
		[NullableContext(2)]
		public void OnHitCallback(UKSC_SkillComp FromComp, UKSC_SkillComp ToComp, in FKSCDamage Damage)
		{
			UKSC_Listener_OnHit.__OnHitCallback_Internal(base.NativePtr, (FromComp != null) ? FromComp.NativePtr : IntPtr.Zero, (ToComp != null) ? ToComp.NativePtr : IntPtr.Zero, (Damage ?? new FKSCDamage()).NativePtr);
		}

		// Token: 0x0601D50C RID: 120076
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnHitCallback_Internal(IntPtr @this, IntPtr FromComp, IntPtr ToComp, IntPtr Damage);

		// Token: 0x0601D50D RID: 120077 RVA: 0x002B4895 File Offset: 0x002B2A95
		static UKSC_Listener_OnHit()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Listener_OnHit");
		}

		// Token: 0x0601D50E RID: 120078 RVA: 0x002B48A3 File Offset: 0x002B2AA3
		protected UKSC_Listener_OnHit(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FE74 RID: 65140
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Listener_OnHit";

		// Token: 0x0400FE75 RID: 65141
		private static IntPtr _ClassPtr;

		// Token: 0x0400FE76 RID: 65142
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FE77 RID: 65143
		internal static int __PropertyOffset_bHitBefore;

		// Token: 0x0400FE78 RID: 65144
		internal static int __PropertyOffset_DamageTypeFilter;

		// Token: 0x0400FE79 RID: 65145
		[Nullable(2)]
		private FKSC_DamageTypeFilter _DamageTypeFilter;

		// Token: 0x0400FE7A RID: 65146
		internal static int __PropertyOffset_CheckTarget;

		// Token: 0x0400FE7B RID: 65147
		internal static int __PropertyOffset_bListenZeroDamage;
	}
}
