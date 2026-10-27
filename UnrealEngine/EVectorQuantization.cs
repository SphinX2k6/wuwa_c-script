using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000BAC RID: 2988
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EVectorQuantization")]
	public enum EVectorQuantization : byte
	{
		// Token: 0x0400523F RID: 21055
		RoundWholeNumber,
		// Token: 0x04005240 RID: 21056
		RoundOneDecimal,
		// Token: 0x04005241 RID: 21057
		RoundTwoDecimals,
		// Token: 0x04005242 RID: 21058
		EVectorQuantization_MAX
	}
}
