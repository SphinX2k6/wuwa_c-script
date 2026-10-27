using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200278D RID: 10125
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/SimplygonUObjects.EFlipBackfacingMode")]
	public enum EFlipBackfacingMode : byte
	{
		// Token: 0x040149DC RID: 84444
		PixelNormal,
		// Token: 0x040149DD RID: 84445
		FaceNormal,
		// Token: 0x040149DE RID: 84446
		EFlipBackfacingMode_MAX
	}
}
