using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001A76 RID: 6774
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.EKuroDebugDrawComponentType")]
	public enum EKuroDebugDrawComponentType : byte
	{
		// Token: 0x0400D925 RID: 55589
		Box,
		// Token: 0x0400D926 RID: 55590
		Sphere,
		// Token: 0x0400D927 RID: 55591
		Cone,
		// Token: 0x0400D928 RID: 55592
		EKuroDebugDrawComponentType_MAX
	}
}
