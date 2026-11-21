using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000458 RID: 1112
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroMath.EEndType")]
	public enum EEndType : byte
	{
		// Token: 0x04002D91 RID: 11665
		Polygon,
		// Token: 0x04002D92 RID: 11666
		Joined,
		// Token: 0x04002D93 RID: 11667
		Butt,
		// Token: 0x04002D94 RID: 11668
		Square,
		// Token: 0x04002D95 RID: 11669
		Round,
		// Token: 0x04002D96 RID: 11670
		EEndType_MAX
	}
}
