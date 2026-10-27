using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020027A3 RID: 10147
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/SimplygonUObjects.EStopCondition")]
	public enum EStopCondition : byte
	{
		// Token: 0x04014A5A RID: 84570
		Any,
		// Token: 0x04014A5B RID: 84571
		All,
		// Token: 0x04014A5C RID: 84572
		EStopCondition_MAX
	}
}
