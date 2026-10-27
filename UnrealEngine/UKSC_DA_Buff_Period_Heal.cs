using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D77 RID: 7543
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_Buff_Period_Heal")]
	[UnrealStructLayout(688, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 688)]
	public class UKSC_DA_Buff_Period_Heal : UKSC_DA_Buff_Period, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601CE3F RID: 118335 RVA: 0x002AB48E File Offset: 0x002A968E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_Buff_Period_Heal._ClassPtr;
		}

		// Token: 0x0601CE40 RID: 118336 RVA: 0x002AB49C File Offset: 0x002A969C
		public UKSC_DA_Buff_Period_Heal() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Buff_Period_Heal.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601CE41 RID: 118337 RVA: 0x002AB4C4 File Offset: 0x002A96C4
		[NullableContext(1)]
		public UKSC_DA_Buff_Period_Heal(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Buff_Period_Heal.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700747A RID: 29818
		// (get) Token: 0x0601CE42 RID: 118338 RVA: 0x002AB4F7 File Offset: 0x002A96F7
		// (set) Token: 0x0601CE43 RID: 118339 RVA: 0x002AB507 File Offset: 0x002A9707
		public unsafe int Probability
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_Period_Heal.__PropertyOffset_Probability);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_Period_Heal.__PropertyOffset_Probability) = value;
			}
		}

		// Token: 0x1700747B RID: 29819
		// (get) Token: 0x0601CE44 RID: 118340 RVA: 0x002AB518 File Offset: 0x002A9718
		// (set) Token: 0x0601CE45 RID: 118341 RVA: 0x002AB528 File Offset: 0x002A9728
		public unsafe int HealFX_MaxNum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_Period_Heal.__PropertyOffset_HealFX_MaxNum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_Period_Heal.__PropertyOffset_HealFX_MaxNum) = value;
			}
		}

		// Token: 0x1700747C RID: 29820
		// (get) Token: 0x0601CE46 RID: 118342 RVA: 0x002AB539 File Offset: 0x002A9739
		// (set) Token: 0x0601CE47 RID: 118343 RVA: 0x002AB54D File Offset: 0x002A974D
		[Nullable(2)]
		public unsafe UEffectModelBase HealFX
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UEffectModelBase>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Buff_Period_Heal.__PropertyOffset_HealFX);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Buff_Period_Heal.__PropertyOffset_HealFX, value);
			}
		}

		// Token: 0x1700747D RID: 29821
		// (get) Token: 0x0601CE48 RID: 118344 RVA: 0x002AB562 File Offset: 0x002A9762
		// (set) Token: 0x0601CE49 RID: 118345 RVA: 0x002AB576 File Offset: 0x002A9776
		public unsafe FTransform HealFX_Offset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_Period_Heal.__PropertyOffset_HealFX_Offset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_Period_Heal.__PropertyOffset_HealFX_Offset) = value;
			}
		}

		// Token: 0x1700747E RID: 29822
		// (get) Token: 0x0601CE4A RID: 118346 RVA: 0x002AB58B File Offset: 0x002A978B
		// (set) Token: 0x0601CE4B RID: 118347 RVA: 0x002AB59B File Offset: 0x002A979B
		public unsafe EKSC_AttrType FromAttrId
		{
			get
			{
				return (EKSC_AttrType)(*(base.NativePtr + (IntPtr)UKSC_DA_Buff_Period_Heal.__PropertyOffset_FromAttrId));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_Period_Heal.__PropertyOffset_FromAttrId) = (byte)value;
			}
		}

		// Token: 0x1700747F RID: 29823
		// (get) Token: 0x0601CE4C RID: 118348 RVA: 0x002AB5AC File Offset: 0x002A97AC
		// (set) Token: 0x0601CE4D RID: 118349 RVA: 0x002AB5BC File Offset: 0x002A97BC
		public unsafe float Amplify
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_Period_Heal.__PropertyOffset_Amplify);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_Period_Heal.__PropertyOffset_Amplify) = value;
			}
		}

		// Token: 0x0601CE4E RID: 118350 RVA: 0x002AB5CD File Offset: 0x002A97CD
		static UKSC_DA_Buff_Period_Heal()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_Buff_Period_Heal");
		}

		// Token: 0x0601CE4F RID: 118351 RVA: 0x002AB5DB File Offset: 0x002A97DB
		protected UKSC_DA_Buff_Period_Heal(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FAD0 RID: 64208
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_Buff_Period_Heal";

		// Token: 0x0400FAD1 RID: 64209
		private static IntPtr _ClassPtr;

		// Token: 0x0400FAD2 RID: 64210
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FAD3 RID: 64211
		internal static int __PropertyOffset_Probability;

		// Token: 0x0400FAD4 RID: 64212
		internal static int __PropertyOffset_HealFX_MaxNum;

		// Token: 0x0400FAD5 RID: 64213
		internal static int __PropertyOffset_HealFX;

		// Token: 0x0400FAD6 RID: 64214
		internal static int __PropertyOffset_HealFX_Offset;

		// Token: 0x0400FAD7 RID: 64215
		internal static int __PropertyOffset_FromAttrId;

		// Token: 0x0400FAD8 RID: 64216
		internal static int __PropertyOffset_Amplify;
	}
}
