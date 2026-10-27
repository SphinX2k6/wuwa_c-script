using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000277 RID: 631
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AkAudio.EAkFitToGeometryMode")]
	public enum EAkFitToGeometryMode : uint
	{
		// Token: 0x04000D07 RID: 3335
		OrientedBox,
		// Token: 0x04000D08 RID: 3336
		AlignedBox,
		// Token: 0x04000D09 RID: 3337
		ConvexPolyhedron,
		// Token: 0x04000D0A RID: 3338
		EAkFitToGeometryMode_MAX
	}
}
