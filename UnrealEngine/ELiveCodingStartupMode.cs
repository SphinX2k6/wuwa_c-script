using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020021EC RID: 8684
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/LiveCoding.ELiveCodingStartupMode")]
	public enum ELiveCodingStartupMode : byte
	{
		// Token: 0x04011ACC RID: 72396
		Automatic,
		// Token: 0x04011ACD RID: 72397
		AutomaticButHidden,
		// Token: 0x04011ACE RID: 72398
		Manual,
		// Token: 0x04011ACF RID: 72399
		ELiveCodingStartupMode_MAX
	}
}
