using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000205 RID: 517
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.ETravelType")]
	public enum ETravelType
	{
		// Token: 0x04000CFE RID: 3326
		TRAVEL_Absolute,
		// Token: 0x04000CFF RID: 3327
		TRAVEL_Partial,
		// Token: 0x04000D00 RID: 3328
		TRAVEL_Relative,
		// Token: 0x04000D01 RID: 3329
		TRAVEL_MAX
	}
}
