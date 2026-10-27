using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020026AF RID: 9903
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/RenderExporter.ERETaskType")]
	public enum ERETaskType : byte
	{
		// Token: 0x04013CBD RID: 81085
		Task_None,
		// Token: 0x04013CBE RID: 81086
		Task_LOD,
		// Token: 0x04013CBF RID: 81087
		Task_Plant,
		// Token: 0x04013CC0 RID: 81088
		Task_HLOD = 5,
		// Token: 0x04013CC1 RID: 81089
		COUNT,
		// Token: 0x04013CC2 RID: 81090
		ERETaskType_MAX
	}
}
