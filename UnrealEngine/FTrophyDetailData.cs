using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200061A RID: 1562
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroUtility.TrophyDetailData")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 88)]
	public class FTrophyDetailData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060088E2 RID: 35042 RVA: 0x000CE8D7 File Offset: 0x000CCAD7
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FTrophyDetailData._ScriptStructPtr != 0) ? FTrophyDetailData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroUtility.TrophyDetailData", ref FTrophyDetailData._ScriptStructPtr);
		}

		// Token: 0x17001985 RID: 6533
		// (get) Token: 0x060088E3 RID: 35043 RVA: 0x000CE8FB File Offset: 0x000CCAFB
		// (set) Token: 0x060088E4 RID: 35044 RVA: 0x000CE90B File Offset: 0x000CCB0B
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

		// Token: 0x17001986 RID: 6534
		// (get) Token: 0x060088E5 RID: 35045 RVA: 0x000CE91C File Offset: 0x000CCB1C
		// (set) Token: 0x060088E6 RID: 35046 RVA: 0x000CE92C File Offset: 0x000CCB2C
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

		// Token: 0x17001987 RID: 6535
		// (get) Token: 0x060088E7 RID: 35047 RVA: 0x000CE93D File Offset: 0x000CCB3D
		// (set) Token: 0x060088E8 RID: 35048 RVA: 0x000CE94D File Offset: 0x000CCB4D
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

		// Token: 0x17001988 RID: 6536
		// (get) Token: 0x060088E9 RID: 35049 RVA: 0x000CE95E File Offset: 0x000CCB5E
		// (set) Token: 0x060088EA RID: 35050 RVA: 0x000CE96E File Offset: 0x000CCB6E
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

		// Token: 0x17001989 RID: 6537
		// (get) Token: 0x060088EB RID: 35051 RVA: 0x000CE97F File Offset: 0x000CCB7F
		// (set) Token: 0x060088EC RID: 35052 RVA: 0x000CE98F File Offset: 0x000CCB8F
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

		// Token: 0x1700198A RID: 6538
		// (get) Token: 0x060088ED RID: 35053 RVA: 0x000CE9A0 File Offset: 0x000CCBA0
		// (set) Token: 0x060088EE RID: 35054 RVA: 0x000CE9B0 File Offset: 0x000CCBB0
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

		// Token: 0x1700198B RID: 6539
		// (get) Token: 0x060088EF RID: 35055 RVA: 0x000CE9C1 File Offset: 0x000CCBC1
		// (set) Token: 0x060088F0 RID: 35056 RVA: 0x000CE9D5 File Offset: 0x000CCBD5
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

		// Token: 0x1700198C RID: 6540
		// (get) Token: 0x060088F1 RID: 35057 RVA: 0x000CE9EA File Offset: 0x000CCBEA
		// (set) Token: 0x060088F2 RID: 35058 RVA: 0x000CE9FE File Offset: 0x000CCBFE
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

		// Token: 0x1700198D RID: 6541
		// (get) Token: 0x060088F3 RID: 35059 RVA: 0x000CEA13 File Offset: 0x000CCC13
		// (set) Token: 0x060088F4 RID: 35060 RVA: 0x000CEA27 File Offset: 0x000CCC27
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

		// Token: 0x1700198E RID: 6542
		// (get) Token: 0x060088F5 RID: 35061 RVA: 0x000CEA3C File Offset: 0x000CCC3C
		// (set) Token: 0x060088F6 RID: 35062 RVA: 0x000CEA50 File Offset: 0x000CCC50
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

		// Token: 0x060088F7 RID: 35063 RVA: 0x000CEA65 File Offset: 0x000CCC65
		public FTrophyDetailData()
		{
		}

		// Token: 0x060088F8 RID: 35064 RVA: 0x000CEA6D File Offset: 0x000CCC6D
		protected override IntPtr GetUStructPtr()
		{
			return FTrophyDetailData.StaticStruct();
		}

		// Token: 0x060088F9 RID: 35065 RVA: 0x000CEA79 File Offset: 0x000CCC79
		[NullableContext(2)]
		public FTrophyDetailData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060088FA RID: 35066 RVA: 0x000CEA83 File Offset: 0x000CCC83
		public FTrophyDetailData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060088FB RID: 35067 RVA: 0x000CEA8E File Offset: 0x000CCC8E
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FTrophyDetailData(Pointer, false, true);
		}

		// Token: 0x060088FC RID: 35068 RVA: 0x000CEA98 File Offset: 0x000CCC98
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FTrophyDetailData(Pointer, MemoryOwner);
		}

		// Token: 0x04003B6A RID: 15210
		public const string __ObjectPath = "/Script/KuroUtility.TrophyDetailData";

		// Token: 0x04003B6B RID: 15211
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003B6C RID: 15212
		internal static int __PropertyOffset_trophyId;

		// Token: 0x04003B6D RID: 15213
		internal static int __PropertyOffset_trophyGrade;

		// Token: 0x04003B6E RID: 15214
		internal static int __PropertyOffset_groupId;

		// Token: 0x04003B6F RID: 15215
		internal static int __PropertyOffset_hidden;

		// Token: 0x04003B70 RID: 15216
		internal static int __PropertyOffset_hasReward;

		// Token: 0x04003B71 RID: 15217
		internal static int __PropertyOffset_progressType;

		// Token: 0x04003B72 RID: 15218
		internal static int __PropertyOffset_progress;

		// Token: 0x04003B73 RID: 15219
		internal static int __PropertyOffset_name;

		// Token: 0x04003B74 RID: 15220
		internal static int __PropertyOffset_desc;

		// Token: 0x04003B75 RID: 15221
		internal static int __PropertyOffset_reward;
	}
}
