using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000BA7 RID: 2983
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EUseFullPrecisionPlatform")]
	public enum EUseFullPrecisionPlatform
	{
		// Token: 0x04005224 RID: 21028
		FP_Default,
		// Token: 0x04005225 RID: 21029
		FP_Android,
		// Token: 0x04005226 RID: 21030
		FP_IOS,
		// Token: 0x04005227 RID: 21031
		FP_OpenHarmony,
		// Token: 0x04005228 RID: 21032
		FP_MAX
	}
}
