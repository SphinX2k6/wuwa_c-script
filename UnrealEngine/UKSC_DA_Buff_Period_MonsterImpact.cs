using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D78 RID: 7544
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_Buff_Period_MonsterImpact")]
	[UnrealStructLayout(672, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 672)]
	public class UKSC_DA_Buff_Period_MonsterImpact : UKSC_DA_Buff_Period, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601CE50 RID: 118352 RVA: 0x002AB5E4 File Offset: 0x002A97E4
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_Buff_Period_MonsterImpact._ClassPtr;
		}

		// Token: 0x0601CE51 RID: 118353 RVA: 0x002AB5F0 File Offset: 0x002A97F0
		public UKSC_DA_Buff_Period_MonsterImpact() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Buff_Period_MonsterImpact.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601CE52 RID: 118354 RVA: 0x002AB618 File Offset: 0x002A9818
		public UKSC_DA_Buff_Period_MonsterImpact(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Buff_Period_MonsterImpact.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007480 RID: 29824
		// (get) Token: 0x0601CE53 RID: 118355 RVA: 0x002AB64C File Offset: 0x002A984C
		// (set) Token: 0x0601CE54 RID: 118356 RVA: 0x002AB685 File Offset: 0x002A9885
		public TArray<FMonsterImpactInfo> MonsterImpactInfoList
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FMonsterImpactInfo> result;
				if ((result = this._MonsterImpactInfoList) == null)
				{
					result = (this._MonsterImpactInfoList = new TArray<FMonsterImpactInfo>(base.NativePtr + (IntPtr)UKSC_DA_Buff_Period_MonsterImpact.__PropertyOffset_MonsterImpactInfoList, this));
				}
				return result;
			}
			set
			{
				this.MonsterImpactInfoList.CopyAssign(value);
			}
		}

		// Token: 0x17007481 RID: 29825
		// (get) Token: 0x0601CE55 RID: 118357 RVA: 0x002AB694 File Offset: 0x002A9894
		// (set) Token: 0x0601CE56 RID: 118358 RVA: 0x002AB6CD File Offset: 0x002A98CD
		public TArray<EKSC_Faction> IgnoreFaction
		{
			get
			{
				base.FastCheckIsValid();
				TArray<EKSC_Faction> result;
				if ((result = this._IgnoreFaction) == null)
				{
					result = (this._IgnoreFaction = new TArray<EKSC_Faction>(base.NativePtr + (IntPtr)UKSC_DA_Buff_Period_MonsterImpact.__PropertyOffset_IgnoreFaction, this));
				}
				return result;
			}
			set
			{
				this.IgnoreFaction.CopyAssign(value);
			}
		}

		// Token: 0x17007482 RID: 29826
		// (get) Token: 0x0601CE57 RID: 118359 RVA: 0x002AB6DB File Offset: 0x002A98DB
		// (set) Token: 0x0601CE58 RID: 118360 RVA: 0x002AB6EB File Offset: 0x002A98EB
		public unsafe int MaxHitCountPerPeriod
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_Period_MonsterImpact.__PropertyOffset_MaxHitCountPerPeriod);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_Period_MonsterImpact.__PropertyOffset_MaxHitCountPerPeriod) = value;
			}
		}

		// Token: 0x17007483 RID: 29827
		// (get) Token: 0x0601CE59 RID: 118361 RVA: 0x002AB6FC File Offset: 0x002A98FC
		// (set) Token: 0x0601CE5A RID: 118362 RVA: 0x002AB70C File Offset: 0x002A990C
		public unsafe int MaxTargetCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_Period_MonsterImpact.__PropertyOffset_MaxTargetCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_Period_MonsterImpact.__PropertyOffset_MaxTargetCount) = value;
			}
		}

		// Token: 0x17007484 RID: 29828
		// (get) Token: 0x0601CE5B RID: 118363 RVA: 0x002AB71D File Offset: 0x002A991D
		// (set) Token: 0x0601CE5C RID: 118364 RVA: 0x002AB731 File Offset: 0x002A9931
		public unsafe FGameplayTag ImmunityTag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_Period_MonsterImpact.__PropertyOffset_ImmunityTag);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_Period_MonsterImpact.__PropertyOffset_ImmunityTag) = value;
			}
		}

		// Token: 0x0601CE5D RID: 118365 RVA: 0x002AB746 File Offset: 0x002A9946
		static UKSC_DA_Buff_Period_MonsterImpact()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_Buff_Period_MonsterImpact");
		}

		// Token: 0x0601CE5E RID: 118366 RVA: 0x002AB754 File Offset: 0x002A9954
		protected UKSC_DA_Buff_Period_MonsterImpact(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FAD9 RID: 64217
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_Buff_Period_MonsterImpact";

		// Token: 0x0400FADA RID: 64218
		private static IntPtr _ClassPtr;

		// Token: 0x0400FADB RID: 64219
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FADC RID: 64220
		internal static int __PropertyOffset_MonsterImpactInfoList;

		// Token: 0x0400FADD RID: 64221
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FMonsterImpactInfo> _MonsterImpactInfoList;

		// Token: 0x0400FADE RID: 64222
		internal static int __PropertyOffset_IgnoreFaction;

		// Token: 0x0400FADF RID: 64223
		[Nullable(2)]
		private TArray<EKSC_Faction> _IgnoreFaction;

		// Token: 0x0400FAE0 RID: 64224
		internal static int __PropertyOffset_MaxHitCountPerPeriod;

		// Token: 0x0400FAE1 RID: 64225
		internal static int __PropertyOffset_MaxTargetCount;

		// Token: 0x0400FAE2 RID: 64226
		internal static int __PropertyOffset_ImmunityTag;
	}
}
