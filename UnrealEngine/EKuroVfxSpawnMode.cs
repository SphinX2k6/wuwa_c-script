using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001F3D RID: 7997
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroVfxGardener.EKuroVfxSpawnMode")]
	public enum EKuroVfxSpawnMode : byte
	{
		// Token: 0x040106B8 RID: 67256
		RandomInBox,
		// Token: 0x040106B9 RID: 67257
		MeshMatch,
		// Token: 0x040106BA RID: 67258
		EKuroVfxSpawnMode_MAX
	}
}
