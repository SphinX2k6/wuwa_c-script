using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D73 RID: 7539
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_Buff_Period")]
	[UnrealStructLayout(608, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 608)]
	public abstract class UKSC_DA_Buff_Period : UKSC_DA_Buff, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601CDFE RID: 118270 RVA: 0x002AAE6E File Offset: 0x002A906E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_Buff_Period._ClassPtr;
		}

		// Token: 0x17007463 RID: 29795
		// (get) Token: 0x0601CDFF RID: 118271 RVA: 0x002AAE7A File Offset: 0x002A907A
		// (set) Token: 0x0601CE00 RID: 118272 RVA: 0x002AAE8A File Offset: 0x002A908A
		public unsafe float Period
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_Period.__PropertyOffset_Period);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_Period.__PropertyOffset_Period) = value;
			}
		}

		// Token: 0x17007464 RID: 29796
		// (get) Token: 0x0601CE01 RID: 118273 RVA: 0x002AAE9B File Offset: 0x002A909B
		// (set) Token: 0x0601CE02 RID: 118274 RVA: 0x002AAEAB File Offset: 0x002A90AB
		public unsafe float MinPeriod
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_Period.__PropertyOffset_MinPeriod);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_Period.__PropertyOffset_MinPeriod) = value;
			}
		}

		// Token: 0x17007465 RID: 29797
		// (get) Token: 0x0601CE03 RID: 118275 RVA: 0x002AAEBC File Offset: 0x002A90BC
		// (set) Token: 0x0601CE04 RID: 118276 RVA: 0x002AAECC File Offset: 0x002A90CC
		public unsafe bool PeriodImmediately
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_Period.__PropertyOffset_PeriodImmediately) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_Period.__PropertyOffset_PeriodImmediately) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007466 RID: 29798
		// (get) Token: 0x0601CE05 RID: 118277 RVA: 0x002AAEE0 File Offset: 0x002A90E0
		// (set) Token: 0x0601CE06 RID: 118278 RVA: 0x002AAF19 File Offset: 0x002A9119
		public TMap<FGameplayTag, float> TagPeriodInCrease
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FGameplayTag, float> result;
				if ((result = this._TagPeriodInCrease) == null)
				{
					result = (this._TagPeriodInCrease = new TMap<FGameplayTag, float>(base.NativePtr + (IntPtr)UKSC_DA_Buff_Period.__PropertyOffset_TagPeriodInCrease, this));
				}
				return result;
			}
			set
			{
				this.TagPeriodInCrease.CopyAssign(value);
			}
		}

		// Token: 0x17007467 RID: 29799
		// (get) Token: 0x0601CE07 RID: 118279 RVA: 0x002AAF27 File Offset: 0x002A9127
		// (set) Token: 0x0601CE08 RID: 118280 RVA: 0x002AAF37 File Offset: 0x002A9137
		public unsafe EKSC_PeriodBuffTagEffect TagPeriodInCreaseEffect
		{
			get
			{
				return (EKSC_PeriodBuffTagEffect)(*(base.NativePtr + (IntPtr)UKSC_DA_Buff_Period.__PropertyOffset_TagPeriodInCreaseEffect));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_Period.__PropertyOffset_TagPeriodInCreaseEffect) = (byte)value;
			}
		}

		// Token: 0x17007468 RID: 29800
		// (get) Token: 0x0601CE09 RID: 118281 RVA: 0x002AAF48 File Offset: 0x002A9148
		// (set) Token: 0x0601CE0A RID: 118282 RVA: 0x002AAF58 File Offset: 0x002A9158
		public unsafe bool AffectByAttackSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_Period.__PropertyOffset_AffectByAttackSpeed) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_Period.__PropertyOffset_AffectByAttackSpeed) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007469 RID: 29801
		// (get) Token: 0x0601CE0B RID: 118283 RVA: 0x002AAF6C File Offset: 0x002A916C
		// (set) Token: 0x0601CE0C RID: 118284 RVA: 0x002AAFA5 File Offset: 0x002A91A5
		public TMap<FGameplayTag, sbyte> TagCountInCrease
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FGameplayTag, sbyte> result;
				if ((result = this._TagCountInCrease) == null)
				{
					result = (this._TagCountInCrease = new TMap<FGameplayTag, sbyte>(base.NativePtr + (IntPtr)UKSC_DA_Buff_Period.__PropertyOffset_TagCountInCrease, this));
				}
				return result;
			}
			set
			{
				this.TagCountInCrease.CopyAssign(value);
			}
		}

		// Token: 0x0601CE0D RID: 118285 RVA: 0x002AAFB3 File Offset: 0x002A91B3
		static UKSC_DA_Buff_Period()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_Buff_Period");
		}

		// Token: 0x0601CE0E RID: 118286 RVA: 0x002AAFC4 File Offset: 0x002A91C4
		protected UKSC_DA_Buff_Period() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Buff_Period.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601CE0F RID: 118287 RVA: 0x002AAFEC File Offset: 0x002A91EC
		protected UKSC_DA_Buff_Period(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FAA6 RID: 64166
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_Buff_Period";

		// Token: 0x0400FAA7 RID: 64167
		private static IntPtr _ClassPtr;

		// Token: 0x0400FAA8 RID: 64168
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FAA9 RID: 64169
		internal static int __PropertyOffset_Period;

		// Token: 0x0400FAAA RID: 64170
		internal static int __PropertyOffset_MinPeriod;

		// Token: 0x0400FAAB RID: 64171
		internal static int __PropertyOffset_PeriodImmediately;

		// Token: 0x0400FAAC RID: 64172
		internal static int __PropertyOffset_TagPeriodInCrease;

		// Token: 0x0400FAAD RID: 64173
		[Nullable(2)]
		private TMap<FGameplayTag, float> _TagPeriodInCrease;

		// Token: 0x0400FAAE RID: 64174
		internal static int __PropertyOffset_TagPeriodInCreaseEffect;

		// Token: 0x0400FAAF RID: 64175
		internal static int __PropertyOffset_AffectByAttackSpeed;

		// Token: 0x0400FAB0 RID: 64176
		internal static int __PropertyOffset_TagCountInCrease;

		// Token: 0x0400FAB1 RID: 64177
		[Nullable(2)]
		private TMap<FGameplayTag, sbyte> _TagCountInCrease;
	}
}
