using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001870 RID: 6256
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroGamePartition.EGamePartitionCellSizeType")]
	public enum EGamePartitionCellSizeType : byte
	{
		// Token: 0x0400C815 RID: 51221
		Default,
		// Token: 0x0400C816 RID: 51222
		Medium,
		// Token: 0x0400C817 RID: 51223
		MaxType,
		// Token: 0x0400C818 RID: 51224
		EGamePartitionCellSizeType_MAX
	}
}
