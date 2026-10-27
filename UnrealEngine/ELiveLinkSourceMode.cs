using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020021EF RID: 8687
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/LiveLinkInterface.ELiveLinkSourceMode")]
	public enum ELiveLinkSourceMode : byte
	{
		// Token: 0x04011AD7 RID: 72407
		Latest,
		// Token: 0x04011AD8 RID: 72408
		EngineTime,
		// Token: 0x04011AD9 RID: 72409
		Timecode,
		// Token: 0x04011ADA RID: 72410
		ELiveLinkSourceMode_MAX
	}
}
