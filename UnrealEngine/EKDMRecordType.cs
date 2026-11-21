using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000467 RID: 1127
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroMovement.EKDMRecordType")]
	public enum EKDMRecordType
	{
		// Token: 0x04002DD6 RID: 11734
		KDM_NONE,
		// Token: 0x04002DD7 RID: 11735
		KDM_LOCATION,
		// Token: 0x04002DD8 RID: 11736
		KDM_MOVEMENTMODE,
		// Token: 0x04002DD9 RID: 11737
		KDM_CUSTOM_VECTOR_01 = 4,
		// Token: 0x04002DDA RID: 11738
		KDM_CUSTOM_VECTOR_02 = 8,
		// Token: 0x04002DDB RID: 11739
		KDM_ALL = 15,
		// Token: 0x04002DDC RID: 11740
		KDM_MAX
	}
}
