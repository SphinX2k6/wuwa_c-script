using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D48 RID: 7496
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_AdditionalAttack")]
	[UnrealStructLayout(368, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 368)]
	public class UKSC_DA_AdditionalAttack : UDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601CB3F RID: 117567 RVA: 0x002A6E3B File Offset: 0x002A503B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_AdditionalAttack._ClassPtr;
		}

		// Token: 0x0601CB40 RID: 117568 RVA: 0x002A6E48 File Offset: 0x002A5048
		public UKSC_DA_AdditionalAttack() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_AdditionalAttack.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601CB41 RID: 117569 RVA: 0x002A6E70 File Offset: 0x002A5070
		[NullableContext(1)]
		public UKSC_DA_AdditionalAttack(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_AdditionalAttack.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700736E RID: 29550
		// (get) Token: 0x0601CB42 RID: 117570 RVA: 0x002A6EA3 File Offset: 0x002A50A3
		// (set) Token: 0x0601CB43 RID: 117571 RVA: 0x002A6EB3 File Offset: 0x002A50B3
		public unsafe EKSC_AdditionalAttackSource AttackSourceType
		{
			get
			{
				return (EKSC_AdditionalAttackSource)(*(base.NativePtr + (IntPtr)UKSC_DA_AdditionalAttack.__PropertyOffset_AttackSourceType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_AdditionalAttack.__PropertyOffset_AttackSourceType) = (byte)value;
			}
		}

		// Token: 0x1700736F RID: 29551
		// (get) Token: 0x0601CB44 RID: 117572 RVA: 0x002A6EC4 File Offset: 0x002A50C4
		// (set) Token: 0x0601CB45 RID: 117573 RVA: 0x002A6ED4 File Offset: 0x002A50D4
		public unsafe EKSC_AdditionalAttackSourceTarget AttackTargetType
		{
			get
			{
				return (EKSC_AdditionalAttackSourceTarget)(*(base.NativePtr + (IntPtr)UKSC_DA_AdditionalAttack.__PropertyOffset_AttackTargetType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_AdditionalAttack.__PropertyOffset_AttackTargetType) = (byte)value;
			}
		}

		// Token: 0x17007370 RID: 29552
		// (get) Token: 0x0601CB46 RID: 117574 RVA: 0x002A6EE8 File Offset: 0x002A50E8
		// (set) Token: 0x0601CB47 RID: 117575 RVA: 0x002A6F21 File Offset: 0x002A5121
		[Nullable(1)]
		public TArray<EKSC_Faction> IgnoreFactions
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<EKSC_Faction> result;
				if ((result = this._IgnoreFactions) == null)
				{
					result = (this._IgnoreFactions = new TArray<EKSC_Faction>(base.NativePtr + (IntPtr)UKSC_DA_AdditionalAttack.__PropertyOffset_IgnoreFactions, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.IgnoreFactions.CopyAssign(value);
			}
		}

		// Token: 0x17007371 RID: 29553
		// (get) Token: 0x0601CB48 RID: 117576 RVA: 0x002A6F2F File Offset: 0x002A512F
		// (set) Token: 0x0601CB49 RID: 117577 RVA: 0x002A6F43 File Offset: 0x002A5143
		public unsafe FName AdditionalAttackSocket
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_AdditionalAttack.__PropertyOffset_AdditionalAttackSocket);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_AdditionalAttack.__PropertyOffset_AdditionalAttackSocket) = value;
			}
		}

		// Token: 0x17007372 RID: 29554
		// (get) Token: 0x0601CB4A RID: 117578 RVA: 0x002A6F58 File Offset: 0x002A5158
		// (set) Token: 0x0601CB4B RID: 117579 RVA: 0x002A6F91 File Offset: 0x002A5191
		[Nullable(1)]
		public FKSC_Range AdditionalAttackRange
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FKSC_Range result;
				if ((result = this._AdditionalAttackRange) == null)
				{
					result = (this._AdditionalAttackRange = new FKSC_Range(base.NativePtr + (IntPtr)UKSC_DA_AdditionalAttack.__PropertyOffset_AdditionalAttackRange, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKSC_Range.StaticStruct(), base.NativePtr + (IntPtr)UKSC_DA_AdditionalAttack.__PropertyOffset_AdditionalAttackRange, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007373 RID: 29555
		// (get) Token: 0x0601CB4C RID: 117580 RVA: 0x002A6FB4 File Offset: 0x002A51B4
		// (set) Token: 0x0601CB4D RID: 117581 RVA: 0x002A6FED File Offset: 0x002A51ED
		[Nullable(1)]
		public FKSCDamage Damage
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FKSCDamage result;
				if ((result = this._Damage) == null)
				{
					result = (this._Damage = new FKSCDamage(base.NativePtr + (IntPtr)UKSC_DA_AdditionalAttack.__PropertyOffset_Damage, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKSCDamage.StaticStruct(), base.NativePtr + (IntPtr)UKSC_DA_AdditionalAttack.__PropertyOffset_Damage, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007374 RID: 29556
		// (get) Token: 0x0601CB4E RID: 117582 RVA: 0x002A700E File Offset: 0x002A520E
		// (set) Token: 0x0601CB4F RID: 117583 RVA: 0x002A701E File Offset: 0x002A521E
		public unsafe int DamageID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_AdditionalAttack.__PropertyOffset_DamageID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_AdditionalAttack.__PropertyOffset_DamageID) = value;
			}
		}

		// Token: 0x17007375 RID: 29557
		// (get) Token: 0x0601CB50 RID: 117584 RVA: 0x002A702F File Offset: 0x002A522F
		// (set) Token: 0x0601CB51 RID: 117585 RVA: 0x002A703F File Offset: 0x002A523F
		public unsafe bool DamageMaterial
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_AdditionalAttack.__PropertyOffset_DamageMaterial) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_AdditionalAttack.__PropertyOffset_DamageMaterial) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007376 RID: 29558
		// (get) Token: 0x0601CB52 RID: 117586 RVA: 0x002A7050 File Offset: 0x002A5250
		// (set) Token: 0x0601CB53 RID: 117587 RVA: 0x002A7060 File Offset: 0x002A5260
		public unsafe bool TriggerHitEvent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_AdditionalAttack.__PropertyOffset_TriggerHitEvent) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_AdditionalAttack.__PropertyOffset_TriggerHitEvent) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007377 RID: 29559
		// (get) Token: 0x0601CB54 RID: 117588 RVA: 0x002A7071 File Offset: 0x002A5271
		// (set) Token: 0x0601CB55 RID: 117589 RVA: 0x002A7085 File Offset: 0x002A5285
		public unsafe UKSC_DA_Buff AddBuff
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_Buff>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_AdditionalAttack.__PropertyOffset_AddBuff);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_AdditionalAttack.__PropertyOffset_AddBuff, value);
			}
		}

		// Token: 0x17007378 RID: 29560
		// (get) Token: 0x0601CB56 RID: 117590 RVA: 0x002A709A File Offset: 0x002A529A
		// (set) Token: 0x0601CB57 RID: 117591 RVA: 0x002A70AE File Offset: 0x002A52AE
		public unsafe UEffectModelBase KuroCastFX
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UEffectModelBase>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_AdditionalAttack.__PropertyOffset_KuroCastFX);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_AdditionalAttack.__PropertyOffset_KuroCastFX, value);
			}
		}

		// Token: 0x17007379 RID: 29561
		// (get) Token: 0x0601CB58 RID: 117592 RVA: 0x002A70C3 File Offset: 0x002A52C3
		// (set) Token: 0x0601CB59 RID: 117593 RVA: 0x002A70D7 File Offset: 0x002A52D7
		public unsafe FTransform KuroCastFX_Offset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_AdditionalAttack.__PropertyOffset_KuroCastFX_Offset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_AdditionalAttack.__PropertyOffset_KuroCastFX_Offset) = value;
			}
		}

		// Token: 0x1700737A RID: 29562
		// (get) Token: 0x0601CB5A RID: 117594 RVA: 0x002A70EC File Offset: 0x002A52EC
		// (set) Token: 0x0601CB5B RID: 117595 RVA: 0x002A70FC File Offset: 0x002A52FC
		public unsafe int KuroHitFX_MaxNum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_AdditionalAttack.__PropertyOffset_KuroHitFX_MaxNum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_AdditionalAttack.__PropertyOffset_KuroHitFX_MaxNum) = value;
			}
		}

		// Token: 0x1700737B RID: 29563
		// (get) Token: 0x0601CB5C RID: 117596 RVA: 0x002A710D File Offset: 0x002A530D
		// (set) Token: 0x0601CB5D RID: 117597 RVA: 0x002A7121 File Offset: 0x002A5321
		public unsafe UEffectModelBase KuroHitFX
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UEffectModelBase>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_AdditionalAttack.__PropertyOffset_KuroHitFX);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_AdditionalAttack.__PropertyOffset_KuroHitFX, value);
			}
		}

		// Token: 0x1700737C RID: 29564
		// (get) Token: 0x0601CB5E RID: 117598 RVA: 0x002A7136 File Offset: 0x002A5336
		// (set) Token: 0x0601CB5F RID: 117599 RVA: 0x002A714A File Offset: 0x002A534A
		public unsafe FTransform KuroHitFX_Offset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_AdditionalAttack.__PropertyOffset_KuroHitFX_Offset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_AdditionalAttack.__PropertyOffset_KuroHitFX_Offset) = value;
			}
		}

		// Token: 0x0601CB60 RID: 117600 RVA: 0x002A715F File Offset: 0x002A535F
		static UKSC_DA_AdditionalAttack()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_AdditionalAttack");
		}

		// Token: 0x0601CB61 RID: 117601 RVA: 0x002A716D File Offset: 0x002A536D
		protected UKSC_DA_AdditionalAttack(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F8FC RID: 63740
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_AdditionalAttack";

		// Token: 0x0400F8FD RID: 63741
		private static IntPtr _ClassPtr;

		// Token: 0x0400F8FE RID: 63742
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F8FF RID: 63743
		internal static int __PropertyOffset_AttackSourceType;

		// Token: 0x0400F900 RID: 63744
		internal static int __PropertyOffset_AttackTargetType;

		// Token: 0x0400F901 RID: 63745
		internal static int __PropertyOffset_IgnoreFactions;

		// Token: 0x0400F902 RID: 63746
		private TArray<EKSC_Faction> _IgnoreFactions;

		// Token: 0x0400F903 RID: 63747
		internal static int __PropertyOffset_AdditionalAttackSocket;

		// Token: 0x0400F904 RID: 63748
		internal static int __PropertyOffset_AdditionalAttackRange;

		// Token: 0x0400F905 RID: 63749
		private FKSC_Range _AdditionalAttackRange;

		// Token: 0x0400F906 RID: 63750
		internal static int __PropertyOffset_Damage;

		// Token: 0x0400F907 RID: 63751
		private FKSCDamage _Damage;

		// Token: 0x0400F908 RID: 63752
		internal static int __PropertyOffset_DamageID;

		// Token: 0x0400F909 RID: 63753
		internal static int __PropertyOffset_DamageMaterial;

		// Token: 0x0400F90A RID: 63754
		internal static int __PropertyOffset_TriggerHitEvent;

		// Token: 0x0400F90B RID: 63755
		internal static int __PropertyOffset_AddBuff;

		// Token: 0x0400F90C RID: 63756
		internal static int __PropertyOffset_KuroCastFX;

		// Token: 0x0400F90D RID: 63757
		internal static int __PropertyOffset_KuroCastFX_Offset;

		// Token: 0x0400F90E RID: 63758
		internal static int __PropertyOffset_KuroHitFX_MaxNum;

		// Token: 0x0400F90F RID: 63759
		internal static int __PropertyOffset_KuroHitFX;

		// Token: 0x0400F910 RID: 63760
		internal static int __PropertyOffset_KuroHitFX_Offset;
	}
}
