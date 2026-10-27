using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200225D RID: 8797
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/MacTargetPlatform.EMacTargetArchitecture")]
	public enum EMacTargetArchitecture : byte
	{
		// Token: 0x04011D00 RID: 72960
		MacTargetArchitectureIntel,
		// Token: 0x04011D01 RID: 72961
		MacTargetArchitectureUniversal,
		// Token: 0x04011D02 RID: 72962
		MacTargetArchitectureAppleSil,
		// Token: 0x04011D03 RID: 72963
		EMacTargetArchitecture_MAX
	}
}
