using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000BA3 RID: 2979
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.ETravelType")]
	public enum ETravelType
	{
		// Token: 0x04005209 RID: 21001
		TRAVEL_Absolute,
		// Token: 0x0400520A RID: 21002
		TRAVEL_Partial,
		// Token: 0x0400520B RID: 21003
		TRAVEL_Relative,
		// Token: 0x0400520C RID: 21004
		TRAVEL_MAX
	}
}
