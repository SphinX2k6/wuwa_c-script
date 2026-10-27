using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020022B7 RID: 8887
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/MeshBlend.EMeshBlendProcessStage")]
	public enum EMeshBlendProcessStage : byte
	{
		// Token: 0x0401204F RID: 73807
		FindDistance,
		// Token: 0x04012050 RID: 73808
		ProcessActors,
		// Token: 0x04012051 RID: 73809
		EMeshBlendProcessStage_MAX
	}
}
