using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200225F RID: 8799
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/MagtModule.EMagtAPScenario")]
	public enum EMagtAPScenario : byte
	{
		// Token: 0x04011D81 RID: 73089
		ThermalNormal_G0,
		// Token: 0x04011D82 RID: 73090
		ThermalNormal_G1,
		// Token: 0x04011D83 RID: 73091
		ThermalSevere_G0,
		// Token: 0x04011D84 RID: 73092
		ThermalSevere_G1,
		// Token: 0x04011D85 RID: 73093
		CBound_G0,
		// Token: 0x04011D86 RID: 73094
		CBound_G1,
		// Token: 0x04011D87 RID: 73095
		GBound_G0,
		// Token: 0x04011D88 RID: 73096
		GBound_G1,
		// Token: 0x04011D89 RID: 73097
		Max,
		// Token: 0x04011D8A RID: 73098
		EMagtAPScenario_MAX
	}
}
