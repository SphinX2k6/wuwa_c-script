using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000B52 RID: 2898
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.ERuntimePartitionCellBoundsMethod")]
	public enum ERuntimePartitionCellBoundsMethod : byte
	{
		// Token: 0x04004FC5 RID: 20421
		UseContent,
		// Token: 0x04004FC6 RID: 20422
		UseCellBounds,
		// Token: 0x04004FC7 RID: 20423
		UseMinContentCellBounds,
		// Token: 0x04004FC8 RID: 20424
		ERuntimePartitionCellBoundsMethod_MAX
	}
}
