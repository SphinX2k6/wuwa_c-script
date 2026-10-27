using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000AE7 RID: 2791
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.ENavMeshTargetPlatform")]
	public enum ENavMeshTargetPlatform : byte
	{
		// Token: 0x04004B40 RID: 19264
		Default,
		// Token: 0x04004B41 RID: 19265
		Desktop,
		// Token: 0x04004B42 RID: 19266
		Mobile,
		// Token: 0x04004B43 RID: 19267
		ENavMeshTargetPlatform_MAX
	}
}
