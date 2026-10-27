using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001F0F RID: 7951
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroUtility.TrophyDetailData")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 88)]
	public class FTrophyDetailData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601E2BA RID: 123578 RVA: 0x002CDBDC File Offset: 0x002CBDDC
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FTrophyDetailData._ScriptStructPtr != 0) ? FTrophyDetailData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroUtility.TrophyDetailData", ref FTrophyDetailData._ScriptStructPtr);
		}

		// Token: 0x170077D5 RID: 30677
		// (get) Token: 0x0601E2BB RID: 123579 RVA: 0x002CDC00 File Offset: 0x002CBE00
		// (set) Token: 0x0601E2BC RID: 123580 RVA: 0x002CDC10 File Offset: 0x002CBE10
		public unsafe int trophyId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTrophyDetailData.__PropertyOffset_trophyId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTrophyDetailData.__PropertyOffset_trophyId) = value;
			}
		}

		// Token: 0x170077D6 RID: 30678
		// (get) Token: 0x0601E2BD RID: 123581 RVA: 0x002CDC21 File Offset: 0x002CBE21
		// (set) Token: 0x0601E2BE RID: 123582 RVA: 0x002CDC31 File Offset: 0x002CBE31
		public unsafe int trophyGrade
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTrophyDetailData.__PropertyOffset_trophyGrade);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTrophyDetailData.__PropertyOffset_trophyGrade) = value;
			}
		}

		// Token: 0x170077D7 RID: 30679
		// (get) Token: 0x0601E2BF RID: 123583 RVA: 0x002CDC42 File Offset: 0x002CBE42
		// (set) Token: 0x0601E2C0 RID: 123584 RVA: 0x002CDC52 File Offset: 0x002CBE52
		public unsafe int groupId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTrophyDetailData.__PropertyOffset_groupId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTrophyDetailData.__PropertyOffset_groupId) = value;
			}
		}

		// Token: 0x170077D8 RID: 30680
		// (get) Token: 0x0601E2C1 RID: 123585 RVA: 0x002CDC63 File Offset: 0x002CBE63
		// (set) Token: 0x0601E2C2 RID: 123586 RVA: 0x002CDC73 File Offset: 0x002CBE73
		public unsafe bool hidden
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTrophyDetailData.__PropertyOffset_hidden) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTrophyDetailData.__PropertyOffset_hidden) = (value ? 1 : 0);
			}
		}

		// Token: 0x170077D9 RID: 30681
		// (get) Token: 0x0601E2C3 RID: 123587 RVA: 0x002CDC84 File Offset: 0x002CBE84
		// (set) Token: 0x0601E2C4 RID: 123588 RVA: 0x002CDC94 File Offset: 0x002CBE94
		public unsafe bool hasReward
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTrophyDetailData.__PropertyOffset_hasReward) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTrophyDetailData.__PropertyOffset_hasReward) = (value ? 1 : 0);
			}
		}

		// Token: 0x170077DA RID: 30682
		// (get) Token: 0x0601E2C5 RID: 123589 RVA: 0x002CDCA5 File Offset: 0x002CBEA5
		// (set) Token: 0x0601E2C6 RID: 123590 RVA: 0x002CDCB5 File Offset: 0x002CBEB5
		public unsafe int progressType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTrophyDetailData.__PropertyOffset_progressType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTrophyDetailData.__PropertyOffset_progressType) = value;
			}
		}

		// Token: 0x170077DB RID: 30683
		// (get) Token: 0x0601E2C7 RID: 123591 RVA: 0x002CDCC6 File Offset: 0x002CBEC6
		// (set) Token: 0x0601E2C8 RID: 123592 RVA: 0x002CDCDA File Offset: 0x002CBEDA
		public unsafe string progress
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FTrophyDetailData.__PropertyOffset_progress)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FTrophyDetailData.__PropertyOffset_progress)), value);
			}
		}

		// Token: 0x170077DC RID: 30684
		// (get) Token: 0x0601E2C9 RID: 123593 RVA: 0x002CDCEF File Offset: 0x002CBEEF
		// (set) Token: 0x0601E2CA RID: 123594 RVA: 0x002CDD03 File Offset: 0x002CBF03
		public unsafe string name
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FTrophyDetailData.__PropertyOffset_name)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FTrophyDetailData.__PropertyOffset_name)), value);
			}
		}

		// Token: 0x170077DD RID: 30685
		// (get) Token: 0x0601E2CB RID: 123595 RVA: 0x002CDD18 File Offset: 0x002CBF18
		// (set) Token: 0x0601E2CC RID: 123596 RVA: 0x002CDD2C File Offset: 0x002CBF2C
		public unsafe string desc
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FTrophyDetailData.__PropertyOffset_desc)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FTrophyDetailData.__PropertyOffset_desc)), value);
			}
		}

		// Token: 0x170077DE RID: 30686
		// (get) Token: 0x0601E2CD RID: 123597 RVA: 0x002CDD41 File Offset: 0x002CBF41
		// (set) Token: 0x0601E2CE RID: 123598 RVA: 0x002CDD55 File Offset: 0x002CBF55
		public unsafe string reward
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FTrophyDetailData.__PropertyOffset_reward)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FTrophyDetailData.__PropertyOffset_reward)), value);
			}
		}

		// Token: 0x0601E2CF RID: 123599 RVA: 0x002CDD6A File Offset: 0x002CBF6A
		public FTrophyDetailData()
		{
		}

		// Token: 0x0601E2D0 RID: 123600 RVA: 0x002CDD74 File Offset: 0x002CBF74
		public FTrophyDetailData(int trophyId, int trophyGrade, int groupId, bool hidden, bool hasReward, int progressType, string progress, string name, string desc, string reward)
		{
			this.trophyId = trophyId;
			this.trophyGrade = trophyGrade;
			this.groupId = groupId;
			this.hidden = hidden;
			this.hasReward = hasReward;
			this.progressType = progressType;
			this.progress = progress;
			this.name = name;
			this.desc = desc;
			this.reward = reward;
		}

		// Token: 0x0601E2D1 RID: 123601 RVA: 0x002CDDD4 File Offset: 0x002CBFD4
		protected override IntPtr GetUStructPtr()
		{
			return FTrophyDetailData.StaticStruct();
		}

		// Token: 0x0601E2D2 RID: 123602 RVA: 0x002CDDE0 File Offset: 0x002CBFE0
		[NullableContext(2)]
		public FTrophyDetailData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601E2D3 RID: 123603 RVA: 0x002CDDEA File Offset: 0x002CBFEA
		public FTrophyDetailData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601E2D4 RID: 123604 RVA: 0x002CDDF5 File Offset: 0x002CBFF5
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FTrophyDetailData(Pointer, false, true);
		}

		// Token: 0x0601E2D5 RID: 123605 RVA: 0x002CDDFF File Offset: 0x002CBFFF
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FTrophyDetailData(Pointer, MemoryOwner);
		}

		// Token: 0x0401049F RID: 66719
		public const string __ObjectPath = "/Script/KuroUtility.TrophyDetailData";

		// Token: 0x040104A0 RID: 66720
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040104A1 RID: 66721
		internal static int __PropertyOffset_trophyId;

		// Token: 0x040104A2 RID: 66722
		internal static int __PropertyOffset_trophyGrade;

		// Token: 0x040104A3 RID: 66723
		internal static int __PropertyOffset_groupId;

		// Token: 0x040104A4 RID: 66724
		internal static int __PropertyOffset_hidden;

		// Token: 0x040104A5 RID: 66725
		internal static int __PropertyOffset_hasReward;

		// Token: 0x040104A6 RID: 66726
		internal static int __PropertyOffset_progressType;

		// Token: 0x040104A7 RID: 66727
		internal static int __PropertyOffset_progress;

		// Token: 0x040104A8 RID: 66728
		internal static int __PropertyOffset_name;

		// Token: 0x040104A9 RID: 66729
		internal static int __PropertyOffset_desc;

		// Token: 0x040104AA RID: 66730
		internal static int __PropertyOffset_reward;
	}
}
