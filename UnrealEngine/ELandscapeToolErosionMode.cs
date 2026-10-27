using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001F50 RID: 8016
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/LandscapeEditor.ELandscapeToolErosionMode")]
	public enum ELandscapeToolErosionMode : sbyte
	{
		// Token: 0x04010725 RID: 67365
		Invalid = -1,
		// Token: 0x04010726 RID: 67366
		Both,
		// Token: 0x04010727 RID: 67367
		Raise,
		// Token: 0x04010728 RID: 67368
		Lower,
		// Token: 0x04010729 RID: 67369
		ELandscapeToolErosionMode_MAX
	}
}
