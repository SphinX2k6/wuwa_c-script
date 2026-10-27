using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020003EA RID: 1002
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AugmentedReality.EARJointTransformSpace")]
	public enum EARJointTransformSpace : byte
	{
		// Token: 0x04001887 RID: 6279
		Model,
		// Token: 0x04001888 RID: 6280
		ParentJoint,
		// Token: 0x04001889 RID: 6281
		EARJointTransformSpace_MAX
	}
}
