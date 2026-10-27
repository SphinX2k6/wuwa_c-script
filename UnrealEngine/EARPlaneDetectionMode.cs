using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020003EE RID: 1006
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AugmentedReality.EARPlaneDetectionMode")]
	public enum EARPlaneDetectionMode : byte
	{
		// Token: 0x040018A7 RID: 6311
		None,
		// Token: 0x040018A8 RID: 6312
		HorizontalPlaneDetection,
		// Token: 0x040018A9 RID: 6313
		VerticalPlaneDetection,
		// Token: 0x040018AA RID: 6314
		EARPlaneDetectionMode_MAX
	}
}
