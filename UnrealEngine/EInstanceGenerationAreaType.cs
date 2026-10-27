using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000A86 RID: 2694
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EInstanceGenerationAreaType")]
	public enum EInstanceGenerationAreaType : byte
	{
		// Token: 0x04004835 RID: 18485
		Sector,
		// Token: 0x04004836 RID: 18486
		Rectangle,
		// Token: 0x04004837 RID: 18487
		RandomRect,
		// Token: 0x04004838 RID: 18488
		EInstanceGenerationAreaType_MAX
	}
}
