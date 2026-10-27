using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200278E RID: 10126
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/SimplygonUObjects.EGeometryDataFieldType")]
	public enum EGeometryDataFieldType : byte
	{
		// Token: 0x040149E0 RID: 84448
		Coords,
		// Token: 0x040149E1 RID: 84449
		TexCoords,
		// Token: 0x040149E2 RID: 84450
		Normals,
		// Token: 0x040149E3 RID: 84451
		Tangents,
		// Token: 0x040149E4 RID: 84452
		Bitangents,
		// Token: 0x040149E5 RID: 84453
		Colors,
		// Token: 0x040149E6 RID: 84454
		TriangleIds,
		// Token: 0x040149E7 RID: 84455
		MaterialIds,
		// Token: 0x040149E8 RID: 84456
		VertexIds,
		// Token: 0x040149E9 RID: 84457
		UserVertexField,
		// Token: 0x040149EA RID: 84458
		UserCornerField,
		// Token: 0x040149EB RID: 84459
		UserTriangleField,
		// Token: 0x040149EC RID: 84460
		CustomField,
		// Token: 0x040149ED RID: 84461
		EGeometryDataFieldType_MAX
	}
}
