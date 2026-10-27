using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020019DB RID: 6619
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroMovement.EKDMRecordType")]
	public enum EKDMRecordType
	{
		// Token: 0x0400D47B RID: 54395
		KDM_NONE,
		// Token: 0x0400D47C RID: 54396
		KDM_LOCATION,
		// Token: 0x0400D47D RID: 54397
		KDM_MOVEMENTMODE,
		// Token: 0x0400D47E RID: 54398
		KDM_CUSTOM_VECTOR_01 = 4,
		// Token: 0x0400D47F RID: 54399
		KDM_CUSTOM_VECTOR_02 = 8,
		// Token: 0x0400D480 RID: 54400
		KDM_ALL = 15,
		// Token: 0x0400D481 RID: 54401
		KDM_MAX
	}
}
