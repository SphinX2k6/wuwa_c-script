using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020003FF RID: 1023
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AugmentedReality.EImageComponentDebugMode")]
	public enum EImageComponentDebugMode : byte
	{
		// Token: 0x04001916 RID: 6422
		None,
		// Token: 0x04001917 RID: 6423
		ShowDetectedImage,
		// Token: 0x04001918 RID: 6424
		EImageComponentDebugMode_MAX
	}
}
