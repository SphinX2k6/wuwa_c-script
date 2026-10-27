using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000328 RID: 808
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AnimGraphRuntime.ERotationComponent")]
	public enum ERotationComponent : byte
	{
		// Token: 0x0400134C RID: 4940
		EulerX,
		// Token: 0x0400134D RID: 4941
		EulerY,
		// Token: 0x0400134E RID: 4942
		EulerZ,
		// Token: 0x0400134F RID: 4943
		QuaternionAngle,
		// Token: 0x04001350 RID: 4944
		SwingAngle,
		// Token: 0x04001351 RID: 4945
		TwistAngle,
		// Token: 0x04001352 RID: 4946
		ERotationComponent_MAX
	}
}
