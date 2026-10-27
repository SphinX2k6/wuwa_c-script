using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020002BD RID: 701
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AnimationCore.EConstraintType")]
	public enum EConstraintType : byte
	{
		// Token: 0x04000F5A RID: 3930
		Transform,
		// Token: 0x04000F5B RID: 3931
		Aim,
		// Token: 0x04000F5C RID: 3932
		MAX
	}
}
