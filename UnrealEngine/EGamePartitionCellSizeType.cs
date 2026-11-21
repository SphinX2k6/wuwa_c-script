using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200039D RID: 925
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroGamePartition.EGamePartitionCellSizeType")]
	public enum EGamePartitionCellSizeType : byte
	{
		// Token: 0x04002635 RID: 9781
		Default,
		// Token: 0x04002636 RID: 9782
		Medium,
		// Token: 0x04002637 RID: 9783
		MaxType,
		// Token: 0x04002638 RID: 9784
		EGamePartitionCellSizeType_MAX
	}
}
