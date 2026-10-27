using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200291C RID: 10524
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/TLBSBase.EDawnMaterialBakeMethod")]
	public enum EDawnMaterialBakeMethod : byte
	{
		// Token: 0x0401567B RID: 87675
		IndividualMaterial,
		// Token: 0x0401567C RID: 87676
		AtlasMaterial,
		// Token: 0x0401567D RID: 87677
		BinnedMaterial,
		// Token: 0x0401567E RID: 87678
		EDawnMaterialBakeMethod_MAX
	}
}
