using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001F62 RID: 8034
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Landscape.ETerrainCoordMappingType")]
	public enum ETerrainCoordMappingType
	{
		// Token: 0x04010786 RID: 67462
		TCMT_Auto,
		// Token: 0x04010787 RID: 67463
		TCMT_XY,
		// Token: 0x04010788 RID: 67464
		TCMT_XZ,
		// Token: 0x04010789 RID: 67465
		TCMT_YZ,
		// Token: 0x0401078A RID: 67466
		TCMT_MAX
	}
}
