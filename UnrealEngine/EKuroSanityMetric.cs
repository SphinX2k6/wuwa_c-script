using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020015EF RID: 5615
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroActorFolderCheck.EKuroSanityMetric")]
	public enum EKuroSanityMetric : byte
	{
		// Token: 0x0400B011 RID: 45073
		MeshLOD0VertexCount,
		// Token: 0x0400B012 RID: 45074
		MeshLOD0TriangleCount,
		// Token: 0x0400B013 RID: 45075
		MeshUVChannelCount,
		// Token: 0x0400B014 RID: 45076
		MeshLODCount,
		// Token: 0x0400B015 RID: 45077
		TextureMaxSize,
		// Token: 0x0400B016 RID: 45078
		TextureNumMips,
		// Token: 0x0400B017 RID: 45079
		EKuroSanityMetric_MAX
	}
}
