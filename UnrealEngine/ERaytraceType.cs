using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000B39 RID: 2873
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.ERaytraceType")]
	public enum ERaytraceType
	{
		// Token: 0x04004F2A RID: 20266
		ALLType,
		// Token: 0x04004F2B RID: 20267
		OnlyRaytrace,
		// Token: 0x04004F2C RID: 20268
		OnlyNotRaytrace,
		// Token: 0x04004F2D RID: 20269
		ERaytraceType_MAX
	}
}
