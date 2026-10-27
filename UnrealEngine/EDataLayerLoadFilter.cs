using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000A3B RID: 2619
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EDataLayerLoadFilter")]
	public enum EDataLayerLoadFilter : byte
	{
		// Token: 0x04004612 RID: 17938
		None,
		// Token: 0x04004613 RID: 17939
		ClientOnly,
		// Token: 0x04004614 RID: 17940
		ServerOnly,
		// Token: 0x04004615 RID: 17941
		EDataLayerLoadFilter_MAX
	}
}
