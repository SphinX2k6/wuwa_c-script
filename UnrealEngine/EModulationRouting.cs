using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000AD7 RID: 2775
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EModulationRouting")]
	public enum EModulationRouting : byte
	{
		// Token: 0x04004AE9 RID: 19177
		Disable,
		// Token: 0x04004AEA RID: 19178
		Inherit,
		// Token: 0x04004AEB RID: 19179
		Override,
		// Token: 0x04004AEC RID: 19180
		EModulationRouting_MAX
	}
}
