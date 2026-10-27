using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200152F RID: 5423
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/InstanceTool.ERotationOrder")]
	public enum ERotationOrder : byte
	{
		// Token: 0x0400AA7B RID: 43643
		XYZ,
		// Token: 0x0400AA7C RID: 43644
		XZY,
		// Token: 0x0400AA7D RID: 43645
		YXZ,
		// Token: 0x0400AA7E RID: 43646
		YZX,
		// Token: 0x0400AA7F RID: 43647
		ZXY,
		// Token: 0x0400AA80 RID: 43648
		ZYX,
		// Token: 0x0400AA81 RID: 43649
		ERotationOrder_MAX
	}
}
