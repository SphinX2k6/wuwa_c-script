using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001DF5 RID: 7669
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Listener_OnCrit")]
	[UnrealStructLayout(120, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 120)]
	public class UKSC_Listener_OnCrit : UKSC_EventListener, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D4E5 RID: 120037 RVA: 0x002B4484 File Offset: 0x002B2684
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Listener_OnCrit._ClassPtr;
		}

		// Token: 0x0601D4E6 RID: 120038 RVA: 0x002B4490 File Offset: 0x002B2690
		public UKSC_Listener_OnCrit() : this(BuiltinUtils.AllocNativeUObject(UKSC_Listener_OnCrit.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D4E7 RID: 120039 RVA: 0x002B44B8 File Offset: 0x002B26B8
		public UKSC_Listener_OnCrit(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_Listener_OnCrit.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007657 RID: 30295
		// (get) Token: 0x0601D4E8 RID: 120040 RVA: 0x002B44EC File Offset: 0x002B26EC
		// (set) Token: 0x0601D4E9 RID: 120041 RVA: 0x002B4525 File Offset: 0x002B2725
		public FKSC_DamageTypeFilter DamageTypeFilter
		{
			get
			{
				base.FastCheckIsValid();
				FKSC_DamageTypeFilter result;
				if ((result = this._DamageTypeFilter) == null)
				{
					result = (this._DamageTypeFilter = new FKSC_DamageTypeFilter(base.NativePtr + (IntPtr)UKSC_Listener_OnCrit.__PropertyOffset_DamageTypeFilter, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKSC_DamageTypeFilter.StaticStruct(), base.NativePtr + (IntPtr)UKSC_Listener_OnCrit.__PropertyOffset_DamageTypeFilter, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007658 RID: 30296
		// (get) Token: 0x0601D4EA RID: 120042 RVA: 0x002B4546 File Offset: 0x002B2746
		// (set) Token: 0x0601D4EB RID: 120043 RVA: 0x002B4556 File Offset: 0x002B2756
		public unsafe EKSC_Event_HitTarget CheckTarget
		{
			get
			{
				return (EKSC_Event_HitTarget)(*(base.NativePtr + (IntPtr)UKSC_Listener_OnCrit.__PropertyOffset_CheckTarget));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_Listener_OnCrit.__PropertyOffset_CheckTarget) = (byte)value;
			}
		}

		// Token: 0x0601D4EC RID: 120044 RVA: 0x002B4567 File Offset: 0x002B2767
		[NullableContext(2)]
		public void OnCritCallback(UKSC_SkillComp FromComp, UKSC_SkillComp ToComp, in FKSCDamage Damage)
		{
			UKSC_Listener_OnCrit.__OnCritCallback_Internal(base.NativePtr, (FromComp != null) ? FromComp.NativePtr : IntPtr.Zero, (ToComp != null) ? ToComp.NativePtr : IntPtr.Zero, (Damage ?? new FKSCDamage()).NativePtr);
		}

		// Token: 0x0601D4ED RID: 120045
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnCritCallback_Internal(IntPtr @this, IntPtr FromComp, IntPtr ToComp, IntPtr Damage);

		// Token: 0x0601D4EE RID: 120046 RVA: 0x002B45A4 File Offset: 0x002B27A4
		static UKSC_Listener_OnCrit()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Listener_OnCrit");
		}

		// Token: 0x0601D4EF RID: 120047 RVA: 0x002B45B2 File Offset: 0x002B27B2
		protected UKSC_Listener_OnCrit(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FE67 RID: 65127
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Listener_OnCrit";

		// Token: 0x0400FE68 RID: 65128
		private static IntPtr _ClassPtr;

		// Token: 0x0400FE69 RID: 65129
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FE6A RID: 65130
		internal static int __PropertyOffset_DamageTypeFilter;

		// Token: 0x0400FE6B RID: 65131
		[Nullable(2)]
		private FKSC_DamageTypeFilter _DamageTypeFilter;

		// Token: 0x0400FE6C RID: 65132
		internal static int __PropertyOffset_CheckTarget;
	}
}
