using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000ADA RID: 2778
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EMontagePlayReturnType")]
	public enum EMontagePlayReturnType : byte
	{
		// Token: 0x04004AF7 RID: 19191
		MontageLength,
		// Token: 0x04004AF8 RID: 19192
		Duration,
		// Token: 0x04004AF9 RID: 19193
		EMontagePlayReturnType_MAX
	}
}
