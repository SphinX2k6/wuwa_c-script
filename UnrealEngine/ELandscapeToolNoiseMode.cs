using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001F53 RID: 8019
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/LandscapeEditor.ELandscapeToolNoiseMode")]
	public enum ELandscapeToolNoiseMode : sbyte
	{
		// Token: 0x04010738 RID: 67384
		Invalid = -1,
		// Token: 0x04010739 RID: 67385
		Both,
		// Token: 0x0401073A RID: 67386
		Add,
		// Token: 0x0401073B RID: 67387
		Sub,
		// Token: 0x0401073C RID: 67388
		ELandscapeToolNoiseMode_MAX
	}
}
