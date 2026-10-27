using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001A10 RID: 6672
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroPackagingEd.EKuroChunkDependencyExtract")]
	public enum EKuroChunkDependencyExtract : byte
	{
		// Token: 0x0400D585 RID: 54661
		NotExtract,
		// Token: 0x0400D586 RID: 54662
		HardExtract,
		// Token: 0x0400D587 RID: 54663
		SoftExtract,
		// Token: 0x0400D588 RID: 54664
		Assets,
		// Token: 0x0400D589 RID: 54665
		EKuroChunkDependencyExtract_MAX
	}
}
