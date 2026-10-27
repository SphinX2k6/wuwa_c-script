using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001A74 RID: 6772
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.EKuroCharSlotSpecifiedType")]
	public enum EKuroCharSlotSpecifiedType : byte
	{
		// Token: 0x0400D919 RID: 55577
		All,
		// Token: 0x0400D91A RID: 55578
		BodyAndOutline,
		// Token: 0x0400D91B RID: 55579
		Body,
		// Token: 0x0400D91C RID: 55580
		Outline,
		// Token: 0x0400D91D RID: 55581
		ECharacterSlotSpecifiedType_Max,
		// Token: 0x0400D91E RID: 55582
		EKuroCharSlotSpecifiedType_MAX
	}
}
