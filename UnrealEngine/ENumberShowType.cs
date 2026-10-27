using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001FEA RID: 8170
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/LGUI.ENumberShowType")]
	public enum ENumberShowType : byte
	{
		// Token: 0x04010BB5 RID: 68533
		Interger,
		// Token: 0x04010BB6 RID: 68534
		OneDecimalPlace,
		// Token: 0x04010BB7 RID: 68535
		TwoDeciMalPlace,
		// Token: 0x04010BB8 RID: 68536
		ENumberShowType_MAX
	}
}
