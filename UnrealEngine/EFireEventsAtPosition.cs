using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200231F RID: 8991
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/MovieSceneTracks.EFireEventsAtPosition")]
	public enum EFireEventsAtPosition : byte
	{
		// Token: 0x04012281 RID: 74369
		AtStartOfEvaluation,
		// Token: 0x04012282 RID: 74370
		AtEndOfEvaluation,
		// Token: 0x04012283 RID: 74371
		AfterSpawn,
		// Token: 0x04012284 RID: 74372
		EFireEventsAtPosition_MAX
	}
}
