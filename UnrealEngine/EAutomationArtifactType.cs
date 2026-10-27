using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000412 RID: 1042
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AutomationController.EAutomationArtifactType")]
	public enum EAutomationArtifactType : byte
	{
		// Token: 0x04001957 RID: 6487
		None,
		// Token: 0x04001958 RID: 6488
		Image,
		// Token: 0x04001959 RID: 6489
		Comparison,
		// Token: 0x0400195A RID: 6490
		EAutomationArtifactType_MAX
	}
}
