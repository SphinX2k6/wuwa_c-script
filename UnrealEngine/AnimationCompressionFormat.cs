using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020007DE RID: 2014
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.AnimationCompressionFormat")]
	public enum AnimationCompressionFormat
	{
		// Token: 0x040033A4 RID: 13220
		ACF_None,
		// Token: 0x040033A5 RID: 13221
		ACF_Float96NoW,
		// Token: 0x040033A6 RID: 13222
		ACF_Fixed48NoW,
		// Token: 0x040033A7 RID: 13223
		ACF_IntervalFixed32NoW,
		// Token: 0x040033A8 RID: 13224
		ACF_Fixed32NoW,
		// Token: 0x040033A9 RID: 13225
		ACF_Float32NoW,
		// Token: 0x040033AA RID: 13226
		ACF_Identity,
		// Token: 0x040033AB RID: 13227
		ACF_MAX
	}
}
