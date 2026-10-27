using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000AA2 RID: 2722
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.ELightDistanceCullType")]
	public enum ELightDistanceCullType
	{
		// Token: 0x04004925 RID: 18725
		NoDistanceCullType,
		// Token: 0x04004926 RID: 18726
		CustomDistanceCullType,
		// Token: 0x04004927 RID: 18727
		DistanceCullType1,
		// Token: 0x04004928 RID: 18728
		DistanceCullType2,
		// Token: 0x04004929 RID: 18729
		DistanceCullType3,
		// Token: 0x0400492A RID: 18730
		DistanceCullType4,
		// Token: 0x0400492B RID: 18731
		DistanceCullType5,
		// Token: 0x0400492C RID: 18732
		ELightDistanceCullType_MAX
	}
}
