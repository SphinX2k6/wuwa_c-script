using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000B17 RID: 2839
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EParticleUVFlipMode")]
	public enum EParticleUVFlipMode : byte
	{
		// Token: 0x04004DC0 RID: 19904
		None,
		// Token: 0x04004DC1 RID: 19905
		FlipUV,
		// Token: 0x04004DC2 RID: 19906
		FlipUOnly,
		// Token: 0x04004DC3 RID: 19907
		FlipVOnly,
		// Token: 0x04004DC4 RID: 19908
		RandomFlipUV,
		// Token: 0x04004DC5 RID: 19909
		RandomFlipUOnly,
		// Token: 0x04004DC6 RID: 19910
		RandomFlipVOnly,
		// Token: 0x04004DC7 RID: 19911
		RandomFlipUVIndependent,
		// Token: 0x04004DC8 RID: 19912
		EParticleUVFlipMode_MAX
	}
}
