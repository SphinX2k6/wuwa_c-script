using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000188 RID: 392
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AIModule.EEQSNormalizationType")]
	public enum EEQSNormalizationType : byte
	{
		// Token: 0x040006D4 RID: 1748
		Absolute,
		// Token: 0x040006D5 RID: 1749
		RelativeToScores,
		// Token: 0x040006D6 RID: 1750
		EEQSNormalizationType_MAX
	}
}
