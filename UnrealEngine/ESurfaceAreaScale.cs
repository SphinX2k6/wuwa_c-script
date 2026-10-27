using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020027A4 RID: 10148
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/SimplygonUObjects.ESurfaceAreaScale")]
	public enum ESurfaceAreaScale : byte
	{
		// Token: 0x04014A5E RID: 84574
		LargestInstance,
		// Token: 0x04014A5F RID: 84575
		SmallestInstance,
		// Token: 0x04014A60 RID: 84576
		Average,
		// Token: 0x04014A61 RID: 84577
		ESurfaceAreaScale_MAX
	}
}
