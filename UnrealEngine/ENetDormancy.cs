using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000AEC RID: 2796
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.ENetDormancy")]
	public enum ENetDormancy
	{
		// Token: 0x04004B5B RID: 19291
		DORM_Never,
		// Token: 0x04004B5C RID: 19292
		DORM_Awake,
		// Token: 0x04004B5D RID: 19293
		DORM_DormantAll,
		// Token: 0x04004B5E RID: 19294
		DORM_DormantPartial,
		// Token: 0x04004B5F RID: 19295
		DORM_Initial,
		// Token: 0x04004B60 RID: 19296
		DORM_MAX
	}
}
