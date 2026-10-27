using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000AC8 RID: 2760
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EMegaLightsShadowMethod")]
	public enum EMegaLightsShadowMethod
	{
		// Token: 0x04004A72 RID: 19058
		Default,
		// Token: 0x04004A73 RID: 19059
		RayTracing,
		// Token: 0x04004A74 RID: 19060
		VirtualShadowMap,
		// Token: 0x04004A75 RID: 19061
		EMegaLightsShadowMethod_MAX
	}
}
