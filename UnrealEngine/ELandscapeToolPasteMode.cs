using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001F54 RID: 8020
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/LandscapeEditor.ELandscapeToolPasteMode")]
	public enum ELandscapeToolPasteMode : sbyte
	{
		// Token: 0x0401073E RID: 67390
		Invalid = -1,
		// Token: 0x0401073F RID: 67391
		Both,
		// Token: 0x04010740 RID: 67392
		Raise,
		// Token: 0x04010741 RID: 67393
		Lower,
		// Token: 0x04010742 RID: 67394
		ELandscapeToolPasteMode_MAX
	}
}
