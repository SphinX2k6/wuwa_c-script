using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000B07 RID: 2823
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EParticleAxisLock")]
	public enum EParticleAxisLock
	{
		// Token: 0x04004D55 RID: 19797
		EPAL_NONE,
		// Token: 0x04004D56 RID: 19798
		EPAL_X,
		// Token: 0x04004D57 RID: 19799
		EPAL_Y,
		// Token: 0x04004D58 RID: 19800
		EPAL_Z,
		// Token: 0x04004D59 RID: 19801
		EPAL_NEGATIVE_X,
		// Token: 0x04004D5A RID: 19802
		EPAL_NEGATIVE_Y,
		// Token: 0x04004D5B RID: 19803
		EPAL_NEGATIVE_Z,
		// Token: 0x04004D5C RID: 19804
		EPAL_ROTATE_X,
		// Token: 0x04004D5D RID: 19805
		EPAL_ROTATE_Y,
		// Token: 0x04004D5E RID: 19806
		EPAL_ROTATE_Z,
		// Token: 0x04004D5F RID: 19807
		EPAL_MAX
	}
}
