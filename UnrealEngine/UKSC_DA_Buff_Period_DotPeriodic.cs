using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D75 RID: 7541
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_Buff_Period_DotPeriodic")]
	[UnrealStructLayout(688, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 688)]
	public class UKSC_DA_Buff_Period_DotPeriodic : UKSC_DA_Buff_Period, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601CE27 RID: 118311 RVA: 0x002AB221 File Offset: 0x002A9421
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_Buff_Period_DotPeriodic._ClassPtr;
		}

		// Token: 0x0601CE28 RID: 118312 RVA: 0x002AB230 File Offset: 0x002A9430
		public UKSC_DA_Buff_Period_DotPeriodic() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Buff_Period_DotPeriodic.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601CE29 RID: 118313 RVA: 0x002AB258 File Offset: 0x002A9458
		public UKSC_DA_Buff_Period_DotPeriodic(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Buff_Period_DotPeriodic.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007473 RID: 29811
		// (get) Token: 0x0601CE2A RID: 118314 RVA: 0x002AB28B File Offset: 0x002A948B
		// (set) Token: 0x0601CE2B RID: 118315 RVA: 0x002AB29B File Offset: 0x002A949B
		public unsafe int DamageID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_Period_DotPeriodic.__PropertyOffset_DamageID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_Period_DotPeriodic.__PropertyOffset_DamageID) = value;
			}
		}

		// Token: 0x17007474 RID: 29812
		// (get) Token: 0x0601CE2C RID: 118316 RVA: 0x002AB2AC File Offset: 0x002A94AC
		// (set) Token: 0x0601CE2D RID: 118317 RVA: 0x002AB2E5 File Offset: 0x002A94E5
		public FKSCDamage Damage
		{
			get
			{
				base.FastCheckIsValid();
				FKSCDamage result;
				if ((result = this._Damage) == null)
				{
					result = (this._Damage = new FKSCDamage(base.NativePtr + (IntPtr)UKSC_DA_Buff_Period_DotPeriodic.__PropertyOffset_Damage, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKSCDamage.StaticStruct(), base.NativePtr + (IntPtr)UKSC_DA_Buff_Period_DotPeriodic.__PropertyOffset_Damage, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007475 RID: 29813
		// (get) Token: 0x0601CE2E RID: 118318 RVA: 0x002AB306 File Offset: 0x002A9506
		// (set) Token: 0x0601CE2F RID: 118319 RVA: 0x002AB316 File Offset: 0x002A9516
		public unsafe EKSC_AttrType IntervalAttrType
		{
			get
			{
				return (EKSC_AttrType)(*(base.NativePtr + (IntPtr)UKSC_DA_Buff_Period_DotPeriodic.__PropertyOffset_IntervalAttrType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_Period_DotPeriodic.__PropertyOffset_IntervalAttrType) = (byte)value;
			}
		}

		// Token: 0x17007476 RID: 29814
		// (get) Token: 0x0601CE30 RID: 118320 RVA: 0x002AB327 File Offset: 0x002A9527
		// (set) Token: 0x0601CE31 RID: 118321 RVA: 0x002AB337 File Offset: 0x002A9537
		public unsafe bool bCountAsDotBuff
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_Period_DotPeriodic.__PropertyOffset_bCountAsDotBuff) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_Period_DotPeriodic.__PropertyOffset_bCountAsDotBuff) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007477 RID: 29815
		// (get) Token: 0x0601CE32 RID: 118322 RVA: 0x002AB348 File Offset: 0x002A9548
		// (set) Token: 0x0601CE33 RID: 118323 RVA: 0x002AB381 File Offset: 0x002A9581
		public TArray<FKSC_DotPeriodic_BuffOnCasterTag> BuffsOnCasterTag
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKSC_DotPeriodic_BuffOnCasterTag> result;
				if ((result = this._BuffsOnCasterTag) == null)
				{
					result = (this._BuffsOnCasterTag = new TArray<FKSC_DotPeriodic_BuffOnCasterTag>(base.NativePtr + (IntPtr)UKSC_DA_Buff_Period_DotPeriodic.__PropertyOffset_BuffsOnCasterTag, this));
				}
				return result;
			}
			set
			{
				this.BuffsOnCasterTag.CopyAssign(value);
			}
		}

		// Token: 0x0601CE34 RID: 118324 RVA: 0x002AB38F File Offset: 0x002A958F
		static UKSC_DA_Buff_Period_DotPeriodic()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_Buff_Period_DotPeriodic");
		}

		// Token: 0x0601CE35 RID: 118325 RVA: 0x002AB39D File Offset: 0x002A959D
		protected UKSC_DA_Buff_Period_DotPeriodic(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FAC0 RID: 64192
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_Buff_Period_DotPeriodic";

		// Token: 0x0400FAC1 RID: 64193
		private static IntPtr _ClassPtr;

		// Token: 0x0400FAC2 RID: 64194
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FAC3 RID: 64195
		internal static int __PropertyOffset_DamageID;

		// Token: 0x0400FAC4 RID: 64196
		internal static int __PropertyOffset_Damage;

		// Token: 0x0400FAC5 RID: 64197
		[Nullable(2)]
		private FKSCDamage _Damage;

		// Token: 0x0400FAC6 RID: 64198
		internal static int __PropertyOffset_IntervalAttrType;

		// Token: 0x0400FAC7 RID: 64199
		internal static int __PropertyOffset_bCountAsDotBuff;

		// Token: 0x0400FAC8 RID: 64200
		internal static int __PropertyOffset_BuffsOnCasterTag;

		// Token: 0x0400FAC9 RID: 64201
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKSC_DotPeriodic_BuffOnCasterTag> _BuffsOnCasterTag;
	}
}
