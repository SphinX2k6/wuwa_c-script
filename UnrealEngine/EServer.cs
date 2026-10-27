using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020026B0 RID: 9904
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/RenderExporter.EServer")]
	public enum EServer : byte
	{
		// Token: 0x04013CC4 RID: 81092
		INTERNAL,
		// Token: 0x04013CC5 RID: 81093
		EXTERNAL,
		// Token: 0x04013CC6 RID: 81094
		CUSTOMIZE,
		// Token: 0x04013CC7 RID: 81095
		COUNT,
		// Token: 0x04013CC8 RID: 81096
		EServer_MAX
	}
}
