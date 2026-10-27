using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020003E6 RID: 998
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AugmentedReality.EARFrameSyncMode")]
	public enum EARFrameSyncMode : byte
	{
		// Token: 0x0400186C RID: 6252
		SyncTickWithCameraImage,
		// Token: 0x0400186D RID: 6253
		SyncTickWithoutCameraImage,
		// Token: 0x0400186E RID: 6254
		EARFrameSyncMode_MAX
	}
}
