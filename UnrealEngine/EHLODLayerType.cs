using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000A80 RID: 2688
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EHLODLayerType")]
	public enum EHLODLayerType : byte
	{
		// Token: 0x04004812 RID: 18450
		Instancing,
		// Token: 0x04004813 RID: 18451
		MeshMerge,
		// Token: 0x04004814 RID: 18452
		MeshSimplify,
		// Token: 0x04004815 RID: 18453
		MeshApproximate,
		// Token: 0x04004816 RID: 18454
		Custom,
		// Token: 0x04004817 RID: 18455
		EHLODLayerType_MAX
	}
}
