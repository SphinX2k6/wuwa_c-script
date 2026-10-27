using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000501 RID: 1281
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/ControlRig.ERigUnitVisualDebugPointMode")]
	public enum ERigUnitVisualDebugPointMode : byte
	{
		// Token: 0x040020AA RID: 8362
		Point,
		// Token: 0x040020AB RID: 8363
		Vector,
		// Token: 0x040020AC RID: 8364
		Max,
		// Token: 0x040020AD RID: 8365
		ERigUnitVisualDebugPointMode_MAX
	}
}
