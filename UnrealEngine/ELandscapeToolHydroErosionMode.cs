using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001F52 RID: 8018
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/LandscapeEditor.ELandscapeToolHydroErosionMode")]
	public enum ELandscapeToolHydroErosionMode : sbyte
	{
		// Token: 0x04010733 RID: 67379
		Invalid = -1,
		// Token: 0x04010734 RID: 67380
		Both,
		// Token: 0x04010735 RID: 67381
		Positive,
		// Token: 0x04010736 RID: 67382
		ELandscapeToolHydroErosionMode_MAX
	}
}
