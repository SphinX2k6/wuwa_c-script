using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001F51 RID: 8017
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/LandscapeEditor.ELandscapeToolFlattenMode")]
	public enum ELandscapeToolFlattenMode : sbyte
	{
		// Token: 0x0401072B RID: 67371
		Invalid = -1,
		// Token: 0x0401072C RID: 67372
		Both,
		// Token: 0x0401072D RID: 67373
		Raise,
		// Token: 0x0401072E RID: 67374
		Lower,
		// Token: 0x0401072F RID: 67375
		Interval,
		// Token: 0x04010730 RID: 67376
		Terrace,
		// Token: 0x04010731 RID: 67377
		ELandscapeToolFlattenMode_MAX
	}
}
