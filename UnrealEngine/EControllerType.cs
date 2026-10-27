using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002A5C RID: 10844
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/VREditor.EControllerType")]
	public enum EControllerType : byte
	{
		// Token: 0x04015F5F RID: 89951
		Laser,
		// Token: 0x04015F60 RID: 89952
		AssistingLaser,
		// Token: 0x04015F61 RID: 89953
		UI,
		// Token: 0x04015F62 RID: 89954
		Navigation,
		// Token: 0x04015F63 RID: 89955
		Unknown,
		// Token: 0x04015F64 RID: 89956
		EControllerType_MAX
	}
}
