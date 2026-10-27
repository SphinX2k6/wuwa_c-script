using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D74 RID: 7540
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_Buff_Period_Action")]
	[UnrealStructLayout(768, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 768)]
	public class UKSC_DA_Buff_Period_Action : UKSC_DA_Buff_Period, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601CE10 RID: 118288 RVA: 0x002AAFF5 File Offset: 0x002A91F5
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_Buff_Period_Action._ClassPtr;
		}

		// Token: 0x0601CE11 RID: 118289 RVA: 0x002AB004 File Offset: 0x002A9204
		public UKSC_DA_Buff_Period_Action() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Buff_Period_Action.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601CE12 RID: 118290 RVA: 0x002AB02C File Offset: 0x002A922C
		[NullableContext(1)]
		public UKSC_DA_Buff_Period_Action(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Buff_Period_Action.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700746A RID: 29802
		// (get) Token: 0x0601CE13 RID: 118291 RVA: 0x002AB05F File Offset: 0x002A925F
		// (set) Token: 0x0601CE14 RID: 118292 RVA: 0x002AB06F File Offset: 0x002A926F
		public unsafe bool ApplyDamage
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_Period_Action.__PropertyOffset_ApplyDamage) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_Period_Action.__PropertyOffset_ApplyDamage) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700746B RID: 29803
		// (get) Token: 0x0601CE15 RID: 118293 RVA: 0x002AB080 File Offset: 0x002A9280
		// (set) Token: 0x0601CE16 RID: 118294 RVA: 0x002AB0B9 File Offset: 0x002A92B9
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
					result = (this._Damage = new FKSCDamage(base.NativePtr + (IntPtr)UKSC_DA_Buff_Period_Action.__PropertyOffset_Damage, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKSCDamage.StaticStruct(), base.NativePtr + (IntPtr)UKSC_DA_Buff_Period_Action.__PropertyOffset_Damage, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700746C RID: 29804
		// (get) Token: 0x0601CE17 RID: 118295 RVA: 0x002AB0DA File Offset: 0x002A92DA
		// (set) Token: 0x0601CE18 RID: 118296 RVA: 0x002AB0EA File Offset: 0x002A92EA
		public unsafe int DamageID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_Period_Action.__PropertyOffset_DamageID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_Period_Action.__PropertyOffset_DamageID) = value;
			}
		}

		// Token: 0x1700746D RID: 29805
		// (get) Token: 0x0601CE19 RID: 118297 RVA: 0x002AB0FB File Offset: 0x002A92FB
		// (set) Token: 0x0601CE1A RID: 118298 RVA: 0x002AB10F File Offset: 0x002A930F
		public unsafe UKSC_DA_Buff ToDoBuff
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_Buff>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Buff_Period_Action.__PropertyOffset_ToDoBuff);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Buff_Period_Action.__PropertyOffset_ToDoBuff, value);
			}
		}

		// Token: 0x1700746E RID: 29806
		// (get) Token: 0x0601CE1B RID: 118299 RVA: 0x002AB124 File Offset: 0x002A9324
		// (set) Token: 0x0601CE1C RID: 118300 RVA: 0x002AB138 File Offset: 0x002A9338
		public unsafe UKSC_DA_AdditionalAttack AdditionalAttack
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_AdditionalAttack>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Buff_Period_Action.__PropertyOffset_AdditionalAttack);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Buff_Period_Action.__PropertyOffset_AdditionalAttack, value);
			}
		}

		// Token: 0x1700746F RID: 29807
		// (get) Token: 0x0601CE1D RID: 118301 RVA: 0x002AB150 File Offset: 0x002A9350
		// (set) Token: 0x0601CE1E RID: 118302 RVA: 0x002AB189 File Offset: 0x002A9389
		[Nullable(1)]
		public TArray<FKSC_ModifyAttrFromOthers> ModifyAttr
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FKSC_ModifyAttrFromOthers> result;
				if ((result = this._ModifyAttr) == null)
				{
					result = (this._ModifyAttr = new TArray<FKSC_ModifyAttrFromOthers>(base.NativePtr + (IntPtr)UKSC_DA_Buff_Period_Action.__PropertyOffset_ModifyAttr, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.ModifyAttr.CopyAssign(value);
			}
		}

		// Token: 0x17007470 RID: 29808
		// (get) Token: 0x0601CE1F RID: 118303 RVA: 0x002AB197 File Offset: 0x002A9397
		// (set) Token: 0x0601CE20 RID: 118304 RVA: 0x002AB1A7 File Offset: 0x002A93A7
		public unsafe int KuroBuffHitFX_MaxNum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_Period_Action.__PropertyOffset_KuroBuffHitFX_MaxNum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_Period_Action.__PropertyOffset_KuroBuffHitFX_MaxNum) = value;
			}
		}

		// Token: 0x17007471 RID: 29809
		// (get) Token: 0x0601CE21 RID: 118305 RVA: 0x002AB1B8 File Offset: 0x002A93B8
		// (set) Token: 0x0601CE22 RID: 118306 RVA: 0x002AB1CC File Offset: 0x002A93CC
		public unsafe UEffectModelBase KuroBuffHitFX
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UEffectModelBase>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Buff_Period_Action.__PropertyOffset_KuroBuffHitFX);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Buff_Period_Action.__PropertyOffset_KuroBuffHitFX, value);
			}
		}

		// Token: 0x17007472 RID: 29810
		// (get) Token: 0x0601CE23 RID: 118307 RVA: 0x002AB1E1 File Offset: 0x002A93E1
		// (set) Token: 0x0601CE24 RID: 118308 RVA: 0x002AB1F5 File Offset: 0x002A93F5
		public unsafe FTransform KuroBuffHitFX_Offset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_Period_Action.__PropertyOffset_KuroBuffHitFX_Offset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_Period_Action.__PropertyOffset_KuroBuffHitFX_Offset) = value;
			}
		}

		// Token: 0x0601CE25 RID: 118309 RVA: 0x002AB20A File Offset: 0x002A940A
		static UKSC_DA_Buff_Period_Action()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_Buff_Period_Action");
		}

		// Token: 0x0601CE26 RID: 118310 RVA: 0x002AB218 File Offset: 0x002A9418
		protected UKSC_DA_Buff_Period_Action(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FAB2 RID: 64178
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_Buff_Period_Action";

		// Token: 0x0400FAB3 RID: 64179
		private static IntPtr _ClassPtr;

		// Token: 0x0400FAB4 RID: 64180
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FAB5 RID: 64181
		internal static int __PropertyOffset_ApplyDamage;

		// Token: 0x0400FAB6 RID: 64182
		internal static int __PropertyOffset_Damage;

		// Token: 0x0400FAB7 RID: 64183
		private FKSCDamage _Damage;

		// Token: 0x0400FAB8 RID: 64184
		internal static int __PropertyOffset_DamageID;

		// Token: 0x0400FAB9 RID: 64185
		internal static int __PropertyOffset_ToDoBuff;

		// Token: 0x0400FABA RID: 64186
		internal static int __PropertyOffset_AdditionalAttack;

		// Token: 0x0400FABB RID: 64187
		internal static int __PropertyOffset_ModifyAttr;

		// Token: 0x0400FABC RID: 64188
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKSC_ModifyAttrFromOthers> _ModifyAttr;

		// Token: 0x0400FABD RID: 64189
		internal static int __PropertyOffset_KuroBuffHitFX_MaxNum;

		// Token: 0x0400FABE RID: 64190
		internal static int __PropertyOffset_KuroBuffHitFX;

		// Token: 0x0400FABF RID: 64191
		internal static int __PropertyOffset_KuroBuffHitFX_Offset;
	}
}
