using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000B5E RID: 2910
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EScreenOrientation")]
	public enum EScreenOrientation
	{
		// Token: 0x04005035 RID: 20533
		Unknown,
		// Token: 0x04005036 RID: 20534
		Portrait,
		// Token: 0x04005037 RID: 20535
		PortraitUpsideDown,
		// Token: 0x04005038 RID: 20536
		LandscapeLeft,
		// Token: 0x04005039 RID: 20537
		LandscapeRight,
		// Token: 0x0400503A RID: 20538
		FaceUp,
		// Token: 0x0400503B RID: 20539
		FaceDown,
		// Token: 0x0400503C RID: 20540
		EScreenOrientation_MAX
	}
}
