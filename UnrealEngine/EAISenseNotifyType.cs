using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200016F RID: 367
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AIModule.EAISenseNotifyType")]
	public enum EAISenseNotifyType : byte
	{
		// Token: 0x0400064D RID: 1613
		OnEveryPerception,
		// Token: 0x0400064E RID: 1614
		OnPerceptionChange,
		// Token: 0x0400064F RID: 1615
		EAISenseNotifyType_MAX
	}
}
