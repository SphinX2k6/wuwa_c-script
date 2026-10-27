using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000ACD RID: 2765
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EMeshLODSelectionType")]
	public enum EMeshLODSelectionType : byte
	{
		// Token: 0x04004A99 RID: 19097
		AllLODs,
		// Token: 0x04004A9A RID: 19098
		SpecificLOD,
		// Token: 0x04004A9B RID: 19099
		CalculateLOD,
		// Token: 0x04004A9C RID: 19100
		LowestDetailLOD,
		// Token: 0x04004A9D RID: 19101
		EMeshLODSelectionType_MAX
	}
}
