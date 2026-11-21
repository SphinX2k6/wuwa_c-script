using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000430 RID: 1072
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGAS.BaseAttributeSet")]
	[UnrealStructLayout(3536, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 3536)]
	public class UBaseAttributeSet : UAttributeSet, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060066DD RID: 26333 RVA: 0x00094C51 File Offset: 0x00092E51
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBaseAttributeSet._ClassPtr;
		}

		// Token: 0x060066DE RID: 26334 RVA: 0x00094C60 File Offset: 0x00092E60
		public UBaseAttributeSet() : this(BuiltinUtils.AllocNativeUObject(UBaseAttributeSet.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060066DF RID: 26335 RVA: 0x00094C88 File Offset: 0x00092E88
		public UBaseAttributeSet(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBaseAttributeSet.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001462 RID: 5218
		// (get) Token: 0x060066E0 RID: 26336 RVA: 0x00094CBC File Offset: 0x00092EBC
		// (set) Token: 0x060066E1 RID: 26337 RVA: 0x00094CF5 File Offset: 0x00092EF5
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

		// Token: 0x17001463 RID: 5219
		// (get) Token: 0x060066E2 RID: 26338 RVA: 0x00094D18 File Offset: 0x00092F18
		// (set) Token: 0x060066E3 RID: 26339 RVA: 0x00094D51 File Offset: 0x00092F51
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

		// Token: 0x17001464 RID: 5220
		// (get) Token: 0x060066E4 RID: 26340 RVA: 0x00094D74 File Offset: 0x00092F74
		// (set) Token: 0x060066E5 RID: 26341 RVA: 0x00094DAD File Offset: 0x00092FAD
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

		// Token: 0x17001465 RID: 5221
		// (get) Token: 0x060066E6 RID: 26342 RVA: 0x00094DD0 File Offset: 0x00092FD0
		// (set) Token: 0x060066E7 RID: 26343 RVA: 0x00094E09 File Offset: 0x00093009
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

		// Token: 0x17001466 RID: 5222
		// (get) Token: 0x060066E8 RID: 26344 RVA: 0x00094E2C File Offset: 0x0009302C
		// (set) Token: 0x060066E9 RID: 26345 RVA: 0x00094E65 File Offset: 0x00093065
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

		// Token: 0x17001467 RID: 5223
		// (get) Token: 0x060066EA RID: 26346 RVA: 0x00094E88 File Offset: 0x00093088
		// (set) Token: 0x060066EB RID: 26347 RVA: 0x00094EC1 File Offset: 0x000930C1
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

		// Token: 0x17001468 RID: 5224
		// (get) Token: 0x060066EC RID: 26348 RVA: 0x00094EE4 File Offset: 0x000930E4
		// (set) Token: 0x060066ED RID: 26349 RVA: 0x00094F1D File Offset: 0x0009311D
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

		// Token: 0x17001469 RID: 5225
		// (get) Token: 0x060066EE RID: 26350 RVA: 0x00094F40 File Offset: 0x00093140
		// (set) Token: 0x060066EF RID: 26351 RVA: 0x00094F79 File Offset: 0x00093179
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

		// Token: 0x1700146A RID: 5226
		// (get) Token: 0x060066F0 RID: 26352 RVA: 0x00094F9C File Offset: 0x0009319C
		// (set) Token: 0x060066F1 RID: 26353 RVA: 0x00094FD5 File Offset: 0x000931D5
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

		// Token: 0x1700146B RID: 5227
		// (get) Token: 0x060066F2 RID: 26354 RVA: 0x00094FF8 File Offset: 0x000931F8
		// (set) Token: 0x060066F3 RID: 26355 RVA: 0x00095031 File Offset: 0x00093231
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

		// Token: 0x1700146C RID: 5228
		// (get) Token: 0x060066F4 RID: 26356 RVA: 0x00095054 File Offset: 0x00093254
		// (set) Token: 0x060066F5 RID: 26357 RVA: 0x0009508D File Offset: 0x0009328D
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

		// Token: 0x1700146D RID: 5229
		// (get) Token: 0x060066F6 RID: 26358 RVA: 0x000950B0 File Offset: 0x000932B0
		// (set) Token: 0x060066F7 RID: 26359 RVA: 0x000950E9 File Offset: 0x000932E9
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

		// Token: 0x1700146E RID: 5230
		// (get) Token: 0x060066F8 RID: 26360 RVA: 0x0009510C File Offset: 0x0009330C
		// (set) Token: 0x060066F9 RID: 26361 RVA: 0x00095145 File Offset: 0x00093345
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

		// Token: 0x1700146F RID: 5231
		// (get) Token: 0x060066FA RID: 26362 RVA: 0x00095168 File Offset: 0x00093368
		// (set) Token: 0x060066FB RID: 26363 RVA: 0x000951A1 File Offset: 0x000933A1
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

		// Token: 0x17001470 RID: 5232
		// (get) Token: 0x060066FC RID: 26364 RVA: 0x000951C4 File Offset: 0x000933C4
		// (set) Token: 0x060066FD RID: 26365 RVA: 0x000951FD File Offset: 0x000933FD
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

		// Token: 0x17001471 RID: 5233
		// (get) Token: 0x060066FE RID: 26366 RVA: 0x00095220 File Offset: 0x00093420
		// (set) Token: 0x060066FF RID: 26367 RVA: 0x00095259 File Offset: 0x00093459
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

		// Token: 0x17001472 RID: 5234
		// (get) Token: 0x06006700 RID: 26368 RVA: 0x0009527C File Offset: 0x0009347C
		// (set) Token: 0x06006701 RID: 26369 RVA: 0x000952B5 File Offset: 0x000934B5
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

		// Token: 0x17001473 RID: 5235
		// (get) Token: 0x06006702 RID: 26370 RVA: 0x000952D8 File Offset: 0x000934D8
		// (set) Token: 0x06006703 RID: 26371 RVA: 0x00095311 File Offset: 0x00093511
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

		// Token: 0x17001474 RID: 5236
		// (get) Token: 0x06006704 RID: 26372 RVA: 0x00095334 File Offset: 0x00093534
		// (set) Token: 0x06006705 RID: 26373 RVA: 0x0009536D File Offset: 0x0009356D
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

		// Token: 0x17001475 RID: 5237
		// (get) Token: 0x06006706 RID: 26374 RVA: 0x00095390 File Offset: 0x00093590
		// (set) Token: 0x06006707 RID: 26375 RVA: 0x000953C9 File Offset: 0x000935C9
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

		// Token: 0x17001476 RID: 5238
		// (get) Token: 0x06006708 RID: 26376 RVA: 0x000953EC File Offset: 0x000935EC
		// (set) Token: 0x06006709 RID: 26377 RVA: 0x00095425 File Offset: 0x00093625
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

		// Token: 0x17001477 RID: 5239
		// (get) Token: 0x0600670A RID: 26378 RVA: 0x00095448 File Offset: 0x00093648
		// (set) Token: 0x0600670B RID: 26379 RVA: 0x00095481 File Offset: 0x00093681
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

		// Token: 0x17001478 RID: 5240
		// (get) Token: 0x0600670C RID: 26380 RVA: 0x000954A4 File Offset: 0x000936A4
		// (set) Token: 0x0600670D RID: 26381 RVA: 0x000954DD File Offset: 0x000936DD
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

		// Token: 0x17001479 RID: 5241
		// (get) Token: 0x0600670E RID: 26382 RVA: 0x00095500 File Offset: 0x00093700
		// (set) Token: 0x0600670F RID: 26383 RVA: 0x00095539 File Offset: 0x00093739
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

		// Token: 0x1700147A RID: 5242
		// (get) Token: 0x06006710 RID: 26384 RVA: 0x0009555C File Offset: 0x0009375C
		// (set) Token: 0x06006711 RID: 26385 RVA: 0x00095595 File Offset: 0x00093795
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

		// Token: 0x1700147B RID: 5243
		// (get) Token: 0x06006712 RID: 26386 RVA: 0x000955B8 File Offset: 0x000937B8
		// (set) Token: 0x06006713 RID: 26387 RVA: 0x000955F1 File Offset: 0x000937F1
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

		// Token: 0x1700147C RID: 5244
		// (get) Token: 0x06006714 RID: 26388 RVA: 0x00095614 File Offset: 0x00093814
		// (set) Token: 0x06006715 RID: 26389 RVA: 0x0009564D File Offset: 0x0009384D
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

		// Token: 0x1700147D RID: 5245
		// (get) Token: 0x06006716 RID: 26390 RVA: 0x00095670 File Offset: 0x00093870
		// (set) Token: 0x06006717 RID: 26391 RVA: 0x000956A9 File Offset: 0x000938A9
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

		// Token: 0x1700147E RID: 5246
		// (get) Token: 0x06006718 RID: 26392 RVA: 0x000956CC File Offset: 0x000938CC
		// (set) Token: 0x06006719 RID: 26393 RVA: 0x00095705 File Offset: 0x00093905
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

		// Token: 0x1700147F RID: 5247
		// (get) Token: 0x0600671A RID: 26394 RVA: 0x00095728 File Offset: 0x00093928
		// (set) Token: 0x0600671B RID: 26395 RVA: 0x00095761 File Offset: 0x00093961
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

		// Token: 0x17001480 RID: 5248
		// (get) Token: 0x0600671C RID: 26396 RVA: 0x00095784 File Offset: 0x00093984
		// (set) Token: 0x0600671D RID: 26397 RVA: 0x000957BD File Offset: 0x000939BD
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

		// Token: 0x17001481 RID: 5249
		// (get) Token: 0x0600671E RID: 26398 RVA: 0x000957E0 File Offset: 0x000939E0
		// (set) Token: 0x0600671F RID: 26399 RVA: 0x00095819 File Offset: 0x00093A19
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

		// Token: 0x17001482 RID: 5250
		// (get) Token: 0x06006720 RID: 26400 RVA: 0x0009583C File Offset: 0x00093A3C
		// (set) Token: 0x06006721 RID: 26401 RVA: 0x00095875 File Offset: 0x00093A75
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

		// Token: 0x17001483 RID: 5251
		// (get) Token: 0x06006722 RID: 26402 RVA: 0x00095898 File Offset: 0x00093A98
		// (set) Token: 0x06006723 RID: 26403 RVA: 0x000958D1 File Offset: 0x00093AD1
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

		// Token: 0x17001484 RID: 5252
		// (get) Token: 0x06006724 RID: 26404 RVA: 0x000958F4 File Offset: 0x00093AF4
		// (set) Token: 0x06006725 RID: 26405 RVA: 0x0009592D File Offset: 0x00093B2D
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

		// Token: 0x17001485 RID: 5253
		// (get) Token: 0x06006726 RID: 26406 RVA: 0x00095950 File Offset: 0x00093B50
		// (set) Token: 0x06006727 RID: 26407 RVA: 0x00095989 File Offset: 0x00093B89
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

		// Token: 0x17001486 RID: 5254
		// (get) Token: 0x06006728 RID: 26408 RVA: 0x000959AC File Offset: 0x00093BAC
		// (set) Token: 0x06006729 RID: 26409 RVA: 0x000959E5 File Offset: 0x00093BE5
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

		// Token: 0x17001487 RID: 5255
		// (get) Token: 0x0600672A RID: 26410 RVA: 0x00095A08 File Offset: 0x00093C08
		// (set) Token: 0x0600672B RID: 26411 RVA: 0x00095A41 File Offset: 0x00093C41
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

		// Token: 0x17001488 RID: 5256
		// (get) Token: 0x0600672C RID: 26412 RVA: 0x00095A64 File Offset: 0x00093C64
		// (set) Token: 0x0600672D RID: 26413 RVA: 0x00095A9D File Offset: 0x00093C9D
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

		// Token: 0x17001489 RID: 5257
		// (get) Token: 0x0600672E RID: 26414 RVA: 0x00095AC0 File Offset: 0x00093CC0
		// (set) Token: 0x0600672F RID: 26415 RVA: 0x00095AF9 File Offset: 0x00093CF9
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

		// Token: 0x1700148A RID: 5258
		// (get) Token: 0x06006730 RID: 26416 RVA: 0x00095B1C File Offset: 0x00093D1C
		// (set) Token: 0x06006731 RID: 26417 RVA: 0x00095B55 File Offset: 0x00093D55
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

		// Token: 0x1700148B RID: 5259
		// (get) Token: 0x06006732 RID: 26418 RVA: 0x00095B78 File Offset: 0x00093D78
		// (set) Token: 0x06006733 RID: 26419 RVA: 0x00095BB1 File Offset: 0x00093DB1
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

		// Token: 0x1700148C RID: 5260
		// (get) Token: 0x06006734 RID: 26420 RVA: 0x00095BD4 File Offset: 0x00093DD4
		// (set) Token: 0x06006735 RID: 26421 RVA: 0x00095C0D File Offset: 0x00093E0D
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

		// Token: 0x1700148D RID: 5261
		// (get) Token: 0x06006736 RID: 26422 RVA: 0x00095C30 File Offset: 0x00093E30
		// (set) Token: 0x06006737 RID: 26423 RVA: 0x00095C69 File Offset: 0x00093E69
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

		// Token: 0x1700148E RID: 5262
		// (get) Token: 0x06006738 RID: 26424 RVA: 0x00095C8C File Offset: 0x00093E8C
		// (set) Token: 0x06006739 RID: 26425 RVA: 0x00095CC5 File Offset: 0x00093EC5
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

		// Token: 0x1700148F RID: 5263
		// (get) Token: 0x0600673A RID: 26426 RVA: 0x00095CE8 File Offset: 0x00093EE8
		// (set) Token: 0x0600673B RID: 26427 RVA: 0x00095D21 File Offset: 0x00093F21
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

		// Token: 0x17001490 RID: 5264
		// (get) Token: 0x0600673C RID: 26428 RVA: 0x00095D44 File Offset: 0x00093F44
		// (set) Token: 0x0600673D RID: 26429 RVA: 0x00095D7D File Offset: 0x00093F7D
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

		// Token: 0x17001491 RID: 5265
		// (get) Token: 0x0600673E RID: 26430 RVA: 0x00095DA0 File Offset: 0x00093FA0
		// (set) Token: 0x0600673F RID: 26431 RVA: 0x00095DD9 File Offset: 0x00093FD9
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

		// Token: 0x17001492 RID: 5266
		// (get) Token: 0x06006740 RID: 26432 RVA: 0x00095DFC File Offset: 0x00093FFC
		// (set) Token: 0x06006741 RID: 26433 RVA: 0x00095E35 File Offset: 0x00094035
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

		// Token: 0x17001493 RID: 5267
		// (get) Token: 0x06006742 RID: 26434 RVA: 0x00095E58 File Offset: 0x00094058
		// (set) Token: 0x06006743 RID: 26435 RVA: 0x00095E91 File Offset: 0x00094091
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

		// Token: 0x17001494 RID: 5268
		// (get) Token: 0x06006744 RID: 26436 RVA: 0x00095EB4 File Offset: 0x000940B4
		// (set) Token: 0x06006745 RID: 26437 RVA: 0x00095EED File Offset: 0x000940ED
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

		// Token: 0x17001495 RID: 5269
		// (get) Token: 0x06006746 RID: 26438 RVA: 0x00095F10 File Offset: 0x00094110
		// (set) Token: 0x06006747 RID: 26439 RVA: 0x00095F49 File Offset: 0x00094149
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

		// Token: 0x17001496 RID: 5270
		// (get) Token: 0x06006748 RID: 26440 RVA: 0x00095F6C File Offset: 0x0009416C
		// (set) Token: 0x06006749 RID: 26441 RVA: 0x00095FA5 File Offset: 0x000941A5
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

		// Token: 0x17001497 RID: 5271
		// (get) Token: 0x0600674A RID: 26442 RVA: 0x00095FC8 File Offset: 0x000941C8
		// (set) Token: 0x0600674B RID: 26443 RVA: 0x00096001 File Offset: 0x00094201
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

		// Token: 0x17001498 RID: 5272
		// (get) Token: 0x0600674C RID: 26444 RVA: 0x00096024 File Offset: 0x00094224
		// (set) Token: 0x0600674D RID: 26445 RVA: 0x0009605D File Offset: 0x0009425D
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

		// Token: 0x17001499 RID: 5273
		// (get) Token: 0x0600674E RID: 26446 RVA: 0x00096080 File Offset: 0x00094280
		// (set) Token: 0x0600674F RID: 26447 RVA: 0x000960B9 File Offset: 0x000942B9
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

		// Token: 0x1700149A RID: 5274
		// (get) Token: 0x06006750 RID: 26448 RVA: 0x000960DC File Offset: 0x000942DC
		// (set) Token: 0x06006751 RID: 26449 RVA: 0x00096115 File Offset: 0x00094315
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

		// Token: 0x1700149B RID: 5275
		// (get) Token: 0x06006752 RID: 26450 RVA: 0x00096138 File Offset: 0x00094338
		// (set) Token: 0x06006753 RID: 26451 RVA: 0x00096171 File Offset: 0x00094371
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

		// Token: 0x1700149C RID: 5276
		// (get) Token: 0x06006754 RID: 26452 RVA: 0x00096194 File Offset: 0x00094394
		// (set) Token: 0x06006755 RID: 26453 RVA: 0x000961CD File Offset: 0x000943CD
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

		// Token: 0x1700149D RID: 5277
		// (get) Token: 0x06006756 RID: 26454 RVA: 0x000961F0 File Offset: 0x000943F0
		// (set) Token: 0x06006757 RID: 26455 RVA: 0x00096229 File Offset: 0x00094429
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

		// Token: 0x1700149E RID: 5278
		// (get) Token: 0x06006758 RID: 26456 RVA: 0x0009624C File Offset: 0x0009444C
		// (set) Token: 0x06006759 RID: 26457 RVA: 0x00096285 File Offset: 0x00094485
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

		// Token: 0x1700149F RID: 5279
		// (get) Token: 0x0600675A RID: 26458 RVA: 0x000962A8 File Offset: 0x000944A8
		// (set) Token: 0x0600675B RID: 26459 RVA: 0x000962E1 File Offset: 0x000944E1
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

		// Token: 0x170014A0 RID: 5280
		// (get) Token: 0x0600675C RID: 26460 RVA: 0x00096304 File Offset: 0x00094504
		// (set) Token: 0x0600675D RID: 26461 RVA: 0x0009633D File Offset: 0x0009453D
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

		// Token: 0x170014A1 RID: 5281
		// (get) Token: 0x0600675E RID: 26462 RVA: 0x00096360 File Offset: 0x00094560
		// (set) Token: 0x0600675F RID: 26463 RVA: 0x00096399 File Offset: 0x00094599
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

		// Token: 0x170014A2 RID: 5282
		// (get) Token: 0x06006760 RID: 26464 RVA: 0x000963BC File Offset: 0x000945BC
		// (set) Token: 0x06006761 RID: 26465 RVA: 0x000963F5 File Offset: 0x000945F5
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

		// Token: 0x170014A3 RID: 5283
		// (get) Token: 0x06006762 RID: 26466 RVA: 0x00096418 File Offset: 0x00094618
		// (set) Token: 0x06006763 RID: 26467 RVA: 0x00096451 File Offset: 0x00094651
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

		// Token: 0x170014A4 RID: 5284
		// (get) Token: 0x06006764 RID: 26468 RVA: 0x00096474 File Offset: 0x00094674
		// (set) Token: 0x06006765 RID: 26469 RVA: 0x000964AD File Offset: 0x000946AD
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

		// Token: 0x170014A5 RID: 5285
		// (get) Token: 0x06006766 RID: 26470 RVA: 0x000964D0 File Offset: 0x000946D0
		// (set) Token: 0x06006767 RID: 26471 RVA: 0x00096509 File Offset: 0x00094709
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

		// Token: 0x170014A6 RID: 5286
		// (get) Token: 0x06006768 RID: 26472 RVA: 0x0009652C File Offset: 0x0009472C
		// (set) Token: 0x06006769 RID: 26473 RVA: 0x00096565 File Offset: 0x00094765
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

		// Token: 0x170014A7 RID: 5287
		// (get) Token: 0x0600676A RID: 26474 RVA: 0x00096588 File Offset: 0x00094788
		// (set) Token: 0x0600676B RID: 26475 RVA: 0x000965C1 File Offset: 0x000947C1
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

		// Token: 0x170014A8 RID: 5288
		// (get) Token: 0x0600676C RID: 26476 RVA: 0x000965E4 File Offset: 0x000947E4
		// (set) Token: 0x0600676D RID: 26477 RVA: 0x0009661D File Offset: 0x0009481D
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

		// Token: 0x170014A9 RID: 5289
		// (get) Token: 0x0600676E RID: 26478 RVA: 0x00096640 File Offset: 0x00094840
		// (set) Token: 0x0600676F RID: 26479 RVA: 0x00096679 File Offset: 0x00094879
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

		// Token: 0x170014AA RID: 5290
		// (get) Token: 0x06006770 RID: 26480 RVA: 0x0009669C File Offset: 0x0009489C
		// (set) Token: 0x06006771 RID: 26481 RVA: 0x000966D5 File Offset: 0x000948D5
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

		// Token: 0x170014AB RID: 5291
		// (get) Token: 0x06006772 RID: 26482 RVA: 0x000966F8 File Offset: 0x000948F8
		// (set) Token: 0x06006773 RID: 26483 RVA: 0x00096731 File Offset: 0x00094931
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

		// Token: 0x170014AC RID: 5292
		// (get) Token: 0x06006774 RID: 26484 RVA: 0x00096754 File Offset: 0x00094954
		// (set) Token: 0x06006775 RID: 26485 RVA: 0x0009678D File Offset: 0x0009498D
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

		// Token: 0x170014AD RID: 5293
		// (get) Token: 0x06006776 RID: 26486 RVA: 0x000967B0 File Offset: 0x000949B0
		// (set) Token: 0x06006777 RID: 26487 RVA: 0x000967E9 File Offset: 0x000949E9
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

		// Token: 0x170014AE RID: 5294
		// (get) Token: 0x06006778 RID: 26488 RVA: 0x0009680C File Offset: 0x00094A0C
		// (set) Token: 0x06006779 RID: 26489 RVA: 0x00096845 File Offset: 0x00094A45
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

		// Token: 0x170014AF RID: 5295
		// (get) Token: 0x0600677A RID: 26490 RVA: 0x00096868 File Offset: 0x00094A68
		// (set) Token: 0x0600677B RID: 26491 RVA: 0x000968A1 File Offset: 0x00094AA1
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

		// Token: 0x170014B0 RID: 5296
		// (get) Token: 0x0600677C RID: 26492 RVA: 0x000968C4 File Offset: 0x00094AC4
		// (set) Token: 0x0600677D RID: 26493 RVA: 0x000968FD File Offset: 0x00094AFD
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

		// Token: 0x170014B1 RID: 5297
		// (get) Token: 0x0600677E RID: 26494 RVA: 0x00096920 File Offset: 0x00094B20
		// (set) Token: 0x0600677F RID: 26495 RVA: 0x00096959 File Offset: 0x00094B59
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

		// Token: 0x170014B2 RID: 5298
		// (get) Token: 0x06006780 RID: 26496 RVA: 0x0009697C File Offset: 0x00094B7C
		// (set) Token: 0x06006781 RID: 26497 RVA: 0x000969B5 File Offset: 0x00094BB5
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

		// Token: 0x170014B3 RID: 5299
		// (get) Token: 0x06006782 RID: 26498 RVA: 0x000969D8 File Offset: 0x00094BD8
		// (set) Token: 0x06006783 RID: 26499 RVA: 0x00096A11 File Offset: 0x00094C11
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

		// Token: 0x170014B4 RID: 5300
		// (get) Token: 0x06006784 RID: 26500 RVA: 0x00096A34 File Offset: 0x00094C34
		// (set) Token: 0x06006785 RID: 26501 RVA: 0x00096A6D File Offset: 0x00094C6D
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

		// Token: 0x170014B5 RID: 5301
		// (get) Token: 0x06006786 RID: 26502 RVA: 0x00096A90 File Offset: 0x00094C90
		// (set) Token: 0x06006787 RID: 26503 RVA: 0x00096AC9 File Offset: 0x00094CC9
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

		// Token: 0x170014B6 RID: 5302
		// (get) Token: 0x06006788 RID: 26504 RVA: 0x00096AEC File Offset: 0x00094CEC
		// (set) Token: 0x06006789 RID: 26505 RVA: 0x00096B25 File Offset: 0x00094D25
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

		// Token: 0x170014B7 RID: 5303
		// (get) Token: 0x0600678A RID: 26506 RVA: 0x00096B48 File Offset: 0x00094D48
		// (set) Token: 0x0600678B RID: 26507 RVA: 0x00096B81 File Offset: 0x00094D81
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

		// Token: 0x170014B8 RID: 5304
		// (get) Token: 0x0600678C RID: 26508 RVA: 0x00096BA4 File Offset: 0x00094DA4
		// (set) Token: 0x0600678D RID: 26509 RVA: 0x00096BDD File Offset: 0x00094DDD
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

		// Token: 0x170014B9 RID: 5305
		// (get) Token: 0x0600678E RID: 26510 RVA: 0x00096C00 File Offset: 0x00094E00
		// (set) Token: 0x0600678F RID: 26511 RVA: 0x00096C39 File Offset: 0x00094E39
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

		// Token: 0x170014BA RID: 5306
		// (get) Token: 0x06006790 RID: 26512 RVA: 0x00096C5C File Offset: 0x00094E5C
		// (set) Token: 0x06006791 RID: 26513 RVA: 0x00096C95 File Offset: 0x00094E95
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

		// Token: 0x170014BB RID: 5307
		// (get) Token: 0x06006792 RID: 26514 RVA: 0x00096CB8 File Offset: 0x00094EB8
		// (set) Token: 0x06006793 RID: 26515 RVA: 0x00096CF1 File Offset: 0x00094EF1
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

		// Token: 0x170014BC RID: 5308
		// (get) Token: 0x06006794 RID: 26516 RVA: 0x00096D14 File Offset: 0x00094F14
		// (set) Token: 0x06006795 RID: 26517 RVA: 0x00096D4D File Offset: 0x00094F4D
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

		// Token: 0x170014BD RID: 5309
		// (get) Token: 0x06006796 RID: 26518 RVA: 0x00096D70 File Offset: 0x00094F70
		// (set) Token: 0x06006797 RID: 26519 RVA: 0x00096DA9 File Offset: 0x00094FA9
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

		// Token: 0x170014BE RID: 5310
		// (get) Token: 0x06006798 RID: 26520 RVA: 0x00096DCC File Offset: 0x00094FCC
		// (set) Token: 0x06006799 RID: 26521 RVA: 0x00096E05 File Offset: 0x00095005
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

		// Token: 0x170014BF RID: 5311
		// (get) Token: 0x0600679A RID: 26522 RVA: 0x00096E28 File Offset: 0x00095028
		// (set) Token: 0x0600679B RID: 26523 RVA: 0x00096E61 File Offset: 0x00095061
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

		// Token: 0x170014C0 RID: 5312
		// (get) Token: 0x0600679C RID: 26524 RVA: 0x00096E84 File Offset: 0x00095084
		// (set) Token: 0x0600679D RID: 26525 RVA: 0x00096EBD File Offset: 0x000950BD
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

		// Token: 0x170014C1 RID: 5313
		// (get) Token: 0x0600679E RID: 26526 RVA: 0x00096EE0 File Offset: 0x000950E0
		// (set) Token: 0x0600679F RID: 26527 RVA: 0x00096F19 File Offset: 0x00095119
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

		// Token: 0x170014C2 RID: 5314
		// (get) Token: 0x060067A0 RID: 26528 RVA: 0x00096F3C File Offset: 0x0009513C
		// (set) Token: 0x060067A1 RID: 26529 RVA: 0x00096F75 File Offset: 0x00095175
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

		// Token: 0x170014C3 RID: 5315
		// (get) Token: 0x060067A2 RID: 26530 RVA: 0x00096F98 File Offset: 0x00095198
		// (set) Token: 0x060067A3 RID: 26531 RVA: 0x00096FD1 File Offset: 0x000951D1
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

		// Token: 0x170014C4 RID: 5316
		// (get) Token: 0x060067A4 RID: 26532 RVA: 0x00096FF4 File Offset: 0x000951F4
		// (set) Token: 0x060067A5 RID: 26533 RVA: 0x0009702D File Offset: 0x0009522D
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

		// Token: 0x170014C5 RID: 5317
		// (get) Token: 0x060067A6 RID: 26534 RVA: 0x00097050 File Offset: 0x00095250
		// (set) Token: 0x060067A7 RID: 26535 RVA: 0x00097089 File Offset: 0x00095289
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

		// Token: 0x170014C6 RID: 5318
		// (get) Token: 0x060067A8 RID: 26536 RVA: 0x000970AC File Offset: 0x000952AC
		// (set) Token: 0x060067A9 RID: 26537 RVA: 0x000970E5 File Offset: 0x000952E5
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

		// Token: 0x170014C7 RID: 5319
		// (get) Token: 0x060067AA RID: 26538 RVA: 0x00097108 File Offset: 0x00095308
		// (set) Token: 0x060067AB RID: 26539 RVA: 0x00097141 File Offset: 0x00095341
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

		// Token: 0x170014C8 RID: 5320
		// (get) Token: 0x060067AC RID: 26540 RVA: 0x00097164 File Offset: 0x00095364
		// (set) Token: 0x060067AD RID: 26541 RVA: 0x0009719D File Offset: 0x0009539D
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

		// Token: 0x170014C9 RID: 5321
		// (get) Token: 0x060067AE RID: 26542 RVA: 0x000971C0 File Offset: 0x000953C0
		// (set) Token: 0x060067AF RID: 26543 RVA: 0x000971F9 File Offset: 0x000953F9
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

		// Token: 0x170014CA RID: 5322
		// (get) Token: 0x060067B0 RID: 26544 RVA: 0x0009721C File Offset: 0x0009541C
		// (set) Token: 0x060067B1 RID: 26545 RVA: 0x00097255 File Offset: 0x00095455
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

		// Token: 0x170014CB RID: 5323
		// (get) Token: 0x060067B2 RID: 26546 RVA: 0x00097278 File Offset: 0x00095478
		// (set) Token: 0x060067B3 RID: 26547 RVA: 0x000972B1 File Offset: 0x000954B1
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

		// Token: 0x170014CC RID: 5324
		// (get) Token: 0x060067B4 RID: 26548 RVA: 0x000972D4 File Offset: 0x000954D4
		// (set) Token: 0x060067B5 RID: 26549 RVA: 0x0009730D File Offset: 0x0009550D
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

		// Token: 0x170014CD RID: 5325
		// (get) Token: 0x060067B6 RID: 26550 RVA: 0x00097330 File Offset: 0x00095530
		// (set) Token: 0x060067B7 RID: 26551 RVA: 0x00097369 File Offset: 0x00095569
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

		// Token: 0x170014CE RID: 5326
		// (get) Token: 0x060067B8 RID: 26552 RVA: 0x0009738C File Offset: 0x0009558C
		// (set) Token: 0x060067B9 RID: 26553 RVA: 0x000973C5 File Offset: 0x000955C5
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

		// Token: 0x170014CF RID: 5327
		// (get) Token: 0x060067BA RID: 26554 RVA: 0x000973E8 File Offset: 0x000955E8
		// (set) Token: 0x060067BB RID: 26555 RVA: 0x00097421 File Offset: 0x00095621
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

		// Token: 0x170014D0 RID: 5328
		// (get) Token: 0x060067BC RID: 26556 RVA: 0x00097444 File Offset: 0x00095644
		// (set) Token: 0x060067BD RID: 26557 RVA: 0x0009747D File Offset: 0x0009567D
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

		// Token: 0x170014D1 RID: 5329
		// (get) Token: 0x060067BE RID: 26558 RVA: 0x000974A0 File Offset: 0x000956A0
		// (set) Token: 0x060067BF RID: 26559 RVA: 0x000974D9 File Offset: 0x000956D9
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

		// Token: 0x170014D2 RID: 5330
		// (get) Token: 0x060067C0 RID: 26560 RVA: 0x000974FC File Offset: 0x000956FC
		// (set) Token: 0x060067C1 RID: 26561 RVA: 0x00097535 File Offset: 0x00095735
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

		// Token: 0x170014D3 RID: 5331
		// (get) Token: 0x060067C2 RID: 26562 RVA: 0x00097558 File Offset: 0x00095758
		// (set) Token: 0x060067C3 RID: 26563 RVA: 0x00097591 File Offset: 0x00095791
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

		// Token: 0x170014D4 RID: 5332
		// (get) Token: 0x060067C4 RID: 26564 RVA: 0x000975B4 File Offset: 0x000957B4
		// (set) Token: 0x060067C5 RID: 26565 RVA: 0x000975ED File Offset: 0x000957ED
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

		// Token: 0x170014D5 RID: 5333
		// (get) Token: 0x060067C6 RID: 26566 RVA: 0x00097610 File Offset: 0x00095810
		// (set) Token: 0x060067C7 RID: 26567 RVA: 0x00097649 File Offset: 0x00095849
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

		// Token: 0x170014D6 RID: 5334
		// (get) Token: 0x060067C8 RID: 26568 RVA: 0x0009766C File Offset: 0x0009586C
		// (set) Token: 0x060067C9 RID: 26569 RVA: 0x000976A5 File Offset: 0x000958A5
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

		// Token: 0x170014D7 RID: 5335
		// (get) Token: 0x060067CA RID: 26570 RVA: 0x000976C8 File Offset: 0x000958C8
		// (set) Token: 0x060067CB RID: 26571 RVA: 0x00097701 File Offset: 0x00095901
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

		// Token: 0x170014D8 RID: 5336
		// (get) Token: 0x060067CC RID: 26572 RVA: 0x00097724 File Offset: 0x00095924
		// (set) Token: 0x060067CD RID: 26573 RVA: 0x0009775D File Offset: 0x0009595D
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

		// Token: 0x170014D9 RID: 5337
		// (get) Token: 0x060067CE RID: 26574 RVA: 0x00097780 File Offset: 0x00095980
		// (set) Token: 0x060067CF RID: 26575 RVA: 0x000977B9 File Offset: 0x000959B9
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

		// Token: 0x170014DA RID: 5338
		// (get) Token: 0x060067D0 RID: 26576 RVA: 0x000977DC File Offset: 0x000959DC
		// (set) Token: 0x060067D1 RID: 26577 RVA: 0x00097815 File Offset: 0x00095A15
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

		// Token: 0x170014DB RID: 5339
		// (get) Token: 0x060067D2 RID: 26578 RVA: 0x00097838 File Offset: 0x00095A38
		// (set) Token: 0x060067D3 RID: 26579 RVA: 0x00097871 File Offset: 0x00095A71
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

		// Token: 0x170014DC RID: 5340
		// (get) Token: 0x060067D4 RID: 26580 RVA: 0x00097894 File Offset: 0x00095A94
		// (set) Token: 0x060067D5 RID: 26581 RVA: 0x000978CD File Offset: 0x00095ACD
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

		// Token: 0x170014DD RID: 5341
		// (get) Token: 0x060067D6 RID: 26582 RVA: 0x000978F0 File Offset: 0x00095AF0
		// (set) Token: 0x060067D7 RID: 26583 RVA: 0x00097929 File Offset: 0x00095B29
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

		// Token: 0x170014DE RID: 5342
		// (get) Token: 0x060067D8 RID: 26584 RVA: 0x0009794C File Offset: 0x00095B4C
		// (set) Token: 0x060067D9 RID: 26585 RVA: 0x00097985 File Offset: 0x00095B85
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

		// Token: 0x170014DF RID: 5343
		// (get) Token: 0x060067DA RID: 26586 RVA: 0x000979A8 File Offset: 0x00095BA8
		// (set) Token: 0x060067DB RID: 26587 RVA: 0x000979E1 File Offset: 0x00095BE1
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

		// Token: 0x170014E0 RID: 5344
		// (get) Token: 0x060067DC RID: 26588 RVA: 0x00097A04 File Offset: 0x00095C04
		// (set) Token: 0x060067DD RID: 26589 RVA: 0x00097A3D File Offset: 0x00095C3D
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

		// Token: 0x170014E1 RID: 5345
		// (get) Token: 0x060067DE RID: 26590 RVA: 0x00097A60 File Offset: 0x00095C60
		// (set) Token: 0x060067DF RID: 26591 RVA: 0x00097A99 File Offset: 0x00095C99
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

		// Token: 0x170014E2 RID: 5346
		// (get) Token: 0x060067E0 RID: 26592 RVA: 0x00097ABC File Offset: 0x00095CBC
		// (set) Token: 0x060067E1 RID: 26593 RVA: 0x00097AF5 File Offset: 0x00095CF5
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

		// Token: 0x170014E3 RID: 5347
		// (get) Token: 0x060067E2 RID: 26594 RVA: 0x00097B18 File Offset: 0x00095D18
		// (set) Token: 0x060067E3 RID: 26595 RVA: 0x00097B51 File Offset: 0x00095D51
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

		// Token: 0x170014E4 RID: 5348
		// (get) Token: 0x060067E4 RID: 26596 RVA: 0x00097B74 File Offset: 0x00095D74
		// (set) Token: 0x060067E5 RID: 26597 RVA: 0x00097BAD File Offset: 0x00095DAD
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

		// Token: 0x170014E5 RID: 5349
		// (get) Token: 0x060067E6 RID: 26598 RVA: 0x00097BD0 File Offset: 0x00095DD0
		// (set) Token: 0x060067E7 RID: 26599 RVA: 0x00097C09 File Offset: 0x00095E09
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

		// Token: 0x170014E6 RID: 5350
		// (get) Token: 0x060067E8 RID: 26600 RVA: 0x00097C2C File Offset: 0x00095E2C
		// (set) Token: 0x060067E9 RID: 26601 RVA: 0x00097C65 File Offset: 0x00095E65
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

		// Token: 0x170014E7 RID: 5351
		// (get) Token: 0x060067EA RID: 26602 RVA: 0x00097C88 File Offset: 0x00095E88
		// (set) Token: 0x060067EB RID: 26603 RVA: 0x00097CC1 File Offset: 0x00095EC1
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

		// Token: 0x170014E8 RID: 5352
		// (get) Token: 0x060067EC RID: 26604 RVA: 0x00097CE4 File Offset: 0x00095EE4
		// (set) Token: 0x060067ED RID: 26605 RVA: 0x00097D1D File Offset: 0x00095F1D
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

		// Token: 0x170014E9 RID: 5353
		// (get) Token: 0x060067EE RID: 26606 RVA: 0x00097D40 File Offset: 0x00095F40
		// (set) Token: 0x060067EF RID: 26607 RVA: 0x00097D79 File Offset: 0x00095F79
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

		// Token: 0x170014EA RID: 5354
		// (get) Token: 0x060067F0 RID: 26608 RVA: 0x00097D9C File Offset: 0x00095F9C
		// (set) Token: 0x060067F1 RID: 26609 RVA: 0x00097DD5 File Offset: 0x00095FD5
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

		// Token: 0x170014EB RID: 5355
		// (get) Token: 0x060067F2 RID: 26610 RVA: 0x00097DF8 File Offset: 0x00095FF8
		// (set) Token: 0x060067F3 RID: 26611 RVA: 0x00097E31 File Offset: 0x00096031
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

		// Token: 0x170014EC RID: 5356
		// (get) Token: 0x060067F4 RID: 26612 RVA: 0x00097E54 File Offset: 0x00096054
		// (set) Token: 0x060067F5 RID: 26613 RVA: 0x00097E8D File Offset: 0x0009608D
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

		// Token: 0x170014ED RID: 5357
		// (get) Token: 0x060067F6 RID: 26614 RVA: 0x00097EB0 File Offset: 0x000960B0
		// (set) Token: 0x060067F7 RID: 26615 RVA: 0x00097EE9 File Offset: 0x000960E9
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

		// Token: 0x170014EE RID: 5358
		// (get) Token: 0x060067F8 RID: 26616 RVA: 0x00097F0C File Offset: 0x0009610C
		// (set) Token: 0x060067F9 RID: 26617 RVA: 0x00097F45 File Offset: 0x00096145
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

		// Token: 0x060067FA RID: 26618
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetReduceMax(float InReduceMax);

		// Token: 0x060067FB RID: 26619
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetElementPowerMax(float InElementPowerMax);

		// Token: 0x060067FC RID: 26620 RVA: 0x00097F66 File Offset: 0x00096166
		public void SetAttributeValue(int AttributeType, float BaseValue, float CurrentValue)
		{
			UBaseAttributeSet.__SetAttributeValue_Internal(base.NativePtr, AttributeType, BaseValue, CurrentValue);
		}

		// Token: 0x060067FD RID: 26621
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetAttackSpeedMax(float InMaxSpeed);

		// Token: 0x060067FE RID: 26622 RVA: 0x00097F76 File Offset: 0x00096176
		[NullableContext(2)]
		public bool GetAttributeData(int AttributeType, ref FGameplayAttributeData AttributeData)
		{
			return UBaseAttributeSet.__GetAttributeData_Internal(base.NativePtr, AttributeType, (AttributeData ?? new FGameplayAttributeData()).NativePtr);
		}

		// Token: 0x060067FF RID: 26623 RVA: 0x00097F94 File Offset: 0x00096194
		public float GetAttributeCurrentValueById(int AttributeType)
		{
			return UBaseAttributeSet.__GetAttributeCurrentValueById_Internal(base.NativePtr, AttributeType);
		}

		// Token: 0x06006800 RID: 26624 RVA: 0x00097FA2 File Offset: 0x000961A2
		public float GetAttributeBaseValueById(int AttributeType)
		{
			return UBaseAttributeSet.__GetAttributeBaseValueById_Internal(base.NativePtr, AttributeType);
		}

		// Token: 0x06006801 RID: 26625 RVA: 0x00097FB0 File Offset: 0x000961B0
		[NullableContext(2)]
		public bool CopyAllAttribute(UBaseAttributeSet AttributeSet)
		{
			return UBaseAttributeSet.__CopyAllAttribute_Internal(base.NativePtr, (AttributeSet != null) ? AttributeSet.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06006802 RID: 26626
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAttributeValue_Internal(IntPtr @this, int AttributeType, float BaseValue, float CurrentValue);

		// Token: 0x06006803 RID: 26627
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetAttributeData_Internal(IntPtr @this, int AttributeType, IntPtr AttributeData);

		// Token: 0x06006804 RID: 26628
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetAttributeCurrentValueById_Internal(IntPtr @this, int AttributeType);

		// Token: 0x06006805 RID: 26629
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetAttributeBaseValueById_Internal(IntPtr @this, int AttributeType);

		// Token: 0x06006806 RID: 26630
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __CopyAllAttribute_Internal(IntPtr @this, IntPtr AttributeSet);

		// Token: 0x06006807 RID: 26631 RVA: 0x00097FCD File Offset: 0x000961CD
		static UBaseAttributeSet()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGAS.BaseAttributeSet");
		}

		// Token: 0x06006808 RID: 26632 RVA: 0x00097FDB File Offset: 0x000961DB
		protected UBaseAttributeSet(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002B65 RID: 11109
		public new const string __ObjectPath = "/Script/KuroGAS.BaseAttributeSet";

		// Token: 0x04002B66 RID: 11110
		private static IntPtr _ClassPtr;

		// Token: 0x04002B67 RID: 11111
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04002B68 RID: 11112
		internal static int __PropertyOffset_Lv;

		// Token: 0x04002B69 RID: 11113
		[Nullable(2)]
		private FGameplayAttributeData _Lv;

		// Token: 0x04002B6A RID: 11114
		internal static int __PropertyOffset_LifeMax;

		// Token: 0x04002B6B RID: 11115
		[Nullable(2)]
		private FGameplayAttributeData _LifeMax;

		// Token: 0x04002B6C RID: 11116
		internal static int __PropertyOffset_Life;

		// Token: 0x04002B6D RID: 11117
		[Nullable(2)]
		private FGameplayAttributeData _Life;

		// Token: 0x04002B6E RID: 11118
		internal static int __PropertyOffset_Sheild;

		// Token: 0x04002B6F RID: 11119
		[Nullable(2)]
		private FGameplayAttributeData _Sheild;

		// Token: 0x04002B70 RID: 11120
		internal static int __PropertyOffset_SheildDamageChange;

		// Token: 0x04002B71 RID: 11121
		[Nullable(2)]
		private FGameplayAttributeData _SheildDamageChange;

		// Token: 0x04002B72 RID: 11122
		internal static int __PropertyOffset_SheildDamageReduce;

		// Token: 0x04002B73 RID: 11123
		[Nullable(2)]
		private FGameplayAttributeData _SheildDamageReduce;

		// Token: 0x04002B74 RID: 11124
		internal static int __PropertyOffset_Atk;

		// Token: 0x04002B75 RID: 11125
		[Nullable(2)]
		private FGameplayAttributeData _Atk;

		// Token: 0x04002B76 RID: 11126
		internal static int __PropertyOffset_Crit;

		// Token: 0x04002B77 RID: 11127
		[Nullable(2)]
		private FGameplayAttributeData _Crit;

		// Token: 0x04002B78 RID: 11128
		internal static int __PropertyOffset_CritDamage;

		// Token: 0x04002B79 RID: 11129
		[Nullable(2)]
		private FGameplayAttributeData _CritDamage;

		// Token: 0x04002B7A RID: 11130
		internal static int __PropertyOffset_Def;

		// Token: 0x04002B7B RID: 11131
		[Nullable(2)]
		private FGameplayAttributeData _Def;

		// Token: 0x04002B7C RID: 11132
		internal static int __PropertyOffset_EnergyEfficiency;

		// Token: 0x04002B7D RID: 11133
		[Nullable(2)]
		private FGameplayAttributeData _EnergyEfficiency;

		// Token: 0x04002B7E RID: 11134
		internal static int __PropertyOffset_CDReduse;

		// Token: 0x04002B7F RID: 11135
		[Nullable(2)]
		private FGameplayAttributeData _CDReduse;

		// Token: 0x04002B80 RID: 11136
		internal static int __PropertyOffset_ReactionEfficiency;

		// Token: 0x04002B81 RID: 11137
		[Nullable(2)]
		private FGameplayAttributeData _ReactionEfficiency;

		// Token: 0x04002B82 RID: 11138
		internal static int __PropertyOffset_DamageChangeNormalSkill;

		// Token: 0x04002B83 RID: 11139
		[Nullable(2)]
		private FGameplayAttributeData _DamageChangeNormalSkill;

		// Token: 0x04002B84 RID: 11140
		internal static int __PropertyOffset_DamageChange;

		// Token: 0x04002B85 RID: 11141
		[Nullable(2)]
		private FGameplayAttributeData _DamageChange;

		// Token: 0x04002B86 RID: 11142
		internal static int __PropertyOffset_DamageReduce;

		// Token: 0x04002B87 RID: 11143
		[Nullable(2)]
		private FGameplayAttributeData _DamageReduce;

		// Token: 0x04002B88 RID: 11144
		internal static int __PropertyOffset_DamageChangeAuto;

		// Token: 0x04002B89 RID: 11145
		[Nullable(2)]
		private FGameplayAttributeData _DamageChangeAuto;

		// Token: 0x04002B8A RID: 11146
		internal static int __PropertyOffset_DamageChangeCast;

		// Token: 0x04002B8B RID: 11147
		[Nullable(2)]
		private FGameplayAttributeData _DamageChangeCast;

		// Token: 0x04002B8C RID: 11148
		internal static int __PropertyOffset_DamageChangeUltra;

		// Token: 0x04002B8D RID: 11149
		[Nullable(2)]
		private FGameplayAttributeData _DamageChangeUltra;

		// Token: 0x04002B8E RID: 11150
		internal static int __PropertyOffset_DamageChangeQTE;

		// Token: 0x04002B8F RID: 11151
		[Nullable(2)]
		private FGameplayAttributeData _DamageChangeQTE;

		// Token: 0x04002B90 RID: 11152
		internal static int __PropertyOffset_DamageChangePhys;

		// Token: 0x04002B91 RID: 11153
		[Nullable(2)]
		private FGameplayAttributeData _DamageChangePhys;

		// Token: 0x04002B92 RID: 11154
		internal static int __PropertyOffset_DamageChangeElement1;

		// Token: 0x04002B93 RID: 11155
		[Nullable(2)]
		private FGameplayAttributeData _DamageChangeElement1;

		// Token: 0x04002B94 RID: 11156
		internal static int __PropertyOffset_DamageChangeElement2;

		// Token: 0x04002B95 RID: 11157
		[Nullable(2)]
		private FGameplayAttributeData _DamageChangeElement2;

		// Token: 0x04002B96 RID: 11158
		internal static int __PropertyOffset_DamageChangeElement3;

		// Token: 0x04002B97 RID: 11159
		[Nullable(2)]
		private FGameplayAttributeData _DamageChangeElement3;

		// Token: 0x04002B98 RID: 11160
		internal static int __PropertyOffset_DamageChangeElement4;

		// Token: 0x04002B99 RID: 11161
		[Nullable(2)]
		private FGameplayAttributeData _DamageChangeElement4;

		// Token: 0x04002B9A RID: 11162
		internal static int __PropertyOffset_DamageChangeElement5;

		// Token: 0x04002B9B RID: 11163
		[Nullable(2)]
		private FGameplayAttributeData _DamageChangeElement5;

		// Token: 0x04002B9C RID: 11164
		internal static int __PropertyOffset_DamageChangeElement6;

		// Token: 0x04002B9D RID: 11165
		[Nullable(2)]
		private FGameplayAttributeData _DamageChangeElement6;

		// Token: 0x04002B9E RID: 11166
		internal static int __PropertyOffset_DamageResistancePhys;

		// Token: 0x04002B9F RID: 11167
		[Nullable(2)]
		private FGameplayAttributeData _DamageResistancePhys;

		// Token: 0x04002BA0 RID: 11168
		internal static int __PropertyOffset_DamageResistanceElement1;

		// Token: 0x04002BA1 RID: 11169
		[Nullable(2)]
		private FGameplayAttributeData _DamageResistanceElement1;

		// Token: 0x04002BA2 RID: 11170
		internal static int __PropertyOffset_DamageResistanceElement2;

		// Token: 0x04002BA3 RID: 11171
		[Nullable(2)]
		private FGameplayAttributeData _DamageResistanceElement2;

		// Token: 0x04002BA4 RID: 11172
		internal static int __PropertyOffset_DamageResistanceElement3;

		// Token: 0x04002BA5 RID: 11173
		[Nullable(2)]
		private FGameplayAttributeData _DamageResistanceElement3;

		// Token: 0x04002BA6 RID: 11174
		internal static int __PropertyOffset_DamageResistanceElement4;

		// Token: 0x04002BA7 RID: 11175
		[Nullable(2)]
		private FGameplayAttributeData _DamageResistanceElement4;

		// Token: 0x04002BA8 RID: 11176
		internal static int __PropertyOffset_DamageResistanceElement5;

		// Token: 0x04002BA9 RID: 11177
		[Nullable(2)]
		private FGameplayAttributeData _DamageResistanceElement5;

		// Token: 0x04002BAA RID: 11178
		internal static int __PropertyOffset_DamageResistanceElement6;

		// Token: 0x04002BAB RID: 11179
		[Nullable(2)]
		private FGameplayAttributeData _DamageResistanceElement6;

		// Token: 0x04002BAC RID: 11180
		internal static int __PropertyOffset_HealChange;

		// Token: 0x04002BAD RID: 11181
		[Nullable(2)]
		private FGameplayAttributeData _HealChange;

		// Token: 0x04002BAE RID: 11182
		internal static int __PropertyOffset_HealedChange;

		// Token: 0x04002BAF RID: 11183
		[Nullable(2)]
		private FGameplayAttributeData _HealedChange;

		// Token: 0x04002BB0 RID: 11184
		internal static int __PropertyOffset_DamageReducePhys;

		// Token: 0x04002BB1 RID: 11185
		[Nullable(2)]
		private FGameplayAttributeData _DamageReducePhys;

		// Token: 0x04002BB2 RID: 11186
		internal static int __PropertyOffset_DamageReduceElement1;

		// Token: 0x04002BB3 RID: 11187
		[Nullable(2)]
		private FGameplayAttributeData _DamageReduceElement1;

		// Token: 0x04002BB4 RID: 11188
		internal static int __PropertyOffset_DamageReduceElement2;

		// Token: 0x04002BB5 RID: 11189
		[Nullable(2)]
		private FGameplayAttributeData _DamageReduceElement2;

		// Token: 0x04002BB6 RID: 11190
		internal static int __PropertyOffset_DamageReduceElement3;

		// Token: 0x04002BB7 RID: 11191
		[Nullable(2)]
		private FGameplayAttributeData _DamageReduceElement3;

		// Token: 0x04002BB8 RID: 11192
		internal static int __PropertyOffset_DamageReduceElement4;

		// Token: 0x04002BB9 RID: 11193
		[Nullable(2)]
		private FGameplayAttributeData _DamageReduceElement4;

		// Token: 0x04002BBA RID: 11194
		internal static int __PropertyOffset_DamageReduceElement5;

		// Token: 0x04002BBB RID: 11195
		[Nullable(2)]
		private FGameplayAttributeData _DamageReduceElement5;

		// Token: 0x04002BBC RID: 11196
		internal static int __PropertyOffset_DamageReduceElement6;

		// Token: 0x04002BBD RID: 11197
		[Nullable(2)]
		private FGameplayAttributeData _DamageReduceElement6;

		// Token: 0x04002BBE RID: 11198
		internal static int __PropertyOffset_ReactionChange1;

		// Token: 0x04002BBF RID: 11199
		[Nullable(2)]
		private FGameplayAttributeData _ReactionChange1;

		// Token: 0x04002BC0 RID: 11200
		internal static int __PropertyOffset_ReactionChange2;

		// Token: 0x04002BC1 RID: 11201
		[Nullable(2)]
		private FGameplayAttributeData _ReactionChange2;

		// Token: 0x04002BC2 RID: 11202
		internal static int __PropertyOffset_ReactionChange3;

		// Token: 0x04002BC3 RID: 11203
		[Nullable(2)]
		private FGameplayAttributeData _ReactionChange3;

		// Token: 0x04002BC4 RID: 11204
		internal static int __PropertyOffset_ReactionChange4;

		// Token: 0x04002BC5 RID: 11205
		[Nullable(2)]
		private FGameplayAttributeData _ReactionChange4;

		// Token: 0x04002BC6 RID: 11206
		internal static int __PropertyOffset_ReactionChange5;

		// Token: 0x04002BC7 RID: 11207
		[Nullable(2)]
		private FGameplayAttributeData _ReactionChange5;

		// Token: 0x04002BC8 RID: 11208
		internal static int __PropertyOffset_ReactionChange6;

		// Token: 0x04002BC9 RID: 11209
		[Nullable(2)]
		private FGameplayAttributeData _ReactionChange6;

		// Token: 0x04002BCA RID: 11210
		internal static int __PropertyOffset_ReactionChange7;

		// Token: 0x04002BCB RID: 11211
		[Nullable(2)]
		private FGameplayAttributeData _ReactionChange7;

		// Token: 0x04002BCC RID: 11212
		internal static int __PropertyOffset_ReactionChange8;

		// Token: 0x04002BCD RID: 11213
		[Nullable(2)]
		private FGameplayAttributeData _ReactionChange8;

		// Token: 0x04002BCE RID: 11214
		internal static int __PropertyOffset_ReactionChange9;

		// Token: 0x04002BCF RID: 11215
		[Nullable(2)]
		private FGameplayAttributeData _ReactionChange9;

		// Token: 0x04002BD0 RID: 11216
		internal static int __PropertyOffset_ReactionChange10;

		// Token: 0x04002BD1 RID: 11217
		[Nullable(2)]
		private FGameplayAttributeData _ReactionChange10;

		// Token: 0x04002BD2 RID: 11218
		internal static int __PropertyOffset_ReactionChange11;

		// Token: 0x04002BD3 RID: 11219
		[Nullable(2)]
		private FGameplayAttributeData _ReactionChange11;

		// Token: 0x04002BD4 RID: 11220
		internal static int __PropertyOffset_ReactionChange12;

		// Token: 0x04002BD5 RID: 11221
		[Nullable(2)]
		private FGameplayAttributeData _ReactionChange12;

		// Token: 0x04002BD6 RID: 11222
		internal static int __PropertyOffset_ReactionChange13;

		// Token: 0x04002BD7 RID: 11223
		[Nullable(2)]
		private FGameplayAttributeData _ReactionChange13;

		// Token: 0x04002BD8 RID: 11224
		internal static int __PropertyOffset_ReactionChange14;

		// Token: 0x04002BD9 RID: 11225
		[Nullable(2)]
		private FGameplayAttributeData _ReactionChange14;

		// Token: 0x04002BDA RID: 11226
		internal static int __PropertyOffset_ReactionChange15;

		// Token: 0x04002BDB RID: 11227
		[Nullable(2)]
		private FGameplayAttributeData _ReactionChange15;

		// Token: 0x04002BDC RID: 11228
		internal static int __PropertyOffset_EnergyMax;

		// Token: 0x04002BDD RID: 11229
		[Nullable(2)]
		private FGameplayAttributeData _EnergyMax;

		// Token: 0x04002BDE RID: 11230
		internal static int __PropertyOffset_Energy;

		// Token: 0x04002BDF RID: 11231
		[Nullable(2)]
		private FGameplayAttributeData _Energy;

		// Token: 0x04002BE0 RID: 11232
		internal static int __PropertyOffset_SpecialEnergy1Max;

		// Token: 0x04002BE1 RID: 11233
		[Nullable(2)]
		private FGameplayAttributeData _SpecialEnergy1Max;

		// Token: 0x04002BE2 RID: 11234
		internal static int __PropertyOffset_SpecialEnergy1;

		// Token: 0x04002BE3 RID: 11235
		[Nullable(2)]
		private FGameplayAttributeData _SpecialEnergy1;

		// Token: 0x04002BE4 RID: 11236
		internal static int __PropertyOffset_SpecialEnergy2Max;

		// Token: 0x04002BE5 RID: 11237
		[Nullable(2)]
		private FGameplayAttributeData _SpecialEnergy2Max;

		// Token: 0x04002BE6 RID: 11238
		internal static int __PropertyOffset_SpecialEnergy2;

		// Token: 0x04002BE7 RID: 11239
		[Nullable(2)]
		private FGameplayAttributeData _SpecialEnergy2;

		// Token: 0x04002BE8 RID: 11240
		internal static int __PropertyOffset_SpecialEnergy3Max;

		// Token: 0x04002BE9 RID: 11241
		[Nullable(2)]
		private FGameplayAttributeData _SpecialEnergy3Max;

		// Token: 0x04002BEA RID: 11242
		internal static int __PropertyOffset_SpecialEnergy3;

		// Token: 0x04002BEB RID: 11243
		[Nullable(2)]
		private FGameplayAttributeData _SpecialEnergy3;

		// Token: 0x04002BEC RID: 11244
		internal static int __PropertyOffset_SpecialEnergy4Max;

		// Token: 0x04002BED RID: 11245
		[Nullable(2)]
		private FGameplayAttributeData _SpecialEnergy4Max;

		// Token: 0x04002BEE RID: 11246
		internal static int __PropertyOffset_SpecialEnergy4;

		// Token: 0x04002BEF RID: 11247
		[Nullable(2)]
		private FGameplayAttributeData _SpecialEnergy4;

		// Token: 0x04002BF0 RID: 11248
		internal static int __PropertyOffset_StrengthMax;

		// Token: 0x04002BF1 RID: 11249
		[Nullable(2)]
		private FGameplayAttributeData _StrengthMax;

		// Token: 0x04002BF2 RID: 11250
		internal static int __PropertyOffset_Strength;

		// Token: 0x04002BF3 RID: 11251
		[Nullable(2)]
		private FGameplayAttributeData _Strength;

		// Token: 0x04002BF4 RID: 11252
		internal static int __PropertyOffset_StrengthRecover;

		// Token: 0x04002BF5 RID: 11253
		[Nullable(2)]
		private FGameplayAttributeData _StrengthRecover;

		// Token: 0x04002BF6 RID: 11254
		internal static int __PropertyOffset_StrengthPunishTime;

		// Token: 0x04002BF7 RID: 11255
		[Nullable(2)]
		private FGameplayAttributeData _StrengthPunishTime;

		// Token: 0x04002BF8 RID: 11256
		internal static int __PropertyOffset_StrengthRun;

		// Token: 0x04002BF9 RID: 11257
		[Nullable(2)]
		private FGameplayAttributeData _StrengthRun;

		// Token: 0x04002BFA RID: 11258
		internal static int __PropertyOffset_StrengthSwim;

		// Token: 0x04002BFB RID: 11259
		[Nullable(2)]
		private FGameplayAttributeData _StrengthSwim;

		// Token: 0x04002BFC RID: 11260
		internal static int __PropertyOffset_StrengthFastSwim;

		// Token: 0x04002BFD RID: 11261
		[Nullable(2)]
		private FGameplayAttributeData _StrengthFastSwim;

		// Token: 0x04002BFE RID: 11262
		internal static int __PropertyOffset_StrengthClimb;

		// Token: 0x04002BFF RID: 11263
		[Nullable(2)]
		private FGameplayAttributeData _StrengthClimb;

		// Token: 0x04002C00 RID: 11264
		internal static int __PropertyOffset_StrengthFastClimb;

		// Token: 0x04002C01 RID: 11265
		[Nullable(2)]
		private FGameplayAttributeData _StrengthFastClimb;

		// Token: 0x04002C02 RID: 11266
		internal static int __PropertyOffset_HardnessMax;

		// Token: 0x04002C03 RID: 11267
		[Nullable(2)]
		private FGameplayAttributeData _HardnessMax;

		// Token: 0x04002C04 RID: 11268
		internal static int __PropertyOffset_Hardness;

		// Token: 0x04002C05 RID: 11269
		[Nullable(2)]
		private FGameplayAttributeData _Hardness;

		// Token: 0x04002C06 RID: 11270
		internal static int __PropertyOffset_HardnessRecover;

		// Token: 0x04002C07 RID: 11271
		[Nullable(2)]
		private FGameplayAttributeData _HardnessRecover;

		// Token: 0x04002C08 RID: 11272
		internal static int __PropertyOffset_HardnessPunishTime;

		// Token: 0x04002C09 RID: 11273
		[Nullable(2)]
		private FGameplayAttributeData _HardnessPunishTime;

		// Token: 0x04002C0A RID: 11274
		internal static int __PropertyOffset_HardnessChange;

		// Token: 0x04002C0B RID: 11275
		[Nullable(2)]
		private FGameplayAttributeData _HardnessChange;

		// Token: 0x04002C0C RID: 11276
		internal static int __PropertyOffset_HardnessReduce;

		// Token: 0x04002C0D RID: 11277
		[Nullable(2)]
		private FGameplayAttributeData _HardnessReduce;

		// Token: 0x04002C0E RID: 11278
		internal static int __PropertyOffset_ToughMax;

		// Token: 0x04002C0F RID: 11279
		[Nullable(2)]
		private FGameplayAttributeData _ToughMax;

		// Token: 0x04002C10 RID: 11280
		internal static int __PropertyOffset_Tough;

		// Token: 0x04002C11 RID: 11281
		[Nullable(2)]
		private FGameplayAttributeData _Tough;

		// Token: 0x04002C12 RID: 11282
		internal static int __PropertyOffset_ToughRecover;

		// Token: 0x04002C13 RID: 11283
		[Nullable(2)]
		private FGameplayAttributeData _ToughRecover;

		// Token: 0x04002C14 RID: 11284
		internal static int __PropertyOffset_ToughChange;

		// Token: 0x04002C15 RID: 11285
		[Nullable(2)]
		private FGameplayAttributeData _ToughChange;

		// Token: 0x04002C16 RID: 11286
		internal static int __PropertyOffset_ToughReduce;

		// Token: 0x04002C17 RID: 11287
		[Nullable(2)]
		private FGameplayAttributeData _ToughReduce;

		// Token: 0x04002C18 RID: 11288
		internal static int __PropertyOffset_ElementPower1;

		// Token: 0x04002C19 RID: 11289
		[Nullable(2)]
		private FGameplayAttributeData _ElementPower1;

		// Token: 0x04002C1A RID: 11290
		internal static int __PropertyOffset_ElementPower2;

		// Token: 0x04002C1B RID: 11291
		[Nullable(2)]
		private FGameplayAttributeData _ElementPower2;

		// Token: 0x04002C1C RID: 11292
		internal static int __PropertyOffset_ElementPower3;

		// Token: 0x04002C1D RID: 11293
		[Nullable(2)]
		private FGameplayAttributeData _ElementPower3;

		// Token: 0x04002C1E RID: 11294
		internal static int __PropertyOffset_ElementPower4;

		// Token: 0x04002C1F RID: 11295
		[Nullable(2)]
		private FGameplayAttributeData _ElementPower4;

		// Token: 0x04002C20 RID: 11296
		internal static int __PropertyOffset_ElementPower5;

		// Token: 0x04002C21 RID: 11297
		[Nullable(2)]
		private FGameplayAttributeData _ElementPower5;

		// Token: 0x04002C22 RID: 11298
		internal static int __PropertyOffset_ElementPower6;

		// Token: 0x04002C23 RID: 11299
		[Nullable(2)]
		private FGameplayAttributeData _ElementPower6;

		// Token: 0x04002C24 RID: 11300
		internal static int __PropertyOffset_SpecialDamageChange;

		// Token: 0x04002C25 RID: 11301
		[Nullable(2)]
		private FGameplayAttributeData _SpecialDamageChange;

		// Token: 0x04002C26 RID: 11302
		internal static int __PropertyOffset_StrengthFastClimbCost;

		// Token: 0x04002C27 RID: 11303
		[Nullable(2)]
		private FGameplayAttributeData _StrengthFastClimbCost;

		// Token: 0x04002C28 RID: 11304
		internal static int __PropertyOffset_ElementPropertyType;

		// Token: 0x04002C29 RID: 11305
		[Nullable(2)]
		private FGameplayAttributeData _ElementPropertyType;

		// Token: 0x04002C2A RID: 11306
		internal static int __PropertyOffset_WeakTime;

		// Token: 0x04002C2B RID: 11307
		[Nullable(2)]
		private FGameplayAttributeData _WeakTime;

		// Token: 0x04002C2C RID: 11308
		internal static int __PropertyOffset_IgnoreDefRate;

		// Token: 0x04002C2D RID: 11309
		[Nullable(2)]
		private FGameplayAttributeData _IgnoreDefRate;

		// Token: 0x04002C2E RID: 11310
		internal static int __PropertyOffset_IgnoreDamageResistancePhys;

		// Token: 0x04002C2F RID: 11311
		[Nullable(2)]
		private FGameplayAttributeData _IgnoreDamageResistancePhys;

		// Token: 0x04002C30 RID: 11312
		internal static int __PropertyOffset_IgnoreDamageResistanceElement1;

		// Token: 0x04002C31 RID: 11313
		[Nullable(2)]
		private FGameplayAttributeData _IgnoreDamageResistanceElement1;

		// Token: 0x04002C32 RID: 11314
		internal static int __PropertyOffset_IgnoreDamageResistanceElement2;

		// Token: 0x04002C33 RID: 11315
		[Nullable(2)]
		private FGameplayAttributeData _IgnoreDamageResistanceElement2;

		// Token: 0x04002C34 RID: 11316
		internal static int __PropertyOffset_IgnoreDamageResistanceElement3;

		// Token: 0x04002C35 RID: 11317
		[Nullable(2)]
		private FGameplayAttributeData _IgnoreDamageResistanceElement3;

		// Token: 0x04002C36 RID: 11318
		internal static int __PropertyOffset_IgnoreDamageResistanceElement4;

		// Token: 0x04002C37 RID: 11319
		[Nullable(2)]
		private FGameplayAttributeData _IgnoreDamageResistanceElement4;

		// Token: 0x04002C38 RID: 11320
		internal static int __PropertyOffset_IgnoreDamageResistanceElement5;

		// Token: 0x04002C39 RID: 11321
		[Nullable(2)]
		private FGameplayAttributeData _IgnoreDamageResistanceElement5;

		// Token: 0x04002C3A RID: 11322
		internal static int __PropertyOffset_IgnoreDamageResistanceElement6;

		// Token: 0x04002C3B RID: 11323
		[Nullable(2)]
		private FGameplayAttributeData _IgnoreDamageResistanceElement6;

		// Token: 0x04002C3C RID: 11324
		internal static int __PropertyOffset_SkillToughRatio;

		// Token: 0x04002C3D RID: 11325
		[Nullable(2)]
		private FGameplayAttributeData _SkillToughRatio;

		// Token: 0x04002C3E RID: 11326
		internal static int __PropertyOffset_StrengthClimbJump;

		// Token: 0x04002C3F RID: 11327
		[Nullable(2)]
		private FGameplayAttributeData _StrengthClimbJump;

		// Token: 0x04002C40 RID: 11328
		internal static int __PropertyOffset_StrengthGliding;

		// Token: 0x04002C41 RID: 11329
		[Nullable(2)]
		private FGameplayAttributeData _StrengthGliding;

		// Token: 0x04002C42 RID: 11330
		internal static int __PropertyOffset_Mass;

		// Token: 0x04002C43 RID: 11331
		[Nullable(2)]
		private FGameplayAttributeData _Mass;

		// Token: 0x04002C44 RID: 11332
		internal static int __PropertyOffset_BrakingFrictionFactor;

		// Token: 0x04002C45 RID: 11333
		[Nullable(2)]
		private FGameplayAttributeData _BrakingFrictionFactor;

		// Token: 0x04002C46 RID: 11334
		internal static int __PropertyOffset_GravityScale;

		// Token: 0x04002C47 RID: 11335
		[Nullable(2)]
		private FGameplayAttributeData _GravityScale;

		// Token: 0x04002C48 RID: 11336
		internal static int __PropertyOffset_SpeedRatio;

		// Token: 0x04002C49 RID: 11337
		[Nullable(2)]
		private FGameplayAttributeData _SpeedRatio;

		// Token: 0x04002C4A RID: 11338
		internal static int __PropertyOffset_DamageChangePhantom;

		// Token: 0x04002C4B RID: 11339
		[Nullable(2)]
		private FGameplayAttributeData _DamageChangePhantom;

		// Token: 0x04002C4C RID: 11340
		internal static int __PropertyOffset_AutoAttackSpeed;

		// Token: 0x04002C4D RID: 11341
		[Nullable(2)]
		private FGameplayAttributeData _AutoAttackSpeed;

		// Token: 0x04002C4E RID: 11342
		internal static int __PropertyOffset_CastAttackSpeed;

		// Token: 0x04002C4F RID: 11343
		[Nullable(2)]
		private FGameplayAttributeData _CastAttackSpeed;

		// Token: 0x04002C50 RID: 11344
		internal static int __PropertyOffset_StatusBuildUp1Max;

		// Token: 0x04002C51 RID: 11345
		[Nullable(2)]
		private FGameplayAttributeData _StatusBuildUp1Max;

		// Token: 0x04002C52 RID: 11346
		internal static int __PropertyOffset_StatusBuildUp1;

		// Token: 0x04002C53 RID: 11347
		[Nullable(2)]
		private FGameplayAttributeData _StatusBuildUp1;

		// Token: 0x04002C54 RID: 11348
		internal static int __PropertyOffset_StatusBuildUp2Max;

		// Token: 0x04002C55 RID: 11349
		[Nullable(2)]
		private FGameplayAttributeData _StatusBuildUp2Max;

		// Token: 0x04002C56 RID: 11350
		internal static int __PropertyOffset_StatusBuildUp2;

		// Token: 0x04002C57 RID: 11351
		[Nullable(2)]
		private FGameplayAttributeData _StatusBuildUp2;

		// Token: 0x04002C58 RID: 11352
		internal static int __PropertyOffset_StatusBuildUp3Max;

		// Token: 0x04002C59 RID: 11353
		[Nullable(2)]
		private FGameplayAttributeData _StatusBuildUp3Max;

		// Token: 0x04002C5A RID: 11354
		internal static int __PropertyOffset_StatusBuildUp3;

		// Token: 0x04002C5B RID: 11355
		[Nullable(2)]
		private FGameplayAttributeData _StatusBuildUp3;

		// Token: 0x04002C5C RID: 11356
		internal static int __PropertyOffset_StatusBuildUp4Max;

		// Token: 0x04002C5D RID: 11357
		[Nullable(2)]
		private FGameplayAttributeData _StatusBuildUp4Max;

		// Token: 0x04002C5E RID: 11358
		internal static int __PropertyOffset_StatusBuildUp4;

		// Token: 0x04002C5F RID: 11359
		[Nullable(2)]
		private FGameplayAttributeData _StatusBuildUp4;

		// Token: 0x04002C60 RID: 11360
		internal static int __PropertyOffset_StatusBuildUp5Max;

		// Token: 0x04002C61 RID: 11361
		[Nullable(2)]
		private FGameplayAttributeData _StatusBuildUp5Max;

		// Token: 0x04002C62 RID: 11362
		internal static int __PropertyOffset_StatusBuildUp5;

		// Token: 0x04002C63 RID: 11363
		[Nullable(2)]
		private FGameplayAttributeData _StatusBuildUp5;

		// Token: 0x04002C64 RID: 11364
		internal static int __PropertyOffset_RageMax;

		// Token: 0x04002C65 RID: 11365
		[Nullable(2)]
		private FGameplayAttributeData _RageMax;

		// Token: 0x04002C66 RID: 11366
		internal static int __PropertyOffset_Rage;

		// Token: 0x04002C67 RID: 11367
		[Nullable(2)]
		private FGameplayAttributeData _Rage;

		// Token: 0x04002C68 RID: 11368
		internal static int __PropertyOffset_RageRecover;

		// Token: 0x04002C69 RID: 11369
		[Nullable(2)]
		private FGameplayAttributeData _RageRecover;

		// Token: 0x04002C6A RID: 11370
		internal static int __PropertyOffset_RagePunishTime;

		// Token: 0x04002C6B RID: 11371
		[Nullable(2)]
		private FGameplayAttributeData _RagePunishTime;

		// Token: 0x04002C6C RID: 11372
		internal static int __PropertyOffset_RageChange;

		// Token: 0x04002C6D RID: 11373
		[Nullable(2)]
		private FGameplayAttributeData _RageChange;

		// Token: 0x04002C6E RID: 11374
		internal static int __PropertyOffset_RageReduce;

		// Token: 0x04002C6F RID: 11375
		[Nullable(2)]
		private FGameplayAttributeData _RageReduce;

		// Token: 0x04002C70 RID: 11376
		internal static int __PropertyOffset_ToughRecoverDelayTime;

		// Token: 0x04002C71 RID: 11377
		[Nullable(2)]
		private FGameplayAttributeData _ToughRecoverDelayTime;

		// Token: 0x04002C72 RID: 11378
		internal static int __PropertyOffset_Jump;

		// Token: 0x04002C73 RID: 11379
		[Nullable(2)]
		private FGameplayAttributeData _Jump;

		// Token: 0x04002C74 RID: 11380
		internal static int __PropertyOffset_ParalysisTimeMax;

		// Token: 0x04002C75 RID: 11381
		[Nullable(2)]
		private FGameplayAttributeData _ParalysisTimeMax;

		// Token: 0x04002C76 RID: 11382
		internal static int __PropertyOffset_ParalysisTime;

		// Token: 0x04002C77 RID: 11383
		[Nullable(2)]
		private FGameplayAttributeData _ParalysisTime;

		// Token: 0x04002C78 RID: 11384
		internal static int __PropertyOffset_ParalysisTimeRecover;

		// Token: 0x04002C79 RID: 11385
		[Nullable(2)]
		private FGameplayAttributeData _ParalysisTimeRecover;

		// Token: 0x04002C7A RID: 11386
		internal static int __PropertyOffset_WeaknessBuildUp;

		// Token: 0x04002C7B RID: 11387
		[Nullable(2)]
		private FGameplayAttributeData _WeaknessBuildUp;

		// Token: 0x04002C7C RID: 11388
		internal static int __PropertyOffset_WeaknessBuildUpMax;

		// Token: 0x04002C7D RID: 11389
		[Nullable(2)]
		private FGameplayAttributeData _WeaknessBuildUpMax;

		// Token: 0x04002C7E RID: 11390
		internal static int __PropertyOffset_WeaknessTotalBonus;

		// Token: 0x04002C7F RID: 11391
		[Nullable(2)]
		private FGameplayAttributeData _WeaknessTotalBonus;

		// Token: 0x04002C80 RID: 11392
		internal static int __PropertyOffset_WeaknessTotalResist;

		// Token: 0x04002C81 RID: 11393
		[Nullable(2)]
		private FGameplayAttributeData _WeaknessTotalResist;
	}
}
