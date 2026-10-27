using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020024B9 RID: 9401
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/NavmeshPartition.ENavPartition")]
	public enum ENavPartition : byte
	{
		// Token: 0x04012CCF RID: 77007
		Normal,
		// Token: 0x04012CD0 RID: 77008
		Water,
		// Token: 0x04012CD1 RID: 77009
		Max,
		// Token: 0x04012CD2 RID: 77010
		ENavPartition_MAX
	}
}
