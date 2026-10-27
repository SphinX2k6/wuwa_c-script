using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002912 RID: 10514
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/TimeManagement.EFrameNumberDisplayFormats")]
	public enum EFrameNumberDisplayFormats : byte
	{
		// Token: 0x0401564D RID: 87629
		NonDropFrameTimecode,
		// Token: 0x0401564E RID: 87630
		DropFrameTimecode,
		// Token: 0x0401564F RID: 87631
		Seconds,
		// Token: 0x04015650 RID: 87632
		Frames,
		// Token: 0x04015651 RID: 87633
		MAX_Count,
		// Token: 0x04015652 RID: 87634
		EFrameNumberDisplayFormats_MAX
	}
}
