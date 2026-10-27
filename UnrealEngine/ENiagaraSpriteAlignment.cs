using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002507 RID: 9479
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Niagara.ENiagaraSpriteAlignment")]
	public enum ENiagaraSpriteAlignment : byte
	{
		// Token: 0x04012E94 RID: 77460
		Unaligned,
		// Token: 0x04012E95 RID: 77461
		VelocityAligned,
		// Token: 0x04012E96 RID: 77462
		CustomAlignment,
		// Token: 0x04012E97 RID: 77463
		ENiagaraSpriteAlignment_MAX
	}
}
