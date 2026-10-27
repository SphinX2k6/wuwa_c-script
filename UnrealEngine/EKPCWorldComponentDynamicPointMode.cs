using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001A22 RID: 6690
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroPointCloud.EKPCWorldComponentDynamicPointMode")]
	public enum EKPCWorldComponentDynamicPointMode : byte
	{
		// Token: 0x0400D61E RID: 54814
		None,
		// Token: 0x0400D61F RID: 54815
		SkeletalMeshSockets,
		// Token: 0x0400D620 RID: 54816
		CustomPoints,
		// Token: 0x0400D621 RID: 54817
		RingBufferPoints,
		// Token: 0x0400D622 RID: 54818
		Max,
		// Token: 0x0400D623 RID: 54819
		EKPCWorldComponentDynamicPointMode_MAX
	}
}
