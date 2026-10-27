using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001425 RID: 5157
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/GeometryCollectionEngine.EGeometryCollectionDebugDrawActorHideGeometry")]
	public enum EGeometryCollectionDebugDrawActorHideGeometry : byte
	{
		// Token: 0x0400A0E2 RID: 41186
		HideNone,
		// Token: 0x0400A0E3 RID: 41187
		HideWithCollision,
		// Token: 0x0400A0E4 RID: 41188
		HideSelected,
		// Token: 0x0400A0E5 RID: 41189
		HideWholeCollection,
		// Token: 0x0400A0E6 RID: 41190
		HideAll,
		// Token: 0x0400A0E7 RID: 41191
		EGeometryCollectionDebugDrawActorHideGeometry_MAX
	}
}
