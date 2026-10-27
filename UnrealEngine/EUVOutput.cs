using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000BA9 RID: 2985
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EUVOutput")]
	public enum EUVOutput : byte
	{
		// Token: 0x04005230 RID: 21040
		DoNotOutputChannel,
		// Token: 0x04005231 RID: 21041
		OutputChannel,
		// Token: 0x04005232 RID: 21042
		EUVOutput_MAX
	}
}
