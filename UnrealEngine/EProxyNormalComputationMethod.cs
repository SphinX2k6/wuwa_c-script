using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000B23 RID: 2851
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EProxyNormalComputationMethod")]
	public enum EProxyNormalComputationMethod
	{
		// Token: 0x04004E06 RID: 19974
		AngleWeighted,
		// Token: 0x04004E07 RID: 19975
		AreaWeighted,
		// Token: 0x04004E08 RID: 19976
		EqualWeighted,
		// Token: 0x04004E09 RID: 19977
		EProxyNormalComputationMethod_MAX
	}
}
