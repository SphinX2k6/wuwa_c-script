using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001E96 RID: 7830
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroUtility.EActorPartitionVolumeType")]
	public enum EActorPartitionVolumeType : byte
	{
		// Token: 0x040101E5 RID: 66021
		Reservation,
		// Token: 0x040101E6 RID: 66022
		Construction,
		// Token: 0x040101E7 RID: 66023
		Complete,
		// Token: 0x040101E8 RID: 66024
		EActorPartitionVolumeType_MAX
	}
}
