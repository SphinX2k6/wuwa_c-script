using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002289 RID: 8841
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/MaterialBaking.EMaterialBakeMethod")]
	public enum EMaterialBakeMethod : byte
	{
		// Token: 0x04011F25 RID: 73509
		IndividualMaterial,
		// Token: 0x04011F26 RID: 73510
		AtlasMaterial,
		// Token: 0x04011F27 RID: 73511
		BinnedMaterial,
		// Token: 0x04011F28 RID: 73512
		EMaterialBakeMethod_MAX
	}
}
