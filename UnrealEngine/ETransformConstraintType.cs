using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020002BE RID: 702
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AnimationCore.ETransformConstraintType")]
	public enum ETransformConstraintType : byte
	{
		// Token: 0x04000F5E RID: 3934
		Translation,
		// Token: 0x04000F5F RID: 3935
		Rotation,
		// Token: 0x04000F60 RID: 3936
		Scale,
		// Token: 0x04000F61 RID: 3937
		Parent,
		// Token: 0x04000F62 RID: 3938
		ETransformConstraintType_MAX
	}
}
