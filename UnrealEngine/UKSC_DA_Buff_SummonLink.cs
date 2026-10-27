using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D84 RID: 7556
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_Buff_SummonLink")]
	[UnrealStructLayout(592, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 592)]
	public class UKSC_DA_Buff_SummonLink : UKSC_DA_Buff, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601CEDF RID: 118495 RVA: 0x002AC2E6 File Offset: 0x002AA4E6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_Buff_SummonLink._ClassPtr;
		}

		// Token: 0x0601CEE0 RID: 118496 RVA: 0x002AC2F4 File Offset: 0x002AA4F4
		public UKSC_DA_Buff_SummonLink() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Buff_SummonLink.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601CEE1 RID: 118497 RVA: 0x002AC31C File Offset: 0x002AA51C
		[NullableContext(1)]
		public UKSC_DA_Buff_SummonLink(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Buff_SummonLink.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170074AA RID: 29866
		// (get) Token: 0x0601CEE2 RID: 118498 RVA: 0x002AC34F File Offset: 0x002AA54F
		// (set) Token: 0x0601CEE3 RID: 118499 RVA: 0x002AC35F File Offset: 0x002AA55F
		public unsafe float LifeTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_SummonLink.__PropertyOffset_LifeTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_SummonLink.__PropertyOffset_LifeTime) = value;
			}
		}

		// Token: 0x170074AB RID: 29867
		// (get) Token: 0x0601CEE4 RID: 118500 RVA: 0x002AC370 File Offset: 0x002AA570
		// (set) Token: 0x0601CEE5 RID: 118501 RVA: 0x002AC380 File Offset: 0x002AA580
		public unsafe bool UseLifeTag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_SummonLink.__PropertyOffset_UseLifeTag) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_SummonLink.__PropertyOffset_UseLifeTag) = (value ? 1 : 0);
			}
		}

		// Token: 0x170074AC RID: 29868
		// (get) Token: 0x0601CEE6 RID: 118502 RVA: 0x002AC391 File Offset: 0x002AA591
		// (set) Token: 0x0601CEE7 RID: 118503 RVA: 0x002AC3A5 File Offset: 0x002AA5A5
		public unsafe FGameplayTag LifeTag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_SummonLink.__PropertyOffset_LifeTag);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_SummonLink.__PropertyOffset_LifeTag) = value;
			}
		}

		// Token: 0x170074AD RID: 29869
		// (get) Token: 0x0601CEE8 RID: 118504 RVA: 0x002AC3BA File Offset: 0x002AA5BA
		// (set) Token: 0x0601CEE9 RID: 118505 RVA: 0x002AC3CE File Offset: 0x002AA5CE
		public unsafe FGameplayTag SyncTag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_SummonLink.__PropertyOffset_SyncTag);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_SummonLink.__PropertyOffset_SyncTag) = value;
			}
		}

		// Token: 0x170074AE RID: 29870
		// (get) Token: 0x0601CEEA RID: 118506 RVA: 0x002AC3E3 File Offset: 0x002AA5E3
		// (set) Token: 0x0601CEEB RID: 118507 RVA: 0x002AC3F3 File Offset: 0x002AA5F3
		public unsafe bool KillOnSummonerDead
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_SummonLink.__PropertyOffset_KillOnSummonerDead) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_SummonLink.__PropertyOffset_KillOnSummonerDead) = (value ? 1 : 0);
			}
		}

		// Token: 0x170074AF RID: 29871
		// (get) Token: 0x0601CEEC RID: 118508 RVA: 0x002AC404 File Offset: 0x002AA604
		// (set) Token: 0x0601CEED RID: 118509 RVA: 0x002AC414 File Offset: 0x002AA614
		public unsafe bool IsUseSummonerAttr
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_SummonLink.__PropertyOffset_IsUseSummonerAttr) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_SummonLink.__PropertyOffset_IsUseSummonerAttr) = (value ? 1 : 0);
			}
		}

		// Token: 0x170074B0 RID: 29872
		// (get) Token: 0x0601CEEE RID: 118510 RVA: 0x002AC425 File Offset: 0x002AA625
		// (set) Token: 0x0601CEEF RID: 118511 RVA: 0x002AC435 File Offset: 0x002AA635
		public unsafe bool IsSyncAllAttr
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_SummonLink.__PropertyOffset_IsSyncAllAttr) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_SummonLink.__PropertyOffset_IsSyncAllAttr) = (value ? 1 : 0);
			}
		}

		// Token: 0x170074B1 RID: 29873
		// (get) Token: 0x0601CEF0 RID: 118512 RVA: 0x002AC448 File Offset: 0x002AA648
		// (set) Token: 0x0601CEF1 RID: 118513 RVA: 0x002AC481 File Offset: 0x002AA681
		[Nullable(1)]
		public TSet<EKSC_AttrType> SyncAttrSet
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TSet<EKSC_AttrType> result;
				if ((result = this._SyncAttrSet) == null)
				{
					result = (this._SyncAttrSet = new TSet<EKSC_AttrType>(base.NativePtr + (IntPtr)UKSC_DA_Buff_SummonLink.__PropertyOffset_SyncAttrSet, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.SyncAttrSet.CopyAssign(value);
			}
		}

		// Token: 0x170074B2 RID: 29874
		// (get) Token: 0x0601CEF2 RID: 118514 RVA: 0x002AC48F File Offset: 0x002AA68F
		// (set) Token: 0x0601CEF3 RID: 118515 RVA: 0x002AC4A3 File Offset: 0x002AA6A3
		public unsafe FGameplayTag AddTagToSummonerOnDead
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_SummonLink.__PropertyOffset_AddTagToSummonerOnDead);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_SummonLink.__PropertyOffset_AddTagToSummonerOnDead) = value;
			}
		}

		// Token: 0x170074B3 RID: 29875
		// (get) Token: 0x0601CEF4 RID: 118516 RVA: 0x002AC4B8 File Offset: 0x002AA6B8
		// (set) Token: 0x0601CEF5 RID: 118517 RVA: 0x002AC4CC File Offset: 0x002AA6CC
		public unsafe FGameplayTag RemoveTagToSummonerOnDead
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_SummonLink.__PropertyOffset_RemoveTagToSummonerOnDead);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_SummonLink.__PropertyOffset_RemoveTagToSummonerOnDead) = value;
			}
		}

		// Token: 0x170074B4 RID: 29876
		// (get) Token: 0x0601CEF6 RID: 118518 RVA: 0x002AC4E1 File Offset: 0x002AA6E1
		// (set) Token: 0x0601CEF7 RID: 118519 RVA: 0x002AC4F5 File Offset: 0x002AA6F5
		public unsafe UKSC_DA_Buff AddBuffToSummonerOnDead
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_Buff>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Buff_SummonLink.__PropertyOffset_AddBuffToSummonerOnDead);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Buff_SummonLink.__PropertyOffset_AddBuffToSummonerOnDead, value);
			}
		}

		// Token: 0x170074B5 RID: 29877
		// (get) Token: 0x0601CEF8 RID: 118520 RVA: 0x002AC50A File Offset: 0x002AA70A
		// (set) Token: 0x0601CEF9 RID: 118521 RVA: 0x002AC51E File Offset: 0x002AA71E
		public unsafe UKSC_DA_Buff RemoveBuffToSummonerOnDead
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_Buff>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Buff_SummonLink.__PropertyOffset_RemoveBuffToSummonerOnDead);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Buff_SummonLink.__PropertyOffset_RemoveBuffToSummonerOnDead, value);
			}
		}

		// Token: 0x170074B6 RID: 29878
		// (get) Token: 0x0601CEFA RID: 118522 RVA: 0x002AC533 File Offset: 0x002AA733
		// (set) Token: 0x0601CEFB RID: 118523 RVA: 0x002AC543 File Offset: 0x002AA743
		public unsafe bool IsRemoveBuffStacks
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_SummonLink.__PropertyOffset_IsRemoveBuffStacks) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_SummonLink.__PropertyOffset_IsRemoveBuffStacks) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601CEFC RID: 118524 RVA: 0x002AC554 File Offset: 0x002AA754
		static UKSC_DA_Buff_SummonLink()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_Buff_SummonLink");
		}

		// Token: 0x0601CEFD RID: 118525 RVA: 0x002AC562 File Offset: 0x002AA762
		protected UKSC_DA_Buff_SummonLink(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FB30 RID: 64304
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_Buff_SummonLink";

		// Token: 0x0400FB31 RID: 64305
		private static IntPtr _ClassPtr;

		// Token: 0x0400FB32 RID: 64306
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FB33 RID: 64307
		internal static int __PropertyOffset_LifeTime;

		// Token: 0x0400FB34 RID: 64308
		internal static int __PropertyOffset_UseLifeTag;

		// Token: 0x0400FB35 RID: 64309
		internal static int __PropertyOffset_LifeTag;

		// Token: 0x0400FB36 RID: 64310
		internal static int __PropertyOffset_SyncTag;

		// Token: 0x0400FB37 RID: 64311
		internal static int __PropertyOffset_KillOnSummonerDead;

		// Token: 0x0400FB38 RID: 64312
		internal static int __PropertyOffset_IsUseSummonerAttr;

		// Token: 0x0400FB39 RID: 64313
		internal static int __PropertyOffset_IsSyncAllAttr;

		// Token: 0x0400FB3A RID: 64314
		internal static int __PropertyOffset_SyncAttrSet;

		// Token: 0x0400FB3B RID: 64315
		private TSet<EKSC_AttrType> _SyncAttrSet;

		// Token: 0x0400FB3C RID: 64316
		internal static int __PropertyOffset_AddTagToSummonerOnDead;

		// Token: 0x0400FB3D RID: 64317
		internal static int __PropertyOffset_RemoveTagToSummonerOnDead;

		// Token: 0x0400FB3E RID: 64318
		internal static int __PropertyOffset_AddBuffToSummonerOnDead;

		// Token: 0x0400FB3F RID: 64319
		internal static int __PropertyOffset_RemoveBuffToSummonerOnDead;

		// Token: 0x0400FB40 RID: 64320
		internal static int __PropertyOffset_IsRemoveBuffStacks;
	}
}
