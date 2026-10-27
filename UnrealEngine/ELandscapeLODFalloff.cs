using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001F60 RID: 8032
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Landscape.ELandscapeLODFalloff")]
	public enum ELandscapeLODFalloff
	{
		// Token: 0x0401077C RID: 67452
		Linear,
		// Token: 0x0401077D RID: 67453
		SquareRoot,
		// Token: 0x0401077E RID: 67454
		ELandscapeLODFalloff_MAX
	}
}
