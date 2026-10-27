using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200231A RID: 8986
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/MovieSceneTools.EThumbnailQuality")]
	public enum EThumbnailQuality : byte
	{
		// Token: 0x04012250 RID: 74320
		Draft,
		// Token: 0x04012251 RID: 74321
		Normal,
		// Token: 0x04012252 RID: 74322
		Best,
		// Token: 0x04012253 RID: 74323
		EThumbnailQuality_MAX
	}
}
