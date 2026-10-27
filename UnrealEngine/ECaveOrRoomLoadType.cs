using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000A25 RID: 2597
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.ECaveOrRoomLoadType")]
	public enum ECaveOrRoomLoadType : byte
	{
		// Token: 0x0400456F RID: 17775
		HLODGridActor,
		// Token: 0x04004570 RID: 17776
		HLODActor,
		// Token: 0x04004571 RID: 17777
		HLODActorAndGrid,
		// Token: 0x04004572 RID: 17778
		HLODGridActorNoLoadOverride,
		// Token: 0x04004573 RID: 17779
		HLODActorNoLoadOverride,
		// Token: 0x04004574 RID: 17780
		HLODActorAndGridNoLoadOverride,
		// Token: 0x04004575 RID: 17781
		DoNothing,
		// Token: 0x04004576 RID: 17782
		ECaveOrRoomLoadType_MAX
	}
}
