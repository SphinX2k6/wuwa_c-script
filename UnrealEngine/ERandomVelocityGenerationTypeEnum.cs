using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000445 RID: 1093
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/ChaosNiagara.ERandomVelocityGenerationTypeEnum")]
	public enum ERandomVelocityGenerationTypeEnum : byte
	{
		// Token: 0x04001B00 RID: 6912
		ChaosNiagara_RandomVelocityGenerationType_RandomDistribution,
		// Token: 0x04001B01 RID: 6913
		ChaosNiagara_RandomVelocityGenerationType_RandomDistributionWithStreamers,
		// Token: 0x04001B02 RID: 6914
		ChaosNiagara_RandomVelocityGenerationType_CollisionNormalBased,
		// Token: 0x04001B03 RID: 6915
		ChaosNiagara_Max,
		// Token: 0x04001B04 RID: 6916
		ChaosNiagara_MAX
	}
}
