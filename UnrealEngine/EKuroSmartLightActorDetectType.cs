using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001A87 RID: 6791
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.EKuroSmartLightActorDetectType")]
	public enum EKuroSmartLightActorDetectType : byte
	{
		// Token: 0x0400DA29 RID: 55849
		Box,
		// Token: 0x0400DA2A RID: 55850
		Sphere,
		// Token: 0x0400DA2B RID: 55851
		EKuroSmartLightActorDetectType_MAX
	}
}
