using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000A82 RID: 2690
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EImportanceWeight")]
	public enum EImportanceWeight
	{
		// Token: 0x0400481E RID: 18462
		Luminance,
		// Token: 0x0400481F RID: 18463
		Red,
		// Token: 0x04004820 RID: 18464
		Green,
		// Token: 0x04004821 RID: 18465
		Blue,
		// Token: 0x04004822 RID: 18466
		Alpha,
		// Token: 0x04004823 RID: 18467
		EImportanceWeight_MAX
	}
}
