using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200195B RID: 6491
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGAS.BaseAttributeSet")]
	[UnrealStructLayout(3536, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 3536)]
	public class UBaseAttributeSet : UAttributeSet, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060180DA RID: 98522 RVA: 0x00235E2C File Offset: 0x0023402C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBaseAttributeSet._ClassPtr;
		}

		// Token: 0x060180DB RID: 98523 RVA: 0x00235E38 File Offset: 0x00234038
		public UBaseAttributeSet() : this(BuiltinUtils.AllocNativeUObject(UBaseAttributeSet.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060180DC RID: 98524 RVA: 0x00235E60 File Offset: 0x00234060
		public UBaseAttributeSet(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBaseAttributeSet.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006043 RID: 24643
		// (get) Token: 0x060180DD RID: 98525 RVA: 0x00235E94 File Offset: 0x00234094
		// (set) Token: 0x060180DE RID: 98526 RVA: 0x00235ECD File Offset: 0x002340CD
		public FGameplayAttributeData Lv
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._Lv) == null)
				{
					result = (this._Lv = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_Lv, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_Lv, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006044 RID: 24644
		// (get) Token: 0x060180DF RID: 98527 RVA: 0x00235EF0 File Offset: 0x002340F0
		// (set) Token: 0x060180E0 RID: 98528 RVA: 0x00235F29 File Offset: 0x00234129
		public FGameplayAttributeData LifeMax
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._LifeMax) == null)
				{
					result = (this._LifeMax = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_LifeMax, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_LifeMax, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006045 RID: 24645
		// (get) Token: 0x060180E1 RID: 98529 RVA: 0x00235F4C File Offset: 0x0023414C
		// (set) Token: 0x060180E2 RID: 98530 RVA: 0x00235F85 File Offset: 0x00234185
		public FGameplayAttributeData Life
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._Life) == null)
				{
					result = (this._Life = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_Life, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_Life, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006046 RID: 24646
		// (get) Token: 0x060180E3 RID: 98531 RVA: 0x00235FA8 File Offset: 0x002341A8
		// (set) Token: 0x060180E4 RID: 98532 RVA: 0x00235FE1 File Offset: 0x002341E1
		public FGameplayAttributeData Sheild
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._Sheild) == null)
				{
					result = (this._Sheild = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_Sheild, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_Sheild, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006047 RID: 24647
		// (get) Token: 0x060180E5 RID: 98533 RVA: 0x00236004 File Offset: 0x00234204
		// (set) Token: 0x060180E6 RID: 98534 RVA: 0x0023603D File Offset: 0x0023423D
		public FGameplayAttributeData SheildDamageChange
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._SheildDamageChange) == null)
				{
					result = (this._SheildDamageChange = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_SheildDamageChange, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_SheildDamageChange, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006048 RID: 24648
		// (get) Token: 0x060180E7 RID: 98535 RVA: 0x00236060 File Offset: 0x00234260
		// (set) Token: 0x060180E8 RID: 98536 RVA: 0x00236099 File Offset: 0x00234299
		public FGameplayAttributeData SheildDamageReduce
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._SheildDamageReduce) == null)
				{
					result = (this._SheildDamageReduce = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_SheildDamageReduce, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_SheildDamageReduce, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006049 RID: 24649
		// (get) Token: 0x060180E9 RID: 98537 RVA: 0x002360BC File Offset: 0x002342BC
		// (set) Token: 0x060180EA RID: 98538 RVA: 0x002360F5 File Offset: 0x002342F5
		public FGameplayAttributeData Atk
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._Atk) == null)
				{
					result = (this._Atk = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_Atk, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_Atk, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700604A RID: 24650
		// (get) Token: 0x060180EB RID: 98539 RVA: 0x00236118 File Offset: 0x00234318
		// (set) Token: 0x060180EC RID: 98540 RVA: 0x00236151 File Offset: 0x00234351
		public FGameplayAttributeData Crit
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._Crit) == null)
				{
					result = (this._Crit = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_Crit, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_Crit, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700604B RID: 24651
		// (get) Token: 0x060180ED RID: 98541 RVA: 0x00236174 File Offset: 0x00234374
		// (set) Token: 0x060180EE RID: 98542 RVA: 0x002361AD File Offset: 0x002343AD
		public FGameplayAttributeData CritDamage
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._CritDamage) == null)
				{
					result = (this._CritDamage = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_CritDamage, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_CritDamage, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700604C RID: 24652
		// (get) Token: 0x060180EF RID: 98543 RVA: 0x002361D0 File Offset: 0x002343D0
		// (set) Token: 0x060180F0 RID: 98544 RVA: 0x00236209 File Offset: 0x00234409
		public FGameplayAttributeData Def
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._Def) == null)
				{
					result = (this._Def = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_Def, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_Def, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700604D RID: 24653
		// (get) Token: 0x060180F1 RID: 98545 RVA: 0x0023622C File Offset: 0x0023442C
		// (set) Token: 0x060180F2 RID: 98546 RVA: 0x00236265 File Offset: 0x00234465
		public FGameplayAttributeData EnergyEfficiency
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._EnergyEfficiency) == null)
				{
					result = (this._EnergyEfficiency = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_EnergyEfficiency, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_EnergyEfficiency, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700604E RID: 24654
		// (get) Token: 0x060180F3 RID: 98547 RVA: 0x00236288 File Offset: 0x00234488
		// (set) Token: 0x060180F4 RID: 98548 RVA: 0x002362C1 File Offset: 0x002344C1
		public FGameplayAttributeData CDReduse
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._CDReduse) == null)
				{
					result = (this._CDReduse = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_CDReduse, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_CDReduse, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700604F RID: 24655
		// (get) Token: 0x060180F5 RID: 98549 RVA: 0x002362E4 File Offset: 0x002344E4
		// (set) Token: 0x060180F6 RID: 98550 RVA: 0x0023631D File Offset: 0x0023451D
		public FGameplayAttributeData ReactionEfficiency
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._ReactionEfficiency) == null)
				{
					result = (this._ReactionEfficiency = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_ReactionEfficiency, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_ReactionEfficiency, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006050 RID: 24656
		// (get) Token: 0x060180F7 RID: 98551 RVA: 0x00236340 File Offset: 0x00234540
		// (set) Token: 0x060180F8 RID: 98552 RVA: 0x00236379 File Offset: 0x00234579
		public FGameplayAttributeData DamageChangeNormalSkill
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._DamageChangeNormalSkill) == null)
				{
					result = (this._DamageChangeNormalSkill = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_DamageChangeNormalSkill, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_DamageChangeNormalSkill, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006051 RID: 24657
		// (get) Token: 0x060180F9 RID: 98553 RVA: 0x0023639C File Offset: 0x0023459C
		// (set) Token: 0x060180FA RID: 98554 RVA: 0x002363D5 File Offset: 0x002345D5
		public FGameplayAttributeData DamageChange
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._DamageChange) == null)
				{
					result = (this._DamageChange = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_DamageChange, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_DamageChange, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006052 RID: 24658
		// (get) Token: 0x060180FB RID: 98555 RVA: 0x002363F8 File Offset: 0x002345F8
		// (set) Token: 0x060180FC RID: 98556 RVA: 0x00236431 File Offset: 0x00234631
		public FGameplayAttributeData DamageReduce
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._DamageReduce) == null)
				{
					result = (this._DamageReduce = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_DamageReduce, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_DamageReduce, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006053 RID: 24659
		// (get) Token: 0x060180FD RID: 98557 RVA: 0x00236454 File Offset: 0x00234654
		// (set) Token: 0x060180FE RID: 98558 RVA: 0x0023648D File Offset: 0x0023468D
		public FGameplayAttributeData DamageChangeAuto
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._DamageChangeAuto) == null)
				{
					result = (this._DamageChangeAuto = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_DamageChangeAuto, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_DamageChangeAuto, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006054 RID: 24660
		// (get) Token: 0x060180FF RID: 98559 RVA: 0x002364B0 File Offset: 0x002346B0
		// (set) Token: 0x06018100 RID: 98560 RVA: 0x002364E9 File Offset: 0x002346E9
		public FGameplayAttributeData DamageChangeCast
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._DamageChangeCast) == null)
				{
					result = (this._DamageChangeCast = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_DamageChangeCast, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_DamageChangeCast, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006055 RID: 24661
		// (get) Token: 0x06018101 RID: 98561 RVA: 0x0023650C File Offset: 0x0023470C
		// (set) Token: 0x06018102 RID: 98562 RVA: 0x00236545 File Offset: 0x00234745
		public FGameplayAttributeData DamageChangeUltra
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._DamageChangeUltra) == null)
				{
					result = (this._DamageChangeUltra = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_DamageChangeUltra, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_DamageChangeUltra, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006056 RID: 24662
		// (get) Token: 0x06018103 RID: 98563 RVA: 0x00236568 File Offset: 0x00234768
		// (set) Token: 0x06018104 RID: 98564 RVA: 0x002365A1 File Offset: 0x002347A1
		public FGameplayAttributeData DamageChangeQTE
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._DamageChangeQTE) == null)
				{
					result = (this._DamageChangeQTE = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_DamageChangeQTE, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_DamageChangeQTE, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006057 RID: 24663
		// (get) Token: 0x06018105 RID: 98565 RVA: 0x002365C4 File Offset: 0x002347C4
		// (set) Token: 0x06018106 RID: 98566 RVA: 0x002365FD File Offset: 0x002347FD
		public FGameplayAttributeData DamageChangePhys
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._DamageChangePhys) == null)
				{
					result = (this._DamageChangePhys = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_DamageChangePhys, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_DamageChangePhys, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006058 RID: 24664
		// (get) Token: 0x06018107 RID: 98567 RVA: 0x00236620 File Offset: 0x00234820
		// (set) Token: 0x06018108 RID: 98568 RVA: 0x00236659 File Offset: 0x00234859
		public FGameplayAttributeData DamageChangeElement1
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._DamageChangeElement1) == null)
				{
					result = (this._DamageChangeElement1 = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_DamageChangeElement1, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_DamageChangeElement1, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006059 RID: 24665
		// (get) Token: 0x06018109 RID: 98569 RVA: 0x0023667C File Offset: 0x0023487C
		// (set) Token: 0x0601810A RID: 98570 RVA: 0x002366B5 File Offset: 0x002348B5
		public FGameplayAttributeData DamageChangeElement2
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._DamageChangeElement2) == null)
				{
					result = (this._DamageChangeElement2 = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_DamageChangeElement2, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_DamageChangeElement2, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700605A RID: 24666
		// (get) Token: 0x0601810B RID: 98571 RVA: 0x002366D8 File Offset: 0x002348D8
		// (set) Token: 0x0601810C RID: 98572 RVA: 0x00236711 File Offset: 0x00234911
		public FGameplayAttributeData DamageChangeElement3
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._DamageChangeElement3) == null)
				{
					result = (this._DamageChangeElement3 = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_DamageChangeElement3, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_DamageChangeElement3, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700605B RID: 24667
		// (get) Token: 0x0601810D RID: 98573 RVA: 0x00236734 File Offset: 0x00234934
		// (set) Token: 0x0601810E RID: 98574 RVA: 0x0023676D File Offset: 0x0023496D
		public FGameplayAttributeData DamageChangeElement4
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._DamageChangeElement4) == null)
				{
					result = (this._DamageChangeElement4 = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_DamageChangeElement4, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_DamageChangeElement4, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700605C RID: 24668
		// (get) Token: 0x0601810F RID: 98575 RVA: 0x00236790 File Offset: 0x00234990
		// (set) Token: 0x06018110 RID: 98576 RVA: 0x002367C9 File Offset: 0x002349C9
		public FGameplayAttributeData DamageChangeElement5
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._DamageChangeElement5) == null)
				{
					result = (this._DamageChangeElement5 = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_DamageChangeElement5, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_DamageChangeElement5, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700605D RID: 24669
		// (get) Token: 0x06018111 RID: 98577 RVA: 0x002367EC File Offset: 0x002349EC
		// (set) Token: 0x06018112 RID: 98578 RVA: 0x00236825 File Offset: 0x00234A25
		public FGameplayAttributeData DamageChangeElement6
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._DamageChangeElement6) == null)
				{
					result = (this._DamageChangeElement6 = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_DamageChangeElement6, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_DamageChangeElement6, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700605E RID: 24670
		// (get) Token: 0x06018113 RID: 98579 RVA: 0x00236848 File Offset: 0x00234A48
		// (set) Token: 0x06018114 RID: 98580 RVA: 0x00236881 File Offset: 0x00234A81
		public FGameplayAttributeData DamageResistancePhys
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._DamageResistancePhys) == null)
				{
					result = (this._DamageResistancePhys = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_DamageResistancePhys, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_DamageResistancePhys, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700605F RID: 24671
		// (get) Token: 0x06018115 RID: 98581 RVA: 0x002368A4 File Offset: 0x00234AA4
		// (set) Token: 0x06018116 RID: 98582 RVA: 0x002368DD File Offset: 0x00234ADD
		public FGameplayAttributeData DamageResistanceElement1
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._DamageResistanceElement1) == null)
				{
					result = (this._DamageResistanceElement1 = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_DamageResistanceElement1, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_DamageResistanceElement1, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006060 RID: 24672
		// (get) Token: 0x06018117 RID: 98583 RVA: 0x00236900 File Offset: 0x00234B00
		// (set) Token: 0x06018118 RID: 98584 RVA: 0x00236939 File Offset: 0x00234B39
		public FGameplayAttributeData DamageResistanceElement2
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._DamageResistanceElement2) == null)
				{
					result = (this._DamageResistanceElement2 = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_DamageResistanceElement2, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_DamageResistanceElement2, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006061 RID: 24673
		// (get) Token: 0x06018119 RID: 98585 RVA: 0x0023695C File Offset: 0x00234B5C
		// (set) Token: 0x0601811A RID: 98586 RVA: 0x00236995 File Offset: 0x00234B95
		public FGameplayAttributeData DamageResistanceElement3
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._DamageResistanceElement3) == null)
				{
					result = (this._DamageResistanceElement3 = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_DamageResistanceElement3, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_DamageResistanceElement3, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006062 RID: 24674
		// (get) Token: 0x0601811B RID: 98587 RVA: 0x002369B8 File Offset: 0x00234BB8
		// (set) Token: 0x0601811C RID: 98588 RVA: 0x002369F1 File Offset: 0x00234BF1
		public FGameplayAttributeData DamageResistanceElement4
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._DamageResistanceElement4) == null)
				{
					result = (this._DamageResistanceElement4 = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_DamageResistanceElement4, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_DamageResistanceElement4, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006063 RID: 24675
		// (get) Token: 0x0601811D RID: 98589 RVA: 0x00236A14 File Offset: 0x00234C14
		// (set) Token: 0x0601811E RID: 98590 RVA: 0x00236A4D File Offset: 0x00234C4D
		public FGameplayAttributeData DamageResistanceElement5
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._DamageResistanceElement5) == null)
				{
					result = (this._DamageResistanceElement5 = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_DamageResistanceElement5, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_DamageResistanceElement5, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006064 RID: 24676
		// (get) Token: 0x0601811F RID: 98591 RVA: 0x00236A70 File Offset: 0x00234C70
		// (set) Token: 0x06018120 RID: 98592 RVA: 0x00236AA9 File Offset: 0x00234CA9
		public FGameplayAttributeData DamageResistanceElement6
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._DamageResistanceElement6) == null)
				{
					result = (this._DamageResistanceElement6 = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_DamageResistanceElement6, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_DamageResistanceElement6, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006065 RID: 24677
		// (get) Token: 0x06018121 RID: 98593 RVA: 0x00236ACC File Offset: 0x00234CCC
		// (set) Token: 0x06018122 RID: 98594 RVA: 0x00236B05 File Offset: 0x00234D05
		public FGameplayAttributeData HealChange
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._HealChange) == null)
				{
					result = (this._HealChange = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_HealChange, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_HealChange, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006066 RID: 24678
		// (get) Token: 0x06018123 RID: 98595 RVA: 0x00236B28 File Offset: 0x00234D28
		// (set) Token: 0x06018124 RID: 98596 RVA: 0x00236B61 File Offset: 0x00234D61
		public FGameplayAttributeData HealedChange
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._HealedChange) == null)
				{
					result = (this._HealedChange = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_HealedChange, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_HealedChange, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006067 RID: 24679
		// (get) Token: 0x06018125 RID: 98597 RVA: 0x00236B84 File Offset: 0x00234D84
		// (set) Token: 0x06018126 RID: 98598 RVA: 0x00236BBD File Offset: 0x00234DBD
		public FGameplayAttributeData DamageReducePhys
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._DamageReducePhys) == null)
				{
					result = (this._DamageReducePhys = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_DamageReducePhys, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_DamageReducePhys, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006068 RID: 24680
		// (get) Token: 0x06018127 RID: 98599 RVA: 0x00236BE0 File Offset: 0x00234DE0
		// (set) Token: 0x06018128 RID: 98600 RVA: 0x00236C19 File Offset: 0x00234E19
		public FGameplayAttributeData DamageReduceElement1
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._DamageReduceElement1) == null)
				{
					result = (this._DamageReduceElement1 = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_DamageReduceElement1, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_DamageReduceElement1, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006069 RID: 24681
		// (get) Token: 0x06018129 RID: 98601 RVA: 0x00236C3C File Offset: 0x00234E3C
		// (set) Token: 0x0601812A RID: 98602 RVA: 0x00236C75 File Offset: 0x00234E75
		public FGameplayAttributeData DamageReduceElement2
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._DamageReduceElement2) == null)
				{
					result = (this._DamageReduceElement2 = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_DamageReduceElement2, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_DamageReduceElement2, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700606A RID: 24682
		// (get) Token: 0x0601812B RID: 98603 RVA: 0x00236C98 File Offset: 0x00234E98
		// (set) Token: 0x0601812C RID: 98604 RVA: 0x00236CD1 File Offset: 0x00234ED1
		public FGameplayAttributeData DamageReduceElement3
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._DamageReduceElement3) == null)
				{
					result = (this._DamageReduceElement3 = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_DamageReduceElement3, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_DamageReduceElement3, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700606B RID: 24683
		// (get) Token: 0x0601812D RID: 98605 RVA: 0x00236CF4 File Offset: 0x00234EF4
		// (set) Token: 0x0601812E RID: 98606 RVA: 0x00236D2D File Offset: 0x00234F2D
		public FGameplayAttributeData DamageReduceElement4
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._DamageReduceElement4) == null)
				{
					result = (this._DamageReduceElement4 = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_DamageReduceElement4, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_DamageReduceElement4, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700606C RID: 24684
		// (get) Token: 0x0601812F RID: 98607 RVA: 0x00236D50 File Offset: 0x00234F50
		// (set) Token: 0x06018130 RID: 98608 RVA: 0x00236D89 File Offset: 0x00234F89
		public FGameplayAttributeData DamageReduceElement5
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._DamageReduceElement5) == null)
				{
					result = (this._DamageReduceElement5 = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_DamageReduceElement5, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_DamageReduceElement5, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700606D RID: 24685
		// (get) Token: 0x06018131 RID: 98609 RVA: 0x00236DAC File Offset: 0x00234FAC
		// (set) Token: 0x06018132 RID: 98610 RVA: 0x00236DE5 File Offset: 0x00234FE5
		public FGameplayAttributeData DamageReduceElement6
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._DamageReduceElement6) == null)
				{
					result = (this._DamageReduceElement6 = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_DamageReduceElement6, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_DamageReduceElement6, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700606E RID: 24686
		// (get) Token: 0x06018133 RID: 98611 RVA: 0x00236E08 File Offset: 0x00235008
		// (set) Token: 0x06018134 RID: 98612 RVA: 0x00236E41 File Offset: 0x00235041
		public FGameplayAttributeData ReactionChange1
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._ReactionChange1) == null)
				{
					result = (this._ReactionChange1 = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_ReactionChange1, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_ReactionChange1, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700606F RID: 24687
		// (get) Token: 0x06018135 RID: 98613 RVA: 0x00236E64 File Offset: 0x00235064
		// (set) Token: 0x06018136 RID: 98614 RVA: 0x00236E9D File Offset: 0x0023509D
		public FGameplayAttributeData ReactionChange2
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._ReactionChange2) == null)
				{
					result = (this._ReactionChange2 = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_ReactionChange2, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_ReactionChange2, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006070 RID: 24688
		// (get) Token: 0x06018137 RID: 98615 RVA: 0x00236EC0 File Offset: 0x002350C0
		// (set) Token: 0x06018138 RID: 98616 RVA: 0x00236EF9 File Offset: 0x002350F9
		public FGameplayAttributeData ReactionChange3
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._ReactionChange3) == null)
				{
					result = (this._ReactionChange3 = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_ReactionChange3, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_ReactionChange3, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006071 RID: 24689
		// (get) Token: 0x06018139 RID: 98617 RVA: 0x00236F1C File Offset: 0x0023511C
		// (set) Token: 0x0601813A RID: 98618 RVA: 0x00236F55 File Offset: 0x00235155
		public FGameplayAttributeData ReactionChange4
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._ReactionChange4) == null)
				{
					result = (this._ReactionChange4 = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_ReactionChange4, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_ReactionChange4, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006072 RID: 24690
		// (get) Token: 0x0601813B RID: 98619 RVA: 0x00236F78 File Offset: 0x00235178
		// (set) Token: 0x0601813C RID: 98620 RVA: 0x00236FB1 File Offset: 0x002351B1
		public FGameplayAttributeData ReactionChange5
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._ReactionChange5) == null)
				{
					result = (this._ReactionChange5 = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_ReactionChange5, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_ReactionChange5, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006073 RID: 24691
		// (get) Token: 0x0601813D RID: 98621 RVA: 0x00236FD4 File Offset: 0x002351D4
		// (set) Token: 0x0601813E RID: 98622 RVA: 0x0023700D File Offset: 0x0023520D
		public FGameplayAttributeData ReactionChange6
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._ReactionChange6) == null)
				{
					result = (this._ReactionChange6 = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_ReactionChange6, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_ReactionChange6, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006074 RID: 24692
		// (get) Token: 0x0601813F RID: 98623 RVA: 0x00237030 File Offset: 0x00235230
		// (set) Token: 0x06018140 RID: 98624 RVA: 0x00237069 File Offset: 0x00235269
		public FGameplayAttributeData ReactionChange7
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._ReactionChange7) == null)
				{
					result = (this._ReactionChange7 = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_ReactionChange7, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_ReactionChange7, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006075 RID: 24693
		// (get) Token: 0x06018141 RID: 98625 RVA: 0x0023708C File Offset: 0x0023528C
		// (set) Token: 0x06018142 RID: 98626 RVA: 0x002370C5 File Offset: 0x002352C5
		public FGameplayAttributeData ReactionChange8
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._ReactionChange8) == null)
				{
					result = (this._ReactionChange8 = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_ReactionChange8, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_ReactionChange8, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006076 RID: 24694
		// (get) Token: 0x06018143 RID: 98627 RVA: 0x002370E8 File Offset: 0x002352E8
		// (set) Token: 0x06018144 RID: 98628 RVA: 0x00237121 File Offset: 0x00235321
		public FGameplayAttributeData ReactionChange9
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._ReactionChange9) == null)
				{
					result = (this._ReactionChange9 = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_ReactionChange9, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_ReactionChange9, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006077 RID: 24695
		// (get) Token: 0x06018145 RID: 98629 RVA: 0x00237144 File Offset: 0x00235344
		// (set) Token: 0x06018146 RID: 98630 RVA: 0x0023717D File Offset: 0x0023537D
		public FGameplayAttributeData ReactionChange10
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._ReactionChange10) == null)
				{
					result = (this._ReactionChange10 = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_ReactionChange10, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_ReactionChange10, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006078 RID: 24696
		// (get) Token: 0x06018147 RID: 98631 RVA: 0x002371A0 File Offset: 0x002353A0
		// (set) Token: 0x06018148 RID: 98632 RVA: 0x002371D9 File Offset: 0x002353D9
		public FGameplayAttributeData ReactionChange11
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._ReactionChange11) == null)
				{
					result = (this._ReactionChange11 = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_ReactionChange11, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_ReactionChange11, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006079 RID: 24697
		// (get) Token: 0x06018149 RID: 98633 RVA: 0x002371FC File Offset: 0x002353FC
		// (set) Token: 0x0601814A RID: 98634 RVA: 0x00237235 File Offset: 0x00235435
		public FGameplayAttributeData ReactionChange12
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._ReactionChange12) == null)
				{
					result = (this._ReactionChange12 = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_ReactionChange12, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_ReactionChange12, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700607A RID: 24698
		// (get) Token: 0x0601814B RID: 98635 RVA: 0x00237258 File Offset: 0x00235458
		// (set) Token: 0x0601814C RID: 98636 RVA: 0x00237291 File Offset: 0x00235491
		public FGameplayAttributeData ReactionChange13
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._ReactionChange13) == null)
				{
					result = (this._ReactionChange13 = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_ReactionChange13, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_ReactionChange13, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700607B RID: 24699
		// (get) Token: 0x0601814D RID: 98637 RVA: 0x002372B4 File Offset: 0x002354B4
		// (set) Token: 0x0601814E RID: 98638 RVA: 0x002372ED File Offset: 0x002354ED
		public FGameplayAttributeData ReactionChange14
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._ReactionChange14) == null)
				{
					result = (this._ReactionChange14 = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_ReactionChange14, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_ReactionChange14, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700607C RID: 24700
		// (get) Token: 0x0601814F RID: 98639 RVA: 0x00237310 File Offset: 0x00235510
		// (set) Token: 0x06018150 RID: 98640 RVA: 0x00237349 File Offset: 0x00235549
		public FGameplayAttributeData ReactionChange15
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._ReactionChange15) == null)
				{
					result = (this._ReactionChange15 = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_ReactionChange15, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_ReactionChange15, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700607D RID: 24701
		// (get) Token: 0x06018151 RID: 98641 RVA: 0x0023736C File Offset: 0x0023556C
		// (set) Token: 0x06018152 RID: 98642 RVA: 0x002373A5 File Offset: 0x002355A5
		public FGameplayAttributeData EnergyMax
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._EnergyMax) == null)
				{
					result = (this._EnergyMax = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_EnergyMax, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_EnergyMax, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700607E RID: 24702
		// (get) Token: 0x06018153 RID: 98643 RVA: 0x002373C8 File Offset: 0x002355C8
		// (set) Token: 0x06018154 RID: 98644 RVA: 0x00237401 File Offset: 0x00235601
		public FGameplayAttributeData Energy
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._Energy) == null)
				{
					result = (this._Energy = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_Energy, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_Energy, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700607F RID: 24703
		// (get) Token: 0x06018155 RID: 98645 RVA: 0x00237424 File Offset: 0x00235624
		// (set) Token: 0x06018156 RID: 98646 RVA: 0x0023745D File Offset: 0x0023565D
		public FGameplayAttributeData SpecialEnergy1Max
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._SpecialEnergy1Max) == null)
				{
					result = (this._SpecialEnergy1Max = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_SpecialEnergy1Max, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_SpecialEnergy1Max, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006080 RID: 24704
		// (get) Token: 0x06018157 RID: 98647 RVA: 0x00237480 File Offset: 0x00235680
		// (set) Token: 0x06018158 RID: 98648 RVA: 0x002374B9 File Offset: 0x002356B9
		public FGameplayAttributeData SpecialEnergy1
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._SpecialEnergy1) == null)
				{
					result = (this._SpecialEnergy1 = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_SpecialEnergy1, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_SpecialEnergy1, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006081 RID: 24705
		// (get) Token: 0x06018159 RID: 98649 RVA: 0x002374DC File Offset: 0x002356DC
		// (set) Token: 0x0601815A RID: 98650 RVA: 0x00237515 File Offset: 0x00235715
		public FGameplayAttributeData SpecialEnergy2Max
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._SpecialEnergy2Max) == null)
				{
					result = (this._SpecialEnergy2Max = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_SpecialEnergy2Max, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_SpecialEnergy2Max, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006082 RID: 24706
		// (get) Token: 0x0601815B RID: 98651 RVA: 0x00237538 File Offset: 0x00235738
		// (set) Token: 0x0601815C RID: 98652 RVA: 0x00237571 File Offset: 0x00235771
		public FGameplayAttributeData SpecialEnergy2
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._SpecialEnergy2) == null)
				{
					result = (this._SpecialEnergy2 = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_SpecialEnergy2, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_SpecialEnergy2, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006083 RID: 24707
		// (get) Token: 0x0601815D RID: 98653 RVA: 0x00237594 File Offset: 0x00235794
		// (set) Token: 0x0601815E RID: 98654 RVA: 0x002375CD File Offset: 0x002357CD
		public FGameplayAttributeData SpecialEnergy3Max
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._SpecialEnergy3Max) == null)
				{
					result = (this._SpecialEnergy3Max = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_SpecialEnergy3Max, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_SpecialEnergy3Max, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006084 RID: 24708
		// (get) Token: 0x0601815F RID: 98655 RVA: 0x002375F0 File Offset: 0x002357F0
		// (set) Token: 0x06018160 RID: 98656 RVA: 0x00237629 File Offset: 0x00235829
		public FGameplayAttributeData SpecialEnergy3
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._SpecialEnergy3) == null)
				{
					result = (this._SpecialEnergy3 = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_SpecialEnergy3, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_SpecialEnergy3, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006085 RID: 24709
		// (get) Token: 0x06018161 RID: 98657 RVA: 0x0023764C File Offset: 0x0023584C
		// (set) Token: 0x06018162 RID: 98658 RVA: 0x00237685 File Offset: 0x00235885
		public FGameplayAttributeData SpecialEnergy4Max
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._SpecialEnergy4Max) == null)
				{
					result = (this._SpecialEnergy4Max = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_SpecialEnergy4Max, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_SpecialEnergy4Max, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006086 RID: 24710
		// (get) Token: 0x06018163 RID: 98659 RVA: 0x002376A8 File Offset: 0x002358A8
		// (set) Token: 0x06018164 RID: 98660 RVA: 0x002376E1 File Offset: 0x002358E1
		public FGameplayAttributeData SpecialEnergy4
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._SpecialEnergy4) == null)
				{
					result = (this._SpecialEnergy4 = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_SpecialEnergy4, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_SpecialEnergy4, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006087 RID: 24711
		// (get) Token: 0x06018165 RID: 98661 RVA: 0x00237704 File Offset: 0x00235904
		// (set) Token: 0x06018166 RID: 98662 RVA: 0x0023773D File Offset: 0x0023593D
		public FGameplayAttributeData StrengthMax
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._StrengthMax) == null)
				{
					result = (this._StrengthMax = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_StrengthMax, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_StrengthMax, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006088 RID: 24712
		// (get) Token: 0x06018167 RID: 98663 RVA: 0x00237760 File Offset: 0x00235960
		// (set) Token: 0x06018168 RID: 98664 RVA: 0x00237799 File Offset: 0x00235999
		public FGameplayAttributeData Strength
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._Strength) == null)
				{
					result = (this._Strength = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_Strength, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_Strength, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006089 RID: 24713
		// (get) Token: 0x06018169 RID: 98665 RVA: 0x002377BC File Offset: 0x002359BC
		// (set) Token: 0x0601816A RID: 98666 RVA: 0x002377F5 File Offset: 0x002359F5
		public FGameplayAttributeData StrengthRecover
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._StrengthRecover) == null)
				{
					result = (this._StrengthRecover = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_StrengthRecover, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_StrengthRecover, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700608A RID: 24714
		// (get) Token: 0x0601816B RID: 98667 RVA: 0x00237818 File Offset: 0x00235A18
		// (set) Token: 0x0601816C RID: 98668 RVA: 0x00237851 File Offset: 0x00235A51
		public FGameplayAttributeData StrengthPunishTime
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._StrengthPunishTime) == null)
				{
					result = (this._StrengthPunishTime = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_StrengthPunishTime, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_StrengthPunishTime, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700608B RID: 24715
		// (get) Token: 0x0601816D RID: 98669 RVA: 0x00237874 File Offset: 0x00235A74
		// (set) Token: 0x0601816E RID: 98670 RVA: 0x002378AD File Offset: 0x00235AAD
		public FGameplayAttributeData StrengthRun
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._StrengthRun) == null)
				{
					result = (this._StrengthRun = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_StrengthRun, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_StrengthRun, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700608C RID: 24716
		// (get) Token: 0x0601816F RID: 98671 RVA: 0x002378D0 File Offset: 0x00235AD0
		// (set) Token: 0x06018170 RID: 98672 RVA: 0x00237909 File Offset: 0x00235B09
		public FGameplayAttributeData StrengthSwim
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._StrengthSwim) == null)
				{
					result = (this._StrengthSwim = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_StrengthSwim, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_StrengthSwim, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700608D RID: 24717
		// (get) Token: 0x06018171 RID: 98673 RVA: 0x0023792C File Offset: 0x00235B2C
		// (set) Token: 0x06018172 RID: 98674 RVA: 0x00237965 File Offset: 0x00235B65
		public FGameplayAttributeData StrengthFastSwim
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._StrengthFastSwim) == null)
				{
					result = (this._StrengthFastSwim = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_StrengthFastSwim, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_StrengthFastSwim, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700608E RID: 24718
		// (get) Token: 0x06018173 RID: 98675 RVA: 0x00237988 File Offset: 0x00235B88
		// (set) Token: 0x06018174 RID: 98676 RVA: 0x002379C1 File Offset: 0x00235BC1
		public FGameplayAttributeData StrengthClimb
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._StrengthClimb) == null)
				{
					result = (this._StrengthClimb = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_StrengthClimb, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_StrengthClimb, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700608F RID: 24719
		// (get) Token: 0x06018175 RID: 98677 RVA: 0x002379E4 File Offset: 0x00235BE4
		// (set) Token: 0x06018176 RID: 98678 RVA: 0x00237A1D File Offset: 0x00235C1D
		public FGameplayAttributeData StrengthFastClimb
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._StrengthFastClimb) == null)
				{
					result = (this._StrengthFastClimb = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_StrengthFastClimb, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_StrengthFastClimb, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006090 RID: 24720
		// (get) Token: 0x06018177 RID: 98679 RVA: 0x00237A40 File Offset: 0x00235C40
		// (set) Token: 0x06018178 RID: 98680 RVA: 0x00237A79 File Offset: 0x00235C79
		public FGameplayAttributeData HardnessMax
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._HardnessMax) == null)
				{
					result = (this._HardnessMax = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_HardnessMax, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_HardnessMax, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006091 RID: 24721
		// (get) Token: 0x06018179 RID: 98681 RVA: 0x00237A9C File Offset: 0x00235C9C
		// (set) Token: 0x0601817A RID: 98682 RVA: 0x00237AD5 File Offset: 0x00235CD5
		public FGameplayAttributeData Hardness
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._Hardness) == null)
				{
					result = (this._Hardness = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_Hardness, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_Hardness, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006092 RID: 24722
		// (get) Token: 0x0601817B RID: 98683 RVA: 0x00237AF8 File Offset: 0x00235CF8
		// (set) Token: 0x0601817C RID: 98684 RVA: 0x00237B31 File Offset: 0x00235D31
		public FGameplayAttributeData HardnessRecover
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._HardnessRecover) == null)
				{
					result = (this._HardnessRecover = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_HardnessRecover, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_HardnessRecover, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006093 RID: 24723
		// (get) Token: 0x0601817D RID: 98685 RVA: 0x00237B54 File Offset: 0x00235D54
		// (set) Token: 0x0601817E RID: 98686 RVA: 0x00237B8D File Offset: 0x00235D8D
		public FGameplayAttributeData HardnessPunishTime
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._HardnessPunishTime) == null)
				{
					result = (this._HardnessPunishTime = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_HardnessPunishTime, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_HardnessPunishTime, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006094 RID: 24724
		// (get) Token: 0x0601817F RID: 98687 RVA: 0x00237BB0 File Offset: 0x00235DB0
		// (set) Token: 0x06018180 RID: 98688 RVA: 0x00237BE9 File Offset: 0x00235DE9
		public FGameplayAttributeData HardnessChange
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._HardnessChange) == null)
				{
					result = (this._HardnessChange = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_HardnessChange, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_HardnessChange, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006095 RID: 24725
		// (get) Token: 0x06018181 RID: 98689 RVA: 0x00237C0C File Offset: 0x00235E0C
		// (set) Token: 0x06018182 RID: 98690 RVA: 0x00237C45 File Offset: 0x00235E45
		public FGameplayAttributeData HardnessReduce
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._HardnessReduce) == null)
				{
					result = (this._HardnessReduce = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_HardnessReduce, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_HardnessReduce, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006096 RID: 24726
		// (get) Token: 0x06018183 RID: 98691 RVA: 0x00237C68 File Offset: 0x00235E68
		// (set) Token: 0x06018184 RID: 98692 RVA: 0x00237CA1 File Offset: 0x00235EA1
		public FGameplayAttributeData ToughMax
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._ToughMax) == null)
				{
					result = (this._ToughMax = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_ToughMax, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_ToughMax, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006097 RID: 24727
		// (get) Token: 0x06018185 RID: 98693 RVA: 0x00237CC4 File Offset: 0x00235EC4
		// (set) Token: 0x06018186 RID: 98694 RVA: 0x00237CFD File Offset: 0x00235EFD
		public FGameplayAttributeData Tough
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._Tough) == null)
				{
					result = (this._Tough = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_Tough, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_Tough, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006098 RID: 24728
		// (get) Token: 0x06018187 RID: 98695 RVA: 0x00237D20 File Offset: 0x00235F20
		// (set) Token: 0x06018188 RID: 98696 RVA: 0x00237D59 File Offset: 0x00235F59
		public FGameplayAttributeData ToughRecover
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._ToughRecover) == null)
				{
					result = (this._ToughRecover = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_ToughRecover, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_ToughRecover, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006099 RID: 24729
		// (get) Token: 0x06018189 RID: 98697 RVA: 0x00237D7C File Offset: 0x00235F7C
		// (set) Token: 0x0601818A RID: 98698 RVA: 0x00237DB5 File Offset: 0x00235FB5
		public FGameplayAttributeData ToughChange
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._ToughChange) == null)
				{
					result = (this._ToughChange = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_ToughChange, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_ToughChange, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700609A RID: 24730
		// (get) Token: 0x0601818B RID: 98699 RVA: 0x00237DD8 File Offset: 0x00235FD8
		// (set) Token: 0x0601818C RID: 98700 RVA: 0x00237E11 File Offset: 0x00236011
		public FGameplayAttributeData ToughReduce
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._ToughReduce) == null)
				{
					result = (this._ToughReduce = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_ToughReduce, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_ToughReduce, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700609B RID: 24731
		// (get) Token: 0x0601818D RID: 98701 RVA: 0x00237E34 File Offset: 0x00236034
		// (set) Token: 0x0601818E RID: 98702 RVA: 0x00237E6D File Offset: 0x0023606D
		public FGameplayAttributeData ElementPower1
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._ElementPower1) == null)
				{
					result = (this._ElementPower1 = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_ElementPower1, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_ElementPower1, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700609C RID: 24732
		// (get) Token: 0x0601818F RID: 98703 RVA: 0x00237E90 File Offset: 0x00236090
		// (set) Token: 0x06018190 RID: 98704 RVA: 0x00237EC9 File Offset: 0x002360C9
		public FGameplayAttributeData ElementPower2
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._ElementPower2) == null)
				{
					result = (this._ElementPower2 = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_ElementPower2, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_ElementPower2, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700609D RID: 24733
		// (get) Token: 0x06018191 RID: 98705 RVA: 0x00237EEC File Offset: 0x002360EC
		// (set) Token: 0x06018192 RID: 98706 RVA: 0x00237F25 File Offset: 0x00236125
		public FGameplayAttributeData ElementPower3
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._ElementPower3) == null)
				{
					result = (this._ElementPower3 = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_ElementPower3, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_ElementPower3, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700609E RID: 24734
		// (get) Token: 0x06018193 RID: 98707 RVA: 0x00237F48 File Offset: 0x00236148
		// (set) Token: 0x06018194 RID: 98708 RVA: 0x00237F81 File Offset: 0x00236181
		public FGameplayAttributeData ElementPower4
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._ElementPower4) == null)
				{
					result = (this._ElementPower4 = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_ElementPower4, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_ElementPower4, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700609F RID: 24735
		// (get) Token: 0x06018195 RID: 98709 RVA: 0x00237FA4 File Offset: 0x002361A4
		// (set) Token: 0x06018196 RID: 98710 RVA: 0x00237FDD File Offset: 0x002361DD
		public FGameplayAttributeData ElementPower5
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._ElementPower5) == null)
				{
					result = (this._ElementPower5 = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_ElementPower5, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_ElementPower5, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170060A0 RID: 24736
		// (get) Token: 0x06018197 RID: 98711 RVA: 0x00238000 File Offset: 0x00236200
		// (set) Token: 0x06018198 RID: 98712 RVA: 0x00238039 File Offset: 0x00236239
		public FGameplayAttributeData ElementPower6
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._ElementPower6) == null)
				{
					result = (this._ElementPower6 = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_ElementPower6, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_ElementPower6, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170060A1 RID: 24737
		// (get) Token: 0x06018199 RID: 98713 RVA: 0x0023805C File Offset: 0x0023625C
		// (set) Token: 0x0601819A RID: 98714 RVA: 0x00238095 File Offset: 0x00236295
		public FGameplayAttributeData SpecialDamageChange
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._SpecialDamageChange) == null)
				{
					result = (this._SpecialDamageChange = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_SpecialDamageChange, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_SpecialDamageChange, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170060A2 RID: 24738
		// (get) Token: 0x0601819B RID: 98715 RVA: 0x002380B8 File Offset: 0x002362B8
		// (set) Token: 0x0601819C RID: 98716 RVA: 0x002380F1 File Offset: 0x002362F1
		public FGameplayAttributeData StrengthFastClimbCost
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._StrengthFastClimbCost) == null)
				{
					result = (this._StrengthFastClimbCost = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_StrengthFastClimbCost, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_StrengthFastClimbCost, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170060A3 RID: 24739
		// (get) Token: 0x0601819D RID: 98717 RVA: 0x00238114 File Offset: 0x00236314
		// (set) Token: 0x0601819E RID: 98718 RVA: 0x0023814D File Offset: 0x0023634D
		public FGameplayAttributeData ElementPropertyType
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._ElementPropertyType) == null)
				{
					result = (this._ElementPropertyType = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_ElementPropertyType, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_ElementPropertyType, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170060A4 RID: 24740
		// (get) Token: 0x0601819F RID: 98719 RVA: 0x00238170 File Offset: 0x00236370
		// (set) Token: 0x060181A0 RID: 98720 RVA: 0x002381A9 File Offset: 0x002363A9
		public FGameplayAttributeData WeakTime
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._WeakTime) == null)
				{
					result = (this._WeakTime = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_WeakTime, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_WeakTime, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170060A5 RID: 24741
		// (get) Token: 0x060181A1 RID: 98721 RVA: 0x002381CC File Offset: 0x002363CC
		// (set) Token: 0x060181A2 RID: 98722 RVA: 0x00238205 File Offset: 0x00236405
		public FGameplayAttributeData IgnoreDefRate
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._IgnoreDefRate) == null)
				{
					result = (this._IgnoreDefRate = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_IgnoreDefRate, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_IgnoreDefRate, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170060A6 RID: 24742
		// (get) Token: 0x060181A3 RID: 98723 RVA: 0x00238228 File Offset: 0x00236428
		// (set) Token: 0x060181A4 RID: 98724 RVA: 0x00238261 File Offset: 0x00236461
		public FGameplayAttributeData IgnoreDamageResistancePhys
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._IgnoreDamageResistancePhys) == null)
				{
					result = (this._IgnoreDamageResistancePhys = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_IgnoreDamageResistancePhys, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_IgnoreDamageResistancePhys, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170060A7 RID: 24743
		// (get) Token: 0x060181A5 RID: 98725 RVA: 0x00238284 File Offset: 0x00236484
		// (set) Token: 0x060181A6 RID: 98726 RVA: 0x002382BD File Offset: 0x002364BD
		public FGameplayAttributeData IgnoreDamageResistanceElement1
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._IgnoreDamageResistanceElement1) == null)
				{
					result = (this._IgnoreDamageResistanceElement1 = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_IgnoreDamageResistanceElement1, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_IgnoreDamageResistanceElement1, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170060A8 RID: 24744
		// (get) Token: 0x060181A7 RID: 98727 RVA: 0x002382E0 File Offset: 0x002364E0
		// (set) Token: 0x060181A8 RID: 98728 RVA: 0x00238319 File Offset: 0x00236519
		public FGameplayAttributeData IgnoreDamageResistanceElement2
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._IgnoreDamageResistanceElement2) == null)
				{
					result = (this._IgnoreDamageResistanceElement2 = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_IgnoreDamageResistanceElement2, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_IgnoreDamageResistanceElement2, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170060A9 RID: 24745
		// (get) Token: 0x060181A9 RID: 98729 RVA: 0x0023833C File Offset: 0x0023653C
		// (set) Token: 0x060181AA RID: 98730 RVA: 0x00238375 File Offset: 0x00236575
		public FGameplayAttributeData IgnoreDamageResistanceElement3
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._IgnoreDamageResistanceElement3) == null)
				{
					result = (this._IgnoreDamageResistanceElement3 = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_IgnoreDamageResistanceElement3, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_IgnoreDamageResistanceElement3, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170060AA RID: 24746
		// (get) Token: 0x060181AB RID: 98731 RVA: 0x00238398 File Offset: 0x00236598
		// (set) Token: 0x060181AC RID: 98732 RVA: 0x002383D1 File Offset: 0x002365D1
		public FGameplayAttributeData IgnoreDamageResistanceElement4
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._IgnoreDamageResistanceElement4) == null)
				{
					result = (this._IgnoreDamageResistanceElement4 = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_IgnoreDamageResistanceElement4, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_IgnoreDamageResistanceElement4, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170060AB RID: 24747
		// (get) Token: 0x060181AD RID: 98733 RVA: 0x002383F4 File Offset: 0x002365F4
		// (set) Token: 0x060181AE RID: 98734 RVA: 0x0023842D File Offset: 0x0023662D
		public FGameplayAttributeData IgnoreDamageResistanceElement5
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._IgnoreDamageResistanceElement5) == null)
				{
					result = (this._IgnoreDamageResistanceElement5 = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_IgnoreDamageResistanceElement5, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_IgnoreDamageResistanceElement5, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170060AC RID: 24748
		// (get) Token: 0x060181AF RID: 98735 RVA: 0x00238450 File Offset: 0x00236650
		// (set) Token: 0x060181B0 RID: 98736 RVA: 0x00238489 File Offset: 0x00236689
		public FGameplayAttributeData IgnoreDamageResistanceElement6
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._IgnoreDamageResistanceElement6) == null)
				{
					result = (this._IgnoreDamageResistanceElement6 = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_IgnoreDamageResistanceElement6, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_IgnoreDamageResistanceElement6, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170060AD RID: 24749
		// (get) Token: 0x060181B1 RID: 98737 RVA: 0x002384AC File Offset: 0x002366AC
		// (set) Token: 0x060181B2 RID: 98738 RVA: 0x002384E5 File Offset: 0x002366E5
		public FGameplayAttributeData SkillToughRatio
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._SkillToughRatio) == null)
				{
					result = (this._SkillToughRatio = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_SkillToughRatio, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_SkillToughRatio, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170060AE RID: 24750
		// (get) Token: 0x060181B3 RID: 98739 RVA: 0x00238508 File Offset: 0x00236708
		// (set) Token: 0x060181B4 RID: 98740 RVA: 0x00238541 File Offset: 0x00236741
		public FGameplayAttributeData StrengthClimbJump
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._StrengthClimbJump) == null)
				{
					result = (this._StrengthClimbJump = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_StrengthClimbJump, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_StrengthClimbJump, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170060AF RID: 24751
		// (get) Token: 0x060181B5 RID: 98741 RVA: 0x00238564 File Offset: 0x00236764
		// (set) Token: 0x060181B6 RID: 98742 RVA: 0x0023859D File Offset: 0x0023679D
		public FGameplayAttributeData StrengthGliding
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._StrengthGliding) == null)
				{
					result = (this._StrengthGliding = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_StrengthGliding, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_StrengthGliding, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170060B0 RID: 24752
		// (get) Token: 0x060181B7 RID: 98743 RVA: 0x002385C0 File Offset: 0x002367C0
		// (set) Token: 0x060181B8 RID: 98744 RVA: 0x002385F9 File Offset: 0x002367F9
		public FGameplayAttributeData Mass
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._Mass) == null)
				{
					result = (this._Mass = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_Mass, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_Mass, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170060B1 RID: 24753
		// (get) Token: 0x060181B9 RID: 98745 RVA: 0x0023861C File Offset: 0x0023681C
		// (set) Token: 0x060181BA RID: 98746 RVA: 0x00238655 File Offset: 0x00236855
		public FGameplayAttributeData BrakingFrictionFactor
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._BrakingFrictionFactor) == null)
				{
					result = (this._BrakingFrictionFactor = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_BrakingFrictionFactor, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_BrakingFrictionFactor, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170060B2 RID: 24754
		// (get) Token: 0x060181BB RID: 98747 RVA: 0x00238678 File Offset: 0x00236878
		// (set) Token: 0x060181BC RID: 98748 RVA: 0x002386B1 File Offset: 0x002368B1
		public FGameplayAttributeData GravityScale
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._GravityScale) == null)
				{
					result = (this._GravityScale = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_GravityScale, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_GravityScale, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170060B3 RID: 24755
		// (get) Token: 0x060181BD RID: 98749 RVA: 0x002386D4 File Offset: 0x002368D4
		// (set) Token: 0x060181BE RID: 98750 RVA: 0x0023870D File Offset: 0x0023690D
		public FGameplayAttributeData SpeedRatio
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._SpeedRatio) == null)
				{
					result = (this._SpeedRatio = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_SpeedRatio, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_SpeedRatio, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170060B4 RID: 24756
		// (get) Token: 0x060181BF RID: 98751 RVA: 0x00238730 File Offset: 0x00236930
		// (set) Token: 0x060181C0 RID: 98752 RVA: 0x00238769 File Offset: 0x00236969
		public FGameplayAttributeData DamageChangePhantom
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._DamageChangePhantom) == null)
				{
					result = (this._DamageChangePhantom = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_DamageChangePhantom, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_DamageChangePhantom, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170060B5 RID: 24757
		// (get) Token: 0x060181C1 RID: 98753 RVA: 0x0023878C File Offset: 0x0023698C
		// (set) Token: 0x060181C2 RID: 98754 RVA: 0x002387C5 File Offset: 0x002369C5
		public FGameplayAttributeData AutoAttackSpeed
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._AutoAttackSpeed) == null)
				{
					result = (this._AutoAttackSpeed = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_AutoAttackSpeed, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_AutoAttackSpeed, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170060B6 RID: 24758
		// (get) Token: 0x060181C3 RID: 98755 RVA: 0x002387E8 File Offset: 0x002369E8
		// (set) Token: 0x060181C4 RID: 98756 RVA: 0x00238821 File Offset: 0x00236A21
		public FGameplayAttributeData CastAttackSpeed
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._CastAttackSpeed) == null)
				{
					result = (this._CastAttackSpeed = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_CastAttackSpeed, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_CastAttackSpeed, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170060B7 RID: 24759
		// (get) Token: 0x060181C5 RID: 98757 RVA: 0x00238844 File Offset: 0x00236A44
		// (set) Token: 0x060181C6 RID: 98758 RVA: 0x0023887D File Offset: 0x00236A7D
		public FGameplayAttributeData StatusBuildUp1Max
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._StatusBuildUp1Max) == null)
				{
					result = (this._StatusBuildUp1Max = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_StatusBuildUp1Max, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_StatusBuildUp1Max, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170060B8 RID: 24760
		// (get) Token: 0x060181C7 RID: 98759 RVA: 0x002388A0 File Offset: 0x00236AA0
		// (set) Token: 0x060181C8 RID: 98760 RVA: 0x002388D9 File Offset: 0x00236AD9
		public FGameplayAttributeData StatusBuildUp1
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._StatusBuildUp1) == null)
				{
					result = (this._StatusBuildUp1 = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_StatusBuildUp1, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_StatusBuildUp1, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170060B9 RID: 24761
		// (get) Token: 0x060181C9 RID: 98761 RVA: 0x002388FC File Offset: 0x00236AFC
		// (set) Token: 0x060181CA RID: 98762 RVA: 0x00238935 File Offset: 0x00236B35
		public FGameplayAttributeData StatusBuildUp2Max
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._StatusBuildUp2Max) == null)
				{
					result = (this._StatusBuildUp2Max = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_StatusBuildUp2Max, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_StatusBuildUp2Max, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170060BA RID: 24762
		// (get) Token: 0x060181CB RID: 98763 RVA: 0x00238958 File Offset: 0x00236B58
		// (set) Token: 0x060181CC RID: 98764 RVA: 0x00238991 File Offset: 0x00236B91
		public FGameplayAttributeData StatusBuildUp2
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._StatusBuildUp2) == null)
				{
					result = (this._StatusBuildUp2 = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_StatusBuildUp2, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_StatusBuildUp2, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170060BB RID: 24763
		// (get) Token: 0x060181CD RID: 98765 RVA: 0x002389B4 File Offset: 0x00236BB4
		// (set) Token: 0x060181CE RID: 98766 RVA: 0x002389ED File Offset: 0x00236BED
		public FGameplayAttributeData StatusBuildUp3Max
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._StatusBuildUp3Max) == null)
				{
					result = (this._StatusBuildUp3Max = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_StatusBuildUp3Max, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_StatusBuildUp3Max, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170060BC RID: 24764
		// (get) Token: 0x060181CF RID: 98767 RVA: 0x00238A10 File Offset: 0x00236C10
		// (set) Token: 0x060181D0 RID: 98768 RVA: 0x00238A49 File Offset: 0x00236C49
		public FGameplayAttributeData StatusBuildUp3
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._StatusBuildUp3) == null)
				{
					result = (this._StatusBuildUp3 = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_StatusBuildUp3, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_StatusBuildUp3, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170060BD RID: 24765
		// (get) Token: 0x060181D1 RID: 98769 RVA: 0x00238A6C File Offset: 0x00236C6C
		// (set) Token: 0x060181D2 RID: 98770 RVA: 0x00238AA5 File Offset: 0x00236CA5
		public FGameplayAttributeData StatusBuildUp4Max
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._StatusBuildUp4Max) == null)
				{
					result = (this._StatusBuildUp4Max = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_StatusBuildUp4Max, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_StatusBuildUp4Max, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170060BE RID: 24766
		// (get) Token: 0x060181D3 RID: 98771 RVA: 0x00238AC8 File Offset: 0x00236CC8
		// (set) Token: 0x060181D4 RID: 98772 RVA: 0x00238B01 File Offset: 0x00236D01
		public FGameplayAttributeData StatusBuildUp4
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._StatusBuildUp4) == null)
				{
					result = (this._StatusBuildUp4 = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_StatusBuildUp4, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_StatusBuildUp4, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170060BF RID: 24767
		// (get) Token: 0x060181D5 RID: 98773 RVA: 0x00238B24 File Offset: 0x00236D24
		// (set) Token: 0x060181D6 RID: 98774 RVA: 0x00238B5D File Offset: 0x00236D5D
		public FGameplayAttributeData StatusBuildUp5Max
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._StatusBuildUp5Max) == null)
				{
					result = (this._StatusBuildUp5Max = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_StatusBuildUp5Max, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_StatusBuildUp5Max, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170060C0 RID: 24768
		// (get) Token: 0x060181D7 RID: 98775 RVA: 0x00238B80 File Offset: 0x00236D80
		// (set) Token: 0x060181D8 RID: 98776 RVA: 0x00238BB9 File Offset: 0x00236DB9
		public FGameplayAttributeData StatusBuildUp5
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._StatusBuildUp5) == null)
				{
					result = (this._StatusBuildUp5 = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_StatusBuildUp5, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_StatusBuildUp5, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170060C1 RID: 24769
		// (get) Token: 0x060181D9 RID: 98777 RVA: 0x00238BDC File Offset: 0x00236DDC
		// (set) Token: 0x060181DA RID: 98778 RVA: 0x00238C15 File Offset: 0x00236E15
		public FGameplayAttributeData RageMax
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._RageMax) == null)
				{
					result = (this._RageMax = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_RageMax, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_RageMax, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170060C2 RID: 24770
		// (get) Token: 0x060181DB RID: 98779 RVA: 0x00238C38 File Offset: 0x00236E38
		// (set) Token: 0x060181DC RID: 98780 RVA: 0x00238C71 File Offset: 0x00236E71
		public FGameplayAttributeData Rage
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._Rage) == null)
				{
					result = (this._Rage = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_Rage, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_Rage, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170060C3 RID: 24771
		// (get) Token: 0x060181DD RID: 98781 RVA: 0x00238C94 File Offset: 0x00236E94
		// (set) Token: 0x060181DE RID: 98782 RVA: 0x00238CCD File Offset: 0x00236ECD
		public FGameplayAttributeData RageRecover
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._RageRecover) == null)
				{
					result = (this._RageRecover = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_RageRecover, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_RageRecover, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170060C4 RID: 24772
		// (get) Token: 0x060181DF RID: 98783 RVA: 0x00238CF0 File Offset: 0x00236EF0
		// (set) Token: 0x060181E0 RID: 98784 RVA: 0x00238D29 File Offset: 0x00236F29
		public FGameplayAttributeData RagePunishTime
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._RagePunishTime) == null)
				{
					result = (this._RagePunishTime = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_RagePunishTime, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_RagePunishTime, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170060C5 RID: 24773
		// (get) Token: 0x060181E1 RID: 98785 RVA: 0x00238D4C File Offset: 0x00236F4C
		// (set) Token: 0x060181E2 RID: 98786 RVA: 0x00238D85 File Offset: 0x00236F85
		public FGameplayAttributeData RageChange
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._RageChange) == null)
				{
					result = (this._RageChange = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_RageChange, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_RageChange, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170060C6 RID: 24774
		// (get) Token: 0x060181E3 RID: 98787 RVA: 0x00238DA8 File Offset: 0x00236FA8
		// (set) Token: 0x060181E4 RID: 98788 RVA: 0x00238DE1 File Offset: 0x00236FE1
		public FGameplayAttributeData RageReduce
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._RageReduce) == null)
				{
					result = (this._RageReduce = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_RageReduce, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_RageReduce, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170060C7 RID: 24775
		// (get) Token: 0x060181E5 RID: 98789 RVA: 0x00238E04 File Offset: 0x00237004
		// (set) Token: 0x060181E6 RID: 98790 RVA: 0x00238E3D File Offset: 0x0023703D
		public FGameplayAttributeData ToughRecoverDelayTime
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._ToughRecoverDelayTime) == null)
				{
					result = (this._ToughRecoverDelayTime = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_ToughRecoverDelayTime, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_ToughRecoverDelayTime, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170060C8 RID: 24776
		// (get) Token: 0x060181E7 RID: 98791 RVA: 0x00238E60 File Offset: 0x00237060
		// (set) Token: 0x060181E8 RID: 98792 RVA: 0x00238E99 File Offset: 0x00237099
		public FGameplayAttributeData Jump
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._Jump) == null)
				{
					result = (this._Jump = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_Jump, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_Jump, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170060C9 RID: 24777
		// (get) Token: 0x060181E9 RID: 98793 RVA: 0x00238EBC File Offset: 0x002370BC
		// (set) Token: 0x060181EA RID: 98794 RVA: 0x00238EF5 File Offset: 0x002370F5
		public FGameplayAttributeData ParalysisTimeMax
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._ParalysisTimeMax) == null)
				{
					result = (this._ParalysisTimeMax = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_ParalysisTimeMax, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_ParalysisTimeMax, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170060CA RID: 24778
		// (get) Token: 0x060181EB RID: 98795 RVA: 0x00238F18 File Offset: 0x00237118
		// (set) Token: 0x060181EC RID: 98796 RVA: 0x00238F51 File Offset: 0x00237151
		public FGameplayAttributeData ParalysisTime
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._ParalysisTime) == null)
				{
					result = (this._ParalysisTime = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_ParalysisTime, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_ParalysisTime, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170060CB RID: 24779
		// (get) Token: 0x060181ED RID: 98797 RVA: 0x00238F74 File Offset: 0x00237174
		// (set) Token: 0x060181EE RID: 98798 RVA: 0x00238FAD File Offset: 0x002371AD
		public FGameplayAttributeData ParalysisTimeRecover
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._ParalysisTimeRecover) == null)
				{
					result = (this._ParalysisTimeRecover = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_ParalysisTimeRecover, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_ParalysisTimeRecover, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170060CC RID: 24780
		// (get) Token: 0x060181EF RID: 98799 RVA: 0x00238FD0 File Offset: 0x002371D0
		// (set) Token: 0x060181F0 RID: 98800 RVA: 0x00239009 File Offset: 0x00237209
		public FGameplayAttributeData WeaknessBuildUp
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._WeaknessBuildUp) == null)
				{
					result = (this._WeaknessBuildUp = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_WeaknessBuildUp, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_WeaknessBuildUp, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170060CD RID: 24781
		// (get) Token: 0x060181F1 RID: 98801 RVA: 0x0023902C File Offset: 0x0023722C
		// (set) Token: 0x060181F2 RID: 98802 RVA: 0x00239065 File Offset: 0x00237265
		public FGameplayAttributeData WeaknessBuildUpMax
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._WeaknessBuildUpMax) == null)
				{
					result = (this._WeaknessBuildUpMax = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_WeaknessBuildUpMax, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_WeaknessBuildUpMax, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170060CE RID: 24782
		// (get) Token: 0x060181F3 RID: 98803 RVA: 0x00239088 File Offset: 0x00237288
		// (set) Token: 0x060181F4 RID: 98804 RVA: 0x002390C1 File Offset: 0x002372C1
		public FGameplayAttributeData WeaknessTotalBonus
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._WeaknessTotalBonus) == null)
				{
					result = (this._WeaknessTotalBonus = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_WeaknessTotalBonus, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_WeaknessTotalBonus, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170060CF RID: 24783
		// (get) Token: 0x060181F5 RID: 98805 RVA: 0x002390E4 File Offset: 0x002372E4
		// (set) Token: 0x060181F6 RID: 98806 RVA: 0x0023911D File Offset: 0x0023731D
		public FGameplayAttributeData WeaknessTotalResist
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttributeData result;
				if ((result = this._WeaknessTotalResist) == null)
				{
					result = (this._WeaknessTotalResist = new FGameplayAttributeData(base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_WeaknessTotalResist, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttributeData.StaticStruct(), base.NativePtr + (IntPtr)UBaseAttributeSet.__PropertyOffset_WeaknessTotalResist, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060181F7 RID: 98807
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetReduceMax(float InReduceMax);

		// Token: 0x060181F8 RID: 98808
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetElementPowerMax(float InElementPowerMax);

		// Token: 0x060181F9 RID: 98809 RVA: 0x0023913E File Offset: 0x0023733E
		public void SetAttributeValue(int AttributeType, float BaseValue, float CurrentValue)
		{
			UBaseAttributeSet.__SetAttributeValue_Internal(base.NativePtr, AttributeType, BaseValue, CurrentValue);
		}

		// Token: 0x060181FA RID: 98810 RVA: 0x0023914E File Offset: 0x0023734E
		public void SetAttributeIntervalLock(int AttributeId, EIntervalLockType LockType, float UpperBoundPercentage, float UpperBoundOffset, float LowerBoundPercentage, float LowerBoundOffset)
		{
			UBaseAttributeSet.__SetAttributeIntervalLock_Internal(base.NativePtr, AttributeId, LockType, UpperBoundPercentage, UpperBoundOffset, LowerBoundPercentage, LowerBoundOffset);
		}

		// Token: 0x060181FB RID: 98811
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetAttackSpeedMax(float InMaxSpeed);

		// Token: 0x060181FC RID: 98812 RVA: 0x00239164 File Offset: 0x00237364
		[NullableContext(2)]
		public bool GetAttributeData(int AttributeType, ref FGameplayAttributeData AttributeData)
		{
			return UBaseAttributeSet.__GetAttributeData_Internal(base.NativePtr, AttributeType, (AttributeData ?? new FGameplayAttributeData()).NativePtr);
		}

		// Token: 0x060181FD RID: 98813 RVA: 0x00239182 File Offset: 0x00237382
		public float GetAttributeCurrentValueById(int AttributeType)
		{
			return UBaseAttributeSet.__GetAttributeCurrentValueById_Internal(base.NativePtr, AttributeType);
		}

		// Token: 0x060181FE RID: 98814 RVA: 0x00239190 File Offset: 0x00237390
		public float GetAttributeBaseValueById(int AttributeType)
		{
			return UBaseAttributeSet.__GetAttributeBaseValueById_Internal(base.NativePtr, AttributeType);
		}

		// Token: 0x060181FF RID: 98815 RVA: 0x0023919E File Offset: 0x0023739E
		[NullableContext(2)]
		public bool CopyAllAttribute(UBaseAttributeSet AttributeSet)
		{
			return UBaseAttributeSet.__CopyAllAttribute_Internal(base.NativePtr, (AttributeSet != null) ? AttributeSet.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06018200 RID: 98816
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAttributeValue_Internal(IntPtr @this, int AttributeType, float BaseValue, float CurrentValue);

		// Token: 0x06018201 RID: 98817
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAttributeIntervalLock_Internal(IntPtr @this, int AttributeId, EIntervalLockType LockType, float UpperBoundPercentage, float UpperBoundOffset, float LowerBoundPercentage, float LowerBoundOffset);

		// Token: 0x06018202 RID: 98818
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetAttributeData_Internal(IntPtr @this, int AttributeType, IntPtr AttributeData);

		// Token: 0x06018203 RID: 98819
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetAttributeCurrentValueById_Internal(IntPtr @this, int AttributeType);

		// Token: 0x06018204 RID: 98820
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetAttributeBaseValueById_Internal(IntPtr @this, int AttributeType);

		// Token: 0x06018205 RID: 98821
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __CopyAllAttribute_Internal(IntPtr @this, IntPtr AttributeSet);

		// Token: 0x06018206 RID: 98822 RVA: 0x002391BB File Offset: 0x002373BB
		static UBaseAttributeSet()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGAS.BaseAttributeSet");
		}

		// Token: 0x06018207 RID: 98823 RVA: 0x002391C9 File Offset: 0x002373C9
		protected UBaseAttributeSet(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400D053 RID: 53331
		public new const string __ObjectPath = "/Script/KuroGAS.BaseAttributeSet";

		// Token: 0x0400D054 RID: 53332
		private static IntPtr _ClassPtr;

		// Token: 0x0400D055 RID: 53333
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400D056 RID: 53334
		internal static int __PropertyOffset_Lv;

		// Token: 0x0400D057 RID: 53335
		[Nullable(2)]
		private FGameplayAttributeData _Lv;

		// Token: 0x0400D058 RID: 53336
		internal static int __PropertyOffset_LifeMax;

		// Token: 0x0400D059 RID: 53337
		[Nullable(2)]
		private FGameplayAttributeData _LifeMax;

		// Token: 0x0400D05A RID: 53338
		internal static int __PropertyOffset_Life;

		// Token: 0x0400D05B RID: 53339
		[Nullable(2)]
		private FGameplayAttributeData _Life;

		// Token: 0x0400D05C RID: 53340
		internal static int __PropertyOffset_Sheild;

		// Token: 0x0400D05D RID: 53341
		[Nullable(2)]
		private FGameplayAttributeData _Sheild;

		// Token: 0x0400D05E RID: 53342
		internal static int __PropertyOffset_SheildDamageChange;

		// Token: 0x0400D05F RID: 53343
		[Nullable(2)]
		private FGameplayAttributeData _SheildDamageChange;

		// Token: 0x0400D060 RID: 53344
		internal static int __PropertyOffset_SheildDamageReduce;

		// Token: 0x0400D061 RID: 53345
		[Nullable(2)]
		private FGameplayAttributeData _SheildDamageReduce;

		// Token: 0x0400D062 RID: 53346
		internal static int __PropertyOffset_Atk;

		// Token: 0x0400D063 RID: 53347
		[Nullable(2)]
		private FGameplayAttributeData _Atk;

		// Token: 0x0400D064 RID: 53348
		internal static int __PropertyOffset_Crit;

		// Token: 0x0400D065 RID: 53349
		[Nullable(2)]
		private FGameplayAttributeData _Crit;

		// Token: 0x0400D066 RID: 53350
		internal static int __PropertyOffset_CritDamage;

		// Token: 0x0400D067 RID: 53351
		[Nullable(2)]
		private FGameplayAttributeData _CritDamage;

		// Token: 0x0400D068 RID: 53352
		internal static int __PropertyOffset_Def;

		// Token: 0x0400D069 RID: 53353
		[Nullable(2)]
		private FGameplayAttributeData _Def;

		// Token: 0x0400D06A RID: 53354
		internal static int __PropertyOffset_EnergyEfficiency;

		// Token: 0x0400D06B RID: 53355
		[Nullable(2)]
		private FGameplayAttributeData _EnergyEfficiency;

		// Token: 0x0400D06C RID: 53356
		internal static int __PropertyOffset_CDReduse;

		// Token: 0x0400D06D RID: 53357
		[Nullable(2)]
		private FGameplayAttributeData _CDReduse;

		// Token: 0x0400D06E RID: 53358
		internal static int __PropertyOffset_ReactionEfficiency;

		// Token: 0x0400D06F RID: 53359
		[Nullable(2)]
		private FGameplayAttributeData _ReactionEfficiency;

		// Token: 0x0400D070 RID: 53360
		internal static int __PropertyOffset_DamageChangeNormalSkill;

		// Token: 0x0400D071 RID: 53361
		[Nullable(2)]
		private FGameplayAttributeData _DamageChangeNormalSkill;

		// Token: 0x0400D072 RID: 53362
		internal static int __PropertyOffset_DamageChange;

		// Token: 0x0400D073 RID: 53363
		[Nullable(2)]
		private FGameplayAttributeData _DamageChange;

		// Token: 0x0400D074 RID: 53364
		internal static int __PropertyOffset_DamageReduce;

		// Token: 0x0400D075 RID: 53365
		[Nullable(2)]
		private FGameplayAttributeData _DamageReduce;

		// Token: 0x0400D076 RID: 53366
		internal static int __PropertyOffset_DamageChangeAuto;

		// Token: 0x0400D077 RID: 53367
		[Nullable(2)]
		private FGameplayAttributeData _DamageChangeAuto;

		// Token: 0x0400D078 RID: 53368
		internal static int __PropertyOffset_DamageChangeCast;

		// Token: 0x0400D079 RID: 53369
		[Nullable(2)]
		private FGameplayAttributeData _DamageChangeCast;

		// Token: 0x0400D07A RID: 53370
		internal static int __PropertyOffset_DamageChangeUltra;

		// Token: 0x0400D07B RID: 53371
		[Nullable(2)]
		private FGameplayAttributeData _DamageChangeUltra;

		// Token: 0x0400D07C RID: 53372
		internal static int __PropertyOffset_DamageChangeQTE;

		// Token: 0x0400D07D RID: 53373
		[Nullable(2)]
		private FGameplayAttributeData _DamageChangeQTE;

		// Token: 0x0400D07E RID: 53374
		internal static int __PropertyOffset_DamageChangePhys;

		// Token: 0x0400D07F RID: 53375
		[Nullable(2)]
		private FGameplayAttributeData _DamageChangePhys;

		// Token: 0x0400D080 RID: 53376
		internal static int __PropertyOffset_DamageChangeElement1;

		// Token: 0x0400D081 RID: 53377
		[Nullable(2)]
		private FGameplayAttributeData _DamageChangeElement1;

		// Token: 0x0400D082 RID: 53378
		internal static int __PropertyOffset_DamageChangeElement2;

		// Token: 0x0400D083 RID: 53379
		[Nullable(2)]
		private FGameplayAttributeData _DamageChangeElement2;

		// Token: 0x0400D084 RID: 53380
		internal static int __PropertyOffset_DamageChangeElement3;

		// Token: 0x0400D085 RID: 53381
		[Nullable(2)]
		private FGameplayAttributeData _DamageChangeElement3;

		// Token: 0x0400D086 RID: 53382
		internal static int __PropertyOffset_DamageChangeElement4;

		// Token: 0x0400D087 RID: 53383
		[Nullable(2)]
		private FGameplayAttributeData _DamageChangeElement4;

		// Token: 0x0400D088 RID: 53384
		internal static int __PropertyOffset_DamageChangeElement5;

		// Token: 0x0400D089 RID: 53385
		[Nullable(2)]
		private FGameplayAttributeData _DamageChangeElement5;

		// Token: 0x0400D08A RID: 53386
		internal static int __PropertyOffset_DamageChangeElement6;

		// Token: 0x0400D08B RID: 53387
		[Nullable(2)]
		private FGameplayAttributeData _DamageChangeElement6;

		// Token: 0x0400D08C RID: 53388
		internal static int __PropertyOffset_DamageResistancePhys;

		// Token: 0x0400D08D RID: 53389
		[Nullable(2)]
		private FGameplayAttributeData _DamageResistancePhys;

		// Token: 0x0400D08E RID: 53390
		internal static int __PropertyOffset_DamageResistanceElement1;

		// Token: 0x0400D08F RID: 53391
		[Nullable(2)]
		private FGameplayAttributeData _DamageResistanceElement1;

		// Token: 0x0400D090 RID: 53392
		internal static int __PropertyOffset_DamageResistanceElement2;

		// Token: 0x0400D091 RID: 53393
		[Nullable(2)]
		private FGameplayAttributeData _DamageResistanceElement2;

		// Token: 0x0400D092 RID: 53394
		internal static int __PropertyOffset_DamageResistanceElement3;

		// Token: 0x0400D093 RID: 53395
		[Nullable(2)]
		private FGameplayAttributeData _DamageResistanceElement3;

		// Token: 0x0400D094 RID: 53396
		internal static int __PropertyOffset_DamageResistanceElement4;

		// Token: 0x0400D095 RID: 53397
		[Nullable(2)]
		private FGameplayAttributeData _DamageResistanceElement4;

		// Token: 0x0400D096 RID: 53398
		internal static int __PropertyOffset_DamageResistanceElement5;

		// Token: 0x0400D097 RID: 53399
		[Nullable(2)]
		private FGameplayAttributeData _DamageResistanceElement5;

		// Token: 0x0400D098 RID: 53400
		internal static int __PropertyOffset_DamageResistanceElement6;

		// Token: 0x0400D099 RID: 53401
		[Nullable(2)]
		private FGameplayAttributeData _DamageResistanceElement6;

		// Token: 0x0400D09A RID: 53402
		internal static int __PropertyOffset_HealChange;

		// Token: 0x0400D09B RID: 53403
		[Nullable(2)]
		private FGameplayAttributeData _HealChange;

		// Token: 0x0400D09C RID: 53404
		internal static int __PropertyOffset_HealedChange;

		// Token: 0x0400D09D RID: 53405
		[Nullable(2)]
		private FGameplayAttributeData _HealedChange;

		// Token: 0x0400D09E RID: 53406
		internal static int __PropertyOffset_DamageReducePhys;

		// Token: 0x0400D09F RID: 53407
		[Nullable(2)]
		private FGameplayAttributeData _DamageReducePhys;

		// Token: 0x0400D0A0 RID: 53408
		internal static int __PropertyOffset_DamageReduceElement1;

		// Token: 0x0400D0A1 RID: 53409
		[Nullable(2)]
		private FGameplayAttributeData _DamageReduceElement1;

		// Token: 0x0400D0A2 RID: 53410
		internal static int __PropertyOffset_DamageReduceElement2;

		// Token: 0x0400D0A3 RID: 53411
		[Nullable(2)]
		private FGameplayAttributeData _DamageReduceElement2;

		// Token: 0x0400D0A4 RID: 53412
		internal static int __PropertyOffset_DamageReduceElement3;

		// Token: 0x0400D0A5 RID: 53413
		[Nullable(2)]
		private FGameplayAttributeData _DamageReduceElement3;

		// Token: 0x0400D0A6 RID: 53414
		internal static int __PropertyOffset_DamageReduceElement4;

		// Token: 0x0400D0A7 RID: 53415
		[Nullable(2)]
		private FGameplayAttributeData _DamageReduceElement4;

		// Token: 0x0400D0A8 RID: 53416
		internal static int __PropertyOffset_DamageReduceElement5;

		// Token: 0x0400D0A9 RID: 53417
		[Nullable(2)]
		private FGameplayAttributeData _DamageReduceElement5;

		// Token: 0x0400D0AA RID: 53418
		internal static int __PropertyOffset_DamageReduceElement6;

		// Token: 0x0400D0AB RID: 53419
		[Nullable(2)]
		private FGameplayAttributeData _DamageReduceElement6;

		// Token: 0x0400D0AC RID: 53420
		internal static int __PropertyOffset_ReactionChange1;

		// Token: 0x0400D0AD RID: 53421
		[Nullable(2)]
		private FGameplayAttributeData _ReactionChange1;

		// Token: 0x0400D0AE RID: 53422
		internal static int __PropertyOffset_ReactionChange2;

		// Token: 0x0400D0AF RID: 53423
		[Nullable(2)]
		private FGameplayAttributeData _ReactionChange2;

		// Token: 0x0400D0B0 RID: 53424
		internal static int __PropertyOffset_ReactionChange3;

		// Token: 0x0400D0B1 RID: 53425
		[Nullable(2)]
		private FGameplayAttributeData _ReactionChange3;

		// Token: 0x0400D0B2 RID: 53426
		internal static int __PropertyOffset_ReactionChange4;

		// Token: 0x0400D0B3 RID: 53427
		[Nullable(2)]
		private FGameplayAttributeData _ReactionChange4;

		// Token: 0x0400D0B4 RID: 53428
		internal static int __PropertyOffset_ReactionChange5;

		// Token: 0x0400D0B5 RID: 53429
		[Nullable(2)]
		private FGameplayAttributeData _ReactionChange5;

		// Token: 0x0400D0B6 RID: 53430
		internal static int __PropertyOffset_ReactionChange6;

		// Token: 0x0400D0B7 RID: 53431
		[Nullable(2)]
		private FGameplayAttributeData _ReactionChange6;

		// Token: 0x0400D0B8 RID: 53432
		internal static int __PropertyOffset_ReactionChange7;

		// Token: 0x0400D0B9 RID: 53433
		[Nullable(2)]
		private FGameplayAttributeData _ReactionChange7;

		// Token: 0x0400D0BA RID: 53434
		internal static int __PropertyOffset_ReactionChange8;

		// Token: 0x0400D0BB RID: 53435
		[Nullable(2)]
		private FGameplayAttributeData _ReactionChange8;

		// Token: 0x0400D0BC RID: 53436
		internal static int __PropertyOffset_ReactionChange9;

		// Token: 0x0400D0BD RID: 53437
		[Nullable(2)]
		private FGameplayAttributeData _ReactionChange9;

		// Token: 0x0400D0BE RID: 53438
		internal static int __PropertyOffset_ReactionChange10;

		// Token: 0x0400D0BF RID: 53439
		[Nullable(2)]
		private FGameplayAttributeData _ReactionChange10;

		// Token: 0x0400D0C0 RID: 53440
		internal static int __PropertyOffset_ReactionChange11;

		// Token: 0x0400D0C1 RID: 53441
		[Nullable(2)]
		private FGameplayAttributeData _ReactionChange11;

		// Token: 0x0400D0C2 RID: 53442
		internal static int __PropertyOffset_ReactionChange12;

		// Token: 0x0400D0C3 RID: 53443
		[Nullable(2)]
		private FGameplayAttributeData _ReactionChange12;

		// Token: 0x0400D0C4 RID: 53444
		internal static int __PropertyOffset_ReactionChange13;

		// Token: 0x0400D0C5 RID: 53445
		[Nullable(2)]
		private FGameplayAttributeData _ReactionChange13;

		// Token: 0x0400D0C6 RID: 53446
		internal static int __PropertyOffset_ReactionChange14;

		// Token: 0x0400D0C7 RID: 53447
		[Nullable(2)]
		private FGameplayAttributeData _ReactionChange14;

		// Token: 0x0400D0C8 RID: 53448
		internal static int __PropertyOffset_ReactionChange15;

		// Token: 0x0400D0C9 RID: 53449
		[Nullable(2)]
		private FGameplayAttributeData _ReactionChange15;

		// Token: 0x0400D0CA RID: 53450
		internal static int __PropertyOffset_EnergyMax;

		// Token: 0x0400D0CB RID: 53451
		[Nullable(2)]
		private FGameplayAttributeData _EnergyMax;

		// Token: 0x0400D0CC RID: 53452
		internal static int __PropertyOffset_Energy;

		// Token: 0x0400D0CD RID: 53453
		[Nullable(2)]
		private FGameplayAttributeData _Energy;

		// Token: 0x0400D0CE RID: 53454
		internal static int __PropertyOffset_SpecialEnergy1Max;

		// Token: 0x0400D0CF RID: 53455
		[Nullable(2)]
		private FGameplayAttributeData _SpecialEnergy1Max;

		// Token: 0x0400D0D0 RID: 53456
		internal static int __PropertyOffset_SpecialEnergy1;

		// Token: 0x0400D0D1 RID: 53457
		[Nullable(2)]
		private FGameplayAttributeData _SpecialEnergy1;

		// Token: 0x0400D0D2 RID: 53458
		internal static int __PropertyOffset_SpecialEnergy2Max;

		// Token: 0x0400D0D3 RID: 53459
		[Nullable(2)]
		private FGameplayAttributeData _SpecialEnergy2Max;

		// Token: 0x0400D0D4 RID: 53460
		internal static int __PropertyOffset_SpecialEnergy2;

		// Token: 0x0400D0D5 RID: 53461
		[Nullable(2)]
		private FGameplayAttributeData _SpecialEnergy2;

		// Token: 0x0400D0D6 RID: 53462
		internal static int __PropertyOffset_SpecialEnergy3Max;

		// Token: 0x0400D0D7 RID: 53463
		[Nullable(2)]
		private FGameplayAttributeData _SpecialEnergy3Max;

		// Token: 0x0400D0D8 RID: 53464
		internal static int __PropertyOffset_SpecialEnergy3;

		// Token: 0x0400D0D9 RID: 53465
		[Nullable(2)]
		private FGameplayAttributeData _SpecialEnergy3;

		// Token: 0x0400D0DA RID: 53466
		internal static int __PropertyOffset_SpecialEnergy4Max;

		// Token: 0x0400D0DB RID: 53467
		[Nullable(2)]
		private FGameplayAttributeData _SpecialEnergy4Max;

		// Token: 0x0400D0DC RID: 53468
		internal static int __PropertyOffset_SpecialEnergy4;

		// Token: 0x0400D0DD RID: 53469
		[Nullable(2)]
		private FGameplayAttributeData _SpecialEnergy4;

		// Token: 0x0400D0DE RID: 53470
		internal static int __PropertyOffset_StrengthMax;

		// Token: 0x0400D0DF RID: 53471
		[Nullable(2)]
		private FGameplayAttributeData _StrengthMax;

		// Token: 0x0400D0E0 RID: 53472
		internal static int __PropertyOffset_Strength;

		// Token: 0x0400D0E1 RID: 53473
		[Nullable(2)]
		private FGameplayAttributeData _Strength;

		// Token: 0x0400D0E2 RID: 53474
		internal static int __PropertyOffset_StrengthRecover;

		// Token: 0x0400D0E3 RID: 53475
		[Nullable(2)]
		private FGameplayAttributeData _StrengthRecover;

		// Token: 0x0400D0E4 RID: 53476
		internal static int __PropertyOffset_StrengthPunishTime;

		// Token: 0x0400D0E5 RID: 53477
		[Nullable(2)]
		private FGameplayAttributeData _StrengthPunishTime;

		// Token: 0x0400D0E6 RID: 53478
		internal static int __PropertyOffset_StrengthRun;

		// Token: 0x0400D0E7 RID: 53479
		[Nullable(2)]
		private FGameplayAttributeData _StrengthRun;

		// Token: 0x0400D0E8 RID: 53480
		internal static int __PropertyOffset_StrengthSwim;

		// Token: 0x0400D0E9 RID: 53481
		[Nullable(2)]
		private FGameplayAttributeData _StrengthSwim;

		// Token: 0x0400D0EA RID: 53482
		internal static int __PropertyOffset_StrengthFastSwim;

		// Token: 0x0400D0EB RID: 53483
		[Nullable(2)]
		private FGameplayAttributeData _StrengthFastSwim;

		// Token: 0x0400D0EC RID: 53484
		internal static int __PropertyOffset_StrengthClimb;

		// Token: 0x0400D0ED RID: 53485
		[Nullable(2)]
		private FGameplayAttributeData _StrengthClimb;

		// Token: 0x0400D0EE RID: 53486
		internal static int __PropertyOffset_StrengthFastClimb;

		// Token: 0x0400D0EF RID: 53487
		[Nullable(2)]
		private FGameplayAttributeData _StrengthFastClimb;

		// Token: 0x0400D0F0 RID: 53488
		internal static int __PropertyOffset_HardnessMax;

		// Token: 0x0400D0F1 RID: 53489
		[Nullable(2)]
		private FGameplayAttributeData _HardnessMax;

		// Token: 0x0400D0F2 RID: 53490
		internal static int __PropertyOffset_Hardness;

		// Token: 0x0400D0F3 RID: 53491
		[Nullable(2)]
		private FGameplayAttributeData _Hardness;

		// Token: 0x0400D0F4 RID: 53492
		internal static int __PropertyOffset_HardnessRecover;

		// Token: 0x0400D0F5 RID: 53493
		[Nullable(2)]
		private FGameplayAttributeData _HardnessRecover;

		// Token: 0x0400D0F6 RID: 53494
		internal static int __PropertyOffset_HardnessPunishTime;

		// Token: 0x0400D0F7 RID: 53495
		[Nullable(2)]
		private FGameplayAttributeData _HardnessPunishTime;

		// Token: 0x0400D0F8 RID: 53496
		internal static int __PropertyOffset_HardnessChange;

		// Token: 0x0400D0F9 RID: 53497
		[Nullable(2)]
		private FGameplayAttributeData _HardnessChange;

		// Token: 0x0400D0FA RID: 53498
		internal static int __PropertyOffset_HardnessReduce;

		// Token: 0x0400D0FB RID: 53499
		[Nullable(2)]
		private FGameplayAttributeData _HardnessReduce;

		// Token: 0x0400D0FC RID: 53500
		internal static int __PropertyOffset_ToughMax;

		// Token: 0x0400D0FD RID: 53501
		[Nullable(2)]
		private FGameplayAttributeData _ToughMax;

		// Token: 0x0400D0FE RID: 53502
		internal static int __PropertyOffset_Tough;

		// Token: 0x0400D0FF RID: 53503
		[Nullable(2)]
		private FGameplayAttributeData _Tough;

		// Token: 0x0400D100 RID: 53504
		internal static int __PropertyOffset_ToughRecover;

		// Token: 0x0400D101 RID: 53505
		[Nullable(2)]
		private FGameplayAttributeData _ToughRecover;

		// Token: 0x0400D102 RID: 53506
		internal static int __PropertyOffset_ToughChange;

		// Token: 0x0400D103 RID: 53507
		[Nullable(2)]
		private FGameplayAttributeData _ToughChange;

		// Token: 0x0400D104 RID: 53508
		internal static int __PropertyOffset_ToughReduce;

		// Token: 0x0400D105 RID: 53509
		[Nullable(2)]
		private FGameplayAttributeData _ToughReduce;

		// Token: 0x0400D106 RID: 53510
		internal static int __PropertyOffset_ElementPower1;

		// Token: 0x0400D107 RID: 53511
		[Nullable(2)]
		private FGameplayAttributeData _ElementPower1;

		// Token: 0x0400D108 RID: 53512
		internal static int __PropertyOffset_ElementPower2;

		// Token: 0x0400D109 RID: 53513
		[Nullable(2)]
		private FGameplayAttributeData _ElementPower2;

		// Token: 0x0400D10A RID: 53514
		internal static int __PropertyOffset_ElementPower3;

		// Token: 0x0400D10B RID: 53515
		[Nullable(2)]
		private FGameplayAttributeData _ElementPower3;

		// Token: 0x0400D10C RID: 53516
		internal static int __PropertyOffset_ElementPower4;

		// Token: 0x0400D10D RID: 53517
		[Nullable(2)]
		private FGameplayAttributeData _ElementPower4;

		// Token: 0x0400D10E RID: 53518
		internal static int __PropertyOffset_ElementPower5;

		// Token: 0x0400D10F RID: 53519
		[Nullable(2)]
		private FGameplayAttributeData _ElementPower5;

		// Token: 0x0400D110 RID: 53520
		internal static int __PropertyOffset_ElementPower6;

		// Token: 0x0400D111 RID: 53521
		[Nullable(2)]
		private FGameplayAttributeData _ElementPower6;

		// Token: 0x0400D112 RID: 53522
		internal static int __PropertyOffset_SpecialDamageChange;

		// Token: 0x0400D113 RID: 53523
		[Nullable(2)]
		private FGameplayAttributeData _SpecialDamageChange;

		// Token: 0x0400D114 RID: 53524
		internal static int __PropertyOffset_StrengthFastClimbCost;

		// Token: 0x0400D115 RID: 53525
		[Nullable(2)]
		private FGameplayAttributeData _StrengthFastClimbCost;

		// Token: 0x0400D116 RID: 53526
		internal static int __PropertyOffset_ElementPropertyType;

		// Token: 0x0400D117 RID: 53527
		[Nullable(2)]
		private FGameplayAttributeData _ElementPropertyType;

		// Token: 0x0400D118 RID: 53528
		internal static int __PropertyOffset_WeakTime;

		// Token: 0x0400D119 RID: 53529
		[Nullable(2)]
		private FGameplayAttributeData _WeakTime;

		// Token: 0x0400D11A RID: 53530
		internal static int __PropertyOffset_IgnoreDefRate;

		// Token: 0x0400D11B RID: 53531
		[Nullable(2)]
		private FGameplayAttributeData _IgnoreDefRate;

		// Token: 0x0400D11C RID: 53532
		internal static int __PropertyOffset_IgnoreDamageResistancePhys;

		// Token: 0x0400D11D RID: 53533
		[Nullable(2)]
		private FGameplayAttributeData _IgnoreDamageResistancePhys;

		// Token: 0x0400D11E RID: 53534
		internal static int __PropertyOffset_IgnoreDamageResistanceElement1;

		// Token: 0x0400D11F RID: 53535
		[Nullable(2)]
		private FGameplayAttributeData _IgnoreDamageResistanceElement1;

		// Token: 0x0400D120 RID: 53536
		internal static int __PropertyOffset_IgnoreDamageResistanceElement2;

		// Token: 0x0400D121 RID: 53537
		[Nullable(2)]
		private FGameplayAttributeData _IgnoreDamageResistanceElement2;

		// Token: 0x0400D122 RID: 53538
		internal static int __PropertyOffset_IgnoreDamageResistanceElement3;

		// Token: 0x0400D123 RID: 53539
		[Nullable(2)]
		private FGameplayAttributeData _IgnoreDamageResistanceElement3;

		// Token: 0x0400D124 RID: 53540
		internal static int __PropertyOffset_IgnoreDamageResistanceElement4;

		// Token: 0x0400D125 RID: 53541
		[Nullable(2)]
		private FGameplayAttributeData _IgnoreDamageResistanceElement4;

		// Token: 0x0400D126 RID: 53542
		internal static int __PropertyOffset_IgnoreDamageResistanceElement5;

		// Token: 0x0400D127 RID: 53543
		[Nullable(2)]
		private FGameplayAttributeData _IgnoreDamageResistanceElement5;

		// Token: 0x0400D128 RID: 53544
		internal static int __PropertyOffset_IgnoreDamageResistanceElement6;

		// Token: 0x0400D129 RID: 53545
		[Nullable(2)]
		private FGameplayAttributeData _IgnoreDamageResistanceElement6;

		// Token: 0x0400D12A RID: 53546
		internal static int __PropertyOffset_SkillToughRatio;

		// Token: 0x0400D12B RID: 53547
		[Nullable(2)]
		private FGameplayAttributeData _SkillToughRatio;

		// Token: 0x0400D12C RID: 53548
		internal static int __PropertyOffset_StrengthClimbJump;

		// Token: 0x0400D12D RID: 53549
		[Nullable(2)]
		private FGameplayAttributeData _StrengthClimbJump;

		// Token: 0x0400D12E RID: 53550
		internal static int __PropertyOffset_StrengthGliding;

		// Token: 0x0400D12F RID: 53551
		[Nullable(2)]
		private FGameplayAttributeData _StrengthGliding;

		// Token: 0x0400D130 RID: 53552
		internal static int __PropertyOffset_Mass;

		// Token: 0x0400D131 RID: 53553
		[Nullable(2)]
		private FGameplayAttributeData _Mass;

		// Token: 0x0400D132 RID: 53554
		internal static int __PropertyOffset_BrakingFrictionFactor;

		// Token: 0x0400D133 RID: 53555
		[Nullable(2)]
		private FGameplayAttributeData _BrakingFrictionFactor;

		// Token: 0x0400D134 RID: 53556
		internal static int __PropertyOffset_GravityScale;

		// Token: 0x0400D135 RID: 53557
		[Nullable(2)]
		private FGameplayAttributeData _GravityScale;

		// Token: 0x0400D136 RID: 53558
		internal static int __PropertyOffset_SpeedRatio;

		// Token: 0x0400D137 RID: 53559
		[Nullable(2)]
		private FGameplayAttributeData _SpeedRatio;

		// Token: 0x0400D138 RID: 53560
		internal static int __PropertyOffset_DamageChangePhantom;

		// Token: 0x0400D139 RID: 53561
		[Nullable(2)]
		private FGameplayAttributeData _DamageChangePhantom;

		// Token: 0x0400D13A RID: 53562
		internal static int __PropertyOffset_AutoAttackSpeed;

		// Token: 0x0400D13B RID: 53563
		[Nullable(2)]
		private FGameplayAttributeData _AutoAttackSpeed;

		// Token: 0x0400D13C RID: 53564
		internal static int __PropertyOffset_CastAttackSpeed;

		// Token: 0x0400D13D RID: 53565
		[Nullable(2)]
		private FGameplayAttributeData _CastAttackSpeed;

		// Token: 0x0400D13E RID: 53566
		internal static int __PropertyOffset_StatusBuildUp1Max;

		// Token: 0x0400D13F RID: 53567
		[Nullable(2)]
		private FGameplayAttributeData _StatusBuildUp1Max;

		// Token: 0x0400D140 RID: 53568
		internal static int __PropertyOffset_StatusBuildUp1;

		// Token: 0x0400D141 RID: 53569
		[Nullable(2)]
		private FGameplayAttributeData _StatusBuildUp1;

		// Token: 0x0400D142 RID: 53570
		internal static int __PropertyOffset_StatusBuildUp2Max;

		// Token: 0x0400D143 RID: 53571
		[Nullable(2)]
		private FGameplayAttributeData _StatusBuildUp2Max;

		// Token: 0x0400D144 RID: 53572
		internal static int __PropertyOffset_StatusBuildUp2;

		// Token: 0x0400D145 RID: 53573
		[Nullable(2)]
		private FGameplayAttributeData _StatusBuildUp2;

		// Token: 0x0400D146 RID: 53574
		internal static int __PropertyOffset_StatusBuildUp3Max;

		// Token: 0x0400D147 RID: 53575
		[Nullable(2)]
		private FGameplayAttributeData _StatusBuildUp3Max;

		// Token: 0x0400D148 RID: 53576
		internal static int __PropertyOffset_StatusBuildUp3;

		// Token: 0x0400D149 RID: 53577
		[Nullable(2)]
		private FGameplayAttributeData _StatusBuildUp3;

		// Token: 0x0400D14A RID: 53578
		internal static int __PropertyOffset_StatusBuildUp4Max;

		// Token: 0x0400D14B RID: 53579
		[Nullable(2)]
		private FGameplayAttributeData _StatusBuildUp4Max;

		// Token: 0x0400D14C RID: 53580
		internal static int __PropertyOffset_StatusBuildUp4;

		// Token: 0x0400D14D RID: 53581
		[Nullable(2)]
		private FGameplayAttributeData _StatusBuildUp4;

		// Token: 0x0400D14E RID: 53582
		internal static int __PropertyOffset_StatusBuildUp5Max;

		// Token: 0x0400D14F RID: 53583
		[Nullable(2)]
		private FGameplayAttributeData _StatusBuildUp5Max;

		// Token: 0x0400D150 RID: 53584
		internal static int __PropertyOffset_StatusBuildUp5;

		// Token: 0x0400D151 RID: 53585
		[Nullable(2)]
		private FGameplayAttributeData _StatusBuildUp5;

		// Token: 0x0400D152 RID: 53586
		internal static int __PropertyOffset_RageMax;

		// Token: 0x0400D153 RID: 53587
		[Nullable(2)]
		private FGameplayAttributeData _RageMax;

		// Token: 0x0400D154 RID: 53588
		internal static int __PropertyOffset_Rage;

		// Token: 0x0400D155 RID: 53589
		[Nullable(2)]
		private FGameplayAttributeData _Rage;

		// Token: 0x0400D156 RID: 53590
		internal static int __PropertyOffset_RageRecover;

		// Token: 0x0400D157 RID: 53591
		[Nullable(2)]
		private FGameplayAttributeData _RageRecover;

		// Token: 0x0400D158 RID: 53592
		internal static int __PropertyOffset_RagePunishTime;

		// Token: 0x0400D159 RID: 53593
		[Nullable(2)]
		private FGameplayAttributeData _RagePunishTime;

		// Token: 0x0400D15A RID: 53594
		internal static int __PropertyOffset_RageChange;

		// Token: 0x0400D15B RID: 53595
		[Nullable(2)]
		private FGameplayAttributeData _RageChange;

		// Token: 0x0400D15C RID: 53596
		internal static int __PropertyOffset_RageReduce;

		// Token: 0x0400D15D RID: 53597
		[Nullable(2)]
		private FGameplayAttributeData _RageReduce;

		// Token: 0x0400D15E RID: 53598
		internal static int __PropertyOffset_ToughRecoverDelayTime;

		// Token: 0x0400D15F RID: 53599
		[Nullable(2)]
		private FGameplayAttributeData _ToughRecoverDelayTime;

		// Token: 0x0400D160 RID: 53600
		internal static int __PropertyOffset_Jump;

		// Token: 0x0400D161 RID: 53601
		[Nullable(2)]
		private FGameplayAttributeData _Jump;

		// Token: 0x0400D162 RID: 53602
		internal static int __PropertyOffset_ParalysisTimeMax;

		// Token: 0x0400D163 RID: 53603
		[Nullable(2)]
		private FGameplayAttributeData _ParalysisTimeMax;

		// Token: 0x0400D164 RID: 53604
		internal static int __PropertyOffset_ParalysisTime;

		// Token: 0x0400D165 RID: 53605
		[Nullable(2)]
		private FGameplayAttributeData _ParalysisTime;

		// Token: 0x0400D166 RID: 53606
		internal static int __PropertyOffset_ParalysisTimeRecover;

		// Token: 0x0400D167 RID: 53607
		[Nullable(2)]
		private FGameplayAttributeData _ParalysisTimeRecover;

		// Token: 0x0400D168 RID: 53608
		internal static int __PropertyOffset_WeaknessBuildUp;

		// Token: 0x0400D169 RID: 53609
		[Nullable(2)]
		private FGameplayAttributeData _WeaknessBuildUp;

		// Token: 0x0400D16A RID: 53610
		internal static int __PropertyOffset_WeaknessBuildUpMax;

		// Token: 0x0400D16B RID: 53611
		[Nullable(2)]
		private FGameplayAttributeData _WeaknessBuildUpMax;

		// Token: 0x0400D16C RID: 53612
		internal static int __PropertyOffset_WeaknessTotalBonus;

		// Token: 0x0400D16D RID: 53613
		[Nullable(2)]
		private FGameplayAttributeData _WeaknessTotalBonus;

		// Token: 0x0400D16E RID: 53614
		internal static int __PropertyOffset_WeaknessTotalResist;

		// Token: 0x0400D16F RID: 53615
		[Nullable(2)]
		private FGameplayAttributeData _WeaknessTotalResist;
	}
}
